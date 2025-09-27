// Decompiled with JetBrains decompiler
// Type: GalacticMap
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using Aurora.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
public class GalacticMap : Form
{
    private Dictionary<AuroraSystemProtectionStatus, string> dictionary_0 =
        new Dictionary<AuroraSystemProtectionStatus, string>();

    private GClass0 gclass0_0;
    public GameRace gclass21_0;
    public RacialSystemSurvey gclass202_0;
    public RacialSystemSurvey gclass202_1;
    public MapLabelData122 gclass122_0;
    public MapLabelData122 gclass122_1;
    public NamingTheme gclass140_0;
    public AlienRaceInfo gclass110_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public int int_3;
    public int int_4;
    public int int_5;
    public int int_6;
    public int int_7;
    public bool bool_0;
    public bool bool_1;
    public bool bool_2;
    private bool bool_3;
    private bool bool_4 = true;
    private bool bool_5;
    private IContainer icontainer_0;
    private ComboBox cboRaces;
    private TabControl tabSidebar;
    private TabPage tabDisplay;
    private TabPage tabOverview;
    private FlowLayoutPanel flowLayoutPanelDisplay;
    private CheckBox chkUnexJP;
    private CheckBox chkJPSurveyStatus;
    private CheckBox chkSurveyLocationPoints;
    private CheckBox chkSurveyedSystemBodies;
    private CheckBox chkLowCCNormalG;
    private CheckBox chkHabRangeWorlds;
    private CheckBox chkMediumCCNormalG;
    private CheckBox chkLowCCLowG;
    private CheckBox chkMediumCCLowG;
    private CheckBox chkDistanceFromSelected;
    private CheckBox chkWarshipLocation;
    private CheckBox chkAllFleetLocations;
    private CheckBox chkKnownAlienForces;
    private CheckBox chkAlienControlledSystems;
    private CheckBox chkPopulatedSystem;
    private CheckBox chkShipyardComplexes;
    private CheckBox chkNavalHeadquarters;
    private CheckBox chkSectors;
    private CheckBox chkPossibleDormantJP;
    private CheckBox chkSecurityStatus;
    private CheckBox chkDiscoveryDate;
    private Label label1;
    private ComboBox cboAlienRace;
    private TabPage tabNaval;
    private TreeView tvFleetList;
    private TabPage tabContacts;
    private FlowLayoutPanel flowLayoutPanel6;
    private CheckBox chkHostile;
    private CheckBox chkNeutral;
    private CheckBox chkFriendly;
    private CheckBox chkAllied;
    private CheckBox chkCivilian;
    private CheckBox chkHostileSensors;
    private CheckBox chkShowDist;
    private CheckBox chkActiveOnly;
    private Label label6;
    private TreeView tvContacts;
    private FlowLayoutPanel flowLayoutPanel4;
    private Label label7;
    private ComboBox cboContactRaceFilter;
    private CheckBox chkContactsCurrentSystem;
    private FlowLayoutPanel flowLayoutPanel1;
    private CheckBox chkSystemOnly;
    private CheckBox chkShowCivilianOOB;
    private FlowLayoutPanel flowLayoutPanel2;
    private FlowLayoutPanel flowLayoutPanel5;
    private FlowLayoutPanel flowLayoutPanel3;
    private FlowLayoutPanel flowLayoutPanel7;
    private Label label2;
    private ComboBox cboNamingTheme;
    private FlowLayoutPanel flowLayoutPanel8;
    private Label label3;
    private ComboBox cboSector;
    private FlowLayoutPanel tlbMainToolbar;
    private Button cmdToolbarColony;
    private Button cmdToolbarIndustry;
    private Button cmdToolbarResearch;
    private Button cmdToolbarWealth;
    private Button cmdToolbarGroundForces;
    private Button cmdToolbarCommanders;
    private Button cmdToolbarClass;
    private Button cmdToolbarFleet;
    private Button cmdToolbarSystem;
    private Button cmdToolbarRace;
    private Button cmdToolbarProject;
    private Button cmdToolbarMissileDesign;
    private Button cmdToolbarTurret;
    private Button cmdToolbarHabitable;
    private Button cmdToolbarTechnology;
    private Button cmdToolbarSurvey;
    private Button cmdToolbarSector;
    private Button cmdToolbarEvents;
    private Button cmdToolbarIntelligence;
    private Button cmdToolbarRefreshGalactic;
    private Button cmdToolbarSavePositions;
    private Button cmdSM;
    private Button cmdToolbarAuto;
    private FlowLayoutPanel tblIncrement;
    private Button cmdIncrement1H;
    private Button cmdIncrement3H;
    private Button cmdIncrement8H;
    private Button cmdIncrement1D;
    private Button cmdIncrement5D;
    private Button cmdIncrement30D;
    private Button cmdIncrement;
    private Button cmdIncrement2M;
    private Button cmdIncrement5M;
    private Button cmdIncrement20M;
    private ListView lstvSystemInfo;
    private ColumnHeader columnHeader_0;
    private ColumnHeader columnHeader_1;
    private ColumnHeader columnHeader_2;
    private Panel panJP;
    private Button cmdToolbarUndo;
    private Button cmdToolbarGrid;
    private TabPage tabLabels;
    private Button cmdNewLabel;
    private Button cmdDeleteLabel;
    private TextBox txtLabel;
    private Button cmdLabelFont;
    private Button cmdCopyLabel;
    private Button cmdUpdateText;
    private CheckBox chkML;
    private CheckBox chkNumCometsPlanetlessSystem;
    private Panel panel1;
    private Button cmdAwardMedal;
    private CheckBox chkGroundSurveyLocations;
    private TabPage tabPage1;
    private ListView lstvSurveySites;
    private ColumnHeader columnHeader_3;
    private ColumnHeader columnHeader_4;
    private TabPage tabPage2;
    private CheckBox chkNoAutoRoute;
    private CheckBox chkBlocked;
    private FlowLayoutPanel flowLayoutPanel10;
    private PictureBox pbShip;
    private PictureBox pbStation;
    private Button cmdHull;
    private Button cmdStation;
    private CheckBox chkRestricted;
    private CheckBox chkMilitaryRestricted;
    private CheckBox chkHideIDs;
    private CheckBox chkTracking;
    private Button cmdToolbarMedals;
    private Label label5;
    private ComboBox cboStatus;
    private CheckBox chkMineralSearchFlag;
    private CheckBox chkDisplayMineralSearch;
    private Button cmdToolbarMining;
    private CheckBox chkHabRangeWorldsLowG;
    private CheckBox chkUseMaxCCDisplay;
    private CheckBox chkMilitaryRestrictedJP;
    private CheckBox chkDistanceFromSelectedMR;
    private FlowLayoutPanel flowLayoutPanel11;
    private CheckBox chkDistanceRealSpace;
    private FlowLayoutPanel flowLayoutPanel9;
    private Button cmdSupernova;
    private CheckBox chkSupernovaImpactTime;
    private CheckBox chkAetherRift;
    private CheckBox chkNumWrecks;
    private TabPage tabMissiles;
    private ListView lstvMissiles;
    private ColumnHeader columnHeader_5;
    private ColumnHeader columnHeader_6;
    private Button cmdSystemSearch;
    private Button cmdScreenshot;
    private Button cmdScreenshotNoUI;
    private TabPage tabPage3;
    private FlowLayoutPanel flowLayoutPanel13;
    private FlowLayoutPanel flowLayoutPanel14;
    private Label label4;
    private Label label8;
    private RadioButton rdoCurrent;
    private RadioButton rdoDay;
    private RadioButton rdoWeek;
    private RadioButton rdoMonth;
    private ComboBox choFlagStatus;
    private CheckBox chkClassIcon;
    private ComboBox cboClassIcon;
    private CheckBox chkAdminIcon;
    private ComboBox cboAdminIcon;
    private FlowLayoutPanel flowLayoutPanel15;
    private FlowLayoutPanel flowLayoutPanel16;
    private CheckBox chkSystemIconOnly;
    private Label label9;
    private TextBox txtMinFontSize;

    public GalacticMap(GClass0 gclass0_1)
    {
        this.InitializeComponent();
        this.DoubleBuffered = true;
        this.gclass0_0 = gclass0_1;
        this.MouseWheel += this.GalacticMap_MouseWheel;
    }

