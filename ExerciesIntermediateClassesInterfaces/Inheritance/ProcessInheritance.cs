namespace ExerciesIntermediateClassesInterfaces.Inheritance
{
    class ProcessInheritance
    {
        public static void Inheritance()
        {
            var text = new Text();
            // Width is een element van de base or parent class (Presentation)
            text.Width = 100;

            text.Copy();
            text.Print();

        }
    }
}
