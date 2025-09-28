// Decompiled with JetBrains decompiler
// Type: GClass36
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
public class FireControlAssignment
{
    [CompilerGenerated]
    private sealed class Class792
    {
        public WeaponFireControlAssignment gclass31_0;

        internal bool method_0(MissileAssignment gclass30_0)
        {
            return gclass30_0.FiringWeaponComponent == this.gclass31_0.WeaponComponent && gclass30_0.WeaponNum == this.gclass31_0.WeaponNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class793
    {
        public GameRace gclass21_0;
        public MissileSalvo gclass132_0;

        internal bool method_0(MissileSalvo gclass132_1)
        {
            return gclass132_1.Race == this.gclass21_0 && gclass132_1.TargetSalvo == this.gclass132_0;
        }
    }

    private GClass0 gclass0_0;
    public ShipData Ship;
    public ShipComponent FCComponent;
    public AuroraContactType TargetContactType;
    public AuroraPointDefenceMode PointDefenceMode;
    public AuroraPointDefencePriority PointDefencePriority = AuroraPointDefencePriority.PriorityThree;

    public AuroraPointDefenceConcentration PointDefenceConcentration =
        AuroraPointDefenceConcentration.ThreeShots;

    public int FCNum;
    public int TargetID;
    public int int_2;
    public bool IsOpeningFire;
    public bool HasFiredThisPhase;
    public bool NodeViewExpanded;
    public double MinimumAMMRange;

    public FireControlAssignment(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public FireControlAssignment method_0()
    {
        try
        {
            return (FireControlAssignment)this.MemberwiseClone();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 291);
            return null;
        }
    }

    public string method_1(ShipData gclass40_1)
    {
        try
        {
            string str = "";
            double num = this.method_3(gclass40_1);
            return num >= 1000000.0
                ? (num >= 10000000.0
                    ? (num >= 100000000.0
                        ? string.Format("{0}  (Max {1}m km)", str, AuroraUtils.smethod_43(num / 1000000.0))
                        : string.Format("{0}  (Max {1}m km)", str,
                            AuroraUtils.FormatDoubleToPrecision(num / 1000000.0, 1)))
                    : string.Format("{0}  (Max {1}m km)", str, AuroraUtils.FormatDoubleToPrecision(num / 1000000.0, 2)))
                : string.Format("{0}  (Max {1}k km)", str, AuroraUtils.smethod_43(num / 1000.0));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 292);
            return "error";
        }
    }

    public double method_2(FleetData gclass85_0)
    {
        try
        {
            if (this.TargetContactType == AuroraContactType.Ship)
            {
                if (!this.gclass0_0.Ships.ContainsKey(this.TargetID))
                    return -1.0;
                FleetData gclass850 = this.gclass0_0.Ships[this.TargetID].gclass85_0;
                return this.gclass0_0.GetDistanceBetween(gclass85_0.XCoord, gclass85_0.YCoord, gclass850.XCoord,
                    gclass850.YCoord);
            }

            if (this.TargetContactType == AuroraContactType.Salvo)
            {
                if (!this.gclass0_0.MissileSalvoes.ContainsKey(this.TargetID))
                    return -1.0;
                MissileSalvo gclass132 = this.gclass0_0.MissileSalvoes[this.TargetID];
                return this.gclass0_0.GetDistanceBetween(gclass85_0.XCoord, gclass85_0.YCoord, gclass132.Xcor,
                    gclass132.Ycor);
            }

            if (this.TargetContactType != AuroraContactType.Population &&
                this.TargetContactType != AuroraContactType.GroundUnit &&
                this.TargetContactType != AuroraContactType.STOGroundUnit &&
                this.TargetContactType != AuroraContactType.Shipyard)
                return 0.0;
            if (!this.gclass0_0.Populations.ContainsKey(this.TargetID))
                return -1.0;
            PopulationData gclass146 = this.gclass0_0.Populations[this.TargetID];
            return this.gclass0_0.GetDistanceBetween(gclass85_0.XCoord, gclass85_0.YCoord, gclass146.method_87(),
                gclass146.method_88());
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 293);
            return 0.0;
        }
    }

