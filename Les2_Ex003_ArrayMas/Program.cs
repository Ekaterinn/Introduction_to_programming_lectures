// Имеется одновременный массив array из n элементов, требуется найти элемент массива, равный find.


void fillarray (int[] gold)
{
    int Length = gold.Length;
    int index = 0;
    while(index<Length)
    {
        gold[index] = new Random().Next(1,100);
        // Console.WriteLine(gold[index]);
        index = index + 1;
    }
}
void printarray(int [] silver)
{
    int count = silver.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(silver[position]);
        position = position+1;
    }
}
int[] Cat = new int[10];
fillarray(Cat);
printarray(Cat);
// Console.WriteLine(Cat[3]);