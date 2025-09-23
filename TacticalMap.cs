// Decompiled with JetBrains decompiler
// Type: TacticalMap
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using Aurora.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
public class TacticalMap : Form
{
  public GClass0 gclass0_0;
  public GClass0 gclass0_1;
  private List<GClass87> list_0 = new List<GClass87>();
  public GClass21 gclass21_0;
  public GClass202 gclass202_0;
  public WayPointType wayPointType_0;
  public string string_0 = "";
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  public bool bool_0;
  public bool bool_1;
  public GClass214 gclass214_0;
  private GClass227 gclass227_0;
  private bool bool_2;
  private DateTime dateTime_0;
  private double double_0;
  private double double_1;
  private IContainer icontainer_0;
  private FlowLayoutPanel tlbMainToolbar;
  private Button cmdToolbarColony;
  private Button cmdToolbarIndustry;
  private Button cmdToolbarResearch;
  private Button cmdToolbarWealth;
  private Button cmdToolbarGroundForces;
  private Button cmdToolbarCommanders;
  private Button cmdToolbarClass;
  private Button cmdToolbarFleet;
  private Button cmdToolbarTurret;
  private Button cmdToolbarSystem;
  private Button cmdToolbarGalactic;
  private Button cmdToolbarRace;
  private Button cmdToolbarProject;
  private Button cmdToolbarComparison;
  private Button cmdToolbarMedals;
  private Button cmdToolbarTechnology;
  private Button cmdToolbarSurvey;
  private Button cmdToolbarSector;
  private Button cmdToolbarRefreshTactical;
  private Button cmdToolbarEvents;
  private Button cmdToolbarIntelligence;
  private Button cmdToolbarAuto;
  private FlowLayoutPanel flowLayoutPanel3;
  private Button cmdLeft;
  private Button cmdRight;
  private Button cmdZoomIn;
  private Button cmdUp;
  private Button cmdZoomOut;
  private Button cmdDown;
  private FlowLayoutPanel tblIncrement;
  private Button cmdIncrement;
  private Button cmdIncrement5S;
  private Button cmdIncrement30S;
  private Button cmdIncrement2M;
  private Button cmdIncrement5M;
  private Button cmdIncrement20M;
  private Button cmdIncrement1H;
  private Button cmdIncrement3H;
  private Button cmdIncrement8H;
  private Button cmdIncrement1D;
  private Button cmdIncrement5D;
  private Button cmdIncrement30D;
  private FlowLayoutPanel tblSubPulse;
  private Button cmdSubPulse;
  private Button cmdSubPulse5S;
  private Button cmdSubPulse30S;
  private Button cmdSubPulse2M;
  private Button cmdSubPulse5M;
  private Button cmdSubPulse20M;
  private Button cmdSubPulse1H;
  private Button cmdSubPulse3H;
  private Button cmdSubPulse8H;
  private Button cmdSubPulse1D;
  private Button cmdSubPulse5D;
  private Button cmdSubPulse30D;
  private FlowLayoutPanel flowLayoutPanel2;
  private ComboBox cboSystems;
  private TabControl tabSidebar;
  private TabPage tabDisplay;
  private FlowLayoutPanel flowLayoutPanelDisplay;
  private CheckBox chkEvents;
  private CheckBox chkColonies;
  private CheckBox chkWP;
  private CheckBox chkPlanets;
  private CheckBox chkDwarf;
  private CheckBox chkMoons;
  private CheckBox chkAst;
  private CheckBox chkFleets;
  private CheckBox chkMoveTail;
  private CheckBox chkEscorts;
  private CheckBox chkOrder;
  private CheckBox chkSL;
  private CheckBox chkGeoPoints;
  private CheckBox chkLifepods;
  private CheckBox chkWrecks;
  private CheckBox chkPackets;
  private CheckBox chkWaypoint;
  private CheckBox chkFiringRanges;
  private CheckBox chkFireControlRange;
  private CheckBox chkStarNames;
  private CheckBox chkPlanetNames;
  private CheckBox chkDwarfNames;
  private CheckBox chkMoonNames;
  private CheckBox chkAstNames;
  private CheckBox chkCometPath;
  private CheckBox chkStarOrbits;
  private CheckBox chkPlanetOrbits;
  private CheckBox chkDwarfOrbits;
  private CheckBox chkMoonOrbits;
  private CheckBox chkAsteroidOrbits;
  private CheckBox chkBearing;
  private CheckBox chkCentre;
  private CheckBox chkTAD;
  private CheckBox chkAstColOnly;
  private CheckBox chkAstMinOnly;
  private CheckBox chkMPC;
  private CheckBox chkCoordinates;
  private CheckBox chkNoOverlap;
  private CheckBox chkHideSL;
  private CheckBox chkSalvoOrigin;
  private CheckBox chkSalvoTarget;
  public ComboBox cboRaces;
  private Button cmdSM;
  private TabPage tabContacts;
  private FlowLayoutPanel flowLayoutPanelContacts;
  private FlowLayoutPanel flowLayoutPanel6;
  private CheckBox chkHostile;
  private CheckBox chkTracking;
  private CheckBox chkHideIDs;
  private CheckBox chkLostContacts;
  private CheckBox chkShowDist;
  private CheckBox chkHostileSensors;
  private CheckBox chkActiveOnly;
  private TabPage tabMinerals;
  private FlowLayoutPanel flowLayoutPanelMinerals;
  private TabPage tabJump;
  private FlowLayoutPanel flowLayoutPanelJump;
  private Label label2;
  private ListBox lstRuins;
  private Label label3;
  private ListBox lstAnomalies;
  private Label label4;
  private ListBox lstWrecks;
  private TreeView tvMinerals;
  private CheckBox chkSBSurvey;
  private CheckBox chkMinerals;
  private TabPage tabMineralText;
  private TextBox txtMinerals;
  private FlowLayoutPanel flowLayoutPanel4;
  private Label label7;
  private ComboBox cboContactRaceFilter;
  private Label label6;
  private FlowLayoutPanel flowLayoutPanel5;
  private TabPage tabBodyInfo;
  private TabPage tabAllBodies;
  private TabPage tabMilitary;
  private FlowLayoutPanel flowLayoutPanelMilitary;
  private CheckBox chkSystemOnly;
  private TreeView tvMilitary;
  private CheckBox chkShowCivilianOOB;
  private TreeView tvSystemBodies;
  private CheckBox chkNeutral;
  private CheckBox chkFriendly;
  private CheckBox chkAllied;
  private CheckBox chkCivilian;
  private TreeView tvContacts;
  private CheckBox chkContactsCurrentSystem;
  private FlowLayoutPanel flowLayoutPanel7;
  private ListView lstvMinerals;
  private ColumnHeader columnHeader_0;
  private ColumnHeader columnHeader_1;
  private ColumnHeader columnHeader_2;
  private ListView lstvBodyInfo;
  private ColumnHeader columnHeader_3;
  private ColumnHeader columnHeader_4;
  private CheckBox chkActiveSensors;
  private CheckBox chkPassive10;
  private CheckBox chkPassive100;
  private CheckBox ckNoSensors;
  private Button cmdToolbarSave;
  private Button cmdToolbarMissileDesign;
  private Button cmdToolbarGame;
  private TabPage tabWaypoints;
  private FlowLayoutPanel flowLayoutPanel8;
  private Button cmdNormalWP;
  private Button cmdLastClickedWP;
  private Button cmdRendezvousWP;
  private Button cmdPOIWP;
  private Button cmdUrgentPOIWP;
  private Button cmdDeleteWP;
  private ListView lstvWaypoints;
  private ColumnHeader columnHeader_5;
  private ColumnHeader columnHeader_6;
  private ColumnHeader columnHeader_7;
  private CheckBox chkPassive1000;
  private CheckBox chkAllRace;
  private CheckBox chkDisplayAllForms;
  private CheckBox chkPassive10000;
  private TabPage tabMisc;
  private Button cmdAddNameTheme;
  private Label label5;
  private TabPage tabGroundSurvey;
  private ListView lstvSurveySites;
  private ColumnHeader columnHeader_8;
  private ColumnHeader columnHeader_9;
  private Label label8;
  private Button cmdAddCmdrTheme;
  private CheckBox chkLostContactsOneYear;
  private Button cmdResetWindows;
  private Label lblVersion;
  private Button cmdToolbarMining;
  private CheckBox chkLostContactsOneDay;
  private Label lblLocation;
  private CheckBox chkHideOrbitFleets;
  private CheckBox chkEventsAllRaces;
  private FlowLayoutPanel flowLayoutPanel9;
  private CheckBox chkSelectedOrbit;
  private CheckBox chkUseHullNumbers;
  private Panel panel2;
  private Button cdmDeepSpaceLocation;
  private Panel panel1;
  private Panel panel3;
  private Button cmdCeaseFireAll;
  private CheckBox chkHideWreckIDs;
  private Button cmdMoveWaypoint;
  private Button cmdTempWaypoint;
  private Button cmdDeleteAll;
  private Button cmdEmpire;
  private Button button1;
  private Label label1;
  private Button cmdCreateFleetWaypoint;
  private Button cmdSetFleetWaypoint;

  public TacticalMap()
  {
    this.InitializeComponent();
    this.DoubleBuffered = true;
    this.MouseWheel += new MouseEventHandler(this.TacticalMap_MouseWheel);
  }

