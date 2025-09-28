// Decompiled with JetBrains decompiler
// Type: GClass118
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class AlienSensorIntel
{
    private sealed class Class1071
    {
        public double double_0;
        public double double_1;

        internal bool method_0(GClass221 gclass221_0)
        {
            return gclass221_0.double_0 == this.double_0 && gclass221_0.double_1 == this.double_1;
        }
    }

    public List<GClass221> list_0 = new List<GClass221>();
    public GameRace Race;
    public GameRace AlienRace;
    public ShipComponent ActualSensor;
    public RaceMissile ActualMissile;
    public GroundUnitClass101 ActualGroundUnitClass;
    public int AlienSensorID;
    public int Resolution;
    public double Range;
    public double IntelligencePoints;
    public Decimal decimal_0;
    public Decimal Strength;
    public string Name;

    public bool method_0(double double_2, double double_3)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        AlienSensorIntel.Class1071 class1071 = new AlienSensorIntel.Class1071();
        // ISSUE: reference to a compiler-generated field
        class1071.double_0 = double_2;
        // ISSUE: reference to a compiler-generated field
        class1071.double_1 = double_3;
        try
        {
            // ISSUE: reference to a compiler-generated method
            if (this.list_0.Where<GClass221>(class1071.method_0).FirstOrDefault<GClass221>() != null)
                return false;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.list_0.Add(new GClass221(class1071.double_0, class1071.double_1));
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3963);
            return false;
        }
    }

    public bool method_1(double double_2, int int_2)
    {
        try
        {
            return this.Range == double_2 && this.Resolution == int_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3959);
            return false;
        }
    }

    public AlienSensorIntel method_2(GameRace gclass21_2)
    {
        try
        {
            AlienSensorIntel gclass118_1 = new AlienSensorIntel();
            AlienSensorIntel gclass118_2 = (AlienSensorIntel)this.MemberwiseClone();
            gclass118_2.Race = gclass21_2;
            return gclass118_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1923);
            return null;
        }
    }

    public string method_3()
    {
        try
        {
            if (this.IntelligencePoints <= 100.0)
                return string.Format("{0}: GPS {1}", this.Name,
                    AuroraUtils.smethod_38(this.Strength * this.Resolution));
            return
                string.Format("{0}: {1}m km  RES {2}", this.Name,
                    AuroraUtils.FormatDoubleToPrecision(this.ActualSensor.double_0 / 1000000.0, 0),
                    AuroraUtils.smethod_37(this.Resolution));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1924);
            return "Unknown";
        }
    }
}