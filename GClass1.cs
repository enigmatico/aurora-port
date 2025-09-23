// Decompiled with JetBrains decompiler
// Type: GClass1
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public partial class GClass1
{
  public Dictionary<AuroraElement, GClass124> dictionary_0 = new Dictionary<AuroraElement, GClass124>();
  public Dictionary<int, GClass218> dictionary_1 = new Dictionary<int, GClass218>();
  public List<GClass224> list_0 = new List<GClass224>();
  public Dictionary<AuroraElement, Decimal> dictionary_2 = new Dictionary<AuroraElement, Decimal>();
  private GClass0 gclass0_0;
  public GClass1 gclass1_0;
  public GClass1 gclass1_1;
  public GClass197 gclass197_0;
  public GClass200 gclass200_0;
  public GClass171 gclass171_0;
  public GClass174 gclass174_0;
  public GClass220 gclass220_0;
  public GClass194 gclass194_0;
  public GEnum12 genum12_0;
  public AuroraSystemBodyType auroraSystemBodyType_0;
  public GEnum2 genum2_0;
  public AuroraHydrosphereType auroraHydrosphereType_0;
  public AuroraTectonics auroraTectonics_0;
  public GClass99 gclass99_0;
  public GEnum5 genum5_0 = GEnum5.const_2;
  public AuroraGroundMineralSurvey auroraGroundMineralSurvey_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  public int int_5;
  public int int_6;
  public int int_7;
  public int int_8;
  public int int_9;
  public int int_10;
  public int int_11;
  public Decimal decimal_0 = -2M;
  public Decimal decimal_1 = -2M;
  public Decimal decimal_2;
  public Decimal decimal_3;
  public Decimal decimal_4;
  public Decimal decimal_5;
  public double double_0;
  public double double_1;
  public double double_2;
  public double double_3;
  public double double_4;
  public double double_5;
  public double double_6;
  public double double_7;
  public double double_8;
  public double double_9;
  public double double_10;
  public double double_11;
  public double double_12;
  public double double_13;
  public double double_14;
  public double double_15;
  public double double_16 = 1.0;
  public double double_17 = 1.0;
  public double double_18 = 1.0;
  public double double_19;
  public double double_20;
  public double double_21;
  public double double_22;
  public double double_23;
  public double double_24;
  public double double_25;
  public double double_26;
  public double double_27;
  public double double_28;
  public double double_29;
  public double double_30;
  public double double_31;
  public double double_32;
  public double double_33;
  public double double_34 = -2.0;
  public double double_35 = -2.0;
  public double double_36;
  public double double_37;
  public bool bool_0;
  public bool bool_1;
  public bool bool_2;
  public string string_0;
  public string string_1;
  public List<AuroraSystemBodyType> list_1 = new List<AuroraSystemBodyType>();
  public GEnum4 genum4_0;
  public int int_12;
  public double double_38;
  public double double_39;
  public double double_40;
  public double double_41;
  public bool bool_3;
  public bool bool_4;
  public bool bool_5;
  public bool bool_6;
  public bool bool_7;
  public bool bool_8;
  public Decimal decimal_6;
  public Decimal decimal_7;
  public string string_2 = "";
  public double double_42;
  public double double_43;
  public double double_44;
  public Decimal decimal_8 = 1M;
  public bool bool_9;
  public Decimal decimal_9;

  public GClass1(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public void method_0(
    ListView listView_0,
    GClass21 gclass21_0,
    GClass194 gclass194_1,
    int int_13)
  {
    try
    {
      listView_0.Items.Clear();
      if (this.double_24 == 0.0)
        return;
      this.gclass0_0.method_624(listView_0, "Period", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", (object) null);
      switch (int_13)
      {
        case 7:
          listView_0.Columns[8].Width = 0;
          listView_0.Columns[9].Width = 0;
          listView_0.Columns[10].Width = 0;
          listView_0.Columns[11].Width = 0;
          listView_0.Columns[12].Width = 0;
          break;
        case 8:
          listView_0.Columns[8].Width = 50;
          listView_0.Columns[9].Width = 0;
          listView_0.Columns[10].Width = 0;
          listView_0.Columns[11].Width = 0;
          listView_0.Columns[12].Width = 0;
          break;
        case 12:
          listView_0.Columns[8].Width = 50;
          listView_0.Columns[9].Width = 50;
          listView_0.Columns[10].Width = 50;
          listView_0.Columns[11].Width = 50;
          listView_0.Columns[12].Width = 50;
          break;
      }
      double num1 = this.double_10 * 3600.0;
      double double_45_1 = 604800.0;
      string text = "Week";
      if (this.genum12_0 == GEnum12.const_2)
        num1 = this.gclass1_0.double_10 * 3600.0;
      do
      {
        List<double> doubleList1 = new List<double>();
        List<double> doubleList2 = new List<double>();
        double num2 = 0.0;
        foreach (double double_45_2 in this.genum12_0 != GEnum12.const_2 ? this.method_1(gclass21_0, gclass194_1, double_45_1, int_13) : this.gclass1_0.method_1(gclass21_0, gclass194_1, double_45_1, int_13))
        {
          double num3 = this.method_52(gclass21_0, gclass194_1, double_45_2, GEnum81.const_0);
          doubleList2.Add(num3);
        }
        ListViewItem listViewItem = new ListViewItem(text);
        foreach (double double_32 in doubleList2)
        {
          listViewItem.SubItems.Add(GClass226.smethod_46(double_32, 2));
          num2 += double_45_1;
          if (num2 > num1)
            break;
        }
        listView_0.Items.Add(listViewItem);
        switch (text)
        {
          case "Week":
            text = "Month";
            double_45_1 = (double) GClass226.decimal_29 / 12.0;
            break;
          case "Month":
            text = "Quarter";
            double_45_1 = (double) GClass226.decimal_29 / 4.0;
            break;
          case "Quarter":
            text = "Year";
            double_45_1 = (double) GClass226.decimal_29;
            break;
          case "Year":
            text = "5Y";
            double_45_1 = (double) GClass226.decimal_29 * 5.0;
            break;
          case "5Y":
            text = "25Y";
            double_45_1 = (double) GClass226.decimal_29 * 25.0;
            break;
          case "25Y":
            text = "100Y";
            double_45_1 = (double) GClass226.decimal_29 * 100.0;
            break;
          default:
            goto label_25;
        }
      }
      while (double_45_1 <= num1);
      goto label_15;
label_25:
      return;
label_15:;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3461);
    }
  }

  public List<double> method_1(
    GClass21 gclass21_0,
    GClass194 gclass194_1,
    double double_45,
    int int_13)
  {
    try
    {
      List<double> doubleList = new List<double>();
      double num1 = this.double_10 * 3600.0;
      double double5 = this.double_5;
      double double37 = this.double_37;
      double double36 = this.double_36;
      double num2 = this.double_22;
      for (int index = 0; index < int_13; ++index)
      {
        if (this.double_23 == 0.0)
          this.double_23 = num2;
        double num3 = num2 / this.double_23;
        double num4 = double_45 / num1 * num3;
        double5 -= num4 * 360.0;
        while (double5 < 0.0)
          double5 += 360.0;
        double num5;
        if (double5 != 0.0 && double5 != 180.0)
        {
          if (double5 != 90.0 && double5 != 270.0)
          {
            double num6 = 360.0 - this.double_5 + 90.0;
            if (num6 < 0.0)
              num6 += 360.0;
            if (num6 == 360.0)
              num6 = 0.0;
            if (num6 > 360.0)
              num6 -= 360.0;
            num5 = this.double_2 * this.double_26 / Math.Sqrt(Math.Pow(this.double_26 * Math.Cos(num6 * Math.PI / 180.0), 2.0) + Math.Pow(this.double_2 * Math.Sin(num6 * Math.PI / 180.0), 2.0));
          }
          else
            num5 = this.double_2;
        }
        else
          num5 = this.double_26;
        double num7 = double5 - 90.0;
        if (num7 < 0.0)
          num7 += 360.0;
        double double25 = this.double_25;
        if (double25 < 0.0)
          double25 += 360.0;
        double num8 = double25 * (Math.PI / 180.0);
        double num9 = (this.double_28 - this.double_27) / 2.0;
        double num10 = this.gclass197_0.double_0 + num9 * GClass226.double_14 * Math.Cos(num8);
        double num11 = this.gclass197_0.double_1 + num9 * GClass226.double_14 * Math.Sin(num8);
        double num12 = num7 + this.double_25;
        if (num12 >= 360.0)
          num12 -= 360.0;
        double num13 = num12 * (Math.PI / 180.0);
        double double_8 = num10 + num5 * GClass226.double_14 * Math.Cos(num13);
        double num14 = num5 * GClass226.double_14 * Math.Sin(num13);
        double double_9 = num11 + num14;
        double num15 = this.gclass0_0.method_28(double_8, double_9, this.gclass197_0.double_0, this.gclass197_0.double_1) / GClass226.double_14;
        num2 = Math.Sqrt(2.0 / num15 - 1.0 / this.double_2);
        doubleList.Add(num15);
      }
      return doubleList;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3459);
      return (List<double>) null;
    }
  }

  public void method_2(GClass1 gclass1_2)
  {
    try
    {
      if (gclass1_2.double_20 < 1000.0)
        this.list_1.Add(AuroraSystemBodyType.Moon);
      else if (gclass1_2.double_20 < 2000.0)
        this.list_1.Add(AuroraSystemBodyType.LargeMoon);
      else if (gclass1_2.double_20 < 3000.0)
        this.list_1.Add(AuroraSystemBodyType.SmallTerrestrial);
      else
        this.list_1.Add(AuroraSystemBodyType.TerrestrialMoon);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3448);
    }
  }

  public void method_3(GEnum12 genum12_1)
  {
    try
    {
      this.double_27 = this.double_2;
      this.double_28 = this.double_2;
      this.double_26 = this.double_2;
      if (this.gclass0_0.int_85 == 0)
      {
        this.double_24 = 0.0;
        this.double_25 = 0.0;
      }
      else
      {
        double double6 = this.gclass197_0.double_6;
        if (this.gclass197_0.int_3 == 1)
          double6 *= 1.5;
        double num1 = 0.999;
        if (double6 < this.double_2 * 2.0)
          num1 = double6 / this.double_2 - 1.0;
        this.double_25 = (double) (GClass226.smethod_13(3600) / 10);
        int num2 = 0;
        do
        {
          int num3 = GClass226.smethod_13(10);
          switch (genum12_1)
          {
            case GEnum12.const_1:
              this.double_24 = num3 >= 6 ? (num3 >= 8 ? (num3 >= 10 ? 0.25 + (double) GClass226.smethod_13(10) * 0.04 : 0.15 + (double) GClass226.smethod_13(10) * 0.01) : 0.05 + (double) GClass226.smethod_13(10) * 0.01) : (double) GClass226.smethod_13(10) * 0.005;
              break;
            case GEnum12.const_3:
              this.double_24 = num3 >= 6 ? (num3 >= 8 ? (num3 >= 10 ? 0.4 + (double) GClass226.smethod_13(40) * 0.01 : 0.3 + (double) GClass226.smethod_13(10) * 0.01) : 0.2 + (double) GClass226.smethod_13(10) * 0.01) : (double) GClass226.smethod_13(20) * 0.01;
              break;
            case GEnum12.const_5:
              switch (num3)
              {
                case 1:
                  this.double_24 = 0.5 + (double) GClass226.smethod_13(10) * 0.01;
                  break;
                case 2:
                  this.double_24 = 0.6 + (double) GClass226.smethod_13(10) * 0.01;
                  break;
                case 3:
                  this.double_24 = 0.7 + (double) GClass226.smethod_13(10) * 0.01;
                  break;
                default:
                  this.double_24 = num3 >= 6 ? (num3 >= 9 ? 0.99 + (double) GClass226.smethod_13(9) * 0.001 : 0.9 + (double) GClass226.smethod_13(9) * 0.01) : 0.8 + (double) GClass226.smethod_13(10) * 0.01;
                  break;
              }
              break;
          }
          this.double_27 = this.double_2 * (1.0 - this.double_24);
          this.double_28 = this.double_2 * (1.0 + this.double_24);
          if (genum12_1 != GEnum12.const_5 && (this.double_27 <= this.gclass197_0.gclass217_0.double_2 * GClass226.double_7 || this.double_28 >= double6 && double6 != 0.0))
            ++num2;
          else
            goto label_18;
        }
        while (num2 != 10);
        this.double_24 = num1;
        this.double_27 = this.double_2 * (1.0 - this.double_24);
        this.double_28 = this.double_2 * (1.0 + this.double_24);
label_18:
        this.double_26 = this.double_2 * Math.Sqrt(1.0 - this.double_24 * this.double_24);
        this.method_5();
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3446);
    }
  }

  public void method_4()
  {
    try
    {
      int num = 0;
      if (this.double_24 > 0.95)
        this.double_24 = 0.95;
      double double6 = this.gclass197_0.double_6;
      if (this.gclass197_0.int_3 == 1)
        double6 *= 1.5;
      do
      {
        this.double_27 = this.double_2 * (1.0 - this.double_24);
        this.double_28 = this.double_2 * (1.0 + this.double_24);
        if (this.double_27 <= this.gclass197_0.gclass217_0.double_2 * GClass226.double_7 || this.double_28 >= double6 && double6 != 0.0)
        {
          this.double_24 -= 0.01;
          ++num;
        }
        else
          goto label_7;
      }
      while (num != 100);
      this.double_24 = 0.0;
label_7:
      this.double_26 = this.double_2 * Math.Sqrt(1.0 - this.double_24 * this.double_24);
      this.method_5();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3446);
    }
  }

  public void method_5()
  {
    try
    {
      this.double_23 = Math.Sqrt(2.0 / this.double_2 - 1.0 / this.double_2);
      this.double_22 = this.double_23;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3443);
    }
  }

  public void method_6()
  {
    try
    {
      this.double_22 = Math.Sqrt(2.0 / this.double_37 - 1.0 / this.double_2);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3444);
    }
  }

  public void method_7()
  {
    try
    {
      if (this.double_5 != 0.0 && this.double_5 != 180.0)
      {
        if (this.double_5 != 90.0 && this.double_5 != 270.0)
        {
          double num = 360.0 - this.double_5 + 90.0;
          if (num < 0.0)
            num += 360.0;
          if (num >= 360.0)
            num -= 360.0;
          this.double_36 = this.double_2 * this.double_26 / Math.Sqrt(Math.Pow(this.double_26 * Math.Cos(num * Math.PI / 180.0), 2.0) + Math.Pow(this.double_2 * Math.Sin(num * Math.PI / 180.0), 2.0));
        }
        else
          this.double_36 = this.double_2;
      }
      else
        this.double_36 = this.double_26;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3450);
    }
  }

  public void method_8(bool bool_10)
  {
    try
    {
      if (this.genum5_0 != GEnum5.const_2)
        this.genum5_0 = GEnum5.const_1;
      if (bool_10)
      {
        this.double_8 = Math.Pow(this.double_20 / 6380.0, 3.0) * this.double_6;
        this.double_7 = this.double_8 / Math.Pow(this.double_20 / 6380.0, 2.0);
        if (this.double_7 < 0.0001)
          this.double_7 = 0.0001;
        this.double_9 = Math.Pow(19600.0 * this.double_7 * this.double_20, 0.5) / 11200.0;
      }
      this.bool_0 = false;
      if (this.genum12_0 != GEnum12.const_2)
      {
        this.double_10 = Math.Pow(Math.Pow(this.double_2, 3.0) / this.gclass197_0.gclass217_0.double_1, 0.5) * 8760.0;
        this.double_11 = this.gclass197_0.gclass217_0.double_1 * 26640000.0 / Math.Pow(this.double_2 * 400.0, 3.0);
        if (this.double_10 == 0.0)
          this.double_10 = 1.0;
        if ((0.83 + (double) GClass226.smethod_13(10) * 0.03) * this.double_11 * this.gclass200_0.double_0 / 6.6 > 1.0)
          this.bool_0 = true;
        this.double_3 = (double) byte.MaxValue / Math.Pow(this.double_37 / Math.Pow(this.gclass197_0.double_4, 0.5), 0.5);
        if (this.double_3 < 4.0)
          this.double_3 = 4.0;
      }
      else
      {
        this.double_10 = Math.Pow(Math.Pow(this.double_2 / 398600.0, 3.0) * (837.0 / (this.double_8 + this.gclass1_0.double_8)), 0.5) * 24.0;
        if (this.double_10 == 0.0)
          this.double_10 = 1.0;
        this.double_11 = this.gclass1_0.double_8 * 80.0 / Math.Pow(this.double_2 / 375000.0, 3.0);
        if (this.double_11 > 7.0)
          this.bool_0 = true;
        this.double_3 = this.gclass1_0.double_3;
      }
      if (this.bool_0)
        this.int_7 = 0;
      this.method_36((GClass21) null);
      this.method_35();
      this.method_32();
      this.method_41(this.double_5);
      GClass212 gclass212 = this.gclass0_0.dictionary_14.Values.FirstOrDefault<GClass212>((Func<GClass212, bool>) (gclass212_0 => gclass212_0.gclass1_0 == this));
      gclass212?.method_1(gclass212.gclass1_0.double_5 + 60.0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3004);
    }
  }

  public void method_9(GClass223 gclass223_0, double double_45, GClass146 gclass146_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass1.Class308 class308 = new GClass1.Class308();
    // ISSUE: reference to a compiler-generated field
    class308.gclass223_0 = gclass223_0;
    try
    {
      GClass21 gclass21_0 = (GClass21) null;
      // ISSUE: reference to a compiler-generated method
      GClass224 gclass224 = this.list_0.Where<GClass224>(new Func<GClass224, bool>(class308.method_0)).FirstOrDefault<GClass224>();
      if (double_45 == 0.0)
      {
        if (gclass224 == null)
          return;
        this.list_0.Remove(gclass224);
      }
      else if (gclass224 == null)
      {
        // ISSUE: reference to a compiler-generated field
        this.list_0.Add(new GClass224()
        {
          gclass223_0 = class308.gclass223_0,
          int_0 = this.int_0,
          double_1 = double_45,
          double_0 = 0.0,
          bool_0 = false
        });
      }
      else
        gclass224.double_1 = double_45;
      this.method_46();
      if (gclass146_0 != null)
      {
        this.method_58(gclass146_0.gclass21_0, gclass146_0.gclass194_0, false);
        gclass146_0.decimal_18 = this.decimal_0;
        gclass146_0.decimal_19 = this.decimal_1;
        gclass146_0.method_184();
        gclass21_0 = gclass146_0.gclass21_0;
      }
      this.method_36(gclass21_0);
      this.method_35();
      this.method_32();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3005);
    }
  }

  public void method_10()
  {
    try
    {
      double num1 = this.double_19 / GClass226.double_27;
      GClass224 gclass224 = this.list_0.FirstOrDefault<GClass224>((Func<GClass224, bool>) (gclass224_0 => gclass224_0.gclass223_0.genum47_0 == GEnum47.const_5));
      if (gclass224 == null)
      {
        this.list_0.Add(new GClass224()
        {
          gclass223_0 = this.gclass0_0.dictionary_23[GEnum47.const_5],
          int_0 = this.int_0,
          double_1 = num1,
          double_0 = 0.0,
          bool_0 = false
        });
        this.double_15 += num1;
      }
      else if (gclass224.double_1 < num1)
      {
        double num2 = num1 - gclass224.double_1;
        gclass224.double_1 += num2;
        this.double_15 += num2;
        if (this.double_15 < 0.0)
          this.double_15 = 0.0;
      }
      this.double_19 = 0.0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3006);
    }
  }

  public void method_11()
  {
    try
    {
      GClass224 gclass224 = this.list_0.FirstOrDefault<GClass224>((Func<GClass224, bool>) (gclass224_0 => gclass224_0.gclass223_0.genum47_0 == GEnum47.const_5));
      if (gclass224 == null)
        return;
      double num1 = this.double_15 * (this.double_19 / 100.0) * GClass226.double_26;
      if (gclass224.double_1 <= num1)
        return;
      double num2 = gclass224.double_1 - num1;
      gclass224.double_1 -= num2;
      this.double_19 += num2 * GClass226.double_27;
      this.double_15 -= num2;
      if (this.double_15 < 0.0)
        this.double_15 = 0.0;
      if (gclass224.double_1 > 0.0)
        return;
      this.list_0.Remove(gclass224);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3007);
    }
  }

  public void method_12(GEnum59 genum59_0, GEnum59 genum59_1, GClass21 gclass21_0)
  {
    try
    {
      this.decimal_6 = 0M;
      this.decimal_7 = 0M;
      switch (genum59_0)
      {
        case GEnum59.const_1:
          this.decimal_6 = (Decimal) this.double_2;
          break;
        case GEnum59.const_2:
          this.decimal_6 = this.decimal_0;
          break;
        case GEnum59.const_3:
          this.decimal_6 = (Decimal) this.double_19;
          break;
        case GEnum59.const_4:
          if (this.method_77(gclass21_0))
          {
            this.decimal_6 = this.dictionary_0.Values.Sum<GClass124>((Func<GClass124, Decimal>) (gclass124_0 => gclass124_0.decimal_0));
            break;
          }
          break;
      }
      switch (genum59_1)
      {
        case GEnum59.const_1:
          this.decimal_7 = (Decimal) this.double_2;
          break;
        case GEnum59.const_2:
          this.decimal_7 = this.decimal_0;
          break;
        case GEnum59.const_3:
          this.decimal_7 = (Decimal) this.double_19;
          break;
        case GEnum59.const_4:
          if (this.method_77(gclass21_0))
          {
            this.decimal_7 = this.dictionary_0.Values.Sum<GClass124>((Func<GClass124, Decimal>) (gclass124_0 => gclass124_0.decimal_0));
            break;
          }
          break;
      }
      this.string_2 = gclass21_0.method_277(this.gclass200_0.int_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3008);
    }
  }

  public bool method_13()
  {
    try
    {
      foreach (GClass224 gclass224 in this.list_0)
      {
        if (gclass224.gclass223_0.genum47_0 == GEnum47.const_10)
          return true;
      }
      return false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3009);
      return false;
    }
  }

  public bool method_14(GClass194 gclass194_1)
  {
    try
    {
      foreach (GClass224 gclass224 in this.list_0)
      {
        if (gclass224.gclass223_0.int_0 > 0 && gclass224.gclass223_0 != gclass194_1.gclass223_0)
          return true;
      }
      return false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3835);
      return false;
    }
  }

  public int method_15(double double_45)
  {
    try
    {
      this.double_2 -= double_45;
      GClass212 gclass212 = this.gclass0_0.dictionary_14.Values.FirstOrDefault<GClass212>((Func<GClass212, bool>) (gclass212_0 => gclass212_0.gclass1_0 == this));
      if (gclass212 != null)
        gclass212.double_2 = this.double_2;
      if (this.double_2 * GClass226.double_14 < 1000000.0)
      {
        foreach (GClass146 gclass146_1 in this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass1_0 == this || gclass146_0.gclass1_0.gclass1_0 == this)).ToList<GClass146>())
        {
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_192, gclass146_1.PopName + " has been destroyed due to the destruction of the body on which it is based", gclass146_1.gclass21_0, this.gclass200_0, this.double_0, this.double_1, AuroraEventCategory.PopSummary);
          gclass146_1.gclass21_0.method_132(gclass146_1);
        }
        if (gclass212 != null)
          this.gclass0_0.dictionary_14.Remove(gclass212.int_0);
        return -1;
      }
      this.double_10 = Math.Pow(Math.Pow(this.double_2, 3.0) / this.gclass197_0.gclass217_0.double_1, 0.5) * 8760.0;
      this.gclass0_0.method_414(10.0, (GClass200) null, this, true);
      foreach (GClass1 gclass1 in this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_2 => gclass1_2.gclass1_0 == this)).ToList<GClass1>())
      {
        gclass1.double_3 = this.double_3;
        gclass1.method_27();
      }
      return 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3010);
      return 0;
    }
  }

  public bool method_16(int int_13, bool bool_10)
  {
    try
    {
      if (!this.gclass197_0.method_6(int_13))
        return false;
      return this.genum12_0 != GEnum12.const_3 && this.genum12_0 != GEnum12.const_5 ? (this.genum12_0 == GEnum12.const_1 ? bool_10 && this.double_28 < (double) int_13 || this.double_28 < (double) int_13 && this.auroraSystemBodyType_0 != AuroraSystemBodyType.GasGiant && this.auroraSystemBodyType_0 != AuroraSystemBodyType.Superjovian : (this.genum12_0 == GEnum12.const_2 ? this.gclass1_0.double_2 < (double) int_13 : this.genum12_0 == GEnum12.const_5 && this.double_28 < (double) int_13)) : this.double_28 < (double) int_13;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3011);
      return false;
    }
  }

  public double method_17()
  {
    try
    {
      if (this.dictionary_0.Count == 0 || this.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || this.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian)
        return 0.0;
      double num = 0.0;
      foreach (GClass124 gclass124 in this.dictionary_0.Values)
      {
        if (!(gclass124.decimal_0 < 1000M))
        {
          double decimal1 = (double) gclass124.decimal_1;
          if (gclass124.decimal_0 > 1000000M)
            decimal1 *= 2.0;
          else if (gclass124.decimal_0 > 100000M)
            decimal1 *= 1.5;
          else if (gclass124.decimal_0 > 10000M)
            decimal1 *= 1.25;
          num += decimal1;
        }
      }
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3012);
      return 0.0;
    }
  }

  public Decimal method_18()
  {
    try
    {
      return this.dictionary_0.Values.Sum<GClass124>((Func<GClass124, Decimal>) (gclass124_0 => gclass124_0.decimal_1));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3013);
      return 0M;
    }
  }

  public GClass124 method_19(AuroraElement auroraElement_0)
  {
    try
    {
      return !this.dictionary_0.ContainsKey(auroraElement_0) ? (GClass124) null : this.dictionary_0[auroraElement_0];
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3014);
      return (GClass124) null;
    }
  }

  public Decimal method_20(AuroraElement auroraElement_0)
  {
    try
    {
      return !this.dictionary_0.ContainsKey(auroraElement_0) ? 0M : this.dictionary_0[auroraElement_0].decimal_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3015);
      return 0M;
    }
  }

  public Decimal method_21(AuroraElement auroraElement_0)
  {
    try
    {
      return !this.dictionary_0.ContainsKey(auroraElement_0) ? 0M : this.dictionary_0[auroraElement_0].decimal_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3016);
      return 0M;
    }
  }

  public GClass194 method_22(
    bool bool_10,
    GClass21 gclass21_0,
    GEnum6 genum6_0,
    GClass143 gclass143_0)
  {
    try
    {
      double num1;
      double num2;
      if (this.genum12_0 == GEnum12.const_2)
      {
        num1 = this.method_53(this.gclass1_0.double_28);
        num2 = this.method_53(this.gclass1_0.double_27);
      }
      else
      {
        num1 = this.method_53(this.double_28);
        num2 = this.method_53(this.double_27);
      }
      double num3 = (num1 + num2) / 2.0;
      double num4 = num2 - num3 + 1.0;
      GClass194 gclass194 = new GClass194(this.gclass0_0)
      {
        int_0 = this.gclass0_0.method_26(GEnum0.const_12),
        gclass223_0 = this.gclass0_0.dictionary_23[GEnum47.const_10]
      };
      gclass194.double_0 = this.method_45(gclass194.gclass223_0);
      gclass194.double_3 = num3;
      gclass194.double_5 = this.double_7;
      gclass194.gclass1_0 = this;
      gclass194.genum6_0 = genum6_0;
      if (gclass143_0 != null)
      {
        gclass194.int_7 = gclass143_0.int_5;
        gclass194.int_3 = gclass143_0.int_1;
        gclass194.int_5 = gclass143_0.int_3;
        gclass194.int_6 = gclass143_0.int_4;
        gclass194.int_2 = gclass143_0.int_0;
        gclass194.int_8 = gclass143_0.int_6;
        gclass194.int_4 = gclass143_0.int_2;
      }
      else
      {
        gclass194.int_7 = GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25);
        gclass194.int_3 = GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25);
        gclass194.int_5 = GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25);
        gclass194.int_6 = GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25);
        gclass194.int_2 = GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25);
        gclass194.int_8 = GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25);
        gclass194.int_4 = GClass226.smethod_21(5) + GClass226.smethod_13(6) - 31 /*0x1F*/;
      }
      if (gclass21_0.bool_0 && genum6_0 == GEnum6.const_0)
      {
        gclass194.int_2 += this.gclass0_0.int_116;
        gclass194.int_5 += this.gclass0_0.int_116;
        gclass194.int_8 -= this.gclass0_0.int_116;
        gclass194.int_3 -= this.gclass0_0.int_116;
        if (gclass194.int_2 > 100)
          gclass194.int_2 = 100;
        if (gclass194.int_5 > 100)
          gclass194.int_5 = 100;
        if (gclass194.int_8 < 1)
          gclass194.int_8 = 1;
        if (gclass194.int_3 < 1)
          gclass194.int_3 = 1;
      }
      if (bool_10)
      {
        gclass194.double_1 = gclass194.double_0 * 0.5;
        gclass194.double_4 = 24.0;
        gclass194.double_6 = gclass194.double_5 * 0.9;
        gclass194.double_2 = 4.0;
        gclass194.SpeciesName = "Human";
        gclass194.string_0 = "Race327.bmp";
      }
      else
      {
        switch (genum6_0)
        {
          case GEnum6.const_1:
            gclass194.double_0 = 0.3;
            gclass194.double_1 = gclass194.double_0 * 0.9;
            gclass194.double_3 = 280.0;
            gclass194.double_4 = 50.0;
            gclass194.double_5 = 1.5;
            gclass194.double_6 = gclass194.double_5 * 0.95;
            gclass194.double_2 = 10.0;
            gclass194.SpeciesName = "Precursor";
            gclass194.string_0 = "Race087.bmp";
            gclass194.int_7 = 100;
            gclass194.int_3 = 20;
            gclass194.int_5 = 100;
            gclass194.int_6 = 50;
            gclass194.int_2 = 100;
            gclass194.int_8 = 20;
            gclass194.int_4 = 0;
            break;
          case GEnum6.const_2:
            gclass194.double_0 = 0.3;
            gclass194.double_1 = gclass194.double_0 * 0.9;
            gclass194.double_3 = 280.0;
            gclass194.double_4 = 100.0;
            gclass194.double_5 = 2.0;
            gclass194.double_6 = gclass194.double_5 * 0.95;
            gclass194.double_2 = 20.0;
            gclass194.SpeciesName = "Star Swarm";
            gclass194.string_0 = "Race356.bmp";
            gclass194.int_7 = 100;
            gclass194.int_3 = 1;
            gclass194.int_5 = 100;
            gclass194.int_6 = 100;
            gclass194.int_2 = 100;
            gclass194.int_8 = 1;
            gclass194.int_4 = 0;
            break;
          case GEnum6.const_4:
            gclass194.double_0 = 0.15;
            gclass194.double_1 = gclass194.double_0 * 0.9;
            gclass194.double_3 = 280.0;
            gclass194.double_4 = 60.0;
            gclass194.double_5 = 1.5;
            gclass194.double_6 = gclass194.double_5 * 0.95;
            gclass194.double_2 = 10.0;
            gclass194.SpeciesName = "Rakhas - #" + this.int_0.ToString();
            gclass194.string_0 = "Race028.bmp";
            gclass194.int_7 = 100;
            gclass194.int_3 = 0;
            gclass194.int_5 = 100;
            gclass194.int_6 = 50;
            gclass194.int_2 = 100;
            gclass194.int_8 = 0;
            gclass194.int_4 = 0;
            break;
          case GEnum6.const_5:
            gclass194.double_0 = 0.2;
            gclass194.double_1 = gclass194.double_0 * 0.8;
            gclass194.double_3 = 280.0;
            gclass194.double_4 = 50.0;
            gclass194.double_5 = 1.5;
            gclass194.double_6 = gclass194.double_5 * 0.95;
            gclass194.double_2 = 10.0;
            gclass194.SpeciesName = "Eldar";
            gclass194.string_0 = "Race156.bmp";
            gclass194.int_7 = 100;
            gclass194.int_3 = 10;
            gclass194.int_5 = 80 /*0x50*/;
            gclass194.int_6 = 20;
            gclass194.int_2 = 100;
            gclass194.int_8 = 10;
            gclass194.int_4 = 0;
            break;
          default:
            gclass194.double_1 = gclass194.double_0 * ((double) GClass226.smethod_13(6) * 0.05 + 0.3);
            gclass194.double_4 = (double) (14 + GClass226.smethod_13(16 /*0x10*/));
            if (num4 > gclass194.double_4)
              gclass194.double_4 = num4 + 1.0;
            gclass194.double_6 = gclass194.double_5 * ((double) GClass226.smethod_13(9) * 0.05 + 0.45);
            gclass194.double_2 = this.double_15 * ((double) GClass226.smethod_13(21) * 0.1 + 1.9);
            gclass194.SpeciesName = gclass21_0.string_0;
            gclass194.string_0 = gclass143_0 == null ? GClass226.smethod_19("Races") : gclass143_0.string_3;
            break;
        }
      }
      gclass194.gclass194_0 = (GClass194) null;
      gclass194.double_7 = gclass194.double_5 - gclass194.double_6;
      gclass194.double_8 = gclass194.double_5 + gclass194.double_6;
      gclass194.double_9 = gclass194.double_0 - gclass194.double_1;
      gclass194.double_10 = gclass194.double_0 + gclass194.double_1;
      gclass194.double_12 = gclass194.double_3 - gclass194.double_4;
      gclass194.double_11 = gclass194.double_3 + gclass194.double_4;
      gclass194.decimal_0 = 1M;
      gclass194.decimal_1 = 1M;
      gclass194.decimal_2 = 1M;
      gclass194.decimal_3 = 1M;
      if (gclass143_0 != null)
      {
        gclass194.decimal_1 = gclass143_0.decimal_0;
        gclass194.decimal_2 = gclass143_0.decimal_1;
        gclass194.decimal_3 = gclass143_0.decimal_2;
      }
      else if (!bool_10)
      {
        if (GClass226.smethod_13(25) == 1)
          gclass194.decimal_0 = 2M + (Decimal) GClass226.smethod_13(30) * 0.1M;
        else if (GClass226.smethod_13(10) == 1)
          gclass194.decimal_0 = 1M + (Decimal) GClass226.smethod_13(10) * 0.1M;
        else if (GClass226.smethod_13(10) == 1)
          gclass194.decimal_0 = 1M - (Decimal) GClass226.smethod_13(5) * 0.1M;
        if (GClass226.smethod_13(25) == 1)
          gclass194.decimal_1 = 2M + (Decimal) GClass226.smethod_13(10) * 0.1M;
        else if (GClass226.smethod_13(10) == 1)
          gclass194.decimal_1 = 1M + (Decimal) GClass226.smethod_13(10) * 0.1M;
        else if (GClass226.smethod_13(10) == 1)
          gclass194.decimal_1 = 1M - (Decimal) GClass226.smethod_13(5) * 0.1M;
        if (GClass226.smethod_13(10) == 1)
          gclass194.decimal_2 = 1M + (Decimal) GClass226.smethod_13(10) * 0.1M;
        else if (GClass226.smethod_13(20) == 1)
          gclass194.decimal_2 = 1M - (Decimal) GClass226.smethod_13(5) * 0.1M;
        if (GClass226.smethod_13(10) == 1)
          gclass194.decimal_3 = 1M + (Decimal) GClass226.smethod_13(10) * 0.1M;
        else if (GClass226.smethod_13(20) == 1)
          gclass194.decimal_3 = 1M - (Decimal) GClass226.smethod_13(5) * 0.1M;
      }
      gclass194.dictionary_0 = new Dictionary<int, GClass195>();
      this.gclass194_0 = gclass194;
      return gclass194;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3017);
      return (GClass194) null;
    }
  }

  public bool method_23(bool bool_10)
  {
    try
    {
      if (bool_10)
      {
        if (this.double_7 < 0.4 || this.double_7 > 2.5 || this.double_4 < 220.0 || this.double_4 > 340.0 || this.double_19 < 20.0 || this.double_19 > 90.0)
          return false;
        double num = 0.0;
        foreach (GClass224 gclass224 in this.list_0)
        {
          if (gclass224.gclass223_0.genum47_0 == GEnum47.const_10)
            num = gclass224.double_1;
          else if (gclass224.gclass223_0.int_0 > 0)
            return false;
        }
        return num >= 0.07 && num <= this.double_15 * 0.3;
      }
      if (this.double_7 < 0.1)
      {
        int num = (int) MessageBox.Show("The gravity of this planet is too low for it to serve as a homeworld (minimum required 0.1G)");
        return false;
      }
      if (this.double_4 < 203.0)
      {
        int num = (int) MessageBox.Show("The surface temperature of this planet is too low for it to serve as a homeworld (minimum required -70C)");
        return false;
      }
      if (this.double_4 > 343.0)
      {
        int num = (int) MessageBox.Show("The surface temperature of this planet is too high for it to serve as a homeworld (maximum allowed 70C)");
        return false;
      }
      if (this.double_4 > 350.0)
      {
        int num = (int) MessageBox.Show("This planet has insufficient water to serve as a homeworld (minimum required 20%)");
        return false;
      }
      double num1 = 0.0;
      foreach (GClass224 gclass224 in this.list_0)
      {
        if (gclass224.gclass223_0.genum47_0 == GEnum47.const_10)
          num1 = gclass224.double_1;
        else if (gclass224.gclass223_0.int_0 > 0 && gclass224.double_0 >= (double) (gclass224.gclass223_0.int_2 / 10000))
        {
          int num2 = (int) MessageBox.Show("This planet has a dangerous in its atmosphere and is not suitable as a homeworld");
          return false;
        }
      }
      if (num1 < 0.05)
      {
        int num3 = (int) MessageBox.Show("This planet has insufficient oxygen for it to serve as a homeworld (minimum required 0.05 atm)");
        return false;
      }
      if (num1 <= this.double_15 * 0.3)
        return true;
      int num4 = (int) MessageBox.Show("This oxygen content of the atmosphere is too high for the planet to serve as a homeworld (maximum allowed 30%)");
      return false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3018);
      return false;
    }
  }

  public void method_24(AuroraElement auroraElement_0, TextBox textBox_0, TextBox textBox_1)
  {
    try
    {
      if (this.dictionary_0.ContainsKey(auroraElement_0))
      {
        textBox_0.Text = Math.Round(this.dictionary_0[auroraElement_0].decimal_0).ToString();
        textBox_1.Text = GClass226.smethod_45(this.dictionary_0[auroraElement_0].decimal_1, 2);
      }
      else
      {
        textBox_0.Text = "0";
        textBox_1.Text = "0";
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3019);
    }
  }

  public void method_25(AuroraElement auroraElement_0, TextBox textBox_0, TextBox textBox_1)
  {
    try
    {
      Decimal num1 = 0M;
      Decimal num2 = 0.1M;
      GClass208 gclass208_1 = GClass226.smethod_4(textBox_0.Text);
      if (gclass208_1.bool_0)
        num1 = gclass208_1.decimal_0;
      GClass208 gclass208_2 = GClass226.smethod_4(textBox_1.Text);
      if (gclass208_2.bool_0)
        num2 = gclass208_2.decimal_0;
      if (this.dictionary_0.ContainsKey(auroraElement_0))
      {
        if (num1 == 0M)
        {
          this.dictionary_0.Remove(auroraElement_0);
        }
        else
        {
          this.dictionary_0[auroraElement_0].decimal_0 = num1;
          this.dictionary_0[auroraElement_0].decimal_1 = num2;
          if (this.dictionary_0[auroraElement_0].decimal_1 > 1M)
            this.dictionary_0[auroraElement_0].decimal_1 = 1M;
          this.dictionary_0[auroraElement_0].decimal_2 = this.dictionary_0[auroraElement_0].decimal_0 / 2M;
          this.dictionary_0[auroraElement_0].decimal_3 = this.dictionary_0[auroraElement_0].decimal_1;
        }
      }
      else
      {
        if (num1 == 0M)
          return;
        GClass124 gclass124 = new GClass124();
        gclass124.int_0 = this.int_0;
        gclass124.auroraElement_0 = auroraElement_0;
        gclass124.decimal_0 = num1;
        gclass124.decimal_1 = num2;
        if (gclass124.decimal_1 > 1M)
          gclass124.decimal_1 = 1M;
        gclass124.decimal_2 = gclass124.decimal_0 / 2M;
        gclass124.decimal_3 = gclass124.decimal_1;
        this.dictionary_0.Add(gclass124.auroraElement_0, gclass124);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3020);
    }
  }

  public string method_26()
  {
    try
    {
      string str = "";
      foreach (GClass124 gclass124 in this.dictionary_0.Values)
        str = $"{str}{GClass226.smethod_82((Enum) gclass124.auroraElement_0)}: {gclass124.method_0()}     ";
      return str;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3021);
      return "None";
    }
  }

  public void method_27()
  {
    try
    {
      if (this.auroraSystemBodyType_0 != AuroraSystemBodyType.GasGiant && this.auroraSystemBodyType_0 != AuroraSystemBodyType.Superjovian)
      {
        double double_45 = 0.0;
        double double_46 = 0.0;
        foreach (GClass224 gclass224 in this.list_0)
        {
          if (!gclass224.bool_0)
          {
            if (gclass224.gclass223_0.bool_0)
              double_45 += gclass224.double_1;
            if (gclass224.gclass223_0.bool_1)
              double_46 += gclass224.double_1;
          }
        }
        this.method_28(double_45, double_46);
      }
      else
        this.double_4 = this.double_3;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3022);
    }
  }

  public void method_28(double double_45, double double_46)
  {
    try
    {
      this.double_17 = 1.0 + this.double_15 / 10.0 + double_45;
      if (this.double_17 > 3.0)
        this.double_17 = 3.0;
      this.double_18 = 1.0 + (double) this.decimal_4 / 20000.0 + double_46;
      if (this.double_18 > 3.0)
        this.double_18 = 3.0;
      this.double_4 = this.double_3 * this.double_17 * this.double_16 / this.double_18;
      if (this.double_4 >= 1.0)
        return;
      this.double_4 = 1.0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3299);
    }
  }

  public void method_29()
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass1.Class309 class309 = new GClass1.Class309();
    // ISSUE: reference to a compiler-generated field
    class309.gclass1_0 = this;
    try
    {
      this.gclass99_0 = this.gclass0_0.dictionary_73[GEnum111.const_0];
      if (this.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || this.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian)
        return;
      // ISSUE: reference to a compiler-generated field
      class309.double_0 = 0.0;
      double num = 0.0;
      foreach (GClass224 gclass224 in this.list_0)
      {
        num += gclass224.double_1;
        if (gclass224.gclass223_0.genum47_0 == GEnum47.const_10)
        {
          // ISSUE: reference to a compiler-generated field
          class309.double_0 = gclass224.double_1;
        }
      }
      // ISSUE: reference to a compiler-generated field
      class309.double_1 = this.double_4 - (double) GClass226.int_17;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if ((class309.double_1 < -150.0 || class309.double_1 > 200.0 || this.double_7 < 0.1 || num == 0.0 || num > 10.0) && this.auroraTectonics_0 < AuroraTectonics.PlateTectonic)
      {
        this.gclass99_0 = this.gclass0_0.dictionary_73[GEnum111.const_0];
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        List<GClass99> list = this.gclass0_0.dictionary_73.Values.Where<GClass99>(new Func<GClass99, bool>(class309.method_0)).ToList<GClass99>();
        if (list.Count == 0)
        {
          // ISSUE: reference to a compiler-generated method
          list = this.gclass0_0.dictionary_73.Values.Where<GClass99>(new Func<GClass99, bool>(class309.method_1)).ToList<GClass99>();
        }
        if (list.Count <= 0)
          return;
        this.gclass99_0 = list.ElementAt<GClass99>(GClass226.smethod_13(list.Count) - 1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3023);
    }
  }

  public List<GClass99> method_30()
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass1.Class310 class310 = new GClass1.Class310();
    // ISSUE: reference to a compiler-generated field
    class310.gclass1_0 = this;
    try
    {
      // ISSUE: reference to a compiler-generated field
      class310.double_0 = 0.0;
      double num = 0.0;
      foreach (GClass224 gclass224 in this.list_0)
      {
        num += gclass224.double_1;
        if (gclass224.gclass223_0.genum47_0 == GEnum47.const_10)
        {
          // ISSUE: reference to a compiler-generated field
          class310.double_0 = gclass224.double_1;
        }
      }
      // ISSUE: reference to a compiler-generated field
      class310.double_1 = this.double_4 - (double) GClass226.int_17;
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_73.Values.Where<GClass99>(new Func<GClass99, bool>(class310.method_0)).ToList<GClass99>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3024);
      return (List<GClass99>) null;
    }
  }

  public bool method_31(GClass143 gclass143_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass1.Class311 class311 = new GClass1.Class311();
    // ISSUE: reference to a compiler-generated field
    class311.gclass1_0 = this;
    try
    {
      // ISSUE: reference to a compiler-generated field
      class311.double_0 = 0.0;
      double num1 = 0.0;
      foreach (GClass224 gclass224 in this.list_0)
      {
        num1 += gclass224.double_1;
        if (gclass224.gclass223_0.genum47_0 == GEnum47.const_10)
        {
          // ISSUE: reference to a compiler-generated field
          class311.double_0 = gclass224.double_1;
        }
      }
      double num2 = this.double_4 - (double) GClass226.int_17;
      // ISSUE: reference to a compiler-generated field
      class311.double_2 = num2;
      // ISSUE: reference to a compiler-generated field
      class311.double_1 = num2;
      // ISSUE: reference to a compiler-generated field
      class311.double_3 = 0.0;
      if (this.genum12_0 == GEnum12.const_2)
      {
        // ISSUE: reference to a compiler-generated field
        class311.double_1 = this.method_53(this.gclass1_0.double_28);
        // ISSUE: reference to a compiler-generated field
        class311.double_2 = this.method_53(this.gclass1_0.double_27);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        class311.double_3 = class311.double_2 - class311.double_1;
        // ISSUE: reference to a compiler-generated field
        class311.double_1 -= (double) GClass226.int_17;
        // ISSUE: reference to a compiler-generated field
        class311.double_2 -= (double) GClass226.int_17;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        class311.double_1 = this.method_53(this.double_28);
        // ISSUE: reference to a compiler-generated field
        class311.double_2 = this.method_53(this.double_27);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        class311.double_3 = class311.double_2 - class311.double_1;
        // ISSUE: reference to a compiler-generated field
        class311.double_1 -= (double) GClass226.int_17;
        // ISSUE: reference to a compiler-generated field
        class311.double_2 -= (double) GClass226.int_17;
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (class311.double_1 < -150.0 || class311.double_2 > 200.0)
        return false;
      // ISSUE: reference to a compiler-generated method
      List<GClass99> list = gclass143_0.list_0.Where<GClass99>(new Func<GClass99, bool>(class311.method_0)).ToList<GClass99>();
      if (list.Count == 0)
        return false;
      int index = GClass226.smethod_13(list.Count) - 1;
      this.gclass99_0 = this.gclass0_0.dictionary_73[list[index].genum111_0];
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3757);
      return false;
    }
  }

  public void method_32()
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass1.Class312 class312 = new GClass1.Class312();
      // ISSUE: reference to a compiler-generated field
      class312.gclass1_0 = this;
      if (this.auroraSystemBodyType_0 != AuroraSystemBodyType.GasGiant && this.auroraSystemBodyType_0 != AuroraSystemBodyType.Superjovian)
      {
        GClass99 gclass990 = this.gclass99_0;
        // ISSUE: reference to a compiler-generated field
        class312.double_0 = 0.0;
        double num1 = 0.0;
        foreach (GClass224 gclass224 in this.list_0)
        {
          num1 += gclass224.double_1;
          if (gclass224.gclass223_0.genum47_0 == GEnum47.const_10)
          {
            // ISSUE: reference to a compiler-generated field
            class312.double_0 = gclass224.double_1;
          }
        }
        if (this.double_7 >= 0.1 && num1 != 0.0 && num1 <= 10.0)
        {
          double num2 = this.double_4 - (double) GClass226.int_17;
          // ISSUE: reference to a compiler-generated field
          class312.double_2 = num2;
          // ISSUE: reference to a compiler-generated field
          class312.double_1 = num2;
          // ISSUE: reference to a compiler-generated field
          class312.double_3 = 0.0;
          if (this.genum12_0 == GEnum12.const_2)
          {
            if (this.gclass1_0.double_10 < 4380.0)
            {
              // ISSUE: reference to a compiler-generated field
              class312.double_1 = this.method_53(this.gclass1_0.double_28);
              // ISSUE: reference to a compiler-generated field
              class312.double_2 = this.method_53(this.gclass1_0.double_27);
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              class312.double_3 = class312.double_2 - class312.double_1;
              // ISSUE: reference to a compiler-generated field
              class312.double_1 -= (double) GClass226.int_17;
              // ISSUE: reference to a compiler-generated field
              class312.double_2 -= (double) GClass226.int_17;
            }
          }
          else if (this.double_10 < 4380.0)
          {
            // ISSUE: reference to a compiler-generated field
            class312.double_1 = this.method_53(this.double_28);
            // ISSUE: reference to a compiler-generated field
            class312.double_2 = this.method_53(this.double_27);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class312.double_3 = class312.double_2 - class312.double_1;
            // ISSUE: reference to a compiler-generated field
            class312.double_1 -= (double) GClass226.int_17;
            // ISSUE: reference to a compiler-generated field
            class312.double_2 -= (double) GClass226.int_17;
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (class312.double_1 >= -150.0 && class312.double_2 <= 200.0)
          {
            if (this.gclass99_0.genum111_0 != GEnum111.const_2 && this.gclass99_0.genum111_0 != GEnum111.const_12 && this.gclass99_0.genum111_0 != GEnum111.const_0)
            {
              // ISSUE: reference to a compiler-generated method
              List<GClass99> list = this.gclass0_0.dictionary_73.Values.Where<GClass99>(new Func<GClass99, bool>(class312.method_1)).ToList<GClass99>();
              if (list.Contains(this.gclass99_0) || list.Count <= 0)
                return;
              if (list.Count > 1)
                list = list.Where<GClass99>((Func<GClass99, bool>) (gclass99_1 => gclass99_1.genum111_0 != this.gclass99_0.genum111_1)).ToList<GClass99>();
              int index = GClass226.smethod_13(list.Count) - 1;
              this.gclass99_0 = this.gclass0_0.dictionary_73[list[index].genum111_0];
              foreach (GClass21 gclass21_0 in this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass1_0 == this)).Select<GClass146, GClass21>((Func<GClass146, GClass21>) (gclass146_0 => gclass146_0.gclass21_0)).Distinct<GClass21>().ToList<GClass21>())
                this.gclass0_0.gclass92_0.method_2(GEnum126.const_152, $"Due to changes in climate, the dominant terrain on {this.method_78(gclass21_0)} has changed from {gclass990.Name} to {this.gclass99_0.Name}", gclass21_0, this.gclass200_0, this.double_0, this.double_1, AuroraEventCategory.PopEnvironment);
            }
            else
            {
              // ISSUE: reference to a compiler-generated method
              List<GClass99> list = this.gclass0_0.dictionary_73.Values.Where<GClass99>(new Func<GClass99, bool>(class312.method_0)).ToList<GClass99>();
              if (list.Count <= 0)
                return;
              int index = GClass226.smethod_13(list.Count) - 1;
              this.gclass99_0 = this.gclass0_0.dictionary_73[list[index].genum111_0];
              foreach (GClass21 gclass21_0 in this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass1_0 == this)).Select<GClass146, GClass21>((Func<GClass146, GClass21>) (gclass146_0 => gclass146_0.gclass21_0)).Distinct<GClass21>().ToList<GClass21>())
                this.gclass0_0.gclass92_0.method_2(GEnum126.const_152, $"Due to changes in climate, the dominant terrain on {this.method_78(gclass21_0)} has changed from {gclass990.Name} to {this.gclass99_0.Name}", gclass21_0, this.gclass200_0, this.double_0, this.double_1, AuroraEventCategory.PopEnvironment);
            }
          }
          else
          {
            if (this.gclass99_0 == this.gclass0_0.dictionary_73[this.gclass99_0.genum111_1])
              return;
            this.gclass99_0 = this.gclass0_0.dictionary_73[this.gclass99_0.genum111_1];
            foreach (GClass21 gclass21_0 in this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass1_0 == this)).Select<GClass146, GClass21>((Func<GClass146, GClass21>) (gclass146_0 => gclass146_0.gclass21_0)).Distinct<GClass21>().ToList<GClass21>())
              this.gclass0_0.gclass92_0.method_2(GEnum126.const_152, $"Due to changes in climate, the dominant terrain on {this.method_78(gclass21_0)} has changed from {gclass990.Name} to {this.gclass99_0.Name}", gclass21_0, this.gclass200_0, this.double_0, this.double_1, AuroraEventCategory.PopEnvironment);
          }
        }
        else
        {
          if (this.gclass99_0 == this.gclass0_0.dictionary_73[this.gclass99_0.genum111_1])
            return;
          this.gclass99_0 = this.gclass0_0.dictionary_73[this.gclass99_0.genum111_1];
          foreach (GClass21 gclass21_0 in this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass1_0 == this)).Select<GClass146, GClass21>((Func<GClass146, GClass21>) (gclass146_0 => gclass146_0.gclass21_0)).Distinct<GClass21>().ToList<GClass21>())
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_152, $"Due to changes in climate, the dominant terrain on {this.method_78(gclass21_0)} has changed from {gclass990.Name} to {this.gclass99_0.Name}", gclass21_0, this.gclass200_0, this.double_0, this.double_1, AuroraEventCategory.PopEnvironment);
        }
      }
      else
        this.gclass99_0 = this.gclass0_0.dictionary_73[GEnum111.const_0];
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3025);
    }
  }

  public AuroraHydrosphereType method_33(bool bool_10, bool bool_11)
  {
    try
    {
      double num = this.double_3;
      if (bool_10)
        num = this.double_4;
      this.auroraHydrosphereType_0 = this.double_15 != 0.0 || !bool_11 ? (this.double_15 >= 0.006 || num <= 245.0 || !bool_11 ? (num <= 369.0 || !bool_11 ? (num <= 369.0 ? (num <= 245.0 ? AuroraHydrosphereType.IceSheet : AuroraHydrosphereType.Liquid) : AuroraHydrosphereType.Vapour) : AuroraHydrosphereType.None) : AuroraHydrosphereType.None) : AuroraHydrosphereType.None;
      return this.auroraHydrosphereType_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3026);
      return AuroraHydrosphereType.None;
    }
  }

  public AuroraHydrosphereType method_34(double double_45)
  {
    try
    {
      if (double_45 > 369.0)
        return AuroraHydrosphereType.Vapour;
      return double_45 > 245.0 ? AuroraHydrosphereType.Liquid : AuroraHydrosphereType.IceSheet;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3477);
      return AuroraHydrosphereType.None;
    }
  }

  public void method_35()
  {
    try
    {
      if (this.list_0.Count == 0)
        return;
      double double15 = this.double_15;
      foreach (GClass224 gclass224 in this.list_0)
        gclass224.bool_0 = this.double_4 < (double) gclass224.gclass223_0.int_1;
      this.double_15 = this.list_0.Where<GClass224>((Func<GClass224, bool>) (gclass224_0 => !gclass224_0.bool_0)).Sum<GClass224>((Func<GClass224, double>) (gclass224_0 => gclass224_0.double_1));
      if (this.double_15 == 0.0)
        this.double_15 = double15 / 20.0;
      if (this.double_15 < 0.0)
        this.double_15 = 0.0;
      if (this.double_15 == double15)
        return;
      this.method_27();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3027);
    }
  }

  public void method_36(GClass21 gclass21_0)
  {
    try
    {
      this.method_27();
      AuroraHydrosphereType hydrosphereType0 = this.auroraHydrosphereType_0;
      AuroraHydrosphereType auroraHydrosphereType = this.method_33(true, false);
      if (hydrosphereType0 == AuroraHydrosphereType.IceSheet && auroraHydrosphereType == AuroraHydrosphereType.Liquid)
      {
        if (this.double_19 > 0.0 && this.auroraHydrosphereType_0 == AuroraHydrosphereType.Liquid)
          this.gclass0_0.method_412(this, 0.0);
        double double4 = this.double_4;
        double double16 = this.double_16;
        this.double_16 += 0.0015 * this.double_19;
        this.method_27();
        if (gclass21_0 == null || this.double_16 == double16)
          return;
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_50, $"Due to increasing temperature the ice sheet on {this.method_78(gclass21_0)} has melted, raising the Albedo from {GClass226.smethod_44(double16, 3)} to {GClass226.smethod_44(this.double_16, 3)}. This has caused a sudden temperature increase from {GClass226.smethod_44(double4 - (double) GClass226.int_17, 1)}C to {GClass226.smethod_44(this.double_4 - (double) GClass226.int_17, 1)}C.", gclass21_0, this.gclass200_0, this.double_0, this.double_1, AuroraEventCategory.PopEnvironment);
      }
      else if (hydrosphereType0 == AuroraHydrosphereType.Liquid && auroraHydrosphereType == AuroraHydrosphereType.IceSheet)
      {
        double double4 = this.double_4;
        double double16 = this.double_16;
        this.double_16 -= 0.0015 * this.double_19;
        this.method_27();
        if (gclass21_0 == null)
          return;
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_184, $"Due to decreasing temperature the ice sheet on {this.string_0} has frozen, lowering the Albedo from {GClass226.smethod_44(double16, 3)} to {GClass226.smethod_44(this.double_16, 3)}. This has caused a sudden temperature decrease from {GClass226.smethod_44(double4 - (double) GClass226.int_17, 1)}C to {GClass226.smethod_44(this.double_4 - (double) GClass226.int_17, 1)}C.", gclass21_0, this.gclass200_0, this.double_0, this.double_1, AuroraEventCategory.PopEnvironment);
      }
      else if (hydrosphereType0 != AuroraHydrosphereType.None && this.double_19 > 0.0 && auroraHydrosphereType == AuroraHydrosphereType.Vapour)
      {
        if (hydrosphereType0 == AuroraHydrosphereType.IceSheet)
          this.double_16 += 0.0015 * this.double_19;
        this.method_27();
      }
      else if (hydrosphereType0 == AuroraHydrosphereType.Vapour && (auroraHydrosphereType == AuroraHydrosphereType.IceSheet || auroraHydrosphereType == AuroraHydrosphereType.Liquid))
      {
        if (auroraHydrosphereType == AuroraHydrosphereType.IceSheet)
          this.double_16 -= 0.0015 * this.double_19;
        if (this.double_19 > 0.0 && auroraHydrosphereType == AuroraHydrosphereType.Liquid)
          this.gclass0_0.method_412(this, 0.0);
        this.method_27();
      }
      else
      {
        if (auroraHydrosphereType != AuroraHydrosphereType.None)
          return;
        this.double_19 = 0.0;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3028);
    }
  }

  public void method_37(GClass21 gclass21_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass1.Class313 class313 = new GClass1.Class313();
    // ISSUE: reference to a compiler-generated field
    class313.gclass21_0 = gclass21_0;
    // ISSUE: reference to a compiler-generated field
    class313.gclass1_0 = this;
    try
    {
      // ISSUE: reference to a compiler-generated method
      if (this.gclass0_0.list_9.Where<GClass215>(new Func<GClass215, bool>(class313.method_0)).FirstOrDefault<GClass215>() != null)
        return;
      // ISSUE: reference to a compiler-generated field
      this.gclass0_0.list_9.Add(new GClass215()
      {
        gclass21_0 = class313.gclass21_0,
        gclass1_0 = this,
        genum5_0 = GEnum5.const_2
      });
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3029);
    }
  }

  public void method_38(GClass21 gclass21_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass1.Class314 class314 = new GClass1.Class314();
    // ISSUE: reference to a compiler-generated field
    class314.gclass21_0 = gclass21_0;
    // ISSUE: reference to a compiler-generated field
    class314.gclass1_0 = this;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass215 gclass215 = this.gclass0_0.list_9.Where<GClass215>(new Func<GClass215, bool>(class314.method_0)).FirstOrDefault<GClass215>();
      if (gclass215 == null)
        return;
      this.gclass0_0.list_9.Remove(gclass215);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3030);
    }
  }

  public Decimal method_39()
  {
    try
    {
      Decimal num = this.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || this.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian ? (Decimal) this.double_20 / 100M : (Decimal) this.double_20 / 10M;
      if (num < 1M)
        num = 1M;
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3031);
      return 0M;
    }
  }

  public void method_40()
  {
    try
    {
      this.double_27 = this.double_2 * (1.0 - this.double_24);
      this.double_28 = this.double_2 * (1.0 + this.double_24);
      this.double_26 = this.double_2 * Math.Sqrt(1.0 - this.double_24 * this.double_24);
      this.method_41(this.double_5);
      this.double_37 = this.gclass0_0.method_28(this.double_0, this.double_1, this.gclass197_0.double_0, this.gclass197_0.double_1) / GClass226.double_14;
      this.method_6();
      if (this.double_24 == 0.0)
        return;
      this.double_3 = (double) byte.MaxValue / Math.Pow(this.double_37 / Math.Pow(this.gclass197_0.double_4, 0.5), 0.5);
      if (this.double_3 < 4.0)
        this.double_3 = 4.0;
      this.method_36((GClass21) null);
      this.method_35();
      this.method_32();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3581);
    }
  }

  public void method_41(double double_45)
  {
    try
    {
      this.method_7();
      double_45 -= 90.0;
      if (double_45 < 0.0)
        double_45 += 360.0;
      if (this.gclass1_0 != null && this.double_21 == 0.0)
      {
        double num = double_45 * (Math.PI / 180.0);
        this.double_0 = this.gclass1_0.double_0 + this.double_2 * Math.Cos(num);
        this.double_1 = this.gclass1_0.double_1 + this.double_2 * Math.Sin(num);
      }
      else if (this.double_24 == 0.0)
      {
        double num = double_45 * (Math.PI / 180.0);
        this.double_0 = this.gclass197_0.double_0 + this.double_2 * GClass226.double_14 * Math.Cos(num);
        this.double_1 = this.gclass197_0.double_1 + this.double_2 * GClass226.double_14 * Math.Sin(num);
      }
      else if (this.double_25 == 0.0)
      {
        double num1 = double_45 * (Math.PI / 180.0);
        double num2 = this.gclass197_0.double_0 + (this.double_2 - this.double_27) * GClass226.double_14;
        double double1 = this.gclass197_0.double_1;
        this.double_0 = num2 + this.double_36 * GClass226.double_14 * Math.Cos(num1);
        this.double_1 = double1 + this.double_36 * GClass226.double_14 * Math.Sin(num1);
      }
      else
      {
        this.method_42();
        double_45 += this.double_25;
        if (double_45 >= 360.0)
          double_45 -= 360.0;
        double num = double_45 * (Math.PI / 180.0);
        this.double_0 = this.double_29 + this.double_36 * GClass226.double_14 * Math.Cos(num);
        this.double_1 = this.double_30 + this.double_36 * GClass226.double_14 * Math.Sin(num);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3032);
    }
  }

  public void method_42()
  {
    try
    {
      double double25 = this.double_25;
      if (double25 < 0.0)
        double25 += 360.0;
      double num1 = double25 * (Math.PI / 180.0);
      double num2 = (this.double_28 - this.double_27) / 2.0;
      this.double_29 = this.gclass197_0.double_0 + num2 * GClass226.double_14 * Math.Cos(num1);
      this.double_30 = this.gclass197_0.double_1 + num2 * GClass226.double_14 * Math.Sin(num1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3447);
    }
  }

  public int method_43(GClass194 gclass194_1)
  {
    try
    {
      int num1 = 0;
      foreach (GClass224 gclass224 in this.list_0)
      {
        if (gclass224.gclass223_0.int_0 > num1 && gclass224.gclass223_0 != gclass194_1.gclass223_0 && !gclass224.bool_0)
        {
          double num2 = (double) gclass224.gclass223_0.int_2 / 10000.0;
          if (gclass224.double_0 > num2)
            num1 = gclass224.gclass223_0.int_0;
        }
      }
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3033);
      return 0;
    }
  }

  public double method_44(GClass223 gclass223_0)
  {
    try
    {
      foreach (GClass224 gclass224 in this.list_0)
      {
        if (gclass224.gclass223_0 == gclass223_0)
          return gclass224.double_0;
      }
      return 0.0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3034);
      return 0.0;
    }
  }

  public double method_45(GClass223 gclass223_0)
  {
    try
    {
      foreach (GClass224 gclass224 in this.list_0)
      {
        if (gclass224.gclass223_0 == gclass223_0)
          return gclass224.double_1;
      }
      return 0.0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3035);
      return 0.0;
    }
  }

  public double method_46()
  {
    try
    {
      this.double_15 = 0.0;
      foreach (GClass224 gclass224 in this.list_0)
        this.double_15 += gclass224.double_1;
      if (this.double_15 < 0.0)
        this.double_15 = 0.0;
      return this.double_15;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3036);
      return 0.0;
    }
  }

  public string method_47(GClass194 gclass194_1, GEnum80 genum80_0)
  {
    try
    {
      return this.method_48(gclass194_1, 2, genum80_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3037);
      return "error";
    }
  }

  public string method_48(GClass194 gclass194_1, int int_13, GEnum80 genum80_0)
  {
    try
    {
      switch (genum80_0)
      {
        case GEnum80.const_0:
          if (this.decimal_0 == -1M)
            return "N/A";
          return this.double_7 < gclass194_1.double_7 ? GClass226.smethod_45(this.decimal_0, int_13) + " LG" : GClass226.smethod_45(this.decimal_0, int_13).ToString();
        case GEnum80.const_1:
          if (this.decimal_1 == -1M)
            return "N/A";
          return this.double_7 < gclass194_1.double_7 ? GClass226.smethod_45(this.decimal_1, int_13) + " LG" : GClass226.smethod_45(this.decimal_1, int_13).ToString();
        case GEnum80.const_2:
          if (this.double_34 == -1.0)
            return "N/A";
          return this.double_7 < gclass194_1.double_7 ? GClass226.smethod_46(this.double_34, int_13) + " LG" : GClass226.smethod_46(this.double_34, int_13).ToString();
        case GEnum80.const_3:
          if (this.double_35 == -1.0)
            return "N/A";
          return this.double_7 < gclass194_1.double_7 ? GClass226.smethod_46(this.double_35, int_13) + " LG" : GClass226.smethod_46(this.double_35, int_13).ToString();
        default:
          return "error";
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3038);
      return "error";
    }
  }

  public bool method_49(GClass194 gclass194_1)
  {
    try
    {
      double num = this.method_45(gclass194_1.gclass223_0);
      return num >= gclass194_1.double_9 && num <= gclass194_1.double_10 && this.method_44(gclass194_1.gclass223_0) <= (double) GClass226.int_22;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3039);
      return false;
    }
  }

  public bool method_50(GClass194 gclass194_1)
  {
    try
    {
      double num = this.method_45(gclass194_1.gclass223_0);
      return num >= gclass194_1.double_9 && num <= gclass194_1.double_10 && this.method_44(gclass194_1.gclass223_0) <= (double) GClass226.int_22;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3254);
      return false;
    }
  }

  public double method_51(double double_45)
  {
    try
    {
      double num = (double) byte.MaxValue / Math.Pow(double_45 / Math.Pow(this.gclass197_0.double_4, 0.5), 0.5);
      if (num < 4.0)
        num = 4.0;
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3456);
      return 0.0;
    }
  }

  public double method_52(
    GClass21 gclass21_0,
    GClass194 gclass194_1,
    double double_45,
    GEnum81 genum81_0)
  {
    try
    {
      if (this.bool_2 || this.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || this.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian)
        return -1.0;
      if (gclass194_1 == null)
        gclass194_1 = gclass21_0.method_164();
      double num1 = this.method_53(double_45);
      switch (genum81_0)
      {
        case GEnum81.const_1:
          this.double_31 = num1;
          break;
        case GEnum81.const_2:
          this.double_32 = num1;
          break;
      }
      double num2 = 0.0;
      if (num1 < gclass194_1.double_12)
        num2 = Math.Abs(gclass194_1.double_12 - num1) / gclass194_1.double_4;
      else if (num1 > gclass194_1.double_11)
        num2 = Math.Abs(gclass194_1.double_11 - num1) / gclass194_1.double_4;
      if (this.bool_0 && this.genum12_0 != GEnum12.const_2)
        num2 /= 5.0;
      double num3 = 0.0;
      if (this.double_15 > gclass194_1.double_2)
      {
        num3 = this.double_15 / gclass194_1.double_2;
        if (num3 < 2.0)
          num3 = 2.0;
      }
      if (num2 < num3)
        num2 = num3;
      double num4 = (double) this.method_43(gclass194_1);
      if (num2 < num4)
        num2 = num4;
      if (Math.Round(num2, 4) < 2.0)
      {
        double num5 = this.method_45(gclass194_1.gclass223_0);
        if (num5 >= gclass194_1.double_9 && num5 <= gclass194_1.double_10)
        {
          if (this.method_44(gclass194_1.gclass223_0) > (double) GClass226.int_22)
            num2 = 2.0;
        }
        else
          num2 = 2.0;
      }
      if (this.double_19 < 20.0)
      {
        double num6 = (20.0 - this.double_19) / 10.0;
        if (num2 < num6)
          num2 = num6;
      }
      if (this.double_7 < gclass194_1.double_7 && num2 < 1.0)
        num2 = 1.0;
      return Math.Round(num2, 4) * (double) gclass21_0.decimal_19;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3455);
      return -2.0;
    }
  }

  public double method_53(double double_45)
  {
    try
    {
      double num1 = (double) byte.MaxValue / Math.Pow(double_45 / Math.Pow(this.gclass197_0.double_4, 0.5), 0.5);
      if (num1 < 4.0)
        num1 = 4.0;
      double num2 = this.double_4 / (this.double_3 * this.double_16);
      double num3 = num1 * this.double_16 * num2;
      double num4 = 1.0;
      double num5 = 1.0;
      if (this.list_0.Count > 0)
      {
        double num6 = 0.0;
        double num7 = 0.0;
        foreach (GClass224 gclass224 in this.list_0)
        {
          if (num3 >= (double) gclass224.gclass223_0.int_1)
          {
            if (gclass224.gclass223_0.bool_0)
              num6 += gclass224.double_1;
            if (gclass224.gclass223_0.bool_1)
              num7 += gclass224.double_1;
          }
        }
        num4 = 1.0 + this.double_15 / 10.0 + num6;
        if (num4 > 3.0)
          num4 = 3.0;
        num5 = 1.0 + (double) this.decimal_4 / 20000.0 + num7;
        if (num5 > 3.0)
          num5 = 3.0;
      }
      double double_45_1 = num1 * num4 * this.double_16 / num5;
      if (double_45_1 < 1.0)
        double_45_1 = 1.0;
      if (this.double_19 > 0.0)
      {
        AuroraHydrosphereType hydrosphereType0 = this.auroraHydrosphereType_0;
        AuroraHydrosphereType auroraHydrosphereType = this.method_34(double_45_1);
        if (hydrosphereType0 != auroraHydrosphereType)
        {
          double num8 = this.double_16;
          if (hydrosphereType0 == AuroraHydrosphereType.IceSheet)
            num8 = this.double_16 + 0.0015 * this.double_19;
          else if (auroraHydrosphereType == AuroraHydrosphereType.IceSheet)
            num8 = this.double_16 - 0.0015 * this.double_19;
          double_45_1 = num1 * num4 * num8 / num5;
          if (double_45_1 < 1.0)
            double_45_1 = 1.0;
        }
      }
      return double_45_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3478);
      return -2.0;
    }
  }

  public double method_54(
    GClass21 gclass21_0,
    GClass194 gclass194_1,
    double double_45,
    double double_46)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass1.Class315 class315 = new GClass1.Class315();
    // ISSUE: reference to a compiler-generated field
    class315.gclass194_0 = gclass194_1;
    try
    {
      double num = 0.0;
      // ISSUE: reference to a compiler-generated method
      foreach (GClass224 gclass224 in this.list_0.Where<GClass224>(new Func<GClass224, bool>(class315.method_0)).OrderByDescending<GClass224, double>((Func<GClass224, double>) (gclass224_0 => gclass224_0.double_1)).ToList<GClass224>())
      {
        if (gclass224.double_1 <= double_45)
        {
          num += gclass224.double_1;
          this.list_0.Remove(gclass224);
        }
        else
          break;
      }
      // ISSUE: reference to a compiler-generated field
      this.method_57(gclass21_0, class315.gclass194_0);
      return num / double_46;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3836);
      return -2.0;
    }
  }

  public double method_55(GClass21 gclass21_0, GClass194 gclass194_1, double double_45)
  {
    try
    {
      double num1 = 0.0;
      GClass224 gclass224_1 = this.list_0.FirstOrDefault<GClass224>((Func<GClass224, bool>) (gclass224_0 => gclass224_0.gclass223_0 == this.gclass0_0.dictionary_23[GEnum47.const_10]));
      if (gclass224_1 == null)
      {
        gclass224_1 = new GClass224();
        gclass224_1.gclass223_0 = this.gclass0_0.dictionary_23[GEnum47.const_10];
        gclass224_1.int_0 = this.int_0;
        gclass224_1.double_1 = 0.0;
        gclass224_1.double_0 = 0.0;
        gclass224_1.bool_0 = false;
        this.list_0.Add(gclass224_1);
      }
      if (gclass224_1.double_1 < gclass194_1.double_9)
      {
        num1 = gclass194_1.double_9 - gclass224_1.double_1 + 0.01;
        gclass224_1.double_1 = gclass194_1.double_9 + 0.01;
      }
      else if (gclass224_1.double_1 > gclass194_1.double_10)
      {
        num1 = gclass224_1.double_1 - gclass194_1.double_10 + 0.01;
        gclass224_1.double_1 = gclass194_1.double_10 - 0.01;
      }
      this.method_57(gclass21_0, gclass194_1);
      if (gclass224_1.double_1 > this.double_15 * 0.3)
      {
        GClass224 gclass224_2 = this.list_0.FirstOrDefault<GClass224>((Func<GClass224, bool>) (gclass224_0 => gclass224_0.gclass223_0 == this.gclass0_0.dictionary_23[GEnum47.const_7]));
        if (gclass224_2 == null)
        {
          gclass224_2 = new GClass224();
          gclass224_2.gclass223_0 = this.gclass0_0.dictionary_23[GEnum47.const_7];
          gclass224_2.int_0 = this.int_0;
          gclass224_2.double_1 = 0.0;
          gclass224_2.double_0 = 0.0;
          gclass224_2.bool_0 = false;
          this.list_0.Add(gclass224_1);
        }
        double num2 = gclass224_1.double_1 / 0.3 + 0.01;
        double num3 = num2 - this.double_15;
        if (num3 + this.double_15 < gclass194_1.double_2)
        {
          gclass224_2.double_1 = num2;
          num1 += num3;
          this.method_57(gclass21_0, gclass194_1);
        }
      }
      return num1 / double_45;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3834);
      return 0.0;
    }
  }

  public double method_56(GClass21 gclass21_0, GClass194 gclass194_1, double double_45)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass1.Class316 class316 = new GClass1.Class316();
      if (this.double_31 < gclass194_1.double_11 && this.double_32 > gclass194_1.double_12)
        return 0.0;
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 0.0;
      if (this.double_31 > gclass194_1.double_11)
        num2 = this.double_31 - gclass194_1.double_11;
      if (this.double_32 < gclass194_1.double_12)
        num3 = gclass194_1.double_12 - this.double_32;
      // ISSUE: reference to a compiler-generated field
      class316.gclass223_0 = new GClass223();
      if (num2 > 0.0 && num2 > num3)
      {
        // ISSUE: reference to a compiler-generated field
        class316.gclass223_0 = this.gclass0_0.dictionary_23[GEnum47.const_21];
      }
      else
      {
        if (num3 <= 0.0 || num3 <= num2)
          return 0.0;
        // ISSUE: reference to a compiler-generated field
        class316.gclass223_0 = this.gclass0_0.dictionary_23[GEnum47.const_20];
      }
      // ISSUE: reference to a compiler-generated method
      GClass224 gclass224 = this.list_0.Where<GClass224>(new Func<GClass224, bool>(class316.method_0)).FirstOrDefault<GClass224>();
      if (gclass224 == null)
      {
        gclass224 = new GClass224();
        // ISSUE: reference to a compiler-generated field
        gclass224.gclass223_0 = class316.gclass223_0;
        gclass224.int_0 = this.int_0;
        gclass224.double_1 = 0.0;
        gclass224.double_0 = 0.0;
        gclass224.bool_0 = false;
        this.list_0.Add(gclass224);
      }
      Decimal decimal1 = this.decimal_1;
      while (true)
      {
        gclass224.double_1 += 0.001;
        num1 += 0.001;
        this.method_57(gclass21_0, gclass194_1);
        if (!(this.decimal_1 == 0M))
        {
          if (!(this.decimal_1 > decimal1))
            decimal1 = this.decimal_1;
          else
            break;
        }
        else
          goto label_19;
      }
      gclass224.double_1 -= 0.001;
      num1 -= 0.001;
      if (gclass224.double_1 == 0.0)
        this.list_0.Remove(gclass224);
      this.method_57(gclass21_0, gclass194_1);
