namespace ShoeStore
{
    public class Shoe
    {
        public Shoe(string brand, string type, double size, string material)
        {
            Brand = brand;
            Type = type;
            Size = size;
            Material = material;
        }

        public string Brand { get; set; }

        public string Type { get; set; }

        public double Size { get; set; }

        public string Material { get; set; }

        public override string ToString()
        {
            return $"Size {this.Size}, {this.Material} {this.Brand} {this.Type} shoe.";
        }
    }
}
