// Decompiled with JetBrains decompiler
// Type: 6
// Assembly: HTBChallange, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4B13835A-6F14-4740-B5E0-426A4B735535
// Assembly location: C:\Users\itsme007\Documents\malware_research\HackingChallenges\HackTheBox\Reversing\bypass\Bypass.exe

using System.IO;
using System.Text;

internal class Class6
{
  private readonly BinaryReader binReader;

  public Class6(Stream _param1) => this.binReader= new BinaryReader(_param1, Encoding.Unicode);

  public Class6(byte[] _param1)
    : this((Stream) new MemoryStream(_param1))
  {
  }

  public string readString() => this.binReader.ReadString();

  public sbyte seven() => this.binReader.ReadSByte();

  public int eight() => this.binReader.ReadInt32();

  public long nine() => this.binReader.ReadInt64();

  public float a() => this.binReader.ReadSingle();

  public double b() => this.binReader.ReadDouble();
}
