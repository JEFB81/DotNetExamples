namespace ExerciesIntermediateClassesInterfaces.Fields
{
    class ProcessField
    {
        public static void TestCustumer()
        {
            var customer = new Costumer(1);
            customer.Orders.Add(new Orders());
            customer.Orders.Add(new Orders());

            // because the promote method empty the list.
            // the count will give a 0 instead of 2.
            customer.Promote();


            System.Console.WriteLine($"Amount of order for customer:{customer.Orders.Count}");
        }
    }
}
