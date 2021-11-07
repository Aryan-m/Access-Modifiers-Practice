using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiersDemoLibrary
{
    public class AccessModifiersSameAssembly
    {
        public void printInternalField()
        {
            Console.WriteLine(AccessModifiersDemo.internalField);
        }
    } 
    
    public class AccessModifiersInherit : AccessModifiersDemo
    {
        public void printProtectedField()
        {
            Console.WriteLine("Protected:\n");
            Console.WriteLine(AccessModifiersDemo.protectedField + "\n");
        }

        public void printAndChangeProtectedEditableField()
        {
            Console.WriteLine("Protected Editable:\n");

            Console.WriteLine(AccessModifiersDemo.protectedEditableField + "\n");
            Console.WriteLine("changing...\n");
            AccessModifiersDemo.protectedEditableField = "Name Has changed";
            Console.WriteLine(AccessModifiersDemo.protectedEditableField + "\n");
        }
        public void printProtectedEditableField()
        {
            Console.WriteLine("Protected Editable:\n");

            Console.WriteLine(AccessModifiersDemo.protectedEditableField + "\n");
        }
    }
}
