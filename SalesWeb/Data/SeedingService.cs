﻿
using Microsoft.EntityFrameworkCore.Internal;
using SalesWeb.Models;
using System;
using SalesWeb.Models.Enums;

namespace SalesWeb.Data
{
    public class SeedingService
    {
        private SalesWebContext _context;

        public SeedingService(SalesWebContext context) 
        { 
            _context = context; 
        }

        public void Seed() 
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Books");
            Department d4 = new Department(4, "Fashion");
            Department d5 = new Department(5, "Development");
            
            Seller s1 = new Seller(1, "William", "william@gmail.com", new DateTime(1995, 2, 23), 1500.0, d1);
            Seller s2 = new Seller(2, "Gulherme", "Guilherme@gmail.com", new DateTime(1995, 4, 12), 1600.0, d2);
            Seller s3 = new Seller(3, "Fuzeto", "fuzeto@gmail.com", new DateTime(1998, 1, 30), 1700.0, d3);
            Seller s4 = new Seller(4, "Eduardo", "edu@gmail.com", new DateTime(1993, 5, 22), 1900.0, d4);
            Seller s5 = new Seller(5, "Bruno", "bruno@gmail.com", new DateTime(1998, 7, 11), 1300.0, d5);
            Seller s6 = new Seller(6, "Thiago", "th@gmail.com", new DateTime(1998, 5, 16), 1200.0, d5);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2020, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2020, 10, 09), 15000.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2020, 04, 10), 21000.0, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2020, 01, 11), 31000.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2020, 09, 15), 32000.0, SaleStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2020, 04, 10), 32000.0, SaleStatus.Billed, s5);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2020, 01, 11), 32000.0, SaleStatus.Billed, s5);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2020, 09, 15), 32000.0, SaleStatus.Billed, s5);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2020, 10, 09), 32000.0, SaleStatus.Billed, s5);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2020, 10, 14), 32000.0, SaleStatus.Billed, s5);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2020, 09, 11), 32000.0, SaleStatus.Billed, s5);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2020, 12, 1), 32000.0, SaleStatus.Billed, s5);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2020, 11, 17), 32000.0, SaleStatus.Billed, s5);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2020, 07, 15), 32000.0, SaleStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2020, 05, 25), 32000.0, SaleStatus.Billed, s5);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2020, 09, 15), 32000.0, SaleStatus.Billed, s5);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2020, 10, 25), 32000.0, SaleStatus.Billed, s5);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2020, 03, 11), 32000.0, SaleStatus.Billed, s5);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2020, 06, 12), 32000.0, SaleStatus.Billed, s5);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2020, 09, 15), 32000.0, SaleStatus.Billed, s5);

            _context.Department.AddRange(d1, d2, d3, d4, d5);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, 
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20
            );

            _context.SaveChanges();
        }
    }
}
