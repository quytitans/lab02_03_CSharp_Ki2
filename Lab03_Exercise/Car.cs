using System;
class Car
{

    public string make;
    public string model;
    public string color;
    public int yearBuilt;

    public void Start()
    {
        System.Console.WriteLine(model + " started");
    }
    public void Stop()
    {
        System.Console.WriteLine(model + " stopped");
    }
}