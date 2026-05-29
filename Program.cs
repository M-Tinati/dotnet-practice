using System;
using System.IO;

string FilePath = @"C:\Users\Tinati\Desktop\C++";   //آدرس دایرکتوری
string[] FormatFiles = Directory.GetFiles(FilePath , "*.cpp"); //آرایه ای که فایل های مسیر داده شده رو میگیره و فرمت مورد نظرمون رو بهش میدیم
if(FormatFiles.Length> 0) //اگر تعداد فایل بزرگ تر از  صفر بود 
{
    Console.WriteLine($"Path -> {FilePath} has cpp count {FormatFiles.Length}"); //در مسیر داده شده به تعداد (مثلا) یک عدد فایل با فرمت مورد نظر وجود دارد
}
else
{
    Console.WriteLine("Empty");
}