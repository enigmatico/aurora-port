using Aurora;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable disable
public partial class ShipClass
{
    [CompilerGenerated]
    [Serializable]
    private sealed class staticCompMem
    {
        internal Decimal method_0(ShipClass gclass22_0)
        {
            return gclass22_0.Size;
        }

        internal Decimal method_1(ShipClass gclass22_0)
        {
            return gclass22_0.Size;
        }

        internal bool method_2(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.FuelStorage;
        }

        internal bool method_3(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.Engine;
        }

        internal bool method_4(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.CIWS;
        }

        internal string method_5(ShipClass gclass22_0)
        {
            return gclass22_0.ClassName;
        }

        internal string method_6(ShipClass gclass22_0)
        {
            return gclass22_0.ClassName;
        }

        internal string method_7(ShipClass gclass22_0)
        {
            return gclass22_0.ClassName;
        }

        internal string method_8(ShipClass gclass22_0)
        {
            return gclass22_0.ClassName;
        }

        internal bool method_9(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.genum86_0 != 0;
        }

        internal Decimal method_10(StoredComponent gclass73_0)
        {
            return gclass73_0.Amount;
        }

        internal Decimal method_11(StoredComponent gclass73_0)
        {
            return gclass73_0.Amount;
        }

        internal ShipComponent method_12(ClassComponent gclass228_0)
        {
            return gclass228_0.Component;
        }

        internal Decimal method_13(ShipComponent gclass230_0)
        {
            return gclass230_0.Resolution;
        }

        internal ShipComponent method_14(ClassComponent gclass228_0)
        {
            return gclass228_0.Component;
        }

        internal GEnum87 method_15(ShipComponent gclass230_0)
        {
            return gclass230_0.genum87_0;
        }

        internal bool method_16(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.gclass164_0.gclass163_0.TechType == TechType.SmallRefuellingSystem;
        }

        internal Decimal method_17(ClassComponent gclass228_0)
        {
            return gclass228_0.NumComponent;
        }

        internal ShipComponent method_18(ClassComponent gclass228_0)
        {
            return gclass228_0.Component;
        }

        internal bool method_19(ShipComponent gclass230_0)
        {
            return gclass230_0.decimal_1 > 3M;
        }

        internal ShipComponent method_20(ClassComponent gclass228_0)
        {
            return gclass228_0.Component;
        }

        internal bool method_21(ShipOrdnance gclass130_0)
        {
            return gclass130_0.RaceMissile.ShipDecoy == 1;
        }

        internal bool method_22(ShipOrdnance gclass130_0)
        {
            return gclass130_0.RaceMissile.ShipDecoy == 0;
        }

        internal bool method_23(ShipOrdnance gclass130_0)
        {
            return gclass130_0.RaceMissile.ShipDecoy == 1;
        }

        internal bool method_24(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.bool_11;
        }

        internal string method_25(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Name;
        }

        internal bool method_26(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.bool_11 && gclass228_0.Component.Data.ComponentTypeID !=
                AuroraComponentType.MissileLauncher;
        }

        internal bool method_27(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.Engine;
        }

        internal bool method_28(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.RefuellingSystem;
        }

        internal bool method_29(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.gclass164_0.gclass163_0.TechType == TechType.SensorJammer;
        }

        internal bool method_30(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.gclass164_0.gclass163_0.TechType == TechType.FireControlJammer;
        }

        internal bool method_31(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.gclass164_0.gclass163_0.TechType == TechType.MissileJammer;
        }

        internal bool method_32(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID ==
                   AuroraComponentType.JumpPointStabilisation;
        }

        internal bool method_33(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.Shields;
        }

        internal bool method_34(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.HangarDeck;
        }

        internal bool method_35(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID ==
                   AuroraComponentType.CommercialHangarDeck;
        }

        internal bool method_36(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.JumpDrive;
        }

        internal bool method_37(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.bool_13;
        }

        internal Decimal method_38(ClassGroundTemplate gclass75_0)
        {
            return gclass75_0.GroundUnitTemplate.method_9() * gclass75_0.Number;
        }

