namespace WarenkorbLinq;

class Program
{
    static void Main(string[] args)
    {
        Kunde[] kunden = Kunde.GetKundenListe();
        Produkt[] produkte = Produkt.GetProduktListe();

        Console.WriteLine("A:");
        // Produktnamen (Query)
        var produktNamenQuery = from p in produkte
            select p.Name;

        foreach (var name in produktNamenQuery)
        {
            Console.WriteLine(name);
        }

// Kundenname + Ort (Query)
        var kundenInfoQuery = from k in kunden
            select new { k.Name, k.Ort };

        foreach (var k in kundenInfoQuery)
        {
            Console.WriteLine($"Name: {k.Name}, Ort: {k.Ort}");
        }

        Console.WriteLine("A:");
        Console.WriteLine("============================");
        
        // Produktnamen (Method)
        var produktNamenMethod = produkte.Select(p => p.Name);

        foreach (var name in produktNamenMethod)
        {
            Console.WriteLine(name);
        }
        

// Kundenname + Ort (Method)
        var kundenInfoMethod = kunden.Select(k => new { k.Name, k.Ort });

        foreach (var k in kundenInfoMethod)
        {
            Console.WriteLine($"Name: {k.Name}, Ort: {k.Ort}");
        }

        Console.WriteLine("============================");
        Console.WriteLine("B:");
        
        var bestellungenDeutschlandQuery =
            from k in kunden
            where k.Land == Länder.Germany
            from b in k.Bestellungen
            select new { k.Name, Bestellung = b };

        foreach (var eintrag in bestellungenDeutschlandQuery)
        {
            Console.WriteLine($"Kunde: {eintrag.Name} -> {eintrag.Bestellung}");
        }

        Console.WriteLine("============================");
        Console.WriteLine("B:");
        
        var bestellungenDeutschlandMethod = kunden
            .Where(k => k.Land == Länder.Germany)
            .SelectMany(k => k.Bestellungen, (k, b) => new { k.Name, Bestellung = b });

        foreach (var eintrag in bestellungenDeutschlandMethod)
        {
            Console.WriteLine($"Kunde: {eintrag.Name} -> {eintrag.Bestellung}");
        }

        Console.WriteLine("============================");
        Console.WriteLine("C:");
        
        var jederZweiteKunde = kunden
            .Select((kunde, index) => new { kunde, index })
            .Where(x => x.index % 2 == 0)
            .Select(x => x.kunde.Name);

        foreach (var name in jederZweiteKunde)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("============================");
        Console.WriteLine("D:");

        var NameAndPriceOfAllProducts = produkte
            .Where(price => price.Preis > 20)
            .Select(p => new { p.Name, p.Preis })
            .OrderByDescending(p => p.Preis);
        foreach (var p in NameAndPriceOfAllProducts)
        {
            Console.WriteLine($"{p.Name} - {p.Preis}");
        }
        
        Console.WriteLine("============================");
        Console.WriteLine("E:");
        var nameUndLandQuery =
            from k in kunden
            orderby k.Land, k.Name
            select new { k.Name, k.Land };

        foreach (var k in nameUndLandQuery)
        {
            Console.WriteLine($"{k.Name} - {k.Land}");
        }

        Console.WriteLine("============================");
        Console.WriteLine("E:");
        
        var NameAndLandAllCostumers = kunden
            .Select(k => new { k.Name, k.Land })
            .OrderBy(k => k.Land)
            .ThenBy(k => k.Name);
        foreach (var k in NameAndLandAllCostumers)
        {
            Console.WriteLine($"{k.Name} - {k.Land}");
        }
        Console.WriteLine("============================");
        Console.WriteLine("F:");
        var gruppiertNachLand =
            from k in kunden
            group k by k.Land into g
            select new { Land = g.Key, Kunden = g.ToList() };

        foreach (var gruppe in gruppiertNachLand)
        {
            Console.WriteLine($"{gruppe.Land} - {gruppe.Kunden.Count}");
            foreach (var kunde in gruppe.Kunden)
            {
                Console.WriteLine($"  {kunde.Name} aus {kunde.Ort}");
            }
        }
        
        Console.WriteLine("============================");
        Console.WriteLine("F:");
        
        var GroupCostumersByLand = kunden
            .GroupBy(k => k.Land)
            .Select(g => new { Land = g.Key, Kunden = g.ToList() });
        foreach (var k in GroupCostumersByLand)
        {
            Console.WriteLine($"{k.Land} - {k.Kunden.Count}");
        }
        
        Console.WriteLine("============================");
        Console.WriteLine("G:");
        var groupProductsByFirstLetterQuery =
            from p in produkte
            group p by p.Name[0] into g
            select new { FirstLetter = g.Key, Produktnamen = g.Select(p => p.Name).ToList() };

        foreach (var gruppe in groupProductsByFirstLetterQuery)
        {
            Console.WriteLine($"{gruppe.FirstLetter} - {gruppe.Produktnamen.Count}");
            foreach (var name in gruppe.Produktnamen)
            {
                Console.WriteLine($"  {name}");
            }
        }
        Console.WriteLine("============================");
        Console.WriteLine("G:");
        
        var groupProductsByFirstLetter = produkte
            .GroupBy(p => p.Name[0])
            .Select(g => new { FirstLetter = g.Key, Produktnamen = g.Select(p => p.Name).ToList() });

        foreach (var gruppe in groupProductsByFirstLetter)
        {
            Console.WriteLine($"{gruppe.FirstLetter} - {gruppe.Produktnamen.Count}");
            foreach (var name in gruppe.Produktnamen)
            {
                Console.WriteLine($"  {name}");
            }
        }
        Console.WriteLine("============================");
        Console.WriteLine("H:");
        
        var joinBestellungenUndProdukteQuery = 
            from k in kunden
            from b in k.Bestellungen 
            join p in produkte on b.ProduktNr equals p.ProduktNr 
            orderby p.Preis 
            select new 
            {
                b.Monat, 
                b.ProduktNr, 
                p.Name, 
                p.Preis, 
                b.Versendet
            };

        foreach (var item in joinBestellungenUndProdukteQuery)
        {
            Console.WriteLine($"Monat: {item.Monat}, ProduktNr: {item.ProduktNr}, Name: {item.Name}, Preis: {item.Preis}, Versendet: {item.Versendet}");
        }

        Console.WriteLine("============================");
        Console.WriteLine("H:");
        var joinBestellungenUndProdukte = from b in kunden.SelectMany(k => k.Bestellungen) 
            join p in produkte on b.ProduktNr equals p.ProduktNr 
            orderby p.Preis 
            select new 
            {
                b.Monat, 
                b.ProduktNr, 
                p.Name, 
                p.Preis, 
                b.Versendet
            };

        foreach (var item in joinBestellungenUndProdukte)
        {
            Console.WriteLine($"Monat: {item.Monat}, ProduktNr: {item.ProduktNr}, Name: {item.Name}, Preis: {item.Preis}, Versendet: {item.Versendet}");
        }
        
        Console.WriteLine("============================");
        Console.WriteLine("I:");
        
        var customerQuery =
        from k in kunden
        select new 
        { 
            k.Name, 
            k.Ort, 
            AnzahlBestellungen = k.Bestellungen.Length 
        };

        foreach (var kunde in customerQuery)
        {
            Console.WriteLine($"{kunde.Name} - {kunde.Ort} - Bestellungen: {kunde.AnzahlBestellungen}");
        }

Console.WriteLine("============================");
Console.WriteLine("I:");
        var customerByNameOrtAndOrderCount = kunden
            .Select(k => new 
            { 
                k.Name, 
                k.Ort, 
                AnzahlBestellungen = k.Bestellungen.Length 
            });

        foreach (var kunde in customerByNameOrtAndOrderCount)
        {
            Console.WriteLine($"{kunde.Name} - {kunde.Ort} - Bestellungen: {kunde.AnzahlBestellungen}");
        }
        Console.WriteLine("============================");
        Console.WriteLine("j:");
        
        var SumOfAllProducts = produkte
            .Select(p => p.Preis)
            .Sum();
        Console.WriteLine(SumOfAllProducts);
        
        Console.WriteLine("============================");
        Console.WriteLine("j:");
        
        var sum = produkte.Sum(p => p.Preis);
        Console.WriteLine(sum);
        
        Console.WriteLine("============================");
        Console.WriteLine("K:");
        
        var customerByNameAndTotalAmountQuery =
            from k in kunden
            select new
            {
                k.Name,
                GesamtBetrag =
                    (from b in k.Bestellungen
                        join p in produkte on b.ProduktNr equals p.ProduktNr
                        select b.Anzahl * p.Preis).Sum()
            } into result
            orderby result.Name
            select result;

        foreach (var kunde in customerByNameAndTotalAmountQuery)
        {
            Console.WriteLine($"{kunde.Name} - {kunde.GesamtBetrag} €");
        }
        Console.WriteLine("============================");
        Console.WriteLine("K:");
        
        var customerByNameAndTotalAmount = kunden
            .Select(k => new
            {
                k.Name,
                GesamtBetrag = k.Bestellungen.Sum(b =>
                {
                    var produkt = produkte.FirstOrDefault(p => p.ProduktNr == b.ProduktNr);
                    return produkt != null ? produkt.Preis * b.Anzahl : 0;
                })
            })
            .OrderBy(k => k.Name); 

        foreach (var kunde in customerByNameAndTotalAmount)
        {
            Console.WriteLine($"{kunde.Name} - {kunde.GesamtBetrag} €");
        }

    }
}