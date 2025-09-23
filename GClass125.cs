// Decompiled with JetBrains decompiler
// Type: GClass125
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;

#nullable disable
public class GClass125
{
  public AuroraElement auroraElement_0;
  public Decimal decimal_0;

  public GClass125()
  {
  }

  public GClass125(AuroraElement auroraElement_1, Decimal decimal_1)
  {
    this.auroraElement_0 = auroraElement_1;
    this.decimal_0 = decimal_1;
  }

  public string method_0() => GClass226.smethod_42(this.decimal_0, 0).ToString();
}
