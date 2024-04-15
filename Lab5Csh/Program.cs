namespace Lab5Csh;

public class Animal
{
    public string Food { get; set; }
    public string Location { get; set; }

    public virtual void MakeNoise()
    {
        Console.WriteLine("Такое-то животное спит");
    }

    public virtual void Eat()
    {
        Console.WriteLine($"Животное ест {Food}");
    }

    public static void Sleep()
    {
        Console.WriteLine("Животное спит");
    }
}



public class Dog : Animal
{
    public string Breed { get; set; }

    public override void MakeNoise()
    {
        Console.WriteLine("Гав-гав");
    }

    public override void Eat()
    {
        Console.WriteLine($"Собака ест {Food}");
    }
}

public class Cat : Animal
{
    public string Color { get; set; }

    public override void MakeNoise()
    {
        Console.WriteLine("Мяу");
    }

    public override void Eat()
    {
        Console.WriteLine($"Кот ест {Food}");
    }
}

public class Horse : Animal
{
    public string Breed { get; set; }

    public override void MakeNoise()
    {
        Console.WriteLine("Ий-ий");
    }

    public override void Eat()
    {
        Console.WriteLine($"Лошадь ест {Food}");
    }
}



public class Veterinarian
{
    public void TreatAnimal(Animal animal)
    {
        Console.WriteLine($"Питание: {animal.Food}, Местоположение: {animal.Location}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Dog dog = new() { Food = "кости", Location = "дом", Breed = "лабрадор" };
        Cat cat = new() { Food = "рыба", Location = "квартира", Color = "серый" };
        Horse horse = new() { Food = "солома", Location = "стайня", Breed = "арабская" };

        Veterinarian veterinarian = new();

        veterinarian.TreatAnimal(dog);
        veterinarian.TreatAnimal(cat);
        veterinarian.TreatAnimal(horse);
    }
}
