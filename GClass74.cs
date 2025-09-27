// Decompiled with JetBrains decompiler
// Type: GClass74
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class GClass74
{
    public int int_0;
    public GClass22 gclass22_0;

    public string Combined { get; set; }

    public string method_0()
    {
        return
            $"{this.int_0.ToString()}x {this.gclass22_0.ClassName} {this.gclass22_0.gclass76_0.Description}   Speed: {this.gclass22_0.int_32.ToString()} km/s    Size: {AuroraUtils.FormatNumberToDigits(this.gclass22_0.decimal_14, 2)}{Environment.NewLine}";
    }
}