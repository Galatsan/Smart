using System;

namespace WebSmartHouse
{ 
    [Serializable]
    public class Heating : IHeating
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        private byte temperatura;
        public byte Temperature
        {
            get
            {
                return temperatura;
            }
            set
            {
                if (value >= 0 && value <= 25)
                {
                    temperatura = value;
                }
            }
        }

        public Heating()
        { }

        public Heating(string name, bool status = false, byte temperatura = 15)
        {
            this.Status = status;
            this.Temperature = temperatura;
            this.Name = name;
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
            return String.Format("Обогреватель {0} {1} температура {2}", this.Name, state, this.Temperature);
        }
        public string TypeAndName()
        {
            return String.Format("Обогреватель {0}", this.Name);
        }
    }
}