using ES.EntityLayer.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DataAccessLayer
{
    public class dalSlot
    {
        static public List<Slot> listOfSlot = new List<Slot>();

        public static List<Slot> AllSlots()
        {
            List<Slot> slot = new List<Slot>();
            slot.Add(new Slot(1, "Slloti1"));
            slot.Add(new Slot(2, "Slloti2"));
            slot.Add(new Slot(3, "Slloti3"));
            slot.Add(new Slot(4, "Slloti4"));

            return slot;
        }
        public static void Insert(Slot slot)
        {
            listOfSlot.Add(slot);
        }
        public static void Remove(int id)
        {
            Slot slots = GetSlot(id);
            listOfSlot.Remove(slots);
        }

        public static Slot GetSlot(int id)
        {
            foreach (var item in AllSlots())
            {
                if (item.RowNumber == id)
                    return item;

            }
            return null;
        }

        public static int GetSlotId(string name)
        {
            foreach (var item in AllSlots())
            {
                if (name == item.Description)
                    return item.RowNumber;
            }

            return -1;
        }

    }
}
