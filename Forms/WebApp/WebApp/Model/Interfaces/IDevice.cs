using System;
namespace WebSmartHouse
{
    public interface IDevice
    {
        string Name { get; set; }
        bool Status { get; set; }
        void OnOff();
        string TypeAndName();
    }
}