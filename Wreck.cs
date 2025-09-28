// Decompiled with JetBrains decompiler
// Type: GClass233
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
public class Wreck
{
    [CompilerGenerated]
    private bool method_3(AlienShipClassIntel gclass115_0)
    {
        return gclass115_0.gclass22_0.ShipClassID == this.ShipClass.ShipClassID;
    }

    [CompilerGenerated]
    private sealed class Class1215
    {
        public TechSystem gclass164_0;

        internal bool method_0(TechSystem gclass164_1)
        {
            return gclass164_1.TechSystemID == this.gclass164_0.int_2;
        }
    }

    public List<WreckTech> ContainingTechs = new List<WreckTech>();
    public List<WreckComponents> ContainingComponents = new List<WreckComponents>();
    public GClass0 gclass0_0;
    public GameRace Race;
    public StarSystem System;
    public SystemBodyData OrbitingBody;
    public ShipClass ShipClass;
    public AllMineralsValue ContainingMineral;
    public int WreckID;
    public int ShipID;
    public int EffectiveSize;
    public int StarSwarmHatching;
    public int QueenStatus;
    public Decimal Size;
    public double Xcor;
    public double Ycor;

    public string ViewingName { get; set; }

    public Wreck(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0()
    {
        try
        {
            if (AuroraUtils.GetRandomInteger(200) > this.ShipClass.Size)
                return;
            int num = 128 /*0x80*/;
            for (int index = 1; index < num; index = AuroraUtils.GetRandomInteger(128 /*0x80*/))
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                Wreck.Class1215 class1215 = new Wreck.Class1215();
                ShipComponent gclass230 = this.ShipClass.method_38();
                if (gclass230 == null)
                    break;
                // ISSUE: reference to a compiler-generated field
                class1215.gclass164_0 = gclass230.method_6();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class1215.gclass164_0 == null && class1215.gclass164_0.bool_4)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    class1215.gclass164_0 =
                        this.gclass0_0.TechSystems.Values.FirstOrDefault<TechSystem>(class1215.method_0);
                }

                // ISSUE: reference to a compiler-generated field
                if (class1215.gclass164_0 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    this.ContainingTechs.Add(new WreckTech()
                    {
                        Percentage = AuroraUtils.GetRandomInteger(20),
                        TechData = class1215.gclass164_0
                    });
                }

                num /= 2;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3185);
        }
    }

    public string method_1(GameRace gclass21_1, bool bool_0)
    {
        try
        {
            string str1 = "";
            string str2;
            if (this.Race == gclass21_1)
            {
                str2 = this.ShipClass.ClassName;
            }
            else
            {
                AlienShipClassIntel gclass115 = gclass21_1.dictionary_11.Values.FirstOrDefault<AlienShipClassIntel>(gclass115_0 =>
                    gclass115_0.gclass22_0.ShipClassID == this.ShipClass.ShipClassID);
                if (gclass115 != null)
                {
                    str2 = gclass115.ClassName;
                    str1 = string.Format((string)"[{0}]",
                        (object)gclass21_1.AlienRaceIntels[this.Race.RaceID].Abbreviation);
                }
                else
                    str2 = "Unknown";
            }

            return bool_0
                ? string.Format((string)"Wreck of {0} class {1} #{2}: {3} tons)", new[] { str2 }, str1,
                    this.WreckID.ToString(), AuroraUtils.smethod_39(this.Size * 50M))
                : string.Format((string)"Wreck of {0} class {1}: {2} tons)", (object)str2, (object)str1,
                    (object)AuroraUtils.smethod_39(this.Size * 50M));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3186);
            return "";
        }
    }

    public void method_2(
        Graphics graphics_0,
        Font font_0,
        GClass222 gclass222_0,
        RacialSystemSurvey gclass202_0,
        int int_5,
        int int_6)
    {
        try
        {
            SolidBrush solidBrush = new SolidBrush(AuroraUtils.color_10);
            Pen pen = new Pen(AuroraUtils.color_10, 3f);
            double x1 = gclass222_0.double_2 - AuroraUtils.int_63 / 2;
            double num = gclass222_0.double_3 - AuroraUtils.int_63 / 2;
            if (int_5 == 0)
            {
                graphics_0.DrawLine(pen, (float)x1, (float)num, (float)x1 + AuroraUtils.int_63,
                    (float)num + AuroraUtils.int_63);
                graphics_0.DrawLine(pen, (float)x1, (float)num + AuroraUtils.int_63, (float)x1 + AuroraUtils.int_63,
                    (float)num);
            }

            string s;
            if (int_6 > 1)
            {
                string str = this.method_1(gclass202_0.Race, false);
                s = string.Format((string)"{0}x {1}", (object)AuroraUtils.smethod_37(int_6), (object)str);
            }
            else
                s = this.method_1(gclass202_0.Race, true);

            GClass221 gclass221 = new GClass221();
            gclass221.double_0 = x1 + AuroraUtils.int_61 + 5.0;
            gclass221.double_1 = num - 3.0 - int_5 * 15;
            graphics_0.DrawString(s, font_0, solidBrush, (float)gclass221.double_0, (float)gclass221.double_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3187);
        }
    }
}