using System;

namespace InterfacesAndAbstractClasses_Task
{
    public class Bird: IFlyable

    {
        private float _currentPosition;
        private float _flySpeed;
        private int _minRandomValue = 0;
        private int _maxRandomValue = 20;

        public Bird(float currentPosition)
        {
            _currentPosition = currentPosition;
            _flySpeed = new Random().Next(_minRandomValue, _maxRandomValue);
        }

        public void FlyTo(float newPoint)
        {
            _currentPosition = newPoint;
            Console.WriteLine($"New position: {_currentPosition}");
        }

        public void GetFlyTime(float newPoint)
        {
            Console.WriteLine($"Fly Time:{MathF.Abs((_currentPosition - newPoint) / _flySpeed)}");
        }

        
    }
}