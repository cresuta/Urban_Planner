using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building b1 = new Building("304 Lightview Lane");
            b1.Width = 50.00;
            b1.Depth = 40.00;
            b1.Stories = 5;
            b1.Construct();
            b1.Purchase("Cameron");
            b1.DisplayInfo();
            Building b2 = new Building("717 Camp Hill");
            b2.Width = 100.00;
            b2.Depth = 20.00;
            b2.Stories = 2;
            b2.Construct();
            b2.Purchase("Courtney");
            b2.DisplayInfo();
            Building b3 = new Building("304 Morgantown Dr");
            b3.Width = 40.00;
            b3.Depth = 100.00;
            b3.Stories = 10;
            b3.Construct();
            b3.Purchase("Noah");
            b3.DisplayInfo();
            Building b4 = new Building("717 Lion St");
            b4.Width = 200.00;
            b4.Depth = 100.00;
            b4.Stories = 10;
            b4.Construct();
            b4.Purchase("Julie");
            b4.DisplayInfo();
            Building b5 = new Building("304 Ruby Medical Dr");
            b5.Width = 50.00;
            b5.Depth = 200.00;
            b5.Stories = 20;
            b5.Construct();
            b5.Purchase("Michele");
            b5.DisplayInfo();
        }

    }
}
