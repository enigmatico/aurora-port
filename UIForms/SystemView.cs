// Decompiled with JetBrains decompiler
// Type: SystemView
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class SystemView : Form
{
    private GClass0 gclass0_0;
    private RacialSystemSurvey gclass202_0;
    private GameRace gclass21_0;
    private Star197 gclass197_0;
    private SystemBodyData gclass1_0;
    private JumpPoint120 gclass120_0;
    private GClass194 gclass194_0;
    private GEnum1 genum1_0;
    private GEnum1 genum1_1 = GEnum1.const_2;
    private GEnum1 genum1_2 = GEnum1.const_1;
    private int int_0;
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private IContainer icontainer_0;
    private ComboBox cboSystems;
    private ListView lstvStars;
    private ColumnHeader columnHeader_0;
    private ColumnHeader columnHeader_1;
    private ColumnHeader columnHeader_2;
    private ColumnHeader columnHeader_3;
    private ColumnHeader columnHeader_4;
    private ColumnHeader columnHeader_5;
    private ColumnHeader columnHeader_6;
    private ColumnHeader columnHeader_7;
    private ListView lstvSB;
    private ColumnHeader columnHeader_8;
    private ColumnHeader columnHeader_9;
    private ColumnHeader columnHeader_10;
    private ColumnHeader columnHeader_11;
    private ColumnHeader columnHeader_12;
    private ColumnHeader columnHeader_13;
    private ColumnHeader columnHeader_14;
    private FlowLayoutPanel flowLayoutPanel1;
    private RadioButton rdoAllMoons;
    private RadioButton rdoMineralMoons;
    private RadioButton rdoHideMoons;
    private FlowLayoutPanel flowLayoutPanel2;
    private RadioButton rdoAllAsteroids;
    private RadioButton rdoMineralAsteroids;
    private RadioButton rdoHideAsteroids;
    private ColumnHeader columnHeader_15;
    private ColumnHeader columnHeader_16;
    private ColumnHeader columnHeader_17;
    private ColumnHeader columnHeader_18;
    private ColumnHeader columnHeader_19;
    private ColumnHeader columnHeader_20;
    private ColumnHeader columnHeader_21;
    private ColumnHeader columnHeader_22;
    private FlowLayoutPanel flowLayoutPanel3;
    private RadioButton rdoAllComets;
    private RadioButton rdoCometMinerals;
    private RadioButton rdoHideComets;
    private Label lblAge;
    private Label label6;
    private Label lblDiscovered;
    private FlowLayoutPanel flowLayoutPanel4;
    private ComboBox cboSpecies;
    private ColumnHeader columnHeader_23;
    private ColumnHeader columnHeader_24;
    private ColumnHeader columnHeader_25;
    private ColumnHeader columnHeader_26;
    private FlowLayoutPanel flowLayoutPanel5;
    private Label label3;
    private Label label4;
    private Label label5;
    private FlowLayoutPanel flowLayoutPanel6;
    private Label lblGravity;
    private Label lblOxygen;
    private Label lblTemperature;
    private FlowLayoutPanel flowLayoutPanel7;
    private Label label1;
    private Label label7;
    private Label lblBreathe;
    private Label lblPressure;
    private FlowLayoutPanel flowLayoutPanel8;
    private Label label8;
    private Label label9;
    private ColumnHeader columnHeader_27;
    private ColumnHeader columnHeader_28;
    private ColumnHeader columnHeader_29;
    private ColumnHeader columnHeader_30;
    private ColumnHeader columnHeader_31;
    private ColumnHeader columnHeader_32;
    private Label lblJSP;
    private Label label11;
    private Label lblJPSurvey;
    private Label label12;
    private Label lblSBSurvey;
    private Label label13;
    private ColumnHeader columnHeader_33;
    private ColumnHeader columnHeader_34;
    private ColumnHeader columnHeader_35;
    private ColumnHeader columnHeader_36;
    private ColumnHeader columnHeader_37;
    private ColumnHeader columnHeader_38;
    private ListView lstvMinerals;
    private ColumnHeader columnHeader_39;
    private ColumnHeader columnHeader_40;
    private ColumnHeader columnHeader_41;
    private FlowLayoutPanel flpColonyCosts;
    private FlowLayoutPanel flowLayoutPanel11;
    private Label label38;
    private Label label24;
    private Label label27;
    private Label label26;
    private Label label28;
    private Label label25;
    private Label label29;
    private Label label30;
    private FlowLayoutPanel flowLayoutPanel12;
    private Label lblColonyCost;
    private Label lblCCGravity;
    private Label lblCCTemp;
    private Label lblBreathable;
    private Label lblDangerous;
    private Label lblMaxPressure;
    private Label lblRetention;
    private Label lblWater;
    private Button cmdRenameSystem;
    private ColumnHeader columnHeader_42;
    private ListView lstvJP;
    private ColumnHeader columnHeader_43;
    private ColumnHeader columnHeader_44;
    private ColumnHeader columnHeader_45;
    private ColumnHeader columnHeader_46;
    private Button cmdRenameBody;
    private ComboBox cboRaces;
    private Button cmdAddColony;
    private Button cmdDeleteSystem;
    private FlowLayoutPanel flpSM;
    private Button cmdAllBodySurvey;
    private Button cmdBodySurvey;
    private Button cmdNoBodySurvey;
    private Button cmdHWMinerals;
    private Button cmdJPSurvey;
    private Button cmdAddJumpPoint;
    private Button cmdDeleteJP;
    private Button cmdRandomRuin;
    private FlowLayoutPanel flowLayoutPanel9;
    private CheckBox chkMinDep;
    private ColumnHeader columnHeader_47;
    private Button cmdCreateSystem;
    private Button cmdExploreJP;
    private FlowLayoutPanel flpButtonRow;
    private Button cmdEnterJP;
    private Button cmdJG;
    private FlowLayoutPanel flpDisplaySection;
    private FlowLayoutPanel flpJPs;
    private FlowLayoutPanel flpMinButtons;
    private Button cmdDeleteJG;
    private Button cmdChangeJPLocation;
    private Button cmdSpecify;
    private FlowLayoutPanel flpSpecify;
    private FlowLayoutPanel flowLayoutPanel16;
    private Label label10;
    private Label label14;
    private Label label15;
    private Label label16;
    private Label label17;
    private Label label18;
    private Label label19;
    private Label label20;
    private Label label21;
    private Label label22;
    private Label label23;
    private FlowLayoutPanel flowLayoutPanel17;
    private FlowLayoutPanel flowLayoutPanel18;
    private TextBox txtAmount1;
    private TextBox txtAmount2;
    private TextBox txtAmount3;
    private TextBox txtAmount4;
    private TextBox txtAmount5;
    private TextBox txtAmount6;
    private TextBox txtAmount7;
    private TextBox txtAmount8;
    private TextBox txtAmount9;
    private TextBox txtAmount10;
    private TextBox txtAmount11;
    private TextBox txtAcc1;
    private TextBox txtAcc2;
    private TextBox txtAcc3;
    private TextBox txtAcc4;
    private TextBox txtAcc5;
    private TextBox txtAcc6;
    private TextBox txtAcc7;
    private TextBox txtAcc8;
    private TextBox txtAcc9;
    private TextBox txtAcc10;
    private TextBox txtAcc11;
    private FlowLayoutPanel flowLayoutPanel15;
    private CheckBox chkUnsurveyed;
    private CheckBox chkTeamSurvey;
    private ListView lstvAtmosphere;
    private ColumnHeader columnHeader_48;
    private ColumnHeader columnHeader_49;
    private ColumnHeader columnHeader_50;
    private Button cmdCreateRace;
    private ColumnHeader columnHeader_51;
    private Button cmdRenameSystemAll;
    private Button cmdRenameBodyAll;
    private CheckBox chkMaxCC;
    private CheckBox chkOrbital;
    private Button cmdSwarm;
    private Button cmdMinText;
    private Button cmdNameSolBodies;
    private Button cmdPotentialColonies;
    private Label label2;
    private CheckBox chkAlien;
    private CheckBox chkAcceptableGravity;
    private CheckBox chkOxygenPresent;
    private CheckBox chkWaterPresent;
    private CheckBox chkHydroAbove20;
    private TextBox txtMaxColonyCost;
    private TextBox txtMinPopCapacity;
    private FlowLayoutPanel flowLayoutPanel22;
    private CheckBox chkExcludeGasGiants;
    private CheckBox chkBelowMaxCC;
    private CheckBox chkAboveMinPop;
    private CheckBox chkMineralsPresent;
    private FlowLayoutPanel flpAllSystemOptions;
    private FlowLayoutPanel flowLayoutPanel23;
    private FlowLayoutPanel flowLayoutPanel24;
    private ComboBox cboSort1;
    private ComboBox cboSort2;
    private Label label31;
    private ColumnHeader columnHeader_52;
    private Button cmdModifyBody;
    private Button cmdAddPlanet;
    private Button cmdAddNewStar;
    private Button cmdChangeStar;
    private Button cmdDeleteStar;
    private Button cmdDeleteSystemBody;
    private Button cmdAddMoons;
    private Button cmdAddLGP;
    private Button cmdDeleteBelt;
    private Button cmdDeleteLagrange;
    private Button cmdRemoveMinerals;
    private Button cmdNewMinerals;
    private Button cmdBanBody;
    private Button cmdSelectName;
    private ColumnHeader columnHeader_53;
    private Button cmdRedoJP;
    private Button cmdRedoAllMinerals;
    private FlowLayoutPanel flpSMButtons;
    private Button cmdNoGravSurvey;
    private ColumnHeader columnHeader_54;
    private ColumnHeader columnHeader_55;
    private ColumnHeader columnHeader_56;
    private ColumnHeader columnHeader_57;
    private ColumnHeader columnHeader_58;
    private Label label32;
    private Label lblPerihelionCC;
    private Label label33;
    private Label lblAphelionCC;
    private Button cmdWideView;
    private ColumnHeader columnHeader_59;
    private ColumnHeader columnHeader_60;
    private PictureBox pbSpecies;
    private ListView lstvColonyCosts;
    private ColumnHeader columnHeader_61;
    private ColumnHeader columnHeader_62;
    private ColumnHeader columnHeader_63;
    private ColumnHeader columnHeader_64;
    private ColumnHeader columnHeader_65;
    private ColumnHeader columnHeader_66;
    private ColumnHeader columnHeader_67;
    private ColumnHeader columnHeader_68;
    private ColumnHeader columnHeader_69;
    private ColumnHeader columnHeader_70;
    private ColumnHeader columnHeader_71;
    private ColumnHeader columnHeader_72;
    private ColumnHeader columnHeader_73;
    private Button cmdRestrictJP;
    private Button cmdCreateHabitableSystem;

    public SystemView(GClass0 gclass0_1, RacialSystemSurvey gclass202_1)
    {
        this.InitializeComponent();
        this.DoubleBuffered = true;
        this.gclass0_0 = gclass0_1;
        this.gclass202_0 = gclass202_1;
    }

    private void method_0()
    {
        if (this.gclass0_0.bool_8)
        {
            this.flpSM.Visible = true;
            this.flpJPs.Visible = true;
            this.flpMinButtons.Visible = true;
            this.cmdExploreJP.Visible = true;
            this.cmdNameSolBodies.Visible = true;
            this.cmdSwarm.Visible = true;
            this.cmdCreateRace.Visible = true;
            this.cmdJPSurvey.Visible = true;
            this.cmdAllBodySurvey.Visible = true;
            this.cmdNoBodySurvey.Visible = true;
            this.cmdDeleteSystem.Visible = true;
            this.cmdRedoJP.Visible = true;
            this.lstvSB.Height -= 30;
            this.flpDisplaySection.Top -= 30;
            this.flpButtonRow.Top -= 30;
            this.flpSMButtons.Top = this.flpButtonRow.Top + 30;
        }
        else
        {
            this.flpSM.Visible = false;
            this.flpJPs.Visible = false;
            this.flpMinButtons.Visible = false;
            this.cmdExploreJP.Visible = false;
            this.cmdNameSolBodies.Visible = false;
            this.cmdSwarm.Visible = false;
            this.cmdCreateRace.Visible = false;
            this.cmdJPSurvey.Visible = false;
            this.cmdAllBodySurvey.Visible = false;
            this.cmdNoBodySurvey.Visible = false;
            this.cmdDeleteSystem.Visible = false;
            this.cmdRedoJP.Visible = false;
        }
    }

    private void SystemView_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            this.Width = 1440;
            this.Height = 898;
            this.method_0();
            this.method_1();
            this.gclass0_0.bool_9 = true;
            this.bool_1 = true;
            this.gclass0_0.method_577(this.cboRaces);
            this.gclass0_0.bool_9 = false;
            if (this.gclass202_0 != null)
            {
                this.cboRaces.SelectedItem = this.gclass202_0.Race;
                this.gclass21_0 = this.gclass202_0.Race;
            }
            else
            {
                this.cboRaces.SelectedItem = this.gclass0_0.raceRecord_0;
                this.gclass21_0 = this.gclass0_0.raceRecord_0;
            }

            this.gclass21_0.method_260(this.cboSpecies);
            if (!this.bool_0)
                this.method_5();
            if (this.gclass0_0.bool_18)
                this.method_3();
            foreach (SystemData200 gclass200 in this.gclass0_0.SystemBodyRecordDic.Values
                         .Where<SystemBodyData>(body =>
                             body.BodyTypeId == AuroraSystemBodyType.Asteroid && body.OrbitNumber == 0)
                         .Select<SystemBodyData, SystemData200>(body => body.SystemData)
                         .Where<SystemData200>(gclass200_0 => !gclass200_0.IsSolSystem).Distinct<SystemData200>()
                         .ToList<SystemData200>())
                gclass200.method_0();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3078);
        }
    }

    public void method_1()
    {
        try
        {
            this.int_0 = 8;
            this.lstvColonyCosts.Width = 450;
            if (!this.gclass0_0.bool_8 && !this.gclass0_0.bool_18)
            {
                this.int_0 = 7;
                this.lstvColonyCosts.Width = 400;
            }
            else
            {
                if (this.gclass0_0.bool_8 || !this.gclass0_0.bool_18)
                    return;
                this.int_0 = 12;
                this.lstvColonyCosts.Width = 650;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3462);
        }
    }

    public void method_2(GameRace gclass21_1)
    {
        try
        {
            this.bool_1 = true;
            this.cboRaces.SelectedItem = gclass21_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3079);
        }
    }

    private void cboRaces_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.cboRaces.SelectedValue == null)
                return;
            this.gclass21_0 = (GameRace)this.cboRaces.SelectedValue;
            this.gclass21_0.method_260(this.cboSpecies);
            if (this.gclass21_0.RacialSystemDictionary.Keys.Contains<int>(this.gclass202_0.ActualSystemData.SystemID))
                this.gclass202_0 = this.gclass21_0.RacialSystemDictionary[this.gclass202_0.ActualSystemData.SystemID];
            this.method_5();
            if (!this.bool_1)
                this.gclass0_0.method_511(this.gclass21_0, this);
            this.bool_1 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3080);
        }
    }

    public void method_3()
    {
        try
        {
            if (this.cmdWideView.Text == "Normal View")
            {
                this.method_4(true);
                this.cmdWideView.Text = "Wide View";
                this.gclass0_0.bool_18 = false;
            }
            else
            {
                this.method_4(false);
                this.cmdWideView.Text = "Normal View";
                this.gclass0_0.bool_18 = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3457);
        }
    }

    private void method_4(bool bool_3)
    {
        try
        {
            if (bool_3)
            {
                this.Width = 1440;
                this.lstvSB.Width = 1420;
            }
            else
            {
                this.Width = 1900;
                this.lstvSB.Width = 1880;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3458);
        }
    }

    private void method_5()
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.bool_0 = false;
            this.gclass0_0.bool_9 = true;
            List<RacialSystemSurvey> gclass202List = this.gclass21_0.method_321();
            this.cboSystems.DisplayMember = "Name";
            this.cboSystems.DataSource = gclass202List;
            this.gclass0_0.bool_9 = false;
            if (this.gclass202_0 != null)
            {
                if (this.gclass21_0.RacialSystemDictionary.Keys.Contains<int>(this.gclass202_0.ActualSystemData.SystemID))
                    this.cboSystems.SelectedItem = this.gclass202_0;
                else
                    this.gclass202_0 = null;
            }

            if (this.gclass202_0 == null && gclass202List.Count > 0)
                this.cboSystems.SelectedItem = gclass202List[0];
            if (this.bool_0)
                return;
            this.method_6();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3081);
        }
    }

    private void cboSystems_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.method_6();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3082);
        }
    }

    private void method_6()
    {
        try
        {
            this.gclass202_0 = (RacialSystemSurvey)this.cboSystems.SelectedValue;
            this.lstvStars.Visible = false;
            this.gclass202_0.method_41(this.lstvStars, this.gclass21_0, this.gclass194_0, this.chkMaxCC.CheckState);
            this.gclass202_0.method_40(this.lblAge, this.lblDiscovered, this.lblJSP, this.lblJPSurvey,
                this.lblSBSurvey);
            this.lstvStars.Visible = true;
            this.lstvStars.Items[1].Selected = true;
            this.bool_0 = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3083);
        }
    }

    private void cboSpecies_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass194_0 = (GClass194)this.cboSpecies.SelectedValue;
            this.gclass194_0.method_0(this.lblGravity, this.lblOxygen, this.lblTemperature, this.lblBreathe,
                this.lblPressure);
            this.pbSpecies.Image = Image.FromFile($"{Application.StartupPath}\\Races\\{this.gclass194_0.string_0}");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3084);
        }
    }

    private void lstvSB_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.lstvMinerals.Items.Clear();
            this.lstvAtmosphere.Items.Clear();
            if (this.gclass202_0 == null || this.gclass197_0 == null || this.lstvSB.SelectedItems.Count <= 0 ||
                this.lstvSB.SelectedItems[0].Index < 0)
                return;
            this.gclass1_0 = (SystemBodyData)this.lstvSB.SelectedItems[0].Tag;
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3085);
        }
    }

    private void method_7()
    {
        try
        {
            this.gclass1_0.method_68(this.lstvMinerals, this.gclass21_0);
            this.gclass1_0.method_71(this.gclass21_0, this.gclass194_0, this.chkMaxCC.CheckState, this.lblRetention,
                this.lblCCGravity, this.lblCCTemp, this.lblBreathable, this.lblMaxPressure, this.lblDangerous,
                this.lblWater, this.lblColonyCost, this.lblPerihelionCC, this.lblAphelionCC, 2);
            this.gclass1_0.method_70(this.lstvAtmosphere, null, false);
            this.gclass1_0.method_0(this.lstvColonyCosts, this.gclass21_0, this.gclass194_0, this.int_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3086);
        }
    }

    private void cmdRenameSystem_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null)
                return;
            this.gclass0_0.string_3 = "Enter New System Name";
            this.gclass0_0.string_4 = this.gclass202_0.Name;
            int num = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.string_4 != this.gclass202_0.Name && !this.gclass0_0.bool_21)
            {
                this.gclass202_0.Name = this.gclass0_0.string_4;
                this.method_5();
            }

            foreach (TacticalMap tacticalMap in Application.OpenForms.OfType<TacticalMap>())
                tacticalMap.method_6();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3087);
        }
    }

    private void cmdRenameBody_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass1_0 == null)
                return;
            string str = this.gclass1_0.method_78(this.gclass21_0);
            this.gclass0_0.string_3 = "Enter New System Body Name";
            this.gclass0_0.string_4 = str;
            int num = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            if (!(this.gclass0_0.string_4 != str) || this.gclass0_0.bool_21)
                return;
            this.gclass1_0.method_80(this.gclass21_0, this.gclass0_0.string_4);
            this.lstvSB.SelectedItems[0].SubItems[0].Text = this.gclass0_0.string_4;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3088);
        }
    }

    private void cmdAddColony_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.gclass1_0 == null ||
                this.gclass1_0.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                this.gclass1_0.BodyTypeId == AuroraSystemBodyType.Superjovian)
                return;
            this.gclass21_0.method_275(this.gclass1_0, this.gclass194_0);
            this.method_12();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3089);
        }
    }

    private void cmdDeleteSystem_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null ||
                MessageBox.Show($" Are you sure you want to delete the system {this.gclass202_0.Name}?",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes || MessageBox.Show(
                    " Are you really sure? This will delete all populations and military forces in the system",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            this.gclass0_0.method_545(this.gclass202_0.ActualSystemData, false);
            this.gclass202_0 = null;
            this.method_5();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3090);
        }
    }

    private void cmdAllBodySurvey_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null)
                return;
            this.gclass202_0.Race.method_258(this.gclass202_0.ActualSystemData, false);
            this.gclass202_0.method_40(this.lblAge, this.lblDiscovered, this.lblJSP, this.lblJPSurvey,
                this.lblSBSurvey);
            this.method_12();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3091);
        }
    }

    private void cmdBodySurvey_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass1_0 == null || this.gclass21_0 == null)
                return;
            this.gclass1_0.method_37(this.gclass21_0);
            this.gclass202_0.method_40(this.lblAge, this.lblDiscovered, this.lblJSP, this.lblJPSurvey,
                this.lblSBSurvey);
            this.method_12();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3092);
        }
    }

    private void cmdNoBodySurvey_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null)
                return;
            this.gclass202_0.Race.method_259(this.gclass202_0.ActualSystemData);
            this.gclass0_0.bool_22 = true;
            this.gclass202_0.method_40(this.lblAge, this.lblDiscovered, this.lblJSP, this.lblJPSurvey,
                this.lblSBSurvey);
            this.method_12();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3093);
        }
    }

    private void method_8(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null)
                return;
            this.gclass202_0.ActualSystemData.method_13();
            this.method_12();
            if (this.gclass1_0 == null)
                return;
            this.gclass1_0.method_68(this.lstvMinerals, this.gclass21_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3094);
        }
    }

    private void cmdHWMinerals_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.gclass1_0 == null ||
                this.gclass1_0.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                this.gclass1_0.BodyTypeId == AuroraSystemBodyType.Superjovian)
                return;
            this.gclass0_0.method_673(this.gclass21_0, this.gclass1_0, 1M);
            this.gclass1_0.method_68(this.lstvMinerals, this.gclass21_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3095);
        }
    }

    private void cmdJPSurvey_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null)
                return;
            this.gclass202_0.method_44();
            this.gclass202_0.method_39(this.lstvJP);
            this.gclass202_0.method_40(this.lblAge, this.lblDiscovered, this.lblJSP, this.lblJPSurvey,
                this.lblSBSurvey);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3096);
        }
    }

    private void cmdAddJumpPoint_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null)
                return;
            this.gclass202_0.ActualSystemData.method_14(false);
            this.gclass202_0.method_39(this.lstvJP);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3097);
        }
    }

    private void lstvJP_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.lstvJP.SelectedItems.Count <= 0 ||
                this.lstvJP.SelectedItems[0].Tag == null)
                return;
            this.gclass120_0 = (JumpPoint120)this.lstvJP.SelectedItems[0].Tag;
            if (this.gclass120_0.method_0(this.gclass202_0.Race))
            {
                this.cmdExploreJP.Visible = false;
                this.cmdEnterJP.Visible = true;
            }
            else
            {
                this.cmdExploreJP.Visible = true;
                this.cmdEnterJP.Visible = false;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3098);
        }
    }

    private void cmdDeleteJP_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass120_0 == null || MessageBox.Show(" Are you sure you want to delete the selected jump point?",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            this.gclass202_0.ActualSystemData.method_15(this.gclass120_0);
            this.gclass202_0.method_39(this.lstvJP);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3099);
        }
    }

    private void method_9(object sender, EventArgs e)
    {
    }

    private void cmdRandomRuin_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass1_0 == null || this.gclass1_0.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                this.gclass1_0.BodyTypeId == AuroraSystemBodyType.Superjovian)
                return;
            if (this.gclass1_0.RuinData != null)
            {
                int num = (int)MessageBox.Show("A ruin is already in place on this body and will be deleted");
                this.gclass1_0.RuinData = null;
                this.gclass1_0.RuinID = 0;
                this.gclass1_0.AbandonedFactories = 0;
                if (this.gclass1_0.UnknownEnumDBUpdateNeedState == Unknown_SystemBodyDataUpdateLevel.BasicUpdate)
                    this.gclass1_0.UnknownEnumDBUpdateNeedState = Unknown_SystemBodyDataUpdateLevel.ExtendedUpdate;
                this.gclass1_0.RuinRaceID = 0;
                this.gclass1_0.RuinRaceData = null;
                if (this.gclass1_0.gclass220_0 != null)
                {
                    this.gclass0_0.dictionary_27.Remove(this.gclass1_0.gclass220_0.int_0);
                    this.gclass1_0.gclass220_0 = null;
                }
            }
            else
            {
                this.gclass0_0.string_3 = "Select Ruin Type";
                this.gclass0_0.string_7 = "";
                this.gclass0_0.string_8 = "";
                this.gclass0_0.string_9 = "";
                this.gclass0_0.list_32 = new List<string>();
                this.gclass0_0.list_32.Add("Random Ruin");
                foreach (RuinDefinition gclass174 in this.gclass0_0.RuinDefinitionDictionary.Values)
                    this.gclass0_0.list_32.Add(gclass174.Description);
                int num = (int)new UserSelection(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                if (this.gclass0_0.string_4 == "Random Ruin")
                    this.gclass0_0.method_676(this.gclass1_0, null, true);
                else
                    this.gclass0_0.method_676(this.gclass1_0,
                        this.gclass0_0.RuinDefinitionDictionary.Values.FirstOrDefault<RuinDefinition>(gclass174_0 =>
                            gclass174_0.Description == this.gclass0_0.string_4), true);
            }

            this.method_12();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3100);
        }
    }

    private void cmdExploreJP_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass120_0 == null)
                return;
            this.gclass202_0 = this.gclass0_0.method_638(this.gclass120_0, this.gclass202_0, null, false, false);
            this.method_5();
            foreach (GalacticMap galacticMap in Application.OpenForms.OfType<GalacticMap>())
                galacticMap.method_2(true);
            foreach (TacticalMap tacticalMap in Application.OpenForms.OfType<TacticalMap>())
                tacticalMap.method_5();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3101);
        }
    }

    private void cmdEnterJP_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass120_0 == null || this.gclass21_0 == null ||
                !this.gclass21_0.RacialSystemDictionary.ContainsKey(this.gclass120_0.LinkedJumpPoint.SystemData.SystemID))
                return;
            this.cboSystems.SelectedItem =
                this.gclass21_0.RacialSystemDictionary[this.gclass120_0.LinkedJumpPoint.SystemData.SystemID];
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3102);
        }
    }

    private void cmdCreateSystem_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            this.gclass0_0.gclass198_0 = null;
            this.gclass0_0.bool_3 = false;
            if (this.gclass0_0.UseKnownStars == 1)
            {
                this.gclass0_0.bool_21 = false;
                int num = (int)new SelectKnownSystem(this.gclass0_0, true).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
            }

            this.gclass202_0 = this.gclass0_0.method_637(this.gclass21_0, this.gclass0_0.bool_3, 1M, false);
            this.method_5();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3103);
        }
    }

    private void cmdJG_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass120_0 == null)
                return;
            this.gclass120_0.JumpGateStrength = 1000;
            this.gclass202_0.method_39(this.lstvJP);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3104);
        }
    }

    private void cmdDeleteJG_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass120_0 == null)
                return;
            this.gclass120_0.JumpGateStrength = 0;
            this.gclass202_0.method_39(this.lstvJP);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3105);
        }
    }

    private void cmdChangeJPLocation_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass120_0 == null)
                return;
            string str1 = AuroraUtils.smethod_43(this.gclass120_0.Distance * AuroraUtils.double_14 / 1000000.0);
            string str2 = AuroraUtils.smethod_37(this.gclass120_0.Bearing);
            this.gclass0_0.string_4 = str1;
            this.gclass0_0.string_5 = str2;
            int num1 = (int)new ChangeLocation(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.string_4 != str1)
                this.gclass120_0.Distance = Convert.ToDouble(this.gclass0_0.string_4) / 150.0;
            if (this.gclass0_0.string_5 != str2)
                this.gclass120_0.Bearing = Convert.ToInt32(this.gclass0_0.string_5);
            double num2 = 40.0 * this.gclass202_0.ActualSystemData.method_12();
            if (this.gclass120_0.Distance > num2)
                this.gclass120_0.Distance = num2;
            GClass221 gclass221 = this.gclass0_0.method_592(0.0, 0.0, this.gclass120_0.Distance * AuroraUtils.double_14,
                this.gclass120_0.Bearing);
            this.gclass120_0.XCoord = gclass221.double_0;
            this.gclass120_0.YCoord = gclass221.double_1;
            this.gclass202_0.method_39(this.lstvJP);
            foreach (TacticalMap tacticalMap in Application.OpenForms.OfType<TacticalMap>())
                tacticalMap.method_10();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3106);
        }
    }

    private void cmdSpecify_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass1_0 == null)
                return;
            if (this.lstvMinerals.Visible)
            {
                if (this.gclass0_0.bool_8)
                    this.flpSpecify.Top = 580;
                else
                    this.flpSpecify.Top = 610;
                this.lstvMinerals.Visible = false;
                this.flpSpecify.Visible = true;
                this.cmdSpecify.Text = "Save Minerals";
                this.gclass1_0.method_24(AuroraElement.Duranium, this.txtAmount1, this.txtAcc1);
                this.gclass1_0.method_24(AuroraElement.Neutronium, this.txtAmount2, this.txtAcc2);
                this.gclass1_0.method_24(AuroraElement.Corbomite, this.txtAmount3, this.txtAcc3);
                this.gclass1_0.method_24(AuroraElement.Tritanium, this.txtAmount4, this.txtAcc4);
                this.gclass1_0.method_24(AuroraElement.Boronide, this.txtAmount5, this.txtAcc5);
                this.gclass1_0.method_24(AuroraElement.Mercassium, this.txtAmount6, this.txtAcc6);
                this.gclass1_0.method_24(AuroraElement.Vendarite, this.txtAmount7, this.txtAcc7);
                this.gclass1_0.method_24(AuroraElement.Sorium, this.txtAmount8, this.txtAcc8);
                this.gclass1_0.method_24(AuroraElement.Uridium, this.txtAmount9, this.txtAcc9);
                this.gclass1_0.method_24(AuroraElement.Corundium, this.txtAmount10, this.txtAcc10);
                this.gclass1_0.method_24(AuroraElement.Gallicite, this.txtAmount11, this.txtAcc11);
            }
            else
            {
                this.lstvMinerals.Visible = true;
                this.flpSpecify.Visible = false;
                this.cmdSpecify.Text = "Specify Minerals";
                this.gclass1_0.method_25(AuroraElement.Duranium, this.txtAmount1, this.txtAcc1);
                this.gclass1_0.method_25(AuroraElement.Neutronium, this.txtAmount2, this.txtAcc2);
                this.gclass1_0.method_25(AuroraElement.Corbomite, this.txtAmount3, this.txtAcc3);
                this.gclass1_0.method_25(AuroraElement.Tritanium, this.txtAmount4, this.txtAcc4);
                this.gclass1_0.method_25(AuroraElement.Boronide, this.txtAmount5, this.txtAcc5);
                this.gclass1_0.method_25(AuroraElement.Mercassium, this.txtAmount6, this.txtAcc6);
                this.gclass1_0.method_25(AuroraElement.Vendarite, this.txtAmount7, this.txtAcc7);
                this.gclass1_0.method_25(AuroraElement.Sorium, this.txtAmount8, this.txtAcc8);
                this.gclass1_0.method_25(AuroraElement.Uridium, this.txtAmount9, this.txtAcc9);
                this.gclass1_0.method_25(AuroraElement.Corundium, this.txtAmount10, this.txtAcc10);
                this.gclass1_0.method_25(AuroraElement.Gallicite, this.txtAmount11, this.txtAcc11);
                this.gclass1_0.method_68(this.lstvMinerals, this.gclass21_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3107);
        }
    }

    private void cmdCreateRace_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass1_0 == null || !this.gclass1_0.method_23(false))
                return;
            Dictionary<AuroraElement, GClass124> dictionary0 = this.gclass1_0.dictionary_0;
            GameRace gclass21 = this.gclass0_0.method_536(this.gclass1_0, 0, GEnum82.const_0, true, false,
                false, false, SpecialNPRIDs.const_0, 0, true, null, 0);
            if (gclass21 == null)
            {
                this.gclass1_0.dictionary_0 = dictionary0;
            }
            else
            {
                this.gclass0_0.bool_9 = true;
                this.gclass0_0.method_577(this.cboRaces);
                this.gclass0_0.bool_9 = false;
                this.cboRaces.SelectedItem = gclass21;
                this.gclass21_0 = gclass21;
                this.gclass21_0.method_260(this.cboSpecies);
                foreach (TacticalMap tacticalMap in Application.OpenForms.OfType<TacticalMap>())
                    tacticalMap.method_1();
                if (this.bool_0)
                    return;
                this.method_5();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3108);
        }
    }

    private void lstvSB_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
    {
        try
        {
            Brush brush1 = new SolidBrush(AuroraUtils.color_19);
            Brush brush2 = new SolidBrush(AuroraUtils.color_16);
            e.Graphics.FillRectangle(brush1, e.Bounds);
            e.Graphics.DrawString(e.Header.Text, e.Font, brush2, e.Bounds);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3109);
        }
    }

    private void lstvSB_DrawItem(object sender, DrawListViewItemEventArgs e)
    {
        try
        {
            e.DrawDefault = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3110);
        }
    }

    private void lstvSB_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
    {
        try
        {
            e.DrawDefault = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3111);
        }
    }

    private void cmdRenameSystemAll_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null)
                return;
            this.gclass0_0.string_3 = "Enter New System Name";
            this.gclass0_0.string_4 = this.gclass202_0.Name;
            int num = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            if (!(this.gclass0_0.string_4 != this.gclass202_0.Name) || this.gclass0_0.bool_21)
                return;
            foreach (RacialSystemSurvey gclass202 in this.gclass0_0.FCTRaceRecordDic.Values
                         .SelectMany<GameRace, RacialSystemSurvey>(gclass21_0 => gclass21_0.RacialSystemDictionary.Values)
                         .Where<RacialSystemSurvey>(gclass202_1 => gclass202_1.ActualSystemData == this.gclass202_0.ActualSystemData)
                         .ToList<RacialSystemSurvey>())
                gclass202.Name = this.gclass0_0.string_4;
            this.method_5();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3112);
        }
    }

    private void cmdRenameBodyAll_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass1_0 == null)
                return;
            string str = this.gclass1_0.method_78(this.gclass21_0);
            this.gclass0_0.string_3 = "Enter New System Body Name";
            this.gclass0_0.string_4 = str;
            int num = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            if (!(this.gclass0_0.string_4 != str) || this.gclass0_0.bool_21)
                return;
            foreach (GameRace gclass21_0 in this.gclass0_0.FCTRaceRecordDic.Values
                         .SelectMany<GameRace, RacialSystemSurvey>(gclass21_0 => gclass21_0.RacialSystemDictionary.Values)
                         .Where<RacialSystemSurvey>(gclass202_1 => gclass202_1.ActualSystemData == this.gclass202_0.ActualSystemData)
                         .Select<RacialSystemSurvey, GameRace>(gclass202_0 => gclass202_0.Race)
                         .ToList<GameRace>())
                this.gclass1_0.method_80(gclass21_0, this.gclass0_0.string_4);
            this.lstvSB.SelectedItems[0].SubItems[0].Text = this.gclass0_0.string_4;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3113);
        }
    }

    private void cmdSwarm_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null)
                return;
            SystemBodyData gclass1_1_1 =
                this.gclass0_0.SystemBodyRecordDic.Values
                    .Where<SystemBodyData>(gclass1_1 => gclass1_1.SystemData == this.gclass202_0.ActualSystemData)
                    .Where<SystemBodyData>(gclass1_0 => gclass1_0.method_17() > 4.0)
                    .Where<SystemBodyData>(gclass1_0 => gclass1_0.method_16(50, false))
                    .OrderByDescending<SystemBodyData, double>(gclass1_0 => gclass1_0.method_17())
                    .FirstOrDefault<SystemBodyData>() ?? this.gclass0_0.SystemBodyRecordDic.Values
                    .Where<SystemBodyData>(gclass1_1 => gclass1_1.SystemData == this.gclass202_0.ActualSystemData)
                    .OrderBy<SystemBodyData, int>(gclass1_0 => gclass1_0.PlanetNumber)
                    .FirstOrDefault<SystemBodyData>();
            if (gclass1_1_1 == null)
            {
                int num = (int)MessageBox.Show("Cannot create swarm in a system with no appropriate system bodies");
            }
            else
                this.gclass0_0.method_59(gclass1_1_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3114);
        }
    }

    private void cmdMinText_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass1_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a system body");
            }
            else if (this.gclass21_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                int num3 = (int)new MineralPopUp(this.gclass1_0, this.gclass21_0, this.gclass0_0).ShowDialog();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3115);
        }
    }

    private void cmdNameSolBodies_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                foreach (SystemBodyData gclass1 in this.gclass0_0.SystemBodyRecordDic.Values
                             .Where<SystemBodyData>(gclass1_0 => gclass1_0.SystemData.IsSolSystem)
                             .ToList<SystemBodyData>())
                {
                    if (!gclass1.dictionary_1.ContainsKey(this.gclass21_0.RaceID))
                        gclass1.dictionary_1.Add(this.gclass21_0.RaceID, new GClass218()
                        {
                            gclass21_0 = this.gclass21_0,
                            string_0 = gclass1.Name,
                            int_0 = gclass1.SystemBodyID
                        });
                }

                this.method_6();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3116);
        }
    }

    private void cmdPotentialColonies_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.cmdPotentialColonies.Text == "All System View")
            {
                this.flpAllSystemOptions.Visible = true;
                this.lstvStars.Visible = false;
                this.lstvJP.Visible = false;
                this.flpJPs.Visible = false;
                this.cboSystems.Visible = false;
                this.lblAge.Visible = false;
                this.lblDiscovered.Visible = false;
                this.lblJSP.Visible = false;
                this.lblJPSurvey.Visible = false;
                this.lblSBSurvey.Visible = false;
                this.label2.Visible = false;
                this.label6.Visible = false;
                this.label11.Visible = false;
                this.label12.Visible = false;
                this.label13.Visible = false;
                this.flpSM.Visible = false;
                this.cmdPotentialColonies.Text = "Normal View";
                this.bool_2 = true;
            }
            else
            {
                this.flpAllSystemOptions.Visible = false;
                this.lstvStars.Visible = true;
                this.lstvJP.Visible = true;
                this.cboSystems.Visible = true;
                this.lblAge.Visible = true;
                this.lblDiscovered.Visible = true;
                this.lblJSP.Visible = true;
                this.lblJPSurvey.Visible = true;
                this.lblSBSurvey.Visible = true;
                this.label2.Visible = true;
                this.label6.Visible = true;
                this.label11.Visible = true;
                this.label12.Visible = true;
                this.label13.Visible = true;
                if (this.gclass0_0.bool_8)
                {
                    this.flpJPs.Visible = true;
                    this.flpSM.Visible = true;
                }

                this.cmdPotentialColonies.Text = "All System View";
                this.bool_2 = false;
            }

            this.gclass1_0 = null;
            this.method_12();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3117);
        }
    }

    private void chkMineralsPresent_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass1_0 = null;
            this.method_12();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3118);
        }
    }

    private void txtMaxColonyCost_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.txtMaxColonyCost.Text == "")
                return;
            this.gclass1_0 = null;
            this.method_12();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3119);
        }
    }

    private void txtMinPopCapacity_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.txtMinPopCapacity.Text == "")
                return;
            this.gclass1_0 = null;
            this.method_12();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3120);
        }
    }

    private void cboSort2_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass1_0 = null;
            this.method_12();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3121);
        }
    }

    private void cmdChangeStar_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.gclass197_0 == null)
                return;
            int num = (int)new StarSetup(this.gclass0_0, this.gclass197_0, this.gclass202_0.ActualSystemData).ShowDialog();
            if (this.gclass0_0.bool_21)
                return;
            this.method_6();
            this.gclass0_0.tacticalMap_0.method_10();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3122);
        }
    }

    private void cmdAddNewStar_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null)
                return;
            int num = (int)new StarSetup(this.gclass0_0, null, this.gclass202_0.ActualSystemData).ShowDialog();
            if (this.gclass0_0.bool_21)
                return;
            this.method_6();
            this.gclass0_0.tacticalMap_0.method_10();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3123);
        }
    }

    private void cmdModifyBody_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.gclass197_0 == null || this.gclass1_0 == null)
                return;
            int num = (int)new SystemBodySetup(this.gclass0_0, this.gclass1_0, this.gclass194_0, this.gclass21_0)
                .ShowDialog();
            this.gclass197_0.method_4();
            this.method_12();
            this.gclass0_0.tacticalMap_0.method_10();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3124);
        }
    }

    private void cmdAddPlanet_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.gclass197_0 == null)
                return;
            int num = (int)new AddPlanet(this.gclass0_0, this.gclass197_0).ShowDialog();
            if (this.gclass0_0.bool_21)
                return;
            this.gclass197_0.method_4();
            this.method_12();
            this.gclass0_0.tacticalMap_0.method_10();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3125);
        }
    }

    private void cmdDeleteStar_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.gclass197_0 == null)
                return;
            if (this.gclass197_0.Component == 1)
            {
                int num = (int)MessageBox.Show("The primary star cannot be deleted", "Deletion Not Possible");
            }
            else
            {
                if (MessageBox.Show($" Are you sure you want to delete {this.gclass197_0.method_18(this.gclass21_0)}?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes ||
                    MessageBox.Show(
                        " Are you really sure? This will delete all populations on bodies orbiting the star",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.gclass0_0.method_546(this.gclass197_0);
                this.gclass202_0.method_41(this.lstvStars, this.gclass21_0, this.gclass194_0, this.chkMaxCC.CheckState);
                this.lstvStars.Items[1].Selected = true;
                this.gclass0_0.tacticalMap_0.method_10();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3126);
        }
    }

    private void cmdDeleteSystemBody_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.gclass1_0 == null ||
                MessageBox.Show($" Are you sure you want to delete {this.gclass1_0.method_78(this.gclass21_0)}?",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes || MessageBox.Show(
                    " Are you really sure? This will delete all populations on the system body or on any orbiting moons",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            this.gclass0_0.method_547(this.gclass1_0);
            this.gclass197_0.method_4();
            this.method_12();
            this.gclass0_0.tacticalMap_0.method_10();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3127);
        }
    }

    private void cmdAddMoons_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.gclass197_0 == null || this.gclass1_0 == null)
                return;
            if (this.gclass1_0.BodyClass != PlanetBodyClass.Planet)
            {
                int num1 = (int)MessageBox.Show("Moons can only be added to planets");
            }
            else
            {
                int num2 = (int)new AddMoons(this.gclass0_0, this.gclass1_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                this.gclass197_0.method_4();
                this.method_12();
                this.gclass0_0.tacticalMap_0.method_10();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3128);
        }
    }

    private void cmdAddLGP_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.gclass197_0 == null || this.gclass1_0 == null ||
                this.gclass0_0.dictionary_14.Values.FirstOrDefault<GClass212>(gclass212_0 =>
                    gclass212_0.gclass1_0 == this.gclass1_0) != null)
                return;
            this.gclass0_0.ModifyForJupiter(this.gclass1_0, false);
            if (this.gclass0_0.bool_21)
                return;
            this.method_12();
            this.gclass0_0.tacticalMap_0.method_10();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3129);
        }
    }

    private void cmdDeleteBelt_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.gclass1_0 == null)
                return;
            if (this.gclass1_0.BodyClass != PlanetBodyClass.Asteroid)
            {
                int num = (int)MessageBox.Show("Please select an asteroid");
            }
            else
            {
                if (this.gclass1_0.PlanetNumber == 100)
                {
                    if (MessageBox.Show(
                            $" Are you sure you want to delete {this.gclass1_0.method_78(this.gclass21_0)} and all asteroids in the same belt?",
                            "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes ||
                        MessageBox.Show(" Are you really sure? This will delete all populations in the asteroid belt",
                            "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                    foreach (SystemBodyData gclass1_1 in this.gclass0_0.SystemBodyRecordDic.Values
                                 .Where<SystemBodyData>(gclass1_1 =>
                                     gclass1_1.StarData == this.gclass1_0.StarData &&
                                     gclass1_1.PlanetNumber == 100 && gclass1_1.AsteroidBeltID == this.gclass1_0.AsteroidBeltID)
                                 .ToList<SystemBodyData>())
                        this.gclass0_0.method_547(gclass1_1);
                }
                else if (this.gclass1_0.PlanetNumber == 101)
                {
                    if (MessageBox.Show(
                            $" Are you sure you want to delete {this.gclass1_0.method_78(this.gclass21_0)} and all other trojan asteroids for the same planet?",
                            "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes ||
                        MessageBox.Show(
                            " Are you really sure? This will delete all populations on the trojan asteroids",
                            "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                    foreach (SystemBodyData gclass1_1 in this.gclass0_0.SystemBodyRecordDic.Values
                                 .Where<SystemBodyData>(gclass1_1 =>
                                     gclass1_1.StarData == this.gclass1_0.StarData &&
                                     gclass1_1.PlanetNumber == 101 && gclass1_1.ParentBodyData == this.gclass1_0.ParentBodyData)
                                 .ToList<SystemBodyData>())
                        this.gclass0_0.method_547(gclass1_1);
                }

                this.method_12();
                this.gclass0_0.tacticalMap_0.method_10();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3130);
        }
    }

    private void cmdDeleteLagrange_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.gclass1_0 == null)
                return;
            var cgc212 =
                this.gclass0_0.dictionary_14.Values.FirstOrDefault<GClass212>(gclass212_0 =>
                    gclass212_0.gclass1_0 == this.gclass1_0);
            if (cgc212 == null)
            {
                int num = (int)MessageBox.Show("This system body does not have a Lagrange Point");
            }
            else
            {
                if (MessageBox.Show(
                        $" Are you sure you want to delete the Lagrange Point for {this.gclass1_0.method_78(this.gclass21_0)}?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                foreach (FleetData gclass85 in this.gclass0_0.FleetDictionary.Values
                             .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                             .Where<MoveOrder>(gc139 =>
                                 gc139.DestinationType == DestinationType.const_8 && gc139.DestinationID == cgc212.int_0)
                             .Select<MoveOrder, FleetData>(gclass139_0 => gclass139_0.Fleet).ToList<FleetData>())
                {
                    if (gclass85.CivilianFunction == CivilanFunctionType.const_1 || gclass85.CivilianFunction == CivilanFunctionType.const_2)
                        gclass85.method_44();
                    gclass85.method_263();
                }

                this.gclass0_0.dictionary_14.Remove(cgc212.int_0);
                this.gclass202_0.ActualSystemData.method_28();
                this.method_12();
                this.gclass0_0.tacticalMap_0.method_10();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3131);
        }
    }

    private void cmdRemoveMinerals_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.gclass1_0 == null)
                return;
            this.gclass1_0.dictionary_0.Clear();
            this.gclass1_0.GroundMineralSurveyState = AuroraGroundMineralSurvey.Completed;
            this.gclass1_0.method_68(this.lstvMinerals, this.gclass21_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3132);
        }
    }

    private void cmdNewMinerals_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.gclass1_0 == null || this.gclass21_0 == null || MessageBox.Show(
                    $" Are you sure you want to remove and regenerate the minerals on {this.gclass1_0.method_78(this.gclass21_0)}?",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            if (this.gclass1_0.BodyTypeId != AuroraSystemBodyType.GasGiant &&
                this.gclass1_0.BodyTypeId != AuroraSystemBodyType.Superjovian)
            {
                if (this.gclass1_0.BodyTypeId == AuroraSystemBodyType.Comet)
                    this.gclass0_0.method_670(this.gclass1_0);
                else
                    this.gclass0_0.method_672(this.gclass1_0, null);
            }
            else
            {
                this.gclass1_0.dictionary_0 = new Dictionary<AuroraElement, GClass124>();
                this.gclass0_0.method_669(this.gclass1_0, false);
            }

            this.gclass1_0.method_68(this.lstvMinerals, this.gclass21_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3133);
        }
    }

    private void cmdBanBody_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.gclass1_0 == null || this.gclass21_0 == null ||
                this.lstvSB.SelectedItems.Count == 0)
                return;
            if (this.gclass1_0.BodyClass == PlanetBodyClass.Planet)
            {
                List<SystemBodyData> list = this.gclass0_0.SystemBodyRecordDic.Values
                    .Where<SystemBodyData>(gclass1_1 =>
                        gclass1_1.ParentBodyData == this.gclass1_0 && gclass1_1.BodyClass == PlanetBodyClass.Moon)
                    .ToList<SystemBodyData>();
                if (list.Count == 0)
                    this.method_10();
                else if (!this.gclass21_0.BannedSystemBodies.Contains(this.gclass1_0))
                {
                    DialogResult dialogResult = MessageBox.Show("Do you wish to also ban all moons of this body?",
                        "Ban Moons?", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Cancel)
                        return;
                    this.method_10();
                    if (dialogResult == DialogResult.No)
                        return;
                    foreach (SystemBodyData gclass1 in list)
                    {
                        if (!this.gclass21_0.BannedSystemBodies.Contains(gclass1))
                            this.gclass21_0.BannedSystemBodies.Add(gclass1);
                    }

                    this.method_12();
                }
                else
                {
                    DialogResult dialogResult =
                        MessageBox.Show("Do you wish to also remove the ban from all moons of this body?", "Ban Moons?",
                            MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Cancel)
                        return;
                    this.method_10();
                    if (dialogResult == DialogResult.No)
                        return;
                    foreach (SystemBodyData gclass1 in list)
                    {
                        if (this.gclass21_0.BannedSystemBodies.Contains(gclass1))
                            this.gclass21_0.BannedSystemBodies.Remove(gclass1);
                    }

                    this.method_12();
                }
            }
            else
                this.method_10();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3134);
        }
    }

    private void method_10()
    {
        try
        {
            if (this.gclass21_0.BannedSystemBodies.Contains(this.gclass1_0))
                this.gclass21_0.BannedSystemBodies.Remove(this.gclass1_0);
            else
                this.gclass21_0.BannedSystemBodies.Add(this.gclass1_0);
            string str = this.gclass1_0.method_78(this.gclass21_0);
            if (this.gclass21_0.BannedSystemBodies.Contains(this.gclass1_0))
                str += " (B)";
            this.lstvSB.SelectedItems[0].SubItems[0].Text = str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3135);
        }
    }

    private void SystemView_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3136);
        }
    }

    private void method_11(object sender, EventArgs e) => this.gclass0_0.method_651(this.gclass1_0);

    private void cmdSelectName_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null)
                return;
            int num = (int)new cmdSelect(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.bool_21 || this.gclass0_0.string_4 == "")
                return;
            if (this.gclass0_0.string_4 != this.gclass202_0.Name)
            {
                this.gclass202_0.Name = this.gclass0_0.string_4;
                this.method_5();
            }

            foreach (TacticalMap tacticalMap in Application.OpenForms.OfType<TacticalMap>())
                tacticalMap.method_6();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3214);
        }
    }

    private void SystemView_KeyDown(object sender, KeyEventArgs e)
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
            AuroraUtils.ShowExceptionPopup(ex, 3285);
        }
    }

    private void cmdRedoJP_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.gclass1_0 == null || this.gclass21_0 == null || MessageBox.Show(
                    $" Are you sure you want to remove and regenerate the jump points in {this.gclass202_0.Name}?",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            foreach (JumpPoint120 gclass120_1 in this.gclass0_0.JumpPointDictionary.Values
                         .Where<JumpPoint120>(gclass120_1 => gclass120_1.SystemData == this.gclass202_0.ActualSystemData)
                         .ToList<JumpPoint120>())
                this.gclass202_0.ActualSystemData.method_15(gclass120_1);
            this.gclass0_0.string_3 = "Min Jump Points";
            this.gclass0_0.string_4 = "0";
            int num = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            int int_136 = (int)Math.Floor(AuroraUtils.ParseDecimalOrDefault(this.gclass0_0.string_4, 0M));
            if (int_136 < 0)
                int_136 = 0;
            this.gclass0_0.method_690(this.gclass202_0.ActualSystemData, int_136, false,
                this.gclass202_0.ActualSystemData.IsSolSystem);
            this.gclass202_0.method_39(this.lstvJP);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3428);
        }
    }

    private void cmdRedoAllMinerals_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.gclass21_0 == null || MessageBox.Show(
                    $"Are you sure you want to remove and regenerate the minerals on all system bodies in {this.gclass202_0.Name}, except for those with existing colonies?",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            List<SystemBodyData> list1 = this.gclass0_0.PopulationDataDictionary.Values
                .Where<PopulationData>(gclass146_0 => gclass146_0.gclass202_0.ActualSystemData == this.gclass202_0.ActualSystemData)
                .Select<PopulationData, SystemBodyData>(gclass146_0 => gclass146_0.SystemBodyData)
                .ToList<SystemBodyData>();
            List<SystemBodyData> list2 = this.gclass0_0.SystemBodyRecordDic.Values
                .Where<SystemBodyData>(gclass1_1 => gclass1_1.SystemData == this.gclass202_0.ActualSystemData)
                .Except<SystemBodyData>(list1).ToList<SystemBodyData>();
            foreach (SystemBodyData gclass1_1 in list2)
            {
                gclass1_1.dictionary_0.Clear();
                gclass1_1.GroundMineralSurveyState = AuroraGroundMineralSurvey.Completed;
                if (this.gclass1_0.RuinData != null)
                {
                    this.gclass1_0.RuinData = null;
                    this.gclass1_0.RuinID = 0;
                    this.gclass1_0.AbandonedFactories = 0;
                    this.gclass1_0.RuinRaceID = 0;
                    this.gclass1_0.RuinRaceData = null;
                    if (this.gclass1_0.gclass220_0 != null)
                    {
                        this.gclass0_0.dictionary_27.Remove(this.gclass1_0.gclass220_0.int_0);
                        this.gclass1_0.gclass220_0 = null;
                    }
                }

                if (gclass1_1.BodyTypeId != AuroraSystemBodyType.GasGiant &&
                    gclass1_1.BodyTypeId != AuroraSystemBodyType.Superjovian)
                {
                    if (gclass1_1.BodyTypeId == AuroraSystemBodyType.Comet)
                        this.gclass0_0.method_670(gclass1_1);
                    else
                        this.gclass0_0.method_672(gclass1_1, null);
                }
                else
                    this.gclass0_0.method_669(gclass1_1, false);
            }

            if (this.gclass202_0.ActualSystemData.IsSolSystem)
            {
                foreach (SystemBodyData gclass1_1 in list2)
                    this.gclass0_0.method_648(gclass1_1);
            }

            this.gclass202_0.method_40(this.lblAge, this.lblDiscovered, this.lblJSP, this.lblJPSurvey,
                this.lblSBSurvey);
            this.method_12();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3429);
        }
    }

    private void cmdNoGravSurvey_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass202_0 == null || this.gclass21_0 == null)
                return;
            for (int key = 1; key < 31 /*0x1F*/; ++key)
                this.gclass202_0.ActualSystemData.SurveyLocationDictionary[key].list_0.Remove(this.gclass21_0.RaceID);
            this.gclass202_0.method_40(this.lblAge, this.lblDiscovered, this.lblJSP, this.lblJPSurvey,
                this.lblSBSurvey);
            this.method_12();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3430);
        }
    }

    private void lblDangerous_Click(object sender, EventArgs e)
    {
    }

    private void cmdWideView_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_3();
            this.method_1();
            if (this.gclass1_0 == null)
                return;
            this.gclass1_0.method_0(this.lstvColonyCosts, this.gclass21_0, this.gclass194_0, this.int_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3542);
        }
    }

    private void lstvColonyCosts_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void flpDisplaySection_Paint(object sender, PaintEventArgs e)
    {
    }

    private void cmdRestrictJP_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null || this.gclass202_0 == null || this.gclass197_0 == null ||
                this.gclass120_0 == null)
                return;
            if (this.gclass120_0.RacialJumpPointSurveys[this.gclass21_0.RaceID].MilitaryRestricted == 1)
            {
                this.gclass120_0.RacialJumpPointSurveys[this.gclass21_0.RaceID].MilitaryRestricted = 0;
                if (this.gclass120_0.LinkedJumpPoint != null &&
                    this.gclass120_0.RacialJumpPointSurveys[this.gclass21_0.RaceID].Explored == 1)
                    this.gclass120_0.LinkedJumpPoint.RacialJumpPointSurveys[this.gclass21_0.RaceID].MilitaryRestricted = 0;
            }
            else if (MessageBox.Show(
                         $" Are you sure you want to restrict {this.gclass120_0.method_7(this.gclass202_0)} to military traffic? Any civilian freighters scheduled to enter this jump point will abandon their cargo and seek new trade runs. Colony ships will be diverted.",
                         "Confirmation Required", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.gclass120_0.RacialJumpPointSurveys[this.gclass21_0.RaceID].MilitaryRestricted = 1;
                this.gclass21_0.method_97(this.gclass120_0);
                if (this.gclass120_0.LinkedJumpPoint != null &&
                    this.gclass120_0.RacialJumpPointSurveys[this.gclass21_0.RaceID].Explored == 1)
                {
                    this.gclass120_0.LinkedJumpPoint.RacialJumpPointSurveys[this.gclass21_0.RaceID].MilitaryRestricted = 1;
                    this.gclass21_0.method_97(this.gclass120_0.LinkedJumpPoint);
                }
            }

            this.gclass202_0.method_39(this.lstvJP);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3474);
        }
    }

    private void cmdCreateHabitableSystem_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            this.gclass0_0.gclass198_0 = null;
            this.gclass0_0.bool_3 = true;
            if (this.gclass0_0.UseKnownStars == 1)
            {
                this.gclass0_0.bool_21 = false;
                int num = (int)new SelectKnownSystem(this.gclass0_0, true).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
            }

            this.gclass202_0 = this.gclass0_0.method_637(this.gclass21_0, this.gclass0_0.bool_3, 1M, true);
            this.method_5();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3650);
        }
    }

    private void method_12()
    {
        try
        {
            if (this.gclass202_0 == null || this.lstvStars.SelectedItems.Count <= 0)
                return;
            this.gclass197_0 = (Star197)this.lstvStars.SelectedItems[0].Tag;
            if (this.gclass197_0 == null)
                return;
            this.genum1_0 = !this.rdoAllMoons.Checked
                ? (!this.rdoHideMoons.Checked ? GEnum1.const_1 : GEnum1.const_2)
                : GEnum1.const_0;
            this.genum1_1 = !this.rdoAllAsteroids.Checked
                ? (!this.rdoHideAsteroids.Checked ? GEnum1.const_1 : GEnum1.const_2)
                : GEnum1.const_0;
            this.genum1_2 = !this.rdoAllComets.Checked
                ? (!this.rdoHideComets.Checked ? GEnum1.const_1 : GEnum1.const_2)
                : GEnum1.const_0;
            int index = -1;
            if (this.gclass1_0 != null && this.lstvSB.SelectedItems.Count > 0)
                index = this.lstvSB.SelectedItems[0].Index;
            Decimal decimal_29 = 10M;
            Decimal decimal_30 = 0M;
            ParsedDecimal gclass208_1 = AuroraUtils.ParseDecimalString(this.txtMaxColonyCost.Text);
            if (gclass208_1.Succeed)
                decimal_29 = gclass208_1.Value;
            ParsedDecimal gclass208_2 = AuroraUtils.ParseDecimalString(this.txtMinPopCapacity.Text);
            if (gclass208_2.Succeed)
                decimal_30 = gclass208_2.Value;
            this.lstvSB.Visible = false;
            this.gclass1_0 = this.gclass21_0.method_110(this.lstvSB, this.gclass197_0, this.genum1_0, this.genum1_1,
                this.genum1_2, this.chkMinDep.CheckState, this.chkUnsurveyed.CheckState, this.chkTeamSurvey.CheckState,
                this.chkMaxCC.CheckState, this.chkOrbital.CheckState, this.gclass194_0, this.bool_2,
                this.chkAlien.CheckState, this.chkAcceptableGravity.CheckState, this.chkExcludeGasGiants.CheckState,
                this.chkOxygenPresent.CheckState, this.chkWaterPresent.CheckState, this.chkHydroAbove20.CheckState,
                this.chkBelowMaxCC.CheckState, this.chkAboveMinPop.CheckState, this.chkMineralsPresent.CheckState,
                decimal_29, decimal_30, (GEnum59)this.cboSort1.SelectedIndex, (GEnum59)this.cboSort2.SelectedIndex);
            if (this.gclass1_0 == null)
            {
                this.lstvMinerals.Items.Clear();
                this.lstvAtmosphere.Items.Clear();
                this.lstvColonyCosts.Items.Clear();
                this.lblRetention.Text = "-";
                this.lblCCGravity.Text = "-";
                this.lblCCTemp.Text = "-";
                this.lblBreathable.Text = "-";
                this.lblMaxPressure.Text = "-";
                this.lblDangerous.Text = "-";
                this.lblWater.Text = "-";
                this.lblColonyCost.Text = "-";
                this.lblPerihelionCC.Text = "-";
                this.lblAphelionCC.Text = "-";
            }

            this.gclass202_0.method_39(this.lstvJP);
            this.lstvSB.Visible = true;
            if (index > -1)
            {
                if (this.lstvSB.Items.Count > index)
                    this.lstvSB.Items[index].Selected = true;
                else
                    this.method_7();
            }
            else
            {
                if (this.gclass1_0 == null)
                    return;
                this.method_7();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3137);
        }
    }

    private void chkMaxCC_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass1_0 = null;
            if (this.lstvStars.SelectedItems.Count <= 0)
                return;
            this.method_12();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3138);
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
        this.cboSystems = new ComboBox();
        this.lstvStars = new ListView();
        this.columnHeader_0 = new ColumnHeader();
        this.columnHeader_1 = new ColumnHeader();
        this.columnHeader_2 = new ColumnHeader();
        this.columnHeader_3 = new ColumnHeader();
        this.columnHeader_4 = new ColumnHeader();
        this.columnHeader_5 = new ColumnHeader();
        this.columnHeader_6 = new ColumnHeader();
        this.columnHeader_7 = new ColumnHeader();
        this.columnHeader_55 = new ColumnHeader();
        this.columnHeader_56 = new ColumnHeader();
        this.columnHeader_33 = new ColumnHeader();
        this.columnHeader_34 = new ColumnHeader();
        this.columnHeader_35 = new ColumnHeader();
        this.columnHeader_36 = new ColumnHeader();
        this.columnHeader_37 = new ColumnHeader();
        this.columnHeader_38 = new ColumnHeader();
        this.columnHeader_54 = new ColumnHeader();
        this.lstvSB = new ListView();
        this.columnHeader_8 = new ColumnHeader();
        this.columnHeader_47 = new ColumnHeader();
        this.columnHeader_9 = new ColumnHeader();
        this.columnHeader_13 = new ColumnHeader();
        this.columnHeader_12 = new ColumnHeader();
        this.columnHeader_51 = new ColumnHeader();
        this.columnHeader_18 = new ColumnHeader();
        this.columnHeader_16 = new ColumnHeader();
        this.columnHeader_17 = new ColumnHeader();
        this.columnHeader_14 = new ColumnHeader();
        this.columnHeader_15 = new ColumnHeader();
        this.columnHeader_11 = new ColumnHeader();
        this.columnHeader_10 = new ColumnHeader();
        this.columnHeader_28 = new ColumnHeader();
        this.columnHeader_42 = new ColumnHeader();
        this.columnHeader_57 = new ColumnHeader();
        this.columnHeader_58 = new ColumnHeader();
        this.columnHeader_59 = new ColumnHeader();
        this.columnHeader_60 = new ColumnHeader();
        this.columnHeader_24 = new ColumnHeader();
        this.columnHeader_19 = new ColumnHeader();
        this.columnHeader_20 = new ColumnHeader();
        this.columnHeader_21 = new ColumnHeader();
        this.columnHeader_53 = new ColumnHeader();
        this.columnHeader_22 = new ColumnHeader();
        this.columnHeader_23 = new ColumnHeader();
        this.columnHeader_25 = new ColumnHeader();
        this.columnHeader_26 = new ColumnHeader();
        this.columnHeader_27 = new ColumnHeader();
        this.columnHeader_29 = new ColumnHeader();
        this.columnHeader_32 = new ColumnHeader();
        this.columnHeader_30 = new ColumnHeader();
        this.columnHeader_31 = new ColumnHeader();
        this.columnHeader_52 = new ColumnHeader();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.rdoAllMoons = new RadioButton();
        this.rdoMineralMoons = new RadioButton();
        this.rdoHideMoons = new RadioButton();
        this.flowLayoutPanel2 = new FlowLayoutPanel();
        this.rdoAllAsteroids = new RadioButton();
        this.rdoMineralAsteroids = new RadioButton();
        this.rdoHideAsteroids = new RadioButton();
        this.flowLayoutPanel3 = new FlowLayoutPanel();
        this.rdoAllComets = new RadioButton();
        this.rdoCometMinerals = new RadioButton();
        this.rdoHideComets = new RadioButton();
        this.lblAge = new Label();
        this.label6 = new Label();
        this.lblDiscovered = new Label();
        this.label2 = new Label();
        this.flowLayoutPanel4 = new FlowLayoutPanel();
        this.flowLayoutPanel7 = new FlowLayoutPanel();
        this.label1 = new Label();
        this.label4 = new Label();
        this.label8 = new Label();
        this.flowLayoutPanel6 = new FlowLayoutPanel();
        this.lblBreathe = new Label();
        this.lblOxygen = new Label();
        this.label9 = new Label();
        this.flowLayoutPanel5 = new FlowLayoutPanel();
        this.label3 = new Label();
        this.label5 = new Label();
        this.label7 = new Label();
        this.flowLayoutPanel8 = new FlowLayoutPanel();
        this.lblGravity = new Label();
        this.lblTemperature = new Label();
        this.lblPressure = new Label();
        this.cboSpecies = new ComboBox();
        this.lblJSP = new Label();
        this.label11 = new Label();
        this.lblJPSurvey = new Label();
        this.label12 = new Label();
        this.lblSBSurvey = new Label();
        this.label13 = new Label();
        this.lstvMinerals = new ListView();
        this.columnHeader_39 = new ColumnHeader();
        this.columnHeader_40 = new ColumnHeader();
        this.columnHeader_41 = new ColumnHeader();
        this.flpColonyCosts = new FlowLayoutPanel();
        this.flowLayoutPanel11 = new FlowLayoutPanel();
        this.label38 = new Label();
        this.label24 = new Label();
        this.label25 = new Label();
        this.label27 = new Label();
        this.label26 = new Label();
        this.label28 = new Label();
        this.label30 = new Label();
        this.label29 = new Label();
        this.label32 = new Label();
        this.label33 = new Label();
        this.flowLayoutPanel12 = new FlowLayoutPanel();
        this.lblColonyCost = new Label();
        this.lblCCGravity = new Label();
        this.lblCCTemp = new Label();
        this.lblBreathable = new Label();
        this.lblDangerous = new Label();
        this.lblMaxPressure = new Label();
        this.lblRetention = new Label();
        this.lblWater = new Label();
        this.lblPerihelionCC = new Label();
        this.lblAphelionCC = new Label();
        this.cmdRenameSystem = new Button();
        this.lstvJP = new ListView();
        this.columnHeader_43 = new ColumnHeader();
        this.columnHeader_44 = new ColumnHeader();
        this.columnHeader_45 = new ColumnHeader();
        this.columnHeader_46 = new ColumnHeader();
        this.cmdRenameBody = new Button();
        this.cboRaces = new ComboBox();
        this.cmdAddColony = new Button();
        this.cmdDeleteSystem = new Button();
        this.flpSM = new FlowLayoutPanel();
        this.cmdCreateRace = new Button();
        this.cmdSwarm = new Button();
        this.cmdCreateSystem = new Button();
        this.cmdCreateHabitableSystem = new Button();
        this.cmdAddNewStar = new Button();
        this.cmdChangeStar = new Button();
        this.cmdAddPlanet = new Button();
        this.cmdModifyBody = new Button();
        this.cmdAddMoons = new Button();
        this.cmdAddLGP = new Button();
        this.cmdDeleteStar = new Button();
        this.cmdDeleteSystemBody = new Button();
        this.cmdDeleteBelt = new Button();
        this.cmdDeleteLagrange = new Button();
        this.cmdJPSurvey = new Button();
        this.cmdAllBodySurvey = new Button();
        this.cmdNoBodySurvey = new Button();
        this.cmdBodySurvey = new Button();
        this.cmdHWMinerals = new Button();
        this.cmdAddJumpPoint = new Button();
        this.cmdDeleteJP = new Button();
        this.cmdRandomRuin = new Button();
        this.flowLayoutPanel9 = new FlowLayoutPanel();
        this.chkMinDep = new CheckBox();
        this.chkUnsurveyed = new CheckBox();
        this.chkTeamSurvey = new CheckBox();
        this.chkOrbital = new CheckBox();
        this.chkMaxCC = new CheckBox();
        this.cmdExploreJP = new Button();
        this.flpButtonRow = new FlowLayoutPanel();
        this.cmdSelectName = new Button();
        this.cmdRenameSystemAll = new Button();
        this.cmdRenameBodyAll = new Button();
        this.cmdBanBody = new Button();
        this.cmdPotentialColonies = new Button();
        this.cmdRestrictJP = new Button();
        this.cmdWideView = new Button();
        this.cmdNameSolBodies = new Button();
        this.cmdEnterJP = new Button();
        this.cmdMinText = new Button();
        this.cmdJG = new Button();
        this.flpDisplaySection = new FlowLayoutPanel();
        this.flpJPs = new FlowLayoutPanel();
        this.cmdChangeJPLocation = new Button();
        this.cmdDeleteJG = new Button();
        this.flowLayoutPanel15 = new FlowLayoutPanel();
        this.flpMinButtons = new FlowLayoutPanel();
        this.cmdNewMinerals = new Button();
        this.cmdSpecify = new Button();
        this.cmdRemoveMinerals = new Button();
        this.lstvAtmosphere = new ListView();
        this.columnHeader_48 = new ColumnHeader();
        this.columnHeader_49 = new ColumnHeader();
        this.columnHeader_50 = new ColumnHeader();
        this.lstvColonyCosts = new ListView();
        this.columnHeader_61 = new ColumnHeader();
        this.columnHeader_62 = new ColumnHeader();
        this.columnHeader_63 = new ColumnHeader();
        this.columnHeader_64 = new ColumnHeader();
        this.columnHeader_65 = new ColumnHeader();
        this.columnHeader_66 = new ColumnHeader();
        this.columnHeader_67 = new ColumnHeader();
        this.columnHeader_68 = new ColumnHeader();
        this.columnHeader_69 = new ColumnHeader();
        this.columnHeader_70 = new ColumnHeader();
        this.columnHeader_71 = new ColumnHeader();
        this.columnHeader_72 = new ColumnHeader();
        this.columnHeader_73 = new ColumnHeader();
        this.flpSpecify = new FlowLayoutPanel();
        this.flowLayoutPanel16 = new FlowLayoutPanel();
        this.label10 = new Label();
        this.label14 = new Label();
        this.label15 = new Label();
        this.label16 = new Label();
        this.label17 = new Label();
        this.label18 = new Label();
        this.label19 = new Label();
        this.label20 = new Label();
        this.label21 = new Label();
        this.label22 = new Label();
        this.label23 = new Label();
        this.flowLayoutPanel17 = new FlowLayoutPanel();
        this.txtAmount1 = new TextBox();
        this.txtAmount2 = new TextBox();
        this.txtAmount3 = new TextBox();
        this.txtAmount4 = new TextBox();
        this.txtAmount5 = new TextBox();
        this.txtAmount6 = new TextBox();
        this.txtAmount7 = new TextBox();
        this.txtAmount8 = new TextBox();
        this.txtAmount9 = new TextBox();
        this.txtAmount10 = new TextBox();
        this.txtAmount11 = new TextBox();
        this.flowLayoutPanel18 = new FlowLayoutPanel();
        this.txtAcc1 = new TextBox();
        this.txtAcc2 = new TextBox();
        this.txtAcc3 = new TextBox();
        this.txtAcc4 = new TextBox();
        this.txtAcc5 = new TextBox();
        this.txtAcc6 = new TextBox();
        this.txtAcc7 = new TextBox();
        this.txtAcc8 = new TextBox();
        this.txtAcc9 = new TextBox();
        this.txtAcc10 = new TextBox();
        this.txtAcc11 = new TextBox();
        this.chkAlien = new CheckBox();
        this.txtMaxColonyCost = new TextBox();
        this.chkWaterPresent = new CheckBox();
        this.chkHydroAbove20 = new CheckBox();
        this.chkOxygenPresent = new CheckBox();
        this.txtMinPopCapacity = new TextBox();
        this.chkAcceptableGravity = new CheckBox();
        this.chkExcludeGasGiants = new CheckBox();
        this.flowLayoutPanel22 = new FlowLayoutPanel();
        this.chkBelowMaxCC = new CheckBox();
        this.chkAboveMinPop = new CheckBox();
        this.chkMineralsPresent = new CheckBox();
        this.flpAllSystemOptions = new FlowLayoutPanel();
        this.flowLayoutPanel23 = new FlowLayoutPanel();
        this.flowLayoutPanel24 = new FlowLayoutPanel();
        this.label31 = new Label();
        this.cboSort1 = new ComboBox();
        this.cboSort2 = new ComboBox();
        this.cmdRedoJP = new Button();
        this.cmdRedoAllMinerals = new Button();
        this.flpSMButtons = new FlowLayoutPanel();
        this.cmdNoGravSurvey = new Button();
        this.pbSpecies = new PictureBox();
        this.flowLayoutPanel1.SuspendLayout();
        this.flowLayoutPanel2.SuspendLayout();
        this.flowLayoutPanel3.SuspendLayout();
        this.flowLayoutPanel4.SuspendLayout();
        this.flowLayoutPanel7.SuspendLayout();
        this.flowLayoutPanel6.SuspendLayout();
        this.flowLayoutPanel5.SuspendLayout();
        this.flowLayoutPanel8.SuspendLayout();
        this.flpColonyCosts.SuspendLayout();
        this.flowLayoutPanel11.SuspendLayout();
        this.flowLayoutPanel12.SuspendLayout();
        this.flpSM.SuspendLayout();
        this.flowLayoutPanel9.SuspendLayout();
        this.flpButtonRow.SuspendLayout();
        this.flpDisplaySection.SuspendLayout();
        this.flpJPs.SuspendLayout();
        this.flowLayoutPanel15.SuspendLayout();
        this.flpMinButtons.SuspendLayout();
        this.flpSpecify.SuspendLayout();
        this.flowLayoutPanel16.SuspendLayout();
        this.flowLayoutPanel17.SuspendLayout();
        this.flowLayoutPanel18.SuspendLayout();
        this.flowLayoutPanel22.SuspendLayout();
        this.flpAllSystemOptions.SuspendLayout();
        this.flowLayoutPanel23.SuspendLayout();
        this.flowLayoutPanel24.SuspendLayout();
        this.flpSMButtons.SuspendLayout();
        ((ISupportInitialize)this.pbSpecies).BeginInit();
        this.SuspendLayout();
        this.cboSystems.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSystems.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboSystems.FormattingEnabled = true;
        this.cboSystems.Location = new Point(184, 3);
        this.cboSystems.Margin = new Padding(3, 3, 3, 0);
        this.cboSystems.Name = "cboSystems";
        this.cboSystems.Size = new Size(176 /*0xB0*/, 21);
        this.cboSystems.TabIndex = 39;
        this.cboSystems.SelectedIndexChanged += this.cboSystems_SelectedIndexChanged;
        this.lstvStars.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvStars.BorderStyle = BorderStyle.FixedSingle;
        this.lstvStars.Columns.AddRange(new ColumnHeader[17]
        {
            this.columnHeader_0,
            this.columnHeader_1,
            this.columnHeader_2,
            this.columnHeader_3,
            this.columnHeader_4,
            this.columnHeader_5,
            this.columnHeader_6,
            this.columnHeader_7,
            this.columnHeader_55,
            this.columnHeader_56,
            this.columnHeader_33,
            this.columnHeader_34,
            this.columnHeader_35,
            this.columnHeader_36,
            this.columnHeader_37,
            this.columnHeader_38,
            this.columnHeader_54
        });
        this.lstvStars.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvStars.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvStars.HideSelection = false;
        this.lstvStars.Location = new Point(2, 27);
        this.lstvStars.MultiSelect = false;
        this.lstvStars.Name = "lstvStars";
        this.lstvStars.Size = new Size(1044, 88);
        this.lstvStars.TabIndex = 70;
        this.lstvStars.UseCompatibleStateImageBehavior = false;
        this.lstvStars.View = View.Details;
        this.lstvStars.SelectedIndexChanged += this.chkMaxCC_CheckedChanged;
        this.columnHeader_0.Text = "Name";
        this.columnHeader_0.Width = 150;
        this.columnHeader_1.Text = "Spectral Class";
        this.columnHeader_1.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_2.Text = "Diameter";
        this.columnHeader_2.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_3.Text = "Mass";
        this.columnHeader_3.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_3.Width = 55;
        this.columnHeader_4.Text = "Luminosity";
        this.columnHeader_4.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_4.Width = 65;
        this.columnHeader_5.Text = "Parent Star";
        this.columnHeader_5.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_6.Text = "Orbital Period";
        this.columnHeader_6.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_7.Text = "Orbital Distance";
        this.columnHeader_7.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_55.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_56.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_33.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_33.Width = 50;
        this.columnHeader_34.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_34.Width = 55;
        this.columnHeader_35.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_35.Width = 55;
        this.columnHeader_36.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_36.Width = 55;
        this.columnHeader_37.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_38.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_38.Width = 75;
        this.columnHeader_54.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_54.Width = 0;
        this.lstvSB.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvSB.BorderStyle = BorderStyle.FixedSingle;
        this.lstvSB.Columns.AddRange(new ColumnHeader[34]
        {
            this.columnHeader_8,
            this.columnHeader_47,
            this.columnHeader_9,
            this.columnHeader_13,
            this.columnHeader_12,
            this.columnHeader_51,
            this.columnHeader_18,
            this.columnHeader_16,
            this.columnHeader_17,
            this.columnHeader_14,
            this.columnHeader_15,
            this.columnHeader_11,
            this.columnHeader_10,
            this.columnHeader_28,
            this.columnHeader_42,
            this.columnHeader_57,
            this.columnHeader_58,
            this.columnHeader_59,
            this.columnHeader_60,
            this.columnHeader_24,
            this.columnHeader_19,
            this.columnHeader_20,
            this.columnHeader_21,
            this.columnHeader_53,
            this.columnHeader_22,
            this.columnHeader_23,
            this.columnHeader_25,
            this.columnHeader_26,
            this.columnHeader_27,
            this.columnHeader_29,
            this.columnHeader_32,
            this.columnHeader_30,
            this.columnHeader_31,
            this.columnHeader_52
        });
        this.lstvSB.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvSB.FullRowSelect = true;
        this.lstvSB.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        this.lstvSB.HideSelection = false;
        this.lstvSB.Location = new Point(2, 155);
        this.lstvSB.MultiSelect = false;
        this.lstvSB.Name = "lstvSB";
        this.lstvSB.OwnerDraw = true;
        this.lstvSB.Size = new Size(1420, 452);
        this.lstvSB.TabIndex = 71;
        this.lstvSB.UseCompatibleStateImageBehavior = false;
        this.lstvSB.View = View.Details;
        this.lstvSB.DrawColumnHeader += this.lstvSB_DrawColumnHeader;
        this.lstvSB.DrawItem += this.lstvSB_DrawItem;
        this.lstvSB.DrawSubItem += this.lstvSB_DrawSubItem;
        this.lstvSB.SelectedIndexChanged += this.lstvSB_SelectedIndexChanged;
        this.columnHeader_8.Text = " Name";
        this.columnHeader_8.Width = 160 /*0xA0*/;
        this.columnHeader_47.Text = "";
        this.columnHeader_47.Width = 40;
        this.columnHeader_9.Text = " Type";
        this.columnHeader_9.Width = 130;
        this.columnHeader_13.Text = " Colony Cost";
        this.columnHeader_13.Width = 70;
        this.columnHeader_12.Text = " Population (m)";
        this.columnHeader_12.Width = 160 /*0xA0*/;
        this.columnHeader_51.Text = " Terrain";
        this.columnHeader_51.Width = 145;
        this.columnHeader_18.Text = " Hydro";
        this.columnHeader_18.Width = 100;
        this.columnHeader_16.Text = " Atmosphere";
        this.columnHeader_16.Width = 140;
        this.columnHeader_17.Text = " Pressure";
        this.columnHeader_14.Text = " Temp (C)";
        this.columnHeader_15.Text = " Gravity (G)";
        this.columnHeader_15.Width = 70;
        this.columnHeader_11.Text = " Distance";
        this.columnHeader_11.Width = 70;
        this.columnHeader_10.Text = " Diameter";
        this.columnHeader_10.Width = 70;
        this.columnHeader_28.Text = " Tidal Lock";
        this.columnHeader_28.Width = 70;
        this.columnHeader_42.Text = " Max Pop";
        this.columnHeader_42.Width = 70;
        this.columnHeader_57.Text = "Perihelion";
        this.columnHeader_57.Width = 70;
        this.columnHeader_58.Text = "Aphelion";
        this.columnHeader_58.Width = 70;
        this.columnHeader_59.Text = "Eccentric";
        this.columnHeader_60.Text = "Inclination";
        this.columnHeader_24.Text = "Orbital Period";
        this.columnHeader_24.Width = 80 /*0x50*/;
        this.columnHeader_19.Text = " Tectonics";
        this.columnHeader_19.Width = 100;
        this.columnHeader_20.Text = " Mag Field";
        this.columnHeader_21.Text = " GH Factor";
        this.columnHeader_21.Width = 70;
        this.columnHeader_53.Text = "AGH Factor";
        this.columnHeader_53.Width = 70;
        this.columnHeader_22.Text = " Albedo";
        this.columnHeader_22.Width = 70;
        this.columnHeader_23.Text = " Day";
        this.columnHeader_23.Width = 80 /*0x50*/;
        this.columnHeader_25.Text = " Mass";
        this.columnHeader_25.Width = 70;
        this.columnHeader_26.Text = " Density";
        this.columnHeader_26.Width = 70;
        this.columnHeader_27.Text = " Esc Velocity";
        this.columnHeader_27.Width = 70;
        this.columnHeader_29.Text = " Axial Tilt";
        this.columnHeader_29.Width = 70;
        this.columnHeader_32.Text = " Base Temp";
        this.columnHeader_32.Width = 70;
        this.columnHeader_30.Text = " Radiation";
        this.columnHeader_30.Width = 70;
        this.columnHeader_31.Text = " Dust Level";
        this.columnHeader_31.Width = 70;
        this.columnHeader_52.Text = "LG Time (y)";
        this.columnHeader_52.Width = 70;
        this.flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel1.Controls.Add(this.rdoAllMoons);
        this.flowLayoutPanel1.Controls.Add(this.rdoMineralMoons);
        this.flowLayoutPanel1.Controls.Add(this.rdoHideMoons);
        this.flowLayoutPanel1.Location = new Point(2, 121);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(274, 28);
        this.flowLayoutPanel1.TabIndex = 72;
        this.rdoAllMoons.AutoSize = true;
        this.rdoAllMoons.Checked = true;
        this.rdoAllMoons.Location = new Point(3, 3);
        this.rdoAllMoons.Name = "rdoAllMoons";
        this.rdoAllMoons.Padding = new Padding(3, 1, 0, 0);
        this.rdoAllMoons.Size = new Size(74, 18);
        this.rdoAllMoons.TabIndex = 1;
        this.rdoAllMoons.TabStop = true;
        this.rdoAllMoons.Text = "All Moons";
        this.rdoAllMoons.UseVisualStyleBackColor = true;
        this.rdoAllMoons.CheckedChanged += this.chkMaxCC_CheckedChanged;
        this.rdoMineralMoons.AutoSize = true;
        this.rdoMineralMoons.Location = new Point(83, 3);
        this.rdoMineralMoons.Name = "rdoMineralMoons";
        this.rdoMineralMoons.Padding = new Padding(3, 1, 0, 0);
        this.rdoMineralMoons.Size = new Size(92, 18);
        this.rdoMineralMoons.TabIndex = 2;
        this.rdoMineralMoons.Text = "With Minerals";
        this.rdoMineralMoons.UseVisualStyleBackColor = true;
        this.rdoMineralMoons.CheckedChanged += this.chkMaxCC_CheckedChanged;
        this.rdoHideMoons.AutoSize = true;
        this.rdoHideMoons.Location = new Point(181, 3);
        this.rdoHideMoons.Name = "rdoHideMoons";
        this.rdoHideMoons.Padding = new Padding(3, 1, 0, 0);
        this.rdoHideMoons.Size = new Size(85, 18);
        this.rdoHideMoons.TabIndex = 0;
        this.rdoHideMoons.Text = "Hide Moons";
        this.rdoHideMoons.UseVisualStyleBackColor = true;
        this.rdoHideMoons.CheckedChanged += this.chkMaxCC_CheckedChanged;
        this.flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel2.Controls.Add(this.rdoAllAsteroids);
        this.flowLayoutPanel2.Controls.Add(this.rdoMineralAsteroids);
        this.flowLayoutPanel2.Controls.Add(this.rdoHideAsteroids);
        this.flowLayoutPanel2.Location = new Point(282, 121);
        this.flowLayoutPanel2.Name = "flowLayoutPanel2";
        this.flowLayoutPanel2.Size = new Size(296, 28);
        this.flowLayoutPanel2.TabIndex = 73;
        this.rdoAllAsteroids.AutoSize = true;
        this.rdoAllAsteroids.Location = new Point(3, 3);
        this.rdoAllAsteroids.Name = "rdoAllAsteroids";
        this.rdoAllAsteroids.Padding = new Padding(3, 1, 0, 0);
        this.rdoAllAsteroids.Size = new Size(85, 18);
        this.rdoAllAsteroids.TabIndex = 1;
        this.rdoAllAsteroids.Text = "All Asteroids";
        this.rdoAllAsteroids.UseVisualStyleBackColor = true;
        this.rdoAllAsteroids.CheckedChanged += this.chkMaxCC_CheckedChanged;
        this.rdoMineralAsteroids.AutoSize = true;
        this.rdoMineralAsteroids.Location = new Point(94, 3);
        this.rdoMineralAsteroids.Name = "rdoMineralAsteroids";
        this.rdoMineralAsteroids.Padding = new Padding(3, 1, 0, 0);
        this.rdoMineralAsteroids.Size = new Size(92, 18);
        this.rdoMineralAsteroids.TabIndex = 2;
        this.rdoMineralAsteroids.Text = "With Minerals";
        this.rdoMineralAsteroids.UseVisualStyleBackColor = true;
        this.rdoMineralAsteroids.CheckedChanged += this.chkMaxCC_CheckedChanged;
        this.rdoHideAsteroids.AutoSize = true;
        this.rdoHideAsteroids.Checked = true;
        this.rdoHideAsteroids.Location = new Point(192 /*0xC0*/, 3);
        this.rdoHideAsteroids.Name = "rdoHideAsteroids";
        this.rdoHideAsteroids.Padding = new Padding(3, 1, 0, 0);
        this.rdoHideAsteroids.Size = new Size(96 /*0x60*/, 18);
        this.rdoHideAsteroids.TabIndex = 0;
        this.rdoHideAsteroids.TabStop = true;
        this.rdoHideAsteroids.Text = "Hide Asteroids";
        this.rdoHideAsteroids.UseVisualStyleBackColor = true;
        this.rdoHideAsteroids.CheckedChanged += this.chkMaxCC_CheckedChanged;
        this.flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel3.Controls.Add(this.rdoAllComets);
        this.flowLayoutPanel3.Controls.Add(this.rdoCometMinerals);
        this.flowLayoutPanel3.Controls.Add(this.rdoHideComets);
        this.flowLayoutPanel3.Location = new Point(585, 121);
        this.flowLayoutPanel3.Name = "flowLayoutPanel3";
        this.flowLayoutPanel3.Size = new Size(279, 28);
        this.flowLayoutPanel3.TabIndex = 74;
        this.rdoAllComets.AutoSize = true;
        this.rdoAllComets.Location = new Point(3, 3);
        this.rdoAllComets.Name = "rdoAllComets";
        this.rdoAllComets.Padding = new Padding(3, 1, 0, 0);
        this.rdoAllComets.Size = new Size(77, 18);
        this.rdoAllComets.TabIndex = 1;
        this.rdoAllComets.Text = "All Comets";
        this.rdoAllComets.UseVisualStyleBackColor = true;
        this.rdoAllComets.CheckedChanged += this.chkMaxCC_CheckedChanged;
        this.rdoCometMinerals.AutoSize = true;
        this.rdoCometMinerals.Checked = true;
        this.rdoCometMinerals.Location = new Point(86, 3);
        this.rdoCometMinerals.Name = "rdoCometMinerals";
        this.rdoCometMinerals.Padding = new Padding(3, 1, 0, 0);
        this.rdoCometMinerals.Size = new Size(92, 18);
        this.rdoCometMinerals.TabIndex = 2;
        this.rdoCometMinerals.TabStop = true;
        this.rdoCometMinerals.Text = "With Minerals";
        this.rdoCometMinerals.UseVisualStyleBackColor = true;
        this.rdoCometMinerals.CheckedChanged += this.chkMaxCC_CheckedChanged;
        this.rdoHideComets.AutoSize = true;
        this.rdoHideComets.Location = new Point(184, 3);
        this.rdoHideComets.Name = "rdoHideComets";
        this.rdoHideComets.Padding = new Padding(3, 1, 0, 0);
        this.rdoHideComets.Size = new Size(88, 18);
        this.rdoHideComets.TabIndex = 0;
        this.rdoHideComets.Text = "Hide Comets";
        this.rdoHideComets.UseVisualStyleBackColor = true;
        this.rdoHideComets.CheckedChanged += this.chkMaxCC_CheckedChanged;
        this.lblAge.AutoSize = true;
        this.lblAge.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblAge.Location = new Point(406, 3);
        this.lblAge.Name = "lblAge";
        this.lblAge.Padding = new Padding(0, 5, 5, 0);
        this.lblAge.Size = new Size(18, 18);
        this.lblAge.TabIndex = 94;
        this.lblAge.Text = "0";
        this.lblAge.TextAlign = ContentAlignment.MiddleCenter;
        this.label6.AutoSize = true;
        this.label6.Location = new Point(378, 3);
        this.label6.Name = "label6";
        this.label6.Padding = new Padding(0, 5, 5, 0);
        this.label6.Size = new Size(31 /*0x1F*/, 18);
        this.label6.TabIndex = 93;
        this.label6.Text = "Age";
        this.lblDiscovered.AutoSize = true;
        this.lblDiscovered.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblDiscovered.Location = new Point(511 /*0x01FF*/, 3);
        this.lblDiscovered.Name = "lblDiscovered";
        this.lblDiscovered.Padding = new Padding(0, 5, 5, 0);
        this.lblDiscovered.Size = new Size(18, 18);
        this.lblDiscovered.TabIndex = 96 /*0x60*/;
        this.lblDiscovered.Text = "0";
        this.lblDiscovered.TextAlign = ContentAlignment.MiddleCenter;
        this.label2.AutoSize = true;
        this.label2.Location = new Point(444, 3);
        this.label2.Name = "label2";
        this.label2.Padding = new Padding(0, 5, 5, 0);
        this.label2.Size = new Size(66, 18);
        this.label2.TabIndex = 95;
        this.label2.Text = "Discovered";
        this.flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel7);
        this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel6);
        this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel5);
        this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel8);
        this.flowLayoutPanel4.Location = new Point(1052, 27);
        this.flowLayoutPanel4.Name = "flowLayoutPanel4";
        this.flowLayoutPanel4.Size = new Size(370, 88);
        this.flowLayoutPanel4.TabIndex = 97;
        this.flowLayoutPanel7.Controls.Add(this.label1);
        this.flowLayoutPanel7.Controls.Add(this.label4);
        this.flowLayoutPanel7.Controls.Add(this.label8);
        this.flowLayoutPanel7.Location = new Point(0, 0);
        this.flowLayoutPanel7.Margin = new Padding(0);
        this.flowLayoutPanel7.Name = "flowLayoutPanel7";
        this.flowLayoutPanel7.Size = new Size(53, 84);
        this.flowLayoutPanel7.TabIndex = 99;
        this.label1.AutoSize = true;
        this.label1.Location = new Point(3, 3);
        this.label1.Margin = new Padding(3, 3, 0, 3);
        this.label1.Name = "label1";
        this.label1.Padding = new Padding(0, 5, 5, 0);
        this.label1.Size = new Size(49, 18);
        this.label1.TabIndex = 95;
        this.label1.Text = "Breathe";
        this.label4.AutoSize = true;
        this.label4.Location = new Point(3, 27);
        this.label4.Margin = new Padding(3, 3, 0, 3);
        this.label4.Name = "label4";
        this.label4.Padding = new Padding(0, 5, 5, 0);
        this.label4.Size = new Size(47, 18);
        this.label4.TabIndex = 96 /*0x60*/;
        this.label4.Text = "Range ";
        this.label8.AutoSize = true;
        this.label8.Location = new Point(3, 51);
        this.label8.Margin = new Padding(3, 3, 0, 3);
        this.label8.Name = "label8";
        this.label8.Padding = new Padding(0, 5, 5, 0);
        this.label8.Size = new Size(43, 18);
        this.label8.TabIndex = 97;
        this.label8.Text = "Max %";
        this.flowLayoutPanel6.Controls.Add(this.lblBreathe);
        this.flowLayoutPanel6.Controls.Add(this.lblOxygen);
        this.flowLayoutPanel6.Controls.Add(this.label9);
        this.flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel6.Location = new Point(53, 0);
        this.flowLayoutPanel6.Margin = new Padding(0);
        this.flowLayoutPanel6.Name = "flowLayoutPanel6";
        this.flowLayoutPanel6.Size = new Size(133, 84);
        this.flowLayoutPanel6.TabIndex = 98;
        this.lblBreathe.AutoSize = true;
        this.lblBreathe.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblBreathe.Location = new Point(3, 3);
        this.lblBreathe.Margin = new Padding(3);
        this.lblBreathe.Name = "lblBreathe";
        this.lblBreathe.Padding = new Padding(0, 5, 5, 0);
        this.lblBreathe.Size = new Size(18, 18);
        this.lblBreathe.TabIndex = 98;
        this.lblBreathe.Text = "0";
        this.lblBreathe.TextAlign = ContentAlignment.MiddleCenter;
        this.lblOxygen.AutoSize = true;
        this.lblOxygen.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblOxygen.Location = new Point(3, 27);
        this.lblOxygen.Margin = new Padding(3);
        this.lblOxygen.Name = "lblOxygen";
        this.lblOxygen.Padding = new Padding(0, 5, 5, 0);
        this.lblOxygen.Size = new Size(18, 18);
        this.lblOxygen.TabIndex = 98;
        this.lblOxygen.Text = "0";
        this.lblOxygen.TextAlign = ContentAlignment.MiddleCenter;
        this.label9.AutoSize = true;
        this.label9.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.label9.Location = new Point(3, 51);
        this.label9.Margin = new Padding(3);
        this.label9.Name = "label9";
        this.label9.Padding = new Padding(0, 5, 5, 0);
        this.label9.Size = new Size(32 /*0x20*/, 18);
        this.label9.TabIndex = 99;
        this.label9.Text = "30%";
        this.label9.TextAlign = ContentAlignment.MiddleCenter;
        this.flowLayoutPanel5.Controls.Add(this.label3);
        this.flowLayoutPanel5.Controls.Add(this.label5);
        this.flowLayoutPanel5.Controls.Add(this.label7);
        this.flowLayoutPanel5.Location = new Point(186, 0);
        this.flowLayoutPanel5.Margin = new Padding(0);
        this.flowLayoutPanel5.Name = "flowLayoutPanel5";
        this.flowLayoutPanel5.Size = new Size(44, 84);
        this.flowLayoutPanel5.TabIndex = 97;
        this.label3.AutoSize = true;
        this.label3.Location = new Point(3, 3);
        this.label3.Margin = new Padding(3);
        this.label3.Name = "label3";
        this.label3.Padding = new Padding(0, 5, 5, 0);
        this.label3.Size = new Size(35, 18);
        this.label3.TabIndex = 95;
        this.label3.Text = "Grav";
        this.label5.AutoSize = true;
        this.label5.Location = new Point(3, 27);
        this.label5.Margin = new Padding(3, 3, 0, 3);
        this.label5.Name = "label5";
        this.label5.Padding = new Padding(0, 5, 5, 0);
        this.label5.Size = new Size(39, 18);
        this.label5.TabIndex = 97;
        this.label5.Text = "Temp";
        this.label7.AutoSize = true;
        this.label7.Location = new Point(3, 51);
        this.label7.Margin = new Padding(3, 3, 0, 3);
        this.label7.Name = "label7";
        this.label7.Padding = new Padding(0, 5, 5, 0);
        this.label7.Size = new Size(38, 18);
        this.label7.TabIndex = 96 /*0x60*/;
        this.label7.Text = "Press";
        this.flowLayoutPanel8.Controls.Add(this.lblGravity);
        this.flowLayoutPanel8.Controls.Add(this.lblTemperature);
        this.flowLayoutPanel8.Controls.Add(this.lblPressure);
        this.flowLayoutPanel8.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel8.Location = new Point(230, 0);
        this.flowLayoutPanel8.Margin = new Padding(0);
        this.flowLayoutPanel8.Name = "flowLayoutPanel8";
        this.flowLayoutPanel8.Size = new Size(133, 84);
        this.flowLayoutPanel8.TabIndex = 100;
        this.lblGravity.AutoSize = true;
        this.lblGravity.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblGravity.Location = new Point(3, 3);
        this.lblGravity.Margin = new Padding(3);
        this.lblGravity.Name = "lblGravity";
        this.lblGravity.Padding = new Padding(0, 5, 5, 0);
        this.lblGravity.Size = new Size(18, 18);
        this.lblGravity.TabIndex = 97;
        this.lblGravity.Text = "0";
        this.lblGravity.TextAlign = ContentAlignment.MiddleCenter;
        this.lblTemperature.AutoSize = true;
        this.lblTemperature.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblTemperature.Location = new Point(3, 27);
        this.lblTemperature.Margin = new Padding(3);
        this.lblTemperature.Name = "lblTemperature";
        this.lblTemperature.Padding = new Padding(0, 5, 5, 0);
        this.lblTemperature.Size = new Size(18, 18);
        this.lblTemperature.TabIndex = 99;
        this.lblTemperature.Text = "0";
        this.lblTemperature.TextAlign = ContentAlignment.MiddleCenter;
        this.lblPressure.AutoSize = true;
        this.lblPressure.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblPressure.Location = new Point(3, 51);
        this.lblPressure.Margin = new Padding(3);
        this.lblPressure.Name = "lblPressure";
        this.lblPressure.Padding = new Padding(0, 5, 5, 0);
        this.lblPressure.Size = new Size(18, 18);
        this.lblPressure.TabIndex = 97;
        this.lblPressure.Text = "0";
        this.lblPressure.TextAlign = ContentAlignment.MiddleCenter;
        this.cboSpecies.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSpecies.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboSpecies.FormattingEnabled = true;
        this.cboSpecies.Location = new Point(1051, 3);
        this.cboSpecies.Margin = new Padding(3, 3, 3, 0);
        this.cboSpecies.Name = "cboSpecies";
        this.cboSpecies.Size = new Size(176 /*0xB0*/, 21);
        this.cboSpecies.TabIndex = 40;
        this.cboSpecies.SelectedIndexChanged += this.cboSpecies_SelectedIndexChanged;
        this.lblJSP.AutoSize = true;
        this.lblJSP.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblJSP.Location = new Point(800, 3);
        this.lblJSP.Name = "lblJSP";
        this.lblJSP.Padding = new Padding(0, 5, 5, 0);
        this.lblJSP.Size = new Size(18, 18);
        this.lblJSP.TabIndex = 99;
        this.lblJSP.Text = "0";
        this.lblJSP.TextAlign = ContentAlignment.MiddleCenter;
        this.label11.AutoSize = true;
        this.label11.Location = new Point(673, 3);
        this.label11.Name = "label11";
        this.label11.Padding = new Padding(0, 5, 5, 0);
        this.label11.Size = new Size(129, 18);
        this.label11.TabIndex = 98;
        this.label11.Text = "JSP per Survey Location";
        this.lblJPSurvey.AutoSize = true;
        this.lblJPSurvey.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblJPSurvey.Location = new Point(908, 3);
        this.lblJPSurvey.Name = "lblJPSurvey";
        this.lblJPSurvey.Padding = new Padding(0, 5, 5, 0);
        this.lblJPSurvey.Size = new Size(18, 18);
        this.lblJPSurvey.TabIndex = 101;
        this.lblJPSurvey.Text = "0";
        this.lblJPSurvey.TextAlign = ContentAlignment.MiddleCenter;
        this.label12.AutoSize = true;
        this.label12.Location = new Point(850, 3);
        this.label12.Name = "label12";
        this.label12.Padding = new Padding(0, 5, 5, 0);
        this.label12.Size = new Size(60, 18);
        this.label12.TabIndex = 100;
        this.label12.Text = "JP Survey";
        this.lblSBSurvey.AutoSize = true;
        this.lblSBSurvey.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblSBSurvey.Location = new Point(1006, 3);
        this.lblSBSurvey.Name = "lblSBSurvey";
        this.lblSBSurvey.Padding = new Padding(0, 5, 5, 0);
        this.lblSBSurvey.Size = new Size(18, 18);
        this.lblSBSurvey.TabIndex = 103;
        this.lblSBSurvey.Text = "0";
        this.lblSBSurvey.TextAlign = ContentAlignment.MiddleCenter;
        this.label13.AutoSize = true;
        this.label13.Location = new Point(946, 3);
        this.label13.Name = "label13";
        this.label13.Padding = new Padding(0, 5, 5, 0);
        this.label13.Size = new Size(62, 18);
        this.label13.TabIndex = 102;
        this.label13.Text = "SB Survey";
        this.lstvMinerals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvMinerals.BorderStyle = BorderStyle.FixedSingle;
        this.lstvMinerals.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_39,
            this.columnHeader_40,
            this.columnHeader_41
        });
        this.lstvMinerals.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvMinerals.FullRowSelect = true;
        this.lstvMinerals.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvMinerals.HideSelection = false;
        this.lstvMinerals.Location = new Point(0, 0);
        this.lstvMinerals.Margin = new Padding(0);
        this.lstvMinerals.Name = "lstvMinerals";
        this.lstvMinerals.Size = new Size(230, 212);
        this.lstvMinerals.TabIndex = 106;
        this.lstvMinerals.UseCompatibleStateImageBehavior = false;
        this.lstvMinerals.View = View.Details;
        this.columnHeader_39.Width = 80 /*0x50*/;
        this.columnHeader_40.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_40.Width = 90;
        this.columnHeader_41.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_41.Width = 50;
        this.flpColonyCosts.BorderStyle = BorderStyle.FixedSingle;
        this.flpColonyCosts.Controls.Add(this.flowLayoutPanel11);
        this.flpColonyCosts.Controls.Add(this.flowLayoutPanel12);
        this.flpColonyCosts.Location = new Point(765, 0);
        this.flpColonyCosts.Margin = new Padding(3, 0, 3, 0);
        this.flpColonyCosts.Name = "flpColonyCosts";
        this.flpColonyCosts.Size = new Size(198, 212);
        this.flpColonyCosts.TabIndex = 107;
        this.flpColonyCosts.WrapContents = false;
        this.flowLayoutPanel11.Controls.Add(this.label38);
        this.flowLayoutPanel11.Controls.Add(this.label24);
        this.flowLayoutPanel11.Controls.Add(this.label25);
        this.flowLayoutPanel11.Controls.Add(this.label27);
        this.flowLayoutPanel11.Controls.Add(this.label26);
        this.flowLayoutPanel11.Controls.Add(this.label28);
        this.flowLayoutPanel11.Controls.Add(this.label30);
        this.flowLayoutPanel11.Controls.Add(this.label29);
        this.flowLayoutPanel11.Controls.Add(this.label32);
        this.flowLayoutPanel11.Controls.Add(this.label33);
        this.flowLayoutPanel11.Location = new Point(0, 0);
        this.flowLayoutPanel11.Margin = new Padding(0);
        this.flowLayoutPanel11.Name = "flowLayoutPanel11";
        this.flowLayoutPanel11.Size = new Size(134, 206);
        this.flowLayoutPanel11.TabIndex = 108;
        this.label38.AutoSize = true;
        this.label38.Location = new Point(3, 3);
        this.label38.Margin = new Padding(3);
        this.label38.Name = "label38";
        this.label38.Size = new Size(99, 13);
        this.label38.TabIndex = 103;
        this.label38.Text = "Overall Colony Cost";
        this.label24.AutoSize = true;
        this.label24.Location = new Point(3, 22);
        this.label24.Margin = new Padding(3);
        this.label24.Name = "label24";
        this.label24.Padding = new Padding(0, 2, 5, 0);
        this.label24.Size = new Size(102, 15);
        this.label24.TabIndex = 96 /*0x60*/;
        this.label24.Text = "Acceptable Gravity";
        this.label25.AutoSize = true;
        this.label25.Location = new Point(3, 43);
        this.label25.Margin = new Padding(3);
        this.label25.Name = "label25";
        this.label25.Padding = new Padding(0, 2, 5, 0);
        this.label25.Size = new Size(105, 15);
        this.label25.TabIndex = 97;
        this.label25.Text = "Temperature Factor";
        this.label27.AutoSize = true;
        this.label27.Location = new Point(3, 64 /*0x40*/);
        this.label27.Margin = new Padding(3);
        this.label27.Name = "label27";
        this.label27.Padding = new Padding(0, 2, 5, 0);
        this.label27.Size = new Size(122, 15);
        this.label27.TabIndex = 99;
        this.label27.Text = "Breathable Atmosphere";
        this.label26.AutoSize = true;
        this.label26.Location = new Point(3, 85);
        this.label26.Margin = new Padding(3);
        this.label26.Name = "label26";
        this.label26.Padding = new Padding(0, 2, 5, 0);
        this.label26.Size = new Size(123, 15);
        this.label26.TabIndex = 98;
        this.label26.Text = "Dangerous Atmosphere";
        this.label28.AutoSize = true;
        this.label28.Location = new Point(3, 106);
        this.label28.Margin = new Padding(3);
        this.label28.Name = "label28";
        this.label28.Padding = new Padding(0, 2, 5, 0);
        this.label28.Size = new Size(114, 15);
        this.label28.TabIndex = 100;
        this.label28.Text = "Atmospheric Pressure";
        this.label30.AutoSize = true;
        this.label30.Location = new Point(3, 127);
        this.label30.Margin = new Padding(3);
        this.label30.Name = "label30";
        this.label30.Padding = new Padding(0, 2, 5, 0);
        this.label30.Size = new Size(117, 15);
        this.label30.TabIndex = 102;
        this.label30.Text = "Atmosphere Retention";
        this.label29.AutoSize = true;
        this.label29.Location = new Point(3, 148);
        this.label29.Margin = new Padding(3);
        this.label29.Name = "label29";
        this.label29.Padding = new Padding(0, 2, 5, 0);
        this.label29.Size = new Size(87, 15);
        this.label29.TabIndex = 101;
        this.label29.Text = "Water Available";
        this.label32.AutoSize = true;
        this.label32.Location = new Point(3, 169);
        this.label32.Margin = new Padding(3);
        this.label32.Name = "label32";
        this.label32.Padding = new Padding(0, 2, 5, 0);
        this.label32.Size = new Size(117, 15);
        this.label32.TabIndex = 104;
        this.label32.Text = "Perihelion Colony Cost";
        this.label33.AutoSize = true;
        this.label33.Location = new Point(3, 190);
        this.label33.Margin = new Padding(3);
        this.label33.Name = "label33";
        this.label33.Padding = new Padding(0, 2, 5, 0);
        this.label33.Size = new Size(112 /*0x70*/, 15);
        this.label33.TabIndex = 105;
        this.label33.Text = "Aphelion Colony Cost";
        this.flowLayoutPanel12.Controls.Add(this.lblColonyCost);
        this.flowLayoutPanel12.Controls.Add(this.lblCCGravity);
        this.flowLayoutPanel12.Controls.Add(this.lblCCTemp);
        this.flowLayoutPanel12.Controls.Add(this.lblBreathable);
        this.flowLayoutPanel12.Controls.Add(this.lblDangerous);
        this.flowLayoutPanel12.Controls.Add(this.lblMaxPressure);
        this.flowLayoutPanel12.Controls.Add(this.lblRetention);
        this.flowLayoutPanel12.Controls.Add(this.lblWater);
        this.flowLayoutPanel12.Controls.Add(this.lblPerihelionCC);
        this.flowLayoutPanel12.Controls.Add(this.lblAphelionCC);
        this.flowLayoutPanel12.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel12.Location = new Point(134, 0);
        this.flowLayoutPanel12.Margin = new Padding(0);
        this.flowLayoutPanel12.Name = "flowLayoutPanel12";
        this.flowLayoutPanel12.Size = new Size(63 /*0x3F*/, 208 /*0xD0*/);
        this.flowLayoutPanel12.TabIndex = 109;
        this.lblColonyCost.AutoSize = true;
        this.lblColonyCost.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblColonyCost.Location = new Point(3, 4);
        this.lblColonyCost.Margin = new Padding(3, 4, 3, 3);
        this.lblColonyCost.Name = "lblColonyCost";
        this.lblColonyCost.Size = new Size(13, 13);
        this.lblColonyCost.TabIndex = 99;
        this.lblColonyCost.Text = "0";
        this.lblColonyCost.TextAlign = ContentAlignment.MiddleCenter;
        this.lblCCGravity.AutoSize = true;
        this.lblCCGravity.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblCCGravity.Location = new Point(3, 25);
        this.lblCCGravity.Margin = new Padding(3, 5, 3, 3);
        this.lblCCGravity.Name = "lblCCGravity";
        this.lblCCGravity.Padding = new Padding(0, 0, 5, 0);
        this.lblCCGravity.Size = new Size(18, 13);
        this.lblCCGravity.TabIndex = 100;
        this.lblCCGravity.Text = "0";
        this.lblCCGravity.TextAlign = ContentAlignment.MiddleCenter;
        this.lblCCTemp.AutoSize = true;
        this.lblCCTemp.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblCCTemp.Location = new Point(3, 46);
        this.lblCCTemp.Margin = new Padding(3, 5, 3, 3);
        this.lblCCTemp.Name = "lblCCTemp";
        this.lblCCTemp.Padding = new Padding(0, 0, 5, 0);
        this.lblCCTemp.Size = new Size(18, 13);
        this.lblCCTemp.TabIndex = 101;
        this.lblCCTemp.Text = "0";
        this.lblCCTemp.TextAlign = ContentAlignment.MiddleCenter;
        this.lblBreathable.AutoSize = true;
        this.lblBreathable.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblBreathable.Location = new Point(3, 67);
        this.lblBreathable.Margin = new Padding(3, 5, 3, 3);
        this.lblBreathable.Name = "lblBreathable";
        this.lblBreathable.Padding = new Padding(0, 0, 5, 0);
        this.lblBreathable.Size = new Size(18, 13);
        this.lblBreathable.TabIndex = 102;
        this.lblBreathable.Text = "0";
        this.lblBreathable.TextAlign = ContentAlignment.MiddleCenter;
        this.lblDangerous.AutoSize = true;
        this.lblDangerous.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblDangerous.Location = new Point(3, 88);
        this.lblDangerous.Margin = new Padding(3, 5, 3, 3);
        this.lblDangerous.Name = "lblDangerous";
        this.lblDangerous.Padding = new Padding(0, 0, 5, 0);
        this.lblDangerous.Size = new Size(18, 13);
        this.lblDangerous.TabIndex = 103;
        this.lblDangerous.Text = "0";
        this.lblDangerous.TextAlign = ContentAlignment.MiddleCenter;
        this.lblDangerous.Click += this.lblDangerous_Click;
        this.lblMaxPressure.AutoSize = true;
        this.lblMaxPressure.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblMaxPressure.Location = new Point(3, 109);
        this.lblMaxPressure.Margin = new Padding(3, 5, 3, 3);
        this.lblMaxPressure.Name = "lblMaxPressure";
        this.lblMaxPressure.Padding = new Padding(0, 0, 5, 0);
        this.lblMaxPressure.Size = new Size(18, 13);
        this.lblMaxPressure.TabIndex = 104;
        this.lblMaxPressure.Text = "0";
        this.lblMaxPressure.TextAlign = ContentAlignment.MiddleCenter;
        this.lblRetention.AutoSize = true;
        this.lblRetention.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblRetention.Location = new Point(3, 130);
        this.lblRetention.Margin = new Padding(3, 5, 3, 3);
        this.lblRetention.Name = "lblRetention";
        this.lblRetention.Padding = new Padding(0, 0, 5, 0);
        this.lblRetention.Size = new Size(18, 13);
        this.lblRetention.TabIndex = 105;
        this.lblRetention.Text = "0";
        this.lblRetention.TextAlign = ContentAlignment.MiddleCenter;
        this.lblWater.AutoSize = true;
        this.lblWater.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblWater.Location = new Point(3, 151);
        this.lblWater.Margin = new Padding(3, 5, 3, 3);
        this.lblWater.Name = "lblWater";
        this.lblWater.Padding = new Padding(0, 0, 5, 0);
        this.lblWater.Size = new Size(18, 13);
        this.lblWater.TabIndex = 106;
        this.lblWater.Text = "0";
        this.lblWater.TextAlign = ContentAlignment.MiddleCenter;
        this.lblPerihelionCC.AutoSize = true;
        this.lblPerihelionCC.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblPerihelionCC.Location = new Point(3, 172);
        this.lblPerihelionCC.Margin = new Padding(3, 5, 3, 3);
        this.lblPerihelionCC.Name = "lblPerihelionCC";
        this.lblPerihelionCC.Padding = new Padding(0, 0, 5, 0);
        this.lblPerihelionCC.Size = new Size(18, 13);
        this.lblPerihelionCC.TabIndex = 107;
        this.lblPerihelionCC.Text = "0";
        this.lblPerihelionCC.TextAlign = ContentAlignment.MiddleCenter;
        this.lblAphelionCC.AutoSize = true;
        this.lblAphelionCC.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblAphelionCC.Location = new Point(3, 192 /*0xC0*/);
        this.lblAphelionCC.Margin = new Padding(3, 4, 3, 3);
        this.lblAphelionCC.Name = "lblAphelionCC";
        this.lblAphelionCC.Size = new Size(13, 13);
        this.lblAphelionCC.TabIndex = 108;
        this.lblAphelionCC.Text = "0";
        this.lblAphelionCC.TextAlign = ContentAlignment.MiddleCenter;
        this.cmdRenameSystem.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameSystem.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRenameSystem.Location = new Point(0, 0);
        this.cmdRenameSystem.Margin = new Padding(0);
        this.cmdRenameSystem.Name = "cmdRenameSystem";
        this.cmdRenameSystem.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameSystem.TabIndex = 113;
        this.cmdRenameSystem.Tag = "1200";
        this.cmdRenameSystem.Text = "Rename System";
        this.cmdRenameSystem.UseVisualStyleBackColor = false;
        this.cmdRenameSystem.Click += this.cmdRenameSystem_Click;
        this.lstvJP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvJP.BorderStyle = BorderStyle.FixedSingle;
        this.lstvJP.Columns.AddRange(new ColumnHeader[4]
        {
            this.columnHeader_43,
            this.columnHeader_44,
            this.columnHeader_45,
            this.columnHeader_46
        });
        this.lstvJP.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvJP.FullRowSelect = true;
        this.lstvJP.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvJP.HideSelection = false;
        this.lstvJP.Location = new Point(0, 0);
        this.lstvJP.Margin = new Padding(0, 0, 3, 0);
        this.lstvJP.Name = "lstvJP";
        this.lstvJP.Size = new Size(315, 212);
        this.lstvJP.TabIndex = 114;
        this.lstvJP.UseCompatibleStateImageBehavior = false;
        this.lstvJP.View = View.Details;
        this.lstvJP.SelectedIndexChanged += this.lstvJP_SelectedIndexChanged;
        this.columnHeader_43.Width = 40;
        this.columnHeader_46.Width = 150;
        this.cmdRenameBody.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameBody.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRenameBody.Location = new Point(192 /*0xC0*/, 0);
        this.cmdRenameBody.Margin = new Padding(0);
        this.cmdRenameBody.Name = "cmdRenameBody";
        this.cmdRenameBody.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameBody.TabIndex = 115;
        this.cmdRenameBody.Tag = "1200";
        this.cmdRenameBody.Text = "Rename Body";
        this.cmdRenameBody.UseVisualStyleBackColor = false;
        this.cmdRenameBody.Click += this.cmdRenameBody_Click;
        this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRaces.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboRaces.FormattingEnabled = true;
        this.cboRaces.Location = new Point(2, 3);
        this.cboRaces.Margin = new Padding(3, 3, 3, 0);
        this.cboRaces.Name = "cboRaces";
        this.cboRaces.Size = new Size(176 /*0xB0*/, 21);
        this.cboRaces.TabIndex = 116;
        this.cboRaces.SelectedIndexChanged += this.cboRaces_SelectedIndexChanged;
        this.cmdAddColony.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddColony.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAddColony.Location = new Point(480, 0);
        this.cmdAddColony.Margin = new Padding(0);
        this.cmdAddColony.Name = "cmdAddColony";
        this.cmdAddColony.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddColony.TabIndex = 117;
        this.cmdAddColony.Tag = "1200";
        this.cmdAddColony.Text = "Create Colony";
        this.cmdAddColony.UseVisualStyleBackColor = false;
        this.cmdAddColony.Click += this.cmdAddColony_Click;
        this.cmdDeleteSystem.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteSystem.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteSystem.Location = new Point(672, 0);
        this.cmdDeleteSystem.Margin = new Padding(0);
        this.cmdDeleteSystem.Name = "cmdDeleteSystem";
        this.cmdDeleteSystem.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteSystem.TabIndex = 118;
        this.cmdDeleteSystem.Tag = "1200";
        this.cmdDeleteSystem.Text = "Delete System";
        this.cmdDeleteSystem.UseVisualStyleBackColor = false;
        this.cmdDeleteSystem.Click += this.cmdDeleteSystem_Click;
        this.flpSM.BorderStyle = BorderStyle.FixedSingle;
        this.flpSM.Controls.Add(this.cmdCreateRace);
        this.flpSM.Controls.Add(this.cmdSwarm);
        this.flpSM.Controls.Add(this.cmdCreateSystem);
        this.flpSM.Controls.Add(this.cmdCreateHabitableSystem);
        this.flpSM.Controls.Add(this.cmdAddNewStar);
        this.flpSM.Controls.Add(this.cmdChangeStar);
        this.flpSM.Controls.Add(this.cmdAddPlanet);
        this.flpSM.Controls.Add(this.cmdModifyBody);
        this.flpSM.Controls.Add(this.cmdAddMoons);
        this.flpSM.Controls.Add(this.cmdAddLGP);
        this.flpSM.Controls.Add(this.cmdDeleteStar);
        this.flpSM.Controls.Add(this.cmdDeleteSystemBody);
        this.flpSM.Controls.Add(this.cmdDeleteBelt);
        this.flpSM.Controls.Add(this.cmdDeleteLagrange);
        this.flpSM.Location = new Point(1225, 0);
        this.flpSM.Margin = new Padding(3, 0, 3, 0);
        this.flpSM.Name = "flpSM";
        this.flpSM.Size = new Size(195, 212);
        this.flpSM.TabIndex = 119;
        this.cmdCreateRace.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreateRace.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreateRace.Location = new Point(0, 0);
        this.cmdCreateRace.Margin = new Padding(0);
        this.cmdCreateRace.Name = "cmdCreateRace";
        this.cmdCreateRace.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreateRace.TabIndex = 130;
        this.cmdCreateRace.Tag = "1200";
        this.cmdCreateRace.Text = "Create Race";
        this.cmdCreateRace.UseVisualStyleBackColor = false;
        this.cmdCreateRace.Click += this.cmdCreateRace_Click;
        this.cmdSwarm.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSwarm.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSwarm.Location = new Point(96 /*0x60*/, 0);
        this.cmdSwarm.Margin = new Padding(0);
        this.cmdSwarm.Name = "cmdSwarm";
        this.cmdSwarm.Size = new Size(96 /*0x60*/, 30);
        this.cmdSwarm.TabIndex = 131;
        this.cmdSwarm.Tag = "1200";
        this.cmdSwarm.Text = "Create Swarm";
        this.cmdSwarm.UseVisualStyleBackColor = false;
        this.cmdSwarm.Click += this.cmdSwarm_Click;
        this.cmdCreateSystem.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreateSystem.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreateSystem.Location = new Point(0, 30);
        this.cmdCreateSystem.Margin = new Padding(0);
        this.cmdCreateSystem.Name = "cmdCreateSystem";
        this.cmdCreateSystem.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreateSystem.TabIndex = 129;
        this.cmdCreateSystem.Tag = "1200";
        this.cmdCreateSystem.Text = "Create System";
        this.cmdCreateSystem.UseVisualStyleBackColor = false;
        this.cmdCreateSystem.Click += this.cmdCreateSystem_Click;
        this.cmdCreateHabitableSystem.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreateHabitableSystem.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreateHabitableSystem.Location = new Point(96 /*0x60*/, 30);
        this.cmdCreateHabitableSystem.Margin = new Padding(0);
        this.cmdCreateHabitableSystem.Name = "cmdCreateHabitableSystem";
        this.cmdCreateHabitableSystem.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreateHabitableSystem.TabIndex = 143;
        this.cmdCreateHabitableSystem.Tag = "1200";
        this.cmdCreateHabitableSystem.Text = "Create Habitable";
        this.cmdCreateHabitableSystem.UseVisualStyleBackColor = false;
        this.cmdCreateHabitableSystem.Click += this.cmdCreateHabitableSystem_Click;
        this.cmdAddNewStar.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddNewStar.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAddNewStar.Location = new Point(0, 60);
        this.cmdAddNewStar.Margin = new Padding(0);
        this.cmdAddNewStar.Name = "cmdAddNewStar";
        this.cmdAddNewStar.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddNewStar.TabIndex = 135;
        this.cmdAddNewStar.Tag = "1200";
        this.cmdAddNewStar.Text = "Add Star";
        this.cmdAddNewStar.UseVisualStyleBackColor = false;
        this.cmdAddNewStar.Click += this.cmdAddNewStar_Click;
        this.cmdChangeStar.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdChangeStar.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdChangeStar.Location = new Point(96 /*0x60*/, 60);
        this.cmdChangeStar.Margin = new Padding(0);
        this.cmdChangeStar.Name = "cmdChangeStar";
        this.cmdChangeStar.Size = new Size(96 /*0x60*/, 30);
        this.cmdChangeStar.TabIndex = 136;
        this.cmdChangeStar.Tag = "1200";
        this.cmdChangeStar.Text = "Modify Star";
        this.cmdChangeStar.UseVisualStyleBackColor = false;
        this.cmdChangeStar.Click += this.cmdChangeStar_Click;
        this.cmdAddPlanet.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddPlanet.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAddPlanet.Location = new Point(0, 90);
        this.cmdAddPlanet.Margin = new Padding(0);
        this.cmdAddPlanet.Name = "cmdAddPlanet";
        this.cmdAddPlanet.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddPlanet.TabIndex = 134;
        this.cmdAddPlanet.Tag = "1200";
        this.cmdAddPlanet.Text = "Add Body";
        this.cmdAddPlanet.UseVisualStyleBackColor = false;
        this.cmdAddPlanet.Click += this.cmdAddPlanet_Click;
        this.cmdModifyBody.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdModifyBody.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdModifyBody.Location = new Point(96 /*0x60*/, 90);
        this.cmdModifyBody.Margin = new Padding(0);
        this.cmdModifyBody.Name = "cmdModifyBody";
        this.cmdModifyBody.Size = new Size(96 /*0x60*/, 30);
        this.cmdModifyBody.TabIndex = 133;
        this.cmdModifyBody.Tag = "1200";
        this.cmdModifyBody.Text = "Modify Body";
        this.cmdModifyBody.UseVisualStyleBackColor = false;
        this.cmdModifyBody.Click += this.cmdModifyBody_Click;
        this.cmdAddMoons.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddMoons.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAddMoons.Location = new Point(0, 120);
        this.cmdAddMoons.Margin = new Padding(0);
        this.cmdAddMoons.Name = "cmdAddMoons";
        this.cmdAddMoons.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddMoons.TabIndex = 139;
        this.cmdAddMoons.Tag = "1200";
        this.cmdAddMoons.Text = "Add Moons";
        this.cmdAddMoons.UseVisualStyleBackColor = false;
        this.cmdAddMoons.Click += this.cmdAddMoons_Click;
        this.cmdAddLGP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddLGP.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAddLGP.Location = new Point(96 /*0x60*/, 120);
        this.cmdAddLGP.Margin = new Padding(0);
        this.cmdAddLGP.Name = "cmdAddLGP";
        this.cmdAddLGP.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddLGP.TabIndex = 140;
        this.cmdAddLGP.Tag = "1200";
        this.cmdAddLGP.Text = "Add Lagrange";
        this.cmdAddLGP.UseVisualStyleBackColor = false;
        this.cmdAddLGP.Click += this.cmdAddLGP_Click;
        this.cmdDeleteStar.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteStar.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteStar.Location = new Point(0, 150);
        this.cmdDeleteStar.Margin = new Padding(0);
        this.cmdDeleteStar.Name = "cmdDeleteStar";
        this.cmdDeleteStar.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteStar.TabIndex = 137;
        this.cmdDeleteStar.Tag = "1200";
        this.cmdDeleteStar.Text = "Delete Star";
        this.cmdDeleteStar.UseVisualStyleBackColor = false;
        this.cmdDeleteStar.Click += this.cmdDeleteStar_Click;
        this.cmdDeleteSystemBody.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteSystemBody.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteSystemBody.Location = new Point(96 /*0x60*/, 150);
        this.cmdDeleteSystemBody.Margin = new Padding(0);
        this.cmdDeleteSystemBody.Name = "cmdDeleteSystemBody";
        this.cmdDeleteSystemBody.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteSystemBody.TabIndex = 138;
        this.cmdDeleteSystemBody.Tag = "1200";
        this.cmdDeleteSystemBody.Text = "Delete Body";
        this.cmdDeleteSystemBody.UseVisualStyleBackColor = false;
        this.cmdDeleteSystemBody.Click += this.cmdDeleteSystemBody_Click;
        this.cmdDeleteBelt.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteBelt.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteBelt.Location = new Point(0, 180);
        this.cmdDeleteBelt.Margin = new Padding(0);
        this.cmdDeleteBelt.Name = "cmdDeleteBelt";
        this.cmdDeleteBelt.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteBelt.TabIndex = 141;
        this.cmdDeleteBelt.Tag = "1200";
        this.cmdDeleteBelt.Text = "Delete Asteroids";
        this.cmdDeleteBelt.UseVisualStyleBackColor = false;
        this.cmdDeleteBelt.Click += this.cmdDeleteBelt_Click;
        this.cmdDeleteLagrange.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteLagrange.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteLagrange.Location = new Point(96 /*0x60*/, 180);
        this.cmdDeleteLagrange.Margin = new Padding(0);
        this.cmdDeleteLagrange.Name = "cmdDeleteLagrange";
        this.cmdDeleteLagrange.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteLagrange.TabIndex = 142;
        this.cmdDeleteLagrange.Tag = "1200";
        this.cmdDeleteLagrange.Text = "Delete Lagrange";
        this.cmdDeleteLagrange.UseVisualStyleBackColor = false;
        this.cmdDeleteLagrange.Click += this.cmdDeleteLagrange_Click;
        this.cmdJPSurvey.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdJPSurvey.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdJPSurvey.Location = new Point(0, 0);
        this.cmdJPSurvey.Margin = new Padding(0);
        this.cmdJPSurvey.Name = "cmdJPSurvey";
        this.cmdJPSurvey.Size = new Size(96 /*0x60*/, 30);
        this.cmdJPSurvey.TabIndex = 124;
        this.cmdJPSurvey.Tag = "1200";
        this.cmdJPSurvey.Text = "Full Grav Survey";
        this.cmdJPSurvey.UseVisualStyleBackColor = false;
        this.cmdJPSurvey.Click += this.cmdJPSurvey_Click;
        this.cmdAllBodySurvey.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAllBodySurvey.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAllBodySurvey.Location = new Point(192 /*0xC0*/, 0);
        this.cmdAllBodySurvey.Margin = new Padding(0);
        this.cmdAllBodySurvey.Name = "cmdAllBodySurvey";
        this.cmdAllBodySurvey.Size = new Size(96 /*0x60*/, 30);
        this.cmdAllBodySurvey.TabIndex = 120;
        this.cmdAllBodySurvey.Tag = "1200";
        this.cmdAllBodySurvey.Text = "Full Geo Survey";
        this.cmdAllBodySurvey.UseVisualStyleBackColor = false;
        this.cmdAllBodySurvey.Click += this.cmdAllBodySurvey_Click;
        this.cmdNoBodySurvey.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdNoBodySurvey.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdNoBodySurvey.Location = new Point(288, 0);
        this.cmdNoBodySurvey.Margin = new Padding(0);
        this.cmdNoBodySurvey.Name = "cmdNoBodySurvey";
        this.cmdNoBodySurvey.Size = new Size(96 /*0x60*/, 30);
        this.cmdNoBodySurvey.TabIndex = 121;
        this.cmdNoBodySurvey.Tag = "1200";
        this.cmdNoBodySurvey.Text = "No Geo Survey";
        this.cmdNoBodySurvey.UseVisualStyleBackColor = false;
        this.cmdNoBodySurvey.Click += this.cmdNoBodySurvey_Click;
        this.cmdBodySurvey.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdBodySurvey.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdBodySurvey.Location = new Point(0, 0);
        this.cmdBodySurvey.Margin = new Padding(0);
        this.cmdBodySurvey.Name = "cmdBodySurvey";
        this.cmdBodySurvey.Size = new Size(96 /*0x60*/, 30);
        this.cmdBodySurvey.TabIndex = 119;
        this.cmdBodySurvey.Tag = "1200";
        this.cmdBodySurvey.Text = "Survey Body";
        this.cmdBodySurvey.UseVisualStyleBackColor = false;
        this.cmdBodySurvey.Click += this.cmdBodySurvey_Click;
        this.cmdHWMinerals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdHWMinerals.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdHWMinerals.Location = new Point(0, 60);
        this.cmdHWMinerals.Margin = new Padding(0);
        this.cmdHWMinerals.Name = "cmdHWMinerals";
        this.cmdHWMinerals.Size = new Size(96 /*0x60*/, 30);
        this.cmdHWMinerals.TabIndex = 123;
        this.cmdHWMinerals.Tag = "1200";
        this.cmdHWMinerals.Text = "HW Minerals";
        this.cmdHWMinerals.UseVisualStyleBackColor = false;
        this.cmdHWMinerals.Click += this.cmdHWMinerals_Click;
        this.cmdAddJumpPoint.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddJumpPoint.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAddJumpPoint.Location = new Point(0, 60);
        this.cmdAddJumpPoint.Margin = new Padding(0);
        this.cmdAddJumpPoint.Name = "cmdAddJumpPoint";
        this.cmdAddJumpPoint.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddJumpPoint.TabIndex = 125;
        this.cmdAddJumpPoint.Tag = "1200";
        this.cmdAddJumpPoint.Text = "Add Jump Point";
        this.cmdAddJumpPoint.UseVisualStyleBackColor = false;
        this.cmdAddJumpPoint.Click += this.cmdAddJumpPoint_Click;
        this.cmdDeleteJP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteJP.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteJP.Location = new Point(0, 90);
        this.cmdDeleteJP.Margin = new Padding(0);
        this.cmdDeleteJP.Name = "cmdDeleteJP";
        this.cmdDeleteJP.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteJP.TabIndex = 126;
        this.cmdDeleteJP.Tag = "1200";
        this.cmdDeleteJP.Text = "Del Jump Point";
        this.cmdDeleteJP.UseVisualStyleBackColor = false;
        this.cmdDeleteJP.Click += this.cmdDeleteJP_Click;
        this.cmdRandomRuin.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRandomRuin.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRandomRuin.Location = new Point(0, 30);
        this.cmdRandomRuin.Margin = new Padding(0);
        this.cmdRandomRuin.Name = "cmdRandomRuin";
        this.cmdRandomRuin.Size = new Size(96 /*0x60*/, 30);
        this.cmdRandomRuin.TabIndex = 128 /*0x80*/;
        this.cmdRandomRuin.Tag = "1200";
        this.cmdRandomRuin.Text = "Create Ruin";
        this.cmdRandomRuin.UseVisualStyleBackColor = false;
        this.cmdRandomRuin.Click += this.cmdRandomRuin_Click;
        this.flowLayoutPanel9.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel9.Controls.Add(this.chkMinDep);
        this.flowLayoutPanel9.Controls.Add(this.chkUnsurveyed);
        this.flowLayoutPanel9.Controls.Add(this.chkTeamSurvey);
        this.flowLayoutPanel9.Controls.Add(this.chkOrbital);
        this.flowLayoutPanel9.Controls.Add(this.chkMaxCC);
        this.flowLayoutPanel9.Location = new Point(870, 121);
        this.flowLayoutPanel9.Name = "flowLayoutPanel9";
        this.flowLayoutPanel9.Size = new Size(552, 28);
        this.flowLayoutPanel9.TabIndex = 120;
        this.chkMinDep.AutoSize = true;
        this.chkMinDep.Checked = true;
        this.chkMinDep.CheckState = CheckState.Checked;
        this.chkMinDep.Location = new Point(3, 3);
        this.chkMinDep.Name = "chkMinDep";
        this.chkMinDep.Padding = new Padding(3, 1, 0, 0);
        this.chkMinDep.Size = new Size(68, 18);
        this.chkMinDep.TabIndex = 0;
        this.chkMinDep.Text = "Minerals";
        this.chkMinDep.UseVisualStyleBackColor = true;
        this.chkMinDep.CheckedChanged += this.chkMaxCC_CheckedChanged;
        this.chkUnsurveyed.AutoSize = true;
        this.chkUnsurveyed.Checked = true;
        this.chkUnsurveyed.CheckState = CheckState.Checked;
        this.chkUnsurveyed.Location = new Point(77, 3);
        this.chkUnsurveyed.Name = "chkUnsurveyed";
        this.chkUnsurveyed.Padding = new Padding(3, 1, 0, 0);
        this.chkUnsurveyed.Size = new Size(79, 18);
        this.chkUnsurveyed.TabIndex = 1;
        this.chkUnsurveyed.Text = "No Survey";
        this.chkUnsurveyed.UseVisualStyleBackColor = true;
        this.chkUnsurveyed.CheckedChanged += this.chkMaxCC_CheckedChanged;
        this.chkTeamSurvey.AutoSize = true;
        this.chkTeamSurvey.Checked = true;
        this.chkTeamSurvey.CheckState = CheckState.Checked;
        this.chkTeamSurvey.Location = new Point(162, 3);
        this.chkTeamSurvey.Name = "chkTeamSurvey";
        this.chkTeamSurvey.Padding = new Padding(3, 1, 0, 0);
        this.chkTeamSurvey.Size = new Size(144 /*0x90*/, 18);
        this.chkTeamSurvey.TabIndex = 2;
        this.chkTeamSurvey.Text = "Ground Survey Potential";
        this.chkTeamSurvey.UseVisualStyleBackColor = true;
        this.chkTeamSurvey.CheckedChanged += this.chkMaxCC_CheckedChanged;
        this.chkOrbital.AutoSize = true;
        this.chkOrbital.Location = new Point(312, 3);
        this.chkOrbital.Name = "chkOrbital";
        this.chkOrbital.Padding = new Padding(3, 1, 0, 0);
        this.chkOrbital.Size = new Size(82, 18);
        this.chkOrbital.TabIndex = 4;
        this.chkOrbital.Text = "OM Eligible";
        this.chkOrbital.UseVisualStyleBackColor = true;
        this.chkOrbital.CheckedChanged += this.chkMaxCC_CheckedChanged;
        this.chkMaxCC.AutoSize = true;
        this.chkMaxCC.Location = new Point(400, 3);
        this.chkMaxCC.Name = "chkMaxCC";
        this.chkMaxCC.Padding = new Padding(3, 1, 0, 0);
        this.chkMaxCC.Size = new Size(134, 18);
        this.chkMaxCC.TabIndex = 3;
        this.chkMaxCC.Text = "Show Max CC / Temp";
        this.chkMaxCC.UseVisualStyleBackColor = true;
        this.chkMaxCC.CheckedChanged += this.chkMaxCC_CheckedChanged;
        this.cmdExploreJP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdExploreJP.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdExploreJP.Location = new Point(0, 30);
        this.cmdExploreJP.Margin = new Padding(0);
        this.cmdExploreJP.Name = "cmdExploreJP";
        this.cmdExploreJP.Size = new Size(96 /*0x60*/, 30);
        this.cmdExploreJP.TabIndex = 130;
        this.cmdExploreJP.Tag = "1200";
        this.cmdExploreJP.Text = "Explore JP";
        this.cmdExploreJP.UseVisualStyleBackColor = false;
        this.cmdExploreJP.Click += this.cmdExploreJP_Click;
        this.flpButtonRow.Controls.Add(this.cmdRenameSystem);
        this.flpButtonRow.Controls.Add(this.cmdSelectName);
        this.flpButtonRow.Controls.Add(this.cmdRenameBody);
        this.flpButtonRow.Controls.Add(this.cmdRenameSystemAll);
        this.flpButtonRow.Controls.Add(this.cmdRenameBodyAll);
        this.flpButtonRow.Controls.Add(this.cmdAddColony);
        this.flpButtonRow.Controls.Add(this.cmdBanBody);
        this.flpButtonRow.Controls.Add(this.cmdPotentialColonies);
        this.flpButtonRow.Controls.Add(this.cmdRestrictJP);
        this.flpButtonRow.Controls.Add(this.cmdWideView);
        this.flpButtonRow.Location = new Point(2, 826);
        this.flpButtonRow.Name = "flpButtonRow";
        this.flpButtonRow.Size = new Size(1410, 30);
        this.flpButtonRow.TabIndex = 131;
        this.cmdSelectName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSelectName.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSelectName.Location = new Point(96 /*0x60*/, 0);
        this.cmdSelectName.Margin = new Padding(0);
        this.cmdSelectName.Name = "cmdSelectName";
        this.cmdSelectName.Size = new Size(96 /*0x60*/, 30);
        this.cmdSelectName.TabIndex = 137;
        this.cmdSelectName.Tag = "1200";
        this.cmdSelectName.Text = "Select Name";
        this.cmdSelectName.UseVisualStyleBackColor = false;
        this.cmdSelectName.Click += this.cmdSelectName_Click;
        this.cmdRenameSystemAll.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameSystemAll.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRenameSystemAll.Location = new Point(288, 0);
        this.cmdRenameSystemAll.Margin = new Padding(0);
        this.cmdRenameSystemAll.Name = "cmdRenameSystemAll";
        this.cmdRenameSystemAll.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameSystemAll.TabIndex = 132;
        this.cmdRenameSystemAll.Tag = "1200";
        this.cmdRenameSystemAll.Text = "Rename Sys All";
        this.cmdRenameSystemAll.UseVisualStyleBackColor = false;
        this.cmdRenameSystemAll.Click += this.cmdRenameSystemAll_Click;
        this.cmdRenameBodyAll.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameBodyAll.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRenameBodyAll.Location = new Point(384, 0);
        this.cmdRenameBodyAll.Margin = new Padding(0);
        this.cmdRenameBodyAll.Name = "cmdRenameBodyAll";
        this.cmdRenameBodyAll.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameBodyAll.TabIndex = 133;
        this.cmdRenameBodyAll.Tag = "1200";
        this.cmdRenameBodyAll.Text = "Rename Body All";
        this.cmdRenameBodyAll.UseVisualStyleBackColor = false;
        this.cmdRenameBodyAll.Click += this.cmdRenameBodyAll_Click;
        this.cmdBanBody.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdBanBody.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdBanBody.Location = new Point(576, 0);
        this.cmdBanBody.Margin = new Padding(0);
        this.cmdBanBody.Name = "cmdBanBody";
        this.cmdBanBody.Size = new Size(96 /*0x60*/, 30);
        this.cmdBanBody.TabIndex = 136;
        this.cmdBanBody.Tag = "1200";
        this.cmdBanBody.Text = "Ban Body";
        this.cmdBanBody.UseVisualStyleBackColor = false;
        this.cmdBanBody.Click += this.cmdBanBody_Click;
        this.cmdPotentialColonies.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdPotentialColonies.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdPotentialColonies.Location = new Point(672, 0);
        this.cmdPotentialColonies.Margin = new Padding(0);
        this.cmdPotentialColonies.Name = "cmdPotentialColonies";
        this.cmdPotentialColonies.Size = new Size(96 /*0x60*/, 30);
        this.cmdPotentialColonies.TabIndex = 135;
        this.cmdPotentialColonies.Tag = "1200";
        this.cmdPotentialColonies.Text = "All System View";
        this.cmdPotentialColonies.UseVisualStyleBackColor = false;
        this.cmdPotentialColonies.Click += this.cmdPotentialColonies_Click;
        this.cmdRestrictJP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRestrictJP.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRestrictJP.Location = new Point(768 /*0x0300*/, 0);
        this.cmdRestrictJP.Margin = new Padding(0);
        this.cmdRestrictJP.Name = "cmdRestrictJP";
        this.cmdRestrictJP.Size = new Size(96 /*0x60*/, 30);
        this.cmdRestrictJP.TabIndex = 139;
        this.cmdRestrictJP.Tag = "1200";
        this.cmdRestrictJP.Text = "Restrict JP";
        this.cmdRestrictJP.UseVisualStyleBackColor = false;
        this.cmdRestrictJP.Click += this.cmdRestrictJP_Click;
        this.cmdWideView.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdWideView.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdWideView.Location = new Point(864, 0);
        this.cmdWideView.Margin = new Padding(0);
        this.cmdWideView.Name = "cmdWideView";
        this.cmdWideView.Size = new Size(96 /*0x60*/, 30);
        this.cmdWideView.TabIndex = 138;
        this.cmdWideView.Tag = "1200";
        this.cmdWideView.Text = "Wide View";
        this.cmdWideView.UseVisualStyleBackColor = false;
        this.cmdWideView.Click += this.cmdWideView_Click;
        this.cmdNameSolBodies.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdNameSolBodies.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdNameSolBodies.Location = new Point(576, 0);
        this.cmdNameSolBodies.Margin = new Padding(0);
        this.cmdNameSolBodies.Name = "cmdNameSolBodies";
        this.cmdNameSolBodies.Size = new Size(96 /*0x60*/, 30);
        this.cmdNameSolBodies.TabIndex = 134;
        this.cmdNameSolBodies.Tag = "1200";
        this.cmdNameSolBodies.Text = "Name Sol Bodies";
        this.cmdNameSolBodies.UseVisualStyleBackColor = false;
        this.cmdNameSolBodies.Click += this.cmdNameSolBodies_Click;
        this.cmdEnterJP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdEnterJP.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdEnterJP.Location = new Point(0, 0);
        this.cmdEnterJP.Margin = new Padding(0);
        this.cmdEnterJP.Name = "cmdEnterJP";
        this.cmdEnterJP.Size = new Size(96 /*0x60*/, 30);
        this.cmdEnterJP.TabIndex = 131;
        this.cmdEnterJP.Tag = "1200";
        this.cmdEnterJP.Text = "Enter JP";
        this.cmdEnterJP.UseVisualStyleBackColor = false;
        this.cmdEnterJP.Click += this.cmdEnterJP_Click;
        this.cmdMinText.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdMinText.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdMinText.Location = new Point(0, 180);
        this.cmdMinText.Margin = new Padding(0);
        this.cmdMinText.Name = "cmdMinText";
        this.cmdMinText.Size = new Size(96 /*0x60*/, 30);
        this.cmdMinText.TabIndex = 134;
        this.cmdMinText.Tag = "1200";
        this.cmdMinText.Text = "Min As Text";
        this.cmdMinText.UseVisualStyleBackColor = false;
        this.cmdMinText.Click += this.cmdMinText_Click;
        this.cmdJG.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdJG.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdJG.Location = new Point(0, 150);
        this.cmdJG.Margin = new Padding(0);
        this.cmdJG.Name = "cmdJG";
        this.cmdJG.Size = new Size(96 /*0x60*/, 30);
        this.cmdJG.TabIndex = 130;
        this.cmdJG.Tag = "1200";
        this.cmdJG.Text = "Stabilise JP";
        this.cmdJG.UseVisualStyleBackColor = false;
        this.cmdJG.Click += this.cmdJG_Click;
        this.flpDisplaySection.Controls.Add(this.lstvJP);
        this.flpDisplaySection.Controls.Add(this.flpJPs);
        this.flpDisplaySection.Controls.Add(this.flowLayoutPanel15);
        this.flpDisplaySection.Controls.Add(this.flpMinButtons);
        this.flpDisplaySection.Controls.Add(this.flpColonyCosts);
        this.flpDisplaySection.Controls.Add(this.lstvAtmosphere);
        this.flpDisplaySection.Controls.Add(this.flpSM);
        this.flpDisplaySection.Controls.Add(this.lstvColonyCosts);
        this.flpDisplaySection.Location = new Point(2, 610);
        this.flpDisplaySection.Name = "flpDisplaySection";
        this.flpDisplaySection.Size = new Size(1883, 212);
        this.flpDisplaySection.TabIndex = 132;
        this.flpDisplaySection.Paint += this.flpDisplaySection_Paint;
        this.flpJPs.BorderStyle = BorderStyle.FixedSingle;
        this.flpJPs.Controls.Add(this.cmdEnterJP);
        this.flpJPs.Controls.Add(this.cmdExploreJP);
        this.flpJPs.Controls.Add(this.cmdAddJumpPoint);
        this.flpJPs.Controls.Add(this.cmdDeleteJP);
        this.flpJPs.Controls.Add(this.cmdChangeJPLocation);
        this.flpJPs.Controls.Add(this.cmdJG);
        this.flpJPs.Controls.Add(this.cmdDeleteJG);
        this.flpJPs.Location = new Point(321, 0);
        this.flpJPs.Margin = new Padding(3, 0, 3, 0);
        this.flpJPs.Name = "flpJPs";
        this.flpJPs.Size = new Size(98, 212);
        this.flpJPs.TabIndex = 115;
        this.cmdChangeJPLocation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdChangeJPLocation.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdChangeJPLocation.Location = new Point(0, 120);
        this.cmdChangeJPLocation.Margin = new Padding(0);
        this.cmdChangeJPLocation.Name = "cmdChangeJPLocation";
        this.cmdChangeJPLocation.Size = new Size(96 /*0x60*/, 30);
        this.cmdChangeJPLocation.TabIndex = 132;
        this.cmdChangeJPLocation.Tag = "1200";
        this.cmdChangeJPLocation.Text = "Change Position";
        this.cmdChangeJPLocation.UseVisualStyleBackColor = false;
        this.cmdChangeJPLocation.Click += this.cmdChangeJPLocation_Click;
        this.cmdDeleteJG.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteJG.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteJG.Location = new Point(0, 180);
        this.cmdDeleteJG.Margin = new Padding(0);
        this.cmdDeleteJG.Name = "cmdDeleteJG";
        this.cmdDeleteJG.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteJG.TabIndex = 131;
        this.cmdDeleteJG.Tag = "1200";
        this.cmdDeleteJG.Text = "Destabilise JP";
        this.cmdDeleteJG.UseVisualStyleBackColor = false;
        this.cmdDeleteJG.Click += this.cmdDeleteJG_Click;
        this.flowLayoutPanel15.Controls.Add(this.lstvMinerals);
        this.flowLayoutPanel15.Location = new Point(425, 0);
        this.flowLayoutPanel15.Margin = new Padding(3, 0, 3, 0);
        this.flowLayoutPanel15.Name = "flowLayoutPanel15";
        this.flowLayoutPanel15.Size = new Size(230, 212);
        this.flowLayoutPanel15.TabIndex = 133;
        this.flpMinButtons.BorderStyle = BorderStyle.FixedSingle;
        this.flpMinButtons.Controls.Add(this.cmdBodySurvey);
        this.flpMinButtons.Controls.Add(this.cmdRandomRuin);
        this.flpMinButtons.Controls.Add(this.cmdHWMinerals);
        this.flpMinButtons.Controls.Add(this.cmdNewMinerals);
        this.flpMinButtons.Controls.Add(this.cmdSpecify);
        this.flpMinButtons.Controls.Add(this.cmdRemoveMinerals);
        this.flpMinButtons.Controls.Add(this.cmdMinText);
        this.flpMinButtons.Location = new Point(661, 0);
        this.flpMinButtons.Margin = new Padding(3, 0, 3, 0);
        this.flpMinButtons.Name = "flpMinButtons";
        this.flpMinButtons.Size = new Size(98, 212);
        this.flpMinButtons.TabIndex = 116;
        this.flpMinButtons.Visible = false;
        this.cmdNewMinerals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdNewMinerals.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdNewMinerals.Location = new Point(0, 90);
        this.cmdNewMinerals.Margin = new Padding(0);
        this.cmdNewMinerals.Name = "cmdNewMinerals";
        this.cmdNewMinerals.Size = new Size(96 /*0x60*/, 30);
        this.cmdNewMinerals.TabIndex = 136;
        this.cmdNewMinerals.Tag = "1200";
        this.cmdNewMinerals.Text = "Redo Minerals";
        this.cmdNewMinerals.UseVisualStyleBackColor = false;
        this.cmdNewMinerals.Click += this.cmdNewMinerals_Click;
        this.cmdSpecify.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSpecify.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSpecify.Location = new Point(0, 120);
        this.cmdSpecify.Margin = new Padding(0);
        this.cmdSpecify.Name = "cmdSpecify";
        this.cmdSpecify.Size = new Size(96 /*0x60*/, 30);
        this.cmdSpecify.TabIndex = 129;
        this.cmdSpecify.Tag = "1200";
        this.cmdSpecify.Text = "Specify Minerals";
        this.cmdSpecify.UseVisualStyleBackColor = false;
        this.cmdSpecify.Click += this.cmdSpecify_Click;
        this.cmdRemoveMinerals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRemoveMinerals.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRemoveMinerals.Location = new Point(0, 150);
        this.cmdRemoveMinerals.Margin = new Padding(0);
        this.cmdRemoveMinerals.Name = "cmdRemoveMinerals";
        this.cmdRemoveMinerals.Size = new Size(96 /*0x60*/, 30);
        this.cmdRemoveMinerals.TabIndex = 135;
        this.cmdRemoveMinerals.Tag = "1200";
        this.cmdRemoveMinerals.Text = "Clear Minerals";
        this.cmdRemoveMinerals.UseVisualStyleBackColor = false;
        this.cmdRemoveMinerals.Click += this.cmdRemoveMinerals_Click;
        this.lstvAtmosphere.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvAtmosphere.BorderStyle = BorderStyle.FixedSingle;
        this.lstvAtmosphere.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_48,
            this.columnHeader_49,
            this.columnHeader_50
        });
        this.lstvAtmosphere.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvAtmosphere.FullRowSelect = true;
        this.lstvAtmosphere.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvAtmosphere.HideSelection = false;
        this.lstvAtmosphere.Location = new Point(969, 0);
        this.lstvAtmosphere.Margin = new Padding(3, 0, 3, 0);
        this.lstvAtmosphere.Name = "lstvAtmosphere";
        this.lstvAtmosphere.Size = new Size(250, 212);
        this.lstvAtmosphere.TabIndex = 133;
        this.lstvAtmosphere.UseCompatibleStateImageBehavior = false;
        this.lstvAtmosphere.View = View.Details;
        this.columnHeader_48.Width = 120;
        this.columnHeader_49.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_50.TextAlign = HorizontalAlignment.Right;
        this.lstvColonyCosts.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvColonyCosts.BorderStyle = BorderStyle.FixedSingle;
        this.lstvColonyCosts.Columns.AddRange(new ColumnHeader[13]
        {
            this.columnHeader_61,
            this.columnHeader_62,
            this.columnHeader_63,
            this.columnHeader_64,
            this.columnHeader_65,
            this.columnHeader_66,
            this.columnHeader_67,
            this.columnHeader_68,
            this.columnHeader_69,
            this.columnHeader_70,
            this.columnHeader_71,
            this.columnHeader_72,
            this.columnHeader_73
        });
        this.lstvColonyCosts.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvColonyCosts.FullRowSelect = true;
        this.lstvColonyCosts.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvColonyCosts.HideSelection = false;
        this.lstvColonyCosts.Location = new Point(1426, 0);
        this.lstvColonyCosts.Margin = new Padding(3, 0, 0, 0);
        this.lstvColonyCosts.Name = "lstvColonyCosts";
        this.lstvColonyCosts.Size = new Size(452, 212);
        this.lstvColonyCosts.TabIndex = 147;
        this.lstvColonyCosts.UseCompatibleStateImageBehavior = false;
        this.lstvColonyCosts.View = View.Details;
        this.lstvColonyCosts.SelectedIndexChanged += this.lstvColonyCosts_SelectedIndexChanged;
        this.columnHeader_61.Width = 50;
        this.columnHeader_62.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_62.Width = 50;
        this.columnHeader_63.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_63.Width = 50;
        this.columnHeader_64.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_64.Width = 50;
        this.columnHeader_65.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_65.Width = 50;
        this.columnHeader_66.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_66.Width = 50;
        this.columnHeader_67.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_67.Width = 50;
        this.columnHeader_68.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_68.Width = 50;
        this.columnHeader_69.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_69.Width = 50;
        this.columnHeader_70.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_70.Width = 50;
        this.columnHeader_71.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_71.Width = 50;
        this.columnHeader_72.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_72.Width = 50;
        this.columnHeader_73.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_73.Width = 50;
        this.flpSpecify.BorderStyle = BorderStyle.FixedSingle;
        this.flpSpecify.Controls.Add(this.flowLayoutPanel16);
        this.flpSpecify.Controls.Add(this.flowLayoutPanel17);
        this.flpSpecify.Controls.Add(this.flowLayoutPanel18);
        this.flpSpecify.Location = new Point(427, 610);
        this.flpSpecify.Margin = new Padding(0);
        this.flpSpecify.Name = "flpSpecify";
        this.flpSpecify.Size = new Size(230, 212);
        this.flpSpecify.TabIndex = 117;
        this.flpSpecify.Visible = false;
        this.flowLayoutPanel16.Controls.Add(this.label10);
        this.flowLayoutPanel16.Controls.Add(this.label14);
        this.flowLayoutPanel16.Controls.Add(this.label15);
        this.flowLayoutPanel16.Controls.Add(this.label16);
        this.flowLayoutPanel16.Controls.Add(this.label17);
        this.flowLayoutPanel16.Controls.Add(this.label18);
        this.flowLayoutPanel16.Controls.Add(this.label19);
        this.flowLayoutPanel16.Controls.Add(this.label20);
        this.flowLayoutPanel16.Controls.Add(this.label21);
        this.flowLayoutPanel16.Controls.Add(this.label22);
        this.flowLayoutPanel16.Controls.Add(this.label23);
        this.flowLayoutPanel16.Location = new Point(0, 0);
        this.flowLayoutPanel16.Margin = new Padding(0);
        this.flowLayoutPanel16.Name = "flowLayoutPanel16";
        this.flowLayoutPanel16.Size = new Size(70, 211);
        this.flowLayoutPanel16.TabIndex = 109;
        this.label10.AutoSize = true;
        this.label10.Location = new Point(3, 3);
        this.label10.Margin = new Padding(3, 3, 3, 2);
        this.label10.Name = "label10";
        this.label10.Size = new Size(52, 13);
        this.label10.TabIndex = 103;
        this.label10.Text = "Duranium";
        this.label14.AutoSize = true;
        this.label14.Location = new Point(3, 22);
        this.label14.Margin = new Padding(3, 4, 3, 2);
        this.label14.Name = "label14";
        this.label14.Size = new Size(61, 13);
        this.label14.TabIndex = 104;
        this.label14.Text = "Neutronium";
        this.label15.AutoSize = true;
        this.label15.Location = new Point(3, 41);
        this.label15.Margin = new Padding(3, 4, 3, 2);
        this.label15.Name = "label15";
        this.label15.Size = new Size(54, 13);
        this.label15.TabIndex = 105;
        this.label15.Text = "Corbomite";
        this.label16.AutoSize = true;
        this.label16.Location = new Point(3, 60);
        this.label16.Margin = new Padding(3, 4, 3, 2);
        this.label16.Name = "label16";
        this.label16.Size = new Size(50, 13);
        this.label16.TabIndex = 106;
        this.label16.Text = "Tritanium";
        this.label17.AutoSize = true;
        this.label17.Location = new Point(3, 79);
        this.label17.Margin = new Padding(3, 4, 3, 2);
        this.label17.Name = "label17";
        this.label17.Size = new Size(49, 13);
        this.label17.TabIndex = 107;
        this.label17.Text = "Boronide";
        this.label18.AutoSize = true;
        this.label18.Location = new Point(3, 98);
        this.label18.Margin = new Padding(3, 4, 3, 2);
        this.label18.Name = "label18";
        this.label18.Size = new Size(63 /*0x3F*/, 13);
        this.label18.TabIndex = 108;
        this.label18.Text = "Mercassium";
        this.label19.AutoSize = true;
        this.label19.Location = new Point(3, 117);
        this.label19.Margin = new Padding(3, 4, 3, 2);
        this.label19.Name = "label19";
        this.label19.Size = new Size(52, 13);
        this.label19.TabIndex = 109;
        this.label19.Text = "Vendarite";
        this.label20.AutoSize = true;
        this.label20.Location = new Point(3, 136);
        this.label20.Margin = new Padding(3, 4, 3, 2);
        this.label20.Name = "label20";
        this.label20.Size = new Size(39, 13);
        this.label20.TabIndex = 110;
        this.label20.Text = "Sorium";
        this.label21.AutoSize = true;
        this.label21.Location = new Point(3, 155);
        this.label21.Margin = new Padding(3, 4, 3, 2);
        this.label21.Name = "label21";
        this.label21.Size = new Size(42, 13);
        this.label21.TabIndex = 111;
        this.label21.Text = "Uridium";
        this.label22.AutoSize = true;
        this.label22.Location = new Point(3, 174);
        this.label22.Margin = new Padding(3, 4, 3, 2);
        this.label22.Name = "label22";
        this.label22.Size = new Size(59, 13);
        this.label22.TabIndex = 112 /*0x70*/;
        this.label22.Text = "Corumdium";
        this.label23.AutoSize = true;
        this.label23.Location = new Point(3, 193);
        this.label23.Margin = new Padding(3, 4, 3, 2);
        this.label23.Name = "label23";
        this.label23.Size = new Size(44, 13);
        this.label23.TabIndex = 113;
        this.label23.Text = "Gallicite";
        this.flowLayoutPanel17.Controls.Add(this.txtAmount1);
        this.flowLayoutPanel17.Controls.Add(this.txtAmount2);
        this.flowLayoutPanel17.Controls.Add(this.txtAmount3);
        this.flowLayoutPanel17.Controls.Add(this.txtAmount4);
        this.flowLayoutPanel17.Controls.Add(this.txtAmount5);
        this.flowLayoutPanel17.Controls.Add(this.txtAmount6);
        this.flowLayoutPanel17.Controls.Add(this.txtAmount7);
        this.flowLayoutPanel17.Controls.Add(this.txtAmount8);
        this.flowLayoutPanel17.Controls.Add(this.txtAmount9);
        this.flowLayoutPanel17.Controls.Add(this.txtAmount10);
        this.flowLayoutPanel17.Controls.Add(this.txtAmount11);
        this.flowLayoutPanel17.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel17.Location = new Point(73, 0);
        this.flowLayoutPanel17.Margin = new Padding(3, 0, 3, 0);
        this.flowLayoutPanel17.Name = "flowLayoutPanel17";
        this.flowLayoutPanel17.Size = new Size(99, 211);
        this.flowLayoutPanel17.TabIndex = 110;
        this.txtAmount1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAmount1.BorderStyle = BorderStyle.None;
        this.txtAmount1.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAmount1.Location = new Point(0, 2);
        this.txtAmount1.Margin = new Padding(0, 2, 0, 2);
        this.txtAmount1.Name = "txtAmount1";
        this.txtAmount1.Size = new Size(87, 13);
        this.txtAmount1.TabIndex = 54;
        this.txtAmount1.Text = "Input Text";
        this.txtAmount1.TextAlign = HorizontalAlignment.Right;
        this.txtAmount2.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAmount2.BorderStyle = BorderStyle.None;
        this.txtAmount2.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAmount2.Location = new Point(0, 21);
        this.txtAmount2.Margin = new Padding(0, 4, 0, 2);
        this.txtAmount2.Name = "txtAmount2";
        this.txtAmount2.Size = new Size(87, 13);
        this.txtAmount2.TabIndex = 55;
        this.txtAmount2.Text = "Input Text";
        this.txtAmount2.TextAlign = HorizontalAlignment.Right;
        this.txtAmount3.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAmount3.BorderStyle = BorderStyle.None;
        this.txtAmount3.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAmount3.Location = new Point(0, 40);
        this.txtAmount3.Margin = new Padding(0, 4, 0, 2);
        this.txtAmount3.Name = "txtAmount3";
        this.txtAmount3.Size = new Size(87, 13);
        this.txtAmount3.TabIndex = 56;
        this.txtAmount3.Text = "Input Text";
        this.txtAmount3.TextAlign = HorizontalAlignment.Right;
        this.txtAmount4.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAmount4.BorderStyle = BorderStyle.None;
        this.txtAmount4.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAmount4.Location = new Point(0, 59);
        this.txtAmount4.Margin = new Padding(0, 4, 0, 2);
        this.txtAmount4.Name = "txtAmount4";
        this.txtAmount4.Size = new Size(87, 13);
        this.txtAmount4.TabIndex = 57;
        this.txtAmount4.Text = "Input Text";
        this.txtAmount4.TextAlign = HorizontalAlignment.Right;
        this.txtAmount5.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAmount5.BorderStyle = BorderStyle.None;
        this.txtAmount5.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAmount5.Location = new Point(0, 78);
        this.txtAmount5.Margin = new Padding(0, 4, 0, 2);
        this.txtAmount5.Name = "txtAmount5";
        this.txtAmount5.Size = new Size(87, 13);
        this.txtAmount5.TabIndex = 58;
        this.txtAmount5.Text = "Input Text";
        this.txtAmount5.TextAlign = HorizontalAlignment.Right;
        this.txtAmount6.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAmount6.BorderStyle = BorderStyle.None;
        this.txtAmount6.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAmount6.Location = new Point(0, 97);
        this.txtAmount6.Margin = new Padding(0, 4, 0, 2);
        this.txtAmount6.Name = "txtAmount6";
        this.txtAmount6.Size = new Size(87, 13);
        this.txtAmount6.TabIndex = 59;
        this.txtAmount6.Text = "Input Text";
        this.txtAmount6.TextAlign = HorizontalAlignment.Right;
        this.txtAmount7.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAmount7.BorderStyle = BorderStyle.None;
        this.txtAmount7.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAmount7.Location = new Point(0, 116);
        this.txtAmount7.Margin = new Padding(0, 4, 0, 2);
        this.txtAmount7.Name = "txtAmount7";
        this.txtAmount7.Size = new Size(87, 13);
        this.txtAmount7.TabIndex = 60;
        this.txtAmount7.Text = "Input Text";
        this.txtAmount7.TextAlign = HorizontalAlignment.Right;
        this.txtAmount8.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAmount8.BorderStyle = BorderStyle.None;
        this.txtAmount8.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAmount8.Location = new Point(0, 135);
        this.txtAmount8.Margin = new Padding(0, 4, 0, 2);
        this.txtAmount8.Name = "txtAmount8";
        this.txtAmount8.Size = new Size(87, 13);
        this.txtAmount8.TabIndex = 61;
        this.txtAmount8.Text = "Input Text";
        this.txtAmount8.TextAlign = HorizontalAlignment.Right;
        this.txtAmount9.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAmount9.BorderStyle = BorderStyle.None;
        this.txtAmount9.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAmount9.Location = new Point(0, 154);
        this.txtAmount9.Margin = new Padding(0, 4, 0, 2);
        this.txtAmount9.Name = "txtAmount9";
        this.txtAmount9.Size = new Size(87, 13);
        this.txtAmount9.TabIndex = 62;
        this.txtAmount9.Text = "Input Text";
        this.txtAmount9.TextAlign = HorizontalAlignment.Right;
        this.txtAmount10.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAmount10.BorderStyle = BorderStyle.None;
        this.txtAmount10.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAmount10.Location = new Point(0, 173);
        this.txtAmount10.Margin = new Padding(0, 4, 0, 2);
        this.txtAmount10.Name = "txtAmount10";
        this.txtAmount10.Size = new Size(87, 13);
        this.txtAmount10.TabIndex = 63 /*0x3F*/;
        this.txtAmount10.Text = "Input Text";
        this.txtAmount10.TextAlign = HorizontalAlignment.Right;
        this.txtAmount11.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAmount11.BorderStyle = BorderStyle.None;
        this.txtAmount11.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAmount11.Location = new Point(0, 192 /*0xC0*/);
        this.txtAmount11.Margin = new Padding(0, 4, 0, 2);
        this.txtAmount11.Name = "txtAmount11";
        this.txtAmount11.Size = new Size(87, 13);
        this.txtAmount11.TabIndex = 64 /*0x40*/;
        this.txtAmount11.Text = "Input Text";
        this.txtAmount11.TextAlign = HorizontalAlignment.Right;
        this.flowLayoutPanel18.Controls.Add(this.txtAcc1);
        this.flowLayoutPanel18.Controls.Add(this.txtAcc2);
        this.flowLayoutPanel18.Controls.Add(this.txtAcc3);
        this.flowLayoutPanel18.Controls.Add(this.txtAcc4);
        this.flowLayoutPanel18.Controls.Add(this.txtAcc5);
        this.flowLayoutPanel18.Controls.Add(this.txtAcc6);
        this.flowLayoutPanel18.Controls.Add(this.txtAcc7);
        this.flowLayoutPanel18.Controls.Add(this.txtAcc8);
        this.flowLayoutPanel18.Controls.Add(this.txtAcc9);
        this.flowLayoutPanel18.Controls.Add(this.txtAcc10);
        this.flowLayoutPanel18.Controls.Add(this.txtAcc11);
        this.flowLayoutPanel18.Location = new Point(178, 0);
        this.flowLayoutPanel18.Margin = new Padding(3, 0, 3, 0);
        this.flowLayoutPanel18.Name = "flowLayoutPanel18";
        this.flowLayoutPanel18.Size = new Size(44, 211);
        this.flowLayoutPanel18.TabIndex = 111;
        this.txtAcc1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAcc1.BorderStyle = BorderStyle.None;
        this.txtAcc1.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAcc1.Location = new Point(0, 2);
        this.txtAcc1.Margin = new Padding(0, 2, 0, 2);
        this.txtAcc1.Name = "txtAcc1";
        this.txtAcc1.Size = new Size(42, 13);
        this.txtAcc1.TabIndex = 55;
        this.txtAcc1.Text = "Acc";
        this.txtAcc1.TextAlign = HorizontalAlignment.Right;
        this.txtAcc2.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAcc2.BorderStyle = BorderStyle.None;
        this.txtAcc2.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAcc2.Location = new Point(0, 21);
        this.txtAcc2.Margin = new Padding(0, 4, 0, 2);
        this.txtAcc2.Name = "txtAcc2";
        this.txtAcc2.Size = new Size(42, 13);
        this.txtAcc2.TabIndex = 56;
        this.txtAcc2.Text = "Acc";
        this.txtAcc2.TextAlign = HorizontalAlignment.Right;
        this.txtAcc3.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAcc3.BorderStyle = BorderStyle.None;
        this.txtAcc3.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAcc3.Location = new Point(0, 40);
        this.txtAcc3.Margin = new Padding(0, 4, 0, 2);
        this.txtAcc3.Name = "txtAcc3";
        this.txtAcc3.Size = new Size(42, 13);
        this.txtAcc3.TabIndex = 57;
        this.txtAcc3.Text = "Acc";
        this.txtAcc3.TextAlign = HorizontalAlignment.Right;
        this.txtAcc4.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAcc4.BorderStyle = BorderStyle.None;
        this.txtAcc4.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAcc4.Location = new Point(0, 59);
        this.txtAcc4.Margin = new Padding(0, 4, 0, 2);
        this.txtAcc4.Name = "txtAcc4";
        this.txtAcc4.Size = new Size(42, 13);
        this.txtAcc4.TabIndex = 58;
        this.txtAcc4.Text = "Acc";
        this.txtAcc4.TextAlign = HorizontalAlignment.Right;
        this.txtAcc5.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAcc5.BorderStyle = BorderStyle.None;
        this.txtAcc5.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAcc5.Location = new Point(0, 78);
        this.txtAcc5.Margin = new Padding(0, 4, 0, 2);
        this.txtAcc5.Name = "txtAcc5";
        this.txtAcc5.Size = new Size(42, 13);
        this.txtAcc5.TabIndex = 59;
        this.txtAcc5.Text = "Acc";
        this.txtAcc5.TextAlign = HorizontalAlignment.Right;
        this.txtAcc6.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAcc6.BorderStyle = BorderStyle.None;
        this.txtAcc6.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAcc6.Location = new Point(0, 97);
        this.txtAcc6.Margin = new Padding(0, 4, 0, 2);
        this.txtAcc6.Name = "txtAcc6";
        this.txtAcc6.Size = new Size(42, 13);
        this.txtAcc6.TabIndex = 60;
        this.txtAcc6.Text = "Acc";
        this.txtAcc6.TextAlign = HorizontalAlignment.Right;
        this.txtAcc7.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAcc7.BorderStyle = BorderStyle.None;
        this.txtAcc7.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAcc7.Location = new Point(0, 116);
        this.txtAcc7.Margin = new Padding(0, 4, 0, 2);
        this.txtAcc7.Name = "txtAcc7";
        this.txtAcc7.Size = new Size(42, 13);
        this.txtAcc7.TabIndex = 61;
        this.txtAcc7.Text = "Acc";
        this.txtAcc7.TextAlign = HorizontalAlignment.Right;
        this.txtAcc8.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAcc8.BorderStyle = BorderStyle.None;
        this.txtAcc8.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAcc8.Location = new Point(0, 135);
        this.txtAcc8.Margin = new Padding(0, 4, 0, 2);
        this.txtAcc8.Name = "txtAcc8";
        this.txtAcc8.Size = new Size(42, 13);
        this.txtAcc8.TabIndex = 62;
        this.txtAcc8.Text = "Acc";
        this.txtAcc8.TextAlign = HorizontalAlignment.Right;
        this.txtAcc9.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAcc9.BorderStyle = BorderStyle.None;
        this.txtAcc9.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAcc9.Location = new Point(0, 154);
        this.txtAcc9.Margin = new Padding(0, 4, 0, 2);
        this.txtAcc9.Name = "txtAcc9";
        this.txtAcc9.Size = new Size(42, 13);
        this.txtAcc9.TabIndex = 63 /*0x3F*/;
        this.txtAcc9.Text = "Acc";
        this.txtAcc9.TextAlign = HorizontalAlignment.Right;
        this.txtAcc10.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAcc10.BorderStyle = BorderStyle.None;
        this.txtAcc10.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAcc10.Location = new Point(0, 173);
        this.txtAcc10.Margin = new Padding(0, 4, 0, 2);
        this.txtAcc10.Name = "txtAcc10";
        this.txtAcc10.Size = new Size(42, 13);
        this.txtAcc10.TabIndex = 64 /*0x40*/;
        this.txtAcc10.Text = "Acc";
        this.txtAcc10.TextAlign = HorizontalAlignment.Right;
        this.txtAcc11.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAcc11.BorderStyle = BorderStyle.None;
        this.txtAcc11.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtAcc11.Location = new Point(0, 192 /*0xC0*/);
        this.txtAcc11.Margin = new Padding(0, 4, 0, 2);
        this.txtAcc11.Name = "txtAcc11";
        this.txtAcc11.Size = new Size(42, 13);
        this.txtAcc11.TabIndex = 65;
        this.txtAcc11.Text = "Acc";
        this.txtAcc11.TextAlign = HorizontalAlignment.Right;
        this.chkAlien.AutoSize = true;
        this.chkAlien.Checked = true;
        this.chkAlien.CheckState = CheckState.Checked;
        this.chkAlien.Location = new Point(131, 51);
        this.chkAlien.Name = "chkAlien";
        this.chkAlien.Padding = new Padding(3, 1, 0, 0);
        this.chkAlien.Size = new Size(109, 18);
        this.chkAlien.TabIndex = 1;
        this.chkAlien.Text = "Not Alien System";
        this.chkAlien.UseVisualStyleBackColor = true;
        this.chkAlien.CheckedChanged += this.chkMineralsPresent_CheckedChanged;
        this.txtMaxColonyCost.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMaxColonyCost.BorderStyle = BorderStyle.None;
        this.txtMaxColonyCost.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMaxColonyCost.Location = new Point(0, 5);
        this.txtMaxColonyCost.Margin = new Padding(0, 5, 3, 3);
        this.txtMaxColonyCost.Name = "txtMaxColonyCost";
        this.txtMaxColonyCost.Size = new Size(34, 13);
        this.txtMaxColonyCost.TabIndex = 11;
        this.txtMaxColonyCost.Text = "4";
        this.txtMaxColonyCost.TextAlign = HorizontalAlignment.Center;
        this.txtMaxColonyCost.TextChanged += this.txtMaxColonyCost_TextChanged;
        this.chkWaterPresent.AutoSize = true;
        this.chkWaterPresent.Checked = true;
        this.chkWaterPresent.CheckState = CheckState.Checked;
        this.chkWaterPresent.Location = new Point(131, 3);
        this.chkWaterPresent.Name = "chkWaterPresent";
        this.chkWaterPresent.Padding = new Padding(3, 1, 0, 0);
        this.chkWaterPresent.Size = new Size(97, 18);
        this.chkWaterPresent.TabIndex = 13;
        this.chkWaterPresent.Text = "Water Present";
        this.chkWaterPresent.UseVisualStyleBackColor = true;
        this.chkWaterPresent.CheckedChanged += this.chkMineralsPresent_CheckedChanged;
        this.chkHydroAbove20.AutoSize = true;
        this.chkHydroAbove20.Checked = true;
        this.chkHydroAbove20.CheckState = CheckState.Checked;
        this.chkHydroAbove20.Location = new Point(131, 27);
        this.chkHydroAbove20.Name = "chkHydroAbove20";
        this.chkHydroAbove20.Padding = new Padding(3, 1, 0, 0);
        this.chkHydroAbove20.Size = new Size(104, 18);
        this.chkHydroAbove20.TabIndex = 14;
        this.chkHydroAbove20.Text = "Hydro Ext 20%+";
        this.chkHydroAbove20.UseVisualStyleBackColor = true;
        this.chkHydroAbove20.CheckedChanged += this.chkMineralsPresent_CheckedChanged;
        this.chkOxygenPresent.AutoSize = true;
        this.chkOxygenPresent.Checked = true;
        this.chkOxygenPresent.CheckState = CheckState.Checked;
        this.chkOxygenPresent.Location = new Point(3, 51);
        this.chkOxygenPresent.Name = "chkOxygenPresent";
        this.chkOxygenPresent.Padding = new Padding(3, 1, 0, 0);
        this.chkOxygenPresent.Size = new Size(104, 18);
        this.chkOxygenPresent.TabIndex = 15;
        this.chkOxygenPresent.Text = "Oxygen Present";
        this.chkOxygenPresent.UseVisualStyleBackColor = true;
        this.chkOxygenPresent.CheckedChanged += this.chkMineralsPresent_CheckedChanged;
        this.txtMinPopCapacity.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMinPopCapacity.BorderStyle = BorderStyle.None;
        this.txtMinPopCapacity.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMinPopCapacity.Location = new Point(0, 29);
        this.txtMinPopCapacity.Margin = new Padding(0, 8, 3, 3);
        this.txtMinPopCapacity.Name = "txtMinPopCapacity";
        this.txtMinPopCapacity.Size = new Size(34, 13);
        this.txtMinPopCapacity.TabIndex = 11;
        this.txtMinPopCapacity.Text = "1";
        this.txtMinPopCapacity.TextAlign = HorizontalAlignment.Center;
        this.txtMinPopCapacity.TextChanged += this.txtMinPopCapacity_TextChanged;
        this.chkAcceptableGravity.AutoSize = true;
        this.chkAcceptableGravity.Checked = true;
        this.chkAcceptableGravity.CheckState = CheckState.Checked;
        this.chkAcceptableGravity.Location = new Point(3, 3);
        this.chkAcceptableGravity.Name = "chkAcceptableGravity";
        this.chkAcceptableGravity.Padding = new Padding(3, 1, 0, 0);
        this.chkAcceptableGravity.Size = new Size(119, 18);
        this.chkAcceptableGravity.TabIndex = 17;
        this.chkAcceptableGravity.Text = "Acceptable Gravity";
        this.chkAcceptableGravity.UseVisualStyleBackColor = true;
        this.chkAcceptableGravity.CheckedChanged += this.chkMineralsPresent_CheckedChanged;
        this.chkExcludeGasGiants.AutoSize = true;
        this.chkExcludeGasGiants.Checked = true;
        this.chkExcludeGasGiants.CheckState = CheckState.Checked;
        this.chkExcludeGasGiants.Location = new Point(3, 27);
        this.chkExcludeGasGiants.Name = "chkExcludeGasGiants";
        this.chkExcludeGasGiants.Padding = new Padding(3, 1, 0, 0);
        this.chkExcludeGasGiants.Size = new Size(122, 18);
        this.chkExcludeGasGiants.TabIndex = 18;
        this.chkExcludeGasGiants.Text = "Exclude Gas Giants";
        this.chkExcludeGasGiants.UseVisualStyleBackColor = true;
        this.chkExcludeGasGiants.CheckedChanged += this.chkMineralsPresent_CheckedChanged;
        this.flowLayoutPanel22.Controls.Add(this.chkAcceptableGravity);
        this.flowLayoutPanel22.Controls.Add(this.chkExcludeGasGiants);
        this.flowLayoutPanel22.Controls.Add(this.chkOxygenPresent);
        this.flowLayoutPanel22.Controls.Add(this.chkWaterPresent);
        this.flowLayoutPanel22.Controls.Add(this.chkHydroAbove20);
        this.flowLayoutPanel22.Controls.Add(this.chkAlien);
        this.flowLayoutPanel22.Controls.Add(this.chkBelowMaxCC);
        this.flowLayoutPanel22.Controls.Add(this.chkAboveMinPop);
        this.flowLayoutPanel22.Controls.Add(this.chkMineralsPresent);
        this.flowLayoutPanel22.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel22.Location = new Point(0, 3);
        this.flowLayoutPanel22.Margin = new Padding(0, 3, 3, 3);
        this.flowLayoutPanel22.Name = "flowLayoutPanel22";
        this.flowLayoutPanel22.Size = new Size(347, 76);
        this.flowLayoutPanel22.TabIndex = 133;
        this.chkBelowMaxCC.AutoSize = true;
        this.chkBelowMaxCC.Checked = true;
        this.chkBelowMaxCC.CheckState = CheckState.Checked;
        this.chkBelowMaxCC.Location = new Point(246, 3);
        this.chkBelowMaxCC.Name = "chkBelowMaxCC";
        this.chkBelowMaxCC.Padding = new Padding(3, 1, 0, 0);
        this.chkBelowMaxCC.Size = new Size(98, 18);
        this.chkBelowMaxCC.TabIndex = 19;
        this.chkBelowMaxCC.Text = "Below Max CC";
        this.chkBelowMaxCC.UseVisualStyleBackColor = true;
        this.chkBelowMaxCC.CheckedChanged += this.chkMineralsPresent_CheckedChanged;
        this.chkAboveMinPop.AutoSize = true;
        this.chkAboveMinPop.Checked = true;
        this.chkAboveMinPop.CheckState = CheckState.Checked;
        this.chkAboveMinPop.Location = new Point(246, 27);
        this.chkAboveMinPop.Name = "chkAboveMinPop";
        this.chkAboveMinPop.Padding = new Padding(3, 1, 0, 0);
        this.chkAboveMinPop.Size = new Size(102, 18);
        this.chkAboveMinPop.TabIndex = 20;
        this.chkAboveMinPop.Text = "Above Min Pop";
        this.chkAboveMinPop.UseVisualStyleBackColor = true;
        this.chkAboveMinPop.CheckedChanged += this.chkMineralsPresent_CheckedChanged;
        this.chkMineralsPresent.AutoSize = true;
        this.chkMineralsPresent.Checked = true;
        this.chkMineralsPresent.CheckState = CheckState.Checked;
        this.chkMineralsPresent.Location = new Point(246, 51);
        this.chkMineralsPresent.Name = "chkMineralsPresent";
        this.chkMineralsPresent.Padding = new Padding(3, 1, 0, 0);
        this.chkMineralsPresent.Size = new Size(107, 18);
        this.chkMineralsPresent.TabIndex = 21;
        this.chkMineralsPresent.Text = "Minerals Present";
        this.chkMineralsPresent.UseVisualStyleBackColor = true;
        this.chkMineralsPresent.CheckedChanged += this.chkMineralsPresent_CheckedChanged;
        this.flpAllSystemOptions.BorderStyle = BorderStyle.FixedSingle;
        this.flpAllSystemOptions.Controls.Add(this.flowLayoutPanel22);
        this.flpAllSystemOptions.Controls.Add(this.flowLayoutPanel23);
        this.flpAllSystemOptions.Controls.Add(this.flowLayoutPanel24);
        this.flpAllSystemOptions.Location = new Point(2, 27);
        this.flpAllSystemOptions.Name = "flpAllSystemOptions";
        this.flpAllSystemOptions.Size = new Size(1044, 88);
        this.flpAllSystemOptions.TabIndex = 133;
        this.flpAllSystemOptions.Visible = false;
        this.flowLayoutPanel23.Controls.Add(this.txtMaxColonyCost);
        this.flowLayoutPanel23.Controls.Add(this.txtMinPopCapacity);
        this.flowLayoutPanel23.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel23.Location = new Point(350, 3);
        this.flowLayoutPanel23.Margin = new Padding(0, 3, 3, 3);
        this.flowLayoutPanel23.Name = "flowLayoutPanel23";
        this.flowLayoutPanel23.Size = new Size(39, 76);
        this.flowLayoutPanel23.TabIndex = 134;
        this.flowLayoutPanel24.Controls.Add(this.label31);
        this.flowLayoutPanel24.Controls.Add(this.cboSort1);
        this.flowLayoutPanel24.Controls.Add(this.cboSort2);
        this.flowLayoutPanel24.Location = new Point(404, 3);
        this.flowLayoutPanel24.Margin = new Padding(12, 3, 3, 3);
        this.flowLayoutPanel24.Name = "flowLayoutPanel24";
        this.flowLayoutPanel24.Size = new Size(187, 76);
        this.flowLayoutPanel24.TabIndex = 134;
        this.label31.AutoSize = true;
        this.label31.Location = new Point(3, 0);
        this.label31.Name = "label31";
        this.label31.Padding = new Padding(0, 5, 5, 0);
        this.label31.Size = new Size(46, 18);
        this.label31.TabIndex = 96 /*0x60*/;
        this.label31.Text = "Sort By";
        this.cboSort1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSort1.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboSort1.FormattingEnabled = true;
        this.cboSort1.Items.AddRange(new object[5]
        {
            "None",
            "Orbital Distance",
            "Colony Cost",
            "Hydro Extent Desc",
            "Minerals Desc"
        });
        this.cboSort1.Location = new Point(3, 24);
        this.cboSort1.Margin = new Padding(3, 6, 3, 0);
        this.cboSort1.Name = "cboSort1";
        this.cboSort1.Size = new Size(176 /*0xB0*/, 21);
        this.cboSort1.TabIndex = 40;
        this.cboSort1.SelectedIndexChanged += this.cboSort2_SelectedIndexChanged;
        this.cboSort2.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSort2.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboSort2.FormattingEnabled = true;
        this.cboSort2.Items.AddRange(new object[5]
        {
            "None",
            "Orbital Distance",
            "Colony Cost",
            "Hydro Extent Desc",
            "Minerals Desc"
        });
        this.cboSort2.Location = new Point(3, 51);
        this.cboSort2.Margin = new Padding(3, 6, 3, 0);
        this.cboSort2.Name = "cboSort2";
        this.cboSort2.Size = new Size(176 /*0xB0*/, 21);
        this.cboSort2.TabIndex = 41;
        this.cboSort2.SelectedIndexChanged += this.cboSort2_SelectedIndexChanged;
        this.cmdRedoJP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRedoJP.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRedoJP.Location = new Point(384, 0);
        this.cmdRedoJP.Margin = new Padding(0);
        this.cmdRedoJP.Name = "cmdRedoJP";
        this.cmdRedoJP.Size = new Size(96 /*0x60*/, 30);
        this.cmdRedoJP.TabIndex = 138;
        this.cmdRedoJP.Tag = "1200";
        this.cmdRedoJP.Text = "Regen JP";
        this.cmdRedoJP.UseVisualStyleBackColor = false;
        this.cmdRedoJP.Click += this.cmdRedoJP_Click;
        this.cmdRedoAllMinerals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRedoAllMinerals.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRedoAllMinerals.Location = new Point(480, 0);
        this.cmdRedoAllMinerals.Margin = new Padding(0);
        this.cmdRedoAllMinerals.Name = "cmdRedoAllMinerals";
        this.cmdRedoAllMinerals.Size = new Size(96 /*0x60*/, 30);
        this.cmdRedoAllMinerals.TabIndex = 139;
        this.cmdRedoAllMinerals.Tag = "1200";
        this.cmdRedoAllMinerals.Text = "Regen Min";
        this.cmdRedoAllMinerals.UseVisualStyleBackColor = false;
        this.cmdRedoAllMinerals.Click += this.cmdRedoAllMinerals_Click;
        this.flpSMButtons.Controls.Add(this.cmdJPSurvey);
        this.flpSMButtons.Controls.Add(this.cmdNoGravSurvey);
        this.flpSMButtons.Controls.Add(this.cmdAllBodySurvey);
        this.flpSMButtons.Controls.Add(this.cmdNoBodySurvey);
        this.flpSMButtons.Controls.Add(this.cmdRedoJP);
        this.flpSMButtons.Controls.Add(this.cmdRedoAllMinerals);
        this.flpSMButtons.Controls.Add(this.cmdNameSolBodies);
        this.flpSMButtons.Controls.Add(this.cmdDeleteSystem);
        this.flpSMButtons.Location = new Point(2, 878);
        this.flpSMButtons.Margin = new Padding(3, 0, 3, 3);
        this.flpSMButtons.Name = "flpSMButtons";
        this.flpSMButtons.Size = new Size(1410, 33);
        this.flpSMButtons.TabIndex = 140;
        this.cmdNoGravSurvey.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdNoGravSurvey.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdNoGravSurvey.Location = new Point(96 /*0x60*/, 0);
        this.cmdNoGravSurvey.Margin = new Padding(0);
        this.cmdNoGravSurvey.Name = "cmdNoGravSurvey";
        this.cmdNoGravSurvey.Size = new Size(96 /*0x60*/, 30);
        this.cmdNoGravSurvey.TabIndex = 140;
        this.cmdNoGravSurvey.Tag = "1200";
        this.cmdNoGravSurvey.Text = "No Grav Survey";
        this.cmdNoGravSurvey.UseVisualStyleBackColor = false;
        this.cmdNoGravSurvey.Click += this.cmdNoGravSurvey_Click;
        this.pbSpecies.BorderStyle = BorderStyle.FixedSingle;
        this.pbSpecies.Location = new Point(1427, 7);
        this.pbSpecies.Margin = new Padding(0);
        this.pbSpecies.Name = "pbSpecies";
        this.pbSpecies.Size = new Size(174, 142);
        this.pbSpecies.SizeMode = PictureBoxSizeMode.StretchImage;
        this.pbSpecies.TabIndex = 145;
        this.pbSpecies.TabStop = false;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(1884, 923);
        this.Controls.Add(this.pbSpecies);
        this.Controls.Add(this.flpSMButtons);
        this.Controls.Add(this.flpSpecify);
        this.Controls.Add(this.flpAllSystemOptions);
        this.Controls.Add(this.flpDisplaySection);
        this.Controls.Add(this.flpButtonRow);
        this.Controls.Add(this.flowLayoutPanel9);
        this.Controls.Add(this.cboRaces);
        this.Controls.Add(this.lblSBSurvey);
        this.Controls.Add(this.label13);
        this.Controls.Add(this.lblJPSurvey);
        this.Controls.Add(this.label12);
        this.Controls.Add(this.lblJSP);
        this.Controls.Add(this.label11);
        this.Controls.Add(this.cboSpecies);
        this.Controls.Add(this.flowLayoutPanel4);
        this.Controls.Add(this.lblDiscovered);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.lblAge);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.flowLayoutPanel3);
        this.Controls.Add(this.flowLayoutPanel2);
        this.Controls.Add(this.flowLayoutPanel1);
        this.Controls.Add(this.lstvSB);
        this.Controls.Add(this.lstvStars);
        this.Controls.Add(this.cboSystems);
        this.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.KeyPreview = true;
        this.Name = "SystemView";
        this.Text = "System Generation and Display";
        this.FormClosing += this.SystemView_FormClosing;
        this.Load += this.SystemView_Load;
        this.KeyDown += this.SystemView_KeyDown;
        this.flowLayoutPanel1.ResumeLayout(false);
        this.flowLayoutPanel1.PerformLayout();
        this.flowLayoutPanel2.ResumeLayout(false);
        this.flowLayoutPanel2.PerformLayout();
        this.flowLayoutPanel3.ResumeLayout(false);
        this.flowLayoutPanel3.PerformLayout();
        this.flowLayoutPanel4.ResumeLayout(false);
        this.flowLayoutPanel7.ResumeLayout(false);
        this.flowLayoutPanel7.PerformLayout();
        this.flowLayoutPanel6.ResumeLayout(false);
        this.flowLayoutPanel6.PerformLayout();
        this.flowLayoutPanel5.ResumeLayout(false);
        this.flowLayoutPanel5.PerformLayout();
        this.flowLayoutPanel8.ResumeLayout(false);
        this.flowLayoutPanel8.PerformLayout();
        this.flpColonyCosts.ResumeLayout(false);
        this.flowLayoutPanel11.ResumeLayout(false);
        this.flowLayoutPanel11.PerformLayout();
        this.flowLayoutPanel12.ResumeLayout(false);
        this.flowLayoutPanel12.PerformLayout();
        this.flpSM.ResumeLayout(false);
        this.flowLayoutPanel9.ResumeLayout(false);
        this.flowLayoutPanel9.PerformLayout();
        this.flpButtonRow.ResumeLayout(false);
        this.flpDisplaySection.ResumeLayout(false);
        this.flpJPs.ResumeLayout(false);
        this.flowLayoutPanel15.ResumeLayout(false);
        this.flpMinButtons.ResumeLayout(false);
        this.flpSpecify.ResumeLayout(false);
        this.flowLayoutPanel16.ResumeLayout(false);
        this.flowLayoutPanel16.PerformLayout();
        this.flowLayoutPanel17.ResumeLayout(false);
        this.flowLayoutPanel17.PerformLayout();
        this.flowLayoutPanel18.ResumeLayout(false);
        this.flowLayoutPanel18.PerformLayout();
        this.flowLayoutPanel22.ResumeLayout(false);
        this.flowLayoutPanel22.PerformLayout();
        this.flpAllSystemOptions.ResumeLayout(false);
        this.flowLayoutPanel23.ResumeLayout(false);
        this.flowLayoutPanel23.PerformLayout();
        this.flowLayoutPanel24.ResumeLayout(false);
        this.flowLayoutPanel24.PerformLayout();
        this.flpSMButtons.ResumeLayout(false);
        ((ISupportInitialize)this.pbSpecies).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}