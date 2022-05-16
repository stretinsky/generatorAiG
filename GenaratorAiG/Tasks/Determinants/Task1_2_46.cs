using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Task1_2_46
    {
        private int[] permutations { get; set; }
        private int permutNumber { 
            get 
            {
                return GetPermutations(permutations);
            }
        }

        #region Constructor
        public Task1_2_46()
        {
            Random random = new Random();
            permutations = new int[random.Next(6, 11)];
            for (int i = 0; i < permutations.Length; i++)
            {
                permutations[i] = i+1;
            }
            for (int i = permutations.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = permutations[j];
                permutations[j] = permutations[i];
                permutations[i] = temp;
            }
        }
        #endregion

        private int GetPermutations(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j]) counter++;
                }
            }
            return counter;
        }

        public string GetDescription()
        {
            return "Определить число инверсий в перестановках";
        }
        public string GetCondition()
        {
            return string.Join(", ", permutations);
        }
        public string GetAnswer()
        {
            return permutNumber.ToString();
        }
    }
}
