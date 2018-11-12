using System;
using Hashtables.Classes;

namespace Hashtables
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      Hashtable TestHash = new Hashtable();

      TestHash.Add("kay", "mary");
      TestHash.Add("b", "sammy");
      TestHash.Add("abc", "junk");
      Console.WriteLine(Hashtable.GetHash("abc"));
      Console.WriteLine(Hashtable.GetHash("b"));
      Console.WriteLine(Hashtable.GetHash("kay"));
      string value = TestHash.Find("kay");

      Console.WriteLine(value);

      Console.WriteLine(TestHash.Find("aebc"));

      Console.WriteLine(TestHash.Contains("abdc"));

      Console.ReadKey();
    }
  }
}
