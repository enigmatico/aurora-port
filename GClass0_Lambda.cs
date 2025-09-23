using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Aurora;

public partial class GClass0
{
  private class staticCompGen
  {
    public static System.Func<GClass158, int> staticCompMem__14_25;
    public static System.Func<GClass31, bool> staticCompMem__100_27;
    public static System.Func<GClass34, bool> staticCompMem__100_48;
  }
    
  [CompilerGenerated]
  private sealed class Class0
  {
    public int int_0;

    public Class0()
    {
      
    }

    internal bool method_0(GClass174 gclass174_0)
    {
      return gclass174_0.int_1 >= this.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class1
  {
    public List<GClass200> list_0;

    public Class1()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return this.list_0.Contains(gclass1_0.gclass200_0) && gclass1_0.gclass171_0 != null;
    }
  }

  [CompilerGenerated]
  private sealed class Class2
  {
    public int int_0;
    public int int_1;

    public Class2()
    {
      
    }

    internal bool method_0(GClass225 gclass225_0)
    {
      return gclass225_0.int_0 == this.int_0 && gclass225_0.int_1 >= this.int_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class3
  {
    public bool bool_0;
    public GClass0 gclass0_0;

    public Class3()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      return gclass40_0.method_19(this.bool_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class4
  {
    public List<GClass200> list_0;
    public List<GClass21> list_1;
    public GClass0.Class3 class3_0;

    public Class4()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      return this.list_0.Contains(gclass40_0.gclass85_0.gclass202_0.gclass200_0);
    }

    internal bool method_1(GClass40 gclass40_0)
    {
      return this.list_1.Contains(gclass40_0.gclass21_0);
    }

    internal bool method_2(GClass65 gclass65_0)
    {
      return this.list_0.Contains(gclass65_0.gclass200_0);
    }

    internal bool method_3(GClass65 gclass65_0)
    {
      return this.list_1.Contains(gclass65_0.gclass21_1);
    }

    internal bool method_4(GClass103 gclass103_0)
    {
      return this.list_0.Contains(gclass103_0.gclass146_0.gclass202_0.gclass200_0);
    }

    internal bool method_5(GClass103 gclass103_0)
    {
      return this.list_0.Contains(gclass103_0.gclass146_0.gclass202_0.gclass200_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class5
  {
    public GClass21 gclass21_0;

    public Class5()
    {
      
    }
  }

  [CompilerGenerated]
  private sealed class Class6
  {
    public GClass132 gclass132_0;
    public GClass0.Class5 class5_0;

    public Class6()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.gclass21_1 == this.class5_0.gclass21_0 && gclass65_0.gclass132_0 == this.gclass132_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class7
  {
    public GClass36 gclass36_0;
    public GClass0.Class4 class4_0;
    public System.Func<GClass131, bool> func_0;
    public System.Func<GClass131, double> func_1;

    public Class7()
    {
      
    }

    internal bool method_0(GClass31 gclass31_0)
    {
      return gclass31_0.gclass230_1 == this.gclass36_0.gclass230_0 && gclass31_0.int_1 == this.gclass36_0.int_0;
    }

    internal bool method_1(GClass132 gclass132_0)
    {
      return this.gclass36_0.gclass40_0.gclass21_0 == gclass132_0.gclass21_1 && gclass132_0.list_0.Contains(this.gclass36_0.gclass40_0.gclass21_0);
    }

    internal bool method_2(GClass132 gclass132_0)
    {
      return gclass132_0.gclass40_1 == this.gclass36_0.gclass40_0;
    }

    internal bool method_3(GClass131 gclass131_0)
    {
      return (AuroraPointDefenceConcentration) gclass131_0.list_0.Count < this.gclass36_0.auroraPointDefenceConcentration_0;
    }

    internal double method_4(GClass131 gclass131_0)
    {
      return this.class4_0.class3_0.gclass0_0.method_28(this.gclass36_0.gclass40_0.gclass85_0.double_2, this.gclass36_0.gclass40_0.gclass85_0.double_3, gclass131_0.gclass132_0.double_0, gclass131_0.gclass132_0.double_1);
    }
  }

  [CompilerGenerated]
  private sealed class Class8
  {
    public int int_0;
    public GClass0.Class7 class7_0;

    public Class8()
    {
      
    }

    internal bool method_0(GClass132 gclass132_0)
    {
      return this.class7_0.class4_0.class3_0.gclass0_0.method_28(this.class7_0.gclass36_0.gclass40_0.gclass85_0.double_2, this.class7_0.gclass36_0.gclass40_0.gclass85_0.double_3, gclass132_0.double_0, gclass132_0.double_1) <= (double) this.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class9
  {
    public GClass39 gclass39_0;
    public GClass0.Class4 class4_0;

    public Class9()
    {
      
    }

    internal bool method_0(GClass132 gclass132_0)
    {
      return this.gclass39_0.gclass103_0.gclass21_0 == gclass132_0.gclass21_1 && gclass132_0.list_0.Contains(this.gclass39_0.gclass103_0.gclass21_0);
    }

    internal bool method_1(GClass132 gclass132_0)
    {
      return gclass132_0.gclass146_0 == this.gclass39_0.gclass103_0.gclass146_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class10
  {
    public double double_0;
    public double double_1;
    public int int_0;
    public GClass0.Class9 class9_0;
    public System.Func<GClass131, double> func_0;

    public Class10()
    {
      
    }

    internal bool method_0(GClass132 gclass132_0)
    {
      return this.class9_0.class4_0.class3_0.gclass0_0.method_28(this.double_0, this.double_1, gclass132_0.double_0, gclass132_0.double_1) <= (double) this.int_0;
    }

    internal double method_1(GClass131 gclass131_0)
    {
      return this.class9_0.class4_0.class3_0.gclass0_0.method_28(this.double_0, this.double_1, gclass131_0.gclass132_0.double_0, gclass131_0.gclass132_0.double_1);
    }
  }

  [CompilerGenerated]
  private sealed class Class11
  {
    public GClass1 gclass1_0;

    public Class11()
    {
      
    }

    internal bool method_0(GClass220 gclass220_0)
    {
      return gclass220_0.gclass1_0 == this.gclass1_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class12
  {
    public GClass200 gclass200_0;

    public Class12()
    {
      
    }

    internal bool method_0(GClass197 gclass197_0)
    {
      return gclass197_0.gclass200_0 == this.gclass200_0 && gclass197_0.int_3 == 1;
    }
  }

  [CompilerGenerated]
  private sealed class Class13
  {
    public GClass217 gclass217_0;
    public int int_0;

    public Class13()
    {
      
    }

    internal bool method_0(GClass217 gclass217_1)
    {
      return gclass217_1.int_1 == this.int_0 && gclass217_1.string_0 == this.gclass217_0.string_0 && gclass217_1.string_1 == this.gclass217_0.string_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class14
  {
    public GClass200 gclass200_0;

    public Class14()
    {
      
    }

    internal double method_0(GClass198 gclass198_0)
    {
      return Math.Pow(gclass198_0.double_3 - this.gclass200_0.gclass198_0.double_3, 2.0) + Math.Pow(gclass198_0.double_4 - this.gclass200_0.gclass198_0.double_4, 2.0) + Math.Pow(gclass198_0.double_5 - this.gclass200_0.gclass198_0.double_5, 2.0);
    }
  }

  [CompilerGenerated]
  private sealed class Class15
  {
    public GClass200 gclass200_0;

    public Class15()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_1(GClass200 gclass200_1)
    {
      return gclass200_1 != this.gclass200_0 && gclass200_1.int_1 >= 0;
    }

    internal bool method_2(GClass200 gclass200_1)
    {
      return gclass200_1 != this.gclass200_0 && gclass200_1.int_1 >= 0;
    }

    internal double method_3(GClass200 gclass200_1)
    {
      return Math.Pow(gclass200_1.gclass198_0.double_3 + this.gclass200_0.gclass198_0.double_3, 2.0) + Math.Pow(gclass200_1.gclass198_0.double_4 + this.gclass200_0.gclass198_0.double_4, 2.0) + Math.Pow(gclass200_1.gclass198_0.double_5 + this.gclass200_0.gclass198_0.double_5, 2.0);
    }
  }

  [CompilerGenerated]
  private sealed class Class16
  {
    public GClass200 gclass200_0;

    public Class16()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.gclass200_0;
    }

    internal double method_1(GClass200 gclass200_1)
    {
      return Math.Pow(gclass200_1.gclass198_0.double_3 + this.gclass200_0.gclass198_0.double_3, 2.0) + Math.Pow(gclass200_1.gclass198_0.double_4 + this.gclass200_0.gclass198_0.double_4, 2.0) + Math.Pow(gclass200_1.gclass198_0.double_5 + this.gclass200_0.gclass198_0.double_5, 2.0);
    }
  }

  [CompilerGenerated]
  private sealed class Class17
  {
    public GClass200 gclass200_0;

    public Class17()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.gclass200_0;
    }

    internal int method_1(GClass200 gclass200_1)
    {
      return Math.Abs(gclass200_1.int_1 - this.gclass200_0.int_1);
    }
  }

  [CompilerGenerated]
  private sealed class Class18
  {
    public GClass202 gclass202_0;
    public GClass0 gclass0_0;

    public Class18()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass202_0.gclass200_0 == this.gclass202_0.gclass200_0 && gclass85_0.gclass21_0 == this.gclass202_0.gclass21_0;
    }

    internal bool method_1(GClass146 gclass146_0)
    {
      return gclass146_0.gclass202_0 == this.gclass202_0;
    }

    internal bool method_2(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0.gclass202_0 == this.gclass202_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class19
  {
    public int int_0;
    public GClass0.Class18 class18_0;

    public Class19()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.gclass21_1 == this.class18_0.gclass202_0.gclass21_0 && gclass65_0.auroraContactType_0 == AuroraContactType.Ship && gclass65_0.gclass200_0 == this.class18_0.gclass202_0.gclass200_0 && gclass65_0.decimal_3 >= this.class18_0.gclass0_0.decimal_0 - (Decimal) this.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class20
  {
    public GClass40 gclass40_0;

    public Class20()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.int_1 == this.gclass40_0.int_8;
    }
  }

  [CompilerGenerated]
  private sealed class Class21
  {
    public GClass132 gclass132_0;

    public Class21()
    {
      
    }

    internal bool method_0(GClass132 gclass132_1)
    {
      return gclass132_1.gclass132_0 == this.gclass132_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class22
  {
    public GClass202 gclass202_0;

    public Class22()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass202_0 == this.gclass202_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class23
  {
    public GClass233 gclass233_0;
    public GClass0.Class22 class22_0;

    public Class23()
    {
      
    }

    internal bool method_0(GClass63 gclass63_0)
    {
      return gclass63_0.string_0 == this.gclass233_0.method_1(this.class22_0.gclass202_0.gclass21_0, false);
    }
  }

  [CompilerGenerated]
  private sealed class Class24
  {
    public GClass40 gclass40_0;

    public Class24()
    {
      
    }

    internal bool method_0(GClass64 gclass64_0)
    {
      return gclass64_0.auroraContactStatus_0 == this.gclass40_0.auroraContactStatus_0 && gclass64_0.string_0 == this.gclass40_0.string_4 && gclass64_0.gclass221_0.double_0 == this.gclass40_0.gclass221_0.double_0 && gclass64_0.gclass221_0.double_1 == this.gclass40_0.gclass221_0.double_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class25
  {
    public GClass132 gclass132_0;

    public Class25()
    {
      
    }

    internal bool method_0(GClass64 gclass64_0)
    {
      return gclass64_0.auroraContactStatus_0 == this.gclass132_0.auroraContactStatus_0 && gclass64_0.string_0 == this.gclass132_0.string_2 && gclass64_0.gclass221_0.double_0 == this.gclass132_0.gclass221_1.double_0 && gclass64_0.gclass221_0.double_1 == this.gclass132_0.gclass221_1.double_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class26
  {
    public GClass228 gclass228_0;

    public Class26()
    {
      
    }

    internal bool method_0(GClass28 gclass28_0)
    {
      return gclass28_0.gclass230_0 == this.gclass228_0.gclass230_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class27
  {
    public GClass85 gclass85_0;
    public System.Func<GClass85, bool> func_0;
    public System.Func<GClass84, bool> func_1;
    public System.Func<GClass40, bool> func_2;
    public System.Func<GClass40, bool> func_3;

    public Class27()
    {
      
    }

    internal bool method_0(GClass85 gclass85_1)
    {
      return gclass85_1.gclass202_0.gclass200_0 == this.gclass85_0.gclass202_0.gclass200_0 && gclass85_1.gclass21_0 != this.gclass85_0.gclass21_0;
    }

    internal bool method_1(GClass84 gclass84_0)
    {
      return gclass84_0.gclass85_0 == this.gclass85_0;
    }

    internal bool method_2(GClass40 gclass40_0)
    {
      return gclass40_0.gclass85_0 == this.gclass85_0 && gclass40_0.gclass22_0.int_23 == 1;
    }

    internal bool method_3(GClass40 gclass40_0)
    {
      return gclass40_0.gclass85_0 == this.gclass85_0 && gclass40_0.gclass22_0.int_52 == 1;
    }
  }

  [CompilerGenerated]
  private sealed class Class28
  {
    public GClass139 gclass139_0;
    public System.Func<GClass233, bool> func_0;

    public Class28()
    {
      
    }

    internal bool method_0(GClass233 gclass233_0)
    {
      return gclass233_0.int_0 == this.gclass139_0.int_2;
    }
  }

  [CompilerGenerated]
  private sealed class Class29
  {
    public GClass85 gclass85_0;

    public Class29()
    {
      
    }

    internal bool method_0(GClass85 gclass85_1)
    {
      return gclass85_1 != this.gclass85_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class30
  {
    public GClass85 gclass85_0;

    public Class30()
    {
      
    }

    internal bool method_0(GClass85 gclass85_1)
    {
      return gclass85_1 != this.gclass85_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class31
  {
    public Decimal decimal_0;
    public GClass0 gclass0_0;

    public Class31()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.decimal_0 <= this.decimal_0 && gclass85_0.gclass85_1 != null;
    }
  }

  [CompilerGenerated]
  private sealed class Class32
  {
    public GClass85 gclass85_0;
    public GClass0.Class31 class31_0;

    public Class32()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.gclass21_1 == this.gclass85_0.gclass21_0 && gclass65_0.gclass40_0 == this.gclass85_0.gclass117_0.gclass40_0 && gclass65_0.decimal_3 == this.class31_0.decimal_0 && gclass65_0.gclass200_0 == this.gclass85_0.gclass202_0.gclass200_0;
    }

    internal bool method_1(GClass65 gclass65_0)
    {
      return gclass65_0.gclass21_1 == this.gclass85_0.gclass21_0 && gclass65_0.gclass40_0 != null && gclass65_0.decimal_3 == this.class31_0.decimal_0 && gclass65_0.gclass200_0 == this.gclass85_0.gclass202_0.gclass200_0;
    }

    internal bool method_2(GClass65 gclass65_0)
    {
      return this.gclass85_0.gclass21_0.dictionary_11.Values.Where<GClass115>(gc115=>gc115.list_1.Count>0)
        .Select<GClass115, GClass22>(gc115=>gc115.gclass22_0)
        .Contains<GClass22>(gclass65_0.gclass40_0.gclass22_0);
    }

    internal double method_3(GClass65 gclass65_0)
    {
      return this.class31_0.gclass0_0.method_28(this.gclass85_0.gclass85_1.double_2, this.gclass85_0.gclass85_1.double_3, gclass65_0.double_0, gclass65_0.double_1);
    }

    internal bool method_4(GClass65 gclass65_0)
    {
      return gclass65_0.gclass21_1 == this.gclass85_0.gclass21_0 && gclass65_0.gclass40_0 != null && gclass65_0.decimal_3 == this.class31_0.decimal_0 && gclass65_0.gclass200_0 == this.gclass85_0.gclass202_0.gclass200_0;
    }

    internal double method_5(GClass65 gclass65_0)
    {
      return this.class31_0.gclass0_0.method_28(this.gclass85_0.gclass85_1.double_2, this.gclass85_0.gclass85_1.double_3, gclass65_0.double_0, gclass65_0.double_1);
    }
  }

  [CompilerGenerated]
  private sealed class Class33
  {
    public GClass85 gclass85_0;

    public Class33()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.gclass40_0.gclass85_0 == this.gclass85_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class34
  {
    public GClass200 gclass200_0;

    public Class34()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.string_0 == "Earth" && gclass1_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_1(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class35
  {
    public GClass11 gclass11_0;

    public Class35()
    {
      
    }

    internal bool method_0(GClass22 gclass22_0)
    {
      return gclass22_0.gclass14_0.genum120_0 == this.gclass11_0.gclass14_0.genum120_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class36
  {
    public GClass21 gclass21_0;
    public GClass9 gclass9_0;
    public System.Func<GClass102, bool> func_0;
    public System.Func<GClass102, bool> func_1;
    public System.Func<GClass102, bool> func_2;

    public Class36()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass21_0 && gclass85_0.gclass9_0 == this.gclass9_0;
    }

    internal bool method_1(GClass102 gclass102_0)
    {
      return gclass102_0.gclass21_0 == this.gclass21_0 && gclass102_0.genum116_0 == GEnum116.const_15;
    }

    internal bool method_2(GClass102 gclass102_0)
    {
      return gclass102_0.gclass21_0 == this.gclass21_0 && gclass102_0.genum116_0 == GEnum116.const_16;
    }

    internal bool method_3(GClass102 gclass102_0)
    {
      return gclass102_0.gclass21_0 == this.gclass21_0 && gclass102_0.genum116_0 == GEnum116.const_20;
    }
  }

  [CompilerGenerated]
  private sealed class Class37
  {
    public GClass11 gclass11_0;

    public Class37()
    {
      
    }

    internal bool method_0(GClass22 gclass22_0)
    {
      return gclass22_0.gclass14_0.genum120_0 == this.gclass11_0.gclass14_0.genum120_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class38
  {
    public GClass21 gclass21_0;
    public GClass9 gclass9_0;

    public Class38()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass21_0 && gclass85_0.gclass9_0 == this.gclass9_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class39
  {
    public GClass11 gclass11_0;

    public Class39()
    {
      
    }

    internal bool method_0(GClass22 gclass22_0)
    {
      return gclass22_0.gclass14_0.genum120_0 == this.gclass11_0.gclass14_0.genum120_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class40
  {
    public GClass21 gclass21_0;

    public Class40()
    {
      
    }

    internal bool method_0(GClass83 gclass83_0)
    {
      return gclass83_0.gclass21_0 == this.gclass21_0 && gclass83_0.gclass83_0 == null;
    }

    internal bool method_1(GClass22 gclass22_0)
    {
      return gclass22_0.gclass21_0 == this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class41
  {
    public GClass200 gclass200_0;
    public System.Func<GClass197, bool> func_0;
    public System.Func<GClass1, bool> func_1;

    public Class41()
    {
      
    }

    internal bool method_0(GClass197 gclass197_0)
    {
      return gclass197_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_1(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass200_0 && gclass1_0.gclass197_0.bool_1 && (gclass1_0.genum12_0 == GEnum12.const_1 || gclass1_0.genum12_0 == GEnum12.const_2) && gclass1_0.auroraSystemBodyType_0 != AuroraSystemBodyType.GasGiant && gclass1_0.auroraSystemBodyType_0 != AuroraSystemBodyType.Superjovian;
    }
  }

  [CompilerGenerated]
  private sealed class Class42
  {
    public GClass200 gclass200_0;

    public Class42()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_1(GClass197 gclass197_0)
    {
      return gclass197_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_2(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_3(GClass212 gclass212_0)
    {
      return gclass212_0.gclass200_0 == this.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class43
  {
    public double double_0;
    public double double_1;

    public Class43()
    {
      
    }

    internal bool method_0(GClass198 gclass198_0)
    {
      return gclass198_0.double_6 > this.double_0 && gclass198_0.double_6 < this.double_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class44
  {
    public GClass85 gclass85_0;

    public Class44()
    {
      
    }

    internal bool method_0(GClass37 gclass37_0)
    {
      return gclass37_0.gclass40_0.gclass85_0 == this.gclass85_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class45
  {
    public GClass230 gclass230_0;
    public GClass0.Class44 class44_0;

    public Class45()
    {
      
    }

    internal bool method_0(GClass37 gclass37_0)
    {
      return gclass37_0.gclass40_0.gclass85_0 == this.class44_0.gclass85_0 && gclass37_0.gclass230_0 == this.gclass230_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class46
  {
    public GClass146 gclass146_0;

    public Class46()
    {
      
    }

    internal bool method_0(GClass37 gclass37_0)
    {
      return gclass37_0.gclass39_0.gclass103_0.gclass146_0 == this.gclass146_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class47
  {
    public GClass230 gclass230_0;
    public GClass0.Class46 class46_0;

    public Class47()
    {
      
    }

    internal bool method_0(GClass37 gclass37_0)
    {
      return gclass37_0.gclass39_0.gclass103_0.gclass146_0 == this.class46_0.gclass146_0 && gclass37_0.gclass230_0 == this.gclass230_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class48
  {
    public GClass37 gclass37_0;

    public Class48()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      return gclass40_0.int_8 == this.gclass37_0.int_0;
    }

    internal bool method_1(GClass146 gclass146_0)
    {
      return gclass146_0.int_6 == this.gclass37_0.int_0;
    }

    internal bool method_2(GClass146 gclass146_0)
    {
      return gclass146_0.int_6 == this.gclass37_0.int_0;
    }

    internal bool method_3(GClass39 gclass39_0)
    {
      return gclass39_0.list_1.Contains(this.gclass37_0.gclass21_1);
    }
  }

  [CompilerGenerated]
  private sealed class Class49
  {
    public GClass40 gclass40_0;
    public GClass117 gclass117_0;

    public Class49()
    {
      
    }

    internal bool method_0(GClass172 gclass172_0)
    {
      return gclass172_0.gclass1_0.gclass200_0 == this.gclass40_0.gclass85_0.gclass202_0.gclass200_0;
    }

    internal bool method_1(GClass117 gclass117_1)
    {
      return gclass117_1.gclass40_0.gclass85_0 == this.gclass117_0.gclass40_0.gclass85_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class50
  {
    public GClass146 gclass146_0;
    public GClass193 gclass193_0;

    public Class50()
    {
      
    }

    internal bool method_0(GClass193 gclass193_1)
    {
      return gclass193_1.gclass146_0 == this.gclass146_0;
    }

    internal bool method_1(GClass192 gclass192_0)
    {
      return gclass192_0.gclass193_0 == this.gclass193_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class51
  {
    public GClass146 gclass146_0;
    public System.Func<GClass83, bool> func_0;
    public System.Func<GClass62, bool> func_1;

    public Class51()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0 == this.gclass146_0;
    }

    internal bool method_1(GClass83 gclass83_0)
    {
      return gclass83_0.gclass146_0 == this.gclass146_0;
    }

    internal bool method_2(GClass62 gclass62_0)
    {
      return gclass62_0.gclass146_0 == this.gclass146_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class52
  {
    public long long_0;

    public Class52()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return this.long_0 >= gclass103_0.long_0 && this.long_0 <= gclass103_0.long_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class53
  {
    public long long_0;

    public Class53()
    {
      
    }

    internal bool method_0(GClass39 gclass39_0)
    {
      return this.long_0 >= gclass39_0.long_0 && this.long_0 <= gclass39_0.long_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class54
  {
    public long long_0;

    public Class54()
    {
      
    }

    internal bool method_0(GClass39 gclass39_0)
    {
      return this.long_0 >= gclass39_0.long_0 && this.long_0 <= gclass39_0.long_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class55
  {
    public int int_0;

    public Class55()
    {
      
    }

    internal bool method_0(GClass158 gclass158_0)
    {
      return gclass158_0.int_0 >= this.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class56
  {
    public GClass40 gclass40_0;

    public Class56()
    {
      
    }

    internal bool method_0(GClass40 gclass40_1)
    {
      return gclass40_1.int_17 == 1 && gclass40_1 != this.gclass40_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class57
  {
    public GClass36 gclass36_0;

    public Class57()
    {
      
    }

    internal bool method_0(GClass31 gclass31_0)
    {
      return gclass31_0.gclass230_1 == this.gclass36_0.gclass230_0 && gclass31_0.int_1 == this.gclass36_0.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class58
  {
    public GClass40 gclass40_0;

    public Class58()
    {
      
    }

    internal bool method_0(GClass40 gclass40_1)
    {
      return gclass40_1.int_17 == 1 && gclass40_1 != this.gclass40_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class59
  {
    public GClass36 gclass36_0;

    public Class59()
    {
      
    }

    internal bool method_0(GClass31 gclass31_0)
    {
      return gclass31_0.gclass230_1 == this.gclass36_0.gclass230_0 && gclass31_0.int_1 == this.gclass36_0.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class60
  {
    public GClass31 gclass31_0;

    public Class60()
    {
      
    }

    internal bool method_0(GClass30 gclass30_0)
    {
      return gclass30_0.gclass230_0 == this.gclass31_0.gclass230_0 && gclass30_0.int_0 == this.gclass31_0.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class61
  {
    public GClass200 gclass200_0;
    public GClass0 gclass0_0;
    public System.Func<GClass65, bool> func_0;

    public Class61()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_1(GClass65 gclass65_0)
    {
      return gclass65_0.gclass200_0 == this.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class62
  {
    public GClass21 gclass21_0;
    public GClass0.Class61 class61_0;

    public Class62()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.genum10_0 == GEnum10.const_0 && gclass65_0.auroraContactType_0 == AuroraContactType.Salvo && gclass65_0.method_5() < AuroraContactStatus.Neutral && gclass65_0.decimal_3 == this.class61_0.gclass0_0.decimal_0 && gclass65_0.gclass21_1 == this.gclass21_0;
    }

    internal bool method_1(GClass40 gclass40_0)
    {
      return gclass40_0.gclass85_0.gclass202_0.gclass200_0 == this.class61_0.gclass200_0 && gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass22_0.decimal_11 > 0M;
    }
  }

  [CompilerGenerated]
  private sealed class Class63
  {
    public GClass132 gclass132_0;

    public Class63()
    {
      
    }

    internal bool method_0(GClass132 gclass132_1)
    {
      return gclass132_1.gclass132_0 == this.gclass132_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class64
  {
    public GClass221 gclass221_0;

    public Class64()
    {
      
    }

    internal bool method_0(GClass29 gclass29_0)
    {
      return gclass29_0.gclass221_0.double_0 == this.gclass221_0.double_0 && gclass29_0.gclass221_0.double_1 == this.gclass221_0.double_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class65
  {
    public GClass40 gclass40_0;
    public GClass0.Class62 class62_0;
    public System.Func<GClass132, double> func_0;

    public Class65()
    {
      
    }

    internal double method_0(GClass132 gclass132_0)
    {
      return this.class62_0.class61_0.gclass0_0.method_28(this.gclass40_0.gclass85_0.double_2, this.gclass40_0.gclass85_0.double_3, gclass132_0.double_0, gclass132_0.double_1);
    }
  }

  [CompilerGenerated]
  private sealed class Class66
  {
    public GClass36 gclass36_0;

    public Class66()
    {
      
    }

    internal bool method_0(GClass31 gclass31_0)
    {
      return gclass31_0.gclass230_1 == this.gclass36_0.gclass230_0 && gclass31_0.int_1 == this.gclass36_0.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class67
  {
    public GClass31 gclass31_0;

    public Class67()
    {
      
    }

    internal bool method_0(GClass30 gclass30_0)
    {
      return gclass30_0.gclass230_0 == this.gclass31_0.gclass230_0 && gclass30_0.int_0 == this.gclass31_0.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class68
  {
    public GClass200 gclass200_0;

    public Class68()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.gclass200_0 == this.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class69
  {
    public GClass200 gclass200_0;
    public AuroraContactType auroraContactType_0;
    public Decimal decimal_0;
    public double double_0;
    public double double_1;

    public Class69()
    {
      
    }

    internal bool method_0(GClass21 gclass21_0)
    {
      return gclass21_0.list_13.Contains(this.gclass200_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class70
  {
    public GClass21 gclass21_0;
    public GClass0.Class69 class69_0;

    public Class70()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.gclass21_1 == this.gclass21_0 && gclass65_0.auroraContactType_0 == this.class69_0.auroraContactType_0 && gclass65_0.decimal_0 == this.class69_0.decimal_0 && gclass65_0.gclass200_0 == this.class69_0.gclass200_0 && gclass65_0.double_0 == this.class69_0.double_0 && gclass65_0.double_1 == this.class69_0.double_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class71
  {
    public GClass40 gclass40_0;
    public GClass230 gclass230_0;
    public GClass39 gclass39_0;
    public string string_0;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public GClass129 gclass129_0;
    public double double_0;
    public double double_1;
    public bool bool_0;
    public bool bool_1;
    public bool bool_2;
    public GEnum62 genum62_0;

    public Class71()
    {
      
    }

    internal bool method_0(GClass37 gclass37_0)
    {
      return gclass37_0.gclass40_0 == this.gclass40_0 && gclass37_0.gclass230_0 == this.gclass230_0 && gclass37_0.gclass39_0 == this.gclass39_0 && gclass37_0.string_0 == this.string_0 && gclass37_0.decimal_0 == this.decimal_0 && gclass37_0.decimal_1 == this.decimal_1 && gclass37_0.gclass129_0 == this.gclass129_0 && gclass37_0.double_0 == this.double_0 && gclass37_0.double_1 == this.double_1 && gclass37_0.bool_2 == this.bool_0 && gclass37_0.bool_4 == this.bool_1 && gclass37_0.bool_5 == this.bool_2 && gclass37_0.genum62_0 == this.genum62_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class72
  {
    public int int_0;
    public System.Func<int, bool> func_0;
    public System.Func<int, int> func_1;

    public Class72()
    {
      
    }

    internal bool method_0(int int_1)
    {
      return int_1 > this.int_0;
    }

    internal int method_1(int int_1)
    {
      return int_1 - this.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class73
  {
    public List<GClass202> list_0;
    public List<GClass85> list_1;

    public Class73()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      return this.list_0.Contains(gclass40_0.gclass85_0.gclass202_0);
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return !this.list_1.Contains(gclass85_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class74
  {
    public List<GClass65> list_0;
    public GClass0 gclass0_0;

    public Class74()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return !this.list_0.Contains(gclass65_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class75
  {
    public GClass65 gclass65_0;
    public GClass0.Class74 class74_0;

    public Class75()
    {
      
    }

    internal bool method_0(GClass65 gclass65_1)
    {
      return gclass65_1.gclass40_0 == this.gclass65_0.gclass40_0 && gclass65_1.gclass21_1 == this.gclass65_0.gclass21_1;
    }

    internal bool method_1(GClass139 gclass139_0)
    {
      return gclass139_0.genum13_0 == GEnum13.const_4 && gclass139_0.int_2 == this.gclass65_0.int_0;
    }

    internal bool method_2(GClass212 gclass212_0)
    {
      return gclass212_0.gclass200_0 == this.gclass65_0.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class76
  {
    public double double_0;
    public GClass0.Class75 class75_0;

    public Class76()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.class75_0.gclass65_0.gclass200_0 && this.class75_0.class74_0.gclass0_0.method_28(gclass120_0.double_1, gclass120_0.double_2, this.class75_0.gclass65_0.double_0, this.class75_0.gclass65_0.double_1) < this.double_0;
    }

    internal bool method_1(GClass212 gclass212_0)
    {
      return gclass212_0.gclass200_0 == this.class75_0.gclass65_0.gclass200_0 && this.class75_0.class74_0.gclass0_0.method_28(gclass212_0.double_0, gclass212_0.double_1, this.class75_0.gclass65_0.double_0, this.class75_0.gclass65_0.double_1) < this.double_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class77
  {
    public GClass65 gclass65_0;
    public GClass0 gclass0_0;

    public Class77()
    {
      
    }

    internal bool method_0(GClass65 gclass65_1)
    {
      return gclass65_1.int_1 == this.gclass65_0.int_1 && gclass65_1.auroraContactType_0 == this.gclass65_0.auroraContactType_0 && gclass65_1.gclass21_1 == this.gclass65_0.gclass21_1 && gclass65_1.decimal_1 != this.gclass0_0.decimal_0 && gclass65_1.decimal_2 != this.gclass0_0.decimal_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class78
  {
    public GClass85 gclass85_0;

    public Class78()
    {
      
    }

    internal bool method_0(GClass85 gclass85_1)
    {
      return gclass85_1.gclass202_0.gclass200_0 == this.gclass85_0.gclass202_0.gclass200_0;
    }

    internal bool method_1(GClass21 gclass21_0)
    {
      return gclass21_0 != this.gclass85_0.gclass21_0;
    }

    internal bool method_2(GClass146 gclass146_0)
    {
      return gclass146_0.gclass202_0.gclass200_0 == this.gclass85_0.gclass202_0.gclass200_0;
    }

    internal bool method_3(GClass21 gclass21_0)
    {
      return gclass21_0 != this.gclass85_0.gclass21_0;
    }

    internal bool method_4(GClass132 gclass132_0)
    {
      return gclass132_0.gclass200_0 == this.gclass85_0.gclass202_0.gclass200_0;
    }

    internal bool method_5(GClass21 gclass21_0)
    {
      return gclass21_0 != this.gclass85_0.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class79
  {
    public Decimal decimal_0;
    public GClass0 gclass0_0;
    public GClass85 gclass85_0;
    public System.Func<GClass132, bool> func_0;
    public System.Func<GClass40, bool> func_1;

    public Class79()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.auroraContactType_0 == AuroraContactType.Ship && gclass65_0.decimal_3 == this.decimal_0;
    }

    internal bool method_1(GClass132 gclass132_0)
    {
      return gclass132_0.decimal_0 == this.gclass0_0.decimal_0;
    }

    internal bool method_2(GClass40 gclass40_0)
    {
      return gclass40_0.gclass85_0 == this.gclass85_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class80
  {
    public GClass200 gclass200_0;

    public Class80()
    {
      
    }

    internal bool method_0(GClass21 gclass21_0)
    {
      return gclass21_0.list_13.Contains(this.gclass200_0);
    }

    internal bool method_1(GClass40 gclass40_0)
    {
      return gclass40_0.gclass85_0.gclass202_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_2(GClass132 gclass132_0)
    {
      return gclass132_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_3(GClass146 gclass146_0)
    {
      return gclass146_0.gclass202_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_4(GClass120 gclass120_0)
    {
      return gclass120_0.int_2 > 0 && gclass120_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_5(GClass193 gclass193_0)
    {
      return gclass193_0.gclass40_0.gclass85_0.gclass202_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_6(GClass39 gclass39_0)
    {
      return gclass39_0.gclass103_0.gclass146_0.gclass202_0.gclass200_0 == this.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class81
  {
    public GClass21 gclass21_0;
    public GClass0.Class80 class80_0;

    public Class81()
    {
      
    }

    internal bool method_0(GClass66 gclass66_0)
    {
      return gclass66_0.gclass21_0 == this.gclass21_0 && gclass66_0.gclass200_0 == this.class80_0.gclass200_0;
    }

    internal bool method_1(GClass67 gclass67_0)
    {
      return gclass67_0.gclass21_0 == this.gclass21_0 && gclass67_0.gclass200_0 == this.class80_0.gclass200_0;
    }

    internal bool method_2(GClass67 gclass67_0)
    {
      return gclass67_0.gclass21_0 == this.gclass21_0 && gclass67_0.gclass200_0 == this.class80_0.gclass200_0;
    }

    internal bool method_3(GClass68 gclass68_0)
    {
      return gclass68_0.gclass21_0 == this.gclass21_0 && gclass68_0.gclass200_0 == this.class80_0.gclass200_0;
    }

    internal bool method_4(GClass120 gclass120_0)
    {
      return gclass120_0.dictionary_0[this.gclass21_0.RaceID].int_2 == 0;
    }
  }

  [CompilerGenerated]
  private sealed class Class82
  {
    public GClass93 gclass93_0;

    public Class82()
    {
      
    }

    internal bool method_0(GClass93 gclass93_1)
    {
      return gclass93_1.int_0 == this.gclass93_0.int_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class83
  {
    public int int_0;

    public Class83()
    {
      
    }

    internal bool method_0(GClass19 gclass19_0)
    {
      return gclass19_0.int_0 == this.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class84
  {
    public GClass197 gclass197_0;

    public Class84()
    {
      
    }

    internal bool method_0(GClass197 gclass197_1)
    {
      return gclass197_1.gclass200_0 == this.gclass197_0.gclass200_0 && gclass197_1.int_3 == this.gclass197_0.int_4;
    }
  }

  [CompilerGenerated]
  private sealed class Class85
  {
    public GClass85 gclass85_0;

    public Class85()
    {
      
    }

    internal bool method_0(GClass83 gclass83_0)
    {
      return gclass83_0.gclass21_0 == this.gclass85_0.gclass21_0 && gclass83_0.gclass83_0 == null;
    }
  }

  [CompilerGenerated]
  private sealed class Class86
  {
    public GClass39 gclass39_0;

    public Class86()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.gclass146_0 == this.gclass39_0.gclass103_0.gclass146_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class87
  {
    public GClass20 gclass20_0;

    public Class87()
    {
      
    }

    internal bool method_0(GClass16 gclass16_0)
    {
      return gclass16_0.int_1 == this.gclass20_0.int_24;
    }

    internal bool method_1(GClass12 gclass12_0)
    {
      return gclass12_0.genum90_0 == this.gclass20_0.genum90_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class88
  {
    public List<GClass1> list_0;

    public Class88()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0.bool_0 && this.list_0.Contains(gclass146_0.gclass1_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class89
  {
    public GClass21 gclass21_0;

    public Class89()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.decimal_4 > 0M && gclass146_0.gclass21_0 == this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class90
  {
    public GClass40 gclass40_0;

    public Class90()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass40_0.gclass21_0 && gclass146_0.gclass202_0 == this.gclass40_0.gclass85_0.gclass202_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class91
  {
    public GClass39 gclass39_0;

    public Class91()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass103_0 == this.gclass39_0.gclass103_0;
    }

    internal bool method_1(GClass39 gclass39_1)
    {
      return gclass39_1.gclass103_0.gclass146_0.gclass1_0 == this.gclass39_0.gclass103_0.gclass146_0.gclass1_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class92
  {
    public GClass85 gclass85_0;
    public GClass0 gclass0_0;
    public System.Func<GClass85, bool> func_0;
    public System.Func<GClass85, bool> func_1;
    public System.Func<GClass85, bool> func_2;
    public System.Func<GClass85, bool> func_3;

    public Class92()
    {
      
    }

    internal bool method_0(GClass85 gclass85_1)
    {
      return gclass85_1.gclass202_0.gclass200_0 == this.gclass85_0.gclass202_0.gclass200_0 && gclass85_1.gclass21_0 != this.gclass85_0.gclass21_0;
    }

    internal bool method_1(GClass85 gclass85_1)
    {
      return this.gclass85_0.gclass21_0.method_90(gclass85_1.gclass21_0) == AuroraContactStatus.Hostile;
    }

    internal bool method_2(GClass85 gclass85_1)
    {
      return gclass85_1.gclass202_0.gclass200_0 == this.gclass85_0.gclass202_0.gclass200_0 && gclass85_1.gclass21_0 != this.gclass85_0.gclass21_0;
    }

    internal bool method_3(GClass85 gclass85_1)
    {
      return this.gclass85_0.gclass21_0.method_90(gclass85_1.gclass21_0) == AuroraContactStatus.Hostile;
    }
  }

  [CompilerGenerated]
  private sealed class Class93
  {
    public GClass139 gclass139_0;
    public GClass0.Class92 class92_0;

    public Class93()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.double_2 == this.class92_0.gclass0_0.dictionary_13[this.gclass139_0.int_2].double_0 && gclass85_0.double_3 == this.class92_0.gclass0_0.dictionary_13[this.gclass139_0.int_2].double_1;
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.double_2 == this.class92_0.gclass0_0.dictionary_12[this.gclass139_0.int_2].double_1 && gclass85_0.double_3 == this.class92_0.gclass0_0.dictionary_12[this.gclass139_0.int_2].double_2;
    }
  }

  [CompilerGenerated]
  private sealed class Class94
  {
    public GClass40 gclass40_0;

    public Class94()
    {
      
    }

    internal bool method_0(GClass82 gclass82_0)
    {
      return gclass82_0.gclass202_0 == this.gclass40_0.gclass85_0.gclass202_0 && gclass82_0.double_0 == this.gclass40_0.gclass85_0.double_2 && gclass82_0.double_1 == this.gclass40_0.gclass85_0.double_3;
    }
  }

  [CompilerGenerated]
  private sealed class Class95
  {
    public GClass36 gclass36_0;

    public Class95()
    {
      
    }

    internal bool method_0(GClass31 gclass31_0)
    {
      return gclass31_0.gclass230_1 == this.gclass36_0.gclass230_0 && gclass31_0.int_1 == this.gclass36_0.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class96
  {
    public GClass31 gclass31_0;

    public Class96()
    {
      
    }

    internal bool method_0(GClass27 gclass27_0)
    {
      return gclass27_0.gclass230_0 == this.gclass31_0.gclass230_0 && gclass27_0.int_0 == this.gclass31_0.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class97
  {
    public GClass21 gclass21_0;

    public Class97()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.genum106_0 == GEnum106.const_1 && gclass85_0.dictionary_0.Count == 0 && gclass85_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_1(GClass110 gclass110_0)
    {
      return gclass110_0.gclass21_0 == this.gclass21_0 && gclass110_0.bool_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class98
  {
    public GClass85 gclass85_0;
    public GClass0 gclass0_0;

    public Class98()
    {
      
    }

    internal GClass120 method_0(GClass202 gclass202_0)
    {
      return gclass202_0.method_11(this.gclass85_0.gclass202_0).gclass120_0;
    }

    internal bool method_1(GClass120 gclass120_0)
    {
      return gclass120_0.dictionary_0[this.gclass85_0.gclass21_0.RaceID].int_4 == 0;
    }

    internal double method_2(GClass120 gclass120_0)
    {
      return this.gclass0_0.method_28(this.gclass85_0.double_2, this.gclass85_0.double_3, gclass120_0.double_1, gclass120_0.double_2);
    }
  }

  [CompilerGenerated]
  private sealed class Class99
  {
    public GClass44 gclass44_0;

    public Class99()
    {
      
    }

    internal bool method_0(GClass55 gclass55_0)
    {
      return gclass55_0.method_14() >= this.gclass44_0.gclass43_0.int_1 && gclass55_0.gclass21_0 == this.gclass44_0.gclass42_0.gclass21_0 && !gclass55_0.dictionary_1.ContainsKey(this.gclass44_0.gclass42_0.int_1);
    }
  }

  [CompilerGenerated]
  private sealed class Class100
  {
    public GClass110 gclass110_0;
    public GClass0 gclass0_0;

    public Class100()
    {
      
    }

    internal bool method_0(GClass110 gclass110_1)
    {
      return gclass110_1.gclass21_0 == this.gclass110_0.gclass21_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class101
  {
    public GClass40 gclass40_0;
    public GClass0.Class100 class100_0;

    public Class101()
    {
      
    }

    internal bool method_0(GClass115 gclass115_0)
    {
      return gclass115_0.gclass22_0 == this.gclass40_0.gclass22_0;
    }

    internal bool method_1(GClass117 gclass117_0)
    {
      return gclass117_0.gclass40_0 == this.gclass40_0;
    }

    internal bool method_2(GClass65 gclass65_0)
    {
      return gclass65_0.int_1 == this.gclass40_0.int_8 && gclass65_0.gclass21_1 == this.class100_0.gclass110_0.gclass21_1 && gclass65_0.decimal_3 == this.class100_0.gclass0_0.decimal_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class102
  {
    public GClass110 gclass110_0;
    public GClass0 gclass0_0;

    public Class102()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      if (gclass65_0.gclass21_0 != this.gclass110_0.gclass21_0 || gclass65_0.gclass21_1 != this.gclass110_0.gclass21_1 || !(gclass65_0.decimal_3 == this.gclass0_0.decimal_0))
        return false;
      return gclass65_0.auroraContactType_0 == AuroraContactType.Population || gclass65_0.auroraContactType_0 == AuroraContactType.Ship;
    }

    internal bool method_1(GClass65 gclass65_0)
    {
      if (gclass65_0.gclass21_0 != this.gclass110_0.gclass21_1 || gclass65_0.gclass21_1 != this.gclass110_0.gclass21_0 || !(gclass65_0.decimal_3 == this.gclass0_0.decimal_0))
        return false;
      return gclass65_0.auroraContactType_0 == AuroraContactType.Population || gclass65_0.auroraContactType_0 == AuroraContactType.Ship;
    }
  }

  [CompilerGenerated]
  private sealed class Class103
  {
    public List<GClass200> list_0;
    public GClass0.Class102 class102_0;

    public Class103()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.class102_0.gclass110_0.gclass21_0 && this.list_0.Contains(gclass40_0.gclass85_0.gclass202_0.gclass200_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class104
  {
    public GClass110 gclass110_0;
    public GClass0 gclass0_0;

    public Class104()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      if (gclass65_0.gclass21_0 != this.gclass110_0.gclass21_0 || gclass65_0.gclass21_1 != this.gclass110_0.gclass21_1 || !(gclass65_0.decimal_3 == this.gclass0_0.decimal_0))
        return false;
      return gclass65_0.auroraContactType_0 == AuroraContactType.Population || gclass65_0.auroraContactType_0 == AuroraContactType.Ship;
    }

    internal bool method_1(GClass65 gclass65_0)
    {
      if (gclass65_0.gclass21_0 != this.gclass110_0.gclass21_1 || gclass65_0.gclass21_1 != this.gclass110_0.gclass21_0 || !(gclass65_0.decimal_3 == this.gclass0_0.decimal_0))
        return false;
      return gclass65_0.auroraContactType_0 == AuroraContactType.Population || gclass65_0.auroraContactType_0 == AuroraContactType.Ship;
    }
  }

  [CompilerGenerated]
  private sealed class Class105
  {
    public List<GClass200> list_0;
    public GClass0.Class104 class104_0;

    public Class105()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.class104_0.gclass110_0.gclass21_1 && this.list_0.Contains(gclass40_0.gclass85_0.gclass202_0.gclass200_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class106
  {
    public GClass110 gclass110_0;
    public GClass0 gclass0_0;

    public Class106()
    {
      
    }

    internal bool method_0(GClass110 gclass110_1)
    {
      return gclass110_1.gclass21_0 == this.gclass110_0.gclass21_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class107
  {
    public GClass40 gclass40_0;
    public GClass117 gclass117_0;
    public GClass0.Class106 class106_0;

    public Class107()
    {
      
    }

    internal bool method_0(GClass115 gclass115_0)
    {
      return gclass115_0.gclass22_0 == this.gclass40_0.gclass22_0;
    }

    internal bool method_1(GClass117 gclass117_1)
    {
      return gclass117_1.gclass40_0 == this.gclass40_0;
    }

    internal bool method_2(GClass65 gclass65_0)
    {
      return gclass65_0.int_1 == this.gclass117_0.gclass40_0.int_8 && gclass65_0.gclass21_1 == this.class106_0.gclass110_0.gclass21_0 && gclass65_0.decimal_3 == this.class106_0.gclass0_0.decimal_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class108
  {
    public List<int> list_0;

    public Class108()
    {
      
    }

    internal bool method_0(GClass214 gclass214_0)
    {
      return !this.list_0.Contains(gclass214_0.int_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class109
  {
    public GClass1 gclass1_0;

    public Class109()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0.gclass1_0 == this.gclass1_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class110
  {
    public GClass187 gclass187_0;

    public Class110()
    {
      
    }

    internal bool method_0(GClass193 gclass193_0)
    {
      return gclass193_0.gclass21_0 == this.gclass187_0.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class111
  {
    public GClass21 gclass21_0;
    public System.Func<GClass85, bool> func_0;
    public System.Func<GClass103, bool> func_1;

    public Class111()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 != this.gclass21_0;
    }

    internal bool method_1(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0 != null && gclass103_0.gclass21_0 != this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class112
  {
    public GClass1 gclass1_0;

    public Class112()
    {
      
    }

    internal bool method_0(GClass172 gclass172_0)
    {
      return gclass172_0.gclass1_0 == this.gclass1_0;
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.gclass1_0 == this.gclass1_0;
    }

    internal bool method_2(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0.gclass1_0 == this.gclass1_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class113
  {
    public GClass1 gclass1_0;
    public GClass21 gclass21_0;

    public Class113()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass1_0 == this.gclass1_0 && gclass146_0.gclass21_0 == this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class114
  {
    public GClass1 gclass1_0;
    public GClass21 gclass21_0;

    public Class114()
    {
      
    }

    internal bool method_0(GClass202 gclass202_0)
    {
      return gclass202_0.gclass200_0 == this.gclass1_0.gclass200_0;
    }

    internal bool method_1(GClass83 gclass83_0)
    {
      return gclass83_0.gclass21_0 == this.gclass21_0 && gclass83_0.gclass83_0 == null;
    }

    internal bool method_2(GClass22 gclass22_0)
    {
      return gclass22_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_3(GClass146 gclass146_0)
    {
      return gclass146_0.gclass1_0 == this.gclass1_0 && gclass146_0.gclass21_0 == this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class115
  {
    public GClass130 gclass130_0;

    public Class115()
    {
      
    }

    internal bool method_0(GClass130 gclass130_1)
    {
      return gclass130_1.gclass129_0 == this.gclass130_0.gclass129_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class116
  {
    public GClass200 gclass200_0;
    public GClass200 gclass200_1;

    public Class116()
    {
      
    }

    internal double method_0(GClass198 gclass198_0)
    {
      return Math.Pow(gclass198_0.double_3 - this.gclass200_0.gclass198_0.double_3, 2.0) + Math.Pow(gclass198_0.double_4 - this.gclass200_0.gclass198_0.double_4, 2.0) + Math.Pow(gclass198_0.double_5 - this.gclass200_0.gclass198_0.double_5, 2.0);
    }

    internal bool method_1(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass200_1;
    }

    internal bool method_2(GClass197 gclass197_0)
    {
      return gclass197_0.gclass200_0 == this.gclass200_1 && gclass197_0.int_3 == 1;
    }
  }

  [CompilerGenerated]
  private sealed class Class117
  {
    public GClass198 gclass198_0;

    public Class117()
    {
      
    }

    internal bool method_0(GClass200 gclass200_0)
    {
      return gclass200_0.gclass198_0 == this.gclass198_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class118
  {
    public int int_0;

    public Class118()
    {
      
    }

    internal bool method_0(GClass200 gclass200_0)
    {
      return gclass200_0.int_1 == this.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class119
  {
    public GClass21 gclass21_0;

    public Class119()
    {
      
    }

    internal bool method_0(GClass22 gclass22_0)
    {
      return gclass22_0.gclass21_0 == this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class120
  {
    public GClass21 gclass21_0;

    public Class120()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass187_0 != null;
    }
  }

  [CompilerGenerated]
  private sealed class Class121
  {
    public GClass21 gclass21_0;

    public Class121()
    {
      
    }

    internal bool method_0(GClass193 gclass193_0)
    {
      return gclass193_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_1(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass21_0 && gclass146_0.decimal_30 > 10M;
    }
  }

  [CompilerGenerated]
  private sealed class Class122
  {
    public List<GClass200> list_0;
    public GClass21 gclass21_0;

    public Class122()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return this.list_0.Contains(gclass1_0.gclass200_0);
    }

    internal bool method_1(GClass1 gclass1_0)
    {
      return gclass1_0.dictionary_0.ContainsKey(AuroraElement.Duranium) && gclass1_0.method_16(80 /*0x50*/, false) && gclass1_0.method_77(this.gclass21_0);
    }

    internal bool method_2(GClass1 gclass1_0)
    {
      return this.list_0.Contains(gclass1_0.gclass200_0);
    }

    internal bool method_3(GClass1 gclass1_0)
    {
      return gclass1_0.dictionary_0.ContainsKey(AuroraElement.Gallicite) && gclass1_0.method_16(80 /*0x50*/, false) && gclass1_0.method_77(this.gclass21_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class123
  {
    public GClass132 gclass132_0;
    public GClass0 gclass0_0;

    public Class123()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass132_0.gclass200_0 && this.gclass0_0.method_520(gclass1_0.double_0, this.gclass132_0.double_0, gclass1_0.double_1, this.gclass132_0.double_1);
    }
  }

  [CompilerGenerated]
  private sealed class Class124
  {
    public GClass1 gclass1_0;
    public GClass0.Class123 class123_0;

    public Class124()
    {
      
    }

    internal bool method_0(GClass216 gclass216_0)
    {
      return gclass216_0.int_0 == this.gclass1_0.int_0 && gclass216_0.int_1 == this.class123_0.gclass132_0.gclass21_0.RaceID;
    }
  }

  [CompilerGenerated]
  private sealed class Class125
  {
    public List<GClass1> list_0;
    public List<GClass1> list_1;

    public Class125()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return this.list_0.Contains(gclass103_0.gclass146_0.gclass1_0);
    }

    internal bool method_1(GClass103 gclass103_0)
    {
      return this.list_1.Contains(gclass103_0.gclass146_0.gclass1_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class126
  {
    public GClass1 gclass1_0;

    public Class126()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0.gclass1_0 == this.gclass1_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class127
  {
    public GClass21 gclass21_0;
    public GClass0.Class126 class126_0;

    public Class127()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0.gclass1_0 == this.class126_0.gclass1_0 && gclass103_0.gclass21_0 == this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class128
  {
    public GClass1 gclass1_0;

    public Class128()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0.gclass1_0 == this.gclass1_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class129
  {
    public GClass21 gclass21_0;
    public GClass0.Class128 class128_0;

    public Class129()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0.gclass1_0 == this.class128_0.gclass1_0 && gclass103_0.gclass21_0 == this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class130
  {
    public GClass85 gclass85_0;
    public GClass0 gclass0_0;

    public Class130()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass85_0.gclass202_0.gclass200_0 && this.gclass0_0.method_520(gclass1_0.double_0, this.gclass85_0.double_2, gclass1_0.double_1, this.gclass85_0.double_3);
    }
  }

  [CompilerGenerated]
  private sealed class Class131
  {
    public GClass200 gclass200_0;
    public GClass1 gclass1_0;
    public GClass0 gclass0_0;
    public bool bool_0;

    public Class131()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass1_0 != null && gclass85_0.gclass202_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.gclass1_0 == this.gclass1_0;
    }

    internal bool method_2(GClass197 gclass197_0)
    {
      return gclass197_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_3(GClass1 gclass1_1)
    {
      return (gclass1_1.genum12_0 == GEnum12.const_1 || gclass1_1.genum12_0 == GEnum12.const_5 || gclass1_1.genum12_0 == GEnum12.const_3 && gclass1_1.double_21 == 0.0 && (this.gclass0_0.int_81 == 1 || this.bool_0)) && gclass1_1.gclass200_0 == this.gclass200_0 && !gclass1_1.bool_2;
    }

    internal bool method_4(GClass1 gclass1_1)
    {
      if (gclass1_1.genum12_0 == GEnum12.const_1 || gclass1_1.genum12_0 == GEnum12.const_5)
        return true;
      if (gclass1_1.genum12_0 != GEnum12.const_3 || gclass1_1.double_21 != 0.0)
        return false;
      return this.gclass0_0.int_81 == 1 || this.bool_0;
    }

    internal bool method_5(GClass1 gclass1_1)
    {
      return gclass1_1.genum12_0 == GEnum12.const_2 && gclass1_1.gclass200_0 == this.gclass200_0;
    }

    internal bool method_6(GClass1 gclass1_1)
    {
      return gclass1_1.genum12_0 == GEnum12.const_2 && gclass1_1.gclass1_0 == this.gclass1_0;
    }

    internal bool method_7(GClass1 gclass1_1)
    {
      return gclass1_1.genum12_0 == GEnum12.const_3 && gclass1_1.double_21 != 0.0 && gclass1_1.gclass200_0 == this.gclass200_0;
    }

    internal bool method_8(GClass1 gclass1_1)
    {
      return gclass1_1.genum12_0 == GEnum12.const_3 && gclass1_1.double_21 != 0.0 && gclass1_1.gclass1_0 == this.gclass1_0;
    }

    internal bool method_9(GClass212 gclass212_0)
    {
      return gclass212_0.gclass197_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_10(GClass212 gclass212_0)
    {
      return gclass212_0.gclass197_0.gclass200_0 == this.gclass1_0.gclass200_0;
    }

    internal bool method_11(GClass65 gclass65_0)
    {
      return gclass65_0.gclass40_0 != null && gclass65_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_12(GClass65 gclass65_0)
    {
      return gclass65_0.gclass40_0 != null && gclass65_0.gclass200_0 == this.gclass1_0.gclass200_0;
    }

    internal bool method_13(GClass65 gclass65_0)
    {
      return gclass65_0.gclass40_0.gclass85_0.gclass1_0 == this.gclass1_0;
    }

    internal bool method_14(GClass132 gclass132_0)
    {
      return gclass132_0.gclass1_0 != null && gclass132_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_15(GClass132 gclass132_0)
    {
      return gclass132_0.gclass1_0 == this.gclass1_0;
    }

    internal bool method_16(GClass65 gclass65_0)
    {
      return gclass65_0.gclass132_0 != null && gclass65_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_17(GClass65 gclass65_0)
    {
      return gclass65_0.gclass132_0 != null && gclass65_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_18(GClass65 gclass65_0)
    {
      return gclass65_0.gclass132_0.gclass1_0 == this.gclass1_0;
    }

    internal bool method_19(GClass214 gclass214_0)
    {
      return gclass214_0.gclass1_0 != null && gclass214_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_20(GClass214 gclass214_0)
    {
      return gclass214_0.gclass1_0 == this.gclass1_0;
    }

    internal bool method_21(GClass233 gclass233_0)
    {
      return gclass233_0.gclass1_0 != null && gclass233_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_22(GClass233 gclass233_0)
    {
      return gclass233_0.gclass1_0 == this.gclass1_0;
    }

    internal bool method_23(GClass65 gclass65_0)
    {
      return gclass65_0.gclass146_0 != null && gclass65_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_24(GClass65 gclass65_0)
    {
      return gclass65_0.gclass146_0 != null && gclass65_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_25(GClass65 gclass65_0)
    {
      return gclass65_0.gclass146_0.gclass1_0 == this.gclass1_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class132
  {
    public GClass40 gclass40_0;
    public GClass0 gclass0_0;

    public Class132()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      if (!this.gclass0_0.method_520(gclass1_0.double_0, this.gclass40_0.gclass85_0.double_2, gclass1_0.double_1, this.gclass40_0.gclass85_0.double_3))
        return false;
      return gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian;
    }
  }

  [CompilerGenerated]
  private sealed class Class133
  {
    public GClass200 gclass200_0;
    public GClass0 gclass0_0;

    public Class133()
    {
      
    }

    internal bool method_0(GClass200 gclass200_1)
    {
      return this.gclass0_0.method_29(this.gclass200_0.gclass198_0.double_3, this.gclass200_0.gclass198_0.double_4, this.gclass200_0.gclass198_0.double_5, gclass200_1.gclass198_0.double_3, gclass200_1.gclass198_0.double_4, gclass200_1.gclass198_0.double_5) < this.gclass200_0.double_3;
    }

    internal bool method_1(GClass200 gclass200_1)
    {
      return this.gclass0_0.method_29(this.gclass200_0.gclass198_0.double_3, this.gclass200_0.gclass198_0.double_4, this.gclass200_0.gclass198_0.double_5, gclass200_1.gclass198_0.double_3, gclass200_1.gclass198_0.double_4, gclass200_1.gclass198_0.double_5) < this.gclass200_0.double_3;
    }
  }

  [CompilerGenerated]
  private sealed class Class134
  {
    public GClass200 gclass200_0;

    public Class134()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.gclass202_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_2(GClass132 gclass132_0)
    {
      return gclass132_0.gclass200_0 == this.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class135
  {
    public GClass1 gclass1_0;

    public Class135()
    {
      
    }

    internal bool method_0(GClass1 gclass1_1)
    {
      return gclass1_1.gclass1_0 == this.gclass1_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class136
  {
    public GClass59 gclass59_0;

    public Class136()
    {
      
    }

    internal bool method_0(GClass55 gclass55_0)
    {
      return gclass55_0.gclass59_0 == this.gclass59_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class137
  {
    public List<GClass85> list_0;

    public Class137()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      return !gclass40_0.gclass22_0.bool_2 && gclass40_0.genum29_0 != GEnum29.const_1 && this.list_0.Contains(gclass40_0.gclass85_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class138
  {
    public List<GClass85> list_0;

    public Class138()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      return !gclass40_0.gclass22_0.bool_2 && gclass40_0.genum29_0 != GEnum29.const_1 && this.list_0.Contains(gclass40_0.gclass85_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class139
  {
    public List<GClass103> list_0;

    public Class139()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return !this.list_0.Contains(gclass103_0.gclass103_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class140
  {
    public GClass103 gclass103_0;

    public Class140()
    {
      
    }

    internal bool method_0(GClass103 gclass103_1)
    {
      return gclass103_1.gclass103_0 == this.gclass103_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class141
  {
    public GClass40 gclass40_0;
    public System.Func<GClass117, bool> func_0;
    public System.Func<GClass117, bool> func_1;
    public System.Func<GClass117, bool> func_2;

    public Class141()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass40_0 == this.gclass40_0;
    }

    internal bool method_1(GClass117 gclass117_0)
    {
      return gclass117_0.gclass40_0 == this.gclass40_0;
    }

    internal bool method_2(GClass117 gclass117_0)
    {
      return gclass117_0.gclass40_0 == this.gclass40_0;
    }

    internal bool method_3(GClass117 gclass117_0)
    {
      return gclass117_0.gclass40_0 == this.gclass40_0;
    }

    internal bool method_4(GClass103 gclass103_0)
    {
      return gclass103_0.gclass40_0 != null && gclass103_0.gclass21_0 == this.gclass40_0.gclass21_0;
    }

    internal bool method_5(GClass103 gclass103_0)
    {
      return gclass103_0.gclass40_0 == this.gclass40_0 || gclass103_0.gclass40_0.gclass40_0 == this.gclass40_0;
    }

    internal bool method_6(GClass117 gclass117_0)
    {
      return gclass117_0.gclass40_0 == this.gclass40_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class142
  {
    public List<GClass103> list_0;

    public Class142()
    {
      
    }

    internal bool method_0(GClass55 gclass55_0)
    {
      return this.list_0.Contains(gclass55_0.gclass103_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class143
  {
    public GClass114 gclass114_0;

    public Class143()
    {
      
    }

    internal bool method_0(GClass39 gclass39_0)
    {
      return gclass39_0.gclass101_0 == this.gclass114_0.gclass101_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class144
  {
    public List<GClass101> list_0;

    public Class144()
    {
      
    }

    internal bool method_0(GClass39 gclass39_0)
    {
      return !this.list_0.Contains(gclass39_0.gclass101_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class145
  {
    public List<GClass1> list_0;

    public Class145()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return this.list_0.Contains(gclass103_0.gclass146_0.gclass1_0);
    }

    internal bool method_1(GClass103 gclass103_0)
    {
      return this.list_0.Contains(gclass103_0.gclass146_0.gclass1_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class146
  {
    public GClass109 gclass109_0;
    public System.Func<GClass85, bool> func_0;

    public Class146()
    {
      
    }

    internal bool method_0(GClass172 gclass172_0)
    {
      return gclass172_0.gclass1_0.gclass200_0 == this.gclass109_0.gclass1_0.gclass200_0;
    }

    internal bool method_1(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0 != null && gclass103_0.gclass21_0 == this.gclass109_0.gclass21_0;
    }

    internal bool method_2(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0.gclass1_0 == this.gclass109_0.gclass1_0;
    }

    internal bool method_3(GClass85 gclass85_0)
    {
      return gclass85_0.gclass1_0 == this.gclass109_0.gclass1_0 && gclass85_0.gclass21_0 == this.gclass109_0.gclass21_0 && gclass85_0.method_36();
    }

    internal bool method_4(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0 != null && gclass103_0.gclass21_0 != this.gclass109_0.gclass21_0;
    }

    internal bool method_5(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0.gclass1_0 == this.gclass109_0.gclass1_0 && this.gclass109_0.gclass21_0.dictionary_10.ContainsKey(gclass103_0.gclass21_0.RaceID);
    }

    internal bool method_6(GClass103 gclass103_0)
    {
      return this.gclass109_0.gclass21_0.dictionary_10[gclass103_0.gclass21_0.RaceID].auroraContactStatus_0 == AuroraContactStatus.Hostile;
    }

    internal bool method_7(GClass146 gclass146_0)
    {
      return gclass146_0.gclass1_0 == this.gclass109_0.gclass1_0 && this.gclass109_0.gclass21_0.dictionary_10.ContainsKey(gclass146_0.gclass21_0.RaceID);
    }

    internal bool method_8(GClass146 gclass146_0)
    {
      return this.gclass109_0.gclass21_0.dictionary_10[gclass146_0.gclass21_0.RaceID].auroraContactStatus_0 == AuroraContactStatus.Hostile;
    }

    internal bool method_9(GClass146 gclass146_0)
    {
      return gclass146_0.gclass1_0 == this.gclass109_0.gclass1_0 && gclass146_0.gclass21_0 == this.gclass109_0.gclass21_0;
    }

    internal bool method_10(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass109_0.gclass21_0;
    }

    internal bool method_11(GClass46 gclass46_0)
    {
      return gclass46_0.gclass1_0 == this.gclass109_0.gclass1_0;
    }

    internal bool method_12(GClass85 gclass85_0)
    {
      return gclass85_0.gclass1_0 == this.gclass109_0.gclass1_0 && gclass85_0.gclass21_0 == this.gclass109_0.gclass21_0;
    }

    internal bool method_13(GClass40 gclass40_0)
    {
      return gclass40_0.gclass85_0.gclass1_0 == this.gclass109_0.gclass1_0 && gclass40_0.gclass21_0 == this.gclass109_0.gclass21_0 && gclass40_0.gclass85_0.method_42(GEnum123.const_103);
    }

    internal bool method_14(GClass40 gclass40_0)
    {
      return gclass40_0.gclass85_0.gclass1_0 == this.gclass109_0.gclass1_0 && gclass40_0.gclass21_0 == this.gclass109_0.gclass21_0 && gclass40_0.gclass85_0.method_42(GEnum123.const_103);
    }
  }

  [CompilerGenerated]
  private sealed class Class147
  {
    public long long_0;

    public Class147()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return this.long_0 >= gclass103_0.long_0 && this.long_0 <= gclass103_0.long_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class148
  {
    public long long_0;

    public Class148()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return this.long_0 >= gclass103_0.long_0 && this.long_0 <= gclass103_0.long_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class149
  {
    public GClass103 gclass103_0;

    public Class149()
    {
      
    }

    internal bool method_0(GClass103 gclass103_1)
    {
      return gclass103_1.gclass103_2 == this.gclass103_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class150
  {
    public long long_0;

    public Class150()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return this.long_0 >= gclass103_0.long_0 && this.long_0 <= gclass103_0.long_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class151
  {
    public List<GClass103> list_0;

    public Class151()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.list_2.Count > 0 && this.list_0.Contains(gclass103_0.gclass103_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class152
  {
    public GClass146 gclass146_0;

    public Class152()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0 == this.gclass146_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class153
  {
    public GClass146 gclass146_0;
    public GClass0.Class146 class146_0;

    public Class153()
    {
      
    }

    internal bool method_0(GClass146 gclass146_1)
    {
      return gclass146_1.gclass1_0 == this.class146_0.gclass109_0.gclass1_0 && gclass146_1 != this.gclass146_0 && gclass146_1.decimal_30 == 0M && gclass146_1.dictionary_0.Count == 0;
    }
  }

  [CompilerGenerated]
  private sealed class Class154
  {
    public GClass103 gclass103_0;
    public GClass0.Class146 class146_0;

    public Class154()
    {
      
    }

    internal bool method_0(GClass103 gclass103_1)
    {
      return gclass103_1.gclass103_1 == this.gclass103_0 && gclass103_1.auroraGroundFormationFieldPosition_0 == AuroraGroundFormationFieldPosition.Support && gclass103_1.gclass146_0 != null;
    }

    internal bool method_1(GClass103 gclass103_1)
    {
      return gclass103_1.gclass146_0.gclass1_0 == this.gclass103_0.gclass146_0.gclass1_0;
    }

    internal bool method_2(GClass103 gclass103_1)
    {
      return gclass103_1.gclass103_1 == this.gclass103_0 && gclass103_1.auroraGroundFormationFieldPosition_0 == AuroraGroundFormationFieldPosition.Support && gclass103_1.gclass146_0 != null;
    }

    internal bool method_3(GClass103 gclass103_1)
    {
      return gclass103_1.gclass146_0.gclass1_0 == this.gclass103_0.gclass146_0.gclass1_0;
    }

    internal bool method_4(GClass103 gclass103_1)
    {
      return gclass103_1.gclass103_1 == this.gclass103_0 && gclass103_1.auroraGroundFormationFieldPosition_0 == AuroraGroundFormationFieldPosition.RearEchelon && gclass103_1.gclass146_0 != null;
    }

    internal bool method_5(GClass103 gclass103_1)
    {
      return gclass103_1.gclass146_0.gclass1_0 == this.gclass103_0.gclass146_0.gclass1_0;
    }

    internal bool method_6(GClass40 gclass40_0)
    {
      return gclass40_0.gclass103_0 == this.gclass103_0;
    }

    internal bool method_7(GClass40 gclass40_0)
    {
      return gclass40_0.gclass85_0.gclass1_0 == this.gclass103_0.gclass146_0.gclass1_0 && gclass40_0.gclass21_0 == this.class146_0.gclass109_0.gclass21_0 && gclass40_0.gclass85_0.method_42(GEnum123.const_101);
    }

    internal bool method_8(GClass40 gclass40_0)
    {
      return gclass40_0.gclass103_0 == this.gclass103_0;
    }

    internal bool method_9(GClass40 gclass40_0)
    {
      return gclass40_0.gclass85_0.gclass1_0 == this.gclass103_0.gclass146_0.gclass1_0 && gclass40_0.gclass21_0 == this.class146_0.gclass109_0.gclass21_0 && gclass40_0.gclass85_0.method_42(GEnum123.const_105);
    }

    internal bool method_10(GClass103 gclass103_1)
    {
      return gclass103_1.gclass103_1 == this.gclass103_0.gclass103_2 && gclass103_1.auroraGroundFormationFieldPosition_0 == AuroraGroundFormationFieldPosition.Support && gclass103_1.gclass146_0 != null;
    }

    internal bool method_11(GClass103 gclass103_1)
    {
      return gclass103_1.gclass146_0.gclass1_0 == this.gclass103_0.gclass103_2.gclass146_0.gclass1_0;
    }

    internal bool method_12(GClass103 gclass103_1)
    {
      return gclass103_1.gclass103_1 == this.gclass103_0.gclass103_2 && gclass103_1.auroraGroundFormationFieldPosition_0 == AuroraGroundFormationFieldPosition.RearEchelon && gclass103_1.gclass146_0 != null;
    }

    internal bool method_13(GClass103 gclass103_1)
    {
      return gclass103_1.gclass146_0.gclass1_0 == this.gclass103_0.gclass103_2.gclass146_0.gclass1_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class155
  {
    public long long_0;

    public Class155()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return this.long_0 >= gclass103_0.long_0 && this.long_0 <= gclass103_0.long_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class156
  {
    public int int_0;

    public Class156()
    {
      
    }

    internal bool method_0(GClass39 gclass39_0)
    {
      return (long) this.int_0 >= gclass39_0.long_0 && (long) this.int_0 <= gclass39_0.long_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class157
  {
    public int int_0;

    public Class157()
    {
      
    }

    internal bool method_0(GClass39 gclass39_0)
    {
      return (long) this.int_0 >= gclass39_0.long_0 && (long) this.int_0 <= gclass39_0.long_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class158
  {
    public int int_0;

    public Class158()
    {
      
    }

    internal bool method_0(GClass39 gclass39_0)
    {
      return (long) this.int_0 >= gclass39_0.long_0 && (long) this.int_0 <= gclass39_0.long_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class159
  {
    public int int_0;

    public Class159()
    {
      
    }

    internal bool method_0(GClass39 gclass39_0)
    {
      return (long) this.int_0 >= gclass39_0.long_0 && (long) this.int_0 <= gclass39_0.long_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class160
  {
    public GClass21 gclass21_0;

    public Class160()
    {
      
    }

    internal bool method_0(GClass104 gclass104_0)
    {
      return gclass104_0.gclass21_0 == this.gclass21_0 && gclass104_0.int_3 > 0;
    }
  }

  [CompilerGenerated]
  private sealed class Class161
  {
    public GClass21 gclass21_0;

    public Class161()
    {
      
    }

    internal bool method_0(GClass104 gclass104_0)
    {
      return gclass104_0.gclass21_0 == this.gclass21_0 && gclass104_0.int_3 > 0;
    }

    internal bool method_1(GClass104 gclass104_0)
    {
      return gclass104_0.gclass21_0 == this.gclass21_0 && gclass104_0.int_3 > 0;
    }
  }

  [CompilerGenerated]
  private sealed class Class162
  {
    public GClass1 gclass1_0;
    public GClass0.Class161 class161_0;

    public Class162()
    {
      
    }

    internal bool method_0(GClass104 gclass104_0)
    {
      return gclass104_0.gclass21_0 == this.class161_0.gclass21_0 && gclass104_0.int_3 > 0 && gclass104_0.gclass1_0 == this.gclass1_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class163
  {
    public GClass40 gclass40_0;
    public GClass0.Class161 class161_0;

    public Class163()
    {
      
    }

    internal bool method_0(GClass104 gclass104_0)
    {
      return gclass104_0.gclass21_0 == this.class161_0.gclass21_0 && gclass104_0.int_3 > 0 && gclass104_0.gclass40_0 == this.gclass40_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class164
  {
    public GClass101 gclass101_0;
    public GClass21 gclass21_0;
    public GClass1 gclass1_0;

    public Class164()
    {
      
    }

    internal bool method_0(GClass104 gclass104_0)
    {
      return gclass104_0.gclass101_0 == this.gclass101_0 && gclass104_0.gclass21_0 == this.gclass21_0 && gclass104_0.gclass1_0 == this.gclass1_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class165
  {
    public GClass101 gclass101_0;
    public GClass21 gclass21_0;
    public GClass101 gclass101_1;
    public GClass1 gclass1_0;

    public Class165()
    {
      
    }

    internal bool method_0(GClass104 gclass104_0)
    {
      return gclass104_0.gclass101_0 == this.gclass101_0 && gclass104_0.gclass21_0 == this.gclass21_0 && gclass104_0.gclass101_1 == this.gclass101_1 && gclass104_0.gclass1_0 == this.gclass1_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class166
  {
    public GClass39 gclass39_0;

    public Class166()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0.gclass1_0 == this.gclass39_0.gclass103_0.gclass146_0.gclass1_0 && gclass103_0.gclass21_0 != this.gclass39_0.gclass103_0.gclass21_0;
    }

    internal bool method_1(GClass103 gclass103_0)
    {
      return gclass103_0.gclass40_0 == this.gclass39_0.gclass103_0.gclass40_0 && gclass103_0.gclass21_0 != this.gclass39_0.gclass103_0.gclass21_0;
    }

    internal bool method_2(GClass105 gclass105_0)
    {
      return gclass105_0.gclass21_0 == this.gclass39_0.gclass103_0.gclass21_0 && gclass105_0.gclass101_0 == this.gclass39_0.gclass101_0 && gclass105_0.gclass1_0 == this.gclass39_0.gclass103_0.gclass146_0.gclass1_0;
    }

    internal bool method_3(GClass105 gclass105_0)
    {
      return gclass105_0.gclass21_0 == this.gclass39_0.gclass103_0.gclass21_0 && gclass105_0.gclass101_0 == this.gclass39_0.gclass101_0 && gclass105_0.gclass40_0 == this.gclass39_0.gclass103_0.gclass40_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class167
  {
    public GClass21 gclass21_0;

    public Class167()
    {
      
    }

    internal bool method_0(GClass105 gclass105_0)
    {
      return gclass105_0.gclass21_0 == this.gclass21_0 && gclass105_0.int_0 > 0;
    }

    internal bool method_1(GClass105 gclass105_0)
    {
      return gclass105_0.gclass21_0 == this.gclass21_0 && gclass105_0.int_0 > 0;
    }
  }

  [CompilerGenerated]
  private sealed class Class168
  {
    public GClass1 gclass1_0;
    public GClass0.Class167 class167_0;

    public Class168()
    {
      
    }

    internal bool method_0(GClass105 gclass105_0)
    {
      return gclass105_0.gclass21_0 == this.class167_0.gclass21_0 && gclass105_0.gclass1_0 == this.gclass1_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class169
  {
    public GClass40 gclass40_0;
    public GClass0.Class167 class167_0;

    public Class169()
    {
      
    }

    internal bool method_0(GClass105 gclass105_0)
    {
      return gclass105_0.gclass21_0 == this.class167_0.gclass21_0 && gclass105_0.gclass40_0 == this.gclass40_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class170
  {
    public GClass21 gclass21_0;

    public Class170()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass21_0 && gclass85_0.gclass1_0 != null;
    }
  }

  [CompilerGenerated]
  private sealed class Class171
  {
    public List<GClass1> list_0;
    public GClass0.Class170 class170_0;
    public System.Func<GClass146, bool> func_0;
    public System.Func<GClass146, bool> func_1;

    public Class171()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return this.list_0.Contains(gclass146_0.gclass1_0);
    }

    internal bool method_1(GClass146 gclass146_0)
    {
      return this.list_0.Contains(gclass146_0.gclass1_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class172
  {
    public GClass21 gclass21_0;
    public GClass0.Class171 class171_0;

    public Class172()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_1(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class173
  {
    public GClass1 gclass1_0;
    public GClass0.Class172 class172_0;

    public Class173()
    {
      
    }

    internal bool method_0(GClass109 gclass109_0)
    {
      return gclass109_0.gclass1_0 == this.gclass1_0 && gclass109_0.gclass21_0 == this.class172_0.class171_0.class170_0.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class174
  {
    public GClass21 gclass21_0;

    public Class174()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass21_0 || this.gclass21_0 == null;
    }

    internal bool method_1(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.gclass21_0 || this.gclass21_0 == null;
    }
  }

  [CompilerGenerated]
  private sealed class Class175
  {
    public List<int> list_0;

    public Class175()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      return !this.list_0.Contains(gclass40_0.gclass22_0.int_39);
    }
  }

  [CompilerGenerated]
  private sealed class Class176
  {
    public GClass146 gclass146_0;
    public GClass0 gclass0_0;

    public Class176()
    {
      
    }

    internal bool method_0(GClass121 gclass121_0)
    {
      return gclass121_0.gclass21_0 == this.gclass146_0.gclass21_0 && this.gclass0_0.method_520(gclass121_0.double_0, this.gclass146_0.method_87(), gclass121_0.double_1, this.gclass146_0.method_88());
    }
  }

  [CompilerGenerated]
  private sealed class Class177
  {
    public GClass40 gclass40_0;
    public GClass0 gclass0_0;

    public Class177()
    {
      
    }

    internal bool method_0(GClass121 gclass121_0)
    {
      return gclass121_0.gclass21_0 == this.gclass40_0.gclass21_0 && this.gclass0_0.method_520(gclass121_0.double_0, this.gclass40_0.gclass85_0.double_2, gclass121_0.double_1, this.gclass40_0.gclass85_0.double_3);
    }
  }

  [CompilerGenerated]
  private sealed class Class178
  {
    public GClass40 gclass40_0;
    public GClass0 gclass0_0;

    public Class178()
    {
      
    }

    internal bool method_0(GClass121 gclass121_0)
    {
      return gclass121_0.gclass21_0 == this.gclass40_0.gclass21_0 && gclass121_0.gclass202_0 == this.gclass40_0.gclass85_0.gclass202_0 && this.gclass0_0.method_520(gclass121_0.double_0, this.gclass40_0.gclass85_0.double_2, gclass121_0.double_1, this.gclass40_0.gclass85_0.double_3);
    }
  }

  [CompilerGenerated]
  private sealed class Class179
  {
    public GClass146 gclass146_0;
    public GClass194 gclass194_0;
    public GClass21 gclass21_0;
    public int int_0;
    public System.Func<GClass85, bool> func_0;

    public Class179()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0 != this.gclass146_0.gclass1_0;
    }

    internal bool method_1(GClass1 gclass1_0)
    {
      return gclass1_0.double_7 >= this.gclass194_0.double_7 && gclass1_0.double_7 <= this.gclass194_0.double_8;
    }

    internal bool method_2(GClass1 gclass1_0)
    {
      return gclass1_0.method_14(this.gclass194_0);
    }

    internal bool method_3(GClass146 gclass146_1)
    {
      return gclass146_1.gclass21_0 == this.gclass21_0;
    }

    internal bool method_4(GClass146 gclass146_1)
    {
      return gclass146_1.gclass21_0 == this.gclass21_0;
    }

    internal bool method_5(GClass146 gclass146_1)
    {
      return gclass146_1.gclass21_0 == this.gclass21_0;
    }

    internal bool method_6(GClass146 gclass146_1)
    {
      return gclass146_1.gclass21_0 == this.gclass21_0;
    }

    internal bool method_7(GClass200 gclass200_0)
    {
      return gclass200_0.double_6 < 10.0 && gclass200_0.int_13 < this.int_0;
    }

    internal bool method_8(GClass146 gclass146_1)
    {
      return gclass146_1.gclass21_0 == this.gclass21_0 && gclass146_1 != this.gclass146_0;
    }

    internal bool method_9(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_10(GClass103 gclass103_0)
    {
      return gclass103_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_11(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_12(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_13(GClass146 gclass146_1)
    {
      return gclass146_1 != this.gclass146_0;
    }

    internal bool method_14(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_15(GClass146 gclass146_1)
    {
      return gclass146_1.gclass21_0 == this.gclass21_0 && gclass146_1.decimal_30 > 10M;
    }
  }

  [CompilerGenerated]
  private sealed class Class180
  {
    public List<GClass1> list_0;
    public List<GClass200> list_1;
    public GClass0.Class179 class179_0;

    public Class180()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return !this.list_0.Contains(gclass1_0);
    }

    internal bool method_1(GClass1 gclass1_0)
    {
      return gclass1_0.double_42 > GClass226.double_29 && !this.list_0.Contains(gclass1_0);
    }

    internal bool method_2(GClass200 gclass200_0)
    {
      return !this.list_1.Contains(gclass200_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class181
  {
    public int int_0;

    public Class181()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.decimal_1 > 0M && gclass1_0.decimal_1 < (Decimal) this.int_0 && gclass1_0.decimal_1 >= (Decimal) (this.int_0 - 1);
    }
  }

  [CompilerGenerated]
  private sealed class Class182
  {
    public GClass200 gclass200_0;
    public GClass0.Class180 class180_0;

    public Class182()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass200_0 && gclass1_0.decimal_1 < 5M && gclass1_0.double_7 >= this.class180_0.class179_0.gclass194_0.double_7 && gclass1_0.double_7 <= this.class180_0.class179_0.gclass194_0.double_8;
    }
  }

  [CompilerGenerated]
  private sealed class Class183
  {
    public GClass146 gclass146_0;

    public Class183()
    {
      
    }

    internal bool method_0(GClass16 gclass16_0)
    {
      return gclass16_0.genum97_0 == this.gclass146_0.gclass6_0.genum97_0;
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.gclass146_0 == this.gclass146_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class184
  {
    public GClass16 gclass16_0;

    public Class184()
    {
      
    }

    internal bool method_0(GClass102 gclass102_0)
    {
      return gclass102_0.genum116_0 == this.gclass16_0.genum116_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class185
  {
    public GClass200 gclass200_0;
    public System.Func<GClass197, bool> func_0;
    public System.Func<GClass1, bool> func_1;

    public Class185()
    {
      
    }

    internal bool method_0(GClass197 gclass197_0)
    {
      return gclass197_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_1(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass200_0 && gclass1_0.gclass197_0.bool_1 && (gclass1_0.genum12_0 == GEnum12.const_1 || gclass1_0.genum12_0 == GEnum12.const_2) && gclass1_0.auroraSystemBodyType_0 != AuroraSystemBodyType.GasGiant && gclass1_0.auroraSystemBodyType_0 != AuroraSystemBodyType.Superjovian;
    }
  }

  [CompilerGenerated]
  private sealed class Class186
  {
    public GClass1 gclass1_0;
    public GClass194 gclass194_0;
    public GClass21 gclass21_0;

    public Class186()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass1_0 == this.gclass1_0 && gclass146_0.gclass194_0 == this.gclass194_0;
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class187
  {
    public List<GClass200> list_0;
    public GClass0.Class186 class186_0;

    public Class187()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return this.list_0.Contains(gclass1_0.gclass200_0) && gclass1_0 != this.class186_0.gclass1_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class188
  {
    public List<GClass200> list_0;

    public Class188()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return this.list_0.Contains(gclass120_0.gclass200_0) && gclass120_0.gclass120_0 == null;
    }
  }

  [CompilerGenerated]
  private sealed class Class189
  {
    public GClass164 gclass164_0;
    public GClass163 gclass163_0;

    public Class189()
    {
      
    }

    internal bool method_0(GClass164 gclass164_1)
    {
      return gclass164_1.gclass163_0 == this.gclass163_0 && !gclass164_1.bool_4 && gclass164_1.decimal_0 > this.gclass164_0.decimal_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class190
  {
    public GClass164 gclass164_0;
    public GClass163 gclass163_0;

    public Class190()
    {
      
    }

    internal bool method_0(GClass164 gclass164_1)
    {
      return gclass164_1.gclass163_0 == this.gclass163_0 && !gclass164_1.bool_4 && gclass164_1.decimal_0 > this.gclass164_0.decimal_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class191
  {
    public GClass164 gclass164_0;
    public GClass163 gclass163_0;

    public Class191()
    {
      
    }

    internal bool method_0(GClass164 gclass164_1)
    {
      return gclass164_1.gclass163_0 == this.gclass163_0 && !gclass164_1.bool_4 && gclass164_1.decimal_0 > this.gclass164_0.decimal_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class192
  {
    public GClass164 gclass164_0;
    public GClass163 gclass163_0;

    public Class192()
    {
      
    }

    internal bool method_0(GClass164 gclass164_1)
    {
      return gclass164_1.gclass163_0 == this.gclass163_0 && !gclass164_1.bool_4 && gclass164_1.decimal_0 > this.gclass164_0.decimal_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class193
  {
    public GClass164 gclass164_0;
    public GClass163 gclass163_0;

    public Class193()
    {
      
    }

    internal bool method_0(GClass164 gclass164_1)
    {
      return gclass164_1.gclass163_0 == this.gclass163_0 && !gclass164_1.bool_4 && gclass164_1.decimal_0 > this.gclass164_0.decimal_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class194
  {
    public GClass164 gclass164_0;
    public GClass163 gclass163_0;

    public Class194()
    {
      
    }

    internal bool method_0(GClass164 gclass164_1)
    {
      return gclass164_1.gclass163_0 == this.gclass163_0 && !gclass164_1.bool_4 && gclass164_1.decimal_0 > this.gclass164_0.decimal_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class195
  {
    public GClass21 gclass21_0;
    public Decimal decimal_0;

    public Class195()
    {
      
    }

    internal bool method_0(GClass164 gclass164_0)
    {
      return gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass164_0.decimal_0 >= this.decimal_0;
    }

    internal bool method_1(GClass164 gclass164_0)
    {
      return gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass164_0.decimal_0 >= this.decimal_0 / 2M;
    }

    internal bool method_2(GClass164 gclass164_0)
    {
      return gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass164_0.decimal_0 >= this.decimal_0 / 3M;
    }
  }

  [CompilerGenerated]
  private sealed class Class196
  {
    public GClass164 gclass164_0;
    public GClass163 gclass163_0;

    public Class196()
    {
      
    }

    internal bool method_0(GClass164 gclass164_1)
    {
      return gclass164_1.gclass163_0 == this.gclass163_0 && !gclass164_1.bool_4 && gclass164_1.decimal_0 > this.gclass164_0.decimal_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class197
  {
    public GClass21 gclass21_0;
    public GClass0 gclass0_0;

    public Class197()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.decimal_30 > 0M && gclass146_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_1(GClass164 gclass164_0)
    {
      return gclass164_0.gclass163_0 == this.gclass0_0.dictionary_49[GEnum122.const_146] && gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_2(GClass164 gclass164_0)
    {
      return gclass164_0.gclass163_0 == this.gclass0_0.dictionary_49[GEnum122.const_146];
    }
  }

  [CompilerGenerated]
  private sealed class Class198
  {
    public GClass163 gclass163_0;
    public GClass0.Class197 class197_0;

    public Class198()
    {
      
    }

    internal bool method_0(GClass164 gclass164_0)
    {
      return gclass164_0.gclass163_0 == this.gclass163_0 && gclass164_0.dictionary_0.ContainsKey(this.class197_0.gclass21_0.RaceID);
    }

    internal bool method_1(GClass164 gclass164_0)
    {
      return gclass164_0.gclass163_0 == this.gclass163_0 && !gclass164_0.bool_4;
    }
  }

  [CompilerGenerated]
  private sealed class Class199
  {
    public GClass164 gclass164_0;
    public GClass0.Class198 class198_0;

    public Class199()
    {
      
    }

    internal bool method_0(GClass164 gclass164_1)
    {
      return gclass164_1.gclass163_0 == this.class198_0.gclass163_0 && gclass164_1.int_4 <= this.gclass164_0.int_4;
    }
  }

  [CompilerGenerated]
  private sealed class Class200
  {
    public GClass58 gclass58_0;

    public Class200()
    {
      
    }

    internal bool method_0(GClass57 gclass57_0)
    {
      return gclass57_0.gclass58_0 == this.gclass58_0 && !gclass57_0.bool_0;
    }

    internal bool method_1(GClass57 gclass57_0)
    {
      return gclass57_0.gclass58_0 == this.gclass58_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class201
  {
    public int int_0;

    public Class201()
    {
      
    }

    internal bool method_0(GClass47 gclass47_0)
    {
      return gclass47_0.int_1 == this.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class202
  {
    public AuroraComponentType auroraComponentType_0;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public Decimal decimal_2;
    public GClass21 gclass21_0;

    public Class202()
    {
      
    }

    internal bool method_0(GClass230 gclass230_0)
    {
      return gclass230_0.gclass164_0.int_1 == 1 && gclass230_0.gclass231_0.auroraComponentType_0 == this.auroraComponentType_0 && gclass230_0.decimal_1 == this.decimal_0 && gclass230_0.decimal_3 == this.decimal_1 && gclass230_0.decimal_2 == this.decimal_2;
    }

    internal bool method_1(GClass230 gclass230_0)
    {
      return gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass230_0.gclass231_0.auroraComponentType_0 == this.auroraComponentType_0 && gclass230_0.decimal_1 == this.decimal_0 && gclass230_0.decimal_3 == this.decimal_1 && gclass230_0.decimal_2 == this.decimal_2;
    }
  }

  [CompilerGenerated]
  private sealed class Class203
  {
    public GClass21 gclass21_0;
    public GClass230 gclass230_0;

    public Class203()
    {
      
    }

    internal bool method_0(GClass230 gclass230_1)
    {
      return gclass230_1.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass230_1.gclass231_0.auroraComponentType_0 == this.gclass230_0.gclass231_0.auroraComponentType_0 && gclass230_1.decimal_1 == this.gclass230_0.decimal_1 && gclass230_1.decimal_3 == this.gclass230_0.decimal_3 && gclass230_1.decimal_2 == this.gclass230_0.decimal_2;
    }
  }

  [CompilerGenerated]
  private sealed class Class204
  {
    public GClass0 gclass0_0;
    public GEnum122 genum122_0;
    public int int_0;

    public Class204()
    {
      
    }

    internal bool method_0(GClass164 gclass164_0)
    {
      return gclass164_0.gclass163_0 == this.gclass0_0.dictionary_49[this.genum122_0] && gclass164_0.int_4 <= this.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class205
  {
    public GClass162 gclass162_0;

    public Class205()
    {
      
    }

    internal bool method_0(GClass163 gclass163_0)
    {
      return gclass163_0.gclass162_0 == this.gclass162_0 && gclass163_0.bool_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class206
  {
    public GClass146 gclass146_0;

    public Class206()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0 == this.gclass146_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class207
  {
    public List<GClass200> list_0;

    public Class207()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      return this.list_0.Contains(gclass40_0.gclass85_0.gclass202_0.gclass200_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class208
  {
    public GClass21 gclass21_0;

    public Class208()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.gclass21_1 == this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class209
  {
    public List<GClass200> list_0;

    public Class209()
    {
      
    }

    internal bool method_0(GClass39 gclass39_0)
    {
      return this.list_0.Contains(gclass39_0.gclass103_0.gclass146_0.gclass202_0.gclass200_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class210
  {
    public GClass40 gclass40_0;

    public Class210()
    {
      
    }

    internal bool method_0(GClass25 gclass25_0)
    {
      return gclass25_0.gclass40_0 == this.gclass40_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class211
  {
    public List<GClass132> list_0;
    public GClass0 gclass0_0;

    public Class211()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return this.list_0.Contains(gclass65_0.gclass132_0) && gclass65_0.genum10_0 == GEnum10.const_0 && gclass65_0.decimal_3 == this.gclass0_0.decimal_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class212
  {
    public GClass21 gclass21_0;

    public Class212()
    {
      
    }
  }

  [CompilerGenerated]
  private sealed class Class213
  {
    public GClass40 gclass40_0;
    public GClass0.Class212 class212_0;

    public Class213()
    {
      
    }

    internal bool method_0(GClass117 gclass117_0)
    {
      return gclass117_0.gclass40_0 == this.gclass40_0;
    }

    internal bool method_1(GClass65 gclass65_0)
    {
      return gclass65_0.gclass21_1 == this.class212_0.gclass21_0 && gclass65_0.gclass132_0.gclass40_0 == this.gclass40_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class214
  {
    public int int_0;

    public Class214()
    {
      
    }

    internal bool method_0(GClass132 gclass132_0)
    {
      return gclass132_0.gclass129_0.decimal_4 == (Decimal) this.int_0;
    }

    internal bool method_1(GClass230 gclass230_0)
    {
      return gclass230_0.decimal_3 == (Decimal) this.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class215
  {
    public List<int> list_0;
    public List<int> list_1;

    public Class215()
    {
      
    }

    internal bool method_0(GClass164 gclass164_0)
    {
      return this.list_0.Contains(gclass164_0.int_0);
    }

    internal bool method_1(GClass185 gclass185_0)
    {
      return this.list_1.Contains(gclass185_0.int_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class216
  {
    public List<int> list_0;

    public Class216()
    {
      
    }

    internal bool method_0(GClass76 gclass76_0)
    {
      return this.list_0.Contains(gclass76_0.int_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class217
  {
    public GClass76 gclass76_0;

    public Class217()
    {
      
    }

    internal bool method_0(GClass184 gclass184_0)
    {
      return gclass184_0.int_1 == this.gclass76_0.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class218
  {
    public GClass21 gclass21_0;

    public Class218()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_1(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_2(GClass55 gclass55_0)
    {
      return gclass55_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_3(GClass22 gclass22_0)
    {
      return gclass22_0.gclass21_0 == this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class219
  {
    public GClass21 gclass21_0;
    public GClass146 gclass146_0;

    public Class219()
    {
      
    }

    internal bool method_0(GClass159 gclass159_0)
    {
      return gclass159_0.gclass21_0 == this.gclass21_0 && gclass159_0.gclass146_0 == this.gclass146_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class220
  {
    public GClass200 gclass200_0;

    public Class220()
    {
      
    }

    internal bool method_0(GClass202 gclass202_0)
    {
      return gclass202_0.gclass200_0 == this.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class221
  {
    public GClass21 gclass21_0;

    public Class221()
    {
      
    }

    internal bool method_0(GClass83 gclass83_0)
    {
      return gclass83_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_1(GClass22 gclass22_0)
    {
      return gclass22_0.gclass21_0 == this.gclass21_0 && gclass22_0.int_38 == 0;
    }

    internal bool method_2(GClass12 gclass12_0)
    {
      return gclass12_0.int_0 > this.gclass21_0.int_55;
    }
  }

  [CompilerGenerated]
  private sealed class Class222
  {
    public int int_0;

    public Class222()
    {
      
    }

    internal bool method_0(GClass211 gclass211_0)
    {
      return gclass211_0.int_0 >= this.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class223
  {
    public GClass11 gclass11_0;

    public Class223()
    {
      
    }

    internal bool method_0(GClass22 gclass22_0)
    {
      return gclass22_0.gclass14_0.genum120_0 == this.gclass11_0.gclass14_0.genum120_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class224
  {
    public GClass211 gclass211_0;
    public GClass0 gclass0_0;

    public Class224()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass211_0.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class225
  {
    public double double_0;
    public GClass0.Class224 class224_0;

    public Class225()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return this.class224_0.gclass0_0.method_28(gclass1_0.double_0, gclass1_0.double_1, this.class224_0.gclass211_0.double_0, this.class224_0.gclass211_0.double_1) < this.double_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class226
  {
    public AuroraCommanderType auroraCommanderType_0;

    public Class226()
    {
      
    }

    internal bool method_0(GClass49 gclass49_0)
    {
      return gclass49_0.auroraCommanderType_0 == AuroraCommanderType.All || gclass49_0.auroraCommanderType_0 == this.auroraCommanderType_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class227
  {
    public List<GClass21> list_0;

    public Class227()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return this.list_0.Contains(gclass146_0.gclass21_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class228
  {
    public GClass21 gclass21_0;
    public System.Func<GClass40, bool> func_0;

    public Class228()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_1(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_2(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.gclass21_0 && !gclass40_0.gclass22_0.bool_2 && gclass40_0.gclass187_0 == null;
    }

    internal bool method_3(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass22_0.bool_2 && gclass40_0.gclass187_0 == null && gclass40_0.gclass22_0.int_37 == 0;
    }

    internal bool method_4(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass22_0.bool_2 && gclass40_0.gclass187_0 == null && gclass40_0.gclass22_0.int_37 == 1;
    }

    internal bool method_5(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass187_0 != null;
    }

    internal bool method_6(GClass103 gclass103_0)
    {
      return gclass103_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_7(GClass193 gclass193_0)
    {
      return gclass193_0.gclass21_0 == this.gclass21_0 && gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Naval;
    }

    internal bool method_8(GClass193 gclass193_0)
    {
      return gclass193_0.gclass21_0 == this.gclass21_0 && gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Commercial;
    }

    internal bool method_9(GClass193 gclass193_0)
    {
      return gclass193_0.gclass21_0 == this.gclass21_0 && gclass193_0.auroraShipyardType_0 == AuroraShipyardType.RepairYard;
    }

    internal bool method_10(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_11(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_12(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_13(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_14(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_15(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_16(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_17(GClass55 gclass55_0)
    {
      return gclass55_0.auroraCommanderType_0 == AuroraCommanderType.Scientist && gclass55_0.gclass21_0 == this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class229
  {
    public IGrouping<GClass157, GClass158> igrouping_0;

    public Class229()
    {
      
    }

    internal bool method_0(GClass158 gclass158_0)
    {
      return gclass158_0.gclass157_0 == this.igrouping_0.Key;
    }

    internal bool method_1(GClass158 gclass158_0)
    {
      return gclass158_0.gclass157_0 == this.igrouping_0.Key;
    }
  }

  [CompilerGenerated]
  private sealed class Class230
  {
    public GClass193 gclass193_0;

    public Class230()
    {
      
    }

    internal bool method_0(GClass192 gclass192_0)
    {
      return gclass192_0.gclass193_0 == this.gclass193_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class231
  {
    public GClass58 gclass58_0;

    public Class231()
    {
      
    }

    internal bool method_0(GClass57 gclass57_0)
    {
      return gclass57_0.gclass58_0 == this.gclass58_0 && gclass57_0.bool_0;
    }

    internal bool method_1(GClass57 gclass57_0)
    {
      return gclass57_0.gclass58_0 == this.gclass58_0 && gclass57_0.bool_1;
    }

    internal bool method_2(GClass57 gclass57_0)
    {
      return gclass57_0.gclass58_0 == this.gclass58_0 && gclass57_0.bool_0;
    }

    internal bool method_3(GClass57 gclass57_0)
    {
      return gclass57_0.gclass58_0 == this.gclass58_0 && gclass57_0.bool_1;
    }

    internal bool method_4(GClass57 gclass57_0)
    {
      return gclass57_0.gclass58_0 == this.gclass58_0 && gclass57_0.bool_0;
    }

    internal bool method_5(GClass57 gclass57_0)
    {
      return gclass57_0.gclass58_0 == this.gclass58_0 && gclass57_0.bool_1;
    }

    internal bool method_6(GClass57 gclass57_0)
    {
      return gclass57_0.gclass58_0 == this.gclass58_0 && gclass57_0.bool_2;
    }

    internal bool method_7(GClass57 gclass57_0)
    {
      return gclass57_0.gclass58_0 == this.gclass58_0 && gclass57_0.bool_0;
    }

    internal bool method_8(GClass57 gclass57_0)
    {
      return gclass57_0.gclass58_0 == this.gclass58_0 && gclass57_0.bool_1;
    }

    internal bool method_9(GClass57 gclass57_0)
    {
      return gclass57_0.gclass58_0 == this.gclass58_0 && gclass57_0.bool_2;
    }

    internal bool method_10(GClass57 gclass57_0)
    {
      return gclass57_0.gclass58_0 == this.gclass58_0 && gclass57_0.bool_0;
    }

    internal bool method_11(GClass57 gclass57_0)
    {
      return gclass57_0.gclass58_0 == this.gclass58_0 && gclass57_0.bool_1;
    }

    internal bool method_12(GClass57 gclass57_0)
    {
      return gclass57_0.gclass58_0 == this.gclass58_0 && gclass57_0.bool_2;
    }
  }

  [CompilerGenerated]
  private sealed class Class232
  {
    public GClass1 gclass1_0;

    public Class232()
    {
      
    }

    internal bool method_0(GClass1 gclass1_1)
    {
      return gclass1_1.gclass200_0 == this.gclass1_0.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class233
  {
    public GClass21 gclass21_0;
    public GClass194 gclass194_0;

    public Class233()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.method_58(this.gclass21_0, this.gclass194_0, true) < 5M;
    }
  }

  [CompilerGenerated]
  private sealed class Class234
  {
    public GClass21 gclass21_0;

    public Class234()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class235
  {
    public GEnum6 genum6_0;

    public Class235()
    {
      
    }

    internal bool method_0(GClass23 gclass23_0)
    {
      return gclass23_0.genum6_0 == this.genum6_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class236
  {
    public GClass146 gclass146_0;

    public Class236()
    {
      
    }

    internal Decimal method_0(GClass23 gclass23_0)
    {
      return gclass23_0.gclass102_0.method_3(this.gclass146_0) * (Decimal) gclass23_0.int_2;
    }
  }

  [CompilerGenerated]
  private sealed class Class237
  {
    public GClass146 gclass146_0;
    public GEnum116 genum116_0;
    public GEnum116 genum116_1;
    public System.Func<GClass103, bool> func_0;

    public Class237()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass21_0 == this.gclass146_0.gclass21_0 && gclass103_0.gclass102_0.genum116_0 == this.genum116_0 && gclass103_0.gclass146_0 == this.gclass146_0;
    }

    internal bool method_1(GClass103 gclass103_0)
    {
      return gclass103_0.gclass21_0 == this.gclass146_0.gclass21_0 && gclass103_0.gclass103_0 == null && gclass103_0.gclass102_0.genum116_0 == this.genum116_1 && gclass103_0.gclass146_0 == this.gclass146_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class238
  {
    public GClass103 gclass103_0;
    public GClass0.Class237 class237_0;

    public Class238()
    {
      
    }

    internal bool method_0(GClass103 gclass103_1)
    {
      return gclass103_1.gclass21_0 == this.class237_0.gclass146_0.gclass21_0 && gclass103_1.gclass103_0 == this.gclass103_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class239
  {
    public GClass21 gclass21_0;

    public Class239()
    {
      
    }

    internal bool method_0(GClass164 gclass164_0)
    {
      return gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }
  }

  [CompilerGenerated]
  private sealed class Class240
  {
    public GClass200 gclass200_0;
    public System.Func<GClass202, bool> func_0;

    public Class240()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_1(GClass197 gclass197_0)
    {
      return gclass197_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_2(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_3(GClass212 gclass212_0)
    {
      return gclass212_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_4(GClass214 gclass214_0)
    {
      return gclass214_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_5(GClass85 gclass85_0)
    {
      return gclass85_0.gclass202_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_6(GClass132 gclass132_0)
    {
      return gclass132_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_7(GClass126 gclass126_0)
    {
      return gclass126_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_8(GClass220 gclass220_0)
    {
      return gclass220_0.gclass1_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_9(GClass65 gclass65_0)
    {
      return gclass65_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_10(GClass233 gclass233_0)
    {
      return gclass233_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_11(GClass59 gclass59_0)
    {
      return gclass59_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_12(GClass202 gclass202_0)
    {
      return gclass202_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_13(GClass146 gclass146_0)
    {
      return gclass146_0.gclass202_0.gclass200_0 == this.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class241
  {
    public GClass197 gclass197_0;

    public Class241()
    {
      
    }

    internal bool method_0(GClass197 gclass197_1)
    {
      return gclass197_1.int_3 > this.gclass197_0.int_3;
    }

    internal bool method_1(GClass1 gclass1_0)
    {
      return gclass1_0.gclass197_0 == this.gclass197_0;
    }

    internal bool method_2(GClass212 gclass212_0)
    {
      return gclass212_0.gclass1_0.gclass197_0 == this.gclass197_0;
    }

    internal bool method_3(GClass220 gclass220_0)
    {
      return gclass220_0.gclass1_0.gclass197_0 == this.gclass197_0;
    }

    internal bool method_4(GClass146 gclass146_0)
    {
      return gclass146_0.gclass1_0.gclass197_0 == this.gclass197_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class242
  {
    public GClass197 gclass197_0;

    public Class242()
    {
      
    }

    internal bool method_0(GClass197 gclass197_1)
    {
      return gclass197_1.gclass197_0 == this.gclass197_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class243
  {
    public GClass1 gclass1_0;

    public Class243()
    {
      
    }

    internal bool method_0(GClass1 gclass1_1)
    {
      return gclass1_1.gclass1_0 == this.gclass1_0;
    }

    internal bool method_1(GClass212 gclass212_0)
    {
      return gclass212_0.gclass1_0 == this.gclass1_0;
    }

    internal bool method_2(GClass220 gclass220_0)
    {
      return gclass220_0.gclass1_0 == this.gclass1_0 || gclass220_0.gclass1_0.gclass1_0 == this.gclass1_0;
    }

    internal bool method_3(GClass146 gclass146_0)
    {
      return gclass146_0.gclass1_0 == this.gclass1_0 || gclass146_0.gclass1_0.gclass1_0 == this.gclass1_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class244
  {
    public List<GClass1> list_0;

    public Class244()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return this.list_0.Contains(gclass146_0.gclass1_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class245
  {
    public GClass200 gclass200_0;

    public Class245()
    {
      
    }

    internal bool method_0(GClass212 gclass212_0)
    {
      return gclass212_0.gclass200_0 == this.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class246
  {
    public int int_0;

    public Class246()
    {
      
    }

    internal bool method_0(GClass141 gclass141_0)
    {
      return gclass141_0.int_0 >= this.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class247
  {
    public AuroraContactType auroraContactType_0;
    public int int_0;
    public GClass21 gclass21_0;
    public GClass0 gclass0_0;
    public int int_1;
    public GEnum10 genum10_0;

    public Class247()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.auroraContactType_0 == this.auroraContactType_0 && gclass65_0.int_1 == this.int_0 && gclass65_0.gclass21_1 == this.gclass21_0 && gclass65_0.decimal_3 >= this.gclass0_0.decimal_0 - (Decimal) this.int_1 && gclass65_0.genum10_0 == this.genum10_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class248
  {
    public AuroraContactType auroraContactType_0;
    public int int_0;
    public GClass21 gclass21_0;
    public GClass0 gclass0_0;
    public int int_1;
    public GEnum10 genum10_0;

    public Class248()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.auroraContactType_0 == this.auroraContactType_0 && gclass65_0.int_1 == this.int_0 && gclass65_0.gclass21_1 == this.gclass21_0 && gclass65_0.decimal_3 >= this.gclass0_0.decimal_0 - (Decimal) this.int_1 && gclass65_0.genum10_0 == this.genum10_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class249
  {
    public GClass21 gclass21_0;
    public GClass0 gclass0_0;
    public AuroraContactType auroraContactType_0;
    public int int_0;

    public Class249()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.gclass21_1 == this.gclass21_0 && gclass65_0.decimal_3 == this.gclass0_0.decimal_0 && gclass65_0.auroraContactType_0 == this.auroraContactType_0 && gclass65_0.int_1 == this.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class250
  {
    public GClass21 gclass21_0;
    public GClass0 gclass0_0;
    public AuroraContactType auroraContactType_0;
    public int int_0;

    public Class250()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.gclass21_1 == this.gclass21_0 && gclass65_0.decimal_3 == this.gclass0_0.decimal_0 && gclass65_0.auroraContactType_0 == this.auroraContactType_0 && gclass65_0.int_1 == this.int_0 && gclass65_0.genum10_0 != GEnum10.const_4;
    }
  }

  [CompilerGenerated]
  private sealed class Class251
  {
    public GClass83 gclass83_0;

    public Class251()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass83_0.gclass21_0 && gclass146_0.dictionary_0.ContainsKey(AuroraInstallationType.NavalHeadquarters);
    }

    internal bool method_1(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass83_0.gclass21_0;
    }

    internal bool method_2(GClass85 gclass85_0)
    {
      return gclass85_0.gclass83_0 == this.gclass83_0;
    }

    internal bool method_3(GClass83 gclass83_1)
    {
      return gclass83_1.gclass83_0 == this.gclass83_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class252
  {
    public GClass187 gclass187_0;

    public Class252()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass187_0 == this.gclass187_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class253
  {
    public GClass21 gclass21_0;
    public CheckState checkState_0;
    public GClass0 gclass0_0;
    public AuroraEventCategory auroraEventCategory_0;
    public System.Func<GClass87, bool> func_0;
    public System.Func<GClass87, bool> func_1;
    public System.Func<GClass87, bool> func_2;

    public Class253()
    {
      
    }

    internal bool method_0(GClass87 gclass87_0)
    {
      return (gclass87_0.gclass21_0 == this.gclass21_0 || this.checkState_0 == CheckState.Checked && (!gclass87_0.gclass21_0.bool_0 || this.gclass0_0.bool_10)) && !gclass87_0.gclass21_0.method_265(gclass87_0.gclass88_0.genum126_0);
    }

    internal bool method_1(GClass87 gclass87_0)
    {
      if (gclass87_0.gclass21_0 == this.gclass21_0)
        return true;
      if (this.checkState_0 != CheckState.Checked)
        return false;
      return !gclass87_0.gclass21_0.bool_0 || this.gclass0_0.bool_10;
    }

    internal bool method_2(GClass87 gclass87_0)
    {
      return gclass87_0.auroraEventCategory_0 == this.auroraEventCategory_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class254
  {
    public Decimal decimal_0;

    public Class254()
    {
      
    }

    internal bool method_0(GClass91 gclass91_0)
    {
      return gclass91_0.decimal_0 > this.decimal_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class255
  {
    public GClass87 gclass87_0;
    public System.Func<GClass90, bool> func_0;
    public System.Func<GClass90, bool> func_1;

    public Class255()
    {
      
    }

    internal bool method_0(GClass90 gclass90_0)
    {
      return gclass90_0.gclass88_0 == this.gclass87_0.gclass88_0;
    }

    internal bool method_1(GClass90 gclass90_0)
    {
      return gclass90_0.gclass88_0 == this.gclass87_0.gclass88_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class256
  {
    public GClass0 gclass0_0;
    public GClass21 gclass21_0;
    public CheckState checkState_0;

    public Class256()
    {
      
    }

    internal bool method_0(GClass87 gclass87_0)
    {
      if (gclass87_0.gclass21_0.bool_0 && !this.gclass0_0.bool_10)
        return false;
      return gclass87_0.gclass21_0 == this.gclass21_0 || this.checkState_0 == CheckState.Checked;
    }
  }

  [CompilerGenerated]
  private sealed class Class257
  {
    public GClass87 gclass87_0;
    public System.Func<GClass90, bool> func_0;

    public Class257()
    {
      
    }

    internal bool method_0(GClass90 gclass90_0)
    {
      return gclass90_0.gclass88_0 == this.gclass87_0.gclass88_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class258
  {
    public GClass0 gclass0_0;
    public double double_0;
    public double double_1;
    public GClass21 gclass21_0;

    public Class258()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return this.gclass0_0.method_519(gclass1_0.double_0, this.double_0, 1.0) && this.gclass0_0.method_519(gclass1_0.double_1, this.double_1, 1.0);
    }
  }

  [CompilerGenerated]
  private sealed class Class259
  {
    public GClass1 gclass1_0;
    public GClass0.Class258 class258_0;

    public Class259()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass1_0 == this.gclass1_0 && gclass146_0.gclass21_0 == this.class258_0.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class260
  {
    public GClass0 gclass0_0;
    public GClass233 gclass233_0;

    public Class260()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return this.gclass0_0.method_519(gclass1_0.double_0, this.gclass233_0.double_0, 1.0) && this.gclass0_0.method_519(gclass1_0.double_1, this.gclass233_0.double_1, 1.0) && gclass1_0.gclass200_0 == this.gclass233_0.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class261
  {
    public GClass0 gclass0_0;
    public int int_0;

    public Class261()
    {
      
    }

    internal bool method_0(GClass117 gclass117_0)
    {
      return gclass117_0.decimal_8 == this.gclass0_0.decimal_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class262
  {
    public GClass37 gclass37_0;

    public Class262()
    {
      
    }

    internal bool method_0(GClass38 gclass38_0)
    {
      return gclass38_0.gclass40_0 == this.gclass37_0.gclass40_0 && gclass38_0.gclass230_0 == this.gclass37_0.gclass230_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class263
  {
    public GClass38 gclass38_0;
    public GClass0.Class261 class261_0;

    public Class263()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.gclass40_0 == this.gclass38_0.gclass40_0 && gclass65_0.genum10_0 == GEnum10.const_0 && gclass65_0.decimal_3 == this.class261_0.gclass0_0.decimal_0 - (Decimal) this.class261_0.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class264
  {
    public GClass65 gclass65_0;

    public Class264()
    {
      
    }

    internal bool method_0(GClass117 gclass117_0)
    {
      return gclass117_0.gclass40_0 == this.gclass65_0.gclass40_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class265
  {
    public GClass117 gclass117_0;

    public Class265()
    {
      
    }

    internal bool method_0(GClass117 gclass117_1)
    {
      return gclass117_1.gclass40_0.gclass85_0 == this.gclass117_0.gclass40_0.gclass85_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class266
  {
    public GEnum6 genum6_0;

    public Class266()
    {
      
    }

    internal bool method_0(GClass21 gclass21_0)
    {
      return gclass21_0.genum6_0 == this.genum6_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class267
  {
    public GEnum120 genum120_0;

    public Class267()
    {
      
    }

    internal bool method_0(GClass22 gclass22_0)
    {
      return gclass22_0.gclass14_0.genum120_0 == this.genum120_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class268
  {
    public GClass21 gclass21_0;
    public CheckState checkState_0;
    public System.Func<GClass120, bool> func_0;

    public Class268()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      if (gclass120_0.dictionary_0[this.gclass21_0.RaceID].int_1 != 1 || gclass120_0.gclass120_0 == null)
        return false;
      return gclass120_0.dictionary_0[this.gclass21_0.RaceID].int_4 == 0 || this.checkState_0 == CheckState.Unchecked;
    }
  }

  [CompilerGenerated]
  private sealed class Class269
  {
    public GClass200 gclass200_0;
    public GClass0.Class268 class268_0;

    public Class269()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.gclass200_0 && gclass120_0.dictionary_0.ContainsKey(this.class268_0.gclass21_0.RaceID);
    }
  }

  [CompilerGenerated]
  private sealed class Class270
  {
    public GClass21 gclass21_0;
    public CheckState checkState_0;
    public System.Func<GClass120, bool> func_0;

    public Class270()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      if (gclass120_0.dictionary_0[this.gclass21_0.RaceID].int_1 != 1 || gclass120_0.gclass120_0 == null)
        return false;
      return gclass120_0.dictionary_0[this.gclass21_0.RaceID].int_4 == 0 || this.checkState_0 == CheckState.Unchecked;
    }
  }

  [CompilerGenerated]
  private sealed class Class271
  {
    public GClass200 gclass200_0;
    public GClass0.Class270 class270_0;

    public Class271()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.gclass200_0 && gclass120_0.dictionary_0.ContainsKey(this.class270_0.gclass21_0.RaceID);
    }
  }

  [CompilerGenerated]
  private sealed class Class272
  {
    public GClass200 gclass200_0;
    public System.Func<GClass197, bool> func_0;
    public System.Func<GClass1, bool> func_1;

    public Class272()
    {
      
    }

    internal bool method_0(GClass197 gclass197_0)
    {
      return gclass197_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_1(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass200_0 && gclass1_0.gclass197_0.bool_1 && (gclass1_0.genum12_0 == GEnum12.const_1 || gclass1_0.genum12_0 == GEnum12.const_2) && gclass1_0.auroraSystemBodyType_0 != AuroraSystemBodyType.GasGiant && gclass1_0.auroraSystemBodyType_0 != AuroraSystemBodyType.Superjovian;
    }
  }

  [CompilerGenerated]
  private sealed class Class273
  {
    public GClass139 gclass139_0;

    public Class273()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return this.gclass139_0.gclass21_0.dictionary_0.Values
        .Select<GClass202, GClass200>(gc202=>gc202.gclass200_0).Contains<GClass200>(gclass120_0.gclass200_0);
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass139_0.gclass21_0 && gclass85_0.dictionary_0.Count > 0 && gclass85_0 != this.gclass139_0.gclass85_0;
    }

    internal bool method_2(GClass139 gclass139_1)
    {
      return gclass139_1.genum13_0 == GEnum13.const_0 && gclass139_1.int_2 == this.gclass139_0.int_2 && gclass139_1.gclass202_1 == null;
    }
  }

  [CompilerGenerated]
  private sealed class Class274
  {
    public GClass200 gclass200_0;

    public Class274()
    {
      
    }

    internal bool method_0(GClass200 gclass200_1)
    {
      return gclass200_1 != this.gclass200_0;
    }

    internal bool method_1(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.gclass200_0 && gclass120_0.gclass120_0 == null;
    }

    internal bool method_2(GClass1 gclass1_0)
    {
      return gclass1_0.list_0.Count > 0 && gclass1_0.gclass200_0 == this.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class275
  {
    public int int_0;
    public System.Func<GClass202, bool> func_0;

    public Class275()
    {
      
    }

    internal bool method_0(GClass202 gclass202_0)
    {
      return gclass202_0.gclass200_0.int_13 == this.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class276
  {
    public GClass200 gclass200_0;

    public Class276()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class277
  {
    public int int_0;

    public Class277()
    {
      
    }

    internal bool method_0(GClass200 gclass200_0)
    {
      return gclass200_0.int_1 == this.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class278
  {
    public GClass200 gclass200_0;

    public Class278()
    {
      
    }

    internal bool method_0(GClass197 gclass197_0)
    {
      return gclass197_0.gclass200_0 == this.gclass200_0 && gclass197_0.int_3 == 1;
    }

    internal bool method_1(GClass197 gclass197_0)
    {
      return gclass197_0.gclass200_0 == this.gclass200_0 && gclass197_0.int_3 > 1;
    }

    internal bool method_2(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_3(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass200_0 && gclass1_0.genum12_0 == GEnum12.const_3;
    }

    internal bool method_4(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_5(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class279
  {
    public GClass197 gclass197_0;

    public Class279()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      if (gclass1_0.gclass197_0 != this.gclass197_0)
        return false;
      return gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian;
    }
  }

  [CompilerGenerated]
  private sealed class Class280
  {
    public GClass197 gclass197_0;

    public Class280()
    {
      
    }

    internal bool method_0(GClass197 gclass197_1)
    {
      return gclass197_1 == this.gclass197_0.gclass197_0;
    }

    internal bool method_1(GClass212 gclass212_0)
    {
      return gclass212_0.gclass197_0 == this.gclass197_0;
    }

    internal bool method_2(GClass1 gclass1_0)
    {
      if (gclass1_0.gclass197_0 != this.gclass197_0)
        return false;
      return gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian;
    }
  }

  [CompilerGenerated]
  private sealed class Class281
  {
    public GClass197 gclass197_0;

    public Class281()
    {
      
    }

    internal bool method_0(GClass212 gclass212_0)
    {
      return gclass212_0.gclass197_0 == this.gclass197_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class282
  {
    public GClass200 gclass200_0;

    public Class282()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      if (gclass1_0.gclass200_0 != this.gclass200_0)
        return false;
      return gclass1_0.genum12_0 == GEnum12.const_1 || gclass1_0.genum12_0 == GEnum12.const_2;
    }

    internal bool method_1(GClass202 gclass202_0)
    {
      return gclass202_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_2(GClass65 gclass65_0)
    {
      return gclass65_0.auroraContactType_0 == AuroraContactType.Explosion && gclass65_0.gclass200_0 == this.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class283
  {
    public GClass21 gclass21_0;

    public Class283()
    {
      
    }

    internal bool method_0(GClass83 gclass83_0)
    {
      return gclass83_0.gclass21_0 == this.gclass21_0 && gclass83_0.gclass83_0 == null;
    }

    internal bool method_1(GClass22 gclass22_0)
    {
      return gclass22_0.gclass21_0 == this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class284
  {
    public GClass197 gclass197_0;

    public Class284()
    {
      
    }

    internal bool method_0(GClass197 gclass197_1)
    {
      return gclass197_1.gclass200_0 == this.gclass197_0.gclass200_0 && gclass197_1.int_3 == this.gclass197_0.int_4;
    }
  }

  [CompilerGenerated]
  private sealed class Class285
  {
    public GClass1 gclass1_0;
    public int int_0;

    public Class285()
    {
      
    }

    internal bool method_0(GClass1 gclass1_1)
    {
      return gclass1_1.int_3 == this.gclass1_0.int_3 && gclass1_1.int_4 == 0;
    }

    internal bool method_1(GClass1 gclass1_1)
    {
      return gclass1_1.int_3 == this.int_0 && gclass1_1.int_4 == 0;
    }
  }

  [CompilerGenerated]
  private sealed class Class286
  {
    public GClass1 gclass1_0;

    public Class286()
    {
      
    }

    internal bool method_0(GClass1 gclass1_1)
    {
      return gclass1_1.gclass1_0 == this.gclass1_0 && gclass1_1.genum12_0 == GEnum12.const_2;
    }

    internal bool method_1(GClass1 gclass1_1)
    {
      return gclass1_1.gclass1_0 == this.gclass1_0 && gclass1_1.genum12_0 == GEnum12.const_3;
    }
  }

  [CompilerGenerated]
  private sealed class Class287
  {
    public GClass1 gclass1_0;

    public Class287()
    {
      
    }

    internal bool method_0(GClass1 gclass1_1)
    {
      return gclass1_1.gclass200_0 == this.gclass1_0.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class288
  {
    public GClass21 gclass21_0;

    public Class288()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass21_0 == this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class289
  {
    public GClass202 gclass202_0;

    public Class289()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0.gclass202_0 == this.gclass202_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class290
  {
    public GClass197 gclass197_0;
    public GClass0 gclass0_0;

    public Class290()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.gclass197_0 == this.gclass197_0 && gclass1_0.genum12_0 == GEnum12.const_1;
    }

    internal bool method_1(GClass1 gclass1_0)
    {
      return !this.gclass0_0.list_0.Contains(gclass1_0);
    }

    internal bool method_2(GClass1 gclass1_0)
    {
      return !this.gclass0_0.list_0.Contains(gclass1_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class291
  {
    public int int_0;

    public Class291()
    {
      
    }

    internal bool method_0(double double_0)
    {
      return double_0 < (double) this.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class292
  {
    public double double_0;

    public Class292()
    {
      
    }

    internal bool method_0(double double_1)
    {
      return double_1 < this.double_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class293
  {
    public GClass1 gclass1_0;
    public double double_0;
    public double double_1;

    public Class293()
    {
      
    }

    internal bool method_0(GClass1 gclass1_1)
    {
      return gclass1_1.double_8 < this.gclass1_0.double_8 && gclass1_1.double_2 > this.double_0 && gclass1_1.double_2 < this.double_1 && !gclass1_1.bool_8 && gclass1_1.double_8 < this.gclass1_0.double_8;
    }
  }

  [CompilerGenerated]
  private sealed class Class294
  {
    public double double_0;
    public GClass0.Class290 class290_0;

    public Class294()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      if (gclass1_0.gclass197_0 != this.class290_0.gclass197_0 || gclass1_0.double_28 <= this.double_0)
        return false;
      return gclass1_0.genum12_0 == GEnum12.const_1 || gclass1_0.genum12_0 == GEnum12.const_3;
    }
  }

  [CompilerGenerated]
  private sealed class Class295
  {
    public List<GClass40> list_0;

    public Class295()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      if (gclass40_0.method_157(AuroraComponentType.Magazine, false) > 0M)
        return true;
      return gclass40_0.method_157(AuroraComponentType.MissileLauncher, false) > 0M && this.list_0.Contains(gclass40_0.gclass40_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class296
  {
    public GClass40 gclass40_0;

    public Class296()
    {
      
    }

    internal bool method_0(GClass40 gclass40_1)
    {
      return gclass40_1.gclass40_0 == this.gclass40_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class297
  {
    public GClass130 gclass130_0;

    public Class297()
    {
      
    }

    internal bool method_0(GClass130 gclass130_1)
    {
      return gclass130_1.gclass129_0 == this.gclass130_0.gclass129_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class298
  {
    public GClass130 gclass130_0;

    public Class298()
    {
      
    }

    internal bool method_0(GClass130 gclass130_1)
    {
      return gclass130_1.gclass129_0 == this.gclass130_0.gclass129_0;
    }

    internal bool method_1(GClass130 gclass130_1)
    {
      return gclass130_1.gclass129_0 == this.gclass130_0.gclass129_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class299
  {
    public GClass1 gclass1_0;

    public Class299()
    {
      
    }

    internal bool method_0(GClass1 gclass1_1)
    {
      return gclass1_1.gclass1_0 == this.gclass1_0 && gclass1_1.genum12_0 == GEnum12.const_2;
    }
  }

  [CompilerGenerated]
  private sealed class Class300
  {
    public GClass1 gclass1_0;

    public Class300()
    {
      
    }

    internal bool method_0(GClass1 gclass1_1)
    {
      return gclass1_1.gclass197_0 == this.gclass1_0.gclass197_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class301
  {
    public GClass1 gclass1_0;
    public System.Func<GClass1, bool> func_0;

    public Class301()
    {
      
    }

    internal bool method_0(GClass1 gclass1_1)
    {
      return gclass1_1.gclass1_0 == this.gclass1_0.gclass1_0 && gclass1_1 != this.gclass1_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class302
  {
    public GClass197 gclass197_0;

    public Class302()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.gclass197_0 == this.gclass197_0 && gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.Comet;
    }
  }

  [CompilerGenerated]
  private sealed class Class303
  {
    public Decimal decimal_0;

    public Class303()
    {
      
    }
  }

  [CompilerGenerated]
  private sealed class Class304
  {
    public GClass132 gclass132_0;
    public GClass0.Class303 class303_0;

    public Class304()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.int_1 == this.gclass132_0.gclass40_1.int_8 && gclass65_0.auroraContactType_0 == AuroraContactType.Ship && gclass65_0.gclass21_1 == this.gclass132_0.gclass21_0 && gclass65_0.decimal_3 == this.class303_0.decimal_0;
    }

    internal bool method_1(GClass65 gclass65_0)
    {
      return gclass65_0.gclass21_1 == this.gclass132_0.gclass21_0 && gclass65_0.decimal_3 == this.class303_0.decimal_0;
    }

    internal bool method_2(GClass65 gclass65_0)
    {
      return gclass65_0.int_1 == this.gclass132_0.gclass132_0.int_1 && gclass65_0.auroraContactType_0 == AuroraContactType.Salvo && gclass65_0.gclass21_1 == this.gclass132_0.gclass21_0 && gclass65_0.genum10_0 == GEnum10.const_0 && gclass65_0.decimal_3 == this.class303_0.decimal_0;
    }

    internal bool method_3(GClass65 gclass65_0)
    {
      return gclass65_0.int_1 == this.gclass132_0.gclass146_0.int_6 && gclass65_0.auroraContactType_0 == AuroraContactType.Population && gclass65_0.gclass21_1 == this.gclass132_0.gclass21_0 && (gclass65_0.genum10_0 == GEnum10.const_1 || gclass65_0.genum10_0 == GEnum10.const_3) && gclass65_0.decimal_3 == this.class303_0.decimal_0;
    }

    internal bool method_4(GClass65 gclass65_0)
    {
      return gclass65_0.int_1 == this.gclass132_0.gclass146_0.int_6 && gclass65_0.auroraContactType_0 == this.gclass132_0.auroraContactType_0 && gclass65_0.gclass21_1 == this.gclass132_0.gclass21_0 && gclass65_0.genum10_0 == GEnum10.const_0 && gclass65_0.decimal_3 == this.class303_0.decimal_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class305
  {
    public GClass40 gclass40_0;

    public Class305()
    {
      
    }

    internal bool method_0(GClass132 gclass132_0)
    {
      return gclass132_0.gclass40_1 == this.gclass40_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class306
  {
    public GClass32 gclass32_0;

    public Class306()
    {
      
    }

    internal bool method_0(GClass30 gclass30_0)
    {
      return gclass30_0.gclass230_0 == this.gclass32_0.gclass230_0 && gclass30_0.int_0 == this.gclass32_0.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class307
  {
    public GClass132 gclass132_0;

    public Class307()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass132_0.gclass200_0 && gclass1_0.double_0 == this.gclass132_0.double_0 && gclass1_0.double_1 == this.gclass132_0.double_1;
    }

    internal bool method_1(GClass132 gclass132_1)
    {
      return gclass132_1.gclass40_1 == this.gclass132_0.gclass40_1 && gclass132_1.gclass129_0.int_14 == 1;
    }

    internal bool method_2(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass132_0.gclass200_0 && gclass1_0.double_0 == this.gclass132_0.double_0 && gclass1_0.double_1 == this.gclass132_0.double_1;
    }
  }
}