// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using TaskLibrery_Implementation;

//TaskImplemenation taskImplemenation = new TaskImplemenation();
//taskImplemenation.CallMethod();


ArrayClass  a = new ArrayClass();


int[] param2 = { 3, 2, 4 };
int[] param3 = { 2, 7, 11, 15 };
int[] param4 = { 2, 7, 11, 15 };



int[] param1 = { 2, 7, 11, 15 };
int[] res0 = a.IdentifyIndex1(param3, 9);
int[] res = a.IdentifyIndex1(param3, 13);
int[] res1 = a.IdentifyIndex1(param3, 18);
int[] res2 = a.IdentifyIndex1(param3, 17);
int[] res3 = a.IdentifyIndex1(param3, 35);


Console.ReadLine();

