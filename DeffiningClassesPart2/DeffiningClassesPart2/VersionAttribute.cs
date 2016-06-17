namespace DeffiningClassesPart2
{
    using System;

    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method)]

    class VersionAttribute : Attribute
    {
        private int major;
        private int minor;

        public int Major
        {
            get
            {
                return this.major;
            }
            set
            {
                this.minor = value;
            }
        }

        public int Minor
        {
            get
            {
                return this.minor;
            }
            set
            {
                this.minor = value;
            }
        }


    }
}
