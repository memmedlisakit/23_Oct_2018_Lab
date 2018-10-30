using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogezyApp.ViewComponents
{
    [ViewComponent(Name = "SideMenu")]
    public class SideMenuViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return  View();
        }
    }
}