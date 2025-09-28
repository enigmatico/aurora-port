using System;
using System.Collections.Generic;
using Aurora;

#nullable disable
public partial class NPRSurveyOperation
{
    private sealed class Class417
    {
        public double double_0;
        public NPRSurveyOperation thisRef;
    }


    private sealed class Class418
    {
        public FleetData Fleet;
        public NPRSurveyOperation.Class417 class417_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.Fleet;
        }

        internal bool method_1(JumpPoint gclass120_0)
        {
            return this.class417_0.thisRef.Game.GetDistanceBetween(this.Fleet.XCoord, this.Fleet.YCoord,
                gclass120_0.XCoord, gclass120_0.YCoord) == 0.0;
        }

        internal bool method_2(Contact gclass65_0)
        {
            return this.class417_0.thisRef.Game.GetDistanceBetween(this.Fleet.XCoord, this.Fleet.YCoord,
                gclass65_0.Xcor, gclass65_0.Ycor) <= this.class417_0.double_0;
        }

        internal bool method_3(Contact gclass65_0)
        {
            return this.class417_0.thisRef.Game.GetDistanceBetween(this.Fleet.XCoord, this.Fleet.YCoord,
                gclass65_0.Xcor, gclass65_0.Ycor) <= this.class417_0.double_0;
        }
    }


    private sealed class Class419
    {
        public FleetData gclass85_0;
        public NPRSurveyOperation gclass3_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }


    private sealed class Class420
    {
        public double double_0;
        public NPRSurveyOperation.Class419 class419_0;

        internal bool method_0(Contact gclass65_0)
        {
            return this.class419_0.gclass3_0.Game.GetDistanceBetween(this.class419_0.gclass85_0.XCoord,
                this.class419_0.gclass85_0.YCoord, gclass65_0.Xcor, gclass65_0.Ycor) <= this.double_0;
        }

        internal bool method_1(Contact gclass65_0)
        {
            return this.class419_0.gclass3_0.Game.GetDistanceBetween(this.class419_0.gclass85_0.XCoord,
                this.class419_0.gclass85_0.YCoord, gclass65_0.Xcor, gclass65_0.Ycor) <= this.double_0;
        }
    }


    private sealed class Class421
    {
        public double double_0;
        public NPRSurveyOperation.Class420 class420_0;

        internal bool method_0(Contact gclass65_0)
        {
            return this.class420_0.class419_0.gclass3_0.Game.GetDistanceBetween(
                this.class420_0.class419_0.gclass85_0.XCoord, this.class420_0.class419_0.gclass85_0.YCoord,
                gclass65_0.Xcor, gclass65_0.Ycor) <= this.double_0;
        }

        internal bool method_1(Contact gclass65_0)
        {
            return this.class420_0.class419_0.gclass3_0.Game.GetDistanceBetween(
                this.class420_0.class419_0.gclass85_0.XCoord, this.class420_0.class419_0.gclass85_0.YCoord,
                gclass65_0.Xcor, gclass65_0.Ycor) <= this.double_0;
        }
    }


    private sealed class Class422
    {
        public double double_0;
        public NPRSurveyOperation.Class421 class421_0;

        internal bool method_0(Contact gclass65_0)
        {
            return this.class421_0.class420_0.class419_0.gclass3_0.Game.GetDistanceBetween(
                       this.class421_0.class420_0.class419_0.gclass85_0.XCoord,
                       this.class421_0.class420_0.class419_0.gclass85_0.YCoord, gclass65_0.Xcor,
                       gclass65_0.Ycor) <=
                   this.double_0;
        }

        internal bool method_1(Contact gclass65_0)
        {
            return this.class421_0.class420_0.class419_0.gclass3_0.Game.GetDistanceBetween(
                       this.class421_0.class420_0.class419_0.gclass85_0.XCoord,
                       this.class421_0.class420_0.class419_0.gclass85_0.YCoord, gclass65_0.Xcor,
                       gclass65_0.Ycor) <=
                   this.double_0;
        }
    }


    private sealed class Class423
    {
        public List<ShipData> list_0;
        public Species gclass194_0;
        public List<ShipData> list_1;
        public NPRSurveyOperation gclass3_0;

        internal bool method_0(Contact gclass65_0)
        {
            return this.list_0.Contains(gclass65_0.TargetShip);
        }

        internal bool method_1(Contact gclass65_0)
        {
            return gclass65_0.TargetPopulation.Species != this.gclass194_0 || gclass65_0.TargetPopulation.Population == 0M ||
                   gclass65_0.ContactType == AuroraContactType.STOGroundUnit ||
                   gclass65_0.ContactType == AuroraContactType.Shipyard;
        }

        internal bool method_2(AlienShipIntel gclass117_0)
        {
            return this.list_1.Contains(gclass117_0.gclass40_0);
        }
    }


    private sealed class Class424
    {
        public Contact gclass65_0;

        internal bool method_0(GClass13 gclass13_0)
        {
            return gclass13_0.gclass146_0 == this.gclass65_0.TargetPopulation;
        }
    }


    private sealed class Class425
    {
        public AlienShipIntel gclass117_0;
        public NPRSurveyOperation.Class441 class441_0;
        public Func<ShipData, Decimal> func_0;

        internal bool method_0(MissileSalvo gclass132_0)
        {
            return gclass132_0.TargetShip == this.gclass117_0.gclass40_0;
        }

        internal bool method_1(MissileSalvo gclass132_0)
        {
            return gclass132_0.TargetShip == this.gclass117_0.gclass40_0 && gclass132_0.LaunchTime <
                this.class441_0.class440_0.class423_0.gclass3_0.Game.GameTime;
        }

        internal Decimal method_2(ShipData gclass40_0)
        {
            return gclass40_0.method_77(this.gclass117_0.gclass40_0);
        }

        internal Decimal method_3(ShipData gclass40_0)
        {
            return gclass40_0.method_76(this.gclass117_0.gclass40_0, this.gclass117_0.double_2);
        }

        internal Decimal method_4(ShipData gclass40_0)
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

        internal bool method_0(MissileSalvo gclass132_0)
        {
            return gclass132_0.TargetPopulation == this.gclass13_0.gclass146_0;
        }

        internal Decimal method_1(ShipData gclass40_0)
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
        public MissileSalvo gclass132_0;
        public Func<MissileSalvo, bool> func_0;

        internal bool method_0(MissileSalvo gclass132_1)
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
        public NPRSurveyOperation.Class423 class423_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return this.class423_0.gclass3_0.Game.GetDistanceBetween(this.gclass39_0.Formation.PopulationData.method_87(),
                this.gclass39_0.Formation.PopulationData.method_88(), gclass40_0.gclass85_0.XCoord,
                gclass40_0.gclass85_0.YCoord) <= this.gclass39_0.GroundUnitClass.int_1;
        }
    }


    private sealed class Class434
    {
        public GClass13 gclass13_0;

        internal bool method_0(AlienPopulationIntel gclass113_0)
        {
            return gclass113_0.Population == this.gclass13_0.gclass146_0;
        }
    }


    private sealed class Class435
    {
        public GClass13 gclass13_0;
        public NPRSurveyOperation.Class423 class423_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.SystemBodyData == this.gclass13_0.gclass146_0.SystemBodyData &&
                   gclass146_0.Race == this.class423_0.gclass3_0.SystemSurvey.Race;
        }
    }


    private sealed class Class436
    {
        public FleetData gclass85_0;
        public NPRSurveyOperation.Class423 class423_0;

        internal bool method_0(FleetData gclass85_1)
        {
            return this.class423_0.gclass3_0.Game.method_521(gclass85_1.XCoord, this.gclass85_0.XCoord,
                gclass85_1.YCoord, this.gclass85_0.YCoord, 100000.0);
        }
    }


    private sealed class Class437
    {
        public List<ShipData> list_0;

        internal bool method_0(MissileSalvo gclass132_0)
        {
            return this.list_0.Contains(gclass132_0.TargetShip);
        }
    }


    private sealed class Class438
    {
        public ShipData gclass40_0;
        public NPRSurveyOperation.Class423 class423_0;

        internal double method_0(MissileSalvo gclass132_0)
        {
            return this.class423_0.gclass3_0.Game.GetDistanceBetween(gclass132_0.Xcor, gclass132_0.Ycor,
                this.gclass40_0.gclass85_0.XCoord, this.gclass40_0.gclass85_0.YCoord);
        }

        internal double method_1(GClass116 gclass116_0)
        {
            return this.class423_0.gclass3_0.Game.GetDistanceBetween(gclass116_0.double_0, gclass116_0.double_1,
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
        public ShipData gclass40_0;
        public NPRSurveyOperation.Class423 class423_0;

        internal bool method_0(ShipData gclass40_1)
        {
            return this.class423_0.gclass3_0.Game.GetDistanceBetween(this.gclass40_0.gclass85_0.XCoord,
                       this.gclass40_0.gclass85_0.YCoord, gclass40_1.gclass85_0.XCoord,
                       gclass40_1.gclass85_0.YCoord) <=
                   this.gclass40_0.NPRShipBehaviour.double_3;
        }
    }


    private sealed class Class441
    {
        public List<ShipData> list_0;
        public NPRSurveyOperation.Class440 class440_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.class440_0.gclass40_0.Race &&
                   this.list_0.Contains(gclass103_0.ShipData);
        }

        internal bool method_1(AlienShipIntel gclass117_0)
        {
            return this.list_0.Contains(gclass117_0.gclass40_0);
        }
    }


    private sealed class Class442
    {
        public FleetData gclass85_0;
        public NPRSurveyOperation gclass3_0;

        internal double method_0(FleetData gclass85_1)
        {
            return this.gclass3_0.Game.GetDistanceBetween(this.gclass85_0.XCoord, this.gclass85_0.YCoord,
                gclass85_1.XCoord, gclass85_1.YCoord);
        }
    }


    private sealed class Class443
    {
        public FleetData gclass85_0;
        public NPRSurveyOperation gclass3_0;

        internal double method_0(FleetData gclass85_1)
        {
            return this.gclass3_0.Game.GetDistanceToNearestGClass212(this.gclass3_0.SystemSurvey.ActualSystem, gclass85_1.XCoord,
                gclass85_1.YCoord, this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }
    }


    private sealed class Class444
    {
        public AetherGate gclass210_0;
        public List<ShipData> list_0;
        public List<ShipData> list_1;
        public NPRSurveyOperation gclass3_0;

        internal bool method_0(AlienShipIntel gclass117_0)
        {
            return this.list_0.Contains(gclass117_0.gclass40_0);
        }

        internal bool method_1(AlienShipIntel gclass117_0)
        {
            return this.list_1.Contains(gclass117_0.gclass40_0);
        }
    }


    private sealed class Class445
    {
        public List<JumpPoint> list_0;
        public int int_0;
        public NPRSurveyOperation.Class444 class444_0;

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

        internal bool method_0(AlienShipIntel gclass117_0)
        {
            return gclass117_0.gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }


    private sealed class Class447
    {
        public FleetData gclass85_0;
        public NPRSurveyOperation.Class444 class444_0;

        internal double method_0(AlienShipIntel gclass117_0)
        {
            return this.class444_0.gclass3_0.Game.GetDistanceToNearestGClass212(this.class444_0.gclass3_0.SystemSurvey.ActualSystem,
                gclass117_0.gclass40_0.gclass85_0.XCoord, gclass117_0.gclass40_0.gclass85_0.YCoord,
                this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }
    }


    private sealed class Class448
    {
        public double double_0;
        public NPRSurveyOperation.Class447 class447_0;

        internal bool method_0(AlienShipIntel gclass117_0)
        {
            return this.class447_0.class444_0.gclass3_0.Game.GetDistanceToNearestGClass212(
                this.class447_0.class444_0.gclass3_0.SystemSurvey.ActualSystem,
                gclass117_0.gclass40_0.gclass85_0.XCoord, gclass117_0.gclass40_0.gclass85_0.YCoord,
                this.class447_0.gclass85_0.XCoord, this.class447_0.gclass85_0.YCoord) < this.double_0;
        }
    }


    private sealed class Class449
    {
        public FleetData gclass85_0;
        public NPRSurveyOperation.Class444 class444_0;

        internal double method_0(ShipData gclass40_0)
        {
            return this.class444_0.gclass3_0.Game.GetDistanceBetween(gclass40_0.gclass85_0.XCoord,
                gclass40_0.gclass85_0.YCoord, this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }
    }


    private sealed class Class450
    {
        public FleetData gclass85_0;
        public NPRSurveyOperation.Class445 class445_0;

        internal double method_0(MissileSalvo gclass132_0)
        {
            return this.class445_0.class444_0.gclass3_0.Game.GetDistanceBetween(this.gclass85_0.XCoord,
                this.gclass85_0.YCoord, gclass132_0.Xcor, gclass132_0.Ycor);
        }

        internal double method_1(JumpPoint gclass120_0)
        {
            return this.class445_0.class444_0.gclass3_0.Game.GetDistanceBetween(gclass120_0.XCoord, gclass120_0.YCoord,
                this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }
    }


    private sealed class Class451
    {
        public MissileSalvo gclass132_0;

        internal bool method_0(MissileSalvo gclass132_1)
        {
            return gclass132_1.Xcor == this.gclass132_0.Xcor &&
                   gclass132_1.Ycor == this.gclass132_0.Ycor;
        }
    }


    private sealed class Class452
    {
        public FleetData gclass85_0;
        public NPRSurveyOperation.Class445 class445_0;

        internal double method_0(MissileSalvo gclass132_0)
        {
            return this.class445_0.class444_0.gclass3_0.Game.GetDistanceBetween(this.gclass85_0.XCoord,
                this.gclass85_0.YCoord, gclass132_0.Xcor, gclass132_0.Ycor);
        }
    }


    private sealed class Class453
    {
        public MissileSalvo gclass132_0;

        internal bool method_0(MissileSalvo gclass132_1)
        {
            return gclass132_1.Xcor == this.gclass132_0.Xcor &&
                   gclass132_1.Ycor == this.gclass132_0.Ycor;
        }
    }


    private sealed class Class454
    {
        public FleetData gclass85_0;
        public NPRSurveyOperation.Class444 class444_0;

        internal bool method_0(FleetData gclass85_1)
        {
            return Math.Abs(gclass85_1.XCoord - this.gclass85_0.XCoord) < 1000000.0 &&
                   Math.Abs(gclass85_1.YCoord - this.gclass85_0.YCoord) < 1000000.0;
        }

        internal double method_1(FleetData gclass85_1)
        {
            return this.class444_0.gclass3_0.Game.GetDistanceToNearestGClass212(this.gclass85_0.System.ActualSystem,
                gclass85_1.XCoord, gclass85_1.YCoord, this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }

        internal double method_2(FleetData gclass85_1)
        {
            return this.class444_0.gclass3_0.Game.GetDistanceToNearestGClass212(this.class444_0.gclass3_0.SystemSurvey.ActualSystem,
                gclass85_1.XCoord, gclass85_1.YCoord, this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }

        internal bool method_3(PopulationData gclass146_0)
        {
            return gclass146_0.method_87() == this.gclass85_0.XCoord &&
                   gclass146_0.method_88() == this.gclass85_0.YCoord;
        }

        internal bool method_4(FleetData gclass85_1)
        {
            return gclass85_1.NPROperationGroup.OperationalGroupId == OperationalGroupID.OrbitalDefences &&
                   gclass85_1.XCoord == this.gclass85_0.XCoord && gclass85_1.YCoord == this.gclass85_0.YCoord;
        }

        internal double method_5(FleetData gclass85_1)
        {
            return this.class444_0.gclass3_0.Game.GetDistanceToNearestGClass212(this.class444_0.gclass3_0.SystemSurvey.ActualSystem,
                gclass85_1.XCoord, gclass85_1.YCoord, this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }
    }


    private sealed class Class455
    {
        public List<ShipData> list_0;

        internal bool method_0(AlienShipIntel gclass117_0)
        {
            return this.list_0.Contains(gclass117_0.gclass40_0);
        }
    }


    private sealed class Class456
    {
        public FleetData gclass85_0;

        internal bool method_0(AlienShipIntel gclass117_0)
        {
            return gclass117_0.gclass40_0.gclass85_0 == this.gclass85_0;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.method_171(false) > this.gclass85_0.Speed;
        }

        internal bool method_2(AlienShipIntel gclass117_0)
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
        public NPRSurveyOperation gclass3_0;

        internal double method_0(FleetData gclass85_1)
        {
            return this.gclass3_0.Game.GetDistanceToNearestGClass212(this.gclass3_0.SystemSurvey.ActualSystem, gclass85_1.XCoord,
                gclass85_1.YCoord, this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }

        internal int method_1(FleetData gclass85_1)
        {
            return this.gclass3_0.Game.method_35(this.gclass85_0.System.ActualSystem,
                gclass85_1.System.ActualSystem, this.gclass85_0.Race);
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
        public NPRSurveyOperation.Class460 class460_0;
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
        public NPRSurveyOperation gclass3_0;

        internal double method_0(FleetData gclass85_1)
        {
            return this.gclass3_0.Game.GetDistanceBetween(gclass85_1.XCoord, gclass85_1.YCoord,
                this.gclass85_0.XCoord, this.gclass85_0.YCoord);
        }
    }


    private sealed class Class463
    {
        public NPRSurveyOperation gclass3_0;
        public AlienShipIntel gclass117_0;

        internal double method_0(FleetData gclass85_0)
        {
            return this.gclass3_0.Game.GetDistanceBetween(gclass85_0.XCoord, gclass85_0.YCoord,
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
        public NPRSurveyOperation gclass3_0;
        public AlienShipIntel gclass117_0;

        internal double method_0(FleetData gclass85_0)
        {
            return this.gclass3_0.Game.GetDistanceBetween(gclass85_0.XCoord, gclass85_0.YCoord,
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
        public List<Waypoint> list_1;
        public Func<Waypoint, bool> func_0;
        public Func<Waypoint, bool> func_1;

        internal bool method_0(Waypoint gclass214_0)
        {
            return this.list_0.Contains(gclass214_0.WaypointID);
        }

        internal bool method_1(Waypoint gclass214_0)
        {
            return !this.list_1.Contains(gclass214_0);
        }

        internal bool method_2(Waypoint gclass214_0)
        {
            return !gclass214_0.method_1(50000000.0, this.list_1);
        }
    }


    private sealed class Class468
    {
        public WayPointType wayPointType_0;
        public NPRSurveyOperation gclass3_0;

        internal bool method_0(Waypoint gclass214_0)
        {
            return gclass214_0.WaypointType == this.wayPointType_0;
        }
    }


    private sealed class Class469
    {
        public double double_0;
        public double double_1;
        public NPRSurveyOperation.Class468 class468_0;
        public Func<Waypoint, double> func_0;

        internal double method_0(Waypoint gclass214_0)
        {
            return this.class468_0.gclass3_0.Game.GetDistanceToNearestGClass212(this.class468_0.gclass3_0.SystemSurvey.ActualSystem,
                gclass214_0.Xcor, gclass214_0.Ycor, this.double_0, this.double_1);
        }
    }


    private sealed class Class470
    {
        public FleetData gclass85_0;
        public NPRSurveyOperation gclass3_0;

        internal double method_0(PopulationData gclass146_0)
        {
            return this.gclass3_0.Game.GetDistanceBetween(this.gclass85_0.XCoord, this.gclass85_0.YCoord,
                gclass146_0.method_87(), gclass146_0.method_88());
        }
    }


    private sealed class Class471
    {
        public FleetData gclass85_0;
        public NPRSurveyOperation gclass3_0;

        internal double method_0(PopulationData gclass146_0)
        {
            return this.gclass3_0.Game.GetDistanceBetween(this.gclass85_0.XCoord, this.gclass85_0.YCoord,
                gclass146_0.method_87(), gclass146_0.method_88());
        }
    }


    private sealed class Class472
    {
        public PopulationData gclass146_0;
        public NPRSurveyOperation gclass3_0;

        internal bool method_0(MoveOrder gclass139_0)
        {
            return gclass139_0.MoveActionType.MoveActionType == MoveActionType.MoveTo &&
                   gclass139_0.Population == this.gclass146_0;
        }

        internal double method_1(FleetData gclass85_0)
        {
            return this.gclass3_0.Game.GetDistanceBetween(gclass85_0.XCoord, gclass85_0.YCoord,
                this.gclass146_0.method_87(), this.gclass146_0.method_88());
        }
    }


    private sealed class Class473
    {
        public List<PopulationData> list_0;

        internal bool method_0(Shipyard gclass193_0)
        {
            return this.list_0.Contains(gclass193_0.Population) &&
                   gclass193_0.SYType == AuroraShipyardType.Naval;
        }

        internal bool method_1(Shipyard gclass193_0)
        {
            return this.list_0.Contains(gclass193_0.Population) &&
                   gclass193_0.SYType == AuroraShipyardType.Commercial;
        }

        internal bool method_2(ShipData gclass40_0)
        {
            return this.list_0.Contains(gclass40_0.gclass85_0.AssignedPopulation);
        }

        internal bool method_3(ShipData gclass40_0)
        {
            return this.list_0.Contains(gclass40_0.gclass85_0.AssignedPopulation);
        }
    }


    private sealed class Class474
    {
        public List<SystemBodyData> list_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return this.list_0.Contains(gclass40_0.gclass85_0.OrbitingBody);
        }
    }
}