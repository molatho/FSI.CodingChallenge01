# Coding-Challenge #1 - *Steine und Edelsteine*
## Aufgabenstellung

Ein String „E“ repräsentiert alle Steine die Edelsteine sind und ein String „S“ repräsentiert alle Steine die man besitzt, wobei jeder Buchstabe in „S“ für einen Stein steht in dessen Besitz man ist.

Die Buchstaben in „E“ sind einzigartig (kommen nicht mehrfach in „E“ vor). „E“ und „S“ bestehen nur aus Buchstaben, wobei die Groß- und Kleinschreibung zu nterscheiden ist.

Nun soll herausgefunden werden wie viele Steine man besitzt die auch Edelsteine sind.

Beispiel 1:
var E = "aA"
var S = "aAAbbbb"
anzahlAnEdelsteinen(E, S) => 3

Beispiel 2:
var E = "z",
var S = "ZZ"
anzahlAnEdelsteinen(E, S) => 0

## Lösungsansatz
Mithilfe von Linq wird die Liste der Edelsteine "E" durchlaufen (Iterator `e`) und die Summe (` .Sum`) der Sub-Query gebildet. Die Sub-Query durchläuft die Liste der eigenen Steine "S" (Iterator `s`) und gibt die Anzahl (`.Count`) der Steine zurück, die gleich dem untersuchten Edelstein sind (`s == e`).

Um den Code auf eine Zeile zu reduzieren wurden keine lokalen Variablen angelegt.