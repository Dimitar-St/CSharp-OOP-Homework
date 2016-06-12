namespace DefiningClassesPart1
{
    using System;

    class Battery
    {
        public enum BatteryType
        {
            LiLon, NiMH, NiCd
        }


        // fields
        private BatteryType batteryType;
        private string model;
        private int hoursIdle;
        private int hoursTalk;

        // constructors

        public Battery (string model) 
        {
            this.Model = model;
            this.HoursIdle = 0;
            this.HoursTalk = 0;
        } 

        public Battery (string model, int hoursTalk, int hoursIdle)
        {
            this.Model = model;
            this.HoursTalk = hoursTalk;
            this.HoursIdle = hoursIdle;
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

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                this.hoursTalk = value;
            }
        }

        // method


    }
}
