using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        public Child(string Name, int Age):base(Name, Age)
        {

        }
        public override int Age
        {
            get
            {
                return base.Age;
            }
            protected set
            {
                if (value <= 18)
                {
                    base.Age = value;// ako valueto e po- malko ot 18, to togava se vliza  v base settera
                }

            }
        }
    }
}
