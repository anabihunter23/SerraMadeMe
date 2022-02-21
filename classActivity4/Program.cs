interface AnInterface
{
//properties
    string AString { get; set; }
    float AFloat { get; set; }
    double ADouble { get; set; }

//instance method
    void AnInstanceMethod();

//delegate and event
    delegate void ADelegate(object source, EventArgs args);
    event ADelegate AnEvent;
}

class AClass : AnInterface
{
//inherited properties
    public string AString { get; set; } = null!; //I was getting a warning about nullable properties for strings and web forums/compiler suggested making string properties as nullable
    public float AFloat { get; set; }
    public double ADouble { get; set; }

//inherited instance method
    public void AnInstanceMethod() {
        Console.WriteLine("Hello User");
    }

//inherited event
    event AnInterface.ADelegate AnInterface.AnEvent {
        add { throw new NotImplementedException(); }
        remove { throw new NotImplementedException(); }
    }

//main
    static void Main() {
        var AObject = new AClass();
        AObject.AnInstanceMethod();
    }
}