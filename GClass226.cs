// Decompiled with JetBrains decompiler
// Type: GClass226
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Design.PluralizationServices;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;

#nullable disable
public static class GClass226
{
  [CompilerGenerated]
  [Serializable]
  private sealed class compStatics2<T>
  {
    public static readonly GClass226.compStatics2<T> compStatics3;
    public static Func<FieldInfo, IEnumerable<object>> compStatics3__292_0;
    public static Func<FieldInfo, object, Class332<FieldInfo, object>> compStatics3__292_1;

    static compStatics2()
    {
      GClass226.compStatics2<T>.compStatics3 = new GClass226.compStatics2<T>();
    }

    internal IEnumerable<object> method_0(FieldInfo fieldInfo_0)
    {
      return (IEnumerable<object>) fieldInfo_0.GetCustomAttributes(typeof (DescriptionAttribute), false);
    }

    internal Class332<FieldInfo, object> method_1(FieldInfo fieldInfo_0, object object_0)
    {
      return new Class332<FieldInfo, object>(fieldInfo_0, object_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class1210<T>
  {
    public string string_0;

    internal bool method_0(Class332<FieldInfo, object> class332_0)
    {
      return ((DescriptionAttribute) class332_0.Att).Description == this.string_0;
    }
  }
  
  public static string string_0 = "2.6.0";
  public static string string_1 = "Data Source=AuroraDB.db;Version=3;New=False;Compress=True;";
  public static int int_0 = 140;
  public static int int_1 = 140;
  public static double double_0 = 50.0;
  public static double double_1 = 48.0;
  public static double double_2 = 8.25;
  public static double double_3 = 50.0;
  public static double double_4 = 6.672E-11;
  public static double double_5 = 1.989E+30;
  public static double double_6 = 5.972E+24;
  public static double double_7 = 0.00465047;
  public static double double_8 = 1E+47;
  public static int int_2 = 493;
  public static Decimal decimal_0 = 0.25M;
  public static Decimal decimal_1 = 0.0001M;
  public static Decimal decimal_2 = 0.004M;
  public static Decimal decimal_3 = 0.0001M;
  public static Decimal decimal_4 = 0.5M;
  public static int int_3 = 125;
  public static int int_4 = 250;
  public static Decimal decimal_5 = 0.5M;
  public static int int_5 = 5;
  public static Decimal decimal_6 = 0.5M;
  public static int int_6 = 20;
  public static int int_7 = 100000000;
  public static double double_9 = 500000000.0;
  public static double double_10 = 60000000.0;
  public static int int_8 = 10000;
  public static double double_11 = 10000000.0;
  public static int int_9 = 10;
  public static Decimal decimal_7 = 0.25M;
  public static int int_10 = 160 /*0xA0*/;
  public static int int_11 = 864000;
  public static int int_12 = 1000000;
  public static int int_13 = 500000;
  public static int int_14 = 5000000;
  public static int int_15 = 80 /*0x50*/;
  public static double double_12 = 0.75;
  public static Decimal decimal_8 = 0.2M;
  public static Decimal decimal_9 = 0.1M;
  public static Decimal decimal_10 = 0.05M;
  public static Decimal decimal_11 = 0.1M;
  public static Decimal decimal_12 = 10M;
  public static Decimal decimal_13 = 500M;
  public static Decimal decimal_14 = 1000M;
  public static long long_0 = 9460730472580;
  public static long long_1 = 946073047258000000;
  public static Decimal decimal_15 = 511187128M;
  public static int int_16 = 12000;
  public static double double_13 = 3.1416;
  public static Decimal decimal_16 = 2500M;
  public static double double_14 = 149600000.0;
  public static double double_15 = 15.0;
  public static double double_16 = 450000.0;
  public static double double_17 = 200.0;
  public static Decimal decimal_17 = 50M;
  public static int int_17 = 273;
  public static Decimal decimal_18 = 11.18M;
  public static Decimal decimal_19 = 10000M;
  public static Decimal decimal_20 = 10000M;
  public static double double_18 = 250000.0;
  public static double double_19 = 1000.0;
  public static int int_18 = 5;
  public static int int_19 = 500;
  public static double double_20 = 0.3;
  public static Decimal decimal_21 = 0.04M;
  public static Decimal decimal_22 = 0.25M;
  public static int int_20 = 100;
  public static Decimal decimal_23 = 20M;
  public static Decimal decimal_24 = 10M;
  public static Decimal decimal_25 = 20M;
  public static int int_21 = 20000;
  public static Decimal decimal_26 = 10M;
  public static Decimal decimal_27 = 30M;
  public static Decimal decimal_28 = 2M;
  public static Decimal decimal_29 = 31536000M;
  public static Decimal decimal_30 = 157680000M;
  public static Decimal decimal_31 = 2592000M;
  public static Decimal decimal_32 = 7776000M;
  public static Decimal decimal_33 = 15552000M;
  public static Decimal decimal_34 = 432000M;
  public static Decimal decimal_35 = 1209600M;
  public static int int_22 = 30;
  public static int int_23 = 5;
  public static Decimal decimal_36 = 0.05M;
  public static Decimal decimal_37 = 0.7M;
  public static int int_24 = 4;
  public static Decimal decimal_38 = 10M;
  public static int int_25 = 5000;
  public static int int_26 = 100;
  public static int int_27 = 10;
  public static Decimal decimal_39 = -0.25M;
  public static Decimal decimal_40 = 2M;
  public static Decimal decimal_41 = 0.8M;
  public static Decimal decimal_42 = 0.2M;
  public static Decimal decimal_43 = 4M;
  public static Decimal decimal_44 = 1M;
  public static Decimal decimal_45 = 0.25M;
  public static Decimal decimal_46 = 5M;
  public static Decimal decimal_47 = 0.125M;
  public static int int_28 = 2000;
  public static Decimal decimal_48 = 0.0001M;
  public static int int_29 = 1000;
  public static int int_30 = 120;
  public static int int_31 = 10;
  public static int int_32 = 400;
  public static double double_21 = 2000000000.0;
  public static double double_22 = 4000000000.0;
  public static double double_23 = 6000000000.0;
  public static int int_33 = 10;
  public static int int_34 = 1000;
  public static Decimal decimal_49 = 30M;
  public static double double_24 = 0.1;
  public static double double_25 = 4.0;
  public static double double_26 = 0.01;
  public static double double_27 = 40.0;
  public static Decimal decimal_50 = 2.5M;
  public static int int_35 = 30;
  public static int int_36 = 5;
  public static int int_37 = 240 /*0xF0*/;
  public static int int_38 = 300;
  public static int int_39 = 4;
  public static Decimal decimal_51 = 30M;
  public static Decimal decimal_52 = 3000M;
  public static int int_40 = 20;
  public static int int_41 = 2000;
  public static int int_42 = 1000;
  public static Decimal decimal_53 = 2500M;
  public static int int_43 = 60;
  public static Decimal decimal_54 = 6M;
  public static Decimal decimal_55 = 0.3M;
  public static Decimal decimal_56 = 1.25M;
  public static int int_44 = 1250;
  public static int int_45 = 2500;
  public static int int_46 = 5000;
  public static int int_47 = 10000;
  public static int int_48 = 20000;
  public static int int_49 = 50000;
  public static int int_50 = 250000;
  public static int int_51 = 1000000;
  public static int int_52 = 4000000;
  public static long long_2 = 10000000000;
  public static long long_3 = 12000000000;
  public static long long_4 = 15000000000;
  public static int int_53 = 4;
  public static double double_28 = 0.1;
  public static int int_54 = 2;
  public static Decimal decimal_57 = 0.25M;
  public static Decimal decimal_58 = 0.25M;
  public static Decimal decimal_59 = 0.25M;
  public static Decimal decimal_60 = 0.5M;
  public static Decimal decimal_61 = 0.25M;
  public static Decimal decimal_62 = 0.1M;
  public static Decimal decimal_63 = 4M;
  public static Decimal decimal_64 = 5M;
  public static Decimal decimal_65 = 200M;
  public static Decimal decimal_66 = 0.5M;
  public static int int_55 = 5;
  public static Decimal decimal_67 = 0.1M;
  public static int int_56 = 120;
  public static Decimal decimal_68 = 0.05M;
  public static Decimal decimal_69 = 0.25M;
  public static int int_57 = 1;
  public static int int_58 = 30;
  public static int int_59 = 50;
  public static double double_29 = 6.0;
  public static double double_30 = 4.0;
  public static int int_60 = 8;
  public static int int_61 = 10;
  public static int int_62 = 10;
  public static int int_63 = 12;
  public static int int_64 = 16 /*0x10*/;
  public static double double_31 = 1391400.0;
  public static int int_65 = 200;
  public static int int_66 = 800;
  public static int int_67 = 2400;
  public static int int_68 = 6000;
  public static int int_69 = -100;
  public static int int_70 = 800;
  public static int int_71 = 4000;
  public static Decimal decimal_70 = 1.5M;
  public static Color color_0 = Color.LightSkyBlue;
  public static Color color_1 = Color.Orange;
  public static Color color_2 = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
  public static Color color_3 = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
  public static Color color_4 = Color.FromArgb(0, 206, 209);
  public static Color color_5 = Color.LimeGreen;
  public static Color color_6 = Color.Red;
  public static Color color_7 = Color.FromArgb(144 /*0x90*/, 238, 144 /*0x90*/);
  public static Color color_8 = Color.FromArgb(152, 251, 152);
  public static Color color_9 = Color.FromArgb(34, 139, 34);
  public static Color color_10 = Color.FromArgb((int) byte.MaxValue, 140, 0);
  public static Color color_11 = Color.FromArgb((int) byte.MaxValue, 215, 0);
  public static Color color_12 = Color.FromArgb(0, (int) byte.MaxValue, (int) byte.MaxValue);
  public static Color color_13 = Color.FromArgb(0, (int) byte.MaxValue, (int) byte.MaxValue);
  public static Color color_14 = Color.FromArgb(80 /*0x50*/, 80 /*0x50*/, 80 /*0x50*/);
  public static Color color_15 = Color.FromArgb(60, 179, 113);
  public static Color color_16 = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
  public static Color color_17 = Color.FromArgb(0, (int) byte.MaxValue, (int) byte.MaxValue);
  public static Color color_18 = Color.FromArgb(0, 50, (int) byte.MaxValue);
  public static Color color_19 = Color.FromArgb(0, 0, 64 /*0x40*/);
  public static Color color_20 = Color.FromArgb(0, (int) byte.MaxValue, 160 /*0xA0*/);
  public static Color color_21 = Color.FromArgb(0, (int) byte.MaxValue, 160 /*0xA0*/);
  public static Decimal decimal_71 = 100M;
  public static Decimal decimal_72 = 250M;
  public static Random random_0 = new Random();
  private static RNGCryptoServiceProvider rngcryptoServiceProvider_0 = new RNGCryptoServiceProvider();

  public static void smethod_0(ListView listView_0, object object_0)
  {
    try
    {
      foreach (ListViewItem listViewItem in listView_0.Items)
      {
        if (listViewItem.Tag == object_0)
        {
          listViewItem.Selected = true;
          break;
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3870);
    }
  }

  public static string smethod_1(double double_32)
  {
    try
    {
      if (double_32 < 6.67)
        return GClass226.smethod_43(double_32 * GClass226.double_14 / 1000000.0) + " m";
      if (double_32 < 33.33)
        return GClass226.smethod_44(double_32 * GClass226.double_14 / 1000000000.0, 2) + " b";
      if (double_32 < 666.67)
        return GClass226.smethod_44(double_32 * GClass226.double_14 / 1000000000.0, 1) + " b";
      if (double_32 < 6666.67)
        return GClass226.smethod_43(double_32 * GClass226.double_14 / 1000000000.0) + " b";
      if (double_32 < 33333.0)
        return GClass226.smethod_44(double_32 * GClass226.double_14 / 1000000000000.0, 2) + " t";
      return double_32 < 666666.0 ? GClass226.smethod_44(double_32 * GClass226.double_14 / 1000000000000.0, 1) + " t" : GClass226.smethod_43(double_32 * GClass226.double_14 / 1000000000000.0) + " t";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2951);
      return "error";
    }
  }

  public static Decimal smethod_2(string string_2, Decimal decimal_73)
  {
    try
    {
      GClass208 gclass208 = GClass226.smethod_4(string_2);
      return gclass208.bool_0 ? gclass208.decimal_0 : decimal_73;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3244);
      return decimal_73;
    }
  }

  public static double smethod_3(string string_2, double double_32)
  {
    try
    {
      GClass209 gclass209 = GClass226.smethod_5(string_2);
      return gclass209.bool_0 ? gclass209.double_0 : double_32;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3245);
      return double_32;
    }
  }

