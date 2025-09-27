// Decompiled with JetBrains decompiler
// Type: GClass211
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Drawing;

#nullable disable
public class GClass211
{
    private GClass0 gclass0_0;
    public SystemData200 gclass200_0;
    public int int_0;
    public double double_0;
    public double double_1;
    public double double_2;

    public GClass211(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0(
        Graphics graphics_0,
        Font font_0,
        GClass222 gclass222_0,
        RacialSystemSurvey gclass202_0)
    {
        try
        {
            GClass221 gclass221 = new GClass221();
            float num1 = AuroraUtils.int_61 * 2;
            float num2 = (float)(this.double_2 / gclass202_0.KmPerPixel);
            if (num2 > (double)num1)
                num1 = num2;
            double x = gclass222_0.double_2 - num1 / 2.0;
            double y = gclass222_0.double_3 - num1 / 2.0;
            SolidBrush solidBrush1 = new SolidBrush(Color.Indigo);
            graphics_0.FillEllipse(solidBrush1, (float)x, (float)y, num1, num1);
            float num3 = num1 * 0.1f;
            if (num3 < 2.0)
                num3 = 2f;
            float num4 = num3 / 2f;
            SolidBrush solidBrush2 = new SolidBrush(Color.Black);
            graphics_0.FillEllipse(solidBrush2, (float)x + num4, (float)y + num4, num1 - num3, num1 - num3);
            solidBrush2.Color = Color.LimeGreen;
            double num5 = graphics_0.MeasureString("Aether Rift", font_0).Width / 2.0;
            gclass221.double_0 = gclass222_0.double_2 - num5;
            gclass221.double_1 = gclass222_0.double_3 + AuroraUtils.int_61;
            graphics_0.DrawString("Aether Rift", font_0, solidBrush2, (float)gclass221.double_0,
                (float)gclass221.double_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2950);
        }
    }
}