// Decompiled with JetBrains decompiler
// Type: GClass121
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass121
{
    private GClass0 gclass0_0;
    public GameRace gclass21_0;
    public RacialSystemSurvey gclass202_0;
    public int int_0;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public double double_0;
    public double double_1;
    public List<PopulationData> list_0 = new List<PopulationData>();
    public List<FCTShipData40> list_1 = new List<FCTShipData40>();
    public List<FCTShipData40> list_2 = new List<FCTShipData40>();
    public List<FCTShipData40> list_3 = new List<FCTShipData40>();

    public GClass121(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public Decimal method_0(Decimal decimal_2, FCTShipData40 gclass40_0_1)
    {
        try
        {
            int num1 = gclass40_0_1.method_167(AuroraComponentType.CargoShuttleBay);
            Decimal num2 = decimal_2;
            this.list_0 = this.list_0.OrderByDescending<PopulationData, Decimal>(gclass146_0 => gclass146_0.MaintenanceStockpile)
                .ToList<PopulationData>();
            foreach (PopulationData gclass146 in this.list_0)
            {
                if (!(gclass146.MaintenanceStockpile >= num2))
                {
                    if (gclass146.MaintenanceStockpile > 0M)
                    {
                        num2 -= gclass146.MaintenanceStockpile;
                        gclass146.MaintenanceStockpile = 0M;
                    }
                }
                else
                {
                    gclass146.MaintenanceStockpile -= num2;
                    return decimal_2;
                }
            }

            this.list_3 = this.list_3.OrderByDescending<FCTShipData40, Decimal>(gclass40_0_2 => gclass40_0_2.decimal_4)
                .ToList<FCTShipData40>();
            foreach (FCTShipData40 gclass40 in this.list_3)
            {
                if (num1 + gclass40.method_167(AuroraComponentType.CargoShuttleBay) != 0)
                {
                    if (!(gclass40.decimal_4 >= num2))
                    {
                        if (gclass40.decimal_4 > 0M)
                        {
                            num2 -= gclass40.decimal_4;
                            gclass40.decimal_4 = 0M;
                        }
                    }
                    else
                    {
                        gclass40.decimal_4 -= num2;
                        return decimal_2;
                    }
                }
            }

            if (gclass40_0_1.decimal_4 >= num2)
            {
                gclass40_0_1.decimal_4 -= num2;
                return decimal_2;
            }

            if (gclass40_0_1.decimal_4 > 0M)
            {
                num2 -= gclass40_0_1.decimal_4;
                gclass40_0_1.decimal_4 = 0M;
            }

            return decimal_2 - num2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1969);
            return 0M;
        }
    }
}