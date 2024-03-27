using System;

Console.WriteLine("1-vazifa boshlandi");
// 1-vazifa sharti :
// 1. Kalkulyator:
// Foydalanuvchidan ikkita raqam va operatsiyani (+, -, *, /) so'raydigan kalkulyator dasturini yozing va keyin operatsiya natijasini chop eting.
// Input = 5;
// Input = +;
// Input = 5;
// Output = 10;

// Dastur kodi :
Console.Write("1-raqamni kiriting : ");
int birinchiRaqam = Convert.ToInt32(Console.ReadLine());
Console.Write("operatsiyani (+, -, *, /) kiriting : ");
string oparation = Console.ReadLine();
Console.Write("2-raqamni kiriting : ");
int ikkiinchiRaqam = Convert.ToInt32(Console.ReadLine());
int result = 0;
switch (oparation) {
            case "+":
                result = birinchiRaqam + ikkiinchiRaqam;
                break;
            case "-":
                result = birinchiRaqam - ikkiinchiRaqam;
                break;
            case "*":
                result = birinchiRaqam * ikkiinchiRaqam;;
                break;
            case "/":
                if (ikkiinchiRaqam != 0)
                    result = birinchiRaqam / ikkiinchiRaqam;
                else
                    Console.WriteLine("Nolga bo'lib bo'lmaydi.");
                break;
            default:
                Console.WriteLine("Noto'g'ri operatsiya kiritildi.");
                break;
        }
Console.WriteLine(result);
Console.WriteLine("1-vazifa yakunlandi");
// Dastur yakunlandi
Console.WriteLine("2-vazifa boshlandi");
// 2-vazifa sharti :
// 2. Raqamlar qatorining yig‘indisini hisoblash:
// Foydalanuvchidan N musbat butun sonni so‘ragan, so‘ngra 1 dan N gacha bo‘lgan barcha sonlar yig‘indisini hisoblab, natijani ekranga chiqaradigan dastur tuzing.
// Input = 10;
// Output = 55;


// Dastur kodi :
Console.Write("N-raqamni kiriting : ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for(int i = 1; i<=N; i++){
    sum = sum + i;
}
Console.WriteLine($"1 dan N gacha bo'lgan barcha sonlar yig'indisi : {sum}");
// Dastur yakunlandi
Console.WriteLine("3-vazifa boshlandi");
// 3-vazifa sharti :
// 3.  Paritet tekshiruvi:
// Foydalanuvchi kiritgan raqamning juft yoki toq ekanligini aniqlaydigan va shunga mos ravishda xabarni chiqaradigan dastur tuzing.
// Input = 3;
// Output = “Toq”

// Dastur kodi :
Console.Write("Raqam kiriting : ");
int number = Convert.ToInt32(Console.ReadLine());
if(number%2 == 0){
    Console.WriteLine("Bu raqam juft");
} else {
    Console.WriteLine("Bu raqam toq");
}

Console.WriteLine("3-vazifa yakunlandi");
// Dastur yakunlandi