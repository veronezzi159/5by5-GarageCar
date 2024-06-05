namespace Models
{
    public class Car
    {
        public static readonly string Insert = "INSERT INTO Car (Plate, Name, ModelYear, ManufactureYear, Color) VALUES (@Plate, @Name, @ModelYear, @ManufactureYear, @Color)";
        public static readonly string GetAll = "SELECT Plate, Name, ModelYear, ManufactureYear, Color FROM Car ";

       public string Plate { get; set; }
        public string Name { get; set; }
        public int ModelYear { get; set; }
        public int ManufactureYear { get; set; }
        public string Color { get; set; }

        public Car() { }

        public override string ToString()
        {
            return "Plate: " + Plate + "\nName: " + Name + "\nModelYear: " + ModelYear + "\nManufactureYear: " + ManufactureYear + "\nColor: " + Color + "\n";
        }
    }
}
