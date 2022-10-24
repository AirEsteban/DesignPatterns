// See https://aka.ms/new-console-template for more information


using FactoryPattern.Classes;

var factA = new ProductAFactory();
var factB = new ProductBFactory();

factA.CreateProduct();
factB.CreateProduct();
