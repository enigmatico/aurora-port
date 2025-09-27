// Decompiled with JetBrains decompiler
// Type: GClass122
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Drawing;

#nullable disable
public class MapLabelData122
{
    private GClass0 gclass0_0;
    public FCTRaceRecordC21 Race;
    public Color Color;
    public Font Font;
    public string Caption;
    public double double_0;
    public double double_1;
    public double XCoord;
    public double YCoord;
    public double SavedXCoord;
    public double SavedYCoord;
    public double double_6;
    public double double_7;

    public MapLabelData122(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0()
    {
        try
        {
            this.double_6 = this.XCoord + this.Race.double_2;
            this.double_7 = this.YCoord + this.Race.double_3;
            this.double_6 = this.XCoord + this.Race.double_2;
            this.double_7 = this.YCoord + this.Race.double_3;
            this.double_6 = this.gclass0_0.double_6 - (this.gclass0_0.double_6 - this.double_6) * this.Race.ZoomSetting;
            this.double_7 = this.gclass0_0.double_7 - (this.gclass0_0.double_7 - this.double_7) * this.Race.ZoomSetting;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1976);
        }
    }

    public void method_1(Graphics graphics_0, bool bool_0)
    {
        try
        {
            this.method_0();
            this.double_0 = AuroraUtils.smethod_12(this.Caption, graphics_0, this.Font);
            this.double_1 = this.Font.SizeInPoints * (double)graphics_0.DpiX / 72.0;
            if (bool_0 && (this.double_6 < 0.0 - this.double_0 || this.double_6 > this.gclass0_0.double_2 ||
                           this.double_7 < 0.0 - this.double_1 || this.double_7 > this.gclass0_0.double_3))
                return;
            this.gclass0_0.method_528(graphics_0, this.Font, this.Color, this.double_6, this.double_7,
                (int)(this.double_0 * 1.2), (int)(this.double_1 * 1.5), this.Caption, StringAlignment.Near,
                StringAlignment.Near);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1977);
        }
    }

    public void method_2(int int_0, int int_1)
    {
        try
        {
            this.XCoord += int_0 / this.Race.ZoomSetting;
            this.YCoord += int_1 / this.Race.ZoomSetting;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1978);
        }
    }

    public void method_3()
    {
        try
        {
            this.XCoord = this.SavedXCoord;
            this.YCoord = this.SavedYCoord;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1979);
        }
    }

    public void method_4()
    {
        try
        {
            this.SavedXCoord = this.XCoord;
            this.SavedYCoord = this.YCoord;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1980);
        }
    }
}