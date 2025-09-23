// Decompiled with JetBrains decompiler
// Type: GClass143
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass143
{
  public List<GClass99> list_0 = new List<GClass99>();
  private GClass0 gclass0_0;
  public GClass198 gclass198_0;
  public GClass140 gclass140_0;
  public GClass140 gclass140_1;
  public GClass140 gclass140_2;
  public GClass140 gclass140_3;
  public GClass60 gclass60_0;
  public GClass58 gclass58_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  public int int_5;
  public int int_6;
  public int int_7 = 1;
  public int int_8;
  public int int_9;
  public int int_10;
  public Decimal decimal_0 = 1M;
  public Decimal decimal_1 = 1M;
  public Decimal decimal_2 = 1M;
  public Decimal decimal_3 = 1M;
  public Decimal decimal_4 = 1M;
  public Decimal decimal_5 = 1M;
  public Decimal decimal_6 = 1M;
  public string string_0;
  public string string_1;
  public string string_2;
  public string string_3;
  public string string_4;
  public string string_5;
  public string string_6;
  public int int_11;
  public Decimal decimal_7 = 1M;
  public bool bool_0;
  public bool bool_1;
  public AuroraNPRSetupOption auroraNPRSetupOption_0;
  public AuroraNPRSetupOption auroraNPRSetupOption_1;
  public AuroraNPRSetupOption auroraNPRSetupOption_2;
  public AuroraNPRSetupOption auroraNPRSetupOption_3;
  public AuroraNPRSetupOption auroraNPRSetupOption_4;
  public AuroraNPRPrimaryBeam auroraNPRPrimaryBeam_0;
  public AuroraNPRPDBeam auroraNPRPDBeam_0;
  public GEnum90 genum90_0;

  public GClass143(GClass0 gclass0_1)
  {
    this.gclass0_0 = gclass0_1;
    this.string_5 = GClass226.smethod_19("ShipIcons");
    this.string_6 = GClass226.smethod_19("StationIcons");
    this.string_4 = GClass226.smethod_19("Flags");
    this.string_3 = GClass226.smethod_19("Races");
    this.string_0 = this.gclass0_0.method_551();
    this.string_1 = this.gclass0_0.method_555(this.string_0);
    this.string_2 = this.string_0 + " Prime";
    this.gclass140_0 = this.gclass0_0.dictionary_55.ElementAt<KeyValuePair<int, GClass140>>(GClass226.smethod_13(this.gclass0_0.dictionary_55.Count) - 1).Value;
    this.gclass140_1 = this.gclass0_0.dictionary_55.ElementAt<KeyValuePair<int, GClass140>>(GClass226.smethod_13(this.gclass0_0.dictionary_55.Count) - 1).Value;
    this.gclass60_0 = this.gclass0_0.dictionary_40.ElementAt<KeyValuePair<int, GClass60>>(GClass226.smethod_13(this.gclass0_0.dictionary_40.Count) - 1).Value;
    this.gclass58_0 = this.gclass0_0.dictionary_47.ElementAt<KeyValuePair<int, GClass58>>(GClass226.smethod_13(this.gclass0_0.dictionary_47.Count) - 1).Value;
    if (this.gclass0_0.dictionary_55.ContainsKey(GClass226.int_2))
    {
      this.gclass140_3 = this.gclass0_0.dictionary_55[GClass226.int_2];
      this.gclass140_2 = this.gclass0_0.dictionary_55[GClass226.int_2];
    }
    else
    {
      this.gclass140_2 = this.gclass0_0.dictionary_55.ElementAt<KeyValuePair<int, GClass140>>(GClass226.smethod_13(this.gclass0_0.dictionary_55.Count) - 1).Value;
      this.gclass140_3 = this.gclass0_0.dictionary_55[GClass226.int_2];
    }
    this.int_5 = GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25);
    this.int_1 = GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25);
    this.int_3 = GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25);
    this.int_4 = GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25);
    this.int_0 = GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25);
    this.int_6 = GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25) + GClass226.smethod_13(25);
    this.int_2 = GClass226.smethod_21(5) + GClass226.smethod_13(6) - 31 /*0x1F*/;
  }
}
