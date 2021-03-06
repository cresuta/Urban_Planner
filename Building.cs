using System;
public class Building
{
    private string _designer = "Cameron";
    private DateTime _dateConstructed { get; set; }
    private string _address { get; set; }
    private string _owner { get; set; }

    public int Stories { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    public Building(string address)
    {
        _address = address;
    }
    public double Volume
    {
        get
        {
            return Width * Depth * (3 * Stories);
        }
    }

    public void Construct()
    {
        _dateConstructed = DateTime.Now;
    }

    public void Purchase(string nameOfBuyer)
    {
        _owner = nameOfBuyer;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"\n{_address}");
        Console.WriteLine("-------------");
        Console.WriteLine($"Designed by {_designer}");
        Console.WriteLine($"Constructed on {_dateConstructed}");
        Console.WriteLine($"Owned by {_owner}");
        Console.WriteLine($"{Volume} cubic meteres of space");
    }
}