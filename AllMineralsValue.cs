// Decompiled with JetBrains decompiler
// Type: GClass123
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

#nullable disable
public class AllMineralsValue
{
    public Decimal Duranium;
    public Decimal Neutronium;
    public Decimal Corbomite;
    public Decimal Tritanium;
    public Decimal Boronide;
    public Decimal Mercassium;
    public Decimal Vendarite;
    public Decimal Sorium;
    public Decimal Uridium;
    public Decimal Corundium;
    public Decimal Gallicite;
    private GClass0 gclass0_0;

    public AllMineralsValue(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public int method_0(AllMineralsValue gclass123_0)
    {
        try
        {
            Decimal d = 1000000M;
            if (gclass123_0.Duranium > 0M)
            {
                Decimal num = this.Duranium / gclass123_0.Duranium;
                if (num < d)
                    d = num;
            }

            if (gclass123_0.Neutronium > 0M)
            {
                Decimal num = this.Neutronium / gclass123_0.Neutronium;
                if (num < d)
                    d = num;
            }

            if (gclass123_0.Corbomite > 0M)
            {
                Decimal num = this.Corbomite / gclass123_0.Corbomite;
                if (num < d)
                    d = num;
            }

            if (gclass123_0.Tritanium > 0M)
            {
                Decimal num = this.Tritanium / gclass123_0.Tritanium;
                if (num < d)
                    d = num;
            }

            if (gclass123_0.Boronide > 0M)
            {
                Decimal num = this.Boronide / gclass123_0.Boronide;
                if (num < d)
                    d = num;
            }

            if (gclass123_0.Mercassium > 0M)
            {
                Decimal num = this.Mercassium / gclass123_0.Mercassium;
                if (num < d)
                    d = num;
            }

            if (gclass123_0.Vendarite > 0M)
            {
                Decimal num = this.Vendarite / gclass123_0.Vendarite;
                if (num < d)
                    d = num;
            }

            if (gclass123_0.Sorium > 0M)
            {
                Decimal num = this.Sorium / gclass123_0.Sorium;
                if (num < d)
                    d = num;
            }

            if (gclass123_0.Uridium > 0M)
            {
                Decimal num = this.Uridium / gclass123_0.Uridium;
                if (num < d)
                    d = num;
            }

            if (gclass123_0.Corundium > 0M)
            {
                Decimal num = this.Corundium / gclass123_0.Corundium;
                if (num < d)
                    d = num;
            }

            if (gclass123_0.Gallicite > 0M)
            {
                Decimal num = this.Gallicite / gclass123_0.Gallicite;
                if (num < d)
                    d = num;
            }

            return (int)Math.Floor(d);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1981);
            return 0;
        }
    }

