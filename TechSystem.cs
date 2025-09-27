// Decompiled with JetBrains decompiler
// Type: GClass164
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;

#nullable disable
public class TechSystem
{
    public GameRace gclass21_0;
    public TechTypeData gclass163_0;
    public TechSystem gclass164_0;
    public TechSystem gclass164_1;
    public ResearchCategoryType genum119_0;
    public Dictionary<int, GClass165> dictionary_0 = new Dictionary<int, GClass165>();
    public int TechSystemID;
    public int int_1;
    public int int_2;
    public int int_3;
    public int int_4;
    public int int_5;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public Decimal decimal_2;
    public Decimal decimal_3;
    public bool bool_0;
    public bool bool_1;
    public bool bool_2;
    public bool bool_3;
    public bool bool_4;
    public string string_0;
    public string string_1;
    public int int_6;

    public string Name { get; set; }

    public bool method_0(GameRace gclass21_1)
    {
        try
        {
            foreach (GClass165 gclass165 in this.dictionary_0.Values)
            {
                if (gclass165.gclass21_0 == gclass21_1 && !gclass165.bool_0)
                    return true;
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2605);
            return false;
        }
    }

    public bool method_1(GameRace gclass21_1)
    {
        try
        {
            return this.dictionary_0.ContainsKey(gclass21_1.RaceID);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2606);
            return false;
        }
    }
}