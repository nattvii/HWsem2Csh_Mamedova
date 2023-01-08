// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string Array = Convert.ToString(n);
if (Array.Length > 2){
  Console.WriteLine("Третья цифра = " + Array[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}

