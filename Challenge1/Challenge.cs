using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodingChallenge
{
    public static class Challenge
    {

        /// <summary>
        ///     Reads a text file given by parameter line by line and returns an array containing every line.
        /// </summary>
        /// <param name="path">
        ///     Path to file to read.
        /// </param>
        /// <returns>
        ///     Array containing every line in the given file.
        /// </returns>
        public static string[] Challenge1(string path)
        {
            return null;
        }


        /// <summary>
        ///     Returns a random element from the array parameter.
        /// </summary>
        /// <param name="array">
        ///     An array of string. Can be empty or null.
        /// </param>
        /// <returns>
        ///     Returns a random element from the array,
        ///      or null in case array is empty or null. 
        /// </returns>
        static Random r = new Random();
        public static string Challenge2(string[] array)
        {
            return null;
        }


        /// <summary>
        ///     Validate the input string based on these criteria:
        ///         - Input word should have a length of 5.
        ///         - Input word is in Valid Inputs array
        /// </summary>
        /// <param name="input">
        ///     Input string. Can be null.
        /// </param>
        /// <param name="validInputs">
        ///     Valid Inputs array. Can be null.
        /// </param>
        /// <returns>
        ///     Returns InputValidation enum if:
        ///         - If all criteria are correct, returns "Correct".
        ///         - If word length is wrong, returns "InvalidLength".
        ///         - If word is not in valid array, returns "NonExistent".
        ///     If any of the parameters are null return null.
        /// </returns>
        public static InputValidation? Challenge3(string input, string[] validInputs)
        {
            return null;
        }

        /// <summary>
        ///     Checks if a character in a given position matches up with the given string.
        ///         - Checks if the character is in the same position based on the given index as the string.
        ///         - Checks if the character is even part of the string.
        /// </summary>
        /// <param name="chr">
        ///     Input character. Its position in the string is based on the index.
        /// </param>
        /// <param name="index">
        ///     Gives the position of the character in the string.
        /// </param>
        /// <param name="str">
        ///     String that the character is checked against. Can be null.
        /// </param>
        /// <returns>
        ///     Returns a CharacterPosition enum.
        ///         - If the character is contained by the string and it is at the same position as in the string,
        ///             return "Correct"
        ///         - If the character is contained by the string but it is not at the same position as the one in the string,
        ///             return "Misplaced"
        ///         - If the character is not in the string, then return "Wrong".
        ///     If the string is null, or the index is out of range return null.
        /// </returns>
        public static CharacterPosition? Challenge4(char chr, int index, string str)
        {
            return null;
        }
    }
}