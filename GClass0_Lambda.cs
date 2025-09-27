using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Aurora;

#nullable disable
public partial class GClass0
{
    private class staticCompGen
    {
        public static System.Func<GClass158, int> staticCompMem__14_25;
        public static System.Func<WeaponFireControlAssignment, bool> staticCompMem__100_27;
        public static System.Func<GClass34, bool> staticCompMem__100_48;
    }

    [CompilerGenerated]
    private sealed class Class5
    {
        public GameRace gclass21_0;
    }

    [CompilerGenerated]
    private sealed class Class6
    {
        public GClass132 gclass132_0;
        public GClass0.Class5 class5_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.gclass21_1 == this.class5_0.gclass21_0 && gclass65_0.gclass132_0 == this.gclass132_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class7
    {
        public FireControlAssignment gclass36_0;
        public GClass0 gc0this;
        public System.Func<GClass131, bool> func_0;
        public System.Func<GClass131, double> func_1;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }

        internal bool method_1(GClass132 gclass132_0)
        {
            return this.gclass36_0.Ship.gclass21_0 == gclass132_0.gclass21_1 &&
                   gclass132_0.list_0.Contains(this.gclass36_0.Ship.gclass21_0);
        }

        internal bool method_2(GClass132 gclass132_0)
        {
            return gclass132_0.gclass40_1 == this.gclass36_0.Ship;
        }

        internal bool method_3(GClass131 gclass131_0)
        {
            return (AuroraPointDefenceConcentration)gclass131_0.list_0.Count <
                   this.gclass36_0.PointDefenceConcentration;
        }

        internal double method_4(GClass131 gclass131_0)
        {
            return gc0this.GetDistanceBetween(this.gclass36_0.Ship.gclass85_0.XCoord,
                this.gclass36_0.Ship.gclass85_0.YCoord, gclass131_0.gclass132_0.double_0,
                gclass131_0.gclass132_0.double_1);
        }
    }

    [CompilerGenerated]
    private sealed class Class8
    {
        public int int_0;
        public GClass0.Class7 class7_0;
        public GClass0 gc0this;

