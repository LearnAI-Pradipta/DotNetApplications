using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrery_Implementation
{
    public class ArrayClass
    {
        public int[] IdentifyIndex(int[] nums, int target)
        {
            int initialIndex = 0;
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == initialIndex) continue;

                int sum = nums[initialIndex] + nums[i];

                if (sum == target)
                {
                    result[0] = initialIndex;
                    result[1] = i;
                    break;
                }

            }
            initialIndex++;
            return result;
        }


        public int[] IdentifyIndex1(int[] nums, int target)
        {            
            int altNumIndex;
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int altNum = target - nums[i];
                if(Array.IndexOf(nums, altNum) != i)
                {
                    if (nums.Contains(altNum))
                    {
                        altNumIndex = Array.IndexOf(nums, altNum);
                        result[0] = i;
                        result[1] = altNumIndex;
                        break;
                    }
                }                
            }
            return result;
        }
    }
}
