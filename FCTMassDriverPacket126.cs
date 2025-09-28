// Decompiled with JetBrains decompiler
// Type: GClass126
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class FCTMassDriverPacket126
{
    public AllMineralsValue MineralsValue;
    public GameRace Race;
    public StarSystem System;
    public PopulationData gclass146_0;
    public int PacketID;
    public Decimal Speed;
    public Decimal TotalSize;
    public double XCoord;
    public double YCoord;
    public double LastXCoord;
    public double LastYCoord;
    public double IncrementStartX;
    public double IncrementStartY;
    public bool bool_0;

    public void method_0(
        Graphics graphics_0,
        Font font_0,
        GClass222 gclass222_0,
        RacialSystemSurvey gclass202_0,
        int int_1)
    {
        try
        {
            SolidBrush solidBrush = new SolidBrush(Color.LightGray);
            Pen pen = new Pen(Color.LightGray);
            double x = gclass222_0.double_2 - AuroraUtils.int_61 / 2;
            double y = gclass222_0.double_3 - AuroraUtils.int_61 / 2;
            GClass221 gclass221_1 = new GClass221();
            GClass221 gclass221_2 = gclass202_0.method_47(this.IncrementStartX, this.IncrementStartY);
            graphics_0.DrawLine(pen, (float)gclass222_0.double_2, (float)gclass222_0.double_3,
                (float)gclass221_2.double_0, (float)gclass221_2.double_1);
            if (int_1 == 0)
                graphics_0.FillEllipse(solidBrush, (float)x, (float)y, AuroraUtils.int_61, AuroraUtils.int_61);
            string str1 = "";
            if (gclass202_0.Race.chkMPC == CheckState.Checked)
                str1 = "   " + this.MineralsValue.method_38();
            string str2 = AuroraUtils.smethod_39(this.Speed) + " km/s";
            GClass221 gclass221_3 = new GClass221();
            gclass221_3.double_0 = x + AuroraUtils.int_61 + 5.0;
            gclass221_3.double_1 = y - 3.0 - int_1 * 15;
            graphics_0.DrawString(
                $"Mineral Packet to {this.gclass146_0.PopName}   {AuroraUtils.FormatNumberToDigits(this.TotalSize, 0)} tons   {str2}{str1}",
                font_0, solidBrush, (float)gclass221_3.double_0, (float)gclass221_3.double_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2012);
        }
    }
}