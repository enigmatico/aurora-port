// Decompiled with JetBrains decompiler
// Type: GClass114
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class AlienGroundUnitClassIntel
{
    private GClass0 gclass0_0;
    public AlienRaceIntel gclass110_0;
    public GameRace gclass21_0;
    public GameRace gclass21_1;
    public GroundUnitClass101 gclass101_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public int int_3;
    public bool bool_0;
    public string string_0;

    public AlienGroundUnitClassIntel(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public AlienGroundUnitClassIntel method_0(GameRace gclass21_2, List<AlienRaceIntel> list_0)
    {
        try
        {
            AlienGroundUnitClassIntel gclass114_1 = new AlienGroundUnitClassIntel(this.gclass0_0);
            AlienGroundUnitClassIntel gclass114_2 = (AlienGroundUnitClassIntel)this.MemberwiseClone();
            gclass114_2.int_0 = this.gclass0_0.method_26(GEnum0.const_48);
            gclass114_2.gclass21_0 = gclass21_2;
            gclass114_2.gclass110_0 =
                list_0.FirstOrDefault<AlienRaceIntel>(gclass110_1 => gclass110_1.ActualAlienRace == this.gclass110_0.ActualAlienRace);
            return gclass114_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1896);
            return null;
        }
    }

    public void method_1()
    {
        try
        {
            if (!this.bool_0)
            {
                string str = "";
                int num = 1;
                foreach (GroundComponentTypeDefinition gclass100 in this.gclass101_0.GroundUnitComponentList)
                {
                    if (gclass100.Shots > 0)
                        str =
                            string.Format("{0}Weapon #{1}:  Shots {2}  Penetration {3}  Damage {4}    ", str,
                                num.ToString(), gclass100.Shots.ToString(),
                                (gclass100.Penetration * this.gclass101_0.decimal_1).ToString(),
                                (gclass100.Damage * this.gclass101_0.decimal_1).ToString());
                    ++num;
                }

                if (str != "")
                    this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                        string.Format("The weapons of the alien ground unit {0} have been classified as: {1}",
                            this.string_0, str),
                        this.gclass21_0, null, 0.0, 0.0, AuroraEventCategory.Intelligence);
            }

            this.bool_0 = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1897);
        }
    }

    public void method_2(int int_4, int int_5, int int_6)
    {
        try
        {
            if (this.int_1 < AuroraUtils.int_6 && this.int_1 + int_4 >= AuroraUtils.int_6)
                this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                    string.Format("The basic type of the alien ground unit {0} has been identified as {1}",
                        this.string_0, this.gclass101_0.GroundUnitBaseTypeData.Name),
                    this.gclass21_0, null, 0.0, 0.0, AuroraEventCategory.Intelligence);
            Decimal num;
            if (this.int_2 < AuroraUtils.int_6 && this.int_2 + int_5 >= AuroraUtils.int_6)
            {
                GClass92 gclass920 = this.gclass0_0.gclass92_0;
                string string0 = this.string_0;
                num = this.gclass101_0.method_7();
                string str = num.ToString();
                string string_0 =
                    string.Format("The armour strength of the alien ground unit {0} has been calculated as {1}",
                        string0, str);
                GameRace gclass210 = this.gclass21_0;
                gclass920.method_2(EventType.const_66, string_0, gclass210, null, 0.0, 0.0,
                    AuroraEventCategory.Intelligence);
            }

            if (this.int_3 < AuroraUtils.int_6 && this.int_3 + int_6 >= AuroraUtils.int_6)
            {
                GClass92 gclass920 = this.gclass0_0.gclass92_0;
                string string0 = this.string_0;
                num = this.gclass101_0.method_8();
                string str = num.ToString();
                string string_0 =
                    string.Format("The 'hit point value' of the alien ground unit {0} have been calculated as {1}",
                        string0, str);
                GameRace gclass210 = this.gclass21_0;
                gclass920.method_2(EventType.const_66, string_0, gclass210, null, 0.0, 0.0,
                    AuroraEventCategory.Intelligence);
            }

            this.method_1();
            this.int_1 += int_4;
            this.int_2 += int_5;
            this.int_3 += int_6;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1898);
        }
    }
}