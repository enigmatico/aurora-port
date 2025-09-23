// Decompiled with JetBrains decompiler
// Type: GClass202
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public partial class GClass202
{
  public Dictionary<GClass110, GClass111> dictionary_0 = new Dictionary<GClass110, GClass111>();
  public List<GClass40> list_0 = new List<GClass40>();
  public GClass200 gclass200_0;
  public GClass21 gclass21_0;
  public GClass110 gclass110_0;
  public GClass62 gclass62_0;
  public GClass140 gclass140_0;
  public GClass3 gclass3_0;
  public AuroraSystemProtectionStatus auroraSystemProtectionStatus_0;
  private GClass0 gclass0_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  public string string_0;
  public bool bool_0;
  public bool bool_1;
  public bool bool_2;
  public bool bool_3;
  public bool bool_4;
  public bool bool_5;
  public Decimal decimal_0;
  public double double_0;
  public double double_1;
  public double double_2;
  public double double_3;
  public double double_4;
  public int int_5;
  public int int_6;
  public int int_7;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public Decimal decimal_3;
  public Decimal decimal_4;
  public Decimal decimal_5;
  public int int_8;
  public int int_9;
  public Decimal decimal_6;
  public Decimal decimal_7;
  public string string_3 = "";
  public Decimal decimal_8;
  public List<GClass40> list_1 = new List<GClass40>();
  public List<GClass146> list_2 = new List<GClass146>();
  public List<GClass132> list_3 = new List<GClass132>();
  public GClass202 gclass202_0;
  public GClass202 gclass202_1;
  public int int_10;
  public Decimal decimal_9;
  public bool bool_6;
  public List<GClass1> list_4 = new List<GClass1>();
  public List<GClass1> list_5 = new List<GClass1>();
  public GClass85 gclass85_0;
  public GClass1 gclass1_0;
  public GClass132 gclass132_0;
  public GClass221 gclass221_0 = new GClass221(0.0, 0.0);
  public List<GClass1> list_6 = new List<GClass1>();
  public List<GClass120> list_7 = new List<GClass120>();
  public List<GClass120> list_8 = new List<GClass120>();
  public int int_11;
  public int int_12 = 1;
  public int int_13;
  public int int_14;
  public int int_15;
  public int int_16;
  public int int_17;
  public int int_18;
  public int int_19;
  public int int_20;
  public int int_21;
  public int int_22;
  public int int_23;
  public int int_24;
  public int int_25;
  public int int_26;
  public int int_27;
  public int int_28;
  public int int_29;
  public int int_30;
  public int int_31;
  public int int_32;
  public int int_33;
  public int int_34;
  public int int_35;
  public Decimal decimal_10;
  public Decimal decimal_11;
  public double double_5;
  public double double_6;
  public double double_7;
  public double double_8;
  public double double_9;
  public double double_10;
  public double double_11;
  public bool bool_7;
  public bool bool_8;
  public bool bool_9;
  public bool bool_10;
  public AuroraContactStatus auroraContactStatus_0 = AuroraContactStatus.None;
  public int int_36;

  public string Name { get; set; }

  public string NameWithSector { get; set; }

  public GClass202(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public List<GClass202> method_0(List<GClass202> list_9)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass202.Class1182 class1182 = new GClass202.Class1182();
      if (list_9.Count == 0)
        return list_9;
      // ISSUE: reference to a compiler-generated field
      class1182.list_0 = this.gclass0_0.dictionary_12.Values.Where<GClass120>((Func<GClass120, bool>) (gclass120_0 => gclass120_0.gclass200_0 == this.gclass200_0 && gclass120_0.dictionary_0[this.gclass21_0.RaceID].int_4 == 0 && gclass120_0.dictionary_0[this.gclass21_0.RaceID].int_1 == 1)).Select<GClass120, GClass200>((Func<GClass120, GClass200>) (gclass120_0 => gclass120_0.gclass120_0.gclass200_0)).ToList<GClass200>();
      // ISSUE: reference to a compiler-generated method
      return list_9.Where<GClass202>(new Func<GClass202, bool>(class1182.method_0)).ToList<GClass202>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3476);
      return (List<GClass202>) null;
    }
  }

  public AuroraSystemProtectionStatus method_1()
  {
    try
    {
      return this.dictionary_0.Count == 0 ? AuroraSystemProtectionStatus.NoProtection : this.dictionary_0.Values.Max<GClass111, AuroraSystemProtectionStatus>((Func<GClass111, AuroraSystemProtectionStatus>) (gclass111_0 => gclass111_0.auroraSystemProtectionStatus_0));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2526);
      return AuroraSystemProtectionStatus.NoProtection;
    }
  }

  public Decimal method_2()
  {
    try
    {
      return this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass202_0 == this)).Sum<GClass146>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.method_190()));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2527);
      return 0M;
    }
  }

  public GClass202 method_3(GClass21 gclass21_1, List<GClass110> list_9)
  {
    try
    {
      GClass202 gclass202 = new GClass202(this.gclass0_0);
      GClass202 gclass202_1 = (GClass202) this.MemberwiseClone();
      gclass202_1.gclass21_0 = gclass21_1;
      gclass202_1.gclass62_0 = (GClass62) null;
      gclass202_1.int_2 = 0;
      gclass202_1.gclass140_0 = (GClass140) null;
      if (this.gclass110_0 != null)
        gclass202_1.gclass110_0 = list_9.FirstOrDefault<GClass110>((Func<GClass110, bool>) (gclass110_1 => gclass110_1.gclass21_0 == this.gclass110_0.gclass21_0));
      if (gclass21_1.bool_0)
        this.gclass3_0 = new GClass3(this.gclass0_0, gclass202_1);
      gclass202_1.list_1 = new List<GClass40>();
      gclass202_1.list_2 = new List<GClass146>();
      gclass202_1.list_3 = new List<GClass132>();
      gclass202_1.dictionary_0 = new Dictionary<GClass110, GClass111>();
      foreach (KeyValuePair<GClass110, GClass111> keyValuePair in this.dictionary_0)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass202.Class1183 class1183 = new GClass202.Class1183();
        // ISSUE: reference to a compiler-generated field
        class1183.keyValuePair_0 = keyValuePair;
        // ISSUE: reference to a compiler-generated method
        GClass110 key = list_9.FirstOrDefault<GClass110>(new Func<GClass110, bool>(class1183.method_0));
        // ISSUE: reference to a compiler-generated field
        gclass202_1.dictionary_0.Add(key, new GClass111()
        {
          gclass202_0 = gclass202_1,
          gclass110_0 = key,
          auroraSystemProtectionStatus_0 = class1183.keyValuePair_0.Value.auroraSystemProtectionStatus_0
        });
      }
      return gclass202_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2528);
      return (GClass202) null;
    }
  }

  public void method_4()
  {
    try
    {
      foreach (GClass146 gclass146_1 in this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass202_0 == this)).ToList<GClass146>())
        this.gclass21_0.method_132(gclass146_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2529);
    }
  }

  public void method_5(GClass21 gclass21_1)
  {
    try
    {
      List<GClass146> list1 = this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 =>
      {
        if (gclass146_0.gclass202_0 != this)
          return false;
        return gclass146_0.decimal_4 > 0.01M || gclass146_0.dictionary_0.Count > 0;
      })).ToList<GClass146>();
      List<GClass146> list2 = this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass202_0 == this && gclass146_0.decimal_4 <= 0.01M && gclass146_0.dictionary_0.Count == 0)).ToList<GClass146>();
      foreach (GClass146 gclass146 in list1)
        gclass146.method_114(gclass21_1, GEnum27.const_2, false, false, false);
      foreach (GClass146 gclass146_1 in list2)
        this.gclass21_0.method_132(gclass146_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2530);
    }
  }

  public void method_6()
  {
    try
    {
      this.double_9 = this.double_5 + this.gclass21_0.double_2;
      this.double_10 = this.double_6 + this.gclass21_0.double_3;
      this.double_9 = this.gclass0_0.double_6 - (this.gclass0_0.double_6 - this.double_9) * this.gclass21_0.double_0;
      this.double_10 = this.gclass0_0.double_7 - (this.gclass0_0.double_7 - this.double_10) * this.gclass21_0.double_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2531);
    }
  }

  public void method_7()
  {
    try
    {
      this.gclass221_0 = new GClass221(0.0, 0.0);
      if (this.gclass85_0 != null)
      {
        this.gclass221_0.double_0 = this.gclass85_0.double_2;
        this.gclass221_0.double_1 = this.gclass85_0.double_3;
      }
      else if (this.gclass1_0 != null)
      {
        this.gclass221_0.double_0 = this.gclass1_0.double_0;
        this.gclass221_0.double_1 = this.gclass1_0.double_1;
      }
      else
      {
        if (this.gclass132_0 == null)
          return;
        this.gclass221_0.double_0 = this.gclass132_0.double_0;
        this.gclass221_0.double_1 = this.gclass132_0.double_1;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2532);
    }
  }

  public void method_8(GClass202 gclass202_2)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass202.Class1184 class1184 = new GClass202.Class1184();
    // ISSUE: reference to a compiler-generated field
    class1184.gclass202_0 = gclass202_2;
    // ISSUE: reference to a compiler-generated field
    class1184.gclass202_1 = this;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      GClass202 gclass202 = this.gclass0_0.dictionary_12.Values.Where<GClass120>(new Func<GClass120, bool>(class1184.method_0)).Select<GClass120, GClass202>(new Func<GClass120, GClass202>(class1184.method_1)).Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0 != null)).OrderBy<GClass202, Decimal>((Func<GClass202, Decimal>) (gclass202_0 => gclass202_0.decimal_0)).FirstOrDefault<GClass202>();
      if (gclass202 != null)
      {
        // ISSUE: reference to a compiler-generated field
        double num1 = class1184.gclass202_0.double_5 - gclass202.double_5;
        // ISSUE: reference to a compiler-generated field
        double num2 = class1184.gclass202_0.double_6 - gclass202.double_6;
        if (num1 > (double) GClass226.int_1)
          num1 = (double) GClass226.int_1;
        if (num2 > (double) GClass226.int_1)
          num2 = (double) GClass226.int_1;
        if (num1 < (double) -GClass226.int_1)
          num1 = (double) -GClass226.int_1;
        if (num2 < (double) -GClass226.int_1)
          num2 = (double) -GClass226.int_1;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (this.method_9(class1184.gclass202_0.double_5 + num1, class1184.gclass202_0.double_6 + num2))
          return;
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (this.method_9(class1184.gclass202_0.double_5 + (double) GClass226.int_1, class1184.gclass202_0.double_6) || this.method_9(class1184.gclass202_0.double_5 - (double) GClass226.int_1, class1184.gclass202_0.double_6) || this.method_9(class1184.gclass202_0.double_5, class1184.gclass202_0.double_6 - (double) GClass226.int_0) || this.method_9(class1184.gclass202_0.double_5, class1184.gclass202_0.double_6 + (double) GClass226.int_0) || this.method_9(class1184.gclass202_0.double_5 + (double) GClass226.int_1, class1184.gclass202_0.double_6 - (double) GClass226.int_0) || this.method_9(class1184.gclass202_0.double_5 - (double) GClass226.int_1, class1184.gclass202_0.double_6 - (double) GClass226.int_0) || this.method_9(class1184.gclass202_0.double_5 + (double) GClass226.int_1, class1184.gclass202_0.double_6 + (double) GClass226.int_0) || this.method_9(class1184.gclass202_0.double_5 - (double) GClass226.int_1, class1184.gclass202_0.double_6 - (double) GClass226.int_0))
        return;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      this.method_9(class1184.gclass202_0.double_5 + (double) (GClass226.int_1 / 3), class1184.gclass202_0.double_6 - (double) (GClass226.int_0 / 3));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2533);
    }
  }

  public bool method_9(double double_12, double double_13)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass202.Class1185 class1185 = new GClass202.Class1185();
    // ISSUE: reference to a compiler-generated field
    class1185.double_0 = double_12;
    // ISSUE: reference to a compiler-generated field
    class1185.double_1 = double_13;
    try
    {
      // ISSUE: reference to a compiler-generated method
      if (this.gclass21_0.dictionary_0.Values.Count<GClass202>(new Func<GClass202, bool>(class1185.method_0)) != 0)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.double_5 = class1185.double_0;
      // ISSUE: reference to a compiler-generated field
      this.double_6 = class1185.double_1;
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2534);
      return false;
    }
  }

  public List<GClass126> method_10()
  {
    try
    {
      return this.gclass0_0.dictionary_7.Values.Where<GClass126>((Func<GClass126, bool>) (gclass126_0 => gclass126_0.gclass200_0 == this.gclass200_0 && gclass126_0.gclass21_0 == this.gclass21_0)).ToList<GClass126>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2535);
      return (List<GClass126>) null;
    }
  }

  public GClass120 method_11(GClass202 gclass202_2)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass202.Class1186 class1186 = new GClass202.Class1186();
    // ISSUE: reference to a compiler-generated field
    class1186.gclass202_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1186.gclass202_1 = gclass202_2;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_12.Values.Where<GClass120>(new Func<GClass120, bool>(class1186.method_0)).Where<GClass120>(new Func<GClass120, bool>(class1186.method_1)).FirstOrDefault<GClass120>(new Func<GClass120, bool>(class1186.method_2));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2536);
      return (GClass120) null;
    }
  }

  public bool method_12(GClass85 gclass85_1, GEnum98 genum98_0)
  {
    try
    {
      if (!this.gclass21_0.bool_0)
        return true;
      if (this.gclass3_0.genum95_0 == GEnum95.const_0 && !gclass85_1.gclass4_0.bool_3 && gclass85_1.gclass9_0.genum104_0 != GEnum104.const_25)
        return false;
      switch (genum98_0)
      {
        case GEnum98.const_0:
          if (gclass85_1.gclass9_0.genum104_0 == GEnum104.const_8 && this.gclass3_0.genum95_0 < GEnum95.const_3)
            return false;
          break;
        case GEnum98.const_2:
          if (this.gclass3_0.genum95_0 < GEnum95.const_2)
            return false;
          break;
      }
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2537);
      return false;
    }
  }

  public List<GClass202> method_13(bool bool_11, bool bool_12, bool bool_13)
  {
    try
    {
      Dictionary<int, GClass202> dictionary = new Dictionary<int, GClass202>();
      List<GClass202> gclass202List1 = new List<GClass202>();
      List<GClass202> gclass202List2 = new List<GClass202>();
      dictionary.Add(this.gclass200_0.int_0, this);
      gclass202List1.Add(this);
      while (true)
      {
        foreach (GClass202 gclass202_1 in gclass202List1)
        {
          List<GClass202> list = gclass202_1.method_36(bool_11, true).Except<GClass202>((IEnumerable<GClass202>) dictionary.Values).ToList<GClass202>();
          if (bool_12)
            list = list.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => !gclass202_0.method_20())).ToList<GClass202>();
          if (bool_13)
            list = list.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => !gclass202_0.method_21())).ToList<GClass202>();
          foreach (GClass202 gclass202_2 in list)
          {
            if (!gclass202List2.Contains(gclass202_2))
              gclass202List2.Add(gclass202_2);
          }
        }
        if (gclass202List2.Count != 0)
        {
          gclass202List1.Clear();
          foreach (GClass202 gclass202 in gclass202List2)
          {
            gclass202List1.Add(gclass202);
            dictionary.Add(gclass202.gclass200_0.int_0, gclass202);
          }
          gclass202List2.Clear();
        }
        else
          break;
      }
      return dictionary.Values.ToList<GClass202>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2538);
      return (List<GClass202>) null;
    }
  }

  public void method_14(ListView listView_0)
  {
    try
    {
      listView_0.Items.Clear();
      foreach (GClass214 object_1 in this.method_15())
      {
        if (object_1.wayPointType_0 != WayPointType.TransitPOI || this.gclass21_0.bool_0)
        {
          string string_12 = "";
          if (object_1.Name != "")
            string_12 = object_1.Name;
          else if (object_1.gclass1_0 != null)
            string_12 = object_1.gclass1_0.method_78(this.gclass21_0);
          this.gclass0_0.method_602(listView_0, object_1.int_3.ToString(), GClass226.smethod_82((Enum) object_1.wayPointType_0), string_12, (object) object_1);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2539);
    }
  }

  public List<GClass214> method_15()
  {
    try
    {
      return this.gclass0_0.dictionary_13.Values.Where<GClass214>((Func<GClass214, bool>) (gclass214_0 => gclass214_0.gclass200_0 == this.gclass200_0 && gclass214_0.gclass21_0 == this.gclass21_0)).OrderBy<GClass214, int>((Func<GClass214, int>) (gclass214_0 => gclass214_0.int_3)).ToList<GClass214>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2540);
      return (List<GClass214>) null;
    }
  }

  public bool method_16()
  {
    try
    {
      return this.gclass0_0.dictionary_28.Values.FirstOrDefault<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass200_0 == this.gclass200_0 && gclass65_0.gclass21_1 == this.gclass21_0 && gclass65_0.method_5() == AuroraContactStatus.Hostile)) != null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2541);
      return false;
    }
  }

  public GClass201 method_17(GEnum109 genum109_0, GClass85 gclass85_1)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass202.Class1187 class1187 = new GClass202.Class1187();
    // ISSUE: reference to a compiler-generated field
    class1187.gclass202_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1187.gclass85_0 = gclass85_1;
    try
    {
      GClass201 gclass201 = new GClass201();
      double num1 = 0.0;
      double num2 = 0.0;
      GClass120 gclass120 = this.gclass200_0.method_4();
      if (gclass120 != null)
      {
        num1 = gclass120.gclass120_0.double_1;
        num2 = gclass120.gclass120_0.double_2;
      }
      switch (genum109_0)
      {
        case GEnum109.const_1:
          gclass201.gclass146_0 = this.gclass21_0.method_137(this, num1, num1, 0M);
          if (gclass201.gclass146_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_2:
          // ISSUE: reference to a compiler-generated field
          Decimal decimal_29 = class1187.gclass85_0.method_142();
          gclass201.gclass146_0 = this.gclass21_0.method_136(this, num1, num1, decimal_29);
          if (gclass201.gclass146_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_3:
          gclass201.gclass85_0 = this.gclass21_0.method_138(this, num1, num1);
          if (gclass201.gclass85_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_4:
          // ISSUE: reference to a compiler-generated method
          if (this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class1187.method_0)).Count<GClass146>() > 0)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_5:
          // ISSUE: reference to a compiler-generated method
          if (this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class1187.method_2)).Count<GClass146>() > 0)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_6:
        case GEnum109.const_34:
        case GEnum109.const_35:
          // ISSUE: reference to a compiler-generated field
          gclass201.gclass146_0 = this.gclass21_0.method_151(this, num1, num2, class1187.gclass85_0, genum109_0);
          if (gclass201.gclass146_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_7:
          gclass201.bool_0 = !this.bool_1;
          return gclass201;
        case GEnum109.const_8:
          gclass201.bool_0 = !this.bool_2;
          return gclass201;
        case GEnum109.const_9:
          gclass201.gclass146_0 = this.gclass21_0.method_141(this, num1, num1, 0M);
          if (gclass201.gclass146_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_13:
          gclass201.gclass120_0 = this.gclass21_0.method_146(this, num1, num2);
          if (gclass201.gclass120_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_14:
          gclass201.gclass146_0 = this.gclass21_0.method_149(this, num1, num2, false);
          if (gclass201.gclass146_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_15:
          gclass201.gclass146_0 = this.gclass21_0.method_150(this, 0.0, 0.0, false, true);
          if (gclass201.gclass146_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_19:
          gclass201.gclass214_0 = this.gclass200_0.method_8(num1, num2, this, WayPointType.POI, 0);
          if (gclass201.gclass214_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_20:
          gclass201.gclass214_0 = this.gclass200_0.method_8(num1, num2, this, WayPointType.UrgentPOI, 0);
          if (gclass201.gclass214_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_23:
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          gclass201.gclass146_0 = class1187.gclass85_0.method_210(this, class1187.gclass85_0.gclass190_0, num1, num2);
          if (gclass201.gclass146_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_24:
          // ISSUE: reference to a compiler-generated field
          gclass201.gclass190_0 = class1187.gclass85_0.method_207(this, num1, num2);
          if (gclass201.gclass190_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_27:
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          gclass201.gclass146_0 = class1187.gclass85_0.method_209(this, class1187.gclass85_0.gclass148_0, num1, num2);
          if (gclass201.gclass146_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_28:
          // ISSUE: reference to a compiler-generated field
          gclass201.gclass148_0 = class1187.gclass85_0.method_208(this, num1, num2);
          if (gclass201.gclass148_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_31:
          gclass201.gclass233_0 = this.gclass200_0.method_5(num1, num2, this);
          if (gclass201.gclass233_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_33:
          // ISSUE: reference to a compiler-generated method
          if (this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class1187.method_1)).Count<GClass146>() > 0)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_36:
          if (this.gclass200_0.method_11(this.gclass21_0, 0M, false) != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_37:
          if (this.gclass200_0.method_11(this.gclass21_0, 10M, true) != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_38:
          if (this.gclass200_0.method_10(6000000000.0, this.gclass21_0) != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_39:
          if (this.gclass21_0.method_133(this) != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_40:
          gclass201.gclass214_0 = this.gclass200_0.method_8(num1, num2, this, WayPointType.Rendezvous, 0);
          if (gclass201.gclass214_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_42:
          // ISSUE: reference to a compiler-generated field
          gclass201.gclass85_0 = this.gclass21_0.method_145(this, class1187.gclass85_0.gclass22_0, num1, num1);
          if (gclass201.gclass85_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_43:
          gclass201.gclass146_0 = this.gclass21_0.method_137(this, num1, num1, this.gclass21_0.gclass2_0.decimal_0);
          if (gclass201.gclass146_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_44:
          gclass201.gclass146_0 = this.gclass21_0.method_143(this, num1, num1);
          if (gclass201.gclass146_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_45:
          gclass201.gclass146_0 = this.gclass21_0.method_142(this, num1, num1);
          if (gclass201.gclass146_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_47:
          if (!this.bool_6)
            gclass201.bool_0 = true;
          return gclass201;
        case GEnum109.const_48:
          gclass201.gclass146_0 = this.gclass21_0.method_140(this, num1, num1);
          if (gclass201.gclass146_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_49:
          // ISSUE: reference to a compiler-generated field
          gclass201.gclass214_0 = this.gclass200_0.method_8(num1, num2, this, WayPointType.FleetWaypoint, class1187.gclass85_0.int_3);
          if (gclass201.gclass214_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
        case GEnum109.const_50:
          gclass201.gclass85_0 = this.gclass21_0.method_139(this, num1, num1);
          if (gclass201.gclass85_0 != null)
          {
            gclass201.bool_0 = true;
            return gclass201;
          }
          break;
      }
      gclass201.bool_0 = false;
      return gclass201;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2542);
      return (GClass201) null;
    }
  }

  public GClass146 method_18(double double_12, double double_13, bool bool_11)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass202.Class1188 class1188 = new GClass202.Class1188();
    // ISSUE: reference to a compiler-generated field
    class1188.gclass202_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1188.double_0 = double_12;
    // ISSUE: reference to a compiler-generated field
    class1188.double_1 = double_13;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass202.Class1189 class1189 = new GClass202.Class1189()
      {
        list_0 = this.gclass21_0.dictionary_10.Values.Where<GClass110>((Func<GClass110, bool>) (gclass110_0 => gclass110_0.bool_0)).Select<GClass110, GClass21>((Func<GClass110, GClass21>) (gclass110_0 => gclass110_0.gclass21_0)).ToList<GClass21>()
      };
      // ISSUE: reference to a compiler-generated field
      class1189.list_0.Add(this.gclass21_0);
      // ISSUE: reference to a compiler-generated method
      List<GClass146> list = this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class1189.method_0)).Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.dictionary_4.Values.FirstOrDefault<GClass190>((Func<GClass190, bool>) (gclass190_0 => gclass190_0.decimal_1 > 10M)) != null)).ToList<GClass146>();
      if (list.Count == 0)
        return (GClass146) null;
      // ISSUE: reference to a compiler-generated method
      return !bool_11 ? list[0] : list.OrderBy<GClass146, double>(new Func<GClass146, double>(class1188.method_0)).FirstOrDefault<GClass146>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2543);
      return (GClass146) null;
    }
  }

  public Decimal method_19()
  {
    try
    {
      return this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_1 => gclass85_1.gclass202_0 == this)).SelectMany<GClass85, GClass40>((Func<GClass85, IEnumerable<GClass40>>) (gclass85_0 => (IEnumerable<GClass40>) gclass85_0.method_176())).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_10));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2543);
      return 0M;
    }
  }

  public bool method_20()
  {
    try
    {
      return this.gclass3_0 != null && this.gclass3_0.genum96_0 > GEnum96.const_1 || this.int_0 != 0 && !(this.method_19() > (Decimal) this.int_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2544);
      return false;
    }
  }

  public bool method_21()
  {
    try
    {
      return this.gclass21_0.bool_0 ? this.gclass3_0.genum95_0 == GEnum95.const_0 : this.gclass110_0 != null && this.gclass110_0.gclass21_0 != null && this.gclass110_0.gclass21_0 != this.gclass21_0 && (!this.gclass21_0.dictionary_10.ContainsKey(this.gclass110_0.gclass21_0.RaceID) || !this.gclass21_0.dictionary_10[this.gclass110_0.gclass21_0.RaceID].bool_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2545);
      return false;
    }
  }

  public void method_22()
  {
    try
    {
      double num1 = this.double_5 % (double) GClass226.int_40;
      if (num1 != 0.0)
      {
        if (num1 < (double) GClass226.int_40 / 2.0)
          this.double_5 -= num1;
        else
          this.double_5 += (double) GClass226.int_40 - num1;
      }
      double num2 = this.double_6 % (double) GClass226.int_40;
      if (num2 == 0.0)
        return;
      if (num2 < (double) GClass226.int_40 / 2.0)
        this.double_6 -= num2;
      else
        this.double_6 += (double) GClass226.int_40 - num2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2546);
    }
  }

  public void method_23(int int_37, int int_38)
  {
    try
    {
      this.double_5 += (double) int_37 / this.gclass21_0.double_0;
      this.double_6 += (double) int_38 / this.gclass21_0.double_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2547);
    }
  }

  public void method_24()
  {
    try
    {
      this.double_5 = this.double_7;
      this.double_6 = this.double_8;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2548);
    }
  }

  public void method_25()
  {
    try
    {
      this.double_7 = this.double_5;
      this.double_8 = this.double_6;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2549);
    }
  }

  public void method_26(GClass194 gclass194_0, CheckState checkState_0, List<GClass200> list_9)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass202.Class1190 class1190 = new GClass202.Class1190();
    // ISSUE: reference to a compiler-generated field
    class1190.gclass194_0 = gclass194_0;
    // ISSUE: reference to a compiler-generated field
    class1190.gclass202_0 = this;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass202.Class1191 class1191 = new GClass202.Class1191();
      // ISSUE: reference to a compiler-generated field
      class1191.class1190_0 = class1190;
      this.int_29 = 0;
      this.int_30 = 0;
      this.int_31 = 0;
      this.int_32 = 0;
      this.int_33 = 0;
      this.int_34 = 0;
      this.int_35 = 0;
      this.list_6 = this.gclass200_0.method_20();
      foreach (GClass1 gclass1 in this.list_6)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        gclass1.method_58(this.gclass21_0, class1191.class1190_0.gclass194_0, true);
        if (gclass1.genum12_0 == GEnum12.const_3)
          ++this.int_34;
        else if (gclass1.genum12_0 == GEnum12.const_2)
          ++this.int_33;
        else if (gclass1.genum12_0 == GEnum12.const_5)
          ++this.int_35;
        else if (gclass1.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant)
          ++this.int_31;
        else if (gclass1.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian)
          ++this.int_32;
        else if (gclass1.auroraSystemBodyType_0 == AuroraSystemBodyType.Terrestrial)
          ++this.int_29;
        else if (gclass1.auroraSystemBodyType_0 == AuroraSystemBodyType.DwarfPlanet)
          ++this.int_30;
      }
      // ISSUE: reference to a compiler-generated field
      class1191.decimal_0 = 1M;
      GClass164 gclass164 = this.gclass21_0.method_388(this.gclass0_0.dictionary_49[GEnum122.const_35]);
      if (gclass164 != null)
      {
        // ISSUE: reference to a compiler-generated field
        class1191.decimal_0 = Math.Round(gclass164.decimal_0, 2);
      }
      if (checkState_0 == CheckState.Unchecked)
      {
        this.int_18 = this.list_6.Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.decimal_0 == 0M)).Count<GClass1>();
        // ISSUE: reference to a compiler-generated method
        this.int_19 = this.list_6.Where<GClass1>(new Func<GClass1, bool>(class1191.method_0)).Count<GClass1>();
        // ISSUE: reference to a compiler-generated method
        this.int_20 = this.list_6.Where<GClass1>(new Func<GClass1, bool>(class1191.method_1)).Count<GClass1>();
        // ISSUE: reference to a compiler-generated method
        this.int_21 = this.list_6.Where<GClass1>(new Func<GClass1, bool>(class1191.method_2)).Count<GClass1>();
        // ISSUE: reference to a compiler-generated method
        this.int_22 = this.list_6.Where<GClass1>(new Func<GClass1, bool>(class1191.method_3)).Count<GClass1>();
        // ISSUE: reference to a compiler-generated method
        this.int_23 = this.list_6.Where<GClass1>(new Func<GClass1, bool>(class1191.method_4)).Count<GClass1>();
        // ISSUE: reference to a compiler-generated method
        this.int_24 = this.list_6.Where<GClass1>(new Func<GClass1, bool>(class1191.method_5)).Count<GClass1>();
      }
      else
      {
        this.int_18 = this.list_6.Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.decimal_1 == 0M)).Count<GClass1>();
        // ISSUE: reference to a compiler-generated method
        this.int_19 = this.list_6.Where<GClass1>(new Func<GClass1, bool>(class1191.method_6)).Count<GClass1>();
        // ISSUE: reference to a compiler-generated method
        this.int_20 = this.list_6.Where<GClass1>(new Func<GClass1, bool>(class1191.method_7)).Count<GClass1>();
        // ISSUE: reference to a compiler-generated method
        this.int_21 = this.list_6.Where<GClass1>(new Func<GClass1, bool>(class1191.method_8)).Count<GClass1>();
        // ISSUE: reference to a compiler-generated method
        this.int_22 = this.list_6.Where<GClass1>(new Func<GClass1, bool>(class1191.method_9)).Count<GClass1>();
        // ISSUE: reference to a compiler-generated method
        this.int_23 = this.list_6.Where<GClass1>(new Func<GClass1, bool>(class1191.method_10)).Count<GClass1>();
        // ISSUE: reference to a compiler-generated method
        this.int_24 = this.list_6.Where<GClass1>(new Func<GClass1, bool>(class1191.method_11)).Count<GClass1>();
      }
      this.int_28 = this.list_6.Count<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.genum12_0 == GEnum12.const_5));
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      class1191.list_0 = this.list_6.Where<GClass1>(new Func<GClass1, bool>(class1191.class1190_0.method_0)).ToList<GClass1>();
      // ISSUE: reference to a compiler-generated field
      if (class1191.list_0.Count == 0)
      {
        this.int_27 = 100;
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        this.int_26 = this.gclass0_0.list_9.Where<GClass215>(new Func<GClass215, bool>(class1191.method_12)).Count<GClass215>();
        // ISSUE: reference to a compiler-generated field
        this.int_27 = (int) Math.Round((Decimal) this.int_26 / (Decimal) class1191.list_0.Count * 100M);
      }
      if (list_9.Count <= 0 || this.gclass200_0.gclass198_0 == null)
        return;
      foreach (GClass200 gclass200 in list_9)
      {
        double num1 = this.gclass0_0.method_29(gclass200.gclass198_0.double_3, gclass200.gclass198_0.double_4, gclass200.gclass198_0.double_5, this.gclass200_0.gclass198_0.double_3, this.gclass200_0.gclass198_0.double_4, this.gclass200_0.gclass198_0.double_5) - gclass200.double_3;
        if (this.gclass200_0.double_4 == 0.0 || this.gclass200_0.double_4 > num1)
        {
          this.gclass200_0.double_4 = num1;
          double x = (double) GClass226.long_1 * num1;
          double num2 = GClass226.double_13 * 4.0 * Math.Pow(x, 2.0);
          this.gclass200_0.double_5 = GClass226.double_8 * gclass200.double_1 / num2;
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2550);
    }
  }

  public void method_27(Graphics graphics_0, Pen pen_0)
  {
    try
    {
      foreach (GClass120 gclass120 in this.list_8)
      {
        if (gclass120.gclass120_0 != null && this.gclass21_0.dictionary_0.ContainsKey(gclass120.gclass120_0.gclass200_0.int_0))
        {
          float x1 = (float) (this.double_9 + this.gclass21_0.double_1 / 2.0);
          float y1 = (float) (this.double_10 + this.gclass21_0.double_1 / 2.0);
          float x2 = (float) (this.gclass21_0.dictionary_0[gclass120.gclass120_0.gclass200_0.int_0].double_9 + this.gclass21_0.double_1 / 2.0);
          float y2 = (float) (this.gclass21_0.dictionary_0[gclass120.gclass120_0.gclass200_0.int_0].double_10 + this.gclass21_0.double_1 / 2.0);
          if ((gclass120.dictionary_0[this.gclass21_0.RaceID].int_4 == 1 || gclass120.gclass120_0.dictionary_0[this.gclass21_0.RaceID].int_4 == 1) && this.gclass21_0.chkMilitaryRestrictedJP == CheckState.Checked)
          {
            pen_0.Color = Color.Magenta;
            pen_0.Width = 3f;
          }
          else if (gclass120.int_2 > 0 && gclass120.gclass120_0.int_2 > 0)
          {
            pen_0.Color = Color.Orange;
            pen_0.Width = 3f;
          }
          else
          {
            pen_0.Color = Color.Green;
            pen_0.Width = 2.5f;
          }
          graphics_0.DrawLine(pen_0, x1, y1, x2, y2);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2551);
    }
  }

  public void method_28(Graphics graphics_0, Font font_0, int int_37, Color color_0)
  {
    try
    {
      double double_10 = this.gclass21_0.double_1 * 0.2;
      double double_8 = this.gclass21_0.double_1 * 0.4 + this.double_9;
      double double_9 = this.gclass21_0.double_1 * 0.4 + this.double_10;
      if (this.int_11 == 1)
        double_9 = this.gclass21_0.double_1 * 0.65 + this.double_10;
      if (this.int_11 == 2)
        double_9 = this.gclass21_0.double_1 * 0.15 + this.double_10;
      if (this.int_11 == 3)
        double_9 = this.gclass21_0.double_1 * -0.1 + this.double_10;
      Color color_0_1 = GClass226.color_16;
      if (this.bool_7)
        color_0_1 = Color.Blue;
      this.gclass0_0.method_529(graphics_0, color_0, 0, double_8, double_9, double_10);
      this.gclass0_0.method_528(graphics_0, font_0, color_0_1, double_8 + double_10 + 1.0, double_9 - 1.0, 25.0, 25, int_37.ToString(), StringAlignment.Near, StringAlignment.Near);
      ++this.int_11;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2552);
    }
  }

  public void method_29(Graphics graphics_0, Font font_0, Color color_0)
  {
    try
    {
      double double_10 = this.gclass21_0.double_1 * (1.0 + (double) this.int_12 * 0.25);
      double num = this.gclass21_0.double_1 * -((double) this.int_12 * 0.125);
      this.gclass0_0.method_529(graphics_0, color_0, 3, this.double_9 + num, this.double_10 + num, double_10);
      ++this.int_12;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2553);
    }
  }

  public void method_30(Graphics graphics_0, Font font_0, Color color_0, float[] float_0)
  {
    try
    {
      double double_10 = this.gclass21_0.double_1 * (1.0 + (double) this.int_12 * 0.25);
      double num = this.gclass21_0.double_1 * -((double) this.int_12 * 0.125);
      this.gclass0_0.method_530(graphics_0, color_0, 3, this.double_9 + num, this.double_10 + num, double_10, float_0);
      ++this.int_12;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2554);
    }
  }

  public void method_31(ListView listView_0)
  {
    try
    {
      int num1 = 1;
      bool flag = false;
      listView_0.Items.Clear();
      if (this.int_18 > 0 || this.int_20 > 0)
      {
        this.gclass0_0.method_603(listView_0, "Ideal & Habitable Range Worlds", this.int_18.ToString(), (this.int_20 - this.int_18).ToString(), (string) null);
        flag = true;
      }
      if (this.int_21 > 0 || this.int_22 > 0)
      {
        this.gclass0_0.method_603(listView_0, "Normal & Low G Low Cost Worlds", this.int_21.ToString(), (this.int_22 - this.int_21).ToString(), (string) null);
        flag = true;
      }
      if (this.int_23 > 0 || this.int_24 > 0)
      {
        this.gclass0_0.method_603(listView_0, "Normal & Low G Medium Cost Worlds", this.int_23.ToString(), (this.int_24 - this.int_23).ToString(), (string) null);
        flag = true;
      }
      if (flag)
        this.gclass0_0.method_594(listView_0, "");
      if (this.int_29 > 0 || this.int_30 > 0)
        this.gclass0_0.method_603(listView_0, "Terrestrial & Dwarf Planets", this.int_29.ToString(), this.int_30.ToString(), (string) null);
      if (this.int_32 > 0 || this.int_31 > 0)
        this.gclass0_0.method_603(listView_0, "Superjovians & Gas Giants", this.int_32.ToString(), this.int_31.ToString(), (string) null);
      if (this.int_33 > 0 || this.int_34 > 0)
        this.gclass0_0.method_603(listView_0, "Moons & Asteroids", this.int_33.ToString(), this.int_34.ToString(), (string) null);
      if (this.int_35 > 0)
        this.gclass0_0.method_603(listView_0, "Comets", this.int_35.ToString(), "", (string) null);
      this.gclass0_0.method_603(listView_0, "Surveyed & Total Bodies", this.int_26.ToString(), this.list_6.Count.ToString(), (string) null);
      if (!this.bool_1)
      {
        int num2 = this.gclass200_0.dictionary_0.Values.Where<GClass213>((Func<GClass213, bool>) (gclass213_0 => gclass213_0.list_0.Contains(this.gclass21_0.RaceID))).Count<GClass213>();
        this.gclass0_0.method_603(listView_0, "Unsurveyed Gravsurvey Locations", (30 - num2).ToString(), "", (string) null);
      }
      this.gclass0_0.method_594(listView_0, "");
      this.gclass0_0.method_603(listView_0, "Jump Point", "AU", "Bearing", (string) null);
      foreach (GClass120 object_1 in this.list_7)
      {
        string str = "  Unexplored";
        if (object_1.gclass120_0 != null && this.gclass21_0.dictionary_0.ContainsKey(object_1.gclass120_0.gclass200_0.int_0))
          str = "  " + this.gclass21_0.dictionary_0[object_1.gclass120_0.gclass200_0.int_0].Name;
        if (object_1.int_2 > 0)
          str += " (S)";
        this.gclass0_0.method_602(listView_0, num1.ToString() + str, GClass226.smethod_44(object_1.double_0, 2), object_1.int_1.ToString(), (object) object_1);
        ++num1;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2555);
    }
  }

  public void method_32(Graphics graphics_0, Font font_0, double double_12)
  {
    try
    {
      float num1 = 8f;
      float num2 = 12f;
      int num3 = 1;
      double num4 = double_12 / 2.0;
      float num5 = (float) num4 - 6f;
      GClass197 gclass197 = this.gclass0_0.dictionary_10.Values.Where<GClass197>((Func<GClass197, bool>) (gclass197_0 => gclass197_0.gclass200_0 == this.gclass200_0)).OrderBy<GClass197, int>((Func<GClass197, int>) (gclass197_0 => gclass197_0.int_3)).FirstOrDefault<GClass197>();
      SolidBrush solidBrush1 = new SolidBrush(Color.FromArgb((int) byte.MaxValue, gclass197.gclass217_0.int_6, gclass197.gclass217_0.int_7, gclass197.gclass217_0.int_8));
      RectangleF rect = new RectangleF(num5, num5, num2, num2);
      graphics_0.FillEllipse((Brush) solidBrush1, rect);
      if (this.list_7.Count == 0)
        return;
      double num6 = this.list_7.Max<GClass120>((Func<GClass120, double>) (gclass120_0 => gclass120_0.double_0)) * 1.1;
      double num7 = num4 / num6;
      this.list_7 = this.list_7.OrderBy<GClass120, double>((Func<GClass120, double>) (gclass120_0 => gclass120_0.double_0)).ToList<GClass120>();
      foreach (GClass120 gclass120 in this.list_7)
      {
        SolidBrush solidBrush2 = new SolidBrush(Color.Red);
        if (gclass120.int_2 > 0)
          solidBrush2 = new SolidBrush(Color.Orange);
        GClass221 gclass221 = this.gclass0_0.method_592(num4, num4, gclass120.double_0 * num7, (double) gclass120.int_1);
        float x = (float) gclass221.double_0 - num1 / 2f;
        float y = (float) gclass221.double_1 - num1 / 2f;
        rect = new RectangleF(x, y, num1, num1);
        graphics_0.FillEllipse((Brush) solidBrush2, rect);
        this.gclass0_0.method_528(graphics_0, font_0, GClass226.color_16, (double) x + (double) num1 + 1.0, (double) y - 2.0, 20.0, 20, num3.ToString(), StringAlignment.Near, StringAlignment.Near);
        ++num3;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2556);
    }
  }

  public void method_33(Graphics graphics_0, Font font_0, bool bool_11)
  {
    try
    {
      this.int_12 = 1;
      this.int_11 = 0;
      this.method_6();
      if (bool_11 && (this.double_9 < 0.0 - this.gclass21_0.double_1 || this.double_9 > this.gclass0_0.double_2 + this.gclass21_0.double_1 || this.double_10 < 0.0 - this.gclass21_0.double_1 || this.double_10 > this.gclass0_0.double_3 + this.gclass21_0.double_1))
        return;
      SolidBrush solidBrush1 = new SolidBrush(Color.Green);
      if (this.gclass200_0.gclass198_0 != null && this.gclass200_0.gclass198_0.dictionary_0[1].string_0 == "BH")
        solidBrush1.Color = Color.Purple;
      if (this.bool_7)
        solidBrush1.Color = Color.Lime;
      if (this.gclass200_0.double_2 > 0.0)
        solidBrush1.Color = Color.White;
      Pen pen1 = new Pen(Color.Lime);
      graphics_0.FillEllipse((Brush) solidBrush1, (float) this.double_9, (float) this.double_10, (float) this.gclass21_0.double_1, (float) this.gclass21_0.double_1);
      graphics_0.DrawEllipse(pen1, (float) this.double_9, (float) this.double_10, (float) this.gclass21_0.double_1, (float) this.gclass21_0.double_1);
      int num1 = this.list_6.Count<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.genum12_0 != GEnum12.const_5 && gclass1_0.genum12_0 != GEnum12.const_3));
      if (num1 == 0 && this.gclass200_0.double_2 == 0.0)
      {
        double double_10 = this.gclass21_0.double_1 * 0.75;
        double num2 = this.gclass21_0.double_1 * 0.125;
        this.gclass0_0.method_529(graphics_0, Color.FromArgb((int) byte.MaxValue, GClass226.color_19), 0, this.double_9 + num2, this.double_10 + num2, double_10);
      }
      if (this.gclass21_0.chkSystemIconOnly == CheckState.Checked)
        return;
      if (this.gclass21_0.chkHabRangeWorldsLowG == CheckState.Checked && this.int_20 > 0 || this.gclass21_0.chkHabRangeWorlds == CheckState.Checked && this.int_19 > 0)
      {
        int int_37 = this.int_19;
        if (this.gclass21_0.chkHabRangeWorldsLowG == CheckState.Checked)
          int_37 = this.int_20;
        this.method_28(graphics_0, font_0, int_37, Color.Blue);
      }
      if (this.gclass21_0.chkLowCCLowG == CheckState.Checked && this.int_22 > 0 || this.gclass21_0.chkLowCCNormalG == CheckState.Checked && this.int_21 > 0)
      {
        int int_37 = this.int_21;
        if (this.gclass21_0.chkLowCCLowG == CheckState.Checked)
          int_37 = this.int_22;
        this.method_28(graphics_0, font_0, int_37, Color.Cyan);
      }
      if (this.gclass21_0.chkNumCometsPlanetlessSystem == CheckState.Checked && this.int_28 > 0 && num1 == 0)
        this.method_28(graphics_0, font_0, this.int_28, Color.Cornsilk);
      if (this.gclass21_0.chkUnexJP == CheckState.Checked && this.int_25 > 0)
        this.method_28(graphics_0, font_0, this.int_25, Color.Orange);
      if (this.gclass21_0.chkMediumCCLowG == CheckState.Checked && this.int_24 > 0 || this.gclass21_0.chkMediumCCNormalG == CheckState.Checked && this.int_23 > 0)
      {
        int int_37 = this.int_23;
        if (this.gclass21_0.chkMediumCCLowG == CheckState.Checked)
          int_37 = this.int_24;
        this.method_28(graphics_0, font_0, int_37, Color.SlateGray);
      }
      if (this.gclass21_0.chkSectors == CheckState.Checked && this.gclass62_0 != null)
      {
        pen1.Color = Color.FromArgb((int) byte.MaxValue, this.gclass62_0.color_0);
        pen1.Width = 5f;
        graphics_0.DrawEllipse(pen1, (float) this.double_9, (float) this.double_10, (float) this.gclass21_0.double_1, (float) this.gclass21_0.double_1);
      }
      if (this.gclass21_0.chkJPSurveyStatus == CheckState.Checked && !this.bool_1)
        this.method_29(graphics_0, font_0, Color.Red);
      if (this.gclass21_0.chkUnexJP == CheckState.Checked && this.int_25 > 0)
        this.method_29(graphics_0, font_0, Color.Orange);
      if (this.gclass21_0.chkPopulatedSystem == CheckState.Checked && this.decimal_10 > 0M)
        this.method_29(graphics_0, font_0, Color.FromArgb((int) byte.MaxValue, GClass226.color_20));
      if (this.gclass21_0.chkPossibleDormantJP == CheckState.Checked && this.int_3 == 1)
        this.method_29(graphics_0, font_0, Color.Yellow);
      if (this.gclass21_0.chkGroundSurveyLocations == CheckState.Checked && this.bool_9)
      {
        float[] float_0 = new float[2]{ 4f, 2f };
        this.method_30(graphics_0, font_0, Color.LightSteelBlue, float_0);
      }
      if (this.gclass21_0.chkML == CheckState.Checked && this.bool_8)
      {
        float[] float_0 = new float[2]{ 5f, 2f };
        this.method_30(graphics_0, font_0, Color.DeepSkyBlue, float_0);
      }
      if (this.gclass21_0.chkNavalHeadquarters == CheckState.Checked && this.int_17 > 0)
      {
        float[] float_0 = new float[2]{ 10f, 3f };
        this.method_30(graphics_0, font_0, Color.Yellow, float_0);
      }
      if (this.gclass21_0.chkAetherRift == CheckState.Checked && this.bool_10)
      {
        float[] float_0 = new float[2]{ 4f, 2f };
        this.method_30(graphics_0, font_0, Color.DarkOrchid, float_0);
      }
      if (this.gclass21_0.chkKnownAlienForces == CheckState.Checked && this.auroraContactStatus_0 != AuroraContactStatus.None)
      {
        float[] float_0 = new float[2]{ 3f, 2f };
        this.method_30(graphics_0, font_0, this.gclass21_0.dictionary_4[this.auroraContactStatus_0], float_0);
      }
      if (this.gclass21_0.chkBlocked == CheckState.Checked && this.bool_3)
      {
        float[] float_0 = new float[2]{ 6f, 3f };
        this.method_30(graphics_0, font_0, Color.Magenta, float_0);
      }
      if (this.gclass21_0.chkMilitaryRestricted == CheckState.Checked && this.bool_4)
      {
        float[] float_0 = new float[2]{ 2f, 1f };
        this.method_30(graphics_0, font_0, Color.Magenta, float_0);
      }
      if (this.gclass21_0.chkDisplayMineralSearch == CheckState.Checked && this.bool_5)
      {
        float[] float_0 = new float[2]{ 4f, 3f };
        this.method_30(graphics_0, font_0, Color.DarkSeaGreen, float_0);
      }
      if (this.gclass3_0 != null && this.gclass3_0.genum95_0 > GEnum95.const_1)
      {
        float[] float_0 = new float[2]{ 1f, 1f };
        Color color_0 = Color.Red;
        if (this.gclass3_0.genum95_0 == GEnum95.const_4)
          color_0 = Color.DarkOrange;
        else if (this.gclass3_0.genum95_0 == GEnum95.const_3)
          color_0 = Color.Orange;
        else if (this.gclass3_0.genum95_0 == GEnum95.const_2)
          color_0 = Color.LightBlue;
        this.method_30(graphics_0, font_0, color_0, float_0);
      }
      string str1 = this.Name;
      if (this.gclass21_0.chkDistanceFromSelected == CheckState.Checked || this.gclass21_0.chkDistanceFromSelectedMR == CheckState.Checked)
        str1 = $"{str1}  ({GClass226.smethod_44(this.gclass200_0.double_7 / 1000000000.0, 1)})";
      if (this.gclass21_0.chkDistanceRealSpace == CheckState.Checked)
        str1 = $"{str1}  ({GClass226.smethod_44(this.gclass200_0.double_7, 1)})";
      double num3 = (double) font_0.Size / GClass226.double_2;
      double num4 = GClass226.double_3 * num3;
      double num5 = num4 * 2.0;
      int int_136_1 = (int) (num4 / 2.0);
      int num6 = (int) (25.0 * num3);
      int int_136_2 = (int) (15.0 * num3);
      this.gclass0_0.method_528(graphics_0, font_0, GClass226.color_16, this.double_9 - num4, this.double_10 + this.gclass21_0.double_1 + 5.0, this.gclass21_0.double_1 + num5, int_136_1, str1, StringAlignment.Center, StringAlignment.Center);
      if (this.gclass21_0.chkNumWrecks == CheckState.Checked && this.gclass200_0.int_10 > 0)
      {
        Size size = TextRenderer.MeasureText(str1, font_0);
        SolidBrush solidBrush2 = new SolidBrush(GClass226.color_10);
        Pen pen2 = new Pen(GClass226.color_10, 3f);
        double x1 = this.double_9 + this.gclass21_0.double_1 / 2.0 + (double) (size.Width / 2) + 5.0;
        double num7 = this.double_10 + this.gclass21_0.double_1 + 11.0;
        graphics_0.DrawLine(pen2, (float) x1, (float) num7, (float) x1 + (float) GClass226.int_63, (float) num7 + (float) GClass226.int_63);
        graphics_0.DrawLine(pen2, (float) x1, (float) num7 + (float) GClass226.int_63, (float) x1 + (float) GClass226.int_63, (float) num7);
        this.gclass0_0.method_528(graphics_0, font_0, GClass226.color_10, x1 + (double) GClass226.int_63 + 2.0, this.double_10 + this.gclass21_0.double_1 + 5.0, 50.0, 25, this.gclass200_0.int_10.ToString(), StringAlignment.Near, StringAlignment.Center);
      }
      int num8 = num6;
      if (this.gclass21_0.chkDiscoveryDate == CheckState.Checked)
      {
        this.gclass0_0.method_528(graphics_0, font_0, GClass226.color_16, this.double_9 - num4, this.double_10 + this.gclass21_0.double_1 + (double) num8, this.gclass21_0.double_1 + num5, int_136_2, this.string_0, StringAlignment.Center, StringAlignment.Center);
        num8 += int_136_2;
      }
      if (this.gclass21_0.chkSurveyLocationPoints == CheckState.Checked || this.gclass21_0.chkSupernovaImpactTime == CheckState.Checked && this.gclass200_0.double_2 == 0.0)
      {
        string string_10 = "";
        if (this.gclass21_0.chkSurveyLocationPoints == CheckState.Checked)
          string_10 = this.gclass200_0.int_4.ToString();
        if (this.gclass21_0.chkSupernovaImpactTime == CheckState.Checked && this.gclass200_0.double_2 == 0.0)
        {
          if (this.gclass21_0.chkSurveyLocationPoints == CheckState.Checked)
            string_10 += "  ";
          string str2 = this.gclass200_0.double_5 <= 1000000.0 ? (this.gclass200_0.double_5 <= 1000.0 ? GClass226.smethod_43(this.gclass200_0.double_5) : GClass226.smethod_43(this.gclass200_0.double_5 / 1000.0) + "k") : GClass226.smethod_44(this.gclass200_0.double_5 / 1000000.0, 1) + "m";
          if (this.gclass200_0.double_4 > 1.0)
            string_10 = $"{string_10}[{GClass226.smethod_44(this.gclass200_0.double_4, 1)}y - {str2}]";
          else if (this.gclass200_0.double_4 > 0.1)
            string_10 = $"{string_10}[{GClass226.smethod_44(this.gclass200_0.double_4 * 12.0, 1)}m - {str2}]";
          else
            string_10 = $"{string_10}[{GClass226.smethod_44(this.gclass200_0.double_4 * 365.0, 1)}d - {str2}]";
        }
        this.gclass0_0.method_528(graphics_0, font_0, GClass226.color_16, this.double_9 - num4, this.double_10 + this.gclass21_0.double_1 + (double) num8, this.gclass21_0.double_1 + num5, int_136_2, string_10, StringAlignment.Center, StringAlignment.Center);
        num8 += int_136_2;
      }
      if (this.gclass21_0.chkSecurityStatus == CheckState.Checked && this.int_0 > 0)
      {
        Color color_0 = GClass226.color_16;
        if (this.decimal_11 < (Decimal) this.int_0)
          color_0 = Color.Red;
        this.gclass0_0.method_528(graphics_0, font_0, color_0, this.double_9, this.double_10 + this.gclass21_0.double_1 + (double) num8, this.gclass21_0.double_1, int_136_2, $"{this.int_0.ToString()}/{this.decimal_11.ToString()}", StringAlignment.Center, StringAlignment.Center);
      }
      if (this.gclass21_0.chkSurveyedSystemBodies == CheckState.Checked && this.list_6.Count > 0)
        this.gclass0_0.method_528(graphics_0, font_0, GClass226.color_16, this.double_9 + this.gclass21_0.double_1 * 1.1, this.double_10 + this.gclass21_0.double_1 * 0.65, this.gclass21_0.double_1, int_136_2, this.int_27.ToString() + "%", StringAlignment.Near, StringAlignment.Near);
      bool flag = false;
      if (this.gclass21_0.gclass112_0 == null)
      {
        if (this.gclass21_0.chkAlienControlledSystems == CheckState.Checked && this.gclass110_0 != null && this.gclass110_0.gclass21_0 != this.gclass21_0 && this.gclass110_0.gclass21_0 != null)
          this.method_34(graphics_0, this.gclass110_0.gclass21_0);
      }
      else if (this.gclass21_0.gclass112_0.int_0 == 1)
      {
        if (this.gclass21_0.chkAlienControlledSystems == CheckState.Checked && this.gclass110_0 != null && this.gclass110_0.gclass21_0 != this.gclass21_0 && this.gclass110_0.gclass21_0 != null)
          this.method_34(graphics_0, this.gclass110_0.gclass21_0);
      }
      else if (this.gclass21_0.gclass112_0.int_0 == 2)
      {
        if (this.gclass110_0 == null)
          this.method_34(graphics_0, this.gclass21_0);
      }
      else if (this.gclass21_0.gclass112_0.int_0 == 0 && this.gclass21_0.gclass112_0.gclass110_0 != null)
      {
        if (this.gclass21_0.gclass112_0.gclass110_0.dictionary_1.ContainsKey(this.gclass200_0.int_0))
          this.method_34(graphics_0, this.gclass21_0.gclass112_0.gclass110_0.gclass21_0);
        flag = true;
      }
      if (!flag)
      {
        if (this.gclass21_0.gclass22_0 != null && this.gclass21_0.chkClassIcon == CheckState.Checked)
        {
          List<GClass40> list = this.list_0.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0 == this.gclass21_0.gclass22_0)).ToList<GClass40>();
          if (this.gclass21_0.gclass83_0 != null && this.gclass21_0.chkAdminIcon == CheckState.Checked)
          {
            List<GClass40> second = this.gclass21_0.gclass83_0.method_1();
            list = list.Intersect<GClass40>((IEnumerable<GClass40>) second).ToList<GClass40>();
          }
          if (list.Count > 0)
          {
            RectangleF rect = new RectangleF((float) (this.double_9 + this.gclass21_0.double_1 / 1.8), (float) (this.double_10 - this.gclass21_0.double_1 / 1.5), this.gclass21_0.float_0, this.gclass21_0.float_0);
            graphics_0.DrawImage(this.gclass21_0.image_1, rect);
          }
        }
        else if (this.gclass21_0.gclass83_0 != null && this.gclass21_0.chkAdminIcon == CheckState.Checked)
        {
          if (this.list_0.Intersect<GClass40>((IEnumerable<GClass40>) this.gclass21_0.gclass83_0.method_1()).Count<GClass40>() > 0)
          {
            RectangleF rect = new RectangleF((float) (this.double_9 + this.gclass21_0.double_1 / 1.8), (float) (this.double_10 - this.gclass21_0.double_1 / 1.5), this.gclass21_0.float_0, this.gclass21_0.float_0);
            graphics_0.DrawImage(this.gclass21_0.image_1, rect);
          }
        }
        else if (this.gclass21_0.chkWarshipLocation == CheckState.Checked && this.int_13 > 0 || this.gclass21_0.chkAllFleetLocations == CheckState.Checked && this.int_14 > 0)
        {
          RectangleF rect = new RectangleF((float) (this.double_9 + this.gclass21_0.double_1 / 1.8), (float) (this.double_10 - this.gclass21_0.double_1 / 1.5), this.gclass21_0.float_0, this.gclass21_0.float_0);
          graphics_0.DrawImage(this.gclass21_0.image_1, rect);
        }
      }
      else if (this.gclass0_0.dictionary_28.Values.FirstOrDefault<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass21_1 == this.gclass21_0 && gclass65_0.gclass21_0 == this.gclass21_0.gclass112_0.gclass110_0.gclass21_0 && gclass65_0.decimal_3 >= this.gclass0_0.decimal_0 - (Decimal) this.gclass21_0.int_47 && gclass65_0.gclass200_0 == this.gclass200_0)) != null)
      {
        RectangleF rect = new RectangleF((float) (this.double_9 + this.gclass21_0.double_1 / 1.8), (float) (this.double_10 - this.gclass21_0.double_1 / 1.5), this.gclass21_0.float_0, this.gclass21_0.float_0);
        graphics_0.DrawImage(this.gclass21_0.gclass112_0.gclass110_0.gclass21_0.image_1, rect);
      }
      if (this.gclass21_0.chkShipyardComplexes != CheckState.Checked || this.int_16 <= 0)
        return;
      RectangleF rect1 = new RectangleF((float) (this.double_9 - this.gclass21_0.double_1 / 1.75), (float) (this.double_10 + this.gclass21_0.double_1 / 3.5), this.gclass21_0.float_0, this.gclass21_0.float_0);
      graphics_0.DrawImage(this.gclass21_0.image_2, rect1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2557);
    }
  }

  public void method_34(Graphics graphics_0, GClass21 gclass21_1)
  {
    try
    {
      RectangleF rect = new RectangleF((float) (this.double_9 - this.gclass21_0.double_1 / 2.0), (float) (this.double_10 - this.gclass21_0.double_1 / 3.0), this.gclass21_0.float_0, this.gclass21_0.float_0 * 0.667f);
      graphics_0.DrawImage(gclass21_1.image_0, rect);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3803);
    }
  }

  public int method_35()
  {
    try
    {
      List<GClass146> list = this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass202_0 == this)).ToList<GClass146>();
      return list.Count == 0 ? 0 : (int) list.Max<GClass146>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.method_62(AuroraProductionCategory.NavalHeadquarters)));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2558);
      return 0;
    }
  }

  public List<GClass202> method_36(bool bool_11, bool bool_12)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass202.Class1192 class1192 = new GClass202.Class1192();
    // ISSUE: reference to a compiler-generated field
    class1192.gclass202_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1192.bool_0 = bool_11;
    // ISSUE: reference to a compiler-generated field
    class1192.bool_1 = bool_12;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.gclass21_0.dictionary_0.Values.Where<GClass202>(new Func<GClass202, bool>(new GClass202.Class1193()
      {
        list_0 = this.gclass0_0.dictionary_12.Values.Where<GClass120>(new Func<GClass120, bool>(class1192.method_0)).Where<GClass120>(new Func<GClass120, bool>(class1192.method_1)).Select<GClass120, GClass200>((Func<GClass120, GClass200>) (gclass120_0 => gclass120_0.gclass120_0.gclass200_0)).ToList<GClass200>()
      }.method_0)).Where<GClass202>(new Func<GClass202, bool>(class1192.method_2)).ToList<GClass202>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2559 /*0x09FF*/);
      return (List<GClass202>) null;
    }
  }

  public List<GClass202> method_37(bool bool_11)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass202.Class1195 class1195 = new GClass202.Class1195();
    // ISSUE: reference to a compiler-generated field
    class1195.gclass202_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1195.bool_0 = bool_11;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return this.gclass21_0.dictionary_0.Values.Where<GClass202>(new Func<GClass202, bool>(new GClass202.Class1196()
      {
        list_0 = this.gclass0_0.dictionary_12.Values.Where<GClass120>(new Func<GClass120, bool>(class1195.method_0)).Where<GClass120>(new Func<GClass120, bool>(class1195.method_1)).Select<GClass120, GClass200>((Func<GClass120, GClass200>) (gclass120_0 => gclass120_0.gclass120_0.gclass200_0)).ToList<GClass200>()
      }.method_0)).ToList<GClass202>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2560 /*0x0A00*/);
      return (List<GClass202>) null;
    }
  }

  public List<GClass202> method_38(bool bool_11, GEnum96 genum96_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass202.Class1198 class1198 = new GClass202.Class1198();
    // ISSUE: reference to a compiler-generated field
    class1198.gclass202_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1198.bool_0 = bool_11;
    // ISSUE: reference to a compiler-generated field
    class1198.genum96_0 = genum96_0;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass202.Class1199 class1199 = new GClass202.Class1199()
      {
        class1198_0 = class1198
      };
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      class1199.list_0 = this.gclass0_0.dictionary_12.Values.Where<GClass120>(new Func<GClass120, bool>(class1199.class1198_0.method_0)).Where<GClass120>(new Func<GClass120, bool>(class1199.class1198_0.method_1)).Select<GClass120, GClass200>((Func<GClass120, GClass200>) (gclass120_0 => gclass120_0.gclass120_0.gclass200_0)).ToList<GClass200>();
      // ISSUE: reference to a compiler-generated method
      return this.gclass21_0.dictionary_0.Values.Where<GClass202>(new Func<GClass202, bool>(class1199.method_0)).ToList<GClass202>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2561);
      return (List<GClass202>) null;
    }
  }

  public void method_39(ListView listView_0)
  {
    try
    {
      listView_0.Items.Clear();
      this.gclass0_0.method_603(listView_0, "No.", "Distance", "Bearing", "Destination");
      List<GClass120> list = this.gclass0_0.dictionary_12.Values.Where<GClass120>((Func<GClass120, bool>) (gclass120_0 => gclass120_0.gclass200_0 == this.gclass200_0 && gclass120_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID))).OrderBy<GClass120, double>((Func<GClass120, double>) (gclass120_0 => gclass120_0.double_0)).ToList<GClass120>();
      int num = 1;
      foreach (GClass120 object_1 in list)
      {
        if (object_1.dictionary_0[this.gclass21_0.RaceID].int_2 == 1)
        {
          string string_13 = "Unexplored";
          if (object_1.dictionary_0[this.gclass21_0.RaceID].int_1 == 1 && object_1.gclass120_0 != null)
            string_13 = this.gclass21_0.dictionary_0[object_1.gclass120_0.gclass200_0.int_0].Name;
          if (object_1.dictionary_0[this.gclass21_0.RaceID].int_4 == 1)
            string_13 += " (MR)";
          if (object_1.int_2 > 0)
            string_13 += " (S)";
          this.gclass0_0.method_604(listView_0, num.ToString(), GClass226.smethod_60(object_1.double_0 * GClass226.double_14), GClass226.smethod_37(object_1.int_1), string_13, (object) object_1);
          ++num;
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2562);
    }
  }

  public void method_40(
    Label label_0,
    Label label_1,
    Label label_2,
    Label label_3,
    Label label_4)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass202.Class1201 class1201 = new GClass202.Class1201();
      // ISSUE: reference to a compiler-generated field
      class1201.gclass202_0 = this;
      label_0.Text = this.gclass200_0.double_0.ToString() + " GY";
      label_1.Text = this.string_0;
      label_2.Text = this.gclass200_0.int_4.ToString();
      int num1 = this.gclass200_0.dictionary_0.Values.Where<GClass213>((Func<GClass213, bool>) (gclass213_0 => gclass213_0.list_0.Contains(this.gclass21_0.RaceID))).Count<GClass213>();
      label_3.Text = GClass226.smethod_38((Decimal) num1 / 30M * 100M) + "%";
      // ISSUE: reference to a compiler-generated field
      class1201.list_0 = this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_1 => gclass1_1.gclass200_0 == this.gclass200_0)).ToList<GClass1>();
      // ISSUE: reference to a compiler-generated field
      if (class1201.list_0.Count == 0)
      {
        label_4.Text = "100%";
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        int num2 = this.gclass0_0.list_9.Where<GClass215>(new Func<GClass215, bool>(class1201.method_0)).Count<GClass215>();
        // ISSUE: reference to a compiler-generated field
        label_4.Text = GClass226.smethod_38((Decimal) num2 / (Decimal) class1201.list_0.Count * 100M) + "%";
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2563);
    }
  }

  public void method_41(
    ListView listView_0,
    GClass21 gclass21_1,
    GClass194 gclass194_0,
    CheckState checkState_0)
  {
    try
    {
      listView_0.Items.Clear();
      this.gclass0_0.method_628(listView_0, "Name", "Spectral", "Diameter", "Mass", "Luminosity", "Parent", "Period", "Distance", "Perihelion", "Aphelion", "Planets", "Moons", "Asteroids", "Comets", "Habitable", "Near-Hab", "Ecc", (object) null);
      List<GClass197> gclass197List = this.gclass200_0.method_26();
      int num1 = 1;
      foreach (GClass197 gclass197 in gclass197List)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass202.Class1202 class1202 = new GClass202.Class1202();
        // ISSUE: reference to a compiler-generated field
        class1202.gclass197_0 = gclass197;
        string string_10 = this.Name;
        if (this.gclass200_0.int_3 > 1)
          string_10 = $"{string_10}-{char.ConvertFromUtf32(64 /*0x40*/ + num1)}";
        string string_15 = "-";
        string string_16 = "-";
        string string_17 = "-";
        string string_18 = "-";
        string string_19 = "-";
        // ISSUE: reference to a compiler-generated field
        if (class1202.gclass197_0.gclass197_0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          string_15 = char.ConvertFromUtf32(64 /*0x40*/ + class1202.gclass197_0.gclass197_0.int_3);
          // ISSUE: reference to a compiler-generated field
          string_16 = GClass226.smethod_50(class1202.gclass197_0.double_5);
          // ISSUE: reference to a compiler-generated field
          string_17 = GClass226.smethod_1(class1202.gclass197_0.double_17);
          // ISSUE: reference to a compiler-generated field
          string_18 = GClass226.smethod_1(class1202.gclass197_0.double_10);
          // ISSUE: reference to a compiler-generated field
          string_19 = GClass226.smethod_1(class1202.gclass197_0.double_11);
        }
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        int num5 = 0;
        int num6 = 0;
        int num7 = 0;
        int num8 = 0;
        // ISSUE: reference to a compiler-generated method
        foreach (GClass1 gclass1 in this.gclass0_0.dictionary_11.Values.Where<GClass1>(new Func<GClass1, bool>(class1202.method_0)).ToList<GClass1>())
        {
          if (gclass1.genum12_0 == GEnum12.const_1)
            ++num2;
          else if (gclass1.genum12_0 == GEnum12.const_2)
            ++num3;
          else if (gclass1.genum12_0 == GEnum12.const_3)
            ++num4;
          else if (gclass1.genum12_0 == GEnum12.const_5)
            ++num5;
          gclass1.method_58(gclass21_1, gclass194_0, true);
          if (checkState_0 == CheckState.Unchecked)
          {
            if (gclass1.decimal_0 >= 0M && gclass1.decimal_0 < 2M)
              ++num6;
            else if (gclass1.decimal_0 >= 0M && gclass1.decimal_0 < 3M)
            {
              if (gclass1.double_7 < gclass194_0.double_7)
                ++num8;
              else
                ++num7;
            }
          }
          else if (gclass1.decimal_1 >= 0M && gclass1.decimal_1 < 2M)
            ++num6;
          else if (gclass1.decimal_1 >= 0M && gclass1.decimal_1 < 3M)
          {
            if (gclass1.double_7 < gclass194_0.double_7)
              ++num8;
            else
              ++num7;
          }
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.gclass0_0.method_628(listView_0, string_10, class1202.gclass197_0.gclass217_0.StellarDescription, GClass226.smethod_50(class1202.gclass197_0.gclass217_0.method_1() / 1000000.0) + "m", GClass226.smethod_50(class1202.gclass197_0.gclass217_0.double_1), GClass226.smethod_50(class1202.gclass197_0.double_4), string_15, string_16, string_17, string_18, string_19, num2.ToString(), num3.ToString(), num4.ToString(), num5.ToString(), num6.ToString(), $"{num7.ToString()} / {num8.ToString()}", GClass226.smethod_50(class1202.gclass197_0.double_7), (object) class1202.gclass197_0);
        ++num1;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2564);
    }
  }

  public bool method_42()
  {
    try
    {
      if (this.gclass200_0.dictionary_0.Values.Where<GClass213>((Func<GClass213, bool>) (gclass213_0 => gclass213_0.list_0.Contains(this.gclass21_0.RaceID))).Count<GClass213>() != 30)
        return false;
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_22, "Gravitational survey completed in " + this.Name, this.gclass21_0, this.gclass200_0, 0.0, 0.0, AuroraEventCategory.System);
      this.bool_1 = true;
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2565);
      return false;
    }
  }

  public bool method_43()
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass202.Class1203 class1203 = new GClass202.Class1203();
      // ISSUE: reference to a compiler-generated field
      class1203.gclass202_0 = this;
      // ISSUE: reference to a compiler-generated field
      class1203.list_0 = this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_1 => gclass1_1.gclass200_0 == this.gclass200_0)).ToList<GClass1>();
      // ISSUE: reference to a compiler-generated field
      if (class1203.list_0.Count == 0)
        return true;
      // ISSUE: reference to a compiler-generated method
      this.int_26 = this.gclass0_0.list_9.Where<GClass215>(new Func<GClass215, bool>(class1203.method_0)).Count<GClass215>();
      // ISSUE: reference to a compiler-generated field
      return this.int_26 == class1203.list_0.Count;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2566);
      return false;
    }
  }

  public void method_44()
  {
    try
    {
      foreach (GClass213 gclass213 in this.gclass200_0.dictionary_0.Values)
      {
        gclass213.method_0(this.gclass21_0);
        this.method_45(gclass213.int_2, (GClass21) null, (GClass85) null);
      }
      this.bool_1 = true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2567);
    }
  }

  public bool method_45(int int_37, GClass21 gclass21_1, GClass85 gclass85_1)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass202.Class1204 class1204 = new GClass202.Class1204();
    // ISSUE: reference to a compiler-generated field
    class1204.gclass202_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1204.gclass21_0 = gclass21_1;
    try
    {
      bool flag = false;
      // ISSUE: reference to a compiler-generated method
      foreach (GClass120 gclass120 in this.gclass0_0.dictionary_12.Values.Where<GClass120>(new Func<GClass120, bool>(class1204.method_0)).ToList<GClass120>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass202.Class1205 class1205 = new GClass202.Class1205();
        // ISSUE: reference to a compiler-generated field
        class1205.gclass120_0 = gclass120;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (this.gclass200_0.dictionary_0.Values.Where<GClass213>(new Func<GClass213, bool>(new GClass202.Class1206()
        {
          double_0 = Math.Pow(class1205.gclass120_0.double_1, 2.0) + Math.Pow(class1205.gclass120_0.double_2, 2.0)
        }.method_0)).OrderBy<GClass213, double>(new Func<GClass213, double>(class1205.method_0)).FirstOrDefault<GClass213>().int_2 == int_37 && class1205.gclass120_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && class1205.gclass120_0.dictionary_0[this.gclass21_0.RaceID].int_2 == 0)
        {
          // ISSUE: reference to a compiler-generated field
          class1205.gclass120_0.dictionary_0[this.gclass21_0.RaceID].int_2 = 1;
          // ISSUE: reference to a compiler-generated field
          if (class1204.gclass21_0 == null)
          {
            if (gclass85_1 != null)
            {
              gclass85_1.method_16(AuroraMeasurementType.JumpPointsDiscovered, 1M);
              gclass85_1.method_17(AuroraMeasurementType.JumpPointsDiscovered, (GClass1) null, (GClass120) null, "");
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              this.gclass0_0.gclass92_0.method_2(GEnum126.const_82, $"{gclass85_1.method_15()} discovered a new jump point in {this.Name}", this.gclass21_0, this.gclass200_0, class1205.gclass120_0.double_1, class1205.gclass120_0.double_2, AuroraEventCategory.JumpPoint);
            }
            flag = true;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_82, $"New jump point detected in {this.Name} as a result of survey data provided by {class1204.gclass21_0.dictionary_10.Values.Where<GClass110>(class1204.func_0 ?? (class1204.func_0 = new Func<GClass110, bool>(class1204.method_1))).Select<GClass110, string>((Func<GClass110, string>) (gclass110_0 => gclass110_0.AlienRaceName)).FirstOrDefault<string>()}", this.gclass21_0, this.gclass200_0, class1205.gclass120_0.double_1, class1205.gclass120_0.double_2, AuroraEventCategory.JumpPoint);
          }
        }
      }
      return flag;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2568);
      return false;
    }
  }

  public List<GClass146> method_46()
  {
    return this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass21_0 == this.gclass21_0 && gclass146_0.gclass202_0 == this)).OrderByDescending<GClass146, Decimal>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.decimal_30)).ToList<GClass146>();
  }

  public GClass221 method_47(double double_12, double double_13)
  {
    return new GClass221()
    {
      double_0 = (double_12 + this.double_3) / this.double_2 + this.gclass0_0.double_4,
      double_1 = (double_13 + this.double_4) / this.double_2 + this.gclass0_0.double_5
    };
  }
}
