using System;

namespace ConsoleApp3
{
    public class Vehicle
    {
        private readonly string _vehicleName;
        public Transmission Transmission { get; }
        public Chassis Chassis { get; }
        public Engine Engine { get; }

        public Vehicle(string name, Transmission transmission, Chassis chassis, Engine engine)
        {
            _vehicleName = name;
            Transmission = transmission;
            Chassis = chassis;
            Engine = engine;
        }

        public string GetName()
        {
            return _vehicleName;
        }
        

        public string GetTransmissionData()
        {
            
            return $"Transmission info: \n" +
                   $"Type: {Transmission.Type} \n" +
                   $"Number Of Gears: {Transmission.NumberOfGears} \n" +
                   $"Manufacturer: {Transmission.Manufacturer} \n";

        }
        
        public string GetEngineData()
        {
            return $"Engine Info: \n" +
                   $"Power: {Engine.Power} \n" +
                   $"Volume: {Engine.Volume} \n" +
                   $"Type: {Engine.Type} \n" +
                   $"Serial: {Engine.Serial} \n" +
                   $"Number: {Engine.Number} \n";
        }
        
        public string GetChassisData()
        {
            return $"Chassis info: \n" +
                   $"Wheels Number: {Chassis.WheelsNumber} \n" +
                   $"Number: {Chassis.Number} \n" +
                   $"Permissible Load: {Chassis.PermissibleLoad} \n";
        }
    }
}