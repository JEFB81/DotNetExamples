using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePricipleExample
{
    // class can only make a pizza at a time
    public class Maker
    {
        private Oven _pizzaOven;    

        public Maker()
        {
            _pizzaOven = new Oven();
        }

        public void MakePizza(Pizza pizza)
        {
            Console.WriteLine($"Making {pizza.PizzaType} Pizza");
            pizza.Make(_pizzaOven);
        }
    }

    // class can make multiple pizza at a time
    public class MultipleMakers 
    {
        private readonly IEnumerable<Pizza> _pizzas;
        private Oven _pizzaOven;

        public MultipleMakers(IEnumerable<Pizza> pizzas)
        {
            _pizzas = pizzas;
            _pizzaOven = new Oven();
        }

        public void MakePizzaOrder()
        { 
            foreach (var pizza in _pizzas)
            {
                Console.WriteLine($"Making {pizza.PizzaType} Pizza");
                pizza.Make(_pizzaOven);
            } 
        }
    }

    // Base Class
    public abstract class Pizza
    {
        protected Ingredients _ingredients; 

        public Type PizzaType { get { return _pizzaType; } }
        private Type _pizzaType;

        public Pizza(Type pizzaType)
        {
            _pizzaType = pizzaType;          
        }

        protected virtual void SetIngredients() 
        {            
            Console.WriteLine("Set Base Pizza Ingratients");
        }

        public void Make(Oven oven) 
        {
            oven.Bake(_ingredients);
        }
    }

    public class Ingredients
    {
    }

    public class Oven
    {
        public void Bake(Ingredients ingredients)
        {
            Console.WriteLine("Baking a Pizza for 10 minutes");
        }
    }

    public class MargaritaPizza : Pizza
    {
        public MargaritaPizza() : base(Type.Margarita)
        {
            SetIngredients();
        }

        protected override void SetIngredients()
        {
            // to set basic ingredients
            base.SetIngredients();
            Console.WriteLine("Add Margarita Pizza Ingredients"); 
        }
    }

    public class Tuna : Pizza
    {
        public Tuna() : base(Type.Tuna)
        {
            SetIngredients();
        }

        protected override void SetIngredients()
        {
            // to set basic ingredients
            base.SetIngredients();
            Console.WriteLine("Add Tuna Pizza Ingredients"); 
        }
    }

    public enum Type
    {
        Margarita = 1,
        Tuna = 2
    }
}
