using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns
{
    public class Rifle : Gun
    {
        public Rifle(string name) : base(name, 50, 500)
        {
        }

        public override int Fire()
        {
            if (this.CanFire)
            {
                if (this.BulletsPerBarrel >= 5)
                {
                    this.bulletsPerBarrel -= 5;
                }
                else
                {
                    if (this.totalBullets >= 50)
                    {
                        this.bulletsPerBarrel = 50;
                        this.totalBullets -= 50;
                    }
                    else
                    {
                        this.bulletsPerBarrel += this.totalBullets;
                        this.totalBullets = 0;
                    }
                }

                return 5;
            }
            else
            {
                return 0;
            }
        }
    }
}
