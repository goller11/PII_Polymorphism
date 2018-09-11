//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;
using System.Collections;

namespace Polymorphism
{
    public class Program
    {
        private static ArrayList productCatalog = new ArrayList();

        public static void Main(string[] args)
        {
            PopulateCatalog();

            Sale sale = new Sale();
            sale.DateTime = DateTime.Now;
            sale.AddLineItem(new SalesLineItem(1, ProductAt(0)));
            sale.AddLineItem(new SalesLineItem(1, ProductAt(1)));

            IPrinter consolePrinter = new ConsolePrinter();
            IPrinter filePrinter = new FilePrinter();
            IPrinter timeMachinePrinter = new TimeMachinePrinter();
            IPrinter twitterPrinter = new TwitterPrinter();

            consolePrinter.PrintTicket(sale);
            filePrinter.PrintTicket(sale);
            twitterPrinter.PrintTicket(sale);
            timeMachinePrinter.PrintTicket(sale);

        }

        private static void PopulateCatalog()
        {
            AddProductToCatalog("Intel i5-6200U", 500.00);
            AddProductToCatalog("Lenovo 8GB RAM 500GB HDD", 600.00);
        }

        private static void AddProductToCatalog(string description, double price)
        {
            productCatalog.Add(new ProductSpecification(description, price));
        }

        private static ProductSpecification ProductAt(int index)
        {
            return productCatalog[index] as ProductSpecification;
        }
    }
}
