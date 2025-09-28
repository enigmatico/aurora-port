// Decompiled with JetBrains decompiler
// Type: GClass193
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class GClass193
{
    private sealed class Class1162
    {
        public bool bool_0;
        public GClass193 gclass193_0;
        public bool bool_1;

        internal bool method_0(ShipClass gclass22_0)
        {
            if (gclass22_0.gclass187_0 != null || gclass22_0.Obsolete != 0 && !this.bool_0 ||
                !(gclass22_0.Size <= this.gclass193_0.decimal_0 / 50M) || !gclass22_0.Commercial ||
                gclass22_0.Race != this.gclass193_0.gclass21_0)
                return false;
            if (!this.bool_1)
                return true;
            return gclass22_0.Size >= this.gclass193_0.gclass22_0.Size * 0.8M &&
                   gclass22_0.Size <= this.gclass193_0.gclass22_0.Size * 1.2M;
        }

        internal bool method_1(ShipClass gclass22_0)
        {
            if (gclass22_0.gclass187_0 != null || gclass22_0.Obsolete != 0 && !this.bool_0 ||
                !(gclass22_0.Size <= this.gclass193_0.decimal_0 / 50M) ||
                gclass22_0.Race != this.gclass193_0.gclass21_0)
                return false;
            if (!this.bool_1)
                return true;
            return gclass22_0.Size >= this.gclass193_0.gclass22_0.Size * 0.8M &&
                   gclass22_0.Size <= this.gclass193_0.gclass22_0.Size * 1.2M;
        }

        internal bool method_2(ShipData gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass193_0.gclass21_0;
        }

        internal bool method_3(ShipClass gclass22_0)
        {
            return gclass22_0.Size <= this.gclass193_0.decimal_0 / 50M && gclass22_0.Commercial &&
                   gclass22_0.Race == this.gclass193_0.gclass21_0 && gclass22_0.gclass187_0 == null;
        }

        internal bool method_4(ShipClass gclass22_0)
        {
            return gclass22_0.Size <= this.gclass193_0.decimal_0 / 50M &&
                   gclass22_0.Race == this.gclass193_0.gclass21_0 && gclass22_0.gclass187_0 == null;
        }

        internal bool method_5(ShipData gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.gclass193_0.gclass21_0;
        }

        internal bool method_6(ShipData gclass40_0)
        {
            return this.gclass193_0.gclass0_0.method_520(gclass40_0.gclass85_0.XCoord,
                this.gclass193_0.gclass146_0.method_87(), gclass40_0.gclass85_0.YCoord,
                this.gclass193_0.gclass146_0.method_88());
        }
    }

    public GClass0 gclass0_0;
    public GameRace gclass21_0;
    public PopulationData gclass146_0;
    public ShipData gclass40_0;
    public ShipData gclass40_1;
    public ShipClass gclass22_0;
    public ShipClass gclass22_1;
    public FleetData gclass85_0;
    public NavalAdminCommand gclass83_0;
    public AuroraShipyardType auroraShipyardType_0;
    public AuroraShipyardUpgradeType auroraShipyardUpgradeType_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public int int_3;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public Decimal decimal_2;
    public double double_0;
    public double double_1;
    public bool bool_0;
    public string string_0;
    public Decimal decimal_3;
    public Decimal decimal_4;
    public ShipClass gclass22_2;
    public ShipClass gclass22_3;
    public FleetData gclass85_1;
    public NavalAdminCommand gclass83_1;
    public ShipData gclass40_2;
    public AllMineralsValue gclass123_0;
    public AuroraSYTaskType auroraSYTaskType_0;
    public Decimal decimal_5;
    public string string_1 = "";
    public bool bool_1;

    public GClass193(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public List<GClass192> method_0()
    {
        try
        {
            return this.gclass0_0.dictionary_32.Values.Where<GClass192>(gclass192_0 => gclass192_0.gclass193_0 == this)
                .ToList<GClass192>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2922);
            return null;
        }
    }

    public int method_1()
    {
        try
        {
            return this.gclass0_0.dictionary_32.Values.Count<GClass192>(gclass192_0 => gclass192_0.gclass193_0 == this);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2923);
            return 0;
        }
    }

    public void method_2()
    {
        try
        {
            GClass192 gclass192 = new GClass192();
            gclass192.int_0 = this.gclass0_0.method_26(GEnum0.const_2);
            gclass192.gclass21_0 = this.gclass21_0;
            gclass192.gclass146_0 = this.gclass146_0;
            gclass192.gclass193_0 = this;
            gclass192.gclass40_0 = null;
            gclass192.gclass22_0 = this.gclass22_0;
            gclass192.gclass22_1 = null;
            gclass192.gclass85_0 = null;
            gclass192.gclass123_0 = this.gclass22_0.ClassMaterials.method_25();
            gclass192.auroraSYTaskType_0 = AuroraSYTaskType.Construction;
            gclass192.decimal_0 = this.gclass22_0.Cost;
            gclass192.decimal_1 = 0M;
            gclass192.bool_0 = this.gclass22_0.Commercial;
            gclass192.string_0 = "";
            gclass192.bool_2 = false;
            gclass192.bool_1 = this.gclass21_0.NPR;
            this.gclass0_0.dictionary_32.Add(gclass192.int_0, gclass192);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2924);
        }
    }

    public void method_3(
        AuroraSYTaskType auroraSYTaskType_1,
        ShipData gclass40_3,
        ShipClass gclass22_4,
        ShipClass gclass22_5,
        FleetData gclass85_2,
        AllMineralsValue gclass123_1,
        Decimal decimal_6,
        string string_2)
    {
        try
        {
            GClass192 gclass192 = new GClass192();
            gclass192.int_0 = this.gclass0_0.method_26(GEnum0.const_2);
            gclass192.gclass21_0 = this.gclass21_0;
            gclass192.gclass146_0 = this.gclass146_0;
            gclass192.gclass193_0 = this;
            gclass192.gclass40_0 = gclass40_3;
            gclass192.gclass22_0 = gclass22_4;
            gclass192.gclass22_1 = gclass22_5;
            gclass192.gclass85_0 = gclass85_2;
            gclass192.gclass123_0 = gclass123_1.method_25();
            gclass192.auroraSYTaskType_0 = auroraSYTaskType_1;
            gclass192.decimal_0 = decimal_6;
            gclass192.decimal_1 = 0M;
            gclass192.bool_0 = gclass22_4.Commercial;
            gclass192.string_0 = string_2;
            gclass192.bool_2 = false;
            gclass192.bool_1 = this.gclass21_0.NPR;
            gclass192.bool_3 = false;
            this.gclass0_0.dictionary_32.Add(gclass192.int_0, gclass192);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2925);
        }
    }

    public bool method_4(
        CheckState checkState_0,
        CheckState checkState_1,
        ComboBox comboBox_0,
        ComboBox comboBox_1,
        ComboBox comboBox_2)
    {
        try
        {
            if (this.auroraSYTaskType_0 == AuroraSYTaskType.Construction)
            {
                if (this.gclass22_2 == null)
                {
                    int num = (int)MessageBox.Show("Please select a class to construct", "Task Not Possible");
                    return false;
                }

                if (!this.gclass22_2.method_29(this.gclass146_0))
                {
                    int num = (int)MessageBox.Show(
                        "A ship cannot be built if it contains alien components that are not available in the population stockpile",
                        "Task Not Possible");
                    return false;
                }

                if (this.gclass22_2.method_28())
                {
                    int num = (int)MessageBox.Show("A ship cannot be built if it contains prototype components",
                        "Task Not Possible");
                    return false;
                }

                if (checkState_1 == CheckState.Unchecked && this.gclass85_1 == null)
                {
                    int num = (int)MessageBox.Show("Please select a target fleet");
                    return false;
                }

                if (checkState_1 == CheckState.Checked && this.gclass83_1 == null)
                {
                    int num = (int)MessageBox.Show("Please select a target naval administration command");
                    return false;
                }

                ShipData gclass40 = this.gclass0_0.Ships.Values.FirstOrDefault<ShipData>(
                    gclass40_3 => gclass40_3.gclass21_0 == this.gclass21_0 && gclass40_3.ShipName == this.string_1);
                if (gclass40 != null)
                {
                    int num = (int)MessageBox.Show(
                        $"That name is already in use for a unit of the {gclass40.gclass22_0.ClassName} class");
                    return false;
                }

                this.gclass22_2.Locked = true;
            }
            else if (this.auroraSYTaskType_0 != AuroraSYTaskType.Refit &&
                     this.auroraSYTaskType_0 != AuroraSYTaskType.AutoRefit)
            {
                if ((this.auroraSYTaskType_0 == AuroraSYTaskType.Repair ||
                     this.auroraSYTaskType_0 == AuroraSYTaskType.Scrap) && this.gclass40_2 == null)
                {
                    int num = (int)MessageBox.Show("No Ship Selected", "Task Not Possible");
                    return false;
                }
            }
            else
            {
                if (!this.gclass22_3.method_30(this.gclass22_2, this.gclass146_0))
                {
                    int num = (int)MessageBox.Show(
                        "A ship cannot be refitted if the refit requires alien components that are not available in the population stockpile",
                        "Task Not Possible");
                    return false;
                }

                if (this.gclass22_2.method_28())
                {
                    int num = (int)MessageBox.Show(
                        "A ship cannot be refitted to a class that contains prototype components", "Task Not Possible");
                    return false;
                }

                if (this.gclass40_2 == null)
                {
                    int num = (int)MessageBox.Show("No Ship Selected", "Task Not Possible");
                    return false;
                }

                if (this.gclass22_3 == this.gclass22_2)
                {
                    int num = (int)MessageBox.Show("You cannot refit a class to the same class", "Task Not Possible");
                    return false;
                }

                if (this.decimal_5 == 0M)
                {
                    int num = (int)MessageBox.Show("Cannot create refit tasks that have zero cost",
                        "Task Not Possible");
                    return false;
                }

                this.gclass22_2.Locked = true;
            }

            GClass192 gclass192_0 = new GClass192();
            gclass192_0.int_0 = this.gclass0_0.method_26(GEnum0.const_2);
            gclass192_0.gclass21_0 = this.gclass21_0;
            gclass192_0.gclass146_0 = this.gclass146_0;
            gclass192_0.gclass193_0 = this;
            gclass192_0.gclass40_0 = this.gclass40_2;
            gclass192_0.auroraSYTaskType_0 = this.auroraSYTaskType_0;
            if (checkState_1 != CheckState.Unchecked && gclass192_0.auroraSYTaskType_0 == AuroraSYTaskType.Construction)
            {
                gclass192_0.gclass85_0 = null;
                gclass192_0.gclass83_0 = this.gclass83_1;
            }
            else
            {
                gclass192_0.gclass85_0 = this.gclass85_1;
                gclass192_0.gclass83_0 = null;
            }

            gclass192_0.gclass123_0 = this.gclass123_0.method_25();
            gclass192_0.decimal_0 = this.decimal_5;
            gclass192_0.decimal_1 = 0M;
            gclass192_0.string_0 = this.string_1;
            gclass192_0.bool_2 = false;
            gclass192_0.bool_1 = this.gclass21_0.NPR;
            gclass192_0.bool_0 = this.gclass22_2.Commercial;
            if (gclass192_0.auroraSYTaskType_0 != AuroraSYTaskType.Construction && gclass192_0.gclass40_0 != null)
                gclass192_0.gclass85_0 = gclass192_0.gclass40_0.gclass85_0;
            if (this.auroraSYTaskType_0 != AuroraSYTaskType.Refit &&
                this.auroraSYTaskType_0 != AuroraSYTaskType.AutoRefit)
            {
                gclass192_0.gclass22_0 = this.gclass22_2;
                gclass192_0.gclass22_1 = null;
            }
            else
            {
                gclass192_0.gclass22_0 = this.gclass22_3;
                gclass192_0.gclass22_1 = this.gclass22_2;
            }

            if (this.auroraSYTaskType_0 == AuroraSYTaskType.Construction)
            {
                this.gclass146_0.method_33(gclass192_0, checkState_0);
                gclass192_0.gclass22_0.Locked = true;
                gclass192_0.bool_3 = true;
            }

            if (this.auroraSYTaskType_0 == AuroraSYTaskType.Refit ||
                this.auroraSYTaskType_0 == AuroraSYTaskType.AutoRefit)
            {
                this.gclass146_0.method_34(gclass192_0, checkState_0);
                gclass192_0.bool_3 = true;
            }

            this.gclass0_0.dictionary_32.Add(gclass192_0.int_0, gclass192_0);
            if (gclass192_0.gclass85_0 != null)
                gclass192_0.gclass85_0.method_263();
            if (this.auroraSYTaskType_0 != AuroraSYTaskType.Refit &&
                this.auroraSYTaskType_0 != AuroraSYTaskType.AutoRefit)
            {
                if (this.auroraSYTaskType_0 == AuroraSYTaskType.Scrap)
                    gclass192_0.gclass146_0.method_129((ShipClass)comboBox_1.SelectedItem, comboBox_2, false, false,
                        true);
                else if (this.auroraSYTaskType_0 == AuroraSYTaskType.Repair)
                    gclass192_0.gclass146_0.method_129((ShipClass)comboBox_1.SelectedItem, comboBox_2, false, true,
                        true);
            }
            else
                gclass192_0.gclass146_0.method_129((ShipClass)comboBox_0.SelectedItem, comboBox_2, true, false, true);

            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2926);
            return false;
        }
    }

    public void method_5(
        ComboBox comboBox_0,
        ComboBox comboBox_1,
        ComboBox comboBox_2,
        ComboBox comboBox_3,
        ComboBox comboBox_4,
        ComboBox comboBox_5,
        ListView listView_0,
        TextBox textBox_0,
        Label label_0,
        Label label_1,
        ListView listView_1)
    {
        try
        {
            textBox_0.Text = "N/A";
            label_0.Text = "N/A";
            label_1.Text = "N/A";
            listView_0.Items.Clear();
            this.gclass22_2 = (ShipClass)comboBox_1.SelectedItem;
            this.gclass22_3 = (ShipClass)comboBox_2.SelectedItem;
            this.gclass40_2 = (ShipData)comboBox_3.SelectedItem;
            this.gclass85_1 = (FleetData)comboBox_4.SelectedItem;
            this.gclass83_1 = null;
            this.gclass123_0 = null;
            this.decimal_5 = 0M;
            this.string_1 = "None";
            listView_1.Items.Clear();
            if (this.gclass22_2 == null)
                return;
            this.method_7(this.gclass22_2);
            switch (comboBox_0.Text)
            {
                case "Construction":
                    this.string_1 = this.gclass22_2.method_39();
                    textBox_0.Text = this.string_1;
                    this.decimal_5 = this.gclass22_2.Cost;
                    this.gclass22_2.ClassMaterials.method_31(listView_0, this.gclass146_0.CurrentMinerals);
                    this.gclass123_0 = this.gclass22_2.ClassMaterials.method_25();
                    this.auroraSYTaskType_0 = AuroraSYTaskType.Construction;
                    this.gclass83_1 = (NavalAdminCommand)comboBox_5.SelectedItem;
                    break;
                case "Repair":
                    if (this.gclass40_2 == null)
                        return;
                    this.decimal_5 = this.gclass40_2.method_206();
                    this.auroraSYTaskType_0 = AuroraSYTaskType.Repair;
                    this.gclass123_0 = this.gclass40_2.method_207();
                    this.string_1 = this.gclass40_2.ShipName;
                    break;
                case "Scrap":
                    if (this.gclass40_2 == null)
                        return;
                    this.decimal_5 = this.gclass22_2.Cost * AuroraUtils.decimal_39;
                    this.gclass22_2.ClassMaterials.method_32(listView_0, this.gclass146_0.CurrentMinerals,
                        AuroraUtils.decimal_39);
                    this.gclass123_0 = this.gclass22_2.ClassMaterials.method_26(AuroraUtils.decimal_39);
                    this.auroraSYTaskType_0 = AuroraSYTaskType.Scrap;
                    this.string_1 = this.gclass40_2.ShipName;
                    break;
                case "Refit":
                    if (this.gclass22_3 == null || this.gclass40_2 == null)
                        return;
                    AllMineralsValue gclass123_1_1 = new AllMineralsValue(this.gclass0_0);
                    this.decimal_5 = this.gclass22_3.method_40(this.gclass22_2, gclass123_1_1, listView_1);
                    gclass123_1_1.method_31(listView_0, this.gclass146_0.CurrentMinerals);
                    this.gclass123_0 = gclass123_1_1;
                    this.auroraSYTaskType_0 = AuroraSYTaskType.Refit;
                    this.string_1 = this.gclass40_2.ShipName;
                    break;
                case "Auto Refit":
                    if (this.gclass22_3 == null || this.gclass40_2 == null)
                        return;
                    AllMineralsValue gclass123_1_2 = new AllMineralsValue(this.gclass0_0);
                    this.decimal_5 = this.gclass22_3.method_40(this.gclass22_2, gclass123_1_2, listView_1);
                    gclass123_1_2.method_31(listView_0, this.gclass146_0.CurrentMinerals);
                    this.gclass123_0 = gclass123_1_2;
                    this.auroraSYTaskType_0 = AuroraSYTaskType.AutoRefit;
                    this.string_1 = this.gclass40_2.ShipName;
                    break;
            }

            label_0.Text = AuroraUtils.FormatNumberToDigits(this.decimal_5, 1);
            this.decimal_5 = Math.Abs(this.decimal_5);
            Decimal num = this.decimal_5 / this.decimal_4 * AuroraUtils.decimal_29;
            label_1.Text = this.gclass0_0.method_583((double)(this.gclass0_0.GameTime + num));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2927);
        }
    }

    public void method_6()
    {
        try
        {
            this.decimal_3 =
                (1M + ((this.auroraShipyardType_0 != AuroraShipyardType.Naval
                    ? this.decimal_0 * AuroraUtils.decimal_67 / (AuroraUtils.int_20 * 50)
                    : this.decimal_0 / (AuroraUtils.int_20 * 50)) - 1M) / 2M) * this.gclass146_0.decimal_65;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2928);
        }
    }

    public void method_7(ShipClass gclass22_4)
    {
        try
        {
            Decimal decimal14 = gclass22_4.Size;
            if (gclass22_4.Commercial)
                decimal14 *= AuroraUtils.decimal_22;
            this.decimal_4 = (1M + (decimal14 / AuroraUtils.int_20 - 1M) / 2M) * this.gclass146_0.decimal_65;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2929);
        }
    }

    public List<ShipClass> method_8()
    {
        try
        {
            List<ShipClass> gclass22List = new List<ShipClass>();
            if (this.gclass22_0 == null)
                return gclass22List;
            gclass22List.Add(this.gclass22_0);
            foreach (ShipClass gclass22_0 in this.auroraShipyardType_0 != AuroraShipyardType.Commercial
                         ? this.gclass0_0.ShipClasses.Values.Where<ShipClass>(gclass22_4 =>
                                 gclass22_4.gclass187_0 == null && gclass22_4.Obsolete == 0 && gclass22_4.OtherRaceClassID == 0 &&
                                 gclass22_4.Size <= this.decimal_0 / 50M && gclass22_4 != this.gclass22_0 &&
                                 gclass22_4.Race == this.gclass21_0)
                             .OrderBy<ShipClass, string>(gclass22_0 => gclass22_0.ClassName).ToList<ShipClass>()
                         : this.gclass0_0.ShipClasses.Values.Where<ShipClass>(gclass22_4 =>
                                 gclass22_4.gclass187_0 == null && gclass22_4.Obsolete == 0 && gclass22_4.OtherRaceClassID == 0 &&
                                 gclass22_4.Size <= this.decimal_0 / 50M && gclass22_4 != this.gclass22_0 &&
                                 gclass22_4.Commercial && gclass22_4.Race == this.gclass21_0)
                             .OrderBy<ShipClass, string>(gclass22_0 => gclass22_0.ClassName).ToList<ShipClass>())
            {
                if (!(gclass22_0.Size < this.gclass22_0.Size * 0.8M) &&
                    !(gclass22_0.Size > this.gclass22_0.Size * 1.2M) &&
                    this.gclass22_0.method_40(gclass22_0, null, null) <= this.gclass22_0.Cost / 5M)
                    gclass22List.Add(gclass22_0);
            }

            return gclass22List;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2930);
            return null;
        }
    }

    public List<ShipClass> method_9(bool bool_2, bool bool_3, bool bool_4)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass193.Class1162 class1162 = new GClass193.Class1162();
        // ISSUE: reference to a compiler-generated field
        class1162.bool_0 = bool_2;
        // ISSUE: reference to a compiler-generated field
        class1162.gclass193_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1162.bool_1 = bool_3;
        try
        {
            // ISSUE: reference to a compiler-generated field
            if (this.gclass22_0 == null && class1162.bool_1)
                return new List<ShipClass>();
            List<ShipClass> gclass22List = new List<ShipClass>();
            List<ShipClass> first;
            // ISSUE: reference to a compiler-generated field
            if (class1162.bool_1)
            {
                if (this.gclass22_0 == null)
                    return new List<ShipClass>();
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                first = (this.auroraShipyardType_0 != AuroraShipyardType.Commercial
                        ? this.gclass0_0.ShipClasses.Values.Where<ShipClass>(class1162.method_1)
                            .OrderBy<ShipClass, string>(gclass22_0 => gclass22_0.ClassName).ToList<ShipClass>()
                        : (IEnumerable<ShipClass>)this.gclass0_0.ShipClasses.Values.Where<ShipClass>(class1162.method_0)
                            .OrderBy<ShipClass, string>(gclass22_0 => gclass22_0.ClassName).ToList<ShipClass>())
                    .Intersect<ShipClass>(this.gclass0_0.Ships.Values
                        .Where<ShipData>(class1162.method_2)
                        .Select<ShipData, ShipClass>(gclass40_0 => gclass40_0.gclass22_0).Distinct<ShipClass>()
                        .ToList<ShipClass>()).ToList<ShipClass>();
            }
            else
            {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                first = this.auroraShipyardType_0 != AuroraShipyardType.Commercial
                    ? this.gclass0_0.ShipClasses.Values.Where<ShipClass>(class1162.method_4)
                        .OrderBy<ShipClass, string>(gclass22_0 => gclass22_0.ClassName).ToList<ShipClass>()
                    : this.gclass0_0.ShipClasses.Values.Where<ShipClass>(class1162.method_3)
                        .OrderBy<ShipClass, string>(gclass22_0 => gclass22_0.ClassName).ToList<ShipClass>();
            }

            if (bool_4)
            {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                List<ShipClass> list = this.gclass0_0.Ships.Values
                    .Where<ShipData>(class1162.method_5).Where<ShipData>(class1162.method_6)
                    .Select<ShipData, ShipClass>(gclass40_0 => gclass40_0.gclass22_0).Distinct<ShipClass>()
                    .ToList<ShipClass>();
                first = first.Intersect<ShipClass>(list).ToList<ShipClass>();
            }

            return first;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2931);
            return null;
        }
    }
}