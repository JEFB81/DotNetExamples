using ExerciesIntermediateClassesInterfaces.MethodOverriding;
using AbsMem = ExerciesIntermediateClassesInterfaces.AbstractClassesAndMembers;
using System.Collections.Generic;
using ExerciesIntermediateClassesInterfaces.Polymorphism;
using ExerciesIntermediateClassesInterfaces.AccessModifiers;
using System;

namespace ExerciesIntermediateClassesInterfaces
{
    public class Runner
    {
        public static void CustomerAccessModifiers()
        {
            var customer = new Customer();
            customer.Promote();
        }

        public static void PersonAccessModifier()
        {
            var person = new PersonExample1();
            person.SetBirthdate(DateTime.Now); // new DateTime(1982,1,2);

            Console.WriteLine($"Birthdate person: {person.GetBirthdate()}");
        }

        // when creating new shape there isnt any impact on other classes
        public void RunMethodOverriding() 
        {
            
            var shapes = new List<Shape>
            {
                new Circle { Width = 100, Height = 200, Radius = 1},
                new Rectangle { Width = 200, Height = 300, BorderSize = 10}
            };

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }

        public void RunAbstractClassesAndMembers() 
        {

            //var shape = new AbsMem.Shape(); // it wont work because of abtract 

            var shapes = new List<AbsMem.Shape>
            {
                new AbsMem.Circle { Width = 100, Height = 200, Radius = 1},
                new AbsMem.Rectangle { Width = 200, Height = 300, BorderSize = 10}
            };
        }

        public void Polimorphism() 
        {
            var processor = new ChannelProcessor();
            processor.RegisterNotificationChannel( new MailNotificationChannel());
            processor.RegisterNotificationChannel( new SmsNotificationChannel());
            processor.ProcessMessage();

        }
    }
}
