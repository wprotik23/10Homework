using System;
using System.Collections.Generic;
using System.Text;
using Printers;

namespace Lesson1_Struct

{
    public struct Person
    {
        string name;
        string surname;
        int age;
        public IPrinter Printer { get; set; }


        public Person(string nam, string surnam, int ag, IPrinter printe)
        {
            name = nam;
            surname = surnam;
            age = ag;
            Printer = printe;


        }
        public string ageCompare(int n)
        {
            if (n < this.age)
                return $"{this.name} {this.surname} older than {n}";
            else
                return $"{this.name} {this.surname} younger than {n}";
        }

        public void Print(int n)
        {
            Printer.Print(ageCompare(n));
        }
    }
}
