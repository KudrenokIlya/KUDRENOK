﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static void Main()
{
    { }
}
//#region Task_1

//var count = int.Parse(Console.ReadLine());
//var unitPrice = double.Parse(Console.ReadLine());
//var discount = double.Parse(Console.ReadLine());

//var totalPrice = count * (unitPrice - (unitPrice * discount / 100));

//Console.WriteLine($"price is {totalPrice}");
//Console.ReadLine();

//#endregion



//#region Task_2

//var Name1 = Console.ReadLine();
//var count1 = int.Parse(Console.ReadLine());
//var unitPrice1 = double.Parse(Console.ReadLine());

//var Name2 = Console.ReadLine();
//var count2 = int.Parse(Console.ReadLine());
//var unitPrice2 = double.Parse(Console.ReadLine());

//var Name3 = Console.ReadLine();
//var count3 = int.Parse(Console.ReadLine());
//var unitPrice3 = double.Parse(Console.ReadLine());

//var discount = double.Parse(Console.ReadLine());

//var COUNT = count1 + count2 + count3;
//Console.WriteLine($"total count  is {COUNT}");

//var UNITPRICE = unitPrice1 + unitPrice2 + unitPrice3;
//Console.WriteLine($"total unitPrice  is {UNITPRICE}");

//var totalPrice = COUNT * (UNITPRICE - (UNITPRICE * discount / 100));
//Console.WriteLine($"Your price is {totalPrice}");
//Console.ReadLine();


//#endregion



//#region Task_3

//var Name1 = Console.ReadLine();
//var count1 = int.Parse(Console.ReadLine());
//var unitPrice1 = double.Parse(Console.ReadLine());

//var Name2 = Console.ReadLine();
//var count2 = int.Parse(Console.ReadLine());
//var unitPrice2 = double.Parse(Console.ReadLine());

//var Name3 = Console.ReadLine();
//var count3 = int.Parse(Console.ReadLine());
//var unitPrice3 = double.Parse(Console.ReadLine());

//var discount = double.Parse(Console.ReadLine());

//var COUNT1 = count1 + count2 + count3;
//Console.WriteLine($"total count  is {COUNT1}");

//var COUNT2 = 10;

//var UNITPRICE = unitPrice1 + unitPrice2 + unitPrice3;
//Console.WriteLine($"total unitPrice  is {UNITPRICE}");

//var totalPrice1 = COUNT1 * (UNITPRICE - (UNITPRICE * discount / 100));
//Console.WriteLine($"Your price is {totalPrice1}");
//Console.ReadLine();

//var totalPrice2 = COUNT2 * (UNITPRICE - (UNITPRICE * discount / 100));
//Console.WriteLine($"Your price is {totalPrice2}");
//Console.ReadLine();

//#endregion

//#region Task_4
//Console.WriteLine("Enter five sides");
//int firstSide = int.Parse(Console.ReadLine());
//int secondSide = int.Parse(Console.ReadLine());
//int thirdSide = int.Parse(Console.ReadLine());
//int forthSide = int.Parse(Console.ReadLine());
//int fithSide = int.Parse(Console.ReadLine());

//int Triangleperimeter = firstSide + secondSide + thirdSide;
//int Quadrangleperimeter = firstSide + secondSide + thirdSide + forthSide;
//int Pentagonperimeter = firstSide + secondSide + thirdSide + forthSide + fithSide;

//Console.WriteLine($"Trianle perimeter: {Triangleperimeter}");
//Console.WriteLine($"Quadrangle perimeter: {Quadrangleperimeter}");
//Console.WriteLine($"Pentagon perimeter: {Pentagonperimeter}");
//Console.ReadLine();
//#endregion

//#region Task_5
//Console.WriteLine("Enter side, height, radius");
//int side = int.Parse(Console.ReadLine());
//int height = int.Parse(Console.ReadLine());
//int radius = int.Parse(Console.ReadLine());


//int TriangleSquare = side * height / 2;
//double CircleSquare = Math.PI * radius * radius;

//Console.WriteLine($"Trianle Square: {TriangleSquare}");
//Console.WriteLine($"Circle Square: {CircleSquare}");
//#endregion

public class Homework

{
    //TASK_1
    //public double CountDiscountReturnValue(int count, double unitPrice, double discount)
    //{
    //    var totalPrice = count * (unitPrice - (unitPrice * discount / 100));

    //    return totalPrice;

    //}





    //TASK_2
    //public double CountDiscountReturnValue(int COUNT, double UNITPRICE, double discount)
    //{
    //    var totalPrice = COUNT * (UNITPRICE - (UNITPRICE * discount / 100));

    //    return totalPrice;

    //}


    //TASK_3
    //public double CountDiscountReturnValue(int COUNT1, double UNITPRICE, double discount)
    //{
    //    var totalPrice1 = COUNT1 * (UNITPRICE - (UNITPRICE * discount / 100));

    //    return totalPrice1;

    //}

    //TASK_3
    //public double CountDiscountReturnValue(int COUNT2, double UNITPRICE, double discount)
    //{
    //    var totalPrice2 = COUNT2 * (UNITPRICE - (UNITPRICE * discount / 100));

    //    return totalPrice2;
    //}

    //TASK_4
    //public static int CalculatePerimeter(params int[] sides)
    //{

    //    var perimeter = 0;
    //    foreach (var side in sides)
    //    {
    //        perimeter += side;
    //    }
    //    return perimeter;
    //}

    //TASK_5

    //public double CalculateTriangleSquare(int side, int height)
    //    {
    //        var TriangleSquare = side * height / 2;
    //        return TriangleSquare;
    //    }

    //    public double CalculateCircleSquare(int radius)
    //    {
    //        var CircleSquare = Math.PI * radius * radius;

    //        return CircleSquare;
    //    }




    // Наследование - во время проектирования чего либо, берем зо основу что-то готовое и совершенствуем
    // Инкаспсуляция - водитель не обязан знать как что устроено внутри авто, чтобы уметь на нем ездить
    // Полиморфизм - знаешя как обращаться с рулем, то ты можешь с помощью него управлять автомобилем, не зависимо от того есть или нет в нем гидроуселителя
    // Абстракция - при создании логотипов требуется взять основные признаки бренда и максимально их упростить, но остаться узнаваемыми

}




