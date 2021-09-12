// Decompiled with JetBrains decompiler
// Type: 1
// Assembly: HTBChallange, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4B13835A-6F14-4740-B5E0-426A4B735535
// Assembly location: C:\Users\itsme007\Documents\malware_research\HackingChallenges\HackTheBox\Reversing\bypass\Bypass.exe

using System;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
public class AlgunAtributo : Attribute
{
  public string algunaString;

  public AlgunAtributo() => this.algunaString = Strings.str10;
}
