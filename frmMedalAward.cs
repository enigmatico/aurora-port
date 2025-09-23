// Decompiled with JetBrains decompiler
// Type: frmMedalAward
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
public class frmMedalAward : Form
{
  private GClass0 gclass0_0;
  private GClass21 gclass21_0;
  private IContainer icontainer_0;
  private Button cmdAwardMedal;
  private Button cmdCancel;
  private FlowLayoutPanel flpCommandType;
  private CheckBox chkCommander;
  private CheckBox chkNavalAdmin;
  private CheckBox chkFleetCommander;
  private CheckBox chkExecutiveOfficer;
  private CheckBox chkCAG;
  private CheckBox chkChiefEngineer;
  private CheckBox chkTacticalOfficer;
  private CheckBox chkScienceOfficer;
  private CheckBox chkGround;
  private CheckBox chkSector;
  private CheckBox chkGovenor;
  private CheckBox chkResearch;
  private CheckBox chkAcademy;
  private ListView lstvMedals;
  private ColumnHeader columnHeader_0;
  private ColumnHeader columnHeader_1;
  private ColumnHeader columnHeader_2;

  public frmMedalAward(GClass0 gclass0_1, GClass21 gclass21_1)
  {
    this.gclass0_0 = gclass0_1;
    this.gclass21_0 = gclass21_1;
    this.InitializeComponent();
  }

