public class ExampleClass
{
    private int _myVariable;

    public ExampleClass() //Constructor added to initialize the property
    {
        _myVariable = 0; //Initialize MyProperty
    }

    public int MyProperty
    {
        get { return _myVariable; }
        set { _myVariable = value; }
    }

    public void MyMethod()
    {
        // Some code here...
        int anotherVariable = MyProperty; //Now safe to access
        //More code here...
    }
}