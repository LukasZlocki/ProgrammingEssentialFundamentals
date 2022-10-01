
// Compilation error - appear during programing and is reported by ex visual studio , lack of ;
//var Number = 5

// Run time errors : accure when programs are running
// Solution: exceptions can handle with this type of errors
//var list = new List<int>();
//var firstElem = list.First();

// logical errors - example : all words are merged without space, logic error made by coder
// Solution : Build unit tests for application
string MergeWords(params string[] words)
{
    return string.Join("", words);
}

var sentence = MergeWords("A", "little", "Duck");
Console.WriteLine(sentence);



Console.ReadLine();