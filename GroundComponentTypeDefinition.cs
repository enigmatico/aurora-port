// Decompiled with JetBrains decompiler
// Type: GClass100
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class GroundComponentTypeDefinition
{
    public TechSystem TechData;
    public GroundUnitComponent GroundUnitComponentType;
    public BombardmentWeaponClass BombardmentWeaponClass;
    public AntiAirWeaponClass AAWeaponClass;
    public int Shots;
    public int int_1;
    public int STO;
    public int HQMaxSize;
    public int FireDirection;
    public int LogisticsPoint;
    public int DisplayOrder;
    public Decimal Size;
    public Decimal Damage;
    public Decimal Penetration;
    public Decimal Construction;
    public Decimal GeoSurvey;
    public Decimal Xenoarchaeology;
    public Decimal SupplyUse;
    public Decimal Decontamination;
    public bool Static;
    public bool Infantry;
    public bool MediumVehicle;
    public bool HeavyVehicle;
    public bool SuperHeavyVehicle;
    public bool UltraHeavyVehicle;
    public bool LightVehicle;
    public bool GroundWeapon;
    public string Abbreviation;

    public string GroundUnitComponentName { get; set; }

    public int method_0(Decimal decimal_8)
    {
        try
        {
            return (int)Math.Floor(Math.Pow((double)this.method_2(decimal_8 / 20M), 2.0));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1736);
            return 0;
        }
    }

    public Decimal method_1(Decimal decimal_8)
    {
        try
        {
            return Math.Round(this.Penetration * decimal_8, 2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1737);
            return 0M;
        }
    }

    public Decimal method_2(Decimal decimal_8)
    {
        try
        {
            return Math.Round(this.Damage * decimal_8, 2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1738);
            return 0M;
        }
    }

    public string method_3(Decimal decimal_8)
    {
        try
        {
            string str = string.Format("{0}:", this.GroundUnitComponentName);
            if (this.Damage > 0M)
            {
                str =
                    string.Format("{0}      Shots {1}      Penetration {2}      Damage {3}", str, this.Shots.ToString(),
                        this.method_1(decimal_8).ToString(), this.method_2(decimal_8).ToString());
                if (this.AAWeaponClass != AntiAirWeaponClass.const_0)
                    str = string.Format("{0}      AA Value {1}", str, this.method_0(decimal_8).ToString());
            }
            else if (this.Construction > 0M)
                str = string.Format("{0}      Construction Factory Equivalent {1}", str,
                    AuroraUtils.FormatNumberToDigits(this.Construction, 2));
            else if (this.LogisticsPoint > 0)
                str = string.Format("{0}      Ground Supply Points {1}", str,
                    AuroraUtils.smethod_37(this.LogisticsPoint));
            else if (this.GeoSurvey > 0M)
                str = string.Format("{0}      Geo Survey Points {1}", str,
                    AuroraUtils.FormatNumberToDigits(this.GeoSurvey, 1));
            else if (this.Xenoarchaeology > 0M)
                str = string.Format("{0}      Xenoarchaeology Points {1}", str,
                    AuroraUtils.FormatNumberToDigits(this.Xenoarchaeology, 1));
            else if (this.Decontamination > 0M)
                str = string.Format("{0}      Decontamination Rate {1}%", str,
                    AuroraUtils.FormatNumberToDigits(this.Decontamination, 1));

            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1739);
            return "error";
        }
    }
}