using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyService.Autos;

namespace EasyService.Autos
{
    class Service
    {
        #region StaticMembers
        private static int _id = 0;
        private double _servicedKm;
        private double _total;
        #endregion

        #region Properties
        public int Id { get; private set; }
        public DateTime ServiceDate { get; set; }
        public double ServicedKm
        {
            get { return _servicedKm; }
            set
            {
                //if(value < _servicedKm)
            }
        }
        public List<Inspection> ListInspection { get; set; }
        public double Total
        {
            get
            {
                return _total; 
            }
            set
            {
                if (CheckInspectionServiced() == true)
                    _total = CalculateTotal();
                else _total = 25;
            }
        }

        #endregion

        #region Constructors

        public Service()
        {
            Id = ++_id;
        }

        public Service(DateTime serviceDate, double servicedKm, List<Inspection> listInspection)
        {
            Id = ++_id;
            ListInspection = listInspection;
            ServicedKm = servicedKm;
            ServiceDate = serviceDate;
        }


        #endregion

        #region Methods
        private bool CheckInspectionServiced()
        {
            bool value = false;
            foreach (Inspection item in ListInspection)
            {
                if (item.IsService != null)
                    value = true;
            }
            return value;
        }


        private double CalculateTotal()
        {
            double total = 0;
            foreach (Inspection item in ListInspection)
            {
                if(item.IsService!=null)
                {
                    total += Total;
                }
            }
            return total;
        }

        #endregion


    }
}
