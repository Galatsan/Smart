using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSmartHouse
{
    [Serializable]
    public class Boiler : IBoiler
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public bool IsFull { get; set; }
        public bool IsBoils { get; set; }

        public Boiler()
        { }

        public Boiler(string name, bool status = false, bool isFull = false,bool isBoils = false)
        {
            this.Status = status;
            this.Name = name;
            this.IsFull = isFull;
            this.IsBoils = isBoils;
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

        public void MakeFull()
        {
            if (!IsFull)
            {
                IsFull = true;
            }
        }

        public void MakeEmpty()
        {
            if (IsFull)
            {
                IsFull = false;
                IsBoils = false;
            }
        }

        public void MakeBoils()
        {
            if (IsFull && Status)
            {
                IsBoils = true;
            }
        }
        
        public override string ToString()
        {
            string state = "Бойлер " + Name + " ";
            
            if (this.Status)
                state += "Включен";
            else
                state += "Выключен";
            if (IsFull)
                state += " Наполнен ";
            else
            {
                state += " Пустой ";
                return state;
            }
            if (IsBoils)
                state += "Кипеток ";
            else
                state += "Не кипеток";
            return state;
        }
        public string TypeAndName()
        {
            return String.Format("Бойлер {0}", this.Name);
        }
    }
}