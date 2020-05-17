using System.Linq;


namespace Practica_1
{
    public class ArrayMerger
    {
        public int[] Arr1 { get; private set; }
        public int[] Arr2 { get; private set; }

        public ArrayMerger(int[] arr1, int[] arr2)
        {
            this.Arr1 = (int[])arr1.Clone();
            this.Arr2 = (int[])arr2.Clone();
        }

        public void Start()
        {
            PrintResult(Merge());
        }

        int[] Merge()
        {
            int length1 = Arr1.Count();
            int length2 = Arr2.Count();
            int[] result = new int[length1 + length2];

            int i = 0;
            int j = 0;

            for (int k = 0; k < length1 + length2; k++)
            {
                if(i == length1)
                    result[k] = Arr2[j++];
                else if(j == length2)
                    result[k] = Arr1[i++];
                else
                    result[k] = Arr1[i] < Arr2[j] ? Arr1[i++] : Arr2[j++];
            }

            return result;
        }

        void PrintResult(int[] result)
        {
            foreach (var num in result)
            {
                System.Console.Write(num + " ");
            }
        }
    }
}