// Decompiled with JetBrains decompiler
// Type: GClass101
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class GClass101
{
  
  
  private sealed class Class1038
  {
    public GEnum54 genum54_0;

    public Class1038()
    {
      
    }

    internal bool method_0(GClass100 gclass100_0)
    {
      return gclass100_0.genum54_0 >= this.genum54_0;
    }
  }

  
  private sealed class Class1039
  {
    public GEnum53 genum53_0;

    public Class1039()
    {
      
    }

    internal bool method_0(GClass100 gclass100_0)
    {
      return gclass100_0.genum53_0 >= this.genum53_0;
    }
  }

  
  private sealed class Class1040
  {
    public GEnum53 genum53_0;

    public Class1040()
    {
      
    }

    internal bool method_0(GClass100 gclass100_0)
    {
      return gclass100_0.genum53_0 == this.genum53_0;
    }
  }
  
  private GClass0 gclass0_0;
  public GClass164 gclass164_0;
  public GClass96 gclass96_0;
  public GClass97 gclass97_0;
  public GClass230 gclass230_0;
  public GClass123 gclass123_0;
  public List<GClass100> list_0 = new List<GClass100>();
  public Dictionary<GEnum113, GClass98> dictionary_0 = new Dictionary<GEnum113, GClass98>();
  public GEnum115 genum115_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  public int int_5;
  public int int_6;
  public int int_7;
  public Decimal decimal_0 = 1M;
  public Decimal decimal_1 = 1M;
  public Decimal decimal_2;
  public Decimal decimal_3;
  public Decimal decimal_4;
  public Decimal decimal_5;
  public Decimal decimal_6;
  public bool bool_0;
  public bool bool_1;
  public GClass95 gclass95_0;
  public bool bool_2;

  public string ClassName { get; set; }

  public GClass101(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public GClass101 method_0(GClass21 gclass21_0)
  {
    try
    {
      bool flag = false;
      if (this.decimal_1 != (Decimal) gclass21_0.method_220())
      {
        foreach (GClass100 gclass100 in this.list_0)
        {
          if (gclass100.bool_7)
          {
            flag = true;
            break;
          }
        }
      }
      else if (this.decimal_0 != gclass21_0.method_386().decimal_3)
        flag = true;
      if (!flag)
        return this;
      GClass100 gclass100_0 = (GClass100) null;
      GClass100 gclass100_1 = (GClass100) null;
      GClass100 gclass100_2 = (GClass100) null;
      GClass100 gclass100_3 = (GClass100) null;
      if (this.list_0.Count > 0)
        gclass100_0 = this.list_0[0];
      if (this.list_0.Count > 1)
        gclass100_1 = this.list_0[1];
      if (this.list_0.Count > 2)
        gclass100_2 = this.list_0[2];
      if (this.list_0.Count > 3)
        gclass100_3 = this.list_0[3];
      CheckState checkState_3 = CheckState.Unchecked;
      CheckState checkState_5 = CheckState.Unchecked;
      if (this.bool_1)
        checkState_3 = CheckState.Checked;
      if (this.bool_0)
        checkState_5 = CheckState.Checked;
      GClass101 gclass101_0 = this.gclass0_0.method_448(gclass21_0, this.gclass96_0, this.gclass97_0, gclass100_0, gclass100_1, gclass100_2, gclass100_3, this.gclass230_0, this.dictionary_0, this.gclass0_0.method_588(this.ClassName), false, checkState_3, CheckState.Checked, checkState_5, this.int_6);
      GClass101 gclass101_1 = gclass21_0.method_210(gclass101_0);
      if (gclass101_1 == null)
      {
        gclass101_1 = this.gclass0_0.method_448(gclass21_0, this.gclass96_0, this.gclass97_0, gclass100_0, gclass100_1, gclass100_2, gclass100_3, this.gclass230_0, this.dictionary_0, this.gclass0_0.method_588(this.ClassName), true, checkState_3, CheckState.Checked, checkState_5, this.int_6);
        if (this.gclass164_0.dictionary_0.ContainsKey(gclass21_0.RaceID))
          this.gclass164_0.dictionary_0[gclass21_0.RaceID].bool_0 = true;
        if (this.gclass95_0 != null)
        {
          int int_1 = 1;
          List<GClass95> list = gclass21_0.list_11.Where<GClass95>((Func<GClass95, bool>) (gclass95_1 => gclass95_1.gclass94_0 == this.gclass95_0.gclass94_0)).ToList<GClass95>();
          if (list.Count > 0)
            int_1 = list.Max<GClass95>((Func<GClass95, int>) (gclass95_0 => gclass95_0.int_0)) + 1;
          GClass95 gclass95 = new GClass95(this.gclass95_0.gclass94_0, gclass101_1, int_1);
          gclass21_0.list_11.Add(gclass95);
        }
        else
        {
          GClass94 gclass94_1 = new GClass94();
          gclass94_1.int_0 = this.gclass0_0.method_26(GEnum0.const_50);
          gclass94_1.string_0 = this.ClassName + " Series";
          gclass21_0.dictionary_8.Add(gclass94_1.int_0, gclass94_1);
          GClass95 gclass95_1 = new GClass95(gclass94_1, this, 1);
          gclass21_0.list_11.Add(gclass95_1);
          GClass95 gclass95_2 = new GClass95(gclass94_1, gclass101_1, 2);
          gclass21_0.list_11.Add(gclass95_2);
        }
      }
      return gclass101_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3593);
      return (GClass101) null;
    }
  }

  public int method_1()
  {
    try
    {
      return this.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_5));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1740);
      return 0;
    }
  }

  public bool method_2()
  {
    try
    {
      return this.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)) > 0M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1741);
      return false;
    }
  }

  public bool method_3(GEnum54 genum54_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass101.Class1038 class1038 = new GClass101.Class1038();
    // ISSUE: reference to a compiler-generated field
    class1038.genum54_0 = genum54_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      return this.list_0.Where<GClass100>(new Func<GClass100, bool>(class1038.method_0)).Count<GClass100>() > 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1742);
      return false;
    }
  }

  public bool method_4(GEnum53 genum53_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass101.Class1039 class1039 = new GClass101.Class1039();
    // ISSUE: reference to a compiler-generated field
    class1039.genum53_0 = genum53_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      return this.list_0.Where<GClass100>(new Func<GClass100, bool>(class1039.method_0)).Count<GClass100>() > 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1743);
      return false;
    }
  }

  public bool method_5(GEnum53 genum53_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass101.Class1040 class1040 = new GClass101.Class1040();
    // ISSUE: reference to a compiler-generated field
    class1040.genum53_0 = genum53_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      return this.list_0.Where<GClass100>(new Func<GClass100, bool>(class1040.method_0)).Count<GClass100>() > 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1744);
      return false;
    }
  }

  public int method_6()
  {
    try
    {
      return this.list_0.Max<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_3));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1745);
      return 0;
    }
  }

  public Decimal method_7()
  {
    try
    {
      return Math.Round(this.gclass97_0.decimal_0 * this.decimal_0, 1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1746);
      return 0M;
    }
  }

  public Decimal method_8()
  {
    try
    {
      Decimal num = Math.Round((Decimal) this.gclass96_0.int_0 * this.decimal_0, 1);
      if (this.gclass96_0.genum112_0 != GEnum112.const_0)
        return num;
      GClass98 gclass98 = this.dictionary_0.Values.Where<GClass98>((Func<GClass98, bool>) (gclass98_0 => gclass98_0.decimal_1 > 0M)).OrderByDescending<GClass98, Decimal>((Func<GClass98, Decimal>) (gclass98_0 => gclass98_0.decimal_1)).FirstOrDefault<GClass98>();
      return gclass98 == null ? num : num * gclass98.decimal_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1747);
      return 0M;
    }
  }

  public void method_9(TextBox textBox_0, bool bool_3, bool bool_4)
  {
    try
    {
      string str1 = "";
      if (bool_3)
        str1 = str1 + this.ClassName + Environment.NewLine;
      string[] strArray1 = new string[10]
      {
        str1,
        "Transport Size (tons) ",
        GClass226.smethod_42(this.decimal_2, 1),
        "     Cost ",
        GClass226.smethod_42(this.decimal_3, 3),
        "     Armour ",
        null,
        null,
        null,
        null
      };
      Decimal num1 = this.method_7();
      strArray1[6] = num1.ToString();
      strArray1[7] = "     Hit Points ";
      num1 = this.method_8();
      strArray1[8] = num1.ToString();
      strArray1[9] = Environment.NewLine;
      string str2 = $"{string.Concat(strArray1)}Annual Maintenance Cost {GClass226.smethod_47(this.decimal_3 * GClass226.decimal_47)}     Resupply Cost {GClass226.smethod_47(this.decimal_4)}{Environment.NewLine}";
      foreach (GClass100 gclass100 in this.list_0)
      {
        if (gclass100.genum114_0 == GEnum114.const_22 && this.gclass230_0 != null)
        {
          Decimal num2 = 1M - (Decimal) this.int_1 / (Decimal) this.int_2;
          string[] strArray2 = new string[17]
          {
            str2,
            Environment.NewLine,
            this.gclass230_0.Name,
            Environment.NewLine,
            "Range ",
            GClass226.smethod_37(this.int_1),
            " km      Tracking ",
            GClass226.smethod_37(this.int_4),
            " km/s      Damage ",
            this.gclass230_0.int_6.ToString(),
            " / ",
            null,
            null,
            null,
            null,
            null,
            null
          };
          int num3 = this.gclass230_0.method_5(this.int_1);
          strArray2[11] = num3.ToString();
          strArray2[12] = "     Shots ";
          strArray2[13] = this.gclass230_0.int_7.ToString();
          strArray2[14] = "     Rate of Fire ";
          num3 = this.gclass230_0.method_3();
          strArray2[15] = num3.ToString();
          strArray2[16 /*0x10*/] = Environment.NewLine;
          str2 = string.Concat(strArray2);
          str2 = $"{str2}Maximum Fire Control Range {GClass226.smethod_37(this.int_2)}km      Chance to Hit at Max Range {GClass226.smethod_39(num2 * 100M)}%{Environment.NewLine}";
          str2 = $"{str2}Maximum Sensor Range {GClass226.smethod_37(this.int_3)}km      Max Range vs Missile {GClass226.smethod_43(Math.Pow(GClass226.double_20, 2.0) * (double) this.int_3)} km{Environment.NewLine}";
          if (this.int_7 > 0)
            str2 = $"{str2}ECCM-{GClass226.smethod_37(this.int_7)}{Environment.NewLine}";
        }
        else
          str2 = gclass100.genum114_0 != GEnum114.const_26 ? str2 + gclass100.method_3(this.decimal_1) + Environment.NewLine : $"{str2}Headquarters:    Capacity {GClass226.smethod_37(this.int_6)}{Environment.NewLine}";
      }
      if (this.dictionary_0.Values.Count > 0)
      {
        str2 += Environment.NewLine;
        foreach (GClass98 gclass98 in this.dictionary_0.Values)
          str2 = str2 + gclass98.string_0 + Environment.NewLine;
      }
      if (this.bool_0)
        str2 = $"{str2}Non-Combat Class{Environment.NewLine}";
      if (bool_4)
        str2 = $"{str2 + Environment.NewLine + this.gclass123_0.method_36() + Environment.NewLine}Development Cost  {GClass226.smethod_37(this.gclass164_0.int_4)}";
      textBox_0.Text = str2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1748);
    }
  }
}
