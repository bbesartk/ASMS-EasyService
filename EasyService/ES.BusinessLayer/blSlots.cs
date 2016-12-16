using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.General;
using ES.DataAccessLayer;

namespace ES.BusinessLayer
{
    class blSlots
    {
        public static void InsertSlots(Slot slot)
        {
            if (slot != null)
                dalSlot.Insert(slot);
            else throw new Exception("Invalid Slot");
        }

        public static void DeleteSlot(int id)
        {
            if (id != 0)
                dalSlot.Remove(id);
            else throw new Exception("Ivalide Id!");
        }

        public static Slot GetAllSlots(int id)
        {
            return dalSlot.GetSlot(id);
        }
       
        public static int GetSingelSlot(string name)
        {
            return dalSlot.GetSlotId(name);
        }
    }
}
