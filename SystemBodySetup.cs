// Decompiled with JetBrains decompiler
// Type: SystemBodySetup
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
public class SystemBodySetup : Form
{
  private GClass0 gclass0_0;
  private GClass1 gclass1_0;
  private GClass194 gclass194_0;
  private GClass21 gclass21_0;
  private IContainer icontainer_0;
  private FlowLayoutPanel flowLayoutPanel16;
  private Label label10;
  private Label lblDistance;
  private Label label15;
  private Label label16;
  private Label label17;
  private FlowLayoutPanel flowLayoutPanel17;
  private TextBox txtHydroExtent;
  private TextBox txtDistance;
  private TextBox txtDiameter;
  private TextBox txtAlbedo;
  private TextBox txtDensity;
  private ListView lstvReadOnly;
  private ColumnHeader columnHeader_0;
  private ColumnHeader columnHeader_1;
  private ListView lstvAtmosphere;
  private ColumnHeader columnHeader_2;
  private ColumnHeader columnHeader_3;
  private ColumnHeader columnHeader_4;
  private ComboBox cboGas;
  private TextBox txtMaxAtm;
  private Button cmdSetGasAtm;
  private Panel panel1;
  private FlowLayoutPanel flowLayoutPanel1;
  private ComboBox cboTerrain;
  private Label label1;
  private TextBox txtHours;
  private FlowLayoutPanel flowLayoutPanel2;
  private Button cmdUpdateBody;
  private Label label2;
  private TextBox txtBearing;
  private Label label3;
  private Label label4;
  private TextBox txtRadiation;
  private TextBox txtDust;
  private Label label5;
  private TextBox txtEccentricity;

  public SystemBodySetup(
    GClass0 gclass0_1,
    GClass1 gclass1_1,
    GClass194 gclass194_1,
    GClass21 gclass21_1)
  {
    this.InitializeComponent();
    this.gclass0_0 = gclass0_1;
    this.gclass1_0 = gclass1_1;
    this.gclass194_0 = gclass194_1;
    this.gclass21_0 = gclass21_1;
    this.gclass0_0.bool_21 = true;
  }

