using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSmartHouse
{
    public class TV : ITV
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public Channels Channel{ get; set; }
        TVSettings Tvsettings;
        public TV()
        { }
        public TV(string name, Channels channel = Channels.Discovery, bool status = false)
        {
            this.Name = name;
            this.Status = status;
            this.Channel = channel;
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

        public void NextChannel()
        {
            if ((int)Channel < Enum.GetValues(typeof(Channels)).Length - 1)
            {
                Channel++;
            }
        }


        public void PreviousChannel()
        {
            if ((int)Channel > 0)
            {
                Channel--;
            }
        }
        public override string ToString()
        {
            string state;
            if (this.Status)
                state = "Включен";
            else
                state = "Выключен";
            return String.Format("Телевизор {0}, {1} ,Канал: {2} ,Громкость: {3}, Контраст: {4} ,Резкость: {5}",
                this.Name,
                state,
                (int)this.Channel + 1 + " " + this.Channel,
                this.Tvsettings.Volume,
                this.Tvsettings.Contrast,
                this.Tvsettings.Abruptness);
        }

        public string TypeAndName()
        {
            return String.Format("Телевизор {0}",this.Name);
            
        }
        public void AddVolume()
        {
            this.Tvsettings.Volume += 1;
        }

        public void AddContrast()
        {
            this.Tvsettings.Contrast += 1;
        }

        public void AddAbruptness()
        {
            this.Tvsettings.Abruptness += 1;
        }

        public void SubVolume()
        {
            this.Tvsettings.Volume -= 1;
        }

        public void SubContrast()
        {
            this.Tvsettings.Contrast -= 1;
        }

        public void SubAbruptness()
        {
            this.Tvsettings.Abruptness -= 1;
        }
        
    }
}