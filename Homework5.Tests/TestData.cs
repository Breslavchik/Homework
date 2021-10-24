using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5.Tests
{
    public class TestData
    {
        public static int[,] GetArrayForFindMinElementOfArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1 }, { 1 } },
                1 => new int[,] { { 1, 3, 4 }, { 5, 0, -8 } },
                _ => new int[,] { { } }
            };
        }

        public static int[,] GetArrayForFindMaxElementOfArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1 }, { 0 } },
                1 => new int[,] { { 0, -3, -4 }, { -5, 0, -8 } },
                2 => new int[,] { { 0, -3, 43 }, { -5, 0, 8 } },
                _ => new int[,] { { } }
            };
        }
        public static int[,] GetArrayForFindIndexOfMinElementOfArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 3, 6 }, { 1, 0, -3 } },
                1 => new int[,] { { 1, 9, 6 }, { -5, 1, -3 } },
                _ => new int[,] { { } },
            };
        }
        public static int[] GetExpectedArrayForFindIndexOfMinElementOfArrayTest(int index)
        {
            return index switch
            {
                0 => new int[] { 1, 2 },
                1 => new int[] { 1, 0 },
                _ => new int[] {  },
            };
        }
        public static int[] GetExpectedArrayForFindIndexOfMaxElementOfArrayTest(int index)
        {
            return index switch
            {
                0 => new int[] { 0, 2 },
                1 => new int[] { 0, 1 },
                _ => new int[] { },
            };
        }
        public static int[,] GetArrayForCountElementsThatAreBiggerThanNeighborsTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 11, 3, 6 }, { 1, 0, -3 } },
                1 => new int[,] { { 1, 9, 6 }, { -5, 1, -3 } },
                _ => new int[,] { { } },
            };
        }

        public static int[,] GetArrayForDiagonalMirrowArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 11, 1, 5 }, { 3, 0, 78 },{6,-3, 4 } },
                1 => new int[,] { { 1, 9 }, { -5, 1 } },
                2 => new int[,] { { 11, 1,5,1 }, { 3,0,78,0}, {6,-3,4,1  }, {5,23,70,0} },
                _ => new int[,] { { } },
            };
        }

        public static int[,] GetExpectedArrayForDiagonalMirrowArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 11, 3, 6 }, { 1, 0, -3 }, { 5, 78, 4} },
                1 => new int[,] { { 1, -5 }, { 9, 1 } },
                2 => new int[,] { { 11, 3, 6, 5}, { 1, 0, -3, 23 }, { 5, 78, 4, 70 }, {1, 0, 1, 0 } },
                _ => new int[,] { { } },
            };
        }
    }
}
