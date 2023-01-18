public class Job {
    // job member variables
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0000;
    public int _endYear = 0000;

    // job methods
    public Job() {}
    public void DisplayJob() {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}