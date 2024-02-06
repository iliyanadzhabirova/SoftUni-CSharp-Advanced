namespace RawData
{
    public class Tires
    {
        public int Age { get; set; }
        public float Pressure { get; set; }

        public Tires(int age, float pressure)
        {
            Age = age;
            Pressure = pressure;
        }
    }
}
