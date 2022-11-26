using System;

namespace InterfacesAndAbstractClasses_Task
{
    public class Drone: IFlyable
    {
        private float _currentPosition;
        private float _flyDistance = 1000f;
        private float _flySpeed;
        private float _hoverTime = 1f;
        private float _timeBeforeHover = 10f;
        private bool isCanFly;
        

        public Drone(float currentPosition, float flyDistance, float flySpeed)
        {
            _currentPosition = currentPosition;
            _flyDistance = flyDistance;
            _flySpeed = flySpeed;
        }

        public void FlyTo(float newPoint)
        {
            CheckIsCanFly(newPoint);
            if (!isCanFly) return;
            _currentPosition = newPoint;
            Console.WriteLine($"New position: {_currentPosition}");
        }

        public void GetFlyTime(float newPoint)
        {
            CheckIsCanFly(newPoint);
            if (!isCanFly) return;
            var timeWithHover = MathF.Abs((_currentPosition - newPoint) / _flySpeed / _timeBeforeHover * _hoverTime);
            Console.WriteLine($"Fly time: {MathF.Abs((_currentPosition - newPoint) / _flySpeed) + timeWithHover}");


        }

        private void CheckIsCanFly( float newPoint)
        {
            if (MathF.Abs(_currentPosition - newPoint) < _flyDistance)
            {
                isCanFly = true;
            }
            else
            {
                isCanFly = false;
                Console.WriteLine("It is very far. I won't make it.");
            }
        }
    }
}