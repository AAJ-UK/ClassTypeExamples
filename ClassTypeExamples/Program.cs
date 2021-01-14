using System;
using System.Collections.Generic;

namespace ClassTypeExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            // the abstract class is marked as abstract and so cannot be instantiated
            // AbstractClass myClass = new AbstractClass();

            AbstractClass myClass = new SubClass1();

            // Play()
            // Because we are creating our instance from the abstract class, it will use 
            // the abstract classes Play() Method is called. To call the Inherited classes version we would mark it as virtual or abstract 
            // so for a templ;ate pattern class, we now the structure defined in play will always be called
            myClass.Play();   

            // Step1()
            // Is defined as abstract so it HAS to be overidden in the inherrited class
            myClass.Step1();

            // Step 2()
            // This is marked as Virtual. It is  given code in the Abstract class, but could be overidden
            // If the overidden code did exist in the Sub Class, the sub classes code would be used
            // In this example the Subclass DOES NOT has its own version of the method code and the abstract code is used
            myClass.Step2();


            // Step 3()
            // This is marked as Virtual. It is given code in the Abstract class, but is overidden
            // If overidden code exisits in the Sub Class, the sub classes code will be used
            // In this example the Subclass has its own version of the method code so the subclass code is used
            myClass.Step3();


            // if we repreat this and instantiate the subclass as a sublass
            SubClass1 myClass1 = new SubClass1();


            //Play()
            // the subclasses Play method is called. Because Play is not virtual Subclass 1's Play()
            // Hides the base classes Play(). This is differenct from Overidding
            myClass1.Play();


            // These three methods behave in the same way as above
            myClass1.Step1();

            myClass1.Step2();

            myClass1.Step3();

            // So whats the difference
            // All classes that inherit from the abstract class can and be added to a list of type abstract
            // Interestingly above, when dealing with MyClass1, the subclasses play method was called
            // here the abstract classes base method is called, so its not  polymorphic in this sense
            
            List<AbstractClass> abstractClasses = new List<AbstractClass>();
            abstractClasses.Add(myClass);
            abstractClasses.Add(myClass1);

            foreach (AbstractClass c in abstractClasses)
            {
                c.Play();
            }


            List<SubClass1> SubClasses = new List<SubClass1>();
            // because the list is expecting subclasses we cannot use the base classes i.e. SubClasses.Add(myClass); doe not work
            SubClasses.Add(myClass1);

            // here, if we use 'foreach Subclass' we see the Sublass Method, if we use the abstract class we 
            // use the abstract class code.
            foreach (SubClass1 c in SubClasses)
            {
                c.Play();
            }

            myClass1.Play();

        }
    }
}
