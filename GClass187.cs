// Decompiled with JetBrains decompiler
// Type: GClass187
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class GClass187
{
  private sealed class Class1156
  {
    public GClass40 gclass40_0;
    public GClass187 gclass187_0;

    public Class1156()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass1_0 == this.gclass40_0.gclass85_0.gclass1_0 && gclass146_0.gclass21_0 == this.gclass187_0.gclass21_0;
    }
  }

  
  private sealed class Class1157
  {
    public List<GClass146> list_0;

    public Class1157()
    {
      
    }

    internal bool method_0(GClass193 gclass193_0)
    {
      return this.list_0.Contains(gclass193_0.gclass146_0);
    }
  }

  
  private sealed class Class1158
  {
    public GClass187 gclass187_0;
    public GClass14 gclass14_0;

    public Class1158()
    {
      
    }

    internal bool method_0(GClass22 gclass22_0)
    {
      return gclass22_0.gclass187_0 == this.gclass187_0 && gclass22_0.int_38 == 0 && gclass22_0.gclass14_0 == this.gclass14_0;
    }
  }

  
  private sealed class Class1159
  {
    public List<GClass200> list_0;

    public Class1159()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return this.list_0.Contains(gclass1_0.gclass200_0);
    }
  }

  
  private sealed class Class1160
  {
    public GClass187 gclass187_0;
    public GClass22 gclass22_0;

    public Class1160()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      return gclass40_0.gclass187_0 == this.gclass187_0 && gclass40_0.gclass22_0.auroraClassMainFunction_0 == this.gclass22_0.auroraClassMainFunction_0 && gclass40_0.decimal_1 < this.gclass187_0.gclass0_0.decimal_0 - GClass226.decimal_29 * 10M;
    }
  }

  
  private sealed class Class1161
  {
    public GClass58 gclass58_0;

    public Class1161()
    {
      
    }

    internal bool method_0(GClass57 gclass57_0)
    {
      return gclass57_0.gclass58_0 == this.gclass58_0 && gclass57_0.bool_1;
    }
  }
  
  public List<GClass188> list_0 = new List<GClass188>();
  private GClass0 gclass0_0;
  public GClass21 gclass21_0;
  public GClass230 gclass230_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public Decimal decimal_0;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public bool bool_0;
  public string string_0;
  public string string_1;
  public int int_3;
  public int int_4;
  public int int_5;
  public int int_6;
  public int int_7;
  public int int_8;
  public int int_9;
  public int int_10;

  public GClass187(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public void method_0()
  {
    try
    {
      foreach (GClass40 gclass40 in this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass187_0 == this)).Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.dictionary_5.Count > 0 || gclass40_0.list_12.Count > 0)).ToList<GClass40>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass187.Class1156 class1156 = new GClass187.Class1156();
        // ISSUE: reference to a compiler-generated field
        class1156.gclass187_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1156.gclass40_0 = gclass40;
        // ISSUE: reference to a compiler-generated field
        if (class1156.gclass40_0.gclass85_0.gclass1_0 != null)
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: reference to a compiler-generated method
          if (this.gclass0_0.dictionary_31.Values.Count<GClass193>(new Func<GClass193, bool>(new GClass187.Class1157()
          {
            list_0 = this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class1156.method_0)).ToList<GClass146>()
          }.method_0)) > 0)
          {
            // ISSUE: reference to a compiler-generated field
            class1156.gclass40_0.list_12.Clear();
            // ISSUE: reference to a compiler-generated field
            class1156.gclass40_0.dictionary_5.Clear();
            continue;
          }
        }
        // ISSUE: reference to a compiler-generated field
        if (class1156.gclass40_0.method_171(true) < 2M)
        {
          // ISSUE: reference to a compiler-generated field
          class1156.gclass40_0.gclass187_0 = (GClass187) null;
          // ISSUE: reference to a compiler-generated field
          class1156.gclass40_0.gclass85_0.gclass187_0 = (GClass187) null;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_83, $"{this.string_0} is unable to repair {class1156.gclass40_0.method_187()} so they have transferred it to our control.", this.gclass21_0, class1156.gclass40_0.gclass85_0.gclass202_0.gclass200_0, class1156.gclass40_0.gclass85_0.double_2, class1156.gclass40_0.gclass85_0.double_3, AuroraEventCategory.Ship);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3585);
    }
  }

  public void method_1(ListView listView_0, ListView listView_1)
  {
    try
    {
      listView_0.Items.Clear();
      listView_1.Items.Clear();
      List<GClass40> list = this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass187_0 == this)).ToList<GClass40>();
      Decimal decimal_73_1 = list.Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14)) * GClass226.decimal_17;
      Decimal decimal_73_2 = this.list_0.Where<GClass188>((Func<GClass188, bool>) (gclass188_0 => gclass188_0.decimal_0 > this.gclass0_0.decimal_0 - GClass226.decimal_29)).Sum<GClass188>((Func<GClass188, Decimal>) (gclass188_0 => gclass188_0.decimal_1));
      string string_11 = "No Dividend Paid";
      if (this.decimal_2 > 0M)
        string_11 = this.gclass0_0.method_584(this.decimal_2);
      this.gclass0_0.method_601(listView_0, "Total Ships", GClass226.smethod_37(list.Count), (string) null);
      this.gclass0_0.method_601(listView_0, "Total Tonnage", GClass226.smethod_39(decimal_73_1), (string) null);
      this.gclass0_0.method_601(listView_0, "Last Year Income", GClass226.smethod_39(decimal_73_2), (string) null);
      this.gclass0_0.method_601(listView_0, "Last Dividend Time", string_11, (string) null);
      this.gclass0_0.method_601(listView_0, "Last Dividend Amount", GClass226.smethod_39(this.decimal_1), (string) null);
      this.gclass0_0.method_601(listView_0, "Current Wealth", GClass226.smethod_39(this.decimal_0), (string) null);
      this.gclass0_0.method_594(listView_0, "");
      foreach (IGrouping<GClass22, GClass40> source in (IEnumerable<IGrouping<GClass22, GClass40>>) list.GroupBy<GClass40, GClass22>((Func<GClass40, GClass22>) (gclass40_0 => gclass40_0.gclass22_0)).OrderBy<IGrouping<GClass22, GClass40>, string>((Func<IGrouping<GClass22, GClass40>, string>) (igrouping_0 => igrouping_0.Key.ClassName)))
      {
        int int_72 = source.Count<GClass40>();
        this.gclass0_0.method_601(listView_0, source.Key.ClassName, GClass226.smethod_37(int_72), (string) null);
      }
      this.gclass0_0.method_611(listView_1, "Date", "Ship", "Trade Good", "Origin", "Destination", (string) null);
      this.list_0 = this.list_0.OrderByDescending<GClass188, Decimal>((Func<GClass188, Decimal>) (gclass188_0 => gclass188_0.decimal_0)).ToList<GClass188>();
      foreach (GClass188 gclass188 in this.list_0)
      {
        if (gclass188.gclass40_0 != null)
        {
          if (gclass188.bool_1)
            this.gclass0_0.method_612(listView_1, this.gclass0_0.method_584(gclass188.decimal_0), gclass188.gclass40_0.method_187(), "Colonists", gclass188.gclass146_0.PopName, gclass188.gclass146_1.PopName, GClass226.smethod_42(gclass188.decimal_1, 1), (object) null);
          else if (gclass188.gclass189_0 == null)
            this.gclass0_0.method_612(listView_1, this.gclass0_0.method_584(gclass188.decimal_0), gclass188.gclass40_0.method_187(), "Trade Goods", gclass188.gclass146_0.PopName, gclass188.gclass146_1.PopName, GClass226.smethod_42(gclass188.decimal_1, 1), (object) null);
          else
            this.gclass0_0.method_612(listView_1, this.gclass0_0.method_584(gclass188.decimal_0), gclass188.gclass40_0.method_187(), gclass188.gclass189_0.string_0, gclass188.gclass146_0.PopName, gclass188.gclass146_1.PopName, GClass226.smethod_42(gclass188.decimal_1, 1), (object) null);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2907);
    }
  }

  public GClass22 method_2(GClass14 gclass14_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass187.Class1158 class1158 = new GClass187.Class1158();
    // ISSUE: reference to a compiler-generated field
    class1158.gclass187_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1158.gclass14_0 = gclass14_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_3.Values.FirstOrDefault<GClass22>(new Func<GClass22, bool>(class1158.method_0));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2908);
      return (GClass22) null;
    }
  }

  public int method_3()
  {
    try
    {
      return this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass187_0 == this)).Count<GClass40>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2909);
      return 0;
    }
  }

  public Decimal method_4()
  {
    try
    {
      return this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass187_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_4));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2910);
      return 0M;
    }
  }

  public void method_5()
  {
    try
    {
      this.int_3 = 0;
      this.int_4 = 0;
      this.int_5 = 0;
      this.int_6 = 0;
      this.int_8 = 0;
      this.int_9 = 0;
      this.int_10 = 0;
      List<GClass40> list = this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass187_0 == this)).ToList<GClass40>();
      this.int_7 = list.Count;
      foreach (GClass40 gclass40 in list)
      {
        if (gclass40.gclass22_0.auroraClassMainFunction_0 == AuroraClassMainFunction.Freighter)
        {
          ++this.int_3;
          if (gclass40.gclass85_0.dictionary_0.Count > 0)
            ++this.int_8;
        }
        else if (gclass40.gclass22_0.auroraClassMainFunction_0 == AuroraClassMainFunction.ColonyShip)
        {
          ++this.int_4;
          if (gclass40.gclass85_0.dictionary_0.Count > 0)
            ++this.int_9;
        }
        else if (gclass40.gclass22_0.auroraClassMainFunction_0 == AuroraClassMainFunction.Liner)
        {
          ++this.int_6;
          if (gclass40.gclass85_0.dictionary_0.Count > 0)
            ++this.int_10;
        }
        else if (gclass40.gclass22_0.auroraClassMainFunction_0 == AuroraClassMainFunction.FuelHarvester)
          ++this.int_5;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2911);
    }
  }

  public Decimal method_6()
  {
    try
    {
      Decimal num1 = this.method_4();
      if (num1 == 0M)
        return 0M;
      Decimal num2 = (num1 + this.decimal_0) / 10M;
      if (num2 > this.decimal_0 - 1000M)
        num2 = this.decimal_0 - 1000M;
      if (num2 < 0M)
        num2 = 0M;
      return num2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2912);
      return 0M;
    }
  }

  public void method_7()
  {
    try
    {
      Decimal num1 = this.method_6();
      if (this.gclass0_0.decimal_0 - this.decimal_2 > GClass226.decimal_29)
      {
        this.decimal_0 -= num1;
        this.decimal_1 = num1;
        this.decimal_2 = this.gclass0_0.decimal_0;
      }
      if (this.decimal_0 < num1 + 500M)
        return;
      int num2 = this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.decimal_4 > 0M && gclass146_0.gclass21_0 == this.gclass21_0)).Count<GClass146>();
      int num3 = this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.decimal_4 > 0M && gclass146_0.gclass21_0 == this.gclass21_0)).Select<GClass146, GClass202>((Func<GClass146, GClass202>) (gclass146_0 => gclass146_0.gclass202_0)).Distinct<GClass202>().Count<GClass202>();
      if (num2 < 2)
        return;
      if (this.decimal_0 < 25000M)
      {
        Decimal num4 = 1M;
        if (this.decimal_0 > 6000M)
          num4 = (Decimal) (int) (this.decimal_0 - 5000M) / 1000M;
        if ((Decimal) GClass226.smethod_13(16 /*0x10*/) > num4)
          return;
      }
      this.method_5();
      GClass146 gclass146_1 = this.gclass0_0.dictionary_22.Values.FirstOrDefault<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.bool_0 && gclass146_0.gclass21_0 == this.gclass21_0));
      if (gclass146_1 == null)
        return;
      AuroraClassMainFunction classMainFunction;
      if (this.int_7 < 6)
        classMainFunction = this.method_8();
      else if (this.int_8 == this.int_3 && this.int_9 == this.int_4)
        classMainFunction = this.method_8();
      else if (this.int_8 == this.int_3)
        classMainFunction = AuroraClassMainFunction.Freighter;
      else if (this.int_9 == this.int_4)
        classMainFunction = AuroraClassMainFunction.ColonyShip;
      else if (this.int_10 == this.int_6 && num3 > 1)
      {
        classMainFunction = AuroraClassMainFunction.Liner;
      }
      else
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        GClass1 gclass1 = this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian)).Where<GClass1>(new Func<GClass1, bool>(new GClass187.Class1159()
        {
          list_0 = this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.decimal_30 > 10M && gclass146_0.gclass21_0 == this.gclass21_0)).Select<GClass146, GClass200>((Func<GClass146, GClass200>) (gclass146_0 => gclass146_0.gclass202_0.gclass200_0)).ToList<GClass200>()
        }.method_0)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.method_77(this.gclass21_0))).FirstOrDefault<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.dictionary_0.ContainsKey(AuroraElement.Sorium)));
        bool flag = false;
        if (this.gclass0_0.dictionary_50[25148].dictionary_0.ContainsKey(this.gclass21_0.RaceID))
          flag = true;
        int num5;
        do
        {
          num5 = GClass226.smethod_13(5);
          if (this.gclass21_0.bool_0)
            goto label_29;
label_23:
          if (num5 >= 3)
          {
            if (num5 != 3)
            {
              if (num5 != 4 || num3 <= 1)
                continue;
              goto label_34;
            }
            goto label_33;
          }
          goto label_32;
label_29:
          num5 = GClass226.smethod_13(4);
          goto label_23;
        }
        while (num5 != 5 || gclass1 == null || this.gclass0_0.int_78 != 1 || !flag);
        goto label_35;
