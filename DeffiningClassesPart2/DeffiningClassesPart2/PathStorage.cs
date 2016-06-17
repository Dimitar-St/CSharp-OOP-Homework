namespace DeffiningClassesPart2
{
    using System.Collections.Generic;

    public static class PathStorage
    {
        private static List<string> savePaths;

        static PathStorage ()
        {
            SavePaths = new List<string>();
        }

        public static List<string> SavePaths
        {
            get
            {
                return savePaths;
            }

            set
            {
                savePaths = value;
            }
        }

        public static void Save()
        {

        }
    }
}
