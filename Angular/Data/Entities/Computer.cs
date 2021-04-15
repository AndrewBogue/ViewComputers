namespace Angular.Data.Entities
{
    public class Computer
    {
        public int Id { get; set; }
        public string Processor { get; set; }
        public int Ram { get; set; }
        public string RamUnits { get; set; }
        public int HardDisk { get; set; }
        public string HardDiskUnits { get; set; }
        public string HardDiskType { get; set; }
        public string Usb { get; set; } //ideally we would have a separate usb table containing usb type and quantity, and key would be computer id
        public string GraphicsCard { get; set; }
        public double Weight { get; set; }
        public string WeightUnits { get; set; }
        public int PowerSupply { get; set; }

    }
}
