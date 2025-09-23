// Decompiled with JetBrains decompiler
// Type: cmdSelect
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
public class cmdSelect : Form
{
  private GClass0 gclass0_0;
  private IContainer icontainer_0;
  private ListBox lstThemes;
  private ListBox lstNames;
  private Button cmdSelectName;
  private Button cmdCancel;

  public cmdSelect(GClass0 gclass0_1)
  {
    this.InitializeComponent();
    this.DoubleBuffered = true;
    this.gclass0_0 = gclass0_1;
    this.gclass0_0.bool_21 = true;
  }

  private void cmdSelect_FormClosing(object sender, FormClosingEventArgs e)
  {
    try
    {
      this.gclass0_0.method_512(this.Name, this.Left, this.Top);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2675);
    }
  }

  private void cmdSelect_Load(object sender, EventArgs e)
  {
    try
    {
      GClass207 gclass207 = this.gclass0_0.method_513(this.Name);
      this.Left = gclass207.int_0;
      this.Top = gclass207.int_1;
      this.gclass0_0.bool_9 = true;
      List<GClass140> list = this.gclass0_0.dictionary_55.Values.OrderBy<GClass140, string>((Func<GClass140, string>) (gclass140_0 => gclass140_0.Description)).ToList<GClass140>();
      this.lstThemes.DisplayMember = "Description";
      this.lstThemes.DataSource = (object) list;
      this.gclass0_0.bool_9 = false;
      if (this.gclass0_0.gclass140_0 == null)
        return;
      this.lstThemes.SelectedItem = (object) this.gclass0_0.gclass140_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2676);
    }
  }

  private void lstThemes_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      GClass140 selectedItem = (GClass140) this.lstThemes.SelectedItem;
      if (selectedItem == null)
        return;
      if (!this.gclass0_0.bool_9)
        this.gclass0_0.gclass140_0 = selectedItem;
      this.lstNames.DataSource = (object) selectedItem.list_0.OrderBy<string, string>((Func<string, string>) (string_0 => string_0)).ToList<string>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2677);
    }
  }

  private void cmdCancel_Click(object sender, EventArgs e) => this.Close();

  private void cmdSelectName_Click(object sender, EventArgs e)
  {
    try
    {
      this.gclass0_0.string_4 = (string) this.lstNames.SelectedItem;
      this.gclass0_0.bool_21 = false;
      this.Close();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2678);
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
    this.lstThemes = new ListBox();
    this.lstNames = new ListBox();
    this.cmdSelectName = new Button();
    this.cmdCancel = new Button();
    this.SuspendLayout();
    this.lstThemes.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstThemes.BorderStyle = BorderStyle.FixedSingle;
    this.lstThemes.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstThemes.FormattingEnabled = true;
    this.lstThemes.Location = new Point(4, 4);
    this.lstThemes.Name = "lstThemes";
    this.lstThemes.Size = new Size(217, 769);
    this.lstThemes.TabIndex = 107;
    this.lstThemes.SelectedIndexChanged += new EventHandler(this.lstThemes_SelectedIndexChanged);
    this.lstNames.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstNames.BorderStyle = BorderStyle.FixedSingle;
    this.lstNames.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstNames.FormattingEnabled = true;
    this.lstNames.Location = new Point(227, 4);
    this.lstNames.Name = "lstNames";
    this.lstNames.Size = new Size(217, 769);
    this.lstNames.TabIndex = 108;
    this.cmdSelectName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSelectName.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSelectName.Location = new Point(4, 776);
    this.cmdSelectName.Margin = new Padding(0);
    this.cmdSelectName.Name = "cmdSelectName";
    this.cmdSelectName.Size = new Size(96 /*0x60*/, 30);
    this.cmdSelectName.TabIndex = 109;
    this.cmdSelectName.Tag = (object) "1200";
    this.cmdSelectName.Text = "Select Name";
    this.cmdSelectName.UseVisualStyleBackColor = false;
    this.cmdSelectName.Click += new EventHandler(this.cmdSelectName_Click);
    this.cmdCancel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdCancel.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdCancel.Location = new Point(348, 776);
    this.cmdCancel.Margin = new Padding(0);
    this.cmdCancel.Name = "cmdCancel";
    this.cmdCancel.Size = new Size(96 /*0x60*/, 30);
    this.cmdCancel.TabIndex = 110;
    this.cmdCancel.Tag = (object) "1200";
    this.cmdCancel.Text = "Cancel";
    this.cmdCancel.UseVisualStyleBackColor = false;
    this.cmdCancel.Click += new EventHandler(this.cmdCancel_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.ClientSize = new Size(448, 808);
    this.Controls.Add((Control) this.cmdCancel);
    this.Controls.Add((Control) this.cmdSelectName);
    this.Controls.Add((Control) this.lstNames);
    this.Controls.Add((Control) this.lstThemes);
    this.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (cmdSelect);
    this.Text = "Select";
    this.FormClosing += new FormClosingEventHandler(this.cmdSelect_FormClosing);
    this.Load += new EventHandler(this.cmdSelect_Load);
    this.ResumeLayout(false);
  }
}
