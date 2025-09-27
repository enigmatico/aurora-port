// Decompiled with JetBrains decompiler
// Type: GClass202
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public partial class RacialSystemSurvey
{
    public Dictionary<AlienRaceInfo, AlienRaceSystemStatus> dictionary_0 = new Dictionary<AlienRaceInfo, AlienRaceSystemStatus>();
    public List<FCTShipData40> list_0 = new List<FCTShipData40>();
    public SystemData200 ActualSystemData;
    public GameRace Race;
    public AlienRaceInfo gclass110_0;
    public GClass62 gclass62_0;
    public NamingTheme NamingTheme;
    public GClass3 gclass3_0;
    public AuroraSystemProtectionStatus AutoSystemProtectionStatus;
    private GClass0 gclass0_0;
    public int DangerRating;
    public int ForeignFleetRaceID;
    public int SectorID;
    public int ClosedWP;
    public int RaidRating;
    public string Discovered;
    public bool bSysTPStatus;
    public bool bSurveyComplete;
    public bool bGeoSurveyDefaultDone;
    public bool bNoAutoRoute;
    public bool bMilitaryRestrictedSystem;
    public bool bMineralSearchFlag;
    public Decimal DiscoveredTime;
    public double SelectedBodyXCoord;
    public double SelectedBodyYCoord;
    public double KmPerPixel;
    public double double_3;
    public double double_4;
    public int int_5;
    public int int_6;
    public int int_7;
    public Decimal decimal_1;
    public Decimal decimal_2;
    public Decimal decimal_3;
    public Decimal decimal_4;
    public Decimal decimal_5;
    public int int_8;
    public int int_9;
    public Decimal decimal_6;
    public Decimal decimal_7;
    public string string_3 = "";
    public Decimal decimal_8;
    public List<FCTShipData40> list_1 = new List<FCTShipData40>();
    public List<PopulationData> list_2 = new List<PopulationData>();
    public List<GClass132> list_3 = new List<GClass132>();
    public RacialSystemSurvey gclass202_0;
    public RacialSystemSurvey gclass202_1;
    public int int_10;
    public Decimal decimal_9;
    public bool bool_6;
    public List<SystemBodyData> list_4 = new List<SystemBodyData>();
    public List<SystemBodyData> list_5 = new List<SystemBodyData>();
    public FleetData gclass85_0;
    public SystemBodyData gclass1_0;
    public GClass132 gclass132_0;
    public GClass221 gclass221_0 = new GClass221(0.0, 0.0);
    public List<SystemBodyData> list_6 = new List<SystemBodyData>();
    public List<JumpPoint120> list_7 = new List<JumpPoint120>();
    public List<JumpPoint120> list_8 = new List<JumpPoint120>();
    public int int_11;
    public int int_12 = 1;
    public int int_13;
    public int int_14;
    public int int_15;
    public int int_16;
    public int int_17;
    public int int_18;
    public int int_19;
    public int int_20;
    public int int_21;
    public int int_22;
    public int int_23;
    public int int_24;
    public int int_25;
    public int int_26;
    public int int_27;
    public int int_28;
    public int int_29;
    public int int_30;
    public int int_31;
    public int int_32;
    public int int_33;
    public int int_34;
    public int int_35;
    public Decimal decimal_10;
    public Decimal decimal_11;
    public double XCoord;
    public double YCoord;
    public double SavedXCoord;
    public double SavedYCoord;
    public double double_9;
    public double double_10;
    public double double_11;
    public bool bool_7;
    public bool bool_8;
    public bool bool_9;
    public bool bool_10;
    public AuroraContactStatus auroraContactStatus_0 = AuroraContactStatus.None;
    public int int_36;

    public string Name { get; set; }

    public string NameWithSector { get; set; }

    public RacialSystemSurvey(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public List<RacialSystemSurvey> method_0(List<RacialSystemSurvey> list_9)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            RacialSystemSurvey.Class1182 class1182 = new RacialSystemSurvey.Class1182();
            if (list_9.Count == 0)
                return list_9;
            // ISSUE: reference to a compiler-generated field
            class1182.list_0 = this.gclass0_0.JumpPointDictionary.Values
                .Where<JumpPoint120>(gclass120_0 =>
                    gclass120_0.SystemData == this.ActualSystemData &&
                    gclass120_0.RacialJumpPointSurveys[this.Race.RaceID].MilitaryRestricted == 0 &&
                    gclass120_0.RacialJumpPointSurveys[this.Race.RaceID].Explored == 1)
                .Select<JumpPoint120, SystemData200>(gclass120_0 => gclass120_0.LinkedJumpPoint.SystemData)
                .ToList<SystemData200>();
            // ISSUE: reference to a compiler-generated method
            return list_9.Where<RacialSystemSurvey>(class1182.method_0).ToList<RacialSystemSurvey>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3476);
            return null;
        }
    }

    public AuroraSystemProtectionStatus method_1()
    {
        try
        {
            return this.dictionary_0.Count == 0
                ? AuroraSystemProtectionStatus.NoProtection
                : this.dictionary_0.Values.Max<AlienRaceSystemStatus, AuroraSystemProtectionStatus>(gclass111_0 =>
                    gclass111_0.auroraSystemProtectionStatus_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2526);
            return AuroraSystemProtectionStatus.NoProtection;
        }
    }

    public Decimal method_2()
    {
        try
        {
            return this.gclass0_0.PopulationDataDictionary.Values.Where<PopulationData>(gclass146_0 => gclass146_0.gclass202_0 == this)
                .Sum<PopulationData>(gclass146_0 => gclass146_0.method_190());
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2527);
            return 0M;
        }
    }

    public RacialSystemSurvey method_3(GameRace gclass21_1, List<AlienRaceInfo> list_9)
    {
        try
        {
            RacialSystemSurvey gclass202 = new RacialSystemSurvey(this.gclass0_0);
            RacialSystemSurvey gclass202_1 = (RacialSystemSurvey)this.MemberwiseClone();
            gclass202_1.Race = gclass21_1;
            gclass202_1.gclass62_0 = null;
            gclass202_1.SectorID = 0;
            gclass202_1.NamingTheme = null;
            if (this.gclass110_0 != null)
                gclass202_1.gclass110_0 = list_9.FirstOrDefault<AlienRaceInfo>(gclass110_1 =>
                    gclass110_1.ActualAlienRace == this.gclass110_0.ActualAlienRace);
            if (gclass21_1.NPR)
                this.gclass3_0 = new GClass3(this.gclass0_0, gclass202_1);
            gclass202_1.list_1 = new List<FCTShipData40>();
            gclass202_1.list_2 = new List<PopulationData>();
            gclass202_1.list_3 = new List<GClass132>();
            gclass202_1.dictionary_0 = new Dictionary<AlienRaceInfo, AlienRaceSystemStatus>();
            foreach (KeyValuePair<AlienRaceInfo, AlienRaceSystemStatus> keyValuePair in this.dictionary_0)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                RacialSystemSurvey.Class1183 class1183 = new RacialSystemSurvey.Class1183();
                // ISSUE: reference to a compiler-generated field
                class1183.keyValuePair_0 = keyValuePair;
                // ISSUE: reference to a compiler-generated method
                AlienRaceInfo key = list_9.FirstOrDefault<AlienRaceInfo>(class1183.method_0);
                // ISSUE: reference to a compiler-generated field
                gclass202_1.dictionary_0.Add(key, new AlienRaceSystemStatus()
                {
                    gclass202_0 = gclass202_1,
                    gclass110_0 = key,
                    auroraSystemProtectionStatus_0 = class1183.keyValuePair_0.Value.auroraSystemProtectionStatus_0
                });
            }

            return gclass202_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2528);
            return null;
        }
    }

    public void method_4()
    {
        try
        {
            foreach (PopulationData gclass146_1 in this.gclass0_0.PopulationDataDictionary.Values
                         .Where<PopulationData>(gclass146_0 => gclass146_0.gclass202_0 == this).ToList<PopulationData>())
                this.Race.method_132(gclass146_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2529);
        }
    }

    public void method_5(GameRace gclass21_1)
    {
        try
        {
            List<PopulationData> list1 = this.gclass0_0.PopulationDataDictionary.Values.Where<PopulationData>(gclass146_0 =>
            {
                if (gclass146_0.gclass202_0 != this)
                    return false;
                return gclass146_0.Population > 0.01M || gclass146_0.dictionary_0.Count > 0;
            }).ToList<PopulationData>();
            List<PopulationData> list2 = this.gclass0_0.PopulationDataDictionary.Values.Where<PopulationData>(gclass146_0 =>
                gclass146_0.gclass202_0 == this && gclass146_0.Population <= 0.01M &&
                gclass146_0.dictionary_0.Count == 0).ToList<PopulationData>();
            foreach (PopulationData gclass146 in list1)
                gclass146.method_114(gclass21_1, PopPoliticalStatusType.Occupied, false, false, false);
            foreach (PopulationData gclass146_1 in list2)
                this.Race.method_132(gclass146_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2530);
        }
    }

    public void method_6()
    {
        try
        {
            this.double_9 = this.XCoord + this.Race.double_2;
            this.double_10 = this.YCoord + this.Race.double_3;
            this.double_9 = this.gclass0_0.double_6 -
                            (this.gclass0_0.double_6 - this.double_9) * this.Race.ZoomSetting;
            this.double_10 = this.gclass0_0.double_7 -
                             (this.gclass0_0.double_7 - this.double_10) * this.Race.ZoomSetting;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2531);
        }
    }

    public void method_7()
    {
        try
        {
            this.gclass221_0 = new GClass221(0.0, 0.0);
            if (this.gclass85_0 != null)
            {
                this.gclass221_0.double_0 = this.gclass85_0.XCoord;
                this.gclass221_0.double_1 = this.gclass85_0.YCoord;
            }
            else if (this.gclass1_0 != null)
            {
                this.gclass221_0.double_0 = this.gclass1_0.XCoordinate;
                this.gclass221_0.double_1 = this.gclass1_0.YCoordinate;
            }
            else
            {
                if (this.gclass132_0 == null)
                    return;
                this.gclass221_0.double_0 = this.gclass132_0.double_0;
                this.gclass221_0.double_1 = this.gclass132_0.double_1;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2532);
        }
    }

    public void method_8(RacialSystemSurvey gclass202_2)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        RacialSystemSurvey.Class1184 class1184 = new RacialSystemSurvey.Class1184();
        // ISSUE: reference to a compiler-generated field
        class1184.gclass202_0 = gclass202_2;
        // ISSUE: reference to a compiler-generated field
        class1184.gclass202_1 = this;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            RacialSystemSurvey gclass202 = this.gclass0_0.JumpPointDictionary.Values.Where<JumpPoint120>(class1184.method_0)
                .Select<JumpPoint120, RacialSystemSurvey>(class1184.method_1)
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0 != null)
                .OrderBy<RacialSystemSurvey, Decimal>(gclass202_0 => gclass202_0.DiscoveredTime).FirstOrDefault<RacialSystemSurvey>();
            if (gclass202 != null)
            {
                // ISSUE: reference to a compiler-generated field
                double num1 = class1184.gclass202_0.XCoord - gclass202.XCoord;
                // ISSUE: reference to a compiler-generated field
                double num2 = class1184.gclass202_0.YCoord - gclass202.YCoord;
                if (num1 > AuroraUtils.int_1)
                    num1 = AuroraUtils.int_1;
                if (num2 > AuroraUtils.int_1)
                    num2 = AuroraUtils.int_1;
                if (num1 < -AuroraUtils.int_1)
                    num1 = -AuroraUtils.int_1;
                if (num2 < -AuroraUtils.int_1)
                    num2 = -AuroraUtils.int_1;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (this.method_9(class1184.gclass202_0.XCoord + num1, class1184.gclass202_0.YCoord + num2))
                    return;
            }

            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (this.method_9(class1184.gclass202_0.XCoord + AuroraUtils.int_1, class1184.gclass202_0.YCoord) ||
                this.method_9(class1184.gclass202_0.XCoord - AuroraUtils.int_1, class1184.gclass202_0.YCoord) ||
                this.method_9(class1184.gclass202_0.XCoord, class1184.gclass202_0.YCoord - AuroraUtils.int_0) ||
                this.method_9(class1184.gclass202_0.XCoord, class1184.gclass202_0.YCoord + AuroraUtils.int_0) ||
                this.method_9(class1184.gclass202_0.XCoord + AuroraUtils.int_1,
                    class1184.gclass202_0.YCoord - AuroraUtils.int_0) ||
                this.method_9(class1184.gclass202_0.XCoord - AuroraUtils.int_1,
                    class1184.gclass202_0.YCoord - AuroraUtils.int_0) ||
                this.method_9(class1184.gclass202_0.XCoord + AuroraUtils.int_1,
                    class1184.gclass202_0.YCoord + AuroraUtils.int_0) || this.method_9(
                    class1184.gclass202_0.XCoord - AuroraUtils.int_1,
                    class1184.gclass202_0.YCoord - AuroraUtils.int_0))
                return;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.method_9(class1184.gclass202_0.XCoord + AuroraUtils.int_1 / 3,
                class1184.gclass202_0.YCoord - AuroraUtils.int_0 / 3);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2533);
        }
    }

    public bool method_9(double double_12, double double_13)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        RacialSystemSurvey.Class1185 class1185 = new RacialSystemSurvey.Class1185();
        // ISSUE: reference to a compiler-generated field
        class1185.double_0 = double_12;
        // ISSUE: reference to a compiler-generated field
        class1185.double_1 = double_13;
        try
        {
            // ISSUE: reference to a compiler-generated method
            if (this.Race.RacialSystemDictionary.Values.Count<RacialSystemSurvey>(class1185.method_0) != 0)
                return false;
            // ISSUE: reference to a compiler-generated field
            this.XCoord = class1185.double_0;
            // ISSUE: reference to a compiler-generated field
            this.YCoord = class1185.double_1;
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2534);
            return false;
        }
    }

    public List<FCTMassDriverPacket126> method_10()
    {
        try
        {
            return this.gclass0_0.MassDriverPacketsDictionary.Values.Where<FCTMassDriverPacket126>(gclass126_0 =>
                    gclass126_0.System == this.ActualSystemData && gclass126_0.Race == this.Race)
                .ToList<FCTMassDriverPacket126>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2535);
            return null;
        }
    }

    public JumpPoint120 method_11(RacialSystemSurvey gclass202_2)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        RacialSystemSurvey.Class1186 class1186 = new RacialSystemSurvey.Class1186();
        // ISSUE: reference to a compiler-generated field
        class1186.gclass202_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1186.gclass202_1 = gclass202_2;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.JumpPointDictionary.Values.Where<JumpPoint120>(class1186.method_0)
                .Where<JumpPoint120>(class1186.method_1).FirstOrDefault<JumpPoint120>(class1186.method_2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2536);
            return null;
        }
    }

    public bool method_12(FleetData gclass85_1, GEnum98 genum98_0)
    {
        try
        {
            if (!this.Race.NPR)
                return true;
            if (this.gclass3_0.genum95_0 == GEnum95.const_0 && !gclass85_1.NPRSomething.bool_3 &&
                gclass85_1.NPROperationGroup.genum104_0 != GEnum104.const_25)
                return false;
            switch (genum98_0)
            {
                case GEnum98.const_0:
                    if (gclass85_1.NPROperationGroup.genum104_0 == GEnum104.const_8 &&
                        this.gclass3_0.genum95_0 < GEnum95.const_3)
                        return false;
                    break;
                case GEnum98.const_2:
                    if (this.gclass3_0.genum95_0 < GEnum95.const_2)
                        return false;
                    break;
            }

            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2537);
            return false;
        }
    }

    public List<RacialSystemSurvey> method_13(bool bool_11, bool bool_12, bool bool_13)
    {
        try
        {
            Dictionary<int, RacialSystemSurvey> dictionary = new Dictionary<int, RacialSystemSurvey>();
            List<RacialSystemSurvey> gclass202List1 = new List<RacialSystemSurvey>();
            List<RacialSystemSurvey> gclass202List2 = new List<RacialSystemSurvey>();
            dictionary.Add(this.ActualSystemData.SystemID, this);
            gclass202List1.Add(this);
            while (true)
            {
                foreach (RacialSystemSurvey gclass202_1 in gclass202List1)
                {
                    List<RacialSystemSurvey> list = gclass202_1.method_36(bool_11, true).Except<RacialSystemSurvey>(dictionary.Values)
                        .ToList<RacialSystemSurvey>();
                    if (bool_12)
                        list = list.Where<RacialSystemSurvey>(gclass202_0 => !gclass202_0.method_20()).ToList<RacialSystemSurvey>();
                    if (bool_13)
                        list = list.Where<RacialSystemSurvey>(gclass202_0 => !gclass202_0.method_21()).ToList<RacialSystemSurvey>();
                    foreach (RacialSystemSurvey gclass202_2 in list)
                    {
                        if (!gclass202List2.Contains(gclass202_2))
                            gclass202List2.Add(gclass202_2);
                    }
                }

                if (gclass202List2.Count != 0)
                {
                    gclass202List1.Clear();
                    foreach (RacialSystemSurvey gclass202 in gclass202List2)
                    {
                        gclass202List1.Add(gclass202);
                        dictionary.Add(gclass202.ActualSystemData.SystemID, gclass202);
                    }

                    gclass202List2.Clear();
                }
                else
                    break;
            }

            return dictionary.Values.ToList<RacialSystemSurvey>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2538);
            return null;
        }
    }

    public void method_14(ListView listView_0)
    {
        try
        {
            listView_0.Items.Clear();
            foreach (GClass214 object_1 in this.method_15())
            {
                if (object_1.wayPointType_0 != WayPointType.TransitPOI || this.Race.NPR)
                {
                    string string_12 = "";
                    if (object_1.Name != "")
                        string_12 = object_1.Name;
                    else if (object_1.gclass1_0 != null)
                        string_12 = object_1.gclass1_0.method_78(this.Race);
                    this.gclass0_0.method_602(listView_0, object_1.int_3.ToString(),
                        AuroraUtils.smethod_82(object_1.wayPointType_0), string_12, object_1);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2539);
        }
    }

    public List<GClass214> method_15()
    {
        try
        {
            return this.gclass0_0.dictionary_13.Values
                .Where<GClass214>(gclass214_0 =>
                    gclass214_0.gclass200_0 == this.ActualSystemData && gclass214_0.gclass21_0 == this.Race)
                .OrderBy<GClass214, int>(gclass214_0 => gclass214_0.int_3).ToList<GClass214>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2540);
            return null;
        }
    }

    public bool method_16()
    {
        try
        {
            return this.gclass0_0.dictionary_28.Values.FirstOrDefault<GClass65>(gclass65_0 =>
                gclass65_0.gclass200_0 == this.ActualSystemData && gclass65_0.gclass21_1 == this.Race &&
                gclass65_0.method_5() == AuroraContactStatus.Hostile) != null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2541);
            return false;
        }
    }

    public GClass201 method_17(GEnum109 genum109_0, FleetData gclass85_1)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        RacialSystemSurvey.Class1187 class1187 = new RacialSystemSurvey.Class1187();
        // ISSUE: reference to a compiler-generated field
        class1187.gclass202_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1187.gclass85_0 = gclass85_1;
        try
        {
            GClass201 gclass201 = new GClass201();
            double num1 = 0.0;
            double num2 = 0.0;
            JumpPoint120 gclass120 = this.ActualSystemData.method_4();
            if (gclass120 != null)
            {
                num1 = gclass120.LinkedJumpPoint.XCoord;
                num2 = gclass120.LinkedJumpPoint.YCoord;
            }

            switch (genum109_0)
            {
                case GEnum109.const_1:
                    gclass201.gclass146_0 = this.Race.method_137(this, num1, num1, 0M);
                    if (gclass201.gclass146_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_2:
                    // ISSUE: reference to a compiler-generated field
                    Decimal decimal_29 = class1187.gclass85_0.method_142();
                    gclass201.gclass146_0 = this.Race.method_136(this, num1, num1, decimal_29);
                    if (gclass201.gclass146_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_3:
                    gclass201.gclass85_0 = this.Race.method_138(this, num1, num1);
                    if (gclass201.gclass85_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_4:
                    // ISSUE: reference to a compiler-generated method
                    if (this.gclass0_0.PopulationDataDictionary.Values.Where<PopulationData>(class1187.method_0).Count<PopulationData>() > 0)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_5:
                    // ISSUE: reference to a compiler-generated method
                    if (this.gclass0_0.PopulationDataDictionary.Values.Where<PopulationData>(class1187.method_2).Count<PopulationData>() > 0)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_6:
                case GEnum109.const_34:
                case GEnum109.const_35:
                    // ISSUE: reference to a compiler-generated field
                    gclass201.gclass146_0 =
                        this.Race.method_151(this, num1, num2, class1187.gclass85_0, genum109_0);
                    if (gclass201.gclass146_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_7:
                    gclass201.bool_0 = !this.bSurveyComplete;
                    return gclass201;
                case GEnum109.const_8:
                    gclass201.bool_0 = !this.bGeoSurveyDefaultDone;
                    return gclass201;
                case GEnum109.const_9:
                    gclass201.gclass146_0 = this.Race.method_141(this, num1, num1, 0M);
                    if (gclass201.gclass146_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_13:
                    gclass201.gclass120_0 = this.Race.method_146(this, num1, num2);
                    if (gclass201.gclass120_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_14:
                    gclass201.gclass146_0 = this.Race.method_149(this, num1, num2, false);
                    if (gclass201.gclass146_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_15:
                    gclass201.gclass146_0 = this.Race.method_150(this, 0.0, 0.0, false, true);
                    if (gclass201.gclass146_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_19:
                    gclass201.gclass214_0 = this.ActualSystemData.method_8(num1, num2, this, WayPointType.POI, 0);
                    if (gclass201.gclass214_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_20:
                    gclass201.gclass214_0 = this.ActualSystemData.method_8(num1, num2, this, WayPointType.UrgentPOI, 0);
                    if (gclass201.gclass214_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_23:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass201.gclass146_0 =
                        class1187.gclass85_0.method_210(this, class1187.gclass85_0.gclass190_0, num1, num2);
                    if (gclass201.gclass146_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_24:
                    // ISSUE: reference to a compiler-generated field
                    gclass201.gclass190_0 = class1187.gclass85_0.method_207(this, num1, num2);
                    if (gclass201.gclass190_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_27:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass201.gclass146_0 =
                        class1187.gclass85_0.method_209(this, class1187.gclass85_0.gclass148_0, num1, num2);
                    if (gclass201.gclass146_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_28:
                    // ISSUE: reference to a compiler-generated field
                    gclass201.gclass148_0 = class1187.gclass85_0.method_208(this, num1, num2);
                    if (gclass201.gclass148_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_31:
                    gclass201.gclass233_0 = this.ActualSystemData.method_5(num1, num2, this);
                    if (gclass201.gclass233_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_33:
                    // ISSUE: reference to a compiler-generated method
                    if (this.gclass0_0.PopulationDataDictionary.Values.Where<PopulationData>(class1187.method_1).Count<PopulationData>() > 0)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_36:
                    if (this.ActualSystemData.method_11(this.Race, 0M, false) != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_37:
                    if (this.ActualSystemData.method_11(this.Race, 10M, true) != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_38:
                    if (this.ActualSystemData.method_10(6000000000.0, this.Race) != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_39:
                    if (this.Race.method_133(this) != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_40:
                    gclass201.gclass214_0 = this.ActualSystemData.method_8(num1, num2, this, WayPointType.Rendezvous, 0);
                    if (gclass201.gclass214_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_42:
                    // ISSUE: reference to a compiler-generated field
                    gclass201.gclass85_0 =
                        this.Race.method_145(this, class1187.gclass85_0.gclass22_0, num1, num1);
                    if (gclass201.gclass85_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_43:
                    gclass201.gclass146_0 =
                        this.Race.method_137(this, num1, num1, this.Race.UnknownNprClass.decimal_0);
                    if (gclass201.gclass146_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_44:
                    gclass201.gclass146_0 = this.Race.method_143(this, num1, num1);
                    if (gclass201.gclass146_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_45:
                    gclass201.gclass146_0 = this.Race.method_142(this, num1, num1);
                    if (gclass201.gclass146_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_47:
                    if (!this.bool_6)
                        gclass201.bool_0 = true;
                    return gclass201;
                case GEnum109.const_48:
                    gclass201.gclass146_0 = this.Race.method_140(this, num1, num1);
                    if (gclass201.gclass146_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_49:
                    // ISSUE: reference to a compiler-generated field
                    gclass201.gclass214_0 = this.ActualSystemData.method_8(num1, num2, this, WayPointType.FleetWaypoint,
                        class1187.gclass85_0.FleetID);
                    if (gclass201.gclass214_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
                case GEnum109.const_50:
                    gclass201.gclass85_0 = this.Race.method_139(this, num1, num1);
                    if (gclass201.gclass85_0 != null)
                    {
                        gclass201.bool_0 = true;
                        return gclass201;
                    }

                    break;
            }

            gclass201.bool_0 = false;
            return gclass201;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2542);
            return null;
        }
    }

    public PopulationData method_18(double double_12, double double_13, bool bool_11)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        RacialSystemSurvey.Class1188 class1188 = new RacialSystemSurvey.Class1188();
        // ISSUE: reference to a compiler-generated field
        class1188.gclass202_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1188.double_0 = double_12;
        // ISSUE: reference to a compiler-generated field
        class1188.double_1 = double_13;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            RacialSystemSurvey.Class1189 class1189 = new RacialSystemSurvey.Class1189()
            {
                list_0 = this.Race.PerceivedAliens.Values.Where<AlienRaceInfo>(gclass110_0 => gclass110_0.bTradeTreaty)
                    .Select<AlienRaceInfo, GameRace>(gclass110_0 => gclass110_0.ActualAlienRace)
                    .ToList<GameRace>()
            };
            // ISSUE: reference to a compiler-generated field
            class1189.list_0.Add(this.Race);
            // ISSUE: reference to a compiler-generated method
            List<PopulationData> list = this.gclass0_0.PopulationDataDictionary.Values.Where<PopulationData>(class1189.method_0)
                .Where<PopulationData>(gclass146_0 =>
                    gclass146_0.dictionary_4.Values.FirstOrDefault<GClass190>(
                        gclass190_0 => gclass190_0.decimal_1 > 10M) != null).ToList<PopulationData>();
            if (list.Count == 0)
                return null;
            // ISSUE: reference to a compiler-generated method
            return !bool_11 ? list[0] : list.OrderBy<PopulationData, double>(class1188.method_0).FirstOrDefault<PopulationData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2543);
            return null;
        }
    }

    public Decimal method_19()
    {
        try
        {
            return this.gclass0_0.FleetDictionary.Values.Where<FleetData>(gclass85_1 => gclass85_1.System == this)
                .SelectMany<FleetData, FCTShipData40>(gclass85_0 => gclass85_0.method_176())
                .Sum<FCTShipData40>(gclass40_0 => gclass40_0.gclass22_0.decimal_10);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2543);
            return 0M;
        }
    }

    public bool method_20()
    {
        try
        {
            return this.gclass3_0 != null && this.gclass3_0.genum96_0 > GEnum96.const_1 ||
                   this.DangerRating != 0 && !(this.method_19() > this.DangerRating);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2544);
            return false;
        }
    }

    public bool method_21()
    {
        try
        {
            return this.Race.NPR
                ? this.gclass3_0.genum95_0 == GEnum95.const_0
                : this.gclass110_0 != null && this.gclass110_0.ActualAlienRace != null &&
                  this.gclass110_0.ActualAlienRace != this.Race &&
                  (!this.Race.PerceivedAliens.ContainsKey(this.gclass110_0.ActualAlienRace.RaceID) ||
                   !this.Race.PerceivedAliens[this.gclass110_0.ActualAlienRace.RaceID].bTradeTreaty);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2545);
            return false;
        }
    }

    public void method_22()
    {
        try
        {
            double num1 = this.XCoord % AuroraUtils.int_40;
            if (num1 != 0.0)
            {
                if (num1 < AuroraUtils.int_40 / 2.0)
                    this.XCoord -= num1;
                else
                    this.XCoord += AuroraUtils.int_40 - num1;
            }

            double num2 = this.YCoord % AuroraUtils.int_40;
            if (num2 == 0.0)
                return;
            if (num2 < AuroraUtils.int_40 / 2.0)
                this.YCoord -= num2;
            else
                this.YCoord += AuroraUtils.int_40 - num2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2546);
        }
    }

    public void method_23(int int_37, int int_38)
    {
        try
        {
            this.XCoord += int_37 / this.Race.ZoomSetting;
            this.YCoord += int_38 / this.Race.ZoomSetting;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2547);
        }
    }

    public void method_24()
    {
        try
        {
            this.XCoord = this.SavedXCoord;
            this.YCoord = this.SavedYCoord;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2548);
        }
    }

    public void method_25()
    {
        try
        {
            this.SavedXCoord = this.XCoord;
            this.SavedYCoord = this.YCoord;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2549);
        }
    }

    public void method_26(GClass194 gclass194_0, CheckState checkState_0, List<SystemData200> list_9)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        RacialSystemSurvey.Class1190 class1190 = new RacialSystemSurvey.Class1190();
        // ISSUE: reference to a compiler-generated field
        class1190.gclass194_0 = gclass194_0;
        // ISSUE: reference to a compiler-generated field
        class1190.gclass202_0 = this;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            RacialSystemSurvey.Class1191 class1191 = new RacialSystemSurvey.Class1191();
            // ISSUE: reference to a compiler-generated field
            class1191.class1190_0 = class1190;
            this.int_29 = 0;
            this.int_30 = 0;
            this.int_31 = 0;
            this.int_32 = 0;
            this.int_33 = 0;
            this.int_34 = 0;
            this.int_35 = 0;
            this.list_6 = this.ActualSystemData.method_20();
            foreach (SystemBodyData gclass1 in this.list_6)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                gclass1.method_58(this.Race, class1191.class1190_0.gclass194_0, true);
                if (gclass1.BodyClass == PlanetBodyClass.Asteroid)
                    ++this.int_34;
                else if (gclass1.BodyClass == PlanetBodyClass.Moon)
                    ++this.int_33;
                else if (gclass1.BodyClass == PlanetBodyClass.Comet)
                    ++this.int_35;
                else if (gclass1.BodyTypeId == AuroraSystemBodyType.GasGiant)
                    ++this.int_31;
                else if (gclass1.BodyTypeId == AuroraSystemBodyType.Superjovian)
                    ++this.int_32;
                else if (gclass1.BodyTypeId == AuroraSystemBodyType.Terrestrial)
                    ++this.int_29;
                else if (gclass1.BodyTypeId == AuroraSystemBodyType.DwarfPlanet)
                    ++this.int_30;
            }

            // ISSUE: reference to a compiler-generated field
            class1191.decimal_0 = 1M;
            TechSystem gclass164 =
                this.Race.method_388(this.gclass0_0.TechTypeDataDictionary[TechType.ColonizationCostReduction]);
            if (gclass164 != null)
            {
                // ISSUE: reference to a compiler-generated field
                class1191.decimal_0 = Math.Round(gclass164.decimal_0, 2);
            }

            if (checkState_0 == CheckState.Unchecked)
            {
                this.int_18 = this.list_6.Where<SystemBodyData>(gclass1_0 => gclass1_0.ColonyCost == 0M)
                    .Count<SystemBodyData>();
                // ISSUE: reference to a compiler-generated method
                this.int_19 = this.list_6.Where<SystemBodyData>(class1191.method_0)
                    .Count<SystemBodyData>();
                // ISSUE: reference to a compiler-generated method
                this.int_20 = this.list_6.Where<SystemBodyData>(class1191.method_1)
                    .Count<SystemBodyData>();
                // ISSUE: reference to a compiler-generated method
                this.int_21 = this.list_6.Where<SystemBodyData>(class1191.method_2)
                    .Count<SystemBodyData>();
                // ISSUE: reference to a compiler-generated method
                this.int_22 = this.list_6.Where<SystemBodyData>(class1191.method_3)
                    .Count<SystemBodyData>();
                // ISSUE: reference to a compiler-generated method
                this.int_23 = this.list_6.Where<SystemBodyData>(class1191.method_4)
                    .Count<SystemBodyData>();
                // ISSUE: reference to a compiler-generated method
                this.int_24 = this.list_6.Where<SystemBodyData>(class1191.method_5)
                    .Count<SystemBodyData>();
            }
            else
            {
                this.int_18 = this.list_6.Where<SystemBodyData>(gclass1_0 => gclass1_0.MaxColonyCost == 0M)
                    .Count<SystemBodyData>();
                // ISSUE: reference to a compiler-generated method
                this.int_19 = this.list_6.Where<SystemBodyData>(class1191.method_6)
                    .Count<SystemBodyData>();
                // ISSUE: reference to a compiler-generated method
                this.int_20 = this.list_6.Where<SystemBodyData>(class1191.method_7)
                    .Count<SystemBodyData>();
                // ISSUE: reference to a compiler-generated method
                this.int_21 = this.list_6.Where<SystemBodyData>(class1191.method_8)
                    .Count<SystemBodyData>();
                // ISSUE: reference to a compiler-generated method
                this.int_22 = this.list_6.Where<SystemBodyData>(class1191.method_9)
                    .Count<SystemBodyData>();
                // ISSUE: reference to a compiler-generated method
                this.int_23 = this.list_6.Where<SystemBodyData>(class1191.method_10)
                    .Count<SystemBodyData>();
                // ISSUE: reference to a compiler-generated method
                this.int_24 = this.list_6.Where<SystemBodyData>(class1191.method_11)
                    .Count<SystemBodyData>();
            }

            this.int_28 =
                this.list_6.Count<SystemBodyData>(gclass1_0 => gclass1_0.BodyClass == PlanetBodyClass.Comet);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            class1191.list_0 = this.list_6.Where<SystemBodyData>(class1191.class1190_0.method_0)
                .ToList<SystemBodyData>();
            // ISSUE: reference to a compiler-generated field
            if (class1191.list_0.Count == 0)
            {
                this.int_27 = 100;
            }
            else
            {
                // ISSUE: reference to a compiler-generated method
                this.int_26 = this.gclass0_0.list_9.Where<GClass215>(class1191.method_12).Count<GClass215>();
                // ISSUE: reference to a compiler-generated field
                this.int_27 = (int)Math.Round(this.int_26 / (Decimal)class1191.list_0.Count * 100M);
            }

            if (list_9.Count <= 0 || this.ActualSystemData.KnownSystemData == null)
                return;
            foreach (SystemData200 gclass200 in list_9)
            {
                double num1 = this.gclass0_0.method_29(gclass200.KnownSystemData.X, gclass200.KnownSystemData.Y,
                    gclass200.KnownSystemData.Z, this.ActualSystemData.KnownSystemData.X, this.ActualSystemData.KnownSystemData.Y,
                    this.ActualSystemData.KnownSystemData.Z) - gclass200.double_3;
                if (this.ActualSystemData.double_4 == 0.0 || this.ActualSystemData.double_4 > num1)
                {
                    this.ActualSystemData.double_4 = num1;
                    double x = AuroraUtils.long_1 * num1;
                    double num2 = AuroraUtils.PI_Apprx * 4.0 * Math.Pow(x, 2.0);
                    this.ActualSystemData.double_5 = AuroraUtils.double_8 * gclass200.SupernovaForce / num2;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2550);
        }
    }

    public void method_27(Graphics graphics_0, Pen pen_0)
    {
        try
        {
            foreach (JumpPoint120 gclass120 in this.list_8)
            {
                if (gclass120.LinkedJumpPoint != null &&
                    this.Race.RacialSystemDictionary.ContainsKey(gclass120.LinkedJumpPoint.SystemData.SystemID))
                {
                    float x1 = (float)(this.double_9 + this.Race.double_1 / 2.0);
                    float y1 = (float)(this.double_10 + this.Race.double_1 / 2.0);
                    float x2 = (float)(this.Race.RacialSystemDictionary[gclass120.LinkedJumpPoint.SystemData.SystemID]
                        .double_9 + this.Race.double_1 / 2.0);
                    float y2 = (float)(this.Race.RacialSystemDictionary[gclass120.LinkedJumpPoint.SystemData.SystemID]
                        .double_10 + this.Race.double_1 / 2.0);
                    if ((gclass120.RacialJumpPointSurveys[this.Race.RaceID].MilitaryRestricted == 1 ||
                         gclass120.LinkedJumpPoint.RacialJumpPointSurveys[this.Race.RaceID].MilitaryRestricted == 1) &&
                        this.Race.chkMilitaryRestrictedJP == CheckState.Checked)
                    {
                        pen_0.Color = Color.Magenta;
                        pen_0.Width = 3f;
                    }
                    else if (gclass120.JumpGateStrength > 0 && gclass120.LinkedJumpPoint.JumpGateStrength > 0)
                    {
                        pen_0.Color = Color.Orange;
                        pen_0.Width = 3f;
                    }
                    else
                    {
                        pen_0.Color = Color.Green;
                        pen_0.Width = 2.5f;
                    }

                    graphics_0.DrawLine(pen_0, x1, y1, x2, y2);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2551);
        }
    }

    public void method_28(Graphics graphics_0, Font font_0, int int_37, Color color_0)
    {
        try
        {
            double double_10 = this.Race.double_1 * 0.2;
            double double_8 = this.Race.double_1 * 0.4 + this.double_9;
            double double_9 = this.Race.double_1 * 0.4 + this.double_10;
            if (this.int_11 == 1)
                double_9 = this.Race.double_1 * 0.65 + this.double_10;
            if (this.int_11 == 2)
                double_9 = this.Race.double_1 * 0.15 + this.double_10;
            if (this.int_11 == 3)
                double_9 = this.Race.double_1 * -0.1 + this.double_10;
            Color color_0_1 = AuroraUtils.color_16;
            if (this.bool_7)
                color_0_1 = Color.Blue;
            this.gclass0_0.method_529(graphics_0, color_0, 0, double_8, double_9, double_10);
            this.gclass0_0.method_528(graphics_0, font_0, color_0_1, double_8 + double_10 + 1.0, double_9 - 1.0, 25.0,
                25, int_37.ToString(), StringAlignment.Near, StringAlignment.Near);
            ++this.int_11;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2552);
        }
    }

    public void method_29(Graphics graphics_0, Font font_0, Color color_0)
    {
        try
        {
            double double_10 = this.Race.double_1 * (1.0 + this.int_12 * 0.25);
            double num = this.Race.double_1 * -(this.int_12 * 0.125);
            this.gclass0_0.method_529(graphics_0, color_0, 3, this.double_9 + num, this.double_10 + num, double_10);
            ++this.int_12;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2553);
        }
    }

    public void method_30(Graphics graphics_0, Font font_0, Color color_0, float[] float_0)
    {
        try
        {
            double double_10 = this.Race.double_1 * (1.0 + this.int_12 * 0.25);
            double num = this.Race.double_1 * -(this.int_12 * 0.125);
            this.gclass0_0.method_530(graphics_0, color_0, 3, this.double_9 + num, this.double_10 + num, double_10,
                float_0);
            ++this.int_12;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2554);
        }
    }

    public void method_31(ListView listView_0)
    {
        try
        {
            int num1 = 1;
            bool flag = false;
            listView_0.Items.Clear();
            if (this.int_18 > 0 || this.int_20 > 0)
            {
                this.gclass0_0.method_603(listView_0, "Ideal & Habitable Range Worlds", this.int_18.ToString(),
                    (this.int_20 - this.int_18).ToString(), null);
                flag = true;
            }

            if (this.int_21 > 0 || this.int_22 > 0)
            {
                this.gclass0_0.method_603(listView_0, "Normal & Low G Low Cost Worlds", this.int_21.ToString(),
                    (this.int_22 - this.int_21).ToString(), null);
                flag = true;
            }

            if (this.int_23 > 0 || this.int_24 > 0)
            {
                this.gclass0_0.method_603(listView_0, "Normal & Low G Medium Cost Worlds", this.int_23.ToString(),
                    (this.int_24 - this.int_23).ToString(), null);
                flag = true;
            }

            if (flag)
                this.gclass0_0.method_594(listView_0, "");
            if (this.int_29 > 0 || this.int_30 > 0)
                this.gclass0_0.method_603(listView_0, "Terrestrial & Dwarf Planets", this.int_29.ToString(),
                    this.int_30.ToString(), null);
            if (this.int_32 > 0 || this.int_31 > 0)
                this.gclass0_0.method_603(listView_0, "Superjovians & Gas Giants", this.int_32.ToString(),
                    this.int_31.ToString(), null);
            if (this.int_33 > 0 || this.int_34 > 0)
                this.gclass0_0.method_603(listView_0, "Moons & Asteroids", this.int_33.ToString(),
                    this.int_34.ToString(), null);
            if (this.int_35 > 0)
                this.gclass0_0.method_603(listView_0, "Comets", this.int_35.ToString(), "", null);
            this.gclass0_0.method_603(listView_0, "Surveyed & Total Bodies", this.int_26.ToString(),
                this.list_6.Count.ToString(), null);
            if (!this.bSurveyComplete)
            {
                int num2 = this.ActualSystemData.SurveyLocationDictionary.Values
                    .Where<SurveyLocation213>(gclass213_0 => gclass213_0.list_0.Contains(this.Race.RaceID))
                    .Count<SurveyLocation213>();
                this.gclass0_0.method_603(listView_0, "Unsurveyed Gravsurvey Locations", (30 - num2).ToString(), "",
                    null);
            }

            this.gclass0_0.method_594(listView_0, "");
            this.gclass0_0.method_603(listView_0, "Jump Point", "AU", "Bearing", null);
            foreach (JumpPoint120 object_1 in this.list_7)
            {
                string str = "  Unexplored";
                if (object_1.LinkedJumpPoint != null &&
                    this.Race.RacialSystemDictionary.ContainsKey(object_1.LinkedJumpPoint.SystemData.SystemID))
                    str = "  " + this.Race.RacialSystemDictionary[object_1.LinkedJumpPoint.SystemData.SystemID].Name;
                if (object_1.JumpGateStrength > 0)
                    str += " (S)";
                this.gclass0_0.method_602(listView_0, num1.ToString() + str,
                    AuroraUtils.smethod_44(object_1.Distance, 2), object_1.Bearing.ToString(), object_1);
                ++num1;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2555);
        }
    }

    public void method_32(Graphics graphics_0, Font font_0, double double_12)
    {
        try
        {
            float num1 = 8f;
            float num2 = 12f;
            int num3 = 1;
            double num4 = double_12 / 2.0;
            float num5 = (float)num4 - 6f;
            Star197 gclass197 = this.gclass0_0.StarDictionary.Values
                .Where<Star197>(gclass197_0 => gclass197_0.SystemData == this.ActualSystemData)
                .OrderBy<Star197, int>(gclass197_0 => gclass197_0.Component).FirstOrDefault<Star197>();
            SolidBrush solidBrush1 = new SolidBrush(Color.FromArgb(byte.MaxValue, gclass197.StellarType.Red,
                gclass197.StellarType.Green, gclass197.StellarType.Blue));
            RectangleF rect = new RectangleF(num5, num5, num2, num2);
            graphics_0.FillEllipse(solidBrush1, rect);
            if (this.list_7.Count == 0)
                return;
            double num6 = this.list_7.Max<JumpPoint120>(gclass120_0 => gclass120_0.Distance) * 1.1;
            double num7 = num4 / num6;
            this.list_7 = this.list_7.OrderBy<JumpPoint120, double>(gclass120_0 => gclass120_0.Distance)
                .ToList<JumpPoint120>();
            foreach (JumpPoint120 gclass120 in this.list_7)
            {
                SolidBrush solidBrush2 = new SolidBrush(Color.Red);
                if (gclass120.JumpGateStrength > 0)
                    solidBrush2 = new SolidBrush(Color.Orange);
                GClass221 gclass221 =
                    this.gclass0_0.method_592(num4, num4, gclass120.Distance * num7, gclass120.Bearing);
                float x = (float)gclass221.double_0 - num1 / 2f;
                float y = (float)gclass221.double_1 - num1 / 2f;
                rect = new RectangleF(x, y, num1, num1);
                graphics_0.FillEllipse(solidBrush2, rect);
                this.gclass0_0.method_528(graphics_0, font_0, AuroraUtils.color_16, x + (double)num1 + 1.0, y - 2.0,
                    20.0, 20, num3.ToString(), StringAlignment.Near, StringAlignment.Near);
                ++num3;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2556);
        }
    }

    public void method_33(Graphics graphics_0, Font font_0, bool bool_11)
    {
        try
        {
            this.int_12 = 1;
            this.int_11 = 0;
            this.method_6();
            if (bool_11 && (this.double_9 < 0.0 - this.Race.double_1 ||
                            this.double_9 > this.gclass0_0.double_2 + this.Race.double_1 ||
                            this.double_10 < 0.0 - this.Race.double_1 ||
                            this.double_10 > this.gclass0_0.double_3 + this.Race.double_1))
                return;
            SolidBrush solidBrush1 = new SolidBrush(Color.Green);
            if (this.ActualSystemData.KnownSystemData != null &&
                this.ActualSystemData.KnownSystemData.dictionary_0[1].SpectralClass == "BH")
                solidBrush1.Color = Color.Purple;
            if (this.bool_7)
                solidBrush1.Color = Color.Lime;
            if (this.ActualSystemData.SupernovaElapsedTime > 0.0)
                solidBrush1.Color = Color.White;
            Pen pen1 = new Pen(Color.Lime);
            graphics_0.FillEllipse(solidBrush1, (float)this.double_9, (float)this.double_10,
                (float)this.Race.double_1, (float)this.Race.double_1);
            graphics_0.DrawEllipse(pen1, (float)this.double_9, (float)this.double_10, (float)this.Race.double_1,
                (float)this.Race.double_1);
            int num1 = this.list_6.Count<SystemBodyData>(gclass1_0 =>
                gclass1_0.BodyClass != PlanetBodyClass.Comet && gclass1_0.BodyClass != PlanetBodyClass.Asteroid);
            if (num1 == 0 && this.ActualSystemData.SupernovaElapsedTime == 0.0)
            {
                double double_10 = this.Race.double_1 * 0.75;
                double num2 = this.Race.double_1 * 0.125;
                this.gclass0_0.method_529(graphics_0, Color.FromArgb(byte.MaxValue, AuroraUtils.color_19), 0,
                    this.double_9 + num2, this.double_10 + num2, double_10);
            }

            if (this.Race.chkSystemIconOnly == CheckState.Checked)
                return;
            if (this.Race.chkHabRangeWorldsLowG == CheckState.Checked && this.int_20 > 0 ||
                this.Race.chkHabRangeWorlds == CheckState.Checked && this.int_19 > 0)
            {
                int int_37 = this.int_19;
                if (this.Race.chkHabRangeWorldsLowG == CheckState.Checked)
                    int_37 = this.int_20;
                this.method_28(graphics_0, font_0, int_37, Color.Blue);
            }

            if (this.Race.chkLowCCLowG == CheckState.Checked && this.int_22 > 0 ||
                this.Race.chkLowCCNormalG == CheckState.Checked && this.int_21 > 0)
            {
                int int_37 = this.int_21;
                if (this.Race.chkLowCCLowG == CheckState.Checked)
                    int_37 = this.int_22;
                this.method_28(graphics_0, font_0, int_37, Color.Cyan);
            }

            if (this.Race.chkNumCometsPlanetlessSystem == CheckState.Checked && this.int_28 > 0 && num1 == 0)
                this.method_28(graphics_0, font_0, this.int_28, Color.Cornsilk);
            if (this.Race.chkUnexJP == CheckState.Checked && this.int_25 > 0)
                this.method_28(graphics_0, font_0, this.int_25, Color.Orange);
            if (this.Race.chkMediumCCLowG == CheckState.Checked && this.int_24 > 0 ||
                this.Race.chkMediumCCNormalG == CheckState.Checked && this.int_23 > 0)
            {
                int int_37 = this.int_23;
                if (this.Race.chkMediumCCLowG == CheckState.Checked)
                    int_37 = this.int_24;
                this.method_28(graphics_0, font_0, int_37, Color.SlateGray);
            }

            if (this.Race.chkSectors == CheckState.Checked && this.gclass62_0 != null)
            {
                pen1.Color = Color.FromArgb(byte.MaxValue, this.gclass62_0.color_0);
                pen1.Width = 5f;
                graphics_0.DrawEllipse(pen1, (float)this.double_9, (float)this.double_10,
                    (float)this.Race.double_1, (float)this.Race.double_1);
            }

            if (this.Race.chkJPSurveyStatus == CheckState.Checked && !this.bSurveyComplete)
                this.method_29(graphics_0, font_0, Color.Red);
            if (this.Race.chkUnexJP == CheckState.Checked && this.int_25 > 0)
                this.method_29(graphics_0, font_0, Color.Orange);
            if (this.Race.chkPopulatedSystem == CheckState.Checked && this.decimal_10 > 0M)
                this.method_29(graphics_0, font_0, Color.FromArgb(byte.MaxValue, AuroraUtils.color_20));
            if (this.Race.chkPossibleDormantJP == CheckState.Checked && this.ClosedWP == 1)
                this.method_29(graphics_0, font_0, Color.Yellow);
            if (this.Race.chkGroundSurveyLocations == CheckState.Checked && this.bool_9)
            {
                float[] float_0 = new float[2] { 4f, 2f };
                this.method_30(graphics_0, font_0, Color.LightSteelBlue, float_0);
            }

            if (this.Race.chkML == CheckState.Checked && this.bool_8)
            {
                float[] float_0 = new float[2] { 5f, 2f };
                this.method_30(graphics_0, font_0, Color.DeepSkyBlue, float_0);
            }

            if (this.Race.chkNavalHeadquarters == CheckState.Checked && this.int_17 > 0)
            {
                float[] float_0 = new float[2] { 10f, 3f };
                this.method_30(graphics_0, font_0, Color.Yellow, float_0);
            }

            if (this.Race.chkAetherRift == CheckState.Checked && this.bool_10)
            {
                float[] float_0 = new float[2] { 4f, 2f };
                this.method_30(graphics_0, font_0, Color.DarkOrchid, float_0);
            }

            if (this.Race.chkKnownAlienForces == CheckState.Checked &&
                this.auroraContactStatus_0 != AuroraContactStatus.None)
            {
                float[] float_0 = new float[2] { 3f, 2f };
                this.method_30(graphics_0, font_0, this.Race.ContactStatusColorDic[this.auroraContactStatus_0],
                    float_0);
            }

            if (this.Race.chkBlocked == CheckState.Checked && this.bNoAutoRoute)
            {
                float[] float_0 = new float[2] { 6f, 3f };
                this.method_30(graphics_0, font_0, Color.Magenta, float_0);
            }

            if (this.Race.chkMilitaryRestricted == CheckState.Checked && this.bMilitaryRestrictedSystem)
            {
                float[] float_0 = new float[2] { 2f, 1f };
                this.method_30(graphics_0, font_0, Color.Magenta, float_0);
            }

            if (this.Race.chkDisplayMineralSearch == CheckState.Checked && this.bMineralSearchFlag)
            {
                float[] float_0 = new float[2] { 4f, 3f };
                this.method_30(graphics_0, font_0, Color.DarkSeaGreen, float_0);
            }

            if (this.gclass3_0 != null && this.gclass3_0.genum95_0 > GEnum95.const_1)
            {
                float[] float_0 = new float[2] { 1f, 1f };
                Color color_0 = Color.Red;
                if (this.gclass3_0.genum95_0 == GEnum95.const_4)
                    color_0 = Color.DarkOrange;
                else if (this.gclass3_0.genum95_0 == GEnum95.const_3)
                    color_0 = Color.Orange;
                else if (this.gclass3_0.genum95_0 == GEnum95.const_2)
                    color_0 = Color.LightBlue;
                this.method_30(graphics_0, font_0, color_0, float_0);
            }

            string str1 = this.Name;
            if (this.Race.chkDistanceFromSelected == CheckState.Checked ||
                this.Race.chkDistanceFromSelectedMR == CheckState.Checked)
                str1 = $"{str1}  ({AuroraUtils.smethod_44(this.ActualSystemData.double_7 / 1000000000.0, 1)})";
            if (this.Race.chkDistanceRealSpace == CheckState.Checked)
                str1 = $"{str1}  ({AuroraUtils.smethod_44(this.ActualSystemData.double_7, 1)})";
            double num3 = font_0.Size / AuroraUtils.double_2;
            double num4 = AuroraUtils.double_3 * num3;
            double num5 = num4 * 2.0;
            int int_136_1 = (int)(num4 / 2.0);
            int num6 = (int)(25.0 * num3);
            int int_136_2 = (int)(15.0 * num3);
            this.gclass0_0.method_528(graphics_0, font_0, AuroraUtils.color_16, this.double_9 - num4,
                this.double_10 + this.Race.double_1 + 5.0, this.Race.double_1 + num5, int_136_1, str1,
                StringAlignment.Center, StringAlignment.Center);
            if (this.Race.chkNumWrecks == CheckState.Checked && this.ActualSystemData.int_10 > 0)
            {
                Size size = TextRenderer.MeasureText(str1, font_0);
                SolidBrush solidBrush2 = new SolidBrush(AuroraUtils.color_10);
                Pen pen2 = new Pen(AuroraUtils.color_10, 3f);
                double x1 = this.double_9 + this.Race.double_1 / 2.0 + size.Width / 2 + 5.0;
                double num7 = this.double_10 + this.Race.double_1 + 11.0;
                graphics_0.DrawLine(pen2, (float)x1, (float)num7, (float)x1 + AuroraUtils.int_63,
                    (float)num7 + AuroraUtils.int_63);
                graphics_0.DrawLine(pen2, (float)x1, (float)num7 + AuroraUtils.int_63, (float)x1 + AuroraUtils.int_63,
                    (float)num7);
                this.gclass0_0.method_528(graphics_0, font_0, AuroraUtils.color_10, x1 + AuroraUtils.int_63 + 2.0,
                    this.double_10 + this.Race.double_1 + 5.0, 50.0, 25, this.ActualSystemData.int_10.ToString(),
                    StringAlignment.Near, StringAlignment.Center);
            }

            int num8 = num6;
            if (this.Race.chkDiscoveryDate == CheckState.Checked)
            {
                this.gclass0_0.method_528(graphics_0, font_0, AuroraUtils.color_16, this.double_9 - num4,
                    this.double_10 + this.Race.double_1 + num8, this.Race.double_1 + num5, int_136_2,
                    this.Discovered, StringAlignment.Center, StringAlignment.Center);
                num8 += int_136_2;
            }

            if (this.Race.chkSurveyLocationPoints == CheckState.Checked ||
                this.Race.chkSupernovaImpactTime == CheckState.Checked &&
                this.ActualSystemData.SupernovaElapsedTime == 0.0)
            {
                string string_10 = "";
                if (this.Race.chkSurveyLocationPoints == CheckState.Checked)
                    string_10 = this.ActualSystemData.JumpPointSurveyPoints.ToString();
                if (this.Race.chkSupernovaImpactTime == CheckState.Checked &&
                    this.ActualSystemData.SupernovaElapsedTime == 0.0)
                {
                    if (this.Race.chkSurveyLocationPoints == CheckState.Checked)
                        string_10 += "  ";
                    string str2 = this.ActualSystemData.double_5 <= 1000000.0
                        ? (this.ActualSystemData.double_5 <= 1000.0
                            ? AuroraUtils.smethod_43(this.ActualSystemData.double_5)
                            : AuroraUtils.smethod_43(this.ActualSystemData.double_5 / 1000.0) + "k")
                        : AuroraUtils.smethod_44(this.ActualSystemData.double_5 / 1000000.0, 1) + "m";
                    if (this.ActualSystemData.double_4 > 1.0)
                        string_10 = $"{string_10}[{AuroraUtils.smethod_44(this.ActualSystemData.double_4, 1)}y - {str2}]";
                    else if (this.ActualSystemData.double_4 > 0.1)
                        string_10 =
                            $"{string_10}[{AuroraUtils.smethod_44(this.ActualSystemData.double_4 * 12.0, 1)}m - {str2}]";
                    else
                        string_10 =
                            $"{string_10}[{AuroraUtils.smethod_44(this.ActualSystemData.double_4 * 365.0, 1)}d - {str2}]";
                }

                this.gclass0_0.method_528(graphics_0, font_0, AuroraUtils.color_16, this.double_9 - num4,
                    this.double_10 + this.Race.double_1 + num8, this.Race.double_1 + num5, int_136_2,
                    string_10, StringAlignment.Center, StringAlignment.Center);
                num8 += int_136_2;
            }

            if (this.Race.chkSecurityStatus == CheckState.Checked && this.DangerRating > 0)
            {
                Color color_0 = AuroraUtils.color_16;
                if (this.decimal_11 < this.DangerRating)
                    color_0 = Color.Red;
                this.gclass0_0.method_528(graphics_0, font_0, color_0, this.double_9,
                    this.double_10 + this.Race.double_1 + num8, this.Race.double_1, int_136_2,
                    $"{this.DangerRating.ToString()}/{this.decimal_11.ToString()}", StringAlignment.Center,
                    StringAlignment.Center);
            }

            if (this.Race.chkSurveyedSystemBodies == CheckState.Checked && this.list_6.Count > 0)
                this.gclass0_0.method_528(graphics_0, font_0, AuroraUtils.color_16,
                    this.double_9 + this.Race.double_1 * 1.1, this.double_10 + this.Race.double_1 * 0.65,
                    this.Race.double_1, int_136_2, this.int_27.ToString() + "%", StringAlignment.Near,
                    StringAlignment.Near);
            bool flag = false;
            if (this.Race.gclass112_0 == null)
            {
                if (this.Race.chkAlienControlledSystems == CheckState.Checked && this.gclass110_0 != null &&
                    this.gclass110_0.ActualAlienRace != this.Race && this.gclass110_0.ActualAlienRace != null)
                    this.method_34(graphics_0, this.gclass110_0.ActualAlienRace);
            }
            else if (this.Race.gclass112_0.int_0 == 1)
            {
                if (this.Race.chkAlienControlledSystems == CheckState.Checked && this.gclass110_0 != null &&
                    this.gclass110_0.ActualAlienRace != this.Race && this.gclass110_0.ActualAlienRace != null)
                    this.method_34(graphics_0, this.gclass110_0.ActualAlienRace);
            }
            else if (this.Race.gclass112_0.int_0 == 2)
            {
                if (this.gclass110_0 == null)
                    this.method_34(graphics_0, this.Race);
            }
            else if (this.Race.gclass112_0.int_0 == 0 && this.Race.gclass112_0.gclass110_0 != null)
            {
                if (this.Race.gclass112_0.gclass110_0.dictionary_1.ContainsKey(this.ActualSystemData.SystemID))
                    this.method_34(graphics_0, this.Race.gclass112_0.gclass110_0.ActualAlienRace);
                flag = true;
            }

            if (!flag)
            {
                if (this.Race.SelectedClass != null && this.Race.chkClassIcon == CheckState.Checked)
                {
                    List<FCTShipData40> list = this.list_0
                        .Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass22_0 == this.Race.SelectedClass)
                        .ToList<FCTShipData40>();
                    if (this.Race.SelectedAdmin != null && this.Race.chkAdminIcon == CheckState.Checked)
                    {
                        List<FCTShipData40> second = this.Race.SelectedAdmin.method_1();
                        list = list.Intersect<FCTShipData40>(second).ToList<FCTShipData40>();
                    }

                    if (list.Count > 0)
                    {
                        RectangleF rect = new RectangleF((float)(this.double_9 + this.Race.double_1 / 1.8),
                            (float)(this.double_10 - this.Race.double_1 / 1.5), this.Race.float_0,
                            this.Race.float_0);
                        graphics_0.DrawImage(this.Race.ShipIconLoadedImg, rect);
                    }
                }
                else if (this.Race.SelectedAdmin != null && this.Race.chkAdminIcon == CheckState.Checked)
                {
                    if (this.list_0.Intersect<FCTShipData40>(this.Race.SelectedAdmin.method_1())
                            .Count<FCTShipData40>() > 0)
                    {
                        RectangleF rect = new RectangleF((float)(this.double_9 + this.Race.double_1 / 1.8),
                            (float)(this.double_10 - this.Race.double_1 / 1.5), this.Race.float_0,
                            this.Race.float_0);
                        graphics_0.DrawImage(this.Race.ShipIconLoadedImg, rect);
                    }
                }
                else if (this.Race.chkWarshipLocation == CheckState.Checked && this.int_13 > 0 ||
                         this.Race.chkAllFleetLocations == CheckState.Checked && this.int_14 > 0)
                {
                    RectangleF rect = new RectangleF((float)(this.double_9 + this.Race.double_1 / 1.8),
                        (float)(this.double_10 - this.Race.double_1 / 1.5), this.Race.float_0,
                        this.Race.float_0);
                    graphics_0.DrawImage(this.Race.ShipIconLoadedImg, rect);
                }
            }
            else if (this.gclass0_0.dictionary_28.Values.FirstOrDefault<GClass65>(gclass65_0 =>
                         gclass65_0.gclass21_1 == this.Race &&
                         gclass65_0.gclass21_0 == this.Race.gclass112_0.gclass110_0.ActualAlienRace &&
                         gclass65_0.decimal_3 >= this.gclass0_0.GameTime - this.Race.int_47 &&
                         gclass65_0.gclass200_0 == this.ActualSystemData) != null)
            {
                RectangleF rect = new RectangleF((float)(this.double_9 + this.Race.double_1 / 1.8),
                    (float)(this.double_10 - this.Race.double_1 / 1.5), this.Race.float_0,
                    this.Race.float_0);
                graphics_0.DrawImage(this.Race.gclass112_0.gclass110_0.ActualAlienRace.ShipIconLoadedImg, rect);
            }

            if (this.Race.chkShipyardComplexes != CheckState.Checked || this.int_16 <= 0)
                return;
            RectangleF rect1 = new RectangleF((float)(this.double_9 - this.Race.double_1 / 1.75),
                (float)(this.double_10 + this.Race.double_1 / 3.5), this.Race.float_0,
                this.Race.float_0);
            graphics_0.DrawImage(this.Race.SpaceStationPicLoadedImg, rect1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2557);
        }
    }

    public void method_34(Graphics graphics_0, GameRace gclass21_1)
    {
        try
        {
            RectangleF rect = new RectangleF((float)(this.double_9 - this.Race.double_1 / 2.0),
                (float)(this.double_10 - this.Race.double_1 / 3.0), this.Race.float_0,
                this.Race.float_0 * 0.667f);
            graphics_0.DrawImage(gclass21_1.FlagPicLoadedImg, rect);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3803);
        }
    }

    public int method_35()
    {
        try
        {
            List<PopulationData> list = this.gclass0_0.PopulationDataDictionary.Values
                .Where<PopulationData>(gclass146_0 => gclass146_0.gclass202_0 == this).ToList<PopulationData>();
            return list.Count == 0
                ? 0
                : (int)list.Max<PopulationData>(gclass146_0 =>
                    gclass146_0.method_62(AuroraProductionCategory.NavalHeadquarters));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2558);
            return 0;
        }
    }

    /// <summary>
    /// Filters and retrieves a list of <see cref="RacialSystemSurvey"/> based on the specified conditions.
    /// </summary>
    /// <param name="bool_11">A boolean value that determines the primary filtering condition.</param>
    /// <param name="bool_12">A boolean value that applies additional filtering criteria.</param>
    /// <returns>A filtered list of <see cref="RacialSystemSurvey"/> objects. Returns null if an exception occurs.</returns>
    public List<RacialSystemSurvey> method_36(bool bool_11, bool bool_12)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        RacialSystemSurvey.Class1192 class1192 = new RacialSystemSurvey.Class1192();
        // ISSUE: reference to a compiler-generated field
        class1192.gclass202_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1192.bool_0 = bool_11;
        // ISSUE: reference to a compiler-generated field
        class1192.bool_1 = bool_12;
        try
        {
            // TODO: This part is Clusterfucking slow. What the hell are we doing.
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return this.Race.RacialSystemDictionary.Values.Where<RacialSystemSurvey>(new RacialSystemSurvey.Class1193()
            {
                list_0 = this.gclass0_0.JumpPointDictionary.Values.Where<JumpPoint120>(class1192.method_0)
                    .Where<JumpPoint120>(class1192.method_1)
                    .Select<JumpPoint120, SystemData200>(gclass120_0 => gclass120_0.LinkedJumpPoint.SystemData)
                    .ToList<SystemData200>()
            }.method_0).Where<RacialSystemSurvey>(class1192.method_2).ToList<RacialSystemSurvey>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2559 /*0x09FF*/);
            return null;
        }
    }

    public List<RacialSystemSurvey> method_37(bool bool_11)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        RacialSystemSurvey.Class1195 class1195 = new RacialSystemSurvey.Class1195();
        // ISSUE: reference to a compiler-generated field
        class1195.gclass202_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1195.bool_0 = bool_11;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: reference to a compiler-generated method
            return this.Race.RacialSystemDictionary.Values.Where<RacialSystemSurvey>(new RacialSystemSurvey.Class1196()
            {
                list_0 = this.gclass0_0.JumpPointDictionary.Values.Where<JumpPoint120>(class1195.method_0)
                    .Where<JumpPoint120>(class1195.method_1)
                    .Select<JumpPoint120, SystemData200>(gclass120_0 => gclass120_0.LinkedJumpPoint.SystemData)
                    .ToList<SystemData200>()
            }.method_0).ToList<RacialSystemSurvey>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2560 /*0x0A00*/);
            return null;
        }
    }

    public List<RacialSystemSurvey> method_38(bool bool_11, GEnum96 genum96_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        RacialSystemSurvey.Class1198 class1198 = new RacialSystemSurvey.Class1198();
        // ISSUE: reference to a compiler-generated field
        class1198.gclass202_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1198.bool_0 = bool_11;
        // ISSUE: reference to a compiler-generated field
        class1198.genum96_0 = genum96_0;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            RacialSystemSurvey.Class1199 class1199 = new RacialSystemSurvey.Class1199()
            {
                class1198_0 = class1198
            };
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            class1199.list_0 = this.gclass0_0.JumpPointDictionary.Values
                .Where<JumpPoint120>(class1199.class1198_0.method_0).Where<JumpPoint120>(class1199.class1198_0.method_1)
                .Select<JumpPoint120, SystemData200>(gclass120_0 => gclass120_0.LinkedJumpPoint.SystemData)
                .ToList<SystemData200>();
            // ISSUE: reference to a compiler-generated method
            return this.Race.RacialSystemDictionary.Values.Where<RacialSystemSurvey>(class1199.method_0).ToList<RacialSystemSurvey>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2561);
            return null;
        }
    }

    public void method_39(ListView listView_0)
    {
        try
        {
            listView_0.Items.Clear();
            this.gclass0_0.method_603(listView_0, "No.", "Distance", "Bearing", "Destination");
            List<JumpPoint120> list = this.gclass0_0.JumpPointDictionary.Values
                .Where<JumpPoint120>(gclass120_0 =>
                    gclass120_0.SystemData == this.ActualSystemData &&
                    gclass120_0.RacialJumpPointSurveys.ContainsKey(this.Race.RaceID))
                .OrderBy<JumpPoint120, double>(gclass120_0 => gclass120_0.Distance).ToList<JumpPoint120>();
            int num = 1;
            foreach (JumpPoint120 object_1 in list)
            {
                if (object_1.RacialJumpPointSurveys[this.Race.RaceID].Charted == 1)
                {
                    string string_13 = "Unexplored";
                    if (object_1.RacialJumpPointSurveys[this.Race.RaceID].Explored == 1 && object_1.LinkedJumpPoint != null)
                        string_13 = this.Race.RacialSystemDictionary[object_1.LinkedJumpPoint.SystemData.SystemID].Name;
                    if (object_1.RacialJumpPointSurveys[this.Race.RaceID].MilitaryRestricted == 1)
                        string_13 += " (MR)";
                    if (object_1.JumpGateStrength > 0)
                        string_13 += " (S)";
                    this.gclass0_0.method_604(listView_0, num.ToString(),
                        AuroraUtils.smethod_60(object_1.Distance * AuroraUtils.double_14),
                        AuroraUtils.smethod_37(object_1.Bearing), string_13, object_1);
                    ++num;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2562);
        }
    }

    public void method_40(
        Label label_0,
        Label label_1,
        Label label_2,
        Label label_3,
        Label label_4)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            RacialSystemSurvey.Class1201 class1201 = new RacialSystemSurvey.Class1201();
            // ISSUE: reference to a compiler-generated field
            class1201.gclass202_0 = this;
            label_0.Text = this.ActualSystemData.Age.ToString() + " GY";
            label_1.Text = this.Discovered;
            label_2.Text = this.ActualSystemData.JumpPointSurveyPoints.ToString();
            int num1 = this.ActualSystemData.SurveyLocationDictionary.Values
                .Where<SurveyLocation213>(gclass213_0 => gclass213_0.list_0.Contains(this.Race.RaceID))
                .Count<SurveyLocation213>();
            label_3.Text = AuroraUtils.smethod_38(num1 / 30M * 100M) + "%";
            // ISSUE: reference to a compiler-generated field
            class1201.list_0 = this.gclass0_0.SystemBodyRecordDic.Values
                .Where<SystemBodyData>(gclass1_1 => gclass1_1.SystemData == this.ActualSystemData)
                .ToList<SystemBodyData>();
            // ISSUE: reference to a compiler-generated field
            if (class1201.list_0.Count == 0)
            {
                label_4.Text = "100%";
            }
            else
            {
                // ISSUE: reference to a compiler-generated method
                int num2 = this.gclass0_0.list_9.Where<GClass215>(class1201.method_0).Count<GClass215>();
                // ISSUE: reference to a compiler-generated field
                label_4.Text = AuroraUtils.smethod_38(num2 / (Decimal)class1201.list_0.Count * 100M) + "%";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2563);
        }
    }

    public void method_41(
        ListView listView_0,
        GameRace gclass21_1,
        GClass194 gclass194_0,
        CheckState checkState_0)
    {
        try
        {
            listView_0.Items.Clear();
            this.gclass0_0.method_628(listView_0, "Name", "Spectral", "Diameter", "Mass", "Luminosity", "Parent",
                "Period", "Distance", "Perihelion", "Aphelion", "Planets", "Moons", "Asteroids", "Comets", "Habitable",
                "Near-Hab", "Ecc", null);
            List<Star197> gclass197List = this.ActualSystemData.method_26();
            int num1 = 1;
            foreach (Star197 gclass197 in gclass197List)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                RacialSystemSurvey.Class1202 class1202 = new RacialSystemSurvey.Class1202();
                // ISSUE: reference to a compiler-generated field
                class1202.gclass197_0 = gclass197;
                string string_10 = this.Name;
                if (this.ActualSystemData.Stars > 1)
                    string_10 = $"{string_10}-{char.ConvertFromUtf32(64 /*0x40*/ + num1)}";
                string string_15 = "-";
                string string_16 = "-";
                string string_17 = "-";
                string string_18 = "-";
                string string_19 = "-";
                // ISSUE: reference to a compiler-generated field
                if (class1202.gclass197_0.OrbitingStar != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    string_15 = char.ConvertFromUtf32(64 /*0x40*/ + class1202.gclass197_0.OrbitingStar.Component);
                    // ISSUE: reference to a compiler-generated field
                    string_16 = AuroraUtils.smethod_50(class1202.gclass197_0.OrbitalPeriod);
                    // ISSUE: reference to a compiler-generated field
                    string_17 = AuroraUtils.smethod_1(class1202.gclass197_0.DistanceToParent);
                    // ISSUE: reference to a compiler-generated field
                    string_18 = AuroraUtils.smethod_1(class1202.gclass197_0.double_10);
                    // ISSUE: reference to a compiler-generated field
                    string_19 = AuroraUtils.smethod_1(class1202.gclass197_0.double_11);
                }

                int num2 = 0;
                int num3 = 0;
                int num4 = 0;
                int num5 = 0;
                int num6 = 0;
                int num7 = 0;
                int num8 = 0;
                // ISSUE: reference to a compiler-generated method
                foreach (SystemBodyData gclass1 in this.gclass0_0.SystemBodyRecordDic.Values
                             .Where<SystemBodyData>(class1202.method_0).ToList<SystemBodyData>())
                {
                    if (gclass1.BodyClass == PlanetBodyClass.Planet)
                        ++num2;
                    else if (gclass1.BodyClass == PlanetBodyClass.Moon)
                        ++num3;
                    else if (gclass1.BodyClass == PlanetBodyClass.Asteroid)
                        ++num4;
                    else if (gclass1.BodyClass == PlanetBodyClass.Comet)
                        ++num5;
                    gclass1.method_58(gclass21_1, gclass194_0, true);
                    if (checkState_0 == CheckState.Unchecked)
                    {
                        if (gclass1.ColonyCost >= 0M && gclass1.ColonyCost < 2M)
                            ++num6;
                        else if (gclass1.ColonyCost >= 0M && gclass1.ColonyCost < 3M)
                        {
                            if (gclass1.Gravity < gclass194_0.double_7)
                                ++num8;
                            else
                                ++num7;
                        }
                    }
                    else if (gclass1.MaxColonyCost >= 0M && gclass1.MaxColonyCost < 2M)
                        ++num6;
                    else if (gclass1.MaxColonyCost >= 0M && gclass1.MaxColonyCost < 3M)
                    {
                        if (gclass1.Gravity < gclass194_0.double_7)
                            ++num8;
                        else
                            ++num7;
                    }
                }

                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.gclass0_0.method_628(listView_0, string_10, class1202.gclass197_0.StellarType.StellarDescription,
                    AuroraUtils.smethod_50(class1202.gclass197_0.StellarType.method_1() / 1000000.0) + "m",
                    AuroraUtils.smethod_50(class1202.gclass197_0.StellarType.Mass),
                    AuroraUtils.smethod_50(class1202.gclass197_0.Luminosity), string_15, string_16, string_17,
                    string_18, string_19, num2.ToString(), num3.ToString(), num4.ToString(), num5.ToString(),
                    num6.ToString(), $"{num7.ToString()} / {num8.ToString()}",
                    AuroraUtils.smethod_50(class1202.gclass197_0.Eccentricity), class1202.gclass197_0);
                ++num1;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2564);
        }
    }

    public bool method_42()
    {
        try
        {
            if (this.ActualSystemData.SurveyLocationDictionary.Values
                    .Where<SurveyLocation213>(gclass213_0 => gclass213_0.list_0.Contains(this.Race.RaceID))
                    .Count<SurveyLocation213>() != 30)
                return false;
            this.gclass0_0.gclass92_0.method_2(EventType.const_22, "Gravitational survey completed in " + this.Name,
                this.Race, this.ActualSystemData, 0.0, 0.0, AuroraEventCategory.System);
            this.bSurveyComplete = true;
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2565);
            return false;
        }
    }

    public bool method_43()
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            RacialSystemSurvey.Class1203 class1203 = new RacialSystemSurvey.Class1203();
            // ISSUE: reference to a compiler-generated field
            class1203.gclass202_0 = this;
            // ISSUE: reference to a compiler-generated field
            class1203.list_0 = this.gclass0_0.SystemBodyRecordDic.Values
                .Where<SystemBodyData>(gclass1_1 => gclass1_1.SystemData == this.ActualSystemData)
                .ToList<SystemBodyData>();
            // ISSUE: reference to a compiler-generated field
            if (class1203.list_0.Count == 0)
                return true;
            // ISSUE: reference to a compiler-generated method
            this.int_26 = this.gclass0_0.list_9.Where<GClass215>(class1203.method_0).Count<GClass215>();
            // ISSUE: reference to a compiler-generated field
            return this.int_26 == class1203.list_0.Count;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2566);
            return false;
        }
    }

    public void method_44()
    {
        try
        {
            foreach (SurveyLocation213 gclass213 in this.ActualSystemData.SurveyLocationDictionary.Values)
            {
                gclass213.method_0(this.Race);
                this.method_45(gclass213.LocationNumber, null, null);
            }

            this.bSurveyComplete = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2567);
        }
    }

    public bool method_45(int int_37, GameRace gclass21_1, FleetData gclass85_1)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        RacialSystemSurvey.Class1204 class1204 = new RacialSystemSurvey.Class1204();
        // ISSUE: reference to a compiler-generated field
        class1204.gclass202_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1204.gclass21_0 = gclass21_1;
        try
        {
            bool flag = false;
            // ISSUE: reference to a compiler-generated method
            foreach (JumpPoint120 gclass120 in this.gclass0_0.JumpPointDictionary.Values
                         .Where<JumpPoint120>(class1204.method_0).ToList<JumpPoint120>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                RacialSystemSurvey.Class1205 class1205 = new RacialSystemSurvey.Class1205();
                // ISSUE: reference to a compiler-generated field
                class1205.gclass120_0 = gclass120;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (this.ActualSystemData.SurveyLocationDictionary.Values.Where<SurveyLocation213>(new RacialSystemSurvey.Class1206()
                        {
                            double_0 = Math.Pow(class1205.gclass120_0.XCoord, 2.0) +
                                       Math.Pow(class1205.gclass120_0.YCoord, 2.0)
                        }.method_0).OrderBy<SurveyLocation213, double>(class1205.method_0)
                        .FirstOrDefault<SurveyLocation213>().LocationNumber == int_37 &&
                    class1205.gclass120_0.RacialJumpPointSurveys.ContainsKey(this.Race.RaceID) &&
                    class1205.gclass120_0.RacialJumpPointSurveys[this.Race.RaceID].Charted == 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    class1205.gclass120_0.RacialJumpPointSurveys[this.Race.RaceID].Charted = 1;
                    // ISSUE: reference to a compiler-generated field
                    if (class1204.gclass21_0 == null)
                    {
                        if (gclass85_1 != null)
                        {
                            gclass85_1.method_16(AuroraMeasurementType.JumpPointsDiscovered, 1M);
                            gclass85_1.method_17(AuroraMeasurementType.JumpPointsDiscovered, null, null, "");
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            this.gclass0_0.gclass92_0.method_2(EventType.const_82,
                                $"{gclass85_1.method_15()} discovered a new jump point in {this.Name}", this.Race,
                                this.ActualSystemData, class1205.gclass120_0.XCoord, class1205.gclass120_0.YCoord,
                                AuroraEventCategory.JumpPoint);
                        }

                        flag = true;
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        this.gclass0_0.gclass92_0.method_2(EventType.const_82,
                            $"New jump point detected in {this.Name} as a result of survey data provided by {class1204.gclass21_0.PerceivedAliens.Values.Where<AlienRaceInfo>(class1204.func_0 ?? (class1204.func_0 = class1204.method_1)).Select<AlienRaceInfo, string>(gclass110_0 => gclass110_0.AlienRaceName).FirstOrDefault<string>()}",
                            this.Race, this.ActualSystemData, class1205.gclass120_0.XCoord,
                            class1205.gclass120_0.YCoord, AuroraEventCategory.JumpPoint);
                    }
                }
            }

            return flag;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2568);
            return false;
        }
    }

    public List<PopulationData> method_46()
    {
        return this.gclass0_0.PopulationDataDictionary.Values
            .Where<PopulationData>(gclass146_0 =>
                gclass146_0.RaceData == this.Race && gclass146_0.gclass202_0 == this)
            .OrderByDescending<PopulationData, Decimal>(gclass146_0 => gclass146_0.decimal_30).ToList<PopulationData>();
    }

    public GClass221 method_47(double double_12, double double_13)
    {
        return new GClass221()
        {
            double_0 = (double_12 + this.double_3) / this.KmPerPixel + this.gclass0_0.double_4,
            double_1 = (double_13 + this.double_4) / this.KmPerPixel + this.gclass0_0.double_5
        };
    }
}