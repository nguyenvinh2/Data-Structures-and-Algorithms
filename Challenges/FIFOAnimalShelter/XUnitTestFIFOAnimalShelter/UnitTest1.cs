using System;
using Xunit;
using StackAndQueue.Classes;
using FIFOAnimalShelter.Classes;
using System.Text;

namespace XUnitTestFIFOAnimalShelter
{
  public class UnitTest1
  {
    /// <summary>
    /// initial no animal test
    /// </summary>
    [Fact]
    public void EmptyQueueTest()
    {
      AnimalShelter MyAnimalShelter = new AnimalShelter();
      Animal MyAnimal = (Animal)MyAnimalShelter.Peek().Data;

      Assert.Equal("No Animal", MyAnimal.Name);
    }
    /// <summary>
    ///     Tests for Peeking and Enqueing
    /// </summary>
    [Fact]
    public void EnqueueTest()
    {
      Animal DogSpotty = new Animal("Spotty", "Dog");

      AnimalShelter MyAnimalShelter = new AnimalShelter();

      MyAnimalShelter.Enqueue(new Node(DogSpotty));
      Animal MyAnimal = (Animal)MyAnimalShelter.Peek().Data;

      Assert.Equal("Spotty", MyAnimal.Name);
    }
    /// <summary>
    /// tests FIFO property that Spotty is still at the front
    /// </summary>
    [Fact]
    public void FIFOEnqueueingTest()
    {
      Animal DogSpotty = new Animal("Spotty", "Dog");
      Animal CatMittens = new Animal("Mittens", "Cat");
      AnimalShelter MyAnimalShelter = new AnimalShelter();

      MyAnimalShelter.Enqueue(new Node(DogSpotty));
      MyAnimalShelter.Enqueue(new Node(CatMittens));

      Animal MyAnimal = (Animal)MyAnimalShelter.Peek().Data;

      Assert.Equal("Spotty", MyAnimal.Name);
    }
    /// <summary>
    /// no null inputs
    /// </summary>
    [Fact]
    public void NullTest()
    {
      AnimalShelter MyAnimalShelter = new AnimalShelter();
      MyAnimalShelter.Enqueue(new Node(null));

      Animal MyAnimal = (Animal)MyAnimalShelter.Peek().Data;

      Assert.Equal("No Animal", MyAnimal.Name);
    }
    /// <summary>
    /// Tests for first no specific animal removal
    /// </summary>
    [Fact]
    public void FIFODequeueingTest()
    {
      Animal DogSpotty = new Animal("Spotty", "Dog");
      Animal CatMittens = new Animal("Mittens", "Cat");
      AnimalShelter MyAnimalShelter = new AnimalShelter();

      MyAnimalShelter.Enqueue(new Node(DogSpotty));
      MyAnimalShelter.Enqueue(new Node(CatMittens));
      MyAnimalShelter.Dequeue("Whatever");
      Animal MyAnimal = (Animal)MyAnimalShelter.Peek().Data;

      Assert.Equal("Mittens", MyAnimal.Name);
    }

    /// <summary>
    /// Tests for first dog animal removal
    /// </summary>
    [Fact]
    public void FIFODogDequeueingTest()
    {
      Animal DogSpotty = new Animal("Spotty", "Dog");
      Animal CatMittens = new Animal("Mittens", "Cat");
      AnimalShelter MyAnimalShelter = new AnimalShelter();

      MyAnimalShelter.Enqueue(new Node(DogSpotty));
      MyAnimalShelter.Enqueue(new Node(CatMittens));
      MyAnimalShelter.Dequeue("Dog");
      Animal MyAnimal = (Animal)MyAnimalShelter.Peek().Data;

      Assert.Equal("Mittens", MyAnimal.Name);
    }


    /// <summary>
    /// Tests for first cat animal removal
    /// </summary>
    [Fact]
    public void FIFOCatDequeueingTest()
    {
      Animal DogSpotty = new Animal("Spotty", "Dog");
      Animal CatMittens = new Animal("Mittens", "Cat");
      AnimalShelter MyAnimalShelter = new AnimalShelter();

      MyAnimalShelter.Enqueue(new Node(DogSpotty));
      MyAnimalShelter.Enqueue(new Node(CatMittens));
      MyAnimalShelter.Dequeue("Cat");
      Animal MyAnimal = (Animal)MyAnimalShelter.Peek().Data;

      Assert.Equal("Spotty", MyAnimal.Name);
    }

