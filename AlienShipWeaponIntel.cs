// Decompiled with JetBrains decompiler
// Type: GClass119
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class AlienShipWeaponIntel
{
    public ShipComponent gclass230_0;
    public int int_0;
    public int int_1;
    public double double_0;
    public Decimal decimal_0;

    public AlienShipWeaponIntel method_0()
    {
        try
        {
            AlienShipWeaponIntel gclass119 = new AlienShipWeaponIntel();
            return (AlienShipWeaponIntel)this.MemberwiseClone();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1925);
            return null;
        }
    }
}