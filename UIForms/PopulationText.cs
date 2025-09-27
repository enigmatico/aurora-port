// Decompiled with JetBrains decompiler
// Type: PopulationText
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class PopulationText : Form
{
    private PopulationData gclass146_0;
    private FleetData gclass85_0;
    private GClass22 gclass22_0;
    private GroundUnitFormationTemplateData gclass102_0;
    private GameRace gclass21_0;
    private AlienRaceInfo gclass110_0;
    private TreeView treeView_0;
    private GEnum127 genum127_0;
    private CheckState checkState_0;
    private CheckState checkState_1;
    private GClass0 gclass0_0;
    private IContainer icontainer_0;
    private TextBox txtDetails;

    public PopulationText(PopulationData gclass146_1, TreeView treeView_1, GClass0 gclass0_1)
    {
        this.InitializeComponent();
        this.gclass146_0 = gclass146_1;
        this.treeView_0 = treeView_1;
        this.gclass0_0 = gclass0_1;
    }

    public PopulationText(
        FleetData gclass85_1,
        GClass0 gclass0_1,
        CheckState checkState_2,
        CheckState checkState_3)
    {
        this.InitializeComponent();
        this.gclass85_0 = gclass85_1;
        this.gclass0_0 = gclass0_1;
        this.checkState_0 = checkState_2;
        this.checkState_1 = checkState_3;
    }

    public PopulationText(GClass22 gclass22_1, GClass0 gclass0_1)
    {
        this.InitializeComponent();
        this.gclass22_0 = gclass22_1;
        this.gclass0_0 = gclass0_1;
    }

    public PopulationText(AlienRaceInfo gclass110_1, GClass0 gclass0_1)
    {
        this.InitializeComponent();
        this.gclass110_0 = gclass110_1;
        this.gclass0_0 = gclass0_1;
    }

    public PopulationText(GroundUnitFormationTemplateData gclass102_1, GClass0 gclass0_1)
    {
        this.InitializeComponent();
        this.gclass102_0 = gclass102_1;
        this.gclass0_0 = gclass0_1;
    }

    public PopulationText(GameRace gclass21_1, GEnum127 genum127_1, GClass0 gclass0_1)
    {
        this.InitializeComponent();
        this.gclass21_0 = gclass21_1;
        this.genum127_0 = genum127_1;
        this.gclass0_0 = gclass0_1;
    }

    private void PopulationText_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            this.method_0();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2263);
        }
    }

    private void method_0()
    {
        try
        {
            if (this.gclass146_0 != null)
            {
                this.Text = "Population Details";
                this.txtDetails.Text = this.gclass146_0.method_35();
            }
            else if (this.gclass85_0 != null)
            {
                this.Width = 1000;
                this.Text = "Fleet Ship List";
                this.txtDetails.Text = this.gclass85_0.method_10(this.checkState_0, this.checkState_1);
            }
            else if (this.gclass22_0 != null)
            {
                this.Width = 1000;
                this.Text = "Class Ship List";
                this.txtDetails.Text = this.gclass22_0.method_23();
            }
            else if (this.gclass102_0 != null)
            {
                this.Width = 400;
                this.Text = "Template Unit List";
                this.txtDetails.Text = this.gclass102_0.method_11();
            }
            else if (this.gclass110_0 != null)
            {
                this.Width = 1000;
                this.Text = "Alien Class Intelligence - " + this.gclass110_0.AlienRaceName;
                this.txtDetails.Text = this.gclass110_0.ViewingRace.method_21(this.gclass110_0);
            }
            else if (this.gclass21_0 != null)
            {
                if (this.genum127_0 == GEnum127.const_1)
                {
                    this.Width = 400;
                    this.Text = "Order of Battle";
                    this.txtDetails.Text = this.gclass21_0.method_93();
                }
                else
                {
                    if (this.genum127_0 != GEnum127.const_2)
                        return;
                    this.Width = 1000;
                    this.Text = "Race Ship List";
                    this.txtDetails.Text = this.gclass21_0.method_78();
                }
            }
            else
            {
                string str = "";
                this.Text = "Population Details";
                foreach (TreeNode node in this.treeView_0.Nodes)
                    str += this.method_1(node);
                this.txtDetails.Text = str;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2264);
        }
    }

    private string method_1(TreeNode treeNode_0)
    {
        try
        {
            string str = "";
            if (treeNode_0.Tag is PopulationData)
            {
                PopulationData tag = (PopulationData)treeNode_0.Tag;
                if (tag.decimal_30 > 0M || tag.dictionary_0.Count > 0)
                    str += tag.method_35();
            }
            else
            {
                foreach (TreeNode node in treeNode_0.Nodes)
                    str += this.method_1(node);
            }

            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2265);
            return "";
        }
    }

    private void txtDetails_TextChanged(object sender, EventArgs e)
    {
    }

    private void PopulationText_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2266);
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
        this.txtDetails = new TextBox();
        this.SuspendLayout();
        this.txtDetails.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDetails.BorderStyle = BorderStyle.FixedSingle;
        this.txtDetails.Dock = DockStyle.Fill;
        this.txtDetails.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtDetails.Location = new Point(0, 0);
        this.txtDetails.Multiline = true;
        this.txtDetails.Name = "txtDetails";
        this.txtDetails.ScrollBars = ScrollBars.Vertical;
        this.txtDetails.Size = new Size(531, 721);
        this.txtDetails.TabIndex = 135;
        this.txtDetails.TextChanged += this.txtDetails_TextChanged;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(531, 721);
        this.Controls.Add(this.txtDetails);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.Name = "PopulationText";
        this.Text = "Population Details";
        this.FormClosing += this.PopulationText_FormClosing;
        this.Load += this.PopulationText_Load;
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}