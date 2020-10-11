using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns
{
    public class Pistol : Gun
    {
        public Pistol(string name) : base(name, 10, 100)
        {
        }

        public override int Fire()
        {
            if(this.CanFire)
            {
                if (this.BulletsPerBarrel >= 1)
                {
                    this.bulletsPerBarrel -= 1;
                }
                else
                {
                    if(this.totalBullets >= 10)
                    {
                        this.bulletsPerBarrel = 10;
                        this.totalBullets -= 10;
                    }
                    else
                    {
                        this.bulletsPerBarrel += this.totalBullets;
                        this.totalBullets = 0;
                    }
                }

                    return 1;
            }
            else
            {
                return 0;
            }
            
        }
    }
}
