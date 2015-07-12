using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSmartHouse
{
    public partial class DevicesForm : System.Web.UI.Page
    {
        public Dictionary<string, List<IDevice>> allDevices = new Dictionary<string, List<IDevice>>();
        List<IDevice> ld;
        IDevice d;
        string deviceSelect;
        string deviceAdd;
        protected void Page_Load(object sender, EventArgs e)
        {
            deviceAdd = RadioButtonListDevice.SelectedValue;
            deviceSelect = DropDownListDevice.SelectedValue;
            if (Session["allDevices"] == null)
            {
                ld = new List<IDevice>();
                ld.Add(new Heating("Зал", true, 13));
                ld.Add(new Heating("Кухня", false, 15));
                ld.Add(new Heating("Спальня", false, 18));
                ld.Add(new Heating("Коридор", false, 21));
                allDevices.Add("Heating", ld);

                ld = new List<IDevice>();
                ld.Add(new Lamp("Зал", true));
                ld.Add(new Lamp("Кухня", false));
                ld.Add(new Lamp("Спальня", false));
                ld.Add(new Lamp("Коридор", false));
                allDevices.Add("Lamp", ld);

                ld = new List<IDevice>();
                ld.Add(new TV("Sony KDL-32W503A", Channels.FOX, true));
                ld.Add(new TV("Samsung JS9500", Channels.ICTV, true));
                ld.Add(new TV("Sony KDL-42W705B", Channels.УТ1, true));
                ld.Add(new TV("Samsung JS8500", Channels.Украина, true));
                allDevices.Add("TV", ld);

                ld = new List<IDevice>();
                ld.Add(new Boiler("1"));
                ld.Add(new Boiler("2"));
                ld.Add(new Boiler("3"));
                ld.Add(new Boiler("4"));
                allDevices.Add("Boiler", ld);

                ld = new List<IDevice>();
                ld.Add(new Louvers("Зал"));
                ld.Add(new Louvers("Кухня"));
                ld.Add(new Louvers("Спальня"));
                ld.Add(new Louvers("Коридор"));
                allDevices.Add("Louvers", ld);

                RefreshLists();
                Session["allDevices"] = allDevices;


            }
            else
            {
                allDevices = (Dictionary<string, List<IDevice>>)Session["allDevices"];
                RefreshLists();
            }
        }

        private void RefreshLists()
        {
            DropDownListDevice.Items.Clear();
            foreach (KeyValuePair<string, List<IDevice>> listDev in allDevices)
            {
                foreach (IDevice i in listDev.Value)
                {
                    DropDownListDevice.Items.Add(i.TypeAndName());
                }
            }
            if (deviceSelect != "")
                DropDownListDevice.SelectedValue = deviceSelect;
        }

        protected void OnOff_Click(object sender, EventArgs e)
        {

            string name;
            if (deviceSelect.Contains("Обогреватель"))
            {
                name = deviceSelect.Replace("Обогреватель", "").Trim();
                ld = allDevices["Heating"];
                OnOffDev(name);
            }
            else if (deviceSelect.Contains("Телевизор"))
            {
                name = deviceSelect.Replace("Телевизор", "").Trim();
                ld = allDevices["TV"];
                OnOffDev(name);
            }
            else if (deviceSelect.Contains("Бойлер"))
            {
                name = deviceSelect.Replace("Бойлер", "").Trim();
                ld = allDevices["Boiler"];
                OnOffDev(name);
            }
            else if (deviceSelect.Contains("Светильник"))
            {
                name = deviceSelect.Replace("Светильник", "").Trim();
                ld = allDevices["Lamp"];
                OnOffDev(name);
            }
            else if (deviceSelect.Contains("Жалюзи"))
            {
                name = deviceSelect.Replace("Жалюзи", "").Trim();
                ld = allDevices["Louvers"];
                OnOffDev(name);
            }
        }
        private void OnOffDev(string ClickDev)
        {
            d = ld.Find(i => i.Name == ClickDev);
            d.OnOff();
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            string name;
            if (deviceSelect.Contains("Обогреватель"))
            {
                name = deviceSelect.Replace("Обогреватель", "").Trim();
                ld = allDevices["Heating"];
                DeleteDev(name);
            }
            else if (deviceSelect.Contains("Телевизор"))
            {
                name = deviceSelect.Replace("Телевизор", "").Trim();
                ld = allDevices["TV"];
                DeleteDev(name);
            }
            else if (deviceSelect.Contains("Бойлер"))
            {
                name = deviceSelect.Replace("Бойлер", "").Trim();
                ld = allDevices["Boiler"];
                DeleteDev(name);
            }
            else if (deviceSelect.Contains("Светильник"))
            {
                name = deviceSelect.Replace("Светильник", "").Trim();
                ld = allDevices["Lamp"];
                DeleteDev(name);
            }
            else if (deviceSelect.Contains("Жалюзи"))
            {
                name = deviceSelect.Replace("Жалюзи", "").Trim();
                ld = allDevices["Louvers"];
                DeleteDev(name);
            }
        }

        private void DeleteDev(string RemoveDev)
        {
            d = ld.Find(i => i.Name == RemoveDev);
            if (d != null)
                ld.Remove(d);
            deviceSelect = "";
            RefreshLists();
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            string name = TextBoxAddDeviceName.Text;
            if (name != "")
            {
                if (deviceAdd.Contains("Обогреватель"))
                {
                    ld = allDevices["Heating"];
                    if (!ld.Exists(i => i.Name == name))
                        ld.Add(new Heating(name));
                }
                else if (deviceAdd.Contains("Телевизор"))
                {
                    ld = allDevices["TV"];
                    if (!ld.Exists(i => i.Name == name))
                        ld.Add(new TV(name));
                }
                else if (deviceAdd.Contains("Бойлер"))
                {
                    ld = allDevices["Boiler"];
                    if (!ld.Exists(i => i.Name == name))
                        ld.Add(new Boiler(name));
                }
                else if (deviceAdd.Contains("Светильник"))
                {
                    ld = allDevices["Lamp"];
                    if (!ld.Exists(i => i.Name == name))
                        ld.Add(new Lamp(name));
                }
                else if (deviceAdd.Contains("Жалюзи"))
                {
                    ld = allDevices["Louvers"];
                    if (!ld.Exists(i => i.Name == name))
                        ld.Add(new Louvers(name));
                }

            } RefreshLists();
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            string name;
            if (deviceSelect.Contains("Обогреватель"))
            {
                name = deviceSelect.Replace("Обогреватель", "").Trim();
                ld = allDevices["Heating"];
                d = ld.Find(i => i.Name == name);
            }
            else if (deviceSelect.Contains("Телевизор"))
            {
                name = deviceSelect.Replace("Телевизор", "").Trim();
                ld = allDevices["TV"];
                d = ld.Find(i => i.Name == name);
            }
            else if (deviceSelect.Contains("Бойлер"))
            {
                name = deviceSelect.Replace("Бойлер", "").Trim();
                ld = allDevices["Boiler"];
                d = ld.Find(i => i.Name == name);
            }
            else if (deviceSelect.Contains("Светильник"))
            {
                name = deviceSelect.Replace("Светильник", "").Trim();
                ld = allDevices["Lamp"];
                d = ld.Find(i => i.Name == name);
            }
            else if (deviceSelect.Contains("Жалюзи"))
            {
                name = deviceSelect.Replace("Жалюзи", "").Trim();
                ld = allDevices["Louvers"];
                d = ld.Find(i => i.Name == name);
            }
            Session["EditDevice"] = d;
            Response.Redirect("~/EditDevice.aspx");
        }
    }
}
