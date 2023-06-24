int[] myArray = { 1, 12, 31, 4, 18, 16, 17, 18 };

int n = myArray.Length;

int find = 18;
int index = 0;

while(index < n)
{
    if(myArray[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}