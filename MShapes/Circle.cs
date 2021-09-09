using System;

namespace MShapes {
    public class Circle : ISquareable {
        /// <summary>
        /// Implements the Circle item with square calculating
        /// </summary>
        /// <param name="dimensions">ineger array from one item. represents the circle radius.</param>
        /// <returns>
        /// function "Square" returns double value. represents the objects square.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown when wrong parameters passed to constructor.</exception>
        public int[] Dimensions { get; set; }
        public Circle(int[] dimensions) {
            if(dimensions.Length != 1) {
                throw new ArgumentException($"wrong argument parameters {nameof(dimensions)}");
            }
            Dimensions = dimensions;
        }
        public double Square() => 3.14 * Dimensions[0] * Dimensions[0];
    }
}
