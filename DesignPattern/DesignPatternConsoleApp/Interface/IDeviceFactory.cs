using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactoryDesignPattern.Interface
{
    public interface IDeviceFactory
    {
        IDevice CreateMobile();
        IDevice CreateLaptop();       
    }
}
