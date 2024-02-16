using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine 
    {
    
        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Cloth> Clothes { get; set; }

        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new();
        }

        public void AddCloth(Cloth cloth)
        {
            if (Capacity>Clothes.Count)
            {
                Clothes.Add(cloth);
            }
        }

        public bool RemoveCloth(string color)
        {
            return Clothes.Remove(Clothes.FirstOrDefault(i=>i.Color==color));
        }
        public Cloth GetSmallestCloth()
        {
            return Clothes.OrderBy(i => i.Size).First();
        }
        public int GetClothCount()
        {
            return Clothes.Count;
        }
        public Cloth GetCloth(string color)
        {
            return Clothes.FirstOrDefault(i => i.Color==color);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Type} magazine contains:");
            foreach (Cloth cloth in Clothes.OrderBy(i=>i.Size))
            {
                sb.AppendLine(cloth.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
