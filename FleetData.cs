// Decompiled with JetBrains decompiler
// Type: GClass85
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public partial class FleetData
{
    public Dictionary<int, MoveOrder> MoveOrderDictionary = new Dictionary<int, MoveOrder>();
    public Dictionary<int, StandingOrderDefinition> StandingOrdersDictionary = new Dictionary<int, StandingOrderDefinition>();
    public Dictionary<int, FleetConditionalOrder> ConditionalOrdersDictionary = new Dictionary<int, FleetConditionalOrder>();
    public List<HistoryRecord> Histories = new List<HistoryRecord>();
    public List<GClass134> list_1 = new List<GClass134>();
    public List<GEnum124> list_2 = new List<GEnum124>();
    public List<ShipData> list_3 = new List<ShipData>();
    public GameRace Race;
    public RacialSystemSurvey System;
    public NavalAdminCommand ParentNavalCommand;
    public SystemBodyData OrbitingBody;
    public PopulationData AssignedPopulation;
    public JumpPoint EntryJumpPoint;
    public Contact gclass65_0;
    public OperationalGroup NPROperationGroup;
    public CivilanFunctionType CivilianFunction;
    public FleetData gclass85_0;
    public UnknownNPRFleetRelatedClass NPRSomething;
    public ShippingLineData ShippingLine;
    public CheckState checkState_0;
    private GClass0 gclass0_0;
    public FleetData AnchorFleet;
    public AlienShipIntel gclass117_0;
    public int AnchorFleetID;
    public int SpecificThreatID;
    public int AnchorFleetBearingOffset;
    public double AnchorFleetDistance;
    public bool bGuardNearestHostileContact;
    public bool bGuardNearestKnownWarship;
    public bool bUseAnchorDestination;
    public int FleetID;
    public int TradeLocation;
    public int OrbitDistance;
    public int Speed = 1;
    public int MaxNebulaSpeed = 1;
    public int JustDivided;
    public Decimal LastMoveTime;
    public Decimal LastTransitTime;
    public Decimal decimal_2 = 1M;
    public Decimal decimal_3;
    public double OrbitBearing;
    public double XCoord;
    public double YCoord;
    public double LastXCoord;
    public double LastYCoord;
    public double IncrementStartX;
    public double IncrementStartY;
    public bool IsNPRHomeguard;
    public bool bool_4;
    public bool bAvoidDanger = true;
    public bool bAvoidAlienSystem;
    public bool bDisplaySensors = true;
    public bool bDisplayWeapons = true;
    public bool bUseMaximumSpeed = true;
    public bool bAssumeJumpCapable;
    public bool bDetachedStanding;
    public bool bDetachedCondition;
    public bool bIncludeSquadrons;
    public bool bIgnoreStanding;
    public bool bIgnoreConditional;
    public bool bool_16;
    public bool bNoSurrender;
    public long MaxStandingOrderDistance;
    public ShipClass gclass22_0;
    public FleetData gclass85_2;
    public FleetData gclass85_3;
    public GEnum48 genum48_0;
    public Decimal decimal_4;
    public Decimal decimal_5;
    public Decimal decimal_6;
    public bool bool_18;
    public bool bool_19;
    public bool bool_20;
    public bool bool_21;
    public bool bool_22;
    public int int_9;
    public PopTradeBalance gclass190_0;
    public PopInstallationDemand gclass148_0;
    public int int_10;
    public double double_8;
    public double double_9;
    public double EscapeTimeRemaining;
    public Decimal decimal_7;
    public int int_11;
    public FleetData gclass85_4;
    public Decimal LastFleetDamageTime;
    public bool bool_23;
    public bool bool_24;

    public string FleetName { get; set; }

    public FleetData(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0(
        bool bool_25,
        StarSystem gclass200_0,
        SystemBodyData gclass1_1,
        double double_11,
        double double_12)
    {
        try
        {
            if (bool_25)
                this.Race.method_188(this.System.ActualSystem, this.OrbitingBody, null,
                    WayPointType.FleetWaypoint, this.XCoord, this.YCoord,
                    string.Format((string)"{0} Waypoint", (object)this.FleetName), this.FleetID);
            else
                this.Race.method_188(gclass200_0, gclass1_1, null, WayPointType.FleetWaypoint, double_11,
                    double_12, string.Format((string)"{0} Waypoint", (object)this.FleetName), this.FleetID);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3920);
        }
    }

    public void method_1(int int_12, StandingOrderDefinition gclass136_0)
    {
        try
        {
            if (gclass136_0 == null || gclass136_0.auroraStandingOrder_0 == AuroraStandingOrder.NoOrder)
                return;
            this.StandingOrdersDictionary.Add(int_12, gclass136_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3910);
        }
    }

    public void method_2(FleetData gclass85_5, bool bool_25, bool bool_26)
    {
        try
        {
            this.StandingOrdersDictionary.Clear();
            this.ConditionalOrdersDictionary.Clear();
            if (bool_25)
            {
                foreach (KeyValuePair<int, StandingOrderDefinition> keyValuePair in gclass85_5.StandingOrdersDictionary)
                    this.StandingOrdersDictionary.Add(keyValuePair.Key, keyValuePair.Value);
            }

            if (!bool_26)
                return;
            foreach (KeyValuePair<int, FleetConditionalOrder> keyValuePair in gclass85_5.ConditionalOrdersDictionary)
                this.ConditionalOrdersDictionary.Add(keyValuePair.Key, new FleetConditionalOrder()
                {
                    StandingOrder = keyValuePair.Value.StandingOrder,
                    Condition = keyValuePair.Value.Condition,
                    CreateFleetWaypoint = keyValuePair.Value.CreateFleetWaypoint
                });
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3905);
        }
    }

    public void method_3(ShipData gclass40_0)
    {
        try
        {
            if (this.list_3.Contains(gclass40_0))
                return;
            this.list_3.Add(gclass40_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3773);
        }
    }

    public void method_4()
    {
        try
        {
            this.EscapeTimeRemaining = 0.0;
            for (int index = 1; index < 11; ++index)
                this.EscapeTimeRemaining += AuroraUtils.GetRandomInteger(86400);
            Species gclass194 = this.list_3
                .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.Class.Size)
                .Select<ShipData, Species>(gclass40_0 => gclass40_0.gclass194_0).FirstOrDefault<Species>();
            this.EscapeTimeRemaining *= gclass194.int_2 / 50.0;
            this.EscapeTimeRemaining *= 50.0 / gclass194.int_7;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3707);
        }
    }

    public Decimal method_5()
    {
        try
        {
            return this.method_177().Sum<ShipData>(gclass40_0 => gclass40_0.Class.Cost) *
                   AuroraUtils.decimal_45;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3643);
            return 0M;
        }
    }

    public void method_6()
    {
        try
        {
            if (this.AssignedPopulation == null)
                return;
            if (this.method_176().Count<ShipData>(gclass40_0 => gclass40_0.Class.ArkShip) == 0)
            {
                this.AssignedPopulation = null;
            }
            else
            {
                PopulationData gclass1460 = this.AssignedPopulation;
                this.AssignedPopulation = null;
                gclass1460.method_182();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3557);
        }
    }

    public void method_7()
    {
        try
        {
            this.decimal_7 = this.method_177().Sum<ShipData>(gclass40_0 => gclass40_0.method_52());
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3410);
        }
    }

    public void method_8(GameRace gclass21_1)
    {
        try
        {
            RacialSystemSurvey gclass202_2 = gclass21_1.RacialSystemDictionary.Values.FirstOrDefault<RacialSystemSurvey>(gclass202_1 =>
                gclass202_1.ActualSystem == this.System.ActualSystem);
            if (gclass202_2 == null)
            {
                gclass202_2 = gclass21_1.method_263(this.System.ActualSystem, gclass21_1.SystemTheme, "",
                    gclass21_1.NPR);
                gclass21_1.method_262(this.System.ActualSystem, 0);
            }

            FleetData gclass85_0 = gclass21_1.method_308(this.FleetName, gclass21_1.method_289(), this.System,
                this.XCoord, this.YCoord, this.OrbitingBody, OperationalGroupID.None);
            this.gclass0_0.gclass92_0.method_2(EventType.const_195,
                string.Format((string)"{0} has been transferred to {1}", (object)this.FleetName,
                    (object)(this.Race.method_325(gclass21_1.RaceID) ??
                             this.Race.method_51(gclass21_1, this.System, this.XCoord, this.YCoord)).AlienRaceName),
                this.Race, this.System.ActualSystem, this.XCoord, this.YCoord, AuroraEventCategory.Ship);
            AlienRaceIntel gclass110_1 = !gclass21_1.AlienRaceIntels.ContainsKey(this.Race.RaceID)
                ? gclass21_1.method_51(this.Race, gclass202_2, this.XCoord, this.YCoord)
                : gclass21_1.AlienRaceIntels[this.Race.RaceID];
            foreach (ShipData gclass40 in this.method_176())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class917 class917 = new FleetData.Class917()
                {
                    gclass40_0 = gclass40
                };
                // ISSUE: reference to a compiler-generated field
                class917.gclass40_0.gclass187_0 = null;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                AlienShipClassIntel gclass115_0 = gclass21_1.dictionary_11.Values.FirstOrDefault<AlienShipClassIntel>(class917.method_0) ??
                                        gclass21_1.method_49(class917.gclass40_0, gclass110_1);
                gclass115_0.method_8();
                // ISSUE: reference to a compiler-generated method
                AlienShipIntel gclass117 = gclass21_1.dictionary_12.Values.FirstOrDefault<AlienShipIntel>(class917.method_1);
                if (gclass117 == null)
                {
                    ++gclass115_0.int_4;
                    // ISSUE: reference to a compiler-generated field
                    gclass117 = gclass21_1.method_46(class917.gclass40_0, gclass110_1, gclass115_0);
                }

                this.gclass0_0.gclass92_0.method_2(EventType.const_195,
                    string.Format((string)"The alien ship {0} has been transferred to us",
                        (object)gclass117.method_11()), gclass21_1,
                    gclass85_0.System.ActualSystem, gclass85_0.XCoord, gclass85_0.YCoord,
                    AuroraEventCategory.Ship);
                // ISSUE: reference to a compiler-generated field
                this.Race.method_271(class917.gclass40_0, gclass85_0, gclass21_1, false);
            }

            if (gclass21_1.UnknownNprClass == null)
                return;
            gclass85_0.NPRSomething.method_0();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3397);
        }
    }

    public bool method_9()
    {
        try
        {
            return this.MoveOrderDictionary.Count != 0 && this.MoveOrderDictionary.Values.Where<MoveOrder>(gclass139_0 =>
                    gclass139_0.MoveActionType.MoveActionType == MoveActionType.SquadronTransit ||
                    gclass139_0.MoveActionType.MoveActionType == MoveActionType.StandardTransit ||
                    gclass139_0.MoveActionType.MoveActionType == MoveActionType.TransitAndDivideFleet ||
                    gclass139_0.MoveActionType.MoveActionType == MoveActionType.TransitBySubFleet)
                .Count<MoveOrder>(gclass139_0 => gclass139_0.NewSystem == null) > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3247);
            return false;
        }
    }

    public string method_10(CheckState checkState_1, CheckState checkState_2)
    {
        try
        {
            string str = this.FleetName + Environment.NewLine;
            List<ShipData> source = this.method_176();
            foreach (ShipClass gclass22 in source.Select<ShipData, ShipClass>(gclass40_0 => gclass40_0.Class)
                         .Distinct<ShipClass>().OrderBy<ShipClass, bool>(gclass22_0 => gclass22_0.Commercial)
                         .ThenByDescending<ShipClass, Decimal>(gclass22_0 => gclass22_0.Size)
                         .ThenBy<ShipClass, string>(gclass22_0 => gclass22_0.ClassName).ToList<ShipClass>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class918 class918 = new FleetData.Class918();
                // ISSUE: reference to a compiler-generated field
                class918.gclass22_0 = gclass22;
                // ISSUE: reference to a compiler-generated method
                List<ShipData> list = source.Where<ShipData>(class918.method_0)
                    .OrderBy<ShipData, string>(gclass40_0 => gclass40_0.ShipName).ToList<ShipData>();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (!(class918.gclass22_0.Size > 20M) &&
                    (!(class918.gclass22_0.Size > 10M) || checkState_1 != CheckState.Checked) &&
                    checkState_2 != CheckState.Checked)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    str =
                        string.Format((string)"{0}{1}x {2} class {3}: {4}", new[] { str },
                            AuroraUtils.smethod_37(list.Count), class918.gclass22_0.ClassName,
                            class918.gclass22_0.ShipHull.Description, Environment.NewLine);
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    str = string.Format((string)"{0}{1} class {2}: ", (object)str,
                        (object)class918.gclass22_0.ClassName, (object)class918.gclass22_0.ShipHull.Description);
                    foreach (ShipData gclass40 in list)
                        str = string.Format((string)"{0}{1}, ", (object)str, (object)gclass40.ShipName);
                    str = str.Remove(str.Length - 2) + Environment.NewLine;
                }
            }

            return str + Environment.NewLine;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 769);
            return "error";
        }
    }

    public void method_11()
    {
        try
        {
            foreach (ShipData gclass40 in this.method_177())
            {
                List<FireControlAssignment> list1 = gclass40.list_4.Where<FireControlAssignment>(gclass36_0 =>
                    gclass36_0.FCComponent.Data.ComponentTypeID ==
                    AuroraComponentType.MissileFireControl && !gclass36_0.HasFiredThisPhase).ToList<FireControlAssignment>();
                if (list1.Count != 0)
                {
                    foreach (FireControlAssignment gclass36 in list1)
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        FleetData.Class919 class919 = new FleetData.Class919();
                        // ISSUE: reference to a compiler-generated field
                        class919.gclass36_0 = gclass36;
                        // ISSUE: reference to a compiler-generated method
                        List<WeaponFireControlAssignment> list2 = gclass40.list_2.Where<WeaponFireControlAssignment>(class919.method_0).ToList<WeaponFireControlAssignment>();
                        if (list2.Count != 0)
                        {
                            List<WeaponFireControlAssignment> gclass31List = gclass40.method_20(list2);
                            if (gclass31List.Count != 0)
                            {
                                foreach (WeaponFireControlAssignment gclass31 in gclass31List)
                                {
                                    // ISSUE: object of a compiler-generated type is created
                                    // ISSUE: variable of a compiler-generated type
                                    FleetData.Class920 class920 = new FleetData.Class920();
                                    // ISSUE: reference to a compiler-generated field
                                    class920.gclass31_0 = gclass31;
                                    // ISSUE: reference to a compiler-generated method
                                    MissileAssignment gclass30_0 = gclass40.FiredMissiles.FirstOrDefault<MissileAssignment>(class920.method_0);
                                    // ISSUE: reference to a compiler-generated field
                                    if (gclass30_0 != null &&
                                        (gclass40.Race.SpecialNPRID != SpecialNPRIDs.const_0 ||
                                         this.gclass0_0.NoOverhauls != 0 || !gclass40.method_92(class920.gclass31_0)))
                                    {
                                        if (!gclass40.method_103(gclass30_0.Missile))
                                        {
                                            this.gclass0_0.gclass92_0.method_2(EventType.const_12,
                                                string.Format(
                                                    (string)
                                                    "{0} cannot lauch a {1} as no missiles of the required type are available in the ship's magazines.",
                                                    (object)gclass40.ShipName, (object)gclass30_0.Missile.Name),
                                                gclass40.Race, gclass40.gclass85_0.System.ActualSystem,
                                                gclass40.gclass85_0.XCoord, gclass40.gclass85_0.YCoord,
                                                AuroraEventCategory.Ship);
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (gclass30_0.Missile.Size >
                                                class920.gclass31_0.WeaponComponent.decimal_3)
                                            {
                                                this.gclass0_0.gclass92_0.method_2(EventType.const_194,
                                                    string.Format(
                                                        (string)
                                                        "{0} cannot lauch a {1} as the ordnance is too large for the launcher.",
                                                        (object)gclass40.ShipName, (object)gclass30_0.Missile.Name),
                                                    gclass40.Race, gclass40.gclass85_0.System.ActualSystem,
                                                    gclass40.gclass85_0.XCoord, gclass40.gclass85_0.YCoord,
                                                    AuroraEventCategory.Ship);
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                WeaponComponentRechargeStatus gclass27 = new WeaponComponentRechargeStatus(class920.gclass31_0.WeaponComponent,
                                                    class920.gclass31_0.WeaponNum, class920.gclass31_0.WeaponComponent.int_11);
                                                gclass40.list_7.Add(gclass27);
                                                // ISSUE: reference to a compiler-generated field
                                                class919.gclass36_0.HasFiredThisPhase = true;
                                                // ISSUE: reference to a compiler-generated field
                                                gclass40.method_101(class919.gclass36_0, gclass30_0, 0,
                                                    AuroraContactType.None).OrbitBody = gclass40.gclass85_0.OrbitingBody;
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
            AuroraUtils.ShowExceptionPopup(ex, 770);
        }
    }

    public void method_12(AuroraComponentType auroraComponentType_0, double double_11)
    {
        try
        {
            List<ShipData> list1 = this.method_177()
                .Where<ShipData>(gclass40_0 => !gclass40_0.Class.Commercial).ToList<ShipData>();
            if (list1.Count == 0)
                return;
            List<Contact> list2 = this.gclass0_0.Contacts.Values.Where<Contact>(gclass65_1 =>
                    gclass65_1.System == this.System.ActualSystem &&
                    gclass65_1.ContactRace != this.Race &&
                    gclass65_1.DetectRace == this.Race && this.gclass0_0.GameTime == gclass65_1.LastUpdate &&
                    gclass65_1.ContactType == AuroraContactType.Ship && gclass65_1.ContactMethod == ContactDetectMethod.const_0)
                .Where<Contact>(gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile).ToList<Contact>();
            if (list2.Count == 0)
                return;
            List<Contact> list3 = list2.ToList<Contact>();
            List<ShipData> source = new List<ShipData>();
            int num = 0;
            while (true)
            {
                foreach (ShipData gclass40 in list1)
                {
                    Contact gclass65 = gclass40.method_57(list2, auroraComponentType_0, double_11);
                    if (gclass65 != null)
                    {
                        list2.Remove(gclass65);
                    }
                    else
                    {
                        source.Add(gclass40);
                        foreach (FireControlAssignment gclass36 in gclass40.list_4)
                        {
                            gclass36.TargetID = 0;
                            gclass36.TargetContactType = AuroraContactType.None;
                        }
                    }

                    if (list2.Count == 0)
                        list2 = list3.ToList<Contact>();
                }

                if (source.Count != 0)
                {
                    ++num;
                    if (num != 5)
                    {
                        list2 = list3.ToList<Contact>();
                        list1 = source.ToList<ShipData>();
                        source.Clear();
                    }
                    else
                        goto label_1;
                }
                else
                    break;
            }

            return;
            label_1: ;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 771);
        }
    }

    public Decimal method_13()
    {
        try
        {
            return this.method_176().Sum<ShipData>(gclass40_0 =>
                gclass40_0.Class.Size * gclass40_0.Class.MaxSpeed);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 772);
            return 0M;
        }
    }

    public void method_14(FleetData gclass85_5)
    {
        try
        {
            if (gclass85_5.System.ActualSystem != this.System.ActualSystem)
            {
                this.method_263();
            }
            else
            {
                List<ShipData> list = this.method_176().Where<ShipData>(gclass40_0 => !gclass40_0.bool_7)
                    .ToList<ShipData>();
                if (list.Count == 0)
                    return;
                List<ShipData> source = gclass85_5.method_177();
                foreach (ShipData gclass40_1 in list)
                {
                    gclass40_1.bool_7 = true;
                    foreach (ShipData gclass40_2 in source)
                        gclass40_2.int_36 = AuroraUtils.GetRandomInteger(1000);
                    ShipData gclass40_3 = source.OrderBy<ShipData, int>(gclass40_0 => gclass40_0.int_36)
                        .FirstOrDefault<ShipData>();
                    double double_9 = 100.0;
                    if (gclass40_3.gclass85_0.Speed > 0)
                        double_9 = this.Speed / gclass40_3.gclass85_0.Speed * (double)AuroraUtils.int_55;
                    if (AuroraUtils.GetRandomInteger(100) <= double_9)
                    {
                        Decimal num1 = (int)Math.Floor(gclass40_1.Class.Size);
                        Decimal num2 = (int)Math.Floor(gclass40_3.Class.Size);
                        if (gclass40_1.Class.Commercial)
                            num1 = Math.Floor(num1 / 10M);
                        if (gclass40_3.Class.Commercial)
                            num2 = Math.Floor(num2 / 10M);
                        if (gclass40_1.int_35 > gclass40_3.int_35)
                        {
                            Decimal num3 = 1M + (gclass40_1.int_35 - gclass40_3.int_35) / 10000M;
                            num1 *= num3;
                            num2 *= num3;
                        }

                        Decimal decimal_13_1 = (int)num1;
                        Decimal decimal_13_2 = (int)num2;
                        this.gclass0_0.method_1(gclass40_1.Race, gclass40_1, null, null, null,
                            AuroraContactType.Ship, gclass40_3.int_8, 1, 1, 0, 0, 0, decimal_13_1, 0M, 0.0, double_9,
                            gclass40_1.Race.method_268(gclass40_3.int_8).method_11(), gclass40_3.Race,
                            false, false, false, false, false, GEnum62.const_1);
                        this.gclass0_0.method_1(gclass40_3.Race, gclass40_3, null, null, null,
                            AuroraContactType.Ship, gclass40_1.int_8, 1, 1, 0, 0, 0, decimal_13_2, 0M, 0.0, double_9,
                            gclass40_3.Race.method_268(gclass40_1.int_8).method_11(), gclass40_1.Race,
                            false, false, false, false, false, GEnum62.const_2);
                    }
                    else
                    {
                        this.gclass0_0.gclass92_0.method_2(EventType.const_124,
                            string.Format((string)"{0} failed in its attempt to ram {1}",
                                (object)gclass40_1.method_187(),
                                (object)gclass40_1.Race.method_267(gclass40_3).method_11()),
                            gclass40_1.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_124,
                            string.Format((string)"{0} failed in its attempt to ram {1}",
                                (object)gclass40_3.Race.method_267(gclass40_1).method_11(),
                                (object)gclass40_3.method_187()),
                            gclass40_3.Race, gclass40_3.gclass85_0.System.ActualSystem,
                            gclass40_3.gclass85_0.XCoord, gclass40_3.gclass85_0.YCoord, AuroraEventCategory.Ship);
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 773);
        }
    }

    public string method_15()
    {
        try
        {
            Commander gclass55 = this.method_162();
            return gclass55 == null ? this.FleetName : string.Format((string)"{0} under the command of {1}",
                (object)this.FleetName, (object)gclass55.method_38());
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 774);
            return "Unknown";
        }
    }

    public void method_16(AuroraMeasurementType auroraMeasurementType_0, Decimal decimal_9)
    {
        try
        {
            if (this.Race.NPR)
                return;
            this.method_18(auroraMeasurementType_0, decimal_9);
            Commander gclass55;
            switch (auroraMeasurementType_0)
            {
                case AuroraMeasurementType.RuinsDiscovered:
                case AuroraMeasurementType.BodiesWithMineralsDiscovered:
                case AuroraMeasurementType.AncientConstructsDiscovered:
                    gclass55 = this.method_19(AuroraComponentType.GeologicalSurveySensors);
                    break;
                case AuroraMeasurementType.JumpPointsDiscovered:
                    gclass55 = this.method_19(AuroraComponentType.GravitationalSurveySensors);
                    break;
                case AuroraMeasurementType.TonsSalvaged:
                    gclass55 = this.method_19(AuroraComponentType.SalvageModule);
                    break;
                case AuroraMeasurementType.JPStablisationsCompleted:
                case AuroraMeasurementType.LPStablisationsCompleted:
                    gclass55 = this.method_19(AuroraComponentType.JumpPointStabilisation);
                    break;
                default:
                    List<Commander> list = this.gclass0_0.Ships.Values
                        .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0 == this)
                        .Select<ShipData, Commander>(gclass40_0 => gclass40_0.method_192(AuroraCommandType.Ship))
                        .ToList<Commander>();
                    if (list.Count == 0)
                        return;
                    gclass55 = list.Where<Commander>(gclass55_0 => gclass55_0 != null)
                        .OrderBy<Commander, int>(gclass55_0 => gclass55_0.RacialRank.RankNum)
                        .ThenBy<Commander, int>(gclass55_0 => gclass55_0.Seniority).FirstOrDefault<Commander>();
                    break;
            }

            gclass55?.method_1(auroraMeasurementType_0, decimal_9);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 775);
        }
    }

    public void method_17(
        AuroraMeasurementType auroraMeasurementType_0,
        SystemBodyData gclass1_1,
        JumpPoint gclass120_1,
        string string_1)
    {
        try
        {
            List<ShipData> source = this.method_177();
            List<ShipData> gclass40List = new List<ShipData>();
            switch (auroraMeasurementType_0)
            {
                case AuroraMeasurementType.StarSystemsExplored:
                    using (List<ShipData>.Enumerator enumerator = source.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                            enumerator.Current.method_204(string.Format((string)"Discovered new system: {0}",
                                (object)this.System.Name));
                        break;
                    }
                case AuroraMeasurementType.RuinsDiscovered:
                    using (List<ShipData>.Enumerator enumerator = source
                               .Where<ShipData>(gclass40_0 =>
                                   gclass40_0.method_167(AuroraComponentType.GeologicalSurveySensors) > 0)
                               .ToList<ShipData>().GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                            enumerator.Current.method_204(
                                string.Format((string)"Discovered {0} on {1}", (object)gclass1_1.RuinData.Description,
                                    (object)gclass1_1.method_78(this.Race)));
                        break;
                    }
                case AuroraMeasurementType.JumpPointsDiscovered:
                    using (List<ShipData>.Enumerator enumerator = source
                               .Where<ShipData>(gclass40_0 =>
                                   gclass40_0.method_167(AuroraComponentType.GravitationalSurveySensors) > 0)
                               .ToList<ShipData>().GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                            enumerator.Current.method_204(string.Format((string)"Discovered jump point in  {0}",
                                (object)this.System.Name));
                        break;
                    }
                case AuroraMeasurementType.HabitableWorldDiscovered:
                    using (List<ShipData>.Enumerator enumerator = source.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                            enumerator.Current.method_204(string.Format((string)"Discovered habitable world in: {0}",
                                (object)this.System.Name));
                        break;
                    }
                case AuroraMeasurementType.TonsSalvaged:
                    source.Where<ShipData>(gclass40_0 =>
                        gclass40_0.method_167(AuroraComponentType.SalvageModule) > 0).ToList<ShipData>();
                    using (List<ShipData>.Enumerator enumerator = source.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                            enumerator.Current.method_204(string.Format((string)"{0} in {1}", (object)string_1,
                                (object)this.System.Name));
                        break;
                    }
                case AuroraMeasurementType.JPStablisationsCompleted:
                    source.Where<ShipData>(gclass40_0 =>
                        gclass40_0.method_167(AuroraComponentType.JumpPointStabilisation) > 0).ToList<ShipData>();
                    string str = "Unknown";
                    if (gclass120_1.LinkedJumpPoint == null)
                        str = "unexplored";
                    else if (this.Race.RacialSystemDictionary.ContainsKey(gclass120_1.LinkedJumpPoint.SystemData.SystemID))
                        str = this.Race.RacialSystemDictionary[gclass120_1.LinkedJumpPoint.SystemData.SystemID].Name;
                    using (List<ShipData>.Enumerator enumerator = source.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                            enumerator.Current.method_204(string.Format((string)"Stabilised {0} jump point in {1}",
                                (object)str, (object)this.System.Name));
                        break;
                    }
                case AuroraMeasurementType.AncientConstructsDiscovered:
                    using (List<ShipData>.Enumerator enumerator = source
                               .Where<ShipData>(gclass40_0 =>
                                   gclass40_0.method_167(AuroraComponentType.GeologicalSurveySensors) > 0)
                               .ToList<ShipData>().GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                            enumerator.Current.method_204(
                                string.Format((string)"Discovered Ancient Construct on {0}",
                                    (object)gclass1_1.method_78(this.Race)));
                        break;
                    }
                case AuroraMeasurementType.LPStablisationsCompleted:
                    source.Where<ShipData>(gclass40_0 =>
                        gclass40_0.method_167(AuroraComponentType.JumpPointStabilisation) > 0).ToList<ShipData>();
                    using (List<ShipData>.Enumerator enumerator = source.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                            enumerator.Current.method_204(
                                string.Format((string)"Stabilised {0} lagrange point in {1}",
                                    (object)gclass1_1.method_78(this.Race), (object)this.System.Name));
                        break;
                    }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3673);
        }
    }

    public void method_18(AuroraMeasurementType auroraMeasurementType_0, Decimal decimal_9)
    {
        try
        {
            if (this.Race.NPR)
                return;
            List<ShipData> source = this.method_177();
            switch (auroraMeasurementType_0)
            {
                case AuroraMeasurementType.RuinsDiscovered:
                case AuroraMeasurementType.BodiesWithMineralsDiscovered:
                case AuroraMeasurementType.AncientConstructsDiscovered:
                    source = source.Where<ShipData>(gclass40_0 =>
                        gclass40_0.method_167(AuroraComponentType.GeologicalSurveySensors) > 0).ToList<ShipData>();
                    break;
                case AuroraMeasurementType.JumpPointsDiscovered:
                    source = source.Where<ShipData>(gclass40_0 =>
                            gclass40_0.method_167(AuroraComponentType.GravitationalSurveySensors) > 0)
                        .ToList<ShipData>();
                    break;
                case AuroraMeasurementType.TonsSalvaged:
                    source = source
                        .Where<ShipData>(
                            gclass40_0 => gclass40_0.method_167(AuroraComponentType.SalvageModule) > 0)
                        .ToList<ShipData>();
                    break;
                case AuroraMeasurementType.JPStablisationsCompleted:
                case AuroraMeasurementType.LPStablisationsCompleted:
                    source = source.Where<ShipData>(gclass40_0 =>
                        gclass40_0.method_167(AuroraComponentType.JumpPointStabilisation) > 0).ToList<ShipData>();
                    break;
            }

            foreach (ShipData gclass40 in source)
                gclass40.method_56(auroraMeasurementType_0, decimal_9);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 776);
        }
    }

    public Commander method_19(AuroraComponentType auroraComponentType_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class921 class921 = new FleetData.Class921();
        // ISSUE: reference to a compiler-generated field
        class921.auroraComponentType_0 = auroraComponentType_0;
        // ISSUE: reference to a compiler-generated field
        class921.gclass85_0 = this;
        try
        {
            // ISSUE: reference to a compiler-generated method
            List<ShipData> list1 = this.gclass0_0.Ships.Values
                .Where<ShipData>(class921.method_0).ToList<ShipData>();
            if (list1.Count == 0)
                return null;
            List<Commander> list2 = list1
                .Select<ShipData, Commander>(gclass40_0 => gclass40_0.method_192(AuroraCommandType.Ship))
                .Where<Commander>(gclass55_0 => gclass55_0 != null).ToList<Commander>();
            return list2.Count == 0
                ? null
                : list2.OrderBy<Commander, int>(gclass55_0 => gclass55_0.RacialRank.RankNum)
                    .ThenBy<Commander, int>(gclass55_0 => gclass55_0.Seniority).FirstOrDefault<Commander>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 777);
            return null;
        }
    }

    public double method_20(int int_12)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class922 class922 = new FleetData.Class922();
        // ISSUE: reference to a compiler-generated field
        class922.int_0 = int_12;
        try
        {
            // ISSUE: reference to a compiler-generated method
            return this.method_176().Sum<ShipData>(class922.method_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 778);
            return 0.0;
        }
    }

    public List<MissileSalvo> method_21(List<MissileSalvo> list_4, int int_12)
    {
        try
        {
            List<MissileSalvo> gclass132List = new List<MissileSalvo>();
            foreach (MissileSalvo gclass132 in list_4)
            {
                double num = gclass132.MissileSpeed * int_12;
                if (this.gclass0_0.GetDistanceBetween(this.XCoord, this.YCoord, gclass132.Xcor, gclass132.Ycor) <
                    num)
                    gclass132List.Add(gclass132);
            }

            return gclass132List;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 779);
            return null;
        }
    }

    public bool method_22(List<JumpPoint> list_4, int int_12)
    {
        try
        {
            foreach (JumpPoint gclass120 in list_4)
            {
                int num = this.Speed * int_12;
                if (this.gclass0_0.GetDistanceBetween(this.XCoord, this.YCoord, gclass120.XCoord, gclass120.YCoord) < num)
                    return true;
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 780);
            return false;
        }
    }

    public bool method_23(AetherGate gclass210_0, int int_12)
    {
        try
        {
            if (gclass210_0 == null || gclass210_0.double_2 > 0.0)
                return false;
            int num = this.Speed * int_12;
            return this.gclass0_0.GetDistanceBetween(this.XCoord, this.YCoord, gclass210_0.double_0, gclass210_0.double_1) <
                   num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3408);
            return false;
        }
    }

    public bool method_24(FleetData gclass85_5)
    {
        try
        {
            if (!this.Race.NPR)
                return false;
            if (this.NPROperationGroup.genum104_0 == GEnum104.const_1)
            {
                if (gclass85_5.NPROperationGroup.genum104_0 == GEnum104.const_1 ||
                    gclass85_5.NPROperationGroup.genum104_0 == GEnum104.const_6)
                    return true;
            }
            else if (gclass85_5.NPROperationGroup.genum104_0 == this.NPROperationGroup.genum104_0)
                return true;

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 781);
            return false;
        }
    }

    public bool method_25()
    {
        try
        {
            List<ShipData> source = this.method_176();
            if (source.Where<ShipData>(gclass40_0 => gclass40_0.Class.gclass163_0 != null)
                    .Where<ShipData>(gclass40_0 =>
                        gclass40_0.Class.gclass163_0.TechType == TechType.TroopTransportBoardingEquipped &&
                        gclass40_0.NPRShipBehaviour.genum99_0 == GEnum99.const_4).ToList<ShipData>().Count == 0)
                return false;
            foreach (ShipData gclass40 in source)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                if (this.gclass0_0.FormationDictionary.Values.Count<GroundUnitFormationData>(new FleetData.Class923()
                    {
                        gclass40_0 = gclass40
                    }.method_0) != 0)
                    return true;
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 782);
            return false;
        }
    }

    public Decimal method_26()
    {
        try
        {
            return this.method_176().Sum<ShipData>(gclass40_0 => gclass40_0.Class.Size);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 783);
            return 0M;
        }
    }

    public void method_27()
    {
        try
        {
            List<ShipData> source = this.method_176();
            List<ShipData> list1 = source
                .Where<ShipData>(gclass40_0 => gclass40_0.int_15 == 0 && gclass40_0.method_148(true) != null)
                .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.method_148(false).decimal_3)
                .ToList<ShipData>();
            List<ShipData> list2 = source
                .Where<ShipData>(gclass40_0 => gclass40_0.int_15 == 0 && gclass40_0.method_148(false) != null)
                .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.method_148(false).decimal_3)
                .ToList<ShipData>();
            if (list1.Count + list2.Count < 2)
                return;
            source.Where<ShipData>(gclass40_0 => gclass40_0.Class.Commercial).Except<ShipData>(list1)
                .Except<ShipData>(list2)
                .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.Class.Size)
                .ToList<ShipData>();
            source.Where<ShipData>(gclass40_0 => !gclass40_0.Class.Commercial).Except<ShipData>(list1)
                .Except<ShipData>(list2)
                .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.Class.Size)
                .ToList<ShipData>();
            foreach (ShipData gclass40 in list2)
                gclass40.method_148(false);
            source.Select<ShipData, Decimal>(gclass40_0 => gclass40_0.Class.Size)
                .OrderByDescending<Decimal, Decimal>(decimal_0 => decimal_0).FirstOrDefault<Decimal>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 784);
        }
    }

    public bool method_28(double double_11, double double_12)
    {
        try
        {
            return this.gclass0_0.GetDistanceBetween(this.XCoord, this.YCoord, double_11, double_12) <=
                   (double)this.method_30() / 2.0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 7785);
            return false;
        }
    }

    public bool method_29(PopulationData gclass146_1)
    {
        try
        {
            double num1 = this.gclass0_0.GetDistanceBetween(this.XCoord, this.YCoord, gclass146_1.method_87(),
                gclass146_1.method_88());
            double num2 = (double)this.method_30();
            if (num1 < num2 / 2.0)
                return true;
            if (num1 > num2)
                return false;
            int num3 = (int)(this.method_176().Sum<ShipData>(gclass40_0 => gclass40_0.Class.FuelCapacity) *
                             (num1 / num2));
            return gclass146_1.FuelStockpile > num3;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 786);
            return false;
        }
    }

    public Decimal method_30()
    {
        try
        {
            return this.method_176().Select<ShipData, Decimal>(gclass40_0 => gclass40_0.method_81())
                .DefaultIfEmpty<Decimal>(0M).Min<Decimal>(decimal_0 => decimal_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 787);
            return 0M;
        }
    }

    public long method_31()
    {
        try
        {
            return this.MaxStandingOrderDistance > 0L ? this.MaxStandingOrderDistance : AuroraUtils.long_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 788);
            return AuroraUtils.long_2;
        }
    }

    public void method_32(int int_12)
    {
        try
        {
            if (int_12 == 0)
                int_12 = 1;
            if (this.MoveOrderDictionary.Count == 0)
            {
                int num1 = (int)MessageBox.Show("No orders have been created for this fleet");
            }
            else
            {
                List<MoveOrder> list = this.MoveOrderDictionary.Values
                    .OrderBy<MoveOrder, int>(gclass139_0 => gclass139_0.OrderValue).ToList<MoveOrder>();
                RacialSystemSurvey gclass202 = list[list.Count - 1].StartSystem;
                if (list[list.Count - 1].NewSystem != null)
                    gclass202 = list[list.Count - 1].NewSystem;
                if (list[0].StartSystem != gclass202)
                {
                    int num2 = (int)MessageBox.Show(
                        "The start and end systems for the orders must be the same to use repeat ordering");
                }
                else
                {
                    for (int index = 1; index <= int_12; ++index)
                    {
                        foreach (MoveOrder gclass139_0 in list)
                            this.method_34(gclass139_0);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 789);
        }
    }

    public void method_33(MoveOrder gclass139_0_1)
    {
        try
        {
            if (this.MoveOrderDictionary.Count == 0)
                return;
            if (this.MoveOrderDictionary.Count == 1)
            {
                this.gclass0_0.gclass92_0.method_2(EventType.const_24,
                    string.Format(
                        (string)
                        "{0} has cycle orders set but only has one order set up. As this can lead to an endless loop the cycle orders request has been removed",
                        (object)this.FleetName),
                    this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                    AuroraEventCategory.Fleet);
                this.checkState_0 = CheckState.Unchecked;
            }
            else
            {
                List<MoveOrder> list = this.MoveOrderDictionary.Values
                    .OrderBy<MoveOrder, int>(gclass139_0_2 => gclass139_0_2.OrderValue).ToList<MoveOrder>();
                RacialSystemSurvey gclass202 = list[list.Count - 1].StartSystem;
                if (list[list.Count - 1].NewSystem != null)
                    gclass202 = list[list.Count - 1].NewSystem;
                if (gclass139_0_1.StartSystem != gclass202)
                {
                    this.gclass0_0.gclass92_0.method_2(EventType.const_24,
                        string.Format(
                            (string)
                            "{0} cannot cycle order {1} as it does not start in the same system as the last current order ends. The cycle orders request has been removed",
                            (object)this.FleetName, (object)gclass139_0_1.Description),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
                    this.checkState_0 = CheckState.Unchecked;
                }
                else
                    this.method_34(gclass139_0_1);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 790);
        }
    }

    public void method_34(MoveOrder gclass139_0_1)
    {
        try
        {
            MoveOrder gclass139 = new MoveOrder();
            gclass139.MoveOrderID = this.gclass0_0.method_26(GEnum0.const_37);
            gclass139.OrderValue = this.MoveOrderDictionary.Count <= 0
                ? 1
                : this.MoveOrderDictionary.Values.Max<MoveOrder>(gclass139_0_2 => gclass139_0_2.OrderValue) + 1;
            gclass139.Fleet = this;
            gclass139.Race = this.Race;
            gclass139.StartSystem = gclass139_0_1.StartSystem;
            gclass139.DestinationType = gclass139_0_1.DestinationType;
            gclass139.DestinationItemType = gclass139_0_1.DestinationItemType;
            gclass139.DestinationID = gclass139_0_1.DestinationID;
            gclass139.Population = gclass139_0_1.Population;
            gclass139.MoveActionType = gclass139_0_1.MoveActionType;
            gclass139.NewSystem = gclass139_0_1.NewSystem;
            gclass139.NewJumpPoint = gclass139_0_1.NewJumpPoint;
            gclass139.MaxItems = gclass139_0_1.MaxItems;
            gclass139.MinDistance = gclass139_0_1.MinDistance;
            gclass139.MinQuantity = gclass139_0_1.MinQuantity;
            gclass139.Delay = gclass139_0_1.Delay;
            gclass139.DelayRemaining = gclass139_0_1.Delay;
            gclass139.OrbDistance = gclass139_0_1.OrbDistance;
            gclass139.bLoadSubUnits = gclass139_0_1.bLoadSubUnits;
            gclass139.SurveyPointsRequired = gclass139_0_1.SurveyPointsRequired;
            gclass139.DestinationItemID = gclass139_0_1.DestinationItemID;
            gclass139.MessageText = gclass139_0_1.MessageText;
            gclass139.Description = gclass139_0_1.Description;
            this.MoveOrderDictionary.Add(gclass139.MoveOrderID, gclass139);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 791);
        }
    }

    public bool method_35()
    {
        try
        {
            return this.MoveOrderDictionary.Values.Where<MoveOrder>(gclass139_0 =>
                gclass139_0.MoveActionType.MoveActionType == MoveActionType.ProvideGroundSupport ||
                gclass139_0.MoveActionType.MoveActionType == MoveActionType.ProvideGroundCap ||
                gclass139_0.MoveActionType.MoveActionType == MoveActionType.PlanetaryFlakSuppression ||
                gclass139_0.MoveActionType.MoveActionType == MoveActionType.PlanetarySearchAndDestroy).Count<MoveOrder>() > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 792);
            return false;
        }
    }

    public bool method_36()
    {
        try
        {
            return this.MoveOrderDictionary.Values.Where<MoveOrder>(gclass139_0 =>
                gclass139_0.MoveActionType.MoveActionType == MoveActionType.ProvideGroundCap ||
                gclass139_0.MoveActionType.MoveActionType == MoveActionType.PlanetaryFlakSuppression ||
                gclass139_0.MoveActionType.MoveActionType == MoveActionType.PlanetarySearchAndDestroy).Count<MoveOrder>() > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 792);
            return false;
        }
    }

    public Decimal method_37()
    {
        try
        {
            return this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0 == this)
                .Max<ShipData>(gclass40_0 => gclass40_0.Class.Size);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 793);
            return 0M;
        }
    }

    public void method_38(AuroraRefuelStatus auroraRefuelStatus_0)
    {
        try
        {
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.gclass85_0 == this && gclass40_0.Class.FuelTanker == 1)
                         .ToList<ShipData>())
                gclass40.auroraRefuelStatus_0 = auroraRefuelStatus_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 794);
        }
    }

    public void method_39(AuroraResupplyStatus auroraResupplyStatus_0)
    {
        try
        {
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.gclass85_0 == this && gclass40_0.Class.SupplyShip == 1)
                         .ToList<ShipData>())
                gclass40.auroraResupplyStatus_0 = auroraResupplyStatus_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 795);
        }
    }

    public void method_40(
        AuroraOrdnanceTransferStatus auroraOrdnanceTransferStatus_0)
    {
        try
        {
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.gclass85_0 == this && gclass40_0.Class.Collier == 1).ToList<ShipData>())
                gclass40.auroraOrdnanceTransferStatus_0 = auroraOrdnanceTransferStatus_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 796);
        }
    }

    public int method_41()
    {
        try
        {
            if (this.gclass0_0.Contacts.Values
                    .Where<Contact>(gclass65_1 => gclass65_1.System == this.System.ActualSystem)
                    .Where<Contact>(gclass65_1 =>
                        gclass65_1.method_5() == AuroraContactStatus.Hostile &&
                        gclass65_1.DetectRace == this.Race && gclass65_1.LastUpdate == this.gclass0_0.GameTime)
                    .Count<Contact>() == 0)
                return 0;
            List<ShipData> source = this.method_176();
            return (int)((1M - source.Sum<ShipData>(gclass40_0 => gclass40_0.decimal_16) /
                source.Count<ShipData>() / 500M) * (1M - this.method_254()) * AuroraUtils.int_43);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 797);
            return 0;
        }
    }

    public bool method_42(MoveActionType genum123_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class924 class924 = new FleetData.Class924();
        // ISSUE: reference to a compiler-generated field
        class924.genum123_0 = genum123_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            return this.MoveOrderDictionary.Values.FirstOrDefault<MoveOrder>(class924.method_0) != null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 798);
            return false;
        }
    }

    public void method_43()
    {
        try
        {
            foreach (ShipData gclass40 in this.method_176())
                gclass40.method_94();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 799);
        }
    }

    public void method_44()
    {
        try
        {
            foreach (ShipData gclass40 in this.method_176())
                gclass40.method_109();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 800);
        }
    }

    public bool method_45()
    {
        try
        {
            return this.method_176().Where<ShipData>(gclass40_0 => gclass40_0.genum29_0 == GEnum29.const_1)
                .Count<ShipData>() > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 801);
            return false;
        }
    }

    public bool method_46()
    {
        try
        {
            return this.gclass0_0.dictionary_32.Values.Where<ShipyardTask>(gclass192_0 => gclass192_0.gclass40_0 != null)
                .Where<ShipyardTask>(gclass192_0 => gclass192_0.gclass40_0.gclass85_0 == this).Count<ShipyardTask>() > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3231);
            return false;
        }
    }

    public bool method_47()
    {
        try
        {
            return this.gclass0_0.dictionary_32.Values
                .Where<ShipyardTask>(gclass192_0 => gclass192_0.gclass193_0.ParentShip != null)
                .Where<ShipyardTask>(gclass192_0 => gclass192_0.gclass193_0.ParentShip.gclass85_0 == this)
                .Count<ShipyardTask>() > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3549);
            return false;
        }
    }

    public void method_48(MoveOrder gclass139_0)
    {
        try
        {
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0 == this)
                         .Where<ShipData>(gclass40_0 => gclass40_0.gclass40_2 != null).ToList<ShipData>())
            {
                gclass40.gclass40_2.gclass40_3 = null;
                gclass40.gclass40_2.gclass84_0 = null;
                if (gclass139_0.DestinationType == DestinationType.const_7)
                {
                    if (this.gclass0_0.FleetDictionary.ContainsKey(gclass139_0.DestinationID))
                    {
                        gclass40.gclass40_2.method_185(this.gclass0_0.FleetDictionary[gclass139_0.DestinationID], true, false,
                            false, true);
                        gclass40.gclass85_0.OrbitingBody = this.gclass0_0.FleetDictionary[gclass139_0.DestinationID].OrbitingBody;
                    }
                    else
                        gclass40.gclass85_0.method_75(gclass40.gclass40_2, OperationalGroupID.None, false);
                }
                else
                    gclass40.gclass85_0.method_75(gclass40.gclass40_2, OperationalGroupID.None, false).AssignedPopulation =
                        gclass40.gclass85_0.AssignedPopulation;

                gclass40.gclass40_2 = null;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 802);
        }
    }

    public void method_49(MoveOrder gclass139_0)
    {
        try
        {
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0 == this)
                         .Where<ShipData>(gclass40_0 => gclass40_0.TractorTargetShipyard != null).ToList<ShipData>())
            {
                gclass40.TractorTargetShipyard.Population = gclass139_0.Population;
                gclass40.TractorTargetShipyard.TractorParentShip = null;
                gclass40.TractorTargetShipyard.XCor = 0.0;
                gclass40.TractorTargetShipyard.YCor = 0.0;
                gclass40.TractorTargetShipyard = null;
                gclass40.gclass85_0.OrbitingBody = gclass139_0.Population.SystemBodyData;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 803);
        }
    }

    public void method_50(MoveOrder gclass139_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class925 class925 = new FleetData.Class925();
        // ISSUE: reference to a compiler-generated field
        class925.gclass139_0 = gclass139_0;
        // ISSUE: reference to a compiler-generated field
        class925.gclass85_0 = this;
        try
        {
            List<ShipData> list1 = this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass40_2 != null).ToList<ShipData>();
            List<ShipData> list2 = list1.Select<ShipData, ShipData>(gclass40_0 => gclass40_0.gclass40_2)
                .ToList<ShipData>();
            // ISSUE: reference to a compiler-generated method
            ShipData gclass40_1 = this.gclass0_0.Ships.Values
                .Where<ShipData>(class925.method_0).Except<ShipData>(list2).Except<ShipData>(list1)
                .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.Class.Size)
                .FirstOrDefault<ShipData>();
            // ISSUE: reference to a compiler-generated field
            if (class925.gclass139_0.MoveActionType.MoveActionType == MoveActionType.TractorSpecifiedShip)
            {
                // ISSUE: reference to a compiler-generated method
                gclass40_1 =
                    this.gclass0_0.Ships.Values.FirstOrDefault<ShipData>(class925.method_1);
            }

            if (gclass40_1 == null)
            {
                // ISSUE: reference to a compiler-generated field
                if (class925.gclass139_0.MoveActionType.MoveActionType == MoveActionType.TractorSpecifiedShip)
                {
                    this.gclass0_0.gclass92_0.method_2(EventType.const_24,
                        string.Format((string)"{0} cannot complete tractor order as the target ship does not exist.",
                            (object)this.FleetName),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    if (class925.gclass139_0.MoveActionType.MoveActionType != MoveActionType.TractorAnyShipInFleet)
                        return;
                    this.gclass0_0.gclass92_0.method_2(EventType.const_24,
                        string.Format(
                            (string)"{0} cannot complete tractor order as the target fleet does not contain any ships.",
                            (object)this.FleetName),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
                }
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                if (gclass40_1.gclass85_0.FleetID != class925.gclass139_0.DestinationID)
                    this.gclass0_0.gclass92_0.method_2(EventType.const_24,
                        string.Format(
                            (string)
                            "{0} cannot complete tractor order as the destination fleet does not contain the target ship.",
                            (object)this.FleetName),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
                else if (list2.Contains(gclass40_1))
                    this.gclass0_0.gclass92_0.method_2(EventType.const_24,
                        string.Format(
                            (string)
                            "{0} cannot complete tractor order as the target ship is already linked by a tractor beam.",
                            (object)this.FleetName),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
                else if (list1.Contains(gclass40_1))
                {
                    this.gclass0_0.gclass92_0.method_2(EventType.const_24,
                        string.Format(
                            (string)
                            "{0} cannot complete tractor order as the target ship is already linked by a tractor beam.",
                            (object)this.FleetName),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
                }
                else
                {
                    // ISSUE: reference to a compiler-generated method
                    ShipData gclass40_2 = this.gclass0_0.Ships.Values
                        .Where<ShipData>(class925.method_2).Except<ShipData>(list1)
                        .Except<ShipData>(list2)
                        .Where<ShipData>(gclass40_0 =>
                            gclass40_0.method_157(AuroraComponentType.TractorBeam, false) > 0M &&
                            gclass40_0.gclass40_2 == null && gclass40_0.TractorTargetShipyard == null &&
                            gclass40_0.gclass40_3 == null)
                        .OrderByDescending<ShipData, Decimal>(gclass40_0 =>
                            gclass40_0.method_157(AuroraComponentType.Engine, false)).FirstOrDefault<ShipData>();
                    if (gclass40_2 == null)
                    {
                        this.gclass0_0.gclass92_0.method_2(EventType.const_24,
                            string.Format(
                                (string)
                                "{0} cannot complete tractor order as the fleet does not contain any ship eligible to establish a tractor link.",
                                (object)this.FleetName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                    }
                    else
                    {
                        gclass40_2.gclass40_2 = gclass40_1;
                        gclass40_1.gclass40_3 = gclass40_2;
                        gclass40_1.gclass84_0 = gclass40_2.gclass84_0;
                        gclass40_1.method_185(this, true, true, false, true);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 804);
        }
    }

    public void method_51(MoveOrder gclass139_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class926 class926 = new FleetData.Class926();
        // ISSUE: reference to a compiler-generated field
        class926.gclass139_0 = gclass139_0;
        // ISSUE: reference to a compiler-generated field
        class926.gclass85_0 = this;
        try
        {
            // ISSUE: reference to a compiler-generated method
            Shipyard gclass193 = this.gclass0_0.Shipyards.Values.FirstOrDefault<Shipyard>(class926.method_0);
            if (gclass193 == null)
            {
                this.gclass0_0.gclass92_0.method_2(EventType.const_24,
                    string.Format((string)"{0} cannot complete tractor order as the target shipyard does not exist.",
                        (object)this.FleetName),
                    this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                    AuroraEventCategory.Fleet);
            }
            else
            {
                // ISSUE: reference to a compiler-generated method
                ShipData gclass40 = this.gclass0_0.Ships.Values
                    .Where<ShipData>(class926.method_1)
                    .Where<ShipData>(gclass40_0 =>
                        gclass40_0.method_157(AuroraComponentType.TractorBeam, false) > 0M &&
                        gclass40_0.gclass40_2 == null && gclass40_0.TractorTargetShipyard == null &&
                        gclass40_0.gclass40_3 == null)
                    .OrderByDescending<ShipData, Decimal>(gclass40_0 =>
                        gclass40_0.method_157(AuroraComponentType.Engine, false)).FirstOrDefault<ShipData>();
                if (gclass40 == null)
                {
                    this.gclass0_0.gclass92_0.method_2(EventType.const_24,
                        string.Format(
                            (string)
                            "{0} cannot complete tractor order as the fleet does not contain any ship eligible to establish a tractor link.",
                            (object)this.FleetName),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
                }
                else
                {
                    gclass40.TractorTargetShipyard = gclass193;
                    gclass193.Population = null;
                    gclass193.TractorParentShip = gclass40;
                    gclass193.RequiredBP = 0M;
                    gclass193.CompletedBP = 0M;
                    gclass193.TaskType = AuroraShipyardUpgradeType.None;
                    gclass193.XCor = gclass40.gclass85_0.XCoord;
                    gclass193.YCor = gclass40.gclass85_0.YCoord;
                    gclass40.gclass85_0.Speed = gclass40.gclass85_0.method_195();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 805);
        }
    }

    public bool method_52(double double_11, double double_12)
    {
        try
        {
            return Math.Abs(this.XCoord - double_11) < 1.0 && Math.Abs(this.YCoord - double_12) < 1.0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 806);
            return false;
        }
    }

    public bool method_53(double double_11, double double_12, RacialSystemSurvey gclass202_1)
    {
        try
        {
            return Math.Abs(this.XCoord - double_11) < 1.0 && Math.Abs(this.YCoord - double_12) < 1.0 &&
                   this.System == gclass202_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 807);
            return false;
        }
    }

    public bool method_54(MoveOrder gclass139_0)
    {
        try
        {
            if (!this.gclass0_0.FleetDictionary.ContainsKey(gclass139_0.DestinationID))
            {
                this.gclass0_0.gclass92_0.method_2(EventType.const_24,
                    string.Format(
                        (string)
                        "{0} cannot complete order as the destination fleet does not exist. Current orders have been rescinded.",
                        (object)this.FleetName),
                    this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                    AuroraEventCategory.Fleet);
                foreach (MoveOrder gclass139 in this.MoveOrderDictionary.Values)
                    gclass139.bool_2 = true;
                return false;
            }

            if (!this.gclass0_0.FleetDictionary[gclass139_0.DestinationID].bool_21 &&
                this.gclass0_0.FleetDictionary[gclass139_0.DestinationID].MoveOrderDictionary.Count <= 0)
                return true;
            this.gclass0_0.gclass92_0.method_2(EventType.const_24,
                string.Format(
                    (string)
                    "{0} cannot complete order as the destination fleet is either moving or has movement orders. Current orders have been rescinded.",
                    (object)this.FleetName),
                this.Race, this.System.ActualSystem, this.XCoord, this.YCoord, AuroraEventCategory.Fleet);
            foreach (MoveOrder gclass139 in this.MoveOrderDictionary.Values)
                gclass139.bool_2 = true;
            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 808);
            return false;
        }
    }

    public void method_55(MoveOrder gclass139_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class927 class927 = new FleetData.Class927();
        // ISSUE: reference to a compiler-generated field
        class927.gclass139_0 = gclass139_0;
        try
        {
            List<ShipData> list = this.method_176().Where<ShipData>(gclass40_0 => gclass40_0.SurvivorsList.Count > 0)
                .ToList<ShipData>();
            if (list.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated method
            ShipData gclass40_4 =
                this.gclass0_0.Ships.Values.FirstOrDefault<ShipData>(class927.method_0);
            if (gclass40_4 == null)
                return;
            foreach (ShipData gclass40 in list)
                gclass40.method_117(gclass40_4);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3819);
        }
    }

    public void method_56(MoveOrder gclass139_0)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            FleetData.Class928 class928 = new FleetData.Class928();
            if (!this.gclass0_0.LifePods.ContainsKey(gclass139_0.DestinationID))
                return;
            // ISSUE: reference to a compiler-generated field
            class928.gclass59_0 = this.gclass0_0.LifePods[gclass139_0.DestinationID];
            // ISSUE: reference to a compiler-generated field
            if (class928.gclass59_0.gclass21_0 == this.Race)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.gclass0_0.gclass92_0.method_2(EventType.const_60,
                    string.Format((string)"{0} survivors rescued by {1} from {2} life pods",
                        (object)class928.gclass59_0.int_1.ToString(), (object)this.FleetName,
                        (object)class928.gclass59_0.string_0),
                    this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                    AuroraEventCategory.Fleet);
                // ISSUE: reference to a compiler-generated field
                this.Race.method_292(class928.gclass59_0);
                // ISSUE: reference to a compiler-generated method
                foreach (Commander gclass55 in this.gclass0_0.ActiveCommanders.Values.Where<Commander>(class928.method_0)
                             .ToList<Commander>())
                {
                    // ISSUE: reference to a compiler-generated field
                    this.gclass0_0.gclass92_0.method_2(EventType.const_60,
                        string.Format((string)"{0} rescued by {1} from {2} life pods", (object)gclass55.method_36(),
                            (object)this.FleetName, (object)class928.gclass59_0.string_0),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
                    gclass55.method_40(false);
                    gclass55.AddHistory(string.Format((string)"Rescued from life pod in {0}", (object)this.System.Name), HistoryType.Personal);
                    gclass55.TransportShip = null;
                }

                // ISSUE: reference to a compiler-generated field
                this.gclass0_0.LifePods.Remove(class928.gclass59_0.int_0);
            }
            else
            {
                List<ShipData> source = this.method_176();
                if (source.Count == 0)
                    return;
                foreach (ShipData gclass40 in source)
                    gclass40.decimal_38 = gclass40.method_121();
                ShipData gclass40_1 = source
                    .OrderByDescending<ShipData, int>(gclass40_0 => gclass40_0.method_122())
                    .ThenByDescending<ShipData, Decimal>(gclass40_0 =>
                        gclass40_0.Class.Crew - gclass40_0.decimal_38).ToList<ShipData>()[0];
                // ISSUE: reference to a compiler-generated method
                Survivors gclass180 = gclass40_1.SurvivorsList.FirstOrDefault<Survivors>(class928.method_1);
                if (gclass180 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    gclass180.Crew += class928.gclass59_0.int_1;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass40_1.SurvivorsList.Add(new Survivors()
                    {
                        Ship = gclass40_1,
                        Crew = class928.gclass59_0.int_1,
                        Race = class928.gclass59_0.gclass21_0,
                        Species = class928.gclass59_0.gclass194_0
                    });
                }

                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                AlienRaceIntel gclass110_1 = this.Race.method_325(class928.gclass59_0.gclass21_0.RaceID) ??
                                        this.Race.method_51(class928.gclass59_0.gclass21_0, this.System,
                                            this.XCoord, this.YCoord);
                gclass110_1.bPortraitShown = true;
                // ISSUE: reference to a compiler-generated field
                this.Race.method_163(gclass110_1, class928.gclass59_0.gclass194_0, GEnum25.const_0);
                // ISSUE: reference to a compiler-generated method
                foreach (Commander gclass55 in this.gclass0_0.ActiveCommanders.Values.Where<Commander>(class928.method_2)
                             .ToList<Commander>())
                {
                    gclass55.AddHistory(string.Format((string)"Captured by {0}", (object)gclass110_1.AlienRaceName), HistoryType.Personal);
                    gclass55.method_40(true);
                    gclass55.TransportShip = gclass40_1;
                    gclass55.Prisoner = true;
                    gclass55.Processed = false;
                }

                if (this.Race.SpecialNPRID == SpecialNPRIDs.Eldar)
                {
                    // ISSUE: reference to a compiler-generated field
                    this.System.RaidRating += class928.gclass59_0.int_1;
                }

                // ISSUE: reference to a compiler-generated field
                this.gclass0_0.LifePods.Remove(class928.gclass59_0.int_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 809);
        }
    }

    public void method_57(bool bool_25)
    {
        try
        {
            foreach (ShipData gclass40 in this.method_176())
            {
                gclass40.bool_10 = bool_25;
                if (!gclass40.bool_10)
                    gclass40.decimal_3 = 0M;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 810);
        }
    }

    public void method_58(MoveOrder gclass139_0)
    {
        try
        {
            if (gclass139_0.Population == null ||
                !this.gclass0_0.Populations.ContainsKey(gclass139_0.Population.PopulationID))
                return;
            PopulationData gclass146_0 = this.gclass0_0.Populations[gclass139_0.Population.PopulationID];
            foreach (ShipData gclass40 in this.method_176())
                gclass40.method_116(gclass146_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 811);
        }
    }

    public void method_59(GEnum78 genum78_0)
    {
        try
        {
            foreach (ShipData gclass40 in this.method_176())
                gclass40.genum78_0 = genum78_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 812);
        }
    }

    public void method_60(bool bool_25)
    {
        try
        {
            foreach (ShipData gclass40 in this.method_176())
                gclass40.bool_8 = bool_25;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 813);
        }
    }

    public void method_61(LagrangePoint gclass212_0)
    {
        try
        {
            this.XCoord = gclass212_0.XCor;
            this.YCoord = gclass212_0.Ycor;
            this.LastXCoord = this.XCoord;
            this.LastYCoord = this.YCoord;
            this.IncrementStartX = this.XCoord;
            this.IncrementStartY = this.YCoord;
            this.LastMoveTime = this.gclass0_0.GameTime;
            this.gclass0_0.method_49(this);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 814);
        }
    }

    public bool method_62(MoveOrder gclass139_0)
    {
        try
        {
            if (gclass139_0.Fleet.Race.NPR)
                this.method_200(gclass139_0);
            int num = this.method_248(gclass139_0.MoveActionType.MoveActionType,
                this.gclass0_0.JumpPointDictionary[gclass139_0.DestinationID]);
            if (num <= 0)
                return false;
            this.gclass0_0.method_167(this, this.gclass0_0.JumpPointDictionary[gclass139_0.DestinationID]);
            if (gclass139_0.NewSystem == null)
                this.gclass0_0.method_639(gclass139_0, null, false, false);
            this.XCoord = this.gclass0_0.JumpPointDictionary[gclass139_0.DestinationID].LinkedJumpPoint.XCoord;
            this.YCoord = this.gclass0_0.JumpPointDictionary[gclass139_0.DestinationID].LinkedJumpPoint.YCoord;
            this.System = gclass139_0.NewSystem;
            this.gclass0_0.method_167(this, this.gclass0_0.JumpPointDictionary[gclass139_0.DestinationID].LinkedJumpPoint);
            if (gclass139_0.MoveActionType.MoveActionType == MoveActionType.SquadronTransit)
            {
                double double_11 = AuroraUtils.GetRandomInteger(360);
                GClass221 gclass221 = this.gclass0_0.method_592(this.XCoord, this.YCoord,
                    AuroraUtils.GetRandomInteger(num * 1000), double_11);
                this.XCoord = gclass221.double_0;
                this.YCoord = gclass221.double_1;
            }

            this.method_243(gclass139_0.MoveActionType.MoveActionType);
            this.LastXCoord = this.XCoord;
            this.LastYCoord = this.YCoord;
            this.IncrementStartX = this.XCoord;
            this.IncrementStartY = this.YCoord;
            this.EntryJumpPoint = this.gclass0_0.JumpPointDictionary[gclass139_0.DestinationID].LinkedJumpPoint;
            this.LastMoveTime = this.gclass0_0.GameTime;
            this.LastTransitTime = this.gclass0_0.GameTime;
            this.gclass0_0.method_49(this);
            gclass139_0.bool_2 = true;
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 815);
            return false;
        }
    }

    public void method_63(Decimal decimal_9)
    {
        try
        {
            double double_11 = AuroraUtils.GetRandomInteger(360);
            GClass221 gclass221 = this.gclass0_0.method_592(this.XCoord, this.YCoord,
                AuroraUtils.smethod_14(decimal_9), double_11);
            this.XCoord = gclass221.double_0;
            this.YCoord = gclass221.double_1;
            this.method_243(MoveActionType.SquadronTransit);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3965);
        }
    }

    public bool method_64(AetherGate gclass210_0, bool bool_25)
    {
        try
        {
            List<ShipData> gclass40List = this.method_176();
            foreach (ShipData gclass40 in gclass40List)
            {
                if (gclass40.Class.Commercial)
                    gclass210_0.double_2 += (double)(gclass40.Class.Size * 5M);
                else
                    gclass210_0.double_2 += (double)(gclass40.Class.Size * 50M);
            }

            if (bool_25)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class929 class929 = new FleetData.Class929();
                // ISSUE: reference to a compiler-generated field
                class929.gclass202_0 = this.System;
                this.XCoord = 0.0;
                this.YCoord = 0.0;
                this.System = this.Race.method_190();
                // ISSUE: reference to a compiler-generated method
                if (this.gclass0_0.FleetDictionary.Values.Count<FleetData>(class929.method_0) == 0)
                    this.gclass0_0.dictionary_16.Remove(gclass210_0.int_0);
                foreach (ShipData gclass40 in gclass40List)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    FleetData.Class930 class930 = new FleetData.Class930();
                    // ISSUE: reference to a compiler-generated field
                    class930.gclass40_0 = gclass40;
                    // ISSUE: reference to a compiler-generated field
                    class930.gclass40_0.ArmorDamages.Clear();
                    // ISSUE: reference to a compiler-generated field
                    class930.gclass40_0.ComponentDamages.Clear();
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class930.gclass40_0.decimal_14 = class930.gclass40_0.Class.FuelCapacity;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class930.gclass40_0.decimal_4 = class930.gclass40_0.Class.MaintSupplies;
                    // ISSUE: reference to a compiler-generated field
                    class930.gclass40_0.method_62(true);
                    // ISSUE: reference to a compiler-generated field
                    class930.gclass40_0.TransportedTradeGoods.Clear();
                    // ISSUE: reference to a compiler-generated field
                    class930.gclass40_0.TransportedMineral.ResetToZero();
                    // ISSUE: reference to a compiler-generated field
                    class930.gclass40_0.TransportedComponents.Clear();
                    // ISSUE: reference to a compiler-generated field
                    class930.gclass40_0.TransportedColonists.Clear();
                    // ISSUE: reference to a compiler-generated field
                    class930.gclass40_0.SurvivorsList.Clear();
                    // ISSUE: reference to a compiler-generated field
                    class930.gclass40_0.TransportedInstallations.Clear();
                    // ISSUE: reference to a compiler-generated method
                    foreach (GroundUnitFormationData gclass103 in this.gclass0_0.FormationDictionary.Values
                                 .Where<GroundUnitFormationData>(class930.method_0).ToList<GroundUnitFormationData>())
                        this.gclass0_0.FormationDictionary.Remove(gclass103.FormationID);
                    // ISSUE: reference to a compiler-generated field
                    if (class930.gclass40_0.Class.AutomatedClassDesign.AutomatedClassDesignTypeID == AutomatedClassDesignType.EldarTroopTransport)
                    {
                        Species gclass194_1 = this.Race.method_164();
                        GroundUnitFormationTemplateData gclass102_0_1 = this.gclass0_0.FormationTemplateRecordDic.Values.First<GroundUnitFormationTemplateData>(
                            gclass102_0 => gclass102_0.RaceData == this.Race &&
                                           gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.EldarAssaultForce);
                        if (gclass102_0_1 != null)
                        {
                            Decimal num1 = gclass102_0_1.method_9();
                            // ISSUE: reference to a compiler-generated field
                            int num2 = (int)Math.Floor(class930.gclass40_0.method_211() / num1);
                            for (int index = 1; index <= num2; ++index)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                this.Race.method_158(
                                    string.Format((string)"{0} Assault Group #{1}",
                                        (object)class930.gclass40_0.method_187(), (object)index.ToString()),
                                    gclass102_0_1.Abbreviation, gclass102_0_1, null, class930.gclass40_0, gclass194_1, null,
                                    0, AuroraGroundFormationFieldPosition.FrontlineDefence);
                            }
                        }
                    }
                }
            }
            else
            {
                this.XCoord = gclass210_0.double_0;
                this.YCoord = gclass210_0.double_1;
                this.System = this.Race.method_128(gclass210_0.gclass200_0);
                this.method_243(MoveActionType.StandardTransit);
            }

            this.LastXCoord = this.XCoord;
            this.LastYCoord = this.YCoord;
            this.IncrementStartX = this.XCoord;
            this.IncrementStartY = this.YCoord;
            this.LastMoveTime = this.gclass0_0.GameTime;
            this.LastTransitTime = this.gclass0_0.GameTime;
            this.NPRSomething.int_0 = 0;
            this.gclass0_0.method_49(this);
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3409);
            return false;
        }
    }

    public void method_65(int int_12, TreeNode treeNode_0)
    {
        try
        {
            foreach (ShipData gclass40 in this.method_176()
                         .Where<ShipData>(gclass40_0 => gclass40_0.Class.ProtectionValue > 0M)
                         .ToList<ShipData>())
                gclass40.int_17 = int_12;
            foreach (TreeNode node in treeNode_0.Nodes)
            {
                if (node.Tag is ShipData)
                {
                    ShipData tag = (ShipData)node.Tag;
                    node.Text = tag.method_187();
                    if (tag.int_17 == 1)
                        node.Text += "  (SF)";
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 816);
        }
    }

    public void method_66()
    {
        try
        {
            foreach (ShipData gclass40_0 in this.method_176())
            {
                if (gclass40_0.gclass40_0 == null)
                {
                    FleetData gclass85 = this.method_75(gclass40_0, OperationalGroupID.None, true);
                    gclass85.bAvoidAlienSystem = this.bAvoidAlienSystem;
                    gclass85.bAvoidDanger = this.bAvoidDanger;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 817);
        }
    }

    public bool method_67(MoveOrder gclass139_0, bool bool_25)
    {
        try
        {
            if (!this.gclass0_0.FleetDictionary.ContainsKey(gclass139_0.DestinationID))
                return false;
            FleetData gclass85_1 = this.gclass0_0.FleetDictionary[gclass139_0.DestinationID];
            List<ShipData> gclass40List1 = gclass85_1.method_176();
            List<ShipData> gclass40List2 = this.method_176();
            this.gclass85_3 = gclass85_1;
            SubFleet gclass84 = null;
            if (bool_25)
            {
                gclass84 = gclass85_1.method_89(this.FleetName);
                gclass84.AnchorFleet = this.AnchorFleet;
                gclass84.gclass117_0 = this.gclass117_0;
                gclass84.AnchorFleetBearingOffset = this.AnchorFleetBearingOffset;
                gclass84.AnchorFleetDistance = this.AnchorFleetDistance;
                gclass84.bGuardNearestHostileContact = this.bGuardNearestHostileContact;
                gclass84.bGuardNearestKnownWarship = this.bGuardNearestKnownWarship;
                gclass84.bUseAnchorDestination = this.bUseAnchorDestination;
            }

            foreach (ShipData gclass40 in gclass40List2)
            {
                if (gclass40.gclass40_0 == null)
                {
                    if (gclass40List1.Contains(gclass40.gclass40_1))
                    {
                        if (gclass40.gclass40_1.method_125() >= gclass40.Class.Size)
                        {
                            gclass40.gclass40_0 = gclass40.gclass40_1;
                            gclass40.gclass84_0 = gclass40.gclass40_0.gclass84_0;
                            gclass40.method_185(gclass85_1, false, true, false, true);
                            gclass40.gclass84_0 = gclass84;
                            if (gclass40.LinkedSquadronID > 0 &&
                                gclass40.gclass40_0.ChildSquadronDictionary.ContainsKey(gclass40.LinkedSquadronID))
                                gclass40.SquadronData =
                                    gclass40.gclass40_0.ChildSquadronDictionary[gclass40.LinkedSquadronID];
                            gclass40.method_117(gclass40.gclass40_1);
                        }
                        else
                            this.gclass0_0.gclass92_0.method_2(EventType.const_29,
                                string.Format(
                                    (string)
                                    "{0} ({1}) is unable to land as the mothership has insufficient hangar space",
                                    (object)gclass40.ShipName, (object)this.FleetName),
                                this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                                AuroraEventCategory.Fleet);
                    }
                    else
                        this.gclass0_0.gclass92_0.method_2(EventType.const_29,
                            string.Format(
                                (string)
                                "{0} ({1}) is unable to land as the destination fleet does not contain its assigned mothership",
                                (object)gclass40.ShipName, (object)this.FleetName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                }
            }

            this.Speed = this.method_195();
            gclass85_1.Speed = gclass85_1.method_195();
            return this.method_176().Count == 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 818);
            return false;
        }
    }

    public void method_68()
    {
        try
        {
            foreach (ShipData gclass40 in this.method_176())
            {
                if (gclass40.gclass40_0 == null)
                {
                    if (gclass40.Class.Commercial)
                    {
                        this.gclass0_0.gclass92_0.method_2(EventType.const_88,
                            string.Format(
                                (string)"{0} ({1}) cannot be overhauled as it is classed as a commercial vessel",
                                (object)gclass40.ShipName, (object)this.FleetName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                    }
                    else
                    {
                        gclass40.genum29_0 = GEnum29.const_1;
                        gclass40.decimal_3 = 0M;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 819);
        }
    }

    public bool method_69(MoveOrder gclass139_0, bool bool_25, bool bool_26)
    {
        try
        {
            if (!this.gclass0_0.FleetDictionary.ContainsKey(gclass139_0.DestinationID))
                return false;
            FleetData gclass85_1 = this.gclass0_0.FleetDictionary[gclass139_0.DestinationID];
            List<ShipData> source = gclass85_1.method_176();
            this.gclass85_3 = gclass85_1;
            if (!bool_26 && !source.Contains(this.gclass0_0.Ships[gclass139_0.DestinationItemID]))
            {
                this.gclass0_0.gclass92_0.method_2(EventType.const_29,
                    string.Format(
                        (string)
                        "{0} is unable to land as the destination fleet does not contain the specified mothership",
                        (object)this.FleetName),
                    this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                    AuroraEventCategory.Fleet);
                return false;
            }

            FCTSquadronData70 gclass70 = null;
            ShipData gclass400;
            if (bool_26)
            {
                Dictionary<int, FCTSquadronData70> dictionary = source
                    .SelectMany<ShipData,
                        KeyValuePair<int, FCTSquadronData70>>(gclass40_0 => gclass40_0.ChildSquadronDictionary)
                    .ToDictionary<KeyValuePair<int, FCTSquadronData70>, int, FCTSquadronData70>(
                        keyValuePair_0 => keyValuePair_0.Key, keyValuePair_0 => keyValuePair_0.Value);
                if (dictionary.ContainsKey(gclass139_0.DestinationItemID))
                {
                    gclass70 = dictionary[gclass139_0.DestinationItemID];
                    gclass400 = gclass70.ParentShipData;
                }
                else
                {
                    this.gclass0_0.gclass92_0.method_2(EventType.const_29,
                        string.Format((string)"{0} is unable to land as the destination squadron does not exist",
                            (object)this.FleetName),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
                    return false;
                }
            }
            else
                gclass400 = this.gclass0_0.Ships[gclass139_0.DestinationItemID];

            if (bool_25)
                gclass70 = gclass400.method_186(this.FleetName);
            foreach (ShipData gclass40 in this.method_176())
            {
                if (gclass400.method_125() >= gclass40.Class.Size)
                {
                    gclass40.gclass40_0 = gclass400;
                    gclass40.gclass84_0 = gclass40.gclass40_0.gclass84_0;
                    gclass40.method_185(gclass85_1, false, true, false, true);
                    gclass40.SquadronData = gclass70;
                    gclass40.LinkedSquadronID = gclass70 == null ? 0 : gclass70.SquadronID;
                    if (gclass139_0.MoveActionType.MoveActionType != MoveActionType.LandOnSpecifiedMothershipWithoutAssignment)
                        gclass40.gclass40_1 = gclass400;
                    gclass40.method_117(gclass400);
                }
                else
                    this.gclass0_0.gclass92_0.method_2(EventType.const_29,
                        string.Format(
                            (string)"{0} ({1}) is unable to land as the mothership has insufficient hangar space",
                            (object)gclass40.ShipName, (object)this.FleetName),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
            }

            this.Speed = this.method_195();
            gclass85_1.Speed = gclass85_1.method_195();
            return this.method_176().Count == 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 820);
            return false;
        }
    }

    public FleetData method_70(SubFleet gclass84_0, bool bool_25)
    {
        try
        {
            List<ShipData> list_22 = gclass84_0.method_0();
            OperationalGroupID genum105_0 = OperationalGroupID.None;
            if (this.NPROperationGroup != null)
                genum105_0 = this.NPROperationGroup.OperationalGroupId;
            FleetData gclass85 = this.Race.method_308(gclass84_0.SubFleetName, this.ParentNavalCommand, this.System,
                this.XCoord, this.YCoord, this.OrbitingBody, genum105_0);
            gclass85.AnchorFleet = gclass84_0.AnchorFleet;
            gclass85.gclass117_0 = gclass84_0.gclass117_0;
            gclass85.AnchorFleetBearingOffset = gclass84_0.AnchorFleetBearingOffset;
            gclass85.AnchorFleetDistance = gclass84_0.AnchorFleetDistance;
            gclass85.bGuardNearestHostileContact = gclass84_0.bGuardNearestHostileContact;
            gclass85.bGuardNearestKnownWarship = gclass84_0.bGuardNearestKnownWarship;
            gclass85.bUseAnchorDestination = gclass84_0.bUseAnchorDestination;
            if (this.bDetachedStanding || this.bDetachedCondition)
                gclass85.method_2(this, this.bDetachedStanding, this.bDetachedCondition);
            foreach (ShipData gclass40 in list_22)
            {
                gclass40.gclass84_0 = null;
                if (gclass40.SquadronData != null)
                {
                    gclass40.LinkedSquadronID = gclass40.SquadronData.SquadronID;
                    gclass40.SquadronData = null;
                }
            }

            this.Race.method_270(list_22, this, gclass85, bool_25, false);
            this.method_72(gclass84_0, gclass85);
            this.method_163(gclass84_0);
            return gclass85;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 821);
            return null;
        }
    }

    public FleetData method_71(FCTSquadronData70 gclass70_0, OperationalGroupID genum105_0)
    {
        try
        {
            List<ShipData> list_22 = gclass70_0.method_0();
            if (genum105_0 == OperationalGroupID.None && this.NPROperationGroup != null)
                genum105_0 = this.NPROperationGroup.OperationalGroupId;
            FleetData gclass85_1 = this.Race.method_308(gclass70_0.SquadronName, this.ParentNavalCommand, this.System,
                this.XCoord, this.YCoord, this.OrbitingBody, genum105_0);
            if ((this.bDetachedStanding || this.bDetachedCondition) && this.bIncludeSquadrons)
                gclass85_1.method_2(this, this.bDetachedStanding, this.bDetachedCondition);
            foreach (ShipData gclass40 in list_22)
            {
                if (gclass40.SquadronData != null)
                {
                    gclass40.LinkedSquadronID = gclass40.SquadronData.SquadronID;
                    gclass40.SquadronData = null;
                }

                gclass40.gclass84_0 = null;
                gclass40.gclass40_0 = null;
            }

            this.Race.method_270(list_22, this, gclass85_1, false, true);
            return gclass85_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3519);
            return null;
        }
    }

    private void method_72(SubFleet gclass84_0, FleetData gclass85_5)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class931 class931 = new FleetData.Class931();
        // ISSUE: reference to a compiler-generated field
        class931.gclass84_0 = gclass84_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            foreach (SubFleet gclass84 in this.gclass0_0.SubFleetDictionary.Values.Where<SubFleet>(class931.method_0)
                         .ToList<SubFleet>())
            {
                gclass84.ParentSubFleet = null;
                gclass84.ParentFleet = gclass85_5;
                gclass84.method_18(gclass85_5);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3220);
        }
    }

    public FleetData method_73(FleetData gclass85_5, SubFleet gclass84_0)
    {
        try
        {
            List<ShipData> list_22 = gclass85_5.method_176();
            foreach (ShipData gclass40 in list_22)
                gclass40.gclass84_0 = gclass84_0;
            this.Race.method_270(list_22, gclass85_5, this, true, false);
            this.gclass0_0.FleetDictionary.Remove(gclass85_5.FleetID);
            return this;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 822);
            return null;
        }
    }

    public FleetData method_74(GEnum110 genum110_0, int int_12, bool bool_25)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class932 class932 = new FleetData.Class932();
        // ISSUE: reference to a compiler-generated field
        class932.int_0 = int_12;
        try
        {
            List<ShipData> source = this.method_176();
            List<ShipData> list_22 = new List<ShipData>();
            OperationalGroupID genum105_0 = OperationalGroupID.None;
            string str = " - ";
            // ISSUE: reference to a compiler-generated field
            if (class932.int_0 == 0)
                str += "Non-";
            switch (genum110_0)
            {
                case GEnum110.const_0:
                    // ISSUE: reference to a compiler-generated method
                    list_22 = source.Where<ShipData>(class932.method_0).ToList<ShipData>();
                    str += "Tanker Detachment";
                    if (this.Race.NPR)
                    {
                        genum105_0 = OperationalGroupID.Tanker;
                        break;
                    }

                    break;
                case GEnum110.const_1:
                    // ISSUE: reference to a compiler-generated method
                    list_22 = source.Where<ShipData>(class932.method_1).ToList<ShipData>();
                    str += "Collier Detachment";
                    if (this.Race.NPR)
                    {
                        genum105_0 = OperationalGroupID.Collier;
                        break;
                    }

                    break;
                case GEnum110.const_2:
                    // ISSUE: reference to a compiler-generated method
                    list_22 = source.Where<ShipData>(class932.method_2).ToList<ShipData>();
                    str += "Supply Ship Detachment";
                    break;
                case GEnum110.const_3:
                    // ISSUE: reference to a compiler-generated field
                    list_22 = class932.int_0 != 1
                        ? source.Where<ShipData>(gclass40_0 =>
                                gclass40_0.method_157(AuroraComponentType.GeologicalSurveySensors, false) == 0M &&
                                gclass40_0.method_157(AuroraComponentType.GravitationalSurveySensors, false) == 0M)
                            .ToList<ShipData>()
                        : source.Where<ShipData>(gclass40_0 =>
                                gclass40_0.method_157(AuroraComponentType.GeologicalSurveySensors, false) > 0M ||
                                gclass40_0.method_157(AuroraComponentType.GravitationalSurveySensors, false) > 0M)
                            .ToList<ShipData>();
                    str += "Survey Ship Detachment";
                    break;
            }

            if (list_22.Count == 0)
            {
                this.gclass0_0.gclass92_0.method_2(EventType.const_27,
                    string.Format((string)"{0} cannot carry out detachment order as no ships qualify for detachment",
                        (object)this.FleetName),
                    this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                    AuroraEventCategory.Fleet);
                return null;
            }

            if (list_22.Count == source.Count)
            {
                this.gclass0_0.gclass92_0.method_2(EventType.const_27,
                    string.Format((string)"{0} cannot carry out detachment order as no ships would remain in fleet",
                        (object)this.FleetName),
                    this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                    AuroraEventCategory.Fleet);
                return null;
            }

            FleetData gclass85_1 = this.Race.method_308(this.FleetName + str, this.ParentNavalCommand, this.System,
                this.XCoord, this.YCoord, this.OrbitingBody, genum105_0);
            foreach (ShipData gclass40 in list_22)
                gclass40.gclass84_0 = null;
            this.Race.method_270(list_22, this, gclass85_1, bool_25, false);
            return gclass85_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 823);
            return null;
        }
    }

    public FleetData method_75(ShipData gclass40_0, OperationalGroupID genum105_0, bool bool_25)
    {
        try
        {
            if (gclass40_0.Race.NPR && gclass40_0.gclass85_0.NPROperationGroup != null)
            {
                if (gclass40_0.gclass85_0.NPROperationGroup.OperationalGroupId != OperationalGroupID.BeamFighterSquadron &&
                    gclass40_0.gclass85_0.NPROperationGroup.OperationalGroupId != OperationalGroupID.MissileFighterSquadron)
                {
                    if (genum105_0 == OperationalGroupID.None)
                        genum105_0 = OperationalGroupID.ReinforcementGroup;
                }
                else
                    genum105_0 = gclass40_0.gclass85_0.NPROperationGroup.OperationalGroupId;
            }

            FleetData gclass85_1 = this.Race.method_308(gclass40_0.method_187(), this.ParentNavalCommand, this.System,
                this.XCoord, this.YCoord, this.OrbitingBody, genum105_0);
            gclass40_0.gclass84_0 = null;
            if (this.bDetachedStanding || this.bDetachedCondition)
                gclass85_1.method_2(this, this.bDetachedStanding, this.bDetachedCondition);
            gclass40_0.method_185(gclass85_1, true, bool_25, false, true);
            return gclass85_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 824);
            return null;
        }
    }

    public FleetData method_76(List<ShipData> list_4, OperationalGroupID genum105_0, bool bool_25)
    {
        try
        {
            if (genum105_0 == OperationalGroupID.None && this.Race.NPR)
                genum105_0 = OperationalGroupID.ReinforcementGroup;
            FleetData gclass85_1 = this.Race.method_308(string.Format((string)"{0} - Detached", (object)this.FleetName), this.ParentNavalCommand,
                this.System, this.XCoord, this.YCoord, this.OrbitingBody, genum105_0);
            if (this.bDetachedStanding || this.bDetachedCondition)
                gclass85_1.method_2(this, this.bDetachedStanding, this.bDetachedCondition);
            foreach (ShipData gclass40 in list_4)
            {
                gclass40.gclass84_0 = null;
                gclass40.method_185(gclass85_1, true, bool_25, false, true);
            }

            return gclass85_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 824);
            return null;
        }
    }

    public void method_77(MoveOrder gclass139_0)
    {
        try
        {
            if (!this.gclass0_0.JumpPointDictionary.ContainsKey(gclass139_0.DestinationID))
                return;
            JumpPoint gclass120_1 = this.gclass0_0.JumpPointDictionary[gclass139_0.DestinationID];
            gclass120_1.JumpGateRaceID = gclass139_0.Race.RaceID;
            gclass120_1.JumpGateStrength = 1000;
            this.method_16(AuroraMeasurementType.JPStablisationsCompleted, 1M);
            this.method_17(AuroraMeasurementType.JPStablisationsCompleted, null, gclass120_1, "");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 825);
        }
    }

    public ShipData method_78()
    {
        try
        {
            List<ShipData> source = this.method_176();
            ShipData gclass40 = this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0 == this)
                .Where<ShipData>(gclass40_0 => gclass40_0.method_157(AuroraComponentType.SalvageModule, true) > 0M)
                .OrderByDescending<ShipData, bool>(gclass40_0 =>
                    gclass40_0.method_157(AuroraComponentType.SalvageModule, true) > 0M)
                .FirstOrDefault<ShipData>();
            if (gclass40 == null)
            {
                if (this.Race.SpecialNPRID != SpecialNPRIDs.StarSwarm)
                    return null;
                gclass40 = source.Where<ShipData>(gclass40_0 => gclass40_0.Class.AutomatedClassDesign.HiveShipSizeClass > 0)
                    .OrderByDescending<ShipData, bool>(gclass40_0 => gclass40_0.Class.AutomatedClassDesign.HiveShipSizeClass > 0)
                    .FirstOrDefault<ShipData>();
            }

            return gclass40;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 826);
            return null;
        }
    }

    public void method_79(ShipComponent gclass230_0)
    {
        try
        {
            foreach (TechSystem gclass164 in gclass230_0.list_0)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                TechSystem gclass164_0_1 = this.gclass0_0.TechSystems.Values.Where<TechSystem>(
                        new FleetData.Class933()
                        {
                            gclass85_0 = this,
                            gclass164_0 = gclass164
                        }.method_0).OrderBy<TechSystem, int>(gclass164_0 => gclass164_0.int_4)
                    .FirstOrDefault<TechSystem>();
                if (gclass164_0_1 != null)
                {
                    int int_0 = (int)(gclass164_0_1.int_4 / 100.0 * AuroraUtils.GetRandomInteger(5));
                    this.Race.UnknownNprClass.method_22(gclass164_0_1, int_0);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 827);
        }
    }

    public void method_80(MoveOrder gclass139_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class934 class934 = new FleetData.Class934();
        // ISSUE: reference to a compiler-generated field
        class934.gclass139_0 = gclass139_0;
        // ISSUE: reference to a compiler-generated field
        class934.gclass85_0 = this;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            FleetData.Class935 class935 = new FleetData.Class935()
            {
                class934_0 = class934
            };
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            class935.gclass233_0 =
                this.gclass0_0.Wrecks.Values.FirstOrDefault<Wreck>(class935.class934_0.method_0);
            // ISSUE: reference to a compiler-generated field
            if (class935.gclass233_0 == null)
                return;
            GClass80 gclass80_0 = new GClass80();
            // ISSUE: reference to a compiler-generated field
            class935.gclass40_0 = this.method_78();
            // ISSUE: reference to a compiler-generated field
            if (class935.gclass40_0 == null)
                return;
            PopulationData gclass146_1 = this.Race.method_191();
            // ISSUE: reference to a compiler-generated method
            AlienShipClassIntel gclass115_1 = this.Race.dictionary_11.Values.FirstOrDefault<AlienShipClassIntel>(class935.method_0);
            if (gclass115_1 != null)
                gclass115_1.decimal_3 = gclass115_1.gclass22_0.Size;
            // ISSUE: reference to a compiler-generated field
            foreach (WreckTech gclass234 in class935.gclass233_0.ContainingTechs)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class936 class936 = new FleetData.Class936();
                // ISSUE: reference to a compiler-generated field
                class936.class935_0 = class935;
                // ISSUE: reference to a compiler-generated field
                class936.gclass234_0 = gclass234;
                // ISSUE: reference to a compiler-generated field
                if (!class936.gclass234_0.TechData.bool_0)
                {
                    TechSystem gclass164_0_1;
                    // ISSUE: reference to a compiler-generated field
                    if (class936.gclass234_0.TechData.gclass163_0.TechType == TechType.CommandandControl)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (!class936.gclass234_0.TechData.dictionary_0.ContainsKey(class936.class935_0.gclass40_0
                                .Race.RaceID))
                        {
                            // ISSUE: reference to a compiler-generated field
                            gclass164_0_1 = class936.gclass234_0.TechData;
                        }
                        else
                            continue;
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated method
                        gclass164_0_1 = this.gclass0_0.TechSystems.Values.Where<TechSystem>(class936.method_0)
                            .OrderBy<TechSystem, int>(gclass164_0 => gclass164_0.int_4).FirstOrDefault<TechSystem>();
                    }

                    if (gclass164_0_1 != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        int num = (int)(gclass164_0_1.int_4 * (class936.gclass234_0.Percentage / 100M));
                        if (this.Race.NPR)
                        {
                            if (this.Race.SpecialNPRID == SpecialNPRIDs.const_0)
                            {
                                if (gclass146_1 != null)
                                    gclass146_1.Race.CurrentResearchTotal += num;
                            }
                            else if (this.Race.SpecialNPRID == SpecialNPRIDs.StarSwarm)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class936.class935_0.gclass40_0.Race.UnknownNprClass.method_22(gclass164_0_1, num);
                            }
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class936.class935_0.gclass40_0.method_112(gclass164_0_1, num);
                        }
                    }

                    // ISSUE: reference to a compiler-generated field
                    if (gclass115_1 != null && !gclass115_1.list_2.Contains(class936.gclass234_0.TechData))
                    {
                        // ISSUE: reference to a compiler-generated field
                        gclass115_1.list_2.Add(class936.gclass234_0.TechData);
                    }
                }
            }

            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            List<ShipData> list1 = this.gclass0_0.Ships.Values
                .Where<ShipData>(class935.class934_0.method_1)
                .Where<ShipData>(gclass40_0 => gclass40_0.method_157(AuroraComponentType.CargoHold, false) > 0M)
                .OrderByDescending<ShipData, Decimal>(gclass40_0 =>
                    gclass40_0.method_157(AuroraComponentType.CargoHold, false)).ToList<ShipData>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            PopulationData gclass146_2 =
                this.gclass0_0.Populations.Values.FirstOrDefault<PopulationData>(class935.class934_0.method_2);
            bool flag = false;
            if (gclass146_2 != null)
            {
                if (gclass146_2.method_62(AuroraProductionCategory.CargoShuttles) >= 1M)
                {
                    flag = true;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    if (this.gclass0_0.Ships.Values.Where<ShipData>(class935.class934_0.method_3)
                            .FirstOrDefault<ShipData>(gclass40_0 =>
                                gclass40_0.method_157(AuroraComponentType.CargoShuttleBay, false) >= 1M) != null)
                        flag = true;
                }
            }

            // ISSUE: reference to a compiler-generated field
            foreach (WreckComponents gclass235_0 in class935.gclass233_0.ContainingComponents)
            {
                gclass115_1?.method_0(gclass235_0);
                if (this.Race.NPR && this.Race.SpecialNPRID != SpecialNPRIDs.Eldar)
                {
                    for (int index = 1; index <= gclass235_0.Amount; ++index)
                    {
                        if (this.Race.SpecialNPRID == SpecialNPRIDs.StarSwarm)
                        {
                            // ISSUE: reference to a compiler-generated field
                            class935.gclass40_0.decimal_17 += gclass235_0.Component.decimal_2;
                            this.method_79(gclass235_0.Component);
                        }
                        else
                            gclass146_1.method_50(gclass235_0);
                    }
                }
                else
                {
                    if (this.Race.SpecialNPRID == SpecialNPRIDs.Eldar)
                        this.System.RaidRating +=
                            (int)(gclass235_0.Component.gclass123_0.GetTotalAmount() * gclass235_0.Amount * 0.3M);
                    if (flag && list1.Count == 0)
                    {
                        gclass146_2.method_67(gclass235_0.Component, gclass235_0.Amount);
                    }
                    else
                    {
                        foreach (ShipData gclass40 in list1)
                        {
                            // ISSUE: reference to a compiler-generated field
                            gclass40.method_132(class935.gclass233_0, gclass235_0, gclass80_0);
                            if (gclass235_0.Amount == 0)
                                break;
                        }
                    }
                }
            }

            // ISSUE: reference to a compiler-generated field
            gclass80_0.gclass123_0 = class935.gclass233_0.ContainingMineral.method_25();
            if (this.Race.NPR && this.Race.SpecialNPRID != SpecialNPRIDs.Eldar)
            {
                if (this.Race.SpecialNPRID == SpecialNPRIDs.StarSwarm)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class935.gclass40_0.decimal_17 += class935.gclass233_0.ContainingMineral.GetTotalAmount();
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    gclass146_1.CurrentMinerals.AddMineralsFrom(class935.gclass233_0.ContainingMineral);
                }
            }
            else
            {
                if (this.Race.SpecialNPRID == SpecialNPRIDs.Eldar)
                {
                    // ISSUE: reference to a compiler-generated field
                    this.System.RaidRating += (int)class935.gclass233_0.ContainingMineral.GetTotalAmount();
                }

                if (flag && list1.Count == 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    gclass146_2.CurrentMinerals.AddMineralsFrom(class935.gclass233_0.ContainingMineral);
                }
                else
                {
                    foreach (ShipData gclass40 in list1)
                    {
                        // ISSUE: reference to a compiler-generated field
                        gclass40.method_131(class935.gclass233_0.ContainingMineral);
                        // ISSUE: reference to a compiler-generated field
                        if (class935.gclass233_0.ContainingMineral.GetTotalAmount() == 0M)
                            break;
                    }
                }

                // ISSUE: reference to a compiler-generated field
                gclass80_0.gclass123_0.method_22(class935.gclass233_0.ContainingMineral, 1M);
            }

            string str1 = "Salvage of ";
            string str2 = "Salvaged ";
            string str3;
            string string_1;
            // ISSUE: reference to a compiler-generated field
            if (class935.gclass233_0.ShipClass.Race == this.Race)
            {
                // ISSUE: reference to a compiler-generated field
                str3 = str1 + class935.gclass233_0.ShipClass.ClassName;
                // ISSUE: reference to a compiler-generated field
                string_1 = str2 + class935.gclass233_0.ShipClass.ClassName;
            }
            else
            {
                // ISSUE: reference to a compiler-generated method
                AlienShipClassIntel gclass115_2 =
                    this.Race.dictionary_11.Values.FirstOrDefault<AlienShipClassIntel>(class935.method_1);
                if (gclass115_2 == null)
                {
                    str3 = string.Format((string)"{0}unknown class", (object)str1);
                    string_1 = string.Format((string)"{0}unknown class", (object)str2);
                }
                else
                {
                    str3 = str1 + gclass115_2.ClassName;
                    string_1 = string.Format((string)"{0}unknown class", (object)str2);
                }
            }

            string string_0 = string.Format((string)"{0} completed by {1}.", (object)str3, (object)this.FleetName);
            if (gclass80_0.list_0.Count > 0)
            {
                string str4 = string.Format((string)"{0}  Components Recovered:", (object)string_0);
                foreach (WreckComponents gclass235 in gclass80_0.list_0)
                    str4 = string.Format((string)"{0}  {1}x {2}", (object)str4, (object)gclass235.Amount.ToString(),
                        (object)gclass235.Component.Name);
                string_0 = string.Format((string)"{0}.", (object)str4);
            }

            if (gclass80_0.gclass123_0.GetTotalAmount() > 0M)
                string_0 = string.Format((string)"{0}  Minerals Recovered: {1}", (object)string_0,
                    (object)gclass80_0.gclass123_0.method_37(0));
            // ISSUE: reference to a compiler-generated field
            if (!class935.gclass233_0.ShipClass.Commercial)
            {
                // ISSUE: reference to a compiler-generated field
                this.method_16(AuroraMeasurementType.TonsSalvaged,
                    class935.gclass233_0.ShipClass.Size * AuroraUtils.decimal_17);
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                this.method_16(AuroraMeasurementType.TonsSalvaged,
                    class935.gclass233_0.ShipClass.Size * AuroraUtils.decimal_17 * 0.1M);
            }

            this.method_17(AuroraMeasurementType.TonsSalvaged, null, null, string_1);
            this.gclass0_0.gclass92_0.method_2(EventType.const_68, string_0, this.Race,
                this.System.ActualSystem, this.XCoord, this.YCoord, AuroraEventCategory.Fleet);
            // ISSUE: reference to a compiler-generated method
            List<GameRace> list2 = this.gclass0_0.Ships.Values
                .Where<ShipData>(class935.method_2)
                .Select<ShipData, GameRace>(gclass40_0 => gclass40_0.Race)
                .Distinct<GameRace>().ToList<GameRace>();
            // ISSUE: reference to a compiler-generated method
            list2.AddRange(this.gclass0_0.Populations.Values.Where<PopulationData>(class935.method_3)
                .Select<PopulationData, GameRace>(gclass146_0 => gclass146_0.Race).Distinct<GameRace>()
                .ToList<GameRace>());
            // ISSUE: reference to a compiler-generated method
            foreach (GameRace gclass21 in list2.Distinct<GameRace>()
                         .Where<GameRace>(class935.method_4).ToList<GameRace>())
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.gclass0_0.gclass92_0.method_2(EventType.const_225,
                    string.Format((string)"The wreck of {0} in {1} has disappeared from sensors. ",
                        (object)class935.gclass233_0.method_1(gclass21, false),
                        (object)gclass21.method_277(class935.gclass233_0.System.SystemID)),
                    gclass21, class935.gclass233_0.System, class935.gclass233_0.Xcor,
                    class935.gclass233_0.Ycor, AuroraEventCategory.Ship);
            }

            // ISSUE: reference to a compiler-generated method
            AlienShipIntel gclass117 = this.Race.dictionary_12.Values.FirstOrDefault<AlienShipIntel>(class935.method_5);
            if (gclass117 != null)
                gclass117.bool_1 = true;
            // ISSUE: reference to a compiler-generated field
            this.gclass0_0.Wrecks.Remove(class935.gclass233_0.WreckID);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 828);
        }
    }

    public void method_81(ShipData gclass40_0, FleetData gclass85_5)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class937 class937 = new FleetData.Class937();
        // ISSUE: reference to a compiler-generated field
        class937.gclass40_0 = gclass40_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            foreach (ShipData gclass40_0_1 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(class937.method_0).ToList<ShipData>())
                this.method_81(gclass40_0_1, gclass85_5);
            ShipData gclass40 = this.method_78();
            if (gclass40 == null)
                return;
            PopulationData gclass146 = this.Race.method_191();
            if (this.Race.SpecialNPRID == SpecialNPRIDs.StarSwarm)
            {
                // ISSUE: reference to a compiler-generated field
                if (class937.gclass40_0.Class.OtherRaceClassID > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    foreach (ClassComponent gclass228 in class937.gclass40_0.Class.ClassComponents.Values)
                    {
                        for (int index = 1; index <= gclass228.NumComponent; ++index)
                            this.method_79(gclass228.Component);
                    }
                }
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                foreach (ClassComponent gclass228 in class937.gclass40_0.Class.ClassComponents.Values)
                {
                    for (int index = 1; index <= gclass228.NumComponent; ++index)
                        gclass146.method_45(gclass228.Component);
                }
            }

            if (this.Race.NPR)
            {
                if (this.Race.SpecialNPRID == SpecialNPRIDs.StarSwarm)
                {
                    // ISSUE: reference to a compiler-generated field
                    gclass40.decimal_17 += class937.gclass40_0.Class.Cost;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    gclass146.CurrentMinerals.AddMineralsFrom(class937.gclass40_0.Class.ClassMaterials);
                }
            }

            string str1 = "Salvage of intact ";
            string str2;
            // ISSUE: reference to a compiler-generated field
            if (class937.gclass40_0.Class.OtherRaceClassID == 0)
            {
                // ISSUE: reference to a compiler-generated field
                str2 = str1 + class937.gclass40_0.Class.ClassName;
            }
            else
            {
                // ISSUE: reference to a compiler-generated method
                AlienShipClassIntel gclass115 = this.Race.dictionary_11.Values.FirstOrDefault<AlienShipClassIntel>(class937.method_1);
                str2 = gclass115 != null ? str1 + gclass115.ClassName : string.Format((string)"{0}unknown class",
                    (object)str1);
            }

            this.gclass0_0.gclass92_0.method_2(EventType.const_163,
                string.Format((string)"{0} completed by {1}.", (object)str2, (object)this.FleetName),
                this.Race, this.System.ActualSystem, this.XCoord, this.YCoord, AuroraEventCategory.Fleet);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class937.gclass40_0.Race.method_303(class937.gclass40_0, GEnum22.const_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 829);
        }
    }

    public int method_82(PopulationData gclass146_1, FleetData gclass85_5, int int_12)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class938 class938 = new FleetData.Class938();
        // ISSUE: reference to a compiler-generated field
        class938.gclass146_0 = gclass146_1;
        try
        {
            ShipData gclass40 = this.method_78();
            if (gclass40 == null)
                return int_12;
            Decimal num1 = this.method_153();
            if (num1 == 0M)
                return int_12;
            // ISSUE: reference to a compiler-generated method
            Shipyard gclass193 = this.gclass0_0.Shipyards.Values.Where<Shipyard>(class938.method_0)
                .OrderBy<Shipyard, Decimal>(gclass193_0 => gclass193_0.Capacity).FirstOrDefault<Shipyard>();
            if (gclass193 != null)
            {
                int num2 = (int)Math.Floor(num1 * (int_12 / 86400) / gclass193.Slipways);
                int num3 = (int)(num2 / 10.0);
                if (gclass193.SYType == AuroraShipyardType.Commercial ||
                    gclass193.SYType == AuroraShipyardType.RepairYard)
                    num2 *= 10;
                gclass40.decimal_17 += num3;
                gclass193.Capacity -= num2;
                if (gclass193.Capacity < 1000M || gclass193.Capacity < 10000M &&
                    (gclass193.SYType == AuroraShipyardType.Commercial ||
                     gclass193.SYType == AuroraShipyardType.RepairYard))
                {
                    gclass40.decimal_17 += 200M;
                    this.gclass0_0.Shipyards.Remove(gclass193.ShipyardID);
                }

                return 0;
            }

            // ISSUE: reference to a compiler-generated field
            List<PopulationInstallation> list = class938.gclass146_0.dictionary_0.Values
                .OrderBy<PopulationInstallation, Decimal>(gclass158_0 => gclass158_0.InstallationType.Cost).ToList<PopulationInstallation>();
            if (list.Count == 0)
                return int_12;
            foreach (PopulationInstallation gclass158 in list)
            {
                Decimal num4 = gclass158.InstallationType.Cost * 10M / num1 * 86400M;
                Decimal d = int_12 / num4;
                if (d >= gclass158.Amount)
                {
                    int_12 -= (int)(gclass158.Amount * num4);
                    gclass40.decimal_17 += gclass158.Amount * gclass158.InstallationType.Cost;
                    this.gclass0_0.gclass92_0.method_2(EventType.const_180,
                        string.Format((string)"{0} has salvaged {1}x {2}", (object)gclass85_5.FleetName,
                            (object)AuroraUtils.smethod_39(gclass158.Amount), (object)gclass158.InstallationType.Name),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
                    // ISSUE: reference to a compiler-generated field
                    class938.gclass146_0.dictionary_0.Remove(gclass158.InstallationType.InstallationType);
                }
                else
                {
                    int decimal_73 = 0;
                    if (d >= 1M)
                    {
                        decimal_73 = (int)Math.Floor(d);
                        gclass40.decimal_17 += decimal_73 * gclass158.InstallationType.Cost;
                        d -= decimal_73;
                    }

                    if (d > 0M)
                    {
                        Decimal num5 = d * 1000M;
                        if (AuroraUtils.GetRandomInteger(1000) < num5)
                        {
                            gclass40.decimal_17 += gclass158.InstallationType.Cost;
                            ++decimal_73;
                        }
                    }

                    if (decimal_73 > 0)
                    {
                        this.gclass0_0.gclass92_0.method_2(EventType.const_180,
                            string.Format((string)"{0} has salvaged {1}x {2}", (object)gclass85_5.FleetName,
                                (object)AuroraUtils.smethod_39(decimal_73), (object)gclass158.InstallationType.Name),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        gclass158.Amount -= decimal_73;
                        if (gclass158.Amount <= 0M)
                        {
                            // ISSUE: reference to a compiler-generated field
                            class938.gclass146_0.dictionary_0.Remove(gclass158.InstallationType.InstallationType);
                        }
                    }

                    return 0;
                }
            }

            return int_12;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 830);
            return 0;
        }
    }

    public int method_83()
    {
        try
        {
            List<ShipData> list = this.method_176()
                .Where<ShipData>(gclass40_0 =>
                    gclass40_0.method_167(AuroraComponentType.JumpPointStabilisation) > 0).ToList<ShipData>();
            if (list.Count == 0)
                return 0;
            Decimal num1 = 0M;
            foreach (ShipData gclass40 in list)
            {
                Decimal num2 = gclass40.Class.JGConstructionTime * 86400;
                Commander gclass55 = gclass40.method_192(AuroraCommandType.Ship);
                if (gclass55 != null)
                {
                    Decimal num3 = 2M - gclass55.method_5(CommanderBonusType.Production);
                    num2 *= num3;
                }

                if (gclass40.int_11 < gclass40.Class.Crew)
                {
                    Decimal num4 = gclass40.Class.Crew / (Decimal)gclass40.int_11;
                    num2 *= num4;
                }

                if (num2 < num1 || num1 == 0M)
                    num1 = num2;
            }

            return (int)num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 831);
            return 0;
        }
    }

    public int method_84(SystemBodyData gclass1_1, bool bool_25)
    {
        try
        {
            List<ShipData> list = this.method_176()
                .Where<ShipData>(gclass40_0 =>
                    gclass40_0.method_167(AuroraComponentType.JumpPointStabilisation) > 0).ToList<ShipData>();
            if (list.Count == 0)
                return 0;
            Decimal num1 = 0M;
            foreach (ShipData gclass40 in list)
            {
                Decimal num2 = (Decimal)(60.0 / Math.Sqrt(gclass1_1.Mass)) * AuroraUtils.decimal_31;
                if (bool_25)
                {
                    Commander gclass55 = gclass40.method_192(AuroraCommandType.Ship);
                    if (gclass55 != null)
                    {
                        Decimal num3 = 2M - gclass55.method_5(CommanderBonusType.Production);
                        num2 *= num3;
                    }
                }

                if (gclass40.int_11 < gclass40.Class.Crew)
                {
                    Decimal num4 = gclass40.Class.Crew / (Decimal)gclass40.int_11;
                    num2 *= num4;
                }

                if (num2 < num1 || num1 == 0M)
                    num1 = num2;
            }

            return (int)num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 832);
            return 0;
        }
    }

    public int method_85(MoveOrder gclass139_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class939 class939 = new FleetData.Class939();
        // ISSUE: reference to a compiler-generated field
        class939.gclass139_0 = gclass139_0;
        try
        {
            Decimal num1 = this.method_153();
            if (num1 == 0M)
                return 0;
            // ISSUE: reference to a compiler-generated method
            Wreck gclass233 = this.gclass0_0.Wrecks.Values.FirstOrDefault<Wreck>(class939.method_0);
            if (gclass233 == null)
                return 0;
            if (gclass233.Size == 0M)
                gclass233.Size = 1M;
            int num2 = (int)Math.Ceiling(gclass233.Size * AuroraUtils.decimal_17 / num1 * 86400M);
            if (gclass233.ShipClass.Commercial)
                num2 = (int)(num2 / 10.0);
            return num2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 833);
            return 0;
        }
    }

    public int method_86(MoveOrder gclass139_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class940 class940 = new FleetData.Class940();
        // ISSUE: reference to a compiler-generated field
        class940.gclass139_0 = gclass139_0;
        try
        {
            Decimal num1 = this.method_153();
            if (num1 == 0M)
                return 0;
            // ISSUE: reference to a compiler-generated method
            ShipData gclass40 =
                this.gclass0_0.Ships.Values.FirstOrDefault<ShipData>(class940.method_0);
            if (gclass40 == null)
                return 0;
            int num2 = (int)(gclass40.Class.Size * AuroraUtils.decimal_17 / num1 * 86400M);
            if (gclass40.Class.Commercial)
                num2 = (int)(num2 / 10.0);
            return num2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 834);
            return 0;
        }
    }

    public int method_87(MoveOrder gclass139_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class941 class941 = new FleetData.Class941();
        // ISSUE: reference to a compiler-generated field
        class941.gclass139_0 = gclass139_0;
        try
        {
            Decimal num1 = 0M;
            Decimal num2 = 0M;
            foreach (ShipData gclass40 in this.method_176())
            {
                // ISSUE: reference to a compiler-generated field
                switch (class941.gclass139_0.MoveActionType.MoveActionType)
                {
                    case MoveActionType.LoadColonists:
                        num2 = ((int)gclass40.method_149() -
                                gclass40.TransportedColonists.Sum<TransportedColonist>(gclass181_0 => gclass181_0.Amount)) *
                               AuroraUtils.decimal_24;
                        break;
                    case MoveActionType.LoadAllMinerals:
                    case MoveActionType.LoadTradeGoods:
                    case MoveActionType.LoadShipComponent:
                    case MoveActionType.LoadUnloadMineralsToReserveLevel:
                    case MoveActionType.LoadInstallation:
                    case MoveActionType.LoadMineralType:
                    case MoveActionType.LoadMineralWhenXAvailable:
                    case MoveActionType.LoadAllMineralsUntilFull:
                        num2 = gclass40.method_124() * AuroraUtils.decimal_23;
                        break;
                    case MoveActionType.LoadGroundUnitIntoTransportBay:
                    case MoveActionType.LoadGroundUnitFromStationaryFleet:
                        // ISSUE: reference to a compiler-generated field
                        if (this.gclass0_0.FormationDictionary.ContainsKey(class941.gclass139_0.DestinationItemID))
                        {
                            int num3 = gclass40.method_211();
                            if (num3 > 0)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated method
                                int num4 = class941.gclass139_0.bLoadSubUnits
                                    ? (int)this.gclass0_0.FormationDictionary[class941.gclass139_0.DestinationItemID]
                                        .method_22(class941.gclass139_0.Population, null)
                                        .Sum<GroundUnitFormationData>(gclass103_0 => gclass103_0.method_34())
                                    : (int)this.gclass0_0.FormationDictionary.Values
                                        .Where<GroundUnitFormationData>(class941.func_0 ?? (class941.func_0 = class941.method_0))
                                        .Sum<GroundUnitFormationData>(gclass103_0 => gclass103_0.method_34());
                                if (num4 > 0)
                                {
                                    if (num4 > num3)
                                        num4 = num3;
                                    num2 = AuroraUtils.decimal_25 * num4;
                                    break;
                                }

                                break;
                            }

                            break;
                        }

                        break;
                    case MoveActionType.LoadAssignedGroundTemplates:
                        int num5 = gclass40.method_211();
                        // ISSUE: reference to a compiler-generated field
                        if (num5 > 0 && class941.gclass139_0.MoveActionType.MoveActionType == MoveActionType.LoadAssignedGroundTemplates)
                        {
                            num2 = AuroraUtils.decimal_25 * num5;
                            break;
                        }

                        break;
                }

                if (num2 > 0M)
                {
                    if (gclass40.int_11 < gclass40.Class.Crew)
                    {
                        Decimal num6 = gclass40.Class.Crew / (Decimal)gclass40.int_11;
                        num2 *= num6;
                    }

                    // ISSUE: reference to a compiler-generated field
                    Decimal num7 = gclass40.method_113(class941.gclass139_0.Population, false);
                    if (num7 > 0M)
                        num2 /= num7;
                    if (num2 > num1)
                        num1 = num2;
                }
            }

            return (int)num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 835);
            return 0;
        }
    }

    public int method_88(MoveOrder gclass139_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class942 class942 = new FleetData.Class942();
        // ISSUE: reference to a compiler-generated field
        class942.gclass139_0 = gclass139_0;
        try
        {
            Decimal num1 = 0M;
            Decimal num2 = 0M;
            foreach (ShipData gclass40 in this.method_176())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class943 class943 = new FleetData.Class943();
                // ISSUE: reference to a compiler-generated field
                class943.gclass40_0 = gclass40;
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class944 class944 = new FleetData.Class944();
                // ISSUE: reference to a compiler-generated field
                switch (class942.gclass139_0.MoveActionType.MoveActionType)
                {
                    case MoveActionType.UnloadColonists:
                        // ISSUE: reference to a compiler-generated field
                        num2 = class943.gclass40_0.TransportedColonists.Sum<TransportedColonist>(gclass181_0 => gclass181_0.Amount) *
                               AuroraUtils.decimal_24;
                        break;
                    case MoveActionType.UnloadAllMinerals:
                    case MoveActionType.TransferAllMinerals:
                        // ISSUE: reference to a compiler-generated field
                        num2 = class943.gclass40_0.TransportedMineral.GetTotalAmount() * AuroraUtils.decimal_28 *
                               AuroraUtils.decimal_23;
                        break;
                    case MoveActionType.UnloadGroundUnitFromTransportBay:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class943.gclass40_0.Class.gclass163_0 != null &&
                            this.gclass0_0.FormationDictionary.ContainsKey(class942.gclass139_0.DestinationItemID))
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            Decimal num3 = class942.gclass139_0.bLoadSubUnits
                                ? (int)this.gclass0_0.FormationDictionary[class942.gclass139_0.DestinationItemID]
                                    .method_22(null, class943.gclass40_0)
                                    .Sum<GroundUnitFormationData>(gclass103_0 => gclass103_0.method_34())
                                : (Decimal)(int)this.gclass0_0.FormationDictionary.Values
                                    .Where<GroundUnitFormationData>(class942.func_0 ?? (class942.func_0 = class942.method_0))
                                    .Sum<GroundUnitFormationData>(gclass103_0 => gclass103_0.method_34());
                            if (num3 > 0M)
                            {
                                num2 = AuroraUtils.decimal_25 * num3;
                                break;
                            }

                            break;
                        }

                        break;
                    case MoveActionType.UnloadAllGroundUnitsFromTransportBay:
                        // ISSUE: reference to a compiler-generated field
                        if (class943.gclass40_0.Class.gclass163_0 != null)
                        {
                            // ISSUE: reference to a compiler-generated method
                            Decimal num4 = this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class943.method_0)
                                .Sum<GroundUnitFormationData>(gclass103_0 => gclass103_0.method_34());
                            if (num4 > 0M)
                            {
                                num2 = AuroraUtils.decimal_25 * num4;
                                break;
                            }

                            break;
                        }

                        break;
                    case MoveActionType.UnloadAllInstallations:
                    case MoveActionType.TransferAllInstallations:
                        // ISSUE: reference to a compiler-generated field
                        if (class943.gclass40_0.TransportedInstallations.Count > 0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            num2 = class943.gclass40_0.TransportedInstallations.Values.Sum<PopulationInstallation>(gclass158_0 =>
                                gclass158_0.InstallationType.CargoPoints * gclass158_0.Amount) * AuroraUtils.decimal_23;
                            break;
                        }

                        break;
                    case MoveActionType.UnloadTradeGoods:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class943.gclass40_0.TransportedTradeGoods.ContainsKey(class942.gclass139_0.DestinationItemID))
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            num2 = class943.gclass40_0.TransportedTradeGoods[class942.gclass139_0.DestinationItemID].Amount *
                                   AuroraUtils.decimal_53 * AuroraUtils.decimal_23;
                            break;
                        }

                        break;
                    case MoveActionType.UnloadShipComponent:
                        // ISSUE: reference to a compiler-generated field
                        class944.gclass230_0 = null;
                        // ISSUE: reference to a compiler-generated field
                        if (this.gclass0_0.ComponentDataDictionary.ContainsKey(class942.gclass139_0.DestinationItemID))
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class944.gclass230_0 = this.gclass0_0.ComponentDataDictionary[class942.gclass139_0.DestinationItemID];
                        }

                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        num2 = class944.gclass230_0 == null
                            ? 0M
                            : class943.gclass40_0.TransportedComponents.Where<StoredComponent>(class944.method_0).Sum<StoredComponent>(gclass73_0 =>
                                  gclass73_0.Component.decimal_1 * gclass73_0.Amount * AuroraUtils.decimal_17) *
                              AuroraUtils.decimal_23;
                        break;
                    case MoveActionType.AttemptBoardingActionAllFormations:
                    case MoveActionType.AttemptBoardingAction:
                    case MoveActionType.OrbitalDropGroundUnit:
                    case MoveActionType.OrbitalDropAllGroundUnits:
                        num2 = 0M;
                        break;
                    case MoveActionType.UnloadInstallation:
                    case MoveActionType.TransferInstallation:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class943.gclass40_0.TransportedInstallations.ContainsKey(
                                (AuroraInstallationType)class942.gclass139_0.DestinationItemID))
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            num2 = class943.gclass40_0.TransportedInstallations[(AuroraInstallationType)class942.gclass139_0.DestinationItemID]
                                .method_0() * AuroraUtils.decimal_23;
                            break;
                        }

                        break;
                    case MoveActionType.UnloadMineralType:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        num2 = class943.gclass40_0.TransportedMineral.GetValueOfElement((AuroraElement)class942.gclass139_0.DestinationItemID) *
                               AuroraUtils.decimal_28 * AuroraUtils.decimal_23;
                        break;
                    case MoveActionType.UnloadAllShipComponents:
                        // ISSUE: reference to a compiler-generated field
                        num2 = class943.gclass40_0.TransportedComponents.Sum<StoredComponent>(gclass73_0 =>
                                   gclass73_0.Component.decimal_1 * gclass73_0.Amount * AuroraUtils.decimal_17) *
                               AuroraUtils.decimal_23;
                        break;
                }

                if (num2 > 0M)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class943.gclass40_0.int_11 < class943.gclass40_0.Class.Crew)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        Decimal num5 = class943.gclass40_0.Class.Crew / (Decimal)class943.gclass40_0.int_11;
                        num2 *= num5;
                    }

                    Decimal num6;
                    // ISSUE: reference to a compiler-generated field
                    if (class942.gclass139_0.Population != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        num6 = class943.gclass40_0.method_113(class942.gclass139_0.Population, false);
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        num6 = class943.gclass40_0.method_114();
                        // ISSUE: reference to a compiler-generated field
                        if (this.gclass0_0.FleetDictionary.ContainsKey(class942.gclass139_0.DestinationID))
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (this.gclass0_0.FleetDictionary[class942.gclass139_0.DestinationID]
                                    .method_125(AuroraComponentType.CargoShuttleBay) > 0M)
                            {
                                ++num6;
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (this.gclass0_0.FleetDictionary[class942.gclass139_0.DestinationID]
                                        .method_125(AuroraComponentType.MaintenanceModule) > 0M)
                                    ++num6;
                            }
                        }
                    }

                    if (num6 > 0M)
                        num2 /= num6;
                    if (num2 > num1)
                        num1 = num2;
                }
            }

            return (int)num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 836);
            return 0;
        }
    }

    public SubFleet method_89(string string_1)
    {
        try
        {
            SubFleet gclass84 = new SubFleet(this.gclass0_0);
            gclass84.SubFleetID = this.gclass0_0.method_26(GEnum0.const_23);
            gclass84.Race = this.Race;
            gclass84.ParentFleet = this;
            gclass84.ParentSubFleet = null;
            gclass84.SubFleetName = string_1;
            this.gclass0_0.SubFleetDictionary.Add(gclass84.SubFleetID, gclass84);
            return gclass84;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 837);
            return null;
        }
    }

    public void method_90(GEnum8 genum8_0)
    {
        try
        {
            List<ShipData> gclass40List = this.method_176();
            if (gclass40List.Count == 0)
                return;
            foreach (ShipData gclass40 in gclass40List)
                gclass40.method_147(genum8_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 838);
        }
    }

    public void method_91(MoveOrder gclass139_0)
    {
        try
        {
            List<ShipData> gclass40List = null;
            if (gclass139_0.MoveActionType.MoveActionType == MoveActionType.LoadGroundUnitIntoTransportBay ||
                gclass139_0.MoveActionType.MoveActionType == MoveActionType.LoadGroundUnitFromStationaryFleet)
                gclass40List = this.gclass0_0.Ships.Values.Where<ShipData>(gclass40_0 =>
                        gclass40_0.method_167(AuroraComponentType.TroopTransport) > 0 && gclass40_0.gclass85_0 == this)
                    .ToList<ShipData>();
            if (gclass40List.Count == 0)
                this.gclass0_0.gclass92_0.method_2(EventType.const_52,
                    string.Format(
                        (string)
                        "{0} was unable to load ground formations as there are no troop transports in the fleet",
                        (object)this.FleetName),
                    this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                    AuroraEventCategory.Fleet);
            else if (!this.gclass0_0.FormationDictionary.ContainsKey(gclass139_0.DestinationItemID))
            {
                this.gclass0_0.gclass92_0.method_2(EventType.const_52,
                    string.Format(
                        (string)
                        "{0} was unable to execute the order: {1}. The target formation was not at the destination",
                        (object)this.FleetName, (object)gclass139_0.Description),
                    this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                    AuroraEventCategory.Fleet);
            }
            else
            {
                List<GroundUnitFormationData> gclass103List = new List<GroundUnitFormationData>();
                if (gclass139_0.bLoadSubUnits)
                {
                    if (gclass139_0.MoveActionType.MoveActionType == MoveActionType.LoadGroundUnitIntoTransportBay ||
                        gclass139_0.MoveActionType.MoveActionType == MoveActionType.LoadGroundUnitFromStationaryFleet)
                        gclass103List = this.gclass0_0.FormationDictionary[gclass139_0.DestinationItemID]
                            .method_22(gclass139_0.Population, null);
                }
                else
                    gclass103List.Add(this.gclass0_0.FormationDictionary[gclass139_0.DestinationItemID]);

                foreach (GroundUnitFormationData gclass103_1 in gclass103List)
                {
                    bool flag = false;
                    foreach (ShipData gclass40 in gclass40List)
                    {
                        if (gclass40.method_128(gclass139_0, gclass103_1))
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (!flag)
                    {
                        this.gclass0_0.gclass92_0.method_2(EventType.const_52,
                            string.Format((string)"{0} was unable to load {1}", (object)this.FleetName,
                                (object)gclass103_1.Name), this.Race,
                            this.System.ActualSystem, this.XCoord, this.YCoord, AuroraEventCategory.Fleet);
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 840);
        }
    }

    public void method_92(MoveOrder gclass139_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class945 class945 = new FleetData.Class945();
        // ISSUE: reference to a compiler-generated field
        class945.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class945.gclass139_0 = gclass139_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(class945.method_0).Where<ShipData>(gclass40_0 =>
                             gclass40_0.Class.GroundUnitTemplates.Count > 0 &&
                             gclass40_0.method_167(AuroraComponentType.TroopTransport) > 0).ToList<ShipData>())
            {
                foreach (ClassGroundTemplate gclass75 in gclass40.Class.GroundUnitTemplates)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    FleetData.Class946 class946 = new FleetData.Class946();
                    // ISSUE: reference to a compiler-generated field
                    class946.class945_0 = class945;
                    // ISSUE: reference to a compiler-generated field
                    class946.gclass75_0 = gclass75;
                    // ISSUE: reference to a compiler-generated field
                    for (int index = 1; index <= class946.gclass75_0.Number; ++index)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        GroundUnitFormationData gclass103_1 =
                            this.gclass0_0.FormationDictionary.Values.FirstOrDefault<GroundUnitFormationData>(class946.func_0 ??
                                (class946.func_0 = class946.method_0));
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (gclass103_1 == null || !gclass40.method_128(class946.class945_0.gclass139_0, gclass103_1))
                            break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3636);
        }
    }

    public void method_93(PopulationData gclass146_1, int int_12)
    {
        try
        {
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.method_167(AuroraComponentType.CargoHold) > 0 && gclass40_0.gclass85_0 == this)
                         .ToList<ShipData>())
                gclass40.method_130(gclass146_1, int_12);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 842);
        }
    }

    public void method_94(PopulationData gclass146_1, ShipComponent gclass230_0)
    {
        try
        {
            Decimal num = 0M;
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.method_167(AuroraComponentType.CargoHold) > 0 && gclass40_0.gclass85_0 == this)
                         .ToList<ShipData>())
                num += gclass40.method_133(gclass146_1, gclass230_0);
            if (!(num == 0M))
                return;
            this.gclass0_0.gclass92_0.method_2(EventType.const_52,
                string.Format((string)"{0} was unable to load {1} from {2}", (object)this.FleetName,
                    (object)gclass230_0.Name, (object)gclass146_1.PopName), this.Race,
                this.System.ActualSystem, this.XCoord, this.YCoord, AuroraEventCategory.Fleet);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 843);
        }
    }

    public void method_95(PopulationData gclass146_1, Decimal decimal_9)
    {
        try
        {
            bool flag = false;
            if (decimal_9 > 0M)
                flag = true;
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             (gclass40_0.method_167(AuroraComponentType.ColonistTransport) > 0 ||
                              gclass40_0.method_167(AuroraComponentType.PassengerModule) > 0) &&
                             gclass40_0.gclass85_0 == this).ToList<ShipData>())
            {
                Decimal num = gclass40.method_127(gclass146_1, decimal_9);
                if (flag)
                {
                    decimal_9 -= num;
                    if (decimal_9 <= 0M)
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 839);
        }
    }

    public void method_96(
        PopulationData gclass146_1,
        AuroraInstallationType auroraInstallationType_0,
        Decimal decimal_9)
    {
        try
        {
            Decimal num1 = 0M;
            bool flag = false;
            if (decimal_9 > 0M)
                flag = true;
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.method_167(AuroraComponentType.CargoHold) > 0 && gclass40_0.gclass85_0 == this)
                         .ToList<ShipData>())
            {
                if ((gclass40.Race.NPR || gclass40.gclass187_0 != null) && gclass40.TransportedInstallations.Count > 0)
                    gclass40.TransportedInstallations.Clear();
                Decimal num2 = gclass40.method_129(gclass146_1, auroraInstallationType_0, decimal_9);
                num1 += num2;
                if (flag)
                {
                    decimal_9 -= num2;
                    if (decimal_9 <= 0M)
                        break;
                }
            }

            if (!(num1 == 0M))
                return;
            this.gclass0_0.gclass92_0.method_2(EventType.const_52,
                string.Format((string)"{0} was unable to load {1} from {2}", (object)this.FleetName,
                    (object)this.gclass0_0.InstallationTypes[auroraInstallationType_0].Name,
                    (object)gclass146_1.PopName),
                this.Race, this.System.ActualSystem, this.XCoord, this.YCoord, AuroraEventCategory.Fleet);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 841);
        }
    }

    public void method_97(
        PopulationData gclass146_1,
        AuroraElement auroraElement_0,
        Decimal decimal_9,
        Decimal decimal_10,
        bool bool_25)
    {
        try
        {
            Decimal num1 = 0M;
            bool flag = false;
            if (decimal_10 > 0M)
                flag = true;
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.method_167(AuroraComponentType.CargoHold) > 0 && gclass40_0.gclass85_0 == this)
                         .ToList<ShipData>())
            {
                Decimal num2 = gclass40.method_134(gclass146_1, auroraElement_0, decimal_9, decimal_10);
                num1 += num2;
                if (flag)
                {
                    decimal_10 -= num2;
                    if (decimal_10 <= 0M)
                        break;
                }
            }

            if (!(num1 == 0M) || !bool_25)
                return;
            this.gclass0_0.gclass92_0.method_2(EventType.const_52,
                string.Format((string)"{0} was unable to load {1} from {2}", (object)this.FleetName,
                    (object)AuroraUtils.smethod_82(auroraElement_0), (object)gclass146_1.PopName),
                this.Race, this.System.ActualSystem, this.XCoord, this.YCoord, AuroraEventCategory.Fleet);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 844);
        }
    }

    public void method_98(PopulationData gclass146_1)
    {
        try
        {
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.method_167(AuroraComponentType.CargoHold) > 0 && gclass40_0.gclass85_0 == this)
                         .ToList<ShipData>())
                gclass40.method_135(gclass146_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 845);
        }
    }

    public void method_99(
        PopulationData gclass146_1,
        AuroraInstallationType auroraInstallationType_0,
        Decimal decimal_9)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class947 class947 = new FleetData.Class947();
        // ISSUE: reference to a compiler-generated field
        class947.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class947.auroraInstallationType_0 = auroraInstallationType_0;
        try
        {
            Decimal num1 = 0M;
            bool flag = false;
            if (decimal_9 > 0M)
                flag = true;
            List<ShipData> list;
            // ISSUE: reference to a compiler-generated field
            if (class947.auroraInstallationType_0 == AuroraInstallationType.NoType)
            {
                // ISSUE: reference to a compiler-generated method
                list = this.gclass0_0.Ships.Values.Where<ShipData>(class947.method_0)
                    .ToList<ShipData>();
                decimal_9 = 0M;
                flag = false;
            }
            else
            {
                // ISSUE: reference to a compiler-generated method
                list = this.gclass0_0.Ships.Values.Where<ShipData>(class947.method_1)
                    .ToList<ShipData>();
            }

            foreach (ShipData gclass40 in list)
            {
                // ISSUE: reference to a compiler-generated field
                Decimal num2 = gclass40.method_140(gclass146_1, class947.auroraInstallationType_0, decimal_9);
                num1 += num2;
                if (flag)
                {
                    decimal_9 -= num2;
                    if (decimal_9 <= 0M)
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 846);
        }
    }

    public void method_100(
        FleetData gclass85_5,
        AuroraInstallationType auroraInstallationType_0,
        Decimal decimal_9)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class948 class948 = new FleetData.Class948();
        // ISSUE: reference to a compiler-generated field
        class948.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class948.auroraInstallationType_0 = auroraInstallationType_0;
        try
        {
            int int_40 = 0;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            List<ShipData> gclass40List = class948.auroraInstallationType_0 != AuroraInstallationType.NoType
                ? this.gclass0_0.Ships.Values.Where<ShipData>(class948.method_1)
                    .ToList<ShipData>()
                : this.gclass0_0.Ships.Values.Where<ShipData>(class948.method_0)
                    .ToList<ShipData>();
            List<ShipData> list = gclass85_5.method_176()
                .Where<ShipData>(gclass40_0 => gclass40_0.method_157(AuroraComponentType.CargoHold, false) > 0M)
                .ToList<ShipData>();
            if (gclass85_5 != null)
            {
                if (gclass85_5.method_125(AuroraComponentType.CargoShuttleBay) > 0M)
                    int_40 = 1;
                else if (gclass85_5.method_125(AuroraComponentType.MaintenanceModule) > 0M)
                    int_40 = 1;
            }

            foreach (ShipData gclass40 in gclass40List)
            {
                // ISSUE: reference to a compiler-generated field
                decimal_9 = gclass40.method_141(gclass85_5, list, class948.auroraInstallationType_0, int_40, decimal_9);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3500);
        }
    }

    public void method_101(PopulationData gclass146_1, int int_12)
    {
        try
        {
            ShipComponent gclass230_0 = null;
            if (this.gclass0_0.ComponentDataDictionary.ContainsKey(int_12))
                gclass230_0 = this.gclass0_0.ComponentDataDictionary[int_12];
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.TransportedComponents.Count > 0 && gclass40_0.gclass85_0 == this).ToList<ShipData>())
                gclass40.method_143(gclass146_1, gclass230_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 847);
        }
    }

    public void method_102(PopulationData gclass146_1, int int_12)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class949 class949 = new FleetData.Class949();
        // ISSUE: reference to a compiler-generated field
        class949.int_0 = int_12;
        // ISSUE: reference to a compiler-generated field
        class949.gclass85_0 = this;
        try
        {
            // ISSUE: reference to a compiler-generated method
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(class949.method_0).ToList<ShipData>())
            {
                // ISSUE: reference to a compiler-generated field
                gclass40.method_144(gclass146_1, class949.int_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 848);
        }
    }

    public void method_103(MoveOrder gclass139_0)
    {
        try
        {
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.method_167(AuroraComponentType.TroopTransport) > 0 &&
                             gclass40_0.gclass85_0 == this).ToList<ShipData>())
            {
                if (gclass139_0.MoveActionType.MoveActionType != MoveActionType.UnloadGroundUnitFromTransportBay &&
                    gclass139_0.MoveActionType.MoveActionType != MoveActionType.OrbitalDropGroundUnit)
                {
                    if (gclass139_0.MoveActionType.MoveActionType != MoveActionType.UnloadAllGroundUnitsFromTransportBay &&
                        gclass139_0.MoveActionType.MoveActionType != MoveActionType.OrbitalDropAllGroundUnits)
                    {
                        if (gclass139_0.MoveActionType.MoveActionType == MoveActionType.AttemptBoardingAction && gclass40.gclass40_0 == null)
                            gclass40.method_136(gclass139_0);
                        else if (gclass139_0.MoveActionType.MoveActionType == MoveActionType.AttemptBoardingActionAllFormations && gclass40.gclass40_0 == null)
                            gclass40.method_137(gclass139_0);
                    }
                    else
                        gclass40.method_139(gclass139_0);
                }
                else
                    gclass40.method_138(gclass139_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 849);
        }
    }

    public void method_104(MoveOrder gclass139_0)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            FleetData.Class950 class950 = new FleetData.Class950();
            // ISSUE: reference to a compiler-generated field
            class950.gclass85_0 = this;
            List<ShipData> list1 = this.gclass0_0.Ships.Values.Where<ShipData>(gclass40_0 =>
                    gclass40_0.method_167(AuroraComponentType.TroopTransport) > 0 && gclass40_0.gclass85_0 == this)
                .ToList<ShipData>();
            if (list1.Count == 0 || !this.gclass0_0.Contacts.ContainsKey(gclass139_0.DestinationID))
                return;
            // ISSUE: reference to a compiler-generated field
            class950.gclass40_0 = this.gclass0_0.Contacts[gclass139_0.DestinationID].TargetShip;
            // ISSUE: reference to a compiler-generated field
            if (class950.gclass40_0 == null)
                return;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            class950.list_0 = this.gclass0_0.Ships.Values.Where<ShipData>(class950.method_0)
                .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.Class.Size)
                .ToList<ShipData>();
            // ISSUE: reference to a compiler-generated method
            List<ShipData> list2 = this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class950.method_1)
                .Select<GroundUnitFormationData, ShipData>(gclass103_0 => gclass103_0.ShipData).Distinct<ShipData>()
                .ToList<ShipData>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class950.list_0 = class950.list_0.Except<ShipData>(list2).ToList<ShipData>();
            // ISSUE: reference to a compiler-generated field
            foreach (ShipData gclass40_1 in class950.list_0)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class951 class951 = new FleetData.Class951();
                Decimal num1 = this.Speed / (Decimal)gclass40_1.gclass85_0.Speed;
                if (num1 > 10M)
                    num1 = 10M;
                Decimal num2 = num1 * 4M;
                if (gclass40_1.Class.Commercial)
                    num2 *= 10M;
                int count = (int)Math.Round(gclass40_1.Class.Size / num2);
                // ISSUE: reference to a compiler-generated field
                class951.list_0 = list1.Take<ShipData>(count).ToList<ShipData>();
                // ISSUE: reference to a compiler-generated method
                foreach (GroundUnitFormationData gclass103 in this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class951.method_0)
                             .ToList<GroundUnitFormationData>())
                    gclass103.method_11(gclass40_1);
                FleetData gclass85_1 = this.Race.method_308("Recycling", this.ParentNavalCommand, this.System,
                    this.XCoord, this.YCoord, this.OrbitingBody, OperationalGroupID.StarSwarmScoutSquadron);
                // ISSUE: reference to a compiler-generated field
                this.Race.method_270(class951.list_0, this, gclass85_1, true, false);
                list1 = this.gclass0_0.Ships.Values.Where<ShipData>(gclass40_0 =>
                        gclass40_0.method_167(AuroraComponentType.TroopTransport) > 0 && gclass40_0.gclass85_0 == this)
                    .ToList<ShipData>();
                if (list1.Count == 0)
                {
                    this.NPROperationGroup = this.gclass0_0.OperationalGroupDictionary[OperationalGroupID.SwarmGeologicalSurvey];
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 850);
        }
    }

    public void method_105()
    {
        try
        {
            List<ShipData> gclass40List = this.method_176();
            Decimal num1 = 0M;
            foreach (ShipData gclass40 in gclass40List)
            {
                int num2 = gclass40.Class.Crew - gclass40.int_11;
                if (num2 > 0)
                {
                    if (gclass40.Class.ConscriptOnly == 0)
                    {
                        if (num2 > this.Race.AcademyCrewmen)
                        {
                            num1 = AuroraUtils.int_26 * this.Race.TrainingLevel *
                                   (this.Race.AcademyCrewmen / num2) * num2;
                            this.Race.AcademyCrewmen = 0M;
                        }
                        else
                        {
                            num1 = AuroraUtils.int_26 * this.Race.TrainingLevel * num2;
                            this.Race.AcademyCrewmen -= num2;
                        }
                    }

                    Decimal num3 = gclass40.int_11 * gclass40.decimal_15;
                    gclass40.decimal_15 = (num3 + num1) / gclass40.Class.Crew;
                    gclass40.int_11 = gclass40.Class.Crew;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 851);
        }
    }

    public void method_106(PopulationData gclass146_1)
    {
        try
        {
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.TransportedColonists.Count > 0 && gclass40_0.gclass85_0 == this).ToList<ShipData>())
                gclass40.method_146(gclass146_1);
            gclass146_1.method_184();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 852);
        }
    }

    public void method_107(PopulationData gclass146_1, AuroraElement auroraElement_0, Decimal decimal_9)
    {
        try
        {
            Decimal num1 = 0M;
            bool flag = false;
            if (decimal_9 > 0M)
                flag = true;
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.TransportedMineral.GetTotalAmount() > 0M && gclass40_0.gclass85_0 == this)
                         .ToList<ShipData>())
            {
                Decimal num2 = gclass40.method_145(gclass146_1, auroraElement_0, decimal_9);
                num1 += num2;
                if (flag)
                {
                    decimal_9 -= num2;
                    if (decimal_9 <= 0M)
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 853);
        }
    }

    public void method_108(FleetData gclass85_5, AuroraElement auroraElement_0, Decimal decimal_9)
    {
        try
        {
            int int_40 = 0;
            List<ShipData> list1 = this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 =>
                    gclass40_0.TransportedMineral.GetTotalAmount() > 0M && gclass40_0.gclass85_0 == this).ToList<ShipData>();
            List<ShipData> list2 = gclass85_5.method_176()
                .Where<ShipData>(gclass40_0 => gclass40_0.method_157(AuroraComponentType.CargoHold, false) > 0M)
                .ToList<ShipData>();
            if (gclass85_5 != null)
            {
                if (gclass85_5.method_125(AuroraComponentType.CargoShuttleBay) > 0M)
                    int_40 = 1;
                else if (gclass85_5.method_125(AuroraComponentType.MaintenanceModule) > 0M)
                    int_40 = 1;
            }

            foreach (ShipData gclass40 in list1)
                decimal_9 = gclass40.method_142(gclass85_5, list2, auroraElement_0, int_40, decimal_9);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 853);
        }
    }

    public void method_109(Decimal decimal_9)
    {
        try
        {
            List<ShipData> source = this.method_176();
            List<ShipData> list1 = source
                .Where<ShipData>(gclass40_0 =>
                    gclass40_0.Class.FuelTanker == 1 && gclass40_0.auroraRefuelStatus_0 != 0).ToList<ShipData>();
            if (list1.Count == 0 || source.Count <= list1.Count)
                return;
            foreach (ShipData gclass40 in source)
            {
                gclass40.bool_18 = false;
                gclass40.decimal_22 = gclass40.method_157(AuroraComponentType.FuelStorage, false);
            }

            List<ShipData> list2 = source.Where<ShipData>(gclass40_0 => gclass40_0.decimal_22 > 0M)
                .ToList<ShipData>();
            foreach (ShipData gclass40_1 in list1)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class952 class952 = new FleetData.Class952();
                // ISSUE: reference to a compiler-generated field
                class952.gclass40_0 = gclass40_1;
                // ISSUE: reference to a compiler-generated field
                if (class952.gclass40_0.method_167(AuroraComponentType.RefuellingSystem) > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    class952.bool_0 = false;
                    // ISSUE: reference to a compiler-generated field
                    if (class952.gclass40_0.Class.RefuellingRate < AuroraUtils.int_21)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class952.bool_0 = true;
                    }

                    // ISSUE: reference to a compiler-generated field
                    Decimal num1 = class952.gclass40_0.Class.RefuellingRate * (decimal_9 / 3600M);
                    if (this.LastMoveTime == this.gclass0_0.GameTime)
                        num1 *= this.Race.UnderwayReplenishmentRate;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    Decimal num2 = (int)class952.gclass40_0.decimal_14 - class952.gclass40_0.Class.MinimumFuel;
                    if (num1 < num2)
                        num2 = num1;
                    if (!(num2 <= 0M))
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        foreach (ShipData gclass40_2 in
                                 class952.gclass40_0.auroraRefuelStatus_0 != AuroraRefuelStatus.FleetTankers
                                     ? (class952.gclass40_0.auroraRefuelStatus_0 != AuroraRefuelStatus.Fleet
                                         ? list2.Where<ShipData>(class952.method_2)
                                             .OrderBy<ShipData, int>(gclass40_0 => gclass40_0.int_18)
                                             .ThenBy<ShipData, int>(gclass40_0 => gclass40_0.Class.RefuelPriority)
                                             .ThenBy<ShipData, Decimal>(gclass40_0 => gclass40_0.decimal_22)
                                             .ToList<ShipData>()
                                         : list2.Where<ShipData>(class952.method_1)
                                             .OrderBy<ShipData, int>(gclass40_0 => gclass40_0.int_18)
                                             .ThenBy<ShipData, int>(gclass40_0 => gclass40_0.Class.RefuelPriority)
                                             .ThenBy<ShipData, Decimal>(gclass40_0 => gclass40_0.decimal_22)
                                             .ToList<ShipData>())
                                     : list2.Where<ShipData>(class952.method_0)
                                         .OrderBy<ShipData, int>(gclass40_0 => gclass40_0.int_18)
                                         .ThenBy<ShipData, int>(gclass40_0 => gclass40_0.Class.RefuelPriority)
                                         .ThenBy<ShipData, Decimal>(gclass40_0 => gclass40_0.decimal_22)
                                         .ToList<ShipData>())
                        {
                            Decimal num3 = gclass40_2.decimal_22 - gclass40_2.decimal_14;
                            if (num3 > 0M)
                            {
                                gclass40_2.bool_18 = true;
                                if (num3 > num2)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    class952.gclass40_0.decimal_14 -= num2;
                                    gclass40_2.decimal_14 += num2;
                                    num2 = 0M;
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    class952.gclass40_0.decimal_14 -= num3;
                                    gclass40_2.decimal_14 = gclass40_2.decimal_22;
                                    num2 -= num3;
                                }
                            }

                            if (num2 == 0M)
                                break;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 854);
        }
    }

    public void method_110(Decimal decimal_9)
    {
        try
        {
            List<ShipData> list1 = this.gclass0_0.Ships.Values.Where<ShipData>(gclass40_0 =>
                gclass40_0.gclass85_0 == this && gclass40_0.gclass40_0 != null &&
                gclass40_0.decimal_14 < gclass40_0.Class.FuelCapacity).ToList<ShipData>();
            if (list1.Count == 0)
                return;
            List<ShipData> list2 = list1.Select<ShipData, ShipData>(gclass40_0 => gclass40_0.gclass40_0)
                .Distinct<ShipData>()
                .Where<ShipData>(gclass40_0 => gclass40_0.decimal_14 > gclass40_0.Class.MinimumFuel)
                .ToList<ShipData>();
            if (list2.Count == 0)
                return;
            foreach (ShipData gclass40 in list1)
                gclass40.decimal_22 = gclass40.method_157(AuroraComponentType.FuelStorage, false);
            foreach (ShipData gclass40_1 in list2)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class953 class953 = new FleetData.Class953();
                // ISSUE: reference to a compiler-generated field
                class953.gclass40_0 = gclass40_1;
                // ISSUE: reference to a compiler-generated field
                Decimal num1 = this.Race.MaxRefuellingRate * class953.gclass40_0.method_123(CommanderBonusType.CarrierOperations) *
                               (decimal_9 / 3600M);
                // ISSUE: reference to a compiler-generated method
                foreach (ShipData gclass40_2 in list1.Where<ShipData>(class953.method_0)
                             .OrderBy<ShipData, int>(gclass40_0 => gclass40_0.int_18)
                             .ThenBy<ShipData, int>(gclass40_0 => gclass40_0.Class.RefuelPriority)
                             .ThenBy<ShipData, Decimal>(gclass40_0 => gclass40_0.decimal_22)
                             .ToList<ShipData>())
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    Decimal num2 = (int)class953.gclass40_0.decimal_14 - class953.gclass40_0.Class.MinimumFuel;
                    if (!(num2 <= 0M))
                    {
                        if (num1 < num2)
                            num2 = num1;
                        Decimal num3 = gclass40_2.decimal_22 - gclass40_2.decimal_14;
                        if (!(num3 <= 0M))
                        {
                            if (num3 > num2)
                            {
                                // ISSUE: reference to a compiler-generated field
                                class953.gclass40_0.decimal_14 -= num2;
                                gclass40_2.decimal_14 += num2;
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                class953.gclass40_0.decimal_14 -= num3;
                                gclass40_2.decimal_14 = gclass40_2.decimal_22;
                            }
                        }
                    }
                    else
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 855);
        }
    }

    public void method_111(Decimal decimal_9)
    {
        try
        {
            List<ShipData> list1 = this.gclass0_0.Ships.Values.Where<ShipData>(gclass40_0 =>
                gclass40_0.gclass85_0 == this && gclass40_0.gclass40_0 != null &&
                gclass40_0.decimal_4 < gclass40_0.Class.MaintSupplies).ToList<ShipData>();
            if (list1.Count == 0)
                return;
            List<ShipData> list2 = list1.Select<ShipData, ShipData>(gclass40_0 => gclass40_0.gclass40_0)
                .Distinct<ShipData>()
                .Where<ShipData>(gclass40_0 => gclass40_0.decimal_14 > gclass40_0.Class.MinimumSupplies)
                .ToList<ShipData>();
            if (list2.Count == 0)
                return;
            foreach (ShipData gclass40 in list1)
                gclass40.decimal_23 = gclass40.method_172();
            foreach (ShipData gclass40_1 in list2)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class954 class954 = new FleetData.Class954();
                // ISSUE: reference to a compiler-generated field
                class954.gclass40_0 = gclass40_1;
                // ISSUE: reference to a compiler-generated field
                Decimal num1 = class954.gclass40_0.method_123(CommanderBonusType.CarrierOperations);
                Decimal num2 = AuroraUtils.decimal_26 * num1 * (decimal_9 / 3600M) * 2M;
                // ISSUE: reference to a compiler-generated method
                foreach (ShipData gclass40_2 in list1.Where<ShipData>(class954.method_0)
                             .OrderBy<ShipData, int>(gclass40_0 => gclass40_0.int_19)
                             .ThenBy<ShipData, int>(gclass40_0 => gclass40_0.Class.ResupplyPriority)
                             .ThenBy<ShipData, Decimal>(gclass40_0 => gclass40_0.decimal_22)
                             .ToList<ShipData>())
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    Decimal num3 = (int)class954.gclass40_0.decimal_4 - class954.gclass40_0.Class.MinimumSupplies;
                    if (num2 < num3)
                        num3 = num2;
                    if (!(num3 <= 0M))
                    {
                        Decimal num4 = gclass40_2.decimal_23 - gclass40_2.decimal_4;
                        if (!(num4 == 0M))
                        {
                            if (num4 > num3)
                            {
                                // ISSUE: reference to a compiler-generated field
                                class954.gclass40_0.decimal_4 -= num3;
                                gclass40_2.decimal_4 += num3;
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                class954.gclass40_0.decimal_4 -= num4;
                                gclass40_2.decimal_4 = gclass40_2.decimal_23;
                            }
                        }
                    }
                    else
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3366);
        }
    }

    public void method_112(Decimal decimal_9)
    {
        try
        {
            List<ShipData> source = this.method_176();
            List<ShipData> list = source
                .Where<ShipData>(gclass40_0 =>
                    gclass40_0.Class.SupplyShip == 1 && gclass40_0.auroraResupplyStatus_0 != 0)
                .ToList<ShipData>();
            if (list.Count == 0)
                return;
            foreach (ShipData gclass40 in source)
            {
                gclass40.bool_19 = false;
                gclass40.decimal_23 = gclass40.method_172();
            }

            foreach (ShipData gclass40_1 in list)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class955 class955 = new FleetData.Class955();
                // ISSUE: reference to a compiler-generated field
                class955.gclass40_0 = gclass40_1;
                // ISSUE: reference to a compiler-generated field
                if (class955.gclass40_0.method_167(AuroraComponentType.CargoShuttleBay) > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    Decimal num1 = AuroraUtils.decimal_26 * class955.gclass40_0.method_113(null, false) *
                                   (decimal_9 / 3600M);
                    if (this.LastMoveTime == this.gclass0_0.GameTime)
                        num1 *= this.Race.UnderwayReplenishmentRate;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    Decimal num2 = (int)class955.gclass40_0.decimal_4 - class955.gclass40_0.Class.MinimumSupplies;
                    if (num1 < num2)
                        num2 = num1;
                    if (!(num2 <= 0M))
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        foreach (ShipData gclass40_2 in
                                 class955.gclass40_0.auroraResupplyStatus_0 != AuroraResupplyStatus.Fleet
                                     ? source.Where<ShipData>(class955.method_0)
                                         .OrderBy<ShipData, int>(gclass40_0 => gclass40_0.int_19)
                                         .ThenBy<ShipData, int>(gclass40_0 => gclass40_0.Class.ResupplyPriority)
                                         .ThenBy<ShipData, Decimal>(gclass40_0 => gclass40_0.decimal_23)
                                         .ToList<ShipData>()
                                     : source
                                         .Where<ShipData>(gclass40_0 =>
                                             gclass40_0.Class.SupplyShip == 0 && !gclass40_0.bool_19)
                                         .OrderBy<ShipData, int>(gclass40_0 => gclass40_0.int_19)
                                         .ThenBy<ShipData, int>(gclass40_0 => gclass40_0.Class.ResupplyPriority)
                                         .ThenBy<ShipData, Decimal>(gclass40_0 => gclass40_0.decimal_23)
                                         .ToList<ShipData>())
                        {
                            Decimal num3 = gclass40_2.decimal_23 - gclass40_2.decimal_4;
                            if (num3 > 0M)
                            {
                                gclass40_2.bool_19 = true;
                                if (num3 > num2)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    class955.gclass40_0.decimal_4 -= num2;
                                    gclass40_2.decimal_4 += num2;
                                    num2 = 0M;
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    class955.gclass40_0.decimal_4 -= num3;
                                    gclass40_2.decimal_4 = gclass40_2.decimal_23;
                                    num2 -= num3;
                                }
                            }

                            if (num2 == 0M)
                                break;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 856);
        }
    }

    public Decimal method_113(Decimal decimal_9, MoveOrder gclass139_0)
    {
        try
        {
            if (!this.gclass0_0.FleetDictionary.ContainsKey(gclass139_0.DestinationID))
                return decimal_9;
            Decimal num1 = decimal_9;
            FleetData gclass85 = this.gclass0_0.FleetDictionary[gclass139_0.DestinationID];
            if (gclass85.LastMoveTime == this.gclass0_0.GameTime)
                return decimal_9;
            List<ShipData> gclass40List1 = new List<ShipData>();
            List<ShipData> gclass40List2 = new List<ShipData>();
            List<ShipData> source;
            List<ShipData> gclass40List3;
            if (gclass139_0.MoveActionType.MoveActionType != MoveActionType.RefuelFromStationaryTankers &&
                gclass139_0.MoveActionType.MoveActionType != MoveActionType.RefuelToMinimumFromStationaryTankers)
            {
                if (gclass139_0.MoveActionType.MoveActionType != MoveActionType.RefuelStationaryFleet &&
                    gclass139_0.MoveActionType.MoveActionType != MoveActionType.RefuelStationaryFleetToMinimum)
                    return decimal_9;
                source = gclass85.method_176();
                gclass40List3 = this.method_134();
            }
            else
            {
                source = this.method_176();
                gclass40List3 = gclass85.method_134();
            }

            if (gclass40List3 == null || gclass40List3.Count == 0)
                return decimal_9;
            foreach (ShipData gclass40 in source)
            {
                gclass40.bool_18 = false;
                gclass40.decimal_22 = gclass40.method_157(AuroraComponentType.FuelStorage, false);
            }

            foreach (ShipData gclass40_1 in gclass40List3)
            {
                if (gclass40_1.method_167(AuroraComponentType.RefuellingSystem) > 0)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    FleetData.Class956 class956 = new FleetData.Class956();
                    // ISSUE: reference to a compiler-generated field
                    class956.bool_0 = false;
                    if (gclass40_1.Class.RefuellingRate < AuroraUtils.int_21)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class956.bool_0 = true;
                    }

                    Decimal num2 = gclass40_1.Class.RefuellingRate * (decimal_9 / 3600M);
                    Decimal num3 = (int)gclass40_1.decimal_14 - gclass40_1.Class.MinimumFuel;
                    if (num2 < num3)
                        num3 = num2;
                    if (!(num3 <= 0M))
                    {
                        // ISSUE: reference to a compiler-generated method
                        foreach (ShipData gclass40_2 in source.Where<ShipData>(class956.method_0)
                                     .OrderBy<ShipData, int>(gclass40_0 => gclass40_0.int_18)
                                     .ThenBy<ShipData, int>(gclass40_0 => gclass40_0.Class.RefuelPriority)
                                     .ThenBy<ShipData, Decimal>(gclass40_0 => gclass40_0.decimal_22)
                                     .ToList<ShipData>())
                        {
                            Decimal num4 = gclass40_2.decimal_22 - gclass40_2.decimal_14;
                            if (gclass139_0.MaxItems > 0M && gclass139_0.MaxItems < gclass40_2.decimal_22)
                                num4 = gclass139_0.MaxItems - gclass40_2.decimal_14;
                            if (gclass139_0.MoveActionType.MoveActionType == MoveActionType.RefuelStationaryFleetToMinimum ||
                                gclass139_0.MoveActionType.MoveActionType == MoveActionType.RefuelStationaryFleetToMinimum)
                                num4 = gclass40_2.Class.MinimumFuel - gclass40_2.decimal_14;
                            if (num4 > 0M)
                            {
                                gclass40_2.bool_18 = true;
                                if (num4 > num3)
                                {
                                    gclass40_1.decimal_14 -= num3;
                                    gclass40_2.decimal_14 += num3;
                                    num3 = 0M;
                                    num1 = 0M;
                                }
                                else
                                {
                                    gclass40_1.decimal_14 -= num4;
                                    gclass40_2.decimal_14 += num4;
                                    num3 -= num4;
                                    if (num1 > decimal_9 * (num3 / num2))
                                        num1 = decimal_9 * (num3 / num2);
                                }
                            }

                            if (num3 == 0M)
                                break;
                        }
                    }
                }
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 858);
            return 0M;
        }
    }

    public Decimal method_114(Decimal decimal_9, MoveOrder gclass139_0)
    {
        try
        {
            if (!this.gclass0_0.FleetDictionary.ContainsKey(gclass139_0.DestinationID))
                return decimal_9;
            Decimal num1 = decimal_9;
            FleetData gclass85 = this.gclass0_0.FleetDictionary[gclass139_0.DestinationID];
            if (gclass85.LastMoveTime == this.gclass0_0.GameTime)
                return decimal_9;
            List<ShipData> gclass40List1 = new List<ShipData>();
            List<ShipData> gclass40List2 = new List<ShipData>();
            List<ShipData> source;
            List<ShipData> gclass40List3;
            if (gclass139_0.MoveActionType.MoveActionType == MoveActionType.ResupplyFromStationarySupplyShip)
            {
                source = this.method_176();
                gclass40List3 = gclass85.method_137();
            }
            else
            {
                if (gclass139_0.MoveActionType.MoveActionType != MoveActionType.ResupplyStationaryFleet)
                    return decimal_9;
                source = gclass85.method_176();
                gclass40List3 = this.method_137();
            }

            if (gclass40List3 == null || gclass40List3.Count == 0)
                return decimal_9;
            foreach (ShipData gclass40 in source)
            {
                gclass40.bool_19 = false;
                gclass40.decimal_23 = gclass40.method_172();
            }

            foreach (ShipData gclass40_1 in gclass40List3)
            {
                if (gclass40_1.method_167(AuroraComponentType.CargoShuttleBay) > 0)
                {
                    Decimal num2 = AuroraUtils.decimal_26 * gclass40_1.method_113(null, false) * (decimal_9 / 3600M);
                    Decimal num3 = (int)gclass40_1.decimal_4 - gclass40_1.Class.MinimumSupplies;
                    if (num2 < num3)
                        num3 = num2;
                    if (!(num3 <= 0M))
                    {
                        source = source.Where<ShipData>(gclass40_0 => !gclass40_0.bool_19)
                            .OrderBy<ShipData, int>(gclass40_0 => gclass40_0.int_19)
                            .ThenBy<ShipData, int>(gclass40_0 => gclass40_0.Class.ResupplyPriority)
                            .ThenBy<ShipData, Decimal>(gclass40_0 => gclass40_0.decimal_23)
                            .ToList<ShipData>();
                        foreach (ShipData gclass40_2 in source)
                        {
                            Decimal num4 = gclass40_2.decimal_23 - gclass40_2.decimal_4;
                            if (num4 > 0M)
                            {
                                gclass40_2.bool_19 = true;
                                if (num4 > num3)
                                {
                                    gclass40_1.decimal_4 -= num3;
                                    gclass40_2.decimal_4 += num3;
                                    num3 = 0M;
                                    num1 = 0M;
                                }
                                else
                                {
                                    gclass40_1.decimal_4 -= num4;
                                    gclass40_2.decimal_4 = gclass40_2.decimal_23;
                                    num3 -= num4;
                                    if (num1 > decimal_9 * (num3 / num2))
                                        num1 = decimal_9 * (num3 / num2);
                                }
                            }

                            if (num3 == 0M)
                                break;
                        }
                    }
                }
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 858);
            return 0M;
        }
    }

    public Decimal method_115(Decimal decimal_9, MoveOrder gclass139_0)
    {
        try
        {
            Decimal num1 = this.method_117(decimal_9, gclass139_0);
            Decimal num2 = this.method_118(decimal_9, gclass139_0);
            return num1 < num2 ? num1 : num2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 859);
            return 0M;
        }
    }

    public Decimal method_116(Decimal decimal_9, MoveOrder gclass139_0)
    {
        try
        {
            Decimal num1 = this.method_117(decimal_9, gclass139_0);
            Decimal num2 = this.method_118(decimal_9, gclass139_0);
            Decimal num3 = this.method_119(decimal_9, gclass139_0, GEnum43.const_0);
            Decimal num4;
            if (num2 < num1)
                return num4 = num2;
            return num3 < num1 ? (num4 = num3) : num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 860);
            return 0M;
        }
    }

    public Decimal method_117(Decimal decimal_9, MoveOrder gclass139_0)
    {
        try
        {
            if (gclass139_0.Population == null)
                return decimal_9;
            PopulationData gclass1460 = gclass139_0.Population;
            if (gclass1460.method_62(AuroraProductionCategory.RefuellingPoint) == 0M)
                return decimal_9;
            List<ShipData> gclass40List = this.method_176();
            Decimal num1 = decimal_9;
            Decimal num2 = this.Race.MaxRefuellingRate * (decimal_9 / 3600M);
            if (gclass1460.FuelStockpile <= 0M)
                return decimal_9;
            foreach (ShipData gclass40 in gclass40List)
            {
                if (gclass40.SurvivorsList.Count > 0 && gclass40.Race.NPR && gclass1460.Population >= 1M)
                    gclass40.method_116(gclass1460);
                Decimal num3 = gclass40.method_157(AuroraComponentType.FuelStorage, false);
                Decimal num4 = num3 - gclass40.decimal_14;
                if (gclass139_0.MaxItems > 0M && gclass139_0.MaxItems < num3)
                    num4 = gclass139_0.MaxItems - gclass40.decimal_14;
                if (num4 > 0M)
                {
                    Decimal num5 = gclass1460.FuelStockpile;
                    if (num2 < num5)
                        num5 = num2;
                    if (num4 >= num5)
                    {
                        gclass1460.FuelStockpile -= num5;
                        gclass40.decimal_14 += num5;
                        num1 = 0M;
                    }
                    else
                    {
                        Decimal num6 = num4 / num5 * decimal_9;
                        if (decimal_9 - num6 < num1)
                            num1 = (int)(decimal_9 - num6);
                        gclass1460.FuelStockpile -= num4;
                        gclass40.decimal_14 += num4;
                    }

                    if (gclass1460.FuelStockpile == 0M)
                        break;
                }
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 861);
            return 0M;
        }
    }

    public Decimal method_118(Decimal decimal_9, MoveOrder gclass139_0)
    {
        try
        {
            if (gclass139_0.Population == null)
                return decimal_9;
            PopulationData gclass1460 = gclass139_0.Population;
            if (gclass1460.MaintenanceStockpile <= 0M)
                return decimal_9;
            List<ShipData> gclass40List = this.method_176();
            Decimal num1 = decimal_9;
            Decimal num2 = AuroraUtils.decimal_26 * (decimal_9 / 3600M);
            foreach (ShipData gclass40 in gclass40List)
            {
                Decimal num3 = gclass40.method_113(gclass1460, true);
                if (!(num3 == 0M))
                {
                    gclass40.decimal_23 = gclass40.method_172();
                    Decimal num4 = gclass40.decimal_23 - gclass40.decimal_4;
                    Decimal num5 = num2 * num3;
                    if (num4 > 0M)
                    {
                        Decimal num6 = gclass1460.MaintenanceStockpile;
                        if (num5 < num6)
                            num6 = num5;
                        if (num4 >= num6)
                        {
                            gclass1460.MaintenanceStockpile -= num6;
                            gclass40.decimal_4 += num6;
                            num1 = 0M;
                        }
                        else
                        {
                            Decimal num7 = num4 / num6 * decimal_9;
                            if (decimal_9 - num7 < num1)
                                num1 = (int)(decimal_9 - num7);
                            gclass1460.MaintenanceStockpile -= num4;
                            gclass40.decimal_4 = gclass40.decimal_23;
                        }

                        if (gclass1460.MaintenanceStockpile == 0M)
                            break;
                    }
                }
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 862);
            return 0M;
        }
    }

    public Decimal method_119(Decimal decimal_9, MoveOrder gclass139_0, GEnum43 genum43_0)
    {
        try
        {
            if (gclass139_0.Population == null)
                return decimal_9;
            PopulationData gclass1460 = gclass139_0.Population;
            if (gclass1460.method_62(AuroraProductionCategory.OrdnanceTransferPoint) == 0M)
                return decimal_9;
            List<ShipData> list1 = this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0 == this && gclass40_0.method_183() > 0M)
                .ToList<ShipData>();
            Decimal num1 = decimal_9;
            Decimal num2 = 0M;
            bool flag = false;
            Decimal num3 = this.Race.MaxOrdnanceTransferRate * (decimal_9 / 3600M);
            if (gclass1460.OrdnanceStocks.Count == 0 && genum43_0 == GEnum43.const_0)
                return decimal_9;
            foreach (ShipData gclass40 in list1)
            {
                List<ShipOrdnance> source = gclass40.Class.OrdnanceTemplate;
                if (gclass40.ShipOrdnanceTemplate.Count > 0)
                    source = gclass40.ShipOrdnanceTemplate;
                gclass40.decimal_39 = num3 + gclass40.decimal_40;
                if (genum43_0 == GEnum43.const_1 || genum43_0 == GEnum43.const_2)
                {
                    foreach (ShipOrdnance gclass130_1 in gclass40.Ordnances
                                 .OrderByDescending<ShipOrdnance, Decimal>(
                                     gclass130_0 => gclass130_0.RaceMissile.Size).ToList<ShipOrdnance>())
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        FleetData.Class957 class957 = new FleetData.Class957();
                        // ISSUE: reference to a compiler-generated field
                        class957.gclass130_0 = gclass130_1;
                        int num4 = 0;
                        if (genum43_0 == GEnum43.const_1)
                        {
                            // ISSUE: reference to a compiler-generated field
                            num4 = class957.gclass130_0.Amount;
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated method
                            ShipOrdnance gclass130_2 = source.FirstOrDefault<ShipOrdnance>(class957.method_0);
                            if (gclass130_2 == null)
                            {
                                // ISSUE: reference to a compiler-generated field
                                num4 = class957.gclass130_0.Amount;
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (gclass130_2.Amount < class957.gclass130_0.Amount)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    num4 = class957.gclass130_0.Amount - gclass130_2.Amount;
                                }
                            }
                        }

                        if (num4 > 0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            int int_25 =
                                (int)Math.Floor(gclass40.decimal_39 / class957.gclass130_0.RaceMissile.Size);
                            if (int_25 > num4)
                                int_25 = num4;
                            if (int_25 > 0)
                            {
                                // ISSUE: reference to a compiler-generated field
                                class957.gclass130_0.Amount -= int_25;
                                // ISSUE: reference to a compiler-generated field
                                if (class957.gclass130_0.Amount == 0)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    gclass40.Ordnances.Remove(class957.gclass130_0);
                                }

                                // ISSUE: reference to a compiler-generated field
                                gclass1460.method_149(class957.gclass130_0.RaceMissile, int_25);
                                // ISSUE: reference to a compiler-generated field
                                gclass40.decimal_39 -= int_25 * class957.gclass130_0.RaceMissile.Size;
                                // ISSUE: reference to a compiler-generated field
                                if (class957.gclass130_0.RaceMissile.Size > num2)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    num2 = class957.gclass130_0.RaceMissile.Size;
                                }
                            }
                            else if (num4 > 0)
                                flag = true;
                        }
                    }
                }

                if (genum43_0 == GEnum43.const_0 || genum43_0 == GEnum43.const_2)
                {
                    Decimal num5 = gclass40.method_210();
                    if (num5 > 0M)
                    {
                        List<ShipOrdnance> list2 = source
                            .OrderByDescending<ShipOrdnance, Decimal>(gclass130_0 => gclass130_0.RaceMissile.Size)
                            .ToList<ShipOrdnance>();
                        if (list2 != null)
                        {
                            foreach (ShipOrdnance gclass130_3 in list2)
                            {
                                // ISSUE: object of a compiler-generated type is created
                                // ISSUE: variable of a compiler-generated type
                                FleetData.Class958 class958 = new FleetData.Class958();
                                // ISSUE: reference to a compiler-generated field
                                class958.gclass130_0 = gclass130_3;
                                // ISSUE: reference to a compiler-generated method
                                ShipOrdnance gclass130_4 = gclass40.Ordnances.FirstOrDefault<ShipOrdnance>(class958.method_0);
                                // ISSUE: reference to a compiler-generated field
                                int num6 = class958.gclass130_0.Amount;
                                if (gclass130_4 != null)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    num6 = class958.gclass130_0.Amount - gclass130_4.Amount;
                                }

                                if (num6 > 0)
                                {
                                    // ISSUE: reference to a compiler-generated method
                                    ShipOrdnance gclass130_5 =
                                        gclass1460.OrdnanceStocks.FirstOrDefault<ShipOrdnance>(class958.method_1);
                                    if (gclass130_5 != null)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        int int_40 = (int)Math.Floor(gclass40.decimal_39 /
                                                                     class958.gclass130_0.RaceMissile.Size);
                                        if (int_40 > num6)
                                            int_40 = num6;
                                        if (int_40 > gclass130_5.Amount)
                                            int_40 = gclass130_5.Amount;
                                        // ISSUE: reference to a compiler-generated field
                                        if (int_40 * class958.gclass130_0.RaceMissile.Size > num5)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            int_40 = (int)Math.Floor(num5 / class958.gclass130_0.RaceMissile.Size);
                                        }

                                        if (int_40 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            gclass40.method_115(class958.gclass130_0.RaceMissile, int_40);
                                            gclass130_5.Amount -= int_40;
                                            if (gclass130_5.Amount == 0)
                                                gclass1460.OrdnanceStocks.Remove(gclass130_5);
                                            // ISSUE: reference to a compiler-generated field
                                            gclass40.decimal_39 -= int_40 * class958.gclass130_0.RaceMissile.Size;
                                            // ISSUE: reference to a compiler-generated field
                                            if (class958.gclass130_0.RaceMissile.Size > num2)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                num2 = class958.gclass130_0.RaceMissile.Size;
                                            }
                                        }
                                        else if (num6 > 0)
                                            flag = true;
                                    }
                                }
                            }
                        }
                    }
                }

                if (!(gclass40.decimal_39 < num2) && !flag)
                {
                    Decimal num7 = decimal_9 * (gclass40.decimal_39 / num3);
                    if (num7 < num1)
                        num1 = num7;
                    gclass40.decimal_40 = 0M;
                }
                else
                {
                    gclass40.decimal_40 = gclass40.decimal_39;
                    num1 = 0M;
                }
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 863);
            return 0M;
        }
    }

    public Decimal method_120(Decimal decimal_9, MoveOrder gclass139_0, GEnum43 genum43_0)
    {
        try
        {
            if (!this.gclass0_0.FleetDictionary.ContainsKey(gclass139_0.DestinationID))
                return decimal_9;
            List<ShipData> list = this.gclass0_0.Ships.Values.Where<ShipData>(gclass40_0 =>
                    gclass40_0.gclass85_0 == this && gclass40_0.method_157(AuroraComponentType.Magazine, false) > 0M)
                .ToList<ShipData>();
            List<ShipData> gclass40List = this.gclass0_0.FleetDictionary[gclass139_0.DestinationID].method_138();
            if (gclass40List.Count == 0)
                return decimal_9;
            Decimal num1 = decimal_9;
            Decimal num2 = 0M;
            Decimal num3 = this.Race.MaxOrdnanceTransferRate * (decimal_9 / 3600M);
            foreach (ShipData gclass40 in list)
                gclass40.decimal_39 = num3 + gclass40.decimal_40;
            foreach (ShipData gclass40_1 in gclass40List)
            {
                if (gclass40_1.Ordnances.Count != 0 || genum43_0 != GEnum43.const_0)
                {
                    foreach (ShipData gclass40_2 in list)
                    {
                        List<ShipOrdnance> source = gclass40_2.Class.OrdnanceTemplate;
                        if (gclass40_2.ShipOrdnanceTemplate.Count > 0)
                            source = gclass40_2.ShipOrdnanceTemplate;
                        if (genum43_0 == GEnum43.const_1 || genum43_0 == GEnum43.const_2)
                        {
                            Decimal num4 = gclass40_1.method_210();
                            if (num4 > 0M)
                            {
                                foreach (ShipOrdnance gclass130_1 in gclass40_2.Ordnances
                                             .OrderByDescending<ShipOrdnance, Decimal>(gclass130_0 =>
                                                 gclass130_0.RaceMissile.Size).ToList<ShipOrdnance>())
                                {
                                    // ISSUE: object of a compiler-generated type is created
                                    // ISSUE: variable of a compiler-generated type
                                    FleetData.Class959 class959 = new FleetData.Class959();
                                    // ISSUE: reference to a compiler-generated field
                                    class959.gclass130_0 = gclass130_1;
                                    int num5 = 0;
                                    if (genum43_0 == GEnum43.const_1)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        num5 = class959.gclass130_0.Amount;
                                    }
                                    else
                                    {
                                        // ISSUE: reference to a compiler-generated method
                                        ShipOrdnance gclass130_2 = source.FirstOrDefault<ShipOrdnance>(class959.method_0);
                                        if (gclass130_2 == null)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            num5 = class959.gclass130_0.Amount;
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (gclass130_2.Amount < class959.gclass130_0.Amount)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                num5 = class959.gclass130_0.Amount - gclass130_2.Amount;
                                            }
                                        }
                                    }

                                    if (num5 > 0)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        int int_40 = (int)Math.Floor(gclass40_2.decimal_39 /
                                                                     class959.gclass130_0.RaceMissile.Size);
                                        if (int_40 > num5)
                                            int_40 = num5;
                                        // ISSUE: reference to a compiler-generated field
                                        if (int_40 * class959.gclass130_0.RaceMissile.Size > num4)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            int_40 = (int)Math.Floor(num4 / class959.gclass130_0.RaceMissile.Size);
                                        }

                                        if (int_40 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class959.gclass130_0.Amount -= int_40;
                                            // ISSUE: reference to a compiler-generated field
                                            if (class959.gclass130_0.Amount == 0)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                gclass40_2.Ordnances.Remove(class959.gclass130_0);
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            gclass40_1.method_115(class959.gclass130_0.RaceMissile, int_40);
                                            // ISSUE: reference to a compiler-generated field
                                            gclass40_2.decimal_39 -=
                                                int_40 * class959.gclass130_0.RaceMissile.Size;
                                            // ISSUE: reference to a compiler-generated field
                                            if (class959.gclass130_0.RaceMissile.Size > num2)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                num2 = class959.gclass130_0.RaceMissile.Size;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (genum43_0 == GEnum43.const_0 || genum43_0 == GEnum43.const_2)
                        {
                            Decimal num6 = gclass40_2.method_210();
                            foreach (ShipOrdnance gclass130_3 in source
                                         .OrderByDescending<ShipOrdnance, Decimal>(gclass130_0 =>
                                             gclass130_0.RaceMissile.Size).ToList<ShipOrdnance>())
                            {
                                // ISSUE: object of a compiler-generated type is created
                                // ISSUE: variable of a compiler-generated type
                                FleetData.Class960 class960 = new FleetData.Class960();
                                // ISSUE: reference to a compiler-generated field
                                class960.gclass130_0 = gclass130_3;
                                // ISSUE: reference to a compiler-generated method
                                ShipOrdnance gclass130_4 = gclass40_2.Ordnances.FirstOrDefault<ShipOrdnance>(class960.method_0);
                                // ISSUE: reference to a compiler-generated field
                                int num7 = class960.gclass130_0.Amount;
                                if (gclass130_4 != null)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    num7 = class960.gclass130_0.Amount - gclass130_4.Amount;
                                }

                                if (num7 > 0)
                                {
                                    // ISSUE: reference to a compiler-generated method
                                    ShipOrdnance gclass130_5 =
                                        gclass40_1.Ordnances.FirstOrDefault<ShipOrdnance>(class960.method_1);
                                    if (gclass130_5 != null)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        int int_40 = (int)Math.Floor(gclass40_2.decimal_39 /
                                                                     class960.gclass130_0.RaceMissile.Size);
                                        if (int_40 > num7)
                                            int_40 = num7;
                                        if (int_40 > gclass130_5.Amount)
                                            int_40 = gclass130_5.Amount;
                                        // ISSUE: reference to a compiler-generated field
                                        if (int_40 * class960.gclass130_0.RaceMissile.Size > num6)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            int_40 = (int)Math.Floor(num6 / class960.gclass130_0.RaceMissile.Size);
                                        }

                                        if (int_40 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            gclass40_2.method_115(class960.gclass130_0.RaceMissile, int_40);
                                            gclass130_5.Amount -= int_40;
                                            if (gclass130_5.Amount == 0)
                                                gclass40_1.Ordnances.Remove(gclass130_5);
                                            // ISSUE: reference to a compiler-generated field
                                            gclass40_2.decimal_39 -=
                                                int_40 * class960.gclass130_0.RaceMissile.Size;
                                            // ISSUE: reference to a compiler-generated field
                                            if (class960.gclass130_0.RaceMissile.Size > num2)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                num2 = class960.gclass130_0.RaceMissile.Size;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (gclass40_2.decimal_39 < num2)
                        {
                            gclass40_2.decimal_40 = gclass40_2.decimal_39;
                            num1 = 0M;
                        }
                        else
                        {
                            Decimal num8 = decimal_9 * (gclass40_2.decimal_39 / num3);
                            if (num8 < num1)
                                num1 = num8;
                            gclass40_2.decimal_40 = 0M;
                        }
                    }
                }
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 864);
            return 0M;
        }
    }

    public Decimal method_121(Decimal decimal_9)
    {
        try
        {
            List<ShipData> list = this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0 == this && gclass40_0.Class.Collier == 1)
                .OrderByDescending<ShipData, int>(gclass40_0 => gclass40_0.Class.OrdnanceTransferRate)
                .ToList<ShipData>();
            if (list.Count == 0)
                return decimal_9;
            Decimal num1 = decimal_9;
            Decimal num2 = 0M;
            GEnum43 genum43 = GEnum43.const_0;
            foreach (ShipData gclass40_1 in list)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class961 class961 = new FleetData.Class961();
                // ISSUE: reference to a compiler-generated field
                class961.gclass40_0 = gclass40_1;
                // ISSUE: reference to a compiler-generated field
                if (class961.gclass40_0.auroraOrdnanceTransferStatus_0 != AuroraOrdnanceTransferStatus.None)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class961.gclass40_0.auroraOrdnanceTransferStatus_0 != AuroraOrdnanceTransferStatus.LoadFleet &&
                        class961.gclass40_0.auroraOrdnanceTransferStatus_0 != AuroraOrdnanceTransferStatus.LoadSubFleet)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class961.gclass40_0.auroraOrdnanceTransferStatus_0 !=
                            AuroraOrdnanceTransferStatus.ReplaceFleet &&
                            class961.gclass40_0.auroraOrdnanceTransferStatus_0 !=
                            AuroraOrdnanceTransferStatus.ReplaceSubFleet)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (class961.gclass40_0.auroraOrdnanceTransferStatus_0 ==
                                AuroraOrdnanceTransferStatus.RemoveFleet ||
                                class961.gclass40_0.auroraOrdnanceTransferStatus_0 ==
                                AuroraOrdnanceTransferStatus.RemoveSubFleet)
                                genum43 = GEnum43.const_1;
                        }
                        else
                            genum43 = GEnum43.const_2;
                    }
                    else
                        genum43 = GEnum43.const_0;

                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    List<ShipData> gclass40List =
                        class961.gclass40_0.auroraOrdnanceTransferStatus_0 == AuroraOrdnanceTransferStatus.LoadFleet ||
                        class961.gclass40_0.auroraOrdnanceTransferStatus_0 ==
                        AuroraOrdnanceTransferStatus.ReplaceFleet ||
                        class961.gclass40_0.auroraOrdnanceTransferStatus_0 == AuroraOrdnanceTransferStatus.RemoveFleet
                            ? this.gclass0_0.Ships.Values.Where<ShipData>(gclass40_0 =>
                                gclass40_0.gclass85_0 == this && gclass40_0.Class.Collier == 0 &&
                                gclass40_0.method_181() > 0M).ToList<ShipData>()
                            : this.gclass0_0.Ships.Values.Where<ShipData>(class961.method_0)
                                .ToList<ShipData>();
                    // ISSUE: reference to a compiler-generated field
                    if (gclass40List.Count != 0 &&
                        (class961.gclass40_0.Ordnances.Count != 0 || genum43 != GEnum43.const_0))
                    {
                        // ISSUE: reference to a compiler-generated field
                        Decimal num3 = class961.gclass40_0.Class.OrdnanceTransferRate * (decimal_9 / 3600M);
                        if (this.LastMoveTime == this.gclass0_0.GameTime)
                            num3 *= this.Race.UnderwayReplenishmentRate;
                        if (!(num3 == 0M))
                        {
                            foreach (ShipData gclass40_2 in gclass40List)
                            {
                                List<ShipOrdnance> source = gclass40_2.Class.OrdnanceTemplate;
                                if (gclass40_2.ShipOrdnanceTemplate.Count > 0)
                                    source = gclass40_2.ShipOrdnanceTemplate;
                                gclass40_2.decimal_39 = num3 + gclass40_2.decimal_40;
                                if (genum43 == GEnum43.const_1 || genum43 == GEnum43.const_2)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    Decimal num4 = class961.gclass40_0.method_208();
                                    if (num4 > 0M)
                                    {
                                        foreach (ShipOrdnance gclass130_1 in gclass40_2.Ordnances
                                                     .Where<ShipOrdnance>(gclass130_0 =>
                                                         gclass130_0.RaceMissile.ShipDecoy == 0)
                                                     .OrderByDescending<ShipOrdnance, Decimal>(gclass130_0 =>
                                                         gclass130_0.RaceMissile.Size).ToList<ShipOrdnance>())
                                        {
                                            // ISSUE: object of a compiler-generated type is created
                                            // ISSUE: variable of a compiler-generated type
                                            FleetData.Class962 class962 = new FleetData.Class962();
                                            // ISSUE: reference to a compiler-generated field
                                            class962.gclass130_0 = gclass130_1;
                                            int num5 = 0;
                                            if (genum43 == GEnum43.const_1)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                num5 = class962.gclass130_0.Amount;
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated method
                                                ShipOrdnance gclass130_2 =
                                                    source.FirstOrDefault<ShipOrdnance>(class962.method_0);
                                                if (gclass130_2 == null)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    num5 = class962.gclass130_0.Amount;
                                                }
                                                else
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (gclass130_2.Amount < class962.gclass130_0.Amount)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        num5 = class962.gclass130_0.Amount - gclass130_2.Amount;
                                                    }
                                                }
                                            }

                                            if (num5 > 0)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                int int_40 = (int)Math.Floor(gclass40_2.decimal_39 /
                                                                             class962.gclass130_0.RaceMissile
                                                                                 .Size);
                                                if (int_40 > num5)
                                                    int_40 = num5;
                                                // ISSUE: reference to a compiler-generated field
                                                if (int_40 * class962.gclass130_0.RaceMissile.Size > num4)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    int_40 = (int)Math.Floor(num4 / class962.gclass130_0.RaceMissile
                                                        .Size);
                                                }

                                                if (int_40 > 0)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    class962.gclass130_0.Amount -= int_40;
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class962.gclass130_0.Amount == 0)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        gclass40_2.Ordnances.Remove(class962.gclass130_0);
                                                    }

                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    class961.gclass40_0.method_115(class962.gclass130_0.RaceMissile,
                                                        int_40);
                                                    // ISSUE: reference to a compiler-generated field
                                                    gclass40_2.decimal_39 -=
                                                        int_40 * class962.gclass130_0.RaceMissile.Size;
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class962.gclass130_0.RaceMissile.Size > num2)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        num2 = class962.gclass130_0.RaceMissile.Size;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                if (genum43 == GEnum43.const_0 || genum43 == GEnum43.const_2)
                                {
                                    Decimal num6 = gclass40_2.method_208();
                                    foreach (ShipOrdnance gclass130_3 in source
                                                 .Where<ShipOrdnance>(gclass130_0 => gclass130_0.RaceMissile.ShipDecoy == 0)
                                                 .OrderByDescending<ShipOrdnance, Decimal>(gclass130_0 =>
                                                     gclass130_0.RaceMissile.Size).ToList<ShipOrdnance>())
                                    {
                                        // ISSUE: object of a compiler-generated type is created
                                        // ISSUE: variable of a compiler-generated type
                                        FleetData.Class963 class963 = new FleetData.Class963();
                                        // ISSUE: reference to a compiler-generated field
                                        class963.gclass130_0 = gclass130_3;
                                        // ISSUE: reference to a compiler-generated method
                                        ShipOrdnance gclass130_4 =
                                            gclass40_2.Ordnances.FirstOrDefault<ShipOrdnance>(class963.method_0);
                                        // ISSUE: reference to a compiler-generated field
                                        int num7 = class963.gclass130_0.Amount;
                                        if (gclass130_4 != null)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            num7 = class963.gclass130_0.Amount - gclass130_4.Amount;
                                        }

                                        if (num7 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated method
                                            ShipOrdnance gclass130_5 =
                                                class961.gclass40_0.Ordnances
                                                    .FirstOrDefault<ShipOrdnance>(class963.method_1);
                                            if (gclass130_5 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                if (gclass40_2.decimal_39 < class963.gclass130_0.RaceMissile.Size)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    num2 = class963.gclass130_0.RaceMissile.Size;
                                                }
                                                else
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    int int_40 = (int)Math.Floor(gclass40_2.decimal_39 /
                                                        class963.gclass130_0.RaceMissile.Size);
                                                    if (int_40 > num7)
                                                        int_40 = num7;
                                                    if (int_40 > gclass130_5.Amount)
                                                        int_40 = gclass130_5.Amount;
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (int_40 * class963.gclass130_0.RaceMissile.Size > num6)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        int_40 = (int)Math.Floor(num6 /
                                                            class963.gclass130_0.RaceMissile.Size);
                                                    }

                                                    if (int_40 > 0)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        gclass40_2.method_115(class963.gclass130_0.RaceMissile, int_40);
                                                        gclass130_5.Amount -= int_40;
                                                        if (gclass130_5.Amount == 0)
                                                        {
                                                            // ISSUE: reference to a compiler-generated field
                                                            class961.gclass40_0.Ordnances.Remove(gclass130_5);
                                                        }

                                                        // ISSUE: reference to a compiler-generated field
                                                        gclass40_2.decimal_39 -=
                                                            int_40 * class963.gclass130_0.RaceMissile.Size;
                                                        // ISSUE: reference to a compiler-generated field
                                                        if (class963.gclass130_0.RaceMissile.Size > num2)
                                                        {
                                                            // ISSUE: reference to a compiler-generated field
                                                            num2 = class963.gclass130_0.RaceMissile.Size;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                if (gclass40_2.decimal_39 < num2)
                                {
                                    gclass40_2.decimal_40 = gclass40_2.decimal_39;
                                    num1 = 0M;
                                }
                                else
                                {
                                    Decimal num8 = decimal_9 * (gclass40_2.decimal_39 / num3);
                                    if (num8 < num1)
                                        num1 = num8;
                                    gclass40_2.decimal_40 = 0M;
                                }
                            }
                        }
                    }
                }
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 865);
            return 0M;
        }
    }

    public Decimal method_122(Decimal decimal_9, MoveOrder gclass139_0)
    {
        try
        {
            if (gclass139_0.Population == null ||
                !this.gclass0_0.Populations.ContainsKey(gclass139_0.Population.PopulationID))
                return decimal_9;
            PopulationData gclass146 = this.gclass0_0.Populations[gclass139_0.Population.PopulationID];
            if (gclass146.method_62(AuroraProductionCategory.RefuellingPoint) == 0M)
                return decimal_9;
            List<ShipData> list = this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.Class.FuelTanker == 1 && gclass40_0.gclass85_0 == this)
                .ToList<ShipData>();
            if (list.Count == 0)
                return decimal_9;
            Decimal num1 = decimal_9;
            foreach (ShipData gclass40 in list)
            {
                if (gclass40.method_167(AuroraComponentType.RefuellingSystem) != 0)
                {
                    Decimal num2 = gclass40.Class.RefuellingRate * (decimal_9 / 3600M);
                    Decimal num3 = gclass40.decimal_14 - gclass40.Class.MinimumFuel;
                    if (num3 > 0M)
                    {
                        if (num2 > num3)
                        {
                            Decimal num4 = num3 / num2 * decimal_9;
                            if (decimal_9 - num4 < num1)
                                num1 = (int)(decimal_9 - num4);
                            gclass146.FuelStockpile += num3;
                            gclass40.decimal_14 -= num3;
                        }
                        else
                        {
                            gclass146.FuelStockpile += num2;
                            gclass40.decimal_14 -= num2;
                            num1 = 0M;
                        }
                    }
                }
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 866);
            return 0M;
        }
    }

    public Decimal method_123(Decimal decimal_9, MoveOrder gclass139_0)
    {
        try
        {
            if (gclass139_0.Population == null ||
                !this.gclass0_0.Populations.ContainsKey(gclass139_0.Population.PopulationID))
                return decimal_9;
            PopulationData gclass146_0 = this.gclass0_0.Populations[gclass139_0.Population.PopulationID];
            List<ShipData> list = this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.Class.SupplyShip == 1 && gclass40_0.gclass85_0 == this)
                .ToList<ShipData>();
            if (list.Count == 0)
                return decimal_9;
            Decimal num1 = decimal_9;
            Decimal num2 = AuroraUtils.decimal_26 * (decimal_9 / 3600M);
            foreach (ShipData gclass40 in list)
            {
                Decimal num3 = gclass40.method_113(gclass146_0, true);
                if (!(num3 == 0M))
                {
                    Decimal num4 = num2 * num3;
                    Decimal num5 = gclass40.decimal_4 - gclass40.Class.MinimumSupplies;
                    if (num5 > 0M)
                    {
                        if (num4 > num5)
                        {
                            Decimal num6 = num5 / num4 * decimal_9;
                            if (decimal_9 - num6 < num1)
                                num1 = (int)(decimal_9 - num6);
                            gclass146_0.MaintenanceStockpile += num5;
                            gclass40.decimal_4 -= num5;
                        }
                        else
                        {
                            gclass146_0.MaintenanceStockpile += num4;
                            gclass40.decimal_4 -= num4;
                            num1 = 0M;
                        }
                    }
                }
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 867);
            return 0M;
        }
    }

    public bool method_124(GEnum26 genum26_0)
    {
        try
        {
            List<ShipData> source = this.method_176();
            switch (genum26_0)
            {
                case GEnum26.const_0:
                    if (source.SelectMany<ShipData, TransportedColonist>(gclass40_0 => gclass40_0.TransportedColonists)
                            .Sum<TransportedColonist>(gclass181_0 => gclass181_0.Amount) > 0)
                        return true;
                    break;
                case GEnum26.const_1:
                    if (source.Sum<ShipData>(gclass40_0 => gclass40_0.TransportedInstallations.Count) > 0)
                        return true;
                    break;
                case GEnum26.const_2:
                    if (source.Sum<ShipData>(gclass40_0 => gclass40_0.TransportedMineral.GetTotalAmount()) > 0M)
                        return true;
                    break;
                case GEnum26.const_3:
                    if (source.Sum<ShipData>(gclass40_0 => gclass40_0.method_196()) > 0)
                        return true;
                    break;
                case GEnum26.const_4:
                    if (source.Sum<ShipData>(gclass40_0 => gclass40_0.TransportedComponents.Count) > 0)
                        return true;
                    break;
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 869);
            return false;
        }
    }

    public Decimal method_125(AuroraComponentType auroraComponentType_0)
    {
        try
        {
            return this.method_126(auroraComponentType_0, null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3471);
            return 0M;
        }
    }

    public Decimal method_126(AuroraComponentType auroraComponentType_0, SubFleet gclass84_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class964 class964 = new FleetData.Class964();
        // ISSUE: reference to a compiler-generated field
        class964.auroraComponentType_0 = auroraComponentType_0;
        // ISSUE: reference to a compiler-generated field
        class964.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class964.gclass84_0 = gclass84_0;
        try
        {
            Decimal num1 = 0M;
            // ISSUE: reference to a compiler-generated method
            List<ShipData> list = this.gclass0_0.Ships.Values
                .Where<ShipData>(class964.method_0).ToList<ShipData>();
            // ISSUE: reference to a compiler-generated field
            if (class964.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated method
                list = list.Where<ShipData>(class964.method_1).ToList<ShipData>();
            }

            foreach (ShipData gclass40 in list)
            {
                // ISSUE: reference to a compiler-generated field
                num1 += gclass40.method_157(class964.auroraComponentType_0, true);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (gclass40.int_11 < gclass40.Class.Crew &&
                    (class964.auroraComponentType_0 == AuroraComponentType.GeologicalSurveySensors ||
                     class964.auroraComponentType_0 == AuroraComponentType.GravitationalSurveySensors))
                {
                    Decimal num2 = gclass40.int_11 / (Decimal)gclass40.Class.Crew;
                    num1 *= num2;
                }
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 870);
            return 0M;
        }
    }

    public int method_127(AuroraComponentType auroraComponentType_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class965 class965 = new FleetData.Class965();
        // ISSUE: reference to a compiler-generated field
        class965.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class965.auroraComponentType_0 = auroraComponentType_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.Ships.Values.Where<ShipData>(class965.method_0)
                .Sum<ShipData>(class965.method_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 871);
            return 0;
        }
    }

    public int method_128()
    {
        try
        {
            return this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0 == this)
                .SelectMany<ShipData, ClassComponent>(gclass40_0 => gclass40_0.Class.ClassComponents.Values)
                .Where<ClassComponent>(gclass228_0 => gclass228_0.Component.bool_4).Count<ClassComponent>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 872);
            return 0;
        }
    }

    public bool method_129(FleetData gclass85_5)
    {
        try
        {
            List<ShipData> list = this.gclass0_0.Ships.Values.Where<ShipData>(gclass40_0 =>
                gclass40_0.gclass85_0 == this && gclass40_0.method_167(AuroraComponentType.RefuellingSystem) > 0 &&
                gclass40_0.Class.FuelTanker == 1 && gclass40_0.gclass40_0 == null).ToList<ShipData>();
            return list.Count != 0 && (gclass85_5 == null ||
                                       list.Max<ShipData, bool>(gclass40_0 =>
                                           gclass40_0.Class.RefuellingRate >= AuroraUtils.int_21) ||
                                       gclass85_5.method_176()
                                           .Max<ShipData>(gclass40_0 => gclass40_0.Class.Size) <= 20M);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 873);
            return false;
        }
    }

    public bool method_130()
    {
        try
        {
            return this.gclass0_0.Ships.Values.Where<ShipData>(gclass40_0 =>
                gclass40_0.gclass85_0 == this &&
                gclass40_0.method_167(AuroraComponentType.OrdnanceTransferSystem) > 0 &&
                gclass40_0.Class.Collier == 1).Count<ShipData>() > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 874);
            return false;
        }
    }

    public bool method_131()
    {
        try
        {
            return this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0 == this)
                .Where<ShipData>(gclass40_0 => gclass40_0.method_183() > 0M).Count<ShipData>() > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 875);
            return false;
        }
    }

    public bool method_132()
    {
        try
        {
            return this.gclass0_0.SubFleetDictionary.Values.Where<SubFleet>(gclass84_0 => gclass84_0.ParentFleet == this)
                .Count<SubFleet>() > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 876);
            return false;
        }
    }

    public bool method_133()
    {
        try
        {
            return this.gclass0_0.Ships.Values.Where<ShipData>(gclass40_0 =>
                    gclass40_0.gclass85_0 == this && gclass40_0.method_167(AuroraComponentType.OrdnanceTransferHub) > 0)
                .Count<ShipData>() > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 878);
            return false;
        }
    }

    public List<ShipData> method_134()
    {
        try
        {
            return this.MoveOrderDictionary.Count > 0 &&
                   !this.MoveOrderDictionary.First<KeyValuePair<int, MoveOrder>>().Value.MoveActionType.StationaryAction
                ? null
                : this.gclass0_0.Ships.Values
                    .Where<ShipData>(gclass40_0 =>
                        gclass40_0.gclass85_0 == this &&
                        gclass40_0.method_167(AuroraComponentType.RefuellingSystem) > 0 &&
                        gclass40_0.Class.FuelTanker == 1)
                    .OrderByDescending<ShipData, Decimal>(gclass40_0 =>
                        gclass40_0.decimal_14 / gclass40_0.Class.FuelCapacity).ToList<ShipData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 880);
            return null;
        }
    }

    public bool method_135()
    {
        try
        {
            return this.MoveOrderDictionary.Count <= 0 && this.list_3.FirstOrDefault<ShipData>(gclass40_0 =>
                gclass40_0.method_167(AuroraComponentType.RefuellingSystem) > 0 && gclass40_0.Class.FuelTanker == 1 &&
                gclass40_0.decimal_14 > gclass40_0.Class.MinimumFuel * 2) != null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3927);
            return false;
        }
    }

    public bool method_136()
    {
        try
        {
            if (this.MoveOrderDictionary.Count > 0)
                return false;
            ShipData gclass40_1 = this.list_3.FirstOrDefault<ShipData>(gclass40_0 =>
                gclass40_0.method_167(AuroraComponentType.RefuellingSystem) > 0 && gclass40_0.Class.FuelTanker == 1 &&
                gclass40_0.decimal_14 > gclass40_0.Class.MinimumFuel * 2);
            ShipData gclass40_2 = this.list_3.FirstOrDefault<ShipData>(gclass40_0 =>
                gclass40_0.method_167(AuroraComponentType.CargoShuttleBay) > 0 && gclass40_0.Class.SupplyShip == 1 &&
                gclass40_0.decimal_4 > 0M);
            return gclass40_1 != null && gclass40_2 != null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3928);
            return false;
        }
    }

    public List<ShipData> method_137()
    {
        try
        {
            return this.MoveOrderDictionary.Count > 0 &&
                   !this.MoveOrderDictionary.First<KeyValuePair<int, MoveOrder>>().Value.MoveActionType.StationaryAction
                ? null
                : this.gclass0_0.Ships.Values.Where<ShipData>(gclass40_0 =>
                    gclass40_0.gclass85_0 == this && gclass40_0.method_167(AuroraComponentType.CargoShuttleBay) > 0 &&
                    gclass40_0.Class.SupplyShip == 1).ToList<ShipData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 880);
            return null;
        }
    }

    public List<ShipData> method_138()
    {
        try
        {
            return this.MoveOrderDictionary.Count > 0
                ? null
                : this.gclass0_0.Ships.Values.Where<ShipData>(gclass40_0 =>
                        gclass40_0.gclass85_0 == this &&
                        gclass40_0.method_167(AuroraComponentType.OrdnanceTransferHub) > 0)
                    .ToList<ShipData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 881);
            return null;
        }
    }

    public bool method_139()
    {
        try
        {
            return this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0 == this && gclass40_0.Class.SupplyShip == 1)
                .Count<ShipData>() > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 882);
            return false;
        }
    }

    public int method_140()
    {
        return (int)this.gclass0_0.Ships.Values
            .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0 == this).Sum<ShipData>(gclass40_0 =>
                gclass40_0.method_157(AuroraComponentType.FuelStorage, false));
    }

    public Decimal method_141()
    {
        try
        {
            return (int)this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0 == this)
                .Sum<ShipData>(gclass40_0 => gclass40_0.method_172());
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3480);
            return 0M;
        }
    }

    public Decimal method_142()
    {
        return (int)this.gclass0_0.Ships.Values
            .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0 == this && !gclass40_0.Class.Commercial)
            .Sum<ShipData>(gclass40_0 => gclass40_0.Class.Size) * AuroraUtils.decimal_17;
    }

    public int method_143()
    {
        return (int)this.gclass0_0.Ships.Values
            .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0 == this).Sum<ShipData>(gclass40_0 =>
                gclass40_0.method_157(AuroraComponentType.TroopTransport, false));
    }

    public int method_144()
    {
        try
        {
            return this.method_143() - (int)this.gclass0_0.FormationDictionary.Values
                .Where<GroundUnitFormationData>(gclass103_0 =>
                    gclass103_0.RaceData == this.Race && gclass103_0.ShipData != null)
                .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.ShipData.gclass85_0 == this)
                .Sum<GroundUnitFormationData>(gclass103_0 => gclass103_0.method_34());
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3425);
            return 0;
        }
    }

    public bool method_145()
    {
        try
        {
            return this.gclass0_0.FormationDictionary.Values
                .Where<GroundUnitFormationData>(gclass103_0 =>
                    gclass103_0.RaceData == this.Race && gclass103_0.ShipData != null)
                .Count<GroundUnitFormationData>(gclass103_0 => gclass103_0.ShipData.gclass85_0 == this) > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3426);
            return false;
        }
    }

    public Decimal method_146()
    {
        return this.list_3.Sum<ShipData>(gclass40_0 =>
            gclass40_0.method_157(AuroraComponentType.CargoHold, false));
    }

    public int method_147()
    {
        try
        {
            return this.list_3.Sum<ShipData>(gclass40_0 => gclass40_0.method_124());
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 883);
            return 0;
        }
    }

    public Decimal method_148()
    {
        try
        {
            return this.list_3.Sum<ShipData>(gclass40_0 =>
                       gclass40_0.method_157(AuroraComponentType.ColonistTransport, false)) +
                   this.list_3.Sum<ShipData>(gclass40_0 =>
                       gclass40_0.method_157(AuroraComponentType.PassengerModule, false));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 884);
            return 0M;
        }
    }

    public Decimal method_149()
    {
        try
        {
            return this.method_148() - this.method_150();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 885);
            return 0M;
        }
    }

    public Decimal method_150()
    {
        try
        {
            return this.method_176().SelectMany<ShipData, TransportedColonist>(gclass40_0 => gclass40_0.TransportedColonists)
                .Sum<TransportedColonist>(gclass181_0 => gclass181_0.Amount);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 886);
            return 0M;
        }
    }

    public Species method_151()
    {
        try
        {
            return this.method_176().SelectMany<ShipData, TransportedColonist>(gclass40_0 => gclass40_0.TransportedColonists)
                .OrderByDescending<TransportedColonist, int>(gclass181_0 => gclass181_0.Amount)
                .Select<TransportedColonist, Species>(gclass181_0 => gclass181_0.Species).FirstOrDefault<Species>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 887);
            return null;
        }
    }

    public Decimal method_152()
    {
        return this.list_3.Sum<ShipData>(gclass40_0 =>
            gclass40_0.method_157(AuroraComponentType.MaintenanceModule, false));
    }

    public Decimal method_153()
    {
        try
        {
            List<ShipData> source = this.method_176();
            ShipData gclass40 = source.Where<ShipData>(gclass40_0 => gclass40_0.Class.AutomatedClassDesign != null)
                .Where<ShipData>(gclass40_0 => gclass40_0.Class.AutomatedClassDesign.HiveShipSizeClass > 0)
                .OrderByDescending<ShipData, bool>(gclass40_0 => gclass40_0.Class.AutomatedClassDesign.HiveShipSizeClass > 0)
                .FirstOrDefault<ShipData>();
            if (gclass40 == null)
                return source.Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0 == this)
                    .Sum<ShipData>(gclass40_0 => gclass40_0.method_157(AuroraComponentType.SalvageModule, true));
            TechSystem gclass164 = this.Race.method_387(TechType.SalvageModule);
            return gclass164 == null ? 0M : gclass164.decimal_0 * gclass40.Class.AutomatedClassDesign.HiveShipSizeClass;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 888);
            return 0M;
        }
    }

    public Decimal method_154()
    {
        try
        {
            return this.list_3.Sum<ShipData>(gclass40_0 => gclass40_0.decimal_14);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3483);
            return 0M;
        }
    }

    public Decimal method_155()
    {
        try
        {
            return this.list_3.Sum<ShipData>(gclass40_0 => gclass40_0.decimal_4);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3482);
            return 0M;
        }
    }

    public Decimal method_156()
    {
        try
        {
            Decimal num = 0M;
            foreach (ShipData gclass40 in this.method_176())
                num += gclass40.method_177();
            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 889);
            return 0M;
        }
    }

    public double method_157()
    {
        try
        {
            double num1 = 0.0;
            foreach (ShipData gclass40 in this.method_176())
            {
                double num2 = gclass40.method_178();
                if (num2 > num1)
                    num1 = num2;
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 890);
            return 0.0;
        }
    }

    public double method_158(Decimal decimal_9)
    {
        try
        {
            double num = 0.0;
            foreach (ShipData gclass40 in this.method_176())
            {
                GClass71 gclass71 = gclass40.method_213(decimal_9, null);
                if (gclass71.double_0 > num)
                    num = gclass71.double_0;
            }

            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 891);
            return 0.0;
        }
    }

    public double method_159()
    {
        try
        {
            double num1 = 0.0;
            foreach (ShipData gclass40 in this.method_176())
            {
                double num2 = gclass40.method_220();
                if (num2 > num1)
                    num1 = num2;
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 892);
            return 0.0;
        }
    }

    public void method_160(int int_12)
    {
        try
        {
            int num = this.method_195();
            if (int_12 > num)
                int_12 = num;
            if (int_12 < 1)
                int_12 = 1;
            this.Speed = int_12;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 893);
        }
    }

    public void method_161()
    {
        try
        {
            this.Speed = this.method_195();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 894);
        }
    }

    public Commander method_162()
    {
        try
        {
            List<Commander> list = this.method_176()
                .Select<ShipData, Commander>(gclass40_0 => gclass40_0.method_192(AuroraCommandType.Ship))
                .Where<Commander>(gclass55_0 => gclass55_0 != null).ToList<Commander>();
            return list.Count == 0
                ? null
                : list.Where<Commander>(gclass55_0 => gclass55_0 != null)
                    .OrderBy<Commander, int>(gclass55_0 => gclass55_0.RacialRank.RankNum)
                    .ThenBy<Commander, int>(gclass55_0 => gclass55_0.Seniority).FirstOrDefault<Commander>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 895);
            return null;
        }
    }

    public void method_163(SubFleet gclass84_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class966 class966 = new FleetData.Class966();
        // ISSUE: reference to a compiler-generated field
        class966.gclass84_0 = gclass84_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            List<ShipData> list = this.gclass0_0.Ships.Values
                .Where<ShipData>(class966.method_0).ToList<ShipData>();
            if (list.Count > 0)
            {
                foreach (ShipData gclass40 in list)
                {
                    // ISSUE: reference to a compiler-generated field
                    gclass40.gclass84_0 = class966.gclass84_0.ParentSubFleet;
                }
            }

            // ISSUE: reference to a compiler-generated field
            this.gclass0_0.SubFleetDictionary.Remove(class966.gclass84_0.SubFleetID);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 896);
        }
    }

    public PopulationData method_164()
    {
        try
        {
            PopulationData gclass146 = this.gclass0_0.Populations.Values.FirstOrDefault<PopulationData>(gclass146_1 =>
                gclass146_1.gclass202_0 == this.System && gclass146_1.Race == this.Race &&
                gclass146_1.method_87() == this.XCoord && gclass146_1.method_88() == this.YCoord);
            return gclass146 == null || gclass146.method_62(AuroraProductionCategory.OrdnanceTransferPoint) == 0M ||
                   gclass146.OrdnanceStocks.Count == 0
                ? null
                : gclass146;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 897);
            return null;
        }
    }

    public string method_165()
    {
        try
        {
            foreach (PopulationData gclass146 in this.System.ActualSystem.method_33(this.Race))
            {
                if (this.gclass0_0.method_520(this.XCoord, gclass146.method_87(), this.YCoord,
                        gclass146.method_88()))
                    return string.Format((string)"Orbiting {0}", (object)gclass146.PopName);
            }

            foreach (JumpPoint gclass120 in this.System.ActualSystem.method_27())
            {
                if (gclass120.RacialJumpPointSurveys.ContainsKey(this.Race.RaceID) &&
                    gclass120.RacialJumpPointSurveys[this.Race.RaceID].Charted == 1 &&
                    this.gclass0_0.method_520(this.XCoord, gclass120.XCoord, this.YCoord, gclass120.YCoord))
                    return string.Format((string)"Stationed at {0}", (object)gclass120.method_8(this.System));
            }

            foreach (SurveyLocation gclass213 in this.System.ActualSystem.SurveyLocationDictionary.Values)
            {
                if (this.gclass0_0.method_520(this.XCoord, gclass213.XCoord, this.YCoord, gclass213.YCoord))
                {
                    MoveOrder gclass139 = this.method_255();
                    return gclass139 != null && gclass139.MoveActionType.MoveActionType == MoveActionType.GravitationalSurvey &&
                           gclass139.DestinationType == DestinationType.const_2 && gclass139.DestinationID == gclass213.LocationNumber
                        ? string.Format((string)"Surveying Survey Location #{0}", (object)gclass213.LocationNumber)
                        : string.Format((string)"Stationed at Survey Location #{0}", (object)gclass213.LocationNumber);
                }
            }

            foreach (SystemBodyData gclass1 in this.System.ActualSystem.method_20())
            {
                if (this.gclass0_0.method_520(this.XCoord, gclass1.XCoordinate, this.YCoord, gclass1.YCoordinate))
                {
                    MoveOrder gclass139 = this.method_255();
                    return gclass139 != null && gclass139.MoveActionType.MoveActionType == MoveActionType.GeologicalSurvey &&
                           gclass139.DestinationType == DestinationType.const_1 && gclass139.DestinationID == gclass1.SystemBodyID
                        ? string.Format((string)"Surveying {0}", (object)gclass1.method_78(this.Race))
                        : string.Format((string)"Orbiting {0}", (object)gclass1.method_78(this.Race));
                }
            }

            return this.System.ActualSystem.method_22(this.XCoord, this.YCoord, this.System);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 898);
            return "None";
        }
    }

    public string method_166()
    {
        try
        {
            string str1 = string.Format((string)"{0} System     {1}", (object)this.System.Name,
                (object)this.method_165());
            MoveOrder gclass139 = this.method_255();
            string str2;
            if (gclass139 == null)
            {
                str2 = string.Format((string)"{0}     No Orders", (object)str1);
                List<ShipData> source = this.method_177();
                int num1 = source.Count<ShipData>(gclass40_0 => gclass40_0.genum29_0 == GEnum29.const_1);
                if (num1 > 0)
                {
                    if (num1 == 1 && source.Count == 1)
                        str2 =
                            string.Format((string)"{0}     In Overhaul     Maint {1}", (object)str2,
                                (object)AuroraUtils.smethod_45(
                                    (this.gclass0_0.GameTime - source[0].decimal_6) / AuroraUtils.decimal_29, 2));
                    else if (num1 == source.Count)
                        str2 += "     All Ships in Overhaul";
                    else if (num1 < source.Count)
                        str2 = string.Format((string)"{0}     {1}/{2} Ships in Overhaul", (object)str2,
                            (object)num1.ToString(), (object)source.Count.ToString());
                }

                int num2 = this.gclass0_0.dictionary_32.Values.Count<ShipyardTask>(gclass192_0 =>
                    gclass192_0.gclass85_0 == this);
                if (num2 > 0)
                    str2 = string.Format((string)"{0}     {1}x Shipyard Task", (object)str2, (object)num2.ToString());
            }
            else
            {
                Decimal decimal_73 = this.method_191();
                Decimal num = decimal_73 / this.Speed;
                string str3 = !(num < 170000M)
                    ? (!(num < 1700000M)
                        ? string.Format((string)"{0} days", (object)AuroraUtils.smethod_39(num / 86400M))
                        : string.Format((string)"{0} days", (object)AuroraUtils.FormatNumberToDigits(num / 86400M, 1)))
                    : string.Format((string)"{0} hours", (object)AuroraUtils.FormatNumberToDigits(num / 3600M, 1));
                str2 =
                    string.Format(
                        (string)"{0}      Orders: {1}      All Orders Distance: {2}      Travel Time Required: {3}",
                        new[] { str1 }, gclass139.Description, AuroraUtils.smethod_61(decimal_73, "km"), str3);
            }

            return str2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 899);
            return "error";
        }
    }

    public void method_167(
        ListView listView_0,
        SubFleet gclass84_0,
        FCTSquadronData70 gclass70_0,
        Label label_0,
        Label label_1,
        Label label_2,
        Label label_3,
        Label label_4,
        Label label_5,
        ListView listView_1,
        CheckBox checkBox_0,
        TextBox textBox_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class967 class967 = new FleetData.Class967();
        // ISSUE: reference to a compiler-generated field
        class967.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class967.gclass84_0 = gclass84_0;
        // ISSUE: reference to a compiler-generated field
        class967.gclass70_0 = gclass70_0;
        try
        {
            string str1 = "";
            string str2 = "";
            string str3 = "    ";
            bool bool_25 = false;
            // ISSUE: reference to a compiler-generated method
            if (this.gclass0_0.Populations.Values.Count<PopulationData>(class967.method_0) > 0)
                bool_25 = true;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (!bool_25 && this.gclass0_0.Ships.Values.Where<ShipData>(class967.method_1)
                    .Count<ShipData>(class967.method_2) > 0)
                bool_25 = true;
            Commander gclass55_0 = this.method_162();
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                gclass55_0 = class967.gclass84_0.method_16();
            }

            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                gclass55_0 = class967.gclass70_0.method_7();
            }

            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.method_174(listView_0, gclass55_0, bool_25, class967.gclass84_0, class967.gclass70_0);
            if (gclass55_0 == null)
                label_1.Text = "No Fleet Commander";
            else
                label_1.Text = string.Format((string)"{0} {1}   {2}", (object)gclass55_0.method_36(),
                    (object)gclass55_0.method_37(), (object)gclass55_0.method_29(false));
            label_0.Text = this.method_166();
            int int_72_1 = this.method_195();
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                int_72_1 = class967.gclass84_0.method_15();
            }

            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                int_72_1 = class967.gclass70_0.method_5();
            }

            if (this.Speed > int_72_1)
                this.Speed = int_72_1;
            string str4 = string.Format((string)"{0}Speed {1} km/s    ", (object)str1,
                (object)AuroraUtils.smethod_37(this.Speed));
            if (this.Speed < int_72_1)
                str4 = string.Format((string)"{0}Max Speed {1} km/s{2}", (object)str4,
                    (object)AuroraUtils.smethod_37(int_72_1), (object)str3);
            Decimal decimal_73_1 = this.method_156();
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                decimal_73_1 = class967.gclass84_0.method_14();
            }

            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                decimal_73_1 = class967.gclass70_0.method_6();
            }

            if (decimal_73_1 > 0M)
                str4 = string.Format((string)"{0}PPV {1}{2}", (object)str4,
                    (object)AuroraUtils.smethod_38(decimal_73_1), (object)str3);
            Decimal decimal_73_2 =
                this.method_177().Where<ShipData>(gclass40_0 => !gclass40_0.Class.Commercial)
                    .Sum<ShipData>(gclass40_0 => gclass40_0.Class.Cost) * AuroraUtils.decimal_45;
            if (decimal_73_2 > 0M)
                str4 = string.Format((string)"{0}Annual MSP {1}{2}", (object)str4,
                    (object)AuroraUtils.smethod_38(decimal_73_2), (object)str3);
            double num1 = this.method_158(0M);
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                num1 = class967.gclass84_0.method_13(0M);
            }

            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                num1 = class967.gclass70_0.method_3(0M);
            }

            if (num1 > 0.0)
                str4 = string.Format((string)"{0}Missile Range {1}m  km{2}", (object)str4,
                    (object)AuroraUtils.smethod_43(num1 / 1000000.0), (object)str3);
            double num2 = this.method_159();
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                num2 = class967.gclass84_0.method_12();
            }

            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                num2 = class967.gclass70_0.method_2();
            }

            if (num2 > 0.0)
                str4 = string.Format((string)"{0}Beam Range {1}k  km{2}", (object)str4,
                    (object)AuroraUtils.smethod_38((Decimal)num2 / 1000M), (object)str3);
            double num3 = this.method_157();
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                num3 = class967.gclass84_0.method_11();
            }

            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                num3 = class967.gclass70_0.method_4();
            }

            if (num3 > 0.0)
                str4 = string.Format((string)"{0}Sensor Range {1}m  km{2}", (object)str4,
                    (object)AuroraUtils.smethod_43(num3 / 1000000.0), (object)str3);
            Decimal num4 = this.ParentNavalCommand.method_5(this.System.ActualSystem.SystemID, CommanderBonusType.Survey);
            // ISSUE: reference to a compiler-generated field
            Decimal num5 = this.method_126(AuroraComponentType.GeologicalSurveySensors, class967.gclass84_0);
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                num5 = class967.gclass70_0.method_1(AuroraComponentType.GeologicalSurveySensors);
            }

            if (num5 > 0M)
                str4 =
                    string.Format((string)"{0}Geo Survey {1}{2}", (object)str4,
                        (object)AuroraUtils.FormatNumberToDigits(
                            num5 * (Decimal)(this.gclass0_0.SurveySpeed / 100.0) * num4, 2), (object)str3);
            // ISSUE: reference to a compiler-generated field
            Decimal num6 = this.method_126(AuroraComponentType.GravitationalSurveySensors, class967.gclass84_0);
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                num6 = class967.gclass70_0.method_1(AuroraComponentType.GravitationalSurveySensors);
            }

            if (num6 > 0M)
                str4 =
                    string.Format((string)"{0}Grav Survey {1}{2}", (object)str4,
                        (object)AuroraUtils.FormatNumberToDigits(
                            num6 * (Decimal)(this.gclass0_0.SurveySpeed / 100.0) * num4, 2), (object)str3);
            // ISSUE: reference to a compiler-generated field
            Decimal num7 = this.method_126(AuroraComponentType.SoriumHarvester, class967.gclass84_0);
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                num7 = class967.gclass70_0.method_1(AuroraComponentType.SoriumHarvester);
            }

            if (num7 > 0M)
                str4 = string.Format((string)"{0}Annual Fuel Production {1} m litres{2}", (object)str4,
                    (object)AuroraUtils.FormatNumberToDigits(num7 / 1000000M, 1), (object)str3);
            // ISSUE: reference to a compiler-generated field
            Decimal decimal_73_3 = this.method_126(AuroraComponentType.TerraformingModule, class967.gclass84_0);
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                decimal_73_3 = class967.gclass70_0.method_1(AuroraComponentType.TerraformingModule);
            }

            if (decimal_73_3 > 0M)
                str4 = string.Format((string)"{0}Annual Terraforming {1}  atm{2}", (object)str4,
                    (object)AuroraUtils.FormatNumberToDigits(decimal_73_3, 3), (object)str3);
            // ISSUE: reference to a compiler-generated field
            Decimal decimal_73_4 = this.method_126(AuroraComponentType.OrbitalMiningModule, class967.gclass84_0);
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                decimal_73_4 = class967.gclass70_0.method_1(AuroraComponentType.OrbitalMiningModule);
            }

            if (decimal_73_4 > 0M)
                str4 = string.Format((string)"{0}Annual Mining {1}  tons{2}", (object)str4,
                    (object)AuroraUtils.FormatNumberToDigits(decimal_73_4, 1), (object)str3);
            int num8 = this.method_140();
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                num8 = class967.gclass84_0.method_5();
            }

            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                num8 = class967.gclass70_0.method_11();
            }

            Decimal num9 = this.method_154();
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                num9 = class967.gclass84_0.method_8();
            }

            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                num9 = class967.gclass70_0.method_14();
            }

            Decimal decimal_73_5 = this.method_141();
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                decimal_73_5 = class967.gclass84_0.method_6();
            }

            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                decimal_73_5 = class967.gclass70_0.method_12();
            }

            Decimal decimal_73_6 = this.method_155();
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                decimal_73_6 = class967.gclass84_0.method_7();
            }

            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                decimal_73_6 = class967.gclass70_0.method_13();
            }

            string str5 =
                string.Format((string)"{0}MSP {1} / {2}{3}", new[]
                {
                    string.Format((string)"{0}Fuel {1}m / {2}m litres{3}", new[] { str2 },
                        AuroraUtils.FormatNumberToDigits(num9 / 1000000M, 1),
                        AuroraUtils.FormatNumberToDigits(num8 / 1000000M, 1), str3)
                }, AuroraUtils.smethod_39(decimal_73_6), AuroraUtils.smethod_39(decimal_73_5), str3);
            int decimal_73_7 = this.method_143();
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                decimal_73_7 = class967.gclass84_0.method_9();
            }

            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                decimal_73_7 = class967.gclass70_0.method_15();
            }

            if (decimal_73_7 > 0)
            {
                int int_72_2 = this.method_144();
                string str6 = string.Format((string)"{0}Troop Capacity {1}", (object)str5,
                    (object)AuroraUtils.FormatNumberToDigits(decimal_73_7, 1));
                if (int_72_2 < decimal_73_7)
                    str6 = string.Format((string)"{0} ({1})", (object)str6, (object)AuroraUtils.smethod_37(int_72_2));
                str5 = str6 + str3;
            }

            int int_72_3 = (int)this.method_146();
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                int_72_3 = (int)class967.gclass84_0.method_10();
            }

            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                int_72_3 = (int)class967.gclass70_0.method_16();
            }

            if (int_72_3 > 0)
            {
                int int_72_4 = this.method_147();
                // ISSUE: reference to a compiler-generated field
                if (class967.gclass84_0 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    int_72_4 = class967.gclass84_0.method_2();
                }

                // ISSUE: reference to a compiler-generated field
                if (class967.gclass70_0 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    int_72_4 = class967.gclass70_0.method_8();
                }

                string str7 = string.Format((string)"{0}Cargo Capacity {1}", (object)str5,
                    (object)AuroraUtils.smethod_37(int_72_3));
                if (int_72_4 < int_72_3)
                    str7 = string.Format((string)"{0} ({1})", (object)str7, (object)AuroraUtils.smethod_37(int_72_4));
                str5 = str7 + str3;
            }

            int int_72_5 = (int)this.method_148();
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                int_72_5 = (int)class967.gclass84_0.method_1();
            }

            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                int_72_5 = (int)class967.gclass70_0.method_17();
            }

            if (int_72_5 > 0)
                str5 = string.Format((string)"{0}Colonist Capacity {1}{2}", (object)str5,
                    (object)AuroraUtils.smethod_37(int_72_5), (object)str3);
            int int_72_6 = (int)this.method_152();
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                int_72_6 = (int)class967.gclass84_0.method_4();
            }

            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                int_72_6 = (int)class967.gclass70_0.method_10();
            }

            if (int_72_6 > 0)
                str5 = string.Format((string)"{0}Maintenance Support {1} tons{2}", (object)str5,
                    (object)AuroraUtils.smethod_37(int_72_6), (object)str3);
            Decimal decimal_73_8 = this.method_142();
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                decimal_73_8 = (int)class967.gclass84_0.method_3();
            }

            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                decimal_73_8 = (int)class967.gclass70_0.method_9();
            }

            if (decimal_73_8 > 0M)
                str5 = string.Format((string)"{0}Military Hulls {1} tons{2}", (object)str5,
                    (object)AuroraUtils.smethod_38(decimal_73_8), (object)str3);
            // ISSUE: reference to a compiler-generated method
            int int_72_7 = this.gclass0_0.Ships.Values.Where<ShipData>(class967.method_3)
                .Sum<ShipData>(gclass40_0 => gclass40_0.Class.Crew);
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated method
                int_72_7 = this.gclass0_0.Ships.Values.Where<ShipData>(class967.method_4)
                    .Sum<ShipData>(gclass40_0 => gclass40_0.Class.Crew);
            }

            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated method
                int_72_7 = this.gclass0_0.Ships.Values.Where<ShipData>(class967.method_5)
                    .Sum<ShipData>(gclass40_0 => gclass40_0.Class.Crew);
            }

            if (int_72_7 > 0)
                str5 = string.Format((string)"{0}Total Crew {1}{2}", (object)str5,
                    (object)AuroraUtils.smethod_37(int_72_7), (object)str3);
            Decimal decimal_73_9 = this.method_176().Sum<ShipData>(gclass40_0 => gclass40_0.Class.Cost);
            // ISSUE: reference to a compiler-generated field
            if (class967.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                decimal_73_9 = class967.gclass84_0.method_0()
                    .Sum<ShipData>(gclass40_0 => gclass40_0.Class.Cost);
            }

            // ISSUE: reference to a compiler-generated field
            if (class967.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                decimal_73_9 = class967.gclass70_0.method_0()
                    .Sum<ShipData>(gclass40_0 => gclass40_0.Class.Cost);
            }

            string str8 = string.Format((string)"{0}Fleet Cost {1}{2}", (object)str5,
                (object)AuroraUtils.smethod_38(decimal_73_9), (object)str3);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            string str9 = this.method_175(class967.gclass84_0, class967.gclass70_0);
            if (str9 != "")
                str8 = string.Format((string)"{0}Cargo: {1}{2}", (object)str8, (object)str9, (object)str3);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            string str10 = this.method_168(class967.gclass84_0, class967.gclass70_0);
            if (str10 != "")
                label_5.Text = str10;
            else
                label_5.Text = "No Ships Present";
            label_2.Text = str4;
            label_3.Text = str8;
            label_4.Text = this.method_173();
            listView_1.Items.Clear();
            List<HistoryRecord> list = this.Histories
                .OrderByDescending<HistoryRecord, Decimal>(gclass177_0 => gclass177_0.GameTime).ToList<HistoryRecord>();
            if (list.Count > 0)
            {
                foreach (HistoryRecord gclass177 in list)
                {
                    string string_10 = this.gclass0_0.method_582((double)gclass177.GameTime, true);
                    this.gclass0_0.method_597(listView_1, string_10, gclass177.Description);
                }

                listView_1.Items[listView_1.Items.Count - 1].EnsureVisible();
            }

            textBox_0.Text = AuroraUtils.smethod_43(this.MaxStandingOrderDistance);
            checkBox_0.CheckState = this.checkState_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 900);
        }
    }

    public string method_168(SubFleet gclass84_0, FCTSquadronData70 gclass70_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class968 class968 = new FleetData.Class968();
        // ISSUE: reference to a compiler-generated field
        class968.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class968.gclass84_0 = gclass84_0;
        // ISSUE: reference to a compiler-generated field
        class968.gclass70_0 = gclass70_0;
        try
        {
            Dictionary<int, GClass78> dictionary = new Dictionary<int, GClass78>();
            // ISSUE: reference to a compiler-generated method
            List<ShipData> list1 = this.gclass0_0.Ships.Values
                .Where<ShipData>(class968.method_0)
                .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.Class.Size)
                .ToList<ShipData>();
            // ISSUE: reference to a compiler-generated field
            if (class968.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated method
                list1 = list1.Where<ShipData>(class968.method_1)
                    .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.Class.Size)
                    .ToList<ShipData>();
            }

            // ISSUE: reference to a compiler-generated field
            if (class968.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated method
                list1 = list1.Where<ShipData>(class968.method_2)
                    .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.Class.Size)
                    .ToList<ShipData>();
            }

            foreach (ShipData gclass40 in list1)
            {
                if (dictionary.ContainsKey(gclass40.Class.ShipClassID))
                {
                    ++dictionary[gclass40.Class.ShipClassID].int_1;
                }
                else
                {
                    GClass78 gclass78 = new GClass78();
                    gclass78.int_0 = gclass40.Class.ShipClassID;
                    gclass78.int_1 = 1;
                    gclass78.gclass22_0 = gclass40.Class;
                    dictionary.Add(gclass78.int_0, gclass78);
                }
            }

            string str = "";
            foreach (GClass78 gclass78 in dictionary.Values)
                str =
                    string.Format((string)"{0}{1}x {2} {3}   ", new[] { str }, gclass78.int_1.ToString(),
                        gclass78.gclass22_0.ShipHull.Abbreviation, gclass78.gclass22_0.ClassName);
            List<ShipData> list2 = list1.Where<ShipData>(gclass40_0 => gclass40_0.gclass40_0 == null)
                .ToList<ShipData>();
            List<ShipData> list3 = list2.Where<ShipData>(gclass40_0 => gclass40_0.gclass40_1 != null)
                .ToList<ShipData>();
            if (list2.Count == list3.Count && list2.Count > 0)
            {
                List<ShipData> list4 = list3
                    .Select<ShipData, ShipData>(gclass40_0 => gclass40_0.gclass40_1).Distinct<ShipData>()
                    .ToList<ShipData>();
                if (list4.Count == 1)
                    str = string.Format((string)"{0}   Assigned Mothership: {1} ({2})   ", (object)str,
                        (object)list4[0].method_187(), (object)list4[0].gclass85_0.FleetName);
            }

            // ISSUE: reference to a compiler-generated method
            foreach (Shipyard gclass193 in this.gclass0_0.Shipyards.Values
                         .Where<Shipyard>(gclass193_0 => gclass193_0.TractorParentShip != null)
                         .Where<Shipyard>(class968.method_3).ToList<Shipyard>())
                str =
                    string.Format((string)"{0}{1} ({2}x {3} tons)   ", new[] { str }, gclass193.ShipyardName,
                        gclass193.Slipways.ToString(), AuroraUtils.smethod_39(gclass193.Capacity));
            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 901);
            return "error";
        }
    }

    public string method_169()
    {
        try
        {
            Dictionary<int, GClass77> dictionary = new Dictionary<int, GClass77>();
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0 == this)
                         .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.Class.Size)
                         .ToList<ShipData>())
            {
                if (dictionary.ContainsKey(gclass40.Class.ShipHull.ShipHullDescriptionID))
                {
                    ++dictionary[gclass40.Class.ShipHull.ShipHullDescriptionID].int_1;
                }
                else
                {
                    GClass77 gclass77 = new GClass77();
                    gclass77.int_0 = gclass40.Class.ShipHull.ShipHullDescriptionID;
                    gclass77.int_1 = 1;
                    gclass77.gclass76_0 = gclass40.Class.ShipHull;
                    dictionary.Add(gclass77.int_0, gclass77);
                }
            }

            string str = "";
            foreach (GClass77 gclass77 in dictionary.Values)
                str = string.Format((string)"{0}{1}x {2}   ", (object)str, (object)gclass77.int_1.ToString(),
                    (object)gclass77.gclass76_0.Description);
            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 902);
            return "error";
        }
    }

    public void method_170(string string_1)
    {
        this.Histories.Add(new HistoryRecord()
        {
            GameTime = this.gclass0_0.GameTime,
            Description = string_1
        });
    }

    public string method_171()
    {
        try
        {
            string str = "";
            if (this.StandingOrdersDictionary.Count == 0)
            {
                str = "No Standing Orders    ";
            }
            else
            {
                this.StandingOrdersDictionary = this.StandingOrdersDictionary
                    .OrderBy<KeyValuePair<int, StandingOrderDefinition>, int>(keyValuePair_0 => keyValuePair_0.Key)
                    .ToDictionary<KeyValuePair<int, StandingOrderDefinition>, int, StandingOrderDefinition>(keyValuePair_0 => keyValuePair_0.Key,
                        keyValuePair_0 => keyValuePair_0.Value);
                foreach (StandingOrderDefinition gclass136 in this.StandingOrdersDictionary.Values)
                    str = string.Format((string)"{0}{1}    ", (object)str, (object)gclass136.Description);
            }

            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3906);
            return "None";
        }
    }

    public string method_172()
    {
        try
        {
            string str = "";
            if (this.ConditionalOrdersDictionary.Count == 0)
                return "";
            this.ConditionalOrdersDictionary = this.ConditionalOrdersDictionary
                .OrderBy<KeyValuePair<int, FleetConditionalOrder>, int>(keyValuePair_0 => keyValuePair_0.Key)
                .ToDictionary<KeyValuePair<int, FleetConditionalOrder>, int, FleetConditionalOrder>(keyValuePair_0 => keyValuePair_0.Key,
                    keyValuePair_0 => keyValuePair_0.Value);
            foreach (FleetConditionalOrder gclass138 in this.ConditionalOrdersDictionary.Values)
                str =
                    string.Format((string)"{0}if {1}, {2}    ", (object)str,
                        (object)AuroraUtils.smethod_82(gclass138.Condition),
                        (object)AuroraUtils.smethod_82(gclass138.StandingOrder));
            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3908);
            return "None";
        }
    }

    public string method_173()
    {
        try
        {
            return this.method_171() + this.method_172();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 903);
            return "None";
        }
    }

    public void method_174(
        ListView listView_0,
        Commander gclass55_0,
        bool bool_25,
        SubFleet gclass84_0,
        FCTSquadronData70 gclass70_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class969 class969 = new FleetData.Class969();
        // ISSUE: reference to a compiler-generated field
        class969.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class969.gclass84_0 = gclass84_0;
        // ISSUE: reference to a compiler-generated field
        class969.gclass70_0 = gclass70_0;
        try
        {
            int index = 0;
            // ISSUE: reference to a compiler-generated method
            List<ShipData> list1 = this.gclass0_0.Ships.Values
                .Where<ShipData>(class969.method_0)
                .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.Class.Size)
                .ThenBy<ShipData, string>(gclass40_0 => gclass40_0.Class.ShipHull.Abbreviation)
                .ThenBy<ShipData, int>(gclass40_0 => gclass40_0.int_20).ToList<ShipData>();
            // ISSUE: reference to a compiler-generated field
            if (class969.gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated method
                list1 = list1.Where<ShipData>(class969.method_1).ToList<ShipData>();
            }

            // ISSUE: reference to a compiler-generated field
            if (class969.gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated method
                list1 = list1.Where<ShipData>(class969.method_2).ToList<ShipData>();
            }

            // ISSUE: reference to a compiler-generated method
            List<ShipData> list2 = this.gclass0_0.dictionary_32.Values.Where<ShipyardTask>(class969.method_3)
                .Select<ShipyardTask, ShipData>(gclass192_0 => gclass192_0.gclass40_0).ToList<ShipData>();
            listView_0.Items.Clear();
            listView_0.Items.Add(new ListViewItem("Ship Name")
            {
                SubItems =
                {
                    "Class",
                    "Status",
                    "Fuel",
                    "Ammo",
                    "MSP",
                    "Shields",
                    "Deploy",
                    "Maint",
                    "Morale",
                    "Grade",
                    "Training",
                    "Thermal",
                    "Commander"
                }
            });
            ListViewItem listViewItem1 = new ListViewItem("");
            listView_0.Items.Add(listViewItem1);
            foreach (ShipData gclass40 in list1)
            {
                ListViewItem listViewItem2 = new ListViewItem(gclass40.method_187());
                listViewItem2.UseItemStyleForSubItems = false;
                listViewItem2.SubItems.Add(gclass40.Class.ClassName);
                index = 2;
                string text1 = "";
                if (list2.Contains(gclass40))
                    text1 += "S";
                if (gclass40.genum78_0 == GEnum78.const_2)
                    text1 += "T";
                else if (gclass40.genum78_0 == GEnum78.const_1)
                    text1 += "F";
                if (gclass40.bool_8)
                    text1 += "A";
                if (gclass40.genum29_0 == GEnum29.const_1)
                    text1 += "O";
                else if (gclass40.decimal_9 < 1M)
                {
                    int num = (int)Math.Round(gclass40.decimal_9 * 100M);
                    text1 = num >= 10 ? string.Format((string)"{0}O{1}", (object)text1, (object)num.ToString()) : string
                        .Format((string)"{0}O0{1}", (object)text1, (object)num.ToString());
                }

                listViewItem2.SubItems.Add(text1);
                ++index;
                Decimal num1 = gclass40.method_157(AuroraComponentType.FuelStorage, false);
                if (num1 > 0M)
                {
                    Decimal num2 = Math.Round(gclass40.decimal_14 / num1 * 100M);
                    listViewItem2.SubItems.Add(string.Format((string)"{0}%", (object)num2));
                    if (num2 < 40M)
                        listViewItem2.SubItems[index].ForeColor = Color.Orange;
                    if (num2 < 20M)
                        listViewItem2.SubItems[index].ForeColor = Color.Red;
                }
                else
                    listViewItem2.SubItems.Add("No Cap");

                ++index;
                if (gclass40.method_183() == 0M)
                {
                    listViewItem2.SubItems.Add("-");
                }
                else
                {
                    Decimal num3 = Math.Round(gclass40.method_212());
                    listViewItem2.SubItems.Add(string.Format((string)"{0}%", (object)num3));
                    if (num3 < 40M)
                        listViewItem2.SubItems[index].ForeColor = Color.Orange;
                    if (num3 < 20M)
                        listViewItem2.SubItems[index].ForeColor = Color.Red;
                }

                ++index;
                if (gclass40.method_172() == 0M)
                {
                    listViewItem2.SubItems.Add("-");
                }
                else
                {
                    Decimal num4 = Math.Round(gclass40.decimal_4 / gclass40.method_172() * 100M);
                    listViewItem2.SubItems.Add(string.Format((string)"{0}%", (object)num4));
                    if (num4 < 40M)
                        listViewItem2.SubItems[index].ForeColor = Color.Orange;
                    if (num4 < 20M)
                        listViewItem2.SubItems[index].ForeColor = Color.Red;
                }

                ++index;
                Decimal num5 = gclass40.method_157(AuroraComponentType.Shields, false) * gclass40.decimal_9;
                if (num5 == 0M)
                {
                    listViewItem2.SubItems.Add("-");
                }
                else
                {
                    Decimal num6 = Math.Round(gclass40.decimal_3 / num5 * 100M);
                    listViewItem2.SubItems.Add(string.Format((string)"{0}%", (object)num6));
                    if (num6 < 40M)
                        listViewItem2.SubItems[index].ForeColor = Color.Orange;
                    if (num6 < 20M)
                        listViewItem2.SubItems[index].ForeColor = Color.Red;
                }

                ++index;
                if (gclass40.Class.Commercial)
                {
                    listViewItem2.SubItems.Add("-");
                }
                else
                {
                    Decimal decimal_73 = (this.gclass0_0.GameTime - gclass40.decimal_7) / AuroraUtils.decimal_31;
                    listViewItem2.SubItems.Add(AuroraUtils.smethod_45(decimal_73, 2));
                    if (decimal_73 > gclass40.Class.PlannedDeployment * 1.5M)
                        listViewItem2.SubItems[index].ForeColor = Color.Red;
                    else if (decimal_73 > gclass40.Class.PlannedDeployment)
                        listViewItem2.SubItems[index].ForeColor = Color.Orange;
                    else if (bool_25)
                        listViewItem2.SubItems[index].ForeColor = AuroraUtils.color_2;
                }

                ++index;
                if (gclass40.Class.Commercial)
                {
                    listViewItem2.SubItems.Add("-");
                }
                else
                {
                    string text2 =
                        AuroraUtils.smethod_45((this.gclass0_0.GameTime - gclass40.decimal_6) / AuroraUtils.decimal_29,
                            2);
                    listViewItem2.SubItems.Add(text2);
                    if (gclass40.genum29_0 == GEnum29.const_1)
                        listViewItem2.SubItems[index].ForeColor = AuroraUtils.color_2;
                }

                ++index;
                if (gclass40.Class.Commercial && gclass40.Class.GravSurvey == 0 &&
                    gclass40.Class.GeoSurvey == 0M)
                {
                    listViewItem2.SubItems.Add("-");
                }
                else
                {
                    Decimal num7 = Math.Round(gclass40.decimal_2 * 100M);
                    listViewItem2.SubItems.Add(string.Format((string)"{0}%", (object)num7));
                    if (num7 < 40M)
                        listViewItem2.SubItems[index].ForeColor = Color.Orange;
                    if (num7 < 20M)
                        listViewItem2.SubItems[index].ForeColor = Color.Red;
                }

                ++index;
                Decimal num8 = gclass40.method_189();
                string text3 = string.Format((string)"{0}%", (object)num8);
                listViewItem2.SubItems.Add(text3);
                ++index;
                num8 = Math.Round(gclass40.decimal_16 / 5M);
                string text4 = string.Format((string)"{0}%", (object)num8);
                listViewItem2.SubItems.Add(text4);
                ++index;
                string text5 = AuroraUtils.smethod_38(gclass40.method_184());
                listViewItem2.SubItems.Add(text5);
                ++index;
                Commander gclass55 = gclass40.method_192(AuroraCommandType.Ship);
                if (gclass55 != null)
                {
                    listViewItem2.SubItems.Add(string.Format((string)"{0} {1}", (object)gclass55.RacialRank.method_0(),
                        (object)gclass55.Name));
                    if (gclass55 == gclass55_0)
                        listViewItem2.SubItems[index].ForeColor = AuroraUtils.color_2;
                }
                else
                    listViewItem2.SubItems.Add("-");

                ++index;
                listViewItem2.Tag = gclass40;
                listView_0.Items.Add(listViewItem2);
            }

            // ISSUE: reference to a compiler-generated method
            List<Shipyard> list3 = this.gclass0_0.Shipyards.Values
                .Where<Shipyard>(gclass193_0 => gclass193_0.TractorParentShip != null).Where<Shipyard>(class969.method_4)
                .OrderByDescending<Shipyard, string>(gclass193_0 => gclass193_0.ShipyardName).ToList<Shipyard>();
            if (list3.Count > 0)
            {
                this.gclass0_0.method_594(listView_0, "");
                this.gclass0_0.method_601(listView_0, "Shipyard", "Towed By", null);
            }

            foreach (Shipyard gclass193 in list3)
            {
                ListViewItem listViewItem3 = new ListViewItem(gclass193.ShipyardName);
                listViewItem3.UseItemStyleForSubItems = false;
                listViewItem3.SubItems.Add(gclass193.TractorParentShip.method_187());
                ++index;
                listViewItem3.Tag = gclass193;
                listView_0.Items.Add(listViewItem3);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 904);
        }
    }

    public string method_175(SubFleet gclass84_0, FCTSquadronData70 gclass70_0)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            FleetData.Class970 class970 = new FleetData.Class970();
            string str = "";
            // ISSUE: reference to a compiler-generated field
            class970.list_0 = this.method_176();
            if (gclass84_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                class970.list_0 = gclass84_0.method_0();
            }

            if (gclass70_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                class970.list_0 = gclass70_0.method_0();
            }

            // ISSUE: reference to a compiler-generated field
            foreach (Species gclass194 in class970.list_0
                         .SelectMany<ShipData, TransportedColonist>(gclass40_0 => gclass40_0.TransportedColonists)
                         .Select<TransportedColonist, Species>(gclass181_0 => gclass181_0.Species).Distinct<Species>()
                         .ToList<Species>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class971 class971 = new FleetData.Class971();
                // ISSUE: reference to a compiler-generated field
                class971.gclass194_0 = gclass194;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                int int_72 = class970.list_0.SelectMany<ShipData, TransportedColonist>(gclass40_0 => gclass40_0.TransportedColonists)
                    .Where<TransportedColonist>(class971.method_0).Sum<TransportedColonist>(gclass181_0 => gclass181_0.Amount);
                // ISSUE: reference to a compiler-generated field
                str = string.Format((string)"{0}{1} {2}   ", (object)str, (object)class971.gclass194_0.SpeciesName,
                    (object)AuroraUtils.smethod_37(int_72));
            }

            // ISSUE: reference to a compiler-generated field
            foreach (PlanetaryInstallationType gclass157 in class970.list_0
                         .SelectMany<ShipData, PopulationInstallation>(gclass40_0 => gclass40_0.TransportedInstallations.Values)
                         .Select<PopulationInstallation, PlanetaryInstallationType>(gclass158_0 => gclass158_0.InstallationType).Distinct<PlanetaryInstallationType>()
                         .ToList<PlanetaryInstallationType>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class972 class972 = new FleetData.Class972();
                // ISSUE: reference to a compiler-generated field
                class972.gclass157_0 = gclass157;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                Decimal decimal_73 = class970.list_0
                    .SelectMany<ShipData, PopulationInstallation>(gclass40_0 => gclass40_0.TransportedInstallations.Values)
                    .Where<PopulationInstallation>(class972.method_0).Sum<PopulationInstallation>(gclass158_0 => gclass158_0.Amount);
                // ISSUE: reference to a compiler-generated field
                str = string.Format((string)"{0}{1} {2}   ", (object)str, (object)class972.gclass157_0.Name,
                    (object)AuroraUtils.FormatNumberToDigits(decimal_73, 2));
            }

            // ISSUE: reference to a compiler-generated field
            foreach (ShipComponent gclass230 in class970.list_0
                         .SelectMany<ShipData, StoredComponent>(gclass40_0 => gclass40_0.TransportedComponents)
                         .Select<StoredComponent, ShipComponent>(gclass73_0 => gclass73_0.Component).Distinct<ShipComponent>()
                         .ToList<ShipComponent>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class973 class973 = new FleetData.Class973();
                // ISSUE: reference to a compiler-generated field
                class973.gclass230_0 = gclass230;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                Decimal decimal_73 = class970.list_0
                    .SelectMany<ShipData, StoredComponent>(gclass40_0 => gclass40_0.TransportedComponents)
                    .Where<StoredComponent>(class973.method_0).Sum<StoredComponent>(gclass73_0 => gclass73_0.Amount);
                // ISSUE: reference to a compiler-generated field
                str = string.Format((string)"{0}{1} {2}   ", (object)str, (object)class973.gclass230_0.Name,
                    (object)AuroraUtils.FormatNumberToDigits(decimal_73, 2));
            }

            // ISSUE: reference to a compiler-generated field
            foreach (AuroraElement auroraElement in class970.list_0
                         .SelectMany<ShipData, SingleMineralValue>(gclass40_0 => gclass40_0.TransportedMineral.GetAsSingleMineralValueList())
                         .Select<SingleMineralValue, AuroraElement>(gclass125_0 => gclass125_0.auroraElement_0)
                         .Distinct<AuroraElement>().ToList<AuroraElement>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class974 class974 = new FleetData.Class974();
                // ISSUE: reference to a compiler-generated field
                class974.auroraElement_0 = auroraElement;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                Decimal decimal_73 = class970.list_0
                    .SelectMany<ShipData, SingleMineralValue>(gclass40_0 => gclass40_0.TransportedMineral.GetAsSingleMineralValueList())
                    .Where<SingleMineralValue>(class974.method_0).Sum<SingleMineralValue>(gclass125_0 => gclass125_0.decimal_0);
                // ISSUE: reference to a compiler-generated field
                str =
                    string.Format((string)"{0}{1} {2}   ", (object)str,
                        (object)AuroraUtils.smethod_82(class974.auroraElement_0),
                        (object)AuroraUtils.smethod_39(decimal_73));
            }

            // ISSUE: reference to a compiler-generated method
            List<GroundUnitFormationData> list = this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class970.method_0)
                .ToList<GroundUnitFormationData>();
            if (list.Count < 4)
            {
                foreach (GroundUnitFormationData gclass103 in list)
                    str = string.Format((string)"{0}{1}   ", (object)str, (object)gclass103.method_45());
            }
            else
            {
                Decimal decimal_73 = list.Sum<GroundUnitFormationData>(gclass103_0 => gclass103_0.method_34());
                if (decimal_73 > 0M)
                    str = string.Format((string)"{0}Ground Forces {1} tons   ", (object)str,
                        (object)AuroraUtils.smethod_39(decimal_73));
            }

            // ISSUE: reference to a compiler-generated field
            foreach (TransportedTradeGood gclass191 in class970.list_0
                         .SelectMany<ShipData, TransportedTradeGood>(gclass40_0 => gclass40_0.TransportedTradeGoods.Values)
                         .ToList<TransportedTradeGood>())
                str = string.Format((string)"{0}{1} {2}   ", (object)str, (object)gclass191.TradeGood.string_0,
                    (object)AuroraUtils.FormatNumberToDigits(gclass191.Amount, 2));
            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 905);
            return "";
        }
    }

    public List<ShipData> method_176()
    {
        try
        {
            return this.list_3.ToList<ShipData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3368);
            return null;
        }
    }

    public List<ShipData> method_177()
    {
        try
        {
            return this.list_3.Where<ShipData>(gclass40_0 => gclass40_0.gclass40_0 == null)
                .ToList<ShipData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3369);
            return null;
        }
    }

    public List<ShipData> method_178()
    {
        try
        {
            return this.list_3
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass40_0 == null && gclass40_0.gclass40_3 == null)
                .ToList<ShipData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3579);
            return null;
        }
    }

    public int method_179()
    {
        try
        {
            return this.list_3.Count;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3370);
            return 0;
        }
    }

    public int method_180()
    {
        try
        {
            return this.list_3.Count<ShipData>(gclass40_0 => gclass40_0.gclass40_0 == null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3371);
            return 0;
        }
    }

    public ShipData method_181(ShipClass gclass22_1)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class975 class975 = new FleetData.Class975();
        // ISSUE: reference to a compiler-generated field
        class975.gclass22_0 = gclass22_1;
        try
        {
            foreach (ShipData gclass40 in this.method_176())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class976 class976 = new FleetData.Class976();
                // ISSUE: reference to a compiler-generated field
                class976.class975_0 = class975;
                // ISSUE: reference to a compiler-generated field
                class976.gclass40_0 = gclass40;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class976.gclass40_0.method_157(AuroraComponentType.HangarDeck, false) > 0M ||
                    class976.gclass40_0.method_157(AuroraComponentType.CommercialHangarDeck, false) > 0M)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    List<ClassFighterTemplate> list = class976.gclass40_0.Class.FighterClassTemplates
                        .Where<ClassFighterTemplate>(class976.class975_0.func_0 ??
                                         (class976.class975_0.func_0 = class976.class975_0.method_0))
                        .ToList<ClassFighterTemplate>();
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (list.Count > 0 &&
                        this.gclass0_0.Ships.Values.Where<ShipData>(class976.method_0)
                            .ToList<ShipData>().Count < list[0].Number && class976.gclass40_0.method_125() >=
                        class976.class975_0.gclass22_0.Size)
                    {
                        // ISSUE: reference to a compiler-generated field
                        return class976.gclass40_0;
                    }
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 906);
            return null;
        }
    }

    public List<ShipComponent> method_182(AuroraComponentType auroraComponentType_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class977 class977 = new FleetData.Class977();
        // ISSUE: reference to a compiler-generated field
        class977.auroraComponentType_0 = auroraComponentType_0;
        try
        {
            List<ShipComponent> source = new List<ShipComponent>();
            foreach (ShipData gclass40 in this.method_177())
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                List<ShipComponent> list = gclass40.Class.ClassComponents.Values
                    .Where<ClassComponent>(class977.func_0 ?? (class977.func_0 = class977.method_0))
                    .Select<ClassComponent, ShipComponent>(gclass228_0 => gclass228_0.Component).ToList<ShipComponent>();
                source.AddRange(list);
            }

            return source.Distinct<ShipComponent>().ToList<ShipComponent>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 907);
            return null;
        }
    }

    public List<ShipComponent> method_183()
    {
        try
        {
            List<ShipComponent> source = new List<ShipComponent>();
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.gclass85_0 == this && gclass40_0.gclass40_0 == null).ToList<ShipData>())
            {
                if (gclass40.bool_8)
                {
                    List<ShipComponent> list = gclass40.Class.ClassComponents.Values
                        .Where<ClassComponent>(gclass228_0 =>
                            gclass228_0.Component.Data.ComponentTypeID ==
                            AuroraComponentType.ActiveSearchSensors)
                        .Select<ClassComponent, ShipComponent>(gclass228_0 => gclass228_0.Component).ToList<ShipComponent>();
                    source.AddRange(list);
                }
            }

            return source.Distinct<ShipComponent>().ToList<ShipComponent>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 908);
            return null;
        }
    }

    public Decimal method_184(AuroraComponentType auroraComponentType_0, bool bool_25)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class978 class978 = new FleetData.Class978();
        // ISSUE: reference to a compiler-generated field
        class978.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class978.bool_0 = bool_25;
        // ISSUE: reference to a compiler-generated field
        class978.auroraComponentType_0 = auroraComponentType_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            List<ShipComponent> list = this.gclass0_0.Ships.Values.Where<ShipData>(class978.method_0)
                .SelectMany<ShipData, ClassComponent>(class978.method_1)
                .Select<ClassComponent, ShipComponent>(gclass228_0 => gclass228_0.Component).ToList<ShipComponent>();
            return list.Count == 0 ? 0M : list.Max<ShipComponent>(gclass230_0 => gclass230_0.decimal_3);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 909);
            return 0M;
        }
    }

    public List<ShipComponent> method_185()
    {
        try
        {
            List<ShipComponent> source = new List<ShipComponent>();
            foreach (ShipData gclass40 in this.method_176())
            {
                List<ShipComponent> list = gclass40.Class.ClassComponents.Values
                    .Where<ClassComponent>(gclass228_0 => gclass228_0.Component.bool_4)
                    .Select<ClassComponent, ShipComponent>(gclass228_0 => gclass228_0.Component).ToList<ShipComponent>();
                source.AddRange(list);
            }

            return source.Distinct<ShipComponent>().ToList<ShipComponent>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 910);
            return null;
        }
    }

    public List<GClass229> method_186()
    {
        try
        {
            Dictionary<ShipComponent, GClass229> dictionary = new Dictionary<ShipComponent, GClass229>();
            foreach (ShipData gclass40 in this.method_177())
            {
                int num = (int)gclass40.method_219();
                foreach (ShipComponent gclass230 in gclass40.Class.ClassComponents.Values
                             .Where<ClassComponent>(gclass228_0 => gclass228_0.Component.bool_4)
                             .Select<ClassComponent, ShipComponent>(gclass228_0 => gclass228_0.Component).ToList<ShipComponent>())
                {
                    int int_1 = gclass230.method_18();
                    if (num < int_1)
                        int_1 = num;
                    if (!dictionary.ContainsKey(gclass230))
                        dictionary.Add(gclass230, new GClass229(gclass230, int_1));
                    else if (dictionary[gclass230].int_0 < int_1)
                        dictionary[gclass230].int_0 = int_1;
                }
            }

            return dictionary.Values.ToList<GClass229>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 911);
            return null;
        }
    }

    public List<RaceMissile> method_187()
    {
        try
        {
            List<RaceMissile> source = new List<RaceMissile>();
            foreach (ShipData gclass40 in this.method_177())
            {
                List<RaceMissile> list = gclass40.Ordnances
                    .Select<ShipOrdnance, RaceMissile>(gclass130_0 => gclass130_0.RaceMissile).ToList<RaceMissile>();
                source.AddRange(list);
            }

            return source.Distinct<RaceMissile>().ToList<RaceMissile>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 912);
            return null;
        }
    }

    public TreeNode method_188()
    {
        try
        {
            TreeNode treeNode = new TreeNode();
            treeNode.Text = this.FleetName;
            treeNode.Tag = this;
            List<ShipData> source = this.method_176();
            foreach (ShipClass gclass22 in source.Select<ShipData, ShipClass>(gclass40_0 => gclass40_0.Class)
                         .Distinct<ShipClass>().ToList<ShipClass>()
                         .OrderBy<ShipClass, string>(gclass22_0 => gclass22_0.ClassName).ToList<ShipClass>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class979 class979 = new FleetData.Class979();
                // ISSUE: reference to a compiler-generated field
                class979.gclass22_0 = gclass22;
                TreeNode node = new TreeNode();
                // ISSUE: reference to a compiler-generated field
                node.Tag = class979.gclass22_0;
                // ISSUE: reference to a compiler-generated method
                List<ShipData> list = source.Where<ShipData>(class979.method_0).ToList<ShipData>();
                // ISSUE: reference to a compiler-generated field
                node.Text = string.Format((string)"{0}x {1}", (object)list.Count.ToString(),
                    (object)class979.gclass22_0.ClassName);
                foreach (ShipData gclass40 in list
                             .OrderBy<ShipData, string>(gclass40_0 => gclass40_0.ShipName).ToList<ShipData>())
                    node.Nodes.Add(new TreeNode()
                    {
                        Tag = gclass40,
                        Text = gclass40.ShipName
                    });
                treeNode.Nodes.Add(node);
            }

            return treeNode;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 913);
            return null;
        }
    }

    public void method_189(
        Graphics graphics_0,
        Font font_0,
        GClass222 gclass222_0,
        RacialSystemSurvey gclass202_1,
        int int_12,
        int int_13,
        int int_14)
    {
        try
        {
            SolidBrush solidBrush_0 = new SolidBrush(AuroraUtils.color_3);
            Pen pen = new Pen(AuroraUtils.color_3);
            if (this.CivilianFunction != CivilanFunctionType.const_0)
            {
                solidBrush_0.Color = AuroraUtils.color_4;
                pen.Color = AuroraUtils.color_4;
            }

            double x = gclass222_0.double_2 - AuroraUtils.int_61 / 2;
            double y = gclass222_0.double_3 - AuroraUtils.int_61 / 2;
            if (this.LastMoveTime == this.gclass0_0.GameTime && this.Race.chkMoveTail == CheckState.Checked)
            {
                GClass221 gclass221_1 = new GClass221();
                GClass221 gclass221_2 = gclass202_1.method_47(this.IncrementStartX, this.IncrementStartY);
                graphics_0.DrawLine(pen, (float)gclass222_0.double_2, (float)gclass222_0.double_3,
                    (float)gclass221_2.double_0, (float)gclass221_2.double_1);
            }

            if (int_12 == 0)
                graphics_0.FillEllipse(solidBrush_0, (float)x, (float)y, AuroraUtils.int_61, AuroraUtils.int_61);
            string str1 = "";
            bool flag = true;
            if (gclass202_1.Race.chkOrder == CheckState.Checked)
            {
                MoveOrder gclass139 = this.method_255();
                if (gclass139 != null)
                {
                    string str2 = gclass139.Description;
                    if (gclass139.DelayRemaining > 0)
                        str2 = string.Format((string)"{0}: Delay  {1}", (object)str2,
                            (object)this.gclass0_0.method_568(gclass139.DelayRemaining, false));
                    str1 = string.Format((string)"  ({0})", (object)str2);
                    if (gclass139.bArrived)
                    {
                        if (gclass139.SurveyPointsRequired > 0M)
                            str1 = string.Format((string)"{0}  SP Required: {1}", (object)str1,
                                (object)AuroraUtils.FormatNumberToDigits(gclass139.SurveyPointsRequired, 1));
                        else if (gclass139.TimeRequired > 0)
                            str1 = string.Format((string)"{0}  Time Required: {1}", (object)str1,
                                (object)this.gclass0_0.method_568(gclass139.TimeRequired, false));
                        flag = false;
                    }
                }
            }

            string str3 = "";
            if (gclass202_1.Race.chkTAD == CheckState.Checked)
                str3 = string.Format((string)"   {0}", (object)this.method_192());
            string str4 = "";
            if (this.MoveOrderDictionary.Count > 0 && flag)
                str4 = string.Format((string)"{0} km/s", (object)this.Speed);
            string str5 = "";
            if (this.Race.chkBearing == CheckState.Checked && this.MoveOrderDictionary.Count > 0)
                str5 =
                    string.Format((string)"  Heading {0}{1}",
                        (object)AuroraUtils.smethod_43(this.gclass0_0.method_591(this.XCoord, this.YCoord,
                            this.LastXCoord, this.LastYCoord)), (object)char.ConvertFromUtf32(176 /*0xB0*/));
            string str6 = "";
            if (this.method_176().Count<ShipData>(gclass40_0 => gclass40_0.genum29_0 == GEnum29.const_1) > 0)
                str6 = " [OV]";
            GClass221 gclass221 = new GClass221();
            if (int_14 == 0)
            {
                gclass221.double_0 = x + AuroraUtils.int_61 + 5.0;
                gclass221.double_1 = y - 3.0 - int_12 * 15;
                graphics_0.DrawString(
                    string.Format((string)"{0}{1}{2}{3}   {4}{5}", new[] { this.FleetName }, str6, str1, str3, str4,
                        str5), font_0, solidBrush_0,
                    (float)gclass221.double_0, (float)gclass221.double_1);
            }
            else
            {
                string str7 = AuroraUtils.smethod_71(int_14);
                gclass221.double_0 = x - AuroraUtils.int_61;
                gclass221.double_1 = y + AuroraUtils.int_61 * 3 + int_13 * 15;
                if (!gclass222_0.bool_1)
                    gclass221.double_1 -= 15.0;
                if (gclass202_1.Race.chkSBSurvey == CheckState.Checked)
                    gclass221.double_1 += 5.0;
                graphics_0.DrawString(
                    string.Format((string)"{0}{1}  (Time Required: {2})  {3}   {4}{5}", new[] { this.FleetName }, str6,
                        str7, str3, str4, str5), font_0,
                    solidBrush_0, (float)gclass221.double_0, (float)gclass221.double_1);
            }

            if (this.Race.chkActiveSensors == CheckState.Checked && this.bDisplaySensors)
            {
                pen.DashStyle = DashStyle.Dash;
                pen.DashPattern = new float[2] { 15f, 5f };
                pen.Color = Color.FromArgb(176 /*0xB0*/, 226, byte.MaxValue);
                solidBrush_0.Color = Color.FromArgb(176 /*0xB0*/, 226, byte.MaxValue);
                foreach (ShipComponent gclass230 in this.method_183())
                {
                    double key = gclass230.double_0 / gclass202_1.KmPerPixel;
                    if (key >= 1.0)
                    {
                        graphics_0.DrawEllipse(pen, (float)(gclass222_0.double_2 - key),
                            (float)(gclass222_0.double_3 - key), (float)key * 2f, (float)key * 2f);
                        string str8 = gclass230.double_0 <= 10000000.0
                            ? AuroraUtils.FormatDoubleToPrecision(gclass230.double_0 / 1000000.0, 1)
                            : AuroraUtils.FormatDoubleToPrecision(gclass230.double_0 / 1000000.0, 0);
                        string str9 = string.Format((string)"{0}  {1}m  R{2}", (object)gclass230.Name, (object)str8,
                            (object)gclass230.Resolution.ToString());
                        float num = graphics_0.MeasureString(str9, font_0).Width / 2f;
                        if (gclass222_0.dictionary_0.ContainsKey(key))
                            gclass222_0.dictionary_0[key]++;
                        else
                            gclass222_0.dictionary_0.Add(key, 1);
                        graphics_0.DrawString(str9, font_0, solidBrush_0, (float)gclass222_0.double_2 - num,
                            (float)(gclass222_0.double_3 - key - 5.0) - 15 * gclass222_0.dictionary_0[key]);
                    }
                }
            }

            if ((this.Race.chkPassive10 == CheckState.Checked ||
                 this.Race.chkPassive100 == CheckState.Checked ||
                 this.Race.chkPassive1000 == CheckState.Checked ||
                 this.Race.chkPassive10000 == CheckState.Checked) && this.bDisplaySensors)
            {
                Decimal decimal_9_1 = this.method_184(AuroraComponentType.ThermalSensors, false);
                Decimal decimal_9_2 = this.method_184(AuroraComponentType.EMSensors, false);
                Decimal decimal_9_3 = this.method_184(AuroraComponentType.ELINTModule, false);
                if (decimal_9_1 > 0M)
                {
                    if (this.Race.chkPassive10 == CheckState.Checked)
                        this.method_190(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_1, decimal_9_1,
                            10, "Thermal");
                    if (this.Race.chkPassive100 == CheckState.Checked)
                        this.method_190(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_1, decimal_9_1,
                            100, "Thermal");
                    if (this.Race.chkPassive1000 == CheckState.Checked)
                        this.method_190(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_1, decimal_9_1,
                            1000, "Thermal");
                    if (this.Race.chkPassive10000 == CheckState.Checked)
                        this.method_190(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_1, decimal_9_1,
                            10000, "Thermal");
                }

                if (decimal_9_2 > 0M)
                {
                    if (this.Race.chkPassive10 == CheckState.Checked)
                        this.method_190(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_1, decimal_9_2,
                            10, "EM");
                    if (this.Race.chkPassive100 == CheckState.Checked)
                        this.method_190(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_1, decimal_9_2,
                            100, "EM");
                    if (this.Race.chkPassive1000 == CheckState.Checked)
                        this.method_190(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_1, decimal_9_2,
                            1000, "EM");
                    if (this.Race.chkPassive10000 == CheckState.Checked)
                        this.method_190(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_1, decimal_9_2,
                            10000, "EM");
                }

                if (decimal_9_3 > 0M)
                {
                    if (this.Race.chkPassive10 == CheckState.Checked)
                        this.method_190(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_1, decimal_9_3,
                            10, "ELINT");
                    if (this.Race.chkPassive100 == CheckState.Checked)
                        this.method_190(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_1, decimal_9_3,
                            100, "ELINT");
                    if (this.Race.chkPassive1000 == CheckState.Checked)
                        this.method_190(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_1, decimal_9_3,
                            1000, "ELINT");
                    if (this.Race.chkPassive10000 == CheckState.Checked)
                        this.method_190(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_1, decimal_9_3,
                            10000, "ELINT");
                }
            }

            if (this.Race.chkFireControlRange == CheckState.Checked && this.bDisplayWeapons)
            {
                pen.DashStyle = DashStyle.Dash;
                pen.DashPattern = new float[2] { 10f, 3f };
                pen.Color = Color.FromArgb(238, 220, 130);
                solidBrush_0.Color = Color.FromArgb(238, 220, 130);
                foreach (ShipComponent gclass230 in this.method_182(AuroraComponentType.MissileFireControl))
                {
                    double key = gclass230.double_0 / gclass202_1.KmPerPixel;
                    if (key >= 1.0)
                    {
                        graphics_0.DrawEllipse(pen, (float)(gclass222_0.double_2 - key),
                            (float)(gclass222_0.double_3 - key), (float)key * 2f, (float)key * 2f);
                        string str10 = gclass230.double_0 <= 10000000.0
                            ? AuroraUtils.FormatDoubleToPrecision(gclass230.double_0 / 1000000.0, 1)
                            : AuroraUtils.FormatDoubleToPrecision(gclass230.double_0 / 1000000.0, 0);
                        string str11 = string.Format((string)"{0}  {1}m  R{2}", (object)gclass230.Name, (object)str10,
                            (object)gclass230.Resolution.ToString());
                        float num = graphics_0.MeasureString(str11, font_0).Width / 2f;
                        if (gclass222_0.dictionary_0.ContainsKey(key))
                            gclass222_0.dictionary_0[key]++;
                        else
                            gclass222_0.dictionary_0.Add(key, 1);
                        graphics_0.DrawString(str11, font_0, solidBrush_0, (float)gclass222_0.double_2 - num,
                            (float)(gclass222_0.double_3 - key - 5.0) - 15 * gclass222_0.dictionary_0[key]);
                    }
                }

                foreach (ShipComponent gclass230 in this.method_182(AuroraComponentType.BeamFireControl))
                {
                    double key = (double)gclass230.decimal_3 / gclass202_1.KmPerPixel;
                    if (key >= 1.0)
                        graphics_0.DrawEllipse(pen, (float)(gclass222_0.double_2 - key),
                            (float)(gclass222_0.double_3 - key), (float)key * 2f, (float)key * 2f);
                    string str12 = string.Format((string)"{0}  {1}km", (object)gclass230.Name,
                        (object)AuroraUtils.smethod_39(gclass230.decimal_3));
                    float num = graphics_0.MeasureString(str12, font_0).Width / 2f;
                    if (gclass222_0.dictionary_0.ContainsKey(key))
                        gclass222_0.dictionary_0[key]++;
                    else
                        gclass222_0.dictionary_0.Add(key, 1);
                    graphics_0.DrawString(str12, font_0, solidBrush_0, (float)gclass222_0.double_2 - num,
                        (float)(gclass222_0.double_3 - key - 5.0) - 15 * gclass222_0.dictionary_0[key]);
                }
            }

            if (this.Race.chkFiringRanges == CheckState.Checked && gclass202_1.KmPerPixel < 100000000.0 &&
                this.bDisplayWeapons)
            {
                List<GClass229> gclass229List = this.method_186();
                pen.DashStyle = DashStyle.Dash;
                pen.DashPattern = new float[2] { 10f, 3f };
                pen.Color = Color.FromArgb(255, 185, 15);
                solidBrush_0.Color = Color.FromArgb(255, 185, 15);
                foreach (GClass229 gclass229 in gclass229List)
                {
                    double key = (int)(gclass229.int_0 / gclass202_1.KmPerPixel);
                    if (key >= 1.0 && key <= 10000.0)
                    {
                        graphics_0.DrawEllipse(pen, (float)(gclass222_0.double_2 - key),
                            (float)(gclass222_0.double_3 - key), (float)key * 2f, (float)key * 2f);
                        string name = gclass229.gclass230_0.Name;
                        int num1 = gclass229.int_0 / 1000;
                        string str13 = num1.ToString();
                        string str14 = string.Format((string)"{0}  {1}k", (object)name, (object)str13);
                        float num2 = graphics_0.MeasureString(str14, font_0).Width / 2f;
                        if (gclass222_0.dictionary_0.ContainsKey(key))
                            num1 = gclass222_0.dictionary_0[key]++;
                        else
                            gclass222_0.dictionary_0.Add(key, 1);
                        graphics_0.DrawString(str14, font_0, solidBrush_0, (float)gclass222_0.double_2 - num2,
                            (float)(gclass222_0.double_3 - key - 5.0) - 15 * gclass222_0.dictionary_0[key]);
                    }
                }

                foreach (RaceMissile gclass129 in this.method_187())
                {
                    double key = gclass129.CombinatedMaxRange / gclass202_1.KmPerPixel;
                    if (key >= 1.0 && key <= 10000.0)
                    {
                        graphics_0.DrawEllipse(pen, (float)(gclass222_0.double_2 - key),
                            (float)(gclass222_0.double_3 - key), (float)key * 2f, (float)key * 2f);
                        string name = gclass129.Name;
                        int num3 = (int)(gclass129.CombinatedMaxRange / 1000000.0);
                        string str15 = num3.ToString();
                        string str16 = string.Format((string)"{0}  {1}m", (object)name, (object)str15);
                        float num4 = graphics_0.MeasureString(str16, font_0).Width / 2f;
                        if (gclass222_0.dictionary_0.ContainsKey(key))
                            num3 = gclass222_0.dictionary_0[key]++;
                        else
                            gclass222_0.dictionary_0.Add(key, 1);
                        graphics_0.DrawString(str16, font_0, solidBrush_0, (float)gclass222_0.double_2 - num4,
                            (float)(gclass222_0.double_3 - key - 5.0) - 15 * gclass222_0.dictionary_0[key]);
                    }
                }
            }

            pen.Dispose();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 914);
        }
    }

    public void method_190(
        Graphics graphics_0,
        SolidBrush solidBrush_0,
        Pen pen_0,
        Font font_0,
        GClass222 gclass222_0,
        RacialSystemSurvey gclass202_1,
        Decimal decimal_9,
        int int_12,
        string string_1)
    {
        try
        {
            pen_0.DashStyle = DashStyle.Dash;
            pen_0.DashPattern = new float[2] { 12f, 4f };
            pen_0.Color = Color.LightCoral;
            solidBrush_0.Color = Color.LightCoral;
            switch (string_1)
            {
                case "EM":
                    pen_0.Color = Color.Thistle;
                    solidBrush_0.Color = Color.Thistle;
                    break;
                case "ELINT":
                    pen_0.Color = Color.AliceBlue;
                    solidBrush_0.Color = Color.AliceBlue;
                    break;
            }

            double num1 = Math.Sqrt((double)decimal_9 * int_12) * AuroraUtils.double_18;
            double key = num1 / gclass202_1.KmPerPixel;
            if (key < 1.0)
                return;
            graphics_0.DrawEllipse(pen_0, (float)(gclass222_0.double_2 - key), (float)(gclass222_0.double_3 - key),
                (float)key * 2f, (float)key * 2f);
            string str1 = num1 <= 10000000.0
                ? AuroraUtils.FormatDoubleToPrecision(num1 / 1000000.0, 1)
                : AuroraUtils.FormatDoubleToPrecision(num1 / 1000000.0, 0);
            string str2 = string.Format((string)"{0} vs {1} Signature-{2}   {3}m", new[] { this.FleetName }, string_1,
                int_12.ToString(), str1);
            float num2 = graphics_0.MeasureString(str2, font_0).Width / 2f;
            if (gclass222_0.dictionary_0.ContainsKey(key))
                gclass222_0.dictionary_0[key]++;
            else
                gclass222_0.dictionary_0.Add(key, 1);
            graphics_0.DrawString(str2, font_0, solidBrush_0, (float)gclass222_0.double_2 - num2,
                (float)(gclass222_0.double_3 - key - 5.0) - 15 * gclass222_0.dictionary_0[key]);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 915);
        }
    }

    public Decimal method_191()
    {
        try
        {
            Decimal num = 0M;
            GClass221 gclass221 = new GClass221(this.XCoord, this.YCoord);
            foreach (MoveOrder gclass139 in this.MoveOrderDictionary.Values
                         .OrderBy<MoveOrder, int>(gclass139_0 => gclass139_0.OrderValue).ToList<MoveOrder>())
            {
                GClass221 gclass221_0 = this.gclass0_0.method_53(gclass139.DestinationType, gclass139.DestinationID,
                    gclass139.StartSystem.ActualSystem, null, this, gclass139.MinDistance, 0M);
                if (!this.bool_19 && gclass139.MinDistance > 0.0)
                {
                    if (gclass221_0.double_0 == this.XCoord && gclass221_0.double_1 == this.YCoord)
                    {
                        gclass221_0.double_0 += 100.0;
                        gclass221_0.double_1 += 100.0;
                    }

                    gclass221_0 = this.method_252(gclass221_0, gclass139.MinDistance);
                }

                num += (Decimal)this.gclass0_0.GetDistanceBetween(gclass221.double_0, gclass221.double_1, gclass221_0.double_0,
                    gclass221_0.double_1);
                if (gclass139.NewJumpPoint != null)
                {
                    gclass221.double_0 = gclass139.NewJumpPoint.XCoord;
                    gclass221.double_1 = gclass139.NewJumpPoint.YCoord;
                }
                else if (gclass139.MoveActionType.MoveActionType == MoveActionType.IntraSystemJump)
                {
                    gclass221.double_0 = this.gclass0_0.LagrangePoints[gclass139.DestinationItemID].XCor;
                    gclass221.double_1 = this.gclass0_0.LagrangePoints[gclass139.DestinationItemID].Ycor;
                }
                else
                    gclass221 = gclass221_0;
            }

            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 916);
            return 0M;
        }
    }

    public string method_192()
    {
        try
        {
            MoveOrder gclass139 = this.method_255();
            if (gclass139 == null || this.Speed == 1)
                return "";
            GClass221 gclass221_0 = this.gclass0_0.method_53(gclass139.DestinationType, gclass139.DestinationID,
                gclass139.StartSystem.ActualSystem, null, this, gclass139.MinDistance, 0M);
            if (!this.bool_19 && gclass139.MinDistance > 0.0)
            {
                if (gclass221_0.double_0 == this.XCoord && gclass221_0.double_1 == this.YCoord)
                {
                    gclass221_0.double_0 += 100.0;
                    gclass221_0.double_1 += 100.0;
                }

                gclass221_0 = this.method_252(gclass221_0, gclass139.MinDistance);
            }

            if (gclass139.MoveActionType.MoveActionType == MoveActionType.ExtendedOrbit)
                gclass221_0.double_1 -= gclass139.OrbDistance;
            Decimal decimal_73 = (Decimal)this.gclass0_0.GetDistanceBetween(this.XCoord, this.YCoord, gclass221_0.double_0,
                gclass221_0.double_1);
            Decimal int_136 = decimal_73 / this.Speed;
            return
                string.Format((string)"Distance {0}  ETA {1}", (object)AuroraUtils.smethod_61(decimal_73, ""),
                    (object)this.gclass0_0.method_568((int)int_136, false));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 917);
            return "Error";
        }
    }

    public int method_193()
    {
        foreach (MoveOrder gclass139 in this.MoveOrderDictionary.Values)
        {
            if (gclass139.TimeRequired > 0)
                return gclass139.TimeRequired;
        }

        return 0;
    }

    public int method_194()
    {
        try
        {
            return (int)this.method_176().Where<ShipData>(gclass40_0 => gclass40_0.Class.ArkShip)
                .Sum<ShipData>(gclass40_0 => gclass40_0.method_150());
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3553);
            return 0;
        }
    }

    public int method_195()
    {
        try
        {
            List<ShipData> source = this.method_178();
            return source.Count == 0 ? 1 : (int)source.Min<ShipData>(gclass40_0 => gclass40_0.method_171(false));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 918);
            return 1;
        }
    }

    public void method_196()
    {
        try
        {
            this.StandingOrdersDictionary.Clear();
            switch (this.CivilianFunction)
            {
                case CivilanFunctionType.const_2:
                    this.StandingOrdersDictionary.Add(1,
                        this.gclass0_0.StandingOrderDictionary[AuroraStandingOrder.LoadColonistsFromColonistSource]);
                    this.StandingOrdersDictionary.Add(2, this.gclass0_0.StandingOrderDictionary[AuroraStandingOrder.UnloadColonists]);
                    break;
                case CivilanFunctionType.const_3:
                    this.StandingOrdersDictionary.Add(1,
                        this.gclass0_0.StandingOrderDictionary[AuroraStandingOrder.MovetoGasGiantwithSorium10mPop]);
                    break;
                case CivilanFunctionType.const_4:
                    this.StandingOrdersDictionary.Add(1, this.gclass0_0.StandingOrderDictionary[AuroraStandingOrder.LoadPassengers]);
                    this.StandingOrdersDictionary.Add(2, this.gclass0_0.StandingOrderDictionary[AuroraStandingOrder.UnloadPassengers]);
                    break;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 919);
        }
    }

    public void method_197(ListView listView_0)
    {
        try
        {
            listView_0.Items.Clear();
            if (this.StandingOrdersDictionary.Count == 0 && this.ConditionalOrdersDictionary.Count == 0)
                return;
            if (this.StandingOrdersDictionary.Count > 0)
                this.gclass0_0.method_601(listView_0, "", "Standing Orders", null);
            this.StandingOrdersDictionary = this.StandingOrdersDictionary
                .OrderBy<KeyValuePair<int, StandingOrderDefinition>, int>(keyValuePair_0 => keyValuePair_0.Key)
                .ToDictionary<KeyValuePair<int, StandingOrderDefinition>, int, StandingOrderDefinition>(keyValuePair_0 => keyValuePair_0.Key,
                    keyValuePair_0 => keyValuePair_0.Value);
            foreach (KeyValuePair<int, StandingOrderDefinition> keyValuePair in this.StandingOrdersDictionary)
                this.gclass0_0.method_598(listView_0, keyValuePair.Key.ToString(), keyValuePair.Value.Description,
                    keyValuePair.Value);
            if (this.ConditionalOrdersDictionary.Count > 0)
            {
                this.gclass0_0.method_594(listView_0, "");
                this.gclass0_0.method_601(listView_0, "", "Conditional Orders", null);
            }

            this.ConditionalOrdersDictionary = this.ConditionalOrdersDictionary
                .OrderBy<KeyValuePair<int, FleetConditionalOrder>, int>(keyValuePair_0 => keyValuePair_0.Key)
                .ToDictionary<KeyValuePair<int, FleetConditionalOrder>, int, FleetConditionalOrder>(keyValuePair_0 => keyValuePair_0.Key,
                    keyValuePair_0 => keyValuePair_0.Value);
            foreach (KeyValuePair<int, FleetConditionalOrder> keyValuePair in this.ConditionalOrdersDictionary)
            {
                string string_13 = "";
                if (keyValuePair.Value.CreateFleetWaypoint == 1)
                    string_13 = "WP";
                this.gclass0_0.method_604(listView_0, keyValuePair.Key.ToString(),
                    this.gclass0_0.StandingOrderDictionary[keyValuePair.Value.StandingOrder].Description,
                    this.gclass0_0.FleetConditionDictionary[keyValuePair.Value.Condition].Description, string_13,
                    keyValuePair.Value);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3898);
        }
    }

    public void method_198(int int_12)
    {
        try
        {
            List<StandingOrderDefinition> list = this.StandingOrdersDictionary
                .OrderBy<KeyValuePair<int, StandingOrderDefinition>, int>(keyValuePair_0 => keyValuePair_0.Key)
                .Select<KeyValuePair<int, StandingOrderDefinition>, StandingOrderDefinition>(keyValuePair_0 => keyValuePair_0.Value)
                .ToList<StandingOrderDefinition>();
            this.StandingOrdersDictionary.Clear();
            int key = 1;
            if (1 == int_12)
                ++key;
            foreach (StandingOrderDefinition gclass136 in list)
            {
                this.StandingOrdersDictionary.Add(key, gclass136);
                ++key;
                if (key == int_12)
                    ++key;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3901);
        }
    }

    public void method_199(int int_12)
    {
        try
        {
            List<FleetConditionalOrder> list = this.ConditionalOrdersDictionary
                .OrderBy<KeyValuePair<int, FleetConditionalOrder>, int>(keyValuePair_0 => keyValuePair_0.Key)
                .Select<KeyValuePair<int, FleetConditionalOrder>, FleetConditionalOrder>(keyValuePair_0 => keyValuePair_0.Value)
                .ToList<FleetConditionalOrder>();
            this.ConditionalOrdersDictionary.Clear();
            int key = 1;
            if (1 == int_12)
                ++key;
            foreach (FleetConditionalOrder gclass138 in list)
            {
                this.ConditionalOrdersDictionary.Add(key, gclass138);
                ++key;
                if (key == int_12)
                    ++key;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3907);
        }
    }

    public void method_200(MoveOrder gclass139_0)
    {
        try
        {
            if (this.method_244(this.method_177()) == 0)
                return;
            gclass139_0.MoveActionType = this.gclass0_0.MoveActionDictionary[MoveActionType.SquadronTransit];
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 662);
        }
    }

    public void method_201(FleetConditionDefinition gclass137_0, StandingOrderDefinition gclass136_0, GEnum48 genum48_1)
    {
        try
        {
            bool flag = false;
            switch (gclass137_0.FleetCondition)
            {
                case AuroraFleetCondition.FuelTanksFull:
                case AuroraFleetCondition.FuelLessThan20:
                case AuroraFleetCondition.FuelLessThan10:
                case AuroraFleetCondition.FuelLessThan30:
                case AuroraFleetCondition.FuelLessThan40:
                case AuroraFleetCondition.FuelLessThan50:
                    int int_40_1 = 100;
                    if (gclass137_0.FleetCondition == AuroraFleetCondition.FuelLessThan50)
                        int_40_1 = 50;
                    if (gclass137_0.FleetCondition == AuroraFleetCondition.FuelLessThan40)
                        int_40_1 = 40;
                    if (gclass137_0.FleetCondition == AuroraFleetCondition.FuelLessThan30)
                        int_40_1 = 30;
                    if (gclass137_0.FleetCondition == AuroraFleetCondition.FuelLessThan20)
                        int_40_1 = 20;
                    if (gclass137_0.FleetCondition == AuroraFleetCondition.FuelLessThan10)
                        int_40_1 = 10;
                    using (List<ShipData>.Enumerator enumerator = this.method_176().GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            if (enumerator.Current.method_110(int_40_1))
                            {
                                flag = true;
                                break;
                            }
                        }

                        break;
                    }
                case AuroraFleetCondition.CurrentSpeedNotEqualtoMax:
                    if (this.Speed < this.method_195())
                    {
                        flag = true;
                        break;
                    }

                    break;
                case AuroraFleetCondition.SupplyPointsLessThan20:
                case AuroraFleetCondition.SupplyPointsLessThan10:
                case AuroraFleetCondition.SupplyPointsLessThan30:
                    int int_40_2 = 30;
                    if (gclass137_0.FleetCondition == AuroraFleetCondition.SupplyPointsLessThan20)
                        int_40_2 = 20;
                    if (gclass137_0.FleetCondition == AuroraFleetCondition.SupplyPointsLessThan10)
                        int_40_2 = 10;
                    using (List<ShipData>.Enumerator enumerator = this.method_176().GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            if (enumerator.Current.method_111(int_40_2))
                            {
                                flag = true;
                                break;
                            }
                        }

                        break;
                    }
                case AuroraFleetCondition.HostileActiveShipContactinSystem:
                    if (this.System.method_16())
                    {
                        flag = true;
                        break;
                    }

                    break;
                case AuroraFleetCondition.DeploymentExceeded:
                    using (List<ShipData>.Enumerator enumerator = this.method_176().GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            ShipData current = enumerator.Current;
                            if ((this.gclass0_0.GameTime - current.decimal_7) / AuroraUtils.decimal_31 >
                                current.Class.PlannedDeployment)
                            {
                                flag = true;
                                break;
                            }
                        }

                        break;
                    }
            }

            if (!flag)
                return;
            this.method_204(gclass136_0, genum48_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 663);
        }
    }

    public bool method_202()
    {
        try
        {
            GClass201 gclass201_1 = new GClass201();
            bool flag = false;
            List<ShipData> list_22 = this.method_176();
            if (list_22.Count == 0 || this.NPRSomething.genum100_0 == GEnum100.const_0)
                return false;
            this.gclass22_0 = list_22[0].Class;
            FleetData gclass85 =
                this.Race.method_145(this.System, this.gclass22_0, this.XCoord, this.YCoord);
            if (gclass85 != null)
            {
                if (gclass85.XCoord == this.XCoord && gclass85.YCoord == this.YCoord)
                {
                    this.Race.method_270(list_22, this, gclass85, true, false);
                    return true;
                }

                if (gclass85.method_195() == 1)
                {
                    flag = true;
                }
                else
                {
                    this.method_222(gclass85, MoveActionType.JoinFleet);
                    this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                        string.Format((string)"As per standing orders {0} is moving to join {1}",
                            (object)this.FleetName, (object)gclass85.FleetName),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
                    return true;
                }
            }

            if (!flag)
            {
                GClass201 gclass201_2 = this.method_235(GEnum109.const_42, "Join Operational Group", true);
                if (gclass201_2.gclass85_0 != null)
                {
                    this.method_222(gclass201_2.gclass85_0, MoveActionType.JoinFleet);
                    this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                        string.Format((string)"As per standing orders {0} is moving to join {1}",
                            (object)this.FleetName, (object)gclass201_2.gclass85_0.FleetName),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
                    return true;
                }
            }

            OperationalGroupID key = this.Race.method_3(this.gclass22_0);
            if (key != OperationalGroupID.None)
            {
                this.NPROperationGroup = this.gclass0_0.OperationalGroupDictionary[key];
                this.StandingOrdersDictionary.Clear();
                this.method_1(1, this.NPROperationGroup.gclass136_0);
                this.method_1(2, this.NPROperationGroup.gclass136_1);
                this.FleetName =
                    string.Format((string)"{0} {1}", (object)this.NPROperationGroup.string_0,
                        (object)AuroraUtils.smethod_33(this.gclass0_0.FleetDictionary.Values
                            .Where<FleetData>(gclass85_5 =>
                                gclass85_5.Race == this.Race && gclass85_5.NPROperationGroup == this.NPROperationGroup)
                            .Count<FleetData>()));
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 664);
            return false;
        }
    }

    public bool method_203(int int_12, AuroraStandingOrder auroraStandingOrder_0)
    {
        try
        {
            double double_6 = this.XCoord;
            double double_7 = this.YCoord;
            bool flag = false;
            for (int index = 1; index <= int_12; ++index)
            {
                SystemBodyData gclass1_1 = this.Race.method_134(this.System, double_6, double_7,
                    auroraStandingOrder_0, this);
                if (gclass1_1 != null)
                {
                    double_6 = gclass1_1.XCoordinate;
                    double_7 = gclass1_1.YCoordinate;
                    this.method_215(gclass1_1, MoveActionType.GeologicalSurvey);
                    flag = true;
                }
                else if (gclass1_1 == null && index == 1 && this.Race.NPR)
                {
                    if (this.method_31() == AuroraUtils.long_2)
                        this.MaxStandingOrderDistance = AuroraUtils.long_3;
                    else if (this.method_31() == AuroraUtils.long_3)
                        this.MaxStandingOrderDistance = AuroraUtils.long_4;
                }
            }

            return flag;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 665);
            return false;
        }
    }

    public void method_204(StandingOrderDefinition gclass136_0, GEnum48 genum48_1)
    {
        try
        {
            Dictionary<int, MoveOrder> dictionary = new Dictionary<int, MoveOrder>();
            GClass201 gclass201_1 = new GClass201();
            bool flag1 = false;
            if (genum48_1 != GEnum48.const_0)
            {
                dictionary.Clear();
                foreach (KeyValuePair<int, MoveOrder> keyValuePair in this.MoveOrderDictionary)
                    dictionary.Add(keyValuePair.Key, keyValuePair.Value);
                this.method_263();
            }

            switch (gclass136_0.auroraStandingOrder_0)
            {
                case AuroraStandingOrder.SurveyNearestAsteroid:
                case AuroraStandingOrder.SurveyNearestMoon:
                case AuroraStandingOrder.SurveyNearestPlanet:
                case AuroraStandingOrder.SurveyNearestBody:
                case AuroraStandingOrder.SurveyNearestPlanetorMoon:
                    SystemBodyData gclass1_1_1 = this.Race.method_134(this.System, this.XCoord,
                        this.YCoord, gclass136_0.auroraStandingOrder_0, this);
                    if (gclass1_1_1 != null)
                    {
                        this.method_215(gclass1_1_1, MoveActionType.GeologicalSurvey);
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.SurveyNearestSurveyLocation:
                    SurveyLocation gclass213_0_1 =
                        this.Race.method_135(this.System, this.XCoord, this.YCoord);
                    if (gclass213_0_1 != null)
                    {
                        this.method_233(gclass213_0_1);
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.MoveToSystemRequiringGeosurvey:
                    if (this.method_235(GEnum109.const_8, gclass136_0.Description, true).gclass202_0 != null)
                    {
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.MovetoEntryJumpPoint:
                    if (this.EntryJumpPoint != null)
                    {
                        if (this.XCoord != this.EntryJumpPoint.XCoord || this.YCoord != this.EntryJumpPoint.YCoord)
                        {
                            this.method_231(this.EntryJumpPoint, MoveActionType.MoveTo, this.System);
                            this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                                string.Format((string)"As per standing orders {0} is moving to {1}",
                                    (object)this.FleetName, (object)this.EntryJumpPoint.method_7(this.System)),
                                this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                                AuroraEventCategory.Fleet);
                            flag1 = true;
                            break;
                        }

                        break;
                    }

                    this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                        string.Format(
                            (string)
                            "{0} has a standing order to return to its entry jump point. However, the entry jump point is not known",
                            (object)this.FleetName),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
                    break;
                case AuroraStandingOrder.MoveToSystemRequiringGravsurvey:
                    if (this.method_235(GEnum109.const_7, gclass136_0.Description, true).gclass202_0 != null)
                    {
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.SurveyNextFiveSystemBodies:
                    if ((flag1 = this.method_203(5, AuroraStandingOrder.SurveyNextFiveSystemBodies)) &&
                        this.Race.NPR)
                    {
                        this.NPRSomething.bRedeployOrderGiven = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.SurveyNextThreeSystemLocations:
                    double double_6 = this.XCoord;
                    double double_7 = this.YCoord;
                    for (int index = 1; index <= 3; ++index)
                    {
                        SurveyLocation gclass213_0_2 =
                            this.Race.method_135(this.System, double_6, double_7);
                        if (gclass213_0_2 != null)
                        {
                            double_6 = gclass213_0_2.XCoord;
                            double_7 = gclass213_0_2.YCoord;
                            this.method_233(gclass213_0_2);
                            flag1 = true;
                            if (this.Race.NPR)
                                this.NPRSomething.bRedeployOrderGiven = true;
                        }
                        else if (gclass213_0_2 == null && index == 1 && this.Race.NPR)
                        {
                            if (this.method_31() == AuroraUtils.long_2)
                                this.MaxStandingOrderDistance = AuroraUtils.long_3;
                            else if (this.method_31() == AuroraUtils.long_3)
                                this.MaxStandingOrderDistance = AuroraUtils.long_4;
                        }
                    }

                    break;
                case AuroraStandingOrder.LoadColonistsFromColonistSource:
                    if (!(this.method_149() <= 0M))
                    {
                        PopulationData gclass146_1 =
                            this.Race.method_148(this.System, this, this.XCoord, this.YCoord);
                        if (gclass146_1 != null)
                        {
                            this.method_219(gclass146_1, MoveActionType.LoadColonists);
                            flag1 = true;
                            break;
                        }

                        if (this.method_235(GEnum109.const_4, gclass136_0.Description, false).gclass202_0 != null)
                        {
                            flag1 = true;
                            break;
                        }

                        break;
                    }

                    break;
                case AuroraStandingOrder.LoadColonistsatCapital:
                    if (!(this.method_149() <= 0M))
                    {
                        PopulationData gclass146_1 = this.Race.method_153(this.System);
                        if (gclass146_1 != null)
                        {
                            this.method_219(gclass146_1, MoveActionType.LoadColonists);
                            flag1 = true;
                            break;
                        }

                        if (this.method_235(GEnum109.const_5, gclass136_0.Description, false).gclass202_0 != null)
                        {
                            flag1 = true;
                            break;
                        }

                        break;
                    }

                    break;
                case AuroraStandingOrder.UnloadColonists:
                    if (!(this.method_150() == 0M))
                    {
                        bool flag2;
                        if (!(flag2 = this.method_214(gclass136_0, GEnum109.const_6)))
                            flag2 = this.method_214(gclass136_0, GEnum109.const_35);
                        if (flag2)
                        {
                            flag1 = true;
                            break;
                        }

                        break;
                    }

                    break;
                case AuroraStandingOrder.StabiliseNearestJumpPoint:
                    if (this.method_212(gclass136_0))
                    {
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.LoadAutomatedMineFromPopulatedColony:
                    if (this.method_176().Sum<ShipData>(gclass40_0 => gclass40_0.method_124()) >=
                        this.gclass0_0.InstallationTypes[AuroraInstallationType.AutomatedMine].CargoPoints)
                    {
                        PopulationData gclass146_1 =
                            this.Race.method_149(this.System, this.XCoord, this.YCoord, true);
                        if (gclass146_1 != null)
                        {
                            this.method_220(gclass146_1, MoveActionType.LoadInstallation,
                                this.gclass0_0.InstallationTypes[AuroraInstallationType.AutomatedMine]);
                            flag1 = true;
                            break;
                        }

                        if (this.method_235(GEnum109.const_14, gclass136_0.Description, true).gclass202_0 != null)
                        {
                            flag1 = true;
                            break;
                        }

                        break;
                    }

                    break;
                case AuroraStandingOrder.DeliverAutomatedMineToMiningColony:
                    if (this.method_176().FirstOrDefault<ShipData>(gclass40_0 =>
                            gclass40_0.TransportedInstallations.ContainsKey(AuroraInstallationType.AutomatedMine)) != null)
                    {
                        PopulationData gclass146_1 = this.Race.method_150(this.System, this.XCoord,
                            this.YCoord, true, true);
                        if (gclass146_1 != null)
                        {
                            this.method_220(gclass146_1, MoveActionType.UnloadInstallation,
                                this.gclass0_0.InstallationTypes[AuroraInstallationType.AutomatedMine]);
                            flag1 = true;
                            break;
                        }

                        if (this.method_235(GEnum109.const_15, gclass136_0.Description, true).gclass202_0 != null)
                        {
                            flag1 = true;
                            break;
                        }

                        break;
                    }

                    break;
                case AuroraStandingOrder.UnloadPassengers:
                    if (this.method_214(gclass136_0, GEnum109.const_34))
                    {
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.MovetoGasGiantwithSorium:
                    SystemBodyData gclass1_1_2 =
                        this.System.ActualSystem.method_11(this.Race, 0M, false);
                    if (gclass1_1_2 != null)
                    {
                        this.method_215(gclass1_1_2, MoveActionType.MoveTo);
                        this.StandingOrdersDictionary.Clear();
                        flag1 = true;
                        break;
                    }

                    if (this.method_235(GEnum109.const_36, gclass136_0.Description, true).gclass202_0 != null)
                    {
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.SalvageNearestWreck:
                    Wreck gclass233_0 =
                        this.System.ActualSystem.method_5(this.XCoord, this.YCoord, this.System);
                    if (gclass233_0 != null)
                    {
                        this.method_216(gclass233_0, MoveActionType.SalvageWreck, this.System);
                        flag1 = true;
                        break;
                    }

                    GClass201 gclass201_2 = this.method_235(GEnum109.const_31, gclass136_0.Description, true);
                    if (gclass201_2.gclass233_0 != null)
                    {
                        this.method_216(gclass201_2.gclass233_0, MoveActionType.SalvageWreck, gclass201_2.gclass202_0);
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.TerraformColony:
                    PopulationData gclass146_1_1 = this.Race.method_133(this.System);
                    if (gclass146_1_1 != null)
                    {
                        this.method_219(gclass146_1_1, MoveActionType.MoveTo);
                        flag1 = true;
                        break;
                    }

                    if (this.method_235(GEnum109.const_39, gclass136_0.Description, true).gclass202_0 != null)
                    {
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.LoadPassengers:
                    if (!(this.method_149() <= 0M))
                    {
                        PopulationData gclass146_1_2 =
                            this.Race.method_152(this.System, this, this.XCoord, this.YCoord);
                        if (gclass146_1_2 != null)
                        {
                            this.method_219(gclass146_1_2, MoveActionType.LoadColonists);
                            flag1 = true;
                            break;
                        }

                        if (this.method_235(GEnum109.const_33, gclass136_0.Description, false).gclass202_0 != null)
                        {
                            flag1 = true;
                            break;
                        }

                        break;
                    }

                    break;
                case AuroraStandingOrder.MovetoGasGiantwithSorium10mPop:
                    SystemBodyData gclass1_1_3 =
                        this.System.ActualSystem.method_11(this.Race, 10M, true);
                    if (gclass1_1_3 != null)
                    {
                        this.method_215(gclass1_1_3, MoveActionType.MoveTo);
                        this.StandingOrdersDictionary.Clear();
                        flag1 = true;
                        break;
                    }

                    if (this.method_235(GEnum109.const_37, gclass136_0.Description, true).gclass202_0 != null)
                    {
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.LandOnMothership:
                    FleetData gclass85_5_1 = this.method_213();
                    if (gclass85_5_1 != null)
                    {
                        this.method_222(gclass85_5_1, MoveActionType.LandOnAssignedMothership);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format(
                                (string)
                                "As per standing orders {0} is moving to land on assigned mothership within {1}",
                                (object)this.FleetName, (object)gclass85_5_1.FleetName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.TransferFuelToColony:
                    PopulationData gclass146_1_3 =
                        this.Race.method_144(this.System, this.XCoord, this.YCoord);
                    if (gclass146_1_3 != null)
                    {
                        this.method_219(gclass146_1_3, MoveActionType.TransferFuelToColony);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format((string)"As per conditional orders {0} is moving to {1} to transfer fuel",
                                (object)this.FleetName, (object)gclass146_1_3.PopName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.RefuelatColony:
                    PopulationData gclass146_1_4 =
                        this.Race.method_137(this.System, this.XCoord, this.YCoord, 0M);
                    if (gclass146_1_4 != null)
                    {
                        this.method_219(gclass146_1_4, MoveActionType.RefuelFromColony);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format((string)"As per standing orders {0} is moving to {1} to refuel",
                                (object)this.FleetName, (object)gclass146_1_4.PopName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        flag1 = true;
                        break;
                    }

                    GClass201 gclass201_3 = this.method_235(GEnum109.const_1, gclass136_0.Description, true);
                    if (gclass201_3.gclass146_0 != null)
                    {
                        this.method_219(gclass201_3.gclass146_0, MoveActionType.RefuelFromColony);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format((string)"As per standing orders {0} is moving to {1} to refuel",
                                (object)this.FleetName, (object)gclass201_3.gclass146_0.PopName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.ActivateShields:
                    this.method_57(true);
                    break;
                case AuroraStandingOrder.DeactivateShields:
                    this.method_57(false);
                    break;
                case AuroraStandingOrder.ClearOrderList:
                    this.method_263();
                    break;
                case AuroraStandingOrder.ChangetoMaximumSpeed:
                    this.method_161();
                    break;
                case AuroraStandingOrder.ActiveSensorsOn:
                    this.method_60(true);
                    break;
                case AuroraStandingOrder.OverhaulatColony:
                    PopulationData gclass146_1_5 = this.Race.method_136(this.System, this.XCoord, this.YCoord,
                        this.method_142());
                    if (gclass146_1_5 != null)
                    {
                        this.method_219(gclass146_1_5, MoveActionType.BeginOverhaul);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format((string)"As per standing orders {0} is moving to {1} to begin an overhaul",
                                (object)this.FleetName, (object)gclass146_1_5.PopName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        flag1 = true;
                        break;
                    }

                    GClass201 gclass201_4 = this.method_235(GEnum109.const_2, gclass136_0.Description, true);
                    if (gclass201_4.gclass146_0 != null)
                    {
                        this.method_219(gclass201_4.gclass146_0, MoveActionType.BeginOverhaul);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format((string)"As per standing orders {0} is moving to {1} to begin an overhaul",
                                (object)this.FleetName, (object)gclass201_4.gclass146_0.PopName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.UnloadFuelatColonyandReturn:
                    PopulationData gclass146_1_6 =
                        this.Race.method_144(this.System, this.XCoord, this.YCoord);
                    if (gclass146_1_6 != null)
                    {
                        this.method_219(gclass146_1_6, MoveActionType.TransferFuelToColony);
                        SystemBodyData gclass1_1_4 =
                            this.gclass0_0.SystemBodyRecordDic.Values.FirstOrDefault<SystemBodyData>(
                                gclass1_1 =>
                                    gclass1_1.SystemData == this.System.ActualSystem &&
                                    gclass1_1.XCoordinate == this.XCoord && gclass1_1.YCoordinate == this.YCoord);
                        if (gclass1_1_4 != null)
                            this.method_215(gclass1_1_4, MoveActionType.MoveTo);
                        else
                            this.method_217(
                                this.Race.method_188(this.System.ActualSystem, null, null,
                                    WayPointType.Temporary, this.XCoord, this.YCoord,
                                    string.Format((string)"{0} Return Point", (object)this.FleetName), 0), MoveActionType.MoveTo, this.System);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format((string)"As per conditional orders {0} is moving to {1} to transfer fuel",
                                (object)this.FleetName, (object)gclass146_1_6.PopName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.ResupplyatColony:
                    PopulationData gclass146_1_7 =
                        this.Race.method_141(this.System, this.XCoord, this.YCoord, 0M);
                    if (gclass146_1_7 != null)
                    {
                        this.method_219(gclass146_1_7, MoveActionType.ResupplyFromColony);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format((string)"As per standing orders {0} is moving to {1} to resupply",
                                (object)this.FleetName, (object)gclass146_1_7.PopName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        flag1 = true;
                        break;
                    }

                    GClass201 gclass201_5 = this.method_235(GEnum109.const_9, gclass136_0.Description, true);
                    if (gclass201_5.gclass146_0 != null)
                    {
                        this.method_219(gclass201_5.gclass146_0, MoveActionType.ResupplyFromColony);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format((string)"As per standing orders {0} is moving to {1} to resupply",
                                (object)this.FleetName, (object)gclass201_5.gclass146_0.PopName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.InvestigatePOI:
                    Waypoint gclass214_0_1 = this.System.ActualSystem.method_8(this.XCoord, this.YCoord,
                        this.System, WayPointType.UrgentPOI, 0);
                    if (gclass214_0_1 != null)
                    {
                        this.method_217(gclass214_0_1, MoveActionType.MoveTo, this.System);
                        flag1 = true;
                        break;
                    }

                    GClass201 gclass201_6 = this.method_235(GEnum109.const_20, gclass136_0.Description, false);
                    if (gclass201_6.gclass214_0 != null)
                    {
                        this.method_217(gclass201_6.gclass214_0, MoveActionType.MoveTo, gclass201_6.gclass202_0);
                        flag1 = true;
                        break;
                    }

                    Waypoint gclass214_0_2 = this.System.ActualSystem.method_8(this.XCoord, this.YCoord,
                        this.System, WayPointType.POI, 0);
                    if (gclass214_0_2 != null)
                    {
                        this.method_217(gclass214_0_2, MoveActionType.MoveTo, this.System);
                        flag1 = true;
                        break;
                    }

                    GClass201 gclass201_7 = this.method_235(GEnum109.const_19, gclass136_0.Description, false);
                    if (gclass201_7.gclass214_0 != null)
                    {
                        this.method_217(gclass201_7.gclass214_0, MoveActionType.MoveTo, gclass201_7.gclass202_0);
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.MoveToRendezvousPoint:
                    Waypoint gclass214_0_3 = this.System.ActualSystem.method_8(this.XCoord, this.YCoord,
                        this.System, WayPointType.Rendezvous, 0);
                    if (gclass214_0_3 != null)
                    {
                        this.method_217(gclass214_0_3, MoveActionType.MoveTo, this.System);
                        flag1 = true;
                        break;
                    }

                    GClass201 gclass201_8 = this.method_235(GEnum109.const_40, gclass136_0.Description, true);
                    if (gclass201_8.gclass214_0 != null)
                    {
                        this.method_217(gclass201_8.gclass214_0, MoveActionType.MoveTo, gclass201_8.gclass202_0);
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.JoinOperationalGroup:
                    flag1 = this.method_202();
                    break;
                case AuroraStandingOrder.SurveyNextThirtySystemBodies:
                    if ((flag1 = this.method_203(30, AuroraStandingOrder.SurveyNextThirtySystemBodies)) &&
                        this.Race.NPR)
                    {
                        this.NPRSomething.bRedeployOrderGiven = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.PickupNearestLifepod:
                    LifePod gclass59_0 =
                        this.System.ActualSystem.method_9(this.XCoord, this.YCoord, this.System);
                    if (gclass59_0 != null)
                    {
                        this.method_218(gclass59_0, MoveActionType.RescueSurvivors, this.System);
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.ReplenishOverhaul:
                    PopulationData gclass146_1_8 = this.Race.method_136(this.System, this.XCoord, this.YCoord,
                        this.method_142());
                    if (gclass146_1_8 != null)
                    {
                        this.method_219(gclass146_1_8, MoveActionType.RefuelAndResupplyFromColony);
                        this.method_219(gclass146_1_8, MoveActionType.LoadOrdnanceFromColony);
                        this.method_219(gclass146_1_8, MoveActionType.BeginOverhaul);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format(
                                (string)
                                "As per standing orders {0} is moving to {1} to refuel, resupply, load ordnance and begin an overhaul",
                                (object)this.FleetName, (object)gclass146_1_8.PopName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        flag1 = true;
                        break;
                    }

                    GClass201 gclass201_9 = this.method_235(GEnum109.const_2, gclass136_0.Description, true);
                    if (gclass201_9.gclass146_0 != null)
                    {
                        this.method_219(gclass201_9.gclass146_0, MoveActionType.RefuelAndResupplyFromColony);
                        this.method_219(gclass201_9.gclass146_0, MoveActionType.LoadOrdnanceFromColony);
                        this.method_219(gclass201_9.gclass146_0, MoveActionType.BeginOverhaul);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format(
                                (string)
                                "As per standing orders {0} is moving to {1} to refuel, resupply, load ordnance and begin an overhaul",
                                (object)this.FleetName, (object)gclass201_9.gclass146_0.PopName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.SurveyNextThreeSystemBodiesOrLocations:
                    double num1 = this.XCoord;
                    double num2 = this.YCoord;
                    for (int index = 1; index <= 3; ++index)
                    {
                        SurveyLocation gclass213_0_3 = this.Race.method_135(this.System, num1, num2);
                        SystemBodyData gclass1_1_5 = this.Race.method_134(this.System, num1, num2,
                            gclass136_0.auroraStandingOrder_0, this);
                        if (gclass213_0_3 != null && gclass1_1_5 == null)
                        {
                            num1 = gclass213_0_3.XCoord;
                            num2 = gclass213_0_3.YCoord;
                            this.method_233(gclass213_0_3);
                            flag1 = true;
                            if (this.Race.NPR)
                                this.NPRSomething.bRedeployOrderGiven = true;
                        }
                        else if (gclass213_0_3 == null && gclass1_1_5 != null)
                        {
                            num1 = gclass1_1_5.XCoordinate;
                            num2 = gclass1_1_5.YCoordinate;
                            this.method_215(gclass1_1_5, MoveActionType.GeologicalSurvey);
                            flag1 = true;
                        }
                        else if (gclass213_0_3 != null && gclass1_1_5 != null)
                        {
                            if (this.gclass0_0.GetDistanceBetween(num1, num2, gclass213_0_3.XCoord, gclass213_0_3.YCoord) <
                                this.gclass0_0.GetDistanceBetween(num1, num2, gclass1_1_5.XCoordinate, gclass1_1_5.YCoordinate))
                            {
                                num1 = gclass213_0_3.XCoord;
                                num2 = gclass213_0_3.YCoord;
                                this.method_233(gclass213_0_3);
                                flag1 = true;
                                if (this.Race.NPR)
                                    this.NPRSomething.bRedeployOrderGiven = true;
                            }
                            else
                            {
                                num1 = gclass1_1_5.XCoordinate;
                                num2 = gclass1_1_5.YCoordinate;
                                this.method_215(gclass1_1_5, MoveActionType.GeologicalSurvey);
                                flag1 = true;
                            }
                        }
                    }

                    break;
                case AuroraStandingOrder.ReplenishAtColony:
                    PopulationData gclass146_1_9 =
                        this.Race.method_140(this.System, this.XCoord, this.YCoord);
                    if (gclass146_1_9 != null)
                    {
                        this.method_219(gclass146_1_9, MoveActionType.RefuelAndResupplyFromColony);
                        this.method_219(gclass146_1_9, MoveActionType.LoadOrdnanceFromColony);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format(
                                (string)
                                "As per standing orders {0} is moving to {1} to refuel, resupply and load ordnance",
                                (object)this.FleetName, (object)gclass146_1_9.PopName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        flag1 = true;
                        break;
                    }

                    GClass201 gclass201_10 = this.method_235(GEnum109.const_48, gclass136_0.Description, true);
                    if (gclass201_10.gclass146_0 != null)
                    {
                        this.method_219(gclass201_10.gclass146_0, MoveActionType.RefuelAndResupplyFromColony);
                        this.method_219(gclass201_10.gclass146_0, MoveActionType.LoadOrdnanceFromColony);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format(
                                (string)
                                "As per standing orders {0} is moving to {1} to refuel, resupply and load ordnance",
                                (object)this.FleetName, (object)gclass201_10.gclass146_0.PopName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.MoveToFleetWaypoint:
                    if (this.gclass0_0.Waypoints.Values.FirstOrDefault<Waypoint>(gclass214_0 =>
                            gclass214_0.FleetID == this.FleetID) != null)
                    {
                        Waypoint gclass214_0_4 = this.System.ActualSystem.method_8(this.XCoord, this.YCoord,
                            this.System, WayPointType.FleetWaypoint, this.FleetID);
                        if (gclass214_0_4 != null)
                        {
                            this.method_217(gclass214_0_4, MoveActionType.MoveTo, this.System);
                            flag1 = true;
                            break;
                        }

                        GClass201 gclass201_11 = this.method_235(GEnum109.const_49, gclass136_0.Description, true);
                        if (gclass201_11.gclass214_0 != null)
                        {
                            this.method_217(gclass201_11.gclass214_0, MoveActionType.MoveTo, gclass201_11.gclass202_0);
                            flag1 = true;
                            break;
                        }

                        break;
                    }

                    break;
                case AuroraStandingOrder.RefuelFromTanker:
                    FleetData gclass85_5_2 = this.Race.method_138(this.System, this.XCoord, this.YCoord);
                    if (gclass85_5_2 != null)
                    {
                        this.method_222(gclass85_5_2, MoveActionType.RefuelFromStationaryTankers);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format((string)"As per standing orders {0} is moving to {1} to refuel",
                                (object)this.FleetName, (object)gclass85_5_2.FleetName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        flag1 = true;
                        break;
                    }

                    GClass201 gclass201_12 = this.method_235(GEnum109.const_3, gclass136_0.Description, true);
                    if (gclass201_12.gclass85_0 != null)
                    {
                        this.method_222(gclass201_12.gclass85_0, MoveActionType.RefuelFromStationaryTankers);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format((string)"As per standing orders {0} is moving to {1} to refuel",
                                (object)this.FleetName, (object)gclass201_12.gclass85_0.FleetName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        flag1 = true;
                        break;
                    }

                    break;
                case AuroraStandingOrder.ReplenishFromShip:
                    FleetData gclass85_5_3 = this.Race.method_139(this.System, this.XCoord, this.YCoord);
                    if (gclass85_5_3 != null)
                    {
                        this.method_222(gclass85_5_3, MoveActionType.RefuelFromStationaryTankers);
                        this.method_222(gclass85_5_3, MoveActionType.ResupplyFromStationarySupplyShip);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format((string)"As per standing orders {0} is moving to {1} to refuel and resupply",
                                (object)this.FleetName, (object)gclass85_5_3.FleetName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        flag1 = true;
                        break;
                    }

                    GClass201 gclass201_13 = this.method_235(GEnum109.const_50, gclass136_0.Description, true);
                    if (gclass201_13.gclass85_0 != null)
                    {
                        this.method_222(gclass201_13.gclass85_0, MoveActionType.RefuelFromStationaryTankers);
                        this.method_222(gclass201_13.gclass85_0, MoveActionType.ResupplyFromStationarySupplyShip);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format((string)"As per standing orders {0} is moving to {1} to refuel and resupply",
                                (object)this.FleetName, (object)gclass201_13.gclass85_0.FleetName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        flag1 = true;
                        break;
                    }

                    break;
            }

            if (flag1)
            {
                this.genum48_0 = genum48_1;
                this.checkState_0 = CheckState.Unchecked;
            }
            else
            {
                if (dictionary.Count <= 0 || genum48_1 == GEnum48.const_0)
                    return;
                foreach (KeyValuePair<int, MoveOrder> keyValuePair in dictionary)
                    this.MoveOrderDictionary.Add(keyValuePair.Key, keyValuePair.Value);
                dictionary.Clear();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 666);
        }
    }

    public bool method_205(RacialSystemSurvey gclass202_1, double double_11, double double_12, bool bool_25)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class980 class980 = new FleetData.Class980();
        // ISSUE: reference to a compiler-generated field
        class980.gclass202_0 = gclass202_1;
        // ISSUE: reference to a compiler-generated field
        class980.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class980.double_0 = double_11;
        // ISSUE: reference to a compiler-generated field
        class980.double_1 = double_12;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            foreach (PopulationData gclass146 in this.gclass0_0.Populations.Values.Where<PopulationData>(class980.method_0)
                         .Where<PopulationData>(gclass146_0 => gclass146_0.method_28())
                         .OrderBy<PopulationData, double>(class980.method_1).ToList<PopulationData>())
            {
                gclass146.method_87();
                gclass146.method_88();
                foreach (PopInstallationDemand gclass148 in gclass146.InstallationDemands.Values
                             .Where<PopInstallationDemand>(gclass148_0 => gclass148_0.Export)
                             .OrderByDescending<PopInstallationDemand, Decimal>(gclass148_0 =>
                                 gclass148_0.Amount * gclass148_0.InstallationType.CargoPoints).ToList<PopInstallationDemand>())
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    FleetData.Class981 class981 = new FleetData.Class981();
                    // ISSUE: reference to a compiler-generated field
                    class981.gclass148_0 = gclass148;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (!(class981.gclass148_0.Amount * class981.gclass148_0.InstallationType.CargoPoints < this.int_10))
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (class980.gclass202_0.ActualSystem.dictionary_2.Count > 0 && bool_25)
                        {
                            // ISSUE: reference to a compiler-generated field
                            this.method_238(class980.gclass202_0, true, true);
                        }

                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        this.method_220(class981.gclass148_0.Population, MoveActionType.LoadInstallation,
                            class981.gclass148_0.InstallationType);
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        PopulationData gclass146_1 = this.method_209(class980.gclass202_0, class981.gclass148_0,
                            class981.gclass148_0.Population.method_87(), class981.gclass148_0.Population.method_88());
                        if (gclass146_1 == null)
                        {
                            // ISSUE: reference to a compiler-generated field
                            this.gclass148_0 = class981.gclass148_0;
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            GClass201 gclass201 = this.method_237(class980.gclass202_0, GEnum109.const_27,
                                string.Format((string)"Unload {0}", (object)class981.gclass148_0.InstallationType.Name), false, 0, false, false, false);
                            if (gclass201.gclass146_0 == null)
                            {
                                this.method_263();
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                this.method_220(gclass201.gclass146_0, MoveActionType.UnloadInstallation,
                                    class981.gclass148_0.InstallationType);
                                // ISSUE: reference to a compiler-generated field
                                Decimal num = this.int_10 / (Decimal)class981.gclass148_0.InstallationType.CargoPoints;
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class981.gclass148_0.Population
                                    .InstallationDemands[class981.gclass148_0.InstallationType.InstallationType]
                                    .Amount -= num;
                                // ISSUE: reference to a compiler-generated method
                                gclass201.gclass146_0.InstallationDemands.Values.FirstOrDefault<PopInstallationDemand>(class981.method_1)
                                    .Amount -= num;
                                return true;
                            }
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated field
                            this.method_220(gclass146_1, MoveActionType.UnloadInstallation, class981.gclass148_0.InstallationType);
                            // ISSUE: reference to a compiler-generated field
                            Decimal num = this.int_10 / (Decimal)class981.gclass148_0.InstallationType.CargoPoints;
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class981.gclass148_0.Population
                                    .InstallationDemands[class981.gclass148_0.InstallationType.InstallationType]
                                    .Amount -=
                                num;
                            // ISSUE: reference to a compiler-generated method
                            gclass146_1.InstallationDemands.Values.FirstOrDefault<PopInstallationDemand>(class981.method_0).Amount -=
                                num;
                            return true;
                        }
                    }
                    else
                        break;
                }
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 667);
            return false;
        }
    }

    public bool method_206(RacialSystemSurvey gclass202_1, double double_11, double double_12, bool bool_25)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class982 class982 = new FleetData.Class982();
        // ISSUE: reference to a compiler-generated field
        class982.gclass202_0 = gclass202_1;
        // ISSUE: reference to a compiler-generated field
        class982.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class982.double_0 = double_11;
        // ISSUE: reference to a compiler-generated field
        class982.double_1 = double_12;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            foreach (PopulationData gclass146 in this.gclass0_0.Populations.Values.Where<PopulationData>(class982.method_0)
                         .Where<PopulationData>(class982.method_1).OrderBy<PopulationData, double>(class982.method_2)
                         .ToList<PopulationData>())
            {
                gclass146.method_87();
                gclass146.method_88();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                foreach (PopTradeBalance gclass190 in gclass146.TradeBalances.Values
                             .Where<PopTradeBalance>(class982.func_0 ?? (class982.func_0 = class982.method_3))
                             .OrderByDescending<PopTradeBalance, GEnum49>(gclass190_0 => gclass190_0.TradeGood.genum49_0)
                             .ThenByDescending<PopTradeBalance, Decimal>(gclass190_0 => gclass190_0.TradeBalance)
                             .ToList<PopTradeBalance>())
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    FleetData.Class983 class983 = new FleetData.Class983();
                    // ISSUE: reference to a compiler-generated field
                    class983.gclass190_0 = gclass190;
                    // ISSUE: reference to a compiler-generated field
                    if (class983.gclass190_0.TradeGood.genum49_0 != GEnum49.const_2 ||
                        gclass146.ColonistDestinationSetting != PopColonistSetting.Destination)
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (class983.gclass190_0.TradeGood.genum49_0 == GEnum49.const_2 && gclass146.ReqInf > 0)
                        {
                            Decimal num = gclass146.method_62(AuroraProductionCategory.Infrastructure);
                            if (gclass146.ReqInf > num)
                                continue;
                        }

                        // ISSUE: reference to a compiler-generated method
                        int num1 = (int)(this.gclass0_0.FleetDictionary.Values
                            .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                            .Where<MoveOrder>(class983.method_0)
                            .SelectMany<MoveOrder, ShipData>(gclass139_0 => gclass139_0.Fleet.method_176())
                            .Sum<ShipData>(gclass40_0 => gclass40_0.method_124()) / AuroraUtils.decimal_53);
                        // ISSUE: reference to a compiler-generated field
                        if (!(class983.gclass190_0.TradeBalance - num1 < this.int_10))
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (class982.gclass202_0.ActualSystem.dictionary_2.Count > 0 && bool_25)
                            {
                                // ISSUE: reference to a compiler-generated field
                                this.method_238(class982.gclass202_0, true, true);
                            }

                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            this.method_221(class983.gclass190_0.Population, MoveActionType.LoadTradeGoods,
                                class983.gclass190_0.TradeGood.TradeGoodID);
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            PopulationData gclass146_1 = this.method_210(class982.gclass202_0, class983.gclass190_0,
                                class983.gclass190_0.Population.method_87(),
                                class983.gclass190_0.Population.method_88());
                            if (gclass146_1 == null)
                            {
                                // ISSUE: reference to a compiler-generated field
                                this.gclass190_0 = class983.gclass190_0;
                                // ISSUE: reference to a compiler-generated field
                                GClass201 gclass201 = this.method_237(class982.gclass202_0, GEnum109.const_23,
                                    "Unload Trade Goods", false, 0, false, false, false);
                                if (gclass201.gclass146_0 == null)
                                {
                                    this.method_263();
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    this.method_221(gclass201.gclass146_0, MoveActionType.UnloadTradeGoods,
                                        class983.gclass190_0.TradeGood.TradeGoodID);
                                    return true;
                                }
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                this.method_221(gclass146_1, MoveActionType.UnloadTradeGoods, class983.gclass190_0.TradeGood.TradeGoodID);
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 668);
            return false;
        }
    }

    public PopTradeBalance method_207(RacialSystemSurvey gclass202_1, double double_11, double double_12)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class984 class984 = new FleetData.Class984();
        // ISSUE: reference to a compiler-generated field
        class984.gclass202_0 = gclass202_1;
        // ISSUE: reference to a compiler-generated field
        class984.gclass85_0 = this;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            foreach (PopulationData gclass146 in this.gclass0_0.Populations.Values.Where<PopulationData>(class984.method_0)
                         .Where<PopulationData>(class984.method_1).OrderBy<PopulationData, double>(gclass146_0 =>
                             gclass146_0.gclass202_0.ActualSystem.method_3(0.0, 0.0, gclass146_0.method_87(),
                                 gclass146_0.method_88())).ToList<PopulationData>())
            {
                gclass146.method_87();
                gclass146.method_88();
                foreach (PopTradeBalance gclass190 in gclass146.TradeBalances.Values
                             .OrderByDescending<PopTradeBalance, GEnum49>(gclass190_0 => gclass190_0.TradeGood.genum49_0)
                             .ThenByDescending<PopTradeBalance, Decimal>(gclass190_0 => gclass190_0.TradeBalance)
                             .ToList<PopTradeBalance>())
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    FleetData.Class985 class985 = new FleetData.Class985();
                    // ISSUE: reference to a compiler-generated field
                    class985.gclass190_0 = gclass190;
                    // ISSUE: reference to a compiler-generated field
                    if (class985.gclass190_0.TradeBalance < this.int_10)
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (class985.gclass190_0.TradeGood.genum49_0 == GEnum49.const_0)
                            break;
                    }

                    // ISSUE: reference to a compiler-generated field
                    if (class985.gclass190_0.TradeGood.genum49_0 != GEnum49.const_2 ||
                        gclass146.ColonistDestinationSetting != PopColonistSetting.Destination)
                    {
                        // ISSUE: reference to a compiler-generated method
                        int num = (int)(this.gclass0_0.FleetDictionary.Values
                            .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                            .Where<MoveOrder>(class985.method_0)
                            .SelectMany<MoveOrder, ShipData>(gclass139_0 => gclass139_0.Fleet.method_176())
                            .Sum<ShipData>(gclass40_0 => gclass40_0.method_124()) / AuroraUtils.decimal_53);
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (!(class985.gclass190_0.TradeBalance - num < this.int_10) ||
                            class985.gclass190_0.TradeGood.genum49_0 != GEnum49.const_0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            return class985.gclass190_0;
                        }
                    }
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 669);
            return null;
        }
    }

    public PopInstallationDemand method_208(RacialSystemSurvey gclass202_1, double double_11, double double_12)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class986 class986 = new FleetData.Class986();
        // ISSUE: reference to a compiler-generated field
        class986.gclass202_0 = gclass202_1;
        // ISSUE: reference to a compiler-generated field
        class986.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class986.double_0 = double_11;
        // ISSUE: reference to a compiler-generated field
        class986.double_1 = double_12;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            foreach (PopulationData gclass146 in this.gclass0_0.Populations.Values.Where<PopulationData>(class986.method_0)
                         .Where<PopulationData>(gclass146_0 => gclass146_0.method_28())
                         .OrderBy<PopulationData, double>(class986.method_1).ToList<PopulationData>())
            {
                gclass146.method_87();
                gclass146.method_88();
                using (List<PopInstallationDemand>.Enumerator enumerator = gclass146.InstallationDemands.Values
                           .Where<PopInstallationDemand>(gclass148_0 => gclass148_0.Export)
                           .OrderByDescending<PopInstallationDemand, Decimal>(gclass148_0 =>
                               gclass148_0.Amount * gclass148_0.InstallationType.CargoPoints).ToList<PopInstallationDemand>()
                           .GetEnumerator())
                {
                    if (enumerator.MoveNext())
                    {
                        PopInstallationDemand current = enumerator.Current;
                        if (!(current.Amount * current.InstallationType.CargoPoints < this.int_10))
                            return current;
                    }
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 670);
            return null;
        }
    }

    public PopulationData method_209(
        RacialSystemSurvey gclass202_1,
        PopInstallationDemand gclass148_1,
        double double_11,
        double double_12)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class987 class987 = new FleetData.Class987();
        // ISSUE: reference to a compiler-generated field
        class987.gclass202_0 = gclass202_1;
        // ISSUE: reference to a compiler-generated field
        class987.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class987.gclass148_0 = gclass148_1;
        // ISSUE: reference to a compiler-generated field
        class987.double_0 = double_11;
        // ISSUE: reference to a compiler-generated field
        class987.double_1 = double_12;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            foreach (PopulationData gclass146 in this.gclass0_0.Populations.Values.Where<PopulationData>(class987.method_0)
                         .Where<PopulationData>(class987.method_1).Where<PopulationData>(class987.method_2)
                         .OrderBy<PopulationData, double>(class987.method_3).ToList<PopulationData>())
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                Decimal num = class987.gclass148_0.Amount * class987.gclass148_0.InstallationType.CargoPoints;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (!(gclass146.InstallationDemands[class987.gclass148_0.InstallationType.InstallationType].Amount *
                        class987.gclass148_0.InstallationType.CargoPoints < this.int_10))
                    return gclass146;
            }

            return null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 671);
            return null;
        }
    }

    public PopulationData method_210(
        RacialSystemSurvey gclass202_1,
        PopTradeBalance gclass190_1,
        double double_11,
        double double_12)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class988 class988 = new FleetData.Class988();
        // ISSUE: reference to a compiler-generated field
        class988.gclass202_0 = gclass202_1;
        // ISSUE: reference to a compiler-generated field
        class988.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class988.gclass190_0 = gclass190_1;
        // ISSUE: reference to a compiler-generated field
        class988.double_0 = double_11;
        // ISSUE: reference to a compiler-generated field
        class988.double_1 = double_12;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            FleetData.Class989 class989 = new FleetData.Class989();
            // ISSUE: reference to a compiler-generated field
            class989.class988_0 = class988;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class989.class988_0.gclass190_0.TradeGood.genum49_0 == GEnum49.const_2)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                return this.method_211(class989.class988_0.gclass202_0, class989.class988_0.gclass190_0,
                    class989.class988_0.double_0, class989.class988_0.double_1);
            }

            // ISSUE: reference to a compiler-generated field
            class989.int_0 = -this.int_10;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            foreach (PopulationData gclass146 in this.gclass0_0.Populations.Values
                         .Where<PopulationData>(class989.class988_0.method_0).Where<PopulationData>(class989.class988_0.method_1)
                         .Where<PopulationData>(class989.method_0).OrderBy<PopulationData, double>(class989.class988_0.method_2)
                         .ToList<PopulationData>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class990 class990 = new FleetData.Class990();
                // ISSUE: reference to a compiler-generated field
                class990.class989_0 = class989;
                // ISSUE: reference to a compiler-generated field
                class990.gclass146_0 = gclass146;
                // ISSUE: reference to a compiler-generated method
                int num = (int)(this.gclass0_0.FleetDictionary.Values
                    .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                    .Where<MoveOrder>(class990.method_0)
                    .SelectMany<MoveOrder, ShipData>(gclass139_0 => gclass139_0.Fleet.method_176())
                    .Sum<ShipData>(gclass40_0 => gclass40_0.method_124()) / AuroraUtils.decimal_53);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (!(class990.gclass146_0.TradeBalances[class990.class989_0.class988_0.gclass190_0.TradeGood.TradeGoodID]
                        .TradeBalance + num > class990.class989_0.int_0))
                {
                    // ISSUE: reference to a compiler-generated field
                    return class990.gclass146_0;
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 672);
            return null;
        }
    }

    public PopulationData method_211(
        RacialSystemSurvey gclass202_1,
        PopTradeBalance gclass190_1,
        double double_11,
        double double_12)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class991 class991 = new FleetData.Class991();
        // ISSUE: reference to a compiler-generated field
        class991.gclass202_0 = gclass202_1;
        // ISSUE: reference to a compiler-generated field
        class991.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class991.double_0 = double_11;
        // ISSUE: reference to a compiler-generated field
        class991.double_1 = double_12;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            foreach (PopulationData gclass146 in this.gclass0_0.Populations.Values.Where<PopulationData>(class991.method_0)
                         .Where<PopulationData>(class991.method_1).OrderBy<PopulationData, double>(class991.method_2)
                         .ToList<PopulationData>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class992 class992 = new FleetData.Class992();
                // ISSUE: reference to a compiler-generated field
                class992.gclass146_0 = gclass146;
                // ISSUE: reference to a compiler-generated field
                if (gclass190_1.Population.method_40() == class992.gclass146_0.method_40())
                {
                    // ISSUE: reference to a compiler-generated field
                    Decimal num1 = class992.gclass146_0.method_62(AuroraProductionCategory.Infrastructure);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    Decimal num2 = class992.gclass146_0.ColonistDestinationSetting != PopColonistSetting.Destination
                        ? class992.gclass146_0.ReqInf - num1
                        : class992.gclass146_0.ReqInf * AuroraUtils.decimal_56 - num1;
                    if (!(num2 < 0M))
                    {
                        // ISSUE: reference to a compiler-generated method
                        int num3 = (int)(this.gclass0_0.FleetDictionary.Values
                            .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                            .Where<MoveOrder>(class992.method_0)
                            .SelectMany<MoveOrder, ShipData>(gclass139_0 => gclass139_0.Fleet.method_176())
                            .Sum<ShipData>(gclass40_0 => gclass40_0.method_124()) / AuroraUtils.decimal_53);
                        if (!(num2 - num3 < this.int_10))
                        {
                            // ISSUE: reference to a compiler-generated field
                            return class992.gclass146_0;
                        }
                    }
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 673);
            return null;
        }
    }

    public bool method_212(StandingOrderDefinition gclass136_0)
    {
        try
        {
            if (this.method_125(AuroraComponentType.JumpPointStabilisation) == 0M)
                return false;
            JumpPoint gclass120_1_1 = this.gclass0_0.JumpPointDictionary.Values.FirstOrDefault<JumpPoint>(
                gclass120_1 => gclass120_1.XCoord == this.XCoord && gclass120_1.YCoord == this.YCoord &&
                               gclass120_1.SystemData == this.System.ActualSystem);
            if (gclass120_1_1 != null)
            {
                if (gclass120_1_1.method_3(this.Race))
                {
                    this.method_263();
                    this.method_231(gclass120_1_1, MoveActionType.StabilizeJumpPoint, this.System);
                    this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                        string.Format((string)"As per standing orders {0} is moving to {1} to stabilise a jump point",
                            (object)this.FleetName, (object)gclass120_1_1.method_7(this.System)),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
                    return true;
                }

                if (gclass120_1_1.LinkedJumpPoint != null && gclass120_1_1.LinkedJumpPoint.method_4(this.Race) &&
                    !this.Race.RacialSystemDictionary[gclass120_1_1.LinkedJumpPoint.SystemData.SystemID].method_20())
                {
                    bool flag = true;
                    if (this.bAvoidAlienSystem && !this.Race.NPR)
                        flag = this.Race.RacialSystemDictionary[gclass120_1_1.LinkedJumpPoint.SystemData.SystemID]
                            .method_21();
                    if (flag && this.System.method_12(this, GEnum98.const_1))
                    {
                        this.method_263();
                        this.method_231(gclass120_1_1, MoveActionType.StandardTransit, this.System);
                        this.method_231(gclass120_1_1.LinkedJumpPoint, MoveActionType.StabilizeJumpPoint,
                            this.Race.RacialSystemDictionary[gclass120_1_1.LinkedJumpPoint.SystemData.SystemID]);
                        this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                            string.Format(
                                (string)"As per standing orders {0} is moving to {1} to stabilise a jump point",
                                (object)this.FleetName, (object)gclass120_1_1.LinkedJumpPoint.method_7(this.System)),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        return true;
                    }
                }
            }

            JumpPoint gclass120_1_2 = this.Race.method_146(this.System, this.XCoord, this.YCoord);
            if (gclass120_1_2 != null)
            {
                this.method_231(gclass120_1_2, MoveActionType.StabilizeJumpPoint, this.System);
                this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                    string.Format((string)"As per standing orders {0} is moving to {1} to stabilise a jump point",
                        (object)this.FleetName, (object)gclass120_1_2.method_7(this.System)),
                    this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                    AuroraEventCategory.Fleet);
                return true;
            }

            GClass201 gclass201 = this.method_235(GEnum109.const_13, gclass136_0.Description, true);
            if (gclass201.gclass120_0 == null)
                return false;
            this.method_231(gclass201.gclass120_0, MoveActionType.StabilizeJumpPoint, gclass201.gclass202_0);
            this.gclass0_0.gclass92_0.method_2(EventType.const_23,
                string.Format((string)"As per standing orders {0} is moving to {1} to stabliise a jump point",
                    (object)this.FleetName, (object)gclass201.gclass120_0.method_7(this.System)),
                this.Race, this.System.ActualSystem, this.XCoord, this.YCoord, AuroraEventCategory.Fleet);
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 674);
            return false;
        }
    }

    public FleetData method_213()
    {
        try
        {
            List<ShipData> list = this.method_176()
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass40_1 != null)
                .Select<ShipData, ShipData>(gclass40_0 => gclass40_0.gclass40_1)
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0.System == this.System)
                .Distinct<ShipData>().ToList<ShipData>();
            return list.Count != 1 ? null : list[0].gclass85_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 675);
            return null;
        }
    }

    public bool method_214(StandingOrderDefinition gclass136_0, GEnum109 genum109_0)
    {
        try
        {
            PopulationData gclass146_1 = null;
            if (gclass136_0.auroraStandingOrder_0 == AuroraStandingOrder.UnloadColonists)
                gclass146_1 =
                    this.Race.method_151(this.System, this.XCoord, this.YCoord, this, genum109_0);
            if (gclass146_1 != null)
            {
                this.method_219(gclass146_1, MoveActionType.UnloadColonists);
                return true;
            }

            GClass201 gclass201 = this.method_235(genum109_0, gclass136_0.Description, false);
            if (gclass201.gclass146_0 != null)
                this.method_219(gclass201.gclass146_0, MoveActionType.UnloadColonists);
            return gclass201.bool_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 676);
            return false;
        }
    }

    public void method_215(SystemBodyData gclass1_1, MoveActionType genum123_0)
    {
        try
        {
            this.method_264(this.method_272(gclass1_1, this.System), this.gclass0_0.MoveActionDictionary[genum123_0],
                null, 0M, 0.0, 0, 0, 0, false, CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 677);
        }
    }

    public void method_216(Wreck gclass233_0, MoveActionType genum123_0, RacialSystemSurvey gclass202_1)
    {
        try
        {
            this.method_264(this.method_275(gclass233_0, gclass202_1), this.gclass0_0.MoveActionDictionary[genum123_0], null,
                0M, 0.0, 0, 0, 0, false, CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 678);
        }
    }

    public void method_217(Waypoint gclass214_0, MoveActionType genum123_0, RacialSystemSurvey gclass202_1)
    {
        try
        {
            this.method_264(this.method_276(gclass214_0, gclass202_1), this.gclass0_0.MoveActionDictionary[genum123_0], null,
                0M, 0.0, 0, 0, 0, false, CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 679);
        }
    }

    public void method_218(LifePod gclass59_0, MoveActionType genum123_0, RacialSystemSurvey gclass202_1)
    {
        try
        {
            this.method_264(this.method_277(gclass59_0, gclass202_1), this.gclass0_0.MoveActionDictionary[genum123_0], null,
                0M, 0.0, 0, 0, 0, false, CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 680);
        }
    }

    public void method_219(PopulationData gclass146_1, MoveActionType genum123_0)
    {
        try
        {
            this.method_264(this.method_274(gclass146_1), this.gclass0_0.MoveActionDictionary[genum123_0], null, 0M, 0.0, 0, 0,
                0, false, CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 681);
        }
    }

    public void method_220(PopulationData gclass146_1, MoveActionType genum123_0, PlanetaryInstallationType gclass157_0)
    {
        try
        {
            this.method_264(this.method_274(gclass146_1), this.gclass0_0.MoveActionDictionary[genum123_0], gclass157_0, 0M,
                0.0, 0, 0, 0, false, CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 682);
        }
    }

    public void method_221(PopulationData gclass146_1, MoveActionType genum123_0, int int_12)
    {
        try
        {
            this.method_264(this.method_274(gclass146_1), this.gclass0_0.MoveActionDictionary[genum123_0], int_12, 0M, 0.0, 0,
                0, 0, false, CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 683);
        }
    }

    public void method_222(FleetData gclass85_5, MoveActionType genum123_0)
    {
        try
        {
            this.method_264(this.method_278(gclass85_5), this.gclass0_0.MoveActionDictionary[genum123_0], null, 0M, 0.0, 0, 0,
                0, false, CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 684);
        }
    }

    public void method_223(FleetData gclass85_5, MoveActionType genum123_0, object object_0)
    {
        try
        {
            this.method_264(this.method_278(gclass85_5), this.gclass0_0.MoveActionDictionary[genum123_0], object_0, 0M, 0.0, 0,
                0, 0, false, CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 685);
        }
    }

    public void method_224(Contact gclass65_1, double double_11)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class993 class993 = new FleetData.Class993();
        // ISSUE: reference to a compiler-generated field
        class993.gclass65_0 = gclass65_1;
        try
        {
            // ISSUE: reference to a compiler-generated method
            this.method_264(
                this.method_279(
                    this.gclass0_0.Ships.Values.FirstOrDefault<ShipData>(class993.method_0),
                    this.System), this.gclass0_0.MoveActionDictionary[MoveActionType.FollowTarget], null, 0M, double_11, 0, 0, 0,
                false, CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 686);
        }
    }

    public void method_225(AlienShipIntel gclass117_1, double double_11)
    {
        try
        {
            this.method_264(this.method_279(gclass117_1.gclass40_0, this.System),
                this.gclass0_0.MoveActionDictionary[MoveActionType.FollowTarget], null, 0M, double_11, 0, 0, 0, false,
                CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 687);
        }
    }

    public void method_226(ShipData gclass40_0, double double_11)
    {
        try
        {
            this.method_264(this.method_279(gclass40_0, this.System),
                this.gclass0_0.MoveActionDictionary[MoveActionType.FollowTarget], null, 0M, double_11, 0, 0, 0, false,
                CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 688);
        }
    }

    public void method_227(Contact gclass65_1)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class994 class994 = new FleetData.Class994();
        // ISSUE: reference to a compiler-generated field
        class994.gclass65_0 = gclass65_1;
        try
        {
            // ISSUE: reference to a compiler-generated method
            this.method_264(
                this.method_279(
                    this.gclass0_0.Ships.Values.FirstOrDefault<ShipData>(class994.method_0),
                    this.System), this.gclass0_0.MoveActionDictionary[MoveActionType.RamTargetShip], null, 0M, 0.0, 0, 0, 0, false,
                CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 689);
        }
    }

    public void method_228(ShipData gclass40_0)
    {
        try
        {
            this.method_264(this.method_279(gclass40_0, this.System),
                this.gclass0_0.MoveActionDictionary[MoveActionType.RamTargetShip], null, 0M, 0.0, 0, 0, 0, false, CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 690);
        }
    }

    public void method_229(FleetData gclass85_5)
    {
        try
        {
            this.method_264(this.method_278(gclass85_5), this.gclass0_0.MoveActionDictionary[MoveActionType.RamTargetShip], null, 0M,
                0.0, 0, 0, 0, false, CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 691);
        }
    }

    public void method_230(AlienShipIntel gclass117_1)
    {
        try
        {
            this.method_264(this.method_279(gclass117_1.gclass40_0, this.System),
                this.gclass0_0.MoveActionDictionary[MoveActionType.AttemptBoardingActionAllFormations], null, 0M, 0.0, 0, 0, 0, false, CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 692);
        }
    }

    public void method_231(JumpPoint gclass120_1, MoveActionType genum123_0, RacialSystemSurvey gclass202_1)
    {
        try
        {
            this.method_264(this.method_270(gclass120_1, gclass202_1), this.gclass0_0.MoveActionDictionary[genum123_0], null,
                0M, 0.0, 0, 0, 0, false, CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 693);
        }
    }

    public void method_232(AetherGate gclass210_0, MoveActionType genum123_0, RacialSystemSurvey gclass202_1)
    {
        try
        {
            this.method_264(this.method_271(gclass210_0, this.System), this.gclass0_0.MoveActionDictionary[genum123_0],
                null, 0M, 0.0, 0, 0, 0, false, CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 693);
        }
    }

    public void method_233(SurveyLocation gclass213_0)
    {
        try
        {
            this.method_264(this.method_273(gclass213_0, this.System),
                this.gclass0_0.MoveActionDictionary[MoveActionType.GravitationalSurvey], null, 0M, 0.0, 0, 0, 0, false, CheckState.Checked);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 694);
        }
    }

    public GClass201 method_234(GEnum109 genum109_0)
    {
        try
        {
            return this.method_237(this.System, genum109_0, "", false, 0, false, true, false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 695);
            return null;
        }
    }

    public GClass201 method_235(GEnum109 genum109_0, string string_1, bool bool_25)
    {
        try
        {
            return this.method_237(this.System, genum109_0, string_1, false, 0, bool_25, true, false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 695);
            return null;
        }
    }

    public GClass201 method_236(
        GEnum109 genum109_0,
        string string_1,
        bool bool_25,
        int int_12,
        bool bool_26)
    {
        try
        {
            return this.method_237(this.System, genum109_0, string_1, bool_25, int_12, bool_26, true, false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 696);
            return null;
        }
    }

    public GClass201 method_237(
        RacialSystemSurvey gclass202_1,
        GEnum109 genum109_0,
        string string_1,
        bool bool_25,
        int int_12,
        bool bool_26,
        bool bool_27,
        bool bool_28)
    {
        try
        {
            GClass201 gclass201 = this.method_240(gclass202_1, genum109_0, bool_25, int_12, bool_28);
            if (gclass201.gclass202_0 != null)
                this.method_238(gclass201.gclass202_0, bool_27, false);
            else if (bool_26 && !this.Race.NPR)
                this.gclass0_0.gclass92_0.method_2(EventType.const_24,
                    string.Format(
                        (string)
                        "{0} is unable to carry out its standing order ({1}) as there is no suitable destination",
                        (object)this.FleetName, (object)string_1),
                    this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                    AuroraEventCategory.Fleet);
            return gclass201;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 697);
            return null;
        }
    }

    public void method_238(RacialSystemSurvey gclass202_1, bool bool_25, bool bool_26)
    {
        try
        {
            if (bool_25)
                this.method_263();
            List<JumpPoint> gclass120List = !bool_26
                ? gclass202_1.ActualSystem.dictionary_1
                    .OrderBy<KeyValuePair<int, JumpPoint>, int>(keyValuePair_0 => keyValuePair_0.Key)
                    .Select<KeyValuePair<int, JumpPoint>, JumpPoint>(keyValuePair_0 => keyValuePair_0.Value)
                    .ToList<JumpPoint>()
                : gclass202_1.ActualSystem.dictionary_2
                    .OrderBy<KeyValuePair<int, JumpPoint>, int>(keyValuePair_0 => keyValuePair_0.Key)
                    .Select<KeyValuePair<int, JumpPoint>, JumpPoint>(keyValuePair_0 => keyValuePair_0.Value)
                    .ToList<JumpPoint>();
            RacialSystemSurvey gclass202_1_1 = this.method_261();
            foreach (JumpPoint gclass120 in gclass120List)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class995 class995 = new FleetData.Class995();
                // ISSUE: reference to a compiler-generated field
                class995.gclass120_0 = gclass120;
                // ISSUE: reference to a compiler-generated field
                GClass134 gclass134_0 = this.method_270(class995.gclass120_0, gclass202_1_1);
                MoveActionDefinition gclass133_0 = this.gclass0_0.MoveActionDictionary[MoveActionType.StandardTransit];
                // ISSUE: reference to a compiler-generated method
                gclass202_1_1 = this.Race.RacialSystemDictionary.Values.FirstOrDefault<RacialSystemSurvey>(class995.method_0);
                this.method_264(gclass134_0, gclass133_0, null, 0M, 0.0, 0, 0, 0, false, CheckState.Checked);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 698);
        }
    }

    public bool method_239(bool bool_25)
    {
        try
        {
            GClass201 gclass201 = new GClass201();
            foreach (StarSystem gclass200 in this.gclass0_0.StarSystemDictionary.Values)
                gclass200.dictionary_2.Clear();
            Dictionary<int, RacialSystemSurvey> dictionary = new Dictionary<int, RacialSystemSurvey>();
            List<RacialSystemSurvey> gclass202List1 = new List<RacialSystemSurvey>();
            List<RacialSystemSurvey> gclass202List2 = new List<RacialSystemSurvey>();
            dictionary.Add(this.System.ActualSystem.SystemID, this.System);
            gclass202List1.Add(this.System);
            while (true)
            {
                foreach (RacialSystemSurvey gclass202_1 in gclass202List1)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    FleetData.Class996 class996 = new FleetData.Class996();
                    // ISSUE: reference to a compiler-generated field
                    class996.gclass202_0 = gclass202_1;
                    // ISSUE: reference to a compiler-generated field
                    List<RacialSystemSurvey> list1 = class996.gclass202_0.method_37(false).Except<RacialSystemSurvey>(dictionary.Values)
                        .ToList<RacialSystemSurvey>();
                    if (list1.Count != 0)
                    {
                        List<RacialSystemSurvey> list2 = list1.Where<RacialSystemSurvey>(gclass202_0 =>
                                !gclass202_0.method_20() && !gclass202_0.method_21() && !gclass202_0.bMilitaryRestrictedSystem)
                            .ToList<RacialSystemSurvey>();
                        // ISSUE: reference to a compiler-generated field
                        foreach (RacialSystemSurvey gclass202_2 in class996.gclass202_0.method_0(list2))
                        {
                            // ISSUE: object of a compiler-generated type is created
                            // ISSUE: variable of a compiler-generated type
                            FleetData.Class997 class997 = new FleetData.Class997();
                            // ISSUE: reference to a compiler-generated field
                            class997.gclass202_0 = gclass202_2;
                            // ISSUE: reference to a compiler-generated field
                            if (!gclass202List2.Contains(class997.gclass202_0))
                            {
                                // ISSUE: reference to a compiler-generated field
                                foreach (KeyValuePair<int, JumpPoint> keyValuePair in class996.gclass202_0
                                             .ActualSystem.dictionary_2)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    class997.gclass202_0.ActualSystem.dictionary_2.Add(keyValuePair.Key,
                                        keyValuePair.Value);
                                }

                                // ISSUE: reference to a compiler-generated field
                                int key = class996.gclass202_0.ActualSystem.dictionary_2.Count + 1;
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                JumpPoint gclass120 = this.gclass0_0.JumpPointDictionary.Values
                                    .Where<JumpPoint>(class996.func_0 ?? (class996.func_0 = class996.method_0))
                                    .FirstOrDefault<JumpPoint>(class997.method_0);
                                // ISSUE: reference to a compiler-generated field
                                class997.gclass202_0.ActualSystem.dictionary_2.Add(key, gclass120);
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (!bool_25
                                        ? this.method_206(class997.gclass202_0, gclass120.XCoord, gclass120.YCoord,
                                            true)
                                        : this.method_205(class997.gclass202_0, gclass120.XCoord, gclass120.YCoord,
                                            true))
                                    return true;
                                // ISSUE: reference to a compiler-generated field
                                gclass202List2.Add(class997.gclass202_0);
                            }
                        }
                    }
                }

                if (gclass202List2.Count != 0)
                {
                    gclass202List1.Clear();
                    foreach (RacialSystemSurvey gclass202 in gclass202List2)
                    {
                        gclass202List1.Add(gclass202);
                        dictionary.Add(gclass202.ActualSystem.SystemID, gclass202);
                    }

                    gclass202List2.Clear();
                }
                else
                    break;
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 699);
            return false;
        }
    }

    /// <summary>
    /// Need to identify what this does; very slow, long execution time
    /// </summary>
    /// <param name="gclass202_1_1"></param>
    /// <param name="genum109_0"></param>
    /// <param name="bool_25"></param>
    /// <param name="int_12"></param>
    /// <param name="bool_26"></param>
    /// <returns></returns>
    public GClass201 method_240(
        RacialSystemSurvey gclass202_1_1,
        GEnum109 genum109_0,
        bool bool_25,
        int int_12,
        bool bool_26)
    {
        try
        {
            bool bool_11;
            if (!(bool_11 = bool_25))
                bool_11 = this.method_241();
            GClass201 gclass201 = new GClass201();
            foreach (StarSystem gclass200 in this.gclass0_0.StarSystemDictionary.Values)
                gclass200.dictionary_1.Clear();
            Dictionary<int, RacialSystemSurvey> dictionary = new Dictionary<int, RacialSystemSurvey>();
            List<RacialSystemSurvey> gclass202List1 = new List<RacialSystemSurvey>();
            List<RacialSystemSurvey> gclass202List2 = new List<RacialSystemSurvey>();
            dictionary.Add(gclass202_1_1.ActualSystem.SystemID, gclass202_1_1);
            gclass202List1.Add(gclass202_1_1);
            while (true)
            {
                foreach (RacialSystemSurvey gclass202_1 in gclass202List1)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    FleetData.Class998 class998 = new FleetData.Class998();
                    // ISSUE: reference to a compiler-generated field
                    class998.gclass202_0 = gclass202_1;
                    // ISSUE: reference to a compiler-generated field
                    List<RacialSystemSurvey> source = class998.gclass202_0.method_36(bool_11, bool_26)
                        .Except<RacialSystemSurvey>(dictionary.Values).ToList<RacialSystemSurvey>();
                    if (source.Count != 0)
                    {
                        if (this.bAvoidDanger)
                            source = source.Where<RacialSystemSurvey>(gclass202_0 => !gclass202_0.method_20())
                                .ToList<RacialSystemSurvey>();
                        if (this.bAvoidAlienSystem && !this.Race.NPR)
                            source = source.Where<RacialSystemSurvey>(gclass202_0 => !gclass202_0.method_21())
                                .ToList<RacialSystemSurvey>();
                        if (this.ShippingLine != null)
                        {
                            List<RacialSystemSurvey> list = source.Where<RacialSystemSurvey>(gclass202_0 => !gclass202_0.bMilitaryRestrictedSystem)
                                .ToList<RacialSystemSurvey>();
                            // ISSUE: reference to a compiler-generated field
                            source = class998.gclass202_0.method_0(list);
                        }

                        if (this.Race.NPR)
                            source = source
                                .Where<RacialSystemSurvey>(gclass202_1_2 => gclass202_1_2.method_12(this, GEnum98.const_0))
                                .ToList<RacialSystemSurvey>();
                        foreach (RacialSystemSurvey gclass202_2 in source)
                        {
                            // ISSUE: object of a compiler-generated type is created
                            // ISSUE: variable of a compiler-generated type
                            FleetData.Class999 class999 = new FleetData.Class999();
                            // ISSUE: reference to a compiler-generated field
                            class999.gclass202_0 = gclass202_2;
                            // ISSUE: reference to a compiler-generated field
                            if (!gclass202List2.Contains(class999.gclass202_0))
                            {
                                // ISSUE: reference to a compiler-generated field
                                foreach (KeyValuePair<int, JumpPoint> keyValuePair in class998.gclass202_0
                                             .ActualSystem.dictionary_1)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    class999.gclass202_0.ActualSystem.dictionary_1.Add(keyValuePair.Key,
                                        keyValuePair.Value);
                                }

                                // ISSUE: reference to a compiler-generated field
                                int key = class998.gclass202_0.ActualSystem.dictionary_1.Count + 1;
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                JumpPoint gclass120 = this.gclass0_0.JumpPointDictionary.Values
                                    .Where<JumpPoint>(class998.func_0 ?? (class998.func_0 = class998.method_0))
                                    .FirstOrDefault<JumpPoint>(class999.method_0);
                                // ISSUE: reference to a compiler-generated field
                                class999.gclass202_0.ActualSystem.dictionary_1.Add(key, gclass120);
                                // ISSUE: reference to a compiler-generated field
                                if (genum109_0 != GEnum109.const_41 ||
                                    class999.gclass202_0.ActualSystem.SystemID != int_12)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    gclass201 = class999.gclass202_0.method_17(genum109_0, this);
                                    if (!gclass201.bool_0)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        gclass202List2.Add(class999.gclass202_0);
                                    }
                                    else
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        gclass201.gclass202_0 = class999.gclass202_0;
                                        return gclass201;
                                    }
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    gclass201.gclass202_0 = class999.gclass202_0;
                                    return gclass201;
                                }
                            }
                        }
                    }
                }

                if (gclass202List2.Count != 0)
                {
                    gclass202List1.Clear();
                    foreach (RacialSystemSurvey gclass202 in gclass202List2)
                    {
                        gclass202List1.Add(gclass202);
                        dictionary.Add(gclass202.ActualSystem.SystemID, gclass202);
                    }

                    gclass202List2.Clear();
                }
                else
                    break;
            }

            return gclass201;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 700);
            return null;
        }
    }

    public bool method_241()
    {
        try
        {
            List<ShipData> list1 = this.gclass0_0.Ships.Values.Where<ShipData>(gclass40_0 =>
                    gclass40_0.gclass85_0 == this && gclass40_0.Class.MilitaryEngines && gclass40_0.gclass40_0 == null)
                .ToList<ShipData>();
            List<ShipData> list2 = this.gclass0_0.Ships.Values.Where<ShipData>(gclass40_0 =>
                    gclass40_0.gclass85_0 == this && !gclass40_0.Class.MilitaryEngines && gclass40_0.gclass40_0 == null)
                .ToList<ShipData>();
            if (list1.Count == 0 && list2.Count == 0)
                return false;
            bool flag1 = list1.Count == 0 || this.method_245(list1, null, false);
            bool flag2 = list2.Count == 0 || this.method_245(list2, null, true);
            return (flag1 || list1.Count <= 0) && (flag2 || list2.Count <= 0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 701);
            return false;
        }
    }

    public void method_242(MoveOrder gclass139_0)
    {
        try
        {
            this.AssignedPopulation = gclass139_0.Population;
            if (gclass139_0.DestinationType != DestinationType.const_1 && gclass139_0.DestinationType != DestinationType.const_10)
            {
                if (gclass139_0.DestinationType != DestinationType.const_7)
                    return;
                this.OrbitingBody = this.gclass0_0.FleetDictionary[gclass139_0.DestinationID].OrbitingBody;
            }
            else
                this.OrbitingBody = this.gclass0_0.SystemBodyRecordDic[gclass139_0.DestinationID];
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 702);
        }
    }

    public void method_243(MoveActionType genum123_0)
    {
        try
        {
            foreach (ShipData gclass40 in this.method_176())
            {
                Decimal num = 2M - gclass40.method_190();
                gclass40.int_13 = genum123_0 == MoveActionType.SquadronTransit || genum123_0 == MoveActionType.TransitBySubFleet
                    ? (int)((AuroraUtils.int_31 + AuroraUtils.GetRandomInteger(20)) * num)
                    : (int)((AuroraUtils.int_30 + AuroraUtils.GetRandomInteger(60)) * num);
                if (gclass40.Race.NPR && genum123_0 == MoveActionType.StandardTransit)
                    gclass40.int_13 /= 2;
                gclass40.bool_17 = true;
                gclass40.int_15 = gclass40.int_13;
                gclass40.decimal_12 = this.gclass0_0.GameTime;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 703);
        }
    }

    public int method_244(List<ShipData> list_4)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            FleetData.Class1000 class1000 = new FleetData.Class1000();
            // ISSUE: reference to a compiler-generated field
            class1000.bool_0 = true;
            foreach (ShipData gclass40 in list_4)
            {
                if (gclass40.Class.MilitaryEngines)
                {
                    // ISSUE: reference to a compiler-generated field
                    class1000.bool_0 = false;
                }
            }

            // ISSUE: reference to a compiler-generated field
            class1000.decimal_0 = list_4.Select<ShipData, Decimal>(gclass40_0 => gclass40_0.Class.Size)
                .OrderByDescending<Decimal, Decimal>(decimal_0 => decimal_0).FirstOrDefault<Decimal>();
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            ShipComponent gclass230 = list_4.Where<ShipData>(class1000.method_0)
                .Select<ShipData, ShipComponent>(class1000.method_1).Where<ShipComponent>(class1000.method_2)
                .OrderByDescending<ShipComponent, int>(gclass230_0 => gclass230_0.int_10).FirstOrDefault<ShipComponent>();
            return gclass230 != null && gclass230.int_10 >= list_4.Count ? gclass230.int_9 : 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 704);
            return 0;
        }
    }

    public bool method_245(List<ShipData> list_4, JumpPoint gclass120_1, bool bool_25)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class1001 class1001 = new FleetData.Class1001();
        // ISSUE: reference to a compiler-generated field
        class1001.bool_0 = bool_25;
        // ISSUE: reference to a compiler-generated field
        class1001.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1001.gclass120_0 = gclass120_1;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            FleetData.Class1002 class1002 = new FleetData.Class1002();
            // ISSUE: reference to a compiler-generated field
            class1002.class1001_0 = class1001;
            Decimal num = list_4.Select<ShipData, Decimal>(gclass40_0 => gclass40_0.Class.Size)
                .OrderByDescending<Decimal, Decimal>(decimal_0 => decimal_0).FirstOrDefault<Decimal>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            ShipComponent gclass230_1 = list_4.Where<ShipData>(class1002.class1001_0.method_0)
                .Select<ShipData, ShipComponent>(class1002.class1001_0.method_1)
                .OrderByDescending<ShipComponent, Decimal>(gclass230_0 => gclass230_0.decimal_3)
                .FirstOrDefault<ShipComponent>();
            if (gclass230_1 != null && gclass230_1.decimal_3 >= num)
                return true;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class1002.class1001_0.gclass120_0 == null)
                return false;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            ShipComponent gclass230_2 = this.method_176().Where<ShipData>(class1002.class1001_0.method_2)
                .Select<ShipData, ShipComponent>(class1002.class1001_0.method_3)
                .OrderByDescending<ShipComponent, Decimal>(gclass230_0 => gclass230_0.decimal_3)
                .FirstOrDefault<ShipComponent>();
            if (gclass230_2 != null && gclass230_2.decimal_3 >= num)
                return true;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            ShipComponent gclass230_3 = this.gclass0_0.Ships.Values
                .Where<ShipData>(class1002.class1001_0.method_4)
                .Where<ShipData>(class1002.class1001_0.method_5)
                .Select<ShipData, ShipComponent>(class1002.class1001_0.method_6)
                .OrderByDescending<ShipComponent, Decimal>(gclass230_0 => gclass230_0.decimal_3)
                .FirstOrDefault<ShipComponent>();
            if (gclass230_3 != null && gclass230_3.decimal_3 >= num)
                return true;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class1002.gclass221_0 = class1002.class1001_0.gclass120_0.method_10(this.Race);
            // ISSUE: reference to a compiler-generated field
            if (class1002.gclass221_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                ShipComponent gclass230_4 = this.gclass0_0.Ships.Values
                    .Where<ShipData>(class1002.class1001_0.method_7).Where<ShipData>(class1002.method_0)
                    .Where<ShipData>(class1002.class1001_0.method_8)
                    .Select<ShipData, ShipComponent>(class1002.class1001_0.method_9)
                    .OrderByDescending<ShipComponent, Decimal>(gclass230_0 => gclass230_0.decimal_3)
                    .FirstOrDefault<ShipComponent>();
                if (gclass230_4 != null && gclass230_4.decimal_3 >= num)
                    return true;
            }

            // ISSUE: reference to a compiler-generated field
            class1002.list_0 = this.Race.AlienRaceIntels.Values
                .Where<AlienRaceIntel>(gclass110_0 => gclass110_0.ContactStatus == AuroraContactStatus.Allied)
                .Select<AlienRaceIntel, GameRace>(gclass110_0 => gclass110_0.ActualAlienRace).ToList<GameRace>();
            // ISSUE: reference to a compiler-generated field
            if (class1002.list_0.Count > 0)
            {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                ShipComponent gclass230_5 = this.gclass0_0.Ships.Values
                    .Where<ShipData>(class1002.method_1).Where<ShipData>(class1002.class1001_0.method_10)
                    .Select<ShipData, ShipComponent>(class1002.class1001_0.method_11)
                    .OrderByDescending<ShipComponent, Decimal>(gclass230_0 => gclass230_0.decimal_3)
                    .FirstOrDefault<ShipComponent>();
                if (gclass230_5 != null && gclass230_5.decimal_3 >= num)
                    return true;
            }

            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class1002.gclass221_0 != null && class1002.list_0.Count > 0)
            {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                ShipComponent gclass230_6 = this.gclass0_0.Ships.Values
                    .Where<ShipData>(class1002.method_2).Where<ShipData>(class1002.class1001_0.method_12)
                    .Select<ShipData, ShipComponent>(class1002.class1001_0.method_13)
                    .OrderByDescending<ShipComponent, Decimal>(gclass230_0 => gclass230_0.decimal_3)
                    .FirstOrDefault<ShipComponent>();
                if (gclass230_6 != null && gclass230_6.decimal_3 >= num)
                    return true;
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 705);
            return false;
        }
    }

    public List<FleetData> method_246(JumpPoint gclass120_1)
    {
        try
        {
            List<FleetData> gclass85List = new List<FleetData>();
            foreach (SubFleet gclass84_0 in this.gclass0_0.SubFleetDictionary.Values
                         .Where<SubFleet>(gclass84_0 => gclass84_0.ParentFleet == this).ToList<SubFleet>())
            {
                List<ShipData> gclass40List = gclass84_0.method_0();
                int num = this.method_244(gclass40List);
                if (num > 0)
                {
                    OperationalGroupID genum105_0 = OperationalGroupID.None;
                    if (this.NPROperationGroup != null)
                        genum105_0 = this.NPROperationGroup.OperationalGroupId;
                    FleetData gclass85_1 = this.Race.method_308(gclass84_0.SubFleetName, this.ParentNavalCommand,
                        this.System, this.XCoord, this.YCoord, this.OrbitingBody, genum105_0);
                    gclass85_1.decimal_6 = num;
                    foreach (ShipData gclass40 in gclass40List)
                        gclass40.gclass84_0 = null;
                    this.Race.method_270(gclass40List, this, gclass85_1, true, false);
                    this.method_163(gclass84_0);
                    gclass85List.Add(gclass85_1);
                }
                else
                    this.gclass0_0.gclass92_0.method_2(EventType.const_32,
                        string.Format(
                            (string)
                            "{0} cannot carry out a squadron transit as there is no available jump drive capable of escorting the sub-fleet through the jump point",
                            (object)gclass84_0.SubFleetName),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
            }

            return gclass85List;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 706);
            return null;
        }
    }

    public List<FleetData> method_247()
    {
        try
        {
            List<FleetData> gclass85List = new List<FleetData>();
            int num1 = 1;
            List<ShipData> list1 = this.list_3
                .Where<ShipData>(gclass40_0 => gclass40_0.method_148(false) != null)
                .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.Class.Size)
                .ToList<ShipData>();
            if (list1.Count == 0)
                return gclass85List;
            List<ShipData> list2 = this.list_3
                .Where<ShipData>(gclass40_0 =>
                    gclass40_0.method_148(false) == null && !gclass40_0.Class.Commercial)
                .OrderByDescending<ShipData, Decimal>(gclass40_0 => gclass40_0.Class.Size)
                .ToList<ShipData>();
            if (list2.Count == 0)
                return gclass85List;
            foreach (ShipData gclass40_1 in list1)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class1003 class1003 = new FleetData.Class1003();
                // ISSUE: reference to a compiler-generated field
                class1003.gclass230_0 = gclass40_1.method_148(false);
                // ISSUE: reference to a compiler-generated field
                int num2 = class1003.gclass230_0.int_10 - 1;
                if (num2 != 0)
                {
                    FleetData gclass85_1 = this.Race.method_308(
                        string.Format((string)"{0} SQN {1}", (object)this.FleetName, (object)num1.ToString()),
                        this.ParentNavalCommand, this.System, this.XCoord, this.YCoord, this.OrbitingBody,
                        OperationalGroupID.ReinforcementGroup);
                    gclass85List.Add(gclass85_1);
                    ++num1;
                    // ISSUE: reference to a compiler-generated field
                    gclass85_1.decimal_6 = class1003.gclass230_0.int_9;
                    gclass85_1.gclass85_0 = this;
                    gclass40_1.method_185(gclass85_1, false, false, false, false);
                    // ISSUE: reference to a compiler-generated method
                    foreach (ShipData gclass40_2 in list2.Where<ShipData>(class1003.method_0)
                                 .ToList<ShipData>())
                    {
                        gclass40_2.method_185(gclass85_1, false, false, false, false);
                        list2.Remove(gclass40_2);
                        --num2;
                        if (num2 <= 0)
                            break;
                    }
                }
            }

            return gclass85List;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3964);
            return null;
        }
    }

    public int method_248(MoveActionType genum123_0, JumpPoint gclass120_1)
    {
        try
        {
            List<ShipData> gclass40List = this.method_177();
            if (gclass40List.Count<ShipData>(gclass40_0 => gclass40_0.int_15 > 0) > 0)
            {
                this.gclass0_0.gclass92_0.method_2(EventType.const_221,
                    string.Format(
                        (string)"{0} cannot conduct a transit as there are one or more ships suffering from jump shock",
                        (object)this.FleetName),
                    this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                    AuroraEventCategory.Fleet);
                return 0;
            }

            switch (genum123_0)
            {
                case MoveActionType.StandardTransit:
                case MoveActionType.TransitAndDivideFleet:
                    if (gclass120_1.JumpGateStrength > 0)
                        return 1;
                    List<ShipData> list1 = this.gclass0_0.Ships.Values
                        .Where<ShipData>(gclass40_0 =>
                            gclass40_0.gclass85_0 == this && gclass40_0.Class.MilitaryEngines &&
                            gclass40_0.gclass40_0 == null).ToList<ShipData>();
                    List<ShipData> list2 = this.gclass0_0.Ships.Values
                        .Where<ShipData>(gclass40_0 =>
                            gclass40_0.gclass85_0 == this && !gclass40_0.Class.MilitaryEngines &&
                            gclass40_0.gclass40_0 == null).ToList<ShipData>();
                    if (list1.Count == 0 && list2.Count == 0)
                        return 0;
                    bool flag1 = list1.Count == 0 || this.method_245(list1, gclass120_1, false);
                    bool flag2 = list2.Count == 0 || this.method_245(list2, gclass120_1, true);
                    if (!flag1 && list1.Count > 0)
                    {
                        this.gclass0_0.gclass92_0.method_2(EventType.const_32,
                            string.Format(
                                (string)
                                "{0} cannot carry out a transit as there is no available jump drive capable of allowing the fleet's military-engined ships to enter the jump point",
                                (object)this.FleetName),
                            this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                            AuroraEventCategory.Fleet);
                        return 0;
                    }

                    if (flag2 || list2.Count <= 0)
                        return 1;
                    this.gclass0_0.gclass92_0.method_2(EventType.const_32,
                        string.Format(
                            (string)
                            "{0} cannot carry out a transit as there is no available jump drive capable of allowing the fleet's commercial-engined ships to enter the jump point",
                            (object)this.FleetName),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
                    return 0;
                case MoveActionType.SquadronTransit:
                    int num = this.method_244(gclass40List);
                    if (num != 0)
                        return num;
                    this.gclass0_0.gclass92_0.method_2(EventType.const_32,
                        string.Format(
                            (string)
                            "{0} cannot carry out a squadron transit as there is no available jump drive capable of escorting the fleet through the jump point",
                            (object)this.FleetName),
                        this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                        AuroraEventCategory.Fleet);
                    return 0;
                default:
                    return 0;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 707);
            return 0;
        }
    }

    public void method_249(GClass221 gclass221_0)
    {
        try
        {
            this.LastMoveTime = this.gclass0_0.GameTime;
            this.LastXCoord = this.XCoord;
            this.LastYCoord = this.YCoord;
            this.XCoord = gclass221_0.double_0;
            this.YCoord = gclass221_0.double_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 708);
        }
    }

    public Decimal method_250(Decimal decimal_9)
    {
        try
        {
            if (decimal_9 == 0M)
                return 0M;
            Decimal num1 = decimal_9;
            List<ShipData> list = this.gclass0_0.Ships.Values.Where<ShipData>(gclass40_0 =>
                    gclass40_0.gclass85_0 == this && gclass40_0.gclass40_0 == null && gclass40_0.gclass40_3 == null)
                .ToList<ShipData>();
            foreach (ShipData gclass40 in list)
            {
                Decimal num2 = gclass40.method_171(true);
                Decimal num3 = gclass40.method_157(AuroraComponentType.Engine, false);
                if (!(num3 == 0M))
                {
                    gclass40.decimal_25 = num3 * (gclass40.gclass85_0.Speed / num2);
                    Decimal num4 = gclass40.decimal_25 * gclass40.Class.FuelEfficiency * (decimal_9 / 3600M);
                    if (num4 > gclass40.decimal_14 && !gclass40.Race.NPR)
                    {
                        Decimal num5 = decimal_9 * (gclass40.decimal_14 / num4);
                        if (num5 < num1)
                        {
                            num1 = num5;
                            if (!gclass40.Race.NPR)
                                this.gclass0_0.gclass92_0.method_2(EventType.const_28,
                                    string.Format(
                                        (string)"{0} has insufficient fuel to complete the orders of its parent fleet",
                                        (object)gclass40.ShipName),
                                    this.Race, this.System.ActualSystem, this.XCoord, this.YCoord,
                                    AuroraEventCategory.Fleet);
                        }
                    }
                }
            }

            foreach (ShipData gclass40 in list)
            {
                Decimal num6 = gclass40.decimal_25 * gclass40.Class.FuelEfficiency * (num1 / 3600M);
                gclass40.decimal_14 -= num6;
                if (gclass40.decimal_14 < 0M)
                    gclass40.decimal_14 = 0M;
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 709);
            return decimal_9;
        }
    }

    public int method_251()
    {
        try
        {
            return this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0 == this)
                .Min<ShipData>(gclass40_0 => gclass40_0.Class.ArmourThickness);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 710);
            return 1;
        }
    }

    public GClass221 method_252(GClass221 gclass221_0, double double_11)
    {
        try
        {
            GClass221 gclass221 = new GClass221(gclass221_0.double_0, gclass221_0.double_1);
            double num1 = this.gclass0_0.GetDistanceBetween(this.XCoord, this.YCoord, gclass221_0.double_0,
                gclass221_0.double_1);
            double num2 = double_11 / num1;
            double num3 = Math.Abs(gclass221_0.double_0 - this.XCoord) * num2;
            double num4 = Math.Abs(gclass221_0.double_1 - this.YCoord) * num2;
            gclass221.double_0 = gclass221_0.double_0 >= this.XCoord
                ? gclass221_0.double_0 - num3
                : gclass221_0.double_0 + num3;
            gclass221.double_1 = gclass221_0.double_1 >= this.YCoord
                ? gclass221_0.double_1 - num4
                : gclass221_0.double_1 + num4;
            return gclass221;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 711);
            return gclass221_0;
        }
    }

    public bool method_253()
    {
        try
        {
            return this.MoveOrderDictionary.Count != 0 && this.Speed >= 2 && !this.method_255().bArrived;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 712);
            return false;
        }
    }

    public Decimal method_254()
    {
        try
        {
            Decimal num1 = 0M;
            List<ShipData> source = this.method_176();
            if (source.Count == 0)
            {
                this.MoveOrderDictionary.Clear();
                this.StandingOrdersDictionary.Clear();
                return 0M;
            }

            List<Commander> list = source
                .Select<ShipData, Commander>(gclass40_0 => gclass40_0.method_192(AuroraCommandType.Ship))
                .Where<Commander>(gclass55_0 => gclass55_0 != null).ToList<Commander>();
            foreach (Commander gclass55 in list)
                num1 += gclass55.method_5(CommanderBonusType.Reaction);
            Decimal num2 = (num1 + (source.Count - list.Count)) / source.Count *
                           this.ParentNavalCommand.method_5(this.System.ActualSystem.SystemID, CommanderBonusType.Reaction);
            return num2 >= 2M ? 0.99M : num2 - 1M;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 713);
            return 0M;
        }
    }

    public MoveOrder method_255()
    {
        try
        {
            return this.MoveOrderDictionary.Values.OrderBy<MoveOrder, int>(gclass139_0 => gclass139_0.OrderValue)
                .FirstOrDefault<MoveOrder>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 714);
            return null;
        }
    }

    public MoveOrder method_256()
    {
        try
        {
            return this.MoveOrderDictionary.Values.OrderByDescending<MoveOrder, int>(gclass139_0 => gclass139_0.OrderValue)
                .FirstOrDefault<MoveOrder>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 715);
            return null;
        }
    }

    public PopulationData method_257()
    {
        try
        {
            return this.method_256()?.Population;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 716);
            return null;
        }
    }

    public void method_258(ListView listView_0)
    {
        try
        {
            listView_0.Items.Clear();
            List<MoveOrder> list = this.MoveOrderDictionary.Values.OrderBy<MoveOrder, int>(gclass139_0 => gclass139_0.OrderValue)
                .ToList<MoveOrder>();
            string str1 = "";
            if (this.method_45())
                str1 = " (OV)";
            foreach (MoveOrder object_1 in list)
            {
                string str2 = object_1.Description;
                if (object_1.DelayRemaining > 0)
                    str2 = string.Format((string)"{0}: Delay  {1}", (object)str2,
                        (object)this.gclass0_0.method_568(object_1.DelayRemaining, false));
                string string_10 = str2 + str1;
                if (object_1.NewJumpPoint != null)
                    this.gclass0_0.method_596(listView_0, string_10, Color.Orange, object_1);
                else
                    this.gclass0_0.method_595(listView_0, string_10, object_1);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 717);
        }
    }

    public void method_259(ListView listView_0)
    {
        try
        {
            listView_0.Items.Clear();
            if (this.AnchorFleet == null)
                this.gclass0_0.method_601(listView_0, "Anchor Fleet", "None", null);
            else
                this.gclass0_0.method_601(listView_0, "Anchor Fleet", this.AnchorFleet.FleetName, null);
            this.gclass0_0.method_601(listView_0, "Desired Distance", AuroraUtils.smethod_59(this.AnchorFleetDistance, "km"),
                null);
            this.gclass0_0.method_601(listView_0, "Desired Bearing Offset", AuroraUtils.smethod_58(this.AnchorFleetBearingOffset, "°"),
                null);
            if (this.gclass117_0 == null)
                this.gclass0_0.method_601(listView_0, "Specific Threat", "None", null);
            else
                this.gclass0_0.method_601(listView_0, "Specific Threat", this.gclass117_0.method_11(), null);
            this.gclass0_0.method_601(listView_0, "Guard vs Nearest Hostile Warship",
                AuroraUtils.smethod_70(this.bGuardNearestKnownWarship), null);
            this.gclass0_0.method_601(listView_0, "Guard vs Nearest Hostile Contact",
                AuroraUtils.smethod_70(this.bGuardNearestHostileContact), null);
            this.gclass0_0.method_601(listView_0, "Use Anchor Fleet Destination", AuroraUtils.smethod_70(this.bUseAnchorDestination),
                null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3326);
        }
    }

    public GClass221 method_260()
    {
        try
        {
            GClass221 gclass221 = new GClass221(0.0, 0.0);
            MoveOrder gclass139 = this.method_256();
            if (gclass139 != null)
                return this.gclass0_0.method_52(gclass139.DestinationType, gclass139.DestinationID, gclass139.StartSystem.ActualSystem,
                    gclass139.NewJumpPoint);
            gclass221.double_0 = this.XCoord;
            gclass221.double_1 = this.YCoord;
            return gclass221;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 718);
            return null;
        }
    }

    public RacialSystemSurvey method_261()
    {
        try
        {
            MoveOrder gclass139 = this.method_256();
            if (gclass139 == null)
                return this.System;
            return gclass139.NewSystem != null ? gclass139.NewSystem : gclass139.StartSystem;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 719);
            return null;
        }
    }

    public void method_262()
    {
        try
        {
            MoveOrder gclass139 = this.method_256();
            if (gclass139 == null)
                return;
            this.MoveOrderDictionary.Remove(gclass139.MoveOrderID);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 720);
        }
    }

    public void method_263()
    {
        try
        {
            this.MoveOrderDictionary.Clear();
            this.genum48_0 = GEnum48.const_0;
            if (this.NPRSomething == null)
                return;
            this.NPRSomething.bRedeployOrderGiven = false;
            this.NPRSomething.gclass202_0 = null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 721);
        }
    }

    public void method_264(
        GClass134 gclass134_0,
        MoveActionDefinition gclass133_0,
        object object_0,
        Decimal decimal_9,
        double double_11,
        int int_12,
        int int_13,
        int int_14,
        bool bool_25,
        CheckState checkState_1)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class1004 class1004 = new FleetData.Class1004();
        // ISSUE: reference to a compiler-generated field
        class1004.gclass134_0 = gclass134_0;
        try
        {
            string str1 = "";
            // ISSUE: reference to a compiler-generated field
            if (checkState_1 == CheckState.Checked && class1004.gclass134_0.genum13_0 != DestinationType.const_8)
            {
                // ISSUE: reference to a compiler-generated method
                List<LagrangePoint> list = this.gclass0_0.LagrangePoints.Values.Where<LagrangePoint>(class1004.method_0)
                    .OrderBy<LagrangePoint, int>(gclass212_0 => gclass212_0.int_1).ToList<LagrangePoint>();
                List<LagrangePoint> gclass212List = new List<LagrangePoint>(list);
                if (list.Count > 1)
                {
                    LagrangePoint gclass212_1 = null;
                    LagrangePoint gclass212_2 = null;
                    GClass221 gclass221_1 = this.method_260();
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    GClass221 gclass221_2 = this.gclass0_0.method_52(class1004.gclass134_0.genum13_0,
                        class1004.gclass134_0.int_0, class1004.gclass134_0.gclass202_0.ActualSystem, null);
                    double num1 = this.gclass0_0.GetDistanceBetween(gclass221_1.double_0, gclass221_1.double_1,
                        gclass221_2.double_0, gclass221_2.double_1);
                    foreach (LagrangePoint gclass212_3 in list)
                    {
                        double num2 = this.gclass0_0.GetDistanceBetween(gclass221_1.double_0, gclass221_1.double_1,
                            gclass212_3.XCor, gclass212_3.Ycor);
                        if (num2 < num1)
                        {
                            foreach (LagrangePoint gclass212_4 in gclass212List)
                            {
                                if (gclass212_4 != gclass212_3)
                                {
                                    double num3 = this.gclass0_0.GetDistanceBetween(gclass212_4.XCor, gclass212_4.Ycor,
                                        gclass221_2.double_0, gclass221_2.double_1);
                                    if (num2 + num3 < num1)
                                    {
                                        gclass212_1 = gclass212_3;
                                        gclass212_2 = gclass212_4;
                                        num1 = num2 + num3;
                                    }
                                }
                            }
                        }
                    }

                    if (gclass212_1 != null)
                    {
                        MoveOrder gclass139 = new MoveOrder();
                        gclass139.MoveOrderID = this.gclass0_0.method_26(GEnum0.const_37);
                        gclass139.OrderValue = this.MoveOrderDictionary.Count <= 0
                            ? 1
                            : this.MoveOrderDictionary.Values.Max<MoveOrder>(gclass139_0 => gclass139_0.OrderValue) + 1;
                        gclass139.Fleet = this;
                        gclass139.Race = this.Race;
                        // ISSUE: reference to a compiler-generated field
                        gclass139.StartSystem = class1004.gclass134_0.gclass202_0;
                        gclass139.DestinationType = DestinationType.const_8;
                        gclass139.DestinationID = gclass212_1.LaGrangePointID;
                        gclass139.DestinationItemType = DestinationItemType.const_9;
                        gclass139.DestinationItemID = gclass212_2.LaGrangePointID;
                        gclass139.NewSystem = null;
                        gclass139.NewJumpPoint = null;
                        gclass139.Population = null;
                        gclass139.MoveActionType = this.gclass0_0.MoveActionDictionary[MoveActionType.IntraSystemJump];
                        gclass139.Description =
                            string.Format((string)"{0}: Intra-system Jump to {1}",
                                (object)gclass212_1.method_3(this.Race), (object)gclass212_2.method_3(this.Race));
                        this.MoveOrderDictionary.Add(gclass139.MoveOrderID, gclass139);
                    }
                }
            }

            MoveOrder gclass139_1 = new MoveOrder();
            gclass139_1.MoveOrderID = this.gclass0_0.method_26(GEnum0.const_37);
            gclass139_1.OrderValue = this.MoveOrderDictionary.Count <= 0
                ? 1
                : this.MoveOrderDictionary.Values.Max<MoveOrder>(gclass139_0 => gclass139_0.OrderValue) + 1;
            gclass139_1.Fleet = this;
            gclass139_1.Race = this.Race;
            // ISSUE: reference to a compiler-generated field
            gclass139_1.StartSystem = class1004.gclass134_0.gclass202_0;
            // ISSUE: reference to a compiler-generated field
            gclass139_1.DestinationType = class1004.gclass134_0.genum13_0;
            gclass139_1.DestinationItemType = gclass133_0.DestinationItemType;
            // ISSUE: reference to a compiler-generated field
            gclass139_1.DestinationID = class1004.gclass134_0.int_0;
            // ISSUE: reference to a compiler-generated field
            gclass139_1.Population = class1004.gclass134_0.gclass146_0;
            gclass139_1.MoveActionType = gclass133_0;
            if (gclass139_1.MoveActionType.TransitOrder)
            {
                // ISSUE: reference to a compiler-generated field
                gclass139_1.NewSystem = class1004.gclass134_0.gclass202_1;
                // ISSUE: reference to a compiler-generated field
                gclass139_1.NewJumpPoint = class1004.gclass134_0.gclass120_0;
            }

            gclass139_1.MaxItems = decimal_9;
            gclass139_1.MinDistance = double_11;
            gclass139_1.MinQuantity = int_12;
            gclass139_1.Delay = int_13;
            gclass139_1.DelayRemaining = int_13;
            gclass139_1.OrbDistance = int_14;
            gclass139_1.bLoadSubUnits = bool_25;
            gclass139_1.SurveyPointsRequired = 0M;
            gclass139_1.DestinationItemID = 0;
            if (gclass139_1.MoveActionType.MoveActionType == MoveActionType.GeologicalSurvey)
                gclass139_1.SurveyPointsRequired = this.gclass0_0.SystemBodyRecordDic[gclass139_1.DestinationID].method_39();
            else if (gclass139_1.MoveActionType.MoveActionType == MoveActionType.GravitationalSurvey)
                gclass139_1.SurveyPointsRequired = gclass139_1.StartSystem.ActualSystem.JumpPointSurveyPoints;
            else if (gclass139_1.MoveActionType.MoveActionType == MoveActionType.SendMessage)
                gclass139_1.MessageText = this.gclass0_0.method_562("Send Message", "Enter Text Here");
            switch (gclass133_0.DestinationItemType)
            {
                case DestinationItemType.const_1:
                case DestinationItemType.const_13:
                    AuroraElement enum_0 = (AuroraElement)object_0;
                    str1 = AuroraUtils.smethod_82(enum_0);
                    gclass139_1.DestinationItemID = (int)enum_0;
                    break;
                case DestinationItemType.const_2:
                case DestinationItemType.const_12:
                    PlanetaryInstallationType gclass157 = (PlanetaryInstallationType)object_0;
                    str1 = gclass157.Name;
                    gclass139_1.DestinationItemID = (int)gclass157.InstallationType;
                    break;
                case DestinationItemType.const_3:
                case DestinationItemType.const_4:
                case DestinationItemType.const_5:
                    GroundUnitFormationData gclass103 = (GroundUnitFormationData)object_0;
                    str1 = gclass103.method_45();
                    gclass139_1.DestinationItemID = gclass103.FormationID;
                    break;
                case DestinationItemType.const_6:
                    Commander gclass55 = (Commander)object_0;
                    str1 = gclass55.method_38();
                    gclass139_1.DestinationItemID = gclass55.CommanderID;
                    break;
                case DestinationItemType.const_7:
                case DestinationItemType.const_8:
                    ShipData gclass40 = (ShipData)object_0;
                    str1 = gclass40.method_187();
                    gclass139_1.DestinationItemID = gclass40.int_8;
                    break;
                case DestinationItemType.const_9:
                    LagrangePoint gclass212 = (LagrangePoint)object_0;
                    str1 = gclass212.method_3(this.Race);
                    gclass139_1.DestinationItemID = gclass212.LaGrangePointID;
                    break;
                case DestinationItemType.const_10:
                case DestinationItemType.const_14:
                    ShipComponent gclass230 = (ShipComponent)object_0;
                    str1 = gclass230.Name;
                    gclass139_1.DestinationItemID = gclass230.int_0;
                    break;
                case DestinationItemType.const_11:
                    Shipyard gclass193 = (Shipyard)object_0;
                    str1 = gclass193.ShipyardName;
                    gclass139_1.DestinationItemID = gclass193.ShipyardID;
                    break;
                case DestinationItemType.const_15:
                    SubFleet gclass84 = (SubFleet)object_0;
                    str1 = gclass84.SubFleetName;
                    gclass139_1.DestinationItemID = gclass84.SubFleetID;
                    break;
                case DestinationItemType.const_16:
                    gclass139_1.DestinationItemID = (int)object_0;
                    str1 = this.gclass0_0.TradeGoodsDictionary[gclass139_1.DestinationItemID].string_0;
                    break;
                case DestinationItemType.const_17:
                    FCTSquadronData70 gclass70 = (FCTSquadronData70)object_0;
                    str1 = gclass70.SquadronName;
                    gclass139_1.DestinationItemID = gclass70.SquadronID;
                    break;
            }

            string str2;
            if (gclass139_1.Population != null)
            {
                // ISSUE: reference to a compiler-generated field
                string popName = class1004.gclass134_0.gclass146_0.PopName;
                if (gclass139_1.Population.ProvideColonists == 1)
                    popName += " (Neutral)";
                str2 = string.Format((string)"{0}: {1}", (object)popName, (object)gclass133_0.Description);
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                str2 = string.Format((string)"{0}: {1}", (object)class1004.gclass134_0.DestinationName,
                    (object)gclass133_0.Description);
            }

            if (str1 != "")
                str2 = string.Format((string)"{0} - {1}", (object)str2, (object)str1);
            if (decimal_9 > 0M)
                str2 = string.Format((string)"{0} x{1}", (object)str2,
                    (object)AuroraUtils.FormatNumberToDigits(decimal_9, 4));
            if (int_12 > 0)
                str2 = string.Format((string)"{0} (Min {1})", (object)str2, (object)AuroraUtils.smethod_37(int_12));
            if (double_11 > 0.0)
                str2 = string.Format((string)"{0}: MD {1}", (object)str2,
                    (object)AuroraUtils.smethod_59(double_11, "km"));
            if (int_14 > 0)
                str2 = string.Format((string)"{0}: Orbit {1}", (object)str2,
                    (object)AuroraUtils.smethod_58(int_14, "km"));
            if (bool_25)
                str2 += " (SUB)";
            gclass139_1.Description = str2;
            this.MoveOrderDictionary.Add(gclass139_1.MoveOrderID, gclass139_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 722);
        }
    }

    public bool method_265(MoveActionDefinition gclass133_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class1005 class1005 = new FleetData.Class1005();
        // ISSUE: reference to a compiler-generated field
        class1005.gclass133_0 = gclass133_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            return this.MoveOrderDictionary.Values.Count<MoveOrder>(class1005.method_0) > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 723);
            return false;
        }
    }

    public bool method_266(List<ShipData> list_4)
    {
        try
        {
            if (list_4.Where<ShipData>(gclass40_0 => gclass40_0.Class.Size > 10M)
                    .Count<ShipData>() > 0)
                return false;
            if (list_4.Select<ShipData, ShipClass>(gclass40_0 => gclass40_0.Class)
                    .SelectMany<ShipClass, ClassComponent>(gclass22_0 => gclass22_0.ClassComponents.Values)
                    .Where<ClassComponent>(gclass228_0 =>
                        gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.FighterPodBay)
                    .Count<ClassComponent>() == 0)
            {
                foreach (ShipData gclass40 in list_4)
                {
                    if (gclass40.method_157(AuroraComponentType.MissileLauncher, false) == 0M ||
                        gclass40.Ordnances.Sum<ShipOrdnance>(gclass130_0 => gclass130_0.RaceMissile.GroundDamage) <= 0M)
                        return false;
                }
            }

            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 724);
            return false;
        }
    }

    public bool method_267(List<ShipData> list_4)
    {
        try
        {
            return list_4.Where<ShipData>(gclass40_0 => gclass40_0.Class.Size > 10M)
                .Count<ShipData>() <= 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 724);
            return false;
        }
    }

    public void method_268()
    {
        try
        {
            List<ShipData> gclass40List = this.method_176();
            if (this.method_127(AuroraComponentType.ActiveSearchSensors) > 0)
                this.method_269(GEnum124.const_14);
            if (this.method_127(AuroraComponentType.MissileLauncher) > 0)
                this.method_269(GEnum124.const_23);
            if (this.method_128() > 0)
                this.method_269(GEnum124.const_62);
            if (gclass40List.Count > 1)
                this.method_269(GEnum124.const_17);
            if (gclass40List
                    .Where<ShipData>(gclass40_0 => gclass40_0.gclass40_1 != null && gclass40_0.gclass40_0 == null)
                    .Count<ShipData>() > 0)
                this.method_269(GEnum124.const_20);
            if (gclass40List.Where<ShipData>(gclass40_0 => gclass40_0.method_120() > 0).Count<ShipData>() > 0)
                this.method_269(GEnum124.const_24);
            if (gclass40List.Where<ShipData>(gclass40_0 => gclass40_0.gclass40_2 != null).Count<ShipData>() >
                0)
                this.method_269(GEnum124.const_39);
            if (gclass40List.Where<ShipData>(gclass40_0 => gclass40_0.TractorTargetShipyard != null).Count<ShipData>() >
                0)
                this.method_269(GEnum124.const_40);
            if (this.gclass0_0.ActiveCommanders.Values.Select<Commander, ShipData>(gclass55_0 => gclass55_0.TransportShip)
                    .Intersect<ShipData>(gclass40List).Count<ShipData>() > 0)
                this.method_269(GEnum124.const_41);
            if (this.method_266(gclass40List))
                this.method_269(GEnum124.const_61);
            if (this.method_267(gclass40List))
                this.method_269(GEnum124.const_68);
            foreach (ShipData gclass40 in gclass40List)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class1006 class1006 = new FleetData.Class1006();
                // ISSUE: reference to a compiler-generated field
                class1006.gclass40_0 = gclass40;
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.CargoShuttleStrength > 0)
                    this.method_269(GEnum124.const_67);
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.ColonistCapacity > 0)
                    this.method_269(GEnum124.const_1);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.ColonistCapacity > 0 && class1006.gclass40_0.Class.CargoShuttleStrength > 0)
                    this.method_269(GEnum124.const_54);
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.FuelTanker == 1)
                    this.method_269(GEnum124.const_2);
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.CargoCapacity >= 25000)
                    this.method_269(GEnum124.const_3);
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.CargoCapacity >= 0)
                    this.method_269(GEnum124.const_4);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.CargoCapacity >= 0 && (class1006.gclass40_0.Class.CargoShuttleStrength > 0 ||
                                                                    class1006.gclass40_0.Class.Size <= 10M))
                    this.method_269(GEnum124.const_55);
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.GravSurvey > 0)
                    this.method_269(GEnum124.const_5);
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.GeoSurvey > 0M)
                    this.method_269(GEnum124.const_6);
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.Collier == 1)
                    this.method_269(GEnum124.const_7);
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.ShieldStrength > 0)
                    this.method_269(GEnum124.const_9);
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.TroopCapacity > 0)
                    this.method_269(GEnum124.const_10);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.GravSurvey > 0 || class1006.gclass40_0.Class.GeoSurvey > 0M)
                    this.method_269(GEnum124.const_11);
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.JGConstructionTime > 0)
                    this.method_269(GEnum124.const_12);
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.SalvageRate > 0)
                    this.method_269(GEnum124.const_15);
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.MagazineCapacity > 0M)
                    this.method_269(GEnum124.const_16);
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.genum29_0 == GEnum29.const_1)
                    this.method_269(GEnum124.const_19);
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.SupplyShip == 1)
                    this.method_269(GEnum124.const_21);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.TroopCapacity > 0 &&
                    class1006.gclass40_0.Class.gclass163_0.TechType == TechType.TroopTransportDropshipEquipped)
                    this.method_269(GEnum124.const_25);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.TroopCapacity > 0 &&
                    class1006.gclass40_0.Class.gclass163_0.TechType == TechType.TroopTransportBoardingEquipped)
                    this.method_269(GEnum124.const_63);
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.STSTractor > 0)
                    this.method_269(GEnum124.const_27);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class1006.gclass40_0.Class.Crew > class1006.gclass40_0.int_11)
                    this.method_269(GEnum124.const_29);
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                if (this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class1006.method_0).Count<GroundUnitFormationData>() > 0 &&
                    class1006.gclass40_0.Class.TroopCapacity == 0)
                    this.method_269(GEnum124.const_31);
            }

            if (this.list_2.Contains(GEnum124.const_2) && this.list_2.Contains(GEnum124.const_21))
                this.method_269(GEnum124.const_59);
            if (!this.list_2.Contains(GEnum124.const_2) || !this.list_2.Contains(GEnum124.const_21) ||
                !this.list_2.Contains(GEnum124.const_7))
                return;
            this.method_269(GEnum124.const_60);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 725);
        }
    }

    public void method_269(GEnum124 genum124_0)
    {
        try
        {
            if (this.list_2.Contains(genum124_0))
                return;
            this.list_2.Add(genum124_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 726);
        }
    }

    public GClass134 method_270(JumpPoint gclass120_1, RacialSystemSurvey gclass202_1)
    {
        try
        {
            GClass134 gclass134 = new GClass134();
            gclass134.gclass202_0 = gclass202_1;
            gclass134.genum13_0 = DestinationType.const_0;
            gclass134.int_0 = gclass120_1.WarpPointID;
            gclass134.DestinationName = gclass120_1.JumpGateStrength <= 0
                ? gclass120_1.method_7(gclass202_1)
                : string.Format((string)"{0} (S)", (object)gclass120_1.method_7(gclass202_1));
            if (gclass120_1.RacialJumpPointSurveys[this.Race.RaceID].Explored == 1 && gclass120_1.LinkedJumpPoint != null)
            {
                gclass134.gclass120_0 = gclass120_1.LinkedJumpPoint;
                gclass134.gclass202_1 = this.Race.RacialSystemDictionary[gclass120_1.LinkedJumpPoint.SystemData.SystemID];
            }
            else
            {
                gclass134.gclass120_0 = null;
                gclass134.gclass202_1 = null;
            }

            gclass134.gclass146_0 = null;
            gclass134.bool_0 = false;
            return gclass134;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 727);
            return null;
        }
    }

    public GClass134 method_271(AetherGate gclass210_0, RacialSystemSurvey gclass202_1)
    {
        try
        {
            return new GClass134()
            {
                gclass202_0 = gclass202_1,
                genum13_0 = DestinationType.const_9,
                int_0 = gclass210_0.int_0,
                DestinationName = string.Format((string)"Aether Gate #{0}", (object)gclass210_0.int_0),
                gclass120_0 = null,
                gclass202_1 = null,
                gclass146_0 = null,
                bool_0 = false
            };
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 727);
            return null;
        }
    }

    public GClass134 method_272(SystemBodyData gclass1_1, RacialSystemSurvey gclass202_1)
    {
        try
        {
            return new GClass134()
            {
                gclass202_0 = gclass202_1,
                genum13_0 = DestinationType.const_1,
                int_0 = gclass1_1.SystemBodyID,
                DestinationName = gclass1_1.method_78(this.Race),
                gclass120_0 = null,
                gclass202_1 = null,
                gclass146_0 = null,
                bool_0 = gclass1_1.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                         gclass1_1.BodyTypeId == AuroraSystemBodyType.Superjovian
            };
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 728);
            return null;
        }
    }

    public GClass134 method_273(SurveyLocation gclass213_0, RacialSystemSurvey gclass202_1)
    {
        try
        {
            return new GClass134()
            {
                gclass202_0 = gclass202_1,
                DestinationName = string.Format((string)"Survey Location #{0}", (object)gclass213_0.LocationNumber),
                genum13_0 = DestinationType.const_2,
                int_0 = gclass213_0.LocationNumber,
                gclass120_0 = null,
                gclass202_1 = null,
                gclass146_0 = null,
                bool_0 = false
            };
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 729);
            return null;
        }
    }

    public GClass134 method_274(PopulationData gclass146_1)
    {
        try
        {
            GClass134 gclass134 = new GClass134();
            gclass134.gclass202_0 = gclass146_1.gclass202_0;
            gclass134.gclass146_0 = gclass146_1;
            gclass134.DestinationName = gclass146_1.method_130();
            gclass134.genum13_0 = DestinationType.const_1;
            gclass134.int_0 = gclass146_1.SystemBodyData.SystemBodyID;
            if (gclass146_1.SystemBodyData.IsFixedBody)
            {
                gclass134.genum13_0 = DestinationType.const_10;
                gclass134.DestinationName += "  (DSP)";
            }

            if (gclass146_1.ProvideColonists == 1)
                gclass134.DestinationName += "  (Neutral)";
            gclass134.gclass120_0 = null;
            gclass134.gclass202_1 = null;
            gclass134.bool_0 = false;
            return gclass134;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 730);
            return null;
        }
    }

    public GClass134 method_275(Wreck gclass233_0, RacialSystemSurvey gclass202_1)
    {
        try
        {
            GClass134 gclass134 = new GClass134();
            string str;
            if (gclass233_0.Race == this.Race)
                str =
                    string.Format((string)"Wreck: {0} {1}  {2} tons   ID {3}",
                        new[] { gclass233_0.ShipClass.ShipHull.Abbreviation }, gclass233_0.ShipClass.ClassName,
                        AuroraUtils.smethod_38(gclass233_0.ShipClass.Size * AuroraUtils.decimal_17),
                        gclass233_0.WreckID.ToString());
            else
                str =
                    string.Format((string)"Wreck: {0}  {1} tons   ID {2}",
                        (object)this.Race.method_324(gclass233_0.ShipClass.ShipClassID),
                        (object)AuroraUtils.smethod_38(gclass233_0.ShipClass.Size * AuroraUtils.decimal_17),
                        (object)gclass233_0.WreckID.ToString());
            gclass134.gclass202_0 = gclass202_1;
            gclass134.DestinationName = str;
            gclass134.genum13_0 = DestinationType.const_6;
            gclass134.int_0 = gclass233_0.WreckID;
            gclass134.gclass120_0 = null;
            gclass134.gclass202_1 = null;
            gclass134.gclass146_0 = null;
            gclass134.bool_0 = false;
            return gclass134;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 731);
            return null;
        }
    }

    public GClass134 method_276(Waypoint gclass214_0, RacialSystemSurvey gclass202_1)
    {
        try
        {
            return new GClass134()
            {
                gclass202_0 = gclass202_1,
                DestinationName = gclass214_0.method_2(true),
                genum13_0 = DestinationType.const_3,
                int_0 = gclass214_0.WaypointID,
                gclass120_0 = null,
                gclass202_1 = null,
                gclass146_0 = null,
                bool_0 = false
            };
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 732);
            return null;
        }
    }

    public GClass134 method_277(LifePod gclass59_0, RacialSystemSurvey gclass202_1)
    {
        try
        {
            string str = gclass59_0.gclass21_0 != this.Race
                ? string.Format((string)"Life Pods: {0}  ID {1}",
                    (object)this.Race.method_324(gclass59_0.gclass22_0.ShipClassID),
                    (object)gclass59_0.int_0.ToString())
                : string.Format((string)"Life Pods: {0} {1}", (object)gclass59_0.gclass22_0.ShipHull.Abbreviation,
                    (object)gclass59_0.string_0);
            return new GClass134()
            {
                gclass202_0 = gclass202_1,
                DestinationName = str,
                genum13_0 = DestinationType.const_5,
                int_0 = gclass59_0.int_0,
                gclass120_0 = null,
                gclass202_1 = null,
                gclass146_0 = null,
                bool_0 = false
            };
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 733);
            return null;
        }
    }

    public GClass134 method_278(FleetData gclass85_5)
    {
        try
        {
            GClass134 gclass134 = new GClass134();
            gclass134.gclass202_0 = gclass85_5.System;
            gclass134.genum13_0 = DestinationType.const_7;
            gclass134.int_0 = gclass85_5.FleetID;
            gclass134.DestinationName = gclass85_5.CivilianFunction != CivilanFunctionType.const_0 ? "CIV: " : "FLT: ";
            if (gclass85_5.CivilianFunction == CivilanFunctionType.const_3)
                gclass134.DestinationName =
                    string.Format((string)"{0}{1}  ({2}m)", (object)gclass134.DestinationName,
                        (object)gclass85_5.FleetName,
                        (object)AuroraUtils.FormatNumberToDigits(gclass85_5.method_154() / 1000000M, 2));
            else
                gclass134.DestinationName += gclass85_5.FleetName;
            gclass134.gclass120_0 = null;
            gclass134.gclass202_1 = null;
            gclass134.gclass146_0 = null;
            gclass134.bool_0 = false;
            return gclass134;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 734);
            return null;
        }
    }

    public GClass134 method_279(ShipData gclass40_0, RacialSystemSurvey gclass202_1)
    {
        try
        {
            gclass40_0.method_226(gclass202_1.Race, false, 0);
            return new GClass134()
            {
                gclass202_0 = gclass202_1,
                genum13_0 = DestinationType.const_4,
                int_0 = gclass40_0.int_25,
                DestinationName = string.Format((string)"CON: {0}", (object)gclass40_0.string_2),
                gclass120_0 = null,
                gclass202_1 = null,
                gclass146_0 = null,
                bool_0 = false
            };
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 735);
            return null;
        }
    }

    public void method_280(ListView listView_0, bool bool_25)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class1007 class1007 = new FleetData.Class1007();
        // ISSUE: reference to a compiler-generated field
        class1007.gclass85_0 = this;
        try
        {
            listView_0.Items.Clear();
            // ISSUE: reference to a compiler-generated field
            class1007.gclass202_0 = this.method_261();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            List<RacialSystemSurvey> list1 = class1007.gclass202_0.method_13(bool_25, this.bAvoidDanger, this.bAvoidAlienSystem)
                .Where<RacialSystemSurvey>(class1007.method_0).ToList<RacialSystemSurvey>();
            foreach (RacialSystemSurvey gclass202 in list1)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class1008 class1008 = new FleetData.Class1008();
                // ISSUE: reference to a compiler-generated field
                class1008.class1007_0 = class1007;
                // ISSUE: reference to a compiler-generated field
                class1008.gclass202_0 = gclass202;
                // ISSUE: reference to a compiler-generated method
                List<PopulationData> list2 = this.gclass0_0.Populations.Values.Where<PopulationData>(class1008.method_0)
                    .ToList<PopulationData>();
                // ISSUE: reference to a compiler-generated field
                class1008.gclass202_0.decimal_5 = list2.Sum<PopulationData>(gclass146_0 => gclass146_0.decimal_30);
                // ISSUE: reference to a compiler-generated field
                class1008.gclass202_0.int_8 = (int)list2.Sum<PopulationData>(gclass146_0 =>
                    gclass146_0.method_62(AuroraProductionCategory.AutomatedMining));
                // ISSUE: reference to a compiler-generated field
                class1008.gclass202_0.int_9 = (int)list2.Sum<PopulationData>(gclass146_0 =>
                    gclass146_0.method_62(AuroraProductionCategory.Terraforming));
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class1008.gclass202_0.decimal_6 = class1008.gclass202_0.int_8 + list2.Sum<PopulationData>(gclass146_0 =>
                    gclass146_0.method_202(AuroraComponentType.OrbitalMiningModule));
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class1008.gclass202_0.decimal_7 = class1008.gclass202_0.int_9 + list2.Sum<PopulationData>(gclass146_0 =>
                    gclass146_0.method_202(AuroraComponentType.TerraformingModule));
                // ISSUE: reference to a compiler-generated field
                class1008.gclass202_0.int_5 = list2.Sum<PopulationData>(gclass146_0 =>
                    gclass146_0.method_73(AuroraInstallationType.CivilianMiningComplex));
                // ISSUE: reference to a compiler-generated field
                class1008.gclass202_0.decimal_2 = list2.Sum<PopulationData>(gclass146_0 =>
                    gclass146_0.method_62(AuroraProductionCategory.Sensors));
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class1008.gclass202_0.string_3 = class1008.gclass202_0.Name;
                // ISSUE: reference to a compiler-generated field
                if (class1008.gclass202_0.decimal_5 > 0M)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class1008.gclass202_0.string_3 =
                        string.Format((string)"{0}  {1}m", (object)class1008.gclass202_0.string_3,
                            (object)AuroraUtils.FormatNumberToDigits(class1008.gclass202_0.decimal_5, 1));
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    if (class1008.gclass202_0.decimal_6 > 0M)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class1008.gclass202_0.string_3 =
                            string.Format((string)"{0}  {1}x AM", (object)class1008.gclass202_0.string_3,
                                (object)AuroraUtils.smethod_38(class1008.gclass202_0.decimal_6));
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (class1008.gclass202_0.int_5 > 0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class1008.gclass202_0.string_3 =
                                string.Format((string)"{0}  {1}x CMC", (object)class1008.gclass202_0.string_3,
                                    (object)AuroraUtils.smethod_37(class1008.gclass202_0.int_5));
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (class1008.gclass202_0.decimal_7 > 0M)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class1008.gclass202_0.string_3 =
                                    string.Format((string)"{0}  {1}x Terra", (object)class1008.gclass202_0.string_3,
                                        (object)AuroraUtils.smethod_38(class1008.gclass202_0.decimal_7));
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (class1008.gclass202_0.decimal_2 > 0M)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    class1008.gclass202_0.string_3 =
                                        string.Format((string)"{0}  {1}x DST", (object)class1008.gclass202_0.string_3,
                                            (object)AuroraUtils.smethod_38(class1008.gclass202_0.decimal_2));
                                }
                            }
                        }
                    }
                }
            }

            // ISSUE: reference to a compiler-generated method
            foreach (RacialSystemSurvey gclass202 in list1.Where<RacialSystemSurvey>(class1007.method_1)
                         .OrderByDescending<RacialSystemSurvey, Decimal>(gclass202_0 => gclass202_0.decimal_5)
                         .ThenByDescending<RacialSystemSurvey, Decimal>(gclass202_0 => gclass202_0.decimal_6)
                         .ThenByDescending<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.int_5)
                         .ThenByDescending<RacialSystemSurvey, Decimal>(gclass202_0 => gclass202_0.decimal_7)
                         .ThenByDescending<RacialSystemSurvey, Decimal>(gclass202_0 => gclass202_0.decimal_2)
                         .ThenBy<RacialSystemSurvey, string>(gclass202_0 => gclass202_0.string_3).ToList<RacialSystemSurvey>())
            {
                ListViewItem listViewItem = new ListViewItem(gclass202.string_3);
                listViewItem.Tag = gclass202;
                if (gclass202.decimal_5 > 0M)
                    listViewItem.SubItems[0].ForeColor = AuroraUtils.color_2;
                else if (gclass202.decimal_6 > 0M || gclass202.int_5 > 0 || gclass202.decimal_7 > 0M ||
                         gclass202.decimal_2 > 0M)
                    listViewItem.SubItems[0].ForeColor = AuroraUtils.color_15;
                listView_0.Items.Add(listViewItem);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 736);
        }
    }

    public void method_281(
        ListView listView_0,
        CheckBox checkBox_0,
        CheckBox checkBox_1,
        CheckBox checkBox_2,
        CheckBox checkBox_3,
        CheckBox checkBox_4,
        CheckBox checkBox_5,
        CheckBox checkBox_6,
        CheckBox checkBox_7,
        CheckBox checkBox_8,
        CheckBox checkBox_9,
        CheckBox checkBox_10,
        CheckBox checkBox_11,
        CheckBox checkBox_12,
        CheckBox checkBox_13)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class1009 class1009 = new FleetData.Class1009();
        // ISSUE: reference to a compiler-generated field
        class1009.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1009.checkBox_0 = checkBox_3;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            FleetData.Class1010 class1010 = new FleetData.Class1010();
            // ISSUE: reference to a compiler-generated field
            class1010.class1009_0 = class1009;
            this.list_1.Clear();
            // ISSUE: reference to a compiler-generated field
            class1010.gclass202_0 = this.method_261();
            // ISSUE: reference to a compiler-generated method
            foreach (JumpPoint gclass120_1 in this.gclass0_0.JumpPointDictionary.Values
                         .Where<JumpPoint>(class1010.method_0)
                         .OrderBy<JumpPoint, double>(gclass120_0 => gclass120_0.Distance).ToList<JumpPoint>())
            {
                if (gclass120_1.RacialJumpPointSurveys.ContainsKey(this.Race.RaceID) &&
                    gclass120_1.RacialJumpPointSurveys[this.Race.RaceID].Charted == 1)
                {
                    // ISSUE: reference to a compiler-generated field
                    this.list_1.Add(this.method_270(gclass120_1, class1010.gclass202_0));
                }
            }

            // ISSUE: reference to a compiler-generated field
            foreach (LagrangePoint gclass212 in class1010.gclass202_0.ActualSystem.method_29())
            {
                // ISSUE: reference to a compiler-generated field
                this.list_1.Add(new GClass134()
                {
                    gclass202_0 = class1010.gclass202_0,
                    DestinationName = gclass212.method_3(this.Race),
                    genum13_0 = DestinationType.const_8,
                    int_0 = gclass212.LaGrangePointID,
                    gclass120_0 = null,
                    gclass202_1 = null,
                    gclass146_0 = null,
                    bool_0 = false
                });
            }

            // ISSUE: reference to a compiler-generated method
            List<PopulationData> list1 = this.gclass0_0.Populations.Values.Where<PopulationData>(class1010.method_1)
                .ToList<PopulationData>();
            foreach (PopulationData gclass146 in list1)
            {
                int num1 = gclass146.method_73(AuroraInstallationType.AutomatedMine);
                int num2 = gclass146.method_73(AuroraInstallationType.TerraformingInstallation);
                gclass146.decimal_72 = num1 + gclass146.method_202(AuroraComponentType.OrbitalMiningModule);
                gclass146.decimal_73 = num2 + gclass146.method_202(AuroraComponentType.TerraformingModule);
            }

            List<PopulationData> list2 = list1.OrderBy<PopulationData, int>(gclass146_0 => gclass146_0.ProvideColonists)
                .ThenByDescending<PopulationData, Decimal>(gclass146_0 => gclass146_0.decimal_30)
                .ThenByDescending<PopulationData, Decimal>(gclass146_0 => gclass146_0.decimal_72)
                .ThenByDescending<PopulationData,
                    int>(gclass146_0 => gclass146_0.method_73(AuroraInstallationType.CivilianMiningComplex))
                .ThenByDescending<PopulationData, Decimal>(gclass146_0 => gclass146_0.decimal_73)
                .ThenByDescending<PopulationData, int>(gclass146_0 =>
                    gclass146_0.method_73(AuroraInstallationType.TrackingStation))
                .ThenBy<PopulationData, string>(gclass146_0 => gclass146_0.PopName).ToList<PopulationData>();
            foreach (PopulationData gclass146_1 in list2)
                this.list_1.Add(this.method_274(gclass146_1));
            if (checkBox_6.CheckState == CheckState.Checked || checkBox_8.CheckState == CheckState.Checked)
            {
                List<FleetData> gclass85List = null;
                if (checkBox_6.CheckState == CheckState.Checked && checkBox_8.CheckState == CheckState.Checked)
                {
                    // ISSUE: reference to a compiler-generated method
                    gclass85List = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(class1010.method_2)
                        .OrderBy<FleetData, string>(gclass85_0 => gclass85_0.FleetName)
                        .ThenBy<FleetData, string>(gclass85_0 => gclass85_0.FleetName).ToList<FleetData>();
                }

                if (checkBox_6.CheckState == CheckState.Checked && checkBox_8.CheckState == CheckState.Unchecked)
                {
                    // ISSUE: reference to a compiler-generated method
                    gclass85List = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(class1010.method_3)
                        .OrderBy<FleetData, string>(gclass85_0 => gclass85_0.FleetName)
                        .ThenBy<FleetData, string>(gclass85_0 => gclass85_0.FleetName).ToList<FleetData>();
                }

                if (checkBox_6.CheckState == CheckState.Unchecked && checkBox_8.CheckState == CheckState.Checked)
                {
                    // ISSUE: reference to a compiler-generated method
                    gclass85List = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(class1010.method_4)
                        .OrderBy<FleetData, string>(gclass85_0 => gclass85_0.FleetName)
                        .ThenBy<FleetData, string>(gclass85_0 => gclass85_0.FleetName).ToList<FleetData>();
                }

                foreach (FleetData gclass85_5 in gclass85List)
                    this.list_1.Add(this.method_278(gclass85_5));
            }

            if (checkBox_7.CheckState == CheckState.Checked)
            {
                // ISSUE: reference to a compiler-generated method
                foreach (ShipData gclass40_0 in this.gclass0_0.Ships.Values
                             .Where<ShipData>(class1010.method_5)
                             .OrderBy<ShipData, string>(gclass40_0 => gclass40_0.ShipName).ToList<ShipData>())
                {
                    if (checkBox_11.CheckState != CheckState.Checked
                            ? this.gclass0_0.method_558(this.Race, AuroraContactType.Ship, gclass40_0.int_8)
                            : this.gclass0_0.method_559(this.Race, AuroraContactType.Ship, gclass40_0.int_8))
                    {
                        // ISSUE: reference to a compiler-generated field
                        this.list_1.Add(this.method_279(gclass40_0, class1010.gclass202_0));
                    }
                }

                // ISSUE: reference to a compiler-generated method
                foreach (PopulationData gclass146 in this.gclass0_0.Populations.Values.Where<PopulationData>(class1010.method_6)
                             .OrderBy<PopulationData, string>(gclass146_0 => gclass146_0.PopName).ToList<PopulationData>())
                {
                    if (this.gclass0_0.method_558(this.Race, AuroraContactType.Population, gclass146.PopulationID))
                    {
                        gclass146.method_80(this.Race);
                        // ISSUE: reference to a compiler-generated field
                        this.list_1.Add(new GClass134()
                        {
                            gclass202_0 = class1010.gclass202_0,
                            genum13_0 = DestinationType.const_4,
                            int_0 = gclass146.int_18,
                            DestinationName = string.Format((string)"CON: {0}", (object)gclass146.string_2),
                            gclass120_0 = null,
                            gclass202_1 = null,
                            gclass146_0 = null,
                            bool_0 = false
                        });
                    }
                }

                // ISSUE: reference to a compiler-generated method
                foreach (MissileSalvo gclass132 in this.gclass0_0.MissileSalvoes.Values.Where<MissileSalvo>(class1010.method_7)
                             .ToList<MissileSalvo>())
                {
                    if (this.gclass0_0.method_558(this.Race, AuroraContactType.Salvo, gclass132.MissileSalvoID))
                    {
                        gclass132.method_18(this.Race, true);
                        // ISSUE: reference to a compiler-generated field
                        this.list_1.Add(new GClass134()
                        {
                            gclass202_0 = class1010.gclass202_0,
                            genum13_0 = DestinationType.const_4,
                            int_0 = gclass132.int_3,
                            DestinationName = string.Format((string)"CON: {0}", (object)gclass132.string_1),
                            gclass120_0 = null,
                            gclass202_1 = null,
                            gclass146_0 = null,
                            bool_0 = false
                        });
                    }
                }

                // ISSUE: reference to a compiler-generated method
                foreach (Contact gclass65 in this.gclass0_0.Contacts.Values.Where<Contact>(class1010.method_8)
                             .OrderBy<Contact, string>(gclass65_0 => gclass65_0.ContactName).ToList<Contact>())
                {
                    // ISSUE: reference to a compiler-generated field
                    this.list_1.Add(new GClass134()
                    {
                        gclass202_0 = class1010.gclass202_0,
                        genum13_0 = DestinationType.const_4,
                        int_0 = gclass65.UniqueID,
                        DestinationName = string.Format((string)"CON: {0}", (object)gclass65.ContactName),
                        gclass120_0 = null,
                        gclass202_1 = null,
                        gclass146_0 = null,
                        bool_0 = false
                    });
                }
            }

            if (checkBox_4.CheckState == CheckState.Checked)
            {
                // ISSUE: reference to a compiler-generated method
                foreach (Waypoint gclass214_0 in this.gclass0_0.Waypoints.Values
                             .Where<Waypoint>(class1010.method_9)
                             .OrderBy<Waypoint, int>(gclass214_0 => gclass214_0.Number).ToList<Waypoint>())
                {
                    // ISSUE: reference to a compiler-generated field
                    this.list_1.Add(this.method_276(gclass214_0, class1010.gclass202_0));
                }
            }

            if (checkBox_5.CheckState == CheckState.Checked)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                foreach (SurveyLocation gclass213_0 in class1010.gclass202_0.ActualSystem.SurveyLocationDictionary
                             .Values.Where<SurveyLocation>(class1010.class1009_0.method_0)
                             .OrderBy<SurveyLocation, int>(gclass213_0 => gclass213_0.LocationNumber)
                             .ToList<SurveyLocation>())
                {
                    // ISSUE: reference to a compiler-generated field
                    this.list_1.Add(this.method_273(gclass213_0, class1010.gclass202_0));
                }
            }

            if (checkBox_9.CheckState == CheckState.Checked)
            {
                // ISSUE: reference to a compiler-generated method
                foreach (Wreck gclass233_0 in this.gclass0_0.Wrecks.Values
                             .Where<Wreck>(class1010.method_10)
                             .OrderByDescending<Wreck, Decimal>(gclass233_0 => gclass233_0.ShipClass.Size)
                             .ThenBy<Wreck, string>(gclass233_0 => gclass233_0.ShipClass.ClassName)
                             .ToList<Wreck>())
                {
                    // ISSUE: reference to a compiler-generated field
                    this.list_1.Add(this.method_275(gclass233_0, class1010.gclass202_0));
                }
            }

            if (checkBox_10.CheckState == CheckState.Checked)
            {
                // ISSUE: reference to a compiler-generated method
                foreach (LifePod gclass59_0 in this.gclass0_0.LifePods.Values.Where<LifePod>(class1010.method_11)
                             .OrderBy<LifePod, string>(gclass59_0 => gclass59_0.string_0).ToList<LifePod>())
                {
                    // ISSUE: reference to a compiler-generated field
                    this.list_1.Add(this.method_277(gclass59_0, class1010.gclass202_0));
                }
            }

            List<SystemBodyData> list3 = list2
                .Select<PopulationData, SystemBodyData>(gclass146_0 => gclass146_0.SystemBodyData)
                .ToList<SystemBodyData>();
            List<SystemBodyData> list4 = list2
                .Where<PopulationData>(gclass146_0 => gclass146_0.SystemBodyData.FixedBodyParentData != null)
                .Select<PopulationData, SystemBodyData>(gclass146_0 => gclass146_0.SystemBodyData.FixedBodyParentData)
                .ToList<SystemBodyData>();
            List<SystemBodyData> list_5 = list3;
            List<SystemBodyData> list5 = list2
                .Select<PopulationData, SystemBodyData>(gclass146_0 => gclass146_0.SystemBodyData)
                .Where<SystemBodyData>(gclass1_0 => gclass1_0.BodyClass == PlanetBodyClass.Moon)
                .ToList<SystemBodyData>();
            if (checkBox_0.CheckState == CheckState.Checked)
            {
                // ISSUE: reference to a compiler-generated method
                List<SystemBodyData> list6 = this.gclass0_0.SystemBodyRecordDic.Values
                    .Where<SystemBodyData>(class1010.method_12).Except<SystemBodyData>(list5)
                    .Select<SystemBodyData, SystemBodyData>(gclass1_0 => gclass1_0.ParentBodyData)
                    .ToList<SystemBodyData>();
                list3 = list2.Select<PopulationData, SystemBodyData>(gclass146_0 => gclass146_0.SystemBodyData)
                    .Except<SystemBodyData>(list6).ToList<SystemBodyData>();
            }

            if (checkBox_12.CheckState == CheckState.Checked || checkBox_13.CheckState == CheckState.Checked)
            {
                List<SystemBodyData> list_4 = null;
                if (checkBox_12.CheckState == CheckState.Checked && checkBox_13.CheckState == CheckState.Checked)
                {
                    // ISSUE: reference to a compiler-generated method
                    list_4 = this.gclass0_0.SystemBodyRecordDic.Values
                        .Where<SystemBodyData>(class1010.method_13).Except<SystemBodyData>(list3)
                        .OrderBy<SystemBodyData, int>(gclass1_0 => gclass1_0.StarData.Component)
                        .ThenBy<SystemBodyData, int>(gclass1_0 => gclass1_0.PlanetNumber)
                        .ToList<SystemBodyData>();
                }
                else if (checkBox_12.CheckState == CheckState.Checked && checkBox_13.CheckState == CheckState.Unchecked)
                {
                    // ISSUE: reference to a compiler-generated method
                    list_4 = this.gclass0_0.SystemBodyRecordDic.Values
                        .Where<SystemBodyData>(class1010.method_14).Except<SystemBodyData>(list3)
                        .OrderBy<SystemBodyData, int>(gclass1_0 => gclass1_0.StarData.Component)
                        .ThenBy<SystemBodyData, int>(gclass1_0 => gclass1_0.PlanetNumber)
                        .ToList<SystemBodyData>();
                }
                else if (checkBox_12.CheckState == CheckState.Unchecked && checkBox_13.CheckState == CheckState.Checked)
                {
                    // ISSUE: reference to a compiler-generated method
                    list_4 = this.gclass0_0.SystemBodyRecordDic.Values
                        .Where<SystemBodyData>(class1010.method_15).Except<SystemBodyData>(list3)
                        .OrderBy<SystemBodyData, int>(gclass1_0 => gclass1_0.StarData.Component)
                        .ThenBy<SystemBodyData, int>(gclass1_0 => gclass1_0.PlanetNumber)
                        .ToList<SystemBodyData>();
                }

                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.method_294(list_4, list_5, list4, class1010.gclass202_0, checkBox_0.CheckState, false,
                    class1010.class1009_0.checkBox_0);
            }

            if (checkBox_1.CheckState == CheckState.Checked)
            {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.method_294(
                    this.gclass0_0.SystemBodyRecordDic.Values.Where<SystemBodyData>(class1010.method_16)
                        .Except<SystemBodyData>(list3)
                        .OrderBy<SystemBodyData, int>(gclass1_0 => gclass1_0.StarData.Component)
                        .ThenBy<SystemBodyData, string>(class1010.class1009_0.method_1)
                        .ToList<SystemBodyData>(), list_5, list4, class1010.gclass202_0, CheckState.Unchecked,
                    false, class1010.class1009_0.checkBox_0);
            }

            if (checkBox_2.CheckState == CheckState.Checked)
            {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.method_294(
                    this.gclass0_0.SystemBodyRecordDic.Values.Where<SystemBodyData>(class1010.method_17)
                        .Except<SystemBodyData>(list3)
                        .OrderBy<SystemBodyData, int>(gclass1_0 => gclass1_0.StarData.Component)
                        .ThenBy<SystemBodyData, int>(gclass1_0 => gclass1_0.OrbitNumber)
                        .ToList<SystemBodyData>(), list_5, list4, class1010.gclass202_0, CheckState.Unchecked,
                    false, class1010.class1009_0.checkBox_0);
            }

            listView_0.Items.Clear();
            foreach (GClass134 gclass134 in this.list_1)
            {
                ListViewItem listViewItem = new ListViewItem(gclass134.DestinationName);
                listViewItem.Tag = gclass134;
                if (gclass134.genum13_0 == DestinationType.const_1 && gclass134.gclass146_0 != null)
                    listViewItem.SubItems[0].ForeColor = !(gclass134.gclass146_0.decimal_30 > 0M)
                        ? (gclass134.gclass146_0.method_62(AuroraProductionCategory.AutomatedMining) > 0M ||
                           gclass134.gclass146_0.method_62(AuroraProductionCategory.CivilianMining) > 0M
                            ? AuroraUtils.color_15
                            : AuroraUtils.color_13)
                        : AuroraUtils.color_2;
                if (gclass134.genum13_0 == DestinationType.const_10 && gclass134.gclass146_0 != null)
                    listViewItem.SubItems[0].ForeColor = !(gclass134.gclass146_0.decimal_30 > 0M)
                        ? AuroraUtils.color_13
                        : AuroraUtils.color_2;
                else if (gclass134.genum13_0 == DestinationType.const_3)
                    listViewItem.SubItems[0].ForeColor = Color.Violet;
                else if (gclass134.genum13_0 == DestinationType.const_0)
                    listViewItem.SubItems[0].ForeColor = Color.Orange;
                else if (gclass134.genum13_0 == DestinationType.const_1 && gclass134.bool_1)
                    listViewItem.SubItems[0].ForeColor = AuroraUtils.color_14;
                listView_0.Items.Add(listViewItem);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 737);
        }
    }

    public void method_282(GClass134 gclass134_0, ListView listView_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class1011 class1011 = new FleetData.Class1011();
        // ISSUE: reference to a compiler-generated field
        class1011.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1011.gclass134_0 = gclass134_0;
        try
        {
            List<MoveActionDefinition> gclass133List = null;
            List<MoveActionDefinition> collection = new List<MoveActionDefinition>();
            // ISSUE: reference to a compiler-generated field
            switch (class1011.gclass134_0.genum13_0)
            {
                case DestinationType.const_0:
                    gclass133List = this.gclass0_0.MoveActionDictionary.Values
                        .Where<MoveActionDefinition>(gclass133_0 => gclass133_0.WarpPoint)
                        .OrderBy<MoveActionDefinition, int>(gclass133_0 => gclass133_0.DisplayOrder).ToList<MoveActionDefinition>();
                    break;
                case DestinationType.const_1:
                    gclass133List = this.gclass0_0.MoveActionDictionary.Values
                        .Where<MoveActionDefinition>(gclass133_0 => gclass133_0.SystemBody)
                        .OrderBy<MoveActionDefinition, int>(gclass133_0 => gclass133_0.DisplayOrder).ToList<MoveActionDefinition>();
                    break;
                case DestinationType.const_2:
                    gclass133List = this.gclass0_0.MoveActionDictionary.Values
                        .Where<MoveActionDefinition>(gclass133_0 => gclass133_0.SurveyLocation)
                        .OrderBy<MoveActionDefinition, int>(gclass133_0 => gclass133_0.DisplayOrder).ToList<MoveActionDefinition>();
                    break;
                case DestinationType.const_3:
                    gclass133List = this.gclass0_0.MoveActionDictionary.Values
                        .Where<MoveActionDefinition>(gclass133_0 => gclass133_0.Waypoint)
                        .OrderBy<MoveActionDefinition, int>(gclass133_0 => gclass133_0.DisplayOrder).ToList<MoveActionDefinition>();
                    break;
                case DestinationType.const_4:
                    gclass133List = this.gclass0_0.MoveActionDictionary.Values
                        .Where<MoveActionDefinition>(gclass133_0 => gclass133_0.Contact)
                        .OrderBy<MoveActionDefinition, int>(gclass133_0 => gclass133_0.DisplayOrder).ToList<MoveActionDefinition>();
                    break;
                case DestinationType.const_5:
                    gclass133List = this.gclass0_0.MoveActionDictionary.Values
                        .Where<MoveActionDefinition>(gclass133_0 => gclass133_0.Lifepod)
                        .OrderBy<MoveActionDefinition, int>(gclass133_0 => gclass133_0.DisplayOrder).ToList<MoveActionDefinition>();
                    break;
                case DestinationType.const_6:
                    gclass133List = this.gclass0_0.MoveActionDictionary.Values
                        .Where<MoveActionDefinition>(gclass133_0 => gclass133_0.Wreck)
                        .OrderBy<MoveActionDefinition, int>(gclass133_0 => gclass133_0.DisplayOrder).ToList<MoveActionDefinition>();
                    break;
                case DestinationType.const_7:
                    gclass133List = this.gclass0_0.MoveActionDictionary.Values
                        .Where<MoveActionDefinition>(gclass133_0 => gclass133_0.Fleet)
                        .OrderBy<MoveActionDefinition, int>(gclass133_0 => gclass133_0.DisplayOrder).ToList<MoveActionDefinition>();
                    break;
                case DestinationType.const_8:
                    gclass133List = this.gclass0_0.MoveActionDictionary.Values
                        .Where<MoveActionDefinition>(gclass133_0 => gclass133_0.LagrangePoint)
                        .OrderBy<MoveActionDefinition, int>(gclass133_0 => gclass133_0.DisplayOrder).ToList<MoveActionDefinition>();
                    break;
                case DestinationType.const_10:
                    gclass133List = this.gclass0_0.MoveActionDictionary.Values
                        .Where<MoveActionDefinition>(gclass133_0 => gclass133_0.DeepSpaceLocation)
                        .OrderBy<MoveActionDefinition, int>(gclass133_0 => gclass133_0.DisplayOrder).ToList<MoveActionDefinition>();
                    break;
            }

            this.method_268();
            foreach (MoveActionDefinition gclass133 in gclass133List)
            {
                switch (gclass133.MoveRequirementID)
                {
                    case GEnum124.const_8:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.gclass0_0.FleetDictionary.ContainsKey(class1011.gclass134_0.int_0) &&
                            this.gclass0_0.FleetDictionary[class1011.gclass134_0.int_0].method_129(this))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_18:
                        // ISSUE: reference to a compiler-generated field
                        if (class1011.gclass134_0.gclass146_0 != null)
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (class1011.gclass134_0.gclass146_0.method_62(
                                    AuroraProductionCategory.MaintenanceFacility) >= 1M)
                            {
                                collection.Add(gclass133);
                                continue;
                            }

                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            if (this.gclass0_0.FleetDictionary.Values
                                    .Where<FleetData>(class1011.func_1 ?? (class1011.func_1 = class1011.method_1))
                                    .Sum<FleetData>(gclass85_0 =>
                                        gclass85_0.method_127(AuroraComponentType.MaintenanceModule)) > 0)
                            {
                                collection.Add(gclass133);
                                continue;
                            }

                            continue;
                        }

                        // ISSUE: reference to a compiler-generated field
                        if (class1011.gclass134_0.genum13_0 == DestinationType.const_7)
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (this.gclass0_0.FleetDictionary.ContainsKey(class1011.gclass134_0.int_0))
                            {
                                // ISSUE: reference to a compiler-generated field
                                FleetData gclass85 = this.gclass0_0.FleetDictionary[class1011.gclass134_0.int_0];
                                if (gclass85.AssignedPopulation != null &&
                                    gclass85.AssignedPopulation.method_62(AuroraProductionCategory.MaintenanceFacility) >= 1M)
                                {
                                    collection.Add(gclass133);
                                    continue;
                                }

                                continue;
                            }

                            continue;
                        }

                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.gclass0_0.FleetDictionary.ContainsKey(class1011.gclass134_0.int_0) && this.gclass0_0
                                .FleetDictionary[class1011.gclass134_0.int_0]
                                .method_125(AuroraComponentType.MaintenanceModule) > 0M)
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_22:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.gclass0_0.FleetDictionary.ContainsKey(class1011.gclass134_0.int_0) &&
                            this.gclass0_0.FleetDictionary[class1011.gclass134_0.int_0].method_139())
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_24:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.list_2.Contains(GEnum124.const_24) && class1011.gclass134_0.gclass146_0 != null &&
                            class1011.gclass134_0.gclass146_0.decimal_30 > 1M &&
                            class1011.gclass134_0.gclass146_0.PopulationPoliticalStatus.PoliticalStatusType == PopPoliticalStatusType.ImperialPopulation)
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_25:
                        // ISSUE: reference to a compiler-generated field
                        if (class1011.gclass134_0.gclass146_0 != null && this.list_2.Contains(GEnum124.const_25) &&
                            (this.method_124(GEnum26.const_3) ||
                             this.method_265(this.gclass0_0.MoveActionDictionary[MoveActionType.LoadGroundUnitIntoTransportBay])))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_26:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.gclass0_0.FleetDictionary.ContainsKey(class1011.gclass134_0.int_0) &&
                            (this.gclass0_0.FleetDictionary[class1011.gclass134_0.int_0]
                                .method_125(AuroraComponentType.HangarDeck) > 0M || this.gclass0_0
                                .FleetDictionary[class1011.gclass134_0.int_0]
                                .method_125(AuroraComponentType.CommercialHangarDeck) > 0M))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_28:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        if (class1011.gclass134_0.gclass146_0 != null &&
                            this.gclass0_0.Shipyards.Values
                                .Where<Shipyard>(class1011.func_3 ?? (class1011.func_3 = class1011.method_3))
                                .Count<Shipyard>() > 0 && this.list_2.Contains(GEnum124.const_27))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_29:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.list_2.Contains(GEnum124.const_29) && class1011.gclass134_0.gclass146_0 != null &&
                            class1011.gclass134_0.gclass146_0.decimal_30 > 1M)
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_32:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.list_2.Contains(GEnum124.const_4) && class1011.gclass134_0.gclass146_0 != null &&
                            class1011.gclass134_0.gclass146_0.dictionary_0.Count > 0 &&
                            (class1011.gclass134_0.gclass146_0.method_62(AuroraProductionCategory.CargoShuttles) >=
                                1M || this.list_2.Contains(GEnum124.const_55)))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_33:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.list_2.Contains(GEnum124.const_1) && class1011.gclass134_0.gclass146_0 != null &&
                            class1011.gclass134_0.gclass146_0.Population > 0M &&
                            (class1011.gclass134_0.gclass146_0.method_62(AuroraProductionCategory.CargoShuttles) >=
                             1M || this.list_2.Contains(GEnum124.const_54) ||
                             this.list_2.Contains(GEnum124.const_68)))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_34:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.list_2.Contains(GEnum124.const_4) && class1011.gclass134_0.gclass146_0 != null &&
                            class1011.gclass134_0.gclass146_0.CurrentMinerals.HasAnyPositiveMineralValue() &&
                            (class1011.gclass134_0.gclass146_0.method_62(AuroraProductionCategory.CargoShuttles) >=
                                1M || this.list_2.Contains(GEnum124.const_55)))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_35:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class1011.gclass134_0.gclass146_0 != null && this.list_2.Contains(GEnum124.const_4) &&
                            (this.method_124(GEnum26.const_1) ||
                             this.method_265(this.gclass0_0.MoveActionDictionary[MoveActionType.LoadInstallation])) &&
                            (class1011.gclass134_0.gclass146_0.method_62(AuroraProductionCategory.CargoShuttles) >=
                             1M || this.list_2.Contains(GEnum124.const_55) ||
                             this.list_2.Contains(GEnum124.const_68)))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_36:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class1011.gclass134_0.gclass146_0 != null && this.list_2.Contains(GEnum124.const_4) &&
                            (this.method_124(GEnum26.const_2) ||
                             this.method_265(this.gclass0_0.MoveActionDictionary[MoveActionType.LoadMineralType]) ||
                             this.method_265(this.gclass0_0.MoveActionDictionary[MoveActionType.LoadAllMinerals]) ||
                             this.method_265(this.gclass0_0.MoveActionDictionary[MoveActionType.LoadAllMineralsUntilFull])) &&
                            (class1011.gclass134_0.gclass146_0.method_62(AuroraProductionCategory.CargoShuttles) >=
                             1M || this.list_2.Contains(GEnum124.const_55) ||
                             this.list_2.Contains(GEnum124.const_68)))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_37:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class1011.gclass134_0.gclass146_0 != null && this.list_2.Contains(GEnum124.const_1) &&
                            (this.method_124(GEnum26.const_0) ||
                             this.method_265(this.gclass0_0.MoveActionDictionary[MoveActionType.LoadColonists])) &&
                            (class1011.gclass134_0.gclass146_0.method_62(AuroraProductionCategory.CargoShuttles) >=
                             1M || this.list_2.Contains(GEnum124.const_54) ||
                             this.list_2.Contains(GEnum124.const_68)))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_38:
                        // ISSUE: reference to a compiler-generated field
                        if (class1011.gclass134_0.gclass146_0 != null && this.list_2.Contains(GEnum124.const_10) &&
                            (this.method_124(GEnum26.const_3) ||
                             this.method_265(this.gclass0_0.MoveActionDictionary[MoveActionType.LoadGroundUnitIntoTransportBay])))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_39:
                        if (this.list_2.Contains(GEnum124.const_27) && (this.list_2.Contains(GEnum124.const_39) ||
                                                                        this.method_265(
                                                                            this.gclass0_0.MoveActionDictionary[
                                                                                MoveActionType.TractorSpecifiedShip]) ||
                                                                        this.method_265(
                                                                            this.gclass0_0.MoveActionDictionary[
                                                                                MoveActionType.TractorAnyShipInFleet])))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_40:
                        if (this.list_2.Contains(GEnum124.const_27) && (this.list_2.Contains(GEnum124.const_40) ||
                                                                        this.method_265(
                                                                            this.gclass0_0.MoveActionDictionary[
                                                                                MoveActionType.TractorSpecifiedShipyard])))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_41:
                        if (this.list_2.Contains(GEnum124.const_41))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_42:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        if (class1011.gclass134_0.gclass146_0 != null && this.gclass0_0.ActiveCommanders.Values
                                .Where<Commander>(class1011.func_4 ?? (class1011.func_4 = class1011.method_4))
                                .Count<Commander>() > 0)
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_44:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.list_2.Contains(GEnum124.const_4) && class1011.gclass134_0.gclass146_0 != null &&
                            class1011.gclass134_0.gclass146_0.StoredComponents.Count > 0 &&
                            (class1011.gclass134_0.gclass146_0.method_62(AuroraProductionCategory.CargoShuttles) >=
                                1M || this.list_2.Contains(GEnum124.const_55)))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_45:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class1011.gclass134_0.gclass146_0 != null && this.list_2.Contains(GEnum124.const_4) &&
                            (this.method_124(GEnum26.const_4) ||
                             this.method_265(this.gclass0_0.MoveActionDictionary[MoveActionType.LoadShipComponent])) &&
                            (class1011.gclass134_0.gclass146_0.method_62(AuroraProductionCategory.CargoShuttles) >=
                             1M || this.list_2.Contains(GEnum124.const_55) ||
                             this.list_2.Contains(GEnum124.const_68)))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_46:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.gclass0_0.FleetDictionary.ContainsKey(class1011.gclass134_0.int_0) && this.gclass0_0
                                .FleetDictionary[class1011.gclass134_0.int_0].method_125(AuroraComponentType.CargoHold) >
                            0M)
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_47:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class1011.gclass134_0.gclass146_0 != null &&
                            class1011.gclass134_0.gclass146_0.method_62(AuroraProductionCategory.RefuellingPoint) >= 1M)
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_48:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class1011.gclass134_0.gclass146_0 != null &&
                            class1011.gclass134_0.gclass146_0.method_62(AuroraProductionCategory.RefuellingPoint) >=
                            1M && this.method_129(null))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_49:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.gclass0_0.FleetDictionary.ContainsKey(class1011.gclass134_0.int_0) &&
                            this.gclass0_0.FleetDictionary[class1011.gclass134_0.int_0].method_132())
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_50:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.gclass0_0.FleetDictionary.ContainsKey(class1011.gclass134_0.int_0) &&
                            this.gclass0_0.FleetDictionary[class1011.gclass134_0.int_0].method_132() &&
                            this.method_129(this))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_51:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.gclass0_0.FleetDictionary.ContainsKey(class1011.gclass134_0.int_0) &&
                            this.gclass0_0.FleetDictionary[class1011.gclass134_0.int_0].method_133() && this.method_131())
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_52:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class1011.gclass134_0.gclass146_0 != null &&
                            class1011.gclass134_0.gclass146_0.method_62(AuroraProductionCategory
                                .OrdnanceTransferPoint) >= 1M && this.method_131())
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_53:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.gclass0_0.FleetDictionary.ContainsKey(class1011.gclass134_0.int_0) &&
                            this.gclass0_0.FleetDictionary[class1011.gclass134_0.int_0].method_132() && this.method_130())
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_56:
                        // ISSUE: reference to a compiler-generated field
                        if (class1011.gclass134_0.gclass146_0 != null)
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_57:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.list_2.Contains(GEnum124.const_4) && class1011.gclass134_0.gclass146_0 != null &&
                            (class1011.gclass134_0.gclass146_0.method_62(AuroraProductionCategory.CargoShuttles) >=
                                1M || this.list_2.Contains(GEnum124.const_55)))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_58:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class1011.gclass134_0.gclass146_0 != null &&
                            class1011.gclass134_0.gclass146_0.method_62(AuroraProductionCategory
                                .OrdnanceTransferPoint) >= 1M &&
                            class1011.gclass134_0.gclass146_0.method_62(AuroraProductionCategory.RefuellingPoint) >=
                            1M && this.method_131())
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_61:
                        // ISSUE: reference to a compiler-generated field
                        if (this.list_2.Contains(GEnum124.const_61) && class1011.gclass134_0.gclass146_0 != null)
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_62:
                        // ISSUE: reference to a compiler-generated field
                        if (this.list_2.Contains(GEnum124.const_62) && class1011.gclass134_0.gclass146_0 != null)
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_63:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.list_2.Contains(GEnum124.const_63) &&
                            class1011.gclass134_0.genum13_0 == DestinationType.const_4 &&
                            this.gclass0_0.Contacts.ContainsKey(class1011.gclass134_0.int_0))
                        {
                            // ISSUE: reference to a compiler-generated field
                            Contact gclass65 = this.gclass0_0.Contacts[class1011.gclass134_0.int_0];
                            if (gclass65.ContactType == AuroraContactType.Ship &&
                                gclass65.ContactRace.SpecialNPRID != SpecialNPRIDs.StarSwarm)
                            {
                                collection.Add(gclass133);
                                continue;
                            }

                            continue;
                        }

                        continue;
                    case GEnum124.const_64:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        if (this.list_2.Contains(GEnum124.const_12) &&
                            class1011.gclass134_0.genum13_0 == DestinationType.const_1 &&
                            this.gclass0_0.SystemBodyRecordDic[class1011.gclass134_0.int_0].Mass >= 0.25 &&
                            (this.gclass0_0.SystemBodyRecordDic[class1011.gclass134_0.int_0].BodyClass ==
                             PlanetBodyClass.Planet ||
                             this.gclass0_0.SystemBodyRecordDic[class1011.gclass134_0.int_0].BodyClass ==
                             PlanetBodyClass.Moon) &&
                            this.gclass0_0.LagrangePoints.Values.FirstOrDefault<LagrangePoint>(class1011.func_0 ??
                                (class1011.func_0 = class1011.method_0)) == null)
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_65:
                        // ISSUE: reference to a compiler-generated field
                        if (class1011.gclass134_0.gclass146_0 != null)
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (class1011.gclass134_0.gclass146_0.method_62(
                                    AuroraProductionCategory.MaintenanceFacility) >= 1M)
                            {
                                collection.Add(gclass133);
                                continue;
                            }

                            // ISSUE: reference to a compiler-generated field
                            if (class1011.gclass134_0.gclass146_0.method_62(AuroraProductionCategory.CargoShuttles) >=
                                1M)
                            {
                                collection.Add(gclass133);
                                continue;
                            }

                            if (!this.list_2.Contains(GEnum124.const_67) && !this.list_2.Contains(GEnum124.const_68))
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated method
                                if (this.gclass0_0.FleetDictionary.Values
                                        .Where<FleetData>(class1011.func_2 ?? (class1011.func_2 = class1011.method_2))
                                        .Sum<FleetData>(gclass85_0 =>
                                            gclass85_0.method_127(AuroraComponentType.MaintenanceModule)) > 0)
                                {
                                    collection.Add(gclass133);
                                    continue;
                                }

                                continue;
                            }

                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_66:
                        // ISSUE: reference to a compiler-generated field
                        if (class1011.gclass134_0.gclass146_0 != null && this.list_2.Contains(GEnum124.const_10))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_69:
                        if (this.list_2.Contains(GEnum124.const_61))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_70:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (this.list_2.Contains(GEnum124.const_4) &&
                            this.gclass0_0.FleetDictionary.ContainsKey(class1011.gclass134_0.int_0) && this.gclass0_0
                                .FleetDictionary[class1011.gclass134_0.int_0].method_125(AuroraComponentType.CargoHold) >
                            0M)
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    case GEnum124.const_71:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if ((this.method_124(GEnum26.const_1) ||
                             this.method_265(this.gclass0_0.MoveActionDictionary[MoveActionType.LoadInstallation])) &&
                            this.gclass0_0.FleetDictionary.ContainsKey(class1011.gclass134_0.int_0) && this.gclass0_0
                                .FleetDictionary[class1011.gclass134_0.int_0].method_125(AuroraComponentType.CargoHold) >
                            0M)
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                    default:
                        if (gclass133.MoveRequirementID == GEnum124.const_0 || this.list_2.Contains(gclass133.MoveRequirementID))
                        {
                            collection.Add(gclass133);
                            continue;
                        }

                        continue;
                }
            }

            foreach (MoveActionDefinition gclass133 in new List<MoveActionDefinition>(collection))
            {
                // ISSUE: reference to a compiler-generated field
                if (gclass133.NoGasGiants && class1011.gclass134_0.bool_0)
                    collection.Remove(gclass133);
                if (gclass133.DesignModeOnly)
                    collection.Remove(gclass133);
            }

            listView_0.Items.Clear();
            foreach (MoveActionDefinition gclass133 in collection)
                listView_0.Items.Add(new ListViewItem(gclass133.Description)
                {
                    Tag = gclass133
                });
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 738);
        }
    }

    public void method_283(DestinationItemType genum125_0, GClass134 gclass134_0, ListView listView_0)
    {
        try
        {
            switch (genum125_0)
            {
                case DestinationItemType.const_1:
                    if (gclass134_0.gclass146_0 != null)
                    {
                        listView_0.Columns[0].Width = 360;
                        listView_0.Columns[1].Width = 75;
                        listView_0.Columns[1].TextAlign = HorizontalAlignment.Right;
                        gclass134_0.gclass146_0.CurrentMinerals.method_28(listView_0);
                        break;
                    }

                    this.gclass0_0.method_594(listView_0, "Destination is not a population");
                    break;
                case DestinationItemType.const_2:
                    if (gclass134_0.gclass146_0 != null)
                    {
                        listView_0.Columns[0].Width = 360;
                        listView_0.Columns[1].Width = 75;
                        listView_0.Columns[1].TextAlign = HorizontalAlignment.Right;
                        gclass134_0.gclass146_0.method_72(listView_0, true);
                        break;
                    }

                    this.gclass0_0.method_594(listView_0, "Destination is not a population");
                    break;
                case DestinationItemType.const_3:
                    if (gclass134_0.gclass146_0 != null)
                    {
                        listView_0.Columns[0].Width = 340;
                        listView_0.Columns[1].Width = 95;
                        gclass134_0.gclass146_0.method_175(listView_0);
                        break;
                    }

                    this.gclass0_0.method_594(listView_0, "Destination is not a population");
                    break;
                case DestinationItemType.const_4:
                    if (gclass134_0.genum13_0 == DestinationType.const_7)
                    {
                        listView_0.Columns[0].Width = 360;
                        listView_0.Columns[1].Width = 75;
                        listView_0.Columns[1].TextAlign = HorizontalAlignment.Right;
                        this.gclass0_0.FleetDictionary[gclass134_0.int_0].method_291(listView_0);
                        break;
                    }

                    this.gclass0_0.method_594(listView_0, "Destination is not a fleet");
                    break;
                case DestinationItemType.const_5:
                    listView_0.Columns[0].Width = 360;
                    listView_0.Columns[1].Width = 75;
                    listView_0.Columns[1].TextAlign = HorizontalAlignment.Right;
                    this.method_284(listView_0);
                    break;
                case DestinationItemType.const_6:
                    listView_0.Columns[0].Width = 435;
                    listView_0.Columns[1].Width = 0;
                    this.method_293(listView_0);
                    break;
                case DestinationItemType.const_7:
                    if (gclass134_0.genum13_0 == DestinationType.const_7)
                    {
                        listView_0.Columns[0].Width = 435;
                        listView_0.Columns[1].Width = 0;
                        this.gclass0_0.FleetDictionary[gclass134_0.int_0].method_288(listView_0, false);
                        break;
                    }

                    this.gclass0_0.method_594(listView_0, "Destination is not a fleet");
                    break;
                case DestinationItemType.const_8:
                    if (gclass134_0.genum13_0 == DestinationType.const_7)
                    {
                        listView_0.Columns[0].Width = 435;
                        listView_0.Columns[1].Width = 0;
                        this.gclass0_0.FleetDictionary[gclass134_0.int_0].method_288(listView_0, true);
                        break;
                    }

                    this.gclass0_0.method_594(listView_0, "Destination is not a fleet");
                    break;
                case DestinationItemType.const_9:
                    if (gclass134_0.genum13_0 == DestinationType.const_8)
                    {
                        listView_0.Columns[0].Width = 435;
                        listView_0.Columns[1].Width = 0;
                        this.gclass0_0.LagrangePoints[gclass134_0.int_0].method_4(listView_0, this.Race);
                        break;
                    }

                    this.gclass0_0.method_594(listView_0, "Destination is not a Lagrange Point");
                    break;
                case DestinationItemType.const_10:
                    if (gclass134_0.gclass146_0 != null)
                    {
                        listView_0.Columns[0].Width = 360;
                        listView_0.Columns[1].Width = 75;
                        listView_0.Columns[1].TextAlign = HorizontalAlignment.Right;
                        gclass134_0.gclass146_0.method_70(listView_0);
                        break;
                    }

                    this.gclass0_0.method_594(listView_0, "Destination is not a population");
                    break;
                case DestinationItemType.const_11:
                    if (gclass134_0.gclass146_0 != null)
                    {
                        listView_0.Columns[0].Width = 340;
                        listView_0.Columns[1].Width = 95;
                        listView_0.Columns[1].TextAlign = HorizontalAlignment.Right;
                        gclass134_0.gclass146_0.method_174(listView_0, true);
                        break;
                    }

                    this.gclass0_0.method_594(listView_0, "Destination is not a population");
                    break;
                case DestinationItemType.const_12:
                    listView_0.Columns[0].Width = 435;
                    listView_0.Columns[1].Width = 0;
                    this.method_287(listView_0);
                    break;
                case DestinationItemType.const_13:
                    listView_0.Columns[0].Width = 435;
                    listView_0.Columns[1].Width = 0;
                    this.method_286(listView_0);
                    break;
                case DestinationItemType.const_14:
                    listView_0.Columns[0].Width = 435;
                    listView_0.Columns[1].Width = 0;
                    this.method_285(listView_0);
                    break;
                case DestinationItemType.const_15:
                    if (gclass134_0.genum13_0 == DestinationType.const_7)
                    {
                        listView_0.Columns[0].Width = 435;
                        listView_0.Columns[1].Width = 0;
                        this.gclass0_0.FleetDictionary[gclass134_0.int_0].method_289(listView_0);
                        break;
                    }

                    this.gclass0_0.method_594(listView_0, "Destination is not a fleet");
                    break;
                case DestinationItemType.const_17:
                    if (gclass134_0.genum13_0 == DestinationType.const_7)
                    {
                        listView_0.Columns[0].Width = 220;
                        listView_0.Columns[1].Width = 215;
                        listView_0.Columns[1].TextAlign = HorizontalAlignment.Left;
                        this.gclass0_0.FleetDictionary[gclass134_0.int_0].method_292(listView_0);
                        break;
                    }

                    this.gclass0_0.method_594(listView_0, "Destination is not a fleet");
                    break;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 739);
        }
    }

    public void method_284(ListView listView_0)
    {
        try
        {
            List<GroundUnitFormationData> list_33 = this.method_290();
            foreach (int key in this.MoveOrderDictionary.Values
                         .Where<MoveOrder>(gclass139_0 => gclass139_0.MoveActionType.LoadGroundUnit)
                         .Select<MoveOrder, int>(gclass139_0 => gclass139_0.DestinationItemID).Distinct<int>().ToList<int>())
            {
                if (this.gclass0_0.FormationDictionary.ContainsKey(key))
                    list_33.Add(this.gclass0_0.FormationDictionary[key]);
            }

            this.gclass0_0.method_420(listView_0, list_33);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 740);
        }
    }

    public void method_285(ListView listView_0)
    {
        try
        {
            List<ShipComponent> list = this.method_176()
                .SelectMany<ShipData, StoredComponent>(gclass40_0 => gclass40_0.TransportedComponents)
                .Select<StoredComponent, ShipComponent>(gclass73_0 => gclass73_0.Component).Distinct<ShipComponent>()
                .ToList<ShipComponent>();
            foreach (int key in this.MoveOrderDictionary.Values
                         .Where<MoveOrder>(gclass139_0 => gclass139_0.MoveActionType.MoveActionType == MoveActionType.LoadShipComponent)
                         .Select<MoveOrder, int>(gclass139_0 => gclass139_0.DestinationItemID).Distinct<int>().ToList<int>())
            {
                if (this.gclass0_0.ComponentDataDictionary.ContainsKey(key))
                    list.Add(this.gclass0_0.ComponentDataDictionary[key]);
            }

            foreach (ShipComponent object_1 in list)
                this.gclass0_0.method_598(listView_0, object_1.Name, "", object_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 741);
        }
    }

    public void method_286(ListView listView_0)
    {
        try
        {
            List<ShipData> gclass40List = this.method_176();
            AllMineralsValue gclass123 = new AllMineralsValue(this.gclass0_0);
            foreach (ShipData gclass40 in gclass40List)
                gclass123.AddMineralsFrom(gclass40.TransportedMineral);
            List<AuroraElement> auroraElementList = gclass123.GetListOfPositiveMinerals();
            if (this.MoveOrderDictionary.Values.Count<MoveOrder>(gclass139_0 =>
                    gclass139_0.MoveActionType.MoveActionType == MoveActionType.LoadAllMinerals ||
                    gclass139_0.MoveActionType.MoveActionType == MoveActionType.LoadAllMineralsUntilFull ||
                    gclass139_0.MoveActionType.MoveActionType == MoveActionType.LoadUnloadMineralsToReserveLevel) > 0)
            {
                foreach (AuroraElement auroraElement in Enum.GetValues(typeof(AuroraElement)))
                {
                    if (!auroraElementList.Contains(auroraElement))
                        auroraElementList.Add(auroraElement);
                }
            }
            else
            {
                foreach (AuroraElement auroraElement in this.MoveOrderDictionary.Values
                             .Where<MoveOrder>(gclass139_0 => gclass139_0.MoveActionType.DestinationItemType == DestinationItemType.const_1)
                             .Select<MoveOrder, int>(gclass139_0 => gclass139_0.DestinationItemID).Distinct<int>().ToList<int>())
                {
                    if (!auroraElementList.Contains(auroraElement))
                        auroraElementList.Add(auroraElement);
                }
            }

            foreach (AuroraElement auroraElement in auroraElementList)
                this.gclass0_0.method_598(listView_0, AuroraUtils.smethod_82(auroraElement), "", auroraElement);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 742);
        }
    }

    public void method_287(ListView listView_0)
    {
        try
        {
            List<PlanetaryInstallationType> list = this.method_176()
                .SelectMany<ShipData, PopulationInstallation>(gclass40_0 => gclass40_0.TransportedInstallations.Values)
                .Select<PopulationInstallation, PlanetaryInstallationType>(gclass158_0 => gclass158_0.InstallationType).Distinct<PlanetaryInstallationType>()
                .ToList<PlanetaryInstallationType>();
            foreach (int key in this.MoveOrderDictionary.Values
                         .Where<MoveOrder>(gclass139_0 => gclass139_0.MoveActionType.MoveActionType == MoveActionType.LoadInstallation)
                         .Select<MoveOrder, int>(gclass139_0 => gclass139_0.DestinationItemID).Distinct<int>().ToList<int>())
            {
                if (this.gclass0_0.InstallationTypes.ContainsKey((AuroraInstallationType)key))
                    list.Add(this.gclass0_0.InstallationTypes[(AuroraInstallationType)key]);
            }

            foreach (PlanetaryInstallationType object_1 in list)
                this.gclass0_0.method_598(listView_0, object_1.Name, "", object_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 743);
        }
    }

    public void method_288(ListView listView_0, bool bool_25)
    {
        try
        {
            foreach (ShipData object_1 in this.method_176())
            {
                if (!bool_25 || object_1.method_167(AuroraComponentType.HangarDeck) > 0 ||
                    object_1.method_167(AuroraComponentType.CommercialHangarDeck) > 0)
                    this.gclass0_0.method_598(listView_0, object_1.method_187(), "", object_1);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 744);
        }
    }

    public void method_289(ListView listView_0)
    {
        try
        {
            foreach (SubFleet object_1 in this.gclass0_0.SubFleetDictionary.Values
                         .Where<SubFleet>(gclass84_0 => gclass84_0.ParentFleet == this).ToList<SubFleet>())
                this.gclass0_0.method_598(listView_0, object_1.SubFleetName, "", object_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 745);
        }
    }

    public List<GroundUnitFormationData> method_290()
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(new FleetData.Class1012()
            {
                list_0 = this.method_176()
            }.method_0).ToList<GroundUnitFormationData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 746);
            return null;
        }
    }

    public void method_291(ListView listView_0)
    {
        try
        {
            List<GroundUnitFormationData> list_33 = this.method_290();
            this.gclass0_0.method_420(listView_0, list_33);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 747);
        }
    }

    public void method_292(ListView listView_0)
    {
        try
        {
            foreach (FCTSquadronData70 object_1 in this.gclass0_0.Ships.Values
                         .SelectMany<ShipData,
                             FCTSquadronData70>(gclass40_0 => gclass40_0.ChildSquadronDictionary.Values)
                         .Where<FCTSquadronData70>(gclass70_0 => gclass70_0.ParentShipData.gclass85_0 == this)
                         .OrderBy<FCTSquadronData70, string>(gclass70_0 => gclass70_0.SquadronName)
                         .ToList<FCTSquadronData70>())
                this.gclass0_0.method_598(listView_0, object_1.SquadronName, object_1.ParentShipData.method_187(),
                    object_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3540);
        }
    }

    public void method_293(ListView listView_0)
    {
        try
        {
            foreach (Commander object_1 in this.method_176()
                         .Select<ShipData, Commander>(gclass40_0 => gclass40_0.method_192(AuroraCommandType.Ship))
                         .Where<Commander>(gclass55_0 => gclass55_0 != null)
                         .OrderBy<Commander, AuroraCommanderType>(gclass55_0 => gclass55_0.CommanderType)
                         .ThenBy<Commander, int>(gclass55_0 => gclass55_0.RacialRank.RankNum)
                         .ThenBy<Commander, int>(gclass55_0 => gclass55_0.Seniority)
                         .ThenBy<Commander, string>(gclass55_0 => gclass55_0.Name).ToList<Commander>())
                this.gclass0_0.method_598(listView_0, object_1.method_38(), "", object_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 748);
        }
    }

    public void method_294(
        List<SystemBodyData> list_4,
        List<SystemBodyData> list_5,
        List<SystemBodyData> list_6,
        RacialSystemSurvey gclass202_1,
        CheckState checkState_1,
        bool bool_25,
        CheckBox checkBox_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        FleetData.Class1013 class1013 = new FleetData.Class1013();
        // ISSUE: reference to a compiler-generated field
        class1013.gclass85_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1013.checkBox_0 = checkBox_0;
        try
        {
            foreach (SystemBodyData gclass1 in list_4)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FleetData.Class1014 class1014 = new FleetData.Class1014();
                // ISSUE: reference to a compiler-generated field
                class1014.class1013_0 = class1013;
                // ISSUE: reference to a compiler-generated field
                class1014.gclass1_0 = gclass1;
                List<SystemBodyData> list_4_1 = new List<SystemBodyData>();
                if (checkState_1 == CheckState.Checked)
                {
                    // ISSUE: reference to a compiler-generated method
                    list_4_1 = this.gclass0_0.SystemBodyRecordDic.Values
                        .Where<SystemBodyData>(class1014.method_0).Except<SystemBodyData>(list_5)
                        .OrderBy<SystemBodyData, int>(gclass1_0 => gclass1_0.StarData.Component)
                        .ThenBy<SystemBodyData, int>(gclass1_0 => gclass1_0.PlanetNumber)
                        .ThenBy<SystemBodyData, double>(gclass1_0 => gclass1_0.OrbitalDistance)
                        .ToList<SystemBodyData>();
                }

                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (!class1014.gclass1_0.method_77(this.Race) ||
                    class1014.class1013_0.checkBox_0.CheckState != CheckState.Checked || list_4_1.Count != 0)
                {
                    GClass134 gclass134 = new GClass134();
                    gclass134.gclass202_0 = gclass202_1;
                    // ISSUE: reference to a compiler-generated field
                    gclass134.DestinationName = class1014.gclass1_0.method_78(this.Race);
                    gclass134.genum13_0 = DestinationType.const_1;
                    // ISSUE: reference to a compiler-generated field
                    gclass134.int_0 = class1014.gclass1_0.SystemBodyID;
                    gclass134.gclass120_0 = null;
                    gclass134.gclass146_0 = null;
                    gclass134.gclass202_1 = null;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass134.bool_0 = class1014.gclass1_0.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                                       class1014.gclass1_0.BodyTypeId == AuroraSystemBodyType.Superjovian;
                    // ISSUE: reference to a compiler-generated field
                    if (list_5.Contains(class1014.gclass1_0))
                        gclass134.bool_1 = true;
                    // ISSUE: reference to a compiler-generated field
                    if (list_6.Contains(class1014.gclass1_0))
                        gclass134.DestinationName += " (Planet)";
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class1014.gclass1_0.method_77(this.Race) &&
                        class1014.class1013_0.checkBox_0.CheckState == CheckState.Checked)
                        gclass134.bool_1 = true;
                    if (bool_25)
                    {
                        // ISSUE: reference to a compiler-generated field
                        gclass134.DestinationName = string.Format((string)"    {0}",
                            (object)class1014.gclass1_0.method_78(this.Race));
                    }

                    this.list_1.Add(gclass134);
                    if (list_4_1.Count > 0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        this.method_294(list_4_1, list_5, list_6, gclass202_1, CheckState.Unchecked, true,
                            class1014.class1013_0.checkBox_0);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 749);
        }
    }
}