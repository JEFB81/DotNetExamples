using System;

namespace DecoratorPattern.Pattern
{
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("Execute: ConcreteDecoratorB.Operation()");
        }

        void AddedBehavior()
        {
        }
    }
}
