// Decompiled with JetBrains decompiler
// Type: GClass210
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class GClass210
{
    private GClass0 gclass0_0;
    public StarSystem gclass200_0;
    public int int_0;
    public Decimal decimal_0;
    public double double_0;
    public double double_1;
    public double double_2;

    public GClass210(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0(
        Graphics graphics_0,
        Font font_0,
        GClass222 gclass222_0,
        RacialSystemSurvey gclass202_0)
    {
        try
        {
            if (gclass202_0.Race.chkWP == CheckState.Unchecked)
                return;
            SolidBrush solidBrush = new SolidBrush(Color.Crimson);
            double x = gclass222_0.double_2 - AuroraUtils.int_61 / 2;
            double y = gclass222_0.double_3 - AuroraUtils.int_61 / 2;
            graphics_0.FillEllipse(solidBrush, (float)x, (float)y, AuroraUtils.int_61, AuroraUtils.int_61);
            GClass221 gclass221 = new GClass221();
            double num = graphics_0.MeasureString("Aether Gate", font_0).Width / 2.0;
            gclass221.double_0 = gclass222_0.double_2 - num;
            gclass221.double_1 = gclass222_0.double_3 + (AuroraUtils.int_61 + 2);
            graphics_0.DrawString("Aether Gate", font_0, solidBrush, (float)gclass221.double_0,
                (float)gclass221.double_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3406);
        }
    }
}