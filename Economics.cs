// Decompiled with JetBrains decompiler
// Type: Economics
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
public class Economics : Form
{
    #region CompilerGenerated

    [CompilerGenerated]
    private sealed class Class1074
    {
        public FCTRaceRecordC21 gclass21_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass21_0;
        }

        internal bool method_1(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass21_0;
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1075
    {
        public GClass107 gclass107_0;

        internal bool method_0(GClass107 gclass107_1)
        {
            return gclass107_1.int_0 == this.gclass107_0.int_0 - 1;
        }
    }

    [CompilerGenerated]
    private sealed class Class1076
    {
        public GClass107 gclass107_0;

        internal bool method_0(GClass107 gclass107_1)
        {
            return gclass107_1.int_0 == this.gclass107_0.int_0 + 1;
        }
    }

    [CompilerGenerated]
    private sealed class Class1077
    {
        public GClass193 gclass193_0;

        internal bool method_0(GClass192 gclass192_0)
        {
            return gclass192_0.gclass193_0 == this.gclass193_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1078
    {
        public GClass166 gclass166_0;

        internal bool method_0(GClass166 gclass166_1)
        {
            return gclass166_1.gclass146_0 == this.gclass166_0.gclass146_0 &&
                   gclass166_1.gclass161_0 == this.gclass166_0.gclass161_0;
        }

        internal bool method_1(GClass166 gclass166_1)
        {
            return gclass166_1.gclass146_0 == this.gclass166_0.gclass146_0 &&
                   gclass166_1.gclass161_0 == this.gclass166_0.gclass161_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1079
    {
        public TechData164 gclass164_0;

        internal bool method_0(GClass130 gclass130_0)
        {
            return gclass130_0.gclass129_0.gclass164_0 == this.gclass164_0;
        }

        internal bool method_1(GClass130 gclass130_0)
        {
            return gclass130_0.gclass129_0.gclass164_0 == this.gclass164_0;
        }

        internal bool method_2(GClass130 gclass130_0)
        {
            return gclass130_0.gclass129_0.gclass164_0 == this.gclass164_0;
        }

        internal bool method_3(GroundUnitFormationElement gclass39_0)
        {
            return gclass39_0.GroundUnitClass.TechData == this.gclass164_0;
        }

        internal bool method_4(GroundUnitFormationElement gclass39_0)
        {
            return gclass39_0.GroundUnitClass.TechData == this.gclass164_0;
        }

        internal bool method_5(GClass228 gclass228_0)
        {
            return gclass228_0.gclass230_0.gclass164_0 == this.gclass164_0;
        }

        internal bool method_6(RaceMissile gclass129_0)
        {
            return gclass129_0.gclass164_0 == this.gclass164_0;
        }

        internal bool method_7(ShipComponent gclass230_0)
        {
            return gclass230_0.gclass164_0 == this.gclass164_0;
        }

        internal bool method_8(GroundUnitClass101 gclass101_0)
        {
            return gclass101_0.TechData == this.gclass164_0;
        }
    }

    #endregion

    private GClass0 gclass0_0;
    private FCTRaceRecordC21 gclass21_0;
    private RacialSystemSurvey gclass202_0;
    private PopulationData gclass146_0;
    private GClass193 gclass193_0;
    private GClass192 gclass192_0;
    private GEnum34 genum34_0;
    private bool bool_0;
    private bool bool_1;
    private IContainer icontainer_0;
    private ComboBox cboRaces;
    private TreeView tvPopList;
    private TabControl tabPopulation;
    private TabPage tabSummary;
    private CheckBox chkShowSystemBody;
    private CheckBox chkByFunction;
    private CheckBox chkHideCMC;
    private ListView lstvPopSummary;
    private ColumnHeader columnHeader_0;
    private ColumnHeader columnHeader_1;
    private FlowLayoutPanel flowLayoutPanel1;
    private Label lblSecGovName;
    private Label label4;
    private Label lblGovName;
    private Label label1;
    private ListView lstvPopSummary2;
    private ColumnHeader columnHeader_2;
    private ColumnHeader columnHeader_3;
    private ListView lstvPopSummary3;
    private ColumnHeader columnHeader_4;
    private ColumnHeader columnHeader_5;
    private TabPage tabIndustry;
    private TextBox txtPercentage;
    private Label label5;
    private TextBox txtItems;
    private Label label3;
    private Button cmdPause;
    private Button cmdCancel;
    private Button cmdModify;
    private ListView lstvConstruction;
    private ColumnHeader columnHeader_6;
    private ColumnHeader columnHeader_7;
    private ColumnHeader columnHeader_8;
    private ColumnHeader columnHeader_9;
    private ColumnHeader columnHeader_10;
    private ColumnHeader columnHeader_11;
    private ColumnHeader columnHeader_12;
    private ColumnHeader columnHeader_13;
    private ListBox lstPI;
    private Button cmdCreate;
    private ComboBox cboConstructionType;
    private TabPage tabMining;
    private ListView lstvMinerals;
    private ColumnHeader columnHeader_14;
    private ColumnHeader columnHeader_15;
    private ColumnHeader columnHeader_16;
    private Label label2;
    private ComboBox cboFighters;
    private Button cmdDownQueue;
    private Button cmdUpQueue;
    private TabPage tabShipyards;
    private TabPage tabSYTasks;
    private TabPage tabResearch;
    private ListView lstvMining;
    private ColumnHeader columnHeader_17;
    private ColumnHeader columnHeader_18;
    private ColumnHeader columnHeader_19;
    private ColumnHeader columnHeader_20;
    private ColumnHeader columnHeader_21;
    private ColumnHeader columnHeader_22;
    private ColumnHeader columnHeader_23;
    private ColumnHeader columnHeader_24;
    private ColumnHeader columnHeader_25;
    private ColumnHeader columnHeader_26;
    private ColumnHeader columnHeader_27;
    private TabPage tabStockpile;
    private ListView lstvMines;
    private ColumnHeader columnHeader_28;
    private ColumnHeader columnHeader_29;
    private ColumnHeader columnHeader_30;
    private ColumnHeader columnHeader_31;
    private ColumnHeader columnHeader_32;
    private ColumnHeader columnHeader_33;
    private ColumnHeader columnHeader_34;
    private ColumnHeader columnHeader_35;
    private ColumnHeader columnHeader_36;
    private ColumnHeader columnHeader_37;
    private ColumnHeader columnHeader_38;
    private ColumnHeader columnHeader_39;
    private ColumnHeader columnHeader_40;
    private ListView lstvUsage;
    private ColumnHeader columnHeader_41;
    private ColumnHeader columnHeader_42;
    private ColumnHeader columnHeader_43;
    private ColumnHeader columnHeader_44;
    private ColumnHeader columnHeader_45;
    private ColumnHeader columnHeader_46;
    private ColumnHeader columnHeader_47;
    private ColumnHeader columnHeader_48;
    private ColumnHeader columnHeader_49;
    private ColumnHeader columnHeader_50;
    private ColumnHeader columnHeader_51;
    private ListView lstvShipyards;
    private ColumnHeader columnHeader_52;
    private ColumnHeader columnHeader_53;
    private ColumnHeader columnHeader_54;
    private ColumnHeader columnHeader_55;
    private ColumnHeader columnHeader_56;
    private ColumnHeader columnHeader_57;
    private ColumnHeader columnHeader_58;
    private ColumnHeader columnHeader_59;
    private ColumnHeader columnHeader_60;
    private ColumnHeader columnHeader_61;
    private Panel panel1;
    private ComboBox cboShipyardUpgrade;
    private Button cmdAutoRename;
    private Button cmdRenameShipyard;
    private Button cmdPauseActivity;
    private Button cmdDeleteActivity;
    private Button cmdSetActivity;
    private Label label7;
    private Label label6;
    private ComboBox cboRetoolClass;
    private Label txtShipyardUpgradeDate;
    private Label txtShipyardUpgradeCost;
    private Timer timer_0;
    private Panel panel3;
    private Label lblFleet;
    private ComboBox cboFleet;
    private Label label11;
    private ComboBox cboShip;
    private Label lblEligible;
    private ComboBox cboEligible;
    private Label lblRefitFrom;
    private ComboBox cboRefitFrom;
    private Label lblTaskType;
    private ComboBox cboShipyardTaskType;
    private Button cmdDefaultFleet;
    private Button cmdAddShipyardTask;
    private Label lblBuildCost;
    private Label label16;
    private Label lblShipyardConstructionDate;
    private Label label14;
    private Button cmdRefitDetails;
    private Button cmdSelectName;
    private TextBox txtShipName;
    private ListView lstvSYMinerals;
    private ColumnHeader columnHeader_62;
    private ColumnHeader columnHeader_63;
    private ColumnHeader columnHeader_64;
    private ListView lstvRefitDetails;
    private ColumnHeader columnHeader_65;
    private ColumnHeader columnHeader_66;
    private ColumnHeader columnHeader_67;
    private Button cmdDeleteTask;
    private ListView lstvShipyardTasks;
    private ColumnHeader columnHeader_68;
    private ColumnHeader columnHeader_69;
    private ColumnHeader columnHeader_70;
    private ColumnHeader columnHeader_71;
    private ColumnHeader columnHeader_72;
    private ColumnHeader columnHeader_73;
    private ColumnHeader columnHeader_74;
    private Button cmdSelectNameTaskShip;
    private Button cmdRenameTaskShip;
    private Button cmdPauseTask;
    private TabPage tabGUTraining;
    private TabPage tabWealth;
    private ListView lstvGroundUnitTraining;
    private ColumnHeader columnHeader_75;
    private ColumnHeader columnHeader_76;
    private ColumnHeader columnHeader_77;
    private ColumnHeader columnHeader_78;
    private Button cmdDeleteGUTask;
    private Button cmdAddGUTask;
    private Button cmdSMAddUnits;
    private Button cmdRenameType;
    private Button cmdRenameGUTask;
    private ColumnHeader columnHeader_79;
    private Panel panel6;
    private Label lblMaintenance;
    private Button cmdMaintenance;
    private Panel panel5;
    private Label lblRefineries;
    private Button cmdRefinery;
    private Panel panel4;
    private ListView lstvTradeGoods;
    private ColumnHeader columnHeader_80;
    private ColumnHeader columnHeader_81;
    private ColumnHeader columnHeader_82;
    private ColumnHeader columnHeader_83;
    private ColumnHeader columnHeader_84;
    private ColumnHeader columnHeader_85;
    private ListView lstvExpenditure;
    private ColumnHeader columnHeader_86;
    private ColumnHeader columnHeader_87;
    private ColumnHeader columnHeader_88;
    private ListView lstvIncome;
    private ColumnHeader columnHeader_89;
    private ColumnHeader columnHeader_90;
    private ColumnHeader columnHeader_91;
    private Label label13;
    private TextBox txtPopPerCapita;
    private Label label12;
    private TextBox txtRacialPerCapita;
    private Label label8;
    private TextBox txtAnnualWealth;
    private Panel panel7;
    private RadioButton rdoOneYear;
    private RadioButton rdoSixMonths;
    private RadioButton rdoThreeMonths;
    private RadioButton rdoOneMonth;
    private ListView lstvTechnology;
    private ColumnHeader columnHeader_92;
    private ColumnHeader columnHeader_93;
    private ComboBox cboResearchFields;
    private ListView lstvScientists;
    private ColumnHeader columnHeader_94;
    private ColumnHeader columnHeader_95;
    private ColumnHeader columnHeader_96;
    private ColumnHeader columnHeader_97;
    private CheckBox chkMatchOnly;
    private Button cmdRemoveTech;
    private Button cmdDeleteProject;
    private Button cmdInstantRST;
    private Button cmdInstant;
    private Button cmdCreateResearch;
    private Label label15;
    private TextBox txtAssignFacilities;
    private Label label18;
    private Label lblRFAvailable;
    private TextBox txtTechDescription;
    private Button cmdRemoveQueue;
    private Button cmdDownResearchQueue;
    private Button cmdUpResearchQueue;
    private Button cmdAddToQueue;
    private RadioButton optProjectSelectCompleted;
    private RadioButton optProjectSelectAvail;
    private Button cmdDeleteTech;
    private Button cmdRemoveLab;
    private Button cmdAddLab;
    private Button cmdPauseResearch;
    private Button cmdRenamePop;
    private Button cmdDeletePopulation;
    private ComboBox cboMassDriver;
    private Label label17;
    private ListView lstvTemplate;
    private ColumnHeader columnHeader_98;
    private ColumnHeader columnHeader_99;
    private ColumnHeader columnHeader_100;
    private ColumnHeader columnHeader_101;
    private ColumnHeader columnHeader_102;
    private ColumnHeader columnHeader_103;
    private ColumnHeader columnHeader_104;
    private ColumnHeader columnHeader_105;
    private FlowLayoutPanel flowLayoutPanel2;
    private FlowLayoutPanel flpCreateProjectsBar;
    private FlowLayoutPanel flowLayoutPanel4;
    private Label lblInstant;
    private Label lblStartingTechPoints;
    private TextBox txtUnitName;
    private ListView lstvPopMissiles;
    private ColumnHeader columnHeader_106;
    private ColumnHeader columnHeader_107;
    private ListView lstvPopComponents;
    private ColumnHeader columnHeader_108;
    private ColumnHeader columnHeader_109;
    private Button cmdScrapMissile;
    private Button cmdDisassemble;
    private Button cmdScrapComponent;
    private FlowLayoutPanel flowLayoutPanel5;
    private TabPage tabCivilian;
    private ComboBox cboSupply;
    private ListView lstvSupply;
    private ColumnHeader columnHeader_110;
    private ColumnHeader columnHeader_111;
    private Button cmdDemand;
    private ComboBox cboDemand;
    private ListView lstvDemand;
    private ColumnHeader columnHeader_112;
    private ColumnHeader columnHeader_113;
    private FlowLayoutPanel flowLayoutPanel6;
    private FlowLayoutPanel flowLayoutPanel7;
    private Button cmdEditSupply;
    private Button cmdSupply;
    private Button cmdDeleteSupply;
    private ListView lstvInstallations;
    private ColumnHeader columnHeader_114;
    private ColumnHeader columnHeader_115;
    private Button cmdEditDemand;
    private Button cmdDeleteDemand;
    private FlowLayoutPanel flowLayoutPanel8;
    private ComboBox cboSMInstallations;
    private Button cmdSMAddInstallation;
    private Button cmdSMEditInstallation;
    private Button cmdSMDeleteInstallation;
    private ColumnHeader columnHeader_116;
    private ColumnHeader columnHeader_117;
    private Button cmdDeleteSY;
    private Label lblIndustry;
    private FlowLayoutPanel flowLayoutPanel9;
    private Label lblCT;
    private TextBox txtCT;
    private FlowLayoutPanel flowLayoutPanel10;
    private RadioButton rdoDestination;
    private RadioButton rdoSource;
    private RadioButton rdoStable;
    private TabPage tabEnvironment;
    private FlowLayoutPanel flpAddGas;
    private ComboBox cboGas;
    private CheckBox chkAddGas;
    private Label label10;
    private TextBox txtMaxAtm;
    private Button cmdSMSetAtm;
    private ListView lstvAtmosphere;
    private ColumnHeader columnHeader_118;
    private ColumnHeader columnHeader_119;
    private ColumnHeader columnHeader_120;
    private Label lblSetSL;
    private TextBox txtSetSL;
    private Label lblHydroExt;
    private TextBox txtHydroExt;
    private Button cmdHydroExt;
    private Button cmdEditPopAmount;
    private Button cmdAddSY;
    private Button cmdDisassembleAll;
    private CheckBox chkReserve;
    private FlowLayoutPanel flpPurchase;
    private RadioButton rdoPurchase;
    private RadioButton rdoTaxMinerals;
    private Label lblCivilianMinerals;
    private TextBox txtCivilianMinerals;
    private Button cmdPopAsText;
    private Button cmdAllPopAsText;
    private FlowLayoutPanel flowLayoutPanel15;
    private Button cmdDeleteEmpty;
    private Button cmdToggleEmpty;
    private CheckBox chkUseComponents;
    private CheckBox chkRestricted;
    private Button cmdRenameAcademy;
    private Button cmdIndependence;
    private FlowLayoutPanel flowLayoutPanel16;
    private CheckBox chkShowStars;
    private FlowLayoutPanel flpRPSort;
    private RadioButton rdoLabs;
    private RadioButton rdoDate;
    private TabPage tabEmpireMining;
    private FlowLayoutPanel flowLayoutPanel18;
    private RadioButton rdoTaskSize;
    private RadioButton rdoTaskDate;
    private Button cmdAddOG;
    private FlowLayoutPanel flowLayoutPanel19;
    private ComboBox cboSpaceStations;
    private Label label19;
    private Button cmdDownQueueGround;
    private Button cmdUpQueueGround;
    private TextBox txtInstantBuild;
    private Label label9;
    private Panel pnlStartingBuildPoints;
    private TabPage tabAncientConstruct;
    private ListView lstvConstructs;
    private ColumnHeader columnHeader_121;
    private ColumnHeader columnHeader_122;
    private ColumnHeader columnHeader_123;
    private ColumnHeader columnHeader_124;
    private ColumnHeader columnHeader_125;
    private ColumnHeader columnHeader_126;
    private FlowLayoutPanel flpSpecies;
    private FlowLayoutPanel flowLayoutPanel21;
    private Label label20;
    private Label label21;
    private Label label22;
    private FlowLayoutPanel flowLayoutPanel22;
    private Label lblBreathe;
    private Label lblOxygen;
    private Label label23;
    private Label label31;
    private Label label32;
    private Label label33;
    private Label lblGravity;
    private Label lblTemperature;
    private Label lblPressure;
    private Label label34;
    private Label label35;
    private Button cmdCapital;
    private Button cmdAssignNew;
    private TabPage tabGovernor;
    private ListView lstvGovernor;
    private ColumnHeader columnHeader_127;
    private ColumnHeader columnHeader_128;
    private ComboBox cboBonusThree;
    private ComboBox cboBonusTwo;
    private ComboBox cboBonusOne;
    private Label label37;
    private TextBox txtImportance;
    private FlowLayoutPanel flowLayoutPanel23;
    private Label label39;
    private Label label36;
    private Label label40;
    private FlowLayoutPanel flowLayoutPanel24;
    private Button cmdAssignGovernors;
    private Button cmdReassignAllGovernors;
    private TreeView tvPopGU;
    private CheckBox chkRoman;
    private CheckBox chkCreationDate;
    private FlowLayoutPanel flowLayoutPanel25;
    private Button cmdScrapInstallation;
    private FlowLayoutPanel flpColonyCostFactors;
    private FlowLayoutPanel flowLayoutPanel13;
    private Label label38;
    private Label label25;
    private Label label27;
    private Label label26;
    private Label label28;
    private Label label29;
    private Label label24;
    private Label label30;
    private Label label41;
    private FlowLayoutPanel flowLayoutPanel14;
    private Label lblColonyCost;
    private Label lblCCTemp;
    private Label lblBreathable;
    private Label lblDangerous;
    private Label lblMaxPressure;
    private Label lblWater;
    private Label lblCCGravity;
    private Label lblRetention;
    private Label lblPerihelionCC;
    private Label label42;
    private Label lblAphelionCC;
    private ColumnHeader columnHeader_129;
    private ListView lstvEmpireStockpiles;
    private ColumnHeader columnHeader_130;
    private ColumnHeader columnHeader_131;
    private ColumnHeader columnHeader_132;
    private ColumnHeader columnHeader_133;
    private ColumnHeader columnHeader_134;
    private ColumnHeader columnHeader_135;
    private ColumnHeader columnHeader_136;
    private ColumnHeader columnHeader_137;
    private ColumnHeader columnHeader_138;
    private ColumnHeader columnHeader_139;
    private ColumnHeader columnHeader_140;
    private ColumnHeader columnHeader_141;
    private FlowLayoutPanel flowLayoutPanel26;
    private Label label43;
    private Label lblMDDistance;
    private CheckBox chkAutoRefuel;
    private Button cmdEditWealth;
    private FlowLayoutPanel flowLayoutPanel11;
    private Button cmdTransferItem;
    private Button cmdTransferOrdnance;
    private ListView lstvWealthHistory;
    private ColumnHeader columnHeader_142;
    private ColumnHeader columnHeader_143;
    private ColumnHeader columnHeader_144;
    private ColumnHeader columnHeader_145;
    private ColumnHeader columnHeader_146;
    private Label label44;
    private ComboBox cboParasites;
    private Label label45;
    private TextBox txtGUPercentage;
    private ColumnHeader columnHeader_147;
    private ListView lstvEmpireMiningProduction;
    private ColumnHeader columnHeader_148;
    private ColumnHeader columnHeader_149;
    private ColumnHeader columnHeader_150;
    private ColumnHeader columnHeader_151;
    private ColumnHeader columnHeader_152;
    private ColumnHeader columnHeader_153;
    private ColumnHeader columnHeader_154;
    private ColumnHeader columnHeader_155;
    private ColumnHeader columnHeader_156;
    private ColumnHeader columnHeader_157;
    private ColumnHeader columnHeader_158;
    private ColumnHeader columnHeader_159;
    private Panel pnlGeneticModification;
    private Label lblGeneticModification;
    private Button cmdGMC;
    private Label label46;
    private ComboBox cboTargetSpecies;
    private RadioButton rdoYes;
    private RadioButton rdoNo;
    private RadioButton rdoNone;
    private Label label49;
    private TextBox txtTaxRate;
    private Button cmdEditTax;
    private FlowLayoutPanel flowLayoutPanel12;
    private Label label47;
    private TextBox txtFuelWarning;
    private Label label48;
    private TextBox txtMSPWarning;
    private Button cmdSelectGovernor;
    private RadioButton rdoConstant;
    private RadioButton rdoSingleWarning;
    private ComboBox cboAdminCommand;
    private CheckBox chkAdminCommand;
    private Label lblAdminCommand;
    private Panel panel2;
    private ComboBox cboTransferRace;
    private Button cmdTransferPopulation;
    private FlowLayoutPanel flowLayoutPanel20;
    private RadioButton rdoNormalView;
    private RadioButton rdoProjectOnlyView;
    private ListView lstvResearchProjects;
    private ColumnHeader columnHeader_160;
    private ColumnHeader columnHeader_161;
    private ColumnHeader columnHeader_162;
    private ColumnHeader columnHeader_163;
    private ColumnHeader columnHeader_164;
    private ColumnHeader columnHeader_165;
    private ColumnHeader columnHeader_166;
    private ColumnHeader columnHeader_167;
    private ColumnHeader columnHeader_168;
    private ColumnHeader columnHeader_169;
    private FlowLayoutPanel flowLayoutPanel3;
    private RadioButton rdoPopProjects;
    private RadioButton rdoAllProjects;
    private Button cmdConvert;
    private Button cmdResearchComponent;
    private TextBox txtComponentDetail;
    private Button cmdResearchMissile;
    private TabPage tabPOW;
    private ListView lstvPOWOfficers;
    private FlowLayoutPanel flowLayoutPanel17;
    private RadioButton rdoPOWPop;
    private RadioButton rdoPOWEmpire;
    private ColumnHeader columnHeader_170;
    private ColumnHeader columnHeader_171;
    private ColumnHeader columnHeader_172;
    private ColumnHeader columnHeader_173;
    private ColumnHeader columnHeader_174;
    private ColumnHeader columnHeader_175;
    private Button cmdRelease;
    private Button cmdScrapAll;
    private Button cmdClearQueue;
    private Button cmdEditMSP;
    private Button cmdEditFuel;
    private TabPage tabMineralData;
    private ListView lstvMineralData;
    private ColumnHeader columnHeader_176;
    private ColumnHeader columnHeader_177;
    private ColumnHeader columnHeader_178;
    private ColumnHeader columnHeader_179;
    private ColumnHeader columnHeader_180;
    private ColumnHeader columnHeader_181;
    private ColumnHeader columnHeader_182;
    private ColumnHeader columnHeader_183;
    private ColumnHeader columnHeader_184;
    private ColumnHeader columnHeader_185;
    private ColumnHeader columnHeader_186;
    private ColumnHeader columnHeader_187;
    private FlowLayoutPanel flowLayoutPanel27;
    private RadioButton rdoMinMonth;
    private RadioButton rdoMin3Months;
    private RadioButton rdoMin6Months;
    private RadioButton rdoMinYear;
    private CheckBox chkCurrentPopulation;

    public Economics(GClass0 gclass0_1, GEnum34 genum34_1, PopulationData gclass146_1)
    {
        this.InitializeComponent();
        this.DoubleBuffered = true;
        this.gclass0_0 = gclass0_1;
        this.genum34_0 = genum34_1;
        this.gclass146_0 = gclass146_1;
    }

    public void method_0(Control control_0)
    {
        control_0.BackColor = Color.White;
        control_0.ForeColor = Color.Black;
        foreach (Control control in (ArrangedElementCollection)control_0.Controls)
            this.method_0(control);
    }

    public void method_1()
    {
        this.BackColor = Color.White;
        this.ForeColor = Color.Black;
        foreach (Control control in (ArrangedElementCollection)this.Controls)
            this.method_0(control);
    }

    private void method_2(GClass193 gclass193_1)
    {
        try
        {
            this.gclass146_0.method_131(this.lstvShipyards, false);
            this.gclass146_0.method_119(this.lstvMining, this.lstvMines, this.lstvUsage);
            if (gclass193_1 == null)
                return;
            foreach (ListViewItem listViewItem in this.lstvShipyards.Items)
            {
                listViewItem.Selected = false;
                if ((GClass193)listViewItem.Tag == gclass193_1)
                    listViewItem.Selected = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 526);
        }
    }

    public void method_3(GEnum34 genum34_1)
    {
        try
        {
            switch (genum34_1)
            {
                case GEnum34.const_0:
                    this.tabPopulation.SelectTab(this.tabSummary);
                    break;
                case GEnum34.const_1:
                    this.tabPopulation.SelectTab(this.tabIndustry);
                    break;
                case GEnum34.const_2:
                    this.tabPopulation.SelectTab(this.tabResearch);
                    break;
                case GEnum34.const_3:
                    this.tabPopulation.SelectTab(this.tabWealth);
                    break;
                case GEnum34.const_4:
                    this.tabPopulation.SelectTab(this.tabShipyards);
                    break;
                case GEnum34.const_5:
                    this.tabPopulation.SelectTab(this.tabSYTasks);
                    break;
                case GEnum34.const_6:
                    this.tabPopulation.SelectTab(this.tabMining);
                    break;
                case GEnum34.const_7:
                    this.tabPopulation.SelectTab(this.tabGUTraining);
                    break;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 527);
        }
    }

    private void Economics_Load(object sender, EventArgs e)
    {
        try
        {
            this.gclass0_0.bool_9 = true;
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            this.bool_0 = true;
            this.method_4();
            this.method_5();
            this.method_6();
            this.method_7();
            this.gclass0_0.method_580(this.cboBonusOne, AuroraCommanderType.Administrator);
            this.gclass0_0.method_580(this.cboBonusTwo, AuroraCommanderType.Administrator);
            this.gclass0_0.method_580(this.cboBonusThree, AuroraCommanderType.Administrator);
            this.gclass0_0.method_577(this.cboRaces);
            this.gclass0_0.method_571(this.cboResearchFields);
            this.method_11();
            this.method_3(this.genum34_0);
            if (!this.gclass0_0.bool_8 && this.gclass21_0.StartTechPoints <= 0)
                this.cmdInstant.Visible = false;
            else
                this.cmdInstant.Visible = true;
            if (this.gclass0_0.bool_8)
            {
                this.cmdInstantRST.Visible = true;
                this.cmdSMAddInstallation.Visible = true;
                this.cmdSMEditInstallation.Visible = true;
                this.cmdSMDeleteInstallation.Visible = true;
                this.cboSMInstallations.Visible = true;
                this.cmdSMSetAtm.Visible = true;
                this.txtHydroExt.Visible = true;
                this.lblHydroExt.Visible = true;
                this.cmdHydroExt.Visible = true;
                this.cmdEditPopAmount.Visible = true;
                this.cmdEditWealth.Visible = true;
                this.cmdAddSY.Visible = true;
                this.cmdEditFuel.Visible = true;
                this.cmdEditMSP.Visible = true;
                this.lstvInstallations.Margin = new Padding(0, 3, 3, 3);
            }
            else
            {
                this.cmdInstantRST.Visible = false;
                this.cmdSMAddInstallation.Visible = false;
                this.cmdSMEditInstallation.Visible = false;
                this.cmdSMDeleteInstallation.Visible = false;
                this.cboSMInstallations.Visible = false;
                this.cmdSMSetAtm.Visible = false;
                this.txtHydroExt.Visible = false;
                this.lblHydroExt.Visible = false;
                this.cmdHydroExt.Visible = false;
                this.cmdEditPopAmount.Visible = false;
                this.cmdEditWealth.Visible = false;
                this.cmdAddSY.Visible = false;
                this.cmdEditFuel.Visible = false;
                this.cmdEditMSP.Visible = false;
                this.lstvInstallations.Margin = new Padding(0, 30, 3, 3);
            }

            if (!this.gclass0_0.bool_8 && !(this.gclass21_0.StartBuildPoints > 0M))
                this.cmdSMAddUnits.Visible = false;
            else
                this.cmdSMAddUnits.Visible = true;
            if (this.gclass0_0.bool_10)
                this.cmdAddOG.Visible = true;
            this.gclass0_0.bool_9 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 528);
        }
    }

    private void method_4()
    {
        try
        {
            List<string> stringList = new List<string>();
            foreach (AuroraProductionType enum_0 in Enum.GetValues(typeof(AuroraProductionType)))
                stringList.Add(AuroraUtils.smethod_82(enum_0));
            this.cboConstructionType.DataSource = stringList;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 529);
        }
    }

    private void method_5()
    {
        try
        {
            this.gclass0_0.bool_13 = true;
            List<AtmosphericGasDefinition> list = this.gclass0_0.AtmosphericGasDictionary.Values
                .OrderBy<AtmosphericGasDefinition, string>(gclass223_0 => gclass223_0.Name).ToList<AtmosphericGasDefinition>();
            this.cboGas.DisplayMember = "Name";
            this.cboGas.DataSource = list;
            this.gclass0_0.bool_13 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 530);
        }
    }

    private void method_6()
    {
        try
        {
            List<string> stringList = new List<string>();
            foreach (AuroraShipyardUpgradeType enum_0 in Enum.GetValues(typeof(AuroraShipyardUpgradeType)))
            {
                if (enum_0 != AuroraShipyardUpgradeType.SMModify || this.gclass0_0.bool_8)
                    stringList.Add(AuroraUtils.smethod_82(enum_0));
            }

            this.cboShipyardUpgrade.DataSource = stringList;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 531);
        }
    }

    private void method_7()
    {
        try
        {
            List<string> stringList = new List<string>();
            foreach (AuroraSYTaskType enum_0 in Enum.GetValues(typeof(AuroraSYTaskType)))
                stringList.Add(AuroraUtils.smethod_82(enum_0));
            this.cboShipyardTaskType.DataSource = stringList;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 532);
        }
    }

    public void method_8(FCTRaceRecordC21 gclass21_1)
    {
        try
        {
            this.bool_0 = true;
            this.cboRaces.SelectedItem = gclass21_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 533);
        }
    }

    public void method_9()
    {
        try
        {
            if (this.gclass146_0 == null)
                return;
            this.gclass146_0.method_121(this.lstvGroundUnitTraining);
            this.gclass146_0.method_119(this.lstvMining, this.lstvMines, this.lstvUsage);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3617);
        }
    }

    public void method_10()
    {
        try
        {
            this.cboRetoolClass.DataSource = null;
            this.gclass21_0 = (FCTRaceRecordC21)this.cboRaces.SelectedValue;
            if (this.gclass146_0 == null)
                this.gclass146_0 = this.gclass21_0.method_191();
            else if (this.gclass146_0.RaceData != this.gclass21_0)
                this.gclass146_0 = this.gclass21_0.method_191();
            this.chkShowSystemBody.CheckState = AuroraUtils.smethod_28(this.gclass21_0.ShowPopSystemBody);
            this.chkShowStars.CheckState = AuroraUtils.smethod_28(this.gclass21_0.ShowPopStar);
            this.chkHideCMC.CheckState = AuroraUtils.smethod_28(this.gclass21_0.HideCMCPop);
            this.chkByFunction.CheckState = AuroraUtils.smethod_28(this.gclass21_0.PopByFunction);
            this.chkRoman.CheckState = this.gclass21_0.checkState_0;
            this.gclass21_0.method_298();
            this.gclass21_0.method_338();
            this.Text =
                $"Economics   {this.gclass0_0.method_586(true)}   Racial Wealth {AuroraUtils.smethod_38(this.gclass21_0.WealthPoints)}";
            this.gclass21_0.method_59(this.tvPopList, this.chkByFunction.CheckState, this.chkShowSystemBody.CheckState,
                this.chkShowStars.CheckState, this.chkHideCMC.CheckState, this.gclass146_0);
            this.gclass21_0.method_330(this.cboTransferRace);
            if (this.gclass21_0.StartTechPoints > 0)
            {
                this.lblStartingTechPoints.Text = AuroraUtils.smethod_37(this.gclass21_0.StartTechPoints);
                this.lblStartingTechPoints.Visible = true;
                this.lblInstant.Visible = true;
            }

            this.pnlStartingBuildPoints.Visible = false;
            if (this.gclass0_0.bool_8 || this.gclass21_0.StartBuildPoints > 0M)
            {
                this.cmdSMAddUnits.Visible = true;
                if (this.gclass21_0.StartBuildPoints > 0M)
                {
                    this.pnlStartingBuildPoints.Visible = true;
                    this.txtInstantBuild.Text = AuroraUtils.smethod_38(this.gclass21_0.StartBuildPoints);
                }
            }

            if (!this.bool_0)
                this.gclass0_0.method_511(this.gclass21_0, this);
            this.bool_0 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 534);
        }
    }

    private void cboRaces_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.method_10();
            this.cboRaces.Focus();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 535);
        }
    }

    private void method_11()
    {
        ToolTip toolTip = new ToolTip();
        toolTip.AutoPopDelay = 2000;
        toolTip.InitialDelay = 750;
        toolTip.ReshowDelay = 500;
        toolTip.ShowAlways = true;
        toolTip.SetToolTip(this.cmdCreateResearch,
            "Create project using selected tech, scientist and number of research facilities");
        toolTip.SetToolTip(this.cmdAddToQueue,
            "Create queued project using selected tech and selected current project (the new tech will be researched by the same scientist and number of labs as the current project)");
        toolTip.SetToolTip(this.cmdRemoveTech, "Remove knowledge of the selected completed tech from the current race");
        toolTip.SetToolTip(this.cmdDeleteTech, "Delete the selected race-specific tech from the current race");
        toolTip.SetToolTip(this.cmdRenameGUTask, "Rename the formation being constructed by the selected task");
        toolTip.SetToolTip(this.cmdRenameType, "Rename the selected formation template");
        toolTip.SetToolTip(this.chkReserve,
            "If this is unchecked and SM mode is active, double-clicking will set the stockpile amount");
        toolTip.SetToolTip(this.cmdDeleteEmpty,
            "Delete all colonies that have no population, no ground forces, no installations, no stockpiles, no abandoned installations and no ground survey potential and is not the destination of any fleet");
        toolTip.SetToolTip(this.cmdToggleEmpty, "Flag a colony as being exempt from the Delete Empty function");
        toolTip.SetToolTip(this.cmdSelectGovernor, "Select a currently unassigned governor for this colony");
    }

    private void tvPopList_AfterSelect(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (e.Node.Tag is RacialSystemSurvey)
            {
                this.gclass202_0 = (RacialSystemSurvey)e.Node.Tag;
            }
            else
            {
                if (!(e.Node.Tag is PopulationData))
                    return;
                this.gclass146_0 = (PopulationData)e.Node.Tag;
                this.method_12();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 536);
        }
    }

    private void method_12()
    {
        try
        {
            this.cmdAddGUTask.Enabled = true;
            this.txtTechDescription.Text = "";
            this.cboEligible.DataSource = null;
            this.txtShipyardUpgradeCost.Text = "N/A";
            this.txtShipyardUpgradeDate.Text = "N/A";
            this.gclass193_0 = null;
            this.gclass192_0 = null;
            Decimal decimal_90 = this.method_17();
            this.gclass146_0.method_155(this.lstvPopSummary, this.lstvPopSummary2, this.lstvPopSummary3,
                this.lblGovName, this.lblSecGovName, this.cboFighters, this.cboSpaceStations, this.cboParasites,
                this.cboFleet, this.cboAdminCommand, this.lblRefineries, this.lblMaintenance,
                this.lblGeneticModification, this.cmdRefinery, this.cmdMaintenance, this.cmdGMC, this.cboGas,
                this.chkAddGas, this.txtMaxAtm, this.lblMDDistance);
            this.gclass146_0.method_153(this.lstvGovernor, this.cboBonusOne, this.cboBonusTwo, this.cboBonusThree,
                this.rdoNo, this.rdoYes, this.rdoNone, this.txtImportance);
            this.gclass146_0.method_132(this.lstvConstruction);
            this.gclass146_0.method_131(this.lstvShipyards, true);
            this.gclass146_0.method_178(this.lstvPOWOfficers, this.rdoPOWEmpire.Checked);
            this.gclass146_0.method_120(this.lstvShipyardTasks, this.rdoTaskSize);
            this.gclass146_0.method_121(this.lstvGroundUnitTraining);
            this.gclass146_0.method_119(this.lstvMining, this.lstvMines, this.lstvUsage);
            this.gclass146_0.method_112(this.lstvTradeGoods);
            this.gclass146_0.method_111(this.lstvWealthHistory);
            this.gclass146_0.method_110(this.lstvIncome, this.lstvExpenditure, this.txtAnnualWealth,
                this.txtRacialPerCapita, this.txtPopPerCapita, this.txtTaxRate, decimal_90);
            this.gclass146_0.method_158(this.lstPI, this.cboConstructionType.Text, this.lblIndustry,
                this.cboConstructionType);
            this.gclass21_0.method_214(this.lstvTemplate, this.gclass146_0, CheckState.Unchecked, null,
                CheckState.Unchecked);
            this.gclass146_0.method_102(this.lstvResearchProjects, this.lblRFAvailable, this.rdoLabs.Checked,
                this.cboResearchFields, this.chkMatchOnly, this.rdoPopProjects.Checked);
            this.gclass146_0.method_58(this.lstvPopMissiles, this.lstvPopComponents);
            this.gclass0_0.bool_9 = true;
            this.gclass146_0.method_23(this.cboTargetSpecies);
            this.cboTargetSpecies.SelectedItem = this.gclass146_0.GenModSpeciesData;
            this.txtFuelWarning.Text = AuroraUtils.smethod_37(this.gclass146_0.WarningFuel);
            this.txtMSPWarning.Text = AuroraUtils.smethod_37(this.gclass146_0.WarningMSP);
            if (this.gclass146_0.WarningConstant == 1)
                this.rdoConstant.Checked = true;
            else
                this.rdoSingleWarning.Checked = true;
            this.gclass0_0.bool_9 = false;
            if (!this.gclass146_0.SystemBodyData.IsFixedBody)
            {
                this.lstvAtmosphere.Visible = true;
                this.flpColonyCostFactors.Visible = true;
                this.flpAddGas.Visible = true;
                this.flpSpecies.Visible = true;
                this.cmdIndependence.Visible = true;
                this.cmdAddGUTask.Visible = true;
                this.txtUnitName.Visible = true;
                this.chkRoman.Visible = true;
                if (this.gclass0_0.bool_8)
                {
                    this.cmdSMAddInstallation.Visible = true;
                    this.cmdSMEditInstallation.Visible = true;
                    this.cmdSMDeleteInstallation.Visible = true;
                    if (this.gclass21_0.StartBuildPoints > 0M)
                        this.cmdSMAddUnits.Visible = true;
                }

                if (this.gclass21_0.StartBuildPoints > 0M)
                {
                    this.pnlStartingBuildPoints.Visible = true;
                    this.txtInstantBuild.Text = AuroraUtils.smethod_38(this.gclass21_0.StartBuildPoints);
                }

                this.gclass146_0.SystemBodyData.method_70(this.lstvAtmosphere, this.gclass146_0, true);
                this.gclass146_0.SystemBodyData.method_71(this.gclass21_0, this.gclass146_0.SpeciesData,
                    CheckState.Unchecked, this.lblRetention, this.lblCCGravity, this.lblCCTemp, this.lblBreathable,
                    this.lblMaxPressure, this.lblDangerous, this.lblWater, this.lblColonyCost, this.lblPerihelionCC,
                    this.lblAphelionCC, 3);
                this.gclass146_0.SpeciesData.method_0(this.lblGravity, this.lblOxygen, this.lblTemperature,
                    this.lblBreathe, this.lblPressure);
            }
            else
            {
                this.lstvAtmosphere.Visible = false;
                this.flpColonyCostFactors.Visible = false;
                this.flpAddGas.Visible = false;
                this.flpSpecies.Visible = false;
                this.cmdIndependence.Visible = false;
                this.cmdAddGUTask.Visible = false;
                this.txtUnitName.Visible = false;
                this.chkRoman.Visible = false;
                this.cmdSMAddUnits.Visible = false;
                this.pnlStartingBuildPoints.Visible = false;
                this.cmdSMAddInstallation.Visible = false;
                this.cmdSMEditInstallation.Visible = false;
                this.cmdSMDeleteInstallation.Visible = false;
            }

            if (this.gclass146_0.SpeciesData.gclass194_0 == null)
                this.pnlGeneticModification.Visible = true;
            else
                this.pnlGeneticModification.Visible = false;
            this.gclass21_0.method_371(this.tvPopGU, this.gclass146_0, this.chkCreationDate.CheckState);
            this.gclass21_0.method_337(this.lstvConstructs);
            PlanetaryInstallationType gclass157_0 = new PlanetaryInstallationType();
            if (this.cboDemand.Items.Count > 0)
                gclass157_0 = (PlanetaryInstallationType)this.cboDemand.SelectedItem;
            this.gclass146_0.method_161(this.cboDemand, false, gclass157_0);
            if (this.cboSupply.Items.Count > 0)
                gclass157_0 = (PlanetaryInstallationType)this.cboSupply.SelectedItem;
            this.gclass146_0.method_161(this.cboSupply, true, gclass157_0);
            if (this.cboSMInstallations.Items.Count > 0)
                gclass157_0 = (PlanetaryInstallationType)this.cboSMInstallations.SelectedItem;
            this.gclass146_0.method_161(this.cboSMInstallations, false, gclass157_0);
            this.gclass146_0.method_163(this.lstvDemand, false);
            this.gclass146_0.method_163(this.lstvSupply, true);
            this.gclass146_0.method_162(this.lstvInstallations);
            this.gclass146_0.method_164(this.rdoDestination, this.rdoSource, this.rdoStable);
            this.gclass146_0.method_165(this.flpPurchase, this.rdoPurchase, this.rdoTaxMinerals,
                this.lblCivilianMinerals, this.txtCivilianMinerals);
            this.gclass146_0.method_166(this.cboMassDriver);
            this.bool_1 = true;
            this.chkRestricted.CheckState = !this.gclass146_0.bMilitaryRestrictedColony ? CheckState.Unchecked : CheckState.Checked;
            this.chkAutoRefuel.CheckState = !this.gclass146_0.bAutoRefuel ? CheckState.Unchecked : CheckState.Checked;
            this.bool_1 = false;
            ResearchFieldData selectedValue = (ResearchFieldData)this.cboResearchFields.SelectedValue;
            if (selectedValue != null)
            {
                this.gclass146_0.method_108(this.lstvTechnology, selectedValue);
                this.gclass146_0.method_107(this.lstvScientists, selectedValue, this.chkMatchOnly.CheckState);
            }

            this.gclass21_0.method_87(this.lstvEmpireStockpiles);
            this.gclass21_0.method_89(this.lstvEmpireMiningProduction);
            this.method_13();
            this.tvPopList.Focus();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 537);
        }
    }

    public void method_13()
    {
        try
        {
            Decimal decimal_29 = this.method_18();
            if (this.chkCurrentPopulation.CheckState == CheckState.Checked)
                this.gclass21_0.method_88(this.lstvMineralData, this.gclass146_0, decimal_29);
            else
                this.gclass21_0.method_88(this.lstvMineralData, null, decimal_29);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3945);
        }
    }

    public void method_14()
    {
        try
        {
            if (this.gclass146_0 == null)
                return;
            ResearchFieldData selectedValue = (ResearchFieldData)this.cboResearchFields.SelectedValue;
            if (selectedValue == null)
                return;
            this.gclass146_0.method_107(this.lstvScientists, selectedValue, this.chkMatchOnly.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3188);
        }
    }

    private void tvPopList_AfterExpand(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || e.Node.Tag is RacialSystemSurvey || e.Node.Tag is Star197 || e.Node.Tag is PopulationData)
                return;
            string tag = (string)e.Node.Tag;
            if (tag == null)
                return;
            switch (tag.Length)
            {
                case 2:
                    if (!(tag == "AM"))
                        break;
                    this.gclass21_0.bool_8 = e.Node.IsExpanded;
                    break;
                case 3:
                    switch (tag[0])
                    {
                        case 'C':
                            if (!(tag == "CMC"))
                                return;
                            this.gclass21_0.bool_9 = e.Node.IsExpanded;
                            return;
                        case 'D':
                            if (!(tag == "DST"))
                                return;
                            this.gclass21_0.bool_10 = e.Node.IsExpanded;
                            return;
                        case 'P':
                            if (!(tag == "Pop"))
                                return;
                            this.gclass21_0.bool_7 = e.Node.IsExpanded;
                            return;
                        default:
                            return;
                    }
                case 4:
                    if (!(tag == "Arch"))
                        break;
                    this.gclass21_0.bool_11 = e.Node.IsExpanded;
                    break;
                case 5:
                    switch (tag[0])
                    {
                        case 'O':
                            if (!(tag == "Other"))
                                return;
                            this.gclass21_0.bool_13 = e.Node.IsExpanded;
                            return;
                        case 'T':
                            if (!(tag == "Terra"))
                                return;
                            this.gclass21_0.bool_12 = e.Node.IsExpanded;
                            return;
                        default:
                            return;
                    }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 538);
        }
    }

    private void cboConstructionType_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
                return;
            this.gclass146_0.method_158(this.lstPI, this.cboConstructionType.Text, this.lblIndustry,
                this.cboConstructionType);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 539);
        }
    }

    private void cmdCreate_Click(object sender, EventArgs e)
    {
        try
        {
            ParsedDecimal gclass208_1 = AuroraUtils.ParseDecimalString(this.txtItems.Text);
            ParsedDecimal gclass208_2 = AuroraUtils.ParseDecimalString(this.txtPercentage.Text);
            if (!gclass208_1.Succeed || !gclass208_2.Succeed)
                return;
            this.gclass146_0.method_143(gclass208_1.Value, gclass208_2.Value);
            this.gclass146_0.method_132(this.lstvConstruction);
            this.gclass146_0.method_119(this.lstvMining, this.lstvMines, this.lstvUsage);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 540);
        }
    }

    private void lstPI_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass146_0.method_159(this.lstvMinerals, this.cboConstructionType.Text, this.lstPI.SelectedValue);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 541);
        }
    }

    private void lstvConstruction_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvConstruction.SelectedItems.Count == 0)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                GClass156 tag = (GClass156)this.lstvConstruction.SelectedItems[0].Tag;
                if (tag == null)
                    return;
                this.txtItems.Text = tag.decimal_0.ToString();
                this.txtPercentage.Text = tag.decimal_3.ToString();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 542);
        }
    }

    private void cmdCancel_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvConstruction.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a project to cancel");
            }
            else
            {
                this.gclass146_0.method_135((GClass156)this.lstvConstruction.SelectedItems[0].Tag);
                this.gclass146_0.method_132(this.lstvConstruction);
                this.gclass146_0.method_119(this.lstvMining, this.lstvMines, this.lstvUsage);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 543);
        }
    }

    private void cmdModify_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvConstruction.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a project to modify");
            }
            else
            {
                GClass156 tag = (GClass156)this.lstvConstruction.SelectedItems[0].Tag;
                ParsedDecimal gclass208_1 = AuroraUtils.ParseDecimalString(this.txtItems.Text);
                ParsedDecimal gclass208_2 = AuroraUtils.ParseDecimalString(this.txtPercentage.Text);
                if (!gclass208_1.Succeed || !gclass208_2.Succeed)
                    return;
                this.gclass146_0.method_142(tag, gclass208_1.Value, gclass208_2.Value);
                this.gclass146_0.method_132(this.lstvConstruction);
                this.gclass146_0.method_119(this.lstvMining, this.lstvMines, this.lstvUsage);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 544);
        }
    }

    private void cmdPause_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvConstruction.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a project to pause");
            }
            else
            {
                this.gclass146_0.method_136((GClass156)this.lstvConstruction.SelectedItems[0].Tag);
                this.gclass146_0.method_132(this.lstvConstruction);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 545);
        }
    }

    private void cmdUpQueue_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvConstruction.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a project to move");
            }
            else
            {
                GClass156 tag = (GClass156)this.lstvConstruction.SelectedItems[0].Tag;
                this.gclass146_0.method_140(tag);
                this.gclass146_0.method_132(this.lstvConstruction);
                foreach (ListViewItem listViewItem in this.lstvConstruction.Items)
                {
                    if (listViewItem.Tag == tag)
                        listViewItem.Selected = true;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 546);
        }
    }

    private void cmdDownQueue_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvConstruction.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a project to move");
            }
            else
            {
                GClass156 tag = (GClass156)this.lstvConstruction.SelectedItems[0].Tag;
                this.gclass146_0.method_141(tag);
                this.gclass146_0.method_132(this.lstvConstruction);
                foreach (ListViewItem listViewItem in this.lstvConstruction.Items)
                {
                    if (listViewItem.Tag == tag)
                        listViewItem.Selected = true;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 547);
        }
    }

    private void cboShipyardUpgrade_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.method_15();
            this.gclass146_0.method_123(this.gclass193_0, this.cboShipyardUpgrade.Text, this.txtShipyardUpgradeCost,
                this.txtShipyardUpgradeDate, this.cboRetoolClass, this.lblCT, this.txtCT, this.lblSetSL, this.txtSetSL,
                true);
            this.timer_0.Enabled = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 548);
        }
    }

    private void lstvShipyards_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.lstvShipyards.SelectedItems.Count == 0)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                this.gclass193_0 = (GClass193)this.lstvShipyards.SelectedItems[0].Tag;
                if (this.gclass193_0 == null)
                    return;
                this.gclass146_0.method_123(this.gclass193_0, this.cboShipyardUpgrade.Text, this.txtShipyardUpgradeCost,
                    this.txtShipyardUpgradeDate, this.cboRetoolClass, this.lblCT, this.txtCT, this.lblSetSL,
                    this.txtSetSL, false);
                this.method_31(this.gclass193_0.int_3);
                if (this.gclass193_0.gclass85_0 != null)
                    this.cboFleet.SelectedItem = this.gclass193_0.gclass85_0;
                if (this.gclass193_0.gclass83_0 != null)
                    this.cboAdminCommand.SelectedItem = this.gclass193_0.gclass83_0;
                if (this.gclass193_0.method_1() == this.gclass193_0.int_1)
                    this.cmdAddShipyardTask.Enabled = false;
                else
                    this.cmdAddShipyardTask.Enabled = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 549);
        }
    }

    private void cboRetoolClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.lstvShipyards.SelectedItems.Count == 0)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                this.gclass193_0 = (GClass193)this.lstvShipyards.SelectedItems[0].Tag;
                this.gclass146_0.method_127(this.gclass193_0, (GClass22)this.cboRetoolClass.SelectedItem,
                    this.txtShipyardUpgradeCost, this.txtShipyardUpgradeDate);
                this.timer_0.Enabled = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 550);
        }
    }

    private void timer_0_Tick(object sender, EventArgs e)
    {
        this.cboShipyardUpgrade.Select(0, 0);
        this.cboRetoolClass.Select(0, 0);
        this.timer_0.Enabled = false;
    }

    private void cmdSetActivity_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_15())
                return;
            if (this.gclass193_0.gclass40_1 != null)
            {
                int num1 = (int)MessageBox.Show(this.gclass193_0.string_0 + " is ship-based and cannot be modified",
                    "Action Not Possible");
            }
            else
            {
                if (this.gclass193_0.auroraShipyardUpgradeType_0 != AuroraShipyardUpgradeType.None && MessageBox.Show(
                        this.gclass193_0.string_0 +
                        " already has a task in progress. Are you sure you want to cancel the existing shipyard activity?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                int int_25 = 0;
                if (this.txtCT.Visible)
                    int_25 = Convert.ToInt32(this.txtCT.Text);
                GClass22 selectedItem = (GClass22)this.cboRetoolClass.SelectedItem;
                AuroraShipyardUpgradeType auroraShipyardUpgradeType_0 = AuroraShipyardUpgradeType.None;
                string text = this.cboShipyardUpgrade.Text;
                if (text != null)
                {
                    switch (text.Length)
                    {
                        case 6:
                            if (text == "Retool")
                            {
                                auroraShipyardUpgradeType_0 = AuroraShipyardUpgradeType.Retool;
                                selectedItem.bool_3 = true;
                                break;
                            }

                            break;
                        case 11:
                            switch (text[0])
                            {
                                case 'A':
                                    if (text == "Add Slipway")
                                    {
                                        auroraShipyardUpgradeType_0 = AuroraShipyardUpgradeType.AddSlipway;
                                        break;
                                    }

                                    break;
                                case 'N':
                                    if (text == "No Activity")
                                    {
                                        auroraShipyardUpgradeType_0 = AuroraShipyardUpgradeType.None;
                                        break;
                                    }

                                    break;
                            }

                            break;
                        case 20:
                            if (text == "Add 500 ton Capacity")
                            {
                                auroraShipyardUpgradeType_0 = AuroraShipyardUpgradeType.Add500;
                                break;
                            }

                            break;
                        case 21:
                            switch (text[4])
                            {
                                case '1':
                                    if (text == "Add 1000 ton Capacity")
                                    {
                                        auroraShipyardUpgradeType_0 = AuroraShipyardUpgradeType.Add1000;
                                        break;
                                    }

                                    break;
                                case '2':
                                    if (text == "Add 2000 ton Capacity")
                                    {
                                        auroraShipyardUpgradeType_0 = AuroraShipyardUpgradeType.Add2000;
                                        break;
                                    }

                                    break;
                                case '5':
                                    if (text == "Add 5000 ton Capacity")
                                    {
                                        auroraShipyardUpgradeType_0 = AuroraShipyardUpgradeType.Add5000;
                                        break;
                                    }

                                    break;
                            }

                            break;
                        case 23:
                            if (text == "Add 10,000 ton Capacity")
                            {
                                auroraShipyardUpgradeType_0 = AuroraShipyardUpgradeType.Add10000;
                                break;
                            }

                            break;
                        case 24:
                            if (text == "Spacemaster Modification")
                            {
                                this.gclass193_0.decimal_0 = Convert.ToInt32(this.txtCT.Text);
                                this.gclass193_0.int_1 = Convert.ToInt32(this.txtSetSL.Text);
                                break;
                            }

                            break;
                        case 26:
                            if (text == "Continual Capacity Upgrade")
                            {
                                auroraShipyardUpgradeType_0 = AuroraShipyardUpgradeType.Continual;
                                break;
                            }

                            break;
                    }
                }

                if (auroraShipyardUpgradeType_0 == AuroraShipyardUpgradeType.Retool && selectedItem == null)
                {
                    int num2 = (int)MessageBox.Show("Please select a refit class");
                }
                else
                {
                    GClass193 gclass1930 = this.gclass193_0;
                    if (auroraShipyardUpgradeType_0 != AuroraShipyardUpgradeType.None &&
                        auroraShipyardUpgradeType_0 == AuroraShipyardUpgradeType.Continual &&
                        int_25 < this.gclass193_0.decimal_0)
                    {
                        int num3 = (int)MessageBox.Show("Target Capacity is less than current capacity");
                    }
                    else
                    {
                        this.gclass146_0.method_124(this.gclass193_0, auroraShipyardUpgradeType_0, selectedItem,
                            int_25);
                        this.method_2(gclass1930);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 551);
        }
    }

    private void cmdDeleteActivity_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_15() || this.gclass193_0.auroraShipyardUpgradeType_0 != AuroraShipyardUpgradeType.None &&
                MessageBox.Show(
                    $" Are you sure you want to cancel the shipyard activity for {this.gclass193_0.string_0}?",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            GClass193 gclass1930 = this.gclass193_0;
            this.gclass146_0.method_125(this.gclass193_0);
            this.method_2(gclass1930);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 552);
        }
    }

    private void cmdPauseActivity_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_15())
                return;
            GClass193 gclass1930 = this.gclass193_0;
            this.gclass193_0.bool_0 = !this.gclass193_0.bool_0;
            this.method_2(gclass1930);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 553);
        }
    }

    private void cmdRenameShipyard_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            int index = this.lstvShipyards.SelectedItems[0].Index;
            this.gclass0_0.string_3 = "Enter New Shipyard Name";
            this.gclass0_0.string_4 = this.gclass193_0.string_0;
            int num = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.string_4 != this.gclass193_0.string_0 && !this.gclass0_0.bool_21)
            {
                GClass193 gclass1930 = this.gclass193_0;
                this.gclass193_0.string_0 = this.gclass0_0.string_4;
                this.method_2(gclass1930);
            }

            this.lstvShipyards.Items[index].Selected = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 554);
        }
    }

    public bool method_15()
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
                return false;
            }

            if (this.lstvShipyards.SelectedItems.Count == 0)
            {
                int num = (int)MessageBox.Show("Please select a shipyard");
                return false;
            }

            this.gclass193_0 = (GClass193)this.lstvShipyards.SelectedItems[0].Tag;
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 555);
            return false;
        }
    }

    private void cboShipyardTaskType_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.method_15();
            this.cboShip.DataSource = null;
            this.txtShipName.Text = "N/A";
            this.lblBuildCost.Text = "N/A";
            this.lblShipyardConstructionDate.Text = "N/A";
            this.lstvSYMinerals.Items.Clear();
            switch (this.cboShipyardTaskType.Text)
            {
                case "Construction":
                    this.cboShip.Visible = false;
                    this.txtShipName.Visible = true;
                    this.cboRefitFrom.Visible = false;
                    this.lblRefitFrom.Visible = false;
                    this.cboEligible.Visible = true;
                    this.lblEligible.Visible = true;
                    this.cmdSelectName.Enabled = true;
                    this.cmdRefitDetails.Enabled = false;
                    this.lstvRefitDetails.Visible = false;
                    if (this.chkAdminCommand.CheckState == CheckState.Checked)
                    {
                        this.cboAdminCommand.Visible = true;
                        this.lblAdminCommand.Visible = true;
                        this.cboFleet.Visible = false;
                        this.lblFleet.Visible = false;
                        this.cmdDefaultFleet.Text = "Default Admin";
                    }
                    else
                    {
                        this.cboAdminCommand.Visible = false;
                        this.lblAdminCommand.Visible = false;
                        this.cboFleet.Visible = true;
                        this.lblFleet.Visible = true;
                        this.cmdDefaultFleet.Text = "Default Fleet";
                    }

                    this.gclass146_0.method_128(this.gclass193_0, true, false, false, false, this.cboEligible);
                    if (this.cboEligible.Items.Count <= 0)
                        break;
                    this.gclass193_0.method_5(this.cboShipyardTaskType, this.cboEligible, this.cboRefitFrom,
                        this.cboShip, this.cboFleet, this.cboAdminCommand, this.lstvSYMinerals, this.txtShipName,
                        this.lblBuildCost, this.lblShipyardConstructionDate, this.lstvRefitDetails);
                    break;
                case "Repair":
                case "Scrap":
                    this.cboShip.Visible = true;
                    this.txtShipName.Visible = false;
                    this.cboFleet.Visible = false;
                    this.lblFleet.Visible = false;
                    this.cboRefitFrom.Visible = false;
                    this.lblRefitFrom.Visible = false;
                    this.cboEligible.Visible = true;
                    this.lblEligible.Visible = true;
                    this.cmdSelectName.Enabled = false;
                    this.cmdRefitDetails.Enabled = false;
                    this.lstvRefitDetails.Visible = false;
                    this.cboAdminCommand.Visible = false;
                    this.lblAdminCommand.Visible = false;
                    if (this.cboShipyardTaskType.Text == "Repair")
                    {
                        this.gclass146_0.method_200(this.gclass193_0, this.cboEligible);
                        if (this.cboEligible.Items.Count > 0)
                            this.gclass146_0.method_199((GClass22)this.cboEligible.SelectedItem, this.cboShip);
                    }
                    else
                    {
                        this.gclass146_0.method_128(this.gclass193_0, false, true, false, true, this.cboEligible);
                        if (this.cboEligible.Items.Count > 0)
                            this.gclass146_0.method_129((GClass22)this.cboEligible.SelectedItem, this.cboShip, false,
                                false, true);
                    }

                    if (this.cboShip.Items.Count <= 0)
                        break;
                    this.gclass193_0.method_5(this.cboShipyardTaskType, this.cboEligible, this.cboRefitFrom,
                        this.cboShip, this.cboFleet, this.cboAdminCommand, this.lstvSYMinerals, this.txtShipName,
                        this.lblBuildCost, this.lblShipyardConstructionDate, this.lstvRefitDetails);
                    break;
                case "Refit":
                case "Auto Refit":
                    this.cboShip.Visible = true;
                    this.txtShipName.Visible = false;
                    this.cboFleet.Visible = false;
                    this.lblFleet.Visible = false;
                    this.cboRefitFrom.Visible = true;
                    this.lblRefitFrom.Visible = true;
                    this.cboEligible.Visible = true;
                    this.lblEligible.Visible = true;
                    this.cmdSelectName.Enabled = false;
                    this.cmdRefitDetails.Enabled = true;
                    this.cboAdminCommand.Visible = false;
                    this.lblAdminCommand.Visible = false;
                    this.gclass146_0.method_128(this.gclass193_0, true, false, false, false, this.cboEligible);
                    this.gclass146_0.method_128(this.gclass193_0, false, true, true, true, this.cboRefitFrom);
                    if (this.cboRefitFrom.Items.Count > 0)
                        this.gclass146_0.method_129((GClass22)this.cboRefitFrom.SelectedItem, this.cboShip, true, false,
                            true);
                    if (this.cboShip.Items.Count <= 0)
                        break;
                    this.gclass193_0.method_5(this.cboShipyardTaskType, this.cboEligible, this.cboRefitFrom,
                        this.cboShip, this.cboFleet, this.cboAdminCommand, this.lstvSYMinerals, this.txtShipName,
                        this.lblBuildCost, this.lblShipyardConstructionDate, this.lstvRefitDetails);
                    break;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 556);
        }
    }

    private void cboEligible_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            switch (this.cboShipyardTaskType.Text)
            {
                case "Construction":
                case "Refit":
                case "Auto Refit":
                    this.gclass193_0.method_5(this.cboShipyardTaskType, this.cboEligible, this.cboRefitFrom,
                        this.cboShip, this.cboFleet, this.cboAdminCommand, this.lstvSYMinerals, this.txtShipName,
                        this.lblBuildCost, this.lblShipyardConstructionDate, this.lstvRefitDetails);
                    break;
                case "Repair":
                    this.gclass146_0.method_199((GClass22)this.cboEligible.SelectedItem, this.cboShip);
                    if (this.cboShip.Items.Count <= 0)
                        break;
                    this.gclass193_0.method_5(this.cboShipyardTaskType, this.cboEligible, this.cboRefitFrom,
                        this.cboShip, this.cboFleet, this.cboAdminCommand, this.lstvSYMinerals, this.txtShipName,
                        this.lblBuildCost, this.lblShipyardConstructionDate, this.lstvRefitDetails);
                    break;
                case "Scrap":
                    this.gclass146_0.method_129((GClass22)this.cboEligible.SelectedItem, this.cboShip, false, false,
                        true);
                    if (this.cboShip.Items.Count <= 0)
                        break;
                    this.gclass193_0.method_5(this.cboShipyardTaskType, this.cboEligible, this.cboRefitFrom,
                        this.cboShip, this.cboFleet, this.cboAdminCommand, this.lstvSYMinerals, this.txtShipName,
                        this.lblBuildCost, this.lblShipyardConstructionDate, this.lstvRefitDetails);
                    break;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 557);
        }
    }

    private void cboShip_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass193_0.method_5(this.cboShipyardTaskType, this.cboEligible, this.cboRefitFrom, this.cboShip,
                this.cboFleet, this.cboAdminCommand, this.lstvSYMinerals, this.txtShipName, this.lblBuildCost,
                this.lblShipyardConstructionDate, this.lstvRefitDetails);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 558);
        }
    }

    private void cboRefitFrom_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass146_0.method_129((GClass22)this.cboRefitFrom.SelectedItem, this.cboShip, true, false, true);
            this.gclass193_0.method_5(this.cboShipyardTaskType, this.cboEligible, this.cboRefitFrom, this.cboShip,
                this.cboFleet, this.cboAdminCommand, this.lstvSYMinerals, this.txtShipName, this.lblBuildCost,
                this.lblShipyardConstructionDate, this.lstvRefitDetails);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 559);
        }
    }

    private void cmdAddShipyardTask_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_15())
                return;
            if (this.cboShipyardTaskType.Text == "Construction")
                this.gclass193_0.auroraSYTaskType_0 = AuroraSYTaskType.Construction;
            else if (this.cboShipyardTaskType.Text == "Refit")
                this.gclass193_0.auroraSYTaskType_0 = AuroraSYTaskType.Refit;
            else if (this.cboShipyardTaskType.Text == "Auto Refit")
                this.gclass193_0.auroraSYTaskType_0 = AuroraSYTaskType.AutoRefit;
            else if (this.cboShipyardTaskType.Text == "Repair")
                this.gclass193_0.auroraSYTaskType_0 = AuroraSYTaskType.Repair;
            else if (this.cboShipyardTaskType.Text == "Scrap")
                this.gclass193_0.auroraSYTaskType_0 = AuroraSYTaskType.Scrap;
            GClass193 gclass1930 = this.gclass193_0;
            if (!this.gclass193_0.method_4(this.chkUseComponents.CheckState, this.chkAdminCommand.CheckState,
                    this.cboRefitFrom, this.cboEligible, this.cboShip))
                return;
            this.gclass146_0.method_120(this.lstvShipyardTasks, this.rdoTaskSize);
            this.gclass146_0.method_119(this.lstvMining, this.lstvMines, this.lstvUsage);
            if (gclass1930 != null)
            {
                foreach (ListViewItem listViewItem in this.lstvShipyards.Items)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    Economics.Class1077 class1077 = new Economics.Class1077();
                    // ISSUE: reference to a compiler-generated field
                    class1077.gclass193_0 = (GClass193)listViewItem.Tag;
                    // ISSUE: reference to a compiler-generated field
                    if (class1077.gclass193_0 == gclass1930)
                    {
                        // ISSUE: reference to a compiler-generated method
                        List<GClass192> list = this.gclass0_0.dictionary_32.Values.Where<GClass192>(class1077.method_0)
                            .ToList<GClass192>();
                        // ISSUE: reference to a compiler-generated field
                        int num = class1077.gclass193_0.int_1 - list.Count;
                        listViewItem.SubItems[4].Text = num.ToString();
                        if (this.gclass193_0.auroraSYTaskType_0 == AuroraSYTaskType.Construction)
                            this.txtShipName.Text = this.gclass193_0.gclass22_2.method_39();
                    }
                }
            }

            if (this.gclass193_0.method_1() == this.gclass193_0.int_1)
                this.cmdAddShipyardTask.Enabled = false;
            else
                this.cmdAddShipyardTask.Enabled = true;
            this.gclass146_0.method_58(this.lstvPopMissiles, this.lstvPopComponents);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 560);
        }
    }

    private void cmdDefaultFleet_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_15())
                return;
            if (this.cmdDefaultFleet.Text == "Default Fleet")
                this.gclass193_0.gclass85_0 = (FleetData)this.cboFleet.SelectedItem;
            else
                this.gclass193_0.gclass83_0 = (NavalAdminCommand)this.cboAdminCommand.SelectedItem;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 561);
        }
    }

    private void cmdSelectName_Click(object sender, EventArgs e)
    {
        try
        {
            int num = (int)new cmdSelect(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.bool_21 || this.gclass0_0.string_4 == "" || this.gclass0_0.string_4 == null)
                return;
            this.txtShipName.Text = this.gclass0_0.string_4;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 562);
        }
    }

    private void cmdRefitDetails_Click(object sender, EventArgs e)
    {
        if (this.lstvRefitDetails.Visible)
            this.lstvRefitDetails.Visible = false;
        else
            this.lstvRefitDetails.Visible = true;
    }

    private void cmdAutoRename_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_15())
                return;
            int index = this.lstvShipyards.SelectedItems[0].Index;
            GClass193 gclass1930 = this.gclass193_0;
            this.gclass193_0.string_0 = this.gclass146_0.method_151();
            this.method_2(gclass1930);
            this.lstvShipyards.Items[index].Selected = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 563);
        }
    }

    private void cmdDeleteTask_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass192_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a shipyard task");
            }
            else
            {
                if (MessageBox.Show(
                        $" Are you sure you want to delete the shipyard task: {this.gclass192_0.method_0()}?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.gclass0_0.dictionary_32.Remove(this.gclass192_0.int_0);
                this.method_2(this.gclass193_0);
                this.gclass146_0.method_120(this.lstvShipyardTasks, this.rdoTaskSize);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 564);
        }
    }

    private void lstvShipyardTasks_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                if (this.lstvShipyardTasks.SelectedItems.Count == 0)
                    return;
                this.gclass192_0 = (GClass192)this.lstvShipyardTasks.SelectedItems[0].Tag;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 565);
        }
    }

    private void cmdPauseTask_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass192_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a shipyard task");
            }
            else
            {
                this.gclass192_0.bool_2 = !this.gclass192_0.bool_2;
                this.gclass146_0.method_120(this.lstvShipyardTasks, this.rdoTaskSize);
                this.gclass146_0.method_119(this.lstvMining, this.lstvMines, this.lstvUsage);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 566);
        }
    }

    private void cmdSelectNameTaskShip_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass192_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a shipyard task");
            }
            else
            {
                int index = this.lstvShipyardTasks.SelectedItems[0].Index;
                int num2 = (int)new cmdSelect(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21 || this.gclass0_0.string_4 == "")
                    return;
                if (this.gclass0_0.string_4 != null)
                    this.gclass192_0.string_0 = this.gclass0_0.string_4;
                this.gclass146_0.method_120(this.lstvShipyardTasks, this.rdoTaskSize);
                this.lstvShipyardTasks.Items[index].Selected = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 567);
        }
    }

    private void cmdRenameTaskShip_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass192_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a shipyard task");
            }
            else
            {
                this.gclass0_0.string_3 = "Enter New Ship Name";
                this.gclass0_0.string_4 = this.gclass192_0.string_0;
                int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (!(this.gclass0_0.string_4 != this.gclass192_0.string_0) || this.gclass0_0.bool_21)
                    return;
                this.gclass192_0.string_0 = this.gclass0_0.string_4;
                this.gclass146_0.method_120(this.lstvShipyardTasks, this.rdoTaskSize);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 568);
        }
    }

    private void cmdAddGUTask_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvTemplate.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a ground unit type");
            }
            else
            {
                GroundUnitFormationTemplateData tag = (GroundUnitFormationTemplateData)this.lstvTemplate.SelectedItems[0].Tag;
                if ((int)this.gclass146_0.method_62(AuroraProductionCategory.GroundTraining) <= 0)
                {
                    int num3 = (int)MessageBox.Show(
                        "You cannot build ground forces without a ground forces construction complex");
                }
                else if (this.gclass146_0.decimal_29 + this.gclass146_0.Population <= 0M)
                {
                    int num4 = (int)MessageBox.Show(
                        "You cannot build ground forces without workers to man the ground forces construction complex");
                }
                else
                {
                    ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.txtGUPercentage.Text);
                    if (100M - this.gclass146_0.dictionary_3.Values.Sum<GClass106>(gclass106_0 =>
                            gclass106_0.decimal_2) < gclass208.Value)
                        this.gclass146_0.list_0.Add(new GClass107(this.gclass0_0)
                        {
                            int_0 = this.gclass146_0.list_0.Count + 1,
                            gclass146_0 = this.gclass146_0,
                            string_0 = this.txtUnitName.Text,
                            gclass102_0 = tag,
                            decimal_0 = gclass208.Value,
                            auroraGroundFormationFieldPosition_0 = AuroraGroundFormationFieldPosition.FrontlineDefence
                        });
                    else
                        this.gclass146_0.method_122(tag, this.txtUnitName.Text, gclass208.Value,
                            AuroraGroundFormationFieldPosition.FrontlineDefence, 0, 0);
                    ++tag.FormationTrained;
                    this.gclass146_0.method_121(this.lstvGroundUnitTraining);
                    this.gclass146_0.method_119(this.lstvMining, this.lstvMines, this.lstvUsage);
                    string str1 = AuroraUtils.smethod_80(tag.FormationTrained + 1);
                    if (this.chkRoman.CheckState == CheckState.Checked)
                    {
                        string str2 = AuroraUtils.smethod_79(tag.FormationTrained + 1);
                        this.txtUnitName.Text = $"{tag.Name} {str2}";
                    }
                    else
                        this.txtUnitName.Text = $"{str1} {tag.Name}";
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 569);
        }
    }

    private void cmdRenameGUTask_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvGroundUnitTraining.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a training task");
            }
            else if (this.lstvGroundUnitTraining.SelectedItems[0].Tag == null)
            {
                int num3 = (int)MessageBox.Show("Please select a training task");
            }
            else
            {
                if (this.lstvGroundUnitTraining.SelectedItems[0].Tag is GClass106)
                {
                    GClass106 tag = (GClass106)this.lstvGroundUnitTraining.SelectedItems[0].Tag;
                    this.gclass0_0.string_3 = "Enter New Formation Name";
                    this.gclass0_0.string_4 = tag.string_0;
                    int num4 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                    if (this.gclass0_0.string_4 != tag.string_0 && !this.gclass0_0.bool_21)
                        tag.string_0 = this.gclass0_0.string_4;
                }
                else if (this.lstvGroundUnitTraining.SelectedItems[0].Tag is GClass107)
                {
                    GClass107 tag = (GClass107)this.lstvGroundUnitTraining.SelectedItems[0].Tag;
                    this.gclass0_0.string_3 = "Enter New Formation Name";
                    this.gclass0_0.string_4 = tag.string_0;
                    int num5 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                    if (this.gclass0_0.string_4 != tag.string_0 && !this.gclass0_0.bool_21)
                        tag.string_0 = this.gclass0_0.string_4;
                }

                this.gclass146_0.method_121(this.lstvGroundUnitTraining);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 570);
        }
    }

    private void cmdDeleteGUTask_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvGroundUnitTraining.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a training / production task");
            }
            else if (this.lstvGroundUnitTraining.SelectedItems[0].Tag == null)
            {
                int num3 = (int)MessageBox.Show("Please select a training / production task");
            }
            else
            {
                if (this.lstvGroundUnitTraining.SelectedItems[0].Tag is GClass106)
                {
                    GClass106 tag = (GClass106)this.lstvGroundUnitTraining.SelectedItems[0].Tag;
                    if (MessageBox.Show("Are you sure you wish to delete the selected task?", "Confirmation Required",
                            MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                    --tag.gclass102_0.FormationTrained;
                    this.gclass146_0.dictionary_3.Remove(tag.int_0);
                }
                else if (this.lstvGroundUnitTraining.SelectedItems[0].Tag is GClass107)
                {
                    GClass107 tag = (GClass107)this.lstvGroundUnitTraining.SelectedItems[0].Tag;
                    if (MessageBox.Show("Are you sure you wish to delete the selected queued task?",
                            "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                    --tag.gclass102_0.FormationTrained;
                    this.gclass146_0.list_0.Remove(tag);
                }

                this.gclass146_0.method_121(this.lstvGroundUnitTraining);
                this.gclass146_0.method_119(this.lstvMining, this.lstvMines, this.lstvUsage);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 571);
        }
    }

    private void method_16(object sender, EventArgs e)
    {
    }

    private void cmdRefinery_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                if (this.gclass146_0.bFuelProdStatus)
                {
                    this.gclass146_0.bFuelProdStatus = false;
                    this.cmdRefinery.Text = "Start";
                }
                else
                {
                    this.gclass146_0.bFuelProdStatus = true;
                    this.cmdRefinery.Text = "Stop";
                }

                this.gclass146_0.method_155(this.lstvPopSummary, this.lstvPopSummary2, this.lstvPopSummary3,
                    this.lblGovName, this.lblSecGovName, this.cboFighters, this.cboSpaceStations, this.cboParasites,
                    this.cboFleet, this.cboAdminCommand, this.lblRefineries, this.lblMaintenance,
                    this.lblGeneticModification, this.cmdRefinery, this.cmdMaintenance, this.cmdGMC, this.cboGas,
                    this.chkAddGas, this.txtMaxAtm, this.lblMDDistance);
                this.gclass146_0.method_119(this.lstvMining, this.lstvMines, this.lstvUsage);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 572);
        }
    }

    private void cmdMaintenance_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                if (this.gclass146_0.bMaintProdStatus)
                {
                    this.gclass146_0.bMaintProdStatus = false;
                    this.cmdMaintenance.Text = "Start";
                }
                else
                {
                    this.gclass146_0.bMaintProdStatus = true;
                    this.cmdMaintenance.Text = "Stop";
                }

                this.gclass146_0.method_155(this.lstvPopSummary, this.lstvPopSummary2, this.lstvPopSummary3,
                    this.lblGovName, this.lblSecGovName, this.cboFighters, this.cboSpaceStations, this.cboParasites,
                    this.cboFleet, this.cboAdminCommand, this.lblRefineries, this.lblMaintenance,
                    this.lblGeneticModification, this.cmdRefinery, this.cmdMaintenance, this.cmdGMC, this.cboGas,
                    this.chkAddGas, this.txtMaxAtm, this.lblMDDistance);
                this.gclass146_0.method_119(this.lstvMining, this.lstvMines, this.lstvUsage);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 573);
        }
    }

    private void rdoOneMonth_CheckedChanged(object sender, EventArgs e)
    {
        this.gclass146_0.method_110(this.lstvIncome, this.lstvExpenditure, this.txtAnnualWealth,
            this.txtRacialPerCapita, this.txtPopPerCapita, this.txtTaxRate, this.method_17());
    }

    private Decimal method_17()
    {
        Decimal num = 0M;
        if (this.rdoOneMonth.Checked)
            num = AuroraUtils.decimal_31;
        if (this.rdoThreeMonths.Checked)
            num = AuroraUtils.decimal_32;
        if (this.rdoSixMonths.Checked)
            num = AuroraUtils.decimal_33;
        if (this.rdoOneYear.Checked)
            num = AuroraUtils.decimal_29;
        return num;
    }

    private Decimal method_18()
    {
        Decimal num = 0M;
        if (this.rdoMinMonth.Checked)
            num = AuroraUtils.decimal_31;
        if (this.rdoMin3Months.Checked)
            num = AuroraUtils.decimal_32;
        if (this.rdoMin6Months.Checked)
            num = AuroraUtils.decimal_33;
        if (this.rdoMinYear.Checked)
            num = AuroraUtils.decimal_29;
        return num;
    }

    private void cboResearchFields_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.method_19();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 574);
        }
    }

    private void method_19()
    {
        try
        {
            if (this.gclass146_0 == null)
                return;
            ResearchFieldData selectedValue = (ResearchFieldData)this.cboResearchFields.SelectedValue;
            if (selectedValue == null)
                return;
            this.gclass146_0.method_107(this.lstvScientists, selectedValue, this.chkMatchOnly.CheckState);
            if (this.optProjectSelectAvail.Checked)
                this.gclass146_0.method_108(this.lstvTechnology, selectedValue);
            else if (this.optProjectSelectCompleted.Checked)
                this.gclass146_0.method_109(this.lstvTechnology, selectedValue);
            this.gclass146_0.method_102(this.lstvResearchProjects, this.lblRFAvailable, this.rdoLabs.Checked,
                this.cboResearchFields, this.chkMatchOnly, this.rdoPopProjects.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3200);
        }
    }

    private void chkMatchOnly_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
                return;
            ResearchFieldData selectedValue = (ResearchFieldData)this.cboResearchFields.SelectedValue;
            if (selectedValue == null)
                return;
            this.gclass146_0.method_107(this.lstvScientists, selectedValue, this.chkMatchOnly.CheckState);
            this.gclass146_0.method_102(this.lstvResearchProjects, this.lblRFAvailable, this.rdoLabs.Checked,
                this.cboResearchFields, this.chkMatchOnly, this.rdoPopProjects.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 575);
        }
    }

    private void cmdRemoveQueue_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvResearchProjects.SelectedItems.Count == 0)
                return;
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvResearchProjects.SelectedItems[0].Tag == null)
            {
                int num2 = (int)MessageBox.Show("Please select a queued research project");
            }
            else
            {
                if (MessageBox.Show("Are you sure you wish to cancel the selected queued research project?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes ||
                    !(this.lstvResearchProjects.SelectedItems[0].Tag is GClass166))
                    return;
                GClass166 tag = (GClass166)this.lstvResearchProjects.SelectedItems[0].Tag;
                this.gclass21_0.list_5.Remove(tag);
                this.gclass146_0.method_105(tag.gclass161_0);
                this.gclass146_0.method_102(this.lstvResearchProjects, this.lblRFAvailable, this.rdoLabs.Checked,
                    this.cboResearchFields, this.chkMatchOnly, this.rdoPopProjects.Checked);
                this.method_19();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 576);
        }
    }

    private void lstvTechnology_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.txtTechDescription.Text = "";
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                if (this.lstvTechnology.SelectedItems.Count == 0 || this.lstvTechnology.SelectedItems[0].Tag == null)
                    return;
                TechData164 tag = (TechData164)this.lstvTechnology.SelectedItems[0].Tag;
                this.txtTechDescription.Text = tag.string_1;
                if (tag.gclass21_0 == null)
                    this.cmdDeleteTech.Visible = false;
                else
                    this.cmdDeleteTech.Visible = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 577);
        }
    }

    private void lstvResearchProjects_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                if (this.lstvResearchProjects.SelectedItems.Count == 0)
                    return;
                if (this.lstvResearchProjects.SelectedItems[0].Tag == null)
                {
                    this.cmdDeleteProject.Visible = false;
                    this.cmdPauseResearch.Visible = false;
                    this.cmdAssignNew.Visible = false;
                    this.cmdAddLab.Visible = false;
                    this.cmdRemoveLab.Visible = false;
                    this.cmdUpResearchQueue.Visible = false;
                    this.cmdDownResearchQueue.Visible = false;
                    this.cmdRemoveQueue.Visible = false;
                }

                if (this.lstvResearchProjects.SelectedItems[0].Tag is GClass161)
                {
                    GClass161 tag = (GClass161)this.lstvResearchProjects.SelectedItems[0].Tag;
                    if (tag.gclass146_0 != this.gclass146_0)
                    {
                        this.cmdDeleteProject.Visible = false;
                        this.cmdPauseResearch.Visible = false;
                        this.cmdAssignNew.Visible = false;
                        this.cmdAddLab.Visible = false;
                        this.cmdRemoveLab.Visible = false;
                        this.cmdUpResearchQueue.Visible = false;
                        this.cmdDownResearchQueue.Visible = false;
                        this.cmdRemoveQueue.Visible = false;
                    }
                    else
                    {
                        this.cmdDeleteProject.Visible = true;
                        this.cmdPauseResearch.Visible = true;
                        this.cmdAssignNew.Visible = true;
                        this.cmdAddLab.Visible = true;
                        this.cmdRemoveLab.Visible = true;
                        this.cmdUpResearchQueue.Visible = false;
                        this.cmdDownResearchQueue.Visible = false;
                        this.cmdRemoveQueue.Visible = false;
                        this.cmdAddLab.Enabled = true;
                        this.cmdRemoveLab.Enabled = true;
                        if (tag.int_0 == 1)
                            this.cmdRemoveLab.Enabled = false;
                        if (tag.int_0 >= tag.gclass55_0.method_5(CommanderBonusType.ResearchAdmin))
                            this.cmdAddLab.Enabled = false;
                        if (this.gclass146_0.int_16 != 0)
                            return;
                        this.cmdAddLab.Enabled = false;
                    }
                }
                else
                {
                    if (!(this.lstvResearchProjects.SelectedItems[0].Tag is GClass166))
                        return;
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    Economics.Class1078 class1078 = new Economics.Class1078();
                    // ISSUE: reference to a compiler-generated field
                    class1078.gclass166_0 = (GClass166)this.lstvResearchProjects.SelectedItems[0].Tag;
                    this.cmdDeleteProject.Visible = false;
                    this.cmdPauseResearch.Visible = false;
                    this.cmdAssignNew.Visible = false;
                    this.cmdAddLab.Visible = false;
                    this.cmdRemoveLab.Visible = false;
                    this.cmdUpResearchQueue.Visible = true;
                    this.cmdDownResearchQueue.Visible = true;
                    this.cmdRemoveQueue.Visible = true;
                    this.cmdUpResearchQueue.Enabled = true;
                    this.cmdDownResearchQueue.Enabled = true;
                    // ISSUE: reference to a compiler-generated method
                    int num2 = this.gclass21_0.list_5.Where<GClass166>(class1078.method_0)
                        .Max<GClass166>(gclass166_0 => gclass166_0.int_0);
                    // ISSUE: reference to a compiler-generated method
                    int num3 = this.gclass21_0.list_5.Where<GClass166>(class1078.method_1)
                        .Min<GClass166>(gclass166_0 => gclass166_0.int_0);
                    // ISSUE: reference to a compiler-generated field
                    if (class1078.gclass166_0.int_0 == num3)
                        this.cmdUpResearchQueue.Enabled = false;
                    // ISSUE: reference to a compiler-generated field
                    if (class1078.gclass166_0.int_0 != num2)
                        return;
                    this.cmdDownResearchQueue.Enabled = false;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 578);
        }
    }

    private void cmdDeleteProject_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                if (this.lstvResearchProjects.SelectedItems.Count == 0)
                    return;
                if (this.lstvResearchProjects.SelectedItems[0].Tag == null)
                {
                    int num2 = (int)MessageBox.Show("Please select a research project");
                }
                else
                {
                    if (MessageBox.Show(
                            "Are you sure you wish to cancel the selected research project and any queued projects for this scientist?",
                            "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes ||
                        !(this.lstvResearchProjects.SelectedItems[0].Tag is GClass161))
                        return;
                    ((GClass161)this.lstvResearchProjects.SelectedItems[0].Tag).gclass55_0.method_40(true);
                    this.gclass146_0.method_102(this.lstvResearchProjects, this.lblRFAvailable, this.rdoLabs.Checked,
                        this.cboResearchFields, this.chkMatchOnly, this.rdoPopProjects.Checked);
                    ResearchFieldData selectedValue = (ResearchFieldData)this.cboResearchFields.SelectedValue;
                    if (selectedValue == null)
                        return;
                    this.gclass146_0.method_108(this.lstvTechnology, selectedValue);
                    this.gclass146_0.method_107(this.lstvScientists, selectedValue, this.chkMatchOnly.CheckState);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 579);
        }
    }

    private void cmdPauseResearch_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                if (this.lstvResearchProjects.SelectedItems.Count == 0)
                    return;
                if (this.lstvResearchProjects.SelectedItems[0].Tag == null)
                {
                    int num2 = (int)MessageBox.Show("Please select a research project");
                }
                else
                {
                    if (!(this.lstvResearchProjects.SelectedItems[0].Tag is GClass161))
                        return;
                    GClass161 tag = (GClass161)this.lstvResearchProjects.SelectedItems[0].Tag;
                    tag.bool_0 = !tag.bool_0;
                    int index = this.lstvResearchProjects.SelectedItems[0].Index;
                    this.gclass146_0.method_102(this.lstvResearchProjects, this.lblRFAvailable, this.rdoLabs.Checked,
                        this.cboResearchFields, this.chkMatchOnly, this.rdoPopProjects.Checked);
                    this.lstvResearchProjects.Items[index].Selected = true;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 580);
        }
    }

    private void cmdAddLab_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvResearchProjects.SelectedItems.Count == 0)
                return;
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvResearchProjects.SelectedItems[0].Tag == null)
            {
                int num2 = (int)MessageBox.Show("Please select a research project");
            }
            else
            {
                if (!(this.lstvResearchProjects.SelectedItems[0].Tag is GClass161))
                    return;
                GClass161 tag = (GClass161)this.lstvResearchProjects.SelectedItems[0].Tag;
                ++tag.int_0;
                this.gclass146_0.method_102(this.lstvResearchProjects, this.lblRFAvailable, this.rdoLabs.Checked,
                    this.cboResearchFields, this.chkMatchOnly, this.rdoPopProjects.Checked);
                foreach (ListViewItem listViewItem in this.lstvResearchProjects.Items)
                {
                    if (listViewItem.Tag is GClass161 && (GClass161)listViewItem.Tag == tag)
                    {
                        listViewItem.Selected = true;
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 581);
        }
    }

    private void cmdRemoveLab_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvResearchProjects.SelectedItems.Count == 0)
                return;
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvResearchProjects.SelectedItems[0].Tag == null)
            {
                int num2 = (int)MessageBox.Show("Please select a research project");
            }
            else
            {
                if (!(this.lstvResearchProjects.SelectedItems[0].Tag is GClass161))
                    return;
                GClass161 tag = (GClass161)this.lstvResearchProjects.SelectedItems[0].Tag;
                --tag.int_0;
                this.gclass146_0.method_102(this.lstvResearchProjects, this.lblRFAvailable, this.rdoLabs.Checked,
                    this.cboResearchFields, this.chkMatchOnly, this.rdoPopProjects.Checked);
                foreach (ListViewItem listViewItem in this.lstvResearchProjects.Items)
                {
                    if (listViewItem.Tag is GClass161 && (GClass161)listViewItem.Tag == tag)
                    {
                        listViewItem.Selected = true;
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 582);
        }
    }

    private void cmdUpResearchQueue_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvResearchProjects.SelectedItems.Count == 0)
                return;
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvResearchProjects.SelectedItems[0].Tag == null)
            {
                int num2 = (int)MessageBox.Show("Please select a queued research project");
            }
            else
            {
                if (!(this.lstvResearchProjects.SelectedItems[0].Tag is GClass166))
                    return;
                GClass166 tag = (GClass166)this.lstvResearchProjects.SelectedItems[0].Tag;
                this.gclass146_0.method_106(tag, true);
                this.gclass146_0.method_102(this.lstvResearchProjects, this.lblRFAvailable, this.rdoLabs.Checked,
                    this.cboResearchFields, this.chkMatchOnly, this.rdoPopProjects.Checked);
                this.method_21(tag);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 583);
        }
    }

    private void cmdDownResearchQueue_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvResearchProjects.SelectedItems.Count == 0)
                return;
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvResearchProjects.SelectedItems[0].Tag == null)
            {
                int num2 = (int)MessageBox.Show("Please select a queued research project");
            }
            else
            {
                if (!(this.lstvResearchProjects.SelectedItems[0].Tag is GClass166))
                    return;
                GClass166 tag = (GClass166)this.lstvResearchProjects.SelectedItems[0].Tag;
                this.gclass146_0.method_106(tag, false);
                this.gclass146_0.method_102(this.lstvResearchProjects, this.lblRFAvailable, this.rdoLabs.Checked,
                    this.cboResearchFields, this.chkMatchOnly, this.rdoPopProjects.Checked);
                this.method_21(tag);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 584);
        }
    }

    private void cmdCreateResearch_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvTechnology.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a technology to research");
            }
            else if (this.lstvScientists.SelectedItems.Count == 0)
            {
                int num3 = (int)MessageBox.Show("Please select a scientist to lead the project");
            }
            else if (this.gclass146_0.decimal_30 == 0M)
            {
                int num4 = (int)MessageBox.Show("You cannot create a project on a colony with no population");
            }
            else
            {
                int int32 = Convert.ToInt32(this.txtAssignFacilities.Text);
                if (int32 <= 0)
                {
                    int num5 = (int)MessageBox.Show("At least one research facility must be selected");
                }
                else if (!(this.lstvTechnology.SelectedItems[0].Tag is TechData164))
                {
                    int num6 = (int)MessageBox.Show("Please select a technology to research");
                }
                else
                {
                    TechData164 tag1 = (TechData164)this.lstvTechnology.SelectedItems[0].Tag;
                    GClass55 tag2 = (GClass55)this.lstvScientists.SelectedItems[0].Tag;
                    if (tag2 == null)
                    {
                        int num7 = (int)MessageBox.Show("Please select a scientist to lead the project");
                    }
                    else if (int32 > this.gclass146_0.int_16)
                    {
                        int num8 = (int)MessageBox.Show(
                            $"Too many facilities selected. There are only {this.gclass146_0.int_16.ToString()} facilities available at this population");
                    }
                    else
                    {
                        this.gclass146_0.method_104(tag1, tag2, int32, 0M);
                        this.gclass146_0.method_102(this.lstvResearchProjects, this.lblRFAvailable,
                            this.rdoLabs.Checked, this.cboResearchFields, this.chkMatchOnly,
                            this.rdoPopProjects.Checked);
                        ResearchFieldData selectedValue = (ResearchFieldData)this.cboResearchFields.SelectedValue;
                        if (selectedValue == null)
                            return;
                        this.gclass146_0.method_108(this.lstvTechnology, selectedValue);
                        this.gclass146_0.method_107(this.lstvScientists, selectedValue, this.chkMatchOnly.CheckState);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 585);
        }
    }

    private void cmdAddToQueue_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvTechnology.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a technology to add to the research queue");
            }
            else if (this.lstvResearchProjects.SelectedItems.Count == 0)
            {
                int num3 = (int)MessageBox.Show(
                    "Please select the existing project which the queued project will eventually replace");
            }
            else if (!(this.lstvResearchProjects.SelectedItems[0].Tag is GClass161))
            {
                int num4 = (int)MessageBox.Show(
                    "Please select the existing project which the queued project will eventually replace");
            }
            else if (!(this.lstvTechnology.SelectedItems[0].Tag is TechData164))
            {
                int num5 = (int)MessageBox.Show("Please select a tech system for the queued project");
            }
            else
            {
                TechData164 tag1 = (TechData164)this.lstvTechnology.SelectedItems[0].Tag;
                GClass161 tag2 = (GClass161)this.lstvResearchProjects.SelectedItems[0].Tag;
                this.gclass146_0.method_103(tag2, tag1);
                this.gclass146_0.method_102(this.lstvResearchProjects, this.lblRFAvailable, this.rdoLabs.Checked,
                    this.cboResearchFields, this.chkMatchOnly, this.rdoPopProjects.Checked);
                ResearchFieldData selectedValue = (ResearchFieldData)this.cboResearchFields.SelectedValue;
                if (selectedValue != null)
                {
                    this.gclass146_0.method_108(this.lstvTechnology, selectedValue);
                    this.gclass146_0.method_107(this.lstvScientists, selectedValue, this.chkMatchOnly.CheckState);
                }

                this.method_20(tag2);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 586);
        }
    }

    public void method_20(GClass161 gclass161_0)
    {
        try
        {
            foreach (ListViewItem listViewItem in this.lstvResearchProjects.Items)
            {
                if (listViewItem.Tag is GClass161 && (GClass161)listViewItem.Tag == gclass161_0)
                {
                    listViewItem.Selected = true;
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 587);
        }
    }

    public void method_21(GClass166 gclass166_0)
    {
        try
        {
            foreach (ListViewItem listViewItem in this.lstvResearchProjects.Items)
            {
                if (listViewItem.Tag is GClass166 && (GClass166)listViewItem.Tag == gclass166_0)
                {
                    listViewItem.Selected = true;
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 588);
        }
    }

    private void cmdInstant_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvTechnology.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a technology to instantly research");
            }
            else
            {
                TechData164 tag = (TechData164)this.lstvTechnology.SelectedItems[0].Tag;
                this.gclass21_0.method_282(tag, null, this.gclass146_0, null, false, false);
                if (this.gclass21_0.StartTechPoints > 0)
                    this.gclass21_0.StartTechPoints -= tag.int_4;
                this.method_22();
                Application.OpenForms.OfType<ClassDesign>().FirstOrDefault<ClassDesign>()?.method_17();
                ResearchFieldData selectedValue = (ResearchFieldData)this.cboResearchFields.SelectedValue;
                if (selectedValue != null)
                    this.gclass146_0.method_108(this.lstvTechnology, selectedValue);
                if (!this.gclass0_0.bool_8 && this.gclass21_0.StartTechPoints <= 0)
                    this.cmdInstant.Visible = false;
                else
                    this.cmdInstant.Visible = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 589);
        }
    }

    public void method_22()
    {
        try
        {
            if (this.gclass21_0.StartTechPoints > 0)
            {
                this.lblStartingTechPoints.Text = AuroraUtils.smethod_37(this.gclass21_0.StartTechPoints);
                this.lblStartingTechPoints.Visible = true;
                this.lblInstant.Visible = true;
            }
            else
            {
                this.lblStartingTechPoints.Visible = false;
                this.lblInstant.Visible = false;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3732);
        }
    }

    private void cmdInstantRST_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to give all designed but unresearched tech to this race?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.gclass21_0.method_280();
                ResearchFieldData selectedValue = (ResearchFieldData)this.cboResearchFields.SelectedValue;
                if (selectedValue == null)
                    return;
                this.gclass146_0.method_108(this.lstvTechnology, selectedValue);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 590);
        }
    }

    private void optProjectSelectAvail_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.cmdCreateResearch.Visible = true;
            this.cmdAddToQueue.Visible = true;
            this.cmdRemoveTech.Visible = false;
            this.cmdDeleteTech.Visible = true;
            if (!this.gclass0_0.bool_8 && this.gclass21_0.StartTechPoints <= 0)
                this.cmdInstant.Visible = false;
            else
                this.cmdInstant.Visible = true;
            if (this.gclass0_0.bool_8)
                this.cmdInstantRST.Visible = true;
            else
                this.cmdInstantRST.Visible = false;
            this.method_19();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 591);
        }
    }

    private void optProjectSelectCompleted_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.cmdCreateResearch.Visible = false;
            this.cmdAddToQueue.Visible = false;
            this.cmdInstant.Visible = false;
            this.cmdRemoveTech.Visible = true;
            this.cmdDeleteTech.Visible = false;
            if (this.gclass0_0.bool_8)
                this.cmdInstantRST.Visible = true;
            else
                this.cmdInstantRST.Visible = false;
            this.method_19();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 592);
        }
    }

    private void cmdRemoveTech_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvTechnology.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a technology to remove");
            }
            else
            {
                TechData164 tag = (TechData164)this.lstvTechnology.SelectedItems[0].Tag;
                if (MessageBox.Show($"Are you sure you want to remove {tag.Name}, from the current race?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.gclass21_0.method_278(tag);
                this.method_19();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 594);
        }
    }

    private void cmdDeleteTech_Click(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            Economics.Class1079 class1079 = new Economics.Class1079();
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvTechnology.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a technology to delete");
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                class1079.gclass164_0 = (TechData164)this.lstvTechnology.SelectedItems[0].Tag;
                // ISSUE: reference to a compiler-generated method
                if (this.gclass0_0.FCTShipDataDictionary.Values
                        .SelectMany<FCTShipData40, GClass130>(gclass40_0 => gclass40_0.list_10)
                        .Count<GClass130>(class1079.method_0) > 0)
                {
                    int num3 = (int)MessageBox.Show(
                        "This technology cannot be deleted as there are missiles reliant on this technology in ship magazines");
                }
                else
                {
                    // ISSUE: reference to a compiler-generated method
                    if (this.gclass0_0.dictionary_3.Values
                            .SelectMany<GClass22, GClass130>(gclass22_0 => gclass22_0.list_0)
                            .Count<GClass130>(class1079.method_1) > 0)
                    {
                        int num4 = (int)MessageBox.Show(
                            "This technology cannot be deleted as there are missiles reliant on this technology in class loadout templates");
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated method
                        if (this.gclass0_0.PopulationDataDictionary.Values
                                .SelectMany<PopulationData, GClass130>(gclass146_0 => gclass146_0.list_1)
                                .Count<GClass130>(class1079.method_2) > 0)
                        {
                            int num5 = (int)MessageBox.Show(
                                "This technology cannot be deleted as there are missiles reliant on this technology in population stockpiles");
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated method
                            if (this.gclass0_0.FormationDictionary.Values
                                    .SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 => gclass103_0.ElementList)
                                    .Count<GroundUnitFormationElement>(class1079.method_3) > 0)
                            {
                                int num6 = (int)MessageBox.Show(
                                    "This technology cannot be deleted as there are ground units reliant on this technology in current ground formations");
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated method
                                if (this.gclass0_0.FormationTemplateRecordDic.Values
                                        .SelectMany<GroundUnitFormationTemplateData, GroundUnitFormationElement>(gclass102_0 => gclass102_0.FormationElementList)
                                        .Count<GroundUnitFormationElement>(class1079.method_4) > 0)
                                {
                                    int num7 = (int)MessageBox.Show(
                                        "This technology cannot be deleted as there are ground units reliant on this technology in current ground formations templates");
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated method
                                    if (this.gclass0_0.dictionary_3.Values
                                            .SelectMany<GClass22, GClass228>(gclass22_0 =>
                                                gclass22_0.dictionary_0.Values).Count<GClass228>(class1079.method_5) >
                                        0)
                                    {
                                        int num8 = (int)MessageBox.Show(
                                            "This technology cannot be deleted as there are ship components in current class designs that are reliant on this technology");
                                    }
                                    else
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        if (MessageBox.Show(
                                                $"Are you sure you want to delete {class1079.gclass164_0.Name}?  Any associated ship components, ground unit designs and missile designs will also be deleted.",
                                                "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                                            return;
                                        // ISSUE: reference to a compiler-generated method
                                        foreach (RaceMissile gclass129 in this.gclass0_0.RaceMissileDictionary.Values
                                                     .Where<RaceMissile>(class1079.method_6).ToList<RaceMissile>())
                                            this.gclass0_0.RaceMissileDictionary.Remove(gclass129.int_0);
                                        // ISSUE: reference to a compiler-generated method
                                        foreach (ShipComponent gclass230 in this.gclass0_0.ComponentDataDictionary.Values
                                                     .Where<ShipComponent>(class1079.method_7).ToList<ShipComponent>())
                                            this.gclass0_0.ComponentDataDictionary.Remove(gclass230.int_0);
                                        // ISSUE: reference to a compiler-generated method
                                        foreach (GroundUnitClass101 gclass101 in this.gclass0_0.GroundUnitClassDictionary.Values
                                                     .Where<GroundUnitClass101>(class1079.method_8).ToList<GroundUnitClass101>())
                                            this.gclass0_0.GroundUnitClassDictionary.Remove(gclass101.int_0);
                                        // ISSUE: reference to a compiler-generated field
                                        this.gclass21_0.method_279(class1079.gclass164_0);
                                        this.method_19();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 595);
        }
    }

    private void cmdSMAddUnits_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvTemplate.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a ground unit type");
            }
            else
            {
                this.gclass0_0.string_3 = "Enter Number of New Formations";
                this.gclass0_0.string_4 = "1";
                int num3 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                int int32 = Convert.ToInt32(this.gclass0_0.string_4);
                if (int32 <= 0 || this.gclass0_0.bool_21)
                    return;
                for (int index = 1; index <= int32; ++index)
                {
                    GroundUnitFormationTemplateData tag = (GroundUnitFormationTemplateData)this.lstvTemplate.SelectedItems[0].Tag;
                    string string_10 = $"{AuroraUtils.smethod_80(tag.FormationTrained + 1)} {tag.Name}";
                    if (this.chkRoman.CheckState == CheckState.Checked)
                    {
                        string str = AuroraUtils.smethod_79(tag.FormationTrained + 1);
                        string_10 = $"{tag.Name} {str}";
                    }

                    ++tag.FormationTrained;
                    this.gclass21_0.method_158(string_10, tag.Abbreviation, tag, this.gclass146_0, null,
                        this.gclass146_0.SpeciesData, null, 0, AuroraGroundFormationFieldPosition.FrontlineDefence);
                    if (this.gclass21_0.StartBuildPoints > 0M)
                        this.gclass21_0.StartBuildPoints -= (int)tag.method_3(this.gclass146_0);
                }

                this.txtInstantBuild.Text = AuroraUtils.smethod_38(this.gclass21_0.StartBuildPoints);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 596);
        }
    }

    private void cmdRenameType_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvTemplate.SelectedItems.Count == 0)
            {
                int num1 = (int)MessageBox.Show("Please select a formation template");
            }
            else
            {
                GroundUnitFormationTemplateData tag = (GroundUnitFormationTemplateData)this.lstvTemplate.SelectedItems[0].Tag;
                this.gclass0_0.string_3 = "Enter New Formation Template Name";
                this.gclass0_0.string_4 = tag.Name;
                int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (!(this.gclass0_0.string_4 != tag.Name) || this.gclass0_0.bool_21)
                    return;
                tag.Name = this.gclass0_0.string_4;
                this.gclass0_0.string_3 = "Enter New Formation Template Abbreviation";
                this.gclass0_0.string_4 = tag.Abbreviation;
                int num3 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (!(this.gclass0_0.string_4 != tag.Abbreviation) || this.gclass0_0.bool_21)
                    return;
                tag.Abbreviation = this.gclass0_0.string_4;
                this.lstvTemplate.SelectedItems[0].SubItems[0].Text = tag.Abbreviation;
                this.lstvTemplate.SelectedItems[0].SubItems[1].Text = tag.Name;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 597);
        }
    }

    private void cmdRenamePop_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
                return;
            this.gclass0_0.string_3 = "Enter New Population Name";
            this.gclass0_0.string_4 = this.gclass146_0.PopName;
            int num = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            if (!(this.gclass0_0.string_4 != this.gclass146_0.PopName) || this.gclass0_0.bool_21)
                return;
            this.gclass146_0.PopName = this.gclass0_0.string_4;
            this.gclass21_0.method_59(this.tvPopList, this.chkByFunction.CheckState, this.chkShowSystemBody.CheckState,
                this.chkShowStars.CheckState, this.chkHideCMC.CheckState, this.gclass146_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 598);
        }
    }

    public void method_23(PopulationData gclass146_1)
    {
        try
        {
            foreach (TreeNode node in this.tvPopList.Nodes)
            {
                if (!(node.Tag is PopulationData) || gclass146_1 != (PopulationData)node.Tag)
                {
                    if (this.method_24(node, gclass146_1))
                        break;
                }
                else
                {
                    this.tvPopList.SelectedNode = node;
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 599);
        }
    }

    private bool method_24(TreeNode treeNode_0, PopulationData gclass146_1)
    {
        try
        {
            foreach (TreeNode node in treeNode_0.Nodes)
            {
                if (!(node.Tag is PopulationData) || gclass146_1 != (PopulationData)node.Tag)
                {
                    if (this.method_24(node, gclass146_1))
                        return true;
                }
                else
                {
                    this.tvPopList.SelectedNode = node;
                    return true;
                }
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 600);
            return false;
        }
    }

    private void cmdDeletePopulation_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null ||
                MessageBox.Show($" Are you sure you want to delete {this.gclass146_0.PopName}?",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes ||
                this.gclass146_0.decimal_30 > 0M && MessageBox.Show(
                    $" Are you really sure you want to delete {this.gclass146_0.PopName}?  This will remove any installations, shipyards, ground units, research projects, sectors and naval admin commands and will unset all movement orders for fleets heading for that population.",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            this.gclass21_0.method_132(this.gclass146_0);
            this.method_10();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 601);
        }
    }

    private void lstvTemplate_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.method_25();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 602);
        }
    }

    private void method_25()
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass146_0 == null || this.lstvTemplate.SelectedItems.Count == 0)
                return;
            GroundUnitFormationTemplateData tag = (GroundUnitFormationTemplateData)this.lstvTemplate.SelectedItems[0].Tag;
            if (tag == null)
                return;
            string str1 = AuroraUtils.smethod_80(tag.FormationTrained + 1);
            if (this.chkRoman.CheckState == CheckState.Checked)
            {
                string str2 = AuroraUtils.smethod_79(tag.FormationTrained + 1);
                this.txtUnitName.Text = $"{tag.Name} {str2}";
            }
            else
                this.txtUnitName.Text = $"{str1} {tag.Name}";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3385);
        }
    }

    private void cmdScrapMissile_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvPopMissiles.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select an ordnance stockpile");
            }
            else
            {
                this.gclass146_0.method_54((GClass130)this.lstvPopMissiles.SelectedItems[0].Tag);
                this.gclass146_0.method_58(this.lstvPopMissiles, this.lstvPopComponents);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 603);
        }
    }

    private void cmdScrapComponent_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvPopComponents.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a component stockpile");
            }
            else
            {
                this.gclass146_0.method_51((GClass73)this.lstvPopComponents.SelectedItems[0].Tag);
                this.gclass146_0.method_58(this.lstvPopMissiles, this.lstvPopComponents);
                foreach (global::Events events in Application.OpenForms.OfType<global::Events>())
                    events.method_0();
                if (this.gclass146_0.RaceData.chkEvents != CheckState.Checked)
                    return;
                this.gclass0_0.tacticalMap_0.Refresh();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 604);
        }
    }

    private void cmdDisassemble_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvPopComponents.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a component stockpile");
            }
            else if (this.gclass146_0.method_24() < 1M)
            {
                int num3 = (int)MessageBox.Show(
                    "Components can only be disassembled at a population with at least one operating Research Facility");
            }
            else
            {
                this.gclass146_0.method_49((GClass73)this.lstvPopComponents.SelectedItems[0].Tag);
                this.gclass146_0.method_58(this.lstvPopMissiles, this.lstvPopComponents);
                this.gclass146_0.method_102(this.lstvResearchProjects, this.lblRFAvailable, this.rdoLabs.Checked,
                    this.cboResearchFields, this.chkMatchOnly, this.rdoPopProjects.Checked);
                foreach (global::Events events in Application.OpenForms.OfType<global::Events>())
                    events.method_0();
                if (this.gclass146_0.RaceData.chkEvents != CheckState.Checked)
                    return;
                this.gclass0_0.tacticalMap_0.Refresh();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 605);
        }
    }

    private void tabResearch_Click(object sender, EventArgs e)
    {
    }

    private void method_26(object sender, EventArgs e)
    {
    }

    private void cmdDemand_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.cboDemand.SelectedValue == null)
            {
                int num2 = (int)MessageBox.Show("Please select an installation");
            }
            else
            {
                this.gclass0_0.string_3 = "Enter Demand Amount";
                this.gclass0_0.string_4 = "1";
                int num3 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.gclass0_0.string_4);
                if (!gclass208.Succeed)
                    return;
                GClass148 gclass148_1 = this.gclass146_0.dictionary_5.Values.FirstOrDefault<GClass148>(gclass148_0 =>
                    gclass148_0.gclass157_0 == (PlanetaryInstallationType)this.cboDemand.SelectedValue);
                if (gclass148_1 != null)
                {
                    gclass148_1.decimal_0 += gclass208.Value;
                }
                else
                {
                    GClass148 gclass148_2 = new GClass148();
                    gclass148_2.decimal_0 = gclass208.Value;
                    gclass148_2.gclass157_0 = (PlanetaryInstallationType)this.cboDemand.SelectedValue;
                    gclass148_2.bool_0 = false;
                    gclass148_2.gclass146_0 = this.gclass146_0;
                    this.gclass146_0.dictionary_5.Add(gclass148_2.gclass157_0.InstallationType, gclass148_2);
                }

                this.gclass146_0.method_163(this.lstvDemand, false);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 606);
        }
    }

    private void cmdEditSupply_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvSupply.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select an installation");
            }
            else
            {
                GClass148 tag = (GClass148)this.lstvSupply.SelectedItems[0].Tag;
                this.gclass0_0.string_3 = "Enter Supply Amount";
                this.gclass0_0.string_4 = tag.decimal_0.ToString();
                int num3 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.gclass0_0.string_4);
                if (!gclass208.Succeed)
                    return;
                tag.decimal_0 = gclass208.Value;
                this.gclass146_0.method_163(this.lstvSupply, true);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 607);
        }
    }

    private void cmdEditDemand_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvDemand.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select an installation");
            }
            else
            {
                GClass148 tag = (GClass148)this.lstvDemand.SelectedItems[0].Tag;
                this.gclass0_0.string_3 = "Enter Demand Amount";
                this.gclass0_0.string_4 = tag.decimal_0.ToString();
                int num3 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.gclass0_0.string_4);
                if (!gclass208.Succeed)
                    return;
                tag.decimal_0 = gclass208.Value;
                this.gclass146_0.method_163(this.lstvDemand, false);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 608);
        }
    }

    private void cmdSupply_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.cboSupply.SelectedValue == null)
            {
                int num2 = (int)MessageBox.Show("Please select an installation");
            }
            else
            {
                this.gclass0_0.string_3 = "Enter Supply Amount";
                this.gclass0_0.string_4 = "1";
                int num3 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.gclass0_0.string_4);
                if (!gclass208.Succeed)
                    return;
                GClass148 gclass148_1 = this.gclass146_0.dictionary_5.Values.FirstOrDefault<GClass148>(gclass148_0 =>
                    gclass148_0.gclass157_0 == (PlanetaryInstallationType)this.cboSupply.SelectedValue);
                if (gclass148_1 != null)
                {
                    gclass148_1.decimal_0 += gclass208.Value;
                }
                else
                {
                    GClass148 gclass148_2 = new GClass148();
                    gclass148_2.decimal_0 = gclass208.Value;
                    gclass148_2.gclass157_0 = (PlanetaryInstallationType)this.cboSupply.SelectedValue;
                    gclass148_2.bool_0 = true;
                    gclass148_2.gclass146_0 = this.gclass146_0;
                    this.gclass146_0.dictionary_5.Add(gclass148_2.gclass157_0.InstallationType, gclass148_2);
                }

                this.gclass146_0.method_163(this.lstvSupply, true);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 609);
        }
    }

    private void cmdDeleteDemand_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvDemand.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select an installation");
            }
            else
            {
                GClass148 tag = (GClass148)this.lstvDemand.SelectedItems[0].Tag;
                if (MessageBox.Show($" Are you sure you want to delete the demand request for {tag.gclass157_0.Name}?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.gclass146_0.dictionary_5.Remove(tag.gclass157_0.InstallationType);
                this.gclass146_0.method_163(this.lstvDemand, false);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 610);
        }
    }

    private void cmdDeleteSupply_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvSupply.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select an installation");
            }
            else
            {
                GClass148 tag = (GClass148)this.lstvSupply.SelectedItems[0].Tag;
                if (MessageBox.Show($" Are you sure you want to delete the supply request for {tag.gclass157_0.Name}?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.gclass146_0.dictionary_5.Remove(tag.gclass157_0.InstallationType);
                this.gclass146_0.method_163(this.lstvSupply, true);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 611);
        }
    }

    private void cmdSMAddInstallation_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.cboSMInstallations.SelectedValue == null)
            {
                int num2 = (int)MessageBox.Show("Please select an installation");
            }
            else
            {
                this.gclass0_0.string_3 = "Enter Installation Amount";
                this.gclass0_0.string_4 = "1";
                int num3 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                Decimal decimal_90 = Convert.ToDecimal(this.gclass0_0.string_4);
                GClass158 gclass158 = this.gclass146_0.dictionary_0.Values.FirstOrDefault<GClass158>(gclass158_0 =>
                    gclass158_0.gclass157_0 == (PlanetaryInstallationType)this.cboSMInstallations.SelectedValue);
                if (gclass158 != null)
                {
                    gclass158.decimal_0 += decimal_90;
                }
                else
                {
                    PlanetaryInstallationType selectedValue = (PlanetaryInstallationType)this.cboSMInstallations.SelectedValue;
                    if (selectedValue != null)
                        this.gclass146_0.method_65(selectedValue.InstallationType, decimal_90);
                    this.gclass146_0.method_162(this.lstvInstallations);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 612);
        }
    }

    private void cmdSMEditInstallation_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvInstallations.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select an installation");
            }
            else
            {
                GClass158 tag = (GClass158)this.lstvInstallations.SelectedItems[0].Tag;
                this.gclass0_0.string_3 = "Enter Installation Amount";
                this.gclass0_0.string_4 = tag.decimal_0.ToString();
                int num3 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                tag.decimal_0 = Convert.ToInt32(this.gclass0_0.string_4);
                this.gclass146_0.method_162(this.lstvInstallations);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 613);
        }
    }

    private void cmdSMDeleteInstallation_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvInstallations.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select an installation");
            }
            else
            {
                GClass158 tag = (GClass158)this.lstvInstallations.SelectedItems[0].Tag;
                if (MessageBox.Show($" Are you sure you want to delete {tag.gclass157_0.Name}?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.gclass146_0.dictionary_0.Remove(tag.gclass157_0.InstallationType);
                this.gclass146_0.method_162(this.lstvInstallations);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 614);
        }
    }

    private void cmdDeleteSY_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_15() || MessageBox.Show($" Are you sure you want to delete {this.gclass193_0.string_0}?",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            this.gclass0_0.dictionary_31.Remove(this.gclass193_0.int_0);
            this.gclass146_0.method_131(this.lstvShipyards, true);
            this.gclass146_0.method_119(this.lstvMining, this.lstvMines, this.lstvUsage);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 615);
        }
    }

    private void lstvScientists_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvScientists.SelectedItems.Count == 0)
                return;
            GClass55 tag = (GClass55)this.lstvScientists.SelectedItems[0].Tag;
            if (tag == null)
                return;
            Decimal num = tag.method_5(CommanderBonusType.ResearchAdmin);
            int int32_1 = Convert.ToInt32(this.lblRFAvailable.Text);
            int int32_2 = Convert.ToInt32(this.txtAssignFacilities.Text);
            if (int32_1 < num)
                num = int32_1;
            if (int32_2 < num)
                this.txtAssignFacilities.Text = num.ToString();
            if (int32_2 > num)
            {
                this.txtAssignFacilities.Text = num.ToString();
            }
            else
            {
                if (int32_2 != 0 || !(num > 0M))
                    return;
                this.txtAssignFacilities.Text = num.ToString();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 616);
        }
    }

    private void txtShipName_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.lstvShipyards.SelectedItems.Count == 0)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                this.gclass193_0 = (GClass193)this.lstvShipyards.SelectedItems[0].Tag;
                if (!(this.txtShipName.Text != ""))
                    return;
                this.gclass193_0.string_1 = this.txtShipName.Text;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 617);
        }
    }

    private void cboFleet_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.lstvShipyards.SelectedItems.Count == 0 ||
                this.cboFleet.SelectedItem == null)
                return;
            this.gclass193_0 = (GClass193)this.lstvShipyards.SelectedItems[0].Tag;
            this.gclass193_0.gclass85_1 = (FleetData)this.cboFleet.SelectedItem;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 618);
        }
    }

    private void rdoStable_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else if (this.rdoDestination.Checked)
                this.gclass146_0.ColonistDestinationSetting = PopColonistSetting.Destination;
            else if (this.rdoSource.Checked)
            {
                this.gclass146_0.ColonistDestinationSetting = PopColonistSetting.Source;
            }
            else
            {
                if (!this.rdoStable.Checked)
                    return;
                this.gclass146_0.ColonistDestinationSetting = PopColonistSetting.Stable;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 619);
        }
    }

    private void rdoPurchase_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                if (this.rdoPurchase.Checked)
                    this.gclass146_0.bPurchaseCivilianMineral = true;
                else if (this.rdoTaxMinerals.Checked)
                    this.gclass146_0.bPurchaseCivilianMineral = false;
                this.gclass0_0.bool_9 = true;
                this.gclass146_0.method_165(this.flpPurchase, this.rdoPurchase, this.rdoTaxMinerals,
                    this.lblCivilianMinerals, this.txtCivilianMinerals);
                this.gclass0_0.bool_9 = false;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 620);
        }
    }

    private void cboMassDriver_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_13)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                GClass170 selectedItem = (GClass170)this.cboMassDriver.SelectedItem;
                this.gclass146_0.MassDriverDestPopulation = !this.gclass0_0.PopulationDataDictionary.ContainsKey((int)selectedItem.decimal_0)
                    ? null
                    : this.gclass0_0.PopulationDataDictionary[(int)selectedItem.decimal_0];
                this.gclass146_0.method_156(this.lblMDDistance);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 621);
        }
    }

    private void chkAddGas_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass0_0.bool_13)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                this.gclass146_0.TerraformStatus =
                    this.chkAddGas.CheckState != CheckState.Checked ? TerraformStatus.No : TerraformStatus.Yes;
                this.gclass146_0.TerraformingTargetGas = (AtmosphericGasDefinition)this.cboGas.SelectedItem;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 622);
        }
    }

    private void cboGas_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass0_0.bool_13)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
                this.gclass146_0.TerraformingTargetGas = (AtmosphericGasDefinition)this.cboGas.SelectedItem;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 623);
        }
    }

    private void cmdSMSetAtm_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                AtmosphericGasDefinition selectedItem = (AtmosphericGasDefinition)this.cboGas.SelectedItem;
                if (selectedItem == null || selectedItem.Name == "None")
                    return;
                ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.txtMaxAtm.Text);
                if (!gclass208.Succeed)
                    return;
                if (gclass208.Value < 0M)
                {
                    this.txtMaxAtm.Text = "0";
                    gclass208.Value = 0M;
                }

                this.gclass146_0.SystemBodyData.method_9(selectedItem, (double)gclass208.Value, this.gclass146_0);
                this.method_12();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 624);
        }
    }

    private void txtMaxAtm_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.txtMaxAtm.Text);
                if (!gclass208.Succeed)
                    return;
                if (gclass208.Value < 0M)
                {
                    this.txtMaxAtm.Text = "0";
                    gclass208.Value = 0M;
                }

                this.gclass146_0.MaxAtm = (double)gclass208.Value;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3289);
        }
    }

    private void cmdHydroExt_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                this.gclass146_0.SystemBodyData.HydroExtent = Convert.ToDouble(this.txtHydroExt.Text);
                int num2 = (int)this.gclass146_0.SystemBodyData.method_33(true, false);
                this.gclass146_0.SystemBodyData.method_32();
                this.method_12();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 626);
        }
    }

    private void cmdEditPopAmount_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                this.gclass0_0.string_3 = "Enter Surface Population Amount";
                this.gclass0_0.string_4 = Math.Round(this.gclass146_0.Population, 2).ToString();
                int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.gclass0_0.string_4);
                if (!gclass208.Succeed)
                    return;
                if (gclass208.Value < 0M)
                    gclass208.Value = 0M;
                this.gclass146_0.method_25(gclass208.Value);
                this.method_12();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 627);
        }
    }

    private void cmdAddSY_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                this.gclass0_0.string_3 = "Select Shipyard Type";
                this.gclass0_0.string_7 = "";
                this.gclass0_0.string_8 = "";
                this.gclass0_0.string_9 = "";
                this.gclass0_0.list_32 = new List<string>();
                Dictionary<AuroraShipyardType, string> source = new Dictionary<AuroraShipyardType, string>();
                foreach (AuroraShipyardType auroraShipyardType in Enum.GetValues(typeof(AuroraShipyardType)))
                {
                    source.Add(auroraShipyardType, AuroraUtils.smethod_82(auroraShipyardType));
                    this.gclass0_0.list_32.Add(AuroraUtils.smethod_82(auroraShipyardType));
                }

                int num2 = (int)new UserSelection(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                this.gclass146_0.method_150(source
                    .FirstOrDefault<KeyValuePair<AuroraShipyardType, string>>(keyValuePair_0 =>
                        keyValuePair_0.Value == this.gclass0_0.string_4).Key);
                this.method_12();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 628);
        }
    }

    private void lstvMining_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            if (this.chkReserve.CheckState == CheckState.Unchecked && !this.gclass0_0.bool_8)
                return;
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvMining.SelectedItems[0].Tag == null)
            {
                int num2 = (int)MessageBox.Show("Please select a mineral");
            }
            else
            {
                AuroraElement tag = (AuroraElement)this.lstvMining.SelectedItems[0].Tag;
                if (this.chkReserve.CheckState == CheckState.Checked)
                {
                    Decimal num3 = this.gclass146_0.ReserveMinerals.GetValueOfElement(tag);
                    this.gclass0_0.string_3 = $"Enter New {AuroraUtils.smethod_82(tag)} Reserve Amount";
                    this.gclass0_0.string_4 = num3.ToString();
                }
                else
                {
                    if (!this.gclass0_0.bool_8)
                        return;
                    Decimal num4 = this.gclass146_0.CurrentMinerals.GetValueOfElement(tag);
                    this.gclass0_0.string_3 = $"Enter New {AuroraUtils.smethod_82(tag)} Stockpile Amount";
                    this.gclass0_0.string_4 = num4.ToString();
                }

                int num5 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.gclass0_0.string_4);
                if (!gclass208.Succeed)
                    return;
                Decimal decimal0 = gclass208.Value;
                if (this.chkReserve.CheckState == CheckState.Checked)
                    this.gclass146_0.ReserveMinerals.SetValueToElement(tag, decimal0);
                else
                    this.gclass146_0.CurrentMinerals.SetValueToElement(tag, decimal0);
                this.gclass146_0.method_119(this.lstvMining, this.lstvMines, this.lstvUsage);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 630);
        }
    }

    private void tabEnvironment_Click(object sender, EventArgs e)
    {
    }

    private void lstvRefitDetails_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void cmdDisassembleAll_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvPopComponents.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a component stockpile");
            }
            else
            {
                GClass73 tag = (GClass73)this.lstvPopComponents.SelectedItems[0].Tag;
                if (tag == null)
                    return;
                int num3 = (int)Math.Floor(tag.decimal_0);
                for (int index = 1; index <= num3; ++index)
                    this.gclass146_0.method_49(tag);
                this.gclass146_0.method_58(this.lstvPopMissiles, this.lstvPopComponents);
                this.gclass146_0.method_102(this.lstvResearchProjects, this.lblRFAvailable, this.rdoLabs.Checked,
                    this.cboResearchFields, this.chkMatchOnly, this.rdoPopProjects.Checked);
                foreach (global::Events events in Application.OpenForms.OfType<global::Events>())
                    events.method_0();
                if (this.gclass146_0.RaceData.chkEvents != CheckState.Checked)
                    return;
                this.gclass0_0.tacticalMap_0.Refresh();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 631);
        }
    }

    private void cmdPopAsText_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.gclass21_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                this.gclass21_0.method_226(null, false);
                int num3 = (int)new PopulationText(this.gclass146_0, null, this.gclass0_0).ShowDialog();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 632);
        }
    }

    private void cmdAllPopAsText_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.gclass21_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                int num3 = (int)new PopulationText(null, this.tvPopList, this.gclass0_0).ShowDialog();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 633);
        }
    }

    private void chkShowStars_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.gclass0_0.bool_9 = true;
            this.gclass21_0.method_59(this.tvPopList, this.chkByFunction.CheckState, this.chkShowSystemBody.CheckState,
                this.chkShowStars.CheckState, this.chkHideCMC.CheckState, null);
            this.gclass21_0.ShowPopSystemBody = AuroraUtils.smethod_27(this.chkShowSystemBody.CheckState);
            this.gclass21_0.ShowPopStar = AuroraUtils.smethod_27(this.chkShowStars.CheckState);
            this.gclass21_0.HideCMCPop = AuroraUtils.smethod_27(this.chkHideCMC.CheckState);
            this.gclass21_0.PopByFunction = AuroraUtils.smethod_27(this.chkByFunction.CheckState);
            this.gclass0_0.bool_9 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 634);
        }
    }

    private void method_27(object sender, EventArgs e)
    {
        try
        {
            this.gclass0_0.bool_9 = true;
            this.gclass21_0.method_59(this.tvPopList, this.chkByFunction.CheckState, this.chkShowSystemBody.CheckState,
                this.chkShowStars.CheckState, this.chkHideCMC.CheckState, null);
            this.gclass0_0.bool_9 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 635);
        }
    }

    private void cmdDeleteEmpty_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.gclass21_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete all empty colonies?", "Confirmation Required",
                        MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.gclass21_0.method_99();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 636);
        }
    }

    private void cmdToggleEmpty_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.gclass21_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                this.gclass146_0.bDoNotDelete = !this.gclass146_0.bDoNotDelete;
                this.method_12();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 637);
        }
    }

    private void chkRestricted_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass21_0 == null || this.gclass146_0 == null || this.bool_1)
                return;
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.CheckState == CheckState.Checked)
            {
                if (MessageBox.Show(
                        $" Are you sure you want to restrict {this.gclass146_0.PopName} to military traffic? Any civilian freighters scheduled to visit this colony will abandon their cargo and seek new trade runs. Colony ships will be diverted",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    checkBox.CheckState = CheckState.Unchecked;
                    return;
                }

                this.gclass146_0.bMilitaryRestrictedColony = true;
                this.gclass21_0.method_98(this.gclass146_0);
            }
            else
                this.gclass146_0.bMilitaryRestrictedColony = false;

            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 638);
        }
    }

    private void cmdRenameAcademy_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
                return;
            this.gclass0_0.string_3 = "Enter New Academy Name";
            this.gclass0_0.string_4 = this.gclass146_0.AcademyName;
            int num = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            if (!(this.gclass0_0.string_4 != this.gclass146_0.AcademyName) || this.gclass0_0.bool_21)
                return;
            this.gclass146_0.AcademyName = this.gclass0_0.string_4;
            this.method_12();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 639);
        }
    }

    private void cmdIndependence_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null ||
                MessageBox.Show($" Are you sure you want to grant independence to {this.gclass146_0.PopName}?",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes ||
                this.gclass146_0.Population > 0M && MessageBox.Show(
                    $" Are you really sure you want to grant independence to {this.gclass146_0.PopName}?  This will transfer all population assets to the new race, including any installations, shipyards and ground units and will unset all movement orders for fleets heading for that population.",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            FCTRaceRecordC21 gclass21 = this.gclass21_0.method_94(this.gclass146_0);
            this.gclass0_0.bool_9 = true;
            this.gclass0_0.method_577(this.cboRaces);
            this.gclass0_0.bool_9 = false;
            this.cboRaces.SelectedItem = gclass21;
            this.gclass21_0 = gclass21;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 640);
        }
    }

    private void lstvAtmosphere_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void method_28(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvMining.SelectedItems[0].Tag == null)
            {
                int num2 = (int)MessageBox.Show("Please select a mineral");
            }
            else
            {
                AuroraElement tag = (AuroraElement)this.lstvMining.SelectedItems[0].Tag;
                if (this.chkReserve.CheckState == CheckState.Checked)
                {
                    Decimal num3 = this.gclass146_0.ReserveMinerals.GetValueOfElement(tag);
                    this.gclass0_0.string_3 = $"Enter New {AuroraUtils.smethod_82(tag)} Reserve Amount";
                    this.gclass0_0.string_4 = num3.ToString();
                }
                else
                {
                    Decimal num4 = this.gclass146_0.CurrentMinerals.GetValueOfElement(tag);
                    this.gclass0_0.string_3 = $"Enter New {AuroraUtils.smethod_82(tag)} Stockpile Amount";
                    this.gclass0_0.string_4 = num4.ToString();
                }

                int num5 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.gclass0_0.string_4);
                if (!gclass208.Succeed)
                    return;
                Decimal decimal0 = gclass208.Value;
                if (this.chkReserve.CheckState == CheckState.Checked)
                    this.gclass146_0.ReserveMinerals.SetValueToElement(tag, decimal0);
                else
                    this.gclass146_0.CurrentMinerals.SetValueToElement(tag, decimal0);
                this.gclass146_0.method_119(this.lstvMining, this.lstvMines, this.lstvUsage);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 641);
        }
    }

    private void rdoDate_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
                this.gclass146_0.method_102(this.lstvResearchProjects, this.lblRFAvailable, this.rdoLabs.Checked,
                    this.cboResearchFields, this.chkMatchOnly, this.rdoPopProjects.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 642);
        }
    }

    private void rdoTaskDate_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
                this.gclass146_0.method_120(this.lstvShipyardTasks, this.rdoTaskSize);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 643);
        }
    }

    private void cmdAddOG_Click(object sender, EventArgs e)
    {
        foreach (FCTRaceRecordC21 gclass21 in this.gclass0_0.FCTRaceRecordDic.Values
                     .Where<FCTRaceRecordC21>(gclass21_0 => gclass21_0.IsNPR).ToList<FCTRaceRecordC21>())
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            Economics.Class1074 class1074 = new Economics.Class1074();
            // ISSUE: reference to a compiler-generated field
            class1074.gclass21_0 = gclass21;
            // ISSUE: reference to a compiler-generated method
            List<FleetData> list1 = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(class1074.method_0)
                .ToList<FleetData>();
            // ISSUE: reference to a compiler-generated method
            List<PopulationData> list2 = this.gclass0_0.PopulationDataDictionary.Values.Where<PopulationData>(class1074.method_1)
                .ToList<PopulationData>();
            foreach (PopulationData gclass146 in list2)
                gclass146.gclass6_0.method_7();
            // ISSUE: reference to a compiler-generated field
            class1074.gclass21_0.UnknownNprClass.method_23(list2, list1);
            // ISSUE: reference to a compiler-generated method
            this.gclass0_0.PopulationDataDictionary.Values.Where<PopulationData>(class1074.method_2).ToList<PopulationData>();
        }
    }

    private void Economics_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 644);
        }
    }

    private void txtItems_Leave(object sender, EventArgs e)
    {
        try
        {
            ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.txtItems.Text);
            if (!gclass208.Succeed || !(gclass208.Value <= 0M))
                return;
            this.txtItems.Text = "1";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3190);
        }
    }

    private void txtPercentage_Leave(object sender, EventArgs e)
    {
        try
        {
            ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.txtPercentage.Text);
            if (!gclass208.Succeed)
                return;
            if (gclass208.Value <= 0M)
            {
                this.txtItems.Text = "1";
            }
            else
            {
                if (!(gclass208.Value > 100M))
                    return;
                this.txtPercentage.Text = "100";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3191);
        }
    }

    private void txtCT_TextChanged(object sender, EventArgs e)
    {
    }

    private void txtHydroExt_TextChanged(object sender, EventArgs e)
    {
    }

    private void txtHydroExt_Leave(object sender, EventArgs e)
    {
        try
        {
            ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.txtHydroExt.Text);
            if (gclass208.Succeed && !(gclass208.Value <= 0M))
                return;
            this.txtHydroExt.Text = "0";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3238);
        }
    }

    private void txtMaxAtm_Leave(object sender, EventArgs e)
    {
    }

    private void cboSupply_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void cboDemand_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void method_29(object sender, EventArgs e)
    {
    }

    private void txtAssignFacilities_Leave(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvScientists.SelectedItems.Count == 0)
                return;
            GClass55 tag = (GClass55)this.lstvScientists.SelectedItems[0].Tag;
            if (tag == null)
                return;
            Decimal num = tag.method_5(CommanderBonusType.ResearchAdmin);
            if (!(Convert.ToInt32(this.txtAssignFacilities.Text) > num))
                return;
            this.txtAssignFacilities.Text = num.ToString();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 625);
        }
    }

    private void lstvTradeGoods_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void cboFighters_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
                this.gclass146_0.FighterDestFleet = (FleetData)this.cboFighters.SelectedItem;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3233);
        }
    }

    private void cboSpaceStations_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
                this.gclass146_0.SpaceStationDestFleet = (FleetData)this.cboSpaceStations.SelectedItem;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3234);
        }
    }

    private void lstvGroundUnitTraining_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void cmdUpQueueGround_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvGroundUnitTraining.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a queued item to move");
            }
            else if (this.lstvGroundUnitTraining.SelectedItems[0].Tag == null)
            {
                int num3 = (int)MessageBox.Show("Please select a queued task");
            }
            else
            {
                if (!(this.lstvGroundUnitTraining.SelectedItems[0].Tag is GClass107))
                    return;
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                Economics.Class1075 class1075 = new Economics.Class1075();
                // ISSUE: reference to a compiler-generated field
                class1075.gclass107_0 = (GClass107)this.lstvGroundUnitTraining.SelectedItems[0].Tag;
                // ISSUE: reference to a compiler-generated field
                if (class1075.gclass107_0.int_0 == 1)
                {
                    Decimal num4 = 100M;
                    if (this.gclass146_0.dictionary_3.Count > 0)
                        num4 -= this.gclass146_0.dictionary_3.Values.Sum<GClass106>(
                            gclass106_0 => gclass106_0.decimal_2);
                    // ISSUE: reference to a compiler-generated field
                    if (num4 >= class1075.gclass107_0.decimal_0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        this.gclass146_0.method_122(class1075.gclass107_0.gclass102_0, class1075.gclass107_0.string_0,
                            class1075.gclass107_0.decimal_0, AuroraGroundFormationFieldPosition.FrontlineDefence,
                            class1075.gclass107_0.int_2, class1075.gclass107_0.int_1);
                        // ISSUE: reference to a compiler-generated field
                        this.gclass146_0.list_0.Remove(class1075.gclass107_0);
                        this.gclass146_0.method_138();
                    }
                    else
                    {
                        int num5 = (int)MessageBox.Show(
                            "There is insufficient available capacity to move this project to the top of the queue",
                            "Change Not Possible");
                        return;
                    }
                }
                else
                {
                    // ISSUE: reference to a compiler-generated method
                    GClass107 gclass107 = this.gclass146_0.list_0.FirstOrDefault<GClass107>(class1075.method_0);
                    if (gclass107 == null)
                        return;
                    // ISSUE: reference to a compiler-generated field
                    --class1075.gclass107_0.int_0;
                    ++gclass107.int_0;
                }

                this.gclass146_0.method_121(this.lstvGroundUnitTraining);
                foreach (ListViewItem listViewItem in this.lstvGroundUnitTraining.Items)
                {
                    // ISSUE: reference to a compiler-generated field
                    if (listViewItem.Tag == class1075.gclass107_0)
                        listViewItem.Selected = true;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3258);
        }
    }

    private void cmdDownQueueGround_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvGroundUnitTraining.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select a queued item to move");
            }
            else if (this.lstvGroundUnitTraining.SelectedItems[0].Tag == null)
            {
                int num3 = (int)MessageBox.Show("Please select a queued task");
            }
            else
            {
                if (!(this.lstvGroundUnitTraining.SelectedItems[0].Tag is GClass107))
                    return;
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                Economics.Class1076 class1076 = new Economics.Class1076();
                // ISSUE: reference to a compiler-generated field
                class1076.gclass107_0 = (GClass107)this.lstvGroundUnitTraining.SelectedItems[0].Tag;
                // ISSUE: reference to a compiler-generated method
                GClass107 gclass107 = this.gclass146_0.list_0.FirstOrDefault<GClass107>(class1076.method_0);
                if (gclass107 == null)
                    return;
                // ISSUE: reference to a compiler-generated field
                ++class1076.gclass107_0.int_0;
                --gclass107.int_0;
                this.gclass146_0.method_121(this.lstvGroundUnitTraining);
                foreach (ListViewItem listViewItem in this.lstvGroundUnitTraining.Items)
                {
                    // ISSUE: reference to a compiler-generated field
                    if (listViewItem.Tag == class1076.gclass107_0)
                        listViewItem.Selected = true;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3259);
        }
    }

    private void Economics_KeyDown(object sender, KeyEventArgs e)
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
            AuroraUtils.ShowExceptionPopup(ex, 3274);
        }
    }

    private void cmdCapital_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to change your capital to {this.gclass146_0.PopName}?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                PopulationData gclass146 = this.gclass0_0.PopulationDataDictionary.Values.FirstOrDefault<PopulationData>(gclass146_1 =>
                    gclass146_1.bIsCapital = gclass146_1.RaceData == this.gclass146_0.RaceData);
                if (gclass146 != null)
                    gclass146.bIsCapital = false;
                this.gclass146_0.bIsCapital = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3274);
        }
    }

    private void cmdAssignNew_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                if (this.lstvResearchProjects.SelectedItems.Count == 0)
                    return;
                if (this.lstvResearchProjects.SelectedItems[0].Tag == null)
                {
                    int num2 = (int)MessageBox.Show("Please select a research project");
                }
                else
                {
                    if (!(this.lstvResearchProjects.SelectedItems[0].Tag is GClass161))
                        return;
                    GClass161 tag = (GClass161)this.lstvResearchProjects.SelectedItems[0].Tag;
                    tag.bool_1 = !tag.bool_1;
                    int index = this.lstvResearchProjects.SelectedItems[0].Index;
                    this.gclass146_0.method_102(this.lstvResearchProjects, this.lblRFAvailable, this.rdoLabs.Checked,
                        this.cboResearchFields, this.chkMatchOnly, this.rdoPopProjects.Checked);
                    this.lstvResearchProjects.Items[index].Selected = true;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3306);
        }
    }

    private void method_30(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.gclass146_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.rdoYes.Checked)
                this.gclass146_0.genum64_0 = GEnum64.const_1;
            else if (this.rdoNo.Checked)
            {
                this.gclass146_0.genum64_0 = GEnum64.const_0;
            }
            else
            {
                if (!this.rdoNone.Checked)
                    return;
                this.gclass146_0.genum64_0 = GEnum64.const_2;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3315);
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
            else if (this.gclass146_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a population");
            }
            else
                this.gclass146_0.BonusOne = ((CommanderBonus)this.cboBonusOne.SelectedItem).CommanderBonusType;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3316);
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
            else if (this.gclass146_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a population");
            }
            else
                this.gclass146_0.BonusTwo = ((CommanderBonus)this.cboBonusTwo.SelectedItem).CommanderBonusType;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3317);
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
            else if (this.gclass146_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a population");
            }
            else
                this.gclass146_0.BonusThree = ((CommanderBonus)this.cboBonusThree.SelectedItem).CommanderBonusType;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3318);
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
            else if (this.gclass146_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                this.gclass146_0.Importance = Convert.ToInt32(this.txtImportance.Text);
                if (this.gclass146_0.Importance >= 1)
                    return;
                this.gclass146_0.Importance = 1;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3319);
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
            else if (this.gclass146_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                this.gclass146_0.method_154();
                this.method_12();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3320);
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
                this.gclass21_0.method_227(false);
                if (this.gclass146_0 != null)
                    return;
                this.method_12();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3323);
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
                this.gclass21_0.method_227(true);
                if (this.gclass146_0 != null)
                    return;
                this.method_12();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3324);
        }
    }

    private void chkRoman_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                this.method_25();
                this.gclass21_0.checkState_0 = this.chkRoman.CheckState;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3386);
        }
    }

    private void chkCreationDate_CheckedChanged(object sender, EventArgs e)
    {
        if (this.gclass0_0.bool_9)
            return;
        if (this.gclass21_0 == null)
        {
            int num = (int)MessageBox.Show("Please select a race");
        }
        else
        {
            try
            {
                this.gclass21_0.method_371(this.tvPopGU, this.gclass146_0, this.chkCreationDate.CheckState);
            }
            catch (Exception ex)
            {
                AuroraUtils.ShowExceptionPopup(ex, 3387);
            }
        }
    }

    private void cmdScrapInstallation_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.lstvInstallations.SelectedItems.Count == 0)
            {
                int num2 = (int)MessageBox.Show("Please select an installation to scrap");
            }
            else
            {
                GClass158 tag = (GClass158)this.lstvInstallations.SelectedItems[0].Tag;
                this.gclass0_0.string_3 = "Enter Amount of Installation to Scrap";
                this.gclass0_0.string_4 = tag.decimal_0.ToString();
                int num3 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                Decimal decimal0 = Convert.ToDecimal(this.gclass0_0.string_4);
                if (decimal0 == 0M)
                    return;
                if (decimal0 > tag.decimal_0)
                    decimal0 = tag.decimal_0;
                this.gclass146_0.method_53(decimal0, tag.gclass157_0);
                tag.decimal_0 -= decimal0;
                if (tag.decimal_0 == 0M)
                    this.gclass146_0.dictionary_0.Remove(tag.gclass157_0.InstallationType);
                this.gclass146_0.method_162(this.lstvInstallations);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3401);
        }
    }

    private void flowLayoutPanel21_Paint(object sender, PaintEventArgs e)
    {
    }

    private void tabGovernor_Click(object sender, EventArgs e)
    {
    }

    private void chkAutoRefuel_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass21_0 == null || this.gclass146_0 == null || this.bool_1)
                return;
            if (((CheckBox)sender).CheckState == CheckState.Checked)
                this.gclass146_0.bAutoRefuel = true;
            else
                this.gclass146_0.bAutoRefuel = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3510);
        }
    }

    private void cmdEditWealth_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a Race");
            }
            else
            {
                this.gclass0_0.string_3 = "Enter Race Wealth Amount";
                this.gclass0_0.string_4 = Math.Round(this.gclass21_0.WealthPoints, 0).ToString();
                int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.gclass0_0.string_4);
                if (!gclass208.Succeed)
                    return;
                this.gclass21_0.WealthPoints = gclass208.Value;
                this.Text =
                    $"Economics   {this.gclass0_0.method_586(true)}   Racial Wealth {AuroraUtils.smethod_38(this.gclass21_0.WealthPoints)}";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3563);
        }
    }

    private void cmdTransferItem_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a Race");
            }
            else if (this.gclass146_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a Population");
            }
            else if (this.gclass0_0.PopulationDataDictionary.Values.Count<PopulationData>(gclass146_1 =>
                         gclass146_1.SystemBodyData == this.gclass146_0.SystemBodyData && gclass146_1 != this.gclass146_0) == 0)
            {
                int num3 = (int)MessageBox.Show("There are no other populations on this system body");
            }
            else if (this.lstvPopComponents.SelectedItems.Count == 0)
            {
                int num4 = (int)MessageBox.Show("Please select a component type to transfer to another race");
            }
            else
            {
                GClass73 tag = (GClass73)this.lstvPopComponents.SelectedItems[0].Tag;
                this.gclass0_0.string_4 = tag.decimal_0.ToString();
                this.gclass0_0.string_3 = "Select Target Population and Amount";
                int num5 = (int)new SelectRace(this.gclass21_0, this.gclass0_0, this.gclass146_0).ShowDialog();
                Decimal decimal0 = Convert.ToDecimal(this.gclass0_0.string_4);
                if (decimal0 <= 0M || this.gclass0_0.gclass146_0 == null)
                    return;
                if (decimal0 >= tag.decimal_0)
                {
                    decimal0 = tag.decimal_0;
                    this.gclass146_0.list_2.Remove(tag);
                }
                else
                    tag.decimal_0 -= decimal0;

                this.gclass0_0.gclass146_0.method_67(tag.gclass230_0, decimal0);
                this.gclass146_0.method_58(this.lstvPopMissiles, this.lstvPopComponents);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3565);
        }
    }

    private void cmdTransferOrdnance_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a Race");
            }
            else if (this.gclass146_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a Population");
            }
            else if (this.gclass0_0.PopulationDataDictionary.Values.Count<PopulationData>(gclass146_1 =>
                         gclass146_1.SystemBodyData == this.gclass146_0.SystemBodyData && gclass146_1 != this.gclass146_0) == 0)
            {
                int num3 = (int)MessageBox.Show("There are no other populations on this system body");
            }
            else if (this.lstvPopMissiles.SelectedItems.Count == 0)
            {
                int num4 = (int)MessageBox.Show("Please select an ordnance type to transfer to another race");
            }
            else
            {
                GClass130 tag = (GClass130)this.lstvPopMissiles.SelectedItems[0].Tag;
                this.gclass0_0.string_4 = tag.int_0.ToString();
                this.gclass0_0.string_3 = "Select Target Population and Amount";
                int num5 = (int)new SelectRace(this.gclass21_0, this.gclass0_0, this.gclass146_0).ShowDialog();
                int int_25 = Convert.ToInt32(this.gclass0_0.string_4);
                if (int_25 <= 0 || this.gclass0_0.gclass146_0 == null)
                    return;
                if (int_25 >= tag.int_0)
                {
                    int_25 = tag.int_0;
                    this.gclass146_0.list_1.Remove(tag);
                }
                else
                    tag.int_0 -= int_25;

                this.gclass0_0.gclass146_0.method_149(tag.gclass129_0, int_25);
                this.gclass146_0.method_58(this.lstvPopMissiles, this.lstvPopComponents);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3570);
        }
    }

    private void cboParasites_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
                this.gclass146_0.ParasiteSource = (FleetData)this.cboParasites.SelectedItem;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3582);
        }
    }

    private void cmdGMC_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                if (this.gclass146_0.bGeneticProdStatus)
                {
                    this.gclass146_0.bGeneticProdStatus = false;
                    this.cmdGMC.Text = "Start";
                }
                else
                {
                    this.gclass146_0.bGeneticProdStatus = true;
                    this.cmdGMC.Text = "Stop";
                }

                this.gclass146_0.method_155(this.lstvPopSummary, this.lstvPopSummary2, this.lstvPopSummary3,
                    this.lblGovName, this.lblSecGovName, this.cboFighters, this.cboSpaceStations, this.cboParasites,
                    this.cboFleet, this.cboAdminCommand, this.lblRefineries, this.lblMaintenance,
                    this.lblGeneticModification, this.cmdRefinery, this.cmdMaintenance, this.cmdGMC, this.cboGas,
                    this.chkAddGas, this.txtMaxAtm, this.lblMDDistance);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3688);
        }
    }

    private void cboTargetSpecies_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
                this.gclass146_0.GenModSpeciesData = (GClass194)this.cboTargetSpecies.SelectedItem;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3690);
        }
    }

    private void rdoNone_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.gclass146_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.rdoYes.Checked)
                this.gclass146_0.genum64_0 = GEnum64.const_1;
            else if (this.rdoNo.Checked)
            {
                this.gclass146_0.genum64_0 = GEnum64.const_0;
            }
            else
            {
                if (!this.rdoNone.Checked)
                    return;
                this.gclass146_0.genum64_0 = GEnum64.const_2;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3742);
        }
    }

    private void cmdEditTax_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a Race");
            }
            else
            {
                this.gclass0_0.string_3 = "Enter Shipping Line Tax Percentage";
                this.gclass0_0.string_4 = Math.Round(this.gclass21_0.ShippingLineTax * 100M, 2).ToString();
                int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.gclass0_0.string_4);
                if (!gclass208.Succeed)
                    return;
                this.gclass21_0.ShippingLineTax = gclass208.Value / 100M;
                if (this.gclass21_0.ShippingLineTax < 0M)
                    this.gclass21_0.ShippingLineTax = 0M;
                this.txtTaxRate.Text = AuroraUtils.FormatNumberToDigits(this.gclass21_0.ShippingLineTax * 100M, 2) + "%";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3774);
        }
    }

    private void txtTaxRate_TextChanged(object sender, EventArgs e)
    {
    }

    private void txtFuelWarning_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.txtFuelWarning.Text == "" || this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.gclass146_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.txtFuelWarning.Text);
                this.gclass146_0.WarningFuel = !gclass208.Succeed ? 0 : (int)gclass208.Value;
                if (this.gclass146_0.WarningFuel >= 0)
                    return;
                this.gclass146_0.WarningFuel = 0;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3783);
        }
    }

    private void txtMSPWarning_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.txtMSPWarning.Text == "" || this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.gclass146_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.txtMSPWarning.Text);
                this.gclass146_0.WarningMSP = !gclass208.Succeed ? 0 : (int)gclass208.Value;
                if (this.gclass146_0.WarningMSP >= 0)
                    return;
                this.gclass146_0.WarningMSP = 0;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3784);
        }
    }

    private void rdoSingleWarning_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.gclass146_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a population");
            }
            else if (this.rdoConstant.Checked)
            {
                this.gclass146_0.WarningConstant = 1;
            }
            else
            {
                if (!this.rdoSingleWarning.Checked)
                    return;
                this.gclass146_0.WarningConstant = 0;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3785);
        }
    }

    private void chkAdminCommand_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.method_32();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3790);
        }
    }

    public void method_31(int int_0)
    {
        try
        {
            this.chkAdminCommand.CheckState = int_0 != 1 ? CheckState.Unchecked : CheckState.Checked;
            this.method_32();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3791);
        }
    }

    private void method_32()
    {
        try
        {
            if (this.chkAdminCommand.CheckState == CheckState.Checked)
            {
                if (this.gclass193_0 != null)
                    this.gclass193_0.int_3 = 1;
            }
            else if (this.gclass193_0 != null)
                this.gclass193_0.int_3 = 0;

            this.cboShipyardTaskType_SelectedIndexChanged(null, null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3792);
        }
    }

    private void cboAdminCommand_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.lstvShipyards.SelectedItems.Count == 0 ||
                this.cboAdminCommand.SelectedItem == null)
                return;
            this.gclass193_0 = (GClass193)this.lstvShipyards.SelectedItems[0].Tag;
            this.gclass193_0.gclass83_1 = (NavalAdminCommand)this.cboAdminCommand.SelectedItem;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3794);
        }
    }

    private void cmdTransferPopulation_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                AlienRaceInfo selectedItem = (AlienRaceInfo)this.cboTransferRace.SelectedItem;
                if (selectedItem == null ||
                    MessageBox.Show(
                        $"Are you sure you want to transfer this population to the {selectedItem.AlienRaceName}?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.gclass146_0.method_114(selectedItem.ActualAlienRace, PopPoliticalStatusType.ImperialPopulation, false, false, false);
                this.method_10();
                this.cboRaces.Focus();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3795);
        }
    }

    private void rdoNormalView_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.rdoNormalView.Checked)
            {
                this.lstvResearchProjects.Height = 344;
                this.flpCreateProjectsBar.Visible = true;
                this.cboResearchFields.Top = 395;
                this.flpRPSort.Left = 831;
                this.flpRPSort.Top = 357;
            }
            else
            {
                this.lstvResearchProjects.Height = 788;
                this.lstvResearchProjects.BringToFront();
                this.flpCreateProjectsBar.Visible = false;
                this.cboResearchFields.Top = 802;
                this.flpRPSort.Left = 493;
                this.flpRPSort.Top = 802;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3796);
        }
    }

    private void rdoAllProjects_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass146_0.method_102(this.lstvResearchProjects, this.lblRFAvailable, this.rdoLabs.Checked,
                this.cboResearchFields, this.chkMatchOnly, this.rdoPopProjects.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3797);
        }
    }

    private void lstvPopComponents_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvPopComponents.SelectedItems.Count == 0)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                this.lstvPopComponents.Height = 793;
                this.lstvPopMissiles.Height = 793;
                this.cmdResearchMissile.Visible = false;
                this.cmdTransferOrdnance.Visible = false;
                this.cmdScrapMissile.Visible = false;
                this.cmdDisassemble.Visible = false;
                this.cmdDisassembleAll.Visible = false;
                this.cmdConvert.Visible = false;
                this.cmdResearchComponent.Visible = false;
                this.cmdScrapComponent.Visible = false;
                this.cmdTransferItem.Visible = false;
                this.txtComponentDetail.Visible = false;
                GClass73 tag = (GClass73)this.lstvPopComponents.SelectedItems[0].Tag;
                if (tag == null)
                    return;
                this.cmdScrapComponent.Visible = true;
                this.cmdTransferItem.Visible = true;
                if (this.gclass146_0.RaceData.method_103(tag.gclass230_0))
                {
                    this.cmdDisassemble.Visible = true;
                    this.cmdDisassembleAll.Visible = true;
                }
                else if (this.gclass146_0.RaceData.method_104(tag.gclass230_0))
                {
                    this.lstvPopComponents.Height = 662;
                    this.lstvPopMissiles.Height = 662;
                    this.cmdConvert.Visible = true;
                    this.txtComponentDetail.Visible = true;
                    this.txtComponentDetail.Text = tag.gclass230_0.method_14();
                }
                else
                {
                    if (!this.gclass146_0.RaceData.method_105(tag.gclass230_0))
                        return;
                    this.lstvPopComponents.Height = 662;
                    this.lstvPopMissiles.Height = 662;
                    this.cmdResearchComponent.Visible = true;
                    this.txtComponentDetail.Visible = true;
                    this.txtComponentDetail.Text = tag.gclass230_0.method_14();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3810);
        }
    }

    private void cmdConvert_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                if (this.lstvPopComponents.SelectedItems.Count == 0)
                    return;
                GClass73 tag = (GClass73)this.lstvPopComponents.SelectedItems[0].Tag;
                if (tag == null)
                {
                    int num2 = (int)MessageBox.Show("Please select a component");
                }
                else
                {
                    this.gclass146_0.method_47(tag);
                    this.gclass146_0.method_58(this.lstvPopMissiles, this.lstvPopComponents);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3811);
        }
    }

    private void cmdResearchComponent_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                if (this.lstvPopComponents.SelectedItems.Count == 0)
                    return;
                GClass73 tag = (GClass73)this.lstvPopComponents.SelectedItems[0].Tag;
                if (tag == null)
                {
                    int num2 = (int)MessageBox.Show("Please select a component");
                }
                else if (this.gclass146_0.method_48(tag.gclass230_0.gclass164_0))
                {
                    int num3 = (int)MessageBox.Show(
                        "Project created. Research the new project on the Research tab of the economics window");
                    this.gclass146_0.method_58(this.lstvPopMissiles, this.lstvPopComponents);
                }
                else
                {
                    int num4 = (int)MessageBox.Show("This project could not be created");
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3813);
        }
    }

    private void lstvPopMissiles_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvPopMissiles.SelectedItems.Count == 0)
                return;
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                this.lstvPopComponents.Height = 793;
                this.lstvPopMissiles.Height = 793;
                this.cmdResearchMissile.Visible = false;
                this.cmdTransferOrdnance.Visible = false;
                this.cmdScrapMissile.Visible = false;
                this.cmdDisassemble.Visible = false;
                this.cmdDisassembleAll.Visible = false;
                this.cmdConvert.Visible = false;
                this.cmdResearchComponent.Visible = false;
                this.cmdScrapComponent.Visible = false;
                this.cmdTransferItem.Visible = false;
                this.txtComponentDetail.Visible = false;
                GClass130 tag = (GClass130)this.lstvPopMissiles.SelectedItems[0].Tag;
                if (tag == null || !this.gclass146_0.method_46(tag.gclass129_0))
                    return;
                this.lstvPopComponents.Height = 662;
                this.lstvPopMissiles.Height = 662;
                this.cmdResearchMissile.Visible = true;
                this.cmdTransferOrdnance.Visible = true;
                this.cmdScrapMissile.Visible = true;
                this.txtComponentDetail.Visible = true;
                this.txtComponentDetail.Text = tag.gclass129_0.method_8();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3815);
        }
    }

    private void cmdResearchMissile_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                if (this.lstvPopMissiles.SelectedItems.Count == 0)
                    return;
                GClass130 tag = (GClass130)this.lstvPopMissiles.SelectedItems[0].Tag;
                if (tag == null)
                {
                    int num2 = (int)MessageBox.Show("Please select a component");
                }
                else if (this.gclass146_0.method_48(tag.gclass129_0.gclass164_0))
                {
                    int num3 = (int)MessageBox.Show(
                        "Project created. Research the new project on the Research tab of the economics window");
                    this.gclass146_0.method_58(this.lstvPopMissiles, this.lstvPopComponents);
                }
                else
                {
                    int num4 = (int)MessageBox.Show("This project could not be created");
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3816);
        }
    }

    private void rdoPOWEmpire_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass146_0.method_178(this.lstvPOWOfficers, this.rdoPOWEmpire.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3824);
        }
    }

    private void lstvPOWOfficers_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.cmdRelease.Enabled = false;
            if (this.lstvPOWOfficers.SelectedItems.Count == 0 || this.lstvPOWOfficers.SelectedItems[0].Tag == null)
                return;
            this.cmdRelease.Enabled = true;
            if (this.lstvPOWOfficers.SelectedItems[0].Tag is GClass180)
            {
                if (this.gclass21_0.method_325(((GClass180)this.lstvPOWOfficers.SelectedItems[0].Tag).gclass21_0.RaceID)
                        .ContactStatus == AuroraContactStatus.Hostile)
                    this.cmdRelease.Text = "Execute";
                else
                    this.cmdRelease.Text = "Release";
            }
            else if (this.lstvPOWOfficers.SelectedItems[0].Tag is GClass147)
            {
                if (this.gclass21_0.method_325(((GClass147)this.lstvPOWOfficers.SelectedItems[0].Tag).gclass21_0.RaceID)
                        .ContactStatus == AuroraContactStatus.Hostile)
                    this.cmdRelease.Text = "Execute";
                else
                    this.cmdRelease.Text = "Release";
            }
            else
            {
                if (!(this.lstvPOWOfficers.SelectedItems[0].Tag is GClass55))
                    return;
                if (this.gclass21_0.method_325(((GClass55)this.lstvPOWOfficers.SelectedItems[0].Tag).gclass21_0.RaceID)
                        .ContactStatus == AuroraContactStatus.Hostile)
                    this.cmdRelease.Text = "Execute";
                else
                    this.cmdRelease.Text = "Release";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3825);
        }
    }

    private void cmdRelease_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvPOWOfficers.SelectedItems.Count == 0)
            {
                int num1 = (int)MessageBox.Show("Please select an officer or group of enlisted prisoners");
            }
            else if (this.lstvPOWOfficers.SelectedItems[0].Tag == null)
            {
                int num2 = (int)MessageBox.Show("Please select an officer or group of enlisted prisoners");
            }
            else
            {
                string str = "Release";
                if (this.lstvPOWOfficers.SelectedItems[0].Tag is GClass180)
                {
                    GClass180 tag = (GClass180)this.lstvPOWOfficers.SelectedItems[0].Tag;
                    AlienRaceInfo gclass110 = this.gclass21_0.method_325(tag.gclass21_0.RaceID);
                    if (gclass110.ContactStatus == AuroraContactStatus.Hostile)
                        str = "Execute";
                    if (MessageBox.Show(
                            $"Are you sure you want to {str}{tag.int_0.ToString()} from the {gclass110.AlienRaceName}",
                            "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                    if (gclass110.ContactStatus != AuroraContactStatus.Hostile)
                        tag.gclass21_0.method_325(this.gclass21_0.RaceID).DiplomaticPoints += tag.int_0 / 100M;
                    tag.gclass40_0.list_1.Remove(tag);
                }
                else if (this.lstvPOWOfficers.SelectedItems[0].Tag is GClass147)
                {
                    GClass147 tag = (GClass147)this.lstvPOWOfficers.SelectedItems[0].Tag;
                    AlienRaceInfo gclass110_1 = this.gclass21_0.method_325(tag.gclass21_0.RaceID);
                    if (gclass110_1.ContactStatus == AuroraContactStatus.Hostile)
                        str = "Execute";
                    if (MessageBox.Show(
                            $"Are you sure you want to {str}{tag.int_0.ToString()} from the {gclass110_1.AlienRaceName}",
                            "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                    if (gclass110_1.ContactStatus != AuroraContactStatus.Hostile)
                    {
                        AlienRaceInfo gclass110_2 = tag.gclass21_0.method_325(this.gclass21_0.RaceID);
                        gclass110_2.DiplomaticPoints =
                            gclass110_2.DiplomaticPoints + tag.int_1 / 400M + (tag.int_0 - tag.int_1) / 100M;
                    }

                    tag.gclass146_0.list_3.Remove(tag);
                }
                else
                {
                    if (!(this.lstvPOWOfficers.SelectedItems[0].Tag is GClass55))
                        return;
                    GClass55 tag = (GClass55)this.lstvPOWOfficers.SelectedItems[0].Tag;
                    AlienRaceInfo gclass110_3 = this.gclass21_0.method_325(tag.gclass21_0.RaceID);
                    if (gclass110_3.ContactStatus == AuroraContactStatus.Hostile)
                        str = "Execute";
                    if (MessageBox.Show(
                            $"Are you sure you want to {str}{tag.method_36()} from the {gclass110_3.AlienRaceName}",
                            "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                    if (gclass110_3.ContactStatus != AuroraContactStatus.Hostile)
                    {
                        AlienRaceInfo gclass110_4 = tag.gclass21_0.method_325(this.gclass21_0.RaceID);
                        Decimal num3 = (Decimal)Math.Pow(tag.method_0() + 1, 3.0);
                        if (tag.bool_5)
                            num3 /= 4M;
                        gclass110_4.DiplomaticPoints += num3;
                        tag.bool_4 = false;
                        tag.bool_5 = false;
                        tag.gclass40_0 = null;
                        tag.gclass146_0 = null;
                    }
                    else
                        tag.method_42(AuroraRetirementStatus.Executed);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3826);
        }
    }

    private void cmdScrapAll_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                if (MessageBox.Show(
                        $"Are you sure you want to scrap all components at {this.gclass146_0.PopName}, except for researched non-obsolete components or those that can be disassembled?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                foreach (GClass73 gclass73 in this.gclass146_0.list_2)
                {
                    gclass73.bool_0 = true;
                    if (gclass73.gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID))
                    {
                        if (!gclass73.gclass230_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0)
                            gclass73.bool_0 = false;
                    }
                    else if (this.gclass146_0.RaceData.method_103(gclass73.gclass230_0))
                        gclass73.bool_0 = false;
                }

                foreach (GClass73 gclass73_0 in this.gclass146_0.list_2.Where<GClass73>(gclass73_0 => gclass73_0.bool_0)
                             .ToList<GClass73>())
                    this.gclass146_0.method_51(gclass73_0);
                this.gclass146_0.method_58(this.lstvPopMissiles, this.lstvPopComponents);
                foreach (global::Events events in Application.OpenForms.OfType<global::Events>())
                    events.method_0();
                if (this.gclass146_0.RaceData.chkEvents != CheckState.Checked)
                    return;
                this.gclass0_0.tacticalMap_0.Refresh();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3838);
        }
    }

    private void cmdClearQueue_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                if (MessageBox.Show(
                        "Are you sure you want to remove all items in the ground construction queue for " +
                        this.gclass146_0.PopName, "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.gclass146_0.list_0.Clear();
                this.gclass146_0.method_121(this.lstvGroundUnitTraining);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3852);
        }
    }

    private void cmdEditFuel_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                this.gclass0_0.string_3 = "Enter Fuel Stockpile Amount";
                this.gclass0_0.string_4 = Math.Round(this.gclass146_0.FuelStockpile, 0).ToString();
                int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.gclass0_0.string_4);
                if (!gclass208.Succeed)
                    return;
                if (gclass208.Value < 0M)
                    gclass208.Value = 0M;
                this.gclass146_0.FuelStockpile = gclass208.Value;
                this.method_12();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3887);
        }
    }

    private void cmdEditMSP_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass146_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a population");
            }
            else
            {
                this.gclass0_0.string_3 = "Enter Maintenance Stockpile Amount";
                this.gclass0_0.string_4 = Math.Round(this.gclass146_0.MaintenanceStockpile, 0).ToString();
                int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.gclass0_0.string_4);
                if (!gclass208.Succeed)
                    return;
                if (gclass208.Value < 0M)
                    gclass208.Value = 0M;
                this.gclass146_0.MaintenanceStockpile = gclass208.Value;
                this.method_12();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3888);
        }
    }

    private void chkCurrentPopulation_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.method_13();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3946);
        }
    }

    private void rdoMinYear_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.method_13();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3947);
        }
    }

    private void txtItems_TextChanged(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.icontainer_0 = new System.ComponentModel.Container();
        this.cboRaces = new ComboBox();
        this.tvPopList = new TreeView();
        this.tabPopulation = new TabControl();
        this.tabSummary = new TabPage();
        this.flowLayoutPanel15 = new FlowLayoutPanel();
        this.cmdRenamePop = new Button();
        this.cmdRenameAcademy = new Button();
        this.cmdCapital = new Button();
        this.cmdPopAsText = new Button();
        this.cmdAllPopAsText = new Button();
        this.cmdToggleEmpty = new Button();
        this.cmdIndependence = new Button();
        this.cmdEditPopAmount = new Button();
        this.cmdDeletePopulation = new Button();
        this.cmdDeleteEmpty = new Button();
        this.cmdAddOG = new Button();
        this.lblSecGovName = new Label();
        this.label4 = new Label();
        this.lblGovName = new Label();
        this.label1 = new Label();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.lstvPopSummary = new ListView();
        this.columnHeader_0 = new ColumnHeader();
        this.columnHeader_1 = new ColumnHeader();
        this.lstvPopSummary2 = new ListView();
        this.columnHeader_2 = new ColumnHeader();
        this.columnHeader_3 = new ColumnHeader();
        this.lstvPopSummary3 = new ListView();
        this.columnHeader_4 = new ColumnHeader();
        this.columnHeader_5 = new ColumnHeader();
        this.tabIndustry = new TabPage();
        this.pnlGeneticModification = new Panel();
        this.label46 = new Label();
        this.cboTargetSpecies = new ComboBox();
        this.lblGeneticModification = new Label();
        this.cmdGMC = new Button();
        this.lblIndustry = new Label();
        this.panel6 = new Panel();
        this.cmdEditMSP = new Button();
        this.lblMaintenance = new Label();
        this.cmdMaintenance = new Button();
        this.panel5 = new Panel();
        this.cmdEditFuel = new Button();
        this.lblRefineries = new Label();
        this.cmdRefinery = new Button();
        this.panel4 = new Panel();
        this.flowLayoutPanel19 = new FlowLayoutPanel();
        this.label3 = new Label();
        this.txtItems = new TextBox();
        this.label5 = new Label();
        this.txtPercentage = new TextBox();
        this.label2 = new Label();
        this.cboFighters = new ComboBox();
        this.label19 = new Label();
        this.cboSpaceStations = new ComboBox();
        this.cmdDownQueue = new Button();
        this.cmdCreate = new Button();
        this.cmdUpQueue = new Button();
        this.cmdModify = new Button();
        this.cmdCancel = new Button();
        this.cmdPause = new Button();
        this.lstvMinerals = new ListView();
        this.columnHeader_14 = new ColumnHeader();
        this.columnHeader_15 = new ColumnHeader();
        this.columnHeader_16 = new ColumnHeader();
        this.lstvConstruction = new ListView();
        this.columnHeader_6 = new ColumnHeader();
        this.columnHeader_7 = new ColumnHeader();
        this.columnHeader_8 = new ColumnHeader();
        this.columnHeader_9 = new ColumnHeader();
        this.columnHeader_10 = new ColumnHeader();
        this.columnHeader_11 = new ColumnHeader();
        this.columnHeader_12 = new ColumnHeader();
        this.columnHeader_13 = new ColumnHeader();
        this.lstPI = new ListBox();
        this.cboConstructionType = new ComboBox();
        this.tabMining = new TabPage();
        this.flowLayoutPanel26 = new FlowLayoutPanel();
        this.label17 = new Label();
        this.cboMassDriver = new ComboBox();
        this.label43 = new Label();
        this.lblMDDistance = new Label();
        this.flpPurchase = new FlowLayoutPanel();
        this.rdoPurchase = new RadioButton();
        this.rdoTaxMinerals = new RadioButton();
        this.lblCivilianMinerals = new Label();
        this.txtCivilianMinerals = new TextBox();
        this.chkReserve = new CheckBox();
        this.lstvUsage = new ListView();
        this.columnHeader_41 = new ColumnHeader();
        this.columnHeader_42 = new ColumnHeader();
        this.columnHeader_43 = new ColumnHeader();
        this.columnHeader_44 = new ColumnHeader();
        this.columnHeader_45 = new ColumnHeader();
        this.columnHeader_46 = new ColumnHeader();
        this.columnHeader_47 = new ColumnHeader();
        this.columnHeader_48 = new ColumnHeader();
        this.columnHeader_49 = new ColumnHeader();
        this.columnHeader_50 = new ColumnHeader();
        this.columnHeader_51 = new ColumnHeader();
        this.lstvMines = new ListView();
        this.columnHeader_28 = new ColumnHeader();
        this.columnHeader_29 = new ColumnHeader();
        this.columnHeader_30 = new ColumnHeader();
        this.columnHeader_31 = new ColumnHeader();
        this.columnHeader_32 = new ColumnHeader();
        this.columnHeader_33 = new ColumnHeader();
        this.columnHeader_34 = new ColumnHeader();
        this.columnHeader_35 = new ColumnHeader();
        this.columnHeader_36 = new ColumnHeader();
        this.columnHeader_37 = new ColumnHeader();
        this.columnHeader_38 = new ColumnHeader();
        this.columnHeader_39 = new ColumnHeader();
        this.columnHeader_40 = new ColumnHeader();
        this.lstvMining = new ListView();
        this.columnHeader_17 = new ColumnHeader();
        this.columnHeader_18 = new ColumnHeader();
        this.columnHeader_19 = new ColumnHeader();
        this.columnHeader_20 = new ColumnHeader();
        this.columnHeader_21 = new ColumnHeader();
        this.columnHeader_22 = new ColumnHeader();
        this.columnHeader_23 = new ColumnHeader();
        this.columnHeader_24 = new ColumnHeader();
        this.columnHeader_25 = new ColumnHeader();
        this.columnHeader_26 = new ColumnHeader();
        this.columnHeader_27 = new ColumnHeader();
        this.tabShipyards = new TabPage();
        this.lstvRefitDetails = new ListView();
        this.columnHeader_65 = new ColumnHeader();
        this.columnHeader_66 = new ColumnHeader();
        this.columnHeader_67 = new ColumnHeader();
        this.lstvSYMinerals = new ListView();
        this.columnHeader_62 = new ColumnHeader();
        this.columnHeader_63 = new ColumnHeader();
        this.columnHeader_64 = new ColumnHeader();
        this.panel3 = new Panel();
        this.chkAdminCommand = new CheckBox();
        this.lblAdminCommand = new Label();
        this.cboAdminCommand = new ComboBox();
        this.label44 = new Label();
        this.cboParasites = new ComboBox();
        this.chkUseComponents = new CheckBox();
        this.txtShipName = new TextBox();
        this.lblBuildCost = new Label();
        this.label16 = new Label();
        this.lblShipyardConstructionDate = new Label();
        this.label14 = new Label();
        this.cmdRefitDetails = new Button();
        this.cmdSelectName = new Button();
        this.lblFleet = new Label();
        this.cboFleet = new ComboBox();
        this.label11 = new Label();
        this.cboShip = new ComboBox();
        this.lblEligible = new Label();
        this.cboEligible = new ComboBox();
        this.lblRefitFrom = new Label();
        this.cboRefitFrom = new ComboBox();
        this.lblTaskType = new Label();
        this.cboShipyardTaskType = new ComboBox();
        this.cmdDefaultFleet = new Button();
        this.cmdAddShipyardTask = new Button();
        this.panel1 = new Panel();
        this.cmdAddSY = new Button();
        this.flowLayoutPanel9 = new FlowLayoutPanel();
        this.cboShipyardUpgrade = new ComboBox();
        this.cboRetoolClass = new ComboBox();
        this.lblCT = new Label();
        this.txtCT = new TextBox();
        this.lblSetSL = new Label();
        this.txtSetSL = new TextBox();
        this.label6 = new Label();
        this.txtShipyardUpgradeCost = new Label();
        this.label7 = new Label();
        this.txtShipyardUpgradeDate = new Label();
        this.cmdDeleteSY = new Button();
        this.cmdAutoRename = new Button();
        this.cmdRenameShipyard = new Button();
        this.cmdPauseActivity = new Button();
        this.cmdDeleteActivity = new Button();
        this.cmdSetActivity = new Button();
        this.lstvShipyards = new ListView();
        this.columnHeader_52 = new ColumnHeader();
        this.columnHeader_53 = new ColumnHeader();
        this.columnHeader_54 = new ColumnHeader();
        this.columnHeader_55 = new ColumnHeader();
        this.columnHeader_56 = new ColumnHeader();
        this.columnHeader_57 = new ColumnHeader();
        this.columnHeader_58 = new ColumnHeader();
        this.columnHeader_59 = new ColumnHeader();
        this.columnHeader_60 = new ColumnHeader();
        this.columnHeader_61 = new ColumnHeader();
        this.tabSYTasks = new TabPage();
        this.flowLayoutPanel18 = new FlowLayoutPanel();
        this.rdoTaskSize = new RadioButton();
        this.rdoTaskDate = new RadioButton();
        this.cmdSelectNameTaskShip = new Button();
        this.cmdRenameTaskShip = new Button();
        this.cmdPauseTask = new Button();
        this.cmdDeleteTask = new Button();
        this.lstvShipyardTasks = new ListView();
        this.columnHeader_68 = new ColumnHeader();
        this.columnHeader_69 = new ColumnHeader();
        this.columnHeader_70 = new ColumnHeader();
        this.columnHeader_72 = new ColumnHeader();
        this.columnHeader_73 = new ColumnHeader();
        this.columnHeader_71 = new ColumnHeader();
        this.columnHeader_74 = new ColumnHeader();
        this.tabResearch = new TabPage();
        this.flowLayoutPanel3 = new FlowLayoutPanel();
        this.rdoPopProjects = new RadioButton();
        this.rdoAllProjects = new RadioButton();
        this.flpRPSort = new FlowLayoutPanel();
        this.rdoLabs = new RadioButton();
        this.rdoDate = new RadioButton();
        this.flowLayoutPanel5 = new FlowLayoutPanel();
        this.optProjectSelectAvail = new RadioButton();
        this.optProjectSelectCompleted = new RadioButton();
        this.flowLayoutPanel4 = new FlowLayoutPanel();
        this.label18 = new Label();
        this.txtAssignFacilities = new TextBox();
        this.label15 = new Label();
        this.lblRFAvailable = new Label();
        this.lblInstant = new Label();
        this.lblStartingTechPoints = new Label();
        this.flpCreateProjectsBar = new FlowLayoutPanel();
        this.cmdCreateResearch = new Button();
        this.cmdAddToQueue = new Button();
        this.cmdInstant = new Button();
        this.cmdInstantRST = new Button();
        this.cmdRemoveTech = new Button();
        this.cmdDeleteTech = new Button();
        this.flowLayoutPanel2 = new FlowLayoutPanel();
        this.cmdDeleteProject = new Button();
        this.cmdPauseResearch = new Button();
        this.cmdAssignNew = new Button();
        this.cmdAddLab = new Button();
        this.cmdRemoveLab = new Button();
        this.cmdUpResearchQueue = new Button();
        this.cmdDownResearchQueue = new Button();
        this.cmdRemoveQueue = new Button();
        this.txtTechDescription = new TextBox();
        this.flowLayoutPanel20 = new FlowLayoutPanel();
        this.rdoNormalView = new RadioButton();
        this.rdoProjectOnlyView = new RadioButton();
        this.chkMatchOnly = new CheckBox();
        this.lstvScientists = new ListView();
        this.columnHeader_94 = new ColumnHeader();
        this.columnHeader_95 = new ColumnHeader();
        this.columnHeader_96 = new ColumnHeader();
        this.columnHeader_97 = new ColumnHeader();
        this.cboResearchFields = new ComboBox();
        this.lstvTechnology = new ListView();
        this.columnHeader_92 = new ColumnHeader();
        this.columnHeader_93 = new ColumnHeader();
        this.lstvResearchProjects = new ListView();
        this.columnHeader_160 = new ColumnHeader();
        this.columnHeader_161 = new ColumnHeader();
        this.columnHeader_162 = new ColumnHeader();
        this.columnHeader_163 = new ColumnHeader();
        this.columnHeader_164 = new ColumnHeader();
        this.columnHeader_165 = new ColumnHeader();
        this.columnHeader_166 = new ColumnHeader();
        this.columnHeader_167 = new ColumnHeader();
        this.columnHeader_168 = new ColumnHeader();
        this.columnHeader_169 = new ColumnHeader();
        this.tabGUTraining = new TabPage();
        this.cmdClearQueue = new Button();
        this.label45 = new Label();
        this.txtGUPercentage = new TextBox();
        this.chkRoman = new CheckBox();
        this.pnlStartingBuildPoints = new Panel();
        this.label9 = new Label();
        this.txtInstantBuild = new TextBox();
        this.cmdDownQueueGround = new Button();
        this.cmdUpQueueGround = new Button();
        this.txtUnitName = new TextBox();
        this.lstvTemplate = new ListView();
        this.columnHeader_98 = new ColumnHeader();
        this.columnHeader_99 = new ColumnHeader();
        this.columnHeader_100 = new ColumnHeader();
        this.columnHeader_101 = new ColumnHeader();
        this.columnHeader_102 = new ColumnHeader();
        this.columnHeader_103 = new ColumnHeader();
        this.columnHeader_104 = new ColumnHeader();
        this.columnHeader_105 = new ColumnHeader();
        this.cmdSMAddUnits = new Button();
        this.cmdRenameType = new Button();
        this.cmdRenameGUTask = new Button();
        this.lstvGroundUnitTraining = new ListView();
        this.columnHeader_75 = new ColumnHeader();
        this.columnHeader_76 = new ColumnHeader();
        this.columnHeader_77 = new ColumnHeader();
        this.columnHeader_147 = new ColumnHeader();
        this.columnHeader_78 = new ColumnHeader();
        this.columnHeader_79 = new ColumnHeader();
        this.cmdDeleteGUTask = new Button();
        this.cmdAddGUTask = new Button();
        this.tabWealth = new TabPage();
        this.cmdEditTax = new Button();
        this.label49 = new Label();
        this.txtTaxRate = new TextBox();
        this.lstvWealthHistory = new ListView();
        this.columnHeader_142 = new ColumnHeader();
        this.columnHeader_143 = new ColumnHeader();
        this.columnHeader_144 = new ColumnHeader();
        this.columnHeader_145 = new ColumnHeader();
        this.columnHeader_146 = new ColumnHeader();
        this.cmdEditWealth = new Button();
        this.panel7 = new Panel();
        this.rdoOneYear = new RadioButton();
        this.rdoSixMonths = new RadioButton();
        this.rdoThreeMonths = new RadioButton();
        this.rdoOneMonth = new RadioButton();
        this.label13 = new Label();
        this.txtPopPerCapita = new TextBox();
        this.label12 = new Label();
        this.txtRacialPerCapita = new TextBox();
        this.label8 = new Label();
        this.txtAnnualWealth = new TextBox();
        this.lstvExpenditure = new ListView();
        this.columnHeader_86 = new ColumnHeader();
        this.columnHeader_87 = new ColumnHeader();
        this.columnHeader_88 = new ColumnHeader();
        this.lstvIncome = new ListView();
        this.columnHeader_89 = new ColumnHeader();
        this.columnHeader_90 = new ColumnHeader();
        this.columnHeader_91 = new ColumnHeader();
        this.lstvTradeGoods = new ListView();
        this.columnHeader_80 = new ColumnHeader();
        this.columnHeader_81 = new ColumnHeader();
        this.columnHeader_82 = new ColumnHeader();
        this.columnHeader_83 = new ColumnHeader();
        this.columnHeader_84 = new ColumnHeader();
        this.columnHeader_85 = new ColumnHeader();
        this.tabCivilian = new TabPage();
        this.flowLayoutPanel25 = new FlowLayoutPanel();
        this.cmdSMAddInstallation = new Button();
        this.cmdSMEditInstallation = new Button();
        this.cmdSMDeleteInstallation = new Button();
        this.cmdScrapInstallation = new Button();
        this.cmdDemand = new Button();
        this.cmdEditDemand = new Button();
        this.cmdDeleteDemand = new Button();
        this.cmdSupply = new Button();
        this.cmdEditSupply = new Button();
        this.cmdDeleteSupply = new Button();
        this.flowLayoutPanel10 = new FlowLayoutPanel();
        this.rdoDestination = new RadioButton();
        this.rdoSource = new RadioButton();
        this.rdoStable = new RadioButton();
        this.chkRestricted = new CheckBox();
        this.chkAutoRefuel = new CheckBox();
        this.flowLayoutPanel8 = new FlowLayoutPanel();
        this.cboSMInstallations = new ComboBox();
        this.lstvInstallations = new ListView();
        this.columnHeader_114 = new ColumnHeader();
        this.columnHeader_115 = new ColumnHeader();
        this.flowLayoutPanel7 = new FlowLayoutPanel();
        this.cboSupply = new ComboBox();
        this.lstvSupply = new ListView();
        this.columnHeader_110 = new ColumnHeader();
        this.columnHeader_111 = new ColumnHeader();
        this.columnHeader_116 = new ColumnHeader();
        this.flowLayoutPanel6 = new FlowLayoutPanel();
        this.cboDemand = new ComboBox();
        this.lstvDemand = new ListView();
        this.columnHeader_112 = new ColumnHeader();
        this.columnHeader_113 = new ColumnHeader();
        this.columnHeader_117 = new ColumnHeader();
        this.tabStockpile = new TabPage();
        this.txtComponentDetail = new TextBox();
        this.flowLayoutPanel11 = new FlowLayoutPanel();
        this.cmdDisassemble = new Button();
        this.cmdDisassembleAll = new Button();
        this.cmdScrapComponent = new Button();
        this.cmdConvert = new Button();
        this.cmdResearchComponent = new Button();
        this.cmdTransferItem = new Button();
        this.cmdResearchMissile = new Button();
        this.cmdTransferOrdnance = new Button();
        this.cmdScrapMissile = new Button();
        this.cmdScrapAll = new Button();
        this.chkCreationDate = new CheckBox();
        this.tvPopGU = new TreeView();
        this.lstvPopComponents = new ListView();
        this.columnHeader_108 = new ColumnHeader();
        this.columnHeader_109 = new ColumnHeader();
        this.lstvPopMissiles = new ListView();
        this.columnHeader_106 = new ColumnHeader();
        this.columnHeader_107 = new ColumnHeader();
        this.tabEnvironment = new TabPage();
        this.flpSpecies = new FlowLayoutPanel();
        this.flowLayoutPanel21 = new FlowLayoutPanel();
        this.label34 = new Label();
        this.label20 = new Label();
        this.label21 = new Label();
        this.label22 = new Label();
        this.label31 = new Label();
        this.label32 = new Label();
        this.label33 = new Label();
        this.flowLayoutPanel22 = new FlowLayoutPanel();
        this.label35 = new Label();
        this.lblBreathe = new Label();
        this.lblOxygen = new Label();
        this.label23 = new Label();
        this.lblGravity = new Label();
        this.lblTemperature = new Label();
        this.lblPressure = new Label();
        this.flpColonyCostFactors = new FlowLayoutPanel();
        this.flowLayoutPanel13 = new FlowLayoutPanel();
        this.label38 = new Label();
        this.label25 = new Label();
        this.label27 = new Label();
        this.label26 = new Label();
        this.label28 = new Label();
        this.label29 = new Label();
        this.label24 = new Label();
        this.label30 = new Label();
        this.label41 = new Label();
        this.label42 = new Label();
        this.flowLayoutPanel14 = new FlowLayoutPanel();
        this.lblColonyCost = new Label();
        this.lblCCTemp = new Label();
        this.lblBreathable = new Label();
        this.lblDangerous = new Label();
        this.lblMaxPressure = new Label();
        this.lblWater = new Label();
        this.lblCCGravity = new Label();
        this.lblRetention = new Label();
        this.lblPerihelionCC = new Label();
        this.lblAphelionCC = new Label();
        this.lstvAtmosphere = new ListView();
        this.columnHeader_118 = new ColumnHeader();
        this.columnHeader_119 = new ColumnHeader();
        this.columnHeader_120 = new ColumnHeader();
        this.flpAddGas = new FlowLayoutPanel();
        this.cboGas = new ComboBox();
        this.chkAddGas = new CheckBox();
        this.label10 = new Label();
        this.txtMaxAtm = new TextBox();
        this.cmdSMSetAtm = new Button();
        this.lblHydroExt = new Label();
        this.txtHydroExt = new TextBox();
        this.cmdHydroExt = new Button();
        this.tabGovernor = new TabPage();
        this.panel2 = new Panel();
        this.cboTransferRace = new ComboBox();
        this.cmdTransferPopulation = new Button();
        this.flowLayoutPanel12 = new FlowLayoutPanel();
        this.label47 = new Label();
        this.txtFuelWarning = new TextBox();
        this.label48 = new Label();
        this.txtMSPWarning = new TextBox();
        this.rdoConstant = new RadioButton();
        this.rdoSingleWarning = new RadioButton();
        this.flowLayoutPanel24 = new FlowLayoutPanel();
        this.cmdSelectGovernor = new Button();
        this.cmdAssignGovernors = new Button();
        this.cmdReassignAllGovernors = new Button();
        this.flowLayoutPanel23 = new FlowLayoutPanel();
        this.rdoYes = new RadioButton();
        this.rdoNo = new RadioButton();
        this.rdoNone = new RadioButton();
        this.label37 = new Label();
        this.txtImportance = new TextBox();
        this.label39 = new Label();
        this.cboBonusOne = new ComboBox();
        this.label36 = new Label();
        this.cboBonusTwo = new ComboBox();
        this.label40 = new Label();
        this.cboBonusThree = new ComboBox();
        this.lstvGovernor = new ListView();
        this.columnHeader_127 = new ColumnHeader();
        this.columnHeader_128 = new ColumnHeader();
        this.tabPOW = new TabPage();
        this.cmdRelease = new Button();
        this.flowLayoutPanel17 = new FlowLayoutPanel();
        this.rdoPOWPop = new RadioButton();
        this.rdoPOWEmpire = new RadioButton();
        this.lstvPOWOfficers = new ListView();
        this.columnHeader_170 = new ColumnHeader();
        this.columnHeader_172 = new ColumnHeader();
        this.columnHeader_171 = new ColumnHeader();
        this.columnHeader_173 = new ColumnHeader();
        this.columnHeader_174 = new ColumnHeader();
        this.columnHeader_175 = new ColumnHeader();
        this.tabEmpireMining = new TabPage();
        this.lstvEmpireMiningProduction = new ListView();
        this.columnHeader_148 = new ColumnHeader();
        this.columnHeader_149 = new ColumnHeader();
        this.columnHeader_150 = new ColumnHeader();
        this.columnHeader_151 = new ColumnHeader();
        this.columnHeader_152 = new ColumnHeader();
        this.columnHeader_153 = new ColumnHeader();
        this.columnHeader_154 = new ColumnHeader();
        this.columnHeader_155 = new ColumnHeader();
        this.columnHeader_156 = new ColumnHeader();
        this.columnHeader_157 = new ColumnHeader();
        this.columnHeader_158 = new ColumnHeader();
        this.columnHeader_159 = new ColumnHeader();
        this.lstvEmpireStockpiles = new ListView();
        this.columnHeader_130 = new ColumnHeader();
        this.columnHeader_131 = new ColumnHeader();
        this.columnHeader_132 = new ColumnHeader();
        this.columnHeader_133 = new ColumnHeader();
        this.columnHeader_134 = new ColumnHeader();
        this.columnHeader_135 = new ColumnHeader();
        this.columnHeader_136 = new ColumnHeader();
        this.columnHeader_137 = new ColumnHeader();
        this.columnHeader_138 = new ColumnHeader();
        this.columnHeader_139 = new ColumnHeader();
        this.columnHeader_140 = new ColumnHeader();
        this.columnHeader_141 = new ColumnHeader();
        this.tabAncientConstruct = new TabPage();
        this.lstvConstructs = new ListView();
        this.columnHeader_121 = new ColumnHeader();
        this.columnHeader_122 = new ColumnHeader();
        this.columnHeader_123 = new ColumnHeader();
        this.columnHeader_129 = new ColumnHeader();
        this.columnHeader_124 = new ColumnHeader();
        this.columnHeader_125 = new ColumnHeader();
        this.columnHeader_126 = new ColumnHeader();
        this.tabMineralData = new TabPage();
        this.flowLayoutPanel27 = new FlowLayoutPanel();
        this.chkCurrentPopulation = new CheckBox();
        this.rdoMinMonth = new RadioButton();
        this.rdoMin3Months = new RadioButton();
        this.rdoMin6Months = new RadioButton();
        this.rdoMinYear = new RadioButton();
        this.lstvMineralData = new ListView();
        this.columnHeader_176 = new ColumnHeader();
        this.columnHeader_177 = new ColumnHeader();
        this.columnHeader_178 = new ColumnHeader();
        this.columnHeader_179 = new ColumnHeader();
        this.columnHeader_180 = new ColumnHeader();
        this.columnHeader_181 = new ColumnHeader();
        this.columnHeader_182 = new ColumnHeader();
        this.columnHeader_183 = new ColumnHeader();
        this.columnHeader_184 = new ColumnHeader();
        this.columnHeader_185 = new ColumnHeader();
        this.columnHeader_186 = new ColumnHeader();
        this.columnHeader_187 = new ColumnHeader();
        this.chkShowSystemBody = new CheckBox();
        this.chkByFunction = new CheckBox();
        this.chkHideCMC = new CheckBox();
        this.timer_0 = new Timer(this.icontainer_0);
        this.flowLayoutPanel16 = new FlowLayoutPanel();
        this.chkShowStars = new CheckBox();
        this.tabPopulation.SuspendLayout();
        this.tabSummary.SuspendLayout();
        this.flowLayoutPanel15.SuspendLayout();
        this.flowLayoutPanel1.SuspendLayout();
        this.tabIndustry.SuspendLayout();
        this.pnlGeneticModification.SuspendLayout();
        this.panel6.SuspendLayout();
        this.panel5.SuspendLayout();
        this.panel4.SuspendLayout();
        this.flowLayoutPanel19.SuspendLayout();
        this.tabMining.SuspendLayout();
        this.flowLayoutPanel26.SuspendLayout();
        this.flpPurchase.SuspendLayout();
        this.tabShipyards.SuspendLayout();
        this.panel3.SuspendLayout();
        this.panel1.SuspendLayout();
        this.flowLayoutPanel9.SuspendLayout();
        this.tabSYTasks.SuspendLayout();
        this.flowLayoutPanel18.SuspendLayout();
        this.tabResearch.SuspendLayout();
        this.flowLayoutPanel3.SuspendLayout();
        this.flpRPSort.SuspendLayout();
        this.flowLayoutPanel5.SuspendLayout();
        this.flowLayoutPanel4.SuspendLayout();
        this.flpCreateProjectsBar.SuspendLayout();
        this.flowLayoutPanel2.SuspendLayout();
        this.flowLayoutPanel20.SuspendLayout();
        this.tabGUTraining.SuspendLayout();
        this.pnlStartingBuildPoints.SuspendLayout();
        this.tabWealth.SuspendLayout();
        this.panel7.SuspendLayout();
        this.tabCivilian.SuspendLayout();
        this.flowLayoutPanel25.SuspendLayout();
        this.flowLayoutPanel10.SuspendLayout();
        this.flowLayoutPanel8.SuspendLayout();
        this.flowLayoutPanel7.SuspendLayout();
        this.flowLayoutPanel6.SuspendLayout();
        this.tabStockpile.SuspendLayout();
        this.flowLayoutPanel11.SuspendLayout();
        this.tabEnvironment.SuspendLayout();
        this.flpSpecies.SuspendLayout();
        this.flowLayoutPanel21.SuspendLayout();
        this.flowLayoutPanel22.SuspendLayout();
        this.flpColonyCostFactors.SuspendLayout();
        this.flowLayoutPanel13.SuspendLayout();
        this.flowLayoutPanel14.SuspendLayout();
        this.flpAddGas.SuspendLayout();
        this.tabGovernor.SuspendLayout();
        this.panel2.SuspendLayout();
        this.flowLayoutPanel12.SuspendLayout();
        this.flowLayoutPanel24.SuspendLayout();
        this.flowLayoutPanel23.SuspendLayout();
        this.tabPOW.SuspendLayout();
        this.flowLayoutPanel17.SuspendLayout();
        this.tabEmpireMining.SuspendLayout();
        this.tabAncientConstruct.SuspendLayout();
        this.tabMineralData.SuspendLayout();
        this.flowLayoutPanel27.SuspendLayout();
        this.flowLayoutPanel16.SuspendLayout();
        this.SuspendLayout();
        this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRaces.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboRaces.FormattingEnabled = true;
        this.cboRaces.Location = new Point(3, 3);
        this.cboRaces.Margin = new Padding(3, 3, 3, 0);
        this.cboRaces.Name = "cboRaces";
        this.cboRaces.Size = new Size(380, 21);
        this.cboRaces.TabIndex = 1;
        this.cboRaces.SelectedIndexChanged += this.cboRaces_SelectedIndexChanged;
        this.tvPopList.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvPopList.BorderStyle = BorderStyle.FixedSingle;
        this.tvPopList.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.tvPopList.HideSelection = false;
        this.tvPopList.Location = new Point(3, 30);
        this.tvPopList.Margin = new Padding(3, 0, 0, 3);
        this.tvPopList.Name = "tvPopList";
        this.tvPopList.Size = new Size(380, 791);
        this.tvPopList.TabIndex = 2;
        this.tvPopList.AfterCollapse += this.tvPopList_AfterExpand;
        this.tvPopList.AfterExpand += this.tvPopList_AfterExpand;
        this.tvPopList.AfterSelect += this.tvPopList_AfterSelect;
        this.tabPopulation.Controls.Add(this.tabSummary);
        this.tabPopulation.Controls.Add(this.tabIndustry);
        this.tabPopulation.Controls.Add(this.tabMining);
        this.tabPopulation.Controls.Add(this.tabShipyards);
        this.tabPopulation.Controls.Add(this.tabSYTasks);
        this.tabPopulation.Controls.Add(this.tabResearch);
        this.tabPopulation.Controls.Add(this.tabGUTraining);
        this.tabPopulation.Controls.Add(this.tabWealth);
        this.tabPopulation.Controls.Add(this.tabCivilian);
        this.tabPopulation.Controls.Add(this.tabStockpile);
        this.tabPopulation.Controls.Add(this.tabEnvironment);
        this.tabPopulation.Controls.Add(this.tabGovernor);
        this.tabPopulation.Controls.Add(this.tabPOW);
        this.tabPopulation.Controls.Add(this.tabEmpireMining);
        this.tabPopulation.Controls.Add(this.tabMineralData);
        this.tabPopulation.Controls.Add(this.tabAncientConstruct);
        this.tabPopulation.Location = new Point(386, 3);
        this.tabPopulation.Name = "tabPopulation";
        this.tabPopulation.SelectedIndex = 0;
        this.tabPopulation.Size = new Size(1038, 862);
        this.tabPopulation.TabIndex = 31 /*0x1F*/;
        this.tabSummary.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabSummary.Controls.Add(this.flowLayoutPanel15);
        this.tabSummary.Controls.Add(this.lblSecGovName);
        this.tabSummary.Controls.Add(this.label4);
        this.tabSummary.Controls.Add(this.lblGovName);
        this.tabSummary.Controls.Add(this.label1);
        this.tabSummary.Controls.Add(this.flowLayoutPanel1);
        this.tabSummary.Location = new Point(4, 22);
        this.tabSummary.Name = "tabSummary";
        this.tabSummary.Padding = new Padding(3);
        this.tabSummary.Size = new Size(1030, 836);
        this.tabSummary.TabIndex = 0;
        this.tabSummary.Text = "Summary";
        this.flowLayoutPanel15.Controls.Add(this.cmdRenamePop);
        this.flowLayoutPanel15.Controls.Add(this.cmdRenameAcademy);
        this.flowLayoutPanel15.Controls.Add(this.cmdCapital);
        this.flowLayoutPanel15.Controls.Add(this.cmdPopAsText);
        this.flowLayoutPanel15.Controls.Add(this.cmdAllPopAsText);
        this.flowLayoutPanel15.Controls.Add(this.cmdToggleEmpty);
        this.flowLayoutPanel15.Controls.Add(this.cmdIndependence);
        this.flowLayoutPanel15.Controls.Add(this.cmdEditPopAmount);
        this.flowLayoutPanel15.Controls.Add(this.cmdDeletePopulation);
        this.flowLayoutPanel15.Controls.Add(this.cmdDeleteEmpty);
        this.flowLayoutPanel15.Controls.Add(this.cmdAddOG);
        this.flowLayoutPanel15.Location = new Point(3, 803);
        this.flowLayoutPanel15.Name = "flowLayoutPanel15";
        this.flowLayoutPanel15.Size = new Size(1024 /*0x0400*/, 30);
        this.flowLayoutPanel15.TabIndex = 117;
        this.cmdRenamePop.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenamePop.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRenamePop.Location = new Point(0, 0);
        this.cmdRenamePop.Margin = new Padding(0);
        this.cmdRenamePop.Name = "cmdRenamePop";
        this.cmdRenamePop.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenamePop.TabIndex = 7;
        this.cmdRenamePop.Tag = "1200";
        this.cmdRenamePop.Text = "Rename Pop";
        this.cmdRenamePop.UseVisualStyleBackColor = false;
        this.cmdRenamePop.Click += this.cmdRenamePop_Click;
        this.cmdRenameAcademy.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameAcademy.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRenameAcademy.Location = new Point(96 /*0x60*/, 0);
        this.cmdRenameAcademy.Margin = new Padding(0);
        this.cmdRenameAcademy.Name = "cmdRenameAcademy";
        this.cmdRenameAcademy.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameAcademy.TabIndex = 8;
        this.cmdRenameAcademy.Tag = "1200";
        this.cmdRenameAcademy.Text = "Academy Name";
        this.cmdRenameAcademy.UseVisualStyleBackColor = false;
        this.cmdRenameAcademy.Click += this.cmdRenameAcademy_Click;
        this.cmdCapital.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCapital.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdCapital.Location = new Point(192 /*0xC0*/, 0);
        this.cmdCapital.Margin = new Padding(0);
        this.cmdCapital.Name = "cmdCapital";
        this.cmdCapital.Size = new Size(96 /*0x60*/, 30);
        this.cmdCapital.TabIndex = 13;
        this.cmdCapital.Tag = "1200";
        this.cmdCapital.Text = "Set Capital";
        this.cmdCapital.UseVisualStyleBackColor = false;
        this.cmdCapital.Click += this.cmdCapital_Click;
        this.cmdPopAsText.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdPopAsText.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdPopAsText.Location = new Point(288, 0);
        this.cmdPopAsText.Margin = new Padding(0);
        this.cmdPopAsText.Name = "cmdPopAsText";
        this.cmdPopAsText.Size = new Size(96 /*0x60*/, 30);
        this.cmdPopAsText.TabIndex = 9;
        this.cmdPopAsText.Tag = "1200";
        this.cmdPopAsText.Text = "Pop as Text";
        this.cmdPopAsText.UseVisualStyleBackColor = false;
        this.cmdPopAsText.Click += this.cmdPopAsText_Click;
        this.cmdAllPopAsText.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAllPopAsText.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdAllPopAsText.Location = new Point(384, 0);
        this.cmdAllPopAsText.Margin = new Padding(0);
        this.cmdAllPopAsText.Name = "cmdAllPopAsText";
        this.cmdAllPopAsText.Size = new Size(96 /*0x60*/, 30);
        this.cmdAllPopAsText.TabIndex = 10;
        this.cmdAllPopAsText.Tag = "1200";
        this.cmdAllPopAsText.Text = "All Pop as Text";
        this.cmdAllPopAsText.UseVisualStyleBackColor = false;
        this.cmdAllPopAsText.Click += this.cmdAllPopAsText_Click;
        this.cmdToggleEmpty.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdToggleEmpty.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdToggleEmpty.Location = new Point(480, 0);
        this.cmdToggleEmpty.Margin = new Padding(0);
        this.cmdToggleEmpty.Name = "cmdToggleEmpty";
        this.cmdToggleEmpty.Size = new Size(96 /*0x60*/, 30);
        this.cmdToggleEmpty.TabIndex = 11;
        this.cmdToggleEmpty.Tag = "1200";
        this.cmdToggleEmpty.Text = "Empty Exempt";
        this.cmdToggleEmpty.UseVisualStyleBackColor = false;
        this.cmdToggleEmpty.Click += this.cmdToggleEmpty_Click;
        this.cmdIndependence.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdIndependence.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdIndependence.Location = new Point(576, 0);
        this.cmdIndependence.Margin = new Padding(0);
        this.cmdIndependence.Name = "cmdIndependence";
        this.cmdIndependence.Size = new Size(96 /*0x60*/, 30);
        this.cmdIndependence.TabIndex = 1;
        this.cmdIndependence.Tag = "1200";
        this.cmdIndependence.Text = "Independence";
        this.cmdIndependence.UseVisualStyleBackColor = false;
        this.cmdIndependence.Click += this.cmdIndependence_Click;
        this.cmdEditPopAmount.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdEditPopAmount.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdEditPopAmount.Location = new Point(672, 0);
        this.cmdEditPopAmount.Margin = new Padding(0);
        this.cmdEditPopAmount.Name = "cmdEditPopAmount";
        this.cmdEditPopAmount.Size = new Size(96 /*0x60*/, 30);
        this.cmdEditPopAmount.TabIndex = 3;
        this.cmdEditPopAmount.Tag = "1200";
        this.cmdEditPopAmount.Text = "SM: Edit Pop";
        this.cmdEditPopAmount.UseVisualStyleBackColor = false;
        this.cmdEditPopAmount.Click += this.cmdEditPopAmount_Click;
        this.cmdDeletePopulation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeletePopulation.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDeletePopulation.Location = new Point(768 /*0x0300*/, 0);
        this.cmdDeletePopulation.Margin = new Padding(0);
        this.cmdDeletePopulation.Name = "cmdDeletePopulation";
        this.cmdDeletePopulation.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeletePopulation.TabIndex = 1;
        this.cmdDeletePopulation.Tag = "1200";
        this.cmdDeletePopulation.Text = "Delete Pop";
        this.cmdDeletePopulation.UseVisualStyleBackColor = false;
        this.cmdDeletePopulation.Click += this.cmdDeletePopulation_Click;
        this.cmdDeleteEmpty.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteEmpty.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDeleteEmpty.Location = new Point(864, 0);
        this.cmdDeleteEmpty.Margin = new Padding(0);
        this.cmdDeleteEmpty.Name = "cmdDeleteEmpty";
        this.cmdDeleteEmpty.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteEmpty.TabIndex = 5;
        this.cmdDeleteEmpty.Tag = "1200";
        this.cmdDeleteEmpty.Text = "Delete Empty";
        this.cmdDeleteEmpty.UseVisualStyleBackColor = false;
        this.cmdDeleteEmpty.Click += this.cmdDeleteEmpty_Click;
        this.cmdAddOG.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddOG.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdAddOG.Location = new Point(0, 30);
        this.cmdAddOG.Margin = new Padding(0);
        this.cmdAddOG.Name = "cmdAddOG";
        this.cmdAddOG.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddOG.TabIndex = 12;
        this.cmdAddOG.Tag = "1200";
        this.cmdAddOG.Text = "Add NPR OG";
        this.cmdAddOG.UseVisualStyleBackColor = false;
        this.cmdAddOG.Visible = false;
        this.cmdAddOG.Click += this.cmdAddOG_Click;
        this.lblSecGovName.Location = new Point(120, 27);
        this.lblSecGovName.Margin = new Padding(3);
        this.lblSecGovName.Name = "lblSecGovName";
        this.lblSecGovName.Size = new Size(900, 13);
        this.lblSecGovName.TabIndex = 54;
        this.lblSecGovName.Text = "None";
        this.label4.AutoSize = true;
        this.label4.Location = new Point(15, 27);
        this.label4.Margin = new Padding(3);
        this.label4.Name = "label4";
        this.label4.Size = new Size(85, 13);
        this.label4.TabIndex = 53;
        this.label4.Text = "Sector Governor";
        this.lblGovName.Location = new Point(120, 8);
        this.lblGovName.Margin = new Padding(3);
        this.lblGovName.Name = "lblGovName";
        this.lblGovName.Size = new Size(900, 13);
        this.lblGovName.TabIndex = 52;
        this.lblGovName.Text = "None";
        this.label1.AutoSize = true;
        this.label1.Location = new Point(15, 8);
        this.label1.Margin = new Padding(3);
        this.label1.Name = "label1";
        this.label1.Size = new Size(98, 13);
        this.label1.TabIndex = 51;
        this.label1.Text = "Planetary Governor";
        this.flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel1.Controls.Add(this.lstvPopSummary);
        this.flowLayoutPanel1.Controls.Add(this.lstvPopSummary2);
        this.flowLayoutPanel1.Controls.Add(this.lstvPopSummary3);
        this.flowLayoutPanel1.Location = new Point(3, 46);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(1024 /*0x0400*/, 753);
        this.flowLayoutPanel1.TabIndex = 50;
        this.lstvPopSummary.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvPopSummary.BorderStyle = BorderStyle.FixedSingle;
        this.lstvPopSummary.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_0,
            this.columnHeader_1
        });
        this.lstvPopSummary.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvPopSummary.FullRowSelect = true;
        this.lstvPopSummary.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvPopSummary.HideSelection = false;
        this.lstvPopSummary.Location = new Point(4, 3);
        this.lstvPopSummary.Margin = new Padding(4, 3, 3, 3);
        this.lstvPopSummary.Name = "lstvPopSummary";
        this.lstvPopSummary.Size = new Size(334, 744);
        this.lstvPopSummary.TabIndex = 14;
        this.lstvPopSummary.UseCompatibleStateImageBehavior = false;
        this.lstvPopSummary.View = View.Details;
        this.columnHeader_0.Width = 210;
        this.columnHeader_1.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_1.Width = 120;
        this.lstvPopSummary2.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvPopSummary2.BorderStyle = BorderStyle.FixedSingle;
        this.lstvPopSummary2.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_2,
            this.columnHeader_3
        });
        this.lstvPopSummary2.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvPopSummary2.FullRowSelect = true;
        this.lstvPopSummary2.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvPopSummary2.HideSelection = false;
        this.lstvPopSummary2.Location = new Point(344, 3);
        this.lstvPopSummary2.Name = "lstvPopSummary2";
        this.lstvPopSummary2.Size = new Size(334, 744);
        this.lstvPopSummary2.TabIndex = 15;
        this.lstvPopSummary2.UseCompatibleStateImageBehavior = false;
        this.lstvPopSummary2.View = View.Details;
        this.columnHeader_2.Width = 200;
        this.columnHeader_3.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_3.Width = 115;
        this.lstvPopSummary3.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvPopSummary3.BorderStyle = BorderStyle.FixedSingle;
        this.lstvPopSummary3.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_4,
            this.columnHeader_5
        });
        this.lstvPopSummary3.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvPopSummary3.FullRowSelect = true;
        this.lstvPopSummary3.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvPopSummary3.HideSelection = false;
        this.lstvPopSummary3.Location = new Point(684, 3);
        this.lstvPopSummary3.Name = "lstvPopSummary3";
        this.lstvPopSummary3.Size = new Size(334, 744);
        this.lstvPopSummary3.TabIndex = 16 /*0x10*/;
        this.lstvPopSummary3.UseCompatibleStateImageBehavior = false;
        this.lstvPopSummary3.View = View.Details;
        this.columnHeader_4.Width = 210;
        this.columnHeader_5.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_5.Width = 120;
        this.tabIndustry.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabIndustry.Controls.Add(this.pnlGeneticModification);
        this.tabIndustry.Controls.Add(this.lblIndustry);
        this.tabIndustry.Controls.Add(this.panel6);
        this.tabIndustry.Controls.Add(this.panel5);
        this.tabIndustry.Controls.Add(this.panel4);
        this.tabIndustry.Controls.Add(this.lstvMinerals);
        this.tabIndustry.Controls.Add(this.lstvConstruction);
        this.tabIndustry.Controls.Add(this.lstPI);
        this.tabIndustry.Controls.Add(this.cboConstructionType);
        this.tabIndustry.Location = new Point(4, 22);
        this.tabIndustry.Name = "tabIndustry";
        this.tabIndustry.Padding = new Padding(3);
        this.tabIndustry.Size = new Size(1030, 836);
        this.tabIndustry.TabIndex = 1;
        this.tabIndustry.Text = "Industry";
        this.pnlGeneticModification.BorderStyle = BorderStyle.FixedSingle;
        this.pnlGeneticModification.Controls.Add(this.label46);
        this.pnlGeneticModification.Controls.Add(this.cboTargetSpecies);
        this.pnlGeneticModification.Controls.Add(this.lblGeneticModification);
        this.pnlGeneticModification.Controls.Add(this.cmdGMC);
        this.pnlGeneticModification.Location = new Point(224 /*0xE0*/, 789);
        this.pnlGeneticModification.Name = "pnlGeneticModification";
        this.pnlGeneticModification.Size = new Size(800, 44);
        this.pnlGeneticModification.TabIndex = 92;
        this.label46.AutoSize = true;
        this.label46.Location = new Point(455, 10);
        this.label46.Name = "label46";
        this.label46.Padding = new Padding(0, 5, 5, 0);
        this.label46.Size = new Size(84, 18);
        this.label46.TabIndex = 82;
        this.label46.Text = "Target Species";
        this.cboTargetSpecies.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboTargetSpecies.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboTargetSpecies.FormattingEnabled = true;
        this.cboTargetSpecies.Location = new Point(538, 10);
        this.cboTargetSpecies.Margin = new Padding(3, 3, 3, 0);
        this.cboTargetSpecies.Name = "cboTargetSpecies";
        this.cboTargetSpecies.Size = new Size(147, 21);
        this.cboTargetSpecies.TabIndex = 81;
        this.cboTargetSpecies.SelectedIndexChanged += this.cboTargetSpecies_SelectedIndexChanged;
        this.lblGeneticModification.AutoSize = true;
        this.lblGeneticModification.Location = new Point(12, 10);
        this.lblGeneticModification.Name = "lblGeneticModification";
        this.lblGeneticModification.Padding = new Padding(0, 5, 5, 0);
        this.lblGeneticModification.Size = new Size(135, 18);
        this.lblGeneticModification.TabIndex = 80 /*0x50*/;
        this.lblGeneticModification.Text = "Genetic Modification Here";
        this.cmdGMC.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdGMC.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdGMC.Location = new Point(695, 6);
        this.cmdGMC.Margin = new Padding(0);
        this.cmdGMC.Name = "cmdGMC";
        this.cmdGMC.Size = new Size(96 /*0x60*/, 30);
        this.cmdGMC.TabIndex = 30;
        this.cmdGMC.Tag = "1200";
        this.cmdGMC.Text = "Start";
        this.cmdGMC.UseVisualStyleBackColor = false;
        this.cmdGMC.Click += this.cmdGMC_Click;
        this.lblIndustry.BorderStyle = BorderStyle.FixedSingle;
        this.lblIndustry.Location = new Point(224 /*0xE0*/, 6);
        this.lblIndustry.Margin = new Padding(3);
        this.lblIndustry.Name = "lblIndustry";
        this.lblIndustry.Size = new Size(800, 21);
        this.lblIndustry.TabIndex = 91;
        this.lblIndustry.Text = "None";
        this.panel6.BorderStyle = BorderStyle.FixedSingle;
        this.panel6.Controls.Add(this.cmdEditMSP);
        this.panel6.Controls.Add(this.lblMaintenance);
        this.panel6.Controls.Add(this.cmdMaintenance);
        this.panel6.Location = new Point(224 /*0xE0*/, 740);
        this.panel6.Name = "panel6";
        this.panel6.Size = new Size(800, 44);
        this.panel6.TabIndex = 90;
        this.cmdEditMSP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdEditMSP.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdEditMSP.Location = new Point(599, 6);
        this.cmdEditMSP.Margin = new Padding(0);
        this.cmdEditMSP.Name = "cmdEditMSP";
        this.cmdEditMSP.Size = new Size(96 /*0x60*/, 30);
        this.cmdEditMSP.TabIndex = 82;
        this.cmdEditMSP.Tag = "1200";
        this.cmdEditMSP.Text = "SM: Edit MSP";
        this.cmdEditMSP.UseVisualStyleBackColor = false;
        this.cmdEditMSP.Visible = false;
        this.cmdEditMSP.Click += this.cmdEditMSP_Click;
        this.lblMaintenance.AutoSize = true;
        this.lblMaintenance.Location = new Point(12, 10);
        this.lblMaintenance.Name = "lblMaintenance";
        this.lblMaintenance.Padding = new Padding(0, 5, 5, 0);
        this.lblMaintenance.Size = new Size(155, 18);
        this.lblMaintenance.TabIndex = 80 /*0x50*/;
        this.lblMaintenance.Text = "Maintenance Information Here";
        this.cmdMaintenance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdMaintenance.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdMaintenance.Location = new Point(695, 6);
        this.cmdMaintenance.Margin = new Padding(0);
        this.cmdMaintenance.Name = "cmdMaintenance";
        this.cmdMaintenance.Size = new Size(96 /*0x60*/, 30);
        this.cmdMaintenance.TabIndex = 30;
        this.cmdMaintenance.Tag = "1200";
        this.cmdMaintenance.Text = "Start";
        this.cmdMaintenance.UseVisualStyleBackColor = false;
        this.cmdMaintenance.Click += this.cmdMaintenance_Click;
        this.panel5.BorderStyle = BorderStyle.FixedSingle;
        this.panel5.Controls.Add(this.cmdEditFuel);
        this.panel5.Controls.Add(this.lblRefineries);
        this.panel5.Controls.Add(this.cmdRefinery);
        this.panel5.Location = new Point(224 /*0xE0*/, 691);
        this.panel5.Name = "panel5";
        this.panel5.Size = new Size(800, 44);
        this.panel5.TabIndex = 89;
        this.cmdEditFuel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdEditFuel.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdEditFuel.Location = new Point(599, 6);
        this.cmdEditFuel.Margin = new Padding(0);
        this.cmdEditFuel.Name = "cmdEditFuel";
        this.cmdEditFuel.Size = new Size(96 /*0x60*/, 30);
        this.cmdEditFuel.TabIndex = 81;
        this.cmdEditFuel.Tag = "1200";
        this.cmdEditFuel.Text = "SM: Edit Fuel";
        this.cmdEditFuel.UseVisualStyleBackColor = false;
        this.cmdEditFuel.Visible = false;
        this.cmdEditFuel.Click += this.cmdEditFuel_Click;
        this.lblRefineries.AutoSize = true;
        this.lblRefineries.Location = new Point(12, 10);
        this.lblRefineries.Name = "lblRefineries";
        this.lblRefineries.Padding = new Padding(0, 5, 5, 0);
        this.lblRefineries.Size = new Size(132, 18);
        this.lblRefineries.TabIndex = 80 /*0x50*/;
        this.lblRefineries.Text = "Refinery Information Here";
        this.cmdRefinery.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRefinery.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRefinery.Location = new Point(695, 6);
        this.cmdRefinery.Margin = new Padding(0);
        this.cmdRefinery.Name = "cmdRefinery";
        this.cmdRefinery.Size = new Size(96 /*0x60*/, 30);
        this.cmdRefinery.TabIndex = 29;
        this.cmdRefinery.Tag = "1200";
        this.cmdRefinery.Text = "Start";
        this.cmdRefinery.UseVisualStyleBackColor = false;
        this.cmdRefinery.Click += this.cmdRefinery_Click;
        this.panel4.BorderStyle = BorderStyle.FixedSingle;
        this.panel4.Controls.Add(this.flowLayoutPanel19);
        this.panel4.Controls.Add(this.cmdDownQueue);
        this.panel4.Controls.Add(this.cmdCreate);
        this.panel4.Controls.Add(this.cmdUpQueue);
        this.panel4.Controls.Add(this.cmdModify);
        this.panel4.Controls.Add(this.cmdCancel);
        this.panel4.Controls.Add(this.cmdPause);
        this.panel4.Location = new Point(224 /*0xE0*/, 611);
        this.panel4.Name = "panel4";
        this.panel4.Size = new Size(800, 75);
        this.panel4.TabIndex = 88;
        this.flowLayoutPanel19.Controls.Add(this.label3);
        this.flowLayoutPanel19.Controls.Add(this.txtItems);
        this.flowLayoutPanel19.Controls.Add(this.label5);
        this.flowLayoutPanel19.Controls.Add(this.txtPercentage);
        this.flowLayoutPanel19.Controls.Add(this.label2);
        this.flowLayoutPanel19.Controls.Add(this.cboFighters);
        this.flowLayoutPanel19.Controls.Add(this.label19);
        this.flowLayoutPanel19.Controls.Add(this.cboSpaceStations);
        this.flowLayoutPanel19.Location = new Point(3, 3);
        this.flowLayoutPanel19.Name = "flowLayoutPanel19";
        this.flowLayoutPanel19.Size = new Size(792, 33);
        this.flowLayoutPanel19.TabIndex = 92;
        this.label3.AutoSize = true;
        this.label3.Location = new Point(3, 3);
        this.label3.Margin = new Padding(3, 3, 3, 0);
        this.label3.Name = "label3";
        this.label3.Padding = new Padding(0, 5, 5, 0);
        this.label3.Size = new Size(89, 18);
        this.label3.TabIndex = 79;
        this.label3.Text = "Number of Items";
        this.txtItems.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtItems.BorderStyle = BorderStyle.None;
        this.txtItems.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtItems.Location = new Point(98, 8);
        this.txtItems.Margin = new Padding(3, 8, 3, 3);
        this.txtItems.Name = "txtItems";
        this.txtItems.Size = new Size(60, 13);
        this.txtItems.TabIndex = 19;
        this.txtItems.Text = "1";
        this.txtItems.TextAlign = HorizontalAlignment.Center;
        this.txtItems.TextChanged += this.txtItems_TextChanged;
        this.txtItems.Leave += this.txtItems_Leave;
        this.label5.AutoSize = true;
        this.label5.Location = new Point(164, 3);
        this.label5.Margin = new Padding(3, 3, 3, 0);
        this.label5.Name = "label5";
        this.label5.Padding = new Padding(0, 5, 5, 0);
        this.label5.Size = new Size(67, 18);
        this.label5.TabIndex = 81;
        this.label5.Text = "Percentage";
        this.txtPercentage.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtPercentage.BorderStyle = BorderStyle.None;
        this.txtPercentage.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtPercentage.Location = new Point(237, 8);
        this.txtPercentage.Margin = new Padding(3, 8, 3, 3);
        this.txtPercentage.Name = "txtPercentage";
        this.txtPercentage.Size = new Size(80 /*0x50*/, 13);
        this.txtPercentage.TabIndex = 20;
        this.txtPercentage.Text = "100";
        this.txtPercentage.TextAlign = HorizontalAlignment.Center;
        this.txtPercentage.Leave += this.txtPercentage_Leave;
        this.label2.AutoSize = true;
        this.label2.Location = new Point(328, 3);
        this.label2.Margin = new Padding(8, 3, 3, 0);
        this.label2.Name = "label2";
        this.label2.Padding = new Padding(0, 5, 5, 0);
        this.label2.Size = new Size(49, 18);
        this.label2.TabIndex = 85;
        this.label2.Text = "Fighters";
        this.cboFighters.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboFighters.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboFighters.FormattingEnabled = true;
        this.cboFighters.Location = new Point(383, 4);
        this.cboFighters.Margin = new Padding(3, 4, 3, 0);
        this.cboFighters.Name = "cboFighters";
        this.cboFighters.Size = new Size(150, 21);
        this.cboFighters.TabIndex = 21;
        this.cboFighters.SelectedIndexChanged += this.cboFighters_SelectedIndexChanged;
        this.label19.AutoSize = true;
        this.label19.Location = new Point(539, 3);
        this.label19.Margin = new Padding(3, 3, 3, 0);
        this.label19.Name = "label19";
        this.label19.Padding = new Padding(0, 5, 5, 0);
        this.label19.Size = new Size(84, 18);
        this.label19.TabIndex = 87;
        this.label19.Text = "Space Stations";
        this.cboSpaceStations.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSpaceStations.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboSpaceStations.FormattingEnabled = true;
        this.cboSpaceStations.Location = new Point(629, 4);
        this.cboSpaceStations.Margin = new Padding(3, 4, 3, 0);
        this.cboSpaceStations.Name = "cboSpaceStations";
        this.cboSpaceStations.Size = new Size(150, 21);
        this.cboSpaceStations.TabIndex = 86;
        this.cboSpaceStations.SelectedIndexChanged += this.cboSpaceStations_SelectedIndexChanged;
        this.cmdDownQueue.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDownQueue.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDownQueue.Location = new Point(483, 37);
        this.cmdDownQueue.Margin = new Padding(0);
        this.cmdDownQueue.Name = "cmdDownQueue";
        this.cmdDownQueue.Size = new Size(96 /*0x60*/, 30);
        this.cmdDownQueue.TabIndex = 27;
        this.cmdDownQueue.Tag = "1200";
        this.cmdDownQueue.Text = "Down Queue";
        this.cmdDownQueue.UseVisualStyleBackColor = false;
        this.cmdDownQueue.Click += this.cmdDownQueue_Click;
        this.cmdCreate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreate.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdCreate.Location = new Point(3, 37);
        this.cmdCreate.Margin = new Padding(0);
        this.cmdCreate.Name = "cmdCreate";
        this.cmdCreate.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreate.TabIndex = 22;
        this.cmdCreate.Tag = "1200";
        this.cmdCreate.Text = "Create";
        this.cmdCreate.UseVisualStyleBackColor = false;
        this.cmdCreate.Click += this.cmdCreate_Click;
        this.cmdUpQueue.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdUpQueue.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdUpQueue.Location = new Point(387, 37);
        this.cmdUpQueue.Margin = new Padding(0);
        this.cmdUpQueue.Name = "cmdUpQueue";
        this.cmdUpQueue.Size = new Size(96 /*0x60*/, 30);
        this.cmdUpQueue.TabIndex = 26;
        this.cmdUpQueue.Tag = "1200";
        this.cmdUpQueue.Text = "Up Queue";
        this.cmdUpQueue.UseVisualStyleBackColor = false;
        this.cmdUpQueue.Click += this.cmdUpQueue_Click;
        this.cmdModify.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdModify.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdModify.Location = new Point(99, 37);
        this.cmdModify.Margin = new Padding(0);
        this.cmdModify.Name = "cmdModify";
        this.cmdModify.Size = new Size(96 /*0x60*/, 30);
        this.cmdModify.TabIndex = 23;
        this.cmdModify.Tag = "1200";
        this.cmdModify.Text = "Modify";
        this.cmdModify.UseVisualStyleBackColor = false;
        this.cmdModify.Click += this.cmdModify_Click;
        this.cmdCancel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCancel.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdCancel.Location = new Point(195, 37);
        this.cmdCancel.Margin = new Padding(0);
        this.cmdCancel.Name = "cmdCancel";
        this.cmdCancel.Size = new Size(96 /*0x60*/, 30);
        this.cmdCancel.TabIndex = 24;
        this.cmdCancel.Tag = "1200";
        this.cmdCancel.Text = "Cancel";
        this.cmdCancel.UseVisualStyleBackColor = false;
        this.cmdCancel.Click += this.cmdCancel_Click;
        this.cmdPause.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdPause.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdPause.Location = new Point(291, 37);
        this.cmdPause.Margin = new Padding(0);
        this.cmdPause.Name = "cmdPause";
        this.cmdPause.Size = new Size(96 /*0x60*/, 30);
        this.cmdPause.TabIndex = 25;
        this.cmdPause.Tag = "1200";
        this.cmdPause.Text = "Pause";
        this.cmdPause.UseVisualStyleBackColor = false;
        this.cmdPause.Click += this.cmdPause_Click;
        this.lstvMinerals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvMinerals.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_14,
            this.columnHeader_15,
            this.columnHeader_16
        });
        this.lstvMinerals.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvMinerals.FullRowSelect = true;
        this.lstvMinerals.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvMinerals.HideSelection = false;
        this.lstvMinerals.Location = new Point(3, 597);
        this.lstvMinerals.Name = "lstvMinerals";
        this.lstvMinerals.Size = new Size(217, 236);
        this.lstvMinerals.TabIndex = 83;
        this.lstvMinerals.UseCompatibleStateImageBehavior = false;
        this.lstvMinerals.View = View.Details;
        this.columnHeader_14.Text = "";
        this.columnHeader_14.Width = 80 /*0x50*/;
        this.columnHeader_15.Text = "";
        this.columnHeader_15.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_16.Text = "";
        this.columnHeader_16.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_16.Width = 70;
        this.lstvConstruction.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvConstruction.BorderStyle = BorderStyle.FixedSingle;
        this.lstvConstruction.Columns.AddRange(new ColumnHeader[8]
        {
            this.columnHeader_6,
            this.columnHeader_7,
            this.columnHeader_8,
            this.columnHeader_9,
            this.columnHeader_10,
            this.columnHeader_11,
            this.columnHeader_12,
            this.columnHeader_13
        });
        this.lstvConstruction.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvConstruction.FullRowSelect = true;
        this.lstvConstruction.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvConstruction.HideSelection = false;
        this.lstvConstruction.Location = new Point(224 /*0xE0*/, 30);
        this.lstvConstruction.Margin = new Padding(4, 3, 3, 3);
        this.lstvConstruction.MultiSelect = false;
        this.lstvConstruction.Name = "lstvConstruction";
        this.lstvConstruction.Size = new Size(800, 575);
        this.lstvConstruction.TabIndex = 71;
        this.lstvConstruction.UseCompatibleStateImageBehavior = false;
        this.lstvConstruction.View = View.Details;
        this.lstvConstruction.SelectedIndexChanged += this.lstvConstruction_SelectedIndexChanged;
        this.columnHeader_6.Width = 80 /*0x50*/;
        this.columnHeader_7.Width = 220;
        this.columnHeader_8.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_9.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_10.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_10.Width = 80 /*0x50*/;
        this.columnHeader_11.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_12.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_12.Width = 150;
        this.columnHeader_13.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_13.Width = 80 /*0x50*/;
        this.lstPI.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstPI.BorderStyle = BorderStyle.FixedSingle;
        this.lstPI.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstPI.FormattingEnabled = true;
        this.lstPI.Location = new Point(3, 30);
        this.lstPI.Name = "lstPI";
        this.lstPI.Size = new Size(217, 561);
        this.lstPI.TabIndex = 18;
        this.lstPI.SelectedIndexChanged += this.lstPI_SelectedIndexChanged;
        this.cboConstructionType.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboConstructionType.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboConstructionType.FormattingEnabled = true;
        this.cboConstructionType.Location = new Point(3, 6);
        this.cboConstructionType.Margin = new Padding(3, 3, 3, 0);
        this.cboConstructionType.Name = "cboConstructionType";
        this.cboConstructionType.Size = new Size(217, 21);
        this.cboConstructionType.TabIndex = 17;
        this.cboConstructionType.SelectedIndexChanged += this.cboConstructionType_SelectedIndexChanged;
        this.tabMining.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabMining.Controls.Add(this.flowLayoutPanel26);
        this.tabMining.Controls.Add(this.flpPurchase);
        this.tabMining.Controls.Add(this.chkReserve);
        this.tabMining.Controls.Add(this.lstvUsage);
        this.tabMining.Controls.Add(this.lstvMines);
        this.tabMining.Controls.Add(this.lstvMining);
        this.tabMining.Location = new Point(4, 22);
        this.tabMining.Name = "tabMining";
        this.tabMining.Padding = new Padding(3);
        this.tabMining.Size = new Size(1030, 836);
        this.tabMining.TabIndex = 2;
        this.tabMining.Text = "Mining";
        this.flowLayoutPanel26.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel26.Controls.Add(this.label17);
        this.flowLayoutPanel26.Controls.Add(this.cboMassDriver);
        this.flowLayoutPanel26.Controls.Add(this.label43);
        this.flowLayoutPanel26.Controls.Add(this.lblMDDistance);
        this.flowLayoutPanel26.Location = new Point(459, 698);
        this.flowLayoutPanel26.Name = "flowLayoutPanel26";
        this.flowLayoutPanel26.Size = new Size(568, 25);
        this.flowLayoutPanel26.TabIndex = 142;
        this.label17.AutoSize = true;
        this.label17.Location = new Point(12, 0);
        this.label17.Margin = new Padding(12, 0, 3, 0);
        this.label17.Name = "label17";
        this.label17.Padding = new Padding(0, 5, 5, 0);
        this.label17.Size = new Size(124, 18);
        this.label17.TabIndex = sbyte.MaxValue;
        this.label17.Text = "Mass Driver Destination";
        this.label17.TextAlign = ContentAlignment.MiddleLeft;
        this.cboMassDriver.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboMassDriver.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboMassDriver.FormattingEnabled = true;
        this.cboMassDriver.Location = new Point(142, 1);
        this.cboMassDriver.Margin = new Padding(3, 1, 3, 0);
        this.cboMassDriver.Name = "cboMassDriver";
        this.cboMassDriver.Size = new Size(176 /*0xB0*/, 21);
        this.cboMassDriver.TabIndex = 34;
        this.cboMassDriver.SelectedIndexChanged += this.cboMassDriver_SelectedIndexChanged;
        this.label43.AutoSize = true;
        this.label43.Location = new Point(327, 0);
        this.label43.Margin = new Padding(6, 0, 3, 0);
        this.label43.Name = "label43";
        this.label43.Padding = new Padding(12, 5, 5, 0);
        this.label43.Size = new Size(129, 18);
        this.label43.TabIndex = 128 /*0x80*/;
        this.label43.Text = "Estimated Travel Time";
        this.label43.TextAlign = ContentAlignment.MiddleLeft;
        this.lblMDDistance.AutoSize = true;
        this.lblMDDistance.Location = new Point(459, 0);
        this.lblMDDistance.Margin = new Padding(0, 0, 3, 0);
        this.lblMDDistance.Name = "lblMDDistance";
        this.lblMDDistance.Padding = new Padding(12, 5, 5, 0);
        this.lblMDDistance.Size = new Size(75, 18);
        this.lblMDDistance.TabIndex = 129;
        this.lblMDDistance.Text = "2000 Days";
        this.lblMDDistance.TextAlign = ContentAlignment.MiddleLeft;
        this.flpPurchase.BorderStyle = BorderStyle.FixedSingle;
        this.flpPurchase.Controls.Add(this.rdoPurchase);
        this.flpPurchase.Controls.Add(this.rdoTaxMinerals);
        this.flpPurchase.Controls.Add(this.lblCivilianMinerals);
        this.flpPurchase.Controls.Add(this.txtCivilianMinerals);
        this.flpPurchase.Location = new Point(4, 698);
        this.flpPurchase.Name = "flpPurchase";
        this.flpPurchase.Size = new Size(449, 25);
        this.flpPurchase.TabIndex = 139;
        this.rdoPurchase.AutoSize = true;
        this.rdoPurchase.Checked = true;
        this.rdoPurchase.Location = new Point(6, 3);
        this.rdoPurchase.Margin = new Padding(6, 3, 3, 3);
        this.rdoPurchase.Name = "rdoPurchase";
        this.rdoPurchase.Size = new Size(112 /*0x70*/, 17);
        this.rdoPurchase.TabIndex = 1;
        this.rdoPurchase.TabStop = true;
        this.rdoPurchase.Text = "Purchase Minerals";
        this.rdoPurchase.UseVisualStyleBackColor = true;
        this.rdoPurchase.CheckedChanged += this.rdoPurchase_CheckedChanged;
        this.rdoTaxMinerals.AutoSize = true;
        this.rdoTaxMinerals.Location = new Point(sbyte.MaxValue, 3);
        this.rdoTaxMinerals.Margin = new Padding(6, 3, 3, 3);
        this.rdoTaxMinerals.Name = "rdoTaxMinerals";
        this.rdoTaxMinerals.Size = new Size(113, 17);
        this.rdoTaxMinerals.TabIndex = 32 /*0x20*/;
        this.rdoTaxMinerals.Text = "Tax Civilian Mining";
        this.rdoTaxMinerals.UseVisualStyleBackColor = true;
        this.rdoTaxMinerals.CheckedChanged += this.rdoStable_CheckedChanged;
        this.lblCivilianMinerals.AutoSize = true;
        this.lblCivilianMinerals.Location = new Point(264, 0);
        this.lblCivilianMinerals.Margin = new Padding(21, 0, 0, 0);
        this.lblCivilianMinerals.Name = "lblCivilianMinerals";
        this.lblCivilianMinerals.Padding = new Padding(0, 5, 5, 0);
        this.lblCivilianMinerals.Size = new Size(67, 18);
        this.lblCivilianMinerals.TabIndex = 83;
        this.lblCivilianMinerals.Text = "Percentage";
        this.txtCivilianMinerals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtCivilianMinerals.BorderStyle = BorderStyle.None;
        this.txtCivilianMinerals.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtCivilianMinerals.Location = new Point(331, 5);
        this.txtCivilianMinerals.Margin = new Padding(0, 5, 3, 3);
        this.txtCivilianMinerals.Name = "txtCivilianMinerals";
        this.txtCivilianMinerals.Size = new Size(55, 13);
        this.txtCivilianMinerals.TabIndex = 33;
        this.txtCivilianMinerals.Text = "100";
        this.txtCivilianMinerals.TextAlign = HorizontalAlignment.Center;
        this.chkReserve.AutoSize = true;
        this.chkReserve.Checked = true;
        this.chkReserve.CheckState = CheckState.Checked;
        this.chkReserve.Location = new Point(11, 811);
        this.chkReserve.Name = "chkReserve";
        this.chkReserve.Size = new Size(191, 17);
        this.chkReserve.TabIndex = 35;
        this.chkReserve.Text = "Double-click Sets Reserve Amount";
        this.chkReserve.TextAlign = ContentAlignment.MiddleRight;
        this.chkReserve.UseVisualStyleBackColor = true;
        this.lstvUsage.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvUsage.BorderStyle = BorderStyle.FixedSingle;
        this.lstvUsage.Columns.AddRange(new ColumnHeader[11]
        {
            this.columnHeader_41,
            this.columnHeader_42,
            this.columnHeader_43,
            this.columnHeader_44,
            this.columnHeader_45,
            this.columnHeader_46,
            this.columnHeader_47,
            this.columnHeader_48,
            this.columnHeader_49,
            this.columnHeader_50,
            this.columnHeader_51
        });
        this.lstvUsage.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvUsage.FullRowSelect = true;
        this.lstvUsage.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvUsage.HideSelection = false;
        this.lstvUsage.LabelWrap = false;
        this.lstvUsage.Location = new Point(4, 282);
        this.lstvUsage.Margin = new Padding(4, 3, 3, 3);
        this.lstvUsage.Name = "lstvUsage";
        this.lstvUsage.Size = new Size(1023 /*0x03FF*/, 244);
        this.lstvUsage.TabIndex = 75;
        this.lstvUsage.UseCompatibleStateImageBehavior = false;
        this.lstvUsage.View = View.Details;
        this.columnHeader_41.Width = 80 /*0x50*/;
        this.columnHeader_42.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_42.Width = 100;
        this.columnHeader_43.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_43.Width = 80 /*0x50*/;
        this.columnHeader_44.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_44.Width = 80 /*0x50*/;
        this.columnHeader_45.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_45.Width = 80 /*0x50*/;
        this.columnHeader_46.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_46.Width = 100;
        this.columnHeader_47.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_47.Width = 80 /*0x50*/;
        this.columnHeader_48.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_48.Width = 80 /*0x50*/;
        this.columnHeader_49.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_49.Width = 100;
        this.columnHeader_50.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_50.Width = 100;
        this.columnHeader_51.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_51.Width = 80 /*0x50*/;
        this.lstvMines.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvMines.BorderStyle = BorderStyle.FixedSingle;
        this.lstvMines.Columns.AddRange(new ColumnHeader[13]
        {
            this.columnHeader_28,
            this.columnHeader_29,
            this.columnHeader_30,
            this.columnHeader_31,
            this.columnHeader_32,
            this.columnHeader_33,
            this.columnHeader_34,
            this.columnHeader_35,
            this.columnHeader_36,
            this.columnHeader_37,
            this.columnHeader_38,
            this.columnHeader_39,
            this.columnHeader_40
        });
        this.lstvMines.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvMines.FullRowSelect = true;
        this.lstvMines.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvMines.HideSelection = false;
        this.lstvMines.LabelWrap = false;
        this.lstvMines.Location = new Point(4, 532);
        this.lstvMines.Margin = new Padding(4, 3, 3, 3);
        this.lstvMines.Name = "lstvMines";
        this.lstvMines.Size = new Size(1023 /*0x03FF*/, 160 /*0xA0*/);
        this.lstvMines.TabIndex = 74;
        this.lstvMines.UseCompatibleStateImageBehavior = false;
        this.lstvMines.View = View.Details;
        this.columnHeader_28.Width = 120;
        this.columnHeader_29.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_29.Width = 75;
        this.columnHeader_30.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_30.Width = 75;
        this.columnHeader_31.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_31.Width = 75;
        this.columnHeader_32.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_32.Width = 75;
        this.columnHeader_33.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_33.Width = 75;
        this.columnHeader_34.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_34.Width = 75;
        this.columnHeader_35.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_35.Width = 75;
        this.columnHeader_36.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_36.Width = 75;
        this.columnHeader_37.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_37.Width = 75;
        this.columnHeader_38.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_38.Width = 75;
        this.columnHeader_39.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_39.Width = 75;
        this.columnHeader_40.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_40.Width = 75;
        this.lstvMining.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvMining.BorderStyle = BorderStyle.FixedSingle;
        this.lstvMining.Columns.AddRange(new ColumnHeader[11]
        {
            this.columnHeader_17,
            this.columnHeader_18,
            this.columnHeader_19,
            this.columnHeader_20,
            this.columnHeader_21,
            this.columnHeader_22,
            this.columnHeader_23,
            this.columnHeader_24,
            this.columnHeader_25,
            this.columnHeader_26,
            this.columnHeader_27
        });
        this.lstvMining.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvMining.FullRowSelect = true;
        this.lstvMining.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvMining.HideSelection = false;
        this.lstvMining.LabelWrap = false;
        this.lstvMining.Location = new Point(4, 8);
        this.lstvMining.Margin = new Padding(4, 3, 3, 3);
        this.lstvMining.Name = "lstvMining";
        this.lstvMining.Size = new Size(1023 /*0x03FF*/, 268);
        this.lstvMining.TabIndex = 72;
        this.lstvMining.UseCompatibleStateImageBehavior = false;
        this.lstvMining.View = View.Details;
        this.lstvMining.DoubleClick += this.lstvMining_DoubleClick;
        this.columnHeader_17.Width = 80 /*0x50*/;
        this.columnHeader_18.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_18.Width = 100;
        this.columnHeader_19.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_19.Width = 80 /*0x50*/;
        this.columnHeader_20.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_20.Width = 80 /*0x50*/;
        this.columnHeader_21.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_21.Width = 80 /*0x50*/;
        this.columnHeader_22.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_22.Width = 100;
        this.columnHeader_23.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_23.Width = 80 /*0x50*/;
        this.columnHeader_24.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_24.Width = 80 /*0x50*/;
        this.columnHeader_25.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_25.Width = 100;
        this.columnHeader_26.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_26.Width = 100;
        this.columnHeader_27.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_27.Width = 80 /*0x50*/;
        this.tabShipyards.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabShipyards.Controls.Add(this.lstvRefitDetails);
        this.tabShipyards.Controls.Add(this.lstvSYMinerals);
        this.tabShipyards.Controls.Add(this.panel3);
        this.tabShipyards.Controls.Add(this.panel1);
        this.tabShipyards.Controls.Add(this.lstvShipyards);
        this.tabShipyards.Location = new Point(4, 22);
        this.tabShipyards.Name = "tabShipyards";
        this.tabShipyards.Padding = new Padding(3);
        this.tabShipyards.Size = new Size(1030, 836);
        this.tabShipyards.TabIndex = 3;
        this.tabShipyards.Text = "Shipyards";
        this.lstvRefitDetails.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvRefitDetails.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_65,
            this.columnHeader_66,
            this.columnHeader_67
        });
        this.lstvRefitDetails.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvRefitDetails.FullRowSelect = true;
        this.lstvRefitDetails.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvRefitDetails.HideSelection = false;
        this.lstvRefitDetails.Location = new Point(4, 8);
        this.lstvRefitDetails.Name = "lstvRefitDetails";
        this.lstvRefitDetails.Size = new Size(1023 /*0x03FF*/, 605);
        this.lstvRefitDetails.TabIndex = 105;
        this.lstvRefitDetails.UseCompatibleStateImageBehavior = false;
        this.lstvRefitDetails.View = View.Details;
        this.lstvRefitDetails.Visible = false;
        this.lstvRefitDetails.SelectedIndexChanged += this.lstvRefitDetails_SelectedIndexChanged;
        this.columnHeader_65.Text = "";
        this.columnHeader_65.Width = 400;
        this.columnHeader_66.Text = "";
        this.columnHeader_66.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_67.Text = "";
        this.columnHeader_67.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_67.Width = 80 /*0x50*/;
        this.lstvSYMinerals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvSYMinerals.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_62,
            this.columnHeader_63,
            this.columnHeader_64
        });
        this.lstvSYMinerals.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvSYMinerals.FullRowSelect = true;
        this.lstvSYMinerals.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvSYMinerals.HideSelection = false;
        this.lstvSYMinerals.Location = new Point(838, 619);
        this.lstvSYMinerals.Name = "lstvSYMinerals";
        this.lstvSYMinerals.Size = new Size(189, 214);
        this.lstvSYMinerals.TabIndex = 104;
        this.lstvSYMinerals.UseCompatibleStateImageBehavior = false;
        this.lstvSYMinerals.View = View.Details;
        this.columnHeader_62.Text = "";
        this.columnHeader_62.Width = 70;
        this.columnHeader_63.Text = "";
        this.columnHeader_63.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_63.Width = 55;
        this.columnHeader_64.Text = "";
        this.columnHeader_64.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_64.Width = 55;
        this.panel3.BorderStyle = BorderStyle.FixedSingle;
        this.panel3.Controls.Add(this.chkAdminCommand);
        this.panel3.Controls.Add(this.lblAdminCommand);
        this.panel3.Controls.Add(this.cboAdminCommand);
        this.panel3.Controls.Add(this.label44);
        this.panel3.Controls.Add(this.cboParasites);
        this.panel3.Controls.Add(this.chkUseComponents);
        this.panel3.Controls.Add(this.txtShipName);
        this.panel3.Controls.Add(this.lblBuildCost);
        this.panel3.Controls.Add(this.label16);
        this.panel3.Controls.Add(this.lblShipyardConstructionDate);
        this.panel3.Controls.Add(this.label14);
        this.panel3.Controls.Add(this.cmdRefitDetails);
        this.panel3.Controls.Add(this.cmdSelectName);
        this.panel3.Controls.Add(this.lblFleet);
        this.panel3.Controls.Add(this.cboFleet);
        this.panel3.Controls.Add(this.label11);
        this.panel3.Controls.Add(this.cboShip);
        this.panel3.Controls.Add(this.lblEligible);
        this.panel3.Controls.Add(this.cboEligible);
        this.panel3.Controls.Add(this.lblRefitFrom);
        this.panel3.Controls.Add(this.cboRefitFrom);
        this.panel3.Controls.Add(this.lblTaskType);
        this.panel3.Controls.Add(this.cboShipyardTaskType);
        this.panel3.Controls.Add(this.cmdDefaultFleet);
        this.panel3.Controls.Add(this.cmdAddShipyardTask);
        this.panel3.Location = new Point(2, 700);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(830, 133);
        this.panel3.TabIndex = 81;
        this.chkAdminCommand.AutoSize = true;
        this.chkAdminCommand.Location = new Point(398, 22);
        this.chkAdminCommand.Name = "chkAdminCommand";
        this.chkAdminCommand.Padding = new Padding(5, 0, 0, 0);
        this.chkAdminCommand.Size = new Size(82, 17);
        this.chkAdminCommand.TabIndex = 107;
        this.chkAdminCommand.Text = "Use Admin";
        this.chkAdminCommand.TextAlign = ContentAlignment.MiddleRight;
        this.chkAdminCommand.UseVisualStyleBackColor = true;
        this.chkAdminCommand.CheckedChanged += this.chkAdminCommand_CheckedChanged;
        this.lblAdminCommand.AutoSize = true;
        this.lblAdminCommand.Location = new Point(3, 54);
        this.lblAdminCommand.Name = "lblAdminCommand";
        this.lblAdminCommand.Padding = new Padding(0, 5, 5, 0);
        this.lblAdminCommand.Size = new Size(57, 18);
        this.lblAdminCommand.TabIndex = 106;
        this.lblAdminCommand.Text = "Adm Cmd";
        this.cboAdminCommand.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboAdminCommand.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboAdminCommand.FormattingEnabled = true;
        this.cboAdminCommand.Location = new Point(72, 55);
        this.cboAdminCommand.Margin = new Padding(3, 3, 3, 0);
        this.cboAdminCommand.Name = "cboAdminCommand";
        this.cboAdminCommand.Size = new Size(192 /*0xC0*/, 21);
        this.cboAdminCommand.TabIndex = 105;
        this.cboAdminCommand.Visible = false;
        this.cboAdminCommand.SelectedIndexChanged += this.cboAdminCommand_SelectedIndexChanged;
        this.label44.AutoSize = true;
        this.label44.Location = new Point(554, 95);
        this.label44.Name = "label44";
        this.label44.Padding = new Padding(0, 5, 5, 0);
        this.label44.Size = new Size(55, 18);
        this.label44.TabIndex = 104;
        this.label44.Text = "Parasites";
        this.cboParasites.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboParasites.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboParasites.FormattingEnabled = true;
        this.cboParasites.Location = new Point(623, 95);
        this.cboParasites.Margin = new Padding(3, 3, 3, 0);
        this.cboParasites.Name = "cboParasites";
        this.cboParasites.Size = new Size(192 /*0xC0*/, 21);
        this.cboParasites.TabIndex = 103;
        this.cboParasites.SelectedIndexChanged += this.cboParasites_SelectedIndexChanged;
        this.chkUseComponents.AutoSize = true;
        this.chkUseComponents.Location = new Point(279, 22);
        this.chkUseComponents.Name = "chkUseComponents";
        this.chkUseComponents.Padding = new Padding(5, 0, 0, 0);
        this.chkUseComponents.Size = new Size(112 /*0x70*/, 17);
        this.chkUseComponents.TabIndex = 49;
        this.chkUseComponents.Text = "Use Components";
        this.chkUseComponents.TextAlign = ContentAlignment.MiddleRight;
        this.chkUseComponents.UseVisualStyleBackColor = true;
        this.txtShipName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtShipName.BorderStyle = BorderStyle.None;
        this.txtShipName.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtShipName.Location = new Point(623, 58);
        this.txtShipName.Name = "txtShipName";
        this.txtShipName.Size = new Size(192 /*0xC0*/, 13);
        this.txtShipName.TabIndex = 52;
        this.txtShipName.Text = "New Ship Name";
        this.txtShipName.TextAlign = HorizontalAlignment.Center;
        this.txtShipName.TextChanged += this.txtShipName_TextChanged;
        this.lblBuildCost.AutoSize = true;
        this.lblBuildCost.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblBuildCost.Location = new Point(554, 18);
        this.lblBuildCost.Name = "lblBuildCost";
        this.lblBuildCost.Padding = new Padding(0, 5, 5, 0);
        this.lblBuildCost.Size = new Size(18, 18);
        this.lblBuildCost.TabIndex = 102;
        this.lblBuildCost.Text = "0";
        this.lblBuildCost.TextAlign = ContentAlignment.MiddleCenter;
        this.label16.AutoSize = true;
        this.label16.Location = new Point(494, 18);
        this.label16.Name = "label16";
        this.label16.Padding = new Padding(0, 5, 5, 0);
        this.label16.Size = new Size(59, 18);
        this.label16.TabIndex = 101;
        this.label16.Text = "Build Cost";
        this.lblShipyardConstructionDate.AutoSize = true;
        this.lblShipyardConstructionDate.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblShipyardConstructionDate.Location = new Point(699, 18);
        this.lblShipyardConstructionDate.Name = "lblShipyardConstructionDate";
        this.lblShipyardConstructionDate.Padding = new Padding(0, 5, 5, 0);
        this.lblShipyardConstructionDate.Size = new Size(113, 18);
        this.lblShipyardConstructionDate.TabIndex = 100;
        this.lblShipyardConstructionDate.Text = "21st September 2544";
        this.lblShipyardConstructionDate.TextAlign = ContentAlignment.MiddleCenter;
        this.label14.AutoSize = true;
        this.label14.Location = new Point(602, 18);
        this.label14.Name = "label14";
        this.label14.Padding = new Padding(0, 5, 5, 0);
        this.label14.Size = new Size(90, 18);
        this.label14.TabIndex = 99;
        this.label14.Text = "Completion Date";
        this.cmdRefitDetails.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRefitDetails.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRefitDetails.Location = new Point(294, 95);
        this.cmdRefitDetails.Margin = new Padding(0);
        this.cmdRefitDetails.Name = "cmdRefitDetails";
        this.cmdRefitDetails.Size = new Size(96 /*0x60*/, 30);
        this.cmdRefitDetails.TabIndex = 57;
        this.cmdRefitDetails.Tag = "1200";
        this.cmdRefitDetails.Text = "Refit Details";
        this.cmdRefitDetails.UseVisualStyleBackColor = false;
        this.cmdRefitDetails.Click += this.cmdRefitDetails_Click;
        this.cmdSelectName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSelectName.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSelectName.Location = new Point(198, 95);
        this.cmdSelectName.Margin = new Padding(0);
        this.cmdSelectName.Name = "cmdSelectName";
        this.cmdSelectName.Size = new Size(96 /*0x60*/, 30);
        this.cmdSelectName.TabIndex = 56;
        this.cmdSelectName.Tag = "1200";
        this.cmdSelectName.Text = "Select Name";
        this.cmdSelectName.UseVisualStyleBackColor = false;
        this.cmdSelectName.Click += this.cmdSelectName_Click;
        this.lblFleet.AutoSize = true;
        this.lblFleet.Location = new Point(3, 54);
        this.lblFleet.Name = "lblFleet";
        this.lblFleet.Padding = new Padding(0, 5, 5, 0);
        this.lblFleet.Size = new Size(35, 18);
        this.lblFleet.TabIndex = 95;
        this.lblFleet.Text = "Fleet";
        this.cboFleet.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboFleet.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboFleet.FormattingEnabled = true;
        this.cboFleet.Location = new Point(72, 55);
        this.cboFleet.Margin = new Padding(3, 3, 3, 0);
        this.cboFleet.Name = "cboFleet";
        this.cboFleet.Size = new Size(192 /*0xC0*/, 21);
        this.cboFleet.TabIndex = 50;
        this.cboFleet.SelectedIndexChanged += this.cboFleet_SelectedIndexChanged;
        this.label11.AutoSize = true;
        this.label11.Location = new Point(553, 54);
        this.label11.Name = "label11";
        this.label11.Padding = new Padding(0, 5, 5, 0);
        this.label11.Size = new Size(64 /*0x40*/, 18);
        this.label11.TabIndex = 93;
        this.label11.Text = "Ship Name";
        this.cboShip.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboShip.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboShip.FormattingEnabled = true;
        this.cboShip.Location = new Point(623, 54);
        this.cboShip.Margin = new Padding(3, 3, 3, 0);
        this.cboShip.Name = "cboShip";
        this.cboShip.Size = new Size(192 /*0xC0*/, 21);
        this.cboShip.TabIndex = 53;
        this.cboShip.Visible = false;
        this.cboShip.SelectedIndexChanged += this.cboShip_SelectedIndexChanged;
        this.lblEligible.AutoSize = true;
        this.lblEligible.Location = new Point(286, 54);
        this.lblEligible.Name = "lblEligible";
        this.lblEligible.Padding = new Padding(0, 5, 5, 0);
        this.lblEligible.Size = new Size(37, 18);
        this.lblEligible.TabIndex = 91;
        this.lblEligible.Text = "Class";
        this.cboEligible.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboEligible.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboEligible.FormattingEnabled = true;
        this.cboEligible.Location = new Point(329, 54);
        this.cboEligible.Margin = new Padding(3, 3, 3, 0);
        this.cboEligible.Name = "cboEligible";
        this.cboEligible.Size = new Size(192 /*0xC0*/, 21);
        this.cboEligible.TabIndex = 51;
        this.cboEligible.SelectedIndexChanged += this.cboEligible_SelectedIndexChanged;
        this.lblRefitFrom.AutoSize = true;
        this.lblRefitFrom.Location = new Point(3, 54);
        this.lblRefitFrom.Name = "lblRefitFrom";
        this.lblRefitFrom.Padding = new Padding(0, 5, 5, 0);
        this.lblRefitFrom.Size = new Size(60, 18);
        this.lblRefitFrom.TabIndex = 89;
        this.lblRefitFrom.Text = "Refit From";
        this.cboRefitFrom.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRefitFrom.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboRefitFrom.FormattingEnabled = true;
        this.cboRefitFrom.Location = new Point(72, 54);
        this.cboRefitFrom.Margin = new Padding(3, 3, 3, 0);
        this.cboRefitFrom.Name = "cboRefitFrom";
        this.cboRefitFrom.Size = new Size(192 /*0xC0*/, 21);
        this.cboRefitFrom.TabIndex = 88;
        this.cboRefitFrom.Visible = false;
        this.cboRefitFrom.SelectedIndexChanged += this.cboRefitFrom_SelectedIndexChanged;
        this.lblTaskType.AutoSize = true;
        this.lblTaskType.Location = new Point(3, 18);
        this.lblTaskType.Name = "lblTaskType";
        this.lblTaskType.Padding = new Padding(0, 5, 5, 0);
        this.lblTaskType.Size = new Size(63 /*0x3F*/, 18);
        this.lblTaskType.TabIndex = 87;
        this.lblTaskType.Text = "Task Type";
        this.cboShipyardTaskType.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboShipyardTaskType.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboShipyardTaskType.FormattingEnabled = true;
        this.cboShipyardTaskType.Location = new Point(72, 18);
        this.cboShipyardTaskType.Margin = new Padding(3, 3, 3, 0);
        this.cboShipyardTaskType.Name = "cboShipyardTaskType";
        this.cboShipyardTaskType.Size = new Size(192 /*0xC0*/, 21);
        this.cboShipyardTaskType.TabIndex = 48 /*0x30*/;
        this.cboShipyardTaskType.SelectedIndexChanged += this.cboShipyardTaskType_SelectedIndexChanged;
        this.cmdDefaultFleet.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDefaultFleet.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDefaultFleet.Location = new Point(102, 95);
        this.cmdDefaultFleet.Margin = new Padding(0);
        this.cmdDefaultFleet.Name = "cmdDefaultFleet";
        this.cmdDefaultFleet.Size = new Size(96 /*0x60*/, 30);
        this.cmdDefaultFleet.TabIndex = 55;
        this.cmdDefaultFleet.Tag = "1200";
        this.cmdDefaultFleet.Text = "Default Fleet";
        this.cmdDefaultFleet.UseVisualStyleBackColor = false;
        this.cmdDefaultFleet.Click += this.cmdDefaultFleet_Click;
        this.cmdAddShipyardTask.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddShipyardTask.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdAddShipyardTask.Location = new Point(6, 95);
        this.cmdAddShipyardTask.Margin = new Padding(0);
        this.cmdAddShipyardTask.Name = "cmdAddShipyardTask";
        this.cmdAddShipyardTask.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddShipyardTask.TabIndex = 54;
        this.cmdAddShipyardTask.Tag = "1200";
        this.cmdAddShipyardTask.Text = "Create Task";
        this.cmdAddShipyardTask.UseVisualStyleBackColor = false;
        this.cmdAddShipyardTask.Click += this.cmdAddShipyardTask_Click;
        this.panel1.BorderStyle = BorderStyle.FixedSingle;
        this.panel1.Controls.Add(this.cmdAddSY);
        this.panel1.Controls.Add(this.flowLayoutPanel9);
        this.panel1.Controls.Add(this.cmdDeleteSY);
        this.panel1.Controls.Add(this.cmdAutoRename);
        this.panel1.Controls.Add(this.cmdRenameShipyard);
        this.panel1.Controls.Add(this.cmdPauseActivity);
        this.panel1.Controls.Add(this.cmdDeleteActivity);
        this.panel1.Controls.Add(this.cmdSetActivity);
        this.panel1.Location = new Point(3, 619);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(829, 75);
        this.panel1.TabIndex = 79;
        this.cmdAddSY.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddSY.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdAddSY.Location = new Point(579, 35);
        this.cmdAddSY.Margin = new Padding(0);
        this.cmdAddSY.Name = "cmdAddSY";
        this.cmdAddSY.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddSY.TabIndex = 46;
        this.cmdAddSY.Tag = "1200";
        this.cmdAddSY.Text = "SM: Add SY";
        this.cmdAddSY.UseVisualStyleBackColor = false;
        this.cmdAddSY.Click += this.cmdAddSY_Click;
        this.flowLayoutPanel9.Controls.Add(this.cboShipyardUpgrade);
        this.flowLayoutPanel9.Controls.Add(this.cboRetoolClass);
        this.flowLayoutPanel9.Controls.Add(this.lblCT);
        this.flowLayoutPanel9.Controls.Add(this.txtCT);
        this.flowLayoutPanel9.Controls.Add(this.lblSetSL);
        this.flowLayoutPanel9.Controls.Add(this.txtSetSL);
        this.flowLayoutPanel9.Controls.Add(this.label6);
        this.flowLayoutPanel9.Controls.Add(this.txtShipyardUpgradeCost);
        this.flowLayoutPanel9.Controls.Add(this.label7);
        this.flowLayoutPanel9.Controls.Add(this.txtShipyardUpgradeDate);
        this.flowLayoutPanel9.Location = new Point(0, 3);
        this.flowLayoutPanel9.Name = "flowLayoutPanel9";
        this.flowLayoutPanel9.Size = new Size(1020, 25);
        this.flowLayoutPanel9.TabIndex = 45;
        this.cboShipyardUpgrade.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboShipyardUpgrade.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboShipyardUpgrade.FormattingEnabled = true;
        this.cboShipyardUpgrade.Location = new Point(3, 3);
        this.cboShipyardUpgrade.Margin = new Padding(3, 3, 3, 0);
        this.cboShipyardUpgrade.Name = "cboShipyardUpgrade";
        this.cboShipyardUpgrade.Size = new Size(165, 21);
        this.cboShipyardUpgrade.TabIndex = 36;
        this.cboShipyardUpgrade.SelectedIndexChanged += this.cboShipyardUpgrade_SelectedIndexChanged;
        this.cboRetoolClass.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRetoolClass.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboRetoolClass.FormattingEnabled = true;
        this.cboRetoolClass.Location = new Point(174, 3);
        this.cboRetoolClass.Margin = new Padding(3, 3, 3, 0);
        this.cboRetoolClass.Name = "cboRetoolClass";
        this.cboRetoolClass.Size = new Size(165, 21);
        this.cboRetoolClass.TabIndex = 37;
        this.cboRetoolClass.Visible = false;
        this.cboRetoolClass.SelectedIndexChanged += this.cboRetoolClass_SelectedIndexChanged;
        this.lblCT.AutoSize = true;
        this.lblCT.Location = new Point(348, 3);
        this.lblCT.Margin = new Padding(6, 3, 3, 0);
        this.lblCT.Name = "lblCT";
        this.lblCT.Padding = new Padding(0, 5, 5, 0);
        this.lblCT.Size = new Size(87, 18);
        this.lblCT.TabIndex = 94;
        this.lblCT.Text = "Capacity Target";
        this.lblCT.Visible = false;
        this.txtCT.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtCT.BorderStyle = BorderStyle.None;
        this.txtCT.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtCT.Location = new Point(438, 8);
        this.txtCT.Margin = new Padding(0, 8, 3, 3);
        this.txtCT.Name = "txtCT";
        this.txtCT.Size = new Size(50, 13);
        this.txtCT.TabIndex = 28;
        this.txtCT.Text = "10000";
        this.txtCT.TextAlign = HorizontalAlignment.Center;
        this.txtCT.Visible = false;
        this.txtCT.TextChanged += this.txtCT_TextChanged;
        this.lblSetSL.AutoSize = true;
        this.lblSetSL.Location = new Point(497, 3);
        this.lblSetSL.Margin = new Padding(6, 3, 3, 0);
        this.lblSetSL.Name = "lblSetSL";
        this.lblSetSL.Padding = new Padding(0, 5, 5, 0);
        this.lblSetSL.Size = new Size(72, 18);
        this.lblSetSL.TabIndex = 96 /*0x60*/;
        this.lblSetSL.Text = "Set Slipways";
        this.lblSetSL.Visible = false;
        this.txtSetSL.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSetSL.BorderStyle = BorderStyle.None;
        this.txtSetSL.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtSetSL.Location = new Point(572, 8);
        this.txtSetSL.Margin = new Padding(0, 8, 3, 3);
        this.txtSetSL.Name = "txtSetSL";
        this.txtSetSL.Size = new Size(26, 13);
        this.txtSetSL.TabIndex = 39;
        this.txtSetSL.Text = "1";
        this.txtSetSL.TextAlign = HorizontalAlignment.Center;
        this.txtSetSL.Visible = false;
        this.label6.AutoSize = true;
        this.label6.Location = new Point(607, 3);
        this.label6.Margin = new Padding(6, 3, 3, 0);
        this.label6.Name = "label6";
        this.label6.Padding = new Padding(0, 5, 5, 0);
        this.label6.Size = new Size(59, 18);
        this.label6.TabIndex = 86;
        this.label6.Text = "Build Cost";
        this.txtShipyardUpgradeCost.AutoSize = true;
        this.txtShipyardUpgradeCost.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtShipyardUpgradeCost.Location = new Point(669, 3);
        this.txtShipyardUpgradeCost.Margin = new Padding(0, 3, 3, 0);
        this.txtShipyardUpgradeCost.Name = "txtShipyardUpgradeCost";
        this.txtShipyardUpgradeCost.Padding = new Padding(0, 5, 5, 0);
        this.txtShipyardUpgradeCost.Size = new Size(18, 18);
        this.txtShipyardUpgradeCost.TabIndex = 92;
        this.txtShipyardUpgradeCost.Text = "0";
        this.txtShipyardUpgradeCost.TextAlign = ContentAlignment.MiddleCenter;
        this.label7.AutoSize = true;
        this.label7.Location = new Point(696, 3);
        this.label7.Margin = new Padding(6, 3, 3, 0);
        this.label7.Name = "label7";
        this.label7.Padding = new Padding(0, 5, 5, 0);
        this.label7.Size = new Size(90, 18);
        this.label7.TabIndex = 88;
        this.label7.Text = "Completion Date";
        this.txtShipyardUpgradeDate.AutoSize = true;
        this.txtShipyardUpgradeDate.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtShipyardUpgradeDate.Location = new Point(789, 3);
        this.txtShipyardUpgradeDate.Margin = new Padding(0, 3, 3, 0);
        this.txtShipyardUpgradeDate.Name = "txtShipyardUpgradeDate";
        this.txtShipyardUpgradeDate.Padding = new Padding(0, 5, 5, 0);
        this.txtShipyardUpgradeDate.Size = new Size(113, 18);
        this.txtShipyardUpgradeDate.TabIndex = 93;
        this.txtShipyardUpgradeDate.Text = "21st September 2544";
        this.txtShipyardUpgradeDate.TextAlign = ContentAlignment.MiddleCenter;
        this.cmdDeleteSY.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteSY.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDeleteSY.Location = new Point(483, 35);
        this.cmdDeleteSY.Margin = new Padding(0);
        this.cmdDeleteSY.Name = "cmdDeleteSY";
        this.cmdDeleteSY.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteSY.TabIndex = 45;
        this.cmdDeleteSY.Tag = "1200";
        this.cmdDeleteSY.Text = "Delete Shipyard";
        this.cmdDeleteSY.UseVisualStyleBackColor = false;
        this.cmdDeleteSY.Click += this.cmdDeleteSY_Click;
        this.cmdAutoRename.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAutoRename.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdAutoRename.Location = new Point(387, 35);
        this.cmdAutoRename.Margin = new Padding(0);
        this.cmdAutoRename.Name = "cmdAutoRename";
        this.cmdAutoRename.Size = new Size(96 /*0x60*/, 30);
        this.cmdAutoRename.TabIndex = 44;
        this.cmdAutoRename.Tag = "1200";
        this.cmdAutoRename.Text = "Auto Rename";
        this.cmdAutoRename.UseVisualStyleBackColor = false;
        this.cmdAutoRename.Click += this.cmdAutoRename_Click;
        this.cmdRenameShipyard.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameShipyard.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRenameShipyard.Location = new Point(291, 35);
        this.cmdRenameShipyard.Margin = new Padding(0);
        this.cmdRenameShipyard.Name = "cmdRenameShipyard";
        this.cmdRenameShipyard.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameShipyard.TabIndex = 43;
        this.cmdRenameShipyard.Tag = "1200";
        this.cmdRenameShipyard.Text = "Rename SY";
        this.cmdRenameShipyard.UseVisualStyleBackColor = false;
        this.cmdRenameShipyard.Click += this.cmdRenameShipyard_Click;
        this.cmdPauseActivity.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdPauseActivity.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdPauseActivity.Location = new Point(195, 35);
        this.cmdPauseActivity.Margin = new Padding(0);
        this.cmdPauseActivity.Name = "cmdPauseActivity";
        this.cmdPauseActivity.Size = new Size(96 /*0x60*/, 30);
        this.cmdPauseActivity.TabIndex = 42;
        this.cmdPauseActivity.Tag = "1200";
        this.cmdPauseActivity.Text = "Pause Activity";
        this.cmdPauseActivity.UseVisualStyleBackColor = false;
        this.cmdPauseActivity.Click += this.cmdPauseActivity_Click;
        this.cmdDeleteActivity.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteActivity.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDeleteActivity.Location = new Point(99, 35);
        this.cmdDeleteActivity.Margin = new Padding(0);
        this.cmdDeleteActivity.Name = "cmdDeleteActivity";
        this.cmdDeleteActivity.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteActivity.TabIndex = 41;
        this.cmdDeleteActivity.Tag = "1200";
        this.cmdDeleteActivity.Text = "Delete Activity";
        this.cmdDeleteActivity.UseVisualStyleBackColor = false;
        this.cmdDeleteActivity.Click += this.cmdDeleteActivity_Click;
        this.cmdSetActivity.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSetActivity.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSetActivity.Location = new Point(3, 35);
        this.cmdSetActivity.Margin = new Padding(0);
        this.cmdSetActivity.Name = "cmdSetActivity";
        this.cmdSetActivity.Size = new Size(96 /*0x60*/, 30);
        this.cmdSetActivity.TabIndex = 40;
        this.cmdSetActivity.Tag = "1200";
        this.cmdSetActivity.Text = "Set Activity";
        this.cmdSetActivity.UseVisualStyleBackColor = false;
        this.cmdSetActivity.Click += this.cmdSetActivity_Click;
        this.lstvShipyards.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvShipyards.BorderStyle = BorderStyle.FixedSingle;
        this.lstvShipyards.Columns.AddRange(new ColumnHeader[10]
        {
            this.columnHeader_52,
            this.columnHeader_53,
            this.columnHeader_54,
            this.columnHeader_55,
            this.columnHeader_56,
            this.columnHeader_57,
            this.columnHeader_58,
            this.columnHeader_59,
            this.columnHeader_60,
            this.columnHeader_61
        });
        this.lstvShipyards.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvShipyards.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvShipyards.HideSelection = false;
        this.lstvShipyards.LabelWrap = false;
        this.lstvShipyards.Location = new Point(4, 8);
        this.lstvShipyards.Margin = new Padding(4, 3, 3, 3);
        this.lstvShipyards.MultiSelect = false;
        this.lstvShipyards.Name = "lstvShipyards";
        this.lstvShipyards.Size = new Size(1023 /*0x03FF*/, 605);
        this.lstvShipyards.TabIndex = 73;
        this.lstvShipyards.UseCompatibleStateImageBehavior = false;
        this.lstvShipyards.View = View.Details;
        this.lstvShipyards.SelectedIndexChanged += this.lstvShipyards_SelectedIndexChanged;
        this.columnHeader_52.Width = 225;
        this.columnHeader_53.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_53.Width = 40;
        this.columnHeader_54.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_54.Width = 80 /*0x50*/;
        this.columnHeader_55.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_55.Width = 50;
        this.columnHeader_56.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_56.Width = 50;
        this.columnHeader_57.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_57.Width = 160 /*0xA0*/;
        this.columnHeader_58.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_58.Width = 160 /*0xA0*/;
        this.columnHeader_59.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_60.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_60.Width = 120;
        this.columnHeader_61.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_61.Width = 70;
        this.tabSYTasks.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabSYTasks.Controls.Add(this.flowLayoutPanel18);
        this.tabSYTasks.Controls.Add(this.cmdSelectNameTaskShip);
        this.tabSYTasks.Controls.Add(this.cmdRenameTaskShip);
        this.tabSYTasks.Controls.Add(this.cmdPauseTask);
        this.tabSYTasks.Controls.Add(this.cmdDeleteTask);
        this.tabSYTasks.Controls.Add(this.lstvShipyardTasks);
        this.tabSYTasks.Location = new Point(4, 22);
        this.tabSYTasks.Name = "tabSYTasks";
        this.tabSYTasks.Padding = new Padding(3);
        this.tabSYTasks.Size = new Size(1030, 836);
        this.tabSYTasks.TabIndex = 4;
        this.tabSYTasks.Text = "SY Tasks";
        this.flowLayoutPanel18.Controls.Add(this.rdoTaskSize);
        this.flowLayoutPanel18.Controls.Add(this.rdoTaskDate);
        this.flowLayoutPanel18.Location = new Point(843, 805);
        this.flowLayoutPanel18.Name = "flowLayoutPanel18";
        this.flowLayoutPanel18.Size = new Size(184, 28);
        this.flowLayoutPanel18.TabIndex = 145;
        this.rdoTaskSize.AutoSize = true;
        this.rdoTaskSize.Checked = true;
        this.rdoTaskSize.Location = new Point(3, 3);
        this.rdoTaskSize.Name = "rdoTaskSize";
        this.rdoTaskSize.Size = new Size(81, 17);
        this.rdoTaskSize.TabIndex = 69;
        this.rdoTaskSize.TabStop = true;
        this.rdoTaskSize.Text = "Sort by Size";
        this.rdoTaskSize.UseVisualStyleBackColor = true;
        this.rdoTaskSize.CheckedChanged += this.rdoTaskDate_CheckedChanged;
        this.rdoTaskDate.AutoSize = true;
        this.rdoTaskDate.Location = new Point(90, 3);
        this.rdoTaskDate.Name = "rdoTaskDate";
        this.rdoTaskDate.Size = new Size(84, 17);
        this.rdoTaskDate.TabIndex = 70;
        this.rdoTaskDate.Text = "Sort by Date";
        this.rdoTaskDate.UseVisualStyleBackColor = true;
        this.rdoTaskDate.CheckedChanged += this.rdoTaskDate_CheckedChanged;
        this.cmdSelectNameTaskShip.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSelectNameTaskShip.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSelectNameTaskShip.Location = new Point(291, 802);
        this.cmdSelectNameTaskShip.Margin = new Padding(0);
        this.cmdSelectNameTaskShip.Name = "cmdSelectNameTaskShip";
        this.cmdSelectNameTaskShip.Size = new Size(96 /*0x60*/, 30);
        this.cmdSelectNameTaskShip.TabIndex = 61;
        this.cmdSelectNameTaskShip.Tag = "1200";
        this.cmdSelectNameTaskShip.Text = "Select Name";
        this.cmdSelectNameTaskShip.UseVisualStyleBackColor = false;
        this.cmdSelectNameTaskShip.Click += this.cmdSelectNameTaskShip_Click;
        this.cmdRenameTaskShip.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameTaskShip.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRenameTaskShip.Location = new Point(195, 802);
        this.cmdRenameTaskShip.Margin = new Padding(0);
        this.cmdRenameTaskShip.Name = "cmdRenameTaskShip";
        this.cmdRenameTaskShip.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameTaskShip.TabIndex = 60;
        this.cmdRenameTaskShip.Tag = "1200";
        this.cmdRenameTaskShip.Text = "Rename Ship";
        this.cmdRenameTaskShip.UseVisualStyleBackColor = false;
        this.cmdRenameTaskShip.Click += this.cmdRenameTaskShip_Click;
        this.cmdPauseTask.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdPauseTask.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdPauseTask.Location = new Point(99, 802);
        this.cmdPauseTask.Margin = new Padding(0);
        this.cmdPauseTask.Name = "cmdPauseTask";
        this.cmdPauseTask.Size = new Size(96 /*0x60*/, 30);
        this.cmdPauseTask.TabIndex = 59;
        this.cmdPauseTask.Tag = "1200";
        this.cmdPauseTask.Text = "Pause Task";
        this.cmdPauseTask.UseVisualStyleBackColor = false;
        this.cmdPauseTask.Click += this.cmdPauseTask_Click;
        this.cmdDeleteTask.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteTask.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDeleteTask.Location = new Point(3, 803);
        this.cmdDeleteTask.Margin = new Padding(0);
        this.cmdDeleteTask.Name = "cmdDeleteTask";
        this.cmdDeleteTask.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteTask.TabIndex = 58;
        this.cmdDeleteTask.Tag = "1200";
        this.cmdDeleteTask.Text = "Delete Task";
        this.cmdDeleteTask.UseVisualStyleBackColor = false;
        this.cmdDeleteTask.Click += this.cmdDeleteTask_Click;
        this.lstvShipyardTasks.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvShipyardTasks.Columns.AddRange(new ColumnHeader[7]
        {
            this.columnHeader_68,
            this.columnHeader_69,
            this.columnHeader_70,
            this.columnHeader_72,
            this.columnHeader_73,
            this.columnHeader_71,
            this.columnHeader_74
        });
        this.lstvShipyardTasks.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvShipyardTasks.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvShipyardTasks.HideSelection = false;
        this.lstvShipyardTasks.Location = new Point(3, 6);
        this.lstvShipyardTasks.Name = "lstvShipyardTasks";
        this.lstvShipyardTasks.Size = new Size(1024 /*0x0400*/, 793);
        this.lstvShipyardTasks.TabIndex = 106;
        this.lstvShipyardTasks.UseCompatibleStateImageBehavior = false;
        this.lstvShipyardTasks.View = View.Details;
        this.lstvShipyardTasks.SelectedIndexChanged += this.lstvShipyardTasks_SelectedIndexChanged;
        this.columnHeader_68.Text = "";
        this.columnHeader_68.Width = 200;
        this.columnHeader_69.Text = "";
        this.columnHeader_69.Width = 200;
        this.columnHeader_70.Text = "";
        this.columnHeader_70.Width = 150;
        this.columnHeader_72.Width = 150;
        this.columnHeader_73.Width = 120;
        this.columnHeader_71.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_71.Width = 80 /*0x50*/;
        this.columnHeader_74.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_74.Width = 80 /*0x50*/;
        this.tabResearch.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabResearch.Controls.Add(this.flowLayoutPanel3);
        this.tabResearch.Controls.Add(this.flpRPSort);
        this.tabResearch.Controls.Add(this.flowLayoutPanel5);
        this.tabResearch.Controls.Add(this.flowLayoutPanel4);
        this.tabResearch.Controls.Add(this.flpCreateProjectsBar);
        this.tabResearch.Controls.Add(this.flowLayoutPanel2);
        this.tabResearch.Controls.Add(this.txtTechDescription);
        this.tabResearch.Controls.Add(this.flowLayoutPanel20);
        this.tabResearch.Controls.Add(this.chkMatchOnly);
        this.tabResearch.Controls.Add(this.lstvScientists);
        this.tabResearch.Controls.Add(this.cboResearchFields);
        this.tabResearch.Controls.Add(this.lstvTechnology);
        this.tabResearch.Controls.Add(this.lstvResearchProjects);
        this.tabResearch.Location = new Point(4, 22);
        this.tabResearch.Name = "tabResearch";
        this.tabResearch.Padding = new Padding(3);
        this.tabResearch.Size = new Size(1030, 836);
        this.tabResearch.TabIndex = 5;
        this.tabResearch.Text = "Research";
        this.tabResearch.Click += this.tabResearch_Click;
        this.flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel3.Controls.Add(this.rdoPopProjects);
        this.flowLayoutPanel3.Controls.Add(this.rdoAllProjects);
        this.flowLayoutPanel3.Location = new Point(694, 802);
        this.flowLayoutPanel3.Margin = new Padding(3, 0, 3, 3);
        this.flowLayoutPanel3.Name = "flowLayoutPanel3";
        this.flowLayoutPanel3.Size = new Size(158, 30);
        this.flowLayoutPanel3.TabIndex = 146;
        this.rdoPopProjects.AutoSize = true;
        this.rdoPopProjects.Checked = true;
        this.rdoPopProjects.Location = new Point(12, 4);
        this.rdoPopProjects.Margin = new Padding(12, 4, 3, 3);
        this.rdoPopProjects.Name = "rdoPopProjects";
        this.rdoPopProjects.Size = new Size(75, 17);
        this.rdoPopProjects.TabIndex = 75;
        this.rdoPopProjects.TabStop = true;
        this.rdoPopProjects.Text = "Population";
        this.rdoPopProjects.UseVisualStyleBackColor = true;
        this.rdoPopProjects.CheckedChanged += this.rdoAllProjects_CheckedChanged;
        this.rdoAllProjects.AutoSize = true;
        this.rdoAllProjects.Location = new Point(93, 4);
        this.rdoAllProjects.Margin = new Padding(3, 4, 3, 3);
        this.rdoAllProjects.Name = "rdoAllProjects";
        this.rdoAllProjects.Size = new Size(57, 17);
        this.rdoAllProjects.TabIndex = 76;
        this.rdoAllProjects.Text = "Empire";
        this.rdoAllProjects.UseVisualStyleBackColor = true;
        this.rdoAllProjects.CheckedChanged += this.rdoAllProjects_CheckedChanged;
        this.flpRPSort.BorderStyle = BorderStyle.FixedSingle;
        this.flpRPSort.Controls.Add(this.rdoLabs);
        this.flpRPSort.Controls.Add(this.rdoDate);
        this.flpRPSort.Location = new Point(831, 357);
        this.flpRPSort.Name = "flpRPSort";
        this.flpRPSort.Size = new Size(195, 30);
        this.flpRPSort.TabIndex = 144 /*0x90*/;
        this.rdoLabs.AutoSize = true;
        this.rdoLabs.Checked = true;
        this.rdoLabs.Location = new Point(12, 4);
        this.rdoLabs.Margin = new Padding(12, 4, 3, 3);
        this.rdoLabs.Name = "rdoLabs";
        this.rdoLabs.Size = new Size(84, 17);
        this.rdoLabs.TabIndex = 69;
        this.rdoLabs.TabStop = true;
        this.rdoLabs.Text = "Sort by Labs";
        this.rdoLabs.UseVisualStyleBackColor = true;
        this.rdoLabs.CheckedChanged += this.rdoDate_CheckedChanged;
        this.rdoDate.AutoSize = true;
        this.rdoDate.Location = new Point(102, 4);
        this.rdoDate.Margin = new Padding(3, 4, 3, 3);
        this.rdoDate.Name = "rdoDate";
        this.rdoDate.Size = new Size(84, 17);
        this.rdoDate.TabIndex = 70;
        this.rdoDate.Text = "Sort by Date";
        this.rdoDate.UseVisualStyleBackColor = true;
        this.rdoDate.CheckedChanged += this.rdoDate_CheckedChanged;
        this.flowLayoutPanel5.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel5.Controls.Add(this.optProjectSelectAvail);
        this.flowLayoutPanel5.Controls.Add(this.optProjectSelectCompleted);
        this.flowLayoutPanel5.Location = new Point(859, 754);
        this.flowLayoutPanel5.Name = "flowLayoutPanel5";
        this.flowLayoutPanel5.Size = new Size(168, 43);
        this.flowLayoutPanel5.TabIndex = 143;
        this.optProjectSelectAvail.AutoSize = true;
        this.optProjectSelectAvail.Checked = true;
        this.optProjectSelectAvail.Location = new Point(12, 12);
        this.optProjectSelectAvail.Margin = new Padding(12, 12, 3, 3);
        this.optProjectSelectAvail.Name = "optProjectSelectAvail";
        this.optProjectSelectAvail.Size = new Size(68, 17);
        this.optProjectSelectAvail.TabIndex = 75;
        this.optProjectSelectAvail.TabStop = true;
        this.optProjectSelectAvail.Text = "Available";
        this.optProjectSelectAvail.UseVisualStyleBackColor = true;
        this.optProjectSelectAvail.CheckedChanged += this.optProjectSelectAvail_CheckedChanged;
        this.optProjectSelectCompleted.AutoSize = true;
        this.optProjectSelectCompleted.Location = new Point(86, 12);
        this.optProjectSelectCompleted.Margin = new Padding(3, 12, 3, 3);
        this.optProjectSelectCompleted.Name = "optProjectSelectCompleted";
        this.optProjectSelectCompleted.Size = new Size(75, 17);
        this.optProjectSelectCompleted.TabIndex = 76;
        this.optProjectSelectCompleted.Text = "Completed";
        this.optProjectSelectCompleted.UseVisualStyleBackColor = true;
        this.optProjectSelectCompleted.CheckedChanged += this.optProjectSelectCompleted_CheckedChanged;
        this.flowLayoutPanel4.Controls.Add(this.label18);
        this.flowLayoutPanel4.Controls.Add(this.txtAssignFacilities);
        this.flowLayoutPanel4.Controls.Add(this.label15);
        this.flowLayoutPanel4.Controls.Add(this.lblRFAvailable);
        this.flowLayoutPanel4.Controls.Add(this.lblInstant);
        this.flowLayoutPanel4.Controls.Add(this.lblStartingTechPoints);
        this.flowLayoutPanel4.Location = new Point(483, 400);
        this.flowLayoutPanel4.Name = "flowLayoutPanel4";
        this.flowLayoutPanel4.Size = new Size(536, 17);
        this.flowLayoutPanel4.TabIndex = 142;
        this.label18.AutoSize = true;
        this.label18.Location = new Point(0, 0);
        this.label18.Margin = new Padding(0);
        this.label18.Name = "label18";
        this.label18.Size = new Size(130, 13);
        this.label18.TabIndex = 126;
        this.label18.Text = "Assign Research Facilities";
        this.label18.TextAlign = ContentAlignment.MiddleLeft;
        this.txtAssignFacilities.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAssignFacilities.BorderStyle = BorderStyle.None;
        this.txtAssignFacilities.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtAssignFacilities.Location = new Point(130, 0);
        this.txtAssignFacilities.Margin = new Padding(0, 0, 6, 3);
        this.txtAssignFacilities.Name = "txtAssignFacilities";
        this.txtAssignFacilities.Size = new Size(32 /*0x20*/, 13);
        this.txtAssignFacilities.TabIndex = 73;
        this.txtAssignFacilities.Text = "25";
        this.txtAssignFacilities.TextAlign = HorizontalAlignment.Center;
        this.txtAssignFacilities.Leave += this.txtAssignFacilities_Leave;
        this.label15.AutoSize = true;
        this.label15.Location = new Point(171, 0);
        this.label15.Name = "label15";
        this.label15.Size = new Size(142, 13);
        this.label15.TabIndex = 124;
        this.label15.Text = "Research Facilities Available";
        this.lblRFAvailable.AutoSize = true;
        this.lblRFAvailable.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblRFAvailable.Location = new Point(316, 0);
        this.lblRFAvailable.Margin = new Padding(0);
        this.lblRFAvailable.Name = "lblRFAvailable";
        this.lblRFAvailable.Size = new Size(25, 13);
        this.lblRFAvailable.TabIndex = 74;
        this.lblRFAvailable.Text = "100";
        this.lblRFAvailable.TextAlign = ContentAlignment.MiddleLeft;
        this.lblInstant.AutoSize = true;
        this.lblInstant.Location = new Point(356, 0);
        this.lblInstant.Margin = new Padding(15, 0, 3, 0);
        this.lblInstant.Name = "lblInstant";
        this.lblInstant.Size = new Size(120, 13);
        this.lblInstant.TabIndex = 140;
        this.lblInstant.Text = "Instant Research Points";
        this.lblInstant.Visible = false;
        this.lblStartingTechPoints.AutoSize = true;
        this.lblStartingTechPoints.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblStartingTechPoints.Location = new Point(479, 0);
        this.lblStartingTechPoints.Margin = new Padding(0);
        this.lblStartingTechPoints.Name = "lblStartingTechPoints";
        this.lblStartingTechPoints.Size = new Size(43, 13);
        this.lblStartingTechPoints.TabIndex = 141;
        this.lblStartingTechPoints.Text = "500000";
        this.lblStartingTechPoints.TextAlign = ContentAlignment.MiddleLeft;
        this.lblStartingTechPoints.Visible = false;
        this.flpCreateProjectsBar.Controls.Add(this.cmdCreateResearch);
        this.flpCreateProjectsBar.Controls.Add(this.cmdAddToQueue);
        this.flpCreateProjectsBar.Controls.Add(this.cmdInstant);
        this.flpCreateProjectsBar.Controls.Add(this.cmdInstantRST);
        this.flpCreateProjectsBar.Controls.Add(this.cmdRemoveTech);
        this.flpCreateProjectsBar.Controls.Add(this.cmdDeleteTech);
        this.flpCreateProjectsBar.Location = new Point(3, 802);
        this.flpCreateProjectsBar.Name = "flpCreateProjectsBar";
        this.flpCreateProjectsBar.Size = new Size(595, 30);
        this.flpCreateProjectsBar.TabIndex = 139;
        this.cmdCreateResearch.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreateResearch.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdCreateResearch.Location = new Point(0, 0);
        this.cmdCreateResearch.Margin = new Padding(0);
        this.cmdCreateResearch.Name = "cmdCreateResearch";
        this.cmdCreateResearch.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreateResearch.TabIndex = 78;
        this.cmdCreateResearch.Tag = "1200";
        this.cmdCreateResearch.Text = "Create Project";
        this.cmdCreateResearch.UseVisualStyleBackColor = false;
        this.cmdCreateResearch.Click += this.cmdCreateResearch_Click;
        this.cmdAddToQueue.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddToQueue.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdAddToQueue.Location = new Point(96 /*0x60*/, 0);
        this.cmdAddToQueue.Margin = new Padding(0);
        this.cmdAddToQueue.Name = "cmdAddToQueue";
        this.cmdAddToQueue.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddToQueue.TabIndex = 79;
        this.cmdAddToQueue.Tag = "1200";
        this.cmdAddToQueue.Text = "Add to Queue";
        this.cmdAddToQueue.UseVisualStyleBackColor = false;
        this.cmdAddToQueue.Click += this.cmdAddToQueue_Click;
        this.cmdInstant.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdInstant.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdInstant.Location = new Point(192 /*0xC0*/, 0);
        this.cmdInstant.Margin = new Padding(0);
        this.cmdInstant.Name = "cmdInstant";
        this.cmdInstant.Size = new Size(96 /*0x60*/, 30);
        this.cmdInstant.TabIndex = 80 /*0x50*/;
        this.cmdInstant.Tag = "1200";
        this.cmdInstant.Text = "Instant";
        this.cmdInstant.UseVisualStyleBackColor = false;
        this.cmdInstant.Visible = false;
        this.cmdInstant.Click += this.cmdInstant_Click;
        this.cmdInstantRST.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdInstantRST.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdInstantRST.Location = new Point(288, 0);
        this.cmdInstantRST.Margin = new Padding(0);
        this.cmdInstantRST.Name = "cmdInstantRST";
        this.cmdInstantRST.Size = new Size(96 /*0x60*/, 30);
        this.cmdInstantRST.TabIndex = 81;
        this.cmdInstantRST.Tag = "1200";
        this.cmdInstantRST.Text = "Instant RST";
        this.cmdInstantRST.UseVisualStyleBackColor = false;
        this.cmdInstantRST.Visible = false;
        this.cmdInstantRST.Click += this.cmdInstantRST_Click;
        this.cmdRemoveTech.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRemoveTech.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRemoveTech.Location = new Point(384, 0);
        this.cmdRemoveTech.Margin = new Padding(0);
        this.cmdRemoveTech.Name = "cmdRemoveTech";
        this.cmdRemoveTech.Size = new Size(96 /*0x60*/, 30);
        this.cmdRemoveTech.TabIndex = 82;
        this.cmdRemoveTech.Tag = "1200";
        this.cmdRemoveTech.Text = "Remove Tech";
        this.cmdRemoveTech.UseCompatibleTextRendering = true;
        this.cmdRemoveTech.UseVisualStyleBackColor = false;
        this.cmdRemoveTech.Visible = false;
        this.cmdRemoveTech.Click += this.cmdRemoveTech_Click;
        this.cmdDeleteTech.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteTech.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDeleteTech.Location = new Point(480, 0);
        this.cmdDeleteTech.Margin = new Padding(0);
        this.cmdDeleteTech.Name = "cmdDeleteTech";
        this.cmdDeleteTech.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteTech.TabIndex = 83;
        this.cmdDeleteTech.Tag = "1200";
        this.cmdDeleteTech.Text = "Delete Tech";
        this.cmdDeleteTech.UseVisualStyleBackColor = false;
        this.cmdDeleteTech.Click += this.cmdDeleteTech_Click;
        this.flowLayoutPanel2.Controls.Add(this.cmdDeleteProject);
        this.flowLayoutPanel2.Controls.Add(this.cmdPauseResearch);
        this.flowLayoutPanel2.Controls.Add(this.cmdAssignNew);
        this.flowLayoutPanel2.Controls.Add(this.cmdAddLab);
        this.flowLayoutPanel2.Controls.Add(this.cmdRemoveLab);
        this.flowLayoutPanel2.Controls.Add(this.cmdUpResearchQueue);
        this.flowLayoutPanel2.Controls.Add(this.cmdDownResearchQueue);
        this.flowLayoutPanel2.Controls.Add(this.cmdRemoveQueue);
        this.flowLayoutPanel2.Location = new Point(3, 355);
        this.flowLayoutPanel2.Name = "flowLayoutPanel2";
        this.flowLayoutPanel2.Size = new Size(773, 34);
        this.flowLayoutPanel2.TabIndex = 138;
        this.cmdDeleteProject.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteProject.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDeleteProject.Location = new Point(0, 0);
        this.cmdDeleteProject.Margin = new Padding(0);
        this.cmdDeleteProject.Name = "cmdDeleteProject";
        this.cmdDeleteProject.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteProject.TabIndex = 62;
        this.cmdDeleteProject.Tag = "1200";
        this.cmdDeleteProject.Text = "Cancel Project";
        this.cmdDeleteProject.UseVisualStyleBackColor = false;
        this.cmdDeleteProject.Visible = false;
        this.cmdDeleteProject.Click += this.cmdDeleteProject_Click;
        this.cmdPauseResearch.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdPauseResearch.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdPauseResearch.Location = new Point(96 /*0x60*/, 0);
        this.cmdPauseResearch.Margin = new Padding(0);
        this.cmdPauseResearch.Name = "cmdPauseResearch";
        this.cmdPauseResearch.Size = new Size(96 /*0x60*/, 30);
        this.cmdPauseResearch.TabIndex = 63 /*0x3F*/;
        this.cmdPauseResearch.Tag = "1200";
        this.cmdPauseResearch.Text = "Pause Project";
        this.cmdPauseResearch.UseVisualStyleBackColor = false;
        this.cmdPauseResearch.Visible = false;
        this.cmdPauseResearch.Click += this.cmdPauseResearch_Click;
        this.cmdAssignNew.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAssignNew.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdAssignNew.Location = new Point(192 /*0xC0*/, 0);
        this.cmdAssignNew.Margin = new Padding(0);
        this.cmdAssignNew.Name = "cmdAssignNew";
        this.cmdAssignNew.Size = new Size(96 /*0x60*/, 30);
        this.cmdAssignNew.TabIndex = 145;
        this.cmdAssignNew.Tag = "1200";
        this.cmdAssignNew.Text = "Assign New";
        this.cmdAssignNew.UseVisualStyleBackColor = false;
        this.cmdAssignNew.Visible = false;
        this.cmdAssignNew.Click += this.cmdAssignNew_Click;
        this.cmdAddLab.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddLab.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdAddLab.Location = new Point(288, 0);
        this.cmdAddLab.Margin = new Padding(0);
        this.cmdAddLab.Name = "cmdAddLab";
        this.cmdAddLab.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddLab.TabIndex = 64 /*0x40*/;
        this.cmdAddLab.Tag = "1200";
        this.cmdAddLab.Text = "Add RL";
        this.cmdAddLab.UseVisualStyleBackColor = false;
        this.cmdAddLab.Visible = false;
        this.cmdAddLab.Click += this.cmdAddLab_Click;
        this.cmdRemoveLab.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRemoveLab.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRemoveLab.Location = new Point(384, 0);
        this.cmdRemoveLab.Margin = new Padding(0);
        this.cmdRemoveLab.Name = "cmdRemoveLab";
        this.cmdRemoveLab.Size = new Size(96 /*0x60*/, 30);
        this.cmdRemoveLab.TabIndex = 65;
        this.cmdRemoveLab.Tag = "1200";
        this.cmdRemoveLab.Text = "Remove RL";
        this.cmdRemoveLab.UseVisualStyleBackColor = false;
        this.cmdRemoveLab.Visible = false;
        this.cmdRemoveLab.Click += this.cmdRemoveLab_Click;
        this.cmdUpResearchQueue.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdUpResearchQueue.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdUpResearchQueue.Location = new Point(480, 0);
        this.cmdUpResearchQueue.Margin = new Padding(0);
        this.cmdUpResearchQueue.Name = "cmdUpResearchQueue";
        this.cmdUpResearchQueue.Size = new Size(96 /*0x60*/, 30);
        this.cmdUpResearchQueue.TabIndex = 66;
        this.cmdUpResearchQueue.Tag = "1200";
        this.cmdUpResearchQueue.Text = "Up Queue";
        this.cmdUpResearchQueue.UseVisualStyleBackColor = false;
        this.cmdUpResearchQueue.Visible = false;
        this.cmdUpResearchQueue.Click += this.cmdUpResearchQueue_Click;
        this.cmdDownResearchQueue.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDownResearchQueue.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDownResearchQueue.Location = new Point(576, 0);
        this.cmdDownResearchQueue.Margin = new Padding(0);
        this.cmdDownResearchQueue.Name = "cmdDownResearchQueue";
        this.cmdDownResearchQueue.Size = new Size(96 /*0x60*/, 30);
        this.cmdDownResearchQueue.TabIndex = 67;
        this.cmdDownResearchQueue.Tag = "1200";
        this.cmdDownResearchQueue.Text = "Down Queue";
        this.cmdDownResearchQueue.UseVisualStyleBackColor = false;
        this.cmdDownResearchQueue.Visible = false;
        this.cmdDownResearchQueue.Click += this.cmdDownResearchQueue_Click;
        this.cmdRemoveQueue.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRemoveQueue.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRemoveQueue.Location = new Point(672, 0);
        this.cmdRemoveQueue.Margin = new Padding(0);
        this.cmdRemoveQueue.Name = "cmdRemoveQueue";
        this.cmdRemoveQueue.Size = new Size(96 /*0x60*/, 30);
        this.cmdRemoveQueue.TabIndex = 68;
        this.cmdRemoveQueue.Tag = "1200";
        this.cmdRemoveQueue.Text = "Remove Queue";
        this.cmdRemoveQueue.UseVisualStyleBackColor = false;
        this.cmdRemoveQueue.Visible = false;
        this.cmdRemoveQueue.Click += this.cmdRemoveQueue_Click;
        this.txtTechDescription.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTechDescription.BorderStyle = BorderStyle.FixedSingle;
        this.txtTechDescription.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtTechDescription.Location = new Point(3, 754);
        this.txtTechDescription.Multiline = true;
        this.txtTechDescription.Name = "txtTechDescription";
        this.txtTechDescription.Size = new Size(850, 43);
        this.txtTechDescription.TabIndex = 128 /*0x80*/;
        this.txtTechDescription.Text = "Technology Description";
        this.flowLayoutPanel20.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel20.Controls.Add(this.rdoNormalView);
        this.flowLayoutPanel20.Controls.Add(this.rdoProjectOnlyView);
        this.flowLayoutPanel20.Location = new Point(858, 802);
        this.flowLayoutPanel20.Margin = new Padding(3, 0, 3, 3);
        this.flowLayoutPanel20.Name = "flowLayoutPanel20";
        this.flowLayoutPanel20.Size = new Size(168, 30);
        this.flowLayoutPanel20.TabIndex = 145;
        this.rdoNormalView.AutoSize = true;
        this.rdoNormalView.Checked = true;
        this.rdoNormalView.Location = new Point(12, 4);
        this.rdoNormalView.Margin = new Padding(12, 4, 3, 3);
        this.rdoNormalView.Name = "rdoNormalView";
        this.rdoNormalView.Size = new Size(58, 17);
        this.rdoNormalView.TabIndex = 75;
        this.rdoNormalView.TabStop = true;
        this.rdoNormalView.Text = "Normal";
        this.rdoNormalView.UseVisualStyleBackColor = true;
        this.rdoNormalView.CheckedChanged += this.rdoNormalView_CheckedChanged;
        this.rdoProjectOnlyView.AutoSize = true;
        this.rdoProjectOnlyView.Location = new Point(76, 4);
        this.rdoProjectOnlyView.Margin = new Padding(3, 4, 3, 3);
        this.rdoProjectOnlyView.Name = "rdoProjectOnlyView";
        this.rdoProjectOnlyView.Size = new Size(87, 17);
        this.rdoProjectOnlyView.TabIndex = 76;
        this.rdoProjectOnlyView.Text = "Projects Only";
        this.rdoProjectOnlyView.UseVisualStyleBackColor = true;
        this.chkMatchOnly.AutoSize = true;
        this.chkMatchOnly.Checked = true;
        this.chkMatchOnly.CheckState = CheckState.Checked;
        this.chkMatchOnly.Location = new Point(225, 399);
        this.chkMatchOnly.Name = "chkMatchOnly";
        this.chkMatchOnly.Size = new Size(142, 17);
        this.chkMatchOnly.TabIndex = 72;
        this.chkMatchOnly.Text = "Matching Scientists Only";
        this.chkMatchOnly.TextAlign = ContentAlignment.MiddleRight;
        this.chkMatchOnly.UseVisualStyleBackColor = true;
        this.chkMatchOnly.CheckedChanged += this.chkMatchOnly_CheckedChanged;
        this.lstvScientists.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvScientists.Columns.AddRange(new ColumnHeader[4]
        {
            this.columnHeader_94,
            this.columnHeader_95,
            this.columnHeader_96,
            this.columnHeader_97
        });
        this.lstvScientists.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvScientists.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvScientists.HideSelection = false;
        this.lstvScientists.Location = new Point(484, 419);
        this.lstvScientists.Name = "lstvScientists";
        this.lstvScientists.Size = new Size(543, 330);
        this.lstvScientists.TabIndex = 110;
        this.lstvScientists.UseCompatibleStateImageBehavior = false;
        this.lstvScientists.View = View.Details;
        this.lstvScientists.SelectedIndexChanged += this.lstvScientists_SelectedIndexChanged;
        this.columnHeader_94.Width = 200;
        this.columnHeader_95.Text = "";
        this.columnHeader_95.Width = 160 /*0xA0*/;
        this.columnHeader_96.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_96.Width = 70;
        this.columnHeader_97.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_97.Width = 70;
        this.cboResearchFields.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboResearchFields.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboResearchFields.FormattingEnabled = true;
        this.cboResearchFields.Location = new Point(3, 395);
        this.cboResearchFields.Margin = new Padding(3, 3, 3, 0);
        this.cboResearchFields.Name = "cboResearchFields";
        this.cboResearchFields.Size = new Size(205, 21);
        this.cboResearchFields.TabIndex = 71;
        this.cboResearchFields.SelectedIndexChanged += this.cboResearchFields_SelectedIndexChanged;
        this.lstvTechnology.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvTechnology.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_92,
            this.columnHeader_93
        });
        this.lstvTechnology.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvTechnology.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvTechnology.HideSelection = false;
        this.lstvTechnology.Location = new Point(3, 419);
        this.lstvTechnology.Name = "lstvTechnology";
        this.lstvTechnology.Size = new Size(475, 330);
        this.lstvTechnology.TabIndex = 108;
        this.lstvTechnology.UseCompatibleStateImageBehavior = false;
        this.lstvTechnology.View = View.Details;
        this.lstvTechnology.SelectedIndexChanged += this.lstvTechnology_SelectedIndexChanged;
        this.columnHeader_92.Width = 335;
        this.columnHeader_93.Text = "";
        this.columnHeader_93.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_93.Width = 110;
        this.lstvResearchProjects.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvResearchProjects.Columns.AddRange(new ColumnHeader[10]
        {
            this.columnHeader_160,
            this.columnHeader_161,
            this.columnHeader_162,
            this.columnHeader_163,
            this.columnHeader_164,
            this.columnHeader_165,
            this.columnHeader_166,
            this.columnHeader_167,
            this.columnHeader_168,
            this.columnHeader_169
        });
        this.lstvResearchProjects.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvResearchProjects.FullRowSelect = true;
        this.lstvResearchProjects.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvResearchProjects.HideSelection = false;
        this.lstvResearchProjects.Location = new Point(3, 8);
        this.lstvResearchProjects.Name = "lstvResearchProjects";
        this.lstvResearchProjects.Size = new Size(1024 /*0x0400*/, 344);
        this.lstvResearchProjects.TabIndex = 107;
        this.lstvResearchProjects.UseCompatibleStateImageBehavior = false;
        this.lstvResearchProjects.View = View.Details;
        this.lstvResearchProjects.SelectedIndexChanged += this.lstvResearchProjects_SelectedIndexChanged;
        this.columnHeader_160.Width = 30;
        this.columnHeader_161.Text = "";
        this.columnHeader_161.Width = 275;
        this.columnHeader_162.Text = "";
        this.columnHeader_162.Width = 150;
        this.columnHeader_163.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_163.Width = 70;
        this.columnHeader_164.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_164.Width = 70;
        this.columnHeader_165.Text = "";
        this.columnHeader_165.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_165.Width = 70;
        this.columnHeader_166.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_166.Width = 75;
        this.columnHeader_167.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_167.Width = 80 /*0x50*/;
        this.columnHeader_168.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_168.Width = 120;
        this.columnHeader_169.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_169.Width = 50;
        this.tabGUTraining.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabGUTraining.Controls.Add(this.cmdClearQueue);
        this.tabGUTraining.Controls.Add(this.label45);
        this.tabGUTraining.Controls.Add(this.txtGUPercentage);
        this.tabGUTraining.Controls.Add(this.chkRoman);
        this.tabGUTraining.Controls.Add(this.pnlStartingBuildPoints);
        this.tabGUTraining.Controls.Add(this.cmdDownQueueGround);
        this.tabGUTraining.Controls.Add(this.cmdUpQueueGround);
        this.tabGUTraining.Controls.Add(this.txtUnitName);
        this.tabGUTraining.Controls.Add(this.lstvTemplate);
        this.tabGUTraining.Controls.Add(this.cmdSMAddUnits);
        this.tabGUTraining.Controls.Add(this.cmdRenameType);
        this.tabGUTraining.Controls.Add(this.cmdRenameGUTask);
        this.tabGUTraining.Controls.Add(this.lstvGroundUnitTraining);
        this.tabGUTraining.Controls.Add(this.cmdDeleteGUTask);
        this.tabGUTraining.Controls.Add(this.cmdAddGUTask);
        this.tabGUTraining.Location = new Point(4, 22);
        this.tabGUTraining.Name = "tabGUTraining";
        this.tabGUTraining.Padding = new Padding(3);
        this.tabGUTraining.Size = new Size(1030, 836);
        this.tabGUTraining.TabIndex = 8;
        this.tabGUTraining.Text = "GU Training";
        this.cmdClearQueue.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdClearQueue.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdClearQueue.Location = new Point(291, 518);
        this.cmdClearQueue.Margin = new Padding(0);
        this.cmdClearQueue.Name = "cmdClearQueue";
        this.cmdClearQueue.Size = new Size(96 /*0x60*/, 30);
        this.cmdClearQueue.TabIndex = 166;
        this.cmdClearQueue.Tag = "1200";
        this.cmdClearQueue.Text = "Clear Queue";
        this.cmdClearQueue.UseVisualStyleBackColor = false;
        this.cmdClearQueue.Click += this.cmdClearQueue_Click;
        this.label45.AutoSize = true;
        this.label45.Location = new Point(134, 806);
        this.label45.Margin = new Padding(3, 3, 3, 0);
        this.label45.Name = "label45";
        this.label45.Padding = new Padding(0, 5, 5, 0);
        this.label45.Size = new Size(20, 18);
        this.label45.TabIndex = 165;
        this.label45.Text = "%";
        this.txtGUPercentage.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtGUPercentage.BorderStyle = BorderStyle.None;
        this.txtGUPercentage.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtGUPercentage.Location = new Point(101, 811);
        this.txtGUPercentage.Margin = new Padding(3, 8, 3, 3);
        this.txtGUPercentage.Name = "txtGUPercentage";
        this.txtGUPercentage.Size = new Size(36, 13);
        this.txtGUPercentage.TabIndex = 164;
        this.txtGUPercentage.Text = "100";
        this.txtGUPercentage.TextAlign = HorizontalAlignment.Center;
        this.chkRoman.AutoSize = true;
        this.chkRoman.Location = new Point(551, 810);
        this.chkRoman.Name = "chkRoman";
        this.chkRoman.Size = new Size(85, 17);
        this.chkRoman.TabIndex = 163;
        this.chkRoman.Text = "Use Roman ";
        this.chkRoman.TextAlign = ContentAlignment.MiddleRight;
        this.chkRoman.UseVisualStyleBackColor = true;
        this.chkRoman.CheckedChanged += this.chkRoman_CheckedChanged;
        this.pnlStartingBuildPoints.Controls.Add(this.label9);
        this.pnlStartingBuildPoints.Controls.Add(this.txtInstantBuild);
        this.pnlStartingBuildPoints.Location = new Point(650, 804);
        this.pnlStartingBuildPoints.Name = "pnlStartingBuildPoints";
        this.pnlStartingBuildPoints.Size = new Size(174, 24);
        this.pnlStartingBuildPoints.TabIndex = 162;
        this.label9.AutoSize = true;
        this.label9.Location = new Point(8, 8);
        this.label9.Margin = new Padding(3);
        this.label9.Name = "label9";
        this.label9.Size = new Size(97, 13);
        this.label9.TabIndex = 158;
        this.label9.Text = "Instant Build Points";
        this.txtInstantBuild.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtInstantBuild.BorderStyle = BorderStyle.None;
        this.txtInstantBuild.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtInstantBuild.Location = new Point(105, 8);
        this.txtInstantBuild.Name = "txtInstantBuild";
        this.txtInstantBuild.Size = new Size(66, 13);
        this.txtInstantBuild.TabIndex = 159;
        this.txtInstantBuild.Text = "0";
        this.txtInstantBuild.TextAlign = HorizontalAlignment.Center;
        this.cmdDownQueueGround.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDownQueueGround.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDownQueueGround.Location = new Point(195, 518);
        this.cmdDownQueueGround.Margin = new Padding(0);
        this.cmdDownQueueGround.Name = "cmdDownQueueGround";
        this.cmdDownQueueGround.Size = new Size(96 /*0x60*/, 30);
        this.cmdDownQueueGround.TabIndex = 161;
        this.cmdDownQueueGround.Tag = "1200";
        this.cmdDownQueueGround.Text = "Down Queue";
        this.cmdDownQueueGround.UseVisualStyleBackColor = false;
        this.cmdDownQueueGround.Click += this.cmdDownQueueGround_Click;
        this.cmdUpQueueGround.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdUpQueueGround.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdUpQueueGround.Location = new Point(99, 518);
        this.cmdUpQueueGround.Margin = new Padding(0);
        this.cmdUpQueueGround.Name = "cmdUpQueueGround";
        this.cmdUpQueueGround.Size = new Size(96 /*0x60*/, 30);
        this.cmdUpQueueGround.TabIndex = 160 /*0xA0*/;
        this.cmdUpQueueGround.Tag = "1200";
        this.cmdUpQueueGround.Text = "Up Queue";
        this.cmdUpQueueGround.UseVisualStyleBackColor = false;
        this.cmdUpQueueGround.Click += this.cmdUpQueueGround_Click;
        this.txtUnitName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtUnitName.BorderStyle = BorderStyle.None;
        this.txtUnitName.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtUnitName.Location = new Point(170, 811);
        this.txtUnitName.Margin = new Padding(0, 0, 6, 3);
        this.txtUnitName.Name = "txtUnitName";
        this.txtUnitName.Size = new Size(353, 13);
        this.txtUnitName.TabIndex = 86;
        this.txtUnitName.Text = "25";
        this.lstvTemplate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvTemplate.BorderStyle = BorderStyle.FixedSingle;
        this.lstvTemplate.Columns.AddRange(new ColumnHeader[8]
        {
            this.columnHeader_98,
            this.columnHeader_99,
            this.columnHeader_100,
            this.columnHeader_101,
            this.columnHeader_102,
            this.columnHeader_103,
            this.columnHeader_104,
            this.columnHeader_105
        });
        this.lstvTemplate.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvTemplate.FullRowSelect = true;
        this.lstvTemplate.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvTemplate.HideSelection = false;
        this.lstvTemplate.Location = new Point(3, 553);
        this.lstvTemplate.MultiSelect = false;
        this.lstvTemplate.Name = "lstvTemplate";
        this.lstvTemplate.Size = new Size(1024 /*0x0400*/, 243);
        this.lstvTemplate.TabIndex = 157;
        this.lstvTemplate.UseCompatibleStateImageBehavior = false;
        this.lstvTemplate.View = View.Details;
        this.lstvTemplate.SelectedIndexChanged += this.lstvTemplate_SelectedIndexChanged;
        this.columnHeader_99.Width = 200;
        this.columnHeader_100.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_101.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_102.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_103.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_104.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_105.Width = 400;
        this.cmdSMAddUnits.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSMAddUnits.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSMAddUnits.Location = new Point(833, 802);
        this.cmdSMAddUnits.Margin = new Padding(0);
        this.cmdSMAddUnits.Name = "cmdSMAddUnits";
        this.cmdSMAddUnits.Size = new Size(96 /*0x60*/, 30);
        this.cmdSMAddUnits.TabIndex = 87;
        this.cmdSMAddUnits.Tag = "1200";
        this.cmdSMAddUnits.Text = "Instant Build";
        this.cmdSMAddUnits.UseVisualStyleBackColor = false;
        this.cmdSMAddUnits.Click += this.cmdSMAddUnits_Click;
        this.cmdRenameType.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameType.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRenameType.Location = new Point(929, 802);
        this.cmdRenameType.Margin = new Padding(0);
        this.cmdRenameType.Name = "cmdRenameType";
        this.cmdRenameType.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameType.TabIndex = 90;
        this.cmdRenameType.Tag = "1200";
        this.cmdRenameType.Text = "Rename Temp";
        this.cmdRenameType.UseVisualStyleBackColor = false;
        this.cmdRenameType.Click += this.cmdRenameType_Click;
        this.cmdRenameGUTask.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameGUTask.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRenameGUTask.Location = new Point(3, 518);
        this.cmdRenameGUTask.Margin = new Padding(0);
        this.cmdRenameGUTask.Name = "cmdRenameGUTask";
        this.cmdRenameGUTask.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameGUTask.TabIndex = 89;
        this.cmdRenameGUTask.Tag = "1200";
        this.cmdRenameGUTask.Text = "Rename Task";
        this.cmdRenameGUTask.UseVisualStyleBackColor = false;
        this.cmdRenameGUTask.Click += this.cmdRenameGUTask_Click;
        this.lstvGroundUnitTraining.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvGroundUnitTraining.Columns.AddRange(new ColumnHeader[6]
        {
            this.columnHeader_75,
            this.columnHeader_76,
            this.columnHeader_77,
            this.columnHeader_147,
            this.columnHeader_78,
            this.columnHeader_79
        });
        this.lstvGroundUnitTraining.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvGroundUnitTraining.FullRowSelect = true;
        this.lstvGroundUnitTraining.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvGroundUnitTraining.HideSelection = false;
        this.lstvGroundUnitTraining.Location = new Point(3, 8);
        this.lstvGroundUnitTraining.MultiSelect = false;
        this.lstvGroundUnitTraining.Name = "lstvGroundUnitTraining";
        this.lstvGroundUnitTraining.Size = new Size(1024 /*0x0400*/, 505);
        this.lstvGroundUnitTraining.TabIndex = 108;
        this.lstvGroundUnitTraining.UseCompatibleStateImageBehavior = false;
        this.lstvGroundUnitTraining.View = View.Details;
        this.lstvGroundUnitTraining.SelectedIndexChanged += this.lstvGroundUnitTraining_SelectedIndexChanged;
        this.columnHeader_75.Text = "";
        this.columnHeader_75.Width = 260;
        this.columnHeader_76.Text = "";
        this.columnHeader_76.Width = 350;
        this.columnHeader_77.Text = "";
        this.columnHeader_77.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_77.Width = 80 /*0x50*/;
        this.columnHeader_147.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_147.Width = 80 /*0x50*/;
        this.columnHeader_78.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_78.Width = 80 /*0x50*/;
        this.columnHeader_79.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_79.Width = 150;
        this.cmdDeleteGUTask.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteGUTask.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDeleteGUTask.Location = new Point(929, 518);
        this.cmdDeleteGUTask.Margin = new Padding(0);
        this.cmdDeleteGUTask.Name = "cmdDeleteGUTask";
        this.cmdDeleteGUTask.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteGUTask.TabIndex = 88;
        this.cmdDeleteGUTask.Tag = "1200";
        this.cmdDeleteGUTask.Text = "Delete Task";
        this.cmdDeleteGUTask.UseVisualStyleBackColor = false;
        this.cmdDeleteGUTask.Click += this.cmdDeleteGUTask_Click;
        this.cmdAddGUTask.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddGUTask.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdAddGUTask.Location = new Point(3, 802);
        this.cmdAddGUTask.Margin = new Padding(0);
        this.cmdAddGUTask.Name = "cmdAddGUTask";
        this.cmdAddGUTask.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddGUTask.TabIndex = 85;
        this.cmdAddGUTask.Tag = "1200";
        this.cmdAddGUTask.Text = "Create Task";
        this.cmdAddGUTask.UseVisualStyleBackColor = false;
        this.cmdAddGUTask.Click += this.cmdAddGUTask_Click;
        this.tabWealth.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabWealth.Controls.Add(this.cmdEditTax);
        this.tabWealth.Controls.Add(this.label49);
        this.tabWealth.Controls.Add(this.txtTaxRate);
        this.tabWealth.Controls.Add(this.lstvWealthHistory);
        this.tabWealth.Controls.Add(this.cmdEditWealth);
        this.tabWealth.Controls.Add(this.panel7);
        this.tabWealth.Controls.Add(this.label13);
        this.tabWealth.Controls.Add(this.txtPopPerCapita);
        this.tabWealth.Controls.Add(this.label12);
        this.tabWealth.Controls.Add(this.txtRacialPerCapita);
        this.tabWealth.Controls.Add(this.label8);
        this.tabWealth.Controls.Add(this.txtAnnualWealth);
        this.tabWealth.Controls.Add(this.lstvExpenditure);
        this.tabWealth.Controls.Add(this.lstvIncome);
        this.tabWealth.Controls.Add(this.lstvTradeGoods);
        this.tabWealth.Location = new Point(4, 22);
        this.tabWealth.Name = "tabWealth";
        this.tabWealth.Padding = new Padding(3);
        this.tabWealth.Size = new Size(1030, 836);
        this.tabWealth.TabIndex = 9;
        this.tabWealth.Text = "Wealth";
        this.cmdEditTax.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdEditTax.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdEditTax.Location = new Point(6, 800);
        this.cmdEditTax.Margin = new Padding(0);
        this.cmdEditTax.Name = "cmdEditTax";
        this.cmdEditTax.Size = new Size(96 /*0x60*/, 30);
        this.cmdEditTax.TabIndex = 137;
        this.cmdEditTax.Tag = "1200";
        this.cmdEditTax.Text = "Edit Tax Rate";
        this.cmdEditTax.UseVisualStyleBackColor = false;
        this.cmdEditTax.Click += this.cmdEditTax_Click;
        this.label49.AutoSize = true;
        this.label49.Location = new Point(763, 8);
        this.label49.Name = "label49";
        this.label49.Padding = new Padding(0, 5, 5, 0);
        this.label49.Size = new Size(123, 18);
        this.label49.TabIndex = 135;
        this.label49.Text = "Shipping Line Tax Rate";
        this.txtTaxRate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTaxRate.BorderStyle = BorderStyle.None;
        this.txtTaxRate.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtTaxRate.Location = new Point(884, 13);
        this.txtTaxRate.Margin = new Padding(3, 8, 3, 3);
        this.txtTaxRate.Name = "txtTaxRate";
        this.txtTaxRate.Size = new Size(80 /*0x50*/, 13);
        this.txtTaxRate.TabIndex = 136;
        this.txtTaxRate.Text = "100";
        this.txtTaxRate.TextAlign = HorizontalAlignment.Center;
        this.txtTaxRate.TextChanged += this.txtTaxRate_TextChanged;
        this.lstvWealthHistory.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvWealthHistory.Columns.AddRange(new ColumnHeader[5]
        {
            this.columnHeader_142,
            this.columnHeader_143,
            this.columnHeader_144,
            this.columnHeader_145,
            this.columnHeader_146
        });
        this.lstvWealthHistory.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvWealthHistory.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvWealthHistory.HideSelection = false;
        this.lstvWealthHistory.Location = new Point(6, 343);
        this.lstvWealthHistory.Name = "lstvWealthHistory";
        this.lstvWealthHistory.Size = new Size(447, 347);
        this.lstvWealthHistory.TabIndex = 120;
        this.lstvWealthHistory.UseCompatibleStateImageBehavior = false;
        this.lstvWealthHistory.View = View.Details;
        this.columnHeader_142.Text = "";
        this.columnHeader_142.Width = 120;
        this.columnHeader_143.Text = "";
        this.columnHeader_143.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_143.Width = 80 /*0x50*/;
        this.columnHeader_144.Text = "";
        this.columnHeader_144.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_144.Width = 80 /*0x50*/;
        this.columnHeader_145.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_145.Width = 80 /*0x50*/;
        this.columnHeader_146.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_146.Width = 80 /*0x50*/;
        this.cmdEditWealth.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdEditWealth.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdEditWealth.Location = new Point(102, 800);
        this.cmdEditWealth.Margin = new Padding(0);
        this.cmdEditWealth.Name = "cmdEditWealth";
        this.cmdEditWealth.Size = new Size(96 /*0x60*/, 30);
        this.cmdEditWealth.TabIndex = 119;
        this.cmdEditWealth.Tag = "1200";
        this.cmdEditWealth.Text = "SM: Edit Wealth";
        this.cmdEditWealth.UseVisualStyleBackColor = false;
        this.cmdEditWealth.Click += this.cmdEditWealth_Click;
        this.panel7.BackgroundImageLayout = ImageLayout.None;
        this.panel7.BorderStyle = BorderStyle.FixedSingle;
        this.panel7.Controls.Add(this.rdoOneYear);
        this.panel7.Controls.Add(this.rdoSixMonths);
        this.panel7.Controls.Add(this.rdoThreeMonths);
        this.panel7.Controls.Add(this.rdoOneMonth);
        this.panel7.Location = new Point(912, 41);
        this.panel7.Name = "panel7";
        this.panel7.Size = new Size(110, 296);
        this.panel7.TabIndex = 118;
        this.rdoOneYear.AutoSize = true;
        this.rdoOneYear.Location = new Point(17, 111);
        this.rdoOneYear.Name = "rdoOneYear";
        this.rdoOneYear.Size = new Size(70, 17);
        this.rdoOneYear.TabIndex = 94;
        this.rdoOneYear.Text = "One Year";
        this.rdoOneYear.UseVisualStyleBackColor = true;
        this.rdoOneYear.CheckedChanged += this.rdoOneMonth_CheckedChanged;
        this.rdoSixMonths.AutoSize = true;
        this.rdoSixMonths.Location = new Point(16 /*0x10*/, 81);
        this.rdoSixMonths.Name = "rdoSixMonths";
        this.rdoSixMonths.Size = new Size(77, 17);
        this.rdoSixMonths.TabIndex = 93;
        this.rdoSixMonths.Text = "Six Months";
        this.rdoSixMonths.UseVisualStyleBackColor = true;
        this.rdoSixMonths.CheckedChanged += this.rdoOneMonth_CheckedChanged;
        this.rdoThreeMonths.AutoSize = true;
        this.rdoThreeMonths.Location = new Point(16 /*0x10*/, 51);
        this.rdoThreeMonths.Name = "rdoThreeMonths";
        this.rdoThreeMonths.Size = new Size(91, 17);
        this.rdoThreeMonths.TabIndex = 92;
        this.rdoThreeMonths.Text = "Three Months";
        this.rdoThreeMonths.UseVisualStyleBackColor = true;
        this.rdoThreeMonths.CheckedChanged += this.rdoOneMonth_CheckedChanged;
        this.rdoOneMonth.AutoSize = true;
        this.rdoOneMonth.Checked = true;
        this.rdoOneMonth.Location = new Point(16 /*0x10*/, 21);
        this.rdoOneMonth.Name = "rdoOneMonth";
        this.rdoOneMonth.Size = new Size(78, 17);
        this.rdoOneMonth.TabIndex = 91;
        this.rdoOneMonth.TabStop = true;
        this.rdoOneMonth.Text = "One Month";
        this.rdoOneMonth.UseVisualStyleBackColor = true;
        this.rdoOneMonth.CheckedChanged += this.rdoOneMonth_CheckedChanged;
        this.label13.AutoSize = true;
        this.label13.Location = new Point(497, 8);
        this.label13.Name = "label13";
        this.label13.Padding = new Padding(0, 5, 5, 0);
        this.label13.Size = new Size(152, 18);
        this.label13.TabIndex = 116;
        this.label13.Text = "Population Per Capita Income";
        this.txtPopPerCapita.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtPopPerCapita.BorderStyle = BorderStyle.None;
        this.txtPopPerCapita.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtPopPerCapita.Location = new Point(655, 13);
        this.txtPopPerCapita.Margin = new Padding(3, 8, 3, 3);
        this.txtPopPerCapita.Name = "txtPopPerCapita";
        this.txtPopPerCapita.ReadOnly = true;
        this.txtPopPerCapita.Size = new Size(80 /*0x50*/, 13);
        this.txtPopPerCapita.TabIndex = 117;
        this.txtPopPerCapita.Text = "100";
        this.txtPopPerCapita.TextAlign = HorizontalAlignment.Center;
        this.label12.AutoSize = true;
        this.label12.Location = new Point(247, 8);
        this.label12.Name = "label12";
        this.label12.Padding = new Padding(0, 5, 5, 0);
        this.label12.Size = new Size(132, 18);
        this.label12.TabIndex = 114;
        this.label12.Text = "Racial Per Capita Income";
        this.txtRacialPerCapita.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtRacialPerCapita.BorderStyle = BorderStyle.None;
        this.txtRacialPerCapita.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtRacialPerCapita.Location = new Point(385, 13);
        this.txtRacialPerCapita.Margin = new Padding(3, 8, 3, 3);
        this.txtRacialPerCapita.Name = "txtRacialPerCapita";
        this.txtRacialPerCapita.ReadOnly = true;
        this.txtRacialPerCapita.Size = new Size(80 /*0x50*/, 13);
        this.txtRacialPerCapita.TabIndex = 115;
        this.txtRacialPerCapita.Text = "100";
        this.txtRacialPerCapita.TextAlign = HorizontalAlignment.Center;
        this.label8.AutoSize = true;
        this.label8.Location = new Point(9, 8);
        this.label8.Name = "label8";
        this.label8.Padding = new Padding(0, 5, 5, 0);
        this.label8.Size = new Size(115, 18);
        this.label8.TabIndex = 112 /*0x70*/;
        this.label8.Text = "Annual Racial Wealth";
        this.txtAnnualWealth.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAnnualWealth.BorderStyle = BorderStyle.None;
        this.txtAnnualWealth.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtAnnualWealth.Location = new Point(130, 13);
        this.txtAnnualWealth.Margin = new Padding(3, 8, 3, 3);
        this.txtAnnualWealth.Name = "txtAnnualWealth";
        this.txtAnnualWealth.ReadOnly = true;
        this.txtAnnualWealth.Size = new Size(80 /*0x50*/, 13);
        this.txtAnnualWealth.TabIndex = 113;
        this.txtAnnualWealth.Text = "100";
        this.txtAnnualWealth.TextAlign = HorizontalAlignment.Center;
        this.lstvExpenditure.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvExpenditure.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_86,
            this.columnHeader_87,
            this.columnHeader_88
        });
        this.lstvExpenditure.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvExpenditure.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvExpenditure.HideSelection = false;
        this.lstvExpenditure.Location = new Point(459, 41);
        this.lstvExpenditure.Name = "lstvExpenditure";
        this.lstvExpenditure.Size = new Size(447, 296);
        this.lstvExpenditure.TabIndex = 111;
        this.lstvExpenditure.UseCompatibleStateImageBehavior = false;
        this.lstvExpenditure.View = View.Details;
        this.columnHeader_86.Text = "";
        this.columnHeader_86.Width = 200;
        this.columnHeader_87.Text = "";
        this.columnHeader_87.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_87.Width = 120;
        this.columnHeader_88.Text = "";
        this.columnHeader_88.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_88.Width = 120;
        this.lstvIncome.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvIncome.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_89,
            this.columnHeader_90,
            this.columnHeader_91
        });
        this.lstvIncome.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvIncome.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvIncome.HideSelection = false;
        this.lstvIncome.Location = new Point(6, 41);
        this.lstvIncome.Name = "lstvIncome";
        this.lstvIncome.Size = new Size(447, 296);
        this.lstvIncome.TabIndex = 110;
        this.lstvIncome.UseCompatibleStateImageBehavior = false;
        this.lstvIncome.View = View.Details;
        this.columnHeader_89.Text = "";
        this.columnHeader_89.Width = 200;
        this.columnHeader_90.Text = "";
        this.columnHeader_90.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_90.Width = 120;
        this.columnHeader_91.Text = "";
        this.columnHeader_91.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_91.Width = 120;
        this.lstvTradeGoods.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvTradeGoods.Columns.AddRange(new ColumnHeader[6]
        {
            this.columnHeader_80,
            this.columnHeader_81,
            this.columnHeader_82,
            this.columnHeader_83,
            this.columnHeader_84,
            this.columnHeader_85
        });
        this.lstvTradeGoods.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvTradeGoods.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvTradeGoods.HideSelection = false;
        this.lstvTradeGoods.Location = new Point(459, 343);
        this.lstvTradeGoods.Name = "lstvTradeGoods";
        this.lstvTradeGoods.Size = new Size(563, 347);
        this.lstvTradeGoods.TabIndex = 109;
        this.lstvTradeGoods.UseCompatibleStateImageBehavior = false;
        this.lstvTradeGoods.View = View.Details;
        this.lstvTradeGoods.SelectedIndexChanged += this.lstvTradeGoods_SelectedIndexChanged;
        this.columnHeader_80.Text = "";
        this.columnHeader_80.Width = 140;
        this.columnHeader_81.Text = "";
        this.columnHeader_81.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_81.Width = 80 /*0x50*/;
        this.columnHeader_82.Text = "";
        this.columnHeader_82.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_82.Width = 80 /*0x50*/;
        this.columnHeader_83.Text = "";
        this.columnHeader_83.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_83.Width = 80 /*0x50*/;
        this.columnHeader_84.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_84.Width = 80 /*0x50*/;
        this.columnHeader_85.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_85.Width = 80 /*0x50*/;
        this.tabCivilian.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabCivilian.Controls.Add(this.flowLayoutPanel25);
        this.tabCivilian.Controls.Add(this.flowLayoutPanel10);
        this.tabCivilian.Controls.Add(this.flowLayoutPanel8);
        this.tabCivilian.Controls.Add(this.flowLayoutPanel7);
        this.tabCivilian.Controls.Add(this.flowLayoutPanel6);
        this.tabCivilian.Location = new Point(4, 22);
        this.tabCivilian.Name = "tabCivilian";
        this.tabCivilian.Padding = new Padding(3);
        this.tabCivilian.Size = new Size(1030, 836);
        this.tabCivilian.TabIndex = 11;
        this.tabCivilian.Text = "Civilian / Flags";
        this.flowLayoutPanel25.Controls.Add(this.cmdSMAddInstallation);
        this.flowLayoutPanel25.Controls.Add(this.cmdSMEditInstallation);
        this.flowLayoutPanel25.Controls.Add(this.cmdSMDeleteInstallation);
        this.flowLayoutPanel25.Controls.Add(this.cmdScrapInstallation);
        this.flowLayoutPanel25.Controls.Add(this.cmdDemand);
        this.flowLayoutPanel25.Controls.Add(this.cmdEditDemand);
        this.flowLayoutPanel25.Controls.Add(this.cmdDeleteDemand);
        this.flowLayoutPanel25.Controls.Add(this.cmdSupply);
        this.flowLayoutPanel25.Controls.Add(this.cmdEditSupply);
        this.flowLayoutPanel25.Controls.Add(this.cmdDeleteSupply);
        this.flowLayoutPanel25.Location = new Point(6, 800);
        this.flowLayoutPanel25.Name = "flowLayoutPanel25";
        this.flowLayoutPanel25.Size = new Size(1018, 32 /*0x20*/);
        this.flowLayoutPanel25.TabIndex = 131;
        this.cmdSMAddInstallation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSMAddInstallation.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSMAddInstallation.Location = new Point(0, 0);
        this.cmdSMAddInstallation.Margin = new Padding(0);
        this.cmdSMAddInstallation.Name = "cmdSMAddInstallation";
        this.cmdSMAddInstallation.Size = new Size(96 /*0x60*/, 30);
        this.cmdSMAddInstallation.TabIndex = 102;
        this.cmdSMAddInstallation.Tag = "1200";
        this.cmdSMAddInstallation.Text = "Add Installation";
        this.cmdSMAddInstallation.UseVisualStyleBackColor = false;
        this.cmdSMAddInstallation.Click += this.cmdSMAddInstallation_Click;
        this.cmdSMEditInstallation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSMEditInstallation.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSMEditInstallation.Location = new Point(96 /*0x60*/, 0);
        this.cmdSMEditInstallation.Margin = new Padding(0);
        this.cmdSMEditInstallation.Name = "cmdSMEditInstallation";
        this.cmdSMEditInstallation.Size = new Size(96 /*0x60*/, 30);
        this.cmdSMEditInstallation.TabIndex = 103;
        this.cmdSMEditInstallation.Tag = "1200";
        this.cmdSMEditInstallation.Text = "Edit Installation";
        this.cmdSMEditInstallation.UseVisualStyleBackColor = false;
        this.cmdSMEditInstallation.Click += this.cmdSMEditInstallation_Click;
        this.cmdSMDeleteInstallation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSMDeleteInstallation.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSMDeleteInstallation.Location = new Point(192 /*0xC0*/, 0);
        this.cmdSMDeleteInstallation.Margin = new Padding(0);
        this.cmdSMDeleteInstallation.Name = "cmdSMDeleteInstallation";
        this.cmdSMDeleteInstallation.Size = new Size(96 /*0x60*/, 30);
        this.cmdSMDeleteInstallation.TabIndex = 104;
        this.cmdSMDeleteInstallation.Tag = "1200";
        this.cmdSMDeleteInstallation.Text = "Delete Install";
        this.cmdSMDeleteInstallation.UseVisualStyleBackColor = false;
        this.cmdSMDeleteInstallation.Click += this.cmdSMDeleteInstallation_Click;
        this.cmdScrapInstallation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdScrapInstallation.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdScrapInstallation.Location = new Point(288, 0);
        this.cmdScrapInstallation.Margin = new Padding(0);
        this.cmdScrapInstallation.Name = "cmdScrapInstallation";
        this.cmdScrapInstallation.Size = new Size(96 /*0x60*/, 30);
        this.cmdScrapInstallation.TabIndex = 111;
        this.cmdScrapInstallation.Tag = "1200";
        this.cmdScrapInstallation.Text = "Scrap Installation";
        this.cmdScrapInstallation.UseVisualStyleBackColor = false;
        this.cmdScrapInstallation.Click += this.cmdScrapInstallation_Click;
        this.cmdDemand.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDemand.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDemand.Location = new Point(384, 0);
        this.cmdDemand.Margin = new Padding(0);
        this.cmdDemand.Name = "cmdDemand";
        this.cmdDemand.Size = new Size(96 /*0x60*/, 30);
        this.cmdDemand.TabIndex = 105;
        this.cmdDemand.Tag = "1200";
        this.cmdDemand.Text = "Add Demand";
        this.cmdDemand.UseVisualStyleBackColor = false;
        this.cmdDemand.Click += this.cmdDemand_Click;
        this.cmdEditDemand.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdEditDemand.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdEditDemand.Location = new Point(480, 0);
        this.cmdEditDemand.Margin = new Padding(0);
        this.cmdEditDemand.Name = "cmdEditDemand";
        this.cmdEditDemand.Size = new Size(96 /*0x60*/, 30);
        this.cmdEditDemand.TabIndex = 106;
        this.cmdEditDemand.Tag = "1200";
        this.cmdEditDemand.Text = "Edit Demand";
        this.cmdEditDemand.UseVisualStyleBackColor = false;
        this.cmdEditDemand.Click += this.cmdEditDemand_Click;
        this.cmdDeleteDemand.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteDemand.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDeleteDemand.Location = new Point(576, 0);
        this.cmdDeleteDemand.Margin = new Padding(0);
        this.cmdDeleteDemand.Name = "cmdDeleteDemand";
        this.cmdDeleteDemand.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteDemand.TabIndex = 107;
        this.cmdDeleteDemand.Tag = "1200";
        this.cmdDeleteDemand.Text = "Delete Demand";
        this.cmdDeleteDemand.UseVisualStyleBackColor = false;
        this.cmdDeleteDemand.Click += this.cmdDeleteDemand_Click;
        this.cmdSupply.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSupply.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSupply.Location = new Point(672, 0);
        this.cmdSupply.Margin = new Padding(0);
        this.cmdSupply.Name = "cmdSupply";
        this.cmdSupply.Size = new Size(96 /*0x60*/, 30);
        this.cmdSupply.TabIndex = 108;
        this.cmdSupply.Tag = "1200";
        this.cmdSupply.Text = "Add Supply";
        this.cmdSupply.UseVisualStyleBackColor = false;
        this.cmdSupply.Click += this.cmdSupply_Click;
        this.cmdEditSupply.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdEditSupply.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdEditSupply.Location = new Point(768 /*0x0300*/, 0);
        this.cmdEditSupply.Margin = new Padding(0);
        this.cmdEditSupply.Name = "cmdEditSupply";
        this.cmdEditSupply.Size = new Size(96 /*0x60*/, 30);
        this.cmdEditSupply.TabIndex = 109;
        this.cmdEditSupply.Tag = "1200";
        this.cmdEditSupply.Text = "Edit Supply";
        this.cmdEditSupply.UseVisualStyleBackColor = false;
        this.cmdEditSupply.Click += this.cmdEditSupply_Click;
        this.cmdDeleteSupply.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteSupply.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDeleteSupply.Location = new Point(864, 0);
        this.cmdDeleteSupply.Margin = new Padding(0);
        this.cmdDeleteSupply.Name = "cmdDeleteSupply";
        this.cmdDeleteSupply.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteSupply.TabIndex = 110;
        this.cmdDeleteSupply.Tag = "1200";
        this.cmdDeleteSupply.Text = "Delete Supply";
        this.cmdDeleteSupply.UseVisualStyleBackColor = false;
        this.cmdDeleteSupply.Click += this.cmdDeleteSupply_Click;
        this.flowLayoutPanel10.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel10.Controls.Add(this.rdoDestination);
        this.flowLayoutPanel10.Controls.Add(this.rdoSource);
        this.flowLayoutPanel10.Controls.Add(this.rdoStable);
        this.flowLayoutPanel10.Controls.Add(this.chkRestricted);
        this.flowLayoutPanel10.Controls.Add(this.chkAutoRefuel);
        this.flowLayoutPanel10.Location = new Point(6, 9);
        this.flowLayoutPanel10.Name = "flowLayoutPanel10";
        this.flowLayoutPanel10.Size = new Size(1018, 25);
        this.flowLayoutPanel10.TabIndex = 0;
        this.rdoDestination.AutoSize = true;
        this.rdoDestination.Checked = true;
        this.rdoDestination.Location = new Point(6, 3);
        this.rdoDestination.Margin = new Padding(6, 3, 3, 3);
        this.rdoDestination.Name = "rdoDestination";
        this.rdoDestination.Size = new Size(135, 17);
        this.rdoDestination.TabIndex = 95;
        this.rdoDestination.TabStop = true;
        this.rdoDestination.Text = "Destination of Colonists";
        this.rdoDestination.UseVisualStyleBackColor = true;
        this.rdoDestination.CheckedChanged += this.rdoStable_CheckedChanged;
        this.rdoSource.AutoSize = true;
        this.rdoSource.Location = new Point(150, 3);
        this.rdoSource.Margin = new Padding(6, 3, 3, 3);
        this.rdoSource.Name = "rdoSource";
        this.rdoSource.Size = new Size(116, 17);
        this.rdoSource.TabIndex = 96 /*0x60*/;
        this.rdoSource.Text = "Source of Colonists";
        this.rdoSource.UseVisualStyleBackColor = true;
        this.rdoSource.CheckedChanged += this.rdoStable_CheckedChanged;
        this.rdoStable.AutoSize = true;
        this.rdoStable.Location = new Point(275, 3);
        this.rdoStable.Margin = new Padding(6, 3, 3, 3);
        this.rdoStable.Name = "rdoStable";
        this.rdoStable.Size = new Size(186, 17);
        this.rdoStable.TabIndex = 97;
        this.rdoStable.Text = "Stable - Not Destination or Source";
        this.rdoStable.UseVisualStyleBackColor = true;
        this.rdoStable.CheckedChanged += this.rdoStable_CheckedChanged;
        this.chkRestricted.AutoSize = true;
        this.chkRestricted.Location = new Point(476, 3);
        this.chkRestricted.Margin = new Padding(12, 3, 3, 3);
        this.chkRestricted.Name = "chkRestricted";
        this.chkRestricted.Padding = new Padding(5, 0, 0, 0);
        this.chkRestricted.Size = new Size(149, 17);
        this.chkRestricted.TabIndex = 98;
        this.chkRestricted.Text = "Military Restricted Colony";
        this.chkRestricted.TextAlign = ContentAlignment.MiddleRight;
        this.chkRestricted.UseVisualStyleBackColor = true;
        this.chkRestricted.CheckedChanged += this.chkRestricted_CheckedChanged;
        this.chkAutoRefuel.AutoSize = true;
        this.chkAutoRefuel.Location = new Point(631, 3);
        this.chkAutoRefuel.Name = "chkAutoRefuel";
        this.chkAutoRefuel.Padding = new Padding(5, 0, 0, 0);
        this.chkAutoRefuel.Size = new Size(187, 17);
        this.chkAutoRefuel.TabIndex = 120;
        this.chkAutoRefuel.Text = "Destination for Automated Refuel";
        this.chkAutoRefuel.TextAlign = ContentAlignment.MiddleRight;
        this.chkAutoRefuel.UseVisualStyleBackColor = true;
        this.chkAutoRefuel.CheckedChanged += this.chkAutoRefuel_CheckedChanged;
        this.flowLayoutPanel8.Controls.Add(this.cboSMInstallations);
        this.flowLayoutPanel8.Controls.Add(this.lstvInstallations);
        this.flowLayoutPanel8.Location = new Point(6, 40);
        this.flowLayoutPanel8.Name = "flowLayoutPanel8";
        this.flowLayoutPanel8.Size = new Size(320, 756);
        this.flowLayoutPanel8.TabIndex = 137;
        this.cboSMInstallations.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSMInstallations.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboSMInstallations.FormattingEnabled = true;
        this.cboSMInstallations.Location = new Point(0, 3);
        this.cboSMInstallations.Margin = new Padding(0, 3, 3, 3);
        this.cboSMInstallations.Name = "cboSMInstallations";
        this.cboSMInstallations.Size = new Size(320, 21);
        this.cboSMInstallations.TabIndex = 99;
        this.lstvInstallations.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvInstallations.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_114,
            this.columnHeader_115
        });
        this.lstvInstallations.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvInstallations.FullRowSelect = true;
        this.lstvInstallations.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvInstallations.HideSelection = false;
        this.lstvInstallations.Location = new Point(0, 30);
        this.lstvInstallations.Margin = new Padding(0, 3, 3, 3);
        this.lstvInstallations.Name = "lstvInstallations";
        this.lstvInstallations.Size = new Size(320, 723);
        this.lstvInstallations.TabIndex = 135;
        this.lstvInstallations.UseCompatibleStateImageBehavior = false;
        this.lstvInstallations.View = View.Details;
        this.columnHeader_114.Text = "";
        this.columnHeader_114.Width = 230;
        this.columnHeader_115.Text = "";
        this.columnHeader_115.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_115.Width = 80 /*0x50*/;
        this.flowLayoutPanel7.Controls.Add(this.cboSupply);
        this.flowLayoutPanel7.Controls.Add(this.lstvSupply);
        this.flowLayoutPanel7.Location = new Point(681, 40);
        this.flowLayoutPanel7.Name = "flowLayoutPanel7";
        this.flowLayoutPanel7.Size = new Size(343, 756);
        this.flowLayoutPanel7.TabIndex = 136;
        this.cboSupply.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSupply.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboSupply.FormattingEnabled = true;
        this.cboSupply.Location = new Point(0, 3);
        this.cboSupply.Margin = new Padding(0, 3, 3, 3);
        this.cboSupply.Name = "cboSupply";
        this.cboSupply.Size = new Size(343, 21);
        this.cboSupply.TabIndex = 101;
        this.cboSupply.SelectedIndexChanged += this.cboSupply_SelectedIndexChanged;
        this.lstvSupply.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvSupply.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_110,
            this.columnHeader_111,
            this.columnHeader_116
        });
        this.lstvSupply.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvSupply.FullRowSelect = true;
        this.lstvSupply.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvSupply.HideSelection = false;
        this.lstvSupply.Location = new Point(0, 30);
        this.lstvSupply.Margin = new Padding(0, 3, 3, 3);
        this.lstvSupply.Name = "lstvSupply";
        this.lstvSupply.Size = new Size(343, 723);
        this.lstvSupply.TabIndex = 130;
        this.lstvSupply.UseCompatibleStateImageBehavior = false;
        this.lstvSupply.View = View.Details;
        this.columnHeader_110.Text = "";
        this.columnHeader_110.Width = 190;
        this.columnHeader_111.Text = "";
        this.columnHeader_111.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_111.Width = 70;
        this.columnHeader_116.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_116.Width = 70;
        this.flowLayoutPanel6.Controls.Add(this.cboDemand);
        this.flowLayoutPanel6.Controls.Add(this.lstvDemand);
        this.flowLayoutPanel6.Location = new Point(332, 40);
        this.flowLayoutPanel6.Name = "flowLayoutPanel6";
        this.flowLayoutPanel6.Size = new Size(343, 756);
        this.flowLayoutPanel6.TabIndex = 134;
        this.cboDemand.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboDemand.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboDemand.FormattingEnabled = true;
        this.cboDemand.Location = new Point(0, 3);
        this.cboDemand.Margin = new Padding(0, 3, 3, 3);
        this.cboDemand.Name = "cboDemand";
        this.cboDemand.Size = new Size(343, 21);
        this.cboDemand.TabIndex = 100;
        this.cboDemand.SelectedIndexChanged += this.cboDemand_SelectedIndexChanged;
        this.lstvDemand.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvDemand.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_112,
            this.columnHeader_113,
            this.columnHeader_117
        });
        this.lstvDemand.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvDemand.FullRowSelect = true;
        this.lstvDemand.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvDemand.HideSelection = false;
        this.lstvDemand.Location = new Point(0, 30);
        this.lstvDemand.Margin = new Padding(0, 3, 3, 3);
        this.lstvDemand.Name = "lstvDemand";
        this.lstvDemand.Size = new Size(343, 723);
        this.lstvDemand.TabIndex = 85;
        this.lstvDemand.UseCompatibleStateImageBehavior = false;
        this.lstvDemand.View = View.Details;
        this.columnHeader_112.Text = "";
        this.columnHeader_112.Width = 190;
        this.columnHeader_113.Text = "";
        this.columnHeader_113.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_113.Width = 70;
        this.columnHeader_117.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_117.Width = 70;
        this.tabStockpile.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabStockpile.Controls.Add(this.txtComponentDetail);
        this.tabStockpile.Controls.Add(this.flowLayoutPanel11);
        this.tabStockpile.Controls.Add(this.chkCreationDate);
        this.tabStockpile.Controls.Add(this.tvPopGU);
        this.tabStockpile.Controls.Add(this.lstvPopComponents);
        this.tabStockpile.Controls.Add(this.lstvPopMissiles);
        this.tabStockpile.Location = new Point(4, 22);
        this.tabStockpile.Name = "tabStockpile";
        this.tabStockpile.Padding = new Padding(3);
        this.tabStockpile.Size = new Size(1030, 836);
        this.tabStockpile.TabIndex = 6;
        this.tabStockpile.Text = "GU / Stockpiles";
        this.txtComponentDetail.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtComponentDetail.BorderStyle = BorderStyle.FixedSingle;
        this.txtComponentDetail.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.txtComponentDetail.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.txtComponentDetail.Location = new Point(404, 668);
        this.txtComponentDetail.Margin = new Padding(0, 0, 3, 3);
        this.txtComponentDetail.Multiline = true;
        this.txtComponentDetail.Name = "txtComponentDetail";
        this.txtComponentDetail.Size = new Size(623, 128 /*0x80*/);
        this.txtComponentDetail.TabIndex = 202;
        this.txtComponentDetail.Visible = false;
        this.flowLayoutPanel11.Controls.Add(this.cmdDisassemble);
        this.flowLayoutPanel11.Controls.Add(this.cmdDisassembleAll);
        this.flowLayoutPanel11.Controls.Add(this.cmdScrapComponent);
        this.flowLayoutPanel11.Controls.Add(this.cmdConvert);
        this.flowLayoutPanel11.Controls.Add(this.cmdResearchComponent);
        this.flowLayoutPanel11.Controls.Add(this.cmdTransferItem);
        this.flowLayoutPanel11.Controls.Add(this.cmdResearchMissile);
        this.flowLayoutPanel11.Controls.Add(this.cmdTransferOrdnance);
        this.flowLayoutPanel11.Controls.Add(this.cmdScrapMissile);
        this.flowLayoutPanel11.Controls.Add(this.cmdScrapAll);
        this.flowLayoutPanel11.FlowDirection = FlowDirection.RightToLeft;
        this.flowLayoutPanel11.Location = new Point(125, 801);
        this.flowLayoutPanel11.Name = "flowLayoutPanel11";
        this.flowLayoutPanel11.Size = new Size(902, 29);
        this.flowLayoutPanel11.TabIndex = 201;
        this.cmdDisassemble.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDisassemble.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDisassemble.Location = new Point(806, 0);
        this.cmdDisassemble.Margin = new Padding(0);
        this.cmdDisassemble.Name = "cmdDisassemble";
        this.cmdDisassemble.Size = new Size(96 /*0x60*/, 30);
        this.cmdDisassemble.TabIndex = 114;
        this.cmdDisassemble.Tag = "1200";
        this.cmdDisassemble.Text = "Disassemble";
        this.cmdDisassemble.UseVisualStyleBackColor = false;
        this.cmdDisassemble.Visible = false;
        this.cmdDisassemble.Click += this.cmdDisassemble_Click;
        this.cmdDisassembleAll.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDisassembleAll.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDisassembleAll.Location = new Point(710, 0);
        this.cmdDisassembleAll.Margin = new Padding(0);
        this.cmdDisassembleAll.Name = "cmdDisassembleAll";
        this.cmdDisassembleAll.Size = new Size(96 /*0x60*/, 30);
        this.cmdDisassembleAll.TabIndex = 113;
        this.cmdDisassembleAll.Tag = "1200";
        this.cmdDisassembleAll.Text = "Disassemble All";
        this.cmdDisassembleAll.UseVisualStyleBackColor = false;
        this.cmdDisassembleAll.Visible = false;
        this.cmdDisassembleAll.Click += this.cmdDisassembleAll_Click;
        this.cmdScrapComponent.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdScrapComponent.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdScrapComponent.Location = new Point(614, 0);
        this.cmdScrapComponent.Margin = new Padding(0);
        this.cmdScrapComponent.Name = "cmdScrapComponent";
        this.cmdScrapComponent.Size = new Size(96 /*0x60*/, 30);
        this.cmdScrapComponent.TabIndex = 112 /*0x70*/;
        this.cmdScrapComponent.Tag = "1200";
        this.cmdScrapComponent.Text = "Scrap Comp";
        this.cmdScrapComponent.UseVisualStyleBackColor = false;
        this.cmdScrapComponent.Visible = false;
        this.cmdScrapComponent.Click += this.cmdScrapComponent_Click;
        this.cmdConvert.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdConvert.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdConvert.Location = new Point(518, 0);
        this.cmdConvert.Margin = new Padding(0);
        this.cmdConvert.Name = "cmdConvert";
        this.cmdConvert.Size = new Size(96 /*0x60*/, 30);
        this.cmdConvert.TabIndex = 203;
        this.cmdConvert.Tag = "1200";
        this.cmdConvert.Text = "Modify for Use";
        this.cmdConvert.UseVisualStyleBackColor = false;
        this.cmdConvert.Visible = false;
        this.cmdConvert.Click += this.cmdConvert_Click;
        this.cmdResearchComponent.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdResearchComponent.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdResearchComponent.Location = new Point(422, 0);
        this.cmdResearchComponent.Margin = new Padding(0);
        this.cmdResearchComponent.Name = "cmdResearchComponent";
        this.cmdResearchComponent.Size = new Size(96 /*0x60*/, 30);
        this.cmdResearchComponent.TabIndex = 204;
        this.cmdResearchComponent.Tag = "1200";
        this.cmdResearchComponent.Text = "Research Comp";
        this.cmdResearchComponent.UseVisualStyleBackColor = false;
        this.cmdResearchComponent.Visible = false;
        this.cmdResearchComponent.Click += this.cmdResearchComponent_Click;
        this.cmdTransferItem.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdTransferItem.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdTransferItem.Location = new Point(326, 0);
        this.cmdTransferItem.Margin = new Padding(0);
        this.cmdTransferItem.Name = "cmdTransferItem";
        this.cmdTransferItem.Size = new Size(96 /*0x60*/, 30);
        this.cmdTransferItem.TabIndex = 200;
        this.cmdTransferItem.Tag = "1200";
        this.cmdTransferItem.Text = "Transfer Comp";
        this.cmdTransferItem.UseVisualStyleBackColor = false;
        this.cmdTransferItem.Visible = false;
        this.cmdTransferItem.Click += this.cmdTransferItem_Click;
        this.cmdResearchMissile.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdResearchMissile.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdResearchMissile.Location = new Point(230, 0);
        this.cmdResearchMissile.Margin = new Padding(0);
        this.cmdResearchMissile.Name = "cmdResearchMissile";
        this.cmdResearchMissile.Size = new Size(96 /*0x60*/, 30);
        this.cmdResearchMissile.TabIndex = 205;
        this.cmdResearchMissile.Tag = "1200";
        this.cmdResearchMissile.Text = "Research Missile";
        this.cmdResearchMissile.UseVisualStyleBackColor = false;
        this.cmdResearchMissile.Visible = false;
        this.cmdResearchMissile.Click += this.cmdResearchMissile_Click;
        this.cmdTransferOrdnance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdTransferOrdnance.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdTransferOrdnance.Location = new Point(134, 0);
        this.cmdTransferOrdnance.Margin = new Padding(0);
        this.cmdTransferOrdnance.Name = "cmdTransferOrdnance";
        this.cmdTransferOrdnance.Size = new Size(96 /*0x60*/, 30);
        this.cmdTransferOrdnance.TabIndex = 202;
        this.cmdTransferOrdnance.Tag = "1200";
        this.cmdTransferOrdnance.Text = "Transfer Missile";
        this.cmdTransferOrdnance.UseVisualStyleBackColor = false;
        this.cmdTransferOrdnance.Visible = false;
        this.cmdTransferOrdnance.Click += this.cmdTransferOrdnance_Click;
        this.cmdScrapMissile.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdScrapMissile.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdScrapMissile.Location = new Point(38, 0);
        this.cmdScrapMissile.Margin = new Padding(0);
        this.cmdScrapMissile.Name = "cmdScrapMissile";
        this.cmdScrapMissile.Size = new Size(96 /*0x60*/, 30);
        this.cmdScrapMissile.TabIndex = 111;
        this.cmdScrapMissile.Tag = "1200";
        this.cmdScrapMissile.Text = "Scrap Ordnance";
        this.cmdScrapMissile.UseVisualStyleBackColor = false;
        this.cmdScrapMissile.Visible = false;
        this.cmdScrapMissile.Click += this.cmdScrapMissile_Click;
        this.cmdScrapAll.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdScrapAll.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdScrapAll.Location = new Point(806, 30);
        this.cmdScrapAll.Margin = new Padding(0);
        this.cmdScrapAll.Name = "cmdScrapAll";
        this.cmdScrapAll.Size = new Size(96 /*0x60*/, 30);
        this.cmdScrapAll.TabIndex = 206;
        this.cmdScrapAll.Tag = "1200";
        this.cmdScrapAll.Text = "Scrap All";
        this.cmdScrapAll.UseVisualStyleBackColor = false;
        this.cmdScrapAll.Click += this.cmdScrapAll_Click;
        this.chkCreationDate.AutoSize = true;
        this.chkCreationDate.Location = new Point(6, 802);
        this.chkCreationDate.Name = "chkCreationDate";
        this.chkCreationDate.Size = new Size(113, 17);
        this.chkCreationDate.TabIndex = 199;
        this.chkCreationDate.Text = "Sort Creation Date";
        this.chkCreationDate.UseVisualStyleBackColor = true;
        this.chkCreationDate.CheckedChanged += this.chkCreationDate_CheckedChanged;
        this.tvPopGU.AllowDrop = true;
        this.tvPopGU.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvPopGU.BorderStyle = BorderStyle.FixedSingle;
        this.tvPopGU.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.tvPopGU.HideSelection = false;
        this.tvPopGU.Location = new Point(3, 3);
        this.tvPopGU.Margin = new Padding(3, 0, 0, 3);
        this.tvPopGU.Name = "tvPopGU";
        this.tvPopGU.Size = new Size(398, 793);
        this.tvPopGU.TabIndex = 115;
        this.lstvPopComponents.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvPopComponents.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_108,
            this.columnHeader_109
        });
        this.lstvPopComponents.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvPopComponents.FullRowSelect = true;
        this.lstvPopComponents.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvPopComponents.HideSelection = false;
        this.lstvPopComponents.Location = new Point(707, 3);
        this.lstvPopComponents.Name = "lstvPopComponents";
        this.lstvPopComponents.Size = new Size(320, 793);
        this.lstvPopComponents.TabIndex = 85;
        this.lstvPopComponents.UseCompatibleStateImageBehavior = false;
        this.lstvPopComponents.View = View.Details;
        this.lstvPopComponents.SelectedIndexChanged += this.lstvPopComponents_SelectedIndexChanged;
        this.columnHeader_108.Text = "";
        this.columnHeader_108.Width = 230;
        this.columnHeader_109.Text = "";
        this.columnHeader_109.TextAlign = HorizontalAlignment.Right;
        this.lstvPopMissiles.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvPopMissiles.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_106,
            this.columnHeader_107
        });
        this.lstvPopMissiles.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvPopMissiles.FullRowSelect = true;
        this.lstvPopMissiles.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvPopMissiles.HideSelection = false;
        this.lstvPopMissiles.Location = new Point(404, 3);
        this.lstvPopMissiles.Name = "lstvPopMissiles";
        this.lstvPopMissiles.Size = new Size(300, 793);
        this.lstvPopMissiles.TabIndex = 84;
        this.lstvPopMissiles.UseCompatibleStateImageBehavior = false;
        this.lstvPopMissiles.View = View.Details;
        this.lstvPopMissiles.SelectedIndexChanged += this.lstvPopMissiles_SelectedIndexChanged;
        this.columnHeader_106.Text = "";
        this.columnHeader_106.Width = 220;
        this.columnHeader_107.Text = "";
        this.columnHeader_107.TextAlign = HorizontalAlignment.Right;
        this.tabEnvironment.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabEnvironment.Controls.Add(this.flpSpecies);
        this.tabEnvironment.Controls.Add(this.flpColonyCostFactors);
        this.tabEnvironment.Controls.Add(this.lstvAtmosphere);
        this.tabEnvironment.Controls.Add(this.flpAddGas);
        this.tabEnvironment.Location = new Point(4, 22);
        this.tabEnvironment.Name = "tabEnvironment";
        this.tabEnvironment.Padding = new Padding(3);
        this.tabEnvironment.Size = new Size(1030, 836);
        this.tabEnvironment.TabIndex = 13;
        this.tabEnvironment.Text = "Environment";
        this.tabEnvironment.Click += this.tabEnvironment_Click;
        this.flpSpecies.BorderStyle = BorderStyle.FixedSingle;
        this.flpSpecies.Controls.Add(this.flowLayoutPanel21);
        this.flpSpecies.Controls.Add(this.flowLayoutPanel22);
        this.flpSpecies.Location = new Point(336, 300);
        this.flpSpecies.Name = "flpSpecies";
        this.flpSpecies.Size = new Size(286, 175);
        this.flpSpecies.TabIndex = 136;
        this.flowLayoutPanel21.Controls.Add(this.label34);
        this.flowLayoutPanel21.Controls.Add(this.label20);
        this.flowLayoutPanel21.Controls.Add(this.label21);
        this.flowLayoutPanel21.Controls.Add(this.label22);
        this.flowLayoutPanel21.Controls.Add(this.label31);
        this.flowLayoutPanel21.Controls.Add(this.label32);
        this.flowLayoutPanel21.Controls.Add(this.label33);
        this.flowLayoutPanel21.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel21.Location = new Point(0, 0);
        this.flowLayoutPanel21.Margin = new Padding(0);
        this.flowLayoutPanel21.Name = "flowLayoutPanel21";
        this.flowLayoutPanel21.Size = new Size(180, 174);
        this.flowLayoutPanel21.TabIndex = 99;
        this.flowLayoutPanel21.Paint += this.flowLayoutPanel21_Paint;
        this.label34.AutoSize = true;
        this.label34.Location = new Point(3, 3);
        this.label34.Margin = new Padding(3, 3, 0, 3);
        this.label34.Name = "label34";
        this.label34.Padding = new Padding(0, 5, 5, 0);
        this.label34.Size = new Size(103, 18);
        this.label34.TabIndex = 137;
        this.label34.Text = "Population Species";
        this.label20.AutoSize = true;
        this.label20.Location = new Point(3, 27);
        this.label20.Margin = new Padding(3, 3, 0, 3);
        this.label20.Name = "label20";
        this.label20.Padding = new Padding(0, 5, 5, 0);
        this.label20.Size = new Size(71, 18);
        this.label20.TabIndex = 95;
        this.label20.Text = "Breathe Gas";
        this.label21.AutoSize = true;
        this.label21.Location = new Point(3, 51);
        this.label21.Margin = new Padding(3, 3, 0, 3);
        this.label21.Name = "label21";
        this.label21.Padding = new Padding(0, 5, 5, 0);
        this.label21.Size = new Size(75, 18);
        this.label21.TabIndex = 96 /*0x60*/;
        this.label21.Text = "Breathe (atm)";
        this.label22.AutoSize = true;
        this.label22.Location = new Point(3, 75);
        this.label22.Margin = new Padding(3, 3, 0, 3);
        this.label22.Name = "label22";
        this.label22.Padding = new Padding(0, 5, 5, 0);
        this.label22.Size = new Size(63 /*0x3F*/, 18);
        this.label22.TabIndex = 97;
        this.label22.Text = "Safe Level";
        this.label31.AutoSize = true;
        this.label31.Location = new Point(3, 99);
        this.label31.Margin = new Padding(3, 3, 0, 3);
        this.label31.Name = "label31";
        this.label31.Padding = new Padding(0, 5, 5, 0);
        this.label31.Size = new Size(45, 18);
        this.label31.TabIndex = 95;
        this.label31.Text = "Gravity";
        this.label32.AutoSize = true;
        this.label32.Location = new Point(3, 123);
        this.label32.Margin = new Padding(3, 3, 0, 3);
        this.label32.Name = "label32";
        this.label32.Padding = new Padding(0, 5, 5, 0);
        this.label32.Size = new Size(72, 18);
        this.label32.TabIndex = 97;
        this.label32.Text = "Temperature";
        this.label33.AutoSize = true;
        this.label33.Location = new Point(3, 147);
        this.label33.Margin = new Padding(3, 3, 0, 3);
        this.label33.Name = "label33";
        this.label33.Padding = new Padding(0, 5, 5, 0);
        this.label33.Size = new Size(76, 18);
        this.label33.TabIndex = 96 /*0x60*/;
        this.label33.Text = "Max Pressure";
        this.flowLayoutPanel22.Controls.Add(this.label35);
        this.flowLayoutPanel22.Controls.Add(this.lblBreathe);
        this.flowLayoutPanel22.Controls.Add(this.lblOxygen);
        this.flowLayoutPanel22.Controls.Add(this.label23);
        this.flowLayoutPanel22.Controls.Add(this.lblGravity);
        this.flowLayoutPanel22.Controls.Add(this.lblTemperature);
        this.flowLayoutPanel22.Controls.Add(this.lblPressure);
        this.flowLayoutPanel22.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel22.Location = new Point(180, 0);
        this.flowLayoutPanel22.Margin = new Padding(0);
        this.flowLayoutPanel22.Name = "flowLayoutPanel22";
        this.flowLayoutPanel22.Size = new Size(102, 174);
        this.flowLayoutPanel22.TabIndex = 98;
        this.label35.AutoSize = true;
        this.label35.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.label35.Location = new Point(3, 3);
        this.label35.Margin = new Padding(3);
        this.label35.Name = "label35";
        this.label35.Padding = new Padding(0, 5, 5, 0);
        this.label35.Size = new Size(5, 18);
        this.label35.TabIndex = 137;
        this.label35.TextAlign = ContentAlignment.MiddleCenter;
        this.lblBreathe.AutoSize = true;
        this.lblBreathe.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblBreathe.Location = new Point(3, 27);
        this.lblBreathe.Margin = new Padding(3);
        this.lblBreathe.Name = "lblBreathe";
        this.lblBreathe.Padding = new Padding(0, 5, 5, 0);
        this.lblBreathe.Size = new Size(18, 18);
        this.lblBreathe.TabIndex = 98;
        this.lblBreathe.Text = "0";
        this.lblBreathe.TextAlign = ContentAlignment.MiddleCenter;
        this.lblOxygen.AutoSize = true;
        this.lblOxygen.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblOxygen.Location = new Point(3, 51);
        this.lblOxygen.Margin = new Padding(3);
        this.lblOxygen.Name = "lblOxygen";
        this.lblOxygen.Padding = new Padding(0, 5, 5, 0);
        this.lblOxygen.Size = new Size(18, 18);
        this.lblOxygen.TabIndex = 98;
        this.lblOxygen.Text = "0";
        this.lblOxygen.TextAlign = ContentAlignment.MiddleCenter;
        this.label23.AutoSize = true;
        this.label23.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.label23.Location = new Point(3, 75);
        this.label23.Margin = new Padding(3);
        this.label23.Name = "label23";
        this.label23.Padding = new Padding(0, 5, 5, 0);
        this.label23.Size = new Size(32 /*0x20*/, 18);
        this.label23.TabIndex = 99;
        this.label23.Text = "30%";
        this.label23.TextAlign = ContentAlignment.MiddleCenter;
        this.lblGravity.AutoSize = true;
        this.lblGravity.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblGravity.Location = new Point(3, 99);
        this.lblGravity.Margin = new Padding(3);
        this.lblGravity.Name = "lblGravity";
        this.lblGravity.Padding = new Padding(0, 5, 5, 0);
        this.lblGravity.Size = new Size(18, 18);
        this.lblGravity.TabIndex = 97;
        this.lblGravity.Text = "0";
        this.lblGravity.TextAlign = ContentAlignment.MiddleCenter;
        this.lblTemperature.AutoSize = true;
        this.lblTemperature.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblTemperature.Location = new Point(3, 123);
        this.lblTemperature.Margin = new Padding(3);
        this.lblTemperature.Name = "lblTemperature";
        this.lblTemperature.Padding = new Padding(0, 5, 5, 0);
        this.lblTemperature.Size = new Size(18, 18);
        this.lblTemperature.TabIndex = 99;
        this.lblTemperature.Text = "0";
        this.lblTemperature.TextAlign = ContentAlignment.MiddleCenter;
        this.lblPressure.AutoSize = true;
        this.lblPressure.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblPressure.Location = new Point(3, 147);
        this.lblPressure.Margin = new Padding(3);
        this.lblPressure.Name = "lblPressure";
        this.lblPressure.Padding = new Padding(0, 5, 5, 0);
        this.lblPressure.Size = new Size(18, 18);
        this.lblPressure.TabIndex = 97;
        this.lblPressure.Text = "0";
        this.lblPressure.TextAlign = ContentAlignment.MiddleCenter;
        this.flpColonyCostFactors.BorderStyle = BorderStyle.FixedSingle;
        this.flpColonyCostFactors.Controls.Add(this.flowLayoutPanel13);
        this.flpColonyCostFactors.Controls.Add(this.flowLayoutPanel14);
        this.flpColonyCostFactors.Location = new Point(336, 45);
        this.flpColonyCostFactors.Margin = new Padding(3, 0, 3, 0);
        this.flpColonyCostFactors.Name = "flpColonyCostFactors";
        this.flpColonyCostFactors.Size = new Size(286, 241);
        this.flpColonyCostFactors.TabIndex = 135;
        this.flpColonyCostFactors.WrapContents = false;
        this.flowLayoutPanel13.Controls.Add(this.label38);
        this.flowLayoutPanel13.Controls.Add(this.label25);
        this.flowLayoutPanel13.Controls.Add(this.label27);
        this.flowLayoutPanel13.Controls.Add(this.label26);
        this.flowLayoutPanel13.Controls.Add(this.label28);
        this.flowLayoutPanel13.Controls.Add(this.label29);
        this.flowLayoutPanel13.Controls.Add(this.label24);
        this.flowLayoutPanel13.Controls.Add(this.label30);
        this.flowLayoutPanel13.Controls.Add(this.label41);
        this.flowLayoutPanel13.Controls.Add(this.label42);
        this.flowLayoutPanel13.Location = new Point(0, 0);
        this.flowLayoutPanel13.Margin = new Padding(0);
        this.flowLayoutPanel13.Name = "flowLayoutPanel13";
        this.flowLayoutPanel13.Size = new Size(180, 240 /*0xF0*/);
        this.flowLayoutPanel13.TabIndex = 108;
        this.label38.AutoSize = true;
        this.label38.Location = new Point(3, 3);
        this.label38.Margin = new Padding(3);
        this.label38.Name = "label38";
        this.label38.Size = new Size(99, 13);
        this.label38.TabIndex = 103;
        this.label38.Text = "Overall Colony Cost";
        this.label25.AutoSize = true;
        this.label25.Location = new Point(3, 22);
        this.label25.Margin = new Padding(3);
        this.label25.Name = "label25";
        this.label25.Padding = new Padding(0, 5, 5, 0);
        this.label25.Size = new Size(105, 18);
        this.label25.TabIndex = 97;
        this.label25.Text = "Temperature Factor";
        this.label27.AutoSize = true;
        this.label27.Location = new Point(3, 46);
        this.label27.Margin = new Padding(3);
        this.label27.Name = "label27";
        this.label27.Padding = new Padding(0, 5, 5, 0);
        this.label27.Size = new Size(122, 18);
        this.label27.TabIndex = 99;
        this.label27.Text = "Breathable Atmosphere";
        this.label26.AutoSize = true;
        this.label26.Location = new Point(3, 70);
        this.label26.Margin = new Padding(3);
        this.label26.Name = "label26";
        this.label26.Padding = new Padding(0, 5, 5, 0);
        this.label26.Size = new Size(123, 18);
        this.label26.TabIndex = 98;
        this.label26.Text = "Dangerous Atmosphere";
        this.label28.AutoSize = true;
        this.label28.Location = new Point(3, 94);
        this.label28.Margin = new Padding(3);
        this.label28.Name = "label28";
        this.label28.Padding = new Padding(0, 5, 5, 0);
        this.label28.Size = new Size(114, 18);
        this.label28.TabIndex = 100;
        this.label28.Text = "Atmospheric Pressure";
        this.label29.AutoSize = true;
        this.label29.Location = new Point(3, 118);
        this.label29.Margin = new Padding(3);
        this.label29.Name = "label29";
        this.label29.Padding = new Padding(0, 5, 5, 0);
        this.label29.Size = new Size(87, 18);
        this.label29.TabIndex = 101;
        this.label29.Text = "Water Available";
        this.label24.AutoSize = true;
        this.label24.Location = new Point(3, 142);
        this.label24.Margin = new Padding(3);
        this.label24.Name = "label24";
        this.label24.Padding = new Padding(0, 5, 5, 0);
        this.label24.Size = new Size(102, 18);
        this.label24.TabIndex = 96 /*0x60*/;
        this.label24.Text = "Acceptable Gravity";
        this.label30.AutoSize = true;
        this.label30.Location = new Point(3, 166);
        this.label30.Margin = new Padding(3);
        this.label30.Name = "label30";
        this.label30.Padding = new Padding(0, 5, 5, 0);
        this.label30.Size = new Size(117, 18);
        this.label30.TabIndex = 102;
        this.label30.Text = "Atmosphere Retention";
        this.label41.AutoSize = true;
        this.label41.Location = new Point(3, 190);
        this.label41.Margin = new Padding(3);
        this.label41.Name = "label41";
        this.label41.Padding = new Padding(0, 4, 5, 0);
        this.label41.Size = new Size(117, 17);
        this.label41.TabIndex = 105;
        this.label41.Text = "Perihelion Colony Cost";
        this.label42.AutoSize = true;
        this.label42.Location = new Point(3, 213);
        this.label42.Margin = new Padding(3);
        this.label42.Name = "label42";
        this.label42.Padding = new Padding(0, 4, 5, 0);
        this.label42.Size = new Size(112 /*0x70*/, 17);
        this.label42.TabIndex = 106;
        this.label42.Text = "Aphelion Colony Cost";
        this.flowLayoutPanel14.Controls.Add(this.lblColonyCost);
        this.flowLayoutPanel14.Controls.Add(this.lblCCTemp);
        this.flowLayoutPanel14.Controls.Add(this.lblBreathable);
        this.flowLayoutPanel14.Controls.Add(this.lblDangerous);
        this.flowLayoutPanel14.Controls.Add(this.lblMaxPressure);
        this.flowLayoutPanel14.Controls.Add(this.lblWater);
        this.flowLayoutPanel14.Controls.Add(this.lblCCGravity);
        this.flowLayoutPanel14.Controls.Add(this.lblRetention);
        this.flowLayoutPanel14.Controls.Add(this.lblPerihelionCC);
        this.flowLayoutPanel14.Controls.Add(this.lblAphelionCC);
        this.flowLayoutPanel14.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel14.Location = new Point(180, 0);
        this.flowLayoutPanel14.Margin = new Padding(0);
        this.flowLayoutPanel14.Name = "flowLayoutPanel14";
        this.flowLayoutPanel14.Size = new Size(105, 240 /*0xF0*/);
        this.flowLayoutPanel14.TabIndex = 109;
        this.lblColonyCost.AutoSize = true;
        this.lblColonyCost.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblColonyCost.Location = new Point(3, 3);
        this.lblColonyCost.Margin = new Padding(3);
        this.lblColonyCost.Name = "lblColonyCost";
        this.lblColonyCost.Size = new Size(13, 13);
        this.lblColonyCost.TabIndex = 99;
        this.lblColonyCost.Text = "0";
        this.lblColonyCost.TextAlign = ContentAlignment.MiddleCenter;
        this.lblCCTemp.AutoSize = true;
        this.lblCCTemp.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblCCTemp.Location = new Point(3, 22);
        this.lblCCTemp.Margin = new Padding(3);
        this.lblCCTemp.Name = "lblCCTemp";
        this.lblCCTemp.Padding = new Padding(0, 5, 5, 0);
        this.lblCCTemp.Size = new Size(18, 18);
        this.lblCCTemp.TabIndex = 101;
        this.lblCCTemp.Text = "0";
        this.lblCCTemp.TextAlign = ContentAlignment.MiddleCenter;
        this.lblBreathable.AutoSize = true;
        this.lblBreathable.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblBreathable.Location = new Point(3, 46);
        this.lblBreathable.Margin = new Padding(3);
        this.lblBreathable.Name = "lblBreathable";
        this.lblBreathable.Padding = new Padding(0, 5, 5, 0);
        this.lblBreathable.Size = new Size(18, 18);
        this.lblBreathable.TabIndex = 102;
        this.lblBreathable.Text = "0";
        this.lblBreathable.TextAlign = ContentAlignment.MiddleCenter;
        this.lblDangerous.AutoSize = true;
        this.lblDangerous.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblDangerous.Location = new Point(3, 70);
        this.lblDangerous.Margin = new Padding(3);
        this.lblDangerous.Name = "lblDangerous";
        this.lblDangerous.Padding = new Padding(0, 5, 5, 0);
        this.lblDangerous.Size = new Size(18, 18);
        this.lblDangerous.TabIndex = 103;
        this.lblDangerous.Text = "0";
        this.lblDangerous.TextAlign = ContentAlignment.MiddleCenter;
        this.lblMaxPressure.AutoSize = true;
        this.lblMaxPressure.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblMaxPressure.Location = new Point(3, 94);
        this.lblMaxPressure.Margin = new Padding(3);
        this.lblMaxPressure.Name = "lblMaxPressure";
        this.lblMaxPressure.Padding = new Padding(0, 5, 5, 0);
        this.lblMaxPressure.Size = new Size(18, 18);
        this.lblMaxPressure.TabIndex = 104;
        this.lblMaxPressure.Text = "0";
        this.lblMaxPressure.TextAlign = ContentAlignment.MiddleCenter;
        this.lblWater.AutoSize = true;
        this.lblWater.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblWater.Location = new Point(3, 118);
        this.lblWater.Margin = new Padding(3);
        this.lblWater.Name = "lblWater";
        this.lblWater.Padding = new Padding(0, 5, 5, 0);
        this.lblWater.Size = new Size(18, 18);
        this.lblWater.TabIndex = 106;
        this.lblWater.Text = "0";
        this.lblWater.TextAlign = ContentAlignment.MiddleCenter;
        this.lblCCGravity.AutoSize = true;
        this.lblCCGravity.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblCCGravity.Location = new Point(3, 142);
        this.lblCCGravity.Margin = new Padding(3);
        this.lblCCGravity.Name = "lblCCGravity";
        this.lblCCGravity.Padding = new Padding(0, 5, 5, 0);
        this.lblCCGravity.Size = new Size(18, 18);
        this.lblCCGravity.TabIndex = 100;
        this.lblCCGravity.Text = "0";
        this.lblCCGravity.TextAlign = ContentAlignment.MiddleCenter;
        this.lblRetention.AutoSize = true;
        this.lblRetention.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblRetention.Location = new Point(3, 166);
        this.lblRetention.Margin = new Padding(3);
        this.lblRetention.Name = "lblRetention";
        this.lblRetention.Padding = new Padding(0, 5, 5, 0);
        this.lblRetention.Size = new Size(18, 18);
        this.lblRetention.TabIndex = 105;
        this.lblRetention.Text = "0";
        this.lblRetention.TextAlign = ContentAlignment.MiddleCenter;
        this.lblPerihelionCC.AutoSize = true;
        this.lblPerihelionCC.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblPerihelionCC.Location = new Point(3, 192 /*0xC0*/);
        this.lblPerihelionCC.Margin = new Padding(3, 5, 3, 3);
        this.lblPerihelionCC.Name = "lblPerihelionCC";
        this.lblPerihelionCC.Padding = new Padding(0, 2, 5, 0);
        this.lblPerihelionCC.Size = new Size(18, 15);
        this.lblPerihelionCC.TabIndex = 108;
        this.lblPerihelionCC.Text = "0";
        this.lblPerihelionCC.TextAlign = ContentAlignment.MiddleCenter;
        this.lblAphelionCC.AutoSize = true;
        this.lblAphelionCC.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.lblAphelionCC.Location = new Point(3, 215);
        this.lblAphelionCC.Margin = new Padding(3, 5, 3, 3);
        this.lblAphelionCC.Name = "lblAphelionCC";
        this.lblAphelionCC.Padding = new Padding(0, 2, 5, 0);
        this.lblAphelionCC.Size = new Size(18, 15);
        this.lblAphelionCC.TabIndex = 109;
        this.lblAphelionCC.Text = "0";
        this.lblAphelionCC.TextAlign = ContentAlignment.MiddleCenter;
        this.lstvAtmosphere.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvAtmosphere.BorderStyle = BorderStyle.FixedSingle;
        this.lstvAtmosphere.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_118,
            this.columnHeader_119,
            this.columnHeader_120
        });
        this.lstvAtmosphere.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvAtmosphere.FullRowSelect = true;
        this.lstvAtmosphere.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvAtmosphere.HideSelection = false;
        this.lstvAtmosphere.Location = new Point(5, 45);
        this.lstvAtmosphere.Margin = new Padding(3, 0, 3, 0);
        this.lstvAtmosphere.Name = "lstvAtmosphere";
        this.lstvAtmosphere.Size = new Size(325, 751);
        this.lstvAtmosphere.TabIndex = 134;
        this.lstvAtmosphere.UseCompatibleStateImageBehavior = false;
        this.lstvAtmosphere.View = View.Details;
        this.lstvAtmosphere.SelectedIndexChanged += this.lstvAtmosphere_SelectedIndexChanged;
        this.columnHeader_118.Width = 160 /*0xA0*/;
        this.columnHeader_119.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_119.Width = 80 /*0x50*/;
        this.columnHeader_120.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_120.Width = 80 /*0x50*/;
        this.flpAddGas.BorderStyle = BorderStyle.FixedSingle;
        this.flpAddGas.Controls.Add(this.cboGas);
        this.flpAddGas.Controls.Add(this.chkAddGas);
        this.flpAddGas.Controls.Add(this.label10);
        this.flpAddGas.Controls.Add(this.txtMaxAtm);
        this.flpAddGas.Controls.Add(this.cmdSMSetAtm);
        this.flpAddGas.Controls.Add(this.lblHydroExt);
        this.flpAddGas.Controls.Add(this.txtHydroExt);
        this.flpAddGas.Controls.Add(this.cmdHydroExt);
        this.flpAddGas.Location = new Point(3, 3);
        this.flpAddGas.Name = "flpAddGas";
        this.flpAddGas.Size = new Size(1024 /*0x0400*/, 37);
        this.flpAddGas.TabIndex = 54;
        this.cboGas.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboGas.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboGas.FormattingEnabled = true;
        this.cboGas.Location = new Point(3, 6);
        this.cboGas.Margin = new Padding(3, 6, 3, 0);
        this.cboGas.Name = "cboGas";
        this.cboGas.Size = new Size(217, 21);
        this.cboGas.TabIndex = 115;
        this.cboGas.SelectedIndexChanged += this.cboGas_SelectedIndexChanged;
        this.chkAddGas.AutoSize = true;
        this.chkAddGas.Location = new Point(241, 9);
        this.chkAddGas.Margin = new Padding(18, 9, 3, 3);
        this.chkAddGas.Name = "chkAddGas";
        this.chkAddGas.Size = new Size(138, 17);
        this.chkAddGas.TabIndex = 116;
        this.chkAddGas.Text = "Add Gas to Atmosphere";
        this.chkAddGas.UseVisualStyleBackColor = true;
        this.chkAddGas.CheckedChanged += this.chkAddGas_CheckedChanged;
        this.label10.AutoSize = true;
        this.label10.Location = new Point(400, 6);
        this.label10.Margin = new Padding(18, 6, 3, 0);
        this.label10.Name = "label10";
        this.label10.Padding = new Padding(0, 5, 5, 0);
        this.label10.Size = new Size(77, 18);
        this.label10.TabIndex = 96 /*0x60*/;
        this.label10.Text = "Maximum Atm";
        this.txtMaxAtm.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMaxAtm.BorderStyle = BorderStyle.None;
        this.txtMaxAtm.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtMaxAtm.Location = new Point(480, 11);
        this.txtMaxAtm.Margin = new Padding(0, 11, 3, 3);
        this.txtMaxAtm.Name = "txtMaxAtm";
        this.txtMaxAtm.Size = new Size(33, 13);
        this.txtMaxAtm.TabIndex = 117;
        this.txtMaxAtm.Text = "0";
        this.txtMaxAtm.TextAlign = HorizontalAlignment.Center;
        this.txtMaxAtm.TextChanged += this.txtMaxAtm_TextChanged;
        this.txtMaxAtm.Leave += this.txtMaxAtm_Leave;
        this.cmdSMSetAtm.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSMSetAtm.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSMSetAtm.Location = new Point(534, 3);
        this.cmdSMSetAtm.Margin = new Padding(18, 3, 12, 0);
        this.cmdSMSetAtm.Name = "cmdSMSetAtm";
        this.cmdSMSetAtm.Size = new Size(96 /*0x60*/, 30);
        this.cmdSMSetAtm.TabIndex = 118;
        this.cmdSMSetAtm.Tag = "1200";
        this.cmdSMSetAtm.Text = "SM: Set Atm";
        this.cmdSMSetAtm.UseVisualStyleBackColor = false;
        this.cmdSMSetAtm.Click += this.cmdSMSetAtm_Click;
        this.lblHydroExt.AutoSize = true;
        this.lblHydroExt.Location = new Point(660, 6);
        this.lblHydroExt.Margin = new Padding(18, 6, 3, 0);
        this.lblHydroExt.Name = "lblHydroExt";
        this.lblHydroExt.Padding = new Padding(0, 5, 5, 0);
        this.lblHydroExt.Size = new Size(73, 18);
        this.lblHydroExt.TabIndex = 100;
        this.lblHydroExt.Text = "Hydro Extent";
        this.txtHydroExt.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtHydroExt.BorderStyle = BorderStyle.None;
        this.txtHydroExt.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtHydroExt.Location = new Point(736, 11);
        this.txtHydroExt.Margin = new Padding(0, 11, 3, 3);
        this.txtHydroExt.Name = "txtHydroExt";
        this.txtHydroExt.Size = new Size(33, 13);
        this.txtHydroExt.TabIndex = 119;
        this.txtHydroExt.Text = "0";
        this.txtHydroExt.TextAlign = HorizontalAlignment.Center;
        this.txtHydroExt.TextChanged += this.txtHydroExt_TextChanged;
        this.txtHydroExt.Leave += this.txtHydroExt_Leave;
        this.cmdHydroExt.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdHydroExt.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdHydroExt.Location = new Point(782, 3);
        this.cmdHydroExt.Margin = new Padding(10, 3, 0, 0);
        this.cmdHydroExt.Name = "cmdHydroExt";
        this.cmdHydroExt.Size = new Size(96 /*0x60*/, 30);
        this.cmdHydroExt.TabIndex = 120;
        this.cmdHydroExt.Tag = "1200";
        this.cmdHydroExt.Text = "SM: Set Hydro";
        this.cmdHydroExt.UseVisualStyleBackColor = false;
        this.cmdHydroExt.Click += this.cmdHydroExt_Click;
        this.tabGovernor.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabGovernor.Controls.Add(this.panel2);
        this.tabGovernor.Controls.Add(this.flowLayoutPanel12);
        this.tabGovernor.Controls.Add(this.flowLayoutPanel24);
        this.tabGovernor.Controls.Add(this.flowLayoutPanel23);
        this.tabGovernor.Controls.Add(this.lstvGovernor);
        this.tabGovernor.Location = new Point(4, 22);
        this.tabGovernor.Name = "tabGovernor";
        this.tabGovernor.Padding = new Padding(3);
        this.tabGovernor.Size = new Size(1030, 836);
        this.tabGovernor.TabIndex = 16 /*0x10*/;
        this.tabGovernor.Text = "Governor / Misc";
        this.tabGovernor.Click += this.tabGovernor_Click;
        this.panel2.BorderStyle = BorderStyle.FixedSingle;
        this.panel2.Controls.Add(this.cboTransferRace);
        this.panel2.Controls.Add(this.cmdTransferPopulation);
        this.panel2.Location = new Point(815, 494);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(209, 77);
        this.panel2.TabIndex = 131;
        this.cboTransferRace.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboTransferRace.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboTransferRace.FormattingEnabled = true;
        this.cboTransferRace.Location = new Point(11, 44);
        this.cboTransferRace.Name = "cboTransferRace";
        this.cboTransferRace.Size = new Size(186, 21);
        this.cboTransferRace.TabIndex = 129;
        this.cmdTransferPopulation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdTransferPopulation.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdTransferPopulation.Location = new Point(11, 8);
        this.cmdTransferPopulation.Margin = new Padding(12, 6, 0, 0);
        this.cmdTransferPopulation.Name = "cmdTransferPopulation";
        this.cmdTransferPopulation.Size = new Size(186, 30);
        this.cmdTransferPopulation.TabIndex = 128 /*0x80*/;
        this.cmdTransferPopulation.Tag = "1200";
        this.cmdTransferPopulation.Text = "Transfer Population";
        this.cmdTransferPopulation.UseVisualStyleBackColor = false;
        this.cmdTransferPopulation.Click += this.cmdTransferPopulation_Click;
        this.flowLayoutPanel12.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel12.Controls.Add(this.label47);
        this.flowLayoutPanel12.Controls.Add(this.txtFuelWarning);
        this.flowLayoutPanel12.Controls.Add(this.label48);
        this.flowLayoutPanel12.Controls.Add(this.txtMSPWarning);
        this.flowLayoutPanel12.Controls.Add(this.rdoConstant);
        this.flowLayoutPanel12.Controls.Add(this.rdoSingleWarning);
        this.flowLayoutPanel12.Location = new Point(815, 397);
        this.flowLayoutPanel12.Name = "flowLayoutPanel12";
        this.flowLayoutPanel12.Size = new Size(209, 91);
        this.flowLayoutPanel12.TabIndex = 130;
        this.label47.AutoSize = true;
        this.label47.Location = new Point(3, 3);
        this.label47.Margin = new Padding(3, 3, 3, 0);
        this.label47.Name = "label47";
        this.label47.Padding = new Padding(0, 5, 5, 0);
        this.label47.Size = new Size(78, 18);
        this.label47.TabIndex = 131;
        this.label47.Text = "Fuel Warning ";
        this.txtFuelWarning.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtFuelWarning.BorderStyle = BorderStyle.None;
        this.txtFuelWarning.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtFuelWarning.Location = new Point(87, 8);
        this.txtFuelWarning.Margin = new Padding(3, 8, 3, 3);
        this.txtFuelWarning.Name = "txtFuelWarning";
        this.txtFuelWarning.Size = new Size(110, 13);
        this.txtFuelWarning.TabIndex = 130;
        this.txtFuelWarning.Text = "0";
        this.txtFuelWarning.TextAlign = HorizontalAlignment.Center;
        this.txtFuelWarning.TextChanged += this.txtFuelWarning_TextChanged;
        this.label48.AutoSize = true;
        this.label48.Location = new Point(3, 27);
        this.label48.Margin = new Padding(3, 3, 3, 0);
        this.label48.Name = "label48";
        this.label48.Padding = new Padding(0, 5, 5, 0);
        this.label48.Size = new Size(78, 18);
        this.label48.TabIndex = 133;
        this.label48.Text = "MSP Warning";
        this.txtMSPWarning.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMSPWarning.BorderStyle = BorderStyle.None;
        this.txtMSPWarning.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtMSPWarning.Location = new Point(87, 32 /*0x20*/);
        this.txtMSPWarning.Margin = new Padding(3, 8, 3, 3);
        this.txtMSPWarning.Name = "txtMSPWarning";
        this.txtMSPWarning.Size = new Size(110, 13);
        this.txtMSPWarning.TabIndex = 132;
        this.txtMSPWarning.Text = "0";
        this.txtMSPWarning.TextAlign = HorizontalAlignment.Center;
        this.txtMSPWarning.TextChanged += this.txtMSPWarning_TextChanged;
        this.rdoConstant.AutoSize = true;
        this.rdoConstant.Checked = true;
        this.rdoConstant.Location = new Point(12, 60);
        this.rdoConstant.Margin = new Padding(12, 12, 3, 3);
        this.rdoConstant.Name = "rdoConstant";
        this.rdoConstant.Size = new Size(67, 17);
        this.rdoConstant.TabIndex = 134;
        this.rdoConstant.TabStop = true;
        this.rdoConstant.Text = "Constant";
        this.rdoConstant.UseVisualStyleBackColor = true;
        this.rdoConstant.CheckedChanged += this.rdoSingleWarning_CheckedChanged;
        this.rdoSingleWarning.AutoSize = true;
        this.rdoSingleWarning.Location = new Point(85, 60);
        this.rdoSingleWarning.Margin = new Padding(3, 12, 3, 3);
        this.rdoSingleWarning.Name = "rdoSingleWarning";
        this.rdoSingleWarning.Size = new Size(97, 17);
        this.rdoSingleWarning.TabIndex = 135;
        this.rdoSingleWarning.Text = "Single Warning";
        this.rdoSingleWarning.UseVisualStyleBackColor = true;
        this.rdoSingleWarning.CheckedChanged += this.rdoSingleWarning_CheckedChanged;
        this.flowLayoutPanel24.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel24.Controls.Add(this.cmdSelectGovernor);
        this.flowLayoutPanel24.Controls.Add(this.cmdAssignGovernors);
        this.flowLayoutPanel24.Controls.Add(this.cmdReassignAllGovernors);
        this.flowLayoutPanel24.Location = new Point(814, 274);
        this.flowLayoutPanel24.Name = "flowLayoutPanel24";
        this.flowLayoutPanel24.Size = new Size(210, 117);
        this.flowLayoutPanel24.TabIndex = 129;
        this.cmdSelectGovernor.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSelectGovernor.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSelectGovernor.Location = new Point(12, 6);
        this.cmdSelectGovernor.Margin = new Padding(12, 6, 0, 0);
        this.cmdSelectGovernor.Name = "cmdSelectGovernor";
        this.cmdSelectGovernor.Size = new Size(186, 30);
        this.cmdSelectGovernor.TabIndex = sbyte.MaxValue;
        this.cmdSelectGovernor.Tag = "1200";
        this.cmdSelectGovernor.Text = "Assign Colony Governor";
        this.cmdSelectGovernor.UseVisualStyleBackColor = false;
        this.cmdSelectGovernor.Click += this.cmdSelectGovernor_Click;
        this.cmdAssignGovernors.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAssignGovernors.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdAssignGovernors.Location = new Point(12, 42);
        this.cmdAssignGovernors.Margin = new Padding(12, 6, 0, 0);
        this.cmdAssignGovernors.Name = "cmdAssignGovernors";
        this.cmdAssignGovernors.Size = new Size(186, 30);
        this.cmdAssignGovernors.TabIndex = 129;
        this.cmdAssignGovernors.Tag = "1200";
        this.cmdAssignGovernors.Text = "Assign Governor Vacancies";
        this.cmdAssignGovernors.UseVisualStyleBackColor = false;
        this.cmdAssignGovernors.Click += this.cmdAssignGovernors_Click;
        this.cmdReassignAllGovernors.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdReassignAllGovernors.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdReassignAllGovernors.Location = new Point(12, 78);
        this.cmdReassignAllGovernors.Margin = new Padding(12, 6, 0, 0);
        this.cmdReassignAllGovernors.Name = "cmdReassignAllGovernors";
        this.cmdReassignAllGovernors.Size = new Size(186, 30);
        this.cmdReassignAllGovernors.TabIndex = 128 /*0x80*/;
        this.cmdReassignAllGovernors.Tag = "1200";
        this.cmdReassignAllGovernors.Text = "Reassign All Colony Govenors";
        this.cmdReassignAllGovernors.UseVisualStyleBackColor = false;
        this.cmdReassignAllGovernors.Click += this.cmdReassignAllGovernors_Click;
        this.flowLayoutPanel23.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel23.Controls.Add(this.rdoYes);
        this.flowLayoutPanel23.Controls.Add(this.rdoNo);
        this.flowLayoutPanel23.Controls.Add(this.rdoNone);
        this.flowLayoutPanel23.Controls.Add(this.label37);
        this.flowLayoutPanel23.Controls.Add(this.txtImportance);
        this.flowLayoutPanel23.Controls.Add(this.label39);
        this.flowLayoutPanel23.Controls.Add(this.cboBonusOne);
        this.flowLayoutPanel23.Controls.Add(this.label36);
        this.flowLayoutPanel23.Controls.Add(this.cboBonusTwo);
        this.flowLayoutPanel23.Controls.Add(this.label40);
        this.flowLayoutPanel23.Controls.Add(this.cboBonusThree);
        this.flowLayoutPanel23.Location = new Point(814, 4);
        this.flowLayoutPanel23.Name = "flowLayoutPanel23";
        this.flowLayoutPanel23.Size = new Size(210, 264);
        this.flowLayoutPanel23.TabIndex = 126;
        this.rdoYes.AutoSize = true;
        this.rdoYes.Location = new Point(6, 3);
        this.rdoYes.Margin = new Padding(6, 3, 3, 3);
        this.rdoYes.Name = "rdoYes";
        this.rdoYes.Size = new Size(133, 17);
        this.rdoYes.TabIndex = 132;
        this.rdoYes.Text = "Automated Assignment";
        this.rdoYes.UseVisualStyleBackColor = true;
        this.rdoYes.CheckedChanged += this.rdoNone_CheckedChanged;
        this.rdoNo.AutoSize = true;
        this.rdoNo.Checked = true;
        this.rdoNo.Location = new Point(6, 26);
        this.rdoNo.Margin = new Padding(6, 3, 3, 3);
        this.rdoNo.Name = "rdoNo";
        this.rdoNo.Size = new Size(117, 17);
        this.rdoNo.TabIndex = 131;
        this.rdoNo.TabStop = true;
        this.rdoNo.Text = "Manual Assignment";
        this.rdoNo.UseVisualStyleBackColor = true;
        this.rdoNo.CheckedChanged += this.rdoNone_CheckedChanged;
        this.rdoNone.AutoSize = true;
        this.rdoNone.Location = new Point(6, 49);
        this.rdoNone.Margin = new Padding(6, 3, 3, 3);
        this.rdoNone.Name = "rdoNone";
        this.rdoNone.Size = new Size(96 /*0x60*/, 17);
        this.rdoNone.TabIndex = 130;
        this.rdoNone.Text = "No Assignment";
        this.rdoNone.UseVisualStyleBackColor = true;
        this.rdoNone.CheckedChanged += this.rdoNone_CheckedChanged;
        this.label37.AutoSize = true;
        this.label37.Location = new Point(3, 72);
        this.label37.Margin = new Padding(3);
        this.label37.Name = "label37";
        this.label37.Padding = new Padding(0, 5, 5, 0);
        this.label37.Size = new Size(149, 18);
        this.label37.TabIndex = 125;
        this.label37.Text = "Colony Importance (1 = High)";
        this.txtImportance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtImportance.BorderStyle = BorderStyle.None;
        this.txtImportance.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtImportance.Location = new Point(158, 77);
        this.txtImportance.Margin = new Padding(3, 8, 3, 3);
        this.txtImportance.Name = "txtImportance";
        this.txtImportance.Size = new Size(47, 13);
        this.txtImportance.TabIndex = 124;
        this.txtImportance.Text = "1";
        this.txtImportance.TextAlign = HorizontalAlignment.Center;
        this.txtImportance.TextChanged += this.txtImportance_TextChanged;
        this.label39.AutoSize = true;
        this.label39.Location = new Point(3, 102);
        this.label39.Margin = new Padding(3, 9, 3, 3);
        this.label39.Name = "label39";
        this.label39.Padding = new Padding(0, 5, 5, 0);
        this.label39.Size = new Size(88, 18);
        this.label39.TabIndex = 126;
        this.label39.Text = "Required Bonus";
        this.cboBonusOne.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboBonusOne.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboBonusOne.FormattingEnabled = true;
        this.cboBonusOne.Location = new Point(3, 126);
        this.cboBonusOne.Name = "cboBonusOne";
        this.cboBonusOne.Size = new Size(200, 21);
        this.cboBonusOne.TabIndex = 120;
        this.cboBonusOne.SelectedIndexChanged += this.cboBonusOne_SelectedIndexChanged;
        this.label36.AutoSize = true;
        this.label36.Location = new Point(3, 156);
        this.label36.Margin = new Padding(3, 6, 3, 3);
        this.label36.Name = "label36";
        this.label36.Padding = new Padding(0, 5, 5, 0);
        this.label36.Size = new Size(96 /*0x60*/, 18);
        this.label36.TabIndex = sbyte.MaxValue;
        this.label36.Text = "Secondary Bonus";
        this.cboBonusTwo.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboBonusTwo.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboBonusTwo.FormattingEnabled = true;
        this.cboBonusTwo.Location = new Point(3, 180);
        this.cboBonusTwo.Name = "cboBonusTwo";
        this.cboBonusTwo.Size = new Size(200, 21);
        this.cboBonusTwo.TabIndex = 121;
        this.cboBonusTwo.SelectedIndexChanged += this.cboBonusTwo_SelectedIndexChanged;
        this.label40.AutoSize = true;
        this.label40.Location = new Point(3, 210);
        this.label40.Margin = new Padding(3, 6, 3, 3);
        this.label40.Name = "label40";
        this.label40.Padding = new Padding(0, 5, 5, 0);
        this.label40.Size = new Size(80 /*0x50*/, 18);
        this.label40.TabIndex = 128 /*0x80*/;
        this.label40.Text = "Tertiary Bonus";
        this.cboBonusThree.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboBonusThree.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboBonusThree.FormattingEnabled = true;
        this.cboBonusThree.Location = new Point(3, 234);
        this.cboBonusThree.Name = "cboBonusThree";
        this.cboBonusThree.Size = new Size(200, 21);
        this.cboBonusThree.TabIndex = 122;
        this.cboBonusThree.SelectedIndexChanged += this.cboBonusThree_SelectedIndexChanged;
        this.lstvGovernor.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvGovernor.BorderStyle = BorderStyle.FixedSingle;
        this.lstvGovernor.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_127,
            this.columnHeader_128
        });
        this.lstvGovernor.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvGovernor.FullRowSelect = true;
        this.lstvGovernor.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvGovernor.HideSelection = false;
        this.lstvGovernor.Location = new Point(455, 4);
        this.lstvGovernor.Margin = new Padding(4, 3, 3, 3);
        this.lstvGovernor.Name = "lstvGovernor";
        this.lstvGovernor.Size = new Size(355, 827);
        this.lstvGovernor.TabIndex = 119;
        this.lstvGovernor.UseCompatibleStateImageBehavior = false;
        this.lstvGovernor.View = View.Details;
        this.columnHeader_127.Width = 175;
        this.columnHeader_128.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_128.Width = 175;
        this.tabPOW.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPOW.Controls.Add(this.cmdRelease);
        this.tabPOW.Controls.Add(this.flowLayoutPanel17);
        this.tabPOW.Controls.Add(this.lstvPOWOfficers);
        this.tabPOW.Location = new Point(4, 22);
        this.tabPOW.Name = "tabPOW";
        this.tabPOW.Padding = new Padding(3);
        this.tabPOW.Size = new Size(1030, 836);
        this.tabPOW.TabIndex = 17;
        this.tabPOW.Text = "POWs";
        this.cmdRelease.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRelease.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRelease.Location = new Point(4, 801);
        this.cmdRelease.Margin = new Padding(0);
        this.cmdRelease.Name = "cmdRelease";
        this.cmdRelease.Size = new Size(96 /*0x60*/, 30);
        this.cmdRelease.TabIndex = 138;
        this.cmdRelease.Tag = "1200";
        this.cmdRelease.Text = "Release";
        this.cmdRelease.UseVisualStyleBackColor = false;
        this.cmdRelease.Click += this.cmdRelease_Click;
        this.flowLayoutPanel17.Controls.Add(this.rdoPOWPop);
        this.flowLayoutPanel17.Controls.Add(this.rdoPOWEmpire);
        this.flowLayoutPanel17.Location = new Point(874, 805);
        this.flowLayoutPanel17.Name = "flowLayoutPanel17";
        this.flowLayoutPanel17.Size = new Size(150, 25);
        this.flowLayoutPanel17.TabIndex = 137;
        this.rdoPOWPop.AutoSize = true;
        this.rdoPOWPop.Checked = true;
        this.rdoPOWPop.Location = new Point(3, 3);
        this.rdoPOWPop.Name = "rdoPOWPop";
        this.rdoPOWPop.Size = new Size(75, 17);
        this.rdoPOWPop.TabIndex = 135;
        this.rdoPOWPop.TabStop = true;
        this.rdoPOWPop.Tag = "1";
        this.rdoPOWPop.Text = "Population";
        this.rdoPOWPop.UseVisualStyleBackColor = true;
        this.rdoPOWPop.CheckedChanged += this.rdoPOWEmpire_CheckedChanged;
        this.rdoPOWEmpire.AutoSize = true;
        this.rdoPOWEmpire.Location = new Point(84, 3);
        this.rdoPOWEmpire.Name = "rdoPOWEmpire";
        this.rdoPOWEmpire.Size = new Size(57, 17);
        this.rdoPOWEmpire.TabIndex = 136;
        this.rdoPOWEmpire.Text = "Empire";
        this.rdoPOWEmpire.UseVisualStyleBackColor = true;
        this.rdoPOWEmpire.CheckedChanged += this.rdoPOWEmpire_CheckedChanged;
        this.lstvPOWOfficers.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvPOWOfficers.BorderStyle = BorderStyle.FixedSingle;
        this.lstvPOWOfficers.Columns.AddRange(new ColumnHeader[6]
        {
            this.columnHeader_170,
            this.columnHeader_172,
            this.columnHeader_171,
            this.columnHeader_173,
            this.columnHeader_174,
            this.columnHeader_175
        });
        this.lstvPOWOfficers.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvPOWOfficers.FullRowSelect = true;
        this.lstvPOWOfficers.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvPOWOfficers.HideSelection = false;
        this.lstvPOWOfficers.Location = new Point(4, 5);
        this.lstvPOWOfficers.Margin = new Padding(4, 3, 3, 3);
        this.lstvPOWOfficers.Name = "lstvPOWOfficers";
        this.lstvPOWOfficers.Size = new Size(1021, 791);
        this.lstvPOWOfficers.TabIndex = 134;
        this.lstvPOWOfficers.UseCompatibleStateImageBehavior = false;
        this.lstvPOWOfficers.View = View.Details;
        this.lstvPOWOfficers.SelectedIndexChanged += this.lstvPOWOfficers_SelectedIndexChanged;
        this.columnHeader_170.Width = 150;
        this.columnHeader_172.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_171.Width = 150;
        this.columnHeader_173.Width = 170;
        this.columnHeader_174.Width = 320;
        this.columnHeader_175.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_175.Width = 100;
        this.tabEmpireMining.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabEmpireMining.Controls.Add(this.lstvEmpireMiningProduction);
        this.tabEmpireMining.Controls.Add(this.lstvEmpireStockpiles);
        this.tabEmpireMining.Location = new Point(4, 22);
        this.tabEmpireMining.Name = "tabEmpireMining";
        this.tabEmpireMining.Size = new Size(1030, 836);
        this.tabEmpireMining.TabIndex = 14;
        this.tabEmpireMining.Text = "Empire Mining";
        this.lstvEmpireMiningProduction.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvEmpireMiningProduction.BorderStyle = BorderStyle.FixedSingle;
        this.lstvEmpireMiningProduction.Columns.AddRange(new ColumnHeader[12]
        {
            this.columnHeader_148,
            this.columnHeader_149,
            this.columnHeader_150,
            this.columnHeader_151,
            this.columnHeader_152,
            this.columnHeader_153,
            this.columnHeader_154,
            this.columnHeader_155,
            this.columnHeader_156,
            this.columnHeader_157,
            this.columnHeader_158,
            this.columnHeader_159
        });
        this.lstvEmpireMiningProduction.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvEmpireMiningProduction.FullRowSelect = true;
        this.lstvEmpireMiningProduction.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvEmpireMiningProduction.HideSelection = false;
        this.lstvEmpireMiningProduction.LabelWrap = false;
        this.lstvEmpireMiningProduction.Location = new Point(4, 5);
        this.lstvEmpireMiningProduction.Margin = new Padding(4, 3, 3, 3);
        this.lstvEmpireMiningProduction.Name = "lstvEmpireMiningProduction";
        this.lstvEmpireMiningProduction.Size = new Size(1023 /*0x03FF*/, 486);
        this.lstvEmpireMiningProduction.TabIndex = 75;
        this.lstvEmpireMiningProduction.UseCompatibleStateImageBehavior = false;
        this.lstvEmpireMiningProduction.View = View.Details;
        this.columnHeader_148.Width = 175;
        this.columnHeader_149.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_149.Width = 75;
        this.columnHeader_150.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_150.Width = 75;
        this.columnHeader_151.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_151.Width = 75;
        this.columnHeader_152.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_152.Width = 75;
        this.columnHeader_153.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_153.Width = 75;
        this.columnHeader_154.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_154.Width = 75;
        this.columnHeader_155.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_155.Width = 75;
        this.columnHeader_156.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_156.Width = 75;
        this.columnHeader_157.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_157.Width = 75;
        this.columnHeader_158.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_158.Width = 75;
        this.columnHeader_159.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_159.Width = 75;
        this.lstvEmpireStockpiles.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvEmpireStockpiles.BorderStyle = BorderStyle.FixedSingle;
        this.lstvEmpireStockpiles.Columns.AddRange(new ColumnHeader[12]
        {
            this.columnHeader_130,
            this.columnHeader_131,
            this.columnHeader_132,
            this.columnHeader_133,
            this.columnHeader_134,
            this.columnHeader_135,
            this.columnHeader_136,
            this.columnHeader_137,
            this.columnHeader_138,
            this.columnHeader_139,
            this.columnHeader_140,
            this.columnHeader_141
        });
        this.lstvEmpireStockpiles.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvEmpireStockpiles.FullRowSelect = true;
        this.lstvEmpireStockpiles.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvEmpireStockpiles.HideSelection = false;
        this.lstvEmpireStockpiles.LabelWrap = false;
        this.lstvEmpireStockpiles.Location = new Point(4, 497);
        this.lstvEmpireStockpiles.Margin = new Padding(4, 3, 3, 3);
        this.lstvEmpireStockpiles.Name = "lstvEmpireStockpiles";
        this.lstvEmpireStockpiles.Size = new Size(1023 /*0x03FF*/, 336);
        this.lstvEmpireStockpiles.TabIndex = 74;
        this.lstvEmpireStockpiles.UseCompatibleStateImageBehavior = false;
        this.lstvEmpireStockpiles.View = View.Details;
        this.columnHeader_130.Width = 175;
        this.columnHeader_131.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_131.Width = 75;
        this.columnHeader_132.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_132.Width = 75;
        this.columnHeader_133.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_133.Width = 75;
        this.columnHeader_134.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_134.Width = 75;
        this.columnHeader_135.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_135.Width = 75;
        this.columnHeader_136.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_136.Width = 75;
        this.columnHeader_137.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_137.Width = 75;
        this.columnHeader_138.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_138.Width = 75;
        this.columnHeader_139.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_139.Width = 75;
        this.columnHeader_140.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_140.Width = 75;
        this.columnHeader_141.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_141.Width = 75;
        this.tabAncientConstruct.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabAncientConstruct.Controls.Add(this.lstvConstructs);
        this.tabAncientConstruct.Location = new Point(4, 22);
        this.tabAncientConstruct.Name = "tabAncientConstruct";
        this.tabAncientConstruct.Padding = new Padding(3);
        this.tabAncientConstruct.Size = new Size(1030, 836);
        this.tabAncientConstruct.TabIndex = 15;
        this.tabAncientConstruct.Text = "Constructs";
        this.lstvConstructs.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvConstructs.BorderStyle = BorderStyle.FixedSingle;
        this.lstvConstructs.Columns.AddRange(new ColumnHeader[7]
        {
            this.columnHeader_121,
            this.columnHeader_122,
            this.columnHeader_123,
            this.columnHeader_129,
            this.columnHeader_124,
            this.columnHeader_125,
            this.columnHeader_126
        });
        this.lstvConstructs.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvConstructs.FullRowSelect = true;
        this.lstvConstructs.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvConstructs.HideSelection = false;
        this.lstvConstructs.Location = new Point(3, 3);
        this.lstvConstructs.Margin = new Padding(3, 0, 3, 0);
        this.lstvConstructs.Name = "lstvConstructs";
        this.lstvConstructs.Size = new Size(1024 /*0x0400*/, 830);
        this.lstvConstructs.TabIndex = 135;
        this.lstvConstructs.UseCompatibleStateImageBehavior = false;
        this.lstvConstructs.View = View.Details;
        this.columnHeader_121.Width = 200;
        this.columnHeader_122.Width = 200;
        this.columnHeader_123.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_123.Width = 80 /*0x50*/;
        this.columnHeader_129.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_129.Width = 80 /*0x50*/;
        this.columnHeader_124.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_124.Width = 80 /*0x50*/;
        this.columnHeader_125.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_125.Width = 200;
        this.columnHeader_126.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_126.Width = 100;
        this.tabMineralData.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabMineralData.Controls.Add(this.flowLayoutPanel27);
        this.tabMineralData.Controls.Add(this.lstvMineralData);
        this.tabMineralData.Location = new Point(4, 22);
        this.tabMineralData.Name = "tabMineralData";
        this.tabMineralData.Padding = new Padding(3);
        this.tabMineralData.Size = new Size(1030, 836);
        this.tabMineralData.TabIndex = 18;
        this.tabMineralData.Text = "Mineral Data";
        this.flowLayoutPanel27.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel27.Controls.Add(this.chkCurrentPopulation);
        this.flowLayoutPanel27.Controls.Add(this.rdoMinMonth);
        this.flowLayoutPanel27.Controls.Add(this.rdoMin3Months);
        this.flowLayoutPanel27.Controls.Add(this.rdoMin6Months);
        this.flowLayoutPanel27.Controls.Add(this.rdoMinYear);
        this.flowLayoutPanel27.Location = new Point(3, 616);
        this.flowLayoutPanel27.Name = "flowLayoutPanel27";
        this.flowLayoutPanel27.Size = new Size(507, 28);
        this.flowLayoutPanel27.TabIndex = 120;
        this.chkCurrentPopulation.AutoSize = true;
        this.chkCurrentPopulation.Location = new Point(3, 3);
        this.chkCurrentPopulation.Name = "chkCurrentPopulation";
        this.chkCurrentPopulation.Size = new Size(137, 17);
        this.chkCurrentPopulation.TabIndex = 117;
        this.chkCurrentPopulation.Text = "Current Population Only";
        this.chkCurrentPopulation.UseVisualStyleBackColor = true;
        this.chkCurrentPopulation.CheckedChanged += this.chkCurrentPopulation_CheckedChanged;
        this.rdoMinMonth.AutoSize = true;
        this.rdoMinMonth.Checked = true;
        this.rdoMinMonth.Location = new Point(146, 3);
        this.rdoMinMonth.Name = "rdoMinMonth";
        this.rdoMinMonth.Size = new Size(78, 17);
        this.rdoMinMonth.TabIndex = 91;
        this.rdoMinMonth.TabStop = true;
        this.rdoMinMonth.Text = "One Month";
        this.rdoMinMonth.UseVisualStyleBackColor = true;
        this.rdoMinMonth.CheckedChanged += this.rdoMinYear_CheckedChanged;
        this.rdoMin3Months.AutoSize = true;
        this.rdoMin3Months.Location = new Point(230, 3);
        this.rdoMin3Months.Name = "rdoMin3Months";
        this.rdoMin3Months.Size = new Size(91, 17);
        this.rdoMin3Months.TabIndex = 92;
        this.rdoMin3Months.Text = "Three Months";
        this.rdoMin3Months.UseVisualStyleBackColor = true;
        this.rdoMin3Months.CheckedChanged += this.rdoMinYear_CheckedChanged;
        this.rdoMin6Months.AutoSize = true;
        this.rdoMin6Months.Location = new Point(327, 3);
        this.rdoMin6Months.Name = "rdoMin6Months";
        this.rdoMin6Months.Size = new Size(77, 17);
        this.rdoMin6Months.TabIndex = 93;
        this.rdoMin6Months.Text = "Six Months";
        this.rdoMin6Months.UseVisualStyleBackColor = true;
        this.rdoMin6Months.CheckedChanged += this.rdoMinYear_CheckedChanged;
        this.rdoMinYear.AutoSize = true;
        this.rdoMinYear.Location = new Point(410, 3);
        this.rdoMinYear.Name = "rdoMinYear";
        this.rdoMinYear.Size = new Size(70, 17);
        this.rdoMinYear.TabIndex = 94;
        this.rdoMinYear.Text = "One Year";
        this.rdoMinYear.UseVisualStyleBackColor = true;
        this.rdoMinYear.CheckedChanged += this.rdoMinYear_CheckedChanged;
        this.lstvMineralData.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvMineralData.BorderStyle = BorderStyle.FixedSingle;
        this.lstvMineralData.Columns.AddRange(new ColumnHeader[12]
        {
            this.columnHeader_176,
            this.columnHeader_177,
            this.columnHeader_178,
            this.columnHeader_179,
            this.columnHeader_180,
            this.columnHeader_181,
            this.columnHeader_182,
            this.columnHeader_183,
            this.columnHeader_184,
            this.columnHeader_185,
            this.columnHeader_186,
            this.columnHeader_187
        });
        this.lstvMineralData.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvMineralData.FullRowSelect = true;
        this.lstvMineralData.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvMineralData.HideSelection = false;
        this.lstvMineralData.LabelWrap = false;
        this.lstvMineralData.Location = new Point(3, 3);
        this.lstvMineralData.Margin = new Padding(4, 3, 3, 3);
        this.lstvMineralData.Name = "lstvMineralData";
        this.lstvMineralData.Size = new Size(1023 /*0x03FF*/, 607);
        this.lstvMineralData.TabIndex = 75;
        this.lstvMineralData.UseCompatibleStateImageBehavior = false;
        this.lstvMineralData.View = View.Details;
        this.columnHeader_176.Width = 175;
        this.columnHeader_177.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_177.Width = 75;
        this.columnHeader_178.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_178.Width = 75;
        this.columnHeader_179.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_179.Width = 75;
        this.columnHeader_180.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_180.Width = 75;
        this.columnHeader_181.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_181.Width = 75;
        this.columnHeader_182.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_182.Width = 75;
        this.columnHeader_183.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_183.Width = 75;
        this.columnHeader_184.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_184.Width = 75;
        this.columnHeader_185.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_185.Width = 75;
        this.columnHeader_186.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_186.Width = 75;
        this.columnHeader_187.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_187.Width = 75;
        this.chkShowSystemBody.AutoSize = true;
        this.chkShowSystemBody.Location = new Point(3, 3);
        this.chkShowSystemBody.Name = "chkShowSystemBody";
        this.chkShowSystemBody.Padding = new Padding(5, 0, 0, 0);
        this.chkShowSystemBody.Size = new Size(92, 17);
        this.chkShowSystemBody.TabIndex = 3;
        this.chkShowSystemBody.Text = "System Body";
        this.chkShowSystemBody.TextAlign = ContentAlignment.MiddleRight;
        this.chkShowSystemBody.UseVisualStyleBackColor = true;
        this.chkShowSystemBody.CheckedChanged += this.chkShowStars_CheckedChanged;
        this.chkByFunction.AutoSize = true;
        this.chkByFunction.Location = new Point(242, 3);
        this.chkByFunction.Name = "chkByFunction";
        this.chkByFunction.Size = new Size(82, 17);
        this.chkByFunction.TabIndex = 6;
        this.chkByFunction.Text = "By Function";
        this.chkByFunction.TextAlign = ContentAlignment.MiddleRight;
        this.chkByFunction.UseVisualStyleBackColor = true;
        this.chkByFunction.CheckedChanged += this.chkShowStars_CheckedChanged;
        this.chkHideCMC.AutoSize = true;
        this.chkHideCMC.Location = new Point(157, 3);
        this.chkHideCMC.Name = "chkHideCMC";
        this.chkHideCMC.Padding = new Padding(5, 0, 0, 0);
        this.chkHideCMC.Size = new Size(79, 17);
        this.chkHideCMC.TabIndex = 5;
        this.chkHideCMC.Text = "Hide CMC";
        this.chkHideCMC.TextAlign = ContentAlignment.MiddleRight;
        this.chkHideCMC.UseVisualStyleBackColor = true;
        this.chkHideCMC.CheckedChanged += this.chkShowStars_CheckedChanged;
        this.timer_0.Interval = 10;
        this.timer_0.Tick += this.timer_0_Tick;
        this.flowLayoutPanel16.Controls.Add(this.chkShowSystemBody);
        this.flowLayoutPanel16.Controls.Add(this.chkShowStars);
        this.flowLayoutPanel16.Controls.Add(this.chkHideCMC);
        this.flowLayoutPanel16.Controls.Add(this.chkByFunction);
        this.flowLayoutPanel16.Location = new Point(4, 830);
        this.flowLayoutPanel16.Name = "flowLayoutPanel16";
        this.flowLayoutPanel16.Size = new Size(380, 22);
        this.flowLayoutPanel16.TabIndex = 45;
        this.chkShowStars.AutoSize = true;
        this.chkShowStars.Location = new Point(101, 3);
        this.chkShowStars.Name = "chkShowStars";
        this.chkShowStars.Padding = new Padding(5, 0, 0, 0);
        this.chkShowStars.Size = new Size(50, 17);
        this.chkShowStars.TabIndex = 4;
        this.chkShowStars.Text = "Star";
        this.chkShowStars.TextAlign = ContentAlignment.MiddleRight;
        this.chkShowStars.UseVisualStyleBackColor = true;
        this.chkShowStars.CheckedChanged += this.chkShowStars_CheckedChanged;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(1424, 862);
        this.Controls.Add(this.flowLayoutPanel16);
        this.Controls.Add(this.tabPopulation);
        this.Controls.Add(this.tvPopList);
        this.Controls.Add(this.cboRaces);
        this.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.KeyPreview = true;
        this.MaximizeBox = false;
        this.Name = nameof(Economics);
        this.Text = nameof(Economics);
        this.FormClosing += this.Economics_FormClosing;
        this.Load += this.Economics_Load;
        this.KeyDown += this.Economics_KeyDown;
        this.tabPopulation.ResumeLayout(false);
        this.tabSummary.ResumeLayout(false);
        this.tabSummary.PerformLayout();
        this.flowLayoutPanel15.ResumeLayout(false);
        this.flowLayoutPanel1.ResumeLayout(false);
        this.tabIndustry.ResumeLayout(false);
        this.pnlGeneticModification.ResumeLayout(false);
        this.pnlGeneticModification.PerformLayout();
        this.panel6.ResumeLayout(false);
        this.panel6.PerformLayout();
        this.panel5.ResumeLayout(false);
        this.panel5.PerformLayout();
        this.panel4.ResumeLayout(false);
        this.flowLayoutPanel19.ResumeLayout(false);
        this.flowLayoutPanel19.PerformLayout();
        this.tabMining.ResumeLayout(false);
        this.tabMining.PerformLayout();
        this.flowLayoutPanel26.ResumeLayout(false);
        this.flowLayoutPanel26.PerformLayout();
        this.flpPurchase.ResumeLayout(false);
        this.flpPurchase.PerformLayout();
        this.tabShipyards.ResumeLayout(false);
        this.panel3.ResumeLayout(false);
        this.panel3.PerformLayout();
        this.panel1.ResumeLayout(false);
        this.flowLayoutPanel9.ResumeLayout(false);
        this.flowLayoutPanel9.PerformLayout();
        this.tabSYTasks.ResumeLayout(false);
        this.flowLayoutPanel18.ResumeLayout(false);
        this.flowLayoutPanel18.PerformLayout();
        this.tabResearch.ResumeLayout(false);
        this.tabResearch.PerformLayout();
        this.flowLayoutPanel3.ResumeLayout(false);
        this.flowLayoutPanel3.PerformLayout();
        this.flpRPSort.ResumeLayout(false);
        this.flpRPSort.PerformLayout();
        this.flowLayoutPanel5.ResumeLayout(false);
        this.flowLayoutPanel5.PerformLayout();
        this.flowLayoutPanel4.ResumeLayout(false);
        this.flowLayoutPanel4.PerformLayout();
        this.flpCreateProjectsBar.ResumeLayout(false);
        this.flowLayoutPanel2.ResumeLayout(false);
        this.flowLayoutPanel20.ResumeLayout(false);
        this.flowLayoutPanel20.PerformLayout();
        this.tabGUTraining.ResumeLayout(false);
        this.tabGUTraining.PerformLayout();
        this.pnlStartingBuildPoints.ResumeLayout(false);
        this.pnlStartingBuildPoints.PerformLayout();
        this.tabWealth.ResumeLayout(false);
        this.tabWealth.PerformLayout();
        this.panel7.ResumeLayout(false);
        this.panel7.PerformLayout();
        this.tabCivilian.ResumeLayout(false);
        this.flowLayoutPanel25.ResumeLayout(false);
        this.flowLayoutPanel10.ResumeLayout(false);
        this.flowLayoutPanel10.PerformLayout();
        this.flowLayoutPanel8.ResumeLayout(false);
        this.flowLayoutPanel7.ResumeLayout(false);
        this.flowLayoutPanel6.ResumeLayout(false);
        this.tabStockpile.ResumeLayout(false);
        this.tabStockpile.PerformLayout();
        this.flowLayoutPanel11.ResumeLayout(false);
        this.tabEnvironment.ResumeLayout(false);
        this.flpSpecies.ResumeLayout(false);
        this.flowLayoutPanel21.ResumeLayout(false);
        this.flowLayoutPanel21.PerformLayout();
        this.flowLayoutPanel22.ResumeLayout(false);
        this.flowLayoutPanel22.PerformLayout();
        this.flpColonyCostFactors.ResumeLayout(false);
        this.flowLayoutPanel13.ResumeLayout(false);
        this.flowLayoutPanel13.PerformLayout();
        this.flowLayoutPanel14.ResumeLayout(false);
        this.flowLayoutPanel14.PerformLayout();
        this.flpAddGas.ResumeLayout(false);
        this.flpAddGas.PerformLayout();
        this.tabGovernor.ResumeLayout(false);
        this.panel2.ResumeLayout(false);
        this.flowLayoutPanel12.ResumeLayout(false);
        this.flowLayoutPanel12.PerformLayout();
        this.flowLayoutPanel24.ResumeLayout(false);
        this.flowLayoutPanel23.ResumeLayout(false);
        this.flowLayoutPanel23.PerformLayout();
        this.tabPOW.ResumeLayout(false);
        this.flowLayoutPanel17.ResumeLayout(false);
        this.flowLayoutPanel17.PerformLayout();
        this.tabEmpireMining.ResumeLayout(false);
        this.tabAncientConstruct.ResumeLayout(false);
        this.tabMineralData.ResumeLayout(false);
        this.flowLayoutPanel27.ResumeLayout(false);
        this.flowLayoutPanel27.PerformLayout();
        this.flowLayoutPanel16.ResumeLayout(false);
        this.flowLayoutPanel16.PerformLayout();
        this.ResumeLayout(false);
    }
}