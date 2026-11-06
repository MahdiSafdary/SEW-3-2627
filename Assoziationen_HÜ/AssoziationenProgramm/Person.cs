using System;

public class Person
{
    public int Id { get; set; }
    public string Vorname { get; set; }
    public string Nachname { get; set; }
    public string EMail { get; set; }
    public DateTime Geburtsdatum { get; set; }
    public Adresse Hauptwohnsitz { get; set; }

    public Person(int id, string vorname, string nachname, string email, DateTime geburtsdatum, Adresse hauptwohnsitz)
    {
        this.Id = id;
        this.Vorname = vorname;
        this.Nachname = nachname;
        this.EMail = email;
        this.Geburtsdatum = geburtsdatum;
        this.Hauptwohnsitz = hauptwohnsitz;
    }
    public int BerechneAlter()
    {
        int alter = DateTime.Today.Year - Geburtsdatum.Year;

        if (Geburtsdatum.AddYears(alter) > DateTime.Today)
        {
            alter--;
        }

        return alter;
    }
    public string VollerName()
    {
        return Vorname + " " + Nachname;
    }
    public override string ToString()
    {
        return Id + ": " + VollerName() + ", " + BerechneAlter() + " Jahre, " + EMail +", Hauptwohnsitz: " + Hauptwohnsitz;
    }
}