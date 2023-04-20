Console.WriteLine("Размер массива a x b и диапазон значений:");
int a = InputNumbers("a: ");
int b = InputNumbers("b: ");
int range = InputNumbers("Диапазон: от 1 до: ");
int[,] array = new int[a, b];
CreateArray(array);
WriteArray(array);
Console.WriteLine("Массив с сортировкой: ");
OrderArrayLines(array);
WriteArray(array);
void OrderArrayLines(int[,] array) {
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}
int InputNumbers(string input) {
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}
void WriteArray(int[,] array) {
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}