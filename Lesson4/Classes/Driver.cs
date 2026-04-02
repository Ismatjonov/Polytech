using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
namespace Lesson4.Classes;

public class Driver
{
    private string Name { get; set; }
    private string Surname { get; set; }
    private string id;
    private int rma;
    public string PhoneNumber;
    public string gender { get; set; }
    private string DateOfBirth;
    private string Address { get; set; }
    public string LicenseDate { get; set; }
    public Car car;
    public string ID
    {
        get => id;
        set
        {
            if(value[0] == 'А' && value.Length == 9)
                id = value;
            else
            {
                Console.WriteLine("ID нодуруст дохил карда шуд!");
                id = "A00000000";
            }
            
        }
    }
    public int RMA
    {
        get => rma;
        set
        {
            if (value.ToString().Length == 9)
                rma = value;
        }
    }
    
    public Driver(string name, string surname, string id, int rma, string phone, string gender, string dateOfBirth, string address, string licenseDate, Car car)
    {
        Name = name;
        Surname = surname;
        ID = id;
        RMA = rma;
        PhoneNumber = phone;
        this.gender = gender;
        DateOfBirth = dateOfBirth;
        Address = address;
        LicenseDate = licenseDate;
        this.car = car;
    }

    public void Display()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("МАЪЛУМОТ ДАР БОРАИ РОНАНДА");
        Console.ResetColor();
        Console.WriteLine($"Ному насаб: {Name} {Surname}");
        Console.WriteLine($"Чинс: {gender}");
        Console.WriteLine($"Раками телефон: {PhoneNumber}");
        Console.WriteLine($"Санаи таваллуд: {DateOfBirth}");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"RMA: {RMA}");
        Console.WriteLine($"Адрес: {Address}");
        Console.WriteLine($"Мошини {car.Brand} {car.Model},\nНомери мошин: {car.Number},\nРангаш: {car.Color}");
        Console.WriteLine("--------------------");
    }

    public void Zakaz(int sit)
    {
        if (sit <= 4 && sit >= 1)
        {
            Random rnd = new Random();
            Console.WriteLine($"Ронанда {Name} {Surname} бo мошини {car.Brand} {car.Model} рангаш {car.Color.ToLower()} бо раками давлатии {car.Number} ба назди шумо дар давоми {rnd.Next(1, 10)} дакика хозир мешавад.");
        }
        else
        {
            Console.WriteLine($"Ин {sit} нафар одамонро ин роонанда гирифта наметавонад(");
        }
    }
}