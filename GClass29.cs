// Decompiled with JetBrains decompiler
// Type: GClass29
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
public class GClass29
{
    [CompilerGenerated]
    [Serializable]
    private sealed class staticCompGen
    {
        public static readonly GClass29.staticCompGen staticCompMem;
        public static Func<MissileSalvo, Decimal> staticCompMem__6_0;
        public static Func<MissileSalvo, int> staticCompMem__6_1;
        public static Func<MissileSalvo, int> staticCompMem__6_2;
        public static Func<KeyValuePair<int, int>, int> staticCompMem__6_3;
        public static Func<KeyValuePair<int, int>, int> staticCompMem__6_4;
        public static Func<KeyValuePair<int, int>, int> staticCompMem__6_5;
        public static Func<KeyValuePair<int, int>, int> staticCompMem__6_7;

        static staticCompGen()
        {
            GClass29.staticCompGen.staticCompMem = new GClass29.staticCompGen();
        }

        internal Decimal method_0(MissileSalvo gclass132_0)
        {
            return gclass132_0.RaceMissile.Speed;
        }

        internal int method_1(MissileSalvo gclass132_0)
        {
            return gclass132_0.RemainingDecoys.Count;
        }

        internal int method_2(MissileSalvo gclass132_0)
        {
            return gclass132_0.RemainingDecoys.Count * gclass132_0.RaceMissile.NumDecoys;
        }

        internal int method_3(KeyValuePair<int, int> keyValuePair_0)
        {
            return keyValuePair_0.Key;
        }

        internal int method_4(KeyValuePair<int, int> keyValuePair_0)
        {
            return keyValuePair_0.Key;
        }

        internal int method_5(KeyValuePair<int, int> keyValuePair_0)
        {
            return keyValuePair_0.Value;
        }

        internal int method_6(KeyValuePair<int, int> keyValuePair_0)
        {
            return keyValuePair_0.Value;
        }
    }

    public List<MissileSalvo> list_0 = new List<MissileSalvo>();
    public GClass0 gclass0_0;
    public GameRace gclass21_0;
    public StarSystem gclass200_0;
    public GClass221 gclass221_0;

    public GClass29(
        GClass0 gclass0_1,
        GClass221 gclass221_1,
        GameRace gclass21_1,
        StarSystem gclass200_1,
        MissileSalvo gclass132_0)
    {
        this.gclass0_0 = gclass0_1;
        this.gclass221_0 = gclass221_1;
        this.gclass21_0 = gclass21_1;
        this.gclass200_0 = gclass200_1;
        this.list_0.Add(gclass132_0);
    }

    public void method_0()
    {
        try
        {
            Dictionary<int, int> source = new Dictionary<int, int>();
            int int_0 = (int)this.list_0.Max<MissileSalvo>(gclass132_0 => gclass132_0.RaceMissile.Speed);
            int num1 = this.list_0.Sum<MissileSalvo>(gclass132_0 => gclass132_0.RemainingDecoys.Count);
            int num2 = this.list_0.Sum<MissileSalvo>(gclass132_0 =>
                gclass132_0.RemainingDecoys.Count * gclass132_0.RaceMissile.NumDecoys);
            if (num1 > 0)
            {
                Decimal num3 = 0M;
                if (num2 > 0)
                    num3 = num2 / (Decimal)num1;
                int num4 = this.gclass21_0.UnknownNprClass.method_11(this.gclass200_0, this.gclass221_0, int_0);
                if (num4 == 0)
                    return;
                foreach (MissileSalvo gclass132 in this.list_0)
                {
                    int key = (int)(this.gclass0_0.GetDistanceBetween(gclass132.double_0, gclass132.double_1,
                        this.gclass221_0.double_0,
                        this.gclass221_0.double_1) / (double)gclass132.RaceMissile.Speed);
                    if (source.ContainsKey(key))
                        source[key] += gclass132.RemainingDecoys.Count;
                    else
                        source.Add(key, gclass132.RemainingDecoys.Count);
                }

                source.OrderBy<KeyValuePair<int, int>, int>(keyValuePair_0 => keyValuePair_0.Key)
                    .ToDictionary<KeyValuePair<int, int>, int, int>(keyValuePair_0 => keyValuePair_0.Key,
                        keyValuePair_0 => keyValuePair_0.Value);
                foreach (KeyValuePair<int, int> keyValuePair in source)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: reference to a compiler-generated method
                    Decimal num5 = source
                        .Where(srcKvPair =>
                        {
                            return srcKvPair.Key >= keyValuePair.Key && srcKvPair.Key < keyValuePair.Key + 11;
                        }).Sum<KeyValuePair<int, int>>(keyValuePair_0 => keyValuePair_0.Value);
                    if (num5 + num3 * num5 > num4)
                        return;
                }
            }

            foreach (MissileSalvo gclass132 in this.list_0)
            {
                if (gclass132.auroraContactType_0 != AuroraContactType.WayPoint)
                    gclass132.bool_3 = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 287);
        }
    }
}