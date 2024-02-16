using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        private readonly List<Shoe> shoes;

        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            shoes = new List<Shoe>();
        }

        public string Name { get; }
        public int StorageCapacity { get; }
        public IReadOnlyCollection<Shoe> Shoes => shoes;
        public int Count => shoes.Count;

        public string StockList(double size, string type)
        {
            var stockList = shoes.Where(s => s.Size == size && s.Type.ToLower() == type.ToLower()).ToList();

            StringBuilder sb = new StringBuilder();
            if (stockList.Count == 0)
            {
                sb.AppendLine("No matches found!");
            }
            else
            {
                sb.AppendLine($"Stock list for size {size} - {type} shoes:");
                foreach (var shoe in stockList)
                {
                    sb.AppendLine(shoe.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }

        public Shoe GetShoeBySize(double size) => shoes.FirstOrDefault(s => s.Size == size);

        public List<Shoe> GetShoesByType(string type)
        {
            return shoes.Where(s => s.Type.ToLower() == type.ToLower()).ToList();
        }

        public int RemoveShoes(string material)
        {
            int removedShoes = shoes.RemoveAll(s => s.Material.ToLower() == material.ToLower());
            return removedShoes;
        }

        public string AddShoe(Shoe shoe)
        {
            if (shoes.Count >= StorageCapacity)
            {
                return "No more space in the storage room.";
            }

            shoes.Add(shoe);
            return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
        }
    }
}
