// Decompiled with JetBrains decompiler
// Type: FleetWindow
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
public class FleetWindow : Form
{
    #region compilerGenerated

    [CompilerGenerated]
    private sealed class Class1015
    {
        public List<FCTShipData40> list_0;
        public List<GroundUnitFormationData> list_1;

        internal bool method_0(GClass55 gclass55_0)
        {
            return this.list_0.Contains(gclass55_0.gclass40_0);
        }

        internal bool method_1(GroundUnitFormationData gclass103_0)
        {
            return this.list_0.Contains(gclass103_0.ShipData);
        }

        internal bool method_2(GClass55 gclass55_0)
        {
            return this.list_1.Contains(gclass55_0.gclass103_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class1016
    {
        public SubFleet gclass84_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass84_0 == this.gclass84_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1017
    {
        public FCTSquadronData70 gclass70_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.SquadronData == this.gclass70_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1018
    {
        public FleetData gclass85_0;

        internal bool method_0(SubFleet gclass84_0)
        {
            return gclass84_0.ParentFleet == this.gclass85_0 && gclass84_0.AnchorFleet != null;
        }
    }

    [CompilerGenerated]
    private sealed class Class1019
    {
        public FleetData gclass85_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass40_0.gclass85_0 != this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1020
    {
        public FleetData gclass85_0;

        internal bool method_0(FleetData gclass85_1)
        {
            return gclass85_1.AnchorFleet == this.gclass85_0 && gclass85_1.System == this.gclass85_0.System;
        }
    }

    [CompilerGenerated]
    private sealed class Class1021
    {
        public FCTShipData40 gclass40_0;
        public int int_0;

        internal bool method_0(FCTShipData40 gclass40_1)
        {
            return gclass40_1.gclass22_0.gclass76_0 == this.gclass40_0.gclass22_0.gclass76_0 &&
                   gclass40_1.int_20 == this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1022
    {
        public FCTShipData40 gclass40_0;

        internal bool method_0(SubFleet gclass84_0)
        {
            return gclass84_0.SubFleetName == this.gclass40_0.SquadronData.SquadronName;
        }
    }

    [CompilerGenerated]
    private sealed class Class1023
    {
        public ShippingLineData gclass187_0;

        internal bool method_0(GClass22 gclass22_0)
        {
            return gclass22_0.gclass187_0 == this.gclass187_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1024
    {
        public GClass22 gclass22_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass22_0 == this.gclass22_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1025
    {
        public SubFleet gclass84_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass84_0 == this.gclass84_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1026
    {
        public SubFleet gclass84_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass84_0 == this.gclass84_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1027
    {
        public FCTShipData40 gclass40_0;

        internal bool method_0(FCTShipData40 gclass40_1)
        {
            return gclass40_1.gclass40_0 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1028
    {
        public FCTShipData40 gclass40_0;

        internal bool method_0(FCTShipData40 gclass40_1)
        {
            return gclass40_1.gclass40_0 == this.gclass40_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1029
    {
        public NavalAdminCommand gclass83_0;

        internal bool method_0(NavalAdminCommand gclass83_1)
        {
            return gclass83_1.ParentAdminCommand == this.gclass83_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1030
    {
        public NavalAdminCommand gclass83_0;

        internal bool method_0(NavalAdminCommand gclass83_1)
        {
            return gclass83_1.ParentAdminCommand == this.gclass83_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1031
    {
        public FireControlAssignment gclass36_0;

        internal bool method_0(WeaponFireControlAssignment gclass31_0)
        {
            return gclass31_0.FireControlComponent == this.gclass36_0.FCComponent && gclass31_0.FireControlNum == this.gclass36_0.FCNum;
        }
    }

    [CompilerGenerated]
    private sealed class Class1032
    {
        public FleetData gclass85_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass40_0.gclass85_0 != this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1033
    {
        public FleetData gclass85_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass40_0.gclass85_0 != this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1034
    {
        public FleetData gclass85_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass40_0.gclass85_0 != this.gclass85_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1035
    {
        public GClass228 gclass228_0;

        internal bool method_0(GClass178 gclass178_0)
        {
            return gclass178_0.gclass230_0 == this.gclass228_0.gclass230_0;
        }

        internal bool method_1(GClass26 gclass26_0)
        {
            return gclass26_0.gclass230_0 == this.gclass228_0.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1036
    {
        public GClass26 gclass26_0;

        internal bool method_0(GClass26 gclass26_1)
        {
            return gclass26_1.int_0 == this.gclass26_0.int_0 - 1;
        }
    }

    [CompilerGenerated]
    private sealed class Class1037
    {
        public GClass26 gclass26_0;

        internal bool method_0(GClass26 gclass26_1)
        {
            return gclass26_1.int_0 == this.gclass26_0.int_0 + 1;
        }
    }

    #endregion

    private Dictionary<string, TabPage> dictionary_0 = new Dictionary<string, TabPage>();
    private bool bool_0;
    private GClass0 gclass0_0;
    private GameRace gclass21_0;
    private PopulationData gclass146_0;
    private NavalAdminCommand gclass83_0;
    private NavalAdminCommandType gclass79_0;
    private FCTShipData40 gclass40_0;
    private FCTShipData40 gclass40_1;
    private ShippingLineData gclass187_0;
    private RaceMissile gclass129_0;
    private GClass132 gclass132_0;
    private bool bool_1;
    private bool bool_2;
    private IContainer icontainer_0;
    private ComboBox cboRaces;
    private TreeView tvFleetList;
    private Button cmdDelete;
    private Button cmdRefresh;
    private Button cmdCreateSubFleet;
    private ListView lstvShips;
    private ColumnHeader columnHeader_0;
    private ColumnHeader columnHeader_1;
    private ColumnHeader columnHeader_2;
    private ColumnHeader columnHeader_3;
    private ColumnHeader columnHeader_4;
    private TabControl tabNaval;
    private TabPage tabFleet;
    private ColumnHeader columnHeader_5;
    private ColumnHeader columnHeader_6;
    private ColumnHeader columnHeader_7;
    private Button cmdRename;
    private ColumnHeader columnHeader_8;
    private ColumnHeader columnHeader_9;
    private ColumnHeader columnHeader_10;
    private ColumnHeader columnHeader_11;
    private ColumnHeader columnHeader_12;
    private Button cmdCreateFleet;
    private Label lblLocation;
    private Label lblCommander;
    private Button cmdSetSpeed;
    private Label lblFleetData;
    private Label lblCapacity;
    private Label lblDefault;
    private TabPage tabShipDisplay;
    private TabPage tabFuel;
    private TabPage tabLogistics;
    private TabPage tabPage5;
    private TextBox txtShipSummary;
    private Label label27;
    private TextBox txtRangeBand;
    private Label label28;
    private TextBox txtTargetSpeed;
    private TabControl tabFleetPages;
    private TabPage tabShipList;
    private TabPage tabOrders;
    private FlowLayoutPanel flowLayoutPanel1;
    private CheckBox chkFleets;
    private CheckBox chkWaypoint;
    private CheckBox chkContacts;
    private CheckBox chkAst;
    private CheckBox chkMoon;
    private CheckBox chkComets;
    private CheckBox chkLifepods;
    private CheckBox chkWrecks;
    private CheckBox chkLocation;
    private CheckBox chkExcSurveyed;
    private CheckBox chkFilterOrders;
    private FlowLayoutPanel flowLayoutPanel2;
    private RadioButton rdoSL;
    private RadioButton rdoARSystem;
    private FlowLayoutPanel flowLayoutPanel3;
    private CheckBox chkAutoLP;
    private CheckBox chkAssumeJumpCapable;
    private CheckBox chkCycle;
    private TabPage tabFleetHistory;
    private ListView lstvHistory;
    private ColumnHeader columnHeader_13;
    private ColumnHeader columnHeader_14;
    private ListView lstvSystemLocations;
    private ColumnHeader columnHeader_15;
    private ListView lstvOrders;
    private ColumnHeader columnHeader_16;
    private ListView lstvActions;
    private ColumnHeader columnHeader_17;
    private CheckBox chkCivilian;
    private RadioButton rdoOrderTemplates;
    private CheckBox chkExcludeTP;
    private CheckBox chkPlanet;
    private CheckBox chkDwarf;
    private ColumnHeader columnHeader_18;
    private ListView lstvLoadItems;
    private ColumnHeader columnHeader_19;
    private Button cmdAddMove;
    private FlowLayoutPanel flpFleetOrderButtons;
    private Label lblMaxItems;
    private TextBox txtMaxItems;
    private Label lblOrbDistance;
    private TextBox txtOrbDistance;
    private Label lblOrderDelay;
    private TextBox txtOrderDelay;
    private CheckBox chkLoadSubUnits;
    private Label lblMinDistance;
    private TextBox txtMinDistance;
    private ComboBox cboRefuelActive;
    private TabPage tabCargo;
    private TabPage tabCombat;
    private TreeView tvCombatAssignment;
    private CheckBox chkHostileOnly;
    private CheckBox chkDragAll;
    private TreeView tvTargets;
    private Button cmdOpenFire;
    private Button cmdOpenFireAll;
    private Button cmdAssignFleet;
    private Button cmdAssignSubFleet;
    private Button cmdAssignSystem;
    private Button cmdAssignAll;
    private Button cmdSyncFire;
    private Button cmdFleetSync;
    private TabPage tabAdminCommand;
    private ListView lstvAdminCommandSystems;
    private ColumnHeader columnHeader_20;
    private ColumnHeader columnHeader_21;
    private ColumnHeader columnHeader_22;
    private ListView lstvNACTypes;
    private ColumnHeader columnHeader_23;
    private ColumnHeader columnHeader_24;
    private ColumnHeader columnHeader_25;
    private ColumnHeader columnHeader_26;
    private ColumnHeader columnHeader_27;
    private ColumnHeader columnHeader_28;
    private ColumnHeader columnHeader_29;
    private ColumnHeader columnHeader_30;
    private Button cmdUpdateAdmin;
    private Button cmdCreateAdmin;
    private ListView lstvPopulation;
    private ColumnHeader columnHeader_31;
    private ColumnHeader columnHeader_32;
    private ColumnHeader columnHeader_33;
    private ColumnHeader columnHeader_34;
    private TextBox textBox1;
    private Label label2;
    private Label lblNACCommander;
    private ColumnHeader columnHeader_35;
    private ColumnHeader columnHeader_36;
    private ColumnHeader columnHeader_37;
    private ListView lstvFuel;
    private ColumnHeader columnHeader_38;
    private ColumnHeader columnHeader_39;
    private ColumnHeader columnHeader_40;
    private ColumnHeader columnHeader_41;
    private ColumnHeader columnHeader_42;
    private ColumnHeader columnHeader_43;
    private ColumnHeader columnHeader_44;
    private ColumnHeader columnHeader_45;
    private ColumnHeader columnHeader_46;
    private FlowLayoutPanel flowLayoutPanel7;
    private CheckBox chkExcTanker;
    private CheckBox chkExcludeFighter;
    private CheckBox chkExcludeFAC;
    private CheckBox chkExcludeSY;
    private CheckBox chkNonArmed;
    private Label lblClassSummary;
    private CheckBox chkSelectOnMap;
    private Label lblMinAvailable;
    private TextBox txtMinAvailable;
    private Button cmdDetach;
    private FlowLayoutPanel flowLayoutPanel9;
    private ComboBox cboTransferActive;
    private ListView lstvMeasurement;
    private ColumnHeader columnHeader_47;
    private ColumnHeader columnHeader_48;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage6;
    private TabPage tabArmour;
    private TabPage tabPage8;
    private ListView lstvCrew;
    private ColumnHeader columnHeader_49;
    private ColumnHeader columnHeader_50;
    private ListView lstvLogistics;
    private ColumnHeader columnHeader_51;
    private ColumnHeader columnHeader_52;
    private ListView lstvOfficers;
    private ColumnHeader columnHeader_53;
    private ColumnHeader columnHeader_54;
    private ListView lstvOrdnance;
    private ColumnHeader columnHeader_55;
    private ColumnHeader columnHeader_56;
    private TabPage tabStandingOrders;
    private ListView lstvConditionOne;
    private ColumnHeader columnHeader_57;
    private CheckBox chkDanger;
    private CheckBox chkExcludeAlien;
    private CheckBox chkIncludeCivilians;
    private FlowLayoutPanel flowLayoutPanel10;
    private FlowLayoutPanel flpEnergyWeaponData;
    private Panel panArmour;
    private TextBox txtClassDisplay;
    private Button cmdAutoAssign;
    private Button cmdAutoFleetFC;
    private ComboBox cboHangar;
    private ListView lstvDAC;
    private ColumnHeader columnHeader_58;
    private ColumnHeader columnHeader_59;
    private ColumnHeader columnHeader_60;
    private ColumnHeader columnHeader_61;
    private ColumnHeader columnHeader_62;
    private ColumnHeader columnHeader_63;
    private Button cmdRepair;
    private Button cmdUp;
    private ListView lstvDamageControlQueue;
    private ColumnHeader columnHeader_64;
    private ColumnHeader columnHeader_65;
    private Button cmdRemove;
    private Button cmdDown;
    private Button cmdTop;
    private TabPage tabMiscellaneous;
    private FlowLayoutPanel flowLayoutPanel4;
    private Label label6;
    private TextBox txtManualDamage;
    private Button cmdDamage;
    private Button cmdInternalDamage;
    private ListView lstvWeapons;
    private ColumnHeader columnHeader_66;
    private ColumnHeader columnHeader_67;
    private ColumnHeader columnHeader_68;
    private FlowLayoutPanel flowLayoutPanel11;
    private Label label7;
    private FlowLayoutPanel flowLayoutPanel12;
    private FlowLayoutPanel flowLayoutPanel13;
    private Panel panel11;
    private TextBox txtFuelPriority;
    private Label label15;
    private Panel panel8;
    private TextBox txtSupplyPriority;
    private Label label10;
    private ComboBox cboResupplyActive;
    private CheckBox chkAutoDC;
    private ColumnHeader columnHeader_69;
    private Label label8;
    private TextBox txtRepairChanceTime;
    private FlowLayoutPanel flowLayoutPanel14;
    private Button cmdSMRepair;
    private Button cmdAutoQueue;
    private TabPage tabFleetMisc;
    private FlowLayoutPanel flowLayoutPanel15;
    private CheckBox chkSensorDisplay;
    private CheckBox chkWeaponDisplay;
    private Button cmdCreatePop;
    private TabPage tabShippingLine;
    private ListView lstvSL;
    private ColumnHeader columnHeader_70;
    private ColumnHeader columnHeader_71;
    private ListView lstvWealth;
    private ColumnHeader columnHeader_72;
    private ColumnHeader columnHeader_73;
    private ColumnHeader columnHeader_74;
    private ColumnHeader columnHeader_75;
    private ColumnHeader columnHeader_76;
    private ColumnHeader columnHeader_77;
    private ColumnHeader columnHeader_78;
    private TreeView tvFleetCargo;
    private Button cmdActive2;
    private Button cmdEndOverhaul;
    private CheckBox chkMaxSpeed;
    private Button cmdSMRefuel;
    private Button cmdPartialRefuel;
    private Button cmdAbandonShip;
    private Button cmdFleetSyncOff;
    private Button cmdRemoveLastOrder;
    private Button cmdRemoveAll;
    private Button cmdRepeat;
    private Button cmdSaveTemplate;
    private FlowLayoutPanel flowLayoutPanel5;
    private Button cmdDeleteTemplate;
    private Button cmdMoveFleetToPop;
    private ListBox lstMoveFleet;
    private Button cmdAwardMedal;
    private TabPage tabOOB;
    private TextBox txtSystemOOB;
    private ListView lstvLogisticsReport;
    private ColumnHeader columnHeader_79;
    private ColumnHeader columnHeader_80;
    private ColumnHeader columnHeader_81;
    private ColumnHeader columnHeader_82;
    private ColumnHeader columnHeader_83;
    private ColumnHeader columnHeader_84;
    private ColumnHeader columnHeader_85;
    private ColumnHeader columnHeader_86;
    private ColumnHeader columnHeader_87;
    private ColumnHeader columnHeader_88;
    private CheckBox chkSupplyShip;
    private FlowLayoutPanel flowLayoutPanel16;
    private CheckBox chkLogSupplyShip;
    private CheckBox chkLogExcTanker;
    private CheckBox chkLogExcludeFighter;
    private CheckBox chkLogExcludeFAC;
    private CheckBox chkLogExcludeSY;
    private CheckBox chkLogNonArmed;
    private ComboBox cboSortType;
    private TabPage tabOrdnanceTemplate;
    private ListView lstvOrdnanceTemplate;
    private ColumnHeader columnHeader_89;
    private ColumnHeader columnHeader_90;
    private ColumnHeader columnHeader_91;
    private ColumnHeader columnHeader_92;
    private ColumnHeader columnHeader_93;
    private ColumnHeader columnHeader_94;
    private ColumnHeader columnHeader_95;
    private ColumnHeader columnHeader_96;
    private ColumnHeader columnHeader_97;
    private ColumnHeader columnHeader_98;
    private ColumnHeader columnHeader_99;
    private ColumnHeader columnHeader_100;
    private Button cmdRenameMissile;
    private CheckBox checkBox1;
    private Button cmdObsoleteMissile;
    private CheckBox chkObsoleteMissiles;
    private FlowLayoutPanel flowLayoutPanel18;
    private RadioButton rdoLoadout1;
    private RadioButton rdoLoadout10;
    private RadioButton rdoLoadout100;
    private RadioButton rdoLoadout1000;
    private Button cmdCopyClassLoadout;
    private FlowLayoutPanel flowLayoutPanel21;
    private FlowLayoutPanel flowLayoutPanel22;
    private ListView lstvShipLoadout;
    private ColumnHeader columnHeader_101;
    private ColumnHeader columnHeader_102;
    private ListView lstvShipTemplate;
    private ColumnHeader columnHeader_103;
    private ColumnHeader columnHeader_104;
    private ListView lstvClassTemplate;
    private ColumnHeader columnHeader_105;
    private ColumnHeader columnHeader_106;
    private Button cmdFillShip;
    private Button cmdSMFillClass;
    private FlowLayoutPanel flowLayoutPanel17;
    private Button cmdCopyToClass;
    private Button cmdCopyToFleet;
    private Button cmOpenFireFleet;
    private Button cmdCeaseFireFleet;
    private Button cmOpenFireFleetMFC;
    private Button cmOpenFireFleetBFC;
    private TabPage tabShipCargo;
    private TreeView tvShipCargo;
    private Button cmdAutoTargetMFC;
    private Button cmdAutoTargetBFC;
    private CheckBox chkDoubleRange;
    private Button cmdFleetText;
    private CheckBox chkRetainData;
    private Button cmdSelectName;
    private CheckBox chkExcludeFighterRepair;
    private CheckBox chkExcludeFACRepair;
    private CheckBox chkExcludeSYRepair;
    private CheckBox chkNonArmedRepair;
    private ListView lstvRepair;
    private ColumnHeader columnHeader_107;
    private ColumnHeader columnHeader_108;
    private ColumnHeader columnHeader_109;
    private ColumnHeader columnHeader_110;
    private ColumnHeader columnHeader_111;
    private ColumnHeader columnHeader_112;
    private ColumnHeader columnHeader_113;
    private ColumnHeader columnHeader_114;
    private ColumnHeader columnHeader_115;
    private FlowLayoutPanel flowLayoutPanel19;
    private Button cmdClearTarget;
    private Button cmdClearAllTargets;
    private Button cmdMoveFleettoWP;
    private ListBox lstMoveWP;
    private TextBox txtRepeatMultiple;
    private TabPage tabFormation;
    private TreeView tvThreat;
    private CheckBox chkCurrentContact;
    private CheckBox chkCurrentSystem;
    private FlowLayoutPanel flowLayoutPanel23;
    private Button cmdClearAnchor;
    private Button cmdClearThreat;
    private ListView lstvFormation;
    private ColumnHeader columnHeader_116;
    private ColumnHeader columnHeader_117;
    private Button cmdSetOffset;
    private Button cmdSetDistance;
    private Button cmdToggleContact;
    private Button cmdToggleWarship;
    private Button button1;
    private TreeView tvAnchor;
    private Button cmdSetAnchor;
    private Button cmdSetThreat;
    private FlowLayoutPanel flowLayoutPanel20;
    private Button cmdDetachEscorts;
    private Button cmdRecallEscorts;
    private Button cmdFleetAtWill;
    private Button cmdFleetFireAtWill;
    private Button cmdFireAtWillFC;
    private FlowLayoutPanel flowLayoutPanel25;
    private FlowLayoutPanel flowLayoutPanel32;
    private Panel panel2;
    private ComboBox cboTransferRace;
    private Button cmdTransfer;
    private Panel panel1;
    private CheckBox chkDefaultActions;
    private Button cmdFleetShields;
    private CheckBox chkIncFighter;
    private CheckBox chkIncFAC;
    private CheckBox chkAutoAssign;
    private Label label37;
    private TextBox txtImportance;
    private FlowLayoutPanel flowLayoutPanel24;
    private Label label39;
    private Label label36;
    private Label label40;
    private FlowLayoutPanel flowLayoutPanel26;
    private ComboBox cboBonusOne;
    private ComboBox cboBonusThree;
    private ComboBox cboBonusTwo;
    private Panel panel3;
    private Button cmdSelectGovernor;
    private FlowLayoutPanel flowLayoutPanel27;
    private Button cmdAssignGovernors;
    private Button cmdReassignAllGovernors;
    private Label label9;
    private ComboBox cboNavalRanks;
    private FlowLayoutPanel flowLayoutPanel6;
    private Button cmdSetHullNumber;
    private Button cmdCreateSquadron;
    private Button cmdLaunchAll;
    private CheckBox chkDragNum;
    private TextBox txtAssignNum;
    private TabPage tabPage3;
    private ListView lstvCombatRating;
    private ColumnHeader columnHeader_118;
    private ColumnHeader columnHeader_119;
    private ColumnHeader columnHeader_120;
    private ColumnHeader columnHeader_121;
    private ColumnHeader columnHeader_122;
    private ColumnHeader columnHeader_123;
    private ColumnHeader columnHeader_124;
    private ColumnHeader columnHeader_125;
    private ColumnHeader columnHeader_126;
    private CheckBox chkIncludeSG;
    private ColumnHeader columnHeader_127;
    private FlowLayoutPanel flowLayoutPanel28;
    private RadioButton rdoMilitary;
    private RadioButton rdoCommercial;
    private RadioButton rdoGround;
    private RadioButton rdoMissiles;
    private RadioButton rdoSize;
    private RadioButton rdoDistance;
    private Label label14;
    private ListView lstvShipHistory;
    private ColumnHeader columnHeader_128;
    private ColumnHeader columnHeader_129;
    private ColumnHeader columnHeader_130;
    private Button cmdMinAMMRange;
    private Button cmdDecoyThreshold;
    private CheckBox ckhTarget;
    private TabPage tabPage4;
    private ListView lstvSalvos;
    private ColumnHeader columnHeader_131;
    private ColumnHeader columnHeader_132;
    private ColumnHeader columnHeader_133;
    private ColumnHeader columnHeader_134;
    private ColumnHeader columnHeader_135;
    private Button cmdDeleteSalvo;
    private ColumnHeader columnHeader_136;
    private ColumnHeader columnHeader_137;
    private Label label11;
    private TextBox txtSurveyRadius;
    private Button cmdTemp;
    private ColumnHeader columnHeader_138;
    private Button cmdScrapAll;
    private Button cmdScrap;
    private Button cmdCollapseAll;
    private ListView lstvStandingOrdersList;
    private ColumnHeader columnHeader_139;
    private Button cmdAddSO;
    private Button cmdDeleteSO;
    private ColumnHeader columnHeader_140;
    private Button cmdOrderUp;
    private Button cmdOrderDown;
    private ColumnHeader columnHeader_141;
    private Button cmdAddCO;
    private TreeView tvStandingOrders;
    private Button cmdLoadTemplate;
    private Button cmdCreateTemplate;
    private ListView lstvStandingOrderTemplates;
    private ColumnHeader columnHeader_142;
    private Button cmdDeleteSOTemplate;
    private Button cmdDeleteAll;
    private CheckBox chkSetFWP;
    private ColumnHeader columnHeader_143;
    private Button cmdCreateFleetWaypoint;
    private FlowLayoutPanel flowLayoutPanel29;
    private CheckBox chkDetachedStanding;
    private CheckBox chkDetachedConditional;
    private CheckBox chkIncludeSquadrons;
    private CheckBox chkIgnoreSO;
    private CheckBox chkIgnoreCO;
    private Button cmdClearFleetTargets;
    private FlowLayoutPanel flowLayoutPanel30;
    private CheckBox chkOrders;
    private CheckBox chkOverhauls;
    private CheckBox chkShowJD;

    public FleetWindow(GClass0 gclass0_1)
    {
        this.gclass0_0 = gclass0_1;
        this.InitializeComponent();
    }

    private void method_0()
    {
        try
        {
            this.txtMaxItems.Visible = false;
            this.lblMaxItems.Visible = false;
            this.txtMinDistance.Visible = false;
            this.lblMinDistance.Visible = false;
            this.txtOrbDistance.Visible = false;
            this.lblOrbDistance.Visible = false;
            this.chkLoadSubUnits.Visible = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 920);
        }
    }

    private void method_1()
    {
        try
        {
            this.cboRefuelActive.DataSource = new List<string>()
            {
                "No Auto Refuel",
                "Refuel Own Fleet",
                "Refuel Own Sub-Fleet",
                "Refuel Own Fleet Tankers"
            };
            this.cboResupplyActive.DataSource = new List<string>()
            {
                "No Auto Resupply",
                "Resupply Own Fleet",
                "Resupply Own Sub-Fleet"
            };
            this.cboTransferActive.DataSource = new List<string>()
            {
                "No Auto Ordnance",
                "Load Fleet Ordnance",
                "Replace Fleet Ordnance",
                "Remove Fleet Ordnance",
                "Load Sub Fleet Ordnance",
                "Replace Sub Fleet Ordnance",
                "Remove Sub Fleet Ordnance"
            };
            this.cboHangar.DataSource = new List<string>()
            {
                "Add Parasite Ordnance",
                "Remove Parasite Ordnance",
                "Replace Parasite Ordnance"
            };
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 921);
        }
    }

    private void FleetWindow_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 922);
        }
    }

    private void FleetWindow_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            this.Height = 896;
            foreach (TabPage tabPage in this.tabFleetPages.TabPages)
                this.dictionary_0.Add(tabPage.Name, tabPage);
            this.gclass0_0.bool_9 = true;
            this.method_1();
            this.gclass0_0.method_633(this.lstvConditionOne);
            this.gclass0_0.method_580(this.cboBonusOne, AuroraCommanderType.Naval);
            this.gclass0_0.method_580(this.cboBonusTwo, AuroraCommanderType.Naval);
            this.gclass0_0.method_580(this.cboBonusThree, AuroraCommanderType.Naval);
            this.cboSortType.DisplayMember = "Description";
            // ISSUE: object of a compiler-generated type is created
            this.cboSortType.DataSource = Enum.GetValues(typeof(AuroraLogisticsSortType)).Cast<Enum>()
                .Select<Enum, Class327<string, Enum>>(enum_0 =>
                    new Class327<string, Enum>(
                        (Attribute.GetCustomAttribute(enum_0.GetType().GetField(enum_0.ToString()),
                            typeof(DescriptionAttribute)) as DescriptionAttribute).Description, enum_0))
                .OrderBy<Class327<string, Enum>, Enum>(class327_0 => class327_0.value).ToList<Class327<string, Enum>>();
            this.bool_2 = true;
            this.gclass0_0.method_577(this.cboRaces);
            this.gclass0_0.method_532(this.lstvNACTypes);
            this.method_3();
            this.method_2();
            this.chkOrders.CheckState = AuroraUtils.smethod_28(this.gclass0_0.chkOrders);
            this.chkOverhauls.CheckState = AuroraUtils.smethod_28(this.gclass0_0.chkOverhauls);
            this.chkShowJD.CheckState = AuroraUtils.smethod_28(this.gclass0_0.chkShowJD);
            this.gclass0_0.bool_9 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 923);
        }
    }

    private void method_2()
    {
        if (this.gclass0_0.bool_8)
        {
            this.cmdSMRepair.Visible = true;
            this.cmdSMRefuel.Visible = true;
            this.cmdPartialRefuel.Visible = true;
            this.cmdFillShip.Visible = true;
            this.cmdSMFillClass.Visible = true;
        }
        else
        {
            this.cmdSMRepair.Visible = false;
            this.cmdSMRefuel.Visible = false;
            this.cmdPartialRefuel.Visible = false;
            this.cmdFillShip.Visible = false;
            this.cmdSMFillClass.Visible = false;
        }
    }

    private void method_3()
    {
        ToolTip toolTip = new ToolTip();
        toolTip.AutoPopDelay = 2000;
        toolTip.InitialDelay = 750;
        toolTip.ReshowDelay = 500;
        toolTip.ShowAlways = true;
        toolTip.SetToolTip(this.cmdCreateAdmin,
            "Create a new administrative command below a selected existing administrative command");
        toolTip.SetToolTip(this.cmdCreateSubFleet, "Create a sub-fleet below an existing fleet");
        toolTip.SetToolTip(this.cmdCreateSquadron, "Create a squadron below the selected ship");
        toolTip.SetToolTip(this.cmdDelete,
            "Delete the currently selected item (Admin Command, Fleet, Sub-Fleet or Ship) on the treeview");
        toolTip.SetToolTip(this.cmdRename,
            "Rename the currently selected item (Admin Command, Fleet, Sub-Fleet or Ship) on the treeview");
        toolTip.SetToolTip(this.chkExcludeTP, "Exclude any ship contacts which are only visible via their transponder");
        toolTip.SetToolTip(this.cmdOpenFireAll, "Open fire / cease fire with all fire controls on the selected ship");
        toolTip.SetToolTip(this.cmdOpenFire,
            "Open fire / cease fire with the selected fire control on the selected ship");
        toolTip.SetToolTip(this.cmdActive2, "Activate / Deactivate all active sensors on the selected ship or fleet");
        toolTip.SetToolTip(this.cmdFleetShields, "Raise or lower shields on the selected ship or fleet");
        toolTip.SetToolTip(this.cmdSyncFire,
            "When synchronous fire is active, the selected ship will not fire unless other ships in the same fleet are ready to fire");
        toolTip.SetToolTip(this.chkSelectOnMap, "Centre the Tactical Map when any fleet is selected");
        toolTip.SetToolTip(this.cmdAutoTargetMFC,
            "Each ship will target a different enemy ship that is within range of its missiles (or double range with Range x2 selected). With fewer enemy ships than friendly, some ships will duplicate targets");
        toolTip.SetToolTip(this.cmdAutoTargetBFC,
            "Each ship will target a different enemy ship that is within range of its beam weapons (or double range with Range x2 selected). With fewer enemy ships than friendly, some ships will duplicate targets");
        toolTip.SetToolTip(this.cmdLaunchAll,
            "Launch all parasites from the selected fleet, sub-fleet or ship. Any squadrons will appear as sub-fleets");
    }

    public void method_4(GameRace gclass21_1)
    {
        try
        {
            this.bool_2 = true;
            this.cboRaces.SelectedItem = gclass21_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 924);
        }
    }

    private void cboRaces_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass21_0 = (GameRace)this.cboRaces.SelectedValue;
            this.method_5();
            if (!this.bool_2)
                this.gclass0_0.method_511(this.gclass21_0, this);
            this.bool_2 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 925);
        }
    }

    private void method_5()
    {
        try
        {
            AuroraLogisticsSortType selectedIndex = (AuroraLogisticsSortType)this.cboSortType.SelectedIndex;
            this.gclass21_0.method_155(this.tvStandingOrders);
            this.gclass0_0.bool_9 = true;
            this.gclass21_0.method_233(this.cboNavalRanks, AuroraCommanderType.Naval);
            this.gclass0_0.bool_9 = false;
            this.gclass21_0.method_355(this.tvFleetList, null, false,
                AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
            this.gclass21_0.method_350(this.lstvFuel, this.chkExcTanker.CheckState, this.chkExcludeFighter.CheckState,
                this.chkExcludeFAC.CheckState, this.chkExcludeSY.CheckState, this.chkNonArmed.CheckState,
                this.chkSupplyShip.CheckState);
            this.gclass21_0.method_352(this.lstvLogisticsReport, selectedIndex, this.chkLogExcTanker.CheckState,
                this.chkLogExcludeFighter.CheckState, this.chkLogExcludeFAC.CheckState, this.chkLogExcludeSY.CheckState,
                this.chkLogNonArmed.CheckState, this.chkLogSupplyShip.CheckState);
            this.gclass21_0.method_353(this.lstvCombatRating, this.chkIncludeSG.CheckState, this.rdoMilitary.Checked,
                this.rdoCommercial.Checked, this.rdoGround.Checked, this.rdoMissiles.Checked, this.rdoSize.Checked,
                this.rdoDistance.Checked);
            this.gclass21_0.method_351(this.lstvRepair, this.chkExcludeFighterRepair.CheckState,
                this.chkExcludeFACRepair.CheckState, this.chkExcludeSYRepair.CheckState,
                this.chkNonArmedRepair.CheckState);
            this.gclass21_0.method_354(this.lstvSalvos);
            this.gclass21_0.method_127(this.lstvWeapons, false);
            this.gclass21_0.method_125(this.lstMoveFleet);
            this.gclass21_0.method_126(this.lstMoveWP);
            this.gclass21_0.method_316(this.lstvOrdnanceTemplate, this.chkObsoleteMissiles.CheckState, true);
            this.gclass21_0.method_330(this.cboTransferRace);
            this.gclass21_0.method_331(this.lstvStandingOrderTemplates);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3218);
        }
    }

    private void tvFleetList_ItemDrag(object sender, ItemDragEventArgs e)
    {
        int num = (int)this.DoDragDrop(e.Item, DragDropEffects.Move);
    }

    private void tvFleetList_DragEnter(object sender, DragEventArgs e)
    {
        e.Effect = DragDropEffects.Move;
    }

    private void tvFleetList_DragDrop(object sender, DragEventArgs e)
    {
        try
        {
            bool flag = (e.KeyState & 4) == 4;
            TreeNode nodeAt = this.tvFleetList.GetNodeAt(this.tvFleetList.PointToClient(new Point(e.X, e.Y)));
            TreeNode data = (TreeNode)e.Data.GetData(typeof(TreeNode));
            if (data.Equals(nodeAt) || nodeAt == null)
                return;
            if (data.Tag is SubFleet)
            {
                if (nodeAt.Tag is SubFleet)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    FleetWindow.Class1025 class1025 = new FleetWindow.Class1025();
                    // ISSUE: reference to a compiler-generated field
                    class1025.gclass84_0 = (SubFleet)data.Tag;
                    SubFleet tag = (SubFleet)nodeAt.Tag;
                    // ISSUE: reference to a compiler-generated field
                    if (class1025.gclass84_0.ParentFleet == tag.ParentFleet)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class1025.gclass84_0.ParentSubFleet = tag;
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.gclass0_0.method_520(class1025.gclass84_0.ParentFleet.XCoord, tag.ParentFleet.XCoord,
                                class1025.gclass84_0.ParentFleet.YCoord, tag.ParentFleet.YCoord) &&
                            class1025.gclass84_0.ParentFleet.System == tag.ParentFleet.System &&
                            class1025.gclass84_0.Race == tag.Race)
                        {
                            // ISSUE: reference to a compiler-generated method
                            List<FCTShipData40> list = this.gclass0_0.FCTShipDataDictionary.Values
                                .Where<FCTShipData40>(class1025.method_0).ToList<FCTShipData40>();
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class1025.gclass84_0.Race.method_270(list, class1025.gclass84_0.ParentFleet,
                                tag.ParentFleet, false, false);
                            // ISSUE: reference to a compiler-generated field
                            class1025.gclass84_0.ParentSubFleet = tag;
                            // ISSUE: reference to a compiler-generated field
                            class1025.gclass84_0.ParentFleet = tag.ParentFleet;
                        }
                        else
                        {
                            int num = (int)MessageBox.Show(
                                "Sub-fleets may only be moved within their current fleet (including sub-fleets) or to a fleet or sub-fleet of the same race in the same location as their parent fleet");
                            return;
                        }
                    }
                }

                if (nodeAt.Tag is FleetData)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    FleetWindow.Class1026 class1026 = new FleetWindow.Class1026();
                    // ISSUE: reference to a compiler-generated field
                    class1026.gclass84_0 = (SubFleet)data.Tag;
                    FleetData tag = (FleetData)nodeAt.Tag;
                    // ISSUE: reference to a compiler-generated field
                    if (class1026.gclass84_0.ParentFleet == tag)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class1026.gclass84_0.ParentSubFleet = null;
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.gclass0_0.method_520(class1026.gclass84_0.ParentFleet.XCoord, tag.XCoord,
                                class1026.gclass84_0.ParentFleet.YCoord, tag.YCoord) &&
                            class1026.gclass84_0.ParentFleet.System == tag.System &&
                            class1026.gclass84_0.Race == tag.Race)
                        {
                            // ISSUE: reference to a compiler-generated method
                            List<FCTShipData40> list = this.gclass0_0.FCTShipDataDictionary.Values
                                .Where<FCTShipData40>(class1026.method_0).ToList<FCTShipData40>();
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class1026.gclass84_0.Race.method_270(list, class1026.gclass84_0.ParentFleet, tag,
                                false, false);
                            // ISSUE: reference to a compiler-generated field
                            class1026.gclass84_0.ParentSubFleet = null;
                            // ISSUE: reference to a compiler-generated field
                            class1026.gclass84_0.ParentFleet = tag;
                        }
                        else
                        {
                            int num = (int)MessageBox.Show(
                                "Sub-fleets may only be moved within their current fleet (including sub-fleets) or to a fleet or sub-fleet of the same race in the same location as their parent fleet");
                            return;
                        }
                    }
                }

                if (nodeAt.Tag is NavalAdminCommand || nodeAt.Tag is FCTShipData40)
                {
                    int num = (int)MessageBox.Show(
                        "Sub-fleets may only be moved within their current fleet (including sub-fleets) or to a fleet or sub-fleet of the same race in the same location as their parent fleet");
                    return;
                }
            }

            if (data.Tag is FCTShipData40)
            {
                if (nodeAt.Tag is SubFleet)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    FleetWindow.Class1027 class1027 = new FleetWindow.Class1027();
                    // ISSUE: reference to a compiler-generated field
                    class1027.gclass40_0 = (FCTShipData40)data.Tag;
                    SubFleet tag = (SubFleet)nodeAt.Tag;
                    // ISSUE: reference to a compiler-generated field
                    if (class1027.gclass40_0.gclass85_0 == tag.ParentFleet)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class1027.gclass40_0.gclass84_0 = tag;
                        // ISSUE: reference to a compiler-generated field
                        class1027.gclass40_0.SquadronData = null;
                        // ISSUE: reference to a compiler-generated field
                        class1027.gclass40_0.gclass40_0 = null;
                        // ISSUE: reference to a compiler-generated method
                        foreach (FCTShipData40 gclass40 in this.gclass0_0.FCTShipDataDictionary.Values
                                     .Where<FCTShipData40>(class1027.method_0).ToList<FCTShipData40>())
                        {
                            // ISSUE: reference to a compiler-generated field
                            gclass40.gclass84_0 = class1027.gclass40_0.gclass84_0;
                        }
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.gclass0_0.method_520(class1027.gclass40_0.gclass85_0.XCoord, tag.ParentFleet.XCoord,
                                class1027.gclass40_0.gclass85_0.YCoord, tag.ParentFleet.YCoord) &&
                            class1027.gclass40_0.gclass85_0.System == tag.ParentFleet.System &&
                            class1027.gclass40_0.gclass21_0 == tag.Race)
                        {
                            // ISSUE: reference to a compiler-generated field
                            class1027.gclass40_0.gclass84_0 = tag;
                            // ISSUE: reference to a compiler-generated field
                            class1027.gclass40_0.gclass40_0 = null;
                            // ISSUE: reference to a compiler-generated field
                            class1027.gclass40_0.method_185(tag.ParentFleet, true, false, false, true);
                        }
                        else
                        {
                            int num = (int)MessageBox.Show(
                                "Ships may only be moved within their current fleet (including sub-fleets) or to a fleet or sub-fleet of the same race in the same location as their parent fleet");
                            return;
                        }
                    }
                }

                if (nodeAt.Tag is FCTSquadronData70)
                {
                    FCTShipData40 tag1 = (FCTShipData40)data.Tag;
                    FCTSquadronData70 tag2 = (FCTSquadronData70)nodeAt.Tag;
                    if (this.gclass0_0.method_520(tag1.gclass85_0.XCoord, tag2.ParentShipData.gclass85_0.XCoord,
                            tag1.gclass85_0.YCoord, tag2.ParentShipData.gclass85_0.YCoord) &&
                        tag1.gclass85_0.System == tag2.ParentShipData.gclass85_0.System)
                    {
                        if (tag1.gclass40_0 != tag2.ParentShipData)
                        {
                            if (tag2.ParentShipData.method_125() >= tag1.gclass22_0.decimal_14)
                            {
                                tag1.gclass40_0 = tag2.ParentShipData;
                                tag1.gclass40_1 = tag2.ParentShipData;
                                tag1.method_185(tag2.ParentShipData.gclass85_0, true, true, false, true);
                                tag1.gclass84_0 = tag2.ParentShipData.gclass84_0;
                                tag1.method_117(tag1.gclass40_1);
                            }
                            else
                            {
                                int num = (int)MessageBox.Show(
                                    "Ships can only be moved into a squadron if the parent ship has sufficient hangar space");
                                return;
                            }
                        }

                        tag1.SquadronData = tag2;
                        tag1.LinkedSquadronID = tag1.SquadronData.SquadronID;
                    }
                    else
                    {
                        int num = (int)MessageBox.Show(
                            "Ships can only be moved into a squadron in the same location as their parent fleet");
                        return;
                    }
                }

                if (nodeAt.Tag is FleetData)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    FleetWindow.Class1028 class1028 = new FleetWindow.Class1028();
                    // ISSUE: reference to a compiler-generated field
                    class1028.gclass40_0 = (FCTShipData40)data.Tag;
                    FleetData tag = (FleetData)nodeAt.Tag;
                    // ISSUE: reference to a compiler-generated field
                    if (class1028.gclass40_0.gclass85_0 == tag)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class1028.gclass40_0.gclass84_0 = null;
                        // ISSUE: reference to a compiler-generated field
                        class1028.gclass40_0.gclass40_0 = null;
                        // ISSUE: reference to a compiler-generated method
                        foreach (FCTShipData40 gclass40 in this.gclass0_0.FCTShipDataDictionary.Values
                                     .Where<FCTShipData40>(class1028.method_0).ToList<FCTShipData40>())
                            gclass40.gclass84_0 = null;
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class1028.gclass40_0.gclass85_0.method_52(tag.XCoord, tag.YCoord) &&
                            class1028.gclass40_0.gclass85_0.System == tag.System &&
                            class1028.gclass40_0.gclass21_0 == tag.Race)
                        {
                            // ISSUE: reference to a compiler-generated field
                            class1028.gclass40_0.gclass84_0 = null;
                            // ISSUE: reference to a compiler-generated field
                            class1028.gclass40_0.gclass40_0 = null;
                            // ISSUE: reference to a compiler-generated field
                            class1028.gclass40_0.method_185(tag, true, false, false, true);
                        }
                        else
                        {
                            int num = (int)MessageBox.Show(
                                "Ships may only be moved within their current fleet (including sub-fleets) or to a fleet or sub-fleet of the same race in the same location as their parent fleet");
                            return;
                        }
                    }
                }

                if (nodeAt.Tag is NavalAdminCommand || nodeAt.Tag is FCTShipData40)
                {
                    int num = (int)MessageBox.Show(
                        "Ships may only be moved to their parent fleet or to a sub-fleet of their parent fleet");
                    return;
                }
            }

            if (data.Tag is FCTSquadronData70 && nodeAt.Tag is FCTShipData40)
            {
                FCTSquadronData70 tag3 = (FCTSquadronData70)data.Tag;
                FCTShipData40 tag4 = (FCTShipData40)nodeAt.Tag;
                if (this.gclass0_0.method_520(tag3.ParentShipData.gclass85_0.XCoord, tag4.gclass85_0.XCoord,
                        tag3.ParentShipData.gclass85_0.YCoord, tag4.gclass85_0.YCoord) &&
                    tag3.ParentShipData.gclass85_0.System == tag4.gclass85_0.System)
                {
                    List<FCTShipData40> source = tag3.method_0();
                    if (tag4.method_125() >= source.Sum<FCTShipData40>(gclass40_0 => gclass40_0.gclass22_0.decimal_14))
                    {
                        foreach (FCTShipData40 gclass40 in source)
                        {
                            gclass40.gclass40_0 = tag4;
                            gclass40.gclass40_1 = tag4;
                            if (gclass40.gclass85_0 != tag4.gclass85_0)
                                gclass40.method_185(tag4.gclass85_0, true, false, false, false);
                            gclass40.gclass84_0 = tag4.gclass84_0;
                        }

                        tag3.ParentShipData = tag4;
                    }
                    else
                    {
                        int num = (int)MessageBox.Show(
                            "A squadron can only be moved to a ship with sufficient hangar space");
                        return;
                    }
                }
                else
                {
                    int num = (int)MessageBox.Show(
                        "Squadrons can only be moved to a ship in the same location as their parent fleet");
                    return;
                }
            }

            if (data.Tag is FleetData)
            {
                if (nodeAt.Tag is NavalAdminCommand)
                {
                    FleetData tag5 = (FleetData)data.Tag;
                    NavalAdminCommand tag6 = (NavalAdminCommand)nodeAt.Tag;
                    if (tag5.Race == tag6.Race)
                    {
                        tag5.ParentNavalCommand = tag6;
                        tag6.bool_0 = true;
                    }
                    else
                    {
                        int num = (int)MessageBox.Show(
                            "Fleets may only be moved to an administrative command of the same race");
                        return;
                    }
                }
                else if (nodeAt.Tag is FleetData)
                {
                    FleetData tag7 = (FleetData)data.Tag;
                    FleetData tag8 = (FleetData)nodeAt.Tag;
                    if (tag7.method_53(tag8.XCoord, tag8.YCoord, tag8.System) &&
                        tag7.Race == tag8.Race)
                    {
                        SubFleet gclass84_0 = null;
                        if (flag)
                            gclass84_0 = tag8.method_89(tag7.FleetName);
                        if (this.lstvShips.SelectedItems.Count > 1)
                        {
                            foreach (ListViewItem selectedItem in this.lstvShips.SelectedItems)
                            {
                                FCTShipData40 tag9 = (FCTShipData40)selectedItem.Tag;
                                tag9.gclass84_0 = gclass84_0;
                                tag9.method_185(tag8, true, false, false, false);
                            }

                            tag8.bool_16 = true;
                        }
                        else
                        {
                            tag8.method_73(tag7, gclass84_0);
                            tag7.Race.genum42_0 = GEnum42.const_2;
                            tag7.Race.int_43 = tag8.FleetID;
                            tag8.bool_16 = true;
                        }
                    }
                    else
                    {
                        int num = (int)MessageBox.Show(
                            "Fleets may only be moved to a fleet or sub-fleet of the same race in the same location");
                        return;
                    }
                }
                else if (nodeAt.Tag is FCTSquadronData70)
                {
                    FleetData tag10 = (FleetData)data.Tag;
                    FCTSquadronData70 tag11 = (FCTSquadronData70)nodeAt.Tag;
                    if (this.gclass0_0.method_520(tag11.ParentShipData.gclass85_0.XCoord, tag10.XCoord,
                            tag11.ParentShipData.gclass85_0.YCoord, tag10.YCoord) &&
                        tag11.ParentShipData.gclass85_0.System == tag10.System)
                    {
                        List<FCTShipData40> source = tag10.method_177();
                        if (tag11.ParentShipData.method_125() >=
                            source.Sum<FCTShipData40>(gclass40_0 => gclass40_0.gclass22_0.decimal_14))
                        {
                            foreach (FCTShipData40 gclass40 in source)
                            {
                                gclass40.gclass40_0 = tag11.ParentShipData;
                                gclass40.gclass40_1 = tag11.ParentShipData;
                                gclass40.SquadronData = tag11;
                                if (gclass40.gclass85_0 != tag11.ParentShipData.gclass85_0)
                                    gclass40.method_185(tag11.ParentShipData.gclass85_0, true, true, false, false);
                                gclass40.gclass84_0 = tag11.ParentShipData.gclass84_0;
                            }

                            tag11.ParentShipData.gclass21_0.genum42_0 = GEnum42.const_2;
                            tag11.ParentShipData.gclass21_0.int_43 = tag11.SquadronID;
                            tag11.bool_0 = true;
                        }
                        else
                        {
                            int num = (int)MessageBox.Show(
                                "A fleet can only be moved to a squadron on board a ship with sufficient hangar space");
                            return;
                        }
                    }
                    else
                    {
                        int num = (int)MessageBox.Show("Fleets can only be moved to a squadron in the same location");
                        return;
                    }
                }
                else if (nodeAt.Tag is SubFleet)
                {
                    FleetData tag12 = (FleetData)data.Tag;
                    SubFleet tag13 = (SubFleet)nodeAt.Tag;
                    if (tag13.ParentFleet == tag12)
                    {
                        int num = (int)MessageBox.Show("Fleets cannot be moved under their own sub-fleet");
                        return;
                    }

                    if (tag12.method_53(tag13.ParentFleet.XCoord, tag13.ParentFleet.YCoord,
                            tag13.ParentFleet.System) && tag12.Race == tag13.ParentFleet.Race)
                    {
                        tag13.ParentFleet.method_73(tag12, tag13);
                        tag12.Race.genum42_0 = GEnum42.const_2;
                        tag12.Race.int_43 = tag13.ParentFleet.FleetID;
                        tag13.ParentFleet.bool_16 = true;
                    }
                    else
                    {
                        int num = (int)MessageBox.Show(
                            "Fleets may only be moved to a fleet or sub-fleet of the same race in the same location");
                        return;
                    }
                }
                else
                {
                    int num = (int)MessageBox.Show(
                        "Fleets may only be moved to an administrative command of the same race or to a fleet or sub-fleet of the same race in the same location");
                    return;
                }
            }

            if (data.Tag is NavalAdminCommand)
            {
                NavalAdminCommand tag = (NavalAdminCommand)data.Tag;
                if (tag.ParentAdminCommand == null)
                {
                    int num = (int)MessageBox.Show("The highest level administrative command may not be moved");
                    return;
                }

                if (nodeAt.Tag is NavalAdminCommand)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    FleetWindow.Class1029 class1029 = new FleetWindow.Class1029();
                    // ISSUE: reference to a compiler-generated field
                    class1029.gclass83_0 = (NavalAdminCommand)nodeAt.Tag;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    if (class1029.gclass83_0.gclass40_0 != null &&
                        this.gclass0_0.NavalAdminCommands.Values.FirstOrDefault<NavalAdminCommand>(class1029.method_0) != null)
                    {
                        int num = (int)MessageBox.Show("Ship-based admin commands cannot have subordinate commands");
                        return;
                    }

                    // ISSUE: reference to a compiler-generated field
                    if (class1029.gclass83_0.Race == tag.Race)
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (class1029.gclass83_0.ParentAdminCommand == tag)
                        {
                            // ISSUE: reference to a compiler-generated field
                            class1029.gclass83_0.ParentAdminCommand = tag.ParentAdminCommand;
                            // ISSUE: reference to a compiler-generated field
                            tag.ParentAdminCommand = class1029.gclass83_0;
                            nodeAt.Remove();
                            data.Parent.Nodes.Add(nodeAt);
                            data.Remove();
                            nodeAt.Nodes.Add(data);
                            this.gclass21_0.method_355(this.tvFleetList, null, false,
                                AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
                            return;
                        }

                        // ISSUE: reference to a compiler-generated field
                        tag.ParentAdminCommand = class1029.gclass83_0;
                        // ISSUE: reference to a compiler-generated field
                        class1029.gclass83_0.bool_0 = true;
                    }
                    else
                    {
                        int num = (int)MessageBox.Show(
                            "An administrative commands may only be placed under another an administrative command of the same race");
                        return;
                    }
                }
                else
                {
                    int num = (int)MessageBox.Show(
                        "An administrative commands may only be placed under another an administrative command of the same race");
                    return;
                }
            }

            data.Remove();
            nodeAt.Nodes.Add(data);
            this.gclass21_0.method_355(this.tvFleetList, null, false,
                AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 926);
        }
    }

    private void cmdCreateAdmin_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a parent command for the new administrative command");
            }
            else if (this.tvFleetList.SelectedNode.Tag is NavalAdminCommand)
            {
                NavalAdminCommand tag = (NavalAdminCommand)this.tvFleetList.SelectedNode.Tag;
                if (tag.gclass40_0 != null)
                {
                    int num3 = (int)MessageBox.Show(
                        "Admin commands located on a flag bridge cannot have subordinate commands");
                }
                else
                {
                    PopulationData gclass1460 = tag.gclass146_0;
                    FCTShipData40 gclass40_1 = null;
                    if (this.gclass146_0 != null)
                        gclass1460 = this.gclass146_0;
                    else if (this.gclass40_1 != null)
                        gclass40_1 = this.gclass40_1;
                    AdminCommandType genum37_0 = AdminCommandType.const_0;
                    if (this.gclass79_0 != null)
                        genum37_0 = this.gclass79_0.AdminCommandType;
                    this.gclass0_0.string_3 = "Enter New Admin Command Name";
                    this.gclass0_0.string_4 = "New Admin Command";
                    int num4 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                    if (this.gclass0_0.bool_21)
                        return;
                    NavalAdminCommand gclass83 = this.gclass21_0.method_248(tag, gclass1460, gclass40_1, this.gclass0_0.string_4,
                        genum37_0);
                    this.tvFleetList.SelectedNode.Nodes.Add(new TreeNode()
                    {
                        Text = gclass83.method_6(),
                        Tag = gclass83,
                        ForeColor = AuroraUtils.color_2
                    });
                }
            }
            else
            {
                int num5 = (int)MessageBox.Show("Please select a parent command for the new administrative command");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 927);
        }
    }

    private void cmdUpdateAdmin_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode.Tag is NavalAdminCommand)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetWindow.Class1030 class1030 = new FleetWindow.Class1030();
                // ISSUE: reference to a compiler-generated field
                class1030.gclass83_0 = (NavalAdminCommand)this.tvFleetList.SelectedNode.Tag;
                if (this.gclass79_0 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    class1030.gclass83_0.gclass79_0 = this.gclass0_0.AdminCommandTypeDictionary[this.gclass79_0.AdminCommandType];
                }

                if (this.gclass146_0 != null || this.gclass40_1 != null)
                {
                    if (this.gclass146_0 != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class1030.gclass83_0.gclass146_0 = this.gclass146_0;
                        // ISSUE: reference to a compiler-generated field
                        class1030.gclass83_0.gclass40_0 = null;
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated method
                        if (this.gclass0_0.NavalAdminCommands.Values.FirstOrDefault<NavalAdminCommand>(class1030.method_0) != null)
                        {
                            int num2 = (int)MessageBox.Show(
                                "Admin commands with subordinate commands cannot be assigned to a ship");
                            return;
                        }

                        // ISSUE: reference to a compiler-generated field
                        class1030.gclass83_0.gclass146_0 = null;
                        // ISSUE: reference to a compiler-generated field
                        class1030.gclass83_0.gclass40_0 = this.gclass40_1;
                    }
                }

                // ISSUE: reference to a compiler-generated field
                this.tvFleetList.SelectedNode.Text = class1030.gclass83_0.method_6();
            }
            else
            {
                int num3 = (int)MessageBox.Show("Please select a naval admin command to be updated");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 928);
        }
    }

    private void cmdRefresh_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 != null)
            {
                this.method_5();
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a race");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 929);
        }
    }

    private void cmdCreateFleet_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show(
                    "Please select an admin command as the parent command for the new fleet");
            }
            else if (this.tvFleetList.SelectedNode.Tag is NavalAdminCommand)
            {
                this.gclass0_0.string_3 = "Enter New Fleet Name";
                this.gclass0_0.string_4 = "New Fleet";
                int num3 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                string string4 = this.gclass0_0.string_4;
                NavalAdminCommand tag = (NavalAdminCommand)this.tvFleetList.SelectedNode.Tag;
                if (tag.gclass146_0 != null)
                    this.gclass21_0.method_307(string4, tag, tag.gclass146_0.SystemBodyData, OperationalGroupID.None);
                else if (tag.gclass40_0 != null)
                    this.gclass21_0.method_307(string4, tag, tag.gclass40_0.gclass85_0.OrbitingBody, OperationalGroupID.None);
                this.gclass21_0.method_355(this.tvFleetList, null, false,
                    AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
            }
            else
            {
                int num4 = (int)MessageBox.Show(
                    "Please select an admin command as the parent command for the new fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 930);
        }
    }

    private void cmdCreateSubFleet_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a parent fleet or sub-fleet for the new sub-fleet");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (this.lstvShips.SelectedItems.Count > 0)
                {
                    SubFleet gclass84 = this.gclass21_0.method_341(tag, null);
                    if (gclass84 == null)
                        return;
                    gclass84.bool_0 = true;
                    foreach (ListViewItem selectedItem in this.lstvShips.SelectedItems)
                        ((FCTShipData40)selectedItem.Tag).gclass84_0 = gclass84;
                    this.gclass21_0.genum42_0 = GEnum42.const_3;
                    this.gclass21_0.int_43 = gclass84.SubFleetID;
                    this.gclass21_0.method_355(this.tvFleetList, null, false,
                        AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
                }
                else if (this.gclass21_0.method_341(tag, null) == null)
                    return;

                this.gclass21_0.method_355(this.tvFleetList, null, false,
                    AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
            }
            else if (this.tvFleetList.SelectedNode.Tag is SubFleet)
            {
                SubFleet tag = (SubFleet)this.tvFleetList.SelectedNode.Tag;
                if (this.gclass21_0.method_341(tag.ParentFleet, tag) == null)
                    return;
                this.gclass21_0.method_355(this.tvFleetList, null, false,
                    AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
            }
            else
            {
                int num3 = (int)MessageBox.Show("Please select a parent fleet or sub-fleet for the new sub-fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 931);
        }
    }

    private void method_6(FleetData gclass85_0)
    {
        try
        {
            if (this.rdoSL.Checked)
                gclass85_0.method_281(this.lstvSystemLocations, this.chkMoon, this.chkComets, this.chkAst,
                    this.chkExcSurveyed, this.chkWaypoint, this.chkLocation, this.chkFleets, this.chkContacts,
                    this.chkCivilian, this.chkWrecks, this.chkLifepods, this.chkExcludeTP, this.chkPlanet,
                    this.chkDwarf);
            else if (this.rdoARSystem.Checked)
            {
                bool bool_25 = this.chkAssumeJumpCapable.CheckState == CheckState.Checked || gclass85_0.method_241();
                gclass85_0.method_280(this.lstvSystemLocations, bool_25);
            }
            else
            {
                if (!this.rdoOrderTemplates.Checked)
                    return;
                if (this.gclass21_0 == null)
                {
                    int num = (int)MessageBox.Show("Please select a race");
                }
                else
                    this.gclass21_0.method_117(this.lstvSystemLocations, gclass85_0.System);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 932);
        }
    }

    public void method_7()
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                this.cmdCreateAdmin.Visible = false;
                this.cmdUpdateAdmin.Visible = false;
                this.cmdCreateFleet.Visible = false;
                this.cmdCreateSubFleet.Visible = false;
                this.cmdCreateSquadron.Visible = false;
                this.cmdSetSpeed.Visible = false;
                this.cmdDetach.Visible = false;
                this.cmdAutoFleetFC.Visible = false;
                this.cmdSelectName.Visible = false;
                this.cmdDetachEscorts.Visible = false;
                this.cmdRecallEscorts.Visible = false;
                this.cmdLaunchAll.Visible = false;
                this.cmdEndOverhaul.Visible = false;
                this.cmdOpenFireAll.Visible = false;
                this.cmdActive2.Visible = false;
                this.cmdFleetShields.Visible = false;
                this.lstvSystemLocations.Items.Clear();
                this.lstvActions.Items.Clear();
                this.lstvLoadItems.Items.Clear();
                this.lstvLoadItems.Visible = false;
                this.lstvOrders.Items.Clear();
                this.method_0();
                if (this.tvFleetList.SelectedNode == null || this.tvFleetList.SelectedNode.Tag == null)
                    return;
                if (this.tvFleetList.SelectedNode.Tag is FleetData)
                    this.method_8((FleetData)this.tvFleetList.SelectedNode.Tag, null, null);
                else if (this.tvFleetList.SelectedNode.Tag is SubFleet)
                {
                    SubFleet tag = (SubFleet)this.tvFleetList.SelectedNode.Tag;
                    this.cmdDetach.Visible = true;
                    this.cmdCreateSubFleet.Visible = true;
                    this.tabNaval.SelectTab(this.tabFleet);
                    this.gclass21_0.genum42_0 = GEnum42.const_3;
                    this.gclass21_0.int_43 = tag.SubFleetID;
                    this.method_8(tag.ParentFleet, tag, null);
                    tag.method_17(this.lstvFormation);
                }
                else if (this.tvFleetList.SelectedNode.Tag is FCTSquadronData70)
                {
                    FCTSquadronData70 tag = (FCTSquadronData70)this.tvFleetList.SelectedNode.Tag;
                    this.cmdDetach.Visible = true;
                    this.tabNaval.SelectTab(this.tabFleet);
                    this.gclass21_0.genum42_0 = GEnum42.const_3;
                    this.gclass21_0.int_43 = tag.SquadronID;
                    this.method_8(tag.ParentShipData.gclass85_0, null, tag);
                }
                else if (this.tvFleetList.SelectedNode.Tag is NavalAdminCommand)
                {
                    this.gclass83_0 = (NavalAdminCommand)this.tvFleetList.SelectedNode.Tag;
                    this.cmdCreateFleet.Visible = true;
                    this.cmdCreateAdmin.Visible = true;
                    this.cmdUpdateAdmin.Visible = true;
                    this.txtImportance.Text = this.gclass83_0.int_2.ToString();
                    this.chkAutoAssign.CheckState = AuroraUtils.smethod_28(this.gclass83_0.bool_1);
                    this.cboBonusOne.SelectedItem = this.gclass0_0.CommanderBonusDictionary[this.gclass83_0.genum121_0];
                    this.cboBonusTwo.SelectedItem = this.gclass0_0.CommanderBonusDictionary[this.gclass83_0.genum121_1];
                    this.cboBonusThree.SelectedItem = this.gclass0_0.CommanderBonusDictionary[this.gclass83_0.genum121_2];
                    CommanderBonus selectedItem = (CommanderBonus)this.cboBonusOne.SelectedItem;
                    this.cboNavalRanks.SelectedItem =
                        this.gclass21_0.RacialRankDictionary.Values.FirstOrDefault<RankThemeEntry>(gclass61_0 =>
                            gclass61_0.RankNum == this.gclass83_0.int_3) ?? this.gclass21_0.RacialRankDictionary.Values
                            .OrderByDescending<RankThemeEntry, int>(gclass61_0 => gclass61_0.RankNum)
                            .FirstOrDefault<RankThemeEntry>();
                    this.lblNACCommander.Text = this.gclass83_0.method_4();
                    this.gclass83_0.method_9(this.lstvAdminCommandSystems);
                    this.gclass21_0.method_187(this.lstvPopulation, this.gclass83_0);
                    this.tabNaval.SelectTab(this.tabAdminCommand);
                    this.gclass21_0.genum42_0 = GEnum42.const_1;
                    this.gclass21_0.int_43 = this.gclass83_0.int_0;
                }
                else if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
                {
                    this.gclass40_0 = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                    this.cmdDetach.Visible = true;
                    this.cmdSelectName.Visible = true;
                    this.cmdCreateSquadron.Visible = true;
                    if (this.gclass40_0.gclass85_0.method_176()
                            .Count<FCTShipData40>(gclass40_2 => gclass40_2.gclass40_0 == this.gclass40_0) > 0)
                        this.cmdLaunchAll.Visible = true;
                    this.method_9();
                }
                else if (this.tvFleetList.SelectedNode.Tag is ShippingLineData)
                {
                    this.gclass187_0 = (ShippingLineData)this.tvFleetList.SelectedNode.Tag;
                    this.gclass21_0.genum42_0 = GEnum42.const_5;
                    this.gclass21_0.int_43 = this.gclass187_0.int_0;
                    this.gclass187_0.method_1(this.lstvSL, this.lstvWealth);
                    this.tabNaval.SelectTab(this.tabShippingLine);
                }

                this.tvFleetList.Select();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3255);
        }
    }

    public void method_8(FleetData gclass85_0, SubFleet gclass84_0, FCTSquadronData70 gclass70_0)
    {
        try
        {
            gclass85_0.method_167(this.lstvShips, gclass84_0, gclass70_0, this.lblLocation, this.lblCommander,
                this.lblFleetData, this.lblCapacity, this.lblDefault, this.lblClassSummary, this.lstvHistory,
                this.chkCycle, this.txtSurveyRadius);
            gclass85_0.method_258(this.lstvOrders);
            this.gclass21_0.method_101(this.tvFleetCargo, gclass85_0, gclass84_0, gclass70_0);
            if (gclass84_0 == null && gclass70_0 == null)
            {
                if (this.bool_0)
                {
                    this.tabFleetPages.TabPages.Clear();
                    foreach (TabPage tabPage in this.dictionary_0.Values)
                        this.tabFleetPages.TabPages.Add(tabPage);
                    this.bool_0 = false;
                }

                this.gclass21_0.method_383(this.tvThreat, this.tvAnchor, gclass85_0, this.chkCurrentContact.CheckState,
                    this.chkCurrentSystem.CheckState);
                gclass85_0.method_259(this.lstvFormation);
                this.cmdCreateSubFleet.Visible = true;
                this.cmdSetSpeed.Visible = true;
                this.cmdAutoFleetFC.Visible = true;
                this.cmdDetach.Visible = true;
                this.cmdDetachEscorts.Visible = true;
                this.cmdRecallEscorts.Visible = true;
                this.cmdActive2.Visible = true;
                this.cmdScrap.Visible = false;
                this.cmdScrapAll.Visible = false;
                this.tvFleetCargo.Height = 641;
                List<FCTShipData40> list1 = gclass85_0.method_176().ToList<FCTShipData40>();
                if (list1.Count<FCTShipData40>(gclass40_0 => gclass40_0.list_17.Count > 0) > 0 &&
                    gclass85_0.method_125(AuroraComponentType.SalvageModule) > 0M)
                {
                    this.cmdScrap.Visible = true;
                    this.cmdScrapAll.Visible = true;
                    this.tvFleetCargo.Height = 611;
                }

                if (list1.Count<FCTShipData40>(gclass40_0 => gclass40_0.gclass40_0 != null) > 0)
                    this.cmdLaunchAll.Visible = true;
                if (list1.Count<FCTShipData40>(gclass40_0 => gclass40_0.genum29_0 == GEnum29.const_1) > 0)
                    this.cmdEndOverhaul.Visible = true;
                List<FCTShipData40> list2 = list1.Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass40_0 == null)
                    .ToList<FCTShipData40>();
                if (list2.Count<FCTShipData40>(gclass40_0 => gclass40_0.bool_8) > 0)
                    this.cmdActive2.Text = "Active Off";
                else
                    this.cmdActive2.Text = "Active On";
                int num = list2.Count<FCTShipData40>(gclass40_0 => gclass40_0.gclass22_0.int_42 > 0);
                if (num > 0)
                {
                    this.cmdFleetShields.Visible = true;
                    if (list2.Count<FCTShipData40>(gclass40_0 => gclass40_0.bool_10) == num)
                        this.cmdFleetShields.Text = "Lower Shields";
                    else
                        this.cmdFleetShields.Text = "Raise Shields";
                }

                this.tabNaval.SelectTab(this.tabFleet);
                this.method_6(gclass85_0);
                if (this.chkSelectOnMap.CheckState == CheckState.Checked)
                    this.gclass0_0.method_522(gclass85_0);
                gclass85_0.method_197(this.lstvStandingOrdersList);
                this.chkDanger.CheckState = AuroraUtils.smethod_28(gclass85_0.bAvoidDanger);
                this.chkExcludeAlien.CheckState = AuroraUtils.smethod_28(gclass85_0.bAvoidAlienSystem);
                this.chkAssumeJumpCapable.CheckState = AuroraUtils.smethod_28(gclass85_0.bAssumeJumpCapable);
                this.chkSensorDisplay.CheckState = AuroraUtils.smethod_28(gclass85_0.bDisplaySensors);
                this.chkWeaponDisplay.CheckState = AuroraUtils.smethod_28(gclass85_0.bDisplayWeapons);
                this.chkMaxSpeed.CheckState = AuroraUtils.smethod_28(gclass85_0.bUseMaximumSpeed);
                this.chkDetachedStanding.CheckState = AuroraUtils.smethod_28(gclass85_0.bDetachedStanding);
                this.chkDetachedConditional.CheckState = AuroraUtils.smethod_28(gclass85_0.bDetachedCondition);
                this.chkIncludeSquadrons.CheckState = AuroraUtils.smethod_28(gclass85_0.bIncludeSquadrons);
                this.chkIgnoreSO.CheckState = AuroraUtils.smethod_28(gclass85_0.bIgnoreStanding);
                this.chkIgnoreCO.CheckState = AuroraUtils.smethod_28(gclass85_0.bIgnoreConditional);
                this.gclass21_0.genum42_0 = GEnum42.const_2;
                this.gclass21_0.int_43 = gclass85_0.FleetID;
                if (gclass85_0.ShippingLine != null && !this.gclass0_0.bool_10)
                {
                    this.tvStandingOrders.Visible = false;
                    this.lstvConditionOne.Visible = false;
                    this.flpFleetOrderButtons.Visible = false;
                    this.cmdDetach.Visible = false;
                }
                else
                {
                    this.tvStandingOrders.Visible = true;
                    this.lstvConditionOne.Visible = true;
                    this.flpFleetOrderButtons.Visible = true;
                    this.cmdDetach.Visible = true;
                }
            }
            else
            {
                this.tabNaval.SelectTab(this.tabFleet);
                if (!this.bool_0)
                {
                    this.tabFleetPages.TabPages.Clear();
                    this.tabFleetPages.TabPages.Add(this.dictionary_0["tabShipList"]);
                    this.tabFleetPages.TabPages.Add(this.dictionary_0["tabCargo"]);
                    this.bool_0 = true;
                }

                if (gclass84_0 == null ||
                    gclass84_0.method_0().Count<FCTShipData40>(gclass40_0 => gclass40_0.gclass40_0 != null) <= 0)
                    return;
                this.cmdLaunchAll.Visible = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3464);
        }
    }

    private void tvFleetList_AfterSelect(object sender, TreeViewEventArgs e)
    {
        try
        {
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 933);
        }
    }

    private void method_9()
    {
        try
        {
            this.txtShipSummary.Text = this.gclass40_0.method_164(AuroraUtils.smethod_67(this.txtTargetSpeed.Text),
                AuroraUtils.smethod_67(this.txtRangeBand.Text), this.cboRefuelActive, this.cboResupplyActive,
                this.cboTransferActive, this.cboHangar, this.flpEnergyWeaponData, this.lstvMeasurement,
                this.lstvLogistics, this.lstvCrew, this.lstvOrdnance, this.lstvOfficers, this.lstvDAC,
                this.lstvDamageControlQueue, this.lstvMeasurement, this.lstvShipHistory,
                AuroraUtils.smethod_67(this.txtRepairChanceTime.Text));
            this.gclass40_0.gclass22_0.method_85(0, 0, "");
            this.txtClassDisplay.Text = this.gclass40_0.gclass22_0.string_0;
            this.txtFuelPriority.Text = AuroraUtils.smethod_37(this.gclass40_0.int_18);
            this.txtSupplyPriority.Text = AuroraUtils.smethod_37(this.gclass40_0.int_19);
            this.chkAutoDC.CheckState = AuroraUtils.smethod_28(this.gclass40_0.bool_14);
            this.chkRetainData.CheckState = AuroraUtils.smethod_26(this.gclass40_0.int_14);
            this.ckhTarget.CheckState = AuroraUtils.smethod_26(this.gclass40_0.int_24);
            this.panArmour.Refresh();
            this.gclass40_0.method_37(this.tvCombatAssignment, this.tvTargets, this.bool_1);
            this.gclass40_0.gclass22_0.method_63(this.lstvClassTemplate);
            this.gclass40_0.method_63(this.lstvShipTemplate);
            this.gclass40_0.method_64(this.lstvShipLoadout);
            this.gclass21_0.method_102(this.tvShipCargo, this.gclass40_0);
            if (this.tabNaval.SelectedTab != this.tabCombat)
                this.tabNaval.SelectTab(this.tabShipDisplay);
            if (this.gclass40_0.method_177() > 0M)
            {
                if (this.gclass40_0.genum29_0 == GEnum29.const_1)
                {
                    this.cmdOpenFireAll.Visible = false;
                }
                else
                {
                    this.cmdOpenFireAll.Visible = true;
                    if (this.gclass40_0.list_4.Where<FireControlAssignment>(gclass36_0 => gclass36_0.IsOpeningFire)
                            .FirstOrDefault<FireControlAssignment>() == null)
                        this.cmdOpenFireAll.Text = "Open Fire All";
                    else
                        this.cmdOpenFireAll.Text = "Cease Fire All";
                }
            }

            if (this.gclass40_0.int_17 == 1)
                this.cmdSyncFire.Text = "Sync Fire Off";
            else
                this.cmdSyncFire.Text = "Sync Fire On";
            if (this.gclass40_0.method_178() > 0.0)
            {
                this.cmdActive2.Visible = true;
                if (this.gclass40_0.bool_8)
                    this.cmdActive2.Text = "Active Off";
                else
                    this.cmdActive2.Text = "Active On";
            }

            if (this.gclass40_0.method_178() > 0.0)
            {
                this.cmdActive2.Visible = true;
                if (this.gclass40_0.bool_8)
                    this.cmdActive2.Text = "Active Off";
                else
                    this.cmdActive2.Text = "Active On";
            }

            if (this.gclass40_0.gclass22_0.int_42 > 0)
            {
                this.cmdFleetShields.Visible = true;
                if (this.gclass40_0.bool_10)
                    this.cmdFleetShields.Text = "Lower Shields";
                else
                    this.cmdFleetShields.Text = "Raise Shields";
            }

            if (this.gclass40_0.genum29_0 == GEnum29.const_1)
                this.cmdEndOverhaul.Visible = true;
            if (this.gclass40_0.method_157(AuroraComponentType.Shields, false) > 0M)
            {
                this.cmdFleetShields.Visible = true;
                if (this.gclass40_0.bool_10)
                    this.cmdFleetShields.Text = "Lower Shields";
                else
                    this.cmdFleetShields.Text = "Raise Shields";
            }

            this.gclass21_0.genum42_0 = GEnum42.const_4;
            this.gclass21_0.int_43 = this.gclass40_0.int_8;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 934);
        }
    }

    private void cmdDelete_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select an item to delete");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
            {
                FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                if (MessageBox.Show($" Are you sure you want to delete {tag.ShipName}?", "Confirmation Required",
                        MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.gclass21_0.method_303(tag, GEnum22.const_0);
                this.gclass21_0.method_355(this.tvFleetList, null, false,
                    AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (MessageBox.Show($" Are you sure you want to delete the fleet '{tag.FleetName}'?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.gclass21_0.method_302(tag, true);
                this.gclass21_0.method_355(this.tvFleetList, null, false,
                    AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
            }
            else if (this.tvFleetList.SelectedNode.Tag is SubFleet)
            {
                SubFleet tag = (SubFleet)this.tvFleetList.SelectedNode.Tag;
                if (MessageBox.Show($" Are you sure you want to delete the sub fleet '{tag.SubFleetName}'?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                tag.ParentFleet.method_163(tag);
                this.gclass21_0.method_355(this.tvFleetList, null, false,
                    AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
            }
            else if (this.tvFleetList.SelectedNode.Tag is FCTSquadronData70)
            {
                FCTSquadronData70 tag = (FCTSquadronData70)this.tvFleetList.SelectedNode.Tag;
                if (MessageBox.Show($" Are you sure you want to delete '{tag.SquadronName}'?", "Confirmation Required",
                        MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                tag.ParentShipData.method_54(tag);
                this.gclass21_0.method_355(this.tvFleetList, null, false,
                    AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
            }
            else if (this.tvFleetList.SelectedNode.Tag is NavalAdminCommand)
            {
                NavalAdminCommand tag = (NavalAdminCommand)this.tvFleetList.SelectedNode.Tag;
                if (tag.ParentAdminCommand == null)
                {
                    int num3 = (int)MessageBox.Show("The highest level administrative commands may not be deleted");
                }
                else
                {
                    if (MessageBox.Show($" Are you sure you want to delete the Admin Command '{tag.AdminCommandName}'?",
                            "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                    this.gclass0_0.method_560(tag);
                    this.gclass21_0.method_355(this.tvFleetList, null, false,
                        AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
                }
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is ShippingLineData))
                    return;
                ShippingLineData tag = (ShippingLineData)this.tvFleetList.SelectedNode.Tag;
                if (MessageBox.Show($" Are you sure you want to delete the Shipping Line '{tag.string_0}'?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.gclass0_0.method_561(tag);
                this.gclass21_0.method_355(this.tvFleetList, null, false,
                    AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 935);
        }
    }

    private void cmdRename_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select an item to rename");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                string str = this.gclass0_0.method_562("Enter New Fleet Name", tag.FleetName);
                if (str != "")
                    tag.FleetName = str;
                this.tvFleetList.SelectedNode.Text = tag.FleetName;
            }
            else if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
            {
                FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                string str = this.gclass0_0.method_562("Enter New Ship Name", tag.ShipName);
                if (str != "")
                    tag.ShipName = str;
                this.tvFleetList.SelectedNode.Text = tag.method_187();
            }
            else if (this.tvFleetList.SelectedNode.Tag is FCTSquadronData70)
            {
                FCTSquadronData70 tag = (FCTSquadronData70)this.tvFleetList.SelectedNode.Tag;
                string str = this.gclass0_0.method_562("Enter New Squadron Name", tag.SquadronName);
                if (str != "")
                    tag.SquadronName = str;
                this.tvFleetList.SelectedNode.Text = tag.SquadronName;
            }
            else if (this.tvFleetList.SelectedNode.Tag is SubFleet)
            {
                SubFleet tag = (SubFleet)this.tvFleetList.SelectedNode.Tag;
                string str = this.gclass0_0.method_562("Enter New Sub Fleet Name", tag.SubFleetName);
                if (str != "")
                    tag.SubFleetName = str;
                this.tvFleetList.SelectedNode.Text = tag.SubFleetName;
            }
            else if (this.tvFleetList.SelectedNode.Tag is NavalAdminCommand)
            {
                NavalAdminCommand tag = (NavalAdminCommand)this.tvFleetList.SelectedNode.Tag;
                string str = this.gclass0_0.method_562("Enter New Admin Command Name", tag.AdminCommandName);
                if (str != "")
                    tag.AdminCommandName = str;
                this.tvFleetList.SelectedNode.Text = tag.method_6();
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is ShippingLineData))
                    return;
                ShippingLineData tag = (ShippingLineData)this.tvFleetList.SelectedNode.Tag;
                string str1 = this.gclass0_0.method_562("Enter New Shipping Line Name", tag.string_0);
                if (str1 != "")
                    tag.string_0 = str1;
                string str2 = this.gclass0_0.method_562("Enter New Shipping Line Short Name", tag.string_1);
                if (str2 != "")
                    tag.string_1 = str2;
                this.tvFleetList.SelectedNode.Text = tag.string_0;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 936);
        }
    }

    private void tvFleetList_AfterExpand(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (e.Node.Tag is FleetData)
                ((FleetData)e.Node.Tag).bool_16 = true;
            else if (e.Node.Tag is FCTShipData40)
                ((FCTShipData40)e.Node.Tag).bool_12 = true;
            else if (e.Node.Tag is FCTSquadronData70)
                ((FCTSquadronData70)e.Node.Tag).bool_0 = true;
            else if (e.Node.Tag is SubFleet)
            {
                ((SubFleet)e.Node.Tag).bool_0 = true;
            }
            else
            {
                if (!(e.Node.Tag is NavalAdminCommand))
                    return;
                ((NavalAdminCommand)e.Node.Tag).bool_0 = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 937);
        }
    }

    private void tvFleetList_AfterCollapse(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (e.Node.Tag is FleetData)
                ((FleetData)e.Node.Tag).bool_16 = false;
            else if (e.Node.Tag is FCTShipData40)
                ((FCTShipData40)e.Node.Tag).bool_12 = false;
            else if (e.Node.Tag is FCTSquadronData70)
                ((FCTSquadronData70)e.Node.Tag).bool_0 = false;
            else if (e.Node.Tag is SubFleet)
            {
                ((SubFleet)e.Node.Tag).bool_0 = false;
            }
            else
            {
                if (!(e.Node.Tag is NavalAdminCommand))
                    return;
                ((NavalAdminCommand)e.Node.Tag).bool_0 = false;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 938);
        }
    }

    private void cmdSetSpeed_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet");
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is FleetData))
                    return;
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                string str = this.gclass0_0.method_562("Enter New Fleet Speed", tag.Speed.ToString());
                if (!(str != ""))
                    return;
                tag.method_160(Convert.ToInt32(str));
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 939);
        }
    }

    private void chkFilterOrders_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet");
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is FleetData))
                    return;
                ((FleetData)this.tvFleetList.SelectedNode.Tag).method_281(this.lstvSystemLocations, this.chkMoon,
                    this.chkComets, this.chkAst, this.chkExcSurveyed, this.chkWaypoint, this.chkLocation,
                    this.chkFleets, this.chkContacts, this.chkCivilian, this.chkWrecks, this.chkLifepods,
                    this.chkExcludeTP, this.chkPlanet, this.chkDwarf);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 940);
        }
    }

    private void method_10(ListView listView_0, StandingOrderDefinition gclass136_0)
    {
        try
        {
            foreach (ListViewItem listViewItem in listView_0.Items)
            {
                listViewItem.Selected = false;
                if ((StandingOrderDefinition)listViewItem.Tag == gclass136_0)
                    listViewItem.Selected = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 943);
        }
    }

    private void method_11(ListView listView_0, FleetConditionDefinition gclass137_0)
    {
        try
        {
            foreach (ListViewItem listViewItem in listView_0.Items)
            {
                listViewItem.Selected = false;
                if ((FleetConditionDefinition)listViewItem.Tag == gclass137_0)
                    listViewItem.Selected = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 944);
        }
    }

    private void lstvActions_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvActions.SelectedItems.Count == 0)
                return;
            this.lstvLoadItems.Items.Clear();
            this.lstvLoadItems.Visible = false;
            this.method_0();
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet");
            }
            else if (this.lstvSystemLocations.SelectedItems.Count == 0)
            {
                int num3 = (int)MessageBox.Show("Please select a destination for the move order");
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is FleetData))
                    return;
                FleetData tag1 = (FleetData)this.tvFleetList.SelectedNode.Tag;
                GClass134 tag2 = (GClass134)this.lstvSystemLocations.SelectedItems[0].Tag;
                MoveActionDefinition tag3 = (MoveActionDefinition)this.lstvActions.SelectedItems[0].Tag;
                this.lstvLoadItems.Items.Clear();
                if (tag3.DestinationItemType != DestinationItemType.const_0)
                {
                    this.lstvLoadItems.Visible = true;
                    tag1.method_283(tag3.DestinationItemType, tag2, this.lstvLoadItems);
                }
                else
                    this.lstvLoadItems.Visible = false;

                if (tag3.SpecifyQuanitity)
                {
                    this.lblMaxItems.Visible = true;
                    this.txtMaxItems.Visible = true;
                }

                if (tag3.MinQuantity)
                {
                    this.lblMinAvailable.Visible = true;
                    this.txtMinAvailable.Visible = true;
                }

                if (tag3.MinDistanceOption)
                {
                    this.lblMinDistance.Visible = true;
                    this.txtMinDistance.Visible = true;
                }

                if (tag3.MoveActionType == MoveActionType.ExtendedOrbit)
                {
                    this.lblOrbDistance.Visible = true;
                    this.txtOrbDistance.Visible = true;
                }

                if (!tag3.LoadGroundUnit)
                    return;
                this.chkLoadSubUnits.Visible = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 945);
        }
    }

    private void cmdAddMove_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_12(CheckState.Unchecked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 946);
        }
    }

    private void method_12(CheckState checkState_0)
    {
        try
        {
            this.lstvLoadItems.Visible = false;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet");
            }
            else if (this.lstvSystemLocations.SelectedItems.Count == 0)
            {
                int num3 = (int)MessageBox.Show("Please select a destination for the move order");
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is FleetData))
                    return;
                FleetData tag1 = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (tag1.method_46())
                {
                    int num4 = (int)MessageBox.Show(
                        "Orders cannot be assigned to a fleet which contains ships in a shipyard");
                }
                else if (tag1.method_47())
                {
                    int num5 = (int)MessageBox.Show(
                        "Orders cannot be assigned to a fleet that contains an active mobile shipyard");
                }
                else if (tag1.CivilianFunction != CivilanFunctionType.const_0)
                {
                    int num6 = (int)MessageBox.Show(
                        "Orders cannot be assigned to a civilian or computer-controlled fleet");
                }
                else if (tag1.method_9())
                {
                    int num7 = (int)MessageBox.Show(
                        "Fleet cannot receive further orders if already ordered to transit an unexplored jump point");
                }
                else
                {
                    bool flag = true;
                    if (this.rdoSL.Checked)
                    {
                        MoveActionDefinition gclass133 = new MoveActionDefinition();
                        GClass134 tag2 = (GClass134)this.lstvSystemLocations.SelectedItems[0].Tag;
                        MoveActionDefinition tag3;
                        if (this.lstvActions.SelectedItems.Count == 0)
                        {
                            if (checkState_0 == CheckState.Checked)
                            {
                                if (tag2.genum13_0 == DestinationType.const_0)
                                    tag3 = this.gclass0_0.MoveActionDictionary[MoveActionType.StandardTransit];
                                else if (tag2.genum13_0 == DestinationType.const_10)
                                    tag3 = this.gclass0_0.MoveActionDictionary[MoveActionType.MoveTo];
                                else if (tag2.gclass146_0 != null)
                                    tag3 = this.gclass0_0.MoveActionDictionary[MoveActionType.RefuelAndResupplyFromColony];
                                else if (tag2.genum13_0 == DestinationType.const_4)
                                    tag3 = this.gclass0_0.MoveActionDictionary[MoveActionType.FollowTarget];
                                else if (tag2.genum13_0 == DestinationType.const_7)
                                    tag3 = this.gclass0_0.MoveActionDictionary[MoveActionType.JoinFleet];
                                else if (tag2.genum13_0 == DestinationType.const_1)
                                    tag3 = this.gclass0_0.MoveActionDictionary[MoveActionType.GeologicalSurvey];
                                else if (tag2.genum13_0 == DestinationType.const_2)
                                    tag3 = this.gclass0_0.MoveActionDictionary[MoveActionType.GravitationalSurvey];
                                else if (tag2.genum13_0 == DestinationType.const_6)
                                {
                                    tag3 = this.gclass0_0.MoveActionDictionary[MoveActionType.SalvageWreck];
                                    flag = false;
                                }
                                else if (tag2.genum13_0 == DestinationType.const_3)
                                    tag3 = this.gclass0_0.MoveActionDictionary[MoveActionType.MoveTo];
                                else if (tag2.genum13_0 == DestinationType.const_5)
                                {
                                    tag3 = this.gclass0_0.MoveActionDictionary[MoveActionType.RescueSurvivors];
                                }
                                else
                                {
                                    int num8 = (int)MessageBox.Show("Please select an action for the move order");
                                    return;
                                }
                            }
                            else
                            {
                                int num9 = (int)MessageBox.Show("Please select an action for the move order");
                                return;
                            }
                        }
                        else
                            tag3 = (MoveActionDefinition)this.lstvActions.SelectedItems[0].Tag;

                        object object_0 = null;
                        if (tag3.DestinationItemType != DestinationItemType.const_0)
                        {
                            if (this.lstvLoadItems.SelectedItems.Count == 0)
                            {
                                int num10 = (int)MessageBox.Show("Please select the target of the order");
                                return;
                            }

                            object_0 = this.lstvLoadItems.SelectedItems[0].Tag;
                        }

                        Decimal decimal_9 = 0M;
                        double double_11 = 0.0;
                        int int_14 = 0;
                        bool bool_25 = false;
                        if (this.txtMaxItems.Visible)
                        {
                            ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.txtMaxItems.Text);
                            if (gclass208.Succeed)
                                decimal_9 = gclass208.Value;
                        }

                        if (this.txtMinDistance.Visible)
                            double_11 = Convert.ToDouble(this.txtMinDistance.Text);
                        int int32 = !this.txtMinAvailable.Visible ? 0 : Convert.ToInt32(this.txtMinAvailable.Text);
                        if (this.txtOrbDistance.Visible)
                            int_14 = Convert.ToInt32(this.txtOrbDistance.Text);
                        int int_13 = 0;
                        if (this.txtOrderDelay.Text != "")
                            int_13 = Convert.ToInt32(this.txtOrderDelay.Text);
                        if (this.chkLoadSubUnits.Visible)
                            bool_25 = AuroraUtils.smethod_27(this.chkLoadSubUnits.CheckState);
                        tag1.method_264(tag2, tag3, object_0, decimal_9, double_11, int32, int_13, int_14, bool_25,
                            this.chkAutoLP.CheckState);
                        tag1.method_258(this.lstvOrders);
                        if (flag)
                            tag1.method_281(this.lstvSystemLocations, this.chkMoon, this.chkComets, this.chkAst,
                                this.chkExcSurveyed, this.chkWaypoint, this.chkLocation, this.chkFleets,
                                this.chkContacts, this.chkCivilian, this.chkWrecks, this.chkLifepods, this.chkExcludeTP,
                                this.chkPlanet, this.chkDwarf);
                        foreach (ListViewItem listViewItem in this.lstvSystemLocations.Items)
                        {
                            GClass134 tag4 = (GClass134)listViewItem.Tag;
                            if (tag4.int_0 == tag2.int_0 && tag4.genum13_0 == tag2.genum13_0)
                            {
                                listViewItem.Selected = true;
                                break;
                            }
                        }
                    }
                    else if (this.rdoARSystem.Checked)
                    {
                        RacialSystemSurvey tag5 = (RacialSystemSurvey)this.lstvSystemLocations.SelectedItems[0].Tag;
                        bool bool_25 = false;
                        if (this.chkAssumeJumpCapable.CheckState == CheckState.Checked)
                            bool_25 = true;
                        RacialSystemSurvey gclass202_1 = tag1.method_261();
                        tag1.method_237(gclass202_1, GEnum109.const_41, "Move to Target System", bool_25,
                            tag5.ActualSystemData.SystemID, false, false, true);
                        tag1.method_258(this.lstvOrders);
                        this.rdoSL.Checked = true;
                    }
                    else if (this.rdoOrderTemplates.Checked)
                    {
                        ((OrderTemplateData)this.lstvSystemLocations.SelectedItems[0].Tag).method_0(tag1);
                        tag1.method_258(this.lstvOrders);
                        this.rdoSL.Checked = true;
                    }

                    this.lblLocation.Text = tag1.method_166();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3210);
        }
    }

    private void cmdRemoveLastOrder_Click(object sender, EventArgs e)
    {
        try
        {
            this.lstvLoadItems.Visible = false;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet");
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is FleetData))
                    return;
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                tag.method_262();
                tag.method_258(this.lstvOrders);
                tag.method_281(this.lstvSystemLocations, this.chkMoon, this.chkComets, this.chkAst, this.chkExcSurveyed,
                    this.chkWaypoint, this.chkLocation, this.chkFleets, this.chkContacts, this.chkCivilian,
                    this.chkWrecks, this.chkLifepods, this.chkExcludeTP, this.chkPlanet, this.chkDwarf);
                this.lblLocation.Text = tag.method_166();
                this.lstvActions.Items.Clear();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 947);
        }
    }

    private void cmdRemoveAll_Click(object sender, EventArgs e)
    {
        try
        {
            this.lstvLoadItems.Visible = false;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet");
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is FleetData))
                    return;
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                tag.method_263();
                if (tag.Race.NPR)
                {
                    tag.NPRSomething.bRedeployOrderGiven = false;
                    tag.NPRSomething.gclass202_0 = null;
                }

                tag.method_258(this.lstvOrders);
                tag.method_281(this.lstvSystemLocations, this.chkMoon, this.chkComets, this.chkAst, this.chkExcSurveyed,
                    this.chkWaypoint, this.chkLocation, this.chkFleets, this.chkContacts, this.chkCivilian,
                    this.chkWrecks, this.chkLifepods, this.chkExcludeTP, this.chkPlanet, this.chkDwarf);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 948);
        }
    }

    private void tvCombatAssignment_AfterSelect(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvCombatAssignment.SelectedNode.Tag is FireControlAssignment)
            {
                if (((FireControlAssignment)this.tvCombatAssignment.SelectedNode.Tag).IsOpeningFire)
                    this.cmdOpenFire.Text = "Cease Fire FC";
                else
                    this.cmdOpenFire.Text = "Open Fire FC";
            }
            else if (this.tvCombatAssignment.SelectedNode.Tag is WeaponFireControlAssignment)
            {
                WeaponFireControlAssignment tag1 = (WeaponFireControlAssignment)this.tvCombatAssignment.SelectedNode.Tag;
            }
            else if (this.tvCombatAssignment.SelectedNode.Tag is GClass130)
            {
                GClass130 tag2 = (GClass130)this.tvCombatAssignment.SelectedNode.Tag;
            }
            else
            {
                if (!(this.tvCombatAssignment.SelectedNode.Tag is GClass65))
                    return;
                GClass65 tag3 = (GClass65)this.tvCombatAssignment.SelectedNode.Tag;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 949);
        }
    }

    private void tvCombatAssignment_DragDrop(object sender, DragEventArgs e)
    {
        try
        {
            if (!(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            FCTShipData40 tag1 = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
            TreeNode nodeAt =
                this.tvCombatAssignment.GetNodeAt(this.tvCombatAssignment.PointToClient(new Point(e.X, e.Y)));
            TreeNode data = (TreeNode)e.Data.GetData(typeof(TreeNode));
            bool flag = false;
            int int_40 = 0;
            if (this.chkDragNum.CheckState == CheckState.Checked)
                int_40 = AuroraUtils.smethod_67(this.txtAssignNum.Text);
            if (data.Equals(nodeAt) || nodeAt == null)
                return;
            if (data.Tag is WeaponFireControlAssignment)
            {
                WeaponFireControlAssignment tag2 = (WeaponFireControlAssignment)data.Tag;
                if (nodeAt.Tag is FireControlAssignment)
                {
                    FireControlAssignment tag3 = (FireControlAssignment)nodeAt.Tag;
                    if (tag3.FCComponent.gclass231_0.ComponentTypeID == AuroraComponentType.BeamFireControl &&
                        !tag2.WeaponComponent.bool_4)
                    {
                        int num = (int)MessageBox.Show("Missile weapons cannot be assigned to beam fire controls");
                        return;
                    }

                    if (tag3.FCComponent.gclass231_0.ComponentTypeID == AuroraComponentType.MissileFireControl &&
                        tag2.WeaponComponent.bool_4)
                    {
                        int num = (int)MessageBox.Show("Energy weapons cannot be assigned to missile fire controls");
                        return;
                    }

                    tag1.method_25(tag3, tag2, this.chkDragAll.CheckState, this.chkDragNum.CheckState, int_40);
                    flag = true;
                }

                if (nodeAt.Tag is string && (string)nodeAt.Tag == "Unassigned")
                {
                    tag1.method_29(tag2, this.chkDragAll.CheckState, this.chkDragNum.CheckState, int_40);
                    flag = true;
                }
            }
            else if (data.Tag is FCTDecoyAssignmentData32)
            {
                FCTDecoyAssignmentData32 tag4 = (FCTDecoyAssignmentData32)data.Tag;
                if (nodeAt.Tag is string && (string)nodeAt.Tag == "Unassigned")
                {
                    tag1.method_30(tag4, this.chkDragAll.CheckState, this.chkDragNum.CheckState, int_40);
                    flag = true;
                }
            }
            else if (data.Tag is GClass35)
            {
                GClass35 tag5 = (GClass35)data.Tag;
                if (nodeAt.Tag is FireControlAssignment)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    FleetWindow.Class1031 class1031 = new FleetWindow.Class1031();
                    // ISSUE: reference to a compiler-generated field
                    class1031.gclass36_0 = (FireControlAssignment)nodeAt.Tag;
                    // ISSUE: reference to a compiler-generated field
                    if (class1031.gclass36_0.FCComponent.gclass231_0.ComponentTypeID ==
                        AuroraComponentType.BeamFireControl && !tag5.gclass230_0.bool_4)
                    {
                        int num = (int)MessageBox.Show("Missile weapons cannot be assigned to beam fire controls");
                        return;
                    }

                    // ISSUE: reference to a compiler-generated field
                    if (class1031.gclass36_0.FCComponent.gclass231_0.ComponentTypeID ==
                        AuroraComponentType.MissileFireControl && tag5.gclass230_0.bool_4)
                    {
                        int num = (int)MessageBox.Show("Energy weapons cannot be assigned to missile fire controls");
                        return;
                    }

                    if (tag5.gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.DecoyMissileLauncher)
                    {
                        int num = (int)MessageBox.Show("Decoy launchers cannot be assigned to fire controls");
                        return;
                    }

                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    if (class1031.gclass36_0.FCComponent.genum87_0 == GEnum87.const_6 &&
                        tag1.list_2.Count<WeaponFireControlAssignment>(class1031.method_0) > 0)
                    {
                        int num = (int)MessageBox.Show("Only a single weapon can be assigned to this fire control");
                        return;
                    }

                    // ISSUE: reference to a compiler-generated field
                    tag1.method_33(class1031.gclass36_0, tag5, this.chkDragAll.CheckState, this.chkDragNum.CheckState,
                        int_40);
                    flag = true;
                }
                else if (nodeAt.Tag is string && (string)nodeAt.Tag == "Decoys")
                {
                    if (tag5.gclass230_0.gclass231_0.ComponentTypeID != AuroraComponentType.DecoyMissileLauncher)
                    {
                        int num = (int)MessageBox.Show("Only Decoy Launchers cannot be assigned to the decoys section");
                        return;
                    }

                    tag1.method_34(tag5, this.chkDragAll.CheckState, this.chkDragNum.CheckState, int_40);
                    flag = true;
                }
            }
            else if (data.Tag is GClass130)
            {
                GClass130 tag6 = (GClass130)data.Tag;
                if (nodeAt.Tag is WeaponFireControlAssignment)
                {
                    WeaponFireControlAssignment tag7 = (WeaponFireControlAssignment)nodeAt.Tag;
                    if (tag6.gclass129_0.int_14 == 1 && tag7.WeaponComponent.gclass231_0.ComponentTypeID !=
                        AuroraComponentType.DecoyMissileLauncher)
                    {
                        int num = (int)MessageBox.Show("Decoy Missiles can only be assigned to Decoy Launchers");
                        return;
                    }

                    if (tag6.gclass129_0.int_14 == 0 && tag7.WeaponComponent.gclass231_0.ComponentTypeID ==
                        AuroraComponentType.DecoyMissileLauncher)
                    {
                        int num = (int)MessageBox.Show("Only Decoy Missiles can be assigned to Decoy Launchers");
                        return;
                    }

                    tag1.method_35(tag7, tag6, this.chkDragAll.CheckState, this.chkDragNum.CheckState, int_40);
                    flag = true;
                }
                else if (nodeAt.Tag is FCTDecoyAssignmentData32)
                {
                    FCTDecoyAssignmentData32 tag8 = (FCTDecoyAssignmentData32)nodeAt.Tag;
                    tag1.method_36(tag8, tag6, this.chkDragAll.CheckState, this.chkDragNum.CheckState, int_40);
                    flag = true;
                }
            }
            else if (data.Tag is AuroraPointDefenceMode)
            {
                AuroraPointDefenceMode tag9 = (AuroraPointDefenceMode)data.Tag;
                if (nodeAt.Tag is FireControlAssignment)
                {
                    FireControlAssignment tag10 = (FireControlAssignment)nodeAt.Tag;
                    if (tag10.FCComponent.gclass231_0.ComponentTypeID == AuroraComponentType.BeamFireControl &&
                        tag9 > AuroraPointDefenceMode.PointBlankDefensiveFire)
                    {
                        int num = (int)MessageBox.Show(
                            "Missile-based point defence modes cannot be assigned to beam fire controls");
                        return;
                    }

                    if (tag10.FCComponent.gclass231_0.ComponentTypeID == AuroraComponentType.MissileFireControl &&
                        tag9 < AuroraPointDefenceMode.PointBlankDefensiveFireSelf &&
                        tag9 != AuroraPointDefenceMode.None)
                    {
                        int num = (int)MessageBox.Show(
                            "Energy weapon-based point defence modes cannot be assigned to missile fire controls");
                        return;
                    }

                    tag1.method_28(tag10, tag9);
                    flag = true;
                }
            }
            else if (data.Tag is AuroraPointDefencePriority)
            {
                AuroraPointDefencePriority tag11 = (AuroraPointDefencePriority)data.Tag;
                if (nodeAt.Tag is FireControlAssignment)
                {
                    FireControlAssignment tag12 = (FireControlAssignment)nodeAt.Tag;
                    if (tag12.FCComponent.gclass231_0.ComponentTypeID == AuroraComponentType.MissileFireControl)
                    {
                        int num = (int)MessageBox.Show(
                            "Beam fire control priorities cannot be assigned to missile fire controls");
                        return;
                    }

                    tag12.PointDefencePriority = tag11;
                    flag = true;
                }
            }
            else if (data.Tag is AuroraPointDefenceConcentration)
            {
                AuroraPointDefenceConcentration tag13 = (AuroraPointDefenceConcentration)data.Tag;
                if (nodeAt.Tag is FireControlAssignment)
                {
                    FireControlAssignment tag14 = (FireControlAssignment)nodeAt.Tag;
                    if (tag14.FCComponent.gclass231_0.ComponentTypeID == AuroraComponentType.MissileFireControl)
                    {
                        int num = (int)MessageBox.Show(
                            "Beam fire control concentration cannot be assigned to missile fire controls");
                        return;
                    }

                    tag14.PointDefenceConcentration = tag13;
                    flag = true;
                }
            }
            else if (data.Tag is GClass65)
            {
                GClass65 tag15 = (GClass65)data.Tag;
                if (nodeAt.Tag is FireControlAssignment)
                {
                    if (this.chkDragAll.CheckState == CheckState.Unchecked)
                    {
                        FireControlAssignment tag16 = (FireControlAssignment)nodeAt.Tag;
                        tag1.method_26(tag16, tag15);
                        flag = true;
                    }
                    else
                    {
                        foreach (FireControlAssignment gclass36_0 in tag1.list_4)
                            tag1.method_26(gclass36_0, tag15);
                        flag = true;
                    }

                    if (!tag1.bool_15)
                    {
                        tag1.int_13 = tag1.method_86(GEnum14.const_0);
                        tag1.bool_15 = true;
                        flag = true;
                    }
                }
            }
            else if (data.Tag is GClass214)
            {
                GClass214 tag17 = (GClass214)data.Tag;
                if (nodeAt.Tag is FireControlAssignment)
                {
                    FireControlAssignment tag18 = (FireControlAssignment)nodeAt.Tag;
                    if (tag18.FCComponent.gclass231_0.ComponentTypeID != AuroraComponentType.MissileFireControl)
                    {
                        int num = (int)MessageBox.Show("Waypoints may only be assigned to missile fire controls");
                        return;
                    }

                    tag1.method_27(tag18, tag17);
                    flag = true;
                }
            }

            if (flag)
            {
                data.Remove();
                nodeAt.Nodes.Add(data);
            }

            tag1.method_37(this.tvCombatAssignment, this.tvTargets, this.bool_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 950);
        }
    }

    private void tvCombatAssignment_DragEnter(object sender, DragEventArgs e)
    {
        e.Effect = DragDropEffects.Move;
    }

    private void tvCombatAssignment_ItemDrag(object sender, ItemDragEventArgs e)
    {
        int num = (int)this.DoDragDrop(e.Item, DragDropEffects.Move);
    }

    private void tvCombatAssignment_AfterExpand(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                if (!(e.Node.Tag is FireControlAssignment))
                    return;
                ((FireControlAssignment)e.Node.Tag).NodeViewExpanded = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 951);
        }
    }

    private void tvCombatAssignment_AfterCollapse(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                if (!(e.Node.Tag is FireControlAssignment))
                    return;
                ((FireControlAssignment)e.Node.Tag).NodeViewExpanded = false;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 952);
        }
    }

    private void tvTargets_DragEnter(object sender, DragEventArgs e)
    {
        e.Effect = DragDropEffects.Move;
    }

    private void tvTargets_ItemDrag(object sender, ItemDragEventArgs e)
    {
        int num = (int)this.DoDragDrop(e.Item, DragDropEffects.Move);
    }

    private void cmdOpenFire_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvCombatAssignment.SelectedNode == null)
            {
                int num1 = (int)MessageBox.Show("Please select a fire control");
            }
            else if (this.tvCombatAssignment.SelectedNode.Tag is FireControlAssignment)
            {
                FireControlAssignment tag1 = (FireControlAssignment)this.tvCombatAssignment.SelectedNode.Tag;
                if (tag1.IsOpeningFire)
                {
                    tag1.IsOpeningFire = false;
                    this.cmdOpenFire.Text = "Open Fire FC";
                    this.tvCombatAssignment.SelectedNode.ForeColor = AuroraUtils.color_2;
                }
                else
                {
                    tag1.IsOpeningFire = true;
                    this.cmdOpenFire.Text = "Cease Fire FC";
                    this.tvCombatAssignment.SelectedNode.ForeColor = Color.Orange;
                }

                if (this.gclass0_0.InexpFleets != 1 || !this.method_18() ||
                    !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                    return;
                FCTShipData40 tag2 = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                if (tag2.bool_15)
                    return;
                tag2.int_13 = tag2.method_86(GEnum14.const_0);
                tag2.bool_15 = true;
            }
            else
            {
                int num2 = (int)MessageBox.Show("Please select a fire control");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 953);
        }
    }

    private void cmdOpenFireAll_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
            if (this.cmdOpenFireAll.Text == "Open Fire All")
            {
                tag.method_31(GEnum61.const_1);
                this.cmdOpenFireAll.Text = "Cease Fire All";
            }
            else
            {
                tag.method_31(GEnum61.const_2);
                this.cmdOpenFireAll.Text = "Open Fire All";
            }

            if (this.gclass0_0.InexpFleets == 1 && !tag.bool_15)
            {
                tag.int_13 = tag.method_86(GEnum14.const_0);
                tag.bool_15 = true;
            }

            tag.method_37(this.tvCombatAssignment, this.tvTargets, this.bool_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 954);
        }
    }

    private void method_13(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
            if (this.cmdActive2.Text == "Active On")
            {
                tag.bool_8 = true;
                this.cmdActive2.Text = "Active Off";
            }
            else
            {
                tag.bool_8 = false;
                this.cmdActive2.Text = "Active On";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 955);
        }
    }

    private void cmdAssignFleet_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            ((FCTShipData40)this.tvFleetList.SelectedNode.Tag).method_24(GEnum35.const_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 957);
        }
    }

    private void cmdAssignSubFleet_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            ((FCTShipData40)this.tvFleetList.SelectedNode.Tag).method_24(GEnum35.const_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 958);
        }
    }

    private void cmdAssignSystem_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            ((FCTShipData40)this.tvFleetList.SelectedNode.Tag).method_24(GEnum35.const_2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 959);
        }
    }

    private void cmdAssignAll_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            ((FCTShipData40)this.tvFleetList.SelectedNode.Tag).method_24(GEnum35.const_3);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 960);
        }
    }

    private void cmdSyncFire_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
            if (this.cmdSyncFire.Text == "Sync Fire On")
            {
                tag.int_17 = 1;
                this.cmdSyncFire.Text = "Sync Fire Off";
                this.tvFleetList.SelectedNode.Text = tag.method_187() + "  (SF)";
            }
            else
            {
                tag.int_17 = 0;
                this.cmdSyncFire.Text = "Sync Fire On";
                this.tvFleetList.SelectedNode.Text = tag.method_187();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 961);
        }
    }

    private void cmdFleetSync_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            ((FCTShipData40)this.tvFleetList.SelectedNode.Tag).gclass85_0.method_65(1,
                this.tvFleetList.SelectedNode.Parent);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 962);
        }
    }

    private void cmdFleetSyncOff_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            ((FCTShipData40)this.tvFleetList.SelectedNode.Tag).gclass85_0.method_65(0,
                this.tvFleetList.SelectedNode.Parent);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 963);
        }
    }

    private void tvTargets_AfterSelect(object sender, TreeViewEventArgs e)
    {
    }

    private void tvTargets_AfterCollapse(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
            }
            else if (e.Node.Tag is AlienRaceInfo)
            {
                ((AlienRaceInfo)e.Node.Tag).bool_6 = false;
            }
            else
            {
                if (!(e.Node.Tag is string) || !((string)e.Node.Tag == "PD"))
                    return;
                this.bool_1 = false;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 965);
        }
    }

    private void tvTargets_AfterExpand(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
            }
            else if (e.Node.Tag is AlienRaceInfo)
            {
                ((AlienRaceInfo)e.Node.Tag).bool_6 = true;
            }
            else
            {
                if (!(e.Node.Tag is string) || !((string)e.Node.Tag == "PD"))
                    return;
                this.bool_1 = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 966);
        }
    }

    private void lstvNACTypes_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvNACTypes.SelectedItems.Count == 0)
                return;
            this.gclass79_0 = (NavalAdminCommandType)this.lstvNACTypes.SelectedItems[0].Tag;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 967);
        }
    }

    private void lstvPopulation_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvPopulation.SelectedItems.Count == 0)
                return;
            this.gclass146_0 = null;
            this.gclass40_1 = null;
            if (this.lstvPopulation.SelectedItems[0].Tag is PopulationData)
            {
                this.gclass146_0 = (PopulationData)this.lstvPopulation.SelectedItems[0].Tag;
            }
            else
            {
                if (!(this.lstvPopulation.SelectedItems[0].Tag is FCTShipData40))
                    return;
                this.gclass40_1 = (FCTShipData40)this.lstvPopulation.SelectedItems[0].Tag;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 968);
        }
    }

    private void chkNonArmed_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            this.gclass21_0.method_350(this.lstvFuel, this.chkExcTanker.CheckState, this.chkExcludeFighter.CheckState,
                this.chkExcludeFAC.CheckState, this.chkExcludeSY.CheckState, this.chkNonArmed.CheckState,
                this.chkSupplyShip.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 969);
        }
    }

    private void cmdDetach_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show(
                    "Please select a ship or sub-fleet to detach or select multiple ships to detach from a fleet");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
            {
                FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                tag.gclass40_0 = null;
                tag.gclass85_0.method_75(tag, OperationalGroupID.None, false);
                tag.gclass84_0 = null;
                if (tag.SquadronData != null)
                {
                    tag.LinkedSquadronID = tag.SquadronData.SquadronID;
                    tag.SquadronData = null;
                }

                this.gclass21_0.genum42_0 = GEnum42.const_2;
                this.gclass21_0.int_43 = tag.gclass85_0.FleetID;
                this.gclass21_0.method_355(this.tvFleetList, null, false,
                    AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
            }
            else if (this.lstvShips.SelectedItems.Count > 0)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetWindow.Class1032 class1032 = new FleetWindow.Class1032();
                FleetData gclass85 = new FleetData(this.gclass0_0);
                string string_10;
                FleetData gclass85_5;
                if (this.tvFleetList.SelectedNode.Tag is FleetData)
                {
                    FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                    string_10 = tag.FleetName;
                    gclass85_5 = tag;
                }
                else if (this.tvFleetList.SelectedNode.Tag is SubFleet)
                {
                    SubFleet tag = (SubFleet)this.tvFleetList.SelectedNode.Tag;
                    string_10 = tag.SubFleetName;
                    gclass85_5 = tag.ParentFleet;
                }
                else
                {
                    if (!(this.tvFleetList.SelectedNode.Tag is FCTSquadronData70))
                        return;
                    FCTSquadronData70 tag = (FCTSquadronData70)this.tvFleetList.SelectedNode.Tag;
                    string_10 = tag.SquadronName;
                    gclass85_5 = tag.ParentShipData.gclass85_0;
                }

                if (this.lstvShips.SelectedItems.Count == 1)
                {
                    FCTShipData40 tag = (FCTShipData40)this.lstvShips.SelectedItems[0].Tag;
                    if (tag != null)
                        string_10 = tag.method_187();
                }
                else
                    string_10 = this.gclass21_0.method_84(string_10);

                // ISSUE: reference to a compiler-generated field
                class1032.gclass85_0 = gclass85_5.NPROperationGroup == null
                    ? this.gclass21_0.method_308(string_10, gclass85_5.ParentNavalCommand, gclass85_5.System,
                        gclass85_5.XCoord, gclass85_5.YCoord, gclass85_5.OrbitingBody, OperationalGroupID.None)
                    : this.gclass21_0.method_308(string_10, gclass85_5.ParentNavalCommand, gclass85_5.System,
                        gclass85_5.XCoord, gclass85_5.YCoord, gclass85_5.OrbitingBody,
                        gclass85_5.NPROperationGroup.OperationalGroupId);
                if ((gclass85_5.bDetachedStanding || gclass85_5.bDetachedCondition) &&
                    (gclass85_5.bIncludeSquadrons || !(this.tvFleetList.SelectedNode.Tag is FCTSquadronData70)))
                {
                    // ISSUE: reference to a compiler-generated field
                    class1032.gclass85_0.method_2(gclass85_5, gclass85_5.bDetachedStanding, gclass85_5.bDetachedCondition);
                }

                foreach (ListViewItem selectedItem in this.lstvShips.SelectedItems)
                {
                    FCTShipData40 tag = (FCTShipData40)selectedItem.Tag;
                    if (tag != null)
                    {
                        if (tag.SquadronData != null)
                        {
                            tag.LinkedSquadronID = tag.SquadronData.SquadronID;
                            tag.SquadronData = null;
                        }

                        tag.gclass84_0 = null;
                        // ISSUE: reference to a compiler-generated field
                        tag.method_185(class1032.gclass85_0, true, false, false, false);
                    }
                }

                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                foreach (FCTShipData40 gclass40 in class1032.gclass85_0.method_176()
                             .Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass40_0 != null)
                             .Where<FCTShipData40>(class1032.method_0).ToList<FCTShipData40>())
                    gclass40.gclass40_0 = null;
                this.gclass21_0.genum42_0 = GEnum42.const_2;
                // ISSUE: reference to a compiler-generated field
                this.gclass21_0.int_43 = class1032.gclass85_0.FleetID;
                this.gclass21_0.method_355(this.tvFleetList, null, false,
                    AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                int num3 = (int)MessageBox.Show("Please select one or more ships from the ship list to detach");
            }
            else if (this.tvFleetList.SelectedNode.Tag is SubFleet)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetWindow.Class1033 class1033 = new FleetWindow.Class1033();
                SubFleet tag = (SubFleet)this.tvFleetList.SelectedNode.Tag;
                // ISSUE: reference to a compiler-generated field
                class1033.gclass85_0 = tag.ParentFleet.method_70(tag, false);
                this.gclass21_0.genum42_0 = GEnum42.const_2;
                // ISSUE: reference to a compiler-generated field
                this.gclass21_0.int_43 = class1033.gclass85_0.FleetID;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                foreach (FCTShipData40 gclass40 in class1033.gclass85_0.method_176()
                             .Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass40_0 != null)
                             .Where<FCTShipData40>(class1033.method_0).ToList<FCTShipData40>())
                    gclass40.gclass40_0 = null;
                this.gclass21_0.method_355(this.tvFleetList, null, false,
                    AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is FCTSquadronData70))
                    return;
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetWindow.Class1034 class1034 = new FleetWindow.Class1034();
                FCTSquadronData70 tag = (FCTSquadronData70)this.tvFleetList.SelectedNode.Tag;
                // ISSUE: reference to a compiler-generated field
                class1034.gclass85_0 = tag.ParentShipData.gclass85_0.method_71(tag, OperationalGroupID.None);
                this.gclass21_0.genum42_0 = GEnum42.const_2;
                // ISSUE: reference to a compiler-generated field
                this.gclass21_0.int_43 = class1034.gclass85_0.FleetID;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                foreach (FCTShipData40 gclass40 in class1034.gclass85_0.method_176()
                             .Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass40_0 != null)
                             .Where<FCTShipData40>(class1034.method_0).ToList<FCTShipData40>())
                    gclass40.gclass40_0 = null;
                this.gclass21_0.method_355(this.tvFleetList, null, false,
                    AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 970);
        }
    }

    private void cboRefuelActive_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a ship");
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                    return;
                ((FCTShipData40)this.tvFleetList.SelectedNode.Tag).auroraRefuelStatus_0 =
                    (AuroraRefuelStatus)this.cboRefuelActive.SelectedIndex;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 971);
        }
    }

    private void cboTransferActive_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a ship");
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                    return;
                ((FCTShipData40)this.tvFleetList.SelectedNode.Tag).auroraOrdnanceTransferStatus_0 =
                    (AuroraOrdnanceTransferStatus)this.cboTransferActive.SelectedIndex;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 972);
        }
    }

    private void method_14(object sender, EventArgs e)
    {
    }

    private void method_15(object sender, EventArgs e)
    {
    }

    private void lstvLoadItems_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void method_16(object sender, EventArgs e)
    {
    }

    private void lstvConditionOne_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void rdoOrderTemplates_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                this.method_6((FleetData)this.tvFleetList.SelectedNode.Tag);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 979);
        }
    }

    private void chkDanger_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (tag.CivilianFunction != CivilanFunctionType.const_0)
                {
                    int num = (int)MessageBox.Show(
                        "Danger settings cannot be changed for a civilian or computer-controlled fleet");
                }
                else
                {
                    tag.bAvoidDanger = AuroraUtils.smethod_27(this.chkDanger.CheckState);
                    this.method_6(tag);
                }
            }
            else
            {
                int num1 = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 980);
        }
    }

    private void chkExcludeAlien_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (tag.CivilianFunction != CivilanFunctionType.const_0)
                    return;
                tag.bAvoidAlienSystem = AuroraUtils.smethod_27(this.chkExcludeAlien.CheckState);
                this.method_6(tag);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 981);
        }
    }

    private void chkIncludeCivilians_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass21_0.method_355(this.tvFleetList, null, false,
                AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 982);
        }
    }

    private void chkAutoLP_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void chkCycle_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (tag.CivilianFunction != CivilanFunctionType.const_0)
                    return;
                tag.checkState_0 = this.chkCycle.CheckState;
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 983);
        }
    }

    private void panArmour_Paint(object sender, PaintEventArgs e)
    {
        try
        {
            if (this.gclass40_0 == null)
                return;
            this.gclass40_0.method_98(e.Graphics, this.panArmour);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 984);
        }
    }

    private void cmdAutoAssign_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass40_0 == null)
                return;
            this.gclass40_0.method_94();
            this.gclass40_0.method_37(this.tvCombatAssignment, this.tvTargets, this.bool_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 985);
        }
    }

    private void cmdAutoFleetFC_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                ((FleetData)this.tvFleetList.SelectedNode.Tag).method_43();
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 986);
        }
    }

    private void cboHangar_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_18() || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            ((FCTShipData40)this.tvFleetList.SelectedNode.Tag).genum43_0 = (GEnum43)this.cboHangar.SelectedIndex;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 987);
        }
    }

    private void cmdRepair_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_18())
                return;
            if (this.lstvDAC.SelectedItems.Count == 0)
            {
                int num1 = (int)MessageBox.Show("Please select a component to repair");
            }
            else if (this.lstvDAC.SelectedItems[0].Tag is GClass228)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetWindow.Class1035 class1035 = new FleetWindow.Class1035();
                // ISSUE: reference to a compiler-generated field
                class1035.gclass228_0 = (GClass228)this.lstvDAC.SelectedItems[0].Tag;
                FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                // ISSUE: reference to a compiler-generated method
                int num2 = tag.list_12.Where<GClass178>(class1035.method_0)
                    .Select<GClass178, int>(gclass178_0 => gclass178_0.int_0).FirstOrDefault<int>();
                if (num2 == 0)
                {
                    int num3 = (int)MessageBox.Show("This component is not damaged");
                }
                else
                {
                    // ISSUE: reference to a compiler-generated method
                    if (tag.list_13.Where<GClass26>(class1035.method_1).Count<GClass26>() >= num2)
                    {
                        int num4 = (int)MessageBox.Show("All damaged components of this type are scheduled for repair");
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        tag.list_13.Add(new GClass26()
                        {
                            gclass230_0 = class1035.gclass228_0.gclass230_0,
                            gclass40_0 = tag,
                            int_0 = tag.list_13.Count <= 0
                                ? 1
                                : tag.list_13.Max<GClass26>(gclass26_0 => gclass26_0.int_0) + 1
                        });
                        int int_40 = AuroraUtils.smethod_67(this.txtRepairChanceTime.Text);
                        tag.method_89(this.lstvDamageControlQueue, int_40);
                    }
                }
            }
            else
            {
                int num5 = (int)MessageBox.Show("Please select a component to repair");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 988);
        }
    }

    private void cmdRemove_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_18())
                return;
            if (this.lstvDamageControlQueue.SelectedItems.Count == 0)
            {
                int num1 = (int)MessageBox.Show("Please select a component to remove");
            }
            else if (this.lstvDamageControlQueue.SelectedItems[0].Tag is GClass26)
            {
                GClass26 tag1 = (GClass26)this.lstvDamageControlQueue.SelectedItems[0].Tag;
                FCTShipData40 tag2 = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                tag2.list_13.Remove(tag1);
                tag2.method_91();
                tag2.method_89(this.lstvDamageControlQueue, AuroraUtils.smethod_67(this.txtRepairChanceTime.Text));
            }
            else
            {
                int num2 = (int)MessageBox.Show("Please select a component to repair");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 989);
        }
    }

    private void cmdTop_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_18())
                return;
            if (this.lstvDamageControlQueue.SelectedItems.Count == 0)
            {
                int num1 = (int)MessageBox.Show("Please select a component to prioritise");
            }
            else if (this.lstvDamageControlQueue.SelectedItems[0].Tag is GClass26)
            {
                GClass26 tag1 = (GClass26)this.lstvDamageControlQueue.SelectedItems[0].Tag;
                FCTShipData40 tag2 = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                tag1.int_0 = 0;
                tag2.method_91();
                tag2.method_89(this.lstvDamageControlQueue, AuroraUtils.smethod_67(this.txtRepairChanceTime.Text));
                foreach (ListViewItem listViewItem in this.lstvDamageControlQueue.Items)
                {
                    if (listViewItem.Tag == tag1)
                        listViewItem.Selected = true;
                }
            }
            else
            {
                int num2 = (int)MessageBox.Show("Please select a component to prioritise");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 990);
        }
    }

    private void cmdUp_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_18())
                return;
            if (this.lstvDamageControlQueue.SelectedItems.Count == 0)
            {
                int num1 = (int)MessageBox.Show("Please select a component to move");
            }
            else if (this.lstvDamageControlQueue.SelectedItems[0].Tag is GClass26)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetWindow.Class1036 class1036 = new FleetWindow.Class1036();
                // ISSUE: reference to a compiler-generated field
                class1036.gclass26_0 = (GClass26)this.lstvDamageControlQueue.SelectedItems[0].Tag;
                FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                // ISSUE: reference to a compiler-generated method
                GClass26 gclass26 = tag.list_13.FirstOrDefault<GClass26>(class1036.method_0);
                if (gclass26 == null)
                    return;
                // ISSUE: reference to a compiler-generated field
                --class1036.gclass26_0.int_0;
                ++gclass26.int_0;
                tag.method_91();
                int int_40 = AuroraUtils.smethod_67(this.txtRepairChanceTime.Text);
                tag.method_89(this.lstvDamageControlQueue, int_40);
                foreach (ListViewItem listViewItem in this.lstvDamageControlQueue.Items)
                {
                    // ISSUE: reference to a compiler-generated field
                    if (listViewItem.Tag == class1036.gclass26_0)
                        listViewItem.Selected = true;
                }
            }
            else
            {
                int num2 = (int)MessageBox.Show("Please select a component to move");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 991);
        }
    }

    private void cmdDown_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_18())
                return;
            if (this.lstvDamageControlQueue.SelectedItems.Count == 0)
            {
                int num1 = (int)MessageBox.Show("Please select a component to move");
            }
            else if (this.lstvDamageControlQueue.SelectedItems[0].Tag is GClass26)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetWindow.Class1037 class1037 = new FleetWindow.Class1037();
                // ISSUE: reference to a compiler-generated field
                class1037.gclass26_0 = (GClass26)this.lstvDamageControlQueue.SelectedItems[0].Tag;
                FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                // ISSUE: reference to a compiler-generated method
                GClass26 gclass26 = tag.list_13.FirstOrDefault<GClass26>(class1037.method_0);
                if (gclass26 == null)
                    return;
                // ISSUE: reference to a compiler-generated field
                ++class1037.gclass26_0.int_0;
                --gclass26.int_0;
                tag.method_91();
                int int_40 = AuroraUtils.smethod_67(this.txtRepairChanceTime.Text);
                tag.method_89(this.lstvDamageControlQueue, int_40);
                foreach (ListViewItem listViewItem in this.lstvDamageControlQueue.Items)
                {
                    // ISSUE: reference to a compiler-generated field
                    if (listViewItem.Tag == class1037.gclass26_0)
                        listViewItem.Selected = true;
                }
            }
            else
            {
                int num2 = (int)MessageBox.Show("Please select a component to move");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 992);
        }
    }

    private void cmdDamage_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_17(false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 993);
        }
    }

    private void cmdInternalDamage_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_17(true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 994);
        }
    }

    private void method_17(bool bool_3)
    {
        try
        {
            if (!this.method_18())
                return;
            FCTShipData40 tag1 = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
            int num1 = AuroraUtils.smethod_67(this.txtManualDamage.Text);
            if (num1 < 1)
                return;
            Decimal decimal_42 = 0M;
            ShipComponent gclass230_0 = null;
            if (this.lstvWeapons.SelectedItems[0].Tag is RaceMissile)
                decimal_42 = ((RaceMissile)this.lstvWeapons.SelectedItems[0].Tag).decimal_0;
            else if (this.lstvWeapons.SelectedItems[0].Tag is ShipComponent)
            {
                ShipComponent tag2 = (ShipComponent)this.lstvWeapons.SelectedItems[0].Tag;
                decimal_42 = tag2.method_5(1);
                gclass230_0 = tag2;
                if (tag2.int_7 > 1)
                    num1 *= tag2.int_7;
            }

            if (decimal_42 == 0M)
                return;
            for (int index = 1; index <= num1; ++index)
            {
                int num2 = (int)tag1.method_0(gclass230_0, null, decimal_42, bool_3, null, false, false, null);
            }

            this.method_9();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 995);
        }
    }

    private void txtFuelPriority_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_18())
                return;
            this.gclass40_0 = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
            if (this.gclass40_0 == null || !(this.txtFuelPriority.Text != ""))
                return;
            this.gclass40_0.int_18 = Convert.ToInt32(this.txtFuelPriority.Text);
            if (this.gclass40_0.int_18 < 1)
                this.gclass40_0.int_18 = 1;
            this.method_9();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 996);
        }
    }

    private void txtSupplyPriority_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_18())
                return;
            this.gclass40_0 = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
            if (this.gclass40_0 == null || !(this.txtSupplyPriority.Text != ""))
                return;
            this.gclass40_0.int_19 = Convert.ToInt32(this.txtSupplyPriority.Text);
            if (this.gclass40_0.int_19 < 1)
                this.gclass40_0.int_19 = 1;
            this.method_9();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 997);
        }
    }

    private void cboResupplyActive_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_18() || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            ((FCTShipData40)this.tvFleetList.SelectedNode.Tag).auroraResupplyStatus_0 =
                (AuroraResupplyStatus)this.cboResupplyActive.SelectedIndex;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 998);
        }
    }

    private void chkAutoDC_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_18() || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            ((FCTShipData40)this.tvFleetList.SelectedNode.Tag).bool_14 =
                AuroraUtils.smethod_27(this.chkAutoDC.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 999);
        }
    }

    private void lstvDAC_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void txtRepairChanceTime_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_18() || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
            int int_40 = AuroraUtils.smethod_67(this.txtRepairChanceTime.Text);
            if (int_40 <= 0)
                return;
            tag.method_89(this.lstvDamageControlQueue, int_40);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1000);
        }
    }

    private void cmdSMRepair_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_18() || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
            tag.list_12.Clear();
            tag.dictionary_5.Clear();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1001);
        }
    }

    private bool method_18()
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return false;
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
                return false;
            }

            if (this.tvFleetList.SelectedNode != null)
                return true;
            int num1 = (int)MessageBox.Show("Please select a ship");
            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1002);
            return false;
        }
    }

    private void cmdAutoQueue_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_18() || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
            tag.method_87();
            tag.method_89(this.lstvDamageControlQueue, AuroraUtils.smethod_67(this.txtRepairChanceTime.Text));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1003);
        }
    }

    private void chkSensorDisplay_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                tag.bDisplaySensors = AuroraUtils.smethod_27(this.chkSensorDisplay.CheckState);
                this.method_6(tag);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1004);
        }
    }

    private void chkWeaponDisplay_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                tag.bDisplayWeapons = AuroraUtils.smethod_27(this.chkWeaponDisplay.CheckState);
                this.method_6(tag);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1005);
        }
    }

    private void cmdCreatePop_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.lstvSystemLocations.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a location");
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is FleetData))
                    return;
                FleetData tag1 = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (!this.rdoSL.Checked)
                    return;
                GClass134 tag2 = (GClass134)this.lstvSystemLocations.SelectedItems[0].Tag;
                if (tag2.genum13_0 != DestinationType.const_1 || tag2.gclass146_0 != null)
                    return;
                SystemBodyData gclass1_0 = this.gclass0_0.SystemBodyRecordDic[tag2.int_0];
                List<GClass194> source = this.gclass21_0.method_261(true);
                if (source.Count == 1)
                {
                    this.gclass21_0.method_275(gclass1_0, source[0]);
                }
                else
                {
                    this.gclass0_0.string_3 = "Select Colony Species";
                    this.gclass0_0.string_7 = "";
                    this.gclass0_0.string_8 = "";
                    this.gclass0_0.string_9 = "";
                    this.gclass0_0.list_32 = new List<string>();
                    foreach (GClass194 gclass194 in source)
                        this.gclass0_0.list_32.Add(gclass194.SpeciesName);
                    int num3 = (int)new UserSelection(this.gclass0_0).ShowDialog();
                    if (this.gclass0_0.bool_21)
                        return;
                    GClass194 gclass194_1 = source.FirstOrDefault<GClass194>(gclass194_0 =>
                        gclass194_0.SpeciesName == this.gclass0_0.string_4);
                    if (gclass194_1 != null)
                        this.gclass21_0.method_275(gclass1_0, gclass194_1);
                }

                this.method_6(tag1);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1006);
        }
    }

    private void cmdRepeat_Click(object sender, EventArgs e)
    {
        try
        {
            this.lstvLoadItems.Visible = false;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet");
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is FleetData))
                    return;
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (tag.CivilianFunction != CivilanFunctionType.const_0)
                {
                    int num3 = (int)MessageBox.Show(
                        "Orders cannot be assigned to a civilian or computer-controlled fleet");
                }
                else
                {
                    int int_12 = 1;
                    if (this.txtRepeatMultiple.Text != "")
                        int_12 = Convert.ToInt32(this.txtRepeatMultiple.Text);
                    if (int_12 <= 0)
                        int_12 = 1;
                    tag.method_32(int_12);
                    tag.method_258(this.lstvOrders);
                    tag.method_281(this.lstvSystemLocations, this.chkMoon, this.chkComets, this.chkAst,
                        this.chkExcSurveyed, this.chkWaypoint, this.chkLocation, this.chkFleets, this.chkContacts,
                        this.chkCivilian, this.chkWrecks, this.chkLifepods, this.chkExcludeTP, this.chkPlanet,
                        this.chkDwarf);
                    this.lblLocation.Text = tag.method_166();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1007);
        }
    }

    private void cmdEndOverhaul_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a ship");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
                ((FCTShipData40)this.tvFleetList.SelectedNode.Tag).method_83();
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                foreach (FCTShipData40 gclass40 in tag.method_176())
                    gclass40.method_83();
                tag.method_167(this.lstvShips, null, null, this.lblLocation, this.lblCommander, this.lblFleetData,
                    this.lblCapacity, this.lblDefault, this.lblClassSummary, this.lstvHistory, this.chkCycle,
                    this.txtSurveyRadius);
            }
            else
            {
                int num3 = (int)MessageBox.Show("Please select a ship");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1008);
        }
    }

    private void chkMaxSpeed_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                ((FleetData)this.tvFleetList.SelectedNode.Tag).bUseMaximumSpeed =
                    AuroraUtils.smethod_27(this.chkMaxSpeed.CheckState);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1009);
        }
    }

    private void cmdSMRefuel_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_18() || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
            tag.decimal_14 = tag.gclass22_0.int_63;
            this.method_9();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1010);
        }
    }

    private void cmdPartialRefuel_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_18() || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            this.gclass0_0.string_3 = "Enter Amount of Fuel";
            this.gclass0_0.string_4 = "0";
            int num1 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.bool_21)
                return;
            int int32 = Convert.ToInt32(this.gclass0_0.string_4);
            FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
            Decimal num2 = tag.method_151();
            tag.decimal_14 = !(num2 < int32) ? int32 : num2;
            this.method_9();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1011);
        }
    }

    private void cmdAbandonShip_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_18() || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
            if (MessageBox.Show($" Are you sure you want to abandon {tag.ShipName}?", "Confirmation Required",
                    MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            this.gclass21_0.method_303(tag, GEnum22.const_4);
            this.gclass21_0.method_355(this.tvFleetList, null, false,
                AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
            this.gclass0_0.tacticalMap_0.method_8();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1012);
        }
    }

    private void cmdSaveTemplate_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                this.gclass0_0.string_3 = "Enter New Order Template Name";
                this.gclass0_0.string_4 = "New Order Template";
                int num3 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                OrderTemplateData gclass144 = new OrderTemplateData(this.gclass0_0);
                gclass144.OrderTemplateID = this.gclass0_0.method_26(GEnum0.const_45);
                gclass144.RaceData = tag.Race;
                gclass144.RaceSystem = tag.System;
                gclass144.TemplateName = this.gclass0_0.string_4;
                this.gclass0_0.MoveOrderTemplateDictionary.Add(gclass144.OrderTemplateID, gclass144);
                gclass144.method_1(tag);
            }
            else
            {
                int num4 = (int)MessageBox.Show("Current selection is not a Fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1013);
        }
    }

    private void cmdDeleteTemplate_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet (to set the starting system for templates)");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag1 = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (!this.rdoOrderTemplates.Checked)
                {
                    int num3 = (int)MessageBox.Show("Please select a an Order Template");
                }
                else if (this.lstvSystemLocations.SelectedItems.Count == 0)
                {
                    int num4 = (int)MessageBox.Show("Please select a template");
                }
                else
                {
                    OrderTemplateData tag2 = (OrderTemplateData)this.lstvSystemLocations.SelectedItems[0].Tag;
                    if (MessageBox.Show($" Are you sure you want to delete {tag2.TemplateName}?", "Confirmation Required",
                            MessageBoxButtons.YesNo) != DialogResult.Yes ||
                        !this.gclass0_0.MoveOrderTemplateDictionary.ContainsKey(tag2.OrderTemplateID))
                        return;
                    this.gclass0_0.MoveOrderTemplateDictionary.Remove(tag2.OrderTemplateID);
                    this.gclass21_0.method_117(this.lstvSystemLocations, tag1.System);
                }
            }
            else
            {
                int num5 = (int)MessageBox.Show("Please select a fleet (to set the starting system for templates)");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1014);
        }
    }

    private void cmdMoveFleetToPop_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet to move");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (!this.gclass0_0.bool_8 && tag.method_176().Count > 0)
                {
                    int num3 = (int)MessageBox.Show("SM Mode required to move non-empty fleets");
                }
                else
                {
                    PopulationData selectedValue = (PopulationData)this.lstMoveFleet.SelectedValue;
                    if (selectedValue == null)
                    {
                        int num4 = (int)MessageBox.Show("Please select a population as the destination");
                    }
                    else
                    {
                        tag.OrbitingBody = selectedValue.SystemBodyData;
                        tag.System = selectedValue.gclass202_0;
                        tag.AssignedPopulation = selectedValue;
                        tag.XCoord = selectedValue.SystemBodyData.XCoordinate;
                        tag.YCoord = selectedValue.SystemBodyData.YCoordinate;
                        tag.method_167(this.lstvShips, null, null, this.lblLocation, this.lblCommander,
                            this.lblFleetData, this.lblCapacity, this.lblDefault, this.lblClassSummary,
                            this.lstvHistory, this.chkCycle, this.txtSurveyRadius);
                    }
                }
            }
            else
            {
                int num5 = (int)MessageBox.Show("Please select a fleet to move");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1015);
        }
    }

    private void cmdAwardMedal_Click(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            FleetWindow.Class1015 class1015 = new FleetWindow.Class1015();
            // ISSUE: reference to a compiler-generated field
            class1015.list_0 = new List<FCTShipData40>();
            string str = "";
            GClass55 gclass55 = null;
            if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
            {
                this.gclass40_0 = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                // ISSUE: reference to a compiler-generated field
                class1015.list_0.Add(this.gclass40_0);
                str = this.gclass40_0.method_187();
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                // ISSUE: reference to a compiler-generated field
                class1015.list_0 = tag.method_176();
                str = tag.FleetName;
            }
            else if (this.tvFleetList.SelectedNode.Tag is SubFleet)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetWindow.Class1016 class1016 = new FleetWindow.Class1016();
                // ISSUE: reference to a compiler-generated field
                class1016.gclass84_0 = (SubFleet)this.tvFleetList.SelectedNode.Tag;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                class1015.list_0 = this.gclass0_0.FCTShipDataDictionary.Values.Where<FCTShipData40>(class1016.method_0)
                    .ToList<FCTShipData40>();
                // ISSUE: reference to a compiler-generated field
                str = class1016.gclass84_0.SubFleetName;
            }
            else if (this.tvFleetList.SelectedNode.Tag is FCTSquadronData70)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetWindow.Class1017 class1017 = new FleetWindow.Class1017();
                // ISSUE: reference to a compiler-generated field
                class1017.gclass70_0 = (FCTSquadronData70)this.tvFleetList.SelectedNode.Tag;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                class1015.list_0 = this.gclass0_0.FCTShipDataDictionary.Values.Where<FCTShipData40>(class1017.method_0)
                    .ToList<FCTShipData40>();
                // ISSUE: reference to a compiler-generated field
                str = class1017.gclass70_0.SquadronName;
            }
            else if (this.tvFleetList.SelectedNode.Tag is NavalAdminCommand)
            {
                this.gclass83_0 = (NavalAdminCommand)this.tvFleetList.SelectedNode.Tag;
                // ISSUE: reference to a compiler-generated field
                class1015.list_0 = this.gclass83_0.method_1();
                str = this.gclass83_0.AdminCommandName;
                gclass55 = this.gclass83_0.gclass55_0;
            }

            this.gclass0_0.gclass42_0 = null;
            int num = (int)new frmMedalAward(this.gclass0_0, this.gclass21_0).ShowDialog();
            if (this.gclass0_0.gclass42_0 == null)
                return;
            if (MessageBox.Show(
                    $" Are you sure you want to award the {this.gclass0_0.gclass42_0.MedalName} to all officers of {str} with the selected command types?",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            // ISSUE: reference to a compiler-generated method
            List<GClass55> list = this.gclass0_0.dictionary_42.Values.Where<GClass55>(class1015.method_0)
                .ToList<GClass55>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            class1015.list_1 = this.gclass0_0.FormationDictionary.Values
                .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.ShipData != null).Where<GroundUnitFormationData>(class1015.method_1)
                .ToList<GroundUnitFormationData>();
            // ISSUE: reference to a compiler-generated method
            list.AddRange(this.gclass0_0.dictionary_42.Values
                .Where<GClass55>(gclass55_0 => gclass55_0.gclass103_0 != null).Where<GClass55>(class1015.method_2)
                .ToList<GClass55>());
            if (gclass55 != null)
                list.Add(gclass55);
            this.gclass21_0.method_109(list.Distinct<GClass55>().ToList<GClass55>(), this.gclass0_0.gclass42_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1016);
        }
    }

    private void chkLogNonArmed_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            this.gclass21_0.method_352(this.lstvLogisticsReport,
                (AuroraLogisticsSortType)this.cboSortType.SelectedIndex, this.chkLogExcTanker.CheckState,
                this.chkLogExcludeFighter.CheckState, this.chkLogExcludeFAC.CheckState, this.chkLogExcludeSY.CheckState,
                this.chkLogNonArmed.CheckState, this.chkLogSupplyShip.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1017);
        }
    }

    private void cmdRenameMissile_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass129_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a missile");
            }
            else
            {
                this.gclass0_0.string_3 = "Enter New Missile Name";
                this.gclass0_0.string_4 = this.gclass129_0.Name;
                int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (!(this.gclass0_0.string_4 != this.gclass129_0.Name) || this.gclass0_0.bool_21)
                    return;
                this.gclass129_0.Name = this.gclass0_0.string_4;
                this.gclass21_0.method_316(this.lstvOrdnance, this.chkObsoleteMissiles.CheckState, false);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1018);
        }
    }

    private void lstvOrdnanceTemplate_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvOrdnanceTemplate.SelectedItems.Count <= 0)
                return;
            this.gclass129_0 = (RaceMissile)this.lstvOrdnanceTemplate.SelectedItems[0].Tag;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1019);
        }
    }

    private void cmdObsoleteMissile_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass129_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a missile");
            }
            else
            {
                this.gclass129_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 =
                    !this.gclass129_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0;
                this.gclass21_0.method_316(this.lstvOrdnance, this.chkObsoleteMissiles.CheckState, false);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1020);
        }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass21_0.method_316(this.lstvOrdnanceTemplate, this.chkObsoleteMissiles.CheckState, false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1021);
        }
    }

    private void lstvOrdnanceTemplate_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass129_0 == null || this.gclass40_0 == null)
                return;
            this.gclass40_0.method_68(this.gclass129_0, this.method_19());
            this.method_9();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1022);
        }
    }

    public int method_19()
    {
        try
        {
            if (this.rdoLoadout1.Checked)
                return 1;
            if (this.rdoLoadout10.Checked)
                return 10;
            if (this.rdoLoadout100.Checked)
                return 100;
            return this.rdoLoadout1000.Checked ? 1000 : 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1023 /*0x03FF*/);
            return 0;
        }
    }

    private void cmdCopyClassLoadout_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass40_0.method_65();
            this.method_9();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1024 /*0x0400*/);
        }
    }

    private void lstvShipTemplate_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvShipTemplate.SelectedItems.Count == 0)
                return;
            this.gclass40_0.method_69((GClass130)this.lstvShipTemplate.SelectedItems[0].Tag, this.method_19());
            this.method_9();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1025);
        }
    }

    private void cmdSMFillClass_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass40_0 == null)
                return;
            foreach (FCTShipData40 gclass40 in this.gclass0_0.FCTShipDataDictionary.Values
                         .Where<FCTShipData40>(gclass40_2 => gclass40_2.gclass22_0 == this.gclass40_0.gclass22_0)
                         .ToList<FCTShipData40>())
                gclass40.method_62(false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1026);
        }
    }

    private void cmdFillShip_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass40_0 != null)
                this.gclass40_0.method_62(true);
            this.gclass40_0.method_64(this.lstvShipLoadout);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1027);
        }
    }

    private void cmdCopyToClass_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass40_0.method_66();
            this.method_9();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1028);
        }
    }

    private void cmdCopyToFleet_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass40_0.method_67();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1029);
        }
    }

    private void cmOpenFireFleet_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_20(GEnum61.const_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1030);
        }
    }

    private void cmdCeaseFireFleet_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_20(GEnum61.const_2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1031);
        }
    }

    private void method_20(GEnum61 genum61_0)
    {
        try
        {
            FleetData gclass85 = null;
            FCTShipData40 gclass40_1 = null;
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
            {
                gclass40_1 = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                if (gclass40_1 != null)
                    gclass85 = gclass40_1.gclass85_0;
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
                gclass85 = (FleetData)this.tvFleetList.SelectedNode.Tag;

            if (gclass85 == null)
                return;
            List<FCTShipData40> gclass40List = new List<FCTShipData40>();
            foreach (FCTShipData40 gclass40_2 in genum61_0 != GEnum61.const_2
                         ? gclass85.method_177()
                         : gclass85.method_176())
            {
                gclass40_2.method_31(genum61_0);
                if (this.gclass0_0.InexpFleets == 1 && !gclass40_2.bool_15 && (genum61_0 == GEnum61.const_1 ||
                                                                          genum61_0 == GEnum61.const_3 ||
                                                                          genum61_0 == GEnum61.const_4))
                {
                    gclass40_2.int_13 = gclass40_2.method_86(GEnum14.const_0);
                    gclass40_2.bool_15 = true;
                }
            }

            gclass40_1?.method_37(this.tvCombatAssignment, this.tvTargets, this.bool_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1032);
        }
    }

    private void method_21()
    {
        try
        {
            FleetData gclass85 = null;
            FCTShipData40 gclass40_1 = null;
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
            {
                gclass40_1 = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                if (gclass40_1 != null)
                    gclass85 = gclass40_1.gclass85_0;
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
                gclass85 = (FleetData)this.tvFleetList.SelectedNode.Tag;

            if (gclass85 == null)
                return;
            foreach (FCTShipData40 gclass40_2 in gclass85.method_177())
            {
                gclass40_2.method_32(null);
                if (this.gclass0_0.InexpFleets == 1)
                {
                    gclass40_2.int_13 = gclass40_2.method_86(GEnum14.const_1);
                    gclass40_2.bool_15 = false;
                }
            }

            gclass40_1?.method_37(this.tvCombatAssignment, this.tvTargets, this.bool_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3377);
        }
    }

    private void cmOpenFireFleetMFC_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_20(GEnum61.const_3);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1033);
        }
    }

    private void cmOpenFireFleetBFC_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_20(GEnum61.const_4);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1034);
        }
    }

    private void cmdAutoTargetMFC_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_22(AuroraComponentType.MissileFireControl, this.chkDoubleRange.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1035);
        }
    }

    private void method_22(AuroraComponentType auroraComponentType_0, CheckState checkState_0)
    {
        try
        {
            FleetData gclass85 = null;
            FCTShipData40 gclass40 = null;
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
            {
                gclass40 = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                if (gclass40 != null)
                    gclass85 = gclass40.gclass85_0;
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
                gclass85 = (FleetData)this.tvFleetList.SelectedNode.Tag;

            if (gclass85 == null)
                return;
            double double_11 = 1.0;
            if (checkState_0 == CheckState.Checked)
                double_11 = 2.0;
            gclass85.method_12(auroraComponentType_0, double_11);
            gclass40?.method_37(this.tvCombatAssignment, this.tvTargets, this.bool_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1036);
        }
    }

    private void cmdAutoTargetBFC_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_22(AuroraComponentType.BeamFireControl, this.chkDoubleRange.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1037);
        }
    }

    private void cmdFleetText_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                FleetData gclass85_1 = null;
                if (this.tvFleetList.SelectedNode == null)
                    return;
                if (this.tvFleetList.SelectedNode.Tag is FleetData)
                    gclass85_1 = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (gclass85_1 == null)
                    return;
                int num2 = (int)new PopulationText(gclass85_1, this.gclass0_0, this.chkIncFAC.CheckState,
                    this.chkIncFighter.CheckState).ShowDialog();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1038);
        }
    }

    private void chkRetainData_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
            if (tag == null)
                return;
            tag.int_14 = AuroraUtils.CheckStateToInt(this.chkRetainData.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1039);
        }
    }

    private void cmdSelectName_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
            if (tag == null)
                return;
            int num = (int)new cmdSelect(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.bool_21 || this.gclass0_0.string_4 == "" || this.gclass0_0.string_4 == null)
                return;
            tag.ShipName = this.gclass0_0.string_4;
            this.tvFleetList.SelectedNode.Text = tag.method_187();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1040);
        }
    }

    private void lstMoveFleet_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void cmdClearTarget_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
            {
                FCTShipData40 tag1 = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                if (this.tvCombatAssignment.SelectedNode == null)
                {
                    int num = (int)MessageBox.Show("Please select a fire control");
                }
                else
                {
                    if (!(this.tvCombatAssignment.SelectedNode.Tag is FireControlAssignment))
                        return;
                    FireControlAssignment tag2 = (FireControlAssignment)this.tvCombatAssignment.SelectedNode.Tag;
                    tag2.TargetID = 0;
                    tag2.TargetContactType = AuroraContactType.None;
                    if (this.gclass40_0 == null)
                        return;
                    this.gclass40_0.method_37(this.tvCombatAssignment, this.tvTargets, this.bool_1);
                }
            }
            else
            {
                int num1 = (int)MessageBox.Show("Please select a ship");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3202);
        }
    }

    private void cmdClearAllTargets_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
            {
                FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                foreach (FireControlAssignment gclass36 in this.gclass40_0.list_4)
                {
                    gclass36.TargetID = 0;
                    gclass36.TargetContactType = AuroraContactType.None;
                }

                this.gclass40_0.method_37(this.tvCombatAssignment, this.tvTargets, this.bool_1);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a ship");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3203);
        }
    }

    private void lstvActions_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            this.method_12(CheckState.Unchecked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3209);
        }
    }

    private void lstvLoadItems_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            this.method_12(CheckState.Unchecked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3217);
        }
    }

    private void lstvSystemLocations_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            this.method_12(this.chkDefaultActions.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3225);
        }
    }

    private void lstvSystemLocations_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvSystemLocations.SelectedItems.Count == 0)
                return;
            this.lstvActions.Items.Clear();
            this.lstvLoadItems.Items.Clear();
            this.lstvLoadItems.Visible = false;
            this.method_0();
            this.cmdCreatePop.Visible = false;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet");
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is FleetData))
                    return;
                FleetData tag1 = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (this.rdoSL.Checked)
                {
                    GClass134 tag2 = (GClass134)this.lstvSystemLocations.SelectedItems[0].Tag;
                    if (tag2.genum13_0 == DestinationType.const_1 && tag2.gclass146_0 == null)
                        this.cmdCreatePop.Visible = true;
                    tag1.method_282(tag2, this.lstvActions);
                }
                else
                {
                    if (!this.rdoARSystem.Checked && !this.rdoOrderTemplates.Checked)
                        return;
                    this.lstvActions.Items.Clear();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 979);
        }
    }

    private void lstvShips_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void FleetWindow_KeyDown(object sender, KeyEventArgs e)
    {
        try
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F4)
            {
                this.Close();
            }
            else
            {
                if (this.gclass21_0 == null)
                    return;
                this.gclass21_0.method_174(e, this.gclass0_0.tacticalMap_0.gclass202_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3272);
        }
    }

    private void cmdMoveFleettoWP_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet to move");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (!this.gclass0_0.bool_8 && tag.method_176().Count > 0)
                {
                    int num3 = (int)MessageBox.Show("SM Mode required to move non-empty fleets");
                }
                else
                {
                    GClass214 selectedValue = (GClass214)this.lstMoveWP.SelectedValue;
                    if (selectedValue == null)
                    {
                        int num4 = (int)MessageBox.Show("Please select a waypoint as the destination");
                    }
                    else
                    {
                        tag.OrbitingBody = selectedValue.gclass1_0;
                        tag.System = tag.Race.method_128(selectedValue.gclass200_0);
                        tag.method_6();
                        tag.XCoord = selectedValue.double_0;
                        tag.YCoord = selectedValue.double_1;
                        tag.method_167(this.lstvShips, null, null, this.lblLocation, this.lblCommander,
                            this.lblFleetData, this.lblCapacity, this.lblDefault, this.lblClassSummary,
                            this.lstvHistory, this.chkCycle, this.txtSurveyRadius);
                    }
                }
            }
            else
            {
                int num5 = (int)MessageBox.Show("Please select a fleet to move");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3305);
        }
    }

    private void chkCurrentSystem_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                this.gclass21_0.method_383(this.tvThreat, this.tvAnchor, (FleetData)this.tvFleetList.SelectedNode.Tag,
                    this.chkCurrentContact.CheckState, this.chkCurrentSystem.CheckState);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3325);
        }
    }

    private void cmdClearAnchor_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                tag.AnchorFleet = null;
                tag.method_259(this.lstvFormation);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3327 /*0x0CFF*/);
        }
    }

    private void cmdClearThreat_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                tag.gclass117_0 = null;
                tag.method_259(this.lstvFormation);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3328 /*0x0D00*/);
        }
    }

    private void cmdToggleWarship_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                tag.bGuardNearestKnownWarship = !tag.bGuardNearestKnownWarship;
                tag.method_259(this.lstvFormation);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3329);
        }
    }

    private void cmdToggleContact_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                tag.bGuardNearestHostileContact = !tag.bGuardNearestHostileContact;
                tag.method_259(this.lstvFormation);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3330);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                tag.bUseAnchorDestination = !tag.bUseAnchorDestination;
                tag.method_259(this.lstvFormation);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3331);
        }
    }

    private void cmdSetDistance_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                this.gclass0_0.string_3 = "Enter Desired Distance to Anchor Fleet in km";
                this.gclass0_0.string_4 = "0";
                int num = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                tag.AnchorFleetDistance = Convert.ToDouble(this.gclass0_0.string_4);
                tag.method_259(this.lstvFormation);
            }
            else
            {
                int num1 = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3332);
        }
    }

    private void cmdSetOffset_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                this.gclass0_0.string_3 = "Enter Positive or Negative Offset to Threat Bearing in Degrees";
                this.gclass0_0.string_4 = "0";
                int num = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                tag.AnchorFleetBearingOffset = Convert.ToInt32(this.gclass0_0.string_4);
                tag.method_259(this.lstvFormation);
            }
            else
            {
                int num1 = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3333);
        }
    }

    private void lstvFormation_DragDrop(object sender, DragEventArgs e)
    {
    }

    private void cmdSetAnchor_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag1 = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (this.tvAnchor.SelectedNode.Tag is FleetData)
                {
                    FleetData tag2 = (FleetData)this.tvAnchor.SelectedNode.Tag;
                    tag1.AnchorFleet = tag2;
                    tag1.method_259(this.lstvFormation);
                }
                else
                {
                    int num2 = (int)MessageBox.Show("Please select an anchor fleet");
                }
            }
            else
            {
                int num3 = (int)MessageBox.Show("Please select a formation fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3334);
        }
    }

    private void cmdSetThreat_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvThreat.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a specific threat");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag1 = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (this.tvThreat.SelectedNode.Tag is GClass117)
                {
                    GClass117 tag2 = (GClass117)this.tvThreat.SelectedNode.Tag;
                    tag1.gclass117_0 = tag2;
                    tag1.method_259(this.lstvFormation);
                }
                else
                {
                    int num3 = (int)MessageBox.Show("Please select an alien ship as the specific threat");
                }
            }
            else
            {
                int num4 = (int)MessageBox.Show("Please select a formation fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3334);
        }
    }

    private void cmdDetachEscorts_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet from which to detach escorts");
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is FleetData))
                    return;
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                foreach (SubFleet gclass84_0 in this.gclass0_0.SubFleetDictionary.Values.Where<SubFleet>(
                             new FleetWindow.Class1018()
                             {
                                 gclass85_0 = (FleetData)this.tvFleetList.SelectedNode.Tag
                             }.method_0).ToList<SubFleet>())
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    FleetWindow.Class1019 class1019 = new FleetWindow.Class1019();
                    // ISSUE: reference to a compiler-generated field
                    class1019.gclass85_0 = gclass84_0.ParentFleet.method_70(gclass84_0, false);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    foreach (FCTShipData40 gclass40 in class1019.gclass85_0.method_176()
                                 .Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass40_0 != null)
                                 .Where<FCTShipData40>(class1019.method_0).ToList<FCTShipData40>())
                        gclass40.gclass40_0 = null;
                }

                this.gclass21_0.method_355(this.tvFleetList, null, false,
                    AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3338);
        }
    }

    private void cmdRecallEscorts_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet for which to recall escorts");
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is FleetData))
                    return;
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetWindow.Class1020 class1020 = new FleetWindow.Class1020();
                // ISSUE: reference to a compiler-generated field
                class1020.gclass85_0 = (FleetData)this.tvFleetList.SelectedNode.Tag;
                // ISSUE: reference to a compiler-generated method
                foreach (FleetData gclass85 in this.gclass0_0.FleetDictionary.Values.Where<FleetData>(class1020.method_0)
                             .ToList<FleetData>())
                {
                    gclass85.method_263();
                    // ISSUE: reference to a compiler-generated field
                    gclass85.method_222(class1020.gclass85_0, MoveActionType.JoinAsSubFleet);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3339);
        }
    }

    private void method_23(object sender, EventArgs e)
    {
    }

    private void cmdFleetAtWill_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
            tag.method_32(null);
            if (this.gclass0_0.InexpFleets == 1)
            {
                tag.int_13 = tag.method_86(GEnum14.const_1);
                tag.bool_15 = false;
            }

            tag.method_37(this.tvCombatAssignment, this.tvTargets, this.bool_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3375);
        }
    }

    private void cmdFleetFireAtWill_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_21();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3376);
        }
    }

    private void cmdFireAtWillFC_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvCombatAssignment.SelectedNode == null)
            {
                int num1 = (int)MessageBox.Show("Please select a fire control");
            }
            else
            {
                if (!(this.tvCombatAssignment.SelectedNode.Tag is FireControlAssignment))
                    return;
                FireControlAssignment tag1 = (FireControlAssignment)this.tvCombatAssignment.SelectedNode.Tag;
                if (this.gclass0_0.InexpFleets != 1 || !this.method_18() ||
                    !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                    return;
                FCTShipData40 tag2 = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                tag2.method_32(tag1);
                if (this.gclass0_0.InexpFleets != 1)
                    return;
                int num2 = tag2.method_86(GEnum14.const_2);
                tag2.int_13 = num2;
                tag2.bool_15 = false;
                tag2.method_37(this.tvCombatAssignment, this.tvTargets, this.bool_1);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3378);
        }
    }

    private void method_24(GClass55 gclass55_0)
    {
        try
        {
            if (gclass55_0 == null)
                return;
            CommandersWindow commandersWindow =
                Application.OpenForms.OfType<CommandersWindow>().FirstOrDefault<CommandersWindow>();
            if (commandersWindow == null)
            {
                commandersWindow = new CommandersWindow(this.gclass0_0);
                commandersWindow.Show();
            }
            else
            {
                commandersWindow.BringToFront();
                this.gclass0_0.object_0 = commandersWindow;
            }

            commandersWindow.method_5(gclass55_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3390);
        }
    }

    private void lstvShips_DoubleClick(object sender, EventArgs e)
    {
    }

    private void lblCommander_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null || this.tvFleetList.SelectedNode.Tag == null ||
                !(this.tvFleetList.SelectedNode.Tag is FleetData))
                return;
            this.method_24(((FleetData)this.tvFleetList.SelectedNode.Tag).method_162());
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3389);
        }
    }

    private void lstvOfficers_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvOfficers.SelectedItems.Count == 0)
                return;
            this.method_24((GClass55)this.lstvOfficers.SelectedItems[0].Tag);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3391);
        }
    }

    private void lstvShips_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null || this.tvFleetList.SelectedNode.Tag == null ||
                !(this.tvFleetList.SelectedNode.Tag is FleetData) || this.lstvShips.SelectedItems.Count == 0)
                return;
            FCTShipData40 tag1 = (FCTShipData40)this.lstvShips.SelectedItems[0].Tag;
            if (tag1 == null)
                return;
            if (Control.ModifierKeys == Keys.Control)
            {
                FCTShipData40 tag2 = (FCTShipData40)this.lstvShips.HitTest(e.X, e.Y).Item.Tag;
                if (tag2 == null)
                    return;
                GClass55 gclass55_0 = tag2.method_192(AuroraCommandType.Ship);
                if (gclass55_0 == null)
                    return;
                this.method_24(gclass55_0);
            }
            else
            {
                foreach (TreeNode node in this.tvFleetList.SelectedNode.Nodes)
                {
                    if (node.Tag == tag1)
                    {
                        this.tvFleetList.SelectedNode = node;
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3392);
        }
    }

    private void lblCommander_Click(object sender, EventArgs e)
    {
    }

    private void cmdTransfer_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet to transfer ");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                AlienRaceInfo selectedValue = (AlienRaceInfo)this.cboTransferRace.SelectedValue;
                if (selectedValue == null)
                    return;
                GameRace gclass210 = selectedValue.ActualAlienRace;
                if (gclass210 == tag.Race)
                {
                    int num3 = (int)MessageBox.Show("Cannot transfer to existing race");
                }
                else
                {
                    tag.method_8(gclass210);
                    this.gclass0_0.FleetDictionary.Remove(tag.FleetID);
                    this.tvFleetList.Nodes.Remove(this.tvFleetList.SelectedNode);
                }
            }
            else
            {
                int num4 = (int)MessageBox.Show("Please select a fleet to transfer");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3396);
        }
    }

    private void cmdActive2_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
            {
                FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                if (this.cmdActive2.Text == "Active On")
                {
                    tag.bool_8 = true;
                    this.cmdActive2.Text = "Active Off";
                }
                else
                {
                    tag.bool_8 = false;
                    this.cmdActive2.Text = "Active On";
                }
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is FleetData))
                    return;
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                List<FCTShipData40> gclass40List = tag.method_177();
                if (this.cmdActive2.Text == "Active On")
                {
                    foreach (FCTShipData40 gclass40 in gclass40List)
                        gclass40.bool_8 = true;
                    this.cmdActive2.Text = "Active Off";
                }
                else
                {
                    foreach (FCTShipData40 gclass40 in gclass40List)
                        gclass40.bool_8 = false;
                    this.cmdActive2.Text = "Active On";
                }

                tag.method_167(this.lstvShips, null, null, this.lblLocation, this.lblCommander, this.lblFleetData,
                    this.lblCapacity, this.lblDefault, this.lblClassSummary, this.lstvHistory, this.chkCycle,
                    this.txtSurveyRadius);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 955);
        }
    }

    private void chkSelectOnMap_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.chkSelectOnMap.CheckState == CheckState.Unchecked || this.tvFleetList.SelectedNode == null ||
                this.tvFleetList.SelectedNode.Tag == null || !(this.tvFleetList.SelectedNode.Tag is FleetData))
                return;
            this.gclass0_0.method_522((FleetData)this.tvFleetList.SelectedNode.Tag);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3403);
        }
    }

    private void chkAssumeJumpCapable_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                tag.bAssumeJumpCapable = AuroraUtils.smethod_27(this.chkAssumeJumpCapable.CheckState);
                this.method_6(tag);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3424);
        }
    }

    private void cmdFleetShields_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
            {
                FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                if (this.cmdFleetShields.Text == "Raise Shields")
                {
                    tag.bool_10 = true;
                    this.cmdFleetShields.Text = "Lower Shields";
                }
                else
                {
                    tag.bool_10 = false;
                    tag.decimal_3 = 0M;
                    this.cmdFleetShields.Text = "Raise Shields";
                }
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is FleetData))
                    return;
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                List<FCTShipData40> gclass40List = tag.method_177();
                if (this.cmdFleetShields.Text == "Raise Shields")
                {
                    foreach (FCTShipData40 gclass40 in gclass40List)
                        gclass40.bool_10 = true;
                    this.cmdFleetShields.Text = "Lower Shields";
                }
                else
                {
                    foreach (FCTShipData40 gclass40 in gclass40List)
                    {
                        gclass40.bool_10 = false;
                        gclass40.decimal_3 = 0M;
                    }

                    this.cmdFleetShields.Text = "Raise Shields";
                }

                tag.method_167(this.lstvShips, null, null, this.lblLocation, this.lblCommander, this.lblFleetData,
                    this.lblCapacity, this.lblDefault, this.lblClassSummary, this.lstvHistory, this.chkCycle,
                    this.txtSurveyRadius);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3434);
        }
    }

    private void chkAutoAssign_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.gclass83_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a naval admin command");
            }
            else
                this.gclass83_0.bool_1 = AuroraUtils.smethod_27(this.chkAutoAssign.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3486);
        }
    }

    private void txtImportance_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.txtImportance.Text == "" || this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.gclass83_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a naval admin command");
            }
            else
            {
                this.gclass83_0.int_2 = Convert.ToInt32(this.txtImportance.Text);
                if (this.gclass83_0.int_2 >= 1)
                    return;
                this.gclass83_0.int_2 = 1;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3487);
        }
    }

    private void cboBonusOne_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.gclass83_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a naval admin command");
            }
            else
                this.gclass83_0.genum121_0 = ((CommanderBonus)this.cboBonusOne.SelectedItem).CommanderBonusType;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3488);
        }
    }

    private void cboBonusThree_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.gclass83_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a naval admin command");
            }
            else
                this.gclass83_0.genum121_2 = ((CommanderBonus)this.cboBonusThree.SelectedItem).CommanderBonusType;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3489);
        }
    }

    private void cboBonusTwo_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.gclass83_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a naval admin command");
            }
            else
                this.gclass83_0.genum121_1 = ((CommanderBonus)this.cboBonusTwo.SelectedItem).CommanderBonusType;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3490);
        }
    }

    private void cmdSelectGovernor_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.gclass83_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a naval admin command");
            }
            else
            {
                this.gclass83_0.method_0(true);
                this.lblNACCommander.Text = this.gclass83_0.method_4();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3491);
        }
    }

    private void cmdAssignGovernors_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                this.gclass21_0.method_228(false);
                if (this.gclass83_0 == null)
                    return;
                this.lblNACCommander.Text = this.gclass83_0.method_4();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3493);
        }
    }

    private void cmdReassignAllGovernors_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                this.gclass21_0.method_228(true);
                if (this.gclass83_0 == null)
                    return;
                this.lblNACCommander.Text = this.gclass83_0.method_4();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3494);
        }
    }

    private void cboNavalRanks_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.gclass83_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a naval admin command");
            }
            else
            {
                this.gclass83_0.int_3 = ((RankThemeEntry)this.cboNavalRanks.SelectedItem).RankNum;
                this.gclass21_0.method_255(false);
                this.tvFleetList.SelectedNode.Text = this.gclass83_0.method_6();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3495);
        }
    }

    private void cmdSetHullNumber_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a ship to renumber");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetWindow.Class1021 class1021 = new FleetWindow.Class1021()
                {
                    gclass40_0 = (FCTShipData40)this.tvFleetList.SelectedNode.Tag
                };
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class1021.int_0 = Convert.ToInt32(this.gclass0_0.method_562("Enter New Hull Number",
                    class1021.gclass40_0.int_20.ToString()));
                // ISSUE: reference to a compiler-generated field
                if (class1021.int_0 < 1)
                {
                    int num3 = (int)MessageBox.Show("Hull number must be a positive integer");
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    if (!this.gclass21_0.ShipHullCountDictionary.ContainsKey(class1021.gclass40_0.gclass22_0.gclass76_0))
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class1021.gclass40_0.int_20 = class1021.int_0;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        this.gclass21_0.ShipHullCountDictionary.Add(class1021.gclass40_0.gclass22_0.gclass76_0, class1021.int_0);
                        // ISSUE: reference to a compiler-generated field
                        this.tvFleetList.SelectedNode.Text = class1021.gclass40_0.method_187();
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated method
                        FCTShipData40 gclass40 =
                            this.gclass0_0.FCTShipDataDictionary.Values.FirstOrDefault<FCTShipData40>(
                                class1021.method_0);
                        if (gclass40 != null)
                        {
                            // ISSUE: reference to a compiler-generated field
                            int num4 = (int)MessageBox.Show(
                                $"Hull number {class1021.int_0.ToString()} is already assigned to {gclass40.method_187()}");
                            return;
                        }

                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class1021.gclass40_0.int_20 = class1021.int_0;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class1021.int_0 > this.gclass21_0.ShipHullCountDictionary[class1021.gclass40_0.gclass22_0.gclass76_0])
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            this.gclass21_0.ShipHullCountDictionary[class1021.gclass40_0.gclass22_0.gclass76_0] = class1021.int_0;
                        }

                        // ISSUE: reference to a compiler-generated field
                        this.tvFleetList.SelectedNode.Text = class1021.gclass40_0.method_187();
                    }

                    int int_40 = AuroraUtils.smethod_67(this.txtTargetSpeed.Text);
                    int int_41 = AuroraUtils.smethod_67(this.txtRangeBand.Text);
                    int int_42 = AuroraUtils.smethod_67(this.txtRepairChanceTime.Text);
                    // ISSUE: reference to a compiler-generated field
                    this.txtShipSummary.Text = class1021.gclass40_0.method_164(int_40, int_41, this.cboRefuelActive,
                        this.cboResupplyActive, this.cboTransferActive, this.cboHangar, this.flpEnergyWeaponData,
                        this.lstvMeasurement, this.lstvLogistics, this.lstvCrew, this.lstvOrdnance, this.lstvOfficers,
                        this.lstvDAC, this.lstvDamageControlQueue, this.lstvMeasurement, this.lstvShipHistory, int_42);
                }
            }
            else
            {
                int num5 = (int)MessageBox.Show("Please select a ship to renumber");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3497);
        }
    }

    private void cmdCreateSquadron_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a parent ship for the new squadron");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
            {
                FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                FCTSquadronData70 gclass70 = this.gclass21_0.method_342(tag);
                if (gclass70 == null)
                    return;
                gclass70.bool_0 = true;
                tag.bool_12 = true;
                this.gclass21_0.genum42_0 = GEnum42.const_4;
                this.gclass21_0.int_43 = tag.int_8;
                this.gclass21_0.method_355(this.tvFleetList, null, false,
                    AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
            }
            else
            {
                int num3 = (int)MessageBox.Show("Please select a parent ship for the new squadron");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3517);
        }
    }

    private void cmdLaunchAll_Click(object sender, EventArgs e)
    {
        try
        {
            List<FCTShipData40> source1 = new List<FCTShipData40>();
            FleetData gclass85_1 = new FleetData(this.gclass0_0);
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet, sub-fleet or ship");
            }
            else
            {
                if (this.tvFleetList.SelectedNode.Tag is FleetData)
                {
                    FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                    source1 = tag.method_176().Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass40_0 != null)
                        .Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass40_0.gclass40_0 == null)
                        .ToList<FCTShipData40>();
                    gclass85_1 = this.gclass21_0.method_308(tag.FleetName + " Strikegroup", tag.ParentNavalCommand,
                        tag.System, tag.XCoord, tag.YCoord, tag.OrbitingBody, OperationalGroupID.None);
                }
                else if (this.tvFleetList.SelectedNode.Tag is SubFleet)
                {
                    SubFleet tag = (SubFleet)this.tvFleetList.SelectedNode.Tag;
                    source1 = tag.method_0().Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass40_0 != null)
                        .Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass40_0.gclass40_0 == null)
                        .ToList<FCTShipData40>();
                    gclass85_1 = this.gclass21_0.method_308(tag.SubFleetName + " Strikegroup", tag.ParentFleet.ParentNavalCommand,
                        tag.ParentFleet.System, tag.ParentFleet.XCoord, tag.ParentFleet.YCoord,
                        tag.ParentFleet.OrbitingBody, OperationalGroupID.None);
                }
                else if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
                {
                    FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                    source1 = tag.method_205();
                    gclass85_1 = this.gclass21_0.method_308(tag.ShipName + " Strikegroup", tag.gclass85_0.ParentNavalCommand,
                        tag.gclass85_0.System, tag.gclass85_0.XCoord, tag.gclass85_0.YCoord,
                        tag.gclass85_0.OrbitingBody, OperationalGroupID.None);
                }

                List<FCTSquadronData70> list = source1.Where<FCTShipData40>(gclass40_0 => gclass40_0.SquadronData != null)
                    .Select<FCTShipData40, FCTSquadronData70>(gclass40_0 => gclass40_0.SquadronData)
                    .Distinct<FCTSquadronData70>().ToList<FCTSquadronData70>();
                List<SubFleet> source2 = new List<SubFleet>();
                foreach (FCTSquadronData70 gclass70 in list)
                {
                    SubFleet gclass84 = gclass85_1.method_89(gclass70.SquadronName);
                    source2.Add(gclass84);
                }

                foreach (FCTShipData40 gclass40 in source1)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    FleetWindow.Class1022 class1022 = new FleetWindow.Class1022()
                    {
                        gclass40_0 = gclass40
                    };
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    class1022.gclass40_0.gclass84_0 = class1022.gclass40_0.SquadronData == null
                        ? null
                        : source2.FirstOrDefault<SubFleet>(class1022.method_0);
                    // ISSUE: reference to a compiler-generated field
                    class1022.gclass40_0.gclass40_0 = null;
                    // ISSUE: reference to a compiler-generated field
                    class1022.gclass40_0.SquadronData = null;
                    // ISSUE: reference to a compiler-generated field
                    class1022.gclass40_0.method_185(gclass85_1, true, false, false, true);
                }

                this.gclass21_0.genum42_0 = GEnum42.const_2;
                this.gclass21_0.int_43 = gclass85_1.FleetID;
                this.gclass21_0.method_355(this.tvFleetList, null, false,
                    AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3541);
        }
    }

    private void chkIncludeSG_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            this.gclass21_0.method_353(this.lstvCombatRating, this.chkIncludeSG.CheckState, this.rdoMilitary.Checked,
                this.rdoCommercial.Checked, this.rdoGround.Checked, this.rdoMissiles.Checked, this.rdoSize.Checked,
                this.rdoDistance.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3647);
        }
    }

    private void rdoDistance_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
            }
            else
                this.gclass21_0.method_353(this.lstvCombatRating, this.chkIncludeSG.CheckState,
                    this.rdoMilitary.Checked, this.rdoCommercial.Checked, this.rdoGround.Checked,
                    this.rdoMissiles.Checked, this.rdoSize.Checked, this.rdoDistance.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 642);
        }
    }

    private void cmdMinAMMRange_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvCombatAssignment.SelectedNode == null)
            {
                int num1 = (int)MessageBox.Show("Please select a missile fire control");
            }
            else if (this.tvCombatAssignment.SelectedNode.Tag is FireControlAssignment)
            {
                FireControlAssignment tag = (FireControlAssignment)this.tvCombatAssignment.SelectedNode.Tag;
                if (tag.FCComponent.gclass231_0.ComponentTypeID != AuroraComponentType.MissileFireControl)
                {
                    int num2 = (int)MessageBox.Show("Please select a missile fire control");
                }
                else
                {
                    this.gclass0_0.string_3 = "Enter Minimum AMM Launch Range";
                    this.gclass0_0.string_4 = tag.MinimumAMMRange.ToString();
                    int num3 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                    if (!this.gclass0_0.bool_21)
                        tag.MinimumAMMRange = AuroraUtils.ParseDoubleOrDefault(this.gclass0_0.string_4, 0.0);
                    this.gclass40_0.method_37(this.tvCombatAssignment, this.tvTargets, this.bool_1);
                }
            }
            else
            {
                int num4 = (int)MessageBox.Show("Please select a missile fire control");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3676);
        }
    }

    private void cmdDecoyThreshold_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass40_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a ship");
            }
            else
            {
                this.gclass0_0.string_3 = "Enter Decoy Threshold in MSP";
                this.gclass0_0.string_4 = this.gclass40_0.int_23.ToString();
                int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (!this.gclass0_0.bool_21)
                    this.gclass40_0.int_23 = AuroraUtils.smethod_67(this.gclass0_0.string_4);
                this.gclass40_0.method_37(this.tvCombatAssignment, this.tvTargets, this.bool_1);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3676);
        }
    }

    private void ckhTarget_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null || !(this.tvFleetList.SelectedNode.Tag is FCTShipData40))
                return;
            FCTShipData40 tag = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
            if (tag == null)
                return;
            tag.int_24 = AuroraUtils.CheckStateToInt(this.ckhTarget.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3741);
        }
    }

    private void lstvSalvos_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvSalvos.SelectedItems.Count <= 0)
                return;
            this.gclass132_0 = (GClass132)this.lstvSalvos.SelectedItems[0].Tag;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3746);
        }
    }

    private void cmdDeleteSalvo_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.gclass132_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a missile salvo");
            }
            else
            {
                if (MessageBox.Show($" Are you sure you want to delete {this.gclass132_0.string_0}?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.gclass21_0.method_130(this.gclass132_0);
                this.gclass21_0.method_354(this.lstvSalvos);
                this.gclass0_0.tacticalMap_0.method_8();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3747);
        }
    }

    private void txtSurveyRadius_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.txtSurveyRadius.Text == "")
                return;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet, sub-fleet or ship");
            }
            else
            {
                if (!(this.tvFleetList.SelectedNode.Tag is FleetData))
                    return;
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (tag == null)
                    return;
                ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.txtSurveyRadius.Text);
                if (gclass208.Succeed)
                {
                    tag.MaxStandingOrderDistance = (long)gclass208.Value;
                    if (tag.MaxStandingOrderDistance >= 0L)
                        return;
                    tag.MaxStandingOrderDistance = 0L;
                    int num3 = (int)MessageBox.Show("Distance cannot be negtive");
                }
                else
                {
                    int num4 = (int)MessageBox.Show("Cannot Parse Prize Chance Value");
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3796);
        }
    }

    private void cmdTemp_Click(object sender, EventArgs e)
    {
        try
        {
            foreach (ShippingLineData gclass187 in this.gclass0_0.ShippingLineDictionary.Values
                         .Where<ShippingLineData>(gclass187_0 => gclass187_0.decimal_0 == 0M).ToList<ShippingLineData>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetWindow.Class1023 class1023 = new FleetWindow.Class1023();
                // ISSUE: reference to a compiler-generated field
                class1023.gclass187_0 = gclass187;
                // ISSUE: reference to a compiler-generated method
                foreach (GClass22 gclass22 in this.gclass0_0.dictionary_3.Values.Where<GClass22>(class1023.method_0)
                             .ToList<GClass22>())
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: reference to a compiler-generated method
                    List<FCTShipData40> list = this.gclass0_0.FCTShipDataDictionary.Values.Where<FCTShipData40>(
                        new FleetWindow.Class1024()
                        {
                            gclass22_0 = gclass22
                        }.method_0).ToList<FCTShipData40>();
                    if (list.Count > 15)
                    {
                        int num = list.Count - 15;
                        foreach (FCTShipData40 gclass40 in list)
                        {
                            gclass40.gclass21_0.method_302(gclass40.gclass85_0, false);
                            --num;
                            if (num == 0)
                                break;
                        }
                    }
                }

                // ISSUE: reference to a compiler-generated field
                class1023.gclass187_0.decimal_0 = 3000M;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3796);
        }
    }

    private void cmdScrap_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode != null)
            {
                if (this.tvFleetList.SelectedNode.Tag is FleetData)
                {
                    FleetData tag1 = (FleetData)this.tvFleetList.SelectedNode.Tag;
                    if (this.tvFleetCargo.SelectedNode == null)
                    {
                        int num2 = (int)MessageBox.Show("Please select a ship component to scrap");
                    }
                    else if (this.tvFleetCargo.SelectedNode.Tag == null)
                    {
                        int num3 = (int)MessageBox.Show("Please select a ship component to scrap");
                    }
                    else if (this.tvFleetCargo.SelectedNode.Tag is ShipComponent)
                    {
                        ShipComponent tag2 = (ShipComponent)this.tvFleetCargo.SelectedNode.Tag;
                        foreach (FCTShipData40 gclass40 in tag1.method_176())
                            gclass40.method_47(tag2);
                        this.gclass21_0.method_101(this.tvFleetCargo, tag1, null, null);
                        foreach (global::Events events in Application.OpenForms.OfType<global::Events>())
                            events.method_0();
                        if (this.gclass21_0.chkEvents != CheckState.Checked)
                            return;
                        this.gclass0_0.tacticalMap_0.Refresh();
                    }
                    else
                    {
                        int num4 = (int)MessageBox.Show("Please select a ship component to scrap");
                    }
                }
                else
                {
                    int num5 = (int)MessageBox.Show("Please select a fleet");
                }
            }
            else
            {
                int num6 = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3840 /*0x0F00*/);
        }
    }

    private void cmdScrapAll_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode != null)
            {
                if (this.tvFleetList.SelectedNode.Tag is FleetData)
                {
                    FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                    if (MessageBox.Show(
                            $"Are you sure you want to scrap all components in {tag.FleetName}, except for researched non-obsolete components or those that can be disassembled?",
                            "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                    List<FCTShipData40> source = tag.method_176();
                    List<GClass73> list1 = source
                        .SelectMany<FCTShipData40, GClass73>(gclass40_0 => gclass40_0.list_17).ToList<GClass73>();
                    foreach (GClass73 gclass73 in list1)
                    {
                        gclass73.bool_0 = true;
                        if (gclass73.gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID))
                        {
                            if (!gclass73.gclass230_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0)
                                gclass73.bool_0 = false;
                        }
                        else if (this.gclass21_0.method_103(gclass73.gclass230_0))
                            gclass73.bool_0 = false;
                    }

                    List<ShipComponent> list2 = list1.Where<GClass73>(gclass73_0 => gclass73_0.bool_0)
                        .Select<GClass73, ShipComponent>(gclass73_0 => gclass73_0.gclass230_0).Distinct<ShipComponent>()
                        .ToList<ShipComponent>();
                    foreach (FCTShipData40 gclass40 in source)
                    {
                        foreach (ShipComponent gclass230_0 in list2)
                            gclass40.method_47(gclass230_0);
                    }

                    this.gclass21_0.method_101(this.tvFleetCargo, tag, null, null);
                    foreach (global::Events events in Application.OpenForms.OfType<global::Events>())
                        events.method_0();
                    if (this.gclass21_0.chkEvents != CheckState.Checked)
                        return;
                    this.gclass0_0.tacticalMap_0.Refresh();
                }
                else
                {
                    int num2 = (int)MessageBox.Show("Please select a fleet");
                }
            }
            else
            {
                int num3 = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3842);
        }
    }

    private void cmdCollapseAll_Click(object sender, EventArgs e)
    {
        try
        {
            foreach (FleetData gclass85 in this.gclass0_0.FleetDictionary.Values)
                gclass85.bool_16 = false;
            foreach (SubFleet gclass84 in this.gclass0_0.SubFleetDictionary.Values)
                gclass84.bool_0 = false;
            foreach (FCTShipData40 gclass40 in this.gclass0_0.FCTShipDataDictionary.Values)
            {
                gclass40.bool_12 = false;
                foreach (FCTSquadronData70 gclass70 in gclass40.ChildSquadronDictionary.Values)
                    gclass70.bool_0 = false;
            }

            foreach (NavalAdminCommand gclass83 in this.gclass0_0.NavalAdminCommands.Values)
                gclass83.bool_0 = false;
            this.gclass21_0.method_355(this.tvFleetList, null, false,
                AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3856);
        }
    }

    private void cmdAddSO_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_25(false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3899);
        }
    }

    private void method_25(bool bool_3)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag1 = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (tag1 == null)
                    return;
                if (this.tvStandingOrders.SelectedNode == null)
                {
                    int num3 = (int)MessageBox.Show("Please select an order");
                }
                else if (this.tvStandingOrders.SelectedNode.Tag is StandingOrderDefinition)
                {
                    StandingOrderDefinition tag2 = (StandingOrderDefinition)this.tvStandingOrders.SelectedNode.Tag;
                    if (tag1 == null)
                        return;
                    int key = 1;
                    if (tag1.StandingOrdersDictionary.Count > 0)
                        key =
                            tag1.StandingOrdersDictionary.Max<KeyValuePair<int, StandingOrderDefinition>>(keyValuePair_0 => keyValuePair_0.Key) +
                            1;
                    if (!bool_3)
                    {
                        tag1.StandingOrdersDictionary.Add(key, tag2);
                    }
                    else
                    {
                        if (this.lstvConditionOne.SelectedItems.Count == 0)
                        {
                            int num4 = (int)MessageBox.Show("Please select a condition");
                            return;
                        }

                        FleetConditionDefinition tag3 = (FleetConditionDefinition)this.lstvConditionOne.SelectedItems[0].Tag;
                        if (tag1.ConditionalOrdersDictionary.Count > 0)
                            key = tag1.ConditionalOrdersDictionary.Max<KeyValuePair<int, FleetConditionalOrder>>(keyValuePair_0 =>
                                keyValuePair_0.Key) + 1;
                        int num5 = 0;
                        if (this.chkSetFWP.CheckState == CheckState.Checked)
                            num5 = 1;
                        tag1.ConditionalOrdersDictionary.Add(key, new FleetConditionalOrder()
                        {
                            StandingOrder = tag2.auroraStandingOrder_0,
                            Condition = tag3.FleetCondition,
                            CreateFleetWaypoint = num5
                        });
                    }

                    this.lblDefault.Text = tag1.method_173();
                    tag1.method_197(this.lstvStandingOrdersList);
                }
                else
                {
                    int num6 = (int)MessageBox.Show("Please select an order");
                }
            }
            else
            {
                int num7 = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3899);
        }
    }

    private void cmdDeleteSO_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (tag == null)
                    return;
                if (this.lstvStandingOrdersList.SelectedItems.Count == 0)
                {
                    int num3 = (int)MessageBox.Show("Please select an order to delete");
                }
                else if (this.lstvStandingOrdersList.SelectedItems[0].Tag == null)
                {
                    int num4 = (int)MessageBox.Show("Please select an order to delete");
                }
                else
                {
                    int int32 = Convert.ToInt32(this.lstvStandingOrdersList.SelectedItems[0].SubItems[0].Text);
                    if (this.lstvStandingOrdersList.SelectedItems[0].Tag is StandingOrderDefinition)
                    {
                        tag.StandingOrdersDictionary.Remove(int32);
                        tag.method_198(0);
                    }
                    else if (this.lstvStandingOrdersList.SelectedItems[0].Tag is FleetConditionalOrder)
                    {
                        tag.ConditionalOrdersDictionary.Remove(int32);
                        tag.method_199(0);
                    }

                    this.lblDefault.Text = tag.method_173();
                    tag.method_197(this.lstvStandingOrdersList);
                }
            }
            else
            {
                int num5 = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3900);
        }
    }

    private void cmdOrderUp_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_26(true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3902);
        }
    }

    private void method_26(bool bool_3)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag1 = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (tag1 == null)
                    return;
                if (this.lstvStandingOrdersList.SelectedItems.Count == 0)
                {
                    int num3 = (int)MessageBox.Show("Please select an order to move");
                }
                else if (this.lstvStandingOrdersList.SelectedItems[0].Tag == null)
                {
                    int num4 = (int)MessageBox.Show("Please select an order to delete");
                }
                else
                {
                    int selectedIndex = this.lstvStandingOrdersList.SelectedIndices[0];
                    int int32 = Convert.ToInt32(this.lstvStandingOrdersList.SelectedItems[0].SubItems[0].Text);
                    if (bool_3 && int32 == 1)
                        return;
                    if (this.lstvStandingOrdersList.SelectedItems[0].Tag is StandingOrderDefinition)
                    {
                        int num5 = tag1.StandingOrdersDictionary.Max<KeyValuePair<int, StandingOrderDefinition>>(keyValuePair_0 =>
                            keyValuePair_0.Key);
                        if (int32 == num5 && !bool_3)
                            return;
                        StandingOrderDefinition tag2 = (StandingOrderDefinition)this.lstvStandingOrdersList.SelectedItems[0].Tag;
                        tag1.StandingOrdersDictionary.Remove(int32);
                        int num6 = int32 + 1;
                        if (bool_3)
                            num6 = int32 - 1;
                        tag1.method_198(num6);
                        tag1.StandingOrdersDictionary.Add(num6, tag2);
                    }
                    else if (this.lstvStandingOrdersList.SelectedItems[0].Tag is FleetConditionalOrder)
                    {
                        int num7 = tag1.ConditionalOrdersDictionary.Max<KeyValuePair<int, FleetConditionalOrder>>(keyValuePair_0 =>
                            keyValuePair_0.Key);
                        if (int32 == num7 && !bool_3)
                            return;
                        FleetConditionalOrder tag3 = (FleetConditionalOrder)this.lstvStandingOrdersList.SelectedItems[0].Tag;
                        tag1.ConditionalOrdersDictionary.Remove(int32);
                        int num8 = int32 + 1;
                        if (bool_3)
                            num8 = int32 - 1;
                        tag1.method_199(num8);
                        tag1.ConditionalOrdersDictionary.Add(num8, tag3);
                    }

                    this.lblDefault.Text = tag1.method_173();
                    tag1.method_197(this.lstvStandingOrdersList);
                    if (bool_3)
                        this.lstvStandingOrdersList.Items[selectedIndex - 1].Selected = true;
                    else
                        this.lstvStandingOrdersList.Items[selectedIndex + 1].Selected = true;
                }
            }
            else
            {
                int num9 = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3903);
        }
    }

    private void cmdOrderDown_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_26(false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3904);
        }
    }

    private void cmdAddCO_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_25(true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3909);
        }
    }

    private void cmdCreateTemplate_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (tag == null)
                    return;
                if (tag.StandingOrdersDictionary.Count == 0 && tag.ConditionalOrdersDictionary.Count == 0)
                {
                    int num3 = (int)MessageBox.Show(
                        "Please select a fleet with one or more standing or conditional orders");
                }
                else
                {
                    this.gclass0_0.string_3 = "Enter Standing Order Template Name";
                    this.gclass0_0.string_4 = "New Template";
                    int num4 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                    if (this.gclass0_0.bool_21)
                        return;
                    GClass135 gclass135 = new GClass135();
                    gclass135.int_0 = this.gclass0_0.method_26(GEnum0.const_56);
                    gclass135.string_0 = this.gclass0_0.string_4;
                    this.gclass21_0.dictionary_9.Add(gclass135.int_0, gclass135);
                    foreach (KeyValuePair<int, StandingOrderDefinition> keyValuePair in tag.StandingOrdersDictionary)
                        gclass135.dictionary_0.Add(keyValuePair.Key, keyValuePair.Value);
                    foreach (KeyValuePair<int, FleetConditionalOrder> keyValuePair in tag.ConditionalOrdersDictionary)
                        gclass135.dictionary_1.Add(keyValuePair.Key, keyValuePair.Value);
                    this.gclass21_0.method_331(this.lstvStandingOrderTemplates);
                }
            }
            else
            {
                int num5 = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3914);
        }
    }

    private void cmdDeleteSOTemplate_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.lstvStandingOrderTemplates.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select an standing order template to delete");
            }
            else if (this.lstvStandingOrdersList.SelectedItems[0].Tag == null)
            {
                int num3 = (int)MessageBox.Show("Please select an standing order template to delete");
            }
            else
            {
                GClass135 tag = (GClass135)this.lstvStandingOrdersList.SelectedItems[0].Tag;
                if (MessageBox.Show($" Are you sure you want to delete {tag.string_0}?", "Confirmation Required",
                        MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.gclass21_0.dictionary_9.Remove(tag.int_0);
                this.gclass21_0.method_331(this.lstvStandingOrderTemplates);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3916);
        }
    }

    private void cmdLoadTemplate_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag1 = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (tag1 == null)
                    return;
                if (this.lstvStandingOrderTemplates.SelectedItems.Count == 0)
                {
                    int num3 = (int)MessageBox.Show("Please select an standing order template");
                }
                else if (this.lstvStandingOrderTemplates.SelectedItems[0].Tag == null)
                {
                    int num4 = (int)MessageBox.Show("Please select an standing order template");
                }
                else
                {
                    GClass135 tag2 = (GClass135)this.lstvStandingOrderTemplates.SelectedItems[0].Tag;
                    if ((tag1.StandingOrdersDictionary.Count > 0 || tag1.ConditionalOrdersDictionary.Count > 0) && MessageBox.Show(
                            $" Are you sure you want to replace the existing standing and conditional orders with {tag2.string_0}?",
                            "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                    tag1.StandingOrdersDictionary.Clear();
                    tag1.ConditionalOrdersDictionary.Clear();
                    foreach (KeyValuePair<int, StandingOrderDefinition> keyValuePair in tag2.dictionary_0)
                        tag1.StandingOrdersDictionary.Add(keyValuePair.Key, keyValuePair.Value);
                    foreach (KeyValuePair<int, FleetConditionalOrder> keyValuePair in tag2.dictionary_1)
                        tag1.ConditionalOrdersDictionary.Add(keyValuePair.Key, keyValuePair.Value);
                    this.lblDefault.Text = tag1.method_173();
                    tag1.method_197(this.lstvStandingOrdersList);
                }
            }
            else
            {
                int num5 = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3917);
        }
    }

    private void cmdDeleteAll_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                FleetData tag = (FleetData)this.tvFleetList.SelectedNode.Tag;
                if (tag == null)
                    return;
                tag.StandingOrdersDictionary.Clear();
                tag.ConditionalOrdersDictionary.Clear();
                this.lblDefault.Text = tag.method_173();
                tag.method_197(this.lstvStandingOrdersList);
            }
            else
            {
                int num3 = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3918);
        }
    }

    private void cmdCreateFleetWaypoint_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvFleetList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a fleet");
            }
            else if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                ((FleetData)this.tvFleetList.SelectedNode.Tag)?.method_0(true, null, null, 0.0, 0.0);
            }
            else
            {
                int num3 = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3923);
        }
    }

    private void chkDetachedStanding_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                ((FleetData)this.tvFleetList.SelectedNode.Tag).bDetachedStanding =
                    AuroraUtils.smethod_27(this.chkDetachedStanding.CheckState);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3924);
        }
    }

    private void chkDetachedConditional_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                ((FleetData)this.tvFleetList.SelectedNode.Tag).bDetachedCondition =
                    AuroraUtils.smethod_27(this.chkDetachedConditional.CheckState);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3925);
        }
    }

    private void chkIncludeSquadrons_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                ((FleetData)this.tvFleetList.SelectedNode.Tag).bIncludeSquadrons =
                    AuroraUtils.smethod_27(this.chkIncludeSquadrons.CheckState);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3926);
        }
    }

    private void chkIgnoreSO_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                ((FleetData)this.tvFleetList.SelectedNode.Tag).bIgnoreStanding =
                    AuroraUtils.smethod_27(this.chkIgnoreSO.CheckState);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3933);
        }
    }

    private void chkIgnoreCO_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFleetList.SelectedNode == null)
                return;
            if (this.tvFleetList.SelectedNode.Tag is FleetData)
            {
                ((FleetData)this.tvFleetList.SelectedNode.Tag).bIgnoreConditional =
                    AuroraUtils.smethod_27(this.chkIgnoreCO.CheckState);
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a fleet");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3934);
        }
    }

    private void cmdClearFleetTargets_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass40_0 = null;
            FleetData gclass85;
            if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
            {
                this.gclass40_0 = (FCTShipData40)this.tvFleetList.SelectedNode.Tag;
                gclass85 = this.gclass40_0.gclass85_0;
            }
            else if (this.tvFleetList.SelectedNode.Tag is FCTShipData40)
            {
                gclass85 = (FleetData)this.tvFleetList.SelectedNode.Tag;
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a ship or fleet");
                return;
            }

            foreach (FCTShipData40 gclass40 in gclass85.list_3)
            {
                foreach (FireControlAssignment gclass36 in gclass40.list_4)
                {
                    gclass36.TargetID = 0;
                    gclass36.TargetContactType = AuroraContactType.None;
                }
            }

            if (this.gclass40_0 == null)
                return;
            this.gclass40_0.method_37(this.tvCombatAssignment, this.tvTargets, this.bool_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3950);
        }
    }

    private void chkOrders_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass0_0.chkOrders = AuroraUtils.smethod_27(this.chkOrders.CheckState);
            this.gclass21_0.method_355(this.tvFleetList, null, false,
                AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3966);
        }
    }

    private void chkOverhauls_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass0_0.chkOverhauls = AuroraUtils.smethod_27(this.chkOverhauls.CheckState);
            this.gclass21_0.method_355(this.tvFleetList, null, false,
                AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3967);
        }
    }

    private void chkShowJD_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass0_0.chkShowJD = AuroraUtils.smethod_27(this.chkShowJD.CheckState);
            this.gclass21_0.method_355(this.tvFleetList, null, false,
                AuroraUtils.smethod_27(this.chkIncludeCivilians.CheckState), this.txtSystemOOB);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3967);
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FleetWindow));
        this.cboRaces = new ComboBox();
        this.tvFleetList = new TreeView();
        this.cmdDelete = new Button();
        this.cmdRefresh = new Button();
        this.cmdCreateSubFleet = new Button();
        this.lstvShips = new ListView();
        this.columnHeader_0 = new ColumnHeader();
        this.columnHeader_1 = new ColumnHeader();
        this.columnHeader_78 = new ColumnHeader();
        this.columnHeader_2 = new ColumnHeader();
        this.columnHeader_3 = new ColumnHeader();
        this.columnHeader_4 = new ColumnHeader();
        this.columnHeader_5 = new ColumnHeader();
        this.columnHeader_6 = new ColumnHeader();
        this.columnHeader_7 = new ColumnHeader();
        this.columnHeader_8 = new ColumnHeader();
        this.columnHeader_9 = new ColumnHeader();
        this.columnHeader_10 = new ColumnHeader();
        this.columnHeader_11 = new ColumnHeader();
        this.columnHeader_12 = new ColumnHeader();
        this.tabNaval = new TabControl();
        this.tabFleet = new TabPage();
        this.lblClassSummary = new Label();
        this.tabFleetPages = new TabControl();
        this.tabShipList = new TabPage();
        this.tabOrders = new TabPage();
        this.flowLayoutPanel5 = new FlowLayoutPanel();
        this.lblMinDistance = new Label();
        this.txtMinDistance = new TextBox();
        this.lblOrderDelay = new Label();
        this.txtOrderDelay = new TextBox();
        this.lblMaxItems = new Label();
        this.txtMaxItems = new TextBox();
        this.lblOrbDistance = new Label();
        this.txtOrbDistance = new TextBox();
        this.lblMinAvailable = new Label();
        this.txtMinAvailable = new TextBox();
        this.chkLoadSubUnits = new CheckBox();
        this.flpFleetOrderButtons = new FlowLayoutPanel();
        this.cmdAddMove = new Button();
        this.cmdCreatePop = new Button();
        this.cmdRemoveLastOrder = new Button();
        this.cmdRemoveAll = new Button();
        this.cmdRepeat = new Button();
        this.txtRepeatMultiple = new TextBox();
        this.cmdSaveTemplate = new Button();
        this.cmdDeleteTemplate = new Button();
        this.cmdCreateFleetWaypoint = new Button();
        this.chkDefaultActions = new CheckBox();
        this.lstvLoadItems = new ListView();
        this.columnHeader_18 = new ColumnHeader();
        this.columnHeader_19 = new ColumnHeader();
        this.lstvOrders = new ListView();
        this.columnHeader_16 = new ColumnHeader();
        this.lstvActions = new ListView();
        this.columnHeader_17 = new ColumnHeader();
        this.lstvSystemLocations = new ListView();
        this.columnHeader_15 = new ColumnHeader();
        this.flowLayoutPanel3 = new FlowLayoutPanel();
        this.chkAutoLP = new CheckBox();
        this.chkAssumeJumpCapable = new CheckBox();
        this.chkCycle = new CheckBox();
        this.chkDanger = new CheckBox();
        this.chkExcludeAlien = new CheckBox();
        this.chkMaxSpeed = new CheckBox();
        this.flowLayoutPanel2 = new FlowLayoutPanel();
        this.rdoSL = new RadioButton();
        this.rdoARSystem = new RadioButton();
        this.rdoOrderTemplates = new RadioButton();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.chkPlanet = new CheckBox();
        this.chkDwarf = new CheckBox();
        this.chkMoon = new CheckBox();
        this.chkComets = new CheckBox();
        this.chkAst = new CheckBox();
        this.chkFleets = new CheckBox();
        this.chkContacts = new CheckBox();
        this.chkExcludeTP = new CheckBox();
        this.chkCivilian = new CheckBox();
        this.chkLifepods = new CheckBox();
        this.chkWrecks = new CheckBox();
        this.chkWaypoint = new CheckBox();
        this.chkLocation = new CheckBox();
        this.chkExcSurveyed = new CheckBox();
        this.chkFilterOrders = new CheckBox();
        this.tabStandingOrders = new TabPage();
        this.flowLayoutPanel29 = new FlowLayoutPanel();
        this.chkDetachedStanding = new CheckBox();
        this.chkDetachedConditional = new CheckBox();
        this.chkIncludeSquadrons = new CheckBox();
        this.chkIgnoreSO = new CheckBox();
        this.chkIgnoreCO = new CheckBox();
        this.chkSetFWP = new CheckBox();
        this.cmdDeleteAll = new Button();
        this.cmdDeleteSOTemplate = new Button();
        this.cmdLoadTemplate = new Button();
        this.cmdCreateTemplate = new Button();
        this.lstvStandingOrderTemplates = new ListView();
        this.columnHeader_142 = new ColumnHeader();
        this.tvStandingOrders = new TreeView();
        this.cmdAddCO = new Button();
        this.cmdOrderDown = new Button();
        this.cmdOrderUp = new Button();
        this.cmdDeleteSO = new Button();
        this.cmdAddSO = new Button();
        this.lstvStandingOrdersList = new ListView();
        this.columnHeader_139 = new ColumnHeader();
        this.columnHeader_140 = new ColumnHeader();
        this.columnHeader_141 = new ColumnHeader();
        this.columnHeader_143 = new ColumnHeader();
        this.lstvConditionOne = new ListView();
        this.columnHeader_57 = new ColumnHeader();
        this.tabFormation = new TabPage();
        this.flowLayoutPanel20 = new FlowLayoutPanel();
        this.chkCurrentContact = new CheckBox();
        this.chkCurrentSystem = new CheckBox();
        this.tvAnchor = new TreeView();
        this.flowLayoutPanel23 = new FlowLayoutPanel();
        this.cmdSetAnchor = new Button();
        this.cmdSetThreat = new Button();
        this.cmdClearAnchor = new Button();
        this.cmdClearThreat = new Button();
        this.cmdSetDistance = new Button();
        this.cmdSetOffset = new Button();
        this.cmdToggleWarship = new Button();
        this.cmdToggleContact = new Button();
        this.button1 = new Button();
        this.lstvFormation = new ListView();
        this.columnHeader_116 = new ColumnHeader();
        this.columnHeader_117 = new ColumnHeader();
        this.tvThreat = new TreeView();
        this.tabCargo = new TabPage();
        this.cmdScrapAll = new Button();
        this.cmdScrap = new Button();
        this.tvFleetCargo = new TreeView();
        this.tabFleetHistory = new TabPage();
        this.lstvHistory = new ListView();
        this.columnHeader_13 = new ColumnHeader();
        this.columnHeader_14 = new ColumnHeader();
        this.tabFleetMisc = new TabPage();
        this.panel2 = new Panel();
        this.cboTransferRace = new ComboBox();
        this.cmdTransfer = new Button();
        this.panel1 = new Panel();
        this.chkIncFighter = new CheckBox();
        this.chkIncFAC = new CheckBox();
        this.cmdFleetText = new Button();
        this.cmdMoveFleettoWP = new Button();
        this.lstMoveWP = new ListBox();
        this.cmdMoveFleetToPop = new Button();
        this.lstMoveFleet = new ListBox();
        this.flowLayoutPanel15 = new FlowLayoutPanel();
        this.label11 = new Label();
        this.txtSurveyRadius = new TextBox();
        this.chkSensorDisplay = new CheckBox();
        this.chkWeaponDisplay = new CheckBox();
        this.lblDefault = new Label();
        this.lblCapacity = new Label();
        this.lblFleetData = new Label();
        this.lblCommander = new Label();
        this.lblLocation = new Label();
        this.tabShipDisplay = new TabPage();
        this.lstvOfficers = new ListView();
        this.columnHeader_53 = new ColumnHeader();
        this.columnHeader_54 = new ColumnHeader();
        this.tabControl1 = new TabControl();
        this.tabPage1 = new TabPage();
        this.flowLayoutPanel19 = new FlowLayoutPanel();
        this.lstvCrew = new ListView();
        this.columnHeader_49 = new ColumnHeader();
        this.columnHeader_50 = new ColumnHeader();
        this.lstvLogistics = new ListView();
        this.columnHeader_51 = new ColumnHeader();
        this.columnHeader_52 = new ColumnHeader();
        this.lstvOrdnance = new ListView();
        this.columnHeader_55 = new ColumnHeader();
        this.columnHeader_56 = new ColumnHeader();
        this.lstvMeasurement = new ListView();
        this.columnHeader_47 = new ColumnHeader();
        this.columnHeader_48 = new ColumnHeader();
        this.flowLayoutPanel10 = new FlowLayoutPanel();
        this.cboRefuelActive = new ComboBox();
        this.cboResupplyActive = new ComboBox();
        this.cboTransferActive = new ComboBox();
        this.cboHangar = new ComboBox();
        this.flpEnergyWeaponData = new FlowLayoutPanel();
        this.label28 = new Label();
        this.txtTargetSpeed = new TextBox();
        this.label27 = new Label();
        this.txtRangeBand = new TextBox();
        this.txtShipSummary = new TextBox();
        this.tabPage2 = new TabPage();
        this.txtClassDisplay = new TextBox();
        this.tabOrdnanceTemplate = new TabPage();
        this.flowLayoutPanel21 = new FlowLayoutPanel();
        this.lstvClassTemplate = new ListView();
        this.columnHeader_105 = new ColumnHeader();
        this.columnHeader_106 = new ColumnHeader();
        this.lstvShipTemplate = new ListView();
        this.columnHeader_103 = new ColumnHeader();
        this.columnHeader_104 = new ColumnHeader();
        this.lstvShipLoadout = new ListView();
        this.columnHeader_101 = new ColumnHeader();
        this.columnHeader_102 = new ColumnHeader();
        this.flowLayoutPanel22 = new FlowLayoutPanel();
        this.flowLayoutPanel18 = new FlowLayoutPanel();
        this.rdoLoadout1 = new RadioButton();
        this.rdoLoadout10 = new RadioButton();
        this.rdoLoadout100 = new RadioButton();
        this.rdoLoadout1000 = new RadioButton();
        this.chkObsoleteMissiles = new CheckBox();
        this.checkBox1 = new CheckBox();
        this.flowLayoutPanel17 = new FlowLayoutPanel();
        this.cmdRenameMissile = new Button();
        this.cmdObsoleteMissile = new Button();
        this.cmdCopyClassLoadout = new Button();
        this.cmdCopyToClass = new Button();
        this.cmdCopyToFleet = new Button();
        this.cmdFillShip = new Button();
        this.cmdSMFillClass = new Button();
        this.lstvOrdnanceTemplate = new ListView();
        this.columnHeader_89 = new ColumnHeader();
        this.columnHeader_90 = new ColumnHeader();
        this.columnHeader_91 = new ColumnHeader();
        this.columnHeader_92 = new ColumnHeader();
        this.columnHeader_93 = new ColumnHeader();
        this.columnHeader_94 = new ColumnHeader();
        this.columnHeader_95 = new ColumnHeader();
        this.columnHeader_96 = new ColumnHeader();
        this.columnHeader_97 = new ColumnHeader();
        this.columnHeader_98 = new ColumnHeader();
        this.columnHeader_99 = new ColumnHeader();
        this.columnHeader_100 = new ColumnHeader();
        this.columnHeader_130 = new ColumnHeader();
        this.tabShipCargo = new TabPage();
        this.tvShipCargo = new TreeView();
        this.tabArmour = new TabPage();
        this.panArmour = new Panel();
        this.tabPage6 = new TabPage();
        this.flowLayoutPanel14 = new FlowLayoutPanel();
        this.cmdRepair = new Button();
        this.cmdSMRepair = new Button();
        this.cmdAutoQueue = new Button();
        this.chkAutoDC = new CheckBox();
        this.label8 = new Label();
        this.txtRepairChanceTime = new TextBox();
        this.cmdTop = new Button();
        this.cmdRemove = new Button();
        this.cmdDown = new Button();
        this.cmdUp = new Button();
        this.lstvDamageControlQueue = new ListView();
        this.columnHeader_64 = new ColumnHeader();
        this.columnHeader_65 = new ColumnHeader();
        this.columnHeader_69 = new ColumnHeader();
        this.lstvDAC = new ListView();
        this.columnHeader_58 = new ColumnHeader();
        this.columnHeader_59 = new ColumnHeader();
        this.columnHeader_63 = new ColumnHeader();
        this.columnHeader_60 = new ColumnHeader();
        this.columnHeader_61 = new ColumnHeader();
        this.columnHeader_62 = new ColumnHeader();
        this.tabPage8 = new TabPage();
        this.lstvShipHistory = new ListView();
        this.columnHeader_128 = new ColumnHeader();
        this.columnHeader_129 = new ColumnHeader();
        this.tabMiscellaneous = new TabPage();
        this.flowLayoutPanel6 = new FlowLayoutPanel();
        this.cmdSMRefuel = new Button();
        this.cmdPartialRefuel = new Button();
        this.cmdAbandonShip = new Button();
        this.cmdSetHullNumber = new Button();
        this.flowLayoutPanel13 = new FlowLayoutPanel();
        this.panel11 = new Panel();
        this.txtFuelPriority = new TextBox();
        this.label15 = new Label();
        this.panel8 = new Panel();
        this.txtSupplyPriority = new TextBox();
        this.label10 = new Label();
        this.label14 = new Label();
        this.chkRetainData = new CheckBox();
        this.ckhTarget = new CheckBox();
        this.flowLayoutPanel11 = new FlowLayoutPanel();
        this.label7 = new Label();
        this.lstvWeapons = new ListView();
        this.columnHeader_66 = new ColumnHeader();
        this.columnHeader_67 = new ColumnHeader();
        this.columnHeader_68 = new ColumnHeader();
        this.flowLayoutPanel4 = new FlowLayoutPanel();
        this.flowLayoutPanel12 = new FlowLayoutPanel();
        this.label6 = new Label();
        this.txtManualDamage = new TextBox();
        this.cmdInternalDamage = new Button();
        this.cmdDamage = new Button();
        this.tabCombat = new TabPage();
        this.flowLayoutPanel25 = new FlowLayoutPanel();
        this.chkHostileOnly = new CheckBox();
        this.chkDragAll = new CheckBox();
        this.chkDragNum = new CheckBox();
        this.txtAssignNum = new TextBox();
        this.cmdOpenFireAll = new Button();
        this.cmdOpenFire = new Button();
        this.cmdFleetAtWill = new Button();
        this.cmdFireAtWillFC = new Button();
        this.cmdAssignFleet = new Button();
        this.cmdAssignSubFleet = new Button();
        this.cmdAssignSystem = new Button();
        this.cmdAssignAll = new Button();
        this.cmOpenFireFleet = new Button();
        this.cmdFleetFireAtWill = new Button();
        this.cmOpenFireFleetMFC = new Button();
        this.cmOpenFireFleetBFC = new Button();
        this.cmdCeaseFireFleet = new Button();
        this.cmdClearTarget = new Button();
        this.cmdClearAllTargets = new Button();
        this.cmdClearFleetTargets = new Button();
        this.cmdAutoAssign = new Button();
        this.cmdAutoTargetMFC = new Button();
        this.cmdAutoTargetBFC = new Button();
        this.chkDoubleRange = new CheckBox();
        this.flowLayoutPanel32 = new FlowLayoutPanel();
        this.cmdSyncFire = new Button();
        this.cmdFleetSync = new Button();
        this.cmdFleetSyncOff = new Button();
        this.cmdMinAMMRange = new Button();
        this.cmdDecoyThreshold = new Button();
        this.tvTargets = new TreeView();
        this.tvCombatAssignment = new TreeView();
        this.tabAdminCommand = new TabPage();
        this.panel3 = new Panel();
        this.cmdReassignAllGovernors = new Button();
        this.cmdAssignGovernors = new Button();
        this.cmdSelectGovernor = new Button();
        this.flowLayoutPanel27 = new FlowLayoutPanel();
        this.flowLayoutPanel24 = new FlowLayoutPanel();
        this.label39 = new Label();
        this.label36 = new Label();
        this.label40 = new Label();
        this.label9 = new Label();
        this.flowLayoutPanel26 = new FlowLayoutPanel();
        this.cboBonusOne = new ComboBox();
        this.cboBonusTwo = new ComboBox();
        this.cboBonusThree = new ComboBox();
        this.cboNavalRanks = new ComboBox();
        this.label37 = new Label();
        this.txtImportance = new TextBox();
        this.chkAutoAssign = new CheckBox();
        this.lblNACCommander = new Label();
        this.textBox1 = new TextBox();
        this.label2 = new Label();
        this.cmdUpdateAdmin = new Button();
        this.cmdCreateAdmin = new Button();
        this.lstvPopulation = new ListView();
        this.columnHeader_31 = new ColumnHeader();
        this.columnHeader_32 = new ColumnHeader();
        this.columnHeader_33 = new ColumnHeader();
        this.columnHeader_34 = new ColumnHeader();
        this.lstvNACTypes = new ListView();
        this.columnHeader_23 = new ColumnHeader();
        this.columnHeader_24 = new ColumnHeader();
        this.columnHeader_25 = new ColumnHeader();
        this.columnHeader_26 = new ColumnHeader();
        this.columnHeader_27 = new ColumnHeader();
        this.columnHeader_28 = new ColumnHeader();
        this.columnHeader_29 = new ColumnHeader();
        this.columnHeader_30 = new ColumnHeader();
        this.columnHeader_35 = new ColumnHeader();
        this.columnHeader_36 = new ColumnHeader();
        this.columnHeader_37 = new ColumnHeader();
        this.lstvAdminCommandSystems = new ListView();
        this.columnHeader_20 = new ColumnHeader();
        this.columnHeader_21 = new ColumnHeader();
        this.columnHeader_22 = new ColumnHeader();
        this.tabLogistics = new TabPage();
        this.cboSortType = new ComboBox();
        this.flowLayoutPanel16 = new FlowLayoutPanel();
        this.chkLogSupplyShip = new CheckBox();
        this.chkLogExcTanker = new CheckBox();
        this.chkLogExcludeFighter = new CheckBox();
        this.chkLogExcludeFAC = new CheckBox();
        this.chkLogExcludeSY = new CheckBox();
        this.chkLogNonArmed = new CheckBox();
        this.lstvLogisticsReport = new ListView();
        this.columnHeader_79 = new ColumnHeader();
        this.columnHeader_80 = new ColumnHeader();
        this.columnHeader_81 = new ColumnHeader();
        this.columnHeader_82 = new ColumnHeader();
        this.columnHeader_83 = new ColumnHeader();
        this.columnHeader_84 = new ColumnHeader();
        this.columnHeader_85 = new ColumnHeader();
        this.columnHeader_86 = new ColumnHeader();
        this.columnHeader_87 = new ColumnHeader();
        this.columnHeader_88 = new ColumnHeader();
        this.tabFuel = new TabPage();
        this.flowLayoutPanel7 = new FlowLayoutPanel();
        this.chkSupplyShip = new CheckBox();
        this.chkExcTanker = new CheckBox();
        this.chkExcludeFighter = new CheckBox();
        this.chkExcludeFAC = new CheckBox();
        this.chkExcludeSY = new CheckBox();
        this.chkNonArmed = new CheckBox();
        this.lstvFuel = new ListView();
        this.columnHeader_38 = new ColumnHeader();
        this.columnHeader_39 = new ColumnHeader();
        this.columnHeader_40 = new ColumnHeader();
        this.columnHeader_41 = new ColumnHeader();
        this.columnHeader_42 = new ColumnHeader();
        this.columnHeader_43 = new ColumnHeader();
        this.columnHeader_44 = new ColumnHeader();
        this.columnHeader_45 = new ColumnHeader();
        this.columnHeader_46 = new ColumnHeader();
        this.tabPage5 = new TabPage();
        this.lstvRepair = new ListView();
        this.columnHeader_107 = new ColumnHeader();
        this.columnHeader_108 = new ColumnHeader();
        this.columnHeader_109 = new ColumnHeader();
        this.columnHeader_110 = new ColumnHeader();
        this.columnHeader_111 = new ColumnHeader();
        this.columnHeader_112 = new ColumnHeader();
        this.columnHeader_113 = new ColumnHeader();
        this.columnHeader_114 = new ColumnHeader();
        this.columnHeader_115 = new ColumnHeader();
        this.columnHeader_138 = new ColumnHeader();
        this.chkExcludeFighterRepair = new CheckBox();
        this.chkExcludeFACRepair = new CheckBox();
        this.chkExcludeSYRepair = new CheckBox();
        this.chkNonArmedRepair = new CheckBox();
        this.tabShippingLine = new TabPage();
        this.lstvWealth = new ListView();
        this.columnHeader_72 = new ColumnHeader();
        this.columnHeader_73 = new ColumnHeader();
        this.columnHeader_74 = new ColumnHeader();
        this.columnHeader_75 = new ColumnHeader();
        this.columnHeader_76 = new ColumnHeader();
        this.columnHeader_77 = new ColumnHeader();
        this.lstvSL = new ListView();
        this.columnHeader_70 = new ColumnHeader();
        this.columnHeader_71 = new ColumnHeader();
        this.tabOOB = new TabPage();
        this.txtSystemOOB = new TextBox();
        this.tabPage3 = new TabPage();
        this.flowLayoutPanel28 = new FlowLayoutPanel();
        this.rdoMilitary = new RadioButton();
        this.rdoCommercial = new RadioButton();
        this.rdoGround = new RadioButton();
        this.rdoMissiles = new RadioButton();
        this.rdoSize = new RadioButton();
        this.rdoDistance = new RadioButton();
        this.chkIncludeSG = new CheckBox();
        this.lstvCombatRating = new ListView();
        this.columnHeader_118 = new ColumnHeader();
        this.columnHeader_119 = new ColumnHeader();
        this.columnHeader_120 = new ColumnHeader();
        this.columnHeader_121 = new ColumnHeader();
        this.columnHeader_122 = new ColumnHeader();
        this.columnHeader_123 = new ColumnHeader();
        this.columnHeader_124 = new ColumnHeader();
        this.columnHeader_125 = new ColumnHeader();
        this.columnHeader_126 = new ColumnHeader();
        this.columnHeader_127 = new ColumnHeader();
        this.tabPage4 = new TabPage();
        this.cmdDeleteSalvo = new Button();
        this.lstvSalvos = new ListView();
        this.columnHeader_131 = new ColumnHeader();
        this.columnHeader_132 = new ColumnHeader();
        this.columnHeader_133 = new ColumnHeader();
        this.columnHeader_134 = new ColumnHeader();
        this.columnHeader_135 = new ColumnHeader();
        this.columnHeader_137 = new ColumnHeader();
        this.columnHeader_136 = new ColumnHeader();
        this.cmdRename = new Button();
        this.cmdCreateFleet = new Button();
        this.cmdSetSpeed = new Button();
        this.chkSelectOnMap = new CheckBox();
        this.cmdDetach = new Button();
        this.flowLayoutPanel9 = new FlowLayoutPanel();
        this.cmdCreateSquadron = new Button();
        this.cmdAutoFleetFC = new Button();
        this.cmdSelectName = new Button();
        this.cmdActive2 = new Button();
        this.cmdFleetShields = new Button();
        this.cmdEndOverhaul = new Button();
        this.cmdLaunchAll = new Button();
        this.cmdDetachEscorts = new Button();
        this.cmdRecallEscorts = new Button();
        this.cmdAwardMedal = new Button();
        this.cmdTemp = new Button();
        this.cmdCollapseAll = new Button();
        this.chkIncludeCivilians = new CheckBox();
        this.flowLayoutPanel30 = new FlowLayoutPanel();
        this.chkShowJD = new CheckBox();
        this.chkOverhauls = new CheckBox();
        this.chkOrders = new CheckBox();
        this.tabNaval.SuspendLayout();
        this.tabFleet.SuspendLayout();
        this.tabFleetPages.SuspendLayout();
        this.tabShipList.SuspendLayout();
        this.tabOrders.SuspendLayout();
        this.flowLayoutPanel5.SuspendLayout();
        this.flpFleetOrderButtons.SuspendLayout();
        this.flowLayoutPanel3.SuspendLayout();
        this.flowLayoutPanel2.SuspendLayout();
        this.flowLayoutPanel1.SuspendLayout();
        this.tabStandingOrders.SuspendLayout();
        this.flowLayoutPanel29.SuspendLayout();
        this.tabFormation.SuspendLayout();
        this.flowLayoutPanel20.SuspendLayout();
        this.flowLayoutPanel23.SuspendLayout();
        this.tabCargo.SuspendLayout();
        this.tabFleetHistory.SuspendLayout();
        this.tabFleetMisc.SuspendLayout();
        this.panel2.SuspendLayout();
        this.panel1.SuspendLayout();
        this.flowLayoutPanel15.SuspendLayout();
        this.tabShipDisplay.SuspendLayout();
        this.tabControl1.SuspendLayout();
        this.tabPage1.SuspendLayout();
        this.flowLayoutPanel19.SuspendLayout();
        this.flowLayoutPanel10.SuspendLayout();
        this.flpEnergyWeaponData.SuspendLayout();
        this.tabPage2.SuspendLayout();
        this.tabOrdnanceTemplate.SuspendLayout();
        this.flowLayoutPanel21.SuspendLayout();
        this.flowLayoutPanel22.SuspendLayout();
        this.flowLayoutPanel18.SuspendLayout();
        this.flowLayoutPanel17.SuspendLayout();
        this.tabShipCargo.SuspendLayout();
        this.tabArmour.SuspendLayout();
        this.tabPage6.SuspendLayout();
        this.flowLayoutPanel14.SuspendLayout();
        this.tabPage8.SuspendLayout();
        this.tabMiscellaneous.SuspendLayout();
        this.flowLayoutPanel6.SuspendLayout();
        this.flowLayoutPanel13.SuspendLayout();
        this.panel11.SuspendLayout();
        this.panel8.SuspendLayout();
        this.flowLayoutPanel11.SuspendLayout();
        this.flowLayoutPanel4.SuspendLayout();
        this.flowLayoutPanel12.SuspendLayout();
        this.tabCombat.SuspendLayout();
        this.flowLayoutPanel25.SuspendLayout();
        this.flowLayoutPanel32.SuspendLayout();
        this.tabAdminCommand.SuspendLayout();
        this.panel3.SuspendLayout();
        this.flowLayoutPanel27.SuspendLayout();
        this.flowLayoutPanel24.SuspendLayout();
        this.flowLayoutPanel26.SuspendLayout();
        this.tabLogistics.SuspendLayout();
        this.flowLayoutPanel16.SuspendLayout();
        this.tabFuel.SuspendLayout();
        this.flowLayoutPanel7.SuspendLayout();
        this.tabPage5.SuspendLayout();
        this.tabShippingLine.SuspendLayout();
        this.tabOOB.SuspendLayout();
        this.tabPage3.SuspendLayout();
        this.flowLayoutPanel28.SuspendLayout();
        this.tabPage4.SuspendLayout();
        this.flowLayoutPanel9.SuspendLayout();
        this.flowLayoutPanel30.SuspendLayout();
        this.SuspendLayout();
        this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRaces.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboRaces.FormattingEnabled = true;
        this.cboRaces.Location = new Point(3, 3);
        this.cboRaces.Margin = new Padding(3, 3, 3, 0);
        this.cboRaces.Name = "cboRaces";
        this.cboRaces.Size = new Size(276, 21);
        this.cboRaces.TabIndex = 40;
        this.cboRaces.SelectedIndexChanged += this.cboRaces_SelectedIndexChanged;
        this.tvFleetList.AllowDrop = true;
        this.tvFleetList.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvFleetList.BorderStyle = BorderStyle.FixedSingle;
        this.tvFleetList.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvFleetList.HideSelection = false;
        this.tvFleetList.Location = new Point(3, 30);
        this.tvFleetList.Margin = new Padding(3, 0, 0, 3);
        this.tvFleetList.Name = "tvFleetList";
        this.tvFleetList.Size = new Size(381, 756);
        this.tvFleetList.TabIndex = 41;
        this.tvFleetList.AfterCollapse += this.tvFleetList_AfterCollapse;
        this.tvFleetList.AfterExpand += this.tvFleetList_AfterExpand;
        this.tvFleetList.ItemDrag += this.tvFleetList_ItemDrag;
        this.tvFleetList.AfterSelect += this.tvFleetList_AfterSelect;
        this.tvFleetList.DragDrop += this.tvFleetList_DragDrop;
        this.tvFleetList.DragEnter += this.tvFleetList_DragEnter;
        this.cmdDelete.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDelete.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDelete.Location = new Point(288, 30);
        this.cmdDelete.Margin = new Padding(0);
        this.cmdDelete.Name = "cmdDelete";
        this.cmdDelete.Size = new Size(96 /*0x60*/, 30);
        this.cmdDelete.TabIndex = 125;
        this.cmdDelete.Tag = "1200";
        this.cmdDelete.Text = "Delete";
        this.cmdDelete.UseVisualStyleBackColor = false;
        this.cmdDelete.Click += this.cmdDelete_Click;
        this.cmdRefresh.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRefresh.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRefresh.Location = new Point(192 /*0xC0*/, 30);
        this.cmdRefresh.Margin = new Padding(0);
        this.cmdRefresh.Name = "cmdRefresh";
        this.cmdRefresh.Size = new Size(96 /*0x60*/, 30);
        this.cmdRefresh.TabIndex = 126;
        this.cmdRefresh.Tag = "1200";
        this.cmdRefresh.Text = "Refresh";
        this.cmdRefresh.UseVisualStyleBackColor = false;
        this.cmdRefresh.Click += this.cmdRefresh_Click;
        this.cmdCreateSubFleet.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreateSubFleet.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreateSubFleet.Location = new Point(96 /*0x60*/, 0);
        this.cmdCreateSubFleet.Margin = new Padding(0);
        this.cmdCreateSubFleet.Name = "cmdCreateSubFleet";
        this.cmdCreateSubFleet.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreateSubFleet.TabIndex = 127;
        this.cmdCreateSubFleet.Tag = "1200";
        this.cmdCreateSubFleet.Text = "Create Sub Fleet";
        this.cmdCreateSubFleet.UseVisualStyleBackColor = false;
        this.cmdCreateSubFleet.Visible = false;
        this.cmdCreateSubFleet.Click += this.cmdCreateSubFleet_Click;
        this.lstvShips.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvShips.BorderStyle = BorderStyle.None;
        this.lstvShips.Columns.AddRange(new ColumnHeader[14]
        {
            this.columnHeader_0,
            this.columnHeader_1,
            this.columnHeader_78,
            this.columnHeader_2,
            this.columnHeader_3,
            this.columnHeader_4,
            this.columnHeader_5,
            this.columnHeader_6,
            this.columnHeader_7,
            this.columnHeader_8,
            this.columnHeader_9,
            this.columnHeader_10,
            this.columnHeader_11,
            this.columnHeader_12
        });
        this.lstvShips.Dock = DockStyle.Fill;
        this.lstvShips.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvShips.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvShips.HideSelection = false;
        this.lstvShips.Location = new Point(3, 3);
        this.lstvShips.Name = "lstvShips";
        this.lstvShips.Size = new Size(1014, 647);
        this.lstvShips.TabIndex = 128 /*0x80*/;
        this.lstvShips.UseCompatibleStateImageBehavior = false;
        this.lstvShips.View = View.Details;
        this.lstvShips.SelectedIndexChanged += this.lstvShips_SelectedIndexChanged;
        this.lstvShips.DoubleClick += this.lstvShips_DoubleClick;
        this.lstvShips.MouseDoubleClick += this.lstvShips_MouseDoubleClick;
        this.columnHeader_0.Width = 145;
        this.columnHeader_1.Text = "";
        this.columnHeader_1.Width = 115;
        this.columnHeader_78.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_2.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_2.Width = 50;
        this.columnHeader_3.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_3.Width = 50;
        this.columnHeader_4.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_4.Width = 50;
        this.columnHeader_5.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_5.Width = 50;
        this.columnHeader_6.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_6.Width = 50;
        this.columnHeader_7.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_7.Width = 50;
        this.columnHeader_8.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_8.Width = 50;
        this.columnHeader_9.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_9.Width = 50;
        this.columnHeader_10.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_10.Width = 50;
        this.columnHeader_11.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_11.Width = 50;
        this.columnHeader_12.Width = 180;
        this.tabNaval.Controls.Add(this.tabFleet);
        this.tabNaval.Controls.Add(this.tabShipDisplay);
        this.tabNaval.Controls.Add(this.tabCombat);
        this.tabNaval.Controls.Add(this.tabAdminCommand);
        this.tabNaval.Controls.Add(this.tabLogistics);
        this.tabNaval.Controls.Add(this.tabFuel);
        this.tabNaval.Controls.Add(this.tabPage5);
        this.tabNaval.Controls.Add(this.tabShippingLine);
        this.tabNaval.Controls.Add(this.tabOOB);
        this.tabNaval.Controls.Add(this.tabPage3);
        this.tabNaval.Controls.Add(this.tabPage4);
        this.tabNaval.Location = new Point(387, 3);
        this.tabNaval.Name = "tabNaval";
        this.tabNaval.SelectedIndex = 0;
        this.tabNaval.Size = new Size(1036, 818);
        this.tabNaval.TabIndex = 129;
        this.tabFleet.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabFleet.Controls.Add(this.lblClassSummary);
        this.tabFleet.Controls.Add(this.tabFleetPages);
        this.tabFleet.Controls.Add(this.lblDefault);
        this.tabFleet.Controls.Add(this.lblCapacity);
        this.tabFleet.Controls.Add(this.lblFleetData);
        this.tabFleet.Controls.Add(this.lblCommander);
        this.tabFleet.Controls.Add(this.lblLocation);
        this.tabFleet.Location = new Point(4, 22);
        this.tabFleet.Name = "tabFleet";
        this.tabFleet.Padding = new Padding(3);
        this.tabFleet.Size = new Size(1028, 792);
        this.tabFleet.TabIndex = 0;
        this.tabFleet.Text = "Fleet";
        this.lblClassSummary.Location = new Point(3, 101);
        this.lblClassSummary.Margin = new Padding(3);
        this.lblClassSummary.Name = "lblClassSummary";
        this.lblClassSummary.Size = new Size(1018, 13);
        this.lblClassSummary.TabIndex = 136;
        this.lblClassSummary.Text = "Class Summary";
        this.tabFleetPages.Controls.Add(this.tabShipList);
        this.tabFleetPages.Controls.Add(this.tabOrders);
        this.tabFleetPages.Controls.Add(this.tabStandingOrders);
        this.tabFleetPages.Controls.Add(this.tabFormation);
        this.tabFleetPages.Controls.Add(this.tabCargo);
        this.tabFleetPages.Controls.Add(this.tabFleetHistory);
        this.tabFleetPages.Controls.Add(this.tabFleetMisc);
        this.tabFleetPages.Location = new Point(0, 120);
        this.tabFleetPages.Margin = new Padding(0);
        this.tabFleetPages.Name = "tabFleetPages";
        this.tabFleetPages.SelectedIndex = 0;
        this.tabFleetPages.Size = new Size(1028, 679);
        this.tabFleetPages.TabIndex = 135;
        this.tabShipList.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabShipList.Controls.Add(this.lstvShips);
        this.tabShipList.Location = new Point(4, 22);
        this.tabShipList.Margin = new Padding(0);
        this.tabShipList.Name = "tabShipList";
        this.tabShipList.Padding = new Padding(3);
        this.tabShipList.Size = new Size(1020, 653);
        this.tabShipList.TabIndex = 0;
        this.tabShipList.Text = "Ship List";
        this.tabOrders.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabOrders.Controls.Add(this.flowLayoutPanel5);
        this.tabOrders.Controls.Add(this.flpFleetOrderButtons);
        this.tabOrders.Controls.Add(this.lstvLoadItems);
        this.tabOrders.Controls.Add(this.lstvOrders);
        this.tabOrders.Controls.Add(this.lstvActions);
        this.tabOrders.Controls.Add(this.lstvSystemLocations);
        this.tabOrders.Controls.Add(this.flowLayoutPanel3);
        this.tabOrders.Controls.Add(this.flowLayoutPanel2);
        this.tabOrders.Controls.Add(this.flowLayoutPanel1);
        this.tabOrders.Location = new Point(4, 22);
        this.tabOrders.Margin = new Padding(0);
        this.tabOrders.Name = "tabOrders";
        this.tabOrders.Padding = new Padding(3);
        this.tabOrders.Size = new Size(1020, 653);
        this.tabOrders.TabIndex = 1;
        this.tabOrders.Text = "Movement Orders";
        this.flowLayoutPanel5.Controls.Add(this.lblMinDistance);
        this.flowLayoutPanel5.Controls.Add(this.txtMinDistance);
        this.flowLayoutPanel5.Controls.Add(this.lblOrderDelay);
        this.flowLayoutPanel5.Controls.Add(this.txtOrderDelay);
        this.flowLayoutPanel5.Controls.Add(this.lblMaxItems);
        this.flowLayoutPanel5.Controls.Add(this.txtMaxItems);
        this.flowLayoutPanel5.Controls.Add(this.lblOrbDistance);
        this.flowLayoutPanel5.Controls.Add(this.txtOrbDistance);
        this.flowLayoutPanel5.Controls.Add(this.lblMinAvailable);
        this.flowLayoutPanel5.Controls.Add(this.txtMinAvailable);
        this.flowLayoutPanel5.Controls.Add(this.chkLoadSubUnits);
        this.flowLayoutPanel5.Location = new Point(4, 584);
        this.flowLayoutPanel5.Name = "flowLayoutPanel5";
        this.flowLayoutPanel5.Size = new Size(1013, 30);
        this.flowLayoutPanel5.TabIndex = 131;
        this.lblMinDistance.AutoSize = true;
        this.lblMinDistance.Location = new Point(0, 4);
        this.lblMinDistance.Margin = new Padding(0, 4, 0, 3);
        this.lblMinDistance.Name = "lblMinDistance";
        this.lblMinDistance.Padding = new Padding(0, 5, 5, 0);
        this.lblMinDistance.Size = new Size(98, 18);
        this.lblMinDistance.TabIndex = 140;
        this.lblMinDistance.Text = "Minimum Distance";
        this.txtMinDistance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMinDistance.BorderStyle = BorderStyle.None;
        this.txtMinDistance.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMinDistance.Location = new Point(98, 10);
        this.txtMinDistance.Margin = new Padding(0, 10, 3, 3);
        this.txtMinDistance.Name = "txtMinDistance";
        this.txtMinDistance.Size = new Size(82, 13);
        this.txtMinDistance.TabIndex = 141;
        this.txtMinDistance.Text = "0";
        this.txtMinDistance.TextAlign = HorizontalAlignment.Center;
        this.lblOrderDelay.AutoSize = true;
        this.lblOrderDelay.Location = new Point(186, 4);
        this.lblOrderDelay.Margin = new Padding(3, 4, 0, 3);
        this.lblOrderDelay.Name = "lblOrderDelay";
        this.lblOrderDelay.Padding = new Padding(0, 5, 5, 0);
        this.lblOrderDelay.Size = new Size(68, 18);
        this.lblOrderDelay.TabIndex = 136;
        this.lblOrderDelay.Text = "Order Delay";
        this.txtOrderDelay.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtOrderDelay.BorderStyle = BorderStyle.None;
        this.txtOrderDelay.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtOrderDelay.Location = new Point(254, 10);
        this.txtOrderDelay.Margin = new Padding(0, 10, 3, 3);
        this.txtOrderDelay.Name = "txtOrderDelay";
        this.txtOrderDelay.Size = new Size(80 /*0x50*/, 13);
        this.txtOrderDelay.TabIndex = 137;
        this.txtOrderDelay.Text = "0";
        this.txtOrderDelay.TextAlign = HorizontalAlignment.Center;
        this.lblMaxItems.AutoSize = true;
        this.lblMaxItems.Location = new Point(340, 4);
        this.lblMaxItems.Margin = new Padding(3, 4, 0, 3);
        this.lblMaxItems.Name = "lblMaxItems";
        this.lblMaxItems.Padding = new Padding(0, 5, 5, 0);
        this.lblMaxItems.Size = new Size(84, 18);
        this.lblMaxItems.TabIndex = 132;
        this.lblMaxItems.Text = "Maximum Items";
        this.txtMaxItems.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMaxItems.BorderStyle = BorderStyle.None;
        this.txtMaxItems.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMaxItems.Location = new Point(424, 10);
        this.txtMaxItems.Margin = new Padding(0, 10, 3, 3);
        this.txtMaxItems.Name = "txtMaxItems";
        this.txtMaxItems.Size = new Size(40, 13);
        this.txtMaxItems.TabIndex = 133;
        this.txtMaxItems.Text = "0";
        this.txtMaxItems.TextAlign = HorizontalAlignment.Center;
        this.lblOrbDistance.AutoSize = true;
        this.lblOrbDistance.Location = new Point(473, 4);
        this.lblOrbDistance.Margin = new Padding(6, 4, 0, 3);
        this.lblOrbDistance.Name = "lblOrbDistance";
        this.lblOrbDistance.Padding = new Padding(0, 5, 5, 0);
        this.lblOrbDistance.Size = new Size(87, 18);
        this.lblOrbDistance.TabIndex = 134;
        this.lblOrbDistance.Text = "Orbital Distance";
        this.txtOrbDistance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtOrbDistance.BorderStyle = BorderStyle.None;
        this.txtOrbDistance.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtOrbDistance.Location = new Point(560, 10);
        this.txtOrbDistance.Margin = new Padding(0, 10, 3, 3);
        this.txtOrbDistance.Name = "txtOrbDistance";
        this.txtOrbDistance.Size = new Size(40, 13);
        this.txtOrbDistance.TabIndex = 135;
        this.txtOrbDistance.Text = "0";
        this.txtOrbDistance.TextAlign = HorizontalAlignment.Center;
        this.lblMinAvailable.AutoSize = true;
        this.lblMinAvailable.Location = new Point(606, 4);
        this.lblMinAvailable.Margin = new Padding(3, 4, 0, 3);
        this.lblMinAvailable.Name = "lblMinAvailable";
        this.lblMinAvailable.Padding = new Padding(0, 5, 5, 0);
        this.lblMinAvailable.Size = new Size(99, 18);
        this.lblMinAvailable.TabIndex = 142;
        this.lblMinAvailable.Text = "Minimum Available";
        this.txtMinAvailable.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMinAvailable.BorderStyle = BorderStyle.None;
        this.txtMinAvailable.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMinAvailable.Location = new Point(705, 10);
        this.txtMinAvailable.Margin = new Padding(0, 10, 3, 3);
        this.txtMinAvailable.Name = "txtMinAvailable";
        this.txtMinAvailable.Size = new Size(40, 13);
        this.txtMinAvailable.TabIndex = 143;
        this.txtMinAvailable.Text = "0";
        this.txtMinAvailable.TextAlign = HorizontalAlignment.Center;
        this.chkLoadSubUnits.AutoSize = true;
        this.chkLoadSubUnits.Location = new Point(751, 8);
        this.chkLoadSubUnits.Margin = new Padding(3, 8, 3, 3);
        this.chkLoadSubUnits.Name = "chkLoadSubUnits";
        this.chkLoadSubUnits.Padding = new Padding(5, 0, 0, 0);
        this.chkLoadSubUnits.Size = new Size(118, 17);
        this.chkLoadSubUnits.TabIndex = 139;
        this.chkLoadSubUnits.Text = "Load All Sub-Units";
        this.chkLoadSubUnits.TextAlign = ContentAlignment.MiddleRight;
        this.chkLoadSubUnits.UseVisualStyleBackColor = true;
        this.flpFleetOrderButtons.Controls.Add(this.cmdAddMove);
        this.flpFleetOrderButtons.Controls.Add(this.cmdCreatePop);
        this.flpFleetOrderButtons.Controls.Add(this.cmdRemoveLastOrder);
        this.flpFleetOrderButtons.Controls.Add(this.cmdRemoveAll);
        this.flpFleetOrderButtons.Controls.Add(this.cmdRepeat);
        this.flpFleetOrderButtons.Controls.Add(this.txtRepeatMultiple);
        this.flpFleetOrderButtons.Controls.Add(this.cmdSaveTemplate);
        this.flpFleetOrderButtons.Controls.Add(this.cmdDeleteTemplate);
        this.flpFleetOrderButtons.Controls.Add(this.cmdCreateFleetWaypoint);
        this.flpFleetOrderButtons.Controls.Add(this.chkDefaultActions);
        this.flpFleetOrderButtons.Location = new Point(4, 617);
        this.flpFleetOrderButtons.Name = "flpFleetOrderButtons";
        this.flpFleetOrderButtons.Size = new Size(1013, 30);
        this.flpFleetOrderButtons.TabIndex = 130;
        this.cmdAddMove.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddMove.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAddMove.Location = new Point(0, 0);
        this.cmdAddMove.Margin = new Padding(0);
        this.cmdAddMove.Name = "cmdAddMove";
        this.cmdAddMove.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddMove.TabIndex = 125;
        this.cmdAddMove.Tag = "1200";
        this.cmdAddMove.Text = "Add Move";
        this.cmdAddMove.UseVisualStyleBackColor = false;
        this.cmdAddMove.Click += this.cmdAddMove_Click;
        this.cmdCreatePop.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreatePop.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreatePop.Location = new Point(96 /*0x60*/, 0);
        this.cmdCreatePop.Margin = new Padding(0);
        this.cmdCreatePop.Name = "cmdCreatePop";
        this.cmdCreatePop.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreatePop.TabIndex = 137;
        this.cmdCreatePop.Tag = "1200";
        this.cmdCreatePop.Text = "Create Colony";
        this.cmdCreatePop.UseVisualStyleBackColor = false;
        this.cmdCreatePop.Click += this.cmdCreatePop_Click;
        this.cmdRemoveLastOrder.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRemoveLastOrder.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRemoveLastOrder.Location = new Point(192 /*0xC0*/, 0);
        this.cmdRemoveLastOrder.Margin = new Padding(0);
        this.cmdRemoveLastOrder.Name = "cmdRemoveLastOrder";
        this.cmdRemoveLastOrder.Size = new Size(96 /*0x60*/, 30);
        this.cmdRemoveLastOrder.TabIndex = 131;
        this.cmdRemoveLastOrder.Tag = "1200";
        this.cmdRemoveLastOrder.Text = "Remove Last";
        this.cmdRemoveLastOrder.UseVisualStyleBackColor = false;
        this.cmdRemoveLastOrder.Click += this.cmdRemoveLastOrder_Click;
        this.cmdRemoveAll.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRemoveAll.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRemoveAll.Location = new Point(288, 0);
        this.cmdRemoveAll.Margin = new Padding(0);
        this.cmdRemoveAll.Name = "cmdRemoveAll";
        this.cmdRemoveAll.Size = new Size(96 /*0x60*/, 30);
        this.cmdRemoveAll.TabIndex = 131;
        this.cmdRemoveAll.Tag = "1200";
        this.cmdRemoveAll.Text = "Remove All";
        this.cmdRemoveAll.UseVisualStyleBackColor = false;
        this.cmdRemoveAll.Click += this.cmdRemoveAll_Click;
        this.cmdRepeat.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRepeat.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRepeat.Location = new Point(384, 0);
        this.cmdRepeat.Margin = new Padding(0);
        this.cmdRepeat.Name = "cmdRepeat";
        this.cmdRepeat.Size = new Size(96 /*0x60*/, 30);
        this.cmdRepeat.TabIndex = 144 /*0x90*/;
        this.cmdRepeat.Tag = "1200";
        this.cmdRepeat.Text = "Repeat Orders";
        this.cmdRepeat.UseVisualStyleBackColor = false;
        this.cmdRepeat.Click += this.cmdRepeat_Click;
        this.txtRepeatMultiple.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtRepeatMultiple.BorderStyle = BorderStyle.None;
        this.txtRepeatMultiple.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtRepeatMultiple.Location = new Point(480, 10);
        this.txtRepeatMultiple.Margin = new Padding(0, 10, 3, 3);
        this.txtRepeatMultiple.Name = "txtRepeatMultiple";
        this.txtRepeatMultiple.Size = new Size(40, 13);
        this.txtRepeatMultiple.TabIndex = 147;
        this.txtRepeatMultiple.Text = "1";
        this.txtRepeatMultiple.TextAlign = HorizontalAlignment.Center;
        this.cmdSaveTemplate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSaveTemplate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSaveTemplate.Location = new Point(523, 0);
        this.cmdSaveTemplate.Margin = new Padding(0);
        this.cmdSaveTemplate.Name = "cmdSaveTemplate";
        this.cmdSaveTemplate.Size = new Size(96 /*0x60*/, 30);
        this.cmdSaveTemplate.TabIndex = 145;
        this.cmdSaveTemplate.Tag = "1200";
        this.cmdSaveTemplate.Text = "Create Template";
        this.cmdSaveTemplate.UseVisualStyleBackColor = false;
        this.cmdSaveTemplate.Click += this.cmdSaveTemplate_Click;
        this.cmdDeleteTemplate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteTemplate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteTemplate.Location = new Point(619, 0);
        this.cmdDeleteTemplate.Margin = new Padding(0);
        this.cmdDeleteTemplate.Name = "cmdDeleteTemplate";
        this.cmdDeleteTemplate.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteTemplate.TabIndex = 146;
        this.cmdDeleteTemplate.Tag = "1200";
        this.cmdDeleteTemplate.Text = "Delete Template";
        this.cmdDeleteTemplate.UseVisualStyleBackColor = false;
        this.cmdDeleteTemplate.Click += this.cmdDeleteTemplate_Click;
        this.cmdCreateFleetWaypoint.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreateFleetWaypoint.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreateFleetWaypoint.Location = new Point(715, 0);
        this.cmdCreateFleetWaypoint.Margin = new Padding(0);
        this.cmdCreateFleetWaypoint.Name = "cmdCreateFleetWaypoint";
        this.cmdCreateFleetWaypoint.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreateFleetWaypoint.TabIndex = 149;
        this.cmdCreateFleetWaypoint.Tag = "1200";
        this.cmdCreateFleetWaypoint.Text = "Create Fleet WP";
        this.cmdCreateFleetWaypoint.UseVisualStyleBackColor = false;
        this.cmdCreateFleetWaypoint.Click += this.cmdCreateFleetWaypoint_Click;
        this.chkDefaultActions.AutoSize = true;
        this.chkDefaultActions.Checked = true;
        this.chkDefaultActions.CheckState = CheckState.Checked;
        this.chkDefaultActions.Location = new Point(835, 8);
        this.chkDefaultActions.Margin = new Padding(24, 8, 3, 3);
        this.chkDefaultActions.Name = "chkDefaultActions";
        this.chkDefaultActions.Padding = new Padding(5, 0, 0, 0);
        this.chkDefaultActions.Size = new Size(103, 17);
        this.chkDefaultActions.TabIndex = 148;
        this.chkDefaultActions.Text = "Default Actions";
        this.chkDefaultActions.TextAlign = ContentAlignment.MiddleRight;
        this.chkDefaultActions.UseVisualStyleBackColor = true;
        this.lstvLoadItems.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvLoadItems.BorderStyle = BorderStyle.FixedSingle;
        this.lstvLoadItems.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_18,
            this.columnHeader_19
        });
        this.lstvLoadItems.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvLoadItems.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvLoadItems.HideSelection = false;
        this.lstvLoadItems.Location = new Point(555, 81);
        this.lstvLoadItems.Name = "lstvLoadItems";
        this.lstvLoadItems.Size = new Size(459, 500);
        this.lstvLoadItems.TabIndex = 51;
        this.lstvLoadItems.UseCompatibleStateImageBehavior = false;
        this.lstvLoadItems.View = View.Details;
        this.lstvLoadItems.Visible = false;
        this.lstvLoadItems.SelectedIndexChanged += this.lstvLoadItems_SelectedIndexChanged;
        this.lstvLoadItems.DoubleClick += this.lstvLoadItems_DoubleClick;
        this.columnHeader_18.Width = 360;
        this.columnHeader_19.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_19.Width = 75;
        this.lstvOrders.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvOrders.BorderStyle = BorderStyle.FixedSingle;
        this.lstvOrders.Columns.AddRange(new ColumnHeader[1]
        {
            this.columnHeader_16
        });
        this.lstvOrders.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvOrders.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvOrders.HideSelection = false;
        this.lstvOrders.Location = new Point(555, 81);
        this.lstvOrders.Name = "lstvOrders";
        this.lstvOrders.Size = new Size(459, 500);
        this.lstvOrders.TabIndex = 50;
        this.lstvOrders.UseCompatibleStateImageBehavior = false;
        this.lstvOrders.View = View.Details;
        this.columnHeader_16.Width = 435;
        this.lstvActions.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvActions.BorderStyle = BorderStyle.FixedSingle;
        this.lstvActions.Columns.AddRange(new ColumnHeader[1]
        {
            this.columnHeader_17
        });
        this.lstvActions.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvActions.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvActions.HideSelection = false;
        this.lstvActions.Location = new Point(309, 81);
        this.lstvActions.Name = "lstvActions";
        this.lstvActions.Size = new Size(240 /*0xF0*/, 500);
        this.lstvActions.TabIndex = 49;
        this.lstvActions.UseCompatibleStateImageBehavior = false;
        this.lstvActions.View = View.Details;
        this.lstvActions.SelectedIndexChanged += this.lstvActions_SelectedIndexChanged;
        this.lstvActions.DoubleClick += this.lstvActions_DoubleClick;
        this.columnHeader_17.Width = 220;
        this.lstvSystemLocations.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvSystemLocations.BorderStyle = BorderStyle.FixedSingle;
        this.lstvSystemLocations.Columns.AddRange(new ColumnHeader[1]
        {
            this.columnHeader_15
        });
        this.lstvSystemLocations.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvSystemLocations.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvSystemLocations.HideSelection = false;
        this.lstvSystemLocations.Location = new Point(4, 81);
        this.lstvSystemLocations.Name = "lstvSystemLocations";
        this.lstvSystemLocations.Size = new Size(300, 500);
        this.lstvSystemLocations.TabIndex = 48 /*0x30*/;
        this.lstvSystemLocations.UseCompatibleStateImageBehavior = false;
        this.lstvSystemLocations.View = View.Details;
        this.lstvSystemLocations.SelectedIndexChanged += this.lstvSystemLocations_SelectedIndexChanged;
        this.lstvSystemLocations.DoubleClick += this.lstvSystemLocations_DoubleClick;
        this.columnHeader_15.Width = 280;
        this.flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel3.Controls.Add(this.chkAutoLP);
        this.flowLayoutPanel3.Controls.Add(this.chkAssumeJumpCapable);
        this.flowLayoutPanel3.Controls.Add(this.chkCycle);
        this.flowLayoutPanel3.Controls.Add(this.chkDanger);
        this.flowLayoutPanel3.Controls.Add(this.chkExcludeAlien);
        this.flowLayoutPanel3.Controls.Add(this.chkMaxSpeed);
        this.flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel3.Location = new Point(648, 3);
        this.flowLayoutPanel3.Name = "flowLayoutPanel3";
        this.flowLayoutPanel3.Size = new Size(366, 72);
        this.flowLayoutPanel3.TabIndex = 4;
        this.chkAutoLP.AutoSize = true;
        this.chkAutoLP.Checked = true;
        this.chkAutoLP.CheckState = CheckState.Checked;
        this.chkAutoLP.Location = new Point(3, 3);
        this.chkAutoLP.Name = "chkAutoLP";
        this.chkAutoLP.Padding = new Padding(5, 0, 0, 0);
        this.chkAutoLP.Size = new Size(170, 17);
        this.chkAutoLP.TabIndex = 47;
        this.chkAutoLP.Text = "Auto-include Lagrange Points";
        this.chkAutoLP.TextAlign = ContentAlignment.MiddleRight;
        this.chkAutoLP.UseVisualStyleBackColor = true;
        this.chkAutoLP.CheckedChanged += this.chkAutoLP_CheckedChanged;
        this.chkAssumeJumpCapable.AutoSize = true;
        this.chkAssumeJumpCapable.Location = new Point(3, 26);
        this.chkAssumeJumpCapable.Name = "chkAssumeJumpCapable";
        this.chkAssumeJumpCapable.Padding = new Padding(5, 0, 0, 0);
        this.chkAssumeJumpCapable.Size = new Size(174, 17);
        this.chkAssumeJumpCapable.TabIndex = 48 /*0x30*/;
        this.chkAssumeJumpCapable.Text = "Assume Fleet is Jump-Capable";
        this.chkAssumeJumpCapable.TextAlign = ContentAlignment.MiddleRight;
        this.chkAssumeJumpCapable.UseVisualStyleBackColor = true;
        this.chkAssumeJumpCapable.CheckedChanged += this.chkAssumeJumpCapable_CheckedChanged;
        this.chkCycle.AutoSize = true;
        this.chkCycle.Location = new Point(3, 49);
        this.chkCycle.Name = "chkCycle";
        this.chkCycle.Padding = new Padding(5, 0, 0, 0);
        this.chkCycle.Size = new Size(92, 17);
        this.chkCycle.TabIndex = 47;
        this.chkCycle.Text = "Cycle Moves";
        this.chkCycle.TextAlign = ContentAlignment.MiddleRight;
        this.chkCycle.UseVisualStyleBackColor = true;
        this.chkCycle.CheckedChanged += this.chkCycle_CheckedChanged;
        this.chkDanger.AutoSize = true;
        this.chkDanger.Checked = true;
        this.chkDanger.CheckState = CheckState.Checked;
        this.chkDanger.Location = new Point(183, 3);
        this.chkDanger.Name = "chkDanger";
        this.chkDanger.Padding = new Padding(5, 0, 0, 0);
        this.chkDanger.Size = new Size(134, 17);
        this.chkDanger.TabIndex = 49;
        this.chkDanger.Text = "Check Danger Rating";
        this.chkDanger.TextAlign = ContentAlignment.MiddleRight;
        this.chkDanger.UseVisualStyleBackColor = true;
        this.chkDanger.CheckedChanged += this.chkDanger_CheckedChanged;
        this.chkExcludeAlien.AutoSize = true;
        this.chkExcludeAlien.Checked = true;
        this.chkExcludeAlien.CheckState = CheckState.Checked;
        this.chkExcludeAlien.Location = new Point(183, 26);
        this.chkExcludeAlien.Name = "chkExcludeAlien";
        this.chkExcludeAlien.Padding = new Padding(5, 0, 0, 0);
        this.chkExcludeAlien.Size = new Size(145, 17);
        this.chkExcludeAlien.TabIndex = 50;
        this.chkExcludeAlien.Text = "Exclude Alien-Controlled";
        this.chkExcludeAlien.TextAlign = ContentAlignment.MiddleRight;
        this.chkExcludeAlien.UseVisualStyleBackColor = true;
        this.chkExcludeAlien.CheckedChanged += this.chkExcludeAlien_CheckedChanged;
        this.chkMaxSpeed.AutoSize = true;
        this.chkMaxSpeed.Location = new Point(183, 49);
        this.chkMaxSpeed.Name = "chkMaxSpeed";
        this.chkMaxSpeed.Padding = new Padding(5, 0, 0, 0);
        this.chkMaxSpeed.Size = new Size(131, 17);
        this.chkMaxSpeed.TabIndex = 51;
        this.chkMaxSpeed.Text = "Use Maximum Speed";
        this.chkMaxSpeed.TextAlign = ContentAlignment.MiddleRight;
        this.chkMaxSpeed.UseVisualStyleBackColor = true;
        this.chkMaxSpeed.CheckedChanged += this.chkMaxSpeed_CheckedChanged;
        this.flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel2.Controls.Add(this.rdoSL);
        this.flowLayoutPanel2.Controls.Add(this.rdoARSystem);
        this.flowLayoutPanel2.Controls.Add(this.rdoOrderTemplates);
        this.flowLayoutPanel2.Location = new Point(3, 3);
        this.flowLayoutPanel2.Name = "flowLayoutPanel2";
        this.flowLayoutPanel2.Size = new Size(143, 72);
        this.flowLayoutPanel2.TabIndex = 3;
        this.rdoSL.AutoSize = true;
        this.rdoSL.Checked = true;
        this.rdoSL.Location = new Point(3, 3);
        this.rdoSL.Name = "rdoSL";
        this.rdoSL.Size = new Size(108, 17);
        this.rdoSL.TabIndex = 0;
        this.rdoSL.TabStop = true;
        this.rdoSL.Text = "System Locations";
        this.rdoSL.UseVisualStyleBackColor = true;
        this.rdoSL.CheckedChanged += this.rdoOrderTemplates_CheckedChanged;
        this.rdoARSystem.AutoSize = true;
        this.rdoARSystem.Location = new Point(3, 26);
        this.rdoARSystem.Name = "rdoARSystem";
        this.rdoARSystem.Size = new Size(122, 17);
        this.rdoARSystem.TabIndex = 1;
        this.rdoARSystem.Text = "Autoroute by System";
        this.rdoARSystem.UseVisualStyleBackColor = true;
        this.rdoARSystem.CheckedChanged += this.rdoOrderTemplates_CheckedChanged;
        this.rdoOrderTemplates.AutoSize = true;
        this.rdoOrderTemplates.Location = new Point(3, 49);
        this.rdoOrderTemplates.Name = "rdoOrderTemplates";
        this.rdoOrderTemplates.Size = new Size(103, 17);
        this.rdoOrderTemplates.TabIndex = 2;
        this.rdoOrderTemplates.Text = "Order Templates";
        this.rdoOrderTemplates.UseVisualStyleBackColor = true;
        this.rdoOrderTemplates.CheckedChanged += this.rdoOrderTemplates_CheckedChanged;
        this.flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel1.Controls.Add(this.chkPlanet);
        this.flowLayoutPanel1.Controls.Add(this.chkDwarf);
        this.flowLayoutPanel1.Controls.Add(this.chkMoon);
        this.flowLayoutPanel1.Controls.Add(this.chkComets);
        this.flowLayoutPanel1.Controls.Add(this.chkAst);
        this.flowLayoutPanel1.Controls.Add(this.chkFleets);
        this.flowLayoutPanel1.Controls.Add(this.chkContacts);
        this.flowLayoutPanel1.Controls.Add(this.chkExcludeTP);
        this.flowLayoutPanel1.Controls.Add(this.chkCivilian);
        this.flowLayoutPanel1.Controls.Add(this.chkLifepods);
        this.flowLayoutPanel1.Controls.Add(this.chkWrecks);
        this.flowLayoutPanel1.Controls.Add(this.chkWaypoint);
        this.flowLayoutPanel1.Controls.Add(this.chkLocation);
        this.flowLayoutPanel1.Controls.Add(this.chkExcSurveyed);
        this.flowLayoutPanel1.Controls.Add(this.chkFilterOrders);
        this.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel1.Location = new Point(152, 3);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(490, 72);
        this.flowLayoutPanel1.TabIndex = 2;
        this.chkPlanet.AutoSize = true;
        this.chkPlanet.Checked = true;
        this.chkPlanet.CheckState = CheckState.Checked;
        this.chkPlanet.Location = new Point(3, 3);
        this.chkPlanet.Name = "chkPlanet";
        this.chkPlanet.Padding = new Padding(5, 0, 0, 0);
        this.chkPlanet.Size = new Size(66, 17);
        this.chkPlanet.TabIndex = 54;
        this.chkPlanet.Text = "Planets";
        this.chkPlanet.TextAlign = ContentAlignment.MiddleRight;
        this.chkPlanet.UseVisualStyleBackColor = true;
        this.chkPlanet.CheckedChanged += this.chkFilterOrders_CheckedChanged;
        this.chkDwarf.AutoSize = true;
        this.chkDwarf.Checked = true;
        this.chkDwarf.CheckState = CheckState.Checked;
        this.chkDwarf.Location = new Point(3, 26);
        this.chkDwarf.Name = "chkDwarf";
        this.chkDwarf.Padding = new Padding(5, 0, 0, 0);
        this.chkDwarf.Size = new Size(97, 17);
        this.chkDwarf.TabIndex = 53;
        this.chkDwarf.Text = "Dwarf Planets";
        this.chkDwarf.TextAlign = ContentAlignment.MiddleRight;
        this.chkDwarf.UseVisualStyleBackColor = true;
        this.chkDwarf.CheckedChanged += this.chkFilterOrders_CheckedChanged;
        this.chkMoon.AutoSize = true;
        this.chkMoon.Location = new Point(3, 49);
        this.chkMoon.Name = "chkMoon";
        this.chkMoon.Padding = new Padding(5, 0, 0, 0);
        this.chkMoon.Size = new Size(63 /*0x3F*/, 17);
        this.chkMoon.TabIndex = 36;
        this.chkMoon.Text = "Moons";
        this.chkMoon.TextAlign = ContentAlignment.MiddleRight;
        this.chkMoon.UseVisualStyleBackColor = true;
        this.chkMoon.CheckedChanged += this.chkFilterOrders_CheckedChanged;
        this.chkComets.AutoSize = true;
        this.chkComets.Location = new Point(106, 3);
        this.chkComets.Name = "chkComets";
        this.chkComets.Padding = new Padding(5, 0, 0, 0);
        this.chkComets.Size = new Size(66, 17);
        this.chkComets.TabIndex = 41;
        this.chkComets.Text = "Comets";
        this.chkComets.TextAlign = ContentAlignment.MiddleRight;
        this.chkComets.UseVisualStyleBackColor = true;
        this.chkComets.CheckedChanged += this.chkFilterOrders_CheckedChanged;
        this.chkAst.AutoSize = true;
        this.chkAst.Location = new Point(106, 26);
        this.chkAst.Name = "chkAst";
        this.chkAst.Padding = new Padding(5, 0, 0, 0);
        this.chkAst.Size = new Size(74, 17);
        this.chkAst.TabIndex = 37;
        this.chkAst.Text = "Asteroids";
        this.chkAst.TextAlign = ContentAlignment.MiddleRight;
        this.chkAst.UseVisualStyleBackColor = true;
        this.chkAst.CheckedChanged += this.chkFilterOrders_CheckedChanged;
        this.chkFleets.AutoSize = true;
        this.chkFleets.Location = new Point(106, 49);
        this.chkFleets.Name = "chkFleets";
        this.chkFleets.Padding = new Padding(5, 0, 0, 0);
        this.chkFleets.Size = new Size(59, 17);
        this.chkFleets.TabIndex = 40;
        this.chkFleets.Text = "Fleets";
        this.chkFleets.TextAlign = ContentAlignment.MiddleRight;
        this.chkFleets.UseVisualStyleBackColor = true;
        this.chkFleets.CheckedChanged += this.chkFilterOrders_CheckedChanged;
        this.chkContacts.AutoSize = true;
        this.chkContacts.Location = new Point(186, 3);
        this.chkContacts.Name = "chkContacts";
        this.chkContacts.Padding = new Padding(5, 0, 0, 0);
        this.chkContacts.Size = new Size(73, 17);
        this.chkContacts.TabIndex = 38;
        this.chkContacts.Text = "Contacts";
        this.chkContacts.TextAlign = ContentAlignment.MiddleRight;
        this.chkContacts.UseVisualStyleBackColor = true;
        this.chkContacts.CheckedChanged += this.chkFilterOrders_CheckedChanged;
        this.chkExcludeTP.AutoSize = true;
        this.chkExcludeTP.Checked = true;
        this.chkExcludeTP.CheckState = CheckState.Checked;
        this.chkExcludeTP.Location = new Point(186, 26);
        this.chkExcludeTP.Name = "chkExcludeTP";
        this.chkExcludeTP.Padding = new Padding(5, 0, 0, 0);
        this.chkExcludeTP.Size = new Size(86, 17);
        this.chkExcludeTP.TabIndex = 52;
        this.chkExcludeTP.Text = "Exclude TP";
        this.chkExcludeTP.TextAlign = ContentAlignment.MiddleRight;
        this.chkExcludeTP.UseVisualStyleBackColor = true;
        this.chkExcludeTP.CheckedChanged += this.chkFilterOrders_CheckedChanged;
        this.chkCivilian.AutoSize = true;
        this.chkCivilian.Location = new Point(186, 49);
        this.chkCivilian.Name = "chkCivilian";
        this.chkCivilian.Padding = new Padding(5, 0, 0, 0);
        this.chkCivilian.Size = new Size(69, 17);
        this.chkCivilian.TabIndex = 51;
        this.chkCivilian.Text = "Civilians";
        this.chkCivilian.TextAlign = ContentAlignment.MiddleRight;
        this.chkCivilian.UseVisualStyleBackColor = true;
        this.chkCivilian.CheckedChanged += this.chkFilterOrders_CheckedChanged;
        this.chkLifepods.AutoSize = true;
        this.chkLifepods.Location = new Point(278, 3);
        this.chkLifepods.Name = "chkLifepods";
        this.chkLifepods.Padding = new Padding(5, 0, 0, 0);
        this.chkLifepods.Size = new Size(71, 17);
        this.chkLifepods.TabIndex = 42;
        this.chkLifepods.Text = "Lifepods";
        this.chkLifepods.TextAlign = ContentAlignment.MiddleRight;
        this.chkLifepods.UseVisualStyleBackColor = true;
        this.chkLifepods.CheckedChanged += this.chkFilterOrders_CheckedChanged;
        this.chkWrecks.AutoSize = true;
        this.chkWrecks.Location = new Point(278, 26);
        this.chkWrecks.Name = "chkWrecks";
        this.chkWrecks.Padding = new Padding(5, 0, 0, 0);
        this.chkWrecks.Size = new Size(68, 17);
        this.chkWrecks.TabIndex = 43;
        this.chkWrecks.Text = "Wrecks";
        this.chkWrecks.TextAlign = ContentAlignment.MiddleRight;
        this.chkWrecks.UseVisualStyleBackColor = true;
        this.chkWrecks.CheckedChanged += this.chkFilterOrders_CheckedChanged;
        this.chkWaypoint.AutoSize = true;
        this.chkWaypoint.Location = new Point(278, 49);
        this.chkWaypoint.Name = "chkWaypoint";
        this.chkWaypoint.Padding = new Padding(5, 0, 0, 0);
        this.chkWaypoint.Size = new Size(81, 17);
        this.chkWaypoint.TabIndex = 39;
        this.chkWaypoint.Text = "Waypoints";
        this.chkWaypoint.TextAlign = ContentAlignment.MiddleRight;
        this.chkWaypoint.UseVisualStyleBackColor = true;
        this.chkWaypoint.CheckedChanged += this.chkFilterOrders_CheckedChanged;
        this.chkLocation.AutoSize = true;
        this.chkLocation.Location = new Point(365, 3);
        this.chkLocation.Name = "chkLocation";
        this.chkLocation.Padding = new Padding(5, 0, 0, 0);
        this.chkLocation.Size = new Size(113, 17);
        this.chkLocation.TabIndex = 44;
        this.chkLocation.Text = "Survey Locations";
        this.chkLocation.TextAlign = ContentAlignment.MiddleRight;
        this.chkLocation.UseVisualStyleBackColor = true;
        this.chkLocation.CheckedChanged += this.chkFilterOrders_CheckedChanged;
        this.chkExcSurveyed.AutoSize = true;
        this.chkExcSurveyed.Location = new Point(365, 26);
        this.chkExcSurveyed.Name = "chkExcSurveyed";
        this.chkExcSurveyed.Padding = new Padding(5, 0, 0, 0);
        this.chkExcSurveyed.Size = new Size(117, 17);
        this.chkExcSurveyed.TabIndex = 45;
        this.chkExcSurveyed.Text = "Exclude Surveyed";
        this.chkExcSurveyed.TextAlign = ContentAlignment.MiddleRight;
        this.chkExcSurveyed.UseVisualStyleBackColor = true;
        this.chkExcSurveyed.CheckedChanged += this.chkFilterOrders_CheckedChanged;
        this.chkFilterOrders.AutoSize = true;
        this.chkFilterOrders.Checked = true;
        this.chkFilterOrders.CheckState = CheckState.Checked;
        this.chkFilterOrders.Location = new Point(365, 49);
        this.chkFilterOrders.Name = "chkFilterOrders";
        this.chkFilterOrders.Padding = new Padding(5, 0, 0, 0);
        this.chkFilterOrders.Size = new Size(96 /*0x60*/, 17);
        this.chkFilterOrders.TabIndex = 46;
        this.chkFilterOrders.Text = "Order Filtering";
        this.chkFilterOrders.TextAlign = ContentAlignment.MiddleRight;
        this.chkFilterOrders.UseVisualStyleBackColor = true;
        this.chkFilterOrders.CheckedChanged += this.chkFilterOrders_CheckedChanged;
        this.tabStandingOrders.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabStandingOrders.Controls.Add(this.flowLayoutPanel29);
        this.tabStandingOrders.Controls.Add(this.chkSetFWP);
        this.tabStandingOrders.Controls.Add(this.cmdDeleteAll);
        this.tabStandingOrders.Controls.Add(this.cmdDeleteSOTemplate);
        this.tabStandingOrders.Controls.Add(this.cmdLoadTemplate);
        this.tabStandingOrders.Controls.Add(this.cmdCreateTemplate);
        this.tabStandingOrders.Controls.Add(this.lstvStandingOrderTemplates);
        this.tabStandingOrders.Controls.Add(this.tvStandingOrders);
        this.tabStandingOrders.Controls.Add(this.cmdAddCO);
        this.tabStandingOrders.Controls.Add(this.cmdOrderDown);
        this.tabStandingOrders.Controls.Add(this.cmdOrderUp);
        this.tabStandingOrders.Controls.Add(this.cmdDeleteSO);
        this.tabStandingOrders.Controls.Add(this.cmdAddSO);
        this.tabStandingOrders.Controls.Add(this.lstvStandingOrdersList);
        this.tabStandingOrders.Controls.Add(this.lstvConditionOne);
        this.tabStandingOrders.Location = new Point(4, 22);
        this.tabStandingOrders.Name = "tabStandingOrders";
        this.tabStandingOrders.Padding = new Padding(3);
        this.tabStandingOrders.Size = new Size(1020, 653);
        this.tabStandingOrders.TabIndex = 4;
        this.tabStandingOrders.Text = "Standing Orders";
        this.flowLayoutPanel29.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel29.Controls.Add(this.chkDetachedStanding);
        this.flowLayoutPanel29.Controls.Add(this.chkDetachedConditional);
        this.flowLayoutPanel29.Controls.Add(this.chkIncludeSquadrons);
        this.flowLayoutPanel29.Controls.Add(this.chkIgnoreSO);
        this.flowLayoutPanel29.Controls.Add(this.chkIgnoreCO);
        this.flowLayoutPanel29.Location = new Point(531, 563);
        this.flowLayoutPanel29.Name = "flowLayoutPanel29";
        this.flowLayoutPanel29.Size = new Size(485, 51);
        this.flowLayoutPanel29.TabIndex = 151;
        this.chkDetachedStanding.AutoSize = true;
        this.chkDetachedStanding.Location = new Point(3, 3);
        this.chkDetachedStanding.Name = "chkDetachedStanding";
        this.chkDetachedStanding.Size = new Size(148, 17);
        this.chkDetachedStanding.TabIndex = 151;
        this.chkDetachedStanding.Text = "Copy Standing on Detach";
        this.chkDetachedStanding.UseVisualStyleBackColor = true;
        this.chkDetachedStanding.CheckedChanged += this.chkDetachedStanding_CheckedChanged;
        this.chkDetachedConditional.AutoSize = true;
        this.chkDetachedConditional.Location = new Point(157, 3);
        this.chkDetachedConditional.Name = "chkDetachedConditional";
        this.chkDetachedConditional.Size = new Size(158, 17);
        this.chkDetachedConditional.TabIndex = 152;
        this.chkDetachedConditional.Text = "Copy Conditional on Detach";
        this.chkDetachedConditional.UseVisualStyleBackColor = true;
        this.chkDetachedConditional.CheckedChanged += this.chkDetachedConditional_CheckedChanged;
        this.chkIncludeSquadrons.AutoSize = true;
        this.chkIncludeSquadrons.Location = new Point(321, 3);
        this.chkIncludeSquadrons.Name = "chkIncludeSquadrons";
        this.chkIncludeSquadrons.Size = new Size(115, 17);
        this.chkIncludeSquadrons.TabIndex = 153;
        this.chkIncludeSquadrons.Text = "Include Squadrons";
        this.chkIncludeSquadrons.UseVisualStyleBackColor = true;
        this.chkIncludeSquadrons.CheckedChanged += this.chkIncludeSquadrons_CheckedChanged;
        this.chkIgnoreSO.AutoSize = true;
        this.chkIgnoreSO.Location = new Point(3, 26);
        this.chkIgnoreSO.Name = "chkIgnoreSO";
        this.chkIgnoreSO.Size = new Size(135, 17);
        this.chkIgnoreSO.TabIndex = 154;
        this.chkIgnoreSO.Text = "Ignore Standing Orders";
        this.chkIgnoreSO.UseVisualStyleBackColor = true;
        this.chkIgnoreSO.CheckedChanged += this.chkIgnoreSO_CheckedChanged;
        this.chkIgnoreCO.AutoSize = true;
        this.chkIgnoreCO.Location = new Point(157, 26);
        this.chkIgnoreCO.Margin = new Padding(16 /*0x10*/, 3, 3, 3);
        this.chkIgnoreCO.Name = "chkIgnoreCO";
        this.chkIgnoreCO.Size = new Size(145, 17);
        this.chkIgnoreCO.TabIndex = 155;
        this.chkIgnoreCO.Text = "Ignore Conditional Orders";
        this.chkIgnoreCO.UseVisualStyleBackColor = true;
        this.chkIgnoreCO.CheckedChanged += this.chkIgnoreCO_CheckedChanged;
        this.chkSetFWP.AutoSize = true;
        this.chkSetFWP.Location = new Point(198, 625);
        this.chkSetFWP.Name = "chkSetFWP";
        this.chkSetFWP.Size = new Size(69, 17);
        this.chkSetFWP.TabIndex = 150;
        this.chkSetFWP.Text = "Set FWP";
        this.chkSetFWP.UseVisualStyleBackColor = true;
        this.cmdDeleteAll.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteAll.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteAll.Location = new Point(921, 617);
        this.cmdDeleteAll.Margin = new Padding(0);
        this.cmdDeleteAll.Name = "cmdDeleteAll";
        this.cmdDeleteAll.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteAll.TabIndex = 149;
        this.cmdDeleteAll.Tag = "1200";
        this.cmdDeleteAll.Text = "Delete All";
        this.cmdDeleteAll.UseVisualStyleBackColor = false;
        this.cmdDeleteAll.Click += this.cmdDeleteAll_Click;
        this.cmdDeleteSOTemplate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteSOTemplate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteSOTemplate.Location = new Point(459, 617);
        this.cmdDeleteSOTemplate.Margin = new Padding(0);
        this.cmdDeleteSOTemplate.Name = "cmdDeleteSOTemplate";
        this.cmdDeleteSOTemplate.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteSOTemplate.TabIndex = 148;
        this.cmdDeleteSOTemplate.Tag = "1200";
        this.cmdDeleteSOTemplate.Text = "Delete Template";
        this.cmdDeleteSOTemplate.UseVisualStyleBackColor = false;
        this.cmdDeleteSOTemplate.Click += this.cmdDeleteSOTemplate_Click;
        this.cmdLoadTemplate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdLoadTemplate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdLoadTemplate.Location = new Point(363, 617);
        this.cmdLoadTemplate.Margin = new Padding(0);
        this.cmdLoadTemplate.Name = "cmdLoadTemplate";
        this.cmdLoadTemplate.Size = new Size(96 /*0x60*/, 30);
        this.cmdLoadTemplate.TabIndex = 147;
        this.cmdLoadTemplate.Tag = "1200";
        this.cmdLoadTemplate.Text = "Load Template";
        this.cmdLoadTemplate.UseVisualStyleBackColor = false;
        this.cmdLoadTemplate.Click += this.cmdLoadTemplate_Click;
        this.cmdCreateTemplate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreateTemplate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreateTemplate.Location = new Point(267, 617);
        this.cmdCreateTemplate.Margin = new Padding(0);
        this.cmdCreateTemplate.Name = "cmdCreateTemplate";
        this.cmdCreateTemplate.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreateTemplate.TabIndex = 146;
        this.cmdCreateTemplate.Tag = "1200";
        this.cmdCreateTemplate.Text = "Create Template";
        this.cmdCreateTemplate.UseVisualStyleBackColor = false;
        this.cmdCreateTemplate.Click += this.cmdCreateTemplate_Click;
        this.lstvStandingOrderTemplates.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvStandingOrderTemplates.BorderStyle = BorderStyle.FixedSingle;
        this.lstvStandingOrderTemplates.Columns.AddRange(new ColumnHeader[1]
        {
            this.columnHeader_142
        });
        this.lstvStandingOrderTemplates.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvStandingOrderTemplates.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvStandingOrderTemplates.HideSelection = false;
        this.lstvStandingOrderTemplates.Location = new Point(267, 393);
        this.lstvStandingOrderTemplates.Name = "lstvStandingOrderTemplates";
        this.lstvStandingOrderTemplates.Size = new Size(260, 221);
        this.lstvStandingOrderTemplates.TabIndex = 145;
        this.lstvStandingOrderTemplates.UseCompatibleStateImageBehavior = false;
        this.lstvStandingOrderTemplates.View = View.Details;
        this.columnHeader_142.Width = 235;
        this.tvStandingOrders.AllowDrop = true;
        this.tvStandingOrders.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvStandingOrders.BorderStyle = BorderStyle.FixedSingle;
        this.tvStandingOrders.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvStandingOrders.HideSelection = false;
        this.tvStandingOrders.Location = new Point(3, 4);
        this.tvStandingOrders.Margin = new Padding(3, 0, 0, 3);
        this.tvStandingOrders.Name = "tvStandingOrders";
        this.tvStandingOrders.Size = new Size(260, 610);
        this.tvStandingOrders.TabIndex = 144 /*0x90*/;
        this.cmdAddCO.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddCO.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAddCO.Location = new Point(98, 617);
        this.cmdAddCO.Margin = new Padding(0);
        this.cmdAddCO.Name = "cmdAddCO";
        this.cmdAddCO.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddCO.TabIndex = 143;
        this.cmdAddCO.Tag = "1200";
        this.cmdAddCO.Text = "Add Conditional";
        this.cmdAddCO.UseVisualStyleBackColor = false;
        this.cmdAddCO.Click += this.cmdAddCO_Click;
        this.cmdOrderDown.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdOrderDown.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdOrderDown.Location = new Point(729, 617);
        this.cmdOrderDown.Margin = new Padding(0);
        this.cmdOrderDown.Name = "cmdOrderDown";
        this.cmdOrderDown.Size = new Size(96 /*0x60*/, 30);
        this.cmdOrderDown.TabIndex = 141;
        this.cmdOrderDown.Tag = "1200";
        this.cmdOrderDown.Text = "Move Down";
        this.cmdOrderDown.UseVisualStyleBackColor = false;
        this.cmdOrderDown.Click += this.cmdOrderDown_Click;
        this.cmdOrderUp.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdOrderUp.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdOrderUp.Location = new Point(633, 617);
        this.cmdOrderUp.Margin = new Padding(0);
        this.cmdOrderUp.Name = "cmdOrderUp";
        this.cmdOrderUp.Size = new Size(96 /*0x60*/, 30);
        this.cmdOrderUp.TabIndex = 140;
        this.cmdOrderUp.Tag = "1200";
        this.cmdOrderUp.Text = "Move Up";
        this.cmdOrderUp.UseVisualStyleBackColor = false;
        this.cmdOrderUp.Click += this.cmdOrderUp_Click;
        this.cmdDeleteSO.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteSO.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteSO.Location = new Point(825, 617);
        this.cmdDeleteSO.Margin = new Padding(0);
        this.cmdDeleteSO.Name = "cmdDeleteSO";
        this.cmdDeleteSO.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteSO.TabIndex = 139;
        this.cmdDeleteSO.Tag = "1200";
        this.cmdDeleteSO.Text = "Delete Order";
        this.cmdDeleteSO.UseVisualStyleBackColor = false;
        this.cmdDeleteSO.Click += this.cmdDeleteSO_Click;
        this.cmdAddSO.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddSO.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAddSO.Location = new Point(2, 617);
        this.cmdAddSO.Margin = new Padding(0);
        this.cmdAddSO.Name = "cmdAddSO";
        this.cmdAddSO.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddSO.TabIndex = 138;
        this.cmdAddSO.Tag = "1200";
        this.cmdAddSO.Text = "Add Standing";
        this.cmdAddSO.UseVisualStyleBackColor = false;
        this.cmdAddSO.Click += this.cmdAddSO_Click;
        this.lstvStandingOrdersList.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvStandingOrdersList.BorderStyle = BorderStyle.FixedSingle;
        this.lstvStandingOrdersList.Columns.AddRange(new ColumnHeader[4]
        {
            this.columnHeader_139,
            this.columnHeader_140,
            this.columnHeader_141,
            this.columnHeader_143
        });
        this.lstvStandingOrdersList.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvStandingOrdersList.FullRowSelect = true;
        this.lstvStandingOrdersList.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvStandingOrdersList.HideSelection = false;
        this.lstvStandingOrdersList.Location = new Point(531, 4);
        this.lstvStandingOrdersList.Name = "lstvStandingOrdersList";
        this.lstvStandingOrdersList.Size = new Size(485, 553);
        this.lstvStandingOrdersList.TabIndex = 60;
        this.lstvStandingOrdersList.UseCompatibleStateImageBehavior = false;
        this.lstvStandingOrdersList.View = View.Details;
        this.columnHeader_139.Width = 30;
        this.columnHeader_140.Width = 200;
        this.columnHeader_141.Width = 200;
        this.columnHeader_143.Width = 30;
        this.lstvConditionOne.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvConditionOne.BorderStyle = BorderStyle.FixedSingle;
        this.lstvConditionOne.Columns.AddRange(new ColumnHeader[1]
        {
            this.columnHeader_57
        });
        this.lstvConditionOne.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvConditionOne.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvConditionOne.HideSelection = false;
        this.lstvConditionOne.Location = new Point(267, 4);
        this.lstvConditionOne.Name = "lstvConditionOne";
        this.lstvConditionOne.Size = new Size(260, 383);
        this.lstvConditionOne.TabIndex = 54;
        this.lstvConditionOne.UseCompatibleStateImageBehavior = false;
        this.lstvConditionOne.View = View.Details;
        this.lstvConditionOne.SelectedIndexChanged += this.lstvConditionOne_SelectedIndexChanged;
        this.columnHeader_57.Width = 235;
        this.tabFormation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabFormation.Controls.Add(this.flowLayoutPanel20);
        this.tabFormation.Controls.Add(this.tvAnchor);
        this.tabFormation.Controls.Add(this.flowLayoutPanel23);
        this.tabFormation.Controls.Add(this.lstvFormation);
        this.tabFormation.Controls.Add(this.tvThreat);
        this.tabFormation.Location = new Point(4, 22);
        this.tabFormation.Name = "tabFormation";
        this.tabFormation.Padding = new Padding(3);
        this.tabFormation.Size = new Size(1020, 653);
        this.tabFormation.TabIndex = 6;
        this.tabFormation.Text = "Formation Orders";
        this.flowLayoutPanel20.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel20.Controls.Add(this.chkCurrentContact);
        this.flowLayoutPanel20.Controls.Add(this.chkCurrentSystem);
        this.flowLayoutPanel20.Location = new Point(4, 238);
        this.flowLayoutPanel20.Name = "flowLayoutPanel20";
        this.flowLayoutPanel20.Size = new Size(321, 31 /*0x1F*/);
        this.flowLayoutPanel20.TabIndex = 189;
        this.chkCurrentContact.AutoSize = true;
        this.chkCurrentContact.Checked = true;
        this.chkCurrentContact.CheckState = CheckState.Checked;
        this.chkCurrentContact.Location = new Point(6, 6);
        this.chkCurrentContact.Margin = new Padding(6);
        this.chkCurrentContact.Name = "chkCurrentContact";
        this.chkCurrentContact.Padding = new Padding(5, 0, 0, 0);
        this.chkCurrentContact.Size = new Size(144 /*0x90*/, 17);
        this.chkCurrentContact.TabIndex = 181;
        this.chkCurrentContact.Text = "Current Contact Threats";
        this.chkCurrentContact.TextAlign = ContentAlignment.MiddleRight;
        this.chkCurrentContact.UseVisualStyleBackColor = true;
        this.chkCurrentContact.CheckedChanged += this.chkCurrentSystem_CheckedChanged;
        this.chkCurrentSystem.AutoSize = true;
        this.chkCurrentSystem.Checked = true;
        this.chkCurrentSystem.CheckState = CheckState.Checked;
        this.chkCurrentSystem.Location = new Point(162, 6);
        this.chkCurrentSystem.Margin = new Padding(6);
        this.chkCurrentSystem.Name = "chkCurrentSystem";
        this.chkCurrentSystem.Padding = new Padding(5, 0, 0, 0);
        this.chkCurrentSystem.Size = new Size(102, 17);
        this.chkCurrentSystem.TabIndex = 180;
        this.chkCurrentSystem.Text = "Current System";
        this.chkCurrentSystem.TextAlign = ContentAlignment.MiddleRight;
        this.chkCurrentSystem.UseVisualStyleBackColor = true;
        this.chkCurrentSystem.CheckedChanged += this.chkCurrentSystem_CheckedChanged;
        this.tvAnchor.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvAnchor.BorderStyle = BorderStyle.FixedSingle;
        this.tvAnchor.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvAnchor.Location = new Point(329, 6);
        this.tvAnchor.Margin = new Padding(0, 2, 0, 0);
        this.tvAnchor.Name = "tvAnchor";
        this.tvAnchor.Size = new Size(341, 641);
        this.tvAnchor.TabIndex = 188;
        this.flowLayoutPanel23.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel23.Controls.Add(this.cmdSetAnchor);
        this.flowLayoutPanel23.Controls.Add(this.cmdSetThreat);
        this.flowLayoutPanel23.Controls.Add(this.cmdClearAnchor);
        this.flowLayoutPanel23.Controls.Add(this.cmdClearThreat);
        this.flowLayoutPanel23.Controls.Add(this.cmdSetDistance);
        this.flowLayoutPanel23.Controls.Add(this.cmdSetOffset);
        this.flowLayoutPanel23.Controls.Add(this.cmdToggleWarship);
        this.flowLayoutPanel23.Controls.Add(this.cmdToggleContact);
        this.flowLayoutPanel23.Controls.Add(this.button1);
        this.flowLayoutPanel23.Location = new Point(4, 275);
        this.flowLayoutPanel23.Name = "flowLayoutPanel23";
        this.flowLayoutPanel23.Size = new Size(321, 189);
        this.flowLayoutPanel23.TabIndex = 187;
        this.cmdSetAnchor.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSetAnchor.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSetAnchor.Location = new Point(6, 6);
        this.cmdSetAnchor.Margin = new Padding(6, 6, 0, 0);
        this.cmdSetAnchor.Name = "cmdSetAnchor";
        this.cmdSetAnchor.Size = new Size(150, 30);
        this.cmdSetAnchor.TabIndex = 194;
        this.cmdSetAnchor.Tag = "1200";
        this.cmdSetAnchor.Text = "Set Anchor Fleet";
        this.cmdSetAnchor.UseVisualStyleBackColor = false;
        this.cmdSetAnchor.Click += this.cmdSetAnchor_Click;
        this.cmdSetThreat.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSetThreat.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSetThreat.Location = new Point(162, 6);
        this.cmdSetThreat.Margin = new Padding(6, 6, 0, 0);
        this.cmdSetThreat.Name = "cmdSetThreat";
        this.cmdSetThreat.Size = new Size(150, 30);
        this.cmdSetThreat.TabIndex = 195;
        this.cmdSetThreat.Tag = "1200";
        this.cmdSetThreat.Text = "Set Specific Threat";
        this.cmdSetThreat.UseVisualStyleBackColor = false;
        this.cmdSetThreat.Click += this.cmdSetThreat_Click;
        this.cmdClearAnchor.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdClearAnchor.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdClearAnchor.Location = new Point(6, 42);
        this.cmdClearAnchor.Margin = new Padding(6, 6, 0, 0);
        this.cmdClearAnchor.Name = "cmdClearAnchor";
        this.cmdClearAnchor.Size = new Size(150, 30);
        this.cmdClearAnchor.TabIndex = 186;
        this.cmdClearAnchor.Tag = "1200";
        this.cmdClearAnchor.Text = "Clear Anchor Fleet";
        this.cmdClearAnchor.UseVisualStyleBackColor = false;
        this.cmdClearAnchor.Click += this.cmdClearAnchor_Click;
        this.cmdClearThreat.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdClearThreat.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdClearThreat.Location = new Point(162, 42);
        this.cmdClearThreat.Margin = new Padding(6, 6, 0, 0);
        this.cmdClearThreat.Name = "cmdClearThreat";
        this.cmdClearThreat.Size = new Size(150, 30);
        this.cmdClearThreat.TabIndex = 187;
        this.cmdClearThreat.Tag = "1200";
        this.cmdClearThreat.Text = "Clear Specific Threat";
        this.cmdClearThreat.UseVisualStyleBackColor = false;
        this.cmdClearThreat.Click += this.cmdClearThreat_Click;
        this.cmdSetDistance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSetDistance.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSetDistance.Location = new Point(6, 78);
        this.cmdSetDistance.Margin = new Padding(6, 6, 0, 0);
        this.cmdSetDistance.Name = "cmdSetDistance";
        this.cmdSetDistance.Size = new Size(150, 30);
        this.cmdSetDistance.TabIndex = 190;
        this.cmdSetDistance.Tag = "1200";
        this.cmdSetDistance.Text = "Set Distance to Anchor";
        this.cmdSetDistance.UseVisualStyleBackColor = false;
        this.cmdSetDistance.Click += this.cmdSetDistance_Click;
        this.cmdSetOffset.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSetOffset.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSetOffset.Location = new Point(162, 78);
        this.cmdSetOffset.Margin = new Padding(6, 6, 0, 0);
        this.cmdSetOffset.Name = "cmdSetOffset";
        this.cmdSetOffset.Size = new Size(150, 30);
        this.cmdSetOffset.TabIndex = 189;
        this.cmdSetOffset.Tag = "1200";
        this.cmdSetOffset.Text = "Set Bearing Offset";
        this.cmdSetOffset.UseVisualStyleBackColor = false;
        this.cmdSetOffset.Click += this.cmdSetOffset_Click;
        this.cmdToggleWarship.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdToggleWarship.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdToggleWarship.Location = new Point(6, 114);
        this.cmdToggleWarship.Margin = new Padding(6, 6, 0, 0);
        this.cmdToggleWarship.Name = "cmdToggleWarship";
        this.cmdToggleWarship.Size = new Size(150, 30);
        this.cmdToggleWarship.TabIndex = 192 /*0xC0*/;
        this.cmdToggleWarship.Tag = "1200";
        this.cmdToggleWarship.Text = "Toggle Hostile Warship";
        this.cmdToggleWarship.UseVisualStyleBackColor = false;
        this.cmdToggleWarship.Click += this.cmdToggleWarship_Click;
        this.cmdToggleContact.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdToggleContact.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdToggleContact.Location = new Point(162, 114);
        this.cmdToggleContact.Margin = new Padding(6, 6, 0, 0);
        this.cmdToggleContact.Name = "cmdToggleContact";
        this.cmdToggleContact.Size = new Size(150, 30);
        this.cmdToggleContact.TabIndex = 191;
        this.cmdToggleContact.Tag = "1200";
        this.cmdToggleContact.Text = "Toggle Hostile Contact";
        this.cmdToggleContact.UseVisualStyleBackColor = false;
        this.cmdToggleContact.Click += this.cmdToggleContact_Click;
        this.button1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.button1.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.button1.Location = new Point(6, 150);
        this.button1.Margin = new Padding(6, 6, 0, 0);
        this.button1.Name = "button1";
        this.button1.Size = new Size(150, 30);
        this.button1.TabIndex = 193;
        this.button1.Tag = "1200";
        this.button1.Text = "Toggle Anchor Destination";
        this.button1.UseVisualStyleBackColor = false;
        this.button1.Click += this.button1_Click;
        this.lstvFormation.AllowDrop = true;
        this.lstvFormation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvFormation.BorderStyle = BorderStyle.FixedSingle;
        this.lstvFormation.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_116,
            this.columnHeader_117
        });
        this.lstvFormation.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvFormation.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvFormation.HideSelection = false;
        this.lstvFormation.Location = new Point(4, 6);
        this.lstvFormation.Margin = new Padding(3, 6, 3, 3);
        this.lstvFormation.Name = "lstvFormation";
        this.lstvFormation.Size = new Size(321, 226);
        this.lstvFormation.TabIndex = 185;
        this.lstvFormation.UseCompatibleStateImageBehavior = false;
        this.lstvFormation.View = View.Details;
        this.lstvFormation.DragDrop += this.lstvFormation_DragDrop;
        this.columnHeader_116.Width = 180;
        this.columnHeader_117.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_117.Width = 140;
        this.tvThreat.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvThreat.BorderStyle = BorderStyle.FixedSingle;
        this.tvThreat.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvThreat.Location = new Point(674, 6);
        this.tvThreat.Margin = new Padding(0, 2, 0, 0);
        this.tvThreat.Name = "tvThreat";
        this.tvThreat.Size = new Size(341, 641);
        this.tvThreat.TabIndex = 179;
        this.tabCargo.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabCargo.Controls.Add(this.cmdScrapAll);
        this.tabCargo.Controls.Add(this.cmdScrap);
        this.tabCargo.Controls.Add(this.tvFleetCargo);
        this.tabCargo.Location = new Point(4, 22);
        this.tabCargo.Name = "tabCargo";
        this.tabCargo.Padding = new Padding(3);
        this.tabCargo.Size = new Size(1020, 653);
        this.tabCargo.TabIndex = 3;
        this.tabCargo.Text = "Transported Items";
        this.cmdScrapAll.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdScrapAll.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdScrapAll.Location = new Point(99, 617);
        this.cmdScrapAll.Margin = new Padding(0);
        this.cmdScrapAll.Name = "cmdScrapAll";
        this.cmdScrapAll.Size = new Size(96 /*0x60*/, 30);
        this.cmdScrapAll.TabIndex = 137;
        this.cmdScrapAll.Tag = "1200";
        this.cmdScrapAll.Text = "Scrap All";
        this.cmdScrapAll.UseVisualStyleBackColor = false;
        this.cmdScrapAll.Visible = false;
        this.cmdScrapAll.Click += this.cmdScrapAll_Click;
        this.cmdScrap.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdScrap.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdScrap.Location = new Point(3, 617);
        this.cmdScrap.Margin = new Padding(0);
        this.cmdScrap.Name = "cmdScrap";
        this.cmdScrap.Size = new Size(96 /*0x60*/, 30);
        this.cmdScrap.TabIndex = 136;
        this.cmdScrap.Tag = "1200";
        this.cmdScrap.Text = "Scrap";
        this.cmdScrap.UseVisualStyleBackColor = false;
        this.cmdScrap.Visible = false;
        this.cmdScrap.Click += this.cmdScrap_Click;
        this.tvFleetCargo.AllowDrop = true;
        this.tvFleetCargo.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvFleetCargo.BorderStyle = BorderStyle.FixedSingle;
        this.tvFleetCargo.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvFleetCargo.HideSelection = false;
        this.tvFleetCargo.Location = new Point(2, 3);
        this.tvFleetCargo.Margin = new Padding(3, 0, 0, 3);
        this.tvFleetCargo.Name = "tvFleetCargo";
        this.tvFleetCargo.Size = new Size(1015, 611);
        this.tvFleetCargo.TabIndex = 42;
        this.tabFleetHistory.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabFleetHistory.Controls.Add(this.lstvHistory);
        this.tabFleetHistory.Location = new Point(4, 22);
        this.tabFleetHistory.Name = "tabFleetHistory";
        this.tabFleetHistory.Padding = new Padding(3);
        this.tabFleetHistory.Size = new Size(1020, 653);
        this.tabFleetHistory.TabIndex = 2;
        this.tabFleetHistory.Text = "History";
        this.lstvHistory.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvHistory.BorderStyle = BorderStyle.FixedSingle;
        this.lstvHistory.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_13,
            this.columnHeader_14
        });
        this.lstvHistory.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvHistory.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvHistory.HideSelection = false;
        this.lstvHistory.Location = new Point(2, 1);
        this.lstvHistory.Name = "lstvHistory";
        this.lstvHistory.Size = new Size(1018, 648);
        this.lstvHistory.TabIndex = 0;
        this.lstvHistory.UseCompatibleStateImageBehavior = false;
        this.lstvHistory.View = View.Details;
        this.columnHeader_13.Width = 180;
        this.columnHeader_14.Width = 800;
        this.tabFleetMisc.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabFleetMisc.Controls.Add(this.panel2);
        this.tabFleetMisc.Controls.Add(this.panel1);
        this.tabFleetMisc.Controls.Add(this.cmdMoveFleettoWP);
        this.tabFleetMisc.Controls.Add(this.lstMoveWP);
        this.tabFleetMisc.Controls.Add(this.cmdMoveFleetToPop);
        this.tabFleetMisc.Controls.Add(this.lstMoveFleet);
        this.tabFleetMisc.Controls.Add(this.flowLayoutPanel15);
        this.tabFleetMisc.Location = new Point(4, 22);
        this.tabFleetMisc.Name = "tabFleetMisc";
        this.tabFleetMisc.Padding = new Padding(3);
        this.tabFleetMisc.Size = new Size(1020, 653);
        this.tabFleetMisc.TabIndex = 5;
        this.tabFleetMisc.Text = "Miscellaneous";
        this.panel2.BorderStyle = BorderStyle.FixedSingle;
        this.panel2.Controls.Add(this.cboTransferRace);
        this.panel2.Controls.Add(this.cmdTransfer);
        this.panel2.Location = new Point(622, 166);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(392, 52);
        this.panel2.TabIndex = 143;
        this.cboTransferRace.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboTransferRace.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboTransferRace.FormattingEnabled = true;
        this.cboTransferRace.Location = new Point(106, 13);
        this.cboTransferRace.Margin = new Padding(3, 3, 3, 0);
        this.cboTransferRace.Name = "cboTransferRace";
        this.cboTransferRace.Size = new Size(276, 21);
        this.cboTransferRace.TabIndex = 141;
        this.cmdTransfer.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdTransfer.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdTransfer.Location = new Point(3, 8);
        this.cmdTransfer.Margin = new Padding(0);
        this.cmdTransfer.Name = "cmdTransfer";
        this.cmdTransfer.Size = new Size(96 /*0x60*/, 30);
        this.cmdTransfer.TabIndex = 140;
        this.cmdTransfer.Tag = "1200";
        this.cmdTransfer.Text = "Transfer Fleet";
        this.cmdTransfer.UseVisualStyleBackColor = false;
        this.cmdTransfer.Click += this.cmdTransfer_Click;
        this.panel1.BorderStyle = BorderStyle.FixedSingle;
        this.panel1.Controls.Add(this.chkIncFighter);
        this.panel1.Controls.Add(this.chkIncFAC);
        this.panel1.Controls.Add(this.cmdFleetText);
        this.panel1.Location = new Point(622, 108);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(392, 52);
        this.panel1.TabIndex = 142;
        this.chkIncFighter.AutoSize = true;
        this.chkIncFighter.Location = new Point(229, 15);
        this.chkIncFighter.Name = "chkIncFighter";
        this.chkIncFighter.Padding = new Padding(5, 0, 0, 0);
        this.chkIncFighter.Size = new Size(129, 17);
        this.chkIncFighter.TabIndex = 139;
        this.chkIncFighter.Text = "Show Fighter Names";
        this.chkIncFighter.TextAlign = ContentAlignment.MiddleRight;
        this.chkIncFighter.UseVisualStyleBackColor = true;
        this.chkIncFAC.AutoSize = true;
        this.chkIncFAC.Location = new Point(106, 15);
        this.chkIncFAC.Name = "chkIncFAC";
        this.chkIncFAC.Padding = new Padding(5, 0, 0, 0);
        this.chkIncFAC.Size = new Size(117, 17);
        this.chkIncFAC.TabIndex = 138;
        this.chkIncFAC.Text = "Show FAC Names";
        this.chkIncFAC.TextAlign = ContentAlignment.MiddleRight;
        this.chkIncFAC.UseVisualStyleBackColor = true;
        this.cmdFleetText.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdFleetText.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdFleetText.Location = new Point(3, 8);
        this.cmdFleetText.Margin = new Padding(0);
        this.cmdFleetText.Name = "cmdFleetText";
        this.cmdFleetText.Size = new Size(96 /*0x60*/, 30);
        this.cmdFleetText.TabIndex = 137;
        this.cmdFleetText.Tag = "1200";
        this.cmdFleetText.Text = "Fleet Text";
        this.cmdFleetText.UseVisualStyleBackColor = false;
        this.cmdFleetText.Click += this.cmdFleetText_Click;
        this.cmdMoveFleettoWP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdMoveFleettoWP.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdMoveFleettoWP.Location = new Point(417, 614);
        this.cmdMoveFleettoWP.Margin = new Padding(0);
        this.cmdMoveFleettoWP.Name = "cmdMoveFleettoWP";
        this.cmdMoveFleettoWP.Size = new Size(96 /*0x60*/, 30);
        this.cmdMoveFleettoWP.TabIndex = 139;
        this.cmdMoveFleettoWP.Tag = "1200";
        this.cmdMoveFleettoWP.Text = "Move Fleet";
        this.cmdMoveFleettoWP.UseVisualStyleBackColor = false;
        this.cmdMoveFleettoWP.Click += this.cmdMoveFleettoWP_Click;
        this.lstMoveWP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstMoveWP.BorderStyle = BorderStyle.FixedSingle;
        this.lstMoveWP.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstMoveWP.FormattingEnabled = true;
        this.lstMoveWP.Location = new Point(314, 8);
        this.lstMoveWP.Name = "lstMoveWP";
        this.lstMoveWP.Size = new Size(302, 600);
        this.lstMoveWP.TabIndex = 138;
        this.cmdMoveFleetToPop.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdMoveFleetToPop.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdMoveFleetToPop.Location = new Point(109, 614);
        this.cmdMoveFleetToPop.Margin = new Padding(0);
        this.cmdMoveFleetToPop.Name = "cmdMoveFleetToPop";
        this.cmdMoveFleetToPop.Size = new Size(96 /*0x60*/, 30);
        this.cmdMoveFleetToPop.TabIndex = 136;
        this.cmdMoveFleetToPop.Tag = "1200";
        this.cmdMoveFleetToPop.Text = "Move Fleet";
        this.cmdMoveFleetToPop.UseVisualStyleBackColor = false;
        this.cmdMoveFleetToPop.Click += this.cmdMoveFleetToPop_Click;
        this.lstMoveFleet.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstMoveFleet.BorderStyle = BorderStyle.FixedSingle;
        this.lstMoveFleet.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstMoveFleet.FormattingEnabled = true;
        this.lstMoveFleet.Location = new Point(6, 8);
        this.lstMoveFleet.Name = "lstMoveFleet";
        this.lstMoveFleet.Size = new Size(302, 600);
        this.lstMoveFleet.TabIndex = 135;
        this.lstMoveFleet.SelectedIndexChanged += this.lstMoveFleet_SelectedIndexChanged;
        this.flowLayoutPanel15.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel15.Controls.Add(this.label11);
        this.flowLayoutPanel15.Controls.Add(this.txtSurveyRadius);
        this.flowLayoutPanel15.Controls.Add(this.chkSensorDisplay);
        this.flowLayoutPanel15.Controls.Add(this.chkWeaponDisplay);
        this.flowLayoutPanel15.Location = new Point(622, 8);
        this.flowLayoutPanel15.Name = "flowLayoutPanel15";
        this.flowLayoutPanel15.Size = new Size(392, 94);
        this.flowLayoutPanel15.TabIndex = 134;
        this.label11.AutoSize = true;
        this.label11.Location = new Point(0, 4);
        this.label11.Margin = new Padding(0, 4, 0, 3);
        this.label11.Name = "label11";
        this.label11.Padding = new Padding(0, 5, 5, 0);
        this.label11.Size = new Size(181, 18);
        this.label11.TabIndex = 142;
        this.label11.Text = "Maximum Geological Survey Radius";
        this.txtSurveyRadius.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSurveyRadius.BorderStyle = BorderStyle.None;
        this.txtSurveyRadius.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtSurveyRadius.Location = new Point(181, 10);
        this.txtSurveyRadius.Margin = new Padding(0, 10, 30, 12);
        this.txtSurveyRadius.Name = "txtSurveyRadius";
        this.txtSurveyRadius.Size = new Size(82, 13);
        this.txtSurveyRadius.TabIndex = 143;
        this.txtSurveyRadius.Text = "0";
        this.txtSurveyRadius.TextAlign = HorizontalAlignment.Center;
        this.txtSurveyRadius.TextChanged += this.txtSurveyRadius_TextChanged;
        this.chkSensorDisplay.AutoSize = true;
        this.chkSensorDisplay.Location = new Point(3, 38);
        this.chkSensorDisplay.Name = "chkSensorDisplay";
        this.chkSensorDisplay.Padding = new Padding(5, 0, 0, 0);
        this.chkSensorDisplay.Size = new Size(186, 17);
        this.chkSensorDisplay.TabIndex = 135;
        this.chkSensorDisplay.Text = "Display Sensors on Tactical Map";
        this.chkSensorDisplay.TextAlign = ContentAlignment.MiddleRight;
        this.chkSensorDisplay.UseVisualStyleBackColor = true;
        this.chkSensorDisplay.CheckedChanged += this.chkSensorDisplay_CheckedChanged;
        this.chkWeaponDisplay.AutoSize = true;
        this.chkWeaponDisplay.Location = new Point(3, 61);
        this.chkWeaponDisplay.Name = "chkWeaponDisplay";
        this.chkWeaponDisplay.Padding = new Padding(5, 0, 0, 0);
        this.chkWeaponDisplay.Size = new Size(229, 17);
        this.chkWeaponDisplay.TabIndex = 136;
        this.chkWeaponDisplay.Text = "Display Weapon Ranges on Tactical Map";
        this.chkWeaponDisplay.TextAlign = ContentAlignment.MiddleRight;
        this.chkWeaponDisplay.UseVisualStyleBackColor = true;
        this.chkWeaponDisplay.CheckedChanged += this.chkWeaponDisplay_CheckedChanged;
        this.lblDefault.Location = new Point(3, 82);
        this.lblDefault.Margin = new Padding(3);
        this.lblDefault.Name = "lblDefault";
        this.lblDefault.Size = new Size(1018, 13);
        this.lblDefault.TabIndex = 134;
        this.lblDefault.Text = "Default Orders";
        this.lblCapacity.Location = new Point(3, 63 /*0x3F*/);
        this.lblCapacity.Margin = new Padding(3);
        this.lblCapacity.Name = "lblCapacity";
        this.lblCapacity.Size = new Size(1018, 13);
        this.lblCapacity.TabIndex = 133;
        this.lblCapacity.Text = "Fleet Capacity";
        this.lblFleetData.Location = new Point(3, 44);
        this.lblFleetData.Margin = new Padding(3);
        this.lblFleetData.Name = "lblFleetData";
        this.lblFleetData.Size = new Size(1018, 13);
        this.lblFleetData.TabIndex = 132;
        this.lblFleetData.Text = "Fleet Data";
        this.lblCommander.Location = new Point(3, 25);
        this.lblCommander.Margin = new Padding(3);
        this.lblCommander.Name = "lblCommander";
        this.lblCommander.Size = new Size(1018, 13);
        this.lblCommander.TabIndex = 131;
        this.lblCommander.Text = "Fleet Commander";
        this.lblCommander.Click += this.lblCommander_Click;
        this.lblCommander.DoubleClick += this.lblCommander_DoubleClick;
        this.lblLocation.Location = new Point(3, 6);
        this.lblLocation.Margin = new Padding(3);
        this.lblLocation.Name = "lblLocation";
        this.lblLocation.Size = new Size(1018, 13);
        this.lblLocation.TabIndex = 130;
        this.lblLocation.Text = "Location";
        this.tabShipDisplay.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabShipDisplay.Controls.Add(this.lstvOfficers);
        this.tabShipDisplay.Controls.Add(this.tabControl1);
        this.tabShipDisplay.Location = new Point(4, 22);
        this.tabShipDisplay.Name = "tabShipDisplay";
        this.tabShipDisplay.Padding = new Padding(3);
        this.tabShipDisplay.Size = new Size(1028, 792);
        this.tabShipDisplay.TabIndex = 2;
        this.tabShipDisplay.Text = "Ship Overview";
        this.lstvOfficers.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvOfficers.BorderStyle = BorderStyle.None;
        this.lstvOfficers.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_53,
            this.columnHeader_54
        });
        this.lstvOfficers.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvOfficers.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvOfficers.HideSelection = false;
        this.lstvOfficers.Location = new Point(3, 3);
        this.lstvOfficers.Name = "lstvOfficers";
        this.lstvOfficers.Size = new Size(1022, 111);
        this.lstvOfficers.TabIndex = 59;
        this.lstvOfficers.UseCompatibleStateImageBehavior = false;
        this.lstvOfficers.View = View.Details;
        this.lstvOfficers.DoubleClick += this.lstvOfficers_DoubleClick;
        this.columnHeader_53.Width = 120;
        this.columnHeader_54.Width = 890;
        this.tabControl1.Controls.Add(this.tabPage1);
        this.tabControl1.Controls.Add(this.tabPage2);
        this.tabControl1.Controls.Add(this.tabOrdnanceTemplate);
        this.tabControl1.Controls.Add(this.tabShipCargo);
        this.tabControl1.Controls.Add(this.tabArmour);
        this.tabControl1.Controls.Add(this.tabPage6);
        this.tabControl1.Controls.Add(this.tabPage8);
        this.tabControl1.Controls.Add(this.tabMiscellaneous);
        this.tabControl1.Location = new Point(0, 120);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new Size(1029, 679);
        this.tabControl1.TabIndex = 59;
        this.tabPage1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage1.Controls.Add(this.flowLayoutPanel19);
        this.tabPage1.Controls.Add(this.flowLayoutPanel10);
        this.tabPage1.Controls.Add(this.txtShipSummary);
        this.tabPage1.Location = new Point(4, 22);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new Padding(3);
        this.tabPage1.Size = new Size(1021, 653);
        this.tabPage1.TabIndex = 0;
        this.tabPage1.Text = "Ship Design Display";
        this.flowLayoutPanel19.Controls.Add(this.lstvCrew);
        this.flowLayoutPanel19.Controls.Add(this.lstvLogistics);
        this.flowLayoutPanel19.Controls.Add(this.lstvOrdnance);
        this.flowLayoutPanel19.Controls.Add(this.lstvMeasurement);
        this.flowLayoutPanel19.Location = new Point(0, 0);
        this.flowLayoutPanel19.Margin = new Padding(0);
        this.flowLayoutPanel19.Name = "flowLayoutPanel19";
        this.flowLayoutPanel19.Size = new Size(1021, 160 /*0xA0*/);
        this.flowLayoutPanel19.TabIndex = 61;
        this.lstvCrew.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvCrew.BorderStyle = BorderStyle.FixedSingle;
        this.lstvCrew.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_49,
            this.columnHeader_50
        });
        this.lstvCrew.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvCrew.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvCrew.HideSelection = false;
        this.lstvCrew.Location = new Point(3, 6);
        this.lstvCrew.Margin = new Padding(3, 6, 3, 3);
        this.lstvCrew.Name = "lstvCrew";
        this.lstvCrew.Size = new Size(160 /*0xA0*/, 154);
        this.lstvCrew.TabIndex = 58;
        this.lstvCrew.UseCompatibleStateImageBehavior = false;
        this.lstvCrew.View = View.Details;
        this.columnHeader_49.Width = 100;
        this.columnHeader_50.TextAlign = HorizontalAlignment.Center;
        this.lstvLogistics.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvLogistics.BorderStyle = BorderStyle.FixedSingle;
        this.lstvLogistics.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_51,
            this.columnHeader_52
        });
        this.lstvLogistics.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvLogistics.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvLogistics.HideSelection = false;
        this.lstvLogistics.Location = new Point(169, 6);
        this.lstvLogistics.Margin = new Padding(3, 6, 3, 3);
        this.lstvLogistics.Name = "lstvLogistics";
        this.lstvLogistics.Size = new Size(245, 154);
        this.lstvLogistics.TabIndex = 57;
        this.lstvLogistics.UseCompatibleStateImageBehavior = false;
        this.lstvLogistics.View = View.Details;
        this.columnHeader_51.Width = 125;
        this.columnHeader_52.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_52.Width = 120;
        this.lstvOrdnance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvOrdnance.BorderStyle = BorderStyle.FixedSingle;
        this.lstvOrdnance.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_55,
            this.columnHeader_56
        });
        this.lstvOrdnance.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvOrdnance.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvOrdnance.HideSelection = false;
        this.lstvOrdnance.Location = new Point(420, 6);
        this.lstvOrdnance.Margin = new Padding(3, 6, 3, 3);
        this.lstvOrdnance.Name = "lstvOrdnance";
        this.lstvOrdnance.Size = new Size(270, 154);
        this.lstvOrdnance.TabIndex = 59;
        this.lstvOrdnance.UseCompatibleStateImageBehavior = false;
        this.lstvOrdnance.View = View.Details;
        this.columnHeader_55.Width = 180;
        this.columnHeader_56.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_56.Width = 70;
        this.lstvMeasurement.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvMeasurement.BorderStyle = BorderStyle.FixedSingle;
        this.lstvMeasurement.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_47,
            this.columnHeader_48
        });
        this.lstvMeasurement.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvMeasurement.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvMeasurement.HideSelection = false;
        this.lstvMeasurement.Location = new Point(696, 6);
        this.lstvMeasurement.Margin = new Padding(3, 6, 3, 3);
        this.lstvMeasurement.Name = "lstvMeasurement";
        this.lstvMeasurement.Size = new Size(321, 154);
        this.lstvMeasurement.TabIndex = 56;
        this.lstvMeasurement.UseCompatibleStateImageBehavior = false;
        this.lstvMeasurement.View = View.Details;
        this.columnHeader_47.Width = 200;
        this.columnHeader_48.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_48.Width = 100;
        this.flowLayoutPanel10.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel10.Controls.Add(this.cboRefuelActive);
        this.flowLayoutPanel10.Controls.Add(this.cboResupplyActive);
        this.flowLayoutPanel10.Controls.Add(this.cboTransferActive);
        this.flowLayoutPanel10.Controls.Add(this.cboHangar);
        this.flowLayoutPanel10.Controls.Add(this.flpEnergyWeaponData);
        this.flowLayoutPanel10.Location = new Point(3, 166);
        this.flowLayoutPanel10.Name = "flowLayoutPanel10";
        this.flowLayoutPanel10.Size = new Size(1015, 30);
        this.flowLayoutPanel10.TabIndex = 60;
        this.cboRefuelActive.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRefuelActive.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboRefuelActive.FormattingEnabled = true;
        this.cboRefuelActive.Location = new Point(3, 3);
        this.cboRefuelActive.Name = "cboRefuelActive";
        this.cboRefuelActive.Size = new Size(155, 21);
        this.cboRefuelActive.TabIndex = 52;
        this.cboRefuelActive.SelectedIndexChanged += this.cboRefuelActive_SelectedIndexChanged;
        this.cboResupplyActive.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboResupplyActive.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboResupplyActive.FormattingEnabled = true;
        this.cboResupplyActive.Location = new Point(164, 3);
        this.cboResupplyActive.Name = "cboResupplyActive";
        this.cboResupplyActive.Size = new Size(155, 21);
        this.cboResupplyActive.TabIndex = 139;
        this.cboResupplyActive.SelectedIndexChanged += this.cboResupplyActive_SelectedIndexChanged;
        this.cboTransferActive.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboTransferActive.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboTransferActive.FormattingEnabled = true;
        this.cboTransferActive.Location = new Point(325, 3);
        this.cboTransferActive.Name = "cboTransferActive";
        this.cboTransferActive.Size = new Size(171, 21);
        this.cboTransferActive.TabIndex = 54;
        this.cboTransferActive.SelectedIndexChanged += this.cboTransferActive_SelectedIndexChanged;
        this.cboHangar.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboHangar.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboHangar.FormattingEnabled = true;
        this.cboHangar.Location = new Point(502, 3);
        this.cboHangar.Name = "cboHangar";
        this.cboHangar.Size = new Size(171, 21);
        this.cboHangar.TabIndex = 138;
        this.cboHangar.SelectedIndexChanged += this.cboHangar_SelectedIndexChanged;
        this.flpEnergyWeaponData.Controls.Add(this.label28);
        this.flpEnergyWeaponData.Controls.Add(this.txtTargetSpeed);
        this.flpEnergyWeaponData.Controls.Add(this.label27);
        this.flpEnergyWeaponData.Controls.Add(this.txtRangeBand);
        this.flpEnergyWeaponData.Location = new Point(681, 0);
        this.flpEnergyWeaponData.Margin = new Padding(5, 0, 0, 0);
        this.flpEnergyWeaponData.Name = "flpEnergyWeaponData";
        this.flpEnergyWeaponData.Size = new Size(325, 25);
        this.flpEnergyWeaponData.TabIndex = 61;
        this.label28.AutoSize = true;
        this.label28.Location = new Point(5, 6);
        this.label28.Margin = new Padding(5, 6, 5, 0);
        this.label28.Name = "label28";
        this.label28.Size = new Size(72, 13);
        this.label28.TabIndex = 3;
        this.label28.Text = "Target Speed";
        this.label28.TextAlign = ContentAlignment.MiddleCenter;
        this.txtTargetSpeed.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTargetSpeed.BorderStyle = BorderStyle.None;
        this.txtTargetSpeed.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtTargetSpeed.Location = new Point(82, 7);
        this.txtTargetSpeed.Margin = new Padding(0, 7, 3, 3);
        this.txtTargetSpeed.Multiline = true;
        this.txtTargetSpeed.Name = "txtTargetSpeed";
        this.txtTargetSpeed.Size = new Size(50, 18);
        this.txtTargetSpeed.TabIndex = 9;
        this.txtTargetSpeed.Text = "4000";
        this.txtTargetSpeed.TextAlign = HorizontalAlignment.Center;
        this.label27.AutoSize = true;
        this.label27.Location = new Point(150, 6);
        this.label27.Margin = new Padding(15, 6, 5, 0);
        this.label27.Name = "label27";
        this.label27.Size = new Size(72, 13);
        this.label27.TabIndex = 3;
        this.label27.Text = "Range Bands";
        this.label27.TextAlign = ContentAlignment.MiddleCenter;
        this.txtRangeBand.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtRangeBand.BorderStyle = BorderStyle.None;
        this.txtRangeBand.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtRangeBand.Location = new Point(227, 7);
        this.txtRangeBand.Margin = new Padding(0, 7, 3, 3);
        this.txtRangeBand.Multiline = true;
        this.txtRangeBand.Name = "txtRangeBand";
        this.txtRangeBand.Size = new Size(50, 18);
        this.txtRangeBand.TabIndex = 9;
        this.txtRangeBand.Text = "10000";
        this.txtRangeBand.TextAlign = HorizontalAlignment.Center;
        this.txtShipSummary.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtShipSummary.BorderStyle = BorderStyle.FixedSingle;
        this.txtShipSummary.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.txtShipSummary.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtShipSummary.Location = new Point(3, 203);
        this.txtShipSummary.Multiline = true;
        this.txtShipSummary.Name = "txtShipSummary";
        this.txtShipSummary.Size = new Size(1015, 442);
        this.txtShipSummary.TabIndex = 48 /*0x30*/;
        this.tabPage2.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage2.Controls.Add(this.txtClassDisplay);
        this.tabPage2.Location = new Point(4, 22);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new Padding(3);
        this.tabPage2.Size = new Size(1021, 653);
        this.tabPage2.TabIndex = 1;
        this.tabPage2.Text = "Class Design Display";
        this.txtClassDisplay.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtClassDisplay.BorderStyle = BorderStyle.FixedSingle;
        this.txtClassDisplay.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.txtClassDisplay.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtClassDisplay.Location = new Point(2, 3);
        this.txtClassDisplay.Multiline = true;
        this.txtClassDisplay.Name = "txtClassDisplay";
        this.txtClassDisplay.Size = new Size(1016, 641);
        this.txtClassDisplay.TabIndex = 49;
        this.tabOrdnanceTemplate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabOrdnanceTemplate.Controls.Add(this.flowLayoutPanel21);
        this.tabOrdnanceTemplate.Controls.Add(this.lstvOrdnanceTemplate);
        this.tabOrdnanceTemplate.Location = new Point(4, 22);
        this.tabOrdnanceTemplate.Name = "tabOrdnanceTemplate";
        this.tabOrdnanceTemplate.Padding = new Padding(3);
        this.tabOrdnanceTemplate.Size = new Size(1021, 653);
        this.tabOrdnanceTemplate.TabIndex = 6;
        this.tabOrdnanceTemplate.Text = "OrdnanceTemplate";
        this.flowLayoutPanel21.Controls.Add(this.lstvClassTemplate);
        this.flowLayoutPanel21.Controls.Add(this.lstvShipTemplate);
        this.flowLayoutPanel21.Controls.Add(this.lstvShipLoadout);
        this.flowLayoutPanel21.Controls.Add(this.flowLayoutPanel22);
        this.flowLayoutPanel21.Controls.Add(this.flowLayoutPanel17);
        this.flowLayoutPanel21.Location = new Point(0, 3);
        this.flowLayoutPanel21.Margin = new Padding(0, 3, 3, 3);
        this.flowLayoutPanel21.Name = "flowLayoutPanel21";
        this.flowLayoutPanel21.Size = new Size(1021, 222);
        this.flowLayoutPanel21.TabIndex = 86;
        this.lstvClassTemplate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvClassTemplate.BorderStyle = BorderStyle.FixedSingle;
        this.lstvClassTemplate.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_105,
            this.columnHeader_106
        });
        this.lstvClassTemplate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvClassTemplate.FullRowSelect = true;
        this.lstvClassTemplate.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvClassTemplate.HideSelection = false;
        this.lstvClassTemplate.Location = new Point(3, 3);
        this.lstvClassTemplate.Name = "lstvClassTemplate";
        this.lstvClassTemplate.Size = new Size(230, 219);
        this.lstvClassTemplate.TabIndex = 89;
        this.lstvClassTemplate.UseCompatibleStateImageBehavior = false;
        this.lstvClassTemplate.View = View.Details;
        this.columnHeader_105.Width = 170;
        this.columnHeader_106.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_106.Width = 50;
        this.lstvShipTemplate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvShipTemplate.BorderStyle = BorderStyle.FixedSingle;
        this.lstvShipTemplate.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_103,
            this.columnHeader_104
        });
        this.lstvShipTemplate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvShipTemplate.FullRowSelect = true;
        this.lstvShipTemplate.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvShipTemplate.HideSelection = false;
        this.lstvShipTemplate.Location = new Point(239, 3);
        this.lstvShipTemplate.Name = "lstvShipTemplate";
        this.lstvShipTemplate.Size = new Size(230, 219);
        this.lstvShipTemplate.TabIndex = 88;
        this.lstvShipTemplate.UseCompatibleStateImageBehavior = false;
        this.lstvShipTemplate.View = View.Details;
        this.lstvShipTemplate.DoubleClick += this.lstvShipTemplate_DoubleClick;
        this.columnHeader_103.Width = 170;
        this.columnHeader_104.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_104.Width = 50;
        this.lstvShipLoadout.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvShipLoadout.BorderStyle = BorderStyle.FixedSingle;
        this.lstvShipLoadout.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_101,
            this.columnHeader_102
        });
        this.lstvShipLoadout.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvShipLoadout.FullRowSelect = true;
        this.lstvShipLoadout.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvShipLoadout.HideSelection = false;
        this.lstvShipLoadout.Location = new Point(475, 3);
        this.lstvShipLoadout.Name = "lstvShipLoadout";
        this.lstvShipLoadout.Size = new Size(230, 219);
        this.lstvShipLoadout.TabIndex = 87;
        this.lstvShipLoadout.UseCompatibleStateImageBehavior = false;
        this.lstvShipLoadout.View = View.Details;
        this.columnHeader_101.Width = 170;
        this.columnHeader_102.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_102.Width = 50;
        this.flowLayoutPanel22.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel22.Controls.Add(this.flowLayoutPanel18);
        this.flowLayoutPanel22.Controls.Add(this.chkObsoleteMissiles);
        this.flowLayoutPanel22.Controls.Add(this.checkBox1);
        this.flowLayoutPanel22.Location = new Point(711, 3);
        this.flowLayoutPanel22.Name = "flowLayoutPanel22";
        this.flowLayoutPanel22.Size = new Size(196, 219);
        this.flowLayoutPanel22.TabIndex = 87;
        this.flowLayoutPanel18.Controls.Add(this.rdoLoadout1);
        this.flowLayoutPanel18.Controls.Add(this.rdoLoadout10);
        this.flowLayoutPanel18.Controls.Add(this.rdoLoadout100);
        this.flowLayoutPanel18.Controls.Add(this.rdoLoadout1000);
        this.flowLayoutPanel18.Location = new Point(3, 3);
        this.flowLayoutPanel18.Name = "flowLayoutPanel18";
        this.flowLayoutPanel18.Size = new Size(186, 25);
        this.flowLayoutPanel18.TabIndex = 79;
        this.rdoLoadout1.AutoSize = true;
        this.rdoLoadout1.Checked = true;
        this.rdoLoadout1.Location = new Point(3, 3);
        this.rdoLoadout1.Name = "rdoLoadout1";
        this.rdoLoadout1.Size = new Size(31 /*0x1F*/, 17);
        this.rdoLoadout1.TabIndex = 0;
        this.rdoLoadout1.TabStop = true;
        this.rdoLoadout1.Tag = "1";
        this.rdoLoadout1.Text = "1";
        this.rdoLoadout1.UseVisualStyleBackColor = true;
        this.rdoLoadout10.AutoSize = true;
        this.rdoLoadout10.Location = new Point(40, 3);
        this.rdoLoadout10.Name = "rdoLoadout10";
        this.rdoLoadout10.Size = new Size(37, 17);
        this.rdoLoadout10.TabIndex = 1;
        this.rdoLoadout10.Text = "10";
        this.rdoLoadout10.UseVisualStyleBackColor = true;
        this.rdoLoadout100.AutoSize = true;
        this.rdoLoadout100.Location = new Point(83, 3);
        this.rdoLoadout100.Name = "rdoLoadout100";
        this.rdoLoadout100.Size = new Size(43, 17);
        this.rdoLoadout100.TabIndex = 2;
        this.rdoLoadout100.Text = "100";
        this.rdoLoadout100.UseVisualStyleBackColor = true;
        this.rdoLoadout1000.AutoSize = true;
        this.rdoLoadout1000.Location = new Point(132, 3);
        this.rdoLoadout1000.Name = "rdoLoadout1000";
        this.rdoLoadout1000.Size = new Size(49, 17);
        this.rdoLoadout1000.TabIndex = 3;
        this.rdoLoadout1000.Text = "1000";
        this.rdoLoadout1000.UseVisualStyleBackColor = true;
        this.chkObsoleteMissiles.AutoSize = true;
        this.chkObsoleteMissiles.Location = new Point(3, 38);
        this.chkObsoleteMissiles.Margin = new Padding(3, 7, 3, 3);
        this.chkObsoleteMissiles.Name = "chkObsoleteMissiles";
        this.chkObsoleteMissiles.Padding = new Padding(5, 0, 0, 0);
        this.chkObsoleteMissiles.Size = new Size(142, 17);
        this.chkObsoleteMissiles.TabIndex = 71;
        this.chkObsoleteMissiles.Text = "Show Obsolete Missiles";
        this.chkObsoleteMissiles.TextAlign = ContentAlignment.MiddleRight;
        this.chkObsoleteMissiles.UseVisualStyleBackColor = true;
        this.chkObsoleteMissiles.CheckedChanged += this.checkBox1_CheckedChanged;
        this.checkBox1.AutoSize = true;
        this.checkBox1.Location = new Point(3, 65);
        this.checkBox1.Margin = new Padding(3, 7, 3, 3);
        this.checkBox1.Name = "checkBox1";
        this.checkBox1.Padding = new Padding(5, 0, 0, 0);
        this.checkBox1.Size = new Size(155, 17);
        this.checkBox1.TabIndex = 77;
        this.checkBox1.Text = "No Missile Size Restriction";
        this.checkBox1.TextAlign = ContentAlignment.MiddleRight;
        this.checkBox1.UseVisualStyleBackColor = true;
        this.checkBox1.CheckedChanged += this.checkBox1_CheckedChanged;
        this.flowLayoutPanel17.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel17.Controls.Add(this.cmdRenameMissile);
        this.flowLayoutPanel17.Controls.Add(this.cmdObsoleteMissile);
        this.flowLayoutPanel17.Controls.Add(this.cmdCopyClassLoadout);
        this.flowLayoutPanel17.Controls.Add(this.cmdCopyToClass);
        this.flowLayoutPanel17.Controls.Add(this.cmdCopyToFleet);
        this.flowLayoutPanel17.Controls.Add(this.cmdFillShip);
        this.flowLayoutPanel17.Controls.Add(this.cmdSMFillClass);
        this.flowLayoutPanel17.Location = new Point(913, 3);
        this.flowLayoutPanel17.Name = "flowLayoutPanel17";
        this.flowLayoutPanel17.Size = new Size(104, 219);
        this.flowLayoutPanel17.TabIndex = 89;
        this.cmdRenameMissile.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameMissile.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRenameMissile.Location = new Point(3, 3);
        this.cmdRenameMissile.Margin = new Padding(3, 3, 0, 0);
        this.cmdRenameMissile.Name = "cmdRenameMissile";
        this.cmdRenameMissile.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameMissile.TabIndex = 78;
        this.cmdRenameMissile.Tag = "1200";
        this.cmdRenameMissile.Text = "Rename Missile";
        this.cmdRenameMissile.UseVisualStyleBackColor = false;
        this.cmdRenameMissile.Click += this.cmdRenameMissile_Click;
        this.cmdObsoleteMissile.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdObsoleteMissile.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdObsoleteMissile.Location = new Point(3, 33);
        this.cmdObsoleteMissile.Margin = new Padding(3, 0, 0, 0);
        this.cmdObsoleteMissile.Name = "cmdObsoleteMissile";
        this.cmdObsoleteMissile.Size = new Size(96 /*0x60*/, 30);
        this.cmdObsoleteMissile.TabIndex = 74;
        this.cmdObsoleteMissile.Tag = "1200";
        this.cmdObsoleteMissile.Text = "Obsolete Missile";
        this.cmdObsoleteMissile.UseVisualStyleBackColor = false;
        this.cmdObsoleteMissile.Click += this.cmdObsoleteMissile_Click;
        this.cmdCopyClassLoadout.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCopyClassLoadout.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCopyClassLoadout.Location = new Point(3, 63 /*0x3F*/);
        this.cmdCopyClassLoadout.Margin = new Padding(3, 0, 0, 0);
        this.cmdCopyClassLoadout.Name = "cmdCopyClassLoadout";
        this.cmdCopyClassLoadout.Size = new Size(96 /*0x60*/, 30);
        this.cmdCopyClassLoadout.TabIndex = 79;
        this.cmdCopyClassLoadout.Tag = "1200";
        this.cmdCopyClassLoadout.Text = "Copy from Class";
        this.cmdCopyClassLoadout.UseVisualStyleBackColor = false;
        this.cmdCopyClassLoadout.Click += this.cmdCopyClassLoadout_Click;
        this.cmdCopyToClass.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCopyToClass.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCopyToClass.Location = new Point(3, 93);
        this.cmdCopyToClass.Margin = new Padding(3, 0, 0, 0);
        this.cmdCopyToClass.Name = "cmdCopyToClass";
        this.cmdCopyToClass.Size = new Size(96 /*0x60*/, 30);
        this.cmdCopyToClass.TabIndex = 89;
        this.cmdCopyToClass.Tag = "1200";
        this.cmdCopyToClass.Text = "Copy to Class";
        this.cmdCopyToClass.UseVisualStyleBackColor = false;
        this.cmdCopyToClass.Click += this.cmdCopyToClass_Click;
        this.cmdCopyToFleet.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCopyToFleet.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCopyToFleet.Location = new Point(3, 123);
        this.cmdCopyToFleet.Margin = new Padding(3, 0, 0, 0);
        this.cmdCopyToFleet.Name = "cmdCopyToFleet";
        this.cmdCopyToFleet.Size = new Size(96 /*0x60*/, 30);
        this.cmdCopyToFleet.TabIndex = 90;
        this.cmdCopyToFleet.Tag = "1200";
        this.cmdCopyToFleet.Text = "Copy to Fleet";
        this.cmdCopyToFleet.UseVisualStyleBackColor = false;
        this.cmdCopyToFleet.Click += this.cmdCopyToFleet_Click;
        this.cmdFillShip.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdFillShip.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdFillShip.Location = new Point(3, 153);
        this.cmdFillShip.Margin = new Padding(3, 0, 0, 0);
        this.cmdFillShip.Name = "cmdFillShip";
        this.cmdFillShip.Size = new Size(96 /*0x60*/, 30);
        this.cmdFillShip.TabIndex = 88;
        this.cmdFillShip.Tag = "1200";
        this.cmdFillShip.Text = "SM: Fill Ship";
        this.cmdFillShip.UseVisualStyleBackColor = false;
        this.cmdFillShip.Click += this.cmdFillShip_Click;
        this.cmdSMFillClass.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSMFillClass.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSMFillClass.Location = new Point(3, 183);
        this.cmdSMFillClass.Margin = new Padding(3, 0, 0, 0);
        this.cmdSMFillClass.Name = "cmdSMFillClass";
        this.cmdSMFillClass.Size = new Size(96 /*0x60*/, 30);
        this.cmdSMFillClass.TabIndex = 87;
        this.cmdSMFillClass.Tag = "1200";
        this.cmdSMFillClass.Text = "SM: Fill Class";
        this.cmdSMFillClass.UseVisualStyleBackColor = false;
        this.cmdSMFillClass.Click += this.cmdSMFillClass_Click;
        this.lstvOrdnanceTemplate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvOrdnanceTemplate.BorderStyle = BorderStyle.FixedSingle;
        this.lstvOrdnanceTemplate.Columns.AddRange(new ColumnHeader[13]
        {
            this.columnHeader_89,
            this.columnHeader_90,
            this.columnHeader_91,
            this.columnHeader_92,
            this.columnHeader_93,
            this.columnHeader_94,
            this.columnHeader_95,
            this.columnHeader_96,
            this.columnHeader_97,
            this.columnHeader_98,
            this.columnHeader_99,
            this.columnHeader_100,
            this.columnHeader_130
        });
        this.lstvOrdnanceTemplate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvOrdnanceTemplate.FullRowSelect = true;
        this.lstvOrdnanceTemplate.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvOrdnanceTemplate.HideSelection = false;
        this.lstvOrdnanceTemplate.Location = new Point(3, 230);
        this.lstvOrdnanceTemplate.Name = "lstvOrdnanceTemplate";
        this.lstvOrdnanceTemplate.Size = new Size(1015, 415);
        this.lstvOrdnanceTemplate.TabIndex = 70;
        this.lstvOrdnanceTemplate.UseCompatibleStateImageBehavior = false;
        this.lstvOrdnanceTemplate.View = View.Details;
        this.lstvOrdnanceTemplate.SelectedIndexChanged += this.lstvOrdnanceTemplate_SelectedIndexChanged;
        this.lstvOrdnanceTemplate.DoubleClick += this.lstvOrdnanceTemplate_DoubleClick;
        this.columnHeader_89.Width = 140;
        this.columnHeader_90.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_90.Width = 50;
        this.columnHeader_91.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_91.Width = 50;
        this.columnHeader_92.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_92.Width = 65;
        this.columnHeader_93.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_93.Width = 50;
        this.columnHeader_94.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_94.Width = 55;
        this.columnHeader_95.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_95.Width = 55;
        this.columnHeader_96.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_97.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_97.Width = 80 /*0x50*/;
        this.columnHeader_98.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_98.Width = 55;
        this.columnHeader_99.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_100.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_100.Width = 150;
        this.columnHeader_130.Width = 130;
        this.tabShipCargo.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabShipCargo.Controls.Add(this.tvShipCargo);
        this.tabShipCargo.Location = new Point(4, 22);
        this.tabShipCargo.Name = "tabShipCargo";
        this.tabShipCargo.Padding = new Padding(3);
        this.tabShipCargo.Size = new Size(1021, 653);
        this.tabShipCargo.TabIndex = 7;
        this.tabShipCargo.Text = "Transported Items";
        this.tvShipCargo.AllowDrop = true;
        this.tvShipCargo.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvShipCargo.BorderStyle = BorderStyle.FixedSingle;
        this.tvShipCargo.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvShipCargo.HideSelection = false;
        this.tvShipCargo.Location = new Point(3, 4);
        this.tvShipCargo.Margin = new Padding(3, 0, 0, 3);
        this.tvShipCargo.Name = "tvShipCargo";
        this.tvShipCargo.Size = new Size(1015, 644);
        this.tvShipCargo.TabIndex = 43;
        this.tabArmour.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabArmour.Controls.Add(this.panArmour);
        this.tabArmour.Location = new Point(4, 22);
        this.tabArmour.Name = "tabArmour";
        this.tabArmour.Padding = new Padding(3);
        this.tabArmour.Size = new Size(1021, 653);
        this.tabArmour.TabIndex = 3;
        this.tabArmour.Text = "Armour Status";
        this.panArmour.BorderStyle = BorderStyle.FixedSingle;
        this.panArmour.Dock = DockStyle.Fill;
        this.panArmour.Location = new Point(3, 3);
        this.panArmour.Name = "panArmour";
        this.panArmour.Size = new Size(1015, 647);
        this.panArmour.TabIndex = 0;
        this.panArmour.Paint += this.panArmour_Paint;
        this.tabPage6.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage6.Controls.Add(this.flowLayoutPanel14);
        this.tabPage6.Controls.Add(this.label8);
        this.tabPage6.Controls.Add(this.txtRepairChanceTime);
        this.tabPage6.Controls.Add(this.cmdTop);
        this.tabPage6.Controls.Add(this.cmdRemove);
        this.tabPage6.Controls.Add(this.cmdDown);
        this.tabPage6.Controls.Add(this.cmdUp);
        this.tabPage6.Controls.Add(this.lstvDamageControlQueue);
        this.tabPage6.Controls.Add(this.lstvDAC);
        this.tabPage6.Location = new Point(4, 22);
        this.tabPage6.Name = "tabPage6";
        this.tabPage6.Padding = new Padding(3);
        this.tabPage6.Size = new Size(1021, 653);
        this.tabPage6.TabIndex = 2;
        this.tabPage6.Text = "Damage Control";
        this.flowLayoutPanel14.Controls.Add(this.cmdRepair);
        this.flowLayoutPanel14.Controls.Add(this.cmdSMRepair);
        this.flowLayoutPanel14.Controls.Add(this.cmdAutoQueue);
        this.flowLayoutPanel14.Controls.Add(this.chkAutoDC);
        this.flowLayoutPanel14.Location = new Point(2, 617);
        this.flowLayoutPanel14.Name = "flowLayoutPanel14";
        this.flowLayoutPanel14.Size = new Size(470, 31 /*0x1F*/);
        this.flowLayoutPanel14.TabIndex = 139;
        this.cmdRepair.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRepair.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRepair.Location = new Point(0, 0);
        this.cmdRepair.Margin = new Padding(0);
        this.cmdRepair.Name = "cmdRepair";
        this.cmdRepair.Size = new Size(96 /*0x60*/, 30);
        this.cmdRepair.TabIndex = 127;
        this.cmdRepair.Tag = "1200";
        this.cmdRepair.Text = "Repair";
        this.cmdRepair.UseVisualStyleBackColor = false;
        this.cmdRepair.Click += this.cmdRepair_Click;
        this.cmdSMRepair.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSMRepair.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSMRepair.Location = new Point(96 /*0x60*/, 0);
        this.cmdSMRepair.Margin = new Padding(0);
        this.cmdSMRepair.Name = "cmdSMRepair";
        this.cmdSMRepair.Size = new Size(96 /*0x60*/, 30);
        this.cmdSMRepair.TabIndex = 138;
        this.cmdSMRepair.Tag = "1200";
        this.cmdSMRepair.Text = "SM Repair All";
        this.cmdSMRepair.UseVisualStyleBackColor = false;
        this.cmdSMRepair.Click += this.cmdSMRepair_Click;
        this.cmdAutoQueue.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAutoQueue.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAutoQueue.Location = new Point(192 /*0xC0*/, 0);
        this.cmdAutoQueue.Margin = new Padding(0);
        this.cmdAutoQueue.Name = "cmdAutoQueue";
        this.cmdAutoQueue.Size = new Size(96 /*0x60*/, 30);
        this.cmdAutoQueue.TabIndex = 137;
        this.cmdAutoQueue.Tag = "1200";
        this.cmdAutoQueue.Text = "Auto Queue";
        this.cmdAutoQueue.UseVisualStyleBackColor = false;
        this.cmdAutoQueue.Click += this.cmdAutoQueue_Click;
        this.chkAutoDC.AutoSize = true;
        this.chkAutoDC.Location = new Point(300, 6);
        this.chkAutoDC.Margin = new Padding(12, 6, 3, 3);
        this.chkAutoDC.Name = "chkAutoDC";
        this.chkAutoDC.Padding = new Padding(5, 0, 0, 0);
        this.chkAutoDC.Size = new Size(161, 17);
        this.chkAutoDC.TabIndex = 134;
        this.chkAutoDC.Text = "Automated Damage Control";
        this.chkAutoDC.TextAlign = ContentAlignment.MiddleRight;
        this.chkAutoDC.UseVisualStyleBackColor = true;
        this.chkAutoDC.CheckedChanged += this.chkAutoDC_CheckedChanged;
        this.label8.AutoSize = true;
        this.label8.Location = new Point(485, 624);
        this.label8.Margin = new Padding(5, 6, 5, 0);
        this.label8.Name = "label8";
        this.label8.Size = new Size(104, 13);
        this.label8.TabIndex = 135;
        this.label8.Text = "Repair Chance Time";
        this.label8.TextAlign = ContentAlignment.MiddleCenter;
        this.txtRepairChanceTime.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtRepairChanceTime.BorderStyle = BorderStyle.None;
        this.txtRepairChanceTime.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtRepairChanceTime.Location = new Point(580, 624);
        this.txtRepairChanceTime.Margin = new Padding(0, 7, 3, 3);
        this.txtRepairChanceTime.Multiline = true;
        this.txtRepairChanceTime.Name = "txtRepairChanceTime";
        this.txtRepairChanceTime.Size = new Size(50, 18);
        this.txtRepairChanceTime.TabIndex = 136;
        this.txtRepairChanceTime.Text = "3600";
        this.txtRepairChanceTime.TextAlign = HorizontalAlignment.Center;
        this.txtRepairChanceTime.TextChanged += this.txtRepairChanceTime_TextChanged;
        this.cmdTop.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdTop.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdTop.Location = new Point(631, 617);
        this.cmdTop.Margin = new Padding(0);
        this.cmdTop.Name = "cmdTop";
        this.cmdTop.Size = new Size(96 /*0x60*/, 30);
        this.cmdTop.TabIndex = 132;
        this.cmdTop.Tag = "1200";
        this.cmdTop.Text = "Move To Top";
        this.cmdTop.UseVisualStyleBackColor = false;
        this.cmdTop.Click += this.cmdTop_Click;
        this.cmdRemove.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRemove.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRemove.Location = new Point(919, 617);
        this.cmdRemove.Margin = new Padding(0);
        this.cmdRemove.Name = "cmdRemove";
        this.cmdRemove.Size = new Size(96 /*0x60*/, 30);
        this.cmdRemove.TabIndex = 131;
        this.cmdRemove.Tag = "1200";
        this.cmdRemove.Text = "Remove";
        this.cmdRemove.UseVisualStyleBackColor = false;
        this.cmdRemove.Click += this.cmdRemove_Click;
        this.cmdDown.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDown.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDown.Location = new Point(823, 617);
        this.cmdDown.Margin = new Padding(0);
        this.cmdDown.Name = "cmdDown";
        this.cmdDown.Size = new Size(96 /*0x60*/, 30);
        this.cmdDown.TabIndex = 130;
        this.cmdDown.Tag = "1200";
        this.cmdDown.Text = "Down";
        this.cmdDown.UseVisualStyleBackColor = false;
        this.cmdDown.Click += this.cmdDown_Click;
        this.cmdUp.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdUp.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdUp.Location = new Point(727, 617);
        this.cmdUp.Margin = new Padding(0);
        this.cmdUp.Name = "cmdUp";
        this.cmdUp.Size = new Size(96 /*0x60*/, 30);
        this.cmdUp.TabIndex = 129;
        this.cmdUp.Tag = "1200";
        this.cmdUp.Text = "Up";
        this.cmdUp.UseVisualStyleBackColor = false;
        this.cmdUp.Click += this.cmdUp_Click;
        this.lstvDamageControlQueue.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvDamageControlQueue.BorderStyle = BorderStyle.FixedSingle;
        this.lstvDamageControlQueue.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_64,
            this.columnHeader_65,
            this.columnHeader_69
        });
        this.lstvDamageControlQueue.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvDamageControlQueue.FullRowSelect = true;
        this.lstvDamageControlQueue.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvDamageControlQueue.HideSelection = false;
        this.lstvDamageControlQueue.Location = new Point(631, 3);
        this.lstvDamageControlQueue.Name = "lstvDamageControlQueue";
        this.lstvDamageControlQueue.Size = new Size(384, 611);
        this.lstvDamageControlQueue.TabIndex = 128 /*0x80*/;
        this.lstvDamageControlQueue.UseCompatibleStateImageBehavior = false;
        this.lstvDamageControlQueue.View = View.Details;
        this.columnHeader_64.Width = 40;
        this.columnHeader_65.Width = 280;
        this.columnHeader_69.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_69.Width = 50;
        this.lstvDAC.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvDAC.BorderStyle = BorderStyle.FixedSingle;
        this.lstvDAC.Columns.AddRange(new ColumnHeader[6]
        {
            this.columnHeader_58,
            this.columnHeader_59,
            this.columnHeader_63,
            this.columnHeader_60,
            this.columnHeader_61,
            this.columnHeader_62
        });
        this.lstvDAC.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvDAC.FullRowSelect = true;
        this.lstvDAC.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvDAC.HideSelection = false;
        this.lstvDAC.Location = new Point(3, 3);
        this.lstvDAC.Name = "lstvDAC";
        this.lstvDAC.Size = new Size(622, 611);
        this.lstvDAC.TabIndex = 57;
        this.lstvDAC.UseCompatibleStateImageBehavior = false;
        this.lstvDAC.View = View.Details;
        this.lstvDAC.SelectedIndexChanged += this.lstvDAC_SelectedIndexChanged;
        this.columnHeader_58.Width = 310;
        this.columnHeader_59.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_63.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_60.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_61.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_62.TextAlign = HorizontalAlignment.Center;
        this.tabPage8.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage8.Controls.Add(this.lstvShipHistory);
        this.tabPage8.Location = new Point(4, 22);
        this.tabPage8.Name = "tabPage8";
        this.tabPage8.Padding = new Padding(3);
        this.tabPage8.Size = new Size(1021, 653);
        this.tabPage8.TabIndex = 4;
        this.tabPage8.Text = "History";
        this.lstvShipHistory.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvShipHistory.BorderStyle = BorderStyle.FixedSingle;
        this.lstvShipHistory.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_128,
            this.columnHeader_129
        });
        this.lstvShipHistory.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvShipHistory.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvShipHistory.HideSelection = false;
        this.lstvShipHistory.Location = new Point(2, 1);
        this.lstvShipHistory.Name = "lstvShipHistory";
        this.lstvShipHistory.Size = new Size(1018, 648);
        this.lstvShipHistory.TabIndex = 1;
        this.lstvShipHistory.UseCompatibleStateImageBehavior = false;
        this.lstvShipHistory.View = View.Details;
        this.columnHeader_128.Width = 180;
        this.columnHeader_129.Width = 800;
        this.tabMiscellaneous.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabMiscellaneous.Controls.Add(this.flowLayoutPanel6);
        this.tabMiscellaneous.Controls.Add(this.flowLayoutPanel13);
        this.tabMiscellaneous.Controls.Add(this.flowLayoutPanel11);
        this.tabMiscellaneous.Location = new Point(4, 22);
        this.tabMiscellaneous.Name = "tabMiscellaneous";
        this.tabMiscellaneous.Padding = new Padding(3);
        this.tabMiscellaneous.Size = new Size(1021, 653);
        this.tabMiscellaneous.TabIndex = 5;
        this.tabMiscellaneous.Text = "Miscellaneous";
        this.flowLayoutPanel6.Controls.Add(this.cmdSMRefuel);
        this.flowLayoutPanel6.Controls.Add(this.cmdPartialRefuel);
        this.flowLayoutPanel6.Controls.Add(this.cmdAbandonShip);
        this.flowLayoutPanel6.Controls.Add(this.cmdSetHullNumber);
        this.flowLayoutPanel6.Location = new Point(376, 614);
        this.flowLayoutPanel6.Name = "flowLayoutPanel6";
        this.flowLayoutPanel6.Size = new Size(630, 31 /*0x1F*/);
        this.flowLayoutPanel6.TabIndex = 143;
        this.cmdSMRefuel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSMRefuel.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSMRefuel.Location = new Point(0, 0);
        this.cmdSMRefuel.Margin = new Padding(0);
        this.cmdSMRefuel.Name = "cmdSMRefuel";
        this.cmdSMRefuel.Size = new Size(96 /*0x60*/, 30);
        this.cmdSMRefuel.TabIndex = 139;
        this.cmdSMRefuel.Tag = "1200";
        this.cmdSMRefuel.Text = "SM Refuel";
        this.cmdSMRefuel.UseVisualStyleBackColor = false;
        this.cmdSMRefuel.Click += this.cmdSMRefuel_Click;
        this.cmdPartialRefuel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdPartialRefuel.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdPartialRefuel.Location = new Point(96 /*0x60*/, 0);
        this.cmdPartialRefuel.Margin = new Padding(0);
        this.cmdPartialRefuel.Name = "cmdPartialRefuel";
        this.cmdPartialRefuel.Size = new Size(96 /*0x60*/, 30);
        this.cmdPartialRefuel.TabIndex = 140;
        this.cmdPartialRefuel.Tag = "1200";
        this.cmdPartialRefuel.Text = "SM Part Refuel";
        this.cmdPartialRefuel.UseVisualStyleBackColor = false;
        this.cmdPartialRefuel.Click += this.cmdPartialRefuel_Click;
        this.cmdAbandonShip.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAbandonShip.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAbandonShip.Location = new Point(192 /*0xC0*/, 0);
        this.cmdAbandonShip.Margin = new Padding(0);
        this.cmdAbandonShip.Name = "cmdAbandonShip";
        this.cmdAbandonShip.Size = new Size(96 /*0x60*/, 30);
        this.cmdAbandonShip.TabIndex = 141;
        this.cmdAbandonShip.Tag = "1200";
        this.cmdAbandonShip.Text = "Abandon Ship";
        this.cmdAbandonShip.UseVisualStyleBackColor = false;
        this.cmdAbandonShip.Click += this.cmdAbandonShip_Click;
        this.cmdSetHullNumber.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSetHullNumber.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSetHullNumber.Location = new Point(288, 0);
        this.cmdSetHullNumber.Margin = new Padding(0);
        this.cmdSetHullNumber.Name = "cmdSetHullNumber";
        this.cmdSetHullNumber.Size = new Size(96 /*0x60*/, 30);
        this.cmdSetHullNumber.TabIndex = 142;
        this.cmdSetHullNumber.Tag = "1200";
        this.cmdSetHullNumber.Text = "Select Hull Num";
        this.cmdSetHullNumber.UseVisualStyleBackColor = false;
        this.cmdSetHullNumber.Click += this.cmdSetHullNumber_Click;
        this.flowLayoutPanel13.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel13.Controls.Add(this.panel11);
        this.flowLayoutPanel13.Controls.Add(this.panel8);
        this.flowLayoutPanel13.Controls.Add(this.label14);
        this.flowLayoutPanel13.Controls.Add(this.chkRetainData);
        this.flowLayoutPanel13.Controls.Add(this.ckhTarget);
        this.flowLayoutPanel13.Location = new Point(378, 3);
        this.flowLayoutPanel13.Name = "flowLayoutPanel13";
        this.flowLayoutPanel13.Size = new Size(205, 130);
        this.flowLayoutPanel13.TabIndex = 133;
        this.panel11.Controls.Add(this.txtFuelPriority);
        this.panel11.Controls.Add(this.label15);
        this.panel11.Location = new Point(3, 3);
        this.panel11.Name = "panel11";
        this.panel11.Size = new Size(200, 15);
        this.panel11.TabIndex = 120;
        this.txtFuelPriority.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtFuelPriority.BorderStyle = BorderStyle.None;
        this.txtFuelPriority.Dock = DockStyle.Right;
        this.txtFuelPriority.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtFuelPriority.Location = new Point(140, 0);
        this.txtFuelPriority.Name = "txtFuelPriority";
        this.txtFuelPriority.Size = new Size(60, 13);
        this.txtFuelPriority.TabIndex = 105;
        this.txtFuelPriority.Text = "1";
        this.txtFuelPriority.TextAlign = HorizontalAlignment.Center;
        this.txtFuelPriority.TextChanged += this.txtFuelPriority_TextChanged;
        this.label15.AutoSize = true;
        this.label15.Dock = DockStyle.Left;
        this.label15.Location = new Point(0, 0);
        this.label15.Margin = new Padding(3);
        this.label15.Name = "label15";
        this.label15.Size = new Size(72, 13);
        this.label15.TabIndex = 104;
        this.label15.Text = "Refuel Priority";
        this.panel8.Controls.Add(this.txtSupplyPriority);
        this.panel8.Controls.Add(this.label10);
        this.panel8.Location = new Point(3, 24);
        this.panel8.Name = "panel8";
        this.panel8.Size = new Size(200, 15);
        this.panel8.TabIndex = 125;
        this.txtSupplyPriority.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSupplyPriority.BorderStyle = BorderStyle.None;
        this.txtSupplyPriority.Dock = DockStyle.Right;
        this.txtSupplyPriority.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtSupplyPriority.Location = new Point(140, 0);
        this.txtSupplyPriority.Name = "txtSupplyPriority";
        this.txtSupplyPriority.Size = new Size(60, 13);
        this.txtSupplyPriority.TabIndex = 105;
        this.txtSupplyPriority.Text = "1";
        this.txtSupplyPriority.TextAlign = HorizontalAlignment.Center;
        this.txtSupplyPriority.TextChanged += this.txtSupplyPriority_TextChanged;
        this.label10.AutoSize = true;
        this.label10.Dock = DockStyle.Left;
        this.label10.Location = new Point(0, 0);
        this.label10.Margin = new Padding(3);
        this.label10.Name = "label10";
        this.label10.Size = new Size(85, 13);
        this.label10.TabIndex = 104;
        this.label10.Text = "Resupply Priority";
        this.label14.AutoSize = true;
        this.label14.Dock = DockStyle.Left;
        this.label14.Location = new Point(3, 48 /*0x30*/);
        this.label14.Margin = new Padding(3, 6, 3, 12);
        this.label14.Name = "label14";
        this.label14.Size = new Size(118, 13);
        this.label14.TabIndex = 143;
        this.label14.Text = "The Highest Priority is 1";
        this.chkRetainData.AutoSize = true;
        this.chkRetainData.Location = new Point(3, 79);
        this.chkRetainData.Margin = new Padding(3, 6, 3, 3);
        this.chkRetainData.Name = "chkRetainData";
        this.chkRetainData.Padding = new Padding(5, 0, 0, 0);
        this.chkRetainData.Size = new Size(116, 17);
        this.chkRetainData.TabIndex = 142;
        this.chkRetainData.Text = "Retain Tech Data";
        this.chkRetainData.TextAlign = ContentAlignment.MiddleRight;
        this.chkRetainData.UseVisualStyleBackColor = true;
        this.chkRetainData.CheckedChanged += this.chkRetainData_CheckedChanged;
        this.ckhTarget.AutoSize = true;
        this.ckhTarget.Location = new Point(3, 105);
        this.ckhTarget.Margin = new Padding(3, 6, 3, 3);
        this.ckhTarget.Name = "ckhTarget";
        this.ckhTarget.Padding = new Padding(5, 0, 0, 0);
        this.ckhTarget.Size = new Size(127, 17);
        this.ckhTarget.TabIndex = 144 /*0x90*/;
        this.ckhTarget.Text = "Designate as Target";
        this.ckhTarget.TextAlign = ContentAlignment.MiddleRight;
        this.ckhTarget.UseVisualStyleBackColor = true;
        this.ckhTarget.CheckedChanged += this.ckhTarget_CheckedChanged;
        this.flowLayoutPanel11.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel11.Controls.Add(this.label7);
        this.flowLayoutPanel11.Controls.Add(this.lstvWeapons);
        this.flowLayoutPanel11.Controls.Add(this.flowLayoutPanel4);
        this.flowLayoutPanel11.Location = new Point(3, 3);
        this.flowLayoutPanel11.Name = "flowLayoutPanel11";
        this.flowLayoutPanel11.Size = new Size(369, 644);
        this.flowLayoutPanel11.TabIndex = 132;
        this.label7.Location = new Point(3, 3);
        this.label7.Margin = new Padding(3, 3, 3, 9);
        this.label7.Name = "label7";
        this.label7.Size = new Size(360, 13);
        this.label7.TabIndex = 133;
        this.label7.Text = "Manual Damage vs Selected Ship";
        this.label7.TextAlign = ContentAlignment.MiddleCenter;
        this.lstvWeapons.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvWeapons.BorderStyle = BorderStyle.None;
        this.lstvWeapons.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_66,
            this.columnHeader_67,
            this.columnHeader_68
        });
        this.lstvWeapons.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvWeapons.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvWeapons.HideSelection = false;
        this.lstvWeapons.Location = new Point(3, 28);
        this.lstvWeapons.Name = "lstvWeapons";
        this.lstvWeapons.Size = new Size(360, 573);
        this.lstvWeapons.TabIndex = 131;
        this.lstvWeapons.UseCompatibleStateImageBehavior = false;
        this.lstvWeapons.View = View.Details;
        this.columnHeader_66.Width = 230;
        this.columnHeader_67.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_68.TextAlign = HorizontalAlignment.Center;
        this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel12);
        this.flowLayoutPanel4.Controls.Add(this.cmdInternalDamage);
        this.flowLayoutPanel4.Controls.Add(this.cmdDamage);
        this.flowLayoutPanel4.Location = new Point(3, 607);
        this.flowLayoutPanel4.Name = "flowLayoutPanel4";
        this.flowLayoutPanel4.Size = new Size(360, 42);
        this.flowLayoutPanel4.TabIndex = 130;
        this.flowLayoutPanel12.Controls.Add(this.label6);
        this.flowLayoutPanel12.Controls.Add(this.txtManualDamage);
        this.flowLayoutPanel12.Location = new Point(3, 3);
        this.flowLayoutPanel12.Name = "flowLayoutPanel12";
        this.flowLayoutPanel12.Size = new Size(147, 23);
        this.flowLayoutPanel12.TabIndex = 133;
        this.label6.AutoSize = true;
        this.label6.Location = new Point(3, 9);
        this.label6.Margin = new Padding(3, 9, 3, 3);
        this.label6.Name = "label6";
        this.label6.Size = new Size(95, 13);
        this.label6.TabIndex = 4;
        this.label6.Text = "Number of Attacks";
        this.label6.TextAlign = ContentAlignment.MiddleLeft;
        this.txtManualDamage.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtManualDamage.BorderStyle = BorderStyle.None;
        this.txtManualDamage.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtManualDamage.Location = new Point(104, 9);
        this.txtManualDamage.Margin = new Padding(3, 9, 3, 3);
        this.txtManualDamage.Multiline = true;
        this.txtManualDamage.Name = "txtManualDamage";
        this.txtManualDamage.Size = new Size(34, 18);
        this.txtManualDamage.TabIndex = 129;
        this.txtManualDamage.Text = "1";
        this.txtManualDamage.TextAlign = HorizontalAlignment.Center;
        this.cmdInternalDamage.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdInternalDamage.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdInternalDamage.Location = new Point(159, 3);
        this.cmdInternalDamage.Margin = new Padding(6, 3, 0, 0);
        this.cmdInternalDamage.Name = "cmdInternalDamage";
        this.cmdInternalDamage.Size = new Size(96 /*0x60*/, 30);
        this.cmdInternalDamage.TabIndex = 130;
        this.cmdInternalDamage.Tag = "1200";
        this.cmdInternalDamage.Text = "Internal Damage";
        this.cmdInternalDamage.UseVisualStyleBackColor = false;
        this.cmdInternalDamage.Click += this.cmdInternalDamage_Click;
        this.cmdDamage.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDamage.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDamage.Location = new Point(255, 3);
        this.cmdDamage.Margin = new Padding(0, 3, 0, 0);
        this.cmdDamage.Name = "cmdDamage";
        this.cmdDamage.Size = new Size(96 /*0x60*/, 30);
        this.cmdDamage.TabIndex = 128 /*0x80*/;
        this.cmdDamage.Tag = "1200";
        this.cmdDamage.Text = "External Damage";
        this.cmdDamage.UseVisualStyleBackColor = false;
        this.cmdDamage.Click += this.cmdDamage_Click;
        this.tabCombat.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabCombat.Controls.Add(this.flowLayoutPanel25);
        this.tabCombat.Controls.Add(this.flowLayoutPanel32);
        this.tabCombat.Controls.Add(this.tvTargets);
        this.tabCombat.Controls.Add(this.tvCombatAssignment);
        this.tabCombat.Location = new Point(4, 22);
        this.tabCombat.Name = "tabCombat";
        this.tabCombat.Padding = new Padding(3);
        this.tabCombat.Size = new Size(1028, 792);
        this.tabCombat.TabIndex = 6;
        this.tabCombat.Text = "Ship Combat";
        this.flowLayoutPanel25.Controls.Add(this.chkHostileOnly);
        this.flowLayoutPanel25.Controls.Add(this.chkDragAll);
        this.flowLayoutPanel25.Controls.Add(this.chkDragNum);
        this.flowLayoutPanel25.Controls.Add(this.txtAssignNum);
        this.flowLayoutPanel25.Controls.Add(this.cmdOpenFireAll);
        this.flowLayoutPanel25.Controls.Add(this.cmdOpenFire);
        this.flowLayoutPanel25.Controls.Add(this.cmdFleetAtWill);
        this.flowLayoutPanel25.Controls.Add(this.cmdFireAtWillFC);
        this.flowLayoutPanel25.Controls.Add(this.cmdAssignFleet);
        this.flowLayoutPanel25.Controls.Add(this.cmdAssignSubFleet);
        this.flowLayoutPanel25.Controls.Add(this.cmdAssignSystem);
        this.flowLayoutPanel25.Controls.Add(this.cmdAssignAll);
        this.flowLayoutPanel25.Controls.Add(this.cmOpenFireFleet);
        this.flowLayoutPanel25.Controls.Add(this.cmdFleetFireAtWill);
        this.flowLayoutPanel25.Controls.Add(this.cmOpenFireFleetMFC);
        this.flowLayoutPanel25.Controls.Add(this.cmOpenFireFleetBFC);
        this.flowLayoutPanel25.Controls.Add(this.cmdCeaseFireFleet);
        this.flowLayoutPanel25.Controls.Add(this.cmdClearTarget);
        this.flowLayoutPanel25.Controls.Add(this.cmdClearAllTargets);
        this.flowLayoutPanel25.Controls.Add(this.cmdClearFleetTargets);
        this.flowLayoutPanel25.Controls.Add(this.cmdAutoAssign);
        this.flowLayoutPanel25.Controls.Add(this.cmdAutoTargetMFC);
        this.flowLayoutPanel25.Controls.Add(this.cmdAutoTargetBFC);
        this.flowLayoutPanel25.Controls.Add(this.chkDoubleRange);
        this.flowLayoutPanel25.Location = new Point(930, 3);
        this.flowLayoutPanel25.Name = "flowLayoutPanel25";
        this.flowLayoutPanel25.Size = new Size(96 /*0x60*/, 783);
        this.flowLayoutPanel25.TabIndex = 137;
        this.chkHostileOnly.AutoSize = true;
        this.chkHostileOnly.Location = new Point(3, 3);
        this.chkHostileOnly.Name = "chkHostileOnly";
        this.chkHostileOnly.Size = new Size(82, 17);
        this.chkHostileOnly.TabIndex = 117;
        this.chkHostileOnly.Text = "Hostile Only";
        this.chkHostileOnly.UseVisualStyleBackColor = true;
        this.chkDragAll.AutoSize = true;
        this.chkDragAll.Location = new Point(3, 29);
        this.chkDragAll.Margin = new Padding(3, 6, 3, 3);
        this.chkDragAll.Name = "chkDragAll";
        this.chkDragAll.Size = new Size(71, 17);
        this.chkDragAll.TabIndex = 118;
        this.chkDragAll.Text = "Assign All";
        this.chkDragAll.UseVisualStyleBackColor = true;
        this.chkDragNum.AutoSize = true;
        this.chkDragNum.Location = new Point(3, 55);
        this.chkDragNum.Margin = new Padding(3, 6, 0, 3);
        this.chkDragNum.Name = "chkDragNum";
        this.chkDragNum.Size = new Size(67, 17);
        this.chkDragNum.TabIndex = 152;
        this.chkDragNum.Text = "Assign #";
        this.chkDragNum.UseVisualStyleBackColor = true;
        this.txtAssignNum.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAssignNum.BorderStyle = BorderStyle.None;
        this.txtAssignNum.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAssignNum.Location = new Point(70, 56);
        this.txtAssignNum.Margin = new Padding(0, 7, 3, 3);
        this.txtAssignNum.Multiline = true;
        this.txtAssignNum.Name = "txtAssignNum";
        this.txtAssignNum.Size = new Size(19, 18);
        this.txtAssignNum.TabIndex = 138;
        this.txtAssignNum.Text = "10";
        this.txtAssignNum.TextAlign = HorizontalAlignment.Center;
        this.cmdOpenFireAll.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdOpenFireAll.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdOpenFireAll.Location = new Point(0, 89);
        this.cmdOpenFireAll.Margin = new Padding(0, 12, 0, 0);
        this.cmdOpenFireAll.Name = "cmdOpenFireAll";
        this.cmdOpenFireAll.Size = new Size(96 /*0x60*/, 30);
        this.cmdOpenFireAll.TabIndex = 134;
        this.cmdOpenFireAll.Tag = "1200";
        this.cmdOpenFireAll.Text = "Open Fire All";
        this.cmdOpenFireAll.UseVisualStyleBackColor = false;
        this.cmdOpenFireAll.Visible = false;
        this.cmdOpenFireAll.Click += this.cmdOpenFireAll_Click;
        this.cmdOpenFire.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdOpenFire.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdOpenFire.Location = new Point(0, 119);
        this.cmdOpenFire.Margin = new Padding(0);
        this.cmdOpenFire.Name = "cmdOpenFire";
        this.cmdOpenFire.Size = new Size(96 /*0x60*/, 30);
        this.cmdOpenFire.TabIndex = 131;
        this.cmdOpenFire.Tag = "1200";
        this.cmdOpenFire.Text = "Open Fire FC";
        this.cmdOpenFire.UseVisualStyleBackColor = false;
        this.cmdOpenFire.Click += this.cmdOpenFire_Click;
        this.cmdFleetAtWill.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdFleetAtWill.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdFleetAtWill.Location = new Point(0, 149);
        this.cmdFleetAtWill.Margin = new Padding(0);
        this.cmdFleetAtWill.Name = "cmdFleetAtWill";
        this.cmdFleetAtWill.Size = new Size(96 /*0x60*/, 30);
        this.cmdFleetAtWill.TabIndex = 135;
        this.cmdFleetAtWill.Tag = "1200";
        this.cmdFleetAtWill.Text = "Fire at Will";
        this.cmdFleetAtWill.UseVisualStyleBackColor = false;
        this.cmdFleetAtWill.Click += this.cmdFleetAtWill_Click;
        this.cmdFireAtWillFC.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdFireAtWillFC.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdFireAtWillFC.Location = new Point(0, 179);
        this.cmdFireAtWillFC.Margin = new Padding(0);
        this.cmdFireAtWillFC.Name = "cmdFireAtWillFC";
        this.cmdFireAtWillFC.Size = new Size(96 /*0x60*/, 30);
        this.cmdFireAtWillFC.TabIndex = 136;
        this.cmdFireAtWillFC.Tag = "1200";
        this.cmdFireAtWillFC.Text = "Fire at Will FC";
        this.cmdFireAtWillFC.UseVisualStyleBackColor = false;
        this.cmdFireAtWillFC.Click += this.cmdFireAtWillFC_Click;
        this.cmdAssignFleet.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAssignFleet.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAssignFleet.Location = new Point(0, 221);
        this.cmdAssignFleet.Margin = new Padding(0, 12, 0, 0);
        this.cmdAssignFleet.Name = "cmdAssignFleet";
        this.cmdAssignFleet.Size = new Size(96 /*0x60*/, 30);
        this.cmdAssignFleet.TabIndex = 135;
        this.cmdAssignFleet.Tag = "1200";
        this.cmdAssignFleet.Text = "Assign Fleet";
        this.cmdAssignFleet.UseVisualStyleBackColor = false;
        this.cmdAssignFleet.Click += this.cmdAssignFleet_Click;
        this.cmdAssignSubFleet.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAssignSubFleet.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAssignSubFleet.Location = new Point(0, 251);
        this.cmdAssignSubFleet.Margin = new Padding(0);
        this.cmdAssignSubFleet.Name = "cmdAssignSubFleet";
        this.cmdAssignSubFleet.Size = new Size(96 /*0x60*/, 30);
        this.cmdAssignSubFleet.TabIndex = 136;
        this.cmdAssignSubFleet.Tag = "1200";
        this.cmdAssignSubFleet.Text = "Assign Sub Fleet";
        this.cmdAssignSubFleet.UseVisualStyleBackColor = false;
        this.cmdAssignSubFleet.Click += this.cmdAssignSubFleet_Click;
        this.cmdAssignSystem.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAssignSystem.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAssignSystem.Location = new Point(0, 281);
        this.cmdAssignSystem.Margin = new Padding(0);
        this.cmdAssignSystem.Name = "cmdAssignSystem";
        this.cmdAssignSystem.Size = new Size(96 /*0x60*/, 30);
        this.cmdAssignSystem.TabIndex = 137;
        this.cmdAssignSystem.Tag = "1200";
        this.cmdAssignSystem.Text = "Assign System";
        this.cmdAssignSystem.UseVisualStyleBackColor = false;
        this.cmdAssignSystem.Click += this.cmdAssignSystem_Click;
        this.cmdAssignAll.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAssignAll.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAssignAll.Location = new Point(0, 311);
        this.cmdAssignAll.Margin = new Padding(0);
        this.cmdAssignAll.Name = "cmdAssignAll";
        this.cmdAssignAll.Size = new Size(96 /*0x60*/, 30);
        this.cmdAssignAll.TabIndex = 138;
        this.cmdAssignAll.Tag = "1200";
        this.cmdAssignAll.Text = "Assign All";
        this.cmdAssignAll.UseVisualStyleBackColor = false;
        this.cmdAssignAll.Click += this.cmdAssignAll_Click;
        this.cmOpenFireFleet.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmOpenFireFleet.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmOpenFireFleet.Location = new Point(0, 353);
        this.cmOpenFireFleet.Margin = new Padding(0, 12, 0, 0);
        this.cmOpenFireFleet.Name = "cmOpenFireFleet";
        this.cmOpenFireFleet.Size = new Size(96 /*0x60*/, 30);
        this.cmOpenFireFleet.TabIndex = 143;
        this.cmOpenFireFleet.Tag = "1200";
        this.cmOpenFireFleet.Text = "Open Fire Fleet";
        this.cmOpenFireFleet.UseVisualStyleBackColor = false;
        this.cmOpenFireFleet.Click += this.cmOpenFireFleet_Click;
        this.cmdFleetFireAtWill.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdFleetFireAtWill.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdFleetFireAtWill.Location = new Point(0, 383);
        this.cmdFleetFireAtWill.Margin = new Padding(0);
        this.cmdFleetFireAtWill.Name = "cmdFleetFireAtWill";
        this.cmdFleetFireAtWill.Size = new Size(96 /*0x60*/, 30);
        this.cmdFleetFireAtWill.TabIndex = 147;
        this.cmdFleetFireAtWill.Tag = "1200";
        this.cmdFleetFireAtWill.Text = "Fleet Fire at Will";
        this.cmdFleetFireAtWill.UseVisualStyleBackColor = false;
        this.cmdFleetFireAtWill.Click += this.cmdFleetFireAtWill_Click;
        this.cmOpenFireFleetMFC.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmOpenFireFleetMFC.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmOpenFireFleetMFC.Location = new Point(0, 413);
        this.cmOpenFireFleetMFC.Margin = new Padding(0);
        this.cmOpenFireFleetMFC.Name = "cmOpenFireFleetMFC";
        this.cmOpenFireFleetMFC.Size = new Size(96 /*0x60*/, 30);
        this.cmOpenFireFleetMFC.TabIndex = 145;
        this.cmOpenFireFleetMFC.Tag = "1200";
        this.cmOpenFireFleetMFC.Text = "Fire Fleet MFC";
        this.cmOpenFireFleetMFC.UseVisualStyleBackColor = false;
        this.cmOpenFireFleetMFC.Click += this.cmOpenFireFleetMFC_Click;
        this.cmOpenFireFleetBFC.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmOpenFireFleetBFC.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmOpenFireFleetBFC.Location = new Point(0, 443);
        this.cmOpenFireFleetBFC.Margin = new Padding(0);
        this.cmOpenFireFleetBFC.Name = "cmOpenFireFleetBFC";
        this.cmOpenFireFleetBFC.Size = new Size(96 /*0x60*/, 30);
        this.cmOpenFireFleetBFC.TabIndex = 146;
        this.cmOpenFireFleetBFC.Tag = "1200";
        this.cmOpenFireFleetBFC.Text = "Fire Fleet BFC";
        this.cmOpenFireFleetBFC.UseVisualStyleBackColor = false;
        this.cmOpenFireFleetBFC.Click += this.cmOpenFireFleetBFC_Click;
        this.cmdCeaseFireFleet.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCeaseFireFleet.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCeaseFireFleet.Location = new Point(0, 473);
        this.cmdCeaseFireFleet.Margin = new Padding(0);
        this.cmdCeaseFireFleet.Name = "cmdCeaseFireFleet";
        this.cmdCeaseFireFleet.Size = new Size(96 /*0x60*/, 30);
        this.cmdCeaseFireFleet.TabIndex = 144 /*0x90*/;
        this.cmdCeaseFireFleet.Tag = "1200";
        this.cmdCeaseFireFleet.Text = "Cease Fire Fleet";
        this.cmdCeaseFireFleet.UseVisualStyleBackColor = false;
        this.cmdCeaseFireFleet.Click += this.cmdCeaseFireFleet_Click;
        this.cmdClearTarget.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdClearTarget.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdClearTarget.Location = new Point(0, 515);
        this.cmdClearTarget.Margin = new Padding(0, 12, 0, 0);
        this.cmdClearTarget.Name = "cmdClearTarget";
        this.cmdClearTarget.Size = new Size(96 /*0x60*/, 30);
        this.cmdClearTarget.TabIndex = 150;
        this.cmdClearTarget.Tag = "1200";
        this.cmdClearTarget.Text = "Clear Target";
        this.cmdClearTarget.UseVisualStyleBackColor = false;
        this.cmdClearTarget.Click += this.cmdClearTarget_Click;
        this.cmdClearAllTargets.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdClearAllTargets.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdClearAllTargets.Location = new Point(0, 545);
        this.cmdClearAllTargets.Margin = new Padding(0);
        this.cmdClearAllTargets.Name = "cmdClearAllTargets";
        this.cmdClearAllTargets.Size = new Size(96 /*0x60*/, 30);
        this.cmdClearAllTargets.TabIndex = 151;
        this.cmdClearAllTargets.Tag = "1200";
        this.cmdClearAllTargets.Text = "Clear All Targets";
        this.cmdClearAllTargets.UseVisualStyleBackColor = false;
        this.cmdClearAllTargets.Click += this.cmdClearAllTargets_Click;
        this.cmdClearFleetTargets.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdClearFleetTargets.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdClearFleetTargets.Location = new Point(0, 575);
        this.cmdClearFleetTargets.Margin = new Padding(0);
        this.cmdClearFleetTargets.Name = "cmdClearFleetTargets";
        this.cmdClearFleetTargets.Size = new Size(96 /*0x60*/, 30);
        this.cmdClearFleetTargets.TabIndex = 153;
        this.cmdClearFleetTargets.Tag = "1200";
        this.cmdClearFleetTargets.Text = "Clear Fleet Tgts";
        this.cmdClearFleetTargets.UseVisualStyleBackColor = false;
        this.cmdClearFleetTargets.Click += this.cmdClearFleetTargets_Click;
        this.cmdAutoAssign.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAutoAssign.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAutoAssign.Location = new Point(0, 617);
        this.cmdAutoAssign.Margin = new Padding(0, 12, 0, 0);
        this.cmdAutoAssign.Name = "cmdAutoAssign";
        this.cmdAutoAssign.Size = new Size(96 /*0x60*/, 30);
        this.cmdAutoAssign.TabIndex = 141;
        this.cmdAutoAssign.Tag = "1200";
        this.cmdAutoAssign.Text = "Auto Assign FC";
        this.cmdAutoAssign.UseVisualStyleBackColor = false;
        this.cmdAutoAssign.Click += this.cmdAutoAssign_Click;
        this.cmdAutoTargetMFC.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAutoTargetMFC.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAutoTargetMFC.Location = new Point(0, 659);
        this.cmdAutoTargetMFC.Margin = new Padding(0, 12, 0, 0);
        this.cmdAutoTargetMFC.Name = "cmdAutoTargetMFC";
        this.cmdAutoTargetMFC.Size = new Size(96 /*0x60*/, 30);
        this.cmdAutoTargetMFC.TabIndex = 147;
        this.cmdAutoTargetMFC.Tag = "1200";
        this.cmdAutoTargetMFC.Text = "Auto Target MFC";
        this.cmdAutoTargetMFC.UseVisualStyleBackColor = false;
        this.cmdAutoTargetMFC.Click += this.cmdAutoTargetMFC_Click;
        this.cmdAutoTargetBFC.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAutoTargetBFC.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAutoTargetBFC.Location = new Point(0, 689);
        this.cmdAutoTargetBFC.Margin = new Padding(0);
        this.cmdAutoTargetBFC.Name = "cmdAutoTargetBFC";
        this.cmdAutoTargetBFC.Size = new Size(96 /*0x60*/, 30);
        this.cmdAutoTargetBFC.TabIndex = 148;
        this.cmdAutoTargetBFC.Tag = "1200";
        this.cmdAutoTargetBFC.Text = "Auto Target BFC";
        this.cmdAutoTargetBFC.UseVisualStyleBackColor = false;
        this.cmdAutoTargetBFC.Click += this.cmdAutoTargetBFC_Click;
        this.chkDoubleRange.AutoSize = true;
        this.chkDoubleRange.Location = new Point(3, 728);
        this.chkDoubleRange.Margin = new Padding(3, 9, 3, 3);
        this.chkDoubleRange.Name = "chkDoubleRange";
        this.chkDoubleRange.Size = new Size(72, 17);
        this.chkDoubleRange.TabIndex = 149;
        this.chkDoubleRange.Text = "Range x2";
        this.chkDoubleRange.UseVisualStyleBackColor = true;
        this.flowLayoutPanel32.Controls.Add(this.cmdSyncFire);
        this.flowLayoutPanel32.Controls.Add(this.cmdFleetSync);
        this.flowLayoutPanel32.Controls.Add(this.cmdFleetSyncOff);
        this.flowLayoutPanel32.Controls.Add(this.cmdMinAMMRange);
        this.flowLayoutPanel32.Controls.Add(this.cmdDecoyThreshold);
        this.flowLayoutPanel32.Location = new Point(3, 760);
        this.flowLayoutPanel32.Name = "flowLayoutPanel32";
        this.flowLayoutPanel32.Size = new Size(820, 30);
        this.flowLayoutPanel32.TabIndex = 136;
        this.cmdSyncFire.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSyncFire.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSyncFire.Location = new Point(0, 0);
        this.cmdSyncFire.Margin = new Padding(0);
        this.cmdSyncFire.Name = "cmdSyncFire";
        this.cmdSyncFire.Size = new Size(96 /*0x60*/, 30);
        this.cmdSyncFire.TabIndex = 139;
        this.cmdSyncFire.Tag = "1200";
        this.cmdSyncFire.Text = "Sync Fire On";
        this.cmdSyncFire.UseVisualStyleBackColor = false;
        this.cmdSyncFire.Click += this.cmdSyncFire_Click;
        this.cmdFleetSync.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdFleetSync.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdFleetSync.Location = new Point(96 /*0x60*/, 0);
        this.cmdFleetSync.Margin = new Padding(0);
        this.cmdFleetSync.Name = "cmdFleetSync";
        this.cmdFleetSync.Size = new Size(96 /*0x60*/, 30);
        this.cmdFleetSync.TabIndex = 140;
        this.cmdFleetSync.Tag = "1200";
        this.cmdFleetSync.Text = "Fleet Sync On";
        this.cmdFleetSync.UseVisualStyleBackColor = false;
        this.cmdFleetSync.Click += this.cmdFleetSync_Click;
        this.cmdFleetSyncOff.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdFleetSyncOff.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdFleetSyncOff.Location = new Point(192 /*0xC0*/, 0);
        this.cmdFleetSyncOff.Margin = new Padding(0);
        this.cmdFleetSyncOff.Name = "cmdFleetSyncOff";
        this.cmdFleetSyncOff.Size = new Size(96 /*0x60*/, 30);
        this.cmdFleetSyncOff.TabIndex = 142;
        this.cmdFleetSyncOff.Tag = "1200";
        this.cmdFleetSyncOff.Text = "Fleet Sync Off";
        this.cmdFleetSyncOff.UseVisualStyleBackColor = false;
        this.cmdFleetSyncOff.Click += this.cmdFleetSyncOff_Click;
        this.cmdMinAMMRange.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdMinAMMRange.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdMinAMMRange.Location = new Point(288, 0);
        this.cmdMinAMMRange.Margin = new Padding(0);
        this.cmdMinAMMRange.Name = "cmdMinAMMRange";
        this.cmdMinAMMRange.Size = new Size(96 /*0x60*/, 30);
        this.cmdMinAMMRange.TabIndex = 143;
        this.cmdMinAMMRange.Tag = "1200";
        this.cmdMinAMMRange.Text = "Min AMM Range";
        this.cmdMinAMMRange.UseVisualStyleBackColor = false;
        this.cmdMinAMMRange.Click += this.cmdMinAMMRange_Click;
        this.cmdDecoyThreshold.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDecoyThreshold.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDecoyThreshold.Location = new Point(384, 0);
        this.cmdDecoyThreshold.Margin = new Padding(0);
        this.cmdDecoyThreshold.Name = "cmdDecoyThreshold";
        this.cmdDecoyThreshold.Size = new Size(96 /*0x60*/, 30);
        this.cmdDecoyThreshold.TabIndex = 144 /*0x90*/;
        this.cmdDecoyThreshold.Tag = "1200";
        this.cmdDecoyThreshold.Text = "Decoy Threshold";
        this.cmdDecoyThreshold.UseVisualStyleBackColor = false;
        this.cmdDecoyThreshold.Click += this.cmdDecoyThreshold_Click;
        this.tvTargets.AllowDrop = true;
        this.tvTargets.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvTargets.BorderStyle = BorderStyle.FixedSingle;
        this.tvTargets.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvTargets.HideSelection = false;
        this.tvTargets.Location = new Point(546, 3);
        this.tvTargets.Margin = new Padding(3, 0, 0, 3);
        this.tvTargets.Name = "tvTargets";
        this.tvTargets.Size = new Size(381, 754);
        this.tvTargets.TabIndex = 119;
        this.tvTargets.AfterCollapse += this.tvTargets_AfterCollapse;
        this.tvTargets.AfterExpand += this.tvTargets_AfterExpand;
        this.tvTargets.ItemDrag += this.tvTargets_ItemDrag;
        this.tvTargets.AfterSelect += this.tvTargets_AfterSelect;
        this.tvTargets.DragEnter += this.tvTargets_DragEnter;
        this.tvCombatAssignment.AllowDrop = true;
        this.tvCombatAssignment.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvCombatAssignment.BorderStyle = BorderStyle.FixedSingle;
        this.tvCombatAssignment.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvCombatAssignment.HideSelection = false;
        this.tvCombatAssignment.Location = new Point(3, 3);
        this.tvCombatAssignment.Margin = new Padding(3, 0, 0, 3);
        this.tvCombatAssignment.Name = "tvCombatAssignment";
        this.tvCombatAssignment.Size = new Size(540, 754);
        this.tvCombatAssignment.TabIndex = 115;
        this.tvCombatAssignment.AfterCollapse += this.tvCombatAssignment_AfterCollapse;
        this.tvCombatAssignment.AfterExpand += this.tvCombatAssignment_AfterExpand;
        this.tvCombatAssignment.ItemDrag += this.tvCombatAssignment_ItemDrag;
        this.tvCombatAssignment.AfterSelect += this.tvCombatAssignment_AfterSelect;
        this.tvCombatAssignment.DragDrop += this.tvCombatAssignment_DragDrop;
        this.tvCombatAssignment.DragEnter += this.tvCombatAssignment_DragEnter;
        this.tabAdminCommand.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabAdminCommand.Controls.Add(this.panel3);
        this.tabAdminCommand.Controls.Add(this.lblNACCommander);
        this.tabAdminCommand.Controls.Add(this.textBox1);
        this.tabAdminCommand.Controls.Add(this.label2);
        this.tabAdminCommand.Controls.Add(this.cmdUpdateAdmin);
        this.tabAdminCommand.Controls.Add(this.cmdCreateAdmin);
        this.tabAdminCommand.Controls.Add(this.lstvPopulation);
        this.tabAdminCommand.Controls.Add(this.lstvNACTypes);
        this.tabAdminCommand.Controls.Add(this.lstvAdminCommandSystems);
        this.tabAdminCommand.Location = new Point(4, 22);
        this.tabAdminCommand.Name = "tabAdminCommand";
        this.tabAdminCommand.Size = new Size(1028, 792);
        this.tabAdminCommand.TabIndex = 7;
        this.tabAdminCommand.Text = "Admin Command";
        this.panel3.BorderStyle = BorderStyle.FixedSingle;
        this.panel3.Controls.Add(this.cmdReassignAllGovernors);
        this.panel3.Controls.Add(this.cmdAssignGovernors);
        this.panel3.Controls.Add(this.cmdSelectGovernor);
        this.panel3.Controls.Add(this.flowLayoutPanel27);
        this.panel3.Controls.Add(this.label37);
        this.panel3.Controls.Add(this.txtImportance);
        this.panel3.Controls.Add(this.chkAutoAssign);
        this.panel3.Location = new Point(448, 404);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(577, 148);
        this.panel3.TabIndex = 134;
        this.cmdReassignAllGovernors.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdReassignAllGovernors.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdReassignAllGovernors.Location = new Point(367, 104);
        this.cmdReassignAllGovernors.Margin = new Padding(12, 6, 0, 0);
        this.cmdReassignAllGovernors.Name = "cmdReassignAllGovernors";
        this.cmdReassignAllGovernors.Size = new Size(186, 30);
        this.cmdReassignAllGovernors.TabIndex = 135;
        this.cmdReassignAllGovernors.Tag = "1200";
        this.cmdReassignAllGovernors.Text = "Reassign All Admin Commands";
        this.cmdReassignAllGovernors.UseVisualStyleBackColor = false;
        this.cmdReassignAllGovernors.Click += this.cmdReassignAllGovernors_Click;
        this.cmdAssignGovernors.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAssignGovernors.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAssignGovernors.Location = new Point(367, 72);
        this.cmdAssignGovernors.Margin = new Padding(12, 6, 0, 0);
        this.cmdAssignGovernors.Name = "cmdAssignGovernors";
        this.cmdAssignGovernors.Size = new Size(186, 30);
        this.cmdAssignGovernors.TabIndex = 136;
        this.cmdAssignGovernors.Tag = "1200";
        this.cmdAssignGovernors.Text = "Assign Admin Vacancies";
        this.cmdAssignGovernors.UseVisualStyleBackColor = false;
        this.cmdAssignGovernors.Click += this.cmdAssignGovernors_Click;
        this.cmdSelectGovernor.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSelectGovernor.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSelectGovernor.Location = new Point(367, 40);
        this.cmdSelectGovernor.Margin = new Padding(30, 6, 0, 0);
        this.cmdSelectGovernor.Name = "cmdSelectGovernor";
        this.cmdSelectGovernor.Size = new Size(186, 30);
        this.cmdSelectGovernor.TabIndex = 134;
        this.cmdSelectGovernor.Tag = "1200";
        this.cmdSelectGovernor.Text = "Assign Admin Commander";
        this.cmdSelectGovernor.UseVisualStyleBackColor = false;
        this.cmdSelectGovernor.Click += this.cmdSelectGovernor_Click;
        this.flowLayoutPanel27.Controls.Add(this.flowLayoutPanel24);
        this.flowLayoutPanel27.Controls.Add(this.flowLayoutPanel26);
        this.flowLayoutPanel27.Location = new Point(3, 30);
        this.flowLayoutPanel27.Name = "flowLayoutPanel27";
        this.flowLayoutPanel27.Size = new Size(331, 113);
        this.flowLayoutPanel27.TabIndex = 135;
        this.flowLayoutPanel24.Controls.Add(this.label39);
        this.flowLayoutPanel24.Controls.Add(this.label36);
        this.flowLayoutPanel24.Controls.Add(this.label40);
        this.flowLayoutPanel24.Controls.Add(this.label9);
        this.flowLayoutPanel24.Location = new Point(3, 3);
        this.flowLayoutPanel24.Name = "flowLayoutPanel24";
        this.flowLayoutPanel24.Size = new Size(108, 110);
        this.flowLayoutPanel24.TabIndex = 134;
        this.label39.AutoSize = true;
        this.label39.Location = new Point(3, 3);
        this.label39.Margin = new Padding(3);
        this.label39.Name = "label39";
        this.label39.Padding = new Padding(0, 5, 5, 0);
        this.label39.Size = new Size(88, 18);
        this.label39.TabIndex = 126;
        this.label39.Text = "Required Bonus";
        this.label36.AutoSize = true;
        this.label36.Location = new Point(3, 30);
        this.label36.Margin = new Padding(3, 6, 3, 3);
        this.label36.Name = "label36";
        this.label36.Padding = new Padding(0, 5, 5, 0);
        this.label36.Size = new Size(96 /*0x60*/, 18);
        this.label36.TabIndex = 127;
        this.label36.Text = "Secondary Bonus";
        this.label40.AutoSize = true;
        this.label40.Location = new Point(3, 57);
        this.label40.Margin = new Padding(3, 6, 3, 3);
        this.label40.Name = "label40";
        this.label40.Padding = new Padding(0, 5, 5, 0);
        this.label40.Size = new Size(80 /*0x50*/, 18);
        this.label40.TabIndex = 128 /*0x80*/;
        this.label40.Text = "Tertiary Bonus";
        this.label9.AutoSize = true;
        this.label9.Location = new Point(3, 84);
        this.label9.Margin = new Padding(3, 6, 3, 3);
        this.label9.Name = "label9";
        this.label9.Padding = new Padding(0, 5, 5, 0);
        this.label9.Size = new Size(82, 18);
        this.label9.TabIndex = 129;
        this.label9.Text = "Minimum Rank";
        this.flowLayoutPanel26.Controls.Add(this.cboBonusOne);
        this.flowLayoutPanel26.Controls.Add(this.cboBonusTwo);
        this.flowLayoutPanel26.Controls.Add(this.cboBonusThree);
        this.flowLayoutPanel26.Controls.Add(this.cboNavalRanks);
        this.flowLayoutPanel26.Location = new Point(117, 3);
        this.flowLayoutPanel26.Name = "flowLayoutPanel26";
        this.flowLayoutPanel26.Size = new Size(207, 110);
        this.flowLayoutPanel26.TabIndex = 135;
        this.cboBonusOne.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboBonusOne.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboBonusOne.FormattingEnabled = true;
        this.cboBonusOne.Location = new Point(3, 3);
        this.cboBonusOne.Margin = new Padding(3, 3, 20, 3);
        this.cboBonusOne.Name = "cboBonusOne";
        this.cboBonusOne.Size = new Size(200, 21);
        this.cboBonusOne.TabIndex = 120;
        this.cboBonusOne.SelectedIndexChanged += this.cboBonusOne_SelectedIndexChanged;
        this.cboBonusTwo.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboBonusTwo.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboBonusTwo.FormattingEnabled = true;
        this.cboBonusTwo.Location = new Point(3, 30);
        this.cboBonusTwo.Name = "cboBonusTwo";
        this.cboBonusTwo.Size = new Size(200, 21);
        this.cboBonusTwo.TabIndex = 121;
        this.cboBonusTwo.SelectedIndexChanged += this.cboBonusTwo_SelectedIndexChanged;
        this.cboBonusThree.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboBonusThree.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboBonusThree.FormattingEnabled = true;
        this.cboBonusThree.Location = new Point(3, 57);
        this.cboBonusThree.Name = "cboBonusThree";
        this.cboBonusThree.Size = new Size(200, 21);
        this.cboBonusThree.TabIndex = 122;
        this.cboBonusThree.SelectedIndexChanged += this.cboBonusThree_SelectedIndexChanged;
        this.cboNavalRanks.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboNavalRanks.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboNavalRanks.FormattingEnabled = true;
        this.cboNavalRanks.Location = new Point(3, 84);
        this.cboNavalRanks.Name = "cboNavalRanks";
        this.cboNavalRanks.Size = new Size(200, 21);
        this.cboNavalRanks.TabIndex = 136;
        this.cboNavalRanks.SelectedIndexChanged += this.cboNavalRanks_SelectedIndexChanged;
        this.label37.AutoSize = true;
        this.label37.Location = new Point(283, 2);
        this.label37.Margin = new Padding(60, 0, 3, 3);
        this.label37.Name = "label37";
        this.label37.Padding = new Padding(0, 5, 5, 0);
        this.label37.Size = new Size(174, 18);
        this.label37.TabIndex = 125;
        this.label37.Text = "Admin Command Priority (1 = High)";
        this.txtImportance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtImportance.BorderStyle = BorderStyle.None;
        this.txtImportance.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtImportance.Location = new Point(459, 7);
        this.txtImportance.Margin = new Padding(0, 5, 3, 3);
        this.txtImportance.Name = "txtImportance";
        this.txtImportance.Size = new Size(31 /*0x1F*/, 13);
        this.txtImportance.TabIndex = 124;
        this.txtImportance.Text = "1";
        this.txtImportance.TextAlign = HorizontalAlignment.Center;
        this.txtImportance.TextChanged += this.txtImportance_TextChanged;
        this.chkAutoAssign.AutoSize = true;
        this.chkAutoAssign.CheckAlign = ContentAlignment.MiddleRight;
        this.chkAutoAssign.Location = new Point(2, 6);
        this.chkAutoAssign.Margin = new Padding(2, 4, 3, 6);
        this.chkAutoAssign.Name = "chkAutoAssign";
        this.chkAutoAssign.Size = new Size(231, 17);
        this.chkAutoAssign.TabIndex = 123;
        this.chkAutoAssign.Text = "Automated Assignment for Admin Command";
        this.chkAutoAssign.UseVisualStyleBackColor = true;
        this.chkAutoAssign.CheckedChanged += this.chkAutoAssign_CheckedChanged;
        this.lblNACCommander.Location = new Point(3, 11);
        this.lblNACCommander.Margin = new Padding(3);
        this.lblNACCommander.Name = "lblNACCommander";
        this.lblNACCommander.Size = new Size(1025, 13);
        this.lblNACCommander.TabIndex = 132;
        this.lblNACCommander.Text = "Commander: ";
        this.textBox1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox1.BorderStyle = BorderStyle.FixedSingle;
        this.textBox1.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox1.Location = new Point(3, 729);
        this.textBox1.Multiline = true;
        this.textBox1.Name = "textBox1";
        this.textBox1.ReadOnly = true;
        this.textBox1.Size = new Size(922, 60);
        this.textBox1.TabIndex = 128 /*0x80*/;
        this.textBox1.Text = componentResourceManager.GetString("textBox1.Text");
        this.label2.AutoSize = true;
        this.label2.Location = new Point(448, 732);
        this.label2.Name = "label2";
        this.label2.Size = new Size(0, 13);
        this.label2.TabIndex = 127;
        this.cmdUpdateAdmin.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdUpdateAdmin.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdUpdateAdmin.Location = new Point(928, 759);
        this.cmdUpdateAdmin.Margin = new Padding(0);
        this.cmdUpdateAdmin.Name = "cmdUpdateAdmin";
        this.cmdUpdateAdmin.Size = new Size(96 /*0x60*/, 30);
        this.cmdUpdateAdmin.TabIndex = 126;
        this.cmdUpdateAdmin.Tag = "1200";
        this.cmdUpdateAdmin.Text = "Update Admin";
        this.cmdUpdateAdmin.UseVisualStyleBackColor = false;
        this.cmdUpdateAdmin.Click += this.cmdUpdateAdmin_Click;
        this.cmdCreateAdmin.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreateAdmin.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreateAdmin.Location = new Point(928, 729);
        this.cmdCreateAdmin.Margin = new Padding(0);
        this.cmdCreateAdmin.Name = "cmdCreateAdmin";
        this.cmdCreateAdmin.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreateAdmin.TabIndex = 125;
        this.cmdCreateAdmin.Tag = "1200";
        this.cmdCreateAdmin.Text = "Create Admin";
        this.cmdCreateAdmin.UseVisualStyleBackColor = false;
        this.cmdCreateAdmin.Click += this.cmdCreateAdmin_Click;
        this.lstvPopulation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvPopulation.BorderStyle = BorderStyle.FixedSingle;
        this.lstvPopulation.Columns.AddRange(new ColumnHeader[4]
        {
            this.columnHeader_31,
            this.columnHeader_32,
            this.columnHeader_33,
            this.columnHeader_34
        });
        this.lstvPopulation.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvPopulation.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvPopulation.HideSelection = false;
        this.lstvPopulation.Location = new Point(448, 30);
        this.lstvPopulation.Name = "lstvPopulation";
        this.lstvPopulation.Size = new Size(577, 368);
        this.lstvPopulation.TabIndex = 54;
        this.lstvPopulation.UseCompatibleStateImageBehavior = false;
        this.lstvPopulation.View = View.Details;
        this.lstvPopulation.SelectedIndexChanged += this.lstvPopulation_SelectedIndexChanged;
        this.columnHeader_31.Width = 220;
        this.columnHeader_32.Width = 200;
        this.columnHeader_33.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_33.Width = 70;
        this.columnHeader_34.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_34.Width = 70;
        this.lstvNACTypes.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvNACTypes.BorderStyle = BorderStyle.FixedSingle;
        this.lstvNACTypes.Columns.AddRange(new ColumnHeader[11]
        {
            this.columnHeader_23,
            this.columnHeader_24,
            this.columnHeader_25,
            this.columnHeader_26,
            this.columnHeader_27,
            this.columnHeader_28,
            this.columnHeader_29,
            this.columnHeader_30,
            this.columnHeader_35,
            this.columnHeader_36,
            this.columnHeader_37
        });
        this.lstvNACTypes.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvNACTypes.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvNACTypes.HideSelection = false;
        this.lstvNACTypes.Location = new Point(3, 558);
        this.lstvNACTypes.Name = "lstvNACTypes";
        this.lstvNACTypes.Size = new Size(1022, 168);
        this.lstvNACTypes.TabIndex = 53;
        this.lstvNACTypes.UseCompatibleStateImageBehavior = false;
        this.lstvNACTypes.View = View.Details;
        this.lstvNACTypes.SelectedIndexChanged += this.lstvNACTypes_SelectedIndexChanged;
        this.columnHeader_23.Width = 140;
        this.columnHeader_24.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_24.Width = 80 /*0x50*/;
        this.columnHeader_25.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_25.Width = 80 /*0x50*/;
        this.columnHeader_26.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_26.Width = 80 /*0x50*/;
        this.columnHeader_27.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_27.Width = 80 /*0x50*/;
        this.columnHeader_28.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_28.Width = 80 /*0x50*/;
        this.columnHeader_29.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_29.Width = 80 /*0x50*/;
        this.columnHeader_30.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_30.Width = 80 /*0x50*/;
        this.columnHeader_35.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_35.Width = 80 /*0x50*/;
        this.columnHeader_36.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_36.Width = 80 /*0x50*/;
        this.columnHeader_37.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_37.Width = 80 /*0x50*/;
        this.lstvAdminCommandSystems.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvAdminCommandSystems.BorderStyle = BorderStyle.FixedSingle;
        this.lstvAdminCommandSystems.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_20,
            this.columnHeader_21,
            this.columnHeader_22
        });
        this.lstvAdminCommandSystems.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvAdminCommandSystems.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvAdminCommandSystems.HideSelection = false;
        this.lstvAdminCommandSystems.Location = new Point(3, 30);
        this.lstvAdminCommandSystems.Name = "lstvAdminCommandSystems";
        this.lstvAdminCommandSystems.Size = new Size(439, 522);
        this.lstvAdminCommandSystems.TabIndex = 52;
        this.lstvAdminCommandSystems.UseCompatibleStateImageBehavior = false;
        this.lstvAdminCommandSystems.View = View.Details;
        this.columnHeader_20.Width = 250;
        this.columnHeader_21.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_21.Width = 80 /*0x50*/;
        this.columnHeader_22.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_22.Width = 80 /*0x50*/;
        this.tabLogistics.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabLogistics.Controls.Add(this.cboSortType);
        this.tabLogistics.Controls.Add(this.flowLayoutPanel16);
        this.tabLogistics.Controls.Add(this.lstvLogisticsReport);
        this.tabLogistics.Location = new Point(4, 22);
        this.tabLogistics.Name = "tabLogistics";
        this.tabLogistics.Padding = new Padding(3);
        this.tabLogistics.Size = new Size(1028, 792);
        this.tabLogistics.TabIndex = 4;
        this.tabLogistics.Text = "Logistics Report";
        this.cboSortType.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSortType.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboSortType.FormattingEnabled = true;
        this.cboSortType.Location = new Point(3, 7);
        this.cboSortType.Margin = new Padding(3, 3, 3, 0);
        this.cboSortType.Name = "cboSortType";
        this.cboSortType.Size = new Size(245, 21);
        this.cboSortType.TabIndex = 131;
        this.cboSortType.SelectedIndexChanged += this.chkLogNonArmed_CheckedChanged;
        this.flowLayoutPanel16.Controls.Add(this.chkLogSupplyShip);
        this.flowLayoutPanel16.Controls.Add(this.chkLogExcTanker);
        this.flowLayoutPanel16.Controls.Add(this.chkLogExcludeFighter);
        this.flowLayoutPanel16.Controls.Add(this.chkLogExcludeFAC);
        this.flowLayoutPanel16.Controls.Add(this.chkLogExcludeSY);
        this.flowLayoutPanel16.Controls.Add(this.chkLogNonArmed);
        this.flowLayoutPanel16.FlowDirection = FlowDirection.RightToLeft;
        this.flowLayoutPanel16.Location = new Point(262, 7);
        this.flowLayoutPanel16.Name = "flowLayoutPanel16";
        this.flowLayoutPanel16.Size = new Size(758, 20);
        this.flowLayoutPanel16.TabIndex = 130;
        this.chkLogSupplyShip.AutoSize = true;
        this.chkLogSupplyShip.Checked = true;
        this.chkLogSupplyShip.CheckState = CheckState.Checked;
        this.chkLogSupplyShip.Location = new Point(627, 3);
        this.chkLogSupplyShip.Margin = new Padding(6, 3, 3, 3);
        this.chkLogSupplyShip.Name = "chkLogSupplyShip";
        this.chkLogSupplyShip.Size = new Size(128 /*0x80*/, 17);
        this.chkLogSupplyShip.TabIndex = 56;
        this.chkLogSupplyShip.Text = "Exclude Supply Ships";
        this.chkLogSupplyShip.UseVisualStyleBackColor = true;
        this.chkLogSupplyShip.CheckedChanged += this.chkLogNonArmed_CheckedChanged;
        this.chkLogExcTanker.AutoSize = true;
        this.chkLogExcTanker.Checked = true;
        this.chkLogExcTanker.CheckState = CheckState.Checked;
        this.chkLogExcTanker.Location = new Point(512 /*0x0200*/, 3);
        this.chkLogExcTanker.Margin = new Padding(6, 3, 3, 3);
        this.chkLogExcTanker.Name = "chkLogExcTanker";
        this.chkLogExcTanker.Size = new Size(106, 17);
        this.chkLogExcTanker.TabIndex = 0;
        this.chkLogExcTanker.Text = "Exclude Tankers";
        this.chkLogExcTanker.UseVisualStyleBackColor = true;
        this.chkLogExcTanker.CheckedChanged += this.chkLogNonArmed_CheckedChanged;
        this.chkLogExcludeFighter.AutoSize = true;
        this.chkLogExcludeFighter.Checked = true;
        this.chkLogExcludeFighter.CheckState = CheckState.Checked;
        this.chkLogExcludeFighter.Location = new Point(399, 3);
        this.chkLogExcludeFighter.Margin = new Padding(6, 3, 3, 3);
        this.chkLogExcludeFighter.Name = "chkLogExcludeFighter";
        this.chkLogExcludeFighter.Size = new Size(104, 17);
        this.chkLogExcludeFighter.TabIndex = 1;
        this.chkLogExcludeFighter.Text = "Exclude Fighters";
        this.chkLogExcludeFighter.UseVisualStyleBackColor = true;
        this.chkLogExcludeFighter.CheckedChanged += this.chkLogNonArmed_CheckedChanged;
        this.chkLogExcludeFAC.AutoSize = true;
        this.chkLogExcludeFAC.Location = new Point(298, 3);
        this.chkLogExcludeFAC.Margin = new Padding(6, 3, 3, 3);
        this.chkLogExcludeFAC.Name = "chkLogExcludeFAC";
        this.chkLogExcludeFAC.Size = new Size(92, 17);
        this.chkLogExcludeFAC.TabIndex = 55;
        this.chkLogExcludeFAC.Text = "Exclude FACs";
        this.chkLogExcludeFAC.UseVisualStyleBackColor = true;
        this.chkLogExcludeFAC.CheckedChanged += this.chkLogNonArmed_CheckedChanged;
        this.chkLogExcludeSY.AutoSize = true;
        this.chkLogExcludeSY.Checked = true;
        this.chkLogExcludeSY.CheckState = CheckState.Checked;
        this.chkLogExcludeSY.Location = new Point(141, 3);
        this.chkLogExcludeSY.Margin = new Padding(6, 3, 3, 3);
        this.chkLogExcludeSY.Name = "chkLogExcludeSY";
        this.chkLogExcludeSY.Size = new Size(148, 17);
        this.chkLogExcludeSY.TabIndex = 2;
        this.chkLogExcludeSY.Text = "Exclude Ships in Shipyard";
        this.chkLogExcludeSY.UseVisualStyleBackColor = true;
        this.chkLogExcludeSY.CheckedChanged += this.chkLogNonArmed_CheckedChanged;
        this.chkLogNonArmed.AutoSize = true;
        this.chkLogNonArmed.Location = new Point(12, 3);
        this.chkLogNonArmed.Margin = new Padding(6, 3, 3, 3);
        this.chkLogNonArmed.Name = "chkLogNonArmed";
        this.chkLogNonArmed.Size = new Size(120, 17);
        this.chkLogNonArmed.TabIndex = 55;
        this.chkLogNonArmed.Text = "Exclude Non-Armed";
        this.chkLogNonArmed.UseVisualStyleBackColor = true;
        this.chkLogNonArmed.CheckedChanged += this.chkLogNonArmed_CheckedChanged;
        this.lstvLogisticsReport.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvLogisticsReport.Columns.AddRange(new ColumnHeader[10]
        {
            this.columnHeader_79,
            this.columnHeader_80,
            this.columnHeader_81,
            this.columnHeader_82,
            this.columnHeader_83,
            this.columnHeader_84,
            this.columnHeader_85,
            this.columnHeader_86,
            this.columnHeader_87,
            this.columnHeader_88
        });
        this.lstvLogisticsReport.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvLogisticsReport.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvLogisticsReport.HideSelection = false;
        this.lstvLogisticsReport.Location = new Point(4, 34);
        this.lstvLogisticsReport.Name = "lstvLogisticsReport";
        this.lstvLogisticsReport.Size = new Size(1021, 752);
        this.lstvLogisticsReport.TabIndex = 129;
        this.lstvLogisticsReport.UseCompatibleStateImageBehavior = false;
        this.lstvLogisticsReport.View = View.Details;
        this.columnHeader_79.Width = 160 /*0xA0*/;
        this.columnHeader_80.Text = "";
        this.columnHeader_80.Width = 140;
        this.columnHeader_81.Width = 200;
        this.columnHeader_82.Width = 120;
        this.columnHeader_83.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_84.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_85.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_86.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_87.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_88.TextAlign = HorizontalAlignment.Center;
        this.tabFuel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabFuel.Controls.Add(this.flowLayoutPanel7);
        this.tabFuel.Controls.Add(this.lstvFuel);
        this.tabFuel.Location = new Point(4, 22);
        this.tabFuel.Name = "tabFuel";
        this.tabFuel.Padding = new Padding(3);
        this.tabFuel.Size = new Size(1028, 792);
        this.tabFuel.TabIndex = 3;
        this.tabFuel.Text = "Detailed Fuel Report";
        this.flowLayoutPanel7.Controls.Add(this.chkSupplyShip);
        this.flowLayoutPanel7.Controls.Add(this.chkExcTanker);
        this.flowLayoutPanel7.Controls.Add(this.chkExcludeFighter);
        this.flowLayoutPanel7.Controls.Add(this.chkExcludeFAC);
        this.flowLayoutPanel7.Controls.Add(this.chkExcludeSY);
        this.flowLayoutPanel7.Controls.Add(this.chkNonArmed);
        this.flowLayoutPanel7.FlowDirection = FlowDirection.RightToLeft;
        this.flowLayoutPanel7.Location = new Point(3, 3);
        this.flowLayoutPanel7.Name = "flowLayoutPanel7";
        this.flowLayoutPanel7.Size = new Size(1022, 20);
        this.flowLayoutPanel7.TabIndex = 54;
        this.chkSupplyShip.AutoSize = true;
        this.chkSupplyShip.Checked = true;
        this.chkSupplyShip.CheckState = CheckState.Checked;
        this.chkSupplyShip.Location = new Point(891, 3);
        this.chkSupplyShip.Margin = new Padding(6, 3, 3, 3);
        this.chkSupplyShip.Name = "chkSupplyShip";
        this.chkSupplyShip.Size = new Size(128 /*0x80*/, 17);
        this.chkSupplyShip.TabIndex = 56;
        this.chkSupplyShip.Text = "Exclude Supply Ships";
        this.chkSupplyShip.UseVisualStyleBackColor = true;
        this.chkExcTanker.AutoSize = true;
        this.chkExcTanker.Checked = true;
        this.chkExcTanker.CheckState = CheckState.Checked;
        this.chkExcTanker.Location = new Point(776, 3);
        this.chkExcTanker.Margin = new Padding(6, 3, 3, 3);
        this.chkExcTanker.Name = "chkExcTanker";
        this.chkExcTanker.Size = new Size(106, 17);
        this.chkExcTanker.TabIndex = 0;
        this.chkExcTanker.Text = "Exclude Tankers";
        this.chkExcTanker.UseVisualStyleBackColor = true;
        this.chkExcTanker.CheckedChanged += this.chkNonArmed_CheckedChanged;
        this.chkExcludeFighter.AutoSize = true;
        this.chkExcludeFighter.Checked = true;
        this.chkExcludeFighter.CheckState = CheckState.Checked;
        this.chkExcludeFighter.Location = new Point(663, 3);
        this.chkExcludeFighter.Margin = new Padding(6, 3, 3, 3);
        this.chkExcludeFighter.Name = "chkExcludeFighter";
        this.chkExcludeFighter.Size = new Size(104, 17);
        this.chkExcludeFighter.TabIndex = 1;
        this.chkExcludeFighter.Text = "Exclude Fighters";
        this.chkExcludeFighter.UseVisualStyleBackColor = true;
        this.chkExcludeFighter.CheckedChanged += this.chkNonArmed_CheckedChanged;
        this.chkExcludeFAC.AutoSize = true;
        this.chkExcludeFAC.Location = new Point(562, 3);
        this.chkExcludeFAC.Margin = new Padding(6, 3, 3, 3);
        this.chkExcludeFAC.Name = "chkExcludeFAC";
        this.chkExcludeFAC.Size = new Size(92, 17);
        this.chkExcludeFAC.TabIndex = 55;
        this.chkExcludeFAC.Text = "Exclude FACs";
        this.chkExcludeFAC.UseVisualStyleBackColor = true;
        this.chkExcludeFAC.CheckedChanged += this.chkNonArmed_CheckedChanged;
        this.chkExcludeSY.AutoSize = true;
        this.chkExcludeSY.Checked = true;
        this.chkExcludeSY.CheckState = CheckState.Checked;
        this.chkExcludeSY.Location = new Point(405, 3);
        this.chkExcludeSY.Margin = new Padding(6, 3, 3, 3);
        this.chkExcludeSY.Name = "chkExcludeSY";
        this.chkExcludeSY.Size = new Size(148, 17);
        this.chkExcludeSY.TabIndex = 2;
        this.chkExcludeSY.Text = "Exclude Ships in Shipyard";
        this.chkExcludeSY.UseVisualStyleBackColor = true;
        this.chkExcludeSY.CheckedChanged += this.chkNonArmed_CheckedChanged;
        this.chkNonArmed.AutoSize = true;
        this.chkNonArmed.Location = new Point(276, 3);
        this.chkNonArmed.Margin = new Padding(6, 3, 3, 3);
        this.chkNonArmed.Name = "chkNonArmed";
        this.chkNonArmed.Size = new Size(120, 17);
        this.chkNonArmed.TabIndex = 55;
        this.chkNonArmed.Text = "Exclude Non-Armed";
        this.chkNonArmed.UseVisualStyleBackColor = true;
        this.chkNonArmed.CheckedChanged += this.chkNonArmed_CheckedChanged;
        this.lstvFuel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvFuel.BorderStyle = BorderStyle.FixedSingle;
        this.lstvFuel.Columns.AddRange(new ColumnHeader[9]
        {
            this.columnHeader_38,
            this.columnHeader_39,
            this.columnHeader_40,
            this.columnHeader_41,
            this.columnHeader_42,
            this.columnHeader_43,
            this.columnHeader_44,
            this.columnHeader_45,
            this.columnHeader_46
        });
        this.lstvFuel.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvFuel.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvFuel.HideSelection = false;
        this.lstvFuel.Location = new Point(3, 26);
        this.lstvFuel.Name = "lstvFuel";
        this.lstvFuel.Size = new Size(1022, 763);
        this.lstvFuel.TabIndex = 53;
        this.lstvFuel.UseCompatibleStateImageBehavior = false;
        this.lstvFuel.View = View.Details;
        this.columnHeader_38.Width = 170;
        this.columnHeader_39.Width = 170;
        this.columnHeader_40.Width = 170;
        this.columnHeader_41.Width = 140;
        this.columnHeader_42.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_42.Width = 70;
        this.columnHeader_43.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_43.Width = 70;
        this.columnHeader_44.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_44.Width = 70;
        this.columnHeader_45.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_45.Width = 70;
        this.columnHeader_46.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_46.Width = 70;
        this.tabPage5.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage5.Controls.Add(this.lstvRepair);
        this.tabPage5.Controls.Add(this.chkExcludeFighterRepair);
        this.tabPage5.Controls.Add(this.chkExcludeFACRepair);
        this.tabPage5.Controls.Add(this.chkExcludeSYRepair);
        this.tabPage5.Controls.Add(this.chkNonArmedRepair);
        this.tabPage5.Location = new Point(4, 22);
        this.tabPage5.Name = "tabPage5";
        this.tabPage5.Padding = new Padding(3);
        this.tabPage5.Size = new Size(1028, 792);
        this.tabPage5.TabIndex = 5;
        this.tabPage5.Text = "Repair / Crew Report";
        this.lstvRepair.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvRepair.Columns.AddRange(new ColumnHeader[10]
        {
            this.columnHeader_107,
            this.columnHeader_108,
            this.columnHeader_109,
            this.columnHeader_110,
            this.columnHeader_111,
            this.columnHeader_112,
            this.columnHeader_113,
            this.columnHeader_114,
            this.columnHeader_115,
            this.columnHeader_138
        });
        this.lstvRepair.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvRepair.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvRepair.HideSelection = false;
        this.lstvRepair.Location = new Point(3, 26);
        this.lstvRepair.Name = "lstvRepair";
        this.lstvRepair.Size = new Size(1022, 763);
        this.lstvRepair.TabIndex = 130;
        this.lstvRepair.UseCompatibleStateImageBehavior = false;
        this.lstvRepair.View = View.Details;
        this.columnHeader_107.Width = 160 /*0xA0*/;
        this.columnHeader_108.Text = "";
        this.columnHeader_108.Width = 140;
        this.columnHeader_109.Width = 200;
        this.columnHeader_110.Width = 120;
        this.columnHeader_111.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_112.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_113.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_114.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_115.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_138.TextAlign = HorizontalAlignment.Center;
        this.chkExcludeFighterRepair.AutoSize = true;
        this.chkExcludeFighterRepair.Location = new Point(921, 5);
        this.chkExcludeFighterRepair.Margin = new Padding(6, 3, 3, 3);
        this.chkExcludeFighterRepair.Name = "chkExcludeFighterRepair";
        this.chkExcludeFighterRepair.Size = new Size(104, 17);
        this.chkExcludeFighterRepair.TabIndex = 56;
        this.chkExcludeFighterRepair.Text = "Exclude Fighters";
        this.chkExcludeFighterRepair.UseVisualStyleBackColor = true;
        this.chkExcludeFACRepair.AutoSize = true;
        this.chkExcludeFACRepair.Location = new Point(820, 5);
        this.chkExcludeFACRepair.Margin = new Padding(6, 3, 3, 3);
        this.chkExcludeFACRepair.Name = "chkExcludeFACRepair";
        this.chkExcludeFACRepair.Size = new Size(92, 17);
        this.chkExcludeFACRepair.TabIndex = 58;
        this.chkExcludeFACRepair.Text = "Exclude FACs";
        this.chkExcludeFACRepair.UseVisualStyleBackColor = true;
        this.chkExcludeSYRepair.AutoSize = true;
        this.chkExcludeSYRepair.Location = new Point(663, 5);
        this.chkExcludeSYRepair.Margin = new Padding(6, 3, 3, 3);
        this.chkExcludeSYRepair.Name = "chkExcludeSYRepair";
        this.chkExcludeSYRepair.Size = new Size(148, 17);
        this.chkExcludeSYRepair.TabIndex = 57;
        this.chkExcludeSYRepair.Text = "Exclude Ships in Shipyard";
        this.chkExcludeSYRepair.UseVisualStyleBackColor = true;
        this.chkNonArmedRepair.AutoSize = true;
        this.chkNonArmedRepair.Location = new Point(534, 5);
        this.chkNonArmedRepair.Margin = new Padding(6, 3, 3, 3);
        this.chkNonArmedRepair.Name = "chkNonArmedRepair";
        this.chkNonArmedRepair.Size = new Size(120, 17);
        this.chkNonArmedRepair.TabIndex = 59;
        this.chkNonArmedRepair.Text = "Exclude Non-Armed";
        this.chkNonArmedRepair.UseVisualStyleBackColor = true;
        this.tabShippingLine.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabShippingLine.Controls.Add(this.lstvWealth);
        this.tabShippingLine.Controls.Add(this.lstvSL);
        this.tabShippingLine.Location = new Point(4, 22);
        this.tabShippingLine.Name = "tabShippingLine";
        this.tabShippingLine.Padding = new Padding(3);
        this.tabShippingLine.Size = new Size(1028, 792);
        this.tabShippingLine.TabIndex = 8;
        this.tabShippingLine.Text = "Shipping Line";
        this.lstvWealth.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvWealth.BorderStyle = BorderStyle.FixedSingle;
        this.lstvWealth.Columns.AddRange(new ColumnHeader[6]
        {
            this.columnHeader_72,
            this.columnHeader_73,
            this.columnHeader_74,
            this.columnHeader_75,
            this.columnHeader_76,
            this.columnHeader_77
        });
        this.lstvWealth.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvWealth.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvWealth.HideSelection = false;
        this.lstvWealth.Location = new Point(272, 6);
        this.lstvWealth.Name = "lstvWealth";
        this.lstvWealth.Size = new Size(749, 780);
        this.lstvWealth.TabIndex = 60;
        this.lstvWealth.UseCompatibleStateImageBehavior = false;
        this.lstvWealth.View = View.Details;
        this.columnHeader_72.Width = 120;
        this.columnHeader_73.Width = 150;
        this.columnHeader_74.Width = 120;
        this.columnHeader_75.Width = 120;
        this.columnHeader_76.Width = 120;
        this.columnHeader_77.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_77.Width = 70;
        this.lstvSL.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvSL.BorderStyle = BorderStyle.FixedSingle;
        this.lstvSL.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_70,
            this.columnHeader_71
        });
        this.lstvSL.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvSL.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvSL.HideSelection = false;
        this.lstvSL.Location = new Point(6, 6);
        this.lstvSL.Name = "lstvSL";
        this.lstvSL.Size = new Size(260, 780);
        this.lstvSL.TabIndex = 59;
        this.lstvSL.UseCompatibleStateImageBehavior = false;
        this.lstvSL.View = View.Details;
        this.columnHeader_70.Width = 120;
        this.columnHeader_71.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_71.Width = 120;
        this.tabOOB.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabOOB.Controls.Add(this.txtSystemOOB);
        this.tabOOB.Location = new Point(4, 22);
        this.tabOOB.Name = "tabOOB";
        this.tabOOB.Padding = new Padding(3);
        this.tabOOB.Size = new Size(1028, 792);
        this.tabOOB.TabIndex = 9;
        this.tabOOB.Text = "OOB by System";
        this.txtSystemOOB.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSystemOOB.BorderStyle = BorderStyle.FixedSingle;
        this.txtSystemOOB.Dock = DockStyle.Fill;
        this.txtSystemOOB.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtSystemOOB.Location = new Point(3, 3);
        this.txtSystemOOB.Multiline = true;
        this.txtSystemOOB.Name = "txtSystemOOB";
        this.txtSystemOOB.ScrollBars = ScrollBars.Vertical;
        this.txtSystemOOB.Size = new Size(1022, 786);
        this.txtSystemOOB.TabIndex = 0;
        this.tabPage3.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage3.Controls.Add(this.flowLayoutPanel28);
        this.tabPage3.Controls.Add(this.chkIncludeSG);
        this.tabPage3.Controls.Add(this.lstvCombatRating);
        this.tabPage3.Location = new Point(4, 22);
        this.tabPage3.Name = "tabPage3";
        this.tabPage3.Padding = new Padding(3);
        this.tabPage3.Size = new Size(1028, 792);
        this.tabPage3.TabIndex = 10;
        this.tabPage3.Text = "Combat Ratings";
        this.flowLayoutPanel28.Controls.Add(this.rdoMilitary);
        this.flowLayoutPanel28.Controls.Add(this.rdoCommercial);
        this.flowLayoutPanel28.Controls.Add(this.rdoGround);
        this.flowLayoutPanel28.Controls.Add(this.rdoMissiles);
        this.flowLayoutPanel28.Controls.Add(this.rdoSize);
        this.flowLayoutPanel28.Controls.Add(this.rdoDistance);
        this.flowLayoutPanel28.Location = new Point(4, 3);
        this.flowLayoutPanel28.Name = "flowLayoutPanel28";
        this.flowLayoutPanel28.Size = new Size(712, 22);
        this.flowLayoutPanel28.TabIndex = 145;
        this.rdoMilitary.AutoSize = true;
        this.rdoMilitary.Checked = true;
        this.rdoMilitary.Location = new Point(3, 3);
        this.rdoMilitary.Name = "rdoMilitary";
        this.rdoMilitary.Size = new Size(93, 17);
        this.rdoMilitary.TabIndex = 69;
        this.rdoMilitary.TabStop = true;
        this.rdoMilitary.Text = "Sort by Military";
        this.rdoMilitary.UseVisualStyleBackColor = true;
        this.rdoMilitary.CheckedChanged += this.rdoDistance_CheckedChanged;
        this.rdoCommercial.AutoSize = true;
        this.rdoCommercial.Location = new Point(102, 3);
        this.rdoCommercial.Name = "rdoCommercial";
        this.rdoCommercial.Size = new Size(115, 17);
        this.rdoCommercial.TabIndex = 70;
        this.rdoCommercial.Text = "Sort by Commercial";
        this.rdoCommercial.UseVisualStyleBackColor = true;
        this.rdoCommercial.CheckedChanged += this.rdoDistance_CheckedChanged;
        this.rdoGround.AutoSize = true;
        this.rdoGround.Location = new Point(223, 3);
        this.rdoGround.Name = "rdoGround";
        this.rdoGround.Size = new Size(96 /*0x60*/, 17);
        this.rdoGround.TabIndex = 71;
        this.rdoGround.Text = "Sort by Ground";
        this.rdoGround.UseVisualStyleBackColor = true;
        this.rdoGround.CheckedChanged += this.rdoDistance_CheckedChanged;
        this.rdoMissiles.AutoSize = true;
        this.rdoMissiles.Location = new Point(325, 3);
        this.rdoMissiles.Name = "rdoMissiles";
        this.rdoMissiles.Size = new Size(97, 17);
        this.rdoMissiles.TabIndex = 72;
        this.rdoMissiles.Text = "Sort by Missiles";
        this.rdoMissiles.UseVisualStyleBackColor = true;
        this.rdoMissiles.CheckedChanged += this.rdoDistance_CheckedChanged;
        this.rdoSize.AutoSize = true;
        this.rdoSize.Location = new Point(428, 3);
        this.rdoSize.Name = "rdoSize";
        this.rdoSize.Size = new Size(81, 17);
        this.rdoSize.TabIndex = 73;
        this.rdoSize.Text = "Sort by Size";
        this.rdoSize.UseVisualStyleBackColor = true;
        this.rdoSize.CheckedChanged += this.rdoDistance_CheckedChanged;
        this.rdoDistance.AutoSize = true;
        this.rdoDistance.Location = new Point(515, 3);
        this.rdoDistance.Name = "rdoDistance";
        this.rdoDistance.Size = new Size(103, 17);
        this.rdoDistance.TabIndex = 74;
        this.rdoDistance.Text = "Sort by Distance";
        this.rdoDistance.UseVisualStyleBackColor = true;
        this.rdoDistance.CheckedChanged += this.rdoDistance_CheckedChanged;
        this.chkIncludeSG.AutoSize = true;
        this.chkIncludeSG.Location = new Point(905, 8);
        this.chkIncludeSG.Margin = new Padding(6, 3, 3, 3);
        this.chkIncludeSG.Name = "chkIncludeSG";
        this.chkIncludeSG.Size = new Size(118, 17);
        this.chkIncludeSG.TabIndex = 132;
        this.chkIncludeSG.Text = "Include Strikegroup";
        this.chkIncludeSG.UseVisualStyleBackColor = true;
        this.chkIncludeSG.CheckedChanged += this.chkIncludeSG_CheckedChanged;
        this.lstvCombatRating.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvCombatRating.Columns.AddRange(new ColumnHeader[10]
        {
            this.columnHeader_118,
            this.columnHeader_119,
            this.columnHeader_120,
            this.columnHeader_121,
            this.columnHeader_122,
            this.columnHeader_123,
            this.columnHeader_124,
            this.columnHeader_125,
            this.columnHeader_126,
            this.columnHeader_127
        });
        this.lstvCombatRating.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvCombatRating.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvCombatRating.HideSelection = false;
        this.lstvCombatRating.Location = new Point(3, 31 /*0x1F*/);
        this.lstvCombatRating.Name = "lstvCombatRating";
        this.lstvCombatRating.Size = new Size(1022, 755);
        this.lstvCombatRating.TabIndex = 131;
        this.lstvCombatRating.UseCompatibleStateImageBehavior = false;
        this.lstvCombatRating.View = View.Details;
        this.columnHeader_118.Width = 180;
        this.columnHeader_119.Text = "";
        this.columnHeader_119.Width = 130;
        this.columnHeader_120.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_120.Width = 80 /*0x50*/;
        this.columnHeader_121.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_121.Width = 80 /*0x50*/;
        this.columnHeader_122.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_122.Width = 70;
        this.columnHeader_123.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_123.Width = 90;
        this.columnHeader_124.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_124.Width = 90;
        this.columnHeader_125.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_125.Width = 90;
        this.columnHeader_126.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_126.Width = 80 /*0x50*/;
        this.columnHeader_127.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_127.Width = 80 /*0x50*/;
        this.tabPage4.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage4.Controls.Add(this.cmdDeleteSalvo);
        this.tabPage4.Controls.Add(this.lstvSalvos);
        this.tabPage4.Location = new Point(4, 22);
        this.tabPage4.Name = "tabPage4";
        this.tabPage4.Padding = new Padding(3);
        this.tabPage4.Size = new Size(1028, 792);
        this.tabPage4.TabIndex = 11;
        this.tabPage4.Text = "Missile Salvos";
        this.cmdDeleteSalvo.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteSalvo.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteSalvo.Location = new Point(931, 761);
        this.cmdDeleteSalvo.Margin = new Padding(0);
        this.cmdDeleteSalvo.Name = "cmdDeleteSalvo";
        this.cmdDeleteSalvo.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteSalvo.TabIndex = 138;
        this.cmdDeleteSalvo.Tag = "1200";
        this.cmdDeleteSalvo.Text = "Delete Salvo";
        this.cmdDeleteSalvo.UseVisualStyleBackColor = false;
        this.cmdDeleteSalvo.Click += this.cmdDeleteSalvo_Click;
        this.lstvSalvos.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvSalvos.Columns.AddRange(new ColumnHeader[7]
        {
            this.columnHeader_131,
            this.columnHeader_132,
            this.columnHeader_133,
            this.columnHeader_134,
            this.columnHeader_135,
            this.columnHeader_137,
            this.columnHeader_136
        });
        this.lstvSalvos.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvSalvos.FullRowSelect = true;
        this.lstvSalvos.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvSalvos.HideSelection = false;
        this.lstvSalvos.Location = new Point(6, 4);
        this.lstvSalvos.Name = "lstvSalvos";
        this.lstvSalvos.Size = new Size(1022, 755);
        this.lstvSalvos.TabIndex = 132;
        this.lstvSalvos.UseCompatibleStateImageBehavior = false;
        this.lstvSalvos.View = View.Details;
        this.lstvSalvos.SelectedIndexChanged += this.lstvSalvos_SelectedIndexChanged;
        this.columnHeader_131.Text = "";
        this.columnHeader_131.Width = 170;
        this.columnHeader_132.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_132.Width = 50;
        this.columnHeader_133.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_133.Width = 180;
        this.columnHeader_134.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_134.Width = 150;
        this.columnHeader_135.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_135.Width = 80 /*0x50*/;
        this.columnHeader_137.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_137.Width = 120;
        this.columnHeader_136.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_136.Width = 250;
        this.cmdRename.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRename.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRename.Location = new Point(480, 0);
        this.cmdRename.Margin = new Padding(0);
        this.cmdRename.Name = "cmdRename";
        this.cmdRename.Size = new Size(96 /*0x60*/, 30);
        this.cmdRename.TabIndex = 130;
        this.cmdRename.Tag = "1200";
        this.cmdRename.Text = "Rename";
        this.cmdRename.UseVisualStyleBackColor = false;
        this.cmdRename.Click += this.cmdRename_Click;
        this.cmdCreateFleet.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreateFleet.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreateFleet.Location = new Point(0, 0);
        this.cmdCreateFleet.Margin = new Padding(0);
        this.cmdCreateFleet.Name = "cmdCreateFleet";
        this.cmdCreateFleet.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreateFleet.TabIndex = 131;
        this.cmdCreateFleet.Tag = "1200";
        this.cmdCreateFleet.Text = "Create Fleet";
        this.cmdCreateFleet.UseVisualStyleBackColor = false;
        this.cmdCreateFleet.Visible = false;
        this.cmdCreateFleet.Click += this.cmdCreateFleet_Click;
        this.cmdSetSpeed.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSetSpeed.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSetSpeed.Location = new Point(288, 0);
        this.cmdSetSpeed.Margin = new Padding(0);
        this.cmdSetSpeed.Name = "cmdSetSpeed";
        this.cmdSetSpeed.Size = new Size(96 /*0x60*/, 30);
        this.cmdSetSpeed.TabIndex = 132;
        this.cmdSetSpeed.Tag = "1200";
        this.cmdSetSpeed.Text = "Set Speed";
        this.cmdSetSpeed.UseVisualStyleBackColor = false;
        this.cmdSetSpeed.Visible = false;
        this.cmdSetSpeed.Click += this.cmdSetSpeed_Click;
        this.chkSelectOnMap.AutoSize = true;
        this.chkSelectOnMap.Location = new Point(260, 7);
        this.chkSelectOnMap.Margin = new Padding(3, 7, 3, 3);
        this.chkSelectOnMap.Name = "chkSelectOnMap";
        this.chkSelectOnMap.Padding = new Padding(5, 0, 0, 0);
        this.chkSelectOnMap.Size = new Size(100, 17);
        this.chkSelectOnMap.TabIndex = 133;
        this.chkSelectOnMap.Text = "Select on Map";
        this.chkSelectOnMap.TextAlign = ContentAlignment.MiddleRight;
        this.chkSelectOnMap.UseVisualStyleBackColor = true;
        this.chkSelectOnMap.CheckedChanged += this.chkSelectOnMap_CheckedChanged;
        this.cmdDetach.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDetach.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDetach.Location = new Point(960, 0);
        this.cmdDetach.Margin = new Padding(0);
        this.cmdDetach.Name = "cmdDetach";
        this.cmdDetach.Size = new Size(96 /*0x60*/, 30);
        this.cmdDetach.TabIndex = 135;
        this.cmdDetach.Tag = "1200";
        this.cmdDetach.Text = "Detach";
        this.cmdDetach.UseVisualStyleBackColor = false;
        this.cmdDetach.Visible = false;
        this.cmdDetach.Click += this.cmdDetach_Click;
        this.flowLayoutPanel9.Controls.Add(this.cmdCreateFleet);
        this.flowLayoutPanel9.Controls.Add(this.cmdCreateSubFleet);
        this.flowLayoutPanel9.Controls.Add(this.cmdCreateSquadron);
        this.flowLayoutPanel9.Controls.Add(this.cmdSetSpeed);
        this.flowLayoutPanel9.Controls.Add(this.cmdAutoFleetFC);
        this.flowLayoutPanel9.Controls.Add(this.cmdRename);
        this.flowLayoutPanel9.Controls.Add(this.cmdSelectName);
        this.flowLayoutPanel9.Controls.Add(this.cmdActive2);
        this.flowLayoutPanel9.Controls.Add(this.cmdFleetShields);
        this.flowLayoutPanel9.Controls.Add(this.cmdEndOverhaul);
        this.flowLayoutPanel9.Controls.Add(this.cmdDetach);
        this.flowLayoutPanel9.Controls.Add(this.cmdLaunchAll);
        this.flowLayoutPanel9.Controls.Add(this.cmdDetachEscorts);
        this.flowLayoutPanel9.Controls.Add(this.cmdRecallEscorts);
        this.flowLayoutPanel9.Controls.Add(this.cmdAwardMedal);
        this.flowLayoutPanel9.Controls.Add(this.cmdRefresh);
        this.flowLayoutPanel9.Controls.Add(this.cmdDelete);
        this.flowLayoutPanel9.Controls.Add(this.cmdTemp);
        this.flowLayoutPanel9.Controls.Add(this.cmdCollapseAll);
        this.flowLayoutPanel9.Location = new Point(3, 824);
        this.flowLayoutPanel9.Margin = new Padding(0);
        this.flowLayoutPanel9.Name = "flowLayoutPanel9";
        this.flowLayoutPanel9.Size = new Size(1257, 71);
        this.flowLayoutPanel9.TabIndex = 136;
        this.cmdCreateSquadron.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreateSquadron.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreateSquadron.Location = new Point(192 /*0xC0*/, 0);
        this.cmdCreateSquadron.Margin = new Padding(0);
        this.cmdCreateSquadron.Name = "cmdCreateSquadron";
        this.cmdCreateSquadron.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreateSquadron.TabIndex = 140;
        this.cmdCreateSquadron.Tag = "1200";
        this.cmdCreateSquadron.Text = "Create Squadron";
        this.cmdCreateSquadron.UseVisualStyleBackColor = false;
        this.cmdCreateSquadron.Visible = false;
        this.cmdCreateSquadron.Click += this.cmdCreateSquadron_Click;
        this.cmdAutoFleetFC.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAutoFleetFC.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAutoFleetFC.Location = new Point(384, 0);
        this.cmdAutoFleetFC.Margin = new Padding(0);
        this.cmdAutoFleetFC.Name = "cmdAutoFleetFC";
        this.cmdAutoFleetFC.Size = new Size(96 /*0x60*/, 30);
        this.cmdAutoFleetFC.TabIndex = 136;
        this.cmdAutoFleetFC.Tag = "1200";
        this.cmdAutoFleetFC.Text = "Auto Fleet FC";
        this.cmdAutoFleetFC.UseVisualStyleBackColor = false;
        this.cmdAutoFleetFC.Visible = false;
        this.cmdAutoFleetFC.Click += this.cmdAutoFleetFC_Click;
        this.cmdSelectName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSelectName.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSelectName.Location = new Point(576, 0);
        this.cmdSelectName.Margin = new Padding(0);
        this.cmdSelectName.Name = "cmdSelectName";
        this.cmdSelectName.Size = new Size(96 /*0x60*/, 30);
        this.cmdSelectName.TabIndex = 138;
        this.cmdSelectName.Tag = "1200";
        this.cmdSelectName.Text = "Select Name";
        this.cmdSelectName.UseVisualStyleBackColor = false;
        this.cmdSelectName.Click += this.cmdSelectName_Click;
        this.cmdActive2.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdActive2.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdActive2.Location = new Point(672, 0);
        this.cmdActive2.Margin = new Padding(0);
        this.cmdActive2.Name = "cmdActive2";
        this.cmdActive2.Size = new Size(96 /*0x60*/, 30);
        this.cmdActive2.TabIndex = 137;
        this.cmdActive2.Tag = "1200";
        this.cmdActive2.Text = "Active On";
        this.cmdActive2.UseVisualStyleBackColor = false;
        this.cmdActive2.Visible = false;
        this.cmdActive2.Click += this.cmdActive2_Click;
        this.cmdFleetShields.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdFleetShields.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdFleetShields.Location = new Point(768 /*0x0300*/, 0);
        this.cmdFleetShields.Margin = new Padding(0);
        this.cmdFleetShields.Name = "cmdFleetShields";
        this.cmdFleetShields.Size = new Size(96 /*0x60*/, 30);
        this.cmdFleetShields.TabIndex = 138;
        this.cmdFleetShields.Tag = "1200";
        this.cmdFleetShields.Text = "Raise Shields";
        this.cmdFleetShields.UseVisualStyleBackColor = false;
        this.cmdFleetShields.Visible = false;
        this.cmdFleetShields.Click += this.cmdFleetShields_Click;
        this.cmdEndOverhaul.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdEndOverhaul.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdEndOverhaul.Location = new Point(864, 0);
        this.cmdEndOverhaul.Margin = new Padding(0);
        this.cmdEndOverhaul.Name = "cmdEndOverhaul";
        this.cmdEndOverhaul.Size = new Size(96 /*0x60*/, 30);
        this.cmdEndOverhaul.TabIndex = 138;
        this.cmdEndOverhaul.Tag = "1200";
        this.cmdEndOverhaul.Text = "Leave Overhaul";
        this.cmdEndOverhaul.UseVisualStyleBackColor = false;
        this.cmdEndOverhaul.Visible = false;
        this.cmdEndOverhaul.Click += this.cmdEndOverhaul_Click;
        this.cmdLaunchAll.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdLaunchAll.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdLaunchAll.Location = new Point(1056, 0);
        this.cmdLaunchAll.Margin = new Padding(0);
        this.cmdLaunchAll.Name = "cmdLaunchAll";
        this.cmdLaunchAll.Size = new Size(96 /*0x60*/, 30);
        this.cmdLaunchAll.TabIndex = 141;
        this.cmdLaunchAll.Tag = "1200";
        this.cmdLaunchAll.Text = "Launch All";
        this.cmdLaunchAll.UseVisualStyleBackColor = false;
        this.cmdLaunchAll.Visible = false;
        this.cmdLaunchAll.Click += this.cmdLaunchAll_Click;
        this.cmdDetachEscorts.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDetachEscorts.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDetachEscorts.Location = new Point(1152, 0);
        this.cmdDetachEscorts.Margin = new Padding(0);
        this.cmdDetachEscorts.Name = "cmdDetachEscorts";
        this.cmdDetachEscorts.Size = new Size(96 /*0x60*/, 30);
        this.cmdDetachEscorts.TabIndex = 138;
        this.cmdDetachEscorts.Tag = "1200";
        this.cmdDetachEscorts.Text = "Detach Escorts";
        this.cmdDetachEscorts.UseVisualStyleBackColor = false;
        this.cmdDetachEscorts.Click += this.cmdDetachEscorts_Click;
        this.cmdRecallEscorts.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRecallEscorts.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRecallEscorts.Location = new Point(0, 30);
        this.cmdRecallEscorts.Margin = new Padding(0);
        this.cmdRecallEscorts.Name = "cmdRecallEscorts";
        this.cmdRecallEscorts.Size = new Size(96 /*0x60*/, 30);
        this.cmdRecallEscorts.TabIndex = 139;
        this.cmdRecallEscorts.Tag = "1200";
        this.cmdRecallEscorts.Text = "Recall Escorts";
        this.cmdRecallEscorts.UseVisualStyleBackColor = false;
        this.cmdRecallEscorts.Click += this.cmdRecallEscorts_Click;
        this.cmdAwardMedal.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAwardMedal.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAwardMedal.Location = new Point(96 /*0x60*/, 30);
        this.cmdAwardMedal.Margin = new Padding(0);
        this.cmdAwardMedal.Name = "cmdAwardMedal";
        this.cmdAwardMedal.Size = new Size(96 /*0x60*/, 30);
        this.cmdAwardMedal.TabIndex = 139;
        this.cmdAwardMedal.Tag = "1200";
        this.cmdAwardMedal.Text = "Award Medal";
        this.cmdAwardMedal.UseVisualStyleBackColor = false;
        this.cmdAwardMedal.Click += this.cmdAwardMedal_Click;
        this.cmdTemp.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdTemp.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdTemp.Location = new Point(384, 30);
        this.cmdTemp.Margin = new Padding(0);
        this.cmdTemp.Name = "cmdTemp";
        this.cmdTemp.Size = new Size(96 /*0x60*/, 30);
        this.cmdTemp.TabIndex = 142;
        this.cmdTemp.Tag = "1200";
        this.cmdTemp.Text = "Fix SL";
        this.cmdTemp.UseVisualStyleBackColor = false;
        this.cmdTemp.Visible = false;
        this.cmdTemp.Click += this.cmdTemp_Click;
        this.cmdCollapseAll.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCollapseAll.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCollapseAll.Location = new Point(480, 30);
        this.cmdCollapseAll.Margin = new Padding(0);
        this.cmdCollapseAll.Name = "cmdCollapseAll";
        this.cmdCollapseAll.Size = new Size(96 /*0x60*/, 30);
        this.cmdCollapseAll.TabIndex = 143;
        this.cmdCollapseAll.Tag = "1200";
        this.cmdCollapseAll.Text = "Collapse All";
        this.cmdCollapseAll.UseVisualStyleBackColor = false;
        this.cmdCollapseAll.Click += this.cmdCollapseAll_Click;
        this.chkIncludeCivilians.AutoSize = true;
        this.chkIncludeCivilians.Checked = true;
        this.chkIncludeCivilians.CheckState = CheckState.Checked;
        this.chkIncludeCivilians.Location = new Point(285, 7);
        this.chkIncludeCivilians.Name = "chkIncludeCivilians";
        this.chkIncludeCivilians.Padding = new Padding(5, 0, 0, 0);
        this.chkIncludeCivilians.Size = new Size(99, 17);
        this.chkIncludeCivilians.TabIndex = 137;
        this.chkIncludeCivilians.Text = "Show Civilians";
        this.chkIncludeCivilians.TextAlign = ContentAlignment.MiddleRight;
        this.chkIncludeCivilians.UseVisualStyleBackColor = true;
        this.chkIncludeCivilians.CheckedChanged += this.chkIncludeCivilians_CheckedChanged;
        this.flowLayoutPanel30.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel30.Controls.Add(this.chkOrders);
        this.flowLayoutPanel30.Controls.Add(this.chkOverhauls);
        this.flowLayoutPanel30.Controls.Add(this.chkShowJD);
        this.flowLayoutPanel30.Controls.Add(this.chkSelectOnMap);
        this.flowLayoutPanel30.Location = new Point(3, 790);
        this.flowLayoutPanel30.Name = "flowLayoutPanel30";
        this.flowLayoutPanel30.Size = new Size(381, 31 /*0x1F*/);
        this.flowLayoutPanel30.TabIndex = 138;
        this.chkShowJD.AutoSize = true;
        this.chkShowJD.Location = new Point(156, 7);
        this.chkShowJD.Margin = new Padding(3, 7, 3, 3);
        this.chkShowJD.Name = "chkShowJD";
        this.chkShowJD.Padding = new Padding(5, 0, 0, 0);
        this.chkShowJD.Size = new Size(98, 17);
        this.chkShowJD.TabIndex = 138;
        this.chkShowJD.Text = "Jump Capable";
        this.chkShowJD.TextAlign = ContentAlignment.MiddleRight;
        this.chkShowJD.UseVisualStyleBackColor = true;
        this.chkShowJD.CheckedChanged += this.chkShowJD_CheckedChanged;
        this.chkOverhauls.AutoSize = true;
        this.chkOverhauls.Location = new Point(71, 7);
        this.chkOverhauls.Margin = new Padding(3, 7, 3, 3);
        this.chkOverhauls.Name = "chkOverhauls";
        this.chkOverhauls.Padding = new Padding(5, 0, 0, 0);
        this.chkOverhauls.Size = new Size(79, 17);
        this.chkOverhauls.TabIndex = 139;
        this.chkOverhauls.Text = "Overhauls";
        this.chkOverhauls.TextAlign = ContentAlignment.MiddleRight;
        this.chkOverhauls.UseVisualStyleBackColor = true;
        this.chkOverhauls.CheckedChanged += this.chkOverhauls_CheckedChanged;
        this.chkOrders.AutoSize = true;
        this.chkOrders.Location = new Point(3, 7);
        this.chkOrders.Margin = new Padding(3, 7, 3, 3);
        this.chkOrders.Name = "chkOrders";
        this.chkOrders.Padding = new Padding(5, 0, 0, 0);
        this.chkOrders.Size = new Size(62, 17);
        this.chkOrders.TabIndex = 140;
        this.chkOrders.Text = "Orders";
        this.chkOrders.TextAlign = ContentAlignment.MiddleRight;
        this.chkOrders.UseVisualStyleBackColor = true;
        this.chkOrders.CheckedChanged += this.chkOrders_CheckedChanged;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(1424, 886);
        this.Controls.Add(this.flowLayoutPanel30);
        this.Controls.Add(this.chkIncludeCivilians);
        this.Controls.Add(this.flowLayoutPanel9);
        this.Controls.Add(this.tabNaval);
        this.Controls.Add(this.tvFleetList);
        this.Controls.Add(this.cboRaces);
        this.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.KeyPreview = true;
        this.Name = "FleetWindow";
        this.Text = "Naval Organization";
        this.FormClosing += this.FleetWindow_FormClosing;
        this.Load += this.FleetWindow_Load;
        this.KeyDown += this.FleetWindow_KeyDown;
        this.tabNaval.ResumeLayout(false);
        this.tabFleet.ResumeLayout(false);
        this.tabFleetPages.ResumeLayout(false);
        this.tabShipList.ResumeLayout(false);
        this.tabOrders.ResumeLayout(false);
        this.flowLayoutPanel5.ResumeLayout(false);
        this.flowLayoutPanel5.PerformLayout();
        this.flpFleetOrderButtons.ResumeLayout(false);
        this.flpFleetOrderButtons.PerformLayout();
        this.flowLayoutPanel3.ResumeLayout(false);
        this.flowLayoutPanel3.PerformLayout();
        this.flowLayoutPanel2.ResumeLayout(false);
        this.flowLayoutPanel2.PerformLayout();
        this.flowLayoutPanel1.ResumeLayout(false);
        this.flowLayoutPanel1.PerformLayout();
        this.tabStandingOrders.ResumeLayout(false);
        this.tabStandingOrders.PerformLayout();
        this.flowLayoutPanel29.ResumeLayout(false);
        this.flowLayoutPanel29.PerformLayout();
        this.tabFormation.ResumeLayout(false);
        this.flowLayoutPanel20.ResumeLayout(false);
        this.flowLayoutPanel20.PerformLayout();
        this.flowLayoutPanel23.ResumeLayout(false);
        this.tabCargo.ResumeLayout(false);
        this.tabFleetHistory.ResumeLayout(false);
        this.tabFleetMisc.ResumeLayout(false);
        this.panel2.ResumeLayout(false);
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.flowLayoutPanel15.ResumeLayout(false);
        this.flowLayoutPanel15.PerformLayout();
        this.tabShipDisplay.ResumeLayout(false);
        this.tabControl1.ResumeLayout(false);
        this.tabPage1.ResumeLayout(false);
        this.tabPage1.PerformLayout();
        this.flowLayoutPanel19.ResumeLayout(false);
        this.flowLayoutPanel10.ResumeLayout(false);
        this.flpEnergyWeaponData.ResumeLayout(false);
        this.flpEnergyWeaponData.PerformLayout();
        this.tabPage2.ResumeLayout(false);
        this.tabPage2.PerformLayout();
        this.tabOrdnanceTemplate.ResumeLayout(false);
        this.flowLayoutPanel21.ResumeLayout(false);
        this.flowLayoutPanel22.ResumeLayout(false);
        this.flowLayoutPanel22.PerformLayout();
        this.flowLayoutPanel18.ResumeLayout(false);
        this.flowLayoutPanel18.PerformLayout();
        this.flowLayoutPanel17.ResumeLayout(false);
        this.tabShipCargo.ResumeLayout(false);
        this.tabArmour.ResumeLayout(false);
        this.tabPage6.ResumeLayout(false);
        this.tabPage6.PerformLayout();
        this.flowLayoutPanel14.ResumeLayout(false);
        this.flowLayoutPanel14.PerformLayout();
        this.tabPage8.ResumeLayout(false);
        this.tabMiscellaneous.ResumeLayout(false);
        this.flowLayoutPanel6.ResumeLayout(false);
        this.flowLayoutPanel13.ResumeLayout(false);
        this.flowLayoutPanel13.PerformLayout();
        this.panel11.ResumeLayout(false);
        this.panel11.PerformLayout();
        this.panel8.ResumeLayout(false);
        this.panel8.PerformLayout();
        this.flowLayoutPanel11.ResumeLayout(false);
        this.flowLayoutPanel4.ResumeLayout(false);
        this.flowLayoutPanel12.ResumeLayout(false);
        this.flowLayoutPanel12.PerformLayout();
        this.tabCombat.ResumeLayout(false);
        this.flowLayoutPanel25.ResumeLayout(false);
        this.flowLayoutPanel25.PerformLayout();
        this.flowLayoutPanel32.ResumeLayout(false);
        this.tabAdminCommand.ResumeLayout(false);
        this.tabAdminCommand.PerformLayout();
        this.panel3.ResumeLayout(false);
        this.panel3.PerformLayout();
        this.flowLayoutPanel27.ResumeLayout(false);
        this.flowLayoutPanel24.ResumeLayout(false);
        this.flowLayoutPanel24.PerformLayout();
        this.flowLayoutPanel26.ResumeLayout(false);
        this.tabLogistics.ResumeLayout(false);
        this.flowLayoutPanel16.ResumeLayout(false);
        this.flowLayoutPanel16.PerformLayout();
        this.tabFuel.ResumeLayout(false);
        this.flowLayoutPanel7.ResumeLayout(false);
        this.flowLayoutPanel7.PerformLayout();
        this.tabPage5.ResumeLayout(false);
        this.tabPage5.PerformLayout();
        this.tabShippingLine.ResumeLayout(false);
        this.tabOOB.ResumeLayout(false);
        this.tabOOB.PerformLayout();
        this.tabPage3.ResumeLayout(false);
        this.tabPage3.PerformLayout();
        this.flowLayoutPanel28.ResumeLayout(false);
        this.flowLayoutPanel28.PerformLayout();
        this.tabPage4.ResumeLayout(false);
        this.flowLayoutPanel9.ResumeLayout(false);
        this.flowLayoutPanel30.ResumeLayout(false);
        this.flowLayoutPanel30.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}