using System.Collections;

var customCollection = new WordsCollection(new[] { "a", "little", "Duck" });

// thanks to IEnumerator we are able to itarate through collection 
foreach (var item in customCollection)
{
    Console.WriteLine(item);
}


public class WordsCollection : System.Collections.IEnumerable
{
    private string[] _words;

    public WordsCollection(string[] words)
    {
        _words = words;
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

class WordsEnumerator : IEnumerator
{
    private string[] _words;
    private int _possition = -1;

    public WordsEnumerator(string[] words)
    {
        _words = words; 
    }

    public object Current
    {
        get
        {
            try
            {
                return _words[_possition];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException("End of collection");
            }
        }
    }

    public bool MoveNext()
    {
        _possition++;
        return _possition < _words.Length;
    }

    public void Reset()
    {
        _possition = -1;
    }


}
