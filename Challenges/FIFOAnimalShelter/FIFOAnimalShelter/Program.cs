using System;
using StackAndQueue.Classes;
using FIFOAnimalShelter.Classes;
using System.Collections.Generic;

namespace FIFOAnimalShelter
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      FIFOAnimalShelter();
      Console.ReadKey();
    }
    /// <summary>
    /// Testing out Animal Shelter Method
    /// </summary>
    static void FIFOAnimalShelter()
    {
      Animal DogSpotty = new Animal("Spotty", "Dog");
      Animal CatMittens = new Animal("Mittens", "Cat");
      Animal DogWoofy = new Animal("Woofy", "Dog");
      Animal DogSpike = new Animal("Spike", "Dog");
      Animal DogMrBeans = new Animal("MrBeans", "Dog");
      Animal CatFluffy = new Animal("Fluffy", "Cat");
      Animal CatMrEvil = new Animal("MrEvil", "Cat");
      Animal CatMisty = new Animal("Misty", "Cat");

      List<Animal> AllMyAnimals = new List<Animal>()
      {
        DogSpotty, CatMittens, DogWoofy, DogSpike, DogMrBeans, CatFluffy, CatMrEvil, CatMisty
      };

      AnimalShelter MyAnimalShelter = new AnimalShelter();

      Console.WriteLine("The Shelter has the following animals in the order it was received:");
      foreach (var items in AllMyAnimals)
      {
        MyAnimalShelter.Enqueue(new Node(items));
        Console.WriteLine($"{items.Name} who is a {items.Type}");
      }

      Animal MyAnimal = (Animal)MyAnimalShelter.Peek().Data;
      Console.WriteLine($"{MyAnimal.Name} is at the Front of the Shelter");

      Animal ReturnAnimal = (Animal)MyAnimalShelter.Dequeue("Whatever").Data;
      MyAnimal = (Animal)MyAnimalShelter.Peek().Data;
      Console.WriteLine($"Any animal is removed so {ReturnAnimal.Name} has been released and {MyAnimal.Name} is now at the front");

      ReturnAnimal = (Animal)MyAnimalShelter.Dequeue("Dog").Data;
      MyAnimal = (Animal)MyAnimalShelter.Peek().Data;
      Console.WriteLine($"A Dog is removed so {ReturnAnimal.Name} has been released and {MyAnimal.Name} is now at the front");

      ReturnAnimal = (Animal)MyAnimalShelter.Dequeue("Cat").Data;
      MyAnimal = (Animal)MyAnimalShelter.Peek().Data;
      Console.WriteLine($"A Cat is removed so {ReturnAnimal.Name} has been released and {MyAnimal.Name} is now at the front");


      ReturnAnimal = (Animal)MyAnimalShelter.Dequeue("Cat").Data;
      MyAnimal = (Animal)MyAnimalShelter.Peek().Data;
      Console.WriteLine($"A Cat is removed so {ReturnAnimal.Name} has been released and {MyAnimal.Name} is now at the front");


      ReturnAnimal = (Animal)MyAnimalShelter.Dequeue("Cat").Data;
      MyAnimal = (Animal)MyAnimalShelter.Peek().Data;
      Console.WriteLine($"A Cat is removed so {ReturnAnimal.Name} has been released and {MyAnimal.Name} is now at the front");


      ReturnAnimal = (Animal)MyAnimalShelter.Dequeue("Dog").Data;
      MyAnimal = (Animal)MyAnimalShelter.Peek().Data;
      Console.WriteLine($"A Dog is removed so {ReturnAnimal.Name} has been released and {MyAnimal.Name} is now at the front");


      ReturnAnimal = (Animal)MyAnimalShelter.Dequeue("Lion").Data;
      MyAnimal = (Animal)MyAnimalShelter.Peek().Data;
      Console.WriteLine($"A Lion is removed so {ReturnAnimal.Name} has been released and {MyAnimal.Name} is now at the front");

      ReturnAnimal = (Animal)MyAnimalShelter.Dequeue("Dog").Data;
      MyAnimal = (Animal)MyAnimalShelter.Peek().Data;
      Console.WriteLine($"A Dog is removed so {ReturnAnimal.Name} has been released and {MyAnimal.Name} is now at the front");

      ReturnAnimal = (Animal)MyAnimalShelter.Dequeue("W").Data;
      MyAnimal = (Animal)MyAnimalShelter.Peek().Data;
      Console.WriteLine($"Any animal is removed so {ReturnAnimal.Name} has been released and {MyAnimal.Name} is now at the front");

      ReturnAnimal = (Animal)MyAnimalShelter.Dequeue("Dog").Data;
      MyAnimal = (Animal)MyAnimalShelter.Peek().Data;
      Console.WriteLine($"A Dog is removed so {ReturnAnimal.Name} has been released and {MyAnimal.Name} is now at the front");

      Animal NewCat = new Animal("Bubbles", "Cat");
      Animal NewDog = new Animal("Labby", "Dog");
      MyAnimalShelter.Enqueue(new Node(NewCat));
      MyAnimalShelter.Enqueue(new Node(NewCat));
      MyAnimal = (Animal)MyAnimalShelter.Peek().Data;

      Console.WriteLine($"{NewCat.Name} who is a {NewCat.Type} has been added and {NewDog.Name} who is a {NewDog.Type} has been added so {MyAnimal.Name} is at the front.");
    }
  }

}
