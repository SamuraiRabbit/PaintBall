using System;
using System.Collections.Generic;
using System.Text;

namespace PaintBall
{
    class PaintballGun
    {
        public const int MAGAZINE_SIZE = 16;

        private int _balls = 0;
        private int _ballsLoaded = 0;

        public int GetBallsLoaded() { return _ballsLoaded; }

        public bool IsEmpty() { return _ballsLoaded == 0; }

        public int GetBalls() { return _balls; }

        public void SetBalls(int numberOfBalls)
        {
            if (numberOfBalls > 0)
                _balls = numberOfBalls;
            Reload();
        }

        public void Reload()
        {
            if (_balls > MAGAZINE_SIZE)
                _ballsLoaded = MAGAZINE_SIZE;
            else
                _ballsLoaded = _balls;
        }

        public bool Shoot()
        {
            if (_ballsLoaded == 0) return false;
            _ballsLoaded--;
            _balls--;
            return true;
        }

    }
}
