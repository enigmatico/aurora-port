// Decompiled with JetBrains decompiler
// Type: RaceComparison
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class RaceComparison : Form
{
    private GClass0 gclass0_0;
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
    
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value
    private ListView lstvCompare;
    private ColumnHeader columnHeader_0;
    private Label label1;

    public RaceComparison(GClass0 gclass0_1)
    {
        this.InitializeComponent();
        this.gclass0_0 = gclass0_1;
    }

    private void RaceComparison_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2569);
        }
    }

    private void RaceComparison_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            this.Text = string.Format("Race Comparison   {0}", this.gclass0_0.method_586(true));
            this.Width = this.gclass0_0.method_514(this.lstvCompare) + 40;
            this.ActiveControl = this.label1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2570);
        }
    }

    private void RaceComparison_KeyDown(object sender, KeyEventArgs e)
    {
        try
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F4)
            {
                this.Close();
            }
            else
            {
                if (this.gclass0_0.tacticalMap_0.Race == null)
                    return;
                this.gclass0_0.tacticalMap_0.Race.method_174(e, this.gclass0_0.tacticalMap_0.gclass202_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3283);
        }
    }

    

    private void InitializeComponent()
    {
        this.lstvCompare = new ListView();
        this.columnHeader_0 = new ColumnHeader();
        this.label1 = new Label();
        this.SuspendLayout();
        this.lstvCompare.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvCompare.BorderStyle = BorderStyle.None;
        this.lstvCompare.Columns.AddRange(new ColumnHeader[1]
        {
            this.columnHeader_0
        });
        this.lstvCompare.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvCompare.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvCompare.Location = new Point(0, 0);
        this.lstvCompare.MultiSelect = false;
        this.lstvCompare.Name = "lstvCompare";
        this.lstvCompare.Size = new Size(1384, 841);
        this.lstvCompare.TabIndex = 129;
        this.lstvCompare.UseCompatibleStateImageBehavior = false;
        this.lstvCompare.View = View.Details;
        this.columnHeader_0.Width = 180;
        this.label1.AutoSize = true;
        this.label1.Location = new Point(1532, 30);
        this.label1.Name = "label1";
        this.label1.Size = new Size(35, 13);
        this.label1.TabIndex = 130;
        this.label1.Text = "label1";
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(1384, 841);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.lstvCompare);
        this.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.KeyPreview = true;
        this.Name = "RaceComparison";
        this.Text = "RaceComparison";
        this.FormClosing += this.RaceComparison_FormClosing;
        this.Load += this.RaceComparison_Load;
        this.KeyDown += this.RaceComparison_KeyDown;
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}