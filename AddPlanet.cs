// Decompiled with JetBrains decompiler
// Type: AddPlanet
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
public class AddPlanet : Form
{
  private GClass0 gclass0_0;
  private GClass197 gclass197_0;
  private GClass1 gclass1_0;
  private AuroraSystemBodyType auroraSystemBodyType_0 = AuroraSystemBodyType.Terrestrial;
  private double double_0;
  private double double_1;
  private double double_2;
  private double double_3;
  private double double_4;
  private IContainer icontainer_0;
  private ComboBox cboPlanetType;
  private Label lblDistance;
  private TextBox txtDistance;
  private Button cmdCancel;
  private Button cmdOK;
  private ListView lstvZones;
  private ColumnHeader columnHeader_0;
  private ColumnHeader columnHeader_1;
  private CheckBox chkMoons;
  private CheckBox chkTrojans;
  private FlowLayoutPanel flowLayoutPanel1;
  private TextBox txtNumMoons;
  private TextBox txtNumTrojans;
  private Label label1;
  private Label label2;
  private FlowLayoutPanel flowLayoutPanel2;
  private FlowLayoutPanel flpMoons;
  private FlowLayoutPanel flpTrojans;
  private FlowLayoutPanel flpComet;
  private Label label3;
  private TextBox txtCometStartDistance;
  private FlowLayoutPanel flpAsteroidA;
  private Label label4;
  private TextBox txtNumAsteroids;
  private FlowLayoutPanel flpAsteroidB;
  private Label label7;
  private TextBox txtBeltWidth;
  
