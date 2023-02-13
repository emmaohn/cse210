public class Reference {
    string _book;
    int _chapter;
    int _startverse;
    int _endverse = 0;
    public Reference(string book, int chapter, int startverse, int endverse){
        book = _book;
        chapter = _chapter;
        startverse = _startverse;
        endverse = _endverse;
    }
    public Reference(string book, int chapter, int startverse){
        book = _book;
        chapter = _chapter;
        startverse = _startverse;
    }
    public void Print(){
        if (_endverse != 0) {
            Console.WriteLine($"{_book} {_chapter}:{_startverse}-{_endverse}");
        } else {
            Console.WriteLine($"{_book} {_chapter}:{_startverse}");
        }
    }
}