// Decompiled with JetBrains decompiler
// Type: GClass102
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class GClass102
{
  private GClass0 gclass0_0;
  public GClass21 gclass21_0;
  public GClass61 gclass61_0;
  public List<GClass39> list_0 = new List<GClass39>();
  public GEnum116 genum116_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public string string_1;
  public Decimal decimal_0;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public Decimal decimal_3;
  public Decimal decimal_4;
  public Decimal decimal_5;
  public Decimal decimal_6;
  public Decimal decimal_7;
  public Decimal decimal_8;
  public Decimal decimal_9;
  public Decimal decimal_10;
  public Decimal decimal_11;
  public Decimal decimal_12;
  public Decimal decimal_13;
  public string string_2 = "None";

  public string Name { get; set; }

  public GClass102(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public string method_0()
  {
    try
    {
      ++this.int_1;
      return $"{GClass226.smethod_80(this.int_1)} {this.Name}";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3615);
      return "Error";
    }
  }

  public void method_1(TreeNode treeNode_0)
  {
    try
    {
      this.list_0 = this.list_0.OrderByDescending<GClass39, int>((Func<GClass39, int>) (gclass39_0 => gclass39_0.int_1)).ToList<GClass39>();
      foreach (GClass39 gclass39 in this.list_0)
        treeNode_0.Nodes.Add(new TreeNode()
        {
          Text = $"{gclass39.int_1.ToString()}x {gclass39.gclass101_0.ClassName}",
          Tag = (object) gclass39
        });
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3607);
    }
  }

  public bool method_2()
  {
    try
    {
      return this.gclass0_0.dictionary_22.Values.SelectMany<GClass146, GClass106>((Func<GClass146, IEnumerable<GClass106>>) (gclass146_0 => (IEnumerable<GClass106>) gclass146_0.dictionary_3.Values)).Count<GClass106>((Func<GClass106, bool>) (gclass106_0 => gclass106_0.gclass102_0 == this)) > 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3256);
      return false;
    }
  }

  public Decimal method_3(GClass146 gclass146_0)
  {
    try
    {
      Decimal num = 0M;
      foreach (GClass39 gclass39 in this.list_0)
      {
        Decimal decimal3 = gclass39.gclass101_0.decimal_3;
        if (gclass146_0 != null && gclass39.gclass101_0.dictionary_0.Count > 0)
        {
          if (gclass39.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_2) && gclass146_0.gclass1_0.double_7 > gclass146_0.gclass194_0.double_8)
            decimal3 /= this.gclass0_0.dictionary_69[GEnum113.const_2].decimal_0;
          if (gclass39.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_3) && gclass146_0.gclass1_0.double_7 < gclass146_0.gclass194_0.double_7)
            decimal3 /= this.gclass0_0.dictionary_69[GEnum113.const_3].decimal_0;
          if (gclass39.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_8) && gclass146_0.gclass1_0.double_15 > gclass146_0.gclass194_0.double_2)
            decimal3 /= this.gclass0_0.dictionary_69[GEnum113.const_8].decimal_0;
          if (gclass39.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_4) && (gclass146_0.gclass1_0.double_4 > gclass146_0.gclass194_0.double_11 || gclass146_0.gclass1_0.double_4 < gclass146_0.gclass194_0.double_12))
            decimal3 /= this.gclass0_0.dictionary_69[GEnum113.const_4].decimal_0;
          if (gclass39.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_5) && gclass146_0.gclass1_0.gclass99_0.genum111_1 == GEnum111.const_2)
            decimal3 /= this.gclass0_0.dictionary_69[GEnum113.const_5].decimal_0;
          if (gclass39.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_9) && gclass146_0.gclass1_0.gclass99_0.genum111_1 == GEnum111.const_12)
            decimal3 /= this.gclass0_0.dictionary_69[GEnum113.const_9].decimal_0;
          if (gclass39.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_7) && gclass146_0.gclass1_0.gclass99_0.bool_0)
            decimal3 /= this.gclass0_0.dictionary_69[GEnum113.const_7].decimal_0;
          if (gclass39.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_6) && gclass146_0.gclass1_0.gclass99_0.bool_1)
            decimal3 /= this.gclass0_0.dictionary_69[GEnum113.const_6].decimal_0;
        }
        num += decimal3 * (Decimal) gclass39.int_1;
      }
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1749);
      return 0M;
    }
  }

  public GClass123 method_4()
  {
    try
    {
      GClass123 gclass123 = new GClass123(this.gclass0_0);
      foreach (GClass39 gclass39 in this.list_0)
        gclass123.method_11(gclass39.gclass101_0.gclass123_0, (Decimal) gclass39.int_1);
      return gclass123;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1750);
      return (GClass123) null;
    }
  }

  public void method_5()
  {
    try
    {
      this.decimal_0 = 0M;
      this.decimal_1 = 0M;
      this.decimal_2 = 0M;
      this.decimal_3 = 0M;
      this.decimal_4 = 0M;
      this.decimal_5 = 0M;
      this.decimal_6 = 0M;
      this.decimal_7 = 0M;
      this.decimal_8 = 0M;
      this.decimal_9 = 0M;
      this.decimal_10 = 0M;
      this.decimal_11 = 0M;
      this.decimal_12 = 0M;
      this.string_2 = "-";
      foreach (GClass39 gclass39 in this.list_0.OrderBy<GClass39, int>((Func<GClass39, int>) (gclass39_0 => gclass39_0.gclass101_0.int_6)).ToList<GClass39>())
      {
        this.decimal_2 += (Decimal) gclass39.int_1;
        this.decimal_0 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
        this.decimal_1 += gclass39.gclass101_0.method_8() * (Decimal) gclass39.int_1;
        this.decimal_3 += (Decimal) (gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_0)) * gclass39.int_1);
        this.decimal_11 += gclass39.gclass101_0.decimal_4 * (Decimal) gclass39.int_1;
        this.string_2 = GClass226.smethod_10(gclass39.gclass101_0.int_6);
        this.decimal_6 += (Decimal) gclass39.int_1 * gclass39.gclass101_0.decimal_6;
        this.decimal_8 += (Decimal) (gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_4)));
        this.decimal_5 += (Decimal) (gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_2)));
        this.decimal_4 += (Decimal) (gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_1)));
        this.decimal_9 += (Decimal) gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_4));
        this.decimal_10 += (Decimal) gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_5));
        this.decimal_13 += (Decimal) gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_7));
        this.decimal_12 += (Decimal) (gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_5)));
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1751);
    }
  }

  public void method_6(ListView listView_0, GClass146 gclass146_0)
  {
    try
    {
      GClass61 gclass61 = this.method_7();
      this.method_5();
      string string_17 = "";
      if (this.string_2 != "-")
        string_17 = $"{string_17}HQ{this.string_2}  ";
      if (this.decimal_5 > 0M)
        string_17 = $"{string_17}ST{this.decimal_5.ToString()}   ";
      if (this.decimal_4 > 0M)
        string_17 = $"{string_17}CW{this.decimal_4.ToString()}  ";
      if (this.decimal_8 > 0M)
        string_17 = $"{string_17}FD{this.decimal_8.ToString()}  ";
      if (this.decimal_6 > 0M)
        string_17 = $"{string_17}CN{this.decimal_6.ToString()}  ";
      if (this.decimal_9 > 0M)
        string_17 = $"{string_17}GE{this.decimal_9.ToString()}  ";
      if (this.decimal_10 > 0M)
        string_17 = $"{string_17}XN{this.decimal_10.ToString()}  ";
      if (this.decimal_13 > 0M)
        string_17 = $"{string_17}DC{this.decimal_13.ToString()}  ";
      if (this.decimal_12 > 0M)
        string_17 = $"{string_17}LG{Math.Round(this.decimal_12 / 1000M).ToString()}  ";
      Color color_0 = GClass226.color_16;
      if (this.int_2 == 1)
        color_0 = Color.Orange;
      this.gclass0_0.method_616(listView_0, this.string_1, this.Name, this.decimal_2.ToString(), GClass226.smethod_38(this.decimal_0), GClass226.smethod_38(this.method_3(gclass146_0)), GClass226.smethod_38(this.decimal_1), GClass226.smethod_38(this.decimal_11), string_17, gclass61.method_0(), color_0, (object) this);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1752);
    }
  }

  public GClass61 method_7()
  {
    try
    {
      if (this.gclass61_0 != null)
        return this.gclass61_0;
      int int_57 = this.method_8();
      this.decimal_0 = this.method_9();
      return this.gclass21_0.method_156((int) this.decimal_0, int_57);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1753);
      return (GClass61) null;
    }
  }

  public int method_8()
  {
    try
    {
      return this.list_0.Count == 0 ? 0 : this.list_0.Max<GClass39>((Func<GClass39, int>) (gclass39_0 => gclass39_0.gclass101_0.int_6));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1754);
      return 0;
    }
  }

  public Decimal method_9()
  {
    try
    {
      this.decimal_0 = 0M;
      foreach (GClass39 gclass39 in this.list_0)
        this.decimal_0 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
      return this.decimal_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1755);
      return 0M;
    }
  }

  public void method_10(ListView listView_0)
  {
    try
    {
      listView_0.Items.Clear();
      this.gclass0_0.method_613(listView_0, "Name", "Units", "Size", "Cost", "HP", "GSP", "Element Attributes", (object) null);
      this.list_0 = this.list_0.OrderByDescending<GClass39, Decimal>((Func<GClass39, Decimal>) (gclass39_0 => gclass39_0.gclass101_0.decimal_2 * (Decimal) gclass39_0.int_1)).ToList<GClass39>();
      foreach (GClass39 object_1 in this.list_0)
      {
        string str = GClass226.smethod_10(object_1.gclass101_0.int_6);
        int num1 = object_1.int_1 * object_1.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_4));
        Decimal num2 = (Decimal) object_1.int_1 * object_1.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_3));
        Decimal num3 = (Decimal) object_1.int_1 * object_1.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_4));
        Decimal num4 = (Decimal) object_1.int_1 * object_1.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_5));
        Decimal num5 = (Decimal) object_1.int_1 * object_1.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_7));
        Decimal decimal_73 = (Decimal) (object_1.int_1 * object_1.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_5)));
        string string_16 = "";
        for (int index = 0; index < object_1.gclass101_0.list_0.Count; ++index)
        {
          if (object_1.gclass101_0.list_0[index].bool_7)
            string_16 = $"{string_16}{object_1.gclass101_0.list_0[index].string_1}  ";
        }
        if (str != "-")
          string_16 = $"{string_16}HQ {str}  ";
        if (object_1.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_2)) > 0)
          string_16 += "ST  ";
        if (object_1.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_1)) > 0)
          string_16 += "CW  ";
        if (num1 > 0)
          string_16 = $"{string_16}FD {num1.ToString()}  ";
        if (num2 > 0M)
          string_16 = $"{string_16}CN {num2.ToString()}  ";
        if (num3 > 0M)
          string_16 = $"{string_16}GE {num3.ToString()}  ";
        if (num4 > 0M)
          string_16 = $"{string_16}XN {num4.ToString()}  ";
        if (num5 > 0M)
          string_16 = $"{string_16}DC {num5.ToString()}  ";
        if (decimal_73 > 0M)
          string_16 = $"{string_16}GSP {GClass226.smethod_38(decimal_73)}  ";
        this.gclass0_0.method_613(listView_0, object_1.gclass101_0.ClassName, object_1.int_1.ToString(), GClass226.smethod_38(object_1.gclass101_0.decimal_2 * (Decimal) object_1.int_1), GClass226.smethod_45(object_1.gclass101_0.decimal_3 * (Decimal) object_1.int_1, 1), (object_1.gclass101_0.method_8() * (Decimal) object_1.int_1).ToString(), GClass226.smethod_38(object_1.gclass101_0.decimal_4 * (Decimal) object_1.int_1), string_16, (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1756);
    }
  }

  public string method_11()
  {
    try
    {
      string str = $"{$"{this.Name + Environment.NewLine}Transport Size: {GClass226.smethod_39(this.method_9())} tons{Environment.NewLine}"}Build Cost: {GClass226.smethod_42(this.method_3((GClass146) null), 1)} BP{Environment.NewLine}";
      foreach (GClass39 gclass39 in this.list_0)
        str = $"{str}{gclass39.int_1.ToString()}x {gclass39.gclass101_0.ClassName}{Environment.NewLine}";
      return str;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1757);
      return "error";
    }
  }

  public void method_12(GClass101 gclass101_0, int int_3)
  {
    try
    {
      this.list_0.Add(new GClass39(this.gclass0_0)
      {
        gclass102_0 = this,
        gclass101_0 = gclass101_0,
        int_1 = int_3
      });
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1758);
    }
  }
}
