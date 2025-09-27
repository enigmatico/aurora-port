using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aurora;

#nullable disable
public partial class GroundUnitDesign
{
    [CompilerGenerated]
    private sealed class Class1049
    {
        public GroundUnitSeriesData gclass94_0;

        internal bool method_0(GroundUnitSeriesClassData gclass95_0)
        {
            return gclass95_0.UnitSeriesData == this.gclass94_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1050
    {
        public GroundUnitFormationData gclass103_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.ReplacementTemplateData == this.gclass103_0.ReplacementTemplateData;
        }
    }

    [CompilerGenerated]
    private sealed class Class1051
    {
        public GroundUnitFormationData gclass103_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.ParentFormationData == this.gclass103_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1052
    {
        public OrganizationNodeC93 gclass93_0;

        internal bool method_0(OrganizationNodeC93 gclass93_1)
        {
            return gclass93_1.FormationTemplate == this.gclass93_0.FormationTemplate;
        }
    }

    [CompilerGenerated]
    private sealed class Class1053
    {
        public GroundUnitFormationData gclass103_0;

        internal bool method_0(MoveOrder gclass139_0)
        {
            return gclass139_0.MoveActionType.MoveActionType == MoveActionType.ProvideOrbitalBombardmentSupport && gclass139_0.bArrived &&
                   gclass139_0.Race == this.gclass103_0.RaceData;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.XCoord == this.gclass103_0.PopulationData.method_87() &&
                   gclass85_0.YCoord == this.gclass103_0.PopulationData.method_88() &&
                   gclass85_0.System.ActualSystemData == this.gclass103_0.PopulationData.gclass202_0.ActualSystemData;
        }

        internal bool method_2(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.AssignedFormationData == this.gclass103_0;
        }

        internal bool method_3(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass103_0 == this.gclass103_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1054
    {
        public GroundUnitClass101 gclass101_0;

        internal bool method_0(GroundUnitFormationElement gclass39_0)
        {
            return gclass39_0.GroundUnitClass == this.gclass101_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1055
    {
        public GroundUnitFormationData gclass103_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass103_0 == this.gclass103_0;
        }

        internal bool method_1(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass85_0.OrbitingBody == this.gclass103_0.PopulationData.SystemBodyData &&
                   gclass40_0.gclass21_0 == this.gclass103_0.RaceData &&
                   gclass40_0.gclass85_0.method_42(MoveActionType.ProvideGroundSupport);
        }

        internal bool method_2(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass103_0 == this.gclass103_0;
        }

        internal bool method_3(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass85_0.OrbitingBody == this.gclass103_0.PopulationData.SystemBodyData &&
                   gclass40_0.gclass21_0 == this.gclass103_0.RaceData &&
                   gclass40_0.gclass85_0.method_42(MoveActionType.ProvideOrbitalBombardmentSupport);
        }
    }

    [CompilerGenerated]
    private sealed class Class1056
    {
        public GroundUnitFormationElement gclass39_0;

        internal bool method_0(GroundUnitFormationElement gclass39_1)
        {
            return gclass39_1.GroundUnitClass == this.gclass39_0.GroundUnitClass;
        }
    }

    [CompilerGenerated]
    private sealed class Class1057
    {
        public PopulationData gclass146_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass146_0.RaceData && gclass103_0.OriginalTemplateData == null;
        }

        internal bool method_1(GroundUnitFormationTemplateData gclass102_0)
        {
            return gclass102_0.RaceData == this.gclass146_0.RaceData;
        }
    }

    [CompilerGenerated]
    private sealed class Class1058
    {
        public string string_0;

        internal bool method_0(
            KeyValuePair<AuroraTargetSelection, string> keyValuePair_0)
        {
            return keyValuePair_0.Value == this.string_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1059
    {
        public GroundUnitFormationData gclass103_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.ParentFormationData == this.gclass103_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1060
    {
        public GroundUnitFormationData gclass103_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.gclass103_0 == this.gclass103_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1061
    {
        public List<GroundUnitFormationData> list_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return this.list_0.Contains(gclass55_0.gclass103_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class1062
    {
        public PopulationData gclass146_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1063
    {
        public GroundUnitFormationData gclass103_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass103_0 == this.gclass103_0;
        }

        internal bool method_1(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass85_0.OrbitingBody == this.gclass103_0.PopulationData.SystemBodyData &&
                   gclass40_0.gclass21_0 == this.gclass103_0.RaceData &&
                   gclass40_0.gclass85_0.method_42(MoveActionType.ProvideGroundSupport);
        }

        internal bool method_2(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass103_0 == this.gclass103_0;
        }

        internal bool method_3(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass85_0.OrbitingBody == this.gclass103_0.PopulationData.SystemBodyData &&
                   gclass40_0.gclass21_0 == this.gclass103_0.RaceData &&
                   gclass40_0.gclass85_0.method_42(MoveActionType.ProvideOrbitalBombardmentSupport);
        }
    }

    [CompilerGenerated]
    private sealed class Class1064
    {
        public GroundUnitSeriesData gclass94_0;

        internal bool method_0(GroundUnitSeriesClassData gclass95_0)
        {
            return gclass95_0.UnitSeriesData == this.gclass94_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1065
    {
        public GroundUnitSeriesData gclass94_0;
        public int int_0;

        internal bool method_0(GroundUnitSeriesClassData gclass95_0)
        {
            return gclass95_0.UnitSeriesData == this.gclass94_0 && gclass95_0.Priority >= this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1066
    {
        public GroundUnitSeriesData gclass94_0;

        internal bool method_0(GroundUnitSeriesClassData gclass95_0)
        {
            return gclass95_0.UnitSeriesData == this.gclass94_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1067
    {
        public GroundUnitSeriesData gclass94_0;

        internal bool method_0(GroundUnitSeriesClassData gclass95_0)
        {
            return gclass95_0.UnitSeriesData == this.gclass94_0;
        }
    }
}