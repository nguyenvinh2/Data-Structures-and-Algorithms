using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using LinkedList;

namespace Hashtables.Classes
{
  public class KeyValue
  {
    public string Key { get; set; }
    public string Value { get; set; }
  }
  public class Hashtable
  {
    private LinkList[] HashArray = new LinkList[1024];
    /// <summary>
    /// convertes input strings to KeyValue pairs,
    /// gets index and stores in array
    /// uses link list in case of collision
    /// </summary>
    /// <param name="key">key part of hashtable</param>
    /// <param name="value">value part</param>
    public void Add(string key, string value)
    {
      int index = GetHash(key);
      KeyValue Pair = new KeyValue();
      Pair.Key = key;
      Pair.Value = value;
      Node NodeHash = new Node(Pair);
      if (HashArray[index] == null)
      {
        LinkList New = new LinkList();
        New.AddToHead(NodeHash);
        HashArray[index] = New;
      }
      else
      {
        HashArray[index].Append(NodeHash);
      }
    }
    /// <summary>
    /// finds and returns the value based on key
    /// accounts for null index and collision
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public string Find(string key)
    {
      int index = GetHash(key);
      if (HashArray[index] != null)
      {
        while (HashArray[index].Current != null)
        {
          KeyValue conversion = (KeyValue)HashArray[index].Current.Data;

          if (conversion.Key == key)
          {
            return conversion.Value;
          }
          else
          {
            HashArray[index].Current = HashArray[index].Current.Next;
          }
        }
      }
      return null;  
    }
    /// <summary>
    /// finds if the key exists
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public bool Contains(string key)
    {
      int index = GetHash(key);
      if (HashArray[index] != null)
      {
        while (HashArray[index].Current != null)
        {
          KeyValue conversion = (KeyValue)HashArray[index].Current.Data;

          if (conversion.Key == key)
          {
            return true;
          }
          else
          {
            HashArray[index].Current = HashArray[index].Current.Next;
          }
        }
      }
      return false;
    }
    /// <summary>
    /// returns index value based on key string
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public static int GetHash(string key)
    {
      if (key.Length == 0)
        return 0;
      int sum = 0;
      int n = key.Length;
      for (int i = 0; i < n-1; i++)
      {
        sum += key[i] * (int)Math.Pow(31, n - i - 1);
      }
      sum += key[n-1];
      return Math.Abs(sum) % 1024;
    }
  }
}
