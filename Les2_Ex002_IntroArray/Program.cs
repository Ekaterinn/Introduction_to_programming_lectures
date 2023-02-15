// Поищем максимум из N чисел

// int a1 = 24;
// int b1 = 234;
// int c1 = 76;
// int a2 = 56;
// int b2 = 876;
// int c2 = 567;
// int a3 = 946;
// int b3 = 23;
// int c3 = 1;
// int Max(int arg1, int arg2)
// {
//     int result = arg1;
//     if(arg2>result) result = arg2;
//     return result;
// }
// int max1 = Max(a1,b1);
// Console.WriteLine(max1);
// int max2 = Max(c1,a2);
// Console.WriteLine(max2);
// int max3 = Max(b2,c2);
// Console.WriteLine(max3);
// int max4 = Max(a3,b3);
// Console.WriteLine(max4);
// int max5 = c3;
// Console.WriteLine(max5);
// int max11 = Max(max1,max2);
// int max12 = Max(max3,max4);
// int max21 = Max(max11, max12);
// int max = Max(max21, max5);
// Console.WriteLine(max);

// // Поищем максимум из N чисел

// int a1 = 24;
// int b1 = 234;
// int c1 = 7556;
// int a2 = 56;
// int b2 = 876;
// int c2 = 567;
// int a3 = 946;
// int b3 = 23;
// int c3 = 1;
// int Fun(int arg1, int arg2, int arg3, int arg4)
// {
//     int result = arg1;
//     if(arg2>result) result = arg2;
//     if(arg3>result) result = arg3;
//     if(arg4>result) result = arg4;
//     return result;
// }
// int max1 = Fun(a1,b1,c1,a2);
// Console.WriteLine(max1);
// int max2 = Fun(b2,c2,a3,b3);
// Console.WriteLine(max2);
// int max3 = c3;
// Console.WriteLine(max3);
// int max4 = 0;
// int max = Fun(max1, max2, max3, max4);
// Console.WriteLine(max);

// Поищем максимум из N чисел


int[] array = {23,56,43,7,89,9,54,90,6};
int n = array.Length;
Console.WriteLine(n);
int find = 54;
int index = 0;
while (index<n)
{
    // Console.WriteLine(index);
   if (array[index]==find)
   {
    Console.WriteLine(array[index]);
    break;
   }
    index = index + 1; 
   Console.WriteLine(index);
}

