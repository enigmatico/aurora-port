// Decompiled with JetBrains decompiler
// Type: GClass83
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class GClass83
{
  private Dictionary<int, GClass202> dictionary_0 = new Dictionary<int, GClass202>();
  private GClass0 gclass0_0;
  public GClass21 gclass21_0;
  public GClass83 gclass83_0;
  public GClass55 gclass55_0;
  public GClass146 gclass146_0;
  public GClass40 gclass40_0;
  public GClass79 gclass79_0;
  public GEnum121 genum121_0 = GEnum121.const_7;
  public GEnum121 genum121_1 = GEnum121.const_16;
  public GEnum121 genum121_2 = GEnum121.const_5;
  public int int_0;
  public int int_1;
  public int int_2 = 5;
  public int int_3 = 10;
  public int int_4;
  public bool bool_0 = true;
  public bool bool_1;
  public GClass61 gclass61_0;
  public bool bool_2;

  public string AdminCommandName { get; set; }

  public GClass83(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public void method_0(bool bool_3)
  {
    try
    {
      GClass61 gclass61 = null;
      if (bool_3)
        gclass21_0.method_255(false);
      List<GClass55> list = gclass0_0.dictionary_42.Values.Where(gclass55_1 => gclass55_1.auroraCommanderType_0 == AuroraCommanderType.Naval && gclass55_1.gclass21_0 == gclass21_0 && gclass55_1.gclass59_0 == null && !gclass55_1.bool_4 && gclass55_1.auroraCommandType_0 == AuroraCommandType.None && gclass55_1.gclass61_0 == gclass61_0).Where(gclass55_1 => gclass55_1.dictionary_0.ContainsKey(genum121_0)).ToList();
      if (list.Count == 0)
      {
        gclass61 = gclass61_0.method_3();
        if (gclass61 == null)
          return;
        list = gclass0_0.dictionary_42.Values.Where(v=> this.gclass0_0.decimal_0 - v.decimal_0 > GClass226.decimal_29 && !v.bool_0 && v.gclass61_0 == gclass61).ToList();
        if (list.Count == 0)
          return;
      }
      GClass55 gclass55_1_1 = list.OrderByDescending(gclass55_1 => gclass55_1.method_5(genum121_0) + gclass55_1.method_5(GEnum121.const_13)).ThenByDescending(gclass55_1 => gclass55_1.method_5(genum121_1)).ThenByDescending(gclass55_1 => gclass55_1.method_5(genum121_2)).FirstOrDefault();
      // ISSUE: reference to a compiler-generated field
      if (gclass61 != null)
        gclass21_0.method_250(gclass55_1_1, true);
      gclass55_1_1.method_40(false);
      if (gclass55_0 != null)
        gclass55_0.method_40(true);
      gclass55_1_1.gclass83_0 = this;
      gclass55_1_1.auroraCommandType_0 = AuroraCommandType.NavalAdminCommand;
      gclass55_1_1.decimal_1 = gclass0_0.decimal_0;
      gclass55_0 = gclass55_1_1;
      if (gclass146_0 != null)
      {
        gclass55_1_1.gclass146_0 = gclass146_0;
        gclass55_1_1.gclass40_0 = null;
        gclass0_0.gclass92_0.method_2(GEnum126.const_78, $"{gclass55_1_1.method_36()} assigned as commander of {AdminCommandName}", gclass55_1_1.gclass21_0, gclass146_0.gclass202_0.gclass200_0, gclass146_0.method_87(), gclass146_0.method_88(), AuroraEventCategory.Commander);
      }
      else if (gclass40_0 != null)
      {
        gclass55_1_1.gclass146_0 = null;
        gclass55_1_1.gclass40_0 = gclass40_0;
        gclass0_0.gclass92_0.method_2(GEnum126.const_78, $"{gclass55_1_1.method_36()} assigned as commander of {AdminCommandName}", gclass55_1_1.gclass21_0, gclass40_0.gclass85_0.gclass202_0.gclass200_0, gclass40_0.gclass85_0.double_2, gclass40_0.gclass85_0.double_3, AuroraEventCategory.Commander);
      }
      gclass55_1_1.method_46("Assigned to " + AdminCommandName, GEnum28.const_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3485);
    }
  }

  public List<GClass40> method_1()
  {
    try
    {
      var list = this.method_12();
      list.AddRange((IEnumerable<GClass85>) this.method_2());
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_4.Values.Where<GClass40>(v=>list.Contains(v.gclass85_0)).ToList<GClass40>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 753);
      return (List<GClass40>) null;
    }
  }

  public List<GClass85> method_2()
  {
    try
    {
      List<GClass85> gclass85List = new List<GClass85>();
      foreach (GClass83 gclass83 in this.gclass0_0.dictionary_0.Values.Where<GClass83>((Func<GClass83, bool>) (gclass83_1 => gclass83_1.gclass83_0 == this)).ToList<GClass83>())
      {
        gclass85List.AddRange((IEnumerable<GClass85>) gclass83.method_12());
        gclass85List.AddRange((IEnumerable<GClass85>) gclass83.method_2());
      }
      return gclass85List;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 754);
      return (List<GClass85>) null;
    }
  }

  public void method_3()
  {
    try
    {
      GClass146 gclass146 = this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_1 => gclass146_1.gclass21_0 == this.gclass21_0 && gclass146_1.method_62(AuroraProductionCategory.NavalHeadquarters) > 0M)).OrderByDescending<GClass146, Decimal>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.method_62(AuroraProductionCategory.NavalHeadquarters))).FirstOrDefault<GClass146>();
      if (gclass146 != null)
      {
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_154, $"Due to the destruction of its current headquarters on {this.gclass146_0.PopName}, {this.AdminCommandName} has been moved to {gclass146.PopName}", this.gclass21_0, gclass146.gclass202_0.gclass200_0, gclass146.method_87(), gclass146.method_88(), AuroraEventCategory.PopSummary);
        this.gclass146_0 = gclass146;
      }
      else
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_154, this.AdminCommandName + " is currently ineffective due to the destruction of its current headquarters. No other headquarters facilities are currently available", this.gclass21_0, this.gclass146_0.gclass202_0.gclass200_0, this.gclass146_0.method_87(), this.gclass146_0.method_88(), AuroraEventCategory.PopSummary);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 755);
    }
  }

  public string method_4()
  {
    try
    {
      return this.gclass55_0 == null ? "No Fleet Commander" : $"{this.gclass55_0.method_36()}   {this.gclass55_0.method_29(false)}";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 756);
      return "error";
    }
  }

  public Decimal method_5(int int_5, GEnum121 genum121_3)
  {
    try
    {
      Decimal num = 1M;
      if (!this.dictionary_0.ContainsKey(int_5) || this.gclass55_0 == null || !this.bool_2)
        return 1M;
      switch (genum121_3)
      {
        case GEnum121.const_0:
          num = 1M + (this.gclass55_0.method_5(GEnum121.const_0) - 1M) * this.gclass79_0.decimal_5;
          break;
        case GEnum121.const_1:
          num = 1M + (this.gclass55_0.method_5(GEnum121.const_1) - 1M) * this.gclass79_0.decimal_1;
          break;
        case GEnum121.const_4:
          num = 1M + (this.gclass55_0.method_5(GEnum121.const_4) - 1M) * this.gclass79_0.decimal_4;
          break;
        case GEnum121.const_5:
          num = 1M + (this.gclass55_0.method_5(GEnum121.const_5) - 1M) * this.gclass79_0.decimal_4;
          break;
        case GEnum121.const_8:
          num = 1M + (this.gclass55_0.method_5(GEnum121.const_8) - 1M) * this.gclass79_0.decimal_4;
          break;
        case GEnum121.const_12:
          num = 1M + (this.gclass55_0.method_5(GEnum121.const_12) - 1M) * this.gclass79_0.decimal_8;
          break;
        case GEnum121.const_17:
          num = 1M + (this.gclass55_0.method_5(GEnum121.const_17) - 1M) * this.gclass79_0.decimal_7;
          break;
        case GEnum121.const_20:
          num = 1M + (this.gclass55_0.method_5(GEnum121.const_20) - 1M) * this.gclass79_0.decimal_2;
          break;
        case GEnum121.const_24:
          num = 1M + (this.gclass55_0.method_5(GEnum121.const_24) - 1M) * this.gclass79_0.decimal_6;
          break;
        case GEnum121.const_32:
          num = 1M + (this.gclass55_0.method_5(GEnum121.const_0) - 1M) * this.gclass79_0.decimal_3;
          break;
      }
      if (this.gclass83_0 != null)
      {
        if (this.gclass146_0 != null)
          num *= this.gclass83_0.method_5(this.gclass146_0.gclass202_0.gclass200_0.int_0, genum121_3);
        else if (this.gclass40_0 != null)
          num *= this.gclass83_0.method_5(this.gclass40_0.gclass85_0.gclass202_0.gclass200_0.int_0, genum121_3);
      }
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 758);
      return 1M;
    }
  }

  public string method_6()
  {
    try
    {
      return this.gclass40_0 != null ? $"{this.gclass79_0.string_1} {this.AdminCommandName}  ({this.gclass61_0.string_0})  -  {this.gclass40_0.method_187()}" : (this.gclass146_0 == null ? $"{this.gclass79_0.string_1} {this.AdminCommandName}  ({this.gclass61_0.string_0})" : $"{this.gclass79_0.string_1} {this.AdminCommandName}  ({this.gclass61_0.string_0})  -  {this.gclass146_0.PopName}");
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 759);
      return "Error";
    }
  }

  public int method_7()
  {
    try
    {
      return this.gclass146_0 == null ? 0 : (int) ((Decimal) this.gclass0_0.method_589((Decimal) (int) this.gclass146_0.method_62(AuroraProductionCategory.NavalHeadquarters)) * this.gclass79_0.decimal_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 760);
      return 0;
    }
  }

  public void method_8()
  {
    try
    {
      this.dictionary_0.Clear();
      if (this.gclass40_0 != null)
      {
        this.dictionary_0.Add(this.gclass40_0.gclass85_0.gclass202_0.gclass200_0.int_0, this.gclass40_0.gclass85_0.gclass202_0);
      }
      else
      {
        if (this.gclass146_0 == null)
          return;
        this.dictionary_0 = this.gclass0_0.method_32(this.gclass21_0, this.gclass146_0.gclass202_0, this.method_7());
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 761);
    }
  }

  public void method_9(ListView listView_0)
  {
    try
    {
      listView_0.Items.Clear();
      this.gclass0_0.method_601(listView_0, "Systems Within Range", "Range", "NHQ Level");
      this.gclass0_0.method_594(listView_0, "");
      this.method_8();
      this.dictionary_0 = this.dictionary_0.OrderBy<KeyValuePair<int, GClass202>, int>((Func<KeyValuePair<int, GClass202>, int>) (keyValuePair_0 => keyValuePair_0.Value.int_10)).ThenBy<KeyValuePair<int, GClass202>, string>((Func<KeyValuePair<int, GClass202>, string>) (keyValuePair_0 => keyValuePair_0.Value.Name)).ToDictionary<KeyValuePair<int, GClass202>, int, GClass202>((Func<KeyValuePair<int, GClass202>, int>) (keyValuePair_0 => keyValuePair_0.Key), (Func<KeyValuePair<int, GClass202>, GClass202>) (keyValuePair_0 => keyValuePair_0.Value));
      foreach (GClass202 object_1 in this.dictionary_0.Values)
      {
        int num = object_1.method_35();
        string string_12 = "-";
        if (num > 0)
          string_12 = num.ToString();
        this.gclass0_0.method_602(listView_0, object_1.Name, object_1.int_10.ToString(), string_12, (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 762);
    }
  }

  public void method_10()
  {
    try
    {
      GClass61 gclass61_1 = this.method_13();
      if (gclass61_1 == null)
      {
        this.gclass61_0 = this.gclass21_0.method_253(GEnum15.const_1, AuroraCommanderType.Naval);
      }
      else
      {
        GClass61 gclass61_2 = gclass61_1.method_1();
        if (gclass61_2 == null)
          this.gclass61_0 = gclass61_1;
        else
          this.gclass61_0 = gclass61_2;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 763);
    }
  }

  public bool method_11()
  {
    try
    {
      GClass61 gclass61_1 = this.method_14();
      if (gclass61_1 == null || gclass61_1.int_1 > this.gclass61_0.int_1)
        return false;
      GClass61 gclass61_2 = gclass61_1.method_1();
      if (gclass61_2 == null)
      {
        if (gclass61_1 == this.gclass61_0)
          return false;
        this.gclass61_0 = gclass61_1;
        return true;
      }
      this.gclass61_0 = gclass61_2;
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 764);
      return false;
    }
  }

  public List<GClass85> method_12()
  {
    try
    {
      return this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass83_0 == this)).ToList<GClass85>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 766);
      return (List<GClass85>) null;
    }
  }

  public GClass61 method_13()
  {
    try
    {
      List<GClass55> list = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass83_0 == this)).Select<GClass85, GClass55>((Func<GClass85, GClass55>) (gclass85_0 => gclass85_0.method_162())).Where<GClass55>((Func<GClass55, bool>) (gclass55_0 => gclass55_0 != null)).ToList<GClass55>();
      return list.Count == 0 ? this.gclass21_0.method_253(GEnum15.const_0, AuroraCommanderType.Naval) : list.Select<GClass55, GClass61>((Func<GClass55, GClass61>) (gclass55_0 => gclass55_0.gclass61_0)).OrderBy<GClass61, int>((Func<GClass61, int>) (gclass61_0 => gclass61_0.int_1)).FirstOrDefault<GClass61>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 767 /*0x02FF*/);
      return (GClass61) null;
    }
  }

  public GClass61 method_14()
  {
    try
    {
      List<GClass83> list = this.gclass0_0.dictionary_0.Values.Where<GClass83>((Func<GClass83, bool>) (gclass83_1 => gclass83_1.gclass83_0 == this)).ToList<GClass83>();
      if (list.Count == 0)
        return (GClass61) null;
      GClass61 gclass61_1 = list.Select<GClass83, GClass61>((Func<GClass83, GClass61>) (gclass83_0 => gclass83_0.gclass61_0)).OrderBy<GClass61, int>((Func<GClass61, int>) (gclass61_0 => gclass61_0.int_1)).FirstOrDefault<GClass61>();
      GClass61 gclass61_2 = list.Select<GClass83, GClass55>((Func<GClass83, GClass55>) (gclass83_0 => gclass83_0.gclass55_0)).Where<GClass55>((Func<GClass55, bool>) (gclass55_0 => gclass55_0 != null)).Select<GClass55, GClass61>((Func<GClass55, GClass61>) (gclass55_0 => gclass55_0.gclass61_0)).OrderBy<GClass61, int>((Func<GClass61, int>) (gclass61_0 => gclass61_0.int_1)).FirstOrDefault<GClass61>();
      return gclass61_2 == null || gclass61_2.int_1 >= gclass61_1.int_1 ? gclass61_1 : gclass61_2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 768 /*0x0300*/);
      return (GClass61) null;
    }
  }
}
