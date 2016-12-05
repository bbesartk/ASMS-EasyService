using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.EntityLayer.Stock
{
    class Item
    {
        //emri nrPersonal qmimi sasiaStok

        #region StatickMembers
        private int _nrPersonal = 0;
        private string _name;
        private double _cmimi = 0;
        private int _sasiaStok = 0;
        #endregion

        #region Properties
        public string Name { get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Name can't be empty!");
                }
                else _name = value;
            }
        }
        public double Cmimi { get { return _cmimi; } set
            {
                if (_cmimi != 0)
                {
                    throw new Exception("Cmimi nuk guxon te jet 0!");
                }
                else _cmimi = value;
            }
        }
        public int SasiaStok { get { return _sasiaStok; } set
            {
                if (_sasiaStok != 0)
                {
                    throw new Exception("Nuk ka ne stok");
                }
                else _cmimi = value;
            }
        }
        #endregion
    }
}
