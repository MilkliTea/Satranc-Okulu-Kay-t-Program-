using System;
using System.Collections.Generic;

public class ChessStudent
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string ParentName { get; set; }
    public string ContactNumber { get; set; }
}

class Program
{
    static List<ChessStudent> students = new List<ChessStudent>();

    static void Main(string[] args)
    {
        Console.WriteLine("Satranç Okulu Kayıt Programına Hoş Geldiniz");

        while (true)
        {
            Console.WriteLine("\nLütfen bir seçenek seçiniz:");
            Console.WriteLine("1. Yeni öğrenci kaydı yap");
            Console.WriteLine("2. Kayıtlı öğrencileri görüntüle");
            Console.WriteLine("3. Çıkış");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RegisterStudent();
                    break;
                case "2":
                    ViewRegisteredStudents();
                    break;
                case "3":
                    Console.WriteLine("Programdan çıkılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyiniz.");
                    break;
            }
        }
    }

    static void RegisterStudent()
    {
        Console.WriteLine("\nYeni öğrenci kaydı için bilgileri giriniz:");

        Console.Write("Adı: ");
        string name = Console.ReadLine();

        Console.Write("Yaşı: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Veli Adı: ");
        string parentName = Console.ReadLine();

        Console.Write("İletişim Numarası: ");
        string contactNumber = Console.ReadLine();

        // Create a new student object
        ChessStudent newStudent = new ChessStudent
        {
            Name = name,
            Age = age,
            ParentName = parentName,
            ContactNumber = contactNumber
        };

        // Add the student to the list
        students.Add(newStudent);

        Console.WriteLine("\nÖğrenci başarıyla kaydedildi!");
    }

    static void ViewRegisteredStudents()
    {
        Console.WriteLine("\nKayıtlı Öğrencilerin Listesi:");

        if (students.Count == 0)
        {
            Console.WriteLine("Henüz kayıtlı öğrenci bulunmamaktadır.");
        }
        else
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Adı: {student.Name}, Yaşı: {student.Age}, Veli Adı: {student.ParentName}, İletişim Numarası: {student.ContactNumber}");
            }
        }
    }
}
