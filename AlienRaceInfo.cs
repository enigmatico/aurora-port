// Decompiled with JetBrains decompiler
// Type: GClass110
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;

#nullable disable
public class AlienRaceInfo
{
    private GClass0 gclass0_0;
    public Dictionary<int, GClass194> dictionary_0 = new Dictionary<int, GClass194>();
    public Dictionary<int, SystemData200> dictionary_1 = new Dictionary<int, SystemData200>();
    public Dictionary<int, GClass118> dictionary_2 = new Dictionary<int, GClass118>();
    public FCTRaceRecordC21 ActualAlienRace;
    public FCTRaceRecordC21 ViewingRace;
    public AuroraContactStatus ContactStatus;
    public AuroraCommStatus CommStatus;
    public NamingTheme ClassTheme;
    public int ActualAlienRaceID;
    public int FixedRelationShip;
    public int UseRealClassNames;
    public int RandomNameOrder = 1;
    public Decimal FirstDetected;
    public Decimal CommEstablished;
    public Decimal DiplomaticPoints;
    public Decimal CommModifier;
    public Decimal DamageCausedByAlienRace;
    public bool bTradeTreaty;
    public bool bTechTreaty;
    public bool bGeoTreaty;
    public bool bGravTreaty;
    public bool bPortraitShown;
    public bool bool_5;
    public string Abbreviation;
    public double AlienRaceIntelPoints;
    public bool bool_6 = true;

    public string AlienRaceName { get; set; }

    public AlienRaceInfo(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public AlienRaceInfo method_0(FCTRaceRecordC21 gclass21_2)
    {
        try
        {
            AlienRaceInfo gclass110_1 = new AlienRaceInfo(this.gclass0_0);
            AlienRaceInfo gclass110_2 = (AlienRaceInfo)this.MemberwiseClone();
            gclass110_2.ViewingRace = gclass21_2;
            gclass110_2.dictionary_0 = new Dictionary<int, GClass194>();
            gclass110_2.dictionary_1 = new Dictionary<int, SystemData200>();
            gclass110_2.dictionary_2 = new Dictionary<int, GClass118>();
            foreach (KeyValuePair<int, GClass194> keyValuePair in this.dictionary_0)
                gclass110_2.dictionary_0.Add(keyValuePair.Key, keyValuePair.Value);
            foreach (KeyValuePair<int, SystemData200> keyValuePair in this.dictionary_1)
                gclass110_2.dictionary_1.Add(keyValuePair.Key, keyValuePair.Value);
            foreach (GClass118 gclass118_1 in this.dictionary_2.Values)
            {
                GClass118 gclass118_2 = gclass118_1.method_2(gclass21_2);
                gclass118_2.int_0 = this.gclass0_0.method_26(GEnum0.const_43);
                gclass110_2.dictionary_2.Add(gclass118_2.int_0, gclass118_2);
            }

            return gclass110_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1893);
            return null;
        }
    }
}