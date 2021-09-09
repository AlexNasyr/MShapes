using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MShapes {
    /// <summary>
    /// Implements the Triangle item with square calculating
    /// </summary>
    public class Triangle : ISquareable {
        /// <summary>
        /// Array of integers whith three items. represents the triangle's sides lenghth.
        /// </summary>
        public int[] Dimensions { get; set; }
        /// <summary>
        /// Initializes a new instance of the Triangle class.
        /// </summary>
        /// <param name="dimensions">Array of integers with three item.</param>
        /// <exception cref="ArgumentException">Thrown when wrong parameters passed to constructor or triangle whith given sides is not possible.</exception>
        public Triangle(int[] dimensions) {
            if(dimensions.Length != 3) {
                throw new ArgumentException($"Wrong argument parameters {nameof(dimensions)}");
            }
            if(!isExists(dimensions)) {
                throw new ArgumentException($"This triangle are not possible.");
            }
            Dimensions = dimensions;
        }
        /// <summary>
        /// Calculate square of object.
        /// </summary>
        /// <returns>Double square.</returns>
        public double Square() {
            double halfPerimeter = 0.5 * (Dimensions[0] + Dimensions[1] + Dimensions[2]);
            double square =  Math.Sqrt(halfPerimeter * (halfPerimeter - Dimensions[0]) * (halfPerimeter - Dimensions[1]) * (halfPerimeter - Dimensions[2]));
            return square;
        }
        public double Square(int accuracy) => Math.Round(Square(), accuracy);
        /// <summary>
        /// Calculate square of object with accuracy is given.
        /// </summary>
        /// <param name="accuracy">Integer accuracy.</param>
        /// <returns>Double square.</returns>
        private bool isExists(int[] dimensions) {
            var dimCounts = (from dim in dimensions group dim by dim into dimGroupes select dimGroupes.Sum()).ToArray();
            if(dimCounts.Length == 2 && dimCounts[0] == dimCounts[1]) { return false; }
            return true;
        }

        public bool isTriangleRight() {
            Array.Sort(Dimensions);
            return (Dimensions[0] * Dimensions[0]) + (Dimensions[1] * Dimensions[1]) == Dimensions[2] * Dimensions[2] ? true : false;
        }
    }
}
