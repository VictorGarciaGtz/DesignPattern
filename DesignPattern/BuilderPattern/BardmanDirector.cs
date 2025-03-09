using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPattern
{
    public class BardmanDirector
    {
        private IBuilder _builder;

        public BardmanDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public void PrepareMargarita()
        {
            _builder.Reset();
            _builder.SetAlcohol(0.5m);
            _builder.SetWater(100);
            _builder.SetMilk(0);
            _builder.AddIngredients(new List<string> { "Lemon", "Salt", "Ice" });
            _builder.Mix();
            _builder.Rest(5);
        }
    }
}
