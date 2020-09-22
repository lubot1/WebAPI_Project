using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class HostingCostController : ApiController
    {
        public string[] Get(int id)
        {
            double Tax = 0.13;
            double PricePerFortnight = 5.50;
            double NumFortnights = id / 14;

            double SubTotal = (int)NumFortnights * PricePerFortnight + PricePerFortnight;
            double TaxAmount = SubTotal * Tax;
            double Total = TaxAmount + SubTotal;

            string[] OutputMessage = {String.Format("{0} fortnights at {1:C2}/FN = {2:C2}", NumFortnights, PricePerFortnight, SubTotal), String.Format("CAD HST 13% = {0:C2}", TaxAmount), String.Format("Total = {0:C2}",Total) };
            //OutputMessage = OutputMessage.Replace("\n", Environment.NewLine);
            return OutputMessage;
        }
    }
}
