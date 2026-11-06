using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Adresse a1 = new Adresse("Hauptstraße", "12a", 3340, "Waidhofen an der Ybbs", "Niederösterreich");
        Adresse a2 = new Adresse("Mariahilfer Straße", "45", 1060, "Wien", "Wien");
        Adresse a3 = new Adresse("Herrengasse", "8", 8010, "Graz", "Steiermark");
        Adresse a4 = new Adresse("Maria-Theresien-Straße", "21", 6020, "Innsbruck", "Tirol");

        Adresse[] adressen = { a1, a2, a3, a4 };
        List<Person> personen = new List<Person>();

        personen.Add(new Person(1, "Anna", "Huber", "anna.huber@example.at", new DateTime(2009, 3, 12), a1));
        personen.Add(new Person(2, "Markus", "Huber", "markus.huber@example.at", new DateTime(1980, 7, 5), a1));
        personen.Add(new Person(3, "Sabine", "Huber", "sabine.huber@example.at", new DateTime(1982, 11, 19), a1));
        personen.Add(new Person(4, "Lukas", "Gruber", "lukas.gruber@example.at", new DateTime(2001, 1, 23), a2));
        personen.Add(new Person(5, "Mira", "Yilmaz", "mira.yilmaz@example.at", new DateTime(1999, 9, 14), a2));
        personen.Add(new Person(6, "Thomas", "Bauer", "thomas.bauer@example.at", new DateTime(1975, 4, 30), a3));
        personen.Add(new Person(7, "Julia", "Steiner", "julia.steiner@example.at", new DateTime(2004, 12, 8), a4));
        personen.Add(new Person(8, "Felix", "Moser", "felix.moser@example.at", new DateTime(2003, 6, 17), a4));
        personen.Add(new Person(9, "Laura", "Wagner", "laura.wagner@example.at", new DateTime(2005, 2, 10), a3));
        personen.Add(new Person(10, "David", "Hofer", "david.hofer@example.at", new DateTime(2000, 8, 25), a2));

        Console.WriteLine("1. Alle Personen");
        double summe = 0;

        for (int i = 0; i < personen.Count; i++)
        {
            Console.WriteLine(personen[i]);
            summe += personen[i].BerechneAlter();
        }

        Console.WriteLine("\n2. Durchschnittsalter: " + summe / personen.Count);

        Console.WriteLine("\n3. Adressen und Bewohner");
        for (int i = 0; i < adressen.Length; i++)
        {
            Console.WriteLine("\n" + adressen[i]);
            int anzahl = 0;

            for (int j = 0; j < personen.Count; j++)
            {
                if (personen[j].Hauptwohnsitz == adressen[i])
                {
                    Console.WriteLine(personen[j].VollerName());
                    anzahl++;
                }
            }
            Console.WriteLine("Anzahl: " + anzahl);
        }

        Console.Write("\n4. Bundesland eingeben: ");
        string bundesland = Console.ReadLine();
        int treffer = 0;

        for (int i = 0; i < personen.Count; i++)
        {
            if (personen[i].Hauptwohnsitz.Bundesland == bundesland)
            {
                Console.WriteLine(personen[i].VollerName());
                treffer++;
            }
        }
        if (treffer == 0)
        {
            Console.WriteLine("Keine Personen gefunden.");
        }

        Console.WriteLine("\n5. Mitbewohner");
        int personIndex = WaehlePerson(personen);
        int mitbewohner = 0;

        for (int i = 0; i < personen.Count; i++)
        {
            if (personen[i].Hauptwohnsitz == personen[personIndex].Hauptwohnsitz && i != personIndex)
            {
                Console.WriteLine(personen[i].VollerName());
                mitbewohner++;
            }
        }
        if (mitbewohner == 0)
        {
            Console.WriteLine("Diese Person wohnt alleine.");
        }

        Console.WriteLine("\n6. Umzug");
        personIndex = WaehlePerson(personen);

        for (int i = 0; i < adressen.Length; i++)
        {
            Console.WriteLine((i + 1) + ": " + adressen[i]);
        }

        int adressIndex = -1;
        while (adressIndex == -1)
        {
            Console.Write("Neue Adressnummer: ");
            string eingabe = Console.ReadLine();

            for (int i = 0; i < adressen.Length; i++)
            {
                if ((i + 1).ToString() == eingabe)
                {
                    if (adressen[i] != personen[personIndex].Hauptwohnsitz)
                    {
                        adressIndex = i;
                    }
                }
            }
            if (adressIndex == -1)
            {
                Console.WriteLine("Bitte eine gültige, andere Adresse wählen.");
            }
        }
        personen[personIndex].Hauptwohnsitz = adressen[adressIndex];

        Console.WriteLine("\nAlle Personen nach dem Umzug");
        for (int i = 0; i < personen.Count; i++)
        {
            Console.WriteLine(personen[i]);
        }
    }
    static int WaehlePerson(List<Person> personen)
    {
        while (true)
        {
            Console.Write("Personen-ID: ");
            string eingabe = Console.ReadLine();
            for (int i = 0; i < personen.Count; i++)
            {
                if (personen[i].Id.ToString() == eingabe)
                {
                    return i;
                }
            }
            Console.WriteLine("Diese ID gibt es nicht.");
        }
    }
}