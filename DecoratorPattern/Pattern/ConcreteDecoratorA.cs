using System;

namespace DecoratorPattern.Pattern
{
    public class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Execute: ConcreteDecoratorA.Operation()");
        }
    }
}
