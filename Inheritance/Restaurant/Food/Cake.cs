using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Food
{
    public class Cake : Dessert
    {
        private const double CakeGrams = 250;
        const double CakeCalories = 1000;
        const decimal CakePrice = 5m;
        public Cake(string name) : base(name, CakePrice, CakeGrams, CakeCalories )
        {

        }

    }
}