    private void GalacticMap_MouseWheel(object sender, MouseEventArgs e)
    {
        try
        {
            int delta = e.Delta;
            if (e.Delta < 0)
                this.gclass21_0.method_70(false);
            else
                this.gclass21_0.method_70(true);
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3891);
        }
    }

    private void GalacticMap_Load(object sender, EventArgs e)
    {
        try
        {
            this.WindowState = FormWindowState.Maximized;
            this.gclass0_0.double_2 = this.Width;
            this.gclass0_0.double_3 = this.Height;
            this.gclass0_0.double_6 = this.gclass0_0.double_2 / 2.0;
            this.gclass0_0.double_7 = this.gclass0_0.double_3 / 2.0;
            this.method_6();
            this.gclass0_0.bool_9 = true;
            this.bool_3 = true;
            foreach (AuroraSystemProtectionStatus protectionStatus in Enum.GetValues(
                         typeof(AuroraSystemProtectionStatus)))
                this.dictionary_0.Add(protectionStatus, AuroraUtils.smethod_82(protectionStatus));
            this.cboStatus.DataSource = this.dictionary_0.Values.ToList<string>();
            this.gclass0_0.method_577(this.cboRaces);
            this.gclass0_0.bool_9 = false;
            this.method_7();
            this.method_2(true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1087);
        }
    }

    [DllImport("user32.dll")]
    private static extern bool PrintWindow(IntPtr intptr_0, IntPtr intptr_1, int int_8);

    [DllImport("User32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern bool MoveWindow(
        IntPtr intptr_0,
        int int_8,
        int int_9,
        int int_10,
        int int_11,
        bool bool_6);

    public void method_0()
    {
        try
        {
            this.WindowState = FormWindowState.Normal;
            double num1 = this.gclass21_0.RacialSystemDictionary.Values.Min<RacialSystemSurvey>(gclass202_0 => gclass202_0.XCoord);
            double num2 = this.gclass21_0.RacialSystemDictionary.Values.Min<RacialSystemSurvey>(gclass202_0 => gclass202_0.YCoord);
            double num3 = this.gclass21_0.RacialSystemDictionary.Values.Max<RacialSystemSurvey>(gclass202_0 => gclass202_0.XCoord);
            double num4 = this.gclass21_0.RacialSystemDictionary.Values.Max<RacialSystemSurvey>(gclass202_0 => gclass202_0.YCoord);
            double double2 = this.gclass21_0.double_2;
            double double3 = this.gclass21_0.double_3;
            this.gclass21_0.double_2 = -num1 + 100.0;
            this.gclass21_0.double_3 = -num2 + 100.0;
            int num5 = (int)(-num1 + num3) + 300;
            int num6 = (int)(-num2 + num4) + 300;
            this.MaximumSize = new Size(num5, num6);
            GalacticMap.MoveWindow(this.Handle, this.Left, this.Top, num5, num6, true);
            this.tabSidebar.Visible = false;
            this.tblIncrement.Visible = false;
            this.tlbMainToolbar.Visible = false;
            this.cboRaces.Visible = false;
            this.bool_4 = false;
            this.bool_5 = true;
            this.Refresh();
            Bitmap bitmap = new Bitmap(this.Width, this.Height, this.CreateGraphics());
            Graphics graphics = Graphics.FromImage(bitmap);
            IntPtr hdc = graphics.GetHdc();
            GalacticMap.PrintWindow(this.Handle, hdc, 0);
            graphics.ReleaseHdc(hdc);
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Files (*.png)|*.png";
                saveFileDialog.DefaultExt = "png";
                saveFileDialog.AddExtension = true;
                saveFileDialog.FileName = "image";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    bitmap.Save(fileName, ImageFormat.Png);
                }
            }

            this.WindowState = FormWindowState.Maximized;
            this.gclass21_0.double_2 = double2;
            this.gclass21_0.double_3 = double3;
            this.tabSidebar.Visible = true;
            this.tblIncrement.Visible = true;
            this.tlbMainToolbar.Visible = true;
            this.cboRaces.Visible = true;
            this.bool_4 = true;
            this.bool_5 = false;
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3799);
        }
    }

    public void method_1()
    {
        try
        {
            this.tabSidebar.Visible = false;
            this.tblIncrement.Visible = false;
            this.tlbMainToolbar.Visible = false;
            this.cboRaces.Visible = false;
            this.bool_5 = true;
            this.Refresh();
            Bitmap bitmap = new Bitmap(this.Width, this.Height, this.CreateGraphics());
            Graphics graphics = Graphics.FromImage(bitmap);
            IntPtr hdc = graphics.GetHdc();
            GalacticMap.PrintWindow(this.Handle, hdc, 0);
            graphics.ReleaseHdc(hdc);
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Files (*.png)|*.png";
                saveFileDialog.DefaultExt = "png";
                saveFileDialog.AddExtension = true;
                saveFileDialog.FileName = "image";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    bitmap.Save(fileName, ImageFormat.Png);
                }
            }

            this.tabSidebar.Visible = true;
            this.tblIncrement.Visible = true;
            this.tlbMainToolbar.Visible = true;
            this.cboRaces.Visible = true;
            this.bool_5 = false;
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3817);
        }
    }

    public void method_2(bool bool_6)
    {
        try
        {
            this.gclass21_0 = (GameRace)this.cboRaces.SelectedValue;
            this.gclass21_0.method_183(this.chkAllied.CheckState, this.chkFriendly.CheckState,
                this.chkNeutral.CheckState, this.chkHostile.CheckState, this.chkCivilian.CheckState,
                (AlienRaceInfo)this.cboContactRaceFilter.SelectedItem);
            this.gclass21_0.method_182(this.chkUseMaxCCDisplay.CheckState);
            SystemBodyData gclass1 = this.gclass21_0.method_189();
            this.gclass0_0.bool_9 = true;
            this.gclass110_0 = this.gclass21_0.method_326(this.cboAlienRace, this.gclass21_0.RaceTitle)[0];
            this.gclass21_0.method_326(this.cboContactRaceFilter, "All Races");
            this.gclass21_0.method_329(this.choFlagStatus);
            this.gclass21_0.method_327(this.cboClassIcon);
            this.gclass21_0.method_328(this.cboAdminIcon);
            this.gclass140_0 = this.gclass0_0.method_552(this.cboNamingTheme);
            this.pbShip.Image = this.gclass21_0.ShipIconLoadedImg;
            this.pbStation.Image = this.gclass21_0.SpaceStationPicLoadedImg;
            this.txtMinFontSize.Text = this.gclass21_0.MinMapFontSize.ToString();
            this.gclass21_0.method_335(this.lstvSurveySites);
            this.gclass0_0.bool_9 = false;
            if (gclass1 != null && bool_6)
                this.method_4(this.gclass21_0.RacialSystemDictionary[gclass1.SystemID]);
            if (!this.bool_3)
                this.gclass0_0.method_511(this.gclass21_0, this);
            this.bool_3 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1088);
        }
    }

    private void method_3(MapLabelData122 gclass122_2)
    {
        try
        {
            this.gclass122_0 = gclass122_2;
            this.txtLabel.Text = this.gclass122_0.Caption;
            this.txtLabel.ForeColor = this.gclass122_0.Color;
            this.txtLabel.Font = this.gclass122_0.Font;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1089);
        }
    }

    private void method_4(RacialSystemSurvey gclass202_2)
    {
        try
        {
            if (gclass202_2 == null)
                return;
            this.gclass21_0.method_168();
            if (this.gclass202_0 != null)
                this.gclass202_0.bool_7 = false;
            this.gclass202_0 = gclass202_2;
            this.gclass202_0.bool_7 = true;
            this.gclass0_0.bool_9 = true;
            this.cboAlienRace.SelectedItem = this.gclass202_0.gclass110_0 == null
                ? this.gclass110_0
                : (object)this.gclass202_0.gclass110_0;
            this.cboStatus.SelectedItem = AuroraUtils.smethod_82(gclass202_2.AutoSystemProtectionStatus);
            this.cboNamingTheme.SelectedItem = this.gclass202_0.NamingTheme == null
                ? this.gclass140_0
                : (object)this.gclass202_0.NamingTheme;
            this.chkNoAutoRoute.CheckState = !this.gclass202_0.bNoAutoRoute ? CheckState.Unchecked : CheckState.Checked;
            this.chkRestricted.CheckState = !this.gclass202_0.bMilitaryRestrictedSystem ? CheckState.Unchecked : CheckState.Checked;
            this.chkMineralSearchFlag.CheckState = !this.gclass202_0.bMineralSearchFlag ? CheckState.Unchecked : CheckState.Checked;
            GClass62 gclass62 = this.gclass21_0.method_186(this.cboSector, this.gclass202_0);
            this.cboSector.SelectedItem =
                this.gclass202_0.gclass62_0 == null ? gclass62 : (object)this.gclass202_0.gclass62_0;
            this.gclass0_0.bool_9 = false;
            this.gclass202_0.method_31(this.lstvSystemInfo);
            this.method_8();
            this.method_9();
            this.method_10();
            this.panJP.Refresh();
            if (this.chkDistanceFromSelected.CheckState == CheckState.Checked ||
                this.chkDistanceFromSelectedMR.CheckState == CheckState.Checked ||
                this.chkDistanceRealSpace.CheckState == CheckState.Checked)
                this.gclass0_0.method_37(this.gclass202_0.ActualSystemData, this.gclass21_0,
                    this.chkDistanceFromSelectedMR.CheckState, this.chkDistanceRealSpace.CheckState);
            if (this.chkContactsCurrentSystem.CheckState == CheckState.Checked)
                this.method_11();
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1090);
        }
    }

    private void GalacticMap_Paint(object sender, PaintEventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            Graphics graphics = e.Graphics;
            this.gclass21_0.method_184(graphics, this.Font, this.bool_4, this.bool_5);
            if (!this.bool_1)
                return;
            this.gclass21_0.method_172(graphics, this.int_4, this.int_5, this.int_6, this.int_7);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1091);
        }
    }

    private void panJP_Paint(object sender, PaintEventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null || this.gclass202_0 == null)
                return;
            this.gclass202_0.method_32(e.Graphics, this.Font, this.panJP.Width);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1092);
        }
    }

    public void method_5(GameRace gclass21_1)
    {
        try
        {
            this.bool_3 = true;
            this.cboRaces.SelectedItem = gclass21_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1093);
        }
    }

    private void cboRaces_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if ((int)this.cboRaces.Tag == 0)
                return;
            this.method_2(true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1094);
        }
    }

    private void chkContactsCurrentSystem_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            CheckBox checkBox = (CheckBox)sender;
            this.gclass21_0.method_320(checkBox.Name, checkBox.CheckState);
            switch (checkBox.Name)
            {
                case "chkSystemOnly":
                case "chkShowCivilianOOB":
                    this.method_9();
                    break;
                case "chkContactsCurrentSystem":
                    this.method_11();
                    break;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1095);
        }
    }

    private void chkTracking_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            CheckBox checkBox = (CheckBox)sender;
            this.gclass21_0.method_320(checkBox.Name, checkBox.CheckState);
            if ((string)checkBox.Tag == "UpdateContacts")
                this.gclass21_0.method_183(this.chkAllied.CheckState, this.chkFriendly.CheckState,
                    this.chkNeutral.CheckState, this.chkHostile.CheckState, this.chkCivilian.CheckState,
                    (AlienRaceInfo)this.cboContactRaceFilter.SelectedItem);
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1096);
        }
    }

    private void cboContactRaceFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.gclass21_0.ContactFilterRace = (AlienRaceInfo)this.cboContactRaceFilter.SelectedValue;
            this.gclass21_0.method_183(this.chkAllied.CheckState, this.chkFriendly.CheckState,
                this.chkNeutral.CheckState, this.chkHostile.CheckState, this.chkCivilian.CheckState,
                (AlienRaceInfo)this.cboContactRaceFilter.SelectedItem);
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1097);
        }
    }

    private void method_6()
    {
        if (this.gclass0_0.bool_8)
            this.cmdSupernova.Visible = true;
        else
            this.cmdSupernova.Visible = false;
    }

    private void method_7()
    {
        try
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 2000;
            toolTip.InitialDelay = 750;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.chkHabRangeWorlds,
                "System Bodies with a colony cost less than 2.00 that have gravity within the species range");
            toolTip.SetToolTip(this.chkHabRangeWorldsLowG, "System Bodies with a colony cost less than 2.00");
            toolTip.SetToolTip(this.chkLowCCNormalG,
                "System Bodies with a colony cost between 2.00 and 2.99 that have gravity within the species range");
            toolTip.SetToolTip(this.chkMediumCCNormalG,
                "System Bodies with a colony cost between 3.00 and 5.00 that have gravity within the species range");
            toolTip.SetToolTip(this.chkLowCCLowG, "All System Bodies with a colony cost between 2.00 and 2.99");
            toolTip.SetToolTip(this.chkMediumCCLowG, "All System Bodies with a colony cost between 3.00 and 5.00");
            toolTip.SetToolTip(this.chkDistanceFromSelected,
                "Show distance in billions of km between centre of selected system and centre of this system");
            toolTip.SetToolTip(this.chkDistanceFromSelectedMR,
                "Show distance in billions of km between centre of selected system and centre of this system, without using military restricted jump points");
            toolTip.SetToolTip(this.chkDistanceRealSpace,
                "Show real space distance in light years between centre of selected system and centre of others system");
            toolTip.SetToolTip(this.chkWarshipLocation, "Flag systems with at least one warship present");
            toolTip.SetToolTip(this.chkAllFleetLocations, "Flag systems with at least one non-civilian ship present");
            toolTip.SetToolTip(this.chkKnownAlienForces,
                "Highlight systems that contain contacts listed in the Contacts tab - status contact filters (hostile, neutral, etc.) and race filters will apply to map");
            toolTip.SetToolTip(this.chkAlienControlledSystems,
                "Flag systems that have been idenitified as alien-controlled");
            toolTip.SetToolTip(this.chkPopulatedSystem, "Systems with population > 0");
            toolTip.SetToolTip(this.chkPossibleDormantJP,
                "Systems where the player has flagged the potential existence of a dormant jump point");
            toolTip.SetToolTip(this.chkSecurityStatus, "Danger Rating and naval presence - affects civilian traffic");
            toolTip.SetToolTip(this.cmdToolbarUndo, "Return systems to their last save positions");
            toolTip.SetToolTip(this.cmdToolbarSavePositions, "Save current system positions");
            toolTip.SetToolTip(this.cmdToolbarGrid, "Line up systems to a hidden grid");
            toolTip.SetToolTip(this.chkML, "Highlight systems with one or more maintenance locations");
            toolTip.SetToolTip(this.cboStatus,
                "Automatically set protection status for any alien race that is detected in this system for the first time");
            toolTip.SetToolTip(this.chkAetherRift, "Highlight systems with one or more Aether Rifts");
            toolTip.SetToolTip(this.chkNumWrecks, "Display number of wrecks in each system");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1098);
        }
    }

    private void chkAdminIcon_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            CheckBox checkBox = (CheckBox)sender;
            if ((this.chkDistanceFromSelected.CheckState == CheckState.Checked ||
                 this.chkDistanceFromSelectedMR.CheckState == CheckState.Checked) &&
                checkBox.Name == "chkDistanceRealSpace")
            {
                if (this.chkDistanceRealSpace.CheckState == CheckState.Checked)
                {
                    this.gclass0_0.bool_9 = true;
                    this.chkDistanceFromSelected.CheckState = CheckState.Unchecked;
                    this.chkDistanceFromSelectedMR.CheckState = CheckState.Unchecked;
                    this.gclass21_0.chkDistanceFromSelected = CheckState.Unchecked;
                    this.gclass21_0.chkDistanceFromSelectedMR = CheckState.Unchecked;
                    this.gclass0_0.bool_9 = false;
                }
            }
            else if (this.chkDistanceRealSpace.CheckState == CheckState.Checked &&
                     (checkBox.Name == "chkDistanceFromSelected" || checkBox.Name == "chkDistanceFromSelectedMR") &&
                     (this.chkDistanceFromSelected.CheckState == CheckState.Checked ||
                      this.chkDistanceFromSelectedMR.CheckState == CheckState.Checked))
            {
                this.gclass0_0.bool_9 = true;
                this.chkDistanceRealSpace.CheckState = CheckState.Unchecked;
                this.gclass21_0.chkDistanceRealSpace = CheckState.Unchecked;
                this.gclass0_0.bool_9 = false;
            }

            this.gclass21_0.method_320(checkBox.Name, checkBox.CheckState);
            if (checkBox.Name == "chkUseMaxCCDisplay")
                this.method_2(false);
            if ((checkBox.Name == "chkDistanceFromSelected" || checkBox.Name == "chkDistanceFromSelectedMR" ||
                 checkBox.Name == "chkDistanceRealSpace") && this.gclass202_0 != null)
                this.gclass0_0.method_37(this.gclass202_0.ActualSystemData, this.gclass21_0,
                    this.chkDistanceFromSelectedMR.CheckState, this.chkDistanceRealSpace.CheckState);
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1099);
        }
    }

    public void method_8()
    {
        try
        {
            this.chkUnexJP.CheckState = this.gclass21_0.chkUnexJP;
            this.chkJPSurveyStatus.CheckState = this.gclass21_0.chkJPSurveyStatus;
            this.chkSurveyLocationPoints.CheckState = this.gclass21_0.chkSurveyLocationPoints;
            this.chkSurveyedSystemBodies.CheckState = this.gclass21_0.chkSurveyedSystemBodies;
            this.chkHabRangeWorlds.CheckState = this.gclass21_0.chkHabRangeWorlds;
            this.chkHabRangeWorldsLowG.CheckState = this.gclass21_0.chkHabRangeWorldsLowG;
            this.chkLowCCNormalG.CheckState = this.gclass21_0.chkLowCCNormalG;
            this.chkMediumCCNormalG.CheckState = this.gclass21_0.chkMediumCCNormalG;
            this.chkLowCCLowG.CheckState = this.gclass21_0.chkLowCCLowG;
            this.chkMediumCCLowG.CheckState = this.gclass21_0.chkMediumCCLowG;
            this.chkUseMaxCCDisplay.CheckState = this.gclass21_0.chkUseMaxCCDisplay;
            this.chkNumCometsPlanetlessSystem.CheckState = this.gclass21_0.chkNumCometsPlanetlessSystem;
            this.chkDistanceFromSelected.CheckState = this.gclass21_0.chkDistanceFromSelected;
            this.chkDistanceFromSelectedMR.CheckState = this.gclass21_0.chkDistanceFromSelectedMR;
            this.chkDistanceRealSpace.CheckState = this.gclass21_0.chkDistanceRealSpace;
            this.chkWarshipLocation.CheckState = this.gclass21_0.chkWarshipLocation;
            this.chkAllFleetLocations.CheckState = this.gclass21_0.chkAllFleetLocations;
            this.chkKnownAlienForces.CheckState = this.gclass21_0.chkKnownAlienForces;
            this.chkAlienControlledSystems.CheckState = this.gclass21_0.chkAlienControlledSystems;
            this.chkPopulatedSystem.CheckState = this.gclass21_0.chkPopulatedSystem;
            this.chkBlocked.CheckState = this.gclass21_0.chkBlocked;
            this.chkSupernovaImpactTime.CheckState = this.gclass21_0.chkSupernovaImpactTime;
            this.chkShipyardComplexes.CheckState = this.gclass21_0.chkShipyardComplexes;
            this.chkNavalHeadquarters.CheckState = this.gclass21_0.chkNavalHeadquarters;
            this.chkSectors.CheckState = this.gclass21_0.chkSectors;
            this.chkPossibleDormantJP.CheckState = this.gclass21_0.chkPossibleDormantJP;
            this.chkSecurityStatus.CheckState = this.gclass21_0.chkSecurityStatus;
            this.chkDiscoveryDate.CheckState = this.gclass21_0.chkDiscoveryDate;
            this.chkGroundSurveyLocations.CheckState = this.gclass21_0.chkGroundSurveyLocations;
            this.chkNumWrecks.CheckState = this.gclass21_0.chkNumWrecks;
            this.chkAetherRift.CheckState = this.gclass21_0.chkAetherRift;
            this.chkSystemIconOnly.CheckState = this.gclass21_0.chkSystemIconOnly;
            this.chkTracking.CheckState = this.gclass21_0.chkTracking;
            this.chkActiveOnly.CheckState = this.gclass21_0.chkActiveOnly;
            this.chkShowDist.CheckState = this.gclass21_0.chkShowDist;
            this.chkHideIDs.CheckState = this.gclass21_0.chkHideIDs;
            this.chkHostileSensors.CheckState = this.gclass21_0.chkHostileSensors;
            this.chkSystemOnly.CheckState = this.gclass21_0.chkSystemOnly;
            this.chkShowCivilianOOB.CheckState = this.gclass21_0.chkShowCivilianOOB;
            this.chkHostile.CheckState = this.gclass21_0.chkHostile;
            this.chkFriendly.CheckState = this.gclass21_0.chkFriendly;
            this.chkAllied.CheckState = this.gclass21_0.chkAllied;
            this.chkNeutral.CheckState = this.gclass21_0.chkNeutral;
            this.chkCivilian.CheckState = this.gclass21_0.chkCivilian;
            this.chkContactsCurrentSystem.CheckState = this.gclass21_0.chkContactsCurrentSystem;
            this.chkAdminIcon.CheckState = this.gclass21_0.chkAdminIcon;
            this.chkClassIcon.CheckState = this.gclass21_0.chkClassIcon;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1100);
        }
    }

    public void method_9()
    {
        try
        {
            bool bool_25 = false;
            if (this.chkShowCivilianOOB.CheckState == CheckState.Checked)
                bool_25 = true;
            if (this.chkSystemOnly.CheckState == CheckState.Checked)
                this.gclass21_0.method_355(this.tvFleetList, this.gclass202_0, true, bool_25, null);
            else
                this.gclass21_0.method_355(this.tvFleetList, null, false, bool_25, null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1101);
        }
    }

    public void method_10()
    {
        try
        {
            if (this.gclass21_0 == null || this.gclass202_0 == null)
                return;
            List<GClass132> list = this.gclass0_0.dictionary_6.Values
                .Where<GClass132>(gclass132_0 =>
                    gclass132_0.gclass21_0 == this.gclass21_0 &&
                    gclass132_0.gclass200_0 == this.gclass202_0.ActualSystemData)
                .OrderBy<GClass132, int>(gclass132_0 => gclass132_0.int_1).ToList<GClass132>();
            this.lstvMissiles.Items.Clear();
            this.lstvMissiles.Items.Add(new ListViewItem("Missile")
            {
                SubItems =
                {
                    "Location"
                }
            });
            foreach (GClass132 gclass132 in list)
                this.lstvMissiles.Items.Add(
                    new ListViewItem($"{gclass132.dictionary_2.Count.ToString()}x {gclass132.gclass129_0.Name}")
                    {
                        SubItems =
                        {
                            gclass132.method_1()
                        },
                        Tag = gclass132
                    });
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3780);
        }
    }

    public void method_11()
    {
        try
        {
            if (this.chkContactsCurrentSystem.CheckState == CheckState.Checked)
                this.gclass21_0.method_317(this.tvContacts, null, this.gclass202_0, false);
            else
                this.gclass21_0.method_318(this.tvContacts);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1102);
        }
    }

    private void cboAlienRace_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass202_0 == null)
                return;
            this.gclass202_0.gclass110_0 = (AlienRaceInfo)this.cboAlienRace.SelectedValue;
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1103);
        }
    }

    private void cboNamingTheme_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.gclass202_0.NamingTheme = (NamingTheme)this.cboNamingTheme.SelectedValue;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1104);
        }
    }

    private void cmdNewLabel_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            MapLabelData122 gclass122_2 = new MapLabelData122(this.gclass0_0)
            {
                Race = this.gclass21_0,
                Font = new Font("MicroSoft Sans Serif", 12f),
                Color = AuroraUtils.color_16,
                Caption = "New Label",
                double_6 = 350.0,
                double_7 = 125.0
            };
            gclass122_2.XCoord = (int)gclass122_2.double_6 - this.gclass21_0.double_2;
            gclass122_2.YCoord = (int)gclass122_2.double_7 - this.gclass21_0.double_3;
            this.gclass21_0.MapLabelList.Add(gclass122_2);
            this.method_3(gclass122_2);
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1105);
        }
    }

    private void cmdDeleteLabel_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass122_0 == null)
                return;
            this.gclass21_0.MapLabelList.Remove(this.gclass122_0);
            this.txtLabel.Text = "";
            this.gclass122_0 = null;
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1106);
        }
    }

    private void cmdUpdateText_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass122_0 == null)
                return;
            this.gclass122_0.Caption = this.txtLabel.Text;
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1107);
        }
    }

    private void cmdCopyLabel_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null || this.gclass122_0 == null)
                return;
            MapLabelData122 gclass122_2 = new MapLabelData122(this.gclass0_0)
            {
                Race = this.gclass21_0,
                Font = this.gclass122_0.Font,
                Color = this.gclass122_0.Color,
                Caption = this.gclass122_0.Caption,
                double_6 = 350.0 - this.gclass0_0.double_6 + this.gclass21_0.double_2,
                double_7 = 350.0 - this.gclass0_0.double_7 + this.gclass21_0.double_3
            };
            gclass122_2.XCoord = (int)gclass122_2.double_6 - this.gclass21_0.double_2;
            gclass122_2.YCoord = (int)gclass122_2.double_7 - this.gclass21_0.double_3;
            this.gclass21_0.MapLabelList.Add(gclass122_2);
            this.method_3(gclass122_2);
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1108);
        }
    }

    private void cmdAwardMedal_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.gclass202_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a system");
            }
            else
            {
                this.gclass0_0.gclass42_0 = null;
                int num3 = (int)new frmMedalAward(this.gclass0_0, this.gclass21_0).ShowDialog();
                if (this.gclass0_0.gclass42_0 == null)
                    return;
                if (MessageBox.Show(
                        $" Are you sure you want to award the {this.gclass0_0.gclass42_0.MedalName} to all officers with the selected command types in {this.gclass202_0.Name}?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                var localList_0 = this.gclass0_0.FCTShipDataDictionary.Values
                    .Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass85_0.System == this.gclass202_0)
                    .ToList<FCTShipData40>();
                var localList_1 = this.gclass0_0.FormationDictionary.Values
                    .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.PopulationData != null)
                    .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.PopulationData.gclass202_0 == this.gclass202_0)
                    .ToList<GroundUnitFormationData>();
                List<GClass55> list = this.gclass0_0.dictionary_42.Values.Where<GClass55>(
                    v => localList_0.Contains(v.gclass40_0)
                ).ToList<GClass55>();
                list.AddRange(gclass0_0.dictionary_42.Values
                    .Where(gclass55_0 => gclass55_0.gclass103_0 != null)
                    .Where<GClass55>(v => localList_1.Contains(v.gclass103_0)).ToList<GClass55>());
                this.gclass21_0.method_109(list.Distinct().ToList(), this.gclass0_0.gclass42_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1109);
        }
    }

    private void cmdLabelFont_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass122_0 == null)
                return;
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.Color = this.gclass122_0.Color;
            fontDialog.Font = this.gclass122_0.Font;
            if (fontDialog.ShowDialog() == DialogResult.Cancel)
                return;
            this.txtLabel.Font = fontDialog.Font;
            this.gclass122_0.Font = fontDialog.Font;
            this.txtLabel.ForeColor = fontDialog.Color;
            this.gclass122_0.Color = fontDialog.Color;
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1110);
        }
    }

    private void chkNoAutoRoute_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass21_0 == null || this.gclass202_0 == null)
                return;
            this.gclass202_0.bNoAutoRoute = ((CheckBox)sender).CheckState == CheckState.Checked;
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1111);
        }
    }

    private void chkRestricted_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass21_0 == null || this.gclass202_0 == null)
                return;
            if (((CheckBox)sender).CheckState == CheckState.Checked)
            {
                if (MessageBox.Show(
                        $" Are you sure you want to restrict the {this.gclass202_0.Name} system to military traffic? Any civilian freighters scheduled to enter this system will abandon their cargo and seek new trade runs. Colony ships will be diverted.",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    this.chkRestricted.CheckState = CheckState.Unchecked;
                    return;
                }

                this.gclass202_0.bMilitaryRestrictedSystem = true;
                this.gclass21_0.method_96(this.gclass202_0);
            }
            else
                this.gclass202_0.bMilitaryRestrictedSystem = false;

            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1112);
        }
    }

    private void method_12(object sender, EventArgs e)
    {
    }

    private void chkHideIDs_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void chkMineralSearchFlag_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass21_0 == null || this.gclass202_0 == null)
                return;
            this.gclass202_0.bMineralSearchFlag = ((CheckBox)sender).CheckState == CheckState.Checked;
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1113);
        }
    }

    private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass21_0 == null || this.gclass202_0 == null)
                return;
            this.gclass202_0.AutoSystemProtectionStatus =
                AuroraUtils.smethod_83<AuroraSystemProtectionStatus>((string)this.cboStatus.SelectedValue);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1114);
        }
    }

    private void cmdHull_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            string str = AuroraUtils.smethod_18("ShipIcons");
            if (str != "")
            {
                int num = str.LastIndexOf("\\");
                this.gclass21_0.HullPic = str.Substring(num + 1);
            }

            this.gclass21_0.ShipIconLoadedImg =
                Image.FromFile($"{Application.StartupPath}\\ShipIcons\\{this.gclass21_0.HullPic}");
            this.pbShip.Image = this.gclass21_0.ShipIconLoadedImg;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3215);
        }
    }

    private void cmdStation_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            string str = AuroraUtils.smethod_18("StationIcons");
            if (str != "")
            {
                int num = str.LastIndexOf("\\");
                this.gclass21_0.SpaceStationPic = str.Substring(num + 1);
            }

            this.gclass21_0.SpaceStationPicLoadedImg =
                Image.FromFile($"{Application.StartupPath}\\StationIcons\\{this.gclass21_0.SpaceStationPic}");
            this.pbStation.Image = this.gclass21_0.SpaceStationPicLoadedImg;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3216);
        }
    }

    private void GalacticMap_KeyDown(object sender, KeyEventArgs e)
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
            AuroraUtils.ShowExceptionPopup(ex, 3279);
        }
    }

    private void cmdSupernova_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a system");
            }
            else
            {
                if (MessageBox.Show(
                        $" Are you sure you want to trigger a supernova in {this.gclass202_0.Name}? This will cause massive radiation damage to many systems and potentially destroy shipping.",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.gclass202_0.ActualSystemData.method_1(1.0);
                this.method_2(false);
                this.Refresh();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3588);
        }
    }

    private void cmdSystemSearch_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.gclass0_0.string_3 = "Enter System Name";
            this.gclass0_0.string_4 = "";
            int num = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.string_4 == "")
                return;
            RacialSystemSurvey gclass202 =
                this.gclass21_0.RacialSystemDictionary.Values.FirstOrDefault<RacialSystemSurvey>(gclass202_2 =>
                    gclass202_2.Name == this.gclass0_0.string_4);
            if (gclass202 == null)
                return;
            this.gclass21_0.method_177((int)(this.gclass0_0.double_6 - gclass202.XCoord),
                (int)(this.gclass0_0.double_7 - gclass202.YCoord));
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3785);
        }
    }

    public void method_13(RacialSystemSurvey gclass202_2)
    {
        try
        {
            this.gclass21_0.method_177((int)(this.gclass0_0.double_6 - gclass202_2.XCoord),
                (int)(this.gclass0_0.double_7 - gclass202_2.YCoord));
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3785);
        }
    }

    private void cmdScreenshot_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_0();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3798);
        }
    }

    private void tabDisplay_Click(object sender, EventArgs e)
    {
    }

    private void choFlagStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.gclass21_0.gclass112_0 = (GClass112)this.choFlagStatus.SelectedValue;
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3802);
        }
    }

    private void rdoCurrent_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.rdoCurrent.Checked)
                this.gclass21_0.int_47 = 0;
            else if (this.rdoDay.Checked)
                this.gclass21_0.int_47 = 86400;
            else if (this.rdoWeek.Checked)
                this.gclass21_0.int_47 = 604800;
            else if (this.rdoMonth.Checked)
                this.gclass21_0.int_47 = (int)AuroraUtils.decimal_31;
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3806);
        }
    }

    private void tvContacts_AfterExpand(object sender, TreeViewEventArgs e)
    {
        try
        {
            this.tvContacts.SelectedNode = e.Node;
            if (this.tvContacts.SelectedNode == null || this.tvContacts.SelectedNode.Tag == null ||
                !(this.tvContacts.SelectedNode.Tag is AlienRaceInfo))
                return;
            ((AlienRaceInfo)this.tvContacts.SelectedNode.Tag).bool_5 = this.tvContacts.SelectedNode.IsExpanded;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3807);
        }
    }

    private void label4_Click(object sender, EventArgs e)
    {
    }

    private void label8_Click(object sender, EventArgs e)
    {
    }

    private void cboClassIcon_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.gclass21_0.SelectedClass = (GClass22)this.cboClassIcon.SelectedValue;
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3881);
        }
    }

    private void cboAdminIcon_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.gclass21_0.SelectedAdmin = (NavalAdminCommand)this.cboAdminIcon.SelectedValue;
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3882);
        }
    }

    private void txtMinFontSize_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.txtMinFontSize.Text == "")
                return;
            ParsedDouble gclass209 = AuroraUtils.ParseDoubleString(this.txtMinFontSize.Text);
            if (!gclass209.Succeed || gclass209.Value <= 0.0 || gclass209.Value == this.gclass21_0.MinMapFontSize)
                return;
            this.gclass21_0.MinMapFontSize = gclass209.Value;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3893);
        }
    }

    private void cmdScreenshotNoUI_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3818);
        }
    }

    private void cboSector_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.gclass202_0.gclass62_0 = (GClass62)this.cboSector.SelectedValue;
            this.gclass202_0.SectorID = this.gclass202_0.gclass62_0.int_0;
            if (this.gclass202_0.SectorID == 0)
                this.gclass202_0.gclass62_0 = null;
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1115);
        }
    }

    private void GalacticMap_Click(object sender, EventArgs e)
    {
    }

    private void GalacticMap_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null)
                return;
            new SystemView(this.gclass0_0, this.gclass202_0).Show();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1117);
        }
    }

    private void method_14(object sender, EventArgs e)
    {
        try
        {
            string str = AuroraUtils.smethod_18("ShipIcons");
            if (str != "")
            {
                int num = str.LastIndexOf("\\");
                this.gclass21_0.HullPic = str.Substring(num + 1);
            }

            this.gclass21_0.ShipIconLoadedImg =
                Image.FromFile($"{Application.StartupPath}\\ShipIcons\\{this.gclass21_0.HullPic}");
            this.pbShip.Image = this.gclass21_0.ShipIconLoadedImg;
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1118);
        }
    }

    private void method_15(object sender, EventArgs e)
    {
        try
        {
            string str = AuroraUtils.smethod_18("StationIcons");
            if (str != "")
            {
                int num = str.LastIndexOf("\\");
                this.gclass21_0.SpaceStationPic = str.Substring(num + 1);
            }

            this.gclass21_0.SpaceStationPicLoadedImg =
                Image.FromFile($"{Application.StartupPath}\\StationIcons\\{this.gclass21_0.SpaceStationPic}");
            this.pbStation.Image = this.gclass21_0.SpaceStationPicLoadedImg;
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1119);
        }
    }

    private void cmdIncrement30D_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass0_0.method_363((Button)sender, this.tblIncrement);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1120);
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }
    }

    private void cmdToolbarAuto_Click(object sender, EventArgs e)
    {
        try
        {
            Button button = (Button)sender;
            bool bool_24 = false;
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                bool_24 = true;
            switch (button.Name)
            {
                case "cmdToolbarSurvey":
                    Minerals minerals = Application.OpenForms.OfType<Minerals>().FirstOrDefault<Minerals>();
                    if (minerals != null && !bool_24)
                    {
                        minerals.BringToFront();
                        break;
                    }

                    new Minerals(this.gclass0_0, this.gclass0_0.tacticalMap_0).Show();
                    break;
                case "cmdSM":
                    this.gclass21_0.method_175(button.Name, bool_24, this.gclass202_0);
                    this.method_6();
                    break;
                case "cmdToolbarRefreshGalactic":
                    this.method_2(true);
                    break;
                default:
                    if (!this.gclass21_0.method_175(button.Name, bool_24, this.gclass202_0))
                        break;
                    this.Refresh();
                    break;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1121);
        }
    }

    private void GalacticMap_MouseMove(object sender, MouseEventArgs e)
    {
        try
        {
            if (!this.bool_0)
                return;
            this.int_2 = e.X - this.int_0;
            this.int_3 = e.Y - this.int_1;
            this.int_0 = e.X;
            this.int_1 = e.Y;
            if (this.gclass202_1 != null)
                this.gclass202_1.method_23(this.int_2, this.int_3);
            else if (this.gclass122_1 != null)
                this.gclass122_1.method_2(this.int_2, this.int_3);
            else if (this.bool_1)
            {
                this.int_6 = e.X;
                this.int_7 = e.Y;
            }
            else if (this.gclass21_0.method_171() > 1)
                this.gclass21_0.method_176(this.int_2, this.int_3, true);
            else
                this.gclass21_0.method_176(this.int_2, this.int_3, false);

            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1122);
        }
    }

    private void GalacticMap_MouseUp(object sender, MouseEventArgs e)
    {
        try
        {
            this.bool_0 = false;
            if (this.gclass202_1 != null)
                this.method_4(this.gclass202_1);
            if (this.gclass122_1 != null)
                this.method_3(this.gclass122_1);
            this.gclass202_1 = null;
            this.gclass122_1 = null;
            this.bool_2 = false;
            if (!this.bool_1)
                return;
            this.bool_1 = false;
            this.int_6 = 0;
            this.int_7 = 0;
            this.gclass21_0.method_173();
            this.Refresh();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1123);
        }
    }

    private void GalacticMap_MouseDown(object sender, MouseEventArgs e)
    {
        try
        {
            this.bool_1 = false;
            this.bool_2 = false;
            if (e.Button == MouseButtons.Left)
            {
                if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                {
                    RacialSystemSurvey gclass202 = this.gclass21_0.method_178(e.X, e.Y);
                    if (gclass202 != null)
                    {
                        gclass202.bool_7 = !gclass202.bool_7;
                        this.Refresh();
                    }
                }
                else if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    this.bool_1 = true;
                    this.int_4 = e.X;
                    this.int_5 = e.Y;
                    this.int_6 = e.X;
                    this.int_7 = e.Y;
                }
                else
                {
                    this.gclass202_1 = this.gclass21_0.method_178(e.X, e.Y);
                    if (this.gclass202_1 == null)
                        this.gclass122_1 = this.gclass21_0.method_179(e.X, e.Y);
                }

                this.int_0 = e.X;
                this.int_1 = e.Y;
                this.bool_0 = true;
            }
            else
            {
                if (e.Button != MouseButtons.Right)
                    return;
                var local202 = this.gclass21_0.method_178(e.X, e.Y);
                if (local202 == null)
                    return;
                ContextMenu contextMenu = new ContextMenu();
                MenuItem menuItem1 = new MenuItem("Open Tactical Map", this.method_16);

                menuItem1.Tag = local202;
                contextMenu.MenuItems.Add(menuItem1);
                var localGClass1List = this.gclass0_0.SystemBodyRecordDic.Values
                    .Where<SystemBodyData>(gc1 => gc1.SystemData == local202.ActualSystemData)
                    .ToList<SystemBodyData>();
                List<FleetData> list = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(gc85 =>
                        gc85.Race == this.gclass21_0 && gc85.System == local202 && gc85.ShippingLine == null)
                    .ToList<FleetData>();

                foreach (PopulationData gclass146 in this.gclass0_0.PopulationDataDictionary.Values.Where<PopulationData>(v =>
                             localGClass1List.Contains(v.SystemBodyData) && v.RaceData == this.gclass21_0
                         ).ToList<PopulationData>())
                {
                    MenuItem menuItem2 = new MenuItem(gclass146.PopName, this.method_16);
                    menuItem2.Tag = gclass146;
                    contextMenu.MenuItems.Add(menuItem2);
                }

                foreach (FleetData gclass85 in list)
                {
                    MenuItem menuItem3 = new MenuItem(gclass85.FleetName, this.method_16);
                    menuItem3.Tag = gclass85;
                    contextMenu.MenuItems.Add(menuItem3);
                }

                foreach (FleetData gclass85_1 in list)
                {
                    GClass69 gclass69 = new GClass69(local202, gclass85_1);
                    MenuItem menuItem4 = new MenuItem(gclass85_1.FleetName + " - Tactical", this.method_16);
                    menuItem4.Tag = gclass69;
                    contextMenu.MenuItems.Add(menuItem4);
                }

                this.ContextMenu = contextMenu;
                contextMenu.Show(this, new Point(e.X, e.Y));
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1124);
        }
    }

    public void method_16(object sender, EventArgs e)
    {
        try
        {
            MenuItem menuItem = (MenuItem)sender;
            if (menuItem.Tag is FleetData)
            {
                FleetData tag = (FleetData)menuItem.Tag;
                this.gclass21_0.genum42_0 = GEnum42.const_2;
                this.gclass21_0.int_43 = tag.FleetID;
                new FleetWindow(this.gclass0_0).Show();
            }
            else if (menuItem.Tag is GClass69)
            {
                this.gclass0_0.method_522(((GClass69)menuItem.Tag).gclass85_0);
                this.gclass0_0.tacticalMap_0.BringToFront();
            }
            else if (menuItem.Tag is PopulationData)
                new Economics(this.gclass0_0, GEnum34.const_0, (PopulationData)menuItem.Tag).Show();
            else if (menuItem.Tag is RacialSystemSurvey)
            {
                this.gclass0_0.tacticalMap_0.method_14((RacialSystemSurvey)menuItem.Tag);
                this.gclass0_0.tacticalMap_0.BringToFront();
                this.gclass0_0.object_0 = this.gclass0_0.tacticalMap_0;
            }

            menuItem.Parent.MenuItems.Clear();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1125);
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
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GalacticMap));
        this.cboRaces = new ComboBox();
        this.tabSidebar = new TabControl();
        this.tabOverview = new TabPage();
        this.flowLayoutPanel5 = new FlowLayoutPanel();
        this.flowLayoutPanel3 = new FlowLayoutPanel();
        this.label1 = new Label();
        this.cboAlienRace = new ComboBox();
        this.flowLayoutPanel7 = new FlowLayoutPanel();
        this.label2 = new Label();
        this.cboNamingTheme = new ComboBox();
        this.flowLayoutPanel8 = new FlowLayoutPanel();
        this.label3 = new Label();
        this.cboSector = new ComboBox();
        this.lstvSystemInfo = new ListView();
        this.columnHeader_0 = new ColumnHeader();
        this.columnHeader_1 = new ColumnHeader();
        this.columnHeader_2 = new ColumnHeader();
        this.panJP = new Panel();
        this.tabDisplay = new TabPage();
        this.flowLayoutPanel16 = new FlowLayoutPanel();
        this.label9 = new Label();
        this.txtMinFontSize = new TextBox();
        this.flowLayoutPanel11 = new FlowLayoutPanel();
        this.chkDistanceFromSelected = new CheckBox();
        this.chkDistanceFromSelectedMR = new CheckBox();
        this.chkDistanceRealSpace = new CheckBox();
        this.flowLayoutPanel9 = new FlowLayoutPanel();
        this.chkUnexJP = new CheckBox();
        this.chkJPSurveyStatus = new CheckBox();
        this.chkSurveyedSystemBodies = new CheckBox();
        this.chkSurveyLocationPoints = new CheckBox();
        this.chkWarshipLocation = new CheckBox();
        this.chkAllFleetLocations = new CheckBox();
        this.chkPopulatedSystem = new CheckBox();
        this.chkKnownAlienForces = new CheckBox();
        this.chkShipyardComplexes = new CheckBox();
        this.chkNavalHeadquarters = new CheckBox();
        this.chkSectors = new CheckBox();
        this.chkML = new CheckBox();
        this.chkGroundSurveyLocations = new CheckBox();
        this.chkAlienControlledSystems = new CheckBox();
        this.chkNumWrecks = new CheckBox();
        this.chkAetherRift = new CheckBox();
        this.chkMilitaryRestricted = new CheckBox();
        this.chkMilitaryRestrictedJP = new CheckBox();
        this.chkPossibleDormantJP = new CheckBox();
        this.chkSecurityStatus = new CheckBox();
        this.flowLayoutPanelDisplay = new FlowLayoutPanel();
        this.chkHabRangeWorlds = new CheckBox();
        this.chkHabRangeWorldsLowG = new CheckBox();
        this.chkLowCCNormalG = new CheckBox();
        this.chkLowCCLowG = new CheckBox();
        this.chkMediumCCNormalG = new CheckBox();
        this.chkMediumCCLowG = new CheckBox();
        this.chkUseMaxCCDisplay = new CheckBox();
        this.chkNumCometsPlanetlessSystem = new CheckBox();
        this.chkBlocked = new CheckBox();
        this.chkSupernovaImpactTime = new CheckBox();
        this.chkDisplayMineralSearch = new CheckBox();
        this.chkDiscoveryDate = new CheckBox();
        this.chkSystemIconOnly = new CheckBox();
        this.tabNaval = new TabPage();
        this.flowLayoutPanel2 = new FlowLayoutPanel();
        this.chkSystemOnly = new CheckBox();
        this.chkShowCivilianOOB = new CheckBox();
        this.tvFleetList = new TreeView();
        this.panel1 = new Panel();
        this.cmdAwardMedal = new Button();
        this.tabContacts = new TabPage();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.flowLayoutPanel6 = new FlowLayoutPanel();
        this.chkHostile = new CheckBox();
        this.chkNeutral = new CheckBox();
        this.chkFriendly = new CheckBox();
        this.chkAllied = new CheckBox();
        this.chkCivilian = new CheckBox();
        this.chkHideIDs = new CheckBox();
        this.chkHostileSensors = new CheckBox();
        this.chkShowDist = new CheckBox();
        this.chkActiveOnly = new CheckBox();
        this.chkTracking = new CheckBox();
        this.flowLayoutPanel4 = new FlowLayoutPanel();
        this.label7 = new Label();
        this.cboContactRaceFilter = new ComboBox();
        this.label6 = new Label();
        this.chkContactsCurrentSystem = new CheckBox();
        this.tvContacts = new TreeView();
        this.tabLabels = new TabPage();
        this.cmdCopyLabel = new Button();
        this.cmdUpdateText = new Button();
        this.cmdLabelFont = new Button();
        this.cmdNewLabel = new Button();
        this.cmdDeleteLabel = new Button();
        this.txtLabel = new TextBox();
        this.tabPage1 = new TabPage();
        this.lstvSurveySites = new ListView();
        this.columnHeader_3 = new ColumnHeader();
        this.columnHeader_4 = new ColumnHeader();
        this.tabMissiles = new TabPage();
        this.lstvMissiles = new ListView();
        this.columnHeader_5 = new ColumnHeader();
        this.columnHeader_6 = new ColumnHeader();
        this.tabPage2 = new TabPage();
        this.cmdScreenshotNoUI = new Button();
        this.cmdScreenshot = new Button();
        this.cmdSystemSearch = new Button();
        this.cmdSupernova = new Button();
        this.flowLayoutPanel10 = new FlowLayoutPanel();
        this.pbShip = new PictureBox();
        this.pbStation = new PictureBox();
        this.cmdHull = new Button();
        this.cmdStation = new Button();
        this.label5 = new Label();
        this.cboStatus = new ComboBox();
        this.chkNoAutoRoute = new CheckBox();
        this.chkRestricted = new CheckBox();
        this.chkMineralSearchFlag = new CheckBox();
        this.tabPage3 = new TabPage();
        this.flowLayoutPanel13 = new FlowLayoutPanel();
        this.flowLayoutPanel14 = new FlowLayoutPanel();
        this.label4 = new Label();
        this.choFlagStatus = new ComboBox();
        this.label8 = new Label();
        this.rdoMonth = new RadioButton();
        this.rdoWeek = new RadioButton();
        this.rdoDay = new RadioButton();
        this.rdoCurrent = new RadioButton();
        this.flowLayoutPanel15 = new FlowLayoutPanel();
        this.chkClassIcon = new CheckBox();
        this.cboClassIcon = new ComboBox();
        this.chkAdminIcon = new CheckBox();
        this.cboAdminIcon = new ComboBox();
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
        this.cmdToolbarHabitable = new Button();
        this.cmdToolbarIntelligence = new Button();
        this.cmdToolbarTechnology = new Button();
        this.cmdToolbarSurvey = new Button();
        this.cmdToolbarSector = new Button();
        this.cmdToolbarEvents = new Button();
        this.cmdToolbarRefreshGalactic = new Button();
        this.cmdToolbarGrid = new Button();
        this.cmdToolbarUndo = new Button();
        this.cmdToolbarSavePositions = new Button();
        this.cmdSM = new Button();
        this.cmdToolbarAuto = new Button();
        this.tblIncrement = new FlowLayoutPanel();
        this.cmdIncrement = new Button();
        this.cmdIncrement2M = new Button();
        this.cmdIncrement5M = new Button();
        this.cmdIncrement20M = new Button();
        this.cmdIncrement1H = new Button();
        this.cmdIncrement3H = new Button();
        this.cmdIncrement8H = new Button();
        this.cmdIncrement1D = new Button();
        this.cmdIncrement5D = new Button();
        this.cmdIncrement30D = new Button();
        this.tabSidebar.SuspendLayout();
        this.tabOverview.SuspendLayout();
        this.flowLayoutPanel5.SuspendLayout();
        this.flowLayoutPanel3.SuspendLayout();
        this.flowLayoutPanel7.SuspendLayout();
        this.flowLayoutPanel8.SuspendLayout();
        this.tabDisplay.SuspendLayout();
        this.flowLayoutPanel16.SuspendLayout();
        this.flowLayoutPanel11.SuspendLayout();
        this.flowLayoutPanel9.SuspendLayout();
        this.flowLayoutPanelDisplay.SuspendLayout();
        this.tabNaval.SuspendLayout();
        this.flowLayoutPanel2.SuspendLayout();
        this.panel1.SuspendLayout();
        this.tabContacts.SuspendLayout();
        this.flowLayoutPanel1.SuspendLayout();
        this.flowLayoutPanel6.SuspendLayout();
        this.flowLayoutPanel4.SuspendLayout();
        this.tabLabels.SuspendLayout();
        this.tabPage1.SuspendLayout();
        this.tabMissiles.SuspendLayout();
        this.tabPage2.SuspendLayout();
        this.flowLayoutPanel10.SuspendLayout();
        ((ISupportInitialize)this.pbShip).BeginInit();
        ((ISupportInitialize)this.pbStation).BeginInit();
        this.tabPage3.SuspendLayout();
        this.flowLayoutPanel13.SuspendLayout();
        this.flowLayoutPanel14.SuspendLayout();
        this.flowLayoutPanel15.SuspendLayout();
        this.tlbMainToolbar.SuspendLayout();
        this.tblIncrement.SuspendLayout();
        this.SuspendLayout();
        this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRaces.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboRaces.FormattingEnabled = true;
        this.cboRaces.Location = new Point(3, 51);
        this.cboRaces.Name = "cboRaces";
        this.cboRaces.Size = new Size(332, 21);
        this.cboRaces.TabIndex = 12;
        this.cboRaces.SelectedIndexChanged += this.cboRaces_SelectedIndexChanged;
        this.tabSidebar.Controls.Add(this.tabOverview);
        this.tabSidebar.Controls.Add(this.tabDisplay);
        this.tabSidebar.Controls.Add(this.tabNaval);
        this.tabSidebar.Controls.Add(this.tabContacts);
        this.tabSidebar.Controls.Add(this.tabLabels);
        this.tabSidebar.Controls.Add(this.tabPage1);
        this.tabSidebar.Controls.Add(this.tabMissiles);
        this.tabSidebar.Controls.Add(this.tabPage2);
        this.tabSidebar.Controls.Add(this.tabPage3);
        this.tabSidebar.Location = new Point(3, 78);
        this.tabSidebar.Multiline = true;
        this.tabSidebar.Name = "tabSidebar";
        this.tabSidebar.SelectedIndex = 0;
        this.tabSidebar.Size = new Size(332, 780);
        this.tabSidebar.TabIndex = 13;
        this.tabOverview.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabOverview.Controls.Add(this.flowLayoutPanel5);
        this.tabOverview.Location = new Point(4, 40);
        this.tabOverview.Name = "tabOverview";
        this.tabOverview.Padding = new Padding(3);
        this.tabOverview.Size = new Size(324, 736);
        this.tabOverview.TabIndex = 1;
        this.tabOverview.Text = "Overview";
        this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel3);
        this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel7);
        this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel8);
        this.flowLayoutPanel5.Controls.Add(this.lstvSystemInfo);
        this.flowLayoutPanel5.Controls.Add(this.panJP);
        this.flowLayoutPanel5.Dock = DockStyle.Fill;
        this.flowLayoutPanel5.Location = new Point(3, 3);
        this.flowLayoutPanel5.Name = "flowLayoutPanel5";
        this.flowLayoutPanel5.Size = new Size(318, 730);
        this.flowLayoutPanel5.TabIndex = 15;
        this.flowLayoutPanel3.Controls.Add(this.label1);
        this.flowLayoutPanel3.Controls.Add(this.cboAlienRace);
        this.flowLayoutPanel3.Location = new Point(3, 3);
        this.flowLayoutPanel3.Name = "flowLayoutPanel3";
        this.flowLayoutPanel3.Size = new Size(320, 23);
        this.flowLayoutPanel3.TabIndex = 14;
        this.label1.AutoSize = true;
        this.label1.Location = new Point(3, 3);
        this.label1.Margin = new Padding(3, 3, 3, 0);
        this.label1.Name = "label1";
        this.label1.Size = new Size(69, 13);
        this.label1.TabIndex = 14;
        this.label1.Text = "Control Race";
        this.cboAlienRace.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboAlienRace.Dock = DockStyle.Right;
        this.cboAlienRace.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboAlienRace.FormattingEnabled = true;
        this.cboAlienRace.Location = new Point(78, 0);
        this.cboAlienRace.Margin = new Padding(3, 0, 3, 3);
        this.cboAlienRace.Name = "cboAlienRace";
        this.cboAlienRace.Size = new Size(237, 21);
        this.cboAlienRace.TabIndex = 12;
        this.cboAlienRace.SelectedIndexChanged += this.cboAlienRace_SelectedIndexChanged;
        this.flowLayoutPanel7.Controls.Add(this.label2);
        this.flowLayoutPanel7.Controls.Add(this.cboNamingTheme);
        this.flowLayoutPanel7.Location = new Point(3, 32 /*0x20*/);
        this.flowLayoutPanel7.Name = "flowLayoutPanel7";
        this.flowLayoutPanel7.Size = new Size(320, 23);
        this.flowLayoutPanel7.TabIndex = 15;
        this.label2.Location = new Point(3, 3);
        this.label2.Margin = new Padding(3, 3, 3, 0);
        this.label2.Name = "label2";
        this.label2.Size = new Size(69, 13);
        this.label2.TabIndex = 14;
        this.label2.Text = "Theme";
        this.cboNamingTheme.Anchor = AnchorStyles.Right;
        this.cboNamingTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboNamingTheme.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboNamingTheme.FormattingEnabled = true;
        this.cboNamingTheme.Location = new Point(78, 0);
        this.cboNamingTheme.Margin = new Padding(3, 0, 3, 3);
        this.cboNamingTheme.Name = "cboNamingTheme";
        this.cboNamingTheme.Size = new Size(237, 21);
        this.cboNamingTheme.TabIndex = 12;
        this.cboNamingTheme.SelectedIndexChanged += this.cboNamingTheme_SelectedIndexChanged;
        this.flowLayoutPanel8.Controls.Add(this.label3);
        this.flowLayoutPanel8.Controls.Add(this.cboSector);
        this.flowLayoutPanel8.Location = new Point(3, 61);
        this.flowLayoutPanel8.Name = "flowLayoutPanel8";
        this.flowLayoutPanel8.Size = new Size(320, 23);
        this.flowLayoutPanel8.TabIndex = 16 /*0x10*/;
        this.label3.Location = new Point(3, 3);
        this.label3.Margin = new Padding(3, 3, 3, 0);
        this.label3.Name = "label3";
        this.label3.Size = new Size(69, 13);
        this.label3.TabIndex = 14;
        this.label3.Text = "Sector";
        this.cboSector.Anchor = AnchorStyles.Right;
        this.cboSector.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSector.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboSector.FormattingEnabled = true;
        this.cboSector.Location = new Point(78, 0);
        this.cboSector.Margin = new Padding(3, 0, 3, 3);
        this.cboSector.Name = "cboSector";
        this.cboSector.Size = new Size(237, 21);
        this.cboSector.TabIndex = 12;
        this.cboSector.SelectedIndexChanged += this.cboSector_SelectedIndexChanged;
        this.lstvSystemInfo.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvSystemInfo.BorderStyle = BorderStyle.None;
        this.lstvSystemInfo.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_0,
            this.columnHeader_1,
            this.columnHeader_2
        });
        this.lstvSystemInfo.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvSystemInfo.FullRowSelect = true;
        this.lstvSystemInfo.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvSystemInfo.HideSelection = false;
        this.lstvSystemInfo.Location = new Point(3, 95);
        this.lstvSystemInfo.Margin = new Padding(3, 8, 3, 3);
        this.lstvSystemInfo.Name = "lstvSystemInfo";
        this.lstvSystemInfo.Size = new Size(312, 316);
        this.lstvSystemInfo.TabIndex = 17;
        this.lstvSystemInfo.UseCompatibleStateImageBehavior = false;
        this.lstvSystemInfo.View = View.Details;
        this.columnHeader_0.Width = 200;
        this.columnHeader_1.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_1.Width = 50;
        this.columnHeader_2.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_2.Width = 50;
        this.panJP.Location = new Point(3, 417);
        this.panJP.Name = "panJP";
        this.panJP.Size = new Size(312, 312);
        this.panJP.TabIndex = 16 /*0x10*/;
        this.panJP.Paint += this.panJP_Paint;
        this.tabDisplay.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabDisplay.Controls.Add(this.flowLayoutPanel16);
        this.tabDisplay.Controls.Add(this.flowLayoutPanel11);
        this.tabDisplay.Controls.Add(this.flowLayoutPanel9);
        this.tabDisplay.Controls.Add(this.flowLayoutPanelDisplay);
        this.tabDisplay.Location = new Point(4, 40);
        this.tabDisplay.Name = "tabDisplay";
        this.tabDisplay.Padding = new Padding(3);
        this.tabDisplay.Size = new Size(324, 736);
        this.tabDisplay.TabIndex = 0;
        this.tabDisplay.Text = "Display";
        this.tabDisplay.Click += this.tabDisplay_Click;
        this.flowLayoutPanel16.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel16.Controls.Add(this.label9);
        this.flowLayoutPanel16.Controls.Add(this.txtMinFontSize);
        this.flowLayoutPanel16.Location = new Point(3, 649);
        this.flowLayoutPanel16.Name = "flowLayoutPanel16";
        this.flowLayoutPanel16.Size = new Size(315, 32 /*0x20*/);
        this.flowLayoutPanel16.TabIndex = 17;
        this.label9.AutoSize = true;
        this.label9.Location = new Point(6, 3);
        this.label9.Margin = new Padding(6, 3, 0, 3);
        this.label9.Name = "label9";
        this.label9.Padding = new Padding(0, 5, 5, 0);
        this.label9.Size = new Size(124, 18);
        this.label9.TabIndex = 65;
        this.label9.Text = "Minimum Map Font Size";
        this.txtMinFontSize.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMinFontSize.BorderStyle = BorderStyle.None;
        this.txtMinFontSize.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtMinFontSize.Location = new Point(130, 8);
        this.txtMinFontSize.Margin = new Padding(0, 8, 30, 3);
        this.txtMinFontSize.Name = "txtMinFontSize";
        this.txtMinFontSize.Size = new Size(40, 13);
        this.txtMinFontSize.TabIndex = 66;
        this.txtMinFontSize.Text = "6";
        this.txtMinFontSize.TextAlign = HorizontalAlignment.Center;
        this.txtMinFontSize.TextChanged += this.txtMinFontSize_TextChanged;
        this.flowLayoutPanel11.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel11.Controls.Add(this.chkDistanceFromSelected);
        this.flowLayoutPanel11.Controls.Add(this.chkDistanceFromSelectedMR);
        this.flowLayoutPanel11.Controls.Add(this.chkDistanceRealSpace);
        this.flowLayoutPanel11.Location = new Point(3, 243);
        this.flowLayoutPanel11.Name = "flowLayoutPanel11";
        this.flowLayoutPanel11.Size = new Size(315, 73);
        this.flowLayoutPanel11.TabIndex = 16 /*0x10*/;
        this.chkDistanceFromSelected.AutoSize = true;
        this.chkDistanceFromSelected.Location = new Point(3, 3);
        this.chkDistanceFromSelected.Name = "chkDistanceFromSelected";
        this.chkDistanceFromSelected.Padding = new Padding(5, 0, 0, 0);
        this.chkDistanceFromSelected.Size = new Size(181, 17);
        this.chkDistanceFromSelected.TabIndex = 29;
        this.chkDistanceFromSelected.Text = "Distance From Selected System";
        this.chkDistanceFromSelected.TextAlign = ContentAlignment.MiddleRight;
        this.chkDistanceFromSelected.UseVisualStyleBackColor = true;
        this.chkDistanceFromSelected.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkDistanceFromSelectedMR.AutoSize = true;
        this.chkDistanceFromSelectedMR.Location = new Point(3, 26);
        this.chkDistanceFromSelectedMR.Name = "chkDistanceFromSelectedMR";
        this.chkDistanceFromSelectedMR.Padding = new Padding(5, 0, 0, 0);
        this.chkDistanceFromSelectedMR.Size = new Size(238, 17);
        this.chkDistanceFromSelectedMR.TabIndex = 63 /*0x3F*/;
        this.chkDistanceFromSelectedMR.Text = "Distance From Selected System (Restricted)";
        this.chkDistanceFromSelectedMR.TextAlign = ContentAlignment.MiddleRight;
        this.chkDistanceFromSelectedMR.UseVisualStyleBackColor = true;
        this.chkDistanceFromSelectedMR.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkDistanceRealSpace.AutoSize = true;
        this.chkDistanceRealSpace.Location = new Point(3, 49);
        this.chkDistanceRealSpace.Name = "chkDistanceRealSpace";
        this.chkDistanceRealSpace.Padding = new Padding(5, 0, 0, 0);
        this.chkDistanceRealSpace.Size = new Size(246, 17);
        this.chkDistanceRealSpace.TabIndex = 64 /*0x40*/;
        this.chkDistanceRealSpace.Text = "Distance From Selected System (Real Space)";
        this.chkDistanceRealSpace.TextAlign = ContentAlignment.MiddleRight;
        this.chkDistanceRealSpace.UseVisualStyleBackColor = true;
        this.chkDistanceRealSpace.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.flowLayoutPanel9.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel9.Controls.Add(this.chkUnexJP);
        this.flowLayoutPanel9.Controls.Add(this.chkJPSurveyStatus);
        this.flowLayoutPanel9.Controls.Add(this.chkSurveyedSystemBodies);
        this.flowLayoutPanel9.Controls.Add(this.chkSurveyLocationPoints);
        this.flowLayoutPanel9.Controls.Add(this.chkWarshipLocation);
        this.flowLayoutPanel9.Controls.Add(this.chkAllFleetLocations);
        this.flowLayoutPanel9.Controls.Add(this.chkPopulatedSystem);
        this.flowLayoutPanel9.Controls.Add(this.chkKnownAlienForces);
        this.flowLayoutPanel9.Controls.Add(this.chkShipyardComplexes);
        this.flowLayoutPanel9.Controls.Add(this.chkNavalHeadquarters);
        this.flowLayoutPanel9.Controls.Add(this.chkSectors);
        this.flowLayoutPanel9.Controls.Add(this.chkML);
        this.flowLayoutPanel9.Controls.Add(this.chkGroundSurveyLocations);
        this.flowLayoutPanel9.Controls.Add(this.chkAlienControlledSystems);
        this.flowLayoutPanel9.Controls.Add(this.chkNumWrecks);
        this.flowLayoutPanel9.Controls.Add(this.chkAetherRift);
        this.flowLayoutPanel9.Controls.Add(this.chkMilitaryRestricted);
        this.flowLayoutPanel9.Controls.Add(this.chkMilitaryRestrictedJP);
        this.flowLayoutPanel9.Controls.Add(this.chkPossibleDormantJP);
        this.flowLayoutPanel9.Controls.Add(this.chkSecurityStatus);
        this.flowLayoutPanel9.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel9.Location = new Point(3, 3);
        this.flowLayoutPanel9.Name = "flowLayoutPanel9";
        this.flowLayoutPanel9.Size = new Size(315, 234);
        this.flowLayoutPanel9.TabIndex = 16 /*0x10*/;
        this.chkUnexJP.AutoSize = true;
        this.chkUnexJP.Location = new Point(3, 3);
        this.chkUnexJP.Name = "chkUnexJP";
        this.chkUnexJP.Padding = new Padding(5, 0, 0, 0);
        this.chkUnexJP.Size = new Size(145, 17);
        this.chkUnexJP.TabIndex = 30;
        this.chkUnexJP.Text = "Unexplored Jump Points";
        this.chkUnexJP.TextAlign = ContentAlignment.MiddleRight;
        this.chkUnexJP.UseVisualStyleBackColor = true;
        this.chkUnexJP.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkJPSurveyStatus.AutoSize = true;
        this.chkJPSurveyStatus.Location = new Point(3, 26);
        this.chkJPSurveyStatus.Name = "chkJPSurveyStatus";
        this.chkJPSurveyStatus.Padding = new Padding(5, 0, 0, 0);
        this.chkJPSurveyStatus.Size = new Size(152, 17);
        this.chkJPSurveyStatus.TabIndex = 23;
        this.chkJPSurveyStatus.Text = "Jump Point Survey Status";
        this.chkJPSurveyStatus.TextAlign = ContentAlignment.MiddleRight;
        this.chkJPSurveyStatus.UseVisualStyleBackColor = true;
        this.chkJPSurveyStatus.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkSurveyedSystemBodies.AutoSize = true;
        this.chkSurveyedSystemBodies.Location = new Point(3, 49);
        this.chkSurveyedSystemBodies.Name = "chkSurveyedSystemBodies";
        this.chkSurveyedSystemBodies.Padding = new Padding(5, 0, 0, 0);
        this.chkSurveyedSystemBodies.Size = new Size(148, 17);
        this.chkSurveyedSystemBodies.TabIndex = 1;
        this.chkSurveyedSystemBodies.Text = "Surveyed System Bodies";
        this.chkSurveyedSystemBodies.TextAlign = ContentAlignment.MiddleRight;
        this.chkSurveyedSystemBodies.UseVisualStyleBackColor = true;
        this.chkSurveyedSystemBodies.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkSurveyLocationPoints.AutoSize = true;
        this.chkSurveyLocationPoints.Location = new Point(3, 72);
        this.chkSurveyLocationPoints.Name = "chkSurveyLocationPoints";
        this.chkSurveyLocationPoints.Padding = new Padding(5, 0, 0, 0);
        this.chkSurveyLocationPoints.Size = new Size(140, 17);
        this.chkSurveyLocationPoints.TabIndex = 0;
        this.chkSurveyLocationPoints.Text = "Survey Location Points";
        this.chkSurveyLocationPoints.TextAlign = ContentAlignment.MiddleRight;
        this.chkSurveyLocationPoints.UseVisualStyleBackColor = true;
        this.chkSurveyLocationPoints.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkWarshipLocation.AutoSize = true;
        this.chkWarshipLocation.Location = new Point(3, 95);
        this.chkWarshipLocation.Name = "chkWarshipLocation";
        this.chkWarshipLocation.Padding = new Padding(5, 0, 0, 0);
        this.chkWarshipLocation.Size = new Size(119, 17);
        this.chkWarshipLocation.TabIndex = 27;
        this.chkWarshipLocation.Text = "Warship Locations";
        this.chkWarshipLocation.TextAlign = ContentAlignment.MiddleRight;
        this.chkWarshipLocation.UseVisualStyleBackColor = true;
        this.chkWarshipLocation.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkAllFleetLocations.AutoSize = true;
        this.chkAllFleetLocations.Location = new Point(3, 118);
        this.chkAllFleetLocations.Name = "chkAllFleetLocations";
        this.chkAllFleetLocations.Padding = new Padding(5, 0, 0, 0);
        this.chkAllFleetLocations.Size = new Size(117, 17);
        this.chkAllFleetLocations.TabIndex = 26;
        this.chkAllFleetLocations.Text = "All Fleet Locations";
        this.chkAllFleetLocations.TextAlign = ContentAlignment.MiddleRight;
        this.chkAllFleetLocations.UseVisualStyleBackColor = true;
        this.chkAllFleetLocations.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkPopulatedSystem.AutoSize = true;
        this.chkPopulatedSystem.Location = new Point(3, 141);
        this.chkPopulatedSystem.Name = "chkPopulatedSystem";
        this.chkPopulatedSystem.Padding = new Padding(5, 0, 0, 0);
        this.chkPopulatedSystem.Size = new Size(121, 17);
        this.chkPopulatedSystem.TabIndex = 43;
        this.chkPopulatedSystem.Text = "Populated Systems";
        this.chkPopulatedSystem.TextAlign = ContentAlignment.MiddleRight;
        this.chkPopulatedSystem.UseVisualStyleBackColor = true;
        this.chkPopulatedSystem.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkKnownAlienForces.AutoSize = true;
        this.chkKnownAlienForces.Location = new Point(3, 164);
        this.chkKnownAlienForces.Name = "chkKnownAlienForces";
        this.chkKnownAlienForces.Padding = new Padding(5, 0, 0, 0);
        this.chkKnownAlienForces.Size = new Size(154, 17);
        this.chkKnownAlienForces.TabIndex = 39;
        this.chkKnownAlienForces.Text = "Highlight Contact Systems";
        this.chkKnownAlienForces.TextAlign = ContentAlignment.MiddleRight;
        this.chkKnownAlienForces.UseVisualStyleBackColor = true;
        this.chkKnownAlienForces.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkShipyardComplexes.AutoSize = true;
        this.chkShipyardComplexes.Location = new Point(3, 187);
        this.chkShipyardComplexes.Name = "chkShipyardComplexes";
        this.chkShipyardComplexes.Padding = new Padding(5, 0, 0, 0);
        this.chkShipyardComplexes.Size = new Size(126, 17);
        this.chkShipyardComplexes.TabIndex = 42;
        this.chkShipyardComplexes.Text = "Shipyard Complexes";
        this.chkShipyardComplexes.TextAlign = ContentAlignment.MiddleRight;
        this.chkShipyardComplexes.UseVisualStyleBackColor = true;
        this.chkShipyardComplexes.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkNavalHeadquarters.AutoSize = true;
        this.chkNavalHeadquarters.Location = new Point(3, 210);
        this.chkNavalHeadquarters.Name = "chkNavalHeadquarters";
        this.chkNavalHeadquarters.Padding = new Padding(5, 0, 0, 0);
        this.chkNavalHeadquarters.Size = new Size(126, 17);
        this.chkNavalHeadquarters.TabIndex = 22;
        this.chkNavalHeadquarters.Text = "Naval Headquarters";
        this.chkNavalHeadquarters.TextAlign = ContentAlignment.MiddleRight;
        this.chkNavalHeadquarters.UseVisualStyleBackColor = true;
        this.chkNavalHeadquarters.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkSectors.AutoSize = true;
        this.chkSectors.Location = new Point(163, 3);
        this.chkSectors.Name = "chkSectors";
        this.chkSectors.Padding = new Padding(5, 0, 0, 0);
        this.chkSectors.Size = new Size(67, 17);
        this.chkSectors.TabIndex = 46;
        this.chkSectors.Text = "Sectors";
        this.chkSectors.TextAlign = ContentAlignment.MiddleRight;
        this.chkSectors.UseVisualStyleBackColor = true;
        this.chkSectors.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkML.AutoSize = true;
        this.chkML.Location = new Point(163, 26);
        this.chkML.Name = "chkML";
        this.chkML.Padding = new Padding(5, 0, 0, 0);
        this.chkML.Size = new Size(142, 17);
        this.chkML.TabIndex = 54;
        this.chkML.Text = "Maintenance Locations";
        this.chkML.TextAlign = ContentAlignment.MiddleRight;
        this.chkML.UseVisualStyleBackColor = true;
        this.chkML.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkGroundSurveyLocations.AutoSize = true;
        this.chkGroundSurveyLocations.Location = new Point(163, 49);
        this.chkGroundSurveyLocations.Name = "chkGroundSurveyLocations";
        this.chkGroundSurveyLocations.Padding = new Padding(5, 0, 0, 0);
        this.chkGroundSurveyLocations.Size = new Size(151, 17);
        this.chkGroundSurveyLocations.TabIndex = 56;
        this.chkGroundSurveyLocations.Text = "Ground Survey Locations";
        this.chkGroundSurveyLocations.TextAlign = ContentAlignment.MiddleRight;
        this.chkGroundSurveyLocations.UseVisualStyleBackColor = true;
        this.chkGroundSurveyLocations.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkAlienControlledSystems.AutoSize = true;
        this.chkAlienControlledSystems.Location = new Point(163, 72);
        this.chkAlienControlledSystems.Name = "chkAlienControlledSystems";
        this.chkAlienControlledSystems.Padding = new Padding(5, 0, 0, 0);
        this.chkAlienControlledSystems.Size = new Size(146, 17);
        this.chkAlienControlledSystems.TabIndex = 53;
        this.chkAlienControlledSystems.Text = "Alien Controlled Systems";
        this.chkAlienControlledSystems.TextAlign = ContentAlignment.MiddleRight;
        this.chkAlienControlledSystems.UseVisualStyleBackColor = true;
        this.chkAlienControlledSystems.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkNumWrecks.AutoSize = true;
        this.chkNumWrecks.Location = new Point(163, 95);
        this.chkNumWrecks.Name = "chkNumWrecks";
        this.chkNumWrecks.Padding = new Padding(5, 0, 0, 0);
        this.chkNumWrecks.Size = new Size(68, 17);
        this.chkNumWrecks.TabIndex = 64 /*0x40*/;
        this.chkNumWrecks.Text = "Wrecks";
        this.chkNumWrecks.TextAlign = ContentAlignment.MiddleRight;
        this.chkNumWrecks.UseVisualStyleBackColor = true;
        this.chkNumWrecks.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkAetherRift.AutoSize = true;
        this.chkAetherRift.Location = new Point(163, 118);
        this.chkAetherRift.Name = "chkAetherRift";
        this.chkAetherRift.Padding = new Padding(5, 0, 0, 0);
        this.chkAetherRift.Size = new Size(81, 17);
        this.chkAetherRift.TabIndex = 63 /*0x3F*/;
        this.chkAetherRift.Text = "Aether Rift";
        this.chkAetherRift.TextAlign = ContentAlignment.MiddleRight;
        this.chkAetherRift.UseVisualStyleBackColor = true;
        this.chkAetherRift.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkMilitaryRestricted.AutoSize = true;
        this.chkMilitaryRestricted.Location = new Point(163, 141);
        this.chkMilitaryRestricted.Name = "chkMilitaryRestricted";
        this.chkMilitaryRestricted.Padding = new Padding(5, 0, 0, 0);
        this.chkMilitaryRestricted.Size = new Size(134, 17);
        this.chkMilitaryRestricted.TabIndex = 58;
        this.chkMilitaryRestricted.Text = "Military Restricted Sys";
        this.chkMilitaryRestricted.TextAlign = ContentAlignment.MiddleRight;
        this.chkMilitaryRestricted.UseVisualStyleBackColor = true;
        this.chkMilitaryRestricted.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkMilitaryRestrictedJP.AutoSize = true;
        this.chkMilitaryRestrictedJP.Location = new Point(163, 164);
        this.chkMilitaryRestrictedJP.Name = "chkMilitaryRestrictedJP";
        this.chkMilitaryRestrictedJP.Padding = new Padding(5, 0, 0, 0);
        this.chkMilitaryRestrictedJP.Size = new Size(129, 17);
        this.chkMilitaryRestrictedJP.TabIndex = 62;
        this.chkMilitaryRestrictedJP.Text = "Military Restricted JP";
        this.chkMilitaryRestrictedJP.TextAlign = ContentAlignment.MiddleRight;
        this.chkMilitaryRestrictedJP.UseVisualStyleBackColor = true;
        this.chkMilitaryRestrictedJP.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkPossibleDormantJP.AutoSize = true;
        this.chkPossibleDormantJP.Location = new Point(163, 187);
        this.chkPossibleDormantJP.Name = "chkPossibleDormantJP";
        this.chkPossibleDormantJP.Padding = new Padding(5, 0, 0, 0);
        this.chkPossibleDormantJP.Size = new Size(128 /*0x80*/, 17);
        this.chkPossibleDormantJP.TabIndex = 35;
        this.chkPossibleDormantJP.Text = "Possible Dormant JP";
        this.chkPossibleDormantJP.TextAlign = ContentAlignment.MiddleRight;
        this.chkPossibleDormantJP.UseVisualStyleBackColor = true;
        this.chkPossibleDormantJP.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkSecurityStatus.AutoSize = true;
        this.chkSecurityStatus.Location = new Point(163, 210);
        this.chkSecurityStatus.Name = "chkSecurityStatus";
        this.chkSecurityStatus.Padding = new Padding(5, 0, 0, 0);
        this.chkSecurityStatus.Size = new Size(102, 17);
        this.chkSecurityStatus.TabIndex = 6;
        this.chkSecurityStatus.Text = "Security Status";
        this.chkSecurityStatus.TextAlign = ContentAlignment.MiddleRight;
        this.chkSecurityStatus.UseVisualStyleBackColor = true;
        this.chkSecurityStatus.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.flowLayoutPanelDisplay.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanelDisplay.Controls.Add(this.chkHabRangeWorlds);
        this.flowLayoutPanelDisplay.Controls.Add(this.chkHabRangeWorldsLowG);
        this.flowLayoutPanelDisplay.Controls.Add(this.chkLowCCNormalG);
        this.flowLayoutPanelDisplay.Controls.Add(this.chkLowCCLowG);
        this.flowLayoutPanelDisplay.Controls.Add(this.chkMediumCCNormalG);
        this.flowLayoutPanelDisplay.Controls.Add(this.chkMediumCCLowG);
        this.flowLayoutPanelDisplay.Controls.Add(this.chkUseMaxCCDisplay);
        this.flowLayoutPanelDisplay.Controls.Add(this.chkNumCometsPlanetlessSystem);
        this.flowLayoutPanelDisplay.Controls.Add(this.chkBlocked);
        this.flowLayoutPanelDisplay.Controls.Add(this.chkSupernovaImpactTime);
        this.flowLayoutPanelDisplay.Controls.Add(this.chkDisplayMineralSearch);
        this.flowLayoutPanelDisplay.Controls.Add(this.chkDiscoveryDate);
        this.flowLayoutPanelDisplay.Controls.Add(this.chkSystemIconOnly);
        this.flowLayoutPanelDisplay.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanelDisplay.Location = new Point(3, 322);
        this.flowLayoutPanelDisplay.Name = "flowLayoutPanelDisplay";
        this.flowLayoutPanelDisplay.Padding = new Padding(3, 6, 3, 3);
        this.flowLayoutPanelDisplay.Size = new Size(315, 321);
        this.flowLayoutPanelDisplay.TabIndex = 14;
        this.chkHabRangeWorlds.AutoSize = true;
        this.chkHabRangeWorlds.Location = new Point(6, 9);
        this.chkHabRangeWorlds.Name = "chkHabRangeWorlds";
        this.chkHabRangeWorlds.Padding = new Padding(5, 0, 0, 0);
        this.chkHabRangeWorlds.Size = new Size(249, 17);
        this.chkHabRangeWorlds.TabIndex = 5;
        this.chkHabRangeWorlds.Text = "Habitable-Range Worlds - Normal Gravity Only";
        this.chkHabRangeWorlds.TextAlign = ContentAlignment.MiddleRight;
        this.chkHabRangeWorlds.UseVisualStyleBackColor = true;
        this.chkHabRangeWorlds.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkHabRangeWorldsLowG.AutoSize = true;
        this.chkHabRangeWorldsLowG.Location = new Point(6, 32 /*0x20*/);
        this.chkHabRangeWorldsLowG.Name = "chkHabRangeWorldsLowG";
        this.chkHabRangeWorldsLowG.Padding = new Padding(5, 0, 0, 0);
        this.chkHabRangeWorldsLowG.Size = new Size(250, 17);
        this.chkHabRangeWorldsLowG.TabIndex = 60;
        this.chkHabRangeWorldsLowG.Text = "Habitable-Range Worlds - Include Low Gravity";
        this.chkHabRangeWorldsLowG.TextAlign = ContentAlignment.MiddleRight;
        this.chkHabRangeWorldsLowG.UseVisualStyleBackColor = true;
        this.chkHabRangeWorldsLowG.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkLowCCNormalG.AutoSize = true;
        this.chkLowCCNormalG.Location = new Point(6, 55);
        this.chkLowCCNormalG.Name = "chkLowCCNormalG";
        this.chkLowCCNormalG.Padding = new Padding(5, 0, 0, 0);
        this.chkLowCCNormalG.Size = new Size(248, 17);
        this.chkLowCCNormalG.TabIndex = 2;
        this.chkLowCCNormalG.Text = "Low Colony Cost Worlds - Normal Gravity Only";
        this.chkLowCCNormalG.TextAlign = ContentAlignment.MiddleRight;
        this.chkLowCCNormalG.UseVisualStyleBackColor = true;
        this.chkLowCCNormalG.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkLowCCLowG.AutoSize = true;
        this.chkLowCCLowG.Location = new Point(6, 78);
        this.chkLowCCLowG.Name = "chkLowCCLowG";
        this.chkLowCCLowG.Padding = new Padding(5, 0, 0, 0);
        this.chkLowCCLowG.Size = new Size(249, 17);
        this.chkLowCCLowG.TabIndex = 21;
        this.chkLowCCLowG.Text = "Low Colony Cost Worlds - Include Low Gravity";
        this.chkLowCCLowG.TextAlign = ContentAlignment.MiddleRight;
        this.chkLowCCLowG.UseVisualStyleBackColor = true;
        this.chkLowCCLowG.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkMediumCCNormalG.AutoSize = true;
        this.chkMediumCCNormalG.Location = new Point(6, 101);
        this.chkMediumCCNormalG.Name = "chkMediumCCNormalG";
        this.chkMediumCCNormalG.Padding = new Padding(5, 0, 0, 0);
        this.chkMediumCCNormalG.Size = new Size(265, 17);
        this.chkMediumCCNormalG.TabIndex = 19;
        this.chkMediumCCNormalG.Text = "Medium Colony Cost Worlds - Normal Gravity Only";
        this.chkMediumCCNormalG.TextAlign = ContentAlignment.MiddleRight;
        this.chkMediumCCNormalG.UseVisualStyleBackColor = true;
        this.chkMediumCCNormalG.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkMediumCCLowG.AutoSize = true;
        this.chkMediumCCLowG.Location = new Point(6, 124);
        this.chkMediumCCLowG.Name = "chkMediumCCLowG";
        this.chkMediumCCLowG.Padding = new Padding(5, 0, 0, 0);
        this.chkMediumCCLowG.Size = new Size(266, 17);
        this.chkMediumCCLowG.TabIndex = 37;
        this.chkMediumCCLowG.Text = "Medium Colony Cost Worlds - Include Low Gravity";
        this.chkMediumCCLowG.TextAlign = ContentAlignment.MiddleRight;
        this.chkMediumCCLowG.UseVisualStyleBackColor = true;
        this.chkMediumCCLowG.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkUseMaxCCDisplay.AutoSize = true;
        this.chkUseMaxCCDisplay.Location = new Point(6, 147);
        this.chkUseMaxCCDisplay.Name = "chkUseMaxCCDisplay";
        this.chkUseMaxCCDisplay.Padding = new Padding(5, 0, 0, 0);
        this.chkUseMaxCCDisplay.Size = new Size(243, 17);
        this.chkUseMaxCCDisplay.TabIndex = 61;
        this.chkUseMaxCCDisplay.Text = "Use Max Colony Cost for Hab Worlds Display";
        this.chkUseMaxCCDisplay.TextAlign = ContentAlignment.MiddleRight;
        this.chkUseMaxCCDisplay.UseVisualStyleBackColor = true;
        this.chkUseMaxCCDisplay.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkNumCometsPlanetlessSystem.AutoSize = true;
        this.chkNumCometsPlanetlessSystem.Location = new Point(6, 170);
        this.chkNumCometsPlanetlessSystem.Name = "chkNumCometsPlanetlessSystem";
        this.chkNumCometsPlanetlessSystem.Padding = new Padding(5, 0, 0, 0);
        this.chkNumCometsPlanetlessSystem.Size = new Size(217, 17);
        this.chkNumCometsPlanetlessSystem.TabIndex = 55;
        this.chkNumCometsPlanetlessSystem.Text = "Number of Comets in Planetless System";
        this.chkNumCometsPlanetlessSystem.TextAlign = ContentAlignment.MiddleRight;
        this.chkNumCometsPlanetlessSystem.UseVisualStyleBackColor = true;
        this.chkNumCometsPlanetlessSystem.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkBlocked.AutoSize = true;
        this.chkBlocked.Location = new Point(6, 193);
        this.chkBlocked.Name = "chkBlocked";
        this.chkBlocked.Padding = new Padding(5, 0, 0, 0);
        this.chkBlocked.Size = new Size(169, 17);
        this.chkBlocked.TabIndex = 57;
        this.chkBlocked.Text = "Blocked Auto-Route Systems";
        this.chkBlocked.TextAlign = ContentAlignment.MiddleRight;
        this.chkBlocked.UseVisualStyleBackColor = true;
        this.chkBlocked.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkSupernovaImpactTime.AutoSize = true;
        this.chkSupernovaImpactTime.Location = new Point(6, 216);
        this.chkSupernovaImpactTime.Name = "chkSupernovaImpactTime";
        this.chkSupernovaImpactTime.Padding = new Padding(5, 0, 0, 0);
        this.chkSupernovaImpactTime.Size = new Size(168, 17);
        this.chkSupernovaImpactTime.TabIndex = 62;
        this.chkSupernovaImpactTime.Text = "Time Until Supernova Impact";
        this.chkSupernovaImpactTime.TextAlign = ContentAlignment.MiddleRight;
        this.chkSupernovaImpactTime.UseVisualStyleBackColor = true;
        this.chkSupernovaImpactTime.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkDisplayMineralSearch.AutoSize = true;
        this.chkDisplayMineralSearch.Location = new Point(6, 239);
        this.chkDisplayMineralSearch.Name = "chkDisplayMineralSearch";
        this.chkDisplayMineralSearch.Padding = new Padding(5, 0, 0, 0);
        this.chkDisplayMineralSearch.Size = new Size(143, 17);
        this.chkDisplayMineralSearch.TabIndex = 59;
        this.chkDisplayMineralSearch.Text = "Mineral Search Flagged";
        this.chkDisplayMineralSearch.TextAlign = ContentAlignment.MiddleRight;
        this.chkDisplayMineralSearch.UseVisualStyleBackColor = true;
        this.chkDisplayMineralSearch.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkDiscoveryDate.AutoSize = true;
        this.chkDiscoveryDate.Location = new Point(6, 262);
        this.chkDiscoveryDate.Name = "chkDiscoveryDate";
        this.chkDiscoveryDate.Padding = new Padding(5, 0, 0, 0);
        this.chkDiscoveryDate.Size = new Size(104, 17);
        this.chkDiscoveryDate.TabIndex = 7;
        this.chkDiscoveryDate.Text = "Discovery Date";
        this.chkDiscoveryDate.TextAlign = ContentAlignment.MiddleRight;
        this.chkDiscoveryDate.UseVisualStyleBackColor = true;
        this.chkDiscoveryDate.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.chkSystemIconOnly.AutoSize = true;
        this.chkSystemIconOnly.Location = new Point(6, 285);
        this.chkSystemIconOnly.Name = "chkSystemIconOnly";
        this.chkSystemIconOnly.Padding = new Padding(5, 0, 0, 0);
        this.chkSystemIconOnly.Size = new Size(113, 17);
        this.chkSystemIconOnly.TabIndex = 64 /*0x40*/;
        this.chkSystemIconOnly.Text = "System Icon Only";
        this.chkSystemIconOnly.TextAlign = ContentAlignment.MiddleRight;
        this.chkSystemIconOnly.UseVisualStyleBackColor = true;
        this.chkSystemIconOnly.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.tabNaval.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabNaval.Controls.Add(this.flowLayoutPanel2);
        this.tabNaval.Location = new Point(4, 40);
        this.tabNaval.Name = "tabNaval";
        this.tabNaval.Size = new Size(324, 736);
        this.tabNaval.TabIndex = 2;
        this.tabNaval.Text = "Naval Forces";
        this.flowLayoutPanel2.Controls.Add(this.chkSystemOnly);
        this.flowLayoutPanel2.Controls.Add(this.chkShowCivilianOOB);
        this.flowLayoutPanel2.Controls.Add(this.tvFleetList);
        this.flowLayoutPanel2.Controls.Add(this.panel1);
        this.flowLayoutPanel2.Dock = DockStyle.Fill;
        this.flowLayoutPanel2.Location = new Point(0, 0);
        this.flowLayoutPanel2.Name = "flowLayoutPanel2";
        this.flowLayoutPanel2.Size = new Size(324, 736);
        this.flowLayoutPanel2.TabIndex = 0;
        this.chkSystemOnly.AutoSize = true;
        this.chkSystemOnly.Checked = true;
        this.chkSystemOnly.CheckState = CheckState.Checked;
        this.chkSystemOnly.Location = new Point(3, 3);
        this.chkSystemOnly.Name = "chkSystemOnly";
        this.chkSystemOnly.Padding = new Padding(5, 0, 0, 0);
        this.chkSystemOnly.Size = new Size(126, 17);
        this.chkSystemOnly.TabIndex = 43;
        this.chkSystemOnly.Text = "Current System Only";
        this.chkSystemOnly.TextAlign = ContentAlignment.MiddleRight;
        this.chkSystemOnly.UseVisualStyleBackColor = true;
        this.chkSystemOnly.Click += this.chkContactsCurrentSystem_Click;
        this.chkShowCivilianOOB.AutoSize = true;
        this.chkShowCivilianOOB.Location = new Point(135, 3);
        this.chkShowCivilianOOB.Name = "chkShowCivilianOOB";
        this.chkShowCivilianOOB.Padding = new Padding(5, 0, 0, 0);
        this.chkShowCivilianOOB.Size = new Size(107, 17);
        this.chkShowCivilianOOB.TabIndex = 44;
        this.chkShowCivilianOOB.Text = "Include Civilians";
        this.chkShowCivilianOOB.TextAlign = ContentAlignment.MiddleRight;
        this.chkShowCivilianOOB.UseVisualStyleBackColor = true;
        this.chkShowCivilianOOB.Click += this.chkContactsCurrentSystem_Click;
        this.tvFleetList.AllowDrop = true;
        this.tvFleetList.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvFleetList.BorderStyle = BorderStyle.None;
        this.tvFleetList.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.tvFleetList.HideSelection = false;
        this.tvFleetList.Location = new Point(3, 23);
        this.tvFleetList.Margin = new Padding(3, 0, 0, 3);
        this.tvFleetList.Name = "tvFleetList";
        this.tvFleetList.Size = new Size(318, 674);
        this.tvFleetList.TabIndex = 42;
        this.panel1.Controls.Add(this.cmdAwardMedal);
        this.panel1.Location = new Point(3, 702);
        this.panel1.Margin = new Padding(3, 2, 3, 3);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(318, 29);
        this.panel1.TabIndex = 141;
        this.cmdAwardMedal.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAwardMedal.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdAwardMedal.Location = new Point(111, 0);
        this.cmdAwardMedal.Margin = new Padding(0);
        this.cmdAwardMedal.Name = "cmdAwardMedal";
        this.cmdAwardMedal.Size = new Size(96 /*0x60*/, 30);
        this.cmdAwardMedal.TabIndex = 140;
        this.cmdAwardMedal.Tag = "1200";
        this.cmdAwardMedal.Text = "Award Medal";
        this.cmdAwardMedal.UseVisualStyleBackColor = false;
        this.cmdAwardMedal.Click += this.cmdAwardMedal_Click;
        this.tabContacts.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabContacts.Controls.Add(this.flowLayoutPanel1);
        this.tabContacts.Location = new Point(4, 40);
        this.tabContacts.Name = "tabContacts";
        this.tabContacts.Size = new Size(324, 736);
        this.tabContacts.TabIndex = 3;
        this.tabContacts.Text = "Contacts";
        this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel6);
        this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
        this.flowLayoutPanel1.Controls.Add(this.label6);
        this.flowLayoutPanel1.Controls.Add(this.chkContactsCurrentSystem);
        this.flowLayoutPanel1.Controls.Add(this.tvContacts);
        this.flowLayoutPanel1.Dock = DockStyle.Fill;
        this.flowLayoutPanel1.Location = new Point(0, 0);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(324, 736);
        this.flowLayoutPanel1.TabIndex = 0;
        this.flowLayoutPanel6.Controls.Add(this.chkHostile);
        this.flowLayoutPanel6.Controls.Add(this.chkNeutral);
        this.flowLayoutPanel6.Controls.Add(this.chkFriendly);
        this.flowLayoutPanel6.Controls.Add(this.chkAllied);
        this.flowLayoutPanel6.Controls.Add(this.chkCivilian);
        this.flowLayoutPanel6.Controls.Add(this.chkHideIDs);
        this.flowLayoutPanel6.Controls.Add(this.chkHostileSensors);
        this.flowLayoutPanel6.Controls.Add(this.chkShowDist);
        this.flowLayoutPanel6.Controls.Add(this.chkActiveOnly);
        this.flowLayoutPanel6.Controls.Add(this.chkTracking);
        this.flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel6.Location = new Point(3, 3);
        this.flowLayoutPanel6.Name = "flowLayoutPanel6";
        this.flowLayoutPanel6.Size = new Size(318, 119);
        this.flowLayoutPanel6.TabIndex = 30;
        this.chkHostile.AutoSize = true;
        this.chkHostile.Location = new Point(3, 3);
        this.chkHostile.Name = "chkHostile";
        this.chkHostile.Size = new Size(58, 17);
        this.chkHostile.TabIndex = 12;
        this.chkHostile.Tag = "UpdateContacts";
        this.chkHostile.Text = "Hostile";
        this.chkHostile.UseVisualStyleBackColor = true;
        this.chkHostile.CheckedChanged += this.chkTracking_Click;
        this.chkNeutral.AutoSize = true;
        this.chkNeutral.Location = new Point(3, 26);
        this.chkNeutral.Name = "chkNeutral";
        this.chkNeutral.Size = new Size(60, 17);
        this.chkNeutral.TabIndex = 31 /*0x1F*/;
        this.chkNeutral.Tag = "UpdateContacts";
        this.chkNeutral.Text = "Neutral";
        this.chkNeutral.UseVisualStyleBackColor = true;
        this.chkNeutral.CheckedChanged += this.chkTracking_Click;
        this.chkFriendly.AutoSize = true;
        this.chkFriendly.Location = new Point(3, 49);
        this.chkFriendly.Name = "chkFriendly";
        this.chkFriendly.Size = new Size(62, 17);
        this.chkFriendly.TabIndex = 31 /*0x1F*/;
        this.chkFriendly.Tag = "UpdateContacts";
        this.chkFriendly.Text = "Friendly";
        this.chkFriendly.UseVisualStyleBackColor = true;
        this.chkFriendly.CheckedChanged += this.chkTracking_Click;
        this.chkAllied.AutoSize = true;
        this.chkAllied.Location = new Point(3, 72);
        this.chkAllied.Name = "chkAllied";
        this.chkAllied.Size = new Size(51, 17);
        this.chkAllied.TabIndex = 30;
        this.chkAllied.Tag = "UpdateContacts";
        this.chkAllied.Text = "Allied";
        this.chkAllied.UseVisualStyleBackColor = true;
        this.chkAllied.CheckedChanged += this.chkTracking_Click;
        this.chkCivilian.AutoSize = true;
        this.chkCivilian.Location = new Point(3, 95);
        this.chkCivilian.Name = "chkCivilian";
        this.chkCivilian.Size = new Size(64 /*0x40*/, 17);
        this.chkCivilian.TabIndex = 29;
        this.chkCivilian.Tag = "UpdateContacts";
        this.chkCivilian.Text = "Civilians";
        this.chkCivilian.UseVisualStyleBackColor = true;
        this.chkCivilian.CheckedChanged += this.chkTracking_Click;
        this.chkHideIDs.AutoSize = true;
        this.chkHideIDs.Location = new Point(73, 3);
        this.chkHideIDs.Name = "chkHideIDs";
        this.chkHideIDs.Size = new Size(100, 17);
        this.chkHideIDs.TabIndex = 14;
        this.chkHideIDs.Text = "Group Contacts";
        this.chkHideIDs.UseVisualStyleBackColor = true;
        this.chkHideIDs.CheckedChanged += this.chkHideIDs_CheckedChanged;
        this.chkHideIDs.Click += this.chkTracking_Click;
        this.chkHostileSensors.AutoSize = true;
        this.chkHostileSensors.Location = new Point(73, 26);
        this.chkHostileSensors.Name = "chkHostileSensors";
        this.chkHostileSensors.Size = new Size(94, 17);
        this.chkHostileSensors.TabIndex = 17;
        this.chkHostileSensors.Text = "Sensor Range";
        this.chkHostileSensors.UseVisualStyleBackColor = true;
        this.chkHostileSensors.Click += this.chkTracking_Click;
        this.chkShowDist.AutoSize = true;
        this.chkShowDist.Location = new Point(73, 49);
        this.chkShowDist.Name = "chkShowDist";
        this.chkShowDist.Size = new Size(73, 17);
        this.chkShowDist.TabIndex = 16 /*0x10*/;
        this.chkShowDist.Text = "Distances";
        this.chkShowDist.UseVisualStyleBackColor = true;
        this.chkShowDist.Click += this.chkTracking_Click;
        this.chkActiveOnly.AutoSize = true;
        this.chkActiveOnly.Location = new Point(73, 72);
        this.chkActiveOnly.Name = "chkActiveOnly";
        this.chkActiveOnly.Size = new Size(80 /*0x50*/, 17);
        this.chkActiveOnly.TabIndex = 18;
        this.chkActiveOnly.Text = "Active Only";
        this.chkActiveOnly.UseVisualStyleBackColor = true;
        this.chkActiveOnly.Click += this.chkTracking_Click;
        this.chkTracking.AutoSize = true;
        this.chkTracking.Location = new Point(73, 95);
        this.chkTracking.Name = "chkTracking";
        this.chkTracking.Size = new Size(101, 17);
        this.chkTracking.TabIndex = 13;
        this.chkTracking.Text = "Tracking Bonus";
        this.chkTracking.UseVisualStyleBackColor = true;
        this.chkTracking.Click += this.chkTracking_Click;
        this.flowLayoutPanel4.Controls.Add(this.label7);
        this.flowLayoutPanel4.Controls.Add(this.cboContactRaceFilter);
        this.flowLayoutPanel4.Location = new Point(3, 125);
        this.flowLayoutPanel4.Margin = new Padding(3, 0, 3, 0);
        this.flowLayoutPanel4.Name = "flowLayoutPanel4";
        this.flowLayoutPanel4.Size = new Size(315, 46);
        this.flowLayoutPanel4.TabIndex = 31 /*0x1F*/;
        this.label7.AutoSize = true;
        this.label7.Location = new Point(3, 0);
        this.label7.Name = "label7";
        this.label7.Size = new Size(161, 13);
        this.label7.TabIndex = 25;
        this.label7.Text = "Display single race contacts only";
        this.cboContactRaceFilter.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboContactRaceFilter.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboContactRaceFilter.FormattingEnabled = true;
        this.cboContactRaceFilter.Location = new Point(3, 16 /*0x10*/);
        this.cboContactRaceFilter.Name = "cboContactRaceFilter";
        this.cboContactRaceFilter.Size = new Size(309, 21);
        this.cboContactRaceFilter.TabIndex = 29;
        this.cboContactRaceFilter.SelectedIndexChanged += this.cboContactRaceFilter_SelectedIndexChanged;
        this.label6.AutoSize = true;
        this.label6.Location = new Point(3, 172);
        this.label6.Margin = new Padding(3, 1, 3, 0);
        this.label6.Name = "label6";
        this.label6.Size = new Size(110, 13);
        this.label6.TabIndex = 32 /*0x20*/;
        this.label6.Text = "Complete Contact List";
        this.chkContactsCurrentSystem.AutoSize = true;
        this.chkContactsCurrentSystem.Checked = true;
        this.chkContactsCurrentSystem.CheckState = CheckState.Checked;
        this.chkContactsCurrentSystem.Location = new Point(181, 171);
        this.chkContactsCurrentSystem.Margin = new Padding(65, 0, 3, 0);
        this.chkContactsCurrentSystem.Name = "chkContactsCurrentSystem";
        this.chkContactsCurrentSystem.Size = new Size(121, 17);
        this.chkContactsCurrentSystem.TabIndex = 34;
        this.chkContactsCurrentSystem.Text = "Current System Only";
        this.chkContactsCurrentSystem.UseVisualStyleBackColor = true;
        this.chkContactsCurrentSystem.Click += this.chkContactsCurrentSystem_Click;
        this.tvContacts.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvContacts.BorderStyle = BorderStyle.None;
        this.tvContacts.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.tvContacts.Location = new Point(3, 191);
        this.tvContacts.Name = "tvContacts";
        this.tvContacts.Size = new Size(314, 540);
        this.tvContacts.TabIndex = 33;
        this.tvContacts.AfterCollapse += this.tvContacts_AfterExpand;
        this.tvContacts.AfterExpand += this.tvContacts_AfterExpand;
        this.tabLabels.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabLabels.Controls.Add(this.cmdCopyLabel);
        this.tabLabels.Controls.Add(this.cmdUpdateText);
        this.tabLabels.Controls.Add(this.cmdLabelFont);
        this.tabLabels.Controls.Add(this.cmdNewLabel);
        this.tabLabels.Controls.Add(this.cmdDeleteLabel);
        this.tabLabels.Controls.Add(this.txtLabel);
        this.tabLabels.Location = new Point(4, 40);
        this.tabLabels.Name = "tabLabels";
        this.tabLabels.Padding = new Padding(3);
        this.tabLabels.Size = new Size(324, 736);
        this.tabLabels.TabIndex = 4;
        this.tabLabels.Text = "Map Labels";
        this.cmdCopyLabel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCopyLabel.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdCopyLabel.Location = new Point(115, 217);
        this.cmdCopyLabel.Margin = new Padding(0);
        this.cmdCopyLabel.Name = "cmdCopyLabel";
        this.cmdCopyLabel.Size = new Size(95, 30);
        this.cmdCopyLabel.TabIndex = 152;
        this.cmdCopyLabel.Tag = "1200";
        this.cmdCopyLabel.Text = "Copy Label";
        this.cmdCopyLabel.UseVisualStyleBackColor = false;
        this.cmdCopyLabel.Click += this.cmdCopyLabel_Click;
        this.cmdUpdateText.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdUpdateText.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdUpdateText.Location = new Point(223, 217);
        this.cmdUpdateText.Margin = new Padding(0);
        this.cmdUpdateText.Name = "cmdUpdateText";
        this.cmdUpdateText.Size = new Size(95, 30);
        this.cmdUpdateText.TabIndex = 151;
        this.cmdUpdateText.Tag = "1200";
        this.cmdUpdateText.Text = "Update Text";
        this.cmdUpdateText.UseVisualStyleBackColor = false;
        this.cmdUpdateText.Click += this.cmdUpdateText_Click;
        this.cmdLabelFont.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdLabelFont.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdLabelFont.Location = new Point(223, 247);
        this.cmdLabelFont.Margin = new Padding(0);
        this.cmdLabelFont.Name = "cmdLabelFont";
        this.cmdLabelFont.Size = new Size(95, 30);
        this.cmdLabelFont.TabIndex = 150;
        this.cmdLabelFont.Tag = "1200";
        this.cmdLabelFont.Text = "Change Font";
        this.cmdLabelFont.UseVisualStyleBackColor = false;
        this.cmdLabelFont.Click += this.cmdLabelFont_Click;
        this.cmdNewLabel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdNewLabel.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdNewLabel.Location = new Point(6, 217);
        this.cmdNewLabel.Margin = new Padding(0);
        this.cmdNewLabel.Name = "cmdNewLabel";
        this.cmdNewLabel.Size = new Size(95, 30);
        this.cmdNewLabel.TabIndex = 149;
        this.cmdNewLabel.Tag = "1200";
        this.cmdNewLabel.Text = "New Label";
        this.cmdNewLabel.UseVisualStyleBackColor = false;
        this.cmdNewLabel.Click += this.cmdNewLabel_Click;
        this.cmdDeleteLabel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteLabel.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDeleteLabel.Location = new Point(6, 247);
        this.cmdDeleteLabel.Margin = new Padding(0);
        this.cmdDeleteLabel.Name = "cmdDeleteLabel";
        this.cmdDeleteLabel.Size = new Size(95, 30);
        this.cmdDeleteLabel.TabIndex = 148;
        this.cmdDeleteLabel.Tag = "1200";
        this.cmdDeleteLabel.Text = "Delete Label";
        this.cmdDeleteLabel.UseVisualStyleBackColor = false;
        this.cmdDeleteLabel.Click += this.cmdDeleteLabel_Click;
        this.txtLabel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtLabel.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.txtLabel.Location = new Point(6, 6);
        this.txtLabel.Multiline = true;
        this.txtLabel.Name = "txtLabel";
        this.txtLabel.Size = new Size(312, 208 /*0xD0*/);
        this.txtLabel.TabIndex = 147;
        this.tabPage1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage1.Controls.Add(this.lstvSurveySites);
        this.tabPage1.Location = new Point(4, 40);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new Padding(3);
        this.tabPage1.Size = new Size(324, 736);
        this.tabPage1.TabIndex = 5;
        this.tabPage1.Text = "Survey Sites";
        this.lstvSurveySites.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvSurveySites.BorderStyle = BorderStyle.None;
        this.lstvSurveySites.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_3,
            this.columnHeader_4
        });
        this.lstvSurveySites.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvSurveySites.FullRowSelect = true;
        this.lstvSurveySites.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvSurveySites.HideSelection = false;
        this.lstvSurveySites.Location = new Point(3, 3);
        this.lstvSurveySites.Name = "lstvSurveySites";
        this.lstvSurveySites.Size = new Size(318, 730);
        this.lstvSurveySites.TabIndex = 15;
        this.lstvSurveySites.UseCompatibleStateImageBehavior = false;
        this.lstvSurveySites.View = View.Details;
        this.columnHeader_3.Width = 190;
        this.columnHeader_4.Width = 80 /*0x50*/;
        this.tabMissiles.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabMissiles.Controls.Add(this.lstvMissiles);
        this.tabMissiles.Location = new Point(4, 40);
        this.tabMissiles.Name = "tabMissiles";
        this.tabMissiles.Padding = new Padding(3);
        this.tabMissiles.Size = new Size(324, 736);
        this.tabMissiles.TabIndex = 7;
        this.tabMissiles.Text = "Missiles";
        this.lstvMissiles.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvMissiles.BorderStyle = BorderStyle.None;
        this.lstvMissiles.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_5,
            this.columnHeader_6
        });
        this.lstvMissiles.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvMissiles.FullRowSelect = true;
        this.lstvMissiles.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvMissiles.HideSelection = false;
        this.lstvMissiles.Location = new Point(3, 3);
        this.lstvMissiles.Name = "lstvMissiles";
        this.lstvMissiles.Size = new Size(318, 730);
        this.lstvMissiles.TabIndex = 16 /*0x10*/;
        this.lstvMissiles.UseCompatibleStateImageBehavior = false;
        this.lstvMissiles.View = View.Details;
        this.columnHeader_5.Width = 140;
        this.columnHeader_6.Width = 160 /*0xA0*/;
        this.tabPage2.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage2.Controls.Add(this.cmdScreenshotNoUI);
        this.tabPage2.Controls.Add(this.cmdScreenshot);
        this.tabPage2.Controls.Add(this.cmdSystemSearch);
        this.tabPage2.Controls.Add(this.cmdSupernova);
        this.tabPage2.Controls.Add(this.flowLayoutPanel10);
        this.tabPage2.Location = new Point(4, 40);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new Padding(3);
        this.tabPage2.Size = new Size(324, 736);
        this.tabPage2.TabIndex = 6;
        this.tabPage2.Text = "Miscellaneous";
        this.cmdScreenshotNoUI.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdScreenshotNoUI.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdScreenshotNoUI.Location = new Point(87, 623);
        this.cmdScreenshotNoUI.Name = "cmdScreenshotNoUI";
        this.cmdScreenshotNoUI.Size = new Size(150, 30);
        this.cmdScreenshotNoUI.TabIndex = 157;
        this.cmdScreenshotNoUI.Tag = "1200";
        this.cmdScreenshotNoUI.Text = "Screenshot - No UI";
        this.cmdScreenshotNoUI.UseVisualStyleBackColor = false;
        this.cmdScreenshotNoUI.Click += this.cmdScreenshotNoUI_Click;
        this.cmdScreenshot.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdScreenshot.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdScreenshot.Location = new Point(87, 659);
        this.cmdScreenshot.Name = "cmdScreenshot";
        this.cmdScreenshot.Size = new Size(150, 30);
        this.cmdScreenshot.TabIndex = 156;
        this.cmdScreenshot.Tag = "1200";
        this.cmdScreenshot.Text = "Full Map Screenshot";
        this.cmdScreenshot.UseVisualStyleBackColor = false;
        this.cmdScreenshot.Click += this.cmdScreenshot_Click;
        this.cmdSystemSearch.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSystemSearch.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSystemSearch.Location = new Point(87, 695);
        this.cmdSystemSearch.Name = "cmdSystemSearch";
        this.cmdSystemSearch.Size = new Size(150, 30);
        this.cmdSystemSearch.TabIndex = 155;
        this.cmdSystemSearch.Tag = "1200";
        this.cmdSystemSearch.Text = "System Search";
        this.cmdSystemSearch.UseVisualStyleBackColor = false;
        this.cmdSystemSearch.Click += this.cmdSystemSearch_Click;
        this.cmdSupernova.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSupernova.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSupernova.Location = new Point(87, 587);
        this.cmdSupernova.Name = "cmdSupernova";
        this.cmdSupernova.Size = new Size(150, 30);
        this.cmdSupernova.TabIndex = 154;
        this.cmdSupernova.Tag = "1200";
        this.cmdSupernova.Text = "Trigger Supernova";
        this.cmdSupernova.UseVisualStyleBackColor = false;
        this.cmdSupernova.Click += this.cmdSupernova_Click;
        this.flowLayoutPanel10.Controls.Add(this.pbShip);
        this.flowLayoutPanel10.Controls.Add(this.pbStation);
        this.flowLayoutPanel10.Controls.Add(this.cmdHull);
        this.flowLayoutPanel10.Controls.Add(this.cmdStation);
        this.flowLayoutPanel10.Controls.Add(this.label5);
        this.flowLayoutPanel10.Controls.Add(this.cboStatus);
        this.flowLayoutPanel10.Controls.Add(this.chkNoAutoRoute);
        this.flowLayoutPanel10.Controls.Add(this.chkRestricted);
        this.flowLayoutPanel10.Controls.Add(this.chkMineralSearchFlag);
        this.flowLayoutPanel10.Location = new Point(5, 6);
        this.flowLayoutPanel10.Margin = new Padding(0);
        this.flowLayoutPanel10.Name = "flowLayoutPanel10";
        this.flowLayoutPanel10.Size = new Size(316, 313);
        this.flowLayoutPanel10.TabIndex = 16 /*0x10*/;
        this.pbShip.Anchor = AnchorStyles.None;
        this.pbShip.BorderStyle = BorderStyle.FixedSingle;
        this.pbShip.Location = new Point(3, 3);
        this.pbShip.Name = "pbShip";
        this.pbShip.Size = new Size(152, 152);
        this.pbShip.SizeMode = PictureBoxSizeMode.Zoom;
        this.pbShip.TabIndex = 147;
        this.pbShip.TabStop = false;
        this.pbStation.Anchor = AnchorStyles.None;
        this.pbStation.BorderStyle = BorderStyle.FixedSingle;
        this.pbStation.Location = new Point(161, 3);
        this.pbStation.Name = "pbStation";
        this.pbStation.Size = new Size(152, 152);
        this.pbStation.SizeMode = PictureBoxSizeMode.Zoom;
        this.pbStation.TabIndex = 146;
        this.pbStation.TabStop = false;
        this.cmdHull.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdHull.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdHull.Location = new Point(3, 161);
        this.cmdHull.Name = "cmdHull";
        this.cmdHull.Size = new Size(150, 30);
        this.cmdHull.TabIndex = 148;
        this.cmdHull.Tag = "1200";
        this.cmdHull.Text = "Change Hull";
        this.cmdHull.UseVisualStyleBackColor = false;
        this.cmdHull.Click += this.cmdHull_Click;
        this.cmdStation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdStation.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdStation.Location = new Point(159, 161);
        this.cmdStation.Name = "cmdStation";
        this.cmdStation.Size = new Size(150, 30);
        this.cmdStation.TabIndex = 149;
        this.cmdStation.Tag = "1200";
        this.cmdStation.Text = "Change Station";
        this.cmdStation.UseVisualStyleBackColor = false;
        this.cmdStation.Click += this.cmdStation_Click;
        this.label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.label5.AutoSize = true;
        this.label5.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.label5.Location = new Point(3, 203);
        this.label5.Margin = new Padding(3, 9, 3, 3);
        this.label5.Name = "label5";
        this.label5.Size = new Size(88, 13);
        this.label5.TabIndex = 152;
        this.label5.Text = "Protection Status";
        this.label5.TextAlign = ContentAlignment.MiddleCenter;
        this.cboStatus.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboStatus.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboStatus.FormattingEnabled = true;
        this.cboStatus.Location = new Point(97, 200);
        this.cboStatus.Margin = new Padding(3, 6, 3, 0);
        this.cboStatus.Name = "cboStatus";
        this.cboStatus.Size = new Size(209, 21);
        this.cboStatus.TabIndex = 151;
        this.cboStatus.SelectedIndexChanged += this.cboStatus_SelectedIndexChanged;
        this.chkNoAutoRoute.AutoSize = true;
        this.chkNoAutoRoute.Location = new Point(3, 227);
        this.chkNoAutoRoute.Margin = new Padding(3, 6, 3, 3);
        this.chkNoAutoRoute.Name = "chkNoAutoRoute";
        this.chkNoAutoRoute.Padding = new Padding(5, 0, 0, 0);
        this.chkNoAutoRoute.Size = new Size(194, 17);
        this.chkNoAutoRoute.TabIndex = 31 /*0x1F*/;
        this.chkNoAutoRoute.Text = "Block Fleet Movement Auto Route";
        this.chkNoAutoRoute.TextAlign = ContentAlignment.MiddleRight;
        this.chkNoAutoRoute.UseVisualStyleBackColor = true;
        this.chkNoAutoRoute.CheckedChanged += this.chkNoAutoRoute_CheckedChanged;
        this.chkRestricted.AutoSize = true;
        this.chkRestricted.Location = new Point(3, 253);
        this.chkRestricted.Margin = new Padding(3, 6, 40, 3);
        this.chkRestricted.Name = "chkRestricted";
        this.chkRestricted.Padding = new Padding(5, 0, 0, 0);
        this.chkRestricted.Size = new Size(151, 17);
        this.chkRestricted.TabIndex = 150;
        this.chkRestricted.Text = "Military Restricted System";
        this.chkRestricted.TextAlign = ContentAlignment.MiddleRight;
        this.chkRestricted.UseVisualStyleBackColor = true;
        this.chkRestricted.CheckedChanged += this.chkRestricted_CheckedChanged;
        this.chkMineralSearchFlag.AutoSize = true;
        this.chkMineralSearchFlag.Location = new Point(3, 279);
        this.chkMineralSearchFlag.Margin = new Padding(3, 6, 3, 3);
        this.chkMineralSearchFlag.Name = "chkMineralSearchFlag";
        this.chkMineralSearchFlag.Padding = new Padding(5, 0, 0, 0);
        this.chkMineralSearchFlag.Size = new Size(125, 17);
        this.chkMineralSearchFlag.TabIndex = 153;
        this.chkMineralSearchFlag.Text = "Mineral Search Flag";
        this.chkMineralSearchFlag.TextAlign = ContentAlignment.MiddleRight;
        this.chkMineralSearchFlag.UseVisualStyleBackColor = true;
        this.chkMineralSearchFlag.CheckedChanged += this.chkMineralSearchFlag_CheckedChanged;
        this.tabPage3.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage3.Controls.Add(this.flowLayoutPanel13);
        this.tabPage3.Location = new Point(4, 40);
        this.tabPage3.Name = "tabPage3";
        this.tabPage3.Padding = new Padding(3);
        this.tabPage3.Size = new Size(324, 736);
        this.tabPage3.TabIndex = 8;
        this.tabPage3.Text = "Icon Display";
        this.flowLayoutPanel13.Controls.Add(this.flowLayoutPanel14);
        this.flowLayoutPanel13.Controls.Add(this.flowLayoutPanel15);
        this.flowLayoutPanel13.Dock = DockStyle.Fill;
        this.flowLayoutPanel13.Location = new Point(3, 3);
        this.flowLayoutPanel13.Name = "flowLayoutPanel13";
        this.flowLayoutPanel13.Size = new Size(318, 730);
        this.flowLayoutPanel13.TabIndex = 0;
        this.flowLayoutPanel14.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel14.Controls.Add(this.label4);
        this.flowLayoutPanel14.Controls.Add(this.choFlagStatus);
        this.flowLayoutPanel14.Controls.Add(this.label8);
        this.flowLayoutPanel14.Controls.Add(this.rdoMonth);
        this.flowLayoutPanel14.Controls.Add(this.rdoWeek);
        this.flowLayoutPanel14.Controls.Add(this.rdoDay);
        this.flowLayoutPanel14.Controls.Add(this.rdoCurrent);
        this.flowLayoutPanel14.Location = new Point(0, 0);
        this.flowLayoutPanel14.Margin = new Padding(0);
        this.flowLayoutPanel14.Name = "flowLayoutPanel14";
        this.flowLayoutPanel14.Size = new Size(318, 55);
        this.flowLayoutPanel14.TabIndex = 0;
        this.label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.label4.AutoSize = true;
        this.label4.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.label4.Location = new Point(3, 9);
        this.label4.Margin = new Padding(3, 9, 3, 3);
        this.label4.Name = "label4";
        this.label4.Size = new Size(70, 13);
        this.label4.TabIndex = 153;
        this.label4.Text = "Race Display";
        this.label4.TextAlign = ContentAlignment.MiddleCenter;
        this.label4.Click += this.label4_Click;
        this.choFlagStatus.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.choFlagStatus.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.choFlagStatus.FormattingEnabled = true;
        this.choFlagStatus.Location = new Point(91, 3);
        this.choFlagStatus.Margin = new Padding(15, 3, 3, 3);
        this.choFlagStatus.Name = "choFlagStatus";
        this.choFlagStatus.Size = new Size(217, 21);
        this.choFlagStatus.TabIndex = 17;
        this.choFlagStatus.SelectedIndexChanged += this.choFlagStatus_SelectedIndexChanged;
        this.label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.label8.AutoSize = true;
        this.label8.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.label8.Location = new Point(3, 32 /*0x20*/);
        this.label8.Margin = new Padding(3, 5, 6, 5);
        this.label8.Name = "label8";
        this.label8.Size = new Size(66, 13);
        this.label8.TabIndex = 154;
        this.label8.Text = "Contact Age";
        this.label8.TextAlign = ContentAlignment.MiddleCenter;
        this.label8.Click += this.label8_Click;
        this.rdoMonth.AutoSize = true;
        this.rdoMonth.Location = new Point(78, 30);
        this.rdoMonth.Margin = new Padding(3, 3, 3, 0);
        this.rdoMonth.Name = "rdoMonth";
        this.rdoMonth.Size = new Size(55, 17);
        this.rdoMonth.TabIndex = 157;
        this.rdoMonth.Text = "Month";
        this.rdoMonth.UseVisualStyleBackColor = true;
        this.rdoMonth.CheckedChanged += this.rdoCurrent_CheckedChanged;
        this.rdoWeek.AutoSize = true;
        this.rdoWeek.Location = new Point(139, 30);
        this.rdoWeek.Name = "rdoWeek";
        this.rdoWeek.Size = new Size(54, 17);
        this.rdoWeek.TabIndex = 156;
        this.rdoWeek.Text = "Week";
        this.rdoWeek.UseVisualStyleBackColor = true;
        this.rdoWeek.CheckedChanged += this.rdoCurrent_CheckedChanged;
        this.rdoDay.AutoSize = true;
        this.rdoDay.Location = new Point(199, 30);
        this.rdoDay.Name = "rdoDay";
        this.rdoDay.Size = new Size(44, 17);
        this.rdoDay.TabIndex = 155;
        this.rdoDay.Text = "Day";
        this.rdoDay.UseVisualStyleBackColor = true;
        this.rdoDay.CheckedChanged += this.rdoCurrent_CheckedChanged;
        this.rdoCurrent.AutoSize = true;
        this.rdoCurrent.Checked = true;
        this.rdoCurrent.Location = new Point(249, 30);
        this.rdoCurrent.Name = "rdoCurrent";
        this.rdoCurrent.Size = new Size(59, 17);
        this.rdoCurrent.TabIndex = 154;
        this.rdoCurrent.TabStop = true;
        this.rdoCurrent.Text = "Current";
        this.rdoCurrent.UseVisualStyleBackColor = true;
        this.rdoCurrent.CheckedChanged += this.rdoCurrent_CheckedChanged;
        this.flowLayoutPanel15.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel15.Controls.Add(this.chkClassIcon);
        this.flowLayoutPanel15.Controls.Add(this.cboClassIcon);
        this.flowLayoutPanel15.Controls.Add(this.chkAdminIcon);
        this.flowLayoutPanel15.Controls.Add(this.cboAdminIcon);
        this.flowLayoutPanel15.Location = new Point(0, 61);
        this.flowLayoutPanel15.Margin = new Padding(0, 6, 0, 0);
        this.flowLayoutPanel15.Name = "flowLayoutPanel15";
        this.flowLayoutPanel15.Size = new Size(318, 59);
        this.flowLayoutPanel15.TabIndex = 158;
        this.chkClassIcon.AutoSize = true;
        this.chkClassIcon.Location = new Point(3, 6);
        this.chkClassIcon.Margin = new Padding(3, 6, 3, 3);
        this.chkClassIcon.Name = "chkClassIcon";
        this.chkClassIcon.Size = new Size(75, 17);
        this.chkClassIcon.TabIndex = 155;
        this.chkClassIcon.Text = "Ship Class";
        this.chkClassIcon.UseVisualStyleBackColor = true;
        this.chkClassIcon.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.cboClassIcon.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboClassIcon.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboClassIcon.FormattingEnabled = true;
        this.cboClassIcon.Location = new Point(92, 3);
        this.cboClassIcon.Margin = new Padding(11, 3, 3, 3);
        this.cboClassIcon.Name = "cboClassIcon";
        this.cboClassIcon.Size = new Size(217, 21);
        this.cboClassIcon.TabIndex = 154;
        this.cboClassIcon.SelectedIndexChanged += this.cboClassIcon_SelectedIndexChanged;
        this.chkAdminIcon.AutoSize = true;
        this.chkAdminIcon.Location = new Point(3, 33);
        this.chkAdminIcon.Margin = new Padding(3, 6, 3, 3);
        this.chkAdminIcon.Name = "chkAdminIcon";
        this.chkAdminIcon.Size = new Size(86, 17);
        this.chkAdminIcon.TabIndex = 157;
        this.chkAdminIcon.Text = "Naval Admin";
        this.chkAdminIcon.UseVisualStyleBackColor = true;
        this.chkAdminIcon.CheckedChanged += this.chkAdminIcon_CheckedChanged;
        this.cboAdminIcon.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboAdminIcon.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboAdminIcon.FormattingEnabled = true;
        this.cboAdminIcon.Location = new Point(92, 30);
        this.cboAdminIcon.Margin = new Padding(0, 3, 3, 3);
        this.cboAdminIcon.Name = "cboAdminIcon";
        this.cboAdminIcon.Size = new Size(217, 21);
        this.cboAdminIcon.TabIndex = 156;
        this.cboAdminIcon.SelectedIndexChanged += this.cboAdminIcon_SelectedIndexChanged;
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarColony);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarIndustry);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarMining);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarResearch);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarWealth);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarClass);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarProject);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarFleet);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarMissileDesign);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarTurret);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarGroundForces);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarCommanders);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarMedals);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarRace);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarSystem);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarHabitable);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarIntelligence);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarTechnology);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarSurvey);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarSector);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarEvents);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarRefreshGalactic);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarGrid);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarUndo);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarSavePositions);
        this.tlbMainToolbar.Controls.Add(this.cmdSM);
        this.tlbMainToolbar.Controls.Add(this.cmdToolbarAuto);
        this.tlbMainToolbar.Location = new Point(0, 0);
        this.tlbMainToolbar.Margin = new Padding(3, 0, 3, 0);
        this.tlbMainToolbar.Name = "tlbMainToolbar";
        this.tlbMainToolbar.Size = new Size(1296, 48 /*0x30*/);
        this.tlbMainToolbar.TabIndex = 14;
        this.cmdToolbarColony.AccessibleName = "Colony Summary";
        this.cmdToolbarColony.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarColony.BackgroundImage");
        this.cmdToolbarColony.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarColony.Location = new Point(0, 0);
        this.cmdToolbarColony.Margin = new Padding(0);
        this.cmdToolbarColony.Name = "cmdToolbarColony";
        this.cmdToolbarColony.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarColony.TabIndex = 0;
        this.cmdToolbarColony.UseVisualStyleBackColor = true;
        this.cmdToolbarColony.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarIndustry.AccessibleName = "Industrial Projects";
        this.cmdToolbarIndustry.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarIndustry.BackgroundImage");
        this.cmdToolbarIndustry.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarIndustry.Location = new Point(48 /*0x30*/, 0);
        this.cmdToolbarIndustry.Margin = new Padding(0);
        this.cmdToolbarIndustry.Name = "cmdToolbarIndustry";
        this.cmdToolbarIndustry.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarIndustry.TabIndex = 2;
        this.cmdToolbarIndustry.UseVisualStyleBackColor = true;
        this.cmdToolbarIndustry.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarMining.AccessibleName = "Mining Summary";
        this.cmdToolbarMining.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarMining.BackgroundImage");
        this.cmdToolbarMining.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarMining.Location = new Point(96 /*0x60*/, 0);
        this.cmdToolbarMining.Margin = new Padding(0);
        this.cmdToolbarMining.Name = "cmdToolbarMining";
        this.cmdToolbarMining.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarMining.TabIndex = 2;
        this.cmdToolbarMining.UseVisualStyleBackColor = true;
        this.cmdToolbarMining.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarResearch.AccessibleName = "Research Projects";
        this.cmdToolbarResearch.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarResearch.BackgroundImage");
        this.cmdToolbarResearch.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarResearch.Location = new Point(144 /*0x90*/, 0);
        this.cmdToolbarResearch.Margin = new Padding(0);
        this.cmdToolbarResearch.Name = "cmdToolbarResearch";
        this.cmdToolbarResearch.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarResearch.TabIndex = 3;
        this.cmdToolbarResearch.UseVisualStyleBackColor = true;
        this.cmdToolbarResearch.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarWealth.AccessibleName = "Wealth Summary";
        this.cmdToolbarWealth.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarWealth.BackgroundImage");
        this.cmdToolbarWealth.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarWealth.Location = new Point(192 /*0xC0*/, 0);
        this.cmdToolbarWealth.Margin = new Padding(0);
        this.cmdToolbarWealth.Name = "cmdToolbarWealth";
        this.cmdToolbarWealth.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarWealth.TabIndex = 4;
        this.cmdToolbarWealth.UseVisualStyleBackColor = true;
        this.cmdToolbarWealth.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarClass.AccessibleName = "Class Design";
        this.cmdToolbarClass.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarClass.BackgroundImage");
        this.cmdToolbarClass.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarClass.Location = new Point(240 /*0xF0*/, 0);
        this.cmdToolbarClass.Margin = new Padding(0);
        this.cmdToolbarClass.Name = "cmdToolbarClass";
        this.cmdToolbarClass.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarClass.TabIndex = 5;
        this.cmdToolbarClass.UseVisualStyleBackColor = true;
        this.cmdToolbarClass.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarProject.AccessibleName = "Create Projects";
        this.cmdToolbarProject.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarProject.BackgroundImage");
        this.cmdToolbarProject.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarProject.Location = new Point(288, 0);
        this.cmdToolbarProject.Margin = new Padding(0);
        this.cmdToolbarProject.Name = "cmdToolbarProject";
        this.cmdToolbarProject.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarProject.TabIndex = 6;
        this.cmdToolbarProject.UseVisualStyleBackColor = true;
        this.cmdToolbarProject.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarFleet.AccessibleName = "Naval Organization";
        this.cmdToolbarFleet.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarFleet.BackgroundImage");
        this.cmdToolbarFleet.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarFleet.Location = new Point(336, 0);
        this.cmdToolbarFleet.Margin = new Padding(0);
        this.cmdToolbarFleet.Name = "cmdToolbarFleet";
        this.cmdToolbarFleet.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarFleet.TabIndex = 7;
        this.cmdToolbarFleet.UseVisualStyleBackColor = true;
        this.cmdToolbarFleet.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarMissileDesign.AccessibleName = "Missile Design";
        this.cmdToolbarMissileDesign.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarMissileDesign.BackgroundImage");
        this.cmdToolbarMissileDesign.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarMissileDesign.Location = new Point(384, 0);
        this.cmdToolbarMissileDesign.Margin = new Padding(0);
        this.cmdToolbarMissileDesign.Name = "cmdToolbarMissileDesign";
        this.cmdToolbarMissileDesign.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarMissileDesign.TabIndex = 8;
        this.cmdToolbarMissileDesign.UseVisualStyleBackColor = true;
        this.cmdToolbarMissileDesign.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarTurret.AccessibleName = "Turret Design";
        this.cmdToolbarTurret.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarTurret.BackgroundImage");
        this.cmdToolbarTurret.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarTurret.Location = new Point(432, 0);
        this.cmdToolbarTurret.Margin = new Padding(0);
        this.cmdToolbarTurret.Name = "cmdToolbarTurret";
        this.cmdToolbarTurret.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarTurret.TabIndex = 9;
        this.cmdToolbarTurret.UseVisualStyleBackColor = true;
        this.cmdToolbarTurret.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarGroundForces.AccessibleName = "Ground Forces";
        this.cmdToolbarGroundForces.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarGroundForces.BackgroundImage");
        this.cmdToolbarGroundForces.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarGroundForces.Location = new Point(480, 0);
        this.cmdToolbarGroundForces.Margin = new Padding(0);
        this.cmdToolbarGroundForces.Name = "cmdToolbarGroundForces";
        this.cmdToolbarGroundForces.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarGroundForces.TabIndex = 10;
        this.cmdToolbarGroundForces.UseVisualStyleBackColor = true;
        this.cmdToolbarGroundForces.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarCommanders.AccessibleName = "Commanders";
        this.cmdToolbarCommanders.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarCommanders.BackgroundImage");
        this.cmdToolbarCommanders.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarCommanders.Location = new Point(528, 0);
        this.cmdToolbarCommanders.Margin = new Padding(0);
        this.cmdToolbarCommanders.Name = "cmdToolbarCommanders";
        this.cmdToolbarCommanders.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarCommanders.TabIndex = 11;
        this.cmdToolbarCommanders.UseVisualStyleBackColor = true;
        this.cmdToolbarCommanders.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarMedals.AccessibleName = "Medal Design";
        this.cmdToolbarMedals.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarMedals.BackgroundImage");
        this.cmdToolbarMedals.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarMedals.Location = new Point(576, 0);
        this.cmdToolbarMedals.Margin = new Padding(0);
        this.cmdToolbarMedals.Name = "cmdToolbarMedals";
        this.cmdToolbarMedals.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarMedals.TabIndex = 12;
        this.cmdToolbarMedals.UseVisualStyleBackColor = true;
        this.cmdToolbarRace.AccessibleName = "Race Summary";
        this.cmdToolbarRace.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarRace.BackgroundImage");
        this.cmdToolbarRace.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarRace.Location = new Point(624, 0);
        this.cmdToolbarRace.Margin = new Padding(0);
        this.cmdToolbarRace.Name = "cmdToolbarRace";
        this.cmdToolbarRace.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarRace.TabIndex = 13;
        this.cmdToolbarRace.UseVisualStyleBackColor = true;
        this.cmdToolbarRace.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarSystem.AccessibleName = "System View";
        this.cmdToolbarSystem.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarSystem.BackgroundImage");
        this.cmdToolbarSystem.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarSystem.Location = new Point(672, 0);
        this.cmdToolbarSystem.Margin = new Padding(0);
        this.cmdToolbarSystem.Name = "cmdToolbarSystem";
        this.cmdToolbarSystem.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarSystem.TabIndex = 14;
        this.cmdToolbarSystem.UseVisualStyleBackColor = true;
        this.cmdToolbarSystem.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarHabitable.AccessibleName = "Race Comparison";
        this.cmdToolbarHabitable.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarHabitable.BackgroundImage");
        this.cmdToolbarHabitable.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarHabitable.Location = new Point(720, 0);
        this.cmdToolbarHabitable.Margin = new Padding(0);
        this.cmdToolbarHabitable.Name = "cmdToolbarHabitable";
        this.cmdToolbarHabitable.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarHabitable.TabIndex = 15;
        this.cmdToolbarHabitable.UseVisualStyleBackColor = true;
        this.cmdToolbarHabitable.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarIntelligence.AccessibleName = "Diplomacy and Intelligence";
        this.cmdToolbarIntelligence.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarIntelligence.BackgroundImage");
        this.cmdToolbarIntelligence.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarIntelligence.Location = new Point(768 /*0x0300*/, 0);
        this.cmdToolbarIntelligence.Margin = new Padding(0);
        this.cmdToolbarIntelligence.Name = "cmdToolbarIntelligence";
        this.cmdToolbarIntelligence.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarIntelligence.TabIndex = 16 /*0x10*/;
        this.cmdToolbarIntelligence.UseVisualStyleBackColor = true;
        this.cmdToolbarIntelligence.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarTechnology.AccessibleName = "Technology View";
        this.cmdToolbarTechnology.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarTechnology.BackgroundImage");
        this.cmdToolbarTechnology.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarTechnology.Location = new Point(816, 0);
        this.cmdToolbarTechnology.Margin = new Padding(0);
        this.cmdToolbarTechnology.Name = "cmdToolbarTechnology";
        this.cmdToolbarTechnology.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarTechnology.TabIndex = 17;
        this.cmdToolbarTechnology.UseVisualStyleBackColor = true;
        this.cmdToolbarTechnology.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarSurvey.AccessibleName = "Mineral Search";
        this.cmdToolbarSurvey.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarSurvey.BackgroundImage");
        this.cmdToolbarSurvey.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarSurvey.Location = new Point(864, 0);
        this.cmdToolbarSurvey.Margin = new Padding(0);
        this.cmdToolbarSurvey.Name = "cmdToolbarSurvey";
        this.cmdToolbarSurvey.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarSurvey.TabIndex = 18;
        this.cmdToolbarSurvey.UseVisualStyleBackColor = true;
        this.cmdToolbarSurvey.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarSector.AccessibleName = "Sectors";
        this.cmdToolbarSector.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarSector.BackgroundImage");
        this.cmdToolbarSector.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarSector.Location = new Point(912, 0);
        this.cmdToolbarSector.Margin = new Padding(0);
        this.cmdToolbarSector.Name = "cmdToolbarSector";
        this.cmdToolbarSector.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarSector.TabIndex = 19;
        this.cmdToolbarSector.UseVisualStyleBackColor = true;
        this.cmdToolbarSector.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarEvents.AccessibleName = "Event Log";
        this.cmdToolbarEvents.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarEvents.BackgroundImage");
        this.cmdToolbarEvents.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarEvents.Location = new Point(960, 0);
        this.cmdToolbarEvents.Margin = new Padding(0);
        this.cmdToolbarEvents.Name = "cmdToolbarEvents";
        this.cmdToolbarEvents.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarEvents.TabIndex = 20;
        this.cmdToolbarEvents.UseVisualStyleBackColor = true;
        this.cmdToolbarEvents.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarRefreshGalactic.AccessibleName = "Refresh";
        this.cmdToolbarRefreshGalactic.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarRefreshGalactic.BackgroundImage");
        this.cmdToolbarRefreshGalactic.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarRefreshGalactic.Location = new Point(1008, 0);
        this.cmdToolbarRefreshGalactic.Margin = new Padding(0);
        this.cmdToolbarRefreshGalactic.Name = "cmdToolbarRefreshGalactic";
        this.cmdToolbarRefreshGalactic.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarRefreshGalactic.TabIndex = 21;
        this.cmdToolbarRefreshGalactic.UseVisualStyleBackColor = true;
        this.cmdToolbarRefreshGalactic.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarGrid.AccessibleName = "Line Up Systems";
        this.cmdToolbarGrid.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarGrid.BackgroundImage");
        this.cmdToolbarGrid.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarGrid.Location = new Point(1056, 0);
        this.cmdToolbarGrid.Margin = new Padding(0);
        this.cmdToolbarGrid.Name = "cmdToolbarGrid";
        this.cmdToolbarGrid.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarGrid.TabIndex = 22;
        this.cmdToolbarGrid.UseVisualStyleBackColor = true;
        this.cmdToolbarGrid.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarUndo.AccessibleName = "Revert to Previous System Positions";
        this.cmdToolbarUndo.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarUndo.BackgroundImage");
        this.cmdToolbarUndo.BackgroundImageLayout = ImageLayout.Zoom;
        this.cmdToolbarUndo.Location = new Point(1104, 0);
        this.cmdToolbarUndo.Margin = new Padding(0);
        this.cmdToolbarUndo.Name = "cmdToolbarUndo";
        this.cmdToolbarUndo.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarUndo.TabIndex = 23;
        this.cmdToolbarUndo.UseVisualStyleBackColor = true;
        this.cmdToolbarUndo.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarSavePositions.AccessibleName = "Save System Positions";
        this.cmdToolbarSavePositions.BackgroundImage =
            (Image)componentResourceManager.GetObject("cmdToolbarSavePositions.BackgroundImage");
        this.cmdToolbarSavePositions.BackgroundImageLayout = ImageLayout.Zoom;
        this.cmdToolbarSavePositions.Location = new Point(1152, 0);
        this.cmdToolbarSavePositions.Margin = new Padding(0);
        this.cmdToolbarSavePositions.Name = "cmdToolbarSavePositions";
        this.cmdToolbarSavePositions.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarSavePositions.TabIndex = 24;
        this.cmdToolbarSavePositions.UseVisualStyleBackColor = true;
        this.cmdToolbarSavePositions.Click += this.cmdToolbarAuto_Click;
        this.cmdSM.AccessibleName = "SM Mode";
        this.cmdSM.BackgroundImage = Resources.SMInactive;
        this.cmdSM.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdSM.Location = new Point(1200, 0);
        this.cmdSM.Margin = new Padding(0);
        this.cmdSM.Name = "cmdSM";
        this.cmdSM.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdSM.TabIndex = 25;
        this.cmdSM.UseVisualStyleBackColor = true;
        this.cmdSM.Click += this.cmdToolbarAuto_Click;
        this.cmdToolbarAuto.AccessibleName = "Automated Turns";
        this.cmdToolbarAuto.BackgroundImage = Resources.AutoOff;
        this.cmdToolbarAuto.BackgroundImageLayout = ImageLayout.Stretch;
        this.cmdToolbarAuto.Location = new Point(1248, 0);
        this.cmdToolbarAuto.Margin = new Padding(0);
        this.cmdToolbarAuto.Name = "cmdToolbarAuto";
        this.cmdToolbarAuto.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
        this.cmdToolbarAuto.TabIndex = 26;
        this.cmdToolbarAuto.UseVisualStyleBackColor = true;
        this.cmdToolbarAuto.Click += this.cmdToolbarAuto_Click;
        this.tblIncrement.Controls.Add(this.cmdIncrement);
        this.tblIncrement.Controls.Add(this.cmdIncrement2M);
        this.tblIncrement.Controls.Add(this.cmdIncrement5M);
        this.tblIncrement.Controls.Add(this.cmdIncrement20M);
        this.tblIncrement.Controls.Add(this.cmdIncrement1H);
        this.tblIncrement.Controls.Add(this.cmdIncrement3H);
        this.tblIncrement.Controls.Add(this.cmdIncrement8H);
        this.tblIncrement.Controls.Add(this.cmdIncrement1D);
        this.tblIncrement.Controls.Add(this.cmdIncrement5D);
        this.tblIncrement.Controls.Add(this.cmdIncrement30D);
        this.tblIncrement.Location = new Point(336, 51);
        this.tblIncrement.Name = "tblIncrement";
        this.tblIncrement.Size = new Size(960, 48 /*0x30*/);
        this.tblIncrement.TabIndex = 15;
        this.cmdIncrement.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdIncrement.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdIncrement.Location = new Point(0, 0);
        this.cmdIncrement.Margin = new Padding(0);
        this.cmdIncrement.Name = "cmdIncrement";
        this.cmdIncrement.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
        this.cmdIncrement.TabIndex = 4;
        this.cmdIncrement.Text = "Select Increment Length";
        this.cmdIncrement.UseVisualStyleBackColor = false;
        this.cmdIncrement2M.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdIncrement2M.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdIncrement2M.Location = new Point(96 /*0x60*/, 0);
        this.cmdIncrement2M.Margin = new Padding(0);
        this.cmdIncrement2M.Name = "cmdIncrement2M";
        this.cmdIncrement2M.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
        this.cmdIncrement2M.TabIndex = 2;
        this.cmdIncrement2M.Tag = "120";
        this.cmdIncrement2M.Text = "2 Minutes";
        this.cmdIncrement2M.UseVisualStyleBackColor = false;
        this.cmdIncrement2M.Click += this.cmdIncrement30D_Click;
        this.cmdIncrement5M.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdIncrement5M.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdIncrement5M.Location = new Point(192 /*0xC0*/, 0);
        this.cmdIncrement5M.Margin = new Padding(0);
        this.cmdIncrement5M.Name = "cmdIncrement5M";
        this.cmdIncrement5M.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
        this.cmdIncrement5M.TabIndex = 3;
        this.cmdIncrement5M.Tag = "300";
        this.cmdIncrement5M.Text = "5 Minutes";
        this.cmdIncrement5M.UseVisualStyleBackColor = false;
        this.cmdIncrement5M.Click += this.cmdIncrement30D_Click;
        this.cmdIncrement20M.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdIncrement20M.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdIncrement20M.Location = new Point(288, 0);
        this.cmdIncrement20M.Margin = new Padding(0);
        this.cmdIncrement20M.Name = "cmdIncrement20M";
        this.cmdIncrement20M.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
        this.cmdIncrement20M.TabIndex = 5;
        this.cmdIncrement20M.Tag = "1200";
        this.cmdIncrement20M.Text = "20 Minutes";
        this.cmdIncrement20M.UseVisualStyleBackColor = false;
        this.cmdIncrement20M.Click += this.cmdIncrement30D_Click;
        this.cmdIncrement1H.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdIncrement1H.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdIncrement1H.Location = new Point(384, 0);
        this.cmdIncrement1H.Margin = new Padding(0);
        this.cmdIncrement1H.Name = "cmdIncrement1H";
        this.cmdIncrement1H.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
        this.cmdIncrement1H.TabIndex = 6;
        this.cmdIncrement1H.Tag = "3600";
        this.cmdIncrement1H.Text = "1 Hour";
        this.cmdIncrement1H.UseVisualStyleBackColor = false;
        this.cmdIncrement1H.Click += this.cmdIncrement30D_Click;
        this.cmdIncrement3H.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdIncrement3H.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdIncrement3H.Location = new Point(480, 0);
        this.cmdIncrement3H.Margin = new Padding(0);
        this.cmdIncrement3H.Name = "cmdIncrement3H";
        this.cmdIncrement3H.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
        this.cmdIncrement3H.TabIndex = 7;
        this.cmdIncrement3H.Tag = "10800";
        this.cmdIncrement3H.Text = "3 Hours";
        this.cmdIncrement3H.UseVisualStyleBackColor = false;
        this.cmdIncrement3H.Click += this.cmdIncrement30D_Click;
        this.cmdIncrement8H.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdIncrement8H.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdIncrement8H.Location = new Point(576, 0);
        this.cmdIncrement8H.Margin = new Padding(0);
        this.cmdIncrement8H.Name = "cmdIncrement8H";
        this.cmdIncrement8H.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
        this.cmdIncrement8H.TabIndex = 8;
        this.cmdIncrement8H.Tag = "28800";
        this.cmdIncrement8H.Text = "8 Hours";
        this.cmdIncrement8H.UseVisualStyleBackColor = false;
        this.cmdIncrement8H.Click += this.cmdIncrement30D_Click;
        this.cmdIncrement1D.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdIncrement1D.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdIncrement1D.Location = new Point(672, 0);
        this.cmdIncrement1D.Margin = new Padding(0);
        this.cmdIncrement1D.Name = "cmdIncrement1D";
        this.cmdIncrement1D.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
        this.cmdIncrement1D.TabIndex = 9;
        this.cmdIncrement1D.Tag = "86400";
        this.cmdIncrement1D.Text = "1 Day";
        this.cmdIncrement1D.UseVisualStyleBackColor = false;
        this.cmdIncrement1D.Click += this.cmdIncrement30D_Click;
        this.cmdIncrement5D.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdIncrement5D.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdIncrement5D.Location = new Point(768 /*0x0300*/, 0);
        this.cmdIncrement5D.Margin = new Padding(0);
        this.cmdIncrement5D.Name = "cmdIncrement5D";
        this.cmdIncrement5D.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
        this.cmdIncrement5D.TabIndex = 10;
        this.cmdIncrement5D.Tag = "432000";
        this.cmdIncrement5D.Text = "5 Days";
        this.cmdIncrement5D.UseVisualStyleBackColor = false;
        this.cmdIncrement5D.Click += this.cmdIncrement30D_Click;
        this.cmdIncrement30D.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdIncrement30D.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdIncrement30D.Location = new Point(864, 0);
        this.cmdIncrement30D.Margin = new Padding(0);
        this.cmdIncrement30D.Name = "cmdIncrement30D";
        this.cmdIncrement30D.Size = new Size(96 /*0x60*/, 48 /*0x30*/);
        this.cmdIncrement30D.TabIndex = 11;
        this.cmdIncrement30D.Tag = "2592000";
        this.cmdIncrement30D.Text = "30 Days";
        this.cmdIncrement30D.UseVisualStyleBackColor = false;
        this.cmdIncrement30D.Click += this.cmdIncrement30D_Click;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(1424, 861);
        this.Controls.Add(this.tblIncrement);
        this.Controls.Add(this.tlbMainToolbar);
        this.Controls.Add(this.tabSidebar);
        this.Controls.Add(this.cboRaces);
        this.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.KeyPreview = true;
        this.Name = nameof(GalacticMap);
        this.Text = nameof(GalacticMap);
        this.Load += this.GalacticMap_Load;
        this.Click += this.GalacticMap_Click;
        this.Paint += this.GalacticMap_Paint;
        this.DoubleClick += this.GalacticMap_DoubleClick;
        this.KeyDown += this.GalacticMap_KeyDown;
        this.MouseDown += this.GalacticMap_MouseDown;
        this.MouseMove += this.GalacticMap_MouseMove;
        this.MouseUp += this.GalacticMap_MouseUp;
        this.tabSidebar.ResumeLayout(false);
        this.tabOverview.ResumeLayout(false);
        this.flowLayoutPanel5.ResumeLayout(false);
        this.flowLayoutPanel3.ResumeLayout(false);
        this.flowLayoutPanel3.PerformLayout();
        this.flowLayoutPanel7.ResumeLayout(false);
        this.flowLayoutPanel8.ResumeLayout(false);
        this.tabDisplay.ResumeLayout(false);
        this.flowLayoutPanel16.ResumeLayout(false);
        this.flowLayoutPanel16.PerformLayout();
        this.flowLayoutPanel11.ResumeLayout(false);
        this.flowLayoutPanel11.PerformLayout();
        this.flowLayoutPanel9.ResumeLayout(false);
        this.flowLayoutPanel9.PerformLayout();
        this.flowLayoutPanelDisplay.ResumeLayout(false);
        this.flowLayoutPanelDisplay.PerformLayout();
        this.tabNaval.ResumeLayout(false);
        this.flowLayoutPanel2.ResumeLayout(false);
        this.flowLayoutPanel2.PerformLayout();
        this.panel1.ResumeLayout(false);
        this.tabContacts.ResumeLayout(false);
        this.flowLayoutPanel1.ResumeLayout(false);
        this.flowLayoutPanel1.PerformLayout();
        this.flowLayoutPanel6.ResumeLayout(false);
        this.flowLayoutPanel6.PerformLayout();
        this.flowLayoutPanel4.ResumeLayout(false);
        this.flowLayoutPanel4.PerformLayout();
        this.tabLabels.ResumeLayout(false);
        this.tabLabels.PerformLayout();
        this.tabPage1.ResumeLayout(false);
        this.tabMissiles.ResumeLayout(false);
        this.tabPage2.ResumeLayout(false);
        this.flowLayoutPanel10.ResumeLayout(false);
        this.flowLayoutPanel10.PerformLayout();
        ((ISupportInitialize)this.pbShip).EndInit();
        ((ISupportInitialize)this.pbStation).EndInit();
        this.tabPage3.ResumeLayout(false);
        this.flowLayoutPanel13.ResumeLayout(false);
        this.flowLayoutPanel14.ResumeLayout(false);
        this.flowLayoutPanel14.PerformLayout();
        this.flowLayoutPanel15.ResumeLayout(false);
        this.flowLayoutPanel15.PerformLayout();
        this.tlbMainToolbar.ResumeLayout(false);
        this.tblIncrement.ResumeLayout(false);
        this.ResumeLayout(false);
    }
}