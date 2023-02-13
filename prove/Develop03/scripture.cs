public class Scripture {
    public string _ref;
    public List<string> _words = new List<string>();
    public class Scripgenerator {
        public string[] _scriptures = {
            "John 3:16|For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
            "psalms 3:5-6|I laid me down and slept; I awaked; for the Lord sustained me. I will not be afraid of ten thousands of people, that have set themselves against me round about."
        };
        public string GetScripture() {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0,_scriptures.Length);
            return _scriptures[number];
        }
        // Reference reference = new Reference("Proverbs", 3, 5, 6);
        // Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
    }

    public void Print(string scripture){
        // string[] scrip = scripture;
        int i = 0;
        string[] parts = scripture.Split(" ");
        foreach (string word in parts){
            _words.Add(new Word(parts[i++]));
        }
        
    }
    
    
}