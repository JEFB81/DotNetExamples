using System;

namespace DecoratorPattern.Pattern
{
    public static class Pattern
    {
        public static void Start()
        {
            // Create ConcreteComponent and two Decorators
            var component = new ConcreteComponent();
            var decoratorA = new ConcreteDecoratorA();
            var decoratorB = new ConcreteDecoratorB();

            // Link decorators
            // "Execute: ConcreteComponent.Operation()"
            decoratorA.SetComponent(component);

            // Execute: ConcreteDecoratorA.Operation()"
            decoratorB.SetComponent(decoratorA);

            // Execute: ConcreteDecoratorB.Operation()"
            decoratorB.Operation();
            
            // Wait for user
            Console.ReadKey();
        }
    }
}
