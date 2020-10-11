using System;
using System.Collections.Generic;
using System.Text;

namespace _02.PointsInRectangle
{
    public class Rectangle
    {

        private Point topLeft;

        private Point bottomRight;

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;

            this.bottomRight = bottomRight;
        }


        public bool Contains(Point point)
        {
            if(this.topLeft.X > point.X)
            {
                return false;
            }
            else if(this.bottomRight.X < point.X)
            {
                return false;
            }
            else if(this.bottomRight.Y < point.Y)
            {
                return false;
            }
            else if(this.topLeft.Y > point.Y)
            {
                return false;
            }
            return true;
        }
    }
}
