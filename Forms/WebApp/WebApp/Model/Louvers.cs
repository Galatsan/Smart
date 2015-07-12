using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSmartHouse
{
    [Serializable]
    public class Louvers : ILouvers
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public bool IsLower{ get; set; }
        private byte angle;
        public byte Angel 
        { 
            get 
            {
                return angle;
            }
            set 
            {
                if (value >= 0 && value <= 180)
                {
                    angle = value;
                }
            } 
        }
        public Louvers()
        { }
        public Louvers(string name, bool status = false, bool isLower = false, byte angle = 90)
        {
            this.Status = status;
            this.Name = name;
            this.IsLower = isLower;
            this.Angel = angle;
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

        public void LowerUp()
        {
            if (IsLower)
                IsLower = false;
            else
                IsLower = true;
        }

        public void AngelUp()
        {
            Angel++;
        }

        public void AngelDown()
        {
            Angel--;
        }

        public override string ToString()
        {
            string state = "Жалюзи " + this.Name + " ";
            if (this.Status)
                state += "Включены";
            else
                state += "Выключены";

            if (IsLower)
                state += " Опущены ";
            else
                state += " Подняты ";
            state += " под углом  " + this.Angel;
            return state;
        }
        public string TypeAndName()
        {
            return String.Format("Жалюзи {0}", this.Name);
        }
    }
}