    public bool HasAnyPositiveMineralValue()
    {
        try
        {
            return this.Duranium > 0M || this.Neutronium > 0M || this.Corbomite > 0M || this.Tritanium > 0M ||
                   this.Boronide > 0M || this.Mercassium > 0M || this.Vendarite > 0M || this.Sorium > 0M ||
                   this.Uridium > 0M || this.Corundium > 0M || this.Gallicite > 0M;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1982);
            return false;
        }
    }

    public bool HasAnyNonZeroMineralValue()
    {
        try
        {
            return this.Duranium > 0M || this.Duranium < 0M || this.Neutronium > 0M || this.Neutronium < 0M ||
                   this.Corbomite > 0M || this.Corbomite < 0M || this.Tritanium > 0M || this.Tritanium < 0M ||
                   this.Boronide > 0M || this.Boronide < 0M || this.Mercassium > 0M || this.Mercassium < 0M ||
                   this.Vendarite > 0M || this.Vendarite < 0M || this.Sorium > 0M || this.Sorium < 0M ||
                   this.Uridium > 0M || this.Uridium < 0M || this.Corundium > 0M || this.Corundium < 0M ||
                   this.Gallicite > 0M || this.Gallicite < 0M;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1983);
            return false;
        }
    }

    public void method_3(int int_0)
    {
        try
        {
            this.Duranium = int_0 * AuroraUtils.decimal_9;
            this.Uridium = int_0 * AuroraUtils.decimal_10;
            this.Gallicite = int_0 * AuroraUtils.decimal_11;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1984);
        }
    }

    public List<SingleMineralValue> GetAsSingleMineralValueList()
    {
        try
        {
            List<SingleMineralValue> gclass125List = new List<SingleMineralValue>();
            if (this.Duranium > 0M)
                gclass125List.Add(new SingleMineralValue()
                {
                    decimal_0 = this.Duranium,
                    auroraElement_0 = AuroraElement.Duranium
                });
            if (this.Neutronium > 0M)
                gclass125List.Add(new SingleMineralValue()
                {
                    decimal_0 = this.Neutronium,
                    auroraElement_0 = AuroraElement.Neutronium
                });
            if (this.Corbomite > 0M)
                gclass125List.Add(new SingleMineralValue()
                {
                    decimal_0 = this.Corbomite,
                    auroraElement_0 = AuroraElement.Corbomite
                });
            if (this.Tritanium > 0M)
                gclass125List.Add(new SingleMineralValue()
                {
                    decimal_0 = this.Tritanium,
                    auroraElement_0 = AuroraElement.Tritanium
                });
            if (this.Boronide > 0M)
                gclass125List.Add(new SingleMineralValue()
                {
                    decimal_0 = this.Boronide,
                    auroraElement_0 = AuroraElement.Boronide
                });
            if (this.Mercassium > 0M)
                gclass125List.Add(new SingleMineralValue()
                {
                    decimal_0 = this.Mercassium,
                    auroraElement_0 = AuroraElement.Mercassium
                });
            if (this.Vendarite > 0M)
                gclass125List.Add(new SingleMineralValue()
                {
                    decimal_0 = this.Vendarite,
                    auroraElement_0 = AuroraElement.Vendarite
                });
            if (this.Sorium > 0M)
                gclass125List.Add(new SingleMineralValue()
                {
                    decimal_0 = this.Sorium,
                    auroraElement_0 = AuroraElement.Sorium
                });
            if (this.Uridium > 0M)
                gclass125List.Add(new SingleMineralValue()
                {
                    decimal_0 = this.Uridium,
                    auroraElement_0 = AuroraElement.Uridium
                });
            if (this.Corundium > 0M)
                gclass125List.Add(new SingleMineralValue()
                {
                    decimal_0 = this.Corundium,
                    auroraElement_0 = AuroraElement.Corundium
                });
            if (this.Gallicite > 0M)
                gclass125List.Add(new SingleMineralValue()
                {
                    decimal_0 = this.Gallicite,
                    auroraElement_0 = AuroraElement.Gallicite
                });
            return gclass125List;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1985);
            return null;
        }
    }

    public List<AuroraElement> GetListOfPositiveMinerals()
    {
        List<AuroraElement> auroraElementList = new List<AuroraElement>();
        if (this.Duranium > 0M)
            auroraElementList.Add(AuroraElement.Duranium);
        if (this.Neutronium > 0M)
            auroraElementList.Add(AuroraElement.Neutronium);
        if (this.Corbomite > 0M)
            auroraElementList.Add(AuroraElement.Corbomite);
        if (this.Tritanium > 0M)
            auroraElementList.Add(AuroraElement.Tritanium);
        if (this.Boronide > 0M)
            auroraElementList.Add(AuroraElement.Boronide);
        if (this.Mercassium > 0M)
            auroraElementList.Add(AuroraElement.Mercassium);
        if (this.Vendarite > 0M)
            auroraElementList.Add(AuroraElement.Vendarite);
        if (this.Sorium > 0M)
            auroraElementList.Add(AuroraElement.Sorium);
        if (this.Uridium > 0M)
            auroraElementList.Add(AuroraElement.Uridium);
        if (this.Corundium > 0M)
            auroraElementList.Add(AuroraElement.Corundium);
        if (this.Gallicite > 0M)
            auroraElementList.Add(AuroraElement.Gallicite);
        return auroraElementList;
    }

    public void ResetToZero()
    {
        this.Duranium = 0M;
        this.Neutronium = 0M;
        this.Corbomite = 0M;
        this.Tritanium = 0M;
        this.Boronide = 0M;
        this.Mercassium = 0M;
        this.Vendarite = 0M;
        this.Sorium = 0M;
        this.Uridium = 0M;
        this.Corundium = 0M;
        this.Gallicite = 0M;
    }

    public Decimal GetTotalAmount()
    {
        return this.Duranium + this.Neutronium + this.Corbomite + this.Tritanium + this.Boronide + this.Mercassium +
               this.Vendarite + this.Sorium + this.Uridium + this.Corundium + this.Gallicite;
    }

    public void method_8(IndustrialProjects gclass156_0)
    {
        this.Duranium += gclass156_0.MineralCost.Duranium * gclass156_0.Amount;
        this.Neutronium += gclass156_0.MineralCost.Neutronium * gclass156_0.Amount;
        this.Corbomite += gclass156_0.MineralCost.Corbomite * gclass156_0.Amount;
        this.Tritanium += gclass156_0.MineralCost.Tritanium * gclass156_0.Amount;
        this.Boronide += gclass156_0.MineralCost.Boronide * gclass156_0.Amount;
        this.Mercassium += gclass156_0.MineralCost.Mercassium * gclass156_0.Amount;
        this.Vendarite += gclass156_0.MineralCost.Vendarite * gclass156_0.Amount;
        this.Sorium += gclass156_0.MineralCost.Sorium * gclass156_0.Amount;
        this.Uridium += gclass156_0.MineralCost.Uridium * gclass156_0.Amount;
        this.Corundium += gclass156_0.MineralCost.Corundium * gclass156_0.Amount;
        this.Gallicite += gclass156_0.MineralCost.Gallicite * gclass156_0.Amount;
    }

    public void method_9(GClass192 gclass192_0)
    {
        try
        {
            if (gclass192_0 == null || gclass192_0.gclass123_0 == null)
                return;
            this.Duranium += gclass192_0.gclass123_0.Duranium * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
            this.Neutronium += gclass192_0.gclass123_0.Neutronium * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
            this.Corbomite += gclass192_0.gclass123_0.Corbomite * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
            this.Tritanium += gclass192_0.gclass123_0.Tritanium * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
            this.Boronide += gclass192_0.gclass123_0.Boronide * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
            this.Mercassium += gclass192_0.gclass123_0.Mercassium * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
            this.Vendarite += gclass192_0.gclass123_0.Vendarite * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
            this.Sorium += gclass192_0.gclass123_0.Sorium * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
            this.Uridium += gclass192_0.gclass123_0.Uridium * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
            this.Corundium += gclass192_0.gclass123_0.Corundium * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
            this.Gallicite += gclass192_0.gclass123_0.Gallicite *
                               (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1986);
        }
    }

    public void AddMineralsFrom(AllMineralsValue gclass123_0)
    {
        try
        {
            this.Duranium += gclass123_0.Duranium;
            this.Neutronium += gclass123_0.Neutronium;
            this.Corbomite += gclass123_0.Corbomite;
            this.Tritanium += gclass123_0.Tritanium;
            this.Boronide += gclass123_0.Boronide;
            this.Mercassium += gclass123_0.Mercassium;
            this.Vendarite += gclass123_0.Vendarite;
            this.Sorium += gclass123_0.Sorium;
            this.Uridium += gclass123_0.Uridium;
            this.Corundium += gclass123_0.Corundium;
            this.Gallicite += gclass123_0.Gallicite;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1987);
        }
    }

    public void method_11(AllMineralsValue gclass123_0, Decimal decimal_11)
    {
        try
        {
            this.Duranium += gclass123_0.Duranium * decimal_11;
            this.Neutronium += gclass123_0.Neutronium * decimal_11;
            this.Corbomite += gclass123_0.Corbomite * decimal_11;
            this.Tritanium += gclass123_0.Tritanium * decimal_11;
            this.Boronide += gclass123_0.Boronide * decimal_11;
            this.Mercassium += gclass123_0.Mercassium * decimal_11;
            this.Vendarite += gclass123_0.Vendarite * decimal_11;
            this.Sorium += gclass123_0.Sorium * decimal_11;
            this.Uridium += gclass123_0.Uridium * decimal_11;
            this.Corundium += gclass123_0.Corundium * decimal_11;
            this.Gallicite += gclass123_0.Gallicite * decimal_11;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1988);
        }
    }

    public void Multiply(Decimal decimal_11)
    {
        try
        {
            this.Duranium *= decimal_11;
            this.Neutronium *= decimal_11;
            this.Corbomite *= decimal_11;
            this.Tritanium *= decimal_11;
            this.Boronide *= decimal_11;
            this.Mercassium *= decimal_11;
            this.Vendarite *= decimal_11;
            this.Sorium *= decimal_11;
            this.Uridium *= decimal_11;
            this.Corundium *= decimal_11;
            this.Gallicite *= decimal_11;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1989);
        }
    }

    // TODO: Probably Wreck/scrap mineral generation (0~50% cost of minerals)
    public void method_13(ShipClass gclass22_0)
    {
        try
        {
            this.Duranium = gclass22_0.ClassMaterials.Duranium * AuroraUtils.GetRandomInteger(5) / 10M;
            this.Neutronium = gclass22_0.ClassMaterials.Neutronium * AuroraUtils.GetRandomInteger(5) / 10M;
            this.Corbomite = gclass22_0.ClassMaterials.Corbomite * AuroraUtils.GetRandomInteger(5) / 10M;
            this.Tritanium = gclass22_0.ClassMaterials.Tritanium * AuroraUtils.GetRandomInteger(5) / 10M;
            this.Boronide = gclass22_0.ClassMaterials.Boronide * AuroraUtils.GetRandomInteger(5) / 10M;
            this.Mercassium = gclass22_0.ClassMaterials.Mercassium * AuroraUtils.GetRandomInteger(5) / 10M;
            this.Vendarite = gclass22_0.ClassMaterials.Vendarite * AuroraUtils.GetRandomInteger(5) / 10M;
            this.Sorium = gclass22_0.ClassMaterials.Sorium * AuroraUtils.GetRandomInteger(5) / 10M;
            this.Uridium = gclass22_0.ClassMaterials.Uridium * AuroraUtils.GetRandomInteger(5) / 10M;
            this.Corundium = gclass22_0.ClassMaterials.Corundium * AuroraUtils.GetRandomInteger(5) / 10M;
            this.Gallicite = gclass22_0.ClassMaterials.Gallicite * AuroraUtils.GetRandomInteger(5) / 10M;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1990);
        }
    }

    public Decimal GetValueOfElement(AuroraElement auroraElement_0)
    {
        try
        {
            switch (auroraElement_0)
            {
                case AuroraElement.Duranium:
                    return this.Duranium;
                case AuroraElement.Neutronium:
                    return this.Neutronium;
                case AuroraElement.Corbomite:
                    return this.Corbomite;
                case AuroraElement.Tritanium:
                    return this.Tritanium;
                case AuroraElement.Boronide:
                    return this.Boronide;
                case AuroraElement.Mercassium:
                    return this.Mercassium;
                case AuroraElement.Vendarite:
                    return this.Vendarite;
                case AuroraElement.Sorium:
                    return this.Sorium;
                case AuroraElement.Uridium:
                    return this.Uridium;
                case AuroraElement.Corundium:
                    return this.Corundium;
                case AuroraElement.Gallicite:
                    return this.Gallicite;
                default:
                    return 0M;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1991);
            return 0M;
        }
    }

    public Decimal SetValueToElement(AuroraElement auroraElement_0, Decimal decimal_11)
    {
        try
        {
            switch (auroraElement_0)
            {
                case AuroraElement.Duranium:
                    this.Duranium = decimal_11;
                    break;
                case AuroraElement.Neutronium:
                    this.Neutronium = decimal_11;
                    break;
                case AuroraElement.Corbomite:
                    this.Corbomite = decimal_11;
                    break;
                case AuroraElement.Tritanium:
                    this.Tritanium = decimal_11;
                    break;
                case AuroraElement.Boronide:
                    this.Boronide = decimal_11;
                    break;
                case AuroraElement.Mercassium:
                    this.Mercassium = decimal_11;
                    break;
                case AuroraElement.Vendarite:
                    this.Vendarite = decimal_11;
                    break;
                case AuroraElement.Sorium:
                    this.Sorium = decimal_11;
                    break;
                case AuroraElement.Uridium:
                    this.Uridium = decimal_11;
                    break;
                case AuroraElement.Corundium:
                    this.Corundium = decimal_11;
                    break;
                case AuroraElement.Gallicite:
                    this.Gallicite = decimal_11;
                    break;
            }

            return 0M;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1992);
            return 0M;
        }
    }

    public string GetElementValueFormattedString(AuroraElement auroraElement_0, int fractionDigits)
    {
        try
        {
            switch (auroraElement_0)
            {
                case AuroraElement.Duranium:
                    return this.Duranium == 0M ? "-" : AuroraUtils.FormatNumberToDigits(this.Duranium, fractionDigits);
                case AuroraElement.Neutronium:
                    return this.Neutronium == 0M ? "-" : AuroraUtils.FormatNumberToDigits(this.Neutronium, fractionDigits);
                case AuroraElement.Corbomite:
                    return this.Corbomite == 0M ? "-" : AuroraUtils.FormatNumberToDigits(this.Corbomite, fractionDigits);
                case AuroraElement.Tritanium:
                    return this.Tritanium == 0M ? "-" : AuroraUtils.FormatNumberToDigits(this.Tritanium, fractionDigits);
                case AuroraElement.Boronide:
                    return this.Boronide == 0M ? "-" : AuroraUtils.FormatNumberToDigits(this.Boronide, fractionDigits);
                case AuroraElement.Mercassium:
                    return this.Mercassium == 0M ? "-" : AuroraUtils.FormatNumberToDigits(this.Mercassium, fractionDigits);
                case AuroraElement.Vendarite:
                    return this.Vendarite == 0M ? "-" : AuroraUtils.FormatNumberToDigits(this.Vendarite, fractionDigits);
                case AuroraElement.Sorium:
                    return this.Sorium == 0M ? "-" : AuroraUtils.FormatNumberToDigits(this.Sorium, fractionDigits);
                case AuroraElement.Uridium:
                    return this.Uridium == 0M ? "-" : AuroraUtils.FormatNumberToDigits(this.Uridium, fractionDigits);
                case AuroraElement.Corundium:
                    return this.Corundium == 0M ? "-" : AuroraUtils.FormatNumberToDigits(this.Corundium, fractionDigits);
                case AuroraElement.Gallicite:
                    return this.Gallicite == 0M ? "-" : AuroraUtils.FormatNumberToDigits(this.Gallicite, fractionDigits);
                default:
                    return "-";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1993);
            return "-";
        }
    }

    public Decimal DetectShortage(IndustrialProjects gclass156_0, Decimal decimal_11)
    {
        try
        {
            string str = "";
            if (gclass156_0.MineralCost.Duranium > 0M &&
                this.Duranium < gclass156_0.MineralCost.Duranium * decimal_11)
            {
                decimal_11 = this.Duranium / gclass156_0.MineralCost.Duranium;
                str = "Duranium";
            }

            if (gclass156_0.MineralCost.Neutronium > 0M &&
                this.Neutronium < gclass156_0.MineralCost.Neutronium * decimal_11)
            {
                decimal_11 = this.Neutronium / gclass156_0.MineralCost.Neutronium;
                str = "Neutronium";
            }

            if (gclass156_0.MineralCost.Corbomite > 0M &&
                this.Corbomite < gclass156_0.MineralCost.Corbomite * decimal_11)
            {
                decimal_11 = this.Corbomite / gclass156_0.MineralCost.Corbomite;
                str = "Corbomite";
            }

            if (gclass156_0.MineralCost.Tritanium > 0M &&
                this.Tritanium < gclass156_0.MineralCost.Tritanium * decimal_11)
            {
                decimal_11 = this.Tritanium / gclass156_0.MineralCost.Tritanium;
                str = "Tritanium";
            }

            if (gclass156_0.MineralCost.Boronide > 0M &&
                this.Boronide < gclass156_0.MineralCost.Boronide * decimal_11)
            {
                decimal_11 = this.Boronide / gclass156_0.MineralCost.Boronide;
                str = "Boronide";
            }

            if (gclass156_0.MineralCost.Mercassium > 0M &&
                this.Mercassium < gclass156_0.MineralCost.Mercassium * decimal_11)
            {
                decimal_11 = this.Mercassium / gclass156_0.MineralCost.Mercassium;
                str = "Mercassium";
            }

            if (gclass156_0.MineralCost.Vendarite > 0M &&
                this.Vendarite < gclass156_0.MineralCost.Vendarite * decimal_11)
            {
                decimal_11 = this.Vendarite / gclass156_0.MineralCost.Vendarite;
                str = "Vendarite";
            }

            if (gclass156_0.MineralCost.Sorium > 0M &&
                this.Sorium < gclass156_0.MineralCost.Sorium * decimal_11)
            {
                decimal_11 = this.Sorium / gclass156_0.MineralCost.Sorium;
                str = "Sorium";
            }

            if (gclass156_0.MineralCost.Uridium > 0M &&
                this.Uridium < gclass156_0.MineralCost.Uridium * decimal_11)
            {
                decimal_11 = this.Uridium / gclass156_0.MineralCost.Uridium;
                str = "Uridium";
            }

            if (gclass156_0.MineralCost.Corundium > 0M &&
                this.Corundium < gclass156_0.MineralCost.Corundium * decimal_11)
            {
                decimal_11 = this.Corundium / gclass156_0.MineralCost.Corundium;
                str = "Corundium";
            }

            if (gclass156_0.MineralCost.Gallicite > 0M &&
                this.Gallicite < gclass156_0.MineralCost.Gallicite * decimal_11)
            {
                decimal_11 = this.Gallicite / gclass156_0.MineralCost.Gallicite;
                str = "Gallicite";
            }

            if (str != "")
                this.gclass0_0.gclass92_0.method_3(EventType.const_41,
                    $"Shortage of {str} in Production of {gclass156_0.Description} at {gclass156_0.Population.PopName}",
                    gclass156_0.Race, gclass156_0.Population.SystemBodyData.SystemData, gclass156_0.Population,
                    gclass156_0.Population.method_87(), gclass156_0.Population.method_88(),
                    AuroraEventCategory.PopProduction);
            return Math.Round(decimal_11, 4);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1994);
            return 0M;
        }
    }

    public Decimal method_18(GClass192 gclass192_0, Decimal decimal_11)
    {
        try
        {
            if (gclass192_0 == null)
                return 0M;
            string str = "";
            if (gclass192_0.gclass123_0.Duranium > 0M &&
                this.Duranium < gclass192_0.gclass123_0.Duranium * decimal_11)
            {
                decimal_11 = this.Duranium / gclass192_0.gclass123_0.Duranium;
                str = "Duranium";
            }

            if (gclass192_0.gclass123_0.Neutronium > 0M &&
                this.Neutronium < gclass192_0.gclass123_0.Neutronium * decimal_11)
            {
                decimal_11 = this.Neutronium / gclass192_0.gclass123_0.Neutronium;
                str = "Neutronium";
            }

            if (gclass192_0.gclass123_0.Corbomite > 0M &&
                this.Corbomite < gclass192_0.gclass123_0.Corbomite * decimal_11)
            {
                decimal_11 = this.Corbomite / gclass192_0.gclass123_0.Corbomite;
                str = "Corbomite";
            }

            if (gclass192_0.gclass123_0.Tritanium > 0M &&
                this.Tritanium < gclass192_0.gclass123_0.Tritanium * decimal_11)
            {
                decimal_11 = this.Tritanium / gclass192_0.gclass123_0.Tritanium;
                str = "Tritanium";
            }

            if (gclass192_0.gclass123_0.Boronide > 0M &&
                this.Boronide < gclass192_0.gclass123_0.Boronide * decimal_11)
            {
                decimal_11 = this.Boronide / gclass192_0.gclass123_0.Boronide;
                str = "Boronide";
            }

            if (gclass192_0.gclass123_0.Mercassium > 0M &&
                this.Mercassium < gclass192_0.gclass123_0.Mercassium * decimal_11)
            {
                decimal_11 = this.Mercassium / gclass192_0.gclass123_0.Mercassium;
                str = "Mercassium";
            }

            if (gclass192_0.gclass123_0.Vendarite > 0M &&
                this.Vendarite < gclass192_0.gclass123_0.Vendarite * decimal_11)
            {
                decimal_11 = this.Vendarite / gclass192_0.gclass123_0.Vendarite;
                str = "Vendarite";
            }

            if (gclass192_0.gclass123_0.Sorium > 0M &&
                this.Sorium < gclass192_0.gclass123_0.Sorium * decimal_11)
            {
                decimal_11 = this.Sorium / gclass192_0.gclass123_0.Sorium;
                str = "Sorium";
            }

            if (gclass192_0.gclass123_0.Uridium > 0M &&
                this.Uridium < gclass192_0.gclass123_0.Uridium * decimal_11)
            {
                decimal_11 = this.Uridium / gclass192_0.gclass123_0.Uridium;
                str = "Uridium";
            }

            if (gclass192_0.gclass123_0.Corundium > 0M &&
                this.Corundium < gclass192_0.gclass123_0.Corundium * decimal_11)
            {
                decimal_11 = this.Corundium / gclass192_0.gclass123_0.Corundium;
                str = "Corundium";
            }

            if (gclass192_0.gclass123_0.Gallicite > 0M &&
                this.Gallicite < gclass192_0.gclass123_0.Gallicite * decimal_11)
            {
                decimal_11 = this.Gallicite / gclass192_0.gclass123_0.Gallicite;
                str = "Gallicite";
            }

            if (str != "")
                this.gclass0_0.gclass92_0.method_3(EventType.const_41,
                    $"Shortage of {str} in shipyard task: {gclass192_0.method_0()} at {gclass192_0.gclass146_0.PopName}",
                    gclass192_0.gclass21_0, gclass192_0.gclass146_0.SystemBodyData.SystemData, gclass192_0.gclass146_0,
                    gclass192_0.gclass146_0.method_87(), gclass192_0.gclass146_0.method_88(),
                    AuroraEventCategory.PopShipbuiding);
            return decimal_11;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1995);
            return 0M;
        }
    }

    public Decimal method_19(GClass106 gclass106_0, AllMineralsValue gclass123_0, Decimal decimal_11)
    {
        try
        {
            string str = "";
            if (gclass123_0.Duranium > 0M && this.Duranium < gclass123_0.Duranium * decimal_11)
            {
                decimal_11 = this.Duranium / gclass123_0.Duranium;
                str = "Duranium";
            }

            if (gclass123_0.Neutronium > 0M && this.Neutronium < gclass123_0.Neutronium * decimal_11)
            {
                decimal_11 = this.Neutronium / gclass123_0.Neutronium;
                str = "Neutronium";
            }

            if (gclass123_0.Corbomite > 0M && this.Corbomite < gclass123_0.Corbomite * decimal_11)
            {
                decimal_11 = this.Corbomite / gclass123_0.Corbomite;
                str = "Corbomite";
            }

            if (gclass123_0.Tritanium > 0M && this.Tritanium < gclass123_0.Tritanium * decimal_11)
            {
                decimal_11 = this.Tritanium / gclass123_0.Tritanium;
                str = "Tritanium";
            }

            if (gclass123_0.Boronide > 0M && this.Boronide < gclass123_0.Boronide * decimal_11)
            {
                decimal_11 = this.Boronide / gclass123_0.Boronide;
                str = "Boronide";
            }

            if (gclass123_0.Mercassium > 0M && this.Mercassium < gclass123_0.Mercassium * decimal_11)
            {
                decimal_11 = this.Mercassium / gclass123_0.Mercassium;
                str = "Mercassium";
            }

            if (gclass123_0.Vendarite > 0M && this.Vendarite < gclass123_0.Vendarite * decimal_11)
            {
                decimal_11 = this.Vendarite / gclass123_0.Vendarite;
                str = "Vendarite";
            }

            if (gclass123_0.Sorium > 0M && this.Sorium < gclass123_0.Sorium * decimal_11)
            {
                decimal_11 = this.Sorium / gclass123_0.Sorium;
                str = "Sorium";
            }

            if (gclass123_0.Uridium > 0M && this.Uridium < gclass123_0.Uridium * decimal_11)
            {
                decimal_11 = this.Uridium / gclass123_0.Uridium;
                str = "Uridium";
            }

            if (gclass123_0.Corundium > 0M && this.Corundium < gclass123_0.Corundium * decimal_11)
            {
                decimal_11 = this.Corundium / gclass123_0.Corundium;
                str = "Corundium";
            }

            if (gclass123_0.Gallicite > 0M && this.Gallicite < gclass123_0.Gallicite * decimal_11)
            {
                decimal_11 = this.Gallicite / gclass123_0.Gallicite;
                str = "Gallicite";
            }

            if (str != "")
                this.gclass0_0.gclass92_0.method_3(EventType.const_41,
                    $"Shortage of {str} in ground formation training task for {gclass106_0.string_0} at {gclass106_0.gclass146_0.PopName}",
                    gclass106_0.gclass21_0, gclass106_0.gclass146_0.SystemBodyData.SystemData, gclass106_0.gclass146_0,
                    gclass106_0.gclass146_0.method_87(), gclass106_0.gclass146_0.method_88(),
                    AuroraEventCategory.PopGroundUnits);
            return decimal_11;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1996);
            return 0M;
        }
    }

    public void method_20(IndustrialProjects gclass156_0, Decimal decimal_11)
    {
        try
        {
            this.Duranium -= gclass156_0.MineralCost.Duranium * decimal_11;
            this.Neutronium -= gclass156_0.MineralCost.Neutronium * decimal_11;
            this.Corbomite -= gclass156_0.MineralCost.Corbomite * decimal_11;
            this.Tritanium -= gclass156_0.MineralCost.Tritanium * decimal_11;
            this.Boronide -= gclass156_0.MineralCost.Boronide * decimal_11;
            this.Mercassium -= gclass156_0.MineralCost.Mercassium * decimal_11;
            this.Vendarite -= gclass156_0.MineralCost.Vendarite * decimal_11;
            this.Sorium -= gclass156_0.MineralCost.Sorium * decimal_11;
            this.Uridium -= gclass156_0.MineralCost.Uridium * decimal_11;
            this.Corundium -= gclass156_0.MineralCost.Corundium * decimal_11;
            this.Gallicite -= gclass156_0.MineralCost.Gallicite * decimal_11;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1997);
        }
    }

    public void method_21(GClass192 gclass192_0, Decimal decimal_11)
    {
        try
        {
            if (gclass192_0 == null)
                return;
            this.Duranium -= gclass192_0.gclass123_0.Duranium * decimal_11;
            this.Neutronium -= gclass192_0.gclass123_0.Neutronium * decimal_11;
            this.Corbomite -= gclass192_0.gclass123_0.Corbomite * decimal_11;
            this.Tritanium -= gclass192_0.gclass123_0.Tritanium * decimal_11;
            this.Boronide -= gclass192_0.gclass123_0.Boronide * decimal_11;
            this.Mercassium -= gclass192_0.gclass123_0.Mercassium * decimal_11;
            this.Vendarite -= gclass192_0.gclass123_0.Vendarite * decimal_11;
            this.Sorium -= gclass192_0.gclass123_0.Sorium * decimal_11;
            this.Uridium -= gclass192_0.gclass123_0.Uridium * decimal_11;
            this.Corundium -= gclass192_0.gclass123_0.Corundium * decimal_11;
            this.Gallicite -= gclass192_0.gclass123_0.Gallicite * decimal_11;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1998);
        }
    }

    public void method_22(AllMineralsValue gclass123_0, Decimal decimal_11)
    {
        try
        {
            this.Duranium -= gclass123_0.Duranium * decimal_11;
            this.Neutronium -= gclass123_0.Neutronium * decimal_11;
            this.Corbomite -= gclass123_0.Corbomite * decimal_11;
            this.Tritanium -= gclass123_0.Tritanium * decimal_11;
            this.Boronide -= gclass123_0.Boronide * decimal_11;
            this.Mercassium -= gclass123_0.Mercassium * decimal_11;
            this.Vendarite -= gclass123_0.Vendarite * decimal_11;
            this.Sorium -= gclass123_0.Sorium * decimal_11;
            this.Uridium -= gclass123_0.Uridium * decimal_11;
            this.Corundium -= gclass123_0.Corundium * decimal_11;
            this.Gallicite -= gclass123_0.Gallicite * decimal_11;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1999);
        }
    }

    public void method_23(PopulationData gclass146_0, MineralUsage genum85_0, Decimal decimal_11)
    {
        try
        {
            gclass146_0.method_21(genum85_0, AuroraElement.Duranium, this.Duranium * decimal_11);
            gclass146_0.method_21(genum85_0, AuroraElement.Neutronium, this.Neutronium * decimal_11);
            gclass146_0.method_21(genum85_0, AuroraElement.Corbomite, this.Corbomite * decimal_11);
            gclass146_0.method_21(genum85_0, AuroraElement.Tritanium, this.Tritanium * decimal_11);
            gclass146_0.method_21(genum85_0, AuroraElement.Boronide, this.Boronide * decimal_11);
            gclass146_0.method_21(genum85_0, AuroraElement.Mercassium, this.Mercassium * decimal_11);
            gclass146_0.method_21(genum85_0, AuroraElement.Vendarite, this.Vendarite * decimal_11);
            gclass146_0.method_21(genum85_0, AuroraElement.Sorium, this.Sorium * decimal_11);
            gclass146_0.method_21(genum85_0, AuroraElement.Uridium, this.Uridium * decimal_11);
            gclass146_0.method_21(genum85_0, AuroraElement.Corundium, this.Corundium * decimal_11);
            gclass146_0.method_21(genum85_0, AuroraElement.Gallicite, this.Gallicite * decimal_11);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3936);
        }
    }

    public void method_24(PopulationData gclass146_0, MineralUsage genum85_0)
    {
        try
        {
            gclass146_0.method_21(genum85_0, AuroraElement.Duranium, this.Duranium);
            gclass146_0.method_21(genum85_0, AuroraElement.Neutronium, this.Neutronium);
            gclass146_0.method_21(genum85_0, AuroraElement.Corbomite, this.Corbomite);
            gclass146_0.method_21(genum85_0, AuroraElement.Tritanium, this.Tritanium);
            gclass146_0.method_21(genum85_0, AuroraElement.Boronide, this.Boronide);
            gclass146_0.method_21(genum85_0, AuroraElement.Mercassium, this.Mercassium);
            gclass146_0.method_21(genum85_0, AuroraElement.Vendarite, this.Vendarite);
            gclass146_0.method_21(genum85_0, AuroraElement.Sorium, this.Sorium);
            gclass146_0.method_21(genum85_0, AuroraElement.Uridium, this.Uridium);
            gclass146_0.method_21(genum85_0, AuroraElement.Corundium, this.Corundium);
            gclass146_0.method_21(genum85_0, AuroraElement.Gallicite, this.Gallicite);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3936);
        }
    }

    public AllMineralsValue method_25()
    {
        try
        {
            AllMineralsValue gclass123 = new AllMineralsValue(this.gclass0_0);
            return (AllMineralsValue)this.MemberwiseClone();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2000);
            return null;
        }
    }

    public AllMineralsValue method_26(Decimal decimal_11)
    {
        try
        {
            return new AllMineralsValue(this.gclass0_0)
            {
                Duranium = this.Duranium * decimal_11,
                Neutronium = this.Neutronium * decimal_11,
                Corbomite = this.Corbomite * decimal_11,
                Tritanium = this.Tritanium * decimal_11,
                Boronide = this.Boronide * decimal_11,
                Mercassium = this.Mercassium * decimal_11,
                Vendarite = this.Vendarite * decimal_11,
                Sorium = this.Sorium * decimal_11,
                Uridium = this.Uridium * decimal_11,
                Corundium = this.Corundium * decimal_11,
                Gallicite = this.Gallicite * decimal_11
            };
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2001);
            return null;
        }
    }

    public void method_27(ListBox listBox_0)
    {
        try
        {
            List<string> stringList1 = new List<string>();
            Decimal num;
            if (this.Duranium > 0M)
            {
                List<string> stringList2 = stringList1;
                num = Math.Round(this.Duranium, 1);
                string str = $"{num}x Duranium";
                stringList2.Add(str);
            }

            if (this.Neutronium > 0M)
            {
                List<string> stringList3 = stringList1;
                num = Math.Round(this.Neutronium, 1);
                string str = $"{num}x Neutronium";
                stringList3.Add(str);
            }

            if (this.Corbomite > 0M)
            {
                List<string> stringList4 = stringList1;
                num = Math.Round(this.Corbomite, 1);
                string str = $"{num}x Corbomite";
                stringList4.Add(str);
            }

            if (this.Tritanium > 0M)
            {
                List<string> stringList5 = stringList1;
                num = Math.Round(this.Tritanium, 1);
                string str = $"{num}x Tritanium";
                stringList5.Add(str);
            }

            if (this.Boronide > 0M)
            {
                List<string> stringList6 = stringList1;
                num = Math.Round(this.Boronide, 1);
                string str = $"{num}x Boronide";
                stringList6.Add(str);
            }

            if (this.Mercassium > 0M)
            {
                List<string> stringList7 = stringList1;
                num = Math.Round(this.Mercassium, 1);
                string str = $"{num}x Mercassium";
                stringList7.Add(str);
            }

            if (this.Vendarite > 0M)
            {
                List<string> stringList8 = stringList1;
                num = Math.Round(this.Vendarite, 1);
                string str = $"{num}x Vendarite";
                stringList8.Add(str);
            }

            if (this.Sorium > 0M)
            {
                List<string> stringList9 = stringList1;
                num = Math.Round(this.Sorium, 1);
                string str = $"{num}x Sorium";
                stringList9.Add(str);
            }

            if (this.Uridium > 0M)
            {
                List<string> stringList10 = stringList1;
                num = Math.Round(this.Uridium, 1);
                string str = $"{num}x Uridium";
                stringList10.Add(str);
            }

            if (this.Corundium > 0M)
            {
                List<string> stringList11 = stringList1;
                num = Math.Round(this.Corundium, 1);
                string str = $"{num}x Corundium";
                stringList11.Add(str);
            }

            if (this.Gallicite > 0M)
            {
                List<string> stringList12 = stringList1;
                num = Math.Round(this.Gallicite, 1);
                string str = $"{num}x Gallicite";
                stringList12.Add(str);
            }

            listBox_0.DataSource = stringList1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2002);
        }
    }

    public void method_28(ListView listView_0) => this.method_29(listView_0, 0);

    public void method_29(ListView listView_0, int int_0)
    {
        try
        {
            this.gclass0_0.method_598(listView_0, "Duranium", AuroraUtils.FormatNumberToDigits(this.Duranium, int_0),
                AuroraElement.Duranium);
            this.gclass0_0.method_598(listView_0, "Neutronium", AuroraUtils.FormatNumberToDigits(this.Neutronium, int_0),
                AuroraElement.Neutronium);
            this.gclass0_0.method_598(listView_0, "Corbomite", AuroraUtils.FormatNumberToDigits(this.Corbomite, int_0),
                AuroraElement.Corbomite);
            this.gclass0_0.method_598(listView_0, "Tritanium", AuroraUtils.FormatNumberToDigits(this.Tritanium, int_0),
                AuroraElement.Tritanium);
            this.gclass0_0.method_598(listView_0, "Boronide", AuroraUtils.FormatNumberToDigits(this.Boronide, int_0),
                AuroraElement.Boronide);
            this.gclass0_0.method_598(listView_0, "Mercassium", AuroraUtils.FormatNumberToDigits(this.Mercassium, int_0),
                AuroraElement.Mercassium);
            this.gclass0_0.method_598(listView_0, "Vendarite", AuroraUtils.FormatNumberToDigits(this.Vendarite, int_0),
                AuroraElement.Vendarite);
            this.gclass0_0.method_598(listView_0, "Sorium", AuroraUtils.FormatNumberToDigits(this.Sorium, int_0),
                AuroraElement.Sorium);
            this.gclass0_0.method_598(listView_0, "Uridium", AuroraUtils.FormatNumberToDigits(this.Uridium, int_0),
                AuroraElement.Uridium);
            this.gclass0_0.method_598(listView_0, "Corundium", AuroraUtils.FormatNumberToDigits(this.Corundium, int_0),
                AuroraElement.Corundium);
            this.gclass0_0.method_598(listView_0, "Gallicite", AuroraUtils.FormatNumberToDigits(this.Gallicite, int_0),
                AuroraElement.Gallicite);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2003);
        }
    }

    public void method_30(ListView listView_0)
    {
        try
        {
            if (this.Duranium > 0M)
                this.gclass0_0.method_598(listView_0, "Duranium", AuroraUtils.smethod_39(this.Duranium),
                    AuroraElement.Duranium);
            if (this.Neutronium > 0M)
                this.gclass0_0.method_598(listView_0, "Neutronium", AuroraUtils.smethod_39(this.Neutronium),
                    AuroraElement.Neutronium);
            if (this.Corbomite > 0M)
                this.gclass0_0.method_598(listView_0, "Corbomite", AuroraUtils.smethod_39(this.Corbomite),
                    AuroraElement.Corbomite);
            if (this.Tritanium > 0M)
                this.gclass0_0.method_598(listView_0, "Tritanium", AuroraUtils.smethod_39(this.Tritanium),
                    AuroraElement.Tritanium);
            if (this.Boronide > 0M)
                this.gclass0_0.method_598(listView_0, "Boronide", AuroraUtils.smethod_39(this.Boronide),
                    AuroraElement.Boronide);
            if (this.Mercassium > 0M)
                this.gclass0_0.method_598(listView_0, "Mercassium", AuroraUtils.smethod_39(this.Mercassium),
                    AuroraElement.Mercassium);
            if (this.Vendarite > 0M)
                this.gclass0_0.method_598(listView_0, "Vendarite", AuroraUtils.smethod_39(this.Vendarite),
                    AuroraElement.Vendarite);
            if (this.Sorium > 0M)
                this.gclass0_0.method_598(listView_0, "Sorium", AuroraUtils.smethod_39(this.Sorium),
                    AuroraElement.Sorium);
            if (this.Uridium > 0M)
                this.gclass0_0.method_598(listView_0, "Uridium", AuroraUtils.smethod_39(this.Uridium),
                    AuroraElement.Uridium);
            if (this.Corundium > 0M)
                this.gclass0_0.method_598(listView_0, "Corundium", AuroraUtils.smethod_39(this.Corundium),
                    AuroraElement.Corundium);
            if (!(this.Gallicite > 0M))
                return;
            this.gclass0_0.method_598(listView_0, "Gallicite", AuroraUtils.smethod_39(this.Gallicite),
                AuroraElement.Gallicite);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2004);
        }
    }

    public void method_31(ListView listView_0, AllMineralsValue gclass123_0)
    {
        this.method_32(listView_0, gclass123_0, 1M);
    }

    public void method_32(ListView listView_0, AllMineralsValue gclass123_0, Decimal decimal_11)
    {
        try
        {
            listView_0.Items.Clear();
            this.gclass0_0.method_601(listView_0, "Resource", "Required", "Available");
            if (this.Duranium > 0M)
                this.gclass0_0.method_601(listView_0, "Duranium", AuroraUtils.smethod_39(this.Duranium * decimal_11),
                    AuroraUtils.smethod_39(gclass123_0.Duranium));
            if (this.Neutronium > 0M)
                this.gclass0_0.method_601(listView_0, "Neutronium", AuroraUtils.smethod_39(this.Neutronium * decimal_11),
                    AuroraUtils.smethod_39(gclass123_0.Neutronium));
            if (this.Corbomite > 0M)
                this.gclass0_0.method_601(listView_0, "Corbomite", AuroraUtils.smethod_39(this.Corbomite * decimal_11),
                    AuroraUtils.smethod_39(gclass123_0.Corbomite));
            if (this.Tritanium > 0M)
                this.gclass0_0.method_601(listView_0, "Tritanium", AuroraUtils.smethod_39(this.Tritanium * decimal_11),
                    AuroraUtils.smethod_39(gclass123_0.Tritanium));
            if (this.Boronide > 0M)
                this.gclass0_0.method_601(listView_0, "Boronide", AuroraUtils.smethod_39(this.Boronide * decimal_11),
                    AuroraUtils.smethod_39(gclass123_0.Boronide));
            if (this.Mercassium > 0M)
                this.gclass0_0.method_601(listView_0, "Mercassium", AuroraUtils.smethod_39(this.Mercassium * decimal_11),
                    AuroraUtils.smethod_39(gclass123_0.Mercassium));
            if (this.Vendarite > 0M)
                this.gclass0_0.method_601(listView_0, "Vendarite", AuroraUtils.smethod_39(this.Vendarite * decimal_11),
                    AuroraUtils.smethod_39(gclass123_0.Vendarite));
            if (this.Sorium > 0M)
                this.gclass0_0.method_601(listView_0, "Sorium", AuroraUtils.smethod_39(this.Sorium * decimal_11),
                    AuroraUtils.smethod_39(gclass123_0.Sorium));
            if (this.Uridium > 0M)
                this.gclass0_0.method_601(listView_0, "Uridium", AuroraUtils.smethod_39(this.Uridium * decimal_11),
                    AuroraUtils.smethod_39(gclass123_0.Uridium));
            if (this.Corundium > 0M)
                this.gclass0_0.method_601(listView_0, "Corundium", AuroraUtils.smethod_39(this.Corundium * decimal_11),
                    AuroraUtils.smethod_39(gclass123_0.Corundium));
            if (!(this.Gallicite > 0M))
                return;
            this.gclass0_0.method_601(listView_0, "Gallicite", AuroraUtils.smethod_39(this.Gallicite * decimal_11),
                AuroraUtils.smethod_39(gclass123_0.Gallicite));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2005);
        }
    }

    public void AddSpecific(AuroraElement auroraElement_0, Decimal decimal_11)
    {
        try
        {
            switch (auroraElement_0)
            {
                case AuroraElement.Duranium:
                    this.Duranium += decimal_11;
                    break;
                case AuroraElement.Neutronium:
                    this.Neutronium += decimal_11;
                    break;
                case AuroraElement.Corbomite:
                    this.Corbomite += decimal_11;
                    break;
                case AuroraElement.Tritanium:
                    this.Tritanium += decimal_11;
                    break;
                case AuroraElement.Boronide:
                    this.Boronide += decimal_11;
                    break;
                case AuroraElement.Mercassium:
                    this.Mercassium += decimal_11;
                    break;
                case AuroraElement.Vendarite:
                    this.Vendarite += decimal_11;
                    break;
                case AuroraElement.Sorium:
                    this.Sorium += decimal_11;
                    break;
                case AuroraElement.Uridium:
                    this.Uridium += decimal_11;
                    break;
                case AuroraElement.Corundium:
                    this.Corundium += decimal_11;
                    break;
                case AuroraElement.Gallicite:
                    this.Gallicite += decimal_11;
                    break;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2006);
        }
    }

    public void method_34(ShipComponent gclass230_0)
    {
        try
        {
            this.Duranium += gclass230_0.gclass123_0.Duranium;
            this.Neutronium += gclass230_0.gclass123_0.Neutronium;
            this.Corbomite += gclass230_0.gclass123_0.Corbomite;
            this.Tritanium += gclass230_0.gclass123_0.Tritanium;
            this.Boronide += gclass230_0.gclass123_0.Boronide;
            this.Mercassium += gclass230_0.gclass123_0.Mercassium;
            this.Vendarite += gclass230_0.gclass123_0.Vendarite;
            this.Sorium += gclass230_0.gclass123_0.Sorium;
            this.Uridium += gclass230_0.gclass123_0.Uridium;
            this.Corundium += gclass230_0.gclass123_0.Corundium;
            this.Gallicite += gclass230_0.gclass123_0.Gallicite;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2007);
        }
    }

    public void method_35(ShipComponent gclass230_0, Decimal decimal_11)
    {
        try
        {
            this.Duranium += gclass230_0.gclass123_0.Duranium * decimal_11;
            this.Neutronium += gclass230_0.gclass123_0.Neutronium * decimal_11;
            this.Corbomite += gclass230_0.gclass123_0.Corbomite * decimal_11;
            this.Tritanium += gclass230_0.gclass123_0.Tritanium * decimal_11;
            this.Boronide += gclass230_0.gclass123_0.Boronide * decimal_11;
            this.Mercassium += gclass230_0.gclass123_0.Mercassium * decimal_11;
            this.Vendarite += gclass230_0.gclass123_0.Vendarite * decimal_11;
            this.Sorium += gclass230_0.gclass123_0.Sorium * decimal_11;
            this.Uridium += gclass230_0.gclass123_0.Uridium * decimal_11;
            this.Corundium += gclass230_0.gclass123_0.Corundium * decimal_11;
            this.Gallicite += gclass230_0.gclass123_0.Gallicite * decimal_11;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2008);
        }
    }

    public string method_36()
    {
        try
        {
            string str = "";
            if (this.Duranium > 0M)
                str = $"{str}Duranium  {AuroraUtils.FormatNumberToDigits(this.Duranium, 2)}    ";
            if (this.Neutronium > 0M)
                str = $"{str}Neutronium  {AuroraUtils.FormatNumberToDigits(this.Neutronium, 2)}    ";
            if (this.Corbomite > 0M)
                str = $"{str}Corbomite  {AuroraUtils.FormatNumberToDigits(this.Corbomite, 2)}    ";
            if (this.Tritanium > 0M)
                str = $"{str}Tritanium  {AuroraUtils.FormatNumberToDigits(this.Tritanium, 2)}    ";
            if (this.Boronide > 0M)
                str = $"{str}Boronide  {AuroraUtils.FormatNumberToDigits(this.Boronide, 2)}    ";
            if (this.Mercassium > 0M)
                str = $"{str}Mercassium  {AuroraUtils.FormatNumberToDigits(this.Mercassium, 2)}    ";
            if (this.Vendarite > 0M)
                str = $"{str}Vendarite  {AuroraUtils.FormatNumberToDigits(this.Vendarite, 2)}    ";
            if (this.Sorium > 0M)
                str = $"{str}Sorium  {AuroraUtils.FormatNumberToDigits(this.Sorium, 2)}    ";
            if (this.Uridium > 0M)
                str = $"{str}Uridium  {AuroraUtils.FormatNumberToDigits(this.Uridium, 2)}    ";
            if (this.Corundium > 0M)
                str = $"{str}Corundium  {AuroraUtils.FormatNumberToDigits(this.Corundium, 2)}    ";
            if (this.Gallicite > 0M)
                str = $"{str}Gallicite  {AuroraUtils.FormatNumberToDigits(this.Gallicite, 2)}    ";
            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2009);
            return "error";
        }
    }

    public string method_37(int int_0)
    {
        try
        {
            string str = "";
            if (this.Duranium > 0M)
                str = $"{str}Duranium  {AuroraUtils.FormatNumberToDigits(this.Duranium, int_0)}   ";
            if (this.Neutronium > 0M)
                str = $"{str}Neutronium  {AuroraUtils.FormatNumberToDigits(this.Neutronium, int_0)}   ";
            if (this.Corbomite > 0M)
                str = $"{str}Corbomite  {AuroraUtils.FormatNumberToDigits(this.Corbomite, int_0)}   ";
            if (this.Tritanium > 0M)
                str = $"{str}Tritanium  {AuroraUtils.FormatNumberToDigits(this.Tritanium, int_0)}   ";
            if (this.Boronide > 0M)
                str = $"{str}Boronide  {AuroraUtils.FormatNumberToDigits(this.Boronide, int_0)}   ";
            if (this.Mercassium > 0M)
                str = $"{str}Mercassium  {AuroraUtils.FormatNumberToDigits(this.Mercassium, int_0)}   ";
            if (this.Vendarite > 0M)
                str = $"{str}Vendarite  {AuroraUtils.FormatNumberToDigits(this.Vendarite, int_0)}   ";
            if (this.Sorium > 0M)
                str = $"{str}Sorium  {AuroraUtils.FormatNumberToDigits(this.Sorium, int_0)}   ";
            if (this.Uridium > 0M)
                str = $"{str}Uridium  {AuroraUtils.FormatNumberToDigits(this.Uridium, int_0)}   ";
            if (this.Corundium > 0M)
                str = $"{str}Corundium  {AuroraUtils.FormatNumberToDigits(this.Corundium, int_0)}   ";
            if (this.Gallicite > 0M)
                str = $"{str}Gallicite  {AuroraUtils.FormatNumberToDigits(this.Gallicite, int_0)}   ";
            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2010);
            return "error";
        }
    }

    public string method_38()
    {
        try
        {
            string str = "";
            if (this.Duranium > 0M)
                str = $"{str}D{AuroraUtils.FormatNumberToDigits(this.Duranium, 0)}  ";
            if (this.Neutronium > 0M)
                str = $"{str}N{AuroraUtils.FormatNumberToDigits(this.Neutronium, 0)}  ";
            if (this.Corbomite > 0M)
                str = $"{str}CB{AuroraUtils.FormatNumberToDigits(this.Corbomite, 0)}  ";
            if (this.Tritanium > 0M)
                str = $"{str}T{AuroraUtils.FormatNumberToDigits(this.Tritanium, 0)}  ";
            if (this.Boronide > 0M)
                str = $"{str}B{AuroraUtils.FormatNumberToDigits(this.Boronide, 0)}  ";
            if (this.Mercassium > 0M)
                str = $"{str}M{AuroraUtils.FormatNumberToDigits(this.Mercassium, 0)}  ";
            if (this.Vendarite > 0M)
                str = $"{str}V{AuroraUtils.FormatNumberToDigits(this.Vendarite, 0)}  ";
            if (this.Sorium > 0M)
                str = $"{str}S{AuroraUtils.FormatNumberToDigits(this.Sorium, 0)}  ";
            if (this.Uridium > 0M)
                str = $"{str}U{AuroraUtils.FormatNumberToDigits(this.Uridium, 0)}  ";
            if (this.Corundium > 0M)
                str = $"{str}CR{AuroraUtils.FormatNumberToDigits(this.Corundium, 0)}  ";
            if (this.Gallicite > 0M)
                str = $"{str}G{AuroraUtils.FormatNumberToDigits(this.Gallicite, 0)}  ";
            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2011);
            return "error";
        }
    }

    public bool method_39(AllMineralsValue gclass123_0)
    {
        try
        {
            return !(this.Duranium < gclass123_0.Duranium) && !(this.Neutronium < gclass123_0.Neutronium) &&
                   !(this.Corbomite < gclass123_0.Corbomite) && !(this.Tritanium < gclass123_0.Tritanium) &&
                   !(this.Boronide < gclass123_0.Boronide) && !(this.Mercassium < gclass123_0.Mercassium) &&
                   !(this.Vendarite < gclass123_0.Vendarite) && !(this.Sorium < gclass123_0.Sorium) &&
                   !(this.Uridium < gclass123_0.Uridium) && !(this.Corundium < gclass123_0.Corundium) &&
                   !(this.Gallicite < gclass123_0.Gallicite);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3855);
            return false;
        }
    }
}