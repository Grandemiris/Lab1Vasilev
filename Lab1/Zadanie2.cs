using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Student
    {
        public string name { get; set; }
        public string gender { get; set; }
        public string hairColor { get; set; }
        public int age { get; set; }

        public void Add(Student x)
        {
            name += x.name;
            gender += x.gender;
            hairColor += x.hairColor;
            age += x.age;
        }


    }
}
