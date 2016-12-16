using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.EntityLayer.Stock;


namespace ES.EntityLayer.Services
{
    public class ServiceName
    {
        public bool IsInMinorService { get; set; }
        public bool IsInMajorService { get; set; }
        public Category ItemCategory { get; set; }
        public string Description { get; set; }
        public bool NeedsReplacement { get; set; }

        public ServiceName(string description, bool isInMinor, bool isInMajor,bool needsReplacement, Category itemCategory )
        {
            Description = description;
            IsInMajorService = isInMajor;
            IsInMinorService = isInMinor;
            ItemCategory = itemCategory;
            NeedsReplacement = needsReplacement;
        }
        public ServiceName(string description, bool isInMinor, bool isInMajor)
        {
            Description = description;
            IsInMajorService = isInMajor;
            IsInMinorService = isInMinor;
        }


        public override string ToString()
        {
            return Description;
        }
    }
}
