using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
  
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }

        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new();
        }
        public bool AddChild(Child child)
        {
            if (Capacity>Registry.Count)
            {
                Registry.Add(child);
                return true;
            }
            return false;
        }
        public bool RemoveChild(string childFullName)
        {
            foreach (Child child in Registry)
            {
                if (child.FirstName + " " + child.LastName == childFullName)
                {
                    Registry.Remove(child);
                    return true;
                }
            }
            return false;
        }

        public int ChildrenCount => Registry.Count;
        public Child GetChild(string childFullName)
        {
            foreach (Child child in Registry)
            {
                if (child.FirstName + " " + child.LastName == childFullName)
                {
                    return child;
                }
            }
            return null; 
        }
        public string RegistryReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Registered children in {Name}:");

            var orderedChildren = Registry
                .OrderByDescending(child => child.Age)
                .ThenBy(child => child.LastName)
                .ThenBy(child => child.FirstName);

            foreach (Child child in orderedChildren)
            {
                sb.AppendLine(child.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
