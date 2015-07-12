using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSmartHouse
{
    public interface ILouvers : IDevice
    {
        bool IsLower { get; set; }
        void LowerUp();
        void AngelUp();
        void AngelDown();
    }
}
