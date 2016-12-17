using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Appointments;
using ES.EntityLayer.Clients;
using ES.EntityLayer.Employees;
using ES.EntityLayer.Finance;
using ES.EntityLayer.General;
using ES.EntityLayer.Services;
using ES.EntityLayer.Stock;
using ES.EntityLayer.Vehicle;

namespace ES.BusinessLayer
{
    class DataTest
    {

        static ContactInfo c1 = new ContactInfo("Prishtine", "Qender", "+37745363373", "syle@shabani.com");
        static ContactInfo c2 = new ContactInfo("Gjakove", "E panjohur", "+37745363373", "filan@fisteku.com");
        static ContactInfo c3 = new ContactInfo("Prizren", "Qendra", "+37745363373", "sylesylani@msn.com");
        static ContactInfo c4 = new ContactInfo("Peja", "Rruga Kryesore", "+37745363373", "pejapeja@msn.com");

        //Inicializimi i Klientve
        static Client cl1 = new Client("1234567899", "Syle", "Shabani",c1);
        static Client cl2 = new Client("1356789001", "Filan", "Fisteku", c2);

        static Company cp1 = new Company("24211443111433", "Elkos Group", c4);
        static Company cp2 = new Company("42314212342424", "AllRide", c4);

     

        //Inicializimi i veturave
        public static List<Vehicle> InitialiseVehicles()
        {
            return new List<Vehicle>()
            {
                new Vehicle("01-123-AI","3242352211133",2004,"Audi","A3",32000,cl1),
                new Vehicle("03-662-BK","4242211643321",2009,"BMW","X3",4100,cl2),
                new Vehicle("06-441-CC","4114324234511",2012,"Audi","R8",3600,cl2),
                new Vehicle("05-442-AI","4234214252241",2016,"VW","GOLF",2000,cp2)
            };
        }




    }
}
