using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shetalent_Events
{
    //class created to keep track of stored datas in data grid view

    public class DGVClass
    {
        public decimal amountOwed;

        public DGVClass()
        {
            amountOwed = 0;
        }
        public string LotNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EventType { get; set; }
        public DateTime DateTimeOfEvent { get; set; }
        public int NumberOfGuest { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public decimal SalesAmount { get; set; }
        public DateTime DateTimeBooked { get; set; }
        public decimal AmountOwed
        {
            set
            { amountOwed = value; }
            get
            { return amountOwed; }
        }
        public string agent { get; set; }
        public string State { get; set; }
    }
}
