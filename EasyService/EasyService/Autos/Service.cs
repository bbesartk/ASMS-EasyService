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
        #region Properties
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double CurrentKm { get; set; }
        public List<Inspection> ListInspection { get; set; }
        public double Total { get; set; }

        #endregion

    }
}
