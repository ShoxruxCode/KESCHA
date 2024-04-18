using System;
// Basics.Takrorlash bo’limi uchun 1-amaliy vazifa
// 1-topshiriq
// 1 dan 1000 gacha bo’lgan toq sonlarni yig’indisini ekranga chiqaradigan dastur
// tuzing. While loop dan foydalaning!
int number = 1;
int sum = 0;
while(number <= 1000)
{
    if(number % 2 != 0)
    {
        sum = sum + number;
    }
    number++;
}
Console.WriteLine(sum);

// 2-topshiriq
// Array ichidagi eng katta va eng kichik qiymatlarni ko’paytmasini ekranga
// chiqaradigan dastur tuzing. For loop dan foydalaning!
Console.Write("Array uzunligini kiriting: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Array qiymatlarini kiriting (butun sonda): ");
int[] array = new int[length];
for(int i = 0; i < length; i++)
{
    Console.Write($"array[{i}]=");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int maximumValueOfArray = array[0];
int minimumValueOfArray = array[0];
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > maximumValueOfArray)
    {
        maximumValueOfArray = array[i];
    }
    if(array[i] < minimumValueOfArray)
    {
        minimumValueOfArray = array[i];
    }
}
Console.WriteLine($"Arrayning eng katta va eng kichik qiymatlarining ko'paytmasi: ");
Console.WriteLine($"{maximumValueOfArray} * {minimumValueOfArray} = {maximumValueOfArray * minimumValueOfArray}");
// 3-topshiriq
// Consolga int tipidagi butun son kiritilgan => int x
// x! (x factorial) ni hisoblaydigan dastur tuzing.
Console.Write("Factorial qiymatini bilmoqchi bo'lgan soningizni kiriting (musbat va butun qiymat kiriting): ");
int x = Convert.ToInt32(Console.ReadLine());
if(x < 0)
{
    Console.WriteLine("Siz manfiy qiymat kiritdingiz!");
}
else
{
    long factorial = 1;
    for(int i = 1; i <=x; i++)
    {
        factorial *= i;
    }
    Console.WriteLine($"{x}! = {factorial}");
}