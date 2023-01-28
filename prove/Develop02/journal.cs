using System.IO; 
public class Journal {
    private class Journalentry {
        public string _userInput = "";
        public string _prompt = "";
        public string _date = "";
        public Journalentry(string date, string prompt, string userInput) {
            _date = date;
            _prompt = prompt;
            _userInput = userInput;
        }
        public void Print() {
            Console.WriteLine($"Date: {_date}\nPrompt: {_prompt}\n{_userInput}");
        }
        public string GetSaveData() {
            return $"{_date}|{_prompt}|{_userInput}";
        }
    }
    
    private List<Journalentry> _entries = new List<Journalentry>();
    
    // entry methods
    public void DisplayEntries() {
        // if there are no entries, nothing will print
        if (_entries.Count() == 0) {
            Console.WriteLine("No current journal entries");
        // display current entries
        } else {
            foreach (Journalentry ent in _entries) {
                ent.Print();
            }
        }
    }
    public void CreateEntry(string _date, string _prompt, string _userInput) {
        Journalentry ent = new Journalentry(_date, _prompt, _userInput);
        _entries.Add(ent);
    }

    // load and save methods
    public void LoadJournal(string fileName) {
        // _journal = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines) {
            string[] parts = line.Split("|");

            // 0 date, 1 prompt, 2 userInput
            _entries.Add(new Journalentry(parts[0],parts[1],parts[2]));
        }
    }
    public void SaveJournal(string fileName) {
        using (StreamWriter outputFile = new StreamWriter(fileName)) {
            // store journal entries
            foreach (Journalentry ent in _entries) {
                outputFile.WriteLine(ent.GetSaveData());
            }
        }
    }
}