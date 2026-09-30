using System;

class BankAccount
{
    int accountNumber { get; init; }
    string accountName {get; set;}
    private double _balance;
    public double balance
    {
        get => _balance;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Balance cannot be negative.");
            _balance = value;
        }
    }

    public BankAccount(int accountNumber, string accountName, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountName = accountName;
        this.balance = balance;
    }
}

class Student
{
    public int Id { get; }
    public string Name { get; }
    public Student(int studentID, string studentName)
    {
        Id = studentID;
        Name = studentName;
    }
}

class Vehicle
{
    public string Make{get; set;}
    public string Model{get; set;}

    public virtual void StartEngine(){}

    protected void DisplayInfo()
    {
        Console.WriteLine($"Make: {Make}, Model: {Model}");
    }

    public Vehicle(string make, string model)
    {
        Make = make;
        Model = model;
    }
}

class Car : Vehicle
{
    public int DoorsNumber{get; set;}

    public override void StartEngine()
    {
        Console.WriteLine("Car engine started with push button.");
        DisplayInfo();
    }

    public Car(string make, string model, int doorsNumber) : base(make, model)
    {
        DoorsNumber = doorsNumber;
    }
}

class Truck : Vehicle
{
    public string Color {get; set;}
    public Truck(string make, string model,string color) : base(make, model)
    {
        Color = color;
    }
}

class HeavyTruck : Truck
{
    public HeavyTruck(string make, string model,string color) : base(make, model, color)
    {
    }
}

class Person
{
    public string Name {get; set;}
    public int Age {get; set;}

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Person(): this("", 0);
    public Person(string name): this(name, 0);
    public Person(int age): this("", age);
}

class Student : Person
{
        public int StudentID {get; set;}
}

class Employee : Person
{
    public string JobTitle {get; set;}
}