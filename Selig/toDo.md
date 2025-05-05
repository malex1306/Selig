-[x] Klasse/Objekt 
-[x] Konstruktoren 
-[x] Felder/ Methoden
-[x] Properties
-[x] Intefaces
-[x] Abstrakte Klassen
-[x] Statische Klassen
-[ ] Exceptions 
-[ ] Generics
-[ ] Delegates 
-[ ] Events 
-[ ] Strings / Collections
-[ ] Extansion Methods
-[ ] Linq
-[ ] Datein / Streams
-[ ] Serialiesierung / Parallelisierung
-[ ] Anonyme Typen

MVC = Model View Controller
- Model (Datenbank)
- View (Frontend)
- Controller (Geschäfts Logik abbilden)

Sring Operations:

# 🧵 C# String-Operations – Komplette Referenz

## 🔤 Eigenschaften

| Eigenschaft | Beschreibung | Beispiel |
|------------|--------------|----------|
| `Length` | Gibt die Anzahl der Zeichen zurück | `"Hallo".Length → 5` |
| `Chars[]` | Zugriff auf einzelne Zeichen per Index | `"Hallo"[1] → 'a'` |

---

## 🔠 Groß- und Kleinschreibung

| Methode | Beschreibung | Beispiel |
|--------|--------------|----------|
| `ToUpper()` | Alles in Großbuchstaben | `"abc".ToUpper() → "ABC"` |
| `ToLower()` | Alles in Kleinbuchstaben | `"ABC".ToLower() → "abc"` |

---

## ✂️ Schneiden & Einfügen

| Methode | Beschreibung | Beispiel |
|--------|--------------|----------|
| `Substring(start, [length])` | Teilstring extrahieren | `"Hallo".Substring(1, 3) → "all"` |
| `Insert(index, string)` | String einfügen | `"abc".Insert(1, "X") → "aXbc"` |
| `Remove(index, [count])` | Zeichen entfernen | `"abcdef".Remove(2, 2) → "abef"` |

---

## 🔄 Ersetzen, Trimmen & Formatieren

| Methode | Beschreibung | Beispiel |
|--------|--------------|----------|
| `Replace(old, new)` | Teilstring ersetzen | `"Haus".Replace("a", "o") → "Hous"` |
| `Trim()` | Leerzeichen vorne & hinten entfernen | `" hi ".Trim() → "hi"` |
| `TrimStart()` / `TrimEnd()` | Entfernt nur vorne / hinten | |
| `PadLeft(length, char)` | Links auffüllen | `"42".PadLeft(5, '0') → "00042"` |
| `PadRight(length, char)` | Rechts auffüllen | `"42".PadRight(5, '-') → "42---"` |

---

## 🔍 Suchen & Vergleichen

| Methode | Beschreibung | Beispiel |
|--------|--------------|----------|
| `Contains(string)` | Prüft, ob Teil enthalten ist | `"Hallo Welt".Contains("Welt") → true` |
| `IndexOf(string)` | Gibt Index des ersten Vorkommens zurück | `"abcabc".IndexOf("b") → 1` |
| `LastIndexOf(string)` | Letztes Vorkommen | `"abcabc".LastIndexOf("b") → 4` |
| `StartsWith(string)` | Prüft Start | `"Hallo".StartsWith("Ha") → true` |
| `EndsWith(string)` | Prüft Ende | `"Hallo".EndsWith("lo") → true` |
| `Equals(string)` | Vergleicht Strings | `"test".Equals("Test", StringComparison.OrdinalIgnoreCase)` |

---

## 🔗 Aufteilen & Verbinden

| Methode | Beschreibung | Beispiel |
|--------|--------------|----------|
| `Split(char[])` | Teilt String in Array | `"a,b,c".Split(',') → ["a", "b", "c"]` |
| `Join(separator, string[])` | Verbindet Array zu String | `string.Join("-", ["a", "b"]) → "a-b"` |

---

## 🧪 Prüfung auf Leerheit

| Methode | Beschreibung | Beispiel |
|--------|--------------|----------|
| `string.IsNullOrEmpty(str)` | true bei `null` oder `""` | |
| `string.IsNullOrWhiteSpace(str)` | true bei `null`, `""` oder nur Leerzeichen | |

---

## 🔁 Umwandlung & Umstrukturierung

| Methode | Beschreibung | Beispiel |
|--------|--------------|----------|
| `ToCharArray()` | Wandelt String in Char-Array | `"Hi".ToCharArray() → ['H', 'i']` |
| `string.Concat(str1, str2)` | Strings zusammenfügen | `string.Concat("a", "b") → "ab"` |
| `string.Format()` | Platzhalter ersetzen | `string.Format("Hi {0}", "Tom") → "Hi Tom"` |
| `string interpolation` | Einfachere Formatierung | `$"Hi {name}"` |

---

## 🔁 Umkehren & Vergleichen

> Achtung: C# hat **keine native `Reverse()`** für `string`, aber du kannst `ToCharArray().Reverse()` verwenden:

```csharp
string s = "Hallo";
string reversed = new string(s.Reverse().ToArray()); // "ollaH"


Methode	Beschreibung
Normalize()	Normalisiert Unicode-Zeichen
Compare(strA, strB)	Vergleicht zwei Strings
Copy()	Kopiert einen String
Clone()	Gibt ein Objekt zurück (nicht empfohlen)
Intern(str) / IsInterned(str)	Interning für Performance


String Builder:

Methode	Beschreibung
Append(string)	Fügt Text am Ende hinzu
Insert(index, string)	Fügt Text an bestimmter Stelle ein
Remove(startIndex, length)	Entfernt Text
Replace(old, new)	Ersetzt Text
ToString()	Wandelt das Ergebnis in einen normalen string um