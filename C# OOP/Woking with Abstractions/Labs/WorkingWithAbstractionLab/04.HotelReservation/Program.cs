using System;
using System.Linq;

namespace _04.HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            var pricePerDay = double.Parse(input[0]);

            var numberOfDays = int.Parse(input[1]);

            Season season = Season.Autumn;

            switch(input[2])
            {
                case "Autumn":
                    {
                        season = Season.Autumn;

                        break; 
                    }
                case "Summer":
                    {
                        season = Season.Summer;

                        break;
                    }
                case "Spring":
                    {
                        season = Season.Spring;

                        break;
                    }
                case "Winter":
                    {
                        season = Season.Winter;

                        break;
                    }
            }

            Discount discount = Discount.None;

            if (input.Length > 3)
            {
                switch (input[3])
                {
                    case "VIP":
                        {
                            discount = Discount.VIP;

                            break;
                        }
                    case "SecondVisit":
                        {
                            discount = Discount.SecondVisit;

                            break;
                        }
                }
            }
            else
            {
                discount = Discount.None;
            }

            Console.WriteLine(string.Format("{0:0.00}",PriceCalculator.GetTotalPrice(pricePerDay, numberOfDays, season, discount)));
        }
    }
}
