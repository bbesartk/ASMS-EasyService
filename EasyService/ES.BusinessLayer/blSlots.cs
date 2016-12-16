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
        public static void InsertSlot(Slot slot)
        {
            if (slot != null)
                dalSlot.Insert(slot);
            else throw new Exception("Invalid Slot");
        }

        public static void DeleteSlot(int id)
        {
            if (id >= 0)
                dalSlot.Remove(id);
            else throw new Exception("Ivalide Id!");
        }

        public static Slot GetSlot(int id)
        {
            return dalSlot.GetSingleSlot(id);
        }

        public static int GetSlodId(string name)
        {
            return dalSlot.GetSlotId(name);
        }

        public static List<Slot> GetAllSlots()
        {
            return dalSlot.GetAllSlots();
        }
    }
}
