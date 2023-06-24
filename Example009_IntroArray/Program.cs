int myMax(int arg1, int arg2, int arg3) // Функция или метод
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] myArray = { 11, 21, 31, 4, 5, 61, 17, 18, 19 };
myArray[0] = 12;
// Console.WriteLine(myArray[0]);

int max = myMax(
    myMax(myArray[0], myArray[1], myArray[2]),
    myMax(myArray[3], myArray[4], myArray[5]),
    myMax(myArray[6], myArray[7], myArray[8])
);
Console.WriteLine(max);


