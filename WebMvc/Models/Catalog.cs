﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Models
{
    public class Catalog
    {
        public int PageSize { get; set; }
        public int PageIndex { get; set; }

        public int Count { get; set; }

        public List<CatalogEvent> Data { get; set; }


    }
}
