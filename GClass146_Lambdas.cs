using Aurora;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable disable
public partial class PopulationData
{
    [CompilerGenerated]
    private sealed class Class1088
    {
        public GClass106 gclass106_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.OrgLinkID == this.gclass106_0.int_2;
        }
    }

    [CompilerGenerated]
    private sealed class Class1089
    {
        public PopulationData gclass146_0;
        public GClass192 gclass192_0;

        internal bool method_0(GClass192 gclass192_1)
        {
            return gclass192_1.gclass146_0 == this.gclass146_0 && gclass192_1.gclass40_0 != null;
        }
    }

    [CompilerGenerated]
    private sealed class Class1090
    {
        public List<ShipData> list_0;
        public PopulationData.Class1089 class1089_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0 == this.class1089_0.gclass192_0.gclass22_0 &&
                   gclass40_0.gclass85_0.XCoord == this.class1089_0.gclass146_0.method_87() &&
                   gclass40_0.gclass85_0.YCoord == this.class1089_0.gclass146_0.method_88() &&
                   gclass40_0.gclass85_0.System == this.class1089_0.gclass146_0.gclass202_0 &&
                   !this.list_0.Contains(gclass40_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class1091
    {
        public IndustrialProjects gclass156_0;

        internal bool method_0(IndustrialProjects gclass156_1)
        {
            return gclass156_1.Queue > 0 &&
                   gclass156_1.ProductionCategory == this.gclass156_0.ProductionCategory;
        }

        internal bool method_1(IndustrialProjects gclass156_1)
        {
            return gclass156_1.ProductionCategory == this.gclass156_0.ProductionCategory &&
                   gclass156_1.Queue == 0;
        }

        internal bool method_2(IndustrialProjects gclass156_1)
        {
            return gclass156_1.Queue > 0 &&
                   gclass156_1.ProductionCategory == this.gclass156_0.ProductionCategory;
        }
    }

    [CompilerGenerated]
    private sealed class Class1092
    {
        public OperationalGroupID genum105_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.OperationalGroupId == this.genum105_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1093
    {
        public PopulationData gclass146_0;

        internal bool method_0(PopulationData gclass146_1)
        {
            return gclass146_1 == this.gclass146_0;
        }

        internal bool method_1(PopulationData gclass146_1)
        {
            return gclass146_1 == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1094
    {
        public GClass228 gclass228_0;

        internal bool method_0(TransportedComponent gclass73_0)
        {
            return gclass73_0.Component == this.gclass228_0.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1095
    {
        public GClass228 gclass228_0;

        internal bool method_0(GClass228 gclass228_1)
        {
            return gclass228_1.int_0 == this.gclass228_0.int_0;
        }

        internal bool method_1(TransportedComponent gclass73_0)
        {
            return gclass73_0.Component == this.gclass228_0.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1096
    {
        public PopulationData gclass146_0;

        internal bool method_0(GClass193 gclass193_0)
        {
            return gclass193_0.gclass146_0 == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1097
    {
        public TechSystem gclass164_0;
        public PopulationData gclass146_0;

        internal bool method_0(TechSystem gclass164_1)
        {
            return gclass164_1.gclass163_0 == this.gclass164_0.gclass163_0 &&
                   !gclass164_1.dictionary_0.ContainsKey(this.gclass146_0.Race.RaceID) &&
                   gclass164_1.int_4 <= this.gclass164_0.int_4 && !gclass164_1.bool_4 && !gclass164_1.bool_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class1098
    {
        public TransportedComponent gclass73_0;

        internal bool method_0(TransportedComponent gclass73_1)
        {
            return gclass73_1.Component == this.gclass73_0.Component;
        }
    }

    [CompilerGenerated]
    private sealed class Class1099
    {
        public GroundUnitFormationElement gclass39_0;

        internal bool method_0(GroundUnitFormationElement gclass39_1)
        {
            return gclass39_1.GroundUnitClass == this.gclass39_0.GroundUnitClass &&
                   gclass39_1.Morale == this.gclass39_0.Morale;
        }
    }

    [CompilerGenerated]
    private sealed class Class1100
    {
        public PlanetaryInstallationType gclass157_0;

        internal bool method_0(PopInstallationDemand gclass148_0)
        {
            return gclass148_0.InstallationType == this.gclass157_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1101
    {
        public ShipComponent gclass230_0;

        internal bool method_0(TransportedComponent gclass73_0)
        {
            return gclass73_0.int_0 == this.gclass230_0.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1102
    {
        public ShipComponent gclass230_0;

        internal bool method_0(TransportedComponent gclass73_0)
        {
            return gclass73_0.int_0 == this.gclass230_0.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1103
    {
        public int int_0;

        internal bool method_0(TransportedComponent gclass73_0)
        {
            return gclass73_0.int_0 == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1104
    {
        public GameRace gclass21_0;
        public PopulationData gclass146_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.gclass21_0 &&
                   gclass65_0.LastUpdate == this.gclass146_0.gclass0_0.GameTime &&
                   gclass65_0.ContactType == AuroraContactType.Population &&
                   gclass65_0.ContactID == this.gclass146_0.PopulationID;
        }
    }

    [CompilerGenerated]
    private sealed class Class1105
    {
        public ResearchQueue gclass166_0;

        internal bool method_0(PausedResearch gclass167_0)
        {
            return gclass167_0.gclass164_0 == this.gclass166_0.TechSystem;
        }
    }

    [CompilerGenerated]
    private sealed class Class1106
    {
        public TechSystem gclass164_0;

        internal bool method_0(PausedResearch gclass167_0)
        {
            return gclass167_0.gclass164_0 == this.gclass164_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1107
    {
        public ResearchProject gclass161_0;

        internal bool method_0(ResearchQueue gclass166_0)
        {
            return gclass166_0.CurrentProject == this.gclass161_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1108
    {
        public ResearchQueue gclass166_0;

        internal bool method_0(ResearchQueue gclass166_1)
        {
            return gclass166_1.CurrentProject == this.gclass166_0.CurrentProject;
        }

        internal bool method_1(ResearchQueue gclass166_1)
        {
            return gclass166_1.CurrentProject == this.gclass166_0.CurrentProject;
        }
    }

    [CompilerGenerated]
    private sealed class Class1109
    {
        public PopulationData gclass146_0;
        public ResearchFieldData gclass162_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.gclass21_0 == this.gclass146_0.Race &&
                   gclass55_0.auroraCommanderType_0 == AuroraCommanderType.Scientist;
        }

        internal bool method_1(GClass55 gclass55_0)
        {
            return gclass55_0.gclass21_0 == this.gclass146_0.Race &&
                   gclass55_0.auroraCommanderType_0 == AuroraCommanderType.Scientist &&
                   gclass55_0.auroraCommandType_0 == AuroraCommandType.None;
        }

        internal bool method_2(GClass55 gclass55_0)
        {
            return gclass55_0.gclass162_0 == this.gclass162_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1110
    {
        public PopulationData gclass146_0;
        public ResearchFieldData gclass162_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.dictionary_0.ContainsKey(this.gclass146_0.Race.RaceID);
        }

        internal bool method_1(PopulationData gclass146_1)
        {
            return gclass146_1.Race == this.gclass146_0.Race;
        }
    }

    [CompilerGenerated]
    private sealed class Class1111
    {
        public List<TechSystem> list_0;
        public List<TechSystem> list_1;
        public List<TechSystem> list_2;
        public PopulationData.Class1110 class1110_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.gclass163_0.ResearchField == this.class1110_0.gclass162_0 && !gclass164_0.bool_1 &&
                   (gclass164_0.int_1 == 0 || gclass164_0.int_1 == this.class1110_0.gclass146_0.Race.RaceID ||
                    this.class1110_0.gclass146_0.Race.list_18.Contains(gclass164_0)) &&
                   (gclass164_0.int_2 == 0 || this.list_0.Contains(gclass164_0.gclass164_0)) &&
                   (gclass164_0.int_3 == 0 || this.list_0.Contains(gclass164_0.gclass164_1)) &&
                   !this.list_0.Contains(gclass164_0) && !this.list_1.Contains(gclass164_0) &&
                   !this.list_2.Contains(gclass164_0);
        }

        internal bool method_1(TechSystem gclass164_0)
        {
            return gclass164_0.dictionary_0.ContainsKey(this.class1110_0.gclass146_0.Race.RaceID) &&
                   !this.list_1.Contains(gclass164_0) && !this.list_2.Contains(gclass164_0) &&
                   gclass164_0.gclass163_0.ResearchField == this.class1110_0.gclass162_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1112
    {
        public TechSystem gclass164_0;

        internal bool method_0(PausedResearch gclass167_0)
        {
            return gclass167_0.gclass164_0 == this.gclass164_0;
        }

        internal bool method_1(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass164_0 == this.gclass164_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1113
    {
        public PopulationData gclass146_0;
        public ResearchFieldData gclass162_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.dictionary_0.ContainsKey(this.gclass146_0.Race.RaceID) && !gclass164_0.bool_3 &&
                   gclass164_0.gclass163_0.ResearchField == this.gclass162_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1114
    {
        public PopulationData gclass146_0;
        public Decimal decimal_0;

        internal bool method_0(GClass151 gclass151_0)
        {
            return gclass151_0.gclass150_0.Income &&
                   gclass151_0.decimal_1 > this.gclass146_0.gclass0_0.GameTime - this.decimal_0;
        }

        internal bool method_1(GClass151 gclass151_0)
        {
            return !gclass151_0.gclass150_0.Income &&
                   gclass151_0.decimal_1 > this.gclass146_0.gclass0_0.GameTime - this.decimal_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1115
    {
        public WealthUsageData gclass150_0;
        public PopulationData.Class1114 class1114_0;

        internal bool method_0(GClass151 gclass151_0)
        {
            return gclass151_0.gclass150_0 == this.gclass150_0 && gclass151_0.decimal_1 >
                this.class1114_0.gclass146_0.gclass0_0.GameTime - this.class1114_0.decimal_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1116
    {
        public GameRace gclass21_0;
        public PopulationData gclass146_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass164_0.gclass21_0 == null;
        }

        internal bool method_1(TechSystem gclass164_0)
        {
            return gclass164_0.dictionary_0.ContainsKey(this.gclass146_0.Race.RaceID) &&
                   gclass164_0.gclass21_0 == null;
        }

        internal bool method_2(TechSystem gclass164_0)
        {
            return gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass164_0.gclass21_0 == null;
        }

        internal bool method_3(TechSystem gclass164_0)
        {
            return gclass164_0.dictionary_0.ContainsKey(this.gclass146_0.Race.RaceID) &&
                   gclass164_0.gclass21_0 == null;
        }

        internal bool method_4(PopulationData gclass146_1)
        {
            return gclass146_1.Race == this.gclass146_0.Race;
        }

        internal bool method_5(ResearchQueue gclass166_0)
        {
            return gclass166_0.Population == this.gclass146_0;
        }

        internal bool method_6(GClass62 gclass62_0)
        {
            return gclass62_0.gclass146_0 == this.gclass146_0;
        }

        internal bool method_7(NavalAdminCommand gclass83_0)
        {
            return gclass83_0.gclass146_0 == this.gclass146_0;
        }

        internal bool method_8(GClass113 gclass113_0)
        {
            return gclass113_0.gclass146_0 == this.gclass146_0;
        }

        internal bool method_9(Contact gclass65_0)
        {
            return gclass65_0.TargetPopulation == this.gclass146_0;
        }

        internal bool method_10(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass146_0.Race;
        }

        internal bool method_11(FleetData gclass85_0)
        {
            return gclass85_0.AssignedPopulation == this.gclass146_0;
        }

        internal bool method_12(GClass192 gclass192_0)
        {
            return gclass192_0.gclass146_0 == this.gclass146_0;
        }

        internal bool method_13(GClass193 gclass193_0)
        {
            return gclass193_0.gclass146_0 == this.gclass146_0;
        }

        internal bool method_14(GClass55 gclass55_0)
        {
            return gclass55_0.gclass146_0 == this.gclass146_0 || gclass55_0.gclass146_1 == this.gclass146_0 ||
                   gclass55_0.gclass146_3 == this.gclass146_0;
        }

        internal bool method_15(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData == this.gclass146_0;
        }

        internal bool method_16(GClass147 gclass147_0)
        {
            return gclass147_0.gclass21_0 == this.gclass21_0;
        }

        internal bool method_17(GClass55 gclass55_0)
        {
            return gclass55_0.gclass146_0 == this.gclass146_0 && gclass55_0.gclass21_0 == this.gclass21_0;
        }

        internal bool method_18(ShipData gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass146_0.Race &&
                   gclass40_0.gclass85_0.System == this.gclass146_0.gclass202_0 &&
                   gclass40_0.gclass85_0.XCoord == this.gclass146_0.method_87() &&
                   gclass40_0.gclass85_0.YCoord == this.gclass146_0.method_88();
        }

        internal bool method_19(PopulationData gclass146_1)
        {
            return gclass146_1.Race == this.gclass146_0.Race;
        }

        internal bool method_20(MissileSalvo gclass132_0)
        {
            return (gclass132_0.auroraContactType_0 == AuroraContactType.Population ||
                    gclass132_0.auroraContactType_0 == AuroraContactType.GroundUnit ||
                    gclass132_0.auroraContactType_0 == AuroraContactType.Shipyard ||
                    gclass132_0.auroraContactType_0 == AuroraContactType.STOGroundUnit) &&
                   gclass132_0.int_0 == this.gclass146_0.PopulationID;
        }

        internal bool method_21(PopulationData gclass146_1)
        {
            return gclass146_1.Race == this.gclass146_0.Race;
        }

        internal bool method_22(ShipData gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass146_0.Race &&
                   gclass40_0.gclass85_0.System == this.gclass146_0.gclass202_0 &&
                   gclass40_0.gclass85_0.XCoord == this.gclass146_0.method_87() &&
                   gclass40_0.gclass85_0.YCoord == this.gclass146_0.method_88();
        }
    }

    [CompilerGenerated]
    private sealed class Class1117
    {
        public List<int> list_0;
        public PopulationData.Class1116 class1116_0;

        internal bool method_0(MoveOrder gclass139_0)
        {
            if (gclass139_0.Population == this.class1116_0.gclass146_0)
                return true;
            return gclass139_0.DestinationType == DestinationType.const_4 && this.list_0.Contains(gclass139_0.DestinationID);
        }
    }

    [CompilerGenerated]
    private sealed class Class1118
    {
        public List<TechSystem> list_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return !this.list_0.Contains(gclass164_0) && !gclass164_0.bool_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1119
    {
        public List<TechSystem> list_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return !this.list_0.Contains(gclass164_0) && !gclass164_0.bool_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1120
    {
        public GClass113 gclass113_0;
        public PopulationData.Class1117 class1117_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.TargetPopulation == this.class1117_0.class1116_0.gclass146_0 &&
                   gclass65_0.LastUpdate == this.class1117_0.class1116_0.gclass146_0.gclass0_0.GameTime &&
                   gclass65_0.DetectRace == this.gclass113_0.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1121
    {
        public GClass193 gclass193_0;
        public PopulationData gclass146_0;

        internal bool method_0(ShipClass gclass22_0)
        {
            return gclass22_0.gclass187_0 == null && gclass22_0.Obsolete == 0 &&
                   gclass22_0.Size <= this.gclass193_0.decimal_0 / 50M &&
                   gclass22_0 != this.gclass193_0.gclass22_0 && gclass22_0.Commercial &&
                   gclass22_0.Race == this.gclass146_0.Race;
        }

        internal bool method_1(ShipClass gclass22_0)
        {
            return gclass22_0.gclass187_0 == null && gclass22_0.Obsolete == 0 &&
                   gclass22_0.Size <= this.gclass193_0.decimal_0 / 50M &&
                   gclass22_0 != this.gclass193_0.gclass22_0 && gclass22_0.Race == this.gclass146_0.Race;
        }
    }

    [CompilerGenerated]
    private sealed class Class1122
    {
        public GClass193 gclass193_0;

        internal bool method_0(GClass192 gclass192_0)
        {
            return gclass192_0.gclass193_0 == this.gclass193_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1123
    {
        public AuroraProductionCategory auroraProductionCategory_0;

        internal bool method_0(IndustrialProjects gclass156_0)
        {
            return gclass156_0.ProductionCategory == this.auroraProductionCategory_0 && gclass156_0.Queue == 0;
        }

        internal bool method_1(IndustrialProjects gclass156_0)
        {
            return gclass156_0.ProductionCategory == this.auroraProductionCategory_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1124
    {
        public AuroraProductionCategory auroraProductionCategory_0;

        internal bool method_0(IndustrialProjects gclass156_0)
        {
            return gclass156_0.ProductionCategory == this.auroraProductionCategory_0 && gclass156_0.Queue > 0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1125
    {
        public AuroraProductionCategory auroraProductionCategory_0;

        internal bool method_0(IndustrialProjects gclass156_0)
        {
            return gclass156_0.ProductionCategory == this.auroraProductionCategory_0 && gclass156_0.Queue > 0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1126
    {
        public IndustrialProjects gclass156_0;

        internal bool method_0(IndustrialProjects gclass156_1)
        {
            return gclass156_1.ProductionCategory == this.gclass156_0.ProductionCategory &&
                   gclass156_1.Queue == 0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1127
    {
        public int int_0;
        public PopulationData.Class1126 class1126_0;

        internal bool method_0(IndustrialProjects gclass156_0)
        {
            return gclass156_0.ProductionCategory == this.class1126_0.gclass156_0.ProductionCategory &&
                   gclass156_0.Queue == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1128
    {
        public IndustrialProjects gclass156_0;
        public int int_0;

        internal bool method_0(IndustrialProjects gclass156_1)
        {
            return gclass156_1.ProductionCategory == this.gclass156_0.ProductionCategory &&
                   gclass156_1.Queue == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1129
    {
        public IndustrialProjects gclass156_0;

        internal bool method_0(IndustrialProjects gclass156_1)
        {
            return gclass156_1.ProductionCategory == this.gclass156_0.ProductionCategory &&
                   gclass156_1.Queue == 0 && gclass156_1 != this.gclass156_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1130
    {
        public PopOrdnanceStock gclass130_0;

        internal bool method_0(PopOrdnanceStock gclass130_1)
        {
            return gclass130_1.RaceMissile == this.gclass130_0.RaceMissile;
        }
    }

    [CompilerGenerated]
    private sealed class Class1131
    {
        public PopOrdnanceStock gclass130_0;

        internal bool method_0(PopOrdnanceStock gclass130_1)
        {
            return gclass130_1.RaceMissile == this.gclass130_0.RaceMissile;
        }
    }

    [CompilerGenerated]
    private sealed class Class1132
    {
        public RaceMissile gclass129_0;

        internal bool method_0(PopOrdnanceStock gclass130_0)
        {
            return gclass130_0.RaceMissile == this.gclass129_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1133
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
    private sealed class Class1134
    {
        public List<TechSystem> list_0;

        internal bool method_0(PlanetaryInstallationType gclass157_0)
        {
            if (gclass157_0.NoBuild)
                return false;
            return gclass157_0.TechData == null || this.list_0.Contains(gclass157_0.TechData);
        }

        internal bool method_1(PlanetaryInstallationType gclass157_0)
        {
            if (gclass157_0.NoBuild ||
                gclass157_0.ConversionFrom == AuroraInstallationType.ConventionalIndustry)
                return false;
            return gclass157_0.TechData == null || this.list_0.Contains(gclass157_0.TechData);
        }
    }

    [CompilerGenerated]
    private sealed class Class1135
    {
        public bool bool_0;
        public PopulationData gclass146_0;

        internal bool method_0(PopInstallationDemand gclass148_0)
        {
            return gclass148_0.Export == this.bool_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1136
    {
        public PopInstallationDemand gclass148_0;
        public PopulationData.Class1135 class1135_0;

        internal bool method_0(MoveOrder gclass139_0)
        {
            return gclass139_0.MoveActionType.MoveActionType == MoveActionType.UnloadInstallation &&
                   gclass139_0.Population == this.class1135_0.gclass146_0 &&
                   (AuroraInstallationType)gclass139_0.DestinationItemID == this.gclass148_0.InstallationType.InstallationType;
        }

        internal bool method_1(MoveOrder gclass139_0)
        {
            return gclass139_0.MoveActionType.MoveActionType == MoveActionType.LoadInstallation &&
                   gclass139_0.Population == this.class1135_0.gclass146_0 &&
                   (AuroraInstallationType)gclass139_0.DestinationItemID == this.gclass148_0.InstallationType.InstallationType;
        }
    }

    [CompilerGenerated]
    private sealed class Class1137
    {
        public PopulationData gclass146_0;
        public List<TechSystem> list_0;

        internal bool method_0(RaceMissile gclass129_0)
        {
            return gclass129_0.MissileID > 0 && this.list_0.Contains(gclass129_0.TechSystem) &&
                   gclass129_0.TechSystem.gclass21_0 == this.gclass146_0.Race;
        }
    }

    [CompilerGenerated]
    private sealed class Class1138
    {
        public List<TechSystem> list_0;

        internal bool method_0(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass231_0.ComponentTypeID != AuroraComponentType.Armour && !gclass230_0.bool_3 &&
                   gclass230_0.genum86_0 == GEnum86.const_0 &&
                   gclass230_0.gclass231_0.ComponentTypeID != AuroraComponentType.MissileEngine &&
                   this.list_0.Contains(gclass230_0.gclass164_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class1139
    {
        public GClass193 gclass193_0;

        internal bool method_0(GClass192 gclass192_0)
        {
            return gclass192_0.gclass193_0.int_0 == this.gclass193_0.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1140
    {
        public PopulationData gclass146_0;
        public GameRace gclass21_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData == this.gclass146_0;
        }

        internal bool method_1(GroundUnitFormationElement gclass39_0)
        {
            return gclass39_0.DetectingRaceList.Contains(this.gclass21_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class1141
    {
        public PopulationData gclass146_0;
        public AuroraClassMainFunction auroraClassMainFunction_0;
        public Func<ShipData, bool> func_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return this.gclass146_0.gclass0_0.method_520(gclass85_0.XCoord, this.gclass146_0.method_87(),
                       gclass85_0.YCoord, this.gclass146_0.method_88()) &&
                   gclass85_0.Race == this.gclass146_0.Race &&
                   gclass85_0.System == this.gclass146_0.gclass202_0;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0.MainFunction == this.auroraClassMainFunction_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1142
    {
        public PopulationData gclass146_0;
        public ShipClass gclass22_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return this.gclass146_0.gclass0_0.method_520(gclass40_0.gclass85_0.XCoord, this.gclass146_0.method_87(),
                       gclass40_0.gclass85_0.YCoord, this.gclass146_0.method_88()) &&
                   gclass40_0.gclass22_0 == this.gclass22_0 && gclass40_0.gclass187_0 == null;
        }

        internal bool method_1(GClass192 gclass192_0)
        {
            return gclass192_0.gclass146_0 == this.gclass146_0 && gclass192_0.gclass40_0 != null;
        }
    }

    [CompilerGenerated]
    private sealed class Class1143
    {
        public List<ShipData> list_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return !this.list_0.Contains(gclass40_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class1144
    {
        public ShipData gclass40_0;
        public PopulationData gclass146_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.gclass146_0.Race &&
                   gclass65_0.LastUpdate == this.gclass146_0.gclass0_0.GameTime &&
                   gclass65_0.ContactType == AuroraContactType.Ship &&
                   gclass65_0.ContactID == this.gclass40_0.int_8 && gclass65_0.ContactMethod == ContactDetectMethod.const_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1145
    {
        public PopulationData gclass146_0;
        public PopulationData gclass146_1;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.gclass146_1.Race &&
                   gclass65_0.LastUpdate == this.gclass146_1.gclass0_0.GameTime &&
                   gclass65_0.ContactType == AuroraContactType.Population &&
                   gclass65_0.ContactID == this.gclass146_0.PopulationID && gclass65_0.ContactMethod == ContactDetectMethod.const_1;
        }

        internal bool method_1(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.gclass146_1.Race &&
                   gclass65_0.LastUpdate == this.gclass146_1.gclass0_0.GameTime &&
                   gclass65_0.ContactType == AuroraContactType.Population &&
                   gclass65_0.ContactID == this.gclass146_0.PopulationID && gclass65_0.ContactMethod == ContactDetectMethod.const_3;
        }
    }

    [CompilerGenerated]
    private sealed class Class1146
    {
        public PopulationData gclass146_0;
        public ShipClass gclass22_0;

        internal bool method_0(GClass192 gclass192_0)
        {
            return gclass192_0.gclass21_0 == this.gclass146_0.Race && gclass192_0.gclass40_0 != null;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass146_0.Race;
        }

        internal bool method_2(ShipData gclass40_0)
        {
            if (!this.gclass146_0.gclass0_0.method_520(gclass40_0.gclass85_0.XCoord, this.gclass146_0.method_87(),
                    gclass40_0.gclass85_0.YCoord, this.gclass146_0.method_88()) ||
                gclass40_0.gclass22_0 != this.gclass22_0)
                return false;
            return gclass40_0.list_12.Count > 0 || gclass40_0.dictionary_5.Count > 0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1147
    {
        public PopulationData gclass146_0;
        public GClass193 gclass193_0;

        internal bool method_0(GClass192 gclass192_0)
        {
            return gclass192_0.gclass21_0 == this.gclass146_0.Race && gclass192_0.gclass40_0 != null;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass146_0.Race;
        }

        internal bool method_2(ShipData gclass40_0)
        {
            if (!this.gclass146_0.gclass0_0.method_520(gclass40_0.gclass85_0.XCoord, this.gclass146_0.method_87(),
                    gclass40_0.gclass85_0.YCoord, this.gclass146_0.method_88()))
                return false;
            return gclass40_0.list_12.Count > 0 || gclass40_0.dictionary_5.Count > 0;
        }

        internal bool method_3(ShipData gclass40_0)
        {
            if (!(gclass40_0.gclass22_0.Size <= this.gclass193_0.decimal_0 / 50M))
                return false;
            return this.gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Naval ||
                   this.gclass193_0.auroraShipyardType_0 == AuroraShipyardType.RepairYard ||
                   gclass40_0.gclass22_0.Commercial;
        }
    }

    [CompilerGenerated]
    private sealed class Class1148
    {
        public DIMDesignPhilosophyTechProgression gclass19_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.gclass162_0 == this.gclass19_0.ResearchField;
        }
    }

    [CompilerGenerated]
    private sealed class Class1149
    {
        public ResearchProject gclass161_0;
        public PopulationData gclass146_0;
        public Func<ResearchQueue, bool> func_0;

        internal bool method_0(ResearchQueue gclass166_0)
        {
            return gclass166_0.Population == this.gclass146_0 && gclass166_0.CurrentProject == this.gclass161_0;
        }

        internal bool method_1(ResearchQueue gclass166_0)
        {
            return gclass166_0.Population == this.gclass146_0 && gclass166_0.CurrentProject == this.gclass161_0;
        }
    }
}