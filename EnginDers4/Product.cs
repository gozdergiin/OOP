using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDers4
{
    class Product
    {
        //CRUD= creat, read, update, delete
        //snippet hazır kod. 2 kere tab basınca oluyor. prop 2tab=public.
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
