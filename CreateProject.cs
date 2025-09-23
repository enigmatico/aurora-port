// Decompiled with JetBrains decompiler
// Type: CreateProject
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
public class CreateProject : Form
{
  private GClass0 gclass0_0;
  private GClass21 gclass21_0;
  private GClass169 gclass169_0;
  private bool bool_0;
  private bool bool_1;
  private IContainer icontainer_0;
  private ComboBox cboRaces;
  private FlowLayoutPanel flowLayoutPanel1;
  private ComboBox cboTech0;
  private ComboBox cboTech1;
  private ComboBox cboTech2;
  private ComboBox cboTech3;
  private ComboBox cboTech4;
  private ComboBox cboTech5;
  private ComboBox cboTech6;
  private ComboBox cboTech7;
  private ComboBox cboRC;
  private Label lblNotes;
  private Button cmdCreate;
  private Button cmdInstant;
  private Button cmdCompanyName;
  private TextBox txtCompanyName;
  private TextBox txtProjectName;
  private Button cmdMissileDesign;
  private Button cmdTurretDesign;
  private TextBox txtDetails;
  private Button cmdGU;
  private CheckBox chkNoNameUpdate;
  private FlowLayoutPanel flpEntry1;
  private Label lblEntry1;
  private TextBox txtEntry1;
  private FlowLayoutPanel flpEntry2;
  private Label lblEntry2;
  private TextBox txtEntry2;
  private Button cmdPrototype;
  private FlowLayoutPanel flowLayoutPanel2;
  private CheckBox chkNextTech;
  private FlowLayoutPanel flpSizeOptions;
  private Label lblRadioInfo;
  private RadioButton rdo10;
  private RadioButton rdo100;
  private RadioButton rdo1000;
  private RadioButton rdo10000;

  public CreateProject(GClass0 gclass0_1)
  {
    this.gclass0_0 = gclass0_1;
    this.InitializeComponent();
  }

