using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records
{
    public record class CarRecord(string Make, string Model, string Color);

    // record class CarRecord
    // {
        // public string Make { get; init; }
        // public string Model { get; init; }
        // public string Color { get; init; }
        //
        // public CarRecord() { }
        //
        // public CarRecord(string make, string model, string color)
        // {
        //     Make = make;
        //     Model = model;
        //     Color = color;
        // }
    // }
}
