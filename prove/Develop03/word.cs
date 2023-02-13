public class Word {
    private string _word;
    private bool _isblank;
    public Word(string word){
        word = _word;
    }
    public void Print() {
        Console.WriteLine(_word);
        if (_isblank) {
            int wordLength = _word.Length;
            Console.WriteLine(wordLength * '_');
        }
    }
}