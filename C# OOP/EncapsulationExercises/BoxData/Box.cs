using System;
using System.Collections.Generic;
using System.Text;

namespace BoxData
{
    public class Box
    {

        private double lenght;

        private double width;

        private double height;

        public Box(double lenght, double height, double width)
        {
            this.lenght = lenght;
            this.height = height;
            this.width = width;
        }

        public double Lenght
        {
            get
            {
                //if (this.lenght < 1)
                //{
                //    throw new ArgumentException("Lenght cannot be zero or negative.");
                //}
                return this.lenght;
            }
            private set
            {
                if(value < 1)
                {
                    throw new ArgumentException("Lenght cannot be zero or negative.");
                }
            }
        }

        public double Width
        {
            get
            {
                //if (this.width < 1)
                //{
                //    throw new ArgumentException("Width cannot be zero or negative.");
                //}
                return this.width;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
            }
        }

        public double Height
        {
            get
            {

                //if (this.height < 1)
                //{
                //    throw new ArgumentException("Height cannot be zero or negative.");
                //}
                return this.height;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
            }
        }

        public void SurfaceArea()
        {
            if(this.Lenght > 0 && this.Height > 0 && this.Width > 0)
            {
                var surfaceArea = 2 * (this.Lenght * this.Width) + 2 * (this.Lenght * this.Height) + 2 * (this.Width * this.Height);

                Console.WriteLine($"Surface Area - {string.Format("{0:0.00}", surfaceArea)}");
            }
            
            else if (this.Lenght <= 0)
            {
                Console.WriteLine("Length cannot be zero or negative.");
            }
            else if(this.Width <= 0)
            {
                Console.WriteLine("Width cannot be zero or negative.");
            }
            else if (this.Height <= 0)
            {
                Console.WriteLine("Height cannot be zero or negative.");
            }
        }

        public void LateralSurfaceArea()
        {
            if (this.Lenght > 0 && this.Height > 0 && this.Width > 0)
            {
                var lateralSurfaceArea = 2 * (this.Lenght * this.Height) + 2 * (this.Width * this.Height);

                Console.WriteLine($"Lateral Surface Area - {string.Format("{0:0.00}", lateralSurfaceArea)}");
            }

        }

        public void Volume()
        {
            if (this.Lenght > 0 && this.Height > 0 && this.Width > 0)
            {
                var volume = this.Lenght * this.Height * this.Width;

                Console.WriteLine($"Volume - {string.Format("{0:0.00}", volume)}");
            }

        }
    }
}
