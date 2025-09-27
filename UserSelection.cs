// Decompiled with JetBrains decompiler
// Type: UserSelection
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class UserSelection : Form
{
    private GClass0 gclass0_0;
    private IContainer icontainer_0;
    private Button cmdCancel;
    private Button cmdOK;
    private ComboBox cboOption;
    private CheckBox chkOption;
    private CheckBox chkOption2;
    private CheckBox chkOption3;

    public UserSelection(GClass0 gclass0_1)
    {
        this.InitializeComponent();
        this.gclass0_0 = gclass0_1;
        this.gclass0_0.bool_21 = true;
    }

    private void UserSelection_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            int num = 0;
            this.Text = this.gclass0_0.string_3;
            if (this.gclass0_0.string_7 == "")
            {
                this.chkOption.Visible = false;
                num += 23;
            }
            else
                this.chkOption.Text = this.gclass0_0.string_7;

            if (this.gclass0_0.string_8 == "")
            {
                this.chkOption2.Visible = false;
                num += 23;
            }
            else
                this.chkOption2.Text = this.gclass0_0.string_8;

            if (this.gclass0_0.string_9 == "")
            {
                this.chkOption3.Visible = false;
                num += 23;
            }
            else
                this.chkOption3.Text = this.gclass0_0.string_9;

            this.Height -= num;
            this.cmdOK.Top -= num;
            this.cmdCancel.Top -= num;
            this.cboOption.DataSource = this.gclass0_0.list_32;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3182);
        }
    }

    private void cmdCancel_Click(object sender, EventArgs e) => this.Close();

    private void cmdOK_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass0_0.bool_21 = false;
            this.gclass0_0.string_4 = (string)this.cboOption.SelectedValue;
            this.gclass0_0.checkState_0 = this.chkOption.CheckState;
            this.gclass0_0.checkState_1 = this.chkOption2.CheckState;
            this.gclass0_0.checkState_2 = this.chkOption3.CheckState;
            this.Close();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3183);
        }
    }

    private void cboOption_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void UserSelection_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3184);
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
        this.cmdCancel = new Button();
        this.cmdOK = new Button();
        this.cboOption = new ComboBox();
        this.chkOption = new CheckBox();
        this.chkOption2 = new CheckBox();
        this.chkOption3 = new CheckBox();
        this.SuspendLayout();
        this.cmdCancel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCancel.DialogResult = DialogResult.Cancel;
        this.cmdCancel.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdCancel.Location = new Point(277, 119);
        this.cmdCancel.Margin = new Padding(0);
        this.cmdCancel.Name = "cmdCancel";
        this.cmdCancel.Size = new Size(96 /*0x60*/, 30);
        this.cmdCancel.TabIndex = 54;
        this.cmdCancel.Tag = "1200";
        this.cmdCancel.Text = "Cancel";
        this.cmdCancel.UseVisualStyleBackColor = false;
        this.cmdCancel.Click += this.cmdCancel_Click;
        this.cmdOK.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdOK.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdOK.Location = new Point(22, 119);
        this.cmdOK.Margin = new Padding(0);
        this.cmdOK.Name = "cmdOK";
        this.cmdOK.Size = new Size(96 /*0x60*/, 30);
        this.cmdOK.TabIndex = 53;
        this.cmdOK.Tag = "1200";
        this.cmdOK.Text = "OK";
        this.cmdOK.UseVisualStyleBackColor = false;
        this.cmdOK.Click += this.cmdOK_Click;
        this.cboOption.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboOption.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboOption.FormattingEnabled = true;
        this.cboOption.Location = new Point(22, 13);
        this.cboOption.Margin = new Padding(3, 3, 3, 0);
        this.cboOption.Name = "cboOption";
        this.cboOption.Size = new Size(351, 21);
        this.cboOption.TabIndex = 55;
        this.cboOption.SelectedIndexChanged += this.cboOption_SelectedIndexChanged;
        this.chkOption.AutoSize = true;
        this.chkOption.Location = new Point(23, 47);
        this.chkOption.Name = "chkOption";
        this.chkOption.Size = new Size(81, 17);
        this.chkOption.TabIndex = 185;
        this.chkOption.Text = "Option Text";
        this.chkOption.UseVisualStyleBackColor = true;
        this.chkOption2.AutoSize = true;
        this.chkOption2.Location = new Point(22, 70);
        this.chkOption2.Name = "chkOption2";
        this.chkOption2.Size = new Size(105, 17);
        this.chkOption2.TabIndex = 186;
        this.chkOption2.Text = "Option Two Text";
        this.chkOption2.UseVisualStyleBackColor = true;
        this.chkOption3.AutoSize = true;
        this.chkOption3.Location = new Point(23, 93);
        this.chkOption3.Name = "chkOption3";
        this.chkOption3.Size = new Size(112 /*0x70*/, 17);
        this.chkOption3.TabIndex = 187;
        this.chkOption3.Text = "Option Three Text";
        this.chkOption3.UseVisualStyleBackColor = true;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(391, 159);
        this.Controls.Add(this.chkOption3);
        this.Controls.Add(this.chkOption2);
        this.Controls.Add(this.chkOption);
        this.Controls.Add(this.cboOption);
        this.Controls.Add(this.cmdCancel);
        this.Controls.Add(this.cmdOK);
        this.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.Name = nameof(UserSelection);
        this.Text = "Select Option";
        this.FormClosing += this.UserSelection_FormClosing;
        this.Load += this.UserSelection_Load;
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}