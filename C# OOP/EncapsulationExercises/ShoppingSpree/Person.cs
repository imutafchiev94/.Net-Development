using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {

		private string name;
		private double money;
		private List<Product> bagOfProducts;

		public Person(string name, double money)
		{
			this.Name = name;
			this.Money = money;

			this.bagOfProducts = new List<Product>();
		}

		public string Name
		{
			get { return this.name; }
			private set 
			{ 
				if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Name cannot be empty");
				}
				this.name = value; 
			}
		}

		public double Money 
		{ 
			get
			{
				return this.money;
			}
			set
			{
				if(value < 0)
				{
					throw new ArgumentException("Money cannot be negative");
				}
				this.money = value;
			}
		}

		public IReadOnlyCollection<Product> BagOfProducts 
		{
			get { return this.bagOfProducts.AsReadOnly(); } 
		}

		public void Buy(Product product)
		{
			if(this.money - product.Cost >= 0)
			{
				this.bagOfProducts.Add(product);
				this.money -= product.Cost;
				Console.WriteLine($"{this.name} bought {product.Name}");
			}
			else
			{
				Console.WriteLine($"{this.name} can't afford {product.Name}");
			}
		}

	}
}
