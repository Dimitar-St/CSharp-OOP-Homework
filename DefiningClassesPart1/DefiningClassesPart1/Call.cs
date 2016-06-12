namespace DefiningClassesPart1
{
    using System;

    class Call
    {
        // field
        private string date;
        private string time;
        private string phoneNumber;
        private int duration;


        public Call(string date, string time, string phoneNumber, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.PhoneNumber = phoneNumber;
            this.Duration = duration;
        }

        // properties

        public string Date
        {
            get
            {
                return this.date; 
            }

            set
            {
                this.date = value;
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }

            set
            {
                this.time = value;
            }
        } 

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            set
            {
                this.phoneNumber = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }

            set
            {
                this.duration = value;
            }

        }
    }
}
