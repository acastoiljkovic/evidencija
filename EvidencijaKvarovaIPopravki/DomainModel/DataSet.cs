﻿using System;
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
//  - ako si zaposleni i imas radionicu onda da se prikazuje dugme radionica inace da se ne prikazuje
//  - filter za kvarove i za radionice
//  - pametno trazenje, dok se kuca on da trazi ( trazenje u dataGrdiView , a ne iz baze )
//  - kada si prijavljen kao zaposleni umesto taba radionice napraviti tab nesvrstani kvarovi koji izlistava sve kvarove koji nemaju radionice
//  - selekcijom na neki kvar izlazi forma dodaj kvar koja se trenutno nalazi na dugmetu dodaj kvar
//  - ukoliko se doda kvar se dodaje radionici i zaposlenom koji ga je dodao radionici
//  - kad se doda radionica i vrati na pocetnu ne prikazu se radionice koje su dodate
//
//
//  ------------------- PROFIL ----------------------
//  - dugme i forma za izmeni profil
//  - forma izmeni profil se prilagodjava tipu osobe
//  - nova forma za izmeni lozinku, poziva se iz forme profil, preko dugmeta izmeni lozinku
//  - trenutna profil forma je za osobu tipa korisnik, a ako je tipa zaposleni forma se menja
//  - treba dodati radionicu u kojoj radi
//  
//
//  ------------------- KREIRANJE NALOGA -------------
//  - menjaju se skripte, kreira se KOorisnik kad nije cekirano Prijavljuje se kao zaposleni, odnosno kreira se 
//      zaposleni kada je cekirano i dodaje mu se radionica koju je selektovao
//  - radionica mora da bude selektovana, dodati proveru na stranici
//
//
//  ------------------- PRIJAVI KVAR -------
//  - skripta koja prijavljenom korisniku dodaje kvar koji nema ni jednu radionicu
//  - selekcija da li korisnik oce da bira radionicu ili da radionice biraju njega
//  - ukoliko odabere radionicu skripta pravi odmah vezu izmedju kvara i radionice  
//
//  ------------------- RADIONICA ------------
//  - u radionicu treba lista kvarova koja nema zaposlenog da radi na kvaru
//  - lista kvarova koji se trenutno popravljaju
//  - pametno bi bilo da se izbace delovi !!!!!
//  - dugme i forma za izmeni radionicus




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
                    query = new Neo4jClient.Cypher.CypherQuery("match (r:Radionica)-[a:NALAZI_SE]->(adresa) return adresa",
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
                    "CREATE(Korisnik1: Korisnik{indikator:'" + k.indikator +"' }) " +
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

        public string proveriDaLiPostojiKorisnik(string email, string korisnickoIme)
        {
            try
            {
                //moze jednim upitom koristeci where, ali ne bismo znali da li je nevalidno korisnickoIme ili email
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
