

using DesignPattern.FactoryPattern;

SaleFactory storeSaleFactory = new StoreSaleFactory(10);
InternetSaleFactory internetSaleFactory = new InternetSaleFactory(10);

ISale storeSale = storeSaleFactory.GetSale();
storeSale.Sell(100);

ISale internetSale = internetSaleFactory.GetSale();
internetSale.Sell(100);
