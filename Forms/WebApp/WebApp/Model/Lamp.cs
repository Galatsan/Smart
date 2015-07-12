using System;

namespace WebSmartHouse
{
    [Serializable]
    public class Lamp : IDevice
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        
        public Lamp()
        { }
        public Lamp(string name, bool status = false)
        {
            this.Name = name;
            this.Status = status;
        }
        
        public void OnOff()
        {
            if (Status)
            {
                Status = false;
            }
            else
            {
                Status = true;
            }
        }
        public override string ToString()
        {
            string state;
            if (this.Status)
                state = "Включен";
            else
                state = "Выключен";
            return "Светильник " + this.Name + " " + state;
        }
        public string TypeAndName()
        {
            return String.Format("Светильник {0}", this.Name);
        }
    }
}