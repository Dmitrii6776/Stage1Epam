

using System;
using InterfacesAndAbstractClasses_Task;

IFlyable falcone = new Bird(4);
falcone.GetFlyTime(10);
falcone.FlyTo(10);

IFlyable AirBus = new AirPlane(7);
AirBus.GetFlyTime(12);
AirBus.FlyTo(12);
IFlyable DJIPhantom = new Drone(9, 1000, 15);
DJIPhantom.GetFlyTime(15);
DJIPhantom.FlyTo(15);
