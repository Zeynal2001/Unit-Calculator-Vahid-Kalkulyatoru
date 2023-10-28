Console.OutputEncoding = System.Text.Encoding.UTF8;

while (true)
{
    // İstifadəçiyə giriş və seçim mesajı verilir
    Console.WriteLine("Xoş gəlmisiniz!");
    Console.WriteLine("Zəhmət olmasa aşağıdakı seçimlərdən birini edin:");
    Console.WriteLine("1. Santimetr -> Metr");
    Console.WriteLine("2. Metr -> Santimetr");
    Console.WriteLine("3. Santimetr -> Millimetr");
    Console.WriteLine("4. Celsius -> Fahrenheit");
    Console.WriteLine("5. Fahrenheit -> Celsius");
    Console.WriteLine("6. Kiloqram -> Ton");
    Console.WriteLine("7. Ton -> Kiloqram");
    Console.WriteLine("8. Çıxış");

    int secim; // Burada istifadəçinin seçimini saxlayacağıq

    try
    {
        // İstifadəçinin seçimini daxil etməsi gözlənilir
        // Və edilən seçim dəyəri integer-ə çevrilərək "secim" dəyişənində saxlanılır
        secim = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        // FormatException halında xəta mesajı verilir və dövr davam edir
        Console.WriteLine("Xahiş edirik düzgün bir seçim edin.");
        continue;
    }

    try
    {
        // İstifadəçinin seçimini əsasında müvafiq funksiyaya yönəldirik
        switch (secim)
        {
            case 1:
                ConvertCmToMeters();
                break;
            case 2:
                ConvertMetersToCm();
                break;
            case 3:
                ConvertCmToMm();
                break;
            case 4:
                ConvertCelsiusToFahrenheit();
                break;
            case 5:
                ConvertFahrenheitToCelsius();
                break;
            case 6:
                ConvertKqToTon();
                break;
            case 7:
                ConvertTonToKq();
                break;
            case 8:
                // Proqramdan çıxış etmək üçün "return" istifadə edirik
                Console.WriteLine("Program bağlandı.");
                return;
            default:
                // Yanlış seçim üçün xəta mesajı göstəririk
                Console.WriteLine("Yanlış seçim! Xahiş edirik düzgün seçim edin.");
                break;
        }
    }
    catch (Exception ex)
    {
        // Başqa bir xəta baş verərsə xəta mesajı verilir
        Console.WriteLine("Xəta baş verdi: " + ex.Message);
    }
    finally
    {
        // Əməliyyat tamamlandı mesajı verilir
        Console.WriteLine("Əməliyyat tamamlandı.");
    }

    // İstifadəçiyə davam etmək istəyib-istəmədiyi soruşulur
    Console.WriteLine("Başqa əməliyyat etmək istəyirsiz? (B/Bəli, X/Xeyr)");
    string davamEt = Console.ReadLine();
    if (davamEt.ToLower() != "b")
    {
        break;
    }
}

// Əməliyyat funksiyalarını təyin etməyə başlayırıq:
void ConvertCmToMeters()
{
    // Santimetr dəyərini daxil etməsi istənilir
    Console.WriteLine("Santimetr dəyərini daxil edin: ");
    double cm;

    try
    {
        // İstifadəçinin daxil etdiyi dəyəri double tipinə çevirir
        cm = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        // FormatException halında xəta mesajı verilir və funksiya sonlandırılır
        Console.WriteLine("Xahiş edirik düzgün bir rəqəm daxil edin.");
        return;
    }

    if (cm < 0)
    {
        // Əgər daxil edilən dəyər negativdirsə, xəta mesajı göstəririk
        throw new Exception("Santimetr dəyəri negativ ola bilməz!");
    }

    // Santimetr dəyərini metrə çevirir və nəticəni konsolda göstərir
    double meters = cm / 100.0;
    Console.WriteLine("Nəticə: " + meters + " metr");
}

void ConvertMetersToCm()
{
    // Metr dəyərini daxil etməsi istənilir
    Console.Write("Metr dəyərini daxil edin: ");
    double meters;

    try
    {
        // İstifadəçinin daxil etdiyi dəyəri double tipinə çevirir
        meters = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        // FormatException halında xəta mesajı verilir və funksiya sonlandırılır
        Console.WriteLine("Xahiş edirik düzgün bir rəqəm daxil edin.");
        return;
    }

    if (meters < 0)
    {
        // Əgər daxil edilən dəyər negativdirsə, xəta mesajı göstəririk
        throw new Exception("Metr dəyəri negativ ola bilməz!");
    }

    // Metr dəyərini santimetrə çevirir və nəticəni konsolda göstərir
    double cm = meters * 100;
    Console.WriteLine("Nəticə: " + cm + " santimetr");
}

