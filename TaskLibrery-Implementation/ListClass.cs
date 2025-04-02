using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrery_Implementation
{
    public class ListClass
    {
        public List<int> IdentifyIndex(List<int> nums, int target)
        {
            List<int> result = new List<int>();

            foreach (int i in nums)
            {
                int indexOfnum = nums.IndexOf(i);
                int altNum = target - i;
                if (nums.Contains(altNum))
                {
                    int indexOfAltNum = nums.IndexOf(altNum);
                    result.Add(indexOfnum);
                    result.Add(indexOfAltNum);
                    break;
                }
            }
            return result;

        }

        public bool isPalindrome(int x)
        {
            if (x < 0 && (x % 10 == 0 && x != 0))
                return false;

            int rev = 0;
            int org = x;

            while (org > 0)
            {
                int reminder = org % 10;
                rev = rev * 10 + reminder;
                org = org / 10;
            }

            if (rev == x)
                return true;
            else
                return false;

        }


        public int RomanToInt(string str)
        {
            Dictionary<char, int> romanKVPair = new Dictionary<char, int>()
            {
                { 'I' , 1},
                {'V',5 },
                {'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                {'D', 500 },
                {'M', 1000 }
            };

            //111
            //III = 3
            //XXX = 30
            //XVII = 17

            //-110
            //IX = 9
            //IV = 4
            //-1050
            //XLI = 41

            int result = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if ((i != str.Length - 1) && romanKVPair[str[i]] < romanKVPair[str[i + 1]])
                {
                    result += -romanKVPair[str[i]];
                }
                else
                {
                    result += romanKVPair[str[i]];
                }
            }
            return result;
        }



        //["flower","flow","flight"]

        public string LongestPrefix(string[] strArray)
        {
            string baseStr = strArray[0];

            for (int i = 1; i < strArray.Length; i++)
            {
                while (!strArray[i].StartsWith(baseStr))
                {
                    baseStr = baseStr.Substring(0, baseStr.Length - 1);

                    if (baseStr.Length == 0)
                        return "";
                }

                return baseStr;
            }

            return "";

        }


        //[{()}]

        //[{(})]
        public bool IsValidCharSeq(string str)
        {
            Dictionary<char, char> keyValuePairs = new Dictionary<char, char>
            {
                { ')','('},
                { '}','{'},
                { ']','['}
            };
            Stack<char> chrStck = new Stack<char>();

            foreach (char c in str)
            {
                if (keyValuePairs.ContainsKey(c))
                {
                    if (chrStck.Count == 0 || keyValuePairs[c] != chrStck.Peek())
                        return false;
                    else
                        chrStck.Pop();
                }
                else
                { chrStck.Push(c); }

            }

            return true;
        }




        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode mergedList = new ListNode(-1);

            while (list1 != null && list2 != null)
            {
                if (list1.val > list2.val)
                {
                    mergedList.val = list2.val;
                    list2 = list2.next;
                }
                else
                {
                    mergedList.val = list1.val;
                    list1 = list1.next;
                }
                mergedList = mergedList.next;
            }
            return mergedList;

        }

        public int[] RemoveDuplicateFromArray(int[] inputArray)
        {
            int[] resArray = new int[inputArray.Length];
            int ind = 0;
            foreach (int i in inputArray)
            {
                if (!resArray.Contains(i))
                {
                    resArray[ind] = i;
                    ind++;
                }
            }
            return resArray;
        }


        public int FisrtOccuranceOfString(string needle, string haystack)
        {
            int index = -1;
            if (haystack.Contains(needle))
            {
                index = haystack.IndexOf(needle);
            }
            return index;
        }


        //nums1 = [1,2,3], m = 3, nums2 = [2,5,6], n = 3
        public int[] MergeTwoSortedArray(int[] arr1, int[] arr2)
        {
            int[] resArray = new int[arr1.Length+arr2.Length];

            int i = 0;
            int j= 0;

          

            for(int ind = 0; ind < resArray.Length; ind++)
            {
                if(i>=arr1.Length)
                {
                    resArray[ind] = arr2[j];
                    j++;
                }
                else if(j>=arr2.Length)
                {
                    resArray[ind] = arr1[i];
                    i++;
                }
                else
                {
                    if (arr1[i] > arr2[j])
                    {
                        resArray[ind] = arr2[j];
                        j++;

                    }
                    else
                    {
                        resArray[ind] = arr1[i];
                        i++;
                    }
                }
            }
            return resArray;
        }


    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
