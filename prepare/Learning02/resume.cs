public class Resume {
    // resume member variables
    public string _name = "";
    public List<Job> _jobs = new List<Job>();
    
    // resume methods
    public void Display() {}
    public void DisplayResume() {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs) {
            job.DisplayJob();
        }
    }
}