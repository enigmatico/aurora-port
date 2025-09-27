// Decompiled with JetBrains decompiler
// Type: GClass217
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class StellarType
{
    public GClass0 gclass0_0;
    public SystemAgeID AgeRangeID;
    public int StellarTypeID;
    public int SpectralNumber;
    public int MaxChance;
    public int BDMaxChance;
    public int SizeID;
    public int Temperature;
    public int Red;
    public int Green;
    public int Blue;
    public int ExtraJP;
    public double Luminosity;
    public double Mass;
    public double Radius;
    public bool bNotPS;
    public string SpectralClass;
    public string SizeText;
    public int int_10;
    public int int_11;
    public double double_3;
    public double double_4;

    public string StellarDescription { get; set; }

    public StellarType(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public StellarType method_0()
    {
        try
        {
            return (StellarType)this.MemberwiseClone();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3062);
            return null;
        }
    }

    public double method_1() => this.Radius * 1391000.0;

    public double method_2(double double_5, StellarType gclass217_0, double double_6, double double_7)
    {
        try
        {
            if (this.gclass0_0.int_85 == 0)
            {
                this.double_4 = 0.0;
                return double_5;
            }

            int num1 = 0;
            if (double_5 < 0.05)
                num1 = 2;
            else if (double_5 < 5.0)
                num1 = 1;
            int num2 = 0;
            double num3;
            do
            {
                int num4 = AuroraUtils.GetRandomInteger(10) - num1;
                this.double_4 = num4 >= 2
                    ? (num4 >= 3
                        ? (num4 >= 5
                            ? (num4 >= 7
                                ? (num4 >= 10
                                    ? 0.6 + AuroraUtils.GetRandomInteger(10) * 0.03
                                    : 0.4 + AuroraUtils.GetRandomInteger(10) * 0.02)
                                : 0.3 + AuroraUtils.GetRandomInteger(10) * 0.01)
                            : 0.2 + AuroraUtils.GetRandomInteger(10) * 0.01)
                        : 0.1 + AuroraUtils.GetRandomInteger(10) * 0.01)
                    : AuroraUtils.GetRandomInteger(10) * 0.01;
                num3 = double_5 * (1.0 - this.double_4);
                double num5 = double_5 * (1.0 + this.double_4);
                if (num3 <= gclass217_0.Radius * AuroraUtils.double_7 || num3 < double_6 && double_6 != 0.0 ||
                    num5 > double_7 && double_7 != 0.0)
                    ++num2;
                else
                    goto label_9;
            } while (num2 != 10);

            goto label_10;
            label_9:
            return num3;
            label_10:
            this.double_4 = 0.0;
            return double_5;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3436);
            return double_5;
        }
    }
}