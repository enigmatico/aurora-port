using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aurora;
#nullable disable
public partial class GClass6
{
    #region CompilerGenerated

    [CompilerGenerated]
    private sealed class Class480
    {
        public List<PopulationData> list_0;
        public GClass6 gclass6_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return this.list_0.Contains(gclass103_0.PopulationData);
        }
    }

    [CompilerGenerated]
    private sealed class Class481
    {
        public GroundUnitFormationElement gclass39_0;

        internal bool method_0(GClass114 gclass114_0)
        {
            return gclass114_0.gclass101_0 == this.gclass39_0.GroundUnitClass;
        }
    }

    [CompilerGenerated]
    private sealed class Class482
    {
        public GroundUnitFormationData gclass103_0;
        public GClass6.Class480 class480_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return this.class480_0.gclass6_0.gclass0_0.AutoGroundTemplateDesignsDictionary[gclass103_1.OriginalTemplateData.AutomatedTemplateType].PrimaryFunction ==
                GUAutoTemplatePrimaryFunction.const_2 && gclass103_1 != this.gclass103_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class483
    {
        public PopulationData gclass146_0;

        internal bool method_0(GClass16 gclass16_0)
        {
            return gclass16_0.genum97_0 == this.gclass146_0.gclass6_0.genum97_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class484
    {
        public GClass18 gclass18_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.OriginalTemplateData.AutomatedTemplateType == this.gclass18_0.genum116_0;
        }

        internal bool method_1(GClass106 gclass106_0)
        {
            return gclass106_0.gclass102_0.AutomatedTemplateType == this.gclass18_0.genum116_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class485
    {
        public GClass18 gclass18_0;
        public GClass6 gclass6_0;
        public Func<GroundUnitFormationTemplateData, bool> func_0;

        internal bool method_0(GroundUnitFormationTemplateData gclass102_0)
        {
            return gclass102_0.RaceData == this.gclass6_0.gclass146_0.Race &&
                   gclass102_0.AutomatedTemplateType == this.gclass18_0.genum116_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class486
    {
        public GClass18 gclass18_0;
        public GClass6 gclass6_0;

        internal bool method_0(GroundUnitFormationTemplateData gclass102_0)
        {
            return gclass102_0.RaceData == this.gclass6_0.gclass146_0.Race &&
                   gclass102_0.AutomatedTemplateType == this.gclass18_0.genum116_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class487
    {
        public Species gclass194_0;

        internal bool method_0(SystemBodyAtmosphericGas gclass224_0)
        {
            return gclass224_0.Gas.Dangerous > 0 && gclass224_0.Gas != this.gclass194_0.gclass223_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class488
    {
        public List<ShipData> list_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return !this.list_0.Contains(gclass40_0) && gclass40_0.gclass85_0.MoveOrderDictionary.Count == 0;
        }
    }

    [CompilerGenerated]
    private sealed class Class489
    {
        public List<ShipData> list_0;
        public PopulationData gclass146_0;
        public GClass193 gclass193_0;

        internal bool method_0(ShipData gclass40_0)
        {
            if (!(gclass40_0.gclass22_0.Size <= this.gclass193_0.decimal_0))
                return false;
            if (gclass40_0.gclass22_0.Commercial && this.gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Commercial)
                return true;
            return !gclass40_0.gclass22_0.Commercial && this.gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Naval;
        }
    }

    [CompilerGenerated]
    private sealed class Class490
    {
        public double double_0;
        public double double_1;
        public GClass6.Class489 class489_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return !this.class489_0.list_0.Contains(gclass40_0) &&
                   gclass40_0.gclass85_0.System == this.class489_0.gclass146_0.gclass202_0 &&
                   gclass40_0.gclass85_0.XCoord == this.double_0 && gclass40_0.gclass85_0.YCoord == this.double_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class491
    {
        public ShipClass gclass22_0;
        public GClass6 gclass6_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0.AutomatedClassDesign != null && gclass40_0.gclass21_0 == this.gclass22_0.Race;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID == this.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID;
        }

        internal bool method_2(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass6_0.gclass146_0.Race;
        }

        internal bool method_3(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID == this.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID;
        }
    }

    [CompilerGenerated]
    private sealed class Class492
    {
        public RaceMissile gclass129_0;

        internal bool method_0(PopOrdnanceStock gclass130_0)
        {
            return gclass130_0.RaceMissile == this.gclass129_0;
        }

        internal bool method_1(PopOrdnanceStock gclass130_0)
        {
            return gclass130_0.RaceMissile == this.gclass129_0;
        }

        internal bool method_2(PopOrdnanceStock gclass130_0)
        {
            return gclass130_0.RaceMissile == this.gclass129_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class493
    {
        public ShipClass gclass22_0;

        internal bool method_0(GClass74 gclass74_0)
        {
            return gclass74_0.gclass22_0 == this.gclass22_0;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0 == this.gclass22_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class494
    {
        public PlanetaryInstallationType gclass157_0;

        internal bool method_0(PopInstallationDemand gclass148_0)
        {
            return gclass148_0.InstallationType == this.gclass157_0;
        }

        internal bool method_1(PopInstallationDemand gclass148_0)
        {
            return gclass148_0.InstallationType == this.gclass157_0;
        }
    }

    #endregion
}