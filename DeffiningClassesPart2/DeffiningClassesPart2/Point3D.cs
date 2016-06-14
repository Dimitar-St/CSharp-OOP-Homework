namespace DeffiningClassesPart2
{
    public struct Point3D
    {
        private int x;
        private int y;
        private int z;

        public static readonly Point3D Origin = new Point3D(0, 0, 0);
        
        // constructures
        public Point3D (int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        // properties

        public int X
        {
            get
            {
                return this.x;
            }

            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }

            set
            {
                this.y = value;
            }
        }

        public int Z
        {
            get
            {
                return this.z;
            }

            set
            {
                this.z = value;
            }
        }
        
        // method
        public string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.x, this.y, this.z);
        }
    }
}
