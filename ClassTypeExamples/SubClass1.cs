using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTypeExamples
{
    class SubClass1 : AbstractClass
    {

        public void Play()
        {

            Console.WriteLine("Overriding a virtual base method");
        }

        // Methods marked abstract in the base class MUST be overidden
        public override void Step1()
        {
            Console.WriteLine("Overriding a virtual base method");
            
        }

        // step 2 exists in the base class


        // step 3 is a virtual class in the base class but CAN be overidden
        public override void Step3()
        {
            Console.WriteLine("Step 3 in the subclass version of the abstract class");
        }
    }
}