    public double method_3(ShipData gclass40_1)
    {
        try
        {
            double num1 = 0.0;
            if (this.FCComponent.Data.ComponentTypeID == AuroraComponentType.MissileFireControl)
            {
                if (this.TargetContactType == AuroraContactType.Ship)
                {
                    if (this.gclass0_0.Ships.ContainsKey(this.TargetID))
                        num1 = this.method_4(gclass40_1, this.gclass0_0.Ships[this.TargetID],
                            this.FCComponent);
                }
                else if (this.TargetContactType == AuroraContactType.Salvo)
                {
                    if (this.gclass0_0.MissileSalvoes.ContainsKey(this.TargetID))
                        num1 = this.method_5(gclass40_1, this.gclass0_0.MissileSalvoes[this.TargetID].RaceMissile,
                            this.FCComponent);
                }
                else
                    num1 = this.FCComponent.double_0;
            }
            else
                num1 = (double)this.FCComponent.decimal_3;

            if (num1 == 0.0)
                return 0.0;
            List<WeaponFireControlAssignment> list = gclass40_1.list_2.Where<WeaponFireControlAssignment>(gclass31_0 =>
                gclass31_0.FireControlComponent == this.FCComponent && gclass31_0.FireControlNum == this.FCNum).ToList<WeaponFireControlAssignment>();
            if (list.Count == 0)
                return 0.0;
            double num2 = 0.0;
            foreach (WeaponFireControlAssignment gclass31 in list)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FireControlAssignment.Class792 class792 = new FireControlAssignment.Class792();
                // ISSUE: reference to a compiler-generated field
                class792.gclass31_0 = gclass31;
                // ISSUE: reference to a compiler-generated method
                MissileAssignment gclass30 = gclass40_1.FiredMissiles.Where<MissileAssignment>(class792.method_0).FirstOrDefault<MissileAssignment>();
                if (gclass30 != null)
                {
                    if (gclass30.Missile.CombinatedMaxRange > num2)
                        num2 = gclass30.Missile.CombinatedMaxRange;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    if (class792.gclass31_0.WeaponComponent.Data.ComponentTypeID !=
                        AuroraComponentType.MissileLauncher)
                    {
                        // ISSUE: reference to a compiler-generated field
                        int num3 = class792.gclass31_0.WeaponComponent.int_8;
                        if (num3 == 0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            num3 = (int)(class792.gclass31_0.WeaponComponent.int_6 *
                                         class792.gclass31_0.WeaponComponent.decimal_17);
                        }

                        if (num3 > num2)
                            num2 = num3;
                    }
                }
            }

            if (num2 < num1)
                num1 = num2;
            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 294);
            return 0.0;
        }
    }

    public double method_4(ShipData gclass40_1, ShipData gclass40_2, ShipComponent gclass230_1)
    {
        try
        {
            double num1 = 1.0;
            if (gclass230_1.Resolution > gclass40_2.method_51())
                num1 = Math.Pow((double)gclass40_2.method_51() / (double)gclass230_1.Resolution, 2.0);
            Decimal decimal_29 = gclass40_2.method_156(AuroraJammerType.Sensor);
            if (decimal_29 > 0M)
                gclass40_1.Race.method_35(gclass40_2, AuroraJammerType.Sensor, decimal_29);
            if (gclass230_1.decimal_13 >= decimal_29)
                return gclass230_1.double_0 * num1;
            double num2 = Math.Pow(0.75, (double)(decimal_29 - gclass230_1.decimal_13));
            return gclass230_1.double_0 * num1 * num2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 295);
            return 0.0;
        }
    }

    public double method_5(ShipData gclass40_1, RaceMissile gclass129_0, ShipComponent gclass230_1)
    {
        try
        {
            double num1 = 1.0;
            double num2 = (double)gclass129_0.Size;
            if (num2 < 0.33)
                num2 = 0.33;
            if ((double)gclass230_1.Resolution > num2)
                num1 = Math.Pow(num2 / (double)gclass230_1.Resolution, 2.0);
            return gclass230_1.double_0 * num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 296);
            return 0.0;
        }
    }

    public double method_6(ShipData gclass40_1, int int_3, ShipComponent gclass230_1)
    {
        try
        {
            if (int_3 == 0)
                return 1.0;
            if (gclass230_1.decimal_13 > 0M)
            {
                int_3 -= (int)gclass230_1.decimal_13;
                if (int_3 <= 0)
                    return 1.0;
            }

            return Math.Pow(0.75, int_3);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 297);
            return 0.0;
        }
    }

    public int method_7(GameRace gclass21_0, MissileSalvo gclass132_0_1)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FireControlAssignment.Class793 class793 = new FireControlAssignment.Class793();
        // ISSUE: reference to a compiler-generated field
        class793.gclass21_0 = gclass21_0;
        // ISSUE: reference to a compiler-generated field
        class793.gclass132_0 = gclass132_0_1;
        try
        {
            int num1 = 0;
            if (this.PointDefenceMode == AuroraPointDefenceMode.FiveMissilesPerTarget)
                num1 = 5;
            if (this.PointDefenceMode == AuroraPointDefenceMode.FourMissilesPerTarget)
                num1 = 4;
            if (this.PointDefenceMode == AuroraPointDefenceMode.ThreeMissilesPerTarget)
                num1 = 3;
            if (this.PointDefenceMode == AuroraPointDefenceMode.TwoMissilesPerTarget)
                num1 = 2;
            if (this.PointDefenceMode == AuroraPointDefenceMode.OneMissilePerTarget)
                num1 = 1;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            int num2 = num1 * class793.gclass132_0.RemainingDecoys.Count - this.gclass0_0.MissileSalvoes.Values
                .Where<MissileSalvo>(class793.method_0)
                .Select<MissileSalvo, int>(gclass132_0_2 => gclass132_0_2.RemainingDecoys.Count).DefaultIfEmpty<int>(0).Sum();
            if (num2 < 0)
                num2 = 0;
            return num2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 298);
            return 0;
        }
    }
}