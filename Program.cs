//Task_2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/* Console.Write("Your num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Your num2 : ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (max < num2) {
    max = num2;
}
Console.Write($"num1 = {num1}; num2 = {num2} -> max = {max}"); */

//Task_4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/* Console.Write("Your num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Your num2 : ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Your num3 : ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (max < num2) max = num2;

if (max < num3) max = num3;

Console.WriteLine($"num1 = {num1}; num2 = {num2}; num3 = {num3} -> max = {max}"); */ 

//Task_4.1 захотелось попробовать написать циклом, чтобы код сократить, хоть и сократила всего на 1 строчку
//и прошлось порыскать в интернете чтобы все заработало функцию int.MinValue
//и смириться с тем, что этот массив работает здесь только с 0, хотя я наверное что-то недопоняла
//и мне очень интересно почему он неправильно считает если я вместо i=0 поставилю i=1
/*
int i=0;
int[] a = new int[3];
int max = int.MinValue;
while(i<3) {
    Console.Write($"Your num{i+1}: ");
    a[i] = Convert.ToInt32(Console.ReadLine());
    if (max < a[i]) max = a[i];

    i++;
}
Console.Write($"num1 = {a[0]}; num2 = {a[1]}; num3 = {a[2]} -> max = {max}");
*/

//Task_6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/* Console.Write("Your num: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 ==0) 
    Console.Write($"{num} -> Yes!");
else
    Console.Write($"{num} -> Nope!"); */

//Task_8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/* Console.Write("Your num : ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 0; //or 1

while (current <= num) {
    if (current % 2 == 0)
    Console.Write(current + " ");
    current ++;
} */
