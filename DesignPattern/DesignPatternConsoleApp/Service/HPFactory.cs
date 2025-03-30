using AbstructFactoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactoryDesignPattern.Service
{
    public class HPFactory : IDeviceFactory
    {
        public IDevice CreateMobile()
        {
            return new HpMobile();
        }

        public IDevice CreateLaptop()
        {
            return new HpLaptop();
        }        
    }
}
