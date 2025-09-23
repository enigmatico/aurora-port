// Decompiled with JetBrains decompiler
// Type: GClass119
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class GClass119
{
  public GClass230 gclass230_0;
  public int int_0;
  public int int_1;
  public double double_0;
  public Decimal decimal_0;

  public GClass119 method_0()
  {
    try
    {
      GClass119 gclass119 = new GClass119();
      return (GClass119) this.MemberwiseClone();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1925);
      return (GClass119) null;
    }
  }
}
