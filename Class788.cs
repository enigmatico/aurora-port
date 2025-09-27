// Decompiled with JetBrains decompiler
// Type: Class788
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Linq;
using System.Windows.Forms;
using Aurora;

#nullable disable
internal class Class788
{
    private GClass0 gclass0_0;

    public Class788(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    private sealed class Class789
    {
        public GameRace gclass21_0;

        internal bool method_0(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_0 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass97_0.decimal_0 < 2M;
        }

        internal bool method_1(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.Infantry && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.Damage == 1M && gclass100_0.Shots == 1 && gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_0;
        }

        internal bool method_2(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_0 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_3(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_1 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_4(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_1 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_5(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_2 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_6(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.HeavyVehicle && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_0 && gclass100_0.AAWeaponClass == AntiAirWeaponClass.const_0;
        }

        internal bool method_7(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_0 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_8(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.Infantry && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.LogisticsPoint > 0;
        }

        internal bool method_9(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_6 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_10(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.LightVehicle && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.LogisticsPoint > 0;
        }

        internal bool method_11(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_1 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_12(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_1 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_13(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_1 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_14(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_1 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_15(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_0 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass97_0.decimal_0 < 2M;
        }

        internal bool method_16(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.Infantry && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.AAWeaponClass == AntiAirWeaponClass.const_1;
        }

        internal bool method_17(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_0 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass97_0.decimal_0 < 2M;
        }

        internal bool method_18(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.Infantry && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_0;
        }

        internal bool method_19(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_0 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_20(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.Infantry && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.Damage == 1M && gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_0 &&
                   gclass100_0.Penetration < 2M;
        }

        internal bool method_21(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_0 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_22(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.Infantry && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.Damage == 1M && gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_0;
        }

        internal bool method_23(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_0 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass97_0.decimal_0 < 2M;
        }

        internal bool method_24(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.HQMaxSize > 0;
        }

        internal bool method_25(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_1 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_26(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.MediumVehicle && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_0 && gclass100_0.AAWeaponClass == AntiAirWeaponClass.const_0;
        }

        internal bool method_27(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.MediumVehicle && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_0 && gclass100_0.AAWeaponClass == AntiAirWeaponClass.const_0;
        }

        internal bool method_28(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_1 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_29(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.HeavyVehicle && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_0 && gclass100_0.AAWeaponClass == AntiAirWeaponClass.const_0;
        }

        internal bool method_30(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.HeavyVehicle && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_0 && gclass100_0.AAWeaponClass == AntiAirWeaponClass.const_0;
        }

        internal bool method_31(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_1 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_32(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.MediumVehicle && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.AAWeaponClass > AntiAirWeaponClass.const_1;
        }

        internal bool method_33(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_1 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_34(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.MediumVehicle && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_0 && gclass100_0.AAWeaponClass == AntiAirWeaponClass.const_0;
        }

        internal bool method_35(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_1 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_36(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.HQMaxSize > 0;
        }

        internal bool method_37(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.MediumVehicle && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_0 && gclass100_0.AAWeaponClass == AntiAirWeaponClass.const_0;
        }

        internal bool method_38(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_2 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_39(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.HQMaxSize > 0;
        }

        internal bool method_40(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.HeavyVehicle && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_0 && gclass100_0.AAWeaponClass == AntiAirWeaponClass.const_0;
        }

        internal bool method_41(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_3 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_42(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.HQMaxSize > 0;
        }

        internal bool method_43(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.SuperHeavyVehicle && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_0 && gclass100_0.AAWeaponClass == AntiAirWeaponClass.const_0;
        }

        internal bool method_44(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.SuperHeavyVehicle && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_0 && gclass100_0.AAWeaponClass == AntiAirWeaponClass.const_0;
        }

        internal bool method_45(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_5 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_46(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.Static && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.BombardmentWeaponClass != 0;
        }

        internal bool method_47(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_1 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_48(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.MediumVehicle && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.BombardmentWeaponClass != 0;
        }

        internal bool method_49(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_0 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_50(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.HQMaxSize > 0;
        }

        internal bool method_51(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_1 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_52(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.HQMaxSize > 0;
        }

        internal bool method_53(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.MediumVehicle && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_0 && gclass100_0.AAWeaponClass == AntiAirWeaponClass.const_0;
        }

        internal bool method_54(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_1 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_55(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.HQMaxSize > 0;
        }

        internal bool method_56(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.MediumVehicle && gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_0 && gclass100_0.AAWeaponClass == AntiAirWeaponClass.const_0;
        }

        internal bool method_57(ShipComponent gclass230_0)
        {
            return gclass230_0.bool_4 && gclass230_0.int_3 == 0 && gclass230_0.decimal_0 > 0M &&
                   gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_58(ShipComponent gclass230_0)
        {
            return !gclass230_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0;
        }

        internal bool method_59(ShipComponent gclass230_0)
        {
            if (gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.Laser &&
                this.gclass21_0.DesignDoctrine.PrimaryBeamPreference == BeamWeaponPreference.const_1 ||
                gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.Railgun &&
                this.gclass21_0.DesignDoctrine.PrimaryBeamPreference == BeamWeaponPreference.const_3 ||
                gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.ParticleBeam &&
                this.gclass21_0.DesignDoctrine.PrimaryBeamPreference == BeamWeaponPreference.const_2 ||
                gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.MesonCannon &&
                this.gclass21_0.DesignDoctrine.PrimaryBeamPreference == BeamWeaponPreference.const_4)
                return true;
            return gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.Carronade &&
                   this.gclass21_0.DesignDoctrine.PrimaryBeamPreference == BeamWeaponPreference.const_5;
        }

        internal bool method_60(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_5 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_61(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_5 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_62(GroundComponentTypeDefinition gclass100_0)
        {
            return gclass100_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.HQMaxSize > 0;
        }

        internal bool method_63(ShipComponent gclass230_0)
        {
            return gclass230_0.bool_4 && gclass230_0.gclass231_0.ComponentTypeID != AuroraComponentType.CIWS &&
                   gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_64(ShipComponent gclass230_0)
        {
            return !gclass230_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0;
        }

        internal bool method_65(ShipComponent gclass230_0)
        {
            if (gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.Laser &&
                this.gclass21_0.DesignDoctrine.PointDefencePreference == BeamWeaponPreference.const_1 ||
                gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.Railgun &&
                this.gclass21_0.DesignDoctrine.PointDefencePreference == BeamWeaponPreference.const_3 ||
                gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.MesonCannon &&
                this.gclass21_0.DesignDoctrine.PointDefencePreference == BeamWeaponPreference.const_4)
                return true;
            return gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.GaussCannon &&
                   this.gclass21_0.DesignDoctrine.PointDefencePreference == BeamWeaponPreference.const_6;
        }

        internal bool method_66(ArmourTypeData gclass97_0)
        {
            return gclass97_0.genum112_0 == GroundUnitBaseType.const_5 &&
                   gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
        }
    }

    private sealed class Class790
    {
        public GameRace gclass21_0;
        public AutomatedGroundTemplateElement gclass24_0;

        internal bool method_0(GroundUnitClass101 gclass101_0)
        {
            return gclass101_0.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID) &&
                   gclass101_0.genum115_0 == this.gclass24_0.GroundUnitClass;
        }

        internal bool method_1(GroundUnitClass101 gclass101_0)
        {
            return !gclass101_0.TechData.dictionary_0[this.gclass21_0.RaceID].bool_0;
        }
    }

    public GroundUnitClass101 method_0(
        GameRace gclass21_0,
        GroundUnitClassType genum115_0,
        string string_0,
        int int_0,
        GClass194 gclass194_0,
        bool bool_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Class788.Class789 class789 = new Class788.Class789();
        // ISSUE: reference to a compiler-generated field
        class789.gclass21_0 = gclass21_0;
        try
        {
            GroundUnitClass101 gclass101 = null;
            Decimal int_136 = Math.Ceiling(int_0 * 1.05M / 1000M) * 1000M;
            if (genum115_0 == GroundUnitClassType.BaseInfantry)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_1 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_0)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0_1 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_1)
                    .OrderByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Penetration)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_0], gclass97_0_1, gclass100_0_1, null, null, null, null,
                    gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Unchecked, 0);
            }

            if (genum115_0 == GroundUnitClassType.SwarmWarrior)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_2 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_2)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                GroundComponentTypeDefinition gclass100_0_2 =
                    this.gclass0_0.GroundUnitComponentDataDictionary.Values.FirstOrDefault<GroundComponentTypeDefinition>(gclass100_0 =>
                        gclass100_0.GroundUnitComponentType == GroundUnitComponent.const_16);
                string_0 = "Swarm Warrior";
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_0], gclass97_0_2, gclass100_0_2, null, null, null, null,
                    gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Unchecked, 0);
            }

            if (genum115_0 == GroundUnitClassType.SwarmRavener)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_3 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_3)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                GroundComponentTypeDefinition gclass100 =
                    this.gclass0_0.GroundUnitComponentDataDictionary.Values.FirstOrDefault<GroundComponentTypeDefinition>(gclass100_0 =>
                        gclass100_0.GroundUnitComponentType == GroundUnitComponent.const_1);
                string_0 = "Swarm Ravener";
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_1], gclass97_0_3, gclass100, gclass100, null, null,
                    null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Unchecked, 0);
            }

            if (genum115_0 == GroundUnitClassType.SwarmBiovore)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_4 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_4)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                GroundComponentTypeDefinition gclass100 =
                    this.gclass0_0.GroundUnitComponentDataDictionary.Values.FirstOrDefault<GroundComponentTypeDefinition>(gclass100_0 =>
                        gclass100_0.GroundUnitComponentType == GroundUnitComponent.const_11);
                string_0 = "Swarm Biovore";
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_1], gclass97_0_4, gclass100, gclass100, null, null,
                    null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Unchecked, 0);
            }

            if (genum115_0 == GroundUnitClassType.SwarmReaper)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_5 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_5)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_6)
                    .OrderByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Penetration)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Damage)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                string_0 = "Swarm Reaper";
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_1], gclass97_0_5, gclass100, gclass100, null, null,
                    null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Unchecked, 0);
            }

            if (genum115_0 == GroundUnitClassType.PrecursorCommander)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_6 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_7)
                    .OrderBy<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0).FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0_3 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_8)
                    .OrderByDescending<GroundComponentTypeDefinition, int>(gclass100_0 => gclass100_0.LogisticsPoint).FirstOrDefault<GroundComponentTypeDefinition>();
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_0], gclass97_0_6, gclass100_0_3, null, null, null, null,
                    gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Checked, 0);
            }

            if (genum115_0 == GroundUnitClassType.ResupplyInfantry)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_7 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_9)
                    .OrderBy<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0).FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0_4 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_10)
                    .OrderByDescending<GroundComponentTypeDefinition, int>(gclass100_0 => gclass100_0.LogisticsPoint).FirstOrDefault<GroundComponentTypeDefinition>();
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_6], gclass97_0_7, gclass100_0_4, null, null, null, null,
                    gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Checked, 0);
            }

            if (genum115_0 == GroundUnitClassType.Geosurvey)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_8 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_11)
                    .OrderBy<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0).FirstOrDefault<ArmourTypeData>();
                GroundComponentTypeDefinition gclass100 =
                    this.gclass0_0.GroundUnitComponentDataDictionary.Values.FirstOrDefault<GroundComponentTypeDefinition>(gclass100_0 =>
                        gclass100_0.GeoSurvey > 0M);
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_1], gclass97_0_8, gclass100, gclass100, null, null,
                    null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Checked, 0);
            }

            if (genum115_0 == GroundUnitClassType.Xenoarchaeology)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_9 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_12)
                    .OrderBy<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0).FirstOrDefault<ArmourTypeData>();
                GroundComponentTypeDefinition gclass100 =
                    this.gclass0_0.GroundUnitComponentDataDictionary.Values.FirstOrDefault<GroundComponentTypeDefinition>(gclass100_0 =>
                        gclass100_0.Xenoarchaeology > 0M);
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_1], gclass97_0_9, gclass100, gclass100, null, null,
                    null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Checked, 0);
            }

            if (genum115_0 == GroundUnitClassType.Decontamination)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_10 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_13)
                    .OrderBy<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0).FirstOrDefault<ArmourTypeData>();
                GroundComponentTypeDefinition gclass100 =
                    this.gclass0_0.GroundUnitComponentDataDictionary.Values.FirstOrDefault<GroundComponentTypeDefinition>(gclass100_0 =>
                        gclass100_0.Decontamination > 0M);
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_1], gclass97_0_10, gclass100, gclass100, null, null,
                    null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Checked, 0);
            }

            if (genum115_0 == GroundUnitClassType.Construction)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_11 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_14)
                    .OrderBy<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0).FirstOrDefault<ArmourTypeData>();
                GroundComponentTypeDefinition gclass100 =
                    this.gclass0_0.GroundUnitComponentDataDictionary.Values.FirstOrDefault<GroundComponentTypeDefinition>(gclass100_0 =>
                        gclass100_0.Construction > 0M);
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_1], gclass97_0_11, gclass100, gclass100, null, null,
                    null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Checked, 0);
            }
            else if (genum115_0 == GroundUnitClassType.InfantryAA)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_12 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_15)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0_5 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_16)
                    .OrderByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Penetration)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Damage)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_0], gclass97_0_12, gclass100_0_5, null, null, null,
                    null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Unchecked, 0);
            }
            else if (genum115_0 == GroundUnitClassType.ATInfantry)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_13 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_17)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0_6 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_18)
                    .OrderByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Penetration)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Damage)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_0], gclass97_0_13, gclass100_0_6, null, null, null,
                    null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Unchecked, 0);
            }
            else if (genum115_0 == GroundUnitClassType.HeavyInfantry)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_14 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_19)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0_7 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_20)
                    .OrderByDescending<GroundComponentTypeDefinition, int>(gclass100_0 => gclass100_0.Shots).FirstOrDefault<GroundComponentTypeDefinition>();
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_0], gclass97_0_14, gclass100_0_7, null, null, null,
                    null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Unchecked, 0);
            }
            else if (genum115_0 == GroundUnitClassType.EliteInfantry)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_15 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_21)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0_8 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_22)
                    .OrderByDescending<GroundComponentTypeDefinition, int>(gclass100_0 => gclass100_0.Shots)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Penetration)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_0], gclass97_0_15, gclass100_0_8, null, null, null,
                    null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Unchecked, 0);
            }
            else if (genum115_0 == GroundUnitClassType.InfantryHQ)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_16 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_23)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0 =
                    this.gclass0_0.GroundUnitComponentDataDictionary.Values.FirstOrDefault<GroundComponentTypeDefinition>(class789.method_24);
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_0], gclass97_0_16, gclass100_0, null, null, null, null,
                    gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Checked, (int)int_136);
            }
            else if (genum115_0 == GroundUnitClassType.MediumTank)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_17 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_25)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0_9 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_26)
                    .OrderByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Penetration)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Damage)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_1 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_27)
                    .OrderByDescending<GroundComponentTypeDefinition, int>(gclass100_0 => gclass100_0.Shots)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Damage)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Penetration)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                string string_10 = string_0;
                if (bool_0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    string_10 =
                        $"{class789.gclass21_0.GroundTheme.method_0(class789.gclass21_0, GEnum21.const_4)} {string_0}";
                }

                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_1], gclass97_0_17, gclass100_0_9, gclass100_1, null,
                    null, null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Unchecked, 0);
            }
            else if (genum115_0 == GroundUnitClassType.PrecursorMech)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_18 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_28)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0_10 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_29)
                    .OrderByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Penetration)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Damage)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_1 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_30)
                    .OrderByDescending<GroundComponentTypeDefinition, int>(gclass100_0 => gclass100_0.Shots)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Damage)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Penetration)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                string string_10 = string_0;
                if (bool_0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    string_10 =
                        $"{class789.gclass21_0.GroundTheme.method_0(class789.gclass21_0, GEnum21.const_4)}  {string_0}";
                }

                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_1], gclass97_0_18, gclass100_0_10, gclass100_1, null,
                    null, null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Unchecked, 0);
            }
            else if (genum115_0 == GroundUnitClassType.AATank)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_19 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_31)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_32)
                    .OrderByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Penetration)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Damage)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                string string_10 = string_0;
                if (bool_0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    string_10 =
                        $"{class789.gclass21_0.GroundTheme.method_0(class789.gclass21_0, GEnum21.const_4)}  {string_0}";
                }

                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_1], gclass97_0_19, gclass100, gclass100, null, null,
                    null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Unchecked, 0);
            }
            else if (genum115_0 == GroundUnitClassType.SupportTank)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_20 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_33)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_34)
                    .OrderByDescending<GroundComponentTypeDefinition, int>(gclass100_0 => gclass100_0.Shots)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Damage)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Penetration)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                string string_10 = string_0;
                if (bool_0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    string_10 = class789.gclass21_0.GroundTheme.method_0(class789.gclass21_0, GEnum21.const_4) +
                                " Infantry Support Tank";
                }

                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_1], gclass97_0_20, gclass100, gclass100, null, null,
                    null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Unchecked, 0);
            }
            else if (genum115_0 == GroundUnitClassType.TankHQ)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_21 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_35)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0_11 =
                    this.gclass0_0.GroundUnitComponentDataDictionary.Values.FirstOrDefault<GroundComponentTypeDefinition>(class789.method_36);
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_1 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_37)
                    .OrderByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Penetration)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Damage)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                string string_10 = string_0;
                if (bool_0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    string_10 =
                        $"{class789.gclass21_0.GroundTheme.method_0(class789.gclass21_0, GEnum21.const_4)}  {string_0}";
                }

                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_1], gclass97_0_21, gclass100_0_11, gclass100_1, null,
                    null, null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Checked, (int)int_136);
            }
            else if (genum115_0 == GroundUnitClassType.PrecursorMechLeader)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_22 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_38)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0_12 =
                    this.gclass0_0.GroundUnitComponentDataDictionary.Values.FirstOrDefault<GroundComponentTypeDefinition>(class789.method_39);
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_1 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_40)
                    .OrderByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Penetration)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Damage)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                string string_10 = string_0;
                if (bool_0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    string_10 =
                        $"{class789.gclass21_0.GroundTheme.method_0(class789.gclass21_0, GEnum21.const_4)}  {string_0}";
                }

                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_2], gclass97_0_22, gclass100_0_12, gclass100_1, null,
                    null, null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Checked, (int)int_136);
            }
            else if (genum115_0 == GroundUnitClassType.ResupplyVehicle)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_23 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_41)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0_13 =
                    this.gclass0_0.GroundUnitComponentDataDictionary.Values.FirstOrDefault<GroundComponentTypeDefinition>(class789.method_42);
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_1 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_43)
                    .OrderByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Penetration)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Damage)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_2 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_44)
                    .OrderByDescending<GroundComponentTypeDefinition, int>(gclass100_0 => gclass100_0.Shots)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Damage)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Penetration)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                string string_10 = string_0;
                if (bool_0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    string_10 =
                        $"{class789.gclass21_0.GroundTheme.method_0(class789.gclass21_0, GEnum21.const_4)}  {string_0}";
                }

                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_3], gclass97_0_23, gclass100_0_13, gclass100_1,
                    gclass100_2, null, null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked,
                    CheckState.Unchecked, CheckState.Checked, (int)int_136);
            }
            else if (genum115_0 == GroundUnitClassType.StaticArtillery)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_24 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_45)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0_14 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_46)
                    .OrderByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Damage)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                string string_10 = string_0;
                if (bool_0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    string_10 =
                        $"{class789.gclass21_0.GroundTheme.method_0(class789.gclass21_0, GEnum21.const_4)}  {string_0}";
                }

                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_5], gclass97_0_24, gclass100_0_14, null, null, null,
                    null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Unchecked, 0);
            }
            else if (genum115_0 == GroundUnitClassType.MobileArtillery)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_25 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_47)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_48)
                    .OrderByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Damage)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                string string_10 = string_0;
                if (bool_0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    string_10 =
                        $"{class789.gclass21_0.GroundTheme.method_0(class789.gclass21_0, GEnum21.const_4)}  {string_0}";
                }

                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_1], gclass97_0_25, gclass100, gclass100, null, null,
                    null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Unchecked, 0);
            }
            else if (genum115_0 == GroundUnitClassType.InfantryUpperHQ)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_26 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_49)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0 =
                    this.gclass0_0.GroundUnitComponentDataDictionary.Values.FirstOrDefault<GroundComponentTypeDefinition>(class789.method_50);
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_0], gclass97_0_26, gclass100_0, null, null, null, null,
                    gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Checked, 50000);
            }
            else if (genum115_0 == GroundUnitClassType.TankUpperHQ)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_27 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_51)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0_15 =
                    this.gclass0_0.GroundUnitComponentDataDictionary.Values.FirstOrDefault<GroundComponentTypeDefinition>(class789.method_52);
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_1 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_53)
                    .OrderByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Penetration)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Damage)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_1], gclass97_0_27, gclass100_0_15, gclass100_1, null,
                    null, null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Checked, 50000);
            }
            else if (genum115_0 == GroundUnitClassType.PrecursorCommander)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_28 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_54)
                    .OrderByDescending<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0)
                    .FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0_16 =
                    this.gclass0_0.GroundUnitComponentDataDictionary.Values.FirstOrDefault<GroundComponentTypeDefinition>(class789.method_55);
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_1 = this.gclass0_0.GroundUnitComponentDataDictionary.Values.Where<GroundComponentTypeDefinition>(class789.method_56)
                    .OrderByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Penetration)
                    .ThenByDescending<GroundComponentTypeDefinition, Decimal>(gclass100_0 => gclass100_0.Damage)
                    .FirstOrDefault<GroundComponentTypeDefinition>();
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_1], gclass97_0_28, gclass100_0_16, gclass100_1, null,
                    null, null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Checked, 250000);
            }
            else if (genum115_0 == GroundUnitClassType.STOAntiShip)
            {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                ShipComponent gclass230_2 = this.gclass0_0.ComponentDataDictionary.Values
                    .Where<ShipComponent>(class789.method_57).Where<ShipComponent>(class789.method_58)
                    .Where<ShipComponent>(class789.method_59)
                    .OrderByDescending<ShipComponent, Decimal>(gclass230_0 => gclass230_0.decimal_0)
                    .FirstOrDefault<ShipComponent>();
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_29 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_60)
                    .OrderBy<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0).FirstOrDefault<ArmourTypeData>();
                string string_10 = string_0;
                if (bool_0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    string_10 =
                        $"{class789.gclass21_0.GroundTheme.method_0(class789.gclass21_0, GEnum21.const_4)}  {string_0}";
                }

                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_5], gclass97_0_29,
                    this.gclass0_0.GroundUnitComponentDataDictionary[GroundUnitComponent.const_22], null, null, null, gclass230_2,
                    gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Unchecked, 0);
            }
            else if (genum115_0 == GroundUnitClassType.PlanetDefenceHQ)
            {
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_30 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_61)
                    .OrderBy<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0).FirstOrDefault<ArmourTypeData>();
                // ISSUE: reference to a compiler-generated method
                GroundComponentTypeDefinition gclass100_0 =
                    this.gclass0_0.GroundUnitComponentDataDictionary.Values.FirstOrDefault<GroundComponentTypeDefinition>(class789.method_62);
                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_5], gclass97_0_30, gclass100_0, null, null, null, null,
                    gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked,
                    CheckState.Checked, (int)int_136);
            }
            else if (genum115_0 == GroundUnitClassType.STOPointDefence)
            {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                ShipComponent gclass230_2 = this.gclass0_0.ComponentDataDictionary.Values
                    .Where<ShipComponent>(class789.method_63).Where<ShipComponent>(class789.method_64)
                    .Where<ShipComponent>(class789.method_65).OrderBy<ShipComponent, int>(gclass230_0 => gclass230_0.int_11)
                    .ThenByDescending<ShipComponent, Decimal>(gclass230_0 => gclass230_0.decimal_1)
                    .FirstOrDefault<ShipComponent>();
                // ISSUE: reference to a compiler-generated method
                ArmourTypeData gclass97_0_31 = this.gclass0_0.ArmourTypeDictionary.Values.Where<ArmourTypeData>(class789.method_66)
                    .OrderBy<ArmourTypeData, Decimal>(gclass97_0 => gclass97_0.decimal_0).FirstOrDefault<ArmourTypeData>();
                string string_10 = string_0;
                if (bool_0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    string_10 =
                        $"{class789.gclass21_0.GroundTheme.method_0(class789.gclass21_0, GEnum21.const_4)} {string_0}";
                }

                // ISSUE: reference to a compiler-generated field
                gclass101 = this.gclass0_0.method_448(class789.gclass21_0,
                    this.gclass0_0.GroundUnitBaseTypeDictionary[GroundUnitBaseType.const_5], gclass97_0_31,
                    this.gclass0_0.GroundUnitComponentDataDictionary[GroundUnitComponent.const_22], null, null, null, gclass230_2,
                    gclass194_0.dictionary_1, string_10, true, CheckState.Checked, CheckState.Unchecked,
                    CheckState.Unchecked, 0);
            }

            gclass101.genum115_0 = genum115_0;
            return gclass101;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 222);
            return null;
        }
    }

    public GroundUnitClass101 method_1(
        GameRace gclass21_0,
        AutomatedGroundTemplateElement gclass24_0,
        int int_0,
        GClass194 gclass194_0,
        bool bool_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Class788.Class790 class790 = new Class788.Class790();
        // ISSUE: reference to a compiler-generated field
        class790.gclass21_0 = gclass21_0;
        // ISSUE: reference to a compiler-generated field
        class790.gclass24_0 = gclass24_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            return this.gclass0_0.GroundUnitClassDictionary.Values.Where<GroundUnitClass101>(class790.method_0)
                .Where<GroundUnitClass101>(class790.method_1)
                .OrderByDescending<GroundUnitClass101, Decimal>(gclass101_0 => gclass101_0.decimal_3)
                .FirstOrDefault<GroundUnitClass101>() ?? this.method_0(class790.gclass21_0, class790.gclass24_0.GroundUnitClass,
                class790.gclass24_0.string_0, int_0, gclass194_0, bool_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 223);
            return null;
        }
    }

    public GroundUnitFormationTemplateData method_2(
        GameRace gclass21_0,
        AutomatedGroundTemplateDesignType genum116_0,
        GClass194 gclass194_0,
        bool bool_0)
    {
        try
        {
            if (!this.gclass0_0.AutoGroundTemplateDesignsDictionary.ContainsKey(genum116_0))
                return null;
            Decimal num1 = 0M;
            if (gclass21_0.SpecialNPRID == SpecialNPRIDs.const_0)
                this.method_3(gclass194_0);
            if (gclass21_0.SpecialNPRID == SpecialNPRIDs.Rakhas)
            {
                this.method_3(gclass194_0);
                TechSystem gclass164 = gclass21_0.method_387(TechType.GeneticEnhancements);
                if (gclass164 != null)
                {
                    if (gclass164.TechSystemID == 67771)
                        gclass194_0.dictionary_1.Add(GroundUnitCapability.const_10,
                            this.gclass0_0.GroundUnitCapabilityDictionary[GroundUnitCapability.const_10]);
                    else if (gclass164.TechSystemID == 67772)
                        gclass194_0.dictionary_1.Add(GroundUnitCapability.const_11,
                            this.gclass0_0.GroundUnitCapabilityDictionary[GroundUnitCapability.const_11]);
                    else if (gclass164.TechSystemID == 67773)
                        gclass194_0.dictionary_1.Add(GroundUnitCapability.const_12,
                            this.gclass0_0.GroundUnitCapabilityDictionary[GroundUnitCapability.const_12]);
                }
            }

            AutomatedGroundTemplateDesign gclass23 = this.gclass0_0.AutoGroundTemplateDesignsDictionary[genum116_0];
            GroundUnitFormationTemplateData gclass102 = new GroundUnitFormationTemplateData(this.gclass0_0);
            gclass102.TemplateID = this.gclass0_0.method_26(GEnum0.const_33);
            gclass102.Name = gclass23.Name;
            gclass102.Abbreviation = gclass23.Abbreviation;
            gclass102.RaceData = gclass21_0;
            gclass102.AutomatedTemplateType = genum116_0;
            AutomatedGroundTemplateElement gclass24_0_1 = gclass23.list_0.FirstOrDefault<AutomatedGroundTemplateElement>(gclass24_0 => gclass24_0.PrimaryClass);
            if (gclass24_0_1 == null)
                return null;
            GroundUnitClass101 gclass101_0_1 = this.method_1(gclass21_0, gclass24_0_1, 0, gclass194_0, bool_0);
            int int_3_1 = gclass24_0_1.BaseAmount +
                          AuroraUtils.smethod_22(gclass24_0_1.DiceSize, gclass24_0_1.DiceAmount) * gclass24_0_1.Multiple;
            gclass102.method_12(gclass101_0_1, int_3_1);
            Decimal num2 = num1 + gclass101_0_1.decimal_4 * int_3_1;
            foreach (AutomatedGroundTemplateElement gclass24_0_2 in gclass23.list_0.Where<AutomatedGroundTemplateElement>(gclass24_0 =>
                             !gclass24_0.PrimaryClass && !gclass24_0.HQ && !gclass24_0.Logistics && !gclass24_0.Construction)
                         .ToList<AutomatedGroundTemplateElement>())
            {
                GroundUnitClass101 gclass101_0_2 = this.method_1(gclass21_0, gclass24_0_2, 0, gclass194_0, bool_0);
                int int_3_2 =
                    (int)((gclass24_0_2.BaseAmount + AuroraUtils.smethod_22(gclass24_0_2.DiceSize, gclass24_0_2.DiceAmount) *
                        gclass24_0_2.Multiple) / 1000.0 * int_3_1);
                gclass102.method_12(gclass101_0_2, int_3_2);
                num2 += gclass101_0_2.decimal_4 * int_3_2;
            }

            AutomatedGroundTemplateElement gclass24_0_3 = gclass23.list_0.FirstOrDefault<AutomatedGroundTemplateElement>(gclass24_0 => gclass24_0.Construction);
            if (gclass24_0_3 != null)
            {
                GroundUnitClass101 gclass101_0_3 = this.method_1(gclass21_0, gclass24_0_3, 0, gclass194_0, bool_0);
                int int_3_3 = gclass24_0_3.BaseAmount;
                if (int_3_3 == 0)
                {
                    int_3_3 = (int)(AuroraUtils.smethod_22(gclass24_0_3.DiceSize, gclass24_0_3.DiceAmount) *
                        gclass24_0_3.Multiple / 10000.0 * int_3_1);
                    if (int_3_3 < 1)
                        int_3_3 = 1;
                }

                gclass102.method_12(gclass101_0_3, int_3_3);
            }

            AutomatedGroundTemplateElement gclass24_0_4 = gclass23.list_0.FirstOrDefault<AutomatedGroundTemplateElement>(gclass24_0 => gclass24_0.Logistics);
            if (gclass24_0_4 != null)
            {
                GroundUnitClass101 gclass101_0_4 = this.method_1(gclass21_0, gclass24_0_4, 0, gclass194_0, bool_0);
                int int_3_4 = gclass24_0_4.BaseAmount;
                if (int_3_4 == 0)
                    int_3_4 = (int)Math.Ceiling(num2 * gclass24_0_4.Multiple / gclass101_0_4.method_1());
                gclass102.method_12(gclass101_0_4, int_3_4);
            }

            AutomatedGroundTemplateElement gclass24_0_5 = gclass23.list_0.FirstOrDefault<AutomatedGroundTemplateElement>(gclass24_0 => gclass24_0.HQ);
            if (gclass24_0_5 != null)
            {
                int int_0 = (int)Math.Ceiling(gclass102.method_9());
                GroundUnitClass101 gclass101_0_5 = this.method_1(gclass21_0, gclass24_0_5, int_0, gclass194_0, bool_0);
                gclass102.method_12(gclass101_0_5, gclass24_0_5.BaseAmount);
                Decimal num3 = num2 + gclass101_0_5.decimal_4 * gclass24_0_5.BaseAmount;
            }

            this.gclass0_0.FormationTemplateRecordDic.Add(gclass102.TemplateID, gclass102);
            return gclass102;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 224 /*0xE0*/);
            return null;
        }
    }

    public void method_3(GClass194 gclass194_0)
    {
        try
        {
            gclass194_0.dictionary_1.Clear();
            if (gclass194_0.gclass1_0 == null || gclass194_0.gclass1_0.DominantTerrain == null)
                return;
            if (gclass194_0.gclass1_0.DominantTerrain.DominantTerrainType == PlanetDominantTerrain.const_9)
                gclass194_0.dictionary_1.Add(GroundUnitCapability.const_7, this.gclass0_0.GroundUnitCapabilityDictionary[GroundUnitCapability.const_7]);
            if (gclass194_0.gclass1_0.DominantTerrain.DominantTerrainType == PlanetDominantTerrain.const_4 ||
                gclass194_0.gclass1_0.DominantTerrain.DominantTerrainType == PlanetDominantTerrain.const_8 ||
                gclass194_0.gclass1_0.DominantTerrain.DominantTerrainType == PlanetDominantTerrain.const_14)
                gclass194_0.dictionary_1.Add(GroundUnitCapability.const_6, this.gclass0_0.GroundUnitCapabilityDictionary[GroundUnitCapability.const_6]);
            if (gclass194_0.gclass1_0.DominantTerrain.DominantTerrainType == PlanetDominantTerrain.const_2 ||
                gclass194_0.gclass1_0.DominantTerrain.DominantTerrainType == PlanetDominantTerrain.const_8 ||
                gclass194_0.gclass1_0.DominantTerrain.DominantTerrainType == PlanetDominantTerrain.const_7 ||
                gclass194_0.gclass1_0.DominantTerrain.DominantTerrainType == PlanetDominantTerrain.const_19)
                gclass194_0.dictionary_1.Add(GroundUnitCapability.const_5, this.gclass0_0.GroundUnitCapabilityDictionary[GroundUnitCapability.const_5]);
            if (gclass194_0.gclass1_0.DominantTerrain.DominantTerrainType != PlanetDominantTerrain.const_12 &&
                gclass194_0.gclass1_0.DominantTerrain.DominantTerrainType != PlanetDominantTerrain.const_13 &&
                gclass194_0.gclass1_0.DominantTerrain.DominantTerrainType != PlanetDominantTerrain.const_14 &&
                gclass194_0.gclass1_0.DominantTerrain.DominantTerrainType != PlanetDominantTerrain.const_20)
                return;
            gclass194_0.dictionary_1.Add(GroundUnitCapability.const_9, this.gclass0_0.GroundUnitCapabilityDictionary[GroundUnitCapability.const_9]);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 225);
        }
    }
}