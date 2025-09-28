// Decompiled with JetBrains decompiler
// Type: ChangeLocation
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class ChangeLocation : Form
{
    private GClass0 gclass0_0;
    
    private Button cmdCancel;
    private Button cmdOK;
    private TextBox txtInput;
    private Label label38;
    private Label label1;
    private TextBox txtInputB;

    public ChangeLocation(GClass0 gclass0_1)
    {
        this.InitializeComponent();
        this.gclass0_0 = gclass0_1;
    }

    private void ChangeLocation_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 226);
        }
    }

    private void ChangeLocation_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            this.txtInput.Text = this.gclass0_0.string_4;
            this.txtInputB.Text = this.gclass0_0.string_5;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 227);
        }
    }

    private void cmdCancel_Click(object sender, EventArgs e) => this.Close();

    private void cmdOK_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass0_0.string_4 = this.txtInput.Text;
            this.gclass0_0.string_5 = this.txtInputB.Text;
            this.Close();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 228);
        }
    }

    

    private void InitializeComponent()
    {
        this.cmdCancel = new Button();
        this.cmdOK = new Button();
        this.txtInput = new TextBox();
        this.label38 = new Label();
        this.label1 = new Label();
        this.txtInputB = new TextBox();
        this.SuspendLayout();
        this.cmdCancel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCancel.DialogResult = DialogResult.Cancel;
        this.cmdCancel.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCancel.Location = new Point(134, 79);
        this.cmdCancel.Margin = new Padding(0);
        this.cmdCancel.Name = "cmdCancel";
        this.cmdCancel.Size = new Size(96 /*0x60*/, 30);
        this.cmdCancel.TabIndex = 4;
        this.cmdCancel.Tag = "1200";
        this.cmdCancel.Text = "Cancel";
        this.cmdCancel.UseVisualStyleBackColor = false;
        this.cmdCancel.Click += this.cmdCancel_Click;
        this.cmdOK.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdOK.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdOK.Location = new Point(20, 79);
        this.cmdOK.Margin = new Padding(0);
        this.cmdOK.Name = "cmdOK";
        this.cmdOK.Size = new Size(96 /*0x60*/, 30);
        this.cmdOK.TabIndex = 3;
        this.cmdOK.Tag = "1200";
        this.cmdOK.Text = "OK";
        this.cmdOK.UseVisualStyleBackColor = false;
        this.cmdOK.Click += this.cmdOK_Click;
        this.txtInput.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtInput.BorderStyle = BorderStyle.FixedSingle;
        this.txtInput.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtInput.Location = new Point(111, 15);
        this.txtInput.Name = "txtInput";
        this.txtInput.Size = new Size(119, 20);
        this.txtInput.TabIndex = 1;
        this.txtInput.Text = "Input Text";
        this.txtInput.TextAlign = HorizontalAlignment.Center;
        this.label38.AutoSize = true;
        this.label38.Location = new Point(17, 17);
        this.label38.Margin = new Padding(3);
        this.label38.Name = "label38";
        this.label38.Size = new Size(83, 13);
        this.label38.TabIndex = 104;
        this.label38.Text = "Distance (m km)";
        this.label1.AutoSize = true;
        this.label1.Location = new Point(17, 43);
        this.label1.Margin = new Padding(3);
        this.label1.Name = "label1";
        this.label1.Size = new Size(70, 13);
        this.label1.TabIndex = 106;
        this.label1.Text = "Bearing (deg)";
        this.txtInputB.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtInputB.BorderStyle = BorderStyle.FixedSingle;
        this.txtInputB.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtInputB.Location = new Point(111, 41);
        this.txtInputB.Name = "txtInputB";
        this.txtInputB.Size = new Size(119, 20);
        this.txtInputB.TabIndex = 2;
        this.txtInputB.Text = "Input Text";
        this.txtInputB.TextAlign = HorizontalAlignment.Center;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(253, 120);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.txtInputB);
        this.Controls.Add(this.label38);
        this.Controls.Add(this.cmdCancel);
        this.Controls.Add(this.cmdOK);
        this.Controls.Add(this.txtInput);
        this.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        this.Name = "ChangeLocation";
        this.Text = "Change Location";
        this.FormClosing += this.ChangeLocation_FormClosing;
        this.Load += this.ChangeLocation_Load;
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}