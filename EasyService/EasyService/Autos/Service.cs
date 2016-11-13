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
        public int Id { get; private set; }
        public DateTime InspectionDate { get; set; }
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
            ListInspection = listInspection;
        }


        #endregion

        #region Methods
        //public double CalculateTotal()
        //{
        //    foreach (Inspection item in ListInspection)
        //    {
        //        if(item.Service.Price)
        //    }
        //}
        #endregion


    }
}
