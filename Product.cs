using System;

namespace GenericCollection
{
    /// <summary>
    /// Represents a product with a name and a price.
    /// Products are compared according to their price.
    /// </summary>
    public class Product : IComparable<Product>
    {
        /// <summary>
        /// Gets the name of the product.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the price of the product.
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// Creates a new product.
        /// </summary>
        /// <param name="name">The name of the product.</param>
        /// <param name="price">The price of the product.</param>
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        /// <summary>
        /// Compares this product with another product using the price.
        /// </summary>
        /// <param name="other">The product to compare with.</param>
        /// <returns>
        /// A negative value if this product is cheaper,
        /// zero if the prices are equal,
        /// or a positive value if this product is more expensive.
        /// </returns>
        public int CompareTo(Product other)
        {
            if (other == null)
            {
                return 1;
            }

            return Price.CompareTo(other.Price);
        }

        /// <summary>
        /// Returns the product as readable text.
        /// </summary>
        /// <returns>The product name and price.</returns>
        public override string ToString()
        {
            return $"{Name}: {Price:0.00} kr.";
        }
    }
}