// Decompiled with JetBrains decompiler
// Type: GClass3
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public partial class GClass3
{
    private GClass0 gclass0_0;
    private RacialSystemSurvey gclass202_0;
    public GEnum95 genum95_0 = GEnum95.const_1;
    public GEnum96 genum96_0 = GEnum96.const_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public int int_3;
    public Decimal decimal_0;
    public Decimal decimal_1;

    public GClass3(GClass0 gclass0_1, RacialSystemSurvey gclass202_1)
    {
        this.gclass0_0 = gclass0_1;
        this.gclass202_0 = gclass202_1;
    }

    public void method_0(List<FleetData> list_0, List<Contact> list_1, List<Contact> list_2)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass3.Class417 class417 = new GClass3.Class417();
            // ISSUE: reference to a compiler-generated field
            class417.gclass3_0 = this;
            List<FleetData> list1 = list_0.Where<FleetData>(gclass85_0 => gclass85_0.System == this.gclass202_0)
                .ToList<FleetData>();
            if (list1.Count == 0)
                return;
            List<ShipData> list2 = list1.SelectMany<FleetData, ShipData>(gclass85_0 => gclass85_0.method_176())
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass22_0.ShieldStrength > 0).ToList<ShipData>();
            if (list2.Count == 0)
                return;
            int num1 = this.gclass202_0.Race.method_166(GEnum41.const_0);
            // ISSUE: reference to a compiler-generated field
            class417.double_0 = num1 * 2000000;
            list2.Select<ShipData, FleetData>(gclass40_0 => gclass40_0.gclass85_0).Distinct<FleetData>()
                .Count<FleetData>();
            List<Contact> list3 = list_1
                .Where<Contact>(gclass65_0 => gclass65_0.System == this.gclass202_0.ActualSystem)
                .ToList<Contact>();
            List<Contact> list4 = list_2
                .Where<Contact>(gclass65_0 => gclass65_0.System == this.gclass202_0.ActualSystem)
                .ToList<Contact>();
            Func<Contact, bool> predicate = gclass65_0 => gclass65_0.LastUpdate == this.gclass0_0.GameTime;
            List<Contact> list5 = list3.Where<Contact>(predicate).ToList<Contact>();
            List<Contact> list6 = list4.Where<Contact>(gclass65_0 => gclass65_0.LastUpdate == this.gclass0_0.GameTime)
                .ToList<Contact>();
            List<JumpPoint> list7 = this.gclass0_0.JumpPointDictionary.Values
                .Where<JumpPoint>(gclass120_0 => gclass120_0.SystemData == this.gclass202_0.ActualSystem)
                .ToList<JumpPoint>();
            foreach (FleetData gclass85 in list1)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class418 class418 = new GClass3.Class418();
                // ISSUE: reference to a compiler-generated field
                class418.class417_0 = class417;
                // ISSUE: reference to a compiler-generated field
                class418.gclass85_0 = gclass85;
                // ISSUE: reference to a compiler-generated method
                List<ShipData> list8 = list2.Where<ShipData>(class418.method_0).ToList<ShipData>();
                if (list8.Count != 0)
                {
                    bool flag = false;
                    if (list8.Count<ShipData>(gclass40_0 =>
                            this.gclass0_0.GameTime - gclass40_0.decimal_18 < 86400M) > 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated method
                        if (list7.Count<JumpPoint>(class418.method_1) > 0)
                        {
                            flag = true;
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated method
                            int num2 = list5.Count<Contact>(class418.method_2);
                            // ISSUE: reference to a compiler-generated method
                            int num3 = list6.Count<Contact>(class418.method_3);
                            if (num2 > 0)
                                flag = true;
                            else if (num3 > 0 && this.genum95_0 >= GEnum95.const_4)
                                flag = true;
                            else if (num3 > 0 && list6.Count<Contact>(gclass65_0 =>
                                         gclass65_0.ContactType == AuroraContactType.Ship &&
                                         gclass65_0.ContactMethod == ContactDetectMethod.const_3) > 0)
                                flag = true;
                        }
                    }

                    if (!flag)
                    {
                        foreach (ShipData gclass40 in list8)
                        {
                            gclass40.bool_10 = false;
                            gclass40.decimal_3 = 0M;
                        }
                    }
                    else
                    {
                        foreach (ShipData gclass40 in list8)
                            gclass40.bool_10 = true;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3290);
        }
    }

    public void method_1(List<FleetData> list_0, List<Contact> list_1, List<Contact> list_2)
    {
        try
        {
            List<FleetData> list1 = list_0.Where<FleetData>(gclass85_0 => gclass85_0.System == this.gclass202_0)
                .ToList<FleetData>();
            if (list1.Count == 0)
                return;
            List<ShipData> list2 = list1.SelectMany<FleetData, ShipData>(gclass85_0 => gclass85_0.method_176())
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass22_0.ActiveSensorStrength > 0).ToList<ShipData>();
            if (list2.Count == 0)
                return;
            list2.Select<ShipData, FleetData>(gclass40_0 => gclass40_0.gclass85_0).Distinct<FleetData>()
                .Count<FleetData>();
            List<Contact> list3 = list_1
                .Where<Contact>(gclass65_0 => gclass65_0.System == this.gclass202_0.ActualSystem)
                .ToList<Contact>();
            List<Contact> list4 = list_2
                .Where<Contact>(gclass65_0 => gclass65_0.System == this.gclass202_0.ActualSystem)
                .ToList<Contact>();
            Func<Contact, bool> predicate = gclass65_0 => gclass65_0.LastUpdate == this.gclass0_0.GameTime;
            List<Contact> list5 = list3.Where<Contact>(predicate).ToList<Contact>();
            List<Contact> list6 = list4.Where<Contact>(gclass65_0 => gclass65_0.LastUpdate == this.gclass0_0.GameTime)
                .ToList<Contact>();
            foreach (FleetData gclass85 in list1)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class419 class419 = new GClass3.Class419();
                // ISSUE: reference to a compiler-generated field
                class419.gclass3_0 = this;
                // ISSUE: reference to a compiler-generated field
                class419.gclass85_0 = gclass85;
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class420 class420 = new GClass3.Class420();
                // ISSUE: reference to a compiler-generated field
                class420.class419_0 = class419;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                List<ShipData> list7 = list2.Where<ShipData>(class420.class419_0.method_0)
                    .ToList<ShipData>();
                if (list7.Count != 0)
                {
                    foreach (ShipData gclass40 in list7)
                        gclass40.bool_8 = false;
                    // ISSUE: reference to a compiler-generated field
                    class420.double_0 = list7
                        .SelectMany<ShipData, GClass228>(gclass40_0 => gclass40_0.gclass22_0.dictionary_0.Values)
                        .Where<GClass228>(gclass228_0 =>
                            gclass228_0.gclass230_0.gclass231_0.ComponentTypeID ==
                            AuroraComponentType.ActiveSearchSensors)
                        .Max<GClass228>(gclass228_0 => gclass228_0.gclass230_0.double_0);
                    // ISSUE: reference to a compiler-generated method
                    int num1 = list5.Count<Contact>(class420.method_0);
                    // ISSUE: reference to a compiler-generated method
                    int num2 = list6.Count<Contact>(class420.method_1);
                    double num3;
                    if (list7.Count<ShipData>(gclass40_0 =>
                            gclass40_0.gclass22_0.AutomatedClassDesign.StealthDesign > StealthDesignType.const_0) == 0)
                    {
                        num3 = num1 <= 0
                            ? (num2 <= 0 || this.genum95_0 < GEnum95.const_4
                                ? (num2 > 0 || list5.Count > 0 ? 250.0 : (list6.Count <= 0 ? 30.0 : 100.0))
                                : 1000.0)
                            : 1000.0;
                    }
                    else
                    {
                        int num4 = 0;
                        int num5 = 0;
                        int num6 = 0;
                        int num7 = 0;
                        int num8 = list7.Count<ShipData>(gclass40_0 =>
                            this.gclass0_0.GameTime - gclass40_0.decimal_18 < 120M);
                        if (num8 == 0)
                        {
                            // ISSUE: object of a compiler-generated type is created
                            // ISSUE: variable of a compiler-generated type
                            GClass3.Class421 class421 = new GClass3.Class421()
                            {
                                class420_0 = class420
                            };
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class421.double_0 = class421.class420_0.class419_0.gclass85_0.method_159();
                            // ISSUE: reference to a compiler-generated method
                            num4 = list5.Count<Contact>(class421.method_0);
                            if (num4 == 0)
                            {
                                // ISSUE: object of a compiler-generated type is created
                                // ISSUE: variable of a compiler-generated type
                                GClass3.Class422 class422 = new GClass3.Class422()
                                {
                                    class421_0 = class421
                                };
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class422.double_0 =
                                    class422.class421_0.class420_0.class419_0.gclass85_0.method_158(100M);
                                // ISSUE: reference to a compiler-generated method
                                num5 = list5.Count<Contact>(class422.method_0);
                                if (num4 == 0)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated method
                                    num6 = list6.Count<Contact>(class422.class421_0.method_1);
                                    if (num6 == 0)
                                    {
                                        // ISSUE: reference to a compiler-generated method
                                        num7 = list6.Count<Contact>(class422.method_1);
                                    }
                                }
                            }
                        }

                        num3 = num4 > 0 || num6 > 0 || num5 > 0 || num8 > 0
                            ? 1000.0
                            : (num7 <= 0 || this.genum95_0 < GEnum95.const_4 ? (list5.Count <= 0 ? 5.0 : 25.0) : 100.0);
                    }

                    if (AuroraUtils.GetRandomInteger(1000) <= num3)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class420.class419_0.gclass85_0.NPRSomething.method_4(list7);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 58);
        }
    }

    public void method_2(List<FleetData> list_0, List<GroundUnitFormationData> list_1, List<Contact> list_2)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass3.Class423 class423 = new GClass3.Class423();
            // ISSUE: reference to a compiler-generated field
            class423.gclass3_0 = this;
            List<Contact> list1 = list_2
                .Where<Contact>(gclass65_0 => gclass65_0.System == this.gclass202_0.ActualSystem)
                .ToList<Contact>();
            if (list1.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated field
            class423.list_0 = this.gclass0_0.FleetDictionary.Values
                .Where<FleetData>(gclass85_0 => gclass85_0.OrbitingBody != null && gclass85_0.method_35())
                .SelectMany<FleetData, ShipData>(gclass85_0 => gclass85_0.method_176()).ToList<ShipData>();
            // ISSUE: reference to a compiler-generated method
            List<Contact> list2 = list1.Where<Contact>(gclass65_0 => gclass65_0.TargetShip != null)
                .Where<Contact>(class423.method_0).ToList<Contact>();
            List<Contact> list3 = list1.Except<Contact>(list2).ToList<Contact>();
            List<GroundUnitFormationElement> list4 = list_1.Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.PopulationData != null)
                .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.PopulationData.gclass202_0 == this.gclass202_0)
                .SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 => gclass103_0.ElementList).Where<GroundUnitFormationElement>(gclass39_0 =>
                    gclass39_0.GroundUnitClass.gclass230_0 != null && gclass39_0.list_0.Count < gclass39_0.UnitCount)
                .ToList<GroundUnitFormationElement>();
            List<FleetData> list5 = list_0.Where<FleetData>(gclass85_0 => gclass85_0.System == this.gclass202_0)
                .ToList<FleetData>();
            if (list5.Count == 0 && list4.Count == 0)
                return;
            List<ShipData> list6 = list5.SelectMany<FleetData, ShipData>(gclass85_0 => gclass85_0.method_176())
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass22_0.ProtectionValue > 0M && gclass40_0.int_13 == 0)
                .OrderBy<ShipData, int>(gclass40_0 => gclass40_0.gclass85_0.FleetID)
                .ThenByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.gclass22_0.Size)
                .ToList<ShipData>();
            if (list6.Count == 0 && list4.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated field
            class423.list_1 = list3
                .Where<Contact>(gclass65_0 =>
                    gclass65_0.ContactMethod == ContactDetectMethod.const_0 && gclass65_0.ContactType == AuroraContactType.Ship)
                .Select<Contact, ShipData>(gclass65_0 => gclass65_0.TargetShip).ToList<ShipData>();
            List<MissileSalvo> list7 = list3
                .Where<Contact>(gclass65_0 =>
                    gclass65_0.ContactMethod == ContactDetectMethod.const_0 &&
                    gclass65_0.ContactType == AuroraContactType.Salvo)
                .Select<Contact, MissileSalvo>(gclass65_0 => gclass65_0.TargetSalvo).ToList<MissileSalvo>();
            List<Contact> list8 = list3.Where<Contact>(gclass65_0 =>
                    (gclass65_0.ContactMethod == ContactDetectMethod.const_0 &&
                     (gclass65_0.ContactType == AuroraContactType.STOGroundUnit ||
                      gclass65_0.ContactType == AuroraContactType.Shipyard) ||
                     gclass65_0.ContactType == AuroraContactType.Population) && gclass65_0.TargetPopulation != null)
                .ToList<Contact>();
            // ISSUE: reference to a compiler-generated field
            if (class423.list_1.Count == 0 && list7.Count == 0 && list8.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated field
            class423.gclass194_0 = this.gclass202_0.Race.method_164();
            // ISSUE: reference to a compiler-generated field
            if (this.gclass202_0.Race.SpecialNPRID == SpecialNPRIDs.const_0 && class423.gclass194_0.int_2 < 50)
                list8 = list8.Where<Contact>(gclass65_0 =>
                    gclass65_0.ContactType == AuroraContactType.STOGroundUnit ||
                    gclass65_0.ContactType == AuroraContactType.Shipyard ||
                    gclass65_0.TargetPopulation.Population == 0M).ToList<Contact>();
            else if (this.gclass202_0.Race.SpecialNPRID == SpecialNPRIDs.Eldar ||
                     this.gclass202_0.Race.SpecialNPRID == SpecialNPRIDs.StarSwarm)
                list8 = list8.Where<Contact>(gclass65_0 =>
                    gclass65_0.ContactType == AuroraContactType.STOGroundUnit ||
                    gclass65_0.ContactType == AuroraContactType.Shipyard).ToList<Contact>();
            // ISSUE: reference to a compiler-generated field
            if (class423.gclass194_0.int_2 < 80 /*0x50*/)
            {
                // ISSUE: reference to a compiler-generated method
                list8 = list8.Where<Contact>(class423.method_1).ToList<Contact>();
            }

            List<GClass13> source1 = new List<GClass13>();
            foreach (Contact gclass65 in list8)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class424 class424 = new GClass3.Class424();
                // ISSUE: reference to a compiler-generated field
                class424.gclass65_0 = gclass65;
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class434 class434 = new GClass3.Class434();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                class434.gclass13_0 = source1.FirstOrDefault<GClass13>(class424.method_0);
                // ISSUE: reference to a compiler-generated field
                if (class434.gclass13_0 == null)
                {
                    // ISSUE: reference to a compiler-generated field
                    class434.gclass13_0 = new GClass13(this.gclass0_0);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class434.gclass13_0.gclass146_0 = class424.gclass65_0.TargetPopulation;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class434.gclass13_0.double_1 = class434.gclass13_0.gclass146_0.method_87();
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class434.gclass13_0.double_2 = class434.gclass13_0.gclass146_0.method_88();
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    class434.gclass13_0.gclass113_0 =
                        class424.gclass65_0.DetectRace.dictionary_13.Values
                            .FirstOrDefault<GClass113>(class434.method_0);
                    // ISSUE: reference to a compiler-generated field
                    source1.Add(class434.gclass13_0);
                }

                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (!class434.gclass13_0.dictionary_0.ContainsKey(class424.gclass65_0.ContactType))
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class434.gclass13_0.dictionary_0.Add(class424.gclass65_0.ContactType, class424.gclass65_0);
                }
            }

            foreach (GClass13 gclass13 in source1)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class435 class435 = new GClass3.Class435();
                // ISSUE: reference to a compiler-generated field
                class435.class423_0 = class423;
                // ISSUE: reference to a compiler-generated field
                class435.gclass13_0 = gclass13;
                // ISSUE: reference to a compiler-generated method
                if (this.gclass0_0.Populations.Values.Where<PopulationData>(class435.method_0)
                        .Sum<PopulationData>(gclass146_0 => gclass146_0.method_190()) > 1000M)
                {
                    // ISSUE: reference to a compiler-generated field
                    class435.gclass13_0.bool_2 = true;
                }

                // ISSUE: reference to a compiler-generated field
                class435.gclass13_0.method_1();
                // ISSUE: reference to a compiler-generated field
                class435.gclass13_0.dictionary_0.ContainsKey(AuroraContactType.STOGroundUnit);
            }

            List<GClass13> list9 = source1
                .Where<GClass13>(gclass13_0 => gclass13_0.double_0 > 0.0 && !gclass13_0.bool_1)
                .OrderByDescending<GClass13, double>(gclass13_0 => gclass13_0.double_0).ToList<GClass13>();
            List<FleetData> list10 = list5.SelectMany<FleetData, ShipData>(gclass85_0 => gclass85_0.method_176())
                .Where<ShipData>(gclass40_0 => this.gclass0_0.GameTime - gclass40_0.decimal_21 < 300M)
                .Select<ShipData, FleetData>(gclass40_0 => gclass40_0.gclass85_0).Distinct<FleetData>()
                .ToList<FleetData>();
            List<FleetData> source2 = new List<FleetData>();
            if (list10.Count > 0)
            {
                foreach (FleetData gclass85 in list10)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: reference to a compiler-generated method
                    source2.AddRange(list5.Where<FleetData>(new GClass3.Class436()
                    {
                        class423_0 = class423,
                        gclass85_0 = gclass85
                    }.method_0).ToList<FleetData>());
                }

                source2 = source2.Distinct<FleetData>().ToList<FleetData>();
            }

            foreach (ShipData gclass40 in list6)
            {
                gclass40.gclass5_0.gclass71_0 = gclass40.method_213(0M, null);
                gclass40.gclass5_0.double_2 = gclass40.method_220();
                gclass40.gclass5_0.double_3 = gclass40.gclass5_0.gclass71_0.double_0;
                if (gclass40.gclass5_0.double_2 > gclass40.gclass5_0.double_3)
                    gclass40.gclass5_0.double_3 = gclass40.gclass5_0.double_2;
                gclass40.gclass5_0.gclass72_0 = gclass40.method_214();
                if (gclass40.gclass5_0.gclass72_0 != null)
                    gclass40.gclass5_0.double_4 = (double)gclass40.gclass5_0.gclass72_0.decimal_0;
                gclass40.gclass5_0.bool_0 = false;
                gclass40.int_17 = 0;
                if (gclass40.gclass22_0.AutomatedClassDesign.MissileDesignType == MissileDesignType.const_3 && gclass40.list_12.Count == 0 &&
                    this.gclass0_0.GameTime - gclass40.gclass85_0.LastFleetDamageTime > 900M)
                    gclass40.int_17 = 1;
            }

            List<ShipData> list11 = list6
                .Where<ShipData>(gclass40_0 =>
                    gclass40_0.gclass5_0.double_3 > 0.0 || gclass40_0.gclass5_0.double_4 > 0.0).ToList<ShipData>();
            if (list11.Count == 0 && list4.Count == 0)
                return;
            List<JumpPoint> list12 = this.gclass0_0.JumpPointDictionary.Values
                .Where<JumpPoint>(gclass120_0 => gclass120_0.SystemData == this.gclass202_0.ActualSystem)
                .Where<JumpPoint>(gclass120_0 =>
                    gclass120_0.RacialJumpPointSurveys.ContainsKey(this.gclass202_0.Race.RaceID))
                .Where<JumpPoint>(gclass120_0 =>
                    gclass120_0.RacialJumpPointSurveys[this.gclass202_0.Race.RaceID].Charted == 1).ToList<JumpPoint>();
            // ISSUE: reference to a compiler-generated method
            List<GClass117> list13 = this.gclass202_0.Race.dictionary_12.Values
                .Where<GClass117>(class423.method_2).ToList<GClass117>();
            List<GClass116> gclass116List = new List<GClass116>();
            foreach (GClass117 gclass117 in list13)
            {
                gclass117.method_5();
                gclass117.method_4(gclass116List);
            }

            foreach (GClass116 gclass116 in gclass116List)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class437 class437 = new GClass3.Class437();
                Decimal num1 =
                    gclass116.list_0.Sum<GClass117>(gclass117_0 => gclass117_0.gclass115_0.gclass22_0.Size);
                Decimal num2 = gclass116.list_0.Sum<GClass117>(gclass117_0 => gclass117_0.gclass40_0.method_170());
                gclass116.int_0 = (int)(num2 / num1 * 1000M);
                // ISSUE: reference to a compiler-generated field
                class437.list_0 = gclass116.list_0
                    .Select<GClass117, ShipData>(gclass117_0 => gclass117_0.gclass40_0).ToList<ShipData>();
                // ISSUE: reference to a compiler-generated method
                gclass116.list_1 = this.gclass0_0.MissileSalvoes.Values.Where<MissileSalvo>(class437.method_0)
                    .ToList<MissileSalvo>();
                foreach (JumpPoint gclass120 in list12)
                {
                    if (this.gclass0_0.GetDistanceBetween(gclass120.XCoord, gclass120.YCoord, gclass116.double_0,
                            gclass116.double_1) < gclass116.int_1 * 30)
                    {
                        gclass116.bool_2 = true;
                        if (gclass116.list_1.Count > 0 && this.gclass0_0.GameTime -
                            gclass116.list_1.Min<MissileSalvo>(gclass132_0 => gclass132_0.decimal_0) > 30M)
                            gclass116.bool_3 = true;
                    }
                }
            }

            foreach (ShipData gclass40 in list11
                         .Where<ShipData>(gclass40_0 => gclass40_0.gclass5_0.double_4 > 0.0)
                         .ToList<ShipData>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class438 class438 = new GClass3.Class438();
                // ISSUE: reference to a compiler-generated field
                class438.class423_0 = class423;
                // ISSUE: reference to a compiler-generated field
                class438.gclass40_0 = gclass40;
                bool flag = false;
                // ISSUE: reference to a compiler-generated field
                if (class438.gclass40_0.gclass5_0.gclass72_0.list_0.Count <= 0)
                {
                    double num3 = -1.0;
                    double num4 = -1.0;
                    if (list7.Count > 0)
                    {
                        // ISSUE: reference to a compiler-generated method
                        num3 = list7.Min<MissileSalvo>(class438.method_0);
                    }

                    if (gclass116List.Count > 0)
                    {
                        // ISSUE: reference to a compiler-generated method
                        num4 = gclass116List.Min<GClass116>(class438.method_1);
                    }

                    if (num3 > -1.0 && num3 < 1000000.0 || num4 > -1.0 && num4 < AuroraUtils.int_14)
                    {
                        flag = true;
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if ((num3 == -1.0 || num3 > 10000000.0) && num4 > -1.0 &&
                            num4 < class438.gclass40_0.gclass5_0.double_4 &&
                            class438.gclass40_0.gclass5_0.gclass72_0.list_1.Count == 0)
                            flag = true;
                    }

                    if (flag)
                    {
                        // ISSUE: reference to a compiler-generated field
                        foreach (FCTSquadronData70 gclass70_0 in class438.gclass40_0.ChildSquadronDictionary.Values)
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (class438.gclass40_0.gclass22_0.MagazineCapacity > 0M)
                                gclass70_0.ParentShipData.gclass85_0.method_71(gclass70_0, OperationalGroupID.MissileFighterSquadron);
                            else
                                gclass70_0.ParentShipData.gclass85_0.method_71(gclass70_0, OperationalGroupID.BeamFighterSquadron);
                        }
                    }
                }
            }

            foreach (ShipData gclass40 in list11)
            {
                if (gclass40.gclass5_0.gclass71_0.double_0 != 0.0 || gclass40.gclass5_0.double_4 != 0.0)
                {
                    foreach (GClass116 gclass116 in gclass116List)
                    {
                        if (this.gclass0_0.GetDistanceBetween(gclass116.double_0, gclass116.double_1,
                                gclass40.gclass85_0.XCoord, gclass40.gclass85_0.YCoord) <
                            gclass40.gclass5_0.gclass71_0.double_0)
                        {
                            double num5 = 1.0;
                            if (gclass116.int_0 > 0)
                                num5 = gclass40.gclass5_0.gclass71_0.int_2 / (double)gclass116.int_0 *
                                    AuroraUtils.int_9 / 100.0;
                            if (num5 > 1.0)
                                num5 = 1.0;
                            int num6 = gclass40.gclass5_0.gclass71_0.int_0;
                            if (num6 > gclass40.gclass5_0.gclass71_0.int_1)
                                num6 = gclass40.gclass5_0.gclass71_0.int_1;
                            gclass116.double_3 += num6 * num5;
                        }
                    }
                }
            }

            foreach (GClass116 gclass116 in gclass116List)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class439 class439 = new GClass3.Class439();
                // ISSUE: reference to a compiler-generated field
                class439.gclass116_0 = gclass116;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class439.gclass116_0.double_3 < class439.gclass116_0.double_2)
                {
                    // ISSUE: reference to a compiler-generated field
                    class439.gclass116_0.bool_0 = true;
                    // ISSUE: reference to a compiler-generated method
                    foreach (GClass13 gclass13 in list9.Where<GClass13>(class439.method_0).ToList<GClass13>())
                        gclass13.bool_0 = true;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class439.gclass116_0.int_2 < class439.gclass116_0.list_0.Count / 2.0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class439.gclass116_0.bool_1 = true;
                    }
                }
            }

            List<ShipData> list14 = list11
                .OrderByDescending<ShipData, double>(gclass40_0 => gclass40_0.gclass5_0.gclass71_0.double_0)
                .ToList<ShipData>();
            foreach (ShipData gclass40 in list14)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class440 class440 = new GClass3.Class440();
                // ISSUE: reference to a compiler-generated field
                class440.class423_0 = class423;
                // ISSUE: reference to a compiler-generated field
                class440.gclass40_0 = gclass40;
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class441 class441 = new GClass3.Class441();
                // ISSUE: reference to a compiler-generated field
                class441.class440_0 = class440;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class441.class440_0.gclass40_0.method_94();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class441.class440_0.gclass40_0.list_4.Count != 0)
                {
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
                    if (class441.class440_0.gclass40_0.gclass5_0.gclass71_0.double_0 > 0.0 &&
                        class441.class440_0.gclass40_0.gclass5_0.gclass71_0.int_0 >
                        class441.class440_0.gclass40_0.gclass5_0.gclass71_0.int_1 &&
                        !source2.Contains(class441.class440_0.gclass40_0.gclass85_0) &&
                        class441.class440_0.gclass40_0.gclass85_0.MoveOrderDictionary.Count > 0 &&
                        class441.class440_0.gclass40_0.gclass85_0.method_255().MoveActionType.MoveActionType ==
                        MoveActionType.LoadOrdnanceFromColony)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class441.class440_0.gclass40_0.gclass5_0.double_2 != 0.0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class441.class440_0.gclass40_0.gclass5_0.bool_0 = true;
                        }
                        else
                            continue;
                    }

                    bool flag1 = false;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    class441.list_0 = class441.class440_0.class423_0.list_1
                        .Where<ShipData>(class441.class440_0.method_0).ToList<ShipData>();
                    // ISSUE: reference to a compiler-generated field
                    if (class441.list_0.Count > 0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class441.class440_0.gclass40_0.gclass21_0.SpecialNPRID == SpecialNPRIDs.StarSwarm)
                        {
                            // ISSUE: reference to a compiler-generated method
                            List<ShipData> list15 = this.gclass0_0.FormationDictionary.Values
                                .Where<GroundUnitFormationData>(class441.method_0)
                                .Select<GroundUnitFormationData, ShipData>(gclass103_0 => gclass103_0.ShipData)
                                .Distinct<ShipData>().ToList<ShipData>();
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class441.list_0 = class441.list_0.Except<ShipData>(list15).ToList<ShipData>();
                        }

                        // ISSUE: reference to a compiler-generated field
                        if (class441.list_0.Count > 0)
                        {
                            int num7 = 1;
                            // ISSUE: reference to a compiler-generated method
                            List<GClass117> list16 = list13.Where<GClass117>(class441.method_1).ToList<GClass117>();
                            foreach (GClass117 gclass117 in list16)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                gclass117.method_6(class441.class440_0.gclass40_0);
                            }

                            List<GClass117> list17 = list16
                                .OrderByDescending<GClass117, Decimal>(gclass117_0 => gclass117_0.decimal_5)
                                .ToList<GClass117>();
                            while (true)
                            {
                                foreach (GClass117 gclass117 in list17)
                                {
                                    // ISSUE: object of a compiler-generated type is created
                                    // ISSUE: variable of a compiler-generated type
                                    GClass3.Class425 class425 = new GClass3.Class425();
                                    // ISSUE: reference to a compiler-generated field
                                    class425.class441_0 = class441;
                                    // ISSUE: reference to a compiler-generated field
                                    class425.gclass117_0 = gclass117;
                                    bool flag2 = false;
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (class425.class441_0.class440_0.gclass40_0.gclass5_0.gclass71_0.double_0 > 0.0 &&
                                        !class425.class441_0.class440_0.gclass40_0.gclass5_0.bool_0 &&
                                        (!class425.gclass117_0.gclass116_0.bool_0 ||
                                         class425.gclass117_0.double_2 < AuroraUtils.int_13 || num7 > 1))
                                    {
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
                                        if ((!class425.gclass117_0.gclass116_0.bool_3 ||
                                             !class425.gclass117_0.gclass21_0.NPR) &&
                                            (!class425.gclass117_0.gclass116_0.bool_2 ||
                                             class425.gclass117_0.gclass21_0.NPR) ||
                                            class425.class441_0.class440_0.gclass40_0.list_10.Count <= 0 ||
                                            (double)class425.class441_0.class440_0.gclass40_0.list_10.Max<PopOrdnanceStock>(
                                                gclass130_0 => gclass130_0.RaceMissile.Speed) * 30.0 >=
                                            class425.gclass117_0.double_2)
                                        {
                                            // ISSUE: reference to a compiler-generated method
                                            Decimal num8 = this.gclass0_0.MissileSalvoes.Values
                                                .Where<MissileSalvo>(class425.method_0).Sum<MissileSalvo>(gclass132_0 =>
                                                    gclass132_0.RaceMissile.Size * gclass132_0.RemainingDecoys.Count);
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated method
                                            if ((class425.gclass117_0.double_2 <= AuroraUtils.int_12 || !(num8 > 0M) ||
                                                 num7 >= 3 ||
                                                 !(this.gclass0_0.GameTime -
                                                   class425.gclass117_0.gclass40_0.decimal_19 <
                                                   AuroraUtils.int_15)) &&
                                                (!class425.gclass117_0.gclass116_0.bool_1 ||
                                                 class425.gclass117_0.double_2 <= AuroraUtils.int_13 || num7 != 1 ||
                                                 this.gclass0_0.MissileSalvoes.Values.Where<MissileSalvo>(class425.method_1)
                                                     .Count<MissileSalvo>() <= 0))
                                            {
                                                // ISSUE: reference to a compiler-generated method
                                                Decimal num9 = list14.Sum<ShipData>(class425.method_2);
                                                // ISSUE: reference to a compiler-generated field
                                                Decimal num10 = class425.gclass117_0.method_7() - num8 - num9;
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                RaceMissile gclass129 = class425.class441_0.class440_0.gclass40_0.list_10
                                                    .Where<PopOrdnanceStock>(
                                                        gclass130_0 => gclass130_0.RaceMissile.ShipDecoy == 0)
                                                    .Select<PopOrdnanceStock, RaceMissile>(
                                                        gclass130_0 => gclass130_0.RaceMissile)
                                                    .FirstOrDefault<RaceMissile>();
                                                if (gclass129 != null)
                                                {
                                                    double double_7 = 1.0;
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class425.gclass117_0.gclass40_0 != null)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        double_7 = gclass129.method_3(class425.gclass117_0.gclass40_0);
                                                    }

                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    Decimal num11 = (Decimal)gclass129.method_0(
                                                        class425.gclass117_0.int_1, double_7,
                                                        class425.class441_0.class440_0.gclass40_0.double_0);
                                                    if (num11 > 0M && num11 < 80M)
                                                        num10 *= 80M / num11;
                                                }

                                                if (!(num10 <= 0M) || num7 != 1)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class425.class441_0.class440_0.gclass40_0.gclass5_0.method_1(
                                                            class425.gclass117_0.gclass40_0,
                                                            class425.gclass117_0.double_2))
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        if (gclass129 == null || !(gclass129.Size < 3M) ||
                                                            class425.gclass117_0.gclass116_0.list_1.Count != 0 ||
                                                            class425.gclass117_0.double_2 <= AuroraUtils.int_13 ||
                                                            class425.gclass117_0.double_2 <= AuroraUtils.double_12 *
                                                            class425.class441_0.class440_0.gclass40_0.gclass5_0
                                                                .double_5 || !(class425.gclass117_0.gclass40_0
                                                                .gclass22_0.Size > 20M))
                                                        {
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            foreach (FireControlAssignment gclass36 in class425.class441_0.class440_0
                                                                         .gclass40_0.list_4
                                                                         .Where<FireControlAssignment>(gclass36_0 =>
                                                                             gclass36_0.FCComponent.gclass231_0
                                                                                 .ComponentTypeID ==
                                                                             AuroraComponentType.MissileFireControl &&
                                                                             gclass36_0.TargetID == 0).ToList<FireControlAssignment>())
                                                            {
                                                                // ISSUE: object of a compiler-generated type is created
                                                                // ISSUE: variable of a compiler-generated type
                                                                GClass3.Class426 class426 = new GClass3.Class426();
                                                                // ISSUE: reference to a compiler-generated field
                                                                class426.gclass36_0 = gclass36;
                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated method
                                                                List<WeaponFireControlAssignment> list18 = class425.class441_0.class440_0
                                                                    .gclass40_0.list_2
                                                                    .Where<WeaponFireControlAssignment>(class426.method_0)
                                                                    .ToList<WeaponFireControlAssignment>();
                                                                if (list18.Count != 0)
                                                                {
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    List<WeaponFireControlAssignment> source3 =
                                                                        class425.class441_0.class440_0.gclass40_0
                                                                            .method_20(list18);
                                                                    if (source3.Count != 0)
                                                                    {
                                                                        // ISSUE: reference to a compiler-generated field
                                                                        // ISSUE: reference to a compiler-generated field
                                                                        class426.gclass36_0.TargetID =
                                                                            class425.gclass117_0.gclass40_0.int_8;
                                                                        // ISSUE: reference to a compiler-generated field
                                                                        class426.gclass36_0.TargetContactType =
                                                                            AuroraContactType.Ship;
                                                                        // ISSUE: reference to a compiler-generated field
                                                                        class426.gclass36_0.IsOpeningFire = true;
                                                                        flag1 = true;
                                                                        if (source3.Sum<WeaponFireControlAssignment>(gclass31_0 =>
                                                                                gclass31_0.WeaponComponent.decimal_3) >
                                                                            num10)
                                                                        {
                                                                            foreach (WeaponFireControlAssignment gclass31 in source3)
                                                                            {
                                                                                if (num10 <= 0M)
                                                                                {
                                                                                    // ISSUE: reference to a compiler-generated field
                                                                                    // ISSUE: reference to a compiler-generated field
                                                                                    // ISSUE: reference to a compiler-generated field
                                                                                    class425.class441_0.class440_0
                                                                                        .gclass40_0.list_2
                                                                                        .Remove(gclass31);
                                                                                    flag2 = true;
                                                                                }

                                                                                num10 -= gclass31.WeaponComponent.decimal_3;
                                                                            }

                                                                            if (flag2)
                                                                                break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        else
                                                            continue;
                                                    }
                                                }
                                                else
                                                    continue;
                                            }
                                            else
                                                continue;
                                        }
                                        else
                                            continue;
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (class425.class441_0.class440_0.gclass40_0.gclass5_0.double_2 > 0.0 &&
                                        class425.class441_0.class440_0.gclass40_0.gclass5_0.double_2 >
                                        class425.gclass117_0.double_2)
                                    {
                                        // ISSUE: reference to a compiler-generated method
                                        Decimal num12 = list14.Sum<ShipData>(class425.method_3);
                                        // ISSUE: reference to a compiler-generated field
                                        Decimal num13 = class425.gclass117_0.method_8();
                                        if (!(num13 - num12 <= 0M))
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            foreach (FireControlAssignment gclass36 in class425.class441_0.class440_0.gclass40_0
                                                         .list_4.Where<FireControlAssignment>(gclass36_0 =>
                                                             gclass36_0.FCComponent.gclass231_0.ComponentTypeID ==
                                                             AuroraComponentType.BeamFireControl &&
                                                             gclass36_0.TargetID == 0).ToList<FireControlAssignment>())
                                            {
                                                // ISSUE: object of a compiler-generated type is created
                                                // ISSUE: variable of a compiler-generated type
                                                GClass3.Class427 class427 = new GClass3.Class427();
                                                // ISSUE: reference to a compiler-generated field
                                                class427.gclass36_0 = gclass36;
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated method
                                                List<WeaponFireControlAssignment> list19 = class425.class441_0.class440_0.gclass40_0.list_2
                                                    .Where<WeaponFireControlAssignment>(class427.method_0).ToList<WeaponFireControlAssignment>();
                                                // ISSUE: reference to a compiler-generated field
                                                if (list19.Count != 0 &&
                                                    list19.Select<WeaponFireControlAssignment, ShipComponent>(gclass31_0 =>
                                                            gclass31_0.WeaponComponent)
                                                        .Max<ShipComponent>(gclass230_0 => gclass230_0.method_18()) >
                                                    class425.gclass117_0.double_2)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    class427.gclass36_0.TargetID = class425.gclass117_0.gclass40_0.int_8;
                                                    // ISSUE: reference to a compiler-generated field
                                                    class427.gclass36_0.TargetContactType = AuroraContactType.Ship;
                                                    // ISSUE: reference to a compiler-generated field
                                                    class427.gclass36_0.IsOpeningFire = true;
                                                    flag1 = true;
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class425.class441_0.list_0.Count > num7)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated method
                                                        Decimal num14 = list14.Sum<ShipData>(class425.func_0 ??
                                                            (class425.func_0 = class425.method_4));
                                                        if (num13 <= num14)
                                                            break;
                                                    }
                                                }
                                            }
                                        }
                                        else
                                            continue;
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (class425.class441_0.class440_0.gclass40_0.list_4.Count<FireControlAssignment>(gclass36_0 =>
                                            gclass36_0.TargetID == 0) == 0)
                                        break;
                                }

                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (!flag1 && num7 != 3 && source2.Contains(class441.class440_0.gclass40_0.gclass85_0))
                                    ++num7;
                                else
                                    break;
                            }
                        }
                    }

                    if (!flag1)
                    {
                        if (list9.Count > 0)
                        {
                            int num15 = 1;
                            while (true)
                            {
                                foreach (GClass13 gclass13 in list9)
                                {
                                    // ISSUE: object of a compiler-generated type is created
                                    // ISSUE: variable of a compiler-generated type
                                    GClass3.Class428 class428 = new GClass3.Class428()
                                    {
                                        gclass13_0 = gclass13
                                    };
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    class428.gclass13_0.double_3 = this.gclass0_0.GetDistanceBetween(
                                        class441.class440_0.gclass40_0.gclass85_0.XCoord,
                                        class441.class440_0.gclass40_0.gclass85_0.YCoord,
                                        class428.gclass13_0.double_1, class428.gclass13_0.double_2);
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (class441.class440_0.gclass40_0.gclass5_0.gclass71_0.double_0 > 0.0 &&
                                        !class441.class440_0.gclass40_0.gclass5_0.bool_0 &&
                                        (!class428.gclass13_0.bool_0 ||
                                         class428.gclass13_0.double_3 < AuroraUtils.int_13 || num15 > 1))
                                    {
                                        // ISSUE: reference to a compiler-generated method
                                        Decimal num16 = this.gclass0_0.MissileSalvoes.Values
                                            .Where<MissileSalvo>(class428.method_0).Sum<MissileSalvo>(gclass132_0 =>
                                                gclass132_0.RaceMissile.Size * gclass132_0.RemainingDecoys.Count);
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (class428.gclass13_0.double_3 <= AuroraUtils.int_12 || !(num16 > 0M) ||
                                            num15 >= 3 ||
                                            !(this.gclass0_0.GameTime - class428.gclass13_0.gclass146_0.decimal_79 <
                                              AuroraUtils.int_15))
                                        {
                                            // ISSUE: reference to a compiler-generated method
                                            Decimal num17 = list14.Sum<ShipData>(class428.method_1);
                                            // ISSUE: reference to a compiler-generated field
                                            Decimal num18 = class428.gclass13_0.method_0() - num16 - num17;
                                            if (!(num18 <= 0M) || num15 != 1)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                if (class441.class440_0.gclass40_0.gclass5_0.method_2(
                                                        class428.gclass13_0.double_3))
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    foreach (FireControlAssignment gclass36 in class441.class440_0.gclass40_0.list_4
                                                                 .Where<FireControlAssignment>(gclass36_0 =>
                                                                     gclass36_0.FCComponent.gclass231_0
                                                                         .ComponentTypeID ==
                                                                     AuroraComponentType.MissileFireControl &&
                                                                     gclass36_0.TargetID == 0).ToList<FireControlAssignment>())
                                                    {
                                                        // ISSUE: object of a compiler-generated type is created
                                                        // ISSUE: variable of a compiler-generated type
                                                        GClass3.Class429 class429 = new GClass3.Class429();
                                                        // ISSUE: reference to a compiler-generated field
                                                        class429.gclass36_0 = gclass36;
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated method
                                                        List<WeaponFireControlAssignment> list20 = class441.class440_0.gclass40_0.list_2
                                                            .Where<WeaponFireControlAssignment>(class429.method_0).ToList<WeaponFireControlAssignment>();
                                                        if (list20.Count != 0)
                                                        {
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            class429.gclass36_0.TargetID =
                                                                class428.gclass13_0.gclass146_0.PopulationID;
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            class429.gclass36_0.TargetContactType =
                                                                class428.gclass13_0.gclass65_0.ContactType;
                                                            // ISSUE: reference to a compiler-generated field
                                                            class429.gclass36_0.IsOpeningFire = true;
                                                            flag1 = true;
                                                            num18 -= list20.Sum<WeaponFireControlAssignment>(gclass31_0 =>
                                                                gclass31_0.WeaponComponent.decimal_1);
                                                            if (num18 <= 0M)
                                                                break;
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                                continue;
                                        }
                                        else
                                            continue;
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (class441.class440_0.gclass40_0.gclass5_0.double_2 > 0.0 &&
                                        class441.class440_0.gclass40_0.gclass5_0.double_2 >
                                        class428.gclass13_0.double_3)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        foreach (FireControlAssignment gclass36 in class441.class440_0.gclass40_0.list_4
                                                     .Where<FireControlAssignment>(gclass36_0 =>
                                                         gclass36_0.FCComponent.gclass231_0.ComponentTypeID ==
                                                         AuroraComponentType.BeamFireControl && gclass36_0.TargetID == 0)
                                                     .ToList<FireControlAssignment>())
                                        {
                                            // ISSUE: object of a compiler-generated type is created
                                            // ISSUE: variable of a compiler-generated type
                                            GClass3.Class430 class430 = new GClass3.Class430();
                                            // ISSUE: reference to a compiler-generated field
                                            class430.gclass36_0 = gclass36;
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated method
                                            List<WeaponFireControlAssignment> list21 = class441.class440_0.gclass40_0.list_2
                                                .Where<WeaponFireControlAssignment>(class430.method_0).ToList<WeaponFireControlAssignment>();
                                            // ISSUE: reference to a compiler-generated field
                                            if (list21.Count != 0 &&
                                                list21.Select<WeaponFireControlAssignment, ShipComponent>(gclass31_0 => gclass31_0.WeaponComponent)
                                                    .Max<ShipComponent>(gclass230_0 => gclass230_0.method_18()) >
                                                class428.gclass13_0.double_3)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class430.gclass36_0.TargetID = class428.gclass13_0.gclass146_0.PopulationID;
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class430.gclass36_0.TargetContactType =
                                                    class428.gclass13_0.gclass65_0.ContactType;
                                                // ISSUE: reference to a compiler-generated field
                                                class430.gclass36_0.IsOpeningFire = true;
                                                flag1 = true;
                                            }
                                        }
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (class441.class440_0.gclass40_0.list_4.Count<FireControlAssignment>(gclass36_0 =>
                                            gclass36_0.TargetID == 0) == 0)
                                        break;
                                }

                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (!flag1 && num15 != 3 && source2.Contains(class441.class440_0.gclass40_0.gclass85_0))
                                    ++num15;
                                else
                                    break;
                            }
                        }

                        if (!flag1 && list7.Where<MissileSalvo>(gclass132_0 => gclass132_0.double_9 == 0.0)
                                .ToList<MissileSalvo>().Count > 0)
                        {
                            foreach (MissileSalvo gclass132 in list7
                                         .Where<MissileSalvo>(gclass132_0 => gclass132_0.double_9 == 0.0)
                                         .ToList<MissileSalvo>())
                            {
                                // ISSUE: object of a compiler-generated type is created
                                // ISSUE: variable of a compiler-generated type
                                GClass3.Class431 class431 = new GClass3.Class431();
                                // ISSUE: reference to a compiler-generated field
                                class431.gclass132_0 = gclass132;
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                double num = this.gclass0_0.GetDistanceBetween(
                                    class441.class440_0.gclass40_0.gclass85_0.XCoord,
                                    class441.class440_0.gclass40_0.gclass85_0.YCoord, class431.gclass132_0.double_0,
                                    class431.gclass132_0.double_1);
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (class441.class440_0.gclass40_0.gclass5_0.double_2 > 0.0 &&
                                    class441.class440_0.gclass40_0.gclass5_0.double_2 > num)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    foreach (FireControlAssignment gclass36 in class441.class440_0.gclass40_0.list_4
                                                 .Where<FireControlAssignment>(gclass36_0 =>
                                                     gclass36_0.FCComponent.gclass231_0.ComponentTypeID ==
                                                     AuroraComponentType.BeamFireControl && gclass36_0.TargetID == 0)
                                                 .ToList<FireControlAssignment>())
                                    {
                                        // ISSUE: object of a compiler-generated type is created
                                        // ISSUE: variable of a compiler-generated type
                                        GClass3.Class432 class432 = new GClass3.Class432();
                                        // ISSUE: reference to a compiler-generated field
                                        class432.gclass36_0 = gclass36;
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated method
                                        List<WeaponFireControlAssignment> list22 = class441.class440_0.gclass40_0.list_2
                                            .Where<WeaponFireControlAssignment>(class432.method_0).ToList<WeaponFireControlAssignment>();
                                        if (list22.Count != 0 &&
                                            list22.Select<WeaponFireControlAssignment, ShipComponent>(gclass31_0 => gclass31_0.WeaponComponent)
                                                .Max<ShipComponent>(gclass230_0 => gclass230_0.method_18()) > num)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class432.gclass36_0.TargetID = class431.gclass132_0.int_1;
                                            // ISSUE: reference to a compiler-generated field
                                            class432.gclass36_0.TargetContactType = AuroraContactType.Salvo;
                                            // ISSUE: reference to a compiler-generated field
                                            class432.gclass36_0.IsOpeningFire = true;
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated method
                                            list7 = list7
                                                .Where<MissileSalvo>(class431.func_0 ??
                                                                  (class431.func_0 = class431.method_0))
                                                .ToList<MissileSalvo>();
                                            // ISSUE: reference to a compiler-generated field
                                            list7.Add(class431.gclass132_0);
                                        }
                                    }
                                }

                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (class441.class440_0.gclass40_0.list_4.Count<FireControlAssignment>(gclass36_0 =>
                                        gclass36_0.TargetID == 0) == 0)
                                    break;
                            }
                        }
                    }
                }
            }

            if (list4.Count <= 0)
                return;
            AuroraTargetSelection auroraTargetSelection = AuroraTargetSelection.RandomShip;
            foreach (GroundUnitFormationElement gclass39 in list4)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class433 class433 = new GClass3.Class433()
                {
                    class423_0 = class423,
                    gclass39_0 = gclass39
                };
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                class433.gclass39_0.TargetSelectionType =
                    class433.class423_0.list_1.Where<ShipData>(class433.method_0).ToList<ShipData>().Count <=
                    0
                        ? AuroraTargetSelection.RangedDefensiveFire
                        : auroraTargetSelection;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 59);
        }
    }

    public void method_3(List<FleetData> list_0, bool bool_0, bool bool_1)
    {
        try
        {
            List<FleetData> list1 = list_0.Where<FleetData>(gclass85_0 => gclass85_0.System == this.gclass202_0)
                .ToList<FleetData>();
            if (!bool_0)
                list1 = list1.Where<FleetData>(gclass85_0 =>
                        gclass85_0.NPRSomething.method_7() || gclass85_0.NPRSomething.genum100_0 < GEnum100.const_2)
                    .ToList<FleetData>();
            List<FleetData> list2 = list1.Where<FleetData>(gclass85_0 => gclass85_0.method_195() > 1).ToList<FleetData>();
            if (list2.Count == 0)
                return;
            foreach (FleetData gclass85 in list2)
                gclass85.method_4();
            List<FleetData> list3 = this.gclass0_0.Contacts.Values.Where<Contact>(gclass65_0 =>
                    gclass65_0.method_5() == AuroraContactStatus.Hostile &&
                    gclass65_0.DetectRace == this.gclass202_0.Race &&
                    gclass65_0.LastUpdate == this.gclass0_0.GameTime &&
                    gclass65_0.ContactType == AuroraContactType.Ship &&
                    gclass65_0.System == this.gclass202_0.ActualSystem)
                .Select<Contact, FleetData>(gclass65_0 => gclass65_0.TargetShip.gclass85_0).Distinct<FleetData>()
                .ToList<FleetData>();
            List<PopulationData> list4 = this.gclass0_0.Contacts.Values.Where<Contact>(gclass65_0 =>
                    gclass65_0.method_5() == AuroraContactStatus.Hostile &&
                    gclass65_0.DetectRace == this.gclass202_0.Race &&
                    gclass65_0.LastUpdate == this.gclass0_0.GameTime &&
                    gclass65_0.ContactType == AuroraContactType.STOGroundUnit &&
                    gclass65_0.System == this.gclass202_0.ActualSystem)
                .Select<Contact, PopulationData>(gclass65_0 => gclass65_0.TargetPopulation).Distinct<PopulationData>()
                .ToList<PopulationData>();
            if (this.gclass202_0.Race.SpecialNPRID == SpecialNPRIDs.Eldar)
            {
                GClass210 gclass210_0_1 =
                    this.gclass0_0.dictionary_16.Values
                        .Where<GClass210>(gclass210_0 => gclass210_0.gclass200_0 == this.gclass202_0.ActualSystem)
                        .FirstOrDefault<GClass210>() ??
                    this.gclass202_0.Race.UnknownNprClass.method_2(this.gclass202_0.ActualSystem);
                foreach (FleetData gclass85_0 in list2)
                {
                    if (!this.method_4(gclass85_0, list3, list4, gclass210_0_1.double_0, gclass210_0_1.double_1,
                            AuroraUtils.int_7) && gclass85_0.NPRSomething.int_0 <= 25)
                    {
                        ++gclass85_0.NPRSomething.int_0;
                    }
                    else
                    {
                        gclass85_0.method_263();
                        if (bool_1)
                        {
                            if (gclass210_0_1.double_2 == 0.0)
                            {
                                gclass85_0.method_232(gclass210_0_1, MoveActionType.StandardTransit, gclass85_0.System);
                                gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                            }
                            else if ((Decimal)this.gclass0_0.GetDistanceBetween(gclass85_0.XCoord, gclass85_0.YCoord,
                                         gclass210_0_1.double_0, gclass210_0_1.double_1) / gclass85_0.Speed >=
                                     (Decimal)gclass210_0_1.double_2)
                            {
                                gclass85_0.method_232(gclass210_0_1, MoveActionType.StandardTransit, gclass85_0.System);
                                gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                            }
                        }
                        else
                            gclass85_0.method_232(gclass210_0_1, MoveActionType.MoveTo, gclass85_0.System);
                    }
                }
            }
            else
            {
                List<JumpPoint> gclass120List1 = new List<JumpPoint>();
                List<JumpPoint> gclass120List2 = this.genum96_0 != GEnum96.const_4
                    ? (this.genum96_0 != GEnum96.const_3
                        ? (this.genum96_0 != GEnum96.const_2
                            ? (this.genum96_0 != GEnum96.const_1
                                ? this.gclass202_0.method_38(true, GEnum96.const_0)
                                    .Where<RacialSystemSurvey>(gclass202_0 => !gclass202_0.bool_6)
                                    .OrderByDescending<RacialSystemSurvey,
                                        GEnum95>(gclass202_0 => gclass202_0.gclass3_0.genum95_0)
                                    .Select<RacialSystemSurvey,
                                        JumpPoint>(gclass202_1 =>
                                        gclass202_1.method_11(this.gclass202_0).LinkedJumpPoint).ToList<JumpPoint>()
                                : this.gclass202_0.method_38(true, GEnum96.const_0)
                                    .OrderByDescending<RacialSystemSurvey,
                                        GEnum95>(gclass202_0 => gclass202_0.gclass3_0.genum95_0)
                                    .Select<RacialSystemSurvey,
                                        JumpPoint>(gclass202_1 =>
                                        gclass202_1.method_11(this.gclass202_0).LinkedJumpPoint).ToList<JumpPoint>())
                            : this.gclass202_0.method_38(true, GEnum96.const_1)
                                .OrderBy<RacialSystemSurvey, GEnum96>(gclass202_0 => gclass202_0.gclass3_0.genum96_0)
                                .ThenByDescending<RacialSystemSurvey, GEnum95>(gclass202_0 => gclass202_0.gclass3_0.genum95_0)
                                .Select<RacialSystemSurvey,
                                    JumpPoint>(
                                    gclass202_1 => gclass202_1.method_11(this.gclass202_0).LinkedJumpPoint)
                                .ToList<JumpPoint>())
                        : this.gclass202_0.method_38(true, GEnum96.const_2)
                            .OrderBy<RacialSystemSurvey, GEnum96>(gclass202_0 => gclass202_0.gclass3_0.genum96_0)
                            .ThenByDescending<RacialSystemSurvey, GEnum95>(gclass202_0 => gclass202_0.gclass3_0.genum95_0)
                            .Select<RacialSystemSurvey,
                                JumpPoint>(gclass202_1 => gclass202_1.method_11(this.gclass202_0).LinkedJumpPoint)
                            .ToList<JumpPoint>())
                    : this.gclass202_0.method_38(true, GEnum96.const_3)
                        .OrderBy<RacialSystemSurvey, GEnum96>(gclass202_0 => gclass202_0.gclass3_0.genum96_0)
                        .ThenByDescending<RacialSystemSurvey, GEnum95>(gclass202_0 => gclass202_0.gclass3_0.genum95_0)
                        .Select<RacialSystemSurvey, JumpPoint>(gclass202_1 =>
                            gclass202_1.method_11(this.gclass202_0).LinkedJumpPoint).ToList<JumpPoint>();
                if (gclass120List2.Count == 0 && bool_1)
                    gclass120List2 = this.gclass202_0.method_38(true, GEnum96.const_4)
                        .OrderBy<RacialSystemSurvey, GEnum96>(gclass202_0 => gclass202_0.gclass3_0.genum96_0)
                        .ThenByDescending<RacialSystemSurvey, GEnum95>(gclass202_0 => gclass202_0.gclass3_0.genum95_0)
                        .Select<RacialSystemSurvey, JumpPoint>(gclass202_1 =>
                            gclass202_1.method_11(this.gclass202_0).LinkedJumpPoint).ToList<JumpPoint>();
                if (gclass120List2.Count > 0)
                {
                    foreach (FleetData gclass85_0 in list2)
                    {
                        gclass85_0.NPRSomething.bool_0 = gclass85_0.method_241();
                        foreach (JumpPoint gclass120_1 in gclass120List2)
                        {
                            if ((gclass120_1.JumpGateStrength != 0 || gclass85_0.NPRSomething.bool_0) &&
                                this.method_4(gclass85_0, list3, list4, gclass120_1.XCoord, gclass120_1.YCoord,
                                    AuroraUtils.int_7))
                            {
                                gclass85_0.method_263();
                                gclass85_0.method_231(gclass120_1, MoveActionType.StandardTransit, this.gclass202_0);
                                gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                            }
                        }
                    }
                }
            }

            List<FleetData> list5 = list2.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
            if (list5.Count == 0)
                return;
            List<PopulationData> list6 = this.gclass0_0.Populations.Values
                .Where<PopulationData>(gclass146_0 =>
                    gclass146_0.gclass202_0 == this.gclass202_0 && gclass146_0.SystemBodyData.DustLevel == 0M)
                .OrderByDescending<PopulationData, GEnum97>(gclass146_0 => gclass146_0.gclass6_0.genum97_0)
                .ToList<PopulationData>();
            if (list6.Count > 0)
            {
                foreach (FleetData gclass85_0 in list5)
                {
                    gclass85_0.NPRSomething.bool_0 = gclass85_0.method_241();
                    foreach (PopulationData gclass146_1 in list6)
                    {
                        double double_0 = gclass146_1.method_87();
                        double double_1 = gclass146_1.method_88();
                        if (this.method_4(gclass85_0, list3, list4, double_0, double_1, AuroraUtils.int_7))
                        {
                            gclass85_0.method_263();
                            gclass85_0.method_219(gclass146_1, MoveActionType.MoveTo);
                            gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                        }
                    }
                }
            }

            List<FleetData> list7 = list5.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
            if (list7.Count == 0 || list3.Count <= 0)
                return;
            foreach (FleetData gclass85_1 in list7)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class442 class442 = new GClass3.Class442();
                // ISSUE: reference to a compiler-generated field
                class442.gclass3_0 = this;
                // ISSUE: reference to a compiler-generated field
                class442.gclass85_0 = gclass85_1;
                // ISSUE: reference to a compiler-generated method
                FleetData gclass85_2 = list3.OrderBy<FleetData, double>(class442.method_0).FirstOrDefault<FleetData>();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                double num = this.gclass0_0.GetDistanceBetween(class442.gclass85_0.XCoord, class442.gclass85_0.YCoord,
                    gclass85_2.XCoord, gclass85_2.YCoord);
                GClass221 gclass221 = new GClass221(0.0, 0.0);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                GClass221 gclass221_0 = num <= 0.0
                    ? this.gclass0_0.method_592(class442.gclass85_0.XCoord, class442.gclass85_0.YCoord, 10000000.0,
                        AuroraUtils.GetRandomInteger(360) - 1)
                    : this.gclass0_0.method_525(class442.gclass85_0.XCoord, class442.gclass85_0.YCoord,
                        gclass85_2.XCoord, gclass85_2.YCoord, num * -10.0);
                // ISSUE: reference to a compiler-generated field
                if (list4.Count > 0 && class442.gclass85_0.NPRSomething.method_10(gclass221_0, list4))
                    break;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                Waypoint gclass214_0 = class442.gclass85_0.Race.method_188(
                    class442.gclass85_0.System.ActualSystem, null, null, WayPointType.Temporary,
                    gclass221_0.double_0, gclass221_0.double_1, $"{class442.gclass85_0.FleetName} Escape Point", 0);
                // ISSUE: reference to a compiler-generated field
                class442.gclass85_0.method_263();
                // ISSUE: reference to a compiler-generated field
                class442.gclass85_0.method_217(gclass214_0, MoveActionType.MoveTo, this.gclass202_0);
                // ISSUE: reference to a compiler-generated field
                class442.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 60);
        }
    }

    public bool method_4(
        FleetData gclass85_0,
        List<FleetData> list_0,
        List<PopulationData> list_1,
        double double_0,
        double double_1,
        double double_2)
    {
        try
        {
            double num1 = 200000000.0;
            double num2 = 200000000.0;
            foreach (FleetData gclass85 in list_0)
            {
                double num3 = this.gclass0_0.GetDistanceBetween(gclass85.XCoord, gclass85.YCoord, gclass85_0.XCoord,
                    gclass85_0.YCoord);
                double num4 = this.gclass0_0.method_517(gclass85.XCoord, gclass85.YCoord, gclass85_0.XCoord,
                    gclass85_0.YCoord, double_0, double_1);
                if (num4 < num1)
                    num1 = num4;
                if (num3 < num2)
                    num2 = num3;
            }

            if (num1 < double_2 && num1 < num2 * 0.8)
                return false;
            foreach (PopulationData gclass146 in list_1)
            {
                double num5 = this.gclass0_0.GetDistanceBetween(gclass146.method_87(), gclass146.method_88(),
                    gclass85_0.XCoord, gclass85_0.YCoord);
                double num6 = this.gclass0_0.method_517(gclass146.method_87(), gclass146.method_88(),
                    gclass85_0.XCoord, gclass85_0.YCoord, double_0, double_1);
                if (num6 < 1000000.0 && num6 < num5)
                    return false;
            }

            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 61);
            return false;
        }
    }

    public bool method_5(
        FleetData gclass85_0,
        FleetData gclass85_1,
        List<FleetData> list_0,
        List<PopulationData> list_1,
        double double_0,
        Decimal decimal_2)
    {
        try
        {
            Decimal num1 = 0M;
            foreach (FleetData gclass85 in list_0)
            {
                if (gclass85 != gclass85_1)
                {
                    double num2 = this.gclass0_0.GetDistanceBetween(gclass85.XCoord, gclass85.YCoord, gclass85_0.XCoord,
                        gclass85_0.YCoord);
                    double num3 = this.gclass0_0.method_517(gclass85.XCoord, gclass85.YCoord, gclass85_0.XCoord,
                        gclass85_0.YCoord, gclass85_1.XCoord, gclass85_1.YCoord);
                    if (num3 < double_0 && num3 < num2 * 0.8)
                        num1 += gclass85.decimal_7;
                    if (num1 > decimal_2)
                        return false;
                }
            }

            foreach (PopulationData gclass146 in list_1)
            {
                double num4 = this.gclass0_0.GetDistanceBetween(gclass146.method_87(), gclass146.method_88(),
                    gclass85_0.XCoord, gclass85_0.YCoord);
                double num5 = this.gclass0_0.method_517(gclass146.method_87(), gclass146.method_88(),
                    gclass85_0.XCoord, gclass85_0.YCoord, gclass85_1.XCoord, gclass85_1.YCoord);
                if (num5 < 1000000.0 && num5 < num4)
                    return false;
            }

            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 62);
            return false;
        }
    }

    public void method_6(List<FleetData> list_0)
    {
        try
        {
            if (list_0.Count == 0)
                return;
            List<FleetData> list1 = list_0.Where<FleetData>(gclass85_0 =>
                    gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_22 && !gclass85_0.NPRSomething.bRedeployOrderGiven)
                .ToList<FleetData>();
            if (list1.Count == 0)
                return;
            foreach (FleetData gclass85 in list1)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class443 class443 = new GClass3.Class443();
                // ISSUE: reference to a compiler-generated field
                class443.gclass3_0 = this;
                // ISSUE: reference to a compiler-generated field
                class443.gclass85_0 = gclass85;
                List<FleetData> list2 = list_0
                    .Where<FleetData>(gclass85_0 => gclass85_0.NPROperationGroup.OperationalGroupId == OperationalGroupID.StarSwarmScoutSquadron)
                    .ToList<FleetData>();
                if (list2.Count > 0)
                {
                    // ISSUE: reference to a compiler-generated method
                    FleetData gclass85_5 = list2.OrderBy<FleetData, double>(class443.method_0).FirstOrDefault<FleetData>();
                    ShipData object_0 = gclass85_5.method_176()
                        .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.gclass22_0.Size)
                        .FirstOrDefault<ShipData>();
                    if (object_0 == null)
                    {
                        this.gclass0_0.FleetDictionary.Remove(gclass85_5.FleetID);
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        class443.gclass85_0.method_263();
                        // ISSUE: reference to a compiler-generated field
                        class443.gclass85_0.method_223(gclass85_5, MoveActionType.SalvageIntactShip, object_0);
                        // ISSUE: reference to a compiler-generated field
                        class443.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                        continue;
                    }
                }

                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                Wreck gclass233_0 = this.gclass202_0.ActualSystem.method_5(class443.gclass85_0.XCoord,
                    class443.gclass85_0.YCoord, this.gclass202_0);
                if (gclass233_0 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    class443.gclass85_0.method_263();
                    // ISSUE: reference to a compiler-generated field
                    class443.gclass85_0.method_216(gclass233_0, MoveActionType.SalvageWreck, this.gclass202_0);
                    // ISSUE: reference to a compiler-generated field
                    class443.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    PopulationData gclass146_1 = this.gclass202_0.ActualSystem.method_6(class443.gclass85_0.XCoord,
                        class443.gclass85_0.YCoord, this.gclass202_0);
                    if (gclass146_1 != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class443.gclass85_0.method_263();
                        // ISSUE: reference to a compiler-generated field
                        class443.gclass85_0.method_219(gclass146_1, MoveActionType.SalvageInstallations);
                        // ISSUE: reference to a compiler-generated field
                        class443.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 63 /*0x3F*/);
        }
    }

    public void method_7(List<FleetData> list_0, List<RacialSystemSurvey> list_1, List<RacialSystemSurvey> list_2)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass3.Class444 class444 = new GClass3.Class444();
            // ISSUE: reference to a compiler-generated field
            class444.gclass3_0 = this;
            List<FleetData> list1 = list_0.Where<FleetData>(gclass85_0 => gclass85_0.System == this.gclass202_0)
                .ToList<FleetData>();
            if (list1.Count<FleetData>() == 0)
                return;
            this.decimal_0 = 0M;
            this.decimal_1 = 0M;
            if (this.genum96_0 == GEnum96.const_4)
            {
                foreach (FleetData gclass85 in list1.Where<FleetData>(gclass85_0 =>
                                 gclass85_0.NPROperationGroup.int_1 == 1 && gclass85_0.NPRSomething.genum100_0 > GEnum100.const_0)
                             .ToList<FleetData>())
                {
                    gclass85.method_263();
                    gclass85.NPRSomething.bRedeployOrderGiven = false;
                }
            }
            else
            {
                if (this.gclass202_0.Race.SpecialNPRID == SpecialNPRIDs.Eldar &&
                    list_0.Count<FleetData>(gclass85_0 =>
                        gclass85_0.LastTransitTime > this.gclass0_0.GameTime - AuroraUtils.decimal_32) == 0 &&
                    this.gclass0_0.Contacts.Values.Count<Contact>(gclass65_0 =>
                        gclass65_0.DetectRace == this.gclass202_0.Race &&
                        gclass65_0.LastUpdate < this.gclass0_0.GameTime - AuroraUtils.decimal_32 &&
                        gclass65_0.System == this.gclass202_0.ActualSystem) == 0 &&
                    this.gclass0_0.Wrecks.Values.Count<Wreck>(gclass233_0 =>
                        gclass233_0.System == this.gclass202_0.ActualSystem) == 0 &&
                    this.gclass0_0.dictionary_30.Values.Count<GClass59>(gclass59_0 =>
                        gclass59_0.gclass200_0 == this.gclass202_0.ActualSystem) == 0)
                {
                    this.gclass202_0.Race.UnknownNprClass.method_33(list1, MoveActionType.StandardTransit);
                    return;
                }

                list1 = list_0.Where<FleetData>(gclass85_0 =>
                    !gclass85_0.NPRSomething.bRedeployOrderGiven && gclass85_0.System == this.gclass202_0).ToList<FleetData>();
            }

            List<FleetData> list2 = list1.Where<FleetData>(gclass85_0 => gclass85_0.NPROperationGroup.bool_2).ToList<FleetData>();
            List<FleetData> list3 = list1
                .Where<FleetData>(gclass85_0 => gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_10).ToList<FleetData>();
            List<FleetData> list4 = list1.Where<FleetData>(gclass85_0 => gclass85_0.NPROperationGroup.bool_3).ToList<FleetData>();
            List<FleetData> list5 = list1
                .Where<FleetData>(gclass85_0 => gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_5).ToList<FleetData>();
            List<PopulationData> list6 = this.gclass202_0.method_46()
                .OrderByDescending<PopulationData, GEnum97>(gclass146_0 => gclass146_0.gclass6_0.genum97_0)
                .ThenByDescending<PopulationData, int>(gclass146_0 => gclass146_0.gclass6_0.int_0)
                .ThenByDescending<PopulationData, double>(gclass146_0 => gclass146_0.gclass6_0.double_2).ToList<PopulationData>();
            List<GroundUnitFormationElement> list7 = this.gclass0_0.FormationDictionary.Values
                .Where<GroundUnitFormationData>(gclass103_0 =>
                    gclass103_0.RaceData == this.gclass202_0.Race && gclass103_0.PopulationData != null)
                .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.PopulationData.gclass202_0 == this.gclass202_0)
                .SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 => gclass103_0.ElementList).Where<GroundUnitFormationElement>(gclass39_0 =>
                    gclass39_0.GroundUnitClass.genum115_0 == GroundUnitClassType.STOAntiShip ||
                    gclass39_0.GroundUnitClass.genum115_0 == GroundUnitClassType.STOPointDefence).ToList<GroundUnitFormationElement>();
            List<GroundUnitFormationElement> list8 = this.gclass0_0.FormationDictionary.Values
                .Where<GroundUnitFormationData>(gclass103_0 =>
                    gclass103_0.RaceData == this.gclass202_0.Race && gclass103_0.PopulationData != null)
                .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.PopulationData.gclass202_0 == this.gclass202_0)
                .SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 => gclass103_0.ElementList)
                .Where<GroundUnitFormationElement>(gclass39_0 => gclass39_0.GroundUnitClass.genum115_0 == GroundUnitClassType.STOPointDefence)
                .ToList<GroundUnitFormationElement>();
            // ISSUE: reference to a compiler-generated field
            class444.list_1 = this.gclass0_0.Contacts.Values.Where<Contact>(gclass65_0 =>
                    gclass65_0.method_5() == AuroraContactStatus.Hostile &&
                    gclass65_0.DetectRace == this.gclass202_0.Race &&
                    gclass65_0.LastUpdate == this.gclass0_0.GameTime &&
                    gclass65_0.ContactType == AuroraContactType.Ship &&
                    gclass65_0.System == this.gclass202_0.ActualSystem)
                .Select<Contact, ShipData>(gclass65_0 => gclass65_0.TargetShip).Distinct<ShipData>()
                .ToList<ShipData>();
            // ISSUE: reference to a compiler-generated field
            List<FleetData> list9 = class444.list_1.Select<ShipData, FleetData>(gclass40_0 => gclass40_0.gclass85_0)
                .Distinct<FleetData>().ToList<FleetData>();
            // ISSUE: reference to a compiler-generated field
            class444.list_0 = this.gclass0_0.Contacts.Values.Where<Contact>(gclass65_0 =>
                    gclass65_0.method_5() == AuroraContactStatus.Hostile &&
                    gclass65_0.DetectRace == this.gclass202_0.Race &&
                    gclass65_0.LastUpdate > this.gclass0_0.GameTime - AuroraUtils.decimal_34 &&
                    gclass65_0.ContactType == AuroraContactType.Ship &&
                    gclass65_0.System == this.gclass202_0.ActualSystem)
                .Select<Contact, ShipData>(gclass65_0 => gclass65_0.TargetShip).Distinct<ShipData>()
                .ToList<ShipData>();
            // ISSUE: reference to a compiler-generated field
            List<FleetData> list10 = class444.list_0.Select<ShipData, FleetData>(gclass40_0 => gclass40_0.gclass85_0)
                .Distinct<FleetData>().ToList<FleetData>();
            List<PopulationData> list11 = this.gclass0_0.Contacts.Values.Where<Contact>(gclass65_0 =>
                    gclass65_0.method_5() == AuroraContactStatus.Hostile &&
                    gclass65_0.DetectRace == this.gclass202_0.Race &&
                    gclass65_0.LastUpdate == this.gclass0_0.GameTime &&
                    gclass65_0.ContactType == AuroraContactType.STOGroundUnit &&
                    gclass65_0.System == this.gclass202_0.ActualSystem)
                .Select<Contact, PopulationData>(gclass65_0 => gclass65_0.TargetPopulation).Distinct<PopulationData>()
                .ToList<PopulationData>();
            // ISSUE: reference to a compiler-generated field
            class444.gclass210_0 = this.gclass0_0.dictionary_16.Values.FirstOrDefault<GClass210>(gclass210_0 =>
                gclass210_0.gclass200_0 == this.gclass202_0.ActualSystem);
            List<MissileSalvo> list12 = this.gclass0_0.Contacts.Values.Where<Contact>(gclass65_0 =>
                    gclass65_0.method_5() == AuroraContactStatus.Hostile &&
                    gclass65_0.DetectRace == this.gclass202_0.Race &&
                    this.gclass0_0.GameTime == gclass65_0.LastUpdate &&
                    gclass65_0.System == this.gclass202_0.ActualSystem &&
                    gclass65_0.ContactType == AuroraContactType.Salvo)
                .Select<Contact, MissileSalvo>(gclass65_0 => gclass65_0.TargetSalvo).Distinct<MissileSalvo>()
                .ToList<MissileSalvo>();
            if (list12.Count > 0)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class445 class445 = new GClass3.Class445();
                // ISSUE: reference to a compiler-generated field
                class445.class444_0 = class444;
                // ISSUE: reference to a compiler-generated field
                class445.int_0 = 60;
                // ISSUE: reference to a compiler-generated field
                class445.list_0 = this.gclass0_0.JumpPointDictionary.Values
                    .Where<JumpPoint>(gclass120_0 => gclass120_0.SystemData == this.gclass202_0.ActualSystem)
                    .Where<JumpPoint>(gclass120_0 =>
                        gclass120_0.RacialJumpPointSurveys.ContainsKey(this.gclass202_0.Race.RaceID))
                    .Where<JumpPoint>(gclass120_0 =>
                        gclass120_0.RacialJumpPointSurveys[this.gclass202_0.Race.RaceID].Charted == 1).ToList<JumpPoint>();
                // ISSUE: reference to a compiler-generated method
                List<FleetData> list13 = list1.Where<FleetData>(class445.method_0).ToList<FleetData>();
                List<FleetData> gclass85List = new List<FleetData>();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class445.class444_0.gclass210_0 != null &&
                    this.gclass202_0.Race.SpecialNPRID == SpecialNPRIDs.Eldar)
                {
                    // ISSUE: reference to a compiler-generated method
                    gclass85List = list1.Where<FleetData>(class445.method_1).ToList<FleetData>();
                }

                if (list13.Count > 0 || gclass85List.Count > 0)
                {
                    foreach (FleetData gclass85 in list13)
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        GClass3.Class450 class450 = new GClass3.Class450();
                        // ISSUE: reference to a compiler-generated field
                        class450.class445_0 = class445;
                        // ISSUE: reference to a compiler-generated field
                        class450.gclass85_0 = gclass85;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        List<MissileSalvo> source = class450.gclass85_0.method_21(list12, class450.class445_0.int_0);
                        if (source.Count > 0)
                        {
                            // ISSUE: object of a compiler-generated type is created
                            // ISSUE: variable of a compiler-generated type
                            GClass3.Class451 class451 = new GClass3.Class451();
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            class451.gclass132_0 = source.OrderByDescending<MissileSalvo, double>(class450.method_0)
                                .FirstOrDefault<MissileSalvo>();
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (source.Where<MissileSalvo>(class451.method_0)
                                    .Sum<MissileSalvo>(gclass132_0 => gclass132_0.RemainingDecoys.Count) >
                                class450.gclass85_0.method_20((int)class451.gclass132_0.RaceMissile.Speed))
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated method
                                JumpPoint gclass120_1 = class450.class445_0.list_0
                                    .OrderBy<JumpPoint, double>(class450.method_1).FirstOrDefault<JumpPoint>();
                                // ISSUE: reference to a compiler-generated field
                                class450.gclass85_0.method_263();
                                // ISSUE: reference to a compiler-generated field
                                class450.gclass85_0.method_231(gclass120_1, MoveActionType.StandardTransit, this.gclass202_0);
                                // ISSUE: reference to a compiler-generated field
                                class450.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                            }
                        }
                    }

                    foreach (FleetData gclass85 in gclass85List)
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        GClass3.Class452 class452 = new GClass3.Class452();
                        // ISSUE: reference to a compiler-generated field
                        class452.class445_0 = class445;
                        // ISSUE: reference to a compiler-generated field
                        class452.gclass85_0 = gclass85;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        List<MissileSalvo> source = class452.gclass85_0.method_21(list12, class452.class445_0.int_0);
                        if (source.Count > 0)
                        {
                            // ISSUE: object of a compiler-generated type is created
                            // ISSUE: variable of a compiler-generated type
                            GClass3.Class453 class453 = new GClass3.Class453();
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            class453.gclass132_0 = source.OrderByDescending<MissileSalvo, double>(class452.method_0)
                                .FirstOrDefault<MissileSalvo>();
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (source.Where<MissileSalvo>(class453.method_0)
                                    .Sum<MissileSalvo>(gclass132_0 => gclass132_0.RemainingDecoys.Count) >
                                class452.gclass85_0.method_20((int)class453.gclass132_0.RaceMissile.Speed))
                            {
                                // ISSUE: reference to a compiler-generated field
                                class452.gclass85_0.method_263();
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class452.gclass85_0.method_232(class452.class445_0.class444_0.gclass210_0,
                                    MoveActionType.StandardTransit, this.gclass202_0);
                                // ISSUE: reference to a compiler-generated field
                                class452.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                            }
                        }
                    }

                    list2 = list2.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
                    list5 = list5.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
                    list3 = list3.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
                }
            }

            List<FleetData> list14 = list1
                .Where<FleetData>(gclass85_0 => gclass85_0.NPRSomething.genum103_0 < GEnum103.const_2).ToList<FleetData>();
            if (list14.Count > 0)
            {
                this.gclass202_0.Race.UnknownNprClass.method_35(list14, list6, list11, true);
                list2 = list2.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
                list5 = list5.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
                list3 = list3.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
            }

            // ISSUE: reference to a compiler-generated field
            if (class444.list_0.Count > 0)
            {
                foreach (FleetData gclass85 in list2)
                    gclass85.method_7();
                this.decimal_0 = list2.Sum<FleetData>(gclass85_0 => gclass85_0.decimal_7);
                // ISSUE: reference to a compiler-generated field
                this.decimal_1 = class444.list_0.Where<ShipData>(gclass40_0 => !gclass40_0.gclass22_0.Commercial)
                    .Sum<ShipData>(gclass40_0 => gclass40_0.gclass22_0.ClassCrossSection * gclass40_0.gclass22_0.MaxSpeed);
                // ISSUE: reference to a compiler-generated method
                List<GClass117> list15 = this.gclass202_0.Race.dictionary_12.Values
                    .Where<GClass117>(class444.method_0)
                    .OrderByDescending<GClass117, Decimal>(gclass117_0 => gclass117_0.gclass115_0.gclass22_0.Size)
                    .ToList<GClass117>();
                // ISSUE: reference to a compiler-generated method
                List<GClass117> list16 = this.gclass202_0.Race.dictionary_12.Values
                    .Where<GClass117>(class444.method_1)
                    .OrderByDescending<GClass117, Decimal>(gclass117_0 => gclass117_0.gclass115_0.gclass22_0.Size)
                    .ToList<GClass117>();
                if (list15.Count > 0)
                {
                    List<FleetData> list17 = list1
                        .Where<FleetData>(gclass85_0 => this.gclass0_0.GameTime - gclass85_0.LastFleetDamageTime < 120M)
                        .Distinct<FleetData>().ToList<FleetData>();
                    List<FleetData> list18 = list1
                        .SelectMany<FleetData, ShipData>(gclass85_0 => gclass85_0.method_176())
                        .Where<ShipData>(gclass40_0 => this.gclass0_0.GameTime - gclass40_0.decimal_20 < 120M)
                        .Select<ShipData, FleetData>(gclass40_0 => gclass40_0.gclass85_0).Distinct<FleetData>()
                        .ToList<FleetData>();
                    if (list17.Count > 0)
                    {
                        foreach (FleetData gclass85_1 in list17)
                        {
                            // ISSUE: object of a compiler-generated type is created
                            // ISSUE: variable of a compiler-generated type
                            GClass3.Class454 class454 = new GClass3.Class454();
                            // ISSUE: reference to a compiler-generated field
                            class454.class444_0 = class444;
                            // ISSUE: reference to a compiler-generated field
                            class454.gclass85_0 = gclass85_1;
                            // ISSUE: reference to a compiler-generated field
                            List<ShipData> source = class454.gclass85_0.method_176();
                            // ISSUE: reference to a compiler-generated method
                            int num1 = list1.Where<FleetData>(class454.method_0)
                                .SelectMany<FleetData, ShipData>(gclass85_0 => gclass85_0.method_176())
                                .Count<ShipData>(gclass40_0 =>
                                    gclass40_0.gclass22_0.ProtectionValue > 0M &&
                                    gclass40_0.gclass5_0.genum99_0 > GEnum99.const_0);
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (num1 != 0 && class454.gclass85_0.NPRSomething.genum100_0 != GEnum100.const_0 &&
                                class454.gclass85_0.NPRSomething.genum102_0 != GEnum102.const_0 &&
                                class454.gclass85_0.NPRSomething.genum103_0 != GEnum103.const_0)
                            {
                                if (source.Count<ShipData>(gclass40_0 =>
                                        this.gclass0_0.GameTime - gclass40_0.decimal_20 < 120M) > 0 && list9.Count > 0)
                                {
                                    // ISSUE: object of a compiler-generated type is created
                                    // ISSUE: variable of a compiler-generated type
                                    GClass3.Class456 class456 = new GClass3.Class456();
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated method
                                    class456.gclass85_0 = list9.OrderBy<FleetData, double>(class454.method_2)
                                        .FirstOrDefault<FleetData>();
                                    // ISSUE: reference to a compiler-generated field
                                    if (class456.gclass85_0 != null)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (class454.gclass85_0.Speed > class456.gclass85_0.Speed)
                                        {
                                            // ISSUE: reference to a compiler-generated method
                                            GClass117 gclass117_0_1 = list16.Where<GClass117>(class456.method_0)
                                                .OrderByDescending<GClass117, Decimal>(gclass117_0 =>
                                                    gclass117_0.gclass115_0.gclass22_0.Size)
                                                .FirstOrDefault<GClass117>();
                                            // ISSUE: reference to a compiler-generated field
                                            if (class454.gclass85_0.NPRSomething.method_9(gclass117_0_1, list11))
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                class454.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                                                continue;
                                            }
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (class454.gclass85_0.NPROperationGroup.int_1 == 0)
                                            {
                                                // ISSUE: reference to a compiler-generated method
                                                List<ShipData> list19 = source.Where<ShipData>(gclass40_0 =>
                                                        gclass40_0.gclass22_0.ProtectionValue > 0M &&
                                                        gclass40_0.gclass5_0.genum99_0 > GEnum99.const_0 &&
                                                        gclass40_0.gclass22_0.AutomatedClassDesign.BeamFireControl > BFCDesignType.const_0)
                                                    .Where<ShipData>(class456.method_1).ToList<ShipData>();
                                                if (list19.Count > 0)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    FleetData gclass85_2 =
                                                        class454.gclass85_0.method_76(list19, OperationalGroupID.BeamOnlyDDSquadron, true);
                                                    gclass85_2.NPRSomething.method_17();
                                                    list2.Add(gclass85_2);
                                                    // ISSUE: reference to a compiler-generated method
                                                    GClass117 gclass117_0_2 = list16.Where<GClass117>(class456.method_2)
                                                        .OrderByDescending<GClass117, Decimal>(gclass117_0 =>
                                                            gclass117_0.gclass115_0.gclass22_0.Size)
                                                        .FirstOrDefault<GClass117>();
                                                    if (gclass85_2.NPRSomething.method_9(gclass117_0_2, list11))
                                                    {
                                                        gclass85_2.NPRSomething.bRedeployOrderGiven = true;
                                                        continue;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                if (source.Count<ShipData>(gclass40_0 =>
                                        this.gclass0_0.GameTime - gclass40_0.decimal_19 < 120M) > 0)
                                {
                                    // ISSUE: object of a compiler-generated type is created
                                    // ISSUE: variable of a compiler-generated type
                                    GClass3.Class457 class457 = new GClass3.Class457();
                                    bool flag = true;
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated method
                                    class457.gclass146_0 = list6.FirstOrDefault<PopulationData>(class454.method_3);
                                    // ISSUE: reference to a compiler-generated field
                                    if (class457.gclass146_0 != null)
                                    {
                                        // ISSUE: reference to a compiler-generated method
                                        if (list8.Count<GroundUnitFormationElement>(class457.method_0) > 0)
                                        {
                                            flag = false;
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated method
                                            if (list1.Count<FleetData>(class454.method_4) > 0)
                                                flag = false;
                                        }
                                    }

                                    if (flag && list9.Count > 0)
                                    {
                                        // ISSUE: object of a compiler-generated type is created
                                        // ISSUE: variable of a compiler-generated type
                                        GClass3.Class446 class446 = new GClass3.Class446();
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated method
                                        class446.gclass85_0 = list9.OrderBy<FleetData, double>(class454.method_5)
                                            .FirstOrDefault<FleetData>();
                                        // ISSUE: reference to a compiler-generated field
                                        if (class446.gclass85_0 != null)
                                        {
                                            // ISSUE: reference to a compiler-generated method
                                            GClass117 gclass117_0_3 = list16.Where<GClass117>(class446.method_0)
                                                .OrderByDescending<GClass117, Decimal>(gclass117_0 =>
                                                    gclass117_0.gclass115_0.gclass22_0.Size)
                                                .FirstOrDefault<GClass117>();
                                            // ISSUE: reference to a compiler-generated field
                                            if (class454.gclass85_0.NPRSomething.method_9(gclass117_0_3, list11))
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                class454.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (list18.Contains(class454.gclass85_0))
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    if (this.gclass202_0.Race.SpecialNPRID != SpecialNPRIDs.Precursor &&
                                        this.gclass202_0.Race.SpecialNPRID != SpecialNPRIDs.const_3 &&
                                        this.gclass202_0.Race.SpecialNPRID != SpecialNPRIDs.StarSwarm &&
                                        !class454.gclass85_0.bNoSurrender)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        if (class454.gclass85_0.decimal_3 < this.gclass0_0.GameTime - 120M)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class454.gclass85_0.decimal_3 = this.gclass0_0.GameTime;
                                            int num2 = source
                                                .Select<ShipData, Species>(gclass40_0 => gclass40_0.gclass194_0)
                                                .Max<Species>(gclass194_0 => gclass194_0.int_7);
                                            int num3 = source
                                                .Select<ShipData, Species>(gclass40_0 => gclass40_0.gclass194_0)
                                                .Max<Species>(gclass194_0 => gclass194_0.int_2);
                                            double num4 = (200 - num2 - num3) / 10.0;
                                            double num5 = (num2 + num3) / 10.0;
                                            if (num1 == 0 && AuroraUtils.GetRandomInteger(100) < num4)
                                            {
                                                // ISSUE: reference to a compiler-generated method
                                                GameRace gclass21_1 = list15
                                                    .Select<GClass117, FleetData>(gclass117_0 =>
                                                        gclass117_0.gclass40_0.gclass85_0).Distinct<FleetData>()
                                                    .OrderBy<FleetData, double>(class454.method_1)
                                                    .Select<FleetData, GameRace>(gclass85_0 =>
                                                        gclass85_0.Race).FirstOrDefault<GameRace>();
                                                foreach (ShipData gclass40 in source)
                                                    gclass40.method_61(gclass21_1);
                                            }
                                            else if (AuroraUtils.GetRandomInteger(100) < num5)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                class454.gclass85_0.bNoSurrender = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        // ISSUE: object of a compiler-generated type is created
                                        // ISSUE: reference to a compiler-generated method
                                        List<GClass117> list20 = this.gclass202_0.Race.dictionary_12.Values
                                            .Where<GClass117>(new GClass3.Class455()
                                            {
                                                list_0 = this.gclass0_0.FormationDictionary.Values
                                                    .Where<GroundUnitFormationData>(gclass103_0 =>
                                                        gclass103_0.RaceData == this.gclass202_0.Race &&
                                                        gclass103_0.ShipData != null)
                                                    .Where<GroundUnitFormationData>(gclass103_0 =>
                                                        gclass103_0.ShipData.gclass21_0 !=
                                                        this.gclass202_0.Race)
                                                    .Select<GroundUnitFormationData, ShipData>(gclass103_0 =>
                                                        gclass103_0.ShipData).Distinct<ShipData>()
                                                    .ToList<ShipData>()
                                            }.method_0).ToList<GClass117>();
                                        List<GClass117> list21 = list16.Except<GClass117>(list20).ToList<GClass117>();
                                        if (list21.Count > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class454.gclass85_0.NPRSomething.method_1(list21);
                                        }
                                    }
                                }
                            }
                        }

                        list2 = list2.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
                        list5 = list5.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
                        list3 = list3.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
                    }

                    List<GClass117> list22 = list16.Where<GClass117>(gclass117_0 => gclass117_0.gclass40_0.int_15 > 0)
                        .ToList<GClass117>();
                    if (list22.Count > 0)
                    {
                        foreach (FleetData gclass85 in list2.Concat<FleetData>(list3).ToList<FleetData>())
                        {
                            // ISSUE: object of a compiler-generated type is created
                            // ISSUE: object of a compiler-generated type is created
                            // ISSUE: variable of a compiler-generated type
                            GClass3.Class448 class448 = new GClass3.Class448()
                            {
                                class447_0 = new GClass3.Class447()
                                {
                                    class444_0 = class444,
                                    gclass85_0 = gclass85
                                }
                            };
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class448.double_0 = class448.class447_0.gclass85_0.method_195() * 120 +
                                                class448.class447_0.gclass85_0.method_159();
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            GClass117 gclass117_0 = list22.Where<GClass117>(class448.method_0)
                                .OrderBy<GClass117, double>(class448.class447_0.method_0).FirstOrDefault<GClass117>();
                            if (gclass117_0 != null)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class448.class447_0.gclass85_0.NPRSomething.method_9(gclass117_0, list11);
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class448.class447_0.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                            }
                        }

                        list2 = list2.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
                        list3 = list3.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
                    }

                    if (list16.Count == 1)
                    {
                        this.method_15(
                            list2.OrderBy<FleetData, Decimal>(gclass85_0 => gclass85_0.decimal_7).ToList<FleetData>(),
                            list16[0], list11);
                        this.method_12(list16[0], list5);
                        list2 = list2.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
                    }
                    else if (list9.Count > 0)
                    {
                        foreach (FleetData gclass85 in list10)
                        {
                            gclass85.method_7();
                            gclass85.gclass85_4 = null;
                        }

                        int num = 0;
                        bool flag = false;
                        if (this.gclass202_0.Race.SpecialNPRID == SpecialNPRIDs.Precursor && list6.Count == 0)
                            this.method_10(list9, list11, list2, true);
                        else if (this.gclass202_0.Race.SpecialNPRID == SpecialNPRIDs.Eldar)
                        {
                            if (this.decimal_0 < this.decimal_1 * 2M)
                            {
                                // ISSUE: reference to a compiler-generated field
                                flag = this.gclass202_0.Race.UnknownNprClass.method_0(class444.gclass210_0,
                                    this.decimal_1 * 2M - this.decimal_0);
                                this.method_3(list1, true, !flag);
                            }
                            else
                                num = this.method_10(list9, list11, list2, false);
                        }
                        else if (this.decimal_1 > this.decimal_0 * 2M)
                            this.method_13(list1, list2, list3, list4, list15, list6, list11, list7, this.decimal_1,
                                this.decimal_0);
                        else if (this.decimal_1 > this.decimal_0)
                        {
                            if (list10.Count == 1)
                                this.method_13(list1, list2, list3, list4, list15, list6, list11, list7, this.decimal_1,
                                    this.decimal_0);
                            else
                                num = this.method_10(list9, list11, list2, false);
                        }
                        else
                            num = this.method_10(list9, list11, list2, false);

                        list2 = list2.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
                        if (list2.Count > 0 || num == 0)
                        {
                            if (this.gclass202_0.Race.SpecialNPRID == SpecialNPRIDs.Eldar)
                                this.method_3(list2, true, !flag);
                            else if (num == 0)
                                this.method_13(list1, list2, list3, list4, list15, list6, list11, list7, this.decimal_1,
                                    this.decimal_0);
                            else
                                this.method_14(list2, list9, list11, list6);
                            this.gclass202_0.Race.UnknownNprClass.method_13(list2);
                        }

                        if (list5.Count > 0)
                            this.method_11(list9, list5);
                    }

                    if (this.gclass202_0.Race.SpecialNPRID != SpecialNPRIDs.Eldar)
                    {
                        List<FleetData> list23 = list1.Where<FleetData>(gclass85_0 =>
                                gclass85_0.NPRSomething.genum103_0 < GEnum103.const_3 &&
                                gclass85_0.MoveOrderDictionary.Count == 0)
                            .ToList<FleetData>();
                        foreach (FleetData gclass85 in list23)
                            gclass85.NPRSomething.bRedeployOrderGiven = false;
                        this.gclass202_0.Race.UnknownNprClass.method_35(list23, list6, list11, true);
                    }

                    list2 = list2.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
                    list5 = list5.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
                    list3 = list3.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
                }

                new List<RacialSystemSurvey>() { this.gclass202_0 };
            }

            if (this.gclass202_0.Race.SpecialNPRID == SpecialNPRIDs.StarSwarm)
            {
                this.method_8(list1, list2, list_2, GEnum104.const_23);
                this.method_8(list1, list2, list_2, GEnum104.const_1);
                this.method_8(list1, list2, list_2, GEnum104.const_21);
                this.method_6(list1);
                this.method_9(list_0);
            }

            if (this.gclass202_0.Race.SpecialNPRID != SpecialNPRIDs.Eldar)
            {
                this.method_8(list1, list3, list_2, GEnum104.const_10);
                this.method_8(list1, list2, list_2, GEnum104.const_1);
                this.method_8(list1, list2, list_2, GEnum104.const_6);
                if (list5.Count > 0 || list2.Count > 0)
                    this.method_20(list2, list5);
            }
            else
            {
                List<FleetData> list24 = list1.Where<FleetData>(gclass85_0 =>
                    gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_27 &&
                    gclass85_0.NPRSomething.genum100_0 == GEnum100.const_2).ToList<FleetData>();
                List<FleetData> list25 = list1.Where<FleetData>(gclass85_0 =>
                    gclass85_0.NPROperationGroup.OperationalGroupId == OperationalGroupID.EldarSalvage &&
                    gclass85_0.NPRSomething.genum100_0 == GEnum100.const_2).ToList<FleetData>();
                int num = list1.Count<FleetData>(gclass85_0 =>
                    gclass85_0.NPROperationGroup.int_1 == 1 && gclass85_0.NPRSomething.genum100_0 > GEnum100.const_0);
                if (list24.Count > 0)
                {
                    foreach (FleetData gclass85 in list24)
                    {
                        if (gclass85.method_149() <= 0M)
                        {
                            gclass85.method_263();
                            // ISSUE: reference to a compiler-generated field
                            gclass85.method_232(class444.gclass210_0, MoveActionType.StandardTransit, gclass85.System);
                            gclass85.NPRSomething.bRedeployOrderGiven = true;
                        }
                    }

                    List<FleetData> list26 = list24.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven)
                        .ToList<FleetData>();
                    this.method_21(list26, list6);
                    this.method_20(list2, list26);
                    if (num == 0)
                    {
                        foreach (FleetData gclass85 in list26)
                        {
                            gclass85.method_263();
                            // ISSUE: reference to a compiler-generated field
                            gclass85.method_232(class444.gclass210_0, MoveActionType.StandardTransit, gclass85.System);
                            gclass85.NPRSomething.bRedeployOrderGiven = true;
                        }
                    }
                }

                if (list25.Count > 0)
                {
                    foreach (FleetData gclass85 in list25)
                    {
                        if (gclass85.method_147() <= 0M)
                        {
                            gclass85.method_263();
                            // ISSUE: reference to a compiler-generated field
                            gclass85.method_232(class444.gclass210_0, MoveActionType.StandardTransit, gclass85.System);
                            gclass85.NPRSomething.bRedeployOrderGiven = true;
                        }
                    }

                    this.method_22(list25, list6);
                    if (num == 0)
                    {
                        foreach (FleetData gclass85 in list25)
                        {
                            gclass85.method_263();
                            // ISSUE: reference to a compiler-generated field
                            gclass85.method_232(class444.gclass210_0, MoveActionType.StandardTransit, gclass85.System);
                            gclass85.NPRSomething.bRedeployOrderGiven = true;
                        }
                    }
                }

                List<FleetData> list27 = list2.Where<FleetData>(gclass85_0 =>
                    !gclass85_0.NPRSomething.bRedeployOrderGiven && gclass85_0.NPROperationGroup.OperationalGroupId == OperationalGroupID.LoneRaider &&
                    gclass85_0.EscapeTimeRemaining == 0.0).ToList<FleetData>();
                if (list27.Count > 0)
                {
                    this.method_18(list_0, list27, list9, true);
                }
                else
                {
                    List<FleetData> list28 = list2.Where<FleetData>(gclass85_0 =>
                    {
                        if (gclass85_0.NPRSomething.bRedeployOrderGiven || gclass85_0.EscapeTimeRemaining != 0.0)
                            return false;
                        return gclass85_0.NPROperationGroup.OperationalGroupId == OperationalGroupID.RaiderSquadron ||
                               gclass85_0.NPROperationGroup.OperationalGroupId == OperationalGroupID.RaidingGroup;
                    }).OrderBy<FleetData, OperationalGroupID>(gclass85_0 => gclass85_0.NPROperationGroup.OperationalGroupId).ToList<FleetData>();
                    if (list28.Count > 0)
                        this.method_18(list_0, list28, list9, false);
                }

                list2 = list2.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
            }

            if (list2.Count > 0)
            {
                foreach (FleetData gclass85 in list2
                             .Where<FleetData>(gclass85_0 => gclass85_0.NPROperationGroup.OperationalGroupId == OperationalGroupID.BeamFighterSquadron)
                             .ToList<FleetData>())
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GClass3.Class449 class449 = new GClass3.Class449();
                    // ISSUE: reference to a compiler-generated field
                    class449.class444_0 = class444;
                    // ISSUE: reference to a compiler-generated field
                    class449.gclass85_0 = gclass85;
                    // ISSUE: reference to a compiler-generated field
                    List<ShipData> list29 = class449.gclass85_0.method_176()
                        .Where<ShipData>(gclass40_0 => gclass40_0.gclass40_1 != null)
                        .Select<ShipData, ShipData>(gclass40_0 => gclass40_0.gclass40_1)
                        .Distinct<ShipData>().ToList<ShipData>();
                    if (list29.Count != 0)
                    {
                        // ISSUE: reference to a compiler-generated method
                        ShipData gclass40 = list29.OrderBy<ShipData, double>(class449.method_0)
                            .FirstOrDefault<ShipData>();
                        // ISSUE: reference to a compiler-generated field
                        class449.gclass85_0.method_263();
                        // ISSUE: reference to a compiler-generated field
                        class449.gclass85_0.method_222(gclass40.gclass85_0, MoveActionType.FollowTarget);
                        // ISSUE: reference to a compiler-generated field
                        class449.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                    }
                }

                list2 = list2.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
            }

            if (list6.Count > 0 && list2.Count > 0 && this.gclass202_0.Race.SpecialNPRID != SpecialNPRIDs.StarSwarm)
                this.method_23(list6, list2);
            if (this.gclass202_0.Race.SpecialNPRID != SpecialNPRIDs.Eldar)
            {
                if (list5.Count > 0)
                {
                    List<FleetData> list30 = list5.Where<FleetData>(gclass85_0 => gclass85_0.EscapeTimeRemaining == 0.0)
                        .ToList<FleetData>();
                    this.method_18(list_0, list30, list9, true);
                }
                else
                {
                    List<FleetData> list31 = list2.Where<FleetData>(gclass85_0 =>
                        !gclass85_0.NPRSomething.bRedeployOrderGiven && gclass85_0.EscapeTimeRemaining == 0.0 &&
                        gclass85_0.NPROperationGroup.OperationalGroupId == OperationalGroupID.FACHunterSquadron).ToList<FleetData>();
                    this.method_18(list_0, list31, list9, false);
                    list2.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
                }
            }

            List<FleetData> list32 = list_0.Where<FleetData>(gclass85_0 =>
                !gclass85_0.NPRSomething.bRedeployOrderGiven && gclass85_0.System == this.gclass202_0 &&
                gclass85_0.EscapeTimeRemaining > 0.0).ToList<FleetData>();
            if (this.gclass202_0.Race.SpecialNPRID == SpecialNPRIDs.Precursor)
                list32 = list32.Where<FleetData>(gclass85_0 => gclass85_0.NPROperationGroup.bool_1).ToList<FleetData>();
            if (list32.Count > 0)
                this.method_3(list32, true, false);
            List<FleetData> list33 = list_0.Where<FleetData>(gclass85_0 =>
            {
                if (gclass85_0.NPRSomething.bRedeployOrderGiven || gclass85_0.System != this.gclass202_0)
                    return false;
                return gclass85_0.NPROperationGroup.bool_2 || gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_5 ||
                       gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_10;
            }).ToList<FleetData>();
            if (list33.Count <= 0)
                return;
            if (list6.Count > 0)
            {
                foreach (FleetData gclass85 in list33)
                {
                    if (gclass85.XCoord != list6[0].method_87() || gclass85.YCoord != list6[0].method_88())
                        gclass85.method_219(list6[0], MoveActionType.RefuelFromColony);
                }
            }
            else
            {
                if (this.gclass202_0.Race.SpecialNPRID == SpecialNPRIDs.Precursor)
                {
                    SystemBodyData gclass1_1 = this.gclass0_0.SystemBodyRecordDic.Values
                        .Where<SystemBodyData>(gclass1_0 =>
                            gclass1_0.SystemData == this.gclass202_0.ActualSystem)
                        .Where<SystemBodyData>(gclass1_0 => gclass1_0.AbandonedFactories > 0)
                        .OrderByDescending<SystemBodyData, int>(gclass1_0 => gclass1_0.AbandonedFactories)
                        .FirstOrDefault<SystemBodyData>();
                    if (gclass1_1 != null)
                    {
                        using (List<FleetData>.Enumerator enumerator = list33.GetEnumerator())
                        {
                            while (enumerator.MoveNext())
                                enumerator.Current.method_215(gclass1_1, MoveActionType.MoveTo);
                            return;
                        }
                    }
                }

                FleetData gclass85_5 = list_0
                    .Where<FleetData>(gclass85_0 =>
                        gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_18 &&
                        gclass85_0.System == this.gclass202_0 && gclass85_0.OrbitingBody != null)
                    .OrderByDescending<FleetData, int>(gclass85_0 => gclass85_0.method_179()).FirstOrDefault<FleetData>();
                if (gclass85_5 != null)
                {
                    foreach (FleetData gclass85 in list33)
                        gclass85.method_222(gclass85_5, MoveActionType.RefuelFromStationaryTankers);
                }
                else
                {
                    foreach (FleetData gclass85 in list33)
                    {
                        SystemBodyData gclass1_1 =
                            this.gclass202_0.ActualSystem.method_23(gclass85.XCoord, gclass85.YCoord);
                        if (gclass1_1 != null)
                            gclass85.method_215(gclass1_1, MoveActionType.MoveTo);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 64 /*0x40*/);
        }
    }

    public void method_8(
        List<FleetData> list_0,
        List<FleetData> list_1,
        List<RacialSystemSurvey> list_2,
        GEnum104 genum104_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class458 class458 = new GClass3.Class458();
        // ISSUE: reference to a compiler-generated field
        class458.genum104_0 = genum104_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            if (list_1.FirstOrDefault<FleetData>(class458.method_0) == null)
                return;
            // ISSUE: reference to a compiler-generated field
            this.gclass202_0.Race.UnknownNprClass.method_47(this.gclass202_0, list_2, list_0, class458.genum104_0,
                false);
            // ISSUE: reference to a compiler-generated field
            this.gclass202_0.Race.UnknownNprClass.method_47(this.gclass202_0, list_2, list_0, class458.genum104_0,
                true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 65);
        }
    }

    public void method_9(List<FleetData> list_0)
    {
        try
        {
            List<FleetData> list = list_0.Where<FleetData>(gclass85_0 => gclass85_0.System == this.gclass202_0)
                .ToList<FleetData>();
            if (list.Count == 0)
                return;
            foreach (FleetData gclass85_1 in list
                         .Where<FleetData>(gclass85_0 => gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_24)
                         .ToList<FleetData>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class459 class459 = new GClass3.Class459();
                // ISSUE: reference to a compiler-generated field
                class459.gclass3_0 = this;
                // ISSUE: reference to a compiler-generated field
                class459.gclass85_0 = gclass85_1;
                // ISSUE: reference to a compiler-generated method
                FleetData gclass85_5 = list
                    .Where<FleetData>(gclass85_0 => gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_22)
                    .OrderBy<FleetData, double>(class459.method_0).FirstOrDefault<FleetData>();
                if (gclass85_5 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    class459.gclass85_0.method_263();
                    // ISSUE: reference to a compiler-generated field
                    class459.gclass85_0.method_222(gclass85_5, MoveActionType.FollowTarget);
                    // ISSUE: reference to a compiler-generated field
                    class459.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated method
                    foreach (FleetData gclass85_2 in this.gclass0_0.FleetDictionary.Values
                                 .Where<FleetData>(gclass85_0 =>
                                     gclass85_0.Race == this.gclass202_0.Race &&
                                     gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_22)
                                 .OrderBy<FleetData, int>(class459.method_1).ToList<FleetData>())
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (class459.gclass85_0.method_236(GEnum109.const_41, "", false,
                                gclass85_2.System.ActualSystem.SystemID, false).gclass202_0 != null)
                        {
                            // ISSUE: reference to a compiler-generated field
                            class459.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 66);
        }
    }

    public int method_10(
        List<FleetData> list_0,
        List<PopulationData> list_1,
        List<FleetData> list_2,
        bool bool_0)
    {
        try
        {
            if (list_0.Count == 0)
                return 0;
            int num1 = 0;
            list_2 = list_2.OrderByDescending<FleetData, Decimal>(gclass85_0 => gclass85_0.decimal_7).ToList<FleetData>();
            foreach (FleetData gclass85_1 in list_2)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class460 class460 = new GClass3.Class460();
                // ISSUE: reference to a compiler-generated field
                class460.gclass85_0 = gclass85_1;
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class461 class461 = new GClass3.Class461();
                // ISSUE: reference to a compiler-generated field
                class461.class460_0 = class460;
                foreach (FleetData gclass85_2 in list_0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass85_2.double_8 = this.gclass0_0.GetDistanceToNearestGClass212(this.gclass202_0.ActualSystem,
                        class461.class460_0.gclass85_0.XCoord, class461.class460_0.gclass85_0.YCoord,
                        gclass85_2.XCoord, gclass85_2.YCoord);
                    double num2 = (AuroraUtils.double_9 - gclass85_2.double_8) / AuroraUtils.double_9;
                    if (num2 < 0.1)
                        num2 = 0.1;
                    gclass85_2.double_9 = num2 * (double)gclass85_2.decimal_7;
                }

                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                FleetData gclass85_3 = list_0.Where<FleetData>(class461.class460_0.method_0)
                    .OrderBy<FleetData, double>(gclass85_0 => gclass85_0.double_8).FirstOrDefault<FleetData>();
                if (gclass85_3 != null)
                {
                    GClass117 gclass117_0 = this.gclass202_0.Race.method_267(gclass85_3.method_176()
                        .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.gclass22_0.Size)
                        .FirstOrDefault<ShipData>());
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class461.class460_0.gclass85_0.NPRSomething.method_9(gclass117_0, list_1);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class461.class460_0.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                    ++num1;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass85_3.gclass85_4 = class461.class460_0.gclass85_0;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    class461.decimal_0 = 0.5M;
                    while (true)
                    {
                        List<FleetData> source = list_0;
                        // ISSUE: reference to a compiler-generated field
                        Func<FleetData, bool> func0 = class461.func_0;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        Func<FleetData, bool> predicate = func0 == null ? (class461.func_0 = class461.method_0) : func0;
                        foreach (FleetData gclass85_1_1 in source.Where<FleetData>(predicate)
                                     .OrderByDescending<FleetData, double>(gclass85_0 => gclass85_0.double_9)
                                     .ToList<FleetData>())
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (this.method_5(class461.class460_0.gclass85_0, gclass85_1_1, list_0, list_1,
                                    AuroraUtils.double_10,
                                    class461.class460_0.gclass85_0.decimal_7 * class461.decimal_0))
                            {
                                GClass117 gclass117_0 = this.gclass202_0.Race.method_267(gclass85_1_1.method_176()
                                    .OrderByDescending<ShipData, Decimal>(gclass40_0 =>
                                        gclass40_0.gclass22_0.Size).FirstOrDefault<ShipData>());
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class461.class460_0.gclass85_0.NPRSomething.method_9(gclass117_0, list_1);
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class461.class460_0.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                                ++num1;
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                gclass85_1_1.gclass85_4 = class461.class460_0.gclass85_0;
                                break;
                            }
                        }

                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (bool_0 && !class461.class460_0.gclass85_0.NPRSomething.bRedeployOrderGiven && !(class461.decimal_0 == 1M))
                        {
                            // ISSUE: reference to a compiler-generated field
                            class461.decimal_0 += 0.1M;
                        }
                        else
                            break;
                    }

                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (!class461.class460_0.gclass85_0.NPRSomething.bRedeployOrderGiven)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        foreach (FleetData gclass85_1_2 in list_0.Where<FleetData>(class461.class460_0.method_1)
                                     .OrderByDescending<FleetData, double>(gclass85_0 => gclass85_0.double_9)
                                     .ToList<FleetData>())
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            double num3 = this.gclass0_0.GetDistanceBetween(gclass85_1_2.XCoord, gclass85_1_2.YCoord,
                                class461.class460_0.gclass85_0.XCoord, class461.class460_0.gclass85_0.YCoord);
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (this.gclass0_0.GetDistanceBetween(gclass85_1_2.XCoord, gclass85_1_2.YCoord,
                                    gclass85_1_2.gclass85_4.XCoord, gclass85_1_2.gclass85_4.YCoord) <= num3 &&
                                this.method_5(class461.class460_0.gclass85_0, gclass85_1_2, list_0, list_1,
                                    AuroraUtils.double_10, class461.class460_0.gclass85_0.decimal_7))
                            {
                                GClass117 gclass117_0 = this.gclass202_0.Race.method_267(gclass85_1_2.method_176()
                                    .OrderByDescending<ShipData, Decimal>(gclass40_0 =>
                                        gclass40_0.gclass22_0.Size).FirstOrDefault<ShipData>());
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class461.class460_0.gclass85_0.NPRSomething.method_9(gclass117_0, list_1);
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class461.class460_0.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                                ++num1;
                                break;
                            }
                        }
                    }
                }
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 67);
            return 0;
        }
    }

    public void method_11(List<FleetData> list_0, List<FleetData> list_1)
    {
        try
        {
            if (list_1.Count == 0)
                return;
            list_0.Where<FleetData>(gclass85_0 => gclass85_0.gclass85_4 == null)
                .OrderByDescending<FleetData, Decimal>(gclass85_0 => gclass85_0.decimal_7).ToList<FleetData>();
            foreach (FleetData gclass85_1 in list_0)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class462 class462 = new GClass3.Class462();
                // ISSUE: reference to a compiler-generated field
                class462.gclass3_0 = this;
                // ISSUE: reference to a compiler-generated field
                class462.gclass85_0 = gclass85_1;
                // ISSUE: reference to a compiler-generated method
                FleetData gclass85_2 = list_1.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven)
                    .OrderBy<FleetData, double>(class462.method_0).FirstOrDefault<FleetData>();
                if (gclass85_2 == null)
                    break;
                // ISSUE: reference to a compiler-generated field
                GClass117 gclass117_0 = this.gclass202_0.Race.method_267(class462.gclass85_0.method_176()
                    .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.gclass22_0.Size)
                    .FirstOrDefault<ShipData>());
                gclass85_2.NPRSomething.method_11(gclass117_0);
                gclass85_2.NPRSomething.bRedeployOrderGiven = true;
                list_1 = list_1.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 68);
        }
    }

    public void method_12(GClass117 gclass117_0, List<FleetData> list_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class463 class463 = new GClass3.Class463();
        // ISSUE: reference to a compiler-generated field
        class463.gclass3_0 = this;
        // ISSUE: reference to a compiler-generated field
        class463.gclass117_0 = gclass117_0;
        try
        {
            if (list_0.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated method
            FleetData gclass85 = list_0.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven)
                .OrderBy<FleetData, double>(class463.method_0).FirstOrDefault<FleetData>();
            if (gclass85 == null)
                return;
            // ISSUE: reference to a compiler-generated field
            gclass85.NPRSomething.method_11(class463.gclass117_0);
            gclass85.NPRSomething.bRedeployOrderGiven = true;
            list_0 = list_0.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 69);
        }
    }

    public void method_13(
        List<FleetData> list_0,
        List<FleetData> list_1,
        List<FleetData> list_2,
        List<FleetData> list_3,
        List<GClass117> list_4,
        List<PopulationData> list_5,
        List<PopulationData> list_6,
        List<GroundUnitFormationElement> list_7,
        Decimal decimal_2,
        Decimal decimal_3)
    {
        try
        {
            if (list_5.Count > 0)
            {
                List<SystemBodyData> list1 = list_6
                    .Select<PopulationData, SystemBodyData>(gclass146_0 => gclass146_0.SystemBodyData)
                    .Distinct<SystemBodyData>().ToList<SystemBodyData>();
                foreach (PopulationData gclass146 in list_5)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GClass3.Class464 class464 = new GClass3.Class464();
                    // ISSUE: reference to a compiler-generated field
                    class464.gclass146_0 = gclass146;
                    // ISSUE: reference to a compiler-generated field
                    if (class464.gclass146_0.gclass6_0.genum97_0 > GEnum97.const_2)
                    {
                        // ISSUE: reference to a compiler-generated method
                        List<FleetData> list2 = list_3.Where<FleetData>(class464.method_0).ToList<FleetData>();
                        // ISSUE: reference to a compiler-generated method
                        List<GroundUnitFormationElement> list3 = list_7.Where<GroundUnitFormationElement>(class464.method_1).ToList<GroundUnitFormationElement>();
                        // ISSUE: reference to a compiler-generated field
                        if ((list2.Count != 0 || list3.Count != 0) && !list1.Contains(class464.gclass146_0.SystemBodyData))
                        {
                            Decimal num = decimal_3;
                            if (list2.Count > 0)
                                num += list2.SelectMany<FleetData, ShipData>(gclass85_0 => gclass85_0.method_176())
                                    .Sum<ShipData>(gclass40_0 => gclass40_0.gclass22_0.ClassCrossSection * 5000M);
                            if (list3.Count > 0)
                                num += list3.Sum<GroundUnitFormationElement>(gclass39_0 => gclass39_0.GroundUnitClass.decimal_2 * 100M);
                            if (!(decimal_2 > num * 1.5M))
                            {
                                // ISSUE: reference to a compiler-generated field
                                this.method_16(list_1, class464.gclass146_0);
                                // ISSUE: reference to a compiler-generated field
                                this.method_16(list_2, class464.gclass146_0);
                                this.method_3(
                                    list_0.Except<FleetData>(list_1).Except<FleetData>(list_2).Except<FleetData>(list_3)
                                        .ToList<FleetData>(), true, false);
                                return;
                            }
                        }
                    }
                    else
                        break;
                }
            }

            this.method_3(list_0.Except<FleetData>(list_3).ToList<FleetData>(), true, false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 70);
        }
    }

    public void method_14(
        List<FleetData> list_0,
        List<FleetData> list_1,
        List<PopulationData> list_2,
        List<PopulationData> list_3)
    {
        try
        {
            foreach (FleetData gclass85_0 in list_0)
            {
                foreach (PopulationData gclass146_1 in list_3)
                {
                    double double_0 = gclass146_1.method_87();
                    double double_1 = gclass146_1.method_88();
                    if (this.method_4(gclass85_0, list_1, list_2, double_0, double_1, AuroraUtils.int_7))
                    {
                        gclass85_0.method_263();
                        gclass85_0.method_219(gclass146_1, MoveActionType.MoveTo);
                        gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3413);
        }
    }

    public bool method_15(List<FleetData> list_0, GClass117 gclass117_0, List<PopulationData> list_1)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class465 class465 = new GClass3.Class465();
        // ISSUE: reference to a compiler-generated field
        class465.gclass3_0 = this;
        // ISSUE: reference to a compiler-generated field
        class465.gclass117_0 = gclass117_0;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass3.Class466 class466 = new GClass3.Class466();
            // ISSUE: reference to a compiler-generated field
            class466.decimal_0 = 0M;
            // ISSUE: reference to a compiler-generated field
            if (!class465.gclass117_0.gclass40_0.gclass22_0.Commercial)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class466.decimal_0 = class465.gclass117_0.gclass40_0.gclass22_0.ClassCrossSection *
                                     class465.gclass117_0.gclass40_0.gclass22_0.MaxSpeed;
            }

            if (list_0.Count > 0)
            {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                FleetData gclass85 = list_0.Where<FleetData>(class466.method_0)
                    .OrderBy<FleetData, double>(class465.method_0).FirstOrDefault<FleetData>();
                if (gclass85 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    gclass85.NPRSomething.method_9(class465.gclass117_0, list_1);
                    gclass85.NPRSomething.bRedeployOrderGiven = true;
                    return true;
                }
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 71);
            return false;
        }
    }

    public void method_16(List<FleetData> list_0, PopulationData gclass146_0)
    {
        try
        {
            foreach (FleetData gclass85 in list_0)
            {
                if (gclass85.XCoord == gclass146_0.method_87() && gclass85.YCoord == gclass146_0.method_88())
                {
                    gclass85.NPRSomething.bRedeployOrderGiven = true;
                }
                else
                {
                    gclass85.method_219(gclass146_0, MoveActionType.RefuelFromColony);
                    gclass85.NPRSomething.bRedeployOrderGiven = true;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 72);
        }
    }

    public void method_17(List<FleetData> list_0, GClass117 gclass117_0, List<PopulationData> list_1)
    {
        try
        {
            foreach (FleetData gclass85 in list_0)
            {
                gclass85.NPRSomething.method_9(gclass117_0, list_1);
                gclass85.NPRSomething.bRedeployOrderGiven = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 73);
        }
    }

    public void method_18(
        List<FleetData> list_0,
        List<FleetData> list_1,
        List<FleetData> list_2,
        bool bool_0)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass3.Class467 class467 = new GClass3.Class467();
            List<Waypoint> list1 = this.gclass0_0.Waypoints.Values.Where<Waypoint>(gclass214_0 =>
            {
                if (gclass214_0.System != this.gclass202_0.ActualSystem ||
                    gclass214_0.Race != this.gclass202_0.Race)
                    return false;
                return gclass214_0.WaypointType == WayPointType.UrgentPOI ||
                       gclass214_0.WaypointType == WayPointType.POI;
            }).ToList<Waypoint>();
            if (list1.Count == 0)
                return;
            if (bool_0 && list_2.Count > 0)
            {
                foreach (Waypoint gclass214 in list1.ToList<Waypoint>())
                {
                    foreach (FleetData gclass85 in list_2)
                    {
                        if (this.gclass0_0.GetDistanceBetween(gclass214.Xcor, gclass214.Ycor, gclass85.XCoord,
                                gclass85.YCoord) < AuroraUtils.int_7)
                        {
                            list1.Remove(gclass214);
                            break;
                        }
                    }
                }
            }

            if (list1.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated field
            class467.list_0 = list_0.SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                .Where<MoveOrder>(gclass139_0 =>
                    gclass139_0.DestinationType == DestinationType.const_3 && gclass139_0.StartSystem == this.gclass202_0)
                .Select<MoveOrder, int>(gclass139_0 => gclass139_0.DestinationID).ToList<int>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            class467.list_1 = list1.Where<Waypoint>(class467.method_0).ToList<Waypoint>();
            foreach (FleetData gclass85_0 in list_1)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                List<Waypoint> list2 = list1.Where<Waypoint>(class467.func_0 ?? (class467.func_0 = class467.method_1))
                    .Where<Waypoint>(class467.func_1 ?? (class467.func_1 = class467.method_2)).ToList<Waypoint>();
                if (list2.Count != 0 && !this.method_19(gclass85_0, list2, WayPointType.UrgentPOI, 20))
                    this.method_19(gclass85_0, list2, WayPointType.POI, 20);
            }

            list_1 = list_1.Where<FleetData>(gclass85_0 =>
                !gclass85_0.NPRSomething.bRedeployOrderGiven && gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_5).ToList<FleetData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 74);
        }
    }

    public bool method_19(
        FleetData gclass85_0,
        List<Waypoint> list_0,
        WayPointType wayPointType_0,
        int int_4)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass3.Class468 class468 = new GClass3.Class468();
        // ISSUE: reference to a compiler-generated field
        class468.wayPointType_0 = wayPointType_0;
        // ISSUE: reference to a compiler-generated field
        class468.gclass3_0 = this;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass3.Class469 class469 = new GClass3.Class469();
            // ISSUE: reference to a compiler-generated field
            class469.class468_0 = class468;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            List<Waypoint> list = list_0.Where<Waypoint>(class469.class468_0.method_0).ToList<Waypoint>();
            if (list.Count == 0)
                return false;
            // ISSUE: reference to a compiler-generated field
            class469.double_0 = gclass85_0.XCoord;
            // ISSUE: reference to a compiler-generated field
            class469.double_1 = gclass85_0.YCoord;
            gclass85_0.method_263();
            for (int index = 1; index < int_4; ++index)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                Waypoint gclass214_0 = list
                    .OrderBy<Waypoint, double>(class469.func_0 ?? (class469.func_0 = class469.method_0))
                    .FirstOrDefault<Waypoint>();
                if (gclass214_0 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    class469.double_0 = gclass214_0.Xcor;
                    // ISSUE: reference to a compiler-generated field
                    class469.double_1 = gclass214_0.Ycor;
                    gclass85_0.method_217(gclass214_0, MoveActionType.MoveTo, this.gclass202_0);
                    list.Remove(gclass214_0);
                }
            }

            gclass85_0.NPRSomething.bRedeployOrderGiven = true;
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 75);
            return false;
        }
    }

    public void method_20(List<FleetData> list_0, List<FleetData> list_1)
    {
        try
        {
            List<GClass59> list = this.gclass0_0.dictionary_30.Values
                .Where<GClass59>(gclass59_0 => gclass59_0.gclass200_0 == this.gclass202_0.ActualSystem)
                .ToList<GClass59>();
            GClass59 gclass59 = null;
            list_0 = list_0.OrderBy<FleetData, Decimal>(gclass85_0 => gclass85_0.decimal_7).ToList<FleetData>();
            foreach (GClass59 gclass59_0 in list)
            {
                if (gclass59 == null || this.gclass0_0.GetDistanceBetween(gclass59_0.double_0, gclass59_0.double_1,
                        gclass59.double_0, gclass59.double_1) >= 100000000.0)
                {
                    FleetData gclass85_1 = list_1.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven)
                        .OrderByDescending<FleetData, int>(gclass85_0 => gclass85_0.Speed).FirstOrDefault<FleetData>();
                    if (gclass85_1 != null)
                    {
                        gclass85_1.method_263();
                        gclass85_1.method_218(gclass59_0, MoveActionType.RescueSurvivors, this.gclass202_0);
                        gclass85_1.NPRSomething.bRedeployOrderGiven = true;
                        gclass59 = gclass59_0;
                    }
                    else
                    {
                        FleetData gclass85_2 = list_0.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven)
                            .OrderBy<FleetData, Decimal>(gclass85_0 => gclass85_0.decimal_7)
                            .ThenByDescending<FleetData, GEnum100>(gclass85_0 => gclass85_0.NPRSomething.genum100_0)
                            .FirstOrDefault<FleetData>();
                        if (gclass85_2 != null)
                        {
                            gclass85_2.method_263();
                            gclass85_2.method_218(gclass59_0, MoveActionType.RescueSurvivors, this.gclass202_0);
                            gclass85_2.NPRSomething.bRedeployOrderGiven = true;
                            gclass59 = gclass59_0;
                        }
                        else
                            break;
                    }
                }
            }

            list_0 = list_0.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
            list_1 = list_1.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 76);
        }
    }

    public void method_21(List<FleetData> list_0, List<PopulationData> list_1)
    {
        try
        {
            List<PopulationData> list = list_1.Where<PopulationData>(gclass146_0 => gclass146_0.Population > 0M)
                .ToList<PopulationData>();
            if (list.Count == 0)
                return;
            foreach (FleetData gclass85 in list_0)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class470 class470 = new GClass3.Class470();
                // ISSUE: reference to a compiler-generated field
                class470.gclass3_0 = this;
                // ISSUE: reference to a compiler-generated field
                class470.gclass85_0 = gclass85;
                // ISSUE: reference to a compiler-generated method
                PopulationData gclass146_1 = list.OrderBy<PopulationData, double>(class470.method_0).FirstOrDefault<PopulationData>();
                // ISSUE: reference to a compiler-generated field
                class470.gclass85_0.method_263();
                // ISSUE: reference to a compiler-generated field
                class470.gclass85_0.method_219(gclass146_1, MoveActionType.LoadColonists);
                // ISSUE: reference to a compiler-generated field
                class470.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
            }

            list_0 = list_0.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3419);
        }
    }

    public void method_22(List<FleetData> list_0, List<PopulationData> list_1)
    {
        try
        {
            List<PopulationData> list = list_1.Where<PopulationData>(gclass146_0 => gclass146_0.CurrentMinerals.GetTotalAmount() > 1000M)
                .ToList<PopulationData>();
            if (list.Count == 0)
                return;
            foreach (FleetData gclass85 in list_0)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class471 class471 = new GClass3.Class471();
                // ISSUE: reference to a compiler-generated field
                class471.gclass3_0 = this;
                // ISSUE: reference to a compiler-generated field
                class471.gclass85_0 = gclass85;
                // ISSUE: reference to a compiler-generated method
                PopulationData gclass146_1 = list.OrderBy<PopulationData, double>(class471.method_0).FirstOrDefault<PopulationData>();
                // ISSUE: reference to a compiler-generated field
                class471.gclass85_0.method_263();
                // ISSUE: reference to a compiler-generated field
                class471.gclass85_0.method_219(gclass146_1, MoveActionType.LoadAllMinerals);
                // ISSUE: reference to a compiler-generated field
                class471.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
            }

            list_0 = list_0.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3419);
        }
    }

    public void method_23(List<PopulationData> list_0, List<FleetData> list_1)
    {
        try
        {
            list_0 = this.gclass202_0.method_46()
                .OrderByDescending<PopulationData, GEnum97>(gclass146_0 => gclass146_0.gclass6_0.genum97_0)
                .ThenByDescending<PopulationData, int>(gclass146_0 => gclass146_0.gclass6_0.int_0)
                .ThenByDescending<PopulationData, double>(gclass146_0 => gclass146_0.gclass6_0.double_2).ToList<PopulationData>();
            foreach (PopulationData gclass146 in list_0)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass3.Class472 class472 = new GClass3.Class472();
                // ISSUE: reference to a compiler-generated field
                class472.gclass3_0 = this;
                // ISSUE: reference to a compiler-generated field
                class472.gclass146_0 = gclass146;
                // ISSUE: reference to a compiler-generated method
                if (list_1.Where<FleetData>(gclass85_0 => gclass85_0.NPRSomething.genum100_0 == GEnum100.const_2)
                        .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                        .Where<MoveOrder>(class472.method_0).Count<MoveOrder>() <= 0)
                {
                    // ISSUE: reference to a compiler-generated method
                    FleetData gclass85 = list_1.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven)
                        .OrderByDescending<FleetData, Decimal>(gclass85_0 => gclass85_0.decimal_7)
                        .OrderByDescending<FleetData, GEnum100>(gclass85_0 => gclass85_0.NPRSomething.genum100_0)
                        .OrderBy<FleetData, double>(class472.method_1).FirstOrDefault<FleetData>();
                    if (gclass85 != null)
                    {
                        if (gclass85.XCoord == list_0[0].method_87() && gclass85.YCoord == list_0[0].method_88())
                        {
                            gclass85.method_263();
                            gclass85.NPRSomething.bRedeployOrderGiven = true;
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (gclass85.method_29(class472.gclass146_0))
                            {
                                gclass85.method_263();
                                // ISSUE: reference to a compiler-generated field
                                gclass85.method_219(class472.gclass146_0, MoveActionType.RefuelFromColony);
                                gclass85.NPRSomething.bRedeployOrderGiven = true;
                            }
                        }
                    }
                }
            }

            list_1 = list_1.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 77);
        }
    }

    public void method_24(List<ShipData> list_0)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass3.Class473 class473 = new GClass3.Class473();
            if (this.genum95_0 == GEnum95.const_0 || this.genum95_0 == GEnum95.const_6)
                return;
            List<ShipData> list1 = list_0
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0.System == this.gclass202_0)
                .ToList<ShipData>();
            // ISSUE: reference to a compiler-generated field
            class473.list_0 = this.gclass202_0.method_46();
            if (this.gclass202_0.Race.SpecialNPRID == SpecialNPRIDs.StarSwarm)
            {
                double num1 = 0.0;
                List<Wreck> list2 = this.gclass0_0.Wrecks.Values
                    .Where<Wreck>(gclass233_0 => gclass233_0.System == this.gclass202_0.ActualSystem)
                    .ToList<Wreck>();
                if (list2.Count > 0)
                    num1 += (int)(list2.Sum<Wreck>(gclass233_0 => gclass233_0.ShipClass.Cost) / 50M);
                List<ShipData> list3 = list1.Where<ShipData>(gclass40_0 => !gclass40_0.gclass22_0.method_33())
                    .ToList<ShipData>();
                if (list3.Count > 0)
                    num1 += (int)(list3.Sum<ShipData>(gclass40_0 => gclass40_0.gclass22_0.Cost) / 10M);
                // ISSUE: reference to a compiler-generated field
                List<PopulationData> list4 = class473.list_0
                    .Where<PopulationData>(gclass146_0 => gclass146_0.dictionary_0.Count > 0).ToList<PopulationData>();
                if (list4.Count > 0)
                    num1 += (int)(list4.SelectMany<PopulationData, PopulationInstallation>(gclass146_0 => gclass146_0.dictionary_0.Values)
                                      .Sum<PopulationInstallation>(gclass158_0 =>
                                          gclass158_0.InstallationType.Cost * gclass158_0.Amount) /
                                  10M);
                // ISSUE: reference to a compiler-generated method
                List<GClass193> list5 = this.gclass0_0.dictionary_31.Values.Where<GClass193>(class473.method_0)
                    .ToList<GClass193>();
                if (list5.Count > 0)
                    num1 += (int)(list5.Sum<GClass193>(gclass193_0 => gclass193_0.int_1 * gclass193_0.decimal_0) /
                                  100M);
                // ISSUE: reference to a compiler-generated method
                List<GClass193> list6 = this.gclass0_0.dictionary_31.Values.Where<GClass193>(class473.method_1)
                    .ToList<GClass193>();
                if (list6.Count > 0)
                    num1 +=
                        (int)(list6.Sum<GClass193>(gclass193_0 => gclass193_0.int_1 * gclass193_0.decimal_0) / 1000M);
                double num2 = num1 + (int)(this.gclass0_0.SystemBodyRecordDic.Values
                    .Where<SystemBodyData>(gclass1_0 => gclass1_0.SystemData == this.gclass202_0.ActualSystem)
                    .Where<SystemBodyData>(gclass1_0 => gclass1_0.MineralDeposits.Values.Count > 3)
                    .Where<SystemBodyData>(gclass1_0 => gclass1_0.method_16(50, false))
                    .Sum<SystemBodyData>(gclass1_0 => gclass1_0.method_17()) / 2.0);
                this.genum95_0 = num2 <= 200.0
                    ? (num2 <= 50.0 ? (num2 <= 20.0 ? GEnum95.const_2 : GEnum95.const_3) : GEnum95.const_4)
                    : GEnum95.const_5;
            }
            else if (this.gclass202_0.Race.SpecialNPRID == SpecialNPRIDs.const_3)
            {
                Decimal num = this.gclass0_0.Populations.Values
                    .Where<PopulationData>(
                        gclass146_0 => gclass146_0.gclass202_0.ActualSystem == this.gclass202_0.ActualSystem)
                    .Sum<PopulationData>(gclass146_0 => gclass146_0.method_190());
                if (num > 20000M)
                {
                    this.genum95_0 = GEnum95.const_5;
                    return;
                }

                if (num > 5000M)
                {
                    this.genum95_0 = GEnum95.const_4;
                    return;
                }

                if (num > 1000M)
                {
                    this.genum95_0 = GEnum95.const_3;
                    return;
                }

                if (num > 1000M)
                {
                    this.genum95_0 = GEnum95.const_2;
                    return;
                }

                this.genum95_0 = GEnum95.const_1;
                return;
            }

            // ISSUE: reference to a compiler-generated field
            Decimal num3 = class473.list_0.Sum<PopulationData>(gclass146_0 => gclass146_0.decimal_30);
            if (num3 > 100M)
            {
                this.genum95_0 = GEnum95.const_5;
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                int num4 = class473.list_0.Sum<PopulationData>(gclass146_0 => gclass146_0.gclass6_0.int_0);
                // ISSUE: reference to a compiler-generated field
                if (class473.list_0.Count > 0)
                {
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    num4 = num4 +
                           list1.Where<ShipData>(gclass40_0 =>
                                   gclass40_0.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID == AutomatedClassDesignType.AsteroidMiner &&
                                   gclass40_0.gclass85_0.AssignedPopulation != null).Where<ShipData>(class473.method_2)
                               .Sum<ShipData>(gclass40_0 =>
                                   gclass40_0.method_167(AuroraComponentType.OrbitalMiningModule)) + (int)Math.Round(
                               list1
                                   .Where<ShipData>(gclass40_0 =>
                                       gclass40_0.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID == AutomatedClassDesignType.TerraFormer &&
                                       gclass40_0.gclass85_0.AssignedPopulation != null)
                                   .Where<ShipData>(class473.method_3)
                                   .Sum<ShipData>(gclass40_0 =>
                                       gclass40_0.method_167(AuroraComponentType.TerraformingModule) * 4.0));
                }

                List<ShipData> list7 = list1
                    .Where<ShipData>(gclass40_0 => gclass40_0.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID == AutomatedClassDesignType.Harvester)
                    .ToList<ShipData>();
                if (list7.Count > 0)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: reference to a compiler-generated method
                    num4 += (int)Math.Round(list7.Where<ShipData>(new GClass3.Class474()
                    {
                        list_0 = this.gclass0_0.SystemBodyRecordDic.Values
                            .Where<SystemBodyData>(gclass1_0 =>
                                gclass1_0.SystemData == this.gclass202_0.ActualSystem).Where<SystemBodyData>(
                                gclass1_0 =>
                                {
                                    if (gclass1_0.MineralDeposits.Count <= 0)
                                        return false;
                                    return gclass1_0.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                                           gclass1_0.BodyTypeId == AuroraSystemBodyType.Superjovian;
                                }).ToList<SystemBodyData>()
                    }.method_0).Sum<ShipData>(gclass40_0 =>
                        gclass40_0.method_167(AuroraComponentType.SoriumHarvester) / 4.0));
                }

                if (num4 > 500)
                {
                    this.genum95_0 = GEnum95.const_5;
                }
                else
                {
                    Decimal num5 = -1M;
                    if (this.gclass202_0.Race.SpecialNPRID == SpecialNPRIDs.const_0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        double num6 = class473.list_0.Sum<PopulationData>(gclass146_0 => gclass146_0.gclass6_0.double_2);
                        if (!(num3 > 25M) && num4 <= 125 && num6 <= 4.0)
                        {
                            if (!(num3 > 5M) && num4 <= 25 && num6 <= 1.0)
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (class473.list_0.Where<PopulationData>(gclass146_0 =>
                                        gclass146_0.MaxColonyCost >= 0M && gclass146_0.SystemBodyData.Gravity >=
                                        gclass146_0.Species.double_7).ToList<PopulationData>().Count > 0)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    num5 = class473.list_0
                                        .Where<PopulationData>(gclass146_0 =>
                                            gclass146_0.MaxColonyCost >= 0M && gclass146_0.SystemBodyData.Gravity >=
                                            gclass146_0.Species.double_7)
                                        .Min<PopulationData>(gclass146_0 => gclass146_0.MaxColonyCost);
                                    if (num5 == 0M)
                                    {
                                        this.genum95_0 = GEnum95.const_3;
                                        return;
                                    }
                                }

                                if (num3 > 0.5M || num4 > 0 || num6 > 0.0 || num5 >= 0M && num5 < 1M)
                                {
                                    this.genum95_0 = GEnum95.const_2;
                                    return;
                                }
                            }
                            else
                            {
                                this.genum95_0 = GEnum95.const_3;
                                return;
                            }
                        }
                        else
                        {
                            this.genum95_0 = GEnum95.const_4;
                            return;
                        }
                    }

                    this.genum95_0 = GEnum95.const_1;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 78);
        }
    }

    public void method_25(List<ShipData> list_0)
    {
        try
        {
            List<PopulationData> source = this.gclass202_0.method_46();
            double num1 = source
                .Where<PopulationData>(gclass146_0 => gclass146_0.gclass6_0.double_1 >= AuroraUtils.double_29)
                .Sum<PopulationData>(gclass146_0 => gclass146_0.gclass6_0.double_1);
            double num2 = 0.0;
            if (source.Count > 0)
                num2 = source.Max<PopulationData>(gclass146_0 => gclass146_0.gclass6_0.double_1);
            if (num1 < 25.0 && num2 < 10.0)
            {
                if (source.Where<PopulationData>(gclass146_0 => gclass146_0.gclass6_0.double_0 > 0.0).ToList<PopulationData>()
                        .Count <= 0 || source.Where<PopulationData>(gclass146_0 => gclass146_0.gclass6_0.double_0 > 0.0)
                        .Min<PopulationData>(gclass146_0 => gclass146_0.gclass6_0.double_0) >= 0.1)
                    return;
                this.genum95_0 = GEnum95.const_2;
            }
            else
                this.genum95_0 = GEnum95.const_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 79);
        }
    }

    public void method_26(GEnum95 genum95_1)
    {
        try
        {
            foreach (RacialSystemSurvey gclass202 in this.gclass202_0.method_37(true))
            {
                if (gclass202.gclass3_0.genum95_0 != GEnum95.const_0 && gclass202.gclass3_0.genum95_0 < genum95_1)
                    gclass202.gclass3_0.genum95_0 = genum95_1;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 80 /*0x50*/);
        }
    }
}