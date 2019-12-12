using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4jClient;
using Neo4jClient.Cypher;

namespace EvidencijaKvarovaIPopravki.DomainModel
{
    public class DataSet
    {
        private static DataSet _instance = null;
        private static GraphClient client;
        public Osoba PrijavljenKorisnik { get; set; }
        public static DataSet Instace
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DataSet();
                }
                return _instance;
            }
        }
        private DataSet()
        {
            PrijavljenKorisnik = null;
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "admin", "admin");
            try
            {
                client.Connect();
            }
            catch (Exception exc)
            {
                
            }

        }
        public Korisnik vratiKorisnika(int id)
        {
            try
            {

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(" + id + ") match (n)-[r:MOJI_PODACI]->(podaci)-[a:NALAZI_SE]->(adresa) return adresa",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                Adresa adresa = ((IRawGraphClient)client).ExecuteGetCypherResults<Adresa>(query).ToList()[0];

                query = new Neo4jClient.Cypher.CypherQuery("start n=node(" + id + ") match (n)-[r:MOJI_PODACI]->(podaci) return podaci",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                LicniPodaci podaci = ((IRawGraphClient)client).ExecuteGetCypherResults<LicniPodaci>(query).ToList()[0];
                podaci.Adresa = adresa;

                query = new Neo4jClient.Cypher.CypherQuery("start n=node(" + id + ") match (n)-[r:MOJA_AUTENTIFIKACIJA]->(auth) return auth",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                Autentifikacija auth = ((IRawGraphClient)client).ExecuteGetCypherResults<Autentifikacija>(query).ToList()[0];

                List<Test> users = ((IRawGraphClient)client).ExecuteGetCypherResults<Test>(query).ToList();

                query = new Neo4jClient.Cypher.CypherQuery("start n=node(" + id + ") match (n)<-[k:IMA_KVAR]-(kvar)<-[r:U_RADIONICI]-(radionica) return radionica",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                List<Radionica> radionice = ((IRawGraphClient)client).ExecuteGetCypherResults<Radionica>(query).ToList();

                query = new Neo4jClient.Cypher.CypherQuery("start n=node(" + id + ") match (n)<-[k:IMA_KVAR]-(kvar) return kvar",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                List<Kvar> kvarovi = ((IRawGraphClient)client).ExecuteGetCypherResults<Kvar>(query).ToList();

                Korisnik k = new Korisnik();
                k.authPodaci = auth;
                k.podaci = podaci;
                int i = 0;
                foreach (Kvar kv in kvarovi)
                {
                    kv.Radionica = radionice[i];
                    k.kvarovi.Add(kv);
                    i++;
                }

                return k;
            }
            catch(Exception e)
            {
                return null;
            }

        }

        public List<Kvar> vratiSveKvarove()
        {
            try
            {
                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[k:IMA_KVAR]-(kvar) return kvar",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                List<Kvar> kvarovi = ((IRawGraphClient)client).ExecuteGetCypherResults<Kvar>(query).ToList();
                return kvarovi;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public bool dodajKorisnika(Korisnik k)
        {
            try
            {

                if (!dodajLicnePodatke(k.podaci))
                    throw new Exception("Pogresni podaci");
                if (!dodajAutentifikaciju(k.authPodaci))
                    throw new Exception("Pogresni auth podaci");


                var query = new Neo4jClient.Cypher.CypherQuery(
                    "MATCH (Auth1:Autentifikacija {email : '"+k.authPodaci.email+"'}) " +
                    "MATCH (LP1:LicniPodaci {ime:'" + k.podaci.ime + "',prezime:'" + k.podaci.prezime + "',datumRodjenja:'" + k.podaci.datumRodjenja + "'}) " +
                    "CREATE(Korisnik1: Korisnik{ }) " +
                    "CREATE(Korisnik1) -[a: MOJA_AUTENTIFIKACIJA]->(Auth1) " +
                    "CREATE(Korisnik1) -[p: MOJI_PODACI]->(LP1) RETURN Korisnik1 ",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteGetCypherResults<Korisnik>(query);

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool dodajAdresu(Adresa a)
        {
            try
            {
                var query = new Neo4jClient.Cypher.CypherQuery(" CREATE(Addr1: Adresa{ UlicaIBroj: '" + a.UlicaIBroj + "', Grad: '" + a.Grad + "' }) RETURN Addr1",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteGetCypherResults<Adresa>(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool dodajLicnePodatke(LicniPodaci p)
        {
            try
            {
                dodajAdresu(p.Adresa);
               
                var query = new Neo4jClient.Cypher.CypherQuery(
                    "MATCH(Addr1:Adresa {UlicaIBroj: '" + p.Adresa.UlicaIBroj + "'})" +
                    "CREATE(LP1: LicniPodaci{ ime: '" +p.ime+"',prezime: '"+p.prezime+"'," +
                    "telefon: '"+p.telefon+"',datumRodjenja: '"+p.datumRodjenja+"'})" +
                    " CREATE (LP1)-[r:NALAZI_SE]->(Addr1) RETURN LP1",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteGetCypherResults<LicniPodaci>(query);

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public string proveriDaLiPostoji(string email, string korisnickoIme)
        {
            try
            {
                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n {korisnickoIme: '" + korisnickoIme + "'}) return n",
                    new Dictionary<string, object>(), CypherResultMode.Set);
                List<Autentifikacija> auth = ((IRawGraphClient)client).ExecuteGetCypherResults<Autentifikacija>(query).ToList();

                if(auth.Count() > 0)
                {
                    return "Korisnicko ime je zauzeto!";
                }
                else
                {
                    query = new Neo4jClient.Cypher.CypherQuery("MATCH (n {email: '" + email + "'}) return n",
                        new Dictionary<string, object>(), CypherResultMode.Set);
                    List<Autentifikacija> auth2 = ((IRawGraphClient)client).ExecuteGetCypherResults<Autentifikacija>(query).ToList();
                    if(auth2.Count() > 0)
                    {
                        return "Korisnik s tim email-om je vec kreiran!";
                    }
                    else
                    {
                        return "Provera uspesno prosla!";
                    }
                }

                
            }
            catch(Exception e)
            {
                return "Greska!";
            }
        }

        public bool dodajAutentifikaciju(Autentifikacija a)
        {
            try
            {
                var query = new Neo4jClient.Cypher.CypherQuery(
                    "CREATE(Auth1: Autentifikacija{ korisnickoIme: '"+a.korisnickoIme+"',email: '"+a.email+"',sifra: '"+a.sifra+"'}) RETURN Auth1",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteGetCypherResults<Autentifikacija>(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public String prijavaKorisnika(Osoba o)
        {
            try
            {
                // korisnik je uneo mail za prijavljivanje
                if (o.authPodaci.email != null)
                {
                    var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n {email: '" + o.authPodaci.email + "'}) return n",
                        new Dictionary<string, object>(), CypherResultMode.Set);
                    List<Autentifikacija> auth = ((IRawGraphClient)client).ExecuteGetCypherResults<Autentifikacija>(query).ToList();
                    if (auth.Count() == 0)
                    {

                        // korisnik je uneo korisnicko ime za prijavljivanje
                        if (o.authPodaci.korisnickoIme != null)
                        {
                            query = new Neo4jClient.Cypher.CypherQuery("MATCH (n {korisnickoIme: '" + o.authPodaci.korisnickoIme + "'}) return n",
                                new Dictionary<string, object>(), CypherResultMode.Set);
                            auth = ((IRawGraphClient)client).ExecuteGetCypherResults<Autentifikacija>(query).ToList();
                            if (auth.Count() == 0)
                            {
                                return "Nepostojece korisnicko ime !";
                            }
                            else
                            {
                                if (auth[0].sifra == o.authPodaci.sifra)
                                {
                                    query = new Neo4jClient.Cypher.CypherQuery(
                                        "MATCH (n {korisnickoIme: '" + o.authPodaci.korisnickoIme + "'})<-[:MOJA_AUTENTIFIKACIJA]-(m) return ID(m)",
                                        new Dictionary<string, object>(), CypherResultMode.Set);
                                    int id = ((IRawGraphClient)client).ExecuteGetCypherResults<int>(query).First();
                                    PrijavljenKorisnik = vratiKorisnika(id);
                                    return "Uspesno prijavljivanje !";
                                }
                                else
                                {
                                    return "Pogresna sifra za dato korisnicko ime !";
                                }
                            }
                        }
                        return "Nepostojeca email adresa !";
                    }
                    else
                    {
                        if (auth[0].sifra == o.authPodaci.sifra)
                        {
                            query = new Neo4jClient.Cypher.CypherQuery(
                                        "MATCH (n {email: '" + o.authPodaci.email + "'})<-[:MOJA_AUTENTIFIKACIJA]-(m) return ID(m)",
                                new Dictionary<string,object>(),CypherResultMode.Set);
                            int id = ((IRawGraphClient)client).ExecuteGetCypherResults<int>(query).First();
                            PrijavljenKorisnik = vratiKorisnika(id);
                            return "Uspesno prijavljivanje !";
                        }
                        else
                        {
                            return "Pogresna sifra za datu email adresu !";
                        }
                    }
                }
                return "Podaci nisu prosledjeni !";

            }
            catch(Exception e)
            {
                return "Greska priliko izvrsavanja upita !";
            }
        }
    }
}
