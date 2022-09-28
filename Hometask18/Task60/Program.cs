// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] CreateTripleArray (int a, int b, int c)
{
    int [] arrayNumbers = new int [a * b * c];
    int [,,] tripleArray = new int [a, b, c];
    int count = 0;
    for (int i = 0; i < tripleArray.GetLength(0); i++)
    {
        for (int j = 0; j < tripleArray.GetLength(1); j++)
        {
            for (int k = 0; k < tripleArray.GetLength(2); k++)
            {
                int randomNumber = new Random().Next(10, 100);
                int num = 0;
                while (num < arrayNumbers.Length)
                {
                    if (randomNumber == arrayNumbers[num])
                    {
                        num = 0;
                        randomNumber = new Random().Next(10, 100);
                    }
                    else
                    {
                        num++;
                    }
                }
                arrayNumbers[count] = randomNumber;
                tripleArray[i, j, k] = randomNumber;
                count += 1;
            }
        }
    }
    return tripleArray;
}

void PrintTripleArray (int [,,] tripleArray)
{
    for (int i = 0; i < tripleArray.GetLength(0); i++)
    {
        for (int j = 0; j < tripleArray.GetLength(1); j++)
        {
            for (int k = 0; k < tripleArray.GetLength(2); k++)
            {
                Console.Write($"  {tripleArray[i, j, k]}({i}, {j}, {k})");
            }
            Console.WriteLine();
        }
    }
}

int [,,] tripleArray = CreateTripleArray(2, 2, 2);
PrintTripleArray(tripleArray);