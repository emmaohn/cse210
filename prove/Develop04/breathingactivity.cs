public class BreathingActivity : Activity {
    private int _breatheInDuration = 4;
    private int _breatheOutDuration = 6;
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") {}
    public void BreatheTimer() {
        while (!IsActivityComplete()) {
            Console.Write("\n\nBreathe in...  ");
            for (int i = _breatheInDuration; i> 0; i--) {
                Console.Write("\b" + i);
                Thread.Sleep(1000);
            }
            Console.Write("\b \nNow breathe out...  ");
            for (int i = _breatheOutDuration; i> 0; i--) {
                Console.Write("\b" + i);
                Thread.Sleep(1000);
            }
            Console.Write("\b ");
        }
    }
}