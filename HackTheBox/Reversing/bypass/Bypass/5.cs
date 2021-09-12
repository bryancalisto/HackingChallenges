// Decompiled with JetBrains decompiler
// Type: 5
// Assembly: HTBChallange, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4B13835A-6F14-4740-B5E0-426A4B735535
// Assembly location: C:\Users\itsme007\Documents\malware_research\HackingChallenges\HackTheBox\Reversing\bypass\Bypass.exe

using System;
using System.IO;
using System.Reflection;

internal static class Strings
{
    internal static string str1="encrypted";
    internal static string str2;
    internal static string str3;
    internal static string str4;
    internal static string str5;
    internal static string str6;
    internal static string str7;
    internal static string str8;
    internal static string str9;
    internal static string str10;
    internal static string a;
    internal static string b;
    internal static string c;

    public static void whatever()
    {
        Assembly assembly = Assembly.GetExecutingAssembly(); 
        Stream assemblyData= assembly.GetManifestResourceStream(str1);
        byte[] obj = Cypher.returnDecrypted(assemblyData);
        Class6 binReader = new Class6(obj);

        str1 = binReader.readString();
        str2 = binReader.readString();
        str3 = binReader.readString();
        str4 = binReader.readString();
        str5 = binReader.readString();
        str6 = binReader.readString();
        str7 = binReader.readString();
        str8 = binReader.readString();
        str9 = binReader.readString();
        str10 = binReader.readString();
        a = binReader.readString();
        b = binReader.readString();
        c = binReader.readString();
    }
}
