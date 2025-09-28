using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Aurora;

#nullable disable
public partial class GClass0
{
    public int method_25(Dictionary<int, int> dictionary_78, int int_136, int int_137)
    {
        try
        {
            var num1 = 0;
            if (dictionary_78[int_136] > int_137)
            {
                var num2 = dictionary_78[int_136 - 1];
                var num3 = dictionary_78[int_136 + 1];
                if (num2 < dictionary_78[int_136] - int_137 || num3 < dictionary_78[int_136] - int_137)
                {
                    if (num2 <= num3)
                    {
                        dictionary_78[int_136 - 1]++;
                        num1 = int_136 - 1;
                    }
                    else
                    {
                        dictionary_78[int_136 + 1]++;
                        num1 = int_136 + 1;
                    }

                    dictionary_78[int_136]--;
                }
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 321);
            return 0;
        }
    }

    public int method_26(GEnum0 genum0_0)
    {
        try
        {
            switch (genum0_0)
            {
                case GEnum0.const_0:
                    ++MaxGameID;
                    return MaxGameID;
                case GEnum0.const_1:
                    ++int_24;
                    return int_24;
                case GEnum0.const_2:
                    ++int_25;
                    return int_25;
                case GEnum0.const_3:
                    ++MaxSystemID;
                    return MaxSystemID;
                case GEnum0.const_4:
                    ++MaxSystemBodyID;
                    return MaxSystemBodyID;
                case GEnum0.const_5:
                    ++MaxRuinRaceID;
                    return MaxRuinRaceID;
                case GEnum0.const_6:
                    ++MaxIncrementID;
                    return MaxIncrementID;
                case GEnum0.const_7:
                    ++MaxStarID;
                    return MaxStarID;
                case GEnum0.const_8:
                    ++MaxWarpPointID;
                    return MaxWarpPointID;
                case GEnum0.const_9:
                    ++int_7;
                    return int_7;
                case GEnum0.const_10:
                    ++int_8;
                    return int_8;
                case GEnum0.const_11:
                    ++int_9;
                    return int_9;
                case GEnum0.const_12:
                    ++int_10;
                    return int_10;
                case GEnum0.const_13:
                    ++int_11;
                    return int_11;
                case GEnum0.const_14:
                    ++int_12;
                    return int_12;
                case GEnum0.const_15:
                    ++int_13;
                    return int_13;
                case GEnum0.const_16:
                    var num = TechDataDictionary.Values.Max(gclass164_0 => gclass164_0.TechSystemID) + 1;
                    return num <= int_56 ? int_56 + 1 : num;
                case GEnum0.const_17:
                    ++int_15;
                    return int_15;
                case GEnum0.const_18:
                    ++int_17;
                    return int_17;
                case GEnum0.const_19:
                    ++int_18;
                    return int_18;
                case GEnum0.const_20:
                    ++int_42;
                    return int_42;
                case GEnum0.const_21:
                    ++int_19;
                    return int_19;
                case GEnum0.const_22:
                    ++int_20;
                    return int_20;
                case GEnum0.const_23:
                    ++int_21;
                    return int_21;
                case GEnum0.const_24:
                    ++int_22;
                    return int_22;
                case GEnum0.const_25:
                    ++int_23;
                    return int_23;
                case GEnum0.const_26:
                    ++int_26;
                    return int_26;
                case GEnum0.const_27:
                    ++int_27;
                    return int_27;
                case GEnum0.const_28:
                    ++int_28;
                    return int_28;
                case GEnum0.const_30:
                    ++int_30;
                    return int_30;
                case GEnum0.const_31:
                    ++int_31;
                    return int_31;
                case GEnum0.const_32:
                    ++int_32;
                    return int_32;
                case GEnum0.const_33:
                    ++int_33;
                    return int_33;
                case GEnum0.const_34:
                    ++int_34;
                    return int_34;
                case GEnum0.const_35:
                    ++int_35;
                    return int_35;
                case GEnum0.const_36:
                    ++int_36;
                    return int_36;
                case GEnum0.const_37:
                    ++int_37;
                    return int_37;
                case GEnum0.const_38:
                    ++int_38;
                    return int_38;
                case GEnum0.const_39:
                    ++int_39;
                    return int_39;
                case GEnum0.const_41:
                    ++int_40;
                    return int_40;
                case GEnum0.const_42:
                    ++int_41;
                    return int_41;
                case GEnum0.const_43:
                    ++int_43;
                    return int_43;
                case GEnum0.const_44:
                    ++int_44;
                    return int_44;
                case GEnum0.const_45:
                    ++MaxOrderTemplateID;
                    return MaxOrderTemplateID;
                case GEnum0.const_46:
                    ++int_47;
                    return int_47;
                case GEnum0.const_47:
                    ++int_48;
                    return int_48;
                case GEnum0.const_48:
                    ++int_45;
                    return int_45;
                case GEnum0.const_49:
                    ++int_49;
                    return int_49;
                case GEnum0.const_50:
                    ++int_50;
                    return int_50;
                case GEnum0.const_51:
                    ++int_29;
                    return int_29;
                case GEnum0.const_52:
                    ++int_51;
                    return int_51;
                case GEnum0.const_53:
                    ++int_52;
                    return int_52;
                case GEnum0.const_54:
                    ++int_53;
                    return int_53;
                case GEnum0.const_55:
                    ++int_54;
                    return int_54;
                case GEnum0.const_56:
                    ++int_55;
                    return int_55;
                default:
                    return 1;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1401);
            return 1;
        }
    }

    public double GetDistanceBetween(double double_8, double double_9, double double_10, double double_11)
    {
        try
        {
            var num1 = Math.Abs(double_10 - double_8);
            var num2 = Math.Abs(double_11 - double_9);
            return Math.Sqrt(num1 * num1 + num2 * num2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1403);
            return 0.0;
        }
    }