  private void frmMedalAward_FormClosing(object sender, FormClosingEventArgs e)
  {
    try
    {
      this.gclass0_0.method_512(this.Name, this.Left, this.Top);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1060);
    }
  }

  private void frmMedalAward_Load(object sender, EventArgs e)
  {
    try
    {
      GClass207 gclass207 = this.gclass0_0.method_513(this.Name);
      this.Left = gclass207.int_0;
      this.Top = gclass207.int_1;
      this.gclass21_0.method_311(this.lstvMedals);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1061);
    }
  }

  private void cmdCancel_Click(object sender, EventArgs e)
  {
    this.gclass0_0.list_31.Clear();
    this.gclass0_0.gclass42_0 = (GClass42) null;
    this.Close();
  }

  private void method_0(object sender, EventArgs e)
  {
  }

  private void cmdAwardMedal_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.lstvMedals.SelectedItems.Count == 0)
      {
        int num = (int) MessageBox.Show("Please select a Medal");
      }
      else
      {
        this.gclass0_0.list_31.Clear();
        foreach (CheckBox control in (ArrangedElementCollection) this.flpCommandType.Controls)
        {
          if (control.CheckState == CheckState.Checked)
            this.gclass0_0.list_31.Add((AuroraCommandType) Convert.ToInt32(control.Tag));
        }
        this.gclass0_0.gclass42_0 = (GClass42) this.lstvMedals.SelectedItems[0].Tag;
        this.Close();
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1062);
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
    this.cmdAwardMedal = new Button();
    this.cmdCancel = new Button();
    this.flpCommandType = new FlowLayoutPanel();
    this.chkNavalAdmin = new CheckBox();
    this.chkFleetCommander = new CheckBox();
    this.chkCommander = new CheckBox();
    this.chkExecutiveOfficer = new CheckBox();
    this.chkCAG = new CheckBox();
    this.chkChiefEngineer = new CheckBox();
    this.chkTacticalOfficer = new CheckBox();
    this.chkScienceOfficer = new CheckBox();
    this.chkGround = new CheckBox();
    this.chkSector = new CheckBox();
    this.chkGovenor = new CheckBox();
    this.chkResearch = new CheckBox();
    this.chkAcademy = new CheckBox();
    this.lstvMedals = new ListView();
    this.columnHeader_0 = new ColumnHeader();
    this.columnHeader_1 = new ColumnHeader();
    this.columnHeader_2 = new ColumnHeader();
    this.flpCommandType.SuspendLayout();
    this.SuspendLayout();
    this.cmdAwardMedal.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdAwardMedal.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdAwardMedal.Location = new Point(3, 580);
    this.cmdAwardMedal.Margin = new Padding(0);
    this.cmdAwardMedal.Name = "cmdAwardMedal";
    this.cmdAwardMedal.Size = new Size(96 /*0x60*/, 30);
    this.cmdAwardMedal.TabIndex = 149;
    this.cmdAwardMedal.Tag = (object) "1200";
    this.cmdAwardMedal.Text = "Award";
    this.cmdAwardMedal.UseVisualStyleBackColor = false;
    this.cmdAwardMedal.Click += new EventHandler(this.cmdAwardMedal_Click);
    this.cmdCancel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdCancel.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdCancel.Location = new Point(1098, 581);
    this.cmdCancel.Margin = new Padding(0);
    this.cmdCancel.Name = "cmdCancel";
    this.cmdCancel.Size = new Size(96 /*0x60*/, 30);
    this.cmdCancel.TabIndex = 150;
    this.cmdCancel.Tag = (object) "1200";
    this.cmdCancel.Text = "Cancel";
    this.cmdCancel.UseVisualStyleBackColor = false;
    this.cmdCancel.Click += new EventHandler(this.cmdCancel_Click);
    this.flpCommandType.BorderStyle = BorderStyle.FixedSingle;
    this.flpCommandType.Controls.Add((Control) this.chkNavalAdmin);
    this.flpCommandType.Controls.Add((Control) this.chkFleetCommander);
    this.flpCommandType.Controls.Add((Control) this.chkCommander);
    this.flpCommandType.Controls.Add((Control) this.chkExecutiveOfficer);
    this.flpCommandType.Controls.Add((Control) this.chkCAG);
    this.flpCommandType.Controls.Add((Control) this.chkChiefEngineer);
    this.flpCommandType.Controls.Add((Control) this.chkTacticalOfficer);
    this.flpCommandType.Controls.Add((Control) this.chkScienceOfficer);
    this.flpCommandType.Controls.Add((Control) this.chkGround);
    this.flpCommandType.Controls.Add((Control) this.chkSector);
    this.flpCommandType.Controls.Add((Control) this.chkGovenor);
    this.flpCommandType.Controls.Add((Control) this.chkResearch);
    this.flpCommandType.Controls.Add((Control) this.chkAcademy);
    this.flpCommandType.FlowDirection = FlowDirection.TopDown;
    this.flpCommandType.Location = new Point(1009, 3);
    this.flpCommandType.Name = "flpCommandType";
    this.flpCommandType.Size = new Size(185, 575);
    this.flpCommandType.TabIndex = 152;
    this.chkNavalAdmin.AutoSize = true;
    this.chkNavalAdmin.Checked = true;
    this.chkNavalAdmin.CheckState = CheckState.Checked;
    this.chkNavalAdmin.Location = new Point(6, 3);
    this.chkNavalAdmin.Margin = new Padding(6, 3, 3, 3);
    this.chkNavalAdmin.Name = "chkNavalAdmin";
    this.chkNavalAdmin.Size = new Size(145, 17);
    this.chkNavalAdmin.TabIndex = 7;
    this.chkNavalAdmin.Tag = (object) "12";
    this.chkNavalAdmin.Text = "Naval Admin Commander";
    this.chkNavalAdmin.UseVisualStyleBackColor = true;
    this.chkFleetCommander.AutoSize = true;
    this.chkFleetCommander.Location = new Point(6, 26);
    this.chkFleetCommander.Margin = new Padding(6, 3, 3, 3);
    this.chkFleetCommander.Name = "chkFleetCommander";
    this.chkFleetCommander.Size = new Size(111, 17);
    this.chkFleetCommander.TabIndex = 6;
    this.chkFleetCommander.Tag = (object) "16";
    this.chkFleetCommander.Text = "Fleet Commander ";
    this.chkFleetCommander.UseVisualStyleBackColor = true;
    this.chkCommander.AutoSize = true;
    this.chkCommander.Location = new Point(6, 49);
    this.chkCommander.Margin = new Padding(6, 3, 3, 3);
    this.chkCommander.Name = "chkCommander";
    this.chkCommander.Size = new Size(106, 17);
    this.chkCommander.TabIndex = 0;
    this.chkCommander.Tag = (object) "1";
    this.chkCommander.Text = "Ship Commander";
    this.chkCommander.UseVisualStyleBackColor = true;
    this.chkExecutiveOfficer.AutoSize = true;
    this.chkExecutiveOfficer.Location = new Point(6, 72);
    this.chkExecutiveOfficer.Margin = new Padding(6, 3, 3, 3);
    this.chkExecutiveOfficer.Name = "chkExecutiveOfficer";
    this.chkExecutiveOfficer.Size = new Size(110, 17);
    this.chkExecutiveOfficer.TabIndex = 1;
    this.chkExecutiveOfficer.Tag = (object) "8";
    this.chkExecutiveOfficer.Text = "Executive Officer ";
    this.chkExecutiveOfficer.UseVisualStyleBackColor = true;
    this.chkCAG.AutoSize = true;
    this.chkCAG.Location = new Point(6, 95);
    this.chkCAG.Margin = new Padding(6, 3, 3, 3);
    this.chkCAG.Name = "chkCAG";
    this.chkCAG.Size = new Size(132, 17);
    this.chkCAG.TabIndex = 5;
    this.chkCAG.Tag = (object) "15";
    this.chkCAG.Text = "Commander, Air Group";
    this.chkCAG.UseVisualStyleBackColor = true;
    this.chkChiefEngineer.AutoSize = true;
    this.chkChiefEngineer.Location = new Point(6, 118);
    this.chkChiefEngineer.Margin = new Padding(6, 3, 3, 3);
    this.chkChiefEngineer.Name = "chkChiefEngineer";
    this.chkChiefEngineer.Size = new Size(95, 17);
    this.chkChiefEngineer.TabIndex = 2;
    this.chkChiefEngineer.Tag = (object) "9";
    this.chkChiefEngineer.Text = "Chief Engineer";
    this.chkChiefEngineer.UseVisualStyleBackColor = true;
    this.chkTacticalOfficer.AutoSize = true;
    this.chkTacticalOfficer.Location = new Point(6, 141);
    this.chkTacticalOfficer.Margin = new Padding(6, 3, 3, 3);
    this.chkTacticalOfficer.Name = "chkTacticalOfficer";
    this.chkTacticalOfficer.Size = new Size(101, 17);
    this.chkTacticalOfficer.TabIndex = 4;
    this.chkTacticalOfficer.Tag = (object) "11";
    this.chkTacticalOfficer.Text = "Tactical Officer ";
    this.chkTacticalOfficer.UseVisualStyleBackColor = true;
    this.chkScienceOfficer.AutoSize = true;
    this.chkScienceOfficer.Location = new Point(6, 164);
    this.chkScienceOfficer.Margin = new Padding(6, 3, 3, 3);
    this.chkScienceOfficer.Name = "chkScienceOfficer";
    this.chkScienceOfficer.Size = new Size(99, 17);
    this.chkScienceOfficer.TabIndex = 3;
    this.chkScienceOfficer.Tag = (object) "10";
    this.chkScienceOfficer.Text = "Science Officer";
    this.chkScienceOfficer.UseVisualStyleBackColor = true;
    this.chkGround.AutoSize = true;
    this.chkGround.Location = new Point(6, 187);
    this.chkGround.Margin = new Padding(6, 3, 3, 3);
    this.chkGround.Name = "chkGround";
    this.chkGround.Size = new Size(169, 17);
    this.chkGround.TabIndex = 8;
    this.chkGround.Tag = (object) "5";
    this.chkGround.Text = "Ground Formation Commander";
    this.chkGround.UseVisualStyleBackColor = true;
    this.chkSector.AutoSize = true;
    this.chkSector.Location = new Point(6, 210);
    this.chkSector.Margin = new Padding(6, 3, 3, 3);
    this.chkSector.Name = "chkSector";
    this.chkSector.Size = new Size(116, 17);
    this.chkSector.TabIndex = 9;
    this.chkSector.Tag = (object) "4";
    this.chkSector.Text = "Sector Commander";
    this.chkSector.UseVisualStyleBackColor = true;
    this.chkGovenor.AutoSize = true;
    this.chkGovenor.Location = new Point(6, 233);
    this.chkGovenor.Margin = new Padding(6, 3, 3, 3);
    this.chkGovenor.Name = "chkGovenor";
    this.chkGovenor.Size = new Size(102, 17);
    this.chkGovenor.TabIndex = 10;
    this.chkGovenor.Tag = (object) "3";
    this.chkGovenor.Text = "Colony Govenor";
    this.chkGovenor.UseVisualStyleBackColor = true;
    this.chkResearch.AutoSize = true;
    this.chkResearch.Location = new Point(6, 256 /*0x0100*/);
    this.chkResearch.Margin = new Padding(6, 3, 3, 3);
    this.chkResearch.Name = "chkResearch";
    this.chkResearch.Size = new Size(144 /*0x90*/, 17);
    this.chkResearch.TabIndex = 11;
    this.chkResearch.Tag = (object) "7";
    this.chkResearch.Text = "Research Project Leader";
    this.chkResearch.UseVisualStyleBackColor = true;
    this.chkAcademy.AutoSize = true;
    this.chkAcademy.Location = new Point(6, 279);
    this.chkAcademy.Margin = new Padding(6, 3, 3, 3);
    this.chkAcademy.Name = "chkAcademy";
    this.chkAcademy.Size = new Size(135, 17);
    this.chkAcademy.TabIndex = 12;
    this.chkAcademy.Tag = (object) "17";
    this.chkAcademy.Text = "Academy Commandant";
    this.chkAcademy.UseVisualStyleBackColor = true;
    this.lstvMedals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstvMedals.BorderStyle = BorderStyle.FixedSingle;
    this.lstvMedals.Columns.AddRange(new ColumnHeader[3]
    {
      this.columnHeader_0,
      this.columnHeader_1,
      this.columnHeader_2
    });
    this.lstvMedals.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstvMedals.FullRowSelect = true;
    this.lstvMedals.HeaderStyle = ColumnHeaderStyle.None;
    this.lstvMedals.HideSelection = false;
    this.lstvMedals.Location = new Point(3, 3);
    this.lstvMedals.Margin = new Padding(3, 0, 3, 0);
    this.lstvMedals.Name = "lstvMedals";
    this.lstvMedals.Size = new Size(1000, 575);
    this.lstvMedals.TabIndex = 153;
    this.lstvMedals.UseCompatibleStateImageBehavior = false;
    this.lstvMedals.View = View.Details;
    this.columnHeader_0.Width = 200;
    this.columnHeader_1.TextAlign = HorizontalAlignment.Center;
    this.columnHeader_2.Width = 720;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.ClientSize = new Size(1197, 612);
    this.Controls.Add((Control) this.lstvMedals);
    this.Controls.Add((Control) this.flpCommandType);
    this.Controls.Add((Control) this.cmdCancel);
    this.Controls.Add((Control) this.cmdAwardMedal);
    this.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (frmMedalAward);
    this.Text = "Award Medal";
    this.FormClosing += new FormClosingEventHandler(this.frmMedalAward_FormClosing);
    this.Load += new EventHandler(this.frmMedalAward_Load);
    this.flpCommandType.ResumeLayout(false);
    this.flpCommandType.PerformLayout();
    this.ResumeLayout(false);
  }
}
