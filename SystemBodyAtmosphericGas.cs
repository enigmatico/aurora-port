// Decompiled with JetBrains decompiler
// Type: GClass224
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
// something atmospheric gas on specific system body
public class SystemBodyAtmosphericGas
{
    public AtmosphericGasDefinition Gas;
    public int SystemBodyID;
    public double AtmoGasAmount;
    public double GasAtm;
    public bool FrozenOut;

    public SystemBodyAtmosphericGas()
    {
    }

    public SystemBodyAtmosphericGas(SystemBodyData gclass1_0, AtmosphericGasDefinition gclass223_1, double double_2, double double_3)
    {
        this.Gas = gclass223_1;
        this.GasAtm = double_2;
        this.AtmoGasAmount = double_3;
        this.SystemBodyID = gclass1_0.SystemBodyID;
    }

    public string method_0(Species gclass194_0)
    {
        try
        {
            string str = this.Gas.Name;
            if (this.FrozenOut)
                str += " (F)";
            if (this.Gas == gclass194_0.gclass223_0)
                str = string.Format("{0} ({1})", str, AuroraUtils.smethod_50(this.GasAtm));
            return string.Format("{0} {1}%", str, AuroraUtils.smethod_50(this.AtmoGasAmount));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3064);
            return "error";
        }
    }
}