    public double method_29(
        double double_8,
        double double_9,
        double double_10,
        double double_11,
        double double_12,
        double double_13)
    {
        try
        {
            var num1 = Math.Abs(double_11 - double_8);
            var num2 = Math.Abs(double_12 - double_9);
            var num3 = Math.Abs(double_13 - double_10);
            return Math.Sqrt(num1 * num1 + num2 * num2 + num3 * num3);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3587);
            return 0.0;
        }
    }

    public double GetDistanceToNearestGClass212(
        StarSystem system,
        double posX,
        double posY,
        double otherPosX,
        double otherPosY)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        var scope245 = new LambdaScope245();
        // ISSUE: reference to a compiler-generated field
        scope245.System = system;
        try
        {
            // ISSUE: reference to a compiler-generated method
            var list = LagrangePoints.Values.Where(scope245.method_0)
                .OrderBy(gclass212_0 => gclass212_0.int_1).ToList();
            var gclass212List = new List<LagrangePoint>(list);
            var distance = GetDistanceBetween(posX, posY, otherPosX, otherPosY);
            if (list.Count < 2)
                return distance;
            foreach (var gclass212_1 in list)
            {
                var num2 = GetDistanceBetween(posX, posY, gclass212_1.XCor, gclass212_1.Ycor);
                if (num2 < distance)
                    foreach (var gclass212_2 in gclass212List)
                        if (gclass212_2 != gclass212_1)
                        {
                            var num3 = GetDistanceBetween(gclass212_2.XCor, gclass212_2.Ycor, otherPosX,
                                otherPosY);
                            if (num2 + num3 < distance)
                                distance = num2 + num3;
                        }
            }

            return distance;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1404);
            return 0.0;
        }
    }

    public int method_33(RacialSystemSurvey gclass202_0_1)
    {
        try
        {
            var num = 0;
            var dictionary = new Dictionary<int, RacialSystemSurvey>();
            var gclass202List1 = new List<RacialSystemSurvey>();
            var gclass202List2 = new List<RacialSystemSurvey>();
            dictionary.Add(gclass202_0_1.ActualSystem.SystemID, gclass202_0_1);
            gclass202List1.Add(gclass202_0_1);
            while (true)
            {
                foreach (var gclass202_1 in gclass202List1)
                {
                    if (gclass202_1.gclass3_0.genum95_0 > GEnum95.const_1)
                        num += (int)Math.Pow((double)gclass202_1.gclass3_0.genum95_0, 2.0);
                    foreach (var gclass202_2 in gclass202_1.method_37(true)
                                 .Where<RacialSystemSurvey>(gclass202_0_2 => gclass202_0_2.gclass3_0.genum95_0 != 0)
                                 .ToList())
                        if (!dictionary.ContainsKey(gclass202_2.ActualSystem.SystemID) &&
                            !gclass202List2.Contains(gclass202_2))
                            gclass202List2.Add(gclass202_2);
                }

                if (gclass202List2.Count != 0)
                {
                    gclass202List1.Clear();
                    foreach (var gclass202 in gclass202List2)
                    {
                        gclass202List1.Add(gclass202);
                        dictionary.Add(gclass202.ActualSystem.SystemID, gclass202);
                    }

                    gclass202List2.Clear();
                }
                else
                {
                    break;
                }
            }

            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1407);
            return 0;
        }
    }

    public int method_686()
    {
        try
        {
            var num = AuroraUtils.GetRandomInteger(5);
            switch (num)
            {
                case 1:
                    return num;
                case 2:
                    return 10 + num;
                case 3:
                    return 20 + num;
                case 4:
                    return 30 + num;
                default:
                    return 40 + num;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1602);
            return 0;
        }
    }

    public int method_682()
    {
        var num = AuroraUtils.GetRandomInteger(10);
        if (num < 6)
            return 50 + AuroraUtils.GetRandomInteger(10) + AuroraUtils.GetRandomInteger(10) +
                   AuroraUtils.GetRandomInteger(10) + AuroraUtils.GetRandomInteger(10);
        return num < 8
            ? 75 + AuroraUtils.GetRandomInteger(10) + AuroraUtils.GetRandomInteger(10)
            : 95 + AuroraUtils.GetRandomInteger(4);
    }

    public int method_641(StarSystem gclass200_0, bool bool_25)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        var class276 = new Class276();
        // ISSUE: reference to a compiler-generated field
        class276.gclass200_0 = gclass200_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            var list = JumpPointDictionary.Values.Where(class276.method_0)
                .Where(gclass120_0 => gclass120_0.LinkedJumpPoint != null)
                .Select(gclass120_0 => gclass120_0.LinkedJumpPoint.SystemData.SystemNumber)
                .ToList();
            var num1 = 0;
            int num2;
            do
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                num2 = LocalSystemChance <= 0 || LocalSystemSpread <= 0
                    ? AuroraUtils.GetRandomInteger(NumberOfSystems + 1) - 1
                    : AuroraUtils.GetRandomInteger(100) > LocalSystemChance
                        ? AuroraUtils.GetRandomInteger(NumberOfSystems + 1) - 1
                        : AuroraUtils.GetRandomInteger(2) != 1
                            ? class276.gclass200_0.SystemNumber - AuroraUtils.GetRandomInteger(LocalSystemSpread)
                            : class276.gclass200_0.SystemNumber + AuroraUtils.GetRandomInteger(LocalSystemSpread);
                if (num2 > NumberOfSystems)
                    num2 -= NumberOfSystems;
                else if (num2 < 0)
                    num2 += NumberOfSystems;
                if (!bool_25 || list.Contains(num2))
                    ++num1;
                else
                    break;
            } while (num1 != 100);

            return num2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1560);
            return 0;
        }
    }

    public int method_640()
    {
        try
        {
            var list = StarSystemDictionary.Values
                .Select(gclass200_0 => gclass200_0.SystemNumber).ToList();
            int num;
            do
            {
                num = AuroraUtils.GetRandomInteger(NumberOfSystems);
            } while (list.Contains(num));

            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1559);
            return 0;
        }
    }

    public int method_35(StarSystem gclass200_0, StarSystem gclass200_1, GameRace gclass21_2)
    {
        try
        {
            if (gclass200_0 == gclass200_1)
                return 0;
            var num = 0;
            var gclass200List1 = new List<StarSystem>();
            var gclass200List2 = new List<StarSystem>();
            var collection = new List<StarSystem>();
            gclass200_0.int_11 = 0;
            gclass200List1.Add(gclass200_0);
            gclass200List2.Add(gclass200_0);
            while (true)
            {
                ++num;
                collection.Clear();
                foreach (var gclass200_2 in gclass200List1)
                foreach (var gclass200_3 in gclass200_2.method_16(gclass21_2))
                {
                    if (gclass200_3 == gclass200_1)
                        return num;
                    if (!gclass200List2.Contains(gclass200_3))
                    {
                        gclass200_3.int_11 = num;
                        gclass200_3.gclass200_0 = gclass200_2;
                        collection.Add(gclass200_3);
                        gclass200List2.Add(gclass200_3);
                    }
                }

                if (collection.Count != 0)
                    gclass200List1 = new List<StarSystem>(collection);
                else
                    break;
            }

            return -1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1408);
            return -1;
        }
    }

    public int method_36(
        StarSystem gclass200_0,
        GameRace gclass21_2,
        CheckState checkState_3,
        CheckState checkState_4)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        var class268 = new Class268();
        // ISSUE: reference to a compiler-generated field
        class268.gclass21_0 = gclass21_2;
        // ISSUE: reference to a compiler-generated field
        class268.checkState_0 = checkState_3;
        try
        {
            if (checkState_4 == CheckState.Checked)
            {
                if (UseKnownStars == 1)
                    foreach (var gclass200 in StarSystemDictionary.Values)
                        if (gclass200.KnownSystemData != null)
                            gclass200.double_7 = method_29(gclass200_0.KnownSystemData.X,
                                gclass200_0.KnownSystemData.Y, gclass200_0.KnownSystemData.Z,
                                gclass200.KnownSystemData.X, gclass200.KnownSystemData.Y, gclass200.KnownSystemData.Z);

                return 0;
            }

            foreach (var gclass120 in JumpPointDictionary.Values)
                gclass120.double_3 = 0.0;
            var num1 = 0;
            var gclass200List1 = new List<StarSystem>();
            var gclass200List2 = new List<StarSystem>();
            var collection = new List<StarSystem>();
            gclass200_0.double_7 = 0.0;
            gclass200_0.gclass120_0 = null;
            gclass200List1.Add(gclass200_0);
            gclass200List2.Add(gclass200_0);
            while (true)
            {
                ++num1;
                collection.Clear();
                foreach (var gclass200 in gclass200List1)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    var class269 = new Class269();
                    // ISSUE: reference to a compiler-generated field
                    class269.class268_0 = class268;
                    // ISSUE: reference to a compiler-generated field
                    class269.gclass200_0 = gclass200;
                    var num2 = 0.0;
                    var double_8 = 0.0;
                    var double_9 = 0.0;
                    // ISSUE: reference to a compiler-generated field
                    class269.gclass200_0.double_7 = 0.0;
                    // ISSUE: reference to a compiler-generated field
                    if (class269.gclass200_0.gclass120_0 != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class269.gclass200_0.double_7 =
                            GetDistanceBetween(class269.gclass200_0.gclass120_0.XCoord,
                                class269.gclass200_0.gclass120_0.YCoord, 0.0, 0.0) +
                            class269.gclass200_0.gclass120_0.double_3;
                        // ISSUE: reference to a compiler-generated field
                        num2 = class269.gclass200_0.gclass120_0.double_3;
                        // ISSUE: reference to a compiler-generated field
                        double_8 = class269.gclass200_0.gclass120_0.XCoord;
                        // ISSUE: reference to a compiler-generated field
                        double_9 = class269.gclass200_0.gclass120_0.YCoord;
                    }

                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    foreach (var gclass120 in JumpPointDictionary.Values
                                 .Where(class269.method_0)
                                 .Where(class269.class268_0.func_0 ??
                                        (class269.class268_0.func_0 = class269.class268_0.method_0))
                                 .ToList())
                    {
                        gclass120.double_3 = GetDistanceBetween(double_8, double_9, gclass120.XCoord, gclass120.YCoord) +
                                             num2;
                        if (!gclass200List2.Contains(gclass120.LinkedJumpPoint.SystemData))
                        {
                            gclass120.LinkedJumpPoint.SystemData.int_11 = num1;
                            // ISSUE: reference to a compiler-generated field
                            gclass120.LinkedJumpPoint.SystemData.gclass200_0 = class269.gclass200_0;
                            gclass120.LinkedJumpPoint.SystemData.gclass120_0 = gclass120.LinkedJumpPoint;
                            gclass120.LinkedJumpPoint.double_3 = gclass120.double_3;
                            collection.Add(gclass120.LinkedJumpPoint.SystemData);
                            gclass200List2.Add(gclass120.LinkedJumpPoint.SystemData);
                        }
                    }
                }

                if (collection.Count != 0)
                    gclass200List1 = new List<StarSystem>(collection);
                else
                    break;
            }

            return -1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1409);
            return -1;
        }
    }

    public int method_37(
        StarSystem gclass200_0,
        GameRace gclass21_2,
        CheckState checkState_3,
        CheckState checkState_4)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        var class270 = new Class270();
        // ISSUE: reference to a compiler-generated field
        class270.gclass21_0 = gclass21_2;
        // ISSUE: reference to a compiler-generated field
        class270.checkState_0 = checkState_3;
        try
        {
            if (checkState_4 == CheckState.Checked)
            {
                if (UseKnownStars == 1)
                    foreach (var gclass200 in StarSystemDictionary.Values)
                        if (gclass200.KnownSystemData != null)
                            gclass200.double_7 = method_29(gclass200_0.KnownSystemData.X,
                                gclass200_0.KnownSystemData.Y, gclass200_0.KnownSystemData.Z,
                                gclass200.KnownSystemData.X, gclass200.KnownSystemData.Y, gclass200.KnownSystemData.Z);

                return 0;
            }

            foreach (var gclass120 in JumpPointDictionary.Values)
                gclass120.double_3 = 0.0;
            var num1 = 0;
            var gclass200List1 = new List<StarSystem>();
            var gclass200List2 = new List<StarSystem>();
            var collection = new List<StarSystem>();
            gclass200_0.double_7 = 0.0;
            gclass200_0.gclass120_0 = null;
            gclass200List1.Add(gclass200_0);
            gclass200List2.Add(gclass200_0);
            while (true)
            {
                ++num1;
                collection.Clear();
                foreach (var gclass200 in gclass200List1)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    var class271 = new Class271();
                    // ISSUE: reference to a compiler-generated field
                    class271.class270_0 = class270;
                    // ISSUE: reference to a compiler-generated field
                    class271.gclass200_0 = gclass200;
                    var num2 = 0.0;
                    var double_8 = 0.0;
                    var double_9 = 0.0;
                    // ISSUE: reference to a compiler-generated field
                    class271.gclass200_0.double_7 = 0.0;
                    // ISSUE: reference to a compiler-generated field
                    if (class271.gclass200_0.gclass120_0 != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class271.gclass200_0.double_7 =
                            GetDistanceBetween(class271.gclass200_0.gclass120_0.XCoord,
                                class271.gclass200_0.gclass120_0.YCoord, 0.0, 0.0) +
                            class271.gclass200_0.gclass120_0.double_3;
                        // ISSUE: reference to a compiler-generated field
                        num2 = class271.gclass200_0.gclass120_0.double_3;
                        // ISSUE: reference to a compiler-generated field
                        double_8 = class271.gclass200_0.gclass120_0.XCoord;
                        // ISSUE: reference to a compiler-generated field
                        double_9 = class271.gclass200_0.gclass120_0.YCoord;
                    }

                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    foreach (var gclass120 in JumpPointDictionary.Values
                                 .Where(class271.method_0)
                                 .Where(class271.class270_0.func_0 ??
                                        (class271.class270_0.func_0 = class271.class270_0.method_0))
                                 .ToList())
                    {
                        gclass120.double_3 = GetDistanceBetween(double_8, double_9, gclass120.XCoord, gclass120.YCoord) +
                                             num2;
                        if (!gclass200List2.Contains(gclass120.LinkedJumpPoint.SystemData))
                        {
                            gclass120.LinkedJumpPoint.SystemData.int_11 = num1;
                            // ISSUE: reference to a compiler-generated field
                            gclass120.LinkedJumpPoint.SystemData.gclass200_0 = class271.gclass200_0;
                            gclass120.LinkedJumpPoint.SystemData.gclass120_0 = gclass120.LinkedJumpPoint;
                            gclass120.LinkedJumpPoint.double_3 = gclass120.double_3;
                            collection.Add(gclass120.LinkedJumpPoint.SystemData);
                            gclass200List2.Add(gclass120.LinkedJumpPoint.SystemData);
                        }
                        else if (GetDistanceBetween(gclass120.LinkedJumpPoint.XCoord, gclass120.LinkedJumpPoint.YCoord, 0.0,
                                     0.0) + gclass120.LinkedJumpPoint.double_3 <
                                 gclass120.LinkedJumpPoint.SystemData.double_7)
                        {
                            gclass120.LinkedJumpPoint.SystemData.int_11 = num1;
                            // ISSUE: reference to a compiler-generated field
                            gclass120.LinkedJumpPoint.SystemData.gclass200_0 = class271.gclass200_0;
                            gclass120.LinkedJumpPoint.SystemData.gclass120_0 = gclass120.LinkedJumpPoint;
                            gclass120.LinkedJumpPoint.double_3 = gclass120.double_3;
                            collection.Add(gclass120.LinkedJumpPoint.SystemData);
                            gclass200List2.Add(gclass120.LinkedJumpPoint.SystemData);
                        }
                    }
                }

                if (collection.Count != 0)
                    gclass200List1 = new List<StarSystem>(collection);
                else
                    break;
            }

            return -1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1409);
            return -1;
        }
    }

    public int method_42(bool bool_25, int int_136, decimal decimal_13)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        var class303 = new Class303();
        // ISSUE: reference to a compiler-generated field
        class303.decimal_0 = decimal_13;
        try
        {
            var gclass132List = new List<MissileSalvo>();
            double num1 = int_136;
            foreach (var gclass132 in MissileSalvoes.Values)
                gclass132.genum40_0 = gclass132.RaceMissile.ShipDecoy != 1
                    ? gclass132.gclass132_0 == null ? GEnum40.const_0 : GEnum40.const_1
                    : GEnum40.const_2;
            var list1 = MissileSalvoes.Values
                .OrderByDescending(gclass132_0 => gclass132_0.genum40_0)
                .ThenByDescending(gclass132_0 => gclass132_0.RaceMissile.Size)
                .ThenByDescending(gclass132_0 => gclass132_0.RemainingDecoys.Count).ToList();
            if (list1.Count == 0)
                return 0;
            method_171(MissileSalvoes.Values
                .Select<MissileSalvo, StarSystem>(gclass132_0 => gclass132_0.System).Distinct()
                .ToList());
            foreach (var gclass132 in list1)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                var class304 = new Class304();
                // ISSUE: reference to a compiler-generated field
                class304.class303_0 = class303;
                // ISSUE: reference to a compiler-generated field
                class304.gclass132_0 = gclass132;
                // ISSUE: reference to a compiler-generated field
                var gclass1320 = class304.gclass132_0;
                // ISSUE: reference to a compiler-generated field
                var count = class304.gclass132_0.RemainingDecoys.Count;
                // ISSUE: reference to a compiler-generated field
                var str = $"{count.ToString()}x {class304.gclass132_0.RaceMissile.Name}";
                gclass1320.string_0 = str;
                // ISSUE: reference to a compiler-generated field
                if (class304.gclass132_0.RemainingDecoys.Count != 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class304.gclass132_0.double_9 == 0.0 && class304.gclass132_0.RaceMissile.SecondStageMissile == null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (bool_25 && !class304.gclass132_0.method_13(true))
                        {
                            var gclass920 = gclass92_0;
                            var strArray = new string[5]
                            {
                                "A salvo with ",
                                null,
                                null,
                                null,
                                null
                            };
                            // ISSUE: reference to a compiler-generated field
                            count = class304.gclass132_0.RemainingDecoys.Count;
                            strArray[1] = count.ToString();
                            strArray[2] = "x ";
                            // ISSUE: reference to a compiler-generated field
                            strArray[3] = class304.gclass132_0.RaceMissile.Name;
                            strArray[4] =
                                " has no sensors, no second stage and no method of movement. Therefore it has self-destructed";
                            var string_0 = string.Concat(strArray);
                            // ISSUE: reference to a compiler-generated field
                            var gclass210 = class304.gclass132_0.Race;
                            // ISSUE: reference to a compiler-generated field
                            var gclass2000 = class304.gclass132_0.System;
                            // ISSUE: reference to a compiler-generated field
                            var double0 = class304.gclass132_0.double_0;
                            // ISSUE: reference to a compiler-generated field
                            var double1 = class304.gclass132_0.double_1;
                            gclass920.method_2(EventType.const_107, string_0, gclass210, gclass2000, double0, double1,
                                AuroraEventCategory.MissileSalvo);
                            // ISSUE: reference to a compiler-generated field
                            class304.gclass132_0.method_6();
                        }
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (class304.gclass132_0.int_0 == 0)
                        {
                            if (bool_25)
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (!class304.gclass132_0.method_15())
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    if (class304.gclass132_0.double_9 > 0.0)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        class304.gclass132_0.decimal_1 -= SubPulseLength;
                                        // ISSUE: reference to a compiler-generated field
                                        if (class304.gclass132_0.decimal_1 <= 0M)
                                            // ISSUE: reference to a compiler-generated field
                                            class304.gclass132_0.method_6();
                                    }

                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }

                        var gclass221_2 = new GClass221(0.0, 0.0);
                        // ISSUE: reference to a compiler-generated field
                        if (class304.gclass132_0.auroraContactType_0 == AuroraContactType.Ship)
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (class304.gclass132_0.gclass40_1 != null)
                            {
                                // ISSUE: reference to a compiler-generated method
                                var list2 = Contacts.Values.Where(class304.method_0)
                                    .ToList();
                                if (list2.Count > 0)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    if (class304.gclass132_0.method_11(list2))
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (!class304.gclass132_0.gclass40_1.gclass85_0.method_253() &&
                                            class304.gclass132_0.RaceMissile.MaxDetonationRange == 0M)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            gclass221_2.double_0 = class304.gclass132_0.gclass40_1.gclass85_0.XCoord;
                                            // ISSUE: reference to a compiler-generated field
                                            gclass221_2.double_1 = class304.gclass132_0.gclass40_1.gclass85_0.YCoord;
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            gclass221_2 = method_50(class304.gclass132_0.gclass40_1.gclass85_0,
                                                null, class304.gclass132_0, (double)class304.gclass132_0.decimal_2);
                                            // ISSUE: reference to a compiler-generated field
                                            if (class304.gclass132_0.decimal_2 > 0M)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                if (gclass221_2.double_0 == class304.gclass132_0.double_0 &&
                                                    gclass221_2.double_1 == class304.gclass132_0.double_1)
                                                {
                                                    gclass221_2.double_0 += 100.0;
                                                    gclass221_2.double_1 += 100.0;
                                                }

                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                gclass221_2 = class304.gclass132_0.method_0(gclass221_2,
                                                    (double)class304.gclass132_0.decimal_2);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated method
                                    Contacts.Values.Where(class304.method_1).ToList();
                                }
                            }
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (class304.gclass132_0.auroraContactType_0 == AuroraContactType.Salvo)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated method
                                if (class304.gclass132_0.gclass132_0 != null && Contacts.Values
                                        .Where(class304.method_2).ToList().Count > 0)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    if (class304.gclass132_0.gclass132_0.double_9 == 0.0)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        gclass221_2.double_0 = class304.gclass132_0.gclass132_0.double_0;
                                        // ISSUE: reference to a compiler-generated field
                                        gclass221_2.double_1 = class304.gclass132_0.gclass132_0.double_1;
                                    }
                                    else
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        gclass221_2 = method_51(class304.gclass132_0.gclass132_0,
                                            class304.gclass132_0);
                                    }
                                }
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (class304.gclass132_0.auroraContactType_0 != AuroraContactType.Population &&
                                    class304.gclass132_0.auroraContactType_0 != AuroraContactType.Shipyard &&
                                    class304.gclass132_0.auroraContactType_0 != AuroraContactType.GroundUnit &&
                                    class304.gclass132_0.auroraContactType_0 != AuroraContactType.STOGroundUnit)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (class304.gclass132_0.auroraContactType_0 == AuroraContactType.WayPoint &&
                                        class304.gclass132_0.gclass214_0 != null)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        gclass221_2.double_0 = class304.gclass132_0.gclass214_0.Xcor;
                                        // ISSUE: reference to a compiler-generated field
                                        gclass221_2.double_1 = class304.gclass132_0.gclass214_0.Ycor;
                                    }
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    if (class304.gclass132_0.gclass146_0 != null)
                                    {
                                        var gclass65List = new List<Contact>();
                                        // ISSUE: reference to a compiler-generated field
                                        if (class304.gclass132_0.auroraContactType_0 == AuroraContactType.Population)
                                        {
                                            // ISSUE: reference to a compiler-generated method
                                            gclass65List = Contacts.Values.Where(class304.method_3)
                                                .ToList();
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            if (class304.gclass132_0.auroraContactType_0 ==
                                                AuroraContactType.STOGroundUnit ||
                                                class304.gclass132_0.auroraContactType_0 ==
                                                AuroraContactType.GroundUnit ||
                                                class304.gclass132_0.auroraContactType_0 == AuroraContactType.Shipyard)
                                                // ISSUE: reference to a compiler-generated method
                                                gclass65List = Contacts.Values
                                                    .Where(class304.method_4).ToList();
                                        }

                                        if (gclass65List.Count > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (class304.gclass132_0.decimal_2 > 0M)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                var double_10 = class304.gclass132_0.gclass146_0.method_87();
                                                // ISSUE: reference to a compiler-generated field
                                                var double_11 = class304.gclass132_0.gclass146_0.method_88();
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                var num2 = GetDistanceBetween(class304.gclass132_0.double_0,
                                                    class304.gclass132_0.double_1, double_10, double_11);
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                gclass221_2 = method_525(class304.gclass132_0.double_0,
                                                    class304.gclass132_0.double_1, double_10, double_11,
                                                    num2 - (double)class304.gclass132_0.decimal_2);
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                gclass221_2.double_0 = class304.gclass132_0.gclass146_0.method_87();
                                                // ISSUE: reference to a compiler-generated field
                                                gclass221_2.double_1 = class304.gclass132_0.gclass146_0.method_88();
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (gclass221_2.double_0 == 0.0 && gclass221_2.double_1 == 0.0)
                        {
                            if (bool_25)
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (!class304.gclass132_0.method_13(false))
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    gclass92_0.method_2(EventType.const_30,
                                        class304.gclass132_0.string_0 +
                                        " has no target and no onboard sensors and will therefore self-destruct",
                                        class304.gclass132_0.Race, class304.gclass132_0.System,
                                        class304.gclass132_0.double_0, class304.gclass132_0.double_1,
                                        AuroraEventCategory.MissileSalvo);
                                    // ISSUE: reference to a compiler-generated field
                                    class304.gclass132_0.method_6();
                                    continue;
                                }

                                // ISSUE: reference to a compiler-generated field
                                if (class304.gclass132_0.double_9 > 0.0)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    if (!class304.gclass132_0.bool_1)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        gclass92_0.method_2(EventType.const_30,
                                            class304.gclass132_0.string_0 +
                                            " cannot locate its target. it will continue to the last known target location and use onboard sensors to search for a new target",
                                            class304.gclass132_0.Race, class304.gclass132_0.System,
                                            class304.gclass132_0.double_0, class304.gclass132_0.double_1,
                                            AuroraEventCategory.MissileSalvo);
                                        // ISSUE: reference to a compiler-generated field
                                        class304.gclass132_0.bool_1 = true;
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    gclass221_2.double_0 = class304.gclass132_0.double_4;
                                    // ISSUE: reference to a compiler-generated field
                                    gclass221_2.double_1 = class304.gclass132_0.double_5;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }

                        if (bool_25)
                        {
                            // ISSUE: reference to a compiler-generated field
                            class304.gclass132_0.double_4 = gclass221_2.double_0;
                            // ISSUE: reference to a compiler-generated field
                            class304.gclass132_0.double_5 = gclass221_2.double_1;
                            // ISSUE: reference to a compiler-generated field
                            class304.gclass132_0.bool_0 = true;
                        }

                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        var num3 = GetDistanceBetween(class304.gclass132_0.double_0, class304.gclass132_0.double_1,
                            gclass221_2.double_0, gclass221_2.double_1);
                        if (!bool_25)
                        {
                            // ISSUE: reference to a compiler-generated field
                            var num4 = class304.gclass132_0.double_9 * int_136;
                            if (num4 >= num3)
                            {
                                var num5 = num3 / num4 * int_136;
                                if (num5 < num1)
                                    num1 = num5;
                            }
                        }
                        else
                        {
                            var num6 = num3;
                            // ISSUE: reference to a compiler-generated field
                            var num7 = class304.gclass132_0.double_9 * SubPulseLength;
                            var flag = false;
                            // ISSUE: reference to a compiler-generated field
                            if (class304.gclass132_0.double_9 > 0.0)
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (class304.gclass132_0.decimal_1 < SubPulseLength)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    num7 = class304.gclass132_0.double_9 * (double)class304.gclass132_0.decimal_1;
                                    flag = true;
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    class304.gclass132_0.decimal_1 -= SubPulseLength;
                                }
                            }

                            if (num7 < num3)
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (class304.gclass132_0.double_9 > 0.0)
                                {
                                    num6 = num3 - num7;
                                    var num8 = num7 / num3;
                                    // ISSUE: reference to a compiler-generated field
                                    var num9 = Math.Abs(gclass221_2.double_0 - class304.gclass132_0.double_0);
                                    // ISSUE: reference to a compiler-generated field
                                    var num10 = Math.Abs(gclass221_2.double_1 - class304.gclass132_0.double_1);
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    class304.gclass132_0.double_2 = class304.gclass132_0.double_0;
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    class304.gclass132_0.double_3 = class304.gclass132_0.double_1;
                                    // ISSUE: reference to a compiler-generated field
                                    if (class304.gclass132_0.double_0 > gclass221_2.double_0)
                                        // ISSUE: reference to a compiler-generated field
                                        class304.gclass132_0.double_0 -= num9 * num8;
                                    else
                                        // ISSUE: reference to a compiler-generated field
                                        class304.gclass132_0.double_0 += num9 * num8;

                                    // ISSUE: reference to a compiler-generated field
                                    if (class304.gclass132_0.double_1 > gclass221_2.double_1)
                                        // ISSUE: reference to a compiler-generated field
                                        class304.gclass132_0.double_1 -= num10 * num8;
                                    else
                                        // ISSUE: reference to a compiler-generated field
                                        class304.gclass132_0.double_1 += num10 * num8;
                                }

                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (class304.gclass132_0.RaceMissile.SecondStageMissile != null &&
                                    num6 <= class304.gclass132_0.RaceMissile.SeparationRange)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    class304.gclass132_0.method_12();
                                    // ISSUE: reference to a compiler-generated field
                                    class304.gclass132_0.method_6();
                                }
                                else if (flag)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    class304.gclass132_0.method_6();
                                }
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (class304.gclass132_0.gclass40_1 != null &&
                                    class304.gclass132_0.RaceMissile.MaxDetonationRange == 0M)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    class304.gclass132_0.double_0 = class304.gclass132_0.gclass40_1.gclass85_0.XCoord;
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    class304.gclass132_0.double_1 = class304.gclass132_0.gclass40_1.gclass85_0.YCoord;
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    class304.gclass132_0.double_0 = gclass221_2.double_0;
                                    // ISSUE: reference to a compiler-generated field
                                    class304.gclass132_0.double_1 = gclass221_2.double_1;
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (class304.gclass132_0.gclass214_0 != null &&
                                        class304.gclass132_0.gclass214_0.WaypointType == WayPointType.Temporary)
                                        // ISSUE: reference to a compiler-generated field
                                        class304.gclass132_0.gclass214_0.WaypointType =
                                            WayPointType.MarkedForDeletion;
                                }

                                // ISSUE: reference to a compiler-generated field
                                gclass132List.Add(class304.gclass132_0);
                            }
                        }
                    }
                }
            }

            if (gclass132List.Count == 0)
                return !bool_25 ? (int)num1 : 0;
            method_43(gclass132List, false);
            method_44(gclass132List);
            var list3 = gclass132List
                .Where(gclass132_0 => gclass132_0.RemainingDecoys.Count > 0 && !gclass132_0.bool_2)
                .OrderByDescending(gclass132_0 => gclass132_0.RaceMissile.Size)
                .ToList();
            if (list3.Count > 0)
            {
                var list4 = list3
                    .Where(gclass132_0 =>
                        gclass132_0.RemainingDecoys.Count > 0 &&
                        gclass132_0.auroraContactType_0 == AuroraContactType.Salvo)
                    .OrderByDescending(gclass132_0 => gclass132_0.RaceMissile.Size)
                    .ToList();
                if (list4.Count > 0)
                    method_45(list4);
                var list5 = list3
                    .Where(gclass132_0 =>
                        gclass132_0.RemainingDecoys.Count > 0 &&
                        gclass132_0.auroraContactType_0 != AuroraContactType.Salvo)
                    .OrderByDescending(gclass132_0 => gclass132_0.RaceMissile.Size)
                    .ToList();
                if (list5.Count > 0)
                {
                    foreach (var gclass40 in list5
                                 .Where(gclass132_0 => gclass132_0.gclass40_1 != null)
                                 .Select<MissileSalvo, ShipData>(gclass132_0 => gclass132_0.gclass40_1)
                                 .Distinct().ToList())
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        var class305 = new Class305();
                        // ISSUE: reference to a compiler-generated field
                        class305.gclass40_0 = gclass40;
                        // ISSUE: reference to a compiler-generated field
                        if (class305.gclass40_0.DecoyAssignmentList.Count != 0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            var num11 = class305.gclass40_0.method_49();
                            // ISSUE: reference to a compiler-generated field
                            var num12 = class305.gclass40_0.int_23 * num11;
                            if (num12 < 1M)
                                num12 = 1M;
                            // ISSUE: reference to a compiler-generated method
                            var num13 = list5.Where(class305.method_0).Sum(gclass132_0 =>
                                gclass132_0.RaceMissile.Size * gclass132_0.RemainingDecoys.Count);
                            if (num13 >= num12)
                            {
                                // ISSUE: reference to a compiler-generated field
                                var list6 = class305.gclass40_0.DecoyAssignmentList
                                    .ToList<FCTDecoyAssignmentData32>();
                                // ISSUE: reference to a compiler-generated field
                                List<FCTDecoyAssignmentData32> source = class305.gclass40_0.method_21(list6);
                                if (source.Count != 0)
                                {
                                    var num14 = (int)Math.Floor(num13 / num12);
                                    foreach (var gclass32 in source)
                                    {
                                        // ISSUE: object of a compiler-generated type is created
                                        // ISSUE: variable of a compiler-generated type
                                        var class306 = new Class306
                                        {
                                            gclass32_0 = gclass32
                                        };
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated method
                                        class306.gclass32_0.gclass30_0 =
                                            class305.gclass40_0.FiredMissiles.FirstOrDefault<MissileAssignment>(class306.method_0);
                                    }

                                    var num15 = 0;
                                    foreach (var gclass32 in source
                                                 .Where(gclass32_0 =>
                                                     gclass32_0.gclass30_0 != null)
                                                 .OrderByDescending(gclass32_0 =>
                                                     gclass32_0.gclass30_0.Missile.Size)
                                                 .ThenByDescending(gclass32_0 =>
                                                     gclass32_0.gclass30_0.Missile.MissileECM)
                                                 .ToList())
                                        // ISSUE: reference to a compiler-generated field
                                        if (!class305.gclass40_0.method_103(gclass32.gclass30_0.Missile))
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            gclass92_0.method_2(EventType.const_12,
                                                $"{class305.gclass40_0.ShipName} cannot launch a {gclass32.gclass30_0.Missile.Name} as no decoys of the required type are available",
                                                class305.gclass40_0.gclass21_0,
                                                class305.gclass40_0.gclass85_0.System.ActualSystem,
                                                class305.gclass40_0.gclass85_0.XCoord,
                                                class305.gclass40_0.gclass85_0.YCoord, AuroraEventCategory.Ship);
                                        }
                                        else if (gclass32.gclass30_0.Missile.Size >
                                                 gclass32.LauncherData.decimal_3)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            gclass92_0.method_2(EventType.const_194,
                                                $"{class305.gclass40_0.ShipName} cannot lauch a {gclass32.gclass30_0.Missile.Name} as the ordnance is too large for the launcher.",
                                                class305.gclass40_0.gclass21_0,
                                                class305.gclass40_0.gclass85_0.System.ActualSystem,
                                                class305.gclass40_0.gclass85_0.XCoord,
                                                class305.gclass40_0.gclass85_0.YCoord, AuroraEventCategory.Ship);
                                        }
                                        else
                                        {
                                            var gclass27 = new WeaponComponentRechargeStatus(gclass32.LauncherData,
                                                gclass32.LauncherNum, gclass32.LauncherData.int_11);
                                            // ISSUE: reference to a compiler-generated field
                                            class305.gclass40_0.list_7.Add(gclass27);
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class305.gclass40_0.method_102(gclass32.gclass30_0,
                                                class305.gclass40_0.int_8, AuroraContactType.Ship);
                                            ++num15;
                                            if (num15 == num14)
                                                break;
                                        }
                                }
                            }
                        }
                    }

                    foreach (var gclass132_1 in list5)
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        var class307 = new Class307();
                        // ISSUE: reference to a compiler-generated field
                        class307.gclass132_0 = gclass132_1;
                        // ISSUE: reference to a compiler-generated field
                        if (class307.gclass132_0.gclass40_1 != null)
                        {
                            // ISSUE: reference to a compiler-generated field
                            method_46(class307.gclass132_0);
                            // ISSUE: reference to a compiler-generated field
                            if (class307.gclass132_0.RemainingDecoys.Count == 0)
                                continue;
                        }

                        // ISSUE: reference to a compiler-generated field
                        if (class307.gclass132_0.RaceMissile.SecondStageMissile != null)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            class307.gclass132_0.gclass1_0 =
                                SystemBodyRecordDic.Values.FirstOrDefault(
                                    class307.method_0);
                            // ISSUE: reference to a compiler-generated field
                            class307.gclass132_0.method_12();
                            // ISSUE: reference to a compiler-generated field
                            class307.gclass132_0.method_6();
                        }
                        else
                        {
                            var decimal_14 = 0M;
                            decimal decimal_13_1;
                            // ISSUE: reference to a compiler-generated field
                            if (class307.gclass132_0.RaceMissile.LaserWarhead > 0M)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                decimal_13_1 =
                                    class307.gclass132_0.RaceMissile.method_2(class307.gclass132_0.decimal_2);
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                decimal_13_1 = class307.gclass132_0.RaceMissile.WarheadStrength /
                                               class307.gclass132_0.RaceMissile.MultipleWarheads;
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                decimal_14 = class307.gclass132_0.RaceMissile.RadDamage /
                                             class307.gclass132_0.RaceMissile.MultipleWarheads;
                            }

                            // ISSUE: reference to a compiler-generated field
                            if (class307.gclass132_0.auroraContactType_0 == AuroraContactType.Ship)
                            {
                                var string_10 = "Unknown";
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                var gclass117 =
                                    class307.gclass132_0.Race.method_268(class307.gclass132_0.gclass40_1.int_8);
                                if (gclass117 != null)
                                    string_10 = gclass117.method_11();
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                var double_7 =
                                    class307.gclass132_0.RaceMissile.method_3(class307.gclass132_0.gclass40_1);
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                var num16 = class307.gclass132_0.RaceMissile.method_0(
                                    (int)class307.gclass132_0.gclass40_1.method_171(true), double_7,
                                    class307.gclass132_0.double_8);
                                if (num16 > 100.0)
                                    num16 = 100.0;
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                var int_137 = class307.gclass132_0.RemainingDecoys.Count *
                                              class307.gclass132_0.RaceMissile.MultipleWarheads;
                                // ISSUE: reference to a compiler-generated field
                                var num17 = class307.gclass132_0.method_3(num16);
                                var int_139 = 0;
                                // ISSUE: reference to a compiler-generated method
                                var list7 = MissileSalvoes.Values.Where(class307.method_1)
                                    .ToList();
                                if (list7.Count > 0)
                                {
                                    var num18 = 0M;
                                    foreach (var gclass132_2 in list7)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        var num19 = class307.gclass132_0.RaceMissile.ECCM -
                                                    gclass132_2.RaceMissile.MissileECM;
                                        if (num19 < 0)
                                            num19 = 0;
                                        var num20 = gclass132_2.RaceMissile.WarheadStrength * (1M - num19 * 0.2M);
                                        if (num20 > 0M)
                                            num18 += num20 * gclass132_2.RemainingDecoys.Count;
                                    }

                                    if (num18 > 0M)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        var num21 = class307.gclass132_0.gclass40_1.gclass22_0.Size *
                                                    AuroraUtils.decimal_17;
                                        var num22 = num21 + num18;
                                        for (var index = 1; index <= num17; ++index)
                                            if ((decimal)AuroraUtils.smethod_17() * num22 > num21)
                                                ++int_139;
                                    }

                                    num17 -= int_139;
                                }

                                // ISSUE: reference to a compiler-generated field
                                if (class307.gclass132_0.RaceMissile.LaserWarhead > 0M)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    method_1(class307.gclass132_0.Race, class307.gclass132_0.Ship,
                                        null, class307.gclass132_0.RaceMissile, null,
                                        class307.gclass132_0.auroraContactType_0, class307.gclass132_0.int_0, int_137,
                                        num17, int_139, 0, 0, decimal_13_1, decimal_14,
                                        (double)class307.gclass132_0.decimal_2, num16, string_10,
                                        class307.gclass132_0.gclass40_1.gclass21_0, false, false, false, false, false,
                                        GEnum62.const_0);
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    method_19(AuroraContactType.Explosion,
                                        class307.gclass132_0.RaceMissile.LaserWarhead,
                                        class307.gclass132_0.RemainingDecoys.Count + num17,
                                        class307.gclass132_0.System, class307.gclass132_0.double_0,
                                        class307.gclass132_0.double_1, false);
                                    if (num17 > 0)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        method_19(AuroraContactType.EWImpact, decimal_13_1, num17,
                                            class307.gclass132_0.System,
                                            class307.gclass132_0.gclass40_1.gclass85_0.XCoord,
                                            class307.gclass132_0.gclass40_1.gclass85_0.YCoord, false);
                                        // ISSUE: reference to a compiler-generated field
                                        class307.gclass132_0.gclass40_1.decimal_19 = GameTime;
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
                                    method_1(class307.gclass132_0.Race, class307.gclass132_0.Ship,
                                        null, class307.gclass132_0.RaceMissile, null,
                                        class307.gclass132_0.auroraContactType_0, class307.gclass132_0.int_0, int_137,
                                        num17, int_139, 0, 0, decimal_13_1, decimal_14, 0.0, num16, string_10,
                                        class307.gclass132_0.gclass40_1.gclass21_0, false, false, false, false, false,
                                        GEnum62.const_0);
                                    if (num17 > 0)
                                        // ISSUE: reference to a compiler-generated field
                                        class307.gclass132_0.gclass40_1.decimal_19 = GameTime;

                                    if (num17 + int_139 > 0)
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        method_19(AuroraContactType.Explosion, decimal_13_1, num17 + int_139,
                                            class307.gclass132_0.System,
                                            class307.gclass132_0.gclass40_1.gclass85_0.XCoord,
                                            class307.gclass132_0.gclass40_1.gclass85_0.YCoord, false);
                                }

                                // ISSUE: reference to a compiler-generated field
                                if (class307.gclass132_0.RaceMissile.Retargeting != 1)
                                    // ISSUE: reference to a compiler-generated field
                                    class307.gclass132_0.method_6();
                                else
                                    // ISSUE: reference to a compiler-generated field
                                    class307.gclass132_0.bool_2 = true;
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (class307.gclass132_0.auroraContactType_0 != AuroraContactType.Population &&
                                    class307.gclass132_0.auroraContactType_0 != AuroraContactType.Shipyard &&
                                    class307.gclass132_0.auroraContactType_0 != AuroraContactType.GroundUnit &&
                                    class307.gclass132_0.auroraContactType_0 != AuroraContactType.STOGroundUnit)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    if (class307.gclass132_0.auroraContactType_0 == AuroraContactType.WayPoint)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        if (class307.gclass132_0.method_13(true))
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated method
                                            class307.gclass132_0.gclass1_0 =
                                                SystemBodyRecordDic.Values.FirstOrDefault(
                                                    class307.method_2);

                                        // ISSUE: reference to a compiler-generated field
                                        if (class307.gclass132_0.decimal_1 < SubPulseLength)
                                            // ISSUE: reference to a compiler-generated field
                                            class307.gclass132_0.method_6();
                                    }
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    var string_10 =
                                        class307.gclass132_0.gclass146_0.Race.method_42(class307.gclass132_0
                                            .gclass146_0);
                                    // ISSUE: reference to a compiler-generated field
                                    if (class307.gclass132_0.auroraContactType_0 == AuroraContactType.Shipyard)
                                    {
                                        string_10 += " Shipyards";
                                    }
                                    else
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        if (class307.gclass132_0.auroraContactType_0 == AuroraContactType.GroundUnit)
                                        {
                                            string_10 += " Ground Forces";
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (class307.gclass132_0.auroraContactType_0 ==
                                                AuroraContactType.STOGroundUnit)
                                                string_10 += " STO Ground Forces";
                                        }
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    if (class307.gclass132_0.RaceMissile.LaserWarhead > 0M)
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        method_1(class307.gclass132_0.Race, class307.gclass132_0.Ship,
                                            null, class307.gclass132_0.RaceMissile, null,
                                            class307.gclass132_0.auroraContactType_0, class307.gclass132_0.int_0,
                                            class307.gclass132_0.RemainingDecoys.Count,
                                            class307.gclass132_0.RemainingDecoys.Count, 0, 0, 0, decimal_13_1, decimal_14,
                                            (double)class307.gclass132_0.decimal_2, 100.0, string_10,
                                            class307.gclass132_0.gclass146_0.Race, false, false, false, false,
                                            false, GEnum62.const_0);
                                    else
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        method_1(class307.gclass132_0.Race, class307.gclass132_0.Ship,
                                            null, class307.gclass132_0.RaceMissile, null,
                                            class307.gclass132_0.auroraContactType_0, class307.gclass132_0.int_0,
                                            class307.gclass132_0.RemainingDecoys.Count,
                                            class307.gclass132_0.RemainingDecoys.Count, 0, 0, 0, decimal_13_1, decimal_14,
                                            0.0, 100.0, string_10, class307.gclass132_0.gclass146_0.Race, false,
                                            false, false, false, false, GEnum62.const_0);

                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    method_19(AuroraContactType.Explosion,
                                        class307.gclass132_0.RaceMissile.WarheadStrength,
                                        class307.gclass132_0.RemainingDecoys.Count, class307.gclass132_0.System,
                                        class307.gclass132_0.gclass146_0.method_87(),
                                        class307.gclass132_0.gclass146_0.method_88(), false);
                                    // ISSUE: reference to a compiler-generated field
                                    class307.gclass132_0.method_6();
                                }
                            }
                        }
                    }
                }
            }

            foreach (var gclass132_0 in MissileSalvoes.Values
                         .Where(gclass132_0 =>
                             gclass132_0.RemainingDecoys.Count == 0 || gclass132_0.RaceMissile.ShipDecoy == 1)
                         .ToList())
                gclass132_0.Race.method_130(gclass132_0);
            return 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1413);
            return 0;
        }
    }

    public int method_589(decimal decimal_13)
    {
        try
        {
            if (decimal_13 == 0M)
                return 0;
            var num = 1;
            while (true)
            {
                decimal_13 /= 2M;
                if (!(decimal_13 < 1M))
                    ++num;
                else
                    break;
            }

            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1689);
            return 0;
        }
    }

    public int method_158(ShipComponent gclass230_2)
    {
        try
        {
            return gclass230_2 != null ? gclass230_2.int_0 : 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1508);
            return 0;
        }
    }

    public int method_159(TechSystem gclass164_1)
    {
        try
        {
            return gclass164_1 != null ? gclass164_1.TechSystemID : 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3499);
            return 0;
        }
    }

    public int method_160(RaceMissile gclass129_1)
    {
        try
        {
            return gclass129_1 != null ? gclass129_1.MissileID : 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1509);
            return 0;
        }
    }

    public int method_161(StarSystem gclass200_0)
    {
        try
        {
            return gclass200_0 != null ? gclass200_0.SystemID : 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1510);
            return 0;
        }
    }

    public int method_374(GClass91 gclass91_0)
    {
        try
        {
            var num1 = gclass91_0.int_1;
            var list1 = FleetDictionary.Values
                .Where(gclass85_0 => gclass85_0.MoveOrderDictionary.Count > 0)
                .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values).Where(
                    gclass139_0 =>
                        (gclass139_0.MoveActionType.MoveActionType == MoveActionType.FollowTarget &&
                         gclass139_0.DestinationType == DestinationType.const_4 && gclass139_0.MinDistance < 5000000.0) ||
                        gclass139_0.DestinationType == DestinationType.const_0 || gclass139_0.DestinationType == DestinationType.const_3)
                .Select<MoveOrder, FleetData>(gclass139_0 => gclass139_0.Fleet).Distinct()
                .ToList();
            var list2 = list1.Where(gclass85_0 => gclass85_0.Race.NPR)
                .Where(gclass85_0 => gclass85_0.NPROperationGroup.genum104_0 == GEnum104.const_5).ToList();
            var list3 = list1.Except(list2).ToList();
            if (list3.Count == 0)
                return 0;
            foreach (var gclass85 in list3)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                var class92 = new Class92();
                // ISSUE: reference to a compiler-generated field
                class92.gclass0_0 = this;
                // ISSUE: reference to a compiler-generated field
                class92.gclass85_0 = gclass85;
                // ISSUE: reference to a compiler-generated field
                using (Dictionary<int, MoveOrder>.ValueCollection.Enumerator enumerator =
                       class92.gclass85_0.MoveOrderDictionary.Values.GetEnumerator())
                {
                    if (enumerator.MoveNext())
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        var class93 = new Class93();
                        // ISSUE: reference to a compiler-generated field
                        class93.class92_0 = class92;
                        // ISSUE: reference to a compiler-generated field
                        class93.gclass139_0 = enumerator.Current;
                        var gclass221 = new GClass221(0.0, 0.0);
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class93.gclass139_0.MoveActionType.MoveActionType == MoveActionType.FollowTarget &&
                            class93.gclass139_0.DestinationType == DestinationType.const_4)
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (Contacts.ContainsKey(class93.gclass139_0.DestinationID))
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (Contacts[class93.gclass139_0.DestinationID].method_5() ==
                                    AuroraContactStatus.Hostile)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    if (Contacts[class93.gclass139_0.DestinationID].ContactType ==
                                        AuroraContactType.Ship)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (Contacts[class93.gclass139_0.DestinationID].TargetShip.gclass85_0
                                                .System.ActualSystem ==
                                            class93.class92_0.gclass85_0.System.ActualSystem)
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            gclass221 = method_50(
                                                Contacts[class93.gclass139_0.DestinationID].TargetShip.gclass85_0,
                                                class93.class92_0.gclass85_0, null, 0.0);
                                        else
                                            continue;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (class93.gclass139_0.DestinationType == DestinationType.const_3)
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (Waypoints.ContainsKey(class93.gclass139_0.DestinationID))
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
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated method
                                    if (FleetDictionary.Values
                                            .Where(class93.class92_0.func_0 ??
                                                   (class93.class92_0.func_0 = class93.class92_0.method_0))
                                            .Where(class93.method_0)
                                            .FirstOrDefault(class93.class92_0.func_1 ??
                                                            (class93.class92_0.func_1 =
                                                                class93.class92_0.method_1)) != null)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        gclass221.double_0 = Waypoints[class93.gclass139_0.DestinationID].Xcor;
                                        // ISSUE: reference to a compiler-generated field
                                        gclass221.double_1 = Waypoints[class93.gclass139_0.DestinationID].Ycor;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (class93.gclass139_0.DestinationType == DestinationType.const_0)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    if (JumpPointDictionary.ContainsKey(class93.gclass139_0.DestinationID))
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
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated method
                                        if (FleetDictionary.Values
                                                .Where(class93.class92_0.func_2 ??
                                                       (class93.class92_0.func_2 =
                                                           class93.class92_0.method_2))
                                                .Where(class93.method_1)
                                                .FirstOrDefault(class93.class92_0.func_3 ??
                                                                (class93.class92_0.func_3 =
                                                                    class93.class92_0.method_3)) != null)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            gclass221.double_0 = JumpPointDictionary[class93.gclass139_0.DestinationID]
                                                .XCoord;
                                            // ISSUE: reference to a compiler-generated field
                                            gclass221.double_1 = JumpPointDictionary[class93.gclass139_0.DestinationID]
                                                .YCoord;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                        }

                        if (gclass221.double_0 == 0.0)
                            if (gclass221.double_1 == 0.0)
                                continue;

                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        var num2 = GetDistanceBetween(class93.class92_0.gclass85_0.XCoord,
                            class93.class92_0.gclass85_0.YCoord, gclass221.double_0, gclass221.double_1);
                        var num3 = num2 * 0.2;
                        if (num3 > 500000.0)
                            num3 = 500000.0;
                        var num4 = num2 - num3;
                        if (num4 < 1.0)
                            num4 = 0.0;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class93.class92_0.gclass85_0.Speed * gclass91_0.int_1 >= num4)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            var num5 = (int)(num4 / class93.class92_0.gclass85_0.Speed);
                            if (num5 < num1)
                                num1 = num5;
                        }
                    }
                }
            }

            if (num1 < 5)
                num1 = 5;
            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3473);
            return gclass91_0.int_1;
        }
    }

    public int method_375(int int_136)
    {
        try
        {
            var num1 = int_136;
            var list1 = Ships.Values
                .Where(gclass40_0 => gclass40_0.gclass40_0 == null && gclass40_0.int_13 == 0)
                .Where(gclass40_0 => gclass40_0.method_18(false)).ToList();
            if (list1.Count == 0)
                return 0;
            var source = new List<GClass82>();
            foreach (var gclass40 in list1)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                var class94 = new Class94();
                // ISSUE: reference to a compiler-generated field
                class94.gclass40_0 = gclass40;
                // ISSUE: reference to a compiler-generated field
                var list2 = class94.gclass40_0.list_4.Where<FireControlAssignment>(gclass36_0 => gclass36_0.IsOpeningFire)
                    .ToList();
                if (list2.Count != 0)
                {
                    GClass82 gclass82 = null;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class94.gclass40_0.gclass21_0.NPR &&
                        class94.gclass40_0.gclass22_0.AutomatedClassDesign.MissileDesignType == MissileDesignType.const_3)
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (class94.gclass40_0.list_10.Count<PopOrdnanceStock>(gclass130_0 =>
                                gclass130_0.RaceMissile.ShipDecoy == 0) != 0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            var num2 = class94.gclass40_0.list_2.Count<WeaponFireControlAssignment>(gclass31_0 =>
                                gclass31_0.WeaponComponent.gclass231_0.ComponentTypeID ==
                                AuroraComponentType.MissileLauncher && gclass31_0.WeaponComponent.decimal_3 > 3M);
                            // ISSUE: reference to a compiler-generated field
                            if (class94.gclass40_0.list_10
                                    .Where<PopOrdnanceStock>(gclass130_0 => gclass130_0.RaceMissile.ShipDecoy == 0)
                                    .Sum(gclass130_0 => gclass130_0.Amount) >= num2)
                            {
                                // ISSUE: reference to a compiler-generated method
                                gclass82 = source.FirstOrDefault(class94.method_0);
                                if (gclass82 == null)
                                {
                                    gclass82 = new GClass82();
                                    // ISSUE: reference to a compiler-generated field
                                    gclass82.gclass202_0 = class94.gclass40_0.gclass85_0.System;
                                    // ISSUE: reference to a compiler-generated field
                                    gclass82.double_0 = class94.gclass40_0.gclass85_0.XCoord;
                                    // ISSUE: reference to a compiler-generated field
                                    gclass82.double_1 = class94.gclass40_0.gclass85_0.YCoord;
                                    gclass82.decimal_0 = 0M;
                                    source.Add(gclass82);
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }

                    foreach (var gclass36 in list2)
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        var class95 = new Class95();
                        // ISSUE: reference to a compiler-generated field
                        class95.gclass36_0 = gclass36;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        var list3 = class94.gclass40_0.list_2.Where<WeaponFireControlAssignment>(class95.method_0)
                            .ToList();
                        if (list3.Count != 0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            var num3 = class95.gclass36_0.method_3(class94.gclass40_0);
                            if (num3 != 0.0)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                var num4 = class95.gclass36_0.method_2(class94.gclass40_0.gclass85_0);
                                if (num4 <= num3 && num4 != -1.0)
                                    foreach (var gclass31 in list3)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: object of a compiler-generated type is created
                                        // ISSUE: reference to a compiler-generated method
                                        var gclass27 = class94.gclass40_0.list_7.FirstOrDefault<WeaponComponentRechargeStatus>(
                                            new Class96
                                            {
                                                gclass31_0 = gclass31
                                            }.method_0);
                                        if (gclass27 == null)
                                        {
                                            if (gclass82 == null)
                                                return 5;
                                            if (gclass82.decimal_0 == 0M)
                                                gclass82.decimal_0 = 5M;
                                        }
                                        else if (gclass27.WeaponComponent.gclass231_0.ComponentTypeID ==
                                                 AuroraComponentType.MissileLauncher)
                                        {
                                            if (gclass82 == null)
                                            {
                                                if (gclass27.RemainingRecharge <= 5M)
                                                    return 5;
                                                if (gclass27.RemainingRecharge < num1)
                                                    num1 = (int)gclass27.RemainingRecharge;
                                            }
                                            else if (gclass27.RemainingRecharge > gclass82.decimal_0)
                                            {
                                                gclass82.decimal_0 = gclass27.RemainingRecharge;
                                            }
                                        }
                                        else
                                        {
                                            if (gclass27.WeaponComponent.gclass231_0.ComponentTypeID ==
                                                AuroraComponentType.GaussCannon)
                                                return 5;
                                            var num5 = gclass27.WeaponComponent.decimal_4;
                                            // ISSUE: reference to a compiler-generated field
                                            var num6 = class94.gclass40_0.method_157(AuroraComponentType.PowerPlant,
                                                false);
                                            if (!(num6 == 0M))
                                            {
                                                if (num6 < num5)
                                                    num5 = num6;
                                                var num7 = gclass27.RemainingRecharge / num5 * 5M;
                                                if (num7 <= 5M)
                                                    return 5;
                                                if (num7 < num1)
                                                    num1 = (int)num7;
                                            }
                                        }
                                    }
                            }
                        }
                    }
                }
            }

            if (source.Count > 0)
            {
                var num8 = source.Min(gclass82_0 => gclass82_0.decimal_0);
                if (num8 > 0M && num8 < num1)
                    num1 = (int)num8;
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1519);
            return 0;
        }
    }

    public int method_587()
    {
        try
        {
            return (int)Math.Floor(GameTime / AuroraUtils.decimal_29) + StartYear;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3594);
            return 0;
        }
    }


    public int method_445(decimal decimal_13)
    {
        try
        {
            return (int)(Math.Sqrt((double)decimal_13 * 5000.0) * (ResearchSpeed / 100.0));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3388);
            return 1;
        }
    }

    public int method_514(ListView listView_0)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            var class227 = new Class227();
            var num1 = 180;
            // ISSUE: reference to a compiler-generated field
            class227.list_0 = GameRaces.Values
                .Where(gclass21_2 => !gclass21_2.NPR || bool_10)
                .OrderBy<GameRace, string>(gclass21_0 => gclass21_0.RaceTitle).ToList();
            // ISSUE: reference to a compiler-generated field
            foreach (var gclass21 in class227.list_0)
            {
                listView_0.Columns.Add(gclass21.RaceTitle, 90, HorizontalAlignment.Center);
                num1 += 90;
            }

            listView_0.Items.Clear();
            var listViewItem1 = new ListViewItem("");
            // ISSUE: reference to a compiler-generated field
            foreach (var gclass21 in class227.list_0)
                listViewItem1.SubItems.Add(gclass21.RaceName);
            listView_0.Items.Add(listViewItem1);
            method_597(listView_0, "", null);
            var listViewItem2 = new ListViewItem("Total Population");
            var listViewItem3 = new ListViewItem("Current Wealth");
            var listViewItem4 = new ListViewItem("Naval Tonnage");
            var listViewItem5 = new ListViewItem("Commercial Tonnage");
            var listViewItem6 = new ListViewItem("Space Station Tonnage");
            var listViewItem7 = new ListViewItem("Shipping Line Tonnage");
            var listViewItem8 = new ListViewItem("Ground Transport Size (tons)");
            var listViewItem9 = new ListViewItem("Naval Shipyard Capacity");
            var listViewItem10 = new ListViewItem("Commercial Shipyard Capacity");
            var listViewItem11 = new ListViewItem("Repair Yard Capacity");
            var listViewItem12 = new ListViewItem("Fuel at Colonies");
            var listViewItem13 = new ListViewItem("Fuel on Ships");
            var listViewItem14 = new ListViewItem("Supply Points at Colonies");
            var listViewItem15 = new ListViewItem("Supply Points on Ships");
            var listViewItem16 = new ListViewItem("Total Missile Size at Colonies");
            var listViewItem17 = new ListViewItem("Total Missile Size on Ships");
            var listViewItem18 = new ListViewItem("Top Scientists");
            var listViewItem19 = new ListViewItem("");
            var listViewItem20 = new ListViewItem("");
            var dictionary = new Dictionary<PlanetaryInstallationType, ListViewItem>();
            // ISSUE: reference to a compiler-generated method
            var orderedEnumerable = Populations.Values
                .Where(class227.method_0)
                .SelectMany<PopulationData, PopulationInstallation>(gclass146_0 => gclass146_0.dictionary_0.Values)
                .GroupBy<PopulationInstallation, PlanetaryInstallationType>(gclass158_0 => gclass158_0.InstallationType)
                .OrderBy<IGrouping<PlanetaryInstallationType, PopulationInstallation>, decimal>(igrouping_0 => igrouping_0.Key.DisplayOrder);
            foreach (var grouping in orderedEnumerable)
            {
                var listViewItem21 = new ListViewItem(grouping.Key.Name);
                dictionary.Add(grouping.Key, listViewItem21);
            }

            // ISSUE: reference to a compiler-generated field
            using (List<GameRace>.Enumerator enumerator = class227.list_0.GetEnumerator())
            {
                label_78:
                while (enumerator.MoveNext())
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    var class228 = new Class228();
                    // ISSUE: reference to a compiler-generated field
                    class228.gclass21_0 = enumerator.Current;
                    // ISSUE: reference to a compiler-generated method
                    var list1 = Populations.Values.Where(class228.method_0)
                        .ToList();
                    // ISSUE: reference to a compiler-generated method
                    var decimal_73_1 = list1.Where(class228.method_1)
                        .Sum(gclass146_0 => gclass146_0.decimal_30);
                    listViewItem2.SubItems.Add(AuroraUtils.smethod_39(decimal_73_1));
                    // ISSUE: reference to a compiler-generated field
                    listViewItem3.SubItems.Add(AuroraUtils.smethod_39(class228.gclass21_0.WealthPoints));
                    // ISSUE: reference to a compiler-generated method
                    var decimal_73_2 =
                        Ships.Values.Where(class228.method_2)
                            .Sum(gclass40_0 => gclass40_0.gclass22_0.Size) *
                        AuroraUtils.decimal_17;
                    // ISSUE: reference to a compiler-generated method
                    var decimal_73_3 =
                        Ships.Values.Where(class228.method_3)
                            .Sum(gclass40_0 => gclass40_0.gclass22_0.Size) *
                        AuroraUtils.decimal_17;
                    // ISSUE: reference to a compiler-generated method
                    var decimal_73_4 =
                        Ships.Values.Where(class228.method_4)
                            .Sum(gclass40_0 => gclass40_0.gclass22_0.Size) *
                        AuroraUtils.decimal_17;
                    // ISSUE: reference to a compiler-generated method
                    var decimal_73_5 =
                        Ships.Values.Where(class228.method_5)
                            .Sum(gclass40_0 => gclass40_0.gclass22_0.Size) *
                        AuroraUtils.decimal_17;
                    // ISSUE: reference to a compiler-generated method
                    var decimal_73_6 = FormationDictionary.Values.Where(class228.method_6)
                        .SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 => gclass103_0.ElementList).Sum(gclass39_0 =>
                            gclass39_0.GroundUnitClass.decimal_2 * gclass39_0.UnitCount);
                    // ISSUE: reference to a compiler-generated method
                    var decimal_73_7 = dictionary_31.Values.Where(class228.method_7)
                        .Sum(gclass193_0 => gclass193_0.decimal_0 * gclass193_0.int_1);
                    // ISSUE: reference to a compiler-generated method
                    var decimal_73_8 = dictionary_31.Values.Where(class228.method_8)
                        .Sum(gclass193_0 => gclass193_0.decimal_0 * gclass193_0.int_1);
                    // ISSUE: reference to a compiler-generated method
                    var decimal_73_9 = dictionary_31.Values.Where(class228.method_9)
                        .Sum(gclass193_0 => gclass193_0.decimal_0 * gclass193_0.int_1);
                    if (decimal_73_2 > 0M)
                        listViewItem4.SubItems.Add(AuroraUtils.smethod_39(decimal_73_2));
                    else
                        listViewItem4.SubItems.Add("-");
                    if (decimal_73_3 > 0M)
                        listViewItem5.SubItems.Add(AuroraUtils.smethod_39(decimal_73_3));
                    else
                        listViewItem5.SubItems.Add("-");
                    if (decimal_73_4 > 0M)
                        listViewItem6.SubItems.Add(AuroraUtils.smethod_39(decimal_73_4));
                    else
                        listViewItem6.SubItems.Add("-");
                    if (decimal_73_5 > 0M)
                        listViewItem7.SubItems.Add(AuroraUtils.smethod_39(decimal_73_5));
                    else
                        listViewItem7.SubItems.Add("-");
                    if (decimal_73_6 > 0M)
                        listViewItem8.SubItems.Add(AuroraUtils.smethod_39(decimal_73_6));
                    else
                        listViewItem8.SubItems.Add("-");
                    if (decimal_73_7 > 0M)
                        listViewItem9.SubItems.Add(AuroraUtils.smethod_39(decimal_73_7));
                    else
                        listViewItem9.SubItems.Add("-");
                    if (decimal_73_8 > 0M)
                        listViewItem10.SubItems.Add(AuroraUtils.smethod_39(decimal_73_8));
                    else
                        listViewItem10.SubItems.Add("-");
                    if (decimal_73_9 > 0M)
                        listViewItem10.SubItems.Add(AuroraUtils.smethod_39(decimal_73_9));
                    else
                        listViewItem11.SubItems.Add("-");
                    // ISSUE: reference to a compiler-generated method
                    var decimal_73_10 = list1.Where(class228.method_10)
                        .Sum(gclass146_0 => gclass146_0.FuelStockpile);
                    // ISSUE: reference to a compiler-generated method
                    var decimal_73_11 = list1.Where(class228.method_11)
                        .Sum(gclass146_0 => gclass146_0.MaintenanceStockpile);
                    // ISSUE: reference to a compiler-generated method
                    var decimal_73_12 = Ships.Values.Where(class228.method_12)
                        .Sum(gclass40_0 => gclass40_0.decimal_14);
                    // ISSUE: reference to a compiler-generated method
                    var decimal_73_13 = Ships.Values.Where(class228.method_13)
                        .Sum(gclass40_0 => gclass40_0.decimal_4);
                    // ISSUE: reference to a compiler-generated method
                    var decimal_73_14 = list1.Where(class228.method_14)
                        .SelectMany<PopulationData, PopOrdnanceStock>(gclass146_0 => gclass146_0.OrdnanceStocks)
                        .Sum(gclass130_0 => gclass130_0.Amount * gclass130_0.RaceMissile.Size);
                    // ISSUE: reference to a compiler-generated method
                    var decimal_73_15 = Ships.Values.Where(class228.method_15)
                        .SelectMany<ShipData, PopOrdnanceStock>(gclass40_0 => gclass40_0.list_10)
                        .Sum(gclass130_0 => gclass130_0.Amount * gclass130_0.RaceMissile.Size);
                    if (decimal_73_10 > 0M)
                        listViewItem12.SubItems.Add(AuroraUtils.smethod_39(decimal_73_10));
                    else
                        listViewItem12.SubItems.Add("-");
                    if (decimal_73_12 > 0M)
                        listViewItem13.SubItems.Add(AuroraUtils.smethod_39(decimal_73_12));
                    else
                        listViewItem13.SubItems.Add("-");
                    if (decimal_73_11 > 0M)
                        listViewItem14.SubItems.Add(AuroraUtils.smethod_39(decimal_73_11));
                    else
                        listViewItem14.SubItems.Add("-");
                    if (decimal_73_13 > 0M)
                        listViewItem15.SubItems.Add(AuroraUtils.smethod_39(decimal_73_13));
                    else
                        listViewItem15.SubItems.Add("-");
                    if (decimal_73_14 > 0M)
                        listViewItem16.SubItems.Add(AuroraUtils.smethod_39(decimal_73_14));
                    else
                        listViewItem16.SubItems.Add("-");
                    if (decimal_73_15 > 0M)
                        listViewItem17.SubItems.Add(AuroraUtils.smethod_39(decimal_73_15));
                    else
                        listViewItem17.SubItems.Add("-");
                    foreach (var grouping in orderedEnumerable)
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        var class229 = new Class229();
                        // ISSUE: reference to a compiler-generated field
                        class229.igrouping_0 = grouping;
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        var decimal_73_16 =
                            list1.SelectMany<PopulationData, PopulationInstallation>(gclass146_0 => gclass146_0.dictionary_0.Values)
                                .Where(class229.method_0)
                                .Sum(gclass158_0 => gclass158_0.Amount) + Ships
                                .Values.Where(class228.func_0 ?? (class228.func_0 = class228.method_16))
                                .SelectMany<ShipData, PopulationInstallation>(gclass40_0 => gclass40_0.TransportedInstallations.Values)
                                .Where(class229.method_1)
                                .Sum(gclass158_0 => gclass158_0.Amount);
                        if (decimal_73_16 > 0M)
                            // ISSUE: reference to a compiler-generated field
                            dictionary[class229.igrouping_0.Key].SubItems.Add(AuroraUtils.smethod_39(decimal_73_16));
                        else
                            // ISSUE: reference to a compiler-generated field
                            dictionary[class229.igrouping_0.Key].SubItems.Add("-");
                    }

                    // ISSUE: reference to a compiler-generated method
                    var list2 = dictionary_42.Values.Where(class228.method_17)
                        .OrderByDescending(gclass55_0 => gclass55_0.method_5(CommanderBonusType.Research))
                        .ThenByDescending(gclass55_0 => gclass55_0.method_5(CommanderBonusType.ResearchAdmin))
                        .ToList();
                    var num2 = 0;
                    foreach (var gclass55 in list2)
                    {
                        ++num2;
                        switch (num2)
                        {
                            case 1:
                                listViewItem18.SubItems.Add(
                                    $"{gclass55.gclass162_0.Abbreviation} {gclass55.method_6(CommanderBonusType.Research)} {gclass55.method_6(CommanderBonusType.ResearchAdmin)}");
                                continue;
                            case 2:
                                listViewItem19.SubItems.Add(
                                    $"{gclass55.gclass162_0.Abbreviation} {gclass55.method_6(CommanderBonusType.Research)} {gclass55.method_6(CommanderBonusType.ResearchAdmin)}");
                                continue;
                            case 3:
                                listViewItem20.SubItems.Add(
                                    $"{gclass55.gclass162_0.Abbreviation} {gclass55.method_6(CommanderBonusType.Research)} {gclass55.method_6(CommanderBonusType.ResearchAdmin)}");
                                continue;
                            default:
                                goto label_78;
                        }
                    }
                }
            }

            listView_0.Items.Add(listViewItem2);
            listView_0.Items.Add(listViewItem3);
            method_597(listView_0, "", null);
            listView_0.Items.Add(listViewItem4);
            listView_0.Items.Add(listViewItem5);
            listView_0.Items.Add(listViewItem6);
            listView_0.Items.Add(listViewItem7);
            listView_0.Items.Add(listViewItem8);
            method_597(listView_0, "", null);
            listView_0.Items.Add(listViewItem9);
            listView_0.Items.Add(listViewItem10);
            method_597(listView_0, "", null);
            listView_0.Items.Add(listViewItem12);
            listView_0.Items.Add(listViewItem13);
            listView_0.Items.Add(listViewItem14);
            listView_0.Items.Add(listViewItem15);
            listView_0.Items.Add(listViewItem16);
            listView_0.Items.Add(listViewItem17);
            method_597(listView_0, "", null);
            foreach (var listViewItem22 in dictionary.Values)
                listView_0.Items.Add(listViewItem22);
            method_597(listView_0, "", null);
            listView_0.Items.Add(listViewItem18);
            listView_0.Items.Add(listViewItem19);
            listView_0.Items.Add(listViewItem20);
            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1633);
            return 1400;
        }
    }

    public double method_424(
        ShipData gclass40_0,
        List<GroundUnitFormationData> list_33,
        List<GroundUnitFormationData> list_34,
        int int_136)
    {
        try
        {
            long num1 = 0;
            var num2 = 0.0;
            foreach (var gclass103 in list_34)
            {
                var num3 = gclass103.method_39();
                gclass103.long_0 = num1 + 1L;
                num1 += num3;
                gclass103.long_1 = num1;
                gclass103.decimal_18 = 1M;
                if (gclass103.gclass55_0 != null)
                    gclass103.decimal_18 = gclass103.gclass55_0.method_3(CommanderBonusType.GroundCombatDefence);
            }

            foreach (var gclass103 in list_33)
            {
                gclass103.decimal_19 = 1M;
                if (gclass103.gclass55_0 != null)
                    gclass103.decimal_19 = gclass103.gclass55_0.method_3(CommanderBonusType.GroundCombatOffence);
            }

            var list1 = list_33.SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 => gclass103_0.ElementList)
                .ToList();
            var list2 = list_34.SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 => gclass103_0.ElementList)
                .ToList();
            var int_9 = 0;
            foreach (var gclass39 in list2)
            {
                var num4 = (int)(gclass39.UnitCount * gclass39.GroundUnitClass.decimal_2);
                gclass39.long_0 = int_9 + 1;
                int_9 += num4;
                gclass39.long_1 = int_9;
            }

            foreach (var gclass39 in list1)
                num2 += gclass39.method_10(gclass40_0, list2, int_9, int_136);
            return num2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1819);
            return 0.0;
        }
    }

    public double method_517(
        double double_8,
        double double_9,
        double double_10,
        double double_11,
        double double_12,
        double double_13)
    {
        try
        {
            var num1 = GetDistanceBetween(double_8, double_9, double_10, double_11);
            var double_10_1 = double_10;
            var double_11_1 = double_11;
            var num2 = (double_12 - double_10) / 1000.0;
            var num3 = (double_13 - double_11) / 1000.0;
            for (var index = 1; index < 1001; ++index)
            {
                double_10_1 += num2;
                double_11_1 += num3;
                var num4 = GetDistanceBetween(double_8, double_9, double_10_1, double_11_1);
                if (num4 > num1)
                    return num1;
                num1 = num4;
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1636);
            return 0.0;
        }
    }


    public double method_591(double double_8, double double_9, double double_10, double double_11)
    {
        try
        {
            var x = double_10 - double_8;
            var num = Math.Atan2(double_11 - double_9, x) * (180.0 / Math.PI) - 90.0;
            if (num < 0.0)
                num += 360.0;
            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1692);
            return 0.0;
        }
    }

    public double method_693(StellarType gclass217_0, StellarType gclass217_1)
    {
        try
        {
            return (gclass217_0.Radius + gclass217_1.Radius) * 2.0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3232);
            return 1.0;
        }
    }

    public double method_694(
        StellarType gclass217_0,
        StellarType gclass217_1,
        double double_8,
        double double_9)
    {
        try
        {
            var num1 = 0.0;
            var num2 = (gclass217_0.Radius + gclass217_1.Radius) / 50.0;
            if (num2 > double_9)
                double_9 = num2;
            if (double_9 > double_8 && double_8 > 0.0)
            {
                num1 = (double_9 + double_8) / 2.0;
                if (num1 < num2)
                    num1 = num2 * 1.2;
            }
            else if (double_9 > 1000.0)
            {
                num1 = double_9 + double_9 * (AuroraUtils.GetRandomInteger(100) / 100.0);
            }
            else
            {
                do
                {
                    switch (AuroraUtils.GetRandomInteger(5))
                    {
                        case 1:
                            num1 = AuroraUtils.GetRandomInteger(100) * 0.005;
                            break;
                        case 2:
                            num1 = AuroraUtils.GetRandomInteger(100) * 0.05;
                            break;
                        case 3:
                            num1 = AuroraUtils.GetRandomInteger(100) * 0.3;
                            break;
                        case 4:
                            num1 = AuroraUtils.GetRandomInteger(100) * 2;
                            break;
                        case 5:
                            num1 = AuroraUtils.GetRandomInteger(100) * 20;
                            break;
                    }
                } while (num1 <= double_9 || (num1 >= double_8 && double_8 != 0.0));
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1609);
            return 0.0;
        }
    }

    public decimal method_40(decimal decimal_13)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            var class295 = new Class295
            {
                list_0 = null
            };
            // ISSUE: reference to a compiler-generated field
            class295.list_0 = Ships.Values.Where(gclass40_0 =>
                gclass40_0.method_157(AuroraComponentType.HangarDeck, false) > 0M ||
                gclass40_0.method_157(AuroraComponentType.CommercialHangarDeck, false) > 0M).ToList();
            // ISSUE: reference to a compiler-generated field
            if (class295.list_0.Count == 0)
                return decimal_13;
            // ISSUE: reference to a compiler-generated method
            var list1 = Ships.Values.Where(class295.method_0)
                .ToList();
            if (list1.Count == 0)
                return decimal_13;
            var num1 = decimal_13;
            var num2 = 0M;
            var flag = false;
            // ISSUE: reference to a compiler-generated field
            foreach (var gclass40_1 in class295.list_0)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                var class296 = new Class296();
                // ISSUE: reference to a compiler-generated field
                class296.gclass40_0 = gclass40_1;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class296.gclass40_0.list_10.Count != 0 || class296.gclass40_0.genum43_0 != GEnum43.const_0)
                {
                    // ISSUE: reference to a compiler-generated method
                    var list2 = list1.Where(class296.method_0).ToList();
                    if (list2.Count != 0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        var num3 = class296.gclass40_0.method_123(CommanderBonusType.CarrierOperations);
                        // ISSUE: reference to a compiler-generated field
                        var num4 = class296.gclass40_0.gclass21_0.MaxOrdnanceTransferRate * num3 *
                                   (decimal_13 / 3600M);
                        foreach (var gclass40_2 in list2)
                            gclass40_2.decimal_39 = num4 + gclass40_2.decimal_40;
                        foreach (var gclass40_3 in list2)
                        {
                            List<PopOrdnanceStock> source = gclass40_3.gclass22_0.list_0;
                            if (gclass40_3.list_9.Count > 0)
                                source = gclass40_3.list_9;
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (class296.gclass40_0.genum43_0 == GEnum43.const_1 ||
                                class296.gclass40_0.genum43_0 == GEnum43.const_2)
                            {
                                // ISSUE: reference to a compiler-generated field
                                var num5 = class296.gclass40_0.method_210();
                                if (num5 > 0M)
                                    foreach (var gclass130_1 in gclass40_3.list_10
                                                 .OrderByDescending<PopOrdnanceStock, decimal>(gclass130_0 =>
                                                     gclass130_0.RaceMissile.Size).ToList())
                                    {
                                        // ISSUE: object of a compiler-generated type is created
                                        // ISSUE: variable of a compiler-generated type
                                        var class297 = new Class297();
                                        // ISSUE: reference to a compiler-generated field
                                        class297.gclass130_0 = gclass130_1;
                                        var num6 = 0;
                                        // ISSUE: reference to a compiler-generated field
                                        if (class296.gclass40_0.genum43_0 == GEnum43.const_1)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            num6 = class297.gclass130_0.Amount;
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated method
                                            var gclass130_2 = source.FirstOrDefault(class297.method_0);
                                            if (gclass130_2 == null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                num6 = class297.gclass130_0.Amount;
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                if (gclass130_2.Amount < class297.gclass130_0.Amount)
                                                    // ISSUE: reference to a compiler-generated field
                                                    num6 = class297.gclass130_0.Amount - gclass130_2.Amount;
                                            }
                                        }

                                        if (num6 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            var int_40 = (int)Math.Floor(gclass40_3.decimal_39 /
                                                                         class297.gclass130_0.RaceMissile.Size);
                                            if (int_40 > num6)
                                                int_40 = num6;
                                            // ISSUE: reference to a compiler-generated field
                                            if (int_40 * class297.gclass130_0.RaceMissile.Size > num5)
                                                // ISSUE: reference to a compiler-generated field
                                                int_40 = (int)Math.Floor(num5 / class297.gclass130_0.RaceMissile
                                                    .Size);

                                            if (int_40 > 0)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                class297.gclass130_0.Amount -= int_40;
                                                // ISSUE: reference to a compiler-generated field
                                                if (class297.gclass130_0.Amount == 0)
                                                    // ISSUE: reference to a compiler-generated field
                                                    gclass40_3.list_10.Remove(class297.gclass130_0);

                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class296.gclass40_0.method_115(class297.gclass130_0.RaceMissile,
                                                    int_40);
                                                // ISSUE: reference to a compiler-generated field
                                                gclass40_3.decimal_39 -=
                                                    int_40 * class297.gclass130_0.RaceMissile.Size;
                                                // ISSUE: reference to a compiler-generated field
                                                if (class297.gclass130_0.RaceMissile.Size > num2)
                                                    // ISSUE: reference to a compiler-generated field
                                                    num2 = class297.gclass130_0.RaceMissile.Size;
                                            }
                                            else if (num6 > 0)
                                            {
                                                flag = true;
                                            }
                                        }
                                    }
                            }

                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (class296.gclass40_0.genum43_0 == GEnum43.const_0 ||
                                class296.gclass40_0.genum43_0 == GEnum43.const_2)
                            {
                                var num7 = gclass40_3.method_210();
                                if (num7 > 0M)
                                    foreach (var gclass130_3 in source
                                                 .OrderByDescending(gclass130_0 =>
                                                     gclass130_0.RaceMissile.Size).ToList())
                                    {
                                        // ISSUE: object of a compiler-generated type is created
                                        // ISSUE: variable of a compiler-generated type
                                        var class298 = new Class298();
                                        // ISSUE: reference to a compiler-generated field
                                        class298.gclass130_0 = gclass130_3;
                                        // ISSUE: reference to a compiler-generated method
                                        var gclass130_4 =
                                            gclass40_3.list_10.FirstOrDefault<PopOrdnanceStock>(class298.method_0);
                                        // ISSUE: reference to a compiler-generated field
                                        var num8 = class298.gclass130_0.Amount;
                                        if (gclass130_4 != null)
                                            // ISSUE: reference to a compiler-generated field
                                            num8 = class298.gclass130_0.Amount - gclass130_4.Amount;

                                        if (num8 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated method
                                            var gclass130_5 =
                                                class296.gclass40_0.list_10
                                                    .FirstOrDefault<PopOrdnanceStock>(class298.method_1);
                                            if (gclass130_5 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                var int_40 = (int)Math.Floor(gclass40_3.decimal_39 /
                                                                             class298.gclass130_0.RaceMissile
                                                                                 .Size);
                                                if (int_40 > num8)
                                                    int_40 = num8;
                                                if (int_40 > gclass130_5.Amount)
                                                    int_40 = gclass130_5.Amount;
                                                // ISSUE: reference to a compiler-generated field
                                                if (int_40 * class298.gclass130_0.RaceMissile.Size > num7)
                                                    // ISSUE: reference to a compiler-generated field
                                                    int_40 = (int)Math.Floor(num7 / class298.gclass130_0.RaceMissile
                                                        .Size);

                                                if (int_40 > 0)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    gclass40_3.method_115(class298.gclass130_0.RaceMissile, int_40);
                                                    gclass130_5.Amount -= int_40;
                                                    if (gclass130_5.Amount == 0)
                                                        // ISSUE: reference to a compiler-generated field
                                                        class296.gclass40_0.list_10.Remove(gclass130_5);

                                                    // ISSUE: reference to a compiler-generated field
                                                    gclass40_3.decimal_39 -=
                                                        int_40 * class298.gclass130_0.RaceMissile.Size;
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class298.gclass130_0.RaceMissile.Size > num2)
                                                        // ISSUE: reference to a compiler-generated field
                                                        num2 = class298.gclass130_0.RaceMissile.Size;
                                                }
                                                else if (num8 > 0)
                                                {
                                                    flag = true;
                                                }
                                            }
                                        }
                                    }
                            }

                            if (!(gclass40_3.decimal_39 < num2) && !flag)
                            {
                                var num9 = decimal_13 * (gclass40_3.decimal_39 / num4);
                                if (num9 < num1)
                                    num1 = num9;
                                gclass40_3.decimal_40 = 0M;
                            }
                            else
                            {
                                gclass40_3.decimal_40 = gclass40_3.decimal_39;
                                num1 = 0M;
                            }
                        }
                    }
                }
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1411);
            return 0M;
        }
    }

    public decimal method_385(AlienRaceInfo gclass110_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        var class102 = new Class102();
        // ISSUE: reference to a compiler-generated field
        class102.gclass110_0 = gclass110_0;
        // ISSUE: reference to a compiler-generated field
        class102.gclass0_0 = this;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            var class103 = new Class103
            {
                class102_0 = class102
            };
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class103.class102_0.gclass110_0.ActualAlienRace.gclass40_0 = null;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class103.class102_0.gclass110_0.ActualAlienRace.gclass55_0 = null;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            class103.list_0 = Contacts.Values.Where(class103.class102_0.method_0)
                .Select<Contact, StarSystem>(gclass65_0 => gclass65_0.System).Distinct()
                .ToList();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            var list1 = Contacts.Values.Where(class103.class102_0.method_1)
                .Select<Contact, StarSystem>(gclass65_0 => gclass65_0.System).Distinct()
                .ToList();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class103.list_0 = class103.list_0.Intersect<StarSystem>(list1).ToList();
            // ISSUE: reference to a compiler-generated field
            if (class103.list_0.Count<StarSystem>() == 0)
                return 0M;
            var gclass40List = new List<ShipData>();
            // ISSUE: reference to a compiler-generated method
            var list2 = Ships.Values.Where(class103.method_0)
                .Where(gclass40_0 =>
                    gclass40_0.method_157(AuroraComponentType.DiplomacyModule, false) > 0M).ToList();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class103.class102_0.gclass110_0.ActualAlienRace.gclass55_0 = list2
                .Select<ShipData, GClass55>(gclass40_0 => gclass40_0.method_192(AuroraCommandType.Ship))
                .Where(gclass55_0 => gclass55_0 != null)
                .OrderByDescending(gclass55_0 => gclass55_0.method_5(CommanderBonusType.Diplomacy))
                .FirstOrDefault();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class103.class102_0.gclass110_0.ActualAlienRace.gclass55_0 == null)
                return 1M;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class103.class102_0.gclass110_0.ActualAlienRace.gclass40_0 =
                class103.class102_0.gclass110_0.ActualAlienRace.gclass55_0.gclass40_1;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            return class103.class102_0.gclass110_0.ActualAlienRace.gclass55_0.method_5(CommanderBonusType.Diplomacy);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1529);
            return 0M;
        }
    }

    public decimal method_386(AlienRaceInfo gclass110_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        var class104 = new Class104();
        // ISSUE: reference to a compiler-generated field
        class104.gclass110_0 = gclass110_0;
        // ISSUE: reference to a compiler-generated field
        class104.gclass0_0 = this;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            var class105 = new Class105();
            // ISSUE: reference to a compiler-generated field
            class105.class104_0 = class104;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class105.class104_0.gclass110_0 == null)
                return 0M;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class105.class104_0.gclass110_0.ViewingRace.gclass40_0 = null;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class105.class104_0.gclass110_0.ViewingRace.gclass55_0 = null;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            class105.list_0 = Contacts.Values.Where(class105.class104_0.method_0)
                .Select<Contact, StarSystem>(gclass65_0 => gclass65_0.System).Distinct()
                .ToList();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            var list1 = Contacts.Values.Where(class105.class104_0.method_1)
                .Select<Contact, StarSystem>(gclass65_0 => gclass65_0.System).Distinct()
                .ToList();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class105.list_0 = class105.list_0.Intersect<StarSystem>(list1).ToList();
            // ISSUE: reference to a compiler-generated field
            if (class105.list_0.Count<StarSystem>() == 0)
                return 0M;
            var gclass40List = new List<ShipData>();
            // ISSUE: reference to a compiler-generated method
            var list2 = Ships.Values.Where(class105.method_0)
                .Where(gclass40_0 =>
                    gclass40_0.method_157(AuroraComponentType.DiplomacyModule, false) > 0M).ToList();
            if (list2.Count == 0)
                return 1M;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class105.class104_0.gclass110_0.ViewingRace.gclass55_0 = list2
                .Select<ShipData, GClass55>(gclass40_0 => gclass40_0.method_192(AuroraCommandType.Ship))
                .Where(gclass55_0 => gclass55_0 != null)
                .OrderByDescending(gclass55_0 => gclass55_0.method_5(CommanderBonusType.Communications))
                .FirstOrDefault();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class105.class104_0.gclass110_0.ViewingRace.gclass55_0 == null)
                return 1M;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class105.class104_0.gclass110_0.ViewingRace.gclass40_0 =
                class105.class104_0.gclass110_0.ViewingRace.gclass55_0.gclass40_1;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            return class105.class104_0.gclass110_0.ViewingRace.gclass55_0.method_5(CommanderBonusType.Communications);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1530);
            return 1M;
        }
    }

    public decimal method_441(
        PopulationData gclass146_1,
        AuroraInstallationType auroraInstallationType_0,
        int int_136)
    {
        try
        {
            if (gclass146_1.decimal_89 < int_136 * InstallationTypes[auroraInstallationType_0].Workers)
                int_136 = (int)(gclass146_1.decimal_89 / InstallationTypes[auroraInstallationType_0].Workers);
            if (int_136 == 0)
                return gclass146_1.decimal_89;
            gclass146_1.method_65(auroraInstallationType_0, int_136);
            gclass146_1.decimal_89 -= int_136 * InstallationTypes[auroraInstallationType_0].Workers;
            return gclass146_1.decimal_89;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3847);
            return 0M;
        }
    }

    public decimal method_439(SystemBodyData gclass1_1, int int_136)
    {
        try
        {
            return gclass1_1.SystemData.int_13 < 2 ? int_136 : int_136 / (decimal)gclass1_1.SystemData.int_13;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3853);
            return 1M;
        }
    }

    public decimal method_497(decimal decimal_13, decimal decimal_14)
    {
        try
        {
            decimal num = (int)(decimal_13 / decimal_14 * 1000M);
            if (num > 270000M)
                num = 270000M;
            return num < 1M ? 1M : num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3862);
            return 1M;
        }
    }

    public decimal method_498(decimal decimal_13, int int_136, int int_137)
    {
        try
        {
            if (int_136 < 1)
                int_136 = 1;
            var num1 = Math.Pow(Math.Pow((double)decimal_13 * 0.75 / Math.PI, 1.0 / 3.0), 2.0) * 4.0 * Math.PI;
            var num2 = int_136 * (num1 / 4.0);
            var num3 = (int)(num2 / int_136);
            return (decimal)(num2 / int_137);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3863);
            return 0M;
        }
    }

    public decimal method_543()
    {
        try
        {
            var num1 = 30M;
            var num2 = GameRaces.Values.Where(gclass21_0 => !gclass21_0.NPR)
                .Count();
            return num2 > 0
                ? Populations.Values.Where(gclass146_0 => !gclass146_0.Race.NPR)
                    .Sum(gclass146_0 => gclass146_0.method_75(AuroraInstallationType.ResearchLab)) / num2
                : num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3548);
            return 0M;
        }
    }

    public decimal method_542()
    {
        try
        {
            var num1 = 0M;
            foreach (var gclass21 in GameRaces.Values
                         .Where(gclass21_0 => !gclass21_0.NPR).ToList())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                decimal num2 = TechDataDictionary.Values.Where(new Class239
                {
                    gclass21_0 = gclass21
                }.method_0).Sum(gclass164_0 => gclass164_0.int_4);
                if (num2 > num1)
                    num1 = num2;
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3827);
            return 0M;
        }
    }


    public decimal method_541()
    {
        try
        {
            var num1 = 0M;
            var num2 = GameRaces.Values.Where(gclass21_0 => !gclass21_0.NPR)
                .Count();
            if (num2 <= 0)
                return 1000M;
            foreach (var gclass146 in Populations.Values
                         .Where(gclass146_0 => !gclass146_0.Race.NPR && gclass146_0.ProvideColonists == 0)
                         .ToList())
                num1 += gclass146.PopulationPoliticalStatus.WealthModifier * gclass146.decimal_30;
            return num1 / num2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1659);
            return 0M;
        }
    }


    public decimal method_509()
    {
        try
        {
            var num = 0M;
            foreach (var gclass220 in Populations.Values
                         .Where(gclass146_0 =>
                             gclass146_0.SystemBodyData.AncientConstruct != null && gclass146_0.decimal_30 >= 1M)
                         .Where(gclass146_0 =>
                             gclass146_0.SystemBodyData.AncientConstruct.Active && !gclass146_0.Race.NPR)
                         .Select<PopulationData, AncientConstruct>(gclass146_0 => gclass146_0.SystemBodyData.AncientConstruct)
                         .Distinct().ToList())
                num += (gclass220.ResearchBonus - 1M) / 10M;
            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3264);
            return 0M;
        }
    }
}