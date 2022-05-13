using MammaMiaPizzaria.Models;

namespace MammaMiaPizzaria.Utils
{
    public static class PizzaData
    {
        private static List<Pizza> Pizze;

        public static List<Pizza> GetPizzas()
        {
            if (Pizze != null)
            {
                return PizzaData.Pizze;
            }

            List<Pizza> NuovePizze = new List<Pizza>();

            int i = 0;
            Pizza pizza = new Pizza(i, "margherita", "mozzarella, pomodoro, olio di oliva, basilico", "https://www.buttalapasta.it/wp-content/uploads/2017/11/pizza-margherita.jpg", 4);
            NuovePizze.Add(pizza);
            Pizza pizza2 = new Pizza(i++, "margherita", "mozzarella, pomodoro, olio di oliva, basilico", "https://primochef.it/wp-content/uploads/2018/05/SH_pizza_alla_marinara-1200x800.jpg", 4);
            NuovePizze.Add(pizza2);
            Pizza pizza3 = new Pizza(i++, "margherita", "mozzarella, pomodoro, olio di oliva, basilico", "https://www.panineriatrentaelode.it/wp-content/uploads/2021/01/Pizza-4-formaggi-pizzeria-30-e-lode-1.jpg", 4);
            NuovePizze.Add(pizza3);
            Pizza pizza4 = new Pizza(i++, "margherita", "mozzarella, pomodoro, olio di oliva, basilico", "https://www.panineriatrentaelode.it/wp-content/uploads/2021/01/Pizza-4-formaggi-pizzeria-30-e-lode-1.jpg", 4);
            NuovePizze.Add(pizza4);
            Pizza pizza5 = new Pizza(i++, "margherita", "mozzarella, pomodoro, olio di oliva, basilico", "https://cdn.agrodolce.it/rbBVUaq8bErMgLcVmw2X5uXeNew=/1200x800/smart/https://www.agrodolce.it/app/uploads/2019/04/shutterstock-1239982861.jpg", 4);
            NuovePizze.Add(pizza5);
            Pizza pizza6 = new Pizza(i++, "margherita", "mozzarella, pomodoro, olio di oliva, basilico", "https://blog.giallozafferano.it/piovonoricette/wp-content/uploads/2018/02/IMG_2164.jpg", 4);
            NuovePizze.Add(pizza6);
            Pizza pizza7 = new Pizza(i++, "margherita", "mozzarella, pomodoro, olio di oliva, basilico", "https://www.ristoranteserenella.it/wp-content/uploads/2019/03/dinamite-pizza.jpg", 4);
            NuovePizze.Add(pizza7);
            Pizza pizza8 = new Pizza(i++, "margherita", "mozzarella, pomodoro, olio di oliva, basilico", "https://static.gamberorosso.it/2020/10/fratelli-cuore.jpg", 4);
            NuovePizze.Add(pizza8);
            Pizza pizza9 = new Pizza(i++, "margherita", "mozzarella, pomodoro, olio di oliva, basilico", "https://static.gamberorosso.it/2020/06/marasco-96ore-ricotta-nduja-bassa.jpg", 4);
            NuovePizze.Add(pizza9);

            PizzaData.Pizze = NuovePizze;

            return PizzaData.Pizze;
        }
    }
}