void ConvertCmToMm()
{
    // Santimetr dəyərini daxil etməsi istənilir
    Console.Write("Santimetr dəyərini daxil edin: ");
    double cm;

    try
    {
        // İstifadəçinin daxil etdiyi dəyəri double tipinə çevirir
        cm = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        // FormatException halında xəta mesajı verilir və funksiya sonlandırılır
        Console.WriteLine("Xahiş edirik düzgün bir rəqəm daxil edin.");
        return;
    }

    if (cm < 0)
    {
        // Əgər daxil edilən dəyər negativdirsə, xəta mesajı göstəririk
        throw new Exception("Santimetr dəyəri negativ ola bilməz!");
    }

    // Santimetr dəyərini millimetrə çevirir və nəticəni konsolda göstərir
    double mm = cm * 10;
    Console.WriteLine("Nəticə: " + mm + " millimetr");
}

void ConvertCelsiusToFahrenheit()
{
    // Celsius dəyərini daxil etməsi istənilir
    Console.Write("Celsius dəyərini daxil edin: ");
    double celsius;

    try
    {
        // İstifadəçinin daxil etdiyi dəyəri double tipinə çevirir
        celsius = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        // FormatException halında xəta mesajı verilir və funksiya sonlandırılır
        Console.WriteLine("Xahiş edirik düzgün bir rəqəm daxil edin.");
        return;
    }

    // Celsius dəyərini Fahrenheit-ə çevirir və nəticəni konsolda göstərir
    double fahrenheit = (celsius * 9 / 5) + 32;
    Console.WriteLine("Nəticə: " + fahrenheit + " Fahrenheit");
}

void ConvertFahrenheitToCelsius()
{
    // Fahrenheit dəyərini daxil etməsi istənilir
    Console.Write("Fahrenheit dəyərini daxil edin: ");
    double fahrenheit;

    try
    {
        // İstifadəçinin daxil etdiyi dəyəri double tipinə çevirir
        fahrenheit = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        // FormatException halında xəta mesajı verilir və funksiya sonlandırılır
        Console.WriteLine("Xahiş edirik düzgün bir rəqəm daxil edin.");
        return;
    }

    // Fahrenheit dəyərini Celsius-a çevirir və nəticəni konsolda göstərir
    double celsius = (fahrenheit - 32) * 5 / 9;
    Console.WriteLine("Nəticə: " + celsius + " Celsius");
}

void ConvertKqToTon()
{
    // Kiloqram dəyərini daxil etməsi istənilir
    Console.Write("Kiloqram dəyərini daxil edin: ");
    double kq;

    try
    {
        // İstifadəçinin daxil etdiyi dəyəri double tipinə çevirir
        kq = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        // FormatException halında xəta mesajı verilir və funksiya sonlandırılır
        Console.WriteLine("Xahiş edirik düzgün bir rəqəm daxil edin.");
        return;
    }

    if (kq < 0)
    {
        // Əgər daxil edilən dəyər negativdirsə, xəta mesajı göstəririk
        throw new Exception("Kiloqram dəyəri negativ ola bilməz!");
    }

    // Kiloqramı tona çevirir və nəticəni konsolda göstərir
    double ton = kq / 1000.0; // 1 ton = 1000 kiloqram
    Console.WriteLine("Nəticə: " + ton + " ton");
}

void ConvertTonToKq()
{
    // Ton dəyərini daxil etməsi istənilir
    Console.Write("Ton dəyərini daxil edin: ");
    double ton;

    try
    {
        // İstifadəçinin daxil etdiyi dəyəri double tipinə çevirir
        ton = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        // FormatException halında xəta mesajı verilir və funksiya sonlandırılır
        Console.WriteLine("Xahiş edirik düzgün bir rəqəm daxil edin.");
        return;
    }

    if (ton < 0)
    {
        // Əgər daxil edilən dəyər negativdirsə, xəta mesajı göstəririk
        throw new Exception("Ton dəyəri negativ ola bilməz!");
    }

    // Tonu kiloqramla çevirir və nəticəni konsolda göstərir
    double kq = ton * 1000.0; // 1 ton = 1000 kiloqram
    Console.WriteLine("Nəticə: " + kq + " kiloqram");
}

Console.WriteLine("Program bağlandı.");
Console.WriteLine("Programımızdan itifadə etdiyiniz üçün təşəkkür edirik!");