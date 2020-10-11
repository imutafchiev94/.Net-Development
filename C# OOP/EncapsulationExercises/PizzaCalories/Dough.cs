using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {

        private string flourType;

        private string bakingTechnique;

        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;

            this.BakingTechnique = bakingTechnique;

            this.Weight = weight;
        }

        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                if(value == "White" || value == "Wholegrain" || value == "white" || value == "wholegrain")
                {
                    this.flourType = value;
                }
                else
                {
                    throw new Exception("Invalid type of dough.");
                }
            }
        }

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            private set
            {
                if (/*value == "Crispy" || value == "Chewy" || value == "Homemade" ||*/ value == "crispy" || value == "chewy" || value == "homemade")
                {
                    this.bakingTechnique = value;
                }
                else
                {
                    throw new Exception("Invalid type of dough.");
                }
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new Exception("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public double CalculateCalories()
        {
            double calories = 0;

            switch(this.flourType)
            {
                case "white":
                    {
                        switch(this.bakingTechnique)
                        {
                            //case "Crispy":
                            //    {
                            //        calories = (2 * this.weight) * 1.5 * 0.9;

                            //        break;
                            //    }
                            //case "Chewy":
                            //    {
                            //        calories = (2 * this.weight) * 1.5 * 1.1;

                            //        break;
                            //    }
                            //case "Homemade":
                            //    {
                            //        calories = (2 * this.weight) * 1.5 * 1.0;

                            //        break;
                            //    }
                            case "crispy":
                                {
                                    calories = (2 * this.weight) * 1.5 * 0.9;

                                    break;
                                }
                            case "chewy":
                                {
                                    calories = (2 * this.weight) * 1.5 * 1.1;

                                    break;
                                }
                            case "homemade":
                                {
                                    calories = (2 * this.weight) * 1.5 * 1.0;

                                    break;
                                }
                        }
                        break;
                    }
                case "wholegrain":
                    {
                        switch (this.bakingTechnique)
                        {
                            //case "Crispy":
                            //    {
                            //        calories = (2 * this.weight) * 1.0 * 0.9;

                            //        break;
                            //    }
                            //case "Chewy":
                            //    {
                            //        calories = (2 * this.weight) * 1.0 * 1.1;

                            //        break;
                            //    }
                            //case "Homemade":
                            //    {
                            //        calories = (2 * this.weight) * 1.0 * 1.0;

                            //        break;
                            //    }
                            case "crispy":
                                {
                                    calories = (2 * this.weight) * 1.0 * 0.9;

                                    break;
                                }
                            case "chewy":
                                {
                                    calories = (2 * this.weight) * 1.0 * 1.1;

                                    break;
                                }
                            case "homemade":
                                {
                                    calories = (2 * this.weight) * 1.0 * 1.0;

                                    break;
                                }
                        }
                        break;
                    }
                //case "white":
                //    {
                //        switch (this.bakingTechnique)
                //        {
                //            case "Crispy":
                //                {
                //                    calories = (2 * this.weight) * 1.5 * 0.9;

                //                    break;
                //                }
                //            case "Chewy":
                //                {
                //                    calories = (2 * this.weight) * 1.5 * 1.1;

                //                    break;
                //                }
                //            case "Homemade":
                //                {
                //                    calories = (2 * this.weight) * 1.5 * 1.0;

                //                    break;
                //                }
                //            case "crispy":
                //                {
                //                    calories = (2 * this.weight) * 1.5 * 0.9;

                //                    break;
                //                }
                //            case "chewy":
                //                {
                //                    calories = (2 * this.weight) * 1.5 * 1.1;

                //                    break;
                //                }
                //            case "homemade":
                //                {
                //                    calories = (2 * this.weight) * 1.5 * 1.0;

                //                    break;
                //                }
                //        }
                //        break;
                //    }
                //case "wholegrain":
                //    {
                //        switch (this.bakingTechnique)
                //        {
                //            case "Crispy":
                //                {
                //                    calories = (2 * this.weight) * 1.0 * 0.9;

                //                    break;
                //                }
                //            case "Chewy":
                //                {
                //                    calories = (2 * this.weight) * 1.0 * 1.1;

                //                    break;
                //                }
                //            case "Homemade":
                //                {
                //                    calories = (2 * this.weight) * 1.0 * 1.0;

                //                    break;
                //                }
                //            case "crispy":
                //                {
                //                    calories = (2 * this.weight) * 1.0 * 0.9;

                //                    break;
                //                }
                //            case "chewy":
                //                {
                //                    calories = (2 * this.weight) * 1.0 * 1.1;

                //                    break;
                //                }
                //            case "homemade":
                //                {
                //                    calories = (2 * this.weight) * 1.0 * 1.0;

                //                    break;
                //                }
                //        }
                //        break;
                //    }
            }

            return calories;
        }
    }
}
