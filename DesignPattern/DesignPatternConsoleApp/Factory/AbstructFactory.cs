using AbstructFactoryDesignPattern.Interface;
using AbstructFactoryDesignPattern.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactoryDesignPattern.Factory
{
    public class AbstructFactory
    {
        public static IDeviceFactory CreateDeviceFactory(string company)
        {
            switch(company)
            {
                case "HP":
                    return new HPFactory();                    
                case "Lenovo":
                    return new LenovoFactory();                   
                default:
                    return new HPFactory();                    
            }            

        }
    }
}
