// Decompiled with JetBrains decompiler
// Type: GClass81
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class GClass81
{
  private GClass0 gclass0_0;
  public GClass21 gclass21_0;
  public GClass202 gclass202_0;
  public double double_0;
  public double double_1;

  public GClass81(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public bool method_0(GClass85 gclass85_0)
  {
    try
    {
      return this.gclass0_0.method_520(gclass85_0.double_2, this.double_0, gclass85_0.double_3, this.double_1) && gclass85_0.gclass202_0 == this.gclass202_0 && gclass85_0.gclass21_0 == this.gclass21_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 752);
      return false;
    }
  }
}
