

//using DesignPattern.FactoryPattern;

//SaleFactory storeSaleFactory = new StoreSaleFactory(10);
//InternetSaleFactory internetSaleFactory = new InternetSaleFactory(10);

//ISale storeSale = storeSaleFactory.GetSale();
//storeSale.Sell(100);

//ISale internetSale = internetSaleFactory.GetSale();
//internetSale.Sell(100);

using DesignPattern.Models;
using DesignPattern.RepositoryPattern;

using (var context = new DesignPatternContext())
{
    
    //var beerRepository = new BeerRepository(context);
    //var beer = new Beer
    //{
    //    Name = "Heineken"
    //};

    //beerRepository.Add(beer);
    //beerRepository.Save();

    //var list = beerRepository.Get();

    //foreach (var item in list)
    //{
    //    Console.WriteLine(item.Name);
    //}

    var beerRepository = new Repository<Beer>(context);
    var beer = new Beer
    {
        Name = "Corona"
    };
    beerRepository.Add(beer);

    beerRepository.Save();

    var list = beerRepository.Get();

    foreach (var item in list)
    {
        Console.WriteLine(item.Name);
    }
}
