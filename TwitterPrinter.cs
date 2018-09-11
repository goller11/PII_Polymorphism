//------------------------------------------------------------------------------------
// <copyright file="TimeMachinePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------------
using System;

namespace Polymorphism
{
    public class TwitterPrinter : IPrinter
    {
        public void PrintTicket(Sale sale)
        {
            string consumerKey = "dtOgpyjBBXglAzMEjMMZtFf73";
            string consumerKeySecret = "Qzm0FxotJ9YyoXiGLJ4JI9IZFWmYvB4LWpteWPGVYofxSG4FnN";
            string accessToken = "1396065818-13uONd7FgFVXhW1xhUCQshKgGv4UOnKeDipg4cz";
            string accessTokenSecret = "HXtlP1SRnJCL5a37R98hFrIRlEIouZX3Ra4s6JuFOpXZF";

            var twitter = new TwitterApi(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            twitter.Tweet(sale.GetTextToPrint()).Wait();
        }
    }
}