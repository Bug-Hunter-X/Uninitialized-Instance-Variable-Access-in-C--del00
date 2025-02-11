public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass()
    {
        // Initialize the property in the constructor.
        MyProperty = 0; // Or any other default value
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now MyProperty is guaranteed to have a value.
    }
}