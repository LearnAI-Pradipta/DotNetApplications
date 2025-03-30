using AbstructFactoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactoryDesignPattern.Service
{
    public class LenovoMobile : IDevice
    {
        public void GetDetails()
        {
            Console.WriteLine("Lenovo Mobile");
        }
    }
}
