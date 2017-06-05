using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace Shetalent_Events
{
    class EventClass
    {
        private int increment = 100;
        private string eventNumber;             //to hold the lot number
        private string eventType;               //the hold the type of the event
        private int guests;                     //to hold the number of guests
        private decimal sales = 0;              //accumulator for the amount of sales                            
        private string fName;
        private string lName;                   //to hold the customers name
        private DateTime eventDate;
        private string street;
        private string city;
        private int zip;
        private string state;
        private DateTime date;
        private const int pricePerGuest = 40;   //setting price per guests

        //constructor
        public EventClass()
        {
            eventNumber = "";
            eventType = "";
            fName = "";
            lName = "";
            street = "";
            city = "";
            zip = 0;
            state = "";
        }

        //the setter accessor that sets the property to a value
        //the getter accessor returns the properties value 

        //guest property
        public int Guest
        {
            set
            { guests = value; }            
            get
            { return guests; }
        }


        //event number or lot number property
        public string EventNumber
        {           
            set
            {               
                eventNumber = eventType.Substring(0, 2) + increment;
                increment++;                
            }
            get
            { return eventNumber; }           
        }

        //the event type property
        public string EventType
        {
            set
            { eventType = value; }             
            get
            { return eventType; }            
        }

        //the customers name property
        public string FirstName
        {
            set
            { fName = value; } 
            get
            { return fName; }
        }

        public string LastName
        {
            set
            { lName = value; }
            get
            { return lName; }
        }
        public string Street
        {
            set
            { street = value; }
            get
            { return street; }
        }
        public string City
        {
            set
            { city = value; }
            get
            { return city; }
        }
        public string State
        {
            set
            { state = value; }
            get
            { return state; }
        }

        public int Zip
        {
            set
            { zip = value; }
            get
            { return zip; }
        }

        //the venue property
        public DateTime EventDate
        {
            set
            { eventDate = value; }
            get
            { return eventDate; }
        }

        //the sales property
        public decimal Sales
        {
            set
            { sales = value; }
            get
            { return sales; }
        }

        //the total due property
        public decimal GetTotal
        {
            get
            {
                decimal price = (guests * pricePerGuest) + sales;
                return price;
            }
        }

        public DateTime BookedDate
        {
            get
            {
                date = DateTime.Now;
                return date;
            }            
        }
    }
}
