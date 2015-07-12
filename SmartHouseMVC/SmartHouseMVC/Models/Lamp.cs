using System;

namespace Models.SmartHouseMVC
{
    [Serializable]
    public class Lamp : Device
    {
        public Lamp()
        { }
        public Lamp(string name, bool status = false):base(name,status)
        { }

        public override string ToString()
        {
            string state;
            if (this.Status)
                state = "Включен";
            else
                state = "Выключен";
            return "Светильник " + this.Name + " " + state;
        }
    }
}