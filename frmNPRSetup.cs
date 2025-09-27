// Decompiled with JetBrains decompiler
// Type: frmNPRSetup
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
public class frmNPRSetup : Form
{
    private GClass0 gclass0_0;
    private GClass143 gclass143_0;
    private IContainer icontainer_0;
    private FlowLayoutPanel flowLayoutPanel10;
    private Panel panel6;
    private TextBox txtTitle;
    private Label label22;
    private Panel panel15;
    private TextBox txtShortName;
    private Label label24;
    private Panel panel16;
    private TextBox txtHomeworld;
    private Label label25;
    private Button cmdStation;
    private Button cmdHull;
    private Button cmdRaceFlag;
    private Button cmdSpeciesImage;
    private Button cmdCreate;
    private FlowLayoutPanel flowLayoutPanel1;
    private FlowLayoutPanel flowLayoutPanel4;
    private Panel panel1;
    private ComboBox cboSystemTheme;
    private Label label18;
    private Panel panel3;
    private ComboBox cboClassTheme;
    private Label label19;
    private Panel panel4;
    private ComboBox cboRankTheme;
    private Label label20;
    private Panel panel2;
    private ComboBox cboGroundTheme;
    private Label label1;
    private Panel panel7;
    private ComboBox cboMissileTheme;
    private Label label2;
    private Panel panel5;
    private ComboBox cboCommanderTheme;
    private Label label21;
    private Button cmdSelectSystem;
    private Panel panel8;
    private TextBox txtHomeSystem;
    private Label label3;
    private CheckedListBox lstTerrain;
    private FlowLayoutPanel flowLayoutPanel2;
    private Panel panel36;
    private TextBox txtDet;
    private Label label36;
    private Panel panel37;
    private TextBox txtDip;
    private Label label37;
    private Panel panel38;
    private TextBox txtExp;
    private Label label38;
    private Panel panel39;
    private TextBox txtMil;
    private Label label39;
    private Panel panel40;
    private TextBox txtTrade;
    private Label label40;
    private Panel panel41;
    private TextBox txtTrans;
    private Label label41;
    private Panel panel42;
    private TextBox txtXen;
    private Label label42;
    private Panel panel26;
    private TextBox txtGrowth;
    private Label label10;
    private Panel panel27;
    private TextBox txtResearch;
    private Label label11;
    private Panel panel28;
    private TextBox txtProduction;
    private Label label12;
    private Panel panel9;
    private ComboBox cboUseShields;
    private Label label5;
    private Panel panel10;
    private ComboBox cboPrimaryBeam;
    private Label label6;
    private Panel panel11;
    private ComboBox cboPDBeam;
    private Label label7;
    private Panel panel12;
    private ComboBox cboUseMissiles;
    private Label label8;
    private PictureBox pbRace;
    private FlowLayoutPanel flowLayoutPanel3;
    private PictureBox pbShip;
    private FlowLayoutPanel flowLayoutPanel6;
    private PictureBox pbStation;
    private PictureBox pbFlag;
    private FlowLayoutPanel flpModifiers;
    private Panel panel47;
    private TextBox txtBP;
    private Label label47;
    private Panel panel19;
    private TextBox txtTP;
    private Label label4;
    private Panel panel13;
    private TextBox txtSSM;
    private Label label9;
    private FlowLayoutPanel flowLayoutPanel7;
    private FlowLayoutPanel flowLayoutPanel8;
    private FlowLayoutPanel flowLayoutPanel9;
    private Panel panel14;
    private TextBox txtPopSizeMod;
    private Label label13;
    private Panel panel17;
    private TextBox txtBaseExplored;
    private Label label14;
    private Panel panel18;
    private TextBox txtRandomExplored;
    private Label label15;
    private Panel panel20;
    private TextBox txtMaxStartingSystems;
    private Label label16;
    private Panel panel21;
    private ComboBox cboUseCarriers;
    private Label label17;
    private Panel panel22;
    private ComboBox cboHybrids;
    private Label label23;
    private Panel panel23;
    private ComboBox cboBalanced;
    private Label label26;

    public frmNPRSetup(GClass0 gclass0_1, GClass143 gclass143_1)
    {
        this.InitializeComponent();
        this.gclass0_0 = gclass0_1;
        this.gclass143_0 = gclass143_1;
    }

