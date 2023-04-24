﻿namespace Online_Bookstore
{
	public class Book
	{
        public string author { get; set; }
        public string title { get; set; }
        public double price { get; set; }
        public string genre { get; set; }
        public double warehousePrice;

        public Book(string title, string author, string genre, double price)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.price = price;

            this.warehousePrice = calcWarehousePrice();
        }

        protected virtual double calcWarehousePrice()
        {
            double buyerPrice = 0;
            if (price > 0 && price <= 10)
            {
                buyerPrice = price + price * 0.02;
            }
            else if (price > 10 && price <= 20)
            {
                buyerPrice = price + price * 0.05;
            }
            else if (price > 20 && price <= 30)
            {
                buyerPrice = price + price * 0.07;
            }
            else if (price > 30)
            {
                buyerPrice = price + price * 0.1;
            }
            else
            {
                // invalid price
            }
            return buyerPrice;
        }

        public double getWarehousePrice()
        {
            return warehousePrice;
        }
    }
}
