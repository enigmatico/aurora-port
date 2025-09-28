// Decompiled with JetBrains decompiler
// Type: GClass101
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#nullable disable
public class GroundUnitClass101
{
    private sealed class Class1038
    {
        public AntiAirWeaponClass genum54_0;

        internal bool method_0(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.AAWeaponClass >= this.genum54_0;
        }
    }


    private sealed class Class1039
    {
        public BombardmentWeaponClass genum53_0;

        internal bool method_0(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.BombardmentWeaponClass >= this.genum53_0;
        }
    }


    private sealed class Class1040
    {
        public BombardmentWeaponClass genum53_0;

        internal bool method_0(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.BombardmentWeaponClass == this.genum53_0;
        }
    }

    private GClass0 gclass0_0;
    public TechSystem TechData;
    public GroundUnitBaseTypeData GroundUnitBaseTypeData;
    public ArmourTypeData ArmourType;
    public ShipComponent SurfaceToOrbitWeapon;
    public AllMineralsValue gclass123_0;
    public List<GroundComponentTypeDefinition> GroundUnitComponentList = new List<GroundComponentTypeDefinition>();
    public Dictionary<GroundUnitCapability, GroundUnitCapabilityDefinition> dictionary_0 = new Dictionary<GroundUnitCapability, GroundUnitCapabilityDefinition>();
    public GroundUnitClassType genum115_0;
    public int ClassID;
    public int int_1;
    public int int_2;
    public int int_3;
    public int int_4;
    public int int_5;
    public int int_6;
    public int int_7;
    public Decimal decimal_0 = 1M;
    public Decimal decimal_1 = 1M;
    public Decimal decimal_2;
    public Decimal decimal_3;
    public Decimal decimal_4;
    public Decimal decimal_5;
    public Decimal decimal_6;
    public bool bool_0;
    public bool bool_1;
    public GroundUnitSeriesClassData gclass95_0;
    public bool bool_2;

    public string ClassName { get; set; }

    public GroundUnitClass101(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public GroundUnitClass101 method_0(GameRace gclass21_0)
    {
        try
        {
            bool flag = false;
            if (this.decimal_1 != gclass21_0.method_220())
            {
                foreach (GroundComponentTypeDefinition gclass100 in this.GroundUnitComponentList)
                {
                    if (gclass100.GroundWeapon)
                    {
                        flag = true;
                        break;
                    }
                }
            }
            else if (this.decimal_0 != gclass21_0.method_386().decimal_3)
                flag = true;

            if (!flag)
                return this;
            GroundComponentTypeDefinition gclass100_0 = null;
            GroundComponentTypeDefinition gclass100_1 = null;
            GroundComponentTypeDefinition gclass100_2 = null;
            GroundComponentTypeDefinition gclass100_3 = null;
            if (this.GroundUnitComponentList.Count > 0)
                gclass100_0 = this.GroundUnitComponentList[0];
            if (this.GroundUnitComponentList.Count > 1)
                gclass100_1 = this.GroundUnitComponentList[1];
            if (this.GroundUnitComponentList.Count > 2)
                gclass100_2 = this.GroundUnitComponentList[2];
            if (this.GroundUnitComponentList.Count > 3)
                gclass100_3 = this.GroundUnitComponentList[3];
            CheckState checkState_3 = CheckState.Unchecked;
            CheckState checkState_5 = CheckState.Unchecked;
            if (this.bool_1)
                checkState_3 = CheckState.Checked;
            if (this.bool_0)
                checkState_5 = CheckState.Checked;
            GroundUnitClass101 gclass101_0 = this.gclass0_0.method_448(gclass21_0, this.GroundUnitBaseTypeData, this.ArmourType, gclass100_0,
                gclass100_1, gclass100_2, gclass100_3, this.SurfaceToOrbitWeapon, this.dictionary_0,
                this.gclass0_0.method_588(this.ClassName), false, checkState_3, CheckState.Checked, checkState_5,
                this.int_6);
            GroundUnitClass101 gclass101_1 = gclass21_0.method_210(gclass101_0);
            if (gclass101_1 == null)
            {
                gclass101_1 = this.gclass0_0.method_448(gclass21_0, this.GroundUnitBaseTypeData, this.ArmourType, gclass100_0,
                    gclass100_1, gclass100_2, gclass100_3, this.SurfaceToOrbitWeapon, this.dictionary_0,
                    this.gclass0_0.method_588(this.ClassName), true, checkState_3, CheckState.Checked, checkState_5,
                    this.int_6);
                if (this.TechData.dictionary_0.ContainsKey(gclass21_0.RaceID))
                    this.TechData.dictionary_0[gclass21_0.RaceID].Obsolete = true;
                if (this.gclass95_0 != null)
                {
                    int int_1 = 1;
                    List<GroundUnitSeriesClassData> list = gclass21_0.GroundUnitSeriesClassList
                        .Where<GroundUnitSeriesClassData>(gclass95_1 => gclass95_1.UnitSeriesData == this.gclass95_0.UnitSeriesData)
                        .ToList<GroundUnitSeriesClassData>();
                    if (list.Count > 0)
                        int_1 = list.Max<GroundUnitSeriesClassData>(gclass95_0 => gclass95_0.Priority) + 1;
                    GroundUnitSeriesClassData gclass95 = new GroundUnitSeriesClassData(this.gclass95_0.UnitSeriesData, gclass101_1, int_1);
                    gclass21_0.GroundUnitSeriesClassList.Add(gclass95);
                }
                else
                {
                    GroundUnitSeriesData gclass94_1 = new GroundUnitSeriesData();
                    gclass94_1.GroundUnitSeriesID = this.gclass0_0.method_26(GEnum0.const_50);
                    gclass94_1.Description = string.Format("{0} Series", this.ClassName);
                    gclass21_0.GroundUnitSeriesDictionary.Add(gclass94_1.GroundUnitSeriesID, gclass94_1);
                    GroundUnitSeriesClassData gclass95_1 = new GroundUnitSeriesClassData(gclass94_1, this, 1);
                    gclass21_0.GroundUnitSeriesClassList.Add(gclass95_1);
                    GroundUnitSeriesClassData gclass95_2 = new GroundUnitSeriesClassData(gclass94_1, gclass101_1, 2);
                    gclass21_0.GroundUnitSeriesClassList.Add(gclass95_2);
                }
            }

            return gclass101_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3593);
            return null;
        }
    }

