namespace HW7_Estate
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var Apart = new Apartament(60.3, 3, "Екатеринбург, Щербакова ул., 20 дом, 3 кв", true, false, 2);
            var PrivateHouse = new PrivateHouse(103.8, 6, "Сысерть, Попова ул., 18 дом", 2, 350);

            BayProperty<Apartament> bayApart = new BayProperty<Apartament>
                (
                    "Иван Иваныч",
                    "Пётр Петрович",
                    Apart,
                    6500000
                );

            Console.WriteLine(bayApart.Information());
            Console.WriteLine($"Стоимость 1 кв.м = " + bayApart.PriceOneMeter() + " руб.");

            Console.WriteLine("\n\n");

            BayProperty<PrivateHouse> Bayhouse = new BayProperty<PrivateHouse>
                (
                    "Сан Саныч",
                    "Глеб Глебыч",
                    PrivateHouse,
                    12350500.70
                );

            Console.WriteLine(Bayhouse.Information());
            Console.WriteLine($"Стоимость 1 кв.м = " + Bayhouse.PriceOneMeter() + " руб.");

        }
    }
}
