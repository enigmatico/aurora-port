// Decompiled with JetBrains decompiler
// Type: GClass188
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class ShippingWealthData
{
    public ShippingLineData ShippingLine;
    public ShipData Ship;
    public TradeGood TradeGood;
    public PopulationData OriginPop;
    public PopulationData DestinationPop;
    public Decimal TradeTime;
    public Decimal Amount;
    public bool Contract;
    public bool Colonist;
    public bool Fuel;

    public int method_0()
    {
        try
        {
            return this.OriginPop != null ? this.OriginPop.PopulationID : 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2919);
            return 0;
        }
    }

    public int method_1()
    {
        try
        {
            return this.DestinationPop != null ? this.DestinationPop.PopulationID : 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2920);
            return 0;
        }
    }
}