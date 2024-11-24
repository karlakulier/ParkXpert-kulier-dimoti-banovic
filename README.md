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
- ovdje dodati poveznicu na ParkXpert-projektna-dokumentacija.pdf koja se nalazi u mapi "Dokumentacija" na master-docs grani.
  
- link na word verziju projektne dokumentacije (za uređivanje): [ParkXpert - projektna dokumentacija](https://1drv.ms/w/s!AqbB7Uw6ErKLdlwN39KzwMGAVSg?e=szMYpY) 

### Mobilna aplikacija - ParkXplore
- ovdje dodati poveznicu na ParkXplore-projektna-dokumentacija.pdf koja se nalazi u mapi "Dokumentacija" na master-docs grani.
  
- link na word verziju projektne dokumentacije (za uređivanje): [ParkXplore - projektna dokumentacija](https://1drv.ms/w/s!AqbB7Uw6ErKLazka5vO5gW95Be0?e=8TEYKN)

## Tehnička dokumentaija

### Sustav za kamere - ParkXpert
- ovdje dodati poveznicu na ParkXpert-tehnicka-dokumentacija.pdf koja se nalazi u mapi "Dokumentacija" na master-docs grani.

- link na word verziju tehničke dokumentacije (za uređivanje): [ParkXpert - tehnička dokumentacija](https://1drv.ms/w/s!AqbB7Uw6ErKLeKwfCekOBqXUeRI?e=1akafh) 

### Mobilna aplikacija - ParkXplore
- ovdje dodati poveznicu na ParkXplore-tehnicka-dokumentacija.pdf koja se nalazi u mapi "Dokumentacija" na master-docs grani.

- link na word verziju tehničke dokumentacije (za uređivanje): [ParkXplore - tehnička dokumentacija](https://1drv.ms/w/s!AqbB7Uw6ErKLdKELMqb9kTqoNdI?e=lnFC1e)

## Tehnologije i oprema
