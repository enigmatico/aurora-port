// Decompiled with JetBrains decompiler
// Type: GClass130
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class ShipOrdnance
{
    public int Amount;
    public RaceMissile RaceMissile;

    public string Combined { get; set; }

    public ShipOrdnance method_0()
    {
        ShipOrdnance gclass130 = new ShipOrdnance();
        return (ShipOrdnance)this.MemberwiseClone();
    }

    public string method_1()
    {
        Decimal num = this.RaceMissile.Speed * AuroraUtils.int_9 * this.RaceMissile.ATG;
        Decimal decimal_73_1 = this.RaceMissile.method_1(100M);
        Decimal decimal_73_2 = this.RaceMissile.method_1(50M);
        Decimal decimal_73_3 = this.RaceMissile.method_1(25M);
        string str =
            string.Format("    TH: {0} / {1} / {2}", AuroraUtils.smethod_39(decimal_73_1),
                AuroraUtils.smethod_39(decimal_73_2), AuroraUtils.smethod_39(decimal_73_3));
        return this.RaceMissile.GroundShots > 0M
            ? string.Format("{0} ({1})    Armour Penetration: {2}     Damage: {3}     Shots: {4}{5}",
                this.RaceMissile.Name, this.Amount.ToString(), this.RaceMissile.GroundAP.ToString(),
                this.RaceMissile.GroundDamage.ToString(), this.RaceMissile.GroundShots.ToString(), Environment.NewLine)
            : (this.RaceMissile.ShipDecoy == 1
                ? string.Format("{0} ({1})    Signature: {2} tons    ECM-{3}    Size: {4}{5}", this.RaceMissile.Name,
                    this.Amount.ToString(), this.RaceMissile.WarheadStrength.ToString(),
                    this.RaceMissile.MissileECM.ToString(), this.RaceMissile.Size.ToString(), Environment.NewLine)
                : (this.RaceMissile.TotalFlightTime > 86400M
                    ? string.Format(
                        "{0} ({1})    Speed: {2} km/s    End: {3}d     Range: {4}m km    WH: {5}    Size: {6}{7}{8}",
                        this.RaceMissile.Name, this.Amount.ToString(), AuroraUtils.smethod_38(this.RaceMissile.Speed),
                        AuroraUtils.FormatNumberToDigits(this.RaceMissile.TotalFlightTime / 86400M, 1),
                        AuroraUtils.FormatDoubleToPrecision(this.RaceMissile.CombinatedMaxRange / 1000000.0, 1),
                        this.RaceMissile.WarheadStrength.ToString(), this.RaceMissile.Size.ToString(), str,
                        Environment.NewLine)
                    : string.Format(
                        "{0} ({1})    Speed: {2} km/s    End: {3}m     Range: {4}m km    WH: {5}    Size: {6}{7}{8}",
                        this.RaceMissile.Name, this.Amount.ToString(), AuroraUtils.smethod_38(this.RaceMissile.Speed),
                        AuroraUtils.FormatNumberToDigits(this.RaceMissile.TotalFlightTime / 60M, 1),
                        AuroraUtils.FormatDoubleToPrecision(this.RaceMissile.CombinatedMaxRange / 1000000.0, 1),
                        this.RaceMissile.WarheadStrength.ToString(), this.RaceMissile.Size.ToString(), str,
                        Environment.NewLine)));
    }
}