using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTypeExamples
{
    // Declaring a class as abstract means it cannot be instantiated in its own right
    // i.e we may have an abstract class for a ball, but never want anyone to create a ball
    // object. They can inherit from ball and become foot,cricket,ruby... ball
    // but never just a ball, i.e. the concept of a ball is abstract.
    public abstract class AbstractClass
    {
        public  void Play()
        {
            // Step 1 Code can only exisit in a subclass. Any subclass MUST define this code
            Step1();

            // if no code exisits in the subclass, the abstract code is used
            // othewise the subclass code is used 
            Step2();
            Step3();
        }

        // if a method is marked abstract it mas no body and MUST be implemented in the subclass
        // i.e., even if the code does nothing, there must be code in place
        public abstract void Step1();


        public virtual void Step2()
        {
            Console.WriteLine("Step 2 in the base version of the abstract class");
        }

        public virtual void Step3()
        {
            Console.WriteLine("Step 3 in the base version of the abstract class");
        }
    }
}
