namespace DefiningClassesPart1
{
    using System;
    using System.Collections.Generic;

    class GSM
    {
        // fields
        private static string iPhone4S;
        private string model;
        private string manyfacturer;
        private int price;
        private string owner;
        private Battery batteryCharacteristics;
        private Display displayCharacteristics;
       
        

        // constructores

        public GSM(string model, string manyfacturer)
        {
            this.Model = model;
            this.Manyfacturer = manyfacturer;
            this.Price = 0;
            this.Owner = "unnamed";
            this.CallHistory = new List<Call>();

        }

        public GSM (string model, string manyfacturer, int price, string owner)
        {
            this.Model = model;
            this.Manyfacturer = manyfacturer;
            this.Price = price;
            this.Owner = owner;
        }

        // properties
        public string Model 
        {
            get 
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }

        public string Manyfacturer
        {
            get
            {
                return this.manyfacturer;
            }

            set
            {
                this.manyfacturer = value;
            }
        }

        public int Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                this.owner = value;
            }
        }

        public Battery BatteryCharacteristics
        {
            get
            {
                return this.batteryCharacteristics;
            }

            set
            {
                this.batteryCharacteristics = value;
            }
        }

        public Display DisplayCharacteristics
        {
            get
            {
                return this.displayCharacteristics;
            }

            set
            {
                this.displayCharacteristics = value;
            }
        }
        
        public List<Call> CallHistory { get; set;  } 
        
        // methods

        public void SeeAllGSMInformation()
        {
            Console.WriteLine("-----------GSM--------------");
            Console.WriteLine("Model : {0}", this.Model);
            Console.WriteLine("Manyfactarer : {0}", this.Manyfacturer);
            Console.WriteLine("Price : {0}", this.Price);
            Console.WriteLine("Owner : {0}", this.Owner);
            Console.WriteLine("-------------------------");
        }

        public void ViewAllCallInformation(Call call)
        {
            Console.WriteLine("-----------Call--------------");
            Console.WriteLine("Date : {0}", call.Date);
            Console.WriteLine("Duration : {0}", call.Duration);
            Console.WriteLine("Time : {0}", call.Time);
            Console.WriteLine("Phone number : {0}", call.PhoneNumber);
            Console.WriteLine("-----------------------------");
        }

        public void AddCall (Call call)
        {
            CallHistory.Add(call);
        }

        public void DeleteCall (Call call)
        {
            CallHistory.Remove(call);
        }
        
        public void ClearAllCallHistory ()
        {
            CallHistory.Clear();
        }

        public double TotalPriceOfTheCalls (double price , double calls)
        {
            return price * calls;
        }
    }
}
