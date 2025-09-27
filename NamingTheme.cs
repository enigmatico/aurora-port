// Decompiled with JetBrains decompiler
// Type: GClass140
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class NamingTheme
{
    private sealed class ThemeRandomChoose
    {
        public Random random_0;

        internal int method_0(string string_0)
        {
            return this.random_0.Next();
        }
    }

    public List<string> NameList = new List<string>();
    public int ThemeID;
    public bool RaceNameEligible;

    public string Description { get; set; }

    public string method_0(FCTRaceRecordC21 gclass21_0, GEnum21 genum21_0)
    {
        try
        {
            return this.method_2(gclass21_0, genum21_0, 0, "", "");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2072);
            return "";
        }
    }

    public string method_1(FCTRaceRecordC21 gclass21_0, GEnum21 genum21_0, int int_1)
    {
        try
        {
            return this.method_2(gclass21_0, genum21_0, int_1, "", "");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2072);
            return "";
        }
    }

    public string method_2(
        FCTRaceRecordC21 fctRace,
        GEnum21 genum21_0,
        int int_1,
        string string_1,
        string string_2)
    {
        try
        {
            bool flag = false;
            List<string> list = this.NameList.ToList<string>();
            if (int_1 == 1)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                list = list.OrderBy<string, int>(new NamingTheme.ThemeRandomChoose()
                {
                    random_0 = new Random()
                }.method_0).Select<string, string>(string_0 => string_0).ToList<string>();
            }

            foreach (string str in list)
            {
                string string_10 = str;
                string_10.Trim();
                if (string_1 != "")
                    string_10 = $"{string_1} {string_10}";
                if (string_2 != "")
                    string_10 = $"{string_10} {string_2}";
                switch (genum21_0)
                {
                    case GEnum21.const_0:
                        flag = fctRace.method_53(string_10);
                        break;
                    case GEnum21.const_1:
                        flag = fctRace.method_54(string_10);
                        break;
                    case GEnum21.const_2:
                        flag = fctRace.method_57(string_10);
                        break;
                    case GEnum21.const_3:
                        flag = fctRace.method_58(string_10);
                        break;
                    case GEnum21.const_4:
                        flag = fctRace.method_56(string_10);
                        break;
                    case GEnum21.const_5:
                        flag = fctRace.method_55(string_10);
                        break;
                }

                if (!flag)
                    return string_10.Trim();
            }

            return "";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2073);
            return "";
        }
    }
}