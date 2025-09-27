// Decompiled with JetBrains decompiler
// Type: GClass227
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class GClass227
{
    private GClass221 gclass221_0;
    private GClass221 gclass221_1;
    private RacialSystemSurvey gclass202_0;

    public GClass227(double double_0, double double_1, RacialSystemSurvey gclass202_1)
    {
        this.gclass221_0 = new GClass221(double_0, double_1);
        this.gclass221_1 = new GClass221(double_0, double_1);
        this.gclass202_0 = gclass202_1;
    }

    public void method_0(double double_0, double double_1)
    {
        try
        {
            this.gclass221_1.double_0 = double_0;
            this.gclass221_1.double_1 = double_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3240);
        }
    }

    public void method_1(Graphics graphics_0, Font font_0, RacialSystemSurvey gclass202_1)
    {
        try
        {
            Pen pen = new Pen(Color.Green, 2f);
            SolidBrush solidBrush = new SolidBrush(Color.Green);
            string str = this.method_2();
            graphics_0.DrawLine(pen, (float)this.gclass221_0.double_0, (float)this.gclass221_0.double_1,
                (float)this.gclass221_1.double_0, (float)this.gclass221_1.double_1);
            float double0 = (float)this.gclass221_1.double_0;
            float double1 = (float)this.gclass221_1.double_1;
            float x;
            if (this.gclass221_1.double_0 < this.gclass221_0.double_0)
            {
                Size size = TextRenderer.MeasureText(str, font_0);
                x = double0 - 5f - size.Width;
            }
            else
                x = double0 + 5f;

            float y = this.gclass221_1.double_1 >= this.gclass221_0.double_1 ? double1 + 5f : double1 - 5f;
            graphics_0.DrawString(str, font_0, solidBrush, x, y);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3251);
        }
    }

    public string method_2()
    {
        try
        {
            double num1 = Math.Abs(this.gclass221_0.double_0 - this.gclass221_1.double_0);
            double num2 = Math.Abs(this.gclass221_0.double_1 - this.gclass221_1.double_1);
            double num3 = Math.Sqrt(num1 * num1 + num2 * num2) * this.gclass202_0.KmPerPixel;
            long num4;
            int int_72;
            string str;
            if (num3 < 1000000.0)
            {
                num4 = 1000L;
                int_72 = 0;
                str = "k km";
            }
            else if (num3 < 10000000.0)
            {
                num4 = 1000000L;
                int_72 = 1;
                str = "m km";
            }
            else if (num3 < 2000000000.0)
            {
                num4 = 1000000L;
                int_72 = 0;
                str = "m km";
            }
            else if (num3 < 10000000000.0)
            {
                num4 = 1000000000L;
                int_72 = 2;
                str = "b km";
            }
            else if (num3 < 100000000000.0)
            {
                num4 = 1000000000L;
                int_72 = 1;
                str = "b km";
            }
            else if (num3 < 2000000000000.0)
            {
                num4 = 1000000000L;
                int_72 = 0;
                str = "b km";
            }
            else
            {
                num4 = AuroraUtils.long_0;
                int_72 = 2;
                str = " LY";
            }

            return AuroraUtils.smethod_44(num3 / num4, int_72) + str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1617);
            return "error";
        }
    }
}