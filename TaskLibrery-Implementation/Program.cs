// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using TaskLibrery_Implementation;

//TaskImplemenation taskImplemenation = new TaskImplemenation();
//await taskImplemenation.CallMethod();












/////////////////////////////////////////////////////////
ArrayClass  a = new ArrayClass();
ListClass listClass = new ListClass();


int[] param2 = { 2, 2, 6 };
int[] param3 = { 3, 5, 8, 9 };
int[] param4 = { 2, 7, 11, 15,17,15,2 };



//int[] param1 = { 2, 7, 11, 15 };
//int[] res0 = a.IdentifyIndex1(param3, 9);
//int[] res = a.IdentifyIndex1(param3, 13);
//int[] res1 = a.IdentifyIndex1(param3, 18);
//int[] res2 = a.IdentifyIndex1(param3, 17);
//int[] res3 = a.IdentifyIndex1(param3, 35);



//List<int> listParam = new List<int>() { 2, 7, 11, 15 };

//List<int> listRes = listClass.IdentifyIndex(listParam, 26);

//int[] ints = listClass.TwoSum(param3, 13);

string match = listClass.LongestPrefix(new string[] { "flower", "flow", "flight" });

//bool resbool = listClass.isPalindrome(121);

//int res1 = listClass.RomanToInt("MCMXCIV");

//bool res2 = listClass.IsValidCharSeq("[{(})]");

//int[] res3 = listClass.RemoveDuplicateFromArray(param4);

//int res4 = listClass.FisrtOccuranceOfString("as", "sadbutsad");

//int[] res5 = listClass.MergeTwoSortedArray(param2, param3);

//int res6 = listClass.LengthOfLastWord("   fly me   to   the moon  ");
LinkedList<int> list = new LinkedList<int>();
LinkedListNode<int> ints1 = new LinkedListNode<int>(1);
LinkedListNode<int> ints2 = new LinkedListNode<int>(1);
LinkedListNode<int> ints3 = new LinkedListNode<int>(2);
list.AddFirst(ints1);
list.AddFirst(ints2);
list.AddFirst(ints3);




////// Calling ASP.NET Core Web api using HttpClient 
//using (var client = new HttpClient())
//{
//    client.BaseAddress = new Uri("https://localhost:7279/api/");
//    var response = await client.GetAsync("FileApi");

//    if(response != null && response.IsSuccessStatusCode)
//    {
//        var result = response.Content.ReadAsStringAsync().Result;
//        Console.WriteLine(result);
//    }

//}


Console.ReadLine();

