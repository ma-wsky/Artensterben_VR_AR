# Artensterben visualisieren (SDG 15)

**Projektarbeit Virtual and Augmented Reality** 

HRW - Sommersemester 2026

---

## Beschreibung

Diese Virtual-Reality-Anwendung macht ausgestorbene und stark bedrohte Tierarten im Rahmen des Nachhaltigkeitsziels **SDG 15 (Leben an Land)** in einem immersiven Raum erlebbar. Nutzer können sich über eine interaktive Weltkarte in die naturgetreuen Lebensräume der Tiere teleportieren, ihr Verhalten beobachten und sich über ein integriertes Informations-Panel über die spezifischen Ursachen ihrer Bedrohung oder ihres Aussterbens informieren.

---

## Kernfunktionalitäten

### Navigation & Umgebung
- **Begrüßungs-Lobby:** Zentraler Einstiegspunkt und Startbereich für die Nutzenden beim App-Start.
- **Interaktive Weltkarte:** Visuelle Auswahl von Tieren, aufgeteilt in die Kategorien „bedroht“ und „ausgestorben“.
- **Teleportations-System:** Nahtlose Fortbewegung aus der Lobby direkt in die VR-simulierten Lebensräume der jeweiligen Tiere.

### Immersion & Interaktion
- **Lebendige 3D-Habitate:** Animierte und realitätsnah skalierte 3D-Tiermodelle mit flüssigen Bewegungsabläufen (Idle, Walk).
- **Spatial Audio:** Realistisches 3D-Sounddesign mit raumbezogenen Umgebungsgeräuschen und Tierlauten für maximale emotionale Wirkung.

### Bildungsdesign & Information
- **World-Space Infopanels:** Schwebende UI-Anzeigen direkt im virtuellen Raum, basierend auf validierten Daten der IUCN Red List.
- **Fakten-Vermittlung:** Übersichtliche Darstellung von Kurzfakten, den primären Aussterbe- bzw. Bedrohungsgründen sowie dem direkten Bezug zu SDG 15.

---

## Inhalte und Szenarien

Das Projekt umfasst die Aufarbeitung von 5 spezifischen Tierarten mit unterschiedlichem Bedrohungsstatus:

| Art | Status | Primäre Bedrohung / Aussterbegrund | Besonderheit der VR-Darstellung |
| :--- | :--- | :--- | :--- |
| **Dodo** (*Raphus cucullatus*) | Ausgestorben (1681) | Jagd durch Kolonisten | Lebendige Bewegungsmuster im historischen Habitat |
| **Beutelwolf** (*Thylacinus*) | Ausgestorben (1936) | Private Bejagung, Prämien, Habitatverlust | Natürliche Verhaltenssimulation im virtuellen Raum |
| **Ioreana-Riesenschildkröte** | Ausgestorben (um 1850) | Bejagung, Proviantnutzung, invasive Arten | Detailgetreue Skalierung und angepasste Trägheit |
| **Java Nashorn** (*Rhinoceros sondaicus*) | Vom Aussterben bedroht | Wilderei, Naturkatastrophen, Platzmangel | Immersiver Regenwald-Lebensraum mit Audio-Kulisse |
| **Amur Leopard** (*Panthera pardus orientalis*) | Vom Aussterben bedroht | Lebensraumverlust, Waldbrände, Wilderei | Dynamische Animationen in einer dichten Wald-Umgebung |

---

## Technologien und Ressourcen

### Grundlegende Technologien

| Technologie / Engine | Version | Beschreibung |
| :--- | :--- | :--- |
| Unity | 2022 LTS | Primäre Entwicklungsumgebung und Engine |
| Meta XR SDK | Aktuell | SDK für die native Integration der Meta Quest 3 |
| C# | .NET Core | Programmierung der Interaktionslogik und UI-Trigger |

### Assets und Animation

| Ressource / Tool | Beschreibung |
| :--- | :--- |
| Sketchfab / CGTrader | Bezugsquelle für freie 3D-Tiermodelle und Umgebungs-Assets |
| PolyHaven / Unity Asset Store | High-Quality Texturen, Materialien und Skyboxen |
| Mixamo / AnimateAnything | Werkzeuge zur Erstellung flüssiger Tieranimationen |

### UI und Audio

| Bibliothek / Komponente | Beschreibung |
| :--- | :--- |
| TextMeshPro | Gestochen scharfe Textdarstellung auf den Infopanels im VR-Raum |
| World-Space Canvas | In die Spielwelt eingebettete Benutzeroberflächen |
| Spatial Audio | Unity-natives 3D-Audio für richtungsabhängige Soundwiedergabe |

### Datenbasis

| Quelle | Beschreibung |
| :--- | :--- |
| IUCN Red List | Offizielle Datenbasis für Gefährdungsstufen und Artenschutz-Fakten |

---

## Vier-Wochen-Zeitplan

---

### Woche 1
#### Konzept, Artenliste & AR-Setup · Woche 1

##### Aufgaben
- 5 Tierarten auswählen, Aussterbe-Gründe und SDG-15-Daten recherchieren (IUCN Red List)
- Unity + Meta XR SDK, VR testen, Flächen erstellen
- 3D-Tiermodelle und Umgebungs Assets suchen und vorauswählen (Sketchfab, CGTrader Free, Poly Haven), Audio Assets für die Tiere und Umgebung suchen, Assets in GitRepo hochladen und sortieren
- Alle:Konzepte erarbeiten

##### Lieferobjekt
- Konzept + 5 Tierarten definiert + VR-Testszene (Lobby) läuft

---

### Woche 2
#### Erste 3 Tiere in AR bauen · Woche 2

##### Aufgaben
- Infopanel-Inhalte für Tiere 1–3 schreiben: Kurzfakt, Aussterbegrund, SDG-Bezug
- Teleportation in die Habitate der Tiere, bewegen durch das Habitat, Trigger für Animationen, Skybox
- 3D-Modelle importieren, Animationen (Idle, Walk) einrichten, Skalierung testen, Habitate bauen (Terrain, Beleuchtung, Himmel)
- Alle: Playtest: erscheinen Tiere stabil? Skalierung überzeugend?

##### Lieferobjekt
- Habitate für drei Tierarten mit entsprechenden Infopanels

---

### Woche 3
#### Alle 5 Tiere + Navigations-UI · Woche 3

##### Aufgaben
- Infopanels für alle 5 Tiere finalisieren
- Tiere 4 und 5 integrieren, Tierauswahl-Menü (schwebendes Rad oder Liste) bauen, Spatial Audio für Umgebungsgeräusche
- Visuelle Verbesserungen:Habitat Verschönerung, Sounddesign
- Alle: Nutzertest mit externen Personen, Feedback einarbeiten

##### Lieferobjekt
- Beta-Build mit allen 5 Arten und Navigations-UI

---

### Woche 4
#### Feinschliff, Doku & Präsentation · Woche 4

##### Aufgaben
- Dokumentation: SDG 15, IUCN-Daten, Reflexion zur Bildungswirkung
- APK finalisieren, Performance-Optimierung
- Demo-Video in virtueller Umgebung aufnehmen, Präsentationsplakat erstellen
- Alle: Live-Demo und Abschlusspräsentation

##### Lieferobjekt
- APK + Dokumentation + Demo-Video

---

## Autoren

Maximilian Dregewsky, Jan Montzka, Ebubekir Yayla.
Erstellt im Rahmen der Projektarbeit Virtual and Augmented Reality.

---
