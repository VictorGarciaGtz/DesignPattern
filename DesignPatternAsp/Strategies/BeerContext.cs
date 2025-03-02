using DesignPattern.Repository;
using DesignPatternAsp.Models.ViewModels;

namespace DesignPatternAsp.Strategies
{
    public class BeerContext
    {
        private IBeerStrategy _beerStrategy;

        public IBeerStrategy strategy {  set { _beerStrategy = value; } }

        public BeerContext(IBeerStrategy beerStrategy) 
        { 
            _beerStrategy = beerStrategy;
        
        }

        public void Add(FormBeerViewModel beerViewModel, IUnitOfWork unitOfWork) 
        { 
            _beerStrategy.Add(beerViewModel, unitOfWork);
        
        }
    }
}
