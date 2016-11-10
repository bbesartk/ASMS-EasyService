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
        #endregion

        #region Properties

        public int Id { get; set; }
        public DateTime ServiceDate { get; set; }
        public double CurrentKm { get; set; }
        public List<Inspection> ListInspection { get; set; }
        public double Total { get; private set; }

        #endregion

        #region Constructors

        public Service()
        {
            Id = ++_id;
        }

        public Service(DateTime serviceDate, double currentKm, List<Inspection> listInspection)
        {
            Id = ++_id;
            Total = CalculateTotal(listInspection);
        }

        #endregion

        #region Methods
        private double CalculateTotal(List<Inspection> listInspection)
        {
            double total=0;
            foreach (Inspection insp in listInspection)
            {
                total += insp.Prise;
            }

            return total;
        }
        #endregion

    }
}
