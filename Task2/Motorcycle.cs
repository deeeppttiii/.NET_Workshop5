using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Motorcycle : Vehicle
{
    public bool HasCarrier { get; set; }   // unique field

    public override void DisplayInfo()
    {
        base.DisplayInfo();  // reuse base class code
        Console.WriteLine($"Has Carrier: {HasCarrier}");
    }
}
