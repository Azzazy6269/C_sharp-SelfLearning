using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Motorcycle : Vehicle
{
    public Motorcycle(int id, string model, string brand, decimal fuelLitres, decimal maxFuel, bool isRunning,bool HasHelmetStorage)
        : base(id, model, brand, fuelLitres, maxFuel, isRunning)
    {
        this.HasHelmetStorage = HasHelmetStorage;
    }

    private bool HasHelmetStorage { get; set; }
    protected override void Drive(decimal km)
    {
        FuelLitres -= (.05m * km);
    }
    public override string ToString()
    {
        return base.ToString()+
            $"Has helmet storage : {HasHelmetStorage}";
    }

}
