// See https://aka.ms/new-console-template for more information
using AbstructFactoryDesignPattern.Factory;
using AbstructFactoryDesignPattern.Interface;

Console.WriteLine("Hello, World!");

string companyName = "Lenovo";

AbstructFactory.CreateDeviceFactory(companyName).CreateLaptop().GetDetails();

AbstructFactory.CreateDeviceFactory(companyName).CreateMobile().GetDetails();


Console.ReadLine();




