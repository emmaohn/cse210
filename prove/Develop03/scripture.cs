public class Scripture {
    private Reference _ref;
    private List<int> _remainingWordIndexes = new List<int>();
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string scripture){
        _ref = reference;
        string[] parts = scripture.Split(" ");
        foreach (string word in parts) {
            _words.Add(new Word(word));
            _remainingWordIndexes.Add(_words.Count - 1);
        }
    }
    private bool isBlank(int i) {
        return !_remainingWordIndexes.Contains(i);
    }
    public void Print(){
        for (int i = 0; i < _words.Count; i++) {
            _words[i].Print(!_remainingWordIndexes.Contains(i));
            Console.Write(" ");
        }
    }
    public void Blank(int blanks) {
        Random randomGenerator = new Random();
        int randomBlankIndex = -1;
        for (int i = 0; i < blanks; i++) {
            do {
                if (CheckAllBlank()) {break;}
                randomBlankIndex = randomGenerator.Next(_words.Count);
            } while (isBlank(randomBlankIndex));
            _remainingWordIndexes.Remove(randomBlankIndex);
        }
    }
    public bool CheckAllBlank() {
        return _remainingWordIndexes.Count < 1;
    }
}