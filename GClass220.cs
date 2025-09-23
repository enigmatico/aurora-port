// Decompiled with JetBrains decompiler
// Type: GClass220
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class GClass220
{
  public GClass0 gclass0_0;
  public GClass1 gclass1_0;
  public GClass162 gclass162_0;
  public int int_0;
  public int int_1;
  public Decimal decimal_0;
  public bool bool_0;

  public string ViewingName { get; set; }

  public GClass220(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public string method_0()
  {
    return this.bool_0 ? $"{this.gclass162_0.ShortName} {GClass226.smethod_39((this.decimal_0 - 1M) * 100M)}%" : "Dormant Construct";
  }
}
