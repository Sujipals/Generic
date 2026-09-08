using System;
using System.Collections.Generic;

namespace GenericCollection
{
    /// <summary>
    /// Contains generic methods for comparing values.
    /// </summary>
    public static class GenericMethods
    {
        /// <summary>
        /// Finds the largest value in a list.
        /// </summary>
        /// <typeparam name="T">
        /// The type of values in the list.
        /// </typeparam>
        /// <param name="items">The list to search.</param>
        /// <returns>The largest value in the list.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when the list is null or empty.
        /// </exception>
        public static T Max<T>(List<T> items)
            where T : IComparable<T>
        {
            if (items == null || items.Count == 0)
            {
                throw new ArgumentException(
                    "The list cannot be null or empty.",
                    nameof(items));
            }

            T max = items[0];

            foreach (T item in items)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        /// <summary>
        /// Finds the smallest value in a list.
        /// </summary>
        /// <typeparam name="T">
        /// The type of values in the list.
        /// </typeparam>
        /// <param name="items">The list to search.</param>
        /// <returns>The smallest value in the list.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when the list is null or empty.
        /// </exception>
        public static T Min<T>(List<T> items)
            where T : IComparable<T>
        {
            if (items == null || items.Count == 0)
            {
                throw new ArgumentException(
                    "The list cannot be null or empty.",
                    nameof(items));
            }

            T min = items[0];

            foreach (T item in items)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }
    }
}