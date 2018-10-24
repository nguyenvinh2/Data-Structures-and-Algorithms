using System;
using System.Collections.Generic;
using System.Text;
using StackAndQueue.Classes;

namespace FIFOAnimalShelter.Classes
{
  class AnimalShelter
  {
    /// <summary>
    /// Adding a marker "End" to the Queue. Queue class was not built to handle having null
    /// </summary>
    public Queue ShelterOne = new Queue(new Node("End"));
    public Queue ShelterTwo = new Queue(new Node("End"));

    /// <summary>
    /// gives the animal at the front of the shelter or no animal left if no animal
    /// </summary>
    /// <returns></returns>
    public Node Peek()
    {
      if ((string)Convert.ToString(ShelterOne.Front.Data) != "End")
      {
        return ShelterOne.Front;
      }
      else
      {
        return new Node(new Animal("No Animal Left", "No Animal Left"));
      }
    }
    /// <summary>
    /// adds animal in
    /// ShelterOne is the working queue. ShelterTwo is used to handle dequeueing
    /// </summary>
    /// <param name="node">animal added in</param>
    public void Enqueue(Node node)
    {
      ShelterOne.Enqueue(node);
      if ((string)Convert.ToString(ShelterOne.Front.Data) == "End")
      {
        ShelterOne.Dequeue();
      }
    }
    /// <summary>
    /// removes animal specified
    /// </summary>
    /// <param name="animal">animal type specified to be removed in string format</param>
    /// <returns>animal specified to be removed in Node format</returns>
    public Node Dequeue(string animal)
    {
      Animal WhatKind;
      //checks if the queue actually any animal to be removed using the marker
      if ((string)Convert.ToString(ShelterOne.Front.Data) != "End")
      {
        //if animal is not a dog or cat, remove one at the front of the queue
        if (animal.ToLower() != "dog" && animal.ToLower() != "cat")
        {
          return ShelterOne.Dequeue();
        }
        //adds marker for while loop
        ShelterOne.Enqueue(new Node("End"));
        //converts the object located in the node back to animal
        WhatKind = (Animal)Convert.ChangeType(ShelterOne.Peek().Data, typeof(Animal));
        //looks for the most recent animal specified (dog or cat) in the queue, throws everything in the second queue until it finds it
        while (WhatKind.Type != animal && (string)Convert.ToString(ShelterOne.Front.Data) != "End")
        {
          ShelterTwo.Enqueue(ShelterOne.Dequeue());
          if ((string)Convert.ToString(ShelterOne.Front.Data) != "End")
          {
            WhatKind = (Animal)Convert.ChangeType(ShelterOne.Peek().Data, typeof(Animal));
          }
        }
        //finds the animal to remove, then throws the rest of the animals in second queue then sends everything back to the first queue
        if ((string)Convert.ToString(ShelterOne.Front.Data) != "End")
        {
          Node PetRelease = ShelterOne.Dequeue();
          while ((string)Convert.ToString(ShelterOne.Front.Data) != "End")
          {
            ShelterTwo.Enqueue(ShelterOne.Dequeue());
          }
          ShelterTwo.Enqueue(new Node("End"));
          ShelterTwo.Dequeue();
          while ((string)Convert.ToString(ShelterTwo.Front.Data) != "End")
          {
            ShelterOne.Enqueue(ShelterTwo.Dequeue());
          }
          ShelterOne.Dequeue();
          return PetRelease;
        }
        //this takes care of the condition that if the desired animal is a dog and there are only cats
        //left, don't release any animal
        else if ((string)Convert.ToString(ShelterOne.Front.Data) == "End")
        {
          ShelterTwo.Enqueue(new Node("End"));
          ShelterTwo.Dequeue();
          while ((string)Convert.ToString(ShelterTwo.Front.Data) != "End")
          {
            ShelterOne.Enqueue(ShelterTwo.Dequeue());
          }
          ShelterOne.Enqueue(new Node("End"));
          ShelterOne.Dequeue();
          return new Node(new Animal("No Animal Released", "No Animal Released"));
        }
        else
        {
          return new Node(new Animal("No Animal Left", "No Animal Left"));
        }
      }
      else
      {
        return new Node(new Animal("No Animal Left", "No Animal Left"));
      }
    }
  }
}