label_32:
        classMainFunction = AuroraClassMainFunction.Freighter;
        goto label_36;
label_33:
        classMainFunction = AuroraClassMainFunction.ColonyShip;
        goto label_36;
label_34:
        classMainFunction = AuroraClassMainFunction.Liner;
        goto label_36;
label_35:
        classMainFunction = AuroraClassMainFunction.FuelHarvester;
      }
label_36:
      GClass22 gclass22 = (GClass22) null;
      GClass14 gclass14_0 = (GClass14) null;
      Decimal num6 = this.decimal_0 - num1;
      for (int index = 1; index < 4; ++index)
      {
        if (this.int_3 == 0 && this.int_4 == 0)
          index = 3;
        switch (classMainFunction)
        {
          case AuroraClassMainFunction.Freighter:
            if (index == 1 && this.int_3 > 5)
            {
              gclass14_0 = this.gclass0_0.dictionary_63[GEnum120.const_81];
              break;
            }
            if (index == 2 && this.int_3 > 3)
            {
              gclass14_0 = this.gclass0_0.dictionary_63[GEnum120.const_2];
              break;
            }
            if (index == 3)
            {
              gclass14_0 = this.gclass0_0.dictionary_63[GEnum120.const_1];
              break;
            }
            break;
          case AuroraClassMainFunction.ColonyShip:
            if (index == 1 && this.int_4 > 5)
            {
              gclass14_0 = this.gclass0_0.dictionary_63[GEnum120.const_82];
              break;
            }
            if (index == 2 && this.int_4 > 3)
            {
              gclass14_0 = this.gclass0_0.dictionary_63[GEnum120.const_4];
              break;
            }
            if (index == 3)
            {
              gclass14_0 = this.gclass0_0.dictionary_63[GEnum120.const_3];
              break;
            }
            break;
          case AuroraClassMainFunction.FuelHarvester:
            if (index == 1)
            {
              gclass14_0 = this.gclass0_0.dictionary_63[GEnum120.const_6];
              break;
            }
            break;
          case AuroraClassMainFunction.Liner:
            switch (index)
            {
              case 1:
                gclass14_0 = this.gclass0_0.dictionary_63[GEnum120.const_43];
                break;
              case 2:
                gclass14_0 = this.gclass0_0.dictionary_63[GEnum120.const_40];
                break;
            }
            break;
        }
        if (gclass14_0 != null)
        {
          gclass22 = this.method_2(gclass14_0) ?? this.gclass21_0.method_6(this, gclass14_0);
          if (!(gclass22.decimal_4 < this.decimal_0 - num1) && (this.int_7 <= 20 || index != 1) && (this.int_7 <= 10 || index != 2))
          {
            gclass22 = (GClass22) null;
            gclass14_0 = (GClass14) null;
          }
          else
            break;
        }
      }
      if (gclass22 == null)
        return;
      int num7 = this.method_3();
      string string_10 = $"{gclass22.ClassName} {GClass226.smethod_33(num7 + 1)}";
      GClass40 gclass40 = this.gclass21_0.method_304(gclass146_1, (GClass40) null, (GClass193) null, gclass22, (GClass85) null, (GClass83) null, this.gclass21_0.method_164(), (GClass40) null, this, string_10, 0M, true, true, GEnum20.const_2);
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_79, $"{this.string_0} has launched a new {gclass22.ClassName} class {gclass22.gclass76_0.Description}", this.gclass21_0, gclass40.gclass85_0.gclass202_0.gclass200_0, gclass40.gclass85_0.double_2, gclass40.gclass85_0.double_3, AuroraEventCategory.Ship);
      this.decimal_0 -= gclass22.decimal_4;
      this.method_10(gclass22);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2913);
    }
  }

  public AuroraClassMainFunction method_8()
  {
    try
    {
      return this.int_3 <= this.int_4 ? (this.int_4 <= this.int_3 ? (!GClass226.smethod_23() ? AuroraClassMainFunction.Freighter : AuroraClassMainFunction.ColonyShip) : AuroraClassMainFunction.Freighter) : AuroraClassMainFunction.ColonyShip;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3777);
      return AuroraClassMainFunction.Freighter;
    }
  }

  public void method_9(GClass146 gclass146_0, GEnum120 genum120_0)
  {
    try
    {
      if (!this.gclass0_0.dictionary_63.ContainsKey(genum120_0))
        return;
      GClass14 gclass14_0 = this.gclass0_0.dictionary_63[genum120_0];
      GClass22 gclass22_1 = this.method_2(gclass14_0) ?? this.gclass21_0.method_6(this, gclass14_0);
      if (gclass22_1 == null)
        return;
      int num = this.method_3();
      string string_10 = $"{gclass22_1.ClassName} {GClass226.smethod_33(num + 1)}";
      this.gclass21_0.method_304(gclass146_0, (GClass40) null, (GClass193) null, gclass22_1, (GClass85) null, (GClass83) null, gclass146_0.gclass194_0, (GClass40) null, this, string_10, 0M, true, true, GEnum20.const_2);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2914);
    }
  }

  public void method_10(GClass22 gclass22_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass187.Class1160 class1160 = new GClass187.Class1160();
    // ISSUE: reference to a compiler-generated field
    class1160.gclass187_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1160.gclass22_0 = gclass22_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass40 gclass40_1 = this.gclass0_0.dictionary_4.Values.Where<GClass40>(new Func<GClass40, bool>(class1160.method_0)).OrderBy<GClass40, Decimal>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.decimal_1)).FirstOrDefault<GClass40>();
      if (gclass40_1 == null)
        return;
      if (gclass40_1.gclass85_0.dictionary_0.Count == 0)
      {
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_218, $"{this.string_0} has scrapped the {gclass40_1.ShipName} due to its replacement by a newer vessel", gclass40_1.gclass21_0, gclass40_1.gclass85_0.gclass202_0.gclass200_0, gclass40_1.gclass85_0.double_2, gclass40_1.gclass85_0.double_3, AuroraEventCategory.Ship);
        gclass40_1.gclass21_0.method_303(gclass40_1, GEnum22.const_3);
      }
      else
        gclass40_1.bool_13 = true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2915);
    }
  }

  public void method_11()
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      List<GClass57> list = this.gclass0_0.list_14.Where<GClass57>(new Func<GClass57, bool>(new GClass187.Class1161()
      {
        gclass58_0 = this.gclass21_0.method_116()
      }.method_0)).ToList<GClass57>();
      if (list.Count == 0)
        list = this.gclass0_0.list_14.Where<GClass57>((Func<GClass57, bool>) (gclass57_0 => gclass57_0.gclass58_0 == this.gclass0_0.dictionary_47[3] && gclass57_0.bool_1)).ToList<GClass57>();
      this.string_1 = this.gclass0_0.method_534(list).string_0;
      this.string_0 = $"{this.string_1} {this.gclass0_0.list_13.ElementAt<string>(GClass226.smethod_13(this.gclass0_0.list_13.Count) - 1)}";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2916);
    }
  }

  public void method_12(
    GClass146 gclass146_0,
    GClass146 gclass146_1,
    GClass40 gclass40_0,
    Decimal decimal_3,
    bool bool_1,
    bool bool_2,
    bool bool_3,
    GClass189 gclass189_0)
  {
    try
    {
      this.list_0.Add(new GClass188()
      {
        gclass40_0 = gclass40_0,
        gclass187_0 = gclass40_0.gclass187_0,
        gclass189_0 = gclass189_0,
        gclass146_0 = gclass146_0,
        gclass146_1 = gclass146_1,
        decimal_0 = this.gclass0_0.decimal_0,
        decimal_1 = decimal_3,
        bool_0 = bool_1,
        bool_2 = bool_2,
        bool_1 = bool_3
      });
      this.decimal_0 += decimal_3;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2917);
    }
  }

  public void method_13(GClass164 gclass164_0)
  {
    try
    {
      if (gclass164_0.gclass163_0.genum122_0 != GEnum122.const_27)
        return;
      this.gclass230_0 = (GClass230) null;
      this.int_2 = 0;
      foreach (GClass22 gclass22 in this.gclass0_0.dictionary_3.Values.Where<GClass22>((Func<GClass22, bool>) (gclass22_0 => gclass22_0.gclass187_0 == this)).ToList<GClass22>())
        gclass22.int_38 = 1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2918);
    }
  }
}
