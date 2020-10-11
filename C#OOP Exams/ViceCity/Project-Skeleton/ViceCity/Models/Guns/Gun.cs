using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public abstract class Gun : IGun
    {

        private string name;
        //{
        //    get
        //    {
        //        return this.name;
        //    }
        //    set
        //    {

        //            this.name = value;

        //    }
        //}

        protected int bulletsPerBarrel;
        //{
        //    //get
        //    //{
        //    //    return this.bulletsPerBarrel;
        //    //}
        //    //set
        //    //{
        //    //    if(value < 0)
        //    //    {
        //    //        throw new ArgumentException("Bullets cannot be below zero!");
        //    //    }
        //    //    else
        //    //    {
        //    //        this.bulletsPerBarrel = value;
        //    //    }
        //    //}
        //}

        protected int totalBullets;
        //{
        //    get
        //    {
        //        return this.totalBullets;
        //    }
        //    set
        //    {
        //        if(value < 0)
        //        {
        //            throw new ArgumentException("Total bullets cannot be below zero!");
        //        }
        //        else
        //        {
        //            this.totalBullets = value;
        //        }
        //    }
        //}

        private bool canFire
        {
            get
            {
                if(this.totalBullets > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //set
            //{
            //    if (this.totalBullets > 0)
            //    {
            //        this.canFire = true;
            //    }
            //    else
            //    {
            //        this.canFire = false;
            //    }
            //}
        }

        public Gun(string name, int bulletsPerBarrel, int totalBullets)
        {
            this.name = name;

            this.bulletsPerBarrel = bulletsPerBarrel;

            this.totalBullets = totalBullets;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int BulletsPerBarrel
        {
            get
            {
                return this.bulletsPerBarrel;
            }
        }
        

        public int TotalBullets
        {
            get
            {
                return this.totalBullets;
            }
        }

        public bool CanFire
        {
            get
            {
                return this.canFire;
            }
        }

        public abstract int Fire();
        
    }
}
