// Decompiled with JetBrains decompiler
// Type: GClass130
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class GClass130
{
  public int int_0;
  public GClass129 gclass129_0;

  public string Combined { get; set; }

  public GClass130 method_0()
  {
    GClass130 gclass130 = new GClass130();
    return (GClass130) this.MemberwiseClone();
  }

  public string method_1()
  {
    Decimal num = this.gclass129_0.decimal_5 * (Decimal) GClass226.int_9 * this.gclass129_0.decimal_26;
    Decimal decimal_73_1 = this.gclass129_0.method_1(100M);
    Decimal decimal_73_2 = this.gclass129_0.method_1(50M);
    Decimal decimal_73_3 = this.gclass129_0.method_1(25M);
    string str = $"    TH: {GClass226.smethod_39(decimal_73_1)} / {GClass226.smethod_39(decimal_73_2)} / {GClass226.smethod_39(decimal_73_3)}";
    return this.gclass129_0.decimal_19 > 0M ? $"{this.gclass129_0.Name} ({this.int_0.ToString()})    Armour Penetration: {this.gclass129_0.decimal_17.ToString()}     Damage: {this.gclass129_0.decimal_18.ToString()}     Shots: {this.gclass129_0.decimal_19.ToString()}{Environment.NewLine}" : (this.gclass129_0.int_14 == 1 ? $"{this.gclass129_0.Name} ({this.int_0.ToString()})    Signature: {this.gclass129_0.decimal_0.ToString()} tons    ECM-{this.gclass129_0.int_12.ToString()}    Size: {this.gclass129_0.decimal_4.ToString()}{Environment.NewLine}" : (this.gclass129_0.decimal_22 > 86400M ? $"{this.gclass129_0.Name} ({this.int_0.ToString()})    Speed: {GClass226.smethod_38(this.gclass129_0.decimal_5)} km/s    End: {GClass226.smethod_42(this.gclass129_0.decimal_22 / 86400M, 1)}d     Range: {GClass226.smethod_44(this.gclass129_0.double_4 / 1000000.0, 1)}m km    WH: {this.gclass129_0.decimal_0.ToString()}    Size: {this.gclass129_0.decimal_4.ToString()}{str}{Environment.NewLine}" : $"{this.gclass129_0.Name} ({this.int_0.ToString()})    Speed: {GClass226.smethod_38(this.gclass129_0.decimal_5)} km/s    End: {GClass226.smethod_42(this.gclass129_0.decimal_22 / 60M, 1)}m     Range: {GClass226.smethod_44(this.gclass129_0.double_4 / 1000000.0, 1)}m km    WH: {this.gclass129_0.decimal_0.ToString()}    Size: {this.gclass129_0.decimal_4.ToString()}{str}{Environment.NewLine}"));
  }
}
