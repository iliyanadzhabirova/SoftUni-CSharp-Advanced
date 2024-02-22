using Microsoft.Win32;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace SharkTaxonomy
{
    public class Classifier
    {
      
        public int Capacity { get; set; }
        public List<Shark> Species { get; set; }
        public int GetCount => Species.Count;

        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new();
        }
       public void AddShark(Shark shark)
        {
            if (Capacity>Species.Count)
            {
                if (!Species.Contains(shark))
                {
                    Species.Add(shark);
                }
            }
        }
        public bool RemoveShark(string kind)
        {
            var removeValue=Species.FirstOrDefault(i => i.Kind == kind);
            if (Species.Contains(removeValue))
            {
                Species.Remove(removeValue);
                return true;
            }
            return false; 
        }

        public string GetLargestShark()
        {
            return Species.OrderByDescending(i=>i.Length).First().ToString();
        }
        public double GetAverageLength()
        {
            return Species.Average(i => i.Length);
           
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Species.Count} sharks classified:");

            foreach (Shark shark in Species)
            {
                sb.AppendLine(shark.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
