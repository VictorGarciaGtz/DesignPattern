using DesignPattern.Models.Data;
using DesignPattern.Repository;
using DesignPatternAsp.Models.ViewModels;

namespace DesignPatternAsp.Strategies
{
    public class BeerWithBrandStrategy : IBeerStrategy
    {
        public void Add(FormBeerViewModel beerViewModelM, IUnitOfWork unitOfWork)
        {
            var beer = new Beer();

            beer.Name = beerViewModelM.Name;

            var brand = new Brand();
            brand.Name = beerViewModelM.OtherBrand;
            brand.BrandId = Guid.NewGuid();

            beer.BrandId = brand.BrandId;

            unitOfWork.Brands.Add(brand);
            unitOfWork.Beers.Add(beer);

            unitOfWork.Save();

        }
    }
}
