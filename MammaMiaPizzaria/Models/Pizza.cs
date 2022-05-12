namespace MammaMiaPizzaria.Models
{
    public class Pizza
    {
        public string? Nome { get; set; }
        public string? Ingredienti { get; set; }
        public double Prezzo { get; set; }

        public Pizza() 
        {
            
        }

        public Pizza(string Nome, string Ingredienti, double Prezzo)
        {
            this.Nome = Nome;
            this.Ingredienti = Ingredienti;
            this.Prezzo = Prezzo;
        }
    }
}
