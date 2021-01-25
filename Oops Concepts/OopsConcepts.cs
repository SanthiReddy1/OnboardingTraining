using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts
{
    class OopsConcepts
    {        
        public const int constvariable = 10;
        public readonly int readonlyvariable = 11;

        public OopsConcepts(int parameter)
        {
            readonlyvariable = parameter;
            Console.WriteLine("Value of read only variable:" + readonlyvariable);
        }
        
        public static void Main(string[] args)
        {
            OopsConcepts OopsConceptsObject = new OopsConcepts(15);
            Encapsulation encapsulationObject = new Encapsulation();
            DerivedClass DerivedClassObject = new DerivedClass();
            encapsulationObject.SetPrivateVariable(12);
            Console.WriteLine("Value of public variable:" + encapsulationObject.publicvariable);
            Console.WriteLine("Value of private variable:" + encapsulationObject.GetPrivateVariable());
            Console.WriteLine("Value of constant variable:" + constvariable);
            encapsulationObject.internalvariable = 30;
            Console.WriteLine("Value of internal variable:" + encapsulationObject.internalvariable);
            DerivedClassObject.PrintProtectedVariable();

            InterfaceImplementation interfaceimplementationobject = new InterfaceImplementation();
            interfaceimplementationobject.InterfaceMethod();

            AbstractClassImplementation abstractmethodobject = new AbstractClassImplementation();
            abstractmethodobject.Method1();
            abstractmethodobject.Method2();

            PolymorphismImplementation polymorphismimplementation = new PolymorphismImplementation();
            polymorphismimplementation.MethodOverloading1();
            polymorphismimplementation.MethodOverloading1(1);
            polymorphismimplementation.MethodOverriding();
        }
        
    }
}
    

