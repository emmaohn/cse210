public class Word {
    private string _word;
    public Word(string word){
        _word = word;
    }
    public void Print(bool isBlank) {
        if (isBlank) {
            int wordLength = _word.Length;
            Console.Write(new string('_', wordLength));
        } else {
            Console.Write(_word);
        }
    }
}