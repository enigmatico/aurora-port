// Decompiled with JetBrains decompiler
// Type: GClass3
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public partial class GClass3
{
  private GClass0 gclass0_0;
  private GClass202 gclass202_0;
  public GEnum95 genum95_0 = GEnum95.const_1;
  public GEnum96 genum96_0 = GEnum96.const_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public Decimal decimal_0;
  public Decimal decimal_1;

  public GClass3(GClass0 gclass0_1, GClass202 gclass202_1)
  {
    this.gclass0_0 = gclass0_1;
    this.gclass202_0 = gclass202_1;
  }

  public void method_0(List<GClass85> list_0, List<GClass65> list_1, List<GClass65> list_2)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass3.Class417 class417 = new GClass3.Class417();
      // ISSUE: reference to a compiler-generated field
      class417.gclass3_0 = this;
      List<GClass85> list1 = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass202_0 == this.gclass202_0)).ToList<GClass85>();
      if (list1.Count == 0)
        return;
      List<GClass40> list2 = list1.SelectMany<GClass85, GClass40>((Func<GClass85, IEnumerable<GClass40>>) (gclass85_0 => (IEnumerable<GClass40>) gclass85_0.method_176())).Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.int_42 > 0)).ToList<GClass40>();
      if (list2.Count == 0)
        return;
      int num1 = this.gclass202_0.gclass21_0.method_166(GEnum41.const_0);
      // ISSUE: reference to a compiler-generated field
      class417.double_0 = (double) (num1 * 2000000);
      list2.Select<GClass40, GClass85>((Func<GClass40, GClass85>) (gclass40_0 => gclass40_0.gclass85_0)).Distinct<GClass85>().Count<GClass85>();
      List<GClass65> list3 = list_1.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass200_0 == this.gclass202_0.gclass200_0)).ToList<GClass65>();
      List<GClass65> list4 = list_2.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass200_0 == this.gclass202_0.gclass200_0)).ToList<GClass65>();
      Func<GClass65, bool> predicate = (Func<GClass65, bool>) (gclass65_0 => gclass65_0.decimal_3 == this.gclass0_0.decimal_0);
      List<GClass65> list5 = list3.Where<GClass65>(predicate).ToList<GClass65>();
      List<GClass65> list6 = list4.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.decimal_3 == this.gclass0_0.decimal_0)).ToList<GClass65>();
      List<GClass120> list7 = this.gclass0_0.dictionary_12.Values.Where<GClass120>((Func<GClass120, bool>) (gclass120_0 => gclass120_0.gclass200_0 == this.gclass202_0.gclass200_0)).ToList<GClass120>();
      foreach (GClass85 gclass85 in list1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class418 class418 = new GClass3.Class418();
        // ISSUE: reference to a compiler-generated field
        class418.class417_0 = class417;
        // ISSUE: reference to a compiler-generated field
        class418.gclass85_0 = gclass85;
        // ISSUE: reference to a compiler-generated method
        List<GClass40> list8 = list2.Where<GClass40>(new Func<GClass40, bool>(class418.method_0)).ToList<GClass40>();
        if (list8.Count != 0)
        {
          bool flag = false;
          if (list8.Count<GClass40>((Func<GClass40, bool>) (gclass40_0 => this.gclass0_0.decimal_0 - gclass40_0.decimal_18 < 86400M)) > 0)
          {
            flag = true;
          }
          else
          {
            // ISSUE: reference to a compiler-generated method
            if (list7.Count<GClass120>(new Func<GClass120, bool>(class418.method_1)) > 0)
            {
              flag = true;
            }
            else
            {
              // ISSUE: reference to a compiler-generated method
              int num2 = list5.Count<GClass65>(new Func<GClass65, bool>(class418.method_2));
              // ISSUE: reference to a compiler-generated method
              int num3 = list6.Count<GClass65>(new Func<GClass65, bool>(class418.method_3));
              if (num2 > 0)
                flag = true;
              else if (num3 > 0 && this.genum95_0 >= GEnum95.const_4)
                flag = true;
              else if (num3 > 0 && list6.Count<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.auroraContactType_0 == AuroraContactType.Ship && gclass65_0.genum10_0 == GEnum10.const_3)) > 0)
                flag = true;
            }
          }
          if (!flag)
          {
            foreach (GClass40 gclass40 in list8)
            {
              gclass40.bool_10 = false;
              gclass40.decimal_3 = 0M;
            }
          }
          else
          {
            foreach (GClass40 gclass40 in list8)
              gclass40.bool_10 = true;
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3290);
    }
  }

  public void method_1(List<GClass85> list_0, List<GClass65> list_1, List<GClass65> list_2)
  {
    try
    {
      List<GClass85> list1 = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass202_0 == this.gclass202_0)).ToList<GClass85>();
      if (list1.Count == 0)
        return;
      List<GClass40> list2 = list1.SelectMany<GClass85, GClass40>((Func<GClass85, IEnumerable<GClass40>>) (gclass85_0 => (IEnumerable<GClass40>) gclass85_0.method_176())).Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.int_1 > 0)).ToList<GClass40>();
      if (list2.Count == 0)
        return;
      list2.Select<GClass40, GClass85>((Func<GClass40, GClass85>) (gclass40_0 => gclass40_0.gclass85_0)).Distinct<GClass85>().Count<GClass85>();
      List<GClass65> list3 = list_1.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass200_0 == this.gclass202_0.gclass200_0)).ToList<GClass65>();
      List<GClass65> list4 = list_2.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass200_0 == this.gclass202_0.gclass200_0)).ToList<GClass65>();
      Func<GClass65, bool> predicate = (Func<GClass65, bool>) (gclass65_0 => gclass65_0.decimal_3 == this.gclass0_0.decimal_0);
      List<GClass65> list5 = list3.Where<GClass65>(predicate).ToList<GClass65>();
      List<GClass65> list6 = list4.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.decimal_3 == this.gclass0_0.decimal_0)).ToList<GClass65>();
      foreach (GClass85 gclass85 in list1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class419 class419 = new GClass3.Class419();
        // ISSUE: reference to a compiler-generated field
        class419.gclass3_0 = this;
        // ISSUE: reference to a compiler-generated field
        class419.gclass85_0 = gclass85;
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class420 class420 = new GClass3.Class420();
        // ISSUE: reference to a compiler-generated field
        class420.class419_0 = class419;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        List<GClass40> list7 = list2.Where<GClass40>(new Func<GClass40, bool>(class420.class419_0.method_0)).ToList<GClass40>();
        if (list7.Count != 0)
        {
          foreach (GClass40 gclass40 in list7)
            gclass40.bool_8 = false;
          // ISSUE: reference to a compiler-generated field
          class420.double_0 = list7.SelectMany<GClass40, GClass228>((Func<GClass40, IEnumerable<GClass228>>) (gclass40_0 => (IEnumerable<GClass228>) gclass40_0.gclass22_0.dictionary_0.Values)).Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.ActiveSearchSensors)).Max<GClass228>((Func<GClass228, double>) (gclass228_0 => gclass228_0.gclass230_0.double_0));
          // ISSUE: reference to a compiler-generated method
          int num1 = list5.Count<GClass65>(new Func<GClass65, bool>(class420.method_0));
          // ISSUE: reference to a compiler-generated method
          int num2 = list6.Count<GClass65>(new Func<GClass65, bool>(class420.method_1));
          double num3;
          if (list7.Count<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.gclass14_0.genum66_0 > GEnum66.const_0)) == 0)
          {
            num3 = num1 <= 0 ? (num2 <= 0 || this.genum95_0 < GEnum95.const_4 ? (num2 > 0 || list5.Count > 0 ? 250.0 : (list6.Count <= 0 ? 30.0 : 100.0)) : 1000.0) : 1000.0;
          }
          else
          {
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            int num8 = list7.Count<GClass40>((Func<GClass40, bool>) (gclass40_0 => this.gclass0_0.decimal_0 - gclass40_0.decimal_18 < 120M));
            if (num8 == 0)
            {
              // ISSUE: object of a compiler-generated type is created
              // ISSUE: variable of a compiler-generated type
              GClass3.Class421 class421 = new GClass3.Class421()
              {
                class420_0 = class420
              };
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              class421.double_0 = class421.class420_0.class419_0.gclass85_0.method_159();
              // ISSUE: reference to a compiler-generated method
              num4 = list5.Count<GClass65>(new Func<GClass65, bool>(class421.method_0));
              if (num4 == 0)
              {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class422 class422 = new GClass3.Class422()
                {
                  class421_0 = class421
                };
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class422.double_0 = class422.class421_0.class420_0.class419_0.gclass85_0.method_158(100M);
                // ISSUE: reference to a compiler-generated method
                num5 = list5.Count<GClass65>(new Func<GClass65, bool>(class422.method_0));
                if (num4 == 0)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  num6 = list6.Count<GClass65>(new Func<GClass65, bool>(class422.class421_0.method_1));
                  if (num6 == 0)
                  {
                    // ISSUE: reference to a compiler-generated method
                    num7 = list6.Count<GClass65>(new Func<GClass65, bool>(class422.method_1));
                  }
                }
              }
            }
            num3 = num4 > 0 || num6 > 0 || num5 > 0 || num8 > 0 ? 1000.0 : (num7 <= 0 || this.genum95_0 < GEnum95.const_4 ? (list5.Count <= 0 ? 5.0 : 25.0) : 100.0);
          }
          if ((double) GClass226.smethod_13(1000) <= num3)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class420.class419_0.gclass85_0.gclass4_0.method_4(list7);
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 58);
    }
  }

  public void method_2(List<GClass85> list_0, List<GClass103> list_1, List<GClass65> list_2)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass3.Class423 class423 = new GClass3.Class423();
      // ISSUE: reference to a compiler-generated field
      class423.gclass3_0 = this;
      List<GClass65> list1 = list_2.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass200_0 == this.gclass202_0.gclass200_0)).ToList<GClass65>();
      if (list1.Count == 0)
        return;
      // ISSUE: reference to a compiler-generated field
      class423.list_0 = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass1_0 != null && gclass85_0.method_35())).SelectMany<GClass85, GClass40>((Func<GClass85, IEnumerable<GClass40>>) (gclass85_0 => (IEnumerable<GClass40>) gclass85_0.method_176())).ToList<GClass40>();
      // ISSUE: reference to a compiler-generated method
      List<GClass65> list2 = list1.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass40_0 != null)).Where<GClass65>(new Func<GClass65, bool>(class423.method_0)).ToList<GClass65>();
      List<GClass65> list3 = list1.Except<GClass65>((IEnumerable<GClass65>) list2).ToList<GClass65>();
      List<GClass39> list4 = list_1.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass146_0 != null)).Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass146_0.gclass202_0 == this.gclass202_0)).SelectMany<GClass103, GClass39>((Func<GClass103, IEnumerable<GClass39>>) (gclass103_0 => (IEnumerable<GClass39>) gclass103_0.list_0)).Where<GClass39>((Func<GClass39, bool>) (gclass39_0 => gclass39_0.gclass101_0.gclass230_0 != null && gclass39_0.list_0.Count < gclass39_0.int_1)).ToList<GClass39>();
      List<GClass85> list5 = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass202_0 == this.gclass202_0)).ToList<GClass85>();
      if (list5.Count == 0 && list4.Count == 0)
        return;
      List<GClass40> list6 = list5.SelectMany<GClass85, GClass40>((Func<GClass85, IEnumerable<GClass40>>) (gclass85_0 => (IEnumerable<GClass40>) gclass85_0.method_176())).Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.decimal_10 > 0M && gclass40_0.int_13 == 0)).OrderBy<GClass40, int>((Func<GClass40, int>) (gclass40_0 => gclass40_0.gclass85_0.int_3)).ThenByDescending<GClass40, Decimal>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14)).ToList<GClass40>();
      if (list6.Count == 0 && list4.Count == 0)
        return;
      // ISSUE: reference to a compiler-generated field
      class423.list_1 = list3.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.genum10_0 == GEnum10.const_0 && gclass65_0.auroraContactType_0 == AuroraContactType.Ship)).Select<GClass65, GClass40>((Func<GClass65, GClass40>) (gclass65_0 => gclass65_0.gclass40_0)).ToList<GClass40>();
      List<GClass132> list7 = list3.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.genum10_0 == GEnum10.const_0 && gclass65_0.auroraContactType_0 == AuroraContactType.Salvo)).Select<GClass65, GClass132>((Func<GClass65, GClass132>) (gclass65_0 => gclass65_0.gclass132_0)).ToList<GClass132>();
      List<GClass65> list8 = list3.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => (gclass65_0.genum10_0 == GEnum10.const_0 && (gclass65_0.auroraContactType_0 == AuroraContactType.STOGroundUnit || gclass65_0.auroraContactType_0 == AuroraContactType.Shipyard) || gclass65_0.auroraContactType_0 == AuroraContactType.Population) && gclass65_0.gclass146_0 != null)).ToList<GClass65>();
      // ISSUE: reference to a compiler-generated field
      if (class423.list_1.Count == 0 && list7.Count == 0 && list8.Count == 0)
        return;
      // ISSUE: reference to a compiler-generated field
      class423.gclass194_0 = this.gclass202_0.gclass21_0.method_164();
      // ISSUE: reference to a compiler-generated field
      if (this.gclass202_0.gclass21_0.genum6_0 == GEnum6.const_0 && class423.gclass194_0.int_2 < 50)
        list8 = list8.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.auroraContactType_0 == AuroraContactType.STOGroundUnit || gclass65_0.auroraContactType_0 == AuroraContactType.Shipyard || gclass65_0.gclass146_0.decimal_4 == 0M)).ToList<GClass65>();
      else if (this.gclass202_0.gclass21_0.genum6_0 == GEnum6.const_5 || this.gclass202_0.gclass21_0.genum6_0 == GEnum6.const_2)
        list8 = list8.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.auroraContactType_0 == AuroraContactType.STOGroundUnit || gclass65_0.auroraContactType_0 == AuroraContactType.Shipyard)).ToList<GClass65>();
      // ISSUE: reference to a compiler-generated field
      if (class423.gclass194_0.int_2 < 80 /*0x50*/)
      {
        // ISSUE: reference to a compiler-generated method
        list8 = list8.Where<GClass65>(new Func<GClass65, bool>(class423.method_1)).ToList<GClass65>();
      }
      List<GClass13> source1 = new List<GClass13>();
      foreach (GClass65 gclass65 in list8)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class424 class424 = new GClass3.Class424();
        // ISSUE: reference to a compiler-generated field
        class424.gclass65_0 = gclass65;
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class434 class434 = new GClass3.Class434();
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class434.gclass13_0 = source1.FirstOrDefault<GClass13>(new Func<GClass13, bool>(class424.method_0));
        // ISSUE: reference to a compiler-generated field
        if (class434.gclass13_0 == null)
        {
          // ISSUE: reference to a compiler-generated field
          class434.gclass13_0 = new GClass13(this.gclass0_0);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class434.gclass13_0.gclass146_0 = class424.gclass65_0.gclass146_0;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class434.gclass13_0.double_1 = class434.gclass13_0.gclass146_0.method_87();
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class434.gclass13_0.double_2 = class434.gclass13_0.gclass146_0.method_88();
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          class434.gclass13_0.gclass113_0 = class424.gclass65_0.gclass21_1.dictionary_13.Values.FirstOrDefault<GClass113>(new Func<GClass113, bool>(class434.method_0));
          // ISSUE: reference to a compiler-generated field
          source1.Add(class434.gclass13_0);
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (!class434.gclass13_0.dictionary_0.ContainsKey(class424.gclass65_0.auroraContactType_0))
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class434.gclass13_0.dictionary_0.Add(class424.gclass65_0.auroraContactType_0, class424.gclass65_0);
        }
      }
      foreach (GClass13 gclass13 in source1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class435 class435 = new GClass3.Class435();
        // ISSUE: reference to a compiler-generated field
        class435.class423_0 = class423;
        // ISSUE: reference to a compiler-generated field
        class435.gclass13_0 = gclass13;
        // ISSUE: reference to a compiler-generated method
        if (this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class435.method_0)).Sum<GClass146>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.method_190())) > 1000M)
        {
          // ISSUE: reference to a compiler-generated field
          class435.gclass13_0.bool_2 = true;
        }
        // ISSUE: reference to a compiler-generated field
        class435.gclass13_0.method_1();
        // ISSUE: reference to a compiler-generated field
        class435.gclass13_0.dictionary_0.ContainsKey(AuroraContactType.STOGroundUnit);
      }
      List<GClass13> list9 = source1.Where<GClass13>((Func<GClass13, bool>) (gclass13_0 => gclass13_0.double_0 > 0.0 && !gclass13_0.bool_1)).OrderByDescending<GClass13, double>((Func<GClass13, double>) (gclass13_0 => gclass13_0.double_0)).ToList<GClass13>();
      List<GClass85> list10 = list5.SelectMany<GClass85, GClass40>((Func<GClass85, IEnumerable<GClass40>>) (gclass85_0 => (IEnumerable<GClass40>) gclass85_0.method_176())).Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => this.gclass0_0.decimal_0 - gclass40_0.decimal_21 < 300M)).Select<GClass40, GClass85>((Func<GClass40, GClass85>) (gclass40_0 => gclass40_0.gclass85_0)).Distinct<GClass85>().ToList<GClass85>();
      List<GClass85> source2 = new List<GClass85>();
      if (list10.Count > 0)
      {
        foreach (GClass85 gclass85 in list10)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: reference to a compiler-generated method
          source2.AddRange((IEnumerable<GClass85>) list5.Where<GClass85>(new Func<GClass85, bool>(new GClass3.Class436()
          {
            class423_0 = class423,
            gclass85_0 = gclass85
          }.method_0)).ToList<GClass85>());
        }
        source2 = source2.Distinct<GClass85>().ToList<GClass85>();
      }
      foreach (GClass40 gclass40 in list6)
      {
        gclass40.gclass5_0.gclass71_0 = gclass40.method_213(0M, (GClass36) null);
        gclass40.gclass5_0.double_2 = gclass40.method_220();
        gclass40.gclass5_0.double_3 = gclass40.gclass5_0.gclass71_0.double_0;
        if (gclass40.gclass5_0.double_2 > gclass40.gclass5_0.double_3)
          gclass40.gclass5_0.double_3 = gclass40.gclass5_0.double_2;
        gclass40.gclass5_0.gclass72_0 = gclass40.method_214();
        if (gclass40.gclass5_0.gclass72_0 != null)
          gclass40.gclass5_0.double_4 = (double) gclass40.gclass5_0.gclass72_0.decimal_0;
        gclass40.gclass5_0.bool_0 = false;
        gclass40.int_17 = 0;
        if (gclass40.gclass22_0.gclass14_0.genum69_0 == GEnum69.const_3 && gclass40.list_12.Count == 0 && this.gclass0_0.decimal_0 - gclass40.gclass85_0.decimal_8 > 900M)
          gclass40.int_17 = 1;
      }
      List<GClass40> list11 = list6.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass5_0.double_3 > 0.0 || gclass40_0.gclass5_0.double_4 > 0.0)).ToList<GClass40>();
      if (list11.Count == 0 && list4.Count == 0)
        return;
      List<GClass120> list12 = this.gclass0_0.dictionary_12.Values.Where<GClass120>((Func<GClass120, bool>) (gclass120_0 => gclass120_0.gclass200_0 == this.gclass202_0.gclass200_0)).Where<GClass120>((Func<GClass120, bool>) (gclass120_0 => gclass120_0.dictionary_0.ContainsKey(this.gclass202_0.gclass21_0.RaceID))).Where<GClass120>((Func<GClass120, bool>) (gclass120_0 => gclass120_0.dictionary_0[this.gclass202_0.gclass21_0.RaceID].int_2 == 1)).ToList<GClass120>();
      // ISSUE: reference to a compiler-generated method
      List<GClass117> list13 = this.gclass202_0.gclass21_0.dictionary_12.Values.Where<GClass117>(new Func<GClass117, bool>(class423.method_2)).ToList<GClass117>();
      List<GClass116> gclass116List = new List<GClass116>();
      foreach (GClass117 gclass117 in list13)
      {
        gclass117.method_5();
        gclass117.method_4(gclass116List);
      }
      foreach (GClass116 gclass116 in gclass116List)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class437 class437 = new GClass3.Class437();
        Decimal num1 = gclass116.list_0.Sum<GClass117>((Func<GClass117, Decimal>) (gclass117_0 => gclass117_0.gclass115_0.gclass22_0.decimal_14));
        Decimal num2 = gclass116.list_0.Sum<GClass117>((Func<GClass117, Decimal>) (gclass117_0 => gclass117_0.gclass40_0.method_170()));
        gclass116.int_0 = (int) (num2 / num1 * 1000M);
        // ISSUE: reference to a compiler-generated field
        class437.list_0 = gclass116.list_0.Select<GClass117, GClass40>((Func<GClass117, GClass40>) (gclass117_0 => gclass117_0.gclass40_0)).ToList<GClass40>();
        // ISSUE: reference to a compiler-generated method
        gclass116.list_1 = this.gclass0_0.dictionary_6.Values.Where<GClass132>(new Func<GClass132, bool>(class437.method_0)).ToList<GClass132>();
        foreach (GClass120 gclass120 in list12)
        {
          if (this.gclass0_0.method_28(gclass120.double_1, gclass120.double_2, gclass116.double_0, gclass116.double_1) < (double) (gclass116.int_1 * 30))
          {
            gclass116.bool_2 = true;
            if (gclass116.list_1.Count > 0 && this.gclass0_0.decimal_0 - gclass116.list_1.Min<GClass132>((Func<GClass132, Decimal>) (gclass132_0 => gclass132_0.decimal_0)) > 30M)
              gclass116.bool_3 = true;
          }
        }
      }
      foreach (GClass40 gclass40 in list11.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass5_0.double_4 > 0.0)).ToList<GClass40>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class438 class438 = new GClass3.Class438();
        // ISSUE: reference to a compiler-generated field
        class438.class423_0 = class423;
        // ISSUE: reference to a compiler-generated field
        class438.gclass40_0 = gclass40;
        bool flag = false;
        // ISSUE: reference to a compiler-generated field
        if (class438.gclass40_0.gclass5_0.gclass72_0.list_0.Count <= 0)
        {
          double num3 = -1.0;
          double num4 = -1.0;
          if (list7.Count > 0)
          {
            // ISSUE: reference to a compiler-generated method
            num3 = list7.Min<GClass132>(new Func<GClass132, double>(class438.method_0));
          }
          if (gclass116List.Count > 0)
          {
            // ISSUE: reference to a compiler-generated method
            num4 = gclass116List.Min<GClass116>(new Func<GClass116, double>(class438.method_1));
          }
          if (num3 > -1.0 && num3 < 1000000.0 || num4 > -1.0 && num4 < (double) GClass226.int_14)
          {
            flag = true;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if ((num3 == -1.0 || num3 > 10000000.0) && num4 > -1.0 && num4 < class438.gclass40_0.gclass5_0.double_4 && class438.gclass40_0.gclass5_0.gclass72_0.list_1.Count == 0)
              flag = true;
          }
          if (flag)
          {
            // ISSUE: reference to a compiler-generated field
            foreach (GClass70 gclass70_0 in class438.gclass40_0.dictionary_0.Values)
            {
              // ISSUE: reference to a compiler-generated field
              if (class438.gclass40_0.gclass22_0.decimal_11 > 0M)
                gclass70_0.gclass40_0.gclass85_0.method_71(gclass70_0, GEnum105.const_83);
              else
                gclass70_0.gclass40_0.gclass85_0.method_71(gclass70_0, GEnum105.const_84);
            }
          }
        }
      }
      foreach (GClass40 gclass40 in list11)
      {
        if (gclass40.gclass5_0.gclass71_0.double_0 != 0.0 || gclass40.gclass5_0.double_4 != 0.0)
        {
          foreach (GClass116 gclass116 in gclass116List)
          {
            if (this.gclass0_0.method_28(gclass116.double_0, gclass116.double_1, gclass40.gclass85_0.double_2, gclass40.gclass85_0.double_3) < gclass40.gclass5_0.gclass71_0.double_0)
            {
              double num5 = 1.0;
              if (gclass116.int_0 > 0)
                num5 = (double) gclass40.gclass5_0.gclass71_0.int_2 / (double) gclass116.int_0 * (double) GClass226.int_9 / 100.0;
              if (num5 > 1.0)
                num5 = 1.0;
              int num6 = gclass40.gclass5_0.gclass71_0.int_0;
              if (num6 > gclass40.gclass5_0.gclass71_0.int_1)
                num6 = gclass40.gclass5_0.gclass71_0.int_1;
              gclass116.double_3 += (double) num6 * num5;
            }
          }
        }
      }
      foreach (GClass116 gclass116 in gclass116List)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class439 class439 = new GClass3.Class439();
        // ISSUE: reference to a compiler-generated field
        class439.gclass116_0 = gclass116;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (class439.gclass116_0.double_3 < class439.gclass116_0.double_2)
        {
          // ISSUE: reference to a compiler-generated field
          class439.gclass116_0.bool_0 = true;
          // ISSUE: reference to a compiler-generated method
          foreach (GClass13 gclass13 in list9.Where<GClass13>(new Func<GClass13, bool>(class439.method_0)).ToList<GClass13>())
            gclass13.bool_0 = true;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if ((double) class439.gclass116_0.int_2 < (double) class439.gclass116_0.list_0.Count / 2.0)
          {
            // ISSUE: reference to a compiler-generated field
            class439.gclass116_0.bool_1 = true;
          }
        }
      }
      List<GClass40> list14 = list11.OrderByDescending<GClass40, double>((Func<GClass40, double>) (gclass40_0 => gclass40_0.gclass5_0.gclass71_0.double_0)).ToList<GClass40>();
      foreach (GClass40 gclass40 in list14)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class440 class440 = new GClass3.Class440();
        // ISSUE: reference to a compiler-generated field
        class440.class423_0 = class423;
        // ISSUE: reference to a compiler-generated field
        class440.gclass40_0 = gclass40;
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class441 class441 = new GClass3.Class441();
        // ISSUE: reference to a compiler-generated field
        class441.class440_0 = class440;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        class441.class440_0.gclass40_0.method_94();
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (class441.class440_0.gclass40_0.list_4.Count != 0)
        {
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
          if (class441.class440_0.gclass40_0.gclass5_0.gclass71_0.double_0 > 0.0 && class441.class440_0.gclass40_0.gclass5_0.gclass71_0.int_0 > class441.class440_0.gclass40_0.gclass5_0.gclass71_0.int_1 && !source2.Contains(class441.class440_0.gclass40_0.gclass85_0) && class441.class440_0.gclass40_0.gclass85_0.dictionary_0.Count > 0 && class441.class440_0.gclass40_0.gclass85_0.method_255().gclass133_0.genum123_0 == GEnum123.const_12)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class441.class440_0.gclass40_0.gclass5_0.double_2 != 0.0)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              class441.class440_0.gclass40_0.gclass5_0.bool_0 = true;
            }
            else
              continue;
          }
          bool flag1 = false;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          class441.list_0 = class441.class440_0.class423_0.list_1.Where<GClass40>(new Func<GClass40, bool>(class441.class440_0.method_0)).ToList<GClass40>();
          // ISSUE: reference to a compiler-generated field
          if (class441.list_0.Count > 0)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class441.class440_0.gclass40_0.gclass21_0.genum6_0 == GEnum6.const_2)
            {
              // ISSUE: reference to a compiler-generated method
              List<GClass40> list15 = this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(class441.method_0)).Select<GClass103, GClass40>((Func<GClass103, GClass40>) (gclass103_0 => gclass103_0.gclass40_0)).Distinct<GClass40>().ToList<GClass40>();
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              class441.list_0 = class441.list_0.Except<GClass40>((IEnumerable<GClass40>) list15).ToList<GClass40>();
            }
            // ISSUE: reference to a compiler-generated field
            if (class441.list_0.Count > 0)
            {
              int num7 = 1;
              // ISSUE: reference to a compiler-generated method
              List<GClass117> list16 = list13.Where<GClass117>(new Func<GClass117, bool>(class441.method_1)).ToList<GClass117>();
              foreach (GClass117 gclass117 in list16)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                gclass117.method_6(class441.class440_0.gclass40_0);
              }
              List<GClass117> list17 = list16.OrderByDescending<GClass117, Decimal>((Func<GClass117, Decimal>) (gclass117_0 => gclass117_0.decimal_5)).ToList<GClass117>();
              while (true)
              {
                foreach (GClass117 gclass117 in list17)
                {
                  // ISSUE: object of a compiler-generated type is created
                  // ISSUE: variable of a compiler-generated type
                  GClass3.Class425 class425 = new GClass3.Class425();
                  // ISSUE: reference to a compiler-generated field
                  class425.class441_0 = class441;
                  // ISSUE: reference to a compiler-generated field
                  class425.gclass117_0 = gclass117;
                  bool flag2 = false;
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (class425.class441_0.class440_0.gclass40_0.gclass5_0.gclass71_0.double_0 > 0.0 && !class425.class441_0.class440_0.gclass40_0.gclass5_0.bool_0 && (!class425.gclass117_0.gclass116_0.bool_0 || class425.gclass117_0.double_2 < (double) GClass226.int_13 || num7 > 1))
                  {
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
                    if ((!class425.gclass117_0.gclass116_0.bool_3 || !class425.gclass117_0.gclass21_0.bool_0) && (!class425.gclass117_0.gclass116_0.bool_2 || class425.gclass117_0.gclass21_0.bool_0) || class425.class441_0.class440_0.gclass40_0.list_10.Count <= 0 || (double) class425.class441_0.class440_0.gclass40_0.list_10.Max<GClass130>((Func<GClass130, Decimal>) (gclass130_0 => gclass130_0.gclass129_0.decimal_5)) * 30.0 >= class425.gclass117_0.double_2)
                    {
                      // ISSUE: reference to a compiler-generated method
                      Decimal num8 = this.gclass0_0.dictionary_6.Values.Where<GClass132>(new Func<GClass132, bool>(class425.method_0)).Sum<GClass132>((Func<GClass132, Decimal>) (gclass132_0 => gclass132_0.gclass129_0.decimal_4 * (Decimal) gclass132_0.dictionary_2.Count));
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated method
                      if ((class425.gclass117_0.double_2 <= (double) GClass226.int_12 || !(num8 > 0M) || num7 >= 3 || !(this.gclass0_0.decimal_0 - class425.gclass117_0.gclass40_0.decimal_19 < (Decimal) GClass226.int_15)) && (!class425.gclass117_0.gclass116_0.bool_1 || class425.gclass117_0.double_2 <= (double) GClass226.int_13 || num7 != 1 || this.gclass0_0.dictionary_6.Values.Where<GClass132>(new Func<GClass132, bool>(class425.method_1)).Count<GClass132>() <= 0))
                      {
                        // ISSUE: reference to a compiler-generated method
                        Decimal num9 = list14.Sum<GClass40>(new Func<GClass40, Decimal>(class425.method_2));
                        // ISSUE: reference to a compiler-generated field
                        Decimal num10 = class425.gclass117_0.method_7() - num8 - num9;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        GClass129 gclass129 = class425.class441_0.class440_0.gclass40_0.list_10.Where<GClass130>((Func<GClass130, bool>) (gclass130_0 => gclass130_0.gclass129_0.int_14 == 0)).Select<GClass130, GClass129>((Func<GClass130, GClass129>) (gclass130_0 => gclass130_0.gclass129_0)).FirstOrDefault<GClass129>();
                        if (gclass129 != null)
                        {
                          double double_7 = 1.0;
                          // ISSUE: reference to a compiler-generated field
                          if (class425.gclass117_0.gclass40_0 != null)
                          {
                            // ISSUE: reference to a compiler-generated field
                            double_7 = gclass129.method_3(class425.gclass117_0.gclass40_0);
                          }
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          Decimal num11 = (Decimal) gclass129.method_0((double) class425.gclass117_0.int_1, double_7, class425.class441_0.class440_0.gclass40_0.double_0);
                          if (num11 > 0M && num11 < 80M)
                            num10 *= 80M / num11;
                        }
                        if (!(num10 <= 0M) || num7 != 1)
                        {
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          if (class425.class441_0.class440_0.gclass40_0.gclass5_0.method_1(class425.gclass117_0.gclass40_0, class425.gclass117_0.double_2))
                          {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (gclass129 == null || !(gclass129.decimal_4 < 3M) || class425.gclass117_0.gclass116_0.list_1.Count != 0 || class425.gclass117_0.double_2 <= (double) GClass226.int_13 || class425.gclass117_0.double_2 <= GClass226.double_12 * class425.class441_0.class440_0.gclass40_0.gclass5_0.double_5 || !(class425.gclass117_0.gclass40_0.gclass22_0.decimal_14 > 20M))
                            {
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              foreach (GClass36 gclass36 in class425.class441_0.class440_0.gclass40_0.list_4.Where<GClass36>((Func<GClass36, bool>) (gclass36_0 => gclass36_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MissileFireControl && gclass36_0.int_1 == 0)).ToList<GClass36>())
                              {
                                // ISSUE: object of a compiler-generated type is created
                                // ISSUE: variable of a compiler-generated type
                                GClass3.Class426 class426 = new GClass3.Class426();
                                // ISSUE: reference to a compiler-generated field
                                class426.gclass36_0 = gclass36;
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated method
                                List<GClass31> list18 = class425.class441_0.class440_0.gclass40_0.list_2.Where<GClass31>(new Func<GClass31, bool>(class426.method_0)).ToList<GClass31>();
                                if (list18.Count != 0)
                                {
                                  // ISSUE: reference to a compiler-generated field
                                  // ISSUE: reference to a compiler-generated field
                                  // ISSUE: reference to a compiler-generated field
                                  List<GClass31> source3 = class425.class441_0.class440_0.gclass40_0.method_20(list18);
                                  if (source3.Count != 0)
                                  {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    class426.gclass36_0.int_1 = class425.gclass117_0.gclass40_0.int_8;
                                    // ISSUE: reference to a compiler-generated field
                                    class426.gclass36_0.auroraContactType_0 = AuroraContactType.Ship;
                                    // ISSUE: reference to a compiler-generated field
                                    class426.gclass36_0.bool_0 = true;
                                    flag1 = true;
                                    if (source3.Sum<GClass31>((Func<GClass31, Decimal>) (gclass31_0 => gclass31_0.gclass230_0.decimal_3)) > num10)
                                    {
                                      foreach (GClass31 gclass31 in source3)
                                      {
                                        if (num10 <= 0M)
                                        {
                                          // ISSUE: reference to a compiler-generated field
                                          // ISSUE: reference to a compiler-generated field
                                          // ISSUE: reference to a compiler-generated field
                                          class425.class441_0.class440_0.gclass40_0.list_2.Remove(gclass31);
                                          flag2 = true;
                                        }
                                        num10 -= gclass31.gclass230_0.decimal_3;
                                      }
                                      if (flag2)
                                        break;
                                    }
                                  }
                                }
                              }
                            }
                            else
                              continue;
                          }
                        }
                        else
                          continue;
                      }
                      else
                        continue;
                    }
                    else
                      continue;
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (class425.class441_0.class440_0.gclass40_0.gclass5_0.double_2 > 0.0 && class425.class441_0.class440_0.gclass40_0.gclass5_0.double_2 > class425.gclass117_0.double_2)
                  {
                    // ISSUE: reference to a compiler-generated method
                    Decimal num12 = list14.Sum<GClass40>(new Func<GClass40, Decimal>(class425.method_3));
                    // ISSUE: reference to a compiler-generated field
                    Decimal num13 = class425.gclass117_0.method_8();
                    if (!(num13 - num12 <= 0M))
                    {
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      foreach (GClass36 gclass36 in class425.class441_0.class440_0.gclass40_0.list_4.Where<GClass36>((Func<GClass36, bool>) (gclass36_0 => gclass36_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.BeamFireControl && gclass36_0.int_1 == 0)).ToList<GClass36>())
                      {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        GClass3.Class427 class427 = new GClass3.Class427();
                        // ISSUE: reference to a compiler-generated field
                        class427.gclass36_0 = gclass36;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        List<GClass31> list19 = class425.class441_0.class440_0.gclass40_0.list_2.Where<GClass31>(new Func<GClass31, bool>(class427.method_0)).ToList<GClass31>();
                        // ISSUE: reference to a compiler-generated field
                        if (list19.Count != 0 && (double) list19.Select<GClass31, GClass230>((Func<GClass31, GClass230>) (gclass31_0 => gclass31_0.gclass230_0)).Max<GClass230>((Func<GClass230, int>) (gclass230_0 => gclass230_0.method_18())) > class425.gclass117_0.double_2)
                        {
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          class427.gclass36_0.int_1 = class425.gclass117_0.gclass40_0.int_8;
                          // ISSUE: reference to a compiler-generated field
                          class427.gclass36_0.auroraContactType_0 = AuroraContactType.Ship;
                          // ISSUE: reference to a compiler-generated field
                          class427.gclass36_0.bool_0 = true;
                          flag1 = true;
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          if (class425.class441_0.list_0.Count > num7)
                          {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            Decimal num14 = list14.Sum<GClass40>(class425.func_0 ?? (class425.func_0 = new Func<GClass40, Decimal>(class425.method_4)));
                            if (num13 <= num14)
                              break;
                          }
                        }
                      }
                    }
                    else
                      continue;
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (class425.class441_0.class440_0.gclass40_0.list_4.Count<GClass36>((Func<GClass36, bool>) (gclass36_0 => gclass36_0.int_1 == 0)) == 0)
                    break;
                }
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (!flag1 && num7 != 3 && source2.Contains(class441.class440_0.gclass40_0.gclass85_0))
                  ++num7;
                else
                  break;
              }
            }
          }
          if (!flag1)
          {
            if (list9.Count > 0)
            {
              int num15 = 1;
              while (true)
              {
                foreach (GClass13 gclass13 in list9)
                {
                  // ISSUE: object of a compiler-generated type is created
                  // ISSUE: variable of a compiler-generated type
                  GClass3.Class428 class428 = new GClass3.Class428()
                  {
                    gclass13_0 = gclass13
                  };
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  class428.gclass13_0.double_3 = this.gclass0_0.method_28(class441.class440_0.gclass40_0.gclass85_0.double_2, class441.class440_0.gclass40_0.gclass85_0.double_3, class428.gclass13_0.double_1, class428.gclass13_0.double_2);
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (class441.class440_0.gclass40_0.gclass5_0.gclass71_0.double_0 > 0.0 && !class441.class440_0.gclass40_0.gclass5_0.bool_0 && (!class428.gclass13_0.bool_0 || class428.gclass13_0.double_3 < (double) GClass226.int_13 || num15 > 1))
                  {
                    // ISSUE: reference to a compiler-generated method
                    Decimal num16 = this.gclass0_0.dictionary_6.Values.Where<GClass132>(new Func<GClass132, bool>(class428.method_0)).Sum<GClass132>((Func<GClass132, Decimal>) (gclass132_0 => gclass132_0.gclass129_0.decimal_4 * (Decimal) gclass132_0.dictionary_2.Count));
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class428.gclass13_0.double_3 <= (double) GClass226.int_12 || !(num16 > 0M) || num15 >= 3 || !(this.gclass0_0.decimal_0 - class428.gclass13_0.gclass146_0.decimal_79 < (Decimal) GClass226.int_15))
                    {
                      // ISSUE: reference to a compiler-generated method
                      Decimal num17 = list14.Sum<GClass40>(new Func<GClass40, Decimal>(class428.method_1));
                      // ISSUE: reference to a compiler-generated field
                      Decimal num18 = class428.gclass13_0.method_0() - num16 - num17;
                      if (!(num18 <= 0M) || num15 != 1)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class441.class440_0.gclass40_0.gclass5_0.method_2(class428.gclass13_0.double_3))
                        {
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          foreach (GClass36 gclass36 in class441.class440_0.gclass40_0.list_4.Where<GClass36>((Func<GClass36, bool>) (gclass36_0 => gclass36_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MissileFireControl && gclass36_0.int_1 == 0)).ToList<GClass36>())
                          {
                            // ISSUE: object of a compiler-generated type is created
                            // ISSUE: variable of a compiler-generated type
                            GClass3.Class429 class429 = new GClass3.Class429();
                            // ISSUE: reference to a compiler-generated field
                            class429.gclass36_0 = gclass36;
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            List<GClass31> list20 = class441.class440_0.gclass40_0.list_2.Where<GClass31>(new Func<GClass31, bool>(class429.method_0)).ToList<GClass31>();
                            if (list20.Count != 0)
                            {
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              class429.gclass36_0.int_1 = class428.gclass13_0.gclass146_0.int_6;
                              // ISSUE: reference to a compiler-generated field
                              // ISSUE: reference to a compiler-generated field
                              class429.gclass36_0.auroraContactType_0 = class428.gclass13_0.gclass65_0.auroraContactType_0;
                              // ISSUE: reference to a compiler-generated field
                              class429.gclass36_0.bool_0 = true;
                              flag1 = true;
                              num18 -= list20.Sum<GClass31>((Func<GClass31, Decimal>) (gclass31_0 => gclass31_0.gclass230_0.decimal_1));
                              if (num18 <= 0M)
                                break;
                            }
                          }
                        }
                      }
                      else
                        continue;
                    }
                    else
                      continue;
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (class441.class440_0.gclass40_0.gclass5_0.double_2 > 0.0 && class441.class440_0.gclass40_0.gclass5_0.double_2 > class428.gclass13_0.double_3)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    foreach (GClass36 gclass36 in class441.class440_0.gclass40_0.list_4.Where<GClass36>((Func<GClass36, bool>) (gclass36_0 => gclass36_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.BeamFireControl && gclass36_0.int_1 == 0)).ToList<GClass36>())
                    {
                      // ISSUE: object of a compiler-generated type is created
                      // ISSUE: variable of a compiler-generated type
                      GClass3.Class430 class430 = new GClass3.Class430();
                      // ISSUE: reference to a compiler-generated field
                      class430.gclass36_0 = gclass36;
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated method
                      List<GClass31> list21 = class441.class440_0.gclass40_0.list_2.Where<GClass31>(new Func<GClass31, bool>(class430.method_0)).ToList<GClass31>();
                      // ISSUE: reference to a compiler-generated field
                      if (list21.Count != 0 && (double) list21.Select<GClass31, GClass230>((Func<GClass31, GClass230>) (gclass31_0 => gclass31_0.gclass230_0)).Max<GClass230>((Func<GClass230, int>) (gclass230_0 => gclass230_0.method_18())) > class428.gclass13_0.double_3)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class430.gclass36_0.int_1 = class428.gclass13_0.gclass146_0.int_6;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class430.gclass36_0.auroraContactType_0 = class428.gclass13_0.gclass65_0.auroraContactType_0;
                        // ISSUE: reference to a compiler-generated field
                        class430.gclass36_0.bool_0 = true;
                        flag1 = true;
                      }
                    }
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (class441.class440_0.gclass40_0.list_4.Count<GClass36>((Func<GClass36, bool>) (gclass36_0 => gclass36_0.int_1 == 0)) == 0)
                    break;
                }
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (!flag1 && num15 != 3 && source2.Contains(class441.class440_0.gclass40_0.gclass85_0))
                  ++num15;
                else
                  break;
              }
            }
            if (!flag1 && list7.Where<GClass132>((Func<GClass132, bool>) (gclass132_0 => gclass132_0.double_9 == 0.0)).ToList<GClass132>().Count > 0)
            {
              foreach (GClass132 gclass132 in list7.Where<GClass132>((Func<GClass132, bool>) (gclass132_0 => gclass132_0.double_9 == 0.0)).ToList<GClass132>())
              {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class431 class431 = new GClass3.Class431();
                // ISSUE: reference to a compiler-generated field
                class431.gclass132_0 = gclass132;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                double num = this.gclass0_0.method_28(class441.class440_0.gclass40_0.gclass85_0.double_2, class441.class440_0.gclass40_0.gclass85_0.double_3, class431.gclass132_0.double_0, class431.gclass132_0.double_1);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class441.class440_0.gclass40_0.gclass5_0.double_2 > 0.0 && class441.class440_0.gclass40_0.gclass5_0.double_2 > num)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  foreach (GClass36 gclass36 in class441.class440_0.gclass40_0.list_4.Where<GClass36>((Func<GClass36, bool>) (gclass36_0 => gclass36_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.BeamFireControl && gclass36_0.int_1 == 0)).ToList<GClass36>())
                  {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GClass3.Class432 class432 = new GClass3.Class432();
                    // ISSUE: reference to a compiler-generated field
                    class432.gclass36_0 = gclass36;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    List<GClass31> list22 = class441.class440_0.gclass40_0.list_2.Where<GClass31>(new Func<GClass31, bool>(class432.method_0)).ToList<GClass31>();
                    if (list22.Count != 0 && (double) list22.Select<GClass31, GClass230>((Func<GClass31, GClass230>) (gclass31_0 => gclass31_0.gclass230_0)).Max<GClass230>((Func<GClass230, int>) (gclass230_0 => gclass230_0.method_18())) > num)
                    {
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      class432.gclass36_0.int_1 = class431.gclass132_0.int_1;
                      // ISSUE: reference to a compiler-generated field
                      class432.gclass36_0.auroraContactType_0 = AuroraContactType.Salvo;
                      // ISSUE: reference to a compiler-generated field
                      class432.gclass36_0.bool_0 = true;
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated method
                      list7 = list7.Where<GClass132>(class431.func_0 ?? (class431.func_0 = new Func<GClass132, bool>(class431.method_0))).ToList<GClass132>();
                      // ISSUE: reference to a compiler-generated field
                      list7.Add(class431.gclass132_0);
                    }
                  }
                }
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class441.class440_0.gclass40_0.list_4.Count<GClass36>((Func<GClass36, bool>) (gclass36_0 => gclass36_0.int_1 == 0)) == 0)
                  break;
              }
            }
          }
        }
      }
      if (list4.Count <= 0)
        return;
      AuroraTargetSelection auroraTargetSelection = AuroraTargetSelection.RandomShip;
      foreach (GClass39 gclass39 in list4)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class433 class433 = new GClass3.Class433()
        {
          class423_0 = class423,
          gclass39_0 = gclass39
        };
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class433.gclass39_0.auroraTargetSelection_0 = class433.class423_0.list_1.Where<GClass40>(new Func<GClass40, bool>(class433.method_0)).ToList<GClass40>().Count <= 0 ? AuroraTargetSelection.RangedDefensiveFire : auroraTargetSelection;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 59);
    }
  }

  public void method_3(List<GClass85> list_0, bool bool_0, bool bool_1)
  {
    try
    {
      List<GClass85> list1 = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass202_0 == this.gclass202_0)).ToList<GClass85>();
      if (!bool_0)
        list1 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass4_0.method_7() || gclass85_0.gclass4_0.genum100_0 < GEnum100.const_2)).ToList<GClass85>();
      List<GClass85> list2 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.method_195() > 1)).ToList<GClass85>();
      if (list2.Count == 0)
        return;
      foreach (GClass85 gclass85 in list2)
        gclass85.method_4();
      List<GClass85> list3 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.gclass21_1 == this.gclass202_0.gclass21_0 && gclass65_0.decimal_3 == this.gclass0_0.decimal_0 && gclass65_0.auroraContactType_0 == AuroraContactType.Ship && gclass65_0.gclass200_0 == this.gclass202_0.gclass200_0)).Select<GClass65, GClass85>((Func<GClass65, GClass85>) (gclass65_0 => gclass65_0.gclass40_0.gclass85_0)).Distinct<GClass85>().ToList<GClass85>();
      List<GClass146> list4 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.gclass21_1 == this.gclass202_0.gclass21_0 && gclass65_0.decimal_3 == this.gclass0_0.decimal_0 && gclass65_0.auroraContactType_0 == AuroraContactType.STOGroundUnit && gclass65_0.gclass200_0 == this.gclass202_0.gclass200_0)).Select<GClass65, GClass146>((Func<GClass65, GClass146>) (gclass65_0 => gclass65_0.gclass146_0)).Distinct<GClass146>().ToList<GClass146>();
      if (this.gclass202_0.gclass21_0.genum6_0 == GEnum6.const_5)
      {
        GClass210 gclass210_0_1 = this.gclass0_0.dictionary_16.Values.Where<GClass210>((Func<GClass210, bool>) (gclass210_0 => gclass210_0.gclass200_0 == this.gclass202_0.gclass200_0)).FirstOrDefault<GClass210>() ?? this.gclass202_0.gclass21_0.gclass2_0.method_2(this.gclass202_0.gclass200_0);
        foreach (GClass85 gclass85_0 in list2)
        {
          if (!this.method_4(gclass85_0, list3, list4, gclass210_0_1.double_0, gclass210_0_1.double_1, (double) GClass226.int_7) && gclass85_0.gclass4_0.int_0 <= 25)
          {
            ++gclass85_0.gclass4_0.int_0;
          }
          else
          {
            gclass85_0.method_263();
            if (bool_1)
            {
              if (gclass210_0_1.double_2 == 0.0)
              {
                gclass85_0.method_232(gclass210_0_1, GEnum123.const_0, gclass85_0.gclass202_0);
                gclass85_0.gclass4_0.bool_1 = true;
              }
              else if ((Decimal) this.gclass0_0.method_28(gclass85_0.double_2, gclass85_0.double_3, gclass210_0_1.double_0, gclass210_0_1.double_1) / (Decimal) gclass85_0.int_6 >= (Decimal) gclass210_0_1.double_2)
              {
                gclass85_0.method_232(gclass210_0_1, GEnum123.const_0, gclass85_0.gclass202_0);
                gclass85_0.gclass4_0.bool_1 = true;
              }
            }
            else
              gclass85_0.method_232(gclass210_0_1, GEnum123.const_1, gclass85_0.gclass202_0);
          }
        }
      }
      else
      {
        List<GClass120> gclass120List1 = new List<GClass120>();
        List<GClass120> gclass120List2 = this.genum96_0 != GEnum96.const_4 ? (this.genum96_0 != GEnum96.const_3 ? (this.genum96_0 != GEnum96.const_2 ? (this.genum96_0 != GEnum96.const_1 ? this.gclass202_0.method_38(true, GEnum96.const_0).Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => !gclass202_0.bool_6)).OrderByDescending<GClass202, GEnum95>((Func<GClass202, GEnum95>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0)).Select<GClass202, GClass120>((Func<GClass202, GClass120>) (gclass202_1 => gclass202_1.method_11(this.gclass202_0).gclass120_0)).ToList<GClass120>() : this.gclass202_0.method_38(true, GEnum96.const_0).OrderByDescending<GClass202, GEnum95>((Func<GClass202, GEnum95>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0)).Select<GClass202, GClass120>((Func<GClass202, GClass120>) (gclass202_1 => gclass202_1.method_11(this.gclass202_0).gclass120_0)).ToList<GClass120>()) : this.gclass202_0.method_38(true, GEnum96.const_1).OrderBy<GClass202, GEnum96>((Func<GClass202, GEnum96>) (gclass202_0 => gclass202_0.gclass3_0.genum96_0)).ThenByDescending<GClass202, GEnum95>((Func<GClass202, GEnum95>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0)).Select<GClass202, GClass120>((Func<GClass202, GClass120>) (gclass202_1 => gclass202_1.method_11(this.gclass202_0).gclass120_0)).ToList<GClass120>()) : this.gclass202_0.method_38(true, GEnum96.const_2).OrderBy<GClass202, GEnum96>((Func<GClass202, GEnum96>) (gclass202_0 => gclass202_0.gclass3_0.genum96_0)).ThenByDescending<GClass202, GEnum95>((Func<GClass202, GEnum95>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0)).Select<GClass202, GClass120>((Func<GClass202, GClass120>) (gclass202_1 => gclass202_1.method_11(this.gclass202_0).gclass120_0)).ToList<GClass120>()) : this.gclass202_0.method_38(true, GEnum96.const_3).OrderBy<GClass202, GEnum96>((Func<GClass202, GEnum96>) (gclass202_0 => gclass202_0.gclass3_0.genum96_0)).ThenByDescending<GClass202, GEnum95>((Func<GClass202, GEnum95>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0)).Select<GClass202, GClass120>((Func<GClass202, GClass120>) (gclass202_1 => gclass202_1.method_11(this.gclass202_0).gclass120_0)).ToList<GClass120>();
        if (gclass120List2.Count == 0 && bool_1)
          gclass120List2 = this.gclass202_0.method_38(true, GEnum96.const_4).OrderBy<GClass202, GEnum96>((Func<GClass202, GEnum96>) (gclass202_0 => gclass202_0.gclass3_0.genum96_0)).ThenByDescending<GClass202, GEnum95>((Func<GClass202, GEnum95>) (gclass202_0 => gclass202_0.gclass3_0.genum95_0)).Select<GClass202, GClass120>((Func<GClass202, GClass120>) (gclass202_1 => gclass202_1.method_11(this.gclass202_0).gclass120_0)).ToList<GClass120>();
        if (gclass120List2.Count > 0)
        {
          foreach (GClass85 gclass85_0 in list2)
          {
            gclass85_0.gclass4_0.bool_0 = gclass85_0.method_241();
            foreach (GClass120 gclass120_1 in gclass120List2)
            {
              if ((gclass120_1.int_2 != 0 || gclass85_0.gclass4_0.bool_0) && this.method_4(gclass85_0, list3, list4, gclass120_1.double_1, gclass120_1.double_2, (double) GClass226.int_7))
              {
                gclass85_0.method_263();
                gclass85_0.method_231(gclass120_1, GEnum123.const_0, this.gclass202_0);
                gclass85_0.gclass4_0.bool_1 = true;
              }
            }
          }
        }
      }
      List<GClass85> list5 = list2.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
      if (list5.Count == 0)
        return;
      List<GClass146> list6 = this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass202_0 == this.gclass202_0 && gclass146_0.gclass1_0.decimal_4 == 0M)).OrderByDescending<GClass146, GEnum97>((Func<GClass146, GEnum97>) (gclass146_0 => gclass146_0.gclass6_0.genum97_0)).ToList<GClass146>();
      if (list6.Count > 0)
      {
        foreach (GClass85 gclass85_0 in list5)
        {
          gclass85_0.gclass4_0.bool_0 = gclass85_0.method_241();
          foreach (GClass146 gclass146_1 in list6)
          {
            double double_0 = gclass146_1.method_87();
            double double_1 = gclass146_1.method_88();
            if (this.method_4(gclass85_0, list3, list4, double_0, double_1, (double) GClass226.int_7))
            {
              gclass85_0.method_263();
              gclass85_0.method_219(gclass146_1, GEnum123.const_1);
              gclass85_0.gclass4_0.bool_1 = true;
            }
          }
        }
      }
      List<GClass85> list7 = list5.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
      if (list7.Count == 0 || list3.Count <= 0)
        return;
      foreach (GClass85 gclass85_1 in list7)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class442 class442 = new GClass3.Class442();
        // ISSUE: reference to a compiler-generated field
        class442.gclass3_0 = this;
        // ISSUE: reference to a compiler-generated field
        class442.gclass85_0 = gclass85_1;
        // ISSUE: reference to a compiler-generated method
        GClass85 gclass85_2 = list3.OrderBy<GClass85, double>(new Func<GClass85, double>(class442.method_0)).FirstOrDefault<GClass85>();
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        double num = this.gclass0_0.method_28(class442.gclass85_0.double_2, class442.gclass85_0.double_3, gclass85_2.double_2, gclass85_2.double_3);
        GClass221 gclass221 = new GClass221(0.0, 0.0);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        GClass221 gclass221_0 = num <= 0.0 ? this.gclass0_0.method_592(class442.gclass85_0.double_2, class442.gclass85_0.double_3, 10000000.0, (double) (GClass226.smethod_13(360) - 1)) : this.gclass0_0.method_525(class442.gclass85_0.double_2, class442.gclass85_0.double_3, gclass85_2.double_2, gclass85_2.double_3, num * -10.0);
        // ISSUE: reference to a compiler-generated field
        if (list4.Count > 0 && class442.gclass85_0.gclass4_0.method_10(gclass221_0, list4))
          break;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        GClass214 gclass214_0 = class442.gclass85_0.gclass21_0.method_188(class442.gclass85_0.gclass202_0.gclass200_0, (GClass1) null, (GClass120) null, WayPointType.Temporary, gclass221_0.double_0, gclass221_0.double_1, class442.gclass85_0.FleetName + " Escape Point", 0);
        // ISSUE: reference to a compiler-generated field
        class442.gclass85_0.method_263();
        // ISSUE: reference to a compiler-generated field
        class442.gclass85_0.method_217(gclass214_0, GEnum123.const_1, this.gclass202_0);
        // ISSUE: reference to a compiler-generated field
        class442.gclass85_0.gclass4_0.bool_1 = true;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 60);
    }
  }

  public bool method_4(
    GClass85 gclass85_0,
    List<GClass85> list_0,
    List<GClass146> list_1,
    double double_0,
    double double_1,
    double double_2)
  {
    try
    {
      double num1 = 200000000.0;
      double num2 = 200000000.0;
      foreach (GClass85 gclass85 in list_0)
      {
        double num3 = this.gclass0_0.method_28(gclass85.double_2, gclass85.double_3, gclass85_0.double_2, gclass85_0.double_3);
        double num4 = this.gclass0_0.method_517(gclass85.double_2, gclass85.double_3, gclass85_0.double_2, gclass85_0.double_3, double_0, double_1);
        if (num4 < num1)
          num1 = num4;
        if (num3 < num2)
          num2 = num3;
      }
      if (num1 < double_2 && num1 < num2 * 0.8)
        return false;
      foreach (GClass146 gclass146 in list_1)
      {
        double num5 = this.gclass0_0.method_28(gclass146.method_87(), gclass146.method_88(), gclass85_0.double_2, gclass85_0.double_3);
        double num6 = this.gclass0_0.method_517(gclass146.method_87(), gclass146.method_88(), gclass85_0.double_2, gclass85_0.double_3, double_0, double_1);
        if (num6 < 1000000.0 && num6 < num5)
          return false;
      }
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 61);
      return false;
    }
  }

  public bool method_5(
    GClass85 gclass85_0,
    GClass85 gclass85_1,
    List<GClass85> list_0,
    List<GClass146> list_1,
    double double_0,
    Decimal decimal_2)
  {
    try
    {
      Decimal num1 = 0M;
      foreach (GClass85 gclass85 in list_0)
      {
        if (gclass85 != gclass85_1)
        {
          double num2 = this.gclass0_0.method_28(gclass85.double_2, gclass85.double_3, gclass85_0.double_2, gclass85_0.double_3);
          double num3 = this.gclass0_0.method_517(gclass85.double_2, gclass85.double_3, gclass85_0.double_2, gclass85_0.double_3, gclass85_1.double_2, gclass85_1.double_3);
          if (num3 < double_0 && num3 < num2 * 0.8)
            num1 += gclass85.decimal_7;
          if (num1 > decimal_2)
            return false;
        }
      }
      foreach (GClass146 gclass146 in list_1)
      {
        double num4 = this.gclass0_0.method_28(gclass146.method_87(), gclass146.method_88(), gclass85_0.double_2, gclass85_0.double_3);
        double num5 = this.gclass0_0.method_517(gclass146.method_87(), gclass146.method_88(), gclass85_0.double_2, gclass85_0.double_3, gclass85_1.double_2, gclass85_1.double_3);
        if (num5 < 1000000.0 && num5 < num4)
          return false;
      }
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 62);
      return false;
    }
  }

  public void method_6(List<GClass85> list_0)
  {
    try
    {
      if (list_0.Count == 0)
        return;
      List<GClass85> list1 = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum104_0 == GEnum104.const_22 && !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
      if (list1.Count == 0)
        return;
      foreach (GClass85 gclass85 in list1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class443 class443 = new GClass3.Class443();
        // ISSUE: reference to a compiler-generated field
        class443.gclass3_0 = this;
        // ISSUE: reference to a compiler-generated field
        class443.gclass85_0 = gclass85;
        List<GClass85> list2 = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum105_0 == GEnum105.const_30)).ToList<GClass85>();
        if (list2.Count > 0)
        {
          // ISSUE: reference to a compiler-generated method
          GClass85 gclass85_5 = list2.OrderBy<GClass85, double>(new Func<GClass85, double>(class443.method_0)).FirstOrDefault<GClass85>();
          GClass40 object_0 = gclass85_5.method_176().OrderByDescending<GClass40, Decimal>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14)).FirstOrDefault<GClass40>();
          if (object_0 == null)
          {
            this.gclass0_0.dictionary_1.Remove(gclass85_5.int_3);
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            class443.gclass85_0.method_263();
            // ISSUE: reference to a compiler-generated field
            class443.gclass85_0.method_223(gclass85_5, GEnum123.const_40, (object) object_0);
            // ISSUE: reference to a compiler-generated field
            class443.gclass85_0.gclass4_0.bool_1 = true;
            continue;
          }
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        GClass233 gclass233_0 = this.gclass202_0.gclass200_0.method_5(class443.gclass85_0.double_2, class443.gclass85_0.double_3, this.gclass202_0);
        if (gclass233_0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          class443.gclass85_0.method_263();
          // ISSUE: reference to a compiler-generated field
          class443.gclass85_0.method_216(gclass233_0, GEnum123.const_39, this.gclass202_0);
          // ISSUE: reference to a compiler-generated field
          class443.gclass85_0.gclass4_0.bool_1 = true;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          GClass146 gclass146_1 = this.gclass202_0.gclass200_0.method_6(class443.gclass85_0.double_2, class443.gclass85_0.double_3, this.gclass202_0);
          if (gclass146_1 != null)
          {
            // ISSUE: reference to a compiler-generated field
            class443.gclass85_0.method_263();
            // ISSUE: reference to a compiler-generated field
            class443.gclass85_0.method_219(gclass146_1, GEnum123.const_109);
            // ISSUE: reference to a compiler-generated field
            class443.gclass85_0.gclass4_0.bool_1 = true;
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 63 /*0x3F*/);
    }
  }

  public void method_7(List<GClass85> list_0, List<GClass202> list_1, List<GClass202> list_2)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass3.Class444 class444 = new GClass3.Class444();
      // ISSUE: reference to a compiler-generated field
      class444.gclass3_0 = this;
      List<GClass85> list1 = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass202_0 == this.gclass202_0)).ToList<GClass85>();
      if (list1.Count<GClass85>() == 0)
        return;
      this.decimal_0 = 0M;
      this.decimal_1 = 0M;
      if (this.genum96_0 == GEnum96.const_4)
      {
        foreach (GClass85 gclass85 in list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.int_1 == 1 && gclass85_0.gclass4_0.genum100_0 > GEnum100.const_0)).ToList<GClass85>())
        {
          gclass85.method_263();
          gclass85.gclass4_0.bool_1 = false;
        }
      }
      else
      {
        if (this.gclass202_0.gclass21_0.genum6_0 == GEnum6.const_5 && list_0.Count<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.decimal_1 > this.gclass0_0.decimal_0 - GClass226.decimal_32)) == 0 && this.gclass0_0.dictionary_28.Values.Count<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass21_1 == this.gclass202_0.gclass21_0 && gclass65_0.decimal_3 < this.gclass0_0.decimal_0 - GClass226.decimal_32 && gclass65_0.gclass200_0 == this.gclass202_0.gclass200_0)) == 0 && this.gclass0_0.dictionary_29.Values.Count<GClass233>((Func<GClass233, bool>) (gclass233_0 => gclass233_0.gclass200_0 == this.gclass202_0.gclass200_0)) == 0 && this.gclass0_0.dictionary_30.Values.Count<GClass59>((Func<GClass59, bool>) (gclass59_0 => gclass59_0.gclass200_0 == this.gclass202_0.gclass200_0)) == 0)
        {
          this.gclass202_0.gclass21_0.gclass2_0.method_33(list1, GEnum123.const_0);
          return;
        }
        list1 = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1 && gclass85_0.gclass202_0 == this.gclass202_0)).ToList<GClass85>();
      }
      List<GClass85> list2 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.bool_2)).ToList<GClass85>();
      List<GClass85> list3 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum104_0 == GEnum104.const_10)).ToList<GClass85>();
      List<GClass85> list4 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.bool_3)).ToList<GClass85>();
      List<GClass85> list5 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum104_0 == GEnum104.const_5)).ToList<GClass85>();
      List<GClass146> list6 = this.gclass202_0.method_46().OrderByDescending<GClass146, GEnum97>((Func<GClass146, GEnum97>) (gclass146_0 => gclass146_0.gclass6_0.genum97_0)).ThenByDescending<GClass146, int>((Func<GClass146, int>) (gclass146_0 => gclass146_0.gclass6_0.int_0)).ThenByDescending<GClass146, double>((Func<GClass146, double>) (gclass146_0 => gclass146_0.gclass6_0.double_2)).ToList<GClass146>();
      List<GClass39> list7 = this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass21_0 == this.gclass202_0.gclass21_0 && gclass103_0.gclass146_0 != null)).Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass146_0.gclass202_0 == this.gclass202_0)).SelectMany<GClass103, GClass39>((Func<GClass103, IEnumerable<GClass39>>) (gclass103_0 => (IEnumerable<GClass39>) gclass103_0.list_0)).Where<GClass39>((Func<GClass39, bool>) (gclass39_0 => gclass39_0.gclass101_0.genum115_0 == GEnum115.const_16 || gclass39_0.gclass101_0.genum115_0 == GEnum115.const_15)).ToList<GClass39>();
      List<GClass39> list8 = this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass21_0 == this.gclass202_0.gclass21_0 && gclass103_0.gclass146_0 != null)).Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass146_0.gclass202_0 == this.gclass202_0)).SelectMany<GClass103, GClass39>((Func<GClass103, IEnumerable<GClass39>>) (gclass103_0 => (IEnumerable<GClass39>) gclass103_0.list_0)).Where<GClass39>((Func<GClass39, bool>) (gclass39_0 => gclass39_0.gclass101_0.genum115_0 == GEnum115.const_15)).ToList<GClass39>();
      // ISSUE: reference to a compiler-generated field
      class444.list_1 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.gclass21_1 == this.gclass202_0.gclass21_0 && gclass65_0.decimal_3 == this.gclass0_0.decimal_0 && gclass65_0.auroraContactType_0 == AuroraContactType.Ship && gclass65_0.gclass200_0 == this.gclass202_0.gclass200_0)).Select<GClass65, GClass40>((Func<GClass65, GClass40>) (gclass65_0 => gclass65_0.gclass40_0)).Distinct<GClass40>().ToList<GClass40>();
      // ISSUE: reference to a compiler-generated field
      List<GClass85> list9 = class444.list_1.Select<GClass40, GClass85>((Func<GClass40, GClass85>) (gclass40_0 => gclass40_0.gclass85_0)).Distinct<GClass85>().ToList<GClass85>();
      // ISSUE: reference to a compiler-generated field
      class444.list_0 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.gclass21_1 == this.gclass202_0.gclass21_0 && gclass65_0.decimal_3 > this.gclass0_0.decimal_0 - GClass226.decimal_34 && gclass65_0.auroraContactType_0 == AuroraContactType.Ship && gclass65_0.gclass200_0 == this.gclass202_0.gclass200_0)).Select<GClass65, GClass40>((Func<GClass65, GClass40>) (gclass65_0 => gclass65_0.gclass40_0)).Distinct<GClass40>().ToList<GClass40>();
      // ISSUE: reference to a compiler-generated field
      List<GClass85> list10 = class444.list_0.Select<GClass40, GClass85>((Func<GClass40, GClass85>) (gclass40_0 => gclass40_0.gclass85_0)).Distinct<GClass85>().ToList<GClass85>();
      List<GClass146> list11 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.gclass21_1 == this.gclass202_0.gclass21_0 && gclass65_0.decimal_3 == this.gclass0_0.decimal_0 && gclass65_0.auroraContactType_0 == AuroraContactType.STOGroundUnit && gclass65_0.gclass200_0 == this.gclass202_0.gclass200_0)).Select<GClass65, GClass146>((Func<GClass65, GClass146>) (gclass65_0 => gclass65_0.gclass146_0)).Distinct<GClass146>().ToList<GClass146>();
      // ISSUE: reference to a compiler-generated field
      class444.gclass210_0 = this.gclass0_0.dictionary_16.Values.FirstOrDefault<GClass210>((Func<GClass210, bool>) (gclass210_0 => gclass210_0.gclass200_0 == this.gclass202_0.gclass200_0));
      List<GClass132> list12 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.gclass21_1 == this.gclass202_0.gclass21_0 && this.gclass0_0.decimal_0 == gclass65_0.decimal_3 && gclass65_0.gclass200_0 == this.gclass202_0.gclass200_0 && gclass65_0.auroraContactType_0 == AuroraContactType.Salvo)).Select<GClass65, GClass132>((Func<GClass65, GClass132>) (gclass65_0 => gclass65_0.gclass132_0)).Distinct<GClass132>().ToList<GClass132>();
      if (list12.Count > 0)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class445 class445 = new GClass3.Class445();
        // ISSUE: reference to a compiler-generated field
        class445.class444_0 = class444;
        // ISSUE: reference to a compiler-generated field
        class445.int_0 = 60;
        // ISSUE: reference to a compiler-generated field
        class445.list_0 = this.gclass0_0.dictionary_12.Values.Where<GClass120>((Func<GClass120, bool>) (gclass120_0 => gclass120_0.gclass200_0 == this.gclass202_0.gclass200_0)).Where<GClass120>((Func<GClass120, bool>) (gclass120_0 => gclass120_0.dictionary_0.ContainsKey(this.gclass202_0.gclass21_0.RaceID))).Where<GClass120>((Func<GClass120, bool>) (gclass120_0 => gclass120_0.dictionary_0[this.gclass202_0.gclass21_0.RaceID].int_2 == 1)).ToList<GClass120>();
        // ISSUE: reference to a compiler-generated method
        List<GClass85> list13 = list1.Where<GClass85>(new Func<GClass85, bool>(class445.method_0)).ToList<GClass85>();
        List<GClass85> gclass85List = new List<GClass85>();
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (class445.class444_0.gclass210_0 != null && this.gclass202_0.gclass21_0.genum6_0 == GEnum6.const_5)
        {
          // ISSUE: reference to a compiler-generated method
          gclass85List = list1.Where<GClass85>(new Func<GClass85, bool>(class445.method_1)).ToList<GClass85>();
        }
        if (list13.Count > 0 || gclass85List.Count > 0)
        {
          foreach (GClass85 gclass85 in list13)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass3.Class450 class450 = new GClass3.Class450();
            // ISSUE: reference to a compiler-generated field
            class450.class445_0 = class445;
            // ISSUE: reference to a compiler-generated field
            class450.gclass85_0 = gclass85;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            List<GClass132> source = class450.gclass85_0.method_21(list12, class450.class445_0.int_0);
            if (source.Count > 0)
            {
              // ISSUE: object of a compiler-generated type is created
              // ISSUE: variable of a compiler-generated type
              GClass3.Class451 class451 = new GClass3.Class451();
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              class451.gclass132_0 = source.OrderByDescending<GClass132, double>(new Func<GClass132, double>(class450.method_0)).FirstOrDefault<GClass132>();
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if ((double) source.Where<GClass132>(new Func<GClass132, bool>(class451.method_0)).Sum<GClass132>((Func<GClass132, int>) (gclass132_0 => gclass132_0.dictionary_2.Count)) > class450.gclass85_0.method_20((int) class451.gclass132_0.gclass129_0.decimal_5))
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                GClass120 gclass120_1 = class450.class445_0.list_0.OrderBy<GClass120, double>(new Func<GClass120, double>(class450.method_1)).FirstOrDefault<GClass120>();
                // ISSUE: reference to a compiler-generated field
                class450.gclass85_0.method_263();
                // ISSUE: reference to a compiler-generated field
                class450.gclass85_0.method_231(gclass120_1, GEnum123.const_0, this.gclass202_0);
                // ISSUE: reference to a compiler-generated field
                class450.gclass85_0.gclass4_0.bool_1 = true;
              }
            }
          }
          foreach (GClass85 gclass85 in gclass85List)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass3.Class452 class452 = new GClass3.Class452();
            // ISSUE: reference to a compiler-generated field
            class452.class445_0 = class445;
            // ISSUE: reference to a compiler-generated field
            class452.gclass85_0 = gclass85;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            List<GClass132> source = class452.gclass85_0.method_21(list12, class452.class445_0.int_0);
            if (source.Count > 0)
            {
              // ISSUE: object of a compiler-generated type is created
              // ISSUE: variable of a compiler-generated type
              GClass3.Class453 class453 = new GClass3.Class453();
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              class453.gclass132_0 = source.OrderByDescending<GClass132, double>(new Func<GClass132, double>(class452.method_0)).FirstOrDefault<GClass132>();
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if ((double) source.Where<GClass132>(new Func<GClass132, bool>(class453.method_0)).Sum<GClass132>((Func<GClass132, int>) (gclass132_0 => gclass132_0.dictionary_2.Count)) > class452.gclass85_0.method_20((int) class453.gclass132_0.gclass129_0.decimal_5))
              {
                // ISSUE: reference to a compiler-generated field
                class452.gclass85_0.method_263();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class452.gclass85_0.method_232(class452.class445_0.class444_0.gclass210_0, GEnum123.const_0, this.gclass202_0);
                // ISSUE: reference to a compiler-generated field
                class452.gclass85_0.gclass4_0.bool_1 = true;
              }
            }
          }
          list2 = list2.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
          list5 = list5.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
          list3 = list3.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
        }
      }
      List<GClass85> list14 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass4_0.genum103_0 < GEnum103.const_2)).ToList<GClass85>();
      if (list14.Count > 0)
      {
        this.gclass202_0.gclass21_0.gclass2_0.method_35(list14, list6, list11, true);
        list2 = list2.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
        list5 = list5.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
        list3 = list3.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
      }
      // ISSUE: reference to a compiler-generated field
      if (class444.list_0.Count > 0)
      {
        foreach (GClass85 gclass85 in list2)
          gclass85.method_7();
        this.decimal_0 = list2.Sum<GClass85>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.decimal_7));
        // ISSUE: reference to a compiler-generated field
        this.decimal_1 = class444.list_0.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => !gclass40_0.gclass22_0.bool_2)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_2 * (Decimal) gclass40_0.gclass22_0.int_32));
        // ISSUE: reference to a compiler-generated method
        List<GClass117> list15 = this.gclass202_0.gclass21_0.dictionary_12.Values.Where<GClass117>(new Func<GClass117, bool>(class444.method_0)).OrderByDescending<GClass117, Decimal>((Func<GClass117, Decimal>) (gclass117_0 => gclass117_0.gclass115_0.gclass22_0.decimal_14)).ToList<GClass117>();
        // ISSUE: reference to a compiler-generated method
        List<GClass117> list16 = this.gclass202_0.gclass21_0.dictionary_12.Values.Where<GClass117>(new Func<GClass117, bool>(class444.method_1)).OrderByDescending<GClass117, Decimal>((Func<GClass117, Decimal>) (gclass117_0 => gclass117_0.gclass115_0.gclass22_0.decimal_14)).ToList<GClass117>();
        if (list15.Count > 0)
        {
          List<GClass85> list17 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => this.gclass0_0.decimal_0 - gclass85_0.decimal_8 < 120M)).Distinct<GClass85>().ToList<GClass85>();
          List<GClass85> list18 = list1.SelectMany<GClass85, GClass40>((Func<GClass85, IEnumerable<GClass40>>) (gclass85_0 => (IEnumerable<GClass40>) gclass85_0.method_176())).Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => this.gclass0_0.decimal_0 - gclass40_0.decimal_20 < 120M)).Select<GClass40, GClass85>((Func<GClass40, GClass85>) (gclass40_0 => gclass40_0.gclass85_0)).Distinct<GClass85>().ToList<GClass85>();
          if (list17.Count > 0)
          {
            foreach (GClass85 gclass85_1 in list17)
            {
              // ISSUE: object of a compiler-generated type is created
              // ISSUE: variable of a compiler-generated type
              GClass3.Class454 class454 = new GClass3.Class454();
              // ISSUE: reference to a compiler-generated field
              class454.class444_0 = class444;
              // ISSUE: reference to a compiler-generated field
              class454.gclass85_0 = gclass85_1;
              // ISSUE: reference to a compiler-generated field
              List<GClass40> source = class454.gclass85_0.method_176();
              // ISSUE: reference to a compiler-generated method
              int num1 = list1.Where<GClass85>(new Func<GClass85, bool>(class454.method_0)).SelectMany<GClass85, GClass40>((Func<GClass85, IEnumerable<GClass40>>) (gclass85_0 => (IEnumerable<GClass40>) gclass85_0.method_176())).Count<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.decimal_10 > 0M && gclass40_0.gclass5_0.genum99_0 > GEnum99.const_0));
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (num1 != 0 && class454.gclass85_0.gclass4_0.genum100_0 != GEnum100.const_0 && class454.gclass85_0.gclass4_0.genum102_0 != GEnum102.const_0 && class454.gclass85_0.gclass4_0.genum103_0 != GEnum103.const_0)
              {
                if (source.Count<GClass40>((Func<GClass40, bool>) (gclass40_0 => this.gclass0_0.decimal_0 - gclass40_0.decimal_20 < 120M)) > 0 && list9.Count > 0)
                {
                  // ISSUE: object of a compiler-generated type is created
                  // ISSUE: variable of a compiler-generated type
                  GClass3.Class456 class456 = new GClass3.Class456();
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  class456.gclass85_0 = list9.OrderBy<GClass85, double>(new Func<GClass85, double>(class454.method_2)).FirstOrDefault<GClass85>();
                  // ISSUE: reference to a compiler-generated field
                  if (class456.gclass85_0 != null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class454.gclass85_0.int_6 > class456.gclass85_0.int_6)
                    {
                      // ISSUE: reference to a compiler-generated method
                      GClass117 gclass117_0_1 = list16.Where<GClass117>(new Func<GClass117, bool>(class456.method_0)).OrderByDescending<GClass117, Decimal>((Func<GClass117, Decimal>) (gclass117_0 => gclass117_0.gclass115_0.gclass22_0.decimal_14)).FirstOrDefault<GClass117>();
                      // ISSUE: reference to a compiler-generated field
                      if (class454.gclass85_0.gclass4_0.method_9(gclass117_0_1, list11))
                      {
                        // ISSUE: reference to a compiler-generated field
                        class454.gclass85_0.gclass4_0.bool_1 = true;
                        continue;
                      }
                    }
                    else
                    {
                      // ISSUE: reference to a compiler-generated field
                      if (class454.gclass85_0.gclass9_0.int_1 == 0)
                      {
                        // ISSUE: reference to a compiler-generated method
                        List<GClass40> list19 = source.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.decimal_10 > 0M && gclass40_0.gclass5_0.genum99_0 > GEnum99.const_0 && gclass40_0.gclass22_0.gclass14_0.genum75_0 > GEnum75.const_0)).Where<GClass40>(new Func<GClass40, bool>(class456.method_1)).ToList<GClass40>();
                        if (list19.Count > 0)
                        {
                          // ISSUE: reference to a compiler-generated field
                          GClass85 gclass85_2 = class454.gclass85_0.method_76(list19, GEnum105.const_25, true);
                          gclass85_2.gclass4_0.method_17();
                          list2.Add(gclass85_2);
                          // ISSUE: reference to a compiler-generated method
                          GClass117 gclass117_0_2 = list16.Where<GClass117>(new Func<GClass117, bool>(class456.method_2)).OrderByDescending<GClass117, Decimal>((Func<GClass117, Decimal>) (gclass117_0 => gclass117_0.gclass115_0.gclass22_0.decimal_14)).FirstOrDefault<GClass117>();
                          if (gclass85_2.gclass4_0.method_9(gclass117_0_2, list11))
                          {
                            gclass85_2.gclass4_0.bool_1 = true;
                            continue;
                          }
                        }
                      }
                    }
                  }
                }
                if (source.Count<GClass40>((Func<GClass40, bool>) (gclass40_0 => this.gclass0_0.decimal_0 - gclass40_0.decimal_19 < 120M)) > 0)
                {
                  // ISSUE: object of a compiler-generated type is created
                  // ISSUE: variable of a compiler-generated type
                  GClass3.Class457 class457 = new GClass3.Class457();
                  bool flag = true;
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  class457.gclass146_0 = list6.FirstOrDefault<GClass146>(new Func<GClass146, bool>(class454.method_3));
                  // ISSUE: reference to a compiler-generated field
                  if (class457.gclass146_0 != null)
                  {
                    // ISSUE: reference to a compiler-generated method
                    if (list8.Count<GClass39>(new Func<GClass39, bool>(class457.method_0)) > 0)
                    {
                      flag = false;
                    }
                    else
                    {
                      // ISSUE: reference to a compiler-generated method
                      if (list1.Count<GClass85>(new Func<GClass85, bool>(class454.method_4)) > 0)
                        flag = false;
                    }
                  }
                  if (flag && list9.Count > 0)
                  {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GClass3.Class446 class446 = new GClass3.Class446();
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    class446.gclass85_0 = list9.OrderBy<GClass85, double>(new Func<GClass85, double>(class454.method_5)).FirstOrDefault<GClass85>();
                    // ISSUE: reference to a compiler-generated field
                    if (class446.gclass85_0 != null)
                    {
                      // ISSUE: reference to a compiler-generated method
                      GClass117 gclass117_0_3 = list16.Where<GClass117>(new Func<GClass117, bool>(class446.method_0)).OrderByDescending<GClass117, Decimal>((Func<GClass117, Decimal>) (gclass117_0 => gclass117_0.gclass115_0.gclass22_0.decimal_14)).FirstOrDefault<GClass117>();
                      // ISSUE: reference to a compiler-generated field
                      if (class454.gclass85_0.gclass4_0.method_9(gclass117_0_3, list11))
                      {
                        // ISSUE: reference to a compiler-generated field
                        class454.gclass85_0.gclass4_0.bool_1 = true;
                      }
                    }
                  }
                }
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                if (list18.Contains(class454.gclass85_0))
                {
                  // ISSUE: reference to a compiler-generated field
                  if (this.gclass202_0.gclass21_0.genum6_0 != GEnum6.const_1 && this.gclass202_0.gclass21_0.genum6_0 != GEnum6.const_3 && this.gclass202_0.gclass21_0.genum6_0 != GEnum6.const_2 && !class454.gclass85_0.bool_17)
                  {
                    // ISSUE: reference to a compiler-generated field
                    if (class454.gclass85_0.decimal_3 < this.gclass0_0.decimal_0 - 120M)
                    {
                      // ISSUE: reference to a compiler-generated field
                      class454.gclass85_0.decimal_3 = this.gclass0_0.decimal_0;
                      int num2 = source.Select<GClass40, GClass194>((Func<GClass40, GClass194>) (gclass40_0 => gclass40_0.gclass194_0)).Max<GClass194>((Func<GClass194, int>) (gclass194_0 => gclass194_0.int_7));
                      int num3 = source.Select<GClass40, GClass194>((Func<GClass40, GClass194>) (gclass40_0 => gclass40_0.gclass194_0)).Max<GClass194>((Func<GClass194, int>) (gclass194_0 => gclass194_0.int_2));
                      double num4 = (double) (200 - num2 - num3) / 10.0;
                      double num5 = (double) (num2 + num3) / 10.0;
                      if (num1 == 0 && (double) GClass226.smethod_13(100) < num4)
                      {
                        // ISSUE: reference to a compiler-generated method
                        GClass21 gclass21_1 = list15.Select<GClass117, GClass85>((Func<GClass117, GClass85>) (gclass117_0 => gclass117_0.gclass40_0.gclass85_0)).Distinct<GClass85>().OrderBy<GClass85, double>(new Func<GClass85, double>(class454.method_1)).Select<GClass85, GClass21>((Func<GClass85, GClass21>) (gclass85_0 => gclass85_0.gclass21_0)).FirstOrDefault<GClass21>();
                        foreach (GClass40 gclass40 in source)
                          gclass40.method_61(gclass21_1);
                      }
                      else if ((double) GClass226.smethod_13(100) < num5)
                      {
                        // ISSUE: reference to a compiler-generated field
                        class454.gclass85_0.bool_17 = true;
                      }
                    }
                  }
                  else
                  {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: reference to a compiler-generated method
                    List<GClass117> list20 = this.gclass202_0.gclass21_0.dictionary_12.Values.Where<GClass117>(new Func<GClass117, bool>(new GClass3.Class455()
                    {
                      list_0 = this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass21_0 == this.gclass202_0.gclass21_0 && gclass103_0.gclass40_0 != null)).Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass40_0.gclass21_0 != this.gclass202_0.gclass21_0)).Select<GClass103, GClass40>((Func<GClass103, GClass40>) (gclass103_0 => gclass103_0.gclass40_0)).Distinct<GClass40>().ToList<GClass40>()
                    }.method_0)).ToList<GClass117>();
                    List<GClass117> list21 = list16.Except<GClass117>((IEnumerable<GClass117>) list20).ToList<GClass117>();
                    if (list21.Count > 0)
                    {
                      // ISSUE: reference to a compiler-generated field
                      class454.gclass85_0.gclass4_0.method_1(list21);
                    }
                  }
                }
              }
            }
            list2 = list2.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
            list5 = list5.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
            list3 = list3.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
          }
          List<GClass117> list22 = list16.Where<GClass117>((Func<GClass117, bool>) (gclass117_0 => gclass117_0.gclass40_0.int_15 > 0)).ToList<GClass117>();
          if (list22.Count > 0)
          {
            foreach (GClass85 gclass85 in list2.Concat<GClass85>((IEnumerable<GClass85>) list3).ToList<GClass85>())
            {
              // ISSUE: object of a compiler-generated type is created
              // ISSUE: object of a compiler-generated type is created
              // ISSUE: variable of a compiler-generated type
              GClass3.Class448 class448 = new GClass3.Class448()
              {
                class447_0 = new GClass3.Class447()
                {
                  class444_0 = class444,
                  gclass85_0 = gclass85
                }
              };
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              class448.double_0 = (double) (class448.class447_0.gclass85_0.method_195() * 120) + class448.class447_0.gclass85_0.method_159();
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              GClass117 gclass117_0 = list22.Where<GClass117>(new Func<GClass117, bool>(class448.method_0)).OrderBy<GClass117, double>(new Func<GClass117, double>(class448.class447_0.method_0)).FirstOrDefault<GClass117>();
              if (gclass117_0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class448.class447_0.gclass85_0.gclass4_0.method_9(gclass117_0, list11);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class448.class447_0.gclass85_0.gclass4_0.bool_1 = true;
              }
            }
            list2 = list2.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
            list3 = list3.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
          }
          if (list16.Count == 1)
          {
            this.method_15(list2.OrderBy<GClass85, Decimal>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.decimal_7)).ToList<GClass85>(), list16[0], list11);
            this.method_12(list16[0], list5);
            list2 = list2.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
          }
          else if (list9.Count > 0)
          {
            foreach (GClass85 gclass85 in list10)
            {
              gclass85.method_7();
              gclass85.gclass85_4 = (GClass85) null;
            }
            int num = 0;
            bool flag = false;
            if (this.gclass202_0.gclass21_0.genum6_0 == GEnum6.const_1 && list6.Count == 0)
              this.method_10(list9, list11, list2, true);
            else if (this.gclass202_0.gclass21_0.genum6_0 == GEnum6.const_5)
            {
              if (this.decimal_0 < this.decimal_1 * 2M)
              {
                // ISSUE: reference to a compiler-generated field
                flag = this.gclass202_0.gclass21_0.gclass2_0.method_0(class444.gclass210_0, this.decimal_1 * 2M - this.decimal_0);
                this.method_3(list1, true, !flag);
              }
              else
                num = this.method_10(list9, list11, list2, false);
            }
            else if (this.decimal_1 > this.decimal_0 * 2M)
              this.method_13(list1, list2, list3, list4, list15, list6, list11, list7, this.decimal_1, this.decimal_0);
            else if (this.decimal_1 > this.decimal_0)
            {
              if (list10.Count == 1)
                this.method_13(list1, list2, list3, list4, list15, list6, list11, list7, this.decimal_1, this.decimal_0);
              else
                num = this.method_10(list9, list11, list2, false);
            }
            else
              num = this.method_10(list9, list11, list2, false);
            list2 = list2.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
            if (list2.Count > 0 || num == 0)
            {
              if (this.gclass202_0.gclass21_0.genum6_0 == GEnum6.const_5)
                this.method_3(list2, true, !flag);
              else if (num == 0)
                this.method_13(list1, list2, list3, list4, list15, list6, list11, list7, this.decimal_1, this.decimal_0);
              else
                this.method_14(list2, list9, list11, list6);
              this.gclass202_0.gclass21_0.gclass2_0.method_13(list2);
            }
            if (list5.Count > 0)
              this.method_11(list9, list5);
          }
          if (this.gclass202_0.gclass21_0.genum6_0 != GEnum6.const_5)
          {
            List<GClass85> list23 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass4_0.genum103_0 < GEnum103.const_3 && gclass85_0.dictionary_0.Count == 0)).ToList<GClass85>();
            foreach (GClass85 gclass85 in list23)
              gclass85.gclass4_0.bool_1 = false;
            this.gclass202_0.gclass21_0.gclass2_0.method_35(list23, list6, list11, true);
          }
          list2 = list2.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
          list5 = list5.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
          list3 = list3.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
        }
        new List<GClass202>() { this.gclass202_0 };
      }
      if (this.gclass202_0.gclass21_0.genum6_0 == GEnum6.const_2)
      {
        this.method_8(list1, list2, list_2, GEnum104.const_23);
        this.method_8(list1, list2, list_2, GEnum104.const_1);
        this.method_8(list1, list2, list_2, GEnum104.const_21);
        this.method_6(list1);
        this.method_9(list_0);
      }
      if (this.gclass202_0.gclass21_0.genum6_0 != GEnum6.const_5)
      {
        this.method_8(list1, list3, list_2, GEnum104.const_10);
        this.method_8(list1, list2, list_2, GEnum104.const_1);
        this.method_8(list1, list2, list_2, GEnum104.const_6);
        if (list5.Count > 0 || list2.Count > 0)
          this.method_20(list2, list5);
      }
      else
      {
        List<GClass85> list24 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum104_0 == GEnum104.const_27 && gclass85_0.gclass4_0.genum100_0 == GEnum100.const_2)).ToList<GClass85>();
        List<GClass85> list25 = list1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum105_0 == GEnum105.const_63 && gclass85_0.gclass4_0.genum100_0 == GEnum100.const_2)).ToList<GClass85>();
        int num = list1.Count<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.int_1 == 1 && gclass85_0.gclass4_0.genum100_0 > GEnum100.const_0));
        if (list24.Count > 0)
        {
          foreach (GClass85 gclass85 in list24)
          {
            if (gclass85.method_149() <= 0M)
            {
              gclass85.method_263();
              // ISSUE: reference to a compiler-generated field
              gclass85.method_232(class444.gclass210_0, GEnum123.const_0, gclass85.gclass202_0);
              gclass85.gclass4_0.bool_1 = true;
            }
          }
          List<GClass85> list26 = list24.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
          this.method_21(list26, list6);
          this.method_20(list2, list26);
          if (num == 0)
          {
            foreach (GClass85 gclass85 in list26)
            {
              gclass85.method_263();
              // ISSUE: reference to a compiler-generated field
              gclass85.method_232(class444.gclass210_0, GEnum123.const_0, gclass85.gclass202_0);
              gclass85.gclass4_0.bool_1 = true;
            }
          }
        }
        if (list25.Count > 0)
        {
          foreach (GClass85 gclass85 in list25)
          {
            if ((Decimal) gclass85.method_147() <= 0M)
            {
              gclass85.method_263();
              // ISSUE: reference to a compiler-generated field
              gclass85.method_232(class444.gclass210_0, GEnum123.const_0, gclass85.gclass202_0);
              gclass85.gclass4_0.bool_1 = true;
            }
          }
          this.method_22(list25, list6);
          if (num == 0)
          {
            foreach (GClass85 gclass85 in list25)
            {
              gclass85.method_263();
              // ISSUE: reference to a compiler-generated field
              gclass85.method_232(class444.gclass210_0, GEnum123.const_0, gclass85.gclass202_0);
              gclass85.gclass4_0.bool_1 = true;
            }
          }
        }
        List<GClass85> list27 = list2.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1 && gclass85_0.gclass9_0.genum105_0 == GEnum105.const_60 && gclass85_0.double_10 == 0.0)).ToList<GClass85>();
        if (list27.Count > 0)
        {
          this.method_18(list_0, list27, list9, true);
        }
        else
        {
          List<GClass85> list28 = list2.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 =>
          {
            if (gclass85_0.gclass4_0.bool_1 || gclass85_0.double_10 != 0.0)
              return false;
            return gclass85_0.gclass9_0.genum105_0 == GEnum105.const_61 || gclass85_0.gclass9_0.genum105_0 == GEnum105.const_62;
          })).OrderBy<GClass85, GEnum105>((Func<GClass85, GEnum105>) (gclass85_0 => gclass85_0.gclass9_0.genum105_0)).ToList<GClass85>();
          if (list28.Count > 0)
            this.method_18(list_0, list28, list9, false);
        }
        list2 = list2.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
      }
      if (list2.Count > 0)
      {
        foreach (GClass85 gclass85 in list2.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum105_0 == GEnum105.const_84)).ToList<GClass85>())
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass3.Class449 class449 = new GClass3.Class449();
          // ISSUE: reference to a compiler-generated field
          class449.class444_0 = class444;
          // ISSUE: reference to a compiler-generated field
          class449.gclass85_0 = gclass85;
          // ISSUE: reference to a compiler-generated field
          List<GClass40> list29 = class449.gclass85_0.method_176().Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass40_1 != null)).Select<GClass40, GClass40>((Func<GClass40, GClass40>) (gclass40_0 => gclass40_0.gclass40_1)).Distinct<GClass40>().ToList<GClass40>();
          if (list29.Count != 0)
          {
            // ISSUE: reference to a compiler-generated method
            GClass40 gclass40 = list29.OrderBy<GClass40, double>(new Func<GClass40, double>(class449.method_0)).FirstOrDefault<GClass40>();
            // ISSUE: reference to a compiler-generated field
            class449.gclass85_0.method_263();
            // ISSUE: reference to a compiler-generated field
            class449.gclass85_0.method_222(gclass40.gclass85_0, GEnum123.const_15);
            // ISSUE: reference to a compiler-generated field
            class449.gclass85_0.gclass4_0.bool_1 = true;
          }
        }
        list2 = list2.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
      }
      if (list6.Count > 0 && list2.Count > 0 && this.gclass202_0.gclass21_0.genum6_0 != GEnum6.const_2)
        this.method_23(list6, list2);
      if (this.gclass202_0.gclass21_0.genum6_0 != GEnum6.const_5)
      {
        if (list5.Count > 0)
        {
          List<GClass85> list30 = list5.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.double_10 == 0.0)).ToList<GClass85>();
          this.method_18(list_0, list30, list9, true);
        }
        else
        {
          List<GClass85> list31 = list2.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1 && gclass85_0.double_10 == 0.0 && gclass85_0.gclass9_0.genum105_0 == GEnum105.const_6)).ToList<GClass85>();
          this.method_18(list_0, list31, list9, false);
          list2.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
        }
      }
      List<GClass85> list32 = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1 && gclass85_0.gclass202_0 == this.gclass202_0 && gclass85_0.double_10 > 0.0)).ToList<GClass85>();
      if (this.gclass202_0.gclass21_0.genum6_0 == GEnum6.const_1)
        list32 = list32.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.bool_1)).ToList<GClass85>();
      if (list32.Count > 0)
        this.method_3(list32, true, false);
      List<GClass85> list33 = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 =>
      {
        if (gclass85_0.gclass4_0.bool_1 || gclass85_0.gclass202_0 != this.gclass202_0)
          return false;
        return gclass85_0.gclass9_0.bool_2 || gclass85_0.gclass9_0.genum104_0 == GEnum104.const_5 || gclass85_0.gclass9_0.genum104_0 == GEnum104.const_10;
      })).ToList<GClass85>();
      if (list33.Count <= 0)
        return;
      if (list6.Count > 0)
      {
        foreach (GClass85 gclass85 in list33)
        {
          if (gclass85.double_2 != list6[0].method_87() || gclass85.double_3 != list6[0].method_88())
            gclass85.method_219(list6[0], GEnum123.const_6);
        }
      }
      else
      {
        if (this.gclass202_0.gclass21_0.genum6_0 == GEnum6.const_1)
        {
          GClass1 gclass1_1 = this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.gclass200_0 == this.gclass202_0.gclass200_0)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.int_10 > 0)).OrderByDescending<GClass1, int>((Func<GClass1, int>) (gclass1_0 => gclass1_0.int_10)).FirstOrDefault<GClass1>();
          if (gclass1_1 != null)
          {
            using (List<GClass85>.Enumerator enumerator = list33.GetEnumerator())
            {
              while (enumerator.MoveNext())
                enumerator.Current.method_215(gclass1_1, GEnum123.const_1);
              return;
            }
          }
        }
        GClass85 gclass85_5 = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum104_0 == GEnum104.const_18 && gclass85_0.gclass202_0 == this.gclass202_0 && gclass85_0.gclass1_0 != null)).OrderByDescending<GClass85, int>((Func<GClass85, int>) (gclass85_0 => gclass85_0.method_179())).FirstOrDefault<GClass85>();
        if (gclass85_5 != null)
        {
          foreach (GClass85 gclass85 in list33)
            gclass85.method_222(gclass85_5, GEnum123.const_100);
        }
        else
        {
          foreach (GClass85 gclass85 in list33)
          {
            GClass1 gclass1_1 = this.gclass202_0.gclass200_0.method_23(gclass85.double_2, gclass85.double_3);
            if (gclass1_1 != null)
              gclass85.method_215(gclass1_1, GEnum123.const_1);
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 64 /*0x40*/);
    }
  }

  public void method_8(
    List<GClass85> list_0,
    List<GClass85> list_1,
    List<GClass202> list_2,
    GEnum104 genum104_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass3.Class458 class458 = new GClass3.Class458();
    // ISSUE: reference to a compiler-generated field
    class458.genum104_0 = genum104_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      if (list_1.FirstOrDefault<GClass85>(new Func<GClass85, bool>(class458.method_0)) == null)
        return;
      // ISSUE: reference to a compiler-generated field
      this.gclass202_0.gclass21_0.gclass2_0.method_47(this.gclass202_0, list_2, list_0, class458.genum104_0, false);
      // ISSUE: reference to a compiler-generated field
      this.gclass202_0.gclass21_0.gclass2_0.method_47(this.gclass202_0, list_2, list_0, class458.genum104_0, true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 65);
    }
  }

  public void method_9(List<GClass85> list_0)
  {
    try
    {
      List<GClass85> list = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass202_0 == this.gclass202_0)).ToList<GClass85>();
      if (list.Count == 0)
        return;
      foreach (GClass85 gclass85_1 in list.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum104_0 == GEnum104.const_24)).ToList<GClass85>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class459 class459 = new GClass3.Class459();
        // ISSUE: reference to a compiler-generated field
        class459.gclass3_0 = this;
        // ISSUE: reference to a compiler-generated field
        class459.gclass85_0 = gclass85_1;
        // ISSUE: reference to a compiler-generated method
        GClass85 gclass85_5 = list.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum104_0 == GEnum104.const_22)).OrderBy<GClass85, double>(new Func<GClass85, double>(class459.method_0)).FirstOrDefault<GClass85>();
        if (gclass85_5 != null)
        {
          // ISSUE: reference to a compiler-generated field
          class459.gclass85_0.method_263();
          // ISSUE: reference to a compiler-generated field
          class459.gclass85_0.method_222(gclass85_5, GEnum123.const_15);
          // ISSUE: reference to a compiler-generated field
          class459.gclass85_0.gclass4_0.bool_1 = true;
        }
        else
        {
          // ISSUE: reference to a compiler-generated method
          foreach (GClass85 gclass85_2 in this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass21_0 == this.gclass202_0.gclass21_0 && gclass85_0.gclass9_0.genum104_0 == GEnum104.const_22)).OrderBy<GClass85, int>(new Func<GClass85, int>(class459.method_1)).ToList<GClass85>())
          {
            // ISSUE: reference to a compiler-generated field
            if (class459.gclass85_0.method_236(GEnum109.const_41, "", false, gclass85_2.gclass202_0.gclass200_0.int_0, false).gclass202_0 != null)
            {
              // ISSUE: reference to a compiler-generated field
              class459.gclass85_0.gclass4_0.bool_1 = true;
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 66);
    }
  }

  public int method_10(
    List<GClass85> list_0,
    List<GClass146> list_1,
    List<GClass85> list_2,
    bool bool_0)
  {
    try
    {
      if (list_0.Count == 0)
        return 0;
      int num1 = 0;
      list_2 = list_2.OrderByDescending<GClass85, Decimal>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.decimal_7)).ToList<GClass85>();
      foreach (GClass85 gclass85_1 in list_2)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class460 class460 = new GClass3.Class460();
        // ISSUE: reference to a compiler-generated field
        class460.gclass85_0 = gclass85_1;
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class461 class461 = new GClass3.Class461();
        // ISSUE: reference to a compiler-generated field
        class461.class460_0 = class460;
        foreach (GClass85 gclass85_2 in list_0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          gclass85_2.double_8 = this.gclass0_0.method_30(this.gclass202_0.gclass200_0, class461.class460_0.gclass85_0.double_2, class461.class460_0.gclass85_0.double_3, gclass85_2.double_2, gclass85_2.double_3);
          double num2 = (GClass226.double_9 - gclass85_2.double_8) / GClass226.double_9;
          if (num2 < 0.1)
            num2 = 0.1;
          gclass85_2.double_9 = num2 * (double) gclass85_2.decimal_7;
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        GClass85 gclass85_3 = list_0.Where<GClass85>(new Func<GClass85, bool>(class461.class460_0.method_0)).OrderBy<GClass85, double>((Func<GClass85, double>) (gclass85_0 => gclass85_0.double_8)).FirstOrDefault<GClass85>();
        if (gclass85_3 != null)
        {
          GClass117 gclass117_0 = this.gclass202_0.gclass21_0.method_267(gclass85_3.method_176().OrderByDescending<GClass40, Decimal>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14)).FirstOrDefault<GClass40>());
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class461.class460_0.gclass85_0.gclass4_0.method_9(gclass117_0, list_1);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class461.class460_0.gclass85_0.gclass4_0.bool_1 = true;
          ++num1;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          gclass85_3.gclass85_4 = class461.class460_0.gclass85_0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          class461.decimal_0 = 0.5M;
          while (true)
          {
            List<GClass85> source = list_0;
            // ISSUE: reference to a compiler-generated field
            Func<GClass85, bool> func0 = class461.func_0;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            Func<GClass85, bool> predicate = func0 == null ? (class461.func_0 = new Func<GClass85, bool>(class461.method_0)) : func0;
            foreach (GClass85 gclass85_1_1 in source.Where<GClass85>(predicate).OrderByDescending<GClass85, double>((Func<GClass85, double>) (gclass85_0 => gclass85_0.double_9)).ToList<GClass85>())
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (this.method_5(class461.class460_0.gclass85_0, gclass85_1_1, list_0, list_1, GClass226.double_10, class461.class460_0.gclass85_0.decimal_7 * class461.decimal_0))
              {
                GClass117 gclass117_0 = this.gclass202_0.gclass21_0.method_267(gclass85_1_1.method_176().OrderByDescending<GClass40, Decimal>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14)).FirstOrDefault<GClass40>());
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class461.class460_0.gclass85_0.gclass4_0.method_9(gclass117_0, list_1);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class461.class460_0.gclass85_0.gclass4_0.bool_1 = true;
                ++num1;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                gclass85_1_1.gclass85_4 = class461.class460_0.gclass85_0;
                break;
              }
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (bool_0 && !class461.class460_0.gclass85_0.gclass4_0.bool_1 && !(class461.decimal_0 == 1M))
            {
              // ISSUE: reference to a compiler-generated field
              class461.decimal_0 += 0.1M;
            }
            else
              break;
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (!class461.class460_0.gclass85_0.gclass4_0.bool_1)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            foreach (GClass85 gclass85_1_2 in list_0.Where<GClass85>(new Func<GClass85, bool>(class461.class460_0.method_1)).OrderByDescending<GClass85, double>((Func<GClass85, double>) (gclass85_0 => gclass85_0.double_9)).ToList<GClass85>())
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              double num3 = this.gclass0_0.method_28(gclass85_1_2.double_2, gclass85_1_2.double_3, class461.class460_0.gclass85_0.double_2, class461.class460_0.gclass85_0.double_3);
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (this.gclass0_0.method_28(gclass85_1_2.double_2, gclass85_1_2.double_3, gclass85_1_2.gclass85_4.double_2, gclass85_1_2.gclass85_4.double_3) <= num3 && this.method_5(class461.class460_0.gclass85_0, gclass85_1_2, list_0, list_1, GClass226.double_10, class461.class460_0.gclass85_0.decimal_7))
              {
                GClass117 gclass117_0 = this.gclass202_0.gclass21_0.method_267(gclass85_1_2.method_176().OrderByDescending<GClass40, Decimal>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14)).FirstOrDefault<GClass40>());
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class461.class460_0.gclass85_0.gclass4_0.method_9(gclass117_0, list_1);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class461.class460_0.gclass85_0.gclass4_0.bool_1 = true;
                ++num1;
                break;
              }
            }
          }
        }
      }
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 67);
      return 0;
    }
  }

  public void method_11(List<GClass85> list_0, List<GClass85> list_1)
  {
    try
    {
      if (list_1.Count == 0)
        return;
      list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass85_4 == null)).OrderByDescending<GClass85, Decimal>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.decimal_7)).ToList<GClass85>();
      foreach (GClass85 gclass85_1 in list_0)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class462 class462 = new GClass3.Class462();
        // ISSUE: reference to a compiler-generated field
        class462.gclass3_0 = this;
        // ISSUE: reference to a compiler-generated field
        class462.gclass85_0 = gclass85_1;
        // ISSUE: reference to a compiler-generated method
        GClass85 gclass85_2 = list_1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).OrderBy<GClass85, double>(new Func<GClass85, double>(class462.method_0)).FirstOrDefault<GClass85>();
        if (gclass85_2 == null)
          break;
        // ISSUE: reference to a compiler-generated field
        GClass117 gclass117_0 = this.gclass202_0.gclass21_0.method_267(class462.gclass85_0.method_176().OrderByDescending<GClass40, Decimal>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14)).FirstOrDefault<GClass40>());
        gclass85_2.gclass4_0.method_11(gclass117_0);
        gclass85_2.gclass4_0.bool_1 = true;
        list_1 = list_1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 68);
    }
  }

  public void method_12(GClass117 gclass117_0, List<GClass85> list_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass3.Class463 class463 = new GClass3.Class463();
    // ISSUE: reference to a compiler-generated field
    class463.gclass3_0 = this;
    // ISSUE: reference to a compiler-generated field
    class463.gclass117_0 = gclass117_0;
    try
    {
      if (list_0.Count == 0)
        return;
      // ISSUE: reference to a compiler-generated method
      GClass85 gclass85 = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).OrderBy<GClass85, double>(new Func<GClass85, double>(class463.method_0)).FirstOrDefault<GClass85>();
      if (gclass85 == null)
        return;
      // ISSUE: reference to a compiler-generated field
      gclass85.gclass4_0.method_11(class463.gclass117_0);
      gclass85.gclass4_0.bool_1 = true;
      list_0 = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 69);
    }
  }

  public void method_13(
    List<GClass85> list_0,
    List<GClass85> list_1,
    List<GClass85> list_2,
    List<GClass85> list_3,
    List<GClass117> list_4,
    List<GClass146> list_5,
    List<GClass146> list_6,
    List<GClass39> list_7,
    Decimal decimal_2,
    Decimal decimal_3)
  {
    try
    {
      if (list_5.Count > 0)
      {
        List<GClass1> list1 = list_6.Select<GClass146, GClass1>((Func<GClass146, GClass1>) (gclass146_0 => gclass146_0.gclass1_0)).Distinct<GClass1>().ToList<GClass1>();
        foreach (GClass146 gclass146 in list_5)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass3.Class464 class464 = new GClass3.Class464();
          // ISSUE: reference to a compiler-generated field
          class464.gclass146_0 = gclass146;
          // ISSUE: reference to a compiler-generated field
          if (class464.gclass146_0.gclass6_0.genum97_0 > GEnum97.const_2)
          {
            // ISSUE: reference to a compiler-generated method
            List<GClass85> list2 = list_3.Where<GClass85>(new Func<GClass85, bool>(class464.method_0)).ToList<GClass85>();
            // ISSUE: reference to a compiler-generated method
            List<GClass39> list3 = list_7.Where<GClass39>(new Func<GClass39, bool>(class464.method_1)).ToList<GClass39>();
            // ISSUE: reference to a compiler-generated field
            if ((list2.Count != 0 || list3.Count != 0) && !list1.Contains(class464.gclass146_0.gclass1_0))
            {
              Decimal num = decimal_3;
              if (list2.Count > 0)
                num += list2.SelectMany<GClass85, GClass40>((Func<GClass85, IEnumerable<GClass40>>) (gclass85_0 => (IEnumerable<GClass40>) gclass85_0.method_176())).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_2 * 5000M));
              if (list3.Count > 0)
                num += list3.Sum<GClass39>((Func<GClass39, Decimal>) (gclass39_0 => gclass39_0.gclass101_0.decimal_2 * 100M));
              if (!(decimal_2 > num * 1.5M))
              {
                // ISSUE: reference to a compiler-generated field
                this.method_16(list_1, class464.gclass146_0);
                // ISSUE: reference to a compiler-generated field
                this.method_16(list_2, class464.gclass146_0);
                this.method_3(list_0.Except<GClass85>((IEnumerable<GClass85>) list_1).Except<GClass85>((IEnumerable<GClass85>) list_2).Except<GClass85>((IEnumerable<GClass85>) list_3).ToList<GClass85>(), true, false);
                return;
              }
            }
          }
          else
            break;
        }
      }
      this.method_3(list_0.Except<GClass85>((IEnumerable<GClass85>) list_3).ToList<GClass85>(), true, false);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 70);
    }
  }

  public void method_14(
    List<GClass85> list_0,
    List<GClass85> list_1,
    List<GClass146> list_2,
    List<GClass146> list_3)
  {
    try
    {
      foreach (GClass85 gclass85_0 in list_0)
      {
        foreach (GClass146 gclass146_1 in list_3)
        {
          double double_0 = gclass146_1.method_87();
          double double_1 = gclass146_1.method_88();
          if (this.method_4(gclass85_0, list_1, list_2, double_0, double_1, (double) GClass226.int_7))
          {
            gclass85_0.method_263();
            gclass85_0.method_219(gclass146_1, GEnum123.const_1);
            gclass85_0.gclass4_0.bool_1 = true;
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3413);
    }
  }

  public bool method_15(List<GClass85> list_0, GClass117 gclass117_0, List<GClass146> list_1)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass3.Class465 class465 = new GClass3.Class465();
    // ISSUE: reference to a compiler-generated field
    class465.gclass3_0 = this;
    // ISSUE: reference to a compiler-generated field
    class465.gclass117_0 = gclass117_0;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass3.Class466 class466 = new GClass3.Class466();
      // ISSUE: reference to a compiler-generated field
      class466.decimal_0 = 0M;
      // ISSUE: reference to a compiler-generated field
      if (!class465.gclass117_0.gclass40_0.gclass22_0.bool_2)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        class466.decimal_0 = class465.gclass117_0.gclass40_0.gclass22_0.decimal_2 * (Decimal) class465.gclass117_0.gclass40_0.gclass22_0.int_32;
      }
      if (list_0.Count > 0)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        GClass85 gclass85 = list_0.Where<GClass85>(new Func<GClass85, bool>(class466.method_0)).OrderBy<GClass85, double>(new Func<GClass85, double>(class465.method_0)).FirstOrDefault<GClass85>();
        if (gclass85 != null)
        {
          // ISSUE: reference to a compiler-generated field
          gclass85.gclass4_0.method_9(class465.gclass117_0, list_1);
          gclass85.gclass4_0.bool_1 = true;
          return true;
        }
      }
      return false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 71);
      return false;
    }
  }

  public void method_16(List<GClass85> list_0, GClass146 gclass146_0)
  {
    try
    {
      foreach (GClass85 gclass85 in list_0)
      {
        if (gclass85.double_2 == gclass146_0.method_87() && gclass85.double_3 == gclass146_0.method_88())
        {
          gclass85.gclass4_0.bool_1 = true;
        }
        else
        {
          gclass85.method_219(gclass146_0, GEnum123.const_6);
          gclass85.gclass4_0.bool_1 = true;
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 72);
    }
  }

  public void method_17(List<GClass85> list_0, GClass117 gclass117_0, List<GClass146> list_1)
  {
    try
    {
      foreach (GClass85 gclass85 in list_0)
      {
        gclass85.gclass4_0.method_9(gclass117_0, list_1);
        gclass85.gclass4_0.bool_1 = true;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 73);
    }
  }

  public void method_18(
    List<GClass85> list_0,
    List<GClass85> list_1,
    List<GClass85> list_2,
    bool bool_0)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass3.Class467 class467 = new GClass3.Class467();
      List<GClass214> list1 = this.gclass0_0.dictionary_13.Values.Where<GClass214>((Func<GClass214, bool>) (gclass214_0 =>
      {
        if (gclass214_0.gclass200_0 != this.gclass202_0.gclass200_0 || gclass214_0.gclass21_0 != this.gclass202_0.gclass21_0)
          return false;
        return gclass214_0.wayPointType_0 == WayPointType.UrgentPOI || gclass214_0.wayPointType_0 == WayPointType.POI;
      })).ToList<GClass214>();
      if (list1.Count == 0)
        return;
      if (bool_0 && list_2.Count > 0)
      {
        foreach (GClass214 gclass214 in list1.ToList<GClass214>())
        {
          foreach (GClass85 gclass85 in list_2)
          {
            if (this.gclass0_0.method_28(gclass214.double_0, gclass214.double_1, gclass85.double_2, gclass85.double_3) < (double) GClass226.int_7)
            {
              list1.Remove(gclass214);
              break;
            }
          }
        }
      }
      if (list1.Count == 0)
        return;
      // ISSUE: reference to a compiler-generated field
      class467.list_0 = list_0.SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>((Func<GClass139, bool>) (gclass139_0 => gclass139_0.genum13_0 == GEnum13.const_3 && gclass139_0.gclass202_0 == this.gclass202_0)).Select<GClass139, int>((Func<GClass139, int>) (gclass139_0 => gclass139_0.int_2)).ToList<int>();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      class467.list_1 = list1.Where<GClass214>(new Func<GClass214, bool>(class467.method_0)).ToList<GClass214>();
      foreach (GClass85 gclass85_0 in list_1)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        List<GClass214> list2 = list1.Where<GClass214>(class467.func_0 ?? (class467.func_0 = new Func<GClass214, bool>(class467.method_1))).Where<GClass214>(class467.func_1 ?? (class467.func_1 = new Func<GClass214, bool>(class467.method_2))).ToList<GClass214>();
        if (list2.Count != 0 && !this.method_19(gclass85_0, list2, WayPointType.UrgentPOI, 20))
          this.method_19(gclass85_0, list2, WayPointType.POI, 20);
      }
      list_1 = list_1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1 && gclass85_0.gclass9_0.genum104_0 == GEnum104.const_5)).ToList<GClass85>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 74);
    }
  }

  public bool method_19(
    GClass85 gclass85_0,
    List<GClass214> list_0,
    WayPointType wayPointType_0,
    int int_4)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass3.Class468 class468 = new GClass3.Class468();
    // ISSUE: reference to a compiler-generated field
    class468.wayPointType_0 = wayPointType_0;
    // ISSUE: reference to a compiler-generated field
    class468.gclass3_0 = this;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass3.Class469 class469 = new GClass3.Class469();
      // ISSUE: reference to a compiler-generated field
      class469.class468_0 = class468;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      List<GClass214> list = list_0.Where<GClass214>(new Func<GClass214, bool>(class469.class468_0.method_0)).ToList<GClass214>();
      if (list.Count == 0)
        return false;
      // ISSUE: reference to a compiler-generated field
      class469.double_0 = gclass85_0.double_2;
      // ISSUE: reference to a compiler-generated field
      class469.double_1 = gclass85_0.double_3;
      gclass85_0.method_263();
      for (int index = 1; index < int_4; ++index)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        GClass214 gclass214_0 = list.OrderBy<GClass214, double>(class469.func_0 ?? (class469.func_0 = new Func<GClass214, double>(class469.method_0))).FirstOrDefault<GClass214>();
        if (gclass214_0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          class469.double_0 = gclass214_0.double_0;
          // ISSUE: reference to a compiler-generated field
          class469.double_1 = gclass214_0.double_1;
          gclass85_0.method_217(gclass214_0, GEnum123.const_1, this.gclass202_0);
          list.Remove(gclass214_0);
        }
      }
      gclass85_0.gclass4_0.bool_1 = true;
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 75);
      return false;
    }
  }

  public void method_20(List<GClass85> list_0, List<GClass85> list_1)
  {
    try
    {
      List<GClass59> list = this.gclass0_0.dictionary_30.Values.Where<GClass59>((Func<GClass59, bool>) (gclass59_0 => gclass59_0.gclass200_0 == this.gclass202_0.gclass200_0)).ToList<GClass59>();
      GClass59 gclass59 = (GClass59) null;
      list_0 = list_0.OrderBy<GClass85, Decimal>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.decimal_7)).ToList<GClass85>();
      foreach (GClass59 gclass59_0 in list)
      {
        if (gclass59 == null || this.gclass0_0.method_28(gclass59_0.double_0, gclass59_0.double_1, gclass59.double_0, gclass59.double_1) >= 100000000.0)
        {
          GClass85 gclass85_1 = list_1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).OrderByDescending<GClass85, int>((Func<GClass85, int>) (gclass85_0 => gclass85_0.int_6)).FirstOrDefault<GClass85>();
          if (gclass85_1 != null)
          {
            gclass85_1.method_263();
            gclass85_1.method_218(gclass59_0, GEnum123.const_32, this.gclass202_0);
            gclass85_1.gclass4_0.bool_1 = true;
            gclass59 = gclass59_0;
          }
          else
          {
            GClass85 gclass85_2 = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).OrderBy<GClass85, Decimal>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.decimal_7)).ThenByDescending<GClass85, GEnum100>((Func<GClass85, GEnum100>) (gclass85_0 => gclass85_0.gclass4_0.genum100_0)).FirstOrDefault<GClass85>();
            if (gclass85_2 != null)
            {
              gclass85_2.method_263();
              gclass85_2.method_218(gclass59_0, GEnum123.const_32, this.gclass202_0);
              gclass85_2.gclass4_0.bool_1 = true;
              gclass59 = gclass59_0;
            }
            else
              break;
          }
        }
      }
      list_0 = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
      list_1 = list_1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 76);
    }
  }

  public void method_21(List<GClass85> list_0, List<GClass146> list_1)
  {
    try
    {
      List<GClass146> list = list_1.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.decimal_4 > 0M)).ToList<GClass146>();
      if (list.Count == 0)
        return;
      foreach (GClass85 gclass85 in list_0)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class470 class470 = new GClass3.Class470();
        // ISSUE: reference to a compiler-generated field
        class470.gclass3_0 = this;
        // ISSUE: reference to a compiler-generated field
        class470.gclass85_0 = gclass85;
        // ISSUE: reference to a compiler-generated method
        GClass146 gclass146_1 = list.OrderBy<GClass146, double>(new Func<GClass146, double>(class470.method_0)).FirstOrDefault<GClass146>();
        // ISSUE: reference to a compiler-generated field
        class470.gclass85_0.method_263();
        // ISSUE: reference to a compiler-generated field
        class470.gclass85_0.method_219(gclass146_1, GEnum123.const_3);
        // ISSUE: reference to a compiler-generated field
        class470.gclass85_0.gclass4_0.bool_1 = true;
      }
      list_0 = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3419);
    }
  }

  public void method_22(List<GClass85> list_0, List<GClass146> list_1)
  {
    try
    {
      List<GClass146> list = list_1.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass123_0.method_7() > 1000M)).ToList<GClass146>();
      if (list.Count == 0)
        return;
      foreach (GClass85 gclass85 in list_0)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class471 class471 = new GClass3.Class471();
        // ISSUE: reference to a compiler-generated field
        class471.gclass3_0 = this;
        // ISSUE: reference to a compiler-generated field
        class471.gclass85_0 = gclass85;
        // ISSUE: reference to a compiler-generated method
        GClass146 gclass146_1 = list.OrderBy<GClass146, double>(new Func<GClass146, double>(class471.method_0)).FirstOrDefault<GClass146>();
        // ISSUE: reference to a compiler-generated field
        class471.gclass85_0.method_263();
        // ISSUE: reference to a compiler-generated field
        class471.gclass85_0.method_219(gclass146_1, GEnum123.const_16);
        // ISSUE: reference to a compiler-generated field
        class471.gclass85_0.gclass4_0.bool_1 = true;
      }
      list_0 = list_0.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3419);
    }
  }

  public void method_23(List<GClass146> list_0, List<GClass85> list_1)
  {
    try
    {
      list_0 = this.gclass202_0.method_46().OrderByDescending<GClass146, GEnum97>((Func<GClass146, GEnum97>) (gclass146_0 => gclass146_0.gclass6_0.genum97_0)).ThenByDescending<GClass146, int>((Func<GClass146, int>) (gclass146_0 => gclass146_0.gclass6_0.int_0)).ThenByDescending<GClass146, double>((Func<GClass146, double>) (gclass146_0 => gclass146_0.gclass6_0.double_2)).ToList<GClass146>();
      foreach (GClass146 gclass146 in list_0)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class472 class472 = new GClass3.Class472();
        // ISSUE: reference to a compiler-generated field
        class472.gclass3_0 = this;
        // ISSUE: reference to a compiler-generated field
        class472.gclass146_0 = gclass146;
        // ISSUE: reference to a compiler-generated method
        if (list_1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass4_0.genum100_0 == GEnum100.const_2)).SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>(new Func<GClass139, bool>(class472.method_0)).Count<GClass139>() <= 0)
        {
          // ISSUE: reference to a compiler-generated method
          GClass85 gclass85 = list_1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).OrderByDescending<GClass85, Decimal>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.decimal_7)).OrderByDescending<GClass85, GEnum100>((Func<GClass85, GEnum100>) (gclass85_0 => gclass85_0.gclass4_0.genum100_0)).OrderBy<GClass85, double>(new Func<GClass85, double>(class472.method_1)).FirstOrDefault<GClass85>();
          if (gclass85 != null)
          {
            if (gclass85.double_2 == list_0[0].method_87() && gclass85.double_3 == list_0[0].method_88())
            {
              gclass85.method_263();
              gclass85.gclass4_0.bool_1 = true;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              if (gclass85.method_29(class472.gclass146_0))
              {
                gclass85.method_263();
                // ISSUE: reference to a compiler-generated field
                gclass85.method_219(class472.gclass146_0, GEnum123.const_6);
                gclass85.gclass4_0.bool_1 = true;
              }
            }
          }
        }
      }
      list_1 = list_1.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => !gclass85_0.gclass4_0.bool_1)).ToList<GClass85>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 77);
    }
  }

  public void method_24(List<GClass40> list_0)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass3.Class473 class473 = new GClass3.Class473();
      if (this.genum95_0 == GEnum95.const_0 || this.genum95_0 == GEnum95.const_6)
        return;
      List<GClass40> list1 = list_0.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass85_0.gclass202_0 == this.gclass202_0)).ToList<GClass40>();
      // ISSUE: reference to a compiler-generated field
      class473.list_0 = this.gclass202_0.method_46();
      if (this.gclass202_0.gclass21_0.genum6_0 == GEnum6.const_2)
      {
        double num1 = 0.0;
        List<GClass233> list2 = this.gclass0_0.dictionary_29.Values.Where<GClass233>((Func<GClass233, bool>) (gclass233_0 => gclass233_0.gclass200_0 == this.gclass202_0.gclass200_0)).ToList<GClass233>();
        if (list2.Count > 0)
          num1 += (double) (int) (list2.Sum<GClass233>((Func<GClass233, Decimal>) (gclass233_0 => gclass233_0.gclass22_0.decimal_4)) / 50M);
        List<GClass40> list3 = list1.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => !gclass40_0.gclass22_0.method_33())).ToList<GClass40>();
        if (list3.Count > 0)
          num1 += (double) (int) (list3.Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_4)) / 10M);
        // ISSUE: reference to a compiler-generated field
        List<GClass146> list4 = class473.list_0.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.dictionary_0.Count > 0)).ToList<GClass146>();
        if (list4.Count > 0)
          num1 += (double) (int) (list4.SelectMany<GClass146, GClass158>((Func<GClass146, IEnumerable<GClass158>>) (gclass146_0 => (IEnumerable<GClass158>) gclass146_0.dictionary_0.Values)).Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_21 * gclass158_0.decimal_0)) / 10M);
        // ISSUE: reference to a compiler-generated method
        List<GClass193> list5 = this.gclass0_0.dictionary_31.Values.Where<GClass193>(new Func<GClass193, bool>(class473.method_0)).ToList<GClass193>();
        if (list5.Count > 0)
          num1 += (double) (int) (list5.Sum<GClass193>((Func<GClass193, Decimal>) (gclass193_0 => (Decimal) gclass193_0.int_1 * gclass193_0.decimal_0)) / 100M);
        // ISSUE: reference to a compiler-generated method
        List<GClass193> list6 = this.gclass0_0.dictionary_31.Values.Where<GClass193>(new Func<GClass193, bool>(class473.method_1)).ToList<GClass193>();
        if (list6.Count > 0)
          num1 += (double) (int) (list6.Sum<GClass193>((Func<GClass193, Decimal>) (gclass193_0 => (Decimal) gclass193_0.int_1 * gclass193_0.decimal_0)) / 1000M);
        double num2 = num1 + (double) (int) (this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.gclass200_0 == this.gclass202_0.gclass200_0)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.dictionary_0.Values.Count > 3)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.method_16(50, false))).Sum<GClass1>((Func<GClass1, double>) (gclass1_0 => gclass1_0.method_17())) / 2.0);
        this.genum95_0 = num2 <= 200.0 ? (num2 <= 50.0 ? (num2 <= 20.0 ? GEnum95.const_2 : GEnum95.const_3) : GEnum95.const_4) : GEnum95.const_5;
      }
      else if (this.gclass202_0.gclass21_0.genum6_0 == GEnum6.const_3)
      {
        Decimal num = this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass202_0.gclass200_0 == this.gclass202_0.gclass200_0)).Sum<GClass146>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.method_190()));
        if (num > 20000M)
        {
          this.genum95_0 = GEnum95.const_5;
          return;
        }
        if (num > 5000M)
        {
          this.genum95_0 = GEnum95.const_4;
          return;
        }
        if (num > 1000M)
        {
          this.genum95_0 = GEnum95.const_3;
          return;
        }
        if (num > 1000M)
        {
          this.genum95_0 = GEnum95.const_2;
          return;
        }
        this.genum95_0 = GEnum95.const_1;
        return;
      }
      // ISSUE: reference to a compiler-generated field
      Decimal num3 = class473.list_0.Sum<GClass146>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.decimal_30));
      if (num3 > 100M)
      {
        this.genum95_0 = GEnum95.const_5;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        int num4 = class473.list_0.Sum<GClass146>((Func<GClass146, int>) (gclass146_0 => gclass146_0.gclass6_0.int_0));
        // ISSUE: reference to a compiler-generated field
        if (class473.list_0.Count > 0)
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          num4 = num4 + list1.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.gclass14_0.genum120_0 == GEnum120.const_45 && gclass40_0.gclass85_0.gclass146_0 != null)).Where<GClass40>(new Func<GClass40, bool>(class473.method_2)).Sum<GClass40>((Func<GClass40, int>) (gclass40_0 => gclass40_0.method_167(AuroraComponentType.OrbitalMiningModule))) + (int) Math.Round(list1.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.gclass14_0.genum120_0 == GEnum120.const_5 && gclass40_0.gclass85_0.gclass146_0 != null)).Where<GClass40>(new Func<GClass40, bool>(class473.method_3)).Sum<GClass40>((Func<GClass40, double>) (gclass40_0 => (double) gclass40_0.method_167(AuroraComponentType.TerraformingModule) * 4.0)));
        }
        List<GClass40> list7 = list1.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.gclass14_0.genum120_0 == GEnum120.const_6)).ToList<GClass40>();
        if (list7.Count > 0)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: reference to a compiler-generated method
          num4 += (int) Math.Round(list7.Where<GClass40>(new Func<GClass40, bool>(new GClass3.Class474()
          {
            list_0 = this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.gclass200_0 == this.gclass202_0.gclass200_0)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0 =>
            {
              if (gclass1_0.dictionary_0.Count <= 0)
                return false;
              return gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian;
            })).ToList<GClass1>()
          }.method_0)).Sum<GClass40>((Func<GClass40, double>) (gclass40_0 => (double) gclass40_0.method_167(AuroraComponentType.SoriumHarvester) / 4.0)));
        }
        if (num4 > 500)
        {
          this.genum95_0 = GEnum95.const_5;
        }
        else
        {
          Decimal num5 = -1M;
          if (this.gclass202_0.gclass21_0.genum6_0 == GEnum6.const_0)
          {
            // ISSUE: reference to a compiler-generated field
            double num6 = class473.list_0.Sum<GClass146>((Func<GClass146, double>) (gclass146_0 => gclass146_0.gclass6_0.double_2));
            if (!(num3 > 25M) && num4 <= 125 && num6 <= 4.0)
            {
              if (!(num3 > 5M) && num4 <= 25 && num6 <= 1.0)
              {
                // ISSUE: reference to a compiler-generated field
                if (class473.list_0.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.decimal_19 >= 0M && gclass146_0.gclass1_0.double_7 >= gclass146_0.gclass194_0.double_7)).ToList<GClass146>().Count > 0)
                {
                  // ISSUE: reference to a compiler-generated field
                  num5 = class473.list_0.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.decimal_19 >= 0M && gclass146_0.gclass1_0.double_7 >= gclass146_0.gclass194_0.double_7)).Min<GClass146>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.decimal_19));
                  if (num5 == 0M)
                  {
                    this.genum95_0 = GEnum95.const_3;
                    return;
                  }
                }
                if (num3 > 0.5M || num4 > 0 || num6 > 0.0 || num5 >= 0M && num5 < 1M)
                {
                  this.genum95_0 = GEnum95.const_2;
                  return;
                }
              }
              else
              {
                this.genum95_0 = GEnum95.const_3;
                return;
              }
            }
            else
            {
              this.genum95_0 = GEnum95.const_4;
              return;
            }
          }
          this.genum95_0 = GEnum95.const_1;
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 78);
    }
  }

  public void method_25(List<GClass40> list_0)
  {
    try
    {
      List<GClass146> source = this.gclass202_0.method_46();
      double num1 = source.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass6_0.double_1 >= GClass226.double_29)).Sum<GClass146>((Func<GClass146, double>) (gclass146_0 => gclass146_0.gclass6_0.double_1));
      double num2 = 0.0;
      if (source.Count > 0)
        num2 = source.Max<GClass146>((Func<GClass146, double>) (gclass146_0 => gclass146_0.gclass6_0.double_1));
      if (num1 < 25.0 && num2 < 10.0)
      {
        if (source.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass6_0.double_0 > 0.0)).ToList<GClass146>().Count <= 0 || source.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass6_0.double_0 > 0.0)).Min<GClass146>((Func<GClass146, double>) (gclass146_0 => gclass146_0.gclass6_0.double_0)) >= 0.1)
          return;
        this.genum95_0 = GEnum95.const_2;
      }
      else
        this.genum95_0 = GEnum95.const_2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 79);
    }
  }

  public void method_26(GEnum95 genum95_1)
  {
    try
    {
      foreach (GClass202 gclass202 in this.gclass202_0.method_37(true))
      {
        if (gclass202.gclass3_0.genum95_0 != GEnum95.const_0 && gclass202.gclass3_0.genum95_0 < genum95_1)
          gclass202.gclass3_0.genum95_0 = genum95_1;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 80 /*0x50*/);
    }
  }
}
