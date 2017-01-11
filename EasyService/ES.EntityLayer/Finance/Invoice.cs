using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Employees;
using ES.EntityLayer.Services;
using ES.EntityLayer.Clients;
using ES.EntityLayer.Vehicle;


namespace ES.EntityLayer.Finance
{
    public class Invoice
    {
        #region StaticMembers
        public readonly double Vat;
        #endregion

        #region Properties
        public int Id { get; private set; }

        public DateTime DateOfBill
        {
            get { return DateTime.Now; }
        }

        public Vehicle.Vehicle ServicedVehicle { get; }
        
        public Service Service { get; }

        public Employee ServicedBy { get; } //Employee that did this particular service

        public Client Client { get; }

        public Company Company { get; }

        public double Total
        {
            get;set;
        }
        #endregion

        #region Constructors
        public Invoice(Vehicle.Vehicle servicedVehicle, Service service, Client client, Employee servicedBy, double vat, double total)
        {
            ServicedVehicle = servicedVehicle;
            Service = service;
            Client = client;
            ServicedBy = servicedBy;
            Vat = vat;
            Total = total;
        }

        public Invoice(Vehicle.Vehicle servicedVehicle, Service service, Company company, Employee servicedBy, double vat, double total)
        {
            ServicedVehicle = servicedVehicle;
            Service = service;
            Company = company; ;
            ServicedBy = servicedBy;
            Vat = vat;
            Total = total;
        }
        #endregion

        #region Methods
       
        #endregion
    }
}
