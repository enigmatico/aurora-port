// Decompiled with JetBrains decompiler
// Type: GClass64
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;

#nullable disable
public class GClass64
{
  public GClass221 gclass221_0;
  public AuroraContactStatus auroraContactStatus_0 = AuroraContactStatus.None;
  public int int_0;
  public int int_1;
  public string string_0 = "";

  public GClass64(
    GClass221 gclass221_1,
    AuroraContactStatus auroraContactStatus_1,
    string string_1,
    int int_2)
  {
    this.gclass221_0 = gclass221_1;
    this.auroraContactStatus_0 = auroraContactStatus_1;
    this.string_0 = string_1;
    this.int_0 = int_2;
  }

  public string method_0()
  {
    try
    {
      if (this.int_0 == 1)
        return this.string_0;
      int num = this.string_0.IndexOf("]");
      return num == -1 ? $"{this.int_0.ToString()}x {this.string_0}" : this.string_0.Insert(num + 3, this.int_0.ToString() + "x ");
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 456);
      return "";
    }
  }
}
