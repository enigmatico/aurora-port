using Aurora;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable disable
public partial class ShipData
{
    private sealed class staticCompGen
    {
        public static Func<GClass228, int> staticCompMem__2_1;
        public static Func<KeyValuePair<int, int>, int> staticCompMem__41_1;
    }

    [CompilerGenerated]
    private sealed class Class801
    {
        public ShipComponent gclass230_0;

        internal bool method_0(GClass178 gclass178_0)
        {
            return gclass178_0.gclass230_0 == this.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class802
    {
        public ShipData gclass40_0;
        public int int_0;

        internal bool method_0(GClass193 gclass193_0)
        {
            return gclass193_0.gclass146_0 == this.gclass40_0.gclass0_0.Populations[this.int_0];
        }

        internal bool method_1(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData == this.gclass40_0.gclass0_0.Populations[this.int_0];
        }

        internal bool method_2(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData == this.gclass40_0.gclass0_0.Populations[this.int_0];
        }

        internal bool method_3(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData == this.gclass40_0.gclass0_0.Populations[this.int_0];
        }
    }

    [CompilerGenerated]
    private sealed class Class803
    {
        public ShipData gclass40_0;
        public GameRace gclass21_0;
        public GClass37 gclass37_0;
        public Func<GClass117, bool> func_0;
        public Func<GClass117, bool> func_1;
        public Func<GClass113, bool> func_2;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.TargetShip == this.gclass40_0 && gclass65_0.DetectRace != this.gclass21_0 &&
                   gclass65_0.LastUpdate == this.gclass40_0.gclass0_0.GameTime;
        }

        internal bool method_1(Contact gclass65_0)
        {
            return gclass65_0.TargetShip == this.gclass37_0.gclass40_0 && gclass65_0.DetectRace != this.gclass21_0 &&
                   gclass65_0.LastUpdate == this.gclass40_0.gclass0_0.GameTime &&
                   gclass65_0.ContactMethod == ContactDetectMethod.const_0;
        }

        internal bool method_2(Contact gclass65_0)
        {
            return gclass65_0.TargetPopulation == this.gclass37_0.gclass39_0.Formation.PopulationData &&
                   gclass65_0.DetectRace != this.gclass21_0 &&
                   gclass65_0.LastUpdate == this.gclass40_0.gclass0_0.GameTime &&
                   gclass65_0.ContactMethod == ContactDetectMethod.const_0 &&
                   gclass65_0.ContactType == AuroraContactType.STOGroundUnit;
        }

        internal bool method_3(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0 == this.gclass40_0;
        }

        internal bool method_4(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0 == this.gclass37_0.gclass40_0;
        }

        internal bool method_5(GClass113 gclass113_0)
        {
            return gclass113_0.gclass146_0 == this.gclass37_0.gclass39_0.Formation.PopulationData;
        }
    }

    [CompilerGenerated]
    private sealed class Class804
    {
        public WeaponComponentRechargeStatus gclass27_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.WeaponComponent == this.gclass27_0.WeaponComponent && gclass31_0.WeaponNum == this.gclass27_0.WeaponNumber;
        }
    }

    [CompilerGenerated]
    private sealed class Class805
    {
        public WeaponComponentRechargeStatus gclass27_0;

        internal bool method_0(FCTDecoyAssignmentData32 gclass32_0)
        {
            return gclass32_0.LauncherData == this.gclass27_0.WeaponComponent &&
                   gclass32_0.LauncherNum == this.gclass27_0.WeaponNumber;
        }
    }

    [CompilerGenerated]
    private sealed class Class806
    {
        public ShipComponent gclass230_0;

        internal bool method_0(TransportedComponent gclass73_0)
        {
            return gclass73_0.Component == this.gclass230_0;
        }

