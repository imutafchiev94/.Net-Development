using System;
using System.Collections.Generic;
using System.Text;

namespace _04.HotelReservation
{
    static public class PriceCalculator
    {

        static public double GetTotalPrice(double pricePerDay, int numberOfDays, Season season, Discount discount)
        {

            double finalPrice = 0;

            switch(season)
            {
                case Season.Autumn:
                    {

                        finalPrice = pricePerDay * numberOfDays;

                        switch(discount)
                        {
                            case Discount.VIP:
                                {
                                    finalPrice -= finalPrice * 0.2;
                                    break;
                                }
                            case Discount.SecondVisit:
                                {
                                    finalPrice -= finalPrice * 0.1;
                                    break;
                                }
                        }

                        break;
                    }
                case Season.Spring:
                    {

                        finalPrice = (2 * pricePerDay) * numberOfDays;
                        switch (discount)
                        {
                            case Discount.VIP:
                                {
                                    finalPrice -= finalPrice * 0.2;
                                    break;
                                }
                            case Discount.SecondVisit:
                                {
                                    finalPrice -= finalPrice * 0.1;
                                    break;
                                }
                        }

                        break;
                    }
                case Season.Summer:
                    {
                        finalPrice = (4 * pricePerDay) * numberOfDays;
                        switch (discount)
                        {
                            case Discount.VIP:
                                {
                                    finalPrice -= finalPrice * 0.2;
                                    break;
                                }
                            case Discount.SecondVisit:
                                {
                                    finalPrice -= finalPrice * 0.1;
                                    break;
                                }
                        }

                        break;
                    }
                case Season.Winter:
                    {
                        finalPrice = (3 * pricePerDay) * numberOfDays;
                        switch (discount)
                        {
                            case Discount.VIP:
                                {
                                    finalPrice -= finalPrice * 0.2;
                                    break;
                                }
                            case Discount.SecondVisit:
                                {
                                    finalPrice -= finalPrice * 0.1;
                                    break;
                                }
                        }

                        break;
                    }
            }

            return finalPrice;
        }

    }
}
