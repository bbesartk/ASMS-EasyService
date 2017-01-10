using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.EntityLayer.General
{
    interface IAccess
    {

        Access Access { get; set; }
        void DisplayMessage();
    }
}
