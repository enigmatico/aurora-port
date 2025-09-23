// Decompiled with JetBrains decompiler
// Type: GClass2
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public partial class GClass2
{
  
  public List<GClass17> list_0 = new List<GClass17>();
  public List<GClass130> list_1 = new List<GClass130>();
  public List<GClass146> list_2 = new List<GClass146>();
  private GClass0 gclass0_0;
  private GClass21 gclass21_0;
  public Decimal decimal_0;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public Decimal decimal_3;
  public Decimal decimal_4;
  public AuroraShipyardType auroraShipyardType_0;

  public GClass2(GClass0 gclass0_1, GClass21 gclass21_1)
  {
    this.gclass0_0 = gclass0_1;
    this.gclass21_0 = gclass21_1;
  }

  public bool method_0(GClass210 gclass210_0, Decimal decimal_5)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class335 class335 = new GClass2.Class335();
    // ISSUE: reference to a compiler-generated field
    class335.gclass2_0 = this;
    try
    {
      if (gclass210_0.double_2 > 0.0)
        return false;
      // ISSUE: reference to a compiler-generated field
      class335.gclass202_0 = this.gclass21_0.method_190();
      // ISSUE: reference to a compiler-generated method
      List<GClass85> list = this.gclass0_0.dictionary_1.Values.Where<GClass85>(new Func<GClass85, bool>(class335.method_0)).ToList<GClass85>();
      if (list.Count == 0)
        return false;
      foreach (GClass85 gclass85 in list)
        gclass85.method_7();
      if (list.Sum<GClass85>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.decimal_7)) < decimal_5)
        return false;
      foreach (GClass85 gclass85 in list.OrderByDescending<GClass85, Decimal>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.decimal_7)).ToList<GClass85>())
      {
        gclass85.method_64(gclass210_0, false);
        decimal_5 -= gclass85.decimal_7;
        if (decimal_5 <= 0M)
          break;
      }
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3412);
      return false;
    }
  }

  public void method_1(
    List<GClass85> list_3,
    List<GClass200> list_4,
    GClass202 gclass202_0,
    GEnum105 genum105_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class336 class336 = new GClass2.Class336();
    // ISSUE: reference to a compiler-generated field
    class336.genum105_0 = genum105_0;
    // ISSUE: reference to a compiler-generated field
    class336.gclass202_0 = gclass202_0;
    // ISSUE: reference to a compiler-generated field
    class336.gclass2_0 = this;
    // ISSUE: reference to a compiler-generated field
    class336.list_0 = list_4;
    try
    {
      // ISSUE: reference to a compiler-generated method
      List<GClass85> list1 = list_3.Where<GClass85>(new Func<GClass85, bool>(class336.method_0)).ToList<GClass85>();
      if (list1.Count <= 0)
        return;
      // ISSUE: reference to a compiler-generated method
      List<GClass200> list2 = list_3.Where<GClass85>(new Func<GClass85, bool>(class336.method_1)).Select<GClass85, GClass200>((Func<GClass85, GClass200>) (gclass85_0 => gclass85_0.gclass202_0.gclass200_0)).ToList<GClass200>();
      List<GClass200> first = new List<GClass200>();
      // ISSUE: reference to a compiler-generated field
      if (class336.genum105_0 == GEnum105.const_64)
      {
        // ISSUE: reference to a compiler-generated method
        first.AddRange((IEnumerable<GClass200>) this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class336.method_2)).OrderByDescending<GClass146, Decimal>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.decimal_4)).Select<GClass146, GClass200>((Func<GClass146, GClass200>) (gclass146_0 => gclass146_0.gclass202_0.gclass200_0)).ToList<GClass200>());
        // ISSUE: reference to a compiler-generated method
        first.AddRange((IEnumerable<GClass200>) this.gclass0_0.dictionary_30.Values.Where<GClass59>(new Func<GClass59, bool>(class336.method_3)).Select<GClass59, GClass200>((Func<GClass59, GClass200>) (gclass59_0 => gclass59_0.gclass200_0)).ToList<GClass200>());
        first = first.Except<GClass200>((IEnumerable<GClass200>) list2).Distinct<GClass200>().ToList<GClass200>();
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (class336.genum105_0 == GEnum105.const_63)
        {
          // ISSUE: reference to a compiler-generated method
          first = this.gclass0_0.dictionary_29.Values.Where<GClass233>(new Func<GClass233, bool>(class336.method_4)).Select<GClass233, GClass200>((Func<GClass233, GClass200>) (gclass233_0 => gclass233_0.gclass200_0)).Except<GClass200>((IEnumerable<GClass200>) list2).Distinct<GClass200>().ToList<GClass200>();
        }
      }
      foreach (GClass200 gclass200_0 in first)
      {
        GClass210 gclass210_0 = gclass200_0.method_2();
        if (gclass210_0 != null)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass2.Class337 class337 = new GClass2.Class337();
          if (gclass210_0.double_2 <= 0.0)
          {
            Decimal num = 0M;
            // ISSUE: reference to a compiler-generated field
            class337.gclass202_0 = this.gclass21_0.method_128(gclass200_0);
            // ISSUE: reference to a compiler-generated method
            List<GClass85> list3 = list_3.Where<GClass85>(new Func<GClass85, bool>(class337.method_0)).ToList<GClass85>();
            if (list3.Count > 0)
              num = list3.Sum<GClass85>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.method_156()));
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class337.gclass202_0.gclass3_0.decimal_1 == 0M || class337.gclass202_0.gclass3_0.decimal_0 > class337.gclass202_0.gclass3_0.decimal_1 * 3M || (Decimal) class337.gclass202_0.int_0 < num)
            {
              list1[0].method_64(gclass210_0, false);
              list1.Remove(list1[0]);
              if (list1.Count == 0)
                break;
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3415);
    }
  }

  public GClass210 method_2(GClass200 gclass200_0)
  {
    try
    {
      double num = gclass200_0.method_12();
      double double_10 = GClass226.smethod_17() * 3000000000.0 * num;
      if (double_10 > 3000000000.0)
        double_10 = 3000000000.0;
      GClass221 gclass221 = this.gclass0_0.method_592(0.0, 0.0, double_10, (double) (GClass226.smethod_13(3600) - 1) / 10.0);
      GClass210 gclass210 = new GClass210(this.gclass0_0);
      gclass210.int_0 = this.gclass0_0.method_26(GEnum0.const_51);
      gclass210.gclass200_0 = gclass200_0;
      gclass210.decimal_0 = this.gclass0_0.decimal_0;
      gclass210.double_2 = 0.0;
      gclass210.double_0 = gclass221.double_0;
      gclass210.double_1 = gclass221.double_1;
      this.gclass0_0.dictionary_16.Add(gclass210.int_0, gclass210);
      return gclass210;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3416);
      return (GClass210) null;
    }
  }

  public void method_3(List<GClass85> list_3, List<GClass202> list_4, List<GClass202> list_5)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class338 class338 = new GClass2.Class338();
    // ISSUE: reference to a compiler-generated field
    class338.gclass2_0 = this;
    try
    {
      if (this.gclass0_0.dictionary_36.Values.Where<GClass21>((Func<GClass21, bool>) (gclass21_0 => !gclass21_0.bool_0)).SelectMany<GClass21, GClass202>((Func<GClass21, IEnumerable<GClass202>>) (gclass21_0 => (IEnumerable<GClass202>) gclass21_0.dictionary_0.Values)).Select<GClass202, GClass200>((Func<GClass202, GClass200>) (gclass202_0 => gclass202_0.gclass200_0)).Distinct<GClass200>().Count<GClass200>() < this.gclass0_0.int_113)
        return;
      if (this.gclass0_0.decimal_10 == 0M)
        this.gclass0_0.decimal_10 = this.gclass0_0.decimal_0;
      // ISSUE: reference to a compiler-generated field
      class338.gclass202_0 = this.gclass21_0.method_190();
      // ISSUE: reference to a compiler-generated field
      if (class338.gclass202_0 == null)
        return;
      // ISSUE: reference to a compiler-generated method
      List<GClass200> list1 = list_3.Where<GClass85>(new Func<GClass85, bool>(class338.method_0)).ToList<GClass85>().Select<GClass85, GClass200>((Func<GClass85, GClass200>) (gclass85_0 => gclass85_0.gclass202_0.gclass200_0)).Distinct<GClass200>().ToList<GClass200>();
      if (list1.Count > 0)
      {
        // ISSUE: reference to a compiler-generated field
        this.method_1(list_3, list1, class338.gclass202_0, GEnum105.const_64);
        // ISSUE: reference to a compiler-generated field
        this.method_1(list_3, list1, class338.gclass202_0, GEnum105.const_63);
      }
      // ISSUE: reference to a compiler-generated method
      List<GClass85> list2 = list_3.Where<GClass85>(new Func<GClass85, bool>(class338.method_1)).OrderByDescending<GClass85, Decimal>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.method_156())).ToList<GClass85>();
      if (list2.Count == 0)
        return;
      // ISSUE: reference to a compiler-generated field
      list1.Add(class338.gclass202_0.gclass200_0);
      // ISSUE: reference to a compiler-generated field
      class338.list_0 = this.gclass0_0.dictionary_9.Values.Where<GClass200>((Func<GClass200, bool>) (gclass200_0 => gclass200_0.double_2 == 0.0)).Except<GClass200>((IEnumerable<GClass200>) list1).ToList<GClass200>();
      if (this.gclass0_0.int_104 == 0 || GClass226.smethod_23())
      {
        // ISSUE: reference to a compiler-generated field
        class338.list_0 = this.gclass0_0.dictionary_36.Values.Where<GClass21>((Func<GClass21, bool>) (gclass21_0 => !gclass21_0.bool_0)).SelectMany<GClass21, GClass202>((Func<GClass21, IEnumerable<GClass202>>) (gclass21_0 => (IEnumerable<GClass202>) gclass21_0.dictionary_0.Values)).Select<GClass202, GClass200>((Func<GClass202, GClass200>) (gclass202_0 => gclass202_0.gclass200_0)).Distinct<GClass200>().Except<GClass200>((IEnumerable<GClass200>) list1).ToList<GClass200>();
        // ISSUE: reference to a compiler-generated field
        if (class338.list_0.Count == 0)
          return;
      }
      // ISSUE: reference to a compiler-generated method
      List<GClass202> list3 = this.gclass21_0.dictionary_0.Values.Where<GClass202>(new Func<GClass202, bool>(class338.method_2)).ToList<GClass202>();
      if (GClass226.smethod_13(5) == 4 && list3.Count > 5)
      {
        foreach (GClass202 gclass202 in list3)
          gclass202.gclass200_0.int_9 = GClass226.smethod_13(10000) + gclass202.int_4;
        // ISSUE: reference to a compiler-generated field
        class338.list_0 = list3.Select<GClass202, GClass200>((Func<GClass202, GClass200>) (gclass202_0 => gclass202_0.gclass200_0)).ToList<GClass200>();
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        foreach (GClass200 gclass200 in class338.list_0)
          gclass200.int_9 = GClass226.smethod_13(10000);
      }
      // ISSUE: reference to a compiler-generated field
      if (class338.list_0.Count < 10)
        return;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      class338.list_0 = class338.list_0.OrderByDescending<GClass200, int>((Func<GClass200, int>) (gclass200_0 => gclass200_0.int_9)).ToList<GClass200>();
      // ISSUE: reference to a compiler-generated field
      foreach (GClass200 gclass200 in class338.list_0)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class339 class339 = new GClass2.Class339();
        // ISSUE: reference to a compiler-generated field
        class339.class338_0 = class338;
        // ISSUE: reference to a compiler-generated field
        class339.gclass200_0 = gclass200;
        // ISSUE: reference to a compiler-generated field
        GClass202 gclass202_1 = this.gclass21_0.method_128(class339.gclass200_0);
        if (gclass202_1 == null)
        {
          // ISSUE: reference to a compiler-generated field
          foreach (GClass120 gclass120_0 in class339.gclass200_0.method_27())
            this.gclass21_0.method_264(gclass120_0, 0, 0);
          // ISSUE: reference to a compiler-generated field
          GClass202 gclass202_2 = this.gclass21_0.method_263(class339.gclass200_0, (GClass140) null, "", true);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          gclass202_2.method_8(class339.class338_0.gclass202_0);
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_106, $"The system of {gclass202_2.Name} has been discovered", this.gclass21_0, gclass202_2.gclass200_0, 0.0, 0.0, AuroraEventCategory.Fleet);
        }
        else if ((Decimal) gclass202_1.int_0 > list2[0].method_156())
          continue;
        // ISSUE: reference to a compiler-generated field
        GClass210 gclass210_0 = class339.gclass200_0.method_2();
        if (gclass210_0 == null)
        {
          // ISSUE: reference to a compiler-generated field
          gclass210_0 = this.method_2(class339.gclass200_0);
          // ISSUE: reference to a compiler-generated method
          List<GClass214> list4 = this.gclass0_0.dictionary_13.Values.Where<GClass214>(new Func<GClass214, bool>(class339.method_0)).ToList<GClass214>();
          // ISSUE: reference to a compiler-generated field
          List<GClass1> list5 = class339.gclass200_0.method_20().Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.genum12_0 == GEnum12.const_1)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.method_16(20, true))).ToList<GClass1>();
          foreach (GClass1 gclass1 in list5)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass2.Class340 class340 = new GClass2.Class340();
            // ISSUE: reference to a compiler-generated field
            class340.gclass1_0 = gclass1;
            // ISSUE: reference to a compiler-generated method
            if (list4.FirstOrDefault<GClass214>(new Func<GClass214, bool>(class340.method_0)) == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              this.gclass21_0.method_188(class339.gclass200_0, class340.gclass1_0, (GClass120) null, WayPointType.POI, class340.gclass1_0.double_0, class340.gclass1_0.double_1, "POI - " + class340.gclass1_0.method_78(this.gclass21_0), 0);
            }
          }
          if (list5.Count == 0)
          {
            // ISSUE: reference to a compiler-generated field
            foreach (GClass213 gclass213 in class339.gclass200_0.dictionary_0.Values.Where<GClass213>((Func<GClass213, bool>) (gclass213_0 => gclass213_0.int_2 < 7)).ToList<GClass213>())
            {
              // ISSUE: object of a compiler-generated type is created
              // ISSUE: variable of a compiler-generated type
              GClass2.Class341 class341 = new GClass2.Class341();
              // ISSUE: reference to a compiler-generated field
              class341.gclass213_0 = gclass213;
              // ISSUE: reference to a compiler-generated method
              if (GClass226.smethod_13(3) >= 3 && list4.FirstOrDefault<GClass214>(new Func<GClass214, bool>(class341.method_0)) == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.gclass21_0.method_188(class339.gclass200_0, (GClass1) null, (GClass120) null, WayPointType.POI, class341.gclass213_0.double_0, class341.gclass213_0.double_1, "POI #" + class341.gclass213_0.int_2.ToString(), 0);
              }
            }
          }
        }
        if (gclass210_0.double_2 <= 0.0)
        {
          list2[0].method_64(gclass210_0, false);
          list2.Remove(list2[0]);
          if (list2.Count == 0)
            break;
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3407);
    }
  }

  public void method_4(bool bool_0)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass2.Class342 class342 = new GClass2.Class342();
      GClass202 gclass202_0 = this.gclass21_0.method_190();
      foreach (GClass202 gclass202 in this.gclass21_0.dictionary_0.Values)
        gclass202.bool_6 = false;
      // ISSUE: reference to a compiler-generated field
      class342.list_0 = this.gclass0_0.method_34(gclass202_0);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      class342.list_1 = this.gclass21_0.dictionary_0.Values.Where<GClass202>(new Func<GClass202, bool>(class342.method_0)).ToList<GClass202>();
      // ISSUE: reference to a compiler-generated field
      if (class342.list_1.Count == 0)
        return;
      // ISSUE: reference to a compiler-generated method
      List<GClass85> list1 = this.gclass0_0.dictionary_1.Values.Where<GClass85>(new Func<GClass85, bool>(class342.method_1)).ToList<GClass85>();
      if (list1.Count == 0)
        return;
      if (!bool_0)
      {
        List<GClass40> list2 = list1.SelectMany<GClass85, GClass40>((Func<GClass85, IEnumerable<GClass40>>) (gclass85_0 => (IEnumerable<GClass40>) gclass85_0.method_176())).ToList<GClass40>();
        this.method_10(list1, list2);
        bool_0 = true;
      }
      // ISSUE: reference to a compiler-generated field
      foreach (GClass202 gclass202 in class342.list_1)
        gclass202.bool_6 = true;
      foreach (GClass85 gclass85 in list1)
      {
        gclass85.gclass4_0.bool_3 = true;
        if (gclass85.method_234(GEnum109.const_47).gclass202_0 != null)
          gclass85.gclass4_0.bool_1 = true;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3312);
    }
  }

  public double method_5(GClass110 gclass110_0, GClass202 gclass202_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class343 class343 = new GClass2.Class343();
    // ISSUE: reference to a compiler-generated field
    class343.gclass110_0 = gclass110_0;
    // ISSUE: reference to a compiler-generated field
    class343.gclass2_0 = this;
    try
    {
      // ISSUE: reference to a compiler-generated method
      double num1 = (double) this.gclass21_0.dictionary_12.Values.Where<GClass117>(new Func<GClass117, bool>(class343.method_0)).Sum<GClass117>((Func<GClass117, Decimal>) (gclass117_0 => gclass117_0.gclass115_0.gclass22_0.decimal_14));
      if (num1 == 0.0)
        return 0.0;
      // ISSUE: reference to a compiler-generated field
      GClass202 gclass202 = class343.gclass110_0.gclass21_0.method_190();
      if (gclass202_0.gclass200_0 != gclass202.gclass200_0)
        num1 *= 1.5;
      // ISSUE: reference to a compiler-generated method
      double num2 = (double) this.gclass0_0.dictionary_4.Values.Where<GClass40>(new Func<GClass40, bool>(class343.method_1)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14));
      double num3 = num1 / num2;
      double num4 = (double) this.gclass21_0.dictionary_11.Values.SelectMany<GClass115, GClass119>((Func<GClass115, IEnumerable<GClass119>>) (gclass115_0 => (IEnumerable<GClass119>) gclass115_0.list_1)).Select<GClass119, GClass230>((Func<GClass119, GClass230>) (gclass119_0 => gclass119_0.gclass230_0)).SelectMany<GClass230, GClass164>((Func<GClass230, IEnumerable<GClass164>>) (gclass230_0 => (IEnumerable<GClass164>) gclass230_0.list_0)).Select<GClass164, int>((Func<GClass164, int>) (gclass164_0 => gclass164_0.int_4)).DefaultIfEmpty<int>(0).Max<int>((Func<int, int>) (int_0 => int_0));
      // ISSUE: reference to a compiler-generated method
      double num5 = (double) this.gclass0_0.dictionary_3.Values.Where<GClass22>(new Func<GClass22, bool>(class343.method_2)).SelectMany<GClass22, GClass228>((Func<GClass22, IEnumerable<GClass228>>) (gclass22_0 => (IEnumerable<GClass228>) gclass22_0.dictionary_0.Values)).Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.bool_11)).SelectMany<GClass228, GClass164>((Func<GClass228, IEnumerable<GClass164>>) (gclass228_0 => (IEnumerable<GClass164>) gclass228_0.gclass230_0.list_0)).Max<GClass164>((Func<GClass164, int>) (gclass164_0 => gclass164_0.int_4));
      if (num4 > 0.0)
        num3 *= num4 / num5;
      // ISSUE: reference to a compiler-generated method
      double num6 = (double) this.gclass21_0.dictionary_11.Values.Where<GClass115>(new Func<GClass115, bool>(class343.method_3)).Select<GClass115, GClass22>((Func<GClass115, GClass22>) (gclass115_0 => gclass115_0.gclass22_0)).SelectMany<GClass22, GClass228>((Func<GClass22, IEnumerable<GClass228>>) (gclass22_0 => (IEnumerable<GClass228>) gclass22_0.dictionary_0.Values)).Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.Engine)).SelectMany<GClass228, GClass164>((Func<GClass228, IEnumerable<GClass164>>) (gclass228_0 => (IEnumerable<GClass164>) gclass228_0.gclass230_0.list_0)).Select<GClass164, int>((Func<GClass164, int>) (gclass164_0 => gclass164_0.int_4)).DefaultIfEmpty<int>(0).Max<int>((Func<int, int>) (int_0 => int_0));
      // ISSUE: reference to a compiler-generated method
      double num7 = (double) this.gclass0_0.dictionary_3.Values.Where<GClass22>(new Func<GClass22, bool>(class343.method_4)).SelectMany<GClass22, GClass228>((Func<GClass22, IEnumerable<GClass228>>) (gclass22_0 => (IEnumerable<GClass228>) gclass22_0.dictionary_0.Values)).Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.Engine)).SelectMany<GClass228, GClass164>((Func<GClass228, IEnumerable<GClass164>>) (gclass228_0 => (IEnumerable<GClass164>) gclass228_0.gclass230_0.list_0)).Max<GClass164>((Func<GClass164, int>) (gclass164_0 => gclass164_0.int_4));
      if (num6 > 0.0)
        num3 *= num6 / num7;
      return num3;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1);
      return 1.0;
    }
  }

  public void method_6(GClass110 gclass110_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class344 class344 = new GClass2.Class344();
    // ISSUE: reference to a compiler-generated field
    class344.gclass110_0 = gclass110_0;
    try
    {
      // ISSUE: reference to a compiler-generated field
      class344.gclass110_0.auroraContactStatus_0 = AuroraContactStatus.Hostile;
      // ISSUE: reference to a compiler-generated method
      foreach (GClass202 gclass202 in this.gclass21_0.dictionary_0.Values.Where<GClass202>(new Func<GClass202, bool>(class344.method_0)).ToList<GClass202>())
        gclass202.gclass3_0.genum95_0 = GEnum95.const_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2);
    }
  }

  public object method_7(
    GClass110 gclass110_0,
    GClass202 gclass202_0,
    GClass40 gclass40_0,
    GClass146 gclass146_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class345 class345 = new GClass2.Class345();
    // ISSUE: reference to a compiler-generated field
    class345.gclass2_0 = this;
    // ISSUE: reference to a compiler-generated field
    class345.gclass202_0 = gclass202_0;
    // ISSUE: reference to a compiler-generated field
    class345.gclass40_0 = gclass40_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      List<GClass40> list1 = this.gclass0_0.dictionary_4.Values.Where<GClass40>(new Func<GClass40, bool>(class345.method_0)).ToList<GClass40>();
      // ISSUE: reference to a compiler-generated method
      List<GClass146> list2 = this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class345.method_1)).ToList<GClass146>();
      if (gclass146_0 != null)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class346 class346 = new GClass2.Class346();
        // ISSUE: reference to a compiler-generated field
        class346.class345_0 = class345;
        // ISSUE: reference to a compiler-generated field
        class346.double_0 = gclass146_0.method_87();
        // ISSUE: reference to a compiler-generated field
        class346.double_1 = gclass146_0.method_88();
        if (list1.Count > 0)
        {
          // ISSUE: reference to a compiler-generated method
          return (object) list1.OrderBy<GClass40, double>(new Func<GClass40, double>(class346.method_0)).FirstOrDefault<GClass40>();
        }
        if (list2.Count > 0)
        {
          // ISSUE: reference to a compiler-generated method
          return (object) list2.OrderBy<GClass146, double>(new Func<GClass146, double>(class346.method_1)).FirstOrDefault<GClass146>();
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (class345.gclass40_0 != null)
      {
        if (list1.Count > 0)
        {
          // ISSUE: reference to a compiler-generated method
          return (object) list1.OrderBy<GClass40, double>(new Func<GClass40, double>(class345.method_2)).FirstOrDefault<GClass40>();
        }
        if (list2.Count > 0)
        {
          // ISSUE: reference to a compiler-generated method
          return (object) list2.OrderBy<GClass146, double>(new Func<GClass146, double>(class345.method_3)).FirstOrDefault<GClass146>();
        }
      }
      return (object) null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3);
      return (object) null;
    }
  }

  public void method_8(Decimal decimal_5)
  {
    try
    {
      Decimal num1 = decimal_5 / GClass226.decimal_29;
      Decimal num2 = (Decimal) this.gclass21_0.method_166(GEnum41.const_0) / 100M;
      GClass202 gclass202_1 = this.gclass21_0.method_190();
      GClass146 gclass146 = this.gclass21_0.method_153(gclass202_1);
      if (gclass146 == null)
        this.gclass21_0.method_82();
      if (gclass146 == null)
        return;
      Decimal num3 = gclass146.method_190();
      List<GClass65> list1 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass21_1 == this.gclass21_0 && this.gclass0_0.decimal_0 == gclass65_0.decimal_3)).Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_2())).ToList<GClass65>();
      List<GClass202> list2 = list1.Select<GClass65, GClass200>((Func<GClass65, GClass200>) (gclass65_0 => gclass65_0.gclass200_0)).Distinct<GClass200>().Select<GClass200, GClass202>((Func<GClass200, GClass202>) (gclass200_0 => this.gclass21_0.method_128(gclass200_0))).ToList<GClass202>();
      List<GClass65> list3 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass21_0 == this.gclass21_0 && this.gclass0_0.decimal_0 == gclass65_0.decimal_3)).Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_2())).ToList<GClass65>();
      List<GClass202> list4 = list3.Select<GClass65, GClass202>((Func<GClass65, GClass202>) (gclass65_0 => gclass65_0.gclass21_1.method_128(gclass65_0.gclass200_0))).Distinct<GClass202>().ToList<GClass202>();
      if (list1.Count == 0 && list3.Count == 0)
        return;
      foreach (GClass202 gclass202_2 in list4)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class347 class347 = new GClass2.Class347();
        // ISSUE: reference to a compiler-generated field
        class347.gclass202_0 = gclass202_2;
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class348 class348 = new GClass2.Class348();
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        class348.gclass202_0 = this.gclass21_0.method_128(class347.gclass202_0.gclass200_0);
        // ISSUE: reference to a compiler-generated field
        if (class348.gclass202_0.gclass3_0.genum95_0 != GEnum95.const_0)
        {
          // ISSUE: reference to a compiler-generated field
          GClass110 key = class347.gclass202_0.gclass21_0.method_325(this.gclass21_0.RaceID);
          if (key != null && key.int_1 != 1)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            GClass110 gclass110_0 = class348.gclass202_0.gclass21_0.method_325(class347.gclass202_0.gclass21_0.RaceID);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (gclass110_0 != null && gclass110_0.auroraContactStatus_0 != AuroraContactStatus.Hostile && class347.gclass202_0.dictionary_0.ContainsKey(key) && class347.gclass202_0.dictionary_0[key].auroraSystemProtectionStatus_0 != AuroraSystemProtectionStatus.NoProtection)
            {
              // ISSUE: reference to a compiler-generated field
              if (!class347.gclass202_0.gclass21_0.bool_0)
              {
                // ISSUE: reference to a compiler-generated method
                List<GClass65> list5 = list3.Where<GClass65>(new Func<GClass65, bool>(class347.method_0)).ToList<GClass65>();
                int num4 = list5.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.auroraContactType_0 == AuroraContactType.Ship)).Select<GClass65, int>((Func<GClass65, int>) (gclass65_0 => gclass65_0.int_1)).Distinct<int>().Count<int>();
                int num5 = list5.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.auroraContactType_0 != AuroraContactType.Ship && gclass65_0.auroraContactType_0 != AuroraContactType.Salvo)).Select<GClass65, int>((Func<GClass65, int>) (gclass65_0 => gclass65_0.int_1)).Distinct<int>().Count<int>();
                int num6 = list5.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.auroraContactType_0 == AuroraContactType.Salvo)).Select<GClass65, int>((Func<GClass65, int>) (gclass65_0 => gclass65_0.int_1)).Distinct<int>().Count<int>();
                string str1 = "";
                if (num4 > 0)
                  str1 = $"{str1}{num4.ToString()}x Ship ";
                if (num5 > 0)
                  str1 = $"{str1}{num5.ToString()}x Population ";
                if (num6 > 0)
                  str1 = $"{str1}{num6.ToString()}x Salvo";
                // ISSUE: reference to a compiler-generated field
                string str2 = GClass226.smethod_82((Enum) class347.gclass202_0.dictionary_0[key].auroraSystemProtectionStatus_0);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.gclass0_0.gclass92_0.method_2(GEnum126.const_100, $"Forces of the {key.AlienRaceName} have been detected in {class347.gclass202_0.Name}. As we have a protection status for this system of '{str2}', an appropriate message has been sent. Current contacts are {str1}", class347.gclass202_0.gclass21_0, class347.gclass202_0.gclass200_0, 0.0, 0.0, AuroraEventCategory.Intelligence);
              }
              // ISSUE: reference to a compiler-generated field
              AuroraSystemProtectionStatus protectionStatus0 = class347.gclass202_0.dictionary_0[key].auroraSystemProtectionStatus_0;
              // ISSUE: reference to a compiler-generated field
              if (!class347.gclass202_0.gclass21_0.bool_0)
              {
                // ISSUE: reference to a compiler-generated field
                Decimal num7 = (Decimal) Math.Pow((double) protectionStatus0, 2.0) * (Decimal) Math.Pow((double) class348.gclass202_0.gclass3_0.genum95_0, 2.0) * num2 * 2M;
                // ISSUE: reference to a compiler-generated field
                this.gclass21_0.method_22(class347.gclass202_0.gclass21_0, -num7, false);
              }
              // ISSUE: reference to a compiler-generated field
              double num8 = (double) class347.gclass202_0.method_2();
              if (num8 < 1000.0 * (double) num2)
              {
                // ISSUE: reference to a compiler-generated field
                class347.gclass202_0.dictionary_0.Remove(key);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.gclass0_0.gclass92_0.method_2(GEnum126.const_183, $"The {key.AlienRaceName} has rejected our claim on {class347.gclass202_0.Name} on the basis they have not detected sufficient evidence of a permament presence that would warrant such a claim. They warn that repeated claims without justification will damage relations.", class347.gclass202_0.gclass21_0, class347.gclass202_0.gclass200_0, 0.0, 0.0, AuroraEventCategory.Intelligence);
              }
              else
              {
                int num9 = this.gclass0_0.method_33(gclass202_1);
                // ISSUE: reference to a compiler-generated field
                GEnum95 genum950 = class348.gclass202_0.gclass3_0.genum95_0;
                // ISSUE: reference to a compiler-generated field
                class348.gclass202_0.gclass3_0.genum95_0 = GEnum95.const_0;
                int num10 = this.gclass0_0.method_33(gclass202_1);
                // ISSUE: reference to a compiler-generated field
                class348.gclass202_0.gclass3_0.genum95_0 = genum950;
                int num11 = num10;
                double num12 = (double) (num9 - num11) / 4.0;
                // ISSUE: reference to a compiler-generated field
                if (class348.gclass202_0.gclass3_0.genum95_0 < GEnum95.const_2 && num12 == 0.0)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  this.gclass0_0.gclass92_0.method_2(GEnum126.const_183, $"The {key.AlienRaceName} has accepted our sovereignty of {class347.gclass202_0.Name} as they have no significant interest in the system", class347.gclass202_0.gclass21_0, class347.gclass202_0.gclass200_0, 0.0, 0.0, AuroraEventCategory.Intelligence);
                  // ISSUE: reference to a compiler-generated field
                  class348.gclass202_0.gclass3_0.genum95_0 = GEnum95.const_0;
                  // ISSUE: reference to a compiler-generated field
                  class348.gclass202_0.gclass110_0 = gclass110_0;
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  class348.gclass202_0.method_5(class347.gclass202_0.gclass21_0);
                }
                else
                {
                  double num13 = this.method_5(gclass110_0, gclass202_1);
                  double num14 = Math.Sqrt((double) protectionStatus0);
                  double num15 = (double) (this.gclass21_0.method_166(GEnum41.const_0) + this.gclass21_0.method_166(GEnum41.const_2) + this.gclass21_0.method_166(GEnum41.const_3)) / 150.0;
                  double num16 = num12 * num15;
                  // ISSUE: reference to a compiler-generated method
                  double num17 = (double) this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class348.method_0)).Sum<GClass146>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.method_190()));
                  double num18 = Math.Pow(num8 / 100.0, 0.333);
                  if (num17 > 0.0)
                  {
                    double num19 = Math.Sqrt(num8 / num17);
                    if (num19 < num18)
                      num18 = num19;
                  }
                  double num20 = num14;
                  if (num13 * num20 * num18 > num16)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.gclass0_0.gclass92_0.method_2(GEnum126.const_183, $"The {key.AlienRaceName} has accepted our sovereignty of {class347.gclass202_0.Name} but warn that claims on additional systems will damage relations", class347.gclass202_0.gclass21_0, class347.gclass202_0.gclass200_0, 0.0, 0.0, AuroraEventCategory.Intelligence);
                    // ISSUE: reference to a compiler-generated field
                    class348.gclass202_0.gclass3_0.genum95_0 = GEnum95.const_0;
                    // ISSUE: reference to a compiler-generated field
                    class348.gclass202_0.gclass110_0 = gclass110_0;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class348.gclass202_0.method_5(class347.gclass202_0.gclass21_0);
                  }
                  else
                  {
                    // ISSUE: reference to a compiler-generated field
                    class347.gclass202_0.dictionary_0.Remove(key);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.gclass0_0.gclass92_0.method_2(GEnum126.const_183, $"The {key.AlienRaceName} has rejected our claim on {class347.gclass202_0.Name}. The system is important to them and they will defend it. Further claims will damage relations.", class347.gclass202_0.gclass21_0, class347.gclass202_0.gclass200_0, 0.0, 0.0, AuroraEventCategory.Intelligence);
                  }
                }
              }
            }
          }
        }
      }
      foreach (GClass202 gclass202_3 in this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 > GEnum95.const_2)).Intersect<GClass202>((IEnumerable<GClass202>) list2).ToList<GClass202>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class349 class349 = new GClass2.Class349();
        // ISSUE: reference to a compiler-generated field
        class349.gclass202_0 = gclass202_3;
        // ISSUE: reference to a compiler-generated method
        foreach (GClass110 gclass110_1 in list1.Where<GClass65>(new Func<GClass65, bool>(class349.method_0)).Select<GClass65, GClass21>((Func<GClass65, GClass21>) (gclass65_0 => gclass65_0.gclass21_0)).Distinct<GClass21>().Select<GClass21, GClass110>((Func<GClass21, GClass110>) (gclass21_1 => this.gclass21_0.method_325(gclass21_1.RaceID))).ToList<GClass110>())
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass2.Class350 class350 = new GClass2.Class350();
          // ISSUE: reference to a compiler-generated field
          class350.class349_0 = class349;
          // ISSUE: reference to a compiler-generated field
          class350.gclass110_0 = gclass110_1;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (class350.gclass110_0.auroraContactStatus_0 < AuroraContactStatus.Allied && (class350.gclass110_0.auroraContactStatus_0 < AuroraContactStatus.Friendly || class350.class349_0.gclass202_0.gclass3_0.genum95_0 >= GEnum95.const_4) && class350.gclass110_0.int_1 != 1)
          {
            // ISSUE: reference to a compiler-generated field
            GClass202 gclass202_4 = class350.gclass110_0.gclass21_0.method_190();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (gclass202_1.gclass200_0 != gclass202_4.gclass200_0 || class350.class349_0.gclass202_0 != gclass202_1)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              GClass202 gclass202_5 = class350.gclass110_0.gclass21_0.method_128(class350.class349_0.gclass202_0.gclass200_0);
              Decimal num21 = gclass202_5.method_2();
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              if (!(num21 > num3 / 10M * num2) || !(this.gclass0_0.dictionary_22.Values.Where<GClass146>(class350.class349_0.func_0 ?? (class350.class349_0.func_0 = new Func<GClass146, bool>(class350.class349_0.method_1))).Sum<GClass146>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.method_190())) < num21))
              {
                // ISSUE: reference to a compiler-generated method
                GClass146 gclass146_0_1 = list1.Where<GClass65>(new Func<GClass65, bool>(class350.method_0)).Select<GClass65, GClass146>((Func<GClass65, GClass146>) (gclass65_0 => gclass65_0.gclass146_0)).OrderByDescending<GClass146, Decimal>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.decimal_30)).FirstOrDefault<GClass146>();
                // ISSUE: reference to a compiler-generated method
                GClass40 gclass40_0_1 = list1.Where<GClass65>(new Func<GClass65, bool>(class350.method_1)).Select<GClass65, GClass40>((Func<GClass65, GClass40>) (gclass65_0 => gclass65_0.gclass40_0)).OrderBy<GClass40, bool>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.bool_2)).ThenByDescending<GClass40, Decimal>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14)).FirstOrDefault<GClass40>();
                if (gclass40_0_1 != null || gclass146_0_1 != null)
                {
                  Decimal num22 = 1M;
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (class350.class349_0.gclass202_0.gclass3_0.genum95_0 == GEnum95.const_3)
                  {
                    num22 = 2.5M;
                  }
                  else
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class350.class349_0.gclass202_0.gclass3_0.genum95_0 == GEnum95.const_4)
                    {
                      num22 = 5M;
                    }
                    else
                    {
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      if (class350.class349_0.gclass202_0.gclass3_0.genum95_0 == GEnum95.const_5)
                      {
                        num22 = 10M;
                      }
                      else
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class350.class349_0.gclass202_0.gclass3_0.genum95_0 == GEnum95.const_6)
                          num22 = 20M;
                      }
                    }
                  }
                  // ISSUE: reference to a compiler-generated field
                  if (class350.gclass110_0.auroraContactStatus_0 == AuroraContactStatus.Friendly)
                    num22 /= 2M;
                  // ISSUE: reference to a compiler-generated field
                  if (class350.gclass110_0.decimal_2 < 0M)
                    num22 *= 2M;
                  num22 *= num2;
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  class350.class349_0.gclass202_0.gclass3_0.int_3 = 0;
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  Decimal num23 = list1.Where<GClass65>(new Func<GClass65, bool>(class350.method_2)).Select<GClass65, GClass40>((Func<GClass65, GClass40>) (gclass65_0 => gclass65_0.gclass40_0)).Distinct<GClass40>().Where<GClass40>(new Func<GClass40, bool>(class350.method_3)).Select<GClass40, GClass115>((Func<GClass40, GClass115>) (gclass40_0 => this.gclass21_0.method_118(gclass40_0.gclass22_0))).Sum<GClass115>(class350.class349_0.func_1 ?? (class350.class349_0.func_1 = new Func<GClass115, Decimal>(class350.class349_0.method_2)));
                  if (num23 > 0M && num23 < 1000M)
                    num23 = 1000M;
                  if (num21 > 0M && num21 < 100M)
                    num21 = 100M;
                  Decimal num24 = (Decimal) Math.Sqrt((double) (num23 + num21 * 10M));
                  if (!(num24 <= 0M))
                  {
                    Decimal num25 = num24 * num22 * num1;
                    // ISSUE: reference to a compiler-generated field
                    this.gclass21_0.method_22(class350.gclass110_0.gclass21_0, -num25, false);
                    Decimal num26 = 1000M;
                    if (num25 > 0M)
                    {
                      // ISSUE: reference to a compiler-generated field
                      num26 = (class350.gclass110_0.decimal_2 + 100M) / num25;
                    }
                    // ISSUE: reference to a compiler-generated field
                    if (class350.gclass110_0.auroraContactStatus_0 != AuroraContactStatus.Hostile)
                    {
                      // ISSUE: reference to a compiler-generated field
                      if (!class350.gclass110_0.gclass21_0.bool_0)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        object object_0 = this.method_7(class350.gclass110_0, class350.class349_0.gclass202_0, gclass40_0_1, gclass146_0_1);
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        string str3 = class350.gclass110_0.gclass21_0.method_85(class350.class349_0.gclass202_0.gclass200_0, object_0);
                        // ISSUE: reference to a compiler-generated field
                        if (class350.gclass110_0.auroraCommStatus_0 != AuroraCommStatus.CommunicationEstablished)
                        {
                          if (gclass146_0_1 != null)
                            this.gclass0_0.gclass92_0.method_2(GEnum126.const_183, $"{gclass146_0_1.PopName} has receieved an unintelligible communication orginating from {str3}", gclass146_0_1.gclass21_0, gclass146_0_1.gclass202_0.gclass200_0, gclass146_0_1.method_87(), gclass146_0_1.method_88(), AuroraEventCategory.PopSummary);
                          else
                            this.gclass0_0.gclass92_0.method_2(GEnum126.const_183, $"{gclass40_0_1.gclass85_0.FleetName} has receieved an unintelligible communication orginating from {str3}", gclass40_0_1.gclass21_0, gclass40_0_1.gclass85_0.gclass202_0.gclass200_0, gclass40_0_1.gclass85_0.double_2, gclass40_0_1.gclass85_0.double_3, AuroraEventCategory.Ship);
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated field
                          GClass110 gclass110_2 = class350.gclass110_0.gclass21_0.method_325(this.gclass21_0.RaceID);
                          string str4 = $" suggesting that our forces leave {gclass202_5.Name} in the near future as the system lies within their territory";
                          if (!(num22 >= 16M) && !(num26 < 2M))
                          {
                            if (!(num22 >= 8M) && !(num26 < 5M))
                            {
                              if (!(num22 >= 4M) && !(num26 < 10M))
                              {
                                if (num22 >= 2M)
                                  str4 = $" requesting that our forces leave {gclass202_5.Name} as the system lies within their territory";
                              }
                              else
                                str4 = $" requesting that our forces leave {gclass202_5.Name} as a matter of urgency";
                            }
                            else
                              str4 = $" demanding that our forces leave {gclass202_5.Name} immediately";
                          }
                          else
                            str4 = $" demanding that our forces leave {gclass202_5.Name} immediately or they will be fired upon";
                          if (gclass146_0_1 != null)
                            this.gclass0_0.gclass92_0.method_2(GEnum126.const_183, $"The {gclass110_2.AlienRaceName} has sent a message to {gclass146_0_1.PopName}{str4}. Origin of message was {str3}", gclass146_0_1.gclass21_0, gclass146_0_1.gclass202_0.gclass200_0, gclass146_0_1.method_87(), gclass146_0_1.method_88(), AuroraEventCategory.PopSummary);
                          else
                            this.gclass0_0.gclass92_0.method_2(GEnum126.const_183, $"The {gclass110_2.AlienRaceName} has sent a message to {gclass40_0_1.ShipName}{str4}. Origin of message was {str3}", gclass40_0_1.gclass21_0, gclass40_0_1.gclass85_0.gclass202_0.gclass200_0, gclass40_0_1.gclass85_0.double_2, gclass40_0_1.gclass85_0.double_3, AuroraEventCategory.Ship);
                        }
                      }
                      else
                      {
                        AuroraSystemProtectionStatus protectionStatus = AuroraSystemProtectionStatus.SuggestLeave;
                        if (num22 >= 20M)
                          protectionStatus = AuroraSystemProtectionStatus.DemandLeaveWithThreat;
                        else if (num22 >= 10M)
                          protectionStatus = AuroraSystemProtectionStatus.DemandLeave;
                        else if (num22 >= 5M)
                          protectionStatus = AuroraSystemProtectionStatus.RequestLeaveUrgently;
                        else if (num22 >= 2M)
                          protectionStatus = AuroraSystemProtectionStatus.RequestLeave;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class350.class349_0.gclass202_0.dictionary_0.ContainsKey(class350.gclass110_0))
                        {
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          class350.class349_0.gclass202_0.dictionary_0[class350.gclass110_0].auroraSystemProtectionStatus_0 = protectionStatus;
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          class350.class349_0.gclass202_0.dictionary_0.Add(class350.gclass110_0, new GClass111()
                          {
                            auroraSystemProtectionStatus_0 = protectionStatus,
                            gclass202_0 = class350.class349_0.gclass202_0,
                            gclass110_0 = class350.gclass110_0
                          });
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 4);
    }
  }

  public void method_9(bool bool_0, int int_0)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass2.Class351 class351 = new GClass2.Class351();
      // ISSUE: reference to a compiler-generated field
      class351.gclass2_0 = this;
      if (this.gclass21_0.genum6_0 == GEnum6.const_5 && this.gclass0_0.int_91 == 0)
        return;
      List<GClass85> list1 = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass21_0 == this.gclass21_0)).ToList<GClass85>();
      List<GClass40> list2 = this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass21_0 == this.gclass21_0)).ToList<GClass40>();
      List<GClass146> list3 = this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass21_0 == this.gclass21_0)).ToList<GClass146>();
      if (list2.Count == 0 && list3.Count == 0)
        return;
      list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.list_3.Count == 0)).ToList<GClass85>();
      bool bool_0_1 = false;
      List<GClass65> list4 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.gclass21_1 == this.gclass21_0 && this.gclass0_0.decimal_0 - gclass65_0.decimal_3 < GClass226.decimal_29)).ToList<GClass65>();
      // ISSUE: reference to a compiler-generated field
      class351.list_0 = list4.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => this.gclass0_0.decimal_0 - gclass65_0.decimal_3 < GClass226.decimal_34 && gclass65_0.auroraContactType_0 == AuroraContactType.Ship)).Select<GClass65, GClass200>((Func<GClass65, GClass200>) (gclass65_0 => gclass65_0.gclass200_0)).Distinct<GClass200>().ToList<GClass200>();
      List<GClass146> list5 = list4.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => this.gclass0_0.decimal_0 - gclass65_0.decimal_3 < GClass226.decimal_34 && gclass65_0.auroraContactType_0 == AuroraContactType.STOGroundUnit)).Select<GClass65, GClass146>((Func<GClass65, GClass146>) (gclass65_0 => gclass65_0.gclass146_0)).Distinct<GClass146>().ToList<GClass146>();
      // ISSUE: reference to a compiler-generated method
      List<GClass202> list6 = this.gclass21_0.dictionary_0.Values.Where<GClass202>(new Func<GClass202, bool>(class351.method_0)).ToList<GClass202>();
      // ISSUE: reference to a compiler-generated field
      class351.list_1 = list4.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.auroraContactType_0 == AuroraContactType.Ship)).Select<GClass65, GClass200>((Func<GClass65, GClass200>) (gclass65_0 => gclass65_0.gclass200_0)).Distinct<GClass200>().ToList<GClass200>();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      class351.list_2 = list4.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.auroraContactType_0 == AuroraContactType.Population || gclass65_0.auroraContactType_0 == AuroraContactType.GroundUnit || gclass65_0.auroraContactType_0 == AuroraContactType.STOGroundUnit || gclass65_0.auroraContactType_0 == AuroraContactType.Shipyard || gclass65_0.auroraContactType_0 == AuroraContactType.Ship)).Select<GClass65, GClass200>((Func<GClass65, GClass200>) (gclass65_0 => gclass65_0.gclass200_0)).Distinct<GClass200>().Except<GClass200>((IEnumerable<GClass200>) class351.list_1).ToList<GClass200>();
      // ISSUE: reference to a compiler-generated method
      List<GClass202> list7 = this.gclass21_0.dictionary_0.Values.Where<GClass202>(new Func<GClass202, bool>(class351.method_1)).ToList<GClass202>();
      // ISSUE: reference to a compiler-generated method
      List<GClass202> list8 = this.gclass21_0.dictionary_0.Values.Where<GClass202>(new Func<GClass202, bool>(class351.method_2)).ToList<GClass202>();
      List<GClass202> list9 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_0)).ToList<GClass202>();
      List<GClass202> list10 = list7.SelectMany<GClass202, GClass202>((Func<GClass202, IEnumerable<GClass202>>) (gclass202_0 => (IEnumerable<GClass202>) gclass202_0.method_37(true))).Distinct<GClass202>().OrderByDescending<GClass202, GEnum95>((Func<GClass202, GEnum95>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0)).ToList<GClass202>();
      List<GClass202> list11 = this.gclass21_0.dictionary_0.Values.Except<GClass202>((IEnumerable<GClass202>) list10).Except<GClass202>((IEnumerable<GClass202>) list7).Except<GClass202>((IEnumerable<GClass202>) list9).ToList<GClass202>();
      foreach (GClass202 gclass202 in this.gclass21_0.dictionary_0.Values)
      {
        gclass202.gclass3_0.int_1 = 0;
        gclass202.gclass3_0.int_0 = 0;
        gclass202.gclass3_0.genum96_0 = GEnum96.const_0;
      }
      foreach (GClass85 gclass85 in list1)
      {
        gclass85.gclass4_0.bool_2 = false;
        gclass85.bool_5 = gclass85.gclass9_0.bool_1;
        gclass85.gclass4_0.method_5();
      }
      foreach (GClass202 gclass202 in list10)
        gclass202.gclass3_0.genum96_0 = GEnum96.const_1;
      foreach (GClass202 gclass202 in list8)
        gclass202.gclass3_0.genum96_0 = GEnum96.const_2;
      foreach (GClass202 gclass202 in list7)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class352 class352 = new GClass2.Class352()
        {
          gclass202_0 = gclass202
        };
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class352.gclass202_0.gclass3_0.int_0 = list4.Where<GClass65>(new Func<GClass65, bool>(class352.method_0)).Select<GClass65, int>((Func<GClass65, int>) (gclass65_0 => gclass65_0.int_1)).Distinct<int>().Count<int>();
        // ISSUE: reference to a compiler-generated field
        class352.gclass202_0.gclass3_0.genum96_0 = GEnum96.const_3;
      }
      foreach (GClass202 gclass202 in list6)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class353 class353 = new GClass2.Class353()
        {
          class351_0 = class351,
          gclass202_0 = gclass202
        };
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class353.gclass202_0.gclass3_0.int_1 = list4.Where<GClass65>(new Func<GClass65, bool>(class353.method_0)).Select<GClass65, int>((Func<GClass65, int>) (gclass65_0 => gclass65_0.int_1)).Distinct<int>().Count<int>();
        // ISSUE: reference to a compiler-generated field
        class353.gclass202_0.gclass3_0.genum96_0 = GEnum96.const_4;
      }
      if (list6.Count > 0 && this.gclass21_0.genum6_0 != GEnum6.const_1)
      {
        if (!bool_0_1)
        {
          this.method_10(list1, list2);
          bool_0_1 = true;
        }
        foreach (GClass202 gclass202 in list7)
          gclass202.gclass3_0.method_3(list1, false, false);
      }
      if (list9.Count > 0)
        this.method_4(bool_0_1);
      if (bool_0 || list6.Count > 0 && this.gclass0_0.decimal_0 - this.decimal_2 > 10000M)
      {
        this.decimal_2 = this.gclass0_0.decimal_0;
        if (!bool_0_1)
        {
          this.method_10(list1, list2);
          bool_0_1 = true;
        }
        foreach (GClass146 gclass146 in list3)
          gclass146.gclass6_0.decimal_0 = 0M;
        if (this.gclass21_0.genum6_0 == GEnum6.const_0)
          this.method_37(list1);
        if (this.gclass21_0.genum6_0 == GEnum6.const_2)
        {
          if (bool_0 || int_0 > 10000)
            this.method_17(list2, list8, list1);
          this.method_36(list1);
        }
        if (this.gclass21_0.genum6_0 != GEnum6.const_1 && this.gclass21_0.genum6_0 != GEnum6.const_5 && list8.Count > 0)
        {
          this.method_12(list1, list6, list8);
          this.method_12(list1, list6, list8);
        }
        if (this.gclass21_0.genum6_0 != GEnum6.const_5)
          this.method_38(list1);
        if (this.gclass21_0.genum6_0 == GEnum6.const_0)
          this.method_39(list1);
        if (list10.Count > 0)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: reference to a compiler-generated method
          List<GClass202> list12 = this.gclass21_0.dictionary_0.Values.Where<GClass202>(new Func<GClass202, bool>(new GClass2.Class354()
          {
            list_0 = this.gclass0_0.dictionary_13.Values.Where<GClass214>((Func<GClass214, bool>) (gclass214_0 => gclass214_0.gclass21_0 == this.gclass21_0 && gclass214_0.wayPointType_0 == WayPointType.TransitPOI)).Select<GClass214, GClass200>((Func<GClass214, GClass200>) (gclass214_0 => gclass214_0.gclass200_0)).ToList<GClass200>()
          }.method_0)).ToList<GClass202>();
          if (this.gclass21_0.genum6_0 == GEnum6.const_2)
          {
            this.method_46(list10, list7, list11, list1, GEnum104.const_23, false);
            this.method_46(list12, list7, list11, list1, GEnum104.const_23, true);
          }
          else
          {
            this.method_46(list10, list7, list11, list1, GEnum104.const_10, false);
            this.method_46(list12, list7, list11, list1, GEnum104.const_10, true);
          }
        }
        if (this.gclass21_0.genum6_0 != GEnum6.const_1 && this.gclass21_0.genum6_0 != GEnum6.const_5)
        {
          this.method_42(list1, GEnum104.const_5);
          this.method_42(list1, GEnum104.const_3);
          this.method_40(list1);
          this.method_41(list1);
        }
        if (this.gclass21_0.genum6_0 != GEnum6.const_2 && this.gclass21_0.genum6_0 != GEnum6.const_5)
        {
          this.method_48(list3);
          this.method_49(list3);
          foreach (GClass85 gclass85 in list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum104_0 == GEnum104.const_4)).ToList<GClass85>())
            gclass85.gclass4_0.method_13();
          this.method_32(list1, list3, list5);
          if (this.gclass21_0.genum6_0 == GEnum6.const_0)
            this.method_31(list1, list3, list5);
          this.method_35(list1, list3, list5, false);
        }
        if (this.gclass0_0.decimal_0 - this.decimal_1 > GClass226.decimal_31)
        {
          this.decimal_1 = this.gclass0_0.decimal_0;
          if (this.gclass21_0.genum6_0 == GEnum6.const_2)
            this.method_52(list1, list11);
          if (this.gclass21_0.genum6_0 == GEnum6.const_0)
          {
            this.method_23(list3, list1);
            this.method_53(list3);
            this.method_56(list3);
            this.method_50(list3);
            this.method_57(list3);
            this.method_61(list3);
            foreach (GClass146 gclass146 in list3)
              gclass146.method_180();
            this.method_58(list3);
            this.method_59(list3);
            this.method_60(list3);
          }
          if (this.gclass21_0.genum6_0 != GEnum6.const_5)
            this.method_51(list1, list6);
          List<GClass85> list13 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum104_0 == GEnum104.const_16 && gclass85_0.gclass4_0.genum100_0 == GEnum100.const_2 && !gclass85_0.gclass4_0.bool_1 && gclass85_0.dictionary_0.Count == 0)).ToList<GClass85>();
          if (list13.Count > 0)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass2.Class355 class355 = new GClass2.Class355();
            List<GClass200> list14 = list4.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => this.gclass0_0.decimal_0 - gclass65_0.decimal_3 < GClass226.decimal_34 && gclass65_0.auroraContactType_0 == AuroraContactType.Ship)).Select<GClass65, GClass200>((Func<GClass65, GClass200>) (gclass65_0 => gclass65_0.gclass200_0)).Distinct<GClass200>().ToList<GClass200>();
            List<GClass200> list15 = list4.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => this.gclass0_0.decimal_0 - gclass65_0.decimal_3 < GClass226.decimal_34 && gclass65_0.auroraContactType_0 == AuroraContactType.Population)).Select<GClass65, GClass200>((Func<GClass65, GClass200>) (gclass65_0 => gclass65_0.gclass200_0)).Distinct<GClass200>().ToList<GClass200>();
            // ISSUE: reference to a compiler-generated field
            class355.list_0 = list15.Except<GClass200>((IEnumerable<GClass200>) list14).ToList<GClass200>();
            // ISSUE: reference to a compiler-generated method
            List<GClass113> list16 = this.gclass21_0.dictionary_13.Values.Where<GClass113>(new Func<GClass113, bool>(class355.method_0)).ToList<GClass113>();
            this.method_27(list3, list1, list13, list16);
          }
        }
        if (this.gclass0_0.decimal_0 - this.decimal_3 > GClass226.decimal_33)
        {
          if (this.gclass21_0.genum6_0 == GEnum6.const_0)
          {
            List<GClass200> list17 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 > GEnum95.const_1 && gclass202_0.bool_2)).Except<GClass202>((IEnumerable<GClass202>) list10).Select<GClass202, GClass200>((Func<GClass202, GClass200>) (gclass202_0 => gclass202_0.gclass200_0)).ToList<GClass200>();
            this.decimal_3 = this.gclass0_0.decimal_0;
            this.method_25(list17);
          }
          if (this.gclass21_0.genum6_0 != GEnum6.const_2 && this.gclass21_0.genum6_0 != GEnum6.const_5)
            this.method_54();
        }
      }
      List<GClass85> list18 = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass85_0 != null && gclass85_0.gclass21_0 == this.gclass21_0)).Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass85_0.gclass202_0 == gclass85_0.gclass202_0)).ToList<GClass85>();
      if (list18.Count > 0)
      {
        List<GClass85> list19 = list18.Select<GClass85, GClass85>((Func<GClass85, GClass85>) (gclass85_0 => gclass85_0.gclass85_0)).Distinct<GClass85>().ToList<GClass85>();
        foreach (GClass85 gclass85 in list18)
        {
          gclass85.method_263();
          gclass85.method_222(gclass85.gclass85_0, GEnum123.const_2);
          gclass85.gclass4_0.bool_1 = true;
        }
        foreach (GClass85 gclass85 in list19)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass2.Class356 class356 = new GClass2.Class356();
          // ISSUE: reference to a compiler-generated field
          class356.class351_0 = class351;
          // ISSUE: reference to a compiler-generated field
          class356.gclass85_0 = gclass85;
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          GClass85 gclass85_5 = list18.Where<GClass85>(new Func<GClass85, bool>(class356.method_0)).OrderBy<GClass85, double>(new Func<GClass85, double>(class356.method_1)).FirstOrDefault<GClass85>();
          if (gclass85_5 != null)
          {
            // ISSUE: reference to a compiler-generated field
            class356.gclass85_0.method_263();
            // ISSUE: reference to a compiler-generated field
            class356.gclass85_0.method_222(gclass85_5, GEnum123.const_1);
            // ISSUE: reference to a compiler-generated field
            class356.gclass85_0.gclass4_0.bool_1 = true;
          }
        }
      }
      if (list6.Count <= 0 && int_0 <= 10000)
        return;
      if (!bool_0_1)
        this.method_10(list1, list2);
      List<GClass202> gclass202List = new List<GClass202>();
      List<GClass202> list20;
      if (this.gclass21_0.genum6_0 == GEnum6.const_5)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        list20 = list1.Select<GClass85, GClass202>((Func<GClass85, GClass202>) (gclass85_0 => gclass85_0.gclass202_0)).Where<GClass202>(new Func<GClass202, bool>(new GClass2.Class357()
        {
          gclass202_0 = this.gclass21_0.method_190()
        }.method_0)).Distinct<GClass202>().ToList<GClass202>();
      }
      else
        list20 = list1.Select<GClass85, GClass202>((Func<GClass85, GClass202>) (gclass85_0 => gclass85_0.gclass202_0)).Distinct<GClass202>().ToList<GClass202>();
      foreach (GClass202 gclass202 in list20)
      {
        if (gclass202.gclass3_0.genum96_0 == GEnum96.const_4 || int_0 > 10000)
          gclass202.gclass3_0.method_7(list1, list10, list7);
      }
      if (this.gclass21_0.genum6_0 != GEnum6.const_5 || this.gclass0_0.int_91 != 1)
        return;
      this.method_3(list1, list10, list7);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 5);
    }
  }

  public void method_10(List<GClass85> list_3, List<GClass40> list_4)
  {
    try
    {
      foreach (GClass40 gclass40 in list_4)
      {
        int num = (int) gclass40.gclass5_0.method_12();
      }
      foreach (GClass85 gclass85 in list_3)
        gclass85.gclass4_0.method_17();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 7);
    }
  }

  public int method_11(GClass200 gclass200_0, GClass221 gclass221_0, int int_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class358 class358 = new GClass2.Class358();
    // ISSUE: reference to a compiler-generated field
    class358.gclass2_0 = this;
    // ISSUE: reference to a compiler-generated field
    class358.gclass200_0 = gclass200_0;
    // ISSUE: reference to a compiler-generated field
    class358.gclass221_0 = gclass221_0;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass2.Class359 class359 = new GClass2.Class359();
      // ISSUE: reference to a compiler-generated method
      List<GClass40> list1 = this.gclass0_0.dictionary_1.Values.Where<GClass85>(new Func<GClass85, bool>(class358.method_0)).SelectMany<GClass85, GClass40>((Func<GClass85, IEnumerable<GClass40>>) (gclass85_0 => (IEnumerable<GClass40>) gclass85_0.method_177())).ToList<GClass40>();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      class359.list_0 = this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class358.method_1)).Where<GClass146>(new Func<GClass146, bool>(class358.method_2)).ToList<GClass146>();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      List<GClass39> list2 = this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(class358.method_3)).Where<GClass103>(new Func<GClass103, bool>(class359.method_0)).SelectMany<GClass103, GClass39>((Func<GClass103, IEnumerable<GClass39>>) (gclass103_0 => (IEnumerable<GClass39>) gclass103_0.list_0)).Where<GClass39>((Func<GClass39, bool>) (gclass39_0 =>
      {
        if (gclass39_0.gclass101_0.gclass230_0 == null)
          return false;
        return gclass39_0.auroraTargetSelection_0 == AuroraTargetSelection.PointBlankDefensiveFire || gclass39_0.auroraTargetSelection_0 == AuroraTargetSelection.PointBlankDefensiveFireSelf || gclass39_0.auroraTargetSelection_0 == AuroraTargetSelection.RangedDefensiveFire;
      })).ToList<GClass39>();
      double d = 0.0;
      foreach (GClass40 gclass40 in list1)
      {
        gclass40.method_104();
        foreach (GClass36 gclass36 in gclass40.list_4.Where<GClass36>((Func<GClass36, bool>) (gclass36_0 =>
        {
          if (gclass36_0.gclass230_0.gclass231_0.auroraComponentType_0 != AuroraComponentType.BeamFireControl)
            return false;
          return gclass36_0.auroraPointDefenceMode_0 == AuroraPointDefenceMode.PointBlankDefensiveFire || gclass36_0.auroraPointDefenceMode_0 == AuroraPointDefenceMode.RangedDefensiveFire;
        })).ToList<GClass36>())
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass2.Class360 class360 = new GClass2.Class360();
          // ISSUE: reference to a compiler-generated field
          class360.gclass36_0 = gclass36;
          // ISSUE: reference to a compiler-generated method
          List<GClass31> list3 = gclass40.list_2.Where<GClass31>(new Func<GClass31, bool>(class360.method_0)).ToList<GClass31>();
          if (list3.Count != 0)
          {
            foreach (GClass31 gclass31_0 in list3)
            {
              if (gclass31_0.gclass230_0.method_7() <= 15)
              {
                // ISSUE: reference to a compiler-generated field
                double num = gclass40.method_106(gclass31_0, class360.gclass36_0, 0.0, (double) int_0, 1.0, 1M) / 100.0;
                if (num > 1.0)
                  num = 1.0;
                d += num * (double) gclass31_0.gclass230_0.int_7;
              }
            }
          }
        }
      }
      foreach (GClass39 gclass39 in list2)
      {
        double num1 = gclass39.method_1(0.0, (double) int_0, 1.0, true, 1M) / 100.0;
        if (num1 > 1.0)
          num1 = 1.0;
        int num2 = gclass39.int_1 * gclass39.gclass101_0.gclass230_0.int_7;
        d += num1 * (double) num2;
      }
      return (int) Math.Floor(d);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 8);
      return 0;
    }
  }

  public void method_12(List<GClass85> list_3, List<GClass202> list_4, List<GClass202> list_5)
  {
    try
    {
      bool flag1 = false;
      List<GClass202> list1 = list_4.OrderByDescending<GClass202, GEnum95>((Func<GClass202, GEnum95>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0)).ToList<GClass202>();
      if (list1.Count == 0)
        list1 = list_5.OrderByDescending<GClass202, GEnum95>((Func<GClass202, GEnum95>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0)).ToList<GClass202>();
      foreach (GClass202 gclass202 in list1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class361 class361 = new GClass2.Class361();
        // ISSUE: reference to a compiler-generated field
        class361.gclass2_0 = this;
        // ISSUE: reference to a compiler-generated field
        class361.gclass202_0 = gclass202;
        // ISSUE: reference to a compiler-generated method
        List<GClass40> list2 = this.gclass0_0.dictionary_28.Values.Where<GClass65>(new Func<GClass65, bool>(class361.method_0)).Select<GClass65, GClass40>((Func<GClass65, GClass40>) (gclass65_0 => gclass65_0.gclass40_0)).Distinct<GClass40>().ToList<GClass40>();
        list2.Select<GClass40, GClass85>((Func<GClass40, GClass85>) (gclass40_0 => gclass40_0.gclass85_0)).Distinct<GClass85>().ToList<GClass85>();
        Decimal num = list2.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => !gclass40_0.gclass22_0.bool_2)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_2 * (Decimal) gclass40_0.gclass22_0.int_32));
        // ISSUE: reference to a compiler-generated method
        List<GClass85> list3 = list_3.Where<GClass85>(new Func<GClass85, bool>(class361.method_1)).Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.bool_2)).ToList<GClass85>();
        bool flag2 = false;
        foreach (GClass85 gclass85 in list3)
        {
          gclass85.method_7();
          if (gclass85.decimal_7 > num * 2M)
          {
            flag2 = true;
            break;
          }
        }
        if (!flag2)
        {
          Decimal decimal_5 = num * 2M;
          // ISSUE: reference to a compiler-generated field
          if (!this.method_45(class361.gclass202_0, decimal_5, list_3))
            flag1 = true;
        }
      }
      if (!flag1)
        return;
      List<GClass85> list4 = list_3.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.bool_2 && gclass85_0.gclass9_0.genum104_0 != GEnum104.const_30 && gclass85_0.gclass9_0.genum104_0 != GEnum104.const_29 && gclass85_0.gclass4_0.genum100_0 == GEnum100.const_2 && !gclass85_0.gclass4_0.bool_1 && !gclass85_0.gclass4_0.bool_2)).ToList<GClass85>();
      if (list4.Count <= 0)
        return;
      foreach (GClass85 gclass85 in list4)
        gclass85.method_7();
      this.method_13(list4);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 9);
    }
  }

  public bool method_13(List<GClass85> list_3)
  {
    try
    {
      List<GClass85> list = list_3.OrderByDescending<GClass85, Decimal>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.decimal_7)).ToList<GClass85>();
      if (list.Count < 2)
        return false;
      foreach (GClass85 gclass85 in list)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class362 class362 = new GClass2.Class362();
        // ISSUE: reference to a compiler-generated field
        class362.gclass85_0 = gclass85;
        // ISSUE: reference to a compiler-generated method
        GClass85 gclass85_0_1 = list.Where<GClass85>(new Func<GClass85, bool>(class362.method_0)).OrderByDescending<GClass85, Decimal>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.decimal_7)).FirstOrDefault<GClass85>();
        if (gclass85_0_1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          this.gclass21_0.method_270(gclass85_0_1.method_176(), gclass85_0_1, class362.gclass85_0, true, false);
          return true;
        }
      }
      return false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 10);
      return false;
    }
  }

  public void method_14()
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass2.Class363 class363 = new GClass2.Class363();
      List<GClass85> list1 = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass21_0 == this.gclass21_0)).ToList<GClass85>();
      List<GClass103> list2 = this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass21_0 == this.gclass21_0 && gclass103_0.gclass146_0 != null)).SelectMany<GClass103, GClass39>((Func<GClass103, IEnumerable<GClass39>>) (gclass103_0 => (IEnumerable<GClass39>) gclass103_0.list_0)).Where<GClass39>((Func<GClass39, bool>) (gclass39_0 => gclass39_0.gclass101_0.gclass230_0 != null)).Select<GClass39, GClass103>((Func<GClass39, GClass103>) (gclass39_0 => gclass39_0.gclass103_0)).Distinct<GClass103>().ToList<GClass103>();
      if (list1.Count == 0 && list2.Count == 0)
        return;
      List<GClass202> list3 = list1.Select<GClass85, GClass202>((Func<GClass85, GClass202>) (gclass85_0 => gclass85_0.gclass202_0)).ToList<GClass202>();
      list3.AddRange((IEnumerable<GClass202>) list2.Select<GClass103, GClass202>((Func<GClass103, GClass202>) (gclass103_0 => gclass103_0.gclass146_0.gclass202_0)).ToList<GClass202>());
      List<GClass202> list4 = list3.Distinct<GClass202>().ToList<GClass202>();
      List<GClass65> list5 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.gclass21_1 == this.gclass21_0 && this.gclass0_0.decimal_0 - gclass65_0.decimal_3 < GClass226.decimal_29)).OrderBy<GClass65, bool>((Func<GClass65, bool>) (gclass65_0 => this.gclass0_0.decimal_0 - gclass65_0.decimal_3 < GClass226.decimal_29)).ToList<GClass65>();
      List<GClass65> list6 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Neutral && gclass65_0.gclass21_1 == this.gclass21_0 && this.gclass0_0.decimal_0 - gclass65_0.decimal_3 < GClass226.decimal_29)).OrderBy<GClass65, bool>((Func<GClass65, bool>) (gclass65_0 => this.gclass0_0.decimal_0 - gclass65_0.decimal_3 < GClass226.decimal_29)).ToList<GClass65>();
      List<GClass65> list7 = list5.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.decimal_3 == this.gclass0_0.decimal_0 && gclass65_0.int_4 > 0)).ToList<GClass65>();
      foreach (GClass202 gclass202 in list4)
      {
        gclass202.gclass3_0.method_1(list1, list5, list6);
        gclass202.gclass3_0.method_0(list1, list5, list6);
      }
      if (list5.Count == 0)
        return;
      // ISSUE: reference to a compiler-generated field
      class363.list_0 = list7.Select<GClass65, GClass200>((Func<GClass65, GClass200>) (gclass65_0 => gclass65_0.gclass200_0)).Distinct<GClass200>().ToList<GClass200>();
      // ISSUE: reference to a compiler-generated field
      if (class363.list_0.Count == 0)
        return;
      // ISSUE: reference to a compiler-generated method
      foreach (GClass202 gclass202 in this.gclass21_0.dictionary_0.Values.Where<GClass202>(new Func<GClass202, bool>(class363.method_0)).ToList<GClass202>())
        gclass202.gclass3_0.method_2(list1, list2, list7);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 11);
    }
  }

  public void method_15()
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass2.Class364 class364 = new GClass2.Class364();
      // ISSUE: reference to a compiler-generated field
      class364.gclass146_0 = this.gclass21_0.method_191();
      // ISSUE: reference to a compiler-generated method
      foreach (GClass146 gclass146 in this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass21_0 == this.gclass21_0)).Where<GClass146>(new Func<GClass146, bool>(class364.method_0)).ToList<GClass146>())
      {
        // ISSUE: reference to a compiler-generated field
        gclass146.gclass6_0.method_3(class364.gclass146_0);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 12);
    }
  }

  public void method_16()
  {
    try
    {
      List<GClass40> list1 = this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass21_0 == this.gclass21_0)).ToList<GClass40>();
      List<GClass40> list2 = list1.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.gclass14_0.int_34 > 0)).ToList<GClass40>();
      if (list2.Count == 0)
        return;
      foreach (GClass40 gclass40_1 in list1.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.gclass14_0.int_34 == 0 && gclass40_0.decimal_17 > 0M)).ToList<GClass40>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class365 class365 = new GClass2.Class365();
        // ISSUE: reference to a compiler-generated field
        class365.gclass2_0 = this;
        // ISSUE: reference to a compiler-generated field
        class365.gclass40_0 = gclass40_1;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        List<GClass40> list3 = list2.Where<GClass40>(new Func<GClass40, bool>(class365.method_0)).OrderBy<GClass40, double>(new Func<GClass40, double>(class365.method_1)).ToList<GClass40>();
        if (list3.Count != 0)
        {
          foreach (GClass40 gclass40_2 in list3)
          {
            // ISSUE: reference to a compiler-generated field
            if (!((Decimal) gclass40_2.gclass22_0.int_64 - gclass40_2.decimal_17 >= class365.gclass40_0.decimal_17))
            {
              Decimal num = (Decimal) gclass40_2.gclass22_0.int_64 - gclass40_2.decimal_17;
              gclass40_2.decimal_17 = (Decimal) gclass40_2.gclass22_0.int_64;
              // ISSUE: reference to a compiler-generated field
              class365.gclass40_0.decimal_17 -= num;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              gclass40_2.decimal_17 += class365.gclass40_0.decimal_17;
              // ISSUE: reference to a compiler-generated field
              class365.gclass40_0.decimal_17 = 0M;
              break;
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 13);
    }
  }

  public void method_17(List<GClass40> list_3, List<GClass202> list_4, List<GClass85> list_5)
  {
    try
    {
      List<GClass40> list = list_3.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.gclass14_0.int_34 > 0 && gclass40_0.decimal_17 > 250M)).ToList<GClass40>();
      int num1 = list.OrderByDescending<GClass40, int>((Func<GClass40, int>) (gclass40_0 => gclass40_0.gclass22_0.gclass14_0.int_34)).Select<GClass40, int>((Func<GClass40, int>) (gclass40_0 => gclass40_0.gclass22_0.gclass14_0.int_34)).FirstOrDefault<int>();
      using (List<GClass40>.Enumerator enumerator = list.GetEnumerator())
      {
label_46:
        while (enumerator.MoveNext())
        {
          GClass40 current = enumerator.Current;
          if (current.gclass22_0.gclass14_0.genum120_0 != GEnum120.const_51 && current.decimal_17 == (Decimal) current.gclass22_0.int_64)
            this.method_21(current);
          else if (list_4.Contains(current.gclass85_0.gclass202_0))
          {
            Decimal num2 = this.method_20(list_3, current.gclass85_0.gclass202_0, GEnum120.const_56);
            Decimal num3 = this.method_20(list_3, current.gclass85_0.gclass202_0, GEnum120.const_55);
            Decimal num4 = this.method_20(list_3, current.gclass85_0.gclass202_0, GEnum120.const_33);
            Decimal num5 = this.method_20(list_3, current.gclass85_0.gclass202_0, GEnum120.const_52);
            Decimal num6 = this.method_20(list_3, current.gclass85_0.gclass202_0, GEnum120.const_57);
            Decimal num7 = this.method_20(list_3, current.gclass85_0.gclass202_0, GEnum120.const_61);
            Decimal num8 = num5 + num4 + num7 + num6;
            if (num2 < num8 / 2M)
            {
              GClass22 gclass22_0 = this.method_19(GEnum120.const_56);
              if (gclass22_0.decimal_4 <= current.decimal_17)
              {
                this.method_18(gclass22_0, current);
                current.decimal_17 -= gclass22_0.decimal_4;
                Decimal num9 = num2 + gclass22_0.decimal_14;
              }
            }
            if (num3 < num8 / 2M)
            {
              GClass22 gclass22_0 = this.method_19(GEnum120.const_56);
              if (gclass22_0.decimal_4 <= current.decimal_17)
              {
                this.method_18(gclass22_0, current);
                current.decimal_17 -= gclass22_0.decimal_4;
                Decimal num10 = num3 + gclass22_0.decimal_14;
              }
            }
            if (num7 < num8 / 10M)
            {
              GClass22 gclass22_0 = this.method_19(GEnum120.const_61);
              for (int index = 1; index <= 2 && gclass22_0.decimal_4 <= current.decimal_17; ++index)
              {
                this.method_18(gclass22_0, current);
                current.decimal_17 -= gclass22_0.decimal_4;
                num8 += gclass22_0.decimal_14;
              }
            }
            if (num5 < num8 / 2M || num8 == 0M)
            {
              GClass22 gclass22_0 = this.method_19(GEnum120.const_52);
              for (int index = 1; index <= 5 && gclass22_0.decimal_4 <= current.decimal_17; ++index)
              {
                this.method_18(gclass22_0, current);
                current.decimal_17 -= gclass22_0.decimal_4;
                num8 += gclass22_0.decimal_14;
              }
            }
            if (num4 < num8 / 3M)
            {
              GClass22 gclass22_0 = this.method_19(GEnum120.const_33);
              for (int index = 1; index <= 5 && gclass22_0.decimal_4 <= current.decimal_17; ++index)
              {
                this.method_18(gclass22_0, current);
                current.decimal_17 -= gclass22_0.decimal_4;
                num8 += gclass22_0.decimal_14;
              }
            }
            if (num6 < num8 / 6M)
            {
              GClass22 gclass22_0 = this.method_19(GEnum120.const_57);
              int num11 = 1;
              while (true)
              {
                if (num11 <= 5 && gclass22_0.decimal_4 <= current.decimal_17)
                {
                  this.method_18(gclass22_0, current);
                  current.decimal_17 -= gclass22_0.decimal_4;
                  num8 += gclass22_0.decimal_14;
                  ++num11;
                }
                else
                  goto label_46;
              }
            }
          }
          else
          {
            Decimal num12 = (Decimal) list_3.Count<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.gclass14_0.genum120_0 == GEnum120.const_54));
            Decimal num13 = (Decimal) list_3.Count<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.gclass14_0.genum120_0 == GEnum120.const_53));
            Decimal num14 = (Decimal) list_3.Count<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.gclass14_0.genum120_0 == GEnum120.const_59));
            Decimal num15 = (Decimal) list_3.Count<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.gclass14_0.genum120_0 == GEnum120.const_60));
            Decimal num16 = (Decimal) list_3.Count<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.gclass14_0.genum120_0 == GEnum120.const_58));
            GClass22 gclass22_0_1 = this.method_19(GEnum120.const_53);
            if (num13 < num14 && gclass22_0_1.decimal_4 <= current.decimal_17)
            {
              this.method_18(gclass22_0_1, current);
              current.decimal_17 -= gclass22_0_1.decimal_4;
              if (current.decimal_17 < 1000M)
                continue;
            }
            if (num12 < num14 && num12 < (Decimal) (num1 * 2))
            {
              GClass22 gclass22_0_2 = this.method_19(GEnum120.const_54);
              if (gclass22_0_2.decimal_4 <= current.decimal_17)
              {
                this.method_18(gclass22_0_2, current);
                current.decimal_17 -= gclass22_0_2.decimal_4;
                if (current.decimal_17 < 1000M)
                  continue;
              }
            }
            if (num14 < (Decimal) (num1 * 2))
            {
              GClass22 gclass22_0_3 = this.method_19(GEnum120.const_59);
              if (gclass22_0_3.decimal_4 <= current.decimal_17)
              {
                this.method_18(gclass22_0_3, current);
                current.decimal_17 -= gclass22_0_3.decimal_4;
                if (current.decimal_17 < 1000M)
                  continue;
              }
            }
            if (num15 < (Decimal) (num1 * 2))
            {
              GClass22 gclass22_0_4 = this.method_19(GEnum120.const_60);
              if (gclass22_0_4.decimal_4 <= current.decimal_17)
              {
                this.method_18(gclass22_0_4, current);
                current.decimal_17 -= gclass22_0_4.decimal_4;
                if (current.decimal_17 < 1000M)
                  continue;
              }
            }
            if (num13 < num14 * 3M && gclass22_0_1.decimal_4 <= current.decimal_17)
            {
              this.method_18(gclass22_0_1, current);
              current.decimal_17 -= gclass22_0_1.decimal_4;
            }
            if (num16 < (Decimal) num1)
            {
              GClass22 gclass22_0_5 = this.method_19(GEnum120.const_58);
              if (gclass22_0_5.decimal_4 <= current.decimal_17)
              {
                this.method_18(gclass22_0_5, current);
                current.decimal_17 -= gclass22_0_5.decimal_4;
              }
            }
            if (current.gclass22_0.gclass14_0.int_34 == 4)
            {
              GClass22 gclass22_0_6 = this.method_19(GEnum120.const_34);
              if (gclass22_0_6.decimal_4 <= current.decimal_17)
              {
                this.method_18(gclass22_0_6, current);
                current.decimal_17 -= gclass22_0_6.decimal_4;
              }
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 14);
    }
  }

  public void method_18(GClass22 gclass22_0, GClass40 gclass40_0)
  {
    try
    {
      GClass40 gclass40 = this.gclass21_0.method_304((GClass146) null, gclass40_0, (GClass193) null, gclass22_0, (GClass85) null, (GClass83) null, (GClass194) null, (GClass40) null, (GClass187) null, "", 100M, false, false, GEnum20.const_0);
      gclass40.gclass85_0.method_202();
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_2, $"{gclass40.ShipName} built by {gclass40_0.ShipName}", this.gclass21_0, gclass40_0.gclass85_0.gclass202_0.gclass200_0, gclass40_0.gclass85_0.double_2, gclass40_0.gclass85_0.double_3, AuroraEventCategory.Ship);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 15);
    }
  }

  public GClass22 method_19(GEnum120 genum120_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class366 class366 = new GClass2.Class366();
    // ISSUE: reference to a compiler-generated field
    class366.gclass2_0 = this;
    // ISSUE: reference to a compiler-generated field
    class366.genum120_0 = genum120_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_3.Values.FirstOrDefault<GClass22>(new Func<GClass22, bool>(class366.method_0));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 16 /*0x10*/);
      return (GClass22) null;
    }
  }

  public Decimal method_20(List<GClass40> list_3, GClass202 gclass202_0, GEnum120 genum120_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class367 class367 = new GClass2.Class367();
    // ISSUE: reference to a compiler-generated field
    class367.gclass202_0 = gclass202_0;
    // ISSUE: reference to a compiler-generated field
    class367.genum120_0 = genum120_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      return list_3.Where<GClass40>(new Func<GClass40, bool>(class367.method_0)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 17);
      return 0M;
    }
  }

  public void method_21(GClass40 gclass40_0)
  {
    try
    {
      GClass22 gclass22_1 = (GClass22) null;
      if (gclass40_0.gclass22_0.gclass14_0.genum120_0 != GEnum120.const_34)
        gclass22_1 = this.gclass0_0.dictionary_3.Values.FirstOrDefault<GClass22>((Func<GClass22, bool>) (gclass22_0 => gclass22_0.gclass21_0 == this.gclass21_0 && gclass22_0.gclass14_0.genum120_0 == GEnum120.const_39));
      else if (gclass40_0.gclass22_0.gclass14_0.genum120_0 != GEnum120.const_39)
        gclass22_1 = this.gclass0_0.dictionary_3.Values.FirstOrDefault<GClass22>((Func<GClass22, bool>) (gclass22_0 => gclass22_0.gclass21_0 == this.gclass21_0 && gclass22_0.gclass14_0.genum120_0 == GEnum120.const_50));
      else if (gclass40_0.gclass22_0.gclass14_0.genum120_0 != GEnum120.const_50)
        gclass22_1 = this.gclass0_0.dictionary_3.Values.FirstOrDefault<GClass22>((Func<GClass22, bool>) (gclass22_0 => gclass22_0.gclass21_0 == this.gclass21_0 && gclass22_0.gclass14_0.genum120_0 == GEnum120.const_51));
      if (gclass22_1 == null)
        return;
      gclass40_0.method_204("Refit to " + gclass22_1.ClassName);
      gclass40_0.method_199(gclass22_1, (GClass146) null);
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_2, $"{gclass40_0.ShipName} refitted to {gclass22_1.ClassName} class", gclass40_0.gclass21_0, gclass40_0.gclass85_0.gclass202_0.gclass200_0, gclass40_0.gclass85_0.double_2, gclass40_0.gclass85_0.double_3, AuroraEventCategory.Ship);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 18);
    }
  }

  public void method_22(GClass164 gclass164_0, int int_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class368 class368 = new GClass2.Class368();
    // ISSUE: reference to a compiler-generated field
    class368.gclass164_0 = gclass164_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass168 gclass168 = this.gclass21_0.list_7.FirstOrDefault<GClass168>(new Func<GClass168, bool>(class368.method_0));
      if (gclass168 != null)
      {
        // ISSUE: reference to a compiler-generated field
        if (gclass168.int_0 + int_0 < class368.gclass164_0.int_4)
        {
          gclass168.int_0 += int_0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          this.gclass21_0.method_282(class368.gclass164_0, (GClass55) null, (GClass146) null, (GClass21) null, false, false);
          this.gclass21_0.list_7.Remove(gclass168);
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        this.gclass21_0.list_7.Add(new GClass168()
        {
          gclass164_0 = class368.gclass164_0,
          gclass21_0 = this.gclass21_0,
          int_0 = int_0
        });
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 19);
    }
  }

  public void method_23(List<GClass146> list_3, List<GClass85> list_4)
  {
    try
    {
      List<GClass103> list = this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass21_0 == this.gclass21_0)).ToList<GClass103>();
      foreach (GClass146 gclass146 in list_3)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class369 class369 = new GClass2.Class369();
        // ISSUE: reference to a compiler-generated field
        class369.gclass146_0 = gclass146;
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
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (!(class369.gclass146_0.decimal_30 > 0M) && class369.gclass146_0.dictionary_0.Count <= 0 && class369.gclass146_0.gclass6_0.double_1 < GClass226.double_29 && (class369.gclass146_0.gclass6_0.double_0 <= 0.0 || class369.gclass146_0.gclass6_0.double_0 >= 0.1) && class369.gclass146_0.gclass1_0.int_10 <= 0 && class369.gclass146_0.gclass1_0.auroraGroundMineralSurvey_0 <= AuroraGroundMineralSurvey.Minimal && !class369.gclass146_0.bool_6 && !(class369.gclass146_0.gclass1_0.method_58(class369.gclass146_0.gclass21_0, class369.gclass146_0.gclass194_0, false) < 2M) && list.Count<GClass103>(new Func<GClass103, bool>(class369.method_0)) <= 0 && list_4.SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>(new Func<GClass139, bool>(class369.method_1)).ToList<GClass139>().Count <= 0)
        {
          // ISSUE: reference to a compiler-generated field
          this.gclass21_0.method_132(class369.gclass146_0);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 20);
    }
  }

  public void method_24(List<GClass146> list_3, List<GClass85> list_4, GClass146 gclass146_0)
  {
    try
    {
      List<GClass103> list1 = this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass21_0 == this.gclass21_0)).ToList<GClass103>();
      foreach (GClass146 gclass146 in list_3)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class370 class370 = new GClass2.Class370();
        // ISSUE: reference to a compiler-generated field
        class370.gclass146_0 = gclass146;
        // ISSUE: reference to a compiler-generated method
        if (list1.Count<GClass103>(new Func<GClass103, bool>(class370.method_0)) <= 0)
        {
          // ISSUE: reference to a compiler-generated method
          List<GClass139> list2 = list_4.SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>(new Func<GClass139, bool>(class370.method_1)).ToList<GClass139>();
          if (list2.Count <= 0 || gclass146_0 != null)
          {
            foreach (GClass139 gclass139 in list2)
              gclass139.gclass146_0 = gclass146_0;
            // ISSUE: reference to a compiler-generated field
            this.gclass21_0.method_132(class370.gclass146_0);
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 21);
    }
  }

  public void method_25(List<GClass200> list_3)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class371 class371 = new GClass2.Class371();
    // ISSUE: reference to a compiler-generated field
    class371.gclass2_0 = this;
    // ISSUE: reference to a compiler-generated field
    class371.list_0 = list_3;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass2.Class372 class372 = new GClass2.Class372();
      // ISSUE: reference to a compiler-generated field
      class372.class371_0 = class371;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      List<GClass1> list1 = this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class372.class371_0.method_0)).Select<GClass146, GClass1>((Func<GClass146, GClass1>) (gclass146_0 => gclass146_0.gclass1_0)).ToList<GClass1>();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      List<GClass1> list2 = this.gclass0_0.list_9.Where<GClass215>(new Func<GClass215, bool>(class372.class371_0.method_1)).Select<GClass215, GClass1>((Func<GClass215, GClass1>) (gclass215_0 => gclass215_0.gclass1_0)).Except<GClass1>((IEnumerable<GClass1>) list1).Except<GClass1>((IEnumerable<GClass1>) this.gclass21_0.list_9).ToList<GClass1>();
      // ISSUE: reference to a compiler-generated field
      class372.gclass194_0 = this.gclass21_0.method_164();
      foreach (GClass1 gclass1_0 in list2)
      {
        if (this.method_62(gclass1_0, false) >= GClass226.double_29)
        {
          // ISSUE: reference to a compiler-generated field
          GClass146 gclass146 = this.gclass21_0.method_276(gclass1_0, class372.gclass194_0, false);
          // ISSUE: reference to a compiler-generated field
          gclass1_0.method_58(this.gclass21_0, class372.gclass194_0, true);
          if (!(gclass1_0.decimal_0 < 0M))
          {
            gclass146.method_60(this.gclass0_0.dictionary_44[AuroraInstallationType.TrackingStation], 1, false);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (gclass1_0.decimal_1 >= 0M && gclass1_0.decimal_1 < 2.5M && gclass1_0.double_7 >= class372.gclass194_0.double_7 && gclass1_0.double_7 <= class372.gclass194_0.double_8)
            {
              gclass146.method_60(this.gclass0_0.dictionary_44[AuroraInstallationType.Infrastructure], 50, false);
              gclass146.method_25(0.0001M);
            }
            // ISSUE: reference to a compiler-generated field
            if (gclass1_0.decimal_1 >= 0M && gclass1_0.decimal_1 < 2M && gclass1_0.double_7 < class372.gclass194_0.double_7)
            {
              gclass146.method_60(this.gclass0_0.dictionary_44[AuroraInstallationType.Infrastructure], 100, false);
              gclass146.method_25(0.0001M);
            }
          }
        }
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (class372.class371_0.list_0.Count == 0 || this.gclass21_0.int_27 <= 0)
        return;
      bool flag = false;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      List<GClass1> list3 = this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class372.class371_0.method_2)).Select<GClass146, GClass1>((Func<GClass146, GClass1>) (gclass146_0 => gclass146_0.gclass1_0)).ToList<GClass1>();
      if (list3.Count <= 1)
      {
        flag = true;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if ((double) class372.class371_0.list_0.Count / (double) (list3.Count - 1) > (double) this.gclass21_0.int_27)
          flag = true;
      }
      if (!flag)
        return;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      List<GClass1> list4 = list2.Where<GClass1>(new Func<GClass1, bool>(class372.method_0)).Where<GClass1>(new Func<GClass1, bool>(class372.class371_0.method_3)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.method_16(40, false))).Except<GClass1>((IEnumerable<GClass1>) list3).ToList<GClass1>();
      foreach (GClass1 gclass1 in list4)
      {
        // ISSUE: reference to a compiler-generated field
        gclass1.method_58(this.gclass21_0, class372.gclass194_0, true);
      }
      List<GClass1> list5 = list4.Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.decimal_1 >= 0M && gclass1_0.decimal_1 < 1.5M)).ToList<GClass1>();
      if (list5.Count > 0)
      {
        foreach (GClass1 gclass1_0 in list5)
        {
          // ISSUE: reference to a compiler-generated field
          this.method_26(gclass1_0, class372.gclass194_0);
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        class372.gclass200_0 = this.gclass21_0.method_190().gclass200_0;
        // ISSUE: reference to a compiler-generated method
        GClass1 gclass1_0_1 = list4.Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.decimal_1 >= 0M && gclass1_0.decimal_1 < 2.5M)).OrderBy<GClass1, Decimal>((Func<GClass1, Decimal>) (gclass1_0 => gclass1_0.decimal_1)).ThenByDescending<GClass1, int>(new Func<GClass1, int>(class372.method_1)).FirstOrDefault<GClass1>();
        if (gclass1_0_1 == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.method_26(gclass1_0_1, class372.gclass194_0);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 22);
    }
  }

  public void method_26(GClass1 gclass1_0, GClass194 gclass194_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class373 class373 = new GClass2.Class373();
    // ISSUE: reference to a compiler-generated field
    class373.gclass1_0 = gclass1_0;
    // ISSUE: reference to a compiler-generated field
    class373.gclass2_0 = this;
    // ISSUE: reference to a compiler-generated field
    class373.gclass194_0 = gclass194_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      GClass146 gclass146 = this.gclass0_0.dictionary_22.Values.FirstOrDefault<GClass146>(new Func<GClass146, bool>(class373.method_0)) ?? this.gclass21_0.method_276(class373.gclass1_0, class373.gclass194_0, false);
      gclass146.method_25(0.0001M);
      gclass146.method_60(this.gclass0_0.dictionary_44[AuroraInstallationType.TrackingStation], 1, false);
      // ISSUE: reference to a compiler-generated field
      if (!(class373.gclass1_0.decimal_1 > 0M))
        return;
      gclass146.method_60(this.gclass0_0.dictionary_44[AuroraInstallationType.Infrastructure], 50, false);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 23);
    }
  }

  public void method_27(
    List<GClass146> list_3,
    List<GClass85> list_4,
    List<GClass85> list_5,
    List<GClass113> list_6)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass2.Class374 class374 = new GClass2.Class374();
      // ISSUE: reference to a compiler-generated field
      class374.gclass2_0 = this;
      GClass146 gclass146_1 = (GClass146) null;
      GClass102 gclass102_1 = (GClass102) null;
      GClass102 gclass102_2 = (GClass102) null;
      GClass102 gclass102_3 = (GClass102) null;
      GClass102 gclass102_4 = (GClass102) null;
      GClass102 gclass102_5 = (GClass102) null;
      GClass102 gclass102_6 = (GClass102) null;
      Decimal num1 = 0M;
      Decimal num2 = 0M;
      Decimal num3 = 0M;
      Decimal num4 = 0M;
      Decimal num5 = 0M;
      Decimal num6 = 0M;
      this.list_0.Clear();
      if (this.gclass21_0.genum6_0 == GEnum6.const_5)
        gclass146_1 = this.gclass21_0.method_191();
      foreach (GClass146 gclass146_2 in list_3)
      {
        gclass146_2.gclass6_0.method_6();
        gclass146_2.bool_6 = false;
      }
      List<GClass139> list1 = list_4.SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>((Func<GClass139, bool>) (gclass139_0 => gclass139_0.gclass133_0.genum123_0 == GEnum123.const_24 || gclass139_0.gclass133_0.genum123_0 == GEnum123.const_25)).ToList<GClass139>();
      // ISSUE: reference to a compiler-generated field
      class374.list_0 = list_4.SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>((Func<GClass139, bool>) (gclass139_0 => gclass139_0.gclass133_0.genum123_0 == GEnum123.const_23)).ToList<GClass139>();
      List<GClass103> list2 = this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass40_0 != null)).Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass40_0.gclass85_0.gclass21_0 == this.gclass21_0)).ToList<GClass103>();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      class374.list_1 = this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(class374.method_0)).ToList<GClass103>();
      List<GEnum116> list3 = this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass21_0 == this.gclass21_0)).Select<GClass103, GEnum116>((Func<GClass103, GEnum116>) (gclass103_0 => gclass103_0.gclass102_0.genum116_0)).Distinct<GEnum116>().ToList<GEnum116>();
      List<GClass85> list4 = list_5.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.method_145())).ToList<GClass85>();
      bool flag1 = false;
      if (list_6.Count > 0)
      {
        List<GClass65> list5 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.gclass21_1 == this.gclass21_0 && gclass65_0.auroraContactType_0 == AuroraContactType.GroundUnit)).ToList<GClass65>();
        List<GClass1> list6 = list_3.Select<GClass146, GClass1>((Func<GClass146, GClass1>) (gclass146_0 => gclass146_0.gclass1_0)).ToList<GClass1>();
        GClass194 gclass194_1 = this.gclass21_0.method_164();
        foreach (GClass113 gclass113 in list_6)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass2.Class375 class375 = new GClass2.Class375();
          // ISSUE: reference to a compiler-generated field
          class375.gclass113_0 = gclass113;
          GClass146 gclass146_3;
          // ISSUE: reference to a compiler-generated field
          if (!list6.Contains(class375.gclass113_0.gclass146_0.gclass1_0))
          {
            // ISSUE: reference to a compiler-generated field
            gclass146_3 = this.gclass21_0.method_276(class375.gclass113_0.gclass146_0.gclass1_0, gclass194_1, false);
            list_3.Add(gclass146_3);
          }
          else
          {
            // ISSUE: reference to a compiler-generated method
            gclass146_3 = list_3.FirstOrDefault<GClass146>(new Func<GClass146, bool>(class375.method_0));
          }
          if (gclass146_3 != null)
          {
            // ISSUE: reference to a compiler-generated method
            GClass65 gclass65 = list5.FirstOrDefault<GClass65>(new Func<GClass65, bool>(class375.method_1));
            gclass146_3.decimal_10 = 0M;
            gclass146_3.bool_6 = true;
            flag1 = true;
            // ISSUE: reference to a compiler-generated field
            gclass146_3.decimal_10 = gclass65 != null ? 100M * gclass146_3.gclass1_0.gclass99_0.decimal_1 * 3M * gclass65.decimal_0 : class375.gclass113_0.gclass146_0.decimal_4 * 1000M;
          }
        }
      }
      if (flag1)
      {
        gclass102_1 = this.gclass0_0.dictionary_72.Values.FirstOrDefault<GClass102>((Func<GClass102, bool>) (gclass102_0 => gclass102_0.genum116_0 == GEnum116.const_3 && gclass102_0.gclass21_0 == this.gclass21_0));
        gclass102_2 = this.gclass0_0.dictionary_72.Values.FirstOrDefault<GClass102>((Func<GClass102, bool>) (gclass102_0 => gclass102_0.genum116_0 == GEnum116.const_4 && gclass102_0.gclass21_0 == this.gclass21_0));
        gclass102_3 = this.gclass0_0.dictionary_72.Values.FirstOrDefault<GClass102>((Func<GClass102, bool>) (gclass102_0 => gclass102_0.genum116_0 == GEnum116.const_6 && gclass102_0.gclass21_0 == this.gclass21_0));
        gclass102_4 = this.gclass0_0.dictionary_72.Values.FirstOrDefault<GClass102>((Func<GClass102, bool>) (gclass102_0 => gclass102_0.genum116_0 == GEnum116.const_7 && gclass102_0.gclass21_0 == this.gclass21_0));
        gclass102_5 = this.gclass0_0.dictionary_72.Values.FirstOrDefault<GClass102>((Func<GClass102, bool>) (gclass102_0 => gclass102_0.genum116_0 == GEnum116.const_16 && gclass102_0.gclass21_0 == this.gclass21_0));
        if (gclass102_1 != null)
          num1 = gclass102_1.method_9();
        if (gclass102_2 != null)
          num2 = gclass102_2.method_9();
        if (gclass102_5 != null)
          num3 = gclass102_5.method_9();
        if (gclass102_3 != null)
          num5 = (Decimal) gclass102_3.method_8();
        if (gclass102_4 != null)
          num6 = (Decimal) gclass102_4.method_8();
      }
      if (this.gclass21_0.genum6_0 == GEnum6.const_5)
      {
        gclass102_6 = this.gclass0_0.dictionary_72.Values.FirstOrDefault<GClass102>((Func<GClass102, bool>) (gclass102_0 => gclass102_0.genum116_0 == GEnum116.const_20 && gclass102_0.gclass21_0 == this.gclass21_0));
        if (gclass102_6 != null)
          num4 = gclass102_6.method_9();
      }
      foreach (GClass146 gclass146_4 in list_3)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class376 class376 = new GClass2.Class376();
        // ISSUE: reference to a compiler-generated field
        class376.class374_0 = class374;
        // ISSUE: reference to a compiler-generated field
        class376.gclass146_0 = gclass146_4;
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class377 class377 = new GClass2.Class377();
        // ISSUE: reference to a compiler-generated field
        class377.class376_0 = class376;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (this.gclass21_0.genum6_0 != GEnum6.const_5 || gclass146_1 != class377.class376_0.gclass146_0)
        {
          List<GEnum116> list_3_1 = new List<GEnum116>();
          List<GClass16> gclass16List = new List<GClass16>();
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (!class377.class376_0.gclass146_0.bool_6)
          {
            if (this.gclass21_0.genum6_0 == GEnum6.const_5)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (class377.class376_0.gclass146_0.gclass6_0.genum97_0 > GEnum97.const_1)
                this.method_28(gclass102_6.genum116_0, 1, list_3_1, gclass16List);
            }
            else
            {
              foreach (GEnum116 genum116 in list3)
                list_3_1.Add(genum116);
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              gclass16List = this.gclass21_0.gclass20_0.list_0.Where<GClass16>(new Func<GClass16, bool>(class377.class376_0.method_0)).ToList<GClass16>();
            }
          }
          else
          {
            int int_0_1 = 0;
            if (num4 > 0M)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              int int_0_2 = (int) Math.Ceiling(class377.class376_0.gclass146_0.decimal_10 * 2M / num4);
              this.method_28(gclass102_6.genum116_0, int_0_2, list_3_1, gclass16List);
            }
            if (num1 > 0M)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              int_0_1 = (int) Math.Ceiling(class377.class376_0.gclass146_0.decimal_10 * 2M / num1);
              this.method_28(gclass102_1.genum116_0, int_0_1, list_3_1, gclass16List);
            }
            if (num2 > 0M)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              int int_0_3 = (int) Math.Ceiling(class377.class376_0.gclass146_0.decimal_10 / num2);
              this.method_28(gclass102_2.genum116_0, int_0_3, list_3_1, gclass16List);
            }
            if (num3 > 0M)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              int int_0_4 = (int) Math.Ceiling(class377.class376_0.gclass146_0.decimal_10 * 2M / num3);
              this.method_28(gclass102_5.genum116_0, int_0_4, list_3_1, gclass16List);
            }
            if (num5 > 0M)
            {
              int int_0_5 = (int) Math.Floor((Decimal) int_0_1 * num1 / num5);
              this.method_28(gclass102_3.genum116_0, int_0_5, list_3_1, gclass16List);
            }
            if (num6 > 0M)
            {
              int int_0_6 = (int) Math.Floor((Decimal) int_0_1 * num1 / num5);
              this.method_28(gclass102_4.genum116_0, int_0_6, list_3_1, gclass16List);
            }
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          class377.list_0 = list1.Where<GClass139>(new Func<GClass139, bool>(class377.class376_0.method_1)).Select<GClass139, GClass85>((Func<GClass139, GClass85>) (gclass139_0 => gclass139_0.gclass85_0)).ToList<GClass85>();
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          List<GClass85> list7 = list_4.Where<GClass85>(new Func<GClass85, bool>(class377.class376_0.method_2)).ToList<GClass85>();
          foreach (GEnum116 genum116 in list_3_1)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass2.Class378 class378 = new GClass2.Class378();
            // ISSUE: reference to a compiler-generated field
            class378.class377_0 = class377;
            // ISSUE: reference to a compiler-generated field
            class378.genum116_0 = genum116;
            GClass17 gclass17 = new GClass17();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            gclass17.gclass146_0 = class378.class377_0.class376_0.gclass146_0;
            // ISSUE: reference to a compiler-generated field
            gclass17.genum116_0 = class378.genum116_0;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            gclass17.int_3 = class378.class377_0.class376_0.gclass146_0.gclass6_0.list_0.Where<GClass103>(new Func<GClass103, bool>(class378.method_0)).Except<GClass103>((IEnumerable<GClass103>) class378.class377_0.class376_0.class374_0.list_1).Count<GClass103>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class378.class377_0.list_0.Count > 0)
            {
              // ISSUE: reference to a compiler-generated method
              gclass17.int_4 = list2.Where<GClass103>(new Func<GClass103, bool>(class378.method_1)).Count<GClass103>();
            }
            if (list7.Count > 0)
            {
              // ISSUE: reference to a compiler-generated method
              gclass17.int_4 += list7.SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>((Func<GClass139, bool>) (gclass139_0 => gclass139_0.gclass133_0.genum123_0 == GEnum123.const_23)).Select<GClass139, IEnumerable<GClass103>>(new Func<GClass139, IEnumerable<GClass103>>(class378.method_2)).Count<IEnumerable<GClass103>>();
            }
            gclass17.int_0 = gclass17.int_3 + gclass17.int_4;
            // ISSUE: reference to a compiler-generated method
            GClass16 gclass16 = gclass16List.FirstOrDefault<GClass16>(new Func<GClass16, bool>(class378.method_3));
            if (gclass16 != null)
            {
              gclass17.int_5 = gclass16.int_2;
              gclass17.int_1 = gclass16.int_0;
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class378.class377_0.class376_0.gclass146_0.gclass1_0.auroraGroundMineralSurvey_0 != AuroraGroundMineralSurvey.Completed && class378.genum116_0 == GEnum116.const_12)
              gclass17.int_1 = 1;
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
            if (class378.class377_0.class376_0.gclass146_0.gclass1_0.int_10 > 0 && class378.genum116_0 == GEnum116.const_13 && !class378.class377_0.class376_0.gclass146_0.gclass21_0.list_2.Contains(class378.class377_0.class376_0.gclass146_0.gclass1_0.gclass171_0.int_0))
              gclass17.int_1 = 1;
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
            if (class378.class377_0.class376_0.gclass146_0.gclass1_0.int_10 > 0 && class378.genum116_0 == GEnum116.const_14 && class378.class377_0.class376_0.gclass146_0.gclass21_0.list_2.Contains(class378.class377_0.class376_0.gclass146_0.gclass1_0.gclass171_0.int_0))
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              gclass17.int_1 = class378.class377_0.class376_0.gclass146_0.gclass1_0.int_10 >= 25 ? (int) Math.Floor((double) class378.class377_0.class376_0.gclass146_0.gclass1_0.int_10 / 25.0) : 1;
            }
            if (gclass17.int_1 > 0)
            {
              gclass17.int_2 = gclass17.int_1 - gclass17.int_0;
              gclass17.int_6 = gclass17.int_3 - gclass17.int_1;
              if (gclass17.int_2 < 0)
                gclass17.int_2 = 0;
              if (gclass17.int_6 < 0)
                gclass17.int_6 = 0;
            }
            else
              gclass17.int_6 = gclass17.int_3;
            if (gclass17.int_6 > 0 || gclass17.int_2 > 0)
              this.list_0.Add(gclass17);
          }
        }
      }
      List<GClass146> list8 = this.list_0.Where<GClass17>((Func<GClass17, bool>) (gclass17_0 => gclass17_0.int_2 > 0)).Select<GClass17, GClass146>((Func<GClass17, GClass146>) (gclass17_0 => gclass17_0.gclass146_0)).OrderByDescending<GClass146, bool>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.bool_6)).ThenByDescending<GClass146, GEnum97>((Func<GClass146, GEnum97>) (gclass146_0 => gclass146_0.gclass6_0.genum97_0)).ThenBy<GClass146, int>((Func<GClass146, int>) (gclass146_0 => gclass146_0.int_6)).ToList<GClass146>();
      if (list8.Count == 0)
        return;
      List<GClass146> list9 = this.list_0.Where<GClass17>((Func<GClass17, bool>) (gclass17_0 => gclass17_0.int_6 > 0)).Select<GClass17, GClass146>((Func<GClass17, GClass146>) (gclass17_0 => gclass17_0.gclass146_0)).Distinct<GClass146>().ToList<GClass146>();
      List<GClass103> list10 = list2.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass40_0.gclass85_0.dictionary_0.Count == 0)).ToList<GClass103>();
      if (list9.Count == 0 && list10.Count == 0)
        return;
      foreach (GClass146 gclass146_5 in list8)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class380 class380 = new GClass2.Class380();
        // ISSUE: reference to a compiler-generated field
        class380.class374_0 = class374;
        // ISSUE: reference to a compiler-generated field
        class380.gclass146_0 = gclass146_5;
        // ISSUE: reference to a compiler-generated method
        foreach (GClass17 gclass17 in this.list_0.Where<GClass17>(new Func<GClass17, bool>(class380.method_0)).OrderBy<GClass17, int>((Func<GClass17, int>) (gclass17_0 => gclass17_0.int_5)).ToList<GClass17>())
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass2.Class381 class381 = new GClass2.Class381();
          // ISSUE: reference to a compiler-generated field
          class381.class380_0 = class380;
          // ISSUE: reference to a compiler-generated field
          class381.gclass17_0 = gclass17;
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          foreach (GClass85 gclass85 in list10.Where<GClass103>(new Func<GClass103, bool>(class381.method_0)).Select<GClass103, GClass85>((Func<GClass103, GClass85>) (gclass103_0 => gclass103_0.gclass40_0.gclass85_0)).Distinct<GClass85>().OrderBy<GClass85, int>(new Func<GClass85, int>(class381.method_1)).ToList<GClass85>())
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass2.Class382 class382 = new GClass2.Class382();
            // ISSUE: reference to a compiler-generated field
            class382.class381_0 = class381;
            // ISSUE: reference to a compiler-generated field
            class382.gclass85_0 = gclass85;
            // ISSUE: reference to a compiler-generated method
            int num7 = list10.Count<GClass103>(new Func<GClass103, bool>(class382.method_0));
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class382.gclass85_0.gclass202_0 == class382.class381_0.class380_0.gclass146_0.gclass202_0)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              this.method_30(class382.gclass85_0, class382.class381_0.gclass17_0);
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              class382.class381_0.gclass17_0.int_2 -= num7;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (class382.gclass85_0.gclass21_0.genum6_0 == GEnum6.const_5)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class382.gclass85_0.gclass202_0 == gclass146_1.gclass202_0 && class382.gclass85_0.decimal_0 < this.gclass0_0.decimal_0 - GClass226.decimal_32)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  GClass210 gclass210_0 = class382.class381_0.class380_0.gclass146_0.gclass202_0.gclass200_0.method_2() ?? this.method_2(class382.class381_0.class380_0.gclass146_0.gclass202_0.gclass200_0);
                  if (gclass210_0.double_2 == 0.0)
                  {
                    // ISSUE: reference to a compiler-generated field
                    class382.gclass85_0.method_64(gclass210_0, false);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.method_30(class382.gclass85_0, class382.class381_0.gclass17_0);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class382.class381_0.gclass17_0.int_2 -= num7;
                  }
                }
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class382.gclass85_0.method_237(class382.gclass85_0.gclass202_0, GEnum109.const_41, "Move To " + class382.class381_0.gclass17_0.gclass146_0.gclass202_0.Name, false, class382.class381_0.gclass17_0.gclass146_0.gclass202_0.gclass200_0.int_0, false, false, false).gclass202_0 != null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  this.method_30(class382.gclass85_0, class382.class381_0.gclass17_0);
                }
              }
            }
          }
          list10 = list10.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass40_0.gclass85_0.dictionary_0.Count == 0)).ToList<GClass103>();
          // ISSUE: reference to a compiler-generated field
          if (class381.gclass17_0.int_2 >= 1)
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            List<GClass17> list11 = this.list_0.Where<GClass17>(new Func<GClass17, bool>(class381.method_2)).OrderBy<GClass17, int>(new Func<GClass17, int>(class381.method_3)).ToList<GClass17>();
            if (list11.Count != 0)
            {
              foreach (GClass17 gclass17_1 in list11)
              {
                bool flag2 = false;
                int int_0 = gclass17_1.int_6;
                // ISSUE: reference to a compiler-generated field
                if (class381.gclass17_0.int_2 < int_0)
                {
                  // ISSUE: reference to a compiler-generated field
                  int_0 = class381.gclass17_0.int_2;
                }
                foreach (GClass85 gclass85_0 in list4)
                {
                  GClass201 gclass201 = new GClass201();
                  if (gclass85_0.gclass202_0 == gclass17_1.gclass146_0.gclass202_0)
                    gclass201.gclass202_0 = gclass85_0.gclass202_0;
                  else if (gclass85_0.gclass21_0.genum6_0 != GEnum6.const_5)
                    gclass201 = gclass85_0.method_236(GEnum109.const_41, "Move To " + gclass17_1.gclass146_0.gclass202_0.Name, false, gclass17_1.gclass146_0.gclass202_0.gclass200_0.int_0, false);
                  if (gclass201.gclass202_0 != null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    this.method_29(gclass85_0, class381.gclass17_0, gclass17_1, int_0, list_4);
                  }
                  if (gclass85_0.gclass4_0.bool_1)
                  {
                    // ISSUE: reference to a compiler-generated field
                    if (class381.gclass17_0.gclass146_0.gclass202_0 == gclass201.gclass202_0)
                    {
                      // ISSUE: reference to a compiler-generated field
                      this.method_30(gclass85_0, class381.gclass17_0);
                    }
                    else
                    {
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      if (gclass85_0.method_237(gclass201.gclass202_0, GEnum109.const_41, "Move To " + class381.gclass17_0.gclass146_0.gclass202_0.Name, false, class381.gclass17_0.gclass146_0.gclass202_0.gclass200_0.int_0, false, false, false).gclass202_0 != null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        this.method_30(gclass85_0, class381.gclass17_0);
                      }
                      else
                        gclass85_0.method_263();
                    }
                  }
                  if (gclass85_0.gclass4_0.bool_1)
                  {
                    flag2 = true;
                    break;
                  }
                }
                list4 = list4.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1 && gclass85_0.dictionary_0.Count == 0)).ToList<GClass85>();
                if (flag2)
                  break;
              }
              list_5 = list_5.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1 && gclass85_0.dictionary_0.Count == 0)).ToList<GClass85>();
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 24);
    }
  }

  public void method_28(
    GEnum116 genum116_0,
    int int_0,
    List<GEnum116> list_3,
    List<GClass16> list_4)
  {
    try
    {
      if (int_0 == 0)
        return;
      GClass16 gclass16 = new GClass16(genum116_0, int_0);
      list_4.Add(gclass16);
      list_3.Add(genum116_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 25);
    }
  }

  public bool method_29(
    GClass85 gclass85_0_1,
    GClass17 gclass17_0,
    GClass17 gclass17_1,
    int int_0,
    List<GClass85> list_3)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class383 class383 = new GClass2.Class383();
    // ISSUE: reference to a compiler-generated field
    class383.gclass17_0 = gclass17_0;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass2.Class384 class384 = new GClass2.Class384();
      Decimal num = (Decimal) gclass85_0_1.method_143();
      GClass134 gclass134_0 = gclass85_0_1.method_274(gclass17_1.gclass146_0);
      GClass133 gclass133_0_1 = this.gclass0_0.dictionary_19[GEnum123.const_23];
      GClass133 gclass133_0_2 = this.gclass0_0.dictionary_19[GEnum123.const_6];
      // ISSUE: reference to a compiler-generated field
      class384.list_0 = list_3.SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0_2 => (IEnumerable<GClass139>) gclass85_0_2.dictionary_0.Values)).Where<GClass139>((Func<GClass139, bool>) (gclass139_0 => gclass139_0.gclass133_0.genum123_0 == GEnum123.const_23)).ToList<GClass139>();
      // ISSUE: reference to a compiler-generated method
      List<GClass103> list1 = this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(class384.method_0)).ToList<GClass103>();
      // ISSUE: reference to a compiler-generated method
      List<GClass103> list2 = gclass17_1.gclass146_0.gclass6_0.list_0.Where<GClass103>(new Func<GClass103, bool>(class383.method_0)).Except<GClass103>((IEnumerable<GClass103>) list1).OrderByDescending<GClass103, Decimal>((Func<GClass103, Decimal>) (gclass103_0 => gclass103_0.method_34())).ToList<GClass103>();
      if (list2.Count == 0)
        return false;
      foreach (GClass103 object_0 in list2)
      {
        if (object_0.decimal_0 <= num)
        {
          gclass85_0_1.method_264(gclass134_0, gclass133_0_1, (object) object_0, 0M, 0.0, 0, 0, 0, false, CheckState.Checked);
          gclass85_0_1.gclass4_0.bool_1 = true;
          --int_0;
          if (int_0 != 0)
            num -= object_0.decimal_0;
          else
            break;
        }
      }
      gclass85_0_1.method_264(gclass134_0, gclass133_0_2, (object) null, 0M, 0.0, 0, 0, 0, false, CheckState.Unchecked);
      return gclass85_0_1.gclass4_0.bool_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 26);
      return false;
    }
  }

  public void method_30(GClass85 gclass85_0, GClass17 gclass17_0)
  {
    try
    {
      Decimal num = (Decimal) gclass85_0.method_143();
      GClass134 gclass134_0 = gclass85_0.method_274(gclass17_0.gclass146_0);
      GClass133 gclass133_0_1 = this.gclass0_0.dictionary_19[GEnum123.const_93];
      GClass133 gclass133_0_2 = this.gclass0_0.dictionary_19[GEnum123.const_6];
      gclass85_0.method_264(gclass134_0, gclass133_0_1, (object) null, 0M, 0.0, 0, 0, 0, false, CheckState.Checked);
      gclass85_0.method_264(gclass134_0, gclass133_0_2, (object) null, 0M, 0.0, 0, 0, 0, false, CheckState.Checked);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 27);
    }
  }

  public void method_31(List<GClass85> list_3, List<GClass146> list_4, List<GClass146> list_5)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass2.Class385 class385 = new GClass2.Class385();
      // ISSUE: reference to a compiler-generated field
      class385.gclass2_0 = this;
      List<GClass85> list1 = list_3.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass4_0.genum102_0 < GEnum102.const_2 && !gclass85_0.gclass4_0.bool_1)).OrderBy<GClass85, GEnum102>((Func<GClass85, GEnum102>) (gclass85_0 => gclass85_0.gclass4_0.genum102_0)).ToList<GClass85>();
      if (list1.Count == 0)
        return;
      // ISSUE: reference to a compiler-generated field
      class385.list_0 = list_5.Select<GClass146, GClass1>((Func<GClass146, GClass1>) (gclass146_0 => gclass146_0.gclass1_0)).Distinct<GClass1>().ToList<GClass1>();
      List<GClass85> list2 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum105_0 == GEnum105.const_83 || gclass85_0.gclass9_0.genum105_0 == GEnum105.const_84)).ToList<GClass85>();
      if (list2.Count > 0)
      {
        List<GClass132> list3 = this.gclass0_0.dictionary_6.Values.Where<GClass132>((Func<GClass132, bool>) (gclass132_0 => gclass132_0.gclass21_0 == this.gclass21_0 && gclass132_0.gclass129_0.decimal_8 > 0M && gclass132_0.gclass40_0 != null)).ToList<GClass132>();
        foreach (GClass85 gclass85_0 in list2)
          this.method_34(gclass85_0, list3);
        list1 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
      }
      // ISSUE: reference to a compiler-generated method
      List<GClass193> list4 = this.gclass0_0.dictionary_31.Values.Where<GClass193>((Func<GClass193, bool>) (gclass193_0 => gclass193_0.gclass21_0 == this.gclass21_0 && gclass193_0.gclass146_0 != null)).ToList<GClass193>().Where<GClass193>(new Func<GClass193, bool>(class385.method_0)).ToList<GClass193>();
      if (list4.Count == 0)
        return;
      foreach (GClass85 gclass85 in list1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class386 class386 = new GClass2.Class386();
        // ISSUE: reference to a compiler-generated field
        class386.class385_0 = class385;
        // ISSUE: reference to a compiler-generated field
        class386.gclass85_0 = gclass85;
        // ISSUE: reference to a compiler-generated field
        List<GClass40> source = class386.gclass85_0.method_176();
        if (source.Count != 0)
        {
          GClass40 gclass40 = source.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass5_0.genum102_0 < GEnum102.const_3)).OrderByDescending<GClass40, Decimal>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14)).FirstOrDefault<GClass40>();
          if (gclass40 != null)
          {
            this.decimal_4 = gclass40.gclass22_0.decimal_14;
            this.auroraShipyardType_0 = AuroraShipyardType.Naval;
            if (gclass40.gclass22_0.bool_2)
              this.auroraShipyardType_0 = AuroraShipyardType.Commercial;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            GClass146 gclass146_1 = list4.Where<GClass193>(new Func<GClass193, bool>(class386.method_0)).Select<GClass193, GClass146>((Func<GClass193, GClass146>) (gclass193_0 => gclass193_0.gclass146_0)).OrderBy<GClass146, double>(new Func<GClass146, double>(class386.method_1)).FirstOrDefault<GClass146>();
            if (gclass146_1 != null)
            {
              // ISSUE: reference to a compiler-generated field
              class386.gclass85_0.method_263();
              // ISSUE: reference to a compiler-generated field
              class386.gclass85_0.method_219(gclass146_1, GEnum123.const_96);
              // ISSUE: reference to a compiler-generated field
              class386.gclass85_0.gclass4_0.bool_1 = true;
              break;
            }
            // ISSUE: reference to a compiler-generated field
            GClass201 gclass201 = class386.gclass85_0.method_235(GEnum109.const_45, "Move to Shipyard Colony", false);
            if (gclass201.gclass146_0 == null)
              break;
            // ISSUE: reference to a compiler-generated field
            class386.gclass85_0.method_219(gclass201.gclass146_0, GEnum123.const_96);
            // ISSUE: reference to a compiler-generated field
            class386.gclass85_0.gclass4_0.bool_1 = true;
            break;
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 28);
    }
  }

  public void method_32(List<GClass85> list_3, List<GClass146> list_4, List<GClass146> list_5)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass2.Class387 class387 = new GClass2.Class387();
      List<GClass85> list1 = list_3.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass4_0.genum101_0 != GEnum101.const_3 && !gclass85_0.gclass4_0.bool_1 && gclass85_0.gclass187_0 == null)).OrderBy<GClass85, GEnum101>((Func<GClass85, GEnum101>) (gclass85_0 => gclass85_0.gclass4_0.genum101_0)).ToList<GClass85>();
      if (list1.Count == 0)
        return;
      // ISSUE: reference to a compiler-generated field
      class387.list_0 = list_5.Select<GClass146, GClass1>((Func<GClass146, GClass1>) (gclass146_0 => gclass146_0.gclass1_0)).Distinct<GClass1>().ToList<GClass1>();
      List<GClass85> list2 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum105_0 == GEnum105.const_83 || gclass85_0.gclass9_0.genum105_0 == GEnum105.const_84)).ToList<GClass85>();
      if (list2.Count > 0)
      {
        List<GClass132> list3 = this.gclass0_0.dictionary_6.Values.Where<GClass132>((Func<GClass132, bool>) (gclass132_0 => gclass132_0.gclass21_0 == this.gclass21_0 && gclass132_0.gclass129_0.decimal_8 > 0M && gclass132_0.gclass40_0 != null)).ToList<GClass132>();
        foreach (GClass85 gclass85_0 in list2)
          this.method_34(gclass85_0, list3);
        list1 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
      }
      // ISSUE: reference to a compiler-generated method
      List<GClass146> list4 = list_4.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.method_62(AuroraProductionCategory.RefuellingPoint) > 0M && gclass146_0.decimal_3 > 0M)).ToList<GClass146>().Where<GClass146>(new Func<GClass146, bool>(class387.method_0)).ToList<GClass146>();
      if (list4.Count == 0)
        return;
      foreach (GClass146 gclass146 in list4)
        gclass146.gclass6_0.decimal_0 = gclass146.decimal_3;
      using (List<GClass85>.Enumerator enumerator = list1.GetEnumerator())
      {
        if (!enumerator.MoveNext())
          return;
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class389 class389 = new GClass2.Class389()
        {
          class388_0 = new GClass2.Class388()
          {
            gclass85_0 = enumerator.Current
          }
        };
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        class389.decimal_0 = (Decimal) class389.class388_0.gclass85_0.method_140() - class389.class388_0.gclass85_0.method_154();
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        GClass146 gclass146_1 = list4.Where<GClass146>(new Func<GClass146, bool>(class389.method_0)).OrderBy<GClass146, double>(new Func<GClass146, double>(class389.class388_0.method_0)).FirstOrDefault<GClass146>();
        if (gclass146_1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class389.class388_0.gclass85_0.method_263();
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class389.class388_0.gclass85_0.method_219(gclass146_1, GEnum123.const_96);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class389.class388_0.gclass85_0.gclass4_0.bool_1 = true;
          // ISSUE: reference to a compiler-generated field
          gclass146_1.gclass6_0.decimal_0 -= class389.decimal_0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          this.gclass21_0.gclass2_0.decimal_0 = class389.decimal_0;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          GClass201 gclass201 = class389.class388_0.gclass85_0.method_235(GEnum109.const_43, "Refuel from Colony", false);
          if (gclass201.gclass146_0 == null)
            return;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class389.class388_0.gclass85_0.method_219(gclass201.gclass146_0, GEnum123.const_96);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class389.class388_0.gclass85_0.gclass4_0.bool_1 = true;
          // ISSUE: reference to a compiler-generated field
          gclass201.gclass146_0.gclass6_0.decimal_0 -= class389.decimal_0;
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 29);
    }
  }

  public void method_33(List<GClass85> list_3, GEnum123 genum123_0)
  {
    try
    {
      foreach (GClass85 gclass85 in list_3)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class390 class390 = new GClass2.Class390();
        // ISSUE: reference to a compiler-generated field
        class390.gclass85_0 = gclass85;
        // ISSUE: reference to a compiler-generated method
        GClass210 gclass210_0 = this.gclass0_0.dictionary_16.Values.Where<GClass210>(new Func<GClass210, bool>(class390.method_0)).FirstOrDefault<GClass210>();
        if (gclass210_0.double_2 <= 0.0)
        {
          // ISSUE: reference to a compiler-generated field
          class390.gclass85_0.method_263();
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class390.gclass85_0.method_232(gclass210_0, genum123_0, class390.gclass85_0.gclass202_0);
          // ISSUE: reference to a compiler-generated field
          class390.gclass85_0.gclass4_0.bool_1 = true;
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3411);
    }
  }

  public void method_34(GClass85 gclass85_0, List<GClass132> list_3)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class391 class391 = new GClass2.Class391();
    // ISSUE: reference to a compiler-generated field
    class391.gclass85_0 = gclass85_0;
    // ISSUE: reference to a compiler-generated field
    class391.gclass2_0 = this;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass2.Class392 class392 = new GClass2.Class392();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      class392.list_0 = class391.gclass85_0.method_176();
      // ISSUE: reference to a compiler-generated field
      if (class392.list_0.Count == 0)
        return;
      GEnum123 genum123_0 = GEnum123.const_14;
      // ISSUE: reference to a compiler-generated method
      if (list_3.FirstOrDefault<GClass132>(new Func<GClass132, bool>(class392.method_0)) != null)
        genum123_0 = GEnum123.const_1;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      List<GClass40> list1 = class392.list_0.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass40_1 != null)).Select<GClass40, GClass40>((Func<GClass40, GClass40>) (gclass40_0 => gclass40_0.gclass40_1)).Distinct<GClass40>().Where<GClass40>(new Func<GClass40, bool>(class391.method_0)).ToList<GClass40>();
      int num1 = list1.Select<GClass40, GClass85>((Func<GClass40, GClass85>) (gclass40_0 => gclass40_0.gclass85_0)).Distinct<GClass85>().Count<GClass85>();
      if (list1.Count != 1 && num1 != 1)
      {
        if (list1.Count > 1 && num1 > 1)
        {
          foreach (GClass40 gclass40_1 in list1)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass2.Class393 class393 = new GClass2.Class393();
            // ISSUE: reference to a compiler-generated field
            class393.gclass40_0 = gclass40_1;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            List<GClass40> list2 = class392.list_0.Where<GClass40>(new Func<GClass40, bool>(class393.method_0)).ToList<GClass40>();
            if (list2.Count > 0)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              GClass85 gclass85_1 = this.gclass21_0.method_308(class393.gclass40_0.ShipName + " Strikegroup", class393.gclass40_0.gclass85_0.gclass83_0, class391.gclass85_0.gclass202_0, class391.gclass85_0.double_2, class391.gclass85_0.double_3, class391.gclass85_0.gclass1_0, class391.gclass85_0.gclass9_0.genum105_0);
              foreach (GClass40 gclass40_2 in list2)
              {
                if (gclass40_2.gclass70_0 != null)
                {
                  gclass40_2.int_22 = gclass40_2.gclass70_0.int_0;
                  gclass40_2.gclass70_0 = (GClass70) null;
                }
                gclass40_2.gclass84_0 = (GClass84) null;
                gclass40_2.method_185(gclass85_1, true, false, false, false);
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              class391.gclass85_0.method_222(class393.gclass40_0.gclass85_0, genum123_0);
              // ISSUE: reference to a compiler-generated field
              class391.gclass85_0.gclass4_0.bool_1 = true;
            }
          }
        }
        // ISSUE: reference to a compiler-generated field
        if (class392.list_0.Count == 0)
        {
          // ISSUE: reference to a compiler-generated field
          this.gclass21_0.method_302(class391.gclass85_0, false);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          foreach (GClass40 gclass40 in class392.list_0)
            gclass40.gclass40_1 = (GClass40) null;
          // ISSUE: reference to a compiler-generated method
          List<GClass40> list3 = this.gclass0_0.dictionary_4.Values.Where<GClass40>(new Func<GClass40, bool>(class391.method_1)).Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.auroraClassMainFunction_0 == AuroraClassMainFunction.Carrier)).ToList<GClass40>();
          // ISSUE: reference to a compiler-generated field
          if (class391.gclass85_0.gclass9_0.genum105_0 == GEnum105.const_84)
          {
            list3 = list3.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.decimal_11 == 0M)).ToList<GClass40>();
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (class391.gclass85_0.gclass9_0.genum105_0 == GEnum105.const_83)
              list3 = list3.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.decimal_11 > 0M)).ToList<GClass40>();
          }
          if (list3.Count == 0)
            return;
          // ISSUE: reference to a compiler-generated method
          List<GClass40> list4 = list3.OrderBy<GClass40, double>(new Func<GClass40, double>(class391.method_2)).ToList<GClass40>();
          // ISSUE: reference to a compiler-generated field
          class392.list_0.Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14));
          foreach (GClass40 gclass40_3 in list4)
          {
            // ISSUE: reference to a compiler-generated field
            class392.list_0.OrderBy<GClass40, Decimal>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14)).ToList<GClass40>();
            Decimal num2 = gclass40_3.method_126();
            List<GClass40> gclass40List = new List<GClass40>();
            // ISSUE: reference to a compiler-generated field
            foreach (GClass40 gclass40_4 in class392.list_0)
            {
              if (num2 >= gclass40_4.gclass22_0.decimal_14)
              {
                gclass40List.Add(gclass40_4);
                // ISSUE: reference to a compiler-generated field
                class392.list_0.Remove(gclass40_4);
                num2 -= gclass40_4.gclass22_0.decimal_14;
              }
              else
                break;
            }
            if (gclass40List.Count > 0)
            {
              GClass70 gclass70_1 = new GClass70(this.gclass0_0);
              GClass70 gclass70_2 = gclass40_3.dictionary_0.Count <= 0 ? gclass40_3.method_186(gclass40_3.ShipName + " strikegroup") : gclass40_3.dictionary_0[0];
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              GClass85 gclass85_1 = this.gclass21_0.method_308(gclass40_3.ShipName + " Strikegroup", gclass40_3.gclass85_0.gclass83_0, class391.gclass85_0.gclass202_0, class391.gclass85_0.double_2, class391.gclass85_0.double_3, class391.gclass85_0.gclass1_0, class391.gclass85_0.gclass9_0.genum105_0);
              foreach (GClass40 gclass40_5 in gclass40List)
              {
                gclass40_5.int_22 = gclass70_2.int_0;
                gclass40_5.gclass70_0 = (GClass70) null;
                gclass40_5.gclass84_0 = (GClass84) null;
                gclass40_5.method_185(gclass85_1, true, false, false, false);
              }
              gclass85_1.method_222(gclass40_3.gclass85_0, genum123_0);
              gclass85_1.gclass4_0.bool_1 = true;
            }
          }
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        class391.gclass85_0.method_263();
        // ISSUE: reference to a compiler-generated field
        class391.gclass85_0.method_222(list1[0].gclass85_0, genum123_0);
        // ISSUE: reference to a compiler-generated field
        class391.gclass85_0.gclass4_0.bool_1 = true;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3858);
    }
  }

  public void method_35(
    List<GClass85> list_3,
    List<GClass146> list_4,
    List<GClass146> list_5,
    bool bool_0)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass2.Class394 class394 = new GClass2.Class394();
      List<GClass85> list1 = list_3.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass4_0.genum103_0 < GEnum103.const_3 && !gclass85_0.gclass4_0.bool_1)).OrderBy<GClass85, GEnum103>((Func<GClass85, GEnum103>) (gclass85_0 => gclass85_0.gclass4_0.genum103_0)).ToList<GClass85>();
      if (list1.Count == 0)
        return;
      // ISSUE: reference to a compiler-generated field
      class394.list_0 = list_5.Select<GClass146, GClass1>((Func<GClass146, GClass1>) (gclass146_0 => gclass146_0.gclass1_0)).Distinct<GClass1>().ToList<GClass1>();
      if (this.gclass21_0.genum6_0 == GEnum6.const_5)
      {
        this.method_33(list1, GEnum123.const_0);
      }
      else
      {
        List<GClass85> list2 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum105_0 == GEnum105.const_83)).ToList<GClass85>();
        if (list2.Count > 0)
        {
          List<GClass132> list3 = this.gclass0_0.dictionary_6.Values.Where<GClass132>((Func<GClass132, bool>) (gclass132_0 => gclass132_0.gclass21_0 == this.gclass21_0 && gclass132_0.gclass129_0.decimal_8 > 0M && gclass132_0.gclass40_0 != null)).ToList<GClass132>();
          foreach (GClass85 gclass85_0 in list2)
            this.method_34(gclass85_0, list3);
          list1 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
        }
        // ISSUE: reference to a compiler-generated method
        List<GClass146> list4 = list_4.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.method_62(AuroraProductionCategory.OrdnanceTransferPoint) > 0M && gclass146_0.list_1.Count > 0)).ToList<GClass146>().Where<GClass146>(new Func<GClass146, bool>(class394.method_0)).ToList<GClass146>();
        if (list4.Count == 0)
          return;
        foreach (GClass146 gclass146 in list4)
        {
          gclass146.gclass6_0.dictionary_0.Clear();
          foreach (GClass130 gclass130_1 in gclass146.list_1)
          {
            GClass130 gclass130_2 = gclass130_1.method_0();
            gclass146.gclass6_0.dictionary_0.Add(gclass130_2.gclass129_0, gclass130_2);
          }
        }
        foreach (GClass85 gclass85 in list1)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass2.Class395 class395 = new GClass2.Class395();
          // ISSUE: reference to a compiler-generated field
          class395.gclass85_0 = gclass85;
          List<GClass130> source1 = new List<GClass130>();
          // ISSUE: reference to a compiler-generated field
          List<GClass40> source2 = class395.gclass85_0.method_176();
          // ISSUE: reference to a compiler-generated method
          foreach (GClass129 gclass129 in source2.Where<GClass40>(new Func<GClass40, bool>(class395.method_0)).SelectMany<GClass40, GClass130>((Func<GClass40, IEnumerable<GClass130>>) (gclass40_0 => (IEnumerable<GClass130>) gclass40_0.gclass22_0.list_0)).Select<GClass130, GClass129>((Func<GClass130, GClass129>) (gclass130_0 => gclass130_0.gclass129_0)).Distinct<GClass129>().ToList<GClass129>())
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass2.Class396 class396 = new GClass2.Class396();
            // ISSUE: reference to a compiler-generated field
            class396.gclass129_0 = gclass129;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            source1.Add(new GClass130()
            {
              gclass129_0 = class396.gclass129_0,
              int_0 = source2.Where<GClass40>(class395.func_0 ?? (class395.func_0 = new Func<GClass40, bool>(class395.method_1))).SelectMany<GClass40, GClass130>((Func<GClass40, IEnumerable<GClass130>>) (gclass40_0 => (IEnumerable<GClass130>) gclass40_0.gclass22_0.list_0)).Where<GClass130>(new Func<GClass130, bool>(class396.method_0)).Sum<GClass130>((Func<GClass130, int>) (gclass130_0 => gclass130_0.int_0)) - source2.Where<GClass40>(class395.func_1 ?? (class395.func_1 = new Func<GClass40, bool>(class395.method_2))).SelectMany<GClass40, GClass130>((Func<GClass40, IEnumerable<GClass130>>) (gclass40_0 => (IEnumerable<GClass130>) gclass40_0.list_10)).Where<GClass130>(new Func<GClass130, bool>(class396.method_1)).Sum<GClass130>((Func<GClass130, int>) (gclass130_0 => gclass130_0.int_0))
            });
          }
          List<GClass130> list5 = source1.Where<GClass130>((Func<GClass130, bool>) (gclass130_0 => gclass130_0.int_0 > 0)).OrderByDescending<GClass130, int>((Func<GClass130, int>) (gclass130_0 => gclass130_0.int_0)).ToList<GClass130>();
          if (list5.Count != 0)
          {
            foreach (GClass130 gclass130 in list5)
            {
              // ISSUE: object of a compiler-generated type is created
              // ISSUE: variable of a compiler-generated type
              GClass2.Class397 class397 = new GClass2.Class397();
              // ISSUE: reference to a compiler-generated field
              class397.class395_0 = class395;
              // ISSUE: reference to a compiler-generated field
              class397.gclass130_0 = gclass130;
              GClass146 gclass146_1;
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (class397.class395_0.gclass85_0.gclass9_0.genum105_0 != GEnum105.const_19 && class397.class395_0.gclass85_0.gclass9_0.genum105_0 != GEnum105.const_4)
              {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                gclass146_1 = list4.Where<GClass146>(new Func<GClass146, bool>(class397.method_1)).Where<GClass146>(new Func<GClass146, bool>(class397.method_2)).OrderByDescending<GClass146, int>(new Func<GClass146, int>(class397.method_3)).FirstOrDefault<GClass146>();
              }
              else
              {
                // ISSUE: reference to a compiler-generated method
                gclass146_1 = list4.FirstOrDefault<GClass146>(new Func<GClass146, bool>(class397.method_0));
                if (gclass146_1 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  class397.class395_0.gclass85_0.gclass4_0.bool_1 = true;
                }
              }
              if (gclass146_1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (!class397.class395_0.gclass85_0.gclass4_0.bool_1)
                {
                  if (!bool_0)
                  {
                    this.gclass21_0.gclass2_0.list_1 = list5;
                    this.gclass21_0.gclass2_0.list_2 = list4;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    GClass201 gclass201 = class397.class395_0.gclass85_0.method_235(GEnum109.const_44, "Reload from Colony", false);
                    if (gclass201.gclass146_0 != null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      class397.class395_0.gclass85_0.method_219(gclass201.gclass146_0, GEnum123.const_12);
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      class397.class395_0.gclass85_0.gclass4_0.bool_1 = true;
                      gclass201.gclass146_0.gclass6_0.method_5(list5);
                      break;
                    }
                    break;
                  }
                }
                else
                  break;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class397.class395_0.gclass85_0.method_263();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class397.class395_0.gclass85_0.method_219(gclass146_1, GEnum123.const_12);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class397.class395_0.gclass85_0.gclass4_0.bool_1 = true;
                gclass146_1.gclass6_0.method_5(list5);
                break;
              }
            }
          }
        }
        List<GClass85> list6 = list_3.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass4_0.genum103_0 == GEnum103.const_0 && !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
        if (list6.Count == 0)
          return;
        foreach (GClass85 gclass85 in list6)
        {
          foreach (GClass40 gclass40_0 in gclass85.method_176())
          {
            if (gclass40_0.gclass5_0.genum103_0 == GEnum103.const_0)
              gclass85.method_75(gclass40_0, GEnum105.const_26, true);
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 30);
    }
  }

  public void method_36(List<GClass85> list_3)
  {
    try
    {
      List<GClass202> list1 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_5)).OrderBy<GClass202, int>((Func<GClass202, int>) (gclass202_0 => gclass202_0.gclass200_0.int_0)).ToList<GClass202>();
      List<GClass202> list2 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 != GEnum95.const_5)).OrderBy<GClass202, int>((Func<GClass202, int>) (gclass202_0 => gclass202_0.gclass200_0.int_0)).ToList<GClass202>();
      List<GClass202> list3 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_4)).OrderBy<GClass202, int>((Func<GClass202, int>) (gclass202_0 => gclass202_0.gclass200_0.int_0)).ToList<GClass202>();
      List<GClass202> list4 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 != GEnum95.const_4)).OrderBy<GClass202, int>((Func<GClass202, int>) (gclass202_0 => gclass202_0.gclass200_0.int_0)).ToList<GClass202>();
      List<GClass202> list5 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_3)).OrderBy<GClass202, int>((Func<GClass202, int>) (gclass202_0 => gclass202_0.gclass200_0.int_0)).ToList<GClass202>();
      List<GClass202> list6 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 != GEnum95.const_3)).OrderBy<GClass202, int>((Func<GClass202, int>) (gclass202_0 => gclass202_0.gclass200_0.int_0)).ToList<GClass202>();
      if (list1.Count > 0)
      {
        this.method_43(list1, list2, list_3, GEnum104.const_22, GEnum100.const_2);
        this.method_43(list1, list2, list_3, GEnum104.const_1, GEnum100.const_2);
        this.method_43(list1, list2, list_3, GEnum104.const_21, GEnum100.const_2);
        this.method_43(list1, list2, list_3, GEnum104.const_23, GEnum100.const_2);
      }
      if (list3.Count > 0)
      {
        this.method_43(list3, list4, list_3, GEnum104.const_22, GEnum100.const_2);
        this.method_43(list3, list4, list_3, GEnum104.const_1, GEnum100.const_2);
        this.method_43(list3, list4, list_3, GEnum104.const_21, GEnum100.const_2);
        this.method_43(list3, list4, list_3, GEnum104.const_23, GEnum100.const_2);
      }
      if (list5.Count <= 0)
        return;
      this.method_43(list5, list6, list_3, GEnum104.const_23, GEnum100.const_2);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 31 /*0x1F*/);
    }
  }

  public void method_37(List<GClass85> list_3)
  {
    try
    {
      List<GClass202> list1 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_6)).ToList<GClass202>();
      List<GClass202> list2 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 != GEnum95.const_6)).OrderBy<GClass202, int>((Func<GClass202, int>) (gclass202_0 => gclass202_0.gclass200_0.int_0)).ToList<GClass202>();
      List<GClass202> list3 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_5)).OrderBy<GClass202, int>((Func<GClass202, int>) (gclass202_0 => gclass202_0.gclass200_0.int_0)).ToList<GClass202>();
      List<GClass202> list4 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 != GEnum95.const_5)).OrderBy<GClass202, int>((Func<GClass202, int>) (gclass202_0 => gclass202_0.gclass200_0.int_0)).ToList<GClass202>();
      List<GClass202> list5 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_4)).OrderBy<GClass202, int>((Func<GClass202, int>) (gclass202_0 => gclass202_0.gclass200_0.int_0)).ToList<GClass202>();
      List<GClass202> list6 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 != GEnum95.const_4)).OrderBy<GClass202, int>((Func<GClass202, int>) (gclass202_0 => gclass202_0.gclass200_0.int_0)).ToList<GClass202>();
      List<GClass202> list7 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_3)).OrderBy<GClass202, int>((Func<GClass202, int>) (gclass202_0 => gclass202_0.gclass200_0.int_0)).ToList<GClass202>();
      List<GClass202> list8 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 != GEnum95.const_3)).OrderBy<GClass202, int>((Func<GClass202, int>) (gclass202_0 => gclass202_0.gclass200_0.int_0)).ToList<GClass202>();
      this.method_43(list1, list2, list_3, GEnum104.const_1, GEnum100.const_2);
      this.method_43(list1, list2, list_3, GEnum104.const_6, GEnum100.const_2);
      this.method_43(list1, list2, list_3, GEnum104.const_28, GEnum100.const_2);
      if (list3.Count > 0)
      {
        this.method_43(list3, list4, list_3, GEnum104.const_1, GEnum100.const_2);
        this.method_43(list3, list4, list_3, GEnum104.const_6, GEnum100.const_2);
        this.method_43(list1, list2, list_3, GEnum104.const_28, GEnum100.const_2);
      }
      if (list5.Count > 0)
      {
        this.method_43(list5, list6, list_3, GEnum104.const_1, GEnum100.const_2);
        this.method_43(list5, list6, list_3, GEnum104.const_6, GEnum100.const_2);
        this.method_43(list1, list2, list_3, GEnum104.const_28, GEnum100.const_2);
      }
      if (list7.Count <= 0)
        return;
      this.method_43(list7, list8, list_3, GEnum104.const_6, GEnum100.const_2);
      this.method_43(list1, list2, list_3, GEnum104.const_28, GEnum100.const_2);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 32 /*0x20*/);
    }
  }

  public void method_38(List<GClass85> list_3)
  {
    try
    {
      List<GClass202> list1 = this.gclass0_0.dictionary_13.Values.Where<GClass214>((Func<GClass214, bool>) (gclass214_0 => gclass214_0.wayPointType_0 == WayPointType.UrgentPOI && gclass214_0.gclass21_0 == this.gclass21_0)).Select<GClass214, GClass202>((Func<GClass214, GClass202>) (gclass214_0 => this.gclass21_0.method_128(gclass214_0.gclass200_0))).Distinct<GClass202>().OrderByDescending<GClass202, GEnum95>((Func<GClass202, GEnum95>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0)).ThenBy<GClass202, int>((Func<GClass202, int>) (gclass202_0 => gclass202_0.gclass200_0.int_0)).ToList<GClass202>();
      if (list1.Count > 0)
      {
        List<GClass202> list2 = this.gclass21_0.dictionary_0.Values.Except<GClass202>((IEnumerable<GClass202>) list1).ToList<GClass202>();
        this.method_43(list1, list2, list_3, GEnum104.const_5, GEnum100.const_2);
      }
      List<GClass202> list3 = this.gclass0_0.dictionary_13.Values.Where<GClass214>((Func<GClass214, bool>) (gclass214_0 => gclass214_0.wayPointType_0 == WayPointType.POI && gclass214_0.gclass21_0 == this.gclass21_0)).Select<GClass214, GClass202>((Func<GClass214, GClass202>) (gclass214_0 => this.gclass21_0.method_128(gclass214_0.gclass200_0))).Distinct<GClass202>().OrderByDescending<GClass202, GEnum95>((Func<GClass202, GEnum95>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0)).ThenBy<GClass202, int>((Func<GClass202, int>) (gclass202_0 => gclass202_0.gclass200_0.int_0)).ToList<GClass202>();
      if (list3.Count <= 0)
        return;
      List<GClass202> list4 = this.gclass21_0.dictionary_0.Values.Except<GClass202>((IEnumerable<GClass202>) list3).ToList<GClass202>();
      this.method_43(list3, list4, list_3, GEnum104.const_5, GEnum100.const_2);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 33);
    }
  }

  public void method_39(List<GClass85> list_3)
  {
    try
    {
      List<GClass85> list1 = list_3.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum105_0 == GEnum105.const_44)).ToList<GClass85>();
      if (list1.Count == 0)
        return;
      List<GClass202> list2 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass21_1 == this.gclass21_0 && this.gclass0_0.decimal_0 - gclass65_0.decimal_3 < GClass226.decimal_32)).Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() != 0)).Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_6() != AuroraCommStatus.CommunicationImpossible)).Select<GClass65, GClass200>((Func<GClass65, GClass200>) (gclass65_0 => gclass65_0.gclass200_0)).Distinct<GClass200>().Select<GClass200, GClass202>((Func<GClass200, GClass202>) (gclass200_0 => this.gclass21_0.method_128(gclass200_0))).OrderByDescending<GClass202, GEnum95>((Func<GClass202, GEnum95>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0)).ToList<GClass202>();
      if (list2.Count == 0)
        return;
      List<GClass202> list3 = this.gclass21_0.dictionary_0.Values.Except<GClass202>((IEnumerable<GClass202>) list2).ToList<GClass202>();
      this.method_43(list2, list3, list1, GEnum104.const_25, GEnum100.const_2);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 34);
    }
  }

  public void method_40(List<GClass85> list_3)
  {
    try
    {
      List<GClass202> list1 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => !gclass202_0.bool_1 && gclass202_0.gclass3_0.genum95_0 != 0)).OrderByDescending<GClass202, GEnum95>((Func<GClass202, GEnum95>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0)).ToList<GClass202>();
      if (list1.Count <= 0)
        return;
      List<GClass202> list2 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.bool_1 || gclass202_0.gclass3_0.genum95_0 != 0)).ToList<GClass202>();
      this.method_44(list1, list2, list_3, GEnum104.const_3, GEnum100.const_2, 2);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 35);
    }
  }

  public void method_41(List<GClass85> list_3)
  {
    try
    {
      List<GClass202> list1 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => !gclass202_0.bool_2 && gclass202_0.gclass3_0.genum95_0 != 0)).OrderByDescending<GClass202, GEnum95>((Func<GClass202, GEnum95>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0)).ToList<GClass202>();
      if (list1.Count <= 0)
        return;
      List<GClass202> list2 = this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.bool_2 || gclass202_0.gclass3_0.genum95_0 != 0)).ToList<GClass202>();
      this.method_44(list1, list2, list_3, GEnum104.const_2, GEnum100.const_2, 2);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 36);
    }
  }

  public void method_42(List<GClass85> list_3, GEnum104 genum104_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class398 class398 = new GClass2.Class398();
    // ISSUE: reference to a compiler-generated field
    class398.gclass2_0 = this;
    // ISSUE: reference to a compiler-generated field
    class398.genum104_0 = genum104_0;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass2.Class399 class399 = new GClass2.Class399();
      // ISSUE: reference to a compiler-generated field
      class399.class398_0 = class398;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      List<GClass120> list1 = this.gclass0_0.dictionary_12.Values.Where<GClass120>(new Func<GClass120, bool>(class399.class398_0.method_0)).ToList<GClass120>();
      if (list1.Count == 0)
        return;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      class399.list_0 = this.gclass0_0.dictionary_1.Values.Where<GClass85>(new Func<GClass85, bool>(class399.class398_0.method_1)).SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>((Func<GClass139, bool>) (gclass139_0 => gclass139_0.gclass133_0.genum123_0 == GEnum123.const_0)).Select<GClass139, int>((Func<GClass139, int>) (gclass139_0 => gclass139_0.int_2)).ToList<int>();
      // ISSUE: reference to a compiler-generated method
      List<GClass120> list2 = list1.Where<GClass120>(new Func<GClass120, bool>(class399.method_0)).ToList<GClass120>();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      List<GClass202> list3 = list2.Select<GClass120, GClass202>(new Func<GClass120, GClass202>(class399.class398_0.method_2)).Distinct<GClass202>().OrderByDescending<GClass202, GEnum95>((Func<GClass202, GEnum95>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0)).ToList<GClass202>();
      // ISSUE: reference to a compiler-generated field
      class399.list_1 = this.gclass21_0.dictionary_0.Values.Except<GClass202>((IEnumerable<GClass202>) list3).ToList<GClass202>();
      foreach (GClass202 gclass202 in list3)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class400 class400 = new GClass2.Class400();
        // ISSUE: reference to a compiler-generated field
        class400.class399_0 = class399;
        // ISSUE: reference to a compiler-generated field
        class400.gclass202_0 = gclass202;
        // ISSUE: reference to a compiler-generated method
        foreach (GClass120 gclass120 in list2.Where<GClass120>(new Func<GClass120, bool>(class400.method_0)).ToList<GClass120>())
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass2.Class401 class401 = new GClass2.Class401();
          // ISSUE: reference to a compiler-generated field
          class401.gclass120_0 = gclass120;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          GClass85 gclass85_1 = list_3.Where<GClass85>(class400.func_0 ?? (class400.func_0 = new Func<GClass85, bool>(class400.method_1))).FirstOrDefault<GClass85>(new Func<GClass85, bool>(class401.method_0));
          if (gclass85_1 != null)
          {
            gclass85_1.method_263();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            gclass85_1.method_231(class401.gclass120_0, GEnum123.const_0, class400.gclass202_0);
            gclass85_1.gclass4_0.bool_1 = true;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            foreach (GClass85 gclass85_2 in list_3.Where<GClass85>(class400.class399_0.func_0 ?? (class400.class399_0.func_0 = new Func<GClass85, bool>(class400.class399_0.method_1))).Where<GClass85>(new Func<GClass85, bool>(class401.method_1)).OrderBy<GClass85, int>(class400.func_1 ?? (class400.func_1 = new Func<GClass85, int>(class400.method_2))).ToList<GClass85>())
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (gclass85_2.method_236(GEnum109.const_41, "Move To " + class400.gclass202_0.Name, false, class400.gclass202_0.gclass200_0.int_0, false).gclass202_0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                gclass85_2.method_231(class401.gclass120_0, GEnum123.const_0, class400.gclass202_0);
                gclass85_2.gclass4_0.bool_1 = true;
                break;
              }
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 37);
    }
  }

  public void method_43(
    List<GClass202> list_3,
    List<GClass202> list_4,
    List<GClass85> list_5,
    GEnum104 genum104_0,
    GEnum100 genum100_0)
  {
    try
    {
      this.method_44(list_3, list_4, list_5, genum104_0, genum100_0, 1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 38);
    }
  }

  public void method_44(
    List<GClass202> list_3,
    List<GClass202> list_4,
    List<GClass85> list_5,
    GEnum104 genum104_0,
    GEnum100 genum100_0,
    int int_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class402 class402 = new GClass2.Class402();
    // ISSUE: reference to a compiler-generated field
    class402.genum104_0 = genum104_0;
    // ISSUE: reference to a compiler-generated field
    class402.genum100_0 = genum100_0;
    // ISSUE: reference to a compiler-generated field
    class402.list_0 = list_4;
    // ISSUE: reference to a compiler-generated field
    class402.gclass2_0 = this;
    try
    {
      foreach (GClass202 gclass202 in list_3)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class403 class403 = new GClass2.Class403()
        {
          class402_0 = class402,
          gclass202_0 = gclass202
        };
        // ISSUE: reference to a compiler-generated field
        class403.gclass202_0.gclass3_0.int_2 = int_0;
        // ISSUE: reference to a compiler-generated method
        int num = list_5.Count<GClass85>(new Func<GClass85, bool>(class403.method_0));
        // ISSUE: reference to a compiler-generated field
        class403.gclass202_0.gclass3_0.int_2 -= num;
        // ISSUE: reference to a compiler-generated field
        if (class403.gclass202_0.gclass3_0.int_2 > 0)
        {
          // ISSUE: reference to a compiler-generated method
          List<GClass85> list = list_5.Where<GClass85>(new Func<GClass85, bool>(class403.method_1)).OrderByDescending<GClass85, GEnum100>((Func<GClass85, GEnum100>) (gclass85_0 => gclass85_0.gclass4_0.genum100_0)).ThenByDescending<GClass85, int>((Func<GClass85, int>) (gclass85_0 => gclass85_0.gclass9_0.int_0)).ToList<GClass85>();
          // ISSUE: reference to a compiler-generated field
          if (list.Count >= class403.gclass202_0.gclass3_0.int_2)
          {
            foreach (GClass85 gclass85 in list)
            {
              gclass85.gclass4_0.bool_2 = true;
              gclass85.gclass4_0.method_6();
              // ISSUE: reference to a compiler-generated field
              --class403.gclass202_0.gclass3_0.int_2;
              // ISSUE: reference to a compiler-generated field
              if (class403.gclass202_0.gclass3_0.int_2 == 0)
                break;
            }
            // ISSUE: reference to a compiler-generated field
            if (class403.gclass202_0.gclass3_0.int_2 == 0)
              continue;
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          foreach (GClass85 gclass85 in list_5.Where<GClass85>(class403.class402_0.func_0 ?? (class403.class402_0.func_0 = new Func<GClass85, bool>(class403.class402_0.method_0))).OrderBy<GClass85, int>(new Func<GClass85, int>(class403.method_2)).ThenByDescending<GClass85, GEnum100>((Func<GClass85, GEnum100>) (gclass85_0 => gclass85_0.gclass4_0.genum100_0)).ThenByDescending<GClass85, int>((Func<GClass85, int>) (gclass85_0 => gclass85_0.gclass9_0.int_0)).ToList<GClass85>())
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (gclass85.method_236(GEnum109.const_41, "Move To " + class403.gclass202_0.Name, false, class403.gclass202_0.gclass200_0.int_0, false).gclass202_0 != null)
            {
              gclass85.gclass4_0.bool_1 = true;
              gclass85.gclass4_0.method_6();
              // ISSUE: reference to a compiler-generated field
              gclass85.gclass4_0.gclass202_0 = class403.gclass202_0;
              // ISSUE: reference to a compiler-generated field
              --class403.gclass202_0.gclass3_0.int_2;
              // ISSUE: reference to a compiler-generated field
              if (class403.gclass202_0.gclass3_0.int_2 == 0)
                break;
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 39);
    }
  }

  public bool method_45(GClass202 gclass202_0, Decimal decimal_5, List<GClass85> list_3)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class404 class404 = new GClass2.Class404();
    // ISSUE: reference to a compiler-generated field
    class404.gclass202_0 = gclass202_0;
    // ISSUE: reference to a compiler-generated field
    class404.decimal_0 = decimal_5;
    // ISSUE: reference to a compiler-generated field
    class404.gclass2_0 = this;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (list_3.Where<GClass85>(new Func<GClass85, bool>(class404.method_0)).FirstOrDefault<GClass85>(new Func<GClass85, bool>(class404.method_1)) != null)
        return true;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (GClass85 gclass85 in list_3.Where<GClass85>(new Func<GClass85, bool>(class404.method_2)).Where<GClass85>(new Func<GClass85, bool>(class404.method_3)).OrderBy<GClass85, int>(new Func<GClass85, int>(class404.method_4)).ThenBy<GClass85, Decimal>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.method_13())).ToList<GClass85>())
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (gclass85.method_236(GEnum109.const_41, "Move To " + class404.gclass202_0.Name, false, class404.gclass202_0.gclass200_0.int_0, false).gclass202_0 != null)
        {
          gclass85.gclass4_0.bool_1 = true;
          gclass85.gclass4_0.method_6();
          // ISSUE: reference to a compiler-generated field
          gclass85.gclass4_0.gclass202_0 = class404.gclass202_0;
          return true;
        }
      }
      return false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 40);
      return false;
    }
  }

  public void method_46(
    List<GClass202> list_3,
    List<GClass202> list_4,
    List<GClass202> list_5,
    List<GClass85> list_6,
    GEnum104 genum104_0,
    bool bool_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class405 class405 = new GClass2.Class405();
    // ISSUE: reference to a compiler-generated field
    class405.genum104_0 = genum104_0;
    // ISSUE: reference to a compiler-generated field
    class405.list_0 = list_5;
    // ISSUE: reference to a compiler-generated field
    class405.gclass2_0 = this;
    try
    {
      foreach (GClass202 gclass202 in list_3)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class406 class406 = new GClass2.Class406();
        // ISSUE: reference to a compiler-generated field
        class406.class405_0 = class405;
        // ISSUE: reference to a compiler-generated field
        class406.gclass202_0 = gclass202;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        List<GClass120> source = bool_0 ? this.gclass0_0.dictionary_13.Values.Where<GClass214>(new Func<GClass214, bool>(class406.method_1)).Select<GClass214, GClass120>((Func<GClass214, GClass120>) (gclass214_0 => gclass214_0.gclass120_0)).ToList<GClass120>() : class406.gclass202_0.method_37(true).Intersect<GClass202>((IEnumerable<GClass202>) list_4).OrderByDescending<GClass202, int>((Func<GClass202, int>) (gclass202_0 => gclass202_0.gclass3_0.int_0)).Select<GClass202, GClass120>(new Func<GClass202, GClass120>(class406.method_0)).ToList<GClass120>();
        if (source.Count == 0)
          break;
        foreach (GClass120 gclass120 in source)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass2.Class407 class407 = new GClass2.Class407()
          {
            class406_0 = class406,
            gclass120_0 = gclass120
          };
          // ISSUE: reference to a compiler-generated field
          class407.gclass120_0.bool_0 = false;
          // ISSUE: reference to a compiler-generated method
          GClass85 gclass85 = list_6.FirstOrDefault<GClass85>(new Func<GClass85, bool>(class407.method_0));
          if (gclass85 != null)
          {
            gclass85.gclass4_0.bool_1 = true;
            // ISSUE: reference to a compiler-generated field
            class407.gclass120_0.bool_0 = true;
          }
        }
        List<GClass120> list1 = source.Where<GClass120>((Func<GClass120, bool>) (gclass120_0 => !gclass120_0.bool_0)).ToList<GClass120>();
        if (list1.Count == 0)
          break;
        foreach (GClass120 gclass120 in list1)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass2.Class408 class408 = new GClass2.Class408();
          // ISSUE: reference to a compiler-generated field
          class408.gclass120_0 = gclass120;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if (list_6.Where<GClass85>(class406.class405_0.func_0 ?? (class406.class405_0.func_0 = new Func<GClass85, bool>(class406.class405_0.method_0))).SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).FirstOrDefault<GClass139>(new Func<GClass139, bool>(class408.method_0)) != null)
          {
            // ISSUE: reference to a compiler-generated field
            class408.gclass120_0.bool_0 = true;
          }
        }
        List<GClass120> list2 = list1.Where<GClass120>((Func<GClass120, bool>) (gclass120_0 => !gclass120_0.bool_0)).ToList<GClass120>();
        if (list2.Count == 0)
          break;
        foreach (GClass120 gclass120_1 in list2)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          GClass85 gclass85_1 = list_6.FirstOrDefault<GClass85>(class406.func_0 ?? (class406.func_0 = new Func<GClass85, bool>(class406.method_2)));
          if (gclass85_1 != null)
          {
            gclass85_1.method_263();
            // ISSUE: reference to a compiler-generated field
            gclass85_1.method_231(gclass120_1, GEnum123.const_1, class406.gclass202_0);
            gclass85_1.gclass4_0.bool_1 = true;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            foreach (GClass85 gclass85_2 in list_6.Where<GClass85>(class406.class405_0.func_1 ?? (class406.class405_0.func_1 = new Func<GClass85, bool>(class406.class405_0.method_1))).OrderBy<GClass85, int>(class406.func_1 ?? (class406.func_1 = new Func<GClass85, int>(class406.method_3))).ToList<GClass85>())
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (gclass85_2.method_236(GEnum109.const_41, "Move To " + class406.gclass202_0.Name, false, class406.gclass202_0.gclass200_0.int_0, false).gclass202_0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                gclass85_2.method_231(gclass120_1, GEnum123.const_1, class406.gclass202_0);
                gclass85_2.gclass4_0.bool_1 = true;
                break;
              }
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 41);
    }
  }

  public void method_47(
    GClass202 gclass202_0_1,
    List<GClass202> list_3,
    List<GClass85> list_4,
    GEnum104 genum104_0,
    bool bool_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class409 class409 = new GClass2.Class409();
    // ISSUE: reference to a compiler-generated field
    class409.gclass202_0 = gclass202_0_1;
    // ISSUE: reference to a compiler-generated field
    class409.genum104_0 = genum104_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      List<GClass120> source = bool_0 ? this.gclass0_0.dictionary_13.Values.Where<GClass214>(new Func<GClass214, bool>(class409.method_1)).Select<GClass214, GClass120>((Func<GClass214, GClass120>) (gclass214_0 => gclass214_0.gclass120_0)).ToList<GClass120>() : class409.gclass202_0.method_37(true).Intersect<GClass202>((IEnumerable<GClass202>) list_3).OrderByDescending<GClass202, int>((Func<GClass202, int>) (gclass202_0_2 => gclass202_0_2.gclass3_0.int_0)).Select<GClass202, GClass120>(new Func<GClass202, GClass120>(class409.method_0)).ToList<GClass120>();
      if (source.Count == 0)
        return;
      foreach (GClass120 gclass120 in source)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class410 class410 = new GClass2.Class410()
        {
          class409_0 = class409,
          gclass120_0 = gclass120
        };
        // ISSUE: reference to a compiler-generated field
        class410.gclass120_0.bool_0 = false;
        // ISSUE: reference to a compiler-generated method
        GClass85 gclass85 = list_4.FirstOrDefault<GClass85>(new Func<GClass85, bool>(class410.method_0));
        if (gclass85 != null)
        {
          gclass85.gclass4_0.bool_1 = true;
          // ISSUE: reference to a compiler-generated field
          class410.gclass120_0.bool_0 = true;
        }
      }
      List<GClass120> list = source.Where<GClass120>((Func<GClass120, bool>) (gclass120_0 => !gclass120_0.bool_0)).ToList<GClass120>();
      if (list.Count == 0)
        return;
      foreach (GClass120 gclass120_1 in list)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        GClass85 gclass85 = list_4.FirstOrDefault<GClass85>(class409.func_0 ?? (class409.func_0 = new Func<GClass85, bool>(class409.method_2)));
        if (gclass85 != null)
        {
          gclass85.method_263();
          // ISSUE: reference to a compiler-generated field
          gclass85.method_231(gclass120_1, GEnum123.const_1, class409.gclass202_0);
          gclass85.gclass4_0.bool_1 = true;
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 42);
    }
  }

  public void method_48(List<GClass146> list_3)
  {
    try
    {
      List<GClass85> list1 = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass21_0 == this.gclass21_0 && gclass85_0.gclass9_0.genum104_0 == GEnum104.const_13 && !gclass85_0.gclass4_0.bool_1)).Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.method_154() > (Decimal) gclass85_0.method_140() * 0.5M)).ToList<GClass85>();
      if (list1.Count == 0)
        return;
      List<GClass146> list2 = list_3.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.method_62(AuroraProductionCategory.RefuellingPoint) > 0M && gclass146_0.decimal_3 < 5000000M)).ToList<GClass146>();
      if (list2.Count == 0)
        list2 = list_3.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.method_62(AuroraProductionCategory.RefuellingPoint) > 0M && gclass146_0.decimal_3 < 10000000M)).ToList<GClass146>();
      if (list2.Count == 0)
        list2 = list_3.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.method_62(AuroraProductionCategory.RefuellingPoint) > 0M && gclass146_0.decimal_3 < 20000000M)).ToList<GClass146>();
      if (list2.Count == 0)
        list2 = list_3.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.method_62(AuroraProductionCategory.RefuellingPoint) > 0M)).ToList<GClass146>();
      if (list2.Count == 0)
        return;
      foreach (GClass85 gclass85 in list1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class411 class411 = new GClass2.Class411();
        // ISSUE: reference to a compiler-generated field
        class411.gclass2_0 = this;
        // ISSUE: reference to a compiler-generated field
        class411.gclass85_0 = gclass85;
        // ISSUE: reference to a compiler-generated method
        GClass146 gclass146_1 = list2.FirstOrDefault<GClass146>(new Func<GClass146, bool>(class411.method_0));
        if (gclass146_1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          class411.gclass85_0.method_263();
          // ISSUE: reference to a compiler-generated field
          class411.gclass85_0.method_219(gclass146_1, GEnum123.const_19);
          // ISSUE: reference to a compiler-generated field
          class411.gclass85_0.gclass4_0.bool_1 = true;
        }
        else
        {
          // ISSUE: reference to a compiler-generated method
          GClass146 gclass146 = list2.OrderBy<GClass146, int>(new Func<GClass146, int>(class411.method_1)).FirstOrDefault<GClass146>();
          // ISSUE: reference to a compiler-generated field
          if (gclass146 != null && class411.gclass85_0.method_236(GEnum109.const_41, "", false, gclass146.gclass202_0.gclass200_0.int_0, false).gclass202_0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            class411.gclass85_0.gclass4_0.bool_1 = true;
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 43);
    }
  }

  public void method_49(List<GClass146> list_3)
  {
    try
    {
      List<GClass85> list1 = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 =>
      {
        if (gclass85_0.gclass21_0 != this.gclass21_0 || gclass85_0.dictionary_0.Count != 0)
          return false;
        return gclass85_0.gclass9_0.genum104_0 == GEnum104.const_18 || gclass85_0.genum106_0 == GEnum106.const_3;
      })).Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.method_154() > (Decimal) gclass85_0.method_140() * 0.5M)).ToList<GClass85>();
      List<GClass85> list2 = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass21_0 == this.gclass21_0 && gclass85_0.gclass9_0.genum104_0 == GEnum104.const_13 && !gclass85_0.gclass4_0.bool_1)).Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.method_154() < (Decimal) gclass85_0.method_140() * 0.5M)).ToList<GClass85>();
      List<GClass146> list3 = list_3.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.method_62(AuroraProductionCategory.RefuellingPoint) > 0M && gclass146_0.decimal_3 > 20000000M)).ToList<GClass146>();
      if (list2.Count == 0)
        return;
      foreach (GClass85 gclass85_1 in list2)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class412 class412 = new GClass2.Class412();
        // ISSUE: reference to a compiler-generated field
        class412.gclass2_0 = this;
        // ISSUE: reference to a compiler-generated field
        class412.gclass85_0 = gclass85_1;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        GClass85 gclass85_5 = list1.Where<GClass85>(new Func<GClass85, bool>(class412.method_0)).OrderBy<GClass85, double>(new Func<GClass85, double>(class412.method_1)).ThenByDescending<GClass85, Decimal>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.method_154() / (Decimal) gclass85_0.method_140())).FirstOrDefault<GClass85>();
        if (gclass85_5 != null)
        {
          // ISSUE: reference to a compiler-generated field
          class412.gclass85_0.method_263();
          // ISSUE: reference to a compiler-generated field
          class412.gclass85_0.method_222(gclass85_5, GEnum123.const_100);
          // ISSUE: reference to a compiler-generated field
          class412.gclass85_0.gclass4_0.bool_1 = true;
        }
        else
        {
          // ISSUE: reference to a compiler-generated method
          GClass85 gclass85_2 = list1.OrderBy<GClass85, int>(new Func<GClass85, int>(class412.method_2)).FirstOrDefault<GClass85>();
          // ISSUE: reference to a compiler-generated field
          if (gclass85_2 != null && class412.gclass85_0.method_236(GEnum109.const_41, "", false, gclass85_2.gclass202_0.gclass200_0.int_0, false).gclass202_0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            class412.gclass85_0.gclass4_0.bool_1 = true;
          }
          else
          {
            // ISSUE: reference to a compiler-generated method
            GClass146 gclass146_1 = list3.FirstOrDefault<GClass146>(new Func<GClass146, bool>(class412.method_3));
            if (gclass146_1 != null)
            {
              // ISSUE: reference to a compiler-generated field
              class412.gclass85_0.method_263();
              // ISSUE: reference to a compiler-generated field
              class412.gclass85_0.method_219(gclass146_1, GEnum123.const_6);
              // ISSUE: reference to a compiler-generated field
              class412.gclass85_0.gclass4_0.bool_1 = true;
            }
            else
            {
              // ISSUE: reference to a compiler-generated method
              GClass146 gclass146 = list3.OrderBy<GClass146, int>(new Func<GClass146, int>(class412.method_4)).FirstOrDefault<GClass146>();
              // ISSUE: reference to a compiler-generated field
              if (gclass146 != null && class412.gclass85_0.method_236(GEnum109.const_41, "", false, gclass146.gclass202_0.gclass200_0.int_0, false).gclass202_0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                class412.gclass85_0.gclass4_0.bool_1 = true;
              }
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 44);
    }
  }

  public void method_50(List<GClass146> list_3)
  {
    try
    {
      List<GClass146> list1 = list_3.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass1_0.double_20 * 2.0 <= (double) gclass146_0.gclass21_0.int_11 && gclass146_0.gclass202_0.gclass3_0.genum95_0 != 0)).Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass6_0.double_1 > 0.0)).OrderByDescending<GClass146, double>((Func<GClass146, double>) (gclass146_0 => gclass146_0.gclass6_0.double_1)).ToList<GClass146>();
      List<GClass85> list2 = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass21_0 == this.gclass21_0 && gclass85_0.gclass9_0.genum104_0 == GEnum104.const_15)).ToList<GClass85>();
      if (list1.Count == 0 || list2.Count == 0)
        return;
      foreach (GClass85 gclass85 in list2)
      {
        long num = gclass85.method_31();
        foreach (GClass146 gclass146_1 in list1)
        {
          if (gclass85.gclass202_0 == gclass146_1.gclass202_0 && gclass85.double_2 == gclass146_1.method_87())
          {
            if (gclass85.double_3 == gclass146_1.method_88())
              break;
          }
          if (gclass146_1.gclass202_0 != gclass85.gclass202_0 || gclass146_1.gclass202_0.gclass200_0.method_3(gclass85.double_2, gclass85.double_3, gclass146_1.method_87(), gclass146_1.method_88()) >= (double) num)
          {
            if (gclass146_1.gclass202_0.gclass200_0.method_3(0.0, 0.0, gclass146_1.method_87(), gclass146_1.method_88()) <= (double) num)
            {
              if (gclass85.method_236(GEnum109.const_41, "", false, gclass146_1.gclass202_0.gclass200_0.int_0, false).gclass202_0 != null)
                break;
            }
          }
          else
          {
            gclass85.method_263();
            gclass85.method_219(gclass146_1, GEnum123.const_1);
            break;
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 45);
    }
  }

  public void method_51(List<GClass85> list_3, List<GClass202> list_4)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass2.Class413 class413 = new GClass2.Class413();
    // ISSUE: reference to a compiler-generated field
    class413.gclass2_0 = this;
    // ISSUE: reference to a compiler-generated field
    class413.list_0 = list_4;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      List<GClass202> list1 = this.gclass0_0.dictionary_29.Values.Select<GClass233, GClass200>((Func<GClass233, GClass200>) (gclass233_0 => gclass233_0.gclass200_0)).Distinct<GClass200>().Where<GClass200>(new Func<GClass200, bool>(class413.method_0)).Select<GClass200, GClass202>(new Func<GClass200, GClass202>(class413.method_1)).Where<GClass202>(new Func<GClass202, bool>(class413.method_2)).ToList<GClass202>();
      // ISSUE: reference to a compiler-generated method
      List<GClass202> list2 = list_3.Where<GClass85>(new Func<GClass85, bool>(class413.method_3)).Select<GClass85, GClass202>((Func<GClass85, GClass202>) (gclass85_0 => gclass85_0.gclass202_0)).Distinct<GClass202>().ToList<GClass202>();
      if (list1.Count == 0 || list2.Count == 0)
        return;
      this.method_44(list1, list2, list_3, GEnum104.const_9, GEnum100.const_2, 1);
      if (this.gclass21_0.genum6_0 != GEnum6.const_2)
        return;
      // ISSUE: reference to a compiler-generated method
      List<GClass202> list3 = list_3.Where<GClass85>(new Func<GClass85, bool>(class413.method_4)).Select<GClass85, GClass202>((Func<GClass85, GClass202>) (gclass85_0 => gclass85_0.gclass202_0)).Distinct<GClass202>().ToList<GClass202>();
      if (list3.Count == 0)
        return;
      // ISSUE: reference to a compiler-generated method
      this.method_44(list_3.Where<GClass85>(new Func<GClass85, bool>(class413.method_5)).Select<GClass85, GClass202>((Func<GClass85, GClass202>) (gclass85_0 => gclass85_0.gclass202_0)).Distinct<GClass202>().ToList<GClass202>(), list3, list_3, GEnum104.const_9, GEnum100.const_2, 10);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 46);
    }
  }

  public void method_52(List<GClass85> list_3, List<GClass202> list_4)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass2.Class414 class414 = new GClass2.Class414();
      if (list_4.Count == 0)
        return;
      List<GClass85> list1 = list_3.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum104_0 == GEnum104.const_12)).ToList<GClass85>();
      if (list1.Count == 0)
        return;
      // ISSUE: reference to a compiler-generated field
      class414.list_0 = list_4.Select<GClass202, GClass200>((Func<GClass202, GClass200>) (gclass202_0 => gclass202_0.gclass200_0)).ToList<GClass200>();
      // ISSUE: reference to a compiler-generated method
      List<GClass1> list2 = this.gclass0_0.dictionary_11.Values.Where<GClass1>(new Func<GClass1, bool>(class414.method_0)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.dictionary_0.Values.Count > 3)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.method_77(this.gclass21_0))).Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.method_16(50, false))).OrderByDescending<GClass1, double>((Func<GClass1, double>) (gclass1_0 => gclass1_0.method_17())).ToList<GClass1>();
      if (list2.Count == 0)
        return;
      foreach (GClass85 gclass85 in list1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class415 class415 = new GClass2.Class415();
        // ISSUE: reference to a compiler-generated field
        class415.gclass85_0 = gclass85;
        foreach (GClass1 gclass1_1 in list2)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (class415.gclass85_0.gclass202_0.gclass200_0 == gclass1_1.gclass200_0 && class415.gclass85_0.double_2 == gclass1_1.double_0)
          {
            // ISSUE: reference to a compiler-generated field
            if (class415.gclass85_0.double_3 == gclass1_1.double_1)
              break;
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          GClass1 gclass1 = list2.FirstOrDefault<GClass1>(class415.func_0 ?? (class415.func_0 = new Func<GClass1, bool>(class415.method_0)));
          if (gclass1 != null)
          {
            double num = gclass1.method_17();
            if (gclass1_1.method_17() < num * 1.2)
              break;
          }
          // ISSUE: reference to a compiler-generated field
          if (gclass1_1.gclass200_0 != class415.gclass85_0.gclass202_0.gclass200_0)
          {
            // ISSUE: reference to a compiler-generated field
            if (class415.gclass85_0.method_236(GEnum109.const_41, "", false, gclass1_1.gclass200_0.int_0, false).gclass202_0 != null)
              break;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            class415.gclass85_0.method_263();
            // ISSUE: reference to a compiler-generated field
            class415.gclass85_0.method_215(gclass1_1, GEnum123.const_1);
            break;
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 47);
    }
  }

  public void method_53(List<GClass146> list_3)
  {
    try
    {
      List<GClass146> list1 = list_3.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass6_0.double_0 > 0.0 && gclass146_0.gclass202_0.gclass3_0.genum95_0 != 0)).OrderBy<GClass146, double>((Func<GClass146, double>) (gclass146_0 => gclass146_0.gclass6_0.double_0)).ToList<GClass146>();
      List<GClass85> list2 = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass21_0 == this.gclass21_0 && gclass85_0.gclass9_0.genum104_0 == GEnum104.const_8)).ToList<GClass85>();
      if (list1.Count == 0 || list2.Count == 0)
        return;
      foreach (GClass85 gclass85 in list2)
      {
        long num = gclass85.method_31();
        foreach (GClass146 gclass146_1 in list1)
        {
          if (gclass85.gclass202_0 == gclass146_1.gclass202_0 && gclass85.double_2 == gclass146_1.method_87())
          {
            if (gclass85.double_3 == gclass146_1.method_88())
              break;
          }
          if (gclass146_1.gclass202_0 != gclass85.gclass202_0 || gclass146_1.gclass202_0.gclass200_0.method_3(gclass85.double_2, gclass85.double_3, gclass146_1.method_87(), gclass146_1.method_88()) >= (double) num)
          {
            if (gclass146_1.gclass202_0.gclass200_0.method_3(0.0, 0.0, gclass146_1.method_87(), gclass146_1.method_88()) <= (double) num)
            {
              if (gclass85.method_236(GEnum109.const_41, "", false, gclass146_1.gclass202_0.gclass200_0.int_0, false).gclass202_0 != null)
                break;
            }
          }
          else
          {
            gclass85.method_263();
            gclass85.method_219(gclass146_1, GEnum123.const_1);
            break;
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 48 /*0x30*/);
    }
  }

  public void method_54()
  {
    try
    {
      List<GClass1> list1 = this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.method_20(AuroraElement.Sorium) > 50000M)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.method_77(this.gclass21_0))).OrderByDescending<GClass1, Decimal>((Func<GClass1, Decimal>) (gclass1_0 => gclass1_0.method_21(AuroraElement.Sorium))).ToList<GClass1>();
      List<GClass85> list2 = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass21_0 == this.gclass21_0 && gclass85_0.gclass9_0.genum104_0 == GEnum104.const_18)).ToList<GClass85>();
      if (list1.Count == 0 || list2.Count == 0)
        return;
      foreach (GClass85 gclass85 in list2)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass2.Class416 class416 = new GClass2.Class416();
        // ISSUE: reference to a compiler-generated field
        class416.gclass85_0 = gclass85;
        // ISSUE: reference to a compiler-generated field
        long num1 = class416.gclass85_0.method_31();
        Decimal num2 = 0M;
        // ISSUE: reference to a compiler-generated method
        GClass1 gclass1 = list1.FirstOrDefault<GClass1>(new Func<GClass1, bool>(class416.method_0));
        if (gclass1 != null)
          num2 = gclass1.method_21(AuroraElement.Sorium);
        if (!(num2 == 1M))
        {
          foreach (GClass1 gclass1_1 in list1)
          {
            if (gclass1_1 != gclass1)
            {
              // ISSUE: reference to a compiler-generated field
              if (gclass1_1.gclass200_0 == class416.gclass85_0.gclass202_0.gclass200_0)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (gclass1_1.gclass200_0.method_3(class416.gclass85_0.double_2, class416.gclass85_0.double_3, gclass1_1.double_0, gclass1_1.double_1) < (double) num1)
                {
                  // ISSUE: reference to a compiler-generated field
                  class416.gclass85_0.method_263();
                  // ISSUE: reference to a compiler-generated field
                  class416.gclass85_0.method_215(gclass1_1, GEnum123.const_1);
                  break;
                }
              }
              else if (!(gclass1_1.method_21(AuroraElement.Sorium) - num2 < 0.2M))
              {
                if (gclass1_1.gclass200_0.method_3(0.0, 0.0, gclass1_1.double_0, gclass1_1.double_1) <= (double) num1)
                {
                  // ISSUE: reference to a compiler-generated field
                  if (class416.gclass85_0.method_236(GEnum109.const_41, "", false, gclass1_1.gclass200_0.int_0, false).gclass202_0 != null)
                    break;
                }
              }
              else
                break;
            }
            else
              break;
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 49);
    }
  }

  public void method_55()
  {
    try
    {
      foreach (GClass202 gclass202 in this.gclass21_0.dictionary_0.Values)
      {
        if (gclass202.gclass3_0.genum95_0 != GEnum95.const_0)
          gclass202.gclass3_0.genum95_0 = GEnum95.const_1;
      }
      GClass202 gclass202_1 = this.gclass21_0.method_190();
      if (gclass202_1 != null)
        gclass202_1.gclass3_0.genum95_0 = GEnum95.const_6;
      List<GClass40> list1 = this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass21_0 == this.gclass21_0)).ToList<GClass40>();
      List<GClass202> list2 = this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass21_0 == this.gclass21_0)).Select<GClass146, GClass202>((Func<GClass146, GClass202>) (gclass146_0 => gclass146_0.gclass202_0)).Distinct<GClass202>().ToList<GClass202>();
      list2.AddRange((IEnumerable<GClass202>) this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass21_0 == this.gclass21_0)).Select<GClass85, GClass202>((Func<GClass85, GClass202>) (gclass85_0 => gclass85_0.gclass202_0)).Distinct<GClass202>().ToList<GClass202>());
      List<GClass202> list3 = list2.Distinct<GClass202>().Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 != 0)).ToList<GClass202>();
      foreach (GClass202 gclass202_2 in list3)
        gclass202_2.gclass3_0.method_24(list1);
      List<GClass202> list4 = list3.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 > GEnum95.const_1)).ToList<GClass202>();
      foreach (GClass202 gclass202_3 in list4.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_5 || gclass202_0.gclass3_0.genum95_0 == GEnum95.const_6)).ToList<GClass202>())
        gclass202_3.gclass3_0.method_26(GEnum95.const_3);
      foreach (GClass202 gclass202_4 in list4.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_4)).ToList<GClass202>())
        gclass202_4.gclass3_0.method_26(GEnum95.const_2);
      foreach (GClass202 gclass202_5 in this.gclass21_0.dictionary_0.Values.Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 > GEnum95.const_2)).ToList<GClass202>().SelectMany<GClass202, GClass202>((Func<GClass202, IEnumerable<GClass202>>) (gclass202_0 => (IEnumerable<GClass202>) gclass202_0.method_37(true))).Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_1)).ToList<GClass202>())
        gclass202_5.gclass3_0.method_25(list1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 50);
    }
  }

  public void method_56(List<GClass146> list_3)
  {
    try
    {
      foreach (GClass146 gclass146 in list_3)
      {
        gclass146.gclass6_0.bool_0 = false;
        gclass146.gclass6_0.bool_1 = false;
      }
      bool flag1 = false;
      bool flag2 = false;
      foreach (GClass146 gclass146 in list_3)
      {
        if (gclass146.dictionary_5.ContainsKey(AuroraInstallationType.Mine))
          gclass146.dictionary_5.Remove(AuroraInstallationType.Mine);
        if (gclass146.dictionary_5.ContainsKey(AuroraInstallationType.AutomatedMine))
          gclass146.dictionary_5.Remove(AuroraInstallationType.AutomatedMine);
        if (!gclass146.bool_0 && gclass146.gclass6_0.double_1 >= GClass226.double_29)
        {
          gclass146.method_60(this.gclass0_0.dictionary_44[AuroraInstallationType.AutomatedMine], 10, false);
          flag1 = true;
          gclass146.gclass6_0.bool_1 = true;
          if (gclass146.decimal_30 > 0M && gclass146.decimal_19 < 3M && gclass146.decimal_56 < gclass146.decimal_53)
          {
            Decimal int_25 = (gclass146.decimal_53 - gclass146.decimal_56) / GClass226.decimal_68;
            if (int_25 >= 1M)
            {
              if (int_25 > 10M)
                int_25 = 10M;
              gclass146.method_60(this.gclass0_0.dictionary_44[AuroraInstallationType.Mine], (int) int_25, false);
              flag2 = true;
              gclass146.gclass6_0.bool_0 = true;
            }
          }
        }
      }
      if (!flag1)
        list_3.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass6_0.double_1 >= GClass226.double_30 && !gclass146_0.bool_0)).OrderByDescending<GClass146, double>((Func<GClass146, double>) (gclass146_0 => gclass146_0.gclass6_0.double_1)).FirstOrDefault<GClass146>()?.method_60(this.gclass0_0.dictionary_44[AuroraInstallationType.AutomatedMine], 10, false);
      if (!flag2)
      {
        GClass146 gclass146 = list_3.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.decimal_30 > 0M && gclass146_0.decimal_19 < 3M && gclass146_0.gclass6_0.double_1 >= GClass226.double_30 && gclass146_0.decimal_56 - gclass146_0.decimal_53 >= GClass226.decimal_68 && !gclass146_0.bool_0)).OrderByDescending<GClass146, double>((Func<GClass146, double>) (gclass146_0 => gclass146_0.gclass6_0.double_1)).FirstOrDefault<GClass146>();
        if (gclass146 != null)
        {
          int num = (gclass146.decimal_53 - gclass146.decimal_56) / GClass226.decimal_68 > 10M ? 1 : 0;
          gclass146.method_60(this.gclass0_0.dictionary_44[AuroraInstallationType.Mine], 10, false);
        }
      }
      foreach (GClass146 gclass146 in list_3.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => !gclass146_0.gclass6_0.bool_1 && (gclass146_0.gclass6_0.double_1 < GClass226.double_30 || gclass146_0.bool_0) && gclass146_0.method_73(AuroraInstallationType.AutomatedMine) > 0)).ToList<GClass146>())
        gclass146.method_60(this.gclass0_0.dictionary_44[AuroraInstallationType.AutomatedMine], gclass146.method_73(AuroraInstallationType.AutomatedMine), true);
      foreach (GClass146 gclass146 in list_3.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => !gclass146_0.gclass6_0.bool_0 && (gclass146_0.gclass6_0.double_1 < GClass226.double_30 || gclass146_0.bool_0) && gclass146_0.method_73(AuroraInstallationType.Mine) > 0)).ToList<GClass146>())
        gclass146.method_60(this.gclass0_0.dictionary_44[AuroraInstallationType.Mine], gclass146.method_73(AuroraInstallationType.Mine), true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 51);
    }
  }

  public void method_57(List<GClass146> list_3)
  {
    try
    {
      foreach (GClass146 gclass146 in list_3)
      {
        if (gclass146.gclass202_0.gclass3_0.genum95_0 != GEnum95.const_0)
        {
          if (gclass146.dictionary_5.ContainsKey(AuroraInstallationType.TrackingStation))
            gclass146.dictionary_5.Remove(AuroraInstallationType.TrackingStation);
          int num1 = gclass146.method_73(AuroraInstallationType.TrackingStation);
          int num2 = gclass146.method_74() - num1 * this.gclass0_0.dictionary_44[AuroraInstallationType.TrackingStation].int_0;
          gclass146.gclass6_0.int_1 = 0;
          if (gclass146.gclass6_0.genum97_0 == GEnum97.const_5)
            gclass146.gclass6_0.int_1 = 6;
          else if (gclass146.gclass6_0.genum97_0 == GEnum97.const_4)
            gclass146.gclass6_0.int_1 = 4;
          else if (gclass146.gclass6_0.genum97_0 == GEnum97.const_3)
            gclass146.gclass6_0.int_1 = 3;
          else if (gclass146.gclass6_0.genum97_0 == GEnum97.const_2 && num2 > 100)
            gclass146.gclass6_0.int_1 = 2;
          else if (gclass146.gclass6_0.genum97_0 == GEnum97.const_1 && num2 > 100)
            gclass146.gclass6_0.int_1 = 1;
          if (num1 != gclass146.gclass6_0.int_1)
          {
            if (num1 < gclass146.gclass6_0.int_1)
              gclass146.method_60(this.gclass0_0.dictionary_44[AuroraInstallationType.TrackingStation], gclass146.gclass6_0.int_1 - num1, false);
            else if (num1 > gclass146.gclass6_0.int_1)
              gclass146.method_60(this.gclass0_0.dictionary_44[AuroraInstallationType.TrackingStation], num1 - gclass146.gclass6_0.int_1, true);
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 52);
    }
  }

  public void method_58(List<GClass146> list_3)
  {
    try
    {
      foreach (GClass146 gclass146 in list_3)
      {
        if (gclass146.gclass202_0.gclass3_0.genum95_0 != GEnum95.const_0)
        {
          bool flag = false;
          if (gclass146.dictionary_5.ContainsKey(AuroraInstallationType.ConstructionFactory))
            gclass146.dictionary_5.Remove(AuroraInstallationType.ConstructionFactory);
          int int_25_1 = gclass146.method_73(AuroraInstallationType.ConstructionFactory);
          int num = gclass146.method_73(AuroraInstallationType.Mine) + gclass146.method_73(AuroraInstallationType.AutomatedMine);
          if (gclass146.decimal_30 > 0M && gclass146.decimal_19 < 3M && gclass146.gclass6_0.double_1 >= GClass226.double_29 && int_25_1 < num && !gclass146.bool_0 && gclass146.decimal_56 < gclass146.decimal_53)
          {
            Decimal int_25_2 = (gclass146.decimal_53 - gclass146.decimal_56) / GClass226.decimal_68;
            if (int_25_2 >= 1M)
            {
              if (int_25_2 > 10M)
                int_25_2 = 10M;
              gclass146.method_60(this.gclass0_0.dictionary_44[AuroraInstallationType.ConstructionFactory], (int) int_25_2, false);
              flag = true;
            }
          }
          if (!flag && int_25_1 > 0)
          {
            if (int_25_1 > 10)
              int_25_1 = 10;
            gclass146.method_60(this.gclass0_0.dictionary_44[AuroraInstallationType.ConstructionFactory], int_25_1, true);
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 53);
    }
  }

  public void method_59(List<GClass146> list_3)
  {
    try
    {
      foreach (GClass146 gclass146 in list_3)
      {
        if (gclass146.gclass202_0.gclass3_0.genum95_0 != GEnum95.const_0)
        {
          if (gclass146.dictionary_5.ContainsKey(AuroraInstallationType.ResearchLab))
            gclass146.dictionary_5.Remove(AuroraInstallationType.ResearchLab);
          Decimal num1 = gclass146.method_147();
          if (num1 < 0M)
          {
            Decimal num2 = 0M;
            Decimal num3 = gclass146.method_75(AuroraInstallationType.ResearchLab);
            if (num3 >= 1M)
              num2 = 1M;
            Decimal decimal_90 = num2 + num3 % 1M;
            if (decimal_90 > 0M)
              gclass146.method_61(this.gclass0_0.dictionary_44[AuroraInstallationType.ResearchLab], decimal_90, true, false);
          }
          else
          {
            Decimal d = gclass146.method_75(AuroraInstallationType.ResearchLab);
            if (!(d == 0M))
            {
              Decimal decimal_90 = d - Math.Floor(d);
              if (num1 > 5M)
                ++decimal_90;
              if (decimal_90 > 0M)
                gclass146.method_61(this.gclass0_0.dictionary_44[AuroraInstallationType.ResearchLab], decimal_90, false, true);
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 54);
    }
  }

  public void method_60(List<GClass146> list_3)
  {
    try
    {
      foreach (GClass146 gclass146 in list_3)
      {
        if (gclass146.gclass202_0.gclass3_0.genum95_0 != GEnum95.const_0)
        {
          if (gclass146.dictionary_5.ContainsKey(AuroraInstallationType.GFCC))
            gclass146.dictionary_5.Remove(AuroraInstallationType.GFCC);
          Decimal num1 = gclass146.method_147();
          Decimal num2 = gclass146.gclass1_0.method_20(AuroraElement.Vendarite);
          if (!(num1 < 0M) && !(num2 < 1000M))
          {
            if (num2 > 1000M)
            {
              Decimal d = gclass146.method_75(AuroraInstallationType.GFCC);
              if (!(d == 0M))
              {
                Decimal decimal_90 = 1M - (d - Math.Floor(d));
                if (num1 > 3M)
                  ++decimal_90;
                if (decimal_90 > 0M)
                  gclass146.method_61(this.gclass0_0.dictionary_44[AuroraInstallationType.GFCC], decimal_90, false, true);
              }
            }
          }
          else
          {
            Decimal num3 = 0M;
            Decimal num4 = gclass146.method_75(AuroraInstallationType.GFCC);
            if (num4 >= 1M)
              num3 = 1M;
            Decimal decimal_90 = num3 + num4 % 1M;
            if (decimal_90 > 0M)
              gclass146.method_61(this.gclass0_0.dictionary_44[AuroraInstallationType.GFCC], decimal_90, true, false);
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 55);
    }
  }

  public void method_61(List<GClass146> list_3)
  {
    try
    {
      list_3 = list_3.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass202_0.gclass3_0.genum95_0 != 0)).OrderByDescending<GClass146, GEnum97>((Func<GClass146, GEnum97>) (gclass146_0 => gclass146_0.gclass6_0.genum97_0)).ToList<GClass146>();
      foreach (GClass146 gclass146 in list_3)
        gclass146.gclass6_0.decimal_1 = Math.Floor(gclass146.method_62(AuroraProductionCategory.RefuellingPoint));
      List<GClass202> list = list_3.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass6_0.decimal_1 > 0M)).Select<GClass146, GClass202>((Func<GClass146, GClass202>) (gclass146_0 => gclass146_0.gclass202_0)).ToList<GClass202>();
      foreach (GClass146 gclass146 in list_3)
      {
        if (gclass146.dictionary_5.ContainsKey(AuroraInstallationType.RefuellingStation))
          gclass146.dictionary_5.Remove(AuroraInstallationType.RefuellingStation);
        if (list.Contains(gclass146.gclass202_0))
        {
          if (gclass146.gclass6_0.decimal_1 > 1M)
          {
            int num = gclass146.method_73(AuroraInstallationType.RefuellingStation);
            if (num > 1)
              gclass146.method_60(this.gclass0_0.dictionary_44[AuroraInstallationType.RefuellingStation], num - 1, true);
          }
        }
        else if (this.gclass0_0.method_32(gclass146.gclass21_0, gclass146.gclass202_0, 2).Values.Intersect<GClass202>((IEnumerable<GClass202>) list).Count<GClass202>() <= 0)
          gclass146.method_60(this.gclass0_0.dictionary_44[AuroraInstallationType.RefuellingStation], 1, false);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 56);
    }
  }

  public double method_62(GClass1 gclass1_0, bool bool_0)
  {
    try
    {
      if (gclass1_0.dictionary_0.Count == 0 || gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian)
        return 0.0;
      double num1 = 0.0;
      if (this.gclass21_0.genum6_0 == GEnum6.const_2)
        return (double) gclass1_0.dictionary_0.Values.Sum<GClass124>((Func<GClass124, Decimal>) (gclass124_0 => gclass124_0.decimal_1));
      GClass123 gclass123 = this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass21_0 == this.gclass21_0 && gclass146_0.bool_0)).Select<GClass146, GClass123>((Func<GClass146, GClass123>) (gclass146_0 => gclass146_0.gclass123_0)).FirstOrDefault<GClass123>();
      foreach (GClass124 gclass124 in gclass1_0.dictionary_0.Values)
      {
        if (!(gclass124.decimal_0 < 2000M))
        {
          double decimal1 = (double) gclass124.decimal_1;
          if (gclass124.decimal_0 < 10000M)
            decimal1 *= 0.5;
          if (gclass124.decimal_0 > 1000000M && gclass124.decimal_1 > 0.4M)
            decimal1 *= 2.0;
          else if (gclass124.decimal_0 > 250000M && gclass124.decimal_1 > 0.4M)
            decimal1 *= 1.5;
          else if (gclass124.decimal_0 > 100000M && gclass124.decimal_1 > 0.4M)
            decimal1 *= 1.25;
          if (!bool_0)
          {
            Decimal num2 = 0M;
            if (gclass123 != null)
              num2 = gclass123.method_14(gclass124.auroraElement_0);
            if (num2 < 1000M)
              decimal1 *= 3.0;
            else if (num2 < 3000M)
              decimal1 *= 2.0;
            else if (num2 < 5000M)
              decimal1 *= 1.5;
            else if (num2 > 400000M)
              decimal1 *= 0.1;
            else if (num2 > 200000M)
              decimal1 *= 0.25;
            else if (num2 > 100000M)
              decimal1 *= 0.5;
          }
          else if (gclass124.auroraElement_0 != AuroraElement.Duranium && gclass124.auroraElement_0 != AuroraElement.Gallicite)
          {
            if (gclass124.auroraElement_0 == AuroraElement.Corundium || gclass124.auroraElement_0 == AuroraElement.Neutronium)
              decimal1 *= 1.5;
          }
          else
            decimal1 *= 2.0;
          num1 += decimal1;
        }
      }
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 57);
      return 0.0;
    }
  }
}
