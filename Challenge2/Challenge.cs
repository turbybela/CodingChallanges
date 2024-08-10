using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Challenge2
{
    internal class Challenge
    {
        /// <summary>
        ///     Returns a direction based on the given Key input, valid inputs are 'WASD' and the arrow keys, 
        ///         and they correspond to the Point class's Up,Down,Left,Right members. Other point values are illegal.
        /// </summary>
        /// <param name="key"> ConsoleKey struct, has the keycode members for example ConsoleKey.UpArrow or ConsoleKey.W for those keys. </param>
        /// <returns> Returns a Direction from the Point class, or null in case an invalid key is given. </returns>
        public static Point? Challenge1(ConsoleKey key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Return a random point inside the box.
        /// </summary>
        /// <param name="maxX"> Width of the box. </param>
        /// <param name="maxY"> Height of the box. </param>
        static readonly Random r = new Random();
        public static Point Challenge2(int width, int height)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Shift the reference array to the right (Front to back) by one, The first element of the array should get the value of the "first" parameter, 
        ///         and then return the unmodified value of the last element of the array.
        /// </summary>
        /// <param name="array"> Reference array, contains list of points. Array can be null or empty</param>
        /// <param name="first"> Point to set the first element to. </param>
        /// <returns> Last element of array, in the state it was originally. The array's modifications are also returned due to the reference status. In case array is null or empty, return first. </returns>
        public static Point Challenge3(ref List<Point> array, Point first)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Make sure the given point is inside the bounds of the box.
        ///     If the point is outside the box in any direction, move it back into the box by making it appear on the other side like its looping.
        /// </summary>
        /// <param name="point"> Point to contain. Expect correct value. </param>
        /// <param name="width"> Width of the box. Expect correct value. </param>
        /// <param name="height"> Height of the box. </param>
        /// <returns> New position of the point. Should be unmodified if the point is already in the box. </returns>
        public static Point Challenge4(Point point, int width, int height)
        {
            throw new NotImplementedException();
        }
    }
}