        internal bool method_0(GClass132 gclass132_0)
        {
            return gc0this.GetDistanceBetween(this.class7_0.gclass36_0.Ship.gclass85_0.XCoord,
                       this.class7_0.gclass36_0.Ship.gclass85_0.YCoord, gclass132_0.double_0,
                       gclass132_0.double_1) <=
                   this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class9
    {
        public GroundUnitFormationElement gclass39_0;

        internal bool method_0(GClass132 gclass132_0)
        {
            return this.gclass39_0.Formation.RaceData == gclass132_0.gclass21_1 &&
                   gclass132_0.list_0.Contains(this.gclass39_0.Formation.RaceData);
        }

        internal bool method_1(GClass132 gclass132_0)
        {
            return gclass132_0.gclass146_0 == this.gclass39_0.Formation.PopulationData;
        }
    }

    [CompilerGenerated]
    private sealed class Class10
    {
        public double double_0;
        public double double_1;
        public int int_0;
        public GClass0 gc0this;
        public System.Func<GClass131, double> func_0;

        internal bool method_0(GClass132 gclass132_0)
        {
            return gc0this.GetDistanceBetween(this.double_0, this.double_1, gclass132_0.double_0, gclass132_0.double_1) <=
                   this.int_0;
        }

        internal double method_1(GClass131 gclass131_0)
        {
            return gc0this.GetDistanceBetween(this.double_0, this.double_1, gclass131_0.gclass132_0.double_0,
                gclass131_0.gclass132_0.double_1);
        }
    }

    [CompilerGenerated]
    private sealed class Class11
    {
        public SystemBodyData gclass1_0;

        internal bool method_0(GClass220 gclass220_0)
        {
            return gclass220_0.gclass1_0 == this.gclass1_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class12
    {
        public SystemData200 gclass200_0;

        internal bool method_0(Star197 gclass197_0)
        {
            return gclass197_0.SystemData == this.gclass200_0 && gclass197_0.Component == 1;
        }
    }

    [CompilerGenerated]
    private sealed class Class13
    {
        public StellarType gclass217_0;
        public int int_0;

        internal bool method_0(StellarType gclass217_1)
        {
            return gclass217_1.SpectralNumber == this.int_0 && gclass217_1.SpectralClass == this.gclass217_0.SpectralClass &&
                   gclass217_1.SizeText == this.gclass217_0.SizeText;
        }
    }

    [CompilerGenerated]
    private sealed class Class14
    {
        public SystemData200 gclass200_0;

        internal double method_0(DIMKnownSystemsData198 gclass198_0)
        {
            return Math.Pow(gclass198_0.X - this.gclass200_0.KnownSystemData.X, 2.0) +
                   Math.Pow(gclass198_0.Y - this.gclass200_0.KnownSystemData.Y, 2.0) +
                   Math.Pow(gclass198_0.Z - this.gclass200_0.KnownSystemData.Z, 2.0);
        }
    }

    [CompilerGenerated]
    private sealed class Class15
    {
        public SystemData200 gclass200_0;

        internal bool method_0(JumpPoint120 gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass200_0;
        }

        internal bool method_1(SystemData200 gclass200_1)
        {
            return gclass200_1 != this.gclass200_0 && gclass200_1.SystemNumber >= 0;
        }

        internal bool method_2(SystemData200 gclass200_1)
        {
            return gclass200_1 != this.gclass200_0 && gclass200_1.SystemNumber >= 0;
        }

        internal double method_3(SystemData200 gclass200_1)
        {
            return Math.Pow(gclass200_1.KnownSystemData.X + this.gclass200_0.KnownSystemData.X, 2.0) +
                   Math.Pow(gclass200_1.KnownSystemData.Y + this.gclass200_0.KnownSystemData.Y, 2.0) +
                   Math.Pow(gclass200_1.KnownSystemData.Z + this.gclass200_0.KnownSystemData.Z, 2.0);
        }
    }

    [CompilerGenerated]
    private sealed class Class16
    {
        public SystemData200 gclass200_0;

        internal bool method_0(JumpPoint120 gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass200_0;
        }

        internal double method_1(SystemData200 gclass200_1)
        {
            return Math.Pow(gclass200_1.KnownSystemData.X + this.gclass200_0.KnownSystemData.X, 2.0) +
                   Math.Pow(gclass200_1.KnownSystemData.Y + this.gclass200_0.KnownSystemData.Y, 2.0) +
                   Math.Pow(gclass200_1.KnownSystemData.Z + this.gclass200_0.KnownSystemData.Z, 2.0);
        }
    }

    [CompilerGenerated]
    private sealed class Class17
    {
        public SystemData200 gclass200_0;

        internal bool method_0(JumpPoint120 gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass200_0;
        }

        internal int method_1(SystemData200 gclass200_1)
        {
            return Math.Abs(gclass200_1.SystemNumber - this.gclass200_0.SystemNumber);
        }
    }

    [CompilerGenerated]
    private sealed class Class18
    {
        public RacialSystemSurvey gclass202_0;
        public GClass0 gclass0_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.System.ActualSystemData == this.gclass202_0.ActualSystemData &&
                   gclass85_0.Race == this.gclass202_0.Race;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0;
        }

        internal bool method_2(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData.gclass202_0 == this.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class19
    {
        public int int_0;
        public GClass0.Class18 class18_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.gclass21_1 == this.class18_0.gclass202_0.Race &&
                   gclass65_0.auroraContactType_0 == AuroraContactType.Ship &&
                   gclass65_0.gclass200_0 == this.class18_0.gclass202_0.ActualSystemData &&
                   gclass65_0.decimal_3 >= this.class18_0.gclass0_0.GameTime - this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class20
    {
        public FCTShipData40 gclass40_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.int_1 == this.gclass40_0.int_8;
        }
    }

    [CompilerGenerated]
    private sealed class Class21
    {
        public GClass132 gclass132_0;

        internal bool method_0(GClass132 gclass132_1)
        {
            return gclass132_1.gclass132_0 == this.gclass132_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class22
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class23
    {
        public GClass233 gclass233_0;
        public GClass0.Class22 class22_0;

        internal bool method_0(GClass63 gclass63_0)
        {
            return gclass63_0.string_0 == this.gclass233_0.method_1(this.class22_0.gclass202_0.Race, false);
        }
    }

    [CompilerGenerated]
    private sealed class Class24
    {
        public FCTShipData40 gclass40_0;

        internal bool method_0(GClass64 gclass64_0)
        {
            return gclass64_0.auroraContactStatus_0 == this.gclass40_0.auroraContactStatus_0 &&
                   gclass64_0.string_0 == this.gclass40_0.string_4 &&
                   gclass64_0.gclass221_0.double_0 == this.gclass40_0.gclass221_0.double_0 &&
                   gclass64_0.gclass221_0.double_1 == this.gclass40_0.gclass221_0.double_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class25
    {
        public GClass132 gclass132_0;

        internal bool method_0(GClass64 gclass64_0)
        {
            return gclass64_0.auroraContactStatus_0 == this.gclass132_0.auroraContactStatus_0 &&
                   gclass64_0.string_0 == this.gclass132_0.string_2 &&
                   gclass64_0.gclass221_0.double_0 == this.gclass132_0.gclass221_1.double_0 &&
                   gclass64_0.gclass221_0.double_1 == this.gclass132_0.gclass221_1.double_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class26
    {
        public GClass228 gclass228_0;

        internal bool method_0(GClass28 gclass28_0)
        {
            return gclass28_0.gclass230_0 == this.gclass228_0.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class27
    {
        public FleetData gclass85_0;
        public System.Func<FleetData, bool> func_0;
        public System.Func<SubFleet, bool> func_1;
        public System.Func<FCTShipData40, bool> func_2;
        public System.Func<FCTShipData40, bool> func_3;

        internal bool method_0(FleetData gclass85_1)
        {
            return gclass85_1.System.ActualSystemData == this.gclass85_0.System.ActualSystemData &&
                   gclass85_1.Race != this.gclass85_0.Race;
        }

        internal bool method_1(SubFleet gclass84_0)
        {
            return gclass84_0.ParentFleet == this.gclass85_0;
        }

        internal bool method_2(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0 && gclass40_0.gclass22_0.int_23 == 1;
        }

        internal bool method_3(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0 && gclass40_0.gclass22_0.int_52 == 1;
        }
    }

    [CompilerGenerated]
    private sealed class Class28
    {
        public MoveOrder gclass139_0;
        public System.Func<GClass233, bool> func_0;

        internal bool method_0(GClass233 gclass233_0)
        {
            return gclass233_0.int_0 == this.gclass139_0.DestinationID;
        }
    }

    [CompilerGenerated]
    private sealed class Class29
    {
        public FleetData gclass85_0;

        internal bool method_0(FleetData gclass85_1)
        {
            return gclass85_1 != this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class30
    {
        public FleetData gclass85_0;

        internal bool method_0(FleetData gclass85_1)
        {
            return gclass85_1 != this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class31
    {
        public Decimal decimal_0;
        public GClass0 gclass0_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.LastMoveTime <= this.decimal_0 && gclass85_0.AnchorFleet != null;
        }
    }

    [CompilerGenerated]
    private sealed class Class32
    {
        public FleetData gclass85_0;
        public GClass0.Class31 class31_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.gclass21_1 == this.gclass85_0.Race &&
                   gclass65_0.gclass40_0 == this.gclass85_0.gclass117_0.gclass40_0 &&
                   gclass65_0.decimal_3 == this.class31_0.decimal_0 &&
                   gclass65_0.gclass200_0 == this.gclass85_0.System.ActualSystemData;
        }

        internal bool method_1(GClass65 gclass65_0)
        {
            return gclass65_0.gclass21_1 == this.gclass85_0.Race && gclass65_0.gclass40_0 != null &&
                   gclass65_0.decimal_3 == this.class31_0.decimal_0 &&
                   gclass65_0.gclass200_0 == this.gclass85_0.System.ActualSystemData;
        }

        internal bool method_2(GClass65 gclass65_0)
        {
            return this.gclass85_0.Race.dictionary_11.Values.Where<GClass115>(gc115 => gc115.list_1.Count > 0)
                .Select<GClass115, GClass22>(gc115 => gc115.gclass22_0)
                .Contains<GClass22>(gclass65_0.gclass40_0.gclass22_0);
        }

        internal double method_3(GClass65 gclass65_0)
        {
            return this.class31_0.gclass0_0.GetDistanceBetween(this.gclass85_0.AnchorFleet.XCoord,
                this.gclass85_0.AnchorFleet.YCoord, gclass65_0.double_0, gclass65_0.double_1);
        }

        internal bool method_4(GClass65 gclass65_0)
        {
            return gclass65_0.gclass21_1 == this.gclass85_0.Race && gclass65_0.gclass40_0 != null &&
                   gclass65_0.decimal_3 == this.class31_0.decimal_0 &&
                   gclass65_0.gclass200_0 == this.gclass85_0.System.ActualSystemData;
        }

        internal double method_5(GClass65 gclass65_0)
        {
            return this.class31_0.gclass0_0.GetDistanceBetween(this.gclass85_0.AnchorFleet.XCoord,
                this.gclass85_0.AnchorFleet.YCoord, gclass65_0.double_0, gclass65_0.double_1);
        }
    }

    [CompilerGenerated]
    private sealed class Class33
    {
        public FleetData gclass85_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class34
    {
        public SystemData200 gclass200_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.Name == "Earth" && gclass1_0.SystemData == this.gclass200_0;
        }

        internal bool method_1(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class35
    {
        public RaceOperationalGroupElement gclass11_0;

        internal bool method_0(GClass22 gclass22_0)
        {
            return gclass22_0.gclass14_0.AutomatedClassDesignTypeID == this.gclass11_0.AutomatedClassDesign.AutomatedClassDesignTypeID;
        }
    }

    [CompilerGenerated]
    private sealed class Class36
    {
        public GameRace gclass21_0;
        public OperationalGroup gclass9_0;
        public System.Func<GroundUnitFormationTemplateData, bool> func_0;
        public System.Func<GroundUnitFormationTemplateData, bool> func_1;
        public System.Func<GroundUnitFormationTemplateData, bool> func_2;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass21_0 && gclass85_0.NPROperationGroup == this.gclass9_0;
        }

        internal bool method_1(GroundUnitFormationTemplateData gclass102_0)
        {
            return gclass102_0.RaceData == this.gclass21_0 && gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.BoardingSwarm;
        }

        internal bool method_2(GroundUnitFormationTemplateData gclass102_0)
        {
            return gclass102_0.RaceData == this.gclass21_0 && gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.PlanetaryAssaultSwarm;
        }

        internal bool method_3(GroundUnitFormationTemplateData gclass102_0)
        {
            return gclass102_0.RaceData == this.gclass21_0 && gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.EldarAssaultForce;
        }
    }

    [CompilerGenerated]
    private sealed class Class37
    {
        public RaceOperationalGroupElement gclass11_0;

        internal bool method_0(GClass22 gclass22_0)
        {
            return gclass22_0.gclass14_0.AutomatedClassDesignTypeID == this.gclass11_0.AutomatedClassDesign.AutomatedClassDesignTypeID;
        }
    }

    [CompilerGenerated]
    private sealed class Class38
    {
        public GameRace gclass21_0;
        public OperationalGroup gclass9_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass21_0 && gclass85_0.NPROperationGroup == this.gclass9_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class39
    {
        public RaceOperationalGroupElement gclass11_0;

        internal bool method_0(GClass22 gclass22_0)
        {
            return gclass22_0.gclass14_0.AutomatedClassDesignTypeID == this.gclass11_0.AutomatedClassDesign.AutomatedClassDesignTypeID;
        }
    }

    [CompilerGenerated]
    private sealed class Class40
    {
        public GameRace gclass21_0;

        internal bool method_0(NavalAdminCommand gclass83_0)
        {
            return gclass83_0.Race == this.gclass21_0 && gclass83_0.ParentAdminCommand == null;
        }

        internal bool method_1(GClass22 gclass22_0)
        {
            return gclass22_0.gclass21_0 == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class41
    {
        public SystemData200 gclass200_0;
        public System.Func<Star197, bool> func_0;
        public System.Func<SystemBodyData, bool> func_1;

        internal bool method_0(Star197 gclass197_0)
        {
            return gclass197_0.SystemData == this.gclass200_0;
        }

        internal bool method_1(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0 && gclass1_0.StarData.bool_1 &&
                   (gclass1_0.BodyClass == PlanetBodyClass.Planet || gclass1_0.BodyClass == PlanetBodyClass.Moon) &&
                   gclass1_0.BodyTypeId != AuroraSystemBodyType.GasGiant &&
                   gclass1_0.BodyTypeId != AuroraSystemBodyType.Superjovian;
        }
    }

    [CompilerGenerated]
    private sealed class Class42
    {
        public SystemData200 gclass200_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0;
        }

        internal bool method_1(Star197 gclass197_0)
        {
            return gclass197_0.SystemData == this.gclass200_0;
        }

        internal bool method_2(JumpPoint120 gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass200_0;
        }

        internal bool method_3(GClass212 gclass212_0)
        {
            return gclass212_0.gclass200_0 == this.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class43
    {
        public double double_0;
        public double double_1;

        internal bool method_0(DIMKnownSystemsData198 gclass198_0)
        {
            return gclass198_0.Distance > this.double_0 && gclass198_0.Distance < this.double_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class44
    {
        public FleetData gclass85_0;

        internal bool method_0(GClass37 gclass37_0)
        {
            return gclass37_0.gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class45
    {
        public ShipComponent gclass230_0;
        public GClass0.Class44 class44_0;

        internal bool method_0(GClass37 gclass37_0)
        {
            return gclass37_0.gclass40_0.gclass85_0 == this.class44_0.gclass85_0 &&
                   gclass37_0.gclass230_0 == this.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class46
    {
        public PopulationData gclass146_0;

        internal bool method_0(GClass37 gclass37_0)
        {
            return gclass37_0.gclass39_0.Formation.PopulationData == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class47
    {
        public ShipComponent gclass230_0;
        public GClass0.Class46 class46_0;

        internal bool method_0(GClass37 gclass37_0)
        {
            return gclass37_0.gclass39_0.Formation.PopulationData == this.class46_0.gclass146_0 &&
                   gclass37_0.gclass230_0 == this.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class48
    {
        public GClass37 gclass37_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.int_8 == this.gclass37_0.int_0;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.PopulationID == this.gclass37_0.int_0;
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.PopulationID == this.gclass37_0.int_0;
        }

        internal bool method_3(GroundUnitFormationElement gclass39_0)
        {
            return gclass39_0.DetectingRaceList.Contains(this.gclass37_0.gclass21_1);
        }
    }

    [CompilerGenerated]
    private sealed class Class49
    {
        public FCTShipData40 gclass40_0;
        public GClass117 gclass117_0;

        internal bool method_0(GClass172 gclass172_0)
        {
            return gclass172_0.gclass1_0.SystemData == this.gclass40_0.gclass85_0.System.ActualSystemData;
        }

        internal bool method_1(GClass117 gclass117_1)
        {
            return gclass117_1.gclass40_0.gclass85_0 == this.gclass117_0.gclass40_0.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class50
    {
        public PopulationData gclass146_0;
        public GClass193 gclass193_0;

        internal bool method_0(GClass193 gclass193_1)
        {
            return gclass193_1.gclass146_0 == this.gclass146_0;
        }

        internal bool method_1(GClass192 gclass192_0)
        {
            return gclass192_0.gclass193_0 == this.gclass193_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class51
    {
        public PopulationData gclass146_0;
        public System.Func<NavalAdminCommand, bool> func_0;
        public System.Func<GClass62, bool> func_1;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData == this.gclass146_0;
        }

        internal bool method_1(NavalAdminCommand gclass83_0)
        {
            return gclass83_0.gclass146_0 == this.gclass146_0;
        }

        internal bool method_2(GClass62 gclass62_0)
        {
            return gclass62_0.gclass146_0 == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class52
    {
        public long long_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return this.long_0 >= gclass103_0.long_0 && this.long_0 <= gclass103_0.long_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class53
    {
        public long long_0;

        internal bool method_0(GroundUnitFormationElement gclass39_0)
        {
            return this.long_0 >= gclass39_0.long_0 && this.long_0 <= gclass39_0.long_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class54
    {
        public long long_0;

        internal bool method_0(GroundUnitFormationElement gclass39_0)
        {
            return this.long_0 >= gclass39_0.long_0 && this.long_0 <= gclass39_0.long_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class55
    {
        public int int_0;

        internal bool method_0(GClass158 gclass158_0)
        {
            return gclass158_0.int_0 >= this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class56
    {
        public FCTShipData40 gclass40_0;

        internal bool method_0(FCTShipData40 gclass40_1)
        {
            return gclass40_1.int_17 == 1 && gclass40_1 != this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class57
    {
        public FireControlAssignment gclass36_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class58
    {
        public FCTShipData40 gclass40_0;

        internal bool method_0(FCTShipData40 gclass40_1)
        {
            return gclass40_1.int_17 == 1 && gclass40_1 != this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class59
    {
        public FireControlAssignment gclass36_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class60
    {
        public WeaponFireControlAssignment gclass31_0;

        internal bool method_0(MissileAssignment gclass30_0)
        {
            return gclass30_0.FiringWeaponComponent == this.gclass31_0.WeaponComponent && gclass30_0.WeaponNum == this.gclass31_0.WeaponNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class61
    {
        public SystemData200 gclass200_0;
        public GClass0 gclass0_0;
        public System.Func<GClass65, bool> func_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.gclass200_0 == this.gclass200_0;
        }

        internal bool method_1(GClass65 gclass65_0)
        {
            return gclass65_0.gclass200_0 == this.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class62
    {
        public GameRace gclass21_0;
        public GClass0.Class61 class61_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.genum10_0 == GEnum10.const_0 &&
                   gclass65_0.auroraContactType_0 == AuroraContactType.Salvo &&
                   gclass65_0.method_5() < AuroraContactStatus.Neutral &&
                   gclass65_0.decimal_3 == this.class61_0.gclass0_0.GameTime &&
                   gclass65_0.gclass21_1 == this.gclass21_0;
        }

        internal bool method_1(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass85_0.System.ActualSystemData == this.class61_0.gclass200_0 &&
                   gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass22_0.decimal_11 > 0M;
        }
    }

    [CompilerGenerated]
    private sealed class Class63
    {
        public GClass132 gclass132_0;

        internal bool method_0(GClass132 gclass132_1)
        {
            return gclass132_1.gclass132_0 == this.gclass132_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class64
    {
        public GClass221 gclass221_0;

        internal bool method_0(GClass29 gclass29_0)
        {
            return gclass29_0.gclass221_0.double_0 == this.gclass221_0.double_0 &&
                   gclass29_0.gclass221_0.double_1 == this.gclass221_0.double_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class65
    {
        public FCTShipData40 gclass40_0;
        public GClass0.Class62 class62_0;
        public System.Func<GClass132, double> func_0;

        internal double method_0(GClass132 gclass132_0)
        {
            return this.class62_0.class61_0.gclass0_0.GetDistanceBetween(this.gclass40_0.gclass85_0.XCoord,
                this.gclass40_0.gclass85_0.YCoord, gclass132_0.double_0, gclass132_0.double_1);
        }
    }

    [CompilerGenerated]
    private sealed class Class66
    {
        public FireControlAssignment gclass36_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class67
    {
        public WeaponFireControlAssignment gclass31_0;

        internal bool method_0(MissileAssignment gclass30_0)
        {
            return gclass30_0.FiringWeaponComponent == this.gclass31_0.WeaponComponent && gclass30_0.WeaponNum == this.gclass31_0.WeaponNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class68
    {
        public SystemData200 gclass200_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.gclass200_0 == this.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class69
    {
        public SystemData200 gclass200_0;
        public AuroraContactType auroraContactType_0;
        public Decimal decimal_0;
        public double double_0;
        public double double_1;

        internal bool method_0(GameRace gclass21_0)
        {
            return gclass21_0.list_13.Contains(this.gclass200_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class70
    {
        public GameRace gclass21_0;
        public GClass0.Class69 class69_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.gclass21_1 == this.gclass21_0 &&
                   gclass65_0.auroraContactType_0 == this.class69_0.auroraContactType_0 &&
                   gclass65_0.decimal_0 == this.class69_0.decimal_0 &&
                   gclass65_0.gclass200_0 == this.class69_0.gclass200_0 &&
                   gclass65_0.double_0 == this.class69_0.double_0 && gclass65_0.double_1 == this.class69_0.double_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class71
    {
        public FCTShipData40 gclass40_0;
        public ShipComponent gclass230_0;
        public GroundUnitFormationElement gclass39_0;
        public string string_0;
        public Decimal decimal_0;
        public Decimal decimal_1;
        public RaceMissile gclass129_0;
        public double double_0;
        public double double_1;
        public bool bool_0;
        public bool bool_1;
        public bool bool_2;
        public GEnum62 genum62_0;

        internal bool method_0(GClass37 gclass37_0)
        {
            return gclass37_0.gclass40_0 == this.gclass40_0 && gclass37_0.gclass230_0 == this.gclass230_0 &&
                   gclass37_0.gclass39_0 == this.gclass39_0 && gclass37_0.string_0 == this.string_0 &&
                   gclass37_0.decimal_0 == this.decimal_0 && gclass37_0.decimal_1 == this.decimal_1 &&
                   gclass37_0.gclass129_0 == this.gclass129_0 && gclass37_0.double_0 == this.double_0 &&
                   gclass37_0.double_1 == this.double_1 && gclass37_0.bool_2 == this.bool_0 &&
                   gclass37_0.bool_4 == this.bool_1 && gclass37_0.bool_5 == this.bool_2 &&
                   gclass37_0.genum62_0 == this.genum62_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class72
    {
        public int int_0;
        public System.Func<int, bool> func_0;
        public System.Func<int, int> func_1;

        internal bool method_0(int int_1)
        {
            return int_1 > this.int_0;
        }

        internal int method_1(int int_1)
        {
            return int_1 - this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class73
    {
        public List<RacialSystemSurvey> list_0;
        public List<FleetData> list_1;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return this.list_0.Contains(gclass40_0.gclass85_0.System);
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return !this.list_1.Contains(gclass85_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class74
    {
        public List<GClass65> list_0;
        public GClass0 gclass0_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return !this.list_0.Contains(gclass65_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class75
    {
        public GClass65 gclass65_0;
        public GClass0.Class74 class74_0;

        internal bool method_0(GClass65 gclass65_1)
        {
            return gclass65_1.gclass40_0 == this.gclass65_0.gclass40_0 &&
                   gclass65_1.gclass21_1 == this.gclass65_0.gclass21_1;
        }

        internal bool method_1(MoveOrder gclass139_0)
        {
            return gclass139_0.DestinationType == DestinationType.const_4 && gclass139_0.DestinationID == this.gclass65_0.int_0;
        }

        internal bool method_2(GClass212 gclass212_0)
        {
            return gclass212_0.gclass200_0 == this.gclass65_0.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class76
    {
        public double double_0;
        public GClass0.Class75 class75_0;

        internal bool method_0(JumpPoint120 gclass120_0)
        {
            return gclass120_0.SystemData == this.class75_0.gclass65_0.gclass200_0 &&
                   this.class75_0.class74_0.gclass0_0.GetDistanceBetween(gclass120_0.XCoord, gclass120_0.YCoord,
                       this.class75_0.gclass65_0.double_0, this.class75_0.gclass65_0.double_1) < this.double_0;
        }

        internal bool method_1(GClass212 gclass212_0)
        {
            return gclass212_0.gclass200_0 == this.class75_0.gclass65_0.gclass200_0 &&
                   this.class75_0.class74_0.gclass0_0.GetDistanceBetween(gclass212_0.double_0, gclass212_0.double_1,
                       this.class75_0.gclass65_0.double_0, this.class75_0.gclass65_0.double_1) < this.double_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class77
    {
        public GClass65 gclass65_0;
        public GClass0 gclass0_0;

        internal bool method_0(GClass65 gclass65_1)
        {
            return gclass65_1.int_1 == this.gclass65_0.int_1 &&
                   gclass65_1.auroraContactType_0 == this.gclass65_0.auroraContactType_0 &&
                   gclass65_1.gclass21_1 == this.gclass65_0.gclass21_1 &&
                   gclass65_1.decimal_1 != this.gclass0_0.GameTime && gclass65_1.decimal_2 != this.gclass0_0.GameTime;
        }
    }

    [CompilerGenerated]
    private sealed class Class78
    {
        public FleetData gclass85_0;

        internal bool method_0(FleetData gclass85_1)
        {
            return gclass85_1.System.ActualSystemData == this.gclass85_0.System.ActualSystemData;
        }

        internal bool method_1(GameRace gclass21_0)
        {
            return gclass21_0 != this.gclass85_0.Race;
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0.ActualSystemData == this.gclass85_0.System.ActualSystemData;
        }

        internal bool method_3(GameRace gclass21_0)
        {
            return gclass21_0 != this.gclass85_0.Race;
        }

        internal bool method_4(GClass132 gclass132_0)
        {
            return gclass132_0.gclass200_0 == this.gclass85_0.System.ActualSystemData;
        }

        internal bool method_5(GameRace gclass21_0)
        {
            return gclass21_0 != this.gclass85_0.Race;
        }
    }

    [CompilerGenerated]
    private sealed class Class79
    {
        public Decimal decimal_0;
        public GClass0 gclass0_0;
        public FleetData gclass85_0;
        public System.Func<GClass132, bool> func_0;
        public System.Func<FCTShipData40, bool> func_1;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.auroraContactType_0 == AuroraContactType.Ship && gclass65_0.decimal_3 == this.decimal_0;
        }

        internal bool method_1(GClass132 gclass132_0)
        {
            return gclass132_0.decimal_0 == this.gclass0_0.GameTime;
        }

        internal bool method_2(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class80
    {
        public SystemData200 gclass200_0;

        internal bool method_0(GameRace gclass21_0)
        {
            return gclass21_0.list_13.Contains(this.gclass200_0);
        }

        internal bool method_1(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass85_0.System.ActualSystemData == this.gclass200_0;
        }

        internal bool method_2(GClass132 gclass132_0)
        {
            return gclass132_0.gclass200_0 == this.gclass200_0;
        }

        internal bool method_3(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0.ActualSystemData == this.gclass200_0;
        }

        internal bool method_4(JumpPoint120 gclass120_0)
        {
            return gclass120_0.JumpGateStrength > 0 && gclass120_0.SystemData == this.gclass200_0;
        }

        internal bool method_5(GClass193 gclass193_0)
        {
            return gclass193_0.gclass40_0.gclass85_0.System.ActualSystemData == this.gclass200_0;
        }

        internal bool method_6(GroundUnitFormationElement gclass39_0)
        {
            return gclass39_0.Formation.PopulationData.gclass202_0.ActualSystemData == this.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class81
    {
        public GameRace gclass21_0;
        public GClass0.Class80 class80_0;

        internal bool method_0(GClass66 gclass66_0)
        {
            return gclass66_0.gclass21_0 == this.gclass21_0 && gclass66_0.gclass200_0 == this.class80_0.gclass200_0;
        }

        internal bool method_1(GClass67 gclass67_0)
        {
            return gclass67_0.gclass21_0 == this.gclass21_0 && gclass67_0.gclass200_0 == this.class80_0.gclass200_0;
        }

        internal bool method_2(GClass67 gclass67_0)
        {
            return gclass67_0.gclass21_0 == this.gclass21_0 && gclass67_0.gclass200_0 == this.class80_0.gclass200_0;
        }

        internal bool method_3(GClass68 gclass68_0)
        {
            return gclass68_0.gclass21_0 == this.gclass21_0 && gclass68_0.gclass200_0 == this.class80_0.gclass200_0;
        }

        internal bool method_4(JumpPoint120 gclass120_0)
        {
            return gclass120_0.RacialJumpPointSurveys[this.gclass21_0.RaceID].Charted == 0;
        }
    }

    [CompilerGenerated]
    private sealed class Class83
    {
        public int int_0;

        internal bool method_0(DIMDesignPhilosophyTechProgression gclass19_0)
        {
            return gclass19_0.ProgressionOrder == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class84
    {
        public Star197 gclass197_0;

        internal bool method_0(Star197 paramStar)
        {
            return paramStar.SystemData == this.gclass197_0.SystemData &&
                   paramStar.Component == this.gclass197_0.OrbitingComponent;
        }
    }

    [CompilerGenerated]
    private sealed class LambdaScope86
    {
        public FleetData Fleet;

        internal bool method_0(NavalAdminCommand adminCommand)
        {
            return adminCommand.Race == this.Fleet.Race && adminCommand.ParentAdminCommand == null;
        }
    }

    [CompilerGenerated]
    private sealed class Class86
    {
        public GroundUnitFormationElement gclass39_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.gclass146_0 == this.gclass39_0.Formation.PopulationData;
        }
    }

    [CompilerGenerated]
    private sealed class Class87
    {
        public DesignDoctrine DesignDoctrine;

        internal bool Class16WherePredicate(GClass16 gclass16_0)
        {
            return gclass16_0.int_1 == this.DesignDoctrine.GroundForceDeploymentThemeID;
        }

        internal bool Class12WherePredicate(GClass12 gclass12_0)
        {
            return gclass12_0.genum90_0 == this.DesignDoctrine.OperationGroupProgressionType;
        }
    }

    [CompilerGenerated]
    private sealed class Class88
    {
        public List<SystemBodyData> list_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData.NPR && this.list_0.Contains(gclass146_0.SystemBodyData);
        }
    }

    [CompilerGenerated]
    private sealed class Class89
    {
        public GameRace gclass21_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.Population > 0M && gclass146_0.RaceData == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class90
    {
        public FCTShipData40 gclass40_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass40_0.gclass21_0 &&
                   gclass146_0.gclass202_0 == this.gclass40_0.gclass85_0.System;
        }
    }

    [CompilerGenerated]
    private sealed class Class91
    {
        public GroundUnitFormationElement gclass39_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.ParentFormationData == this.gclass39_0.Formation;
        }

        internal bool method_1(GroundUnitFormationElement gclass39_1)
        {
            return gclass39_1.Formation.PopulationData.SystemBodyData == this.gclass39_0.Formation.PopulationData.SystemBodyData;
        }
    }

    [CompilerGenerated]
    private sealed class Class92
    {
        public FleetData gclass85_0;
        public GClass0 gclass0_0;
        public System.Func<FleetData, bool> func_0;
        public System.Func<FleetData, bool> func_1;
        public System.Func<FleetData, bool> func_2;
        public System.Func<FleetData, bool> func_3;

        internal bool method_0(FleetData gclass85_1)
        {
            return gclass85_1.System.ActualSystemData == this.gclass85_0.System.ActualSystemData &&
                   gclass85_1.Race != this.gclass85_0.Race;
        }

        internal bool method_1(FleetData gclass85_1)
        {
            return this.gclass85_0.Race.method_90(gclass85_1.Race) == AuroraContactStatus.Hostile;
        }

        internal bool method_2(FleetData gclass85_1)
        {
            return gclass85_1.System.ActualSystemData == this.gclass85_0.System.ActualSystemData &&
                   gclass85_1.Race != this.gclass85_0.Race;
        }

        internal bool method_3(FleetData gclass85_1)
        {
            return this.gclass85_0.Race.method_90(gclass85_1.Race) == AuroraContactStatus.Hostile;
        }
    }

    [CompilerGenerated]
    private sealed class Class93
    {
        public MoveOrder gclass139_0;
        public GClass0.Class92 class92_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.XCoord == this.class92_0.gclass0_0.dictionary_13[this.gclass139_0.DestinationID].double_0 &&
                   gclass85_0.YCoord == this.class92_0.gclass0_0.dictionary_13[this.gclass139_0.DestinationID].double_1;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.XCoord == this.class92_0.gclass0_0.JumpPointDictionary[this.gclass139_0.DestinationID].XCoord &&
                   gclass85_0.YCoord == this.class92_0.gclass0_0.JumpPointDictionary[this.gclass139_0.DestinationID].YCoord;
        }
    }

    [CompilerGenerated]
    private sealed class Class94
    {
        public FCTShipData40 gclass40_0;

        internal bool method_0(GClass82 gclass82_0)
        {
            return gclass82_0.gclass202_0 == this.gclass40_0.gclass85_0.System &&
                   gclass82_0.double_0 == this.gclass40_0.gclass85_0.XCoord &&
                   gclass82_0.double_1 == this.gclass40_0.gclass85_0.YCoord;
        }
    }

    [CompilerGenerated]
    private sealed class Class95
    {
        public FireControlAssignment gclass36_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class96
    {
        public WeaponFireControlAssignment gclass31_0;

        internal bool method_0(WeaponComponentRechargeStatus gclass27_0)
        {
            return gclass27_0.WeaponComponent == this.gclass31_0.WeaponComponent && gclass27_0.WeaponNumber == this.gclass31_0.WeaponNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class97
    {
        public GameRace gclass21_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.CivilianFunction == CivilanFunctionType.const_1 && gclass85_0.MoveOrderDictionary.Count == 0 &&
                   gclass85_0.Race == this.gclass21_0;
        }

        internal bool method_1(AlienRaceInfo gclass110_0)
        {
            return gclass110_0.ActualAlienRace == this.gclass21_0 && gclass110_0.bTradeTreaty;
        }
    }

    [CompilerGenerated]
    private sealed class Class98
    {
        public FleetData gclass85_0;
        public GClass0 gclass0_0;

        internal JumpPoint120 method_0(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.method_11(this.gclass85_0.System).LinkedJumpPoint;
        }

        internal bool method_1(JumpPoint120 gclass120_0)
        {
            return gclass120_0.RacialJumpPointSurveys[this.gclass85_0.Race.RaceID].MilitaryRestricted == 0;
        }

        internal double method_2(JumpPoint120 gclass120_0)
        {
            return this.gclass0_0.GetDistanceBetween(this.gclass85_0.XCoord, this.gclass85_0.YCoord, gclass120_0.XCoord,
                gclass120_0.YCoord);
        }
    }

    [CompilerGenerated]
    private sealed class Class99
    {
        public GClass44 gclass44_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.method_14() >= this.gclass44_0.gclass43_0.AmountRequired &&
                   gclass55_0.gclass21_0 == this.gclass44_0.gclass42_0.Race &&
                   !gclass55_0.dictionary_1.ContainsKey(this.gclass44_0.gclass42_0.MedalID);
        }
    }

    [CompilerGenerated]
    private sealed class Class100
    {
        public AlienRaceInfo gclass110_0;
        public GClass0 gclass0_0;

        internal bool method_0(AlienRaceInfo gclass110_1)
        {
            return gclass110_1.ActualAlienRace == this.gclass110_0.ViewingRace;
        }
    }

    [CompilerGenerated]
    private sealed class Class101
    {
        public FCTShipData40 gclass40_0;
        public GClass0.Class100 class100_0;

        internal bool method_0(GClass115 gclass115_0)
        {
            return gclass115_0.gclass22_0 == this.gclass40_0.gclass22_0;
        }

        internal bool method_1(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0 == this.gclass40_0;
        }

        internal bool method_2(GClass65 gclass65_0)
        {
            return gclass65_0.int_1 == this.gclass40_0.int_8 &&
                   gclass65_0.gclass21_1 == this.class100_0.gclass110_0.ViewingRace &&
                   gclass65_0.decimal_3 == this.class100_0.gclass0_0.GameTime;
        }
    }

    [CompilerGenerated]
    private sealed class Class102
    {
        public AlienRaceInfo gclass110_0;
        public GClass0 gclass0_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            if (gclass65_0.gclass21_0 != this.gclass110_0.ActualAlienRace ||
                gclass65_0.gclass21_1 != this.gclass110_0.ViewingRace ||
                !(gclass65_0.decimal_3 == this.gclass0_0.GameTime))
                return false;
            return gclass65_0.auroraContactType_0 == AuroraContactType.Population ||
                   gclass65_0.auroraContactType_0 == AuroraContactType.Ship;
        }

        internal bool method_1(GClass65 gclass65_0)
        {
            if (gclass65_0.gclass21_0 != this.gclass110_0.ViewingRace ||
                gclass65_0.gclass21_1 != this.gclass110_0.ActualAlienRace ||
                !(gclass65_0.decimal_3 == this.gclass0_0.GameTime))
                return false;
            return gclass65_0.auroraContactType_0 == AuroraContactType.Population ||
                   gclass65_0.auroraContactType_0 == AuroraContactType.Ship;
        }
    }

    [CompilerGenerated]
    private sealed class Class103
    {
        public List<SystemData200> list_0;
        public GClass0.Class102 class102_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.class102_0.gclass110_0.ActualAlienRace &&
                   this.list_0.Contains(gclass40_0.gclass85_0.System.ActualSystemData);
        }
    }

    [CompilerGenerated]
    private sealed class Class104
    {
        public AlienRaceInfo gclass110_0;
        public GClass0 gclass0_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            if (gclass65_0.gclass21_0 != this.gclass110_0.ActualAlienRace ||
                gclass65_0.gclass21_1 != this.gclass110_0.ViewingRace ||
                !(gclass65_0.decimal_3 == this.gclass0_0.GameTime))
                return false;
            return gclass65_0.auroraContactType_0 == AuroraContactType.Population ||
                   gclass65_0.auroraContactType_0 == AuroraContactType.Ship;
        }

        internal bool method_1(GClass65 gclass65_0)
        {
            if (gclass65_0.gclass21_0 != this.gclass110_0.ViewingRace ||
                gclass65_0.gclass21_1 != this.gclass110_0.ActualAlienRace ||
                !(gclass65_0.decimal_3 == this.gclass0_0.GameTime))
                return false;
            return gclass65_0.auroraContactType_0 == AuroraContactType.Population ||
                   gclass65_0.auroraContactType_0 == AuroraContactType.Ship;
        }
    }

    [CompilerGenerated]
    private sealed class Class105
    {
        public List<SystemData200> list_0;
        public GClass0.Class104 class104_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.class104_0.gclass110_0.ViewingRace &&
                   this.list_0.Contains(gclass40_0.gclass85_0.System.ActualSystemData);
        }
    }

    [CompilerGenerated]
    private sealed class Class106
    {
        public AlienRaceInfo gclass110_0;
        public GClass0 gclass0_0;

        internal bool method_0(AlienRaceInfo gclass110_1)
        {
            return gclass110_1.ActualAlienRace == this.gclass110_0.ViewingRace;
        }
    }

    [CompilerGenerated]
    private sealed class Class107
    {
        public FCTShipData40 gclass40_0;
        public GClass117 gclass117_0;
        public GClass0.Class106 class106_0;

        internal bool method_0(GClass115 gclass115_0)
        {
            return gclass115_0.gclass22_0 == this.gclass40_0.gclass22_0;
        }

        internal bool method_1(GClass117 gclass117_1)
        {
            return gclass117_1.gclass40_0 == this.gclass40_0;
        }

        internal bool method_2(GClass65 gclass65_0)
        {
            return gclass65_0.int_1 == this.gclass117_0.gclass40_0.int_8 &&
                   gclass65_0.gclass21_1 == this.class106_0.gclass110_0.ActualAlienRace &&
                   gclass65_0.decimal_3 == this.class106_0.gclass0_0.GameTime;
        }
    }

    [CompilerGenerated]
    private sealed class Class108
    {
        public List<int> list_0;

        internal bool method_0(GClass214 gclass214_0)
        {
            return !this.list_0.Contains(gclass214_0.int_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class109
    {
        public SystemBodyData gclass1_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData.SystemBodyData == this.gclass1_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class110
    {
        public ShippingLineData gclass187_0;

        internal bool method_0(GClass193 gclass193_0)
        {
            return gclass193_0.gclass21_0 == this.gclass187_0.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class111
    {
        public GameRace gclass21_0;
        public System.Func<FleetData, bool> func_0;
        public System.Func<GroundUnitFormationData, bool> func_1;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.Race != this.gclass21_0;
        }

        internal bool method_1(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData != null && gclass103_0.RaceData != this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class112
    {
        public SystemBodyData gclass1_0;

        internal bool method_0(GClass172 gclass172_0)
        {
            return gclass172_0.gclass1_0 == this.gclass1_0;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.OrbitingBody == this.gclass1_0;
        }

        internal bool method_2(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData.SystemBodyData == this.gclass1_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class113
    {
        public SystemBodyData gclass1_0;
        public GameRace gclass21_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.SystemBodyData == this.gclass1_0 && gclass146_0.RaceData == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class114
    {
        public SystemBodyData gclass1_0;
        public GameRace gclass21_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.ActualSystemData == this.gclass1_0.SystemData;
        }

        internal bool method_1(NavalAdminCommand gclass83_0)
        {
            return gclass83_0.Race == this.gclass21_0 && gclass83_0.ParentAdminCommand == null;
        }

        internal bool method_2(GClass22 gclass22_0)
        {
            return gclass22_0.gclass21_0 == this.gclass21_0;
        }

        internal bool method_3(PopulationData gclass146_0)
        {
            return gclass146_0.SystemBodyData == this.gclass1_0 && gclass146_0.RaceData == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class115
    {
        public GClass130 gclass130_0;

        internal bool method_0(GClass130 gclass130_1)
        {
            return gclass130_1.gclass129_0 == this.gclass130_0.gclass129_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class116
    {
        public SystemData200 gclass200_0;
        public SystemData200 gclass200_1;

        internal double method_0(DIMKnownSystemsData198 gclass198_0)
        {
            return Math.Pow(gclass198_0.X - this.gclass200_0.KnownSystemData.X, 2.0) +
                   Math.Pow(gclass198_0.Y - this.gclass200_0.KnownSystemData.Y, 2.0) +
                   Math.Pow(gclass198_0.Z - this.gclass200_0.KnownSystemData.Z, 2.0);
        }

        internal bool method_1(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_1;
        }

        internal bool method_2(Star197 gclass197_0)
        {
            return gclass197_0.SystemData == this.gclass200_1 && gclass197_0.Component == 1;
        }
    }

    [CompilerGenerated]
    private sealed class Class117
    {
        public DIMKnownSystemsData198 gclass198_0;

        internal bool method_0(SystemData200 gclass200_0)
        {
            return gclass200_0.KnownSystemData == this.gclass198_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class118
    {
        public int int_0;

        internal bool method_0(SystemData200 gclass200_0)
        {
            return gclass200_0.SystemNumber == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class119
    {
        public GameRace gclass21_0;

        internal bool method_0(GClass22 gclass22_0)
        {
            return gclass22_0.gclass21_0 == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class120
    {
        public GameRace gclass21_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass187_0 != null;
        }
    }

    [CompilerGenerated]
    private sealed class Class121
    {
        public GameRace gclass21_0;

        internal bool method_0(GClass193 gclass193_0)
        {
            return gclass193_0.gclass21_0 == this.gclass21_0;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass21_0 && gclass146_0.decimal_30 > 10M;
        }
    }

    [CompilerGenerated]
    private sealed class Class122
    {
        public List<SystemData200> list_0;
        public GameRace gclass21_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return this.list_0.Contains(gclass1_0.SystemData);
        }

        internal bool method_1(SystemBodyData gclass1_0)
        {
            return gclass1_0.dictionary_0.ContainsKey(AuroraElement.Duranium) &&
                   gclass1_0.method_16(80 /*0x50*/, false) && gclass1_0.method_77(this.gclass21_0);
        }

        internal bool method_2(SystemBodyData gclass1_0)
        {
            return this.list_0.Contains(gclass1_0.SystemData);
        }

        internal bool method_3(SystemBodyData gclass1_0)
        {
            return gclass1_0.dictionary_0.ContainsKey(AuroraElement.Gallicite) &&
                   gclass1_0.method_16(80 /*0x50*/, false) && gclass1_0.method_77(this.gclass21_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class123
    {
        public GClass132 gclass132_0;
        public GClass0 gclass0_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass132_0.gclass200_0 && this.gclass0_0.method_520(
                gclass1_0.XCoordinate, this.gclass132_0.double_0, gclass1_0.YCoordinate, this.gclass132_0.double_1);
        }
    }

    [CompilerGenerated]
    private sealed class Class124
    {
        public SystemBodyData gclass1_0;
        public GClass0.Class123 class123_0;

        internal bool method_0(GClass216 gclass216_0)
        {
            return gclass216_0.int_0 == this.gclass1_0.SystemBodyID &&
                   gclass216_0.int_1 == this.class123_0.gclass132_0.gclass21_0.RaceID;
        }
    }

    [CompilerGenerated]
    private sealed class Class125
    {
        public List<SystemBodyData> list_0;
        public List<SystemBodyData> list_1;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return this.list_0.Contains(gclass103_0.PopulationData.SystemBodyData);
        }

        internal bool method_1(GroundUnitFormationData gclass103_0)
        {
            return this.list_1.Contains(gclass103_0.PopulationData.SystemBodyData);
        }
    }

    [CompilerGenerated]
    private sealed class Class126
    {
        public SystemBodyData gclass1_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData.SystemBodyData == this.gclass1_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class127
    {
        public GameRace gclass21_0;
        public GClass0.Class126 class126_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData.SystemBodyData == this.class126_0.gclass1_0 &&
                   gclass103_0.RaceData == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class128
    {
        public SystemBodyData gclass1_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData.SystemBodyData == this.gclass1_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class129
    {
        public GameRace gclass21_0;
        public GClass0.Class128 class128_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData.SystemBodyData == this.class128_0.gclass1_0 &&
                   gclass103_0.RaceData == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class130
    {
        public FleetData gclass85_0;
        public GClass0 gclass0_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass85_0.System.ActualSystemData && this.gclass0_0.method_520(
                gclass1_0.XCoordinate, this.gclass85_0.XCoord, gclass1_0.YCoordinate, this.gclass85_0.YCoord);
        }
    }

    [CompilerGenerated]
    private sealed class Class131
    {
        public SystemData200 gclass200_0;
        public SystemBodyData gclass1_0;
        public GClass0 gclass0_0;
        public bool bool_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.OrbitingBody != null && gclass85_0.System.ActualSystemData == this.gclass200_0;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.OrbitingBody == this.gclass1_0;
        }

        internal bool method_2(Star197 gclass197_0)
        {
            return gclass197_0.SystemData == this.gclass200_0;
        }

        internal bool method_3(SystemBodyData gclass1_1)
        {
            return (gclass1_1.BodyClass == PlanetBodyClass.Planet || gclass1_1.BodyClass == PlanetBodyClass.Comet ||
                    gclass1_1.BodyClass == PlanetBodyClass.Asteroid && gclass1_1.TrojanOffset == 0.0 &&
                    (this.gclass0_0.OrbitalMotionAst == 1 || this.bool_0)) && gclass1_1.SystemData == this.gclass200_0 &&
                   !gclass1_1.IsFixedBody;
        }

        internal bool method_4(SystemBodyData gclass1_1)
        {
            if (gclass1_1.BodyClass == PlanetBodyClass.Planet || gclass1_1.BodyClass == PlanetBodyClass.Comet)
                return true;
            if (gclass1_1.BodyClass != PlanetBodyClass.Asteroid || gclass1_1.TrojanOffset != 0.0)
                return false;
            return this.gclass0_0.OrbitalMotionAst == 1 || this.bool_0;
        }

        internal bool method_5(SystemBodyData gclass1_1)
        {
            return gclass1_1.BodyClass == PlanetBodyClass.Moon && gclass1_1.SystemData == this.gclass200_0;
        }

        internal bool method_6(SystemBodyData gclass1_1)
        {
            return gclass1_1.BodyClass == PlanetBodyClass.Moon && gclass1_1.ParentBodyData == this.gclass1_0;
        }

        internal bool method_7(SystemBodyData gclass1_1)
        {
            return gclass1_1.BodyClass == PlanetBodyClass.Asteroid && gclass1_1.TrojanOffset != 0.0 &&
                   gclass1_1.SystemData == this.gclass200_0;
        }

        internal bool method_8(SystemBodyData gclass1_1)
        {
            return gclass1_1.BodyClass == PlanetBodyClass.Asteroid && gclass1_1.TrojanOffset != 0.0 &&
                   gclass1_1.ParentBodyData == this.gclass1_0;
        }

        internal bool method_9(GClass212 gclass212_0)
        {
            return gclass212_0.gclass197_0.SystemData == this.gclass200_0;
        }

        internal bool method_10(GClass212 gclass212_0)
        {
            return gclass212_0.gclass197_0.SystemData == this.gclass1_0.SystemData;
        }

        internal bool method_11(GClass65 gclass65_0)
        {
            return gclass65_0.gclass40_0 != null && gclass65_0.gclass200_0 == this.gclass200_0;
        }

        internal bool method_12(GClass65 gclass65_0)
        {
            return gclass65_0.gclass40_0 != null && gclass65_0.gclass200_0 == this.gclass1_0.SystemData;
        }

        internal bool method_13(GClass65 gclass65_0)
        {
            return gclass65_0.gclass40_0.gclass85_0.OrbitingBody == this.gclass1_0;
        }

        internal bool method_14(GClass132 gclass132_0)
        {
            return gclass132_0.gclass1_0 != null && gclass132_0.gclass200_0 == this.gclass200_0;
        }

        internal bool method_15(GClass132 gclass132_0)
        {
            return gclass132_0.gclass1_0 == this.gclass1_0;
        }

        internal bool method_16(GClass65 gclass65_0)
        {
            return gclass65_0.gclass132_0 != null && gclass65_0.gclass200_0 == this.gclass200_0;
        }

        internal bool method_17(GClass65 gclass65_0)
        {
            return gclass65_0.gclass132_0 != null && gclass65_0.gclass200_0 == this.gclass200_0;
        }

        internal bool method_18(GClass65 gclass65_0)
        {
            return gclass65_0.gclass132_0.gclass1_0 == this.gclass1_0;
        }

        internal bool method_19(GClass214 gclass214_0)
        {
            return gclass214_0.gclass1_0 != null && gclass214_0.gclass200_0 == this.gclass200_0;
        }

        internal bool method_20(GClass214 gclass214_0)
        {
            return gclass214_0.gclass1_0 == this.gclass1_0;
        }

        internal bool method_21(GClass233 gclass233_0)
        {
            return gclass233_0.gclass1_0 != null && gclass233_0.gclass200_0 == this.gclass200_0;
        }

        internal bool method_22(GClass233 gclass233_0)
        {
            return gclass233_0.gclass1_0 == this.gclass1_0;
        }

        internal bool method_23(GClass65 gclass65_0)
        {
            return gclass65_0.gclass146_0 != null && gclass65_0.gclass200_0 == this.gclass200_0;
        }

        internal bool method_24(GClass65 gclass65_0)
        {
            return gclass65_0.gclass146_0 != null && gclass65_0.gclass200_0 == this.gclass200_0;
        }

        internal bool method_25(GClass65 gclass65_0)
        {
            return gclass65_0.gclass146_0.SystemBodyData == this.gclass1_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class132
    {
        public FCTShipData40 gclass40_0;
        public GClass0 gclass0_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            if (!this.gclass0_0.method_520(gclass1_0.XCoordinate, this.gclass40_0.gclass85_0.XCoord,
                    gclass1_0.YCoordinate, this.gclass40_0.gclass85_0.YCoord))
                return false;
            return gclass1_0.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                   gclass1_0.BodyTypeId == AuroraSystemBodyType.Superjovian;
        }
    }

    [CompilerGenerated]
    private sealed class Class133
    {
        public SystemData200 gclass200_0;
        public GClass0 gclass0_0;

        internal bool method_0(SystemData200 gclass200_1)
        {
            return this.gclass0_0.method_29(this.gclass200_0.KnownSystemData.X, this.gclass200_0.KnownSystemData.Y,
                this.gclass200_0.KnownSystemData.Z, gclass200_1.KnownSystemData.X, gclass200_1.KnownSystemData.Y,
                gclass200_1.KnownSystemData.Z) < this.gclass200_0.double_3;
        }

        internal bool method_1(SystemData200 gclass200_1)
        {
            return this.gclass0_0.method_29(this.gclass200_0.KnownSystemData.X, this.gclass200_0.KnownSystemData.Y,
                this.gclass200_0.KnownSystemData.Z, gclass200_1.KnownSystemData.X, gclass200_1.KnownSystemData.Y,
                gclass200_1.KnownSystemData.Z) < this.gclass200_0.double_3;
        }
    }

    [CompilerGenerated]
    private sealed class Class134
    {
        public SystemData200 gclass200_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.System.ActualSystemData == this.gclass200_0;
        }

        internal bool method_2(GClass132 gclass132_0)
        {
            return gclass132_0.gclass200_0 == this.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class135
    {
        public SystemBodyData gclass1_0;

        internal bool method_0(SystemBodyData gclass1_1)
        {
            return gclass1_1.ParentBodyData == this.gclass1_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class136
    {
        public GClass59 gclass59_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.gclass59_0 == this.gclass59_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class137
    {
        public List<FleetData> list_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return !gclass40_0.gclass22_0.bool_2 && gclass40_0.genum29_0 != GEnum29.const_1 &&
                   this.list_0.Contains(gclass40_0.gclass85_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class138
    {
        public List<FleetData> list_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return !gclass40_0.gclass22_0.bool_2 && gclass40_0.genum29_0 != GEnum29.const_1 &&
                   this.list_0.Contains(gclass40_0.gclass85_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class139
    {
        public List<GroundUnitFormationData> list_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return !this.list_0.Contains(gclass103_0.ParentFormationData);
        }
    }

    [CompilerGenerated]
    private sealed class Class140
    {
        public GroundUnitFormationData gclass103_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.ParentFormationData == this.gclass103_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class141
    {
        public FCTShipData40 gclass40_0;
        public System.Func<GClass117, bool> func_0;
        public System.Func<GClass117, bool> func_1;
        public System.Func<GClass117, bool> func_2;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.ShipData == this.gclass40_0;
        }

        internal bool method_1(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0 == this.gclass40_0;
        }

        internal bool method_2(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0 == this.gclass40_0;
        }

        internal bool method_3(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0 == this.gclass40_0;
        }

        internal bool method_4(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.ShipData != null && gclass103_0.RaceData == this.gclass40_0.gclass21_0;
        }

        internal bool method_5(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.ShipData == this.gclass40_0 || gclass103_0.ShipData.gclass40_0 == this.gclass40_0;
        }

        internal bool method_6(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class142
    {
        public List<GroundUnitFormationData> list_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return this.list_0.Contains(gclass55_0.gclass103_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class143
    {
        public GClass114 gclass114_0;

        internal bool method_0(GroundUnitFormationElement gclass39_0)
        {
            return gclass39_0.GroundUnitClass == this.gclass114_0.gclass101_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class144
    {
        public List<GroundUnitClass101> list_0;

        internal bool method_0(GroundUnitFormationElement gclass39_0)
        {
            return !this.list_0.Contains(gclass39_0.GroundUnitClass);
        }
    }

    [CompilerGenerated]
    private sealed class Class145
    {
        public List<SystemBodyData> list_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return this.list_0.Contains(gclass103_0.PopulationData.SystemBodyData);
        }

        internal bool method_1(GroundUnitFormationData gclass103_0)
        {
            return this.list_0.Contains(gclass103_0.PopulationData.SystemBodyData);
        }
    }

    [CompilerGenerated]
    private sealed class Class146
    {
        public GClass109 gclass109_0;
        public System.Func<FleetData, bool> func_0;

        internal bool method_0(GClass172 gclass172_0)
        {
            return gclass172_0.gclass1_0.SystemData == this.gclass109_0.gclass1_0.SystemData;
        }

        internal bool method_1(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData != null && gclass103_0.RaceData == this.gclass109_0.gclass21_0;
        }

        internal bool method_2(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData.SystemBodyData == this.gclass109_0.gclass1_0;
        }

        internal bool method_3(FleetData gclass85_0)
        {
            return gclass85_0.OrbitingBody == this.gclass109_0.gclass1_0 &&
                   gclass85_0.Race == this.gclass109_0.gclass21_0 && gclass85_0.method_36();
        }

        internal bool method_4(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData != null && gclass103_0.RaceData != this.gclass109_0.gclass21_0;
        }

        internal bool method_5(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData.SystemBodyData == this.gclass109_0.gclass1_0 &&
                   this.gclass109_0.gclass21_0.PerceivedAliens.ContainsKey(gclass103_0.RaceData.RaceID);
        }

        internal bool method_6(GroundUnitFormationData gclass103_0)
        {
            return this.gclass109_0.gclass21_0.PerceivedAliens[gclass103_0.RaceData.RaceID].ContactStatus ==
                   AuroraContactStatus.Hostile;
        }

        internal bool method_7(PopulationData gclass146_0)
        {
            return gclass146_0.SystemBodyData == this.gclass109_0.gclass1_0 &&
                   this.gclass109_0.gclass21_0.PerceivedAliens.ContainsKey(gclass146_0.RaceData.RaceID);
        }

        internal bool method_8(PopulationData gclass146_0)
        {
            return this.gclass109_0.gclass21_0.PerceivedAliens[gclass146_0.RaceData.RaceID].ContactStatus ==
                   AuroraContactStatus.Hostile;
        }

        internal bool method_9(PopulationData gclass146_0)
        {
            return gclass146_0.SystemBodyData == this.gclass109_0.gclass1_0 &&
                   gclass146_0.RaceData == this.gclass109_0.gclass21_0;
        }

        internal bool method_10(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass109_0.gclass21_0;
        }

        internal bool method_11(RaceGroundCombat gclass46_0)
        {
            return gclass46_0.SystemBody == this.gclass109_0.gclass1_0;
        }

        internal bool method_12(FleetData gclass85_0)
        {
            return gclass85_0.OrbitingBody == this.gclass109_0.gclass1_0 &&
                   gclass85_0.Race == this.gclass109_0.gclass21_0;
        }

        internal bool method_13(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass85_0.OrbitingBody == this.gclass109_0.gclass1_0 &&
                   gclass40_0.gclass21_0 == this.gclass109_0.gclass21_0 &&
                   gclass40_0.gclass85_0.method_42(MoveActionType.PlanetarySearchAndDestroy);
        }

        internal bool method_14(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass85_0.OrbitingBody == this.gclass109_0.gclass1_0 &&
                   gclass40_0.gclass21_0 == this.gclass109_0.gclass21_0 &&
                   gclass40_0.gclass85_0.method_42(MoveActionType.PlanetarySearchAndDestroy);
        }
    }

    [CompilerGenerated]
    private sealed class Class147
    {
        public long long_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return this.long_0 >= gclass103_0.long_0 && this.long_0 <= gclass103_0.long_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class148
    {
        public long long_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return this.long_0 >= gclass103_0.long_0 && this.long_0 <= gclass103_0.long_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class149
    {
        public GroundUnitFormationData gclass103_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.gclass103_2 == this.gclass103_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class150
    {
        public long long_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return this.long_0 >= gclass103_0.long_0 && this.long_0 <= gclass103_0.long_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class151
    {
        public List<GroundUnitFormationData> list_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.list_2.Count > 0 && this.list_0.Contains(gclass103_0.ParentFormationData);
        }
    }

    [CompilerGenerated]
    private sealed class Class152
    {
        public PopulationData gclass146_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class153
    {
        public PopulationData gclass146_0;
        public GClass0.Class146 class146_0;

        internal bool method_0(PopulationData gclass146_1)
        {
            return gclass146_1.SystemBodyData == this.class146_0.gclass109_0.gclass1_0 && gclass146_1 != this.gclass146_0 &&
                   gclass146_1.decimal_30 == 0M && gclass146_1.dictionary_0.Count == 0;
        }
    }

    [CompilerGenerated]
    private sealed class Class154
    {
        public GroundUnitFormationData gclass103_0;
        public GClass0.Class146 class146_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.AssignedFormationData == this.gclass103_0 &&
                   gclass103_1.FieldPosition == AuroraGroundFormationFieldPosition.Support &&
                   gclass103_1.PopulationData != null;
        }

        internal bool method_1(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.PopulationData.SystemBodyData == this.gclass103_0.PopulationData.SystemBodyData;
        }

        internal bool method_2(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.AssignedFormationData == this.gclass103_0 &&
                   gclass103_1.FieldPosition == AuroraGroundFormationFieldPosition.Support &&
                   gclass103_1.PopulationData != null;
        }

        internal bool method_3(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.PopulationData.SystemBodyData == this.gclass103_0.PopulationData.SystemBodyData;
        }

        internal bool method_4(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.AssignedFormationData == this.gclass103_0 &&
                   gclass103_1.FieldPosition == AuroraGroundFormationFieldPosition.RearEchelon &&
                   gclass103_1.PopulationData != null;
        }

        internal bool method_5(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.PopulationData.SystemBodyData == this.gclass103_0.PopulationData.SystemBodyData;
        }

        internal bool method_6(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass103_0 == this.gclass103_0;
        }

        internal bool method_7(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass85_0.OrbitingBody == this.gclass103_0.PopulationData.SystemBodyData &&
                   gclass40_0.gclass21_0 == this.class146_0.gclass109_0.gclass21_0 &&
                   gclass40_0.gclass85_0.method_42(MoveActionType.ProvideGroundSupport);
        }

        internal bool method_8(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass103_0 == this.gclass103_0;
        }

        internal bool method_9(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass85_0.OrbitingBody == this.gclass103_0.PopulationData.SystemBodyData &&
                   gclass40_0.gclass21_0 == this.class146_0.gclass109_0.gclass21_0 &&
                   gclass40_0.gclass85_0.method_42(MoveActionType.ProvideOrbitalBombardmentSupport);
        }

        internal bool method_10(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.AssignedFormationData == this.gclass103_0.gclass103_2 &&
                   gclass103_1.FieldPosition == AuroraGroundFormationFieldPosition.Support &&
                   gclass103_1.PopulationData != null;
        }

        internal bool method_11(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.PopulationData.SystemBodyData == this.gclass103_0.gclass103_2.PopulationData.SystemBodyData;
        }

        internal bool method_12(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.AssignedFormationData == this.gclass103_0.gclass103_2 &&
                   gclass103_1.FieldPosition == AuroraGroundFormationFieldPosition.RearEchelon &&
                   gclass103_1.PopulationData != null;
        }

        internal bool method_13(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.PopulationData.SystemBodyData == this.gclass103_0.gclass103_2.PopulationData.SystemBodyData;
        }
    }

    [CompilerGenerated]
    private sealed class Class155
    {
        public long long_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return this.long_0 >= gclass103_0.long_0 && this.long_0 <= gclass103_0.long_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class156
    {
        public int int_0;

        internal bool method_0(GroundUnitFormationElement gclass39_0)
        {
            return this.int_0 >= gclass39_0.long_0 && this.int_0 <= gclass39_0.long_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class157
    {
        public int int_0;

        internal bool method_0(GroundUnitFormationElement gclass39_0)
        {
            return this.int_0 >= gclass39_0.long_0 && this.int_0 <= gclass39_0.long_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class158
    {
        public int int_0;

        internal bool method_0(GroundUnitFormationElement gclass39_0)
        {
            return this.int_0 >= gclass39_0.long_0 && this.int_0 <= gclass39_0.long_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class159
    {
        public int int_0;

        internal bool method_0(GroundUnitFormationElement gclass39_0)
        {
            return this.int_0 >= gclass39_0.long_0 && this.int_0 <= gclass39_0.long_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class160
    {
        public GameRace gclass21_0;

        internal bool method_0(GClass104 gclass104_0)
        {
            return gclass104_0.gclass21_0 == this.gclass21_0 && gclass104_0.int_3 > 0;
        }
    }

    [CompilerGenerated]
    private sealed class Class161
    {
        public GameRace gclass21_0;

        internal bool method_0(GClass104 gclass104_0)
        {
            return gclass104_0.gclass21_0 == this.gclass21_0 && gclass104_0.int_3 > 0;
        }

        internal bool method_1(GClass104 gclass104_0)
        {
            return gclass104_0.gclass21_0 == this.gclass21_0 && gclass104_0.int_3 > 0;
        }
    }

    [CompilerGenerated]
    private sealed class Class162
    {
        public SystemBodyData gclass1_0;
        public GClass0.Class161 class161_0;

        internal bool method_0(GClass104 gclass104_0)
        {
            return gclass104_0.gclass21_0 == this.class161_0.gclass21_0 && gclass104_0.int_3 > 0 &&
                   gclass104_0.gclass1_0 == this.gclass1_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class163
    {
        public FCTShipData40 gclass40_0;
        public GClass0.Class161 class161_0;

        internal bool method_0(GClass104 gclass104_0)
        {
            return gclass104_0.gclass21_0 == this.class161_0.gclass21_0 && gclass104_0.int_3 > 0 &&
                   gclass104_0.gclass40_0 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class164
    {
        public GroundUnitClass101 gclass101_0;
        public GameRace gclass21_0;
        public SystemBodyData gclass1_0;

        internal bool method_0(GClass104 gclass104_0)
        {
            return gclass104_0.gclass101_0 == this.gclass101_0 && gclass104_0.gclass21_0 == this.gclass21_0 &&
                   gclass104_0.gclass1_0 == this.gclass1_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class165
    {
        public GroundUnitClass101 gclass101_0;
        public GameRace gclass21_0;
        public GroundUnitClass101 gclass101_1;
        public SystemBodyData gclass1_0;

        internal bool method_0(GClass104 gclass104_0)
        {
            return gclass104_0.gclass101_0 == this.gclass101_0 && gclass104_0.gclass21_0 == this.gclass21_0 &&
                   gclass104_0.gclass101_1 == this.gclass101_1 && gclass104_0.gclass1_0 == this.gclass1_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class166
    {
        public GroundUnitFormationElement gclass39_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData.SystemBodyData == this.gclass39_0.Formation.PopulationData.SystemBodyData &&
                   gclass103_0.RaceData != this.gclass39_0.Formation.RaceData;
        }

        internal bool method_1(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.ShipData == this.gclass39_0.Formation.ShipData &&
                   gclass103_0.RaceData != this.gclass39_0.Formation.RaceData;
        }

        internal bool method_2(GClass105 gclass105_0)
        {
            return gclass105_0.gclass21_0 == this.gclass39_0.Formation.RaceData &&
                   gclass105_0.gclass101_0 == this.gclass39_0.GroundUnitClass &&
                   gclass105_0.gclass1_0 == this.gclass39_0.Formation.PopulationData.SystemBodyData;
        }

        internal bool method_3(GClass105 gclass105_0)
        {
            return gclass105_0.gclass21_0 == this.gclass39_0.Formation.RaceData &&
                   gclass105_0.gclass101_0 == this.gclass39_0.GroundUnitClass &&
                   gclass105_0.gclass40_0 == this.gclass39_0.Formation.ShipData;
        }
    }

    [CompilerGenerated]
    private sealed class Class167
    {
        public GameRace gclass21_0;

        internal bool method_0(GClass105 gclass105_0)
        {
            return gclass105_0.gclass21_0 == this.gclass21_0 && gclass105_0.int_0 > 0;
        }

        internal bool method_1(GClass105 gclass105_0)
        {
            return gclass105_0.gclass21_0 == this.gclass21_0 && gclass105_0.int_0 > 0;
        }
    }

    [CompilerGenerated]
    private sealed class Class168
    {
        public SystemBodyData gclass1_0;
        public GClass0.Class167 class167_0;

        internal bool method_0(GClass105 gclass105_0)
        {
            return gclass105_0.gclass21_0 == this.class167_0.gclass21_0 && gclass105_0.gclass1_0 == this.gclass1_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class169
    {
        public FCTShipData40 gclass40_0;
        public GClass0.Class167 class167_0;

        internal bool method_0(GClass105 gclass105_0)
        {
            return gclass105_0.gclass21_0 == this.class167_0.gclass21_0 && gclass105_0.gclass40_0 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class170
    {
        public GameRace gclass21_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass21_0;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass21_0 && gclass85_0.OrbitingBody != null;
        }
    }

    [CompilerGenerated]
    private sealed class Class171
    {
        public List<SystemBodyData> list_0;
        public GClass0.Class170 class170_0;
        public System.Func<PopulationData, bool> func_0;
        public System.Func<PopulationData, bool> func_1;

        internal bool method_0(PopulationData gclass146_0)
        {
            return this.list_0.Contains(gclass146_0.SystemBodyData);
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return this.list_0.Contains(gclass146_0.SystemBodyData);
        }
    }

    [CompilerGenerated]
    private sealed class Class172
    {
        public GameRace gclass21_0;
        public GClass0.Class171 class171_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass21_0;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class173
    {
        public SystemBodyData gclass1_0;
        public GClass0.Class172 class172_0;

        internal bool method_0(GClass109 gclass109_0)
        {
            return gclass109_0.gclass1_0 == this.gclass1_0 &&
                   gclass109_0.gclass21_0 == this.class172_0.class171_0.class170_0.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class174
    {
        public GameRace gclass21_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass21_0 || this.gclass21_0 == null;
        }

        internal bool method_1(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0 || this.gclass21_0 == null;
        }
    }

    [CompilerGenerated]
    private sealed class Class175
    {
        public List<int> list_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return !this.list_0.Contains(gclass40_0.gclass22_0.int_39);
        }
    }

    [CompilerGenerated]
    private sealed class Class176
    {
        public PopulationData gclass146_0;
        public GClass0 gclass0_0;

        internal bool method_0(GClass121 gclass121_0)
        {
            return gclass121_0.gclass21_0 == this.gclass146_0.RaceData && this.gclass0_0.method_520(
                gclass121_0.double_0, this.gclass146_0.method_87(), gclass121_0.double_1, this.gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class177
    {
        public FCTShipData40 gclass40_0;
        public GClass0 gclass0_0;

        internal bool method_0(GClass121 gclass121_0)
        {
            return gclass121_0.gclass21_0 == this.gclass40_0.gclass21_0 && this.gclass0_0.method_520(
                gclass121_0.double_0, this.gclass40_0.gclass85_0.XCoord, gclass121_0.double_1,
                this.gclass40_0.gclass85_0.YCoord);
        }
    }

    [CompilerGenerated]
    private sealed class Class178
    {
        public FCTShipData40 gclass40_0;
        public GClass0 gclass0_0;

        internal bool method_0(GClass121 gclass121_0)
        {
            return gclass121_0.gclass21_0 == this.gclass40_0.gclass21_0 &&
                   gclass121_0.gclass202_0 == this.gclass40_0.gclass85_0.System && this.gclass0_0.method_520(
                       gclass121_0.double_0, this.gclass40_0.gclass85_0.XCoord, gclass121_0.double_1,
                       this.gclass40_0.gclass85_0.YCoord);
        }
    }

    [CompilerGenerated]
    private sealed class Class179
    {
        public PopulationData gclass146_0;
        public GClass194 gclass194_0;
        public GameRace gclass21_0;
        public int int_0;
        public System.Func<FleetData, bool> func_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0 != this.gclass146_0.SystemBodyData;
        }

        internal bool method_1(SystemBodyData gclass1_0)
        {
            return gclass1_0.Gravity >= this.gclass194_0.double_7 && gclass1_0.Gravity <= this.gclass194_0.double_8;
        }

        internal bool method_2(SystemBodyData gclass1_0)
        {
            return gclass1_0.method_14(this.gclass194_0);
        }

        internal bool method_3(PopulationData gclass146_1)
        {
            return gclass146_1.RaceData == this.gclass21_0;
        }

        internal bool method_4(PopulationData gclass146_1)
        {
            return gclass146_1.RaceData == this.gclass21_0;
        }

        internal bool method_5(PopulationData gclass146_1)
        {
            return gclass146_1.RaceData == this.gclass21_0;
        }

        internal bool method_6(PopulationData gclass146_1)
        {
            return gclass146_1.RaceData == this.gclass21_0;
        }

        internal bool method_7(SystemData200 gclass200_0)
        {
            return gclass200_0.double_6 < 10.0 && gclass200_0.int_13 < this.int_0;
        }

        internal bool method_8(PopulationData gclass146_1)
        {
            return gclass146_1.RaceData == this.gclass21_0 && gclass146_1 != this.gclass146_0;
        }

        internal bool method_9(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass21_0;
        }

        internal bool method_10(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass21_0;
        }

        internal bool method_11(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0;
        }

        internal bool method_12(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass21_0;
        }

        internal bool method_13(PopulationData gclass146_1)
        {
            return gclass146_1 != this.gclass146_0;
        }

        internal bool method_14(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass21_0;
        }

        internal bool method_15(PopulationData gclass146_1)
        {
            return gclass146_1.RaceData == this.gclass21_0 && gclass146_1.decimal_30 > 10M;
        }
    }

    [CompilerGenerated]
    private sealed class Class180
    {
        public List<SystemBodyData> list_0;
        public List<SystemData200> list_1;
        public GClass0.Class179 class179_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return !this.list_0.Contains(gclass1_0);
        }

        internal bool method_1(SystemBodyData gclass1_0)
        {
            return gclass1_0.double_42 > AuroraUtils.double_29 && !this.list_0.Contains(gclass1_0);
        }

        internal bool method_2(SystemData200 gclass200_0)
        {
            return !this.list_1.Contains(gclass200_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class181
    {
        public int int_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.MaxColonyCost > 0M && gclass1_0.MaxColonyCost < this.int_0 &&
                   gclass1_0.MaxColonyCost >= this.int_0 - 1;
        }
    }

    [CompilerGenerated]
    private sealed class Class182
    {
        public SystemData200 gclass200_0;
        public GClass0.Class180 class180_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0 && gclass1_0.MaxColonyCost < 5M &&
                   gclass1_0.Gravity >= this.class180_0.class179_0.gclass194_0.double_7 &&
                   gclass1_0.Gravity <= this.class180_0.class179_0.gclass194_0.double_8;
        }
    }

    [CompilerGenerated]
    private sealed class Class183
    {
        public PopulationData gclass146_0;

        internal bool method_0(GClass16 gclass16_0)
        {
            return gclass16_0.genum97_0 == this.gclass146_0.gclass6_0.genum97_0;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.AssignedPopulation == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class184
    {
        public GClass16 gclass16_0;

        internal bool method_0(GroundUnitFormationTemplateData gclass102_0)
        {
            return gclass102_0.AutomatedTemplateType == this.gclass16_0.genum116_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class185
    {
        public SystemData200 gclass200_0;
        public System.Func<Star197, bool> func_0;
        public System.Func<SystemBodyData, bool> func_1;

        internal bool method_0(Star197 gclass197_0)
        {
            return gclass197_0.SystemData == this.gclass200_0;
        }

        internal bool method_1(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0 && gclass1_0.StarData.bool_1 &&
                   (gclass1_0.BodyClass == PlanetBodyClass.Planet || gclass1_0.BodyClass == PlanetBodyClass.Moon) &&
                   gclass1_0.BodyTypeId != AuroraSystemBodyType.GasGiant &&
                   gclass1_0.BodyTypeId != AuroraSystemBodyType.Superjovian;
        }
    }

    [CompilerGenerated]
    private sealed class Class186
    {
        public SystemBodyData gclass1_0;
        public GClass194 gclass194_0;
        public GameRace gclass21_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.SystemBodyData == this.gclass1_0 && gclass146_0.SpeciesData == this.gclass194_0;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class187
    {
        public List<SystemData200> list_0;
        public GClass0.Class186 class186_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return this.list_0.Contains(gclass1_0.SystemData) && gclass1_0 != this.class186_0.gclass1_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class188
    {
        public List<SystemData200> list_0;

        internal bool method_0(JumpPoint120 gclass120_0)
        {
            return this.list_0.Contains(gclass120_0.SystemData) && gclass120_0.LinkedJumpPoint == null;
        }
    }

    [CompilerGenerated]
    private sealed class Class189
    {
        public TechSystem gclass164_0;
        public TechTypeData gclass163_0;

        internal bool method_0(TechSystem gclass164_1)
        {
            return gclass164_1.gclass163_0 == this.gclass163_0 && !gclass164_1.bool_4 &&
                   gclass164_1.decimal_0 > this.gclass164_0.decimal_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class190
    {
        public TechSystem gclass164_0;
        public TechTypeData gclass163_0;

        internal bool method_0(TechSystem gclass164_1)
        {
            return gclass164_1.gclass163_0 == this.gclass163_0 && !gclass164_1.bool_4 &&
                   gclass164_1.decimal_0 > this.gclass164_0.decimal_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class191
    {
        public TechSystem gclass164_0;
        public TechTypeData gclass163_0;

        internal bool method_0(TechSystem gclass164_1)
        {
            return gclass164_1.gclass163_0 == this.gclass163_0 && !gclass164_1.bool_4 &&
                   gclass164_1.decimal_0 > this.gclass164_0.decimal_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class192
    {
        public TechSystem gclass164_0;
        public TechTypeData gclass163_0;

        internal bool method_0(TechSystem gclass164_1)
        {
            return gclass164_1.gclass163_0 == this.gclass163_0 && !gclass164_1.bool_4 &&
                   gclass164_1.decimal_0 > this.gclass164_0.decimal_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class193
    {
        public TechSystem gclass164_0;
        public TechTypeData gclass163_0;

        internal bool method_0(TechSystem gclass164_1)
        {
            return gclass164_1.gclass163_0 == this.gclass163_0 && !gclass164_1.bool_4 &&
                   gclass164_1.decimal_0 > this.gclass164_0.decimal_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class194
    {
        public TechSystem gclass164_0;
        public TechTypeData gclass163_0;

        internal bool method_0(TechSystem gclass164_1)
        {
            return gclass164_1.gclass163_0 == this.gclass163_0 && !gclass164_1.bool_4 &&
                   gclass164_1.decimal_0 > this.gclass164_0.decimal_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class195
    {
        public GameRace gclass21_0;
        public Decimal decimal_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass164_0.decimal_0 >= this.decimal_0;
        }

        internal bool method_1(TechSystem gclass164_0)
        {
            return gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass164_0.decimal_0 >= this.decimal_0 / 2M;
        }

        internal bool method_2(TechSystem gclass164_0)
        {
            return gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass164_0.decimal_0 >= this.decimal_0 / 3M;
        }
    }

    [CompilerGenerated]
    private sealed class Class196
    {
        public TechSystem gclass164_0;
        public TechTypeData gclass163_0;

        internal bool method_0(TechSystem gclass164_1)
        {
            return gclass164_1.gclass163_0 == this.gclass163_0 && !gclass164_1.bool_4 &&
                   gclass164_1.decimal_0 > this.gclass164_0.decimal_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class197
    {
        public GameRace gclass21_0;
        public GClass0 gclass0_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.decimal_30 > 0M && gclass146_0.RaceData == this.gclass21_0;
        }

        internal bool method_1(TechSystem gclass164_0)
        {
            return gclass164_0.gclass163_0 == this.gclass0_0.TechTypeDataDictionary[TechType.MaximumEngineSize] &&
                   gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_2(TechSystem gclass164_0)
        {
            return gclass164_0.gclass163_0 == this.gclass0_0.TechTypeDataDictionary[TechType.MaximumEngineSize];
        }
    }

    [CompilerGenerated]
    private sealed class Class198
    {
        public TechTypeData gclass163_0;
        public GClass0.Class197 class197_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.gclass163_0 == this.gclass163_0 &&
                   gclass164_0.dictionary_0.ContainsKey(this.class197_0.gclass21_0.RaceID);
        }

        internal bool method_1(TechSystem gclass164_0)
        {
            return gclass164_0.gclass163_0 == this.gclass163_0 && !gclass164_0.bool_4;
        }
    }

    [CompilerGenerated]
    private sealed class Class199
    {
        public TechSystem gclass164_0;
        public GClass0.Class198 class198_0;

        internal bool method_0(TechSystem gclass164_1)
        {
            return gclass164_1.gclass163_0 == this.class198_0.gclass163_0 &&
                   gclass164_1.int_4 <= this.gclass164_0.int_4;
        }
    }

    [CompilerGenerated]
    private sealed class Class200
    {
        public CommanderNameThemeData gclass58_0;

        internal bool method_0(CommanderNameDefinition gclass57_0)
        {
            return gclass57_0.CommanderNameTheme == this.gclass58_0 && !gclass57_0.AllowedForFirstName;
        }

        internal bool method_1(CommanderNameDefinition gclass57_0)
        {
            return gclass57_0.CommanderNameTheme == this.gclass58_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class201
    {
        public int int_0;

        internal bool method_0(CompanyNameData gclass47_0)
        {
            return gclass47_0.CompanyType == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class202
    {
        public AuroraComponentType auroraComponentType_0;
        public Decimal decimal_0;
        public Decimal decimal_1;
        public Decimal decimal_2;
        public GameRace gclass21_0;

        internal bool method_0(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass164_0.int_1 == 1 &&
                   gclass230_0.gclass231_0.ComponentTypeID == this.auroraComponentType_0 &&
                   gclass230_0.decimal_1 == this.decimal_0 && gclass230_0.decimal_3 == this.decimal_1 &&
                   gclass230_0.decimal_2 == this.decimal_2;
        }

        internal bool method_1(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass230_0.gclass231_0.ComponentTypeID == this.auroraComponentType_0 &&
                   gclass230_0.decimal_1 == this.decimal_0 && gclass230_0.decimal_3 == this.decimal_1 &&
                   gclass230_0.decimal_2 == this.decimal_2;
        }
    }

    [CompilerGenerated]
    private sealed class Class203
    {
        public GameRace gclass21_0;
        public ShipComponent gclass230_0;

        internal bool method_0(ShipComponent gclass230_1)
        {
            return gclass230_1.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass230_1.gclass231_0.ComponentTypeID ==
                   this.gclass230_0.gclass231_0.ComponentTypeID &&
                   gclass230_1.decimal_1 == this.gclass230_0.decimal_1 &&
                   gclass230_1.decimal_3 == this.gclass230_0.decimal_3 &&
                   gclass230_1.decimal_2 == this.gclass230_0.decimal_2;
        }
    }

    [CompilerGenerated]
    private sealed class Class204
    {
        public GClass0 gclass0_0;
        public TechType genum122_0;
        public int int_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.gclass163_0 == this.gclass0_0.TechTypeDataDictionary[this.genum122_0] &&
                   gclass164_0.int_4 <= this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class205
    {
        public ResearchFieldData gclass162_0;

        internal bool method_0(TechTypeData gclass163_0)
        {
            return gclass163_0.ResearchField == this.gclass162_0 && gclass163_0.RuinTechType;
        }
    }

    [CompilerGenerated]
    private sealed class Class206
    {
        public PopulationData gclass146_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class207
    {
        public List<SystemData200> list_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return this.list_0.Contains(gclass40_0.gclass85_0.System.ActualSystemData);
        }
    }

    [CompilerGenerated]
    private sealed class Class208
    {
        public GameRace gclass21_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.gclass21_1 == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class209
    {
        public List<SystemData200> list_0;

        internal bool method_0(GroundUnitFormationElement gclass39_0)
        {
            return this.list_0.Contains(gclass39_0.Formation.PopulationData.gclass202_0.ActualSystemData);
        }
    }

    [CompilerGenerated]
    private sealed class Class210
    {
        public FCTShipData40 gclass40_0;

        internal bool method_0(AcidAttack gclass25_0)
        {
            return gclass25_0.TargetShip == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class211
    {
        public List<GClass132> list_0;
        public GClass0 gclass0_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return this.list_0.Contains(gclass65_0.gclass132_0) && gclass65_0.genum10_0 == GEnum10.const_0 &&
                   gclass65_0.decimal_3 == this.gclass0_0.GameTime;
        }
    }

    [CompilerGenerated]
    private sealed class Class212
    {
        public GameRace gclass21_0;
    }

    [CompilerGenerated]
    private sealed class Class213
    {
        public FCTShipData40 gclass40_0;
        public GClass0.Class212 class212_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0 == this.gclass40_0;
        }

        internal bool method_1(GClass65 gclass65_0)
        {
            return gclass65_0.gclass21_1 == this.class212_0.gclass21_0 &&
                   gclass65_0.gclass132_0.gclass40_0 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class214
    {
        public int int_0;

        internal bool method_0(GClass132 gclass132_0)
        {
            return gclass132_0.gclass129_0.decimal_4 == this.int_0;
        }

        internal bool method_1(ShipComponent gclass230_0)
        {
            return gclass230_0.decimal_3 == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class215
    {
        public List<int> list_0;
        public List<int> list_1;

        internal bool method_0(TechSystem gclass164_0)
        {
            return this.list_0.Contains(gclass164_0.TechSystemID);
        }

        internal bool method_1(GClass185 gclass185_0)
        {
            return this.list_1.Contains(gclass185_0.int_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class216
    {
        public List<int> list_0;

        internal bool method_0(ShipHull gclass76_0)
        {
            return this.list_0.Contains(gclass76_0.ShipHullDescriptionID);
        }
    }

    [CompilerGenerated]
    private sealed class Class217
    {
        public ShipHull gclass76_0;

        internal bool method_0(ShipClassTemplate184 gclass184_0)
        {
            return gclass184_0.HullID == this.gclass76_0.ShipHullDescriptionID;
        }
    }

    [CompilerGenerated]
    private sealed class Class218
    {
        public GameRace gclass21_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass21_0;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass21_0;
        }

        internal bool method_2(GClass55 gclass55_0)
        {
            return gclass55_0.gclass21_0 == this.gclass21_0;
        }

        internal bool method_3(GClass22 gclass22_0)
        {
            return gclass22_0.gclass21_0 == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class219
    {
        public GameRace gclass21_0;
        public PopulationData gclass146_0;

        internal bool method_0(GClass159 gclass159_0)
        {
            return gclass159_0.gclass21_0 == this.gclass21_0 && gclass159_0.gclass146_0 == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class220
    {
        public SystemData200 gclass200_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.ActualSystemData == this.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class221
    {
        public GameRace gclass21_0;

        internal bool method_0(NavalAdminCommand gclass83_0)
        {
            return gclass83_0.Race == this.gclass21_0;
        }

        internal bool method_1(GClass22 gclass22_0)
        {
            return gclass22_0.gclass21_0 == this.gclass21_0 && gclass22_0.int_38 == 0;
        }

        internal bool method_2(GClass12 gclass12_0)
        {
            return gclass12_0.int_0 > this.gclass21_0.LastProgressionOrder;
        }
    }

    [CompilerGenerated]
    private sealed class Class222
    {
        public int int_0;

        internal bool method_0(GClass211 gclass211_0)
        {
            return gclass211_0.int_0 >= this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class223
    {
        public RaceOperationalGroupElement gclass11_0;

        internal bool method_0(GClass22 gclass22_0)
        {
            return gclass22_0.gclass14_0.AutomatedClassDesignTypeID == this.gclass11_0.AutomatedClassDesign.AutomatedClassDesignTypeID;
        }
    }

    [CompilerGenerated]
    private sealed class Class224
    {
        public GClass211 gclass211_0;
        public GClass0 gclass0_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass211_0.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class225
    {
        public double double_0;
        public GClass0.Class224 class224_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return this.class224_0.gclass0_0.GetDistanceBetween(gclass1_0.XCoordinate, gclass1_0.YCoordinate,
                this.class224_0.gclass211_0.double_0, this.class224_0.gclass211_0.double_1) < this.double_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class226
    {
        public AuroraCommanderType auroraCommanderType_0;

        internal bool method_0(AssignmentTypeFilter gclass49_0)
        {
            return gclass49_0.LeaderType == AuroraCommanderType.All ||
                   gclass49_0.LeaderType == this.auroraCommanderType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class227
    {
        public List<GameRace> list_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return this.list_0.Contains(gclass146_0.RaceData);
        }
    }

    [CompilerGenerated]
    private sealed class Class228
    {
        public GameRace gclass21_0;
        public System.Func<FCTShipData40, bool> func_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass21_0;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass21_0;
        }

        internal bool method_2(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0 && !gclass40_0.gclass22_0.bool_2 &&
                   gclass40_0.gclass187_0 == null;
        }

        internal bool method_3(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass22_0.bool_2 &&
                   gclass40_0.gclass187_0 == null && gclass40_0.gclass22_0.int_37 == 0;
        }

        internal bool method_4(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass22_0.bool_2 &&
                   gclass40_0.gclass187_0 == null && gclass40_0.gclass22_0.int_37 == 1;
        }

        internal bool method_5(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass187_0 != null;
        }

        internal bool method_6(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass21_0;
        }

        internal bool method_7(GClass193 gclass193_0)
        {
            return gclass193_0.gclass21_0 == this.gclass21_0 &&
                   gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Naval;
        }

        internal bool method_8(GClass193 gclass193_0)
        {
            return gclass193_0.gclass21_0 == this.gclass21_0 &&
                   gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Commercial;
        }

        internal bool method_9(GClass193 gclass193_0)
        {
            return gclass193_0.gclass21_0 == this.gclass21_0 &&
                   gclass193_0.auroraShipyardType_0 == AuroraShipyardType.RepairYard;
        }

        internal bool method_10(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass21_0;
        }

        internal bool method_11(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass21_0;
        }

        internal bool method_12(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0;
        }

        internal bool method_13(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0;
        }

        internal bool method_14(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass21_0;
        }

        internal bool method_15(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0;
        }

        internal bool method_16(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0;
        }

        internal bool method_17(GClass55 gclass55_0)
        {
            return gclass55_0.auroraCommanderType_0 == AuroraCommanderType.Scientist &&
                   gclass55_0.gclass21_0 == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class229
    {
        public IGrouping<PlanetaryInstallationType, GClass158> igrouping_0;

        internal bool method_0(GClass158 gclass158_0)
        {
            return gclass158_0.gclass157_0 == this.igrouping_0.Key;
        }

        internal bool method_1(GClass158 gclass158_0)
        {
            return gclass158_0.gclass157_0 == this.igrouping_0.Key;
        }
    }

    [CompilerGenerated]
    private sealed class Class230
    {
        public GClass193 gclass193_0;

        internal bool method_0(GClass192 gclass192_0)
        {
            return gclass192_0.gclass193_0 == this.gclass193_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class231
    {
        public CommanderNameThemeData gclass58_0;

        internal bool method_0(CommanderNameDefinition gclass57_0)
        {
            return gclass57_0.CommanderNameTheme == this.gclass58_0 && gclass57_0.AllowedForFirstName;
        }

        internal bool method_1(CommanderNameDefinition gclass57_0)
        {
            return gclass57_0.CommanderNameTheme == this.gclass58_0 && gclass57_0.AllowedForLastName;
        }

        internal bool method_2(CommanderNameDefinition gclass57_0)
        {
            return gclass57_0.CommanderNameTheme == this.gclass58_0 && gclass57_0.AllowedForFirstName;
        }

        internal bool method_3(CommanderNameDefinition gclass57_0)
        {
            return gclass57_0.CommanderNameTheme == this.gclass58_0 && gclass57_0.AllowedForLastName;
        }

        internal bool method_4(CommanderNameDefinition gclass57_0)
        {
            return gclass57_0.CommanderNameTheme == this.gclass58_0 && gclass57_0.AllowedForFirstName;
        }

        internal bool method_5(CommanderNameDefinition gclass57_0)
        {
            return gclass57_0.CommanderNameTheme == this.gclass58_0 && gclass57_0.AllowedForLastName;
        }

        internal bool method_6(CommanderNameDefinition gclass57_0)
        {
            return gclass57_0.CommanderNameTheme == this.gclass58_0 && gclass57_0.AllowedForThirdName;
        }

        internal bool method_7(CommanderNameDefinition gclass57_0)
        {
            return gclass57_0.CommanderNameTheme == this.gclass58_0 && gclass57_0.AllowedForFirstName;
        }

        internal bool method_8(CommanderNameDefinition gclass57_0)
        {
            return gclass57_0.CommanderNameTheme == this.gclass58_0 && gclass57_0.AllowedForLastName;
        }

        internal bool method_9(CommanderNameDefinition gclass57_0)
        {
            return gclass57_0.CommanderNameTheme == this.gclass58_0 && gclass57_0.AllowedForThirdName;
        }

        internal bool method_10(CommanderNameDefinition gclass57_0)
        {
            return gclass57_0.CommanderNameTheme == this.gclass58_0 && gclass57_0.AllowedForFirstName;
        }

        internal bool method_11(CommanderNameDefinition gclass57_0)
        {
            return gclass57_0.CommanderNameTheme == this.gclass58_0 && gclass57_0.AllowedForLastName;
        }

        internal bool method_12(CommanderNameDefinition gclass57_0)
        {
            return gclass57_0.CommanderNameTheme == this.gclass58_0 && gclass57_0.AllowedForThirdName;
        }
    }

    [CompilerGenerated]
    private sealed class Class232
    {
        public SystemBodyData gclass1_0;

        internal bool method_0(SystemBodyData gclass1_1)
        {
            return gclass1_1.SystemData == this.gclass1_0.SystemData;
        }
    }

    [CompilerGenerated]
    private sealed class Class233
    {
        public GameRace gclass21_0;
        public GClass194 gclass194_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.method_58(this.gclass21_0, this.gclass194_0, true) < 5M;
        }
    }

    [CompilerGenerated]
    private sealed class Class234
    {
        public GameRace gclass21_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class235
    {
        public SpecialNPRIDs genum6_0;

        internal bool method_0(AutomatedGroundTemplateDesign gclass23_0)
        {
            return gclass23_0.SpecialNPR == this.genum6_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class236
    {
        public PopulationData gclass146_0;

        internal Decimal method_0(AutomatedGroundTemplateDesign gclass23_0)
        {
            return gclass23_0.gclass102_0.method_3(this.gclass146_0) * gclass23_0.int_2;
        }
    }

    [CompilerGenerated]
    private sealed class Class237
    {
        public PopulationData gclass146_0;
        public AutomatedGroundTemplateDesignType genum116_0;
        public AutomatedGroundTemplateDesignType genum116_1;
        public System.Func<GroundUnitFormationData, bool> func_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass146_0.RaceData &&
                   gclass103_0.OriginalTemplateData.AutomatedTemplateType == this.genum116_0 && gclass103_0.PopulationData == this.gclass146_0;
        }

        internal bool method_1(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass146_0.RaceData && gclass103_0.ParentFormationData == null &&
                   gclass103_0.OriginalTemplateData.AutomatedTemplateType == this.genum116_1 && gclass103_0.PopulationData == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class238
    {
        public GroundUnitFormationData gclass103_0;
        public GClass0.Class237 class237_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.RaceData == this.class237_0.gclass146_0.RaceData &&
                   gclass103_1.ParentFormationData == this.gclass103_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class239
    {
        public GameRace gclass21_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }
    }

    [CompilerGenerated]
    private sealed class Class240
    {
        public SystemData200 gclass200_0;
        public System.Func<RacialSystemSurvey, bool> func_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0;
        }

        internal bool method_1(Star197 gclass197_0)
        {
            return gclass197_0.SystemData == this.gclass200_0;
        }

        internal bool method_2(JumpPoint120 gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass200_0;
        }

        internal bool method_3(GClass212 gclass212_0)
        {
            return gclass212_0.gclass200_0 == this.gclass200_0;
        }

        internal bool method_4(GClass214 gclass214_0)
        {
            return gclass214_0.gclass200_0 == this.gclass200_0;
        }

        internal bool method_5(FleetData gclass85_0)
        {
            return gclass85_0.System.ActualSystemData == this.gclass200_0;
        }

        internal bool method_6(GClass132 gclass132_0)
        {
            return gclass132_0.gclass200_0 == this.gclass200_0;
        }

        internal bool method_7(FCTMassDriverPacket126 gclass126_0)
        {
            return gclass126_0.System == this.gclass200_0;
        }

        internal bool method_8(GClass220 gclass220_0)
        {
            return gclass220_0.gclass1_0.SystemData == this.gclass200_0;
        }

        internal bool method_9(GClass65 gclass65_0)
        {
            return gclass65_0.gclass200_0 == this.gclass200_0;
        }

        internal bool method_10(GClass233 gclass233_0)
        {
            return gclass233_0.gclass200_0 == this.gclass200_0;
        }

        internal bool method_11(GClass59 gclass59_0)
        {
            return gclass59_0.gclass200_0 == this.gclass200_0;
        }

        internal bool method_12(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.ActualSystemData == this.gclass200_0;
        }

        internal bool method_13(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0.ActualSystemData == this.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class241
    {
        public Star197 gclass197_0;

        internal bool method_0(Star197 gclass197_1)
        {
            return gclass197_1.Component > this.gclass197_0.Component;
        }

        internal bool method_1(SystemBodyData gclass1_0)
        {
            return gclass1_0.StarData == this.gclass197_0;
        }

        internal bool method_2(GClass212 gclass212_0)
        {
            return gclass212_0.gclass1_0.StarData == this.gclass197_0;
        }

        internal bool method_3(GClass220 gclass220_0)
        {
            return gclass220_0.gclass1_0.StarData == this.gclass197_0;
        }

        internal bool method_4(PopulationData gclass146_0)
        {
            return gclass146_0.SystemBodyData.StarData == this.gclass197_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class242
    {
        public Star197 gclass197_0;

        internal bool method_0(Star197 gclass197_1)
        {
            return gclass197_1.OrbitingStar == this.gclass197_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class243
    {
        public SystemBodyData gclass1_0;

        internal bool method_0(SystemBodyData gclass1_1)
        {
            return gclass1_1.ParentBodyData == this.gclass1_0;
        }

        internal bool method_1(GClass212 gclass212_0)
        {
            return gclass212_0.gclass1_0 == this.gclass1_0;
        }

        internal bool method_2(GClass220 gclass220_0)
        {
            return gclass220_0.gclass1_0 == this.gclass1_0 || gclass220_0.gclass1_0.ParentBodyData == this.gclass1_0;
        }

        internal bool method_3(PopulationData gclass146_0)
        {
            return gclass146_0.SystemBodyData == this.gclass1_0 || gclass146_0.SystemBodyData.ParentBodyData == this.gclass1_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class244
    {
        public List<SystemBodyData> list_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return this.list_0.Contains(gclass146_0.SystemBodyData);
        }
    }

    [CompilerGenerated]
    private sealed class LambdaScope245
    {
        public SystemData200 System;

        internal bool method_0(GClass212 gclass212_0)
        {
            return gclass212_0.gclass200_0 == this.System;
        }
    }

    [CompilerGenerated]
    private sealed class Class246
    {
        public int int_0;

        internal bool method_0(GClass141 gclass141_0)
        {
            return gclass141_0.MaxChance >= this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class247
    {
        public AuroraContactType auroraContactType_0;
        public int int_0;
        public GameRace gclass21_0;
        public GClass0 gclass0_0;
        public int int_1;
        public GEnum10 genum10_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.auroraContactType_0 == this.auroraContactType_0 && gclass65_0.int_1 == this.int_0 &&
                   gclass65_0.gclass21_1 == this.gclass21_0 &&
                   gclass65_0.decimal_3 >= this.gclass0_0.GameTime - this.int_1 &&
                   gclass65_0.genum10_0 == this.genum10_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class248
    {
        public AuroraContactType auroraContactType_0;
        public int int_0;
        public GameRace gclass21_0;
        public GClass0 gclass0_0;
        public int int_1;
        public GEnum10 genum10_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.auroraContactType_0 == this.auroraContactType_0 && gclass65_0.int_1 == this.int_0 &&
                   gclass65_0.gclass21_1 == this.gclass21_0 &&
                   gclass65_0.decimal_3 >= this.gclass0_0.GameTime - this.int_1 &&
                   gclass65_0.genum10_0 == this.genum10_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class249
    {
        public GameRace gclass21_0;
        public GClass0 gclass0_0;
        public AuroraContactType auroraContactType_0;
        public int int_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.gclass21_1 == this.gclass21_0 && gclass65_0.decimal_3 == this.gclass0_0.GameTime &&
                   gclass65_0.auroraContactType_0 == this.auroraContactType_0 && gclass65_0.int_1 == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class250
    {
        public GameRace gclass21_0;
        public GClass0 gclass0_0;
        public AuroraContactType auroraContactType_0;
        public int int_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.gclass21_1 == this.gclass21_0 && gclass65_0.decimal_3 == this.gclass0_0.GameTime &&
                   gclass65_0.auroraContactType_0 == this.auroraContactType_0 && gclass65_0.int_1 == this.int_0 &&
                   gclass65_0.genum10_0 != GEnum10.const_4;
        }
    }

    [CompilerGenerated]
    private sealed class Class251
    {
        public NavalAdminCommand gclass83_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass83_0.Race &&
                   gclass146_0.dictionary_0.ContainsKey(AuroraInstallationType.NavalHeadquarters);
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass83_0.Race;
        }

        internal bool method_2(FleetData gclass85_0)
        {
            return gclass85_0.ParentNavalCommand == this.gclass83_0;
        }

        internal bool method_3(NavalAdminCommand gclass83_1)
        {
            return gclass83_1.ParentAdminCommand == this.gclass83_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class252
    {
        public ShippingLineData gclass187_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.ShippingLine == this.gclass187_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class253
    {
        public GameRace gclass21_0;
        public CheckState checkState_0;
        public GClass0 gclass0_0;
        public AuroraEventCategory auroraEventCategory_0;
        public System.Func<GClass87, bool> func_0;
        public System.Func<GClass87, bool> func_1;
        public System.Func<GClass87, bool> func_2;

        internal bool method_0(GClass87 gclass87_0)
        {
            return (gclass87_0.gclass21_0 == this.gclass21_0 || this.checkState_0 == CheckState.Checked &&
                       (!gclass87_0.gclass21_0.NPR || this.gclass0_0.bool_10)) &&
                   !gclass87_0.gclass21_0.method_265(gclass87_0.gclass88_0.EventTypeId);
        }

        internal bool method_1(GClass87 gclass87_0)
        {
            if (gclass87_0.gclass21_0 == this.gclass21_0)
                return true;
            if (this.checkState_0 != CheckState.Checked)
                return false;
            return !gclass87_0.gclass21_0.NPR || this.gclass0_0.bool_10;
        }

        internal bool method_2(GClass87 gclass87_0)
        {
            return gclass87_0.auroraEventCategory_0 == this.auroraEventCategory_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class254
    {
        public Decimal decimal_0;

        internal bool method_0(GClass91 gclass91_0)
        {
            return gclass91_0.decimal_0 > this.decimal_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class255
    {
        public GClass87 gclass87_0;
        public System.Func<EventColourSetting, bool> func_0;
        public System.Func<EventColourSetting, bool> func_1;

        internal bool method_0(EventColourSetting gclass90_0)
        {
            return gclass90_0.EventType == this.gclass87_0.gclass88_0;
        }

        internal bool method_1(EventColourSetting gclass90_0)
        {
            return gclass90_0.EventType == this.gclass87_0.gclass88_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class256
    {
        public GClass0 gclass0_0;
        public GameRace gclass21_0;
        public CheckState checkState_0;

        internal bool method_0(GClass87 gclass87_0)
        {
            if (gclass87_0.gclass21_0.NPR && !this.gclass0_0.bool_10)
                return false;
            return gclass87_0.gclass21_0 == this.gclass21_0 || this.checkState_0 == CheckState.Checked;
        }
    }

    [CompilerGenerated]
    private sealed class Class257
    {
        public GClass87 gclass87_0;
        public System.Func<EventColourSetting, bool> func_0;

        internal bool method_0(EventColourSetting gclass90_0)
        {
            return gclass90_0.EventType == this.gclass87_0.gclass88_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class258
    {
        public GClass0 gclass0_0;
        public double double_0;
        public double double_1;
        public GameRace gclass21_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return this.gclass0_0.method_519(gclass1_0.XCoordinate, this.double_0, 1.0) &&
                   this.gclass0_0.method_519(gclass1_0.YCoordinate, this.double_1, 1.0);
        }
    }

    [CompilerGenerated]
    private sealed class Class259
    {
        public SystemBodyData gclass1_0;
        public GClass0.Class258 class258_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.SystemBodyData == this.gclass1_0 && gclass146_0.RaceData == this.class258_0.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class260
    {
        public GClass0 gclass0_0;
        public GClass233 gclass233_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return this.gclass0_0.method_519(gclass1_0.XCoordinate, this.gclass233_0.double_0, 1.0) &&
                   this.gclass0_0.method_519(gclass1_0.YCoordinate, this.gclass233_0.double_1, 1.0) &&
                   gclass1_0.SystemData == this.gclass233_0.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class261
    {
        public GClass0 gclass0_0;
        public int int_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return gclass117_0.decimal_8 == this.gclass0_0.GameTime;
        }
    }

    [CompilerGenerated]
    private sealed class Class262
    {
        public GClass37 gclass37_0;

        internal bool method_0(GClass38 gclass38_0)
        {
            return gclass38_0.gclass40_0 == this.gclass37_0.gclass40_0 &&
                   gclass38_0.gclass230_0 == this.gclass37_0.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class263
    {
        public GClass38 gclass38_0;
        public GClass0.Class261 class261_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.gclass40_0 == this.gclass38_0.gclass40_0 && gclass65_0.genum10_0 == GEnum10.const_0 &&
                   gclass65_0.decimal_3 == this.class261_0.gclass0_0.GameTime - this.class261_0.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class264
    {
        public GClass65 gclass65_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0 == this.gclass65_0.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class265
    {
        public GClass117 gclass117_0;

        internal bool method_0(GClass117 gclass117_1)
        {
            return gclass117_1.gclass40_0.gclass85_0 == this.gclass117_0.gclass40_0.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class266
    {
        public SpecialNPRIDs genum6_0;

        internal bool method_0(GameRace gclass21_0)
        {
            return gclass21_0.SpecialNPRID == this.genum6_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class267
    {
        public AutomatedClassDesignType genum120_0;

        internal bool method_0(GClass22 gclass22_0)
        {
            return gclass22_0.gclass14_0.AutomatedClassDesignTypeID == this.genum120_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class268
    {
        public GameRace gclass21_0;
        public CheckState checkState_0;
        public System.Func<JumpPoint120, bool> func_0;

        internal bool method_0(JumpPoint120 gclass120_0)
        {
            if (gclass120_0.RacialJumpPointSurveys[this.gclass21_0.RaceID].Explored != 1 || gclass120_0.LinkedJumpPoint == null)
                return false;
            return gclass120_0.RacialJumpPointSurveys[this.gclass21_0.RaceID].MilitaryRestricted == 0 ||
                   this.checkState_0 == CheckState.Unchecked;
        }
    }

    [CompilerGenerated]
    private sealed class Class269
    {
        public SystemData200 gclass200_0;
        public GClass0.Class268 class268_0;

        internal bool method_0(JumpPoint120 gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass200_0 &&
                   gclass120_0.RacialJumpPointSurveys.ContainsKey(this.class268_0.gclass21_0.RaceID);
        }
    }

    [CompilerGenerated]
    private sealed class Class270
    {
        public GameRace gclass21_0;
        public CheckState checkState_0;
        public System.Func<JumpPoint120, bool> func_0;

        internal bool method_0(JumpPoint120 gclass120_0)
        {
            if (gclass120_0.RacialJumpPointSurveys[this.gclass21_0.RaceID].Explored != 1 || gclass120_0.LinkedJumpPoint == null)
                return false;
            return gclass120_0.RacialJumpPointSurveys[this.gclass21_0.RaceID].MilitaryRestricted == 0 ||
                   this.checkState_0 == CheckState.Unchecked;
        }
    }

    [CompilerGenerated]
    private sealed class Class271
    {
        public SystemData200 gclass200_0;
        public GClass0.Class270 class270_0;

        internal bool method_0(JumpPoint120 gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass200_0 &&
                   gclass120_0.RacialJumpPointSurveys.ContainsKey(this.class270_0.gclass21_0.RaceID);
        }
    }

    [CompilerGenerated]
    private sealed class Class272
    {
        public SystemData200 gclass200_0;
        public System.Func<Star197, bool> func_0;
        public System.Func<SystemBodyData, bool> func_1;

        internal bool method_0(Star197 gclass197_0)
        {
            return gclass197_0.SystemData == this.gclass200_0;
        }

        internal bool method_1(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0 && gclass1_0.StarData.bool_1 &&
                   (gclass1_0.BodyClass == PlanetBodyClass.Planet || gclass1_0.BodyClass == PlanetBodyClass.Moon) &&
                   gclass1_0.BodyTypeId != AuroraSystemBodyType.GasGiant &&
                   gclass1_0.BodyTypeId != AuroraSystemBodyType.Superjovian;
        }
    }

    [CompilerGenerated]
    private sealed class Class273
    {
        public MoveOrder gclass139_0;

        internal bool method_0(JumpPoint120 gclass120_0)
        {
            return this.gclass139_0.Race.RacialSystemDictionary.Values
                .Select<RacialSystemSurvey, SystemData200>(gc202 => gc202.ActualSystemData)
                .Contains<SystemData200>(gclass120_0.SystemData);
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass139_0.Race && gclass85_0.MoveOrderDictionary.Count > 0 &&
                   gclass85_0 != this.gclass139_0.Fleet;
        }

        internal bool method_2(MoveOrder gclass139_1)
        {
            return gclass139_1.DestinationType == DestinationType.const_0 && gclass139_1.DestinationID == this.gclass139_0.DestinationID &&
                   gclass139_1.NewSystem == null;
        }
    }

    [CompilerGenerated]
    private sealed class Class274
    {
        public SystemData200 gclass200_0;

        internal bool method_0(SystemData200 gclass200_1)
        {
            return gclass200_1 != this.gclass200_0;
        }

        internal bool method_1(JumpPoint120 gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass200_0 && gclass120_0.LinkedJumpPoint == null;
        }

        internal bool method_2(SystemBodyData gclass1_0)
        {
            return gclass1_0.list_0.Count > 0 && gclass1_0.SystemData == this.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class275
    {
        public int int_0;
        public System.Func<RacialSystemSurvey, bool> func_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.ActualSystemData.int_13 == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class276
    {
        public SystemData200 gclass200_0;

        internal bool method_0(JumpPoint120 gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class277
    {
        public int int_0;

        internal bool method_0(SystemData200 gclass200_0)
        {
            return gclass200_0.SystemNumber == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class278
    {
        public SystemData200 gclass200_0;

        internal bool method_0(Star197 gclass197_0)
        {
            return gclass197_0.SystemData == this.gclass200_0 && gclass197_0.Component == 1;
        }

        internal bool method_1(Star197 gclass197_0)
        {
            return gclass197_0.SystemData == this.gclass200_0 && gclass197_0.Component > 1;
        }

        internal bool method_2(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0;
        }

        internal bool method_3(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0 && gclass1_0.BodyClass == PlanetBodyClass.Asteroid;
        }

        internal bool method_4(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0;
        }

        internal bool method_5(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class279
    {
        public Star197 gclass197_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            if (gclass1_0.StarData != this.gclass197_0)
                return false;
            return gclass1_0.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                   gclass1_0.BodyTypeId == AuroraSystemBodyType.Superjovian;
        }
    }

    [CompilerGenerated]
    private sealed class Class280
    {
        public Star197 gclass197_0;

        internal bool method_0(Star197 gclass197_1)
        {
            return gclass197_1 == this.gclass197_0.OrbitingStar;
        }

        internal bool method_1(GClass212 gclass212_0)
        {
            return gclass212_0.gclass197_0 == this.gclass197_0;
        }

        internal bool method_2(SystemBodyData gclass1_0)
        {
            if (gclass1_0.StarData != this.gclass197_0)
                return false;
            return gclass1_0.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                   gclass1_0.BodyTypeId == AuroraSystemBodyType.Superjovian;
        }
    }

    [CompilerGenerated]
    private sealed class Class281
    {
        public Star197 gclass197_0;

        internal bool method_0(GClass212 gclass212_0)
        {
            return gclass212_0.gclass197_0 == this.gclass197_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class282
    {
        public SystemData200 gclass200_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            if (gclass1_0.SystemData != this.gclass200_0)
                return false;
            return gclass1_0.BodyClass == PlanetBodyClass.Planet || gclass1_0.BodyClass == PlanetBodyClass.Moon;
        }

        internal bool method_1(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.ActualSystemData == this.gclass200_0;
        }

        internal bool method_2(GClass65 gclass65_0)
        {
            return gclass65_0.auroraContactType_0 == AuroraContactType.Explosion &&
                   gclass65_0.gclass200_0 == this.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class283
    {
        public GameRace gclass21_0;

        internal bool method_0(NavalAdminCommand gclass83_0)
        {
            return gclass83_0.Race == this.gclass21_0 && gclass83_0.ParentAdminCommand == null;
        }

        internal bool method_1(GClass22 gclass22_0)
        {
            return gclass22_0.gclass21_0 == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class284
    {
        public Star197 gclass197_0;

        internal bool method_0(Star197 gclass197_1)
        {
            return gclass197_1.SystemData == this.gclass197_0.SystemData &&
                   gclass197_1.Component == this.gclass197_0.OrbitingComponent;
        }
    }

    [CompilerGenerated]
    private sealed class Class285
    {
        public SystemBodyData gclass1_0;
        public int int_0;

        internal bool method_0(SystemBodyData gclass1_1)
        {
            return gclass1_1.PlanetNumber == this.gclass1_0.PlanetNumber && gclass1_1.OrbitNumber == 0;
        }

        internal bool method_1(SystemBodyData gclass1_1)
        {
            return gclass1_1.PlanetNumber == this.int_0 && gclass1_1.OrbitNumber == 0;
        }
    }

    [CompilerGenerated]
    private sealed class Class286
    {
        public SystemBodyData gclass1_0;

        internal bool method_0(SystemBodyData gclass1_1)
        {
            return gclass1_1.ParentBodyData == this.gclass1_0 && gclass1_1.BodyClass == PlanetBodyClass.Moon;
        }

        internal bool method_1(SystemBodyData gclass1_1)
        {
            return gclass1_1.ParentBodyData == this.gclass1_0 && gclass1_1.BodyClass == PlanetBodyClass.Asteroid;
        }
    }

    [CompilerGenerated]
    private sealed class Class287
    {
        public SystemBodyData gclass1_0;

        internal bool method_0(SystemBodyData gclass1_1)
        {
            return gclass1_1.SystemData == this.gclass1_0.SystemData;
        }
    }

    [CompilerGenerated]
    private sealed class Class288
    {
        public GameRace gclass21_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class289
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData.gclass202_0 == this.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class290
    {
        public Star197 gclass197_0;
        public GClass0 gclass0_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.StarData == this.gclass197_0 && gclass1_0.BodyClass == PlanetBodyClass.Planet;
        }

        internal bool method_1(SystemBodyData gclass1_0)
        {
            return !this.gclass0_0.list_0.Contains(gclass1_0);
        }

        internal bool method_2(SystemBodyData gclass1_0)
        {
            return !this.gclass0_0.list_0.Contains(gclass1_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class291
    {
        public int int_0;

        internal bool method_0(double double_0)
        {
            return double_0 < this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class292
    {
        public double double_0;

        internal bool method_0(double double_1)
        {
            return double_1 < this.double_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class293
    {
        public SystemBodyData gclass1_0;
        public double double_0;
        public double double_1;

        internal bool method_0(SystemBodyData gclass1_1)
        {
            return gclass1_1.Mass < this.gclass1_0.Mass && gclass1_1.OrbitalDistance > this.double_0 &&
                   gclass1_1.OrbitalDistance < this.double_1 && !gclass1_1.bool_8 &&
                   gclass1_1.Mass < this.gclass1_0.Mass;
        }
    }

    [CompilerGenerated]
    private sealed class Class294
    {
        public double double_0;
        public GClass0.Class290 class290_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            if (gclass1_0.StarData != this.class290_0.gclass197_0 || gclass1_0.double_28 <= this.double_0)
                return false;
            return gclass1_0.BodyClass == PlanetBodyClass.Planet || gclass1_0.BodyClass == PlanetBodyClass.Asteroid;
        }
    }

    [CompilerGenerated]
    private sealed class Class295
    {
        public List<FCTShipData40> list_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            if (gclass40_0.method_157(AuroraComponentType.Magazine, false) > 0M)
                return true;
            return gclass40_0.method_157(AuroraComponentType.MissileLauncher, false) > 0M &&
                   this.list_0.Contains(gclass40_0.gclass40_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class296
    {
        public FCTShipData40 gclass40_0;

        internal bool method_0(FCTShipData40 gclass40_1)
        {
            return gclass40_1.gclass40_0 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class297
    {
        public GClass130 gclass130_0;

        internal bool method_0(GClass130 gclass130_1)
        {
            return gclass130_1.gclass129_0 == this.gclass130_0.gclass129_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class298
    {
        public GClass130 gclass130_0;

        internal bool method_0(GClass130 gclass130_1)
        {
            return gclass130_1.gclass129_0 == this.gclass130_0.gclass129_0;
        }

        internal bool method_1(GClass130 gclass130_1)
        {
            return gclass130_1.gclass129_0 == this.gclass130_0.gclass129_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class299
    {
        public SystemBodyData gclass1_0;

        internal bool method_0(SystemBodyData gclass1_1)
        {
            return gclass1_1.ParentBodyData == this.gclass1_0 && gclass1_1.BodyClass == PlanetBodyClass.Moon;
        }
    }

    [CompilerGenerated]
    private sealed class Class300
    {
        public SystemBodyData gclass1_0;

        internal bool method_0(SystemBodyData gclass1_1)
        {
            return gclass1_1.StarData == this.gclass1_0.StarData;
        }
    }

    [CompilerGenerated]
    private sealed class Class301
    {
        public SystemBodyData gclass1_0;
        public System.Func<SystemBodyData, bool> func_0;

        internal bool method_0(SystemBodyData gclass1_1)
        {
            return gclass1_1.ParentBodyData == this.gclass1_0.ParentBodyData && gclass1_1 != this.gclass1_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class302
    {
        public Star197 gclass197_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.StarData == this.gclass197_0 && gclass1_0.BodyTypeId == AuroraSystemBodyType.Comet;
        }
    }

    [CompilerGenerated]
    private sealed class Class303
    {
        public Decimal decimal_0;
    }

    [CompilerGenerated]
    private sealed class Class304
    {
        public GClass132 gclass132_0;
        public GClass0.Class303 class303_0;

        internal bool method_0(GClass65 gclass65_0)
        {
            return gclass65_0.int_1 == this.gclass132_0.gclass40_1.int_8 &&
                   gclass65_0.auroraContactType_0 == AuroraContactType.Ship &&
                   gclass65_0.gclass21_1 == this.gclass132_0.gclass21_0 &&
                   gclass65_0.decimal_3 == this.class303_0.decimal_0;
        }

        internal bool method_1(GClass65 gclass65_0)
        {
            return gclass65_0.gclass21_1 == this.gclass132_0.gclass21_0 &&
                   gclass65_0.decimal_3 == this.class303_0.decimal_0;
        }

        internal bool method_2(GClass65 gclass65_0)
        {
            return gclass65_0.int_1 == this.gclass132_0.gclass132_0.int_1 &&
                   gclass65_0.auroraContactType_0 == AuroraContactType.Salvo &&
                   gclass65_0.gclass21_1 == this.gclass132_0.gclass21_0 && gclass65_0.genum10_0 == GEnum10.const_0 &&
                   gclass65_0.decimal_3 == this.class303_0.decimal_0;
        }

        internal bool method_3(GClass65 gclass65_0)
        {
            return gclass65_0.int_1 == this.gclass132_0.gclass146_0.PopulationID &&
                   gclass65_0.auroraContactType_0 == AuroraContactType.Population &&
                   gclass65_0.gclass21_1 == this.gclass132_0.gclass21_0 &&
                   (gclass65_0.genum10_0 == GEnum10.const_1 || gclass65_0.genum10_0 == GEnum10.const_3) &&
                   gclass65_0.decimal_3 == this.class303_0.decimal_0;
        }

        internal bool method_4(GClass65 gclass65_0)
        {
            return gclass65_0.int_1 == this.gclass132_0.gclass146_0.PopulationID &&
                   gclass65_0.auroraContactType_0 == this.gclass132_0.auroraContactType_0 &&
                   gclass65_0.gclass21_1 == this.gclass132_0.gclass21_0 && gclass65_0.genum10_0 == GEnum10.const_0 &&
                   gclass65_0.decimal_3 == this.class303_0.decimal_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class305
    {
        public FCTShipData40 gclass40_0;

        internal bool method_0(GClass132 gclass132_0)
        {
            return gclass132_0.gclass40_1 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class306
    {
        public FCTDecoyAssignmentData32 gclass32_0;

        internal bool method_0(MissileAssignment gclass30_0)
        {
            return gclass30_0.FiringWeaponComponent == this.gclass32_0.LauncherData &&
                   gclass30_0.WeaponNum == this.gclass32_0.LauncherNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class307
    {
        public GClass132 gclass132_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass132_0.gclass200_0 &&
                   gclass1_0.XCoordinate == this.gclass132_0.double_0 &&
                   gclass1_0.YCoordinate == this.gclass132_0.double_1;
        }

        internal bool method_1(GClass132 gclass132_1)
        {
            return gclass132_1.gclass40_1 == this.gclass132_0.gclass40_1 && gclass132_1.gclass129_0.int_14 == 1;
        }

        internal bool method_2(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass132_0.gclass200_0 &&
                   gclass1_0.XCoordinate == this.gclass132_0.double_0 &&
                   gclass1_0.YCoordinate == this.gclass132_0.double_1;
        }
    }
}