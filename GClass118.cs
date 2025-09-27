// Decompiled with JetBrains decompiler
// Type: GClass118
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass118
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
    public GameRace gclass21_0;
    public GameRace gclass21_1;
    public ShipComponent gclass230_0;
    public RaceMissile gclass129_0;
    public GroundUnitClass101 gclass101_0;
    public int int_0;
    public int int_1;
    public double double_0;
    public double double_1;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public string string_0;

    public bool method_0(double double_2, double double_3)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass118.Class1071 class1071 = new GClass118.Class1071();
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
            return this.double_0 == double_2 && this.int_1 == int_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3959);
            return false;
        }
    }

    public GClass118 method_2(GameRace gclass21_2)
    {
        try
        {
            GClass118 gclass118_1 = new GClass118();
            GClass118 gclass118_2 = (GClass118)this.MemberwiseClone();
            gclass118_2.gclass21_0 = gclass21_2;
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
            if (this.double_1 <= 100.0)
                return $"{this.string_0}: GPS {AuroraUtils.smethod_38(this.decimal_1 * this.int_1)}";
            return
                $"{this.string_0}: {AuroraUtils.smethod_44(this.gclass230_0.double_0 / 1000000.0, 0)}m km  RES {AuroraUtils.smethod_37(this.int_1)}";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1924);
            return "Unknown";
        }
    }
}