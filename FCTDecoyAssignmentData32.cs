// Decompiled with JetBrains decompiler
// Type: GClass32
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class FCTDecoyAssignmentData32
{
    public FCTShipData40 FCTShipData;
    public ShipComponent LauncherData;
    public MissileAssignment gclass30_0;
    public int LauncherNum;

    public FCTDecoyAssignmentData32 method_0()
    {
        try
        {
            return (FCTDecoyAssignmentData32)this.MemberwiseClone();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 289);
            return null;
        }
    }
}