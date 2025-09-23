// Decompiled with JetBrains decompiler
// Type: GClass29
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
public class GClass29
{
  [CompilerGenerated]
  [Serializable]
  private sealed class staticCompGen
  {
    public static readonly GClass29.staticCompGen staticCompMem;
    public static Func<GClass132, Decimal> staticCompMem__6_0;
    public static Func<GClass132, int> staticCompMem__6_1;
    public static Func<GClass132, int> staticCompMem__6_2;
    public static Func<KeyValuePair<int, int>, int> staticCompMem__6_3;
    public static Func<KeyValuePair<int, int>, int> staticCompMem__6_4;
    public static Func<KeyValuePair<int, int>, int> staticCompMem__6_5;
    public static Func<KeyValuePair<int, int>, int> staticCompMem__6_7;

    static staticCompGen()
    {
      GClass29.staticCompGen.staticCompMem = new GClass29.staticCompGen();
    }

    internal Decimal method_0(GClass132 gclass132_0)
    {
      return gclass132_0.gclass129_0.decimal_5;
    }

    internal int method_1(GClass132 gclass132_0)
    {
      return gclass132_0.dictionary_2.Count;
    }

    internal int method_2(GClass132 gclass132_0)
    {
      return gclass132_0.dictionary_2.Count * gclass132_0.gclass129_0.int_7;
    }

    internal int method_3(KeyValuePair<int, int> keyValuePair_0)
    {
      return keyValuePair_0.Key;
    }

    internal int method_4(KeyValuePair<int, int> keyValuePair_0)
    {
      return keyValuePair_0.Key;
    }

    internal int method_5(KeyValuePair<int, int> keyValuePair_0)
    {
      return keyValuePair_0.Value;
    }

    internal int method_6(KeyValuePair<int, int> keyValuePair_0)
    {
      return keyValuePair_0.Value;
    }
  }
  
  public List<GClass132> list_0 = new List<GClass132>();
  public GClass0 gclass0_0;
  public GClass21 gclass21_0;
  public GClass200 gclass200_0;
  public GClass221 gclass221_0;

  public GClass29(
    GClass0 gclass0_1,
    GClass221 gclass221_1,
    GClass21 gclass21_1,
    GClass200 gclass200_1,
    GClass132 gclass132_0)
  {
    this.gclass0_0 = gclass0_1;
    this.gclass221_0 = gclass221_1;
    this.gclass21_0 = gclass21_1;
    this.gclass200_0 = gclass200_1;
    this.list_0.Add(gclass132_0);
  }

  public void method_0()
  {
    try
    {
      Dictionary<int, int> source = new Dictionary<int, int>();
      int int_0 = (int) this.list_0.Max<GClass132>((Func<GClass132, Decimal>) (gclass132_0 => gclass132_0.gclass129_0.decimal_5));
      int num1 = this.list_0.Sum<GClass132>((Func<GClass132, int>) (gclass132_0 => gclass132_0.dictionary_2.Count));
      int num2 = this.list_0.Sum<GClass132>((Func<GClass132, int>) (gclass132_0 => gclass132_0.dictionary_2.Count * gclass132_0.gclass129_0.int_7));
      if (num1 > 0)
      {
        Decimal num3 = 0M;
        if (num2 > 0)
          num3 = (Decimal) num2 / (Decimal) num1;
        int num4 = this.gclass21_0.gclass2_0.method_11(this.gclass200_0, this.gclass221_0, int_0);
        if (num4 == 0)
          return;
        foreach (GClass132 gclass132 in this.list_0)
        {
          int key = (int) (this.gclass0_0.method_28(gclass132.double_0, gclass132.double_1, this.gclass221_0.double_0, this.gclass221_0.double_1) / (double) gclass132.gclass129_0.decimal_5);
          if (source.ContainsKey(key))
            source[key] += gclass132.dictionary_2.Count;
          else
            source.Add(key, gclass132.dictionary_2.Count);
        }
        source.OrderBy<KeyValuePair<int, int>, int>((Func<KeyValuePair<int, int>, int>) (keyValuePair_0 => keyValuePair_0.Key)).ToDictionary<KeyValuePair<int, int>, int, int>((Func<KeyValuePair<int, int>, int>) (keyValuePair_0 => keyValuePair_0.Key), (Func<KeyValuePair<int, int>, int>) (keyValuePair_0 => keyValuePair_0.Value));
        foreach (KeyValuePair<int, int> keyValuePair in source)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: reference to a compiler-generated method
          Decimal num5 = source.Where(srcKvPair => { return srcKvPair.Key >= keyValuePair.Key && srcKvPair.Key < keyValuePair.Key + 11; }).Sum<KeyValuePair<int, int>>((Func<KeyValuePair<int, int>, int>) (keyValuePair_0 => keyValuePair_0.Value));
          if (num5 + num3 * num5 > (Decimal) num4)
            return;
        }
      }
      foreach (GClass132 gclass132 in this.list_0)
      {
        if (gclass132.auroraContactType_0 != AuroraContactType.WayPoint)
          gclass132.bool_3 = true;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 287);
    }
  }
}
