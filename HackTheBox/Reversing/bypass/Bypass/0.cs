// Decompiled with JetBrains decompiler
// Type: 0
// Assembly: HTBChallange, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4B13835A-6F14-4740-B5E0-426A4B735535
// Assembly location: C:\Users\itsme007\Documents\malware_research\HackingChallenges\HackTheBox\Reversing\bypass\Bypass.exe

using System;

public class Class0
{
  public static string str0;
  public static string str1;
  public static string str2;

  public static void Main()
  {
        Strings.whatever();
    if (printMsg())
    {
      validate();
    }
    else
    {
      Console.WriteLine(str0);
      //str0();
    }
  }

  public static bool printMsg()
  {
    Console.Write(str1);
    Console.ReadLine();
    Console.Write(str2);
    Console.ReadLine();
    return false;
  }

  public static void validate()
  {
    //string str1 = \u0035.\u0033;
    //Console.Write(\u0035.\u0034);
    //string str2 = Console.ReadLine();
    //if (str1 == str2)
    //{
    //  Console.Write(\u0035.\u0035 + str0.\u0032 + \u0035.\u0036);
    //}
    //else
    //{
    //  Console.WriteLine(\u0035.\u0037);
    //  str0.\u0032();
    //}
  }
}
