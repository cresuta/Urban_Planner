using System.Collections.Generic;

namespace UrbanPlanner
{
    public class City
    {
        private string _name { get; set; }
        private string _mayor { get; set; }
        private int _yearEstablished { get; set; }

        public List<Building> Buildings = new List<Building>();

        public City(string name)
        {
            _name = name;
        }
       
        public void addBuilding(Building building)
        {
            Buildings.Add(building);
        }
       
        
    }
}