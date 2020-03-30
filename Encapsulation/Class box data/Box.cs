 using System;
using System.Collections.Generic;
using System.Text;

namespace Class_box_data
{
    public class Box
    {
        private const string INVALID_STRING_MESSAGE = "{0} cannot be zero or negative.";
        private const double SIDE_MIN_VALUE = 0;
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double heigth)
        {
            this.Length = length;
            this.Width = width;
            this.Height = heigth;
        }
        public double calculateSurfaceArea()
        {
            double surfaceArea = (2 * this.Length * this.Width) + (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
            return surfaceArea;
        }
        public double calculateLateralSurfaceArea()
        {
            double surfaceArea = (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
            return surfaceArea;
        }
        public double calculateVolume()
        {
            double volume = this.Length * this.Width * this.Height;
            return volume;
        }
        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= SIDE_MIN_VALUE)
                {
                    throw new ArgumentException(string.Format(INVALID_STRING_MESSAGE, nameof(this.Length)));
                }
                this.length = value;
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= SIDE_MIN_VALUE)
                {
                    throw new ArgumentException(string.Format(INVALID_STRING_MESSAGE, nameof(this.Width)));
                }
                this.width = value;
            }

        }
        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= SIDE_MIN_VALUE)
                {
                    throw new ArgumentException(string.Format(INVALID_STRING_MESSAGE, nameof(this.Height)));
                }
                this.height = value;
            }
        }

    }
}
