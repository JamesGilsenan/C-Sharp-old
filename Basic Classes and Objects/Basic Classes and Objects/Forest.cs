using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Classes_and_Objects
{
    class Forest
    {
        //Adding fields to the forest class
        //public string name;
        //public int trees;
        private int age;

        //We can make the property of Age unsettable by not including a set method, or use a private set method so the value can be set within its class only
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        //fields should be priavte so their values cannot be changed. We should only the set the property value so any necassary validation takes place
        //private and public are known as access modifiers. By default, a field is private and a property is public
        //public string biome;
        private string biome;

        //Create a property for the name field with no validation
        /*public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Trees
        {
            get { return trees; }
            set { trees = value; }
        }*/

        //When you use an automatic property, you dont need to define a field. Also the get, set methods are shorter than above
        public string Name
            {get;set;}
        public int Trees
            { get; set; }
        //Add property for biome field. Add validation so it only sets Tropical Temperate Boreal as the value
        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical") { biome = value; }
                else if (value == "Temperate") { biome = value; }
                else if (value == "Boreal") { biome = value; }
                else { biome = "Unknown"; }
            }
        }
        //creating public methods that belong to the forest class
        public int Grow()
        {
            Trees = Trees + 30;
            Age = Age + 1;
            return Trees;
        }

        public int Burn()
        {
            Trees = Trees - 20;
            Age = Age + 1;
            return Trees;
        }
    }
}
