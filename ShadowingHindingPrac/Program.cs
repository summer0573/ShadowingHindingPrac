﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowingHindingPrac {

    internal class Program
    {
        class Animal
        {
            public virtual void Eat()
            {
                Console.WriteLine("촵촵촵촵!!!!");
            }
        }

        class Dog : Animal { 
            public void Eat()
            {
                Console.WriteLine("냠냠냠냠냠!!!!");
            }
        }

        class Cat : Animal
        {
            public void Eat()
            {
                Console.WriteLine("냠냠냠냠냠!!!!");
            }
        }
    }

    class Parent
    {
        public int variable = 273;
        public void Method()
        {
            Console.WriteLine("부모의 메서드");
        }

        public void Method2()
        {
            Console.WriteLine("부모의 메서드");
        }

    }
    class Child : Parent
    {
        public new string variable = "shadowing";
        public new void Method()
        {
            Console.WriteLine("자식의 메서드");
        }

        public virtual void Method2() //
        {
            Console.WriteLine("자식의 메서드");
        }
    }

    class Program
    {
        public static int number = 20;

        static void Main(string[] args)
        {
            Console.WriteLine(number);
            Child child = new Child();
            Console.WriteLine(child.variable);
            Parent p = child;
            Console.WriteLine(p.variable);

            child.Method();
            p.Method();

            child.Method2();
            p.Method2();

            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Cat(), new Dog(),
            };
            foreach(var item in Animals)
            {
                item.Eat();
            }
        }
    }
}
