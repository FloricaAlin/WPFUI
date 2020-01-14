using System.Collections.Generic;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, string imageName)
        {
            Location location = new Location();
            location.XCoordinate = xCoordinate;
            location.YCoordinate = yCoordinate;
            location.Name = name;
            location.Description = description;
            location.ImageName = $"/Engine;component/Images/Locations/{imageName}";

            _locations.Add(location);
        }

        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (Location location in _locations)
            {
                if (location.XCoordinate == xCoordinate && location.YCoordinate == yCoordinate)
                {
                    return location;
                }
            }
            return null;
        }
    }
}