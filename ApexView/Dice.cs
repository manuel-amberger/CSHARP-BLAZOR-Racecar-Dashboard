namespace ApexView;

public static class Dice {
    public static int Roll() {
        var dice = new Random();
        return dice.Next(0, 100);
    }

    public static int BigRoll() {
        var dice = new Random();
        return dice.Next(0, 1000);
    }
    public static int TemperaturRoll() {
        var dice = new Random();
        return dice.Next(10, 40);
    }
    public static double RoundTimeRoll() {
        var dice = new Random();
        return dice.Next(88, 104);
    }
}