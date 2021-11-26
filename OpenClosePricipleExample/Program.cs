using System;
using System.Collections.Generic;

namespace OpenClosePricipleExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            MultiplePizzaWithOCP();
            //WithOCP();
        }

        public static void MultiplePizzaWithOCP()
        {            
            var pizzas = new List<Pizza>
            {
                new MargaritaPizza(),
                new Tuna()
            };
            var pizzaMaker = new MultipleMakers(pizzas);
            pizzaMaker.MakePizzaOrder();

            Console.ReadLine();
        }

        public static void WithOCP() 
        {
            Maker pizzaMaker = new Maker();
            MargaritaPizza margarita = new MargaritaPizza();            
            pizzaMaker.MakePizza(margarita);

            Console.ReadLine();
        }

        public static void WithoutOCP() 
        {
            Console.WriteLine("Pizza");
            PizzaMaker pizzaMaker = new PizzaMaker();
            pizzaMaker.MakePizza(PizzaType.Margarita);
            Console.WriteLine();
        }
    }
  

}
