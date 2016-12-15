using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.EntityLayer.General
{
    public class Slot
    {
        public int RowNumber { get; set; }
        public string Description { get; set; }

        public Slot(int row, string desc)
        {
            RowNumber = row;
            Description = desc;
        }

        public override string ToString()
        {
            return Description;
        }


    }
}