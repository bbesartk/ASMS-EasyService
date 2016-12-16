﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ES.EntityLayer.Services
{
    public class ServiceName
    {
        public bool IsInMinorService { get; set; }
        public bool IsInMajorService { get; set; }
        public int ItemCategoryId { get; set; }
        public string Description { get; set; }
        public bool NeedsReplacement { get; set; }

        public ServiceName(string description, bool isInMinor, bool isInMajor,bool needsReplacement, int itemCategoryId )
        {
            Description = description;
            IsInMajorService = isInMajor;
            IsInMinorService = isInMinor;
            ItemCategoryId = itemCategoryId;
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
