// Decompiled with JetBrains decompiler
// Type: ManageNPRTemplates
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class ManageNPRTemplates : Form
{
    private IContainer icontainer_0;
    private ComboBox cboRaces;

    public ManageNPRTemplates() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.cboRaces = new ComboBox();
        this.SuspendLayout();
        this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRaces.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboRaces.FormattingEnabled = true;
        this.cboRaces.Location = new Point(9, 14);
        this.cboRaces.Margin = new Padding(0, 5, 3, 0);
        this.cboRaces.Name = "cboRaces";
        this.cboRaces.Size = new Size(213, 21);
        this.cboRaces.TabIndex = 63 /*0x3F*/;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(1086, 762);
        this.Controls.Add(this.cboRaces);
        this.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.Name = nameof(ManageNPRTemplates);
        this.Text = "Manage NPR Templates";
        this.ResumeLayout(false);
    }
}