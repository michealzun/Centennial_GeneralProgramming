using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSassignment7
{
    public static class Db
    {
        static Random rand = new Random();

        static List<String> models;             //the models
        static List<int> numbers;               //the count

        public static void Init(string[] names)
        {
            models = new List<string>(names);
            numbers = new List<int>();
            foreach (String name in names)
                numbers.Add(rand.Next(6, 10) * 50);
        }

        public static int GetInventory(string car)
        {
            //may returns negative if the items is not found
            int position = models.IndexOf(car);
            //make sure method does not break!
            position = (position < 0) ? 0 : position;
            //calculate the change for new value
            int delta = rand.Next(20) - 10;

            int result = numbers[position];         //stores the actual value
            numbers[position] += delta;             //now change the value

            return result;
        }


    }


}
