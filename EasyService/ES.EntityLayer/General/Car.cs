using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.EntityLayer.General
{
    public class CarType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CarType(int id,string name)
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    public class CarModel
    {
        public int CarID { get; set; }
        public string Model { get; set; }

        public CarModel(int carId,string model)
        {
            CarID = carId;
            Model = model;
        }

        public override string ToString()
        {
            return Model;
        }
    }
}