  private void TacticalMap_Load(object sender, EventArgs e)
  {
    try
    {
      this.method_0(0);
      this.dateTime_0 = DateTime.Now;
      this.lblVersion.Text = GClass226.string_0;
      this.gclass0_0.bool_10 = false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 138);
    }
  }

  public void method_0(int int_5)
  {
    try
    {
      if (int_5 == 0)
      {
        IEnumerator enumerator = new Class1181().method_0("select * from FCT_Game order by LastViewed desc").Rows.GetEnumerator();
        try
        {
          if (enumerator.MoveNext())
            int_5 = Convert.ToInt32(((DataRow) enumerator.Current)["GameID"]);
        }
        finally
        {
          if (enumerator is IDisposable disposable)
            disposable.Dispose();
        }
      }
      if (int_5 > 0)
      {
        this.gclass0_0 = this.method_3(int_5);
        this.gclass0_0.string_2 = "Aur";
        if (this.gclass0_0 == null)
          return;
        this.gclass0_0.method_636();
        foreach (GClass21 gclass21 in this.gclass0_0.dictionary_36.Values.Where<GClass21>((System.Func<GClass21, bool>) (gclass21_0 => gclass21_0.bool_0 && gclass21_0.genum6_0 == GEnum6.const_0)).ToList<GClass21>())
          gclass21.method_92();
        this.method_11();
        this.method_13();
        this.WindowState = FormWindowState.Maximized;
        this.gclass0_0.double_0 = (double) this.Width;
        this.gclass0_0.double_1 = (double) this.Height;
        this.gclass0_0.double_4 = this.gclass0_0.double_0 / 2.0;
        this.gclass0_0.double_5 = this.gclass0_0.double_1 / 2.0;
        this.gclass0_0.string_2 += "xe";
        this.gclass0_0.bool_9 = true;
        this.bool_2 = true;
        this.gclass0_0.method_577(this.cboRaces);
        this.gclass0_0.bool_9 = false;
        this.Refresh();
      }
      else
      {
        int num = (int) new GameDetails(this).ShowDialog();
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 139);
    }
  }

  public void method_1()
  {
    try
    {
      this.gclass0_0.bool_9 = true;
      this.gclass0_0.method_577(this.cboRaces);
      this.gclass0_0.bool_9 = false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3205);
    }
  }

  private void method_2()
  {
    try
    {
      int num = (int) new GameDetails(this).ShowDialog();
      if (this.gclass0_1.int_66 == this.gclass0_0.int_66)
        return;
      Cursor.Current = Cursors.WaitCursor;
      this.method_0(this.gclass0_1.int_66);
      Cursor.Current = Cursors.Default;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 140);
    }
  }

  public GClass0 method_3(int int_5)
  {
    try
    {
      GClass0 gclass0 = new GClass0(this);
      foreach (DataRow row in (InternalDataCollectionBase) new Class1181().method_0("select * from FCT_Game where GameID = " + int_5.ToString()).Rows)
      {
        gclass0.int_66 = Convert.ToInt32(row["GameID"]);
        gclass0.int_67 = Convert.ToInt32(row["DifficultyModifier"]);
        gclass0.int_106 = Convert.ToInt32(row["ResearchSpeed"]);
        gclass0.int_107 = Convert.ToInt32(row["TerraformingSpeed"]);
        gclass0.int_108 = Convert.ToInt32(row["SurveySpeed"]);
        gclass0.int_68 = Convert.ToInt32(row["NumberOfSystems"]);
        gclass0.int_69 = Convert.ToInt32(row["StartYear"]);
        gclass0.int_70 = Convert.ToInt32(row["LocalSystemChance"]);
        gclass0.int_71 = Convert.ToInt32(row["LocalSystemSpread"]);
        gclass0.int_72 = Convert.ToInt32(row["MinConstructionPeriod"]);
        gclass0.int_74 = Convert.ToInt32(row["RaceChance"]);
        gclass0.int_75 = Convert.ToInt32(row["RaceChanceNPR"]);
        gclass0.int_76 = Convert.ToInt32(row["NewRuinCreationChance"]);
        gclass0.int_77 = Convert.ToInt32(row["CivilianShippingLinesActive"]);
        gclass0.int_78 = Convert.ToInt32(row["AllowCivilianHarvesters"]);
        gclass0.int_105 = Convert.ToInt32(row["TechFromConquest"]);
        gclass0.int_79 = Convert.ToInt32(row["MinComets"]);
        gclass0.int_80 = Convert.ToInt32(row["OrbitalMotion"]);
        gclass0.int_81 = Convert.ToInt32(row["OrbitalMotionAst"]);
        gclass0.int_82 = Convert.ToInt32(row["PoliticalAdmirals"]);
        gclass0.int_87 = Convert.ToInt32(row["InexpFleets"]);
        gclass0.int_88 = Convert.ToInt32(row["AutoJumpGates"]);
        gclass0.int_89 = Convert.ToInt32(row["Precursors"]);
        gclass0.int_90 = Convert.ToInt32(row["Rakhas"]);
        gclass0.int_91 = Convert.ToInt32(row["Eldar"]);
        gclass0.int_92 = Convert.ToInt32(row["StarSwarm"]);
        gclass0.int_93 = Convert.ToInt32(row["Invaders"]);
        gclass0.int_99 = Convert.ToInt32(row["UseKnownStars"]);
        gclass0.int_94 = Convert.ToInt32(row["GenerateNPRs"]);
        gclass0.int_95 = Convert.ToInt32(row["HumanNPRs"]);
        gclass0.int_96 = Convert.ToInt32(row["GenerateNonTNOnly"]);
        gclass0.int_97 = Convert.ToInt32(row["NoOverhauls"]);
        gclass0.int_98 = Convert.ToInt32(row["RealisticPromotions"]);
        gclass0.int_83 = Convert.ToInt32(row["DefaultRaceID"]);
        gclass0.int_102 = Convert.ToInt32(row["NPRsGeneratePrecursors"]);
        gclass0.int_101 = Convert.ToInt32(row["NPRsGenerateSwarm"]);
        gclass0.int_103 = Convert.ToInt32(row["NPRsGenerateRifts"]);
        gclass0.int_104 = Convert.ToInt32(row["NPRsEncounterRaiders"]);
        gclass0.int_132 = Convert.ToInt32(row["SubPulseLength"]);
        gclass0.int_73 = Convert.ToInt32(row["MinGroundCombatPeriod"]);
        gclass0.int_100 = Convert.ToInt32(row["NonPlayerSystemDetection"]);
        gclass0.genum30_0 = (GEnum30) Convert.ToInt32(row["SolDisaster"]);
        gclass0.int_109 = Convert.ToInt32(row["MaxEventDays"]);
        gclass0.int_110 = Convert.ToInt32(row["MaxEventCount"]);
        gclass0.int_84 = Convert.ToInt32(row["ConstellationNames"]);
        gclass0.int_65 = Convert.ToInt32(row["EldarOpGroupProgression"]);
        gclass0.int_114 = Convert.ToInt32(row["LimitedLabs"]);
        gclass0.int_115 = Convert.ToInt32(row["OneSecondSubPulse"]);
        gclass0.int_117 = Convert.ToInt32(row["MinorRaceChance"]);
        gclass0.int_118 = Convert.ToInt32(row["PreIndustrialChance"]);
        gclass0.int_119 = Convert.ToInt32(row["ConventionalChance"]);
        gclass0.int_120 = Convert.ToInt32(row["LimitPlanetaryDistance"]);
        gclass0.int_121 = Convert.ToInt32(row["ParallelUniverse"]);
        gclass0.int_122 = Convert.ToInt32(row["UseThemeInKnownStars"]);
        gclass0.int_127 = Convert.ToInt32(row["NPRBaseTransits"]);
        gclass0.int_128 = Convert.ToInt32(row["NPRRandomTransits"]);
        gclass0.int_129 = Convert.ToInt32(row["NPRMaxSystems"]);
        gclass0.int_113 = Convert.ToInt32(row["RaiderSystems"]);
        gclass0.int_111 = Convert.ToInt32(row["SwarmSystems"]);
        gclass0.int_112 = Convert.ToInt32(row["InvaderSystems"]);
        gclass0.int_85 = Convert.ToInt32(row["StarEccentricity"]);
        gclass0.int_86 = Convert.ToInt32(row["GasGiantEffects"]);
        gclass0.int_116 = Convert.ToInt32(row["HostilityModifier"]);
        gclass0.decimal_0 = Convert.ToDecimal(row["GameTime"]);
        gclass0.decimal_1 = Convert.ToDecimal(row["LastGrowthTime"]);
        gclass0.decimal_2 = Convert.ToDecimal(row["LastGroundCombatTime"]);
        gclass0.decimal_5 = Convert.ToDecimal(row["PlayerExplorationTime"]);
        gclass0.decimal_6 = Convert.ToDecimal(row["TruceCountdown"]);
        gclass0.decimal_10 = Convert.ToDecimal(row["StartTimeEldar"]);
        gclass0.decimal_11 = Convert.ToDecimal(row["StartTimeSwarm"]);
        gclass0.decimal_12 = Convert.ToDecimal(row["StartTimeInvaders"]);
        gclass0.int_123 = Convert.ToInt32(row["EnhancedInvaders"]);
        gclass0.int_125 = Convert.ToInt32(row["EnhancedPrecursors"]);
        gclass0.int_124 = Convert.ToInt32(row["EnhancedSwarm"]);
        gclass0.int_126 = Convert.ToInt32(row["SwarmInvasion"]);
        gclass0.int_130 = Convert.ToInt32(row["MinimumSwarmRP"]);
        gclass0.bool_15 = Convert.ToBoolean(row["CurrentGroundCombat"]);
        gclass0.bool_4 = Convert.ToBoolean(row["chkOrders"]);
        gclass0.bool_5 = Convert.ToBoolean(row["chkOverhauls"]);
        gclass0.bool_6 = Convert.ToBoolean(row["chkShowJD"]);
        gclass0.string_0 = row["SMPassword"].ToString();
        gclass0.string_1 = row["GameName"].ToString();
      }
      return gclass0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 141);
      return (GClass0) null;
    }
  }

  private void TacticalMap_Paint(object sender, PaintEventArgs e)
  {
    try
    {
      Graphics graphics = e.Graphics;
      this.gclass0_0.method_705(graphics, this.Font, this.gclass202_0);
      if (this.chkEvents.CheckState == CheckState.Checked)
        this.list_0 = this.gclass0_0.method_566(this.gclass21_0, graphics, this.Font, this.chkEventsAllRaces.CheckState);
      this.gclass0_0.method_704(graphics, this.Font, this.gclass202_0);
      if (this.gclass227_0 != null)
        this.gclass227_0.method_1(graphics, this.Font, this.gclass202_0);
      if (this.gclass21_0 == null)
        return;
      this.Text = $"{this.gclass21_0.RaceTitle}   {this.gclass0_0.method_586(true)}   Racial Wealth {GClass226.smethod_38(this.gclass21_0.decimal_0)}";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 142);
    }
  }

  public void method_4(GClass21 gclass21_1)
  {
    try
    {
      this.bool_2 = true;
      this.cboRaces.SelectedItem = (object) gclass21_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 143);
    }
  }

  public void method_5()
  {
    try
    {
      GClass202 gclass202 = (GClass202) null;
      this.gclass21_0 = (GClass21) this.cboRaces.SelectedValue;
      this.gclass0_0.gclass21_0 = this.gclass21_0;
      this.Text = $"{this.gclass21_0.RaceTitle}   {this.gclass0_0.method_586(true)}   Racial Wealth {GClass226.smethod_38(this.gclass21_0.decimal_0)}";
      this.gclass21_0.method_326(this.cboContactRaceFilter, "All Races");
      List<GClass202> gclass202List = this.gclass21_0.method_321();
      this.gclass0_0.bool_9 = true;
      if (this.gclass202_0 != null)
      {
        if (this.gclass21_0.dictionary_0.Keys.Contains<int>(this.gclass202_0.gclass200_0.int_0))
          gclass202 = this.gclass21_0.dictionary_0[this.gclass202_0.gclass200_0.int_0];
      }
      else
        gclass202 = this.gclass21_0.method_190();
      this.cboSystems.DisplayMember = "Name";
      this.cboSystems.DataSource = (object) gclass202List;
      if (gclass202 != null)
        this.cboSystems.SelectedItem = (object) gclass202;
      this.gclass0_0.bool_9 = false;
      this.method_10();
      this.gclass21_0.method_334(this.lstRuins);
      this.gclass21_0.method_336(this.lstAnomalies);
      this.gclass21_0.method_339(this.lstWrecks);
      this.method_7();
      this.method_12();
      if (!this.bool_2)
        this.gclass0_0.method_511(this.gclass21_0, (object) this);
      this.bool_2 = false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 144 /*0x90*/);
    }
  }

  public void method_6()
  {
    try
    {
      GClass202 gclass202 = (GClass202) null;
      List<GClass202> gclass202List = this.gclass21_0.method_321();
      this.gclass0_0.bool_9 = true;
      if (this.gclass202_0 != null)
      {
        if (this.gclass21_0.dictionary_0.Keys.Contains<int>(this.gclass202_0.gclass200_0.int_0))
          gclass202 = this.gclass21_0.dictionary_0[this.gclass202_0.gclass200_0.int_0];
      }
      else
        gclass202 = this.gclass21_0.method_190();
      this.cboSystems.DisplayMember = "Name";
      this.cboSystems.DataSource = (object) gclass202List;
      if (gclass202 != null)
        this.cboSystems.SelectedItem = (object) gclass202;
      this.gclass0_0.bool_9 = false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3213);
    }
  }

  public void method_7()
  {
    try
    {
      this.gclass21_0.method_335(this.lstvSurveySites);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3208);
    }
  }

  private void cboRaces_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      this.method_5();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 145);
    }
  }

  public void method_8()
  {
    try
    {
      if (this.cboSystems.Items.Count != this.gclass21_0.dictionary_0.Count)
      {
        this.gclass202_0 = this.gclass21_0.dictionary_0.Values.OrderByDescending<GClass202, Decimal>((System.Func<GClass202, Decimal>) (gclass202_0 => gclass202_0.decimal_0)).FirstOrDefault<GClass202>();
        this.method_5();
      }
      else
      {
        this.gclass0_0.method_703(this.gclass202_0);
        this.Refresh();
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 146);
    }
  }

  public void method_9(GClass202 gclass202_1)
  {
    try
    {
      if (this.gclass21_0 != gclass202_1.gclass21_0)
        this.method_4(gclass202_1.gclass21_0);
      if (this.cboSystems.SelectedValue == gclass202_1 || !this.cboSystems.Items.Contains((object) gclass202_1))
        return;
      this.cboSystems.SelectedItem = (object) gclass202_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 147);
    }
  }

  private void cboSystems_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass0_0.bool_9)
        return;
      this.method_10();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 148);
    }
  }

  public void method_10()
  {
    try
    {
      this.gclass202_0 = (GClass202) this.cboSystems.SelectedValue;
      if (this.gclass202_0 == null)
        return;
      this.gclass21_0 = (GClass21) this.cboRaces.SelectedValue;
      this.gclass21_0.method_340(this.gclass202_0.gclass200_0, this.tvMinerals, this.txtMinerals);
      this.gclass202_0.method_14(this.lstvWaypoints);
      this.method_20();
      this.gclass21_0.method_385(this.gclass202_0, this.tvSystemBodies);
      if (this.chkContactsCurrentSystem.CheckState == CheckState.Checked)
        this.gclass21_0.method_317(this.tvContacts, (ListView) null, this.gclass202_0, false);
      else
        this.gclass21_0.method_318(this.tvContacts);
      this.gclass0_0.method_703(this.gclass202_0);
      this.Refresh();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 149);
    }
  }

  private void cboContactRaceFilter_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      this.gclass21_0.ContactFilterRace = (GClass110) this.cboContactRaceFilter.SelectedValue;
      if (this.gclass0_0.bool_9)
        return;
      this.Refresh();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 150);
    }
  }

  private void chkTracking_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass0_0.bool_9)
        return;
      CheckBox checkBox = (CheckBox) sender;
      this.gclass21_0.method_320(checkBox.Name, checkBox.CheckState);
      this.gclass0_0.bool_11 = GClass226.smethod_27(this.chkAllRace.CheckState);
      this.gclass0_0.bool_12 = GClass226.smethod_27(this.chkDisplayAllForms.CheckState);
      this.Refresh();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 151);
    }
  }

  private void chkShowCivilianOOB_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass0_0.bool_9)
        return;
      CheckBox checkBox = (CheckBox) sender;
      this.gclass21_0.method_320(checkBox.Name, checkBox.CheckState);
      switch (checkBox.Name)
      {
        case "chkSystemOnly":
        case "chkShowCivilianOOB":
          this.method_20();
          break;
        case "chkContactsCurrentSystem":
          if (checkBox.CheckState == CheckState.Checked)
          {
            this.gclass21_0.method_317(this.tvContacts, (ListView) null, this.gclass202_0, false);
            break;
          }
          this.gclass21_0.method_318(this.tvContacts);
          break;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 152);
    }
  }

  private void lstRuins_Click(object sender, EventArgs e)
  {
    GClass219 selectedValue = (GClass219) this.lstRuins.SelectedValue;
  }

  private void cmdIncrement30D_Click(object sender, EventArgs e)
  {
    try
    {
      this.gclass0_0.method_363((Button) sender, this.tblIncrement);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 153);
    }
    finally
    {
      Cursor.Current = Cursors.Default;
    }
  }

  private void cmdSubPulse30D_Click(object sender, EventArgs e)
  {
    try
    {
      Button button = (Button) sender;
      string name = button.Name;
      this.gclass0_0.int_133 = Convert.ToInt32(button.Tag);
      foreach (Control control in (ArrangedElementCollection) this.tblSubPulse.Controls)
      {
        control.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        if (control.Name == name)
          control.BackColor = Color.FromArgb(0, 0, 120);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 154);
    }
  }

  private void cmdRight_Click(object sender, EventArgs e)
  {
    try
    {
      bool bool_24 = false;
      Button button = (Button) sender;
      if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
        bool_24 = true;
      string name = button.Name;
      if (name != null)
      {
        switch (name.Length)
        {
          case 5:
            switch (name[3])
            {
              case 'S':
                if (name == "cmdSM")
                {
                  this.gclass21_0.method_175(button.Name, bool_24, this.gclass202_0);
                  this.method_13();
                  goto label_32;
                }
                break;
              case 'U':
                if (name == "cmdUp")
                {
                  this.gclass0_0.method_707(GEnum11.const_2, this.gclass202_0);
                  this.Refresh();
                  goto label_32;
                }
                break;
            }
            break;
          case 7:
            switch (name[3])
            {
              case 'D':
                if (name == "cmdDown")
                {
                  this.gclass0_0.method_707(GEnum11.const_3, this.gclass202_0);
                  this.Refresh();
                  goto label_32;
                }
                break;
              case 'L':
                if (name == "cmdLeft")
                {
                  this.gclass0_0.method_707(GEnum11.const_0, this.gclass202_0);
                  this.Refresh();
                  goto label_32;
                }
                break;
            }
            break;
          case 8:
            if (name == "cmdRight")
            {
              this.gclass0_0.method_707(GEnum11.const_1, this.gclass202_0);
              this.Refresh();
              goto label_32;
            }
            break;
          case 9:
            if (name == "cmdZoomIn")
            {
              this.gclass0_0.method_707(GEnum11.const_4, this.gclass202_0);
              this.gclass0_0.method_703(this.gclass202_0);
              this.Refresh();
              goto label_32;
            }
            break;
          case 10:
            if (name == "cmdZoomOut")
            {
              this.gclass0_0.method_707(GEnum11.const_5, this.gclass202_0);
              this.gclass0_0.method_703(this.gclass202_0);
              this.Refresh();
              goto label_32;
            }
            break;
          case 14:
            if (name == "cmdToolbarGame")
            {
              this.method_2();
              goto label_32;
            }
            break;
          case 16 /*0x10*/:
            if (name == "cmdToolbarSurvey")
            {
              Minerals minerals = Application.OpenForms.OfType<Minerals>().FirstOrDefault<Minerals>();
              if (minerals != null && !bool_24)
              {
                minerals.BringToFront();
                goto label_32;
              }
              new Minerals(this.gclass0_0, this).Show();
              goto label_32;
            }
            break;
          case 22:
            if (name == "cmdToolbarDesignerMode")
            {
              this.gclass0_0.bool_10 = !this.gclass0_0.bool_10;
              this.gclass0_0.method_526(GEnum38.const_2);
              this.gclass0_0.bool_9 = true;
              this.gclass0_0.method_577(this.cboRaces);
              this.gclass0_0.bool_9 = false;
              this.Refresh();
              goto label_32;
            }
            break;
          case 25:
            if (name == "cmdToolbarRefreshTactical")
            {
              this.method_5();
              goto label_32;
            }
            break;
        }
      }
      if (this.gclass21_0.method_175(button.Name, bool_24, this.gclass202_0))
        this.Refresh();
label_32:
      this.gclass0_0.method_515();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 155);
    }
  }

  private void TacticalMap_MouseWheel(object sender, MouseEventArgs e)
  {
    try
    {
      int delta = e.Delta;
      if (e.Delta < 0)
      {
        this.gclass0_0.method_707(GEnum11.const_5, this.gclass202_0);
        this.gclass0_0.method_703(this.gclass202_0);
        this.Refresh();
      }
      else
      {
        this.gclass0_0.method_707(GEnum11.const_4, this.gclass202_0);
        this.gclass0_0.method_703(this.gclass202_0);
        this.Refresh();
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 156);
    }
  }

  private void method_11()
  {
    ToolTip toolTip = new ToolTip();
    toolTip.AutoPopDelay = 2000;
    toolTip.InitialDelay = 750;
    toolTip.ReshowDelay = 500;
    toolTip.ShowAlways = true;
    toolTip.SetToolTip((Control) this.cmdToolbarColony, "Open Colony Summary Tab on the Colonies Window");
    toolTip.SetToolTip((Control) this.cmdToolbarIndustry, "Open Industry Tab on the Colonies Window");
    toolTip.SetToolTip((Control) this.cmdToolbarMining, "Open Mining Summary Tab on the Colonies Window");
    toolTip.SetToolTip((Control) this.cmdToolbarResearch, "Open Research Tab on the Colonies Window");
    toolTip.SetToolTip((Control) this.cmdToolbarWealth, "Open Wealth Tab on the Colonies Window");
    toolTip.SetToolTip((Control) this.cmdToolbarClass, "Open Class Design Window");
    toolTip.SetToolTip((Control) this.cmdToolbarProject, "Open Create Project Window");
    toolTip.SetToolTip((Control) this.cmdToolbarFleet, "Open Fleet Organization Window");
    toolTip.SetToolTip((Control) this.cmdToolbarMissileDesign, "Open Missile Design Window");
    toolTip.SetToolTip((Control) this.cmdToolbarTurret, "Open Turret Design Window");
    toolTip.SetToolTip((Control) this.cmdToolbarGroundForces, "Open Ground Forces Window");
    toolTip.SetToolTip((Control) this.cmdToolbarCommanders, "Open Commanders Window");
    toolTip.SetToolTip((Control) this.cmdToolbarMedals, "Open Medal Creation Window");
    toolTip.SetToolTip((Control) this.cmdToolbarRace, "Open Race Window");
    toolTip.SetToolTip((Control) this.cmdToolbarSystem, "Open System View Window");
    toolTip.SetToolTip((Control) this.cmdToolbarGalactic, "Open Galactic Map Window");
    toolTip.SetToolTip((Control) this.cmdToolbarComparison, "Open Race Comparison Window");
    toolTip.SetToolTip((Control) this.cmdToolbarIntelligence, "Open Intelligence Window");
    toolTip.SetToolTip((Control) this.cmdToolbarTechnology, "Open Technology Report Window");
    toolTip.SetToolTip((Control) this.cmdToolbarSurvey, "Open Mineral Survey Window");
    toolTip.SetToolTip((Control) this.cmdToolbarSector, "Open Sector Window");
    toolTip.SetToolTip((Control) this.cmdToolbarEvents, "Open Events Window");
    toolTip.SetToolTip((Control) this.cmdToolbarRefreshTactical, "Refresh the Tactical Map Window");
    toolTip.SetToolTip((Control) this.cmdToolbarSave, "Save Current Game");
    toolTip.SetToolTip((Control) this.cmdToolbarGame, "View Current Game and Create New Game");
    toolTip.SetToolTip((Control) this.cmdSM, "Spacemaster Mode On/Off");
    toolTip.SetToolTip((Control) this.cmdToolbarAuto, "Automated Turns On/Off");
    toolTip.SetToolTip((Control) this.cboRaces, "Select Default Races");
    toolTip.SetToolTip((Control) this.cboSystems, "Select System to View Tactical Map");
    toolTip.SetToolTip((Control) this.chkPassive10, "The range of passive sensors vs a signature of 10");
    toolTip.SetToolTip((Control) this.chkPassive100, "The range of passive sensors vs a signature of 100");
    this.gclass0_0.string_2 += "ora.e";
  }

  public void method_12()
  {
    try
    {
      this.chkStarOrbits.CheckState = this.gclass21_0.chkStarOrbits;
      this.chkPlanetOrbits.CheckState = this.gclass21_0.chkPlanetOrbits;
      this.chkDwarfOrbits.CheckState = this.gclass21_0.chkDwarfOrbits;
      this.chkMoonOrbits.CheckState = this.gclass21_0.chkMoonOrbits;
      this.chkAsteroidOrbits.CheckState = this.gclass21_0.chkAsteroidOrbits;
      this.chkSelectedOrbit.CheckState = this.gclass21_0.chkSelectedOrbit;
      this.chkPlanets.CheckState = this.gclass21_0.chkPlanets;
      this.chkDwarf.CheckState = this.gclass21_0.chkDwarf;
      this.chkMoons.CheckState = this.gclass21_0.chkMoons;
      this.chkAst.CheckState = this.gclass21_0.chkAst;
      this.chkWP.CheckState = this.gclass21_0.chkWP;
      this.chkEvents.CheckState = this.gclass21_0.chkEvents;
      this.chkEventsAllRaces.CheckState = this.gclass21_0.chkEventsAllRaces;
      this.chkStarNames.CheckState = this.gclass21_0.chkStarNames;
      this.chkPlanetNames.CheckState = this.gclass21_0.chkPlanetNames;
      this.chkDwarfNames.CheckState = this.gclass21_0.chkDwarfNames;
      this.chkMoonNames.CheckState = this.gclass21_0.chkMoonNames;
      this.chkAstNames.CheckState = this.gclass21_0.chkAstNames;
      this.chkFleets.CheckState = this.gclass21_0.chkFleets;
      this.chkMoveTail.CheckState = this.gclass21_0.chkMoveTail;
      this.chkColonies.CheckState = this.gclass21_0.chkColonies;
      this.chkCentre.CheckState = this.gclass21_0.chkCentre;
      this.chkSL.CheckState = this.gclass21_0.chkSL;
      this.chkWaypoint.CheckState = this.gclass21_0.chkWaypoint;
      this.chkOrder.CheckState = this.gclass21_0.chkOrder;
      this.chkNoOverlap.CheckState = this.gclass21_0.chkNoOverlap;
      this.chkActiveSensors.CheckState = this.gclass21_0.chkActiveSensors;
      this.chkUseHullNumbers.CheckState = this.gclass21_0.chkUseHullNumbers;
      this.chkPassive10.CheckState = this.gclass21_0.chkPassive10;
      this.chkPassive100.CheckState = this.gclass21_0.chkPassive100;
      this.chkPassive1000.CheckState = this.gclass21_0.chkPassive1000;
      this.chkPassive10000.CheckState = this.gclass21_0.chkPassive10000;
      this.chkTracking.CheckState = this.gclass21_0.chkTracking;
      this.chkActiveOnly.CheckState = this.gclass21_0.chkActiveOnly;
      this.chkShowDist.CheckState = this.gclass21_0.chkShowDist;
      this.chkSBSurvey.CheckState = this.gclass21_0.chkSBSurvey;
      this.chkMinerals.CheckState = this.gclass21_0.chkMinerals;
      this.chkCometPath.CheckState = this.gclass21_0.chkCometPath;
      this.chkAstColOnly.CheckState = this.gclass21_0.chkAstColOnly;
      this.chkAstMinOnly.CheckState = this.gclass21_0.chkAstMinOnly;
      this.chkTAD.CheckState = this.gclass21_0.chkTAD;
      this.chkSalvoOrigin.CheckState = this.gclass21_0.chkSalvoOrigin;
      this.chkFiringRanges.CheckState = this.gclass21_0.chkFiringRanges;
      this.chkAllRace.CheckState = this.gclass21_0.chkAllRace;
      this.chkDisplayAllForms.CheckState = this.gclass21_0.chkDisplayAllForms;
      this.chkSalvoTarget.CheckState = this.gclass21_0.chkSalvoTarget;
      this.chkEscorts.CheckState = this.gclass21_0.chkEscorts;
      this.chkFireControlRange.CheckState = this.gclass21_0.chkFireControlRange;
      this.chkHideIDs.CheckState = this.gclass21_0.chkHideIDs;
      this.chkHideWreckIDs.CheckState = this.gclass21_0.chkHideWreckIDs;
      this.chkHideSL.CheckState = this.gclass21_0.chkHideSL;
      this.chkPackets.CheckState = this.gclass21_0.chkPackets;
      this.chkMPC.CheckState = this.gclass21_0.chkMPC;
      this.chkLifepods.CheckState = this.gclass21_0.chkLifepods;
      this.chkWrecks.CheckState = this.gclass21_0.chkWrecks;
      this.chkHostileSensors.CheckState = this.gclass21_0.chkHostileSensors;
      this.chkBearing.CheckState = this.gclass21_0.chkBearing;
      this.chkGeoPoints.CheckState = this.gclass21_0.chkGeoPoints;
      this.chkCoordinates.CheckState = this.gclass21_0.chkCoordinates;
      this.chkLostContacts.CheckState = this.gclass21_0.chkLostContacts;
      this.chkLostContactsOneYear.CheckState = this.gclass21_0.chkLostContactsOneYear;
      this.chkLostContacts.CheckState = this.gclass21_0.chkLostContacts;
      this.chkSystemOnly.CheckState = this.gclass21_0.chkSystemOnly;
      this.chkShowCivilianOOB.CheckState = this.gclass21_0.chkShowCivilianOOB;
      this.chkHostile.CheckState = this.gclass21_0.chkHostile;
      this.chkFriendly.CheckState = this.gclass21_0.chkFriendly;
      this.chkAllied.CheckState = this.gclass21_0.chkAllied;
      this.chkNeutral.CheckState = this.gclass21_0.chkNeutral;
      this.chkCivilian.CheckState = this.gclass21_0.chkCivilian;
      this.chkContactsCurrentSystem.CheckState = this.gclass21_0.chkContactsCurrentSystem;
      this.chkHideOrbitFleets.CheckState = this.gclass21_0.chkHideOrbitFleets;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 157);
    }
  }

  private void method_13()
  {
    if (this.gclass0_0.bool_8)
    {
      this.ckNoSensors.Visible = true;
      this.chkEventsAllRaces.Visible = true;
    }
    else
    {
      this.ckNoSensors.Visible = false;
      this.chkEventsAllRaces.Visible = false;
    }
  }

  public void method_14(GClass202 gclass202_1)
  {
    try
    {
      if (this.gclass202_0 == gclass202_1)
        return;
      this.cboSystems.SelectedItem = (object) gclass202_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 158);
    }
  }

  public GClass202 method_15()
  {
    try
    {
      return this.gclass202_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 159);
      return (GClass202) null;
    }
  }

  private void tvMilitary_AfterSelect(object sender, TreeViewEventArgs e)
  {
    try
    {
      if (e.Node.Tag is GClass85)
        this.gclass0_0.method_522((GClass85) e.Node.Tag);
      else if (e.Node.Tag is GClass22)
      {
        int num1 = (int) MessageBox.Show("ShipClass");
      }
      else
      {
        if (!(e.Node.Tag is GClass40))
          return;
        int num2 = (int) MessageBox.Show(((GClass40) e.Node.Tag).ShipName);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 160 /*0xA0*/);
    }
  }

  private void ckNoSensors_CheckedChanged(object sender, EventArgs e)
  {
    try
    {
      if (this.ckNoSensors.CheckState == CheckState.Checked)
        this.gclass202_0.gclass200_0.int_7 = 1;
      else
        this.gclass202_0.gclass200_0.int_7 = 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 161);
    }
  }

  private void tvSystemBodies_AfterSelect(object sender, TreeViewEventArgs e)
  {
    try
    {
      if (e.Node.Tag is GClass197)
      {
        GClass197 tag = (GClass197) e.Node.Tag;
        this.gclass0_0.method_712(tag.double_0, tag.double_1, this.gclass202_0);
        this.Refresh();
      }
      else
      {
        if (!(e.Node.Tag is GClass1))
          return;
        GClass1 tag = (GClass1) e.Node.Tag;
        this.gclass0_0.method_712(tag.double_0, tag.double_1, this.gclass202_0);
        this.Refresh();
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 162);
    }
  }

  private void cmdNormalWP_Click(object sender, EventArgs e)
  {
    try
    {
      this.wayPointType_0 = WayPointType.Normal;
      this.Cursor = Cursors.Cross;
      this.int_4 = 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 163);
    }
  }

  private void cmdLastClickedWP_Click(object sender, EventArgs e)
  {
    try
    {
      this.wayPointType_0 = WayPointType.Named;
      this.Cursor = Cursors.Cross;
      this.int_4 = 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 164);
    }
  }

  private void cmdRendezvousWP_Click(object sender, EventArgs e)
  {
    try
    {
      this.wayPointType_0 = WayPointType.Rendezvous;
      this.Cursor = Cursors.Cross;
      this.int_4 = 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 165);
    }
  }

  private void cmdPOIWP_Click(object sender, EventArgs e)
  {
    try
    {
      this.wayPointType_0 = WayPointType.POI;
      this.Cursor = Cursors.Cross;
      this.int_4 = 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 166);
    }
  }

  private void cmdUrgentPOIWP_Click(object sender, EventArgs e)
  {
    try
    {
      this.wayPointType_0 = WayPointType.UrgentPOI;
      this.Cursor = Cursors.Cross;
      this.int_4 = 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 167);
    }
  }

  private void lstvWaypoints_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      if (this.lstvWaypoints.SelectedItems.Count == 0)
        return;
      if (this.gclass21_0 == null)
      {
        int num = (int) MessageBox.Show("Please select a race");
      }
      else
      {
        GClass214 tag = (GClass214) this.lstvWaypoints.SelectedItems[0].Tag;
        if (tag == null)
          return;
        this.gclass0_0.method_712(tag.double_0, tag.double_1, this.gclass202_0);
        this.Refresh();
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 168);
    }
  }

  private void cmdDeleteWP_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.lstvWaypoints.SelectedItems.Count == 0)
      {
        int num1 = (int) MessageBox.Show("Please select a waypoint to delete");
      }
      else if (this.gclass21_0 == null)
      {
        int num2 = (int) MessageBox.Show("Please select a race");
      }
      else
      {
        GClass214 tag = (GClass214) this.lstvWaypoints.SelectedItems[0].Tag;
        if (tag == null || MessageBox.Show($" Are you sure you want to delete {tag.method_2(true)}?", "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
          return;
        this.gclass0_0.dictionary_13.Remove(tag.int_0);
        this.gclass202_0.method_14(this.lstvWaypoints);
        this.gclass0_0.method_703(this.gclass202_0);
        this.Refresh();
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 169);
    }
  }

  private void method_16(object sender, EventArgs e)
  {
  }

  private void method_17(object sender, EventArgs e)
  {
  }

  private void cmdAddNameTheme_Click(object sender, EventArgs e)
  {
    try
    {
      this.gclass0_0.string_3 = "Create New Naming Theme";
      this.gclass0_0.string_4 = "Enter Theme Name";
      int num = (int) new MessageEntry(this.gclass0_0).ShowDialog();
      if (this.gclass0_0.bool_21)
        return;
      GClass140 gclass140_1 = new GClass140();
      gclass140_1.int_0 = this.gclass0_0.method_26(GEnum0.const_47);
      gclass140_1.Description = this.gclass0_0.string_4;
      this.gclass0_0.dictionary_55.Add(gclass140_1.int_0, gclass140_1);
      using (StreamReader streamReader = new StreamReader(GClass226.smethod_18("")))
      {
        while (!streamReader.EndOfStream)
        {
          string[] strArray = streamReader.ReadLine().Split(',');
          gclass140_1.list_0.Add(strArray[0]);
        }
      }
      this.gclass0_0.method_155(gclass140_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 172);
    }
  }

  private void TacticalMap_MouseClick(object sender, MouseEventArgs e)
  {
    try
    {
      MouseEventArgs mouseEventArgs = e;
      string string_10 = "";
      if (this.int_4 > 0)
        string_10 = this.string_0;
      if (e.Button != MouseButtons.Left || !(Cursor.Current == Cursors.Cross))
        return;
      GClass1 gclass1_0_1 = this.gclass0_0.method_711(mouseEventArgs.X, mouseEventArgs.Y);
      if (this.gclass214_0 == null)
      {
        if (this.wayPointType_0 != WayPointType.Named && this.wayPointType_0 != WayPointType.Rendezvous)
        {
          if (this.wayPointType_0 == WayPointType.DeepSpaceLocation)
          {
            GClass197 gclass197_0_1 = this.gclass0_0.dictionary_10.Values.FirstOrDefault<GClass197>((System.Func<GClass197, bool>) (gclass197_0 => gclass197_0.gclass200_0 == this.gclass202_0.gclass200_0 && gclass197_0.int_3 == 1));
            GClass221 gclass221 = this.gclass0_0.method_716(this.gclass202_0, (double) mouseEventArgs.X, (double) mouseEventArgs.Y);
            GClass1 gclass1_1 = (GClass1) null;
            if (gclass1_0_1 != null && (gclass1_0_1.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || gclass1_0_1.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian))
            {
              gclass1_1 = gclass1_0_1;
              string_10 = gclass1_0_1.method_78(this.gclass21_0);
              gclass221.double_0 = gclass1_1.double_0;
              gclass221.double_1 = gclass1_1.double_1;
            }
            if (gclass1_1 == null)
            {
              this.gclass0_0.string_3 = "Enter Name for Deep Space Population";
              this.gclass0_0.string_4 = "New Deep Space Population";
              int num = (int) new MessageEntry(this.gclass0_0).ShowDialog();
              if (this.gclass0_0.bool_21)
              {
                this.Cursor = Cursors.Default;
                return;
              }
              string_10 = this.gclass0_0.string_4;
            }
            GClass1 gclass1_0_2 = this.gclass0_0.method_649(this.gclass21_0, this.gclass202_0.gclass200_0, gclass197_0_1, gclass221.double_0, gclass221.double_1, string_10, gclass1_1);
            GClass194 gclass194_1 = this.gclass21_0.method_164();
            this.gclass21_0.method_275(gclass1_0_2, gclass194_1);
            gclass1_0_2.method_37(this.gclass21_0);
            this.Cursor = Cursors.Default;
            this.gclass21_0.method_385(this.gclass202_0, this.tvSystemBodies);
            this.gclass0_0.method_703(this.gclass202_0);
            this.Refresh();
            return;
          }
        }
        else
        {
          this.gclass0_0.string_3 = "Enter Waypoint Name";
          this.gclass0_0.string_4 = "New Waypoint";
          int num = (int) new MessageEntry(this.gclass0_0).ShowDialog();
          if (this.gclass0_0.bool_21)
          {
            this.Cursor = Cursors.Default;
            return;
          }
          string_10 = this.gclass0_0.string_4;
          if (this.wayPointType_0 == WayPointType.Named)
            this.wayPointType_0 = WayPointType.Normal;
        }
        if (gclass1_0_1 != null)
        {
          this.gclass21_0.method_188(this.gclass202_0.gclass200_0, gclass1_0_1, (GClass120) null, this.wayPointType_0, gclass1_0_1.double_0, gclass1_0_1.double_1, string_10, this.int_4);
        }
        else
        {
          GClass221 gclass221 = this.gclass0_0.method_716(this.gclass202_0, (double) mouseEventArgs.X, (double) mouseEventArgs.Y);
          this.gclass21_0.method_188(this.gclass202_0.gclass200_0, (GClass1) null, (GClass120) null, this.wayPointType_0, gclass221.double_0, gclass221.double_1, string_10, this.int_4);
        }
      }
      else
      {
        if (gclass1_0_1 != null)
        {
          this.gclass214_0.gclass1_0 = gclass1_0_1;
          this.gclass214_0.int_1 = gclass1_0_1.int_0;
          this.gclass214_0.double_0 = gclass1_0_1.double_0;
          this.gclass214_0.double_1 = gclass1_0_1.double_1;
        }
        else
        {
          GClass221 gclass221 = this.gclass0_0.method_716(this.gclass202_0, (double) mouseEventArgs.X, (double) mouseEventArgs.Y);
          this.gclass214_0.gclass1_0 = (GClass1) null;
          this.gclass214_0.int_1 = 0;
          this.gclass214_0.double_0 = gclass221.double_0;
          this.gclass214_0.double_1 = gclass221.double_1;
        }
        this.gclass214_0 = (GClass214) null;
      }
      this.Cursor = Cursors.Default;
      this.gclass202_0.method_14(this.lstvWaypoints);
      this.gclass0_0.method_703(this.gclass202_0);
      this.Refresh();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 173);
    }
  }

  public void method_18(object sender, EventArgs e)
  {
    try
    {
      MenuItem menuItem = (MenuItem) sender;
      if (menuItem.Tag is GClass85)
      {
        GClass85 tag = (GClass85) menuItem.Tag;
        this.gclass21_0.genum42_0 = GEnum42.const_2;
        this.gclass21_0.int_43 = tag.int_3;
        new FleetWindow(this.gclass0_0).Show();
      }
      else if (menuItem.Tag is GClass146)
        new Economics(this.gclass0_0, GEnum34.const_0, (GClass146) menuItem.Tag).Show();
      else if (menuItem.Tag is GClass202)
        this.method_9((GClass202) menuItem.Tag);
      menuItem.Parent.MenuItems.Clear();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 174);
    }
  }

  private void cmdAddCmdrTheme_Click(object sender, EventArgs e)
  {
    try
    {
      this.gclass0_0.string_3 = "Create New Commander Name Theme";
      this.gclass0_0.string_4 = "Enter Commander Theme Name";
      int num1 = (int) new MessageEntry(this.gclass0_0).ShowDialog();
      if (this.gclass0_0.bool_21)
        return;
      GClass58 gclass58_0 = new GClass58();
      gclass58_0.int_0 = this.gclass0_0.method_26(GEnum0.const_49);
      gclass58_0.Description = this.gclass0_0.string_4;
      gclass58_0.int_1 = 1;
      gclass58_0.string_0 = "";
      this.gclass0_0.dictionary_47.Add(gclass58_0.int_0, gclass58_0);
      List<GClass57> list_33 = new List<GClass57>();
      int num2 = (int) MessageBox.Show("Select the Male Names file");
      using (StreamReader streamReader = new StreamReader(GClass226.smethod_18("")))
      {
        while (!streamReader.EndOfStream)
        {
          string[] strArray = streamReader.ReadLine().Split(',');
          if (!(strArray[0] == ""))
          {
            GClass57 gclass57 = new GClass57();
            gclass57.gclass58_0 = gclass58_0;
            gclass57.bool_0 = true;
            gclass57.bool_1 = false;
            gclass57.bool_2 = false;
            gclass57.bool_3 = false;
            gclass57.string_0 = strArray[0].Trim();
            this.gclass0_0.list_14.Add(gclass57);
            list_33.Add(gclass57);
          }
        }
      }
      int num3 = (int) MessageBox.Show("Select the Female Names file");
      string path1 = GClass226.smethod_18("");
      if (path1 != "")
      {
        using (StreamReader streamReader = new StreamReader(path1))
        {
          while (!streamReader.EndOfStream)
          {
            string[] strArray = streamReader.ReadLine().Split(',');
            if (!(strArray[0] == ""))
            {
              GClass57 gclass57 = new GClass57();
              gclass57.gclass58_0 = gclass58_0;
              gclass57.bool_0 = true;
              gclass57.bool_1 = false;
              gclass57.bool_2 = false;
              gclass57.bool_3 = true;
              gclass57.string_0 = strArray[0].Trim();
              this.gclass0_0.list_14.Add(gclass57);
              list_33.Add(gclass57);
            }
          }
        }
      }
      int num4 = (int) MessageBox.Show("Select the Surnames file");
      string path2 = GClass226.smethod_18("");
      if (path2 != "")
      {
        gclass58_0.int_2 = 2;
        using (StreamReader streamReader = new StreamReader(path2))
        {
          while (!streamReader.EndOfStream)
          {
            string[] strArray = streamReader.ReadLine().Split(',');
            if (!(strArray[0] == ""))
            {
              GClass57 gclass57 = new GClass57();
              gclass57.gclass58_0 = gclass58_0;
              gclass57.bool_0 = false;
              gclass57.bool_1 = true;
              gclass57.bool_2 = false;
              gclass57.bool_3 = false;
              gclass57.string_0 = strArray[0].Trim();
              this.gclass0_0.list_14.Add(gclass57);
              list_33.Add(gclass57);
            }
          }
        }
      }
      this.gclass0_0.method_154(gclass58_0);
      this.gclass0_0.method_156(list_33);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 175);
    }
  }

  private void chkLostContactsOneYear_CheckedChanged(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass0_0.bool_9)
        return;
      CheckBox checkBox = (CheckBox) sender;
      this.gclass21_0.method_320(checkBox.Name, checkBox.CheckState);
      if (this.chkContactsCurrentSystem.CheckState == CheckState.Checked)
        this.gclass21_0.method_317(this.tvContacts, (ListView) null, this.gclass202_0, false);
      else
        this.gclass21_0.method_318(this.tvContacts);
      this.gclass0_0.method_703(this.gclass202_0);
      this.Refresh();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 176 /*0xB0*/);
    }
  }

  private void method_19(object sender, EventArgs e)
  {
  }

  private void TacticalMap_KeyDown(object sender, KeyEventArgs e)
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
        this.gclass21_0.method_174(e, this.gclass202_0);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3269);
    }
  }

  private void tvContacts_AfterSelect(object sender, TreeViewEventArgs e)
  {
    try
    {
      if (this.gclass21_0 == null || !(e.Node.Tag is GClass40))
        return;
      var cgc40_0 = (GClass40) e.Node.Tag;
      if (cgc40_0 == null)
        return;
      GClass65 gclass65 = this.gclass0_0.dictionary_28.Values.Where<GClass65>(gc65=>gc65.gclass40_0 == cgc40_0 && gc65.gclass21_0 == this.gclass21_0).OrderByDescending<GClass65, Decimal>((System.Func<GClass65, Decimal>) (gclass65_0 => gclass65_0.decimal_3)).FirstOrDefault<GClass65>();
      if (gclass65 == null)
        return;
      this.lblLocation.Text = gclass65.method_0();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3297);
    }
  }

  private void TacticalMap_MouseDoubleClick(object sender, MouseEventArgs e)
  {
    try
    {
      if (e.X < 345 || e.X > 1285 || this.chkEvents.CheckState == CheckState.Unchecked)
        return;
      foreach (GClass87 gclass87_0 in this.list_0)
      {
        if ((double) e.Y >= gclass87_0.double_2 && (double) e.Y < gclass87_0.double_3)
        {
          this.gclass0_0.method_567(gclass87_0);
          break;
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3300);
    }
  }

  private void chkHideIDs_CheckedChanged(object sender, EventArgs e)
  {
  }

  private void cdmDeepSpaceLocation_Click(object sender, EventArgs e)
  {
    try
    {
      this.wayPointType_0 = WayPointType.DeepSpaceLocation;
      this.Cursor = Cursors.Cross;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3552);
    }
  }

  private void cmdCeaseFireAll_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass21_0 == null)
      {
        int num = (int) MessageBox.Show("Please select a race");
      }
      else
      {
        foreach (GClass40 gclass40 in this.gclass0_0.dictionary_4.Values.Where<GClass40>((System.Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass21_0 == this.gclass21_0)).Where<GClass40>((System.Func<GClass40, bool>) (gclass40_0 => !gclass40_0.gclass22_0.bool_2)).ToList<GClass40>())
          gclass40.method_31(GEnum61.const_2);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3560);
    }
  }

  private void cmdMoveWaypoint_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.lstvWaypoints.SelectedItems.Count == 0)
      {
        int num1 = (int) MessageBox.Show("Please select a waypoint to move");
      }
      else if (this.gclass21_0 == null)
      {
        int num2 = (int) MessageBox.Show("Please select a race");
      }
      else
      {
        this.gclass214_0 = (GClass214) this.lstvWaypoints.SelectedItems[0].Tag;
        if (this.gclass214_0 == null)
          return;
        foreach (GClass132 gclass132 in this.gclass0_0.dictionary_6.Values.Where<GClass132>((System.Func<GClass132, bool>) (gclass132_0 => gclass132_0.auroraContactType_0 == AuroraContactType.WayPoint && gclass132_0.int_0 == this.gclass214_0.int_0)).ToList<GClass132>())
        {
          gclass132.int_0 = 0;
          gclass132.auroraContactType_0 = AuroraContactType.None;
        }
        this.wayPointType_0 = WayPointType.Normal;
        this.Cursor = Cursors.Cross;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3769);
    }
  }

  private void cmdTempWaypoint_Click(object sender, EventArgs e)
  {
    try
    {
      this.wayPointType_0 = WayPointType.Temporary;
      this.Cursor = Cursors.Cross;
      this.int_4 = 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3770);
    }
  }

  private void cmdDeleteAll_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass21_0 == null)
      {
        int num = (int) MessageBox.Show("Please select a race");
      }
      else
      {
        if (MessageBox.Show(" Are you sure you want to delete all waypoints in this system?", "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
          return;
        foreach (ListViewItem listViewItem in this.lstvWaypoints.Items)
        {
          GClass214 tag = (GClass214) listViewItem.Tag;
          if (tag != null)
            this.gclass0_0.dictionary_13.Remove(tag.int_0);
        }
        this.gclass202_0.method_14(this.lstvWaypoints);
        this.gclass0_0.method_703(this.gclass202_0);
        this.Refresh();
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3778);
    }
  }

  private void cmdEmpire_Click(object sender, EventArgs e)
  {
    try
    {
      this.gclass0_0.method_442(GEnum7.const_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3837);
    }
  }

  private void button1_Click(object sender, EventArgs e)
  {
    try
    {
      this.gclass0_0.string_3 = "Create New Commander Name Theme";
      this.gclass0_0.string_4 = "Enter Commander Theme Name";
      int num1 = (int) new MessageEntry(this.gclass0_0).ShowDialog();
      if (this.gclass0_0.bool_21)
        return;
      GClass58 gclass58_0 = new GClass58();
      gclass58_0.int_0 = this.gclass0_0.method_26(GEnum0.const_49);
      gclass58_0.Description = this.gclass0_0.string_4;
      gclass58_0.int_1 = 1;
      gclass58_0.string_0 = "";
      this.gclass0_0.dictionary_47.Add(gclass58_0.int_0, gclass58_0);
      List<GClass57> list_33 = new List<GClass57>();
      int num2 = (int) MessageBox.Show("Select the First Names file");
      using (StreamReader streamReader = new StreamReader(GClass226.smethod_18("")))
      {
        while (!streamReader.EndOfStream)
        {
          string[] strArray = streamReader.ReadLine().Split(',');
          if (!(strArray[0] == ""))
          {
            GClass57 gclass57 = new GClass57();
            gclass57.gclass58_0 = gclass58_0;
            gclass57.bool_0 = true;
            gclass57.bool_1 = false;
            gclass57.bool_2 = false;
            gclass57.bool_3 = false;
            gclass57.string_0 = strArray[0].Trim();
            this.gclass0_0.list_14.Add(gclass57);
            list_33.Add(gclass57);
          }
        }
      }
      int num3 = (int) MessageBox.Show("Select the Surnames file");
      string path = GClass226.smethod_18("");
      if (path != "")
      {
        gclass58_0.int_2 = 2;
        using (StreamReader streamReader = new StreamReader(path))
        {
          while (!streamReader.EndOfStream)
          {
            string[] strArray = streamReader.ReadLine().Split(',');
            if (!(strArray[0] == ""))
            {
              GClass57 gclass57 = new GClass57();
              gclass57.gclass58_0 = gclass58_0;
              gclass57.bool_0 = false;
              gclass57.bool_1 = true;
              gclass57.bool_2 = false;
              gclass57.bool_3 = false;
              gclass57.string_0 = strArray[0].Trim();
              this.gclass0_0.list_14.Add(gclass57);
              list_33.Add(gclass57);
            }
          }
        }
      }
      this.gclass0_0.method_154(gclass58_0);
      this.gclass0_0.method_156(list_33);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3867);
    }
  }

  private void cmdCreateFleetWaypoint_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass21_0 == null)
      {
        int num1 = (int) MessageBox.Show("Please select a race");
      }
      else if (this.tvMilitary.SelectedNode == null)
      {
        int num2 = (int) MessageBox.Show("Please select a fleet");
      }
      else if (this.tvMilitary.SelectedNode.Tag is GClass85)
      {
        GClass85 tag = (GClass85) this.tvMilitary.SelectedNode.Tag;
        if (tag == null)
          return;
        tag.method_0(true, (GClass200) null, (GClass1) null, 0.0, 0.0);
        this.gclass202_0.method_14(this.lstvWaypoints);
        this.gclass0_0.method_703(this.gclass202_0);
        this.Refresh();
      }
      else
      {
        int num3 = (int) MessageBox.Show("Please select a fleet");
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3921);
    }
  }

  private void cmdSetFleetWaypoint_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass21_0 == null)
      {
        int num1 = (int) MessageBox.Show("Please select a race");
      }
      else if (this.tvMilitary.SelectedNode == null)
      {
        int num2 = (int) MessageBox.Show("Please select a fleet");
      }
      else if (this.tvMilitary.SelectedNode.Tag is GClass85)
      {
        GClass85 tag = (GClass85) this.tvMilitary.SelectedNode.Tag;
        if (tag == null)
          return;
        this.wayPointType_0 = WayPointType.FleetWaypoint;
        this.string_0 = tag.FleetName;
        this.Cursor = Cursors.Cross;
        this.int_4 = tag.int_3;
      }
      else
      {
        int num3 = (int) MessageBox.Show("Please select a fleet");
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3922);
    }
  }

  private void cmdResetWindows_Click(object sender, EventArgs e)
  {
    try
    {
      this.gclass0_0.dictionary_77.Clear();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 177);
    }
  }

  private void TacticalMap_FormClosing(object sender, FormClosingEventArgs e)
  {
    try
    {
      if (MessageBox.Show("Are you sure you wish to close C# Aurora? Any unsaved play will be lost.", "C# Aurora", MessageBoxButtons.YesNo) != DialogResult.No)
        return;
      e.Cancel = true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3195);
    }
  }

  private void TacticalMap_MouseMove(object sender, MouseEventArgs e)
  {
    try
    {
      if (!this.bool_0)
        return;
      this.bool_1 = true;
      double num1 = Math.Abs(this.double_0 - (double) e.X);
      double num2 = Math.Abs(this.double_0 - (double) e.Y);
      double num3 = Math.Sqrt(num1 * num1 + num2 * num2);
      if (DateTime.Now.Subtract(this.dateTime_0).TotalMilliseconds < 50.0 && num3 < 100.0)
        return;
      this.dateTime_0 = DateTime.Now;
      this.double_0 = (double) e.X;
      this.double_1 = (double) e.Y;
      this.int_2 = e.X - this.int_0;
      this.int_3 = e.Y - this.int_1;
      this.int_0 = e.X;
      this.int_1 = e.Y;
      if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift && this.gclass227_0 != null)
      {
        this.gclass227_0.method_0((double) e.X, (double) e.Y);
      }
      else
      {
        this.gclass227_0 = (GClass227) null;
        this.gclass0_0.method_708(this.int_2, this.int_3, this.gclass202_0);
      }
      this.Refresh();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 178);
    }
  }

  private void TacticalMap_MouseDown(object sender, MouseEventArgs e)
  {
    try
    {
      if (e.Button == MouseButtons.Left)
      {
        this.int_0 = e.X;
        this.int_1 = e.Y;
        this.bool_0 = true;
        if (this.gclass202_0 == null || (Control.ModifierKeys & Keys.Shift) != Keys.Shift)
          return;
        this.gclass227_0 = new GClass227((double) this.int_0, (double) this.int_1, this.gclass202_0);
      }
      else
      {
        if (e.Button != MouseButtons.Right)
          return;
        ContextMenu contextMenu = new ContextMenu();
        List<GClass222> source = this.gclass0_0.method_710(e.X, e.Y, this.gclass202_0);
        if (source.Count > 0)
        {
          var capturedList = source.SelectMany<GClass222, GClass1>((System.Func<GClass222, IEnumerable<GClass1>>) (gclass222_0 => (IEnumerable<GClass1>) gclass222_0.list_1)).ToList<GClass1>();
          List<GClass85> list1 = source.SelectMany<GClass222, GClass85>((System.Func<GClass222, IEnumerable<GClass85>>) (gclass222_0 => (IEnumerable<GClass85>) gclass222_0.list_4)).Distinct<GClass85>().ToList<GClass85>();
          List<GClass120> list2 = source.SelectMany<GClass222, GClass120>((System.Func<GClass222, IEnumerable<GClass120>>) (gclass222_0 => (IEnumerable<GClass120>) gclass222_0.list_2)).ToList<GClass120>();
          
          foreach (GClass146 gclass146 in this.gclass0_0.dictionary_22.Values.Where<GClass146>(
                     gc146=>capturedList.Contains(gc146.gclass1_0) &&
                            gc146.gclass21_0 == this.gclass21_0)
                     .ToList<GClass146>())
          {
            MenuItem menuItem = new MenuItem(gclass146.PopName, new EventHandler(this.method_18));
            menuItem.Tag = (object) gclass146;
            contextMenu.MenuItems.Add(menuItem);
          }
          foreach (GClass85 gclass85 in list1)
          {
            MenuItem menuItem = new MenuItem(gclass85.FleetName, new EventHandler(this.method_18));
            menuItem.Tag = (object) gclass85;
            contextMenu.MenuItems.Add(menuItem);
          }
          foreach (GClass120 gclass120 in list2)
          {
            if (gclass120.method_0(this.gclass21_0))
            {
              GClass202 gclass202 = this.gclass21_0.method_128(gclass120.gclass120_0.gclass200_0);
              MenuItem menuItem = new MenuItem(gclass202.Name, new EventHandler(this.method_18));
              menuItem.Tag = (object) gclass202;
              contextMenu.MenuItems.Add(menuItem);
            }
          }
          this.ContextMenu = contextMenu;
          contextMenu.Show((Control) this, new Point(e.X, e.Y));
        }
        else
          this.ContextMenu = (ContextMenu) null;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 179);
    }
  }

  private void TacticalMap_MouseUp(object sender, MouseEventArgs e)
  {
    try
    {
      MouseEventArgs mouseEventArgs = e;
      this.bool_0 = false;
      if (this.gclass227_0 != null)
      {
        this.gclass227_0 = (GClass227) null;
        this.Refresh();
      }
      else if (this.bool_1)
      {
        this.bool_1 = false;
      }
      else
      {
        GClass222 gclass222 = this.gclass0_0.method_709(mouseEventArgs.X, mouseEventArgs.Y, this.gclass202_0);
        if (gclass222 == null)
          return;
        object gclass1_0 = gclass222.method_0();
        switch (gclass1_0)
        {
          case GClass85 _ when this.gclass21_0.chkFleets == CheckState.Checked:
            this.gclass202_0.gclass85_0 = (GClass85) gclass1_0;
            this.gclass202_0.gclass1_0 = (GClass1) null;
            this.gclass202_0.gclass132_0 = (GClass132) null;
            break;
          case GClass1 _:
            if (this.gclass21_0.method_83((GClass1) gclass1_0))
            {
              this.gclass202_0.gclass1_0 = (GClass1) gclass1_0;
              this.gclass202_0.gclass85_0 = (GClass85) null;
              this.gclass202_0.gclass132_0 = (GClass132) null;
              break;
            }
            break;
          case GClass132 _:
            this.gclass202_0.gclass132_0 = (GClass132) gclass1_0;
            this.gclass202_0.gclass85_0 = (GClass85) null;
            this.gclass202_0.gclass1_0 = (GClass1) null;
            break;
        }
        if (gclass222.list_1.Count > 0)
          gclass222.list_1.FirstOrDefault<GClass1>()?.method_67(this.lstvBodyInfo, this.lstvMinerals, this.gclass21_0);
        this.Refresh();
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 180);
    }
  }

  public void method_20()
  {
    try
    {
      bool bool_25 = false;
      if (this.chkShowCivilianOOB.CheckState == CheckState.Checked)
        bool_25 = true;
      if (this.chkSystemOnly.CheckState == CheckState.Checked)
        this.gclass21_0.method_355(this.tvMilitary, this.gclass202_0, true, bool_25, (TextBox) null);
      else
        this.gclass21_0.method_355(this.tvMilitary, (GClass202) null, false, bool_25, (TextBox) null);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 181);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TacticalMap));
    this.tlbMainToolbar = new FlowLayoutPanel();
    this.cmdToolbarColony = new Button();
    this.cmdToolbarIndustry = new Button();
    this.cmdToolbarMining = new Button();
    this.cmdToolbarResearch = new Button();
    this.cmdToolbarWealth = new Button();
    this.cmdToolbarClass = new Button();
    this.cmdToolbarProject = new Button();
    this.cmdToolbarFleet = new Button();
    this.cmdToolbarMissileDesign = new Button();
    this.cmdToolbarTurret = new Button();
    this.cmdToolbarGroundForces = new Button();
    this.cmdToolbarCommanders = new Button();
    this.cmdToolbarMedals = new Button();
    this.cmdToolbarRace = new Button();
    this.cmdToolbarSystem = new Button();
    this.cmdToolbarGalactic = new Button();
    this.cmdToolbarComparison = new Button();
    this.cmdToolbarIntelligence = new Button();
    this.cmdToolbarTechnology = new Button();
    this.cmdToolbarSurvey = new Button();
    this.cmdToolbarSector = new Button();
    this.cmdToolbarEvents = new Button();
    this.cmdToolbarRefreshTactical = new Button();
    this.cmdToolbarSave = new Button();
    this.cmdToolbarGame = new Button();
    this.cmdSM = new Button();
    this.cmdToolbarAuto = new Button();
    this.flowLayoutPanel3 = new FlowLayoutPanel();
    this.cmdZoomIn = new Button();
    this.cmdUp = new Button();
    this.cmdZoomOut = new Button();
    this.cmdLeft = new Button();
    this.cmdDown = new Button();
    this.cmdRight = new Button();
    this.tblIncrement = new FlowLayoutPanel();
    this.cmdIncrement = new Button();
    this.cmdIncrement5S = new Button();
    this.cmdIncrement30S = new Button();
    this.cmdIncrement2M = new Button();
    this.cmdIncrement5M = new Button();
    this.cmdIncrement20M = new Button();
    this.cmdIncrement1H = new Button();
    this.cmdIncrement3H = new Button();
    this.cmdIncrement8H = new Button();
    this.cmdIncrement1D = new Button();
    this.cmdIncrement5D = new Button();
    this.cmdIncrement30D = new Button();
    this.tblSubPulse = new FlowLayoutPanel();
    this.cmdSubPulse = new Button();
    this.cmdSubPulse5S = new Button();
    this.cmdSubPulse30S = new Button();
    this.cmdSubPulse2M = new Button();
    this.cmdSubPulse5M = new Button();
    this.cmdSubPulse20M = new Button();
    this.cmdSubPulse1H = new Button();
    this.cmdSubPulse3H = new Button();
    this.cmdSubPulse8H = new Button();
    this.cmdSubPulse1D = new Button();
    this.cmdSubPulse5D = new Button();
    this.cmdSubPulse30D = new Button();
    this.flowLayoutPanel2 = new FlowLayoutPanel();
    this.cboRaces = new ComboBox();
    this.cboSystems = new ComboBox();
    this.tabSidebar = new TabControl();
    this.tabDisplay = new TabPage();
    this.flowLayoutPanelDisplay = new FlowLayoutPanel();
    this.chkEvents = new CheckBox();
    this.chkEventsAllRaces = new CheckBox();
    this.chkUseHullNumbers = new CheckBox();
    this.chkActiveSensors = new CheckBox();
    this.chkFireControlRange = new CheckBox();
    this.chkFiringRanges = new CheckBox();
    this.chkMoveTail = new CheckBox();
    this.chkGeoPoints = new CheckBox();
    this.chkSBSurvey = new CheckBox();
    this.chkBearing = new CheckBox();
    this.chkOrder = new CheckBox();
    this.chkEscorts = new CheckBox();
    this.chkHideOrbitFleets = new CheckBox();
    this.chkSalvoTarget = new CheckBox();
    this.chkSalvoOrigin = new CheckBox();
    this.chkMPC = new CheckBox();
    this.chkCentre = new CheckBox();
    this.chkTAD = new CheckBox();
    this.chkCoordinates = new CheckBox();
    this.chkMinerals = new CheckBox();
    this.chkHideSL = new CheckBox();
    this.chkAstMinOnly = new CheckBox();
    this.chkAstColOnly = new CheckBox();
    this.chkPassive10 = new CheckBox();
    this.chkPassive100 = new CheckBox();
    this.chkPassive1000 = new CheckBox();
    this.chkPassive10000 = new CheckBox();
    this.chkNoOverlap = new CheckBox();
    this.chkAllRace = new CheckBox();
    this.chkDisplayAllForms = new CheckBox();
    this.chkHideWreckIDs = new CheckBox();
    this.flowLayoutPanel9 = new FlowLayoutPanel();
    this.chkColonies = new CheckBox();
    this.chkWP = new CheckBox();
    this.chkPlanets = new CheckBox();
    this.chkDwarf = new CheckBox();
    this.chkMoons = new CheckBox();
    this.chkAst = new CheckBox();
    this.chkFleets = new CheckBox();
    this.chkStarOrbits = new CheckBox();
    this.chkPlanetOrbits = new CheckBox();
    this.chkDwarfOrbits = new CheckBox();
    this.chkCometPath = new CheckBox();
    this.chkMoonOrbits = new CheckBox();
    this.chkAsteroidOrbits = new CheckBox();
    this.chkSelectedOrbit = new CheckBox();
    this.chkStarNames = new CheckBox();
    this.chkPlanetNames = new CheckBox();
    this.chkDwarfNames = new CheckBox();
    this.chkMoonNames = new CheckBox();
    this.chkAstNames = new CheckBox();
    this.chkLifepods = new CheckBox();
    this.chkWrecks = new CheckBox();
    this.chkWaypoint = new CheckBox();
    this.chkSL = new CheckBox();
    this.chkPackets = new CheckBox();
    this.tabContacts = new TabPage();
    this.flowLayoutPanelContacts = new FlowLayoutPanel();
    this.flowLayoutPanel6 = new FlowLayoutPanel();
    this.chkHostile = new CheckBox();
    this.chkNeutral = new CheckBox();
    this.chkFriendly = new CheckBox();
    this.chkAllied = new CheckBox();
    this.chkCivilian = new CheckBox();
    this.chkActiveOnly = new CheckBox();
    this.chkHideIDs = new CheckBox();
    this.chkHostileSensors = new CheckBox();
    this.chkShowDist = new CheckBox();
    this.chkTracking = new CheckBox();
    this.chkLostContactsOneDay = new CheckBox();
    this.chkLostContacts = new CheckBox();
    this.chkLostContactsOneYear = new CheckBox();
    this.ckNoSensors = new CheckBox();
    this.flowLayoutPanel4 = new FlowLayoutPanel();
    this.label7 = new Label();
    this.cboContactRaceFilter = new ComboBox();
    this.flowLayoutPanel5 = new FlowLayoutPanel();
    this.label6 = new Label();
    this.chkContactsCurrentSystem = new CheckBox();
    this.tvContacts = new TreeView();
    this.lblLocation = new Label();
    this.tabMinerals = new TabPage();
    this.flowLayoutPanelMinerals = new FlowLayoutPanel();
    this.tvMinerals = new TreeView();
    this.tabMineralText = new TabPage();
    this.txtMinerals = new TextBox();
    this.tabJump = new TabPage();
    this.flowLayoutPanelJump = new FlowLayoutPanel();
    this.label2 = new Label();
    this.lstRuins = new ListBox();
    this.label3 = new Label();
    this.lstAnomalies = new ListBox();
    this.label4 = new Label();
    this.lstWrecks = new ListBox();
    this.tabGroundSurvey = new TabPage();
    this.lstvSurveySites = new ListView();
    this.columnHeader_8 = new ColumnHeader();
    this.columnHeader_9 = new ColumnHeader();
    this.tabBodyInfo = new TabPage();
    this.flowLayoutPanel7 = new FlowLayoutPanel();
    this.lstvBodyInfo = new ListView();
    this.columnHeader_3 = new ColumnHeader();
    this.columnHeader_4 = new ColumnHeader();
    this.lstvMinerals = new ListView();
    this.columnHeader_0 = new ColumnHeader();
    this.columnHeader_1 = new ColumnHeader();
    this.columnHeader_2 = new ColumnHeader();
    this.tabAllBodies = new TabPage();
    this.tvSystemBodies = new TreeView();
    this.tabMilitary = new TabPage();
    this.flowLayoutPanelMilitary = new FlowLayoutPanel();
    this.chkSystemOnly = new CheckBox();
    this.chkShowCivilianOOB = new CheckBox();
    this.tvMilitary = new TreeView();
    this.tabWaypoints = new TabPage();
    this.lstvWaypoints = new ListView();
    this.columnHeader_5 = new ColumnHeader();
    this.columnHeader_6 = new ColumnHeader();
    this.columnHeader_7 = new ColumnHeader();
    this.flowLayoutPanel8 = new FlowLayoutPanel();
    this.cmdNormalWP = new Button();
    this.cmdLastClickedWP = new Button();
    this.cmdRendezvousWP = new Button();
    this.cmdPOIWP = new Button();
    this.cmdUrgentPOIWP = new Button();
    this.cmdMoveWaypoint = new Button();
    this.cmdTempWaypoint = new Button();
    this.cmdDeleteWP = new Button();
    this.cmdDeleteAll = new Button();
    this.tabMisc = new TabPage();
    this.cmdEmpire = new Button();
    this.panel3 = new Panel();
    this.cmdCeaseFireAll = new Button();
    this.panel2 = new Panel();
    this.cdmDeepSpaceLocation = new Button();
    this.panel1 = new Panel();
    this.button1 = new Button();
    this.label1 = new Label();
    this.label5 = new Label();
    this.cmdAddNameTheme = new Button();
    this.cmdResetWindows = new Button();
    this.cmdAddCmdrTheme = new Button();
    this.label8 = new Label();
    this.lblVersion = new Label();
    this.cmdCreateFleetWaypoint = new Button();
    this.cmdSetFleetWaypoint = new Button();
    this.tlbMainToolbar.SuspendLayout();
    this.flowLayoutPanel3.SuspendLayout();
    this.tblIncrement.SuspendLayout();
    this.tblSubPulse.SuspendLayout();
    this.flowLayoutPanel2.SuspendLayout();
    this.tabSidebar.SuspendLayout();
    this.tabDisplay.SuspendLayout();
    this.flowLayoutPanelDisplay.SuspendLayout();
    this.flowLayoutPanel9.SuspendLayout();
    this.tabContacts.SuspendLayout();
    this.flowLayoutPanelContacts.SuspendLayout();
    this.flowLayoutPanel6.SuspendLayout();
    this.flowLayoutPanel4.SuspendLayout();
    this.flowLayoutPanel5.SuspendLayout();
    this.tabMinerals.SuspendLayout();
    this.flowLayoutPanelMinerals.SuspendLayout();
    this.tabMineralText.SuspendLayout();
    this.tabJump.SuspendLayout();
    this.flowLayoutPanelJump.SuspendLayout();
    this.tabGroundSurvey.SuspendLayout();
    this.tabBodyInfo.SuspendLayout();
    this.flowLayoutPanel7.SuspendLayout();
    this.tabAllBodies.SuspendLayout();
    this.tabMilitary.SuspendLayout();
    this.flowLayoutPanelMilitary.SuspendLayout();
    this.tabWaypoints.SuspendLayout();
    this.flowLayoutPanel8.SuspendLayout();
    this.tabMisc.SuspendLayout();
    this.panel3.SuspendLayout();
    this.panel2.SuspendLayout();
    this.panel1.SuspendLayout();
    this.SuspendLayout();
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarColony);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarIndustry);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarMining);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarResearch);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarWealth);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarClass);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarProject);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarFleet);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarMissileDesign);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarTurret);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarGroundForces);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarCommanders);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarMedals);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarRace);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarSystem);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarGalactic);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarComparison);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarIntelligence);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarTechnology);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarSurvey);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarSector);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarEvents);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarRefreshTactical);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarSave);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarGame);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdSM);
    this.tlbMainToolbar.Controls.Add((Control) this.cmdToolbarAuto);
    this.tlbMainToolbar.Location = new Point(0, 0);
    this.tlbMainToolbar.Margin = new Padding(3, 0, 3, 0);
    this.tlbMainToolbar.Name = "tlbMainToolbar";
    this.tlbMainToolbar.Size = new Size(1296, 48 /*0x30*/);
    this.tlbMainToolbar.TabIndex = 6;
    this.cmdToolbarColony.AccessibleName = "Colony Summary";
    this.cmdToolbarColony.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarColony.BackgroundImage");
    this.cmdToolbarColony.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarColony.Location = new Point(0, 0);
    this.cmdToolbarColony.Margin = new Padding(0);
    this.cmdToolbarColony.Name = "cmdToolbarColony";
    this.cmdToolbarColony.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarColony.TabIndex = 0;
    this.cmdToolbarColony.UseVisualStyleBackColor = true;
    this.cmdToolbarColony.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarIndustry.AccessibleName = "Industrial Projects";
    this.cmdToolbarIndustry.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarIndustry.BackgroundImage");
    this.cmdToolbarIndustry.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarIndustry.Location = new Point(48 /*0x30*/, 0);
    this.cmdToolbarIndustry.Margin = new Padding(0);
    this.cmdToolbarIndustry.Name = "cmdToolbarIndustry";
    this.cmdToolbarIndustry.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarIndustry.TabIndex = 1;
    this.cmdToolbarIndustry.UseVisualStyleBackColor = true;
    this.cmdToolbarIndustry.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarMining.AccessibleName = "Mining Summary";
    this.cmdToolbarMining.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarMining.BackgroundImage");
    this.cmdToolbarMining.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarMining.Location = new Point(96 /*0x60*/, 0);
    this.cmdToolbarMining.Margin = new Padding(0);
    this.cmdToolbarMining.Name = "cmdToolbarMining";
    this.cmdToolbarMining.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarMining.TabIndex = 2;
    this.cmdToolbarMining.UseVisualStyleBackColor = true;
    this.cmdToolbarMining.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarResearch.AccessibleName = "Research Projects";
    this.cmdToolbarResearch.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarResearch.BackgroundImage");
    this.cmdToolbarResearch.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarResearch.Location = new Point(144 /*0x90*/, 0);
    this.cmdToolbarResearch.Margin = new Padding(0);
    this.cmdToolbarResearch.Name = "cmdToolbarResearch";
    this.cmdToolbarResearch.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarResearch.TabIndex = 3;
    this.cmdToolbarResearch.UseVisualStyleBackColor = true;
    this.cmdToolbarResearch.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarWealth.AccessibleName = "Wealth Summary";
    this.cmdToolbarWealth.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarWealth.BackgroundImage");
    this.cmdToolbarWealth.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarWealth.Location = new Point(192 /*0xC0*/, 0);
    this.cmdToolbarWealth.Margin = new Padding(0);
    this.cmdToolbarWealth.Name = "cmdToolbarWealth";
    this.cmdToolbarWealth.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarWealth.TabIndex = 4;
    this.cmdToolbarWealth.UseVisualStyleBackColor = true;
    this.cmdToolbarWealth.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarClass.AccessibleName = "Class Design";
    this.cmdToolbarClass.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarClass.BackgroundImage");
    this.cmdToolbarClass.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarClass.Location = new Point(240 /*0xF0*/, 0);
    this.cmdToolbarClass.Margin = new Padding(0);
    this.cmdToolbarClass.Name = "cmdToolbarClass";
    this.cmdToolbarClass.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarClass.TabIndex = 5;
    this.cmdToolbarClass.UseVisualStyleBackColor = true;
    this.cmdToolbarClass.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarProject.AccessibleName = "Create Projects";
    this.cmdToolbarProject.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarProject.BackgroundImage");
    this.cmdToolbarProject.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarProject.Location = new Point(288, 0);
    this.cmdToolbarProject.Margin = new Padding(0);
    this.cmdToolbarProject.Name = "cmdToolbarProject";
    this.cmdToolbarProject.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarProject.TabIndex = 6;
    this.cmdToolbarProject.UseVisualStyleBackColor = true;
    this.cmdToolbarProject.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarFleet.AccessibleName = "Naval Organization";
    this.cmdToolbarFleet.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarFleet.BackgroundImage");
    this.cmdToolbarFleet.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarFleet.Location = new Point(336, 0);
    this.cmdToolbarFleet.Margin = new Padding(0);
    this.cmdToolbarFleet.Name = "cmdToolbarFleet";
    this.cmdToolbarFleet.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarFleet.TabIndex = 7;
    this.cmdToolbarFleet.UseVisualStyleBackColor = true;
    this.cmdToolbarFleet.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarMissileDesign.AccessibleName = "Missile Design";
    this.cmdToolbarMissileDesign.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarMissileDesign.BackgroundImage");
    this.cmdToolbarMissileDesign.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarMissileDesign.Location = new Point(384, 0);
    this.cmdToolbarMissileDesign.Margin = new Padding(0);
    this.cmdToolbarMissileDesign.Name = "cmdToolbarMissileDesign";
    this.cmdToolbarMissileDesign.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarMissileDesign.TabIndex = 8;
    this.cmdToolbarMissileDesign.UseVisualStyleBackColor = true;
    this.cmdToolbarMissileDesign.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarTurret.AccessibleName = "Turret Design";
    this.cmdToolbarTurret.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarTurret.BackgroundImage");
    this.cmdToolbarTurret.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarTurret.Location = new Point(432, 0);
    this.cmdToolbarTurret.Margin = new Padding(0);
    this.cmdToolbarTurret.Name = "cmdToolbarTurret";
    this.cmdToolbarTurret.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarTurret.TabIndex = 9;
    this.cmdToolbarTurret.UseVisualStyleBackColor = true;
    this.cmdToolbarTurret.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarGroundForces.AccessibleName = "Ground Forces";
    this.cmdToolbarGroundForces.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarGroundForces.BackgroundImage");
    this.cmdToolbarGroundForces.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarGroundForces.Location = new Point(480, 0);
    this.cmdToolbarGroundForces.Margin = new Padding(0);
    this.cmdToolbarGroundForces.Name = "cmdToolbarGroundForces";
    this.cmdToolbarGroundForces.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarGroundForces.TabIndex = 10;
    this.cmdToolbarGroundForces.UseVisualStyleBackColor = true;
    this.cmdToolbarGroundForces.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarCommanders.AccessibleName = "Commanders";
    this.cmdToolbarCommanders.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarCommanders.BackgroundImage");
    this.cmdToolbarCommanders.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarCommanders.Location = new Point(528, 0);
    this.cmdToolbarCommanders.Margin = new Padding(0);
    this.cmdToolbarCommanders.Name = "cmdToolbarCommanders";
    this.cmdToolbarCommanders.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarCommanders.TabIndex = 11;
    this.cmdToolbarCommanders.UseVisualStyleBackColor = true;
    this.cmdToolbarCommanders.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarMedals.AccessibleName = "Medal Design";
    this.cmdToolbarMedals.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarMedals.BackgroundImage");
    this.cmdToolbarMedals.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarMedals.Location = new Point(576, 0);
    this.cmdToolbarMedals.Margin = new Padding(0);
    this.cmdToolbarMedals.Name = "cmdToolbarMedals";
    this.cmdToolbarMedals.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarMedals.TabIndex = 11;
    this.cmdToolbarMedals.UseVisualStyleBackColor = true;
    this.cmdToolbarMedals.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarRace.AccessibleName = "Race Summary";
    this.cmdToolbarRace.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarRace.BackgroundImage");
    this.cmdToolbarRace.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarRace.Location = new Point(624, 0);
    this.cmdToolbarRace.Margin = new Padding(0);
    this.cmdToolbarRace.Name = "cmdToolbarRace";
    this.cmdToolbarRace.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarRace.TabIndex = 12;
    this.cmdToolbarRace.UseVisualStyleBackColor = true;
    this.cmdToolbarRace.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarSystem.AccessibleName = "System View";
    this.cmdToolbarSystem.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarSystem.BackgroundImage");
    this.cmdToolbarSystem.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarSystem.Location = new Point(672, 0);
    this.cmdToolbarSystem.Margin = new Padding(0);
    this.cmdToolbarSystem.Name = "cmdToolbarSystem";
    this.cmdToolbarSystem.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarSystem.TabIndex = 13;
    this.cmdToolbarSystem.UseVisualStyleBackColor = true;
    this.cmdToolbarSystem.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarGalactic.AccessibleName = "Galactic Map";
    this.cmdToolbarGalactic.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarGalactic.BackgroundImage");
    this.cmdToolbarGalactic.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarGalactic.Location = new Point(720, 0);
    this.cmdToolbarGalactic.Margin = new Padding(0);
    this.cmdToolbarGalactic.Name = "cmdToolbarGalactic";
    this.cmdToolbarGalactic.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarGalactic.TabIndex = 14;
    this.cmdToolbarGalactic.UseVisualStyleBackColor = true;
    this.cmdToolbarGalactic.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarComparison.AccessibleName = "Race Comparison";
    this.cmdToolbarComparison.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarComparison.BackgroundImage");
    this.cmdToolbarComparison.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarComparison.Location = new Point(768 /*0x0300*/, 0);
    this.cmdToolbarComparison.Margin = new Padding(0);
    this.cmdToolbarComparison.Name = "cmdToolbarComparison";
    this.cmdToolbarComparison.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarComparison.TabIndex = 15;
    this.cmdToolbarComparison.UseVisualStyleBackColor = true;
    this.cmdToolbarComparison.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarIntelligence.AccessibleName = "Diplomacy and Intelligence";
    this.cmdToolbarIntelligence.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarIntelligence.BackgroundImage");
    this.cmdToolbarIntelligence.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarIntelligence.Location = new Point(816, 0);
    this.cmdToolbarIntelligence.Margin = new Padding(0);
    this.cmdToolbarIntelligence.Name = "cmdToolbarIntelligence";
    this.cmdToolbarIntelligence.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarIntelligence.TabIndex = 16 /*0x10*/;
    this.cmdToolbarIntelligence.UseVisualStyleBackColor = true;
    this.cmdToolbarIntelligence.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarTechnology.AccessibleName = "Technology View";
    this.cmdToolbarTechnology.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarTechnology.BackgroundImage");
    this.cmdToolbarTechnology.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarTechnology.Location = new Point(864, 0);
    this.cmdToolbarTechnology.Margin = new Padding(0);
    this.cmdToolbarTechnology.Name = "cmdToolbarTechnology";
    this.cmdToolbarTechnology.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarTechnology.TabIndex = 17;
    this.cmdToolbarTechnology.UseVisualStyleBackColor = true;
    this.cmdToolbarTechnology.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarSurvey.AccessibleName = "Mineral Search";
    this.cmdToolbarSurvey.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarSurvey.BackgroundImage");
    this.cmdToolbarSurvey.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarSurvey.Location = new Point(912, 0);
    this.cmdToolbarSurvey.Margin = new Padding(0);
    this.cmdToolbarSurvey.Name = "cmdToolbarSurvey";
    this.cmdToolbarSurvey.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarSurvey.TabIndex = 18;
    this.cmdToolbarSurvey.UseVisualStyleBackColor = true;
    this.cmdToolbarSurvey.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarSector.AccessibleName = "Sectors";
    this.cmdToolbarSector.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarSector.BackgroundImage");
    this.cmdToolbarSector.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarSector.Location = new Point(960, 0);
    this.cmdToolbarSector.Margin = new Padding(0);
    this.cmdToolbarSector.Name = "cmdToolbarSector";
    this.cmdToolbarSector.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarSector.TabIndex = 19;
    this.cmdToolbarSector.UseVisualStyleBackColor = true;
    this.cmdToolbarSector.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarEvents.AccessibleName = "Events Log";
    this.cmdToolbarEvents.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarEvents.BackgroundImage");
    this.cmdToolbarEvents.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarEvents.Location = new Point(1008, 0);
    this.cmdToolbarEvents.Margin = new Padding(0);
    this.cmdToolbarEvents.Name = "cmdToolbarEvents";
    this.cmdToolbarEvents.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarEvents.TabIndex = 20;
    this.cmdToolbarEvents.UseVisualStyleBackColor = true;
    this.cmdToolbarEvents.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarRefreshTactical.AccessibleName = "Refresh";
    this.cmdToolbarRefreshTactical.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarRefreshTactical.BackgroundImage");
    this.cmdToolbarRefreshTactical.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarRefreshTactical.Location = new Point(1056, 0);
    this.cmdToolbarRefreshTactical.Margin = new Padding(0);
    this.cmdToolbarRefreshTactical.Name = "cmdToolbarRefreshTactical";
    this.cmdToolbarRefreshTactical.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarRefreshTactical.TabIndex = 21;
    this.cmdToolbarRefreshTactical.UseVisualStyleBackColor = true;
    this.cmdToolbarRefreshTactical.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarSave.AccessibleName = "Save Game";
    this.cmdToolbarSave.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarSave.BackgroundImage");
    this.cmdToolbarSave.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarSave.Location = new Point(1104, 0);
    this.cmdToolbarSave.Margin = new Padding(0);
    this.cmdToolbarSave.Name = "cmdToolbarSave";
    this.cmdToolbarSave.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarSave.TabIndex = 22;
    this.cmdToolbarSave.UseVisualStyleBackColor = true;
    this.cmdToolbarSave.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarGame.AccessibleName = "Game Window";
    this.cmdToolbarGame.BackgroundImage = (Image) componentResourceManager.GetObject("cmdToolbarGame.BackgroundImage");
    this.cmdToolbarGame.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarGame.Location = new Point(1152, 0);
    this.cmdToolbarGame.Margin = new Padding(0);
    this.cmdToolbarGame.Name = "cmdToolbarGame";
    this.cmdToolbarGame.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarGame.TabIndex = 23;
    this.cmdToolbarGame.UseVisualStyleBackColor = true;
    this.cmdToolbarGame.Click += new EventHandler(this.cmdRight_Click);
    this.cmdSM.AccessibleName = "SM Mode";
    this.cmdSM.BackgroundImage = (Image) Resources.SMInactive;
    this.cmdSM.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdSM.Location = new Point(1200, 0);
    this.cmdSM.Margin = new Padding(0);
    this.cmdSM.Name = "cmdSM";
    this.cmdSM.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdSM.TabIndex = 24;
    this.cmdSM.UseVisualStyleBackColor = true;
    this.cmdSM.Click += new EventHandler(this.cmdRight_Click);
    this.cmdToolbarAuto.AccessibleName = "Automated Turns";
    this.cmdToolbarAuto.BackgroundImage = (Image) Resources.AutoOff;
    this.cmdToolbarAuto.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdToolbarAuto.Location = new Point(1248, 0);
    this.cmdToolbarAuto.Margin = new Padding(0);
    this.cmdToolbarAuto.Name = "cmdToolbarAuto";
    this.cmdToolbarAuto.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdToolbarAuto.TabIndex = 25;
    this.cmdToolbarAuto.UseVisualStyleBackColor = true;
    this.cmdToolbarAuto.Click += new EventHandler(this.cmdRight_Click);
    this.flowLayoutPanel3.Controls.Add((Control) this.cmdZoomIn);
    this.flowLayoutPanel3.Controls.Add((Control) this.cmdUp);
    this.flowLayoutPanel3.Controls.Add((Control) this.cmdZoomOut);
    this.flowLayoutPanel3.Controls.Add((Control) this.cmdLeft);
    this.flowLayoutPanel3.Controls.Add((Control) this.cmdDown);
    this.flowLayoutPanel3.Controls.Add((Control) this.cmdRight);
    this.flowLayoutPanel3.Location = new Point(0, 48 /*0x30*/);
    this.flowLayoutPanel3.Margin = new Padding(3, 0, 3, 3);
    this.flowLayoutPanel3.Name = "flowLayoutPanel3";
    this.flowLayoutPanel3.Size = new Size(144 /*0x90*/, 96 /*0x60*/);
    this.flowLayoutPanel3.TabIndex = 7;
    this.cmdZoomIn.AccessibleName = "Zoom In";
    this.cmdZoomIn.Anchor = AnchorStyles.Left;
    this.cmdZoomIn.BackgroundImage = (Image) componentResourceManager.GetObject("cmdZoomIn.BackgroundImage");
    this.cmdZoomIn.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdZoomIn.Location = new Point(0, 0);
    this.cmdZoomIn.Margin = new Padding(0);
    this.cmdZoomIn.Name = "cmdZoomIn";
    this.cmdZoomIn.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdZoomIn.TabIndex = 26;
    this.cmdZoomIn.UseVisualStyleBackColor = true;
    this.cmdZoomIn.Click += new EventHandler(this.cmdRight_Click);
    this.cmdUp.AccessibleName = "Up";
    this.cmdUp.Anchor = AnchorStyles.Top;
    this.cmdUp.BackgroundImage = (Image) componentResourceManager.GetObject("cmdUp.BackgroundImage");
    this.cmdUp.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdUp.Location = new Point(48 /*0x30*/, 0);
    this.cmdUp.Margin = new Padding(0);
    this.cmdUp.Name = "cmdUp";
    this.cmdUp.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdUp.TabIndex = 28;
    this.cmdUp.UseVisualStyleBackColor = true;
    this.cmdUp.Click += new EventHandler(this.cmdRight_Click);
    this.cmdZoomOut.AccessibleName = "Zoom Out";
    this.cmdZoomOut.Anchor = AnchorStyles.Bottom;
    this.cmdZoomOut.BackgroundImage = (Image) componentResourceManager.GetObject("cmdZoomOut.BackgroundImage");
    this.cmdZoomOut.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdZoomOut.Location = new Point(96 /*0x60*/, 0);
    this.cmdZoomOut.Margin = new Padding(0);
    this.cmdZoomOut.Name = "cmdZoomOut";
    this.cmdZoomOut.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdZoomOut.TabIndex = 27;
    this.cmdZoomOut.UseVisualStyleBackColor = true;
    this.cmdZoomOut.Click += new EventHandler(this.cmdRight_Click);
    this.cmdLeft.AccessibleName = "Left";
    this.cmdLeft.Anchor = AnchorStyles.Left;
    this.cmdLeft.BackgroundImage = (Image) componentResourceManager.GetObject("cmdLeft.BackgroundImage");
    this.cmdLeft.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdLeft.Location = new Point(0, 48 /*0x30*/);
    this.cmdLeft.Margin = new Padding(0);
    this.cmdLeft.Name = "cmdLeft";
    this.cmdLeft.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdLeft.TabIndex = 29;
    this.cmdLeft.UseVisualStyleBackColor = true;
    this.cmdLeft.Click += new EventHandler(this.cmdRight_Click);
    this.cmdDown.AccessibleName = "Down";
    this.cmdDown.Anchor = AnchorStyles.Bottom;
    this.cmdDown.BackgroundImage = (Image) componentResourceManager.GetObject("cmdDown.BackgroundImage");
    this.cmdDown.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdDown.Location = new Point(48 /*0x30*/, 48 /*0x30*/);
    this.cmdDown.Margin = new Padding(0);
    this.cmdDown.Name = "cmdDown";
    this.cmdDown.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdDown.TabIndex = 30;
    this.cmdDown.UseVisualStyleBackColor = true;
    this.cmdDown.Click += new EventHandler(this.cmdRight_Click);
    this.cmdRight.AccessibleName = "Right";
    this.cmdRight.Anchor = AnchorStyles.Right;
    this.cmdRight.BackgroundImage = (Image) componentResourceManager.GetObject("cmdRight.BackgroundImage");
    this.cmdRight.BackgroundImageLayout = ImageLayout.Stretch;
    this.cmdRight.Location = new Point(96 /*0x60*/, 48 /*0x30*/);
    this.cmdRight.Margin = new Padding(0);
    this.cmdRight.Name = "cmdRight";
    this.cmdRight.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.cmdRight.TabIndex = 31 /*0x1F*/;
    this.cmdRight.UseVisualStyleBackColor = true;
    this.cmdRight.Click += new EventHandler(this.cmdRight_Click);
    this.tblIncrement.Controls.Add((Control) this.cmdIncrement);
    this.tblIncrement.Controls.Add((Control) this.cmdIncrement5S);
    this.tblIncrement.Controls.Add((Control) this.cmdIncrement30S);
    this.tblIncrement.Controls.Add((Control) this.cmdIncrement2M);
    this.tblIncrement.Controls.Add((Control) this.cmdIncrement5M);
    this.tblIncrement.Controls.Add((Control) this.cmdIncrement20M);
    this.tblIncrement.Controls.Add((Control) this.cmdIncrement1H);
    this.tblIncrement.Controls.Add((Control) this.cmdIncrement3H);
    this.tblIncrement.Controls.Add((Control) this.cmdIncrement8H);
    this.tblIncrement.Controls.Add((Control) this.cmdIncrement1D);
    this.tblIncrement.Controls.Add((Control) this.cmdIncrement5D);
    this.tblIncrement.Controls.Add((Control) this.cmdIncrement30D);
    this.tblIncrement.Location = new Point(144 /*0x90*/, 48 /*0x30*/);
    this.tblIncrement.Name = "tblIncrement";
    this.tblIncrement.Size = new Size(1152, 48 /*0x30*/);
    this.tblIncrement.TabIndex = 8;
    this.cmdIncrement.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdIncrement.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdIncrement.Location = new Point(0, 0);
    this.cmdIncrement.Margin = new Padding(0);
    this.cmdIncrement.Name = "cmdIncrement";
    this.cmdIncrement.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdIncrement.TabIndex = 4;
    this.cmdIncrement.Text = "Select Increment Length";
    this.cmdIncrement.UseVisualStyleBackColor = false;
    this.cmdIncrement5S.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdIncrement5S.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdIncrement5S.Location = new Point(96 /*0x60*/, 0);
    this.cmdIncrement5S.Margin = new Padding(0);
    this.cmdIncrement5S.Name = "cmdIncrement5S";
    this.cmdIncrement5S.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdIncrement5S.TabIndex = 0;
    this.cmdIncrement5S.Tag = (object) "5";
    this.cmdIncrement5S.Text = "5 Seconds";
    this.cmdIncrement5S.UseVisualStyleBackColor = false;
    this.cmdIncrement5S.Click += new EventHandler(this.cmdIncrement30D_Click);
    this.cmdIncrement30S.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdIncrement30S.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdIncrement30S.Location = new Point(192 /*0xC0*/, 0);
    this.cmdIncrement30S.Margin = new Padding(0);
    this.cmdIncrement30S.Name = "cmdIncrement30S";
    this.cmdIncrement30S.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdIncrement30S.TabIndex = 1;
    this.cmdIncrement30S.Tag = (object) "30";
    this.cmdIncrement30S.Text = "30 Seconds";
    this.cmdIncrement30S.UseVisualStyleBackColor = false;
    this.cmdIncrement30S.Click += new EventHandler(this.cmdIncrement30D_Click);
    this.cmdIncrement2M.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdIncrement2M.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdIncrement2M.Location = new Point(288, 0);
    this.cmdIncrement2M.Margin = new Padding(0);
    this.cmdIncrement2M.Name = "cmdIncrement2M";
    this.cmdIncrement2M.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdIncrement2M.TabIndex = 2;
    this.cmdIncrement2M.Tag = (object) "120";
    this.cmdIncrement2M.Text = "2 Minutes";
    this.cmdIncrement2M.UseVisualStyleBackColor = false;
    this.cmdIncrement2M.Click += new EventHandler(this.cmdIncrement30D_Click);
    this.cmdIncrement5M.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdIncrement5M.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdIncrement5M.Location = new Point(384, 0);
    this.cmdIncrement5M.Margin = new Padding(0);
    this.cmdIncrement5M.Name = "cmdIncrement5M";
    this.cmdIncrement5M.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdIncrement5M.TabIndex = 3;
    this.cmdIncrement5M.Tag = (object) "300";
    this.cmdIncrement5M.Text = "5 Minutes";
    this.cmdIncrement5M.UseVisualStyleBackColor = false;
    this.cmdIncrement5M.Click += new EventHandler(this.cmdIncrement30D_Click);
    this.cmdIncrement20M.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdIncrement20M.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdIncrement20M.Location = new Point(480, 0);
    this.cmdIncrement20M.Margin = new Padding(0);
    this.cmdIncrement20M.Name = "cmdIncrement20M";
    this.cmdIncrement20M.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdIncrement20M.TabIndex = 5;
    this.cmdIncrement20M.Tag = (object) "1200";
    this.cmdIncrement20M.Text = "20 Minutes";
    this.cmdIncrement20M.UseVisualStyleBackColor = false;
    this.cmdIncrement20M.Click += new EventHandler(this.cmdIncrement30D_Click);
    this.cmdIncrement1H.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdIncrement1H.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdIncrement1H.Location = new Point(576, 0);
    this.cmdIncrement1H.Margin = new Padding(0);
    this.cmdIncrement1H.Name = "cmdIncrement1H";
    this.cmdIncrement1H.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdIncrement1H.TabIndex = 6;
    this.cmdIncrement1H.Tag = (object) "3600";
    this.cmdIncrement1H.Text = "1 Hour";
    this.cmdIncrement1H.UseVisualStyleBackColor = false;
    this.cmdIncrement1H.Click += new EventHandler(this.cmdIncrement30D_Click);
    this.cmdIncrement3H.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdIncrement3H.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdIncrement3H.Location = new Point(672, 0);
    this.cmdIncrement3H.Margin = new Padding(0);
    this.cmdIncrement3H.Name = "cmdIncrement3H";
    this.cmdIncrement3H.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdIncrement3H.TabIndex = 7;
    this.cmdIncrement3H.Tag = (object) "10800";
    this.cmdIncrement3H.Text = "3 Hours";
    this.cmdIncrement3H.UseVisualStyleBackColor = false;
    this.cmdIncrement3H.Click += new EventHandler(this.cmdIncrement30D_Click);
    this.cmdIncrement8H.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdIncrement8H.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdIncrement8H.Location = new Point(768 /*0x0300*/, 0);
    this.cmdIncrement8H.Margin = new Padding(0);
    this.cmdIncrement8H.Name = "cmdIncrement8H";
    this.cmdIncrement8H.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdIncrement8H.TabIndex = 8;
    this.cmdIncrement8H.Tag = (object) "28800";
    this.cmdIncrement8H.Text = "8 Hours";
    this.cmdIncrement8H.UseVisualStyleBackColor = false;
    this.cmdIncrement8H.Click += new EventHandler(this.cmdIncrement30D_Click);
    this.cmdIncrement1D.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdIncrement1D.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdIncrement1D.Location = new Point(864, 0);
    this.cmdIncrement1D.Margin = new Padding(0);
    this.cmdIncrement1D.Name = "cmdIncrement1D";
    this.cmdIncrement1D.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdIncrement1D.TabIndex = 9;
    this.cmdIncrement1D.Tag = (object) "86400";
    this.cmdIncrement1D.Text = "1 Day";
    this.cmdIncrement1D.UseVisualStyleBackColor = false;
    this.cmdIncrement1D.Click += new EventHandler(this.cmdIncrement30D_Click);
    this.cmdIncrement5D.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdIncrement5D.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdIncrement5D.Location = new Point(960, 0);
    this.cmdIncrement5D.Margin = new Padding(0);
    this.cmdIncrement5D.Name = "cmdIncrement5D";
    this.cmdIncrement5D.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdIncrement5D.TabIndex = 10;
    this.cmdIncrement5D.Tag = (object) "432000";
    this.cmdIncrement5D.Text = "5 Days";
    this.cmdIncrement5D.UseVisualStyleBackColor = false;
    this.cmdIncrement5D.Click += new EventHandler(this.cmdIncrement30D_Click);
    this.cmdIncrement30D.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdIncrement30D.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdIncrement30D.Location = new Point(1056, 0);
    this.cmdIncrement30D.Margin = new Padding(0);
    this.cmdIncrement30D.Name = "cmdIncrement30D";
    this.cmdIncrement30D.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdIncrement30D.TabIndex = 11;
    this.cmdIncrement30D.Tag = (object) "2592000";
    this.cmdIncrement30D.Text = "30 Days";
    this.cmdIncrement30D.UseVisualStyleBackColor = false;
    this.cmdIncrement30D.Click += new EventHandler(this.cmdIncrement30D_Click);
    this.tblSubPulse.Controls.Add((Control) this.cmdSubPulse);
    this.tblSubPulse.Controls.Add((Control) this.cmdSubPulse5S);
    this.tblSubPulse.Controls.Add((Control) this.cmdSubPulse30S);
    this.tblSubPulse.Controls.Add((Control) this.cmdSubPulse2M);
    this.tblSubPulse.Controls.Add((Control) this.cmdSubPulse5M);
    this.tblSubPulse.Controls.Add((Control) this.cmdSubPulse20M);
    this.tblSubPulse.Controls.Add((Control) this.cmdSubPulse1H);
    this.tblSubPulse.Controls.Add((Control) this.cmdSubPulse3H);
    this.tblSubPulse.Controls.Add((Control) this.cmdSubPulse8H);
    this.tblSubPulse.Controls.Add((Control) this.cmdSubPulse1D);
    this.tblSubPulse.Controls.Add((Control) this.cmdSubPulse5D);
    this.tblSubPulse.Controls.Add((Control) this.cmdSubPulse30D);
    this.tblSubPulse.Location = new Point(144 /*0x90*/, 96 /*0x60*/);
    this.tblSubPulse.Name = "tblSubPulse";
    this.tblSubPulse.Size = new Size(1152, 48 /*0x30*/);
    this.tblSubPulse.TabIndex = 9;
    this.cmdSubPulse.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSubPulse.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSubPulse.Location = new Point(0, 0);
    this.cmdSubPulse.Margin = new Padding(0);
    this.cmdSubPulse.Name = "cmdSubPulse";
    this.cmdSubPulse.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdSubPulse.TabIndex = 4;
    this.cmdSubPulse.Tag = (object) "0";
    this.cmdSubPulse.Text = "Select Sub-Pulse Length (Auto)";
    this.cmdSubPulse.UseVisualStyleBackColor = false;
    this.cmdSubPulse.Click += new EventHandler(this.cmdSubPulse30D_Click);
    this.cmdSubPulse5S.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSubPulse5S.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSubPulse5S.Location = new Point(96 /*0x60*/, 0);
    this.cmdSubPulse5S.Margin = new Padding(0);
    this.cmdSubPulse5S.Name = "cmdSubPulse5S";
    this.cmdSubPulse5S.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdSubPulse5S.TabIndex = 0;
    this.cmdSubPulse5S.Tag = (object) "5";
    this.cmdSubPulse5S.Text = "5 Seconds";
    this.cmdSubPulse5S.UseVisualStyleBackColor = false;
    this.cmdSubPulse5S.Click += new EventHandler(this.cmdSubPulse30D_Click);
    this.cmdSubPulse30S.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSubPulse30S.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSubPulse30S.Location = new Point(192 /*0xC0*/, 0);
    this.cmdSubPulse30S.Margin = new Padding(0);
    this.cmdSubPulse30S.Name = "cmdSubPulse30S";
    this.cmdSubPulse30S.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdSubPulse30S.TabIndex = 1;
    this.cmdSubPulse30S.Tag = (object) "30";
    this.cmdSubPulse30S.Text = "30 Seconds";
    this.cmdSubPulse30S.UseVisualStyleBackColor = false;
    this.cmdSubPulse30S.Click += new EventHandler(this.cmdSubPulse30D_Click);
    this.cmdSubPulse2M.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSubPulse2M.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSubPulse2M.Location = new Point(288, 0);
    this.cmdSubPulse2M.Margin = new Padding(0);
    this.cmdSubPulse2M.Name = "cmdSubPulse2M";
    this.cmdSubPulse2M.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdSubPulse2M.TabIndex = 2;
    this.cmdSubPulse2M.Tag = (object) "120";
    this.cmdSubPulse2M.Text = "2 Minutes";
    this.cmdSubPulse2M.UseVisualStyleBackColor = false;
    this.cmdSubPulse2M.Click += new EventHandler(this.cmdSubPulse30D_Click);
    this.cmdSubPulse5M.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSubPulse5M.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSubPulse5M.Location = new Point(384, 0);
    this.cmdSubPulse5M.Margin = new Padding(0);
    this.cmdSubPulse5M.Name = "cmdSubPulse5M";
    this.cmdSubPulse5M.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdSubPulse5M.TabIndex = 3;
    this.cmdSubPulse5M.Tag = (object) "300";
    this.cmdSubPulse5M.Text = "5 Minutes";
    this.cmdSubPulse5M.UseVisualStyleBackColor = false;
    this.cmdSubPulse5M.Click += new EventHandler(this.cmdSubPulse30D_Click);
    this.cmdSubPulse20M.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSubPulse20M.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSubPulse20M.Location = new Point(480, 0);
    this.cmdSubPulse20M.Margin = new Padding(0);
    this.cmdSubPulse20M.Name = "cmdSubPulse20M";
    this.cmdSubPulse20M.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdSubPulse20M.TabIndex = 5;
    this.cmdSubPulse20M.Tag = (object) "1200";
    this.cmdSubPulse20M.Text = "20 Minutes";
    this.cmdSubPulse20M.UseVisualStyleBackColor = false;
    this.cmdSubPulse20M.Click += new EventHandler(this.cmdSubPulse30D_Click);
    this.cmdSubPulse1H.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSubPulse1H.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSubPulse1H.Location = new Point(576, 0);
    this.cmdSubPulse1H.Margin = new Padding(0);
    this.cmdSubPulse1H.Name = "cmdSubPulse1H";
    this.cmdSubPulse1H.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdSubPulse1H.TabIndex = 6;
    this.cmdSubPulse1H.Tag = (object) "3600";
    this.cmdSubPulse1H.Text = "1 Hour";
    this.cmdSubPulse1H.UseVisualStyleBackColor = false;
    this.cmdSubPulse1H.Click += new EventHandler(this.cmdSubPulse30D_Click);
    this.cmdSubPulse3H.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSubPulse3H.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSubPulse3H.Location = new Point(672, 0);
    this.cmdSubPulse3H.Margin = new Padding(0);
    this.cmdSubPulse3H.Name = "cmdSubPulse3H";
    this.cmdSubPulse3H.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdSubPulse3H.TabIndex = 7;
    this.cmdSubPulse3H.Tag = (object) "10800";
    this.cmdSubPulse3H.Text = "3 Hours";
    this.cmdSubPulse3H.UseVisualStyleBackColor = false;
    this.cmdSubPulse3H.Click += new EventHandler(this.cmdSubPulse30D_Click);
    this.cmdSubPulse8H.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSubPulse8H.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSubPulse8H.Location = new Point(768 /*0x0300*/, 0);
    this.cmdSubPulse8H.Margin = new Padding(0);
    this.cmdSubPulse8H.Name = "cmdSubPulse8H";
    this.cmdSubPulse8H.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdSubPulse8H.TabIndex = 8;
    this.cmdSubPulse8H.Tag = (object) "28800";
    this.cmdSubPulse8H.Text = "8 Hours";
    this.cmdSubPulse8H.UseVisualStyleBackColor = false;
    this.cmdSubPulse8H.Click += new EventHandler(this.cmdSubPulse30D_Click);
    this.cmdSubPulse1D.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSubPulse1D.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSubPulse1D.Location = new Point(864, 0);
    this.cmdSubPulse1D.Margin = new Padding(0);
    this.cmdSubPulse1D.Name = "cmdSubPulse1D";
    this.cmdSubPulse1D.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdSubPulse1D.TabIndex = 9;
    this.cmdSubPulse1D.Tag = (object) "86400";
    this.cmdSubPulse1D.Text = "1 Day";
    this.cmdSubPulse1D.UseVisualStyleBackColor = false;
    this.cmdSubPulse1D.Click += new EventHandler(this.cmdSubPulse30D_Click);
    this.cmdSubPulse5D.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSubPulse5D.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSubPulse5D.Location = new Point(960, 0);
    this.cmdSubPulse5D.Margin = new Padding(0);
    this.cmdSubPulse5D.Name = "cmdSubPulse5D";
    this.cmdSubPulse5D.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdSubPulse5D.TabIndex = 10;
    this.cmdSubPulse5D.Tag = (object) "432000";
    this.cmdSubPulse5D.Text = "5 Days";
    this.cmdSubPulse5D.UseVisualStyleBackColor = false;
    this.cmdSubPulse5D.Click += new EventHandler(this.cmdSubPulse30D_Click);
    this.cmdSubPulse30D.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSubPulse30D.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSubPulse30D.Location = new Point(1056, 0);
    this.cmdSubPulse30D.Margin = new Padding(0);
    this.cmdSubPulse30D.Name = "cmdSubPulse30D";
    this.cmdSubPulse30D.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
    this.cmdSubPulse30D.TabIndex = 11;
    this.cmdSubPulse30D.Tag = (object) "2592000";
    this.cmdSubPulse30D.Text = "30 Days";
    this.cmdSubPulse30D.UseVisualStyleBackColor = false;
    this.cmdSubPulse30D.Click += new EventHandler(this.cmdSubPulse30D_Click);
    this.flowLayoutPanel2.Controls.Add((Control) this.cboRaces);
    this.flowLayoutPanel2.Controls.Add((Control) this.cboSystems);
    this.flowLayoutPanel2.Controls.Add((Control) this.tabSidebar);
    this.flowLayoutPanel2.Location = new Point(0, 144 /*0x90*/);
    this.flowLayoutPanel2.Name = "flowLayoutPanel2";
    this.flowLayoutPanel2.Size = new Size(336, 721);
    this.flowLayoutPanel2.TabIndex = 10;
    this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboRaces.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboRaces.FormattingEnabled = true;
    this.cboRaces.Location = new Point(3, 3);
    this.cboRaces.Name = "cboRaces";
    this.cboRaces.Size = new Size(332, 21);
    this.cboRaces.TabIndex = 11;
    this.cboRaces.SelectedIndexChanged += new EventHandler(this.cboRaces_SelectedIndexChanged);
    this.cboSystems.AccessibleRole = AccessibleRole.ComboBox;
    this.cboSystems.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboSystems.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboSystems.FormattingEnabled = true;
    this.cboSystems.Location = new Point(3, 30);
    this.cboSystems.Name = "cboSystems";
    this.cboSystems.Size = new Size(332, 21);
    this.cboSystems.TabIndex = 0;
    this.cboSystems.SelectedIndexChanged += new EventHandler(this.cboSystems_SelectedIndexChanged);
    this.tabSidebar.Controls.Add((Control) this.tabDisplay);
    this.tabSidebar.Controls.Add((Control) this.tabContacts);
    this.tabSidebar.Controls.Add((Control) this.tabMinerals);
    this.tabSidebar.Controls.Add((Control) this.tabMineralText);
    this.tabSidebar.Controls.Add((Control) this.tabJump);
    this.tabSidebar.Controls.Add((Control) this.tabGroundSurvey);
    this.tabSidebar.Controls.Add((Control) this.tabBodyInfo);
    this.tabSidebar.Controls.Add((Control) this.tabAllBodies);
    this.tabSidebar.Controls.Add((Control) this.tabMilitary);
    this.tabSidebar.Controls.Add((Control) this.tabWaypoints);
    this.tabSidebar.Controls.Add((Control) this.tabMisc);
    this.tabSidebar.Location = new Point(3, 57);
    this.tabSidebar.Multiline = true;
    this.tabSidebar.Name = "tabSidebar";
    this.tabSidebar.SelectedIndex = 0;
    this.tabSidebar.Size = new Size(332, 664);
    this.tabSidebar.TabIndex = 2;
    this.tabDisplay.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.tabDisplay.Controls.Add((Control) this.flowLayoutPanelDisplay);
    this.tabDisplay.Controls.Add((Control) this.flowLayoutPanel9);
    this.tabDisplay.Location = new Point(4, 40);
    this.tabDisplay.Margin = new Padding(2, 3, 3, 3);
    this.tabDisplay.Name = "tabDisplay";
    this.tabDisplay.Padding = new Padding(3);
    this.tabDisplay.Size = new Size(324, 620);
    this.tabDisplay.TabIndex = 0;
    this.tabDisplay.Text = "Display";
    this.flowLayoutPanelDisplay.BorderStyle = BorderStyle.FixedSingle;
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkEvents);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkEventsAllRaces);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkUseHullNumbers);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkActiveSensors);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkFireControlRange);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkFiringRanges);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkMoveTail);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkGeoPoints);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkSBSurvey);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkBearing);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkOrder);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkEscorts);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkHideOrbitFleets);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkSalvoTarget);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkSalvoOrigin);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkMPC);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkCentre);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkTAD);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkCoordinates);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkMinerals);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkHideSL);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkAstMinOnly);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkAstColOnly);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkPassive10);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkPassive100);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkPassive1000);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkPassive10000);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkNoOverlap);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkAllRace);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkDisplayAllForms);
    this.flowLayoutPanelDisplay.Controls.Add((Control) this.chkHideWreckIDs);
    this.flowLayoutPanelDisplay.FlowDirection = FlowDirection.TopDown;
    this.flowLayoutPanelDisplay.Location = new Point(3, 195);
    this.flowLayoutPanelDisplay.Name = "flowLayoutPanelDisplay";
    this.flowLayoutPanelDisplay.Size = new Size(318, 374);
    this.flowLayoutPanelDisplay.TabIndex = 13;
    this.chkEvents.AutoSize = true;
    this.chkEvents.Location = new Point(2, 3);
    this.chkEvents.Margin = new Padding(2, 3, 3, 3);
    this.chkEvents.Name = "chkEvents";
    this.chkEvents.Padding = new Padding(5, 0, 0, 0);
    this.chkEvents.Size = new Size(64 /*0x40*/, 17);
    this.chkEvents.TabIndex = 30;
    this.chkEvents.Text = "Events";
    this.chkEvents.TextAlign = ContentAlignment.MiddleRight;
    this.chkEvents.UseVisualStyleBackColor = true;
    this.chkEvents.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkEventsAllRaces.AutoSize = true;
    this.chkEventsAllRaces.Location = new Point(2, 26);
    this.chkEventsAllRaces.Margin = new Padding(2, 3, 3, 3);
    this.chkEventsAllRaces.Name = "chkEventsAllRaces";
    this.chkEventsAllRaces.Padding = new Padding(5, 0, 0, 0);
    this.chkEventsAllRaces.Size = new Size(118, 17);
    this.chkEventsAllRaces.TabIndex = 61;
    this.chkEventsAllRaces.Text = "Events - All Races";
    this.chkEventsAllRaces.TextAlign = ContentAlignment.MiddleRight;
    this.chkEventsAllRaces.UseVisualStyleBackColor = true;
    this.chkEventsAllRaces.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkUseHullNumbers.AutoSize = true;
    this.chkUseHullNumbers.Location = new Point(2, 49);
    this.chkUseHullNumbers.Margin = new Padding(2, 3, 3, 3);
    this.chkUseHullNumbers.Name = "chkUseHullNumbers";
    this.chkUseHullNumbers.Padding = new Padding(5, 0, 0, 0);
    this.chkUseHullNumbers.Size = new Size(116, 17);
    this.chkUseHullNumbers.TabIndex = 62;
    this.chkUseHullNumbers.Text = "Use Hull Numbers";
    this.chkUseHullNumbers.UseVisualStyleBackColor = true;
    this.chkUseHullNumbers.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkActiveSensors.AutoSize = true;
    this.chkActiveSensors.Location = new Point(2, 72);
    this.chkActiveSensors.Margin = new Padding(2, 3, 3, 3);
    this.chkActiveSensors.Name = "chkActiveSensors";
    this.chkActiveSensors.Padding = new Padding(5, 0, 0, 0);
    this.chkActiveSensors.Size = new Size(102, 17);
    this.chkActiveSensors.TabIndex = 53;
    this.chkActiveSensors.Text = "Active Sensors";
    this.chkActiveSensors.TextAlign = ContentAlignment.MiddleRight;
    this.chkActiveSensors.UseVisualStyleBackColor = true;
    this.chkActiveSensors.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkFireControlRange.AutoSize = true;
    this.chkFireControlRange.Location = new Point(2, 95);
    this.chkFireControlRange.Margin = new Padding(2, 3, 3, 3);
    this.chkFireControlRange.Name = "chkFireControlRange";
    this.chkFireControlRange.Padding = new Padding(5, 0, 0, 0);
    this.chkFireControlRange.Size = new Size(119, 17);
    this.chkFireControlRange.TabIndex = 43;
    this.chkFireControlRange.Text = "Fire Control Range";
    this.chkFireControlRange.TextAlign = ContentAlignment.MiddleRight;
    this.chkFireControlRange.UseVisualStyleBackColor = true;
    this.chkFireControlRange.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkFiringRanges.AutoSize = true;
    this.chkFiringRanges.Location = new Point(2, 118);
    this.chkFiringRanges.Margin = new Padding(2, 3, 3, 3);
    this.chkFiringRanges.Name = "chkFiringRanges";
    this.chkFiringRanges.Padding = new Padding(5, 0, 0, 0);
    this.chkFiringRanges.Size = new Size(107, 17);
    this.chkFiringRanges.TabIndex = 42;
    this.chkFiringRanges.Text = "Weapon Range";
    this.chkFiringRanges.TextAlign = ContentAlignment.MiddleRight;
    this.chkFiringRanges.UseVisualStyleBackColor = true;
    this.chkFiringRanges.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkMoveTail.AutoSize = true;
    this.chkMoveTail.Location = new Point(2, 141);
    this.chkMoveTail.Margin = new Padding(2, 3, 3, 3);
    this.chkMoveTail.Name = "chkMoveTail";
    this.chkMoveTail.Padding = new Padding(5, 0, 0, 0);
    this.chkMoveTail.Size = new Size(101, 17);
    this.chkMoveTail.TabIndex = 22;
    this.chkMoveTail.Text = "Movement Tail";
    this.chkMoveTail.TextAlign = ContentAlignment.MiddleRight;
    this.chkMoveTail.UseVisualStyleBackColor = true;
    this.chkMoveTail.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkGeoPoints.AutoSize = true;
    this.chkGeoPoints.Location = new Point(2, 164);
    this.chkGeoPoints.Margin = new Padding(2, 3, 3, 3);
    this.chkGeoPoints.Name = "chkGeoPoints";
    this.chkGeoPoints.Padding = new Padding(5, 0, 0, 0);
    this.chkGeoPoints.Size = new Size(119, 17);
    this.chkGeoPoints.TabIndex = 35;
    this.chkGeoPoints.Text = "Geo Survey Points";
    this.chkGeoPoints.TextAlign = ContentAlignment.MiddleRight;
    this.chkGeoPoints.UseVisualStyleBackColor = true;
    this.chkGeoPoints.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkSBSurvey.AutoSize = true;
    this.chkSBSurvey.Location = new Point(2, 187);
    this.chkSBSurvey.Margin = new Padding(2, 3, 3, 3);
    this.chkSBSurvey.Name = "chkSBSurvey";
    this.chkSBSurvey.Padding = new Padding(5, 0, 0, 0);
    this.chkSBSurvey.Size = new Size(111, 17);
    this.chkSBSurvey.TabIndex = 51;
    this.chkSBSurvey.Text = "Surveyed Bodies";
    this.chkSBSurvey.UseVisualStyleBackColor = true;
    this.chkSBSurvey.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkBearing.AutoSize = true;
    this.chkBearing.Location = new Point(2, 210);
    this.chkBearing.Margin = new Padding(2, 3, 3, 3);
    this.chkBearing.Name = "chkBearing";
    this.chkBearing.Padding = new Padding(5, 0, 0, 0);
    this.chkBearing.Size = new Size(97, 17);
    this.chkBearing.TabIndex = 32 /*0x20*/;
    this.chkBearing.Text = "Fleet Heading";
    this.chkBearing.TextAlign = ContentAlignment.MiddleRight;
    this.chkBearing.UseVisualStyleBackColor = true;
    this.chkBearing.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkOrder.AutoSize = true;
    this.chkOrder.Location = new Point(2, 233);
    this.chkOrder.Margin = new Padding(2, 3, 3, 3);
    this.chkOrder.Name = "chkOrder";
    this.chkOrder.Padding = new Padding(5, 0, 0, 0);
    this.chkOrder.Size = new Size(108, 17);
    this.chkOrder.TabIndex = 28;
    this.chkOrder.Text = "Fleet Next Order";
    this.chkOrder.TextAlign = ContentAlignment.MiddleRight;
    this.chkOrder.UseVisualStyleBackColor = true;
    this.chkOrder.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkEscorts.AutoSize = true;
    this.chkEscorts.Location = new Point(2, 256 /*0x0100*/);
    this.chkEscorts.Margin = new Padding(2, 3, 3, 3);
    this.chkEscorts.Name = "chkEscorts";
    this.chkEscorts.Padding = new Padding(5, 0, 0, 0);
    this.chkEscorts.Size = new Size(91, 17);
    this.chkEscorts.TabIndex = 46;
    this.chkEscorts.Text = "Hide Escorts";
    this.chkEscorts.TextAlign = ContentAlignment.MiddleRight;
    this.chkEscorts.UseVisualStyleBackColor = true;
    this.chkEscorts.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkHideOrbitFleets.AutoSize = true;
    this.chkHideOrbitFleets.Location = new Point(2, 279);
    this.chkHideOrbitFleets.Margin = new Padding(2, 3, 3, 3);
    this.chkHideOrbitFleets.Name = "chkHideOrbitFleets";
    this.chkHideOrbitFleets.Padding = new Padding(5, 0, 0, 0);
    this.chkHideOrbitFleets.Size = new Size(120, 17);
    this.chkHideOrbitFleets.TabIndex = 60;
    this.chkHideOrbitFleets.Text = "Hide Fleets in Orbit";
    this.chkHideOrbitFleets.TextAlign = ContentAlignment.MiddleRight;
    this.chkHideOrbitFleets.UseVisualStyleBackColor = true;
    this.chkHideOrbitFleets.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkSalvoTarget.AutoSize = true;
    this.chkSalvoTarget.Location = new Point(2, 302);
    this.chkSalvoTarget.Margin = new Padding(2, 3, 3, 3);
    this.chkSalvoTarget.Name = "chkSalvoTarget";
    this.chkSalvoTarget.Padding = new Padding(5, 0, 0, 0);
    this.chkSalvoTarget.Size = new Size(92, 17);
    this.chkSalvoTarget.TabIndex = 50;
    this.chkSalvoTarget.Text = "Salvo Target";
    this.chkSalvoTarget.TextAlign = ContentAlignment.MiddleRight;
    this.chkSalvoTarget.UseVisualStyleBackColor = true;
    this.chkSalvoTarget.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkSalvoOrigin.AutoSize = true;
    this.chkSalvoOrigin.Location = new Point(2, 325);
    this.chkSalvoOrigin.Margin = new Padding(2, 3, 3, 3);
    this.chkSalvoOrigin.Name = "chkSalvoOrigin";
    this.chkSalvoOrigin.Padding = new Padding(5, 0, 0, 0);
    this.chkSalvoOrigin.Size = new Size(108, 17);
    this.chkSalvoOrigin.TabIndex = 44;
    this.chkSalvoOrigin.Text = "Launch Platform";
    this.chkSalvoOrigin.TextAlign = ContentAlignment.MiddleRight;
    this.chkSalvoOrigin.UseVisualStyleBackColor = true;
    this.chkSalvoOrigin.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkMPC.AutoSize = true;
    this.chkMPC.Location = new Point(2, 348);
    this.chkMPC.Margin = new Padding(2, 3, 3, 3);
    this.chkMPC.Name = "chkMPC";
    this.chkMPC.Padding = new Padding(5, 0, 0, 0);
    this.chkMPC.Size = new Size(105, 17);
    this.chkMPC.TabIndex = 36;
    this.chkMPC.Text = "Packet Content";
    this.chkMPC.UseVisualStyleBackColor = true;
    this.chkMPC.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkCentre.AutoSize = true;
    this.chkCentre.Location = new Point((int) sbyte.MaxValue, 3);
    this.chkCentre.Margin = new Padding(2, 3, 3, 3);
    this.chkCentre.Name = "chkCentre";
    this.chkCentre.Padding = new Padding(5, 0, 0, 0);
    this.chkCentre.Size = new Size(122, 17);
    this.chkCentre.TabIndex = 25;
    this.chkCentre.Text = "Centre on Selected";
    this.chkCentre.TextAlign = ContentAlignment.MiddleRight;
    this.chkCentre.UseVisualStyleBackColor = true;
    this.chkCentre.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkTAD.AutoSize = true;
    this.chkTAD.Location = new Point((int) sbyte.MaxValue, 26);
    this.chkTAD.Margin = new Padding(2, 3, 3, 3);
    this.chkTAD.Name = "chkTAD";
    this.chkTAD.Padding = new Padding(5, 0, 0, 0);
    this.chkTAD.Size = new Size(149, 17);
    this.chkTAD.TabIndex = 31 /*0x1F*/;
    this.chkTAD.Text = "Order Time and Distance";
    this.chkTAD.TextAlign = ContentAlignment.MiddleRight;
    this.chkTAD.UseVisualStyleBackColor = true;
    this.chkTAD.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkCoordinates.AutoSize = true;
    this.chkCoordinates.Location = new Point((int) sbyte.MaxValue, 49);
    this.chkCoordinates.Margin = new Padding(2, 3, 3, 3);
    this.chkCoordinates.Name = "chkCoordinates";
    this.chkCoordinates.Padding = new Padding(5, 0, 0, 0);
    this.chkCoordinates.Size = new Size(142, 17);
    this.chkCoordinates.TabIndex = 38;
    this.chkCoordinates.Text = "Body/Fleet Coordinates";
    this.chkCoordinates.TextAlign = ContentAlignment.MiddleRight;
    this.chkCoordinates.UseVisualStyleBackColor = true;
    this.chkCoordinates.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkMinerals.AutoSize = true;
    this.chkMinerals.Location = new Point((int) sbyte.MaxValue, 72);
    this.chkMinerals.Margin = new Padding(2, 3, 3, 3);
    this.chkMinerals.Name = "chkMinerals";
    this.chkMinerals.Padding = new Padding(5, 0, 0, 0);
    this.chkMinerals.Size = new Size(139, 17);
    this.chkMinerals.TabIndex = 52;
    this.chkMinerals.Text = "Mineral Concentrations";
    this.chkMinerals.UseVisualStyleBackColor = true;
    this.chkMinerals.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkHideSL.AutoSize = true;
    this.chkHideSL.Location = new Point((int) sbyte.MaxValue, 95);
    this.chkHideSL.Margin = new Padding(2, 3, 3, 3);
    this.chkHideSL.Name = "chkHideSL";
    this.chkHideSL.Padding = new Padding(5, 0, 0, 0);
    this.chkHideSL.Size = new Size(150, 17);
    this.chkHideSL.TabIndex = 41;
    this.chkHideSL.Text = "Hide Surveyed Locations";
    this.chkHideSL.TextAlign = ContentAlignment.MiddleRight;
    this.chkHideSL.UseVisualStyleBackColor = true;
    this.chkHideSL.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkAstMinOnly.AutoSize = true;
    this.chkAstMinOnly.Location = new Point((int) sbyte.MaxValue, 118);
    this.chkAstMinOnly.Margin = new Padding(2, 3, 3, 3);
    this.chkAstMinOnly.Name = "chkAstMinOnly";
    this.chkAstMinOnly.Padding = new Padding(5, 0, 0, 0);
    this.chkAstMinOnly.Size = new Size(157, 17);
    this.chkAstMinOnly.TabIndex = 34;
    this.chkAstMinOnly.Text = "Asteroid with Minerals Only";
    this.chkAstMinOnly.TextAlign = ContentAlignment.TopLeft;
    this.chkAstMinOnly.UseVisualStyleBackColor = true;
    this.chkAstMinOnly.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkAstColOnly.AutoSize = true;
    this.chkAstColOnly.Location = new Point((int) sbyte.MaxValue, 141);
    this.chkAstColOnly.Margin = new Padding(2, 3, 3, 3);
    this.chkAstColOnly.Name = "chkAstColOnly";
    this.chkAstColOnly.Padding = new Padding(5, 0, 0, 0);
    this.chkAstColOnly.Size = new Size(158, 17);
    this.chkAstColOnly.TabIndex = 33;
    this.chkAstColOnly.Text = "Asteroid with Colonies Only";
    this.chkAstColOnly.TextAlign = ContentAlignment.MiddleRight;
    this.chkAstColOnly.UseVisualStyleBackColor = true;
    this.chkAstColOnly.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkPassive10.AutoSize = true;
    this.chkPassive10.Location = new Point((int) sbyte.MaxValue, 164);
    this.chkPassive10.Margin = new Padding(2, 3, 3, 3);
    this.chkPassive10.Name = "chkPassive10";
    this.chkPassive10.Padding = new Padding(5, 0, 0, 0);
    this.chkPassive10.Size = new Size(145, 17);
    this.chkPassive10.TabIndex = 54;
    this.chkPassive10.Text = "Passive vs Signature 10";
    this.chkPassive10.TextAlign = ContentAlignment.MiddleRight;
    this.chkPassive10.UseVisualStyleBackColor = true;
    this.chkPassive10.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkPassive100.AutoSize = true;
    this.chkPassive100.Location = new Point((int) sbyte.MaxValue, 187);
    this.chkPassive100.Margin = new Padding(2, 3, 3, 3);
    this.chkPassive100.Name = "chkPassive100";
    this.chkPassive100.Padding = new Padding(5, 0, 0, 0);
    this.chkPassive100.Size = new Size(151, 17);
    this.chkPassive100.TabIndex = 55;
    this.chkPassive100.Text = "Passive vs Signature 100";
    this.chkPassive100.TextAlign = ContentAlignment.MiddleRight;
    this.chkPassive100.UseVisualStyleBackColor = true;
    this.chkPassive100.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkPassive1000.AutoSize = true;
    this.chkPassive1000.Location = new Point((int) sbyte.MaxValue, 210);
    this.chkPassive1000.Margin = new Padding(2, 3, 3, 3);
    this.chkPassive1000.Name = "chkPassive1000";
    this.chkPassive1000.Padding = new Padding(5, 0, 0, 0);
    this.chkPassive1000.Size = new Size(157, 17);
    this.chkPassive1000.TabIndex = 56;
    this.chkPassive1000.Text = "Passive vs Signature 1000";
    this.chkPassive1000.TextAlign = ContentAlignment.MiddleRight;
    this.chkPassive1000.UseVisualStyleBackColor = true;
    this.chkPassive1000.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkPassive10000.AutoSize = true;
    this.chkPassive10000.Location = new Point((int) sbyte.MaxValue, 233);
    this.chkPassive10000.Margin = new Padding(2, 3, 3, 3);
    this.chkPassive10000.Name = "chkPassive10000";
    this.chkPassive10000.Padding = new Padding(5, 0, 0, 0);
    this.chkPassive10000.Size = new Size(166, 17);
    this.chkPassive10000.TabIndex = 59;
    this.chkPassive10000.Text = "Passive vs Signature 10,000";
    this.chkPassive10000.TextAlign = ContentAlignment.MiddleRight;
    this.chkPassive10000.UseVisualStyleBackColor = true;
    this.chkPassive10000.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkNoOverlap.AutoSize = true;
    this.chkNoOverlap.Location = new Point((int) sbyte.MaxValue, 256 /*0x0100*/);
    this.chkNoOverlap.Margin = new Padding(2, 3, 3, 3);
    this.chkNoOverlap.Name = "chkNoOverlap";
    this.chkNoOverlap.Padding = new Padding(5, 0, 0, 0);
    this.chkNoOverlap.Size = new Size(152, 17);
    this.chkNoOverlap.TabIndex = 40;
    this.chkNoOverlap.Text = "No Child/Parent Overlaps";
    this.chkNoOverlap.TextAlign = ContentAlignment.MiddleRight;
    this.chkNoOverlap.UseVisualStyleBackColor = true;
    this.chkNoOverlap.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkAllRace.AutoSize = true;
    this.chkAllRace.Location = new Point((int) sbyte.MaxValue, 279);
    this.chkAllRace.Margin = new Padding(2, 3, 3, 3);
    this.chkAllRace.Name = "chkAllRace";
    this.chkAllRace.Padding = new Padding(5, 0, 0, 0);
    this.chkAllRace.Size = new Size(165, 17);
    this.chkAllRace.TabIndex = 57;
    this.chkAllRace.Text = "All Windows Linked to Race";
    this.chkAllRace.TextAlign = ContentAlignment.MiddleRight;
    this.chkAllRace.UseVisualStyleBackColor = true;
    this.chkAllRace.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkDisplayAllForms.AutoSize = true;
    this.chkDisplayAllForms.Location = new Point((int) sbyte.MaxValue, 302);
    this.chkDisplayAllForms.Margin = new Padding(2, 3, 3, 3);
    this.chkDisplayAllForms.Name = "chkDisplayAllForms";
    this.chkDisplayAllForms.Padding = new Padding(5, 0, 0, 0);
    this.chkDisplayAllForms.Size = new Size(169, 17);
    this.chkDisplayAllForms.TabIndex = 58;
    this.chkDisplayAllForms.Text = "Keep Tactical in Background";
    this.chkDisplayAllForms.TextAlign = ContentAlignment.MiddleRight;
    this.chkDisplayAllForms.UseVisualStyleBackColor = true;
    this.chkDisplayAllForms.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkHideWreckIDs.AutoSize = true;
    this.chkHideWreckIDs.Location = new Point((int) sbyte.MaxValue, 325);
    this.chkHideWreckIDs.Margin = new Padding(2, 3, 3, 3);
    this.chkHideWreckIDs.Name = "chkHideWreckIDs";
    this.chkHideWreckIDs.Padding = new Padding(5, 0, 0, 0);
    this.chkHideWreckIDs.Size = new Size(142, 17);
    this.chkHideWreckIDs.TabIndex = 63 /*0x3F*/;
    this.chkHideWreckIDs.Text = "Group Wrecks by Class";
    this.chkHideWreckIDs.TextAlign = ContentAlignment.MiddleRight;
    this.chkHideWreckIDs.UseVisualStyleBackColor = true;
    this.chkHideWreckIDs.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.flowLayoutPanel9.BorderStyle = BorderStyle.FixedSingle;
    this.flowLayoutPanel9.Controls.Add((Control) this.chkColonies);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkWP);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkPlanets);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkDwarf);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkMoons);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkAst);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkFleets);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkStarOrbits);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkPlanetOrbits);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkDwarfOrbits);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkCometPath);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkMoonOrbits);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkAsteroidOrbits);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkSelectedOrbit);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkStarNames);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkPlanetNames);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkDwarfNames);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkMoonNames);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkAstNames);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkLifepods);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkWrecks);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkWaypoint);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkSL);
    this.flowLayoutPanel9.Controls.Add((Control) this.chkPackets);
    this.flowLayoutPanel9.FlowDirection = FlowDirection.TopDown;
    this.flowLayoutPanel9.Location = new Point(3, 3);
    this.flowLayoutPanel9.Margin = new Padding(2, 3, 3, 3);
    this.flowLayoutPanel9.Name = "flowLayoutPanel9";
    this.flowLayoutPanel9.Size = new Size(318, 189);
    this.flowLayoutPanel9.TabIndex = 14;
    this.chkColonies.AutoSize = true;
    this.chkColonies.Location = new Point(2, 3);
    this.chkColonies.Margin = new Padding(2, 3, 3, 3);
    this.chkColonies.Name = "chkColonies";
    this.chkColonies.Padding = new Padding(5, 0, 0, 0);
    this.chkColonies.Size = new Size(71, 17);
    this.chkColonies.TabIndex = 23;
    this.chkColonies.Text = "Colonies";
    this.chkColonies.TextAlign = ContentAlignment.MiddleRight;
    this.chkColonies.UseVisualStyleBackColor = true;
    this.chkColonies.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkWP.AutoSize = true;
    this.chkWP.Location = new Point(2, 26);
    this.chkWP.Margin = new Padding(2, 3, 3, 3);
    this.chkWP.Name = "chkWP";
    this.chkWP.Padding = new Padding(5, 0, 0, 0);
    this.chkWP.Size = new Size(88, 17);
    this.chkWP.TabIndex = 0;
    this.chkWP.Text = "Jump Points";
    this.chkWP.TextAlign = ContentAlignment.MiddleRight;
    this.chkWP.UseVisualStyleBackColor = true;
    this.chkWP.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkPlanets.AutoSize = true;
    this.chkPlanets.Location = new Point(2, 49);
    this.chkPlanets.Margin = new Padding(2, 3, 3, 3);
    this.chkPlanets.Name = "chkPlanets";
    this.chkPlanets.Padding = new Padding(5, 0, 0, 0);
    this.chkPlanets.Size = new Size(66, 17);
    this.chkPlanets.TabIndex = 1;
    this.chkPlanets.Text = "Planets";
    this.chkPlanets.TextAlign = ContentAlignment.MiddleRight;
    this.chkPlanets.UseVisualStyleBackColor = true;
    this.chkPlanets.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkDwarf.AutoSize = true;
    this.chkDwarf.Location = new Point(2, 72);
    this.chkDwarf.Margin = new Padding(2, 3, 3, 3);
    this.chkDwarf.Name = "chkDwarf";
    this.chkDwarf.Padding = new Padding(5, 0, 0, 0);
    this.chkDwarf.Size = new Size(97, 17);
    this.chkDwarf.TabIndex = 2;
    this.chkDwarf.Text = "Dwarf Planets";
    this.chkDwarf.TextAlign = ContentAlignment.MiddleRight;
    this.chkDwarf.UseVisualStyleBackColor = true;
    this.chkDwarf.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkMoons.AutoSize = true;
    this.chkMoons.Location = new Point(2, 95);
    this.chkMoons.Margin = new Padding(2, 3, 3, 3);
    this.chkMoons.Name = "chkMoons";
    this.chkMoons.Padding = new Padding(5, 0, 0, 0);
    this.chkMoons.Size = new Size(63 /*0x3F*/, 17);
    this.chkMoons.TabIndex = 5;
    this.chkMoons.Text = "Moons";
    this.chkMoons.TextAlign = ContentAlignment.MiddleRight;
    this.chkMoons.UseVisualStyleBackColor = true;
    this.chkMoons.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkAst.AutoSize = true;
    this.chkAst.Location = new Point(2, 118);
    this.chkAst.Margin = new Padding(2, 3, 3, 3);
    this.chkAst.Name = "chkAst";
    this.chkAst.Padding = new Padding(5, 0, 0, 0);
    this.chkAst.Size = new Size(74, 17);
    this.chkAst.TabIndex = 19;
    this.chkAst.Text = "Asteroids";
    this.chkAst.TextAlign = ContentAlignment.MiddleRight;
    this.chkAst.UseVisualStyleBackColor = true;
    this.chkAst.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkFleets.AutoSize = true;
    this.chkFleets.Location = new Point(2, 141);
    this.chkFleets.Margin = new Padding(2, 3, 3, 3);
    this.chkFleets.Name = "chkFleets";
    this.chkFleets.Padding = new Padding(5, 0, 0, 0);
    this.chkFleets.Size = new Size(59, 17);
    this.chkFleets.TabIndex = 21;
    this.chkFleets.Text = "Fleets";
    this.chkFleets.TextAlign = ContentAlignment.MiddleRight;
    this.chkFleets.UseVisualStyleBackColor = true;
    this.chkFleets.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkStarOrbits.AutoSize = true;
    this.chkStarOrbits.Location = new Point(2, 164);
    this.chkStarOrbits.Margin = new Padding(2, 3, 3, 3);
    this.chkStarOrbits.Name = "chkStarOrbits";
    this.chkStarOrbits.Padding = new Padding(5, 0, 0, 0);
    this.chkStarOrbits.Size = new Size(80 /*0x50*/, 17);
    this.chkStarOrbits.TabIndex = 15;
    this.chkStarOrbits.Text = "Star Orbits";
    this.chkStarOrbits.TextAlign = ContentAlignment.MiddleRight;
    this.chkStarOrbits.UseVisualStyleBackColor = true;
    this.chkStarOrbits.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkPlanetOrbits.AutoSize = true;
    this.chkPlanetOrbits.Location = new Point(104, 3);
    this.chkPlanetOrbits.Margin = new Padding(2, 3, 3, 3);
    this.chkPlanetOrbits.Name = "chkPlanetOrbits";
    this.chkPlanetOrbits.Padding = new Padding(5, 0, 0, 0);
    this.chkPlanetOrbits.Size = new Size(91, 17);
    this.chkPlanetOrbits.TabIndex = 16 /*0x10*/;
    this.chkPlanetOrbits.Text = "Planet Orbits";
    this.chkPlanetOrbits.TextAlign = ContentAlignment.MiddleRight;
    this.chkPlanetOrbits.UseVisualStyleBackColor = true;
    this.chkPlanetOrbits.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkDwarfOrbits.AutoSize = true;
    this.chkDwarfOrbits.Location = new Point(104, 26);
    this.chkDwarfOrbits.Margin = new Padding(2, 3, 3, 3);
    this.chkDwarfOrbits.Name = "chkDwarfOrbits";
    this.chkDwarfOrbits.Padding = new Padding(5, 0, 0, 0);
    this.chkDwarfOrbits.Size = new Size(89, 17);
    this.chkDwarfOrbits.TabIndex = 13;
    this.chkDwarfOrbits.Text = "Dwarf Orbits";
    this.chkDwarfOrbits.TextAlign = ContentAlignment.MiddleRight;
    this.chkDwarfOrbits.UseVisualStyleBackColor = true;
    this.chkDwarfOrbits.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkCometPath.AutoSize = true;
    this.chkCometPath.Location = new Point(104, 49);
    this.chkCometPath.Margin = new Padding(2, 3, 3, 3);
    this.chkCometPath.Name = "chkCometPath";
    this.chkCometPath.Padding = new Padding(5, 0, 0, 0);
    this.chkCometPath.Size = new Size(91, 17);
    this.chkCometPath.TabIndex = 24;
    this.chkCometPath.Text = "Comet Orbits";
    this.chkCometPath.TextAlign = ContentAlignment.MiddleRight;
    this.chkCometPath.UseVisualStyleBackColor = true;
    this.chkCometPath.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkMoonOrbits.AutoSize = true;
    this.chkMoonOrbits.Location = new Point(104, 72);
    this.chkMoonOrbits.Margin = new Padding(2, 3, 3, 3);
    this.chkMoonOrbits.Name = "chkMoonOrbits";
    this.chkMoonOrbits.Padding = new Padding(5, 0, 0, 0);
    this.chkMoonOrbits.Size = new Size(88, 17);
    this.chkMoonOrbits.TabIndex = 17;
    this.chkMoonOrbits.Text = "Moon Orbits";
    this.chkMoonOrbits.TextAlign = ContentAlignment.MiddleRight;
    this.chkMoonOrbits.UseVisualStyleBackColor = true;
    this.chkMoonOrbits.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkAsteroidOrbits.AutoSize = true;
    this.chkAsteroidOrbits.Location = new Point(104, 95);
    this.chkAsteroidOrbits.Margin = new Padding(2, 3, 3, 3);
    this.chkAsteroidOrbits.Name = "chkAsteroidOrbits";
    this.chkAsteroidOrbits.Padding = new Padding(5, 0, 0, 0);
    this.chkAsteroidOrbits.Size = new Size(99, 17);
    this.chkAsteroidOrbits.TabIndex = 20;
    this.chkAsteroidOrbits.Text = "Asteroid Orbits";
    this.chkAsteroidOrbits.TextAlign = ContentAlignment.MiddleRight;
    this.chkAsteroidOrbits.UseVisualStyleBackColor = true;
    this.chkAsteroidOrbits.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkSelectedOrbit.AutoSize = true;
    this.chkSelectedOrbit.Location = new Point(104, 118);
    this.chkSelectedOrbit.Margin = new Padding(2, 3, 3, 3);
    this.chkSelectedOrbit.Name = "chkSelectedOrbit";
    this.chkSelectedOrbit.Padding = new Padding(5, 0, 0, 0);
    this.chkSelectedOrbit.Size = new Size(98, 17);
    this.chkSelectedOrbit.TabIndex = 40;
    this.chkSelectedOrbit.Text = "Selected Orbit";
    this.chkSelectedOrbit.TextAlign = ContentAlignment.MiddleRight;
    this.chkSelectedOrbit.UseVisualStyleBackColor = true;
    this.chkSelectedOrbit.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkStarNames.AutoSize = true;
    this.chkStarNames.Location = new Point(104, 141);
    this.chkStarNames.Margin = new Padding(2, 3, 3, 3);
    this.chkStarNames.Name = "chkStarNames";
    this.chkStarNames.Padding = new Padding(5, 0, 0, 0);
    this.chkStarNames.Size = new Size(86, 17);
    this.chkStarNames.TabIndex = 6;
    this.chkStarNames.Text = "Star Names";
    this.chkStarNames.TextAlign = ContentAlignment.MiddleRight;
    this.chkStarNames.UseVisualStyleBackColor = true;
    this.chkStarNames.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkPlanetNames.AutoSize = true;
    this.chkPlanetNames.Location = new Point(104, 164);
    this.chkPlanetNames.Margin = new Padding(2, 3, 3, 3);
    this.chkPlanetNames.Name = "chkPlanetNames";
    this.chkPlanetNames.Padding = new Padding(5, 0, 0, 0);
    this.chkPlanetNames.Size = new Size(97, 17);
    this.chkPlanetNames.TabIndex = 7;
    this.chkPlanetNames.Text = "Planet Names";
    this.chkPlanetNames.TextAlign = ContentAlignment.MiddleRight;
    this.chkPlanetNames.UseVisualStyleBackColor = true;
    this.chkPlanetNames.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkDwarfNames.AutoSize = true;
    this.chkDwarfNames.Location = new Point(208 /*0xD0*/, 3);
    this.chkDwarfNames.Margin = new Padding(2, 3, 3, 3);
    this.chkDwarfNames.Name = "chkDwarfNames";
    this.chkDwarfNames.Padding = new Padding(5, 0, 0, 0);
    this.chkDwarfNames.Size = new Size(95, 17);
    this.chkDwarfNames.TabIndex = 14;
    this.chkDwarfNames.Text = "Dwarf Names";
    this.chkDwarfNames.TextAlign = ContentAlignment.MiddleRight;
    this.chkDwarfNames.UseVisualStyleBackColor = true;
    this.chkDwarfNames.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkMoonNames.AutoSize = true;
    this.chkMoonNames.Location = new Point(208 /*0xD0*/, 26);
    this.chkMoonNames.Margin = new Padding(2, 3, 3, 3);
    this.chkMoonNames.Name = "chkMoonNames";
    this.chkMoonNames.Padding = new Padding(5, 0, 0, 0);
    this.chkMoonNames.Size = new Size(94, 17);
    this.chkMoonNames.TabIndex = 18;
    this.chkMoonNames.Text = "Moon Names";
    this.chkMoonNames.TextAlign = ContentAlignment.MiddleRight;
    this.chkMoonNames.UseVisualStyleBackColor = true;
    this.chkMoonNames.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkAstNames.AutoSize = true;
    this.chkAstNames.Location = new Point(208 /*0xD0*/, 49);
    this.chkAstNames.Margin = new Padding(2, 3, 3, 3);
    this.chkAstNames.Name = "chkAstNames";
    this.chkAstNames.Padding = new Padding(5, 0, 0, 0);
    this.chkAstNames.Size = new Size(105, 17);
    this.chkAstNames.TabIndex = 3;
    this.chkAstNames.Text = "Asteroid Names";
    this.chkAstNames.TextAlign = ContentAlignment.MiddleRight;
    this.chkAstNames.UseVisualStyleBackColor = true;
    this.chkAstNames.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkLifepods.AutoSize = true;
    this.chkLifepods.Location = new Point(208 /*0xD0*/, 72);
    this.chkLifepods.Margin = new Padding(2, 3, 3, 3);
    this.chkLifepods.Name = "chkLifepods";
    this.chkLifepods.Padding = new Padding(5, 0, 0, 0);
    this.chkLifepods.Size = new Size(71, 17);
    this.chkLifepods.TabIndex = 37;
    this.chkLifepods.Text = "Lifepods";
    this.chkLifepods.TextAlign = ContentAlignment.MiddleRight;
    this.chkLifepods.UseVisualStyleBackColor = true;
    this.chkLifepods.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkWrecks.AutoSize = true;
    this.chkWrecks.Location = new Point(208 /*0xD0*/, 95);
    this.chkWrecks.Margin = new Padding(2, 3, 3, 3);
    this.chkWrecks.Name = "chkWrecks";
    this.chkWrecks.Padding = new Padding(5, 0, 0, 0);
    this.chkWrecks.Size = new Size(68, 17);
    this.chkWrecks.TabIndex = 29;
    this.chkWrecks.Text = "Wrecks";
    this.chkWrecks.TextAlign = ContentAlignment.MiddleRight;
    this.chkWrecks.UseVisualStyleBackColor = true;
    this.chkWrecks.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkWaypoint.AutoSize = true;
    this.chkWaypoint.Location = new Point(208 /*0xD0*/, 118);
    this.chkWaypoint.Margin = new Padding(2, 3, 3, 3);
    this.chkWaypoint.Name = "chkWaypoint";
    this.chkWaypoint.Padding = new Padding(5, 0, 0, 0);
    this.chkWaypoint.Size = new Size(81, 17);
    this.chkWaypoint.TabIndex = 27;
    this.chkWaypoint.Text = "Waypoints";
    this.chkWaypoint.TextAlign = ContentAlignment.MiddleRight;
    this.chkWaypoint.UseVisualStyleBackColor = true;
    this.chkWaypoint.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkSL.AutoSize = true;
    this.chkSL.Location = new Point(208 /*0xD0*/, 141);
    this.chkSL.Margin = new Padding(2, 3, 3, 3);
    this.chkSL.Name = "chkSL";
    this.chkSL.Padding = new Padding(5, 0, 0, 0);
    this.chkSL.Size = new Size(113, 17);
    this.chkSL.TabIndex = 26;
    this.chkSL.Text = "Survey Locations";
    this.chkSL.TextAlign = ContentAlignment.MiddleRight;
    this.chkSL.UseVisualStyleBackColor = true;
    this.chkSL.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.chkPackets.AutoSize = true;
    this.chkPackets.Location = new Point(208 /*0xD0*/, 164);
    this.chkPackets.Margin = new Padding(2, 3, 3, 3);
    this.chkPackets.Name = "chkPackets";
    this.chkPackets.Padding = new Padding(5, 0, 0, 0);
    this.chkPackets.Size = new Size(107, 17);
    this.chkPackets.TabIndex = 39;
    this.chkPackets.Text = "Mineral Packets";
    this.chkPackets.TextAlign = ContentAlignment.MiddleRight;
    this.chkPackets.UseVisualStyleBackColor = true;
    this.chkPackets.CheckedChanged += new EventHandler(this.chkTracking_Click);
    this.tabContacts.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.tabContacts.Controls.Add((Control) this.flowLayoutPanelContacts);
    this.tabContacts.Location = new Point(4, 40);
    this.tabContacts.Name = "tabContacts";
    this.tabContacts.Padding = new Padding(3);
    this.tabContacts.Size = new Size(324, 620);
    this.tabContacts.TabIndex = 2;
    this.tabContacts.Text = "Contacts";
    this.flowLayoutPanelContacts.Controls.Add((Control) this.flowLayoutPanel6);
    this.flowLayoutPanelContacts.Controls.Add((Control) this.flowLayoutPanel4);
    this.flowLayoutPanelContacts.Controls.Add((Control) this.flowLayoutPanel5);
    this.flowLayoutPanelContacts.Dock = DockStyle.Top;
    this.flowLayoutPanelContacts.Location = new Point(3, 3);
    this.flowLayoutPanelContacts.Name = "flowLayoutPanelContacts";
    this.flowLayoutPanelContacts.Size = new Size(318, 614);
    this.flowLayoutPanelContacts.TabIndex = 0;
    this.flowLayoutPanel6.Controls.Add((Control) this.chkHostile);
    this.flowLayoutPanel6.Controls.Add((Control) this.chkNeutral);
    this.flowLayoutPanel6.Controls.Add((Control) this.chkFriendly);
    this.flowLayoutPanel6.Controls.Add((Control) this.chkAllied);
    this.flowLayoutPanel6.Controls.Add((Control) this.chkCivilian);
    this.flowLayoutPanel6.Controls.Add((Control) this.chkActiveOnly);
    this.flowLayoutPanel6.Controls.Add((Control) this.chkHideIDs);
    this.flowLayoutPanel6.Controls.Add((Control) this.chkHostileSensors);
    this.flowLayoutPanel6.Controls.Add((Control) this.chkShowDist);
    this.flowLayoutPanel6.Controls.Add((Control) this.chkTracking);
    this.flowLayoutPanel6.Controls.Add((Control) this.chkLostContactsOneDay);
    this.flowLayoutPanel6.Controls.Add((Control) this.chkLostContacts);
    this.flowLayoutPanel6.Controls.Add((Control) this.chkLostContactsOneYear);
    this.flowLayoutPanel6.Controls.Add((Control) this.ckNoSensors);
    this.flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
    this.flowLayoutPanel6.Location = new Point(3, 3);
    this.flowLayoutPanel6.Name = "flowLayoutPanel6";
    this.flowLayoutPanel6.Size = new Size(318, 119);
    this.flowLayoutPanel6.TabIndex = 0;
    this.chkHostile.AutoSize = true;
    this.chkHostile.Location = new Point(3, 3);
    this.chkHostile.Name = "chkHostile";
    this.chkHostile.Size = new Size(58, 17);
    this.chkHostile.TabIndex = 12;
    this.chkHostile.Text = "Hostile";
    this.chkHostile.UseVisualStyleBackColor = true;
    this.chkHostile.Click += new EventHandler(this.chkTracking_Click);
    this.chkNeutral.AutoSize = true;
    this.chkNeutral.Location = new Point(3, 26);
    this.chkNeutral.Name = "chkNeutral";
    this.chkNeutral.Size = new Size(60, 17);
    this.chkNeutral.TabIndex = 31 /*0x1F*/;
    this.chkNeutral.Text = "Neutral";
    this.chkNeutral.UseVisualStyleBackColor = true;
    this.chkNeutral.Click += new EventHandler(this.chkTracking_Click);
    this.chkFriendly.AutoSize = true;
    this.chkFriendly.Location = new Point(3, 49);
    this.chkFriendly.Name = "chkFriendly";
    this.chkFriendly.Size = new Size(62, 17);
    this.chkFriendly.TabIndex = 31 /*0x1F*/;
    this.chkFriendly.Text = "Friendly";
    this.chkFriendly.UseVisualStyleBackColor = true;
    this.chkFriendly.Click += new EventHandler(this.chkTracking_Click);
    this.chkAllied.AutoSize = true;
    this.chkAllied.Location = new Point(3, 72);
    this.chkAllied.Name = "chkAllied";
    this.chkAllied.Size = new Size(51, 17);
    this.chkAllied.TabIndex = 30;
    this.chkAllied.Text = "Allied";
    this.chkAllied.UseVisualStyleBackColor = true;
    this.chkAllied.Click += new EventHandler(this.chkTracking_Click);
    this.chkCivilian.AutoSize = true;
    this.chkCivilian.Location = new Point(3, 95);
    this.chkCivilian.Name = "chkCivilian";
    this.chkCivilian.Size = new Size(64 /*0x40*/, 17);
    this.chkCivilian.TabIndex = 29;
    this.chkCivilian.Text = "Civilians";
    this.chkCivilian.UseVisualStyleBackColor = true;
    this.chkCivilian.Click += new EventHandler(this.chkTracking_Click);
    this.chkActiveOnly.AutoSize = true;
    this.chkActiveOnly.Location = new Point(73, 3);
    this.chkActiveOnly.Name = "chkActiveOnly";
    this.chkActiveOnly.Size = new Size(80 /*0x50*/, 17);
    this.chkActiveOnly.TabIndex = 18;
    this.chkActiveOnly.Text = "Active Only";
    this.chkActiveOnly.UseVisualStyleBackColor = true;
    this.chkActiveOnly.Click += new EventHandler(this.chkTracking_Click);
    this.chkHideIDs.AutoSize = true;
    this.chkHideIDs.Location = new Point(73, 26);
    this.chkHideIDs.Name = "chkHideIDs";
    this.chkHideIDs.Size = new Size(100, 17);
    this.chkHideIDs.TabIndex = 14;
    this.chkHideIDs.Text = "Group Contacts";
    this.chkHideIDs.UseVisualStyleBackColor = true;
    this.chkHideIDs.CheckedChanged += new EventHandler(this.chkHideIDs_CheckedChanged);
    this.chkHideIDs.Click += new EventHandler(this.chkTracking_Click);
    this.chkHostileSensors.AutoSize = true;
    this.chkHostileSensors.Location = new Point(73, 49);
    this.chkHostileSensors.Name = "chkHostileSensors";
    this.chkHostileSensors.Size = new Size(94, 17);
    this.chkHostileSensors.TabIndex = 17;
    this.chkHostileSensors.Text = "Sensor Range";
    this.chkHostileSensors.UseVisualStyleBackColor = true;
    this.chkHostileSensors.Click += new EventHandler(this.chkTracking_Click);
    this.chkShowDist.AutoSize = true;
    this.chkShowDist.Location = new Point(73, 72);
    this.chkShowDist.Name = "chkShowDist";
    this.chkShowDist.Size = new Size(73, 17);
    this.chkShowDist.TabIndex = 16 /*0x10*/;
    this.chkShowDist.Text = "Distances";
    this.chkShowDist.UseVisualStyleBackColor = true;
    this.chkShowDist.Click += new EventHandler(this.chkTracking_Click);
    this.chkTracking.AutoSize = true;
    this.chkTracking.Location = new Point(73, 95);
    this.chkTracking.Name = "chkTracking";
    this.chkTracking.Size = new Size(101, 17);
    this.chkTracking.TabIndex = 13;
    this.chkTracking.Text = "Tracking Bonus";
    this.chkTracking.UseVisualStyleBackColor = true;
    this.chkTracking.Click += new EventHandler(this.chkTracking_Click);
    this.chkLostContactsOneDay.AutoSize = true;
    this.chkLostContactsOneDay.Location = new Point(180, 3);
    this.chkLostContactsOneDay.Name = "chkLostContactsOneDay";
    this.chkLostContactsOneDay.Size = new Size(122, 17);
    this.chkLostContactsOneDay.TabIndex = 57;
    this.chkLostContactsOneDay.Text = "Lost Contacts 1 Day";
    this.chkLostContactsOneDay.UseVisualStyleBackColor = true;
    this.chkLostContactsOneDay.CheckedChanged += new EventHandler(this.chkLostContactsOneYear_CheckedChanged);
    this.chkLostContacts.AutoSize = true;
    this.chkLostContacts.Location = new Point(180, 26);
    this.chkLostContacts.Name = "chkLostContacts";
    this.chkLostContacts.Size = new Size(133, 17);
    this.chkLostContacts.TabIndex = 15;
    this.chkLostContacts.Text = "Lost Contacts 1 Month";
    this.chkLostContacts.UseVisualStyleBackColor = true;
    this.chkLostContacts.CheckedChanged += new EventHandler(this.chkLostContactsOneYear_CheckedChanged);
    this.chkLostContactsOneYear.AutoSize = true;
    this.chkLostContactsOneYear.Location = new Point(180, 49);
    this.chkLostContactsOneYear.Name = "chkLostContactsOneYear";
    this.chkLostContactsOneYear.Size = new Size(125, 17);
    this.chkLostContactsOneYear.TabIndex = 56;
    this.chkLostContactsOneYear.Text = "Lost Contacts 1 Year";
    this.chkLostContactsOneYear.UseVisualStyleBackColor = true;
    this.chkLostContactsOneYear.CheckedChanged += new EventHandler(this.chkLostContactsOneYear_CheckedChanged);
    this.ckNoSensors.AutoSize = true;
    this.ckNoSensors.Location = new Point(180, 72);
    this.ckNoSensors.Name = "ckNoSensors";
    this.ckNoSensors.Size = new Size(124, 17);
    this.ckNoSensors.TabIndex = 55;
    this.ckNoSensors.Text = "SM: Disable Sensors";
    this.ckNoSensors.TextAlign = ContentAlignment.MiddleRight;
    this.ckNoSensors.UseVisualStyleBackColor = true;
    this.ckNoSensors.CheckedChanged += new EventHandler(this.ckNoSensors_CheckedChanged);
    this.flowLayoutPanel4.Controls.Add((Control) this.label7);
    this.flowLayoutPanel4.Controls.Add((Control) this.cboContactRaceFilter);
    this.flowLayoutPanel4.Location = new Point(3, 125);
    this.flowLayoutPanel4.Margin = new Padding(3, 0, 3, 0);
    this.flowLayoutPanel4.Name = "flowLayoutPanel4";
    this.flowLayoutPanel4.Size = new Size(315, 46);
    this.flowLayoutPanel4.TabIndex = 25;
    this.label7.AutoSize = true;
    this.label7.Location = new Point(3, 0);
    this.label7.Name = "label7";
    this.label7.Size = new Size(161, 13);
    this.label7.TabIndex = 25;
    this.label7.Text = "Display single race contacts only";
    this.cboContactRaceFilter.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboContactRaceFilter.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboContactRaceFilter.FormattingEnabled = true;
    this.cboContactRaceFilter.Location = new Point(3, 16 /*0x10*/);
    this.cboContactRaceFilter.Name = "cboContactRaceFilter";
    this.cboContactRaceFilter.Size = new Size(309, 21);
    this.cboContactRaceFilter.TabIndex = 29;
    this.cboContactRaceFilter.SelectedIndexChanged += new EventHandler(this.cboContactRaceFilter_SelectedIndexChanged);
    this.flowLayoutPanel5.Controls.Add((Control) this.label6);
    this.flowLayoutPanel5.Controls.Add((Control) this.chkContactsCurrentSystem);
    this.flowLayoutPanel5.Controls.Add((Control) this.tvContacts);
    this.flowLayoutPanel5.Controls.Add((Control) this.lblLocation);
    this.flowLayoutPanel5.Location = new Point(3, 172);
    this.flowLayoutPanel5.Margin = new Padding(3, 1, 3, 3);
    this.flowLayoutPanel5.Name = "flowLayoutPanel5";
    this.flowLayoutPanel5.Size = new Size(312, 440);
    this.flowLayoutPanel5.TabIndex = 28;
    this.label6.AutoSize = true;
    this.label6.Location = new Point(3, 1);
    this.label6.Margin = new Padding(3, 1, 3, 0);
    this.label6.Name = "label6";
    this.label6.Size = new Size(110, 13);
    this.label6.TabIndex = 27;
    this.label6.Text = "Complete Contact List";
    this.chkContactsCurrentSystem.AutoSize = true;
    this.chkContactsCurrentSystem.Dock = DockStyle.Right;
    this.chkContactsCurrentSystem.Location = new Point(181, 0);
    this.chkContactsCurrentSystem.Margin = new Padding(65, 0, 3, 0);
    this.chkContactsCurrentSystem.Name = "chkContactsCurrentSystem";
    this.chkContactsCurrentSystem.Size = new Size(121, 17);
    this.chkContactsCurrentSystem.TabIndex = 29;
    this.chkContactsCurrentSystem.Text = "Current System Only";
    this.chkContactsCurrentSystem.UseVisualStyleBackColor = true;
    this.chkContactsCurrentSystem.Click += new EventHandler(this.chkShowCivilianOOB_Click);
    this.tvContacts.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.tvContacts.BorderStyle = BorderStyle.None;
    this.tvContacts.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.tvContacts.Location = new Point(3, 20);
    this.tvContacts.Name = "tvContacts";
    this.tvContacts.Size = new Size(309, 402);
    this.tvContacts.TabIndex = 28;
    this.tvContacts.AfterSelect += new TreeViewEventHandler(this.tvContacts_AfterSelect);
    this.lblLocation.Location = new Point(0, 428);
    this.lblLocation.Margin = new Padding(0, 3, 3, 3);
    this.lblLocation.Name = "lblLocation";
    this.lblLocation.Size = new Size(317, 12);
    this.lblLocation.TabIndex = 131;
    this.tabMinerals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.tabMinerals.Controls.Add((Control) this.flowLayoutPanelMinerals);
    this.tabMinerals.Location = new Point(4, 40);
    this.tabMinerals.Name = "tabMinerals";
    this.tabMinerals.Padding = new Padding(3);
    this.tabMinerals.Size = new Size(324, 620);
    this.tabMinerals.TabIndex = 3;
    this.tabMinerals.Text = "Minerals";
    this.flowLayoutPanelMinerals.Controls.Add((Control) this.tvMinerals);
    this.flowLayoutPanelMinerals.Dock = DockStyle.Fill;
    this.flowLayoutPanelMinerals.Location = new Point(3, 3);
    this.flowLayoutPanelMinerals.Name = "flowLayoutPanelMinerals";
    this.flowLayoutPanelMinerals.Size = new Size(318, 614);
    this.flowLayoutPanelMinerals.TabIndex = 0;
    this.tvMinerals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.tvMinerals.BorderStyle = BorderStyle.None;
    this.tvMinerals.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.tvMinerals.Location = new Point(3, 3);
    this.tvMinerals.Name = "tvMinerals";
    this.tvMinerals.Size = new Size(312, 608);
    this.tvMinerals.TabIndex = 1;
    this.tabMineralText.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.tabMineralText.Controls.Add((Control) this.txtMinerals);
    this.tabMineralText.Location = new Point(4, 40);
    this.tabMineralText.Name = "tabMineralText";
    this.tabMineralText.Padding = new Padding(3);
    this.tabMineralText.Size = new Size(324, 620);
    this.tabMineralText.TabIndex = 5;
    this.tabMineralText.Text = "Min Text";
    this.txtMinerals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtMinerals.BorderStyle = BorderStyle.None;
    this.txtMinerals.Dock = DockStyle.Top;
    this.txtMinerals.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.txtMinerals.Location = new Point(3, 3);
    this.txtMinerals.Margin = new Padding(5, 3, 3, 3);
    this.txtMinerals.Multiline = true;
    this.txtMinerals.Name = "txtMinerals";
    this.txtMinerals.ScrollBars = ScrollBars.Vertical;
    this.txtMinerals.Size = new Size(318, 611);
    this.txtMinerals.TabIndex = 0;
    this.tabJump.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.tabJump.Controls.Add((Control) this.flowLayoutPanelJump);
    this.tabJump.Location = new Point(4, 40);
    this.tabJump.Name = "tabJump";
    this.tabJump.Padding = new Padding(3);
    this.tabJump.Size = new Size(324, 620);
    this.tabJump.TabIndex = 4;
    this.tabJump.Text = "Artifacts";
    this.flowLayoutPanelJump.Controls.Add((Control) this.label2);
    this.flowLayoutPanelJump.Controls.Add((Control) this.lstRuins);
    this.flowLayoutPanelJump.Controls.Add((Control) this.label3);
    this.flowLayoutPanelJump.Controls.Add((Control) this.lstAnomalies);
    this.flowLayoutPanelJump.Controls.Add((Control) this.label4);
    this.flowLayoutPanelJump.Controls.Add((Control) this.lstWrecks);
    this.flowLayoutPanelJump.Dock = DockStyle.Top;
    this.flowLayoutPanelJump.Location = new Point(3, 3);
    this.flowLayoutPanelJump.Name = "flowLayoutPanelJump";
    this.flowLayoutPanelJump.Size = new Size(318, 611);
    this.flowLayoutPanelJump.TabIndex = 0;
    this.label2.AutoSize = true;
    this.label2.Location = new Point(3, 0);
    this.label2.Name = "label2";
    this.label2.Size = new Size(70, 13);
    this.label2.TabIndex = 1;
    this.label2.Text = "Known Ruins";
    this.lstRuins.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstRuins.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstRuins.FormattingEnabled = true;
    this.lstRuins.Location = new Point(3, 16 /*0x10*/);
    this.lstRuins.Name = "lstRuins";
    this.lstRuins.SelectionMode = SelectionMode.None;
    this.lstRuins.Size = new Size(312, 121);
    this.lstRuins.TabIndex = 0;
    this.lstRuins.Click += new EventHandler(this.lstRuins_Click);
    this.label3.AutoSize = true;
    this.label3.Location = new Point(3, 143);
    this.label3.Margin = new Padding(3, 3, 3, 0);
    this.label3.Name = "label3";
    this.label3.Size = new Size(132, 13);
    this.label3.TabIndex = 2;
    this.label3.Text = "Known Ancient Constructs";
    this.lstAnomalies.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstAnomalies.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstAnomalies.FormattingEnabled = true;
    this.lstAnomalies.Location = new Point(3, 159);
    this.lstAnomalies.Name = "lstAnomalies";
    this.lstAnomalies.SelectionMode = SelectionMode.None;
    this.lstAnomalies.Size = new Size(312, 121);
    this.lstAnomalies.TabIndex = 3;
    this.label4.AutoSize = true;
    this.label4.Location = new Point(3, 286);
    this.label4.Margin = new Padding(3, 3, 3, 0);
    this.label4.Name = "label4";
    this.label4.Size = new Size(80 /*0x50*/, 13);
    this.label4.TabIndex = 4;
    this.label4.Text = "Known Wrecks";
    this.lstWrecks.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstWrecks.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstWrecks.FormattingEnabled = true;
    this.lstWrecks.Location = new Point(3, 302);
    this.lstWrecks.Name = "lstWrecks";
    this.lstWrecks.SelectionMode = SelectionMode.None;
    this.lstWrecks.Size = new Size(312, 303);
    this.lstWrecks.TabIndex = 5;
    this.tabGroundSurvey.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.tabGroundSurvey.Controls.Add((Control) this.lstvSurveySites);
    this.tabGroundSurvey.Location = new Point(4, 40);
    this.tabGroundSurvey.Name = "tabGroundSurvey";
    this.tabGroundSurvey.Padding = new Padding(3);
    this.tabGroundSurvey.Size = new Size(324, 620);
    this.tabGroundSurvey.TabIndex = 11;
    this.tabGroundSurvey.Text = "Survey Sites";
    this.lstvSurveySites.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstvSurveySites.BorderStyle = BorderStyle.None;
    this.lstvSurveySites.Columns.AddRange(new ColumnHeader[2]
    {
      this.columnHeader_8,
      this.columnHeader_9
    });
    this.lstvSurveySites.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstvSurveySites.FullRowSelect = true;
    this.lstvSurveySites.HeaderStyle = ColumnHeaderStyle.None;
    this.lstvSurveySites.HideSelection = false;
    this.lstvSurveySites.Location = new Point(3, 3);
    this.lstvSurveySites.Name = "lstvSurveySites";
    this.lstvSurveySites.Size = new Size(318, 611);
    this.lstvSurveySites.TabIndex = 14;
    this.lstvSurveySites.UseCompatibleStateImageBehavior = false;
    this.lstvSurveySites.View = View.Details;
    this.columnHeader_8.Width = 190;
    this.columnHeader_9.Width = 80 /*0x50*/;
    this.tabBodyInfo.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.tabBodyInfo.Controls.Add((Control) this.flowLayoutPanel7);
    this.tabBodyInfo.Location = new Point(4, 40);
    this.tabBodyInfo.Name = "tabBodyInfo";
    this.tabBodyInfo.Padding = new Padding(3);
    this.tabBodyInfo.Size = new Size(324, 620);
    this.tabBodyInfo.TabIndex = 6;
    this.tabBodyInfo.Text = "Body Info";
    this.flowLayoutPanel7.Controls.Add((Control) this.lstvBodyInfo);
    this.flowLayoutPanel7.Controls.Add((Control) this.lstvMinerals);
    this.flowLayoutPanel7.Dock = DockStyle.Fill;
    this.flowLayoutPanel7.Location = new Point(3, 3);
    this.flowLayoutPanel7.Name = "flowLayoutPanel7";
    this.flowLayoutPanel7.Size = new Size(318, 614);
    this.flowLayoutPanel7.TabIndex = 0;
    this.lstvBodyInfo.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstvBodyInfo.BorderStyle = BorderStyle.None;
    this.lstvBodyInfo.Columns.AddRange(new ColumnHeader[2]
    {
      this.columnHeader_3,
      this.columnHeader_4
    });
    this.lstvBodyInfo.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstvBodyInfo.FullRowSelect = true;
    this.lstvBodyInfo.HeaderStyle = ColumnHeaderStyle.None;
    this.lstvBodyInfo.HideSelection = false;
    this.lstvBodyInfo.Location = new Point(3, 3);
    this.lstvBodyInfo.Name = "lstvBodyInfo";
    this.lstvBodyInfo.Size = new Size(312, 607);
    this.lstvBodyInfo.TabIndex = 13;
    this.lstvBodyInfo.UseCompatibleStateImageBehavior = false;
    this.lstvBodyInfo.View = View.Details;
    this.columnHeader_3.Width = 100;
    this.columnHeader_4.Width = 104;
    this.lstvMinerals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstvMinerals.BorderStyle = BorderStyle.None;
    this.lstvMinerals.Columns.AddRange(new ColumnHeader[3]
    {
      this.columnHeader_0,
      this.columnHeader_1,
      this.columnHeader_2
    });
    this.lstvMinerals.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstvMinerals.FullRowSelect = true;
    this.lstvMinerals.HeaderStyle = ColumnHeaderStyle.None;
    this.lstvMinerals.HideSelection = false;
    this.lstvMinerals.Location = new Point(3, 616);
    this.lstvMinerals.Name = "lstvMinerals";
    this.lstvMinerals.Size = new Size(312, 194);
    this.lstvMinerals.TabIndex = 12;
    this.lstvMinerals.UseCompatibleStateImageBehavior = false;
    this.lstvMinerals.View = View.Details;
    this.columnHeader_0.Width = 91;
    this.columnHeader_1.Width = 104;
    this.tabAllBodies.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.tabAllBodies.Controls.Add((Control) this.tvSystemBodies);
    this.tabAllBodies.Location = new Point(4, 40);
    this.tabAllBodies.Name = "tabAllBodies";
    this.tabAllBodies.Padding = new Padding(3);
    this.tabAllBodies.Size = new Size(324, 620);
    this.tabAllBodies.TabIndex = 7;
    this.tabAllBodies.Text = "All Bodies";
    this.tvSystemBodies.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.tvSystemBodies.BorderStyle = BorderStyle.None;
    this.tvSystemBodies.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.tvSystemBodies.Location = new Point(5, 6);
    this.tvSystemBodies.Name = "tvSystemBodies";
    this.tvSystemBodies.Size = new Size(312, 611);
    this.tvSystemBodies.TabIndex = 3;
    this.tvSystemBodies.AfterSelect += new TreeViewEventHandler(this.tvSystemBodies_AfterSelect);
    this.tabMilitary.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.tabMilitary.Controls.Add((Control) this.flowLayoutPanelMilitary);
    this.tabMilitary.Location = new Point(4, 40);
    this.tabMilitary.Name = "tabMilitary";
    this.tabMilitary.Padding = new Padding(3);
    this.tabMilitary.Size = new Size(324, 620);
    this.tabMilitary.TabIndex = 8;
    this.tabMilitary.Text = "Military";
    this.flowLayoutPanelMilitary.Controls.Add((Control) this.chkSystemOnly);
    this.flowLayoutPanelMilitary.Controls.Add((Control) this.chkShowCivilianOOB);
    this.flowLayoutPanelMilitary.Controls.Add((Control) this.tvMilitary);
    this.flowLayoutPanelMilitary.Controls.Add((Control) this.cmdCreateFleetWaypoint);
    this.flowLayoutPanelMilitary.Controls.Add((Control) this.cmdSetFleetWaypoint);
    this.flowLayoutPanelMilitary.Location = new Point(3, 6);
    this.flowLayoutPanelMilitary.Name = "flowLayoutPanelMilitary";
    this.flowLayoutPanelMilitary.Size = new Size(321, 614);
    this.flowLayoutPanelMilitary.TabIndex = 32 /*0x20*/;
    this.chkSystemOnly.AutoSize = true;
    this.chkSystemOnly.Checked = true;
    this.chkSystemOnly.CheckState = CheckState.Checked;
    this.chkSystemOnly.Location = new Point(3, 3);
    this.chkSystemOnly.Name = "chkSystemOnly";
    this.chkSystemOnly.Padding = new Padding(5, 0, 0, 0);
    this.chkSystemOnly.Size = new Size(126, 17);
    this.chkSystemOnly.TabIndex = 31 /*0x1F*/;
    this.chkSystemOnly.Text = "Current System Only";
    this.chkSystemOnly.TextAlign = ContentAlignment.MiddleRight;
    this.chkSystemOnly.UseVisualStyleBackColor = true;
    this.chkSystemOnly.Click += new EventHandler(this.chkShowCivilianOOB_Click);
    this.chkShowCivilianOOB.AutoSize = true;
    this.chkShowCivilianOOB.Location = new Point(135, 3);
    this.chkShowCivilianOOB.Name = "chkShowCivilianOOB";
    this.chkShowCivilianOOB.Padding = new Padding(5, 0, 0, 0);
    this.chkShowCivilianOOB.Size = new Size(107, 17);
    this.chkShowCivilianOOB.TabIndex = 32 /*0x20*/;
    this.chkShowCivilianOOB.Text = "Include Civilians";
    this.chkShowCivilianOOB.TextAlign = ContentAlignment.MiddleRight;
    this.chkShowCivilianOOB.UseVisualStyleBackColor = true;
    this.chkShowCivilianOOB.Click += new EventHandler(this.chkShowCivilianOOB_Click);
    this.tvMilitary.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.tvMilitary.BorderStyle = BorderStyle.None;
    this.tvMilitary.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.tvMilitary.Location = new Point(3, 26);
    this.tvMilitary.Name = "tvMilitary";
    this.tvMilitary.Size = new Size(312, 550);
    this.tvMilitary.TabIndex = 2;
    this.tvMilitary.AfterSelect += new TreeViewEventHandler(this.tvMilitary_AfterSelect);
    this.tabWaypoints.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.tabWaypoints.Controls.Add((Control) this.lstvWaypoints);
    this.tabWaypoints.Controls.Add((Control) this.flowLayoutPanel8);
    this.tabWaypoints.Location = new Point(4, 40);
    this.tabWaypoints.Name = "tabWaypoints";
    this.tabWaypoints.Padding = new Padding(3);
    this.tabWaypoints.Size = new Size(324, 620);
    this.tabWaypoints.TabIndex = 9;
    this.tabWaypoints.Text = "Waypoints";
    this.lstvWaypoints.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstvWaypoints.BorderStyle = BorderStyle.None;
    this.lstvWaypoints.Columns.AddRange(new ColumnHeader[3]
    {
      this.columnHeader_5,
      this.columnHeader_6,
      this.columnHeader_7
    });
    this.lstvWaypoints.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstvWaypoints.FullRowSelect = true;
    this.lstvWaypoints.HeaderStyle = ColumnHeaderStyle.None;
    this.lstvWaypoints.HideSelection = false;
    this.lstvWaypoints.Location = new Point(3, 5);
    this.lstvWaypoints.Name = "lstvWaypoints";
    this.lstvWaypoints.Size = new Size(318, 520);
    this.lstvWaypoints.TabIndex = 131;
    this.lstvWaypoints.UseCompatibleStateImageBehavior = false;
    this.lstvWaypoints.View = View.Details;
    this.lstvWaypoints.SelectedIndexChanged += new EventHandler(this.lstvWaypoints_SelectedIndexChanged);
    this.columnHeader_5.Width = 30;
    this.columnHeader_6.Width = 90;
    this.columnHeader_7.Width = 190;
    this.flowLayoutPanel8.Controls.Add((Control) this.cmdNormalWP);
    this.flowLayoutPanel8.Controls.Add((Control) this.cmdLastClickedWP);
    this.flowLayoutPanel8.Controls.Add((Control) this.cmdRendezvousWP);
    this.flowLayoutPanel8.Controls.Add((Control) this.cmdPOIWP);
    this.flowLayoutPanel8.Controls.Add((Control) this.cmdUrgentPOIWP);
    this.flowLayoutPanel8.Controls.Add((Control) this.cmdMoveWaypoint);
    this.flowLayoutPanel8.Controls.Add((Control) this.cmdTempWaypoint);
    this.flowLayoutPanel8.Controls.Add((Control) this.cmdDeleteWP);
    this.flowLayoutPanel8.Controls.Add((Control) this.cmdDeleteAll);
    this.flowLayoutPanel8.Location = new Point(4, 528);
    this.flowLayoutPanel8.Name = "flowLayoutPanel8";
    this.flowLayoutPanel8.Size = new Size(321, 91);
    this.flowLayoutPanel8.TabIndex = 130;
    this.cmdNormalWP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdNormalWP.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdNormalWP.Location = new Point(0, 0);
    this.cmdNormalWP.Margin = new Padding(0);
    this.cmdNormalWP.Name = "cmdNormalWP";
    this.cmdNormalWP.Size = new Size(105, 30);
    this.cmdNormalWP.TabIndex = (int) sbyte.MaxValue;
    this.cmdNormalWP.Tag = (object) "1200";
    this.cmdNormalWP.Text = "Normal Waypoint";
    this.cmdNormalWP.UseVisualStyleBackColor = false;
    this.cmdNormalWP.Click += new EventHandler(this.cmdNormalWP_Click);
    this.cmdLastClickedWP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdLastClickedWP.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdLastClickedWP.Location = new Point(105, 0);
    this.cmdLastClickedWP.Margin = new Padding(0);
    this.cmdLastClickedWP.Name = "cmdLastClickedWP";
    this.cmdLastClickedWP.Size = new Size(105, 30);
    this.cmdLastClickedWP.TabIndex = 131;
    this.cmdLastClickedWP.Tag = (object) "1200";
    this.cmdLastClickedWP.Text = "Named Waypoint";
    this.cmdLastClickedWP.UseVisualStyleBackColor = false;
    this.cmdLastClickedWP.Click += new EventHandler(this.cmdLastClickedWP_Click);
    this.cmdRendezvousWP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdRendezvousWP.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdRendezvousWP.Location = new Point(210, 0);
    this.cmdRendezvousWP.Margin = new Padding(0);
    this.cmdRendezvousWP.Name = "cmdRendezvousWP";
    this.cmdRendezvousWP.Size = new Size(105, 30);
    this.cmdRendezvousWP.TabIndex = 130;
    this.cmdRendezvousWP.Tag = (object) "1200";
    this.cmdRendezvousWP.Text = "Rendezvous";
    this.cmdRendezvousWP.UseVisualStyleBackColor = false;
    this.cmdRendezvousWP.Click += new EventHandler(this.cmdRendezvousWP_Click);
    this.cmdPOIWP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdPOIWP.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdPOIWP.Location = new Point(0, 30);
    this.cmdPOIWP.Margin = new Padding(0);
    this.cmdPOIWP.Name = "cmdPOIWP";
    this.cmdPOIWP.Size = new Size(105, 30);
    this.cmdPOIWP.TabIndex = 128 /*0x80*/;
    this.cmdPOIWP.Tag = (object) "1200";
    this.cmdPOIWP.Text = "Point of Interest";
    this.cmdPOIWP.UseVisualStyleBackColor = false;
    this.cmdPOIWP.Click += new EventHandler(this.cmdPOIWP_Click);
    this.cmdUrgentPOIWP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdUrgentPOIWP.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdUrgentPOIWP.Location = new Point(105, 30);
    this.cmdUrgentPOIWP.Margin = new Padding(0);
    this.cmdUrgentPOIWP.Name = "cmdUrgentPOIWP";
    this.cmdUrgentPOIWP.Size = new Size(105, 30);
    this.cmdUrgentPOIWP.TabIndex = 129;
    this.cmdUrgentPOIWP.Tag = (object) "1200";
    this.cmdUrgentPOIWP.Text = "Urgent POI";
    this.cmdUrgentPOIWP.UseVisualStyleBackColor = false;
    this.cmdUrgentPOIWP.Click += new EventHandler(this.cmdUrgentPOIWP_Click);
    this.cmdMoveWaypoint.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdMoveWaypoint.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdMoveWaypoint.Location = new Point(210, 30);
    this.cmdMoveWaypoint.Margin = new Padding(0);
    this.cmdMoveWaypoint.Name = "cmdMoveWaypoint";
    this.cmdMoveWaypoint.Size = new Size(105, 30);
    this.cmdMoveWaypoint.TabIndex = 133;
    this.cmdMoveWaypoint.Tag = (object) "1200";
    this.cmdMoveWaypoint.Text = "Move Waypoint";
    this.cmdMoveWaypoint.UseVisualStyleBackColor = false;
    this.cmdMoveWaypoint.Click += new EventHandler(this.cmdMoveWaypoint_Click);
    this.cmdTempWaypoint.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdTempWaypoint.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdTempWaypoint.Location = new Point(0, 60);
    this.cmdTempWaypoint.Margin = new Padding(0);
    this.cmdTempWaypoint.Name = "cmdTempWaypoint";
    this.cmdTempWaypoint.Size = new Size(105, 30);
    this.cmdTempWaypoint.TabIndex = 134;
    this.cmdTempWaypoint.Tag = (object) "1200";
    this.cmdTempWaypoint.Text = "Temp Waypoint";
    this.cmdTempWaypoint.UseVisualStyleBackColor = false;
    this.cmdTempWaypoint.Click += new EventHandler(this.cmdTempWaypoint_Click);
    this.cmdDeleteWP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdDeleteWP.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdDeleteWP.Location = new Point(105, 60);
    this.cmdDeleteWP.Margin = new Padding(0);
    this.cmdDeleteWP.Name = "cmdDeleteWP";
    this.cmdDeleteWP.Size = new Size(105, 30);
    this.cmdDeleteWP.TabIndex = 132;
    this.cmdDeleteWP.Tag = (object) "1200";
    this.cmdDeleteWP.Text = "Delete Waypoint";
    this.cmdDeleteWP.UseVisualStyleBackColor = false;
    this.cmdDeleteWP.Click += new EventHandler(this.cmdDeleteWP_Click);
    this.cmdDeleteAll.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdDeleteAll.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdDeleteAll.Location = new Point(210, 60);
    this.cmdDeleteAll.Margin = new Padding(0);
    this.cmdDeleteAll.Name = "cmdDeleteAll";
    this.cmdDeleteAll.Size = new Size(105, 30);
    this.cmdDeleteAll.TabIndex = 135;
    this.cmdDeleteAll.Tag = (object) "1200";
    this.cmdDeleteAll.Text = "Delete All";
    this.cmdDeleteAll.UseVisualStyleBackColor = false;
    this.cmdDeleteAll.Click += new EventHandler(this.cmdDeleteAll_Click);
    this.tabMisc.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.tabMisc.Controls.Add((Control) this.cmdEmpire);
    this.tabMisc.Controls.Add((Control) this.panel3);
    this.tabMisc.Controls.Add((Control) this.panel2);
    this.tabMisc.Controls.Add((Control) this.panel1);
    this.tabMisc.Controls.Add((Control) this.lblVersion);
    this.tabMisc.Location = new Point(4, 40);
    this.tabMisc.Name = "tabMisc";
    this.tabMisc.Padding = new Padding(3);
    this.tabMisc.Size = new Size(324, 620);
    this.tabMisc.TabIndex = 10;
    this.tabMisc.Text = "Miscellaneous";
    this.cmdEmpire.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdEmpire.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdEmpire.Location = new Point(6, 587);
    this.cmdEmpire.Margin = new Padding(0);
    this.cmdEmpire.Name = "cmdEmpire";
    this.cmdEmpire.Size = new Size(93, 30);
    this.cmdEmpire.TabIndex = 137;
    this.cmdEmpire.Tag = (object) "1200";
    this.cmdEmpire.Text = "Create Empire";
    this.cmdEmpire.UseVisualStyleBackColor = false;
    this.cmdEmpire.Click += new EventHandler(this.cmdEmpire_Click);
    this.panel3.BorderStyle = BorderStyle.FixedSingle;
    this.panel3.Controls.Add((Control) this.cmdCeaseFireAll);
    this.panel3.Location = new Point(5, 258);
    this.panel3.Name = "panel3";
    this.panel3.Size = new Size(315, 51);
    this.panel3.TabIndex = 136;
    this.cmdCeaseFireAll.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdCeaseFireAll.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdCeaseFireAll.Location = new Point(72, 9);
    this.cmdCeaseFireAll.Margin = new Padding(0);
    this.cmdCeaseFireAll.Name = "cmdCeaseFireAll";
    this.cmdCeaseFireAll.Size = new Size(171, 30);
    this.cmdCeaseFireAll.TabIndex = 134;
    this.cmdCeaseFireAll.Tag = (object) "1200";
    this.cmdCeaseFireAll.Text = "Cease Fire All Ships";
    this.cmdCeaseFireAll.UseVisualStyleBackColor = false;
    this.cmdCeaseFireAll.Click += new EventHandler(this.cmdCeaseFireAll_Click);
    this.panel2.BorderStyle = BorderStyle.FixedSingle;
    this.panel2.Controls.Add((Control) this.cdmDeepSpaceLocation);
    this.panel2.Location = new Point(5, 201);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(315, 51);
    this.panel2.TabIndex = 135;
    this.cdmDeepSpaceLocation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cdmDeepSpaceLocation.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cdmDeepSpaceLocation.Location = new Point(72, 9);
    this.cdmDeepSpaceLocation.Margin = new Padding(0);
    this.cdmDeepSpaceLocation.Name = "cdmDeepSpaceLocation";
    this.cdmDeepSpaceLocation.Size = new Size(171, 30);
    this.cdmDeepSpaceLocation.TabIndex = 134;
    this.cdmDeepSpaceLocation.Tag = (object) "1200";
    this.cdmDeepSpaceLocation.Text = "Create Deep Space Population";
    this.cdmDeepSpaceLocation.UseVisualStyleBackColor = false;
    this.cdmDeepSpaceLocation.Click += new EventHandler(this.cdmDeepSpaceLocation_Click);
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.button1);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.label5);
    this.panel1.Controls.Add((Control) this.cmdAddNameTheme);
    this.panel1.Controls.Add((Control) this.cmdResetWindows);
    this.panel1.Controls.Add((Control) this.cmdAddCmdrTheme);
    this.panel1.Controls.Add((Control) this.label8);
    this.panel1.Location = new Point(5, 3);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(315, 193);
    this.panel1.TabIndex = 134;
    this.button1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.button1.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.button1.Location = new Point(203, 104);
    this.button1.Margin = new Padding(0);
    this.button1.Name = "button1";
    this.button1.Size = new Size(105, 30);
    this.button1.TabIndex = 133;
    this.button1.Tag = (object) "1200";
    this.button1.Text = "Cmdr Theme FN";
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.label1.Location = new Point(3, 102);
    this.label1.Name = "label1";
    this.label1.Size = new Size(190, 44);
    this.label1.TabIndex = 134;
    this.label1.Text = "Click button, enter theme name, then select first name and surname text files with one name per line";
    this.label5.Location = new Point(3, 10);
    this.label5.Name = "label5";
    this.label5.Size = new Size(190, 30);
    this.label5.TabIndex = 129;
    this.label5.Text = "Click button, enter theme name, then select text file with one name per line";
    this.cmdAddNameTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdAddNameTheme.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdAddNameTheme.Location = new Point(202, 10);
    this.cmdAddNameTheme.Margin = new Padding(0);
    this.cmdAddNameTheme.Name = "cmdAddNameTheme";
    this.cmdAddNameTheme.Size = new Size(105, 30);
    this.cmdAddNameTheme.TabIndex = 128 /*0x80*/;
    this.cmdAddNameTheme.Tag = (object) "1200";
    this.cmdAddNameTheme.Text = "Add Name Theme";
    this.cmdAddNameTheme.UseVisualStyleBackColor = false;
    this.cmdAddNameTheme.Click += new EventHandler(this.cmdAddNameTheme_Click);
    this.cmdResetWindows.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdResetWindows.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdResetWindows.Location = new Point(203, 151);
    this.cmdResetWindows.Margin = new Padding(0);
    this.cmdResetWindows.Name = "cmdResetWindows";
    this.cmdResetWindows.Size = new Size(105, 30);
    this.cmdResetWindows.TabIndex = 132;
    this.cmdResetWindows.Tag = (object) "1200";
    this.cmdResetWindows.Text = "Reset Windows";
    this.cmdResetWindows.UseVisualStyleBackColor = false;
    this.cmdResetWindows.Click += new EventHandler(this.cmdResetWindows_Click);
    this.cmdAddCmdrTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdAddCmdrTheme.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdAddCmdrTheme.Location = new Point(202, 57);
    this.cmdAddCmdrTheme.Margin = new Padding(0);
    this.cmdAddCmdrTheme.Name = "cmdAddCmdrTheme";
    this.cmdAddCmdrTheme.Size = new Size(105, 30);
    this.cmdAddCmdrTheme.TabIndex = 130;
    this.cmdAddCmdrTheme.Tag = (object) "1200";
    this.cmdAddCmdrTheme.Text = "Cmdr Theme MF";
    this.cmdAddCmdrTheme.UseVisualStyleBackColor = false;
    this.cmdAddCmdrTheme.Click += new EventHandler(this.cmdAddCmdrTheme_Click);
    this.label8.Location = new Point(3, 51);
    this.label8.Name = "label8";
    this.label8.Size = new Size(190, 44);
    this.label8.TabIndex = 131;
    this.label8.Text = "Click button, enter theme name, then select male, female and surname text files with one name per line";
    this.lblVersion.Location = new Point(3, 600);
    this.lblVersion.Name = "lblVersion";
    this.lblVersion.Size = new Size(318, 17);
    this.lblVersion.TabIndex = 133;
    this.lblVersion.Text = "Version Number";
    this.lblVersion.TextAlign = ContentAlignment.MiddleRight;
    this.cmdCreateFleetWaypoint.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdCreateFleetWaypoint.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdCreateFleetWaypoint.Location = new Point(0, 582);
    this.cmdCreateFleetWaypoint.Margin = new Padding(0, 3, 0, 0);
    this.cmdCreateFleetWaypoint.Name = "cmdCreateFleetWaypoint";
    this.cmdCreateFleetWaypoint.Size = new Size(96 /*0x60*/, 30);
    this.cmdCreateFleetWaypoint.TabIndex = 145;
    this.cmdCreateFleetWaypoint.Tag = (object) "1200";
    this.cmdCreateFleetWaypoint.Text = "Create Fleet WP";
    this.cmdCreateFleetWaypoint.UseVisualStyleBackColor = false;
    this.cmdCreateFleetWaypoint.Click += new EventHandler(this.cmdCreateFleetWaypoint_Click);
    this.cmdSetFleetWaypoint.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSetFleetWaypoint.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSetFleetWaypoint.Location = new Point(96 /*0x60*/, 582);
    this.cmdSetFleetWaypoint.Margin = new Padding(0, 3, 0, 0);
    this.cmdSetFleetWaypoint.Name = "cmdSetFleetWaypoint";
    this.cmdSetFleetWaypoint.Size = new Size(96 /*0x60*/, 30);
    this.cmdSetFleetWaypoint.TabIndex = 146;
    this.cmdSetFleetWaypoint.Tag = (object) "1200";
    this.cmdSetFleetWaypoint.Text = "Set Fleet WP";
    this.cmdSetFleetWaypoint.UseVisualStyleBackColor = false;
    this.cmdSetFleetWaypoint.Click += new EventHandler(this.cmdSetFleetWaypoint_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.ClientSize = new Size(1424, 914);
    this.Controls.Add((Control) this.flowLayoutPanel2);
    this.Controls.Add((Control) this.tblSubPulse);
    this.Controls.Add((Control) this.tblIncrement);
    this.Controls.Add((Control) this.flowLayoutPanel3);
    this.Controls.Add((Control) this.tlbMainToolbar);
    this.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.KeyPreview = true;
    this.Name = nameof (TacticalMap);
    this.Tag = (object) "Tactical";
    this.Text = "Aurora";
    this.FormClosing += new FormClosingEventHandler(this.TacticalMap_FormClosing);
    this.Load += new EventHandler(this.TacticalMap_Load);
    this.Paint += new PaintEventHandler(this.TacticalMap_Paint);
    this.KeyDown += new KeyEventHandler(this.TacticalMap_KeyDown);
    this.MouseClick += new MouseEventHandler(this.TacticalMap_MouseClick);
    this.MouseDoubleClick += new MouseEventHandler(this.TacticalMap_MouseDoubleClick);
    this.MouseDown += new MouseEventHandler(this.TacticalMap_MouseDown);
    this.MouseMove += new MouseEventHandler(this.TacticalMap_MouseMove);
    this.MouseUp += new MouseEventHandler(this.TacticalMap_MouseUp);
    this.tlbMainToolbar.ResumeLayout(false);
    this.flowLayoutPanel3.ResumeLayout(false);
    this.tblIncrement.ResumeLayout(false);
    this.tblSubPulse.ResumeLayout(false);
    this.flowLayoutPanel2.ResumeLayout(false);
    this.tabSidebar.ResumeLayout(false);
    this.tabDisplay.ResumeLayout(false);
    this.flowLayoutPanelDisplay.ResumeLayout(false);
    this.flowLayoutPanelDisplay.PerformLayout();
    this.flowLayoutPanel9.ResumeLayout(false);
    this.flowLayoutPanel9.PerformLayout();
    this.tabContacts.ResumeLayout(false);
    this.flowLayoutPanelContacts.ResumeLayout(false);
    this.flowLayoutPanel6.ResumeLayout(false);
    this.flowLayoutPanel6.PerformLayout();
    this.flowLayoutPanel4.ResumeLayout(false);
    this.flowLayoutPanel4.PerformLayout();
    this.flowLayoutPanel5.ResumeLayout(false);
    this.flowLayoutPanel5.PerformLayout();
    this.tabMinerals.ResumeLayout(false);
    this.flowLayoutPanelMinerals.ResumeLayout(false);
    this.tabMineralText.ResumeLayout(false);
    this.tabMineralText.PerformLayout();
    this.tabJump.ResumeLayout(false);
    this.flowLayoutPanelJump.ResumeLayout(false);
    this.flowLayoutPanelJump.PerformLayout();
    this.tabGroundSurvey.ResumeLayout(false);
    this.tabBodyInfo.ResumeLayout(false);
    this.flowLayoutPanel7.ResumeLayout(false);
    this.tabAllBodies.ResumeLayout(false);
    this.tabMilitary.ResumeLayout(false);
    this.flowLayoutPanelMilitary.ResumeLayout(false);
    this.flowLayoutPanelMilitary.PerformLayout();
    this.tabWaypoints.ResumeLayout(false);
    this.flowLayoutPanel8.ResumeLayout(false);
    this.tabMisc.ResumeLayout(false);
    this.panel3.ResumeLayout(false);
    this.panel2.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
