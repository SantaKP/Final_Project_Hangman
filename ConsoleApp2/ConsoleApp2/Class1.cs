using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Animals
    {
        public string Animal, Habitat, Hint;
        public Animals(string rawData)
        {
            string[] data = rawData.Split(',');

            this.Animal = data[0];
            this.Habitat = data[1];
            this.Hint = data[2];

        }


    }
}
