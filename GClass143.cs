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
    public List<PlanetaryTerrainDefinition> list_0 = new List<PlanetaryTerrainDefinition>();
    private GClass0 gclass0_0;
    public DIMKnownSystemsData198 gclass198_0;
    public NamingTheme gclass140_0;
    public NamingTheme gclass140_1;
    public NamingTheme gclass140_2;
    public NamingTheme gclass140_3;
    public RankTheme gclass60_0;
    public CommanderNameThemeData gclass58_0;
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
    public OperationGroupProgressionType genum90_0;

    public GClass143(GClass0 gclass0_1)
    {
        this.gclass0_0 = gclass0_1;
        this.string_5 = AuroraUtils.GetRandomImageFileNameFromFolder("ShipIcons");
        this.string_6 = AuroraUtils.GetRandomImageFileNameFromFolder("StationIcons");
        this.string_4 = AuroraUtils.GetRandomImageFileNameFromFolder("Flags");
        this.string_3 = AuroraUtils.GetRandomImageFileNameFromFolder("Races");
        this.string_0 = this.gclass0_0.method_551();
        this.string_1 = this.gclass0_0.GenerateEmpireName(this.string_0);
        this.string_2 = string.Format("{0} Prime", this.string_0);
        this.gclass140_0 = this.gclass0_0.ThemeDictionary
            .ElementAt<KeyValuePair<int, NamingTheme>>(
                AuroraUtils.GetRandomInteger(this.gclass0_0.ThemeDictionary.Count) - 1).Value;
        this.gclass140_1 = this.gclass0_0.ThemeDictionary
            .ElementAt<KeyValuePair<int, NamingTheme>>(
                AuroraUtils.GetRandomInteger(this.gclass0_0.ThemeDictionary.Count) - 1).Value;
        this.gclass60_0 = this.gclass0_0.RankThemeDictionary
            .ElementAt<KeyValuePair<int, RankTheme>>(
                AuroraUtils.GetRandomInteger(this.gclass0_0.RankThemeDictionary.Count) - 1).Value;
        this.gclass58_0 = this.gclass0_0.NameThemeDictionary
            .ElementAt<KeyValuePair<int, CommanderNameThemeData>>(
                AuroraUtils.GetRandomInteger(this.gclass0_0.NameThemeDictionary.Count) - 1).Value;
        if (this.gclass0_0.ThemeDictionary.ContainsKey(AuroraUtils.int_2))
        {
            this.gclass140_3 = this.gclass0_0.ThemeDictionary[AuroraUtils.int_2];
            this.gclass140_2 = this.gclass0_0.ThemeDictionary[AuroraUtils.int_2];
        }
        else
        {
            this.gclass140_2 = this.gclass0_0.ThemeDictionary
                .ElementAt<KeyValuePair<int, NamingTheme>>(
                    AuroraUtils.GetRandomInteger(this.gclass0_0.ThemeDictionary.Count) - 1).Value;
            this.gclass140_3 = this.gclass0_0.ThemeDictionary[AuroraUtils.int_2];
        }

        this.int_5 = AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25) +
                     AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25);
        this.int_1 = AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25) +
                     AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25);
        this.int_3 = AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25) +
                     AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25);
        this.int_4 = AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25) +
                     AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25);
        this.int_0 = AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25) +
                     AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25);
        this.int_6 = AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25) +
                     AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25);
        this.int_2 = AuroraUtils.smethod_21(5) + AuroraUtils.GetRandomInteger(6) - 31 /*0x1F*/;
    }
}