    public void method_0()
    {
        try
        {
            List<string> stringList1 = new List<string>();
            foreach (AuroraNPRSetupOption enum_0 in Enum.GetValues(typeof(AuroraNPRSetupOption)))
                stringList1.Add(AuroraUtils.smethod_82(enum_0));
            this.cboUseMissiles.DataSource = stringList1;
            List<string> stringList2 = new List<string>();
            foreach (AuroraNPRSetupOption enum_0 in Enum.GetValues(typeof(AuroraNPRSetupOption)))
                stringList2.Add(AuroraUtils.smethod_82(enum_0));
            this.cboUseShields.DataSource = stringList2;
            List<string> stringList3 = new List<string>();
            foreach (AuroraNPRSetupOption enum_0 in Enum.GetValues(typeof(AuroraNPRSetupOption)))
                stringList3.Add(AuroraUtils.smethod_82(enum_0));
            this.cboUseCarriers.DataSource = stringList3;
            List<string> stringList4 = new List<string>();
            foreach (AuroraNPRSetupOption enum_0 in Enum.GetValues(typeof(AuroraNPRSetupOption)))
                stringList4.Add(AuroraUtils.smethod_82(enum_0));
            this.cboHybrids.DataSource = stringList4;
            List<string> stringList5 = new List<string>();
            foreach (AuroraNPRSetupOption enum_0 in Enum.GetValues(typeof(AuroraNPRSetupOption)))
                stringList5.Add(AuroraUtils.smethod_82(enum_0));
            this.cboBalanced.DataSource = stringList5;
            List<string> stringList6 = new List<string>();
            foreach (AuroraNPRPrimaryBeam enum_0 in Enum.GetValues(typeof(AuroraNPRPrimaryBeam)))
                stringList6.Add(AuroraUtils.smethod_82(enum_0));
            this.cboPrimaryBeam.DataSource = stringList6;
            List<string> stringList7 = new List<string>();
            foreach (AuroraNPRPDBeam enum_0 in Enum.GetValues(typeof(AuroraNPRPDBeam)))
                stringList7.Add(AuroraUtils.smethod_82(enum_0));
            this.cboPDBeam.DataSource = stringList7;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3759);
        }
    }

    private void cmdRaceFlag_Click(object sender, EventArgs e)
    {
        try
        {
            string str = AuroraUtils.smethod_18("Flags");
            if (str != "")
            {
                int num = str.LastIndexOf("\\");
                this.gclass143_0.string_4 = str.Substring(num + 1);
            }

            this.pbFlag.Image = Image.FromFile($"{Application.StartupPath}\\Flags\\{this.gclass143_0.string_4}");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3748);
        }
    }

    private void cmdSpeciesImage_Click(object sender, EventArgs e)
    {
        try
        {
            string str = AuroraUtils.smethod_18("Races");
            if (str != "")
            {
                int num = str.LastIndexOf("\\");
                this.gclass143_0.string_3 = str.Substring(num + 1);
            }

            this.pbRace.Image = Image.FromFile($"{Application.StartupPath}\\Races\\{this.gclass143_0.string_3}");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3749);
        }
    }

    private void cmdHull_Click(object sender, EventArgs e)
    {
        try
        {
            string str = AuroraUtils.smethod_18("ShipIcons");
            if (str != "")
            {
                int num = str.LastIndexOf("\\");
                this.gclass143_0.string_5 = str.Substring(num + 1);
            }

            this.pbShip.Image = Image.FromFile($"{Application.StartupPath}\\ShipIcons\\{this.gclass143_0.string_5}");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3750);
        }
    }

    private void cmdStation_Click(object sender, EventArgs e)
    {
        try
        {
            string str = AuroraUtils.smethod_18("StationIcons");
            if (str != "")
            {
                int num = str.LastIndexOf("\\");
                this.gclass143_0.string_6 = str.Substring(num + 1);
            }

            this.pbStation.Image =
                Image.FromFile($"{Application.StartupPath}\\StationIcons\\{this.gclass143_0.string_6}");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3751);
        }
    }

    private void cmdCreate_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass143_0.string_1 = this.txtTitle.Text;
            this.gclass143_0.string_0 = this.txtShortName.Text;
            this.gclass143_0.string_2 = this.txtHomeworld.Text;
            this.gclass143_0.gclass140_0 = (NamingTheme)this.cboClassTheme.SelectedValue;
            this.gclass143_0.gclass140_1 = (NamingTheme)this.cboSystemTheme.SelectedValue;
            this.gclass143_0.gclass140_2 = (NamingTheme)this.cboGroundTheme.SelectedValue;
            this.gclass143_0.gclass140_3 = (NamingTheme)this.cboMissileTheme.SelectedValue;
            this.gclass143_0.gclass60_0 = (RankTheme)this.cboRankTheme.SelectedValue;
            this.gclass143_0.gclass58_0 = (CommanderNameThemeData)this.cboCommanderTheme.SelectedValue;
            this.gclass143_0.int_5 = Convert.ToInt32(this.txtDet.Text);
            this.gclass143_0.int_1 = Convert.ToInt32(this.txtDip.Text);
            this.gclass143_0.int_4 = Convert.ToInt32(this.txtExp.Text);
            this.gclass143_0.int_3 = Convert.ToInt32(this.txtMil.Text);
            this.gclass143_0.int_6 = Convert.ToInt32(this.txtTrade.Text);
            this.gclass143_0.int_2 = Convert.ToInt32(this.txtTrans.Text);
            this.gclass143_0.int_0 = Convert.ToInt32(this.txtXen.Text);
            this.gclass143_0.int_8 = Convert.ToInt32(this.txtBaseExplored.Text);
            this.gclass143_0.int_9 = Convert.ToInt32(this.txtRandomExplored.Text);
            this.gclass143_0.int_10 = Convert.ToInt32(this.txtMaxStartingSystems.Text);
            ParsedDecimal gclass208_1 = AuroraUtils.ParseDecimalString(this.txtGrowth.Text);
            if (gclass208_1.Succeed)
                this.gclass143_0.decimal_0 = gclass208_1.Value;
            ParsedDecimal gclass208_2 = AuroraUtils.ParseDecimalString(this.txtProduction.Text);
            if (gclass208_2.Succeed)
                this.gclass143_0.decimal_2 = gclass208_2.Value;
            ParsedDecimal gclass208_3 = AuroraUtils.ParseDecimalString(this.txtResearch.Text);
            if (gclass208_3.Succeed)
                this.gclass143_0.decimal_1 = gclass208_3.Value;
            ParsedDecimal gclass208_4 = AuroraUtils.ParseDecimalString(this.txtBP.Text);
            if (gclass208_4.Succeed)
                this.gclass143_0.decimal_4 = gclass208_4.Value;
            ParsedDecimal gclass208_5 = AuroraUtils.ParseDecimalString(this.txtTP.Text);
            if (gclass208_5.Succeed)
                this.gclass143_0.decimal_3 = gclass208_5.Value;
            ParsedDecimal gclass208_6 = AuroraUtils.ParseDecimalString(this.txtSSM.Text);
            if (gclass208_6.Succeed)
                this.gclass143_0.decimal_5 = gclass208_6.Value;
            ParsedDecimal gclass208_7 = AuroraUtils.ParseDecimalString(this.txtPopSizeMod.Text);
            if (gclass208_7.Succeed)
                this.gclass143_0.decimal_6 = gclass208_7.Value;
            foreach (PlanetaryTerrainDefinition checkedItem in this.lstTerrain.CheckedItems)
                this.gclass143_0.list_0.Add(checkedItem);
            if (this.gclass143_0.decimal_0 > 3M)
                this.gclass143_0.decimal_0 = 3M;
            if (this.gclass143_0.decimal_2 > 3M)
                this.gclass143_0.decimal_2 = 3M;
            if (this.gclass143_0.decimal_1 > 3M)
                this.gclass143_0.decimal_1 = 3M;
            if (this.gclass143_0.decimal_4 > 3M)
                this.gclass143_0.decimal_4 = 3M;
            if (this.gclass143_0.decimal_3 > 3M)
                this.gclass143_0.decimal_3 = 3M;
            if (this.gclass143_0.decimal_5 > 5M)
                this.gclass143_0.decimal_5 = 5M;
            if (this.gclass143_0.decimal_6 > 5M)
                this.gclass143_0.decimal_5 = 5M;
            if (this.gclass143_0.decimal_0 < 0.5M)
                this.gclass143_0.decimal_0 = 0.5M;
            if (this.gclass143_0.decimal_2 < 0.5M)
                this.gclass143_0.decimal_2 = 0.5M;
            if (this.gclass143_0.decimal_1 < 0.5M)
                this.gclass143_0.decimal_1 = 0.5M;
            if (this.gclass143_0.decimal_4 < 0.5M)
                this.gclass143_0.decimal_4 = 0.5M;
            if (this.gclass143_0.decimal_3 < 0.5M)
                this.gclass143_0.decimal_3 = 0.5M;
            if (this.gclass143_0.decimal_6 < 0.2M)
                this.gclass143_0.decimal_6 = 0.2M;
            if (this.gclass143_0.decimal_5 < 1M)
                this.gclass143_0.decimal_5 = 1M;
            this.gclass143_0.auroraNPRSetupOption_0 = (AuroraNPRSetupOption)Enum.Parse(typeof(AuroraNPRSetupOption),
                (string)this.cboUseShields.SelectedValue);
            this.gclass143_0.auroraNPRSetupOption_1 = (AuroraNPRSetupOption)Enum.Parse(typeof(AuroraNPRSetupOption),
                (string)this.cboUseMissiles.SelectedValue);
            this.gclass143_0.auroraNPRPrimaryBeam_0 = (AuroraNPRPrimaryBeam)Enum.Parse(typeof(AuroraNPRPrimaryBeam),
                (string)this.cboPrimaryBeam.SelectedValue);
            this.gclass143_0.auroraNPRPDBeam_0 =
                (AuroraNPRPDBeam)Enum.Parse(typeof(AuroraNPRPDBeam), (string)this.cboPDBeam.SelectedValue);
            this.gclass143_0.auroraNPRSetupOption_2 = (AuroraNPRSetupOption)Enum.Parse(typeof(AuroraNPRSetupOption),
                (string)this.cboUseCarriers.SelectedValue);
            this.gclass143_0.auroraNPRSetupOption_3 = (AuroraNPRSetupOption)Enum.Parse(typeof(AuroraNPRSetupOption),
                (string)this.cboHybrids.SelectedValue);
            this.gclass143_0.auroraNPRSetupOption_4 = (AuroraNPRSetupOption)Enum.Parse(typeof(AuroraNPRSetupOption),
                (string)this.cboBalanced.SelectedValue);
            this.Close();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3752);
        }
    }

    private void frmNPRSetup_Load(object sender, EventArgs e)
    {
        try
        {
            this.txtTitle.Text = this.gclass143_0.string_1;
            this.txtShortName.Text = this.gclass143_0.string_0;
            this.txtHomeworld.Text = this.gclass143_0.string_2;
            this.pbRace.Image = Image.FromFile($"{Application.StartupPath}\\Races\\{this.gclass143_0.string_3}");
            this.pbShip.Image = Image.FromFile($"{Application.StartupPath}\\ShipIcons\\{this.gclass143_0.string_5}");
            this.pbStation.Image =
                Image.FromFile($"{Application.StartupPath}\\StationIcons\\{this.gclass143_0.string_6}");
            this.pbFlag.Image = Image.FromFile($"{Application.StartupPath}\\Flags\\{this.gclass143_0.string_4}");
            this.gclass0_0.method_552(this.cboClassTheme);
            this.gclass0_0.method_552(this.cboSystemTheme);
            this.gclass0_0.method_552(this.cboGroundTheme);
            this.gclass0_0.method_552(this.cboMissileTheme);
            this.gclass0_0.method_553(this.cboCommanderTheme);
            this.gclass0_0.method_554(this.cboRankTheme);
            this.cboClassTheme.SelectedItem = this.gclass143_0.gclass140_0;
            this.cboSystemTheme.SelectedItem = this.gclass143_0.gclass140_1;
            this.cboGroundTheme.SelectedItem = this.gclass143_0.gclass140_2;
            this.cboMissileTheme.SelectedItem = this.gclass143_0.gclass140_3;
            this.cboCommanderTheme.SelectedItem = this.gclass143_0.gclass58_0;
            this.cboRankTheme.SelectedItem = this.gclass143_0.gclass60_0;
            this.txtDet.Text = AuroraUtils.smethod_37(this.gclass143_0.int_5);
            this.txtDip.Text = AuroraUtils.smethod_37(this.gclass143_0.int_1);
            this.txtExp.Text = AuroraUtils.smethod_37(this.gclass143_0.int_4);
            this.txtMil.Text = AuroraUtils.smethod_37(this.gclass143_0.int_3);
            this.txtTrade.Text = AuroraUtils.smethod_37(this.gclass143_0.int_6);
            this.txtTrans.Text = AuroraUtils.smethod_37(this.gclass143_0.int_2);
            this.txtXen.Text = AuroraUtils.smethod_37(this.gclass143_0.int_0);
            this.txtGrowth.Text = AuroraUtils.smethod_45(this.gclass143_0.decimal_0, 2);
            this.txtResearch.Text = AuroraUtils.smethod_45(this.gclass143_0.decimal_1, 2);
            this.txtProduction.Text = AuroraUtils.smethod_45(this.gclass143_0.decimal_2, 2);
            this.txtBP.Text = AuroraUtils.smethod_45(this.gclass143_0.decimal_4, 2);
            this.txtTP.Text = AuroraUtils.smethod_45(this.gclass143_0.decimal_3, 2);
            this.txtSSM.Text = AuroraUtils.smethod_45(this.gclass143_0.decimal_5, 2);
            this.txtPopSizeMod.Text = AuroraUtils.smethod_45(this.gclass143_0.decimal_6, 2);
            if (this.gclass0_0.UseKnownStars == 1)
                this.cmdSelectSystem.Visible = true;
            else
                this.cmdSelectSystem.Visible = false;
            this.method_1(this.lstTerrain, true);
            this.method_0();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3753);
        }
    }

    private void cmdSelectSystem_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass0_0.gclass198_0 = null;
            this.gclass0_0.bool_3 = false;
            this.gclass0_0.bool_21 = false;
            Cursor.Current = Cursors.WaitCursor;
            int num = (int)new SelectKnownSystem(this.gclass0_0, false).ShowDialog();
            if (this.gclass0_0.bool_21)
                return;
            this.gclass143_0.gclass198_0 = this.gclass0_0.gclass198_0;
            this.txtHomeSystem.Text = this.gclass143_0.gclass198_0.Name;
            Cursor.Current = Cursors.Default;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3754);
        }
    }

    public void method_1(CheckedListBox checkedListBox_0, bool bool_0)
    {
        try
        {
            List<PlanetaryTerrainDefinition> list = this.gclass0_0.DominantTerrainTypeDictionary.Values
                .OrderBy<PlanetaryTerrainDefinition, double>(gclass99_0 => gclass99_0.MinTemperature)
                .ThenBy<PlanetaryTerrainDefinition, double>(gclass99_0 => gclass99_0.MaxTemperature)
                .ThenBy<PlanetaryTerrainDefinition, double>(gclass99_0 => gclass99_0.MinimumHydro)
                .ThenBy<PlanetaryTerrainDefinition, AuroraTectonics>(gclass99_0 => gclass99_0.MinTectonics)
                .ThenBy<PlanetaryTerrainDefinition, double>(gclass99_0 => gclass99_0.MinOxygen).ToList<PlanetaryTerrainDefinition>();
            if (bool_0)
                list = list.Where<PlanetaryTerrainDefinition>(gclass99_0 => gclass99_0.MinTemperature > -100.0 && gclass99_0.MinimumHydro < 70.0)
                    .ToList<PlanetaryTerrainDefinition>();
            checkedListBox_0.DataSource = list;
            checkedListBox_0.DisplayMember = "Name";
            for (int index = 0; index < checkedListBox_0.Items.Count; ++index)
                checkedListBox_0.SetItemChecked(index, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3755);
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
        this.flowLayoutPanel10 = new FlowLayoutPanel();
        this.panel6 = new Panel();
        this.txtTitle = new TextBox();
        this.label22 = new Label();
        this.panel15 = new Panel();
        this.txtShortName = new TextBox();
        this.label24 = new Label();
        this.panel16 = new Panel();
        this.txtHomeworld = new TextBox();
        this.label25 = new Label();
        this.panel8 = new Panel();
        this.txtHomeSystem = new TextBox();
        this.label3 = new Label();
        this.cmdStation = new Button();
        this.cmdHull = new Button();
        this.cmdRaceFlag = new Button();
        this.cmdSpeciesImage = new Button();
        this.cmdCreate = new Button();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.cmdSelectSystem = new Button();
        this.flowLayoutPanel4 = new FlowLayoutPanel();
        this.flowLayoutPanel7 = new FlowLayoutPanel();
        this.panel5 = new Panel();
        this.cboCommanderTheme = new ComboBox();
        this.label21 = new Label();
        this.panel1 = new Panel();
        this.cboSystemTheme = new ComboBox();
        this.label18 = new Label();
        this.panel3 = new Panel();
        this.cboClassTheme = new ComboBox();
        this.label19 = new Label();
        this.flowLayoutPanel8 = new FlowLayoutPanel();
        this.panel4 = new Panel();
        this.cboRankTheme = new ComboBox();
        this.label20 = new Label();
        this.panel2 = new Panel();
        this.cboGroundTheme = new ComboBox();
        this.label1 = new Label();
        this.panel7 = new Panel();
        this.cboMissileTheme = new ComboBox();
        this.label2 = new Label();
        this.lstTerrain = new CheckedListBox();
        this.flowLayoutPanel2 = new FlowLayoutPanel();
        this.panel9 = new Panel();
        this.cboUseShields = new ComboBox();
        this.label5 = new Label();
        this.panel10 = new Panel();
        this.cboPrimaryBeam = new ComboBox();
        this.label6 = new Label();
        this.panel12 = new Panel();
        this.cboUseMissiles = new ComboBox();
        this.label8 = new Label();
        this.panel11 = new Panel();
        this.cboPDBeam = new ComboBox();
        this.label7 = new Label();
        this.panel21 = new Panel();
        this.cboUseCarriers = new ComboBox();
        this.label17 = new Label();
        this.panel22 = new Panel();
        this.cboHybrids = new ComboBox();
        this.label23 = new Label();
        this.panel23 = new Panel();
        this.cboBalanced = new ComboBox();
        this.label26 = new Label();
        this.panel36 = new Panel();
        this.txtDet = new TextBox();
        this.label36 = new Label();
        this.panel37 = new Panel();
        this.txtDip = new TextBox();
        this.label37 = new Label();
        this.panel38 = new Panel();
        this.txtExp = new TextBox();
        this.label38 = new Label();
        this.panel39 = new Panel();
        this.txtMil = new TextBox();
        this.label39 = new Label();
        this.panel40 = new Panel();
        this.txtTrade = new TextBox();
        this.label40 = new Label();
        this.panel41 = new Panel();
        this.txtTrans = new TextBox();
        this.label41 = new Label();
        this.panel42 = new Panel();
        this.txtXen = new TextBox();
        this.label42 = new Label();
        this.panel26 = new Panel();
        this.txtGrowth = new TextBox();
        this.label10 = new Label();
        this.panel27 = new Panel();
        this.txtResearch = new TextBox();
        this.label11 = new Label();
        this.panel28 = new Panel();
        this.txtProduction = new TextBox();
        this.label12 = new Label();
        this.pbRace = new PictureBox();
        this.flowLayoutPanel3 = new FlowLayoutPanel();
        this.pbShip = new PictureBox();
        this.flowLayoutPanel6 = new FlowLayoutPanel();
        this.pbStation = new PictureBox();
        this.pbFlag = new PictureBox();
        this.flpModifiers = new FlowLayoutPanel();
        this.panel14 = new Panel();
        this.txtPopSizeMod = new TextBox();
        this.label13 = new Label();
        this.panel47 = new Panel();
        this.txtBP = new TextBox();
        this.label47 = new Label();
        this.panel19 = new Panel();
        this.txtTP = new TextBox();
        this.label4 = new Label();
        this.panel13 = new Panel();
        this.txtSSM = new TextBox();
        this.label9 = new Label();
        this.panel17 = new Panel();
        this.txtBaseExplored = new TextBox();
        this.label14 = new Label();
        this.panel18 = new Panel();
        this.txtRandomExplored = new TextBox();
        this.label15 = new Label();
        this.panel20 = new Panel();
        this.txtMaxStartingSystems = new TextBox();
        this.label16 = new Label();
        this.flowLayoutPanel9 = new FlowLayoutPanel();
        this.flowLayoutPanel10.SuspendLayout();
        this.panel6.SuspendLayout();
        this.panel15.SuspendLayout();
        this.panel16.SuspendLayout();
        this.panel8.SuspendLayout();
        this.flowLayoutPanel1.SuspendLayout();
        this.flowLayoutPanel4.SuspendLayout();
        this.flowLayoutPanel7.SuspendLayout();
        this.panel5.SuspendLayout();
        this.panel1.SuspendLayout();
        this.panel3.SuspendLayout();
        this.flowLayoutPanel8.SuspendLayout();
        this.panel4.SuspendLayout();
        this.panel2.SuspendLayout();
        this.panel7.SuspendLayout();
        this.flowLayoutPanel2.SuspendLayout();
        this.panel9.SuspendLayout();
        this.panel10.SuspendLayout();
        this.panel12.SuspendLayout();
        this.panel11.SuspendLayout();
        this.panel21.SuspendLayout();
        this.panel22.SuspendLayout();
        this.panel23.SuspendLayout();
        this.panel36.SuspendLayout();
        this.panel37.SuspendLayout();
        this.panel38.SuspendLayout();
        this.panel39.SuspendLayout();
        this.panel40.SuspendLayout();
        this.panel41.SuspendLayout();
        this.panel42.SuspendLayout();
        this.panel26.SuspendLayout();
        this.panel27.SuspendLayout();
        this.panel28.SuspendLayout();
        ((ISupportInitialize)this.pbRace).BeginInit();
        this.flowLayoutPanel3.SuspendLayout();
        ((ISupportInitialize)this.pbShip).BeginInit();
        this.flowLayoutPanel6.SuspendLayout();
        ((ISupportInitialize)this.pbStation).BeginInit();
        ((ISupportInitialize)this.pbFlag).BeginInit();
        this.flpModifiers.SuspendLayout();
        this.panel14.SuspendLayout();
        this.panel47.SuspendLayout();
        this.panel19.SuspendLayout();
        this.panel13.SuspendLayout();
        this.panel17.SuspendLayout();
        this.panel18.SuspendLayout();
        this.panel20.SuspendLayout();
        this.flowLayoutPanel9.SuspendLayout();
        this.SuspendLayout();
        this.flowLayoutPanel10.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel10.Controls.Add(this.panel6);
        this.flowLayoutPanel10.Controls.Add(this.panel15);
        this.flowLayoutPanel10.Controls.Add(this.panel16);
        this.flowLayoutPanel10.Controls.Add(this.panel8);
        this.flowLayoutPanel10.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel10.Location = new Point(6, 6);
        this.flowLayoutPanel10.Name = "flowLayoutPanel10";
        this.flowLayoutPanel10.Size = new Size(293, 90);
        this.flowLayoutPanel10.TabIndex = 109;
        this.flowLayoutPanel10.WrapContents = false;
        this.panel6.Controls.Add(this.txtTitle);
        this.panel6.Controls.Add(this.label22);
        this.panel6.Location = new Point(3, 6);
        this.panel6.Margin = new Padding(3, 6, 3, 3);
        this.panel6.Name = "panel6";
        this.panel6.Size = new Size(280, 15);
        this.panel6.TabIndex = 119;
        this.txtTitle.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTitle.BorderStyle = BorderStyle.None;
        this.txtTitle.Dock = DockStyle.Right;
        this.txtTitle.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtTitle.Location = new Point(120, 0);
        this.txtTitle.Name = "txtTitle";
        this.txtTitle.Size = new Size(160 /*0xA0*/, 13);
        this.txtTitle.TabIndex = 1;
        this.txtTitle.Text = "Text";
        this.txtTitle.TextAlign = HorizontalAlignment.Center;
        this.label22.AutoSize = true;
        this.label22.Dock = DockStyle.Left;
        this.label22.Location = new Point(0, 0);
        this.label22.Margin = new Padding(3);
        this.label22.Name = "label22";
        this.label22.Size = new Size(56, 13);
        this.label22.TabIndex = 104;
        this.label22.Text = "Race Title";
        this.panel15.Controls.Add(this.txtShortName);
        this.panel15.Controls.Add(this.label24);
        this.panel15.Location = new Point(3, 27);
        this.panel15.Name = "panel15";
        this.panel15.Size = new Size(280, 15);
        this.panel15.TabIndex = 120;
        this.txtShortName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtShortName.BorderStyle = BorderStyle.None;
        this.txtShortName.Dock = DockStyle.Right;
        this.txtShortName.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtShortName.Location = new Point(120, 0);
        this.txtShortName.Name = "txtShortName";
        this.txtShortName.Size = new Size(160 /*0xA0*/, 13);
        this.txtShortName.TabIndex = 2;
        this.txtShortName.Text = "Text";
        this.txtShortName.TextAlign = HorizontalAlignment.Center;
        this.label24.AutoSize = true;
        this.label24.Dock = DockStyle.Left;
        this.label24.Location = new Point(0, 0);
        this.label24.Margin = new Padding(3);
        this.label24.Name = "label24";
        this.label24.Size = new Size(92, 13);
        this.label24.TabIndex = 104;
        this.label24.Text = "Race Short Name";
        this.panel16.Controls.Add(this.txtHomeworld);
        this.panel16.Controls.Add(this.label25);
        this.panel16.Location = new Point(3, 48 /*0x30*/);
        this.panel16.Name = "panel16";
        this.panel16.Size = new Size(280, 15);
        this.panel16.TabIndex = 121;
        this.txtHomeworld.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtHomeworld.BorderStyle = BorderStyle.None;
        this.txtHomeworld.Dock = DockStyle.Right;
        this.txtHomeworld.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtHomeworld.Location = new Point(120, 0);
        this.txtHomeworld.Name = "txtHomeworld";
        this.txtHomeworld.Size = new Size(160 /*0xA0*/, 13);
        this.txtHomeworld.TabIndex = 3;
        this.txtHomeworld.Text = "Text";
        this.txtHomeworld.TextAlign = HorizontalAlignment.Center;
        this.label25.AutoSize = true;
        this.label25.Dock = DockStyle.Left;
        this.label25.Location = new Point(0, 0);
        this.label25.Margin = new Padding(3);
        this.label25.Name = "label25";
        this.label25.Size = new Size(91, 13);
        this.label25.TabIndex = 104;
        this.label25.Text = "Homeworld Name";
        this.panel8.Controls.Add(this.txtHomeSystem);
        this.panel8.Controls.Add(this.label3);
        this.panel8.Location = new Point(3, 69);
        this.panel8.Name = "panel8";
        this.panel8.Size = new Size(280, 15);
        this.panel8.TabIndex = 122;
        this.txtHomeSystem.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtHomeSystem.BorderStyle = BorderStyle.None;
        this.txtHomeSystem.Dock = DockStyle.Right;
        this.txtHomeSystem.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtHomeSystem.Location = new Point(120, 0);
        this.txtHomeSystem.Name = "txtHomeSystem";
        this.txtHomeSystem.Size = new Size(160 /*0xA0*/, 13);
        this.txtHomeSystem.TabIndex = 4;
        this.txtHomeSystem.Text = "Random";
        this.txtHomeSystem.TextAlign = HorizontalAlignment.Center;
        this.label3.AutoSize = true;
        this.label3.Dock = DockStyle.Left;
        this.label3.Location = new Point(0, 0);
        this.label3.Margin = new Padding(3);
        this.label3.Name = "label3";
        this.label3.Size = new Size(72, 13);
        this.label3.TabIndex = 104;
        this.label3.Text = "Home System";
        this.cmdStation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdStation.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdStation.Location = new Point(380, 0);
        this.cmdStation.Margin = new Padding(0);
        this.cmdStation.Name = "cmdStation";
        this.cmdStation.Size = new Size(95, 30);
        this.cmdStation.TabIndex = 33;
        this.cmdStation.Tag = "1200";
        this.cmdStation.Text = "Change Station";
        this.cmdStation.UseVisualStyleBackColor = false;
        this.cmdStation.Click += this.cmdStation_Click;
        this.cmdHull.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdHull.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdHull.Location = new Point(285, 0);
        this.cmdHull.Margin = new Padding(0);
        this.cmdHull.Name = "cmdHull";
        this.cmdHull.Size = new Size(95, 30);
        this.cmdHull.TabIndex = 32 /*0x20*/;
        this.cmdHull.Tag = "1200";
        this.cmdHull.Text = "Change Hull";
        this.cmdHull.UseVisualStyleBackColor = false;
        this.cmdHull.Click += this.cmdHull_Click;
        this.cmdRaceFlag.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRaceFlag.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRaceFlag.Location = new Point(190, 0);
        this.cmdRaceFlag.Margin = new Padding(0);
        this.cmdRaceFlag.Name = "cmdRaceFlag";
        this.cmdRaceFlag.Size = new Size(95, 30);
        this.cmdRaceFlag.TabIndex = 31 /*0x1F*/;
        this.cmdRaceFlag.Tag = "1200";
        this.cmdRaceFlag.Text = "Change Flag";
        this.cmdRaceFlag.UseVisualStyleBackColor = false;
        this.cmdRaceFlag.Click += this.cmdRaceFlag_Click;
        this.cmdSpeciesImage.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSpeciesImage.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSpeciesImage.Location = new Point(95, 0);
        this.cmdSpeciesImage.Margin = new Padding(0);
        this.cmdSpeciesImage.Name = "cmdSpeciesImage";
        this.cmdSpeciesImage.Size = new Size(95, 30);
        this.cmdSpeciesImage.TabIndex = 30;
        this.cmdSpeciesImage.Tag = "1200";
        this.cmdSpeciesImage.Text = "Change Image";
        this.cmdSpeciesImage.UseVisualStyleBackColor = false;
        this.cmdSpeciesImage.Click += this.cmdSpeciesImage_Click;
        this.cmdCreate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreate.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdCreate.Location = new Point(0, 0);
        this.cmdCreate.Margin = new Padding(0);
        this.cmdCreate.Name = "cmdCreate";
        this.cmdCreate.Size = new Size(95, 30);
        this.cmdCreate.TabIndex = 29;
        this.cmdCreate.Tag = "1200";
        this.cmdCreate.Text = "Create NPR";
        this.cmdCreate.UseVisualStyleBackColor = false;
        this.cmdCreate.Click += this.cmdCreate_Click;
        this.flowLayoutPanel1.Controls.Add(this.cmdCreate);
        this.flowLayoutPanel1.Controls.Add(this.cmdSpeciesImage);
        this.flowLayoutPanel1.Controls.Add(this.cmdRaceFlag);
        this.flowLayoutPanel1.Controls.Add(this.cmdHull);
        this.flowLayoutPanel1.Controls.Add(this.cmdStation);
        this.flowLayoutPanel1.Controls.Add(this.cmdSelectSystem);
        this.flowLayoutPanel1.Location = new Point(7, 652);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(716, 30);
        this.flowLayoutPanel1.TabIndex = 147;
        this.cmdSelectSystem.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSelectSystem.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSelectSystem.Location = new Point(475, 0);
        this.cmdSelectSystem.Margin = new Padding(0);
        this.cmdSelectSystem.Name = "cmdSelectSystem";
        this.cmdSelectSystem.Size = new Size(95, 30);
        this.cmdSelectSystem.TabIndex = 34;
        this.cmdSelectSystem.Tag = "1200";
        this.cmdSelectSystem.Text = "Home System";
        this.cmdSelectSystem.UseVisualStyleBackColor = false;
        this.cmdSelectSystem.Click += this.cmdSelectSystem_Click;
        this.flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel7);
        this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel8);
        this.flowLayoutPanel4.Location = new Point(305, 6);
        this.flowLayoutPanel4.Name = "flowLayoutPanel4";
        this.flowLayoutPanel4.Size = new Size(662, 90);
        this.flowLayoutPanel4.TabIndex = 150;
        this.flowLayoutPanel4.WrapContents = false;
        this.flowLayoutPanel7.Controls.Add(this.panel5);
        this.flowLayoutPanel7.Controls.Add(this.panel1);
        this.flowLayoutPanel7.Controls.Add(this.panel3);
        this.flowLayoutPanel7.Location = new Point(0, 0);
        this.flowLayoutPanel7.Margin = new Padding(0, 0, 3, 3);
        this.flowLayoutPanel7.Name = "flowLayoutPanel7";
        this.flowLayoutPanel7.Size = new Size(326, 82);
        this.flowLayoutPanel7.TabIndex = 158;
        this.panel5.Controls.Add(this.cboCommanderTheme);
        this.panel5.Controls.Add(this.label21);
        this.panel5.Location = new Point(3, 3);
        this.panel5.Name = "panel5";
        this.panel5.Size = new Size(315, 22);
        this.panel5.TabIndex = 118;
        this.cboCommanderTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboCommanderTheme.Dock = DockStyle.Right;
        this.cboCommanderTheme.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboCommanderTheme.FormattingEnabled = true;
        this.cboCommanderTheme.Location = new Point(93, 0);
        this.cboCommanderTheme.Margin = new Padding(3, 3, 3, 0);
        this.cboCommanderTheme.Name = "cboCommanderTheme";
        this.cboCommanderTheme.Size = new Size(222, 21);
        this.cboCommanderTheme.TabIndex = 5;
        this.label21.AutoSize = true;
        this.label21.Location = new Point(6, 3);
        this.label21.Margin = new Padding(3);
        this.label21.Name = "label21";
        this.label21.Padding = new Padding(0, 3, 0, 0);
        this.label21.Size = new Size(71, 16 /*0x10*/);
        this.label21.TabIndex = 104;
        this.label21.Text = "Name Theme";
        this.panel1.Controls.Add(this.cboSystemTheme);
        this.panel1.Controls.Add(this.label18);
        this.panel1.Location = new Point(3, 31 /*0x1F*/);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(315, 22);
        this.panel1.TabIndex = 115;
        this.cboSystemTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSystemTheme.Dock = DockStyle.Right;
        this.cboSystemTheme.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboSystemTheme.FormattingEnabled = true;
        this.cboSystemTheme.Location = new Point(93, 0);
        this.cboSystemTheme.Margin = new Padding(3, 3, 3, 0);
        this.cboSystemTheme.Name = "cboSystemTheme";
        this.cboSystemTheme.Size = new Size(222, 21);
        this.cboSystemTheme.TabIndex = 6;
        this.label18.AutoSize = true;
        this.label18.Location = new Point(6, 3);
        this.label18.Margin = new Padding(3);
        this.label18.Name = "label18";
        this.label18.Padding = new Padding(0, 3, 0, 0);
        this.label18.Size = new Size(77, 16 /*0x10*/);
        this.label18.TabIndex = 104;
        this.label18.Text = "System Theme";
        this.panel3.Controls.Add(this.cboClassTheme);
        this.panel3.Controls.Add(this.label19);
        this.panel3.Location = new Point(3, 59);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(315, 22);
        this.panel3.TabIndex = 116;
        this.cboClassTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboClassTheme.Dock = DockStyle.Right;
        this.cboClassTheme.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboClassTheme.FormattingEnabled = true;
        this.cboClassTheme.Location = new Point(93, 0);
        this.cboClassTheme.Margin = new Padding(3, 3, 3, 0);
        this.cboClassTheme.Name = "cboClassTheme";
        this.cboClassTheme.Size = new Size(222, 21);
        this.cboClassTheme.TabIndex = 7;
        this.label19.AutoSize = true;
        this.label19.Location = new Point(6, 3);
        this.label19.Margin = new Padding(3);
        this.label19.Name = "label19";
        this.label19.Padding = new Padding(0, 3, 0, 0);
        this.label19.Size = new Size(68, 16 /*0x10*/);
        this.label19.TabIndex = 104;
        this.label19.Text = "Class Theme";
        this.flowLayoutPanel8.Controls.Add(this.panel4);
        this.flowLayoutPanel8.Controls.Add(this.panel2);
        this.flowLayoutPanel8.Controls.Add(this.panel7);
        this.flowLayoutPanel8.Location = new Point(329, 0);
        this.flowLayoutPanel8.Margin = new Padding(0, 0, 3, 3);
        this.flowLayoutPanel8.Name = "flowLayoutPanel8";
        this.flowLayoutPanel8.Size = new Size(326, 84);
        this.flowLayoutPanel8.TabIndex = 159;
        this.panel4.Controls.Add(this.cboRankTheme);
        this.panel4.Controls.Add(this.label20);
        this.panel4.Location = new Point(3, 3);
        this.panel4.Name = "panel4";
        this.panel4.Size = new Size(315, 22);
        this.panel4.TabIndex = 117;
        this.cboRankTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRankTheme.Dock = DockStyle.Right;
        this.cboRankTheme.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboRankTheme.FormattingEnabled = true;
        this.cboRankTheme.Location = new Point(93, 0);
        this.cboRankTheme.Margin = new Padding(3, 3, 3, 0);
        this.cboRankTheme.Name = "cboRankTheme";
        this.cboRankTheme.Size = new Size(222, 21);
        this.cboRankTheme.TabIndex = 8;
        this.label20.AutoSize = true;
        this.label20.Location = new Point(6, 3);
        this.label20.Margin = new Padding(3);
        this.label20.Name = "label20";
        this.label20.Padding = new Padding(0, 3, 0, 0);
        this.label20.Size = new Size(69, 16 /*0x10*/);
        this.label20.TabIndex = 104;
        this.label20.Text = "Rank Theme";
        this.panel2.Controls.Add(this.cboGroundTheme);
        this.panel2.Controls.Add(this.label1);
        this.panel2.Location = new Point(3, 31 /*0x1F*/);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(315, 22);
        this.panel2.TabIndex = 119;
        this.cboGroundTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboGroundTheme.Dock = DockStyle.Right;
        this.cboGroundTheme.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboGroundTheme.FormattingEnabled = true;
        this.cboGroundTheme.Location = new Point(93, 0);
        this.cboGroundTheme.Margin = new Padding(3, 3, 3, 0);
        this.cboGroundTheme.Name = "cboGroundTheme";
        this.cboGroundTheme.Size = new Size(222, 21);
        this.cboGroundTheme.TabIndex = 9;
        this.label1.AutoSize = true;
        this.label1.Location = new Point(6, 3);
        this.label1.Margin = new Padding(3);
        this.label1.Name = "label1";
        this.label1.Padding = new Padding(0, 3, 0, 0);
        this.label1.Size = new Size(78, 16 /*0x10*/);
        this.label1.TabIndex = 104;
        this.label1.Text = "Ground Theme";
        this.panel7.Controls.Add(this.cboMissileTheme);
        this.panel7.Controls.Add(this.label2);
        this.panel7.Location = new Point(3, 59);
        this.panel7.Name = "panel7";
        this.panel7.Size = new Size(315, 22);
        this.panel7.TabIndex = 120;
        this.cboMissileTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboMissileTheme.Dock = DockStyle.Right;
        this.cboMissileTheme.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboMissileTheme.FormattingEnabled = true;
        this.cboMissileTheme.Location = new Point(93, 0);
        this.cboMissileTheme.Margin = new Padding(3, 3, 3, 0);
        this.cboMissileTheme.Name = "cboMissileTheme";
        this.cboMissileTheme.Size = new Size(222, 21);
        this.cboMissileTheme.TabIndex = 10;
        this.label2.AutoSize = true;
        this.label2.Location = new Point(6, 3);
        this.label2.Margin = new Padding(3);
        this.label2.Name = "label2";
        this.label2.Padding = new Padding(0, 3, 0, 0);
        this.label2.Size = new Size(74, 16 /*0x10*/);
        this.label2.TabIndex = 104;
        this.label2.Text = "Missile Theme";
        this.lstTerrain.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstTerrain.ColumnWidth = 150;
        this.lstTerrain.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstTerrain.FormattingEnabled = true;
        this.lstTerrain.Location = new Point(497, 281);
        this.lstTerrain.MultiColumn = true;
        this.lstTerrain.Name = "lstTerrain";
        this.lstTerrain.Size = new Size(470, 364);
        this.lstTerrain.TabIndex = 151;
        this.flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel2.Controls.Add(this.panel9);
        this.flowLayoutPanel2.Controls.Add(this.panel10);
        this.flowLayoutPanel2.Controls.Add(this.panel12);
        this.flowLayoutPanel2.Controls.Add(this.panel11);
        this.flowLayoutPanel2.Controls.Add(this.panel21);
        this.flowLayoutPanel2.Controls.Add(this.panel22);
        this.flowLayoutPanel2.Controls.Add(this.panel23);
        this.flowLayoutPanel2.Location = new Point(6, 525);
        this.flowLayoutPanel2.Name = "flowLayoutPanel2";
        this.flowLayoutPanel2.Size = new Size(485, 120);
        this.flowLayoutPanel2.TabIndex = 152;
        this.panel9.Controls.Add(this.cboUseShields);
        this.panel9.Controls.Add(this.label5);
        this.panel9.Location = new Point(0, 3);
        this.panel9.Margin = new Padding(0, 3, 3, 3);
        this.panel9.Name = "panel9";
        this.panel9.Size = new Size(210, 22);
        this.panel9.TabIndex = 150;
        this.cboUseShields.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboUseShields.Dock = DockStyle.Right;
        this.cboUseShields.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboUseShields.FormattingEnabled = true;
        this.cboUseShields.Location = new Point(90, 0);
        this.cboUseShields.Margin = new Padding(3, 3, 3, 0);
        this.cboUseShields.Name = "cboUseShields";
        this.cboUseShields.Size = new Size(120, 21);
        this.cboUseShields.TabIndex = 25;
        this.label5.AutoSize = true;
        this.label5.Location = new Point(6, 3);
        this.label5.Margin = new Padding(3);
        this.label5.Name = "label5";
        this.label5.Padding = new Padding(0, 3, 0, 0);
        this.label5.Size = new Size(63 /*0x3F*/, 16 /*0x10*/);
        this.label5.TabIndex = 104;
        this.label5.Text = "Use Shields";
        this.panel10.Controls.Add(this.cboPrimaryBeam);
        this.panel10.Controls.Add(this.label6);
        this.panel10.Location = new Point(225, 3);
        this.panel10.Margin = new Padding(12, 3, 3, 3);
        this.panel10.Name = "panel10";
        this.panel10.Size = new Size(250, 22);
        this.panel10.TabIndex = 151;
        this.cboPrimaryBeam.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboPrimaryBeam.Dock = DockStyle.Right;
        this.cboPrimaryBeam.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboPrimaryBeam.FormattingEnabled = true;
        this.cboPrimaryBeam.Location = new Point(130, 0);
        this.cboPrimaryBeam.Margin = new Padding(3, 3, 3, 0);
        this.cboPrimaryBeam.Name = "cboPrimaryBeam";
        this.cboPrimaryBeam.Size = new Size(120, 21);
        this.cboPrimaryBeam.TabIndex = 27;
        this.label6.AutoSize = true;
        this.label6.Location = new Point(6, 3);
        this.label6.Margin = new Padding(3);
        this.label6.Name = "label6";
        this.label6.Padding = new Padding(0, 3, 0, 0);
        this.label6.Size = new Size(84, 16 /*0x10*/);
        this.label6.TabIndex = 104;
        this.label6.Text = "Energy Weapon";
        this.panel12.Controls.Add(this.cboUseMissiles);
        this.panel12.Controls.Add(this.label8);
        this.panel12.Location = new Point(0, 31 /*0x1F*/);
        this.panel12.Margin = new Padding(0, 3, 3, 3);
        this.panel12.Name = "panel12";
        this.panel12.Size = new Size(210, 22);
        this.panel12.TabIndex = 153;
        this.cboUseMissiles.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboUseMissiles.Dock = DockStyle.Right;
        this.cboUseMissiles.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboUseMissiles.FormattingEnabled = true;
        this.cboUseMissiles.Location = new Point(90, 0);
        this.cboUseMissiles.Margin = new Padding(3, 3, 3, 0);
        this.cboUseMissiles.Name = "cboUseMissiles";
        this.cboUseMissiles.Size = new Size(120, 21);
        this.cboUseMissiles.TabIndex = 26;
        this.label8.AutoSize = true;
        this.label8.Location = new Point(6, 3);
        this.label8.Margin = new Padding(3);
        this.label8.Name = "label8";
        this.label8.Padding = new Padding(0, 3, 0, 0);
        this.label8.Size = new Size(63 /*0x3F*/, 16 /*0x10*/);
        this.label8.TabIndex = 104;
        this.label8.Text = "Missile User";
        this.panel11.Controls.Add(this.cboPDBeam);
        this.panel11.Controls.Add(this.label7);
        this.panel11.Location = new Point(225, 31 /*0x1F*/);
        this.panel11.Margin = new Padding(12, 3, 3, 3);
        this.panel11.Name = "panel11";
        this.panel11.Size = new Size(250, 22);
        this.panel11.TabIndex = 152;
        this.cboPDBeam.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboPDBeam.Dock = DockStyle.Right;
        this.cboPDBeam.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboPDBeam.FormattingEnabled = true;
        this.cboPDBeam.Location = new Point(130, 0);
        this.cboPDBeam.Margin = new Padding(3, 3, 3, 0);
        this.cboPDBeam.Name = "cboPDBeam";
        this.cboPDBeam.Size = new Size(120, 21);
        this.cboPDBeam.TabIndex = 28;
        this.label7.AutoSize = true;
        this.label7.Location = new Point(6, 3);
        this.label7.Margin = new Padding(3);
        this.label7.Name = "label7";
        this.label7.Padding = new Padding(0, 3, 0, 0);
        this.label7.Size = new Size(102, 16 /*0x10*/);
        this.label7.TabIndex = 104;
        this.label7.Text = "PD Energy Weapon";
        this.panel21.Controls.Add(this.cboUseCarriers);
        this.panel21.Controls.Add(this.label17);
        this.panel21.Location = new Point(0, 59);
        this.panel21.Margin = new Padding(0, 3, 3, 3);
        this.panel21.Name = "panel21";
        this.panel21.Size = new Size(210, 22);
        this.panel21.TabIndex = 154;
        this.cboUseCarriers.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboUseCarriers.Dock = DockStyle.Right;
        this.cboUseCarriers.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboUseCarriers.FormattingEnabled = true;
        this.cboUseCarriers.Location = new Point(90, 0);
        this.cboUseCarriers.Margin = new Padding(3, 3, 3, 0);
        this.cboUseCarriers.Name = "cboUseCarriers";
        this.cboUseCarriers.Size = new Size(120, 21);
        this.cboUseCarriers.TabIndex = 25;
        this.label17.AutoSize = true;
        this.label17.Location = new Point(6, 3);
        this.label17.Margin = new Padding(3);
        this.label17.Name = "label17";
        this.label17.Padding = new Padding(0, 3, 0, 0);
        this.label17.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
        this.label17.TabIndex = 104;
        this.label17.Text = "Use Carriers";
        this.panel22.Controls.Add(this.cboHybrids);
        this.panel22.Controls.Add(this.label23);
        this.panel22.Location = new Point(225, 59);
        this.panel22.Margin = new Padding(12, 3, 3, 3);
        this.panel22.Name = "panel22";
        this.panel22.Size = new Size(250, 22);
        this.panel22.TabIndex = 157;
        this.cboHybrids.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboHybrids.Dock = DockStyle.Right;
        this.cboHybrids.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboHybrids.FormattingEnabled = true;
        this.cboHybrids.Location = new Point(130, 0);
        this.cboHybrids.Margin = new Padding(3, 3, 3, 0);
        this.cboHybrids.Name = "cboHybrids";
        this.cboHybrids.Size = new Size(120, 21);
        this.cboHybrids.TabIndex = 28;
        this.label23.AutoSize = true;
        this.label23.Location = new Point(6, 3);
        this.label23.Margin = new Padding(3);
        this.label23.Name = "label23";
        this.label23.Padding = new Padding(0, 3, 0, 0);
        this.label23.Size = new Size(98, 16 /*0x10*/);
        this.label23.TabIndex = 104;
        this.label23.Text = "Carriers are Hybrids";
        this.panel23.Controls.Add(this.cboBalanced);
        this.panel23.Controls.Add(this.label26);
        this.panel23.Location = new Point(0, 87);
        this.panel23.Margin = new Padding(0, 3, 3, 3);
        this.panel23.Name = "panel23";
        this.panel23.Size = new Size(210, 22);
        this.panel23.TabIndex = 156;
        this.cboBalanced.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboBalanced.Dock = DockStyle.Right;
        this.cboBalanced.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboBalanced.FormattingEnabled = true;
        this.cboBalanced.Location = new Point(90, 0);
        this.cboBalanced.Margin = new Padding(3, 3, 3, 0);
        this.cboBalanced.Name = "cboBalanced";
        this.cboBalanced.Size = new Size(120, 21);
        this.cboBalanced.TabIndex = 25;
        this.label26.AutoSize = true;
        this.label26.Location = new Point(6, 3);
        this.label26.Margin = new Padding(3);
        this.label26.Name = "label26";
        this.label26.Padding = new Padding(0, 3, 0, 0);
        this.label26.Size = new Size(78, 16 /*0x10*/);
        this.label26.TabIndex = 104;
        this.label26.Text = "Balanced Fleet";
        this.panel36.Controls.Add(this.txtDet);
        this.panel36.Controls.Add(this.label36);
        this.panel36.Location = new Point(3, 51);
        this.panel36.Margin = new Padding(3, 5, 3, 3);
        this.panel36.Name = "panel36";
        this.panel36.Size = new Size(190, 15);
        this.panel36.TabIndex = 137;
        this.txtDet.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDet.BorderStyle = BorderStyle.None;
        this.txtDet.Dock = DockStyle.Right;
        this.txtDet.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtDet.Location = new Point(130, 0);
        this.txtDet.Name = "txtDet";
        this.txtDet.Size = new Size(60, 13);
        this.txtDet.TabIndex = 20;
        this.txtDet.Text = "0";
        this.txtDet.TextAlign = HorizontalAlignment.Center;
        this.label36.AutoSize = true;
        this.label36.Dock = DockStyle.Left;
        this.label36.Location = new Point(0, 0);
        this.label36.Margin = new Padding(3);
        this.label36.Name = "label36";
        this.label36.Size = new Size(114, 13);
        this.label36.TabIndex = 104;
        this.label36.Text = "Determination (1 - 100)";
        this.panel37.Controls.Add(this.txtDip);
        this.panel37.Controls.Add(this.label37);
        this.panel37.Location = new Point(3, 97);
        this.panel37.Margin = new Padding(3, 5, 3, 3);
        this.panel37.Name = "panel37";
        this.panel37.Size = new Size(190, 15);
        this.panel37.TabIndex = 138;
        this.txtDip.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDip.BorderStyle = BorderStyle.None;
        this.txtDip.Dock = DockStyle.Right;
        this.txtDip.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtDip.Location = new Point(130, 0);
        this.txtDip.Name = "txtDip";
        this.txtDip.Size = new Size(60, 13);
        this.txtDip.TabIndex = 22;
        this.txtDip.Text = "0";
        this.txtDip.TextAlign = HorizontalAlignment.Center;
        this.label37.AutoSize = true;
        this.label37.Dock = DockStyle.Left;
        this.label37.Location = new Point(0, 0);
        this.label37.Margin = new Padding(3);
        this.label37.Name = "label37";
        this.label37.Size = new Size(98, 13);
        this.label37.TabIndex = 104;
        this.label37.Text = "Diplomacy (1 - 100)";
        this.panel38.Controls.Add(this.txtExp);
        this.panel38.Controls.Add(this.label38);
        this.panel38.Location = new Point(3, 74);
        this.panel38.Margin = new Padding(3, 5, 3, 3);
        this.panel38.Name = "panel38";
        this.panel38.Size = new Size(190, 15);
        this.panel38.TabIndex = 139;
        this.txtExp.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtExp.BorderStyle = BorderStyle.None;
        this.txtExp.Dock = DockStyle.Right;
        this.txtExp.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtExp.Location = new Point(130, 0);
        this.txtExp.Name = "txtExp";
        this.txtExp.Size = new Size(60, 13);
        this.txtExp.TabIndex = 21;
        this.txtExp.Text = "0";
        this.txtExp.TextAlign = HorizontalAlignment.Center;
        this.label38.AutoSize = true;
        this.label38.Dock = DockStyle.Left;
        this.label38.Location = new Point(0, 0);
        this.label38.Margin = new Padding(3);
        this.label38.Name = "label38";
        this.label38.Size = new Size(98, 13);
        this.label38.TabIndex = 104;
        this.label38.Text = "Expansion (1 - 100)";
        this.panel39.Controls.Add(this.txtMil);
        this.panel39.Controls.Add(this.label39);
        this.panel39.Location = new Point(3, 28);
        this.panel39.Margin = new Padding(3, 5, 3, 3);
        this.panel39.Name = "panel39";
        this.panel39.Size = new Size(190, 15);
        this.panel39.TabIndex = 140;
        this.txtMil.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMil.BorderStyle = BorderStyle.None;
        this.txtMil.Dock = DockStyle.Right;
        this.txtMil.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtMil.Location = new Point(130, 0);
        this.txtMil.Name = "txtMil";
        this.txtMil.Size = new Size(60, 13);
        this.txtMil.TabIndex = 19;
        this.txtMil.Text = "0";
        this.txtMil.TextAlign = HorizontalAlignment.Center;
        this.label39.AutoSize = true;
        this.label39.Dock = DockStyle.Left;
        this.label39.Location = new Point(0, 0);
        this.label39.Margin = new Padding(3);
        this.label39.Name = "label39";
        this.label39.Size = new Size(90, 13);
        this.label39.TabIndex = 104;
        this.label39.Text = "Militancy (1 - 100)";
        this.panel40.Controls.Add(this.txtTrade);
        this.panel40.Controls.Add(this.label40);
        this.panel40.Location = new Point(3, 120);
        this.panel40.Margin = new Padding(3, 5, 3, 3);
        this.panel40.Name = "panel40";
        this.panel40.Size = new Size(190, 15);
        this.panel40.TabIndex = 141;
        this.txtTrade.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTrade.BorderStyle = BorderStyle.None;
        this.txtTrade.Dock = DockStyle.Right;
        this.txtTrade.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtTrade.Location = new Point(130, 0);
        this.txtTrade.Name = "txtTrade";
        this.txtTrade.Size = new Size(60, 13);
        this.txtTrade.TabIndex = 23;
        this.txtTrade.Text = "0";
        this.txtTrade.TextAlign = HorizontalAlignment.Center;
        this.label40.AutoSize = true;
        this.label40.Dock = DockStyle.Left;
        this.label40.Location = new Point(0, 0);
        this.label40.Margin = new Padding(3);
        this.label40.Name = "label40";
        this.label40.Size = new Size(77, 13);
        this.label40.TabIndex = 104;
        this.label40.Text = "Trade (1 - 100)";
        this.panel41.Controls.Add(this.txtTrans);
        this.panel41.Controls.Add(this.label41);
        this.panel41.Location = new Point(3, 143);
        this.panel41.Margin = new Padding(3, 5, 3, 3);
        this.panel41.Name = "panel41";
        this.panel41.Size = new Size(190, 15);
        this.panel41.TabIndex = 142;
        this.txtTrans.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTrans.BorderStyle = BorderStyle.None;
        this.txtTrans.Dock = DockStyle.Right;
        this.txtTrans.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtTrans.Location = new Point(130, 0);
        this.txtTrans.Name = "txtTrans";
        this.txtTrans.Size = new Size(60, 13);
        this.txtTrans.TabIndex = 24;
        this.txtTrans.Text = "0";
        this.txtTrans.TextAlign = HorizontalAlignment.Center;
        this.label41.AutoSize = true;
        this.label41.Dock = DockStyle.Left;
        this.label41.Location = new Point(0, 0);
        this.label41.Margin = new Padding(3);
        this.label41.Name = "label41";
        this.label41.Size = new Size(110, 13);
        this.label41.TabIndex = 104;
        this.label41.Text = "Translation (-25 to 25)";
        this.panel42.Controls.Add(this.txtXen);
        this.panel42.Controls.Add(this.label42);
        this.panel42.Location = new Point(3, 5);
        this.panel42.Margin = new Padding(3, 5, 3, 3);
        this.panel42.Name = "panel42";
        this.panel42.Size = new Size(190, 15);
        this.panel42.TabIndex = 143;
        this.txtXen.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtXen.BorderStyle = BorderStyle.None;
        this.txtXen.Dock = DockStyle.Right;
        this.txtXen.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtXen.Location = new Point(130, 0);
        this.txtXen.Name = "txtXen";
        this.txtXen.Size = new Size(60, 13);
        this.txtXen.TabIndex = 18;
        this.txtXen.Text = "0";
        this.txtXen.TextAlign = HorizontalAlignment.Center;
        this.label42.AutoSize = true;
        this.label42.Dock = DockStyle.Left;
        this.label42.Location = new Point(0, 0);
        this.label42.Margin = new Padding(3);
        this.label42.Name = "label42";
        this.label42.Size = new Size(106, 13);
        this.label42.TabIndex = 104;
        this.label42.Text = "Xenophobia (1 - 100)";
        this.panel26.Controls.Add(this.txtGrowth);
        this.panel26.Controls.Add(this.label10);
        this.panel26.Location = new Point(3, 74);
        this.panel26.Margin = new Padding(3, 5, 3, 3);
        this.panel26.Name = "panel26";
        this.panel26.Size = new Size(260, 15);
        this.panel26.TabIndex = 144 /*0x90*/;
        this.txtGrowth.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtGrowth.BorderStyle = BorderStyle.None;
        this.txtGrowth.Dock = DockStyle.Right;
        this.txtGrowth.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtGrowth.Location = new Point(200, 0);
        this.txtGrowth.Name = "txtGrowth";
        this.txtGrowth.Size = new Size(60, 13);
        this.txtGrowth.TabIndex = 14;
        this.txtGrowth.Text = "0";
        this.txtGrowth.TextAlign = HorizontalAlignment.Center;
        this.label10.AutoSize = true;
        this.label10.Dock = DockStyle.Left;
        this.label10.Location = new Point(0, 0);
        this.label10.Margin = new Padding(3);
        this.label10.Name = "label10";
        this.label10.Size = new Size(179, 13);
        this.label10.TabIndex = 104;
        this.label10.Text = "Population Growth Modifier (0.5 to 3)";
        this.panel27.Controls.Add(this.txtResearch);
        this.panel27.Controls.Add(this.label11);
        this.panel27.Location = new Point(3, 51);
        this.panel27.Margin = new Padding(3, 5, 3, 3);
        this.panel27.Name = "panel27";
        this.panel27.Size = new Size(260, 15);
        this.panel27.TabIndex = 145;
        this.txtResearch.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtResearch.BorderStyle = BorderStyle.None;
        this.txtResearch.Dock = DockStyle.Right;
        this.txtResearch.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtResearch.Location = new Point(200, 0);
        this.txtResearch.Name = "txtResearch";
        this.txtResearch.Size = new Size(60, 13);
        this.txtResearch.TabIndex = 13;
        this.txtResearch.Text = "0";
        this.txtResearch.TextAlign = HorizontalAlignment.Center;
        this.label11.AutoSize = true;
        this.label11.Dock = DockStyle.Left;
        this.label11.Location = new Point(0, 0);
        this.label11.Margin = new Padding(3);
        this.label11.Name = "label11";
        this.label11.Size = new Size(164, 13);
        this.label11.TabIndex = 104;
        this.label11.Text = "Research Rate Modifier (0.5 to 3)";
        this.panel28.Controls.Add(this.txtProduction);
        this.panel28.Controls.Add(this.label12);
        this.panel28.Location = new Point(3, 28);
        this.panel28.Margin = new Padding(3, 5, 3, 3);
        this.panel28.Name = "panel28";
        this.panel28.Size = new Size(260, 15);
        this.panel28.TabIndex = 146;
        this.txtProduction.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtProduction.BorderStyle = BorderStyle.None;
        this.txtProduction.Dock = DockStyle.Right;
        this.txtProduction.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtProduction.Location = new Point(200, 0);
        this.txtProduction.Name = "txtProduction";
        this.txtProduction.Size = new Size(60, 13);
        this.txtProduction.TabIndex = 12;
        this.txtProduction.Text = "0";
        this.txtProduction.TextAlign = HorizontalAlignment.Center;
        this.label12.AutoSize = true;
        this.label12.Dock = DockStyle.Left;
        this.label12.Location = new Point(0, 0);
        this.label12.Margin = new Padding(3);
        this.label12.Name = "label12";
        this.label12.Size = new Size(181, 13);
        this.label12.TabIndex = 104;
        this.label12.Text = "Factory Production Modifier (0.5 to 3)";
        this.pbRace.BorderStyle = BorderStyle.FixedSingle;
        this.pbRace.Location = new Point(6, 101);
        this.pbRace.Margin = new Padding(3, 0, 3, 3);
        this.pbRace.Name = "pbRace";
        this.pbRace.Size = new Size(215, 175);
        this.pbRace.SizeMode = PictureBoxSizeMode.StretchImage;
        this.pbRace.TabIndex = 154;
        this.pbRace.TabStop = false;
        this.flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel3.Controls.Add(this.pbShip);
        this.flowLayoutPanel3.Location = new Point(227, 101);
        this.flowLayoutPanel3.Margin = new Padding(3, 0, 3, 0);
        this.flowLayoutPanel3.Name = "flowLayoutPanel3";
        this.flowLayoutPanel3.Size = new Size(215, 175);
        this.flowLayoutPanel3.TabIndex = 155;
        this.pbShip.Location = new Point(21, 0);
        this.pbShip.Margin = new Padding(21, 0, 3, 3);
        this.pbShip.Name = "pbShip";
        this.pbShip.Size = new Size(175, 175);
        this.pbShip.SizeMode = PictureBoxSizeMode.Zoom;
        this.pbShip.TabIndex = 134;
        this.pbShip.TabStop = false;
        this.flowLayoutPanel6.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel6.Controls.Add(this.pbStation);
        this.flowLayoutPanel6.Location = new Point(448, 101);
        this.flowLayoutPanel6.Margin = new Padding(3, 0, 3, 0);
        this.flowLayoutPanel6.Name = "flowLayoutPanel6";
        this.flowLayoutPanel6.Size = new Size(215, 175);
        this.flowLayoutPanel6.TabIndex = 156;
        this.pbStation.Anchor = AnchorStyles.None;
        this.pbStation.Location = new Point(21, 0);
        this.pbStation.Margin = new Padding(21, 0, 3, 3);
        this.pbStation.Name = "pbStation";
        this.pbStation.Size = new Size(175, 175);
        this.pbStation.SizeMode = PictureBoxSizeMode.Zoom;
        this.pbStation.TabIndex = 144 /*0x90*/;
        this.pbStation.TabStop = false;
        this.pbFlag.BackgroundImageLayout = ImageLayout.None;
        this.pbFlag.BorderStyle = BorderStyle.FixedSingle;
        this.pbFlag.Location = new Point(669, 101);
        this.pbFlag.Margin = new Padding(3, 0, 3, 3);
        this.pbFlag.Name = "pbFlag";
        this.pbFlag.Size = new Size(298, 175);
        this.pbFlag.SizeMode = PictureBoxSizeMode.StretchImage;
        this.pbFlag.TabIndex = 153;
        this.pbFlag.TabStop = false;
        this.flpModifiers.BorderStyle = BorderStyle.FixedSingle;
        this.flpModifiers.Controls.Add(this.panel14);
        this.flpModifiers.Controls.Add(this.panel28);
        this.flpModifiers.Controls.Add(this.panel27);
        this.flpModifiers.Controls.Add(this.panel26);
        this.flpModifiers.Controls.Add(this.panel47);
        this.flpModifiers.Controls.Add(this.panel19);
        this.flpModifiers.Controls.Add(this.panel13);
        this.flpModifiers.Controls.Add(this.panel17);
        this.flpModifiers.Controls.Add(this.panel18);
        this.flpModifiers.Controls.Add(this.panel20);
        this.flpModifiers.Location = new Point(6, 281);
        this.flpModifiers.Name = "flpModifiers";
        this.flpModifiers.Size = new Size(271, 238);
        this.flpModifiers.TabIndex = 157;
        this.panel14.Controls.Add(this.txtPopSizeMod);
        this.panel14.Controls.Add(this.label13);
        this.panel14.Location = new Point(3, 5);
        this.panel14.Margin = new Padding(3, 5, 3, 3);
        this.panel14.Name = "panel14";
        this.panel14.Size = new Size(260, 15);
        this.panel14.TabIndex = 150;
        this.txtPopSizeMod.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtPopSizeMod.BorderStyle = BorderStyle.None;
        this.txtPopSizeMod.Dock = DockStyle.Right;
        this.txtPopSizeMod.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtPopSizeMod.Location = new Point(200, 0);
        this.txtPopSizeMod.Name = "txtPopSizeMod";
        this.txtPopSizeMod.Size = new Size(60, 13);
        this.txtPopSizeMod.TabIndex = 11;
        this.txtPopSizeMod.Text = "0";
        this.txtPopSizeMod.TextAlign = HorizontalAlignment.Center;
        this.label13.AutoSize = true;
        this.label13.Dock = DockStyle.Left;
        this.label13.Location = new Point(0, 0);
        this.label13.Margin = new Padding(3);
        this.label13.Name = "label13";
        this.label13.Size = new Size(165, 13);
        this.label13.TabIndex = 104;
        this.label13.Text = "Population Size Modifier (0.2 to 5)";
        this.panel47.Controls.Add(this.txtBP);
        this.panel47.Controls.Add(this.label47);
        this.panel47.Location = new Point(3, 97);
        this.panel47.Margin = new Padding(3, 5, 3, 3);
        this.panel47.Name = "panel47";
        this.panel47.Size = new Size(260, 15);
        this.panel47.TabIndex = 148;
        this.txtBP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtBP.BorderStyle = BorderStyle.None;
        this.txtBP.Dock = DockStyle.Right;
        this.txtBP.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtBP.Location = new Point(200, 0);
        this.txtBP.Name = "txtBP";
        this.txtBP.Size = new Size(60, 13);
        this.txtBP.TabIndex = 15;
        this.txtBP.Text = "0";
        this.txtBP.TextAlign = HorizontalAlignment.Center;
        this.label47.AutoSize = true;
        this.label47.Dock = DockStyle.Left;
        this.label47.Location = new Point(0, 0);
        this.label47.Margin = new Padding(3);
        this.label47.Name = "label47";
        this.label47.Size = new Size(147, 13);
        this.label47.TabIndex = 104;
        this.label47.Text = "Build Points Modifier (0.5 to 3)";
        this.panel19.Controls.Add(this.txtTP);
        this.panel19.Controls.Add(this.label4);
        this.panel19.Location = new Point(3, 120);
        this.panel19.Margin = new Padding(3, 5, 3, 3);
        this.panel19.Name = "panel19";
        this.panel19.Size = new Size(260, 15);
        this.panel19.TabIndex = 147;
        this.txtTP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTP.BorderStyle = BorderStyle.None;
        this.txtTP.Dock = DockStyle.Right;
        this.txtTP.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtTP.Location = new Point(200, 0);
        this.txtTP.Name = "txtTP";
        this.txtTP.Size = new Size(60, 13);
        this.txtTP.TabIndex = 16 /*0x10*/;
        this.txtTP.Text = "0";
        this.txtTP.TextAlign = HorizontalAlignment.Center;
        this.label4.AutoSize = true;
        this.label4.Dock = DockStyle.Left;
        this.label4.Location = new Point(0, 0);
        this.label4.Margin = new Padding(3);
        this.label4.Name = "label4";
        this.label4.Size = new Size(149, 13);
        this.label4.TabIndex = 104;
        this.label4.Text = "Tech Points Modifier (0.5 to 3)";
        this.panel13.Controls.Add(this.txtSSM);
        this.panel13.Controls.Add(this.label9);
        this.panel13.Location = new Point(3, 143);
        this.panel13.Margin = new Padding(3, 5, 3, 3);
        this.panel13.Name = "panel13";
        this.panel13.Size = new Size(260, 15);
        this.panel13.TabIndex = 149;
        this.txtSSM.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSSM.BorderStyle = BorderStyle.None;
        this.txtSSM.Dock = DockStyle.Right;
        this.txtSSM.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtSSM.Location = new Point(200, 0);
        this.txtSSM.Name = "txtSSM";
        this.txtSSM.Size = new Size(60, 13);
        this.txtSSM.TabIndex = 17;
        this.txtSSM.Text = "0";
        this.txtSSM.TextAlign = HorizontalAlignment.Center;
        this.label9.AutoSize = true;
        this.label9.Dock = DockStyle.Left;
        this.label9.Location = new Point(0, 0);
        this.label9.Margin = new Padding(3);
        this.label9.Name = "label9";
        this.label9.Size = new Size(191, 13);
        this.label9.TabIndex = 104;
        this.label9.Text = "Ship Size Modifier (1 to 5). 1 = Random";
        this.panel17.Controls.Add(this.txtBaseExplored);
        this.panel17.Controls.Add(this.label14);
        this.panel17.Location = new Point(3, 166);
        this.panel17.Margin = new Padding(3, 5, 3, 3);
        this.panel17.Name = "panel17";
        this.panel17.Size = new Size(260, 15);
        this.panel17.TabIndex = 151;
        this.txtBaseExplored.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtBaseExplored.BorderStyle = BorderStyle.None;
        this.txtBaseExplored.Dock = DockStyle.Right;
        this.txtBaseExplored.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtBaseExplored.Location = new Point(200, 0);
        this.txtBaseExplored.Name = "txtBaseExplored";
        this.txtBaseExplored.Size = new Size(60, 13);
        this.txtBaseExplored.TabIndex = 11;
        this.txtBaseExplored.Text = "0";
        this.txtBaseExplored.TextAlign = HorizontalAlignment.Center;
        this.label14.AutoSize = true;
        this.label14.Dock = DockStyle.Left;
        this.label14.Location = new Point(0, 0);
        this.label14.Margin = new Padding(3);
        this.label14.Name = "label14";
        this.label14.Size = new Size(115, 13);
        this.label14.TabIndex = 104;
        this.label14.Text = "Base Explored Transits";
        this.panel18.Controls.Add(this.txtRandomExplored);
        this.panel18.Controls.Add(this.label15);
        this.panel18.Location = new Point(3, 189);
        this.panel18.Margin = new Padding(3, 5, 3, 3);
        this.panel18.Name = "panel18";
        this.panel18.Size = new Size(260, 15);
        this.panel18.TabIndex = 152;
        this.txtRandomExplored.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtRandomExplored.BorderStyle = BorderStyle.None;
        this.txtRandomExplored.Dock = DockStyle.Right;
        this.txtRandomExplored.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtRandomExplored.Location = new Point(200, 0);
        this.txtRandomExplored.Name = "txtRandomExplored";
        this.txtRandomExplored.Size = new Size(60, 13);
        this.txtRandomExplored.TabIndex = 11;
        this.txtRandomExplored.Text = "0";
        this.txtRandomExplored.TextAlign = HorizontalAlignment.Center;
        this.label15.AutoSize = true;
        this.label15.Dock = DockStyle.Left;
        this.label15.Location = new Point(0, 0);
        this.label15.Margin = new Padding(3);
        this.label15.Name = "label15";
        this.label15.Size = new Size(131, 13);
        this.label15.TabIndex = 104;
        this.label15.Text = "Random Explored Transits";
        this.panel20.Controls.Add(this.txtMaxStartingSystems);
        this.panel20.Controls.Add(this.label16);
        this.panel20.Location = new Point(3, 212);
        this.panel20.Margin = new Padding(3, 5, 3, 3);
        this.panel20.Name = "panel20";
        this.panel20.Size = new Size(260, 15);
        this.panel20.TabIndex = 153;
        this.txtMaxStartingSystems.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMaxStartingSystems.BorderStyle = BorderStyle.None;
        this.txtMaxStartingSystems.Dock = DockStyle.Right;
        this.txtMaxStartingSystems.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtMaxStartingSystems.Location = new Point(200, 0);
        this.txtMaxStartingSystems.Name = "txtMaxStartingSystems";
        this.txtMaxStartingSystems.Size = new Size(60, 13);
        this.txtMaxStartingSystems.TabIndex = 11;
        this.txtMaxStartingSystems.Text = "0";
        this.txtMaxStartingSystems.TextAlign = HorizontalAlignment.Center;
        this.label16.AutoSize = true;
        this.label16.Dock = DockStyle.Left;
        this.label16.Location = new Point(0, 0);
        this.label16.Margin = new Padding(3);
        this.label16.Name = "label16";
        this.label16.Size = new Size(132, 13);
        this.label16.TabIndex = 104;
        this.label16.Text = "Maximum Starting Systems";
        this.flowLayoutPanel9.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel9.Controls.Add(this.panel42);
        this.flowLayoutPanel9.Controls.Add(this.panel39);
        this.flowLayoutPanel9.Controls.Add(this.panel36);
        this.flowLayoutPanel9.Controls.Add(this.panel38);
        this.flowLayoutPanel9.Controls.Add(this.panel37);
        this.flowLayoutPanel9.Controls.Add(this.panel40);
        this.flowLayoutPanel9.Controls.Add(this.panel41);
        this.flowLayoutPanel9.Location = new Point(283, 281);
        this.flowLayoutPanel9.Name = "flowLayoutPanel9";
        this.flowLayoutPanel9.Size = new Size(208 /*0xD0*/, 238);
        this.flowLayoutPanel9.TabIndex = 158;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(973, 686);
        this.Controls.Add(this.flowLayoutPanel9);
        this.Controls.Add(this.flpModifiers);
        this.Controls.Add(this.pbRace);
        this.Controls.Add(this.flowLayoutPanel3);
        this.Controls.Add(this.flowLayoutPanel6);
        this.Controls.Add(this.pbFlag);
        this.Controls.Add(this.flowLayoutPanel2);
        this.Controls.Add(this.lstTerrain);
        this.Controls.Add(this.flowLayoutPanel1);
        this.Controls.Add(this.flowLayoutPanel10);
        this.Controls.Add(this.flowLayoutPanel4);
        this.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.Name = nameof(frmNPRSetup);
        this.Text = "NPR Setup";
        this.Load += this.frmNPRSetup_Load;
        this.flowLayoutPanel10.ResumeLayout(false);
        this.panel6.ResumeLayout(false);
        this.panel6.PerformLayout();
        this.panel15.ResumeLayout(false);
        this.panel15.PerformLayout();
        this.panel16.ResumeLayout(false);
        this.panel16.PerformLayout();
        this.panel8.ResumeLayout(false);
        this.panel8.PerformLayout();
        this.flowLayoutPanel1.ResumeLayout(false);
        this.flowLayoutPanel4.ResumeLayout(false);
        this.flowLayoutPanel7.ResumeLayout(false);
        this.panel5.ResumeLayout(false);
        this.panel5.PerformLayout();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.panel3.ResumeLayout(false);
        this.panel3.PerformLayout();
        this.flowLayoutPanel8.ResumeLayout(false);
        this.panel4.ResumeLayout(false);
        this.panel4.PerformLayout();
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        this.panel7.ResumeLayout(false);
        this.panel7.PerformLayout();
        this.flowLayoutPanel2.ResumeLayout(false);
        this.panel9.ResumeLayout(false);
        this.panel9.PerformLayout();
        this.panel10.ResumeLayout(false);
        this.panel10.PerformLayout();
        this.panel12.ResumeLayout(false);
        this.panel12.PerformLayout();
        this.panel11.ResumeLayout(false);
        this.panel11.PerformLayout();
        this.panel21.ResumeLayout(false);
        this.panel21.PerformLayout();
        this.panel22.ResumeLayout(false);
        this.panel22.PerformLayout();
        this.panel23.ResumeLayout(false);
        this.panel23.PerformLayout();
        this.panel36.ResumeLayout(false);
        this.panel36.PerformLayout();
        this.panel37.ResumeLayout(false);
        this.panel37.PerformLayout();
        this.panel38.ResumeLayout(false);
        this.panel38.PerformLayout();
        this.panel39.ResumeLayout(false);
        this.panel39.PerformLayout();
        this.panel40.ResumeLayout(false);
        this.panel40.PerformLayout();
        this.panel41.ResumeLayout(false);
        this.panel41.PerformLayout();
        this.panel42.ResumeLayout(false);
        this.panel42.PerformLayout();
        this.panel26.ResumeLayout(false);
        this.panel26.PerformLayout();
        this.panel27.ResumeLayout(false);
        this.panel27.PerformLayout();
        this.panel28.ResumeLayout(false);
        this.panel28.PerformLayout();
        ((ISupportInitialize)this.pbRace).EndInit();
        this.flowLayoutPanel3.ResumeLayout(false);
        ((ISupportInitialize)this.pbShip).EndInit();
        this.flowLayoutPanel6.ResumeLayout(false);
        ((ISupportInitialize)this.pbStation).EndInit();
        ((ISupportInitialize)this.pbFlag).EndInit();
        this.flpModifiers.ResumeLayout(false);
        this.panel14.ResumeLayout(false);
        this.panel14.PerformLayout();
        this.panel47.ResumeLayout(false);
        this.panel47.PerformLayout();
        this.panel19.ResumeLayout(false);
        this.panel19.PerformLayout();
        this.panel13.ResumeLayout(false);
        this.panel13.PerformLayout();
        this.panel17.ResumeLayout(false);
        this.panel17.PerformLayout();
        this.panel18.ResumeLayout(false);
        this.panel18.PerformLayout();
        this.panel20.ResumeLayout(false);
        this.panel20.PerformLayout();
        this.flowLayoutPanel9.ResumeLayout(false);
        this.ResumeLayout(false);
    }
}