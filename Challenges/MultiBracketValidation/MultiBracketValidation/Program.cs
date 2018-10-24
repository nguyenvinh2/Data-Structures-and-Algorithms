using System;
using StackAndQueue.Classes;

namespace MultiBracketValidation
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      string input = "{}{Code}[Fellows](())";
      string input2 = "(){}[[]]";
      string input3 = "()[[Extra Characters]]";
      string input4 = "[({}]";
      string input5 = "(](";
      string input6 = "{(})";

      Console.WriteLine($"Bracker Validation for {input} is {MultiBracketValidation(input)}");
      Console.WriteLine($"Bracker Validation for {input2} is {MultiBracketValidation(input2)}");
      Console.WriteLine($"Bracker Validation for {input3} is {MultiBracketValidation(input3)}");
      Console.WriteLine($"Bracker Validation for {input4} is {MultiBracketValidation(input4)}");
      Console.WriteLine($"Bracker Validation for {input5} is {MultiBracketValidation(input5)}");
      Console.WriteLine($"Bracker Validation for {input6} is {MultiBracketValidation(input6)}");

      Console.ReadKey();
    }

    public static bool MultiBracketValidation(string input)
    {
      char[] brackets = input.ToCharArray();
      Stack Keeper = new Stack(new Node(null));
      for (int i = 0; i < brackets.Length; i++)
      {
        if (brackets[i] == '[' || brackets[i] == '{' | brackets[i] == '(')
        {
          switch (brackets[i])
          {
            case '[':
              Keeper.Push(new Node(']'));
              break;
            case '{':
              Keeper.Push(new Node('}'));
              break;
            case '(':
              Keeper.Push(new Node(')'));
              break;
          }
        }
        else if (brackets[i] == ']' || brackets[i] == '}' | brackets[i] == ')')
        {
          if (Keeper.Peek().Data != null)
          {
            if ((char)Keeper.Peek().Data == brackets[i])
            {
              Keeper.Pop();
            }
            else
            {
              return false;

            }
          }
          else
          {
            return false;
          }
        }
      }
      if (Keeper.Peek().Data == null)
      {
        return true;
      }
      return false;
    }
  }
}
