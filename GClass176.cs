// Decompiled with JetBrains decompiler
// Type: GClass176
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass176
{
    private GClass0 gclass0_0;
    public List<GClass175> list_0 = new List<GClass175>();
    public GEnum39 genum39_0;
    public AuroraInstallationType auroraInstallationType_0;
    public TechType genum122_0;
    public ResearchFieldData gclass162_0;
    public int int_0;
    public int int_1;
    public int int_2 = 1;
    public int int_3 = 1;
    public int int_4;
    private string string_0;

    public GClass176(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public bool method_0(PopulationData gclass146_0, GroundUnitFormationElement gclass39_0)
    {
        try
        {
            this.gclass0_0.int_61 += this.int_0;
            if (this.gclass0_0.int_59 > this.gclass0_0.int_61)
                return false;
            if (this.genum39_0 == GEnum39.const_1)
            {
                int num = AuroraUtils.GetRandomInteger(11);
                this.int_1 = AuroraUtils.smethod_21(5) * 200;
                if (num == 1)
                    this.int_1 *= 2;
                gclass146_0.CurrentMinerals.method_33((AuroraElement)num, this.int_1);
                if (!gclass146_0.RaceData.NPR)
                    gclass146_0.method_21(MineralUsage.const_10, (AuroraElement)num, this.int_1);
                this.string_0 =
                    $"{AuroraUtils.smethod_37(this.int_1)} tons of {AuroraUtils.smethod_82((AuroraElement)num)}";
            }
            else if (this.genum39_0 == GEnum39.const_3)
            {
                this.int_1 = AuroraUtils.smethod_21(5) * 200000;
                gclass146_0.FuelStockpile += this.int_1;
                this.string_0 = AuroraUtils.smethod_37(this.int_1) + " litres of fuel";
            }
            else if (this.genum39_0 == GEnum39.const_5)
            {
                this.int_1 = AuroraUtils.smethod_21(5) * 200;
                gclass146_0.MaintenanceStockpile += this.int_1;
                this.string_0 = AuroraUtils.smethod_37(this.int_1) + " maintenance supplies";
            }
            else if (this.genum39_0 == GEnum39.const_4)
            {
                this.int_1 = AuroraUtils.smethod_21(5) * 200;
                gclass146_0.RaceData.method_300(this.int_1, this.gclass0_0.WealthUsageDictionary[WealthUsage.const_28]);
                this.string_0 = AuroraUtils.smethod_37(this.int_1) + " wealth";
            }
            else if (this.genum39_0 == GEnum39.const_6)
            {
                GClass190 gclass190 =
                    gclass146_0.dictionary_4.Values.FirstOrDefault<GClass190>(gclass190_0 =>
                        gclass190_0.gclass189_0.int_0 == 15);
                if (gclass190 == null)
                {
                    gclass190 = new GClass190();
                    gclass190.gclass146_0 = gclass146_0;
                    gclass190.gclass189_0 = this.gclass0_0.TradeGoodsDictionary[15];
                    gclass190.decimal_1 = 0M;
                    gclass190.decimal_2 = 0M;
                    gclass190.decimal_0 = 0M;
                    gclass146_0.dictionary_4.Add(gclass190.gclass189_0.int_0, gclass190);
                }

                this.int_1 = AuroraUtils.smethod_22(50, 4);
                gclass190.decimal_1 += this.int_1;
                this.string_0 = AuroraUtils.smethod_37(this.int_1) + " alien artifacts";
            }
            else if (this.genum39_0 == GEnum39.const_2)
            {
                this.gclass0_0.int_63 = this.list_0.Sum<GClass175>(gclass175_0 => gclass175_0.int_0);
                this.gclass0_0.int_62 = AuroraUtils.GetRandomInteger(this.gclass0_0.int_63);
                this.gclass0_0.int_64 = 0;
                foreach (GClass175 gclass175 in this.list_0)
                {
                    if (gclass175.method_0(gclass146_0, gclass39_0))
                        break;
                }
            }
            else if (this.genum39_0 == GEnum39.const_0)
            {
                this.int_1 = AuroraUtils.GetRandomInteger(this.int_2) * this.int_3;
                gclass146_0.method_65(this.auroraInstallationType_0, this.int_1);
                this.string_0 = this.int_1 != 1
                    ? $"{this.int_1.ToString()} abandoned {AuroraUtils.smethod_11(AuroraUtils.smethod_82(this.auroraInstallationType_0))}"
                    : "an abandoned " + AuroraUtils.smethod_82(this.auroraInstallationType_0);
                if (this.auroraInstallationType_0 == AuroraInstallationType.SectorCommand)
                    gclass146_0.method_66();
                if (AuroraUtils.GetRandomInteger(this.int_4) == 1)
                {
                    if (this.genum122_0 == TechType.None)
                        this.genum122_0 = this.gclass0_0.method_494(this.gclass162_0);
                    TechSystem gclass164_1 = gclass146_0.RaceData.method_387(this.genum122_0);
                    TechSystem gclass164_2 =
                        this.gclass0_0.method_493(this.genum122_0, gclass146_0.SystemBodyData.RuinRaceData.Level);
                    if (gclass164_2 != null)
                    {
                        int num = 0;
                        if (gclass164_1 != null)
                            num = gclass164_1.int_4;
                        if (gclass164_2.int_4 > num)
                        {
                            TechSystem gclass164_0 = gclass146_0.RaceData.method_392(this.genum122_0);
                            gclass146_0.RaceData.method_282(gclass164_0, null, null, null, true, false);
                            this.string_0 = $"{this.string_0} plus technical information on {gclass164_0.Name}";
                        }
                    }
                }
            }

            if (this.genum39_0 != GEnum39.const_2)
                this.gclass0_0.gclass92_0.method_2(EventType.const_65,
                    $"{gclass39_0.Formation.Name} has recovered {this.string_0} on {gclass146_0.SystemBodyData.method_78(gclass146_0.RaceData)}",
                    gclass146_0.RaceData, gclass146_0.gclass202_0.ActualSystemData, gclass146_0.method_87(),
                    gclass146_0.method_88(), AuroraEventCategory.PopGroundUnits);
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2662);
            return false;
        }
    }
}