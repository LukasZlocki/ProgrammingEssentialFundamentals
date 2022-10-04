namespace AccessModifiersAnotherClass
{
    public class TestClass
    {
        public string PublicField = "public";
        internal string InternalField = "internal";
        protected string ProtectedField = "protected";
        protected internal string ProtectedInternalField = "protected internal";
        private protected string PrivateProtectedField = "private protected";
    }


    public class TestClassChild : TestClass
    {
        public TestClassChild()
        {
            Console.WriteLine(base.PublicField);
            Console.WriteLine(base.InternalField);
            Console.WriteLine(base.ProtectedField);
            Console.WriteLine(base.ProtectedInternalField);
            Console.WriteLine(base.PrivateProtectedField);
        }

    }



}

