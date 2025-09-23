// Decompiled with JetBrains decompiler
// Type: GClass65
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class GClass65
{
  public GClass200 gclass200_0;
  public GClass21 gclass21_0;
  public GClass21 gclass21_1;
  public GEnum10 genum10_0;
  public AuroraContactType auroraContactType_0;
  public GClass40 gclass40_0;
  public GClass132 gclass132_0;
  public GClass146 gclass146_0;
  private GClass0 gclass0_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  public int int_5;
  public Decimal decimal_0;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public Decimal decimal_3;
  public double double_0;
  public double double_1;
  public double double_2;
  public double double_3;
  public double double_4;
  public double double_5;
  public string string_0;
  public bool bool_0;
  public GClass110 gclass110_0;
  public string string_1 = "";

  public GClass65(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public string method_0()
  {
    try
    {
      GClass202 gclass202_0 = this.gclass21_1.method_128(this.gclass200_0);
      foreach (GClass146 gclass146 in this.gclass200_0.method_33(this.gclass21_1))
      {
        if (this.gclass0_0.method_520(this.double_0, gclass146.method_87(), this.double_1, gclass146.method_88()))
          return "Orbiting " + gclass146.PopName;
      }
      foreach (GClass120 gclass120 in this.gclass200_0.method_27())
      {
        if (gclass120.dictionary_0.ContainsKey(this.gclass21_1.RaceID) && gclass120.dictionary_0[this.gclass21_1.RaceID].int_2 == 1 && this.gclass0_0.method_520(this.double_0, gclass120.double_1, this.double_1, gclass120.double_2))
          return "Stationed at " + gclass120.method_8(gclass202_0);
      }
      foreach (GClass213 gclass213 in this.gclass200_0.dictionary_0.Values)
      {
        if (this.gclass0_0.method_520(this.double_0, gclass213.double_0, this.double_1, gclass213.double_1))
          return "Stationed at Survey Location #" + gclass213.int_2.ToString();
      }
      foreach (GClass1 gclass1 in this.gclass200_0.method_20())
      {
        if (this.gclass0_0.method_520(this.double_0, gclass1.double_0, this.double_1, gclass1.double_1))
          return "Orbiting " + gclass1.method_78(this.gclass21_1);
      }
      return this.gclass200_0.method_22(this.double_0, this.double_1, gclass202_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 898);
      return "None";
    }
  }

  public Decimal method_1()
  {
    try
    {
      return this.decimal_2 == 0M ? this.decimal_1 : this.decimal_2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 457);
      return this.gclass0_0.decimal_0;
    }
  }

  public bool method_2()
  {
    try
    {
      return this.auroraContactType_0 == AuroraContactType.Population || this.auroraContactType_0 == AuroraContactType.Salvo || this.auroraContactType_0 == AuroraContactType.GroundUnit || this.auroraContactType_0 == AuroraContactType.STOGroundUnit || this.auroraContactType_0 == AuroraContactType.Shipyard || this.auroraContactType_0 == AuroraContactType.Ship && (this.gclass40_0.gclass187_0 == null || !this.gclass21_1.dictionary_10.ContainsKey(this.gclass21_0.RaceID) || !this.gclass21_1.dictionary_10[this.gclass21_0.RaceID].bool_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 458);
      return false;
    }
  }

  public int method_3()
  {
    try
    {
      return this.gclass21_0 == null ? 0 : this.gclass21_0.RaceID;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 459);
      return 0;
    }
  }

  public string method_4()
  {
    try
    {
      string str1 = "";
      if (this.gclass21_0 != null)
        str1 = $"[{this.gclass21_1.dictionary_10[this.gclass21_0.RaceID].string_0}]  ";
      string str2;
      if (this.auroraContactType_0 == AuroraContactType.Ship)
        str2 = str1 + this.gclass40_0.method_226(this.gclass21_1, false, 0);
      else if (this.auroraContactType_0 == AuroraContactType.Salvo)
        str2 = this.gclass132_0.method_18(this.gclass21_1, true);
      else if (this.auroraContactType_0 == AuroraContactType.Population)
        str2 = str1 + this.gclass146_0.method_80(this.gclass21_1);
      else if (this.auroraContactType_0 == AuroraContactType.GroundUnit)
      {
        string str3 = this.gclass21_1.method_42(this.gclass146_0);
        str2 = $"{str1}{str3} - Ground Forces Signature: {GClass226.smethod_39(this.decimal_0 * 100M)} tons";
      }
      else if (this.auroraContactType_0 == AuroraContactType.STOGroundUnit)
      {
        string str4 = this.gclass21_1.method_42(this.gclass146_0);
        str2 = $"{str1}{str4} - STO Ground Forces Signature {GClass226.smethod_39(this.decimal_0 * 100M)} tons";
      }
      else if (this.auroraContactType_0 == AuroraContactType.Shipyard)
      {
        string str5 = this.gclass21_1.method_42(this.gclass146_0);
        str2 = $"{str1}{str5} - Shipyard Complex Signature {this.decimal_0.ToString()}";
      }
      else
        str2 = this.auroraContactType_0 == AuroraContactType.Explosion || this.auroraContactType_0 == AuroraContactType.EWImpact ? $"{GClass226.smethod_37(this.int_2)}x {this.string_0}" : this.string_0;
      return str2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 460);
      return "error";
    }
  }

  public AuroraContactStatus method_5()
  {
    try
    {
      return this.gclass21_0 == null || !this.gclass21_1.dictionary_10.ContainsKey(this.gclass21_0.RaceID) ? AuroraContactStatus.None : this.gclass21_1.dictionary_10[this.gclass21_0.RaceID].auroraContactStatus_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 461);
      return AuroraContactStatus.None;
    }
  }

  public AuroraCommStatus method_6()
  {
    try
    {
      return this.gclass21_0 == null || !this.gclass21_1.dictionary_10.ContainsKey(this.gclass21_0.RaceID) ? AuroraCommStatus.CommunicationImpossible : this.gclass21_1.dictionary_10[this.gclass21_0.RaceID].auroraCommStatus_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 462);
      return AuroraCommStatus.CommunicationImpossible;
    }
  }

  public bool method_7(
    Graphics graphics_0,
    Font font_0,
    GClass222 gclass222_0,
    GClass202 gclass202_0,
    int int_6)
  {
    try
    {
      if (gclass202_0.gclass21_0.chkActiveOnly == CheckState.Checked && this.genum10_0 != GEnum10.const_0)
        return false;
      AuroraContactStatus auroraContactStatus_0 = AuroraContactStatus.Hostile;
      string str1 = "";
      if (this.gclass21_0 != null)
      {
        auroraContactStatus_0 = this.gclass21_1.dictionary_10[this.gclass21_0.RaceID].auroraContactStatus_0;
        str1 = $"[{gclass202_0.gclass21_0.dictionary_10[this.gclass21_0.RaceID].string_0}]  ";
      }
      if (!gclass202_0.gclass21_0.method_319(auroraContactStatus_0))
        return false;
      SolidBrush solidBrush = new SolidBrush(GClass226.color_6);
      Pen pen = new Pen(GClass226.color_6);
      solidBrush.Color = GClass226.smethod_81(auroraContactStatus_0);
      pen.Color = solidBrush.Color;
      double x = gclass222_0.double_2 - (double) (GClass226.int_61 / 2);
      double y = gclass222_0.double_3 - (double) (GClass226.int_61 / 2);
      if (this.decimal_3 == this.gclass0_0.decimal_0 && (this.double_4 != 0.0 || this.double_5 != 0.0))
      {
        GClass221 gclass221_1 = new GClass221();
        GClass221 gclass221_2 = gclass202_0.method_47(this.double_4, this.double_5);
        graphics_0.DrawLine(pen, (float) gclass222_0.double_2, (float) gclass222_0.double_3, (float) gclass221_2.double_0, (float) gclass221_2.double_1);
      }
      if (int_6 == 0)
        graphics_0.FillEllipse((Brush) solidBrush, (float) x, (float) y, (float) GClass226.int_61, (float) GClass226.int_61);
      string str2 = this.string_0;
      if (gclass202_0.gclass21_0.chkShowDist == CheckState.Checked && (gclass202_0.gclass221_0.double_0 != 0.0 || gclass202_0.gclass221_0.double_1 != 0.0))
      {
        double num = this.gclass0_0.method_28(gclass202_0.gclass221_0.double_0, gclass202_0.gclass221_0.double_1, gclass222_0.double_0, gclass222_0.double_1);
        str2 = $"{str2}  {GClass226.smethod_50(num / 1000000.0)}m";
      }
      GClass221 gclass221 = new GClass221();
      gclass221.double_0 = x + (double) GClass226.int_61 + 5.0;
      gclass221.double_1 = y - 3.0 - (double) (int_6 * 15);
      graphics_0.DrawString(str1 + str2, font_0, (Brush) solidBrush, (float) gclass221.double_0, (float) gclass221.double_1);
      pen.Dispose();
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 463);
      return false;
    }
  }

  public bool method_8(Graphics graphics_0, Font font_0, GClass222 gclass222_0, int int_6)
  {
    try
    {
      SolidBrush solidBrush = new SolidBrush(GClass226.color_6);
      Pen pen = new Pen(GClass226.color_6, 2f);
      graphics_0.DrawLine(pen, (float) gclass222_0.double_2, (float) gclass222_0.double_3 - 8f, (float) gclass222_0.double_2, (float) gclass222_0.double_3 + 8f);
      graphics_0.DrawLine(pen, (float) gclass222_0.double_2 - 8f, (float) gclass222_0.double_3, (float) gclass222_0.double_2 + 8f, (float) gclass222_0.double_3);
      graphics_0.DrawLine(pen, (float) gclass222_0.double_2 - 6f, (float) gclass222_0.double_3 - 6f, (float) gclass222_0.double_2 + 6f, (float) gclass222_0.double_3 + 6f);
      graphics_0.DrawLine(pen, (float) gclass222_0.double_2 + 6f, (float) gclass222_0.double_3 - 6f, (float) gclass222_0.double_2 - 6f, (float) gclass222_0.double_3 + 6f);
      double num1 = gclass222_0.double_2 - (double) (GClass226.int_61 / 2);
      double num2 = gclass222_0.double_3 - (double) (GClass226.int_61 / 2);
      GClass221 gclass221 = new GClass221();
      gclass221.double_0 = num1 + (double) GClass226.int_61 + 5.0;
      gclass221.double_1 = num2 - 3.0 - (double) (int_6 * 15);
      graphics_0.DrawString($"{GClass226.smethod_37(this.int_2)}x {this.string_0}", font_0, (Brush) solidBrush, (float) gclass221.double_0, (float) gclass221.double_1);
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 464);
      return false;
    }
  }
}
