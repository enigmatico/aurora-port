// Decompiled with JetBrains decompiler
// Type: TurretDesign
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class TurretDesign : Form
{
    private GClass0 gclass0_0;
    private GameRace gclass21_0;
    private ShipComponent gclass230_0;
    private int int_0 = 1;
    private bool bool_0 = true;
    private ComboBox cboRaces;
    private FlowLayoutPanel flowLayoutPanel4;
    private FlowLayoutPanel flowLayoutPanel3;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private Label label10;
    private Label label11;
    private Label label12;
    private FlowLayoutPanel flowLayoutPanel1;
    private TextBox txtTrackingSpeed;
    private TextBox txtArmourStrength;
    private TextBox txtWeaponSize;
    private ComboBox cboBeamType;
    private TextBox txtTech;
    private TextBox txtFireControl;
    private FlowLayoutPanel flowLayoutPanel5;
    private RadioButton rboSingle;
    private RadioButton rdoTwin;
    private RadioButton rdoTriple;
    private RadioButton rdoQuad;
    private TextBox txtWeaponCost;
    private TextBox txtTotalWeaponSize;
    private TextBox txtTotalWeaponCost;
    private TextBox txtRotationGear;
    private TextBox txtGearSize;
    private TextBox txtTurretName;
    private TextBox txtCompanyName;
    private Button cmdInstant;
    private Button cmdCreate;
    private Button cmdCompanyName;
    private Label label1;
    private Label label2;
    private TextBox txtArmourCost;
    private TextBox txtArmourSize;
    private FlowLayoutPanel flowLayoutPanel2;
    private FlowLayoutPanel flowLayoutPanel6;
    private FlowLayoutPanel flowLayoutPanel7;
    private TextBox txtTurretSummary;
    private CheckBox chkShowObsoleteClasses;
    private Button cmdPrototype;
    private FlowLayoutPanel flowLayoutPanel8;

    public TurretDesign(GClass0 gclass0_1)
    {
        this.InitializeComponent();
        this.gclass0_0 = gclass0_1;
    }

    private void TurretDesign_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            this.gclass0_0.bool_9 = true;
            this.bool_0 = true;
            if (!this.gclass0_0.bool_8)
                this.cmdInstant.Visible = false;
            else
                this.cmdInstant.Visible = true;
            this.gclass0_0.method_577(this.cboRaces);
            this.gclass21_0 = (GameRace)this.cboRaces.SelectedValue;
            if (this.gclass21_0 == null)
            {
                this.gclass0_0.bool_9 = false;
            }
            else
            {
                this.gclass21_0.method_216(this.cboBeamType);
                this.gclass0_0.bool_9 = false;
                this.gclass21_0.method_215(this.txtTech, this.txtFireControl);
                this.gclass230_0 = (ShipComponent)this.cboBeamType.SelectedValue;
                if (this.gclass230_0 == null)
                    return;
                if (this.gclass230_0.genum86_0 != GEnum86.const_0)
                    this.cmdCreate.Visible = false;
                else
                    this.cmdCreate.Visible = true;
                this.gclass0_0.gclass164_0 = null;
                this.method_1();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3166);
        }
    }

    public void method_0(GameRace gclass21_1)
    {
        try
        {
            this.bool_0 = true;
            this.cboRaces.SelectedItem = gclass21_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3167);
        }
    }

    private void cboRaces_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.gclass21_0 = (GameRace)this.cboRaces.SelectedValue;
            if (this.gclass21_0 == null)
                return;
            this.gclass21_0.method_216(this.cboBeamType);
            this.gclass21_0.method_215(this.txtTech, this.txtFireControl);
            this.method_1();
            if (!this.bool_0)
                this.gclass0_0.method_511(this.gclass21_0, this);
            this.bool_0 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3168);
        }
    }

    private void cboBeamType_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.gclass230_0 = (ShipComponent)this.cboBeamType.SelectedValue;
            if (this.gclass230_0 == null)
                return;
            if (this.gclass230_0.genum86_0 != GEnum86.const_0)
                this.cmdCreate.Visible = false;
            else
                this.cmdCreate.Visible = true;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3169);
        }
    }

    private void cmdCompanyName_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            this.txtCompanyName.Text =
                this.gclass0_0.method_479(this.gclass21_0, this.gclass0_0.ResearchCategoryDictionary[ResearchCategoryType.Missiles].CompanyNameType);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3170);
        }
    }

    private void method_1()
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass230_0 == null)
            {
                this.txtTurretName.Text = "";
                this.txtTurretSummary.Text = "No Beam Selected";
            }
            else
            {
                int int_137 = (int)AuroraUtils.ParseDoubleOrDefault(this.txtTrackingSpeed.Text, 0.0);
                int int_138 = (int)AuroraUtils.ParseDoubleOrDefault(this.txtArmourStrength.Text, 0.0);
                TechSystem gclass164_1 =
                    this.gclass21_0.method_388(this.gclass0_0.TechTypeDataDictionary[TechType.TurretRotationGear]);
                this.gclass21_0.method_388(this.gclass0_0.TechTypeDataDictionary[TechType.FireControlSpeedRating]);
                this.gclass0_0.method_450(this.gclass21_0, gclass164_1, this.gclass230_0, this.int_0, int_137, int_138,
                    this.txtTurretSummary, this.txtTurretName, this.txtWeaponSize, this.txtWeaponCost,
                    this.txtTotalWeaponSize, this.txtTotalWeaponCost, this.txtRotationGear, this.txtGearSize,
                    this.txtArmourCost, this.txtArmourSize, false);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3171);
        }
    }

    private void rboSingle_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.int_0 = 1;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3172);
        }
    }

    private void rdoTwin_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.int_0 = 2;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3173);
        }
    }

    private void rdoTriple_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.int_0 = 3;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3174);
        }
    }

    private void rdoQuad_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.int_0 = 4;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3175);
        }
    }

    private void txtArmourStrength_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null || this.txtArmourStrength.Text == "")
                return;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3176);
        }
    }

    private void txtTrackingSpeed_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null || this.txtTrackingSpeed.Text == "")
                return;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3177);
        }
    }

    private void cmdCreate_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass0_0.gclass164_0.Name = !(this.txtCompanyName.Text == "")
                ? string.Format("{0} {1}", this.txtCompanyName.Text, this.txtTurretName.Text)
                : this.txtTurretName.Text;
            if (this.gclass230_0.genum86_0 != GEnum86.const_0)
            {
                int num1 = (int)MessageBox.Show(
                    "You cannot create a research project for a turret that includes a prototype weapon");
            }
            else
            {
                this.gclass0_0.TechSystems.Add(this.gclass0_0.gclass164_0.TechSystemID, this.gclass0_0.gclass164_0);
                this.gclass0_0.gclass230_1.Name = this.gclass0_0.gclass164_0.Name;
                this.gclass0_0.ComponentDataDictionary.Add(this.gclass0_0.gclass230_1.int_0, this.gclass0_0.gclass230_1);
                int num2 = (int)MessageBox.Show(
                    "Turret Design Created. Research the new turret on the Research tab of the economics window");
                this.method_1();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3178);
        }
    }

    private void cmdInstant_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                this.gclass0_0.gclass164_0.Name = !(this.txtCompanyName.Text == "")
                    ? string.Format("{0} {1}", this.txtCompanyName.Text, this.txtTurretName.Text)
                    : this.txtTurretName.Text;
                if (this.gclass230_0.genum86_0 != GEnum86.const_0)
                {
                    int num2 = (int)MessageBox.Show(
                        "You cannot create a research project for a turret that includes a prototype weapon");
                }
                else
                {
                    this.gclass0_0.TechSystems.Add(this.gclass0_0.gclass164_0.TechSystemID, this.gclass0_0.gclass164_0);
                    this.gclass0_0.gclass230_1.Name = this.gclass0_0.gclass164_0.Name;
                    this.gclass0_0.ComponentDataDictionary.Add(this.gclass0_0.gclass230_1.int_0,
                        this.gclass0_0.gclass230_1);
                    this.gclass21_0.method_282(this.gclass0_0.gclass164_0, null, null, null, false, false);
                    int num3 = (int)MessageBox.Show("Turret has been created and automatically researched");
                    this.method_1();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3179);
        }
    }

    private void txtTurretName_TextChanged(object sender, EventArgs e)
    {
    }

    private void cmdPrototype_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                this.gclass0_0.gclass164_0.Name = !(this.txtCompanyName.Text == "")
                    ? string.Format("{0} {1}", this.txtCompanyName.Text, this.txtTurretName.Text)
                    : this.txtTurretName.Text;
                this.gclass0_0.TechSystems.Add(this.gclass0_0.gclass164_0.TechSystemID, this.gclass0_0.gclass164_0);
                this.gclass0_0.gclass230_1.Name = this.gclass0_0.gclass164_0.Name;
                this.gclass0_0.gclass230_1.genum86_0 = GEnum86.const_1;
                this.gclass0_0.ComponentDataDictionary.Add(this.gclass0_0.gclass230_1.int_0, this.gclass0_0.gclass230_1);
                this.gclass21_0.method_282(this.gclass0_0.gclass164_0, null, null, null, false, false);
                int num2 = (int)MessageBox.Show(
                    "The prototype turret has been created and is available for class design. A shipyard cannot be retooled for a class design that contains a prototype component");
                this.method_1();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3180);
        }
    }

    private void TurretDesign_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3181);
        }
    }

    private void TurretDesign_KeyDown(object sender, KeyEventArgs e)
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
            AuroraUtils.ShowExceptionPopup(ex, 3287);
        }
    }

    private void InitializeComponent()
    {
        this.cboRaces = new ComboBox();
        this.flowLayoutPanel4 = new FlowLayoutPanel();
        this.flowLayoutPanel3 = new FlowLayoutPanel();
        this.label7 = new Label();
        this.label8 = new Label();
        this.label9 = new Label();
        this.label10 = new Label();
        this.label11 = new Label();
        this.label12 = new Label();
        this.label1 = new Label();
        this.label2 = new Label();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.txtWeaponSize = new TextBox();
        this.txtWeaponCost = new TextBox();
        this.txtTotalWeaponSize = new TextBox();
        this.txtTotalWeaponCost = new TextBox();
        this.txtRotationGear = new TextBox();
        this.txtGearSize = new TextBox();
        this.txtArmourCost = new TextBox();
        this.txtArmourSize = new TextBox();
        this.label5 = new Label();
        this.label6 = new Label();
        this.txtTrackingSpeed = new TextBox();
        this.txtArmourStrength = new TextBox();
        this.cboBeamType = new ComboBox();
        this.txtTech = new TextBox();
        this.txtFireControl = new TextBox();
        this.flowLayoutPanel5 = new FlowLayoutPanel();
        this.rboSingle = new RadioButton();
        this.rdoTwin = new RadioButton();
        this.rdoTriple = new RadioButton();
        this.rdoQuad = new RadioButton();
        this.txtTurretName = new TextBox();
        this.txtCompanyName = new TextBox();
        this.cmdInstant = new Button();
        this.cmdCreate = new Button();
        this.cmdCompanyName = new Button();
        this.flowLayoutPanel2 = new FlowLayoutPanel();
        this.flowLayoutPanel6 = new FlowLayoutPanel();
        this.flowLayoutPanel7 = new FlowLayoutPanel();
        this.txtTurretSummary = new TextBox();
        this.chkShowObsoleteClasses = new CheckBox();
        this.cmdPrototype = new Button();
        this.flowLayoutPanel8 = new FlowLayoutPanel();
        this.flowLayoutPanel4.SuspendLayout();
        this.flowLayoutPanel3.SuspendLayout();
        this.flowLayoutPanel1.SuspendLayout();
        this.flowLayoutPanel5.SuspendLayout();
        this.flowLayoutPanel2.SuspendLayout();
        this.flowLayoutPanel6.SuspendLayout();
        this.flowLayoutPanel7.SuspendLayout();
        this.flowLayoutPanel8.SuspendLayout();
        this.SuspendLayout();
        this.cboRaces.AccessibleName = "Race Dropdown";
        this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRaces.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboRaces.FormattingEnabled = true;
        this.cboRaces.Location = new Point(3, 3);
        this.cboRaces.Margin = new Padding(3, 3, 3, 0);
        this.cboRaces.Name = "cboRaces";
        this.cboRaces.Size = new Size(244, 21);
        this.cboRaces.TabIndex = 1;
        this.cboRaces.SelectedIndexChanged += this.cboRaces_SelectedIndexChanged;
        this.flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel3);
        this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel1);
        this.flowLayoutPanel4.Location = new Point(3, 151);
        this.flowLayoutPanel4.Name = "flowLayoutPanel4";
        this.flowLayoutPanel4.Size = new Size(244, 211);
        this.flowLayoutPanel4.TabIndex = 121;
        this.flowLayoutPanel3.Controls.Add(this.label7);
        this.flowLayoutPanel3.Controls.Add(this.label8);
        this.flowLayoutPanel3.Controls.Add(this.label9);
        this.flowLayoutPanel3.Controls.Add(this.label10);
        this.flowLayoutPanel3.Controls.Add(this.label11);
        this.flowLayoutPanel3.Controls.Add(this.label12);
        this.flowLayoutPanel3.Controls.Add(this.label1);
        this.flowLayoutPanel3.Controls.Add(this.label2);
        this.flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel3.Location = new Point(3, 3);
        this.flowLayoutPanel3.Name = "flowLayoutPanel3";
        this.flowLayoutPanel3.Size = new Size(154, 203);
        this.flowLayoutPanel3.TabIndex = 119;
        this.label7.AutoSize = true;
        this.label7.Location = new Point(3, 6);
        this.label7.Margin = new Padding(3, 6, 3, 0);
        this.label7.Name = "label7";
        this.label7.Padding = new Padding(0, 5, 5, 0);
        this.label7.Size = new Size(124, 18);
        this.label7.TabIndex = 11;
        this.label7.Text = "Individual Weapon Size";
        this.label7.TextAlign = ContentAlignment.MiddleLeft;
        this.label8.AutoSize = true;
        this.label8.Location = new Point(3, 30);
        this.label8.Margin = new Padding(3, 6, 3, 0);
        this.label8.Name = "label8";
        this.label8.Padding = new Padding(0, 5, 5, 0);
        this.label8.Size = new Size(125, 18);
        this.label8.TabIndex = 13;
        this.label8.Text = "Individual Weapon Cost";
        this.label8.TextAlign = ContentAlignment.MiddleLeft;
        this.label9.AutoSize = true;
        this.label9.Location = new Point(3, 54);
        this.label9.Margin = new Padding(3, 6, 3, 0);
        this.label9.Name = "label9";
        this.label9.Padding = new Padding(0, 5, 5, 0);
        this.label9.Size = new Size(103, 18);
        this.label9.TabIndex = 15;
        this.label9.Text = "Total Weapon Size";
        this.label9.TextAlign = ContentAlignment.MiddleLeft;
        this.label10.AutoSize = true;
        this.label10.Location = new Point(3, 78);
        this.label10.Margin = new Padding(3, 6, 3, 0);
        this.label10.Name = "label10";
        this.label10.Padding = new Padding(0, 5, 5, 0);
        this.label10.Size = new Size(104, 18);
        this.label10.TabIndex = 17;
        this.label10.Text = "Total Weapon Cost";
        this.label10.TextAlign = ContentAlignment.MiddleLeft;
        this.label11.AutoSize = true;
        this.label11.Location = new Point(3, 102);
        this.label11.Margin = new Padding(3, 6, 3, 0);
        this.label11.Name = "label11";
        this.label11.Padding = new Padding(0, 5, 5, 0);
        this.label11.Size = new Size(89, 18);
        this.label11.TabIndex = 19;
        this.label11.Text = "Rotation Gear %";
        this.label11.TextAlign = ContentAlignment.MiddleLeft;
        this.label12.AutoSize = true;
        this.label12.Location = new Point(3, 126);
        this.label12.Margin = new Padding(3, 6, 3, 0);
        this.label12.Name = "label12";
        this.label12.Padding = new Padding(0, 5, 5, 0);
        this.label12.Size = new Size(58, 18);
        this.label12.TabIndex = 21;
        this.label12.Text = "Gear Size";
        this.label12.TextAlign = ContentAlignment.MiddleLeft;
        this.label1.AutoSize = true;
        this.label1.Location = new Point(3, 150);
        this.label1.Margin = new Padding(3, 6, 3, 0);
        this.label1.Name = "label1";
        this.label1.Padding = new Padding(0, 5, 5, 0);
        this.label1.Size = new Size(69, 18);
        this.label1.TabIndex = 23;
        this.label1.Text = "Armour Cost";
        this.label1.TextAlign = ContentAlignment.MiddleLeft;
        this.label2.AutoSize = true;
        this.label2.Location = new Point(3, 174);
        this.label2.Margin = new Padding(3, 6, 3, 0);
        this.label2.Name = "label2";
        this.label2.Padding = new Padding(0, 5, 5, 0);
        this.label2.Size = new Size(68, 18);
        this.label2.TabIndex = 25;
        this.label2.Text = "Armour Size";
        this.label2.TextAlign = ContentAlignment.MiddleLeft;
        this.flowLayoutPanel1.Controls.Add(this.txtWeaponSize);
        this.flowLayoutPanel1.Controls.Add(this.txtWeaponCost);
        this.flowLayoutPanel1.Controls.Add(this.txtTotalWeaponSize);
        this.flowLayoutPanel1.Controls.Add(this.txtTotalWeaponCost);
        this.flowLayoutPanel1.Controls.Add(this.txtRotationGear);
        this.flowLayoutPanel1.Controls.Add(this.txtGearSize);
        this.flowLayoutPanel1.Controls.Add(this.txtArmourCost);
        this.flowLayoutPanel1.Controls.Add(this.txtArmourSize);
        this.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel1.Location = new Point(163, 3);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(73, 203);
        this.flowLayoutPanel1.TabIndex = 117;
        this.txtWeaponSize.AccessibleName = "Individual Weapon Size";
        this.txtWeaponSize.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtWeaponSize.BorderStyle = BorderStyle.None;
        this.txtWeaponSize.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtWeaponSize.Location = new Point(3, 11);
        this.txtWeaponSize.Margin = new Padding(3, 11, 3, 0);
        this.txtWeaponSize.Name = "txtWeaponSize";
        this.txtWeaponSize.ReadOnly = true;
        this.txtWeaponSize.Size = new Size(65, 13);
        this.txtWeaponSize.TabIndex = 12;
        this.txtWeaponSize.Text = "0";
        this.txtWeaponSize.TextAlign = HorizontalAlignment.Center;
        this.txtWeaponCost.AccessibleName = "Individual Weapon Cost";
        this.txtWeaponCost.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtWeaponCost.BorderStyle = BorderStyle.None;
        this.txtWeaponCost.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtWeaponCost.Location = new Point(3, 35);
        this.txtWeaponCost.Margin = new Padding(3, 11, 3, 0);
        this.txtWeaponCost.Name = "txtWeaponCost";
        this.txtWeaponCost.ReadOnly = true;
        this.txtWeaponCost.Size = new Size(65, 13);
        this.txtWeaponCost.TabIndex = 14;
        this.txtWeaponCost.Text = "0";
        this.txtWeaponCost.TextAlign = HorizontalAlignment.Center;
        this.txtTotalWeaponSize.AccessibleName = "Total Weapon Size";
        this.txtTotalWeaponSize.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTotalWeaponSize.BorderStyle = BorderStyle.None;
        this.txtTotalWeaponSize.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtTotalWeaponSize.Location = new Point(3, 59);
        this.txtTotalWeaponSize.Margin = new Padding(3, 11, 3, 0);
        this.txtTotalWeaponSize.Name = "txtTotalWeaponSize";
        this.txtTotalWeaponSize.ReadOnly = true;
        this.txtTotalWeaponSize.Size = new Size(65, 13);
        this.txtTotalWeaponSize.TabIndex = 16 /*0x10*/;
        this.txtTotalWeaponSize.Text = "0";
        this.txtTotalWeaponSize.TextAlign = HorizontalAlignment.Center;
        this.txtTotalWeaponCost.AccessibleName = "Total Weapon Cost";
        this.txtTotalWeaponCost.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTotalWeaponCost.BorderStyle = BorderStyle.None;
        this.txtTotalWeaponCost.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtTotalWeaponCost.Location = new Point(3, 83);
        this.txtTotalWeaponCost.Margin = new Padding(3, 11, 3, 0);
        this.txtTotalWeaponCost.Name = "txtTotalWeaponCost";
        this.txtTotalWeaponCost.ReadOnly = true;
        this.txtTotalWeaponCost.Size = new Size(65, 13);
        this.txtTotalWeaponCost.TabIndex = 18;
        this.txtTotalWeaponCost.Text = "0";
        this.txtTotalWeaponCost.TextAlign = HorizontalAlignment.Center;
        this.txtRotationGear.AccessibleName = "Rotation Gear Percentage";
        this.txtRotationGear.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtRotationGear.BorderStyle = BorderStyle.None;
        this.txtRotationGear.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtRotationGear.Location = new Point(3, 107);
        this.txtRotationGear.Margin = new Padding(3, 11, 3, 0);
        this.txtRotationGear.Name = "txtRotationGear";
        this.txtRotationGear.ReadOnly = true;
        this.txtRotationGear.Size = new Size(65, 13);
        this.txtRotationGear.TabIndex = 20;
        this.txtRotationGear.Text = "0";
        this.txtRotationGear.TextAlign = HorizontalAlignment.Center;
        this.txtGearSize.AccessibleName = "Gear Size";
        this.txtGearSize.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtGearSize.BorderStyle = BorderStyle.None;
        this.txtGearSize.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtGearSize.Location = new Point(3, 131);
        this.txtGearSize.Margin = new Padding(3, 11, 3, 0);
        this.txtGearSize.Name = "txtGearSize";
        this.txtGearSize.ReadOnly = true;
        this.txtGearSize.Size = new Size(65, 13);
        this.txtGearSize.TabIndex = 22;
        this.txtGearSize.Text = "0";
        this.txtGearSize.TextAlign = HorizontalAlignment.Center;
        this.txtArmourCost.AccessibleName = "Armour Cost";
        this.txtArmourCost.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtArmourCost.BorderStyle = BorderStyle.None;
        this.txtArmourCost.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtArmourCost.Location = new Point(3, 155);
        this.txtArmourCost.Margin = new Padding(3, 11, 3, 0);
        this.txtArmourCost.Name = "txtArmourCost";
        this.txtArmourCost.ReadOnly = true;
        this.txtArmourCost.Size = new Size(65, 13);
        this.txtArmourCost.TabIndex = 24;
        this.txtArmourCost.Text = "0";
        this.txtArmourCost.TextAlign = HorizontalAlignment.Center;
        this.txtArmourSize.AccessibleName = "Armur SIze";
        this.txtArmourSize.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtArmourSize.BorderStyle = BorderStyle.None;
        this.txtArmourSize.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtArmourSize.Location = new Point(3, 179);
        this.txtArmourSize.Margin = new Padding(3, 11, 3, 0);
        this.txtArmourSize.Name = "txtArmourSize";
        this.txtArmourSize.ReadOnly = true;
        this.txtArmourSize.Size = new Size(65, 13);
        this.txtArmourSize.TabIndex = 26;
        this.txtArmourSize.Text = "0";
        this.txtArmourSize.TextAlign = HorizontalAlignment.Center;
        this.label5.AutoSize = true;
        this.label5.Location = new Point(3, 3);
        this.label5.Margin = new Padding(3, 3, 3, 0);
        this.label5.Name = "label5";
        this.label5.Padding = new Padding(0, 5, 5, 0);
        this.label5.Size = new Size(sbyte.MaxValue, 18);
        this.label5.TabIndex = 7;
        this.label5.Text = "Desired Tracking Speed";
        this.label5.TextAlign = ContentAlignment.MiddleLeft;
        this.label6.AutoSize = true;
        this.label6.Location = new Point(3, 27);
        this.label6.Margin = new Padding(3, 6, 3, 0);
        this.label6.Name = "label6";
        this.label6.Padding = new Padding(0, 5, 5, 0);
        this.label6.Size = new Size(119, 18);
        this.label6.TabIndex = 9;
        this.label6.Text = "Turret Armour Strength";
        this.label6.TextAlign = ContentAlignment.MiddleLeft;
        this.txtTrackingSpeed.AccessibleName = "Desired Tracking Speed";
        this.txtTrackingSpeed.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTrackingSpeed.BorderStyle = BorderStyle.None;
        this.txtTrackingSpeed.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtTrackingSpeed.Location = new Point(3, 8);
        this.txtTrackingSpeed.Margin = new Padding(3, 8, 3, 0);
        this.txtTrackingSpeed.Name = "txtTrackingSpeed";
        this.txtTrackingSpeed.Size = new Size(65, 13);
        this.txtTrackingSpeed.TabIndex = 8;
        this.txtTrackingSpeed.Text = "10000";
        this.txtTrackingSpeed.TextAlign = HorizontalAlignment.Center;
        this.txtTrackingSpeed.TextChanged += this.txtTrackingSpeed_TextChanged;
        this.txtArmourStrength.AccessibleName = "Turret Armour Strength";
        this.txtArmourStrength.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtArmourStrength.BorderStyle = BorderStyle.None;
        this.txtArmourStrength.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtArmourStrength.Location = new Point(3, 32 /*0x20*/);
        this.txtArmourStrength.Margin = new Padding(3, 11, 3, 0);
        this.txtArmourStrength.Name = "txtArmourStrength";
        this.txtArmourStrength.Size = new Size(65, 13);
        this.txtArmourStrength.TabIndex = 10;
        this.txtArmourStrength.Text = "0";
        this.txtArmourStrength.TextAlign = HorizontalAlignment.Center;
        this.txtArmourStrength.TextChanged += this.txtArmourStrength_TextChanged;
        this.cboBeamType.AccessibleName = "Weapon Selection Dropdown";
        this.cboBeamType.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboBeamType.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboBeamType.FormattingEnabled = true;
        this.cboBeamType.Location = new Point(3, 27);
        this.cboBeamType.Margin = new Padding(3, 3, 3, 0);
        this.cboBeamType.Name = "cboBeamType";
        this.cboBeamType.Size = new Size(244, 21);
        this.cboBeamType.TabIndex = 2;
        this.cboBeamType.SelectedIndexChanged += this.cboBeamType_SelectedIndexChanged;
        this.txtTech.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTech.BorderStyle = BorderStyle.FixedSingle;
        this.txtTech.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtTech.Location = new Point(253, 4);
        this.txtTech.Name = "txtTech";
        this.txtTech.ReadOnly = true;
        this.txtTech.Size = new Size(429, 20);
        this.txtTech.TabIndex = 27;
        this.txtTech.TextAlign = HorizontalAlignment.Center;
        this.txtFireControl.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtFireControl.BorderStyle = BorderStyle.FixedSingle;
        this.txtFireControl.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtFireControl.Location = new Point(253, 27);
        this.txtFireControl.Name = "txtFireControl";
        this.txtFireControl.ReadOnly = true;
        this.txtFireControl.Size = new Size(429, 20);
        this.txtFireControl.TabIndex = 28;
        this.txtFireControl.TextAlign = HorizontalAlignment.Center;
        this.flowLayoutPanel5.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel5.Controls.Add(this.rboSingle);
        this.flowLayoutPanel5.Controls.Add(this.rdoTwin);
        this.flowLayoutPanel5.Controls.Add(this.rdoTriple);
        this.flowLayoutPanel5.Controls.Add(this.rdoQuad);
        this.flowLayoutPanel5.Location = new Point(3, 51);
        this.flowLayoutPanel5.Name = "flowLayoutPanel5";
        this.flowLayoutPanel5.Size = new Size(244, 27);
        this.flowLayoutPanel5.TabIndex = 125;
        this.rboSingle.AccessibleName = "Single Turret";
        this.rboSingle.AutoSize = true;
        this.rboSingle.Checked = true;
        this.rboSingle.Location = new Point(6, 3);
        this.rboSingle.Margin = new Padding(6, 3, 3, 3);
        this.rboSingle.Name = "rboSingle";
        this.rboSingle.Size = new Size(54, 17);
        this.rboSingle.TabIndex = 3;
        this.rboSingle.TabStop = true;
        this.rboSingle.Text = "Single";
        this.rboSingle.UseVisualStyleBackColor = true;
        this.rboSingle.CheckedChanged += this.rboSingle_CheckedChanged;
        this.rdoTwin.AutoSize = true;
        this.rdoTwin.Location = new Point(69, 3);
        this.rdoTwin.Margin = new Padding(6, 3, 3, 3);
        this.rdoTwin.Name = "rdoTwin";
        this.rdoTwin.Size = new Size(48 /*0x30*/, 17);
        this.rdoTwin.TabIndex = 4;
        this.rdoTwin.Text = "Twin";
        this.rdoTwin.UseVisualStyleBackColor = true;
        this.rdoTwin.CheckedChanged += this.rdoTwin_CheckedChanged;
        this.rdoTriple.AutoSize = true;
        this.rdoTriple.Location = new Point(126, 3);
        this.rdoTriple.Margin = new Padding(6, 3, 3, 3);
        this.rdoTriple.Name = "rdoTriple";
        this.rdoTriple.Size = new Size(51, 17);
        this.rdoTriple.TabIndex = 5;
        this.rdoTriple.Text = "Triple";
        this.rdoTriple.UseVisualStyleBackColor = true;
        this.rdoTriple.CheckedChanged += this.rdoTriple_CheckedChanged;
        this.rdoQuad.AutoSize = true;
        this.rdoQuad.Location = new Point(186, 3);
        this.rdoQuad.Margin = new Padding(6, 3, 3, 3);
        this.rdoQuad.Name = "rdoQuad";
        this.rdoQuad.Size = new Size(51, 17);
        this.rdoQuad.TabIndex = 6;
        this.rdoQuad.Text = "Quad";
        this.rdoQuad.UseVisualStyleBackColor = true;
        this.rdoQuad.CheckedChanged += this.rdoQuad_CheckedChanged;
        this.txtTurretName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTurretName.BorderStyle = BorderStyle.FixedSingle;
        this.txtTurretName.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtTurretName.Location = new Point(253, 120);
        this.txtTurretName.Name = "txtTurretName";
        this.txtTurretName.Size = new Size(429, 20);
        this.txtTurretName.TabIndex = 30;
        this.txtTurretName.TextChanged += this.txtTurretName_TextChanged;
        this.txtCompanyName.AccessibleName = "Company Name";
        this.txtCompanyName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtCompanyName.BorderStyle = BorderStyle.FixedSingle;
        this.txtCompanyName.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtCompanyName.Location = new Point(253, 88);
        this.txtCompanyName.Name = "txtCompanyName";
        this.txtCompanyName.Size = new Size(429, 20);
        this.txtCompanyName.TabIndex = 29;
        this.cmdInstant.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdInstant.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdInstant.Location = new Point(192 /*0xC0*/, 0);
        this.cmdInstant.Margin = new Padding(0);
        this.cmdInstant.Name = "cmdInstant";
        this.cmdInstant.Size = new Size(96 /*0x60*/, 30);
        this.cmdInstant.TabIndex = 33;
        this.cmdInstant.Tag = "1200";
        this.cmdInstant.Text = "Instant";
        this.cmdInstant.UseVisualStyleBackColor = false;
        this.cmdInstant.Click += this.cmdInstant_Click;
        this.cmdCreate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreate.Location = new Point(0, 0);
        this.cmdCreate.Margin = new Padding(0);
        this.cmdCreate.Name = "cmdCreate";
        this.cmdCreate.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreate.TabIndex = 31 /*0x1F*/;
        this.cmdCreate.Tag = "1200";
        this.cmdCreate.Text = "Create";
        this.cmdCreate.UseVisualStyleBackColor = false;
        this.cmdCreate.Click += this.cmdCreate_Click;
        this.cmdCompanyName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCompanyName.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCompanyName.Location = new Point(288, 0);
        this.cmdCompanyName.Margin = new Padding(0);
        this.cmdCompanyName.Name = "cmdCompanyName";
        this.cmdCompanyName.Size = new Size(96 /*0x60*/, 30);
        this.cmdCompanyName.TabIndex = 34;
        this.cmdCompanyName.Tag = "1200";
        this.cmdCompanyName.Text = "Company Name";
        this.cmdCompanyName.UseVisualStyleBackColor = false;
        this.cmdCompanyName.Click += this.cmdCompanyName_Click;
        this.flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel6);
        this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel7);
        this.flowLayoutPanel2.Location = new Point(3, 84);
        this.flowLayoutPanel2.Name = "flowLayoutPanel2";
        this.flowLayoutPanel2.Size = new Size(244, 61);
        this.flowLayoutPanel2.TabIndex = 137;
        this.flowLayoutPanel6.Controls.Add(this.label5);
        this.flowLayoutPanel6.Controls.Add(this.label6);
        this.flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel6.Location = new Point(3, 3);
        this.flowLayoutPanel6.Name = "flowLayoutPanel6";
        this.flowLayoutPanel6.Size = new Size(154, 57);
        this.flowLayoutPanel6.TabIndex = 119;
        this.flowLayoutPanel7.Controls.Add(this.txtTrackingSpeed);
        this.flowLayoutPanel7.Controls.Add(this.txtArmourStrength);
        this.flowLayoutPanel7.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel7.Location = new Point(163, 3);
        this.flowLayoutPanel7.Name = "flowLayoutPanel7";
        this.flowLayoutPanel7.Size = new Size(73, 57);
        this.flowLayoutPanel7.TabIndex = 117;
        this.txtTurretSummary.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTurretSummary.BorderStyle = BorderStyle.FixedSingle;
        this.txtTurretSummary.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtTurretSummary.Location = new Point(253, 151);
        this.txtTurretSummary.Multiline = true;
        this.txtTurretSummary.Name = "txtTurretSummary";
        this.txtTurretSummary.Size = new Size(429, 211);
        this.txtTurretSummary.TabIndex = 138;
        this.chkShowObsoleteClasses.AccessibleName = "Show Obsolete";
        this.chkShowObsoleteClasses.AutoSize = true;
        this.chkShowObsoleteClasses.Location = new Point(579, 372);
        this.chkShowObsoleteClasses.Name = "chkShowObsoleteClasses";
        this.chkShowObsoleteClasses.Padding = new Padding(5, 0, 0, 0);
        this.chkShowObsoleteClasses.Size = new Size(103, 17);
        this.chkShowObsoleteClasses.TabIndex = 35;
        this.chkShowObsoleteClasses.Text = "Show Obsolete";
        this.chkShowObsoleteClasses.TextAlign = ContentAlignment.MiddleRight;
        this.chkShowObsoleteClasses.UseVisualStyleBackColor = true;
        this.cmdPrototype.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdPrototype.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdPrototype.Location = new Point(96 /*0x60*/, 0);
        this.cmdPrototype.Margin = new Padding(0);
        this.cmdPrototype.Name = "cmdPrototype";
        this.cmdPrototype.Size = new Size(96 /*0x60*/, 30);
        this.cmdPrototype.TabIndex = 32 /*0x20*/;
        this.cmdPrototype.Tag = "1200";
        this.cmdPrototype.Text = "Prototype";
        this.cmdPrototype.UseVisualStyleBackColor = false;
        this.cmdPrototype.Click += this.cmdPrototype_Click;
        this.flowLayoutPanel8.Controls.Add(this.cmdCreate);
        this.flowLayoutPanel8.Controls.Add(this.cmdPrototype);
        this.flowLayoutPanel8.Controls.Add(this.cmdInstant);
        this.flowLayoutPanel8.Controls.Add(this.cmdCompanyName);
        this.flowLayoutPanel8.Location = new Point(3, 364);
        this.flowLayoutPanel8.Name = "flowLayoutPanel8";
        this.flowLayoutPanel8.Size = new Size(411, 31 /*0x1F*/);
        this.flowLayoutPanel8.TabIndex = 141;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(685, 396);
        this.Controls.Add(this.flowLayoutPanel8);
        this.Controls.Add(this.chkShowObsoleteClasses);
        this.Controls.Add(this.txtTurretSummary);
        this.Controls.Add(this.flowLayoutPanel2);
        this.Controls.Add(this.txtTurretName);
        this.Controls.Add(this.txtCompanyName);
        this.Controls.Add(this.flowLayoutPanel5);
        this.Controls.Add(this.txtFireControl);
        this.Controls.Add(this.txtTech);
        this.Controls.Add(this.cboBeamType);
        this.Controls.Add(this.flowLayoutPanel4);
        this.Controls.Add(this.cboRaces);
        this.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.KeyPreview = true;
        this.Name = "TurretDesign";
        this.Text = "Turret Design";
        this.FormClosing += this.TurretDesign_FormClosing;
        this.Load += this.TurretDesign_Load;
        this.KeyDown += this.TurretDesign_KeyDown;
        this.flowLayoutPanel4.ResumeLayout(false);
        this.flowLayoutPanel3.ResumeLayout(false);
        this.flowLayoutPanel3.PerformLayout();
        this.flowLayoutPanel1.ResumeLayout(false);
        this.flowLayoutPanel1.PerformLayout();
        this.flowLayoutPanel5.ResumeLayout(false);
        this.flowLayoutPanel5.PerformLayout();
        this.flowLayoutPanel2.ResumeLayout(false);
        this.flowLayoutPanel6.ResumeLayout(false);
        this.flowLayoutPanel6.PerformLayout();
        this.flowLayoutPanel7.ResumeLayout(false);
        this.flowLayoutPanel7.PerformLayout();
        this.flowLayoutPanel8.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}