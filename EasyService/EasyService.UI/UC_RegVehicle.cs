using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ES.EntityLayer.Vehicle;

namespace EasyService.UI
{
    public partial class UC_RegVehicle : UserControl
    {
        public readonly string _tableOrVin;
        public readonly Vehicle _vehicle;
        public UC_RegVehicle(string tableOrVin,bool isTable)
        {
            InitializeComponent();
            _tableOrVin = tableOrVin;
            if (isTable)
            {
                txbLicensePlate.Text = tableOrVin;
            }
            else txbVin.Text = tableOrVin;
        }

        public UC_RegVehicle(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }
    }
}
