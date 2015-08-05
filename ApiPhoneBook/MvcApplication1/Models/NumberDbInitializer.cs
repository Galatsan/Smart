using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcApplication1.Models
{
    public class NumberDbInitializer : DropCreateDatabaseAlways<NumberContext>
    {
        protected override void Seed(NumberContext context)
        {
            DateTime now = DateTime.Now.ToUniversalTime();
            context.Numbers.Add(new Number { FirstName = "Aleksey", SecondName = "Galatsan", PhoneNumber = "+380639423709", DataCreate = now, DataChange = now });
            context.Numbers.Add(new Number { FirstName = "Ivan", SecondName = "Krasovskiy", PhoneNumber = "+380636789450", DataCreate = now, DataChange = now });
            context.Numbers.Add(new Number { FirstName = "Aleksey", SecondName = "Belovodskiy", PhoneNumber = "+38063128456", DataCreate = now, DataChange = now });
            context.Numbers.Add(new Number { FirstName = "Valera", SecondName = "Neshumov", PhoneNumber = "+38063987456", DataCreate = now, DataChange = now });
            context.Numbers.Add(new Number { FirstName = "Ivan", SecondName = "Ivanov", PhoneNumber = "+38063456329", DataCreate = now, DataChange = now }); 
            base.Seed(context);
        }
    }
}