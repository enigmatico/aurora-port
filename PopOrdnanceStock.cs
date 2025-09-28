// Decompiled with JetBrains decompiler
// Type: GClass130
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class PopOrdnanceStock
{
    public int Amount;
    public RaceMissile RaceMissile;

    public string Combined { get; set; }

    public PopOrdnanceStock method_0()
    {
        PopOrdnanceStock gclass130 = new PopOrdnanceStock();
        return (PopOrdnanceStock)this.MemberwiseClone();
    }

    public string method_1()
    {
        Decimal num = this.RaceMissile.Speed * AuroraUtils.int_9 * this.RaceMissile.ATG;
        Decimal decimal_73_1 = this.RaceMissile.method_1(100M);
        Decimal decimal_73_2 = this.RaceMissile.method_1(50M);
        Decimal decimal_73_3 = this.RaceMissile.method_1(25M);
        string str =
            $"    TH: {AuroraUtils.smethod_39(decimal_73_1)} / {AuroraUtils.smethod_39(decimal_73_2)} / {AuroraUtils.smethod_39(decimal_73_3)}";
        return this.RaceMissile.GroundShots > 0M
            ? $"{this.RaceMissile.Name} ({this.Amount.ToString()})    Armour Penetration: {this.RaceMissile.GroundAP.ToString()}     Damage: {this.RaceMissile.GroundDamage.ToString()}     Shots: {this.RaceMissile.GroundShots.ToString()}{Environment.NewLine}"
            : (this.RaceMissile.ShipDecoy == 1
                ? $"{this.RaceMissile.Name} ({this.Amount.ToString()})    Signature: {this.RaceMissile.WarheadStrength.ToString()} tons    ECM-{this.RaceMissile.MissileECM.ToString()}    Size: {this.RaceMissile.Size.ToString()}{Environment.NewLine}"
                : (this.RaceMissile.TotalFlightTime > 86400M
                    ? $"{this.RaceMissile.Name} ({this.Amount.ToString()})    Speed: {AuroraUtils.smethod_38(this.RaceMissile.Speed)} km/s    End: {AuroraUtils.FormatNumberToDigits(this.RaceMissile.TotalFlightTime / 86400M, 1)}d     Range: {AuroraUtils.FormatDoubleToPrecision(this.RaceMissile.CombinatedMaxRange / 1000000.0, 1)}m km    WH: {this.RaceMissile.WarheadStrength.ToString()}    Size: {this.RaceMissile.Size.ToString()}{str}{Environment.NewLine}"
                    : $"{this.RaceMissile.Name} ({this.Amount.ToString()})    Speed: {AuroraUtils.smethod_38(this.RaceMissile.Speed)} km/s    End: {AuroraUtils.FormatNumberToDigits(this.RaceMissile.TotalFlightTime / 60M, 1)}m     Range: {AuroraUtils.FormatDoubleToPrecision(this.RaceMissile.CombinatedMaxRange / 1000000.0, 1)}m km    WH: {this.RaceMissile.WarheadStrength.ToString()}    Size: {this.RaceMissile.Size.ToString()}{str}{Environment.NewLine}"));
    }
}