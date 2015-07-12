using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSmartHouse
{
    public interface IHeating : IDevice
    {
        byte Temperature { get; set; }
    }
}
