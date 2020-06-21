using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_2 {
    public static class SortingUtilities {
        public static bool More(int number1, int number2) {
            return number1 > number2;
        }
        public static bool LesserThan(int number1, int number2) {
            return number1 < number2;
        }
        public static void Swap(int[] data, int firstIndex, int secondIndex) {
            int temporaryNumber = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = temporaryNumber;
        }
    }
}
