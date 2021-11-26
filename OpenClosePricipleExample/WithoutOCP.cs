using System;

namespace OpenClosePricipleExample
{
    // without OCP
    public class PizzaMaker
    {
        private PizzaOven _pizzaOven;

        public PizzaMaker()
        {
            _pizzaOven = new PizzaOven();
        }

        public void MakePizza(PizzaType type)
        {
            PizzaIngredients pizzaIngredients;
            // the problem is here, this part always will be changed when 
            // a new pizza is added to the menu
            switch (type)
            {
                case PizzaType.Margarita:
                    pizzaIngredients = new PizzaIngredients();
                    Console.WriteLine("Making Tomato Pizza");
                    _pizzaOven.Bake(pizzaIngredients);
                    break;
                case PizzaType.Tuna:
                    pizzaIngredients = new PizzaIngredients();
                    Console.WriteLine("Making Tuna Pizza");
                    _pizzaOven.Bake(pizzaIngredients);
                    break;
                default:
                    pizzaIngredients = new PizzaIngredients();
                    _pizzaOven.Bake(pizzaIngredients);
                    break;
            }
        }
    }

    // in OCP if we add a PizzaType we have to change MakePizza class by every
    // new PizzaType
    public enum PizzaType
    {
        Margarita = 1,
        Tuna = 2
    }

    public class PizzaOven
    {
        public void Bake(PizzaIngredients ingredients)
        {
            Console.WriteLine("Baking a Pizza for 10 minutes");
        }
    }

    public class PizzaIngredients
    {
    }
}
