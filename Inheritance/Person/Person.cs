using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {

        private int age;
        private string name;
        public Person()
        {

        }
        public Person(string name)
        {
            this.Name = name;
        }
        public Person(string name, int age) : this(name)
        {
            this.Age = age;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public virtual int Age
        {
            get
            {
                return this.age;
            }
            protected set
            {
               if(value>=0)
                {
                    this.age = value;
                }
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"Name: {this.Name}, Age: {this.Age}");
            return result.ToString();
        }

    }
}
