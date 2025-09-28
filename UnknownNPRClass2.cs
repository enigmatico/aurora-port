// Decompiled with JetBrains decompiler
// Type: GClass2
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#nullable disable
// TODO : is set if an race is NPR; what could it be?
public partial class UnknownNPRClass2
{
    public List<GClass17> list_0 = new List<GClass17>();
    public List<PopOrdnanceStock> list_1 = new List<PopOrdnanceStock>();
    public List<PopulationData> list_2 = new List<PopulationData>();
    private GClass0 gclass0_0;
    private GameRace gclass21_0;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public Decimal decimal_2;
    public Decimal decimal_3;
    public Decimal decimal_4;
    public AuroraShipyardType auroraShipyardType_0;

    public UnknownNPRClass2(GClass0 gclass0_1, GameRace gclass21_1)
    {
        this.gclass0_0 = gclass0_1;
        this.gclass21_0 = gclass21_1;
    }

    public bool method_0(GClass210 gclass210_0, Decimal decimal_5)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class335 class335 = new UnknownNPRClass2.Class335();
        // ISSUE: reference to a compiler-generated field
        class335.gclass2_0 = this;
        try
        {
            if (gclass210_0.double_2 > 0.0)
                return false;
            // ISSUE: reference to a compiler-generated field
            class335.gclass202_0 = this.gclass21_0.method_190();
            // ISSUE: reference to a compiler-generated method
            List<FleetData> list = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(class335.method_0)
                .ToList<FleetData>();
            if (list.Count == 0)
                return false;
            foreach (FleetData gclass85 in list)
                gclass85.method_7();
            if (list.Sum<FleetData>(gclass85_0 => gclass85_0.decimal_7) < decimal_5)
                return false;
            foreach (FleetData gclass85 in list.OrderByDescending<FleetData, Decimal>(gclass85_0 => gclass85_0.decimal_7)
                         .ToList<FleetData>())
            {
                gclass85.method_64(gclass210_0, false);
                decimal_5 -= gclass85.decimal_7;
                if (decimal_5 <= 0M)
                    break;
            }

            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3412);
            return false;
        }
    }

    public void method_1(
        List<FleetData> list_3,
        List<StarSystem> list_4,
        RacialSystemSurvey gclass202_0,
        OperationalGroupID genum105_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class336 class336 = new UnknownNPRClass2.Class336();
        // ISSUE: reference to a compiler-generated field
        class336.genum105_0 = genum105_0;
        // ISSUE: reference to a compiler-generated field
        class336.gclass202_0 = gclass202_0;
        // ISSUE: reference to a compiler-generated field
        class336.gclass2_0 = this;
        // ISSUE: reference to a compiler-generated field
        class336.list_0 = list_4;
        try
        {
            // ISSUE: reference to a compiler-generated method
            List<FleetData> list1 = list_3.Where<FleetData>(class336.method_0).ToList<FleetData>();
            if (list1.Count <= 0)
                return;
            // ISSUE: reference to a compiler-generated method
            List<StarSystem> list2 = list_3.Where<FleetData>(class336.method_1)
                .Select<FleetData, StarSystem>(gclass85_0 => gclass85_0.System.ActualSystem)
                .ToList<StarSystem>();
            List<StarSystem> first = new List<StarSystem>();
            // ISSUE: reference to a compiler-generated field
            if (class336.genum105_0 == OperationalGroupID.SlaveTransport)
            {
                // ISSUE: reference to a compiler-generated method
                first.AddRange(this.gclass0_0.Populations.Values.Where<PopulationData>(class336.method_2)
                    .OrderByDescending<PopulationData, Decimal>(gclass146_0 => gclass146_0.Population)
                    .Select<PopulationData, StarSystem>(gclass146_0 => gclass146_0.gclass202_0.ActualSystem)
                    .ToList<StarSystem>());
                // ISSUE: reference to a compiler-generated method
                first.AddRange(this.gclass0_0.dictionary_30.Values.Where<GClass59>(class336.method_3)
                    .Select<GClass59, StarSystem>(gclass59_0 => gclass59_0.gclass200_0).ToList<StarSystem>());
                first = first.Except<StarSystem>(list2).Distinct<StarSystem>().ToList<StarSystem>();
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                if (class336.genum105_0 == OperationalGroupID.EldarSalvage)
                {
                    // ISSUE: reference to a compiler-generated method
                    first = this.gclass0_0.Wrecks.Values.Where<Wreck>(class336.method_4)
                        .Select<Wreck, StarSystem>(gclass233_0 => gclass233_0.System)
                        .Except<StarSystem>(list2).Distinct<StarSystem>().ToList<StarSystem>();
                }
            }

            foreach (StarSystem gclass200_0 in first)
            {
                GClass210 gclass210_0 = gclass200_0.method_2();
                if (gclass210_0 != null)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    UnknownNPRClass2.Class337 class337 = new UnknownNPRClass2.Class337();
                    if (gclass210_0.double_2 <= 0.0)
                    {
                        Decimal num = 0M;
                        // ISSUE: reference to a compiler-generated field
                        class337.gclass202_0 = this.gclass21_0.method_128(gclass200_0);
                        // ISSUE: reference to a compiler-generated method
                        List<FleetData> list3 = list_3.Where<FleetData>(class337.method_0).ToList<FleetData>();
                        if (list3.Count > 0)
                            num = list3.Sum<FleetData>(gclass85_0 => gclass85_0.method_156());
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class337.gclass202_0.gclass3_0.decimal_1 == 0M ||
                            class337.gclass202_0.gclass3_0.decimal_0 > class337.gclass202_0.gclass3_0.decimal_1 * 3M ||
                            class337.gclass202_0.DangerRating < num)
                        {
                            list1[0].method_64(gclass210_0, false);
                            list1.Remove(list1[0]);
                            if (list1.Count == 0)
                                break;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3415);
        }
    }

    public GClass210 method_2(StarSystem gclass200_0)
    {
        try
        {
            double num = gclass200_0.method_12();
            double double_10 = AuroraUtils.smethod_17() * 3000000000.0 * num;
            if (double_10 > 3000000000.0)
                double_10 = 3000000000.0;
            GClass221 gclass221 =
                this.gclass0_0.method_592(0.0, 0.0, double_10, (AuroraUtils.GetRandomInteger(3600) - 1) / 10.0);
            GClass210 gclass210 = new GClass210(this.gclass0_0);
            gclass210.int_0 = this.gclass0_0.method_26(GEnum0.const_51);
            gclass210.gclass200_0 = gclass200_0;
            gclass210.decimal_0 = this.gclass0_0.GameTime;
            gclass210.double_2 = 0.0;
            gclass210.double_0 = gclass221.double_0;
            gclass210.double_1 = gclass221.double_1;
            this.gclass0_0.dictionary_16.Add(gclass210.int_0, gclass210);
            return gclass210;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3416);
            return null;
        }
    }

    public void method_3(List<FleetData> list_3, List<RacialSystemSurvey> list_4, List<RacialSystemSurvey> list_5)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class338 class338 = new UnknownNPRClass2.Class338();
        // ISSUE: reference to a compiler-generated field
        class338.gclass2_0 = this;
        try
        {
            if (this.gclass0_0.GameRaces.Values.Where<GameRace>(gclass21_0 => !gclass21_0.NPR)
                    .SelectMany<GameRace, RacialSystemSurvey>(gclass21_0 => gclass21_0.RacialSystemDictionary.Values)
                    .Select<RacialSystemSurvey, StarSystem>(gclass202_0 => gclass202_0.ActualSystem).Distinct<StarSystem>()
                    .Count<StarSystem>() < this.gclass0_0.RaiderSystems)
                return;
            if (this.gclass0_0.StartTimeEldar == 0M)
                this.gclass0_0.StartTimeEldar = this.gclass0_0.GameTime;
            // ISSUE: reference to a compiler-generated field
            class338.gclass202_0 = this.gclass21_0.method_190();
            // ISSUE: reference to a compiler-generated field
            if (class338.gclass202_0 == null)
                return;
            // ISSUE: reference to a compiler-generated method
            List<StarSystem> list1 = list_3.Where<FleetData>(class338.method_0).ToList<FleetData>()
                .Select<FleetData, StarSystem>(gclass85_0 => gclass85_0.System.ActualSystem)
                .Distinct<StarSystem>().ToList<StarSystem>();
            if (list1.Count > 0)
            {
                // ISSUE: reference to a compiler-generated field
                this.method_1(list_3, list1, class338.gclass202_0, OperationalGroupID.SlaveTransport);
                // ISSUE: reference to a compiler-generated field
                this.method_1(list_3, list1, class338.gclass202_0, OperationalGroupID.EldarSalvage);
            }

            // ISSUE: reference to a compiler-generated method
            List<FleetData> list2 = list_3.Where<FleetData>(class338.method_1)
                .OrderByDescending<FleetData, Decimal>(gclass85_0 => gclass85_0.method_156()).ToList<FleetData>();
            if (list2.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated field
            list1.Add(class338.gclass202_0.ActualSystem);
            // ISSUE: reference to a compiler-generated field
            class338.list_0 = this.gclass0_0.StarSystemDictionary.Values
                .Where<StarSystem>(gclass200_0 => gclass200_0.SupernovaElapsedTime == 0.0)
                .Except<StarSystem>(list1).ToList<StarSystem>();
            if (this.gclass0_0.NPRsEncounterRaiders == 0 || AuroraUtils.smethod_23())
            {
                // ISSUE: reference to a compiler-generated field
                class338.list_0 = this.gclass0_0.GameRaces.Values
                    .Where<GameRace>(gclass21_0 => !gclass21_0.NPR)
                    .SelectMany<GameRace, RacialSystemSurvey>(gclass21_0 => gclass21_0.RacialSystemDictionary.Values)
                    .Select<RacialSystemSurvey, StarSystem>(gclass202_0 => gclass202_0.ActualSystem).Distinct<StarSystem>()
                    .Except<StarSystem>(list1).ToList<StarSystem>();
                // ISSUE: reference to a compiler-generated field
                if (class338.list_0.Count == 0)
                    return;
            }

            // ISSUE: reference to a compiler-generated method
            List<RacialSystemSurvey> list3 = this.gclass21_0.RacialSystemDictionary.Values.Where<RacialSystemSurvey>(class338.method_2)
                .ToList<RacialSystemSurvey>();
            if (AuroraUtils.GetRandomInteger(5) == 4 && list3.Count > 5)
            {
                foreach (RacialSystemSurvey gclass202 in list3)
                    gclass202.ActualSystem.int_9 = AuroraUtils.GetRandomInteger(10000) + gclass202.RaidRating;
                // ISSUE: reference to a compiler-generated field
                class338.list_0 = list3.Select<RacialSystemSurvey, StarSystem>(gclass202_0 => gclass202_0.ActualSystem)
                    .ToList<StarSystem>();
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                foreach (StarSystem gclass200 in class338.list_0)
                    gclass200.int_9 = AuroraUtils.GetRandomInteger(10000);
            }

            // ISSUE: reference to a compiler-generated field
            if (class338.list_0.Count < 10)
                return;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class338.list_0 = class338.list_0.OrderByDescending<StarSystem, int>(gclass200_0 => gclass200_0.int_9)
                .ToList<StarSystem>();
            // ISSUE: reference to a compiler-generated field
            foreach (StarSystem gclass200 in class338.list_0)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class339 class339 = new UnknownNPRClass2.Class339();
                // ISSUE: reference to a compiler-generated field
                class339.class338_0 = class338;
                // ISSUE: reference to a compiler-generated field
                class339.gclass200_0 = gclass200;
                // ISSUE: reference to a compiler-generated field
                RacialSystemSurvey gclass202_1 = this.gclass21_0.method_128(class339.gclass200_0);
                if (gclass202_1 == null)
                {
                    // ISSUE: reference to a compiler-generated field
                    foreach (JumpPoint gclass120_0 in class339.gclass200_0.method_27())
                        this.gclass21_0.method_264(gclass120_0, 0, 0);
                    // ISSUE: reference to a compiler-generated field
                    RacialSystemSurvey gclass202_2 = this.gclass21_0.method_263(class339.gclass200_0, null, "", true);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass202_2.method_8(class339.class338_0.gclass202_0);
                    this.gclass0_0.gclass92_0.method_2(EventType.const_106,
                        $"The system of {gclass202_2.Name} has been discovered", this.gclass21_0,
                        gclass202_2.ActualSystem, 0.0, 0.0, AuroraEventCategory.Fleet);
                }
                else if (gclass202_1.DangerRating > list2[0].method_156())
                    continue;

                // ISSUE: reference to a compiler-generated field
                GClass210 gclass210_0 = class339.gclass200_0.method_2();
                if (gclass210_0 == null)
                {
                    // ISSUE: reference to a compiler-generated field
                    gclass210_0 = this.method_2(class339.gclass200_0);
                    // ISSUE: reference to a compiler-generated method
                    List<Waypoint> list4 = this.gclass0_0.Waypoints.Values.Where<Waypoint>(class339.method_0)
                        .ToList<Waypoint>();
                    // ISSUE: reference to a compiler-generated field
                    List<SystemBodyData> list5 = class339.gclass200_0.method_20()
                        .Where<SystemBodyData>(gclass1_0 => gclass1_0.BodyClass == PlanetBodyClass.Planet)
                        .Where<SystemBodyData>(gclass1_0 => gclass1_0.method_16(20, true))
                        .ToList<SystemBodyData>();
                    foreach (SystemBodyData gclass1 in list5)
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        UnknownNPRClass2.Class340 class340 = new UnknownNPRClass2.Class340();
                        // ISSUE: reference to a compiler-generated field
                        class340.gclass1_0 = gclass1;
                        // ISSUE: reference to a compiler-generated method
                        if (list4.FirstOrDefault<Waypoint>(class340.method_0) == null)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            this.gclass21_0.method_188(class339.gclass200_0, class340.gclass1_0, null, WayPointType.POI,
                                class340.gclass1_0.XCoordinate, class340.gclass1_0.YCoordinate,
                                "POI - " + class340.gclass1_0.method_78(this.gclass21_0), 0);
                        }
                    }

                    if (list5.Count == 0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        foreach (SurveyLocation gclass213 in class339.gclass200_0.SurveyLocationDictionary.Values
                                     .Where<SurveyLocation>(gclass213_0 => gclass213_0.LocationNumber < 7)
                                     .ToList<SurveyLocation>())
                        {
                            // ISSUE: object of a compiler-generated type is created
                            // ISSUE: variable of a compiler-generated type
                            UnknownNPRClass2.Class341 class341 = new UnknownNPRClass2.Class341();
                            // ISSUE: reference to a compiler-generated field
                            class341.gclass213_0 = gclass213;
                            // ISSUE: reference to a compiler-generated method
                            if (AuroraUtils.GetRandomInteger(3) >= 3 &&
                                list4.FirstOrDefault<Waypoint>(class341.method_0) == null)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                this.gclass21_0.method_188(class339.gclass200_0, null, null, WayPointType.POI,
                                    class341.gclass213_0.XCoord, class341.gclass213_0.YCoord,
                                    "POI #" + class341.gclass213_0.LocationNumber.ToString(), 0);
                            }
                        }
                    }
                }

                if (gclass210_0.double_2 <= 0.0)
                {
                    list2[0].method_64(gclass210_0, false);
                    list2.Remove(list2[0]);
                    if (list2.Count == 0)
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3407);
        }
    }

    public void method_4(bool bool_0)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            UnknownNPRClass2.Class342 class342 = new UnknownNPRClass2.Class342();
            RacialSystemSurvey gclass202_0 = this.gclass21_0.method_190();
            foreach (RacialSystemSurvey gclass202 in this.gclass21_0.RacialSystemDictionary.Values)
                gclass202.bool_6 = false;
            // ISSUE: reference to a compiler-generated field
            class342.list_0 = this.gclass0_0.method_34(gclass202_0);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            class342.list_1 = this.gclass21_0.RacialSystemDictionary.Values.Where<RacialSystemSurvey>(class342.method_0)
                .ToList<RacialSystemSurvey>();
            // ISSUE: reference to a compiler-generated field
            if (class342.list_1.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated method
            List<FleetData> list1 = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(class342.method_1)
                .ToList<FleetData>();
            if (list1.Count == 0)
                return;
            if (!bool_0)
            {
                List<ShipData> list2 = list1
                    .SelectMany<FleetData, ShipData>(gclass85_0 => gclass85_0.method_176()).ToList<ShipData>();
                this.method_10(list1, list2);
                bool_0 = true;
            }

            // ISSUE: reference to a compiler-generated field
            foreach (RacialSystemSurvey gclass202 in class342.list_1)
                gclass202.bool_6 = true;
            foreach (FleetData gclass85 in list1)
            {
                gclass85.NPRSomething.bool_3 = true;
                if (gclass85.method_234(GEnum109.const_47).gclass202_0 != null)
                    gclass85.NPRSomething.bRedeployOrderGiven = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3312);
        }
    }

    public double method_5(AlienRaceInfo gclass110_0, RacialSystemSurvey gclass202_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class343 class343 = new UnknownNPRClass2.Class343();
        // ISSUE: reference to a compiler-generated field
        class343.gclass110_0 = gclass110_0;
        // ISSUE: reference to a compiler-generated field
        class343.gclass2_0 = this;
        try
        {
            // ISSUE: reference to a compiler-generated method
            double num1 = (double)this.gclass21_0.dictionary_12.Values.Where<GClass117>(class343.method_0)
                .Sum<GClass117>(gclass117_0 => gclass117_0.gclass115_0.gclass22_0.Size);
            if (num1 == 0.0)
                return 0.0;
            // ISSUE: reference to a compiler-generated field
            RacialSystemSurvey gclass202 = class343.gclass110_0.ActualAlienRace.method_190();
            if (gclass202_0.ActualSystem != gclass202.ActualSystem)
                num1 *= 1.5;
            // ISSUE: reference to a compiler-generated method
            double num2 = (double)this.gclass0_0.Ships.Values.Where<ShipData>(class343.method_1)
                .Sum<ShipData>(gclass40_0 => gclass40_0.gclass22_0.Size);
            double num3 = num1 / num2;
            double num4 = this.gclass21_0.dictionary_11.Values
                .SelectMany<GClass115, GClass119>(gclass115_0 => gclass115_0.list_1)
                .Select<GClass119, ShipComponent>(gclass119_0 => gclass119_0.gclass230_0)
                .SelectMany<ShipComponent, TechSystem>(gclass230_0 => gclass230_0.list_0)
                .Select<TechSystem, int>(gclass164_0 => gclass164_0.int_4).DefaultIfEmpty<int>(0)
                .Max<int>(int_0 => int_0);
            // ISSUE: reference to a compiler-generated method
            double num5 = this.gclass0_0.ShipClasses.Values.Where<ShipClass>(class343.method_2)
                .SelectMany<ShipClass, GClass228>(gclass22_0 => gclass22_0.dictionary_0.Values)
                .Where<GClass228>(gclass228_0 => gclass228_0.gclass230_0.bool_11)
                .SelectMany<GClass228, TechSystem>(gclass228_0 => gclass228_0.gclass230_0.list_0)
                .Max<TechSystem>(gclass164_0 => gclass164_0.int_4);
            if (num4 > 0.0)
                num3 *= num4 / num5;
            // ISSUE: reference to a compiler-generated method
            double num6 = this.gclass21_0.dictionary_11.Values.Where<GClass115>(class343.method_3)
                .Select<GClass115, ShipClass>(gclass115_0 => gclass115_0.gclass22_0)
                .SelectMany<ShipClass, GClass228>(gclass22_0 => gclass22_0.dictionary_0.Values)
                .Where<GClass228>(gclass228_0 =>
                    gclass228_0.gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.Engine)
                .SelectMany<GClass228, TechSystem>(gclass228_0 => gclass228_0.gclass230_0.list_0)
                .Select<TechSystem, int>(gclass164_0 => gclass164_0.int_4).DefaultIfEmpty<int>(0)
                .Max<int>(int_0 => int_0);
            // ISSUE: reference to a compiler-generated method
            double num7 = this.gclass0_0.ShipClasses.Values.Where<ShipClass>(class343.method_4)
                .SelectMany<ShipClass, GClass228>(gclass22_0 => gclass22_0.dictionary_0.Values)
                .Where<GClass228>(gclass228_0 =>
                    gclass228_0.gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.Engine)
                .SelectMany<GClass228, TechSystem>(gclass228_0 => gclass228_0.gclass230_0.list_0)
                .Max<TechSystem>(gclass164_0 => gclass164_0.int_4);
            if (num6 > 0.0)
                num3 *= num6 / num7;
            return num3;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1);
            return 1.0;
        }
    }

    public void method_6(AlienRaceInfo gclass110_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class344 class344 = new UnknownNPRClass2.Class344();
        // ISSUE: reference to a compiler-generated field
        class344.gclass110_0 = gclass110_0;
        try
        {
            // ISSUE: reference to a compiler-generated field
            class344.gclass110_0.ContactStatus = AuroraContactStatus.Hostile;
            // ISSUE: reference to a compiler-generated method
            foreach (RacialSystemSurvey gclass202 in this.gclass21_0.RacialSystemDictionary.Values.Where<RacialSystemSurvey>(class344.method_0)
                         .ToList<RacialSystemSurvey>())
                gclass202.gclass3_0.genum95_0 = GEnum95.const_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2);
        }
    }

    public object method_7(
        AlienRaceInfo gclass110_0,
        RacialSystemSurvey gclass202_0,
        ShipData gclass40_0,
        PopulationData gclass146_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class345 class345 = new UnknownNPRClass2.Class345();
        // ISSUE: reference to a compiler-generated field
        class345.gclass2_0 = this;
        // ISSUE: reference to a compiler-generated field
        class345.gclass202_0 = gclass202_0;
        // ISSUE: reference to a compiler-generated field
        class345.gclass40_0 = gclass40_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            List<ShipData> list1 = this.gclass0_0.Ships.Values
                .Where<ShipData>(class345.method_0).ToList<ShipData>();
            // ISSUE: reference to a compiler-generated method
            List<PopulationData> list2 = this.gclass0_0.Populations.Values.Where<PopulationData>(class345.method_1)
                .ToList<PopulationData>();
            if (gclass146_0 != null)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class346 class346 = new UnknownNPRClass2.Class346();
                // ISSUE: reference to a compiler-generated field
                class346.class345_0 = class345;
                // ISSUE: reference to a compiler-generated field
                class346.double_0 = gclass146_0.method_87();
                // ISSUE: reference to a compiler-generated field
                class346.double_1 = gclass146_0.method_88();
                if (list1.Count > 0)
                {
                    // ISSUE: reference to a compiler-generated method
                    return list1.OrderBy<ShipData, double>(class346.method_0).FirstOrDefault<ShipData>();
                }

                if (list2.Count > 0)
                {
                    // ISSUE: reference to a compiler-generated method
                    return list2.OrderBy<PopulationData, double>(class346.method_1).FirstOrDefault<PopulationData>();
                }
            }

            // ISSUE: reference to a compiler-generated field
            if (class345.gclass40_0 != null)
            {
                if (list1.Count > 0)
                {
                    // ISSUE: reference to a compiler-generated method
                    return list1.OrderBy<ShipData, double>(class345.method_2).FirstOrDefault<ShipData>();
                }

                if (list2.Count > 0)
                {
                    // ISSUE: reference to a compiler-generated method
                    return list2.OrderBy<PopulationData, double>(class345.method_3).FirstOrDefault<PopulationData>();
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3);
            return null;
        }
    }

    public void method_8(Decimal decimal_5)
    {
        try
        {
            Decimal num1 = decimal_5 / AuroraUtils.decimal_29;
            Decimal num2 = this.gclass21_0.method_166(GEnum41.const_0) / 100M;
            RacialSystemSurvey gclass202_1 = this.gclass21_0.method_190();
            PopulationData gclass146 = this.gclass21_0.method_153(gclass202_1);
            if (gclass146 == null)
                this.gclass21_0.method_82();
            if (gclass146 == null)
                return;
            Decimal num3 = gclass146.method_190();
            List<Contact> list1 = this.gclass0_0.Contacts.Values
                .Where<Contact>(gclass65_0 =>
                    gclass65_0.DetectRace == this.gclass21_0 && this.gclass0_0.GameTime == gclass65_0.LastUpdate)
                .Where<Contact>(gclass65_0 => gclass65_0.method_2()).ToList<Contact>();
            List<RacialSystemSurvey> list2 = list1.Select<Contact, StarSystem>(gclass65_0 => gclass65_0.System)
                .Distinct<StarSystem>()
                .Select<StarSystem, RacialSystemSurvey>(gclass200_0 => gclass21_0.method_128(gclass200_0))
                .ToList<RacialSystemSurvey>();
            List<Contact> list3 = this.gclass0_0.Contacts.Values
                .Where<Contact>(gclass65_0 =>
                    gclass65_0.ContactRace == this.gclass21_0 && this.gclass0_0.GameTime == gclass65_0.LastUpdate)
                .Where<Contact>(gclass65_0 => gclass65_0.method_2()).ToList<Contact>();
            List<RacialSystemSurvey> list4 = list3
                .Select<Contact, RacialSystemSurvey>(gclass65_0 => gclass65_0.DetectRace.method_128(gclass65_0.System))
                .Distinct<RacialSystemSurvey>().ToList<RacialSystemSurvey>();
            if (list1.Count == 0 && list3.Count == 0)
                return;
            foreach (RacialSystemSurvey gclass202_2 in list4)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class347 class347 = new UnknownNPRClass2.Class347();
                // ISSUE: reference to a compiler-generated field
                class347.gclass202_0 = gclass202_2;
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class348 class348 = new UnknownNPRClass2.Class348();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class348.gclass202_0 = this.gclass21_0.method_128(class347.gclass202_0.ActualSystem);
                // ISSUE: reference to a compiler-generated field
                if (class348.gclass202_0.gclass3_0.genum95_0 != GEnum95.const_0)
                {
                    // ISSUE: reference to a compiler-generated field
                    AlienRaceInfo key = class347.gclass202_0.Race.method_325(this.gclass21_0.RaceID);
                    if (key != null && key.FixedRelationShip != 1)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        AlienRaceInfo gclass110_0 =
                            class348.gclass202_0.Race.method_325(class347.gclass202_0.Race.RaceID);
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (gclass110_0 != null && gclass110_0.ContactStatus != AuroraContactStatus.Hostile &&
                            class347.gclass202_0.dictionary_0.ContainsKey(key) &&
                            class347.gclass202_0.dictionary_0[key].auroraSystemProtectionStatus_0 !=
                            AuroraSystemProtectionStatus.NoProtection)
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (!class347.gclass202_0.Race.NPR)
                            {
                                // ISSUE: reference to a compiler-generated method
                                List<Contact> list5 = list3.Where<Contact>(class347.method_0).ToList<Contact>();
                                int num4 = list5
                                    .Where<Contact>(gclass65_0 =>
                                        gclass65_0.ContactType == AuroraContactType.Ship)
                                    .Select<Contact, int>(gclass65_0 => gclass65_0.ContactID).Distinct<int>().Count<int>();
                                int num5 = list5
                                    .Where<Contact>(gclass65_0 =>
                                        gclass65_0.ContactType != AuroraContactType.Ship &&
                                        gclass65_0.ContactType != AuroraContactType.Salvo)
                                    .Select<Contact, int>(gclass65_0 => gclass65_0.ContactID).Distinct<int>().Count<int>();
                                int num6 = list5
                                    .Where<Contact>(gclass65_0 =>
                                        gclass65_0.ContactType == AuroraContactType.Salvo)
                                    .Select<Contact, int>(gclass65_0 => gclass65_0.ContactID).Distinct<int>().Count<int>();
                                string str1 = "";
                                if (num4 > 0)
                                    str1 = $"{str1}{num4.ToString()}x Ship ";
                                if (num5 > 0)
                                    str1 = $"{str1}{num5.ToString()}x Population ";
                                if (num6 > 0)
                                    str1 = $"{str1}{num6.ToString()}x Salvo";
                                // ISSUE: reference to a compiler-generated field
                                string str2 = AuroraUtils.smethod_82(class347.gclass202_0.dictionary_0[key]
                                    .auroraSystemProtectionStatus_0);
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                this.gclass0_0.gclass92_0.method_2(EventType.const_100,
                                    $"Forces of the {key.AlienRaceName} have been detected in {class347.gclass202_0.Name}. As we have a protection status for this system of '{str2}', an appropriate message has been sent. Current contacts are {str1}",
                                    class347.gclass202_0.Race, class347.gclass202_0.ActualSystem, 0.0, 0.0,
                                    AuroraEventCategory.Intelligence);
                            }

                            // ISSUE: reference to a compiler-generated field
                            AuroraSystemProtectionStatus protectionStatus0 =
                                class347.gclass202_0.dictionary_0[key].auroraSystemProtectionStatus_0;
                            // ISSUE: reference to a compiler-generated field
                            if (!class347.gclass202_0.Race.NPR)
                            {
                                // ISSUE: reference to a compiler-generated field
                                Decimal num7 = (Decimal)Math.Pow((double)protectionStatus0, 2.0) *
                                               (Decimal)Math.Pow((double)class348.gclass202_0.gclass3_0.genum95_0,
                                                   2.0) * num2 * 2M;
                                // ISSUE: reference to a compiler-generated field
                                this.gclass21_0.method_22(class347.gclass202_0.Race, -num7, false);
                            }

                            // ISSUE: reference to a compiler-generated field
                            double num8 = (double)class347.gclass202_0.method_2();
                            if (num8 < 1000.0 * (double)num2)
                            {
                                // ISSUE: reference to a compiler-generated field
                                class347.gclass202_0.dictionary_0.Remove(key);
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                this.gclass0_0.gclass92_0.method_2(EventType.const_183,
                                    $"The {key.AlienRaceName} has rejected our claim on {class347.gclass202_0.Name} on the basis they have not detected sufficient evidence of a permament presence that would warrant such a claim. They warn that repeated claims without justification will damage relations.",
                                    class347.gclass202_0.Race, class347.gclass202_0.ActualSystem, 0.0, 0.0,
                                    AuroraEventCategory.Intelligence);
                            }
                            else
                            {
                                int num9 = this.gclass0_0.method_33(gclass202_1);
                                // ISSUE: reference to a compiler-generated field
                                GEnum95 genum950 = class348.gclass202_0.gclass3_0.genum95_0;
                                // ISSUE: reference to a compiler-generated field
                                class348.gclass202_0.gclass3_0.genum95_0 = GEnum95.const_0;
                                int num10 = this.gclass0_0.method_33(gclass202_1);
                                // ISSUE: reference to a compiler-generated field
                                class348.gclass202_0.gclass3_0.genum95_0 = genum950;
                                int num11 = num10;
                                double num12 = (num9 - num11) / 4.0;
                                // ISSUE: reference to a compiler-generated field
                                if (class348.gclass202_0.gclass3_0.genum95_0 < GEnum95.const_2 && num12 == 0.0)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    this.gclass0_0.gclass92_0.method_2(EventType.const_183,
                                        $"The {key.AlienRaceName} has accepted our sovereignty of {class347.gclass202_0.Name} as they have no significant interest in the system",
                                        class347.gclass202_0.Race, class347.gclass202_0.ActualSystem, 0.0, 0.0,
                                        AuroraEventCategory.Intelligence);
                                    // ISSUE: reference to a compiler-generated field
                                    class348.gclass202_0.gclass3_0.genum95_0 = GEnum95.const_0;
                                    // ISSUE: reference to a compiler-generated field
                                    class348.gclass202_0.gclass110_0 = gclass110_0;
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    class348.gclass202_0.method_5(class347.gclass202_0.Race);
                                }
                                else
                                {
                                    double num13 = this.method_5(gclass110_0, gclass202_1);
                                    double num14 = Math.Sqrt((double)protectionStatus0);
                                    double num15 = (this.gclass21_0.method_166(GEnum41.const_0) +
                                                    this.gclass21_0.method_166(GEnum41.const_2) +
                                                    this.gclass21_0.method_166(GEnum41.const_3)) / 150.0;
                                    double num16 = num12 * num15;
                                    // ISSUE: reference to a compiler-generated method
                                    double num17 = (double)this.gclass0_0.Populations.Values
                                        .Where<PopulationData>(class348.method_0)
                                        .Sum<PopulationData>(gclass146_0 => gclass146_0.method_190());
                                    double num18 = Math.Pow(num8 / 100.0, 0.333);
                                    if (num17 > 0.0)
                                    {
                                        double num19 = Math.Sqrt(num8 / num17);
                                        if (num19 < num18)
                                            num18 = num19;
                                    }

                                    double num20 = num14;
                                    if (num13 * num20 * num18 > num16)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        this.gclass0_0.gclass92_0.method_2(EventType.const_183,
                                            $"The {key.AlienRaceName} has accepted our sovereignty of {class347.gclass202_0.Name} but warn that claims on additional systems will damage relations",
                                            class347.gclass202_0.Race, class347.gclass202_0.ActualSystem, 0.0, 0.0,
                                            AuroraEventCategory.Intelligence);
                                        // ISSUE: reference to a compiler-generated field
                                        class348.gclass202_0.gclass3_0.genum95_0 = GEnum95.const_0;
                                        // ISSUE: reference to a compiler-generated field
                                        class348.gclass202_0.gclass110_0 = gclass110_0;
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        class348.gclass202_0.method_5(class347.gclass202_0.Race);
                                    }
                                    else
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        class347.gclass202_0.dictionary_0.Remove(key);
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        this.gclass0_0.gclass92_0.method_2(EventType.const_183,
                                            $"The {key.AlienRaceName} has rejected our claim on {class347.gclass202_0.Name}. The system is important to them and they will defend it. Further claims will damage relations.",
                                            class347.gclass202_0.Race, class347.gclass202_0.ActualSystem, 0.0, 0.0,
                                            AuroraEventCategory.Intelligence);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            foreach (RacialSystemSurvey gclass202_3 in this.gclass21_0.RacialSystemDictionary.Values
                         .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 > GEnum95.const_2)
                         .Intersect<RacialSystemSurvey>(list2).ToList<RacialSystemSurvey>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class349 class349 = new UnknownNPRClass2.Class349();
                // ISSUE: reference to a compiler-generated field
                class349.gclass202_0 = gclass202_3;
                // ISSUE: reference to a compiler-generated method
                foreach (AlienRaceInfo gclass110_1 in list1.Where<Contact>(class349.method_0)
                             .Select<Contact, GameRace>(gclass65_0 => gclass65_0.ContactRace)
                             .Distinct<GameRace>()
                             .Select<GameRace, AlienRaceInfo>(gclass21_1 =>
                                 this.gclass21_0.method_325(gclass21_1.RaceID)).ToList<AlienRaceInfo>())
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    UnknownNPRClass2.Class350 class350 = new UnknownNPRClass2.Class350();
                    // ISSUE: reference to a compiler-generated field
                    class350.class349_0 = class349;
                    // ISSUE: reference to a compiler-generated field
                    class350.gclass110_0 = gclass110_1;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class350.gclass110_0.ContactStatus < AuroraContactStatus.Allied &&
                        (class350.gclass110_0.ContactStatus < AuroraContactStatus.Friendly ||
                         class350.class349_0.gclass202_0.gclass3_0.genum95_0 >= GEnum95.const_4) &&
                        class350.gclass110_0.FixedRelationShip != 1)
                    {
                        // ISSUE: reference to a compiler-generated field
                        RacialSystemSurvey gclass202_4 = class350.gclass110_0.ActualAlienRace.method_190();
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (gclass202_1.ActualSystem != gclass202_4.ActualSystem ||
                            class350.class349_0.gclass202_0 != gclass202_1)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            RacialSystemSurvey gclass202_5 =
                                class350.gclass110_0.ActualAlienRace.method_128(class350.class349_0.gclass202_0.ActualSystem);
                            Decimal num21 = gclass202_5.method_2();
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            if (!(num21 > num3 / 10M * num2) || !(this.gclass0_0.Populations.Values
                                    .Where<PopulationData>(class350.class349_0.func_0 ??
                                                      (class350.class349_0.func_0 = class350.class349_0.method_1))
                                    .Sum<PopulationData>(gclass146_0 => gclass146_0.method_190()) < num21))
                            {
                                // ISSUE: reference to a compiler-generated method
                                PopulationData gclass146_0_1 = list1.Where<Contact>(class350.method_0)
                                    .Select<Contact, PopulationData>(gclass65_0 => gclass65_0.TargetPopulation)
                                    .OrderByDescending<PopulationData, Decimal>(gclass146_0 => gclass146_0.decimal_30)
                                    .FirstOrDefault<PopulationData>();
                                // ISSUE: reference to a compiler-generated method
                                ShipData gclass40_0_1 = list1.Where<Contact>(class350.method_1)
                                    .Select<Contact, ShipData>(gclass65_0 => gclass65_0.TargetShip)
                                    .OrderBy<ShipData, bool>(gclass40_0 => gclass40_0.gclass22_0.Commercial)
                                    .ThenByDescending<ShipData, Decimal>(gclass40_0 =>
                                        gclass40_0.gclass22_0.Size).FirstOrDefault<ShipData>();
                                if (gclass40_0_1 != null || gclass146_0_1 != null)
                                {
                                    Decimal num22 = 1M;
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (class350.class349_0.gclass202_0.gclass3_0.genum95_0 == GEnum95.const_3)
                                    {
                                        num22 = 2.5M;
                                    }
                                    else
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (class350.class349_0.gclass202_0.gclass3_0.genum95_0 == GEnum95.const_4)
                                        {
                                            num22 = 5M;
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            if (class350.class349_0.gclass202_0.gclass3_0.genum95_0 == GEnum95.const_5)
                                            {
                                                num22 = 10M;
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                if (class350.class349_0.gclass202_0.gclass3_0.genum95_0 ==
                                                    GEnum95.const_6)
                                                    num22 = 20M;
                                            }
                                        }
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    if (class350.gclass110_0.ContactStatus == AuroraContactStatus.Friendly)
                                        num22 /= 2M;
                                    // ISSUE: reference to a compiler-generated field
                                    if (class350.gclass110_0.DiplomaticPoints < 0M)
                                        num22 *= 2M;
                                    num22 *= num2;
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    class350.class349_0.gclass202_0.gclass3_0.int_3 = 0;
                                    // ISSUE: reference to a compiler-generated method
                                    // ISSUE: reference to a compiler-generated method
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated method
                                    Decimal num23 = list1.Where<Contact>(class350.method_2)
                                        .Select<Contact, ShipData>(gclass65_0 => gclass65_0.TargetShip)
                                        .Distinct<ShipData>().Where<ShipData>(class350.method_3)
                                        .Select<ShipData, GClass115>(gclass40_0 =>
                                            this.gclass21_0.method_118(gclass40_0.gclass22_0))
                                        .Sum<GClass115>(class350.class349_0.func_1 ??
                                                        (class350.class349_0.func_1 = class350.class349_0.method_2));
                                    if (num23 > 0M && num23 < 1000M)
                                        num23 = 1000M;
                                    if (num21 > 0M && num21 < 100M)
                                        num21 = 100M;
                                    Decimal num24 = (Decimal)Math.Sqrt((double)(num23 + num21 * 10M));
                                    if (!(num24 <= 0M))
                                    {
                                        Decimal num25 = num24 * num22 * num1;
                                        // ISSUE: reference to a compiler-generated field
                                        this.gclass21_0.method_22(class350.gclass110_0.ActualAlienRace, -num25, false);
                                        Decimal num26 = 1000M;
                                        if (num25 > 0M)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            num26 = (class350.gclass110_0.DiplomaticPoints + 100M) / num25;
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        if (class350.gclass110_0.ContactStatus != AuroraContactStatus.Hostile)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (!class350.gclass110_0.ActualAlienRace.NPR)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                object object_0 = this.method_7(class350.gclass110_0,
                                                    class350.class349_0.gclass202_0, gclass40_0_1, gclass146_0_1);
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                string str3 =
                                                    class350.gclass110_0.ActualAlienRace.method_85(
                                                        class350.class349_0.gclass202_0.ActualSystem, object_0);
                                                // ISSUE: reference to a compiler-generated field
                                                if (class350.gclass110_0.CommStatus !=
                                                    AuroraCommStatus.CommunicationEstablished)
                                                {
                                                    if (gclass146_0_1 != null)
                                                        this.gclass0_0.gclass92_0.method_2(EventType.const_183,
                                                            $"{gclass146_0_1.PopName} has receieved an unintelligible communication orginating from {str3}",
                                                            gclass146_0_1.Race,
                                                            gclass146_0_1.gclass202_0.ActualSystem,
                                                            gclass146_0_1.method_87(), gclass146_0_1.method_88(),
                                                            AuroraEventCategory.PopSummary);
                                                    else
                                                        this.gclass0_0.gclass92_0.method_2(EventType.const_183,
                                                            $"{gclass40_0_1.gclass85_0.FleetName} has receieved an unintelligible communication orginating from {str3}",
                                                            gclass40_0_1.gclass21_0,
                                                            gclass40_0_1.gclass85_0.System.ActualSystem,
                                                            gclass40_0_1.gclass85_0.XCoord,
                                                            gclass40_0_1.gclass85_0.YCoord, AuroraEventCategory.Ship);
                                                }
                                                else
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    AlienRaceInfo gclass110_2 =
                                                        class350.gclass110_0.ActualAlienRace.method_325(this.gclass21_0
                                                            .RaceID);
                                                    string str4 =
                                                        $" suggesting that our forces leave {gclass202_5.Name} in the near future as the system lies within their territory";
                                                    if (!(num22 >= 16M) && !(num26 < 2M))
                                                    {
                                                        if (!(num22 >= 8M) && !(num26 < 5M))
                                                        {
                                                            if (!(num22 >= 4M) && !(num26 < 10M))
                                                            {
                                                                if (num22 >= 2M)
                                                                    str4 =
                                                                        $" requesting that our forces leave {gclass202_5.Name} as the system lies within their territory";
                                                            }
                                                            else
                                                                str4 =
                                                                    $" requesting that our forces leave {gclass202_5.Name} as a matter of urgency";
                                                        }
                                                        else
                                                            str4 =
                                                                $" demanding that our forces leave {gclass202_5.Name} immediately";
                                                    }
                                                    else
                                                        str4 =
                                                            $" demanding that our forces leave {gclass202_5.Name} immediately or they will be fired upon";

                                                    if (gclass146_0_1 != null)
                                                        this.gclass0_0.gclass92_0.method_2(EventType.const_183,
                                                            $"The {gclass110_2.AlienRaceName} has sent a message to {gclass146_0_1.PopName}{str4}. Origin of message was {str3}",
                                                            gclass146_0_1.Race,
                                                            gclass146_0_1.gclass202_0.ActualSystem,
                                                            gclass146_0_1.method_87(), gclass146_0_1.method_88(),
                                                            AuroraEventCategory.PopSummary);
                                                    else
                                                        this.gclass0_0.gclass92_0.method_2(EventType.const_183,
                                                            $"The {gclass110_2.AlienRaceName} has sent a message to {gclass40_0_1.ShipName}{str4}. Origin of message was {str3}",
                                                            gclass40_0_1.gclass21_0,
                                                            gclass40_0_1.gclass85_0.System.ActualSystem,
                                                            gclass40_0_1.gclass85_0.XCoord,
                                                            gclass40_0_1.gclass85_0.YCoord, AuroraEventCategory.Ship);
                                                }
                                            }
                                            else
                                            {
                                                AuroraSystemProtectionStatus protectionStatus =
                                                    AuroraSystemProtectionStatus.SuggestLeave;
                                                if (num22 >= 20M)
                                                    protectionStatus = AuroraSystemProtectionStatus
                                                        .DemandLeaveWithThreat;
                                                else if (num22 >= 10M)
                                                    protectionStatus = AuroraSystemProtectionStatus.DemandLeave;
                                                else if (num22 >= 5M)
                                                    protectionStatus = AuroraSystemProtectionStatus
                                                        .RequestLeaveUrgently;
                                                else if (num22 >= 2M)
                                                    protectionStatus = AuroraSystemProtectionStatus.RequestLeave;
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                if (class350.class349_0.gclass202_0.dictionary_0.ContainsKey(
                                                        class350.gclass110_0))
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    class350.class349_0.gclass202_0.dictionary_0[class350.gclass110_0]
                                                        .auroraSystemProtectionStatus_0 = protectionStatus;
                                                }
                                                else
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    class350.class349_0.gclass202_0.dictionary_0.Add(
                                                        class350.gclass110_0, new AlienRaceSystemStatus()
                                                        {
                                                            auroraSystemProtectionStatus_0 = protectionStatus,
                                                            gclass202_0 = class350.class349_0.gclass202_0,
                                                            gclass110_0 = class350.gclass110_0
                                                        });
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 4);
        }
    }

    public void method_9(bool bool_0, int int_0)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            UnknownNPRClass2.Class351 class351 = new UnknownNPRClass2.Class351();
            // ISSUE: reference to a compiler-generated field
            class351.gclass2_0 = this;
            if (this.gclass21_0.SpecialNPRID == SpecialNPRIDs.Eldar && this.gclass0_0.Eldar == 0)
                return;
            List<FleetData> list1 = this.gclass0_0.FleetDictionary.Values
                .Where<FleetData>(gclass85_0 => gclass85_0.Race == this.gclass21_0).ToList<FleetData>();
            List<ShipData> list2 = this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass21_0 == this.gclass21_0).ToList<ShipData>();
            List<PopulationData> list3 = this.gclass0_0.Populations.Values
                .Where<PopulationData>(gclass146_0 => gclass146_0.Race == this.gclass21_0).ToList<PopulationData>();
            if (list2.Count == 0 && list3.Count == 0)
                return;
            list1.Where<FleetData>(gclass85_0 => gclass85_0.list_3.Count == 0).ToList<FleetData>();
            bool bool_0_1 = false;
            List<Contact> list4 = this.gclass0_0.Contacts.Values.Where<Contact>(gclass65_0 =>
                gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.DetectRace == this.gclass21_0 &&
                this.gclass0_0.GameTime - gclass65_0.LastUpdate < AuroraUtils.decimal_29).ToList<Contact>();
            // ISSUE: reference to a compiler-generated field
            class351.list_0 = list4
                .Where<Contact>(gclass65_0 =>
                    this.gclass0_0.GameTime - gclass65_0.LastUpdate < AuroraUtils.decimal_34 &&
                    gclass65_0.ContactType == AuroraContactType.Ship)
                .Select<Contact, StarSystem>(gclass65_0 => gclass65_0.System).Distinct<StarSystem>()
                .ToList<StarSystem>();
            List<PopulationData> list5 = list4
                .Where<Contact>(gclass65_0 =>
                    this.gclass0_0.GameTime - gclass65_0.LastUpdate < AuroraUtils.decimal_34 &&
                    gclass65_0.ContactType == AuroraContactType.STOGroundUnit)
                .Select<Contact, PopulationData>(gclass65_0 => gclass65_0.TargetPopulation).Distinct<PopulationData>()
                .ToList<PopulationData>();
            // ISSUE: reference to a compiler-generated method
            List<RacialSystemSurvey> list6 = this.gclass21_0.RacialSystemDictionary.Values.Where<RacialSystemSurvey>(class351.method_0)
                .ToList<RacialSystemSurvey>();
            // ISSUE: reference to a compiler-generated field
            class351.list_1 = list4
                .Where<Contact>(gclass65_0 => gclass65_0.ContactType == AuroraContactType.Ship)
                .Select<Contact, StarSystem>(gclass65_0 => gclass65_0.System).Distinct<StarSystem>()
                .ToList<StarSystem>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class351.list_2 = list4
                .Where<Contact>(gclass65_0 => gclass65_0.ContactType == AuroraContactType.Population ||
                                               gclass65_0.ContactType == AuroraContactType.GroundUnit ||
                                               gclass65_0.ContactType == AuroraContactType.STOGroundUnit ||
                                               gclass65_0.ContactType == AuroraContactType.Shipyard ||
                                               gclass65_0.ContactType == AuroraContactType.Ship)
                .Select<Contact, StarSystem>(gclass65_0 => gclass65_0.System).Distinct<StarSystem>()
                .Except<StarSystem>(class351.list_1).ToList<StarSystem>();
            // ISSUE: reference to a compiler-generated method
            List<RacialSystemSurvey> list7 = this.gclass21_0.RacialSystemDictionary.Values.Where<RacialSystemSurvey>(class351.method_1)
                .ToList<RacialSystemSurvey>();
            // ISSUE: reference to a compiler-generated method
            List<RacialSystemSurvey> list8 = this.gclass21_0.RacialSystemDictionary.Values.Where<RacialSystemSurvey>(class351.method_2)
                .ToList<RacialSystemSurvey>();
            List<RacialSystemSurvey> list9 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_0)
                .ToList<RacialSystemSurvey>();
            List<RacialSystemSurvey> list10 = list7.SelectMany<RacialSystemSurvey, RacialSystemSurvey>(gclass202_0 => gclass202_0.method_37(true))
                .Distinct<RacialSystemSurvey>()
                .OrderByDescending<RacialSystemSurvey, GEnum95>(gclass202_0 => gclass202_0.gclass3_0.genum95_0)
                .ToList<RacialSystemSurvey>();
            List<RacialSystemSurvey> list11 = this.gclass21_0.RacialSystemDictionary.Values.Except<RacialSystemSurvey>(list10)
                .Except<RacialSystemSurvey>(list7).Except<RacialSystemSurvey>(list9).ToList<RacialSystemSurvey>();
            foreach (RacialSystemSurvey gclass202 in this.gclass21_0.RacialSystemDictionary.Values)
            {
                gclass202.gclass3_0.int_1 = 0;
                gclass202.gclass3_0.int_0 = 0;
                gclass202.gclass3_0.genum96_0 = GEnum96.const_0;
            }

            foreach (FleetData gclass85 in list1)
            {
                gclass85.NPRSomething.bool_2 = false;
                gclass85.bAvoidDanger = gclass85.NPROperationGroup.bool_1;
                gclass85.NPRSomething.method_5();
            }

            foreach (RacialSystemSurvey gclass202 in list10)
                gclass202.gclass3_0.genum96_0 = GEnum96.const_1;
            foreach (RacialSystemSurvey gclass202 in list8)
                gclass202.gclass3_0.genum96_0 = GEnum96.const_2;
            foreach (RacialSystemSurvey gclass202 in list7)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class352 class352 = new UnknownNPRClass2.Class352()
                {
                    gclass202_0 = gclass202
                };
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                class352.gclass202_0.gclass3_0.int_0 = list4.Where<Contact>(class352.method_0)
                    .Select<Contact, int>(gclass65_0 => gclass65_0.ContactID).Distinct<int>().Count<int>();
                // ISSUE: reference to a compiler-generated field
                class352.gclass202_0.gclass3_0.genum96_0 = GEnum96.const_3;
            }

            foreach (RacialSystemSurvey gclass202 in list6)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class353 class353 = new UnknownNPRClass2.Class353()
                {
                    class351_0 = class351,
                    gclass202_0 = gclass202
                };
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                class353.gclass202_0.gclass3_0.int_1 = list4.Where<Contact>(class353.method_0)
                    .Select<Contact, int>(gclass65_0 => gclass65_0.ContactID).Distinct<int>().Count<int>();
                // ISSUE: reference to a compiler-generated field
                class353.gclass202_0.gclass3_0.genum96_0 = GEnum96.const_4;
            }

            if (list6.Count > 0 && this.gclass21_0.SpecialNPRID != SpecialNPRIDs.Precursor)
            {
                if (!bool_0_1)
                {
                    this.method_10(list1, list2);
                    bool_0_1 = true;
                }

                foreach (RacialSystemSurvey gclass202 in list7)
                    gclass202.gclass3_0.method_3(list1, false, false);
            }

            if (list9.Count > 0)
                this.method_4(bool_0_1);
            if (bool_0 || list6.Count > 0 && this.gclass0_0.GameTime - this.decimal_2 > 10000M)
            {
                this.decimal_2 = this.gclass0_0.GameTime;
                if (!bool_0_1)
                {
                    this.method_10(list1, list2);
                    bool_0_1 = true;
                }

                foreach (PopulationData gclass146 in list3)
                    gclass146.gclass6_0.decimal_0 = 0M;
                if (this.gclass21_0.SpecialNPRID == SpecialNPRIDs.const_0)
                    this.method_37(list1);
                if (this.gclass21_0.SpecialNPRID == SpecialNPRIDs.StarSwarm)
                {
                    if (bool_0 || int_0 > 10000)
                        this.method_17(list2, list8, list1);
                    this.method_36(list1);
                }

                if (this.gclass21_0.SpecialNPRID != SpecialNPRIDs.Precursor &&
                    this.gclass21_0.SpecialNPRID != SpecialNPRIDs.Eldar && list8.Count > 0)
                {
                    this.method_12(list1, list6, list8);
                    this.method_12(list1, list6, list8);
                }

                if (this.gclass21_0.SpecialNPRID != SpecialNPRIDs.Eldar)
                    this.method_38(list1);
                if (this.gclass21_0.SpecialNPRID == SpecialNPRIDs.const_0)
                    this.method_39(list1);
                if (list10.Count > 0)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: reference to a compiler-generated method
                    List<RacialSystemSurvey> list12 = this.gclass21_0.RacialSystemDictionary.Values.Where<RacialSystemSurvey>(
                        new UnknownNPRClass2.Class354()
                        {
                            list_0 = this.gclass0_0.Waypoints.Values
                                .Where<Waypoint>(gclass214_0 =>
                                    gclass214_0.Race == this.gclass21_0 &&
                                    gclass214_0.WaypointType == WayPointType.TransitPOI)
                                .Select<Waypoint, StarSystem>(gclass214_0 => gclass214_0.System)
                                .ToList<StarSystem>()
                        }.method_0).ToList<RacialSystemSurvey>();
                    if (this.gclass21_0.SpecialNPRID == SpecialNPRIDs.StarSwarm)
                    {
                        this.method_46(list10, list7, list11, list1, GEnum104.const_23, false);
                        this.method_46(list12, list7, list11, list1, GEnum104.const_23, true);
                    }
                    else
                    {
                        this.method_46(list10, list7, list11, list1, GEnum104.const_10, false);
                        this.method_46(list12, list7, list11, list1, GEnum104.const_10, true);
                    }
                }

                if (this.gclass21_0.SpecialNPRID != SpecialNPRIDs.Precursor &&
                    this.gclass21_0.SpecialNPRID != SpecialNPRIDs.Eldar)
                {
                    this.method_42(list1, GEnum104.const_5);
                    this.method_42(list1, GEnum104.const_3);
                    this.method_40(list1);
                    this.method_41(list1);
                }

                if (this.gclass21_0.SpecialNPRID != SpecialNPRIDs.StarSwarm &&
                    this.gclass21_0.SpecialNPRID != SpecialNPRIDs.Eldar)
                {
                    this.method_48(list3);
                    this.method_49(list3);
                    foreach (FleetData gclass85 in list1
                                 .Where<FleetData>(gclass85_0 => gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_4)
                                 .ToList<FleetData>())
                        gclass85.NPRSomething.method_13();
                    this.method_32(list1, list3, list5);
                    if (this.gclass21_0.SpecialNPRID == SpecialNPRIDs.const_0)
                        this.method_31(list1, list3, list5);
                    this.method_35(list1, list3, list5, false);
                }

                if (this.gclass0_0.GameTime - this.decimal_1 > AuroraUtils.decimal_31)
                {
                    this.decimal_1 = this.gclass0_0.GameTime;
                    if (this.gclass21_0.SpecialNPRID == SpecialNPRIDs.StarSwarm)
                        this.method_52(list1, list11);
                    if (this.gclass21_0.SpecialNPRID == SpecialNPRIDs.const_0)
                    {
                        this.method_23(list3, list1);
                        this.method_53(list3);
                        this.method_56(list3);
                        this.method_50(list3);
                        this.method_57(list3);
                        this.method_61(list3);
                        foreach (PopulationData gclass146 in list3)
                            gclass146.method_180();
                        this.method_58(list3);
                        this.method_59(list3);
                        this.method_60(list3);
                    }

                    if (this.gclass21_0.SpecialNPRID != SpecialNPRIDs.Eldar)
                        this.method_51(list1, list6);
                    List<FleetData> list13 = list1.Where<FleetData>(gclass85_0 =>
                        gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_16 &&
                        gclass85_0.NPRSomething.genum100_0 == GEnum100.const_2 && !gclass85_0.NPRSomething.bRedeployOrderGiven &&
                        gclass85_0.MoveOrderDictionary.Count == 0).ToList<FleetData>();
                    if (list13.Count > 0)
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        UnknownNPRClass2.Class355 class355 = new UnknownNPRClass2.Class355();
                        List<StarSystem> list14 = list4
                            .Where<Contact>(gclass65_0 =>
                                this.gclass0_0.GameTime - gclass65_0.LastUpdate < AuroraUtils.decimal_34 &&
                                gclass65_0.ContactType == AuroraContactType.Ship)
                            .Select<Contact, StarSystem>(gclass65_0 => gclass65_0.System)
                            .Distinct<StarSystem>().ToList<StarSystem>();
                        List<StarSystem> list15 = list4
                            .Where<Contact>(gclass65_0 =>
                                this.gclass0_0.GameTime - gclass65_0.LastUpdate < AuroraUtils.decimal_34 &&
                                gclass65_0.ContactType == AuroraContactType.Population)
                            .Select<Contact, StarSystem>(gclass65_0 => gclass65_0.System)
                            .Distinct<StarSystem>().ToList<StarSystem>();
                        // ISSUE: reference to a compiler-generated field
                        class355.list_0 = list15.Except<StarSystem>(list14).ToList<StarSystem>();
                        // ISSUE: reference to a compiler-generated method
                        List<GClass113> list16 = this.gclass21_0.dictionary_13.Values
                            .Where<GClass113>(class355.method_0).ToList<GClass113>();
                        this.method_27(list3, list1, list13, list16);
                    }
                }

                if (this.gclass0_0.GameTime - this.decimal_3 > AuroraUtils.decimal_33)
                {
                    if (this.gclass21_0.SpecialNPRID == SpecialNPRIDs.const_0)
                    {
                        List<StarSystem> list17 = this.gclass21_0.RacialSystemDictionary.Values
                            .Where<RacialSystemSurvey>(gclass202_0 =>
                                gclass202_0.gclass3_0.genum95_0 > GEnum95.const_1 && gclass202_0.bGeoSurveyDefaultDone)
                            .Except<RacialSystemSurvey>(list10)
                            .Select<RacialSystemSurvey, StarSystem>(gclass202_0 => gclass202_0.ActualSystem)
                            .ToList<StarSystem>();
                        this.decimal_3 = this.gclass0_0.GameTime;
                        this.method_25(list17);
                    }

                    if (this.gclass21_0.SpecialNPRID != SpecialNPRIDs.StarSwarm &&
                        this.gclass21_0.SpecialNPRID != SpecialNPRIDs.Eldar)
                        this.method_54();
                }
            }

            List<FleetData> list18 = this.gclass0_0.FleetDictionary.Values
                .Where<FleetData>(
                    gclass85_0 => gclass85_0.gclass85_0 != null && gclass85_0.Race == this.gclass21_0)
                .Where<FleetData>(gclass85_0 => gclass85_0.gclass85_0.System == gclass85_0.System)
                .ToList<FleetData>();
            if (list18.Count > 0)
            {
                List<FleetData> list19 = list18.Select<FleetData, FleetData>(gclass85_0 => gclass85_0.gclass85_0)
                    .Distinct<FleetData>().ToList<FleetData>();
                foreach (FleetData gclass85 in list18)
                {
                    gclass85.method_263();
                    gclass85.method_222(gclass85.gclass85_0, MoveActionType.JoinFleet);
                    gclass85.NPRSomething.bRedeployOrderGiven = true;
                }

                foreach (FleetData gclass85 in list19)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    UnknownNPRClass2.Class356 class356 = new UnknownNPRClass2.Class356();
                    // ISSUE: reference to a compiler-generated field
                    class356.class351_0 = class351;
                    // ISSUE: reference to a compiler-generated field
                    class356.gclass85_0 = gclass85;
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    FleetData gclass85_5 = list18.Where<FleetData>(class356.method_0)
                        .OrderBy<FleetData, double>(class356.method_1).FirstOrDefault<FleetData>();
                    if (gclass85_5 != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class356.gclass85_0.method_263();
                        // ISSUE: reference to a compiler-generated field
                        class356.gclass85_0.method_222(gclass85_5, MoveActionType.MoveTo);
                        // ISSUE: reference to a compiler-generated field
                        class356.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                    }
                }
            }

            if (list6.Count <= 0 && int_0 <= 10000)
                return;
            if (!bool_0_1)
                this.method_10(list1, list2);
            List<RacialSystemSurvey> gclass202List = new List<RacialSystemSurvey>();
            List<RacialSystemSurvey> list20;
            if (this.gclass21_0.SpecialNPRID == SpecialNPRIDs.Eldar)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                list20 = list1.Select<FleetData, RacialSystemSurvey>(gclass85_0 => gclass85_0.System).Where<RacialSystemSurvey>(
                    new UnknownNPRClass2.Class357()
                    {
                        gclass202_0 = this.gclass21_0.method_190()
                    }.method_0).Distinct<RacialSystemSurvey>().ToList<RacialSystemSurvey>();
            }
            else
                list20 = list1.Select<FleetData, RacialSystemSurvey>(gclass85_0 => gclass85_0.System).Distinct<RacialSystemSurvey>()
                    .ToList<RacialSystemSurvey>();

            foreach (RacialSystemSurvey gclass202 in list20)
            {
                if (gclass202.gclass3_0.genum96_0 == GEnum96.const_4 || int_0 > 10000)
                    gclass202.gclass3_0.method_7(list1, list10, list7);
            }

            if (this.gclass21_0.SpecialNPRID != SpecialNPRIDs.Eldar || this.gclass0_0.Eldar != 1)
                return;
            this.method_3(list1, list10, list7);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 5);
        }
    }

    public void method_10(List<FleetData> list_3, List<ShipData> list_4)
    {
        try
        {
            foreach (ShipData gclass40 in list_4)
            {
                int num = (int)gclass40.gclass5_0.method_12();
            }

            foreach (FleetData gclass85 in list_3)
                gclass85.NPRSomething.method_17();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 7);
        }
    }

    public int method_11(StarSystem gclass200_0, GClass221 gclass221_0, int int_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class358 class358 = new UnknownNPRClass2.Class358();
        // ISSUE: reference to a compiler-generated field
        class358.gclass2_0 = this;
        // ISSUE: reference to a compiler-generated field
        class358.gclass200_0 = gclass200_0;
        // ISSUE: reference to a compiler-generated field
        class358.gclass221_0 = gclass221_0;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            UnknownNPRClass2.Class359 class359 = new UnknownNPRClass2.Class359();
            // ISSUE: reference to a compiler-generated method
            List<ShipData> list1 = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(class358.method_0)
                .SelectMany<FleetData, ShipData>(gclass85_0 => gclass85_0.method_177()).ToList<ShipData>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            class359.list_0 = this.gclass0_0.Populations.Values.Where<PopulationData>(class358.method_1)
                .Where<PopulationData>(class358.method_2).ToList<PopulationData>();
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            List<GroundUnitFormationElement> list2 = this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class358.method_3)
                .Where<GroundUnitFormationData>(class359.method_0).SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 => gclass103_0.ElementList)
                .Where<GroundUnitFormationElement>(gclass39_0 =>
                {
                    if (gclass39_0.GroundUnitClass.gclass230_0 == null)
                        return false;
                    return gclass39_0.TargetSelectionType == AuroraTargetSelection.PointBlankDefensiveFire ||
                           gclass39_0.TargetSelectionType == AuroraTargetSelection.PointBlankDefensiveFireSelf ||
                           gclass39_0.TargetSelectionType == AuroraTargetSelection.RangedDefensiveFire;
                }).ToList<GroundUnitFormationElement>();
            double d = 0.0;
            foreach (ShipData gclass40 in list1)
            {
                gclass40.method_104();
                foreach (FireControlAssignment gclass36 in gclass40.list_4.Where<FireControlAssignment>(gclass36_0 =>
                         {
                             if (gclass36_0.FCComponent.gclass231_0.ComponentTypeID !=
                                 AuroraComponentType.BeamFireControl)
                                 return false;
                             return gclass36_0.PointDefenceMode ==
                                    AuroraPointDefenceMode.PointBlankDefensiveFire ||
                                    gclass36_0.PointDefenceMode == AuroraPointDefenceMode.RangedDefensiveFire;
                         }).ToList<FireControlAssignment>())
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    UnknownNPRClass2.Class360 class360 = new UnknownNPRClass2.Class360();
                    // ISSUE: reference to a compiler-generated field
                    class360.gclass36_0 = gclass36;
                    // ISSUE: reference to a compiler-generated method
                    List<WeaponFireControlAssignment> list3 = gclass40.list_2.Where<WeaponFireControlAssignment>(class360.method_0).ToList<WeaponFireControlAssignment>();
                    if (list3.Count != 0)
                    {
                        foreach (WeaponFireControlAssignment gclass31_0 in list3)
                        {
                            if (gclass31_0.WeaponComponent.method_7() <= 15)
                            {
                                // ISSUE: reference to a compiler-generated field
                                double num = gclass40.method_106(gclass31_0, class360.gclass36_0, 0.0, int_0, 1.0, 1M) /
                                             100.0;
                                if (num > 1.0)
                                    num = 1.0;
                                d += num * gclass31_0.WeaponComponent.int_7;
                            }
                        }
                    }
                }
            }

            foreach (GroundUnitFormationElement gclass39 in list2)
            {
                double num1 = gclass39.method_1(0.0, int_0, 1.0, true, 1M) / 100.0;
                if (num1 > 1.0)
                    num1 = 1.0;
                int num2 = gclass39.UnitCount * gclass39.GroundUnitClass.gclass230_0.int_7;
                d += num1 * num2;
            }

            return (int)Math.Floor(d);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 8);
            return 0;
        }
    }

    public void method_12(List<FleetData> list_3, List<RacialSystemSurvey> list_4, List<RacialSystemSurvey> list_5)
    {
        try
        {
            bool flag1 = false;
            List<RacialSystemSurvey> list1 = list_4
                .OrderByDescending<RacialSystemSurvey, GEnum95>(gclass202_0 => gclass202_0.gclass3_0.genum95_0)
                .ToList<RacialSystemSurvey>();
            if (list1.Count == 0)
                list1 = list_5.OrderByDescending<RacialSystemSurvey, GEnum95>(gclass202_0 => gclass202_0.gclass3_0.genum95_0)
                    .ToList<RacialSystemSurvey>();
            foreach (RacialSystemSurvey gclass202 in list1)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class361 class361 = new UnknownNPRClass2.Class361();
                // ISSUE: reference to a compiler-generated field
                class361.gclass2_0 = this;
                // ISSUE: reference to a compiler-generated field
                class361.gclass202_0 = gclass202;
                // ISSUE: reference to a compiler-generated method
                List<ShipData> list2 = this.gclass0_0.Contacts.Values.Where<Contact>(class361.method_0)
                    .Select<Contact, ShipData>(gclass65_0 => gclass65_0.TargetShip).Distinct<ShipData>()
                    .ToList<ShipData>();
                list2.Select<ShipData, FleetData>(gclass40_0 => gclass40_0.gclass85_0).Distinct<FleetData>()
                    .ToList<FleetData>();
                Decimal num = list2.Where<ShipData>(gclass40_0 => !gclass40_0.gclass22_0.Commercial)
                    .Sum<ShipData>(gclass40_0 => gclass40_0.gclass22_0.ClassCrossSection * gclass40_0.gclass22_0.MaxSpeed);
                // ISSUE: reference to a compiler-generated method
                List<FleetData> list3 = list_3.Where<FleetData>(class361.method_1)
                    .Where<FleetData>(gclass85_0 => gclass85_0.NPROperationGroup.bool_2).ToList<FleetData>();
                bool flag2 = false;
                foreach (FleetData gclass85 in list3)
                {
                    gclass85.method_7();
                    if (gclass85.decimal_7 > num * 2M)
                    {
                        flag2 = true;
                        break;
                    }
                }

                if (!flag2)
                {
                    Decimal decimal_5 = num * 2M;
                    // ISSUE: reference to a compiler-generated field
                    if (!this.method_45(class361.gclass202_0, decimal_5, list_3))
                        flag1 = true;
                }
            }

            if (!flag1)
                return;
            List<FleetData> list4 = list_3.Where<FleetData>(gclass85_0 => gclass85_0.NPROperationGroup.bool_2 &&
                                                                        gclass85_0.NPROperationGroup.genum104_0 !=
                                                                        GEnum104.const_30 &&
                                                                        gclass85_0.NPROperationGroup.genum104_0 !=
                                                                        GEnum104.const_29 &&
                                                                        gclass85_0.NPRSomething.genum100_0 ==
                                                                        GEnum100.const_2 &&
                                                                        !gclass85_0.NPRSomething.bRedeployOrderGiven &&
                                                                        !gclass85_0.NPRSomething.bool_2)
                .ToList<FleetData>();
            if (list4.Count <= 0)
                return;
            foreach (FleetData gclass85 in list4)
                gclass85.method_7();
            this.method_13(list4);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 9);
        }
    }

    public bool method_13(List<FleetData> list_3)
    {
        try
        {
            List<FleetData> list = list_3.OrderByDescending<FleetData, Decimal>(gclass85_0 => gclass85_0.decimal_7)
                .ToList<FleetData>();
            if (list.Count < 2)
                return false;
            foreach (FleetData gclass85 in list)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class362 class362 = new UnknownNPRClass2.Class362();
                // ISSUE: reference to a compiler-generated field
                class362.gclass85_0 = gclass85;
                // ISSUE: reference to a compiler-generated method
                FleetData gclass85_0_1 = list.Where<FleetData>(class362.method_0)
                    .OrderByDescending<FleetData, Decimal>(gclass85_0 => gclass85_0.decimal_7)
                    .FirstOrDefault<FleetData>();
                if (gclass85_0_1 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    this.gclass21_0.method_270(gclass85_0_1.method_176(), gclass85_0_1, class362.gclass85_0, true,
                        false);
                    return true;
                }
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 10);
            return false;
        }
    }

    public void method_14()
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            UnknownNPRClass2.Class363 class363 = new UnknownNPRClass2.Class363();
            List<FleetData> list1 = this.gclass0_0.FleetDictionary.Values
                .Where<FleetData>(gclass85_0 => gclass85_0.Race == this.gclass21_0).ToList<FleetData>();
            List<GroundUnitFormationData> list2 = this.gclass0_0.FormationDictionary.Values
                .Where<GroundUnitFormationData>(gclass103_0 =>
                    gclass103_0.RaceData == this.gclass21_0 && gclass103_0.PopulationData != null)
                .SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 => gclass103_0.ElementList)
                .Where<GroundUnitFormationElement>(gclass39_0 => gclass39_0.GroundUnitClass.gclass230_0 != null)
                .Select<GroundUnitFormationElement, GroundUnitFormationData>(gclass39_0 => gclass39_0.Formation).Distinct<GroundUnitFormationData>()
                .ToList<GroundUnitFormationData>();
            if (list1.Count == 0 && list2.Count == 0)
                return;
            List<RacialSystemSurvey> list3 = list1.Select<FleetData, RacialSystemSurvey>(gclass85_0 => gclass85_0.System)
                .ToList<RacialSystemSurvey>();
            list3.AddRange(list2.Select<GroundUnitFormationData, RacialSystemSurvey>(gclass103_0 => gclass103_0.PopulationData.gclass202_0)
                .ToList<RacialSystemSurvey>());
            List<RacialSystemSurvey> list4 = list3.Distinct<RacialSystemSurvey>().ToList<RacialSystemSurvey>();
            List<Contact> list5 = this.gclass0_0.Contacts.Values
                .Where<Contact>(gclass65_0 =>
                    gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.DetectRace == this.gclass21_0 &&
                    this.gclass0_0.GameTime - gclass65_0.LastUpdate < AuroraUtils.decimal_29)
                .OrderBy<Contact, bool>(gclass65_0 =>
                    this.gclass0_0.GameTime - gclass65_0.LastUpdate < AuroraUtils.decimal_29).ToList<Contact>();
            List<Contact> list6 = this.gclass0_0.Contacts.Values
                .Where<Contact>(gclass65_0 =>
                    gclass65_0.method_5() == AuroraContactStatus.Neutral && gclass65_0.DetectRace == this.gclass21_0 &&
                    this.gclass0_0.GameTime - gclass65_0.LastUpdate < AuroraUtils.decimal_29)
                .OrderBy<Contact, bool>(gclass65_0 =>
                    this.gclass0_0.GameTime - gclass65_0.LastUpdate < AuroraUtils.decimal_29).ToList<Contact>();
            List<Contact> list7 = list5
                .Where<Contact>(gclass65_0 => gclass65_0.LastUpdate == this.gclass0_0.GameTime && gclass65_0.ContinualContactTime > 0)
                .ToList<Contact>();
            foreach (RacialSystemSurvey gclass202 in list4)
            {
                gclass202.gclass3_0.method_1(list1, list5, list6);
                gclass202.gclass3_0.method_0(list1, list5, list6);
            }

            if (list5.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated field
            class363.list_0 = list7.Select<Contact, StarSystem>(gclass65_0 => gclass65_0.System)
                .Distinct<StarSystem>().ToList<StarSystem>();
            // ISSUE: reference to a compiler-generated field
            if (class363.list_0.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated method
            foreach (RacialSystemSurvey gclass202 in this.gclass21_0.RacialSystemDictionary.Values.Where<RacialSystemSurvey>(class363.method_0)
                         .ToList<RacialSystemSurvey>())
                gclass202.gclass3_0.method_2(list1, list2, list7);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 11);
        }
    }

    public void method_15()
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            UnknownNPRClass2.Class364 class364 = new UnknownNPRClass2.Class364();
            // ISSUE: reference to a compiler-generated field
            class364.gclass146_0 = this.gclass21_0.method_191();
            // ISSUE: reference to a compiler-generated method
            foreach (PopulationData gclass146 in this.gclass0_0.Populations.Values
                         .Where<PopulationData>(gclass146_0 => gclass146_0.Race == this.gclass21_0)
                         .Where<PopulationData>(class364.method_0).ToList<PopulationData>())
            {
                // ISSUE: reference to a compiler-generated field
                gclass146.gclass6_0.method_3(class364.gclass146_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 12);
        }
    }

    public void method_16()
    {
        try
        {
            List<ShipData> list1 = this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass21_0 == this.gclass21_0).ToList<ShipData>();
            List<ShipData> list2 = list1
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass22_0.AutomatedClassDesign.HiveShipSizeClass > 0)
                .ToList<ShipData>();
            if (list2.Count == 0)
                return;
            foreach (ShipData gclass40_1 in list1.Where<ShipData>(gclass40_0 =>
                             gclass40_0.gclass22_0.AutomatedClassDesign.HiveShipSizeClass == 0 && gclass40_0.decimal_17 > 0M)
                         .ToList<ShipData>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class365 class365 = new UnknownNPRClass2.Class365();
                // ISSUE: reference to a compiler-generated field
                class365.gclass2_0 = this;
                // ISSUE: reference to a compiler-generated field
                class365.gclass40_0 = gclass40_1;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                List<ShipData> list3 = list2.Where<ShipData>(class365.method_0)
                    .OrderBy<ShipData, double>(class365.method_1).ToList<ShipData>();
                if (list3.Count != 0)
                {
                    foreach (ShipData gclass40_2 in list3)
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (!(gclass40_2.gclass22_0.BioEnergyCapacity - gclass40_2.decimal_17 >= class365.gclass40_0.decimal_17))
                        {
                            Decimal num = gclass40_2.gclass22_0.BioEnergyCapacity - gclass40_2.decimal_17;
                            gclass40_2.decimal_17 = gclass40_2.gclass22_0.BioEnergyCapacity;
                            // ISSUE: reference to a compiler-generated field
                            class365.gclass40_0.decimal_17 -= num;
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated field
                            gclass40_2.decimal_17 += class365.gclass40_0.decimal_17;
                            // ISSUE: reference to a compiler-generated field
                            class365.gclass40_0.decimal_17 = 0M;
                            break;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 13);
        }
    }

    public void method_17(List<ShipData> list_3, List<RacialSystemSurvey> list_4, List<FleetData> list_5)
    {
        try
        {
            List<ShipData> list = list_3
                .Where<ShipData>(gclass40_0 =>
                    gclass40_0.gclass22_0.AutomatedClassDesign.HiveShipSizeClass > 0 && gclass40_0.decimal_17 > 250M)
                .ToList<ShipData>();
            int num1 = list.OrderByDescending<ShipData, int>(gclass40_0 => gclass40_0.gclass22_0.AutomatedClassDesign.HiveShipSizeClass)
                .Select<ShipData, int>(gclass40_0 => gclass40_0.gclass22_0.AutomatedClassDesign.HiveShipSizeClass)
                .FirstOrDefault<int>();
            using (List<ShipData>.Enumerator enumerator = list.GetEnumerator())
            {
                label_46:
                while (enumerator.MoveNext())
                {
                    ShipData current = enumerator.Current;
                    if (current.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID != AutomatedClassDesignType.SwarmHiveVeryLarge &&
                        current.decimal_17 == current.gclass22_0.BioEnergyCapacity)
                        this.method_21(current);
                    else if (list_4.Contains(current.gclass85_0.System))
                    {
                        Decimal num2 = this.method_20(list_3, current.gclass85_0.System, AutomatedClassDesignType.SwarmCruiser);
                        Decimal num3 = this.method_20(list_3, current.gclass85_0.System, AutomatedClassDesignType.SwarmEscort);
                        Decimal num4 = this.method_20(list_3, current.gclass85_0.System, AutomatedClassDesignType.SwarmMicrowaveFAC);
                        Decimal num5 = this.method_20(list_3, current.gclass85_0.System, AutomatedClassDesignType.SwarmBioAcidFAC);
                        Decimal num6 = this.method_20(list_3, current.gclass85_0.System, AutomatedClassDesignType.SwarmBoardingFAC);
                        Decimal num7 = this.method_20(list_3, current.gclass85_0.System, AutomatedClassDesignType.SwarmJumpFAC);
                        Decimal num8 = num5 + num4 + num7 + num6;
                        if (num2 < num8 / 2M)
                        {
                            ShipClass gclass22_0 = this.method_19(AutomatedClassDesignType.SwarmCruiser);
                            if (gclass22_0.Cost <= current.decimal_17)
                            {
                                this.method_18(gclass22_0, current);
                                current.decimal_17 -= gclass22_0.Cost;
                                Decimal num9 = num2 + gclass22_0.Size;
                            }
                        }

                        if (num3 < num8 / 2M)
                        {
                            ShipClass gclass22_0 = this.method_19(AutomatedClassDesignType.SwarmCruiser);
                            if (gclass22_0.Cost <= current.decimal_17)
                            {
                                this.method_18(gclass22_0, current);
                                current.decimal_17 -= gclass22_0.Cost;
                                Decimal num10 = num3 + gclass22_0.Size;
                            }
                        }

                        if (num7 < num8 / 10M)
                        {
                            ShipClass gclass22_0 = this.method_19(AutomatedClassDesignType.SwarmJumpFAC);
                            for (int index = 1; index <= 2 && gclass22_0.Cost <= current.decimal_17; ++index)
                            {
                                this.method_18(gclass22_0, current);
                                current.decimal_17 -= gclass22_0.Cost;
                                num8 += gclass22_0.Size;
                            }
                        }

                        if (num5 < num8 / 2M || num8 == 0M)
                        {
                            ShipClass gclass22_0 = this.method_19(AutomatedClassDesignType.SwarmBioAcidFAC);
                            for (int index = 1; index <= 5 && gclass22_0.Cost <= current.decimal_17; ++index)
                            {
                                this.method_18(gclass22_0, current);
                                current.decimal_17 -= gclass22_0.Cost;
                                num8 += gclass22_0.Size;
                            }
                        }

                        if (num4 < num8 / 3M)
                        {
                            ShipClass gclass22_0 = this.method_19(AutomatedClassDesignType.SwarmMicrowaveFAC);
                            for (int index = 1; index <= 5 && gclass22_0.Cost <= current.decimal_17; ++index)
                            {
                                this.method_18(gclass22_0, current);
                                current.decimal_17 -= gclass22_0.Cost;
                                num8 += gclass22_0.Size;
                            }
                        }

                        if (num6 < num8 / 6M)
                        {
                            ShipClass gclass22_0 = this.method_19(AutomatedClassDesignType.SwarmBoardingFAC);
                            int num11 = 1;
                            while (true)
                            {
                                if (num11 <= 5 && gclass22_0.Cost <= current.decimal_17)
                                {
                                    this.method_18(gclass22_0, current);
                                    current.decimal_17 -= gclass22_0.Cost;
                                    num8 += gclass22_0.Size;
                                    ++num11;
                                }
                                else
                                    goto label_46;
                            }
                        }
                    }
                    else
                    {
                        Decimal num12 = list_3.Count<ShipData>(gclass40_0 =>
                            gclass40_0.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID == AutomatedClassDesignType.SwarmSalvager);
                        Decimal num13 = list_3.Count<ShipData>(gclass40_0 =>
                            gclass40_0.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID == AutomatedClassDesignType.SwarmWorker);
                        Decimal num14 = list_3.Count<ShipData>(gclass40_0 =>
                            gclass40_0.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID == AutomatedClassDesignType.SwarmGeosurvey);
                        Decimal num15 = list_3.Count<ShipData>(gclass40_0 =>
                            gclass40_0.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID == AutomatedClassDesignType.SwarmGravsurvey);
                        Decimal num16 = list_3.Count<ShipData>(gclass40_0 =>
                            gclass40_0.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID == AutomatedClassDesignType.SwarmAssualtTransport);
                        ShipClass gclass22_0_1 = this.method_19(AutomatedClassDesignType.SwarmWorker);
                        if (num13 < num14 && gclass22_0_1.Cost <= current.decimal_17)
                        {
                            this.method_18(gclass22_0_1, current);
                            current.decimal_17 -= gclass22_0_1.Cost;
                            if (current.decimal_17 < 1000M)
                                continue;
                        }

                        if (num12 < num14 && num12 < num1 * 2)
                        {
                            ShipClass gclass22_0_2 = this.method_19(AutomatedClassDesignType.SwarmSalvager);
                            if (gclass22_0_2.Cost <= current.decimal_17)
                            {
                                this.method_18(gclass22_0_2, current);
                                current.decimal_17 -= gclass22_0_2.Cost;
                                if (current.decimal_17 < 1000M)
                                    continue;
                            }
                        }

                        if (num14 < num1 * 2)
                        {
                            ShipClass gclass22_0_3 = this.method_19(AutomatedClassDesignType.SwarmGeosurvey);
                            if (gclass22_0_3.Cost <= current.decimal_17)
                            {
                                this.method_18(gclass22_0_3, current);
                                current.decimal_17 -= gclass22_0_3.Cost;
                                if (current.decimal_17 < 1000M)
                                    continue;
                            }
                        }

                        if (num15 < num1 * 2)
                        {
                            ShipClass gclass22_0_4 = this.method_19(AutomatedClassDesignType.SwarmGravsurvey);
                            if (gclass22_0_4.Cost <= current.decimal_17)
                            {
                                this.method_18(gclass22_0_4, current);
                                current.decimal_17 -= gclass22_0_4.Cost;
                                if (current.decimal_17 < 1000M)
                                    continue;
                            }
                        }

                        if (num13 < num14 * 3M && gclass22_0_1.Cost <= current.decimal_17)
                        {
                            this.method_18(gclass22_0_1, current);
                            current.decimal_17 -= gclass22_0_1.Cost;
                        }

                        if (num16 < num1)
                        {
                            ShipClass gclass22_0_5 = this.method_19(AutomatedClassDesignType.SwarmAssualtTransport);
                            if (gclass22_0_5.Cost <= current.decimal_17)
                            {
                                this.method_18(gclass22_0_5, current);
                                current.decimal_17 -= gclass22_0_5.Cost;
                            }
                        }

                        if (current.gclass22_0.AutomatedClassDesign.HiveShipSizeClass == 4)
                        {
                            ShipClass gclass22_0_6 = this.method_19(AutomatedClassDesignType.SwarmHiveSmall);
                            if (gclass22_0_6.Cost <= current.decimal_17)
                            {
                                this.method_18(gclass22_0_6, current);
                                current.decimal_17 -= gclass22_0_6.Cost;
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 14);
        }
    }

    public void method_18(ShipClass gclass22_0, ShipData gclass40_0)
    {
        try
        {
            ShipData gclass40 = this.gclass21_0.method_304(null, gclass40_0, null, gclass22_0, null, null, null,
                null, null, "", 100M, false, false, GEnum20.const_0);
            gclass40.gclass85_0.method_202();
            this.gclass0_0.gclass92_0.method_2(EventType.const_2, $"{gclass40.ShipName} built by {gclass40_0.ShipName}",
                this.gclass21_0, gclass40_0.gclass85_0.System.ActualSystem, gclass40_0.gclass85_0.XCoord,
                gclass40_0.gclass85_0.YCoord, AuroraEventCategory.Ship);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 15);
        }
    }

    public ShipClass method_19(AutomatedClassDesignType genum120_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class366 class366 = new UnknownNPRClass2.Class366();
        // ISSUE: reference to a compiler-generated field
        class366.gclass2_0 = this;
        // ISSUE: reference to a compiler-generated field
        class366.genum120_0 = genum120_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.ShipClasses.Values.FirstOrDefault<ShipClass>(class366.method_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 16 /*0x10*/);
            return null;
        }
    }

    public Decimal method_20(List<ShipData> list_3, RacialSystemSurvey gclass202_0, AutomatedClassDesignType genum120_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class367 class367 = new UnknownNPRClass2.Class367();
        // ISSUE: reference to a compiler-generated field
        class367.gclass202_0 = gclass202_0;
        // ISSUE: reference to a compiler-generated field
        class367.genum120_0 = genum120_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            return list_3.Where<ShipData>(class367.method_0)
                .Sum<ShipData>(gclass40_0 => gclass40_0.gclass22_0.Size);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 17);
            return 0M;
        }
    }

    public void method_21(ShipData gclass40_0)
    {
        try
        {
            ShipClass gclass22_1 = null;
            if (gclass40_0.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID != AutomatedClassDesignType.SwarmHiveSmall)
                gclass22_1 = this.gclass0_0.ShipClasses.Values.FirstOrDefault<ShipClass>(gclass22_0 =>
                    gclass22_0.Race == this.gclass21_0 && gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID == AutomatedClassDesignType.SwarmHiveMedium);
            else if (gclass40_0.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID != AutomatedClassDesignType.SwarmHiveMedium)
                gclass22_1 = this.gclass0_0.ShipClasses.Values.FirstOrDefault<ShipClass>(gclass22_0 =>
                    gclass22_0.Race == this.gclass21_0 && gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID == AutomatedClassDesignType.SwarmHiveLarge);
            else if (gclass40_0.gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID != AutomatedClassDesignType.SwarmHiveLarge)
                gclass22_1 = this.gclass0_0.ShipClasses.Values.FirstOrDefault<ShipClass>(gclass22_0 =>
                    gclass22_0.Race == this.gclass21_0 && gclass22_0.AutomatedClassDesign.AutomatedClassDesignTypeID == AutomatedClassDesignType.SwarmHiveVeryLarge);
            if (gclass22_1 == null)
                return;
            gclass40_0.method_204("Refit to " + gclass22_1.ClassName);
            gclass40_0.method_199(gclass22_1, null);
            this.gclass0_0.gclass92_0.method_2(EventType.const_2,
                $"{gclass40_0.ShipName} refitted to {gclass22_1.ClassName} class", gclass40_0.gclass21_0,
                gclass40_0.gclass85_0.System.ActualSystem, gclass40_0.gclass85_0.XCoord,
                gclass40_0.gclass85_0.YCoord, AuroraEventCategory.Ship);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 18);
        }
    }

    public void method_22(TechSystem gclass164_0, int int_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class368 class368 = new UnknownNPRClass2.Class368();
        // ISSUE: reference to a compiler-generated field
        class368.gclass164_0 = gclass164_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            SwarmResearch gclass168 = this.gclass21_0.list_7.FirstOrDefault<SwarmResearch>(class368.method_0);
            if (gclass168 != null)
            {
                // ISSUE: reference to a compiler-generated field
                if (gclass168.ResearchPoints + int_0 < class368.gclass164_0.int_4)
                {
                    gclass168.ResearchPoints += int_0;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    this.gclass21_0.method_282(class368.gclass164_0, null, null, null, false, false);
                    this.gclass21_0.list_7.Remove(gclass168);
                }
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                this.gclass21_0.list_7.Add(new SwarmResearch()
                {
                    TechSystem = class368.gclass164_0,
                    Race = this.gclass21_0,
                    ResearchPoints = int_0
                });
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 19);
        }
    }

    public void method_23(List<PopulationData> list_3, List<FleetData> list_4)
    {
        try
        {
            List<GroundUnitFormationData> list = this.gclass0_0.FormationDictionary.Values
                .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.RaceData == this.gclass21_0).ToList<GroundUnitFormationData>();
            foreach (PopulationData gclass146 in list_3)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class369 class369 = new UnknownNPRClass2.Class369();
                // ISSUE: reference to a compiler-generated field
                class369.gclass146_0 = gclass146;
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
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!(class369.gclass146_0.decimal_30 > 0M) && class369.gclass146_0.dictionary_0.Count <= 0 &&
                    class369.gclass146_0.gclass6_0.double_1 < AuroraUtils.double_29 &&
                    (class369.gclass146_0.gclass6_0.double_0 <= 0.0 ||
                     class369.gclass146_0.gclass6_0.double_0 >= 0.1) && class369.gclass146_0.SystemBodyData.AbandonedFactories <= 0 &&
                    class369.gclass146_0.SystemBodyData.GroundMineralSurveyState <= AuroraGroundMineralSurvey.Minimal &&
                    !class369.gclass146_0.bIsInvasionStagingPoint &&
                    !(class369.gclass146_0.SystemBodyData.method_58(class369.gclass146_0.Race,
                        class369.gclass146_0.Species, false) < 2M) &&
                    list.Count<GroundUnitFormationData>(class369.method_0) <= 0 && list_4
                        .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                        .Where<MoveOrder>(class369.method_1).ToList<MoveOrder>().Count <= 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    this.gclass21_0.method_132(class369.gclass146_0);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 20);
        }
    }

    public void method_24(List<PopulationData> list_3, List<FleetData> list_4, PopulationData gclass146_0)
    {
        try
        {
            List<GroundUnitFormationData> list1 = this.gclass0_0.FormationDictionary.Values
                .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.RaceData == this.gclass21_0).ToList<GroundUnitFormationData>();
            foreach (PopulationData gclass146 in list_3)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class370 class370 = new UnknownNPRClass2.Class370();
                // ISSUE: reference to a compiler-generated field
                class370.gclass146_0 = gclass146;
                // ISSUE: reference to a compiler-generated method
                if (list1.Count<GroundUnitFormationData>(class370.method_0) <= 0)
                {
                    // ISSUE: reference to a compiler-generated method
                    List<MoveOrder> list2 = list_4
                        .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                        .Where<MoveOrder>(class370.method_1).ToList<MoveOrder>();
                    if (list2.Count <= 0 || gclass146_0 != null)
                    {
                        foreach (MoveOrder gclass139 in list2)
                            gclass139.Population = gclass146_0;
                        // ISSUE: reference to a compiler-generated field
                        this.gclass21_0.method_132(class370.gclass146_0);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 21);
        }
    }

    public void method_25(List<StarSystem> list_3)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class371 class371 = new UnknownNPRClass2.Class371();
        // ISSUE: reference to a compiler-generated field
        class371.gclass2_0 = this;
        // ISSUE: reference to a compiler-generated field
        class371.list_0 = list_3;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            UnknownNPRClass2.Class372 class372 = new UnknownNPRClass2.Class372();
            // ISSUE: reference to a compiler-generated field
            class372.class371_0 = class371;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            List<SystemBodyData> list1 = this.gclass0_0.Populations.Values
                .Where<PopulationData>(class372.class371_0.method_0)
                .Select<PopulationData, SystemBodyData>(gclass146_0 => gclass146_0.SystemBodyData)
                .ToList<SystemBodyData>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            List<SystemBodyData> list2 = this.gclass0_0.SystemBodySurveys.Where<RacialSystemBodySurvey>(class372.class371_0.method_1)
                .Select<RacialSystemBodySurvey, SystemBodyData>(gclass215_0 => gclass215_0.SystemBody)
                .Except<SystemBodyData>(list1)
                .Except<SystemBodyData>(this.gclass21_0.BannedSystemBodies).ToList<SystemBodyData>();
            // ISSUE: reference to a compiler-generated field
            class372.gclass194_0 = this.gclass21_0.method_164();
            foreach (SystemBodyData gclass1_0 in list2)
            {
                if (this.method_62(gclass1_0, false) >= AuroraUtils.double_29)
                {
                    // ISSUE: reference to a compiler-generated field
                    PopulationData gclass146 = this.gclass21_0.method_276(gclass1_0, class372.gclass194_0, false);
                    // ISSUE: reference to a compiler-generated field
                    gclass1_0.method_58(this.gclass21_0, class372.gclass194_0, true);
                    if (!(gclass1_0.ColonyCost < 0M))
                    {
                        gclass146.method_60(this.gclass0_0.InstallationTypes[AuroraInstallationType.TrackingStation], 1,
                            false);
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (gclass1_0.MaxColonyCost >= 0M && gclass1_0.MaxColonyCost < 2.5M &&
                            gclass1_0.Gravity >= class372.gclass194_0.double_7 &&
                            gclass1_0.Gravity <= class372.gclass194_0.double_8)
                        {
                            gclass146.method_60(this.gclass0_0.InstallationTypes[AuroraInstallationType.Infrastructure], 50,
                                false);
                            gclass146.method_25(0.0001M);
                        }

                        // ISSUE: reference to a compiler-generated field
                        if (gclass1_0.MaxColonyCost >= 0M && gclass1_0.MaxColonyCost < 2M &&
                            gclass1_0.Gravity < class372.gclass194_0.double_7)
                        {
                            gclass146.method_60(this.gclass0_0.InstallationTypes[AuroraInstallationType.Infrastructure],
                                100, false);
                            gclass146.method_25(0.0001M);
                        }
                    }
                }
            }

            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class372.class371_0.list_0.Count == 0 || this.gclass21_0.ColonyDensity <= 0)
                return;
            bool flag = false;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            List<SystemBodyData> list3 = this.gclass0_0.Populations.Values
                .Where<PopulationData>(class372.class371_0.method_2)
                .Select<PopulationData, SystemBodyData>(gclass146_0 => gclass146_0.SystemBodyData)
                .ToList<SystemBodyData>();
            if (list3.Count <= 1)
            {
                flag = true;
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class372.class371_0.list_0.Count / (double)(list3.Count - 1) > this.gclass21_0.ColonyDensity)
                    flag = true;
            }

            if (!flag)
                return;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            List<SystemBodyData> list4 = list2.Where<SystemBodyData>(class372.method_0)
                .Where<SystemBodyData>(class372.class371_0.method_3)
                .Where<SystemBodyData>(gclass1_0 => gclass1_0.method_16(40, false))
                .Except<SystemBodyData>(list3).ToList<SystemBodyData>();
            foreach (SystemBodyData gclass1 in list4)
            {
                // ISSUE: reference to a compiler-generated field
                gclass1.method_58(this.gclass21_0, class372.gclass194_0, true);
            }

            List<SystemBodyData> list5 = list4
                .Where<SystemBodyData>(gclass1_0 => gclass1_0.MaxColonyCost >= 0M && gclass1_0.MaxColonyCost < 1.5M)
                .ToList<SystemBodyData>();
            if (list5.Count > 0)
            {
                foreach (SystemBodyData gclass1_0 in list5)
                {
                    // ISSUE: reference to a compiler-generated field
                    this.method_26(gclass1_0, class372.gclass194_0);
                }
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                class372.gclass200_0 = this.gclass21_0.method_190().ActualSystem;
                // ISSUE: reference to a compiler-generated method
                SystemBodyData gclass1_0_1 = list4
                    .Where<SystemBodyData>(gclass1_0 => gclass1_0.MaxColonyCost >= 0M && gclass1_0.MaxColonyCost < 2.5M)
                    .OrderBy<SystemBodyData, Decimal>(gclass1_0 => gclass1_0.MaxColonyCost)
                    .ThenByDescending<SystemBodyData, int>(class372.method_1)
                    .FirstOrDefault<SystemBodyData>();
                if (gclass1_0_1 == null)
                    return;
                // ISSUE: reference to a compiler-generated field
                this.method_26(gclass1_0_1, class372.gclass194_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 22);
        }
    }

    public void method_26(SystemBodyData gclass1_0, Species gclass194_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class373 class373 = new UnknownNPRClass2.Class373();
        // ISSUE: reference to a compiler-generated field
        class373.gclass1_0 = gclass1_0;
        // ISSUE: reference to a compiler-generated field
        class373.gclass2_0 = this;
        // ISSUE: reference to a compiler-generated field
        class373.gclass194_0 = gclass194_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            PopulationData gclass146 = this.gclass0_0.Populations.Values.FirstOrDefault<PopulationData>(class373.method_0) ??
                                  this.gclass21_0.method_276(class373.gclass1_0, class373.gclass194_0, false);
            gclass146.method_25(0.0001M);
            gclass146.method_60(this.gclass0_0.InstallationTypes[AuroraInstallationType.TrackingStation], 1, false);
            // ISSUE: reference to a compiler-generated field
            if (!(class373.gclass1_0.MaxColonyCost > 0M))
                return;
            gclass146.method_60(this.gclass0_0.InstallationTypes[AuroraInstallationType.Infrastructure], 50, false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 23);
        }
    }

    public void method_27(
        List<PopulationData> list_3,
        List<FleetData> list_4,
        List<FleetData> list_5,
        List<GClass113> list_6)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            UnknownNPRClass2.Class374 class374 = new UnknownNPRClass2.Class374();
            // ISSUE: reference to a compiler-generated field
            class374.gclass2_0 = this;
            PopulationData gclass146_1 = null;
            GroundUnitFormationTemplateData gclass102_1 = null;
            GroundUnitFormationTemplateData gclass102_2 = null;
            GroundUnitFormationTemplateData gclass102_3 = null;
            GroundUnitFormationTemplateData gclass102_4 = null;
            GroundUnitFormationTemplateData gclass102_5 = null;
            GroundUnitFormationTemplateData gclass102_6 = null;
            Decimal num1 = 0M;
            Decimal num2 = 0M;
            Decimal num3 = 0M;
            Decimal num4 = 0M;
            Decimal num5 = 0M;
            Decimal num6 = 0M;
            this.list_0.Clear();
            if (this.gclass21_0.SpecialNPRID == SpecialNPRIDs.Eldar)
                gclass146_1 = this.gclass21_0.method_191();
            foreach (PopulationData gclass146_2 in list_3)
            {
                gclass146_2.gclass6_0.method_6();
                gclass146_2.bIsInvasionStagingPoint = false;
            }

            List<MoveOrder> list1 = list_4.SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                .Where<MoveOrder>(gclass139_0 =>
                    gclass139_0.MoveActionType.MoveActionType == MoveActionType.UnloadGroundUnitFromTransportBay ||
                    gclass139_0.MoveActionType.MoveActionType == MoveActionType.UnloadAllGroundUnitsFromTransportBay).ToList<MoveOrder>();
            // ISSUE: reference to a compiler-generated field
            class374.list_0 = list_4.SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                .Where<MoveOrder>(gclass139_0 => gclass139_0.MoveActionType.MoveActionType == MoveActionType.LoadGroundUnitIntoTransportBay)
                .ToList<MoveOrder>();
            List<GroundUnitFormationData> list2 = this.gclass0_0.FormationDictionary.Values
                .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.ShipData != null)
                .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.ShipData.gclass85_0.Race == this.gclass21_0)
                .ToList<GroundUnitFormationData>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            class374.list_1 = this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class374.method_0)
                .ToList<GroundUnitFormationData>();
            List<AutomatedGroundTemplateDesignType> list3 = this.gclass0_0.FormationDictionary.Values
                .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.RaceData == this.gclass21_0)
                .Select<GroundUnitFormationData, AutomatedGroundTemplateDesignType>(gclass103_0 => gclass103_0.OriginalTemplateData.AutomatedTemplateType).Distinct<AutomatedGroundTemplateDesignType>()
                .ToList<AutomatedGroundTemplateDesignType>();
            List<FleetData> list4 = list_5.Where<FleetData>(gclass85_0 => !gclass85_0.method_145()).ToList<FleetData>();
            bool flag1 = false;
            if (list_6.Count > 0)
            {
                List<Contact> list5 = this.gclass0_0.Contacts.Values.Where<Contact>(gclass65_0 =>
                    gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.DetectRace == this.gclass21_0 &&
                    gclass65_0.ContactType == AuroraContactType.GroundUnit).ToList<Contact>();
                List<SystemBodyData> list6 = list_3
                    .Select<PopulationData, SystemBodyData>(gclass146_0 => gclass146_0.SystemBodyData)
                    .ToList<SystemBodyData>();
                Species gclass194_1 = this.gclass21_0.method_164();
                foreach (GClass113 gclass113 in list_6)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    UnknownNPRClass2.Class375 class375 = new UnknownNPRClass2.Class375();
                    // ISSUE: reference to a compiler-generated field
                    class375.gclass113_0 = gclass113;
                    PopulationData gclass146_3;
                    // ISSUE: reference to a compiler-generated field
                    if (!list6.Contains(class375.gclass113_0.gclass146_0.SystemBodyData))
                    {
                        // ISSUE: reference to a compiler-generated field
                        gclass146_3 = this.gclass21_0.method_276(class375.gclass113_0.gclass146_0.SystemBodyData,
                            gclass194_1, false);
                        list_3.Add(gclass146_3);
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated method
                        gclass146_3 = list_3.FirstOrDefault<PopulationData>(class375.method_0);
                    }

                    if (gclass146_3 != null)
                    {
                        // ISSUE: reference to a compiler-generated method
                        Contact gclass65 = list5.FirstOrDefault<Contact>(class375.method_1);
                        gclass146_3.decimal_10 = 0M;
                        gclass146_3.bIsInvasionStagingPoint = true;
                        flag1 = true;
                        // ISSUE: reference to a compiler-generated field
                        gclass146_3.decimal_10 = gclass65 != null
                            ? 100M * gclass146_3.SystemBodyData.DominantTerrain.FortificationModifier * 3M * gclass65.ContactStrength
                            : class375.gclass113_0.gclass146_0.Population * 1000M;
                    }
                }
            }

            if (flag1)
            {
                gclass102_1 = this.gclass0_0.FormationTemplateRecordDic.Values.FirstOrDefault<GroundUnitFormationTemplateData>(gclass102_0 =>
                    gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.InfantryRegiment && gclass102_0.RaceData == this.gclass21_0);
                gclass102_2 = this.gclass0_0.FormationTemplateRecordDic.Values.FirstOrDefault<GroundUnitFormationTemplateData>(gclass102_0 =>
                    gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.ArmourRegiment && gclass102_0.RaceData == this.gclass21_0);
                gclass102_3 = this.gclass0_0.FormationTemplateRecordDic.Values.FirstOrDefault<GroundUnitFormationTemplateData>(gclass102_0 =>
                    gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.InfantryBrigadeHQ && gclass102_0.RaceData == this.gclass21_0);
                gclass102_4 = this.gclass0_0.FormationTemplateRecordDic.Values.FirstOrDefault<GroundUnitFormationTemplateData>(gclass102_0 =>
                    gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.ArmourBrigadeHQ && gclass102_0.RaceData == this.gclass21_0);
                gclass102_5 = this.gclass0_0.FormationTemplateRecordDic.Values.FirstOrDefault<GroundUnitFormationTemplateData>(gclass102_0 =>
                    gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.PlanetaryAssaultSwarm && gclass102_0.RaceData == this.gclass21_0);
                if (gclass102_1 != null)
                    num1 = gclass102_1.method_9();
                if (gclass102_2 != null)
                    num2 = gclass102_2.method_9();
                if (gclass102_5 != null)
                    num3 = gclass102_5.method_9();
                if (gclass102_3 != null)
                    num5 = gclass102_3.method_8();
                if (gclass102_4 != null)
                    num6 = gclass102_4.method_8();
            }

            if (this.gclass21_0.SpecialNPRID == SpecialNPRIDs.Eldar)
            {
                gclass102_6 = this.gclass0_0.FormationTemplateRecordDic.Values.FirstOrDefault<GroundUnitFormationTemplateData>(gclass102_0 =>
                    gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.EldarAssaultForce && gclass102_0.RaceData == this.gclass21_0);
                if (gclass102_6 != null)
                    num4 = gclass102_6.method_9();
            }

            foreach (PopulationData gclass146_4 in list_3)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class376 class376 = new UnknownNPRClass2.Class376();
                // ISSUE: reference to a compiler-generated field
                class376.class374_0 = class374;
                // ISSUE: reference to a compiler-generated field
                class376.gclass146_0 = gclass146_4;
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class377 class377 = new UnknownNPRClass2.Class377();
                // ISSUE: reference to a compiler-generated field
                class377.class376_0 = class376;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (this.gclass21_0.SpecialNPRID != SpecialNPRIDs.Eldar ||
                    gclass146_1 != class377.class376_0.gclass146_0)
                {
                    List<AutomatedGroundTemplateDesignType> list_3_1 = new List<AutomatedGroundTemplateDesignType>();
                    List<GClass16> gclass16List = new List<GClass16>();
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (!class377.class376_0.gclass146_0.bIsInvasionStagingPoint)
                    {
                        if (this.gclass21_0.SpecialNPRID == SpecialNPRIDs.Eldar)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (class377.class376_0.gclass146_0.gclass6_0.genum97_0 > GEnum97.const_1)
                                this.method_28(gclass102_6.AutomatedTemplateType, 1, list_3_1, gclass16List);
                        }
                        else
                        {
                            foreach (AutomatedGroundTemplateDesignType genum116 in list3)
                                list_3_1.Add(genum116);
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            gclass16List = this.gclass21_0.DesignDoctrine.NameList_0
                                .Where<GClass16>(class377.class376_0.method_0).ToList<GClass16>();
                        }
                    }
                    else
                    {
                        int int_0_1 = 0;
                        if (num4 > 0M)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            int int_0_2 = (int)Math.Ceiling(class377.class376_0.gclass146_0.decimal_10 * 2M / num4);
                            this.method_28(gclass102_6.AutomatedTemplateType, int_0_2, list_3_1, gclass16List);
                        }

                        if (num1 > 0M)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            int_0_1 = (int)Math.Ceiling(class377.class376_0.gclass146_0.decimal_10 * 2M / num1);
                            this.method_28(gclass102_1.AutomatedTemplateType, int_0_1, list_3_1, gclass16List);
                        }

                        if (num2 > 0M)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            int int_0_3 = (int)Math.Ceiling(class377.class376_0.gclass146_0.decimal_10 / num2);
                            this.method_28(gclass102_2.AutomatedTemplateType, int_0_3, list_3_1, gclass16List);
                        }

                        if (num3 > 0M)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            int int_0_4 = (int)Math.Ceiling(class377.class376_0.gclass146_0.decimal_10 * 2M / num3);
                            this.method_28(gclass102_5.AutomatedTemplateType, int_0_4, list_3_1, gclass16List);
                        }

                        if (num5 > 0M)
                        {
                            int int_0_5 = (int)Math.Floor(int_0_1 * num1 / num5);
                            this.method_28(gclass102_3.AutomatedTemplateType, int_0_5, list_3_1, gclass16List);
                        }

                        if (num6 > 0M)
                        {
                            int int_0_6 = (int)Math.Floor(int_0_1 * num1 / num5);
                            this.method_28(gclass102_4.AutomatedTemplateType, int_0_6, list_3_1, gclass16List);
                        }
                    }

                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    class377.list_0 = list1.Where<MoveOrder>(class377.class376_0.method_1)
                        .Select<MoveOrder, FleetData>(gclass139_0 => gclass139_0.Fleet).ToList<FleetData>();
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    List<FleetData> list7 = list_4.Where<FleetData>(class377.class376_0.method_2).ToList<FleetData>();
                    foreach (AutomatedGroundTemplateDesignType genum116 in list_3_1)
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        UnknownNPRClass2.Class378 class378 = new UnknownNPRClass2.Class378();
                        // ISSUE: reference to a compiler-generated field
                        class378.class377_0 = class377;
                        // ISSUE: reference to a compiler-generated field
                        class378.genum116_0 = genum116;
                        GClass17 gclass17 = new GClass17();
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        gclass17.gclass146_0 = class378.class377_0.class376_0.gclass146_0;
                        // ISSUE: reference to a compiler-generated field
                        gclass17.genum116_0 = class378.genum116_0;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        gclass17.int_3 = class378.class377_0.class376_0.gclass146_0.gclass6_0.list_0
                            .Where<GroundUnitFormationData>(class378.method_0)
                            .Except<GroundUnitFormationData>(class378.class377_0.class376_0.class374_0.list_1).Count<GroundUnitFormationData>();
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class378.class377_0.list_0.Count > 0)
                        {
                            // ISSUE: reference to a compiler-generated method
                            gclass17.int_4 = list2.Where<GroundUnitFormationData>(class378.method_1).Count<GroundUnitFormationData>();
                        }

                        if (list7.Count > 0)
                        {
                            // ISSUE: reference to a compiler-generated method
                            gclass17.int_4 += list7
                                .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                                .Where<MoveOrder>(
                                    gclass139_0 => gclass139_0.MoveActionType.MoveActionType == MoveActionType.LoadGroundUnitIntoTransportBay)
                                .Select<MoveOrder, IEnumerable<GroundUnitFormationData>>(class378.method_2)
                                .Count<IEnumerable<GroundUnitFormationData>>();
                        }

                        gclass17.int_0 = gclass17.int_3 + gclass17.int_4;
                        // ISSUE: reference to a compiler-generated method
                        GClass16 gclass16 = gclass16List.FirstOrDefault<GClass16>(class378.method_3);
                        if (gclass16 != null)
                        {
                            gclass17.int_5 = gclass16.int_2;
                            gclass17.int_1 = gclass16.int_0;
                        }

                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class378.class377_0.class376_0.gclass146_0.SystemBodyData.GroundMineralSurveyState !=
                            AuroraGroundMineralSurvey.Completed && class378.genum116_0 == AutomatedGroundTemplateDesignType.SurveyExpedition)
                            gclass17.int_1 = 1;
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
                        if (class378.class377_0.class376_0.gclass146_0.SystemBodyData.AbandonedFactories > 0 &&
                            class378.genum116_0 == AutomatedGroundTemplateDesignType.XenoarchaeologyExpedition &&
                            !class378.class377_0.class376_0.gclass146_0.Race.KnownRuinIDs.Contains(class378.class377_0
                                .class376_0.gclass146_0.SystemBodyData.RuinRaceData.RuinRaceID))
                            gclass17.int_1 = 1;
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
                        if (class378.class377_0.class376_0.gclass146_0.SystemBodyData.AbandonedFactories > 0 &&
                            class378.genum116_0 == AutomatedGroundTemplateDesignType.ConstructionRegiment &&
                            class378.class377_0.class376_0.gclass146_0.Race.KnownRuinIDs.Contains(class378.class377_0
                                .class376_0.gclass146_0.SystemBodyData.RuinRaceData.RuinRaceID))
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            gclass17.int_1 = class378.class377_0.class376_0.gclass146_0.SystemBodyData.AbandonedFactories >= 25
                                ? (int)Math.Floor(class378.class377_0.class376_0.gclass146_0.SystemBodyData.AbandonedFactories / 25.0)
                                : 1;
                        }

                        if (gclass17.int_1 > 0)
                        {
                            gclass17.int_2 = gclass17.int_1 - gclass17.int_0;
                            gclass17.int_6 = gclass17.int_3 - gclass17.int_1;
                            if (gclass17.int_2 < 0)
                                gclass17.int_2 = 0;
                            if (gclass17.int_6 < 0)
                                gclass17.int_6 = 0;
                        }
                        else
                            gclass17.int_6 = gclass17.int_3;

                        if (gclass17.int_6 > 0 || gclass17.int_2 > 0)
                            this.list_0.Add(gclass17);
                    }
                }
            }

            List<PopulationData> list8 = this.list_0.Where<GClass17>(gclass17_0 => gclass17_0.int_2 > 0)
                .Select<GClass17, PopulationData>(gclass17_0 => gclass17_0.gclass146_0)
                .OrderByDescending<PopulationData, bool>(gclass146_0 => gclass146_0.bIsInvasionStagingPoint)
                .ThenByDescending<PopulationData, GEnum97>(gclass146_0 => gclass146_0.gclass6_0.genum97_0)
                .ThenBy<PopulationData, int>(gclass146_0 => gclass146_0.PopulationID).ToList<PopulationData>();
            if (list8.Count == 0)
                return;
            List<PopulationData> list9 = this.list_0.Where<GClass17>(gclass17_0 => gclass17_0.int_6 > 0)
                .Select<GClass17, PopulationData>(gclass17_0 => gclass17_0.gclass146_0).Distinct<PopulationData>()
                .ToList<PopulationData>();
            List<GroundUnitFormationData> list10 = list2
                .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.ShipData.gclass85_0.MoveOrderDictionary.Count == 0)
                .ToList<GroundUnitFormationData>();
            if (list9.Count == 0 && list10.Count == 0)
                return;
            foreach (PopulationData gclass146_5 in list8)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class380 class380 = new UnknownNPRClass2.Class380();
                // ISSUE: reference to a compiler-generated field
                class380.class374_0 = class374;
                // ISSUE: reference to a compiler-generated field
                class380.gclass146_0 = gclass146_5;
                // ISSUE: reference to a compiler-generated method
                foreach (GClass17 gclass17 in this.list_0.Where<GClass17>(class380.method_0)
                             .OrderBy<GClass17, int>(gclass17_0 => gclass17_0.int_5).ToList<GClass17>())
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    UnknownNPRClass2.Class381 class381 = new UnknownNPRClass2.Class381();
                    // ISSUE: reference to a compiler-generated field
                    class381.class380_0 = class380;
                    // ISSUE: reference to a compiler-generated field
                    class381.gclass17_0 = gclass17;
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    foreach (FleetData gclass85 in list10.Where<GroundUnitFormationData>(class381.method_0)
                                 .Select<GroundUnitFormationData, FleetData>(gclass103_0 => gclass103_0.ShipData.gclass85_0)
                                 .Distinct<FleetData>().OrderBy<FleetData, int>(class381.method_1).ToList<FleetData>())
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        UnknownNPRClass2.Class382 class382 = new UnknownNPRClass2.Class382();
                        // ISSUE: reference to a compiler-generated field
                        class382.class381_0 = class381;
                        // ISSUE: reference to a compiler-generated field
                        class382.gclass85_0 = gclass85;
                        // ISSUE: reference to a compiler-generated method
                        int num7 = list10.Count<GroundUnitFormationData>(class382.method_0);
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class382.gclass85_0.System == class382.class381_0.class380_0.gclass146_0.gclass202_0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            this.method_30(class382.gclass85_0, class382.class381_0.gclass17_0);
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class382.class381_0.gclass17_0.int_2 -= num7;
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (class382.gclass85_0.Race.SpecialNPRID == SpecialNPRIDs.Eldar)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (class382.gclass85_0.System == gclass146_1.gclass202_0 &&
                                    class382.gclass85_0.LastMoveTime < this.gclass0_0.GameTime - AuroraUtils.decimal_32)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    GClass210 gclass210_0 =
                                        class382.class381_0.class380_0.gclass146_0.gclass202_0.ActualSystem.method_2() ??
                                        this.method_2(
                                            class382.class381_0.class380_0.gclass146_0.gclass202_0.ActualSystem);
                                    if (gclass210_0.double_2 == 0.0)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        class382.gclass85_0.method_64(gclass210_0, false);
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        this.method_30(class382.gclass85_0, class382.class381_0.gclass17_0);
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        class382.class381_0.gclass17_0.int_2 -= num7;
                                    }
                                }
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (class382.gclass85_0.method_237(class382.gclass85_0.System, GEnum109.const_41,
                                        "Move To " + class382.class381_0.gclass17_0.gclass146_0.gclass202_0.Name, false,
                                        class382.class381_0.gclass17_0.gclass146_0.gclass202_0.ActualSystem.SystemID,
                                        false, false, false).gclass202_0 != null)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    this.method_30(class382.gclass85_0, class382.class381_0.gclass17_0);
                                }
                            }
                        }
                    }

                    list10 = list10
                        .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.ShipData.gclass85_0.MoveOrderDictionary.Count == 0)
                        .ToList<GroundUnitFormationData>();
                    // ISSUE: reference to a compiler-generated field
                    if (class381.gclass17_0.int_2 >= 1)
                    {
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        List<GClass17> list11 = this.list_0.Where<GClass17>(class381.method_2)
                            .OrderBy<GClass17, int>(class381.method_3).ToList<GClass17>();
                        if (list11.Count != 0)
                        {
                            foreach (GClass17 gclass17_1 in list11)
                            {
                                bool flag2 = false;
                                int int_0 = gclass17_1.int_6;
                                // ISSUE: reference to a compiler-generated field
                                if (class381.gclass17_0.int_2 < int_0)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    int_0 = class381.gclass17_0.int_2;
                                }

                                foreach (FleetData gclass85_0 in list4)
                                {
                                    GClass201 gclass201 = new GClass201();
                                    if (gclass85_0.System == gclass17_1.gclass146_0.gclass202_0)
                                        gclass201.gclass202_0 = gclass85_0.System;
                                    else if (gclass85_0.Race.SpecialNPRID != SpecialNPRIDs.Eldar)
                                        gclass201 = gclass85_0.method_236(GEnum109.const_41,
                                            "Move To " + gclass17_1.gclass146_0.gclass202_0.Name, false,
                                            gclass17_1.gclass146_0.gclass202_0.ActualSystem.SystemID, false);
                                    if (gclass201.gclass202_0 != null)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        this.method_29(gclass85_0, class381.gclass17_0, gclass17_1, int_0, list_4);
                                    }

                                    if (gclass85_0.NPRSomething.bRedeployOrderGiven)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        if (class381.gclass17_0.gclass146_0.gclass202_0 == gclass201.gclass202_0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            this.method_30(gclass85_0, class381.gclass17_0);
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            if (gclass85_0.method_237(gclass201.gclass202_0, GEnum109.const_41,
                                                    "Move To " + class381.gclass17_0.gclass146_0.gclass202_0.Name,
                                                    false,
                                                    class381.gclass17_0.gclass146_0.gclass202_0.ActualSystem.SystemID,
                                                    false, false, false).gclass202_0 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                this.method_30(gclass85_0, class381.gclass17_0);
                                            }
                                            else
                                                gclass85_0.method_263();
                                        }
                                    }

                                    if (gclass85_0.NPRSomething.bRedeployOrderGiven)
                                    {
                                        flag2 = true;
                                        break;
                                    }
                                }

                                list4 = list4.Where<FleetData>(gclass85_0 =>
                                        !gclass85_0.NPRSomething.bRedeployOrderGiven && gclass85_0.MoveOrderDictionary.Count == 0)
                                    .ToList<FleetData>();
                                if (flag2)
                                    break;
                            }

                            list_5 = list_5.Where<FleetData>(gclass85_0 =>
                                !gclass85_0.NPRSomething.bRedeployOrderGiven && gclass85_0.MoveOrderDictionary.Count == 0).ToList<FleetData>();
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 24);
        }
    }

    public void method_28(
        AutomatedGroundTemplateDesignType genum116_0,
        int int_0,
        List<AutomatedGroundTemplateDesignType> list_3,
        List<GClass16> list_4)
    {
        try
        {
            if (int_0 == 0)
                return;
            GClass16 gclass16 = new GClass16(genum116_0, int_0);
            list_4.Add(gclass16);
            list_3.Add(genum116_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 25);
        }
    }

    public bool method_29(
        FleetData gclass85_0_1,
        GClass17 gclass17_0,
        GClass17 gclass17_1,
        int int_0,
        List<FleetData> list_3)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class383 class383 = new UnknownNPRClass2.Class383();
        // ISSUE: reference to a compiler-generated field
        class383.gclass17_0 = gclass17_0;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            UnknownNPRClass2.Class384 class384 = new UnknownNPRClass2.Class384();
            Decimal num = gclass85_0_1.method_143();
            GClass134 gclass134_0 = gclass85_0_1.method_274(gclass17_1.gclass146_0);
            MoveActionDefinition gclass133_0_1 = this.gclass0_0.MoveActionDictionary[MoveActionType.LoadGroundUnitIntoTransportBay];
            MoveActionDefinition gclass133_0_2 = this.gclass0_0.MoveActionDictionary[MoveActionType.RefuelFromColony];
            // ISSUE: reference to a compiler-generated field
            class384.list_0 = list_3.SelectMany<FleetData, MoveOrder>(gclass85_0_2 => gclass85_0_2.MoveOrderDictionary.Values)
                .Where<MoveOrder>(gclass139_0 => gclass139_0.MoveActionType.MoveActionType == MoveActionType.LoadGroundUnitIntoTransportBay)
                .ToList<MoveOrder>();
            // ISSUE: reference to a compiler-generated method
            List<GroundUnitFormationData> list1 = this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class384.method_0)
                .ToList<GroundUnitFormationData>();
            // ISSUE: reference to a compiler-generated method
            List<GroundUnitFormationData> list2 = gclass17_1.gclass146_0.gclass6_0.list_0.Where<GroundUnitFormationData>(class383.method_0)
                .Except<GroundUnitFormationData>(list1).OrderByDescending<GroundUnitFormationData, Decimal>(gclass103_0 => gclass103_0.method_34())
                .ToList<GroundUnitFormationData>();
            if (list2.Count == 0)
                return false;
            foreach (GroundUnitFormationData object_0 in list2)
            {
                if (object_0.decimal_0 <= num)
                {
                    gclass85_0_1.method_264(gclass134_0, gclass133_0_1, object_0, 0M, 0.0, 0, 0, 0, false,
                        CheckState.Checked);
                    gclass85_0_1.NPRSomething.bRedeployOrderGiven = true;
                    --int_0;
                    if (int_0 != 0)
                        num -= object_0.decimal_0;
                    else
                        break;
                }
            }

            gclass85_0_1.method_264(gclass134_0, gclass133_0_2, null, 0M, 0.0, 0, 0, 0, false, CheckState.Unchecked);
            return gclass85_0_1.NPRSomething.bRedeployOrderGiven;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 26);
            return false;
        }
    }

    public void method_30(FleetData gclass85_0, GClass17 gclass17_0)
    {
        try
        {
            Decimal num = gclass85_0.method_143();
            GClass134 gclass134_0 = gclass85_0.method_274(gclass17_0.gclass146_0);
            MoveActionDefinition gclass133_0_1 = this.gclass0_0.MoveActionDictionary[MoveActionType.OrbitalDropAllGroundUnits];
            MoveActionDefinition gclass133_0_2 = this.gclass0_0.MoveActionDictionary[MoveActionType.RefuelFromColony];
            gclass85_0.method_264(gclass134_0, gclass133_0_1, null, 0M, 0.0, 0, 0, 0, false, CheckState.Checked);
            gclass85_0.method_264(gclass134_0, gclass133_0_2, null, 0M, 0.0, 0, 0, 0, false, CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 27);
        }
    }

    public void method_31(List<FleetData> list_3, List<PopulationData> list_4, List<PopulationData> list_5)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            UnknownNPRClass2.Class385 class385 = new UnknownNPRClass2.Class385();
            // ISSUE: reference to a compiler-generated field
            class385.gclass2_0 = this;
            List<FleetData> list1 = list_3
                .Where<FleetData>(gclass85_0 =>
                    gclass85_0.NPRSomething.genum102_0 < GEnum102.const_2 && !gclass85_0.NPRSomething.bRedeployOrderGiven)
                .OrderBy<FleetData, GEnum102>(gclass85_0 => gclass85_0.NPRSomething.genum102_0).ToList<FleetData>();
            if (list1.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated field
            class385.list_0 = list_5.Select<PopulationData, SystemBodyData>(gclass146_0 => gclass146_0.SystemBodyData)
                .Distinct<SystemBodyData>().ToList<SystemBodyData>();
            List<FleetData> list2 = list1.Where<FleetData>(gclass85_0 =>
                gclass85_0.NPROperationGroup.OperationalGroupId == OperationalGroupID.MissileFighterSquadron ||
                gclass85_0.NPROperationGroup.OperationalGroupId == OperationalGroupID.BeamFighterSquadron).ToList<FleetData>();
            if (list2.Count > 0)
            {
                List<MissileSalvo> list3 = this.gclass0_0.MissileSalvoes.Values.Where<MissileSalvo>(gclass132_0 =>
                    gclass132_0.Race == this.gclass21_0 && gclass132_0.RaceMissile.MSPEngine > 0M &&
                    gclass132_0.Ship != null).ToList<MissileSalvo>();
                foreach (FleetData gclass85_0 in list2)
                    this.method_34(gclass85_0, list3);
                list1 = list1.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
            }

            // ISSUE: reference to a compiler-generated method
            List<GClass193> list4 = this.gclass0_0.dictionary_31.Values
                .Where<GClass193>(gclass193_0 =>
                    gclass193_0.gclass21_0 == this.gclass21_0 && gclass193_0.gclass146_0 != null).ToList<GClass193>()
                .Where<GClass193>(class385.method_0).ToList<GClass193>();
            if (list4.Count == 0)
                return;
            foreach (FleetData gclass85 in list1)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class386 class386 = new UnknownNPRClass2.Class386();
                // ISSUE: reference to a compiler-generated field
                class386.class385_0 = class385;
                // ISSUE: reference to a compiler-generated field
                class386.gclass85_0 = gclass85;
                // ISSUE: reference to a compiler-generated field
                List<ShipData> source = class386.gclass85_0.method_176();
                if (source.Count != 0)
                {
                    ShipData gclass40 = source
                        .Where<ShipData>(gclass40_0 => gclass40_0.gclass5_0.genum102_0 < GEnum102.const_3)
                        .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.gclass22_0.Size)
                        .FirstOrDefault<ShipData>();
                    if (gclass40 != null)
                    {
                        this.decimal_4 = gclass40.gclass22_0.Size;
                        this.auroraShipyardType_0 = AuroraShipyardType.Naval;
                        if (gclass40.gclass22_0.Commercial)
                            this.auroraShipyardType_0 = AuroraShipyardType.Commercial;
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        PopulationData gclass146_1 = list4.Where<GClass193>(class386.method_0)
                            .Select<GClass193, PopulationData>(gclass193_0 => gclass193_0.gclass146_0)
                            .OrderBy<PopulationData, double>(class386.method_1).FirstOrDefault<PopulationData>();
                        if (gclass146_1 != null)
                        {
                            // ISSUE: reference to a compiler-generated field
                            class386.gclass85_0.method_263();
                            // ISSUE: reference to a compiler-generated field
                            class386.gclass85_0.method_219(gclass146_1, MoveActionType.RefuelAndResupplyFromColony);
                            // ISSUE: reference to a compiler-generated field
                            class386.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                            break;
                        }

                        // ISSUE: reference to a compiler-generated field
                        GClass201 gclass201 =
                            class386.gclass85_0.method_235(GEnum109.const_45, "Move to Shipyard Colony", false);
                        if (gclass201.gclass146_0 == null)
                            break;
                        // ISSUE: reference to a compiler-generated field
                        class386.gclass85_0.method_219(gclass201.gclass146_0, MoveActionType.RefuelAndResupplyFromColony);
                        // ISSUE: reference to a compiler-generated field
                        class386.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 28);
        }
    }

    public void method_32(List<FleetData> list_3, List<PopulationData> list_4, List<PopulationData> list_5)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            UnknownNPRClass2.Class387 class387 = new UnknownNPRClass2.Class387();
            List<FleetData> list1 = list_3
                .Where<FleetData>(gclass85_0 =>
                    gclass85_0.NPRSomething.genum101_0 != GEnum101.const_3 && !gclass85_0.NPRSomething.bRedeployOrderGiven &&
                    gclass85_0.ShippingLine == null)
                .OrderBy<FleetData, GEnum101>(gclass85_0 => gclass85_0.NPRSomething.genum101_0).ToList<FleetData>();
            if (list1.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated field
            class387.list_0 = list_5.Select<PopulationData, SystemBodyData>(gclass146_0 => gclass146_0.SystemBodyData)
                .Distinct<SystemBodyData>().ToList<SystemBodyData>();
            List<FleetData> list2 = list1.Where<FleetData>(gclass85_0 =>
                gclass85_0.NPROperationGroup.OperationalGroupId == OperationalGroupID.MissileFighterSquadron ||
                gclass85_0.NPROperationGroup.OperationalGroupId == OperationalGroupID.BeamFighterSquadron).ToList<FleetData>();
            if (list2.Count > 0)
            {
                List<MissileSalvo> list3 = this.gclass0_0.MissileSalvoes.Values.Where<MissileSalvo>(gclass132_0 =>
                    gclass132_0.Race == this.gclass21_0 && gclass132_0.RaceMissile.MSPEngine > 0M &&
                    gclass132_0.Ship != null).ToList<MissileSalvo>();
                foreach (FleetData gclass85_0 in list2)
                    this.method_34(gclass85_0, list3);
                list1 = list1.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
            }

            // ISSUE: reference to a compiler-generated method
            List<PopulationData> list4 = list_4
                .Where<PopulationData>(gclass146_0 => gclass146_0.method_62(AuroraProductionCategory.RefuellingPoint) > 0M &&
                                                 gclass146_0.FuelStockpile > 0M).ToList<PopulationData>()
                .Where<PopulationData>(class387.method_0).ToList<PopulationData>();
            if (list4.Count == 0)
                return;
            foreach (PopulationData gclass146 in list4)
                gclass146.gclass6_0.decimal_0 = gclass146.FuelStockpile;
            using (List<FleetData>.Enumerator enumerator = list1.GetEnumerator())
            {
                if (!enumerator.MoveNext())
                    return;
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class389 class389 = new UnknownNPRClass2.Class389()
                {
                    class388_0 = new UnknownNPRClass2.Class388()
                    {
                        gclass85_0 = enumerator.Current
                    }
                };
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class389.decimal_0 = class389.class388_0.gclass85_0.method_140() -
                                     class389.class388_0.gclass85_0.method_154();
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                PopulationData gclass146_1 = list4.Where<PopulationData>(class389.method_0)
                    .OrderBy<PopulationData, double>(class389.class388_0.method_0).FirstOrDefault<PopulationData>();
                if (gclass146_1 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class389.class388_0.gclass85_0.method_263();
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class389.class388_0.gclass85_0.method_219(gclass146_1, MoveActionType.RefuelAndResupplyFromColony);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class389.class388_0.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                    // ISSUE: reference to a compiler-generated field
                    gclass146_1.gclass6_0.decimal_0 -= class389.decimal_0;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    this.gclass21_0.UnknownNprClass.decimal_0 = class389.decimal_0;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    GClass201 gclass201 =
                        class389.class388_0.gclass85_0.method_235(GEnum109.const_43, "Refuel from Colony", false);
                    if (gclass201.gclass146_0 == null)
                        return;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class389.class388_0.gclass85_0.method_219(gclass201.gclass146_0, MoveActionType.RefuelAndResupplyFromColony);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class389.class388_0.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                    // ISSUE: reference to a compiler-generated field
                    gclass201.gclass146_0.gclass6_0.decimal_0 -= class389.decimal_0;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 29);
        }
    }

    public void method_33(List<FleetData> list_3, MoveActionType genum123_0)
    {
        try
        {
            foreach (FleetData gclass85 in list_3)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class390 class390 = new UnknownNPRClass2.Class390();
                // ISSUE: reference to a compiler-generated field
                class390.gclass85_0 = gclass85;
                // ISSUE: reference to a compiler-generated method
                GClass210 gclass210_0 = this.gclass0_0.dictionary_16.Values.Where<GClass210>(class390.method_0)
                    .FirstOrDefault<GClass210>();
                if (gclass210_0.double_2 <= 0.0)
                {
                    // ISSUE: reference to a compiler-generated field
                    class390.gclass85_0.method_263();
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class390.gclass85_0.method_232(gclass210_0, genum123_0, class390.gclass85_0.System);
                    // ISSUE: reference to a compiler-generated field
                    class390.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3411);
        }
    }

    public void method_34(FleetData gclass85_0, List<MissileSalvo> list_3)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class391 class391 = new UnknownNPRClass2.Class391();
        // ISSUE: reference to a compiler-generated field
        class391.gclass85_0 = gclass85_0;
        // ISSUE: reference to a compiler-generated field
        class391.gclass2_0 = this;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            UnknownNPRClass2.Class392 class392 = new UnknownNPRClass2.Class392();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class392.list_0 = class391.gclass85_0.method_176();
            // ISSUE: reference to a compiler-generated field
            if (class392.list_0.Count == 0)
                return;
            MoveActionType genum123_0 = MoveActionType.LandOnAssignedMothership;
            // ISSUE: reference to a compiler-generated method
            if (list_3.FirstOrDefault<MissileSalvo>(class392.method_0) != null)
                genum123_0 = MoveActionType.MoveTo;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            List<ShipData> list1 = class392.list_0
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass40_1 != null)
                .Select<ShipData, ShipData>(gclass40_0 => gclass40_0.gclass40_1).Distinct<ShipData>()
                .Where<ShipData>(class391.method_0).ToList<ShipData>();
            int num1 = list1.Select<ShipData, FleetData>(gclass40_0 => gclass40_0.gclass85_0).Distinct<FleetData>()
                .Count<FleetData>();
            if (list1.Count != 1 && num1 != 1)
            {
                if (list1.Count > 1 && num1 > 1)
                {
                    foreach (ShipData gclass40_1 in list1)
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        UnknownNPRClass2.Class393 class393 = new UnknownNPRClass2.Class393();
                        // ISSUE: reference to a compiler-generated field
                        class393.gclass40_0 = gclass40_1;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        List<ShipData> list2 = class392.list_0.Where<ShipData>(class393.method_0)
                            .ToList<ShipData>();
                        if (list2.Count > 0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            FleetData gclass85_1 = this.gclass21_0.method_308(
                                class393.gclass40_0.ShipName + " Strikegroup",
                                class393.gclass40_0.gclass85_0.ParentNavalCommand, class391.gclass85_0.System,
                                class391.gclass85_0.XCoord, class391.gclass85_0.YCoord,
                                class391.gclass85_0.OrbitingBody, class391.gclass85_0.NPROperationGroup.OperationalGroupId);
                            foreach (ShipData gclass40_2 in list2)
                            {
                                if (gclass40_2.SquadronData != null)
                                {
                                    gclass40_2.LinkedSquadronID = gclass40_2.SquadronData.SquadronID;
                                    gclass40_2.SquadronData = null;
                                }

                                gclass40_2.gclass84_0 = null;
                                gclass40_2.method_185(gclass85_1, true, false, false, false);
                            }

                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class391.gclass85_0.method_222(class393.gclass40_0.gclass85_0, genum123_0);
                            // ISSUE: reference to a compiler-generated field
                            class391.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                        }
                    }
                }

                // ISSUE: reference to a compiler-generated field
                if (class392.list_0.Count == 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    this.gclass21_0.method_302(class391.gclass85_0, false);
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    foreach (ShipData gclass40 in class392.list_0)
                        gclass40.gclass40_1 = null;
                    // ISSUE: reference to a compiler-generated method
                    List<ShipData> list3 = this.gclass0_0.Ships.Values
                        .Where<ShipData>(class391.method_1).Where<ShipData>(gclass40_0 =>
                            gclass40_0.gclass22_0.MainFunction == AuroraClassMainFunction.Carrier)
                        .ToList<ShipData>();
                    // ISSUE: reference to a compiler-generated field
                    if (class391.gclass85_0.NPROperationGroup.OperationalGroupId == OperationalGroupID.BeamFighterSquadron)
                    {
                        list3 = list3.Where<ShipData>(gclass40_0 => gclass40_0.gclass22_0.MagazineCapacity == 0M)
                            .ToList<ShipData>();
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (class391.gclass85_0.NPROperationGroup.OperationalGroupId == OperationalGroupID.MissileFighterSquadron)
                            list3 = list3.Where<ShipData>(gclass40_0 => gclass40_0.gclass22_0.MagazineCapacity > 0M)
                                .ToList<ShipData>();
                    }

                    if (list3.Count == 0)
                        return;
                    // ISSUE: reference to a compiler-generated method
                    List<ShipData> list4 = list3.OrderBy<ShipData, double>(class391.method_2)
                        .ToList<ShipData>();
                    // ISSUE: reference to a compiler-generated field
                    class392.list_0.Sum<ShipData>(gclass40_0 => gclass40_0.gclass22_0.Size);
                    foreach (ShipData gclass40_3 in list4)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class392.list_0.OrderBy<ShipData, Decimal>(gclass40_0 => gclass40_0.gclass22_0.Size)
                            .ToList<ShipData>();
                        Decimal num2 = gclass40_3.method_126();
                        List<ShipData> gclass40List = new List<ShipData>();
                        // ISSUE: reference to a compiler-generated field
                        foreach (ShipData gclass40_4 in class392.list_0)
                        {
                            if (num2 >= gclass40_4.gclass22_0.Size)
                            {
                                gclass40List.Add(gclass40_4);
                                // ISSUE: reference to a compiler-generated field
                                class392.list_0.Remove(gclass40_4);
                                num2 -= gclass40_4.gclass22_0.Size;
                            }
                            else
                                break;
                        }

                        if (gclass40List.Count > 0)
                        {
                            FCTSquadronData70 gclass70_1 = new FCTSquadronData70(this.gclass0_0);
                            FCTSquadronData70 gclass70_2 = gclass40_3.ChildSquadronDictionary.Count <= 0
                                ? gclass40_3.method_186(gclass40_3.ShipName + " strikegroup")
                                : gclass40_3.ChildSquadronDictionary[0];
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            FleetData gclass85_1 = this.gclass21_0.method_308(gclass40_3.ShipName + " Strikegroup",
                                gclass40_3.gclass85_0.ParentNavalCommand, class391.gclass85_0.System,
                                class391.gclass85_0.XCoord, class391.gclass85_0.YCoord,
                                class391.gclass85_0.OrbitingBody, class391.gclass85_0.NPROperationGroup.OperationalGroupId);
                            foreach (ShipData gclass40_5 in gclass40List)
                            {
                                gclass40_5.LinkedSquadronID = gclass70_2.SquadronID;
                                gclass40_5.SquadronData = null;
                                gclass40_5.gclass84_0 = null;
                                gclass40_5.method_185(gclass85_1, true, false, false, false);
                            }

                            gclass85_1.method_222(gclass40_3.gclass85_0, genum123_0);
                            gclass85_1.NPRSomething.bRedeployOrderGiven = true;
                        }
                    }
                }
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                class391.gclass85_0.method_263();
                // ISSUE: reference to a compiler-generated field
                class391.gclass85_0.method_222(list1[0].gclass85_0, genum123_0);
                // ISSUE: reference to a compiler-generated field
                class391.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3858);
        }
    }

    public void method_35(
        List<FleetData> list_3,
        List<PopulationData> list_4,
        List<PopulationData> list_5,
        bool bool_0)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            UnknownNPRClass2.Class394 class394 = new UnknownNPRClass2.Class394();
            List<FleetData> list1 = list_3
                .Where<FleetData>(gclass85_0 =>
                    gclass85_0.NPRSomething.genum103_0 < GEnum103.const_3 && !gclass85_0.NPRSomething.bRedeployOrderGiven)
                .OrderBy<FleetData, GEnum103>(gclass85_0 => gclass85_0.NPRSomething.genum103_0).ToList<FleetData>();
            if (list1.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated field
            class394.list_0 = list_5.Select<PopulationData, SystemBodyData>(gclass146_0 => gclass146_0.SystemBodyData)
                .Distinct<SystemBodyData>().ToList<SystemBodyData>();
            if (this.gclass21_0.SpecialNPRID == SpecialNPRIDs.Eldar)
            {
                this.method_33(list1, MoveActionType.StandardTransit);
            }
            else
            {
                List<FleetData> list2 = list1
                    .Where<FleetData>(gclass85_0 => gclass85_0.NPROperationGroup.OperationalGroupId == OperationalGroupID.MissileFighterSquadron)
                    .ToList<FleetData>();
                if (list2.Count > 0)
                {
                    List<MissileSalvo> list3 = this.gclass0_0.MissileSalvoes.Values.Where<MissileSalvo>(gclass132_0 =>
                        gclass132_0.Race == this.gclass21_0 && gclass132_0.RaceMissile.MSPEngine > 0M &&
                        gclass132_0.Ship != null).ToList<MissileSalvo>();
                    foreach (FleetData gclass85_0 in list2)
                        this.method_34(gclass85_0, list3);
                    list1 = list1.Where<FleetData>(gclass85_0 => !gclass85_0.NPRSomething.bRedeployOrderGiven).ToList<FleetData>();
                }

                // ISSUE: reference to a compiler-generated method
                List<PopulationData> list4 = list_4
                    .Where<PopulationData>(gclass146_0 =>
                        gclass146_0.method_62(AuroraProductionCategory.OrdnanceTransferPoint) > 0M &&
                        gclass146_0.OrdnanceStocks.Count > 0).ToList<PopulationData>().Where<PopulationData>(class394.method_0)
                    .ToList<PopulationData>();
                if (list4.Count == 0)
                    return;
                foreach (PopulationData gclass146 in list4)
                {
                    gclass146.gclass6_0.dictionary_0.Clear();
                    foreach (PopOrdnanceStock gclass130_1 in gclass146.OrdnanceStocks)
                    {
                        PopOrdnanceStock gclass130_2 = gclass130_1.method_0();
                        gclass146.gclass6_0.dictionary_0.Add(gclass130_2.RaceMissile, gclass130_2);
                    }
                }

                foreach (FleetData gclass85 in list1)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    UnknownNPRClass2.Class395 class395 = new UnknownNPRClass2.Class395();
                    // ISSUE: reference to a compiler-generated field
                    class395.gclass85_0 = gclass85;
                    List<PopOrdnanceStock> source1 = new List<PopOrdnanceStock>();
                    // ISSUE: reference to a compiler-generated field
                    List<ShipData> source2 = class395.gclass85_0.method_176();
                    // ISSUE: reference to a compiler-generated method
                    foreach (RaceMissile gclass129 in source2.Where<ShipData>(class395.method_0)
                                 .SelectMany<ShipData, PopOrdnanceStock>(gclass40_0 => gclass40_0.gclass22_0.list_0)
                                 .Select<PopOrdnanceStock, RaceMissile>(gclass130_0 => gclass130_0.RaceMissile)
                                 .Distinct<RaceMissile>().ToList<RaceMissile>())
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        UnknownNPRClass2.Class396 class396 = new UnknownNPRClass2.Class396();
                        // ISSUE: reference to a compiler-generated field
                        class396.gclass129_0 = gclass129;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        source1.Add(new PopOrdnanceStock()
                        {
                            RaceMissile = class396.gclass129_0,
                            Amount = source2
                                        .Where<ShipData>(class395.func_0 ?? (class395.func_0 = class395.method_1))
                                        .SelectMany<ShipData, PopOrdnanceStock>(
                                            gclass40_0 => gclass40_0.gclass22_0.list_0)
                                        .Where<PopOrdnanceStock>(class396.method_0)
                                        .Sum<PopOrdnanceStock>(gclass130_0 => gclass130_0.Amount) -
                                    source2.Where<ShipData>(class395.func_1 ??
                                                                 (class395.func_1 = class395.method_2))
                                        .SelectMany<ShipData, PopOrdnanceStock>(gclass40_0 => gclass40_0.list_10)
                                        .Where<PopOrdnanceStock>(class396.method_1)
                                        .Sum<PopOrdnanceStock>(gclass130_0 => gclass130_0.Amount)
                        });
                    }

                    List<PopOrdnanceStock> list5 = source1.Where<PopOrdnanceStock>(gclass130_0 => gclass130_0.Amount > 0)
                        .OrderByDescending<PopOrdnanceStock, int>(gclass130_0 => gclass130_0.Amount).ToList<PopOrdnanceStock>();
                    if (list5.Count != 0)
                    {
                        foreach (PopOrdnanceStock gclass130 in list5)
                        {
                            // ISSUE: object of a compiler-generated type is created
                            // ISSUE: variable of a compiler-generated type
                            UnknownNPRClass2.Class397 class397 = new UnknownNPRClass2.Class397();
                            // ISSUE: reference to a compiler-generated field
                            class397.class395_0 = class395;
                            // ISSUE: reference to a compiler-generated field
                            class397.gclass130_0 = gclass130;
                            PopulationData gclass146_1;
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (class397.class395_0.gclass85_0.NPROperationGroup.OperationalGroupId != OperationalGroupID.OribitalMissileBase &&
                                class397.class395_0.gclass85_0.NPROperationGroup.OperationalGroupId != OperationalGroupID.OrbitalDefences)
                            {
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                gclass146_1 = list4.Where<PopulationData>(class397.method_1)
                                    .Where<PopulationData>(class397.method_2)
                                    .OrderByDescending<PopulationData, int>(class397.method_3).FirstOrDefault<PopulationData>();
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated method
                                gclass146_1 = list4.FirstOrDefault<PopulationData>(class397.method_0);
                                if (gclass146_1 == null)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    class397.class395_0.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                                }
                            }

                            if (gclass146_1 == null)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (!class397.class395_0.gclass85_0.NPRSomething.bRedeployOrderGiven)
                                {
                                    if (!bool_0)
                                    {
                                        this.gclass21_0.UnknownNprClass.list_1 = list5;
                                        this.gclass21_0.UnknownNprClass.list_2 = list4;
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        GClass201 gclass201 =
                                            class397.class395_0.gclass85_0.method_235(GEnum109.const_44,
                                                "Reload from Colony", false);
                                        if (gclass201.gclass146_0 != null)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class397.class395_0.gclass85_0.method_219(gclass201.gclass146_0,
                                                MoveActionType.LoadOrdnanceFromColony);
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class397.class395_0.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                                            gclass201.gclass146_0.gclass6_0.method_5(list5);
                                            break;
                                        }

                                        break;
                                    }
                                }
                                else
                                    break;
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class397.class395_0.gclass85_0.method_263();
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class397.class395_0.gclass85_0.method_219(gclass146_1, MoveActionType.LoadOrdnanceFromColony);
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class397.class395_0.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                                gclass146_1.gclass6_0.method_5(list5);
                                break;
                            }
                        }
                    }
                }

                List<FleetData> list6 = list_3.Where<FleetData>(gclass85_0 =>
                        gclass85_0.NPRSomething.genum103_0 == GEnum103.const_0 && !gclass85_0.NPRSomething.bRedeployOrderGiven)
                    .ToList<FleetData>();
                if (list6.Count == 0)
                    return;
                foreach (FleetData gclass85 in list6)
                {
                    foreach (ShipData gclass40_0 in gclass85.method_176())
                    {
                        if (gclass40_0.gclass5_0.genum103_0 == GEnum103.const_0)
                            gclass85.method_75(gclass40_0, OperationalGroupID.RammingForce, true);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 30);
        }
    }

    public void method_36(List<FleetData> list_3)
    {
        try
        {
            List<RacialSystemSurvey> list1 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_5)
                .OrderBy<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.ActualSystem.SystemID).ToList<RacialSystemSurvey>();
            List<RacialSystemSurvey> list2 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 != GEnum95.const_5)
                .OrderBy<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.ActualSystem.SystemID).ToList<RacialSystemSurvey>();
            List<RacialSystemSurvey> list3 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_4)
                .OrderBy<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.ActualSystem.SystemID).ToList<RacialSystemSurvey>();
            List<RacialSystemSurvey> list4 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 != GEnum95.const_4)
                .OrderBy<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.ActualSystem.SystemID).ToList<RacialSystemSurvey>();
            List<RacialSystemSurvey> list5 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_3)
                .OrderBy<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.ActualSystem.SystemID).ToList<RacialSystemSurvey>();
            List<RacialSystemSurvey> list6 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 != GEnum95.const_3)
                .OrderBy<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.ActualSystem.SystemID).ToList<RacialSystemSurvey>();
            if (list1.Count > 0)
            {
                this.method_43(list1, list2, list_3, GEnum104.const_22, GEnum100.const_2);
                this.method_43(list1, list2, list_3, GEnum104.const_1, GEnum100.const_2);
                this.method_43(list1, list2, list_3, GEnum104.const_21, GEnum100.const_2);
                this.method_43(list1, list2, list_3, GEnum104.const_23, GEnum100.const_2);
            }

            if (list3.Count > 0)
            {
                this.method_43(list3, list4, list_3, GEnum104.const_22, GEnum100.const_2);
                this.method_43(list3, list4, list_3, GEnum104.const_1, GEnum100.const_2);
                this.method_43(list3, list4, list_3, GEnum104.const_21, GEnum100.const_2);
                this.method_43(list3, list4, list_3, GEnum104.const_23, GEnum100.const_2);
            }

            if (list5.Count <= 0)
                return;
            this.method_43(list5, list6, list_3, GEnum104.const_23, GEnum100.const_2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 31 /*0x1F*/);
        }
    }

    public void method_37(List<FleetData> list_3)
    {
        try
        {
            List<RacialSystemSurvey> list1 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_6)
                .ToList<RacialSystemSurvey>();
            List<RacialSystemSurvey> list2 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 != GEnum95.const_6)
                .OrderBy<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.ActualSystem.SystemID).ToList<RacialSystemSurvey>();
            List<RacialSystemSurvey> list3 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_5)
                .OrderBy<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.ActualSystem.SystemID).ToList<RacialSystemSurvey>();
            List<RacialSystemSurvey> list4 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 != GEnum95.const_5)
                .OrderBy<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.ActualSystem.SystemID).ToList<RacialSystemSurvey>();
            List<RacialSystemSurvey> list5 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_4)
                .OrderBy<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.ActualSystem.SystemID).ToList<RacialSystemSurvey>();
            List<RacialSystemSurvey> list6 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 != GEnum95.const_4)
                .OrderBy<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.ActualSystem.SystemID).ToList<RacialSystemSurvey>();
            List<RacialSystemSurvey> list7 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_3)
                .OrderBy<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.ActualSystem.SystemID).ToList<RacialSystemSurvey>();
            List<RacialSystemSurvey> list8 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 != GEnum95.const_3)
                .OrderBy<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.ActualSystem.SystemID).ToList<RacialSystemSurvey>();
            this.method_43(list1, list2, list_3, GEnum104.const_1, GEnum100.const_2);
            this.method_43(list1, list2, list_3, GEnum104.const_6, GEnum100.const_2);
            this.method_43(list1, list2, list_3, GEnum104.const_28, GEnum100.const_2);
            if (list3.Count > 0)
            {
                this.method_43(list3, list4, list_3, GEnum104.const_1, GEnum100.const_2);
                this.method_43(list3, list4, list_3, GEnum104.const_6, GEnum100.const_2);
                this.method_43(list1, list2, list_3, GEnum104.const_28, GEnum100.const_2);
            }

            if (list5.Count > 0)
            {
                this.method_43(list5, list6, list_3, GEnum104.const_1, GEnum100.const_2);
                this.method_43(list5, list6, list_3, GEnum104.const_6, GEnum100.const_2);
                this.method_43(list1, list2, list_3, GEnum104.const_28, GEnum100.const_2);
            }

            if (list7.Count <= 0)
                return;
            this.method_43(list7, list8, list_3, GEnum104.const_6, GEnum100.const_2);
            this.method_43(list1, list2, list_3, GEnum104.const_28, GEnum100.const_2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 32 /*0x20*/);
        }
    }

    public void method_38(List<FleetData> list_3)
    {
        try
        {
            List<RacialSystemSurvey> list1 = this.gclass0_0.Waypoints.Values
                .Where<Waypoint>(gclass214_0 =>
                    gclass214_0.WaypointType == WayPointType.UrgentPOI && gclass214_0.Race == this.gclass21_0)
                .Select<Waypoint, RacialSystemSurvey>(gclass214_0 => gclass21_0.method_128(gclass214_0.System))
                .Distinct<RacialSystemSurvey>()
                .OrderByDescending<RacialSystemSurvey, GEnum95>(gclass202_0 => gclass202_0.gclass3_0.genum95_0)
                .ThenBy<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.ActualSystem.SystemID).ToList<RacialSystemSurvey>();
            if (list1.Count > 0)
            {
                List<RacialSystemSurvey> list2 = this.gclass21_0.RacialSystemDictionary.Values.Except<RacialSystemSurvey>(list1)
                    .ToList<RacialSystemSurvey>();
                this.method_43(list1, list2, list_3, GEnum104.const_5, GEnum100.const_2);
            }

            List<RacialSystemSurvey> list3 = this.gclass0_0.Waypoints.Values
                .Where<Waypoint>(gclass214_0 =>
                    gclass214_0.WaypointType == WayPointType.POI && gclass214_0.Race == this.gclass21_0)
                .Select<Waypoint, RacialSystemSurvey>(gclass214_0 => gclass21_0.method_128(gclass214_0.System))
                .Distinct<RacialSystemSurvey>()
                .OrderByDescending<RacialSystemSurvey, GEnum95>(gclass202_0 => gclass202_0.gclass3_0.genum95_0)
                .ThenBy<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.ActualSystem.SystemID).ToList<RacialSystemSurvey>();
            if (list3.Count <= 0)
                return;
            List<RacialSystemSurvey> list4 = this.gclass21_0.RacialSystemDictionary.Values.Except<RacialSystemSurvey>(list3).ToList<RacialSystemSurvey>();
            this.method_43(list3, list4, list_3, GEnum104.const_5, GEnum100.const_2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 33);
        }
    }

    public void method_39(List<FleetData> list_3)
    {
        try
        {
            List<FleetData> list1 = list_3
                .Where<FleetData>(gclass85_0 => gclass85_0.NPROperationGroup.OperationalGroupId == OperationalGroupID.DiplomaticShip).ToList<FleetData>();
            if (list1.Count == 0)
                return;
            List<RacialSystemSurvey> list2 = this.gclass0_0.Contacts.Values
                .Where<Contact>(gclass65_0 =>
                    gclass65_0.DetectRace == this.gclass21_0 &&
                    this.gclass0_0.GameTime - gclass65_0.LastUpdate < AuroraUtils.decimal_32)
                .Where<Contact>(gclass65_0 => gclass65_0.method_5() != 0)
                .Where<Contact>(gclass65_0 => gclass65_0.method_6() != AuroraCommStatus.CommunicationImpossible)
                .Select<Contact, StarSystem>(gclass65_0 => gclass65_0.System).Distinct<StarSystem>()
                .Select<StarSystem, RacialSystemSurvey>(gclass200_0 => gclass21_0.method_128(gclass200_0))
                .OrderByDescending<RacialSystemSurvey, GEnum95>(gclass202_0 => gclass202_0.gclass3_0.genum95_0)
                .ToList<RacialSystemSurvey>();
            if (list2.Count == 0)
                return;
            List<RacialSystemSurvey> list3 = this.gclass21_0.RacialSystemDictionary.Values.Except<RacialSystemSurvey>(list2).ToList<RacialSystemSurvey>();
            this.method_43(list2, list3, list1, GEnum104.const_25, GEnum100.const_2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 34);
        }
    }

    public void method_40(List<FleetData> list_3)
    {
        try
        {
            List<RacialSystemSurvey> list1 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => !gclass202_0.bSurveyComplete && gclass202_0.gclass3_0.genum95_0 != 0)
                .OrderByDescending<RacialSystemSurvey, GEnum95>(gclass202_0 => gclass202_0.gclass3_0.genum95_0)
                .ToList<RacialSystemSurvey>();
            if (list1.Count <= 0)
                return;
            List<RacialSystemSurvey> list2 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.bSurveyComplete || gclass202_0.gclass3_0.genum95_0 != 0)
                .ToList<RacialSystemSurvey>();
            this.method_44(list1, list2, list_3, GEnum104.const_3, GEnum100.const_2, 2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 35);
        }
    }

    public void method_41(List<FleetData> list_3)
    {
        try
        {
            List<RacialSystemSurvey> list1 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => !gclass202_0.bGeoSurveyDefaultDone && gclass202_0.gclass3_0.genum95_0 != 0)
                .OrderByDescending<RacialSystemSurvey, GEnum95>(gclass202_0 => gclass202_0.gclass3_0.genum95_0)
                .ToList<RacialSystemSurvey>();
            if (list1.Count <= 0)
                return;
            List<RacialSystemSurvey> list2 = this.gclass21_0.RacialSystemDictionary.Values
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.bGeoSurveyDefaultDone || gclass202_0.gclass3_0.genum95_0 != 0)
                .ToList<RacialSystemSurvey>();
            this.method_44(list1, list2, list_3, GEnum104.const_2, GEnum100.const_2, 2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 36);
        }
    }

    public void method_42(List<FleetData> list_3, GEnum104 genum104_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class398 class398 = new UnknownNPRClass2.Class398();
        // ISSUE: reference to a compiler-generated field
        class398.gclass2_0 = this;
        // ISSUE: reference to a compiler-generated field
        class398.genum104_0 = genum104_0;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            UnknownNPRClass2.Class399 class399 = new UnknownNPRClass2.Class399();
            // ISSUE: reference to a compiler-generated field
            class399.class398_0 = class398;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            List<JumpPoint> list1 = this.gclass0_0.JumpPointDictionary.Values
                .Where<JumpPoint>(class399.class398_0.method_0).ToList<JumpPoint>();
            if (list1.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            class399.list_0 = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(class399.class398_0.method_1)
                .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                .Where<MoveOrder>(gclass139_0 => gclass139_0.MoveActionType.MoveActionType == MoveActionType.StandardTransit)
                .Select<MoveOrder, int>(gclass139_0 => gclass139_0.DestinationID).ToList<int>();
            // ISSUE: reference to a compiler-generated method
            List<JumpPoint> list2 = list1.Where<JumpPoint>(class399.method_0).ToList<JumpPoint>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            List<RacialSystemSurvey> list3 = list2.Select<JumpPoint, RacialSystemSurvey>(class399.class398_0.method_2)
                .Distinct<RacialSystemSurvey>()
                .OrderByDescending<RacialSystemSurvey, GEnum95>(gclass202_0 => gclass202_0.gclass3_0.genum95_0)
                .ToList<RacialSystemSurvey>();
            // ISSUE: reference to a compiler-generated field
            class399.list_1 = this.gclass21_0.RacialSystemDictionary.Values.Except<RacialSystemSurvey>(list3).ToList<RacialSystemSurvey>();
            foreach (RacialSystemSurvey gclass202 in list3)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class400 class400 = new UnknownNPRClass2.Class400();
                // ISSUE: reference to a compiler-generated field
                class400.class399_0 = class399;
                // ISSUE: reference to a compiler-generated field
                class400.gclass202_0 = gclass202;
                // ISSUE: reference to a compiler-generated method
                foreach (JumpPoint gclass120 in list2.Where<JumpPoint>(class400.method_0).ToList<JumpPoint>())
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    UnknownNPRClass2.Class401 class401 = new UnknownNPRClass2.Class401();
                    // ISSUE: reference to a compiler-generated field
                    class401.gclass120_0 = gclass120;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    FleetData gclass85_1 = list_3
                        .Where<FleetData>(class400.func_0 ?? (class400.func_0 = class400.method_1))
                        .FirstOrDefault<FleetData>(class401.method_0);
                    if (gclass85_1 != null)
                    {
                        gclass85_1.method_263();
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        gclass85_1.method_231(class401.gclass120_0, MoveActionType.StandardTransit, class400.gclass202_0);
                        gclass85_1.NPRSomething.bRedeployOrderGiven = true;
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        foreach (FleetData gclass85_2 in list_3
                                     .Where<FleetData>(class400.class399_0.func_0 ??
                                                      (class400.class399_0.func_0 = class400.class399_0.method_1))
                                     .Where<FleetData>(class401.method_1)
                                     .OrderBy<FleetData, int>(class400.func_1 ?? (class400.func_1 = class400.method_2))
                                     .ToList<FleetData>())
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (gclass85_2.method_236(GEnum109.const_41, "Move To " + class400.gclass202_0.Name, false,
                                    class400.gclass202_0.ActualSystem.SystemID, false).gclass202_0 != null)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                gclass85_2.method_231(class401.gclass120_0, MoveActionType.StandardTransit, class400.gclass202_0);
                                gclass85_2.NPRSomething.bRedeployOrderGiven = true;
                                break;
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 37);
        }
    }

    public void method_43(
        List<RacialSystemSurvey> list_3,
        List<RacialSystemSurvey> list_4,
        List<FleetData> list_5,
        GEnum104 genum104_0,
        GEnum100 genum100_0)
    {
        try
        {
            this.method_44(list_3, list_4, list_5, genum104_0, genum100_0, 1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 38);
        }
    }

    public void method_44(
        List<RacialSystemSurvey> list_3,
        List<RacialSystemSurvey> list_4,
        List<FleetData> list_5,
        GEnum104 genum104_0,
        GEnum100 genum100_0,
        int int_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class402 class402 = new UnknownNPRClass2.Class402();
        // ISSUE: reference to a compiler-generated field
        class402.genum104_0 = genum104_0;
        // ISSUE: reference to a compiler-generated field
        class402.genum100_0 = genum100_0;
        // ISSUE: reference to a compiler-generated field
        class402.list_0 = list_4;
        // ISSUE: reference to a compiler-generated field
        class402.gclass2_0 = this;
        try
        {
            foreach (RacialSystemSurvey gclass202 in list_3)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class403 class403 = new UnknownNPRClass2.Class403()
                {
                    class402_0 = class402,
                    gclass202_0 = gclass202
                };
                // ISSUE: reference to a compiler-generated field
                class403.gclass202_0.gclass3_0.int_2 = int_0;
                // ISSUE: reference to a compiler-generated method
                int num = list_5.Count<FleetData>(class403.method_0);
                // ISSUE: reference to a compiler-generated field
                class403.gclass202_0.gclass3_0.int_2 -= num;
                // ISSUE: reference to a compiler-generated field
                if (class403.gclass202_0.gclass3_0.int_2 > 0)
                {
                    // ISSUE: reference to a compiler-generated method
                    List<FleetData> list = list_5.Where<FleetData>(class403.method_1)
                        .OrderByDescending<FleetData, GEnum100>(gclass85_0 => gclass85_0.NPRSomething.genum100_0)
                        .ThenByDescending<FleetData, int>(gclass85_0 => gclass85_0.NPROperationGroup.int_0).ToList<FleetData>();
                    // ISSUE: reference to a compiler-generated field
                    if (list.Count >= class403.gclass202_0.gclass3_0.int_2)
                    {
                        foreach (FleetData gclass85 in list)
                        {
                            gclass85.NPRSomething.bool_2 = true;
                            gclass85.NPRSomething.method_6();
                            // ISSUE: reference to a compiler-generated field
                            --class403.gclass202_0.gclass3_0.int_2;
                            // ISSUE: reference to a compiler-generated field
                            if (class403.gclass202_0.gclass3_0.int_2 == 0)
                                break;
                        }

                        // ISSUE: reference to a compiler-generated field
                        if (class403.gclass202_0.gclass3_0.int_2 == 0)
                            continue;
                    }

                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    foreach (FleetData gclass85 in list_5
                                 .Where<FleetData>(class403.class402_0.func_0 ??
                                                  (class403.class402_0.func_0 = class403.class402_0.method_0))
                                 .OrderBy<FleetData, int>(class403.method_2)
                                 .ThenByDescending<FleetData, GEnum100>(gclass85_0 => gclass85_0.NPRSomething.genum100_0)
                                 .ThenByDescending<FleetData, int>(gclass85_0 => gclass85_0.NPROperationGroup.int_0)
                                 .ToList<FleetData>())
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (gclass85.method_236(GEnum109.const_41, "Move To " + class403.gclass202_0.Name, false,
                                class403.gclass202_0.ActualSystem.SystemID, false).gclass202_0 != null)
                        {
                            gclass85.NPRSomething.bRedeployOrderGiven = true;
                            gclass85.NPRSomething.method_6();
                            // ISSUE: reference to a compiler-generated field
                            gclass85.NPRSomething.gclass202_0 = class403.gclass202_0;
                            // ISSUE: reference to a compiler-generated field
                            --class403.gclass202_0.gclass3_0.int_2;
                            // ISSUE: reference to a compiler-generated field
                            if (class403.gclass202_0.gclass3_0.int_2 == 0)
                                break;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 39);
        }
    }

    public bool method_45(RacialSystemSurvey gclass202_0, Decimal decimal_5, List<FleetData> list_3)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class404 class404 = new UnknownNPRClass2.Class404();
        // ISSUE: reference to a compiler-generated field
        class404.gclass202_0 = gclass202_0;
        // ISSUE: reference to a compiler-generated field
        class404.decimal_0 = decimal_5;
        // ISSUE: reference to a compiler-generated field
        class404.gclass2_0 = this;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (list_3.Where<FleetData>(class404.method_0).FirstOrDefault<FleetData>(class404.method_1) != null)
                return true;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            foreach (FleetData gclass85 in list_3.Where<FleetData>(class404.method_2).Where<FleetData>(class404.method_3)
                         .OrderBy<FleetData, int>(class404.method_4)
                         .ThenBy<FleetData, Decimal>(gclass85_0 => gclass85_0.method_13()).ToList<FleetData>())
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (gclass85.method_236(GEnum109.const_41, "Move To " + class404.gclass202_0.Name, false,
                        class404.gclass202_0.ActualSystem.SystemID, false).gclass202_0 != null)
                {
                    gclass85.NPRSomething.bRedeployOrderGiven = true;
                    gclass85.NPRSomething.method_6();
                    // ISSUE: reference to a compiler-generated field
                    gclass85.NPRSomething.gclass202_0 = class404.gclass202_0;
                    return true;
                }
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 40);
            return false;
        }
    }

    public void method_46(
        List<RacialSystemSurvey> list_3,
        List<RacialSystemSurvey> list_4,
        List<RacialSystemSurvey> list_5,
        List<FleetData> list_6,
        GEnum104 genum104_0,
        bool bool_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class405 class405 = new UnknownNPRClass2.Class405();
        // ISSUE: reference to a compiler-generated field
        class405.genum104_0 = genum104_0;
        // ISSUE: reference to a compiler-generated field
        class405.list_0 = list_5;
        // ISSUE: reference to a compiler-generated field
        class405.gclass2_0 = this;
        try
        {
            foreach (RacialSystemSurvey gclass202 in list_3)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class406 class406 = new UnknownNPRClass2.Class406();
                // ISSUE: reference to a compiler-generated field
                class406.class405_0 = class405;
                // ISSUE: reference to a compiler-generated field
                class406.gclass202_0 = gclass202;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                List<JumpPoint> source = bool_0
                    ? this.gclass0_0.Waypoints.Values.Where<Waypoint>(class406.method_1)
                        .Select<Waypoint, JumpPoint>(gclass214_0 => gclass214_0.JumpPoint).ToList<JumpPoint>()
                    : class406.gclass202_0.method_37(true).Intersect<RacialSystemSurvey>(list_4)
                        .OrderByDescending<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.gclass3_0.int_0)
                        .Select<RacialSystemSurvey, JumpPoint>(class406.method_0).ToList<JumpPoint>();
                if (source.Count == 0)
                    break;
                foreach (JumpPoint gclass120 in source)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    UnknownNPRClass2.Class407 class407 = new UnknownNPRClass2.Class407()
                    {
                        class406_0 = class406,
                        gclass120_0 = gclass120
                    };
                    // ISSUE: reference to a compiler-generated field
                    class407.gclass120_0.bool_0 = false;
                    // ISSUE: reference to a compiler-generated method
                    FleetData gclass85 = list_6.FirstOrDefault<FleetData>(class407.method_0);
                    if (gclass85 != null)
                    {
                        gclass85.NPRSomething.bRedeployOrderGiven = true;
                        // ISSUE: reference to a compiler-generated field
                        class407.gclass120_0.bool_0 = true;
                    }
                }

                List<JumpPoint> list1 = source.Where<JumpPoint>(gclass120_0 => !gclass120_0.bool_0)
                    .ToList<JumpPoint>();
                if (list1.Count == 0)
                    break;
                foreach (JumpPoint gclass120 in list1)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    UnknownNPRClass2.Class408 class408 = new UnknownNPRClass2.Class408();
                    // ISSUE: reference to a compiler-generated field
                    class408.gclass120_0 = gclass120;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (list_6
                            .Where<FleetData>(class406.class405_0.func_0 ??
                                             (class406.class405_0.func_0 = class406.class405_0.method_0))
                            .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                            .FirstOrDefault<MoveOrder>(class408.method_0) != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class408.gclass120_0.bool_0 = true;
                    }
                }

                List<JumpPoint> list2 = list1.Where<JumpPoint>(gclass120_0 => !gclass120_0.bool_0)
                    .ToList<JumpPoint>();
                if (list2.Count == 0)
                    break;
                foreach (JumpPoint gclass120_1 in list2)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    FleetData gclass85_1 =
                        list_6.FirstOrDefault<FleetData>(class406.func_0 ?? (class406.func_0 = class406.method_2));
                    if (gclass85_1 != null)
                    {
                        gclass85_1.method_263();
                        // ISSUE: reference to a compiler-generated field
                        gclass85_1.method_231(gclass120_1, MoveActionType.MoveTo, class406.gclass202_0);
                        gclass85_1.NPRSomething.bRedeployOrderGiven = true;
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        foreach (FleetData gclass85_2 in list_6
                                     .Where<FleetData>(class406.class405_0.func_1 ??
                                                      (class406.class405_0.func_1 = class406.class405_0.method_1))
                                     .OrderBy<FleetData, int>(class406.func_1 ?? (class406.func_1 = class406.method_3))
                                     .ToList<FleetData>())
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (gclass85_2.method_236(GEnum109.const_41, "Move To " + class406.gclass202_0.Name, false,
                                    class406.gclass202_0.ActualSystem.SystemID, false).gclass202_0 != null)
                            {
                                // ISSUE: reference to a compiler-generated field
                                gclass85_2.method_231(gclass120_1, MoveActionType.MoveTo, class406.gclass202_0);
                                gclass85_2.NPRSomething.bRedeployOrderGiven = true;
                                break;
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 41);
        }
    }

    public void method_47(
        RacialSystemSurvey gclass202_0_1,
        List<RacialSystemSurvey> list_3,
        List<FleetData> list_4,
        GEnum104 genum104_0,
        bool bool_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class409 class409 = new UnknownNPRClass2.Class409();
        // ISSUE: reference to a compiler-generated field
        class409.gclass202_0 = gclass202_0_1;
        // ISSUE: reference to a compiler-generated field
        class409.genum104_0 = genum104_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            List<JumpPoint> source = bool_0
                ? this.gclass0_0.Waypoints.Values.Where<Waypoint>(class409.method_1)
                    .Select<Waypoint, JumpPoint>(gclass214_0 => gclass214_0.JumpPoint).ToList<JumpPoint>()
                : class409.gclass202_0.method_37(true).Intersect<RacialSystemSurvey>(list_3)
                    .OrderByDescending<RacialSystemSurvey, int>(gclass202_0_2 => gclass202_0_2.gclass3_0.int_0)
                    .Select<RacialSystemSurvey, JumpPoint>(class409.method_0).ToList<JumpPoint>();
            if (source.Count == 0)
                return;
            foreach (JumpPoint gclass120 in source)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class410 class410 = new UnknownNPRClass2.Class410()
                {
                    class409_0 = class409,
                    gclass120_0 = gclass120
                };
                // ISSUE: reference to a compiler-generated field
                class410.gclass120_0.bool_0 = false;
                // ISSUE: reference to a compiler-generated method
                FleetData gclass85 = list_4.FirstOrDefault<FleetData>(class410.method_0);
                if (gclass85 != null)
                {
                    gclass85.NPRSomething.bRedeployOrderGiven = true;
                    // ISSUE: reference to a compiler-generated field
                    class410.gclass120_0.bool_0 = true;
                }
            }

            List<JumpPoint> list = source.Where<JumpPoint>(gclass120_0 => !gclass120_0.bool_0)
                .ToList<JumpPoint>();
            if (list.Count == 0)
                return;
            foreach (JumpPoint gclass120_1 in list)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                FleetData gclass85 =
                    list_4.FirstOrDefault<FleetData>(class409.func_0 ?? (class409.func_0 = class409.method_2));
                if (gclass85 != null)
                {
                    gclass85.method_263();
                    // ISSUE: reference to a compiler-generated field
                    gclass85.method_231(gclass120_1, MoveActionType.MoveTo, class409.gclass202_0);
                    gclass85.NPRSomething.bRedeployOrderGiven = true;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 42);
        }
    }

    public void method_48(List<PopulationData> list_3)
    {
        try
        {
            List<FleetData> list1 = this.gclass0_0.FleetDictionary.Values
                .Where<FleetData>(gclass85_0 =>
                    gclass85_0.Race == this.gclass21_0 && gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_13 &&
                    !gclass85_0.NPRSomething.bRedeployOrderGiven)
                .Where<FleetData>(gclass85_0 => gclass85_0.method_154() > gclass85_0.method_140() * 0.5M)
                .ToList<FleetData>();
            if (list1.Count == 0)
                return;
            List<PopulationData> list2 = list_3.Where<PopulationData>(gclass146_0 =>
                gclass146_0.method_62(AuroraProductionCategory.RefuellingPoint) > 0M &&
                gclass146_0.FuelStockpile < 5000000M).ToList<PopulationData>();
            if (list2.Count == 0)
                list2 = list_3.Where<PopulationData>(gclass146_0 =>
                    gclass146_0.method_62(AuroraProductionCategory.RefuellingPoint) > 0M &&
                    gclass146_0.FuelStockpile < 10000000M).ToList<PopulationData>();
            if (list2.Count == 0)
                list2 = list_3.Where<PopulationData>(gclass146_0 =>
                    gclass146_0.method_62(AuroraProductionCategory.RefuellingPoint) > 0M &&
                    gclass146_0.FuelStockpile < 20000000M).ToList<PopulationData>();
            if (list2.Count == 0)
                list2 = list_3
                    .Where<PopulationData>(gclass146_0 =>
                        gclass146_0.method_62(AuroraProductionCategory.RefuellingPoint) > 0M).ToList<PopulationData>();
            if (list2.Count == 0)
                return;
            foreach (FleetData gclass85 in list1)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class411 class411 = new UnknownNPRClass2.Class411();
                // ISSUE: reference to a compiler-generated field
                class411.gclass2_0 = this;
                // ISSUE: reference to a compiler-generated field
                class411.gclass85_0 = gclass85;
                // ISSUE: reference to a compiler-generated method
                PopulationData gclass146_1 = list2.FirstOrDefault<PopulationData>(class411.method_0);
                if (gclass146_1 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    class411.gclass85_0.method_263();
                    // ISSUE: reference to a compiler-generated field
                    class411.gclass85_0.method_219(gclass146_1, MoveActionType.TransferFuelToColony);
                    // ISSUE: reference to a compiler-generated field
                    class411.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated method
                    PopulationData gclass146 = list2.OrderBy<PopulationData, int>(class411.method_1).FirstOrDefault<PopulationData>();
                    // ISSUE: reference to a compiler-generated field
                    if (gclass146 != null && class411.gclass85_0.method_236(GEnum109.const_41, "", false,
                            gclass146.gclass202_0.ActualSystem.SystemID, false).gclass202_0 != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class411.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 43);
        }
    }

    public void method_49(List<PopulationData> list_3)
    {
        try
        {
            List<FleetData> list1 = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(gclass85_0 =>
                {
                    if (gclass85_0.Race != this.gclass21_0 || gclass85_0.MoveOrderDictionary.Count != 0)
                        return false;
                    return gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_18 ||
                           gclass85_0.CivilianFunction == CivilanFunctionType.const_3;
                }).Where<FleetData>(gclass85_0 => gclass85_0.method_154() > gclass85_0.method_140() * 0.5M)
                .ToList<FleetData>();
            List<FleetData> list2 = this.gclass0_0.FleetDictionary.Values
                .Where<FleetData>(gclass85_0 =>
                    gclass85_0.Race == this.gclass21_0 && gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_13 &&
                    !gclass85_0.NPRSomething.bRedeployOrderGiven)
                .Where<FleetData>(gclass85_0 => gclass85_0.method_154() < gclass85_0.method_140() * 0.5M)
                .ToList<FleetData>();
            List<PopulationData> list3 = list_3.Where<PopulationData>(gclass146_0 =>
                gclass146_0.method_62(AuroraProductionCategory.RefuellingPoint) > 0M &&
                gclass146_0.FuelStockpile > 20000000M).ToList<PopulationData>();
            if (list2.Count == 0)
                return;
            foreach (FleetData gclass85_1 in list2)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class412 class412 = new UnknownNPRClass2.Class412();
                // ISSUE: reference to a compiler-generated field
                class412.gclass2_0 = this;
                // ISSUE: reference to a compiler-generated field
                class412.gclass85_0 = gclass85_1;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                FleetData gclass85_5 = list1.Where<FleetData>(class412.method_0)
                    .OrderBy<FleetData, double>(class412.method_1)
                    .ThenByDescending<FleetData, Decimal>(
                        gclass85_0 => gclass85_0.method_154() / gclass85_0.method_140()).FirstOrDefault<FleetData>();
                if (gclass85_5 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    class412.gclass85_0.method_263();
                    // ISSUE: reference to a compiler-generated field
                    class412.gclass85_0.method_222(gclass85_5, MoveActionType.RefuelFromStationaryTankers);
                    // ISSUE: reference to a compiler-generated field
                    class412.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated method
                    FleetData gclass85_2 = list1.OrderBy<FleetData, int>(class412.method_2).FirstOrDefault<FleetData>();
                    // ISSUE: reference to a compiler-generated field
                    if (gclass85_2 != null && class412.gclass85_0.method_236(GEnum109.const_41, "", false,
                            gclass85_2.System.ActualSystem.SystemID, false).gclass202_0 != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class412.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated method
                        PopulationData gclass146_1 = list3.FirstOrDefault<PopulationData>(class412.method_3);
                        if (gclass146_1 != null)
                        {
                            // ISSUE: reference to a compiler-generated field
                            class412.gclass85_0.method_263();
                            // ISSUE: reference to a compiler-generated field
                            class412.gclass85_0.method_219(gclass146_1, MoveActionType.RefuelFromColony);
                            // ISSUE: reference to a compiler-generated field
                            class412.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated method
                            PopulationData gclass146 = list3.OrderBy<PopulationData, int>(class412.method_4)
                                .FirstOrDefault<PopulationData>();
                            // ISSUE: reference to a compiler-generated field
                            if (gclass146 != null && class412.gclass85_0.method_236(GEnum109.const_41, "", false,
                                    gclass146.gclass202_0.ActualSystem.SystemID, false).gclass202_0 != null)
                            {
                                // ISSUE: reference to a compiler-generated field
                                class412.gclass85_0.NPRSomething.bRedeployOrderGiven = true;
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 44);
        }
    }

    public void method_50(List<PopulationData> list_3)
    {
        try
        {
            List<PopulationData> list1 = list_3
                .Where<PopulationData>(gclass146_0 =>
                    gclass146_0.SystemBodyData.Radius * 2.0 <= gclass146_0.Race.MaximumOrbitalMiningDiameter &&
                    gclass146_0.gclass202_0.gclass3_0.genum95_0 != 0)
                .Where<PopulationData>(gclass146_0 => gclass146_0.gclass6_0.double_1 > 0.0)
                .OrderByDescending<PopulationData, double>(gclass146_0 => gclass146_0.gclass6_0.double_1)
                .ToList<PopulationData>();
            List<FleetData> list2 = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(gclass85_0 =>
                    gclass85_0.Race == this.gclass21_0 && gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_15)
                .ToList<FleetData>();
            if (list1.Count == 0 || list2.Count == 0)
                return;
            foreach (FleetData gclass85 in list2)
            {
                long num = gclass85.method_31();
                foreach (PopulationData gclass146_1 in list1)
                {
                    if (gclass85.System == gclass146_1.gclass202_0 && gclass85.XCoord == gclass146_1.method_87())
                    {
                        if (gclass85.YCoord == gclass146_1.method_88())
                            break;
                    }

                    if (gclass146_1.gclass202_0 != gclass85.System ||
                        gclass146_1.gclass202_0.ActualSystem.method_3(gclass85.XCoord, gclass85.YCoord,
                            gclass146_1.method_87(), gclass146_1.method_88()) >= num)
                    {
                        if (gclass146_1.gclass202_0.ActualSystem.method_3(0.0, 0.0, gclass146_1.method_87(),
                                gclass146_1.method_88()) <= num)
                        {
                            if (gclass85.method_236(GEnum109.const_41, "", false,
                                    gclass146_1.gclass202_0.ActualSystem.SystemID, false).gclass202_0 != null)
                                break;
                        }
                    }
                    else
                    {
                        gclass85.method_263();
                        gclass85.method_219(gclass146_1, MoveActionType.MoveTo);
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 45);
        }
    }

    public void method_51(List<FleetData> list_3, List<RacialSystemSurvey> list_4)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        UnknownNPRClass2.Class413 class413 = new UnknownNPRClass2.Class413();
        // ISSUE: reference to a compiler-generated field
        class413.gclass2_0 = this;
        // ISSUE: reference to a compiler-generated field
        class413.list_0 = list_4;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            List<RacialSystemSurvey> list1 = this.gclass0_0.Wrecks.Values
                .Select<Wreck, StarSystem>(gclass233_0 => gclass233_0.System).Distinct<StarSystem>()
                .Where<StarSystem>(class413.method_0).Select<StarSystem, RacialSystemSurvey>(class413.method_1)
                .Where<RacialSystemSurvey>(class413.method_2).ToList<RacialSystemSurvey>();
            // ISSUE: reference to a compiler-generated method
            List<RacialSystemSurvey> list2 = list_3.Where<FleetData>(class413.method_3)
                .Select<FleetData, RacialSystemSurvey>(gclass85_0 => gclass85_0.System).Distinct<RacialSystemSurvey>()
                .ToList<RacialSystemSurvey>();
            if (list1.Count == 0 || list2.Count == 0)
                return;
            this.method_44(list1, list2, list_3, GEnum104.const_9, GEnum100.const_2, 1);
            if (this.gclass21_0.SpecialNPRID != SpecialNPRIDs.StarSwarm)
                return;
            // ISSUE: reference to a compiler-generated method
            List<RacialSystemSurvey> list3 = list_3.Where<FleetData>(class413.method_4)
                .Select<FleetData, RacialSystemSurvey>(gclass85_0 => gclass85_0.System).Distinct<RacialSystemSurvey>()
                .ToList<RacialSystemSurvey>();
            if (list3.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated method
            this.method_44(
                list_3.Where<FleetData>(class413.method_5)
                    .Select<FleetData, RacialSystemSurvey>(gclass85_0 => gclass85_0.System).Distinct<RacialSystemSurvey>()
                    .ToList<RacialSystemSurvey>(), list3, list_3, GEnum104.const_9, GEnum100.const_2, 10);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 46);
        }
    }

    public void method_52(List<FleetData> list_3, List<RacialSystemSurvey> list_4)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            UnknownNPRClass2.Class414 class414 = new UnknownNPRClass2.Class414();
            if (list_4.Count == 0)
                return;
            List<FleetData> list1 = list_3
                .Where<FleetData>(gclass85_0 => gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_12).ToList<FleetData>();
            if (list1.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated field
            class414.list_0 = list_4.Select<RacialSystemSurvey, StarSystem>(gclass202_0 => gclass202_0.ActualSystem)
                .ToList<StarSystem>();
            // ISSUE: reference to a compiler-generated method
            List<SystemBodyData> list2 = this.gclass0_0.SystemBodyRecordDic.Values
                .Where<SystemBodyData>(class414.method_0)
                .Where<SystemBodyData>(gclass1_0 => gclass1_0.MineralDeposits.Values.Count > 3)
                .Where<SystemBodyData>(gclass1_0 => gclass1_0.method_77(this.gclass21_0))
                .Where<SystemBodyData>(gclass1_0 => gclass1_0.method_16(50, false))
                .OrderByDescending<SystemBodyData, double>(gclass1_0 => gclass1_0.method_17())
                .ToList<SystemBodyData>();
            if (list2.Count == 0)
                return;
            foreach (FleetData gclass85 in list1)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class415 class415 = new UnknownNPRClass2.Class415();
                // ISSUE: reference to a compiler-generated field
                class415.gclass85_0 = gclass85;
                foreach (SystemBodyData gclass1_1 in list2)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class415.gclass85_0.System.ActualSystem == gclass1_1.SystemData &&
                        class415.gclass85_0.XCoord == gclass1_1.XCoordinate)
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (class415.gclass85_0.YCoord == gclass1_1.YCoordinate)
                            break;
                    }

                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    SystemBodyData gclass1 =
                        list2.FirstOrDefault<SystemBodyData>(class415.func_0 ??
                                                                     (class415.func_0 = class415.method_0));
                    if (gclass1 != null)
                    {
                        double num = gclass1.method_17();
                        if (gclass1_1.method_17() < num * 1.2)
                            break;
                    }

                    // ISSUE: reference to a compiler-generated field
                    if (gclass1_1.SystemData != class415.gclass85_0.System.ActualSystem)
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (class415.gclass85_0
                                .method_236(GEnum109.const_41, "", false, gclass1_1.SystemData.SystemID, false)
                                .gclass202_0 != null)
                            break;
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        class415.gclass85_0.method_263();
                        // ISSUE: reference to a compiler-generated field
                        class415.gclass85_0.method_215(gclass1_1, MoveActionType.MoveTo);
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 47);
        }
    }

    public void method_53(List<PopulationData> list_3)
    {
        try
        {
            List<PopulationData> list1 = list_3
                .Where<PopulationData>(gclass146_0 =>
                    gclass146_0.gclass6_0.double_0 > 0.0 && gclass146_0.gclass202_0.gclass3_0.genum95_0 != 0)
                .OrderBy<PopulationData, double>(gclass146_0 => gclass146_0.gclass6_0.double_0).ToList<PopulationData>();
            List<FleetData> list2 = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(gclass85_0 =>
                    gclass85_0.Race == this.gclass21_0 && gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_8)
                .ToList<FleetData>();
            if (list1.Count == 0 || list2.Count == 0)
                return;
            foreach (FleetData gclass85 in list2)
            {
                long num = gclass85.method_31();
                foreach (PopulationData gclass146_1 in list1)
                {
                    if (gclass85.System == gclass146_1.gclass202_0 && gclass85.XCoord == gclass146_1.method_87())
                    {
                        if (gclass85.YCoord == gclass146_1.method_88())
                            break;
                    }

                    if (gclass146_1.gclass202_0 != gclass85.System ||
                        gclass146_1.gclass202_0.ActualSystem.method_3(gclass85.XCoord, gclass85.YCoord,
                            gclass146_1.method_87(), gclass146_1.method_88()) >= num)
                    {
                        if (gclass146_1.gclass202_0.ActualSystem.method_3(0.0, 0.0, gclass146_1.method_87(),
                                gclass146_1.method_88()) <= num)
                        {
                            if (gclass85.method_236(GEnum109.const_41, "", false,
                                    gclass146_1.gclass202_0.ActualSystem.SystemID, false).gclass202_0 != null)
                                break;
                        }
                    }
                    else
                    {
                        gclass85.method_263();
                        gclass85.method_219(gclass146_1, MoveActionType.MoveTo);
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 48 /*0x30*/);
        }
    }

    public void method_54()
    {
        try
        {
            List<SystemBodyData> list1 = this.gclass0_0.SystemBodyRecordDic.Values
                .Where<SystemBodyData>(gclass1_0 =>
                    gclass1_0.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                    gclass1_0.BodyTypeId == AuroraSystemBodyType.Superjovian)
                .Where<SystemBodyData>(gclass1_0 => gclass1_0.method_20(AuroraElement.Sorium) > 50000M)
                .Where<SystemBodyData>(gclass1_0 => gclass1_0.method_77(this.gclass21_0))
                .OrderByDescending<SystemBodyData, Decimal>(gclass1_0 =>
                    gclass1_0.method_21(AuroraElement.Sorium)).ToList<SystemBodyData>();
            List<FleetData> list2 = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(gclass85_0 =>
                    gclass85_0.Race == this.gclass21_0 && gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_18)
                .ToList<FleetData>();
            if (list1.Count == 0 || list2.Count == 0)
                return;
            foreach (FleetData gclass85 in list2)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                UnknownNPRClass2.Class416 class416 = new UnknownNPRClass2.Class416();
                // ISSUE: reference to a compiler-generated field
                class416.gclass85_0 = gclass85;
                // ISSUE: reference to a compiler-generated field
                long num1 = class416.gclass85_0.method_31();
                Decimal num2 = 0M;
                // ISSUE: reference to a compiler-generated method
                SystemBodyData gclass1 = list1.FirstOrDefault<SystemBodyData>(class416.method_0);
                if (gclass1 != null)
                    num2 = gclass1.method_21(AuroraElement.Sorium);
                if (!(num2 == 1M))
                {
                    foreach (SystemBodyData gclass1_1 in list1)
                    {
                        if (gclass1_1 != gclass1)
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (gclass1_1.SystemData == class416.gclass85_0.System.ActualSystem)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (gclass1_1.SystemData.method_3(class416.gclass85_0.XCoord,
                                        class416.gclass85_0.YCoord, gclass1_1.XCoordinate, gclass1_1.YCoordinate) <
                                    num1)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    class416.gclass85_0.method_263();
                                    // ISSUE: reference to a compiler-generated field
                                    class416.gclass85_0.method_215(gclass1_1, MoveActionType.MoveTo);
                                    break;
                                }
                            }
                            else if (!(gclass1_1.method_21(AuroraElement.Sorium) - num2 < 0.2M))
                            {
                                if (gclass1_1.SystemData.method_3(0.0, 0.0, gclass1_1.XCoordinate,
                                        gclass1_1.YCoordinate) <= num1)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    if (class416.gclass85_0.method_236(GEnum109.const_41, "", false,
                                            gclass1_1.SystemData.SystemID, false).gclass202_0 != null)
                                        break;
                                }
                            }
                            else
                                break;
                        }
                        else
                            break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 49);
        }
    }

    public void method_55()
    {
        try
        {
            foreach (RacialSystemSurvey gclass202 in this.gclass21_0.RacialSystemDictionary.Values)
            {
                if (gclass202.gclass3_0.genum95_0 != GEnum95.const_0)
                    gclass202.gclass3_0.genum95_0 = GEnum95.const_1;
            }

            RacialSystemSurvey gclass202_1 = this.gclass21_0.method_190();
            if (gclass202_1 != null)
                gclass202_1.gclass3_0.genum95_0 = GEnum95.const_6;
            List<ShipData> list1 = this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass21_0 == this.gclass21_0).ToList<ShipData>();
            List<RacialSystemSurvey> list2 = this.gclass0_0.Populations.Values
                .Where<PopulationData>(gclass146_0 => gclass146_0.Race == this.gclass21_0)
                .Select<PopulationData, RacialSystemSurvey>(gclass146_0 => gclass146_0.gclass202_0).Distinct<RacialSystemSurvey>()
                .ToList<RacialSystemSurvey>();
            list2.AddRange(this.gclass0_0.FleetDictionary.Values
                .Where<FleetData>(gclass85_0 => gclass85_0.Race == this.gclass21_0)
                .Select<FleetData, RacialSystemSurvey>(gclass85_0 => gclass85_0.System).Distinct<RacialSystemSurvey>()
                .ToList<RacialSystemSurvey>());
            List<RacialSystemSurvey> list3 = list2.Distinct<RacialSystemSurvey>()
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 != 0).ToList<RacialSystemSurvey>();
            foreach (RacialSystemSurvey gclass202_2 in list3)
                gclass202_2.gclass3_0.method_24(list1);
            List<RacialSystemSurvey> list4 = list3
                .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 > GEnum95.const_1).ToList<RacialSystemSurvey>();
            foreach (RacialSystemSurvey gclass202_3 in list4.Where<RacialSystemSurvey>(gclass202_0 =>
                         gclass202_0.gclass3_0.genum95_0 == GEnum95.const_5 ||
                         gclass202_0.gclass3_0.genum95_0 == GEnum95.const_6).ToList<RacialSystemSurvey>())
                gclass202_3.gclass3_0.method_26(GEnum95.const_3);
            foreach (RacialSystemSurvey gclass202_4 in list4
                         .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_4)
                         .ToList<RacialSystemSurvey>())
                gclass202_4.gclass3_0.method_26(GEnum95.const_2);
            foreach (RacialSystemSurvey gclass202_5 in this.gclass21_0.RacialSystemDictionary.Values
                         .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 > GEnum95.const_2)
                         .ToList<RacialSystemSurvey>()
                         .SelectMany<RacialSystemSurvey, RacialSystemSurvey>(gclass202_0 => gclass202_0.method_37(true))
                         .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass3_0.genum95_0 == GEnum95.const_1)
                         .ToList<RacialSystemSurvey>())
                gclass202_5.gclass3_0.method_25(list1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 50);
        }
    }

    public void method_56(List<PopulationData> list_3)
    {
        try
        {
            foreach (PopulationData gclass146 in list_3)
            {
                gclass146.gclass6_0.bool_0 = false;
                gclass146.gclass6_0.bool_1 = false;
            }

            bool flag1 = false;
            bool flag2 = false;
            foreach (PopulationData gclass146 in list_3)
            {
                if (gclass146.InstallationDemands.ContainsKey(AuroraInstallationType.Mine))
                    gclass146.InstallationDemands.Remove(AuroraInstallationType.Mine);
                if (gclass146.InstallationDemands.ContainsKey(AuroraInstallationType.AutomatedMine))
                    gclass146.InstallationDemands.Remove(AuroraInstallationType.AutomatedMine);
                if (!gclass146.bIsCapital && gclass146.gclass6_0.double_1 >= AuroraUtils.double_29)
                {
                    gclass146.method_60(this.gclass0_0.InstallationTypes[AuroraInstallationType.AutomatedMine], 10, false);
                    flag1 = true;
                    gclass146.gclass6_0.bool_1 = true;
                    if (gclass146.decimal_30 > 0M && gclass146.MaxColonyCost < 3M &&
                        gclass146.decimal_56 < gclass146.decimal_53)
                    {
                        Decimal int_25 = (gclass146.decimal_53 - gclass146.decimal_56) / AuroraUtils.decimal_68;
                        if (int_25 >= 1M)
                        {
                            if (int_25 > 10M)
                                int_25 = 10M;
                            gclass146.method_60(this.gclass0_0.InstallationTypes[AuroraInstallationType.Mine], (int)int_25,
                                false);
                            flag2 = true;
                            gclass146.gclass6_0.bool_0 = true;
                        }
                    }
                }
            }

            if (!flag1)
                list_3
                    .Where<PopulationData>(gclass146_0 =>
                        gclass146_0.gclass6_0.double_1 >= AuroraUtils.double_30 && !gclass146_0.bIsCapital)
                    .OrderByDescending<PopulationData, double>(gclass146_0 => gclass146_0.gclass6_0.double_1)
                    .FirstOrDefault<PopulationData>()
                    ?.method_60(this.gclass0_0.InstallationTypes[AuroraInstallationType.AutomatedMine], 10, false);
            if (!flag2)
            {
                PopulationData gclass146 = list_3.Where<PopulationData>(gclass146_0 =>
                        gclass146_0.decimal_30 > 0M && gclass146_0.MaxColonyCost < 3M &&
                        gclass146_0.gclass6_0.double_1 >= AuroraUtils.double_30 &&
                        gclass146_0.decimal_56 - gclass146_0.decimal_53 >= AuroraUtils.decimal_68 &&
                        !gclass146_0.bIsCapital)
                    .OrderByDescending<PopulationData, double>(gclass146_0 => gclass146_0.gclass6_0.double_1)
                    .FirstOrDefault<PopulationData>();
                if (gclass146 != null)
                {
                    int num = (gclass146.decimal_53 - gclass146.decimal_56) / AuroraUtils.decimal_68 > 10M ? 1 : 0;
                    gclass146.method_60(this.gclass0_0.InstallationTypes[AuroraInstallationType.Mine], 10, false);
                }
            }

            foreach (PopulationData gclass146 in list_3.Where<PopulationData>(gclass146_0 =>
                         !gclass146_0.gclass6_0.bool_1 &&
                         (gclass146_0.gclass6_0.double_1 < AuroraUtils.double_30 || gclass146_0.bIsCapital) &&
                         gclass146_0.method_73(AuroraInstallationType.AutomatedMine) > 0).ToList<PopulationData>())
                gclass146.method_60(this.gclass0_0.InstallationTypes[AuroraInstallationType.AutomatedMine],
                    gclass146.method_73(AuroraInstallationType.AutomatedMine), true);
            foreach (PopulationData gclass146 in list_3.Where<PopulationData>(gclass146_0 =>
                         !gclass146_0.gclass6_0.bool_0 &&
                         (gclass146_0.gclass6_0.double_1 < AuroraUtils.double_30 || gclass146_0.bIsCapital) &&
                         gclass146_0.method_73(AuroraInstallationType.Mine) > 0).ToList<PopulationData>())
                gclass146.method_60(this.gclass0_0.InstallationTypes[AuroraInstallationType.Mine],
                    gclass146.method_73(AuroraInstallationType.Mine), true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 51);
        }
    }

    public void method_57(List<PopulationData> list_3)
    {
        try
        {
            foreach (PopulationData gclass146 in list_3)
            {
                if (gclass146.gclass202_0.gclass3_0.genum95_0 != GEnum95.const_0)
                {
                    if (gclass146.InstallationDemands.ContainsKey(AuroraInstallationType.TrackingStation))
                        gclass146.InstallationDemands.Remove(AuroraInstallationType.TrackingStation);
                    int num1 = gclass146.method_73(AuroraInstallationType.TrackingStation);
                    int num2 = gclass146.method_74() -
                               num1 * this.gclass0_0.InstallationTypes[AuroraInstallationType.TrackingStation].TargetSize;
                    gclass146.gclass6_0.int_1 = 0;
                    if (gclass146.gclass6_0.genum97_0 == GEnum97.const_5)
                        gclass146.gclass6_0.int_1 = 6;
                    else if (gclass146.gclass6_0.genum97_0 == GEnum97.const_4)
                        gclass146.gclass6_0.int_1 = 4;
                    else if (gclass146.gclass6_0.genum97_0 == GEnum97.const_3)
                        gclass146.gclass6_0.int_1 = 3;
                    else if (gclass146.gclass6_0.genum97_0 == GEnum97.const_2 && num2 > 100)
                        gclass146.gclass6_0.int_1 = 2;
                    else if (gclass146.gclass6_0.genum97_0 == GEnum97.const_1 && num2 > 100)
                        gclass146.gclass6_0.int_1 = 1;
                    if (num1 != gclass146.gclass6_0.int_1)
                    {
                        if (num1 < gclass146.gclass6_0.int_1)
                            gclass146.method_60(this.gclass0_0.InstallationTypes[AuroraInstallationType.TrackingStation],
                                gclass146.gclass6_0.int_1 - num1, false);
                        else if (num1 > gclass146.gclass6_0.int_1)
                            gclass146.method_60(this.gclass0_0.InstallationTypes[AuroraInstallationType.TrackingStation],
                                num1 - gclass146.gclass6_0.int_1, true);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 52);
        }
    }

    public void method_58(List<PopulationData> list_3)
    {
        try
        {
            foreach (PopulationData gclass146 in list_3)
            {
                if (gclass146.gclass202_0.gclass3_0.genum95_0 != GEnum95.const_0)
                {
                    bool flag = false;
                    if (gclass146.InstallationDemands.ContainsKey(AuroraInstallationType.ConstructionFactory))
                        gclass146.InstallationDemands.Remove(AuroraInstallationType.ConstructionFactory);
                    int int_25_1 = gclass146.method_73(AuroraInstallationType.ConstructionFactory);
                    int num = gclass146.method_73(AuroraInstallationType.Mine) +
                              gclass146.method_73(AuroraInstallationType.AutomatedMine);
                    if (gclass146.decimal_30 > 0M && gclass146.MaxColonyCost < 3M &&
                        gclass146.gclass6_0.double_1 >= AuroraUtils.double_29 && int_25_1 < num && !gclass146.bIsCapital &&
                        gclass146.decimal_56 < gclass146.decimal_53)
                    {
                        Decimal int_25_2 = (gclass146.decimal_53 - gclass146.decimal_56) / AuroraUtils.decimal_68;
                        if (int_25_2 >= 1M)
                        {
                            if (int_25_2 > 10M)
                                int_25_2 = 10M;
                            gclass146.method_60(
                                this.gclass0_0.InstallationTypes[AuroraInstallationType.ConstructionFactory], (int)int_25_2,
                                false);
                            flag = true;
                        }
                    }

                    if (!flag && int_25_1 > 0)
                    {
                        if (int_25_1 > 10)
                            int_25_1 = 10;
                        gclass146.method_60(this.gclass0_0.InstallationTypes[AuroraInstallationType.ConstructionFactory],
                            int_25_1, true);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 53);
        }
    }

    public void method_59(List<PopulationData> list_3)
    {
        try
        {
            foreach (PopulationData gclass146 in list_3)
            {
                if (gclass146.gclass202_0.gclass3_0.genum95_0 != GEnum95.const_0)
                {
                    if (gclass146.InstallationDemands.ContainsKey(AuroraInstallationType.ResearchLab))
                        gclass146.InstallationDemands.Remove(AuroraInstallationType.ResearchLab);
                    Decimal num1 = gclass146.method_147();
                    if (num1 < 0M)
                    {
                        Decimal num2 = 0M;
                        Decimal num3 = gclass146.method_75(AuroraInstallationType.ResearchLab);
                        if (num3 >= 1M)
                            num2 = 1M;
                        Decimal decimal_90 = num2 + num3 % 1M;
                        if (decimal_90 > 0M)
                            gclass146.method_61(this.gclass0_0.InstallationTypes[AuroraInstallationType.ResearchLab],
                                decimal_90, true, false);
                    }
                    else
                    {
                        Decimal d = gclass146.method_75(AuroraInstallationType.ResearchLab);
                        if (!(d == 0M))
                        {
                            Decimal decimal_90 = d - Math.Floor(d);
                            if (num1 > 5M)
                                ++decimal_90;
                            if (decimal_90 > 0M)
                                gclass146.method_61(this.gclass0_0.InstallationTypes[AuroraInstallationType.ResearchLab],
                                    decimal_90, false, true);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 54);
        }
    }

    public void method_60(List<PopulationData> list_3)
    {
        try
        {
            foreach (PopulationData gclass146 in list_3)
            {
                if (gclass146.gclass202_0.gclass3_0.genum95_0 != GEnum95.const_0)
                {
                    if (gclass146.InstallationDemands.ContainsKey(AuroraInstallationType.GFCC))
                        gclass146.InstallationDemands.Remove(AuroraInstallationType.GFCC);
                    Decimal num1 = gclass146.method_147();
                    Decimal num2 = gclass146.SystemBodyData.method_20(AuroraElement.Vendarite);
                    if (!(num1 < 0M) && !(num2 < 1000M))
                    {
                        if (num2 > 1000M)
                        {
                            Decimal d = gclass146.method_75(AuroraInstallationType.GFCC);
                            if (!(d == 0M))
                            {
                                Decimal decimal_90 = 1M - (d - Math.Floor(d));
                                if (num1 > 3M)
                                    ++decimal_90;
                                if (decimal_90 > 0M)
                                    gclass146.method_61(this.gclass0_0.InstallationTypes[AuroraInstallationType.GFCC],
                                        decimal_90, false, true);
                            }
                        }
                    }
                    else
                    {
                        Decimal num3 = 0M;
                        Decimal num4 = gclass146.method_75(AuroraInstallationType.GFCC);
                        if (num4 >= 1M)
                            num3 = 1M;
                        Decimal decimal_90 = num3 + num4 % 1M;
                        if (decimal_90 > 0M)
                            gclass146.method_61(this.gclass0_0.InstallationTypes[AuroraInstallationType.GFCC], decimal_90,
                                true, false);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 55);
        }
    }

    public void method_61(List<PopulationData> list_3)
    {
        try
        {
            list_3 = list_3.Where<PopulationData>(gclass146_0 => gclass146_0.gclass202_0.gclass3_0.genum95_0 != 0)
                .OrderByDescending<PopulationData, GEnum97>(gclass146_0 => gclass146_0.gclass6_0.genum97_0)
                .ToList<PopulationData>();
            foreach (PopulationData gclass146 in list_3)
                gclass146.gclass6_0.decimal_1 =
                    Math.Floor(gclass146.method_62(AuroraProductionCategory.RefuellingPoint));
            List<RacialSystemSurvey> list = list_3.Where<PopulationData>(gclass146_0 => gclass146_0.gclass6_0.decimal_1 > 0M)
                .Select<PopulationData, RacialSystemSurvey>(gclass146_0 => gclass146_0.gclass202_0).ToList<RacialSystemSurvey>();
            foreach (PopulationData gclass146 in list_3)
            {
                if (gclass146.InstallationDemands.ContainsKey(AuroraInstallationType.RefuellingStation))
                    gclass146.InstallationDemands.Remove(AuroraInstallationType.RefuellingStation);
                if (list.Contains(gclass146.gclass202_0))
                {
                    if (gclass146.gclass6_0.decimal_1 > 1M)
                    {
                        int num = gclass146.method_73(AuroraInstallationType.RefuellingStation);
                        if (num > 1)
                            gclass146.method_60(this.gclass0_0.InstallationTypes[AuroraInstallationType.RefuellingStation],
                                num - 1, true);
                    }
                }
                else if (this.gclass0_0.method_32(gclass146.Race, gclass146.gclass202_0, 2).Values
                             .Intersect<RacialSystemSurvey>(list).Count<RacialSystemSurvey>() <= 0)
                    gclass146.method_60(this.gclass0_0.InstallationTypes[AuroraInstallationType.RefuellingStation], 1,
                        false);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 56);
        }
    }

    public double method_62(SystemBodyData gclass1_0, bool bool_0)
    {
        try
        {
            if (gclass1_0.MineralDeposits.Count == 0 || gclass1_0.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                gclass1_0.BodyTypeId == AuroraSystemBodyType.Superjovian)
                return 0.0;
            double num1 = 0.0;
            if (this.gclass21_0.SpecialNPRID == SpecialNPRIDs.StarSwarm)
                return (double)gclass1_0.MineralDeposits.Values.Sum<MineralDeposit>(gclass124_0 => gclass124_0.Accessibility);
            AllMineralsValue gclass123 = this.gclass0_0.Populations.Values
                .Where<PopulationData>(gclass146_0 => gclass146_0.Race == this.gclass21_0 && gclass146_0.bIsCapital)
                .Select<PopulationData, AllMineralsValue>(gclass146_0 => gclass146_0.CurrentMinerals).FirstOrDefault<AllMineralsValue>();
            foreach (MineralDeposit gclass124 in gclass1_0.MineralDeposits.Values)
            {
                if (!(gclass124.Amount < 2000M))
                {
                    double decimal1 = (double)gclass124.Accessibility;
                    if (gclass124.Amount < 10000M)
                        decimal1 *= 0.5;
                    if (gclass124.Amount > 1000000M && gclass124.Accessibility > 0.4M)
                        decimal1 *= 2.0;
                    else if (gclass124.Amount > 250000M && gclass124.Accessibility > 0.4M)
                        decimal1 *= 1.5;
                    else if (gclass124.Amount > 100000M && gclass124.Accessibility > 0.4M)
                        decimal1 *= 1.25;
                    if (!bool_0)
                    {
                        Decimal num2 = 0M;
                        if (gclass123 != null)
                            num2 = gclass123.GetValueOfElement(gclass124.MaterialID);
                        if (num2 < 1000M)
                            decimal1 *= 3.0;
                        else if (num2 < 3000M)
                            decimal1 *= 2.0;
                        else if (num2 < 5000M)
                            decimal1 *= 1.5;
                        else if (num2 > 400000M)
                            decimal1 *= 0.1;
                        else if (num2 > 200000M)
                            decimal1 *= 0.25;
                        else if (num2 > 100000M)
                            decimal1 *= 0.5;
                    }
                    else if (gclass124.MaterialID != AuroraElement.Duranium &&
                             gclass124.MaterialID != AuroraElement.Gallicite)
                    {
                        if (gclass124.MaterialID == AuroraElement.Corundium ||
                            gclass124.MaterialID == AuroraElement.Neutronium)
                            decimal1 *= 1.5;
                    }
                    else
                        decimal1 *= 2.0;

                    num1 += decimal1;
                }
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 57);
            return 0.0;
        }
    }
}