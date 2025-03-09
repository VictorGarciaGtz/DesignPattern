

//using DesignPattern.FactoryPattern;

//SaleFactory storeSaleFactory = new StoreSaleFactory(10);
//InternetSaleFactory internetSaleFactory = new InternetSaleFactory(10);

//ISale storeSale = storeSaleFactory.GetSale();
//storeSale.Sell(100);

//ISale internetSale = internetSaleFactory.GetSale();
//internetSale.Sell(100);

using DesignPattern.BuilderPattern;
using DesignPattern.Models;
using DesignPattern.RepositoryPattern;
using DesignPattern.StrategyPattern;

var builder = new PreparedAlcoholDrinkConcreteBuilder();
var director = new BardmanDirector(builder);

director.PrepareMargarita();
var preparedDrink = builder.GetPreparedDrink();

Console.WriteLine(preparedDrink.Result);

//var context = new Context(new CarStrategy());
//context.Run();

//using (var context = new DesignPatternContext())
//{

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

//var beerRepository = new Repository<Beer>(context);
//var beer = new Beer
//{
//    Name = "Corona"
//};
//beerRepository.Add(beer);

//beerRepository.Save();

//var list = beerRepository.Get();

//foreach (var item in list)
//{
//    Console.WriteLine(item.Name);
//}

//var unitOfWork = new DesignPattern.UnitOfWorkPattern.UnitOfWork(context);

//var beers = unitOfWork.Beers.Get();
//var beer = new Beer
//{
//    Name = "Budweiser"
//};

//unitOfWork.Beers.Add(beer);

//var brand = new Brand
//{
//    Name = "Budweiser"
//};

//unitOfWork.Brands.Add(brand);

//unitOfWork.Save();

//foreach (var item in beers)
//{
//    Console.WriteLine(item.Name);
//}

//}
