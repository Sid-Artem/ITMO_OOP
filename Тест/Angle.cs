using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тест
{
    internal class Angle
    {

        double gradus;
        double min;
        double sec;

        public double Gradus
        {
            get
            {
                return gradus;

            }
            set
            {
                gradus = value % 360;
            }
        }
        public double Min
        {
            get
            {
                return min;

            }
            set
            {
                Gradus += value / 60;
                min = value % 60;
            }
        }

        public double Sec
        {
            get
            {
                return sec;

            }
            set
            {
                Min += value / 60;
                sec = value % 60;
            }
        }


        public Angle(double gradus, double min, double sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;

        }


        public double ToRadians()
        {
            return (gradus + ((min + sec) / 60) / 60) * Math.PI / 180;
        }

    }
}