    public int method_1()
    {
        try
        {
            return this.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.LogisticsPoint);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1740);
            return 0;
        }
    }

    public bool method_2()
    {
        try
        {
            return this.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Damage) > 0M;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1741);
            return false;
        }
    }

    public bool method_3(AntiAirWeaponClass genum54_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GroundUnitClass101.Class1038 class1038 = new GroundUnitClass101.Class1038();
        // ISSUE: reference to a compiler-generated field
        class1038.genum54_0 = genum54_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            return this.GroundUnitComponentList.Where<GroundComponentTypeDefinition>(class1038.method_0).Count<GroundComponentTypeDefinition>() > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1742);
            return false;
        }
    }

    public bool method_4(BombardmentWeaponClass genum53_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GroundUnitClass101.Class1039 class1039 = new GroundUnitClass101.Class1039();
        // ISSUE: reference to a compiler-generated field
        class1039.genum53_0 = genum53_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            return this.GroundUnitComponentList.Where<GroundComponentTypeDefinition>(class1039.method_0).Count<GroundComponentTypeDefinition>() > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1743);
            return false;
        }
    }

    public bool method_5(BombardmentWeaponClass genum53_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GroundUnitClass101.Class1040 class1040 = new GroundUnitClass101.Class1040();
        // ISSUE: reference to a compiler-generated field
        class1040.genum53_0 = genum53_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            return this.GroundUnitComponentList.Where<GroundComponentTypeDefinition>(class1040.method_0).Count<GroundComponentTypeDefinition>() > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1744);
            return false;
        }
    }

    public int method_6()
    {
        try
        {
            return this.GroundUnitComponentList.Max<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.HQMaxSize);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1745);
            return 0;
        }
    }

    public Decimal method_7()
    {
        try
        {
            return Math.Round(this.ArmourType.decimal_0 * this.decimal_0, 1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1746);
            return 0M;
        }
    }

    public Decimal method_8()
    {
        try
        {
            Decimal num = Math.Round(this.GroundUnitBaseTypeData.int_0 * this.decimal_0, 1);
            if (this.GroundUnitBaseTypeData.genum112_0 != GroundUnitBaseType.const_0)
                return num;
            GroundUnitCapabilityDefinition gclass98 = this.dictionary_0.Values.Where<GroundUnitCapabilityDefinition>(gclass98_0 => gclass98_0.HPEnhancement > 0M)
                .OrderByDescending<GroundUnitCapabilityDefinition, Decimal>(gclass98_0 => gclass98_0.HPEnhancement).FirstOrDefault<GroundUnitCapabilityDefinition>();
            return gclass98 == null ? num : num * gclass98.HPEnhancement;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1747);
            return 0M;
        }
    }

    public void PrintOutGroundUnitDesignedSpec(TextBox textBox_0, bool bool_3, bool bool_4)
    {
        try
        {
            var sb = new StringBuilder();

            // Conditionally add the class name header
            if (bool_3)
            {
                sb.AppendLine(this.ClassName);
            }

            // First block of stats
            Decimal armorValue = this.method_7();
            Decimal hitPoints = this.method_8();
            
            sb.AppendLine(string.Format("Transport Size (tons) {0}     Cost {1}     Armour {2}     Hit Points {3}",
                AuroraUtils.FormatNumberToDigits(this.decimal_2, 1),
                AuroraUtils.FormatNumberToDigits(this.decimal_3, 3), armorValue, hitPoints));
            sb.AppendLine(string.Format("Annual Maintenance Cost {0}     Resupply Cost {1}",
                AuroraUtils.smethod_47(this.decimal_3 * AuroraUtils.decimal_47),
                AuroraUtils.smethod_47(this.decimal_4)));

            // Loop through each component and add its specific details
            foreach (GroundComponentTypeDefinition gclass100 in this.GroundUnitComponentList)
            {
                if (gclass100.GroundUnitComponentType == GroundUnitComponent.SurfaceToOrbit && this.SurfaceToOrbitWeapon != null)
                {
                    // Handle the complex 'const_22' type component
                    sb.AppendLine(); // Add a blank line separator
                    sb.AppendLine(this.SurfaceToOrbitWeapon.Name);

                    int damagePerShot = this.SurfaceToOrbitWeapon.method_5(this.int_1);
                    int rateOfFire = this.SurfaceToOrbitWeapon.method_3();
                    
                    sb.AppendLine(string.Format(
                        "Range {0} km      Tracking {1} km/s      Damage {2} / {3}     Shots {4}     Rate of Fire {5}",
                        AuroraUtils.smethod_37(this.int_1), AuroraUtils.smethod_37(this.int_4),
                        this.SurfaceToOrbitWeapon.int_6, damagePerShot, this.SurfaceToOrbitWeapon.int_7,
                        rateOfFire));

                    Decimal accuracyFactor = 1M - this.int_1 / (Decimal)this.int_2;

                    sb.AppendLine(string.Format("Maximum Fire Control Range {0}km      Chance to Hit at Max Range {1}%",
                        AuroraUtils.smethod_37(this.int_2), AuroraUtils.smethod_39(accuracyFactor * 100M)));
                    sb.AppendLine(string.Format("Maximum Sensor Range {0}km      Max Range vs Missile {1} km",
                        AuroraUtils.smethod_37(this.int_3),
                        AuroraUtils.smethod_43(Math.Pow(AuroraUtils.double_20, 2.0) * this.int_3)));

                    if (this.int_7 > 0)
                    {
                        sb.AppendLine(string.Format("ECCM-{0}", AuroraUtils.smethod_37(this.int_7)));
                    }
                }
                else if (gclass100.GroundUnitComponentType == GroundUnitComponent.const_26)
                {
                    // Handle the 'const_26' type (Headquarters)
                    sb.AppendLine(string.Format("Headquarters:    Capacity {0}", AuroraUtils.smethod_37(this.int_6)));
                }
                else
                {
                    // Handle all other component types
                    sb.AppendLine(gclass100.method_3(this.decimal_1));
                }
            }

            // Append capabilities if any exist
            if (this.dictionary_0.Values.Any())
            {
                sb.AppendLine(); // Add a blank line separator
                foreach (GroundUnitCapabilityDefinition gclass98 in this.dictionary_0.Values)
                {
                    sb.AppendLine(gclass98.CapabilityName);
                }
            }

            // Append final flag-based info
            if (this.bool_0)
            {
                sb.AppendLine("Non-Combat Class");
            }

            if (bool_4)
            {
                sb.AppendLine();
                sb.AppendLine(this.gclass123_0.method_36());
                sb.Append(string.Format("Development Cost  {0}", AuroraUtils.smethod_37(this.TechData.int_4))); // Use Append for the last line as original had no final NewLine
            }

            // Assign the completed string to the UI element
            textBox_0.Text = sb.ToString();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1748);
        }
    }
}