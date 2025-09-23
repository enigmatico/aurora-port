// Decompiled with JetBrains decompiler
// Type: GClass61
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
// TODO : Probably this object is commander position
public class GClass61
{
  public GClass21 gclass21_0;
  public AuroraCommanderType auroraCommanderType_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public string string_0;
  public List<GClass55> list_0 = new List<GClass55>();

  public string RankName { get; set; }

  public string method_0() => this.string_0 == "" ? this.RankName : this.string_0;

  public GClass61 method_1()
  {
    try
    {
      return this.gclass21_0.dictionary_1.Values.Where<GClass61>((Func<GClass61, bool>) (gclass61_0 => gclass61_0.auroraCommanderType_0 == this.auroraCommanderType_0 && gclass61_0.int_1 == this.int_1 - 1)).FirstOrDefault<GClass61>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 412);
      return (GClass61) null;
    }
  }

  public GClass61 method_2(int int_4)
  {
    try
    {
      // ISSUE: reference to a compiler-generated method
      return this.gclass21_0.dictionary_1.Values.
        FirstOrDefault(
          gClass61 => gClass61.auroraCommanderType_0 == this.auroraCommanderType_0
                      && gClass61.int_1 == this.int_1 + int_4);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 413);
      return (GClass61) null;
    }
  }

  public GClass61 method_3()
  {
    try
    {
      return this.gclass21_0.dictionary_1.Values.Where<GClass61>((Func<GClass61, bool>) (gclass61_0 => gclass61_0.auroraCommanderType_0 == this.auroraCommanderType_0 && gclass61_0.int_1 == this.int_1 + 1)).FirstOrDefault<GClass61>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 414);
      return (GClass61) null;
    }
  }
}
