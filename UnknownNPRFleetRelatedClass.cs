// Decompiled with JetBrains decompiler
// Type: GClass4
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
public class UnknownNPRFleetRelatedClass
{
    #region CompilerGenerated

    [CompilerGenerated]
    private sealed class Class475
    {
        public Decimal decimal_0;

        internal double method_0(ShipData gclass40_0)
        {
            return gclass40_0.method_218(this.decimal_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class476
    {
        public UnknownNPRFleetRelatedClass gclass4_0;
        public ShipClass gclass22_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass4_0.Fleet &&
                   gclass40_0.gclass22_0.AutomatedClassDesign == this.gclass22_0.AutomatedClassDesign;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass4_0.Fleet.Race;
        }

        internal bool method_2(MoveOrder gclass139_0)
        {
            return gclass139_0.MoveActionType.MoveActionType == MoveActionType.JoinFleet &&
                   gclass139_0.DestinationID == this.gclass4_0.Fleet.FleetID;
        }

        internal bool method_3(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0.AutomatedClassDesign == this.gclass22_0.AutomatedClassDesign;
        }
    }

    [CompilerGenerated]
    private sealed class Class477
    {
        public Decimal decimal_0;

        internal double method_0(ShipData gclass40_0)
        {
            return gclass40_0.method_216(this.decimal_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class478
    {
        public RaceOperationalGroupElement gclass11_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass5_0.genum103_0 != GEnum103.const_4 && gclass40_0.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID ==
                this.gclass11_0.AutomatedClassDesign.AutomatedClassDesignTypeID;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID == this.gclass11_0.AutomatedClassDesign.AutomatedClassDesignTypeID;
        }
    }

    #endregion

    private GClass0 Game;
    private FleetData Fleet;
    public ShipData gclass40_0;
    public GEnum100 genum100_0;
    public GEnum101 genum101_0 = GEnum101.const_3;
    public GEnum103 genum103_0 = GEnum103.const_3;
    public GEnum102 genum102_0 = GEnum102.const_3;
    public RacialSystemSurvey gclass202_0;
    public int int_0;
    public double double_0 = -1.0;
    public bool bool_0;
    public bool bRedeployOrderGiven;
    public bool bool_2;
    public bool bool_3;
    public bool bool_4;

    public UnknownNPRFleetRelatedClass(GClass0 gclass0_1, FleetData gclass85_1)
    {
        this.Game = gclass0_1;
        this.Fleet = gclass85_1;
    }

    public void method_0()
    {
        try
        {
            List<ShipData> source = this.Fleet.method_176();
            if (this.Fleet.ShippingLine != null)
                this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.Civilian];
            else if (this.Fleet.method_125(AuroraComponentType.GravitationalSurveySensors) > 0M)
                this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.GravitationalSurvey];
            else if (this.Fleet.method_125(AuroraComponentType.GeologicalSurveySensors) > 0M)
                this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.GeologicalSurvey];
            else if (this.Fleet.method_125(AuroraComponentType.TerraformingModule) > 0M)
                this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.TerraFormerGroup];
            else if (this.Fleet.method_125(AuroraComponentType.SoriumHarvester) > 0M)
                this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.HarvesterGroup];
            else if (this.Fleet.method_125(AuroraComponentType.SalvageModule) > 0M)
                this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.SalvageSquadron];
            else if (this.Fleet.method_125(AuroraComponentType.JumpPointStabilisation) > 0M)
                this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.StabilisationSquadron];
            else if (this.Fleet.method_125(AuroraComponentType.OrbitalMiningModule) > 0M)
                this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.OrbitalMinerGroup];
            else if (this.Fleet.method_125(AuroraComponentType.DiplomacyModule) > 0M)
                this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.DiplomaticShip];
            else if (!(this.Fleet.method_125(AuroraComponentType.MissileFireControl) > 0M) &&
                     !(this.Fleet.method_125(AuroraComponentType.BeamFireControl) > 0M))
            {
                if (this.Fleet.method_125(AuroraComponentType.RefuellingSystem) > 0M)
                    this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.Tanker];
                else if (this.Fleet.method_125(AuroraComponentType.TroopTransport) > 0M)
                    this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.TroopTransportGroup];
                else if (source.Count == 1)
                {
                    if (source
                            .SelectMany<ShipData,
                                GClass228>(gclass40_0 => gclass40_0.gclass22_0.dictionary_0.Values)
                            .Count<GClass228>(gclass228_0 =>
                                gclass228_0.gclass230_0.gclass231_0.ComponentTypeID ==
                                AuroraComponentType.ActiveSearchSensors && gclass228_0.gclass230_0.decimal_1 >= 3M) <=
                        0)
                        return;
                    this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.Scout];
                }
                else
                {
                    this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.ReinforcementGroup];
                    if (source.Count <= 1)
                        return;
                    foreach (ShipData gclass40_0 in source)
                    {
                        this.Fleet.method_75(gclass40_0, OperationalGroupID.ReinforcementGroup, false);
                        if (source.Count == 1)
                            break;
                    }
                }
            }
            else
            {
                Decimal num1 = this.Fleet.method_125(AuroraComponentType.MissileFireControl);
                Decimal num2 = this.Fleet.method_125(AuroraComponentType.BeamFireControl);
                Decimal num3 = source.Sum<ShipData>(gclass40_0 =>
                    gclass40_0.gclass22_0.Size * AuroraUtils.decimal_17);
                Decimal num4 = num2;
                if (num1 > num4)
                {
                    if (this.Fleet.method_125(AuroraComponentType.Engine) == 0M)
                        this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.OribitalMissileBase];
                    else if (num3 < 30000M)
                        this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.FACHunterSquadron];
                    else if (num3 < 60000M)
                        this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.MissileBattleSquadron];
                    else
                        this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.MissileBattleFleet];
                }
                else
                {
                    if (!(num2 > 0M))
                        return;
                    if (this.Fleet.method_125(AuroraComponentType.Engine) == 0M)
                        this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.OrbitalDefencesBeamOnly];
                    else if (num3 < 30000M)
                        this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.BeamOnlyDDSquadron];
                    else if (num3 < 60000M)
                        this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.BeamOnlyBattleSquadron];
                    else
                        this.Fleet.NPROperationGroup = this.Game.OperationalGroupDictionary[OperationalGroupID.BeamOnlyBattleFleet];
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3398);
        }
    }

    public void method_1(List<GClass117> list_0)
    {
        try
        {
            FleetData fleet = list_0.Select<GClass117, FleetData>(gclass117_0 => gclass117_0.gclass40_0.gclass85_0)
                .Distinct<FleetData>().OrderBy<FleetData, double>(gclass85_1 =>
                    this.Game.GetDistanceToNearestGClass212(this.Fleet.System.ActualSystem, gclass85_1.XCoord,
                        gclass85_1.YCoord, this.Fleet.XCoord, this.Fleet.YCoord))
                .FirstOrDefault<FleetData>();
            if (fleet == null)
                return;
            this.Fleet.method_263();
            this.Fleet.method_229(fleet);
            this.Fleet.NPRSomething.bRedeployOrderGiven = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 81);
        }
    }

    public Decimal method_2()
    {
        try
        {
            return this.genum100_0 == GEnum100.const_0 ? 0M : (int)this.genum100_0 / 4M;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 82);
            return 0M;
        }
    }

    public void method_3()
    {
        try
        {
            List<ShipData> list = this.Fleet.method_176()
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass22_0.ActiveSensorStrength > 0).ToList<ShipData>();
            foreach (ShipData gclass40 in list)
                gclass40.bool_8 = false;
            this.method_4(list);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 83);
        }
    }

    public void method_4(List<ShipData> list_0)
    {
        try
        {
            foreach (Decimal num in list_0
                         .SelectMany<ShipData,
                             GClass228>(gclass40_0 => gclass40_0.gclass22_0.dictionary_0.Values)
                         .Where<GClass228>(gclass228_0 =>
                             gclass228_0.gclass230_0.gclass231_0.ComponentTypeID ==
                             AuroraComponentType.ActiveSearchSensors)
                         .Select<GClass228, Decimal>(gclass228_0 => gclass228_0.gclass230_0.decimal_6)
                         .Distinct<Decimal>().ToList<Decimal>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                List<ShipData> list = list_0.OrderByDescending<ShipData, double>(new UnknownNPRFleetRelatedClass.Class475()
                {
                    decimal_0 = num
                }.method_0).ThenBy<ShipData, Decimal>(gclass40_0 => gclass40_0.decimal_1).ToList<ShipData>();
                if (list.Count != 0)
                {
                    list[0].bool_8 = true;
                    if (list.Count > 1)
                        list[1].bool_8 = true;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 84);
        }
    }

    public void method_5()
    {
        try
        {
            if (this.Fleet.MoveOrderDictionary.Count == 0)
            {
                this.gclass202_0 = null;
                this.Fleet.NPRSomething.bRedeployOrderGiven = false;
            }
            else
            {
                MoveOrder gclass139 = this.Fleet.MoveOrderDictionary.Values
                    .OrderByDescending<MoveOrder, int>(gclass139_0 => gclass139_0.OrderValue).FirstOrDefault<MoveOrder>();
                if (gclass139.NewSystem != null)
                    this.gclass202_0 = gclass139.NewSystem;
                else
                    this.gclass202_0 = gclass139.StartSystem;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 85);
        }
    }

    public void method_6()
    {
        try
        {
            this.Fleet.StandingOrdersDictionary.Clear();
            this.Fleet.method_1(1, this.Fleet.NPROperationGroup.gclass136_0);
            this.Fleet.method_1(2, this.Fleet.NPROperationGroup.gclass136_1);
            this.Fleet.MaxStandingOrderDistance = AuroraUtils.long_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 87);
        }
    }

    public bool method_7()
    {
        try
        {
            return this.Fleet.NPROperationGroup.bool_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 88);
            return false;
        }
    }

    public bool method_8(ShipClass gclass22_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRFleetRelatedClass.Class476 class476 = new UnknownNPRFleetRelatedClass.Class476();
        // ISSUE: reference to a compiler-generated field
        class476.gclass4_0 = this;
        // ISSUE: reference to a compiler-generated field
        class476.gclass22_0 = gclass22_0;
        try
        {
            // ISSUE: reference to a compiler-generated field
            int num = this.Fleet.NPROperationGroup.method_2(this.Fleet.Race, class476.gclass22_0.AutomatedClassDesign);
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return num != 0 &&
                   this.Game.Ships.Values.Where<ShipData>(class476.method_0)
                       .Count<ShipData>() + this.Game.FleetDictionary.Values.Where<FleetData>(class476.method_1)
                       .Where<FleetData>(gclass85_0 => gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_11)
                       .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                       .Where<MoveOrder>(class476.method_2)
                       .SelectMany<MoveOrder, ShipData>(gclass139_0 => gclass139_0.Fleet.method_176())
                       .Where<ShipData>(class476.method_3).Count<ShipData>() < num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 89);
            return false;
        }
    }

    public bool method_9(GClass117 gclass117_0, List<PopulationData> list_0)
    {
        try
        {
            double num1 = -1.0;
            ShipData gclass40 = null;
            if (gclass117_0 == null)
                return false;
            if (this.Fleet.method_25())
            {
                this.Fleet.method_230(gclass117_0);
                return true;
            }

            if (gclass40 == null)
                gclass40 = this.method_15(gclass117_0.gclass40_0.method_51());
            if (num1 == -1.0)
                num1 = this.Fleet.method_159();
            if (gclass40 == null && num1 <= 0.0)
                return false;
            double num2 = 0.0;
            if (gclass40 != null)
            {
                double num3 = gclass40.gclass5_0.double_1 / (double)gclass40.gclass5_0.gclass129_0.Speed;
                double num4 = gclass117_0.gclass115_0.int_2 * num3;
                num2 = gclass40.gclass5_0.double_1 - num4;
            }
            else if (num1 > 0.0)
            {
                double num5 = gclass117_0.gclass115_0.method_7();
                if (num1 > num5 * 1.2)
                    num2 = num5 * 1.2;
                else if (num1 > num5 * 1.1)
                    num2 = num5 * 1.1;
            }

            this.Fleet.method_263();
            if (list_0.Count > 0)
            {
                GClass221 gclass221_0 = this.Game.method_53(DestinationType.const_7,
                    gclass117_0.gclass40_0.gclass85_0.FleetID, gclass117_0.gclass40_0.gclass85_0.System.ActualSystem,
                    null, this.Fleet, num2, 0M);
                if ((gclass221_0.double_0 != 0.0 || gclass221_0.double_1 != 0.0) && this.method_10(gclass221_0, list_0))
                    return true;
            }

            this.Fleet.method_225(gclass117_0, (int)num2);
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 90);
            return false;
        }
    }

    public bool method_10(GClass221 gclass221_0, List<PopulationData> list_0)
    {
        try
        {
            bool flag1 = false;
            int num1 = 0;
            GClass221 gclass221 = new GClass221(gclass221_0.double_0, gclass221_0.double_1);
            double double_11 = this.Game.method_591(gclass221.double_0, gclass221.double_1,
                this.Fleet.XCoord, this.Fleet.YCoord);
            if (this.Fleet.int_9 <= 0)
            {
                this.Fleet.bool_22 = AuroraUtils.smethod_23();
                this.Fleet.int_9 = 86400;
            }

            while (true)
            {
                bool flag2 = false;
                foreach (PopulationData gclass146 in list_0)
                {
                    double num2 = this.Game.GetDistanceBetween(gclass146.method_87(), gclass146.method_88(),
                        this.Fleet.XCoord, this.Fleet.YCoord);
                    double num3 = this.Game.method_517(gclass146.method_87(), gclass146.method_88(),
                        this.Fleet.XCoord, this.Fleet.YCoord, gclass221.double_0, gclass221.double_1);
                    if (num3 < 500000.0 && num3 < num2)
                    {
                        flag2 = true;
                        break;
                    }
                }

                if (flag2)
                {
                    ++num1;
                    if (num1 != 36)
                    {
                        if (this.Fleet.bool_22)
                        {
                            double_11 += 10.0;
                            if (double_11 >= 360.0)
                                double_11 -= 360.0;
                        }
                        else
                        {
                            double_11 -= 10.0;
                            if (double_11 <= 360.0)
                                double_11 += 360.0;
                        }

                        gclass221 = this.Game.method_592(this.Fleet.XCoord, this.Fleet.YCoord,
                            100000000.0, double_11);
                    }
                    else
                        goto label_18;
                }
                else
                    break;
            }

            if (num1 > 0)
                flag1 = true;
            label_18:
            if (!flag1)
                return false;
            Waypoint gclass214_0 = this.Fleet.Race.method_188(this.Fleet.System.ActualSystem, null,
                null, WayPointType.Temporary, gclass221.double_0, gclass221.double_1,
                this.Fleet.FleetName + " Manoeuvre Point", 0);
            this.Fleet.method_263();
            this.Fleet.method_217(gclass214_0, MoveActionType.MoveTo, this.Fleet.System);
            this.Fleet.NPRSomething.bRedeployOrderGiven = true;
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3885);
            return false;
        }
    }

    public bool method_11(GClass117 gclass117_0)
    {
        try
        {
            if (gclass117_0 == null)
                return false;
            double double_11 = this.Fleet.NPRSomething.method_16(gclass117_0.gclass40_0.method_51()) * 0.95;
            this.Fleet.method_263();
            this.Fleet.method_225(gclass117_0, (int)double_11);
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 91);
            return false;
        }
    }

    public bool method_12(ShipData gclass40_1)
    {
        try
        {
            if (gclass40_1 == null)
                return false;
            double double_11 = this.Fleet.NPRSomething.method_16(gclass40_1.method_51()) * 0.95;
            this.Fleet.method_226(gclass40_1, (int)double_11);
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 92);
            return false;
        }
    }

    public void method_13()
    {
        try
        {
            if (!this.method_18(this.Fleet.method_176()))
                return;
            PopulationData gclass146_1 = this.Fleet.method_164();
            if (gclass146_1 == null)
                return;
            this.Fleet.method_219(gclass146_1, MoveActionType.LoadOrdnanceFromColony);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 93);
        }
    }

    public ShipData method_14(Decimal decimal_0)
    {
        try
        {
            List<ShipData> source = this.Fleet.method_176();
            foreach (ShipData gclass40 in source)
                gclass40.gclass5_0.method_13(decimal_0, false);
            return source.Where<ShipData>(gclass40_0 => gclass40_0.gclass5_0.double_1 > 0.0)
                .OrderByDescending<ShipData, double>(gclass40_0 => gclass40_0.gclass5_0.double_1)
                .FirstOrDefault<ShipData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 94);
            return null;
        }
    }

    public ShipData method_15(Decimal decimal_0)
    {
        try
        {
            List<ShipData> source = this.Fleet.method_176();
            foreach (ShipData gclass40 in source)
                gclass40.gclass5_0.method_13(decimal_0, true);
            return source.Where<ShipData>(gclass40_0 => gclass40_0.gclass5_0.double_1 > 0.0)
                .OrderBy<ShipData, double>(gclass40_0 => gclass40_0.gclass5_0.double_1)
                .FirstOrDefault<ShipData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 95);
            return null;
        }
    }

    public double method_16(Decimal decimal_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRFleetRelatedClass.Class477 class477 = new UnknownNPRFleetRelatedClass.Class477();
        // ISSUE: reference to a compiler-generated field
        class477.decimal_0 = decimal_0;
        try
        {
            List<ShipData> source = this.Fleet.method_176();
            // ISSUE: reference to a compiler-generated method
            return source.Count == 0 ? 0.0 : source.Max<ShipData>(class477.method_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 96 /*0x60*/);
            return 0.0;
        }
    }

    public void method_17()
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            UnknownNPRFleetRelatedClass.Class478 class478 = new UnknownNPRFleetRelatedClass.Class478();
            // ISSUE: reference to a compiler-generated field
            class478.gclass11_0 = this.Fleet.NPROperationGroup.method_1(this.Fleet.Race);
            List<ShipData> source = this.Fleet.method_176();
            if (this.Fleet.Race.SpecialNPRID == SpecialNPRIDs.StarSwarm)
            {
                this.genum101_0 = GEnum101.const_3;
                this.genum103_0 = GEnum103.const_4;
            }
            else
            {
                double num1 = 0.0;
                foreach (ShipData gclass40 in source)
                    num1 += (double)gclass40.gclass5_0.genum101_0;
                if (num1 == 0.0)
                {
                    this.genum101_0 = GEnum101.const_0;
                    this.genum100_0 = GEnum100.const_0;
                }
                else
                {
                    double num2 = num1 / source.Count;
                    this.genum101_0 =
                        num2 <= 2.5 ? (num2 <= 1.5 ? GEnum101.const_1 : GEnum101.const_2) : GEnum101.const_3;
                }

                double num3 = 0.0;
                double num4 = 0.0;
                this.genum103_0 = GEnum103.const_4;
                List<ShipData> list = source
                    .Where<ShipData>(gclass40_0 => gclass40_0.gclass5_0.genum103_0 != GEnum103.const_4)
                    .ToList<ShipData>();
                List<ShipData> gclass40List = new List<ShipData>();
                // ISSUE: reference to a compiler-generated field
                if (class478.gclass11_0 != null)
                {
                    // ISSUE: reference to a compiler-generated method
                    gclass40List = source.Where<ShipData>(class478.method_0).ToList<ShipData>();
                }

                if (list.Count > 0)
                {
                    foreach (ShipData gclass40 in list)
                        num3 += (double)gclass40.gclass5_0.genum103_0;
                    foreach (ShipData gclass40 in gclass40List)
                        num4 += (double)gclass40.gclass5_0.genum103_0;
                    if (num3 == 0.0)
                        this.genum103_0 = GEnum103.const_0;
                    else if (gclass40List.Count > 0 && num4 == 0.0)
                    {
                        this.genum100_0 = GEnum100.const_0;
                        this.genum103_0 = GEnum103.const_0;
                    }
                    else
                    {
                        double num5 = num3 / list.Count;
                        this.genum103_0 = num5 != 3.0
                            ? (num5 <= 1.5 ? GEnum103.const_1 : GEnum103.const_2)
                            : GEnum103.const_3;
                        if (gclass40List.Count > 0)
                        {
                            double num6 = num4 / gclass40List.Count;
                            if (num6 <= 1.5 && this.genum103_0 > GEnum103.const_1)
                                this.genum103_0 = GEnum103.const_1;
                            else if (num6 <= 2.5 && this.genum103_0 > GEnum103.const_2)
                                this.genum103_0 = GEnum103.const_2;
                        }
                    }
                }
            }

            double num7 = 0.0;
            foreach (ShipData gclass40 in source)
                num7 += (double)gclass40.gclass5_0.genum102_0;
            if (num7 == 0.0)
            {
                this.genum102_0 = GEnum102.const_0;
                this.genum100_0 = GEnum100.const_0;
            }
            else
            {
                double num8 = num7 / source.Count;
                this.genum102_0 = num8 <= 2.5 ? (num8 <= 1.5 ? GEnum102.const_1 : GEnum102.const_2) : GEnum102.const_3;
            }

            // ISSUE: reference to a compiler-generated field
            if (class478.gclass11_0 == null)
            {
                this.genum100_0 = GEnum100.const_1;
            }
            else
            {
                if (this.genum100_0 == GEnum100.const_0)
                    return;
                // ISSUE: reference to a compiler-generated method
                List<ShipData> list = source.Where<ShipData>(class478.method_1).ToList<ShipData>();
                double num9 = 0.0;
                foreach (ShipData gclass40 in list)
                    num9 += (double)gclass40.gclass5_0.genum99_0;
                if (num9 == 0.0)
                    this.genum100_0 = GEnum100.const_1;
                else
                    this.genum100_0 = GEnum100.const_2;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 97);
        }
    }

    public bool method_18(List<ShipData> list_0)
    {
        try
        {
            foreach (ShipData gclass40 in list_0)
            {
                if (gclass40.gclass22_0.AutomatedClassDesign.MissileDesignType > MissileDesignType.const_0)
                {
                    if (gclass40.gclass22_0.list_0.Count == 0)
                        return false;
                    Decimal num =
                        gclass40.gclass22_0.list_0.Min<PopOrdnanceStock>(gclass130_0 => gclass130_0.RaceMissile.Size);
                    if (gclass40.method_208() > num)
                        return true;
                }
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 99);
            return false;
        }
    }
}