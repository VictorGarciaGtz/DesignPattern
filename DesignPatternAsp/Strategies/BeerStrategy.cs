using DesignPattern.Models.Data;
using DesignPattern.Repository;
using DesignPatternAsp.Models.ViewModels;

namespace DesignPatternAsp.Strategies
{
    public class BeerStrategy : IBeerStrategy
    {
        public void Add(FormBeerViewModel beerViewModelM, IUnitOfWork unitOfWork)
        {
            var beer = new Beer();
            beer.Name = beerViewModelM.Name;
            beer.BrandId = (Guid?)beerViewModelM.BrandId;

            unitOfWork.Beers.Add(beer);
            unitOfWork.Save();
        }
    }
}
