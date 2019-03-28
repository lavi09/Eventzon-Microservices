﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogApi.Domain
{
    public class CatalogEvent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Month { get; set; }
        public string Date { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }

        public int CatalogCategoryID { get; set; }
        public int CatalogTypeID { get; set; }

        public virtual CatalogType CatalogType { get; set; }
        public virtual CatalogCategory CatalogCategory { get; set; }

    }
}
