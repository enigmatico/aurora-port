// Decompiled with JetBrains decompiler
// Type: StarSetup
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class StarSetup : Form
{
  private GClass0 gclass0_0;
  private GClass197 gclass197_0;
  private GClass200 gclass200_0;
  private IContainer icontainer_0;
  private ComboBox cboStellarType;
  private Button cmdCancel;
  private Button cmdOK;
  private ListView lstvStellarType;
  private ColumnHeader columnHeader_0;
  private ColumnHeader columnHeader_1;
  private Label label1;
  private FlowLayoutPanel flpComponents;
  private RadioButton rdoA;
  private RadioButton rdoB;
  private RadioButton rdoC;
  private Label label3;
  private TextBox txtOrbit;
  private Label label2;
  private TextBox txtBearing;
  private Label label4;
  private TextBox txtEccentricity;
  private Label label5;
  private TextBox txtEccDirection;

  public StarSetup(GClass0 gclass0_1, GClass197 gclass197_1, GClass200 gclass200_1)
  {
    this.InitializeComponent();
    this.gclass0_0 = gclass0_1;
    this.gclass197_0 = gclass197_1;
    this.gclass200_0 = gclass200_1;
    this.gclass0_0.bool_21 = true;
  }

  private void StarSetup_Load(object sender, EventArgs e)
  {
    try
    {
      GClass207 gclass207 = this.gclass0_0.method_513(this.Name);
      this.Left = gclass207.int_0;
      this.Top = gclass207.int_1;
      this.gclass0_0.bool_9 = true;
      this.method_1(this.cboStellarType);
      if (this.gclass197_0 != null)
      {
        this.cboStellarType.SelectedItem = (object) this.gclass197_0.gclass217_0;
        this.txtBearing.Text = GClass226.smethod_44(this.gclass197_0.double_3, 2);
        this.txtOrbit.Text = GClass226.smethod_44(this.gclass197_0.double_2, 2);
        this.txtEccentricity.Text = GClass226.smethod_44(this.gclass197_0.double_7, 3);
        this.txtEccDirection.Text = GClass226.smethod_44(this.gclass197_0.double_8, 3);
      }
      else
      {
        this.cboStellarType.SelectedItem = (object) this.gclass0_0.dictionary_25[70];
        this.txtBearing.Text = "0";
        this.txtOrbit.Text = "10";
        this.txtEccentricity.Text = "0";
        this.txtEccDirection.Text = "0";
      }
      this.method_0();
      this.gclass0_0.bool_9 = false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2952);
    }
  }

  private void method_0()
  {
    try
    {
      if (this.gclass197_0 != null)
      {
        if (this.gclass197_0.int_3 == 1)
        {
          this.rdoA.Visible = false;
          this.rdoB.Visible = false;
          this.rdoC.Visible = false;
        }
        else
        {
          if (this.gclass200_0.int_3 < 4)
            this.rdoC.Visible = false;
          if (this.gclass200_0.int_3 < 3)
            this.rdoB.Visible = false;
          if (this.gclass197_0.int_4 == 1)
            this.rdoA.Checked = true;
          else if (this.gclass197_0.int_4 == 2)
          {
            this.rdoB.Checked = true;
          }
          else
          {
            if (this.gclass197_0.int_4 != 3)
              return;
            this.rdoC.Checked = true;
          }
        }
      }
      else
      {
        if (this.gclass200_0.int_3 < 3)
          this.rdoC.Visible = false;
        if (this.gclass200_0.int_3 < 2)
          this.rdoB.Visible = false;
        this.rdoA.Checked = true;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2953);
    }
  }

  private void method_1(ComboBox comboBox_0)
  {
    try
    {
      List<GClass217> list = this.gclass0_0.dictionary_25.Values.OrderBy<GClass217, int>((Func<GClass217, int>) (gclass217_0 => gclass217_0.int_4)).ThenBy<GClass217, string>((Func<GClass217, string>) (gclass217_0 => gclass217_0.string_0)).ThenBy<GClass217, string>((Func<GClass217, string>) (gclass217_0 => gclass217_0.string_1)).ThenBy<GClass217, int>((Func<GClass217, int>) (gclass217_0 => gclass217_0.int_1)).ToList<GClass217>();
      comboBox_0.DisplayMember = "StellarDescription";
      comboBox_0.DataSource = (object) list;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2954);
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
      GClass226.smethod_74(ex, 2955);
    }
  }

  private void cboStellarType_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      GClass217 selectedValue = (GClass217) this.cboStellarType.SelectedValue;
      this.lstvStellarType.Items.Clear();
      string string_11_1 = "";
      if (selectedValue.string_0 == "O")
        string_11_1 = "Blue";
      else if (!(selectedValue.string_0 == "B") && !(selectedValue.string_0 == "WR"))
      {
        if (!(selectedValue.string_0 == "A") && !(selectedValue.string_0 == "D"))
        {
          if (selectedValue.string_0 == "F")
            string_11_1 = "Yellow-white";
          else if (selectedValue.string_0 == "G")
            string_11_1 = "Yellow";
          else if (selectedValue.string_0 == "K")
            string_11_1 = "Orange";
          else if (selectedValue.string_0 == "M")
            string_11_1 = "Red";
          else if (selectedValue.string_0 == "L" || selectedValue.string_0 == "T" || selectedValue.string_0 == "Y")
            string_11_1 = "Brown";
        }
        else
          string_11_1 = "White";
      }
      else
        string_11_1 = "Blue-white";
      string string_11_2 = selectedValue.int_4 != 5 ? (selectedValue.int_4 != 4 ? (selectedValue.int_4 != 3 ? (selectedValue.int_4 != 2 ? (selectedValue.int_4 != 1 ? "Dwarf" : "Hypergiant") : "Supergiant") : "Giant") : "Sub-Giant") : "Main Sequence Star";
      this.gclass0_0.method_601(this.lstvStellarType, "Colour", string_11_1, (string) null);
      this.gclass0_0.method_601(this.lstvStellarType, "Size", string_11_2, (string) null);
      this.gclass0_0.method_601(this.lstvStellarType, "Luminosity", GClass226.smethod_50(selectedValue.double_0), (string) null);
      this.gclass0_0.method_601(this.lstvStellarType, "Mass", GClass226.smethod_50(selectedValue.double_1), (string) null);
      this.gclass0_0.method_601(this.lstvStellarType, "Temperature", GClass226.smethod_42((Decimal) selectedValue.int_5, 4), (string) null);
      this.gclass0_0.method_601(this.lstvStellarType, "Diameter (km)", GClass226.smethod_50(selectedValue.method_1() / 1000000.0) + "m", (string) null);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2956);
    }
  }

  private void cmdOK_Click(object sender, EventArgs e)
  {
    try
    {
      GClass217 selectedValue = (GClass217) this.cboStellarType.SelectedValue;
      int int_7 = 0;
      double num1 = Convert.ToDouble(this.txtOrbit.Text);
      double num2 = Convert.ToDouble(this.txtBearing.Text);
      double num3 = Convert.ToDouble(this.txtEccentricity.Text);
      double num4 = Convert.ToDouble(this.txtEccDirection.Text);
      if (num3 < 0.0)
        num3 = 0.0;
      if (num3 > 0.95)
        num3 = 0.95;
      if (num4 >= 360.0 || num4 < 0.0)
        num4 = 0.0;
      if (num2 >= 360.0 || num2 < 0.0)
        num2 = 0.0;
      if (this.rdoA.Checked)
        int_7 = 1;
      else if (this.rdoB.Checked)
        int_7 = 2;
      else if (this.rdoC.Checked)
        int_7 = 3;
      if (this.gclass197_0 == null)
      {
        ++this.gclass200_0.int_3;
        selectedValue.int_10 = this.gclass200_0.int_3;
        selectedValue.int_11 = int_7;
        this.gclass0_0.method_645(selectedValue, this.gclass200_0, num1, num2, num3, num4);
      }
      else
      {
        this.gclass197_0.method_3(selectedValue, num1, num2, int_7, num3, num4);
        if (this.gclass197_0.int_3 == 1)
          this.gclass0_0.method_689(this.gclass200_0, this.gclass197_0);
      }
      this.gclass0_0.bool_21 = false;
      this.Close();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2957);
    }
  }

  private void StarSetup_FormClosing(object sender, FormClosingEventArgs e)
  {
    try
    {
      this.gclass0_0.method_512(this.Name, this.Left, this.Top);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2958);
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
    this.cboStellarType = new ComboBox();
    this.cmdCancel = new Button();
    this.cmdOK = new Button();
    this.lstvStellarType = new ListView();
    this.columnHeader_0 = new ColumnHeader();
    this.columnHeader_1 = new ColumnHeader();
    this.label1 = new Label();
    this.flpComponents = new FlowLayoutPanel();
    this.label3 = new Label();
    this.txtOrbit = new TextBox();
    this.label2 = new Label();
    this.txtBearing = new TextBox();
    this.rdoA = new RadioButton();
    this.rdoB = new RadioButton();
    this.rdoC = new RadioButton();
    this.label4 = new Label();
    this.txtEccentricity = new TextBox();
    this.label5 = new Label();
    this.txtEccDirection = new TextBox();
    this.flpComponents.SuspendLayout();
    this.SuspendLayout();
    this.cboStellarType.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboStellarType.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboStellarType.FormattingEnabled = true;
    this.cboStellarType.Location = new Point(83, 3);
    this.cboStellarType.Margin = new Padding(3, 3, 3, 0);
    this.cboStellarType.Name = "cboStellarType";
    this.cboStellarType.Size = new Size(66, 21);
    this.cboStellarType.TabIndex = 58;
    this.cboStellarType.SelectedIndexChanged += new EventHandler(this.cboStellarType_SelectedIndexChanged);
    this.cmdCancel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdCancel.DialogResult = DialogResult.Cancel;
    this.cmdCancel.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdCancel.Location = new Point(388, 169);
    this.cmdCancel.Margin = new Padding(0);
    this.cmdCancel.Name = "cmdCancel";
    this.cmdCancel.Size = new Size(96 /*0x60*/, 30);
    this.cmdCancel.TabIndex = 57;
    this.cmdCancel.Tag = (object) "1200";
    this.cmdCancel.Text = "Cancel";
    this.cmdCancel.UseVisualStyleBackColor = false;
    this.cmdCancel.Click += new EventHandler(this.cmdCancel_Click);
    this.cmdOK.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdOK.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdOK.Location = new Point(292, 169);
    this.cmdOK.Margin = new Padding(0);
    this.cmdOK.Name = "cmdOK";
    this.cmdOK.Size = new Size(96 /*0x60*/, 30);
    this.cmdOK.TabIndex = 56;
    this.cmdOK.Tag = (object) "1200";
    this.cmdOK.Text = "OK";
    this.cmdOK.UseVisualStyleBackColor = false;
    this.cmdOK.Click += new EventHandler(this.cmdOK_Click);
    this.lstvStellarType.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstvStellarType.BorderStyle = BorderStyle.FixedSingle;
    this.lstvStellarType.Columns.AddRange(new ColumnHeader[2]
    {
      this.columnHeader_0,
      this.columnHeader_1
    });
    this.lstvStellarType.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstvStellarType.FullRowSelect = true;
    this.lstvStellarType.HeaderStyle = ColumnHeaderStyle.None;
    this.lstvStellarType.HideSelection = false;
    this.lstvStellarType.Location = new Point(161, 6);
    this.lstvStellarType.Margin = new Padding(3, 0, 3, 0);
    this.lstvStellarType.Name = "lstvStellarType";
    this.lstvStellarType.Size = new Size(322, 160 /*0xA0*/);
    this.lstvStellarType.TabIndex = 134;
    this.lstvStellarType.UseCompatibleStateImageBehavior = false;
    this.lstvStellarType.View = View.Details;
    this.columnHeader_0.Width = 100;
    this.columnHeader_1.TextAlign = HorizontalAlignment.Center;
    this.columnHeader_1.Width = 200;
    this.label1.AutoSize = true;
    this.label1.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label1.Location = new Point(3, 7);
    this.label1.Margin = new Padding(3, 7, 3, 0);
    this.label1.Name = "label1";
    this.label1.Size = new Size(74, 13);
    this.label1.TabIndex = 135;
    this.label1.Text = "Spectral Class";
    this.flpComponents.Controls.Add((Control) this.label1);
    this.flpComponents.Controls.Add((Control) this.cboStellarType);
    this.flpComponents.Controls.Add((Control) this.label3);
    this.flpComponents.Controls.Add((Control) this.txtOrbit);
    this.flpComponents.Controls.Add((Control) this.label2);
    this.flpComponents.Controls.Add((Control) this.txtBearing);
    this.flpComponents.Controls.Add((Control) this.label4);
    this.flpComponents.Controls.Add((Control) this.txtEccentricity);
    this.flpComponents.Controls.Add((Control) this.label5);
    this.flpComponents.Controls.Add((Control) this.txtEccDirection);
    this.flpComponents.Controls.Add((Control) this.rdoA);
    this.flpComponents.Controls.Add((Control) this.rdoB);
    this.flpComponents.Controls.Add((Control) this.rdoC);
    this.flpComponents.Location = new Point(3, 3);
    this.flpComponents.Name = "flpComponents";
    this.flpComponents.Size = new Size(152, 196);
    this.flpComponents.TabIndex = 139;
    this.label3.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label3.Location = new Point(3, 27);
    this.label3.Margin = new Padding(3, 3, 3, 0);
    this.label3.Name = "label3";
    this.label3.Padding = new Padding(0, 5, 5, 0);
    this.label3.Size = new Size(58, 18);
    this.label3.TabIndex = 140;
    this.label3.Text = "Orbit (AU)";
    this.txtOrbit.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtOrbit.BorderStyle = BorderStyle.None;
    this.txtOrbit.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtOrbit.Location = new Point(67, 32 /*0x20*/);
    this.txtOrbit.Margin = new Padding(3, 8, 3, 3);
    this.txtOrbit.Name = "txtOrbit";
    this.txtOrbit.Size = new Size(80 /*0x50*/, 13);
    this.txtOrbit.TabIndex = 141;
    this.txtOrbit.Text = "10";
    this.txtOrbit.TextAlign = HorizontalAlignment.Center;
    this.label2.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label2.Location = new Point(3, 51);
    this.label2.Margin = new Padding(3, 3, 3, 0);
    this.label2.Name = "label2";
    this.label2.Padding = new Padding(0, 5, 5, 0);
    this.label2.Size = new Size(58, 18);
    this.label2.TabIndex = 142;
    this.label2.Text = "Bearing";
    this.txtBearing.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtBearing.BorderStyle = BorderStyle.None;
    this.txtBearing.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtBearing.Location = new Point(67, 56);
    this.txtBearing.Margin = new Padding(3, 8, 3, 3);
    this.txtBearing.Name = "txtBearing";
    this.txtBearing.Size = new Size(80 /*0x50*/, 13);
    this.txtBearing.TabIndex = 143;
    this.txtBearing.Text = "0";
    this.txtBearing.TextAlign = HorizontalAlignment.Center;
    this.rdoA.AutoSize = true;
    this.rdoA.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.rdoA.Location = new Point(5, 126);
    this.rdoA.Margin = new Padding(5, 6, 3, 3);
    this.rdoA.Name = "rdoA";
    this.rdoA.Size = new Size(84, 17);
    this.rdoA.TabIndex = 0;
    this.rdoA.TabStop = true;
    this.rdoA.Text = "Orbit Primary";
    this.rdoA.UseVisualStyleBackColor = true;
    this.rdoB.AutoSize = true;
    this.rdoB.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.rdoB.Location = new Point(5, 149);
    this.rdoB.Margin = new Padding(5, 3, 3, 3);
    this.rdoB.Name = "rdoB";
    this.rdoB.Size = new Size(114, 17);
    this.rdoB.TabIndex = 1;
    this.rdoB.TabStop = true;
    this.rdoB.Text = "Orbit Component B";
    this.rdoB.UseVisualStyleBackColor = true;
    this.rdoC.AutoSize = true;
    this.rdoC.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.rdoC.Location = new Point(5, 172);
    this.rdoC.Margin = new Padding(5, 3, 3, 3);
    this.rdoC.Name = "rdoC";
    this.rdoC.Size = new Size(114, 17);
    this.rdoC.TabIndex = 2;
    this.rdoC.TabStop = true;
    this.rdoC.Text = "Orbit Component C";
    this.rdoC.UseVisualStyleBackColor = true;
    this.label4.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label4.Location = new Point(3, 75);
    this.label4.Margin = new Padding(3, 3, 3, 0);
    this.label4.Name = "label4";
    this.label4.Padding = new Padding(0, 5, 5, 0);
    this.label4.Size = new Size(68, 18);
    this.label4.TabIndex = 144 /*0x90*/;
    this.label4.Text = "Eccentricity";
    this.txtEccentricity.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtEccentricity.BorderStyle = BorderStyle.None;
    this.txtEccentricity.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtEccentricity.Location = new Point(77, 80 /*0x50*/);
    this.txtEccentricity.Margin = new Padding(3, 8, 3, 3);
    this.txtEccentricity.Name = "txtEccentricity";
    this.txtEccentricity.Size = new Size(60, 13);
    this.txtEccentricity.TabIndex = 145;
    this.txtEccentricity.Text = "0";
    this.txtEccentricity.TextAlign = HorizontalAlignment.Center;
    this.label5.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.label5.Location = new Point(3, 99);
    this.label5.Margin = new Padding(3, 3, 3, 0);
    this.label5.Name = "label5";
    this.label5.Padding = new Padding(0, 5, 5, 0);
    this.label5.Size = new Size(73, 18);
    this.label5.TabIndex = 146;
    this.label5.Text = "Ecc Bearing";
    this.txtEccDirection.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtEccDirection.BorderStyle = BorderStyle.None;
    this.txtEccDirection.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtEccDirection.Location = new Point(82, 104);
    this.txtEccDirection.Margin = new Padding(3, 8, 3, 3);
    this.txtEccDirection.Name = "txtEccDirection";
    this.txtEccDirection.Size = new Size(50, 13);
    this.txtEccDirection.TabIndex = 147;
    this.txtEccDirection.Text = "0";
    this.txtEccDirection.TextAlign = HorizontalAlignment.Center;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.ClientSize = new Size(487, 202);
    this.Controls.Add((Control) this.lstvStellarType);
    this.Controls.Add((Control) this.flpComponents);
    this.Controls.Add((Control) this.cmdCancel);
    this.Controls.Add((Control) this.cmdOK);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (StarSetup);
    this.Text = "Star Setup";
    this.FormClosing += new FormClosingEventHandler(this.StarSetup_FormClosing);
    this.Load += new EventHandler(this.StarSetup_Load);
    this.flpComponents.ResumeLayout(false);
    this.flpComponents.PerformLayout();
    this.ResumeLayout(false);
  }
}
