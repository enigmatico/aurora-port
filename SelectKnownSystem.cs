// Decompiled with JetBrains decompiler
// Type: SelectKnownSystem
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class SelectKnownSystem : Form
{
    private GClass0 gclass0_0;
    private DIMKnownSystemsData198 gclass198_0;
    private bool bool_0;
    private bool bool_1 = true;
    private IContainer icontainer_0;
    private Button cmdCancel;
    private Button cmdGenerate;
    private Button cmdDistSol;
    private Button cmdDistSelected;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button cmdSortByName;
    private TextBox txtMinMass;
    private CheckBox chkExisting;
    private Label label6;
    private ListView lstvSystems;
    private ColumnHeader columnHeader_0;
    private ColumnHeader columnHeader_1;
    private ColumnHeader columnHeader_2;
    private ColumnHeader columnHeader_3;
    private ColumnHeader columnHeader_4;
    private ColumnHeader columnHeader_5;
    private ColumnHeader columnHeader_6;
    private ColumnHeader columnHeader_7;
    private ColumnHeader columnHeader_8;
    private ColumnHeader columnHeader_9;
    private ColumnHeader columnHeader_10;

    public SelectKnownSystem(GClass0 gclass0_1, bool bool_2)
    {
        this.InitializeComponent();
        this.gclass0_0 = gclass0_1;
        this.bool_1 = bool_2;
    }

    private void SelectKnownSystem_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2667);
        }
    }

    private void SelectKnownSystem_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            if (!this.bool_1)
                this.cmdGenerate.Text = "Select System";
            this.gclass0_0.method_544(this.lstvSystems, this.chkExisting.CheckState, this.bool_0,
                Convert.ToDouble(this.txtMinMass.Text), null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2668);
        }
    }

    private void cmdSortByName_Click(object sender, EventArgs e)
    {
        try
        {
            this.bool_0 = false;
            this.gclass0_0.method_544(this.lstvSystems, this.chkExisting.CheckState, this.bool_0,
                Convert.ToDouble(this.txtMinMass.Text), null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2669);
        }
    }

    private void cmdDistSol_Click(object sender, EventArgs e)
    {
        try
        {
            this.bool_0 = true;
            this.gclass0_0.method_544(this.lstvSystems, this.chkExisting.CheckState, this.bool_0,
                Convert.ToDouble(this.txtMinMass.Text), null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2670);
        }
    }

    private void chkExisting_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass0_0.method_544(this.lstvSystems, this.chkExisting.CheckState, this.bool_0,
                Convert.ToDouble(this.txtMinMass.Text), this.gclass198_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2671);
        }
    }

    private void lstvSystems_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvSystems.SelectedItems.Count > 0)
            {
                this.gclass198_0 = (DIMKnownSystemsData198)this.lstvSystems.SelectedItems[0].Tag;
                if (this.gclass198_0.bool_1)
                    this.cmdGenerate.Visible = false;
                else
                    this.cmdGenerate.Visible = true;
            }
            else
                this.gclass198_0 = null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2672);
        }
    }

    private void cmdDistSelected_Click(object sender, EventArgs e)
    {
        try
        {
            this.bool_0 = true;
            this.gclass0_0.method_544(this.lstvSystems, this.chkExisting.CheckState, this.bool_0,
                Convert.ToDouble(this.txtMinMass.Text), this.gclass198_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2673);
        }
    }

    private void cmdGenerate_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass198_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a system to generate");
            }
            else
            {
                this.gclass0_0.gclass198_0 = this.gclass198_0;
                this.Close();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2674);
        }
    }

    private void cmdCancel_Click(object sender, EventArgs e)
    {
        this.gclass0_0.bool_21 = true;
        this.Close();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.cmdCancel = new Button();
        this.cmdGenerate = new Button();
        this.cmdDistSol = new Button();
        this.cmdDistSelected = new Button();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.cmdSortByName = new Button();
        this.txtMinMass = new TextBox();
        this.chkExisting = new CheckBox();
        this.label6 = new Label();
        this.lstvSystems = new ListView();
        this.columnHeader_0 = new ColumnHeader();
        this.columnHeader_1 = new ColumnHeader();
        this.columnHeader_2 = new ColumnHeader();
        this.columnHeader_3 = new ColumnHeader();
        this.columnHeader_4 = new ColumnHeader();
        this.columnHeader_5 = new ColumnHeader();
        this.columnHeader_6 = new ColumnHeader();
        this.columnHeader_7 = new ColumnHeader();
        this.columnHeader_8 = new ColumnHeader();
        this.columnHeader_9 = new ColumnHeader();
        this.columnHeader_10 = new ColumnHeader();
        this.flowLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        this.cmdCancel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCancel.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdCancel.Location = new Point(960, 726);
        this.cmdCancel.Margin = new Padding(0);
        this.cmdCancel.Name = "cmdCancel";
        this.cmdCancel.Size = new Size(96 /*0x60*/, 30);
        this.cmdCancel.TabIndex = 113;
        this.cmdCancel.Tag = "1200";
        this.cmdCancel.Text = "Cancel";
        this.cmdCancel.UseVisualStyleBackColor = false;
        this.cmdCancel.Click += this.cmdCancel_Click;
        this.cmdGenerate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdGenerate.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdGenerate.Location = new Point(0, 0);
        this.cmdGenerate.Margin = new Padding(0);
        this.cmdGenerate.Name = "cmdGenerate";
        this.cmdGenerate.Size = new Size(96 /*0x60*/, 30);
        this.cmdGenerate.TabIndex = 112 /*0x70*/;
        this.cmdGenerate.Tag = "1200";
        this.cmdGenerate.Text = "Create System";
        this.cmdGenerate.UseVisualStyleBackColor = false;
        this.cmdGenerate.Visible = false;
        this.cmdGenerate.Click += this.cmdGenerate_Click;
        this.cmdDistSol.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDistSol.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDistSol.Location = new Point(192 /*0xC0*/, 0);
        this.cmdDistSol.Margin = new Padding(0);
        this.cmdDistSol.Name = "cmdDistSol";
        this.cmdDistSol.Size = new Size(96 /*0x60*/, 30);
        this.cmdDistSol.TabIndex = 115;
        this.cmdDistSol.Tag = "1200";
        this.cmdDistSol.Text = "Sort From Sol";
        this.cmdDistSol.UseVisualStyleBackColor = false;
        this.cmdDistSol.Click += this.cmdDistSol_Click;
        this.cmdDistSelected.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDistSelected.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDistSelected.Location = new Point(288, 0);
        this.cmdDistSelected.Margin = new Padding(0);
        this.cmdDistSelected.Name = "cmdDistSelected";
        this.cmdDistSelected.Size = new Size(96 /*0x60*/, 30);
        this.cmdDistSelected.TabIndex = 116;
        this.cmdDistSelected.Tag = "1200";
        this.cmdDistSelected.Text = "Sort Selected";
        this.cmdDistSelected.UseVisualStyleBackColor = false;
        this.cmdDistSelected.Click += this.cmdDistSelected_Click;
        this.flowLayoutPanel1.Controls.Add(this.cmdGenerate);
        this.flowLayoutPanel1.Controls.Add(this.cmdSortByName);
        this.flowLayoutPanel1.Controls.Add(this.cmdDistSol);
        this.flowLayoutPanel1.Controls.Add(this.cmdDistSelected);
        this.flowLayoutPanel1.Location = new Point(9, 726);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(498, 30);
        this.flowLayoutPanel1.TabIndex = 117;
        this.cmdSortByName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortByName.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSortByName.Location = new Point(96 /*0x60*/, 0);
        this.cmdSortByName.Margin = new Padding(0);
        this.cmdSortByName.Name = "cmdSortByName";
        this.cmdSortByName.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortByName.TabIndex = 117;
        this.cmdSortByName.Tag = "1200";
        this.cmdSortByName.Text = "Sort by Name";
        this.cmdSortByName.UseVisualStyleBackColor = false;
        this.cmdSortByName.Click += this.cmdSortByName_Click;
        this.txtMinMass.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMinMass.BorderStyle = BorderStyle.None;
        this.txtMinMass.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtMinMass.Location = new Point(631, 735);
        this.txtMinMass.Margin = new Padding(3, 8, 3, 3);
        this.txtMinMass.Name = "txtMinMass";
        this.txtMinMass.Size = new Size(40, 13);
        this.txtMinMass.TabIndex = 119;
        this.txtMinMass.Text = "0.0";
        this.txtMinMass.TextAlign = HorizontalAlignment.Center;
        this.chkExisting.AutoSize = true;
        this.chkExisting.Location = new Point(848, 733);
        this.chkExisting.Name = "chkExisting";
        this.chkExisting.Size = new Size(100, 17);
        this.chkExisting.TabIndex = 121;
        this.chkExisting.Text = "Include Existing";
        this.chkExisting.UseVisualStyleBackColor = true;
        this.chkExisting.CheckedChanged += this.chkExisting_CheckedChanged;
        this.label6.AutoSize = true;
        this.label6.Location = new Point(530, 730);
        this.label6.Name = "label6";
        this.label6.Padding = new Padding(0, 5, 5, 0);
        this.label6.Size = new Size(103, 18);
        this.label6.TabIndex = 122;
        this.label6.Text = "Minimum Star Mass";
        this.lstvSystems.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvSystems.BorderStyle = BorderStyle.FixedSingle;
        this.lstvSystems.Columns.AddRange(new ColumnHeader[11]
        {
            this.columnHeader_0,
            this.columnHeader_1,
            this.columnHeader_2,
            this.columnHeader_3,
            this.columnHeader_4,
            this.columnHeader_5,
            this.columnHeader_6,
            this.columnHeader_7,
            this.columnHeader_8,
            this.columnHeader_9,
            this.columnHeader_10
        });
        this.lstvSystems.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvSystems.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvSystems.HideSelection = false;
        this.lstvSystems.Location = new Point(10, 12);
        this.lstvSystems.MultiSelect = false;
        this.lstvSystems.Name = "lstvSystems";
        this.lstvSystems.Size = new Size(1044, 708);
        this.lstvSystems.TabIndex = 123;
        this.lstvSystems.UseCompatibleStateImageBehavior = false;
        this.lstvSystems.View = View.Details;
        this.lstvSystems.SelectedIndexChanged += this.lstvSystems_SelectedIndexChanged;
        this.columnHeader_0.Text = "Name";
        this.columnHeader_0.Width = 150;
        this.columnHeader_1.Text = "Spectral Class";
        this.columnHeader_1.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_1.Width = 80 /*0x50*/;
        this.columnHeader_2.Text = "Diameter";
        this.columnHeader_2.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_2.Width = 25;
        this.columnHeader_3.Text = "Mass";
        this.columnHeader_3.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_3.Width = 70;
        this.columnHeader_4.Text = "Luminosity";
        this.columnHeader_4.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_4.Width = 70;
        this.columnHeader_5.Text = "Parent Star";
        this.columnHeader_5.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_5.Width = 70;
        this.columnHeader_6.Text = "Orbital Period";
        this.columnHeader_6.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_6.Width = 70;
        this.columnHeader_7.Text = "Orbital Distance";
        this.columnHeader_7.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_7.Width = 80 /*0x50*/;
        this.columnHeader_8.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_8.Width = 70;
        this.columnHeader_9.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_9.Width = 70;
        this.columnHeader_10.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_10.Width = 70;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(1066, 761);
        this.Controls.Add(this.lstvSystems);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.chkExisting);
        this.Controls.Add(this.txtMinMass);
        this.Controls.Add(this.flowLayoutPanel1);
        this.Controls.Add(this.cmdCancel);
        this.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.Name = nameof(SelectKnownSystem);
        this.Text = "Select Known System to Generate";
        this.FormClosing += this.SelectKnownSystem_FormClosing;
        this.Load += this.SelectKnownSystem_Load;
        this.flowLayoutPanel1.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}