        internal bool method_1(TransportedComponent gclass73_0)
        {
            return gclass73_0.Component != this.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class807
    {
        public GClass228 gclass228_0;

        internal bool method_0(GClass178 gclass178_0)
        {
            return gclass178_0.gclass230_0 == this.gclass228_0.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class808
    {
        public FCTSquadronData70 gclass70_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.SquadronData == this.gclass70_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class809
    {
        public AuroraMeasurementType auroraMeasurementType_0;

        internal bool method_0(GClass54 gclass54_0)
        {
            return gclass54_0.auroraMeasurementType_0 == this.auroraMeasurementType_0 && !gclass54_0.bool_0;
        }

        internal bool method_1(GClass54 gclass54_0)
        {
            return gclass54_0.auroraMeasurementType_0 == this.auroraMeasurementType_0 && gclass54_0.bool_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class810
    {
        public AuroraComponentType auroraComponentType_0;

        internal bool method_0(FireControlAssignment gclass36_0)
        {
            return gclass36_0.FCComponent.gclass231_0.ComponentTypeID == this.auroraComponentType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class811
    {
        public FireControlAssignment gclass36_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class812
    {
        public int int_0;

        internal bool method_0(GroundUnitFormationElement gclass39_0)
        {
            return this.int_0 >= gclass39_0.long_0 && this.int_0 <= gclass39_0.long_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class813
    {
        public int int_0;

        internal bool method_0(GroundUnitFormationElement gclass39_0)
        {
            return this.int_0 >= gclass39_0.long_0 && this.int_0 <= gclass39_0.long_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class814
    {
        public RaceMissile gclass129_0;

        internal bool method_0(PopOrdnanceStock gclass130_0)
        {
            return gclass130_0.RaceMissile == this.gclass129_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class815
    {
        public PopOrdnanceStock gclass130_0;

        internal bool method_0(PopOrdnanceStock gclass130_1)
        {
            return gclass130_1 == this.gclass130_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class816
    {
        public WeaponFireControlAssignment gclass31_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_1)
        {
            return gclass31_1.WeaponComponent == this.gclass31_0.WeaponComponent &&
                   gclass31_1.FireControlComponent == this.gclass31_0.FireControlComponent && gclass31_1.FireControlNum == this.gclass31_0.FireControlNum;
        }

        internal bool method_1(WeaponFireControlAssignment gclass31_1)
        {
            return gclass31_1.WeaponComponent == this.gclass31_0.WeaponComponent &&
                   gclass31_1.FireControlComponent == this.gclass31_0.FireControlComponent && gclass31_1.FireControlNum == this.gclass31_0.FireControlNum &&
                   gclass31_1.WeaponNum >= this.gclass31_0.WeaponNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class817
    {
        public ShipData gclass40_0;
        public ShipData gclass40_1;

        internal bool method_0(FireControlAssignment gclass36_0)
        {
            return gclass36_0.TargetContactType == AuroraContactType.Ship &&
                   gclass36_0.TargetID == this.gclass40_0.int_8 &&
                   gclass36_0.FCComponent.gclass231_0.ComponentTypeID == AuroraComponentType.BeamFireControl;
        }

        internal IEnumerable<WeaponFireControlAssignment> method_1(FireControlAssignment gclass36_0)
        {
            return this.gclass40_1.method_79(gclass36_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class818
    {
        public ShipData gclass40_0;
        public ShipData gclass40_1;

        internal bool method_0(FireControlAssignment gclass36_0)
        {
            return gclass36_0.TargetContactType == AuroraContactType.Ship &&
                   gclass36_0.TargetID == this.gclass40_0.int_8 &&
                   gclass36_0.FCComponent.gclass231_0.ComponentTypeID == AuroraComponentType.MissileFireControl;
        }

        internal IEnumerable<WeaponFireControlAssignment> method_1(FireControlAssignment gclass36_0)
        {
            return this.gclass40_1.method_79(gclass36_0);
        }

        internal MissileAssignment method_2(WeaponFireControlAssignment gclass31_0)
        {
            return this.gclass40_1.method_80(gclass31_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class819
    {
        public PopulationData gclass146_0;
        public ShipData gclass40_0;

        internal bool method_0(FireControlAssignment gclass36_0)
        {
            return (gclass36_0.TargetContactType == AuroraContactType.Population ||
                    gclass36_0.TargetContactType == AuroraContactType.STOGroundUnit ||
                    gclass36_0.TargetContactType == AuroraContactType.GroundUnit ||
                    gclass36_0.TargetContactType == AuroraContactType.Shipyard) &&
                   gclass36_0.TargetID == this.gclass146_0.PopulationID &&
                   gclass36_0.FCComponent.gclass231_0.ComponentTypeID ==
                   AuroraComponentType.MissileFireControl;
        }

        internal IEnumerable<WeaponFireControlAssignment> method_1(FireControlAssignment gclass36_0)
        {
            return this.gclass40_0.method_79(gclass36_0);
        }

        internal MissileAssignment method_2(WeaponFireControlAssignment gclass31_0)
        {
            return this.gclass40_0.method_80(gclass31_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class820
    {
        public FireControlAssignment gclass36_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class821
    {
        public WeaponFireControlAssignment gclass31_0;

        internal bool method_0(MissileAssignment gclass30_0)
        {
            return gclass30_0.FiringWeaponComponent == this.gclass31_0.WeaponComponent && gclass30_0.WeaponNum == this.gclass31_0.WeaponNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class822
    {
        public ShipComponent gclass230_0;

        internal bool method_0(GClass178 gclass178_0)
        {
            return gclass178_0.gclass230_0 == this.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class823
    {
        public int int_0;

        internal bool method_0(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.BeamFireControl &&
                   gclass228_0.gclass230_0.int_3 >= this.int_0 * 3;
        }

        internal bool method_1(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.BeamFireControl &&
                   gclass228_0.gclass230_0.int_3 < this.int_0 * 3;
        }
    }

    [CompilerGenerated]
    private sealed class Class824
    {
        public GClass228 gclass228_0;
        public int int_0;
        public Func<WeaponFireControlAssignment, bool> func_0;
        public Func<WeaponFireControlAssignment, bool> func_1;
        public Func<FireControlAssignment, bool> func_2;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass228_0.gclass230_0 && gclass31_0.FireControlNum == this.int_0;
        }

        internal bool method_1(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass228_0.gclass230_0 && gclass31_0.FireControlNum == this.int_0;
        }

        internal bool method_2(FireControlAssignment gclass36_0)
        {
            return gclass36_0.FCComponent == this.gclass228_0.gclass230_0 && gclass36_0.FCNum == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class825
    {
        public GClass228 gclass228_0;
        public Func<PopOrdnanceStock, bool> func_0;

        internal bool method_0(PopOrdnanceStock gclass130_0)
        {
            return gclass130_0.RaceMissile.Size <= this.gclass228_0.gclass230_0.decimal_3 &&
                   gclass130_0.RaceMissile.ShipDecoy == 1;
        }
    }

    [CompilerGenerated]
    private sealed class Class826
    {
        public GClass228 gclass228_0;
        public Func<PopOrdnanceStock, bool> func_0;

        internal bool method_0(PopOrdnanceStock gclass130_0)
        {
            return gclass130_0.RaceMissile.Size <= this.gclass228_0.gclass230_0.decimal_3;
        }
    }

    [CompilerGenerated]
    private sealed class Class827
    {
        public GClass228 gclass228_0;
        public int int_0;
        public Func<WeaponFireControlAssignment, bool> func_0;
        public Func<FireControlAssignment, bool> func_1;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass228_0.gclass230_0 && gclass31_0.FireControlNum == this.int_0;
        }

        internal bool method_1(FireControlAssignment gclass36_0)
        {
            return gclass36_0.FCComponent == this.gclass228_0.gclass230_0 && gclass36_0.FCNum == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class828
    {
        public ShipComponent gclass230_0;

        internal bool method_0(GClass28 gclass28_0)
        {
            return gclass28_0.gclass230_0 == this.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class829
    {
        public ShipData gclass40_0;
        public MissileAssignment gclass30_0;
        public FireControlAssignment gclass36_0;
        public int int_0;

        internal bool method_0(MissileSalvo gclass132_0)
        {
            return gclass132_0.Ship == this.gclass40_0 &&
                   gclass132_0.decimal_0 == this.gclass40_0.gclass0_0.GameTime &&
                   gclass132_0.RaceMissile == this.gclass30_0.Missile &&
                   gclass132_0.gclass230_0 == this.gclass36_0.FCComponent &&
                   gclass132_0.int_2 == this.gclass36_0.FCNum && gclass132_0.int_0 == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class830
    {
        public ShipData gclass40_0;
        public MissileAssignment gclass30_0;
        public int int_0;

        internal bool method_0(MissileSalvo gclass132_0)
        {
            return gclass132_0.Ship == this.gclass40_0 &&
                   gclass132_0.decimal_0 == this.gclass40_0.gclass0_0.GameTime &&
                   gclass132_0.RaceMissile == this.gclass30_0.Missile && gclass132_0.int_0 == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class831
    {
        public RaceMissile gclass129_0;

        internal bool method_0(PopOrdnanceStock gclass130_0)
        {
            return gclass130_0.RaceMissile == this.gclass129_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class832
    {
        public FireControlAssignment gclass36_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class833
    {
        public TechSystem gclass164_0;

        internal bool method_0(ShipTechData182 gclass182_0)
        {
            return gclass182_0.TechData == this.gclass164_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class834
    {
        public PopulationData gclass146_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.AssignedPopulation == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class835
    {
        public RaceMissile gclass129_0;

        internal bool method_0(PopOrdnanceStock gclass130_0)
        {
            return gclass130_0.RaceMissile == this.gclass129_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class836
    {
        public WeaponFireControlAssignment gclass31_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_1)
        {
            return gclass31_1.WeaponComponent == this.gclass31_0.WeaponComponent &&
                   gclass31_1.FireControlComponent == this.gclass31_0.FireControlComponent && gclass31_1.FireControlNum == this.gclass31_0.FireControlNum;
        }

        internal bool method_1(WeaponFireControlAssignment gclass31_1)
        {
            return gclass31_1.WeaponComponent == this.gclass31_0.WeaponComponent &&
                   gclass31_1.FireControlComponent == this.gclass31_0.FireControlComponent && gclass31_1.FireControlNum == this.gclass31_0.FireControlNum &&
                   gclass31_1.WeaponNum >= this.gclass31_0.WeaponNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class837
    {
        public int int_0;

        internal bool method_0(GClass228 gclass228_0)
        {
            return gclass228_0.int_2 >= this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class838
    {
        public int int_0;

        internal bool method_0(GClass228 gclass228_0)
        {
            return gclass228_0.int_3 >= this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class839
    {
        public Survivors gclass180_0;

        internal bool method_0(GClass147 gclass147_0)
        {
            return gclass147_0.gclass21_0 == this.gclass180_0.Race &&
                   gclass147_0.gclass194_0 == this.gclass180_0.Species;
        }
    }

    [CompilerGenerated]
    private sealed class Class840
    {
        public Survivors gclass180_0;

        internal bool method_0(Survivors gclass180_1)
        {
            return gclass180_1.Race == this.gclass180_0.Race &&
                   gclass180_1.Species == this.gclass180_0.Species;
        }
    }

    [CompilerGenerated]
    private sealed class Class841
    {
        public FCTDecoyAssignmentData32 gclass32_0;

        internal bool method_0(FCTDecoyAssignmentData32 gclass32_1)
        {
            return gclass32_1.LauncherData == this.gclass32_0.LauncherData;
        }

        internal bool method_1(FCTDecoyAssignmentData32 gclass32_1)
        {
            return gclass32_1.LauncherData == this.gclass32_0.LauncherData &&
                   gclass32_1.LauncherNum >= this.gclass32_0.LauncherNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class842
    {
        public WreckComponents gclass235_0;

        internal bool method_0(TransportedComponent gclass73_0)
        {
            return gclass73_0.int_0 == this.gclass235_0.Component.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class843
    {
        public ShipComponent gclass230_0;

        internal bool method_0(TransportedComponent gclass73_0)
        {
            return gclass73_0.int_0 == this.gclass230_0.int_0;
        }

        internal bool method_1(TransportedComponent gclass73_0)
        {
            return gclass73_0.int_0 == this.gclass230_0.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class844
    {
        public GEnum61 genum61_0;
    }

    [CompilerGenerated]
    private sealed class Class845
    {
        public GClass228 gclass228_0;
        public int int_0;
        public ShipData.Class844 class844_0;
        public Func<FireControlAssignment, bool> func_0;

        internal bool method_0(FireControlAssignment gclass36_0)
        {
            if (gclass36_0.FCComponent != this.gclass228_0.gclass230_0 || gclass36_0.FCNum != this.int_0)
                return false;
            return gclass36_0.TargetID != 0 || this.class844_0.genum61_0 == GEnum61.const_2;
        }
    }

    [CompilerGenerated]
    private sealed class Class846
    {
        public AuroraInstallationType auroraInstallationType_0;

        internal bool method_0(PopulationInstallation gclass158_0)
        {
            return gclass158_0.InstallationType.InstallationType == this.auroraInstallationType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class847
    {
        public AuroraInstallationType auroraInstallationType_0;

        internal bool method_0(PopulationInstallation gclass158_0)
        {
            return gclass158_0.InstallationType.InstallationType == this.auroraInstallationType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class848
    {
        public ShipComponent gclass230_0;

        internal bool method_0(TransportedComponent gclass73_0)
        {
            return gclass73_0.Component == this.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class849
    {
        public List<ShipData> list_0;
        public ShipData gclass40_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass40_0.gclass21_0 && this.list_0.Contains(gclass103_0.ShipData);
        }

        internal bool method_1(GClass117 gclass117_0)
        {
            return this.list_0.Contains(gclass117_0.gclass40_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class850
    {
        public int int_0;
        public ShipData.Class849 class849_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.int_38 >= this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class851
    {
        public GClass71 gclass71_0;
        public ShipData.Class850 class850_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return this.class850_0.class849_0.gclass40_0.gclass0_0.GetDistanceBetween(
                this.class850_0.class849_0.gclass40_0.gclass85_0.XCoord,
                this.class850_0.class849_0.gclass40_0.gclass85_0.YCoord, gclass40_0.gclass85_0.XCoord,
                gclass40_0.gclass85_0.YCoord) < this.gclass71_0.double_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class852
    {
        public double double_0;
        public ShipData.Class850 class850_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return this.class850_0.class849_0.gclass40_0.gclass0_0.GetDistanceBetween(
                this.class850_0.class849_0.gclass40_0.gclass85_0.XCoord,
                this.class850_0.class849_0.gclass40_0.gclass85_0.YCoord, gclass40_0.gclass85_0.XCoord,
                gclass40_0.gclass85_0.YCoord) <= this.double_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class853
    {
        public GClass35 gclass35_0;

        internal bool method_0(GClass35 gclass35_1)
        {
            return gclass35_1.gclass230_0 == this.gclass35_0.gclass230_0;
        }

        internal bool method_1(GClass35 gclass35_1)
        {
            return gclass35_1.gclass230_0 == this.gclass35_0.gclass230_0 && gclass35_1.int_0 >= this.gclass35_0.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class854
    {
        public AuroraComponentType auroraComponentType_0;

        internal bool method_0(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0.gclass231_0.ComponentTypeID == this.auroraComponentType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class855
    {
        public GClass228 gclass228_0;

        internal bool method_0(GClass178 gclass178_0)
        {
            return gclass178_0.gclass230_0 == this.gclass228_0.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class856
    {
        public ShipComponent gclass230_0;

        internal bool method_0(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0 == this.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class857
    {
        public GClass35 gclass35_0;

        internal bool method_0(GClass35 gclass35_1)
        {
            return gclass35_1.gclass230_0 == this.gclass35_0.gclass230_0;
        }

        internal bool method_1(GClass35 gclass35_1)
        {
            return gclass35_1.gclass230_0 == this.gclass35_0.gclass230_0 && gclass35_1.int_0 >= this.gclass35_0.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class858
    {
        public AuroraComponentType auroraComponentType_0;

        internal bool method_0(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0.gclass231_0.ComponentTypeID == this.auroraComponentType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class859
    {
        public AuroraComponentType auroraComponentType_0;

        internal bool method_0(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0.gclass231_0.ComponentTypeID == this.auroraComponentType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class860
    {
        public AuroraComponentType auroraComponentType_0;

        internal bool method_0(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0.gclass231_0.ComponentTypeID == this.auroraComponentType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class861
    {
        public WeaponFireControlAssignment gclass31_0;

        internal bool method_0(MissileAssignment gclass30_0)
        {
            return gclass30_0.FiringWeaponComponent == this.gclass31_0.WeaponComponent && gclass30_0.WeaponNum == this.gclass31_0.WeaponNum;
        }

        internal bool method_1(WeaponFireControlAssignment gclass31_1)
        {
            return gclass31_1.WeaponComponent == this.gclass31_0.WeaponComponent &&
                   gclass31_1.FireControlComponent == this.gclass31_0.FireControlComponent && gclass31_1.FireControlNum == this.gclass31_0.FireControlNum;
        }

        internal bool method_2(WeaponFireControlAssignment gclass31_1)
        {
            return gclass31_1.WeaponComponent == this.gclass31_0.WeaponComponent &&
                   gclass31_1.FireControlComponent == this.gclass31_0.FireControlComponent && gclass31_1.FireControlNum == this.gclass31_0.FireControlNum &&
                   gclass31_1.WeaponNum >= this.gclass31_0.WeaponNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class862
    {
        public WeaponFireControlAssignment gclass31_0;

        internal bool method_0(MissileAssignment gclass30_0)
        {
            return gclass30_0.FiringWeaponComponent == this.gclass31_0.WeaponComponent && gclass30_0.WeaponNum == this.gclass31_0.WeaponNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class863
    {
        public WeaponFireControlAssignment gclass31_0;

        internal bool method_0(MissileAssignment gclass30_0)
        {
            return gclass30_0.FiringWeaponComponent == this.gclass31_0.WeaponComponent && gclass30_0.WeaponNum == this.gclass31_0.WeaponNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class864
    {
        public FCTDecoyAssignmentData32 gclass32_0;

        internal bool method_0(MissileAssignment gclass30_0)
        {
            return gclass30_0.FiringWeaponComponent == this.gclass32_0.LauncherData &&
                   gclass30_0.WeaponNum == this.gclass32_0.LauncherNum;
        }

        internal bool method_1(FCTDecoyAssignmentData32 gclass32_1)
        {
            return gclass32_1.LauncherData == this.gclass32_0.LauncherData;
        }

        internal bool method_2(FCTDecoyAssignmentData32 gclass32_1)
        {
            return gclass32_1.LauncherData == this.gclass32_0.LauncherData &&
                   gclass32_1.LauncherNum >= this.gclass32_0.LauncherNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class865
    {
        public FCTDecoyAssignmentData32 gclass32_0;

        internal bool method_0(MissileAssignment gclass30_0)
        {
            return gclass30_0.FiringWeaponComponent == this.gclass32_0.LauncherData &&
                   gclass30_0.WeaponNum == this.gclass32_0.LauncherNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class866
    {
        public FCTDecoyAssignmentData32 gclass32_0;

        internal bool method_0(MissileAssignment gclass30_0)
        {
            return gclass30_0.FiringWeaponComponent == this.gclass32_0.LauncherData &&
                   gclass30_0.WeaponNum == this.gclass32_0.LauncherNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class867
    {
        public GClass228 gclass228_0;
        public int int_0;
        public Func<FireControlAssignment, bool> func_0;
        public Func<WeaponFireControlAssignment, bool> func_1;

        internal bool method_0(FireControlAssignment gclass36_0)
        {
            return gclass36_0.FCComponent == this.gclass228_0.gclass230_0 && gclass36_0.FCNum == this.int_0;
        }

        internal bool method_1(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass228_0.gclass230_0 && gclass31_0.FireControlNum == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class868
    {
        public WeaponFireControlAssignment gclass31_0;

        internal bool method_0(MissileAssignment gclass30_0)
        {
            return gclass30_0.FiringWeaponComponent == this.gclass31_0.WeaponComponent && gclass30_0.WeaponNum == this.gclass31_0.WeaponNum;
        }

        internal bool method_1(WeaponComponentRechargeStatus gclass27_0)
        {
            return gclass27_0.WeaponComponent == this.gclass31_0.WeaponComponent && gclass27_0.WeaponNumber == this.gclass31_0.WeaponNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class869
    {
        public FCTDecoyAssignmentData32 gclass32_0;

        internal bool method_0(MissileAssignment gclass30_0)
        {
            return gclass30_0.FiringWeaponComponent == this.gclass32_0.LauncherData &&
                   gclass30_0.WeaponNum == this.gclass32_0.LauncherNum;
        }

        internal bool method_1(WeaponComponentRechargeStatus gclass27_0)
        {
            return gclass27_0.WeaponComponent == this.gclass32_0.LauncherData &&
                   gclass27_0.WeaponNumber == this.gclass32_0.LauncherNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class870
    {
        public GClass228 gclass228_0;
        public int int_0;
        public Func<WeaponFireControlAssignment, bool> func_0;
        public Func<FCTDecoyAssignmentData32, bool> func_1;
        public Func<MissileAssignment, bool> func_2;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.WeaponComponent == this.gclass228_0.gclass230_0 && gclass31_0.WeaponNum == this.int_0;
        }

        internal bool method_1(FCTDecoyAssignmentData32 gclass32_0)
        {
            return gclass32_0.LauncherData == this.gclass228_0.gclass230_0 && gclass32_0.LauncherNum == this.int_0;
        }

        internal bool method_2(MissileAssignment gclass30_0)
        {
            return gclass30_0.FiringWeaponComponent == this.gclass228_0.gclass230_0 && gclass30_0.WeaponNum == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class871
    {
        public Contact gclass65_0;

        internal bool method_0(Contact gclass65_1)
        {
            return gclass65_1.ContactType == AuroraContactType.Population &&
                   gclass65_1.ContactID == this.gclass65_0.ContactID;
        }
    }

    [CompilerGenerated]
    private sealed class Class872
    {
        public AlienRaceInfo gclass110_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.gclass110_0 == this.gclass110_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class873
    {
        public GClass228 gclass228_0;

        internal bool method_0(GClass178 gclass178_0)
        {
            return gclass178_0.gclass230_0 == this.gclass228_0.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class874
    {
        public FireControlAssignment gclass36_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class875
    {
        public List<ShipComponent> list_0;

        internal bool method_0(GClass228 gclass228_0)
        {
            return this.list_0.Contains(gclass228_0.gclass230_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class876
    {
        public ShipComponent gclass230_0;
        public int int_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.WeaponComponent == this.gclass230_0 && gclass31_0.WeaponNum == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class877
    {
        public ShipComponent gclass230_0;

        internal bool method_0(GClass178 gclass178_0)
        {
            return gclass178_0.gclass230_0 == this.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class878
    {
        public int int_0;
        public ShipData.Class877 class877_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.WeaponComponent == this.class877_0.gclass230_0 && gclass31_0.WeaponNum > this.int_0;
        }

        internal bool method_1(WeaponComponentRechargeStatus gclass27_0)
        {
            return gclass27_0.WeaponComponent == this.class877_0.gclass230_0 && gclass27_0.WeaponNumber > this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class879
    {
        public Decimal decimal_0;
        public ShipData gclass40_0;

        internal bool method_0(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0.gclass231_0.ComponentTypeID ==
                AuroraComponentType.ActiveSearchSensors && gclass228_0.gclass230_0.decimal_6 == this.decimal_0;
        }

        internal bool method_1(GClass228 gclass228_0)
        {
            return this.gclass40_0.method_158(gclass228_0) > 0;
        }
    }

    [CompilerGenerated]
    private sealed class Class880
    {
        public FireControlAssignment gclass36_0;

        internal bool method_0(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0 == this.gclass36_0.FCComponent;
        }

        internal bool method_1(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class881
    {
        public List<ShipComponent> list_0;

        internal bool method_0(GClass228 gclass228_0)
        {
            return this.list_0.Contains(gclass228_0.gclass230_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class882
    {
        public ShipData gclass40_0;
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.ContactID == this.gclass40_0.int_8 && gclass65_0.DetectRace == this.gclass202_0.Race &&
                   gclass65_0.System == this.gclass202_0.ActualSystem;
        }
    }

    [CompilerGenerated]
    private sealed class Class883
    {
        public ShipData gclass40_0;
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.ContactID == this.gclass40_0.int_8 && gclass65_0.DetectRace == this.gclass202_0.Race &&
                   gclass65_0.System == this.gclass202_0.ActualSystem;
        }
    }

    [CompilerGenerated]
    private sealed class Class884
    {
        public ShipData gclass40_0;
        public Wreck gclass233_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return this.gclass40_0.gclass0_0.method_520(gclass1_0.XCoordinate, this.gclass233_0.Xcor,
                       gclass1_0.YCoordinate, this.gclass233_0.Ycor) &&
                   gclass1_0.SystemData == this.gclass233_0.System;
        }

        internal bool method_1(ShipData gclass40_1)
        {
            return gclass40_1.gclass85_0.System.ActualSystem == this.gclass233_0.System;
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0.ActualSystem == this.gclass233_0.System;
        }

        internal bool method_3(GameRace gclass21_0)
        {
            return gclass21_0 != this.gclass233_0.Race;
        }
    }

    [CompilerGenerated]
    private sealed class Class885
    {
        public GClass228 gclass228_0;

        internal bool method_0(GClass178 gclass178_0)
        {
            return gclass178_0.gclass230_0 == this.gclass228_0.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class886
    {
        public GClass228 gclass228_0;
        public ShipData gclass40_0;

        internal bool method_0(GClass178 gclass178_0)
        {
            return gclass178_0.gclass230_0 == this.gclass228_0.gclass230_0;
        }

        internal bool method_1(FireControlAssignment gclass36_0)
        {
            return gclass36_0.FCComponent == this.gclass228_0.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class887
    {
        public int int_0;
        public ShipData.Class886 class886_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.WeaponComponent == this.class886_0.gclass228_0.gclass230_0 && gclass31_0.WeaponNum > this.int_0;
        }

        internal bool method_1(FCTDecoyAssignmentData32 gclass32_0)
        {
            return gclass32_0.LauncherData == this.class886_0.gclass228_0.gclass230_0 &&
                   gclass32_0.LauncherNum > this.int_0;
        }

        internal bool method_2(WeaponComponentRechargeStatus gclass27_0)
        {
            return gclass27_0.WeaponComponent == this.class886_0.gclass228_0.gclass230_0 && gclass27_0.WeaponNumber > this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class888
    {
        public FireControlAssignment gclass36_0;
        public ShipData.Class887 class887_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.class887_0.class886_0.gclass228_0.gclass230_0 &&
                   gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }

        internal bool method_1(MissileSalvo gclass132_0)
        {
            return gclass132_0.Ship == this.class887_0.class886_0.gclass40_0 &&
                   gclass132_0.gclass230_0 == this.class887_0.class886_0.gclass228_0.gclass230_0 &&
                   gclass132_0.int_2 == this.gclass36_0.FCNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class889
    {
        public PopulationInstallation gclass158_0;

        internal bool method_0(PopInstallationDemand gclass148_0)
        {
            return gclass148_0.InstallationType == this.gclass158_0.InstallationType && !gclass148_0.Export;
        }
    }

    [CompilerGenerated]
    private sealed class Class890
    {
        public MoveOrder gclass139_0;

        internal bool method_0(PopInstallationDemand gclass148_0)
        {
            return gclass148_0.InstallationType.InstallationType == (AuroraInstallationType)this.gclass139_0.DestinationItemID &&
                   gclass148_0.Export;
        }
    }

    [CompilerGenerated]
    private sealed class Class891
    {
        public MoveOrder gclass139_0;

        internal bool method_0(PopInstallationDemand gclass148_0)
        {
            return gclass148_0.InstallationType.InstallationType == (AuroraInstallationType)this.gclass139_0.DestinationItemID &&
                   !gclass148_0.Export;
        }
    }
}