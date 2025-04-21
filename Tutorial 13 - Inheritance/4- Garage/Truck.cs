using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Truck : Vehicle
{
    public Truck(int id, string model, string brand, decimal fuelLitres, decimal maxFuel, bool isRunning, decimal LoadCapacity)
        : base(id, model, brand, fuelLitres, maxFuel, isRunning)
    {
        this.LoadCapacity = LoadCapacity;
    }
    private decimal LoadCapacity { get; set; }
    protected override void Drive(decimal km)
    {
        FuelLitres -= (.2m * km);
    }
    public override string ToString()
    {
        return base.ToString()+
            $"LoadCapacity : {LoadCapacity} ton";
    }

}