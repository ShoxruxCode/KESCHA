// Basics.Takrorlash bo'limi uchun 2-amaliy vazifa
// Vazifa menejeri:
// Vazifalarni boshqarish uchun dastur yozing. Foydalanuvchi vazifalarni qo'shishi, o'chirishi va
// bajarilganligini belgilashi kerak. Dastur vazifalar ro'yxatini va ularning holatini saqlashi kerak.
// For loop, While loop yoki Forech-dan foydalaning, va Array yoki List-dan foydalaning.

using System;

Console.Write("Vazifangizning sonini kiriting: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = new string[length];

for (int i = 0; i < length; i++)
{
    bool isInputValid = false;
    do
    {
        Console.Write($"{i + 1}-vazifa: ");
        string inputArray = Console.ReadLine();
        if(!string.IsNullOrEmpty(inputArray))
        {
            array[i] = inputArray;
            isInputValid = true;
        }
        else
        {
            Console.WriteLine("Siz vazifa kiritmadingiz. Iltimos, qayta urinib ko'ring.");
        }
    } while(!isInputValid);
}
Console.WriteLine();
string[] newArray = new string[array.Length];
int newArrayIndex = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{i + 1}-vazifa: {array[i]} - vazifasini o'chirmoqchimisiz? ikkala so'zdan birini yozing - (ha) yoki (yo'q): ");
    string checkDeleteElement = Console.ReadLine().ToLower();

    if (checkDeleteElement == "ha")
    {
        Console.Write("O'chirmoqchi bo'lgan vazifangizning tartib raqamini kiriting: ");
        int indexToRemove = Convert.ToInt32(Console.ReadLine()) - 1;

        if (indexToRemove >= 0 && indexToRemove < array.Length)
        {
            if (array[indexToRemove] != array[i])
            {
                continue;
            }
            Console.WriteLine($"{i + 1} - vazifa: {array[i]} - o'chirildi \n");
        }
        else
        {
            Console.WriteLine("Kiritilgan tartib raqam noto'g'ri! \n");
        }
    }
    else if (checkDeleteElement == "yo'q")
    {
        Console.WriteLine($"{i + 1} - vazifa: {array[i]} - o'chirilmadi \n");
        newArray[newArrayIndex] = array[i];
        newArrayIndex++;
    }
    else
    {
        Console.WriteLine("Noto'g'ri javob! \n");
    }
}

string vazifaniAniqlash;

for(int j = 0; j < newArray.Length; j++)
{
    if(string.IsNullOrWhiteSpace(newArray[j]))
    {
        continue;
    }
    else
    {
        Console.Write($"{j+1} - vazifa: {newArray[j]} - vazifasini bajardingizmi ? ikkala so'zdan birini yozing - (ha) yoki (yo'q) : ");
        vazifaniAniqlash = Console.ReadLine();
        if(vazifaniAniqlash == "ha")
        {
            Console.WriteLine($"{j+1} - vazifa: {newArray[j]}-vazifasi bajarildi \n");
        }
        if(vazifaniAniqlash == "yo'q")
        {
            Console.WriteLine($"{j+1} - vazifa: {newArray[j]}-vazifasi bajarilmadi \n");
        }
        if(vazifaniAniqlash != "ha" && vazifaniAniqlash != "yo'q")
        {
            Console.WriteLine("Siz noto'g'ri so'z yozdingiz \n");
        }
    }
}

Console.WriteLine();

// Bajarilganlikka tekshirildi va ma'lumotlar saqlandi

for(int i = 0; i < newArray.Length; i++)
{
    if(string.IsNullOrEmpty(newArray[i]))
    {
        Console.WriteLine($"{i+1}-vazifa o'chirilgan \n");
        continue;
    }
    else
    {
        Console.WriteLine($"{i+1}-vazifa bajarilganlikka tekshirildi va ma'lumotlar saqlandi \n");
    }
}

// Dastur ro'yxati

Console.WriteLine("Dasturda vazifalarning yangi ro'yxati chiqarildi va saqlandi \n");
for (int j = 0; j < newArray.Length; j++)
{
    if(string.IsNullOrWhiteSpace(newArray[j]))
    {
        continue;
    }
    else
    {
        Console.WriteLine($"{j+1} - vazifa: {newArray[j]} \n");
    }
}

// Dasturda vazifalarning yangi ro'yxati chiqarildi va saqlandi

// Xulosa:
// Bu dasturni Listdan foydalanib tayyor metodlarini qo'llab (Add, Remove) vazifalarni qo'shish, o'chirish
// mumkin. Lekin men vazifalarni qo'shish, o'chirish, bajarilganlikka
// tekshirish kabi jarayonlarni algoritmlash yordamida tuzdim.