  private sealed class Class333
  {
    public double double_0;
    public AddPlanet addPlanet_0;

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.gclass197_0 == this.addPlanet_0.gclass197_0 && gclass1_0.double_2 < this.double_0;
    }
  }

  private sealed class Class334
  {
    public string string_0;

    internal bool method_0(AuroraSystemBodyType auroraSystemBodyType_0)
    {
      return GClass226.smethod_82((Enum) auroraSystemBodyType_0) == this.string_0;
    }
  }

  public AddPlanet(GClass0 gclass0_1, GClass197 gclass197_1)
  {
    this.InitializeComponent();
    this.gclass0_0 = gclass0_1;
    this.gclass197_0 = gclass197_1;
  }

  private void AddPlanet_FormClosing(object sender, FormClosingEventArgs e)
  {
    try
    {
      this.gclass0_0.method_512(this.Name, this.Left, this.Top);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 187);
    }
  }

  private void AddPlanet_Load(object sender, EventArgs e)
  {
    try
    {
      GClass207 gclass207 = this.gclass0_0.method_513(this.Name);
      this.Left = gclass207.int_0;
      this.Top = gclass207.int_1;
      this.cboPlanetType.DataSource = (object) new List<string>()
      {
        GClass226.smethod_82((Enum) AuroraSystemBodyType.Terrestrial),
        GClass226.smethod_82((Enum) AuroraSystemBodyType.DwarfPlanet),
        GClass226.smethod_82((Enum) AuroraSystemBodyType.GasGiant),
        GClass226.smethod_82((Enum) AuroraSystemBodyType.Superjovian),
        GClass226.smethod_82((Enum) AuroraSystemBodyType.Asteroid),
        GClass226.smethod_82((Enum) AuroraSystemBodyType.Comet)
      };
      this.double_0 = 4.0 * Math.Pow(this.gclass197_0.double_4, 0.5);
      this.double_1 = 50.0 * Math.Pow(this.gclass197_0.double_4, 0.5);
      this.double_2 = 0.75 * Math.Pow(this.gclass197_0.double_4, 0.5);
      this.double_3 = Math.Pow(this.gclass197_0.double_4, 0.5);
      this.double_4 = 1.4 * Math.Pow(this.gclass197_0.double_4, 0.5);
      this.gclass0_0.method_601(this.lstvZones, "", "m km", (string) null);
      this.gclass0_0.method_597(this.lstvZones, "Life Zone Start", GClass226.smethod_44(this.double_2 * GClass226.double_14 / 1000000.0, 2));
      this.gclass0_0.method_597(this.lstvZones, "Life Zone End", GClass226.smethod_44(this.double_4 * GClass226.double_14 / 1000000.0, 2));
      this.gclass0_0.method_597(this.lstvZones, "Inner System End", GClass226.smethod_44(this.double_0 * GClass226.double_14 / 1000000.0, 2));
      this.gclass0_0.method_597(this.lstvZones, "Outer System End", GClass226.smethod_44(this.double_1 * GClass226.double_14 / 1000000.0, 2));
      this.gclass0_0.method_597(this.lstvZones, "Extreme", "Beyond Outer");
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 188);
    }
  }

  private void cmdOK_Click(object sender, EventArgs e)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      AddPlanet.Class333 class333 = new AddPlanet.Class333();
      // ISSUE: reference to a compiler-generated field
      class333.addPlanet_0 = this;
      if (this.auroraSystemBodyType_0 == AuroraSystemBodyType.None)
      {
        int num1 = (int) MessageBox.Show("Please select a planet type");
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        class333.double_0 = Convert.ToDouble(this.txtDistance.Text) * 1000000.0 / GClass226.double_14;
        // ISSUE: reference to a compiler-generated field
        if (class333.double_0 <= 0.0)
        {
          // ISSUE: reference to a compiler-generated field
          class333.double_0 = 100.0;
        }
        if (this.auroraSystemBodyType_0 == AuroraSystemBodyType.Comet)
        {
          double double_9 = Convert.ToDouble(this.txtCometStartDistance.Text) * 1000000.0 / GClass226.double_14;
          GClass197 gclass197_0 = this.gclass0_0.dictionary_10.Values.Where<GClass197>((Func<GClass197, bool>) (gclass197_1 => gclass197_1.gclass200_0 == this.gclass197_0.gclass200_0 && gclass197_1.int_3 == 1)).FirstOrDefault<GClass197>();
          if (gclass197_0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            this.gclass0_0.method_664(gclass197_0, 0, class333.double_0, double_9);
          }
        }
        else
        {
          double double_9 = 0.0;
          int int_137 = -1;
          int int_138 = 0;
          double double_14 = 0.0;
          if (this.chkTrojans.CheckState == CheckState.Checked)
          {
            int_137 = Convert.ToInt32(this.txtNumTrojans.Text);
            if (int_137 < 0)
              int_137 = 0;
          }
          if (this.auroraSystemBodyType_0 == AuroraSystemBodyType.Asteroid)
          {
            int_138 = Convert.ToInt32(this.txtNumAsteroids.Text);
            if (int_138 < 0)
              int_138 = 0;
            double_14 = Convert.ToDouble(this.txtBeltWidth.Text) * 500000.0 / GClass226.double_14;
          }
          // ISSUE: reference to a compiler-generated method
          GClass1 gclass1_2 = this.gclass0_0.dictionary_11.Values.Where<GClass1>(new Func<GClass1, bool>(class333.method_0)).OrderByDescending<GClass1, double>((Func<GClass1, double>) (gclass1_0 => gclass1_0.double_2)).FirstOrDefault<GClass1>();
          if (gclass1_2 != null)
            double_9 = gclass1_2.double_2;
          // ISSUE: reference to a compiler-generated field
          this.gclass1_0 = this.gclass0_0.method_656(this.auroraSystemBodyType_0, 1000, this.gclass197_0, class333.double_0, double_9, this.double_0, this.double_1, this.double_2, this.double_4, false, int_137, int_138, double_14);
          if (this.gclass1_0.genum12_0 == GEnum12.const_1)
            this.gclass1_0.method_40();
          if (this.chkMoons.CheckState == CheckState.Checked && !this.gclass1_0.bool_0)
          {
            int int_136 = Convert.ToInt32(this.txtNumMoons.Text);
            if (int_136 < 0)
              int_136 = 0;
            this.gclass0_0.method_655(this.gclass1_0, int_136, false);
          }
          if (this.auroraSystemBodyType_0 == AuroraSystemBodyType.Asteroid)
          {
            int num2 = 1;
            foreach (GClass1 gclass1_3 in this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_1 => gclass1_1.gclass200_0 == this.gclass197_0.gclass200_0 && gclass1_1.genum12_0 == GEnum12.const_3)).OrderBy<GClass1, int>((Func<GClass1, int>) (gclass1_0 => gclass1_0.gclass197_0.int_3)).ThenBy<GClass1, double>((Func<GClass1, double>) (gclass1_0 => gclass1_0.double_2)).ToList<GClass1>())
            {
              gclass1_3.string_0 = "Asteroid #" + num2.ToString();
              gclass1_3.int_4 = num2;
              ++num2;
            }
          }
        }
        this.gclass0_0.bool_21 = false;
        this.Close();
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 189);
    }
  }

  private void lstvZones_SelectedIndexChanged(object sender, EventArgs e)
  {
  }

  private void cboPlanetType_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.auroraSystemBodyType_0 = Enum.GetValues(typeof (AuroraSystemBodyType)).Cast<AuroraSystemBodyType>().FirstOrDefault<AuroraSystemBodyType>(new Func<AuroraSystemBodyType, bool>(new AddPlanet.Class334()
      {
        string_0 = (string) this.cboPlanetType.SelectedValue
      }.method_0));
      if (this.auroraSystemBodyType_0 != AuroraSystemBodyType.Superjovian && this.auroraSystemBodyType_0 != AuroraSystemBodyType.GasGiant)
        this.flpTrojans.Visible = false;
      else
        this.flpTrojans.Visible = true;
      if (this.auroraSystemBodyType_0 != AuroraSystemBodyType.Asteroid && this.auroraSystemBodyType_0 != AuroraSystemBodyType.Comet)
        this.flpMoons.Visible = true;
      else
        this.flpMoons.Visible = false;
      if (this.auroraSystemBodyType_0 == AuroraSystemBodyType.Comet)
        this.flpComet.Visible = true;
      else
        this.flpComet.Visible = false;
      if (this.auroraSystemBodyType_0 == AuroraSystemBodyType.Asteroid)
      {
        this.flpAsteroidA.Visible = true;
        this.flpAsteroidB.Visible = true;
      }
      else
      {
        this.flpAsteroidA.Visible = false;
        this.flpAsteroidB.Visible = false;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 191);
    }
  }

  private void cmdCancel_Click(object sender, EventArgs e)
  {
    try
    {
      this.Close();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 192 /*0xC0*/);
    }
  }

  private void method_0(object sender, FormClosingEventArgs e)
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
    this.cboPlanetType = new ComboBox();
    this.lblDistance = new Label();
    this.txtDistance = new TextBox();
    this.cmdCancel = new Button();
    this.cmdOK = new Button();
    this.lstvZones = new ListView();
    this.columnHeader_0 = new ColumnHeader();
    this.columnHeader_1 = new ColumnHeader();
    this.chkMoons = new CheckBox();
    this.chkTrojans = new CheckBox();
    this.flowLayoutPanel1 = new FlowLayoutPanel();
    this.flowLayoutPanel2 = new FlowLayoutPanel();
    this.flpMoons = new FlowLayoutPanel();
    this.label1 = new Label();
    this.txtNumMoons = new TextBox();
    this.flpTrojans = new FlowLayoutPanel();
    this.label2 = new Label();
    this.txtNumTrojans = new TextBox();
    this.flpComet = new FlowLayoutPanel();
    this.label3 = new Label();
    this.txtCometStartDistance = new TextBox();
    this.flpAsteroidA = new FlowLayoutPanel();
    this.label4 = new Label();
    this.txtNumAsteroids = new TextBox();
    this.flpAsteroidB = new FlowLayoutPanel();
    this.label7 = new Label();
    this.txtBeltWidth = new TextBox();
    this.flowLayoutPanel1.SuspendLayout();
    this.flowLayoutPanel2.SuspendLayout();
    this.flpMoons.SuspendLayout();
    this.flpTrojans.SuspendLayout();
    this.flpComet.SuspendLayout();
    this.flpAsteroidA.SuspendLayout();
    this.flpAsteroidB.SuspendLayout();
    this.SuspendLayout();
    this.cboPlanetType.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboPlanetType.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboPlanetType.FormattingEnabled = true;
    this.cboPlanetType.Location = new Point(3, 6);
    this.cboPlanetType.Margin = new Padding(3, 6, 3, 6);
    this.cboPlanetType.Name = "cboPlanetType";
    this.cboPlanetType.Size = new Size(312, 21);
    this.cboPlanetType.TabIndex = 1;
    this.cboPlanetType.SelectedIndexChanged += new EventHandler(this.cboPlanetType_SelectedIndexChanged);
    this.lblDistance.AutoSize = true;
    this.lblDistance.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lblDistance.Location = new Point(3, 2);
    this.lblDistance.Margin = new Padding(3, 2, 3, 2);
    this.lblDistance.Name = "lblDistance";
    this.lblDistance.Size = new Size(116, 13);
    this.lblDistance.TabIndex = 106;
    this.lblDistance.Text = "Orbital Distance (m km)";
    this.txtDistance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtDistance.BorderStyle = BorderStyle.None;
    this.txtDistance.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtDistance.Location = new Point(122, 3);
    this.txtDistance.Margin = new Padding(0, 3, 0, 2);
    this.txtDistance.Name = "txtDistance";
    this.txtDistance.Size = new Size(45, 13);
    this.txtDistance.TabIndex = 2;
    this.txtDistance.Text = "100";
    this.txtDistance.TextAlign = HorizontalAlignment.Center;
    this.cmdCancel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdCancel.DialogResult = DialogResult.Cancel;
    this.cmdCancel.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdCancel.Location = new Point(235, 231);
    this.cmdCancel.Margin = new Padding(0);
    this.cmdCancel.Name = "cmdCancel";
    this.cmdCancel.Size = new Size(96 /*0x60*/, 30);
    this.cmdCancel.TabIndex = 12;
    this.cmdCancel.Tag = (object) "1200";
    this.cmdCancel.Text = "Cancel";
    this.cmdCancel.UseVisualStyleBackColor = false;
    this.cmdCancel.Click += new EventHandler(this.cmdCancel_Click);
    this.cmdOK.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdOK.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdOK.Location = new Point(3, 231);
    this.cmdOK.Margin = new Padding(0);
    this.cmdOK.Name = "cmdOK";
    this.cmdOK.Size = new Size(96 /*0x60*/, 30);
    this.cmdOK.TabIndex = 11;
    this.cmdOK.Tag = (object) "1200";
    this.cmdOK.Text = "OK";
    this.cmdOK.UseVisualStyleBackColor = false;
    this.cmdOK.Click += new EventHandler(this.cmdOK_Click);
    this.lstvZones.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstvZones.BorderStyle = BorderStyle.FixedSingle;
    this.lstvZones.Columns.AddRange(new ColumnHeader[2]
    {
      this.columnHeader_0,
      this.columnHeader_1
    });
    this.lstvZones.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstvZones.FullRowSelect = true;
    this.lstvZones.HeaderStyle = ColumnHeaderStyle.None;
    this.lstvZones.HideSelection = false;
    this.lstvZones.Location = new Point(3, 3);
    this.lstvZones.Margin = new Padding(3, 0, 3, 0);
    this.lstvZones.Name = "lstvZones";
    this.lstvZones.Size = new Size(328, 109);
    this.lstvZones.TabIndex = 151;
    this.lstvZones.UseCompatibleStateImageBehavior = false;
    this.lstvZones.View = View.Details;
    this.lstvZones.SelectedIndexChanged += new EventHandler(this.lstvZones_SelectedIndexChanged);
    this.columnHeader_0.Width = 150;
    this.columnHeader_1.TextAlign = HorizontalAlignment.Center;
    this.columnHeader_1.Width = 170;
    this.chkMoons.AutoSize = true;
    this.chkMoons.Location = new Point(0, 4);
    this.chkMoons.Margin = new Padding(0, 4, 3, 3);
    this.chkMoons.Name = "chkMoons";
    this.chkMoons.Padding = new Padding(3, 1, 0, 0);
    this.chkMoons.Size = new Size(108, 18);
    this.chkMoons.TabIndex = 3;
    this.chkMoons.Text = "Generate Moons";
    this.chkMoons.UseVisualStyleBackColor = true;
    this.chkTrojans.AutoSize = true;
    this.chkTrojans.Location = new Point(0, 4);
    this.chkTrojans.Margin = new Padding(0, 4, 3, 3);
    this.chkTrojans.Name = "chkTrojans";
    this.chkTrojans.Padding = new Padding(3, 1, 0, 0);
    this.chkTrojans.Size = new Size(111, 18);
    this.chkTrojans.TabIndex = 5;
    this.chkTrojans.Text = "Generate Trojans";
    this.chkTrojans.UseVisualStyleBackColor = true;
    this.flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
    this.flowLayoutPanel1.Controls.Add((Control) this.cboPlanetType);
    this.flowLayoutPanel1.Controls.Add((Control) this.flowLayoutPanel2);
    this.flowLayoutPanel1.Controls.Add((Control) this.flpMoons);
    this.flowLayoutPanel1.Controls.Add((Control) this.flpTrojans);
    this.flowLayoutPanel1.Controls.Add((Control) this.flpComet);
    this.flowLayoutPanel1.Controls.Add((Control) this.flpAsteroidA);
    this.flowLayoutPanel1.Controls.Add((Control) this.flpAsteroidB);
    this.flowLayoutPanel1.Location = new Point(3, 115);
    this.flowLayoutPanel1.Name = "flowLayoutPanel1";
    this.flowLayoutPanel1.Size = new Size(328, 111);
    this.flowLayoutPanel1.TabIndex = 154;
    this.flowLayoutPanel2.Controls.Add((Control) this.lblDistance);
    this.flowLayoutPanel2.Controls.Add((Control) this.txtDistance);
    this.flowLayoutPanel2.Location = new Point(1, 34);
    this.flowLayoutPanel2.Margin = new Padding(1, 1, 3, 0);
    this.flowLayoutPanel2.Name = "flowLayoutPanel2";
    this.flowLayoutPanel2.Size = new Size(312, 21);
    this.flowLayoutPanel2.TabIndex = 155;
    this.flpMoons.Controls.Add((Control) this.chkMoons);
    this.flpMoons.Controls.Add((Control) this.label1);
    this.flpMoons.Controls.Add((Control) this.txtNumMoons);
    this.flpMoons.Location = new Point(3, 56);
    this.flpMoons.Margin = new Padding(3, 1, 0, 0);
    this.flpMoons.Name = "flpMoons";
    this.flpMoons.Size = new Size(316, 21);
    this.flpMoons.TabIndex = 156;
    this.label1.AutoSize = true;
    this.label1.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label1.Location = new Point(117, 6);
    this.label1.Margin = new Padding(6, 6, 3, 3);
    this.label1.Name = "label1";
    this.label1.Size = new Size(158, 13);
    this.label1.TabIndex = 157;
    this.label1.Text = "Number of Moons (0 = Random)";
    this.txtNumMoons.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtNumMoons.BorderStyle = BorderStyle.None;
    this.txtNumMoons.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtNumMoons.Location = new Point(281, 7);
    this.txtNumMoons.Margin = new Padding(3, 7, 0, 2);
    this.txtNumMoons.Name = "txtNumMoons";
    this.txtNumMoons.Size = new Size(35, 13);
    this.txtNumMoons.TabIndex = 4;
    this.txtNumMoons.Text = "0";
    this.txtNumMoons.TextAlign = HorizontalAlignment.Center;
    this.flpTrojans.Controls.Add((Control) this.chkTrojans);
    this.flpTrojans.Controls.Add((Control) this.label2);
    this.flpTrojans.Controls.Add((Control) this.txtNumTrojans);
    this.flpTrojans.Location = new Point(3, 82);
    this.flpTrojans.Margin = new Padding(3, 5, 3, 0);
    this.flpTrojans.Name = "flpTrojans";
    this.flpTrojans.Size = new Size(318, 21);
    this.flpTrojans.TabIndex = 157;
    this.label2.AutoSize = true;
    this.label2.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label2.Location = new Point(117, 6);
    this.label2.Margin = new Padding(3, 6, 3, 3);
    this.label2.Name = "label2";
    this.label2.Size = new Size(161, 13);
    this.label2.TabIndex = 158;
    this.label2.Text = "Number of Trojans (0 = Random)";
    this.txtNumTrojans.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtNumTrojans.BorderStyle = BorderStyle.None;
    this.txtNumTrojans.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtNumTrojans.Location = new Point(281, 6);
    this.txtNumTrojans.Margin = new Padding(0, 6, 0, 2);
    this.txtNumTrojans.Name = "txtNumTrojans";
    this.txtNumTrojans.Size = new Size(35, 13);
    this.txtNumTrojans.TabIndex = 6;
    this.txtNumTrojans.Text = "0";
    this.txtNumTrojans.TextAlign = HorizontalAlignment.Center;
    this.flpComet.Controls.Add((Control) this.label3);
    this.flpComet.Controls.Add((Control) this.txtCometStartDistance);
    this.flpComet.Location = new Point(1, 108);
    this.flpComet.Margin = new Padding(1, 5, 0, 0);
    this.flpComet.Name = "flpComet";
    this.flpComet.Size = new Size(312, 21);
    this.flpComet.TabIndex = 157;
    this.label3.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label3.Location = new Point(3, 6);
    this.label3.Margin = new Padding(3, 6, 3, 3);
    this.label3.Name = "label3";
    this.label3.Size = new Size(116, 13);
    this.label3.TabIndex = 157;
    this.label3.Text = "Start Distance (m km)";
    this.txtCometStartDistance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtCometStartDistance.BorderStyle = BorderStyle.None;
    this.txtCometStartDistance.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtCometStartDistance.Location = new Point(125, 7);
    this.txtCometStartDistance.Margin = new Padding(3, 7, 0, 2);
    this.txtCometStartDistance.Name = "txtCometStartDistance";
    this.txtCometStartDistance.Size = new Size(45, 13);
    this.txtCometStartDistance.TabIndex = 7;
    this.txtCometStartDistance.Text = "0";
    this.txtCometStartDistance.TextAlign = HorizontalAlignment.Center;
    this.flpAsteroidA.Controls.Add((Control) this.label4);
    this.flpAsteroidA.Controls.Add((Control) this.txtNumAsteroids);
    this.flpAsteroidA.Location = new Point(1, 134);
    this.flpAsteroidA.Margin = new Padding(1, 5, 0, 0);
    this.flpAsteroidA.Name = "flpAsteroidA";
    this.flpAsteroidA.Size = new Size(312, 21);
    this.flpAsteroidA.TabIndex = 158;
    this.label4.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label4.Location = new Point(3, 6);
    this.label4.Margin = new Padding(3, 6, 3, 3);
    this.label4.Name = "label4";
    this.label4.Size = new Size(204, 13);
    this.label4.TabIndex = 157;
    this.label4.Text = "Number of Asteroids (0 = Random)";
    this.txtNumAsteroids.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtNumAsteroids.BorderStyle = BorderStyle.None;
    this.txtNumAsteroids.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtNumAsteroids.Location = new Point(213, 7);
    this.txtNumAsteroids.Margin = new Padding(3, 7, 0, 2);
    this.txtNumAsteroids.Name = "txtNumAsteroids";
    this.txtNumAsteroids.Size = new Size(45, 13);
    this.txtNumAsteroids.TabIndex = 8;
    this.txtNumAsteroids.Text = "0";
    this.txtNumAsteroids.TextAlign = HorizontalAlignment.Center;
    this.flpAsteroidB.Controls.Add((Control) this.label7);
    this.flpAsteroidB.Controls.Add((Control) this.txtBeltWidth);
    this.flpAsteroidB.Location = new Point(1, 160 /*0xA0*/);
    this.flpAsteroidB.Margin = new Padding(1, 5, 0, 0);
    this.flpAsteroidB.Name = "flpAsteroidB";
    this.flpAsteroidB.Size = new Size(312, 21);
    this.flpAsteroidB.TabIndex = 159;
    this.label7.AutoSize = true;
    this.label7.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label7.Location = new Point(3, 6);
    this.label7.Margin = new Padding(3, 6, 3, 3);
    this.label7.Name = "label7";
    this.label7.Size = new Size(204, 13);
    this.label7.TabIndex = 158;
    this.label7.Text = "Maximum Belt Width (m km) (0 = Random)";
    this.txtBeltWidth.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtBeltWidth.BorderStyle = BorderStyle.None;
    this.txtBeltWidth.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtBeltWidth.Location = new Point(213, 7);
    this.txtBeltWidth.Margin = new Padding(3, 7, 0, 2);
    this.txtBeltWidth.Name = "txtBeltWidth";
    this.txtBeltWidth.Size = new Size(45, 13);
    this.txtBeltWidth.TabIndex = 9;
    this.txtBeltWidth.Text = "0";
    this.txtBeltWidth.TextAlign = HorizontalAlignment.Center;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.ClientSize = new Size(334, 264);
    this.Controls.Add((Control) this.flowLayoutPanel1);
    this.Controls.Add((Control) this.lstvZones);
    this.Controls.Add((Control) this.cmdCancel);
    this.Controls.Add((Control) this.cmdOK);
    this.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (AddPlanet);
    this.Text = "Add Planet";
    this.FormClosing += new FormClosingEventHandler(this.AddPlanet_FormClosing);
    this.Load += new EventHandler(this.AddPlanet_Load);
    this.flowLayoutPanel1.ResumeLayout(false);
    this.flowLayoutPanel2.ResumeLayout(false);
    this.flowLayoutPanel2.PerformLayout();
    this.flpMoons.ResumeLayout(false);
    this.flpMoons.PerformLayout();
    this.flpTrojans.ResumeLayout(false);
    this.flpTrojans.PerformLayout();
    this.flpComet.ResumeLayout(false);
    this.flpComet.PerformLayout();
    this.flpAsteroidA.ResumeLayout(false);
    this.flpAsteroidA.PerformLayout();
    this.flpAsteroidB.ResumeLayout(false);
    this.flpAsteroidB.PerformLayout();
    this.ResumeLayout(false);
  }
}
