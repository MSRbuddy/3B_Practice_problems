﻿namespace PublicAccessModifier
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class AnotherAssemblyClass1 : AssemblyOneClass1
    {
        public void Display4()
        {
            //We Can access the public Member from Derived Classes
            //from Other Assemblies
            Console.WriteLine(Id); //No-Compile Time Error
        }
    }
    public class AnotherAssemblyClass2
    {
        public void Dispplay3()
        {
            //We Can access the public Member from Non-Derived Classes
            //from Other Assemblies
            AssemblyOneClass1 obj = new AssemblyOneClass1();
            Console.WriteLine(obj.Id); //No-Compile Time Error
        }
    }
    //The scope of the public member in C#.NET is as follows:

    //With the Class: YES
    //Derived Class in Same Assembly: YES
    //Non-Derived Class in Same Assembly: YES
    //Derived Class in Other Assemblies: YES
    //Non-Derived Class in Other Assemblies: YES
}