    /// <summary>
    /// Tests for cat animal removal when no cat is left
    /// </summary>
    [Fact]
    public void FIFONoCatDequeueingTest()
    {
      Animal DogSpotty = new Animal("Spotty", "Dog");
      Animal CatMittens = new Animal("Mittens", "Cat");
      AnimalShelter MyAnimalShelter = new AnimalShelter();

      MyAnimalShelter.Enqueue(new Node(DogSpotty));
      MyAnimalShelter.Enqueue(new Node(CatMittens));
      MyAnimalShelter.Dequeue("Cat");
      MyAnimalShelter.Dequeue("Cat");
      Animal MyAnimal = (Animal)MyAnimalShelter.Peek().Data;

      Assert.Equal("Spotty", MyAnimal.Name);
    }

    /// <summary>
    /// Tests for dog animal removal when no dog is left
    /// </summary>
    [Fact]
    public void FIFONoDogDequeueingTest()
    {
      Animal DogSpotty = new Animal("Spotty", "Dog");
      Animal CatMittens = new Animal("Mittens", "Cat");
      AnimalShelter MyAnimalShelter = new AnimalShelter();

      MyAnimalShelter.Enqueue(new Node(DogSpotty));
      MyAnimalShelter.Enqueue(new Node(CatMittens));
      MyAnimalShelter.Dequeue("Dog");
      MyAnimalShelter.Dequeue("Dog");
      Animal MyAnimal = (Animal)MyAnimalShelter.Peek().Data;

      Assert.Equal("Mittens", MyAnimal.Name);
    }

    /// <summary>
    /// Tests for animal removal when no animal is left
    /// </summary>
    [Fact]
    public void FIFONoAnimalDequeueingTest()
    {
      Animal DogSpotty = new Animal("Spotty", "Dog");
      Animal CatMittens = new Animal("Mittens", "Cat");
      AnimalShelter MyAnimalShelter = new AnimalShelter();

      MyAnimalShelter.Enqueue(new Node(DogSpotty));
      MyAnimalShelter.Enqueue(new Node(CatMittens));
      MyAnimalShelter.Dequeue("Dog");
      MyAnimalShelter.Dequeue("Cat");
      Animal MyAnimal = (Animal)MyAnimalShelter.Peek().Data;
      Assert.Equal("No Animal", MyAnimal.Name);
    }
    /// <summary>
    /// Tests for cat animal removal after when no animal is left
    /// </summary>
    [Fact]
    public void FIFONoAnimalToRemoveCatDequeueingTest()
    {
      Animal DogSpotty = new Animal("Spotty", "Dog");
      Animal CatMittens = new Animal("Mittens", "Cat");
      AnimalShelter MyAnimalShelter = new AnimalShelter();

      MyAnimalShelter.Enqueue(new Node(DogSpotty));
      MyAnimalShelter.Enqueue(new Node(CatMittens));
      MyAnimalShelter.Dequeue("Dog");
      MyAnimalShelter.Dequeue("Cat");
      MyAnimalShelter.Dequeue("Cat");
      Animal MyAnimal = (Animal)MyAnimalShelter.Peek().Data;
      Assert.Equal("No Animal", MyAnimal.Name);
    }

    /// <summary>
    /// Tests for dog animal removal after when no animal is left
    /// </summary>
    [Fact]
    public void FIFONoAnimalToRemoveDogDequeueingTest()
    {
      Animal DogSpotty = new Animal("Spotty", "Dog");
      Animal CatMittens = new Animal("Mittens", "Cat");
      AnimalShelter MyAnimalShelter = new AnimalShelter();

      MyAnimalShelter.Enqueue(new Node(DogSpotty));
      MyAnimalShelter.Enqueue(new Node(CatMittens));
      MyAnimalShelter.Dequeue("Dog");
      MyAnimalShelter.Dequeue("Cat");
      MyAnimalShelter.Dequeue("Dog");
      Animal MyAnimal = (Animal)MyAnimalShelter.Peek().Data;
      Assert.Equal("No Animal", MyAnimal.Name);
    }

    /// <summary>
    /// Tests for dany animal removal after when no animal is left
    /// </summary>
    [Fact]
    public void FIFONoAnimalToRemoveAnyDequeueingTest()
    {
      Animal DogSpotty = new Animal("Spotty", "Dog");
      Animal CatMittens = new Animal("Mittens", "Cat");
      AnimalShelter MyAnimalShelter = new AnimalShelter();

      MyAnimalShelter.Enqueue(new Node(DogSpotty));
      MyAnimalShelter.Enqueue(new Node(CatMittens));
      MyAnimalShelter.Dequeue("Dog");
      MyAnimalShelter.Dequeue("Cat");
      MyAnimalShelter.Dequeue("Any");
      Animal MyAnimal = (Animal)MyAnimalShelter.Peek().Data;
      Assert.Equal("No Animal", MyAnimal.Name);
    }
  }
}
