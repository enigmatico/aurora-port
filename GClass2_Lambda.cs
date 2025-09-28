using System;
using System.Collections.Generic;
using System.Linq;
using Aurora;

#nullable disable
public partial class UnknownNPRClass2
{
    private sealed class Class335
    {
        public UnknownNPRClass2 gclass2_0;
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.System == this.gclass202_0 &&
                   gclass85_0.LastMoveTime < this.gclass2_0.gclass0_0.GameTime - AuroraUtils.decimal_32 &&
                   gclass85_0.NPROperationGroup.bool_2;
        }
    }


    private sealed class Class336
    {
        public OperationalGroupID genum105_0;
        public RacialSystemSurvey gclass202_0;
        public UnknownNPRClass2 gclass2_0;
        public List<StarSystem> list_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.OperationalGroupId == this.genum105_0 && gclass85_0.System == this.gclass202_0;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.OperationalGroupId == this.genum105_0 && gclass85_0.System != this.gclass202_0;
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass2_0.gclass21_0 && gclass146_0.gclass202_0 != this.gclass202_0;
        }

        internal bool method_3(LifePod gclass59_0)
        {
            return this.list_0.Contains(gclass59_0.gclass200_0);
        }

        internal bool method_4(Wreck gclass233_0)
        {
            return this.list_0.Contains(gclass233_0.System);
        }
    }


    private sealed class Class337
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.int_1 == 1 && gclass85_0.System == this.gclass202_0;
        }
    }


    private sealed class Class338
    {
        public UnknownNPRClass2 gclass2_0;
        public RacialSystemSurvey gclass202_0;
        public List<StarSystem> list_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.int_1 == 1 && gclass85_0.System != this.gclass202_0;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.OperationalGroupId == OperationalGroupID.LoneRaider && gclass85_0.System == this.gclass202_0 &&
                   gclass85_0.LastMoveTime < this.gclass2_0.gclass0_0.GameTime - AuroraUtils.decimal_32;
        }

        internal bool method_2(RacialSystemSurvey gclass202_1)
        {
            return this.list_0.Contains(gclass202_1.ActualSystem);
        }
    }


    private sealed class Class339
    {
        public StarSystem gclass200_0;
        public UnknownNPRClass2.Class338 class338_0;

        internal bool method_0(Waypoint gclass214_0)
        {
            return gclass214_0.WaypointType == WayPointType.POI &&
                   gclass214_0.Race == this.class338_0.gclass2_0.gclass21_0 &&
                   gclass214_0.System == this.gclass200_0;
        }
    }


    private sealed class Class340
    {
        public SystemBodyData gclass1_0;

        internal bool method_0(Waypoint gclass214_0)
        {
            return gclass214_0.OrbitBody == this.gclass1_0;
        }
    }


    private sealed class Class341
    {
        public SurveyLocation gclass213_0;

        internal bool method_0(Waypoint gclass214_0)
        {
            return gclass214_0.Xcor == this.gclass213_0.XCoord && gclass214_0.Ycor == this.gclass213_0.YCoord;
        }
    }


    private sealed class Class342
    {
        public List<RacialSystemSurvey> list_0;
        public List<RacialSystemSurvey> list_1;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return !this.list_0.Contains(gclass202_0);
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return this.list_1.Contains(gclass85_0.System) && gclass85_0.NPROperationGroup.genum104_0 != GEnum104.const_25;
        }
    }


    private sealed class Class343
    {
        public AlienRaceIntel gclass110_0;
        public UnknownNPRClass2 gclass2_0;

        internal bool method_0(AlienShipIntel gclass117_0)
        {
            return gclass117_0.gclass110_0 == this.gclass110_0 && !gclass117_0.bool_0 && gclass117_0.int_1 > 1 &&
                   !gclass117_0.gclass115_0.gclass22_0.Commercial &&
                   this.gclass2_0.gclass0_0.GameTime - gclass117_0.decimal_0 < AuroraUtils.decimal_30;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.Race == this.gclass2_0.gclass21_0 && gclass40_0.Class.MaxSpeed > 1 &&
                   !gclass40_0.Class.Commercial;
        }

        internal bool method_2(ShipClass gclass22_0)
        {
            return gclass22_0.Race == this.gclass2_0.gclass21_0;
        }

        internal bool method_3(AlienShipClassIntel gclass115_0)
        {
            return gclass115_0.gclass110_0 == this.gclass110_0;
        }

        internal bool method_4(ShipClass gclass22_0)
        {
            return gclass22_0.Race == this.gclass2_0.gclass21_0;
        }
    }


    private sealed class Class344
    {
        public AlienRaceIntel gclass110_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.gclass110_0 == this.gclass110_0;
        }
    }


    private sealed class Class345
    {
        public UnknownNPRClass2 gclass2_0;
        public RacialSystemSurvey gclass202_0;
        public ShipData gclass40_0;

        internal bool method_0(ShipData gclass40_1)
        {
            return gclass40_1.Race == this.gclass2_0.gclass21_0 &&
                   gclass40_1.gclass85_0.System == this.gclass202_0;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            if (gclass146_0.Race != this.gclass2_0.gclass21_0 || gclass146_0.gclass202_0 != this.gclass202_0)
                return false;
            return gclass146_0.decimal_30 > 0.01M || gclass146_0.dictionary_0.Count > 0;
        }

        internal double method_2(ShipData gclass40_1)
        {
            return this.gclass2_0.gclass0_0.GetDistanceBetween(gclass40_1.gclass85_0.XCoord, gclass40_1.gclass85_0.YCoord,
                this.gclass40_0.gclass85_0.XCoord, this.gclass40_0.gclass85_0.YCoord);
        }

        internal double method_3(PopulationData gclass146_0)
        {
            return this.gclass2_0.gclass0_0.GetDistanceBetween(gclass146_0.method_87(), gclass146_0.method_88(),
                this.gclass40_0.gclass85_0.XCoord, this.gclass40_0.gclass85_0.YCoord);
        }
    }


    private sealed class Class346
    {
        public double double_0;
        public double double_1;
        public UnknownNPRClass2.Class345 class345_0;

        internal double method_0(ShipData gclass40_0)
        {
            return this.class345_0.gclass2_0.gclass0_0.GetDistanceBetween(gclass40_0.gclass85_0.XCoord,
                gclass40_0.gclass85_0.YCoord, this.double_0, this.double_1);
        }

        internal double method_1(PopulationData gclass146_0)
        {
            return this.class345_0.gclass2_0.gclass0_0.GetDistanceBetween(gclass146_0.method_87(), gclass146_0.method_88(),
                this.double_0, this.double_1);
        }
    }


    private sealed class Class347
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.System == this.gclass202_0.ActualSystem;
        }
    }


    private sealed class Class348
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0;
        }
    }


    private sealed class Class349
    {
        public RacialSystemSurvey gclass202_0;
        public Func<PopulationData, bool> func_0;
        public Func<AlienShipClassIntel, Decimal> func_1;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.System == this.gclass202_0.ActualSystem;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0;
        }

        internal Decimal method_2(AlienShipClassIntel gclass115_0)
        {
            return gclass115_0.method_2(this.gclass202_0);
        }
    }


    private sealed class Class350
    {
        public AlienRaceIntel gclass110_0;
        public UnknownNPRClass2.Class349 class349_0;

        internal bool method_0(Contact gclass65_0)
        {
            if (gclass65_0.ContactRace != this.gclass110_0.ActualAlienRace ||
                gclass65_0.System != this.class349_0.gclass202_0.ActualSystem)
                return false;
            return gclass65_0.ContactType == AuroraContactType.Population ||
                   gclass65_0.ContactType == AuroraContactType.Shipyard ||
                   gclass65_0.ContactType == AuroraContactType.GroundUnit ||
                   gclass65_0.ContactType == AuroraContactType.STOGroundUnit;
        }

        internal bool method_1(Contact gclass65_0)
        {
            return gclass65_0.ContactRace == this.gclass110_0.ActualAlienRace &&
                   gclass65_0.System == this.class349_0.gclass202_0.ActualSystem &&
                   gclass65_0.ContactType == AuroraContactType.Ship;
        }

        internal bool method_2(Contact gclass65_0)
        {
            return gclass65_0.ContactRace == this.gclass110_0.ActualAlienRace &&
                   gclass65_0.ContactType == AuroraContactType.Ship &&
                   gclass65_0.System == this.class349_0.gclass202_0.ActualSystem;
        }

        internal bool method_3(ShipData gclass40_0)
        {
            return gclass40_0.gclass187_0 == null || !this.gclass110_0.bTradeTreaty;
        }
    }


    private sealed class Class351
    {
        public List<StarSystem> list_0;
        public List<StarSystem> list_1;
        public List<StarSystem> list_2;
        public UnknownNPRClass2 gclass2_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return this.list_0.Contains(gclass202_0.ActualSystem);
        }

        internal bool method_1(RacialSystemSurvey gclass202_0)
        {
            return this.list_1.Contains(gclass202_0.ActualSystem);
        }

        internal bool method_2(RacialSystemSurvey gclass202_0)
        {
            return this.list_2.Contains(gclass202_0.ActualSystem);
        }
    }


    private sealed class Class352
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.System == this.gclass202_0.ActualSystem &&
                   gclass65_0.ContactType == AuroraContactType.Ship;
        }
    }


    private sealed class Class353
    {
        public RacialSystemSurvey gclass202_0;
        public UnknownNPRClass2.Class351 class351_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.System == this.gclass202_0.ActualSystem &&
                   this.class351_0.gclass2_0.gclass0_0.GameTime - gclass65_0.LastUpdate < AuroraUtils.decimal_34 &&
                   gclass65_0.ContactType == AuroraContactType.Ship;
        }
    }


    private sealed class Class354
    {
        public List<StarSystem> list_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return this.list_0.Contains(gclass202_0.ActualSystem);
        }
    }


    private sealed class Class355
    {
        public List<StarSystem> list_0;

        internal bool method_0(AlienPopulationIntel gclass113_0)
        {
            return this.list_0.Contains(gclass113_0.Population.gclass202_0.ActualSystem);
        }
    }


    private sealed class Class356
    {
        public FleetData gclass85_0;
        public UnknownNPRClass2.Class351 class351_0;

        internal bool method_0(FleetData gclass85_1)
        {
            return gclass85_1.gclass85_0 == this.gclass85_0;
        }

        internal double method_1(FleetData gclass85_1)
        {
            return this.class351_0.gclass2_0.gclass0_0.GetDistanceBetween(this.gclass85_0.XCoord, this.gclass85_0.YCoord,
                gclass85_1.XCoord, gclass85_1.YCoord);
        }
    }


    private sealed class Class357
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(RacialSystemSurvey gclass202_1)
        {
            return gclass202_1 != this.gclass202_0;
        }
    }


    private sealed class Class358
    {
        public UnknownNPRClass2 gclass2_0;
        public StarSystem gclass200_0;
        public GClass221 gclass221_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass2_0.gclass21_0 &&
                   gclass85_0.System.ActualSystem == this.gclass200_0 &&
                   gclass85_0.XCoord == this.gclass221_0.double_0 && gclass85_0.YCoord == this.gclass221_0.double_1;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass2_0.gclass21_0 &&
                   gclass146_0.gclass202_0.ActualSystem == this.gclass200_0;
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.method_87() == this.gclass221_0.double_0 &&
                   gclass146_0.method_88() == this.gclass221_0.double_1;
        }

        internal bool method_3(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass2_0.gclass21_0 && gclass103_0.PopulationData != null;
        }
    }


    private sealed class Class359
    {
        public List<PopulationData> list_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return this.list_0.Contains(gclass103_0.PopulationData);
        }
    }


    private sealed class Class360
    {
        public FireControlAssignment gclass36_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }
    }


    private sealed class Class361
    {
        public RacialSystemSurvey gclass202_0;
        public UnknownNPRClass2 gclass2_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.method_5() == AuroraContactStatus.Hostile &&
                   gclass65_0.DetectRace == this.gclass202_0.Race &&
                   this.gclass2_0.gclass0_0.GameTime - gclass65_0.LastUpdate < AuroraUtils.decimal_34 &&
                   gclass65_0.ContactType == AuroraContactType.Ship;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.System == this.gclass202_0;
        }
    }


    private sealed class Class362
    {
        public FleetData gclass85_0;

        internal bool method_0(FleetData gclass85_1)
        {
            return gclass85_1 != this.gclass85_0 && gclass85_1.XCoord == this.gclass85_0.XCoord &&
                   gclass85_1.YCoord == this.gclass85_0.YCoord && this.gclass85_0.method_24(gclass85_1);
        }
    }


    private sealed class Class363
    {
        public List<StarSystem> list_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return this.list_0.Contains(gclass202_0.ActualSystem);
        }
    }


    private sealed class Class364
    {
        public PopulationData gclass146_0;

        internal bool method_0(PopulationData gclass146_1)
        {
            return gclass146_1 != this.gclass146_0;
        }
    }


    private sealed class Class365
    {
        public ShipData gclass40_0;
        public UnknownNPRClass2 gclass2_0;

        internal bool method_0(ShipData gclass40_1)
        {
            return gclass40_1.gclass85_0.System == this.gclass40_0.gclass85_0.System;
        }

        internal double method_1(ShipData gclass40_1)
        {
            return this.gclass2_0.gclass0_0.GetDistanceBetween(gclass40_1.gclass85_0.XCoord, gclass40_1.gclass85_0.YCoord,
                this.gclass40_0.gclass85_0.XCoord, this.gclass40_0.gclass85_0.YCoord);
        }
    }


    private sealed class Class366
    {
        public UnknownNPRClass2 gclass2_0;
        public AutomatedClassDesignType genum120_0;

        internal bool method_0(ShipClass gclass22_0)
        {
            return gclass22_0.Race == this.gclass2_0.gclass21_0 &&
                   gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID == this.genum120_0;
        }
    }


    private sealed class Class367
    {
        public RacialSystemSurvey gclass202_0;
        public AutomatedClassDesignType genum120_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0.System == this.gclass202_0 &&
                   gclass40_0.Class.AutomatedClassDesign.AutomatedClassDesignTypeID == this.genum120_0;
        }
    }


    private sealed class Class368
    {
        public TechSystem gclass164_0;

        internal bool method_0(SwarmResearch gclass168_0)
        {
            return gclass168_0.TechSystem == this.gclass164_0;
        }
    }


    private sealed class Class369
    {
        public PopulationData gclass146_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData == this.gclass146_0;
        }

        internal bool method_1(MoveOrder gclass139_0)
        {
            return gclass139_0.Population == this.gclass146_0;
        }
    }


    private sealed class Class370
    {
        public PopulationData gclass146_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData == this.gclass146_0;
        }

        internal bool method_1(MoveOrder gclass139_0)
        {
            return gclass139_0.Population == this.gclass146_0;
        }
    }


    private sealed class Class371
    {
        public UnknownNPRClass2 gclass2_0;
        public List<StarSystem> list_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass2_0.gclass21_0;
        }

        internal bool method_1(RacialSystemBodySurvey gclass215_0)
        {
            return gclass215_0.Race == this.gclass2_0.gclass21_0;
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass2_0.gclass21_0 && gclass146_0.decimal_30 > 0M;
        }

        internal bool method_3(SystemBodyData gclass1_0)
        {
            return this.list_0.Contains(gclass1_0.SystemData);
        }
    }


    private sealed class Class372
    {
        public Species gclass194_0;
        public StarSystem gclass200_0;
        public UnknownNPRClass2.Class371 class371_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.Gravity >= this.gclass194_0.double_7 && gclass1_0.Gravity <= this.gclass194_0.double_8;
        }

        internal int method_1(SystemBodyData gclass1_0)
        {
            return this.class371_0.gclass2_0.gclass0_0.method_35(this.gclass200_0, gclass1_0.SystemData,
                this.class371_0.gclass2_0.gclass21_0);
        }
    }


    private sealed class Class373
    {
        public SystemBodyData gclass1_0;
        public UnknownNPRClass2 gclass2_0;
        public Species gclass194_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.SystemBodyData == this.gclass1_0 && gclass146_0.Race == this.gclass2_0.gclass21_0 &&
                   gclass146_0.Species == this.gclass194_0;
        }
    }


    private sealed class Class374
    {
        public List<MoveOrder> list_0;
        public List<GroundUnitFormationData> list_1;
        public UnknownNPRClass2 gclass2_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData != null &&
                   this.list_0.Select<MoveOrder, int>(gClass139 => gClass139.DestinationItemID).Contains<int>(gclass103_0.FormationID);
        }
    }


    private sealed class Class375
    {
        public AlienPopulationIntel gclass113_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.SystemBodyData == this.gclass113_0.Population.SystemBodyData;
        }

        internal bool method_1(Contact gclass65_0)
        {
            return gclass65_0.TargetPopulation == this.gclass113_0.Population;
        }
    }


    private sealed class Class376
    {
        public PopulationData gclass146_0;
        public UnknownNPRClass2.Class374 class374_0;

        internal bool method_0(GClass16 gclass16_0)
        {
            return gclass16_0.genum97_0 == this.gclass146_0.gclass6_0.genum97_0;
        }

        internal bool method_1(MoveOrder gclass139_0)
        {
            return gclass139_0.Population == this.gclass146_0;
        }

        internal bool method_2(FleetData gclass85_0)
        {
            return gclass85_0.method_257() == this.gclass146_0;
        }
    }


    private sealed class Class377
    {
        public List<FleetData> list_0;
        public UnknownNPRClass2.Class376 class376_0;
    }


    private sealed class Class378
    {
        public AutomatedGroundTemplateDesignType genum116_0;
        public UnknownNPRClass2.Class377 class377_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.OriginalTemplateData.AutomatedTemplateType == this.genum116_0;
        }

        internal bool method_1(GroundUnitFormationData gclass103_0)
        {
            return this.class377_0.list_0.Contains(gclass103_0.ShipData.gclass85_0) &&
                   gclass103_0.OriginalTemplateData.AutomatedTemplateType == this.genum116_0;
        }

        internal IEnumerable<GroundUnitFormationData> method_2(MoveOrder gclass139_0)
        {
            UnknownNPRClass2.Class379 class379 = new UnknownNPRClass2.Class379();
            class379.class378_0 = this;
            class379.gclass139_0 = gclass139_0;
            return this.class377_0.class376_0.class374_0.list_1.Where<GroundUnitFormationData>(class379.method_0);
        }

        internal bool method_3(GClass16 gclass16_0)
        {
            return gclass16_0.genum116_0 == this.genum116_0;
        }
    }


    private sealed class Class379
    {
        public MoveOrder gclass139_0;
        public UnknownNPRClass2.Class378 class378_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.FormationID == this.gclass139_0.DestinationItemID &&
                   gclass103_0.OriginalTemplateData.AutomatedTemplateType == this.class378_0.genum116_0;
        }
    }


    private sealed class Class380
    {
        public PopulationData gclass146_0;
        public UnknownNPRClass2.Class374 class374_0;

        internal bool method_0(GClass17 gclass17_0)
        {
            return gclass17_0.gclass146_0 == this.gclass146_0 && gclass17_0.int_2 > 0;
        }
    }


    private sealed class Class381
    {
        public GClass17 gclass17_0;
        public UnknownNPRClass2.Class380 class380_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.OriginalTemplateData.AutomatedTemplateType == this.gclass17_0.genum116_0;
        }

        internal int method_1(FleetData gclass85_0)
        {
            return this.class380_0.class374_0.gclass2_0.gclass0_0.method_35(gclass85_0.System.ActualSystem,
                this.gclass17_0.gclass146_0.gclass202_0.ActualSystem, this.class380_0.class374_0.gclass2_0.gclass21_0);
        }

        internal bool method_2(GClass17 gclass17_1)
        {
            return gclass17_1.genum116_0 == this.gclass17_0.genum116_0 && gclass17_1.int_6 > 0;
        }

        internal int method_3(GClass17 gclass17_1)
        {
            return this.class380_0.class374_0.gclass2_0.gclass0_0.method_35(
                gclass17_1.gclass146_0.gclass202_0.ActualSystem, this.gclass17_0.gclass146_0.gclass202_0.ActualSystem,
                this.class380_0.class374_0.gclass2_0.gclass21_0);
        }
    }


    private sealed class Class382
    {
        public FleetData gclass85_0;
        public UnknownNPRClass2.Class381 class381_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.OriginalTemplateData.AutomatedTemplateType == this.class381_0.gclass17_0.genum116_0 &&
                   gclass103_0.ShipData.gclass85_0 == this.gclass85_0;
        }
    }


    private sealed class Class383
    {
        public GClass17 gclass17_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.OriginalTemplateData.AutomatedTemplateType == this.gclass17_0.genum116_0;
        }
    }


    private sealed class Class384
    {
        public List<MoveOrder> list_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData != null && this.list_0.Select<MoveOrder, int>(gClass139 => gClass139.DestinationItemID)
                .Contains<int>(gclass103_0.FormationID);
        }
    }


    private sealed class Class385
    {
        public List<SystemBodyData> list_0;
        public UnknownNPRClass2 gclass2_0;

        internal bool method_0(Shipyard gclass193_0)
        {
            return !this.list_0.Contains(gclass193_0.Population.SystemBodyData);
        }
    }


    private sealed class Class386
    {
        public FleetData gclass85_0;
        public UnknownNPRClass2.Class385 class385_0;

        internal bool method_0(Shipyard gclass193_0)
        {
            return gclass193_0.Population.gclass202_0 == this.gclass85_0.System &&
                   gclass193_0.SYType == this.class385_0.gclass2_0.auroraShipyardType_0 &&
                   gclass193_0.Capacity >= this.class385_0.gclass2_0.decimal_4;
        }

        internal double method_1(PopulationData gclass146_0)
        {
            return this.gclass85_0.System.ActualSystem.method_3(this.gclass85_0.XCoord, this.gclass85_0.YCoord,
                gclass146_0.method_87(), gclass146_0.method_88());
        }
    }


    private sealed class Class387
    {
        public List<SystemBodyData> list_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return !this.list_0.Contains(gclass146_0.SystemBodyData);
        }
    }


    private sealed class Class388
    {
        public FleetData gclass85_0;

        internal double method_0(PopulationData gclass146_0)
        {
            return this.gclass85_0.System.ActualSystem.method_3(this.gclass85_0.XCoord, this.gclass85_0.YCoord,
                gclass146_0.method_87(), gclass146_0.method_88());
        }
    }


    private sealed class Class389
    {
        public Decimal decimal_0;
        public UnknownNPRClass2.Class388 class388_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.class388_0.gclass85_0.System &&
                   gclass146_0.gclass6_0.decimal_0 > this.decimal_0;
        }
    }


    private sealed class Class390
    {
        public FleetData gclass85_0;

        internal bool method_0(AetherGate gclass210_0)
        {
            return gclass210_0.gclass200_0 == this.gclass85_0.System.ActualSystem;
        }
    }


    private sealed class Class391
    {
        public FleetData gclass85_0;
        public UnknownNPRClass2 gclass2_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0.System == this.gclass85_0.System;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0.System == this.gclass85_0.System;
        }

        internal double method_2(ShipData gclass40_0)
        {
            return this.gclass2_0.gclass0_0.GetDistanceBetween(this.gclass85_0.XCoord, this.gclass85_0.YCoord,
                gclass40_0.gclass85_0.XCoord, gclass40_0.gclass85_0.YCoord);
        }
    }


    private sealed class Class392
    {
        public List<ShipData> list_0;

        internal bool method_0(MissileSalvo gclass132_0)
        {
            return this.list_0.Contains(gclass132_0.Ship);
        }
    }


    private sealed class Class393
    {
        public ShipData gclass40_0;

        internal bool method_0(ShipData gclass40_1)
        {
            return gclass40_1.gclass40_0 == this.gclass40_0;
        }
    }


    private sealed class Class394
    {
        public List<SystemBodyData> list_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return !this.list_0.Contains(gclass146_0.SystemBodyData);
        }
    }


    private sealed class Class395
    {
        public FleetData gclass85_0;
        public Func<ShipData, bool> func_0;
        public Func<ShipData, bool> func_1;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0;
        }

        internal bool method_2(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }


    private sealed class Class396
    {
        public RaceMissile gclass129_0;

        internal bool method_0(ShipOrdnance gclass130_0)
        {
            return gclass130_0.RaceMissile == this.gclass129_0;
        }

        internal bool method_1(ShipOrdnance gclass130_0)
        {
            return gclass130_0.RaceMissile == this.gclass129_0;
        }
    }


    private sealed class Class397
    {
        public ShipOrdnance gclass130_0;
        public UnknownNPRClass2.Class395 class395_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.class395_0.gclass85_0.System &&
                   gclass146_0.method_87() == this.class395_0.gclass85_0.XCoord &&
                   gclass146_0.method_88() == this.class395_0.gclass85_0.YCoord &&
                   gclass146_0.gclass6_0.dictionary_0.ContainsKey(this.gclass130_0.RaceMissile);
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.class395_0.gclass85_0.System &&
                   gclass146_0.gclass6_0.dictionary_0.ContainsKey(this.gclass130_0.RaceMissile);
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.gclass6_0.dictionary_0[this.gclass130_0.RaceMissile].Amount >=
                   this.gclass130_0.Amount / 2.0;
        }

        internal int method_3(PopulationData gclass146_0)
        {
            return gclass146_0.gclass6_0.dictionary_0[this.gclass130_0.RaceMissile].Amount;
        }
    }


    private sealed class Class398
    {
        public UnknownNPRClass2 gclass2_0;
        public GEnum104 genum104_0;

        internal bool method_0(JumpPoint gclass120_0)
        {
            return gclass120_0.method_2(this.gclass2_0.gclass21_0);
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass2_0.gclass21_0;
        }

        internal RacialSystemSurvey method_2(JumpPoint gclass120_0)
        {
            return this.gclass2_0.gclass21_0.method_128(gclass120_0.SystemData);
        }
    }


    private sealed class Class399
    {
        public List<int> list_0;
        public List<RacialSystemSurvey> list_1;
        public UnknownNPRClass2.Class398 class398_0;
        public Func<FleetData, bool> func_0;

        internal bool method_0(JumpPoint gclass120_0)
        {
            return !this.list_0.Contains(gclass120_0.WarpPointID);
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.genum104_0 == this.class398_0.genum104_0 &&
                   this.list_1.Contains(gclass85_0.System) &&
                   gclass85_0.NPRSomething.genum100_0 == GEnum100.const_2 && !gclass85_0.NPRSomething.bRedeployOrderGiven &&
                   !gclass85_0.method_42(MoveActionType.StandardTransit);
        }
    }


    private sealed class Class400
    {
        public RacialSystemSurvey gclass202_0;
        public UnknownNPRClass2.Class399 class399_0;
        public Func<FleetData, bool> func_0;
        public Func<FleetData, int> func_1;

        internal bool method_0(JumpPoint gclass120_0)
        {
            return this.class399_0.class398_0.gclass2_0.gclass21_0.method_128(gclass120_0.SystemData) ==
                   this.gclass202_0;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.genum104_0 == this.class399_0.class398_0.genum104_0 &&
                   gclass85_0.System == this.gclass202_0 && gclass85_0.NPRSomething.genum100_0 == GEnum100.const_2 &&
                   !gclass85_0.NPRSomething.bRedeployOrderGiven && !gclass85_0.method_42(MoveActionType.StandardTransit);
        }

        internal int method_2(FleetData gclass85_0)
        {
            return this.class399_0.class398_0.gclass2_0.gclass0_0.method_35(gclass85_0.System.ActualSystem,
                this.gclass202_0.ActualSystem, this.class399_0.class398_0.gclass2_0.gclass21_0);
        }
    }


    private sealed class Class401
    {
        public JumpPoint gclass120_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return this.gclass120_0.JumpGateStrength > 0 || gclass85_0.method_241();
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return this.gclass120_0.JumpGateStrength > 0 || gclass85_0.method_241();
        }
    }


    private sealed class Class402
    {
        public GEnum104 genum104_0;
        public GEnum100 genum100_0;
        public List<RacialSystemSurvey> list_0;
        public UnknownNPRClass2 gclass2_0;
        public Func<FleetData, bool> func_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.genum104_0 == this.genum104_0 &&
                   (this.list_0.Contains(gclass85_0.System) || gclass85_0.System.gclass3_0.int_2 < 1) &&
                   gclass85_0.NPRSomething.genum100_0 >= this.genum100_0 && !gclass85_0.NPRSomething.bRedeployOrderGiven &&
                   !gclass85_0.NPRSomething.bool_2;
        }
    }


    private sealed class Class403
    {
        public RacialSystemSurvey gclass202_0;
        public UnknownNPRClass2.Class402 class402_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.genum104_0 == this.class402_0.genum104_0 &&
                   gclass85_0.NPRSomething.gclass202_0 == this.gclass202_0 &&
                   gclass85_0.NPRSomething.genum100_0 >= this.class402_0.genum100_0 && gclass85_0.NPRSomething.bRedeployOrderGiven;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.genum104_0 == this.class402_0.genum104_0 &&
                   gclass85_0.System == this.gclass202_0 &&
                   gclass85_0.NPRSomething.genum100_0 >= this.class402_0.genum100_0 && !gclass85_0.NPRSomething.bRedeployOrderGiven;
        }

        internal int method_2(FleetData gclass85_0)
        {
            return this.class402_0.gclass2_0.gclass0_0.method_35(gclass85_0.System.ActualSystem,
                this.gclass202_0.ActualSystem, this.class402_0.gclass2_0.gclass21_0);
        }
    }


    private sealed class Class404
    {
        public RacialSystemSurvey gclass202_0;
        public Decimal decimal_0;
        public UnknownNPRClass2 gclass2_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.bool_2 && gclass85_0.NPRSomething.gclass202_0 == this.gclass202_0 &&
                   gclass85_0.NPRSomething.genum100_0 == GEnum100.const_2 && gclass85_0.NPRSomething.bRedeployOrderGiven;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.method_13() > this.decimal_0;
        }

        internal bool method_2(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.bool_2 && gclass85_0.NPRSomething.genum100_0 == GEnum100.const_2 &&
                   !gclass85_0.NPRSomething.bRedeployOrderGiven && !gclass85_0.NPRSomething.bool_2 &&
                   gclass85_0.System != this.gclass202_0;
        }

        internal bool method_3(FleetData gclass85_0)
        {
            return gclass85_0.method_13() > this.decimal_0;
        }

        internal int method_4(FleetData gclass85_0)
        {
            return this.gclass2_0.gclass0_0.method_35(gclass85_0.System.ActualSystem, this.gclass202_0.ActualSystem,
                this.gclass2_0.gclass21_0);
        }
    }


    private sealed class Class405
    {
        public GEnum104 genum104_0;
        public List<RacialSystemSurvey> list_0;
        public UnknownNPRClass2 gclass2_0;
        public Func<FleetData, bool> func_0;
        public Func<FleetData, bool> func_1;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.genum104_0 == this.genum104_0;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.genum104_0 == this.genum104_0 && this.list_0.Contains(gclass85_0.System) &&
                   gclass85_0.NPRSomething.genum100_0 == GEnum100.const_2 && !gclass85_0.NPRSomething.bRedeployOrderGiven;
        }
    }


    private sealed class Class406
    {
        public RacialSystemSurvey gclass202_0;
        public UnknownNPRClass2.Class405 class405_0;
        public Func<FleetData, bool> func_0;
        public Func<FleetData, int> func_1;

        internal JumpPoint method_0(RacialSystemSurvey gclass202_1)
        {
            return gclass202_1.method_11(this.gclass202_0).LinkedJumpPoint;
        }

        internal bool method_1(Waypoint gclass214_0)
        {
            return gclass214_0.Race == this.gclass202_0.Race &&
                   gclass214_0.System == this.gclass202_0.ActualSystem &&
                   gclass214_0.WaypointType == WayPointType.TransitPOI;
        }

        internal bool method_2(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.genum104_0 == this.class405_0.genum104_0 &&
                   gclass85_0.System == this.gclass202_0 && gclass85_0.NPRSomething.genum100_0 == GEnum100.const_2 &&
                   !gclass85_0.NPRSomething.bRedeployOrderGiven;
        }

        internal int method_3(FleetData gclass85_0)
        {
            return this.class405_0.gclass2_0.gclass0_0.method_35(gclass85_0.System.ActualSystem,
                this.gclass202_0.ActualSystem, this.class405_0.gclass2_0.gclass21_0);
        }
    }


    private sealed class Class407
    {
        public JumpPoint gclass120_0;
        public UnknownNPRClass2.Class406 class406_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.genum104_0 == this.class406_0.class405_0.genum104_0 &&
                   gclass85_0.System == this.class406_0.gclass202_0 &&
                   gclass85_0.XCoord == this.gclass120_0.XCoord && gclass85_0.YCoord == this.gclass120_0.YCoord &&
                   gclass85_0.NPRSomething.genum100_0 == GEnum100.const_2 && !gclass85_0.NPRSomething.bRedeployOrderGiven;
        }
    }


    private sealed class Class408
    {
        public JumpPoint gclass120_0;

        internal bool method_0(MoveOrder gclass139_0)
        {
            return gclass139_0.DestinationType == DestinationType.const_0 && gclass139_0.DestinationID == this.gclass120_0.WarpPointID &&
                   gclass139_0.MoveActionType.MoveActionType == MoveActionType.MoveTo;
        }
    }


    private sealed class Class409
    {
        public RacialSystemSurvey gclass202_0;
        public GEnum104 genum104_0;
        public Func<FleetData, bool> func_0;

        internal JumpPoint method_0(RacialSystemSurvey gclass202_1)
        {
            return gclass202_1.method_11(this.gclass202_0).LinkedJumpPoint;
        }

        internal bool method_1(Waypoint gclass214_0)
        {
            return gclass214_0.Race == this.gclass202_0.Race &&
                   gclass214_0.System == this.gclass202_0.ActualSystem &&
                   gclass214_0.WaypointType == WayPointType.TransitPOI;
        }

        internal bool method_2(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.genum104_0 == this.genum104_0 && gclass85_0.System == this.gclass202_0 &&
                   gclass85_0.NPRSomething.genum100_0 == GEnum100.const_2 && !gclass85_0.NPRSomething.bRedeployOrderGiven;
        }
    }


    private sealed class Class410
    {
        public JumpPoint gclass120_0;
        public UnknownNPRClass2.Class409 class409_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.System == this.class409_0.gclass202_0 &&
                   gclass85_0.XCoord == this.gclass120_0.XCoord && gclass85_0.YCoord == this.gclass120_0.YCoord &&
                   gclass85_0.NPRSomething.genum100_0 == GEnum100.const_2 && !gclass85_0.NPRSomething.bRedeployOrderGiven;
        }
    }


    private sealed class Class411
    {
        public FleetData gclass85_0;
        public UnknownNPRClass2 gclass2_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass85_0.System;
        }

        internal int method_1(PopulationData gclass146_0)
        {
            return this.gclass2_0.gclass0_0.method_35(this.gclass85_0.System.ActualSystem,
                gclass146_0.gclass202_0.ActualSystem, this.gclass85_0.Race);
        }
    }


    private sealed class Class412
    {
        public FleetData gclass85_0;
        public UnknownNPRClass2 gclass2_0;

        internal bool method_0(FleetData gclass85_1)
        {
            return gclass85_1.System == this.gclass85_0.System && gclass85_1.MoveOrderDictionary.Count == 0;
        }

        internal double method_1(FleetData gclass85_1)
        {
            return this.gclass2_0.gclass0_0.GetDistanceBetween(this.gclass85_0.XCoord, this.gclass85_0.YCoord,
                gclass85_1.XCoord, gclass85_1.YCoord);
        }

        internal int method_2(FleetData gclass85_1)
        {
            return this.gclass2_0.gclass0_0.method_35(this.gclass85_0.System.ActualSystem,
                gclass85_1.System.ActualSystem, this.gclass85_0.Race);
        }

        internal bool method_3(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass85_0.System;
        }

        internal int method_4(PopulationData gclass146_0)
        {
            return this.gclass2_0.gclass0_0.method_35(this.gclass85_0.System.ActualSystem,
                gclass146_0.gclass202_0.ActualSystem, this.gclass85_0.Race);
        }
    }


    private sealed class Class413
    {
        public UnknownNPRClass2 gclass2_0;
        public List<RacialSystemSurvey> list_0;

        internal bool method_0(StarSystem gclass200_0)
        {
            return this.gclass2_0.gclass21_0.RacialSystemDictionary.Values
                .Select<RacialSystemSurvey, StarSystem>(gClass202 => gClass202.ActualSystem).ToList<StarSystem>()
                .Contains(gclass200_0);
        }

        internal RacialSystemSurvey method_1(StarSystem gclass200_0)
        {
            return this.gclass2_0.gclass21_0.method_128(gclass200_0);
        }

        internal bool method_2(RacialSystemSurvey gclass202_0)
        {
            return !this.list_0.Contains(gclass202_0) && gclass202_0.gclass3_0.genum95_0 != 0;
        }

        internal bool method_3(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass2_0.gclass21_0 &&
                   gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_9;
        }

        internal bool method_4(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass2_0.gclass21_0 &&
                   gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_9 && !gclass85_0.NPRSomething.bRedeployOrderGiven &&
                   !gclass85_0.NPRSomething.bool_2;
        }

        internal bool method_5(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass2_0.gclass21_0 &&
                   gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_22;
        }
    }


    private sealed class Class414
    {
        public List<StarSystem> list_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return this.list_0.Contains(gclass1_0.SystemData);
        }
    }


    private sealed class Class415
    {
        public FleetData gclass85_0;
        public Func<SystemBodyData, bool> func_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass85_0.System.ActualSystem &&
                   gclass1_0.XCoordinate == this.gclass85_0.XCoord &&
                   gclass1_0.YCoordinate == this.gclass85_0.YCoord;
        }
    }


    private sealed class Class416
    {
        public FleetData gclass85_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.XCoordinate == this.gclass85_0.XCoord &&
                   gclass1_0.YCoordinate == this.gclass85_0.YCoord &&
                   gclass1_0.SystemData == this.gclass85_0.System.ActualSystem;
        }
    }
}