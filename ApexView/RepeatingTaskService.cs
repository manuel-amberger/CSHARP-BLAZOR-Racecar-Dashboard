namespace ApexView;

using System.Timers;
public class RepeatingTaskService : IDisposable {
    private readonly Timer _timer;

    public event Action? OnTick;

    public RepeatingTaskService() {
        _timer = new Timer(1000); // alle 1 Sekunde
        _timer.Elapsed += (_, _) => OnTick?.Invoke();
        _timer.AutoReset = true;
        _timer.Start();
    }

    public void Dispose() {
        _timer.Dispose();
    }
}