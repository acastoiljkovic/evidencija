using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4jClient;
using Neo4jClient.Cypher;

// TODO :
// 1. Da se disableju dugmici u zavisnosti od toga ko je prijavljen
//
//  ------------------ POCETNA ---------------------
//  - filter za kvarove i za radionice
//  - pametno trazenje, dok se kuca on da trazi ( trazenje u dataGrdiView , a ne iz baze )
//  - kada si prijavljen kao zaposleni umesto taba radionice napraviti tab nesvrstani kvarovi koji izlistava sve kvarove koji nemaju radionice
//  - selekcijom na neki kvar izlazi forma dodaj kvar koja se trenutno nalazi na dugmetu dodaj kvar
//  - ukoliko se doda kvar se dodaje radionici i zaposlenom koji ga je dodao radionici
//
//  ------------------- PRIJAVI KVAR -------
//  - selekcija da li korisnik oce da bira radionicu ili da radionice biraju njega
//  - ukoliko odabere radionicu skripta pravi odmah vezu izmedju kvara i radionice  
//
//  ------------------- RADIONICA ------------
//  - u radionicu treba lista kvarova koja nema zaposlenog da radi na kvaru
//  - lista kvarova koji se trenutno popravljaju
//  - pametno bi bilo da se izbace delovi !!!!!
//  - dugme i forma za izmeni radionicus
//  - funkcija vratiRadionicuNaziv da se sredi da vraca i kvarove radionice i delove



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

        public bool dodajKvarKorisniku(Kvar k)
        {
            try
            {
                String komentari = "";
                foreach(String kom in k.komentari)
                {
                    komentari += "'" + kom + "'";
                }

                var query = new Neo4jClient.Cypher.CypherQuery(
                    "match (n:Korisnik)-[a:MOJA_AUTENTIFIKACIJA]->(auth:Autentifikacija{korisnickoIme:'"+PrijavljenKorisnik.authPodaci.korisnickoIme+"'})" +
                    "CREATE(k:Kvar{naziv:'"+k.naziv+"',komentar:[" +
                    komentari +
                    "]})" +
                    "CREATE(n)-[kr:IMA_KVAR]->(k) RETURN n", new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteGetCypherResults<Osoba>(query);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }

        }
        public Osoba vratiOsobu(int id)
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


                query = new Neo4jClient.Cypher.CypherQuery("start n=node(" + id + ") match (n)<-[k:IMA_KVAR]-(kvar)<-[r:U_RADIONICI]-(radionica) return radionica",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                List<Radionica> radionice = ((IRawGraphClient)client).ExecuteGetCypherResults<Radionica>(query).ToList();

                query = new Neo4jClient.Cypher.CypherQuery("start n=node(" + id + ") match (n)<-[k:IMA_KVAR]-(kvar) return kvar",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                List<Kvar> kvarovi = ((IRawGraphClient)client).ExecuteGetCypherResults<Kvar>(query).ToList();

                query = new Neo4jClient.Cypher.CypherQuery("start n=node(" + id + ") match (n) return n",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                Osoba k = ((IRawGraphClient)client).ExecuteGetCypherResults<Osoba>(query).ToList()[0];

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
                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[k:IMA_KVAR]->(kvar) return kvar",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                List<Kvar> kvarovi = ((IRawGraphClient)client).ExecuteGetCypherResults<Kvar>(query).ToList();
                return kvarovi;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public List<Radionica> vratiSveRadionice()
        {
            try
            {
                //verovatno moze optimalnije
                List<Radionica> radionice = new List<Radionica>();
                var query = new Neo4jClient.Cypher.CypherQuery("match (r:Radionica)-[a:NALAZI_SE]->(adresa) return r",
                                                new Dictionary<string, object>(), CypherResultMode.Set);
                List<Radionica> radioniceList = ((IRawGraphClient)client).ExecuteGetCypherResults<Radionica>(query).ToList();
                
                foreach (Radionica i in radioniceList)
                {
                    query = new Neo4jClient.Cypher.CypherQuery("match (r:Radionica {naziv: '"+i.naziv+"'})-[a:NALAZI_SE]->(adresa) return adresa",
                                new Dictionary<string, object>(), CypherResultMode.Set);
                    i.Adresa = ((IRawGraphClient)client).ExecuteGetCypherResults<Adresa>(query).ToList()[0];
                    radionice.Add(i);
                }

                return radionice;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public bool RadnikNeRadiViseUTrenutnojRadionici()
        {
            try
            {
                var query = new Neo4jClient.Cypher.CypherQuery("match(a:Autentifikacija{korisnickoIme: '" + PrijavljenKorisnik.authPodaci.korisnickoIme + "'})<-[m:MOJA_AUTENTIFIKACIJA]-(korisnik)-[r:RADI_U]->(radionica) delete r",
                    new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteCypher(query);

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool PrijaviRadnikaRadionica(string radionicaNaziv)
        {
            try
            {
                var query = new Neo4jClient.Cypher.CypherQuery(
                "match(a:Autentifikacija{korisnickoIme: '" + PrijavljenKorisnik.authPodaci.korisnickoIme + "'})<-[m:MOJA_AUTENTIFIKACIJA]-(korisnik) " +
                "match (rad1:Radionica {naziv : '" + radionicaNaziv + "'}) " +
                "create(korisnik) -[ru:RADI_U]->(rad1) RETURN rad1 ",
                    new Dictionary<string, object>(), CypherResultMode.Set);
                List<Radionica> r = ((IRawGraphClient)client).ExecuteGetCypherResults<Radionica>(query).ToList();

                if (r[0].naziv.Equals(radionicaNaziv))
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string IzmeniRadnikovuRadionicu(string radionica)
        {
            try
            {
                if (RadnikNeRadiViseUTrenutnojRadionici() && PrijaviRadnikaRadionica(radionica))
                    return "Uspesna izmena radnikove radionice!";
                else
                    return "Neuspesna izmena radnikove radionice!";
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string IzmeniKorisnikovProfil(string ime, string prezime, string email, string telefon, string datumRodjenja, string grad, string ulicaIBroj, string radionica)
        {
            try
            {
                Radionica r = vratiRadionicuRadnik(PrijavljenKorisnik);
                if (PrijavljenKorisnik.indikator.Equals("zaposleni") && !r.naziv.Equals(radionica) && !IzmeniRadnikovuRadionicu(radionica).Equals("Uspesna izmena radnikove radionice!"))
                {
                    return "Neuspesna izmena radnikove radionice!";
                }
                if (IzmeniAutentifikaciju(email).Equals("Uspesno promenjen email!"))
                {
                    if (IzmeniKorisnikovePodatke(ime, prezime, telefon, grad, ulicaIBroj, datumRodjenja).Equals("Uspesno promenjeni podaci!"))
                        return "Uspesna izmena profila!";
                    else
                        return "Neuspesna izmena licnih podataka, promena autentifikacije uspesna!";
                }
                else
                {
                    return IzmeniAutentifikaciju(email);
                }
            }
            catch(Exception e)
            {
                return "Greska";
            }
        }

        public string IzmeniAutentifikaciju(string email)
        {
            try
            {
                if (!proveraDaLiPostojiEmail(email))
                {
                    var query = new Neo4jClient.Cypher.CypherQuery("match(k:Korisnik)-[a:MOJA_AUTENTIFIKACIJA]->(auth) where (auth.korisnickoIme = '" + PrijavljenKorisnik.authPodaci.korisnickoIme + "') set auth.email = '" + email + "' return auth",
                        new Dictionary<string, object>(), CypherResultMode.Set);
                    List<Autentifikacija> a = ((IRawGraphClient)client).ExecuteGetCypherResults<Autentifikacija>(query).ToList();
                    
                    if (a[0].email.Equals(email))
                        return "Uspesno promenjen email!";
                    else
                        return "Neuspesna promena email-a!";
                }
                else
                {
                    if (!PrijavljenKorisnik.authPodaci.email.Equals(email))
                        return "Nalog s tim email-om je vec kreiran!";
                    else
                        return "Uspesno promenjen email!";
                    //ne menjamo stvarno email, ali vracamo ovu proveru, zbog dalje provere
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string IzmeniAdresu(string grad, string ulicaIBroj)
        {
            try
            {
                var query = new Neo4jClient.Cypher.CypherQuery("match(lp:LicniPodaci)-[a:NALAZI_SE]->(adresa) where (lp.telefon ='" + PrijavljenKorisnik.podaci.telefon + "') set adresa.Grad='" + grad + "', adresa.UlicaIBroj = '" + ulicaIBroj + "' return adresa",
                    new Dictionary<string, object>(), CypherResultMode.Set);
                List<Adresa> a = ((IRawGraphClient)client).ExecuteGetCypherResults<Adresa>(query).ToList();

                if (a[0].Grad.Equals(grad) && a[0].UlicaIBroj.Equals(ulicaIBroj))
                    return "Uspesno!";
                else
                    return "Neuspesna promena adrese!";
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public string IzmenaSifre(string stara, string nova, string potvrdaNove)
        {
            try
            {
                if(!PrijavljenKorisnik.authPodaci.sifra.Equals(stara))
                {
                    return "Uneli ste pogresnu postojecu sifru!";
                }
                else if(!nova.Equals(potvrdaNove))
                {
                    return "Nova sifra i njena potvrda se ne poklapaju!";
                }
                else
                {
                    var query = new Neo4jClient.Cypher.CypherQuery("match(k:Korisnik)-[a:MOJA_AUTENTIFIKACIJA]->(auth) where (auth.korisnickoIme = '" + PrijavljenKorisnik.authPodaci.korisnickoIme + "') set auth.sifra = '" + nova + "' return auth",
                        new Dictionary<string, object>(), CypherResultMode.Set);
                    List<Autentifikacija> a = ((IRawGraphClient)client).ExecuteGetCypherResults<Autentifikacija>(query).ToList();
                    
                    if (a[0].sifra.Equals(nova))
                        return "Uspesno promenjena sifra!";
                    else
                        return "Neuspesna promena sifre!";
                }

            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string IzmeniKorisnikovePodatke(string ime, string prezime, string telefon, string grad, string ulicaIBroj, string datumRodjenja)
        {
            try
            {
                if (IzmeniAdresu(grad, ulicaIBroj).Equals("Uspesno!"))
                {
                    if (!proveraDaLiPostojiTelefon(telefon) || PrijavljenKorisnik.podaci.telefon.Equals(telefon))
                    {
                        var query = new Neo4jClient.Cypher.CypherQuery("match(k:Korisnik)-[p:MOJI_PODACI]->(licni) where (licni.telefon = '" + PrijavljenKorisnik.podaci.telefon + "') set licni.ime = '" + ime + "', licni.prezime = '" + prezime + "', licni.Grad = '" + grad + "', licni.datumRodjenja = '" + datumRodjenja + "' return licni",
                                new Dictionary<string, object>(), CypherResultMode.Set);
                        List<LicniPodaci> lp = ((IRawGraphClient)client).ExecuteGetCypherResults<LicniPodaci>(query).ToList();

                        if (lp[0].ime.Equals(ime) && lp[0].prezime.Equals(prezime) && lp[0].telefon.Equals(telefon) && lp[0].datumRodjenja.Equals(datumRodjenja))
                            return "Uspesno promenjeni podaci!";
                        else
                            return "Neuspesna promena licnih podataka!";
                    }
                    else
                    {
                        return "Kreiran je nalog s tim brojem telefona!";
                    }
                }
                else
                {
                    return "Neuspesna promena adrese!";
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Radionica vratiRadionicuRadnik(Osoba r)
        {
            try
            {
                var query = new Neo4jClient.Cypher.CypherQuery("match (r:Zaposleni)-[a:MOJA_AUTENTIFIKACIJA]->(auth)" +
                    " where (auth.korisnickoIme = '"+r.authPodaci.korisnickoIme+"' ) " +
                    "match (r)-[RADI_U]->(radionica) return radionica", new Dictionary<string,object>(),CypherResultMode.Set);
                List<Radionica> rad = ((IRawGraphClient)client).ExecuteGetCypherResults<Radionica>(query).ToList();
                foreach(Radionica ra in rad){
                    if (ra.naziv != null)
                        return vratiRadionicuNaziv(ra.naziv);
                }
                return rad[0];
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public Radionica vratiRadionicuNaziv(String naziv)
        {
            try
            {
                var query = new Neo4jClient.Cypher.CypherQuery("match (r:Radionica {naziv: '"+naziv+"'}) return r",
                    new Dictionary<string, object>(), CypherResultMode.Set);
                Radionica rad = ((IRawGraphClient)client).ExecuteGetCypherResults<Radionica>(query).ToList()[0];

                query = new Neo4jClient.Cypher.CypherQuery("match (r:Radionica {naziv: '" + naziv + "'})-[NALAZI_SE]->(adr) return adr",
                    new Dictionary<string, object>(), CypherResultMode.Set);
                Adresa adr = ((IRawGraphClient)client).ExecuteGetCypherResults<Adresa>(query).ToList()[0];
                rad.Adresa = adr;
                return rad;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool dodajZaposlenog(Osoba z, String rNaziv)
        {
            try
            {
                if (!dodajLicnePodatke(z.podaci))
                    throw new Exception("Pogresni podaci");
                if (!dodajAutentifikaciju(z.authPodaci))
                    throw new Exception("Pogresni auth podaci");


                var query = new Neo4jClient.Cypher.CypherQuery(
                    "MATCH (Auth1:Autentifikacija {email : '" + z.authPodaci.email + "'}) " +
                    "MATCH (LP1:LicniPodaci {ime:'" + z.podaci.ime + "',prezime:'" + z.podaci.prezime + "',datumRodjenja:'" + z.podaci.datumRodjenja + "'}) " +
                    "MATCH (Rad1:Radionica {naziv : '" + rNaziv + "'}) " +
                    "CREATE(Zaposleni1: Zaposleni{indikator:'" + z.indikator + "' }) " +
                    "CREATE(Zaposleni1) -[a: MOJA_AUTENTIFIKACIJA]->(Auth1) " +
                    "CREATE(Zaposleni1) -[p: MOJI_PODACI]->(LP1) " +
                    "CREATE(Zaposleni1) -[r: RADI_U]->(Rad1) RETURN Zaposleni1 ",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteGetCypherResults<Osoba>(query);

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool dodajKorisnika(Osoba k)
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
                    "CREATE(Korisnik1: Korisnik{indikator:'" + k.indikator +"' }) " +
                    "CREATE(Korisnik1) -[a: MOJA_AUTENTIFIKACIJA]->(Auth1) " +
                    "CREATE(Korisnik1) -[p: MOJI_PODACI]->(LP1) RETURN Korisnik1 ",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteGetCypherResults<Osoba>(query);

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

        public bool dodajRadionicu(Radionica r)
        {
            try
            {
                dodajAdresu(r.Adresa);

                var query = new Neo4jClient.Cypher.CypherQuery(
                    "MATCH(Addr1:Adresa {UlicaIBroj: '" + r.Adresa.UlicaIBroj + "'})" +
                    "CREATE(R1: Radionica{ naziv: '" + r.naziv + "'})" +
                    " CREATE (R1)-[r:NALAZI_SE]->(Addr1) RETURN R1",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteGetCypherResults<Radionica>(query);

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool dodajAutentifikaciju(Autentifikacija a)
        {
            try
            {
                var query = new Neo4jClient.Cypher.CypherQuery(
                    "CREATE(Auth1: Autentifikacija{ korisnickoIme: '" + a.korisnickoIme + "',email: '" + a.email + "',sifra: '" + a.sifra + "'}) RETURN Auth1",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteGetCypherResults<Autentifikacija>(query);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool proveraDaLiPostojiKorisnickoIme(string korisnickoIme)
        {
            try
            {
                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n {korisnickoIme: '" + korisnickoIme + "'}) return n",
                    new Dictionary<string, object>(), CypherResultMode.Set);
                List<Autentifikacija> auth = ((IRawGraphClient)client).ExecuteGetCypherResults<Autentifikacija>(query).ToList();

                if (auth.Count() > 0)
                    return true;
                else
                    return false;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool proveraDaLiPostojiEmail(string email)
        {
            try
            {
                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n {email: '" + email + "'}) return n",
                        new Dictionary<string, object>(), CypherResultMode.Set);
                List<Autentifikacija> auth = ((IRawGraphClient)client).ExecuteGetCypherResults<Autentifikacija>(query).ToList();
                if (auth.Count() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool proveraDaLiPostojiTelefon(string telefon)
        {
            try
            {
                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n {telefon: '" + telefon + "'}) return n",
                        new Dictionary<string, object>(), CypherResultMode.Set);
                List<LicniPodaci> lp = ((IRawGraphClient)client).ExecuteGetCypherResults<LicniPodaci>(query).ToList();
                if (lp.Count() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string proveriDaLiPostojiKorisnik(string email, string korisnickoIme)
        {
            try
            {

                if(proveraDaLiPostojiKorisnickoIme(korisnickoIme))
                {
                    return "Korisnicko ime je zauzeto!";
                }
                else
                {
                    if(proveraDaLiPostojiEmail(email))
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

        public string proveriDaLiPostojiRadionica(string nazivRadionice)
        {
            try
            {
                var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n {naziv: '" + nazivRadionice + "'}) return n",
                    new Dictionary<string, object>(), CypherResultMode.Set);
                List<Radionica> rad = ((IRawGraphClient)client).ExecuteGetCypherResults<Radionica>(query).ToList();

                if (rad.Count() > 0)
                {
                    return "Radionica s tim nazivom vec postoji!";
                }
                else
                {
                    return "Provera uspesno prosla!";
                }


            }
            catch (Exception e)
            {
                return "Greska!";
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
                                    PrijavljenKorisnik = vratiOsobu(id);
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
                            PrijavljenKorisnik = vratiOsobu(id);
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
