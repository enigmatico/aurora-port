// Decompiled with JetBrains decompiler
// Type: GClass84
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class SubFleet
{
    private GClass0 gclass0_0;
    public GameRace Race;
    public FleetData ParentFleet;
    public SubFleet ParentSubFleet;
    public int SubFleetID;
    public int ParentSubFleetID;
    public bool bool_0;
    public string SubFleetName;
    public FleetData AnchorFleet;
    public GClass117 gclass117_0;
    public int AnchorFleetID;
    public int SpecificThreatID;
    public int AnchorFleetBearingOffset;
    public double AnchorFleetDistance;
    public bool bGuardNearestHostileContact;
    public bool bGuardNearestKnownWarship;
    public bool bUseAnchorDestination;

    public SubFleet(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public List<ShipData> method_0()
    {
        return this.gclass0_0.Ships.Values
            .Where<ShipData>(gclass40_0 => gclass40_0.gclass84_0 == this).ToList<ShipData>();
    }

    public Decimal method_1()
    {
        try
        {
            return this.gclass0_0.Ships.Values
                       .Where<ShipData>(gclass40_0 => gclass40_0.gclass84_0 == this)
                       .Sum<ShipData>(gclass40_0 =>
                           gclass40_0.method_157(AuroraComponentType.ColonistTransport, false)) +
                   this.gclass0_0.Ships.Values
                       .Where<ShipData>(gclass40_0 => gclass40_0.gclass84_0 == this).Sum<ShipData>(
                           gclass40_0 =>
                               gclass40_0.method_157(AuroraComponentType.PassengerModule, false));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3479);
            return 0M;
        }
    }

    public int method_2()
    {
        try
        {
            return this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass84_0 == this)
                .Sum<ShipData>(gclass40_0 => gclass40_0.method_124());
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3472);
            return 0;
        }
    }

    public Decimal method_3()
    {
        return (int)this.gclass0_0.Ships.Values
            .Where<ShipData>(gclass40_0 => gclass40_0.gclass84_0 == this && !gclass40_0.gclass22_0.Commercial)
            .Sum<ShipData>(gclass40_0 => gclass40_0.gclass22_0.Size) * AuroraUtils.decimal_17;
    }

    public Decimal method_4()
    {
        return this.gclass0_0.Ships.Values
            .Where<ShipData>(gclass40_0 => gclass40_0.gclass84_0 == this).Sum<ShipData>(gclass40_0 =>
                gclass40_0.method_157(AuroraComponentType.MaintenanceModule, false));
    }

    public int method_5()
    {
        return (int)this.gclass0_0.Ships.Values
            .Where<ShipData>(gclass40_0 => gclass40_0.gclass84_0 == this).Sum<ShipData>(gclass40_0 =>
                gclass40_0.method_157(AuroraComponentType.FuelStorage, false));
    }

    public Decimal method_6()
    {
        try
        {
            return (int)this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass84_0 == this)
                .Sum<ShipData>(gclass40_0 => gclass40_0.method_172());
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3481);
            return 0M;
        }
    }

    public Decimal method_7()
    {
        try
        {
            return this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass84_0 == this)
                .Sum<ShipData>(gclass40_0 => gclass40_0.decimal_4);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3484);
            return 0M;
        }
    }

    public Decimal method_8()
    {
        return this.gclass0_0.Ships.Values
            .Where<ShipData>(gclass40_0 => gclass40_0.gclass84_0 == this)
            .Sum<ShipData>(gclass40_0 => gclass40_0.decimal_14);
    }

    public int method_9()
    {
        return (int)this.gclass0_0.Ships.Values
            .Where<ShipData>(gclass40_0 => gclass40_0.gclass84_0 == this).Sum<ShipData>(gclass40_0 =>
                gclass40_0.method_157(AuroraComponentType.TroopTransport, false));
    }

    public Decimal method_10()
    {
        return this.gclass0_0.Ships.Values
            .Where<ShipData>(gclass40_0 => gclass40_0.gclass84_0 == this).Sum<ShipData>(gclass40_0 =>
                gclass40_0.method_157(AuroraComponentType.CargoHold, false));
    }

    public double method_11()
    {
        try
        {
            double num1 = 0.0;
            foreach (ShipData gclass40 in this.method_0())
            {
                double num2 = gclass40.method_178();
                if (num2 > num1)
                    num1 = num2;
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3470);
            return 0.0;
        }
    }

    public double method_12()
    {
        try
        {
            double num1 = 0.0;
            foreach (ShipData gclass40 in this.method_0())
            {
                double num2 = gclass40.method_220();
                if (num2 > num1)
                    num1 = num2;
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3469);
            return 0.0;
        }
    }

    public double method_13(Decimal decimal_0)
    {
        try
        {
            double num = 0.0;
            foreach (ShipData gclass40 in this.method_0())
            {
                GClass71 gclass71 = gclass40.method_213(decimal_0, null);
                if (gclass71.double_0 > num)
                    num = gclass71.double_0;
            }

            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3468);
            return 0.0;
        }
    }

    public Decimal method_14()
    {
        try
        {
            Decimal num = 0M;
            foreach (ShipData gclass40 in this.method_0())
                num += gclass40.method_177();
            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3467);
            return 0M;
        }
    }

    public int method_15()
    {
        try
        {
            List<ShipData> list = this.gclass0_0.Ships.Values.Where<ShipData>(gclass40_0 =>
                    gclass40_0.gclass84_0 == this && gclass40_0.gclass40_0 == null && gclass40_0.gclass40_3 == null)
                .ToList<ShipData>();
            return list.Count == 0 ? 1 : (int)list.Min<ShipData>(gclass40_0 => gclass40_0.method_171(false));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3466);
            return 1;
        }
    }

    public GClass55 method_16()
    {
        try
        {
            List<GClass55> list = this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass84_0 == this)
                .Select<ShipData, GClass55>(gclass40_0 => gclass40_0.method_192(AuroraCommandType.Ship))
                .ToList<GClass55>();
            return list.Count == 0
                ? null
                : list.Where<GClass55>(gclass55_0 => gclass55_0 != null)
                    .OrderBy<GClass55, int>(gclass55_0 => gclass55_0.gclass61_0.RankNum)
                    .ThenBy<GClass55, int>(gclass55_0 => gclass55_0.int_4).FirstOrDefault<GClass55>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3465);
            return null;
        }
    }

    public void method_17(ListView listView_0)
    {
        try
        {
            listView_0.Items.Clear();
            if (this.AnchorFleet == null)
                this.gclass0_0.method_601(listView_0, "Anchor Fleet", "None", null);
            else
                this.gclass0_0.method_601(listView_0, "Anchor Fleet", this.AnchorFleet.FleetName, null);
            this.gclass0_0.method_601(listView_0, "Desired Distance", AuroraUtils.smethod_59(this.AnchorFleetDistance, "km"),
                null);
            this.gclass0_0.method_601(listView_0, "Desired Bearing Offset", AuroraUtils.smethod_58(this.AnchorFleetBearingOffset, "°"),
                null);
            if (this.gclass117_0 == null)
                this.gclass0_0.method_601(listView_0, "Specific Threat", "None", null);
            else
                this.gclass0_0.method_601(listView_0, "Specific Threat", this.gclass117_0.method_11(), null);
            this.gclass0_0.method_601(listView_0, "Guard vs Nearest Hostile Warship",
                AuroraUtils.smethod_70(this.bGuardNearestKnownWarship), null);
            this.gclass0_0.method_601(listView_0, "Guard vs Nearest Hostile Contact",
                AuroraUtils.smethod_70(this.bGuardNearestHostileContact), null);
            this.gclass0_0.method_601(listView_0, "Use Anchor Fleet Destination", AuroraUtils.smethod_70(this.bUseAnchorDestination),
                null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3363);
        }
    }

    public void method_18(FleetData gclass85_2)
    {
        try
        {
            this.ParentFleet = gclass85_2;
            this.Race.method_270(this.method_0(), this.ParentFleet, gclass85_2, false, false);
            foreach (SubFleet gclass84 in this.gclass0_0.SubFleetDictionary.Values
                         .Where<SubFleet>(gclass84_1 => gclass84_1.ParentSubFleet == this).ToList<SubFleet>())
                gclass84.method_18(gclass85_2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3221);
        }
    }
}