label_19:
      return num1 / double_45;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3832);
      return 0.0;
    }
  }

  public void method_57(GClass21 gclass21_0, GClass194 gclass194_1)
  {
    try
    {
      this.method_46();
      this.method_36(gclass21_0);
      this.method_35();
      this.method_32();
      this.method_58(gclass21_0, gclass194_1, true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3833);
    }
  }

  public Decimal method_58(GClass21 gclass21_0, GClass194 gclass194_1, bool bool_10)
  {
    try
    {
      this.decimal_0 = 0M;
      this.decimal_1 = 0M;
      double num1 = 0.0;
      if (this.double_27 <= 0.0)
      {
        this.double_37 = this.double_2;
        this.double_27 = this.double_2 * (1.0 - this.double_24);
        this.double_28 = this.double_2 * (1.0 + this.double_24);
      }
      if (gclass194_1 == null)
        gclass194_1 = gclass21_0.method_164();
      if (this.auroraSystemBodyType_0 != AuroraSystemBodyType.GasGiant && this.auroraSystemBodyType_0 != AuroraSystemBodyType.Superjovian && this.double_7 <= gclass194_1.double_8 && !this.bool_2)
      {
        double num2 = (double) this.method_43(gclass194_1);
        if (this.double_4 < gclass194_1.double_12)
          num1 = Math.Abs(gclass194_1.double_12 - this.double_4) / gclass194_1.double_4;
        else if (this.double_4 > gclass194_1.double_11)
          num1 = Math.Abs(gclass194_1.double_11 - this.double_4) / gclass194_1.double_4;
        if (this.bool_0 && this.genum12_0 != GEnum12.const_2)
          num1 /= 5.0;
        if (num1 > num2)
          num2 = num1;
        double num3 = 0.0;
        if (this.double_15 > gclass194_1.double_2)
        {
          num3 = this.double_15 / gclass194_1.double_2;
          if (num3 < 2.0)
            num3 = 2.0;
        }
        if (num2 < num3)
          num2 = num3;
        if (Math.Round(num2, 4) < 2.0)
        {
          double num4 = this.method_45(gclass194_1.gclass223_0);
          if (num4 >= gclass194_1.double_9 && num4 <= gclass194_1.double_10)
          {
            if (this.method_44(gclass194_1.gclass223_0) > (double) GClass226.int_22)
              num2 = 2.0;
          }
          else
            num2 = 2.0;
        }
        if (this.double_19 < 20.0)
        {
          double num5 = (20.0 - this.double_19) / 10.0;
          if (num2 < num5)
            num2 = num5;
        }
        if (this.double_7 < gclass194_1.double_7 && num2 < 1.0)
          num2 = 1.0;
        this.decimal_0 = (Decimal) Math.Round(num2, 4) * gclass21_0.decimal_19;
      }
      else
      {
        this.decimal_0 = -1M;
        this.decimal_1 = -1M;
        this.double_31 = this.method_51(this.double_27);
        this.double_32 = this.method_51(this.double_28);
        this.double_33 = this.double_31 <= this.double_32 ? this.double_32 : this.double_31;
      }
      if (bool_10 && this.decimal_0 > -1M && (this.double_24 > 0.0 || this.genum12_0 == GEnum12.const_2))
      {
        if (this.genum12_0 == GEnum12.const_2)
        {
          if (this.gclass1_0.double_27 <= 0.0)
          {
            this.gclass1_0.double_27 = this.gclass1_0.double_2 * (1.0 - this.gclass1_0.double_24);
            this.gclass1_0.double_28 = this.gclass1_0.double_2 * (1.0 + this.gclass1_0.double_24);
          }
          this.double_34 = this.method_52(gclass21_0, gclass194_1, this.gclass1_0.double_27, GEnum81.const_1);
          this.double_35 = this.method_52(gclass21_0, gclass194_1, this.gclass1_0.double_28, GEnum81.const_2);
        }
        else
        {
          this.double_34 = this.method_52(gclass21_0, gclass194_1, this.double_27, GEnum81.const_1);
          this.double_35 = this.method_52(gclass21_0, gclass194_1, this.double_28, GEnum81.const_2);
        }
        double num6;
        if (this.double_34 > this.double_35)
        {
          this.double_33 = this.double_31;
          num6 = this.double_34;
        }
        else
        {
          this.double_33 = this.double_32;
          num6 = this.double_35;
        }
        this.decimal_1 = !((Decimal) num6 > this.decimal_0) ? this.decimal_0 : (Decimal) num6;
      }
      else
      {
        this.decimal_1 = this.decimal_0;
        this.double_34 = (double) this.decimal_0;
        this.double_35 = (double) this.decimal_0;
        this.double_31 = this.double_4;
        this.double_32 = this.double_4;
        this.double_33 = this.double_4;
      }
      return this.decimal_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3040);
      return -2M;
    }
  }

  public string method_59()
  {
    try
    {
      string str1 = "-";
      string str2 = "";
      string str3;
      if (this.double_15 > 20.0 && this.double_4 > 500.0)
      {
        str3 = "Venusian";
      }
      else
      {
        int num = 1;
        foreach (GClass224 gclass224 in this.list_0)
        {
          if (num == 1)
            str1 = gclass224.gclass223_0.genum47_0 != GEnum47.const_13 ? (gclass224.gclass223_0.genum47_0 != GEnum47.const_5 ? gclass224.gclass223_0.Name : "Water") : "CO2";
          if (num == 2)
            str2 = gclass224.gclass223_0.genum47_0 != GEnum47.const_13 ? (gclass224.gclass223_0.genum47_0 != GEnum47.const_5 ? " - " + gclass224.gclass223_0.Name : " - Water") : " - CO2";
          if (gclass224.gclass223_0.genum47_0 == GEnum47.const_10 && str1 != "Oxygen")
            str2 = $" - Oxygen ({GClass226.smethod_44(gclass224.double_1, 2)})";
          ++num;
        }
        str3 = str1 + str2;
      }
      return str3;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3041);
      return "-";
    }
  }

  public void method_60(
    ListView listView_0,
    CheckState checkState_0,
    CheckState checkState_1,
    CheckState checkState_2,
    CheckState checkState_3,
    CheckState checkState_4,
    GClass21 gclass21_0,
    GClass194 gclass194_1,
    bool bool_10)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass1.Class317 class317 = new GClass1.Class317();
    // ISSUE: reference to a compiler-generated field
    class317.gclass21_0 = gclass21_0;
    // ISSUE: reference to a compiler-generated field
    class317.gclass1_0 = this;
    try
    {
      Color color_0 = GClass226.color_16;
      string str1 = "-";
      string string_17 = "-";
      string str2 = "";
      string string_18 = "-";
      string string_16 = "-";
      string string_31 = "-";
      string string_30 = "-";
      string string_23 = "-";
      string string_24 = "-";
      List<string> stringList = new List<string>();
      // ISSUE: reference to a compiler-generated field
      string str3 = this.method_78(class317.gclass21_0);
      this.list_0 = this.list_0.OrderByDescending<GClass224, double>((Func<GClass224, double>) (gclass224_0 => gclass224_0.double_1)).ToList<GClass224>();
      if (this.list_0.Count > 0)
      {
        string_18 = GClass226.smethod_50(this.double_15);
        if (this.list_0.Count<GClass224>((Func<GClass224, bool>) (gclass224_0 => gclass224_0.bool_0)) > 0)
          string_18 += "F";
        string_17 = this.method_59();
      }
      // ISSUE: reference to a compiler-generated method
      foreach (GClass146 gclass146 in this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class317.method_0)).OrderByDescending<GClass146, Decimal>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.decimal_30)).ToList<GClass146>())
      {
        // ISSUE: reference to a compiler-generated field
        str1 = !(gclass146.PopName == str3) ? $"{gclass146.PopName} {GClass226.smethod_61(gclass146.decimal_30, "m")}" : $"{class317.gclass21_0.string_0} {GClass226.smethod_61(gclass146.decimal_30, "m")}";
        stringList.Add(str1);
      }
      // ISSUE: reference to a compiler-generated field
      bool flag = this.method_77(class317.gclass21_0);
      if (this.gclass174_0 != null && flag)
        stringList.Add(this.gclass174_0.string_0);
      if (this.gclass220_0 != null && flag)
        stringList.Add(this.gclass220_0.method_0());
      if (stringList.Count == 0)
        stringList.Add(str1);
      if (this.double_19 > 0.0)
        string_16 = $"{GClass226.smethod_82((Enum) this.auroraHydrosphereType_0)} {GClass226.smethod_44(this.double_19, 1)}%";
      if (this.auroraTectonics_0 != AuroraTectonics.Dead)
        string_30 = GClass226.smethod_82((Enum) this.auroraTectonics_0);
      if (this.double_14 > 0.0)
        string_31 = GClass226.smethod_52(this.double_14);
      if (this.bool_0)
        string_23 = this.genum12_0 != GEnum12.const_2 ? "Yes" : "Yes - M";
      // ISSUE: reference to a compiler-generated field
      Decimal num1 = this.method_58(class317.gclass21_0, gclass194_1, true);
      if (checkState_3 == CheckState.Checked && this.decimal_1 > 0M)
        num1 = this.decimal_1;
      Decimal num2 = 1M;
      // ISSUE: reference to a compiler-generated field
      GClass164 gclass164 = class317.gclass21_0.method_388(this.gclass0_0.dictionary_49[GEnum122.const_35]);
      if (gclass164 != null)
        num2 = Math.Round(gclass164.decimal_0, 2);
      if (num1 >= 0M)
      {
        if (num1 < 2M * num2)
          color_0 = Color.DodgerBlue;
        else if (num1 < 3M * num2)
          color_0 = Color.Cyan;
        else if (num1 < 6M * num2 && this.double_7 > gclass194_1.double_7)
          color_0 = Color.Chocolate;
      }
      this.method_62(gclass194_1);
      if (this.decimal_5 > 0M)
        string_24 = GClass226.smethod_53(this.decimal_5);
      string string_11 = "";
      if (checkState_0 == CheckState.Checked && this.dictionary_0.Count > 0 && flag)
        string_11 = "M";
      if (checkState_1 == CheckState.Checked && !flag)
        string_11 = "U";
      // ISSUE: reference to a compiler-generated field
      if (checkState_4 == CheckState.Checked && this.double_20 * 2.0 <= (double) class317.gclass21_0.int_11 && (this.dictionary_0.Count > 0 || !flag))
        string_11 += "E";
      if (checkState_2 == CheckState.Checked && this.auroraGroundMineralSurvey_0 != AuroraGroundMineralSurvey.Completed && flag)
        string_11 += ((int) this.auroraGroundMineralSurvey_0).ToString();
      string string_15 = "-";
      if (this.gclass99_0.genum111_0 != GEnum111.const_0)
        string_15 = this.gclass99_0.Name;
      string string_12 = GClass226.smethod_82((Enum) this.auroraSystemBodyType_0);
      if (bool_10)
      {
        // ISSUE: reference to a compiler-generated field
        string_12 = class317.gclass21_0.method_277(this.gclass200_0.int_0);
      }
      // ISSUE: reference to a compiler-generated field
      string string_10 = str2 + this.method_78(class317.gclass21_0);
      if (this.genum12_0 == GEnum12.const_2 && !bool_10)
      {
        // ISSUE: reference to a compiler-generated field
        string_10 = "    " + this.method_79(class317.gclass21_0, true, false);
      }
      // ISSUE: reference to a compiler-generated field
      if (class317.gclass21_0.list_9.Contains(this))
        string_10 += " (B)";
      string string_43 = this.method_61(false, false);
      string string_19 = GClass226.smethod_50(this.double_4 - (double) GClass226.int_17);
      if (checkState_3 == CheckState.Checked)
        string_19 = GClass226.smethod_50(this.double_33 - (double) GClass226.int_17);
      GEnum80 genum80_0 = GEnum80.const_0;
      if (checkState_3 == CheckState.Checked)
        genum80_0 = GEnum80.const_1;
      string string_27 = "-";
      string string_28 = "-";
      string string_25 = "-";
      string string_26 = "-";
      if (this.double_24 > 0.0)
      {
        string_27 = GClass226.smethod_44(this.double_24, 3);
        double double_32 = this.double_25 + 90.0;
        if (double_32 >= 360.0)
          double_32 -= 360.0;
        string_28 = GClass226.smethod_44(double_32, 1);
        string_25 = this.method_65();
        string_26 = this.method_66();
      }
      this.gclass0_0.method_631(listView_0, string_10, string_11, string_12, this.method_47(gclass194_1, genum80_0), stringList[0], string_15, string_16, string_17, string_18, string_19, GClass226.smethod_52(this.double_7), this.method_64(), GClass226.smethod_50(this.double_20 * 2.0), string_23, string_24, string_25, string_26, string_27, string_28, GClass226.smethod_57(this.double_10), string_30, string_31, GClass226.smethod_52(this.double_17), GClass226.smethod_52(this.double_18), GClass226.smethod_52(this.double_16), GClass226.smethod_57(this.double_12), GClass226.smethod_52(this.double_8), GClass226.smethod_52(this.double_6), GClass226.smethod_52(this.double_9 * 11.18), GClass226.smethod_51((Decimal) this.int_7), GClass226.smethod_50(this.double_3 - (double) GClass226.int_17), GClass226.smethod_42(this.decimal_3, 0), GClass226.smethod_42(this.decimal_4, 0), string_43, color_0, (object) this);
      for (int index = 1; stringList.Count > index; ++index)
      {
        string string_14 = stringList[index];
        this.gclass0_0.method_606(listView_0, "", "", "", "", string_14, color_0, (object) this);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3042);
    }
  }

  public string method_61(bool bool_10, bool bool_11)
  {
    try
    {
      if (this.double_8 < 0.25 || this.auroraSystemBodyType_0 == AuroraSystemBodyType.Comet)
        return "-";
      if (this.gclass0_0.dictionary_14.Values.Count<GClass212>((Func<GClass212, bool>) (gclass212_0 => gclass212_0.gclass1_0 == this)) > 0 && bool_10)
        return "Existing LP";
      string str = GClass226.smethod_44(60.0 / Math.Sqrt(this.double_8) / 12.0, 2);
      return bool_11 ? str + " years" : str;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3043);
      return "-";
    }
  }

  public Decimal method_62(GClass194 gclass194_1)
  {
    try
    {
      if (this.decimal_0 == -1M)
      {
        this.decimal_5 = 0M;
        return 0M;
      }
      this.decimal_5 = (Decimal) (4.0 * GClass226.double_13 * Math.Pow(this.double_20, 2.0)) / GClass226.decimal_15 * (Decimal) GClass226.int_16;
      if (gclass194_1 != null)
        this.decimal_5 *= gclass194_1.decimal_0;
      if (this.double_19 > 75.0)
      {
        double num = (100.0 - this.double_19) / 25.0;
        if (num < 0.01)
          num = 0.01;
        this.decimal_5 *= (Decimal) num;
      }
      if (this.bool_0 && this.genum12_0 != GEnum12.const_2)
        this.decimal_5 /= 5M;
      if (this.decimal_5 < 0.05M)
        this.decimal_5 = 0.05M;
      return this.decimal_5;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3044);
      return 0M;
    }
  }

  public string method_63(AuroraSystemBodyType auroraSystemBodyType_1)
  {
    try
    {
      return GClass226.smethod_82((Enum) (AuroraSystemBodyTypeAbbrev) auroraSystemBodyType_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3045);
      return "error";
    }
  }

  public string method_64()
  {
    try
    {
      if (this.genum12_0 != GEnum12.const_2)
        return GClass226.smethod_1(this.double_37);
      return this.double_2 > 1000000.0 ? GClass226.smethod_50(this.double_2 / 1000000.0) + "m" : GClass226.smethod_43(this.double_2 / 1000.0) + "k";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3046);
      return "error";
    }
  }

  public string method_65()
  {
    try
    {
      if (this.genum12_0 != GEnum12.const_2)
        return GClass226.smethod_1(this.double_27);
      return this.double_2 > 1000000.0 ? GClass226.smethod_50(this.double_2 / 1000000.0) + "m" : GClass226.smethod_43(this.double_2 / 1000.0) + "k";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3452);
      return "error";
    }
  }

  public string method_66()
  {
    try
    {
      if (this.genum12_0 != GEnum12.const_2)
        return GClass226.smethod_1(this.double_28);
      return this.double_2 > 1000000.0 ? GClass226.smethod_50(this.double_2 / 1000000.0) + "m" : GClass226.smethod_43(this.double_2 / 1000.0) + "k";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3451);
      return "error";
    }
  }

  public void method_67(ListView listView_0, ListView listView_1, GClass21 gclass21_0)
  {
    try
    {
      listView_0.Items.Clear();
      listView_1.Items.Clear();
      GClass194 gclass194_1 = gclass21_0.method_164();
      this.method_27();
      this.method_58(gclass21_0, gclass194_1, true);
      this.gclass0_0.method_597(listView_0, "Name", this.method_78(gclass21_0));
      this.gclass0_0.method_597(listView_0, "Colony Cost", this.method_47(gclass21_0.method_164(), GEnum80.const_0));
      if (this.bool_2)
      {
        this.gclass0_0.method_597(listView_0, "Orbital Distance", $"{GClass226.smethod_59(this.double_2 * GClass226.double_14, "km")}  ({GClass226.smethod_59(this.double_2, "AU")})");
        this.gclass0_0.method_597(listView_0, "Temperature", GClass226.smethod_59(this.double_3 - (double) GClass226.int_17, "C"));
      }
      else
      {
        if (this.decimal_1 > this.decimal_0 && this.decimal_1 > 0M)
          this.gclass0_0.method_597(listView_0, "Max Colony Cost", this.method_47(gclass21_0.method_164(), GEnum80.const_1));
        this.gclass0_0.method_597(listView_0, "Body Type", GClass226.smethod_82((Enum) this.auroraSystemBodyType_0));
        this.gclass0_0.method_597(listView_0, "Diameter", GClass226.smethod_59(this.double_20 * 2.0, "km"));
        if (this.genum12_0 == GEnum12.const_2)
          this.gclass0_0.method_597(listView_0, "Orbital Distance", GClass226.smethod_59(this.double_2, "km"));
        else if (this.double_24 > 0.0)
        {
          this.gclass0_0.method_597(listView_0, "Current Distance", $"{GClass226.smethod_59(this.double_2 * GClass226.double_14, "km")}  ({GClass226.smethod_59(this.double_2, "AU")})");
          this.gclass0_0.method_597(listView_0, "Perihelion", $"{GClass226.smethod_59(this.double_27 * GClass226.double_14, "km")}  ({GClass226.smethod_59(this.double_27, "AU")})");
          this.gclass0_0.method_597(listView_0, "Aphelion", $"{GClass226.smethod_59(this.double_28 * GClass226.double_14, "km")}  ({GClass226.smethod_59(this.double_28, "AU")})");
          this.gclass0_0.method_597(listView_0, "Eccentricity", GClass226.smethod_44(this.double_24, 4));
          double double_32 = this.double_25 + 90.0;
          if (double_32 >= 360.0)
            double_32 -= 360.0;
          this.gclass0_0.method_597(listView_0, "Inclination", GClass226.smethod_44(double_32, 4) + char.ConvertFromUtf32(176 /*0xB0*/));
        }
        else
          this.gclass0_0.method_597(listView_0, "Orbital Distance", $"{GClass226.smethod_59(this.double_2 * GClass226.double_14, "km")}  ({GClass226.smethod_59(this.double_2, "AU")})");
        this.gclass0_0.method_597(listView_0, "Gravity", GClass226.smethod_59(this.double_7, "G"));
        if (this.list_0.Count == 0)
        {
          this.gclass0_0.method_597(listView_0, "Atmosphere", "None");
        }
        else
        {
          this.gclass0_0.method_597(listView_0, "Atmosphere", "Atmospheric Pressure " + GClass226.smethod_59(this.double_15, "atm"));
          this.list_0 = this.list_0.OrderByDescending<GClass224, double>((Func<GClass224, double>) (gclass224_0 => gclass224_0.double_1)).ToList<GClass224>();
          foreach (GClass224 gclass224 in this.list_0)
            this.gclass0_0.method_597(listView_0, "", $"{gclass224.gclass223_0.Name} {GClass226.smethod_59(gclass224.double_0, "%")}");
        }
        this.gclass0_0.method_597(listView_0, "Hydrosphere", GClass226.smethod_82((Enum) this.auroraHydrosphereType_0));
        this.gclass0_0.method_597(listView_0, "Hydro Extent", GClass226.smethod_59(this.double_19, "%"));
        this.gclass0_0.method_597(listView_0, "Year", GClass226.smethod_31(this.double_10));
        this.gclass0_0.method_597(listView_0, "Day", GClass226.smethod_31(this.double_12));
        this.gclass0_0.method_597(listView_0, "Surface Temperature", GClass226.smethod_59(this.double_4 - (double) GClass226.int_17, "C"));
        this.gclass0_0.method_597(listView_0, "Tectonics", GClass226.smethod_82((Enum) this.auroraTectonics_0));
        this.gclass0_0.method_597(listView_0, "Mass", GClass226.smethod_48(this.double_8));
        this.gclass0_0.method_597(listView_0, "Density", GClass226.smethod_48(this.double_6));
        ListViewItem listViewItem = new ListViewItem("");
        if (this.bool_0)
          this.gclass0_0.method_597(listView_0, "Tidal Lock", "Yes");
        else
          this.gclass0_0.method_597(listView_0, "Tidal Lock", "No");
        this.gclass0_0.method_597(listView_0, "Base Temperature", GClass226.smethod_59(this.double_3 - (double) GClass226.int_17, "C"));
        this.gclass0_0.method_597(listView_0, "Albedo", GClass226.smethod_44(this.double_16, 2));
        this.gclass0_0.method_597(listView_0, "Greenhouse Factor", GClass226.smethod_44(this.double_17, 2));
        this.gclass0_0.method_597(listView_0, "Anti-GH Factor", GClass226.smethod_44(this.double_18, 2));
        if (this.method_77(gclass21_0))
        {
          if (this.dictionary_0.Count > 0)
          {
            foreach (GClass124 gclass124 in this.dictionary_0.Values)
              this.gclass0_0.method_601(listView_1, gclass124.auroraElement_0.ToString(), string.Format("{0:0,0}", (object) gclass124.decimal_0) + "  tons", "Acc  " + gclass124.decimal_1.ToString());
          }
        }
        else
          this.gclass0_0.method_594(listView_1, "No Survey");
      }
      listView_0.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
      listView_1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
      listView_1.Columns[0].Width = listView_0.Columns[0].Width;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3047);
    }
  }

  public void method_68(ListView listView_0, GClass21 gclass21_0)
  {
    try
    {
      listView_0.Items.Clear();
      if (this.method_77(gclass21_0))
      {
        if (this.dictionary_0.Count <= 0)
          return;
        this.dictionary_0 = this.dictionary_0.OrderBy<KeyValuePair<AuroraElement, GClass124>, AuroraElement>((Func<KeyValuePair<AuroraElement, GClass124>, AuroraElement>) (keyValuePair_0 => keyValuePair_0.Value.auroraElement_0)).ToDictionary<KeyValuePair<AuroraElement, GClass124>, AuroraElement, GClass124>((Func<KeyValuePair<AuroraElement, GClass124>, AuroraElement>) (keyValuePair_0 => keyValuePair_0.Key), (Func<KeyValuePair<AuroraElement, GClass124>, GClass124>) (keyValuePair_0 => keyValuePair_0.Value));
        foreach (GClass124 gclass124 in this.dictionary_0.Values)
          this.gclass0_0.method_601(listView_0, gclass124.auroraElement_0.ToString(), string.Format("{0:0,0}", (object) gclass124.decimal_0), GClass226.smethod_45(gclass124.decimal_1, 2));
      }
      else
        this.gclass0_0.method_594(listView_0, "No Survey");
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3048);
    }
  }

  public void method_69(TextBox textBox_0, GClass21 gclass21_0)
  {
    try
    {
      string str = $"{this.method_78(gclass21_0)} Survey Report{Environment.NewLine}";
      if (this.method_77(gclass21_0))
      {
        if (this.dictionary_0.Count > 0)
        {
          foreach (GClass124 gclass124 in this.dictionary_0.Values)
            str = $"{str}{gclass124.auroraElement_0.ToString()}:   {string.Format("{0:0,0}", (object) gclass124.decimal_0)}   {GClass226.smethod_45(gclass124.decimal_1, 2)}{Environment.NewLine}";
        }
      }
      else
        str = "No Survey";
      textBox_0.Text = str;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3049);
    }
  }

  public void method_70(ListView listView_0, GClass146 gclass146_0, bool bool_10)
  {
    try
    {
      listView_0.Items.Clear();
      if (this.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || this.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian)
        return;
      int int_72 = 3;
      if (bool_10)
        int_72 = 4;
      double num1 = 0.0;
      double double_45 = 0.0;
      double double_46 = 0.0;
      double double_32_1 = 0.0;
      double double_32_2 = 0.0;
      this.list_0 = this.list_0.OrderByDescending<GClass224, double>((Func<GClass224, double>) (gclass224_0 => gclass224_0.double_1)).ToList<GClass224>();
      if (this.list_0.Count > 0)
      {
        this.gclass0_0.method_601(listView_0, "Gas", "%", "atm");
        if (this.list_0.Count > 0)
        {
          foreach (GClass224 gclass224 in this.list_0)
            num1 += gclass224.double_1;
          foreach (GClass224 object_1 in this.list_0)
          {
            string name = object_1.gclass223_0.Name;
            if (object_1.bool_0)
              name += " (F)";
            else if (object_1.gclass223_0.bool_0)
            {
              double_45 += object_1.double_1;
              double_32_1 += object_1.double_1;
            }
            else if (object_1.gclass223_0.bool_1)
            {
              double_46 += object_1.double_1;
              double_32_2 += object_1.double_1;
            }
            object_1.double_0 = object_1.double_1 / num1 * 100.0;
            this.gclass0_0.method_602(listView_0, name, GClass226.smethod_46(object_1.double_0, 3), GClass226.smethod_46(object_1.double_1, int_72), (object) object_1);
          }
        }
        this.gclass0_0.method_594(listView_0, "");
      }
      this.method_28(double_45, double_46);
      if (bool_10)
      {
        this.gclass0_0.method_601(listView_0, "Atmospheric Pressure", GClass226.smethod_46(this.double_15, 3), (string) null);
        this.gclass0_0.method_601(listView_0, "Greenhouse Gas Pressure", GClass226.smethod_46(double_32_1, 3), (string) null);
        this.gclass0_0.method_601(listView_0, "Anti-Greenhouse Gas Pressure", GClass226.smethod_46(double_32_2, 3), (string) null);
        this.gclass0_0.method_601(listView_0, "Greenhouse Factor", GClass226.smethod_46(this.double_17, 3), (string) null);
        this.gclass0_0.method_601(listView_0, "Anti-Greenhouse Factor", GClass226.smethod_46(this.double_18, 3), (string) null);
        if (this.decimal_4 > 0M)
          this.gclass0_0.method_601(listView_0, "Dust Effective Atm", GClass226.smethod_45(this.decimal_4 / 20000M, 3), (string) null);
        this.gclass0_0.method_601(listView_0, "Albedo Factor", GClass226.smethod_46(this.double_16, 3), (string) null);
        this.gclass0_0.method_594(listView_0, "");
        double double_32_3 = 0.0;
        double double_32_4 = 0.0;
        double double_32_5 = 0.0;
        if (gclass146_0.gclass194_0.double_12 > this.double_4)
          double_32_3 = this.double_4 - gclass146_0.gclass194_0.double_12;
        else if (this.double_4 > gclass146_0.gclass194_0.double_11)
          double_32_3 = this.double_4 - gclass146_0.gclass194_0.double_11;
        if (gclass146_0.gclass194_0.double_12 > this.double_32)
          double_32_4 = this.double_32 - gclass146_0.gclass194_0.double_12;
        else if (this.double_32 > gclass146_0.gclass194_0.double_11)
          double_32_4 = this.double_32 - gclass146_0.gclass194_0.double_11;
        if (gclass146_0.gclass194_0.double_12 > this.double_31)
          double_32_5 = this.double_31 - gclass146_0.gclass194_0.double_12;
        else if (this.double_31 > gclass146_0.gclass194_0.double_11)
          double_32_5 = this.double_31 - gclass146_0.gclass194_0.double_11;
        this.gclass0_0.method_601(listView_0, "Base Temperature (Celsius)", GClass226.smethod_46(this.double_3 - (double) GClass226.int_17, 3), (string) null);
        this.gclass0_0.method_601(listView_0, "Surface Temperature (Celsius)", GClass226.smethod_46(this.double_4 - (double) GClass226.int_17, 3), (string) null);
        this.gclass0_0.method_594(listView_0, "");
        this.gclass0_0.method_601(listView_0, "Minimum Temperature (Celsius)", GClass226.smethod_46(this.double_32 - (double) GClass226.int_17, 3), (string) null);
        this.gclass0_0.method_601(listView_0, "Maximum Temperature (Celsius)", GClass226.smethod_46(this.double_31 - (double) GClass226.int_17, 3), (string) null);
        this.gclass0_0.method_594(listView_0, "");
        this.gclass0_0.method_601(listView_0, "Current Temp vs Species", GClass226.smethod_46(double_32_3, 3), (string) null);
        this.gclass0_0.method_601(listView_0, "Min Temp vs Species", GClass226.smethod_46(double_32_4, 3), (string) null);
        this.gclass0_0.method_601(listView_0, "Max Temp vs Species", GClass226.smethod_46(double_32_5, 3), (string) null);
        this.gclass0_0.method_594(listView_0, "");
        this.gclass0_0.method_601(listView_0, "Base Temperature (Kelvin)", GClass226.smethod_46(this.double_3, 3), (string) null);
        this.gclass0_0.method_601(listView_0, "Surface Temperature (Kelvin)", GClass226.smethod_46(this.double_4, 3), (string) null);
        this.gclass0_0.method_594(listView_0, "");
        this.gclass0_0.method_601(listView_0, "Hydrographic Extent", GClass226.smethod_46(this.double_19, 2), (string) null);
        this.gclass0_0.method_594(listView_0, "");
        this.gclass0_0.method_601(listView_0, "Radiation Level", GClass226.smethod_45(this.decimal_3, 2), (string) null);
        this.gclass0_0.method_601(listView_0, "Atmospheric Dust Level", GClass226.smethod_45(this.decimal_4, 2), (string) null);
        if (this.decimal_3 > 0M)
        {
          this.gclass0_0.method_601(listView_0, "Radiation Production Impact", GClass226.smethod_45(this.decimal_3 / 10000M, 2) + "%", (string) null);
          this.gclass0_0.method_601(listView_0, "Radiation Growth Rate Impact", GClass226.smethod_45(this.decimal_3 * 0.0025M, 2) + "%", (string) null);
        }
        double num2 = 4.0 * GClass226.double_13 * Math.Pow(this.double_20, 2.0);
        double double_32_6 = (double) GClass226.decimal_15 / num2;
        this.gclass0_0.method_594(listView_0, "");
        this.gclass0_0.method_601(listView_0, "Body Diameter", GClass226.smethod_43(this.double_20 * 2.0), (string) null);
        this.gclass0_0.method_601(listView_0, "Terraform Rate vs Earth (1.00)", GClass226.smethod_46(double_32_6, 2), (string) null);
        gclass146_0.method_100();
        if (!(gclass146_0.decimal_24 > 0M))
          return;
        int num3 = (int) gclass146_0.method_62(AuroraProductionCategory.Terraforming);
        int num4 = gclass146_0.method_202(AuroraComponentType.TerraformingModule);
        if (num3 > 0 && num4 == 0)
          this.gclass0_0.method_601(listView_0, "Terraforming Installations", num3.ToString(), (string) null);
        else if (num3 == 0 && num4 > 0)
          this.gclass0_0.method_601(listView_0, "Orbital Terraforming Modules", num4.ToString(), (string) null);
        else
          this.gclass0_0.method_601(listView_0, "Terraforming Modules (S/O)", $"{num3.ToString()} / {num4.ToString()}", (string) null);
        double double_32_7 = (double) gclass146_0.decimal_24 * double_32_6;
        this.gclass0_0.method_601(listView_0, "Annual Terraform Capacity (atm)", GClass226.smethod_46(double_32_7, 4), (string) null);
      }
      else
      {
        this.gclass0_0.method_603(listView_0, "GH Factor / Albedo", GClass226.smethod_46(this.double_17, 2), GClass226.smethod_46(this.double_16, 2), (string) null);
        this.gclass0_0.method_603(listView_0, "AGH Factor / Dust", GClass226.smethod_46(this.double_18, 2), GClass226.smethod_45(this.decimal_4, 0), (string) null);
        this.gclass0_0.method_601(listView_0, "Base/Surface Temp", GClass226.smethod_46(this.double_3 - (double) GClass226.int_17, 2), GClass226.smethod_46(this.double_4 - (double) GClass226.int_17, 2));
        this.gclass0_0.method_601(listView_0, "Min/Max Surface Temp", GClass226.smethod_46(this.double_32 - (double) GClass226.int_17, 2), GClass226.smethod_46(this.double_31 - (double) GClass226.int_17, 2));
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3050);
    }
  }

  public void method_71(
    GClass21 gclass21_0,
    GClass194 gclass194_1,
    CheckState checkState_0,
    Label label_0,
    Label label_1,
    Label label_2,
    Label label_3,
    Label label_4,
    Label label_5,
    Label label_6,
    Label label_7,
    Label label_8,
    Label label_9,
    int int_13)
  {
    try
    {
      string str1 = "2.00";
      string str2 = "0.00";
      string str3 = "1.00 LG";
      if (int_13 == 3)
      {
        str1 = "2.000";
        str2 = "0.000";
        str3 = "1.000 LG";
      }
      label_7.Text = this.method_48(gclass194_1, int_13, GEnum80.const_0);
      label_8.Text = this.method_48(gclass194_1, int_13, GEnum80.const_2);
      label_9.Text = this.method_48(gclass194_1, int_13, GEnum80.const_3);
      if (this.auroraSystemBodyType_0 != AuroraSystemBodyType.GasGiant && this.auroraSystemBodyType_0 != AuroraSystemBodyType.Superjovian)
      {
        if (this.double_7 < 0.1)
          label_0.Text = "No";
        else
          label_0.Text = "Yes";
        if (this.double_7 < gclass194_1.double_7)
          label_1.Text = str3;
        else if (this.double_7 > gclass194_1.double_8)
          label_1.Text = "No";
        else
          label_1.Text = "Yes";
        double double_32_1 = 0.0;
        if (this.double_4 >= gclass194_1.double_12 && this.double_4 <= gclass194_1.double_11)
        {
          label_2.Text = str2;
        }
        else
        {
          if (this.double_4 < gclass194_1.double_12)
            double_32_1 = Math.Abs(gclass194_1.double_12 - this.double_4) / gclass194_1.double_4;
          else if (this.double_4 > gclass194_1.double_11)
            double_32_1 = Math.Abs(gclass194_1.double_11 - this.double_4) / gclass194_1.double_4;
          if (this.bool_0 && this.genum12_0 != GEnum12.const_2)
            double_32_1 /= 5.0;
          label_2.Text = GClass226.smethod_46(double_32_1, int_13);
        }
        if (this.double_15 > gclass194_1.double_2)
        {
          double double_32_2 = this.double_15 / gclass194_1.double_2;
          if (double_32_2 < 2.0)
            double_32_2 = 2.0;
          label_4.Text = GClass226.smethod_46(double_32_2, int_13);
        }
        else
          label_4.Text = str2;
        double num = this.method_45(gclass194_1.gclass223_0);
        if (num >= gclass194_1.double_9 && num <= gclass194_1.double_10)
        {
          if (this.method_44(gclass194_1.gclass223_0) > (double) GClass226.int_22)
            label_3.Text = str1;
          else
            label_3.Text = str2;
        }
        else
          label_3.Text = str1;
        Decimal decimal_73 = (Decimal) this.method_43(gclass194_1);
        label_5.Text = GClass226.smethod_45(decimal_73, int_13);
        double double_32_3 = 0.0;
        if (this.double_19 < 20.0)
          double_32_3 = (20.0 - this.double_19) / 10.0;
        label_6.Text = GClass226.smethod_46(double_32_3, int_13);
      }
      else
      {
        label_1.Text = "-";
        label_0.Text = "-";
        label_4.Text = "-";
        label_3.Text = "-";
        label_2.Text = "-";
        label_4.Text = "-";
        label_5.Text = "-";
        label_6.Text = "-";
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3051);
    }
  }

  public void method_72(
    GClass21 gclass21_0,
    GClass194 gclass194_1,
    ListView listView_0,
    int int_13)
  {
    try
    {
      string string_11_1 = "2.00";
      string string_11_2 = "0.00";
      string string_11_3 = "1.00 LG";
      if (int_13 == 3)
      {
        string_11_1 = "2.000";
        string_11_2 = "0.000";
        string_11_3 = "1.000 LG";
      }
      this.gclass0_0.method_601(listView_0, "Colony Cost", this.method_48(gclass194_1, int_13, GEnum80.const_0), (string) null);
      if (this.double_7 < gclass194_1.double_7)
        this.gclass0_0.method_601(listView_0, "CC - Gravity", string_11_3, (string) null);
      else
        this.gclass0_0.method_601(listView_0, "CC - Gravity", string_11_2, (string) null);
      double double_32_1 = 0.0;
      if (this.double_4 >= gclass194_1.double_12 && this.double_4 <= gclass194_1.double_11)
      {
        this.gclass0_0.method_601(listView_0, "CC - Temperature", string_11_2, (string) null);
      }
      else
      {
        if (this.double_4 < gclass194_1.double_12)
          double_32_1 = Math.Abs(gclass194_1.double_12 - this.double_4) / gclass194_1.double_4;
        else if (this.double_4 > gclass194_1.double_11)
          double_32_1 = Math.Abs(gclass194_1.double_11 - this.double_4) / gclass194_1.double_4;
        if (this.bool_0 && this.genum12_0 != GEnum12.const_2)
          double_32_1 /= 5.0;
        this.gclass0_0.method_601(listView_0, "CC - Temperature", GClass226.smethod_46(double_32_1, int_13), (string) null);
      }
      double num = this.method_45(gclass194_1.gclass223_0);
      if (num >= gclass194_1.double_9 && num <= gclass194_1.double_10)
      {
        if (this.method_44(gclass194_1.gclass223_0) > (double) GClass226.int_22)
          this.gclass0_0.method_601(listView_0, "CC - Breathable", string_11_1, (string) null);
        else
          this.gclass0_0.method_601(listView_0, "CC - Breathable", string_11_2, (string) null);
      }
      else
        this.gclass0_0.method_601(listView_0, "CC - Breathable", string_11_1, (string) null);
      Decimal decimal_73 = (Decimal) this.method_43(gclass194_1);
      this.gclass0_0.method_601(listView_0, "CC - Dangerous Gas", GClass226.smethod_45(decimal_73, int_13), (string) null);
      if (this.double_15 > gclass194_1.double_2)
      {
        double double_32_2 = this.double_15 / gclass194_1.double_2;
        if (double_32_2 < 2.0)
          double_32_2 = 2.0;
        this.gclass0_0.method_601(listView_0, "CC - Pressure", GClass226.smethod_46(double_32_2, int_13), (string) null);
      }
      else
        this.gclass0_0.method_601(listView_0, "CC - Pressure", string_11_2, (string) null);
      double double_32_3 = 0.0;
      if (this.double_19 < 20.0)
        double_32_3 = (20.0 - this.double_19) / 10.0;
      this.gclass0_0.method_601(listView_0, "CC - Water", GClass226.smethod_46(double_32_3, int_13), (string) null);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3052);
    }
  }

  public double method_73()
  {
    try
    {
      return 0.02783 * this.double_3 / Math.Pow(this.double_9, 2.0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3053);
      return -1.0;
    }
  }

  public GClass221 method_74(GClass202 gclass202_0)
  {
    try
    {
      return new GClass221()
      {
        double_0 = (this.double_0 + gclass202_0.double_3) / gclass202_0.double_2 + this.gclass0_0.double_4,
        double_1 = (this.double_1 + gclass202_0.double_4) / gclass202_0.double_2 + this.gclass0_0.double_5
      };
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3054);
      return new GClass221(0.0, 0.0);
    }
  }

  public void method_75(
    Graphics graphics_0,
    Font font_0,
    GClass222 gclass222_0,
    GClass202 gclass202_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass1.Class318 class318 = new GClass1.Class318();
    // ISSUE: reference to a compiler-generated field
    class318.gclass202_0 = gclass202_0;
    // ISSUE: reference to a compiler-generated field
    class318.gclass1_0 = this;
    try
    {
      // ISSUE: reference to a compiler-generated field
      bool flag = this.method_77(class318.gclass202_0.gclass21_0);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (class318.gclass202_0.gclass21_0.chkAst == CheckState.Unchecked && this.auroraSystemBodyType_0 == AuroraSystemBodyType.Asteroid && !this.bool_2 || class318.gclass202_0.gclass21_0.chkMoons == CheckState.Unchecked && this.genum12_0 == GEnum12.const_2 || class318.gclass202_0.gclass21_0.chkDwarf == CheckState.Unchecked && this.auroraSystemBodyType_0 == AuroraSystemBodyType.DwarfPlanet || class318.gclass202_0.gclass21_0.chkPlanets == CheckState.Unchecked && this.genum12_0 == GEnum12.const_1 && this.auroraSystemBodyType_0 != AuroraSystemBodyType.DwarfPlanet || class318.gclass202_0.gclass21_0.chkAstMinOnly == CheckState.Checked && this.auroraSystemBodyType_0 == AuroraSystemBodyType.Asteroid && !this.bool_2 && (!flag || this.dictionary_0.Count == 0) || class318.gclass202_0.gclass21_0.chkAstColOnly == CheckState.Checked && this.auroraSystemBodyType_0 == AuroraSystemBodyType.Asteroid && !this.bool_2 && !class318.gclass202_0.list_4.Contains(this) || this.genum12_0 == GEnum12.const_2 && this.double_2 / class318.gclass202_0.double_2 < (double) GClass226.int_61)
        return;
      int num1 = 0;
      // ISSUE: reference to a compiler-generated field
      if (class318.gclass202_0.gclass21_0.chkSBSurvey == CheckState.Checked && !this.bool_2 && flag)
      {
        Pen pen = new Pen(Color.White);
        double x = gclass222_0.double_2 - (double) GClass226.int_61;
        double y = gclass222_0.double_3 - (double) GClass226.int_61;
        graphics_0.DrawEllipse(pen, (float) x, (float) y, (float) (GClass226.int_61 * 2), (float) (GClass226.int_61 * 2));
        ++num1;
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (class318.gclass202_0.gclass21_0.chkMinerals == CheckState.Checked && this.dictionary_0.Count > 0 && this.method_77(class318.gclass202_0.gclass21_0))
      {
        Pen pen = new Pen(Color.Yellow);
        double num2 = 1.0 + 0.4 * (double) num1;
        double x = gclass222_0.double_2 - (double) GClass226.int_61 * num2;
        double y = gclass222_0.double_3 - (double) GClass226.int_61 * num2;
        graphics_0.DrawEllipse(pen, (float) x, (float) y, (float) GClass226.int_61 * (float) (num2 * 2.0), (float) GClass226.int_61 * (float) (num2 * 2.0));
        ++num1;
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (class318.gclass202_0.gclass21_0.chkColonies == CheckState.Checked && !this.bool_2 && class318.gclass202_0.list_4.Contains(this))
      {
        Pen pen = new Pen(Color.LimeGreen);
        double num3 = 1.0 + 0.4 * (double) num1;
        double x = gclass222_0.double_2 - (double) GClass226.int_61 * num3;
        double y = gclass222_0.double_3 - (double) GClass226.int_61 * num3;
        graphics_0.DrawEllipse(pen, (float) x, (float) y, (float) GClass226.int_61 * (float) (num3 * 2.0), (float) GClass226.int_61 * (float) (num3 * 2.0));
        int num4 = num1 + 1;
      }
      SolidBrush solidBrush = new SolidBrush(Color.Blue);
      GClass221 gclass221_1 = new GClass221();
      // ISSUE: reference to a compiler-generated field
      string text = this.method_78(class318.gclass202_0.gclass21_0);
      double x1 = gclass222_0.double_2 - (double) GClass226.int_61 / 2.0;
      double y1 = gclass222_0.double_3 - (double) GClass226.int_61 / 2.0;
      if (this.genum12_0 == GEnum12.const_5)
      {
        Pen pen = new Pen(Color.Cyan);
        double double_11 = this.gclass0_0.method_591(this.double_0, this.double_1, 0.0, 0.0);
        GClass221 gclass221_2 = this.gclass0_0.method_593(gclass222_0.double_2, gclass222_0.double_3, 25.0, double_11);
        graphics_0.DrawLine(pen, (float) gclass222_0.double_2, (float) gclass222_0.double_3, (float) gclass221_2.double_0, (float) gclass221_2.double_1);
        graphics_0.FillEllipse((Brush) solidBrush, (float) x1, (float) y1, (float) GClass226.int_61, (float) GClass226.int_61);
        graphics_0.DrawEllipse(pen, (float) x1, (float) y1, (float) GClass226.int_61, (float) GClass226.int_61);
      }
      else if (!this.bool_2)
      {
        graphics_0.FillEllipse((Brush) solidBrush, (float) x1, (float) y1, (float) GClass226.int_61, (float) GClass226.int_61);
      }
      else
      {
        solidBrush.Color = Color.Yellow;
        graphics_0.FillEllipse((Brush) solidBrush, (float) x1, (float) y1, (float) GClass226.int_61, (float) GClass226.int_61);
        // ISSUE: reference to a compiler-generated field
        if (class318.gclass202_0.list_4.Contains(this))
        {
          // ISSUE: reference to a compiler-generated method
          GClass146 gclass146 = this.gclass0_0.dictionary_22.Values.FirstOrDefault<GClass146>(new Func<GClass146, bool>(class318.method_0));
          if (gclass146 != null)
            text = gclass146.PopName;
        }
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (class318.gclass202_0.gclass21_0.chkAstNames == CheckState.Unchecked && this.auroraSystemBodyType_0 == AuroraSystemBodyType.Asteroid && !this.bool_2 || class318.gclass202_0.gclass21_0.chkMoonNames == CheckState.Unchecked && this.genum12_0 == GEnum12.const_2 || class318.gclass202_0.gclass21_0.chkDwarfNames == CheckState.Unchecked && this.auroraSystemBodyType_0 == AuroraSystemBodyType.DwarfPlanet || class318.gclass202_0.gclass21_0.chkPlanetNames == CheckState.Unchecked && this.genum12_0 == GEnum12.const_1 && this.auroraSystemBodyType_0 != AuroraSystemBodyType.DwarfPlanet)
        return;
      string str = "";
      // ISSUE: reference to a compiler-generated field
      if (class318.gclass202_0.gclass21_0.chkGeoPoints == CheckState.Checked)
      {
        double num5 = this.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || this.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian ? this.double_20 / 100.0 : this.double_20 / 10.0;
        if (num5 < 1.0)
          num5 = 1.0;
        str = $" ({Math.Round(num5, 0).ToString()})";
      }
      solidBrush.Color = Color.LimeGreen;
      double num6 = (double) graphics_0.MeasureString(text, font_0).Width / 2.0;
      gclass221_1.double_0 = gclass222_0.double_2 - num6;
      gclass221_1.double_1 = gclass222_0.double_3 + (double) GClass226.int_61;
      // ISSUE: reference to a compiler-generated field
      if (class318.gclass202_0.gclass21_0.chkSBSurvey == CheckState.Checked)
        gclass221_1.double_1 += 5.0;
      graphics_0.DrawString(text + str, font_0, (Brush) solidBrush, (float) gclass221_1.double_0, (float) gclass221_1.double_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3055);
    }
  }

  public void method_76(Graphics graphics_0, GClass222 gclass222_0, GClass202 gclass202_0)
  {
    try
    {
      if (this.bool_2 || this != this.gclass0_0.gclass1_0 && (this.double_21 != 0.0 || gclass202_0.gclass21_0.chkAsteroidOrbits == CheckState.Unchecked && this.auroraSystemBodyType_0 == AuroraSystemBodyType.Asteroid || gclass202_0.gclass21_0.chkMoonOrbits == CheckState.Unchecked && this.genum12_0 == GEnum12.const_2 || gclass202_0.gclass21_0.chkDwarfOrbits == CheckState.Unchecked && this.auroraSystemBodyType_0 == AuroraSystemBodyType.DwarfPlanet || gclass202_0.gclass21_0.chkCometPath == CheckState.Unchecked && this.auroraSystemBodyType_0 == AuroraSystemBodyType.Comet || gclass202_0.gclass21_0.chkPlanetOrbits == CheckState.Unchecked && this.genum12_0 == GEnum12.const_1 && this.auroraSystemBodyType_0 != AuroraSystemBodyType.DwarfPlanet))
        return;
      if (this.double_24 != 0.0 && this.genum12_0 != GEnum12.const_2 && this.gclass0_0.int_85 != 0)
      {
        GClass221 gclass221 = this.gclass197_0.method_20(gclass202_0);
        if (gclass221.double_0 < 0.0 || gclass221.double_0 > this.gclass0_0.double_0 || gclass221.double_1 < 0.0 || gclass221.double_1 > this.gclass0_0.double_1)
          return;
        float width = (float) (this.double_2 * GClass226.double_14 * 2.0 / gclass202_0.double_2);
        if ((double) width < (double) GClass226.int_61)
          return;
        float height = (float) (this.double_26 * GClass226.double_14 * 2.0 / gclass202_0.double_2);
        float num = (float) (this.double_27 * GClass226.double_14 / gclass202_0.double_2);
        float x = (float) gclass221.double_0 - num;
        float y = (float) (gclass221.double_1 - (double) height / 2.0);
        Matrix matrix = new Matrix();
        matrix.RotateAt((float) this.double_25, new PointF((float) gclass221.double_0, (float) gclass221.double_1));
        graphics_0.Transform = matrix;
        RectangleF rect = new RectangleF(x, y, width, height);
        Pen pen = new Pen(GClass226.color_5);
        graphics_0.DrawEllipse(pen, rect);
        graphics_0.ResetTransform();
        pen.Dispose();
      }
      else
      {
        GClass221 gclass221_1 = new GClass221();
        double num = this.genum12_0 != GEnum12.const_2 ? this.double_2 * GClass226.double_14 / gclass202_0.double_2 : this.double_2 / gclass202_0.double_2;
        if (num < (double) GClass226.int_61)
          return;
        GClass221 gclass221_2 = this.genum2_0 != GEnum2.const_1 || this.genum12_0 != GEnum12.const_2 ? this.gclass197_0.method_20(gclass202_0) : this.gclass1_0.method_74(gclass202_0);
        if (gclass221_2.double_0 < 0.0 || gclass221_2.double_0 > this.gclass0_0.double_0 || gclass221_2.double_1 < 0.0 || gclass221_2.double_1 > this.gclass0_0.double_1)
          return;
        double x = gclass221_2.double_0 - num;
        double y = gclass221_2.double_1 - num;
        Pen pen = new Pen(GClass226.color_5);
        graphics_0.DrawEllipse(pen, (float) x, (float) y, (float) (num * 2.0), (float) (num * 2.0));
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3056);
    }
  }

  public bool method_77(GClass21 gclass21_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: reference to a compiler-generated method
    return this.gclass0_0.list_9.Where<GClass215>(new Func<GClass215, bool>(new GClass1.Class319()
    {
      gclass21_0 = gclass21_0,
      gclass1_0 = this
    }.method_0)).FirstOrDefault<GClass215>() != null;
  }

  public string method_78(GClass21 gclass21_0)
  {
    try
    {
      return this.method_79(gclass21_0, false, false);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3057);
      return "error";
    }
  }

  public string method_79(GClass21 gclass21_0, bool bool_10, bool bool_11)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass1.Class320 class320 = new GClass1.Class320();
    // ISSUE: reference to a compiler-generated field
    class320.gclass21_0 = gclass21_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated field
      return this.dictionary_1.Values.Where<GClass218>(new Func<GClass218, bool>(class320.method_0)).Select<GClass218, string>((Func<GClass218, string>) (gclass218_0 => gclass218_0.string_0)).FirstOrDefault<string>() ?? this.method_81(class320.gclass21_0, bool_10, bool_11);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3058);
      return "error";
    }
  }

  public void method_80(GClass21 gclass21_0, string string_3)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass1.Class321 class321 = new GClass1.Class321();
    // ISSUE: reference to a compiler-generated field
    class321.gclass21_0 = gclass21_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass218 gclass218 = this.dictionary_1.Values.Where<GClass218>(new Func<GClass218, bool>(class321.method_0)).FirstOrDefault<GClass218>();
      if (gclass218 != null)
      {
        gclass218.string_0 = string_3;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.dictionary_1.Add(class321.gclass21_0.RaceID, new GClass218()
        {
          string_0 = string_3,
          int_0 = this.int_0,
          gclass21_0 = class321.gclass21_0
        });
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3059);
    }
  }

  public string method_81(GClass21 gclass21_0, bool bool_10, bool bool_11)
  {
    try
    {
      string str = "";
      if (!bool_11)
        str = this.gclass197_0.method_18(gclass21_0) + " ";
      switch (this.genum12_0)
      {
        case GEnum12.const_1:
          return str + GClass226.smethod_79(this.int_3);
        case GEnum12.const_2:
          if (!bool_10)
            return $"{this.gclass1_0.method_78(gclass21_0)} - Moon {this.int_4.ToString()}";
          if (this.gclass200_0.int_3 == 1)
            return $"Moon {GClass226.smethod_79(this.int_3)} {this.int_4.ToString()}";
          return $"Moon {this.gclass197_0.method_19()}-{GClass226.smethod_79(this.int_3)} {this.int_4.ToString()}";
        case GEnum12.const_3:
          return "Asteroid #" + this.int_4.ToString();
        case GEnum12.const_5:
          return "Comet #" + this.int_4.ToString();
        default:
          return "No Name";
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3060);
      return "No Name";
    }
  }

  public List<GClass1> method_82()
  {
    try
    {
      return this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_2 => gclass1_2.gclass1_0 == this)).OrderBy<GClass1, int>((Func<GClass1, int>) (gclass1_0 => gclass1_0.int_4)).ToList<GClass1>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3061);
      return new List<GClass1>();
    }
  }
}
