namespace ExerciesIntermediateClassesInterfaces.Constructor
{
    public class ProcessCustomer
    {
        public void UseCustomer()
        {
            var order = new Order
            {
                Id = 123,
            };

            var costumer = new Costumer();
            costumer.Orders.Add(order);
        }
    }
}
