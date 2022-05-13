namespace MammaMiaPizzaria.Models
{
    public class Pizza
    {
        public int id { get; set; } 
        public string? Nome { get; set; }
        public string? Ingredienti { get; set; }
        public string? immagine { get; set; }
        public double Prezzo { get; set; }

        public Pizza() 
        {
            
        }

        public Pizza(int id, string Nome, string Ingredienti,string immagine, double Prezzo)
        {
            this.id = id;
            this.Nome = Nome;
            this.Ingredienti = Ingredienti;
            this.immagine = immagine;
            this.Prezzo = Prezzo;
        }
    }
}
