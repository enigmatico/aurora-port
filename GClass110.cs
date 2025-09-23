// Decompiled with JetBrains decompiler
// Type: GClass110
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;

#nullable disable
public class GClass110
{
  private GClass0 gclass0_0;
  public Dictionary<int, GClass194> dictionary_0 = new Dictionary<int, GClass194>();
  public Dictionary<int, GClass200> dictionary_1 = new Dictionary<int, GClass200>();
  public Dictionary<int, GClass118> dictionary_2 = new Dictionary<int, GClass118>();
  public GClass21 gclass21_0;
  public GClass21 gclass21_1;
  public AuroraContactStatus auroraContactStatus_0;
  public AuroraCommStatus auroraCommStatus_0;
  public GClass140 gclass140_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3 = 1;
  public Decimal decimal_0;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public Decimal decimal_3;
  public Decimal decimal_4;
  public bool bool_0;
  public bool bool_1;
  public bool bool_2;
  public bool bool_3;
  public bool bool_4;
  public bool bool_5;
  public string string_0;
  public double double_0;
  public bool bool_6 = true;

  public string AlienRaceName { get; set; }

  public GClass110(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public GClass110 method_0(GClass21 gclass21_2)
  {
    try
    {
      GClass110 gclass110_1 = new GClass110(this.gclass0_0);
      GClass110 gclass110_2 = (GClass110) this.MemberwiseClone();
      gclass110_2.gclass21_1 = gclass21_2;
      gclass110_2.dictionary_0 = new Dictionary<int, GClass194>();
      gclass110_2.dictionary_1 = new Dictionary<int, GClass200>();
      gclass110_2.dictionary_2 = new Dictionary<int, GClass118>();
      foreach (KeyValuePair<int, GClass194> keyValuePair in this.dictionary_0)
        gclass110_2.dictionary_0.Add(keyValuePair.Key, keyValuePair.Value);
      foreach (KeyValuePair<int, GClass200> keyValuePair in this.dictionary_1)
        gclass110_2.dictionary_1.Add(keyValuePair.Key, keyValuePair.Value);
      foreach (GClass118 gclass118_1 in this.dictionary_2.Values)
      {
        GClass118 gclass118_2 = gclass118_1.method_2(gclass21_2);
        gclass118_2.int_0 = this.gclass0_0.method_26(GEnum0.const_43);
        gclass110_2.dictionary_2.Add(gclass118_2.int_0, gclass118_2);
      }
      return gclass110_2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1893);
      return (GClass110) null;
    }
  }
}
