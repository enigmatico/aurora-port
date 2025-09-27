using System;
using System.Collections.Generic;
using Aurora;

#nullable disable
public partial class GClass3
{
    private sealed class Class417
    {
        public double double_0;
        public GClass3 gclass3_0;
    }


    private sealed class Class418
    {
        public FleetData gclass85_0;
        public GClass3.Class417 class417_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0;
        }

        internal bool method_1(JumpPoint120 gclass120_0)
        {
            return this.class417_0.gclass3_0.gclass0_0.GetDistanceBetween(this.gclass85_0.XCoord, this.gclass85_0.YCoord,
                gclass120_0.XCoord, gclass120_0.YCoord) == 0.0;
        }

        internal bool method_2(GClass65 gclass65_0)
        {
            return this.class417_0.gclass3_0.gclass0_0.GetDistanceBetween(this.gclass85_0.XCoord, this.gclass85_0.YCoord,
                gclass65_0.double_0, gclass65_0.double_1) <= this.class417_0.double_0;
        }

        internal bool method_3(GClass65 gclass65_0)
        {
            return this.class417_0.gclass3_0.gclass0_0.GetDistanceBetween(this.gclass85_0.XCoord, this.gclass85_0.YCoord,
                gclass65_0.double_0, gclass65_0.double_1) <= this.class417_0.double_0;
        }
    }


    private sealed class Class419
    {
        public FleetData gclass85_0;
        public GClass3 gclass3_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }


    private sealed class Class420
    {
        public double double_0;
        public GClass3.Class419 class419_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return this.class419_0.gclass3_0.gclass0_0.GetDistanceBetween(this.class419_0.gclass85_0.XCoord,
                this.class419_0.gclass85_0.YCoord, gclass65_0.double_0, gclass65_0.double_1) <= this.double_0;
        }

        internal bool method_1(GClass65 gclass65_0)
        {
            return this.class419_0.gclass3_0.gclass0_0.GetDistanceBetween(this.class419_0.gclass85_0.XCoord,
                this.class419_0.gclass85_0.YCoord, gclass65_0.double_0, gclass65_0.double_1) <= this.double_0;
        }
    }


    private sealed class Class421
    {
        public double double_0;
        public GClass3.Class420 class420_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return this.class420_0.class419_0.gclass3_0.gclass0_0.GetDistanceBetween(
                this.class420_0.class419_0.gclass85_0.XCoord, this.class420_0.class419_0.gclass85_0.YCoord,
                gclass65_0.double_0, gclass65_0.double_1) <= this.double_0;
        }

        internal bool method_1(GClass65 gclass65_0)
        {
            return this.class420_0.class419_0.gclass3_0.gclass0_0.GetDistanceBetween(
                this.class420_0.class419_0.gclass85_0.XCoord, this.class420_0.class419_0.gclass85_0.YCoord,
                gclass65_0.double_0, gclass65_0.double_1) <= this.double_0;
        }
    }


    private sealed class Class422
    {
        public double double_0;
        public GClass3.Class421 class421_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return this.class421_0.class420_0.class419_0.gclass3_0.gclass0_0.GetDistanceBetween(
                       this.class421_0.class420_0.class419_0.gclass85_0.XCoord,
                       this.class421_0.class420_0.class419_0.gclass85_0.YCoord, gclass65_0.double_0,
                       gclass65_0.double_1) <=
                   this.double_0;
        }

        internal bool method_1(GClass65 gclass65_0)
        {
            return this.class421_0.class420_0.class419_0.gclass3_0.gclass0_0.GetDistanceBetween(
                       this.class421_0.class420_0.class419_0.gclass85_0.XCoord,
                       this.class421_0.class420_0.class419_0.gclass85_0.YCoord, gclass65_0.double_0,
                       gclass65_0.double_1) <=
                   this.double_0;
        }
    }


    private sealed class Class423
    {
        public List<FCTShipData40> list_0;
        public GClass194 gclass194_0;
        public List<FCTShipData40> list_1;
        public GClass3 gclass3_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return this.list_0.Contains(gclass65_0.gclass40_0);
        }

        internal bool method_1(GClass65 gclass65_0)
        {
            return gclass65_0.gclass146_0.SpeciesData != this.gclass194_0 || gclass65_0.gclass146_0.Population == 0M ||
                   gclass65_0.auroraContactType_0 == AuroraContactType.STOGroundUnit ||
                   gclass65_0.auroraContactType_0 == AuroraContactType.Shipyard;
        }

        internal bool method_2(GClass117 gclass117_0)
        {
            return this.list_1.Contains(gclass117_0.gclass40_0);
        }
    }


    private sealed class Class424
    {
        public GClass65 gclass65_0;

        internal bool method_0(GClass13 gclass13_0)
        {
            return gclass13_0.gclass146_0 == this.gclass65_0.gclass146_0;
        }
    }


    private sealed class Class425
    {
        public GClass117 gclass117_0;
        public GClass3.Class441 class441_0;
        public Func<FCTShipData40, Decimal> func_0;

        internal bool method_0(GClass132 gclass132_0)
        {
            return gclass132_0.gclass40_1 == this.gclass117_0.gclass40_0;
        }

        internal bool method_1(GClass132 gclass132_0)
        {
            return gclass132_0.gclass40_1 == this.gclass117_0.gclass40_0 && gclass132_0.decimal_0 <
                this.class441_0.class440_0.class423_0.gclass3_0.gclass0_0.decimal_0;
        }

        internal Decimal method_2(FCTShipData40 gclass40_0)
        {
            return gclass40_0.method_77(this.gclass117_0.gclass40_0);
        }

        internal Decimal method_3(FCTShipData40 gclass40_0)
        {
            return gclass40_0.method_76(this.gclass117_0.gclass40_0, this.gclass117_0.double_2);
        }

        internal Decimal method_4(FCTShipData40 gclass40_0)
        {
            return gclass40_0.method_76(this.gclass117_0.gclass40_0, this.gclass117_0.double_2);
        }
    }


    private sealed class Class426
    {
        public FireControlAssignment gclass36_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }
    }


    private sealed class Class427
    {
        public FireControlAssignment gclass36_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }
    }


    private sealed class Class428
    {
        public GClass13 gclass13_0;

        internal bool method_0(GClass132 gclass132_0)
        {
            return gclass132_0.gclass146_0 == this.gclass13_0.gclass146_0;
        }

        internal Decimal method_1(FCTShipData40 gclass40_0)
        {
            return gclass40_0.method_78(this.gclass13_0.gclass146_0);
        }
    }


    private sealed class Class429
    {
        public FireControlAssignment gclass36_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }
    }


    private sealed class Class430
    {
        public FireControlAssignment gclass36_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }
    }


    private sealed class Class431
    {
        public GClass132 gclass132_0;
        public Func<GClass132, bool> func_0;

        internal bool method_0(GClass132 gclass132_1)
        {
            return gclass132_1 != this.gclass132_0;
        }
    }


    private sealed class Class432
    {
        public FireControlAssignment gclass36_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }
    }


    private sealed class Class433
    {
        public GroundUnitFormationElement gclass39_0;
        public GClass3.Class423 class423_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return this.class423_0.gclass3_0.gclass0_0.GetDistanceBetween(this.gclass39_0.Formation.PopulationData.method_87(),
                this.gclass39_0.Formation.PopulationData.method_88(), gclass40_0.gclass85_0.XCoord,
                gclass40_0.gclass85_0.YCoord) <= this.gclass39_0.GroundUnitClass.int_1;
        }
    }


    private sealed class Class434
    {
        public GClass13 gclass13_0;

        internal bool method_0(GClass113 gclass113_0)
        {
            return gclass113_0.gclass146_0 == this.gclass13_0.gclass146_0;
        }
    }


    private sealed class Class435
    {
        public GClass13 gclass13_0;
        public GClass3.Class423 class423_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.SystemBodyData == this.gclass13_0.gclass146_0.SystemBodyData &&
                   gclass146_0.RaceData == this.class423_0.gclass3_0.gclass202_0.Race;
        }
    }


    private sealed class Class436
    {
        public FleetData gclass85_0;
        public GClass3.Class423 class423_0;

        internal bool method_0(FleetData gclass85_1)
        {
            return this.class423_0.gclass3_0.gclass0_0.method_521(gclass85_1.XCoord, this.gclass85_0.XCoord,
                gclass85_1.YCoord, this.gclass85_0.YCoord, 100000.0);
        }
    }


    private sealed class Class437
    {
        public List<FCTShipData40> list_0;

        internal bool method_0(GClass132 gclass132_0)
        {
            return this.list_0.Contains(gclass132_0.gclass40_1);
        }
    }


    private sealed class Class438
    {
        public FCTShipData40 gclass40_0;
        public GClass3.Class423 class423_0;

        internal double method_0(GClass132 gclass132_0)
        {
            return this.class423_0.gclass3_0.gclass0_0.GetDistanceBetween(gclass132_0.double_0, gclass132_0.double_1,
                this.gclass40_0.gclass85_0.XCoord, this.gclass40_0.gclass85_0.YCoord);
        }

        internal double method_1(GClass116 gclass116_0)
        {
            return this.class423_0.gclass3_0.gclass0_0.GetDistanceBetween(gclass116_0.double_0, gclass116_0.double_1,
                this.gclass40_0.gclass85_0.XCoord, this.gclass40_0.gclass85_0.YCoord);
        }
    }


    private sealed class Class439
    {
        public GClass116 gclass116_0;

        internal bool method_0(GClass13 gclass13_0)
        {
            return gclass13_0.double_1 == this.gclass116_0.double_0 && gclass13_0.double_2 == this.gclass116_0.double_1;
        }
    }


    private sealed class Class440
    {
        public FCTShipData40 gclass40_0;
        public GClass3.Class423 class423_0;

        internal bool method_0(FCTShipData40 gclass40_1)
        {
            return this.class423_0.gclass3_0.gclass0_0.GetDistanceBetween(this.gclass40_0.gclass85_0.XCoord,
                       this.gclass40_0.gclass85_0.YCoord, gclass40_1.gclass85_0.XCoord,
                       gclass40_1.gclass85_0.YCoord) <=
                   this.gclass40_0.gclass5_0.double_3;
        }
    }


    private sealed class Class441
    {
        public List<FCTShipData40> list_0;
        public GClass3.Class440 class440_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.class440_0.gclass40_0.gclass21_0 &&
                   this.list_0.Contains(gclass103_0.ShipData);
        }

        internal bool method_1(GClass117 gclass117_0)
        {
            return this.list_0.Contains(gclass117_0.gclass40_0);
        }
    }


    private sealed class Class442
    {
        public FleetData gclass85_0;
        public GClass3 gclass3_0;

        internal double method_0(FleetData gclass85_1)
        {
            return this.gclass3_0.gclass0_0.GetDistanceBetween(this.gclass85_0.XCoord, this.gclass85_0.YCoord,
                gclass85_1.XCoord, gclass85_1.YCoord);
        }
    }


    private sealed class Class443
    {
        public FleetData gclass85_0;
        public GClass3 gclass3_0;

        internal double method_0(FleetData gclass85_1)
        {
            return this.gclass3_0.gclass0_0.GetDistanceToNearestGClass212(this.gclass3_0.gclass202_0.ActualSystemData, gclass85_1.XCoord,
                gclass85_1.YCoord, this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }
    }


    private sealed class Class444
    {
        public GClass210 gclass210_0;
        public List<FCTShipData40> list_0;
        public List<FCTShipData40> list_1;
        public GClass3 gclass3_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return this.list_0.Contains(gclass117_0.gclass40_0);
        }

        internal bool method_1(GClass117 gclass117_0)
        {
            return this.list_1.Contains(gclass117_0.gclass40_0);
        }
    }


    private sealed class Class445
    {
        public List<JumpPoint120> list_0;
        public int int_0;
        public GClass3.Class444 class444_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.method_22(this.list_0, this.int_0);
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.method_23(this.class444_0.gclass210_0, this.int_0) &&
                   gclass85_0.Race.SpecialNPRID == SpecialNPRIDs.Eldar;
        }
    }


    private sealed class Class446
    {
        public FleetData gclass85_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }


    private sealed class Class447
    {
        public FleetData gclass85_0;
        public GClass3.Class444 class444_0;

        internal double method_0(GClass117 gclass117_0)
        {
            return this.class444_0.gclass3_0.gclass0_0.GetDistanceToNearestGClass212(this.class444_0.gclass3_0.gclass202_0.ActualSystemData,
                gclass117_0.gclass40_0.gclass85_0.XCoord, gclass117_0.gclass40_0.gclass85_0.YCoord,
                this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }
    }


    private sealed class Class448
    {
        public double double_0;
        public GClass3.Class447 class447_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return this.class447_0.class444_0.gclass3_0.gclass0_0.GetDistanceToNearestGClass212(
                this.class447_0.class444_0.gclass3_0.gclass202_0.ActualSystemData,
                gclass117_0.gclass40_0.gclass85_0.XCoord, gclass117_0.gclass40_0.gclass85_0.YCoord,
                this.class447_0.gclass85_0.XCoord, this.class447_0.gclass85_0.YCoord) < this.double_0;
        }
    }


    private sealed class Class449
    {
        public FleetData gclass85_0;
        public GClass3.Class444 class444_0;

        internal double method_0(FCTShipData40 gclass40_0)
        {
            return this.class444_0.gclass3_0.gclass0_0.GetDistanceBetween(gclass40_0.gclass85_0.XCoord,
                gclass40_0.gclass85_0.YCoord, this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }
    }


    private sealed class Class450
    {
        public FleetData gclass85_0;
        public GClass3.Class445 class445_0;

        internal double method_0(GClass132 gclass132_0)
        {
            return this.class445_0.class444_0.gclass3_0.gclass0_0.GetDistanceBetween(this.gclass85_0.XCoord,
                this.gclass85_0.YCoord, gclass132_0.double_0, gclass132_0.double_1);
        }

        internal double method_1(JumpPoint120 gclass120_0)
        {
            return this.class445_0.class444_0.gclass3_0.gclass0_0.GetDistanceBetween(gclass120_0.XCoord, gclass120_0.YCoord,
                this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }
    }


    private sealed class Class451
    {
        public GClass132 gclass132_0;

        internal bool method_0(GClass132 gclass132_1)
        {
            return gclass132_1.double_0 == this.gclass132_0.double_0 &&
                   gclass132_1.double_1 == this.gclass132_0.double_1;
        }
    }


    private sealed class Class452
    {
        public FleetData gclass85_0;
        public GClass3.Class445 class445_0;

        internal double method_0(GClass132 gclass132_0)
        {
            return this.class445_0.class444_0.gclass3_0.gclass0_0.GetDistanceBetween(this.gclass85_0.XCoord,
                this.gclass85_0.YCoord, gclass132_0.double_0, gclass132_0.double_1);
        }
    }


    private sealed class Class453
    {
        public GClass132 gclass132_0;

        internal bool method_0(GClass132 gclass132_1)
        {
            return gclass132_1.double_0 == this.gclass132_0.double_0 &&
                   gclass132_1.double_1 == this.gclass132_0.double_1;
        }
    }


    private sealed class Class454
    {
        public FleetData gclass85_0;
        public GClass3.Class444 class444_0;

        internal bool method_0(FleetData gclass85_1)
        {
            return Math.Abs(gclass85_1.XCoord - this.gclass85_0.XCoord) < 1000000.0 &&
                   Math.Abs(gclass85_1.YCoord - this.gclass85_0.YCoord) < 1000000.0;
        }

        internal double method_1(FleetData gclass85_1)
        {
            return this.class444_0.gclass3_0.gclass0_0.GetDistanceToNearestGClass212(this.gclass85_0.System.ActualSystemData,
                gclass85_1.XCoord, gclass85_1.YCoord, this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }

        internal double method_2(FleetData gclass85_1)
        {
            return this.class444_0.gclass3_0.gclass0_0.GetDistanceToNearestGClass212(this.class444_0.gclass3_0.gclass202_0.ActualSystemData,
                gclass85_1.XCoord, gclass85_1.YCoord, this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }

        internal bool method_3(PopulationData gclass146_0)
        {
            return gclass146_0.method_87() == this.gclass85_0.XCoord &&
                   gclass146_0.method_88() == this.gclass85_0.YCoord;
        }

        internal bool method_4(FleetData gclass85_1)
        {
            return gclass85_1.NPROperationGroup.genum105_0 == OperationalGroup.OrbitalDefences &&
                   gclass85_1.XCoord == this.gclass85_0.XCoord && gclass85_1.YCoord == this.gclass85_0.YCoord;
        }

        internal double method_5(FleetData gclass85_1)
        {
            return this.class444_0.gclass3_0.gclass0_0.GetDistanceToNearestGClass212(this.class444_0.gclass3_0.gclass202_0.ActualSystemData,
                gclass85_1.XCoord, gclass85_1.YCoord, this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }
    }


    private sealed class Class455
    {
        public List<FCTShipData40> list_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return this.list_0.Contains(gclass117_0.gclass40_0);
        }
    }


    private sealed class Class456
    {
        public FleetData gclass85_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0.gclass85_0 == this.gclass85_0;
        }

        internal bool method_1(FCTShipData40 gclass40_0)
        {
            return gclass40_0.method_171(false) > this.gclass85_0.Speed;
        }

        internal bool method_2(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }


    private sealed class Class457
    {
        public PopulationData gclass146_0;

        internal bool method_0(GroundUnitFormationElement gclass39_0)
        {
            return gclass39_0.Formation.PopulationData == this.gclass146_0;
        }
    }


    private sealed class Class458
    {
        public GEnum104 genum104_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.genum104_0 == this.genum104_0 && !gclass85_0.NPRSomething.bRedeployOrderGiven;
        }
    }


    private sealed class Class459
    {
        public FleetData gclass85_0;
        public GClass3 gclass3_0;

        internal double method_0(FleetData gclass85_1)
        {
            return this.gclass3_0.gclass0_0.GetDistanceToNearestGClass212(this.gclass3_0.gclass202_0.ActualSystemData, gclass85_1.XCoord,
                gclass85_1.YCoord, this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }

        internal int method_1(FleetData gclass85_1)
        {
            return this.gclass3_0.gclass0_0.method_35(this.gclass85_0.System.ActualSystemData,
                gclass85_1.System.ActualSystemData, this.gclass85_0.Race);
        }
    }


    private sealed class Class460
    {
        public FleetData gclass85_0;

        internal bool method_0(FleetData gclass85_1)
        {
            return gclass85_1.double_8 < AuroraUtils.double_10 / 2.0 &&
                   gclass85_1.decimal_7 < this.gclass85_0.decimal_7;
        }

        internal bool method_1(FleetData gclass85_1)
        {
            return gclass85_1.decimal_7 < this.gclass85_0.decimal_7 * 2M && gclass85_1.gclass85_4 != null;
        }
    }


    private sealed class Class461
    {
        public Decimal decimal_0;
        public GClass3.Class460 class460_0;
        public Func<FleetData, bool> func_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.decimal_7 < this.class460_0.gclass85_0.decimal_7 * this.decimal_0 &&
                   gclass85_0.gclass85_4 == null;
        }
    }


    private sealed class Class462
    {
        public FleetData gclass85_0;
        public GClass3 gclass3_0;

        internal double method_0(FleetData gclass85_1)
        {
            return this.gclass3_0.gclass0_0.GetDistanceBetween(gclass85_1.XCoord, gclass85_1.YCoord,
                this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }
    }


    private sealed class Class463
    {
        public GClass3 gclass3_0;
        public GClass117 gclass117_0;

        internal double method_0(FleetData gclass85_0)
        {
            return this.gclass3_0.gclass0_0.GetDistanceBetween(gclass85_0.XCoord, gclass85_0.YCoord,
                this.gclass117_0.gclass40_0.gclass85_0.XCoord, this.gclass117_0.gclass40_0.gclass85_0.YCoord);
        }
    }


    private sealed class Class464
    {
        public PopulationData gclass146_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.XCoord == this.gclass146_0.method_87() &&
                   gclass85_0.YCoord == this.gclass146_0.method_88();
        }

        internal bool method_1(GroundUnitFormationElement gclass39_0)
        {
            return gclass39_0.Formation.PopulationData == this.gclass146_0;
        }
    }


    private sealed class Class465
    {
        public GClass3 gclass3_0;
        public GClass117 gclass117_0;

        internal double method_0(FleetData gclass85_0)
        {
            return this.gclass3_0.gclass0_0.GetDistanceBetween(gclass85_0.XCoord, gclass85_0.YCoord,
                this.gclass117_0.gclass40_0.gclass85_0.XCoord, this.gclass117_0.gclass40_0.gclass85_0.YCoord);
        }
    }


    private sealed class Class466
    {
        public Decimal decimal_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.decimal_7 > this.decimal_0 * 2M;
        }
    }


    private sealed class Class467
    {
        public List<int> list_0;
        public List<GClass214> list_1;
        public Func<GClass214, bool> func_0;
        public Func<GClass214, bool> func_1;

        internal bool method_0(GClass214 gclass214_0)
        {
            return this.list_0.Contains(gclass214_0.int_0);
        }

        internal bool method_1(GClass214 gclass214_0)
        {
            return !this.list_1.Contains(gclass214_0);
        }

        internal bool method_2(GClass214 gclass214_0)
        {
            return !gclass214_0.method_1(50000000.0, this.list_1);
        }
    }


    private sealed class Class468
    {
        public WayPointType wayPointType_0;
        public GClass3 gclass3_0;

        internal bool method_0(GClass214 gclass214_0)
        {
            return gclass214_0.wayPointType_0 == this.wayPointType_0;
        }
    }


    private sealed class Class469
    {
        public double double_0;
        public double double_1;
        public GClass3.Class468 class468_0;
        public Func<GClass214, double> func_0;

        internal double method_0(GClass214 gclass214_0)
        {
            return this.class468_0.gclass3_0.gclass0_0.GetDistanceToNearestGClass212(this.class468_0.gclass3_0.gclass202_0.ActualSystemData,
                gclass214_0.double_0, gclass214_0.double_1, this.double_0, this.double_1);
        }
    }


    private sealed class Class470
    {
        public FleetData gclass85_0;
        public GClass3 gclass3_0;

        internal double method_0(PopulationData gclass146_0)
        {
            return this.gclass3_0.gclass0_0.GetDistanceBetween(this.gclass85_0.XCoord, this.gclass85_0.YCoord,
                gclass146_0.method_87(), gclass146_0.method_88());
        }
    }


    private sealed class Class471
    {
        public FleetData gclass85_0;
        public GClass3 gclass3_0;

        internal double method_0(PopulationData gclass146_0)
        {
            return this.gclass3_0.gclass0_0.GetDistanceBetween(this.gclass85_0.XCoord, this.gclass85_0.YCoord,
                gclass146_0.method_87(), gclass146_0.method_88());
        }
    }


    private sealed class Class472
    {
        public PopulationData gclass146_0;
        public GClass3 gclass3_0;

        internal bool method_0(MoveOrder gclass139_0)
        {
            return gclass139_0.MoveActionType.MoveActionType == MoveActionType.MoveTo &&
                   gclass139_0.Population == this.gclass146_0;
        }

        internal double method_1(FleetData gclass85_0)
        {
            return this.gclass3_0.gclass0_0.GetDistanceBetween(gclass85_0.XCoord, gclass85_0.YCoord,
                this.gclass146_0.method_87(), this.gclass146_0.method_88());
        }
    }


    private sealed class Class473
    {
        public List<PopulationData> list_0;

        internal bool method_0(GClass193 gclass193_0)
        {
            return this.list_0.Contains(gclass193_0.gclass146_0) &&
                   gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Naval;
        }

        internal bool method_1(GClass193 gclass193_0)
        {
            return this.list_0.Contains(gclass193_0.gclass146_0) &&
                   gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Commercial;
        }

        internal bool method_2(FCTShipData40 gclass40_0)
        {
            return this.list_0.Contains(gclass40_0.gclass85_0.AssignedPopulation);
        }

        internal bool method_3(FCTShipData40 gclass40_0)
        {
            return this.list_0.Contains(gclass40_0.gclass85_0.AssignedPopulation);
        }
    }


    private sealed class Class474
    {
        public List<SystemBodyData> list_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return this.list_0.Contains(gclass40_0.gclass85_0.OrbitingBody);
        }
    }
}