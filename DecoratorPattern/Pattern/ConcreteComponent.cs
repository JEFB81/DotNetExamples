using System;

namespace DecoratorPattern.Pattern
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Execute: ConcreteComponent.Operation()");
        }
    }
}
