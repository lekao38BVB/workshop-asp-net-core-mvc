﻿using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id{ get; set; }
        public DateTime Date { get; set; }
        public Double amount { get; set; }
        public SaleStatus status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            this.amount = amount;
            this.status = status;
            Seller = seller;
        }
    }
}
