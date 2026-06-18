namespace ApexView;

public class Car {
    public Driver Driver { get; set; } = new();
    public Team Team { get; set; } = new();
    public int Position { get; set; }
    public double TrackProgress { get; set; } = 0.0;
    public double RoundTime { get; set; }
    public int RoundTimeM { get; set; }
    public int RoundTimeS { get; set; }
    public List<double> RoundTimes { get; set; } = new();
    public double BestRoundTime { get; set; }
    public CarData CarData { get; set; } = new();
    public string ImgUrl { get; set; }
    public List<EFlags> Flags { get; set; } = [EFlags.DRIVING];
    public int CurrentRounds { get; set; }
    public int TrackPos { get; set; }
}