using System;
using TT_hoby.OopOperations;

namespace TT_hoby
{
  public class Program
  {
    private static HashingOperations.HashingOperations _hashingOperations;

    private static void Main()
    {
      Console.WriteLine("Make your choice:");
      Console.WriteLine("1 - matrix operations, 2 - algorithms, 3 - hashing, 4 - OOP, 5 - stop this program");
      int firstChoice = Convert.ToInt32(Console.ReadLine());

      switch (firstChoice)
      {
        case 1:
          MatrixOperations();
          break;
        case 2:
          AlgorithmOperations();
          break;
        case 3:
          HashingOperations();
          break;
        case 4:
          OopOperations();
          break;
        case 5:
          return;
      }

      Main();
    }

    private static void MatrixOperations()
    {
      Console.WriteLine(
        "a - calculate diagonal matrix sum, b - calculate multiples num matrix sum, c - exit subprogram");
      string secondChoice = Console.ReadLine();

      MatrixOperations.MatrixOperations matrixOperations = new MatrixOperations.MatrixOperations();
      switch (secondChoice)
      {
        case "a":
          matrixOperations.CountMatrixSum();
          break;
        case "b":
          matrixOperations.CountMatrixMultipleSum();
          break;
        case "c":
          return;
      }

      MatrixOperations();
    }

    private static void AlgorithmOperations()
    {
      Console.WriteLine("a - calculate fibonacci numbers, b - number exponentiation, c - exit subprogram");
      string secondChoice = Console.ReadLine();

      AlgorithmOperations.AlgorithmOperations algorithmOperations = new AlgorithmOperations.AlgorithmOperations();
      switch (secondChoice)
      {
        case "a":
          Console.WriteLine("Input serial number");
          int serialNumber = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"Fibonacci with serial number {serialNumber} = " +
                            algorithmOperations.CountFibonacciNumbers(serialNumber));
          break;
        case "b":
          Console.WriteLine("Input number");
          int number = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Input extent");
          int extent = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"The number {number} raised to the power {extent} = " +
                            algorithmOperations.CountNumberExponentiation(number, extent));
          break;
        case "c":
          return;
      }

      AlgorithmOperations();
    }

    private static void HashingOperations()
    {
      Console.WriteLine(
        "a - add contact, b - remove contact, c - edit contact, d - find phone number with contact, e - show all contacts, f - remove all contacts, g - exit subprogram");
      string secondChoice = Console.ReadLine();

      if (_hashingOperations == null) _hashingOperations = new HashingOperations.HashingOperations();

      switch (secondChoice)
      {
        case "a":
          Console.WriteLine("Input contact's full name");
          string fullName = Console.ReadLine();
          Console.WriteLine("Input contact's phone number");
          string phoneNumber = Console.ReadLine();

          _hashingOperations.AddContact(fullName, phoneNumber);
          break;
        case "b":
          Console.WriteLine("Input contact's full name to remove");
          string fullNameToRemove = Console.ReadLine();
          Console.WriteLine("Input contact's phone number to remove");
          string phoneNumberToRemove = Console.ReadLine();

          _hashingOperations.RemoveContact(fullNameToRemove, phoneNumberToRemove);
          break;
        case "c":
          Console.WriteLine("Input contact's full name to edit");
          string currentFullName = Console.ReadLine();
          Console.WriteLine("Input contact's phone number to edit");
          string currentPhoneNumber = Console.ReadLine();
          Console.WriteLine("Input new contact's full name");
          string newFullName = Console.ReadLine();
          Console.WriteLine("Input new contact's phone number");
          string newPhoneNumber = Console.ReadLine();

          _hashingOperations.EditContact(currentFullName, currentPhoneNumber, newFullName, newPhoneNumber);
          break;
        case "d":
          Console.WriteLine("Input current contact's full name");
          string contactFullName = Console.ReadLine();

          _hashingOperations.FindContactPhoneNumber(contactFullName);
          break;
        case "e":
          _hashingOperations.ShowAllContacts();
          break;
        case "f":
          _hashingOperations.RemoveAllContacts();
          Console.WriteLine("All contacts deleted");
          break;
        case "g":
          return;
      }

      HashingOperations();
    }

    private static void OopOperations()
    {
      Console.WriteLine("a - square, b - rectangle, c - circle, d - rhombus, e - exit subprogram");

      string secondChoice = Console.ReadLine();
      switch (secondChoice)
      {
        case "a":
          Console.WriteLine("Input square side");
          double side = Convert.ToDouble(Console.ReadLine());

          IShape square = new Square(side);
          CountShapeOperations(square);
          break;
        case "b":
          Console.WriteLine("Input rectangle length");
          double length = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Input rectangle width");
          double width = Convert.ToDouble(Console.ReadLine());

          IShape rectangle = new Rectangle(length, width);
          CountShapeOperations(rectangle);
          break;
        case "c":
          Console.WriteLine("Input circle radius");
          double radius = Convert.ToDouble(Console.ReadLine());

          IShape circle = new Circle(radius);
          CountShapeOperations(circle);
          break;
        case "d":
          Console.WriteLine("Input rhombus side");
          double rhombusSide = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Input rhombus height");
          double height = Convert.ToDouble(Console.ReadLine());

          IShape rhombus = new Rhombus(rhombusSide, height);
          CountShapeOperations(rhombus);
          break;
        case "e":
          return;
      }

      OopOperations();
    }

    private static void CountShapeOperations(IShape square)
    {
      if (square.IsValid())
      {
        Console.WriteLine("Perimeter = " + square.Perimeter());
        Console.WriteLine("Area = " + square.Area());
      }
      else
      {
        Console.WriteLine("Error: such figure does not exists");
      }
    }
  }
}