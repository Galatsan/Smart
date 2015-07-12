using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSmartHouse
{
    public interface IBoiler : IDevice
    {
        bool IsFull { get; set; }
        bool IsBoils { get; set; }
        void MakeFull();
        void MakeEmpty();
        void MakeBoils();
    }
}