  private void method_0()
  {
    try
    {
      string string_11_1 = "-";
      string string_11_2 = "-";
      this.gclass0_0.bool_9 = true;
      this.lstvReadOnly.Items.Clear();
      List<GClass223> list = this.gclass0_0.dictionary_23.Values.OrderBy<GClass223, string>((Func<GClass223, string>) (gclass223_0 => gclass223_0.Name)).ToList<GClass223>();
      this.cboGas.DisplayMember = "Name";
      this.cboGas.DataSource = (object) list;
      this.gclass1_0.method_62(this.gclass194_0);
      if (this.gclass1_0.decimal_5 > 0M)
        string_11_1 = GClass226.smethod_53(this.gclass1_0.decimal_5) + "m";
      if (this.gclass1_0.gclass99_0.genum111_0 != GEnum111.const_0)
      {
        string name = this.gclass1_0.gclass99_0.Name;
      }
      if (this.gclass1_0.bool_0)
        string_11_2 = "Yes";
      string string_11_3 = this.gclass1_0.method_78(this.gclass21_0);
      string string_11_4 = this.gclass1_0.method_61(true, true);
      this.gclass0_0.method_601(this.lstvReadOnly, "Name", string_11_3, (string) null);
      this.gclass0_0.method_601(this.lstvReadOnly, "Body Type", GClass226.smethod_82((Enum) this.gclass1_0.auroraSystemBodyType_0), (string) null);
      this.gclass0_0.method_601(this.lstvReadOnly, "Maximum Population", string_11_1, (string) null);
      this.gclass0_0.method_601(this.lstvReadOnly, "Hydrosphere", GClass226.smethod_82((Enum) this.gclass1_0.auroraHydrosphereType_0), (string) null);
      this.gclass0_0.method_601(this.lstvReadOnly, "Gravity", GClass226.smethod_44(this.gclass1_0.double_7, 2) + " G", (string) null);
      this.gclass0_0.method_601(this.lstvReadOnly, "Pressure", GClass226.smethod_44(this.gclass1_0.double_15, 2) + " atm", (string) null);
      this.gclass0_0.method_601(this.lstvReadOnly, "Eccentricity", GClass226.smethod_44(this.gclass1_0.double_24, 2), (string) null);
      this.gclass0_0.method_601(this.lstvReadOnly, "Tidal Lock", string_11_2, (string) null);
      this.gclass0_0.method_601(this.lstvReadOnly, "Year", GClass226.smethod_57(this.gclass1_0.double_10), (string) null);
      this.gclass0_0.method_601(this.lstvReadOnly, "Mass", GClass226.smethod_52(this.gclass1_0.double_8), (string) null);
      double num1 = 4.0 * GClass226.double_13 * Math.Pow(this.gclass1_0.double_20, 2.0);
      this.gclass0_0.method_601(this.lstvReadOnly, "Terraform Rate vs Earth", GClass226.smethod_46((double) GClass226.decimal_15 / num1, 2), (string) null);
      this.gclass0_0.method_601(this.lstvReadOnly, "Lagrange Stablisation", string_11_4, (string) null);
      if (this.gclass1_0.double_7 < 0.1)
        this.gclass0_0.method_601(this.lstvReadOnly, "Atmosphere Retention", "No", (string) null);
      else
        this.gclass0_0.method_601(this.lstvReadOnly, "Atmosphere Retention", "Yes", (string) null);
      this.gclass0_0.method_594(this.lstvReadOnly, "");
      this.gclass1_0.method_72(this.gclass21_0, this.gclass194_0, this.lstvReadOnly, 3);
      this.txtHydroExtent.Text = Math.Round(this.gclass1_0.double_19, 2).ToString();
      this.txtDiameter.Text = Math.Round(this.gclass1_0.double_20 * 2.0).ToString();
      TextBox txtAlbedo = this.txtAlbedo;
      double num2 = Math.Round(this.gclass1_0.double_16, 2);
      string str1 = num2.ToString();
      txtAlbedo.Text = str1;
      TextBox txtDensity = this.txtDensity;
      num2 = Math.Round(this.gclass1_0.double_6, 2);
      string str2 = num2.ToString();
      txtDensity.Text = str2;
      TextBox txtHours = this.txtHours;
      num2 = Math.Round(this.gclass1_0.double_12, 2);
      string str3 = num2.ToString();
      txtHours.Text = str3;
      TextBox txtBearing = this.txtBearing;
      num2 = Math.Round(this.gclass1_0.double_5, 2);
      string str4 = num2.ToString();
      txtBearing.Text = str4;
      TextBox txtRadiation = this.txtRadiation;
      Decimal num3 = Math.Round(this.gclass1_0.decimal_3, 2);
      string str5 = num3.ToString();
      txtRadiation.Text = str5;
      TextBox txtDust = this.txtDust;
      num3 = Math.Round(this.gclass1_0.decimal_4, 2);
      string str6 = num3.ToString();
      txtDust.Text = str6;
      TextBox txtEccentricity = this.txtEccentricity;
      num2 = Math.Round(this.gclass1_0.double_24, 2);
      string str7 = num2.ToString();
      txtEccentricity.Text = str7;
      if (this.gclass1_0.genum12_0 == GEnum12.const_2)
      {
        this.lblDistance.Text = "Distance (km)";
        TextBox txtDistance = this.txtDistance;
        num2 = Math.Round(this.gclass1_0.double_2);
        string str8 = num2.ToString();
        txtDistance.Text = str8;
      }
      else
      {
        this.lblDistance.Text = "Distance (m km)";
        TextBox txtDistance = this.txtDistance;
        num2 = Math.Round(this.gclass1_0.double_2 * GClass226.double_14 / 1000000.0, 2);
        string str9 = num2.ToString();
        txtDistance.Text = str9;
      }
      this.gclass1_0.method_70(this.lstvAtmosphere, (GClass146) null, false);
      if (this.gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || this.gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian)
      {
        this.txtAlbedo.Enabled = false;
        this.txtHydroExtent.Enabled = false;
      }
      List<GClass99> gclass99List = this.gclass1_0.method_30();
      this.cboTerrain.DisplayMember = "Name";
      this.cboTerrain.DataSource = (object) gclass99List;
      this.cboTerrain.SelectedItem = (object) this.gclass1_0.gclass99_0;
      this.gclass0_0.bool_9 = false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3065);
    }
  }

  private void SystemBodySetup_Load(object sender, EventArgs e)
  {
    try
    {
      GClass207 gclass207 = this.gclass0_0.method_513(this.Name);
      this.Left = gclass207.int_0;
      this.Top = gclass207.int_1;
      this.method_0();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3066);
    }
  }

  private void cmdSetGasAtm_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass0_0.bool_9)
        return;
      GClass223 selectedItem = (GClass223) this.cboGas.SelectedItem;
      if (selectedItem == null)
        return;
      double double_45 = GClass226.smethod_3(this.txtMaxAtm.Text, 0.0);
      this.gclass1_0.method_9(selectedItem, double_45, (GClass146) null);
      this.method_0();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3067);
    }
  }

  private void txtDistance_TextChanged(object sender, EventArgs e)
  {
  }

  private void txtDiameter_TextChanged(object sender, EventArgs e)
  {
  }

  private void txtHydroExtent_TextChanged(object sender, EventArgs e)
  {
  }

  private void txtAlbedo_TextChanged(object sender, EventArgs e)
  {
  }

  private void txtDensity_TextChanged(object sender, EventArgs e)
  {
  }

  private void cboTerrain_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass0_0.bool_9)
        return;
      this.gclass1_0.gclass99_0 = (GClass99) this.cboTerrain.SelectedValue;
      this.method_0();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3073);
    }
  }

  private void txtHours_TextChanged(object sender, EventArgs e)
  {
  }

  private void lstvAtmosphere_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass0_0.bool_9 || this.lstvAtmosphere.SelectedItems.Count == 0 || this.lstvAtmosphere.SelectedItems[0].Tag == null)
        return;
      this.cboGas.SelectedItem = (object) ((GClass224) this.lstvAtmosphere.SelectedItems[0].Tag).gclass223_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3075);
    }
  }

  private void cmdUpdateBody_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass0_0.bool_9)
        return;
      List<GClass1> list = this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_1 => gclass1_1.gclass1_0 == this.gclass1_0 && gclass1_1.genum12_0 == GEnum12.const_3)).ToList<GClass1>();
      GClass209 gclass209_1 = new GClass209();
      GClass209 gclass209_2 = GClass226.smethod_5(this.txtDistance.Text);
      if (gclass209_2.bool_0)
      {
        if (this.gclass1_0.genum12_0 == GEnum12.const_2)
        {
          this.gclass1_0.double_2 = gclass209_2.double_0;
          if (this.gclass1_0.double_2 == 0.0)
            this.gclass1_0.double_2 = 100000.0;
        }
        else
        {
          double double2 = this.gclass1_0.double_2;
          this.gclass1_0.double_2 = gclass209_2.double_0 * 1000000.0 / GClass226.double_14;
          if (this.gclass1_0.double_2 == 0.0)
            this.gclass1_0.double_2 = 1.0;
          double num = this.gclass1_0.double_2 - double2;
          foreach (GClass1 gclass1 in list)
          {
            gclass1.double_2 += num;
            gclass1.method_8(false);
          }
        }
      }
      GClass209 gclass209_3 = GClass226.smethod_5(this.txtDiameter.Text);
      if (gclass209_3.bool_0)
      {
        this.gclass1_0.double_20 = gclass209_3.double_0 / 2.0;
        if (this.gclass1_0.double_20 <= 0.0)
          this.gclass1_0.double_20 = 10.0;
      }
      GClass209 gclass209_4 = GClass226.smethod_5(this.txtHydroExtent.Text);
      if (gclass209_4.bool_0)
      {
        this.gclass1_0.double_19 = gclass209_4.double_0;
        if (this.gclass1_0.double_19 < 0.0)
          this.gclass1_0.double_19 = 0.0;
      }
      GClass209 gclass209_5 = GClass226.smethod_5(this.txtAlbedo.Text);
      if (gclass209_5.bool_0)
      {
        this.gclass1_0.double_16 = gclass209_5.double_0;
        if (this.gclass1_0.double_16 <= 0.0)
          this.gclass1_0.double_16 = 1.0;
      }
      GClass209 gclass209_6 = GClass226.smethod_5(this.txtDensity.Text);
      if (gclass209_6.bool_0)
      {
        this.gclass1_0.double_6 = gclass209_6.double_0;
        if (this.gclass1_0.double_6 <= 0.0)
          this.gclass1_0.double_6 = 1.0;
      }
      GClass209 gclass209_7 = GClass226.smethod_5(this.txtHours.Text);
      if (gclass209_7.bool_0)
      {
        this.gclass1_0.double_12 = gclass209_7.double_0;
        if (this.gclass1_0.double_12 <= 0.0)
          this.gclass1_0.double_12 = 24.0;
      }
      GClass209 gclass209_8 = GClass226.smethod_5(this.txtBearing.Text);
      if (gclass209_8.bool_0)
      {
        this.gclass1_0.double_5 = gclass209_8.double_0;
        if (this.gclass1_0.double_5 <= 0.0)
          this.gclass1_0.double_5 = 0.0;
        if (this.gclass1_0.double_5 > 360.0)
          this.gclass1_0.double_5 = 0.0;
      }
      GClass208 gclass208_1 = GClass226.smethod_4(this.txtRadiation.Text);
      if (gclass208_1.bool_0)
      {
        this.gclass1_0.decimal_3 = gclass208_1.decimal_0;
        if (this.gclass1_0.decimal_3 <= 0M)
          this.gclass1_0.decimal_3 = 0M;
      }
      GClass208 gclass208_2 = GClass226.smethod_4(this.txtDust.Text);
      if (gclass208_2.bool_0)
      {
        this.gclass1_0.decimal_4 = gclass208_2.decimal_0;
        if (this.gclass1_0.decimal_4 <= 0M)
          this.gclass1_0.decimal_3 = 0M;
      }
      if (this.gclass1_0.genum12_0 == GEnum12.const_1 || this.gclass1_0.genum12_0 == GEnum12.const_3 || this.gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.Comet)
      {
        GClass209 gclass209_9 = GClass226.smethod_5(this.txtEccentricity.Text);
        if (gclass209_9.bool_0)
        {
          this.gclass1_0.double_24 = gclass209_9.double_0;
          if (this.gclass1_0.double_24 <= 0.0)
            this.gclass1_0.double_24 = 0.0;
          if (this.gclass1_0.double_24 > 0.95)
            this.gclass1_0.double_24 = 0.95;
        }
      }
      this.gclass1_0.method_8(true);
      foreach (GClass1 gclass1 in this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_1 => gclass1_1.gclass1_0 == this.gclass1_0 && gclass1_1.genum12_0 == GEnum12.const_2)).ToList<GClass1>())
        gclass1.method_8(false);
      this.gclass0_0.method_414(1.0, this.gclass1_0.gclass200_0, (GClass1) null, true);
      this.method_0();
      this.gclass1_0.gclass197_0.method_4();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3076);
    }
  }

  private void SystemBodySetup_FormClosing(object sender, FormClosingEventArgs e)
  {
    try
    {
      this.gclass0_0.method_512(this.Name, this.Left, this.Top);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3077);
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
    this.flowLayoutPanel16 = new FlowLayoutPanel();
    this.lblDistance = new Label();
    this.label15 = new Label();
    this.label10 = new Label();
    this.label16 = new Label();
    this.label17 = new Label();
    this.label1 = new Label();
    this.label2 = new Label();
    this.label3 = new Label();
    this.label4 = new Label();
    this.flowLayoutPanel17 = new FlowLayoutPanel();
    this.txtDistance = new TextBox();
    this.txtDiameter = new TextBox();
    this.txtHydroExtent = new TextBox();
    this.txtAlbedo = new TextBox();
    this.txtDensity = new TextBox();
    this.txtHours = new TextBox();
    this.txtBearing = new TextBox();
    this.txtRadiation = new TextBox();
    this.txtDust = new TextBox();
    this.lstvReadOnly = new ListView();
    this.columnHeader_0 = new ColumnHeader();
    this.columnHeader_1 = new ColumnHeader();
    this.lstvAtmosphere = new ListView();
    this.columnHeader_2 = new ColumnHeader();
    this.columnHeader_3 = new ColumnHeader();
    this.columnHeader_4 = new ColumnHeader();
    this.cboGas = new ComboBox();
    this.txtMaxAtm = new TextBox();
    this.cmdSetGasAtm = new Button();
    this.panel1 = new Panel();
    this.flowLayoutPanel1 = new FlowLayoutPanel();
    this.cmdUpdateBody = new Button();
    this.cboTerrain = new ComboBox();
    this.flowLayoutPanel2 = new FlowLayoutPanel();
    this.label5 = new Label();
    this.txtEccentricity = new TextBox();
    this.flowLayoutPanel16.SuspendLayout();
    this.flowLayoutPanel17.SuspendLayout();
    this.panel1.SuspendLayout();
    this.flowLayoutPanel1.SuspendLayout();
    this.flowLayoutPanel2.SuspendLayout();
    this.SuspendLayout();
    this.flowLayoutPanel16.Controls.Add((Control) this.lblDistance);
    this.flowLayoutPanel16.Controls.Add((Control) this.label15);
    this.flowLayoutPanel16.Controls.Add((Control) this.label10);
    this.flowLayoutPanel16.Controls.Add((Control) this.label16);
    this.flowLayoutPanel16.Controls.Add((Control) this.label17);
    this.flowLayoutPanel16.Controls.Add((Control) this.label1);
    this.flowLayoutPanel16.Controls.Add((Control) this.label2);
    this.flowLayoutPanel16.Controls.Add((Control) this.label3);
    this.flowLayoutPanel16.Controls.Add((Control) this.label4);
    this.flowLayoutPanel16.Controls.Add((Control) this.label5);
    this.flowLayoutPanel16.Location = new Point(0, 0);
    this.flowLayoutPanel16.Margin = new Padding(0, 0, 6, 0);
    this.flowLayoutPanel16.Name = "flowLayoutPanel16";
    this.flowLayoutPanel16.Size = new Size(120, 174);
    this.flowLayoutPanel16.TabIndex = 148;
    this.lblDistance.AutoSize = true;
    this.lblDistance.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lblDistance.Location = new Point(3, 2);
    this.lblDistance.Margin = new Padding(3, 2, 3, 2);
    this.lblDistance.Name = "lblDistance";
    this.lblDistance.Size = new Size(72, 13);
    this.lblDistance.TabIndex = 104;
    this.lblDistance.Text = "Distance (km)";
    this.label15.AutoSize = true;
    this.label15.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label15.Location = new Point(3, 19);
    this.label15.Margin = new Padding(3, 2, 3, 2);
    this.label15.Name = "label15";
    this.label15.Size = new Size(72, 13);
    this.label15.TabIndex = 105;
    this.label15.Text = "Diameter (km)";
    this.label10.AutoSize = true;
    this.label10.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label10.Location = new Point(3, 37);
    this.label10.Margin = new Padding(3, 3, 3, 2);
    this.label10.Name = "label10";
    this.label10.Size = new Size(104, 13);
    this.label10.TabIndex = 103;
    this.label10.Text = "Hydro Extent (0-100)";
    this.label16.AutoSize = true;
    this.label16.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label16.Location = new Point(3, 54);
    this.label16.Margin = new Padding(3, 2, 3, 2);
    this.label16.Name = "label16";
    this.label16.Size = new Size(92, 13);
    this.label16.TabIndex = 106;
    this.label16.Text = "Albedo (Earth = 1)";
    this.label17.AutoSize = true;
    this.label17.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label17.Location = new Point(3, 71);
    this.label17.Margin = new Padding(3, 2, 3, 2);
    this.label17.Name = "label17";
    this.label17.Size = new Size(94, 13);
    this.label17.TabIndex = 107;
    this.label17.Text = "Density (Earth = 1)";
    this.label1.AutoSize = true;
    this.label1.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label1.Location = new Point(3, 88);
    this.label1.Margin = new Padding(3, 2, 3, 2);
    this.label1.Name = "label1";
    this.label1.Size = new Size(85, 13);
    this.label1.TabIndex = 108;
    this.label1.Text = "Day Length (hrs)";
    this.label2.AutoSize = true;
    this.label2.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label2.Location = new Point(3, 105);
    this.label2.Margin = new Padding(3, 2, 3, 2);
    this.label2.Name = "label2";
    this.label2.Size = new Size(70, 13);
    this.label2.TabIndex = 109;
    this.label2.Text = "Bearing (deg)";
    this.label3.AutoSize = true;
    this.label3.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label3.Location = new Point(3, 122);
    this.label3.Margin = new Padding(3, 2, 3, 2);
    this.label3.Name = "label3";
    this.label3.Size = new Size(52, 13);
    this.label3.TabIndex = 110;
    this.label3.Text = "Radiation";
    this.label4.AutoSize = true;
    this.label4.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label4.Location = new Point(3, 139);
    this.label4.Margin = new Padding(3, 2, 3, 2);
    this.label4.Name = "label4";
    this.label4.Size = new Size(58, 13);
    this.label4.TabIndex = 111;
    this.label4.Text = "Dust Level";
    this.flowLayoutPanel17.Controls.Add((Control) this.txtDistance);
    this.flowLayoutPanel17.Controls.Add((Control) this.txtDiameter);
    this.flowLayoutPanel17.Controls.Add((Control) this.txtHydroExtent);
    this.flowLayoutPanel17.Controls.Add((Control) this.txtAlbedo);
    this.flowLayoutPanel17.Controls.Add((Control) this.txtDensity);
    this.flowLayoutPanel17.Controls.Add((Control) this.txtHours);
    this.flowLayoutPanel17.Controls.Add((Control) this.txtBearing);
    this.flowLayoutPanel17.Controls.Add((Control) this.txtRadiation);
    this.flowLayoutPanel17.Controls.Add((Control) this.txtDust);
    this.flowLayoutPanel17.Controls.Add((Control) this.txtEccentricity);
    this.flowLayoutPanel17.FlowDirection = FlowDirection.TopDown;
    this.flowLayoutPanel17.Location = new Point(129, 0);
    this.flowLayoutPanel17.Margin = new Padding(3, 0, 3, 0);
    this.flowLayoutPanel17.Name = "flowLayoutPanel17";
    this.flowLayoutPanel17.Size = new Size(115, 174);
    this.flowLayoutPanel17.TabIndex = 149;
    this.txtDistance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtDistance.BorderStyle = BorderStyle.None;
    this.txtDistance.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtDistance.Location = new Point(0, 2);
    this.txtDistance.Margin = new Padding(0, 2, 0, 2);
    this.txtDistance.Name = "txtDistance";
    this.txtDistance.Size = new Size(105, 13);
    this.txtDistance.TabIndex = 55;
    this.txtDistance.Text = "Distance";
    this.txtDistance.TextAlign = HorizontalAlignment.Right;
    this.txtDistance.TextChanged += new EventHandler(this.txtDistance_TextChanged);
    this.txtDiameter.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtDiameter.BorderStyle = BorderStyle.None;
    this.txtDiameter.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtDiameter.Location = new Point(0, 19);
    this.txtDiameter.Margin = new Padding(0, 2, 0, 2);
    this.txtDiameter.Name = "txtDiameter";
    this.txtDiameter.Size = new Size(105, 13);
    this.txtDiameter.TabIndex = 56;
    this.txtDiameter.Text = "Diameter";
    this.txtDiameter.TextAlign = HorizontalAlignment.Right;
    this.txtDiameter.TextChanged += new EventHandler(this.txtDiameter_TextChanged);
    this.txtHydroExtent.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtHydroExtent.BorderStyle = BorderStyle.None;
    this.txtHydroExtent.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtHydroExtent.Location = new Point(0, 37);
    this.txtHydroExtent.Margin = new Padding(0, 3, 0, 2);
    this.txtHydroExtent.Name = "txtHydroExtent";
    this.txtHydroExtent.Size = new Size(105, 13);
    this.txtHydroExtent.TabIndex = 54;
    this.txtHydroExtent.Text = "Hydro";
    this.txtHydroExtent.TextAlign = HorizontalAlignment.Right;
    this.txtHydroExtent.TextChanged += new EventHandler(this.txtHydroExtent_TextChanged);
    this.txtAlbedo.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtAlbedo.BorderStyle = BorderStyle.None;
    this.txtAlbedo.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtAlbedo.Location = new Point(0, 54);
    this.txtAlbedo.Margin = new Padding(0, 2, 0, 2);
    this.txtAlbedo.Name = "txtAlbedo";
    this.txtAlbedo.Size = new Size(105, 13);
    this.txtAlbedo.TabIndex = 57;
    this.txtAlbedo.Text = "Albedo";
    this.txtAlbedo.TextAlign = HorizontalAlignment.Right;
    this.txtAlbedo.TextChanged += new EventHandler(this.txtAlbedo_TextChanged);
    this.txtDensity.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtDensity.BorderStyle = BorderStyle.None;
    this.txtDensity.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtDensity.Location = new Point(0, 71);
    this.txtDensity.Margin = new Padding(0, 2, 0, 2);
    this.txtDensity.Name = "txtDensity";
    this.txtDensity.Size = new Size(105, 13);
    this.txtDensity.TabIndex = 58;
    this.txtDensity.Text = "Density";
    this.txtDensity.TextAlign = HorizontalAlignment.Right;
    this.txtDensity.TextChanged += new EventHandler(this.txtDensity_TextChanged);
    this.txtHours.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtHours.BorderStyle = BorderStyle.None;
    this.txtHours.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtHours.Location = new Point(0, 88);
    this.txtHours.Margin = new Padding(0, 2, 0, 2);
    this.txtHours.Name = "txtHours";
    this.txtHours.Size = new Size(105, 13);
    this.txtHours.TabIndex = 59;
    this.txtHours.Text = "Day Hours";
    this.txtHours.TextAlign = HorizontalAlignment.Right;
    this.txtHours.TextChanged += new EventHandler(this.txtHours_TextChanged);
    this.txtBearing.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtBearing.BorderStyle = BorderStyle.None;
    this.txtBearing.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtBearing.Location = new Point(0, 105);
    this.txtBearing.Margin = new Padding(0, 2, 0, 2);
    this.txtBearing.Name = "txtBearing";
    this.txtBearing.Size = new Size(105, 13);
    this.txtBearing.TabIndex = 60;
    this.txtBearing.Text = "Bearing";
    this.txtBearing.TextAlign = HorizontalAlignment.Right;
    this.txtRadiation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtRadiation.BorderStyle = BorderStyle.None;
    this.txtRadiation.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtRadiation.Location = new Point(0, 122);
    this.txtRadiation.Margin = new Padding(0, 2, 0, 2);
    this.txtRadiation.Name = "txtRadiation";
    this.txtRadiation.Size = new Size(105, 13);
    this.txtRadiation.TabIndex = 61;
    this.txtRadiation.Text = "Radiation";
    this.txtRadiation.TextAlign = HorizontalAlignment.Right;
    this.txtDust.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtDust.BorderStyle = BorderStyle.None;
    this.txtDust.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtDust.Location = new Point(0, 139);
    this.txtDust.Margin = new Padding(0, 2, 0, 2);
    this.txtDust.Name = "txtDust";
    this.txtDust.Size = new Size(105, 13);
    this.txtDust.TabIndex = 62;
    this.txtDust.Text = "Dust";
    this.txtDust.TextAlign = HorizontalAlignment.Right;
    this.lstvReadOnly.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstvReadOnly.BorderStyle = BorderStyle.FixedSingle;
    this.lstvReadOnly.Columns.AddRange(new ColumnHeader[2]
    {
      this.columnHeader_0,
      this.columnHeader_1
    });
    this.lstvReadOnly.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstvReadOnly.FullRowSelect = true;
    this.lstvReadOnly.HeaderStyle = ColumnHeaderStyle.None;
    this.lstvReadOnly.HideSelection = false;
    this.lstvReadOnly.Location = new Point(257, 5);
    this.lstvReadOnly.Margin = new Padding(3, 0, 3, 0);
    this.lstvReadOnly.Name = "lstvReadOnly";
    this.lstvReadOnly.Size = new Size(322, 483);
    this.lstvReadOnly.TabIndex = 150;
    this.lstvReadOnly.UseCompatibleStateImageBehavior = false;
    this.lstvReadOnly.View = View.Details;
    this.columnHeader_0.Width = 150;
    this.columnHeader_1.Width = 170;
    this.lstvAtmosphere.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstvAtmosphere.BorderStyle = BorderStyle.FixedSingle;
    this.lstvAtmosphere.Columns.AddRange(new ColumnHeader[3]
    {
      this.columnHeader_2,
      this.columnHeader_3,
      this.columnHeader_4
    });
    this.lstvAtmosphere.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstvAtmosphere.FullRowSelect = true;
    this.lstvAtmosphere.HeaderStyle = ColumnHeaderStyle.None;
    this.lstvAtmosphere.HideSelection = false;
    this.lstvAtmosphere.Location = new Point(3, 252);
    this.lstvAtmosphere.Margin = new Padding(3, 0, 3, 0);
    this.lstvAtmosphere.Name = "lstvAtmosphere";
    this.lstvAtmosphere.Size = new Size(250, 195);
    this.lstvAtmosphere.TabIndex = 151;
    this.lstvAtmosphere.UseCompatibleStateImageBehavior = false;
    this.lstvAtmosphere.View = View.Details;
    this.lstvAtmosphere.SelectedIndexChanged += new EventHandler(this.lstvAtmosphere_SelectedIndexChanged);
    this.columnHeader_2.Width = 120;
    this.columnHeader_3.TextAlign = HorizontalAlignment.Right;
    this.columnHeader_4.TextAlign = HorizontalAlignment.Right;
    this.cboGas.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboGas.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboGas.FormattingEnabled = true;
    this.cboGas.Location = new Point(3, 6);
    this.cboGas.Margin = new Padding(3, 6, 3, 0);
    this.cboGas.Name = "cboGas";
    this.cboGas.Size = new Size(135, 21);
    this.cboGas.TabIndex = 53;
    this.txtMaxAtm.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtMaxAtm.BorderStyle = BorderStyle.None;
    this.txtMaxAtm.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtMaxAtm.Location = new Point(141, 11);
    this.txtMaxAtm.Margin = new Padding(0, 11, 3, 3);
    this.txtMaxAtm.Name = "txtMaxAtm";
    this.txtMaxAtm.Size = new Size(50, 13);
    this.txtMaxAtm.TabIndex = 95;
    this.txtMaxAtm.Text = "0";
    this.txtMaxAtm.TextAlign = HorizontalAlignment.Center;
    this.cmdSetGasAtm.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSetGasAtm.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSetGasAtm.Location = new Point(192 /*0xC0*/, 2);
    this.cmdSetGasAtm.Margin = new Padding(18, 3, 12, 0);
    this.cmdSetGasAtm.Name = "cmdSetGasAtm";
    this.cmdSetGasAtm.Size = new Size(48 /*0x30*/, 30);
    this.cmdSetGasAtm.TabIndex = 98;
    this.cmdSetGasAtm.Tag = (object) "1200";
    this.cmdSetGasAtm.Text = "Set";
    this.cmdSetGasAtm.UseVisualStyleBackColor = false;
    this.cmdSetGasAtm.Click += new EventHandler(this.cmdSetGasAtm_Click);
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.txtMaxAtm);
    this.panel1.Controls.Add((Control) this.cboGas);
    this.panel1.Controls.Add((Control) this.cmdSetGasAtm);
    this.panel1.Location = new Point(3, 451);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(250, 37);
    this.panel1.TabIndex = 153;
    this.flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
    this.flowLayoutPanel1.Controls.Add((Control) this.flowLayoutPanel16);
    this.flowLayoutPanel1.Controls.Add((Control) this.flowLayoutPanel17);
    this.flowLayoutPanel1.Controls.Add((Control) this.cmdUpdateBody);
    this.flowLayoutPanel1.Location = new Point(3, 5);
    this.flowLayoutPanel1.Name = "flowLayoutPanel1";
    this.flowLayoutPanel1.Size = new Size(250, 210);
    this.flowLayoutPanel1.TabIndex = 155;
    this.cmdUpdateBody.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdUpdateBody.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdUpdateBody.Location = new Point(77, 177);
    this.cmdUpdateBody.Margin = new Padding(77, 3, 0, 0);
    this.cmdUpdateBody.Name = "cmdUpdateBody";
    this.cmdUpdateBody.Size = new Size(96 /*0x60*/, 30);
    this.cmdUpdateBody.TabIndex = 157;
    this.cmdUpdateBody.Tag = (object) "1200";
    this.cmdUpdateBody.Text = "Update Body";
    this.cmdUpdateBody.UseVisualStyleBackColor = false;
    this.cmdUpdateBody.Click += new EventHandler(this.cmdUpdateBody_Click);
    this.cboTerrain.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboTerrain.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboTerrain.FormattingEnabled = true;
    this.cboTerrain.Location = new Point(3, 3);
    this.cboTerrain.Margin = new Padding(3, 3, 3, 0);
    this.cboTerrain.Name = "cboTerrain";
    this.cboTerrain.Size = new Size(242, 21);
    this.cboTerrain.TabIndex = 53;
    this.cboTerrain.SelectedIndexChanged += new EventHandler(this.cboTerrain_SelectedIndexChanged);
    this.flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
    this.flowLayoutPanel2.Controls.Add((Control) this.cboTerrain);
    this.flowLayoutPanel2.Location = new Point(3, 219);
    this.flowLayoutPanel2.Name = "flowLayoutPanel2";
    this.flowLayoutPanel2.Size = new Size(250, 29);
    this.flowLayoutPanel2.TabIndex = 156;
    this.label5.AutoSize = true;
    this.label5.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label5.Location = new Point(3, 156);
    this.label5.Margin = new Padding(3, 2, 3, 2);
    this.label5.Name = "label5";
    this.label5.Size = new Size(62, 13);
    this.label5.TabIndex = 112 /*0x70*/;
    this.label5.Text = "Eccentricity";
    this.txtEccentricity.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtEccentricity.BorderStyle = BorderStyle.None;
    this.txtEccentricity.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtEccentricity.Location = new Point(0, 156);
    this.txtEccentricity.Margin = new Padding(0, 2, 0, 2);
    this.txtEccentricity.Name = "txtEccentricity";
    this.txtEccentricity.Size = new Size(105, 13);
    this.txtEccentricity.TabIndex = 63 /*0x3F*/;
    this.txtEccentricity.Text = "Eccentricity";
    this.txtEccentricity.TextAlign = HorizontalAlignment.Right;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.ClientSize = new Size(583, 491);
    this.Controls.Add((Control) this.flowLayoutPanel2);
    this.Controls.Add((Control) this.flowLayoutPanel1);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.lstvAtmosphere);
    this.Controls.Add((Control) this.lstvReadOnly);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (SystemBodySetup);
    this.Text = "System Body Modification";
    this.FormClosing += new FormClosingEventHandler(this.SystemBodySetup_FormClosing);
    this.Load += new EventHandler(this.SystemBodySetup_Load);
    this.flowLayoutPanel16.ResumeLayout(false);
    this.flowLayoutPanel16.PerformLayout();
    this.flowLayoutPanel17.ResumeLayout(false);
    this.flowLayoutPanel17.PerformLayout();
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.flowLayoutPanel1.ResumeLayout(false);
    this.flowLayoutPanel2.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
