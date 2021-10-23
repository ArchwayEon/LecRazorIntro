using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LecRazorIntro.ViewComponents
{
   public class TimeViewComponent : ViewComponent
   {
      public IViewComponentResult Invoke()
      {
         var time = DateTime.Now;
         return View(time);
      }

   }
}
