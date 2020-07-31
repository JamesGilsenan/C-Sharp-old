using System;

namespace Static_Members
{
    //Static Fields and Properties
    class Forest2StaticFandP
    {

        // FIELDS

        public int age;
        private string biome;
        //declaring a privtae field int forestsCreated. Static means it's associated with the class, not an instance
        private static int forestsCreated;

        // CONSTRUCTORS

        public Forest2StaticFandP(string name, string biome)
        {
            this.Name = name;
            this.Biome = biome;
            Age = 0;
            //this will increment ForestsCreated everytime it's constructor is called
            ForestsCreated++;

        }

        public Forest2StaticFandP(string name) : this(name, "Unknown")
        { }

        // PROPERTIES

        //Creates a public static Property for TreeFacts. It only has a getter, no setter
        public static string TreeFacts
        { get; }

        //Creates a public static property for int ForestsCreated. The getter is public and the setter is private
        public static int ForestsCreated
        {
            get { return forestsCreated; }
            private set { forestsCreated = value; }
        }


        public string Name
        { get; set; }

        public int Trees
        { get; set; }

        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical" ||
                    value == "Temperate" ||
                    value == "Boreal")
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        // METHODS

        //A method should be static if it does something that isn't specif to any one instance E.G. Write to Console
        //A static method can only use static variables
        public static void PrintTreeFacts()
        {
            Console.WriteLine(TreeFacts);
        }

        public int Grow()
        {
            Trees += 30;
            Age += 1;
            return Trees;
        }

        public int Burn()
        {
            Trees -= 20;
            Age += 1;
            return Trees;
        }
    }
}

