using System;

public class Adresse
{
    public string Strasse { get; set; }
    public string Hausnummer { get; set; }
    public int Plz { get; set; }
    public string Ort { get; set; }
    public string Bundesland { get; set; }
    public string Land { get; set; }

    public Adresse(string strasse, string hausnummer, int plz, string ort, string bundesland, string land = "Österreich")
    {
        Strasse = strasse;
        Hausnummer = hausnummer;
        Plz = plz;
        Ort = ort;
        Bundesland = bundesland;
        Land = land;
    }

    public override string ToString()
    {
        return Strasse + " " + Hausnummer + ", " + Plz + " " + Ort + ", " + Bundesland + ", " + Land;
    }
}