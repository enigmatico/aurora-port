// Decompiled with JetBrains decompiler
// Type: GClass59
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class LifePod
{
    private GClass0 gclass0_0;
    public GameRace gclass21_0;
    public Species gclass194_0;
    public StarSystem gclass200_0;
    public ShipClass gclass22_0;
    public int int_0;
    public int int_1;
    public double double_0;
    public double double_1;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public string string_0;

    public LifePod(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0(
        Graphics graphics_0,
        Font font_0,
        GClass222 gclass222_0,
        RacialSystemSurvey gclass202_0,
        int int_2)
    {
        try
        {
            if (gclass202_0.Race.chkLifepods == CheckState.Unchecked)
                return;
            SolidBrush solidBrush = new SolidBrush(AuroraUtils.color_11);
            double x = gclass222_0.double_2 - AuroraUtils.int_63 / 2;
            double y = gclass222_0.double_3 - AuroraUtils.int_63 / 2;
            if (int_2 == 0)
                graphics_0.FillEllipse(solidBrush, (float)x, (float)y, AuroraUtils.int_62, AuroraUtils.int_62);
            string s;
            if (this.gclass21_0 == gclass202_0.Race)
            {
                string str1 = !(AuroraUtils.decimal_35 - (this.gclass0_0.GameTime - this.decimal_0) < 0M)
                    ? string.Format("LS: {0}",
                        this.gclass0_0.method_568(
                            (int)(AuroraUtils.decimal_35 - (this.gclass0_0.GameTime - this.decimal_0)), false))
                    : "Life Support Failure Imminent";
                string str2 = string.Format("{0} Life Pods:  {1} crew", this.string_0,
                    AuroraUtils.smethod_37(this.int_1));
                foreach (Commander gclass55 in this.gclass0_0.ActiveCommanders.Values
                             .Where<Commander>(gclass55_0 => gclass55_0.LifePod == this).ToList<Commander>())
                    str2 = string.Format("{0}   {1}", str2, gclass55.method_38());
                s = string.Format("{0}   {1}", str2, str1);
            }
            else
                s = string.Format("{0} life pods #{1}", gclass202_0.Race.method_324(this.gclass22_0.ShipClassID),
                    this.int_0.ToString());

            GClass221 gclass221 = new GClass221();
            gclass221.double_0 = x + AuroraUtils.int_61 + 5.0;
            gclass221.double_1 = y - 3.0 - int_2 * 15;
            graphics_0.DrawString(s, font_0, solidBrush, (float)gclass221.double_0, (float)gclass221.double_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 411);
        }
    }
}