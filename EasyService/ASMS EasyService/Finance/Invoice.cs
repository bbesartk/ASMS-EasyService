using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMS_EasyService.Clients;
using ASMS_EasyService.Vehicles;
using ASMS_EasyService.Employees;

namespace ASMS_EasyService.Finance
{
    class Invoice
    {
        #region StaticMembers
        public readonly int Vat;
        private static int _id;
        #endregion

        #region PrivateMembers

        #endregion

        #region Properties
        public int Id { get; private set; }
        public DateTime DateOfBill
        {
            get {return DateTime.Now;}
        }
        
        public Vehicle ServicedVehicle { get; } 
        
        public Service Service { get; }

        public Employee ServicedBy { get; } //Employee that did this particular service

        public Employee IssuedBy { get; } //The employee that issued this bill
        
        public Client Client { get; }

        public Company Company { get; }

        public decimal Total
        {
            get
            {
                return CalculateTotal();
            }
        }
        #endregion

        #region Constructors
        public Invoice(Vehicle servicedVehicle, Service service,Client client, Employee servicedBy,Employee issuedBy,int vat)
        {
            Id = ++_id;
            ServicedVehicle = servicedVehicle;
            Service = service;
            Client = client;
            ServicedBy = servicedBy;
            IssuedBy = issuedBy;
            Vat = vat;
        }

        public Invoice(Vehicle servicedVehicle, Service service, Company company, Employee servicedBy, Employee issuedBy, int vat)
        {
            Id = ++_id;
            ServicedVehicle = servicedVehicle;
            Service = service;
            Company = company; ;
            ServicedBy = servicedBy;
            IssuedBy = issuedBy;
            Vat = vat;
        }
        #endregion

        #region Methods
        private decimal CalculateTotal()
        {
            return Service.Total + (Service.Total * (Vat / 100));
        }
        #endregion
    }
}
