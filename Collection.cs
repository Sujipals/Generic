using System;
using System.Collections.Generic;

namespace GenericCollection
{
    /// <summary>
    /// Represents a generic collection that can store elements of any type.
    /// </summary>
    /// <typeparam name="T">The type of elements stored in the collection.</typeparam>
    public class Collection<T>
    {
        // The list is private because the internal data
        // should only be controlled through the collection's methods.
        private readonly List<T> elements = new List<T>();

        /// <summary>
        /// Gets the number of elements in the collection.
        /// </summary>
        public int Count
        {
            get { return elements.Count; }
        }

        /// <summary>
        /// Adds an element to the collection.
        /// </summary>
        /// <param name="element">The element to add.</param>
        public void Add(T element)
        {
            elements.Add(element);
        }

        /// <summary>
        /// Removes an element from the collection.
        /// </summary>
        /// <param name="element">The element to remove.</param>
        /// <returns>
        /// True if the element was found and removed; otherwise, false.
        /// </returns>
        public bool Remove(T element)
        {
            return elements.Remove(element);
        }

        /// <summary>
        /// Finds the first element that matches the given condition.
        /// </summary>
        /// <param name="predicate">
        /// The condition used to search for an element.
        /// </param>
        /// <returns>
        /// The first matching element, or the default value of T
        /// if no element matches.
        /// </returns>
        public T Find(Func<T, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            foreach (T element in elements)
            {
                if (predicate(element))
                {
                    return element;
                }
            }

            // If there is no match:
            // reference types return null,
            // value types return their default value.
            return default(T);
        }

        /// <summary>
        /// Determines whether the collection contains an element.
        /// </summary>
        /// <param name="element">The element to search for.</param>
        /// <returns>True if the element exists; otherwise, false.</returns>
        public bool Contains(T element)
        {
            return elements.Contains(element);
        }

        /// <summary>
        /// Removes all elements from the collection.
        /// </summary>
        public void Clear()
        {
            elements.Clear();
        }

        /// <summary>
        /// Returns a copy of all elements in the collection.
        /// </summary>
        /// <returns>A new list containing the elements.</returns>
        public List<T> GetAll()
        {
            // We return a copy instead of the internal list.
            // This protects the internal collection from direct modification.
            return new List<T>(elements);
        }
    }
}