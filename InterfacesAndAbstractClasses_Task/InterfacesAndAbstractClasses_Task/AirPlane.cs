using System;

namespace InterfacesAndAbstractClasses_Task
{
    public class AirPlane: IFlyable
    {
        private float _startPosition;
        private float _currentPosition;
        private float _currentSpeed = 200f;
        private float increaseDistance = 10f;
        private float increaseValue = 10f;

        public AirPlane(float currentPosition)
        {
            _currentPosition = currentPosition;
        }

        public void FlyTo(float newPoint)
        {
            _currentPosition = newPoint;
            Console.WriteLine($"New position: {_currentPosition}");
        }

        public void GetFlyTime(float newPoint)
        {
           var speed =  ((_currentPosition - newPoint) / increaseDistance) * increaseValue + _currentSpeed;
           Console.WriteLine($"Fly Time: {MathF.Abs((_currentPosition - newPoint)/ speed)}");
        }
        
    }
}