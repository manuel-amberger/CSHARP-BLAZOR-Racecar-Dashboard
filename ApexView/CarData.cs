namespace ApexView;

public class CarData {
    public int Torque { get; set; } = 1200;
    public int Velocity { get; set; } = 0;
    public int Gear { get; set; } = 0;
    
    
    // Tires
    public Tire TireLeftF { get; set; } = new();
    public Tire TireRightF { get; set; } = new();
    public Tire TireLeftR { get; set; } = new();
    public Tire TireRightR { get; set; } = new();
}