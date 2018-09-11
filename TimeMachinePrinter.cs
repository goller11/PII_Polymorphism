//------------------------------------------------------------------------------------
// <copyright file="TimeMachinePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------------
using System;

namespace Polymorphism
{
    public class TimeMachinePrinter : IPrinter
    {
        public void PrintTicket(Sale sale)
        {
            sale.DateTime = new DateTime(2018, 09, 09);
            Console.WriteLine(sale.GetTextToPrint());
        }
    }
}