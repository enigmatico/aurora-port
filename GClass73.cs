// Decompiled with JetBrains decompiler
// Type: GClass73
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class GClass73
{
  public GClass230 gclass230_0;
  public GClass146 gclass146_0;
  public int int_0;
  public Decimal decimal_0;
  public bool bool_0;

  public string Combined { get; set; }

  public string method_0()
  {
    return $"{this.decimal_0.ToString()}x {this.gclass230_0.Name}{Environment.NewLine}";
  }
}
