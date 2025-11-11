using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraRental.Models;

public class CameraKit
{
    public string Brand { get; set; }   = string.Empty;
    public string Model { get; set; }   = string.Empty;
    public double DailyRate { get; set; } = 0.0;

    public CameraKit()
    {
        Console.WriteLine("CameraKit instance created.");
    }

    public CameraKit(string brand, string model, double dailyRate)
    {
        if(string.IsNullOrWhiteSpace(brand))
        {
            throw new ArgumentException("Brand cannot be null or empty.", nameof(brand));
        }

        if (string.IsNullOrWhiteSpace(model))
        {
            throw new ArgumentException("Model cannot be null or empty.", nameof(model));
        }

        Brand = brand;
        Model = model;
        DailyRate = dailyRate;
    }

    public void Display()
    {
        Console.WriteLine("CameraKit Display Called");
        Console.WriteLine(new string('*',40));
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Daily Rate: {DailyRate}");

    }
}
