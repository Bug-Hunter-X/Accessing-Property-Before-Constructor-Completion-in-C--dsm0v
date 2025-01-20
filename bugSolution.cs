public class MyClass {
    public int MyProperty { get; set; }

    public MyClass() {
        // Initialize MyProperty to a non-zero value
        MyProperty = 1;
    }

    public void MyMethod() {
        // Access MyProperty here - it is guaranteed to be initialized
        Console.WriteLine(MyProperty); 
    }
}