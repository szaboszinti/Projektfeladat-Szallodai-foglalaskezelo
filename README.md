# Projektfeladat-Szallodai-foglalaskezelo
## Feladatmegosztás

#### Szabó Szintia:

- Room osztály,
- szobakezelés,
- szabad szobák keresése,
- árkalkuláció,
- statisztikák egy része.

 #### Árki Dávid:

- Guest osztály,
- Booking osztály,
- foglalások kezelése,
- foglalási ütközések vizsgálata,
- fájlkezelés.

#### Közös feladat:
- főmenü,
- rendszerintegráció,
- tesztelés,
- hibajavítás,
- dokumentáció,
- végső bemutató.

## Alapvető követelmények:

#### A programnak képesnek kell lennie:

- szobák kezelésére
- vendégek kezelésére
- foglalások létrehozására
- foglalások módosítására
- foglalások törlésére
- szabad szobák keresésére
- foglalási ütközések ellenőrzésére
- ár kiszámítására
- adatok fájlba mentésére
- adatok betöltésére
- statisztikák készítésére

## Osztálydiagramm:

#### Room
- RoomNumber
- RoomType
- Capacity
- PricePerNight
- IsActive

#### Guest
- Id
- Name
- Phone
- Email

#### Booking
- Id
- GuestId
- RoomNumber
- CheckIn
- CheckOut
- GuestCount
- Status
- TotalPrice


## Fejlesztési terv:

1. hét: 
Github, projekt létrehozása, tervezés
2. hét:
Osztályok elkészítése
3. hét:
Adatok felvétele, módosítása, törlése
4. hét:
Foglalások kezelése
5. hét:
CSV betöltése
6. hét: 
Ár kiszámitás, statisztikák
7. hét:
Legalább 15 tesztelés
8. hét:
Projekt véglegesítése, bemutatás


