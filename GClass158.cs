// Decompiled with JetBrains decompiler
// Type: GClass158
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class GClass158
{
  public GClass157 gclass157_0;
  public GClass146 gclass146_0;
  public GClass40 gclass40_0;
  public Decimal decimal_0;
  public GClass146 gclass146_1;
  public Decimal decimal_1;
  public int int_0;

  public Decimal method_0()
  {
    try
    {
      return (Decimal) this.gclass157_0.int_1 * this.decimal_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2102);
      return 0M;
    }
  }
}
