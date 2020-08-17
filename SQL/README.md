![Kuva](https://github.com/FLATISHKA/eduvantaa/blob/master/SQL/Diagram.png)
### Tehtävä 4
>SELECT * FROM Kurssisuoritus
### Tehtävä 5
>SELECT kurssi FROM Kurssisuoritus
### Tehtävä 6
>SELECT DISTINCT kurssi FROM Kurssisuoritus
### Tehtävä 7
>SELECT * FROM Opiskelija 
    WHERE nimi = 'Anna'
### Tehvävä 8
>SELECT * FROM Kurssisuoritus 
    WHERE opiskelija = 999999
### Tehtävä 9
>SELECT DISTINCT pääaine FROM Opiskelija 
    WHERE pääaine LIKE '%tiede%'
### Tehtävä 10
>SELECT nimi, päivämäärä, arvosana FROM Kurssi, Kurssisuoritus 
    WHERE Kurssi.kurssitunnus = Kurssisuoritus.kurssi
### Tehtävä 11
>SELECT nimi, päivämäärä, arvosana FROM Opiskelija, Kurssisuoritus 
    WHERE Kurssisuoritus.opiskelija = opiskelija.opiskelijanumero
### Tehtävä 12
>SELECT Kurssi.nimi AS kurssi, Tehtävä.nimi AS tehtävä FROM Kurssi, Kurssitehtävä, Tehtävä 
    WHERE  kurssi.kurssitunnus = Kurssitehtävä.kurssi AND Kurssitehtävä.tehtävä = Tehtävä.tunnus 
### Tehtävä 13
>SELECT Kurssi.nimi AS kurssi, Tehtävä.nimi AS tehtävä FROM Opiskelija, Kurssi, Tehtävä, Kurssitehtävä 
    WHERE Opiskelija.nimi = 'Anna' AND Kurssi.kurssitunnus = Kurssitehtävä.kurssi AND Kurssitehtävä.tehtävä = Tehtävä.tunnus
### Tehtävä 14
>Ekassa haetaaan vain tehtävät ja toisessa opiskeljialle haetaan erikseen kaikki tehtävät ja ne toistuu.
### Tehtävä 15
>SELECT nimi FROM Kurssi k 
    WHERE k.kurssitunnus
NOT IN (SELECT kurssi FROM kurssitehtävä)

>SELECT nimi FROM Kurssi kurssi 
LEFT JOIN Kurssitehtävä tehtävä
ON kurssi.kurssitunnus=tehtävä.kurssi
WHERE tehtävä.tunnus IS NULL
### Tehtävä 16
>SELECT k.nimi AS kurssi, COUNT(ks.kurssi) AS lukumäärä FROM Kurssi k, Kurssisuoritus ks
    WHERE k.kurssitunnus = ks.kurssi GROUP BY k.nimi
### Tehtävä 17
>SELECT k.nimi AS kurssi, COUNT(ks.kurssi) as lukumäärä FROM Kurssi k LEFT JOIN Kurssisuoritus ks
    ON k.kurssitunnus = ks.kurssi GROUP BY k.nimi
### Tehtävä 18
>CREATE TABLE Kurssi (kurssitunnus, nimi, kuvaus)
### Tehtävä 19
>INSERT INTO Kurssi (kurssitunnus, nimi, kuvaus)
VALUES ("12345", "SQL-kielen perusteet", "Hei maailma")

>SELECT * FROM Kurssi
### Tehtävä 20
>PRAGMA TABLE_INFO(Opiskelija)
### Tehtävä 21
>CREATE TABLE Kurssi (kurssitunnus, nimi, kuvas)
### Tehtävä 22
