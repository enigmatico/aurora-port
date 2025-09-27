// Decompiled with JetBrains decompiler
// Type: GClass170
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class GClass170
{
    public Decimal decimal_0;
    public double double_0;

    public string DisplayText { get; set; }

    public GClass170(string string_1, Decimal decimal_1)
    {
        this.DisplayText = string_1;
        this.decimal_0 = decimal_1;
    }

    public GClass170(string string_1, Decimal decimal_1, double double_1)
    {
        this.DisplayText = string_1;
        this.decimal_0 = decimal_1;
        this.double_0 = double_1;
    }
}