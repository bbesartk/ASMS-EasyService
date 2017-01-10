using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.EntityLayer.General
{
    public class Access
    {
        public bool Dashboard { get; set; }
        public bool Appointment { get; set; }
        public bool Vehicles { get; set; }
        public bool Reports { get; set; }
        public bool Stock { get; set; }
        public bool Staff { get; set; }
        public bool Clients { get; set; }
        public bool Settings { get; set; }

        public Access(bool db, bool app, bool vh, bool rep, bool stock, bool staff, bool client, bool sett)
        {
            Dashboard = db;
            Appointment = app;
            Vehicles = vh;
            Reports = rep;
            Stock = stock;
            Staff = staff;
            Clients = client;
            Settings = sett;
        }
        public Access()
        {

        }
    }
}
