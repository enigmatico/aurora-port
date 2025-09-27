// Decompiled with JetBrains decompiler
// Type: GClass158
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class GClass158
{
    public PlanetaryInstallationType gclass157_0;
    public PopulationData gclass146_0;
    public FCTShipData40 gclass40_0;
    public Decimal decimal_0;
    public PopulationData gclass146_1;
    public Decimal decimal_1;
    public int int_0;

    public Decimal method_0()
    {
        try
        {
            return this.gclass157_0.CargoPoints * this.decimal_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2102);
            return 0M;
        }
    }
}