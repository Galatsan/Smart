using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSmartHouse
{
    public partial class EditDevice : System.Web.UI.Page
    {
        public IDevice d;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HeatClick(object sender, EventArgs e)
        {
            IHeating h = null;
            Button b = (Button)sender;
            if (b.Text == "+")
            {
                h = (IHeating)Session["EditDevice"];
                h.Temperature++;
            }
            else if (b.Text == "-")
            {
                h = (IHeating)Session["EditDevice"];
                h.Temperature--;
            }
            Session["EditDevice"] = h;
        }

        protected void TVClick(object sender, EventArgs e)
        {
            ITV tv = (ITV)Session["EditDevice"];
            Button b = (Button)sender;
            if (tv.Status)
            {
                if (b.Text == "Громкость+")
                    tv.AddVolume();

                else if (b.Text == "Громкость-")
                    tv.SubVolume();

                else if (b.Text == "Резкость+")
                    tv.AddAbruptness();

                else if (b.Text == "Резкость-")
                    tv.SubAbruptness();

                else if (b.Text == "Контраст+")
                    tv.AddContrast();

                else if (b.Text == "Контраст-")
                    tv.SubContrast();

                else if (b.Text == "<-")
                    tv.PreviousChannel();

                else if (b.Text == "->")
                    tv.NextChannel();
            }
            Session["EditDevice"] = tv;
        }

        protected void BoilerClick(object sender, EventArgs e)
        {
            IBoiler ib = (IBoiler)Session["EditDevice"];
            Button b = (Button)sender;
            if (ib.Status)
            {
                if (b.Text == "Наполнить")
                {
                    ib.MakeFull();
                }

                else if (b.Text == "Закипетить")
                {
                    ib.MakeBoils();
                }
                else if (b.Text == "Слить Воду")
                {
                    ib.MakeEmpty();
                }
            }
            Session["EditDevice"] = ib;
        }
        protected void LouversClick(object sender, EventArgs e)
        {
            ILouvers l = (ILouvers)Session["EditDevice"];
            Button b = (Button)sender;
            if (l.Status)
            {
                if (b.Text == "Угол+")
                {
                    l.AngelUp();
                }

                else if (b.Text == "Угол-")
                {
                    l.AngelDown();
                }
                else if (b.Text == "Поднять/Опустить")
                {
                    l.LowerUp();
                }
            }
            Session["EditDevice"] = l;
        }

        protected void OnOFF(object sender, EventArgs e)
        {
            IDevice d = (IDevice)Session["EditDevice"];
            d.OnOff();
            Session["EditDevice"] = d;
        }
    }
}