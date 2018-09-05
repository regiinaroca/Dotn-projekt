# Aplikacija-Upis ucenika u školu

Aplikacija Upis ucenika u školu namijenjena je unosu novih ucenika u bazu podataka.
Ucenicima se uz njihove osobne podatke (ime, prezime, oib) dodijeljuje i razredni
odjel u koji ce pripadati. Podaci o razrednim odjelima i nastanicima nalazi s
u tablici raz_odjel, a podaci o ucenicima spremaju se u tablicu ucenici. Tablice su
povezane po id-ju razrednog odjela.
U aplikaciji je omoguceno citanje podataka o razrednim odjelima korištenjem 
DataGridView elementa, kao i citanje podataka o upisanim ucenicima.
Za komunikaciju s bazom koristi se EntityFramework.

Na prvoj formi omogucen je unos podataka o ucenicima koji se zapisuju u bazu
pritiskom na gumb. Takoder, nalaze se još dva gumba koji vode na odvojene forme koje
prikazuju podatke.

U formi na kojoj se prikazuju podaci o ucenicima, te kojim razredima pripadaju, 
omoguceno je filtriranje po razrednim odjelima. Na istoj formi, postoji gumb
kojim se pokrece funkcija koja podatke iz baze podataka sprema u Excel datoteku.
Za rad s Excel datotekama korištena je EPPlus biblioteka.
