// Decompiled with JetBrains decompiler
// Type: AddMoons
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class AddMoons : Form
{
    private GClass0 gclass0_0;
    private SystemBodyData gclass1_0;
    private IContainer icontainer_0;
    private ComboBox cboMoonType1;
    private Label lblDistance;
    private Button cmdCancel;
    private Button cmdOK;
    private FlowLayoutPanel flowLayoutPanel1;
    private ComboBox cboMoonType2;
    private ComboBox cboMoonType3;
    private ComboBox cboMoonType4;
    private ComboBox cboMoonType5;
    private FlowLayoutPanel flowLayoutPanel3;
    private TextBox txtDistance1;
    private Label label1;
    private TextBox txtDistance2;
    private TextBox txtDistance3;
    private TextBox txtDistance4;
    private TextBox txtDistance5;
    private FlowLayoutPanel flowLayoutPanel2;

    public AddMoons(GClass0 gclass0_1, SystemBodyData gclass1_1)
    {
        this.InitializeComponent();
        this.gclass0_0 = gclass0_1;
        this.gclass1_0 = gclass1_1;
    }

    private void AddMoons_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            List<string> stringList1 = new List<string>();
            List<string> stringList2 = new List<string>();
            List<string> stringList3 = new List<string>();
            List<string> stringList4 = new List<string>();
            List<string> stringList5 = new List<string>();
            stringList1.Add(AuroraUtils.smethod_82(AuroraSystemBodyType.None));
            stringList1.Add(AuroraUtils.smethod_82(AuroraSystemBodyType.SmallMoon));
            stringList1.Add(AuroraUtils.smethod_82(AuroraSystemBodyType.Moon));
            stringList1.Add(AuroraUtils.smethod_82(AuroraSystemBodyType.LargeMoon));
            stringList1.Add(AuroraUtils.smethod_82(AuroraSystemBodyType.SmallTerrestrial));
            stringList1.Add(AuroraUtils.smethod_82(AuroraSystemBodyType.TerrestrialMoon));
            foreach (string str in stringList1)
            {
                stringList2.Add(str);
                stringList3.Add(str);
                stringList4.Add(str);
                stringList5.Add(str);
            }

            double num1 = 4.0 * Math.Pow(this.gclass1_0.StarData.Luminosity, 0.5);
            double num2 = 50.0 * Math.Pow(this.gclass1_0.StarData.Luminosity, 0.5);
            double num3 = 0.75 * Math.Pow(this.gclass1_0.StarData.Luminosity, 0.5);
            Math.Pow(this.gclass1_0.StarData.Luminosity, 0.5);
            double num4 = 1.4 * Math.Pow(this.gclass1_0.StarData.Luminosity, 0.5);
            this.gclass1_0.genum4_0 = this.gclass1_0.OrbitalDistance > num1
                ? (this.gclass1_0.OrbitalDistance > num2 ? GEnum4.const_2 : GEnum4.const_1)
                : GEnum4.const_0;
            this.gclass1_0.bool_4 = this.gclass1_0.OrbitalDistance >= num3 && this.gclass1_0.OrbitalDistance <= num4;
            this.cboMoonType1.DataSource = stringList1;
            this.cboMoonType2.DataSource = stringList2;
            this.cboMoonType3.DataSource = stringList3;
            this.cboMoonType4.DataSource = stringList4;
            this.cboMoonType5.DataSource = stringList5;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 182);
        }
    }

    private void method_0(AuroraSystemBodyType auroraSystemBodyType_0, double double_0)
    {
        try
        {
            if (auroraSystemBodyType_0 == AuroraSystemBodyType.None)
                return;
            if (double_0 <= 0.0)
                double_0 = 10000.0;
            this.gclass0_0.method_654(this.gclass1_0, auroraSystemBodyType_0, double_0 * 1000.0, false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 183);
        }
    }

    private void cmdOK_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_0(
                Enum.GetValues(typeof(AuroraSystemBodyType)).Cast<AuroraSystemBodyType>()
                    .FirstOrDefault<AuroraSystemBodyType>(auroraSystemBodyType_0 =>
                        AuroraUtils.smethod_82(auroraSystemBodyType_0) == (string)this.cboMoonType1.SelectedValue),
                Convert.ToDouble(this.txtDistance1.Text));
            this.method_0(
                Enum.GetValues(typeof(AuroraSystemBodyType)).Cast<AuroraSystemBodyType>()
                    .FirstOrDefault<AuroraSystemBodyType>(auroraSystemBodyType_0 =>
                        AuroraUtils.smethod_82(auroraSystemBodyType_0) == (string)this.cboMoonType2.SelectedValue),
                Convert.ToDouble(this.txtDistance2.Text));
            this.method_0(
                Enum.GetValues(typeof(AuroraSystemBodyType)).Cast<AuroraSystemBodyType>()
                    .FirstOrDefault<AuroraSystemBodyType>(auroraSystemBodyType_0 =>
                        AuroraUtils.smethod_82(auroraSystemBodyType_0) == (string)this.cboMoonType3.SelectedValue),
                Convert.ToDouble(this.txtDistance3.Text));
            this.method_0(
                Enum.GetValues(typeof(AuroraSystemBodyType)).Cast<AuroraSystemBodyType>()
                    .FirstOrDefault<AuroraSystemBodyType>(auroraSystemBodyType_0 =>
                        AuroraUtils.smethod_82(auroraSystemBodyType_0) == (string)this.cboMoonType4.SelectedValue),
                Convert.ToDouble(this.txtDistance4.Text));
            this.method_0(
                Enum.GetValues(typeof(AuroraSystemBodyType)).Cast<AuroraSystemBodyType>()
                    .FirstOrDefault<AuroraSystemBodyType>(auroraSystemBodyType_0 =>
                        AuroraUtils.smethod_82(auroraSystemBodyType_0) == (string)this.cboMoonType5.SelectedValue),
                Convert.ToDouble(this.txtDistance5.Text));
            this.gclass0_0.bool_21 = false;
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
            this.Close();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 184);
        }
    }

    private void cmdCancel_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
            this.Close();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 185);
        }
    }

    private void AddMoons_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 186);
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
        this.cboMoonType1 = new ComboBox();
        this.lblDistance = new Label();
        this.cmdCancel = new Button();
        this.cmdOK = new Button();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.cboMoonType2 = new ComboBox();
        this.cboMoonType3 = new ComboBox();
        this.cboMoonType4 = new ComboBox();
        this.cboMoonType5 = new ComboBox();
        this.flowLayoutPanel3 = new FlowLayoutPanel();
        this.label1 = new Label();
        this.txtDistance1 = new TextBox();
        this.txtDistance2 = new TextBox();
        this.txtDistance3 = new TextBox();
        this.txtDistance4 = new TextBox();
        this.txtDistance5 = new TextBox();
        this.flowLayoutPanel2 = new FlowLayoutPanel();
        this.flowLayoutPanel1.SuspendLayout();
        this.flowLayoutPanel3.SuspendLayout();
        this.flowLayoutPanel2.SuspendLayout();
        this.SuspendLayout();
        this.cboMoonType1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboMoonType1.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboMoonType1.FormattingEnabled = true;
        this.cboMoonType1.Location = new Point(3, 23);
        this.cboMoonType1.Margin = new Padding(3, 6, 3, 6);
        this.cboMoonType1.Name = "cboMoonType1";
        this.cboMoonType1.Size = new Size(145, 21);
        this.cboMoonType1.TabIndex = 1;
        this.lblDistance.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lblDistance.Location = new Point(3, 2);
        this.lblDistance.Margin = new Padding(3, 2, 3, 2);
        this.lblDistance.Name = "lblDistance";
        this.lblDistance.Size = new Size(145, 13);
        this.lblDistance.TabIndex = 106;
        this.lblDistance.Text = "Moon Type";
        this.lblDistance.TextAlign = ContentAlignment.MiddleCenter;
        this.cmdCancel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCancel.DialogResult = DialogResult.Cancel;
        this.cmdCancel.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCancel.Location = new Point(155, 175);
        this.cmdCancel.Margin = new Padding(0);
        this.cmdCancel.Name = "cmdCancel";
        this.cmdCancel.Size = new Size(96 /*0x60*/, 30);
        this.cmdCancel.TabIndex = 12;
        this.cmdCancel.Tag = "1200";
        this.cmdCancel.Text = "Cancel";
        this.cmdCancel.UseVisualStyleBackColor = false;
        this.cmdCancel.Click += this.cmdCancel_Click;
        this.cmdOK.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdOK.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdOK.Location = new Point(3, 175);
        this.cmdOK.Margin = new Padding(0);
        this.cmdOK.Name = "cmdOK";
        this.cmdOK.Size = new Size(96 /*0x60*/, 30);
        this.cmdOK.TabIndex = 11;
        this.cmdOK.Tag = "1200";
        this.cmdOK.Text = "OK";
        this.cmdOK.UseVisualStyleBackColor = false;
        this.cmdOK.Click += this.cmdOK_Click;
        this.flowLayoutPanel1.Controls.Add(this.lblDistance);
        this.flowLayoutPanel1.Controls.Add(this.cboMoonType1);
        this.flowLayoutPanel1.Controls.Add(this.cboMoonType2);
        this.flowLayoutPanel1.Controls.Add(this.cboMoonType3);
        this.flowLayoutPanel1.Controls.Add(this.cboMoonType4);
        this.flowLayoutPanel1.Controls.Add(this.cboMoonType5);
        this.flowLayoutPanel1.Location = new Point(3, 3);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(153, 160 /*0xA0*/);
        this.flowLayoutPanel1.TabIndex = 160 /*0xA0*/;
        this.cboMoonType2.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboMoonType2.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboMoonType2.FormattingEnabled = true;
        this.cboMoonType2.Location = new Point(3, 53);
        this.cboMoonType2.Name = "cboMoonType2";
        this.cboMoonType2.Size = new Size(145, 21);
        this.cboMoonType2.TabIndex = 3;
        this.cboMoonType3.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboMoonType3.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboMoonType3.FormattingEnabled = true;
        this.cboMoonType3.Location = new Point(3, 80 /*0x50*/);
        this.cboMoonType3.Name = "cboMoonType3";
        this.cboMoonType3.Size = new Size(145, 21);
        this.cboMoonType3.TabIndex = 5;
        this.cboMoonType4.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboMoonType4.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboMoonType4.FormattingEnabled = true;
        this.cboMoonType4.Location = new Point(3, 107);
        this.cboMoonType4.Name = "cboMoonType4";
        this.cboMoonType4.Size = new Size(145, 21);
        this.cboMoonType4.TabIndex = 7;
        this.cboMoonType5.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboMoonType5.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboMoonType5.FormattingEnabled = true;
        this.cboMoonType5.Location = new Point(3, 134);
        this.cboMoonType5.Name = "cboMoonType5";
        this.cboMoonType5.Size = new Size(145, 21);
        this.cboMoonType5.TabIndex = 9;
        this.flowLayoutPanel3.Controls.Add(this.label1);
        this.flowLayoutPanel3.Controls.Add(this.txtDistance1);
        this.flowLayoutPanel3.Controls.Add(this.txtDistance2);
        this.flowLayoutPanel3.Controls.Add(this.txtDistance3);
        this.flowLayoutPanel3.Controls.Add(this.txtDistance4);
        this.flowLayoutPanel3.Controls.Add(this.txtDistance5);
        this.flowLayoutPanel3.Location = new Point(159, 3);
        this.flowLayoutPanel3.Margin = new Padding(0, 3, 3, 3);
        this.flowLayoutPanel3.Name = "flowLayoutPanel3";
        this.flowLayoutPanel3.Size = new Size(83, 160 /*0xA0*/);
        this.flowLayoutPanel3.TabIndex = 161;
        this.label1.AutoSize = true;
        this.label1.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.label1.Location = new Point(3, 2);
        this.label1.Margin = new Padding(3, 2, 3, 2);
        this.label1.Name = "label1";
        this.label1.Size = new Size(75, 13);
        this.label1.TabIndex = 111;
        this.label1.Text = "Distance k km";
        this.txtDistance1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDistance1.BorderStyle = BorderStyle.None;
        this.txtDistance1.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtDistance1.Location = new Point(0, 27);
        this.txtDistance1.Margin = new Padding(0, 10, 3, 3);
        this.txtDistance1.Name = "txtDistance1";
        this.txtDistance1.Size = new Size(83, 13);
        this.txtDistance1.TabIndex = 2;
        this.txtDistance1.Text = "100";
        this.txtDistance1.TextAlign = HorizontalAlignment.Center;
        this.txtDistance2.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDistance2.BorderStyle = BorderStyle.None;
        this.txtDistance2.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtDistance2.Location = new Point(0, 55);
        this.txtDistance2.Margin = new Padding(0, 12, 3, 3);
        this.txtDistance2.Name = "txtDistance2";
        this.txtDistance2.Size = new Size(83, 13);
        this.txtDistance2.TabIndex = 4;
        this.txtDistance2.Text = "200";
        this.txtDistance2.TextAlign = HorizontalAlignment.Center;
        this.txtDistance3.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDistance3.BorderStyle = BorderStyle.None;
        this.txtDistance3.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtDistance3.Location = new Point(0, 83);
        this.txtDistance3.Margin = new Padding(0, 12, 3, 3);
        this.txtDistance3.Name = "txtDistance3";
        this.txtDistance3.Size = new Size(83, 13);
        this.txtDistance3.TabIndex = 6;
        this.txtDistance3.Text = "300";
        this.txtDistance3.TextAlign = HorizontalAlignment.Center;
        this.txtDistance4.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDistance4.BorderStyle = BorderStyle.None;
        this.txtDistance4.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtDistance4.Location = new Point(0, 111);
        this.txtDistance4.Margin = new Padding(0, 12, 3, 3);
        this.txtDistance4.Name = "txtDistance4";
        this.txtDistance4.Size = new Size(83, 13);
        this.txtDistance4.TabIndex = 8;
        this.txtDistance4.Text = "400";
        this.txtDistance4.TextAlign = HorizontalAlignment.Center;
        this.txtDistance5.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDistance5.BorderStyle = BorderStyle.None;
        this.txtDistance5.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtDistance5.Location = new Point(0, 139);
        this.txtDistance5.Margin = new Padding(0, 12, 3, 3);
        this.txtDistance5.Name = "txtDistance5";
        this.txtDistance5.Size = new Size(83, 13);
        this.txtDistance5.TabIndex = 10;
        this.txtDistance5.Text = "500";
        this.txtDistance5.TextAlign = HorizontalAlignment.Center;
        this.flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
        this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
        this.flowLayoutPanel2.Location = new Point(3, 3);
        this.flowLayoutPanel2.Name = "flowLayoutPanel2";
        this.flowLayoutPanel2.Size = new Size(248, 169);
        this.flowLayoutPanel2.TabIndex = 162;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(254, 208 /*0xD0*/);
        this.Controls.Add(this.flowLayoutPanel2);
        this.Controls.Add(this.cmdCancel);
        this.Controls.Add(this.cmdOK);
        this.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.Name = "AddMoons";
        this.Text = "Add Moons";
        this.FormClosing += this.AddMoons_FormClosing;
        this.Load += this.AddMoons_Load;
        this.flowLayoutPanel1.ResumeLayout(false);
        this.flowLayoutPanel3.ResumeLayout(false);
        this.flowLayoutPanel3.PerformLayout();
        this.flowLayoutPanel2.ResumeLayout(false);
        this.ResumeLayout(false);
    }
}