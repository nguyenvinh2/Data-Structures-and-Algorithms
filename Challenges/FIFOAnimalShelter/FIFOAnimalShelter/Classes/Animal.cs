using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
  class Animal
  {
    public string Name { get; set; }
    public string Type { get; set; }
    /// <summary>
    /// constructor for animal object with type of animal
    /// property. e.g. dog, cat, lion...
    /// </summary>
    /// <param name="name">name of animal</param>
    /// <param name="type">type of animal</param>
    public Animal(string name, string type)
    {
      Name = name;
      Type = type;
    }
  }
}
