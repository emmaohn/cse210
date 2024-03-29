public class Swim : Activity {
    private double _laps;
    public Swim(string date, double minutes, double laps) : base(date, minutes) {
        _laps = laps;
    }
    public override double GetDistance() {
        return _laps * 50 /1000 * 0.62;
    }
    public override double GetSpeed() {
        return (GetDistance() / _minutes) * 60;
    }
    public override double GetPace() {
        return 60 / GetSpeed();
    }
    public override string GetActivity(){
        return "Swimming";
    }
}