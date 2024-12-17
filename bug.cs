public class ExampleClass
{
    private int _myVariable;

    public int MyProperty
    {
        get { return _myVariable; }
        set { _myVariable = value; }
    }

    public void MyMethod()
    {
        // Some code here...
        int anotherVariable = MyProperty; //This line might cause error if MyProperty is not initialized
        //More code here...
    }
}