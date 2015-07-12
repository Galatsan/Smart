using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSmartHouse
{
    public interface ITV : IDevice
    {
        Channels Channel { get; set; }
        void PreviousChannel();
        void NextChannel();
        void AddVolume();
        void AddContrast();
        void AddAbruptness();
        void SubVolume();
        void SubContrast();
        void SubAbruptness();
    }
}
