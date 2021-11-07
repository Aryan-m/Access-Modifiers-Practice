using System;
using AccessModifiersDemoLibrary;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessModifiersSameAssembly amd = new AccessModifiersSameAssembly();
            AccessModifiersInherit      ami = new AccessModifiersInherit();

            Console.WriteLine(AccessModifiersDemo.publicField + "\n");
            amd.printInternalField();
            ami.printProtectedField();
            ami.printAndChangeProtectedEditableField();
            ami.printProtectedEditableField();

        }
    }
}