  private void CreateProject_FormClosing(object sender, FormClosingEventArgs e)
  {
    try
    {
      this.gclass0_0.method_512(this.Name, this.Left, this.Top);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1041);
    }
  }

  private void CreateProject_Load(object sender, EventArgs e)
  {
    try
    {
      GClass207 gclass207 = this.gclass0_0.method_513(this.Name);
      this.Left = gclass207.int_0;
      this.Top = gclass207.int_1;
      this.gclass0_0.bool_9 = true;
      this.bool_0 = true;
      if (!this.gclass0_0.bool_8)
        this.cmdInstant.Visible = false;
      else
        this.cmdInstant.Visible = true;
      this.gclass0_0.method_577(this.cboRaces);
      this.method_1(this.cboRC);
      this.gclass0_0.bool_9 = false;
      this.method_2();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1042);
    }
  }

  public void method_0(GClass21 gclass21_1)
  {
    try
    {
      this.bool_0 = true;
      this.cboRaces.SelectedItem = (object) gclass21_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1043);
    }
  }

  private void cboRaces_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      this.gclass21_0 = (GClass21) this.cboRaces.SelectedValue;
      this.method_2();
      if (!this.bool_0)
        this.gclass0_0.method_511(this.gclass21_0, (object) this);
      this.bool_0 = false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1044);
    }
  }

  public void method_1(ComboBox comboBox_0)
  {
    try
    {
      List<GClass169> list = this.gclass0_0.dictionary_64.Values.Where<GClass169>((Func<GClass169, bool>) (gclass169_0 => gclass169_0.bool_0)).OrderBy<GClass169, string>((Func<GClass169, string>) (gclass169_0 => gclass169_0.CategoryName)).ToList<GClass169>();
      comboBox_0.DisplayMember = "CategoryName";
      comboBox_0.DataSource = (object) list;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1045);
    }
  }

  private void cboRC_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass0_0.bool_9)
        return;
      this.method_2();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1046);
    }
  }

  private void method_2()
  {
    try
    {
      this.bool_1 = true;
      int int_136 = 0;
      GClass169 selectedItem = (GClass169) this.cboRC.SelectedItem;
      if (selectedItem == null)
        return;
      if (selectedItem.genum119_0 == GEnum119.const_28)
        this.cmdPrototype.Visible = false;
      else
        this.cmdPrototype.Visible = true;
      if (selectedItem.int_9 > 0)
      {
        int_136 = selectedItem.int_9;
        this.flpSizeOptions.Visible = true;
        if (selectedItem.int_9 == 10)
          this.rdo10.Checked = true;
        else if (selectedItem.int_9 == 100)
          this.rdo100.Checked = true;
        else if (selectedItem.int_9 == 1000)
          this.rdo1000.Checked = true;
        else if (selectedItem.int_9 == 10000)
          this.rdo10000.Checked = true;
      }
      else
        this.flpSizeOptions.Visible = false;
      this.cmdCreate.Enabled = true;
      if (selectedItem != null)
      {
        this.gclass0_0.method_477(this.gclass21_0, selectedItem, this.cboTech0, this.cboTech1, this.cboTech2, this.cboTech3, this.cboTech4, this.cboTech5, this.cboTech6, this.cboTech7, this.lblNotes, this.chkNextTech.CheckState, int_136);
        this.method_3(selectedItem);
      }
      else
        this.txtProjectName.Text = "";
      this.bool_1 = false;
      this.method_5();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1047);
    }
  }

  private void method_3(GClass169 gclass169_1)
  {
    try
    {
      if (gclass169_1.genum122_0 != GEnum122.const_0 && this.cboTech0.Items.Count == 0)
        this.cmdCreate.Enabled = false;
      if (gclass169_1.genum122_1 != GEnum122.const_0 && this.cboTech1.Items.Count == 0)
        this.cmdCreate.Enabled = false;
      if (gclass169_1.genum122_2 != GEnum122.const_0 && this.cboTech2.Items.Count == 0)
        this.cmdCreate.Enabled = false;
      if (gclass169_1.genum122_3 != GEnum122.const_0 && this.cboTech3.Items.Count == 0)
        this.cmdCreate.Enabled = false;
      if (gclass169_1.genum122_4 != GEnum122.const_0 && this.cboTech4.Items.Count == 0)
        this.cmdCreate.Enabled = false;
      if (gclass169_1.genum122_5 != GEnum122.const_0 && this.cboTech5.Items.Count == 0)
        this.cmdCreate.Enabled = false;
      if (gclass169_1.genum122_6 != GEnum122.const_0 && this.cboTech6.Items.Count == 0)
        this.cmdCreate.Enabled = false;
      if (gclass169_1.genum122_7 == GEnum122.const_0 || this.cboTech7.Items.Count != 0)
        return;
      this.cmdCreate.Enabled = false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3768);
    }
  }

  private void cboTech7_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      this.method_4();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1048);
    }
  }

  private void method_4()
  {
    try
    {
      if (this.gclass0_0.bool_9 || this.bool_1)
        return;
      this.method_5();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1049);
    }
  }

  private void method_5()
  {
    try
    {
      if (!this.method_6())
        return;
      this.gclass169_0 = (GClass169) this.cboRC.SelectedValue;
      this.gclass0_0.gclass194_0 = (GClass194) null;
      string text = this.txtProjectName.Text;
      if (this.gclass169_0.genum119_0 == GEnum119.const_30)
        this.gclass0_0.method_447(this.gclass21_0, (GClass170) this.cboTech0.SelectedItem, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_1)
        this.gclass0_0.method_473(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech1.SelectedItem, (GClass164) this.cboTech2.SelectedItem, (GClass164) this.cboTech3.SelectedItem, (GClass164) this.cboTech4.SelectedItem, false, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_17)
        this.gclass0_0.method_471(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech1.SelectedItem, (GClass164) this.cboTech2.SelectedItem, (int) ((GClass170) this.cboTech3.SelectedItem).decimal_0, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_18)
        this.gclass0_0.method_470(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech1.SelectedItem, (GClass164) this.cboTech2.SelectedItem, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_16)
        this.gclass0_0.method_468(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech1.SelectedItem, (GClass164) this.cboTech3.SelectedItem, (GClass164) this.cboTech2.SelectedItem, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_23)
        this.gclass0_0.method_462(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech1.SelectedItem, (GClass164) this.cboTech2.SelectedItem, false, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_15)
        this.gclass0_0.method_467(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech1.SelectedItem, (GClass164) this.cboTech2.SelectedItem, (GClass164) this.cboTech3.SelectedItem, (GClass164) this.cboTech4.SelectedItem, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_24)
        this.gclass0_0.method_466(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech1.SelectedItem, (GClass164) this.cboTech2.SelectedItem, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_31)
        this.gclass0_0.method_446(this.gclass21_0, (GClass170) this.cboTech0.SelectedItem, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_27)
      {
        if (this.cboTech5.Visible)
          this.gclass0_0.method_460(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech1.SelectedItem, (GClass164) this.cboTech2.SelectedItem, (GClass164) this.cboTech3.SelectedItem, (GClass164) this.cboTech4.SelectedItem, (GClass164) this.cboTech5.SelectedItem, this.txtDetails, this.txtProjectName, false);
        else
          this.gclass0_0.method_460(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech1.SelectedItem, (GClass164) this.cboTech2.SelectedItem, (GClass164) this.cboTech3.SelectedItem, (GClass164) this.cboTech4.SelectedItem, (GClass164) null, this.txtDetails, this.txtProjectName, false);
      }
      if (this.gclass169_0.genum119_0 == GEnum119.const_10)
        this.gclass0_0.method_465(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech2.SelectedItem, ((GClass170) this.cboTech1.SelectedItem).decimal_0, GEnum32.const_0, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_22)
        this.gclass0_0.method_465(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech2.SelectedItem, ((GClass170) this.cboTech1.SelectedItem).decimal_0, GEnum32.const_1, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_9)
        this.gclass0_0.method_464(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech1.SelectedItem, (GClass164) this.cboTech4.SelectedItem, (GClass164) this.cboTech5.SelectedItem, GEnum33.const_0, ((GClass170) this.cboTech2.SelectedItem).decimal_0, (double) (int) ((GClass170) this.cboTech3.SelectedItem).decimal_0, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_14)
        this.gclass0_0.method_464(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech1.SelectedItem, (GClass164) this.cboTech4.SelectedItem, (GClass164) this.cboTech5.SelectedItem, GEnum33.const_1, ((GClass170) this.cboTech2.SelectedItem).decimal_0, (double) (int) ((GClass170) this.cboTech3.SelectedItem).decimal_0, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_13)
        this.gclass0_0.method_463(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech1.SelectedItem, ((GClass170) this.cboTech2.SelectedItem).decimal_0, ((GClass170) this.cboTech3.SelectedItem).decimal_0, (GClass164) this.cboTech4.SelectedItem, (GClass164) this.cboTech6.SelectedItem, (GClass164) this.cboTech5.SelectedItem, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_4)
        this.gclass0_0.method_459(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech1.SelectedItem, ((GClass170) this.cboTech2.SelectedItem).decimal_0, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_26)
        this.gclass0_0.method_458(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech1.SelectedItem, (GClass164) this.cboTech2.SelectedItem, (int) ((GClass170) this.cboTech3.SelectedItem).decimal_0, (int) ((GClass170) this.cboTech4.SelectedItem).decimal_0, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_5)
        this.gclass0_0.method_457(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech2.SelectedItem, (GClass164) this.cboTech3.SelectedItem, ((GClass170) this.cboTech1.SelectedItem).decimal_0, ((GClass170) this.cboTech4.SelectedItem).decimal_0, this.txtDetails, this.txtProjectName, (GClass187) null, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_12)
      {
        Decimal decimal_13 = ((GClass170) this.cboTech3.SelectedItem).decimal_0 / GClass226.decimal_17;
        if (((GClass164) this.cboTech4.SelectedItem).decimal_0 == 1M)
          decimal_13 /= (Decimal) GClass226.int_36;
        this.gclass0_0.method_456(this.gclass21_0, decimal_13, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech1.SelectedItem, (GClass164) this.cboTech2.SelectedItem, (GClass164) this.cboTech4.SelectedItem, this.txtDetails, this.txtProjectName, false);
      }
      if (this.gclass169_0.genum119_0 == GEnum119.const_8)
        this.gclass0_0.method_455(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech1.SelectedItem, ((GClass170) this.cboTech2.SelectedItem).decimal_0, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_29)
        this.gclass0_0.method_454(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech2.SelectedItem, ((GClass170) this.cboTech1.SelectedItem).decimal_0, ((GClass170) this.cboTech3.SelectedItem).decimal_0, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_2)
        this.gclass0_0.method_453(this.gclass21_0, (GClass164) this.cboTech1.SelectedItem, (GClass164) this.cboTech2.SelectedItem, ((GClass170) this.cboTech0.SelectedItem).decimal_0, this.txtDetails, this.txtProjectName, AuroraComponentType.MissileLauncher, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_32)
        this.gclass0_0.method_453(this.gclass21_0, (GClass164) null, (GClass164) null, ((GClass170) this.cboTech0.SelectedItem).decimal_0, this.txtDetails, this.txtProjectName, AuroraComponentType.DecoyMissileLauncher, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_25)
        this.gclass0_0.method_451(this.gclass21_0, (GClass164) this.cboTech0.SelectedItem, (GClass164) this.cboTech1.SelectedItem, ((GClass170) this.cboTech2.SelectedItem).decimal_0, this.txtDetails, this.txtProjectName, false);
      if (this.gclass169_0.genum119_0 == GEnum119.const_28)
        this.gclass0_0.method_452(this.gclass21_0, (GClass164) this.cboTech1.SelectedItem, (GClass164) this.cboTech2.SelectedItem, (GClass164) this.cboTech3.SelectedItem, (GClass164) this.cboTech4.SelectedItem, (GClass194) this.cboTech0.SelectedItem, this.txtDetails, this.txtProjectName, false);
      if (!this.chkNoNameUpdate.Checked)
        return;
      this.txtProjectName.Text = text;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1050);
    }
  }

  private void cmdCreate_Click(object sender, EventArgs e)
  {
    try
    {
      this.gclass0_0.gclass164_0.Name = this.txtProjectName.Text;
      if (this.txtCompanyName.Text != "")
        this.gclass0_0.gclass164_0.Name = $"{this.txtCompanyName.Text} {this.gclass0_0.gclass164_0.Name}";
      this.gclass0_0.dictionary_50.Add(this.gclass0_0.gclass164_0.int_0, this.gclass0_0.gclass164_0);
      if (this.gclass0_0.gclass194_0 != null)
      {
        this.gclass0_0.gclass194_0.SpeciesName = this.gclass0_0.gclass164_0.Name;
        this.gclass0_0.dictionary_37.Add(this.gclass0_0.gclass194_0.int_0, this.gclass0_0.gclass194_0);
      }
      else
      {
        this.gclass0_0.gclass230_0.Name = this.gclass0_0.gclass164_0.Name;
        this.gclass0_0.dictionary_54.Add(this.gclass0_0.gclass230_0.int_0, this.gclass0_0.gclass230_0);
      }
      int num = (int) MessageBox.Show("Project created. Research the new project on the Research tab of the economics window");
      this.method_4();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1051);
    }
  }

  private bool method_6()
  {
    try
    {
      if (this.cboTech0.Visible && this.cboTech0.Items.Count == 0)
      {
        this.txtDetails.Text = "Cannot design component without all required technology";
        return false;
      }
      if (this.cboTech1.Visible && this.cboTech1.Items.Count == 0)
      {
        this.txtDetails.Text = "Cannot design component without all required technology";
        return false;
      }
      if (this.cboTech2.Visible && this.cboTech2.Items.Count == 0)
      {
        this.txtDetails.Text = "Cannot design component without all required technology";
        return false;
      }
      if (this.cboTech3.Visible && this.cboTech3.Items.Count == 0)
      {
        this.txtDetails.Text = "Cannot design component without all required technology";
        return false;
      }
      if (this.cboTech4.Visible && this.cboTech4.Items.Count == 0)
      {
        this.txtDetails.Text = "Cannot design component without all required technology";
        return false;
      }
      if (this.cboTech5.Visible && this.cboTech5.Items.Count == 0)
      {
        this.txtDetails.Text = "Cannot design component without all required technology";
        return false;
      }
      if (this.cboTech6.Visible && this.cboTech6.Items.Count == 0)
      {
        this.txtDetails.Text = "Cannot design component without all required technology";
        return false;
      }
      if (this.cboTech7.Visible && this.cboTech7.Items.Count == 0)
      {
        this.txtDetails.Text = "Cannot design component without all required technology";
        return false;
      }
      this.txtDetails.Text = "";
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1052);
      return false;
    }
  }

  private void cmdCompanyName_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass21_0 == null || this.gclass169_0 == null)
        return;
      this.txtCompanyName.Text = this.gclass0_0.method_479(this.gclass21_0, this.gclass169_0.int_8);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1053);
    }
  }

  private void cmdMissileDesign_Click(object sender, EventArgs e)
  {
    try
    {
      new MissileDesign(this.gclass0_0).Show();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1054);
    }
  }

  private void cmdInstant_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass21_0 == null)
      {
        int num1 = (int) MessageBox.Show("Please select a race");
      }
      else
      {
        this.gclass0_0.gclass164_0.Name = !(this.txtCompanyName.Text != "") ? this.txtProjectName.Text : $"{this.txtCompanyName.Text} {this.txtProjectName.Text}";
        this.gclass0_0.dictionary_50.Add(this.gclass0_0.gclass164_0.int_0, this.gclass0_0.gclass164_0);
        if (this.gclass0_0.gclass194_0 != null)
        {
          this.gclass0_0.gclass194_0.SpeciesName = this.gclass0_0.gclass164_0.Name;
          this.gclass0_0.dictionary_37.Add(this.gclass0_0.gclass194_0.int_0, this.gclass0_0.gclass194_0);
        }
        else
        {
          this.gclass0_0.gclass230_0.Name = this.gclass0_0.gclass164_0.Name;
          this.gclass0_0.dictionary_54.Add(this.gclass0_0.gclass230_0.int_0, this.gclass0_0.gclass230_0);
        }
        this.gclass21_0.method_282(this.gclass0_0.gclass164_0, (GClass55) null, (GClass146) null, (GClass21) null, false, false);
        this.method_4();
        int num2 = (int) MessageBox.Show("Project has been created and automatically researched");
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1055);
    }
  }

  private void txtProjectName_Leave(object sender, EventArgs e)
  {
  }

  private void cmdTurretDesign_Click(object sender, EventArgs e)
  {
    try
    {
      new TurretDesign(this.gclass0_0).Show();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1056);
    }
  }

  private void cmdGU_Click(object sender, EventArgs e)
  {
    try
    {
      new GroundUnitDesign(this.gclass0_0).Show();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1057);
    }
  }

  private void txtProjectName_TextChanged(object sender, EventArgs e)
  {
  }

  private void cmdPrototype_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass21_0 == null)
      {
        int num1 = (int) MessageBox.Show("Please select a race");
      }
      else
      {
        this.gclass0_0.gclass164_0.Name = !(this.txtCompanyName.Text != "") ? this.txtProjectName.Text : $"{this.txtCompanyName.Text} {this.txtProjectName.Text}";
        this.gclass0_0.dictionary_50.Add(this.gclass0_0.gclass164_0.int_0, this.gclass0_0.gclass164_0);
        if (this.gclass0_0.gclass194_0 != null)
        {
          this.gclass0_0.gclass194_0.SpeciesName = this.gclass0_0.gclass164_0.Name;
          this.gclass0_0.dictionary_37.Add(this.gclass0_0.gclass194_0.int_0, this.gclass0_0.gclass194_0);
        }
        else
        {
          this.gclass0_0.gclass230_0.Name = this.gclass0_0.gclass164_0.Name;
          this.gclass0_0.gclass230_0.genum86_0 = this.chkNextTech.CheckState != CheckState.Checked ? GEnum86.const_1 : GEnum86.const_2;
          this.gclass0_0.dictionary_54.Add(this.gclass0_0.gclass230_0.int_0, this.gclass0_0.gclass230_0);
        }
        this.gclass21_0.method_282(this.gclass0_0.gclass164_0, (GClass55) null, (GClass146) null, (GClass21) null, false, false);
        this.method_4();
        if (this.chkNextTech.CheckState == CheckState.Checked)
        {
          int num2 = (int) MessageBox.Show("The future prototype component has been created and is available for class design. A shipyard cannot be retooled for a class design that contains any type of prototype component");
        }
        else
        {
          int num3 = (int) MessageBox.Show("The prototype component has been created and is available for class design. A shipyard cannot be retooled for a class design that contains a prototype component");
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1058);
    }
  }

  private void chkNextTech_CheckedChanged(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass0_0.bool_9)
        return;
      if (this.chkNextTech.CheckState == CheckState.Checked)
        this.cmdCreate.Visible = false;
      else
        this.cmdCreate.Visible = true;
      this.method_2();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1059);
    }
  }

  private void CreateProject_Activated(object sender, EventArgs e)
  {
  }

  private void CreateProject_KeyDown(object sender, KeyEventArgs e)
  {
    try
    {
      if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F4)
      {
        this.Close();
      }
      else
      {
        if (this.gclass21_0 == null)
          return;
        this.gclass21_0.method_174(e, this.gclass0_0.tacticalMap_0.gclass202_0);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3276);
    }
  }

  private void rdo10000_CheckedChanged(object sender, EventArgs e)
  {
    try
    {
      this.bool_1 = true;
      int int_136 = 0;
      GClass169 selectedItem = (GClass169) this.cboRC.SelectedItem;
      if (selectedItem == null)
        return;
      if (this.rdo10.Checked)
        int_136 = 10;
      else if (this.rdo100.Checked)
        int_136 = 100;
      else if (this.rdo1000.Checked)
        int_136 = 1000;
      else if (this.rdo10000.Checked)
        int_136 = 10000;
      this.gclass0_0.method_477(this.gclass21_0, selectedItem, this.cboTech0, this.cboTech1, this.cboTech2, this.cboTech3, this.cboTech4, this.cboTech5, this.cboTech6, this.cboTech7, this.lblNotes, this.chkNextTech.CheckState, int_136);
      this.method_3(selectedItem);
      this.bool_1 = false;
      this.method_5();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1047);
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
    this.cboRaces = new ComboBox();
    this.flowLayoutPanel1 = new FlowLayoutPanel();
    this.cboTech0 = new ComboBox();
    this.cboTech1 = new ComboBox();
    this.cboTech2 = new ComboBox();
    this.cboTech3 = new ComboBox();
    this.cboTech4 = new ComboBox();
    this.cboTech5 = new ComboBox();
    this.cboTech6 = new ComboBox();
    this.cboTech7 = new ComboBox();
    this.cboRC = new ComboBox();
    this.lblNotes = new Label();
    this.cmdCreate = new Button();
    this.cmdInstant = new Button();
    this.cmdCompanyName = new Button();
    this.txtCompanyName = new TextBox();
    this.txtProjectName = new TextBox();
    this.cmdMissileDesign = new Button();
    this.cmdTurretDesign = new Button();
    this.txtDetails = new TextBox();
    this.cmdGU = new Button();
    this.chkNoNameUpdate = new CheckBox();
    this.flpEntry1 = new FlowLayoutPanel();
    this.lblEntry1 = new Label();
    this.txtEntry1 = new TextBox();
    this.flpEntry2 = new FlowLayoutPanel();
    this.lblEntry2 = new Label();
    this.txtEntry2 = new TextBox();
    this.cmdPrototype = new Button();
    this.flowLayoutPanel2 = new FlowLayoutPanel();
    this.chkNextTech = new CheckBox();
    this.flpSizeOptions = new FlowLayoutPanel();
    this.rdo10 = new RadioButton();
    this.rdo100 = new RadioButton();
    this.rdo1000 = new RadioButton();
    this.rdo10000 = new RadioButton();
    this.lblRadioInfo = new Label();
    this.flowLayoutPanel1.SuspendLayout();
    this.flpEntry1.SuspendLayout();
    this.flpEntry2.SuspendLayout();
    this.flowLayoutPanel2.SuspendLayout();
    this.flpSizeOptions.SuspendLayout();
    this.SuspendLayout();
    this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboRaces.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboRaces.FormattingEnabled = true;
    this.cboRaces.Location = new Point(7, 3);
    this.cboRaces.Margin = new Padding(3, 3, 3, 0);
    this.cboRaces.Name = "cboRaces";
    this.cboRaces.Size = new Size(330, 21);
    this.cboRaces.TabIndex = 41;
    this.cboRaces.SelectedIndexChanged += new EventHandler(this.cboRaces_SelectedIndexChanged);
    this.flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
    this.flowLayoutPanel1.Controls.Add((Control) this.cboTech0);
    this.flowLayoutPanel1.Controls.Add((Control) this.cboTech1);
    this.flowLayoutPanel1.Controls.Add((Control) this.cboTech2);
    this.flowLayoutPanel1.Controls.Add((Control) this.cboTech3);
    this.flowLayoutPanel1.Controls.Add((Control) this.cboTech4);
    this.flowLayoutPanel1.Controls.Add((Control) this.cboTech5);
    this.flowLayoutPanel1.Controls.Add((Control) this.cboTech6);
    this.flowLayoutPanel1.Controls.Add((Control) this.cboTech7);
    this.flowLayoutPanel1.Controls.Add((Control) this.flpSizeOptions);
    this.flowLayoutPanel1.Location = new Point(3, 55);
    this.flowLayoutPanel1.Name = "flowLayoutPanel1";
    this.flowLayoutPanel1.Size = new Size(339, 248);
    this.flowLayoutPanel1.TabIndex = 42;
    this.cboTech0.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboTech0.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboTech0.FormattingEnabled = true;
    this.cboTech0.Location = new Point(3, 6);
    this.cboTech0.Margin = new Padding(3, 6, 3, 0);
    this.cboTech0.Name = "cboTech0";
    this.cboTech0.Size = new Size(330, 21);
    this.cboTech0.TabIndex = 42;
    this.cboTech0.SelectedIndexChanged += new EventHandler(this.cboTech7_SelectedIndexChanged);
    this.cboTech1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboTech1.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboTech1.FormattingEnabled = true;
    this.cboTech1.Location = new Point(3, 33);
    this.cboTech1.Margin = new Padding(3, 6, 3, 0);
    this.cboTech1.Name = "cboTech1";
    this.cboTech1.Size = new Size(330, 21);
    this.cboTech1.TabIndex = 43;
    this.cboTech1.SelectedIndexChanged += new EventHandler(this.cboTech7_SelectedIndexChanged);
    this.cboTech2.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboTech2.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboTech2.FormattingEnabled = true;
    this.cboTech2.Location = new Point(3, 60);
    this.cboTech2.Margin = new Padding(3, 6, 3, 0);
    this.cboTech2.Name = "cboTech2";
    this.cboTech2.Size = new Size(330, 21);
    this.cboTech2.TabIndex = 44;
    this.cboTech2.SelectedIndexChanged += new EventHandler(this.cboTech7_SelectedIndexChanged);
    this.cboTech3.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboTech3.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboTech3.FormattingEnabled = true;
    this.cboTech3.Location = new Point(3, 87);
    this.cboTech3.Margin = new Padding(3, 6, 3, 0);
    this.cboTech3.Name = "cboTech3";
    this.cboTech3.Size = new Size(330, 21);
    this.cboTech3.TabIndex = 45;
    this.cboTech3.SelectedIndexChanged += new EventHandler(this.cboTech7_SelectedIndexChanged);
    this.cboTech4.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboTech4.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboTech4.FormattingEnabled = true;
    this.cboTech4.Location = new Point(3, 114);
    this.cboTech4.Margin = new Padding(3, 6, 3, 0);
    this.cboTech4.Name = "cboTech4";
    this.cboTech4.Size = new Size(330, 21);
    this.cboTech4.TabIndex = 46;
    this.cboTech4.SelectedIndexChanged += new EventHandler(this.cboTech7_SelectedIndexChanged);
    this.cboTech5.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboTech5.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboTech5.FormattingEnabled = true;
    this.cboTech5.Location = new Point(3, 141);
    this.cboTech5.Margin = new Padding(3, 6, 3, 0);
    this.cboTech5.Name = "cboTech5";
    this.cboTech5.Size = new Size(330, 21);
    this.cboTech5.TabIndex = 47;
    this.cboTech5.SelectedIndexChanged += new EventHandler(this.cboTech7_SelectedIndexChanged);
    this.cboTech6.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboTech6.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboTech6.FormattingEnabled = true;
    this.cboTech6.Location = new Point(3, 168);
    this.cboTech6.Margin = new Padding(3, 6, 3, 0);
    this.cboTech6.Name = "cboTech6";
    this.cboTech6.Size = new Size(330, 21);
    this.cboTech6.TabIndex = 48 /*0x30*/;
    this.cboTech6.SelectedIndexChanged += new EventHandler(this.cboTech7_SelectedIndexChanged);
    this.cboTech7.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboTech7.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboTech7.FormattingEnabled = true;
    this.cboTech7.Location = new Point(3, 195);
    this.cboTech7.Margin = new Padding(3, 6, 3, 0);
    this.cboTech7.Name = "cboTech7";
    this.cboTech7.Size = new Size(330, 21);
    this.cboTech7.TabIndex = 49;
    this.cboTech7.SelectedIndexChanged += new EventHandler(this.cboTech7_SelectedIndexChanged);
    this.cboRC.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboRC.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboRC.FormattingEnabled = true;
    this.cboRC.Location = new Point(7, 27);
    this.cboRC.Margin = new Padding(3, 3, 3, 0);
    this.cboRC.Name = "cboRC";
    this.cboRC.Size = new Size(330, 21);
    this.cboRC.TabIndex = 43;
    this.cboRC.SelectedIndexChanged += new EventHandler(this.cboRC_SelectedIndexChanged);
    this.lblNotes.BorderStyle = BorderStyle.FixedSingle;
    this.lblNotes.Location = new Point(3, 308);
    this.lblNotes.Name = "lblNotes";
    this.lblNotes.Size = new Size(339, 73);
    this.lblNotes.TabIndex = 44;
    this.lblNotes.Text = "Notes";
    this.cmdCreate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdCreate.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdCreate.Location = new Point(0, 0);
    this.cmdCreate.Margin = new Padding(0);
    this.cmdCreate.Name = "cmdCreate";
    this.cmdCreate.Size = new Size(96 /*0x60*/, 30);
    this.cmdCreate.TabIndex = 69;
    this.cmdCreate.Tag = (object) "1200";
    this.cmdCreate.Text = "Create";
    this.cmdCreate.UseVisualStyleBackColor = false;
    this.cmdCreate.Click += new EventHandler(this.cmdCreate_Click);
    this.cmdInstant.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdInstant.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdInstant.Location = new Point(96 /*0x60*/, 0);
    this.cmdInstant.Margin = new Padding(0);
    this.cmdInstant.Name = "cmdInstant";
    this.cmdInstant.Size = new Size(96 /*0x60*/, 30);
    this.cmdInstant.TabIndex = 72;
    this.cmdInstant.Tag = (object) "1200";
    this.cmdInstant.Text = "Instant";
    this.cmdInstant.UseVisualStyleBackColor = false;
    this.cmdInstant.Click += new EventHandler(this.cmdInstant_Click);
    this.cmdCompanyName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdCompanyName.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdCompanyName.Location = new Point(288, 0);
    this.cmdCompanyName.Margin = new Padding(0);
    this.cmdCompanyName.Name = "cmdCompanyName";
    this.cmdCompanyName.Size = new Size(96 /*0x60*/, 30);
    this.cmdCompanyName.TabIndex = 73;
    this.cmdCompanyName.Tag = (object) "1200";
    this.cmdCompanyName.Text = "Company Name";
    this.cmdCompanyName.UseVisualStyleBackColor = false;
    this.cmdCompanyName.Click += new EventHandler(this.cmdCompanyName_Click);
    this.txtCompanyName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtCompanyName.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtCompanyName.Location = new Point(347, 3);
    this.txtCompanyName.Name = "txtCompanyName";
    this.txtCompanyName.Size = new Size(431, 20);
    this.txtCompanyName.TabIndex = 75;
    this.txtCompanyName.Leave += new EventHandler(this.txtProjectName_Leave);
    this.txtProjectName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtProjectName.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtProjectName.Location = new Point(347, 27);
    this.txtProjectName.Name = "txtProjectName";
    this.txtProjectName.Size = new Size(431, 20);
    this.txtProjectName.TabIndex = 76;
    this.txtProjectName.TextChanged += new EventHandler(this.txtProjectName_TextChanged);
    this.txtProjectName.Leave += new EventHandler(this.txtProjectName_Leave);
    this.cmdMissileDesign.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdMissileDesign.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdMissileDesign.Location = new Point(384, 0);
    this.cmdMissileDesign.Margin = new Padding(0);
    this.cmdMissileDesign.Name = "cmdMissileDesign";
    this.cmdMissileDesign.Size = new Size(96 /*0x60*/, 30);
    this.cmdMissileDesign.TabIndex = 77;
    this.cmdMissileDesign.Tag = (object) "1200";
    this.cmdMissileDesign.Text = "Missile Design";
    this.cmdMissileDesign.UseVisualStyleBackColor = false;
    this.cmdMissileDesign.Click += new EventHandler(this.cmdMissileDesign_Click);
    this.cmdTurretDesign.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdTurretDesign.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdTurretDesign.Location = new Point(480, 0);
    this.cmdTurretDesign.Margin = new Padding(0);
    this.cmdTurretDesign.Name = "cmdTurretDesign";
    this.cmdTurretDesign.Size = new Size(96 /*0x60*/, 30);
    this.cmdTurretDesign.TabIndex = 78;
    this.cmdTurretDesign.Tag = (object) "1200";
    this.cmdTurretDesign.Text = "Turret Design";
    this.cmdTurretDesign.UseVisualStyleBackColor = false;
    this.cmdTurretDesign.Click += new EventHandler(this.cmdTurretDesign_Click);
    this.txtDetails.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtDetails.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.txtDetails.Location = new Point(348, 55);
    this.txtDetails.Multiline = true;
    this.txtDetails.Name = "txtDetails";
    this.txtDetails.Size = new Size(551, 326);
    this.txtDetails.TabIndex = 79;
    this.txtDetails.Text = "Project Details";
    this.cmdGU.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdGU.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdGU.Location = new Point(576, 0);
    this.cmdGU.Margin = new Padding(0);
    this.cmdGU.Name = "cmdGU";
    this.cmdGU.Size = new Size(96 /*0x60*/, 30);
    this.cmdGU.TabIndex = 80 /*0x50*/;
    this.cmdGU.Tag = (object) "1200";
    this.cmdGU.Text = "GU Design";
    this.cmdGU.UseVisualStyleBackColor = false;
    this.cmdGU.Click += new EventHandler(this.cmdGU_Click);
    this.chkNoNameUpdate.AutoSize = true;
    this.chkNoNameUpdate.Location = new Point(785, 29);
    this.chkNoNameUpdate.Name = "chkNoNameUpdate";
    this.chkNoNameUpdate.Padding = new Padding(5, 0, 0, 0);
    this.chkNoNameUpdate.Size = new Size(114, 17);
    this.chkNoNameUpdate.TabIndex = 81;
    this.chkNoNameUpdate.Text = "No Name Update";
    this.chkNoNameUpdate.TextAlign = ContentAlignment.MiddleRight;
    this.chkNoNameUpdate.UseVisualStyleBackColor = true;
    this.flpEntry1.BorderStyle = BorderStyle.Fixed3D;
    this.flpEntry1.Controls.Add((Control) this.lblEntry1);
    this.flpEntry1.Controls.Add((Control) this.txtEntry1);
    this.flpEntry1.Location = new Point(941, 251);
    this.flpEntry1.Margin = new Padding(3, 6, 3, 3);
    this.flpEntry1.Name = "flpEntry1";
    this.flpEntry1.Size = new Size(330, 21);
    this.flpEntry1.TabIndex = 82;
    this.lblEntry1.Location = new Point(3, 1);
    this.lblEntry1.Margin = new Padding(3, 1, 3, 0);
    this.lblEntry1.Name = "lblEntry1";
    this.lblEntry1.Size = new Size(216, 17);
    this.lblEntry1.TabIndex = 83;
    this.lblEntry1.Text = "Entry #1";
    this.txtEntry1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtEntry1.BorderStyle = BorderStyle.None;
    this.txtEntry1.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtEntry1.Location = new Point(222, 2);
    this.txtEntry1.Margin = new Padding(0, 2, 3, 3);
    this.txtEntry1.Name = "txtEntry1";
    this.txtEntry1.Size = new Size(101, 13);
    this.txtEntry1.TabIndex = 84;
    this.txtEntry1.Text = "3";
    this.txtEntry1.TextAlign = HorizontalAlignment.Center;
    this.flpEntry2.BorderStyle = BorderStyle.Fixed3D;
    this.flpEntry2.Controls.Add((Control) this.lblEntry2);
    this.flpEntry2.Controls.Add((Control) this.txtEntry2);
    this.flpEntry2.Location = new Point(941, 281);
    this.flpEntry2.Margin = new Padding(3, 6, 3, 3);
    this.flpEntry2.Name = "flpEntry2";
    this.flpEntry2.Size = new Size(330, 21);
    this.flpEntry2.TabIndex = 83;
    this.lblEntry2.Location = new Point(3, 1);
    this.lblEntry2.Margin = new Padding(3, 1, 3, 0);
    this.lblEntry2.Name = "lblEntry2";
    this.lblEntry2.Size = new Size(216, 17);
    this.lblEntry2.TabIndex = 83;
    this.lblEntry2.Text = "Entry #2";
    this.txtEntry2.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtEntry2.BorderStyle = BorderStyle.None;
    this.txtEntry2.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtEntry2.Location = new Point(222, 2);
    this.txtEntry2.Margin = new Padding(0, 2, 3, 3);
    this.txtEntry2.Name = "txtEntry2";
    this.txtEntry2.Size = new Size(101, 13);
    this.txtEntry2.TabIndex = 84;
    this.txtEntry2.Text = "3";
    this.txtEntry2.TextAlign = HorizontalAlignment.Center;
    this.cmdPrototype.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdPrototype.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdPrototype.Location = new Point(192 /*0xC0*/, 0);
    this.cmdPrototype.Margin = new Padding(0);
    this.cmdPrototype.Name = "cmdPrototype";
    this.cmdPrototype.Size = new Size(96 /*0x60*/, 30);
    this.cmdPrototype.TabIndex = 84;
    this.cmdPrototype.Tag = (object) "1200";
    this.cmdPrototype.Text = "Prototype";
    this.cmdPrototype.UseVisualStyleBackColor = false;
    this.cmdPrototype.Click += new EventHandler(this.cmdPrototype_Click);
    this.flowLayoutPanel2.Controls.Add((Control) this.cmdCreate);
    this.flowLayoutPanel2.Controls.Add((Control) this.cmdInstant);
    this.flowLayoutPanel2.Controls.Add((Control) this.cmdPrototype);
    this.flowLayoutPanel2.Controls.Add((Control) this.cmdCompanyName);
    this.flowLayoutPanel2.Controls.Add((Control) this.cmdMissileDesign);
    this.flowLayoutPanel2.Controls.Add((Control) this.cmdTurretDesign);
    this.flowLayoutPanel2.Controls.Add((Control) this.cmdGU);
    this.flowLayoutPanel2.Location = new Point(3, 386);
    this.flowLayoutPanel2.Name = "flowLayoutPanel2";
    this.flowLayoutPanel2.Size = new Size(757, 30);
    this.flowLayoutPanel2.TabIndex = 85;
    this.chkNextTech.AutoSize = true;
    this.chkNextTech.Location = new Point(785, 6);
    this.chkNextTech.Name = "chkNextTech";
    this.chkNextTech.Padding = new Padding(5, 0, 0, 0);
    this.chkNextTech.Size = new Size(111, 17);
    this.chkNextTech.TabIndex = 86;
    this.chkNextTech.Text = "Show Next Tech";
    this.chkNextTech.TextAlign = ContentAlignment.MiddleRight;
    this.chkNextTech.UseVisualStyleBackColor = true;
    this.chkNextTech.CheckedChanged += new EventHandler(this.chkNextTech_CheckedChanged);
    this.flpSizeOptions.Anchor = AnchorStyles.None;
    this.flpSizeOptions.AutoSize = true;
    this.flpSizeOptions.Controls.Add((Control) this.lblRadioInfo);
    this.flpSizeOptions.Controls.Add((Control) this.rdo10);
    this.flpSizeOptions.Controls.Add((Control) this.rdo100);
    this.flpSizeOptions.Controls.Add((Control) this.rdo1000);
    this.flpSizeOptions.Controls.Add((Control) this.rdo10000);
    this.flpSizeOptions.Location = new Point(3, 219);
    this.flpSizeOptions.Name = "flpSizeOptions";
    this.flpSizeOptions.Size = new Size(327, 23);
    this.flpSizeOptions.TabIndex = 72;
    this.flpSizeOptions.Visible = false;
    this.rdo10.AutoSize = true;
    this.rdo10.Location = new Point(119, 3);
    this.rdo10.Name = "rdo10";
    this.rdo10.Size = new Size(37, 17);
    this.rdo10.TabIndex = 60;
    this.rdo10.Tag = (object) "1";
    this.rdo10.Text = "10";
    this.rdo10.UseVisualStyleBackColor = true;
    this.rdo10.CheckedChanged += new EventHandler(this.rdo10000_CheckedChanged);
    this.rdo100.AutoSize = true;
    this.rdo100.Location = new Point(162, 3);
    this.rdo100.Name = "rdo100";
    this.rdo100.Size = new Size(43, 17);
    this.rdo100.TabIndex = 61;
    this.rdo100.Text = "100";
    this.rdo100.UseVisualStyleBackColor = true;
    this.rdo100.CheckedChanged += new EventHandler(this.rdo10000_CheckedChanged);
    this.rdo1000.AutoSize = true;
    this.rdo1000.Checked = true;
    this.rdo1000.Location = new Point(211, 3);
    this.rdo1000.Name = "rdo1000";
    this.rdo1000.Size = new Size(49, 17);
    this.rdo1000.TabIndex = 62;
    this.rdo1000.TabStop = true;
    this.rdo1000.Text = "1000";
    this.rdo1000.UseVisualStyleBackColor = true;
    this.rdo1000.CheckedChanged += new EventHandler(this.rdo10000_CheckedChanged);
    this.rdo10000.AutoSize = true;
    this.rdo10000.Location = new Point(266, 3);
    this.rdo10000.Name = "rdo10000";
    this.rdo10000.Size = new Size(58, 17);
    this.rdo10000.TabIndex = 63 /*0x3F*/;
    this.rdo10000.Text = "10,000";
    this.rdo10000.UseVisualStyleBackColor = true;
    this.rdo10000.CheckedChanged += new EventHandler(this.rdo10000_CheckedChanged);
    this.lblRadioInfo.AutoSize = true;
    this.lblRadioInfo.Location = new Point(1, 5);
    this.lblRadioInfo.Margin = new Padding(1, 5, 6, 0);
    this.lblRadioInfo.Name = "lblRadioInfo";
    this.lblRadioInfo.Size = new Size(109, 13);
    this.lblRadioInfo.TabIndex = 87;
    this.lblRadioInfo.Text = "Target Tons Multiplier";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.ClientSize = new Size(902, 419);
    this.Controls.Add((Control) this.chkNextTech);
    this.Controls.Add((Control) this.flowLayoutPanel2);
    this.Controls.Add((Control) this.chkNoNameUpdate);
    this.Controls.Add((Control) this.txtDetails);
    this.Controls.Add((Control) this.txtProjectName);
    this.Controls.Add((Control) this.txtCompanyName);
    this.Controls.Add((Control) this.flpEntry1);
    this.Controls.Add((Control) this.flpEntry2);
    this.Controls.Add((Control) this.cboRC);
    this.Controls.Add((Control) this.flowLayoutPanel1);
    this.Controls.Add((Control) this.cboRaces);
    this.Controls.Add((Control) this.lblNotes);
    this.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.KeyPreview = true;
    this.Name = nameof (CreateProject);
    this.Text = "Create Research Project";
    this.Activated += new EventHandler(this.CreateProject_Activated);
    this.FormClosing += new FormClosingEventHandler(this.CreateProject_FormClosing);
    this.Load += new EventHandler(this.CreateProject_Load);
    this.KeyDown += new KeyEventHandler(this.CreateProject_KeyDown);
    this.flowLayoutPanel1.ResumeLayout(false);
    this.flowLayoutPanel1.PerformLayout();
    this.flpEntry1.ResumeLayout(false);
    this.flpEntry1.PerformLayout();
    this.flpEntry2.ResumeLayout(false);
    this.flpEntry2.PerformLayout();
    this.flowLayoutPanel2.ResumeLayout(false);
    this.flpSizeOptions.ResumeLayout(false);
    this.flpSizeOptions.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
