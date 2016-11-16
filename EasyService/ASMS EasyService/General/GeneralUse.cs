using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMS_EasyService.Vehicles;

namespace ASMS_EasyService.General
{
    class GeneralUse
    {
        public static string FormatNames(string value)
        {
            return char.ToUpper(value[0]) + value.Substring(1).ToLower();
        }

       
    }
}
