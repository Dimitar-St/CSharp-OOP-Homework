namespace DefiningClassesPart1
{
    class Call
    {
        // field
        private string date;
        private string time;
        private string phoneNumber;
        private int duration;


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
