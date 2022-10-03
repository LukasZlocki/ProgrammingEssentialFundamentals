
using AccessModifiersAnotherClass;

var testClass = new TestClass();
Console.WriteLine(testClass.PublicField);
//Console.WriteLine(testClass.InternalField); <- no access from class outside assembly
//Console.WriteLine(testClass.ProtectedField); <- no access from class outside assembly
//Console.WriteLine(testClass.ProtectedInternalField); <- no access from class outside assembly
//Console.WriteLine(testClass.PrivateProtectedField); <- no access from class outside assembly


var testClass2 = new TestClass2();
Console.WriteLine(testClass2.PublicField);
Console.WriteLine(testClass2.InternalField);
//Console.WriteLine(testClass2.ProtectedField); <- no access 
Console.WriteLine(testClass2.ProtectedInternalField);
//Console.WriteLine(testClass2.PrivateProtectedField); <- no access

var testClassFromAnotherAssembly = new TestClassChild();
Console.WriteLine(testClassFromAnotherAssembly.PublicField);
//Console.WriteLine(testClassFromAnotherAssembly.InternalField);  <- no access from class outside assembly
//Console.WriteLine(testClassFromAnotherAssembly.ProtectedField);   <- no access from class outside assembly
//Console.WriteLine(testClassFromAnotherAssembly.ProtectedInternalField);  <- no access from class outside assembly
//Console.WriteLine(testClassFromAnotherAssembly.PrivateProtectedField);  <- no access from class outside assembly



public class TestClass2 
{
    public string PublicField = "public";
    internal string InternalField = "internal";
    protected string ProtectedField = "protected";
    protected internal string ProtectedInternalField = "protected internal";
    private protected string PrivateProtectedField = "private protected";
}

public class ChildOfTestClass2 : TestClass2
{

    public ChildOfTestClass2()
    {
        Console.WriteLine(base.PublicField);
        Console.WriteLine(base.InternalField);
        Console.WriteLine(base.ProtectedField);
        Console.WriteLine(base.ProtectedInternalField);
        Console.WriteLine(base.PrivateProtectedField); 
    }

}




