// Decompiled with JetBrains decompiler
// Type: GClass13
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;

#nullable disable
public class GClass13
{
    private GClass0 gclass0_0;
    public Dictionary<AuroraContactType, Contact> dictionary_0 = new Dictionary<AuroraContactType, Contact>();
    public PopulationData gclass146_0;
    public AlienPopulationIntel gclass113_0;
    public Contact gclass65_0;
    public double double_0;
    public double double_1;
    public double double_2;
    public double double_3;
    public bool bool_0;
    public bool bool_1;
    public bool bool_2;

    public GClass13(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public Decimal method_0()
    {
        try
        {
            Decimal num = this.gclass113_0.EMSignature / 25M;
            if (this.gclass65_0.ContactType == AuroraContactType.Population)
                return num;
            return this.gclass65_0.ContactType == AuroraContactType.Shipyard ? num / 10M : num * 5M;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 455);
            return 0M;
        }
    }

    public void method_1()
    {
        try
        {
            this.bool_1 = false;
            this.double_0 = (double)this.gclass113_0.EMSignature;
            if (this.double_0 == 0.0)
                this.double_0 = 1.0;
            if (this.dictionary_0.ContainsKey(AuroraContactType.STOGroundUnit))
            {
                this.gclass65_0 = this.dictionary_0[AuroraContactType.STOGroundUnit];
                this.double_0 *= 20.0;
            }
            else if (this.dictionary_0.ContainsKey(AuroraContactType.Shipyard))
            {
                this.gclass65_0 = this.dictionary_0[AuroraContactType.Shipyard];
                this.double_0 *= 5.0;
            }
            else if (this.dictionary_0.ContainsKey(AuroraContactType.GroundUnit) && !this.bool_2)
            {
                this.gclass65_0 = this.dictionary_0[AuroraContactType.GroundUnit];
                this.double_0 *= 2.0;
            }
            else if (this.dictionary_0.ContainsKey(AuroraContactType.Population) && !this.bool_2)
                this.gclass65_0 = this.dictionary_0[AuroraContactType.Population];
            else
                this.bool_1 = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 454);
        }
    }
}