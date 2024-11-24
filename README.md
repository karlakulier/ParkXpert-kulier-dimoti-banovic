# Softversko rješenje ParkXpert i ParkXplore

## Projektni tim

Ime i prezime | E-mail adresa | OIB | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Karla Kulier | karlakulier@gmail.com | 75821226159  | karlakulier |
Vedran Đimoti | vedrandimoti@gmail.com | 94542085545 | VedranDimoti|
Matej Banović | mbanovicb@gmail.com | 31984717472 | mbanovic20

## Opis domene

## Specifikacija projekta

### Sustav za kamere - ParkXpert
Oznaka | Naziv | Kratki opis
------ | ----- | ----------- 
F01 | Praćenje zauzetosti parkirnih mjesta | Sustav koristi kamere za praćenje zauzetosti parkirnih mjesta u stvarnom vremenu. Kamere detektiraju prisutnost vozila i šalju ažurirane podatke (slobodno/zauzeto) putem LoRa mreže aplikaciji ParkXplore, koja ih interpretira i prikazuje korisnicima. 
F02 | Identifikacija registarskih oznaka vozila | Sustav automatski prepoznaje registarske oznake vozila pri ulasku i izlasku, bilježeći vrijeme dolaska i odlaska. Podaci se pohranjuju u bazu za analizu, sigurnosni nadzor i kontrolu pristupa. 
F03 | Prijenos podataka putem LoRa mreže | Sustav će putem LoRa mreže prenositi podatke o zauzetosti parkirnih mjesta i registarskim oznakama, osiguravajući siguran, energetski učinkovit prijenos na velikim udaljenostima uz minimalnu potrošnju energije. 
F04 | Sigurnosno praćenje parkirališta | Sustav će analizirati video signal s kamera za detekciju sumnjivih aktivnosti te automatski aktivirati alarm ili obavijestiti upravitelja. Sigurnosni podaci čuvat će se zaštićeno, uz očuvanje privatnosti korisnika.
F05 | Automatsko ažuriranje statusa parkirnih mjesta | Sustav će automatski ažurirati status parkirnih mjesta u stvarnom vremenu putem LoRa mreže, omogućujući korisnicima uvid u dostupnost kroz aplikaciju ParkXplore. 

### Mobilna aplikacija - ParkXplore
Oznaka | Naziv | Kratki opis 
------ | ----- | -----------
F01 | Prikaz dostupnih parkirnih mjesta u stvarnom vremenu | Sustav će korisnicima omogućiti pregled slobodnih parkirnih mjesta u stvarnom vremenu putem aplikacije ParkXplore, koristeći podatke iz ParkXpert sustava. Aplikacija će prikazivati status parkirnih mjesta (slobodno, zauzeto, rezervirano) na interaktivnoj karti, s mogućnošću filtriranja prema lokaciji, udaljenosti, tipu parkirnog mjesta i vremenu dostupnosti. 
F02 | Rezervacija parkirnog mjesta | Sustav omogućuje korisnicima rezervaciju parkirnog mjesta putem ParkXplore aplikacije, uz provjeru dostupnosti u stvarnom vremenu. Korisnici mogu odabrati, izmijeniti ili otkazati rezervaciju unutar dozvoljenog perioda. 
F03 | Prijava i registracija korisnika | Sustav omogućuje korisnicima kreiranje računa i prijavu putem aplikacije ParkXplore, uz sigurno pohranjivanje lozinke i opciju za resetiranje lozinke putem e-maila. 
F04 | Upravljanje korisničkim profilom | Sustav omogućuje korisnicima ažuriranje osobnih podataka, promjenu lozinke i postavljanje preferencija za parkiranje u aplikaciji ParkXplore. 
F05 | Povijest parkiranja i rezervacija | Sustav omogućuje korisnicima pregled povijesti parkiranja i rezervacija s detaljima o parkirnim mjestima, datumima, vremenima i statusima. 
F06 | Obavijesti o promjeni statusa rezervacije | Sustav će slati obavijesti korisnicima o promjenama statusa rezervacija, uključujući oslobađanje, promjene, otkazivanja i isteke vremena. 
F07 | Prikaz i plaćanje parkirnih naknada | Sustav će omogućiti korisnicima pregled i plaćanje parkirnih naknada putem aplikacije ParkXplore, podržavajući različite metode plaćanja. Korisnici će imati pregled svih naknada, a aplikacija će slati obavijesti o nadolazećim naknadama ili isteku parkirnog vremena. 
F08 | Pretraga i filtriranje parkirnih mjesta | Sustav će omogućiti korisnicima pretragu parkirnih mjesta prema različitim kriterijima, kao što su lokacija, cijena, dostupnost, veličina, pristupačnost i dodatne pogodnosti. Korisnici će moći koristiti više filtera i pregledavati povijest pretrage za brži pristup omiljenim mjestima. 
F09 | Ocjenjivanje i komentiranje parkirnih mjesta | Sustav će omogućiti korisnicima ocjenjivanje parkirnih mjesta s 1 do 5 zvjezdica i ostavljanje komentara. Ostali korisnici moći će pregledavati recenzije, a sustav će moderirati komentare i omogućiti prijavu neprikladnih. 
F10 | Navigacija do parkirnog mjesta | Sustav će omogućiti korisnicima navigaciju do parkirnog mjesta putem GPS-a, s opcijama za pješačenje ili vožnju. Aplikacija će integrirati Google Maps ili Apple Maps za preciznu rutu i pružati informacije o prometnim uvjetima. 
F11 | Prikaz posebnih ponuda i promocija | Sustav će omogućiti korisnicima pregled i primjenu promocija unutar aplikacije, uključujući popuste, sezonske ponude i promocije za članove. Korisnici će moći primijeniti promocijske kodove ili automatski ostvariti popuste prilikom plaćanja ili rezervacije. 