        internal string method_39(ClassFighterTemplate gclass74_0)
        {
            return gclass74_0.FighterClass.ClassName;
        }

        internal string method_40(ClassGroundTemplate gclass75_0)
        {
            return gclass75_0.GroundUnitTemplate.Name;
        }

        internal string method_41(ShipOrdnance gclass130_0)
        {
            return gclass130_0.RaceMissile.Name;
        }

        internal string method_42(ShipOrdnance gclass130_0)
        {
            return gclass130_0.RaceMissile.Name;
        }

        internal int method_43(ClassComponent gclass228_0)
        {
            return gclass228_0.ChanceToHit;
        }

        internal Decimal method_44(ClassComponent gclass228_0)
        {
            return gclass228_0.NumComponent;
        }

        internal Decimal method_45(ClassComponent gclass228_0)
        {
            return gclass228_0.decimal_2;
        }

        internal Decimal method_46(ClassComponent gclass228_0)
        {
            return gclass228_0.decimal_4;
        }

        internal Decimal method_47(ClassComponent gclass228_0)
        {
            return gclass228_0.decimal_3;
        }

        internal Decimal method_48(ClassComponent gclass228_0)
        {
            return gclass228_0.decimal_5;
        }

        internal Decimal method_49(ClassComponent gclass228_0)
        {
            return gclass228_0.decimal_6;
        }

        internal Decimal method_50(ClassComponent gclass228_0)
        {
            return gclass228_0.decimal_7;
        }

        internal ClassSummaryType method_51(KeyValuePair<ClassSummaryTypeID, ClassSummaryType> keyValuePair_0)
        {
            return keyValuePair_0.Value;
        }

        internal bool method_52(ClassSummaryType gclass232_0)
        {
            return gclass232_0.bool_0;
        }

        internal Decimal method_53(ClassSummaryType gclass232_0)
        {
            return gclass232_0.decimal_1;
        }

        internal Decimal method_54(ClassSummaryType gclass232_0)
        {
            return gclass232_0.decimal_0;
        }

        internal Decimal method_55(ClassSummaryType gclass232_0)
        {
            return gclass232_0.decimal_2;
        }

        internal Decimal method_56(ClassSummaryType gclass232_0)
        {
            return gclass232_0.decimal_3;
        }

        internal int method_57(ClassComponent gclass228_0)
        {
            return gclass228_0.ChanceToHit;
        }

        internal Decimal method_58(ClassComponent gclass228_0)
        {
            return gclass228_0.decimal_6;
        }

        internal int method_59(ComponentDamage gclass178_0)
        {
            return gclass178_0.Number;
        }

        internal string method_60(ShipData gclass40_0)
        {
            return gclass40_0.ShipName;
        }

        internal ShipClass method_61(ShipData gclass40_0)
        {
            return gclass40_0.Class;
        }

        internal string method_62(ShipClass gclass22_0)
        {
            return gclass22_0.ClassName;
        }

        internal IEnumerable<FCTSquadronData70> method_63(ShipData gclass40_0)
        {
            return gclass40_0.ChildSquadronDictionary.Values;
        }

        internal string method_64(FCTSquadronData70 gclass70_0)
        {
            return gclass70_0.SquadronName;
        }

        internal string method_65(ShipData gclass40_0)
        {
            return gclass40_0.ShipName;
        }

        internal string method_66(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0.FleetName;
        }

        internal string method_67(ShipData gclass40_0)
        {
            return gclass40_0.gclass85_0.System.Name;
        }

        internal Decimal method_68(ShipData gclass40_0)
        {
            return gclass40_0.decimal_1;
        }

        internal Decimal method_69(ShipData gclass40_0)
        {
            return gclass40_0.decimal_6;
        }

        internal Decimal method_70(ShipData gclass40_0)
        {
            return gclass40_0.decimal_7;
        }

        internal Decimal method_71(ShipData gclass40_0)
        {
            return gclass40_0.decimal_14;
        }

        internal string method_72(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Name;
        }

