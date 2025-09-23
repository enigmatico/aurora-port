// Decompiled with JetBrains decompiler
// Type: SelectRace
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class SelectRace : Form
{
  private GClass0 gclass0_0;
  private GClass21 gclass21_0;
  private GClass146 gclass146_0;
  private IContainer icontainer_0;
  private ComboBox cboTargetPopulation;
  private Button cmdCancel;
  private Button cmdOK;
  private TextBox txtInput;

  public SelectRace(GClass21 gclass21_1, GClass0 gclass0_1, GClass146 gclass146_1)
  {
    this.InitializeComponent();
    this.gclass0_0 = gclass0_1;
    this.gclass21_0 = gclass21_1;
    this.gclass146_0 = gclass146_1;
    this.gclass0_0.bool_21 = true;
    this.gclass0_0.gclass146_0 = (GClass146) null;
  }

  private void SelectRace_Load(object sender, EventArgs e)
  {
    try
    {
      this.gclass21_0.method_332(this.cboTargetPopulation, this.gclass146_0);
      if (this.cboTargetPopulation.Items.Count == 0)
        this.Close();
      this.Text = this.gclass0_0.string_3;
      this.txtInput.Text = this.gclass0_0.string_4;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3566);
    }
  }

  private void cmdCancel_Click(object sender, EventArgs e)
  {
    try
    {
      this.gclass0_0.bool_21 = true;
      this.Close();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3567);
    }
  }

  private void cmdOK_Click(object sender, EventArgs e)
  {
    try
    {
      this.gclass0_0.bool_21 = false;
      this.gclass0_0.gclass146_0 = (GClass146) this.cboTargetPopulation.SelectedValue;
      this.gclass0_0.string_4 = this.txtInput.Text;
      this.Close();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3568);
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
    this.cboTargetPopulation = new ComboBox();
    this.cmdCancel = new Button();
    this.cmdOK = new Button();
    this.txtInput = new TextBox();
    this.SuspendLayout();
    this.cboTargetPopulation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboTargetPopulation.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboTargetPopulation.FormattingEnabled = true;
    this.cboTargetPopulation.Location = new Point(12, 12);
    this.cboTargetPopulation.Margin = new Padding(3, 3, 3, 0);
    this.cboTargetPopulation.Name = "cboTargetPopulation";
    this.cboTargetPopulation.Size = new Size(381, 21);
    this.cboTargetPopulation.TabIndex = 58;
    this.cmdCancel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdCancel.DialogResult = DialogResult.Cancel;
    this.cmdCancel.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdCancel.Location = new Point(297, 59);
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
    this.cmdOK.Location = new Point(12, 59);
    this.cmdOK.Margin = new Padding(0);
    this.cmdOK.Name = "cmdOK";
    this.cmdOK.Size = new Size(96 /*0x60*/, 30);
    this.cmdOK.TabIndex = 56;
    this.cmdOK.Tag = (object) "1200";
    this.cmdOK.Text = "OK";
    this.cmdOK.UseVisualStyleBackColor = false;
    this.cmdOK.Click += new EventHandler(this.cmdOK_Click);
    this.txtInput.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtInput.BorderStyle = BorderStyle.FixedSingle;
    this.txtInput.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtInput.Location = new Point(12, 36);
    this.txtInput.Name = "txtInput";
    this.txtInput.Size = new Size(381, 20);
    this.txtInput.TabIndex = 59;
    this.txtInput.Text = "0";
    this.txtInput.TextAlign = HorizontalAlignment.Center;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.ClientSize = new Size(405, 97);
    this.Controls.Add((Control) this.txtInput);
    this.Controls.Add((Control) this.cboTargetPopulation);
    this.Controls.Add((Control) this.cmdCancel);
    this.Controls.Add((Control) this.cmdOK);
    this.Name = nameof (SelectRace);
    this.Text = "Select Race";
    this.Load += new EventHandler(this.SelectRace_Load);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
