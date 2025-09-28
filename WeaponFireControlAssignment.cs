// Decompiled with JetBrains decompiler
// Type: GClass31
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class WeaponFireControlAssignment
{
    public ShipData Ship;
    public ShipComponent WeaponComponent;
    public ShipComponent FireControlComponent;
    public int WeaponNum;
    public int FireControlNum;
    public bool bool_0;
    public int int_2;
    public int int_3;
    public double double_0;
    public double double_1;

    public WeaponFireControlAssignment method_0()
    {
        try
        {
            return (WeaponFireControlAssignment)this.MemberwiseClone();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 289);
            return null;
        }
    }
}