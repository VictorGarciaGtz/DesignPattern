using DesignPattern.Repository;
using DesignPatternAsp.Models.ViewModels;

namespace DesignPatternAsp.Strategies
{
    public interface IBeerStrategy
    {
        public void Add(FormBeerViewModel beerViewModelM, IUnitOfWork unitOfWork);
    }
}
