﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double ComissionRate { get; set; }
        public decimal PaymentDue { get; set; }
        public string Display
        {
            get
            {
                return string.Format("{0}, {1} - ${2}", FirstName, LastName, PaymentDue);
            }
        }

        public Vendor()
        {
            ComissionRate = 0.5;
        }

    }
}
