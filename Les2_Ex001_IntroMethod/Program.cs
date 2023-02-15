// Поищем максимум из N чисел

int a1 = 24;
int b1 = 234;
int c1 = 76;
int a2 = 56;
int b2 = 876;
int c2 = 567;
int a3 = 946;
int b3 = 23;
int c3 = 1;
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}
int max1 = Max(a1,b1,c1);
Console.WriteLine(max1);
int max2 = Max(a2,b2,c2);
Console.WriteLine(max2);
int max3 = Max(a3,b3,c3);
Console.WriteLine(max3);
int max = Max(max1,max2,max3);
Console.WriteLine(max);