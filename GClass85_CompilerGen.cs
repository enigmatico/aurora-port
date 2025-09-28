using Aurora;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
public partial class FleetData
{
    [CompilerGenerated]
    private sealed class Class917
    {
        public ShipData gclass40_0;

        internal bool method_0(GClass115 gclass115_0)
        {
            return gclass115_0.gclass22_0 == this.gclass40_0.gclass22_0;
        }

        internal bool method_1(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class918
    {
        public ShipClass gclass22_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0 == this.gclass22_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class919
    {
        public FireControlAssignment gclass36_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class920
    {
        public WeaponFireControlAssignment gclass31_0;

        internal bool method_0(MissileAssignment gclass30_0)
        {
            return gclass30_0.FiringWeaponComponent == this.gclass31_0.WeaponComponent && gclass30_0.WeaponNum == this.gclass31_0.WeaponNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class921
    {
        public AuroraComponentType auroraComponentType_0;
        public FleetData gclass85_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.method_167(this.auroraComponentType_0) > 0 && gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class922
    {
        public int int_0;

        internal double method_0(ShipData gclass40_0)
        {
            return gclass40_0.method_75(this.int_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class923
    {
        public ShipData gclass40_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.ShipData == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class924
    {
        public MoveActionType genum123_0;

        internal bool method_0(MoveOrder gclass139_0)
        {
            return gclass139_0.MoveActionType.MoveActionType == this.genum123_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class925
    {
        public MoveOrder gclass139_0;
        public FleetData gclass85_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0.FleetID == this.gclass139_0.DestinationID;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.int_8 == this.gclass139_0.DestinationItemID;
        }

        internal bool method_2(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class926
    {
        public MoveOrder gclass139_0;
        public FleetData gclass85_0;

        internal bool method_0(GClass193 gclass193_0)
        {
            return gclass193_0.int_0 == this.gclass139_0.DestinationItemID;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class927
    {
        public MoveOrder gclass139_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.int_8 == this.gclass139_0.DestinationItemID;
        }
    }

    [CompilerGenerated]
    private sealed class Class928
    {
        public GClass59 gclass59_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.gclass59_0 == this.gclass59_0;
        }

        internal bool method_1(Survivors gclass180_0)
        {
            return gclass180_0.Race == this.gclass59_0.gclass21_0 &&
                   gclass180_0.Species == this.gclass59_0.gclass194_0;
        }

        internal bool method_2(GClass55 gclass55_0)
        {
            return gclass55_0.gclass59_0 == this.gclass59_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class929
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.System == this.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class930
    {
        public ShipData gclass40_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.ShipData == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class931
    {
        public SubFleet gclass84_0;

        internal bool method_0(SubFleet gclass84_1)
        {
            return gclass84_1.ParentSubFleet == this.gclass84_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class932
    {
        public int int_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0.FuelTanker == this.int_0;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0.Collier == this.int_0;
        }

        internal bool method_2(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0.SupplyShip == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class933
    {
        public TechSystem gclass164_0;
        public FleetData gclass85_0;

        internal bool method_0(TechSystem gclass164_1)
        {
            return gclass164_1.gclass163_0 == this.gclass164_0.gclass163_0 &&
                   !gclass164_1.dictionary_0.ContainsKey(this.gclass85_0.Race.RaceID) &&
                   gclass164_1.int_4 <= this.gclass164_0.int_4;
        }
    }

    [CompilerGenerated]
    private sealed class Class934
    {
        public MoveOrder gclass139_0;
        public FleetData gclass85_0;

        internal bool method_0(Wreck gclass233_0)
        {
            return gclass233_0.WreckID == this.gclass139_0.DestinationID;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0;
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass85_0.Race &&
                   gclass146_0.gclass202_0 == this.gclass85_0.System &&
                   gclass146_0.method_87() == this.gclass85_0.XCoord &&
                   gclass146_0.method_88() == this.gclass85_0.YCoord;
        }

        internal bool method_3(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class935
    {
        public Wreck gclass233_0;
        public ShipData gclass40_0;
        public FleetData.Class934 class934_0;

        internal bool method_0(GClass115 gclass115_0)
        {
            return gclass115_0.gclass22_0 == this.gclass233_0.ShipClass;
        }

        internal bool method_1(GClass115 gclass115_0)
        {
            return gclass115_0.gclass22_0 == this.gclass233_0.ShipClass;
        }

        internal bool method_2(ShipData gclass40_1)
        {
            return gclass40_1.gclass85_0.System.ActualSystem == this.gclass233_0.System;
        }

        internal bool method_3(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0.ActualSystem == this.gclass233_0.System;
        }

        internal bool method_4(GameRace gclass21_0)
        {
            return gclass21_0 != this.gclass40_0.gclass21_0;
        }

        internal bool method_5(GClass117 gclass117_0)
        {
            return gclass117_0.int_0 == this.gclass233_0.ShipID;
        }
    }

    [CompilerGenerated]
    private sealed class Class936
    {
        public WreckTech gclass234_0;
        public FleetData.Class935 class935_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.gclass163_0 == this.gclass234_0.TechData.gclass163_0 &&
                   !gclass164_0.dictionary_0.ContainsKey(this.class935_0.class934_0.gclass85_0.Race.RaceID) &&
                   gclass164_0.int_4 <= this.gclass234_0.TechData.int_4 && !gclass164_0.bool_4 &&
                   !gclass164_0.bool_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class937
    {
        public ShipData gclass40_0;

        internal bool method_0(ShipData gclass40_1)
        {
            return gclass40_1.gclass40_0 == this.gclass40_0;
        }

        internal bool method_1(GClass115 gclass115_0)
        {
            return gclass115_0.gclass22_0 == this.gclass40_0.gclass22_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class938
    {
        public PopulationData gclass146_0;

        internal bool method_0(GClass193 gclass193_0)
        {
            return gclass193_0.gclass146_0 == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class939
    {
        public MoveOrder gclass139_0;

        internal bool method_0(Wreck gclass233_0)
        {
            return gclass233_0.WreckID == this.gclass139_0.DestinationID;
        }
    }

    [CompilerGenerated]
    private sealed class Class940
    {
        public MoveOrder gclass139_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.int_8 == this.gclass139_0.DestinationItemID;
        }
    }

    [CompilerGenerated]
    private sealed class Class941
    {
        public MoveOrder gclass139_0;
        public Func<GroundUnitFormationData, bool> func_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.FormationID == this.gclass139_0.DestinationItemID;
        }
    }

    [CompilerGenerated]
    private sealed class Class942
    {
        public MoveOrder gclass139_0;
        public Func<GroundUnitFormationData, bool> func_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.FormationID == this.gclass139_0.DestinationItemID;
        }
    }

    [CompilerGenerated]
    private sealed class Class943
    {
        public ShipData gclass40_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.ShipData == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class944
    {
        public ShipComponent gclass230_0;

        internal bool method_0(TransportedComponent gclass73_0)
        {
            return gclass73_0.Component == this.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class945
    {
        public FleetData gclass85_0;
        public MoveOrder gclass139_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class946
    {
        public GClass75 gclass75_0;
        public FleetData.Class945 class945_0;
        public Func<GroundUnitFormationData, bool> func_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData == this.class945_0.gclass139_0.Population &&
                   gclass103_0.OriginalTemplateData == this.gclass75_0.gclass102_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class947
    {
        public FleetData gclass85_0;
        public AuroraInstallationType auroraInstallationType_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.TransportedInstallations.Count > 0 && gclass40_0.gclass85_0 == this.gclass85_0;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.TransportedInstallations.ContainsKey(this.auroraInstallationType_0) &&
                   gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class948
    {
        public FleetData gclass85_0;
        public AuroraInstallationType auroraInstallationType_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.TransportedInstallations.Count > 0 && gclass40_0.gclass85_0 == this.gclass85_0;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.TransportedInstallations.ContainsKey(this.auroraInstallationType_0) &&
                   gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class949
    {
        public int int_0;
        public FleetData gclass85_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.TransportedTradeGoods.ContainsKey(this.int_0) && gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class950
    {
        public ShipData gclass40_0;
        public List<ShipData> list_0;
        public FleetData gclass85_0;

        internal bool method_0(ShipData gclass40_1)
        {
            return gclass40_1.gclass85_0.XCoord == this.gclass40_0.gclass85_0.XCoord &&
                   gclass40_1.gclass85_0.YCoord == this.gclass40_0.gclass85_0.YCoord &&
                   gclass40_1.gclass21_0 == this.gclass40_0.gclass21_0 &&
                   gclass40_1.gclass85_0.Speed < this.gclass85_0.Speed;
        }

        internal bool method_1(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass85_0.Race && this.list_0.Contains(gclass103_0.ShipData);
        }
    }

    [CompilerGenerated]
    private sealed class Class951
    {
        public List<ShipData> list_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return this.list_0.Contains(gclass103_0.ShipData);
        }
    }

    [CompilerGenerated]
    private sealed class Class952
    {
        public ShipData gclass40_0;
        public bool bool_0;

        internal bool method_0(ShipData gclass40_1)
        {
            if (gclass40_1.gclass22_0.FuelTanker != 1 || gclass40_1.bool_18 || gclass40_1 == this.gclass40_0)
                return false;
            return !this.bool_0 || gclass40_1.gclass22_0.Size <= 20M;
        }

        internal bool method_1(ShipData gclass40_1)
        {
            if (gclass40_1.gclass22_0.FuelTanker != 0 || gclass40_1.bool_18)
                return false;
            return !this.bool_0 || gclass40_1.gclass22_0.Size <= 20M;
        }

        internal bool method_2(ShipData gclass40_1)
        {
            if (gclass40_1.gclass22_0.FuelTanker != 0 || gclass40_1.bool_18 ||
                gclass40_1.gclass84_0 != this.gclass40_0.gclass84_0)
                return false;
            return !this.bool_0 || gclass40_1.gclass22_0.Size <= 20M;
        }
    }

    [CompilerGenerated]
    private sealed class Class953
    {
        public ShipData gclass40_0;

        internal bool method_0(ShipData gclass40_1)
        {
            return gclass40_1.gclass40_0 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class954
    {
        public ShipData gclass40_0;

        internal bool method_0(ShipData gclass40_1)
        {
            return gclass40_1.gclass40_0 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class955
    {
        public ShipData gclass40_0;

        internal bool method_0(ShipData gclass40_1)
        {
            return gclass40_1.gclass22_0.SupplyShip == 0 && !gclass40_1.bool_19 &&
                   gclass40_1.gclass84_0 == this.gclass40_0.gclass84_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class956
    {
        public bool bool_0;

        internal bool method_0(ShipData gclass40_0)
        {
            if (gclass40_0.bool_18)
                return false;
            return !this.bool_0 || gclass40_0.gclass22_0.Size <= 20M;
        }
    }

    [CompilerGenerated]
    private sealed class Class957
    {
        public PopOrdnanceStock gclass130_0;

        internal bool method_0(PopOrdnanceStock gclass130_1)
        {
            return gclass130_1.RaceMissile == this.gclass130_0.RaceMissile;
        }
    }

    [CompilerGenerated]
    private sealed class Class958
    {
        public PopOrdnanceStock gclass130_0;

        internal bool method_0(PopOrdnanceStock gclass130_1)
        {
            return gclass130_1.RaceMissile == this.gclass130_0.RaceMissile;
        }

        internal bool method_1(PopOrdnanceStock gclass130_1)
        {
            return gclass130_1.RaceMissile == this.gclass130_0.RaceMissile;
        }
    }

    [CompilerGenerated]
    private sealed class Class959
    {
        public PopOrdnanceStock gclass130_0;

        internal bool method_0(PopOrdnanceStock gclass130_1)
        {
            return gclass130_1.RaceMissile == this.gclass130_0.RaceMissile;
        }
    }

    [CompilerGenerated]
    private sealed class Class960
    {
        public PopOrdnanceStock gclass130_0;

        internal bool method_0(PopOrdnanceStock gclass130_1)
        {
            return gclass130_1.RaceMissile == this.gclass130_0.RaceMissile;
        }

        internal bool method_1(PopOrdnanceStock gclass130_1)
        {
            return gclass130_1.RaceMissile == this.gclass130_0.RaceMissile;
        }
    }

    [CompilerGenerated]
    private sealed class Class961
    {
        public ShipData gclass40_0;

        internal bool method_0(ShipData gclass40_1)
        {
            return gclass40_1.gclass84_0 == this.gclass40_0.gclass84_0 && gclass40_1.gclass22_0.Collier == 0 &&
                   gclass40_1.method_181() > 0M;
        }
    }

    [CompilerGenerated]
    private sealed class Class962
    {
        public PopOrdnanceStock gclass130_0;

        internal bool method_0(PopOrdnanceStock gclass130_1)
        {
            return gclass130_1.RaceMissile == this.gclass130_0.RaceMissile;
        }
    }

    [CompilerGenerated]
    private sealed class Class963
    {
        public PopOrdnanceStock gclass130_0;

        internal bool method_0(PopOrdnanceStock gclass130_1)
        {
            return gclass130_1.RaceMissile == this.gclass130_0.RaceMissile;
        }

        internal bool method_1(PopOrdnanceStock gclass130_1)
        {
            return gclass130_1.RaceMissile == this.gclass130_0.RaceMissile;
        }
    }

    [CompilerGenerated]
    private sealed class Class964
    {
        public AuroraComponentType auroraComponentType_0;
        public FleetData gclass85_0;
        public SubFleet gclass84_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.method_167(this.auroraComponentType_0) > 0 && gclass40_0.gclass85_0 == this.gclass85_0;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass84_0 == this.gclass84_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class965
    {
        public FleetData gclass85_0;
        public AuroraComponentType auroraComponentType_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0;
        }

        internal int method_1(ShipData gclass40_0)
        {
            return gclass40_0.method_167(this.auroraComponentType_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class966
    {
        public SubFleet gclass84_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass84_0 == this.gclass84_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class967
    {
        public FleetData gclass85_0;
        public SubFleet gclass84_0;
        public FCTSquadronData70 gclass70_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass85_0.Race &&
                   gclass146_0.method_87() == this.gclass85_0.XCoord &&
                   gclass146_0.method_88() == this.gclass85_0.YCoord &&
                   gclass146_0.gclass202_0 == this.gclass85_0.System && gclass146_0.decimal_30 >= 0.05M;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.method_167(AuroraComponentType.RecreationalModule) > 0 &&
                   gclass40_0.gclass21_0 == this.gclass85_0.Race;
        }

        internal bool method_2(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0.XCoord == this.gclass85_0.XCoord &&
                   gclass40_0.gclass85_0.YCoord == this.gclass85_0.YCoord &&
                   gclass40_0.gclass85_0.System == this.gclass85_0.System;
        }

        internal bool method_3(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0;
        }

        internal bool method_4(ShipData gclass40_0)
        {
            return gclass40_0.gclass84_0 == this.gclass84_0;
        }

        internal bool method_5(ShipData gclass40_0)
        {
            return gclass40_0.SquadronData == this.gclass70_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class968
    {
        public FleetData gclass85_0;
        public SubFleet gclass84_0;
        public FCTSquadronData70 gclass70_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass84_0 == this.gclass84_0;
        }

        internal bool method_2(ShipData gclass40_0)
        {
            return gclass40_0.SquadronData == this.gclass70_0;
        }

        internal bool method_3(GClass193 gclass193_0)
        {
            return gclass193_0.gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class969
    {
        public FleetData gclass85_0;
        public SubFleet gclass84_0;
        public FCTSquadronData70 gclass70_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass84_0 == this.gclass84_0;
        }

        internal bool method_2(ShipData gclass40_0)
        {
            return gclass40_0.SquadronData == this.gclass70_0;
        }

        internal bool method_3(GClass192 gclass192_0)
        {
            return gclass192_0.gclass85_0 == this.gclass85_0 && gclass192_0.gclass40_0 != null;
        }

        internal bool method_4(GClass193 gclass193_0)
        {
            return gclass193_0.gclass40_0.gclass85_0 == this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class970
    {
        public List<ShipData> list_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return this.list_0.Contains(gclass103_0.ShipData);
        }
    }

    [CompilerGenerated]
    private sealed class Class971
    {
        public Species gclass194_0;

        internal bool method_0(TransportedColonist gclass181_0)
        {
            return gclass181_0.Species == this.gclass194_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class972
    {
        public PlanetaryInstallationType gclass157_0;

        internal bool method_0(PopulationInstallation gclass158_0)
        {
            return gclass158_0.InstallationType == this.gclass157_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class973
    {
        public ShipComponent gclass230_0;

        internal bool method_0(TransportedComponent gclass73_0)
        {
            return gclass73_0.Component == this.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class974
    {
        public AuroraElement auroraElement_0;

        internal bool method_0(SingleMineralValue gclass125_0)
        {
            return gclass125_0.auroraElement_0 == this.auroraElement_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class975
    {
        public ShipClass gclass22_0;
        public Func<GClass74, bool> func_0;

        internal bool method_0(GClass74 gclass74_0)
        {
            return gclass74_0.gclass22_0 == this.gclass22_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class976
    {
        public ShipData gclass40_0;
        public FleetData.Class975 class975_0;

        internal bool method_0(ShipData gclass40_1)
        {
            return gclass40_1.gclass40_0 == this.gclass40_0 && gclass40_1.gclass22_0 == this.class975_0.gclass22_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class977
    {
        public AuroraComponentType auroraComponentType_0;
        public Func<GClass228, bool> func_0;

        internal bool method_0(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0.gclass231_0.ComponentTypeID == this.auroraComponentType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class978
    {
        public FleetData gclass85_0;
        public bool bool_0;
        public AuroraComponentType auroraComponentType_0;

        internal bool method_0(ShipData gclass40_0)
        {
            if (gclass40_0.gclass85_0 != this.gclass85_0)
                return false;
            return gclass40_0.gclass40_0 == null || this.bool_0;
        }

        internal IEnumerable<GClass228> method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0.dictionary_0.Values.Where<GClass228>(method_2);
        }

        internal bool method_2(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0.gclass231_0.ComponentTypeID == this.auroraComponentType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class979
    {
        public ShipClass gclass22_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0 == this.gclass22_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class980
    {
        public RacialSystemSurvey gclass202_0;
        public FleetData gclass85_0;
        public double double_0;
        public double double_1;

        internal bool method_0(PopulationData gclass146_0)
        {
            if (gclass146_0.gclass202_0 != this.gclass202_0 || gclass146_0.Race != this.gclass85_0.Race ||
                gclass146_0.InstallationDemands.Count <= 0)
                return false;
            return this.gclass85_0.ShippingLine == null || !gclass146_0.bMilitaryRestrictedColony;
        }

        internal double method_1(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class981
    {
        public PopInstallationDemand gclass148_0;

        internal bool method_0(PopInstallationDemand gclass148_1)
        {
            return gclass148_1.InstallationType.InstallationType ==
                this.gclass148_0.InstallationType.InstallationType && !gclass148_1.Export;
        }

        internal bool method_1(PopInstallationDemand gclass148_1)
        {
            return gclass148_1.InstallationType.InstallationType ==
                this.gclass148_0.InstallationType.InstallationType && !gclass148_1.Export;
        }
    }

    [CompilerGenerated]
    private sealed class Class982
    {
        public RacialSystemSurvey gclass202_0;
        public FleetData gclass85_0;
        public double double_0;
        public double double_1;
        public Func<PopTradeBalance, bool> func_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0 && gclass146_0.TradeBalances.Count > 0;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            if (!(gclass146_0.method_41() > this.gclass85_0.int_10) ||
                !this.gclass85_0.Race.list_21.Contains(gclass146_0.Race))
                return false;
            return this.gclass85_0.ShippingLine == null || !gclass146_0.bMilitaryRestrictedColony;
        }

        internal double method_2(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }

        internal bool method_3(PopTradeBalance gclass190_0)
        {
            return gclass190_0.TradeBalance > this.gclass85_0.int_10;
        }
    }

    [CompilerGenerated]
    private sealed class Class983
    {
        public PopTradeBalance gclass190_0;

        internal bool method_0(MoveOrder gclass139_0)
        {
            return gclass139_0.MoveActionType.MoveActionType == MoveActionType.LoadTradeGoods &&
                   gclass139_0.Population == this.gclass190_0.Population &&
                   gclass139_0.DestinationItemID == this.gclass190_0.TradeGood.TradeGoodID;
        }
    }

    [CompilerGenerated]
    private sealed class Class984
    {
        public RacialSystemSurvey gclass202_0;
        public FleetData gclass85_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            if (gclass146_0.gclass202_0 != this.gclass202_0 || gclass146_0.TradeBalances.Count <= 0)
                return false;
            return this.gclass85_0.ShippingLine == null || !gclass146_0.bMilitaryRestrictedColony;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.method_41() > this.gclass85_0.int_10 &&
                   this.gclass85_0.Race.list_21.Contains(gclass146_0.Race);
        }
    }

    [CompilerGenerated]
    private sealed class Class985
    {
        public PopTradeBalance gclass190_0;

        internal bool method_0(MoveOrder gclass139_0)
        {
            return gclass139_0.MoveActionType.MoveActionType == MoveActionType.LoadTradeGoods &&
                   gclass139_0.Population == this.gclass190_0.Population &&
                   gclass139_0.DestinationItemID == this.gclass190_0.TradeGood.TradeGoodID;
        }
    }

    [CompilerGenerated]
    private sealed class Class986
    {
        public RacialSystemSurvey gclass202_0;
        public FleetData gclass85_0;
        public double double_0;
        public double double_1;

        internal bool method_0(PopulationData gclass146_0)
        {
            if (gclass146_0.gclass202_0 != this.gclass202_0 || gclass146_0.Race != this.gclass85_0.Race ||
                gclass146_0.InstallationDemands.Count <= 0)
                return false;
            return this.gclass85_0.ShippingLine == null || !gclass146_0.bMilitaryRestrictedColony;
        }

        internal double method_1(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class987
    {
        public RacialSystemSurvey gclass202_0;
        public FleetData gclass85_0;
        public PopInstallationDemand gclass148_0;
        public double double_0;
        public double double_1;

        internal bool method_0(PopulationData gclass146_0)
        {
            if (gclass146_0.gclass202_0 != this.gclass202_0 || gclass146_0.Race != this.gclass85_0.Race ||
                !gclass146_0.InstallationDemands.ContainsKey(this.gclass148_0.InstallationType.InstallationType))
                return false;
            return this.gclass85_0.ShippingLine == null || !gclass146_0.bMilitaryRestrictedColony;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return !gclass146_0.InstallationDemands[this.gclass148_0.InstallationType.InstallationType].Export;
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.InstallationDemands[this.gclass148_0.InstallationType.InstallationType].Amount *
                this.gclass148_0.InstallationType.CargoPoints >= this.gclass85_0.int_10;
        }

        internal double method_3(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class988
    {
        public RacialSystemSurvey gclass202_0;
        public FleetData gclass85_0;
        public PopTradeBalance gclass190_0;
        public double double_0;
        public double double_1;

        internal bool method_0(PopulationData gclass146_0)
        {
            if (gclass146_0.gclass202_0 != this.gclass202_0)
                return false;
            return this.gclass85_0.ShippingLine == null || !gclass146_0.bMilitaryRestrictedColony;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0 != this.gclass190_0.Population &&
                   this.gclass202_0.Race.list_21.Contains(gclass146_0.Race) &&
                   gclass146_0.TradeBalances.ContainsKey(this.gclass190_0.TradeGood.TradeGoodID);
        }

        internal double method_2(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class989
    {
        public int int_0;
        public FleetData.Class988 class988_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.TradeBalances[this.class988_0.gclass190_0.TradeGood.TradeGoodID].TradeBalance < this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class990
    {
        public PopulationData gclass146_0;
        public FleetData.Class989 class989_0;

        internal bool method_0(MoveOrder gclass139_0)
        {
            return gclass139_0.MoveActionType.MoveActionType == MoveActionType.UnloadTradeGoods &&
                   gclass139_0.Population == this.gclass146_0 &&
                   gclass139_0.DestinationItemID == this.class989_0.class988_0.gclass190_0.TradeGood.TradeGoodID;
        }
    }

    [CompilerGenerated]
    private sealed class Class991
    {
        public RacialSystemSurvey gclass202_0;
        public FleetData gclass85_0;
        public double double_0;
        public double double_1;

        internal bool method_0(PopulationData gclass146_0)
        {
            if (gclass146_0.gclass202_0 != this.gclass202_0 || gclass146_0.ReqInf <= 0)
                return false;
            return this.gclass85_0.ShippingLine == null || !gclass146_0.bMilitaryRestrictedColony;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return this.gclass202_0.Race.list_21.Contains(gclass146_0.Race);
        }

        internal double method_2(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class992
    {
        public PopulationData gclass146_0;

        internal bool method_0(MoveOrder gclass139_0)
        {
            return gclass139_0.MoveActionType.MoveActionType == MoveActionType.UnloadTradeGoods &&
                   gclass139_0.Population == this.gclass146_0 && gclass139_0.DestinationItemID == 16 /*0x10*/;
        }
    }

    [CompilerGenerated]
    private sealed class Class993
    {
        public Contact gclass65_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.int_8 == this.gclass65_0.ContactID;
        }
    }

    [CompilerGenerated]
    private sealed class Class994
    {
        public Contact gclass65_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.int_8 == this.gclass65_0.ContactID;
        }
    }

    [CompilerGenerated]
    private sealed class Class995
    {
        public JumpPoint gclass120_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.ActualSystem == this.gclass120_0.LinkedJumpPoint.SystemData;
        }
    }

    [CompilerGenerated]
    private sealed class Class996
    {
        public RacialSystemSurvey gclass202_0;
        public Func<JumpPoint, bool> func_0;

        internal bool method_0(JumpPoint gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass202_0.ActualSystem && gclass120_0.LinkedJumpPoint != null;
        }
    }

    [CompilerGenerated]
    private sealed class Class997
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(JumpPoint gclass120_0)
        {
            return gclass120_0.LinkedJumpPoint.SystemData == this.gclass202_0.ActualSystem;
        }
    }

    [CompilerGenerated]
    private sealed class Class998
    {
        public RacialSystemSurvey gclass202_0;
        public Func<JumpPoint, bool> func_0;

        internal bool method_0(JumpPoint gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass202_0.ActualSystem && gclass120_0.LinkedJumpPoint != null;
        }
    }

    [CompilerGenerated]
    private sealed class Class999
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(JumpPoint gclass120_0)
        {
            return gclass120_0.LinkedJumpPoint.SystemData == this.gclass202_0.ActualSystem;
        }
    }

    [CompilerGenerated]
    private sealed class Class1000
    {
        public bool bool_0;
        public Decimal decimal_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.int_15 == 0 && gclass40_0.method_148(this.bool_0) != null;
        }

        internal ShipComponent method_1(ShipData gclass40_0)
        {
            return gclass40_0.method_148(this.bool_0);
        }

        internal bool method_2(ShipComponent gclass230_0)
        {
            return gclass230_0.decimal_3 >= this.decimal_0 && gclass230_0.int_10 > 1;
        }
    }

    [CompilerGenerated]
    private sealed class Class1001
    {
        public bool bool_0;
        public FleetData gclass85_0;
        public JumpPoint gclass120_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.int_15 == 0 && gclass40_0.method_148(this.bool_0) != null;
        }

        internal ShipComponent method_1(ShipData gclass40_0)
        {
            return gclass40_0.method_148(this.bool_0);
        }

        internal bool method_2(ShipData gclass40_0)
        {
            return gclass40_0.method_148(this.bool_0) != null && gclass40_0.int_15 == 0;
        }

        internal ShipComponent method_3(ShipData gclass40_0)
        {
            return gclass40_0.method_148(this.bool_0);
        }

        internal bool method_4(ShipData gclass40_0)
        {
            return this.gclass85_0.gclass0_0.method_520(gclass40_0.gclass85_0.XCoord, this.gclass120_0.XCoord,
                       gclass40_0.gclass85_0.YCoord, this.gclass120_0.YCoord) &&
                   gclass40_0.gclass85_0.System == this.gclass85_0.System;
        }

        internal bool method_5(ShipData gclass40_0)
        {
            return gclass40_0.gclass40_0 == null && gclass40_0.method_148(this.bool_0) != null &&
                   gclass40_0.int_15 == 0;
        }

        internal ShipComponent method_6(ShipData gclass40_0)
        {
            return gclass40_0.method_148(this.bool_0);
        }

        internal bool method_7(ShipData gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass85_0.Race;
        }

        internal bool method_8(ShipData gclass40_0)
        {
            return gclass40_0.gclass40_0 == null && gclass40_0.method_148(this.bool_0) != null &&
                   gclass40_0.int_15 == 0;
        }

        internal ShipComponent method_9(ShipData gclass40_0)
        {
            return gclass40_0.method_148(this.bool_0);
        }

        internal bool method_10(ShipData gclass40_0)
        {
            return gclass40_0.gclass40_0 == null && gclass40_0.method_148(this.bool_0) != null &&
                   gclass40_0.int_15 == 0;
        }

        internal ShipComponent method_11(ShipData gclass40_0)
        {
            return gclass40_0.method_148(this.bool_0);
        }

        internal bool method_12(ShipData gclass40_0)
        {
            return gclass40_0.gclass40_0 == null && gclass40_0.method_148(this.bool_0) != null &&
                   gclass40_0.int_15 == 0;
        }

        internal ShipComponent method_13(ShipData gclass40_0)
        {
            return gclass40_0.method_148(this.bool_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class1002
    {
        public GClass221 gclass221_0;
        public List<GameRace> list_0;
        public FleetData.Class1001 class1001_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return this.class1001_0.gclass85_0.gclass0_0.method_520(gclass40_0.gclass85_0.XCoord,
                       this.gclass221_0.double_0, gclass40_0.gclass85_0.YCoord, this.gclass221_0.double_1) &&
                   gclass40_0.gclass85_0.System.ActualSystem ==
                   this.class1001_0.gclass120_0.LinkedJumpPoint.SystemData;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return this.class1001_0.gclass85_0.gclass0_0.method_520(gclass40_0.gclass85_0.XCoord,
                       this.class1001_0.gclass120_0.XCoord, gclass40_0.gclass85_0.YCoord,
                       this.class1001_0.gclass120_0.YCoord) &&
                   gclass40_0.gclass85_0.System == this.class1001_0.gclass85_0.System &&
                   this.list_0.Contains(gclass40_0.gclass21_0);
        }

        internal bool method_2(ShipData gclass40_0)
        {
            return this.class1001_0.gclass85_0.gclass0_0.method_520(gclass40_0.gclass85_0.XCoord,
                       this.gclass221_0.double_0, gclass40_0.gclass85_0.YCoord, this.gclass221_0.double_1) &&
                   gclass40_0.gclass85_0.System.ActualSystem ==
                   this.class1001_0.gclass120_0.LinkedJumpPoint.SystemData &&
                   this.list_0.Contains(gclass40_0.gclass21_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class1003
    {
        public ShipComponent gclass230_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0.Size <= this.gclass230_0.decimal_3;
        }
    }

    [CompilerGenerated]
    private sealed class Class1004
    {
        public GClass134 gclass134_0;

        internal bool method_0(LagrangePoint gclass212_0)
        {
            return gclass212_0.System == this.gclass134_0.gclass202_0.ActualSystem;
        }
    }

    [CompilerGenerated]
    private sealed class Class1005
    {
        public MoveActionDefinition gclass133_0;

        internal bool method_0(MoveOrder gclass139_0)
        {
            return gclass139_0.MoveActionType == this.gclass133_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1006
    {
        public ShipData gclass40_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.ShipData == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1007
    {
        public FleetData gclass85_0;
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(RacialSystemSurvey gclass202_1)
        {
            return gclass202_1 != this.gclass202_0;
        }

        internal bool method_1(RacialSystemSurvey gclass202_1)
        {
            return gclass202_1 != this.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1008
    {
        public RacialSystemSurvey gclass202_0;
        public FleetData.Class1007 class1007_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.class1007_0.gclass85_0.Race &&
                   gclass146_0.gclass202_0 == this.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1009
    {
        public FleetData gclass85_0;
        public CheckBox checkBox_0;

        internal bool method_0(SurveyLocation gclass213_0)
        {
            return !gclass213_0.RaceIDs.Contains(this.gclass85_0.Race.RaceID) ||
                   this.checkBox_0.CheckState == CheckState.Unchecked;
        }

        internal string method_1(SystemBodyData gclass1_0)
        {
            return gclass1_0.method_78(this.gclass85_0.Race);
        }
    }

    [CompilerGenerated]
    private sealed class Class1010
    {
        public RacialSystemSurvey gclass202_0;
        public FleetData.Class1009 class1009_0;

        internal bool method_0(JumpPoint gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass202_0.ActualSystem;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            if (gclass146_0.gclass202_0.ActualSystem != this.gclass202_0.ActualSystem)
                return false;
            if (gclass146_0.Race == this.class1009_0.gclass85_0.Race)
                return true;
            return gclass146_0.ProvideColonists == 1 &&
                   gclass146_0.Species == this.class1009_0.gclass85_0.Race.method_164();
        }

        internal bool method_2(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.class1009_0.gclass85_0.Race &&
                   gclass85_0.System == this.gclass202_0;
        }

        internal bool method_3(FleetData gclass85_0)
        {
            if (gclass85_0.Race != this.class1009_0.gclass85_0.Race ||
                gclass85_0.System != this.gclass202_0 || gclass85_0 == this.class1009_0.gclass85_0)
                return false;
            return gclass85_0.CivilianFunction == CivilanFunctionType.const_0 || gclass85_0.CivilianFunction == CivilanFunctionType.const_3;
        }

        internal bool method_4(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.class1009_0.gclass85_0.Race &&
                   gclass85_0.System == this.gclass202_0 && gclass85_0 != this.class1009_0.gclass85_0 &&
                   gclass85_0.CivilianFunction != 0;
        }

        internal bool method_5(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0.System.ActualSystem == this.gclass202_0.ActualSystem &&
                   gclass40_0.gclass21_0 != this.class1009_0.gclass85_0.Race;
        }

        internal bool method_6(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0.ActualSystem == this.gclass202_0.ActualSystem &&
                   gclass146_0.Race != this.class1009_0.gclass85_0.Race;
        }

        internal bool method_7(MissileSalvo gclass132_0)
        {
            return gclass132_0.System == this.gclass202_0.ActualSystem &&
                   gclass132_0.Race != this.class1009_0.gclass85_0.Race;
        }

        internal bool method_8(Contact gclass65_0)
        {
            return gclass65_0.System == this.gclass202_0.ActualSystem &&
                   gclass65_0.DetectRace == this.class1009_0.gclass85_0.Race &&
                   gclass65_0.ContactType != AuroraContactType.Ship &&
                   gclass65_0.ContactType != AuroraContactType.Population;
        }

        internal bool method_9(Waypoint gclass214_0)
        {
            return gclass214_0.Race == this.class1009_0.gclass85_0.Race &&
                   gclass214_0.System == this.gclass202_0.ActualSystem;
        }

        internal bool method_10(Wreck gclass233_0)
        {
            return gclass233_0.System == this.gclass202_0.ActualSystem;
        }

        internal bool method_11(GClass59 gclass59_0)
        {
            return gclass59_0.gclass200_0 == this.gclass202_0.ActualSystem;
        }

        internal bool method_12(SystemBodyData gclass1_0)
        {
            if (gclass1_0.SystemData != this.gclass202_0.ActualSystem || gclass1_0.BodyClass != PlanetBodyClass.Moon)
                return false;
            return !gclass1_0.method_77(this.class1009_0.gclass85_0.Race) ||
                   this.class1009_0.checkBox_0.CheckState == CheckState.Unchecked;
        }

        internal bool method_13(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass202_0.ActualSystem &&
                   gclass1_0.BodyClass == PlanetBodyClass.Planet;
        }

        internal bool method_14(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass202_0.ActualSystem &&
                   gclass1_0.BodyClass == PlanetBodyClass.Planet &&
                   gclass1_0.BodyTypeId != AuroraSystemBodyType.DwarfPlanet;
        }

        internal bool method_15(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass202_0.ActualSystem &&
                   gclass1_0.BodyTypeId == AuroraSystemBodyType.DwarfPlanet;
        }

        internal bool method_16(SystemBodyData gclass1_0)
        {
            if (gclass1_0.SystemData != this.gclass202_0.ActualSystem || gclass1_0.BodyClass != PlanetBodyClass.Comet)
                return false;
            return !gclass1_0.method_77(this.class1009_0.gclass85_0.Race) ||
                   this.class1009_0.checkBox_0.CheckState == CheckState.Unchecked;
        }

        internal bool method_17(SystemBodyData gclass1_0)
        {
            if (gclass1_0.SystemData != this.gclass202_0.ActualSystem || gclass1_0.BodyClass != PlanetBodyClass.Asteroid)
                return false;
            return !gclass1_0.method_77(this.class1009_0.gclass85_0.Race) ||
                   this.class1009_0.checkBox_0.CheckState == CheckState.Unchecked;
        }
    }

    [CompilerGenerated]
    private sealed class Class1011
    {
        public FleetData gclass85_0;
        public GClass134 gclass134_0;
        public Func<LagrangePoint, bool> func_0;
        public Func<FleetData, bool> func_1;
        public Func<FleetData, bool> func_2;
        public Func<GClass193, bool> func_3;
        public Func<GClass55, bool> func_4;

        internal bool method_0(LagrangePoint gclass212_0)
        {
            return gclass212_0.Planet == this.gclass85_0.gclass0_0.SystemBodyRecordDic[this.gclass134_0.int_0];
        }

        internal bool method_1(FleetData gclass85_1)
        {
            return gclass85_1.AssignedPopulation == this.gclass134_0.gclass146_0;
        }

        internal bool method_2(FleetData gclass85_1)
        {
            return gclass85_1.AssignedPopulation == this.gclass134_0.gclass146_0;
        }

        internal bool method_3(GClass193 gclass193_0)
        {
            return gclass193_0.gclass146_0 == this.gclass134_0.gclass146_0;
        }

        internal bool method_4(GClass55 gclass55_0)
        {
            return gclass55_0.gclass146_1 == this.gclass134_0.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1012
    {
        public List<ShipData> list_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return this.list_0.Contains(gclass103_0.ShipData);
        }
    }

    [CompilerGenerated]
    private sealed class Class1013
    {
        public FleetData gclass85_0;
        public CheckBox checkBox_0;
    }

    [CompilerGenerated]
    private sealed class Class1014
    {
        public SystemBodyData gclass1_0;
        public FleetData.Class1013 class1013_0;

        internal bool method_0(SystemBodyData gclass1_1)
        {
            if (gclass1_1.ParentBodyData != this.gclass1_0 || gclass1_1.BodyClass != PlanetBodyClass.Moon)
                return false;
            return !gclass1_1.method_77(this.class1013_0.gclass85_0.Race) ||
                   this.class1013_0.checkBox_0.CheckState == CheckState.Unchecked;
        }
    }
}