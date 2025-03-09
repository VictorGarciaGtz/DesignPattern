using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPattern
{
    public class PreparedDrink
    {
        public List<string> Ingredients { get; set; }

        public int Milk { get; set; }

        public int Water { get; set; }

         public decimal Alcohol { get; set; }

        public string Result;

    }
}
