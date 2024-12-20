# Lern-Periode 2

25.10 bis 20.12

## Grob-Planung

Ich möchte einen Taschenrechner erstellen, mit dem man beliebige Zahlen beliebig oft rechnen kann. Man soll mit allen Operatoren rechnen können. Wenn ich früher fertig bin, baue ich den Taschenrechrechner noch weiter aus.

- [x] Die Grundfunktion erstellen (Addition, Subtraktion, Division, Multiplikation).
- [x] Mit der letzten Zahl weiterrechnen können.

## 01.11

- [x] Fertig programmieren, dass man mit dem letzten Resultat weiterrechnen kann.
- [x] Wurzeln und Quadrieren programmieren
- [ ] Resultate speichern können
- [x] Weitere Operatoren

Heute habe ich vertig programmiert, dass man mit dem vorherigen Resultat weiterrechnen kann. Ich habe auch hinzugefügt, dass man die n-te Wurzel und Potenz rechnen kann. Zum schluss habe ich noch die Mitternachtsformel programmiert. Diese funktioniert auch, ausser das Resultat beinhaltet imaginäte Zahlen.

## 08.11

- [ ] Mich über komplexe Zahlen in C# informieren und diese evtl. zu meiner Mitternachtsformel hinzufügen
- [ ] Weitere Rechnungsoperatoren wie sinus und cosinus
- [ ] Zahlen speichern und wieder aufrufen
- [ ] Mich über WinForms informieren und ein kleines Programm machen

Heute habe ich mich ein wenig über komplexe Zahlen informiert. In C# diese umzusetzen ist aber nicht ganz einfach und für das, was ich im Internet gefunden habe benötigt es viel code. Ich habe meinen Taschenrechner noch überarbeitet. Dass heisst ich habe ein paar Variablen umbenannt, hinzugefügt, dass die Mitternachtsformel einen Wert zurückgibt und man mit diesem auch weiterrechnen kann. Ich habe noch verbessert, dass es früher prüft ob man einen richtigen Operator angibt oder nicht. Wenn er falsch ist, muss man wieder von vorne anfangen. Das werde ich vielleicht noch beheben. Dazu habe ich mich noch mit WinForms ein wenig auseinandergesetzt und ein paar Toutorials dazu gemacht.

## 15.11

- [ ] Hinzufügen, dass der Rechner die Zahl PI berrechnet und diese speichert. Beim Erneutstart fährt er dort auf, wo er aufgehört hat
- [ ] Weitere Rechenwege hinzufügen (z.B. von r und h zu v)
- [ ] einen einfacheren Weg für imaginäre Zahlen finden
- [ ] Weiter mit WinForms üben und evtl. ein GUI für den Taschenrechner beginnen.

Heute habe ich die Annäherung an PI programmiert. Dies dauert aber eine Zeit, bis es schon nur die ersten 5 Ziffern berrechnet hat. Diese Zahlt speichert es in einem Textdokument. Dass das programm am selben punkt weitermacht, wie es aufgehört hat habe ich aber nicht hinbekommen. Dann habe ich noch angefangen die berrechnung eines Zylinters zu programmieren. Dort sollte man den Ziel-Wert eingeben und dann steht welche Werte für diese Berrechnung erforderlich sind wie zum Beispiel die Höhe oder der Radius.

## 22.11

- [x] Die Switchcases für die Zylinderberrechnung fertigstellen
- [x] Funktionen für die Berrechnung in den Switchcases erstellen
- [x] Berrechnung von Kreissektoren hinzufügen
- [ ] Noch andere Formen wie z.B. eine Kugel hinzufügen

Heute habe ich die Berrechnung für den Zylinder und den Kreis fertig gestellt. Ich musste ein wenig umplanen, da mir aufgefallen ist, dass so wie ich es vorhatte nicht funktioniert. Jetzt funktioniert es aber trotzdem einfach ein wenig eingeschränkter. 

## 29.11

- [x] Den Code sicherer machen, damit das programm nicht abstürzen kann
- [x] Den Code für den Zylinder in den Taschenrechner einauen.
- [x] Verschiedenste Daten vom rechnen speichern können

Heute habe ich die Berrechnung des Zylinders in den Taschenrecher eingebaut. Dazu habe ich mal Klassen und Objekte verwendet, um das auch mal zu üben. Ausserdem habe ich die Struktur des Taschenrechners verändert. Jetzt kann man am Anfang eingeben, ob man den Taschenrechner, die Mitternachtsformel, Annäherung von PI oder die Berrechnung des Zylinders. Dazu habe ich noch ein paar Schleifen angepasst, dass es bei falscher Eingabe den richtigen Teil wiederholt. Ich habe auch noch programmiert, dass man Resultate speichern kann und wenn man s drückt, wird die gespeicherte Zahl eingefügt. Zum Schluss habe ich noch mit Console.Clear den Umgang mit dem Rechner Angenehmer gemacht.

## 6.12
- [ ] Die Restlichen Schleifen auf Fehler kontrollieren
- [ ] Bei allen Funktionen noch Console.Clear hinzufügen
- [ ] Bei der Einsetzung der gespeicherten Zahl verbessern, dass auch die erste Zahl angezeigt wird.

Heute habe ich nicht viel an meinem Projekt weiter gearbeitet, sondern hauptsächlich am Advent of Code. Ich finde, das ist eine sehr coole Idee und macht auch ziehmlich spass. Es ist aber nicht sehr einfach und ich habe ziemlich lange gebraucht, um das erste rätsel zu lösen. Ich musste einige Dinge nachschauen und es hat lange Zeit nicht funktioniert, da es in diesen Spalten jede 3. Zahl genommen hat und nicht jede 2. so wie ich es wollte. Für Tag 1 habe ich 2 goldene Sterne bekommen. Am Schluss habe ich noch an Tag 2 begonnen, bin aber noch nicht weit gekommen.

## 13.12
- [ ] Die Restlichen Schleifen auf Fehler kontrollieren
- [ ] Bei allen Funktionen noch Console.Clear hinzufügen
- [ ] Bei der Einsetzung der gespeicherten Zahl verbessern, dass auch die erste Zahl angezeigt wird.

Heute habe ich am 13. Tag von Advent of Code gearbeitet. Dort habe ich eine Textdatei eingelesen und die Zahlen herausgefiltert. Dann habe ich noch in meinem Taschenrechner eingefügt, dass wenn man einen gespeicherten Wert einfügen will, kann man einen Wert aussuchen. 

## 20.12
- [x] Hinzufügen, dass man bei der 2. Zahl auch einen gespeicherten Wert aussuchen kann.
- [x] Hinzufügen, dass man, wenn man einen Wert speichert, aussuchen kann, wo er gespeichert wird, also welche Stelle

Zu meinen beiden Aufgaben habe ich noch hinzugefügt, dass wenn man eine Zahl eingibt, die Konsole geleert wird und nur noch die Zahlen stehen, also ohne "Geben sie eine Zahl ein: ". Dazu habe ich noch alle Variablen auf Englisch umbenannt und die Auswahl aus den gespeicherten Werten in eine Funktion ausgelagert.

# Beschreibung Projekt














