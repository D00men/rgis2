namespace RGIS.Models;

public class Rezervacija
{
    private int iDRezervacije;
    private int iDDogodka;
    private int iDUporabnika;
    private DateTime datumRezervacije;
    private int steviloOseb;
    private string statusRezervacije;
    
    public int IDRezervacije { get; set; }
    public int IDDogodka { get; set; }
    public int IDUporabnika { get; set; }
    public DateTime DatumRezervacije { get; set; }
    public int SteviloOseb { get; set; }
    public string StatusRezervacije { get; set; }

    public Event Dogodek { get; set; }
    public User Uporabnik { get; set; }

    public bool NovaRezervacija(int iDDogodka, int iD_uporabnika, int steviloMest)
    {
        throw new System.NotImplementedException("Not implemented");
    }

    public List<Rezervacija> PridobiRezervacije(int iD_uporabnika)
    {
        throw new System.NotImplementedException("Not implemented");
    }

    private UpravljanjeRezervacije upravljanjeRezervacije;

    private RezervacijaUI rezervacijaUI;
}