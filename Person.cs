using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Interface02
{
    internal class Person
    {
        string name;
        readonly string username;  // Readonly field can be defined at runtime.
        int age;
        const int abc = 5; //Const need to be defined at the time of assignment.

        public Person(string name, string username, int age)
        {
            this.name = name;
            this.username = username;
            this.age = age;
        }
    }
    public override string ToString()
    {
        return this.name + " " + this.username + " " + this.age;
    }
}
