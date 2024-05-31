using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Programmering2
{
    //Classen visar en Human med olika egenskaper (ID, Namn, År)
    internal class Human //class 1
    {
        private string id;
        private string name;
        private int age;

        //Här är en constractor som börjar classens egenskaper ett specifikt sätt (Programmet kommer skicka signal från början med iD)
        public Human(string id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        // Basically en get, set funktion för ID
        public string GetId() => id;
        public void SetId(string value) => id = value;

        // en get, set funktion för namn
        public string GetName() => name;
        public void SetName(string value) => name = value;
        // en get, set funktion för ålder
        public int GetAge() => age;
        public void SetAge(int value) => age = value;

        //Lägger till en extra funktion till bas klassen, gör så att stringen gör något annat än den ska göra egentligen
        public override string ToString()
        {
            return $"{name} ({id}) - Age: {age}";
        }

    }
    //class 2
    internal class Teacher : Human
    {
        //constructor 
        public Teacher(string id, string name, int age)
            : base(id, name, age)
        {
        }
        //visar string till teacher
        public override string ToString()
        {
            return $"{GetName()} (Teacher) - Age: {GetAge()}";
        }
    }
    //class 3
    internal class Professor : Teacher
    {
        public Professor(string id, string name, int age)
            : base(id, name, age)
        {
        }

        public override string ToString()
        {
            return $"{GetName()} (Professor) - Age: {GetAge()}";
        }
    }

}