## Projektna dokumentacija

### Sustav za kamere - ParkXpert
https://github.com/karlakulier/ParkXpert-kulier-dimoti-banovic/blob/731b6211e07e92789b852c2a96741d764bcd445f/ParkXpert%20-%20projektna%20dokumentacija.docx.pdf
  
- link na word verziju projektne dokumentacije (za uređivanje): [ParkXpert - projektna dokumentacija](https://1drv.ms/w/s!AqbB7Uw6ErKLdlwN39KzwMGAVSg?e=szMYpY) 

### Mobilna aplikacija - ParkXplore
https://github.com/karlakulier/ParkXpert-kulier-dimoti-banovic/blob/731b6211e07e92789b852c2a96741d764bcd445f/ParkXplore%20-%20projektna%20dokumentacija.docx%20-%20Microsoft%20Word%20Online.pdf
  
- link na word verziju projektne dokumentacije (za uređivanje): [ParkXplore - projektna dokumentacija](https://1drv.ms/w/s!AqbB7Uw6ErKLazka5vO5gW95Be0?e=8TEYKN)

## Tehnička dokumentaija

### Sustav za kamere - ParkXpert
https://github.com/karlakulier/ParkXpert-kulier-dimoti-banovic/blob/731b6211e07e92789b852c2a96741d764bcd445f/ParkXpert%20-%20tehni%C4%8Dka%20dokumentacija.docx.pdf

- link na word verziju tehničke dokumentacije (za uređivanje): [ParkXpert - tehnička dokumentacija](https://1drv.ms/w/s!AqbB7Uw6ErKLeKwfCekOBqXUeRI?e=1akafh) 

### Mobilna aplikacija - ParkXplore
https://github.com/karlakulier/ParkXpert-kulier-dimoti-banovic/blob/731b6211e07e92789b852c2a96741d764bcd445f/ParkXplore%20-%20tehni%C4%8Dka%20dokumentacija.docx.pdf

- link na word verziju tehničke dokumentacije (za uređivanje): [ParkXplore - tehnička dokumentacija](https://1drv.ms/w/s!AqbB7Uw6ErKLdKELMqb9kTqoNdI?e=lnFC1e)

## Tehnologije i oprema
Pri implementaciji softverskog rješenja za praćenje rada kozmetičkog salona koristit će se niz tehnologija, alata i opreme kako bi se osigurala kvaliteta, funkcionalnost i sigurnost rješenja. Ovdje je popis tih elemenata:

* [*LoRaWAN*](https://lens-zagreb.hr/proizvodi/iot-internet-of-things/lora/): Korištena za komunikaciju kamera i API-ja.

* [*Programski jezik C#*](https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/?view=vs-2022): Korišten za razvoj glavnog softverskog rješenja.

* [*Programski jezik Kotlin*](https://kotlinlang.org/): Korišten za razvoj grafičkog korisničkog sučelja, pružajući bogat, stabilan i interaktivan dizajn.

* [*Visual Studio*](https://visualstudio.microsoft.com/): Kao integrirano razvojno okruženje za backend programiranje u C# i .NET okruženju.
  
* [*Android Studio*](https://developer.android.com/studio): Kao integrirano razvojno okruženje za frontend programiranje u Kotlin-u.

* [*MySQL*](https://sqlitebrowser.org/): Za pohranu podataka o klijentima, parkinzima, parkirnim mjestima i administrativnim informacijama.

* [*ADO.NET*](https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/ado-net-overview): Za integraciju i upravljanje online bazom podataka, omogućujući siguran pristup i manipulaciju podacima.

* [*ASP.NET*](https://dotnet.microsoft.com/en-us/apps/aspnet): Razvojni framework otvorenog koda od Microsofta korišten za izradu dinamičnog, sigurnog i skalabilnog API-ja koristeći .NET platformu, MVC stil razvoja.

* [*Entity Framework*](https://learn.microsoft.com/en-us/ef/): Za olakšavanje upita i pristupa podacima u aplikaciji.

* [*SMTP server*](https://support.google.com/a/answer/176600?hl=en): Za slanje e-mail obavijesti klijentima.

* [*Operativni sustav Windows*](https://www.microsoft.com/en-us/windows?r=1): Kako bi aplikacija bila kompatibilna s okruženjem većine korisnika.

* [*Projektni alati (Gantt Chart)*](https://www.onlinegantt.com/#/gantt): Za upravljanje projektom, planiranje aktivnosti, i praćenje napretka.

* [*Version Control Platform (GitHub)*](https://github.com/): Za upravljanje izvorima koda, verzioniranje i timsku suradnju.

* [*Visual Paradigm*](https://www.visual-paradigm.com/whats-new/): Za dizajniranje i kreiranje dijagrama

* [*Dokumentacijski alati (Microsoft Office Education)*](https://www.microsoft.com/en-us/education/products/microsoft-365): Za izradu tehničke dokumentacije, uputa za korištenje i dokumentacije korisnika.

Svi korišteni alati i tehnologije su javno dostupni i imaju odgovarajuće licence kako bi se osigurala legalnost i usklađenost s pravilima i propisima. Za tehnologije koje nisu standardno dostupne (npr. Entity Framework) u dokumentaciji će biti navedeni načini instalacije i korištenja.
