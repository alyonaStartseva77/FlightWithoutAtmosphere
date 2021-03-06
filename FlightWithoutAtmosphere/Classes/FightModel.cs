using System;

namespace FlightWithoutAtmosphere.Classes
{
    static class FightModel
    {
        public const double TIME_STEP = 0.1;
        public const double g = 9.81;

        static public double a, v0, y0, t, x, y, maxX, maxY;

        static public void InitComponents()
        {
            t = 0;
            x = 0;
            y = y0;
            maxX = v0 * v0 * Math.Sin(2 * a * Math.PI / 180) / g;
            maxY = v0 * v0 * Math.Sin(a * Math.PI / 180) * Math.Sin(a * Math.PI / 180) / ( 2 * g );
        }

        static public void MakeStep()
        {
            t += TIME_STEP;
            x = v0 * Math.Cos(a * Math.PI / 180) * t;
            y = y0 + v0 * Math.Sin(a * Math.PI / 180) * t - g * t * t / 2;
        }
    }
}

