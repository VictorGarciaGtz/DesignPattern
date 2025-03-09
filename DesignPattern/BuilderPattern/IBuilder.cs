using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPattern
{
    public interface IBuilder
    {
        void Reset();

        void SetAlcohol(decimal alcohol);

        void SetMilk(int milk);

        void SetWater(int water);

        void AddIngredients(List<string> ingredients);

        void Mix();

        void Rest(int time);
    }
}
