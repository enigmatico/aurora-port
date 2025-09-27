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
public class GClass114
{
    private GClass0 gclass0_0;
    public AlienRaceInfo gclass110_0;
    public GameRace gclass21_0;
    public GameRace gclass21_1;
    public GroundUnitClass101 gclass101_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public int int_3;
    public bool bool_0;
    public string string_0;

    public GClass114(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public GClass114 method_0(GameRace gclass21_2, List<AlienRaceInfo> list_0)
    {
        try
        {
            GClass114 gclass114_1 = new GClass114(this.gclass0_0);
            GClass114 gclass114_2 = (GClass114)this.MemberwiseClone();
            gclass114_2.int_0 = this.gclass0_0.method_26(GEnum0.const_48);
            gclass114_2.gclass21_0 = gclass21_2;
            gclass114_2.gclass110_0 =
                list_0.FirstOrDefault<AlienRaceInfo>(gclass110_1 => gclass110_1.ActualAlienRace == this.gclass110_0.ActualAlienRace);
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
                            $"{str}Weapon #{num.ToString()}:  Shots {gclass100.Shots.ToString()}  Penetration {(gclass100.Penetration * this.gclass101_0.decimal_1).ToString()}  Damage {(gclass100.Damage * this.gclass101_0.decimal_1).ToString()}    ";
                    ++num;
                }

                if (str != "")
                    this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                        $"The weapons of the alien ground unit {this.string_0} have been classified as: {str}",
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
                    $"The basic type of the alien ground unit {this.string_0} has been identified as {this.gclass101_0.GroundUnitBaseTypeData.Name}",
                    this.gclass21_0, null, 0.0, 0.0, AuroraEventCategory.Intelligence);
            Decimal num;
            if (this.int_2 < AuroraUtils.int_6 && this.int_2 + int_5 >= AuroraUtils.int_6)
            {
                GClass92 gclass920 = this.gclass0_0.gclass92_0;
                string string0 = this.string_0;
                num = this.gclass101_0.method_7();
                string str = num.ToString();
                string string_0 =
                    $"The armour strength of the alien ground unit {string0} has been calculated as {str}";
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
                    $"The 'hit point value' of the alien ground unit {string0} have been calculated as {str}";
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