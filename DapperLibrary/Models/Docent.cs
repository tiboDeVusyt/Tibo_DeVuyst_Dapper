namespace DapperLibrary.Models
{
    public class Docent
    {
        public int DocentNr { get; set; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public double Wedde { get; set; }
        public int CampusNr { get; set; }
        public override string ToString()
        {
            return $"{Voornaam}  {Familienaam}";
        }
    }
}