  public static GClass208 smethod_4(string string_2)
  {
    GClass208 gclass208 = new GClass208();
    try
    {
      CultureInfo provider = new CultureInfo("en-US");
      gclass208.bool_0 = false;
      gclass208.decimal_0 = 0M;
      gclass208.bool_0 = Decimal.TryParse(string_2, NumberStyles.Number, (IFormatProvider) provider, out gclass208.decimal_0);
      return gclass208;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3242);
      return gclass208;
    }
  }

  public static GClass209 smethod_5(string string_2)
  {
    GClass209 gclass209 = new GClass209();
    try
    {
      CultureInfo provider = new CultureInfo("en-US");
      gclass209.bool_0 = false;
      gclass209.double_0 = 0.0;
      gclass209.bool_0 = double.TryParse(string_2, NumberStyles.Number, (IFormatProvider) provider, out gclass209.double_0);
      return gclass209;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3242);
      return gclass209;
    }
  }

  public static string smethod_6(
    AuroraSystemProtectionStatus auroraSystemProtectionStatus_0)
  {
    try
    {
      switch (auroraSystemProtectionStatus_0)
      {
        case AuroraSystemProtectionStatus.NoProtection:
          return "";
        case AuroraSystemProtectionStatus.SuggestLeave:
          return " (SL)";
        case AuroraSystemProtectionStatus.RequestLeave:
          return " (RL)";
        case AuroraSystemProtectionStatus.RequestLeaveUrgently:
          return " (RLU)";
        case AuroraSystemProtectionStatus.DemandLeave:
          return " (DL)";
        case AuroraSystemProtectionStatus.DemandLeaveWithThreat:
          return " (DLT)";
        default:
          return "";
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1716);
      return "";
    }
  }

  public static string smethod_7(Decimal decimal_73)
  {
    try
    {
      if (decimal_73 < 10000M)
        return GClass226.smethod_47(decimal_73);
      if (decimal_73 < 1000000M)
        return GClass226.smethod_39(decimal_73 / 1000M) + "k";
      return decimal_73 < 10000000M ? GClass226.smethod_42(decimal_73 / 1000000M, 1) + "m" : GClass226.smethod_39(decimal_73 / 1000000M) + "m";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1717);
      return "0";
    }
  }

  public static Decimal smethod_8(Decimal decimal_73, int int_72)
  {
    try
    {
      decimal_73 /= (Decimal) int_72;
      decimal_73 = Math.Ceiling(decimal_73);
      return decimal_73 * (Decimal) int_72;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1718);
      return 0M;
    }
  }

  public static Decimal smethod_9(Decimal decimal_73, int int_72)
  {
    try
    {
      Decimal num = Math.Round(decimal_73, int_72);
      if (num < decimal_73)
      {
        switch (int_72)
        {
          case 1:
            num += 0.1M;
            break;
          case 2:
            num += 0.01M;
            break;
          case 3:
            num += 0.001M;
            break;
          case 4:
            num += 0.0001M;
            break;
        }
      }
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3661);
      return 0M;
    }
  }

  public static string smethod_10(int int_72)
  {
    try
    {
      string str = "-";
      if (int_72 > 0)
        str = int_72 >= 5000 ? (int_72 >= 1000000 ? (int_72 / 1000000).ToString() + "M" : (int_72 / 1000).ToString()) : GClass226.smethod_37(int_72);
      return str;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1719);
      return "-";
    }
  }

  public static string smethod_11(string string_2)
  {
    try
    {
      PluralizationService service = PluralizationService.CreateService(CultureInfo.GetCultureInfo("en-gb"));
      return string_2 == "Infrastructure" || service.IsPlural(string_2) ? string_2 : service.Pluralize(string_2);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1720);
      return string_2;
    }
  }

  public static double smethod_12(string string_2, Graphics graphics_0, Font font_0)
  {
    try
    {
      return (double) graphics_0.MeasureString(string_2, font_0, 0, StringFormat.GenericTypographic).Width + 40.0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1721);
      return 0.0;
    }
  }

  public static int smethod_13(int int_72)
  {
    try
    {
      return int_72 == 0 ? 0 : GClass226.random_0.Next(int_72) + 1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1722);
      return -1;
    }
  }

  public static int smethod_14(Decimal decimal_73)
  {
    try
    {
      return decimal_73 == 0M ? 0 : GClass226.random_0.Next((int) decimal_73) + 1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3843);
      return -1;
    }
  }

  public static int smethod_15(byte byte_0)
  {
    try
    {
      if (byte_0 <= (byte) 0)
        throw new ArgumentOutOfRangeException("numberSides");
      byte[] data = new byte[1];
      GClass226.rngcryptoServiceProvider_0.GetBytes(data);
      return (int) data[0] % (int) byte_0 + 1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1723);
      return 0;
    }
  }

  public static long smethod_16(long long_5)
  {
    try
    {
      switch (long_5)
      {
        case 0:
          return 0;
        case 1:
          return 1;
        case 2:
          return GClass226.smethod_23() ? 1L : 2L;
        default:
          long num;
          do
          {
            num = (long) (GClass226.random_0.NextDouble() * (double) long_5);
          }
          while (num < 1L);
          if (num < 1L)
            num = 1L;
          return num;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1724);
      return -1;
    }
  }

  public static double smethod_17()
  {
    try
    {
      return GClass226.random_0.NextDouble();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3292);
      return 0.5;
    }
  }

  public static string smethod_18(string string_2)
  {
    try
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.RestoreDirectory = true;
      openFileDialog.InitialDirectory = $"{Application.StartupPath}\\{string_2}";
      return openFileDialog.ShowDialog() == DialogResult.OK ? openFileDialog.FileName : "";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1725);
      return "error";
    }
  }

  public static string smethod_19(string string_2)
  {
    try
    {
      string searchPattern = "*.png";
      if (string_2 == "Races")
        searchPattern = "*.bmp";
      if (string_2 == "Flags")
        searchPattern = "*.jpg";
      FileInfo[] files = new DirectoryInfo($"{Application.StartupPath}\\{string_2}").GetFiles(searchPattern);
      int index = new Random().Next(0, files.Length);
      return files[index].Name;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1726);
      return "error";
    }
  }

  public static int smethod_20() => GClass226.smethod_21(1);

  public static int smethod_21(int int_72)
  {
    try
    {
      int num = 0;
      for (int index = 1; index <= int_72; ++index)
        num += GClass226.smethod_13(10);
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1735);
      return 0;
    }
  }

  public static int smethod_22(int int_72, int int_73)
  {
    int num = 0;
    for (int index = 1; index <= int_73; ++index)
      num += GClass226.smethod_13(int_72);
    return num;
  }

  public static bool smethod_23() => GClass226.smethod_13(2) == 1;

  public static string smethod_24(Decimal decimal_73, int int_72)
  {
    decimal_73 *= 100M;
    decimal_73 = Math.Round(decimal_73, int_72);
    return decimal_73.ToString() + "%";
  }

  public static string smethod_25(string string_2, int int_72) => string_2.Substring(0, int_72);

  public static CheckState smethod_26(int int_72)
  {
    return int_72 == 1 ? CheckState.Checked : CheckState.Unchecked;
  }

  public static bool smethod_27(CheckState checkState_0) => checkState_0 == CheckState.Checked;

  public static CheckState smethod_28(bool bool_0)
  {
    return bool_0 ? CheckState.Checked : CheckState.Unchecked;
  }

  public static int smethod_29(CheckState checkState_0)
  {
    return checkState_0 == CheckState.Checked ? 1 : 0;
  }

  public static string smethod_30(Decimal decimal_73)
  {
    if (decimal_73 < 48M)
      return GClass226.smethod_42(decimal_73, 1) + " Hours";
    return decimal_73 < 8760M ? GClass226.smethod_42(decimal_73 / 24M, 1) + " Days" : GClass226.smethod_42(decimal_73 / 8760M, 1) + " Years";
  }

  public static string smethod_31(double double_32)
  {
    if (double_32 < 48.0)
      return GClass226.smethod_44(double_32, 1) + " Hours";
    return double_32 < 8760.0 ? GClass226.smethod_44(double_32 / 24.0, 1) + " Days" : GClass226.smethod_44(double_32 / 8760.0, 1) + " Years";
  }

  public static string smethod_32(int int_72)
  {
    return int_72 < 10 ? "0" + int_72.ToString() : int_72.ToString();
  }

  public static string smethod_33(int int_72)
  {
    if (int_72 < 10)
      return "00" + int_72.ToString();
    return int_72 < 100 ? "0" + int_72.ToString() : int_72.ToString();
  }

  public static string smethod_34(int int_72)
  {
    if (int_72 < 10)
      return "000" + int_72.ToString();
    if (int_72 < 100)
      return "00" + int_72.ToString();
    return int_72 < 1000 ? "0" + int_72.ToString() : int_72.ToString();
  }

  public static Decimal smethod_35(Decimal decimal_73) => (Decimal) Math.Sqrt((double) decimal_73);

  public static Decimal smethod_36(Decimal decimal_73)
  {
    return (Decimal) Math.Sqrt(Math.Sqrt((double) decimal_73));
  }

  public static string smethod_37(int int_72) => string.Format("{0:#,0}", (object) int_72);

  public static string smethod_38(Decimal decimal_73)
  {
    return string.Format("{0:#,0}", (object) decimal_73);
  }

  public static string smethod_39(Decimal decimal_73)
  {
    return string.Format("{0:#,0}", (object) decimal_73);
  }

  public static string smethod_40(Decimal decimal_73)
  {
    return decimal_73 == 0M ? "-" : string.Format("{0:#,0}", (object) decimal_73);
  }

  public static string smethod_41(Decimal decimal_73, int int_72)
  {
    return decimal_73 == 0M ? "-" : GClass226.smethod_42(decimal_73, int_72);
  }

  public static string smethod_42(Decimal decimal_73, int int_72)
  {
    switch (int_72)
    {
      case 0:
        return string.Format("{0:#,0}", (object) decimal_73);
      case 1:
        return string.Format("{0:#,0.#}", (object) decimal_73);
      case 2:
        return string.Format("{0:#,0.##}", (object) decimal_73);
      case 3:
        return string.Format("{0:#,0.###}", (object) decimal_73);
      case 4:
        return string.Format("{0:#,0.####}", (object) decimal_73);
      default:
        return decimal_73.ToString();
    }
  }

  public static string smethod_43(double double_32) => string.Format("{0:#,0}", (object) double_32);

  public static string smethod_44(double double_32, int int_72)
  {
    switch (int_72)
    {
      case 0:
        return string.Format("{0:#,0}", (object) double_32);
      case 1:
        return string.Format("{0:#,0.#}", (object) double_32);
      case 2:
        return string.Format("{0:#,0.##}", (object) double_32);
      case 3:
        return string.Format("{0:#,0.###}", (object) double_32);
      case 4:
        return string.Format("{0:#,0.####}", (object) double_32);
      default:
        return double_32.ToString();
    }
  }

  public static string smethod_45(Decimal decimal_73, int int_72)
  {
    switch (int_72)
    {
      case 1:
        return string.Format("{0:#,0.0}", (object) decimal_73);
      case 2:
        return string.Format("{0:#,0.00}", (object) decimal_73);
      case 3:
        return string.Format("{0:#,0.000}", (object) decimal_73);
      case 4:
        return string.Format("{0:#,0.0000}", (object) decimal_73);
      default:
        return decimal_73.ToString();
    }
  }

  public static string smethod_46(double double_32, int int_72)
  {
    switch (int_72)
    {
      case 1:
        return string.Format("{0:#,0.0}", (object) double_32);
      case 2:
        return string.Format("{0:#,0.00}", (object) double_32);
      case 3:
        return string.Format("{0:#,0.000}", (object) double_32);
      case 4:
        return string.Format("{0:#,0.0000}", (object) double_32);
      default:
        return double_32.ToString();
    }
  }

  public static string smethod_47(Decimal decimal_73)
  {
    if (decimal_73 > 20M)
      return string.Format("{0:#,0}", (object) decimal_73);
    if (decimal_73 > 1M)
      return string.Format("{0:#,0.#}", (object) decimal_73);
    if (decimal_73 > 0.1M)
      return string.Format("{0:#,0.##}", (object) decimal_73);
    if (decimal_73 > 0.01M)
      return string.Format("{0:#,0.###}", (object) decimal_73);
    return decimal_73 > 0.00001M ? string.Format("{0:#,0.####}", (object) decimal_73) : "0";
  }

  public static string smethod_48(double double_32)
  {
    if (double_32 > 20.0)
      return string.Format("{0:#,0}", (object) double_32);
    if (double_32 > 1.0)
      return string.Format("{0:#,0.#}", (object) double_32);
    if (double_32 > 0.1)
      return string.Format("{0:#,0.##}", (object) double_32);
    if (double_32 > 0.01)
      return string.Format("{0:#,0.###}", (object) double_32);
    return double_32 > 1E-05 ? string.Format("{0:#,0.####}", (object) double_32) : "0";
  }

  public static string smethod_49(Decimal decimal_73)
  {
    if (decimal_73 > 50M || decimal_73 < -50M)
      return string.Format("{0:#,0}", (object) decimal_73);
    if (decimal_73 > 5M || decimal_73 < -5M)
      return string.Format("{0:#,0.#}", (object) decimal_73);
    if (decimal_73 > 0.5M || decimal_73 < -0.5M)
      return string.Format("{0:#,0.##}", (object) decimal_73);
    return !(decimal_73 > 0.05M) && !(decimal_73 < -0.05M) ? string.Format("{0:#,0.####}", (object) decimal_73) : string.Format("{0:#,0.###}", (object) decimal_73);
  }

  public static string smethod_50(double double_32)
  {
    if (double_32 > 50.0 || double_32 < -50.0)
      return string.Format("{0:#,0}", (object) double_32);
    if (double_32 > 5.0 || double_32 < -5.0)
      return string.Format("{0:#,0.#}", (object) double_32);
    if (double_32 > 0.5 || double_32 < -0.5)
      return string.Format("{0:#,0.##}", (object) double_32);
    return double_32 <= 0.05 && double_32 >= -0.05 ? string.Format("{0:#,0.####}", (object) double_32) : string.Format("{0:#,0.###}", (object) double_32);
  }

  public static string smethod_51(Decimal decimal_73)
  {
    if (decimal_73 > 0.5M || decimal_73 < -5M)
      return string.Format("{0:#,0.00}", (object) decimal_73);
    if (decimal_73 > 0.05M || decimal_73 < -0.05M)
      return string.Format("{0:#,0.00#}", (object) decimal_73);
    if (decimal_73 > 0.005M || decimal_73 < -0.005M)
      return string.Format("{0:#,0.00##}", (object) decimal_73);
    return !(decimal_73 > 0.0005M) && !(decimal_73 < -0.0005M) ? string.Format("{0:#,0.00####}", (object) decimal_73) : string.Format("{0:#,0.00###}", (object) decimal_73);
  }

  public static string smethod_52(double double_32)
  {
    if (double_32 > 0.5 || double_32 < -5.0)
      return string.Format("{0:#,0.00}", (object) double_32);
    if (double_32 > 0.05 || double_32 < -0.05)
      return string.Format("{0:#,0.00#}", (object) double_32);
    if (double_32 > 0.005 || double_32 < -0.005)
      return string.Format("{0:#,0.00##}", (object) double_32);
    return double_32 <= 0.0005 && double_32 >= -0.0005 ? string.Format("{0:#,0.00####}", (object) double_32) : string.Format("{0:#,0.00###}", (object) double_32);
  }

  public static string smethod_53(Decimal decimal_73)
  {
    if (decimal_73 > 50M || decimal_73 < -50M)
      return string.Format("{0:#,0}", (object) decimal_73);
    return !(decimal_73 > 5M) && !(decimal_73 < -5M) ? string.Format("{0:#,0.##}", (object) decimal_73) : string.Format("{0:#,0.#}", (object) decimal_73);
  }

  public static string smethod_54(double double_32)
  {
    if (double_32 > 50.0 || double_32 < -50.0)
      return string.Format("{0:#,0}", (object) double_32);
    return double_32 <= 5.0 && double_32 >= -5.0 ? string.Format("{0:#,0.##}", (object) double_32) : string.Format("{0:#,0.#}", (object) double_32);
  }

  public static string smethod_55(string string_2, int int_72)
  {
    return string_2.Substring(string_2.Length - int_72);
  }

  public static string smethod_56(Decimal decimal_73)
  {
    try
    {
      return !(decimal_73 < 48M) ? (!(decimal_73 < 600M) ? (!(decimal_73 < 8760M) ? (!(decimal_73 < 35000M) ? (!(decimal_73 < 350000M) ? GClass226.smethod_42(decimal_73 / 8760M, 0) + " years" : GClass226.smethod_42(decimal_73 / 8760M, 1) + " years") : GClass226.smethod_42(decimal_73 / 8760M, 2) + " years") : GClass226.smethod_42(decimal_73 / 24M, 0) + " days") : GClass226.smethod_42(decimal_73 / 24M, 1) + " days") : GClass226.smethod_42(decimal_73, 1) + " hours";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1727);
      return "error";
    }
  }

  public static string smethod_57(double double_32)
  {
    try
    {
      return double_32 >= 48.0 ? (double_32 >= 600.0 ? (double_32 >= 8760.0 ? (double_32 >= 35000.0 ? (double_32 >= 350000.0 ? GClass226.smethod_44(double_32 / 8760.0, 0) + " years" : GClass226.smethod_44(double_32 / 8760.0, 1) + " years") : GClass226.smethod_44(double_32 / 8760.0, 2) + " years") : GClass226.smethod_44(double_32 / 24.0, 0) + " days") : GClass226.smethod_44(double_32 / 24.0, 1) + " days") : GClass226.smethod_44(double_32, 1) + " hours";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1728);
      return "error";
    }
  }

  public static string smethod_58(int int_72, string string_2)
  {
    if (int_72 > 1000000000)
      return $"{GClass226.smethod_42((Decimal) (int_72 / 1000000000), 1)} b {string_2}";
    if (int_72 > 1000000)
      return $"{GClass226.smethod_42((Decimal) (int_72 / 1000000), 1)} m {string_2}";
    return int_72 > 1000 ? $"{GClass226.smethod_37(int_72)} {string_2}" : $"{GClass226.smethod_42((Decimal) int_72, 1)} {string_2}";
  }

  public static string smethod_59(double double_32, string string_2)
  {
    if (double_32 > 1000000000.0)
      return $"{GClass226.smethod_44(double_32 / 1000000000.0, 1)} b {string_2}";
    if (double_32 > 1000000.0)
      return $"{GClass226.smethod_44(double_32 / 1000000.0, 1)} m {string_2}";
    return double_32 > 1000.0 ? $"{GClass226.smethod_43(double_32)} {string_2}" : $"{GClass226.smethod_44(double_32, 1)} {string_2}";
  }

  public static string smethod_60(double double_32)
  {
    return double_32 >= 1000000000.0 ? GClass226.smethod_46(double_32 / 1000000000.0, 2) + " b" : GClass226.smethod_44(double_32 / 1000000.0, 0) + " m";
  }

  public static string smethod_61(Decimal decimal_73, string string_2)
  {
    if (decimal_73 > 10000000000M || decimal_73 < -10000000000M)
      return $"{GClass226.smethod_42(decimal_73 / 1000000000M, 1)} b {string_2}";
    if (decimal_73 > 1000000000M || decimal_73 < -1000000000M)
      return $"{GClass226.smethod_42(decimal_73 / 1000000000M, 2)} b {string_2}";
    if (decimal_73 > 1000000M || decimal_73 < -1000000M)
      return $"{GClass226.smethod_42(decimal_73 / 1000000M, 1)} m {string_2}";
    if (decimal_73 > 1000M || decimal_73 < -1000M)
      return $"{GClass226.smethod_37((int) decimal_73)} {string_2}";
    if (decimal_73 > 10M || decimal_73 < -10M)
      return $"{GClass226.smethod_42(decimal_73, 1)} {string_2}";
    return !(decimal_73 > 0.1M) && !(decimal_73 < -0.1M) ? $"{GClass226.smethod_42(decimal_73, 4)} {string_2}" : $"{GClass226.smethod_42(decimal_73, 2)} {string_2}";
  }

  public static Decimal smethod_62(Decimal decimal_73, double double_32)
  {
    return (Decimal) Math.Pow((double) decimal_73, double_32);
  }

  public static Decimal smethod_63(Decimal decimal_73, Decimal decimal_74)
  {
    return (Decimal) Math.Pow((double) decimal_73, (double) decimal_74);
  }

  public static Decimal smethod_64(Decimal decimal_73, int int_72)
  {
    return (Decimal) Math.Pow((double) decimal_73, (double) int_72);
  }

  public static Decimal smethod_65(int int_72, int int_73)
  {
    return (Decimal) Math.Pow((double) int_72, (double) int_73);
  }

  public static Decimal smethod_66(int int_72, double double_32)
  {
    return (Decimal) Math.Pow((double) int_72, double_32);
  }

  public static int smethod_67(string string_2) => string_2 == "" ? 0 : int.Parse(string_2);

  public static bool smethod_68(int int_72) => int_72 != 0;

  public static int smethod_69(bool bool_0) => bool_0 ? 1 : 0;

  public static string smethod_70(bool bool_0) => bool_0 ? "Yes" : "No";

  public static string smethod_71(int int_72)
  {
    TimeSpan timeSpan = TimeSpan.FromSeconds((double) int_72);
    return $"{timeSpan.Days:D2}:{timeSpan.Hours:D2}:{timeSpan.Minutes:D2}";
  }

  public static DateTime smethod_72(string string_2)
  {
    try
    {
      return new DateTime(Convert.ToInt32(string_2.Substring(0, 4)), Convert.ToInt32(string_2.Substring(5, 2)), Convert.ToInt32(string_2.Substring(8, 2)), Convert.ToInt32(string_2.Substring(11, 2)), Convert.ToInt32(string_2.Substring(14, 2)), Convert.ToInt32(string_2.Substring(17, 2)));
    }
    catch (OleDbException ex)
    {
      GClass226.smethod_78(ex, 1731);
      return DateTime.MinValue;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1732);
      return DateTime.MinValue;
    }
  }

  public static void smethod_73(Exception exception_0)
  {
    int num = (int) MessageBox.Show(exception_0.Message);
  }

  public static void smethod_74(Exception exception_0, int int_72)
  {
    //TODO: This one should be a good place to start tracking down symbol meanings
    int num = (int) MessageBox.Show($"{GClass226.string_0} Function #{int_72.ToString()}: {exception_0.Message}");
  }

  public static void smethod_75(Exception exception_0, int int_72, int int_73)
  {
    int num = (int) MessageBox.Show($"{GClass226.string_0} Function #{int_72.ToString()}, Item #: {exception_0.Message}");
  }

  public static void smethod_76()
  {
  }

  public static void smethod_77(OleDbException oleDbException_0)
  {
    int num = (int) MessageBox.Show(oleDbException_0.Message);
  }

  public static void smethod_78(OleDbException oleDbException_0, int int_72)
  {
    int num = (int) MessageBox.Show($"Function #{int_72.ToString()}: {oleDbException_0.Message}");
  }

  public static string smethod_79(int int_72)
  {
    if (int_72 < 0 || int_72 > 3999)
      throw new ArgumentOutOfRangeException("Value must be between 1 and 3999");
    if (int_72 < 1)
      return string.Empty;
    if (int_72 >= 1000)
      return "M" + GClass226.smethod_79(int_72 - 1000);
    if (int_72 >= 900)
      return "CM" + GClass226.smethod_79(int_72 - 900);
    if (int_72 >= 500)
      return "D" + GClass226.smethod_79(int_72 - 500);
    if (int_72 >= 400)
      return "CD" + GClass226.smethod_79(int_72 - 400);
    if (int_72 >= 100)
      return "C" + GClass226.smethod_79(int_72 - 100);
    if (int_72 >= 90)
      return "XC" + GClass226.smethod_79(int_72 - 90);
    if (int_72 >= 50)
      return "L" + GClass226.smethod_79(int_72 - 50);
    if (int_72 >= 40)
      return "XL" + GClass226.smethod_79(int_72 - 40);
    if (int_72 >= 10)
      return "X" + GClass226.smethod_79(int_72 - 10);
    if (int_72 >= 9)
      return "IX" + GClass226.smethod_79(int_72 - 9);
    if (int_72 >= 5)
      return "V" + GClass226.smethod_79(int_72 - 5);
    if (int_72 >= 4)
      return "IV" + GClass226.smethod_79(int_72 - 4);
    if (int_72 < 1)
      throw new ArgumentOutOfRangeException("Value must be between 1 and 3999");
    return "I" + GClass226.smethod_79(int_72 - 1);
  }

  public static string smethod_80(int int_72)
  {
    if (int_72 <= 0)
      return int_72.ToString();
    switch (int_72 % 100)
    {
      case 11:
      case 12:
      case 13:
        return int_72.ToString() + "th";
      default:
        switch (int_72 % 10)
        {
          case 1:
            return int_72.ToString() + "st";
          case 2:
            return int_72.ToString() + "nd";
          case 3:
            return int_72.ToString() + "rd";
          default:
            return int_72.ToString() + "th";
        }
    }
  }

  public static Color smethod_81(AuroraContactStatus auroraContactStatus_0)
  {
    switch (auroraContactStatus_0)
    {
      case AuroraContactStatus.Hostile:
        return GClass226.color_6;
      case AuroraContactStatus.Neutral:
        return GClass226.color_7;
      case AuroraContactStatus.Friendly:
        return GClass226.color_8;
      case AuroraContactStatus.Allied:
        return GClass226.color_9;
      default:
        return Color.White;
    }
  }

  public static string smethod_82(Enum enum_0)
  {
    try
    {
      MemberInfo[] member = enum_0.GetType().GetMember(enum_0.ToString());
      if (member != null && member.Length != 0)
      {
        object[] customAttributes = member[0].GetCustomAttributes(typeof (DescriptionAttribute), false);
        if (customAttributes != null && customAttributes.Length != 0)
          return ((DescriptionAttribute) customAttributes[0]).Description;
      }
      return enum_0.ToString();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1733);
      return (string) null;
    }
  }

  public static T smethod_83<T>(string string_2)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass226.Class1210<T> class1210 = new GClass226.Class1210<T>();
    // ISSUE: reference to a compiler-generated field
    class1210.string_0 = string_2;
    try
    {
      System.Type type = typeof (T);
      if (!type.IsEnum)
        throw new ArgumentException();
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a compiler-generated type
      Class332<FieldInfo, object> class332 = ((IEnumerable<FieldInfo>) type.GetFields()).SelectMany<FieldInfo, object, Class332<FieldInfo, object>>((Func<FieldInfo, IEnumerable<object>>) (fieldInfo_0 => (IEnumerable<object>) fieldInfo_0.GetCustomAttributes(typeof (DescriptionAttribute), false)), (Func<FieldInfo, object, Class332<FieldInfo, object>>) ((fieldInfo_0, object_0) => new Class332<FieldInfo, object>(fieldInfo_0, object_0))).Where<Class332<FieldInfo, object>>(new Func<Class332<FieldInfo, object>, bool>(class1210.method_0)).SingleOrDefault<Class332<FieldInfo, object>>();
      return class332 == null ? default (T) : (T) class332.Field.GetRawConstantValue();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1734);
      return default (T);
    }
  }
}
