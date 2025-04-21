using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Car : Vehicle
{
    public Car(int id, string model, string brand, decimal fuelLitres, decimal maxFuel, bool isRunning, bool HasAirConditioning, int NumberOfDoors) 
        : base(id, model, brand, fuelLitres, maxFuel, isRunning)
    {
        this.HasAirConditioning = HasAirConditioning;
        this.NumberOfDoors = NumberOfDoors;
    }

    private bool HasAirConditioning { get; set; }
    private int NumberOfDoors { get; set; }
    protected override void Drive(decimal km)
    {
        FuelLitres -= (.1m * km);
    }
    public override string ToString()
    {
        return base.ToString()+
                $"Has AirConditioning : {HasAirConditioning}\n" +
                $"Number of doors : {NumberOfDoors}\n";
    }

}

