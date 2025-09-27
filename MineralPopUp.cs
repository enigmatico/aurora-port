// Decompiled with JetBrains decompiler
// Type: MineralPopUp
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class MineralPopUp : Form
{
    private SystemBodyData gclass1_0;
    private GameRace gclass21_0;
    private GClass0 gclass0_0;
    private IContainer icontainer_0;
    private TextBox txtMinerals;

    public MineralPopUp(SystemBodyData gclass1_1, GameRace gclass21_1, GClass0 gclass0_1)
    {
        this.InitializeComponent();
        this.gclass1_0 = gclass1_1;
        this.gclass21_0 = gclass21_1;
        this.gclass0_0 = gclass0_1;
    }

    private void MineralPopUp_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2019);
        }
    }

    private void MineralPopUp_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            this.gclass1_0.method_69(this.txtMinerals, this.gclass21_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2020);
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
        this.txtMinerals = new TextBox();
        this.SuspendLayout();
        this.txtMinerals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMinerals.BorderStyle = BorderStyle.FixedSingle;
        this.txtMinerals.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.txtMinerals.Location = new Point(3, 1);
        this.txtMinerals.Multiline = true;
        this.txtMinerals.Name = "txtMinerals";
        this.txtMinerals.Size = new Size(262, 195);
        this.txtMinerals.TabIndex = 134;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(267, 199);
        this.Controls.Add(this.txtMinerals);
        this.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.Name = nameof(MineralPopUp);
        this.Text = "Mineral Text";
        this.FormClosing += this.MineralPopUp_FormClosing;
        this.Load += this.MineralPopUp_Load;
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}