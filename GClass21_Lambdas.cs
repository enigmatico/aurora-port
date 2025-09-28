using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Aurora;

#nullable disable
public partial class GameRace
{
    public class swappedSymbol
    {
        public static Func<GClass228, bool> swappedSymbol2__11_0;
    }

    [CompilerGenerated]
    private sealed class Class496
    {
        public AutomatedClassDesign gclass14_0;

        internal bool method_0(ShipClass gclass22_0)
        {
            return gclass22_0.AutomatedClassDesign == this.gclass14_0;
        }

        internal bool method_1(ShipClass gclass22_0)
        {
            return gclass22_0.AutomatedClassDesign == this.gclass14_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class497
    {
        public AutomatedClassDesign gclass14_0;

        internal bool method_0(ShipClass gclass22_0)
        {
            return gclass22_0.AutomatedClassDesign == this.gclass14_0;
        }

        internal bool method_1(ShipClass gclass22_0)
        {
            return gclass22_0.AutomatedClassDesign == this.gclass14_0;
        }

        internal bool method_2(ShipClass gclass22_0)
        {
            return gclass22_0.AutomatedClassDesign == this.gclass14_0;
        }

        internal bool method_3(ShipClass gclass22_0)
        {
            return gclass22_0.AutomatedClassDesign == this.gclass14_0;
        }

        internal bool method_4(ShipClass gclass22_0)
        {
            return gclass22_0.AutomatedClassDesign == this.gclass14_0;
        }

        internal bool method_5(ShipClass gclass22_0)
        {
            return gclass22_0.AutomatedClassDesign == this.gclass14_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class498
    {
        public AncientConstruct gclass220_0;
        public GameRace gclass21_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0 && gclass146_0.SystemBodyData == this.gclass220_0.SystemBody;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0 && gclass146_0.SystemBodyData == this.gclass220_0.SystemBody;
        }
    }

    [CompilerGenerated]
    private sealed class Class499
    {
        public NavalAdminCommand gclass83_0;

        internal bool method_0(NavalAdminCommand gclass83_1)
        {
            return gclass83_1.ParentAdminCommand == this.gclass83_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class500
    {
        public SubFleet gclass84_0;

        internal bool method_0(SubFleet gclass84_1)
        {
            return gclass84_1.ParentSubFleet == this.gclass84_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class501
    {
        public FleetData gclass85_0;
        public SubFleet gclass84_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0 && gclass40_0.gclass84_0 == this.gclass84_0;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0 == this.gclass85_0 && gclass40_0.SquadronData != null;
        }
    }

    [CompilerGenerated]
    private sealed class Class502
    {
        public FCTSquadronData70 gclass70_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.SquadronData == this.gclass70_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class503
    {
        public GameRace gclass21_0;
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(ShippingLineData gclass187_0)
        {
            return gclass187_0.gclass21_0 == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class504
    {
        public ShippingLineData gclass187_0;
        public GameRace.Class503 class503_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.ShippingLine == this.gclass187_0;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.ShippingLine == this.gclass187_0 && gclass85_0.System == this.class503_0.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class505
    {
        public NavalAdminCommand gclass83_0;
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.ParentNavalCommand == this.gclass83_0 && gclass85_0.ShippingLine == null;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.ParentNavalCommand == this.gclass83_0 && gclass85_0.ShippingLine == null &&
                   gclass85_0.System == this.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class506
    {
        public FleetData gclass85_0;

        internal bool method_0(SubFleet gclass84_0)
        {
            return gclass84_0.ParentFleet == this.gclass85_0 && gclass84_0.ParentSubFleet == null;
        }
    }

    [CompilerGenerated]
    private sealed class Class507
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.System == this.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class508
    {
        public Class330<ShipClass, int> class330_0;
        public GameRace.Class507 class507_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0.System == this.class507_0.gclass202_0 &&
                   gclass40_0.gclass22_0 == this.class330_0.ClassType;
        }
    }

    [CompilerGenerated]
    private sealed class Class509
    {
        public GroundUnitSeriesData gclass94_0;

        internal bool method_0(GroundUnitSeriesClassData gclass95_0)
        {
            return gclass95_0.UnitSeriesData == this.gclass94_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class510
    {
        public GroundUnitBaseTypeData gclass96_0;

        internal bool method_0(GroundUnitClass101 gclass101_0)
        {
            return gclass101_0.GroundUnitBaseTypeData == this.gclass96_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class511
    {
        public OrganizationNodeC93 gclass93_0;

        internal bool method_0(OrganizationNodeC93 gclass93_1)
        {
            return gclass93_1.ParentOrganizationNode == this.gclass93_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class512
    {
        public OrganizationNodeC93 gclass93_0;

        internal bool method_0(OrganizationNodeC93 gclass93_1)
        {
            return gclass93_1.ParentOrganizationNode == this.gclass93_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class513
    {
        public OrganizationNodeC93 gclass93_0;

        internal bool method_0(OrganizationNodeC93 gclass93_1)
        {
            return gclass93_1.ParentOrganizationNode == this.gclass93_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class514
    {
        public OrganizationNodeC93 gclass93_0;

        internal bool method_0(OrganizationNodeC93 gclass93_1)
        {
            return gclass93_1.ParentOrganizationNode == this.gclass93_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class515
    {
        public GameRace gclass21_0;
        public CheckState checkState_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            if (gclass103_0.RaceData != this.gclass21_0)
                return false;
            return this.checkState_0 == CheckState.Checked || !gclass103_0.bCivilian;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass103_0 != null &&
                   gclass40_0.gclass40_0 == null;
        }

        internal bool method_2(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass21_0 && gclass103_0.ParentFormationData == null;
        }
    }

    [CompilerGenerated]
    private sealed class Class516
    {
        public List<GroundUnitFormationData> list_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return !this.list_0.Contains(gclass103_0.ParentFormationData);
        }
    }

    [CompilerGenerated]
    private sealed class Class517
    {
        public GroundUnitFormationData gclass103_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.ParentFormationData == this.gclass103_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class518
    {
        public GroundUnitFormationData gclass103_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.ParentFormationData == this.gclass103_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class519
    {
        public GroundUnitFormationData gclass103_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.ParentFormationData == this.gclass103_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class520
    {
        public GameRace gclass21_0;
        public CheckState checkState_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            if (gclass103_0.RaceData != this.gclass21_0 || gclass103_0.PopulationData == null)
                return false;
            return this.checkState_0 == CheckState.Checked || !gclass103_0.bCivilian;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0;
        }

        internal bool method_2(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass21_0 && gclass103_0.ShipData != null;
        }
    }

    [CompilerGenerated]
    private sealed class Class521
    {
        public List<SystemBodyData> list_0;
        public List<StarSystem> list_1;

        internal bool method_0(PopulationData gclass146_0)
        {
            return this.list_0.Contains(gclass146_0.SystemBodyData);
        }

        internal bool method_1(RacialSystemSurvey gclass202_0)
        {
            return this.list_1.Contains(gclass202_0.ActualSystem);
        }
    }

    [CompilerGenerated]
    private sealed class Class522
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0.System.ActualSystem == this.gclass202_0.ActualSystem;
        }
    }

    [CompilerGenerated]
    private sealed class Class523
    {
        public GameRace gclass21_0;
        public PopulationData gclass146_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass21_0;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.XCoord == this.gclass146_0.method_87() &&
                   gclass85_0.YCoord == this.gclass146_0.method_88() && gclass85_0.System.ActualSystem ==
                   this.gclass146_0.gclass202_0.ActualSystem;
        }
    }

    [CompilerGenerated]
    private sealed class Class524
    {
        public GameRace gclass21_0;
        public PopulationData gclass146_0;

        internal bool method_0(MoveOrder gclass139_0)
        {
            return gclass139_0.MoveActionType.MoveActionType == MoveActionType.ProvideOrbitalBombardmentSupport && gclass139_0.bArrived &&
                   gclass139_0.Race == this.gclass21_0;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.XCoord == this.gclass146_0.method_87() &&
                   gclass85_0.YCoord == this.gclass146_0.method_88() && gclass85_0.System.ActualSystem ==
                   this.gclass146_0.gclass202_0.ActualSystem;
        }
    }

    [CompilerGenerated]
    private sealed class Class525
    {
        public GameRace gclass21_0;
        public PopulationData gclass146_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass21_0 && gclass103_0.ParentFormationData == null &&
                   gclass103_0.PopulationData == this.gclass146_0;
        }

        internal bool method_1(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass21_0 && gclass103_0.ParentFormationData != null &&
                   gclass103_0.PopulationData == this.gclass146_0;
        }

        internal bool method_2(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.ParentFormationData.PopulationData != this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class526
    {
        public GameRace gclass21_0;
        public ShipData gclass40_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass21_0 && gclass103_0.ParentFormationData == null &&
                   gclass103_0.ShipData == this.gclass40_0;
        }

        internal bool method_1(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass21_0 && gclass103_0.ParentFormationData != null &&
                   gclass103_0.ShipData == this.gclass40_0;
        }

        internal bool method_2(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.ParentFormationData.ShipData != this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class527
    {
        public GroundUnitFormationData gclass103_0;
        public PopulationData gclass146_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.ParentFormationData == this.gclass103_0 && gclass103_1.PopulationData == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class528
    {
        public GroundUnitFormationData gclass103_0;
        public ShipData gclass40_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.ParentFormationData == this.gclass103_0 && gclass103_1.ShipData == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class529
    {
        public ShipHull gclass76_0;

        internal bool method_0(ShipClass gclass22_0)
        {
            return gclass22_0.ShipHull == this.gclass76_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class530
    {
        public GClass62 gclass62_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.gclass62_0 == this.gclass62_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class531
    {
        public AlienRaceInfo gclass110_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return this.gclass110_0.dictionary_1.ContainsKey(gclass202_0.ActualSystem.SystemID);
        }

        internal bool method_1(GClass115 gclass115_0)
        {
            return gclass115_0.gclass110_0 == this.gclass110_0;
        }

        internal bool method_2(GClass114 gclass114_0)
        {
            return gclass114_0.gclass110_0 == this.gclass110_0;
        }

        internal bool method_3(GClass115 gclass115_0)
        {
            return gclass115_0.gclass110_0 == this.gclass110_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class532
    {
        public RacialSystemSurvey gclass202_0;
        public GameRace.Class531 class531_0;

        internal bool method_0(GClass113 gclass113_0)
        {
            return gclass113_0.gclass110_0 == this.class531_0.gclass110_0 &&
                   gclass113_0.gclass146_0.gclass202_0.ActualSystem == this.gclass202_0.ActualSystem;
        }
    }

    [CompilerGenerated]
    private sealed class Class533
    {
        public GClass115 gclass115_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return gclass117_0.gclass115_0 == this.gclass115_0 && !gclass117_0.bool_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class534
    {
        public GameRace gclass21_0;
        public FleetData gclass85_0;
        public Func<GClass117, bool> func_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return gclass117_0.gclass200_0 == this.gclass85_0.System.ActualSystem;
        }
    }

    [CompilerGenerated]
    private sealed class Class535
    {
        public AlienRaceInfo gclass110_0;
        public GameRace.Class534 class534_0;
        public Func<Contact, bool> func_0;
        public Func<GClass117, bool> func_1;

        internal bool method_0(GClass115 gclass115_0)
        {
            return gclass115_0.gclass110_0 == this.gclass110_0;
        }

        internal bool method_1(GClass117 gclass117_0)
        {
            return this.class534_0.gclass21_0.gclass0_0.Contacts.Values
                .Where<Contact>(this.method_2)
                .Select<Contact, ShipData>(gc65 => gc65.TargetShip)
                .Contains<ShipData>(gclass117_0.gclass40_0);
        }

        internal bool method_2(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.class534_0.gclass21_0 &&
                   gclass65_0.ContactRace == this.gclass110_0.ActualAlienRace &&
                   gclass65_0.ContactType == AuroraContactType.Ship &&
                   gclass65_0.LastUpdate == this.class534_0.gclass21_0.gclass0_0.GameTime;
        }
    }

    [CompilerGenerated]
    private sealed class Class536
    {
        public GClass115 gclass115_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return gclass117_0.gclass115_0 == this.gclass115_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class537
    {
        public GameRace gclass21_0;
        public CheckState checkState_0;
        public Func<ShipComponent, bool> func_0;
        public Func<ShipComponent, bool> func_1;
        public Func<PopulationData, bool> func_2;
        public Func<PopulationData, bool> func_3;

        internal bool method_0(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass230_0.gclass231_0.bShowInClassDisplay && !gclass230_0.bool_3;
        }

        internal bool method_1(ShipComponent gclass230_0)
        {
            return gclass230_0.genum86_0 == GEnum86.const_0 || this.checkState_0 == CheckState.Checked;
        }

        internal bool method_2(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass164_0.method_0(this.gclass21_0) && gclass230_0.gclass231_0.bShowInClassDisplay &&
                   !gclass230_0.bool_3;
        }

        internal bool method_3(ShipComponent gclass230_0)
        {
            return gclass230_0.genum86_0 == GEnum86.const_0 || this.checkState_0 == CheckState.Checked;
        }

        internal bool method_4(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0;
        }

        internal bool method_5(TransportedComponent gclass73_0)
        {
            return gclass73_0.Component.gclass164_0.method_0(this.gclass21_0);
        }

        internal bool method_6(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0;
        }

        internal bool method_7(TransportedComponent gclass73_0)
        {
            return !gclass73_0.Component.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_8(ShipComponent gclass230_0)
        {
            return gclass230_0.genum86_0 == GEnum86.const_0 || this.checkState_0 == CheckState.Checked;
        }

        internal bool method_9(ShipComponent gclass230_0)
        {
            return gclass230_0.genum86_0 == GEnum86.const_0 || this.checkState_0 == CheckState.Checked;
        }

        internal bool method_10(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0;
        }

        internal bool method_11(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class538
    {
        public ClassSummaryType gclass232_0;
        public GameRace.Class537 class537_0;

        internal bool method_0(ComponentTypeData gclass231_0)
        {
            return gclass231_0.ClassSummaryType == this.gclass232_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class539
    {
        public ComponentTypeData gclass231_0;
        public GameRace.Class538 class538_0;

        internal bool method_0(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.class538_0.class537_0.gclass21_0.RaceID) &&
                   gclass230_0.gclass231_0 == this.gclass231_0 && !gclass230_0.bool_3;
        }

        internal bool method_1(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass164_0.method_0(this.class538_0.class537_0.gclass21_0) &&
                   gclass230_0.gclass231_0 == this.gclass231_0 && !gclass230_0.bool_3;
        }

        internal bool method_2(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass231_0 == this.gclass231_0 &&
                   gclass230_0.gclass164_0.method_0(this.class538_0.class537_0.gclass21_0);
        }

        internal bool method_3(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass231_0 == this.gclass231_0 &&
                   !gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.class538_0.class537_0.gclass21_0.RaceID);
        }
    }

    [CompilerGenerated]
    private sealed class Class540
    {
        public TechTypeData gclass163_0;
        public GameRace gclass21_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.gclass163_0 == this.gclass163_0 &&
                   gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }
    }

    [CompilerGenerated]
    private sealed class Class541
    {
        public TechSystem gclass164_0;
        public GameRace gclass21_0;

        internal bool method_0(TechSystem gclass164_1)
        {
            return gclass164_1.gclass163_0 == this.gclass164_0.gclass163_0 &&
                   gclass164_1.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && !gclass164_1.bool_4 &&
                   gclass164_1.int_4 > this.gclass164_0.int_4;
        }
    }

    [CompilerGenerated]
    private sealed class Class542
    {
        public GameRace gclass21_0;
        public Decimal decimal_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.gclass163_0 ==
                   this.gclass21_0.gclass0_0.TechTypeDataDictionary[TechType.FireControlSizevsTrackingSpeed] &&
                   gclass164_0.decimal_0 > this.decimal_0 &&
                   gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }
    }

    [CompilerGenerated]
    private sealed class Class543
    {
        public TechType genum122_0;
        public GameRace gclass21_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.gclass163_0.TechType == this.genum122_0 &&
                   gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }
    }

    [CompilerGenerated]
    private sealed class Class544
    {
        public GameRace gclass21_0;
        public TechType genum122_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.gclass163_0 == this.gclass21_0.gclass0_0.TechTypeDataDictionary[this.genum122_0] &&
                   !gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }
    }

    [CompilerGenerated]
    private sealed class Class545
    {
        public GameRace gclass21_0;
        public TechType genum122_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.gclass163_0 == this.gclass21_0.gclass0_0.TechTypeDataDictionary[this.genum122_0] &&
                   !gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }
    }

    [CompilerGenerated]
    private sealed class Class546
    {
        public GEnum118 genum118_0;
        public GameRace gclass21_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return (GEnum118)gclass164_0.TechSystemID == this.genum118_0 &&
                   gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }
    }

    [CompilerGenerated]
    private sealed class Class547
    {
        public GEnum118 genum118_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return (GEnum118)gclass164_0.TechSystemID == this.genum118_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class548
    {
        public int int_0;
        public GameRace gclass21_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.TechSystemID == this.int_0 && gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }
    }

    [CompilerGenerated]
    private sealed class Class549
    {
        public ShipComponent gclass230_0;
        public ShipComponent gclass230_1;
        public Func<GClass228, bool> func_0;
        public Func<GClass228, bool> func_1;
        public Func<GClass228, bool> func_2;
        public Func<GClass228, bool> func_3;
        public Func<GClass228, bool> func_4;
        public Func<GClass228, bool> func_5;

        internal bool method_0(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0 == this.gclass230_0;
        }

        internal bool method_1(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0 == this.gclass230_1;
        }

        internal bool method_2(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0 == this.gclass230_1;
        }

        internal bool method_3(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0 == this.gclass230_1;
        }

        internal bool method_4(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0 == this.gclass230_1;
        }

        internal bool method_5(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0 == this.gclass230_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class550
    {
        public ShipComponent gclass230_0;
        public Func<GClass228, bool> func_0;

        internal bool method_0(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0 == this.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class551
    {
        public GameRace gclass21_0;
        public ShipData gclass40_0;
        public ContactDetectMethod genum10_0;
        public GClass66 gclass66_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.gclass21_0 && gclass65_0.TargetShip == this.gclass40_0 &&
                   gclass65_0.ContactType == AuroraContactType.Ship && gclass65_0.ContactMethod == this.genum10_0;
        }

        internal bool method_1(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.gclass21_0 && gclass65_0.TargetShip == this.gclass40_0 &&
                   gclass65_0.ContactType == AuroraContactType.Ship &&
                   gclass65_0.ContactMethod == ContactDetectMethod.const_2 &&
                   gclass65_0.ContactStrength == this.gclass66_0.decimal_0 * this.gclass66_0.int_0 &&
                   gclass65_0.Resolution == this.gclass66_0.int_0;
        }

        internal bool method_2(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.gclass21_0 && gclass65_0.TargetShip == this.gclass40_0 &&
                   gclass65_0.ContactType == AuroraContactType.Ship && gclass65_0.ContactMethod != this.genum10_0 &&
                   gclass65_0.LastUpdate == this.gclass21_0.gclass0_0.GameTime;
        }
    }

    [CompilerGenerated]
    private sealed class Class552
    {
        public GameRace gclass21_0;
        public MissileSalvo gclass132_0;
        public ContactDetectMethod genum10_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.gclass21_0 && gclass65_0.TargetSalvo == this.gclass132_0 &&
                   gclass65_0.ContactType == AuroraContactType.Salvo && gclass65_0.ContactMethod == this.genum10_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class553
    {
        public GameRace gclass21_0;
        public PopulationData gclass146_0;
        public AuroraContactType auroraContactType_0;
        public ContactDetectMethod genum10_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.gclass21_0 && gclass65_0.TargetPopulation == this.gclass146_0 &&
                   gclass65_0.ContactType == this.auroraContactType_0 && gclass65_0.ContactMethod == this.genum10_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class554
    {
        public GameRace gclass21_0;
        public GClass193 gclass193_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.gclass21_0 && gclass65_0.TargetPopulation == null &&
                   gclass65_0.ContactType == AuroraContactType.Shipyard &&
                   gclass65_0.ContactID == this.gclass193_0.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class555
    {
        public RaceMissile gclass129_0;
        public RaceMissile gclass129_1;
        public RaceMissile gclass129_2;

        internal bool method_0(PopOrdnanceStock gclass130_0)
        {
            return gclass130_0.RaceMissile == this.gclass129_0;
        }

        internal bool method_1(PopOrdnanceStock gclass130_0)
        {
            return gclass130_0.RaceMissile == this.gclass129_1;
        }

        internal bool method_2(PopOrdnanceStock gclass130_0)
        {
            return gclass130_0.RaceMissile == this.gclass129_2;
        }
    }

    [CompilerGenerated]
    private sealed class Class556
    {
        public GClass118 gclass118_0;

        internal bool method_0(GClass115 gclass115_0)
        {
            return gclass115_0.list_0.Contains(this.gclass118_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class557
    {
        public AlienRaceInfo gclass110_0;

        internal bool method_0(GClass115 gclass115_0)
        {
            return gclass115_0.gclass110_0 == this.gclass110_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class558
    {
        public GClass115 gclass115_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return gclass117_0.gclass115_0 == this.gclass115_0 && !gclass117_0.bool_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class559
    {
        public ShipData gclass40_0;

        internal bool method_0(GClass115 gclass115_0)
        {
            return gclass115_0.gclass22_0 == this.gclass40_0.gclass22_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class560
    {
        public GClass115 gclass115_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return gclass117_0.gclass115_0 == this.gclass115_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class561
    {
        public GroundUnitClass101 gclass101_0;

        internal bool method_0(GroundUnitClass101 gclass101_1)
        {
            return gclass101_1.genum115_0 == this.gclass101_0.genum115_0;
        }

        internal bool method_1(GroundUnitClass101 gclass101_1)
        {
            return gclass101_1.genum115_0 == this.gclass101_0.genum115_0;
        }

        internal bool method_2(GroundUnitFormationElement gclass39_0)
        {
            return gclass39_0.GroundUnitClass == this.gclass101_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class562
    {
        public AlienRaceInfo gclass110_0;

        internal bool method_0(AlienRaceInfo gclass110_1)
        {
            return gclass110_1.ActualAlienRace == this.gclass110_0.ViewingRace;
        }
    }

    [CompilerGenerated]
    private sealed class Class563
    {
        public ShipData gclass40_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class564
    {
        public ShipData gclass40_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class565
    {
        public ShipData gclass40_0;

        internal bool method_0(GClass115 gclass115_0)
        {
            return gclass115_0.gclass22_0 == this.gclass40_0.gclass22_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class566
    {
        public ShipClass gclass22_0;

        internal bool method_0(GClass115 gclass115_0)
        {
            return gclass115_0.gclass22_0 == this.gclass22_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class567
    {
        public GroundUnitFormationElement gclass39_0;
        public AlienRaceInfo gclass110_0;

        internal bool method_0(GClass114 gclass114_0)
        {
            return gclass114_0.gclass101_0 == this.gclass39_0.GroundUnitClass &&
                   gclass114_0.gclass110_0 == this.gclass110_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class568
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
    private sealed class Class569
    {
        public Decimal decimal_0;
        public int int_0;

        internal bool method_0(GClass118 gclass118_0)
        {
            return gclass118_0.decimal_1 * gclass118_0.int_1 == this.decimal_0 && gclass118_0.int_1 == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class570
    {
        public ShipClass gclass22_0;

        internal IEnumerable<RaceOperationalGroupElement> method_0(OperationalGroup gclass9_0)
        {
            return gclass9_0.method_0(this.gclass22_0.Race);
        }

        internal bool method_1(RaceOperationalGroupElement gclass11_0)
        {
            return gclass11_0.AutomatedClassDesign == this.gclass22_0.AutomatedClassDesign && gclass11_0.KeyElement;
        }
    }

    [CompilerGenerated]
    private sealed class Class571
    {
        public GClass66 gclass66_0;

        internal bool method_0(GClass118 gclass118_0)
        {
            return gclass118_0.gclass230_0 == this.gclass66_0.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class572
    {
        public ShipComponent gclass230_0;

        internal bool method_0(GClass118 gclass118_0)
        {
            return gclass118_0.gclass230_0 == this.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class573
    {
        public PopulationData gclass146_0;

        internal bool method_0(GClass113 gclass113_0)
        {
            return gclass113_0.gclass146_0 == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class574
    {
        public PopulationData gclass146_0;

        internal bool method_0(GClass113 gclass113_0)
        {
            return gclass113_0.gclass146_0 == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class575
    {
        public GameRace gclass21_0;
        public GEnum104 genum104_0;
        public Func<FleetData, bool> func_0;
        public Func<FleetData, bool> func_1;

        internal bool method_0(NavalAdminCommand gclass83_0)
        {
            return gclass83_0.Race == this.gclass21_0 && gclass83_0.ParentAdminCommand == null;
        }

        internal bool method_1(ShipClass gclass22_0)
        {
            return gclass22_0.Race == this.gclass21_0;
        }

        internal bool method_2(GClass12 gclass12_0)
        {
            return gclass12_0.gclass9_0.genum104_0 == this.genum104_0;
        }

        internal bool method_3(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass21_0;
        }

        internal bool method_4(FleetData gclass85_0)
        {
            return gclass85_0.NPROperationGroup.genum104_0 == this.genum104_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class576
    {
        public RaceOperationalGroupElement gclass11_0;

        internal bool method_0(ShipClass gclass22_0)
        {
            return gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID == this.gclass11_0.AutomatedClassDesign.AutomatedClassDesignTypeID;
        }
    }

    [CompilerGenerated]
    private sealed class Class577
    {
        public GameRace gclass21_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0;
        }

        internal bool method_1(ShipClass gclass22_0)
        {
            return gclass22_0.Race == this.gclass21_0;
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0;
        }

        internal bool method_3(GroundUnitClass101 gclass101_0)
        {
            return gclass101_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }
    }

    [CompilerGenerated]
    private sealed class Class578
    {
        public GClass115 gclass115_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0 == this.gclass115_0.gclass22_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class579
    {
        public string string_0;
        public GameRace gclass21_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.ShipName.Trim() == this.string_0.Trim() && gclass40_0.gclass21_0 == this.gclass21_0;
        }

        internal bool method_1(GClass192 gclass192_0)
        {
            return gclass192_0.string_0.Trim() == this.string_0.Trim() && gclass192_0.gclass21_0 == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class580
    {
        public string string_0;
        public GameRace gclass21_0;

        internal bool method_0(ShipClass gclass22_0)
        {
            return gclass22_0.ClassName.Trim() == this.string_0.Trim() && gclass22_0.Race == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class581
    {
        public string string_0;

        internal bool method_0(RaceMissile gclass129_0)
        {
            return gclass129_0.Name.Contains(this.string_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class582
    {
        public string string_0;

        internal bool method_0(GroundUnitClass101 gclass101_0)
        {
            return gclass101_0.ClassName.Contains(this.string_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class583
    {
        public string string_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.Name.Trim() == this.string_0.Trim();
        }
    }

    [CompilerGenerated]
    private sealed class Class584
    {
        public string string_0;

        internal bool method_0(GClass115 gclass115_0)
        {
            return gclass115_0.ClassName.Trim() == this.string_0.Trim();
        }
    }

    [CompilerGenerated]
    private sealed class Class585
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class586
    {
        public Star197 gclass197_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.SystemBodyData.StarData == this.gclass197_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class587
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass202_0.Race &&
                   gclass146_0.gclass202_0 == this.gclass202_0 && gclass146_0.decimal_30 > 0M;
        }
    }

    [CompilerGenerated]
    private sealed class Class588
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return !gclass146_0.bool_5 && gclass146_0.decimal_72 > 0M &&
                   gclass146_0.Race == this.gclass202_0.Race && gclass146_0.gclass202_0 == this.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class589
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return !gclass146_0.bool_5 && gclass146_0.method_73(AuroraInstallationType.CivilianMiningComplex) > 0 &&
                   gclass146_0.Race == this.gclass202_0.Race && gclass146_0.gclass202_0 == this.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class590
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return !gclass146_0.bool_5 && gclass146_0.decimal_73 > 0M &&
                   gclass146_0.Race == this.gclass202_0.Race && gclass146_0.gclass202_0 == this.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class591
    {
        public RacialSystemSurvey gclass202_0;
        public GameRace gclass21_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0 && gclass146_0.SystemBodyData.AbandonedFactories > 0 &&
                   gclass146_0.SystemBodyData.method_77(this.gclass21_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class592
    {
        public RacialSystemSurvey gclass202_0;
        public GameRace gclass21_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return !gclass146_0.bool_5 && gclass146_0.gclass202_0 == this.gclass202_0 &&
                   gclass146_0.SystemBodyData.AbandonedFactories > 0 && gclass146_0.SystemBodyData.method_77(this.gclass21_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class593
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return !gclass146_0.bool_5 && gclass146_0.method_62(AuroraProductionCategory.Sensors) > 0M &&
                   gclass146_0.Race == this.gclass202_0.Race && gclass146_0.gclass202_0 == this.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class594
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return !gclass146_0.bool_5 && gclass146_0.Race == this.gclass202_0.Race &&
                   gclass146_0.gclass202_0 == this.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class595
    {
        public GameRace gclass21_0;
        public PopulationData gclass146_0;

        internal bool method_0(NavalAdminCommand gclass83_0)
        {
            return gclass83_0.Race == this.gclass21_0 && gclass83_0.ParentAdminCommand == null;
        }

        internal bool method_1(ShipClass gclass22_0)
        {
            return gclass22_0.Race == this.gclass21_0;
        }

        internal bool method_2(GClass193 gclass193_0)
        {
            return gclass193_0.gclass146_0 == this.gclass146_0 &&
                   gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Naval;
        }

        internal bool method_3(GClass193 gclass193_0)
        {
            return gclass193_0.gclass146_0 == this.gclass146_0 &&
                   gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Commercial;
        }
    }

    [CompilerGenerated]
    private sealed class Class596
    {
        public RaceOperationalGroupElement gclass11_0;

        internal bool method_0(ShipClass gclass22_0)
        {
            return gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID == this.gclass11_0.AutomatedClassDesign.AutomatedClassDesignTypeID;
        }
    }

    [CompilerGenerated]
    private sealed class Class597
    {
        public AlienRaceInfo gclass110_0;
        public List<int> list_0;

        internal bool method_0(ShipClass gclass22_0)
        {
            return gclass22_0.Race == this.gclass110_0.ActualAlienRace && gclass22_0.Obsolete == 0 &&
                   !this.list_0.Contains(gclass22_0.ShipClassID);
        }
    }

    [CompilerGenerated]
    private sealed class Class598
    {
        public AlienRaceInfo gclass110_0;

        internal bool method_0(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass164_0.method_1(this.gclass110_0.ActualAlienRace) &&
                   gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.ActiveSearchSensors;
        }
    }

    [CompilerGenerated]
    private sealed class Class599
    {
        public ShipComponent gclass230_0;

        internal bool method_0(ShipComponent gclass230_1)
        {
            return gclass230_1.int_0 == this.gclass230_0.int_14;
        }
    }

    [CompilerGenerated]
    private sealed class Class600
    {
        public ClassComponentTemplate186 gclass186_0;

        internal bool method_0(ShipComponent gclass230_0)
        {
            return gclass230_0.int_0 == this.gclass186_0.StandardComponentID;
        }

        internal bool method_1(GClass185 gclass185_0)
        {
            return gclass185_0.int_0 == this.gclass186_0.ShipComponentTemplateID;
        }
    }

    [CompilerGenerated]
    private sealed class Class601
    {
        public GClass185 gclass185_0;

        internal bool method_0(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass185_0 == this.gclass185_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class602
    {
        public GClass185 gclass185_0;

        internal bool method_0(GClass185 gclass185_1)
        {
            return gclass185_1.int_0 == this.gclass185_0.int_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class603
    {
        public int int_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.TechSystemID == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class604
    {
        public GameRace gclass21_0;
        public TechSystem gclass164_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0;
        }

        internal bool method_1(ResearchProject gclass161_0)
        {
            return gclass161_0.gclass164_0.gclass163_0 == this.gclass164_0.gclass163_0;
        }

        internal bool method_2(PausedResearch gclass167_0)
        {
            return gclass167_0.gclass164_0 == this.gclass164_0;
        }

        internal bool method_3(PausedResearch gclass167_0)
        {
            return gclass167_0.gclass164_0.gclass163_0 == this.gclass164_0.gclass163_0;
        }

        internal bool method_4(TechSystem gclass164_1)
        {
            return gclass164_1.gclass163_0 == this.gclass164_0.gclass163_0 &&
                   !gclass164_1.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && !gclass164_1.bool_4;
        }
    }

    [CompilerGenerated]
    private sealed class Class605
    {
        public ShipClass gclass22_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0 == this.gclass22_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class606
    {
        public List<PopulationData> list_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return this.list_0.Contains(gclass103_0.PopulationData);
        }
    }

    [CompilerGenerated]
    private sealed class Class607
    {
        public GroundUnitFormationData gclass103_0;
        public Func<GroundUnitFormationData, bool> func_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.PopulationData == this.gclass103_0.PopulationData;
        }
    }

    [CompilerGenerated]
    private sealed class Class608
    {
        public GroundUnitFormationElement gclass39_0;

        internal bool method_0(GroundUnitFormationElement gclass39_1)
        {
            return gclass39_1.GroundUnitClass.gclass95_0.UnitSeriesData == this.gclass39_0.GroundUnitClass.gclass95_0.UnitSeriesData;
        }

        internal bool method_1(GroundUnitFormationElement gclass39_1)
        {
            return gclass39_1.GroundUnitClass.gclass95_0.UnitSeriesData == this.gclass39_0.GroundUnitClass.gclass95_0.UnitSeriesData;
        }
    }

    [CompilerGenerated]
    private sealed class Class609
    {
        public int int_0;
        public GClass205 gclass205_0;

        internal bool method_0(GClass205 gclass205_1)
        {
            return gclass205_1.int_0 == this.gclass205_0.int_0 + this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class610
    {
        public GClass205 gclass205_0;

        internal bool method_0(KeyValuePair<int, GClass205> keyValuePair_0)
        {
            return keyValuePair_0.Key <= this.gclass205_0.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class611
    {
        public ShipData gclass40_0;
        public GameRace gclass21_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.ContactID == this.gclass40_0.int_8 && gclass65_0.DetectRace == this.gclass21_0 &&
                   gclass65_0.LastUpdate == this.gclass21_0.gclass0_0.GameTime;
        }

        internal bool method_1(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class612
    {
        public PopulationData gclass146_0;
        public GameRace gclass21_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.ContactID == this.gclass146_0.PopulationID && gclass65_0.DetectRace == this.gclass21_0 &&
                   gclass65_0.LastUpdate == this.gclass21_0.gclass0_0.GameTime;
        }
    }

    [CompilerGenerated]
    private sealed class Class613
    {
        public GameRace gclass21_0;
        public Decimal decimal_0;
        public PopulationData gclass146_0;

        internal bool method_0(GClass153 gclass153_0)
        {
            return gclass153_0.decimal_1 > this.gclass21_0.gclass0_0.GameTime - this.decimal_0;
        }

        internal bool method_1(GClass153 gclass153_0)
        {
            return gclass153_0.gclass146_0 == this.gclass146_0;
        }

        internal bool method_2(FCTMassDriverPacket126 gclass126_0)
        {
            return gclass126_0.Race == this.gclass21_0;
        }

        internal bool method_3(FCTMassDriverPacket126 gclass126_0)
        {
            return gclass126_0.gclass146_0 == this.gclass146_0;
        }

        internal bool method_4(ShipData gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0;
        }

        internal bool method_5(MoveOrder gclass139_0)
        {
            return gclass139_0.Population == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class614
    {
        public List<MineralUsage> list_0;

        internal bool method_0(MineralUsageData gclass154_0)
        {
            return this.list_0.Contains(gclass154_0.MineralUsage) && gclass154_0.Income;
        }

        internal bool method_1(MineralUsageData gclass154_0)
        {
            return this.list_0.Contains(gclass154_0.MineralUsage) && !gclass154_0.Income;
        }
    }

    [CompilerGenerated]
    private sealed class Class615
    {
        public MineralUsageData gclass154_0;
    }

    [CompilerGenerated]
    private sealed class Class616
    {
        public AuroraElement auroraElement_0;
        public GameRace.Class615 class615_0;

        internal bool method_0(GClass155 gclass155_0)
        {
            return gclass155_0.genum85_0 == this.class615_0.gclass154_0.MineralUsage &&
                   gclass155_0.auroraElement_0 == this.auroraElement_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class617
    {
        public MineralUsageData gclass154_0;
    }

    [CompilerGenerated]
    private sealed class Class618
    {
        public AuroraElement auroraElement_0;
        public GameRace.Class617 class617_0;

        internal bool method_0(GClass155 gclass155_0)
        {
            return gclass155_0.genum85_0 == this.class617_0.gclass154_0.MineralUsage &&
                   gclass155_0.auroraElement_0 == this.auroraElement_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class619
    {
        public StarSystem gclass200_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class620
    {
        public List<GameRace> list_0;
        public List<SystemBodyData> list_1;

        internal bool method_0(PopulationData gclass146_0)
        {
            return this.list_0.Contains(gclass146_0.Race);
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return !this.list_0.Contains(gclass146_0.Race);
        }

        internal bool method_2(SystemBodyData gclass1_0)
        {
            return this.list_1.Contains(gclass1_0.ParentBodyData) && gclass1_0.BodyClass == PlanetBodyClass.Moon;
        }
    }

    [CompilerGenerated]
    private sealed class Class621
    {
        public GameRace gclass21_0;
        public PopulationData gclass146_0;

        internal bool method_0(PopulationData gclass146_1)
        {
            return gclass146_1.Race == this.gclass21_0;
        }

        internal bool method_1(RacialSystemBodySurvey gclass215_0)
        {
            return gclass215_0.Race == this.gclass21_0;
        }

        internal bool method_2(SurveyLocation gclass213_0)
        {
            return gclass213_0.RaceIDs.Contains(this.gclass21_0.RaceID);
        }

        internal bool method_3(GClass165 gclass165_0)
        {
            return gclass165_0.gclass21_0 == this.gclass21_0;
        }

        internal bool method_4(ShipClass gclass22_0)
        {
            return gclass22_0.Race == this.gclass21_0;
        }

        internal bool method_5(GroundUnitFormationTemplateData gclass102_0)
        {
            return gclass102_0.RaceData == this.gclass21_0;
        }

        internal bool method_6(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData == this.gclass146_0;
        }

        internal bool method_7(FleetData gclass85_0)
        {
            return gclass85_0.AssignedPopulation == this.gclass146_0;
        }

        internal bool method_8(GClass55 gclass55_0)
        {
            return gclass55_0.gclass21_0 == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class622
    {
        public List<StarSystem> list_0;

        internal bool method_0(JumpPoint gclass120_0)
        {
            return this.list_0.Contains(gclass120_0.SystemData);
        }
    }

    [CompilerGenerated]
    private sealed class Class623
    {
        public GroundUnitFormationTemplateData gclass102_0;

        internal bool method_0(RankThemeEntry gclass61_0)
        {
            return gclass61_0.RankNum == this.gclass102_0.RequiredRankData.RankNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class624
    {
        public GClass62 gclass62_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.gclass62_0 == this.gclass62_0;
        }

        internal bool method_1(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.gclass62_0 == this.gclass62_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class625
    {
        public GameRace gclass21_0;
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.ShippingLine != null && gclass85_0.Race == this.gclass21_0;
        }

        internal bool method_1(MoveOrder gclass139_0)
        {
            return gclass139_0.StartSystem == this.gclass202_0 || gclass139_0.NewSystem == this.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class626
    {
        public GameRace gclass21_0;
        public JumpPoint gclass120_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.ShippingLine != null && gclass85_0.Race == this.gclass21_0;
        }

        internal bool method_1(MoveOrder gclass139_0)
        {
            return gclass139_0.MoveActionType.TransitOrder && gclass139_0.DestinationID == this.gclass120_0.WarpPointID;
        }
    }

    [CompilerGenerated]
    private sealed class Class627
    {
        public GameRace gclass21_0;
        public PopulationData gclass146_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.ShippingLine != null && gclass85_0.Race == this.gclass21_0;
        }

        internal bool method_1(MoveOrder gclass139_0)
        {
            return gclass139_0.Population == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class628
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

    [CompilerGenerated]
    private sealed class Class629
    {
        public GameRace gclass21_0;
        public PopulationData gclass146_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass21_0;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass21_0;
        }

        internal bool method_2(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData == this.gclass146_0;
        }

        internal bool method_3(MoveOrder gclass139_0)
        {
            return gclass139_0.Population == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class630
    {
        public SubFleet gclass84_0;
        public FCTSquadronData70 gclass70_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass84_0 == this.gclass84_0;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.SquadronData == this.gclass70_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class631
    {
        public ShipData gclass40_0;

        internal bool method_0(ShipData gclass40_1)
        {
            return gclass40_1 == this.gclass40_0 || gclass40_1.gclass40_0 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class632
    {
        public TechSystem gclass164_0;
        public GameRace gclass21_0;

        internal bool method_0(TechSystem gclass164_1)
        {
            return gclass164_1.gclass163_0 == this.gclass164_0.gclass163_0 &&
                   !gclass164_1.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass164_1.int_4 <= this.gclass164_0.int_4 && !gclass164_1.bool_4 && !gclass164_1.bool_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class633
    {
        public GameRace gclass21_0;
        public List<ShipData> list_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.bool_4 && gclass55_0.gclass21_0 != this.gclass21_0;
        }

        internal bool method_1(GClass55 gclass55_0)
        {
            return this.list_0.Contains(gclass55_0.gclass40_0);
        }

        internal bool method_2(GroundUnitFormationData gclass103_0)
        {
            return this.list_0.Contains(gclass103_0.ShipData);
        }
    }

    [CompilerGenerated]
    private sealed class Class634
    {
        public RaceMissile gclass129_0;

        internal bool method_0(PopOrdnanceStock gclass130_0)
        {
            return gclass130_0.RaceMissile == this.gclass129_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class635
    {
        public Species gclass194_0;

        internal bool method_0(TransportedColonist gclass181_0)
        {
            return gclass181_0.Species == this.gclass194_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class636
    {
        public GameRace gclass21_0;

        internal bool method_0(Survivors gclass180_0)
        {
            return gclass180_0.Race == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class637
    {
        public PlanetaryInstallationType gclass157_0;

        internal bool method_0(PopulationInstallation gclass158_0)
        {
            return gclass158_0.InstallationType == this.gclass157_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class638
    {
        public ShipComponent gclass230_0;

        internal bool method_0(TransportedComponent gclass73_0)
        {
            return gclass73_0.Component == this.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class639
    {
        public AuroraElement auroraElement_0;

        internal bool method_0(SingleMineralValue gclass125_0)
        {
            return gclass125_0.auroraElement_0 == this.auroraElement_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class640
    {
        public TechSystem gclass164_0;

        internal bool method_0(ShipTechData182 gclass182_0)
        {
            return gclass182_0.TechData == this.gclass164_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class641
    {
        public GameRace gclass21_0;
        public MissileSalvo gclass132_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.gclass21_0 && gclass65_0.ContactMethod == ContactDetectMethod.const_0 &&
                   gclass65_0.ContactType == AuroraContactType.Salvo &&
                   gclass65_0.ContactID == this.gclass132_0.int_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class642
    {
        public CommanderNameThemeData gclass58_0;

        internal bool method_0(CommanderNameDefinition gclass57_0)
        {
            return gclass57_0.CommanderNameTheme == this.gclass58_0 && gclass57_0.AllowedForLastName;
        }
    }

    [CompilerGenerated]
    private sealed class Class643
    {
        public Star197 gclass197_0;
        public CheckState checkState_0;
        public Species gclass194_0;
        public CheckState checkState_1;
        public CheckState checkState_2;
        public CheckState checkState_3;
        public CheckState checkState_4;
        public CheckState checkState_5;
        public GameRace gclass21_0;
        public CheckState checkState_6;
        public Decimal decimal_0;
        public Decimal decimal_1;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.StarData == this.gclass197_0 && !gclass1_0.IsFixedBody;
        }

        internal bool method_1(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.gclass110_0 == null || this.checkState_0 == CheckState.Unchecked;
        }

        internal bool method_2(SystemBodyData gclass1_0)
        {
            return gclass1_0.Gravity >= this.gclass194_0.double_7 && gclass1_0.Gravity <= this.gclass194_0.double_8 ||
                   this.checkState_1 == CheckState.Unchecked;
        }

        internal bool method_3(SystemBodyData gclass1_0)
        {
            return gclass1_0.BodyTypeId != AuroraSystemBodyType.GasGiant &&
                gclass1_0.BodyTypeId != AuroraSystemBodyType.Superjovian || this.checkState_2 == CheckState.Unchecked;
        }

        internal bool method_4(SystemBodyData gclass1_0)
        {
            return gclass1_0.method_13() || this.checkState_3 == CheckState.Unchecked;
        }

        internal bool method_5(SystemBodyData gclass1_0)
        {
            return gclass1_0.HydroExtent > 0.0 || this.checkState_4 == CheckState.Unchecked;
        }

        internal bool method_6(SystemBodyData gclass1_0)
        {
            return gclass1_0.HydroExtent >= 20.0 || this.checkState_5 == CheckState.Unchecked;
        }

        internal bool method_7(SystemBodyData gclass1_0)
        {
            return gclass1_0.MineralDeposits.Count > 0 && gclass1_0.method_77(this.gclass21_0) ||
                   this.checkState_6 == CheckState.Unchecked;
        }

        internal bool method_8(SystemBodyData gclass1_0)
        {
            return gclass1_0.PopulationCapacity_Probably >= this.decimal_0;
        }

        internal bool method_9(SystemBodyData gclass1_0)
        {
            return gclass1_0.ColonyCost <= this.decimal_1 && gclass1_0.ColonyCost >= 0M;
        }

        internal bool method_10(SystemBodyData gclass1_0)
        {
            return gclass1_0.MaxColonyCost <= this.decimal_1 && gclass1_0.ColonyCost >= 0M;
        }
    }

    [CompilerGenerated]
    private sealed class Class644
    {
        public List<StarSystem> list_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return this.list_0.Contains(gclass1_0.SystemData);
        }
    }

    [CompilerGenerated]
    private sealed class Class645
    {
        public CommanderNameThemeData gclass58_0;

        internal bool method_0(RaceNameTheme gclass45_0)
        {
            return gclass45_0.CommanderNameThemeData == this.gclass58_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class646
    {
        public CommanderNameThemeData gclass58_0;

        internal bool method_0(RaceNameTheme gclass45_0)
        {
            return gclass45_0.CommanderNameThemeData == this.gclass58_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class647
    {
        public int int_0;

        internal bool method_0(RaceNameTheme gclass45_0)
        {
            return gclass45_0.int_1 >= this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class648
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(OrderTemplateData gclass144_0)
        {
            return gclass144_0.RaceSystem == this.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class649
    {
        public ShipClass gclass22_0;

        internal bool method_0(GClass115 gclass115_0)
        {
            return gclass115_0.gclass22_0 == this.gclass22_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class650
    {
        public GameRace gclass21_0;
        public bool bool_0;

        internal bool method_0(RaceMissile gclass129_0)
        {
            return gclass129_0.TechSystem.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_1(RaceMissile gclass129_0)
        {
            return gclass129_0.TechSystem.dictionary_0[this.gclass21_0.RaceID].bool_0 == this.bool_0;
        }

        internal bool method_2(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass230_0.bool_4;
        }

        internal bool method_3(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 == this.bool_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class651
    {
        public StarSystem gclass200_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.ActualSystem == this.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class652
    {
        public PopulationData gclass146_0;

        internal bool method_0(ResearchQueue gclass166_0)
        {
            return gclass166_0.Population == this.gclass146_0;
        }

        internal bool method_1(GClass62 gclass62_0)
        {
            return gclass62_0.gclass146_0 == this.gclass146_0;
        }

        internal bool method_2(NavalAdminCommand gclass83_0)
        {
            return gclass83_0.gclass146_0 == this.gclass146_0;
        }

        internal bool method_3(Contact gclass65_0)
        {
            return gclass65_0.TargetPopulation == this.gclass146_0;
        }

        internal bool method_4(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass146_0.Race;
        }

        internal bool method_5(FleetData gclass85_0)
        {
            return gclass85_0.AssignedPopulation == this.gclass146_0;
        }

        internal bool method_6(GClass193 gclass193_0)
        {
            return gclass193_0.gclass146_0 == this.gclass146_0;
        }

        internal bool method_7(GClass192 gclass192_0)
        {
            return gclass192_0.gclass146_0 == this.gclass146_0;
        }

        internal bool method_8(GClass55 gclass55_0)
        {
            return gclass55_0.gclass146_0 == this.gclass146_0 || gclass55_0.gclass146_1 == this.gclass146_0 ||
                   gclass55_0.gclass146_3 == this.gclass146_0;
        }

        internal bool method_9(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData == this.gclass146_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class653
    {
        public List<int> list_0;
        public GameRace.Class652 class652_0;

        internal bool method_0(MoveOrder gclass139_0)
        {
            if (gclass139_0.Population == this.class652_0.gclass146_0)
                return true;
            return gclass139_0.DestinationType == DestinationType.const_4 && this.list_0.Contains(gclass139_0.DestinationID);
        }
    }

    [CompilerGenerated]
    private sealed class Class654
    {
        public GameRace gclass21_0;
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0 && gclass146_0.gclass202_0 == this.gclass202_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class655
    {
        public GameRace gclass21_0;
        public RacialSystemSurvey gclass202_0;
        public double double_0;
        public double double_1;

        internal bool method_0(RacialSystemBodySurvey gclass215_0)
        {
            return gclass215_0.Race == this.gclass21_0 &&
                   gclass215_0.SystemBody.SystemData == this.gclass202_0.ActualSystem;
        }

        internal bool method_1(MoveOrder gclass139_0)
        {
            return gclass139_0.MoveActionType.MoveActionType == MoveActionType.GeologicalSurvey &&
                   gclass139_0.StartSystem.ActualSystem == this.gclass202_0.ActualSystem;
        }

        internal SystemBodyData method_2(MoveOrder gclass139_0)
        {
            return this.gclass21_0.gclass0_0.SystemBodyRecordDic[gclass139_0.DestinationID];
        }

        internal bool method_3(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass202_0.ActualSystem && !gclass1_0.IsFixedBody;
        }

        internal double method_4(SystemBodyData gclass1_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass1_0.XCoordinate,
                gclass1_0.YCoordinate);
        }
    }

    [CompilerGenerated]
    private sealed class Class656
    {
        public List<GameRace> list_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return this.list_0.Contains(gclass85_0.Race);
        }
    }

    [CompilerGenerated]
    private sealed class Class657
    {
        public GameRace gclass21_0;
        public RacialSystemSurvey gclass202_0;
        public double double_0;
        public double double_1;

        internal bool method_0(SurveyLocation gclass213_0)
        {
            return gclass213_0.RaceIDs.Contains(this.gclass21_0.RaceID);
        }

        internal bool method_1(MoveOrder gclass139_0)
        {
            return gclass139_0.MoveActionType.MoveActionType == MoveActionType.GravitationalSurvey &&
                   gclass139_0.StartSystem.ActualSystem == this.gclass202_0.ActualSystem;
        }

        internal SurveyLocation method_2(MoveOrder gclass139_0)
        {
            return this.gclass202_0.ActualSystem.SurveyLocationDictionary[gclass139_0.DestinationID];
        }

        internal double method_3(SurveyLocation gclass213_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass213_0.XCoord,
                gclass213_0.YCoord);
        }
    }

    [CompilerGenerated]
    private sealed class Class658
    {
        public List<GameRace> list_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return this.list_0.Contains(gclass85_0.Race);
        }
    }

    [CompilerGenerated]
    private sealed class Class659
    {
        public RacialSystemSurvey gclass202_0;
        public GameRace gclass21_0;
        public Decimal decimal_0;
        public double double_0;
        public double double_1;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0 && gclass146_0.FuelStockpile > 0M;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.method_62(AuroraProductionCategory.MaintenanceFacility) *
                this.gclass21_0.MaintenanceCapacity > this.decimal_0;
        }

        internal double method_2(PopulationData gclass146_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class660
    {
        public RacialSystemSurvey gclass202_0;
        public Decimal decimal_0;
        public double double_0;
        public double double_1;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0 && gclass146_0.gclass6_0.decimal_0 > this.decimal_0 &&
                   gclass146_0.bAutoRefuel;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0 && gclass146_0.FuelStockpile > 0M && gclass146_0.bAutoRefuel;
        }

        internal double method_2(PopulationData gclass146_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class661
    {
        public RacialSystemSurvey gclass202_0;
        public double double_0;
        public double double_1;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.System == this.gclass202_0;
        }

        internal double method_1(FleetData gclass85_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass85_0.XCoord,
                gclass85_0.YCoord);
        }
    }

    [CompilerGenerated]
    private sealed class Class662
    {
        public RacialSystemSurvey gclass202_0;
        public double double_0;
        public double double_1;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.System == this.gclass202_0;
        }

        internal double method_1(FleetData gclass85_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass85_0.XCoord,
                gclass85_0.YCoord);
        }
    }

    [CompilerGenerated]
    private sealed class Class663
    {
        public RacialSystemSurvey gclass202_0;
        public double double_0;
        public double double_1;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0 && gclass146_0.MaintenanceStockpile > 0M &&
                   gclass146_0.FuelStockpile > 0M && gclass146_0.bAutoRefuel;
        }

        internal double method_1(PopulationData gclass146_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class664
    {
        public RacialSystemSurvey gclass202_0;
        public Decimal decimal_0;
        public double double_0;
        public double double_1;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0 && gclass146_0.MaintenanceStockpile > this.decimal_0;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0 && gclass146_0.MaintenanceStockpile > 0M;
        }

        internal double method_2(PopulationData gclass146_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class665
    {
        public RacialSystemSurvey gclass202_0;
        public GameRace gclass21_0;
        public double double_0;
        public double double_1;

        internal bool method_0(GClass193 gclass193_0)
        {
            return gclass193_0.gclass146_0.gclass202_0 == this.gclass202_0 &&
                   gclass193_0.auroraShipyardType_0 == this.gclass21_0.UnknownNprClass.auroraShipyardType_0 &&
                   gclass193_0.decimal_0 >= this.gclass21_0.UnknownNprClass.decimal_4;
        }

        internal double method_1(PopulationData gclass146_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class666
    {
        public RacialSystemSurvey gclass202_0;
    }

    [CompilerGenerated]
    private sealed class Class667
    {
        public PopOrdnanceStock gclass130_0;
        public GameRace.Class666 class666_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.class666_0.gclass202_0 &&
                   gclass146_0.gclass6_0.dictionary_0.ContainsKey(this.gclass130_0.RaceMissile);
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.gclass6_0.dictionary_0[this.gclass130_0.RaceMissile].Amount >=
                   this.gclass130_0.Amount / 2.0;
        }

        internal int method_2(PopulationData gclass146_0)
        {
            return gclass146_0.gclass6_0.dictionary_0[this.gclass130_0.RaceMissile].Amount;
        }
    }

    [CompilerGenerated]
    private sealed class Class668
    {
        public RacialSystemSurvey gclass202_0;
        public double double_0;
        public double double_1;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0;
        }

        internal double method_1(PopulationData gclass146_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class669
    {
        public RacialSystemSurvey gclass202_0;
        public ShipClass gclass22_0;
        public double double_0;
        public double double_1;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.System == this.gclass202_0;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.NPRSomething.method_8(this.gclass22_0);
        }

        internal double method_2(FleetData gclass85_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass85_0.XCoord,
                gclass85_0.YCoord);
        }
    }

    [CompilerGenerated]
    private sealed class Class670
    {
        public RacialSystemSurvey gclass202_0;
        public double double_0;
        public double double_1;

        internal bool method_0(JumpPoint gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass202_0.ActualSystem;
        }

        internal bool method_1(JumpPoint gclass120_0)
        {
            return gclass120_0.method_3(this.gclass202_0.Race);
        }

        internal double method_2(JumpPoint gclass120_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass120_0.XCoord,
                gclass120_0.YCoord);
        }
    }

    [CompilerGenerated]
    private sealed class Class671
    {
        public RacialSystemSurvey gclass202_0;
        public double double_0;
        public double double_1;

        internal bool method_0(JumpPoint gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass202_0.ActualSystem;
        }

        internal bool method_1(JumpPoint gclass120_0)
        {
            return gclass120_0.method_3(this.gclass202_0.Race);
        }

        internal double method_2(JumpPoint gclass120_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass120_0.XCoord,
                gclass120_0.YCoord);
        }
    }

    [CompilerGenerated]
    private sealed class Class672
    {
        public RacialSystemSurvey gclass202_0;
        public FleetData gclass85_0;
        public double double_0;
        public double double_1;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0 && gclass146_0.ColonistDestinationSetting == PopColonistSetting.Source &&
                   (this.gclass85_0.ShippingLine == null || !gclass146_0.bMilitaryRestrictedColony) &&
                   gclass146_0.PopulationPoliticalStatus.PoliticalStatusType == PopPoliticalStatusType.ImperialPopulation;
        }

        internal double method_1(PopulationData gclass146_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class673
    {
        public Decimal decimal_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.method_44() >= this.decimal_0 / 1000000M;
        }
    }

    [CompilerGenerated]
    private sealed class Class674
    {
        public GameRace gclass21_0;
        public RacialSystemSurvey gclass202_0;
        public double double_0;
        public double double_1;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0 && gclass146_0.decimal_30 > 0M;
        }

        internal double method_1(PopulationData gclass146_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class675
    {
        public GameRace gclass21_0;
        public bool bool_0;
        public RacialSystemSurvey gclass202_0;
        public double double_0;
        public double double_1;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0 && gclass146_0.decimal_30 == 0M;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            if (gclass146_0.method_73(AuroraInstallationType.Mine) > 0 && !this.bool_0)
                return true;
            return gclass146_0.method_73(AuroraInstallationType.AutomatedMine) > 0 && this.bool_0;
        }

        internal double method_2(PopulationData gclass146_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class676
    {
        public RacialSystemSurvey gclass202_0;
        public FleetData gclass85_0;
        public GameRace gclass21_0;
        public double double_0;
        public double double_1;

        internal bool method_0(FleetData gclass85_1)
        {
            return gclass85_1.Race == this.gclass21_0;
        }

        internal bool method_1(MoveOrder gclass139_0)
        {
            return gclass139_0.StartSystem == this.gclass202_0 &&
                   gclass139_0.MoveActionType.MoveActionType == MoveActionType.UnloadColonists;
        }

        internal PopulationData method_2(MoveOrder gclass139_0)
        {
            return this.gclass21_0.gclass0_0.Populations[gclass139_0.Population.PopulationID];
        }

        internal double method_3(PopulationData gclass146_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class677
    {
        public Species gclass194_0;
        public Decimal decimal_0;
        public GameRace.Class676 class676_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            if (gclass146_0.gclass202_0 != this.class676_0.gclass202_0 || gclass146_0.Species != this.gclass194_0 ||
                gclass146_0.SystemBodyData.BodyClass == PlanetBodyClass.Comet)
                return false;
            return this.class676_0.gclass85_0.ShippingLine == null || !gclass146_0.bMilitaryRestrictedColony;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.method_43(this.class676_0.gclass85_0) > this.decimal_0;
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.method_43(this.class676_0.gclass85_0) > this.decimal_0;
        }

        internal bool method_3(PopulationData gclass146_0)
        {
            return gclass146_0.method_43(this.class676_0.gclass85_0) > this.decimal_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class678
    {
        public RacialSystemSurvey gclass202_0;
        public FleetData gclass85_0;
        public double double_0;
        public double double_1;

        internal bool method_0(PopulationData gclass146_0)
        {
            if (gclass146_0.gclass202_0 != this.gclass202_0 || !(gclass146_0.Population > AuroraUtils.decimal_12))
                return false;
            return this.gclass85_0.ShippingLine == null || !gclass146_0.bMilitaryRestrictedColony;
        }

        internal double method_1(PopulationData gclass146_0)
        {
            return this.gclass202_0.ActualSystem.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class679
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0 == this.gclass202_0 && gclass146_0.bIsCapital;
        }
    }

    [CompilerGenerated]
    private sealed class Class680
    {
        public AuroraStandingOrderGroup auroraStandingOrderGroup_0;

        internal bool method_0(StandingOrderDefinition gclass136_0)
        {
            return gclass136_0.auroraStandingOrderGroup_0 == this.auroraStandingOrderGroup_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class681
    {
        public GameRace gclass21_0;
        public AutomatedGroundTemplateDesignType genum116_0;

        internal bool method_0(GroundUnitFormationTemplateData gclass102_0)
        {
            return gclass102_0.RaceData == this.gclass21_0 && gclass102_0.AutomatedTemplateType == this.genum116_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class682
    {
        public SpecialNPRIDs genum6_0;

        internal bool method_0(Species gclass194_0)
        {
            return gclass194_0.genum6_0 == this.genum6_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class683
    {
        public List<StarSystem> list_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return this.list_0.Contains(gclass202_0.ActualSystem);
        }
    }

    [CompilerGenerated]
    private sealed class Class684
    {
        public GClass211 gclass211_0;

        internal bool method_0(RacialSystemSurvey gclass202_0)
        {
            return gclass202_0.ActualSystem == this.gclass211_0.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class685
    {
        public GameRace gclass21_0;
        public AlienRaceInfo gclass110_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.gclass21_0 &&
                   gclass65_0.LastUpdate == this.gclass21_0.gclass0_0.GameTime;
        }

        internal bool method_1(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.gclass21_0 &&
                   gclass65_0.LastUpdate == this.gclass21_0.gclass0_0.GameTime;
        }

        internal bool method_2(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.gclass21_0 &&
                   gclass65_0.LastUpdate == this.gclass21_0.gclass0_0.GameTime &&
                   gclass65_0.ContactRace == this.gclass110_0.ActualAlienRace;
        }
    }

    [CompilerGenerated]
    private sealed class Class686
    {
        public GameRace gclass21_0;
        public StarSystem gclass200_0;
        public WayPointType wayPointType_0;
        public double double_0;
        public double double_1;
        public int int_0;

        internal bool method_0(Waypoint gclass214_0)
        {
            return gclass214_0.Race == this.gclass21_0 && gclass214_0.System == this.gclass200_0 &&
                   gclass214_0.WaypointType == this.wayPointType_0 &&
                   this.gclass21_0.gclass0_0.method_520(gclass214_0.Xcor, this.double_0, gclass214_0.Ycor,
                       this.double_1);
        }

        internal bool method_1(Waypoint gclass214_0)
        {
            return gclass214_0.Race == this.gclass21_0 && gclass214_0.System == this.gclass200_0 &&
                   gclass214_0.WaypointType == this.wayPointType_0 &&
                   this.gclass21_0.gclass0_0.method_521(gclass214_0.Xcor, this.double_0, gclass214_0.Ycor,
                       this.double_1, 5000000.0);
        }

        internal bool method_2(Waypoint gclass214_0)
        {
            return gclass214_0.FleetID == this.int_0;
        }

        internal bool method_3(Waypoint gclass214_0)
        {
            return gclass214_0.Race == this.gclass21_0 && gclass214_0.System == this.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class687
    {
        public GameRace gclass21_0;
        public GroundUnitBaseType genum112_0;

        internal bool method_0(ArmourTypeData gclass97_0)
        {
            return gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass97_0.genum112_0 == this.genum112_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class688
    {
        public bool bool_0;
        public GameRace gclass21_0;

        internal bool method_0(GroundComponentTypeDefinition gclass100_0)
        {
            if (!gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) || !gclass100_0.Static)
                return false;
            return gclass100_0.STO == 0 || this.bool_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class689
    {
        public OrganizationNodeC93 gclass93_0;

        internal bool method_0(OrganizationNodeC93 gclass93_1)
        {
            return gclass93_1.ParentOrganizationNode == this.gclass93_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class690
    {
        public OrganizationNodeC93 gclass93_0;

        internal bool method_0(OrganizationNodeC93 gclass93_1)
        {
            return gclass93_1.ParentOrganizationNode == this.gclass93_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class691
    {
        public OrganizationNodeC93 gclass93_0;

        internal bool method_0(OrganizationNodeC93 gclass93_1)
        {
            return gclass93_1.ParentOrganizationNode == this.gclass93_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class692
    {
        public GameRace gclass21_0;
        public GroundUnitClass101 gclass101_0;

        internal bool method_0(GroundUnitClass101 gclass101_1)
        {
            return gclass101_1.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass101_1.genum115_0 == this.gclass101_0.genum115_0;
        }

        internal bool method_1(GroundUnitClass101 gclass101_1)
        {
            return gclass101_1.ArmourType == this.gclass101_0.ArmourType &&
                   gclass101_1.decimal_0 == this.gclass101_0.decimal_0 &&
                   gclass101_1.decimal_1 == this.gclass101_0.decimal_1 &&
                   gclass101_1.GroundUnitComponentList.Count == this.gclass101_0.GroundUnitComponentList.Count &&
                   gclass101_1.dictionary_0.Count == this.gclass101_0.dictionary_0.Count &&
                   gclass101_1.decimal_2 == this.gclass101_0.decimal_2 &&
                   gclass101_1.decimal_3 == this.gclass101_0.decimal_3 &&
                   gclass101_1.gclass230_0 == this.gclass101_0.gclass230_0 &&
                   gclass101_1.int_4 == this.gclass101_0.int_4 && gclass101_1.int_7 == this.gclass101_0.int_7 &&
                   gclass101_1.decimal_4 == this.gclass101_0.decimal_4 && gclass101_1.int_3 == this.gclass101_0.int_3 &&
                   gclass101_1.decimal_5 == this.gclass101_0.decimal_5 && gclass101_1.int_6 == this.gclass101_0.int_6 &&
                   gclass101_1.int_2 == this.gclass101_0.int_2 && gclass101_1.bool_0 == this.gclass101_0.bool_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class693
    {
        public GameRace gclass21_0;
        public GroundUnitFormationTemplateData gclass102_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass21_0 && gclass103_0.ReplacementTemplateData == this.gclass102_0;
        }

        internal bool method_1(OrganizationNodeC93 gclass93_0)
        {
            return gclass93_0.FormationTemplate == this.gclass102_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class694
    {
        public GameRace gclass21_0;
        public CheckState checkState_0;

        internal bool method_0(GroundUnitClass101 gclass101_0)
        {
            return gclass101_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_1(GroundUnitClass101 gclass101_0)
        {
            return !gclass101_0.TechData.dictionary_0[this.gclass21_0.RaceID].bool_0 ||
                   this.checkState_0 == CheckState.Checked;
        }

        internal bool method_2(GroundUnitFormationTemplateData gclass102_0)
        {
            return gclass102_0.RaceData == this.gclass21_0 && gclass102_0.AutomatedTemplateType != AutomatedGroundTemplateDesignType.CivilianGarrison;
        }

        internal bool method_3(GroundUnitFormationTemplateData gclass102_0)
        {
            return gclass102_0.RaceData == this.gclass21_0 && gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.CivilianGarrison;
        }
    }

    [CompilerGenerated]
    private sealed class Class695
    {
        public string string_0;

        internal bool method_0(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.Abbreviation == this.string_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class696
    {
        public GameRace gclass21_0;
        public CheckState checkState_0;
        public CheckState checkState_1;

        internal bool method_0(GroundUnitFormationTemplateData gclass102_0)
        {
            if (((gclass102_0.RaceData == this.gclass21_0 ? 1 : 0) &
                 (gclass102_0.Obsolete == 0 ? 1 : (this.checkState_0 == CheckState.Checked ? 1 : 0))) == 0)
                return false;
            return gclass102_0.AutomatedTemplateType != AutomatedGroundTemplateDesignType.CivilianGarrison || this.checkState_1 == CheckState.Checked;
        }
    }

    [CompilerGenerated]
    private sealed class Class697
    {
        public AuroraCommanderType auroraCommanderType_0;
        public GameRace gclass21_0;

        internal bool method_0(RankThemeEntry gclass61_0)
        {
            return gclass61_0.CommanderType == this.auroraCommanderType_0;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass187_0 == null;
        }
    }

    [CompilerGenerated]
    private sealed class Class698
    {
        public RankThemeEntry gclass61_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0 == this.gclass61_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class699
    {
        public AuroraCommanderType auroraCommanderType_0;

        internal bool method_0(RankThemeEntry gclass61_0)
        {
            return gclass61_0.CommanderType == this.auroraCommanderType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class700
    {
        public RankThemeEntry gclass61_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0 == this.gclass61_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class701
    {
        public RankThemeEntry gclass61_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0 == this.gclass61_0 && !gclass55_0.bool_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class702
    {
        public GameRace gclass21_0;
        public CommanderBonusType genum121_0;
        public Func<GClass55, Decimal> func_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.auroraCommanderType_0 == AuroraCommanderType.Naval &&
                   gclass55_0.gclass21_0 == this.gclass21_0 && gclass55_0.auroraCommandType_0 == AuroraCommandType.None;
        }

        internal Decimal method_1(GClass55 gclass55_0)
        {
            return gclass55_0.method_5(this.genum121_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class703
    {
        public ShipData gclass40_0;
        public GameRace.Class702 class702_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.dictionary_0.ContainsKey(this.class702_0.genum121_0) &&
                   gclass55_0.gclass61_0 == this.gclass40_0.gclass22_0.RankTheme;
        }
    }

    [CompilerGenerated]
    private sealed class Class704
    {
        public GameRace gclass21_0;
        public ShipData gclass40_0;
        public Func<GClass55, bool> func_0;
        public Func<GroundUnitFormationData, bool> func_1;

        internal bool method_0(ShipData gclass40_1)
        {
            return gclass40_1.gclass21_0 == this.gclass21_0 && gclass40_1.gclass187_0 == null &&
                   gclass40_1.gclass22_0.NoOfficers == 0;
        }

        internal bool method_1(ShipData gclass40_1)
        {
            return gclass40_1 == this.gclass40_0 && gclass40_1.gclass22_0.NoOfficers == 0;
        }

        internal bool method_2(GClass55 gclass55_0)
        {
            return gclass55_0.auroraCommanderType_0 == AuroraCommanderType.Naval &&
                   gclass55_0.gclass21_0 == this.gclass21_0 && gclass55_0.gclass59_0 == null && !gclass55_0.bool_4;
        }

        internal bool method_3(GClass55 gclass55_0)
        {
            return this.gclass21_0.gclass0_0.GameTime - gclass55_0.decimal_0 > AuroraUtils.decimal_29 &&
                   !gclass55_0.bool_0;
        }

        internal bool method_4(GClass55 gclass55_0)
        {
            return gclass55_0.auroraCommanderType_0 == AuroraCommanderType.Naval &&
                   gclass55_0.gclass21_0 == this.gclass21_0 &&
                   gclass55_0.auroraCommandType_0 == AuroraCommandType.None && gclass55_0.gclass59_0 == null &&
                   !gclass55_0.bool_4;
        }

        internal bool method_5(GClass55 gclass55_0)
        {
            return gclass55_0.auroraCommanderType_0 == AuroraCommanderType.GroundForce &&
                   gclass55_0.gclass21_0 == this.gclass21_0 && gclass55_0.gclass59_0 == null && !gclass55_0.bool_4;
        }

        internal bool method_6(GClass55 gclass55_0)
        {
            return this.gclass21_0.gclass0_0.GameTime - gclass55_0.decimal_0 > AuroraUtils.decimal_29 &&
                   !gclass55_0.bool_0;
        }

        internal bool method_7(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.gclass55_0 == null && gclass103_0.RaceData == this.gclass21_0;
        }

        internal bool method_8(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0;
        }

        internal bool method_9(GClass55 gclass55_0)
        {
            return gclass55_0.gclass21_0 == this.gclass21_0 &&
                   gclass55_0.auroraCommanderType_0 == AuroraCommanderType.Administrator;
        }
    }

    [CompilerGenerated]
    private sealed class Class705
    {
        public ShipData gclass40_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.dictionary_0.ContainsKey(this.gclass40_0.genum121_0) &&
                   gclass55_0.gclass61_0 == this.gclass40_0.gclass22_0.RankTheme;
        }

        internal Decimal method_1(GClass55 gclass55_0)
        {
            return gclass55_0.method_5(this.gclass40_0.genum121_0);
        }

        internal bool method_2(GClass55 gclass55_0)
        {
            return gclass55_0.dictionary_0.ContainsKey(this.gclass40_0.genum121_0) &&
                   gclass55_0.gclass61_0.RankNum < this.gclass40_0.gclass22_0.RankTheme.RankNum;
        }

        internal Decimal method_3(GClass55 gclass55_0)
        {
            return gclass55_0.method_5(this.gclass40_0.genum121_0);
        }

        internal bool method_4(GClass55 gclass55_0)
        {
            return gclass55_0.dictionary_0.ContainsKey(this.gclass40_0.genum121_0) &&
                   gclass55_0.gclass61_0 == this.gclass40_0.gclass22_0.RankTheme.method_3();
        }

        internal Decimal method_5(GClass55 gclass55_0)
        {
            return gclass55_0.method_5(this.gclass40_0.genum121_0) + gclass55_0.method_5(CommanderBonusType.PoliticalReliability);
        }
    }

    [CompilerGenerated]
    private sealed class Class706
    {
        public RankThemeEntry gclass61_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0 == this.gclass61_0;
        }

        internal bool method_1(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0 == this.gclass61_0;
        }

        internal bool method_2(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0 == this.gclass61_0;
        }

        internal bool method_3(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0 == this.gclass61_0;
        }

        internal bool method_4(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0 == this.gclass61_0;
        }

        internal bool method_5(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0 == this.gclass61_0;
        }

        internal bool method_6(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0 == this.gclass61_0;
        }

        internal bool method_7(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0 == this.gclass61_0;
        }

        internal bool method_8(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0 == this.gclass61_0;
        }

        internal bool method_9(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0 == this.gclass61_0;
        }

        internal bool method_10(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0 == this.gclass61_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class707
    {
        public PopulationData gclass146_0;
        public GameRace.Class704 class704_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.method_5(CommanderBonusType.ColonyAdmnistration) >= this.gclass146_0.int_17 &&
                   gclass55_0.decimal_1 < this.class704_0.gclass21_0.gclass0_0.GameTime;
        }
    }

    [CompilerGenerated]
    private sealed class Class708
    {
        public List<GClass51> list_0;

        internal Decimal method_0(GClass55 gclass55_0)
        {
            return gclass55_0.method_5(this.list_0[0].genum121_0);
        }

        internal Decimal method_1(GClass55 gclass55_0)
        {
            return gclass55_0.method_5(this.list_0[1].genum121_0);
        }

        internal Decimal method_2(GClass55 gclass55_0)
        {
            return gclass55_0.method_5(this.list_0[2].genum121_0);
        }

        internal Decimal method_3(GClass55 gclass55_0)
        {
            return gclass55_0.method_5(this.list_0[3].genum121_0);
        }

        internal Decimal method_4(GClass55 gclass55_0)
        {
            return gclass55_0.method_5(this.list_0[4].genum121_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class709
    {
        public AuroraCommandType auroraCommandType_0;
        public GEnum118 genum118_0;
        public CommanderBonusType genum121_0;
        public Func<GClass55, Decimal> func_0;
        public Func<GClass55, Decimal> func_1;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.method_192(this.auroraCommandType_0) == null &&
                   gclass40_0.gclass22_0.method_35(this.genum118_0);
        }

        internal Decimal method_1(GClass55 gclass55_0)
        {
            return gclass55_0.method_5(this.genum121_0);
        }

        internal Decimal method_2(GClass55 gclass55_0)
        {
            return gclass55_0.method_5(this.genum121_0) + gclass55_0.method_5(CommanderBonusType.PoliticalReliability);
        }
    }

    [CompilerGenerated]
    private sealed class Class710
    {
        public ShipData gclass40_0;
        public RankThemeEntry gclass61_0;
        public GameRace.Class709 class709_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.dictionary_0.ContainsKey(this.class709_0.genum121_0) &&
                   gclass55_0.gclass61_0 == this.gclass61_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class711
    {
        public RankThemeEntry gclass61_0;
        public GameRace.Class710 class710_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.dictionary_0.ContainsKey(this.class710_0.gclass40_0.genum121_0) &&
                   gclass55_0.gclass61_0 == this.gclass61_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class712
    {
        public GameRace gclass21_0;
        public AuroraCommanderType auroraCommanderType_0;
        public RankThemeEntry gclass61_0;
        public RankThemeEntry gclass61_1;
        public int int_0;
        public int int_1;
        public CommanderBonus gclass50_0;
        public CommanderBonus gclass50_1;
        public CommanderBonus gclass50_2;
        public CommanderBonus gclass50_3;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.gclass21_0 == this.gclass21_0 &&
                   gclass55_0.auroraCommanderType_0 == this.auroraCommanderType_0;
        }

        internal bool method_1(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0.RankNum <= this.gclass61_0.RankNum &&
                   gclass55_0.gclass61_0.RankNum >= this.gclass61_1.RankNum;
        }

        internal bool method_2(GClass55 gclass55_0)
        {
            return gclass55_0.gclass21_0 == this.gclass21_0 &&
                   (gclass55_0.auroraCommanderType_0 == this.auroraCommanderType_0 ||
                    this.auroraCommanderType_0 == AuroraCommanderType.All) &&
                   gclass55_0.method_5(CommanderBonusType.ColonyAdmnistration) >= this.int_0 &&
                   gclass55_0.method_5(CommanderBonusType.ColonyAdmnistration) <= this.int_1;
        }

        internal bool method_3(GClass55 gclass55_0)
        {
            if (gclass55_0.gclass21_0 != this.gclass21_0)
                return false;
            return gclass55_0.auroraCommanderType_0 == this.auroraCommanderType_0 ||
                   this.auroraCommanderType_0 == AuroraCommanderType.All;
        }

        internal Decimal method_4(GClass55 gclass55_0)
        {
            return gclass55_0.method_5(this.gclass50_0.CommanderBonusType);
        }

        internal Decimal method_5(GClass55 gclass55_0)
        {
            return gclass55_0.method_5(this.gclass50_1.CommanderBonusType);
        }

        internal Decimal method_6(GClass55 gclass55_0)
        {
            return gclass55_0.method_5(this.gclass50_2.CommanderBonusType);
        }

        internal Decimal method_7(GClass55 gclass55_0)
        {
            return gclass55_0.method_5(this.gclass50_3.CommanderBonusType);
        }
    }

    [CompilerGenerated]
    private sealed class Class713
    {
        public AuroraCommanderType auroraCommanderType_0;

        internal bool method_0(RankThemeEntry gclass61_0)
        {
            return gclass61_0.CommanderType == this.auroraCommanderType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class714
    {
        public RankThemeEntry gclass61_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0 == this.gclass61_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class715
    {
        public RankThemeEntry gclass61_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0 == this.gclass61_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class716
    {
        public ResearchFieldData gclass162_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.gclass162_0 == this.gclass162_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class717
    {
        public int int_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.method_5(CommanderBonusType.ColonyAdmnistration) == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class718
    {
        public GameRace gclass21_0;
        public StarSystem gclass200_0;
        public Func<TechSystem, bool> func_0;

        internal bool method_0(GClass16 gclass16_0)
        {
            return gclass16_0.int_1 == this.gclass21_0.DesignDoctrine.GroundForceDeploymentThemeID;
        }

        internal bool method_1(DIMDesignPhilosophyTechProgression gclass19_0)
        {
            return this.gclass21_0.DesignDoctrine.list_2.Contains(gclass19_0.TechProgressionCategoryID);
        }

        internal bool method_2(GClass12 gclass12_0)
        {
            return gclass12_0.genum90_0 == this.gclass21_0.DesignDoctrine.OperationGroupProgressionType;
        }

        internal bool method_3(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0;
        }

        internal bool method_4(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0 && gclass1_0.Radius < 200.0;
        }

        internal bool method_5(TechSystem gclass164_0)
        {
            return gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_6(TechSystem gclass164_0)
        {
            return gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }
    }

    [CompilerGenerated]
    private sealed class Class719
    {
        public GEnum118 genum118_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return (GEnum118)gclass164_0.TechSystemID == this.genum118_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class720
    {
        public TechTypeData gclass163_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.gclass163_0 == this.gclass163_0 && !gclass164_0.bool_4;
        }
    }

    [CompilerGenerated]
    private sealed class Class721
    {
        public TechTypeData gclass163_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return gclass164_0.gclass163_0 == this.gclass163_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class722
    {
        public RankThemeEntry gclass61_0;

        internal bool method_0(GClass55 gclass55_0)
        {
            return gclass55_0.gclass61_0 == this.gclass61_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class723
    {
        public AuroraCommanderType auroraCommanderType_0;

        internal bool method_0(RankThemeEntry gclass61_0)
        {
            return gclass61_0.CommanderType == this.auroraCommanderType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class724
    {
        public AuroraCommanderType auroraCommanderType_0;

        internal bool method_0(RankThemeEntry gclass61_0)
        {
            return gclass61_0.CommanderType == this.auroraCommanderType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class725
    {
        public AuroraCommanderType auroraCommanderType_0;

        internal bool method_0(RankThemeEntry gclass61_0)
        {
            return gclass61_0.CommanderType == this.auroraCommanderType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class726
    {
        public NavalAdminCommand gclass83_0;

        internal bool method_0(RankThemeEntry gclass61_0)
        {
            return gclass61_0.RankNum == this.gclass83_0.int_3 &&
                   gclass61_0.CommanderType == AuroraCommanderType.Naval;
        }
    }

    [CompilerGenerated]
    private sealed class Class727
    {
        public GClass55 gclass55_0;

        internal bool method_0(GClass55 gclass55_1)
        {
            return gclass55_1.gclass61_0 == this.gclass55_0.gclass61_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class728
    {
        public StarSystem gclass200_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class729
    {
        public GameRace gclass21_0;
        public EventType genum126_0;

        internal bool method_0(HideEventData gclass89_0)
        {
            return gclass89_0.RaceID == this.gclass21_0.RaceID && gclass89_0.EventType == this.genum126_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class730
    {
        public GameRace gclass21_0;
        public EventType genum126_0;

        internal bool method_0(HideEventData gclass89_0)
        {
            return gclass89_0.RaceID == this.gclass21_0.RaceID && gclass89_0.EventType == this.genum126_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class731
    {
        public ShipData gclass40_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class732
    {
        public int int_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0.int_8 == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class733
    {
        public ShipData gclass40_0;
        public GameRace gclass21_0;

        internal bool method_0(ShipClass gclass22_0)
        {
            return gclass22_0.OtherRaceClassID == this.gclass40_0.gclass22_0.ShipClassID;
        }

        internal bool method_1(ShipData gclass40_1)
        {
            return gclass40_1.gclass40_2 == this.gclass40_0;
        }

        internal bool method_2(GClass192 gclass192_0)
        {
            return gclass192_0.gclass40_0 == this.gclass40_0;
        }

        internal bool method_3(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0 == this.gclass40_0;
        }

        internal bool method_4(ShippingLineData gclass187_0)
        {
            return gclass187_0.gclass21_0 == this.gclass21_0;
        }

        internal bool method_5(ShipData gclass40_1)
        {
            return gclass40_1.gclass40_0 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class734
    {
        public GameRace gclass21_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class735
    {
        public GameRace gclass21_0;
        public SystemBodyData gclass1_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0 && gclass146_0.SystemBodyData == this.gclass1_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class736
    {
        public GameRace gclass21_0;
        public Species gclass194_0;
        public SystemBodyData gclass1_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0 && gclass146_0.Species == this.gclass194_0 &&
                   gclass146_0.SystemBodyData == this.gclass1_0;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.SystemBodyData == this.gclass1_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class737
    {
        public TechSystem gclass164_0;

        internal bool method_0(TechSystem gclass164_1)
        {
            return gclass164_1 == this.gclass164_0;
        }

        internal bool method_1(TechSystem gclass164_1)
        {
            return gclass164_1 == this.gclass164_0;
        }

        internal bool method_2(TechSystem gclass164_1)
        {
            return gclass164_1 == this.gclass164_0;
        }

        internal bool method_3(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass164_0 == this.gclass164_0;
        }

        internal bool method_4(RaceMissile gclass129_0)
        {
            return gclass129_0.TechSystem == this.gclass164_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class738
    {
        public TechSystem gclass164_0;
        public GameRace gclass21_0;

        internal bool method_0(PausedResearch gclass167_0)
        {
            return gclass167_0.gclass164_0 == this.gclass164_0;
        }

        internal bool method_1(ResearchQueue gclass166_0)
        {
            return gclass166_0.TechSystem == this.gclass164_0;
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0;
        }

        internal bool method_3(ResearchProject gclass161_0)
        {
            return gclass161_0.gclass164_0 == this.gclass164_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class739
    {
        public ResearchProject gclass161_0;

        internal bool method_0(ResearchQueue gclass166_0)
        {
            return gclass166_0.Population == this.gclass161_0.gclass146_0 &&
                   gclass166_0.CurrentProject == this.gclass161_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class740
    {
        public TechSystem gclass164_0;
        public GameRace gclass21_0;

        internal bool method_0(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass164_0 == this.gclass164_0 && gclass230_0.genum86_0 == GEnum86.const_3;
        }

        internal bool method_1(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass164_0 == this.gclass164_0 && gclass230_0.genum86_0 == GEnum86.const_1;
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0;
        }

        internal bool method_3(ResearchProject gclass161_0)
        {
            return gclass161_0.gclass164_0 == this.gclass164_0;
        }

        internal bool method_4(ResearchQueue gclass166_0)
        {
            return gclass166_0.TechSystem == this.gclass164_0;
        }

        internal bool method_5(PausedResearch gclass167_0)
        {
            return gclass167_0.gclass164_0 == this.gclass164_0;
        }

        internal bool method_6(ShippingLineData gclass187_0)
        {
            return gclass187_0.gclass21_0 == this.gclass21_0;
        }

        internal bool method_7(PopulationData gclass146_0)
        {
            return gclass146_0.bIsCapital && gclass146_0.Race == this.gclass21_0;
        }

        internal bool method_8(TechSystem gclass164_1)
        {
            return gclass164_1.bool_4 && gclass164_1.int_2 == this.gclass164_0.TechSystemID;
        }
    }

    [CompilerGenerated]
    private sealed class Class741
    {
        public AlienRaceInfo gclass110_0;
        public GameRace.Class740 class740_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return !gclass164_0.dictionary_0.ContainsKey(this.gclass110_0.ActualAlienRace.RaceID) &&
                   gclass164_0.gclass163_0 == this.class740_0.gclass164_0.gclass163_0 && !gclass164_0.bool_4;
        }
    }

    [CompilerGenerated]
    private sealed class Class742
    {
        public AlienRaceInfo gclass110_0;
        public GameRace.Class740 class740_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return !gclass164_0.dictionary_0.ContainsKey(this.gclass110_0.ActualAlienRace.RaceID) &&
                   gclass164_0.gclass163_0 == this.class740_0.gclass164_0.gclass163_0 && !gclass164_0.bool_4;
        }
    }

    [CompilerGenerated]
    private sealed class Class743
    {
        public AlienRaceInfo gclass110_0;
        public GameRace.Class740 class740_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.bIsCapital && gclass146_0.Race == this.gclass110_0.ActualAlienRace;
        }

        internal bool method_1(TechSystem gclass164_0)
        {
            return !gclass164_0.dictionary_0.ContainsKey(this.gclass110_0.ActualAlienRace.RaceID) &&
                   gclass164_0.gclass163_0 == this.class740_0.gclass164_0.gclass163_0 && !gclass164_0.bool_4;
        }
    }

    [CompilerGenerated]
    private sealed class Class744
    {
        public GameRace gclass21_0;
        public PopulationData gclass146_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.gclass21_0 &&
                   gclass65_0.LastUpdate == this.gclass21_0.gclass0_0.GameTime &&
                   gclass65_0.ContactType == AuroraContactType.Population &&
                   gclass65_0.ContactID == this.gclass146_0.PopulationID && gclass65_0.ContactMethod == ContactDetectMethod.const_1;
        }

        internal bool method_1(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.gclass21_0 &&
                   gclass65_0.LastUpdate == this.gclass21_0.gclass0_0.GameTime &&
                   gclass65_0.ContactType == AuroraContactType.Population &&
                   gclass65_0.ContactID == this.gclass146_0.PopulationID && gclass65_0.ContactMethod == ContactDetectMethod.const_3;
        }
    }

    [CompilerGenerated]
    private sealed class Class745
    {
        public string string_0;
        public int int_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.FleetName == this.string_0;
        }

        internal bool method_1(FleetData gclass85_0)
        {
            return gclass85_0.FleetName == $"{this.string_0} #{this.int_0}";
        }
    }

    [CompilerGenerated]
    private sealed class Class746
    {
        public FleetData gclass85_0;

        internal bool method_0(GClass192 gclass192_0)
        {
            return gclass192_0.gclass85_0 == this.gclass85_0;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.SpaceStationDestFleet == this.gclass85_0;
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.FighterDestFleet == this.gclass85_0;
        }

        internal bool method_3(SubFleet gclass84_0)
        {
            return gclass84_0.ParentFleet == this.gclass85_0;
        }

        internal bool method_4(FleetData gclass85_1)
        {
            return gclass85_1.AnchorFleet == this.gclass85_0;
        }

        internal bool method_5(SubFleet gclass84_0)
        {
            return gclass84_0.AnchorFleet == this.gclass85_0;
        }

        internal bool method_6(MoveOrder gclass139_0)
        {
            if (gclass139_0.DestinationType != DestinationType.const_7 || gclass139_0.DestinationID != this.gclass85_0.FleetID)
                return false;
            return gclass139_0.MoveActionType.MoveActionType != MoveActionType.TractorSpecifiedShip &&
                   gclass139_0.MoveActionType.MoveActionType != MoveActionType.TractorAnyShipInFleet &&
                   gclass139_0.MoveActionType.MoveActionType != MoveActionType.AbsorbTargetFleet ||
                   gclass139_0.Fleet.XCoord != this.gclass85_0.XCoord ||
                   gclass139_0.Fleet.YCoord != this.gclass85_0.YCoord;
        }

        internal bool method_7(FleetData gclass85_1)
        {
            return gclass85_1.AnchorFleet == this.gclass85_0;
        }

        internal bool method_8(SubFleet gclass84_0)
        {
            return gclass84_0.AnchorFleet == this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class747
    {
        public MoveOrder gclass139_0;

        internal bool method_0(MoveOrder gclass139_1)
        {
            return gclass139_1.MoveOrderID >= this.gclass139_0.MoveOrderID;
        }
    }

    [CompilerGenerated]
    private sealed class Class748
    {
        public ShipData gclass40_0;

        internal bool method_0(GClass192 gclass192_0)
        {
            return gclass192_0.gclass40_0 == this.gclass40_0;
        }

        internal bool method_1(GClass193 gclass193_0)
        {
            return gclass193_0.gclass40_1 == this.gclass40_0;
        }

        internal bool method_2(AcidAttack gclass25_0)
        {
            return gclass25_0.TargetShip == this.gclass40_0;
        }

        internal bool method_3(MissileSalvo gclass132_0)
        {
            return gclass132_0.int_0 == this.gclass40_0.int_8 &&
                   gclass132_0.auroraContactType_0 == AuroraContactType.Ship;
        }

        internal bool method_4(FireControlAssignment gclass36_0)
        {
            return gclass36_0.TargetID == this.gclass40_0.int_8 &&
                   gclass36_0.TargetContactType == AuroraContactType.Ship;
        }

        internal bool method_5(ShipData gclass40_1)
        {
            return gclass40_1.gclass40_1 == this.gclass40_0;
        }

        internal bool method_6(ShipData gclass40_1)
        {
            return gclass40_1.gclass40_2 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class749
    {
        public List<int> list_0;
        public GameRace.Class748 class748_0;

        internal bool method_0(MoveOrder gclass139_0)
        {
            if (gclass139_0.DestinationType == DestinationType.const_7 &&
                gclass139_0.DestinationID == this.class748_0.gclass40_0.gclass85_0.FleetID)
                return true;
            return gclass139_0.DestinationType == DestinationType.const_4 && this.list_0.Contains(gclass139_0.DestinationID);
        }
    }

    [CompilerGenerated]
    private sealed class Class750
    {
        public MoveOrder gclass139_0;

        internal bool method_0(MoveOrder gclass139_1)
        {
            return gclass139_1.MoveOrderID >= this.gclass139_0.MoveOrderID;
        }
    }

    [CompilerGenerated]
    private sealed class Class751
    {
        public PopulationData gclass146_0;
    }

    [CompilerGenerated]
    private sealed class Class752
    {
        public GClass74 gclass74_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass22_0 == this.gclass74_0.gclass22_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class753
    {
        public GClass75 gclass75_0;
        public GameRace.Class751 class751_0;

        internal bool method_0(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.PopulationData == this.class751_0.gclass146_0 &&
                   gclass103_0.OriginalTemplateData == this.gclass75_0.gclass102_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class754
    {
        public ShipClass gclass22_0;

        internal bool method_0(GClass192 gclass192_0)
        {
            return gclass192_0.gclass22_0 == this.gclass22_0;
        }

        internal bool method_1(GClass193 gclass193_0)
        {
            return gclass193_0.gclass22_0 == this.gclass22_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class755
    {
        public FCTRaceMedalRecord gclass42_0;

        internal bool method_0(GClass53 gclass53_0)
        {
            return gclass53_0.gclass42_0 == this.gclass42_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class756
    {
        public MedalCondition gclass43_0;

        internal bool method_0(GClass44 gclass44_0)
        {
            return gclass44_0.gclass43_0 == this.gclass43_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class757
    {
        public GameRace gclass21_0;
        public Decimal decimal_0;

        internal bool method_0(ShipClass gclass22_0)
        {
            return gclass22_0.Size <= this.decimal_0 && gclass22_0.Race == this.gclass21_0;
        }

        internal bool method_1(ShipClass gclass22_0)
        {
            return gclass22_0.Size <= this.decimal_0 && gclass22_0.Obsolete == 0 &&
                   gclass22_0.Race == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class758
    {
        public GameRace gclass21_0;
        public RacialSystemSurvey gclass202_0;
        public int int_0;
    }

    [CompilerGenerated]
    private sealed class Class759
    {
        public AlienRaceInfo gclass110_0;
        public GameRace.Class758 class758_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.class758_0.gclass21_0 &&
                   gclass65_0.ContactRace == this.gclass110_0.ActualAlienRace &&
                   gclass65_0.ContactType == AuroraContactType.Ship &&
                   gclass65_0.System == this.class758_0.gclass202_0.ActualSystem && gclass65_0.LastUpdate >=
                   this.class758_0.gclass21_0.gclass0_0.GameTime - this.class758_0.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class760
    {
        public ShipData gclass40_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.ContactMethod == ContactDetectMethod.const_0 && gclass65_0.TargetShip == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class761
    {
        public GameRace gclass21_0;
        public int int_0;
    }

    [CompilerGenerated]
    private sealed class Class762
    {
        public AlienRaceInfo gclass110_0;
        public GameRace.Class761 class761_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.class761_0.gclass21_0 &&
                   gclass65_0.ContactRace == this.gclass110_0.ActualAlienRace &&
                   gclass65_0.ContactType == AuroraContactType.Ship;
        }
    }

    [CompilerGenerated]
    private sealed class Class763
    {
        public RacialSystemSurvey gclass202_0;
        public GameRace.Class762 class762_0;

        internal bool method_0(Contact gclass65_0)
        {
            return gclass65_0.DetectRace == this.class762_0.class761_0.gclass21_0 &&
                   gclass65_0.ContactRace == this.class762_0.gclass110_0.ActualAlienRace &&
                   gclass65_0.ContactType == AuroraContactType.Ship &&
                   gclass65_0.System == this.gclass202_0.ActualSystem && gclass65_0.LastUpdate >=
                   this.class762_0.class761_0.gclass21_0.gclass0_0.GameTime - this.class762_0.class761_0.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class764
    {
        public GroundUnitClass101 gclass101_0;

        internal bool method_0(GClass114 gclass114_0)
        {
            return gclass114_0.gclass101_0 == this.gclass101_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class765
    {
        public int int_0;

        internal bool method_0(GClass115 gclass115_0)
        {
            return gclass115_0.gclass22_0.ShipClassID == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class766
    {
        public PopulationData gclass146_0;

        internal bool method_0(PopulationData gclass146_1)
        {
            return gclass146_1.SystemBodyData == this.gclass146_0.SystemBodyData && gclass146_1 != this.gclass146_0;
        }
    }
}