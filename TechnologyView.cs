// Decompiled with JetBrains decompiler
// Type: TechnologyView
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
public class TechnologyView : Form
{
  private GClass0 gclass0_0;
  private GClass21 gclass21_0;
  private GClass169 gclass169_0;
  private GClass230 gclass230_0;
  private GClass129 gclass129_0;
  private bool bool_0;
  private IContainer icontainer_0;
  private ComboBox cboRaces;
  private FlowLayoutPanel flowLayoutPanel1;
  private ComboBox cboCategory;
  private CheckBox chkObsolete;
  private ListView lstvDisplayTech;
  private ColumnHeader columnHeader_0;
  private ColumnHeader columnHeader_1;
  private ColumnHeader columnHeader_2;
  private CheckBox chkShowCivilian;
  private CheckBox chkTons;
  private Button cmdRename;
  private FlowLayoutPanel flowLayoutPanel2;
  private Button cmdObsolete;

  public TechnologyView(GClass0 gclass0_1)
  {
    this.InitializeComponent();
    this.gclass0_0 = gclass0_1;
  }

  private void TechnologyView_Load(object sender, EventArgs e)
  {
    try
    {
      GClass207 gclass207 = this.gclass0_0.method_513(this.Name);
      this.Left = gclass207.int_0;
      this.Top = gclass207.int_1;
      this.gclass0_0.bool_9 = true;
      this.bool_0 = true;
      this.method_2();
      this.gclass0_0.method_577(this.cboRaces);
      this.gclass0_0.bool_9 = false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3139);
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
      GClass226.smethod_74(ex, 3140);
    }
  }

  public void method_1()
  {
    try
    {
      this.gclass21_0 = (GClass21) this.cboRaces.SelectedValue;
      this.method_3();
      if (!this.bool_0)
        this.gclass0_0.method_511(this.gclass21_0, (object) this);
      this.bool_0 = false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3141);
    }
  }

  private void cboRaces_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      this.method_1();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3142);
    }
  }

  private void method_2()
  {
    try
    {
      this.gclass0_0.bool_13 = true;
      List<GClass169> list = this.gclass0_0.dictionary_64.Values.Where<GClass169>((Func<GClass169, bool>) (gclass169_0 => gclass169_0.bool_1)).OrderBy<GClass169, string>((Func<GClass169, string>) (gclass169_0 => gclass169_0.CategoryName)).ToList<GClass169>();
      this.cboCategory.DisplayMember = "CategoryName";
      this.cboCategory.DataSource = (object) list;
      this.gclass0_0.bool_13 = false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3143);
    }
  }

  private void method_3()
  {
    try
    {
      if (this.gclass0_0.bool_13)
        return;
      if (this.gclass21_0 == null)
      {
        int num1 = (int) MessageBox.Show("Please select a race");
      }
      else
      {
        this.gclass169_0 = (GClass169) this.cboCategory.SelectedValue;
        this.lstvDisplayTech.Columns.Clear();
        this.lstvDisplayTech.Items.Clear();
        int num2 = 50;
        if (this.chkTons.CheckState == CheckState.Unchecked)
          num2 = 1;
        if (this.gclass169_0.genum119_0 == GEnum119.const_1)
          this.method_4(AuroraComponentType.Laser, num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_18)
          this.method_4(AuroraComponentType.Carronade, num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_17)
          this.method_4(AuroraComponentType.Railgun, num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_15)
          this.method_4(AuroraComponentType.ParticleBeam, num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_16)
          this.method_4(AuroraComponentType.MesonCannon, num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_23)
          this.method_4(AuroraComponentType.HighPowerMicrowave, num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_24)
          this.method_4(AuroraComponentType.GaussCannon, num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_5)
          this.method_5(num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_9)
          this.method_13(num2, AuroraComponentType.ActiveSearchSensors);
        if (this.gclass169_0.genum119_0 == GEnum119.const_14)
          this.method_13(num2, AuroraComponentType.MissileFireControl);
        if (this.gclass169_0.genum119_0 == GEnum119.const_13)
          this.method_14(num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_27)
          this.method_17(num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_22)
          this.method_15(AuroraComponentType.EMSensors, num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_10)
          this.method_15(AuroraComponentType.ThermalSensors, num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_11)
          this.method_16(num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_12)
          this.method_9(num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_26)
          this.method_10(num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_2)
          this.method_11(num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_4)
          this.method_6(num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_8)
          this.method_8(num2);
        if (this.gclass169_0.genum119_0 == GEnum119.const_3)
          this.method_12((Decimal) num2);
        if (this.gclass169_0.genum119_0 != GEnum119.const_25)
          return;
        this.method_7(num2);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3144);
    }
  }

  private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      this.method_3();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3145);
    }
  }

  // weaponry
  private void method_4(AuroraComponentType auroraComponentType_0, int int_0)
  {
    try
    {
      this.lstvDisplayTech.Columns.Add("Name", 300, HorizontalAlignment.Left);
      this.lstvDisplayTech.Columns.Add("Damage", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Range", 100, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Tracking Speed", 100, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Firing Interval", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Size", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Cost", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Total Power", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Capacitor", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Range Modifier", 100, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Crew", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("HTK", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Obsolete?", 60, HorizontalAlignment.Center);
      this.gclass0_0.method_624(this.lstvDisplayTech, "", "Damage", "Range", "Tracking Speed", "Firing Interval", "Size", "Cost", "Total Power", "Capacitor", "Range Modifier", "Crew", "HTK", "Obsolete?", (object) null);
      this.gclass0_0.method_594(this.lstvDisplayTech, "");
      
      foreach (GClass230 object_1 in this.gclass0_0.dictionary_54.Values
                 .Where<GClass230>(
                    gc230=>gc230.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gc230.gclass231_0.auroraComponentType_0 == auroraComponentType_0)
                 .Where<GClass230>(
                    gc230=>!gc230.bool_3 && this.chkShowCivilian.CheckState == CheckState.Checked)
                 .Where<GClass230>(
                    gc230=>!gc230.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 && this.chkObsolete.CheckState == CheckState.Checked
                   ).OrderBy<GClass230, string>((Func<GClass230, string>) (gclass230_0 => gclass230_0.Name)).ToList<GClass230>())
      {
        Decimal d = 1M;
        if (object_1.decimal_4 > 0M)
          d = object_1.decimal_0 / object_1.decimal_4;
        int num = (int) Math.Ceiling(d) * 5;
        Decimal decimal_73 = object_1.int_8 <= 0 ? Math.Floor((Decimal) object_1.int_6 * object_1.decimal_17) : (Decimal) object_1.int_8;
        string string_22 = "-";
        if (this.chkObsolete.CheckState == CheckState.Checked && object_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0)
          string_22 = "Yes";
        string string_11 = object_1.int_6.ToString();
        if (object_1.int_7 > 1)
          string_11 = $"{string_11} x {object_1.int_7.ToString()}";
        string string_13 = "-";
        if (object_1.int_3 > 0)
          string_13 = GClass226.smethod_37(object_1.int_3) + " km/s";
        string name = object_1.Name;
        if (object_1.genum86_0 != GEnum86.const_0)
          name += " (P)";
        this.gclass0_0.method_624(this.lstvDisplayTech, name, string_11, GClass226.smethod_39(decimal_73) + " km", string_13, num.ToString() + " secs", GClass226.smethod_42(object_1.decimal_1 * (Decimal) int_0, 2), GClass226.smethod_42(object_1.decimal_2, 2), GClass226.smethod_39(object_1.decimal_0), GClass226.smethod_39(object_1.decimal_4), GClass226.smethod_39(object_1.decimal_17) + " km", GClass226.smethod_37(object_1.int_1), GClass226.smethod_37(object_1.int_4), string_22, (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3146);
    }
  }

  private void method_5(int int_0)
  {
    try
    {
      this.lstvDisplayTech.Columns.Add("Name", 350, HorizontalAlignment.Left);
      this.lstvDisplayTech.Columns.Add("Power", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Efficiency", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Size", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Cost", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Exp Chance", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Exp Size", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Crew", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("HTK", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Obsolete?", 60, HorizontalAlignment.Center);
      this.gclass0_0.method_617(this.lstvDisplayTech, "", "Power", "Efficiency", "Size", "Cost", "Exp Chance", "Exp Size", "Crew", "HTK", "Obsolete?", (object) null);
      this.gclass0_0.method_594(this.lstvDisplayTech, "");
      foreach (GClass230 object_1 in this.gclass0_0.dictionary_54.Values.Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => gclass230_1.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass230_1.gclass231_0.auroraComponentType_0 == AuroraComponentType.Engine)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.bool_3 || this.chkShowCivilian.CheckState == CheckState.Checked)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 || this.chkObsolete.CheckState == CheckState.Checked)).OrderBy<GClass230, string>((Func<GClass230, string>) (gclass230_0 => gclass230_0.Name)).ToList<GClass230>())
      {
        string string_19 = "-";
        if (this.chkObsolete.CheckState == CheckState.Checked && object_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0)
          string_19 = "Yes";
        this.gclass0_0.method_617(this.lstvDisplayTech, object_1.Name, GClass226.smethod_39(object_1.decimal_3), GClass226.smethod_42(object_1.decimal_8, 3), GClass226.smethod_42(object_1.decimal_1 * (Decimal) int_0, 2), GClass226.smethod_42(object_1.decimal_2, 2), GClass226.smethod_39(object_1.decimal_11), GClass226.smethod_39((Decimal) object_1.int_5), GClass226.smethod_37(object_1.int_1), GClass226.smethod_37(object_1.int_4), string_19, (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3147);
    }
  }

  private void method_6(int int_0)
  {
    try
    {
      this.lstvDisplayTech.Columns.Add("Name", 350, HorizontalAlignment.Left);
      this.lstvDisplayTech.Columns.Add("Power", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Power per HS", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Size", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Cost", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Exp Chance", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Exp Size", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Crew", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("HTK", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Obsolete?", 60, HorizontalAlignment.Center);
      this.gclass0_0.method_617(this.lstvDisplayTech, "", "Power", "Power per HS", "Size", "Cost", "Exp Chance", "Exp Size", "Crew", "HTK", "Obsolete?", (object) null);
      this.gclass0_0.method_594(this.lstvDisplayTech, "");
      foreach (GClass230 object_1 in this.gclass0_0.dictionary_54.Values.Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => gclass230_1.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass230_1.gclass231_0.auroraComponentType_0 == AuroraComponentType.PowerPlant)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.bool_3 || this.chkShowCivilian.CheckState == CheckState.Checked)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 || this.chkObsolete.CheckState == CheckState.Checked)).OrderBy<GClass230, string>((Func<GClass230, string>) (gclass230_0 => gclass230_0.Name)).ToList<GClass230>())
      {
        string string_19 = "-";
        if (this.chkObsolete.CheckState == CheckState.Checked && object_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0)
          string_19 = "Yes";
        this.gclass0_0.method_617(this.lstvDisplayTech, object_1.Name, GClass226.smethod_39(object_1.decimal_3), GClass226.smethod_42(object_1.decimal_3 / object_1.decimal_1, 2), GClass226.smethod_42(object_1.decimal_1 * (Decimal) int_0, 2), GClass226.smethod_42(object_1.decimal_2, 2), GClass226.smethod_39(object_1.decimal_11), GClass226.smethod_39((Decimal) object_1.int_5), GClass226.smethod_37(object_1.int_1), GClass226.smethod_37(object_1.int_4), string_19, (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3148);
    }
  }

  private void method_7(int int_0)
  {
    try
    {
      this.lstvDisplayTech.Columns.Add("Name", 350, HorizontalAlignment.Left);
      this.lstvDisplayTech.Columns.Add("Size", 100, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Cost", 100, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Cloak Rating", 100, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Cloak Ship Size", 100, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Crew", 100, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("HTK", 100, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Obsolete?", 100, HorizontalAlignment.Center);
      this.gclass0_0.method_614(this.lstvDisplayTech, "", "Size", "Cost", "Cloak Rating", "Cloak Ship Size", "Crew", "HTK", "Obsolete?", (object) null);
      this.gclass0_0.method_594(this.lstvDisplayTech, "");
      foreach (GClass230 object_1 in this.gclass0_0.dictionary_54.Values.Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => gclass230_1.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass230_1.gclass231_0.auroraComponentType_0 == AuroraComponentType.CloakingDevice)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 || this.chkObsolete.CheckState == CheckState.Checked)).OrderBy<GClass230, string>((Func<GClass230, string>) (gclass230_0 => gclass230_0.Name)).ToList<GClass230>())
      {
        string string_17 = "-";
        if (this.chkObsolete.CheckState == CheckState.Checked && object_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0)
          string_17 = "Yes";
        this.gclass0_0.method_614(this.lstvDisplayTech, object_1.Name, GClass226.smethod_42(object_1.decimal_1 * (Decimal) int_0, 2), GClass226.smethod_42(object_1.decimal_2, 2), GClass226.smethod_39(object_1.decimal_10), GClass226.smethod_39(object_1.decimal_3), GClass226.smethod_37(object_1.int_1), GClass226.smethod_37(object_1.int_4), string_17, (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3400);
    }
  }

  private void method_8(int int_0)
  {
    try
    {
      this.lstvDisplayTech.Columns.Add("Name", 350, HorizontalAlignment.Left);
      this.lstvDisplayTech.Columns.Add("Max Strength", 90, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Recharge Time", 90, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Size", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Cost", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Crew", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("HTK", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Obsolete?", 60, HorizontalAlignment.Center);
      this.gclass0_0.method_614(this.lstvDisplayTech, "", "Max Strength", "Recharge Time", "Size", "Cost", "Crew", "HTK", "Obsolete?", (object) null);
      this.gclass0_0.method_594(this.lstvDisplayTech, "");
      foreach (GClass230 object_1 in this.gclass0_0.dictionary_54.Values.Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => gclass230_1.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass230_1.gclass231_0.auroraComponentType_0 == AuroraComponentType.Shields)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.bool_3 || this.chkShowCivilian.CheckState == CheckState.Checked)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 || this.chkObsolete.CheckState == CheckState.Checked)).OrderBy<GClass230, string>((Func<GClass230, string>) (gclass230_0 => gclass230_0.Name)).ToList<GClass230>())
      {
        string string_17 = "-";
        if (this.chkObsolete.CheckState == CheckState.Checked && object_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0)
          string_17 = "Yes";
        this.gclass0_0.method_614(this.lstvDisplayTech, object_1.Name, GClass226.smethod_38(object_1.decimal_3), GClass226.smethod_38(object_1.decimal_4) + " secs", GClass226.smethod_42(object_1.decimal_1 * (Decimal) int_0, 2), GClass226.smethod_42(object_1.decimal_2, 2), GClass226.smethod_37(object_1.int_1), GClass226.smethod_37(object_1.int_4), string_17, (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3149);
    }
  }

  private void method_9(int int_0)
  {
    try
    {
      this.lstvDisplayTech.Columns.Add("Name", 350, HorizontalAlignment.Left);
      this.lstvDisplayTech.Columns.Add("Capacity", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Squadron Size", 90, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Jump Radius", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Commercial", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Size", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Cost", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Crew", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("HTK", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Obsolete?", 60, HorizontalAlignment.Center);
      this.gclass0_0.method_617(this.lstvDisplayTech, "", "Capacity", "Squadron Size", "Jump Radius", "Commercial", "Size", "Cost", "Crew", "HTK", "Obsolete?", (object) null);
      this.gclass0_0.method_594(this.lstvDisplayTech, "");
      foreach (GClass230 object_1 in this.gclass0_0.dictionary_54.Values.Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => gclass230_1.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass230_1.gclass231_0.auroraComponentType_0 == AuroraComponentType.JumpDrive)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.bool_3 || this.chkShowCivilian.CheckState == CheckState.Checked)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 || this.chkObsolete.CheckState == CheckState.Checked)).OrderByDescending<GClass230, AuroraComponentType>((Func<GClass230, AuroraComponentType>) (gclass230_0 => gclass230_0.gclass231_0.auroraComponentType_0)).ThenBy<GClass230, string>((Func<GClass230, string>) (gclass230_0 => gclass230_0.Name)).ToList<GClass230>())
      {
        string string_19 = "-";
        if (this.chkObsolete.CheckState == CheckState.Checked && object_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0)
          string_19 = "Yes";
        string string_14 = "No";
        if (object_1.genum87_0 == GEnum87.const_2)
          string_14 = "Yes";
        this.gclass0_0.method_617(this.lstvDisplayTech, object_1.Name, GClass226.smethod_39(object_1.decimal_3 * GClass226.decimal_17), GClass226.smethod_37(object_1.int_10), GClass226.smethod_37(object_1.int_9), string_14, GClass226.smethod_42(object_1.decimal_1 * (Decimal) int_0, 2), GClass226.smethod_42(object_1.decimal_2, 2), GClass226.smethod_37(object_1.int_1), GClass226.smethod_37(object_1.int_4), string_19, (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3150);
    }
  }

  private void method_10(int int_0)
  {
    try
    {
      this.lstvDisplayTech.Columns.Add("Name", 350, HorizontalAlignment.Left);
      this.lstvDisplayTech.Columns.Add("Capacity", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Capacity per HS", 90, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Explosion Chance", 90, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Commercial", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Size", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Cost", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Crew", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("HTK", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Obsolete?", 60, HorizontalAlignment.Center);
      this.gclass0_0.method_617(this.lstvDisplayTech, "", "Capacity", "Capacity per HS", "Exp Chance", "Commercial", "Size", "Cost", "Crew", "HTK", "Obsolete?", (object) null);
      this.gclass0_0.method_594(this.lstvDisplayTech, "");
      foreach (GClass230 object_1 in this.gclass0_0.dictionary_54.Values.Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => gclass230_1.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass230_1.gclass231_0.auroraComponentType_0 == AuroraComponentType.Magazine)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.bool_3 || this.chkShowCivilian.CheckState == CheckState.Checked)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 || this.chkObsolete.CheckState == CheckState.Checked)).OrderBy<GClass230, bool>((Func<GClass230, bool>) (gclass230_0 => gclass230_0.bool_1)).ThenBy<GClass230, string>((Func<GClass230, string>) (gclass230_0 => gclass230_0.Name)).ToList<GClass230>())
      {
        string string_19 = "-";
        if (this.chkObsolete.CheckState == CheckState.Checked && object_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0)
          string_19 = "Yes";
        string string_14 = "No";
        if (!object_1.bool_1)
          string_14 = "Yes";
        this.gclass0_0.method_617(this.lstvDisplayTech, object_1.Name, GClass226.smethod_39(object_1.decimal_3), GClass226.smethod_42(object_1.decimal_3 / object_1.decimal_1, 2), GClass226.smethod_42(object_1.decimal_11, 1) + "%", string_14, GClass226.smethod_42(object_1.decimal_1 * (Decimal) int_0, 2), GClass226.smethod_42(object_1.decimal_2, 2), GClass226.smethod_37(object_1.int_1), GClass226.smethod_37(object_1.int_4), string_19, (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3151);
    }
  }

  private void method_11(int int_0)
  {
    try
    {
      this.lstvDisplayTech.Columns.Add("Name", 350, HorizontalAlignment.Left);
      this.lstvDisplayTech.Columns.Add("Missile Size", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Recycle Time", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Size", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Cost", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Crew", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("HTK", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Obsolete?", 60, HorizontalAlignment.Center);
      this.gclass0_0.method_614(this.lstvDisplayTech, "", "Missile Size", "Recycle Time", "Size", "Cost", "Crew", "HTK", "Obsolete?", (object) null);
      this.gclass0_0.method_594(this.lstvDisplayTech, "");
      foreach (GClass230 object_1 in this.gclass0_0.dictionary_54.Values.Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => gclass230_1.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass230_1.gclass231_0.auroraComponentType_0 == AuroraComponentType.MissileLauncher)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.bool_3 || this.chkShowCivilian.CheckState == CheckState.Checked)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 || this.chkObsolete.CheckState == CheckState.Checked)).OrderBy<GClass230, string>((Func<GClass230, string>) (gclass230_0 => gclass230_0.Name)).ToList<GClass230>())
      {
        string string_17 = "-";
        if (this.chkObsolete.CheckState == CheckState.Checked && object_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0)
          string_17 = "Yes";
        this.gclass0_0.method_614(this.lstvDisplayTech, object_1.Name, GClass226.smethod_39(object_1.decimal_3), GClass226.smethod_39((Decimal) object_1.int_11) + " secs", GClass226.smethod_42(object_1.decimal_1 * (Decimal) int_0, 2), GClass226.smethod_42(object_1.decimal_2, 2), GClass226.smethod_37(object_1.int_1), GClass226.smethod_37(object_1.int_4), string_17, (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3152);
    }
  }

  private void method_12(Decimal decimal_0)
  {
    try
    {
      if (decimal_0 == 50M)
        decimal_0 = 2.5M;
      this.lstvDisplayTech.Columns.Add("Name", 200, HorizontalAlignment.Left);
      this.lstvDisplayTech.Columns.Add("Size (MSP)", 50, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Speed", 70, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("First Stage", 70, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Total Range", 70, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Warhead", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Active", 50, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Thermal", 50, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("EM", 50, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Geo", 50, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Decoys", 50, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("ECCM", 50, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("ATG", 50, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Retarget", 50, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Radiation", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Cost", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Obsolete?", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Second Stage?", 200, HorizontalAlignment.Left);
      this.gclass0_0.method_629(this.lstvDisplayTech, "", "Size", "Speed (km/s)", "First Stage", "Total Range", "Warhead", "Active", "Thermal", "EM", "Geo", "Decoys", "ECCM", "ATG", "Retarget", "Radiation", "Cost", "Obsolete?", "Second Stage", (object) null);
      this.gclass0_0.method_594(this.lstvDisplayTech, "");
      foreach (GClass129 object_1 in this.gclass0_0.dictionary_5.Values.Where<GClass129>((Func<GClass129, bool>) (gclass129_1 => gclass129_1.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID))).Where<GClass129>((Func<GClass129, bool>) (gclass129_1 => !gclass129_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 || this.chkObsolete.CheckState == CheckState.Checked)).OrderBy<GClass129, string>((Func<GClass129, string>) (gclass129_0 => gclass129_0.Name)).ToList<GClass129>())
      {
        string string_26 = "-";
        string string_15 = "-";
        string string_20 = "-";
        if (this.chkObsolete.CheckState == CheckState.Checked && object_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0)
          string_26 = "Yes";
        string string_27 = "";
        if (object_1.gclass129_0 != null)
          string_27 = $"{object_1.int_16.ToString()}x {object_1.gclass129_0.Name}";
        if (object_1.decimal_0 > 0M)
        {
          if (object_1.decimal_1 > 0M)
            string_15 = $"L{GClass226.smethod_42(object_1.method_2(object_1.decimal_25), 1)} {GClass226.smethod_42(object_1.decimal_25 / 1000M, 0)}k";
          else
            string_15 = object_1.int_13 <= 1 ? GClass226.smethod_42(object_1.decimal_0, 3) : $"{GClass226.smethod_42(object_1.decimal_0 / (Decimal) object_1.int_13, 3)}x{object_1.int_13.ToString()}";
        }
        if (object_1.int_14 == 1)
          string_20 = "SHIP";
        else if (object_1.int_7 > 0)
          string_20 = $"{GClass226.smethod_37(object_1.int_7).ToString()}-{object_1.int_12.ToString()}";
        string string_12 = "-";
        if (object_1.decimal_5 > 0M)
          string_12 = GClass226.smethod_38(object_1.decimal_5);
        string string_24 = "-";
        if (object_1.decimal_2 > 0M)
          string_24 = GClass226.smethod_42(object_1.decimal_2, 3);
        string string_13 = "-";
        if (object_1.double_4 > 0.0)
          string_13 = GClass226.smethod_50(object_1.double_4 / 1000000.0);
        string string_14 = "-";
        if (object_1.double_4 > object_1.double_5)
          string_14 = GClass226.smethod_50(object_1.double_5 / 1000000.0);
        string string_16 = "-";
        if (object_1.double_0 > 0.0)
          string_16 = GClass226.smethod_44(object_1.double_0, 3);
        string string_17 = "-";
        if (object_1.double_1 > 0.0)
          string_17 = GClass226.smethod_44(object_1.double_1, 3);
        string string_18 = "-";
        if (object_1.double_2 > 0.0)
          string_18 = GClass226.smethod_44(object_1.double_2, 3);
        string string_19 = "-";
        if (object_1.decimal_16 > 0M)
          string_19 = GClass226.smethod_42(object_1.decimal_16, 3);
        string string_22 = "-";
        if (object_1.decimal_26 > 1M)
          string_22 = GClass226.smethod_42((object_1.decimal_26 - 1M) * 100M, 3) + "%";
        string string_23 = "-";
        if (object_1.int_10 == 1)
          string_23 = "Yes";
        string string_21 = "-";
        if (object_1.int_8 > 0)
          string_21 = GClass226.smethod_42((Decimal) object_1.int_8, 3);
        this.gclass0_0.method_629(this.lstvDisplayTech, object_1.Name, GClass226.smethod_42(object_1.decimal_4 * decimal_0, 4), string_12, string_13, string_14, string_15, string_16, string_17, string_18, string_19, string_20, string_21, string_22, string_23, string_24, GClass226.smethod_42(object_1.decimal_3, 2), string_26, string_27, (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3153);
    }
  }

  // activesensor / MFC
  private void method_13(int int_0, AuroraComponentType auroraComponentType_0)
  {
    try
    {
      this.lstvDisplayTech.Columns.Add("Name", 350, HorizontalAlignment.Left);
      this.lstvDisplayTech.Columns.Add("Range", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Resolution", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Emissions", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Size", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Cost", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Crew", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("HTK", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Obsolete?", 60, HorizontalAlignment.Center);
      this.gclass0_0.method_615(this.lstvDisplayTech, "", "Range (m km)", "Resolution", "Emissions", "Size", "Cost", "Crew", "HTK", "Obsolete?", (object) null);
      this.gclass0_0.method_594(this.lstvDisplayTech, "");
      foreach (GClass230 object_1 in this.gclass0_0.dictionary_54.Values
                 .Where<GClass230>(gc230=>gc230.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gc230.gclass231_0.auroraComponentType_0 == auroraComponentType_0)
                 .Where<GClass230>(gc230=>!gc230.bool_3 || this.chkShowCivilian.CheckState == CheckState.Checked)
                 .Where<GClass230>(gc230=>!gc230.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 || this.chkObsolete.CheckState == CheckState.Checked).OrderBy<GClass230, AuroraComponentType>((Func<GClass230, AuroraComponentType>) (gclass230_0 => gclass230_0.gclass231_0.auroraComponentType_0)).ThenBy<GClass230, string>((Func<GClass230, string>) (gclass230_0 => gclass230_0.Name)).ToList<GClass230>())
      {
        string string_18 = "-";
        if (this.chkObsolete.CheckState == CheckState.Checked && object_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0)
          string_18 = "Yes";
        this.gclass0_0.method_615(this.lstvDisplayTech, object_1.Name, GClass226.smethod_44(object_1.double_0 / 1000000.0, 1), GClass226.smethod_39(object_1.decimal_6), GClass226.smethod_39(object_1.decimal_3), GClass226.smethod_42(object_1.decimal_1 * (Decimal) int_0, 2), GClass226.smethod_42(object_1.decimal_2, 2), GClass226.smethod_37(object_1.int_1), GClass226.smethod_37(object_1.int_4), string_18, (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3154);
    }
  }

  private void method_14(int int_0)
  {
    try
    {
      this.lstvDisplayTech.Columns.Add("Name", 350, HorizontalAlignment.Left);
      this.lstvDisplayTech.Columns.Add("Range", 90, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Tracking Speed", 90, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Size", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Cost", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Crew", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("HTK", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Obsolete?", 60, HorizontalAlignment.Center);
      this.gclass0_0.method_614(this.lstvDisplayTech, "", "Range", "Tracking Speed", "Size", "Cost", "Crew", "HTK", "Obsolete?", (object) null);
      this.gclass0_0.method_594(this.lstvDisplayTech, "");
      foreach (GClass230 object_1 in this.gclass0_0.dictionary_54.Values.Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => gclass230_1.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass230_1.gclass231_0.auroraComponentType_0 == AuroraComponentType.BeamFireControl)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.bool_3 || this.chkShowCivilian.CheckState == CheckState.Checked)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 || this.chkObsolete.CheckState == CheckState.Checked)).OrderBy<GClass230, AuroraComponentType>((Func<GClass230, AuroraComponentType>) (gclass230_0 => gclass230_0.gclass231_0.auroraComponentType_0)).ThenBy<GClass230, string>((Func<GClass230, string>) (gclass230_0 => gclass230_0.Name)).ToList<GClass230>())
      {
        string string_17 = "-";
        if (this.chkObsolete.CheckState == CheckState.Checked && object_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0)
          string_17 = "Yes";
        this.gclass0_0.method_614(this.lstvDisplayTech, object_1.Name, GClass226.smethod_39(object_1.decimal_3), GClass226.smethod_39((Decimal) object_1.int_3), GClass226.smethod_42(object_1.decimal_1 * (Decimal) int_0, 2), GClass226.smethod_42(object_1.decimal_2, 2), GClass226.smethod_37(object_1.int_1), GClass226.smethod_37(object_1.int_4), string_17, (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3155);
    }
  }

  private void method_15(AuroraComponentType auroraComponentType_0, int int_0)
  {
    try
    {
      this.lstvDisplayTech.Columns.Add("Name", 350, HorizontalAlignment.Left);
      this.lstvDisplayTech.Columns.Add("Strength", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Range vs 100", 90, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Range vs 1000", 90, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Range vs 10000", 90, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Size", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Cost", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Crew", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("HTK", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Obsolete?", 60, HorizontalAlignment.Center);
      this.gclass0_0.method_617(this.lstvDisplayTech, "", "Strength", "m km vs 100", "m km vs 1000", "m km vs 10000", "Size", "Cost", "Crew", "HTK", "Obsolete?", (object) null);
      this.gclass0_0.method_594(this.lstvDisplayTech, "");
      
      foreach (GClass230 object_1 in this.gclass0_0.dictionary_54.Values
                 .Where<GClass230>(gc230=>gc230.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID)
                                          && gc230.gclass231_0.auroraComponentType_0 == auroraComponentType_0)
                 .Where<GClass230>(gc230=>!gc230.bool_3 || this.chkShowCivilian.CheckState == CheckState.Checked)
                 .Where<GClass230>(gc230=>!gc230.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 || this.chkObsolete.CheckState == CheckState.Checked)
                 .OrderBy<GClass230, AuroraComponentType>((Func<GClass230, AuroraComponentType>) (gclass230_0 => gclass230_0.gclass231_0.auroraComponentType_0))
                 .ThenBy<GClass230, string>((Func<GClass230, string>) (gclass230_0 => gclass230_0.Name)).ToList<GClass230>())
      {
        string string_19 = "-";
        if (this.chkObsolete.CheckState == CheckState.Checked && object_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0)
          string_19 = "Yes";
        double num1 = Math.Sqrt((double) object_1.decimal_3 * 100.0) * GClass226.double_18;
        double num2 = Math.Sqrt((double) object_1.decimal_3 * 1000.0) * GClass226.double_18;
        double num3 = Math.Sqrt((double) object_1.decimal_3 * 10000.0) * GClass226.double_18;
        this.gclass0_0.method_617(this.lstvDisplayTech, object_1.Name, GClass226.smethod_39(object_1.decimal_3), GClass226.smethod_44(num1 / 1000000.0, 1), GClass226.smethod_44(num2 / 1000000.0, 1), GClass226.smethod_44(num3 / 1000000.0, 1), GClass226.smethod_42(object_1.decimal_1 * (Decimal) int_0, 2), GClass226.smethod_42(object_1.decimal_2, 2), GClass226.smethod_37(object_1.int_1), GClass226.smethod_37(object_1.int_4), string_19, (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3156);
    }
  }

  private void method_16(int int_0)
  {
    try
    {
      this.lstvDisplayTech.Columns.Add("Name", 350, HorizontalAlignment.Left);
      this.lstvDisplayTech.Columns.Add("Strength", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Size", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Cost", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Crew", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("HTK", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Obsolete?", 60, HorizontalAlignment.Center);
      this.gclass0_0.method_613(this.lstvDisplayTech, "", "Strength", "Size", "Cost", "Crew", "HTK", "Obsolete?", (object) null);
      this.gclass0_0.method_594(this.lstvDisplayTech, "");
      foreach (GClass230 object_1 in this.gclass0_0.dictionary_54.Values.Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => gclass230_1.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass230_1.gclass231_0.auroraComponentType_0 == AuroraComponentType.ElectronicWarfareSystems)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.bool_3 || this.chkShowCivilian.CheckState == CheckState.Checked)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 || this.chkObsolete.CheckState == CheckState.Checked)).OrderBy<GClass230, AuroraComponentType>((Func<GClass230, AuroraComponentType>) (gclass230_0 => gclass230_0.gclass231_0.auroraComponentType_0)).ThenBy<GClass230, string>((Func<GClass230, string>) (gclass230_0 => gclass230_0.Name)).ToList<GClass230>())
      {
        string string_16 = "-";
        if (this.chkObsolete.CheckState == CheckState.Checked && object_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0)
          string_16 = "Yes";
        this.gclass0_0.method_613(this.lstvDisplayTech, object_1.Name, GClass226.smethod_39(object_1.decimal_3), GClass226.smethod_42(object_1.decimal_1 * (Decimal) int_0, 2), GClass226.smethod_42(object_1.decimal_2, 2), GClass226.smethod_37(object_1.int_1), GClass226.smethod_37(object_1.int_4), string_16, (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3157);
    }
  }

  private void method_17(int int_0)
  {
    try
    {
      this.lstvDisplayTech.Columns.Add("Name", 350, HorizontalAlignment.Left);
      this.lstvDisplayTech.Columns.Add("ROF", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Tracking Speed", 90, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("ECCM", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Size", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Cost", 80 /*0x50*/, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Crew", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("HTK", 60, HorizontalAlignment.Center);
      this.lstvDisplayTech.Columns.Add("Obsolete?", 60, HorizontalAlignment.Center);
      this.gclass0_0.method_615(this.lstvDisplayTech, "", "ROF", "Tracking Speed", "ECCM", "Size", "Cost", "Crew", "HTK", "Obsolete?", (object) null);
      this.gclass0_0.method_594(this.lstvDisplayTech, "");
      foreach (GClass230 object_1 in this.gclass0_0.dictionary_54.Values.Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => gclass230_1.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass230_1.gclass231_0.auroraComponentType_0 == AuroraComponentType.CIWS)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.bool_3 || this.chkShowCivilian.CheckState == CheckState.Checked)).Where<GClass230>((Func<GClass230, bool>) (gclass230_1 => !gclass230_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 || this.chkObsolete.CheckState == CheckState.Checked)).OrderBy<GClass230, AuroraComponentType>((Func<GClass230, AuroraComponentType>) (gclass230_0 => gclass230_0.gclass231_0.auroraComponentType_0)).ThenBy<GClass230, string>((Func<GClass230, string>) (gclass230_0 => gclass230_0.Name)).ToList<GClass230>())
      {
        string string_18 = "-";
        if (this.chkObsolete.CheckState == CheckState.Checked && object_1.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0)
          string_18 = "Yes";
        this.gclass0_0.method_615(this.lstvDisplayTech, object_1.Name, GClass226.smethod_39((Decimal) object_1.int_7), GClass226.smethod_39((Decimal) object_1.int_3), GClass226.smethod_39(object_1.decimal_13), GClass226.smethod_42(object_1.decimal_1 * (Decimal) int_0, 2), GClass226.smethod_42(object_1.decimal_2, 2), GClass226.smethod_37(object_1.int_1), GClass226.smethod_37(object_1.int_4), string_18, (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3158);
    }
  }

  private void chkObsolete_CheckedChanged(object sender, EventArgs e)
  {
    try
    {
      this.method_3();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3159);
    }
  }

  private void chkShowCivilian_CheckedChanged(object sender, EventArgs e)
  {
    try
    {
      this.method_3();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3160);
    }
  }

  private void chkTons_CheckedChanged(object sender, EventArgs e)
  {
    try
    {
      this.method_3();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3161);
    }
  }

  private void cmdRename_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass0_0.bool_9)
        return;
      if (this.gclass230_0 != null)
      {
        this.gclass0_0.string_3 = "Enter New Component Name";
        this.gclass0_0.string_4 = this.gclass230_0.Name;
        int num = (int) new MessageEntry(this.gclass0_0).ShowDialog();
        if (this.gclass0_0.string_4 != this.gclass230_0.Name && !this.gclass0_0.bool_21)
          this.gclass230_0.Name = this.gclass0_0.string_4;
      }
      else
      {
        if (this.gclass129_0 == null)
          return;
        this.gclass0_0.string_3 = "Enter New Missile Name";
        this.gclass0_0.string_4 = this.gclass129_0.Name;
        int num = (int) new MessageEntry(this.gclass0_0).ShowDialog();
        if (this.gclass0_0.string_4 != this.gclass129_0.Name && !this.gclass0_0.bool_21)
          this.gclass129_0.Name = this.gclass0_0.string_4;
      }
      this.method_3();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3162);
    }
  }

  private void lstvDisplayTech_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      this.gclass230_0 = (GClass230) null;
      this.gclass129_0 = (GClass129) null;
      if (this.lstvDisplayTech.SelectedItems.Count <= 0 || this.lstvDisplayTech.SelectedItems[0].Index < 0)
        return;
      if (this.lstvDisplayTech.SelectedItems[0].Tag is GClass230)
      {
        this.gclass230_0 = (GClass230) this.lstvDisplayTech.SelectedItems[0].Tag;
      }
      else
      {
        if (!(this.lstvDisplayTech.SelectedItems[0].Tag is GClass129))
          return;
        this.gclass129_0 = (GClass129) this.lstvDisplayTech.SelectedItems[0].Tag;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3163);
    }
  }

  private void cmdObsolete_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass0_0.bool_9)
        return;
      if (this.gclass230_0 != null)
      {
        if (this.gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID))
          this.gclass230_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 = !this.gclass230_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0;
      }
      else
      {
        if (this.gclass129_0 == null)
          return;
        if (this.gclass129_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID))
          this.gclass129_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 = !this.gclass129_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0;
      }
      this.method_3();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3164);
    }
  }

  private void TechnologyView_FormClosing(object sender, FormClosingEventArgs e)
  {
    try
    {
      this.gclass0_0.method_512(this.Name, this.Left, this.Top);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3165);
    }
  }

  private void TechnologyView_KeyDown(object sender, KeyEventArgs e)
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
      GClass226.smethod_74(ex, 3286);
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
    this.cboCategory = new ComboBox();
    this.chkObsolete = new CheckBox();
    this.chkShowCivilian = new CheckBox();
    this.chkTons = new CheckBox();
    this.lstvDisplayTech = new ListView();
    this.columnHeader_0 = new ColumnHeader();
    this.columnHeader_1 = new ColumnHeader();
    this.columnHeader_2 = new ColumnHeader();
    this.cmdRename = new Button();
    this.flowLayoutPanel2 = new FlowLayoutPanel();
    this.cmdObsolete = new Button();
    this.flowLayoutPanel1.SuspendLayout();
    this.flowLayoutPanel2.SuspendLayout();
    this.SuspendLayout();
    this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboRaces.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboRaces.FormattingEnabled = true;
    this.cboRaces.Location = new Point(0, 3);
    this.cboRaces.Margin = new Padding(0, 3, 3, 0);
    this.cboRaces.Name = "cboRaces";
    this.cboRaces.Size = new Size(248, 21);
    this.cboRaces.TabIndex = 40;
    this.cboRaces.SelectedIndexChanged += new EventHandler(this.cboRaces_SelectedIndexChanged);
    this.flowLayoutPanel1.Controls.Add((Control) this.cboRaces);
    this.flowLayoutPanel1.Controls.Add((Control) this.cboCategory);
    this.flowLayoutPanel1.Controls.Add((Control) this.chkObsolete);
    this.flowLayoutPanel1.Controls.Add((Control) this.chkShowCivilian);
    this.flowLayoutPanel1.Controls.Add((Control) this.chkTons);
    this.flowLayoutPanel1.Location = new Point(3, 3);
    this.flowLayoutPanel1.Name = "flowLayoutPanel1";
    this.flowLayoutPanel1.Size = new Size(1379, 27);
    this.flowLayoutPanel1.TabIndex = 41;
    this.cboCategory.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboCategory.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboCategory.FormattingEnabled = true;
    this.cboCategory.Location = new Point(254, 3);
    this.cboCategory.Margin = new Padding(3, 3, 3, 0);
    this.cboCategory.Name = "cboCategory";
    this.cboCategory.Size = new Size(248, 21);
    this.cboCategory.TabIndex = 41;
    this.cboCategory.SelectedIndexChanged += new EventHandler(this.cboCategory_SelectedIndexChanged);
    this.chkObsolete.AutoSize = true;
    this.chkObsolete.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.chkObsolete.Location = new Point(517, 5);
    this.chkObsolete.Margin = new Padding(12, 5, 3, 3);
    this.chkObsolete.Name = "chkObsolete";
    this.chkObsolete.Padding = new Padding(5, 0, 0, 0);
    this.chkObsolete.Size = new Size(162, 17);
    this.chkObsolete.TabIndex = 44;
    this.chkObsolete.Text = "Show Obsolete Technology";
    this.chkObsolete.TextAlign = ContentAlignment.MiddleRight;
    this.chkObsolete.UseVisualStyleBackColor = true;
    this.chkObsolete.CheckedChanged += new EventHandler(this.chkObsolete_CheckedChanged);
    this.chkShowCivilian.AutoSize = true;
    this.chkShowCivilian.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.chkShowCivilian.Location = new Point(694, 5);
    this.chkShowCivilian.Margin = new Padding(12, 5, 3, 3);
    this.chkShowCivilian.Name = "chkShowCivilian";
    this.chkShowCivilian.Padding = new Padding(5, 0, 0, 0);
    this.chkShowCivilian.Size = new Size(153, 17);
    this.chkShowCivilian.TabIndex = 45;
    this.chkShowCivilian.Text = "Show Civilian Technology";
    this.chkShowCivilian.TextAlign = ContentAlignment.MiddleRight;
    this.chkShowCivilian.UseVisualStyleBackColor = true;
    this.chkShowCivilian.CheckedChanged += new EventHandler(this.chkShowCivilian_CheckedChanged);
    this.chkTons.AutoSize = true;
    this.chkTons.Checked = true;
    this.chkTons.CheckState = CheckState.Checked;
    this.chkTons.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.chkTons.Location = new Point(862, 5);
    this.chkTons.Margin = new Padding(12, 5, 3, 3);
    this.chkTons.Name = "chkTons";
    this.chkTons.Padding = new Padding(5, 0, 0, 0);
    this.chkTons.Size = new Size(89, 17);
    this.chkTons.TabIndex = 46;
    this.chkTons.Text = "Size in Tons";
    this.chkTons.TextAlign = ContentAlignment.MiddleRight;
    this.chkTons.UseVisualStyleBackColor = true;
    this.chkTons.CheckedChanged += new EventHandler(this.chkTons_CheckedChanged);
    this.lstvDisplayTech.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstvDisplayTech.Columns.AddRange(new ColumnHeader[3]
    {
      this.columnHeader_0,
      this.columnHeader_1,
      this.columnHeader_2
    });
    this.lstvDisplayTech.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstvDisplayTech.FullRowSelect = true;
    this.lstvDisplayTech.HeaderStyle = ColumnHeaderStyle.None;
    this.lstvDisplayTech.Location = new Point(3, 30);
    this.lstvDisplayTech.Name = "lstvDisplayTech";
    this.lstvDisplayTech.Size = new Size(1379, 795);
    this.lstvDisplayTech.TabIndex = 106;
    this.lstvDisplayTech.UseCompatibleStateImageBehavior = false;
    this.lstvDisplayTech.View = View.Details;
    this.lstvDisplayTech.SelectedIndexChanged += new EventHandler(this.lstvDisplayTech_SelectedIndexChanged);
    this.columnHeader_0.Text = "";
    this.columnHeader_0.Width = 400;
    this.columnHeader_1.Text = "";
    this.columnHeader_1.TextAlign = HorizontalAlignment.Center;
    this.columnHeader_2.Text = "";
    this.columnHeader_2.TextAlign = HorizontalAlignment.Center;
    this.columnHeader_2.Width = 80 /*0x50*/;
    this.cmdRename.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdRename.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdRename.Location = new Point(0, 0);
    this.cmdRename.Margin = new Padding(0);
    this.cmdRename.Name = "cmdRename";
    this.cmdRename.Size = new Size(96 /*0x60*/, 30);
    this.cmdRename.TabIndex = 113;
    this.cmdRename.Tag = (object) "1200";
    this.cmdRename.Text = "Rename";
    this.cmdRename.UseVisualStyleBackColor = false;
    this.cmdRename.Click += new EventHandler(this.cmdRename_Click);
    this.flowLayoutPanel2.Controls.Add((Control) this.cmdRename);
    this.flowLayoutPanel2.Controls.Add((Control) this.cmdObsolete);
    this.flowLayoutPanel2.Location = new Point(3, 828);
    this.flowLayoutPanel2.Name = "flowLayoutPanel2";
    this.flowLayoutPanel2.Size = new Size(1379, 30);
    this.flowLayoutPanel2.TabIndex = 114;
    this.cmdObsolete.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdObsolete.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdObsolete.Location = new Point(96 /*0x60*/, 0);
    this.cmdObsolete.Margin = new Padding(0);
    this.cmdObsolete.Name = "cmdObsolete";
    this.cmdObsolete.Size = new Size(96 /*0x60*/, 30);
    this.cmdObsolete.TabIndex = 114;
    this.cmdObsolete.Tag = (object) "1200";
    this.cmdObsolete.Text = "Obsolete";
    this.cmdObsolete.UseVisualStyleBackColor = false;
    this.cmdObsolete.Click += new EventHandler(this.cmdObsolete_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.ClientSize = new Size(1384, 861);
    this.Controls.Add((Control) this.flowLayoutPanel2);
    this.Controls.Add((Control) this.lstvDisplayTech);
    this.Controls.Add((Control) this.flowLayoutPanel1);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.KeyPreview = true;
    this.Name = nameof (TechnologyView);
    this.Text = "View Technology";
    this.FormClosing += new FormClosingEventHandler(this.TechnologyView_FormClosing);
    this.Load += new EventHandler(this.TechnologyView_Load);
    this.KeyDown += new KeyEventHandler(this.TechnologyView_KeyDown);
    this.flowLayoutPanel1.ResumeLayout(false);
    this.flowLayoutPanel1.PerformLayout();
    this.flowLayoutPanel2.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
