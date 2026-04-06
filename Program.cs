using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // первое задание
        Console.WriteLine("Векторы");

        MyVector vectorA = new MyVector(5, -2);
        MyVector vectorB = new MyVector(-3, 7);

        Console.WriteLine("vectorA = " + vectorA);
        Console.WriteLine("vectorB = " + vectorB);

        Console.WriteLine("Сложение: " + (vectorA + vectorB));
        Console.WriteLine("Вычитание: " + (vectorA - vectorB));
        Console.WriteLine("Скалярное произведение: " + (vectorA * vectorB));
        Console.WriteLine("Умножение на число: " + (vectorA * 3));
        Console.WriteLine("Длина vectorA: " + (+vectorA));
        Console.WriteLine("vectorA == vectorB: " + (vectorA == vectorB));
        Console.WriteLine("vectorA != vectorB: " + (vectorA != vectorB));

        Console.WriteLine();

        // второе задание
        Console.WriteLine("Репозиторий в памяти");

        IOrderRepository memoryRepo = new InMemoryOrderRepository();

        memoryRepo.Add(new Order(1, "Ноутбук", 2));
        memoryRepo.Add(new Order(2, "Мышь", 5));

        foreach (Order order in memoryRepo.GetAll())
        {
            Console.WriteLine(order);
        }

        Console.WriteLine();
        Console.WriteLine("Репозиторий в csv файле");

        IOrderRepository csvRepo = new CsvOrderRepository("orders.csv");

        csvRepo.Add(new Order(3, "Клавиатура", 1));
        csvRepo.Add(new Order(4, "Монитор", 2));

        foreach (Order order in csvRepo.GetAll())
        {
            Console.WriteLine(order);
        }

        Console.WriteLine();

        // третье задание
        Console.WriteLine("Дерево");

        NodeUnit baseNode = new NodeUnit(10);

        NodeUnit block1 = new NodeUnit(20);
        NodeUnit block2 = new NodeUnit(30);
        NodeUnit block3 = new NodeUnit(40);
        NodeUnit block4 = new NodeUnit(50);
        NodeUnit block5 = new NodeUnit(60);

        baseNode.Attach(block1);
        baseNode.Attach(block2);

        block1.Attach(block3);
        block1.Attach(block4);

        block2.Attach(block5);

        Console.WriteLine("Все вложенные значения:");
        baseNode.ShowNested();
    }
}