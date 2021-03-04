using System;
using System.Drawing;
using System.Diagnostics;

namespace towerDefense
{
    class GameObject
    {
        Units _gameObject;
        PointF _position;
        Point _direction;
        float _speed; // Буду мерить скорость в пикселях в секунду
        Stopwatch _lastUpdate = new Stopwatch();

        public GameObject(Units gameObject, PointF position, Point direction, float speed)//{Хорошобы игровой объект сделать не только юнитами
        {
            _gameObject = gameObject;
            _position = position;
            _direction = direction;
            _speed = speed;
            _lastUpdate.Start();
        }

        public GameObject(Units gameObject, Point position)
        {
            _gameObject = gameObject;
            _position = position;
            _direction = new Point(0,0);
            _speed = 0;
            _lastUpdate.Start();
        }

        public void objectUpdate()
        {
            long miliSec = _lastUpdate.ElapsedMilliseconds;
            float ofsetTime = miliSec/(float)1000.0;

            SizeF ofset = new SizeF(_direction.X * ofsetTime * _speed, _direction.Y * ofsetTime * _speed);
            _position = PointF.Add(_position, ofset);
            _lastUpdate.Restart();
        }

        public PointF getPosition()
        {
            return _position;
        }
    }
}