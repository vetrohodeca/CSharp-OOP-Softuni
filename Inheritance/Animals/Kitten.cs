using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten:Cat
    {
        const string DEFAILT_GENDER = "Female";
        public Kitten(string name, int age) : base(name, age, DEFAILT_GENDER)
        {

        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
