![Kuva](https://github.com/FLATISHKA/eduvantaa/blob/master/SQL/Diagram.png)
### Tehtävä 4
SELECT * FROM Kurssisuoritus
### Tehtävä 5
SELECT kurssi FROM Kurssisuoritus
### Tehtävä 6
SELECT DISTINCT kurssi FROM Kurssisuoritus
### Tehtävä 7
SELECT * FROM Opiskelija WHERE nimi = 'Anna'
### Tehvävä 8
SELECT * FROM Kurssisuoritus WHERE opiskelija = 999999
### Tehtävä 9
SELECT DISTINCT pääaine FROM Opiskelija WHERE pääaine LIKE '%tiede%'
### Tehtävä 10
SELECT nimi, päivämäärä, arvosana FROM Kurssi, Kurssisuoritus WHERE Kurssi.kurssitunnus = Kurssisuoritus.kurssi
### 
### 
