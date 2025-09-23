// Decompiled with JetBrains decompiler
// Type: GClass20
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass20
{
  private GClass0 gclass0_0;
  public List<GClass16> list_0 = new List<GClass16>();
  public List<GClass19> list_1 = new List<GClass19>();
  public List<GEnum89> list_2 = new List<GEnum89>();
  public List<GClass12> list_3 = new List<GClass12>();
  public GEnum90 genum90_0;
  public GClass21 gclass21_0;
  public GClass230 gclass230_0;
  public GClass230 gclass230_1;
  public GClass230 gclass230_2;
  public GClass230 gclass230_3;
  public GClass230 gclass230_4;
  public GClass230 gclass230_5;
  public GClass230 gclass230_6;
  public GClass230 gclass230_7;
  public GClass230 gclass230_8;
  public GClass230 gclass230_9;
  public GClass230 gclass230_10;
  public GClass230 gclass230_11;
  public GClass230 gclass230_12;
  public GClass230 gclass230_13;
  public GClass230 gclass230_14;
  public GClass230 gclass230_15;
  public GClass230 gclass230_16;
  public GClass230 gclass230_17;
  public GClass230 gclass230_18;
  public GClass230 gclass230_19;
  public GClass230 gclass230_20;
  public GClass230 gclass230_21;
  public GClass230 gclass230_22;
  public GClass230 gclass230_23;
  public GClass230 gclass230_24;
  public GClass230 gclass230_25;
  public GClass230 gclass230_26;
  public GClass230 gclass230_27;
  public GClass230 gclass230_28;
  public GClass230 gclass230_29;
  public GClass230 gclass230_30;
  public GClass230 gclass230_31;
  public GClass230 gclass230_32;
  public GClass230 gclass230_33;
  public GClass230 gclass230_34;
  public GClass230 gclass230_35;
  public GClass230 gclass230_36;
  public GClass230 gclass230_37;
  public GClass230 gclass230_38;
  public GClass230 gclass230_39;
  public GClass230 gclass230_40;
  public GClass230 gclass230_41;
  public GClass230 gclass230_42;
  public GClass230 gclass230_43;
  public GClass230 gclass230_44;
  public GClass230 gclass230_45;
  public GClass230 gclass230_46;
  public GClass230 gclass230_47;
  public GClass230 gclass230_48;
  public GClass230 gclass230_49;
  public GClass230 gclass230_50;
  public GClass230 gclass230_51;
  public GClass230 gclass230_52;
  public GClass230 gclass230_53;
  public GClass230 gclass230_54;
  public GClass230 gclass230_55;
  public GClass230 gclass230_56;
  public GClass230 gclass230_57;
  public GClass230 gclass230_58;
  public GClass230 gclass230_59;
  public GClass230 gclass230_60;
  public GClass230 gclass230_61;
  public GClass230 gclass230_62;
  public GClass230 gclass230_63;
  public GClass230 gclass230_64;
  public GClass164 gclass164_0;
  public GClass129 gclass129_0;
  public GClass129 gclass129_1;
  public GClass129 gclass129_2;
  public GClass129 gclass129_3;
  public GClass129 gclass129_4;
  public GClass129 gclass129_5;
  public GEnum36 genum36_0;
  public GEnum36 genum36_1;
  public GEnum36 genum36_2;
  public GEnum108 genum108_0;
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
  public int int_12;
  public int int_13 = 2;
  public int int_14 = 1;
  public int int_15 = 20;
  public int int_16 = 10;
  public Decimal decimal_0 = 0.7M;
  public Decimal decimal_1 = 1M;
  public Decimal decimal_2 = 1M;
  public Decimal decimal_3 = 2M;
  public double double_0;
  public double double_1 = 1.0;
  public int int_17;
  public int int_18;
  public int int_19;
  public int int_20;
  public int int_21;
  public int int_22;
  public int int_23;
  public int int_24 = 1;
  public bool bool_0;
  public bool bool_1;
  public bool bool_2;
  public bool bool_3;

  public GClass20(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public void method_0(GClass21 gclass21_1)
  {
    try
    {
      foreach (GClass9 gclass9 in this.list_3.Select<GClass12, GClass9>((Func<GClass12, GClass9>) (gclass12_0 => gclass12_0.gclass9_0)).Distinct<GClass9>().ToList<GClass9>())
      {
        foreach (GClass10 gclass10 in gclass9.list_0)
        {
          if (GClass226.smethod_13(100) <= gclass10.int_2)
          {
            GClass11 gclass11 = new GClass11();
            gclass11.gclass9_0 = gclass9;
            gclass11.gclass14_0 = gclass10.gclass14_0;
            gclass11.bool_0 = gclass10.bool_0;
            gclass11.int_0 = gclass10.int_0 + GClass226.smethod_13(gclass10.int_1);
            if (gclass11.gclass14_0.genum120_0 == GEnum120.const_76 && this.bool_3)
              gclass11.gclass14_0 = this.gclass0_0.dictionary_63[GEnum120.const_78];
            gclass21_1.list_0.Add(gclass11);
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3295);
    }
  }

  public void method_1()
  {
    try
    {
      this.list_1 = this.gclass0_0.list_3.Where<GClass19>((Func<GClass19, bool>) (gclass19_0 => this.list_2.Contains(gclass19_0.genum89_0))).OrderBy<GClass19, int>((Func<GClass19, int>) (gclass19_0 => gclass19_0.int_0)).ToList<GClass19>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3296);
    }
  }
}
