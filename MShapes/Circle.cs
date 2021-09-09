using System;

namespace MShapes {
    /// <summary>
    /// Implements the Circle item with square calculating
    /// </summary>
    public class Circle : ISquareable {
        /// <summary>
        /// Array of integers whith one item. represents the circle radius.
        /// </summary>
        public int[] Dimensions { get; set; }
        /// <summary>
        /// Initializes a new instance of the Circle class.
        /// </summary>
        /// <param name="dimensions">Array of integers whith one item.</param>
        /// <exception cref="ArgumentException">Thrown when wrong parameters passed to constructor.</exception>
        public Circle(int[] dimensions) {
            if(dimensions.Length != 1) {
                throw new ArgumentException($"Wrong argument parameters {nameof(dimensions)}");
            }
            Dimensions = dimensions;
        }
        /// <summary>
        /// Calculate square of object.
        /// </summary>
        /// <returns>Double square.</returns>
        public double Square() => 3.141592654 * Dimensions[0] * Dimensions[0];
        /// <summary>
        /// Calculate square of object with accuracy is given.
        /// </summary>
        /// <param name="accuracy">Integer accuracy.</param>
        /// <returns>Double square.</returns>
        public double Square(int accuracy) => Math.Round(Square(), accuracy, MidpointRounding.AwayFromZero);
    }
}