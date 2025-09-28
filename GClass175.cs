// Decompiled with JetBrains decompiler
// Type: GClass175
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;

#nullable disable
public class GClass175
{
    private GClass0 gclass0_0;
    public GEnum118 genum118_0;
    public TechType genum122_0;
    public AuroraComponentType auroraComponentType_0;
    public int int_0;
    public int int_1;
    public int int_2 = 1;
    private string string_0;

    public GClass175(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public bool method_0(PopulationData gclass146_0, GroundUnitFormationElement gclass39_0)
    {
        try
        {
            ShipComponent gclass230_0 = null;
            this.gclass0_0.int_64 += this.int_0;
            if (this.gclass0_0.int_62 > this.gclass0_0.int_64)
                return false;
            this.int_1 = AuroraUtils.GetRandomInteger(this.int_2);
            if (this.genum118_0 != GEnum118.const_0)
                gclass230_0 = this.gclass0_0.ComponentDataDictionary[(int)this.genum118_0];
            else if (this.genum122_0 != TechType.None)
            {
                TechSystem gclass164 =
                    this.gclass0_0.method_493(this.genum122_0, gclass146_0.SystemBodyData.RuinRaceData.Level);
                if (gclass164 == null)
                    return true;
                gclass230_0 = this.gclass0_0.ComponentDataDictionary[gclass164.TechSystemID];
            }
            else if (this.auroraComponentType_0 != AuroraComponentType.NoType)
            {
                if (this.auroraComponentType_0 == AuroraComponentType.Laser)
                    gclass230_0 = gclass146_0.SystemBodyData.RuinRaceData.method_0();
                else if (this.auroraComponentType_0 == AuroraComponentType.Railgun)
                    gclass230_0 = gclass146_0.SystemBodyData.RuinRaceData.method_1();
                else if (this.auroraComponentType_0 == AuroraComponentType.ParticleBeam)
                    gclass230_0 = gclass146_0.SystemBodyData.RuinRaceData.method_2();
                else if (this.auroraComponentType_0 == AuroraComponentType.MesonCannon)
                    gclass230_0 = gclass146_0.SystemBodyData.RuinRaceData.method_3();
                else if (this.auroraComponentType_0 == AuroraComponentType.Carronade)
                    gclass230_0 = gclass146_0.SystemBodyData.RuinRaceData.method_4();
                else if (this.auroraComponentType_0 == AuroraComponentType.GaussCannon)
                    gclass230_0 = gclass146_0.SystemBodyData.RuinRaceData.method_5();
                else if (this.auroraComponentType_0 == AuroraComponentType.Shields)
                    gclass230_0 = gclass146_0.SystemBodyData.RuinRaceData.method_6();
                else if (this.auroraComponentType_0 == AuroraComponentType.CIWS)
                    gclass230_0 = gclass146_0.SystemBodyData.RuinRaceData.method_9();
                else if (this.auroraComponentType_0 == AuroraComponentType.JumpDrive)
                    gclass230_0 = gclass146_0.SystemBodyData.RuinRaceData.method_10();
                else if (this.auroraComponentType_0 == AuroraComponentType.Engine)
                    gclass230_0 = !AuroraUtils.smethod_23()
                        ? gclass146_0.SystemBodyData.RuinRaceData.method_8()
                        : gclass146_0.SystemBodyData.RuinRaceData.method_7();
            }

            if (gclass230_0 == null)
                return false;
            gclass146_0.method_67(gclass230_0, this.int_1);
            this.string_0 = this.int_1 != 1
                ? string.Format("{0} abandoned {1}", this.int_1.ToString(), AuroraUtils.smethod_11(gclass230_0.Name))
                : string.Format("an abandoned {0}", gclass230_0.Name);
            this.gclass0_0.gclass92_0.method_2(EventType.const_65,
                string.Format("{0} has recovered {1} on {2}", gclass39_0.Formation.Name, this.string_0,
                    gclass146_0.SystemBodyData.method_78(gclass146_0.Race)),
                gclass146_0.Race, gclass146_0.gclass202_0.ActualSystem, gclass146_0.method_87(),
                gclass146_0.method_88(), AuroraEventCategory.PopGroundUnits);
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2661);
            return false;
        }
    }
}