        internal ComponentTypeData method_73(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data;
        }

        internal ClassSummaryType method_74(ComponentTypeData gclass231_0)
        {
            return gclass231_0.ClassSummaryType;
        }

        internal string method_75(ClassSummaryType gclass232_0)
        {
            return gclass232_0.string_0;
        }

        internal string method_76(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Name;
        }

        internal Decimal method_77(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.decimal_3 * gclass228_0.NumComponent;
        }

        internal Decimal method_78(ClassComponent gclass228_0)
        {
            return gclass228_0.NumComponent;
        }

        internal int method_79(KeyValuePair<int, ClassComponent> keyValuePair_0)
        {
            return keyValuePair_0.Key;
        }

        internal bool method_80(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.CrewQuarters;
        }

        internal ShipComponent method_81(ClassComponent gclass228_0)
        {
            return gclass228_0.Component;
        }

        internal bool method_82(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.ColonistTransport &&
                   gclass228_0.Component.genum87_0 == GEnum87.const_0;
        }

        internal Decimal method_83(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.decimal_3 * gclass228_0.NumComponent;
        }

        internal bool method_84(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.ColonistTransport &&
                   gclass228_0.Component.genum87_0 == GEnum87.const_7;
        }

        internal Decimal method_85(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.decimal_3 * gclass228_0.NumComponent;
        }

        internal bool method_86(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.HangarDeck ||
                   gclass228_0.Component.Data.ComponentTypeID ==
                   AuroraComponentType.CommercialHangarDeck;
        }

        internal Decimal method_87(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.decimal_3 * gclass228_0.NumComponent;
        }

        internal Decimal method_88(ShipComponent gclass230_0)
        {
            return gclass230_0.decimal_3;
        }

        internal bool method_89(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.bool_1;
        }

        internal bool method_90(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.int_0 == 65275;
        }

        internal bool method_91(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.bool_1;
        }

        internal bool method_92(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.bool_4 ||
                   gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.CIWS;
        }

        internal int method_93(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.method_5(1000);
        }

        internal string method_94(ClassGroundTemplate gclass75_0)
        {
            return gclass75_0.GroundUnitTemplate.Name;
        }

        internal bool method_95(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.ColonistTransport &&
                   gclass228_0.Component.genum87_0 == GEnum87.const_7;
        }

        internal Decimal method_96(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.decimal_3 * gclass228_0.NumComponent;
        }

        internal int method_97(ClassComponent gclass228_0)
        {
            return gclass228_0.ChanceToHit;
        }

        internal bool method_98(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.HangarDeck;
        }

        internal Decimal method_99(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.decimal_1 * gclass228_0.NumComponent;
        }

        internal bool method_100(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID ==
                   AuroraComponentType.GeologicalSurveySensors;
        }

        internal Decimal method_101(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.decimal_1 * gclass228_0.NumComponent;
        }

        internal bool method_102(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID ==
                   AuroraComponentType.GravitationalSurveySensors;
        }

        internal Decimal method_103(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.decimal_1 * gclass228_0.NumComponent;
        }

        internal bool method_104(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.MissileLauncher;
        }

        internal Decimal method_105(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.decimal_1 * gclass228_0.NumComponent;
        }

        internal bool method_106(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.bool_4;
        }

        internal Decimal method_107(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.decimal_1 * gclass228_0.NumComponent;
        }

        internal bool method_108(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.FighterPodBay;
        }

        internal Decimal method_109(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.decimal_1 * gclass228_0.NumComponent;
        }
    }

    [CompilerGenerated]
    private sealed class Class767
    {
        public ClassComponent gclass228_0;

        internal bool method_0(StoredComponent gclass73_0)
        {
            return gclass73_0.Component == this.gclass228_0.Component;
        }
    }

    [CompilerGenerated]
    private sealed class Class768
    {
        public ClassComponent gclass228_0;

        internal bool method_0(ClassComponent gclass228_1)
        {
            return gclass228_1.ComponentID == this.gclass228_0.ComponentID;
        }

