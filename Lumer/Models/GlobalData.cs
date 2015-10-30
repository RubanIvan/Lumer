using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lumer.Models
{
    public static class GlobalData
    {
        public static DateTime CurDate { get; }
        public static DateTime WeakStart { get; }
        public static DateTime WeekEnd { get; }

        static GlobalData()
        {
            CurDate=DateTime.Now;
            WeakStart = DateTime.Parse("26.10.2015");
            WeekEnd = DateTime.Parse("01.11.2015");
        }
    }
}