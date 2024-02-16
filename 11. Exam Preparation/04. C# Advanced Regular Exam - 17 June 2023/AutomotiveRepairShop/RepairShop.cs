using System.Text;
using System.Xml.Linq;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
     
        public int Capacity { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public RepairShop(int capacity)
        {
            Capacity = capacity;
            Vehicles = new();
        }
        public void AddVehicle(Vehicle vehicle)
        {
            if (Capacity > Vehicles.Count)
            {
                Vehicles.Add(vehicle);
            }
        }
        public bool RemoveVehicle(string vin)
        {
            return Vehicles.Remove(Vehicles.FirstOrDefault(i => i.VIN == vin));
        }
        public int GetCount()
        {
            return Vehicles.Count;
        }
        public Vehicle GetLowestMileage()
        {
            return Vehicles.OrderBy(i => i.Mileage).First();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Vehicles in the preparatory:");
            foreach (Vehicle vehicle in Vehicles)
            {
                sb.AppendLine(vehicle.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