        internal bool method_1(StoredComponent gclass73_0)
        {
            return gclass73_0.Component == this.gclass228_0.Component;
        }
    }

    [CompilerGenerated]
    private sealed class Class769
    {
        public ClassComponent gclass228_0;

        internal bool method_0(ClassComponent gclass228_1)
        {
            return gclass228_1.ComponentID == this.gclass228_0.ComponentID;
        }
    }

    [CompilerGenerated]
    private sealed class Class770
    {
        public ShipOrdnance gclass130_0;

        internal bool method_0(ShipOrdnance gclass130_1)
        {
            return gclass130_1.RaceMissile == this.gclass130_0.RaceMissile;
        }
    }

    [CompilerGenerated]
    private sealed class Class771
    {
        public ShipComponent gclass230_0;

        internal bool method_0(ClassComponent gclass228_0)
        {
            return gclass228_0.Component == this.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class772
    {
        public ShipComponent gclass230_0;

        internal bool method_0(ClassComponent gclass228_0)
        {
            return gclass228_0.Component == this.gclass230_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class773
    {
        public RaceMissile gclass129_0;

        internal bool method_0(ShipOrdnance gclass130_0)
        {
            return gclass130_0.RaceMissile == this.gclass129_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class774
    {
        public ShipOrdnance gclass130_0;

        internal bool method_0(ShipOrdnance gclass130_1)
        {
            return gclass130_1 == this.gclass130_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class775
    {
        public ShipClass gclass22_0;

        internal bool method_0(ClassFighterTemplate gclass74_0)
        {
            return gclass74_0.FighterClass == this.gclass22_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class776
    {
        public GroundUnitFormationTemplateData gclass102_0;

        internal bool method_0(ClassGroundTemplate gclass75_0)
        {
            return gclass75_0.GroundUnitTemplate == this.gclass102_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class777
    {
        public ClassFighterTemplate gclass74_0;

        internal bool method_0(ClassFighterTemplate gclass74_1)
        {
            return gclass74_1 == this.gclass74_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class778
    {
        public ClassGroundTemplate gclass75_0;

        internal bool method_0(ClassGroundTemplate gclass75_1)
        {
            return gclass75_1 == this.gclass75_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class779
    {
        public ClassComponent gclass228_0;

        internal bool method_0(KeyValuePair<ClassSummaryTypeID, ClassSummaryType> keyValuePair_0)
        {
            return keyValuePair_0.Key == this.gclass228_0.Component.Data.ClassSummaryType.genum83_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class780
    {
        public ClassComponent gclass228_0;

        internal bool method_0(ComponentDamage gclass178_0)
        {
            return gclass178_0.ShipComponent == this.gclass228_0.Component;
        }
    }

    [CompilerGenerated]
    private sealed class Class781
    {
        public ClassSummaryType gclass232_0;

        internal bool method_0(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ClassSummaryType == this.gclass232_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class782
    {
        public AuroraComponentType auroraComponentType_0;

        internal bool method_0(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == this.auroraComponentType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class783
    {
        public AuroraComponentType auroraComponentType_0;

        internal bool method_0(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == this.auroraComponentType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class784
    {
        public AuroraComponentType auroraComponentType_0;

        internal bool method_0(ClassComponent gclass228_0)
        {
            return gclass228_0.Component.Data.ComponentTypeID == this.auroraComponentType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class785
    {
        public AuroraComponentType auroraComponentType_0;

        internal bool method_0(KeyValuePair<int, ClassComponent> keyValuePair_0)
        {
            return keyValuePair_0.Value.Component.Data.ComponentTypeID == this.auroraComponentType_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class786
    {
        public int int_0;

        internal bool method_0(ShipComponent gclass230_0)
        {
            return gclass230_0.Data.ComponentTypeID == AuroraComponentType.CrewQuarters &&
                   gclass230_0.decimal_2 >= this.int_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class787
    {
        public DesignDoctrine gclass20_0;

        internal bool method_0(ShipClass gclass22_0)
        {
            return gclass22_0.Race == this.gclass20_0.Race && gclass22_0.Commercial;
        }
    }
}