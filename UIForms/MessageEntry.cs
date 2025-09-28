// Decompiled with JetBrains decompiler
// Type: MessageEntry
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class MessageEntry : Form
{
    private GClass0 gclass0_0;
    private TextBox txtInput;
    private Button cmdOK;
    private Button cmdCancel;

    public MessageEntry(GClass0 gclass0_1)
    {
        this.InitializeComponent();
        this.gclass0_0 = gclass0_1;
        this.gclass0_0.bool_21 = true;
    }

    private void MessageEntry_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2015);
        }
    }

    private void MessageEntry_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            this.Text = this.gclass0_0.string_3;
            this.txtInput.Text = this.gclass0_0.string_4;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2016);
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
            AuroraUtils.ShowExceptionPopup(ex, 2017);
        }
    }

    private void cmdOK_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass0_0.bool_21 = false;
            this.gclass0_0.string_4 = this.txtInput.Text;
            this.Close();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2018);
        }
    }

    private void method_0(object sender, FormClosingEventArgs e)
    {
    }

    private void InitializeComponent()
    {
        this.txtInput = new TextBox();
        this.cmdOK = new Button();
        this.cmdCancel = new Button();
        this.SuspendLayout();
        this.txtInput.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtInput.BorderStyle = BorderStyle.FixedSingle;
        this.txtInput.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtInput.Location = new Point(12, 24);
        this.txtInput.Name = "txtInput";
        this.txtInput.Size = new Size(300, 20);
        this.txtInput.TabIndex = 11;
        this.txtInput.Text = "Input Text";
        this.txtInput.TextAlign = HorizontalAlignment.Center;
        this.cmdOK.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdOK.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdOK.Location = new Point(57, 60);
        this.cmdOK.Margin = new Padding(0);
        this.cmdOK.Name = "cmdOK";
        this.cmdOK.Size = new Size(96 /*0x60*/, 30);
        this.cmdOK.TabIndex = 50;
        this.cmdOK.Tag = "1200";
        this.cmdOK.Text = "OK";
        this.cmdOK.UseVisualStyleBackColor = false;
        this.cmdOK.Click += this.cmdOK_Click;
        this.cmdCancel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCancel.DialogResult = DialogResult.Cancel;
        this.cmdCancel.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCancel.Location = new Point(171, 60);
        this.cmdCancel.Margin = new Padding(0);
        this.cmdCancel.Name = "cmdCancel";
        this.cmdCancel.Size = new Size(96 /*0x60*/, 30);
        this.cmdCancel.TabIndex = 51;
        this.cmdCancel.Tag = "1200";
        this.cmdCancel.Text = "Cancel";
        this.cmdCancel.UseVisualStyleBackColor = false;
        this.cmdCancel.Click += this.cmdCancel_Click;
        this.AcceptButton = this.cmdOK;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.CancelButton = this.cmdCancel;
        this.ClientSize = new Size(324, 106);
        this.Controls.Add(this.cmdCancel);
        this.Controls.Add(this.cmdOK);
        this.Controls.Add(this.txtInput);
        this.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.Name = "MessageEntry";
        this.Text = "Text Input Window";
        this.FormClosing += this.MessageEntry_FormClosing;
        this.Load += this.MessageEntry_Load;
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}