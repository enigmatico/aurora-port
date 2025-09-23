
using System;
using System.Collections.Generic;
using System.Linq;
using Aurora;

public partial class GClass2
{
    
  private sealed class Class335
  {
    public GClass2 gclass2_0;
    public GClass202 gclass202_0;

    public Class335()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass202_0 == this.gclass202_0 && gclass85_0.decimal_0 < this.gclass2_0.gclass0_0.decimal_0 - GClass226.decimal_32 && gclass85_0.gclass9_0.bool_2;
    }
  }

  
  private sealed class Class336
  {
    public GEnum105 genum105_0;
    public GClass202 gclass202_0;
    public GClass2 gclass2_0;
    public List<GClass200> list_0;

    public Class336()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass9_0.genum105_0 == this.genum105_0 && gclass85_0.gclass202_0 == this.gclass202_0;
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.gclass9_0.genum105_0 == this.genum105_0 && gclass85_0.gclass202_0 != this.gclass202_0;
    }

    internal bool method_2(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass2_0.gclass21_0 && gclass146_0.gclass202_0 != this.gclass202_0;
    }

    internal bool method_3(GClass59 gclass59_0)
    {
      return this.list_0.Contains(gclass59_0.gclass200_0);
    }

    internal bool method_4(GClass233 gclass233_0)
    {
      return this.list_0.Contains(gclass233_0.gclass200_0);
    }
  }

  
  private sealed class Class337
  {
    public GClass202 gclass202_0;

    public Class337()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass9_0.int_1 == 1 && gclass85_0.gclass202_0 == this.gclass202_0;
    }
  }

  
  private sealed class Class338
  {
    public GClass2 gclass2_0;
    public GClass202 gclass202_0;
    public List<GClass200> list_0;

    public Class338()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass9_0.int_1 == 1 && gclass85_0.gclass202_0 != this.gclass202_0;
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.gclass9_0.genum105_0 == GEnum105.const_60 && gclass85_0.gclass202_0 == this.gclass202_0 && gclass85_0.decimal_0 < this.gclass2_0.gclass0_0.decimal_0 - GClass226.decimal_32;
    }

    internal bool method_2(GClass202 gclass202_1)
    {
      return this.list_0.Contains(gclass202_1.gclass200_0);
    }
  }

  
  private sealed class Class339
  {
    public GClass200 gclass200_0;
    public GClass2.Class338 class338_0;

    public Class339()
    {
      
    }

    internal bool method_0(GClass214 gclass214_0)
    {
      return gclass214_0.wayPointType_0 == WayPointType.POI && gclass214_0.gclass21_0 == this.class338_0.gclass2_0.gclass21_0 && gclass214_0.gclass200_0 == this.gclass200_0;
    }
  }

  
  private sealed class Class340
  {
    public GClass1 gclass1_0;

    public Class340()
    {
      
    }

    internal bool method_0(GClass214 gclass214_0)
    {
      return gclass214_0.gclass1_0 == this.gclass1_0;
    }
  }

  
  private sealed class Class341
  {
    public GClass213 gclass213_0;

    public Class341()
    {
      
    }

    internal bool method_0(GClass214 gclass214_0)
    {
      return gclass214_0.double_0 == this.gclass213_0.double_0 && gclass214_0.double_1 == this.gclass213_0.double_1;
    }
  }

  
  private sealed class Class342
  {
    public List<GClass202> list_0;
    public List<GClass202> list_1;

    public Class342()
    {
      
    }

    internal bool method_0(GClass202 gclass202_0)
    {
      return !this.list_0.Contains(gclass202_0);
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return this.list_1.Contains(gclass85_0.gclass202_0) && gclass85_0.gclass9_0.genum104_0 != GEnum104.const_25;
    }
  }

  
  private sealed class Class343
  {
    public GClass110 gclass110_0;
    public GClass2 gclass2_0;

    public Class343()
    {
      
    }

    internal bool method_0(GClass117 gclass117_0)
    {
      return gclass117_0.gclass110_0 == this.gclass110_0 && !gclass117_0.bool_0 && gclass117_0.int_1 > 1 && !gclass117_0.gclass115_0.gclass22_0.bool_2 && this.gclass2_0.gclass0_0.decimal_0 - gclass117_0.decimal_0 < GClass226.decimal_30;
    }

    internal bool method_1(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.gclass2_0.gclass21_0 && gclass40_0.gclass22_0.int_32 > 1 && !gclass40_0.gclass22_0.bool_2;
    }

    internal bool method_2(GClass22 gclass22_0)
    {
      return gclass22_0.gclass21_0 == this.gclass2_0.gclass21_0;
    }

    internal bool method_3(GClass115 gclass115_0)
    {
      return gclass115_0.gclass110_0 == this.gclass110_0;
    }

    internal bool method_4(GClass22 gclass22_0)
    {
      return gclass22_0.gclass21_0 == this.gclass2_0.gclass21_0;
    }
  }

  
  private sealed class Class344
  {
    public GClass110 gclass110_0;

    public Class344()
    {
      
    }

    internal bool method_0(GClass202 gclass202_0)
    {
      return gclass202_0.gclass110_0 == this.gclass110_0;
    }
  }

  
  private sealed class Class345
  {
    public GClass2 gclass2_0;
    public GClass202 gclass202_0;
    public GClass40 gclass40_0;

    public Class345()
    {
      
    }

    internal bool method_0(GClass40 gclass40_1)
    {
      return gclass40_1.gclass21_0 == this.gclass2_0.gclass21_0 && gclass40_1.gclass85_0.gclass202_0 == this.gclass202_0;
    }

    internal bool method_1(GClass146 gclass146_0)
    {
      if (gclass146_0.gclass21_0 != this.gclass2_0.gclass21_0 || gclass146_0.gclass202_0 != this.gclass202_0)
        return false;
      return gclass146_0.decimal_30 > 0.01M || gclass146_0.dictionary_0.Count > 0;
    }

    internal double method_2(GClass40 gclass40_1)
    {
      return this.gclass2_0.gclass0_0.method_28(gclass40_1.gclass85_0.double_2, gclass40_1.gclass85_0.double_3, this.gclass40_0.gclass85_0.double_2, this.gclass40_0.gclass85_0.double_3);
    }

    internal double method_3(GClass146 gclass146_0)
    {
      return this.gclass2_0.gclass0_0.method_28(gclass146_0.method_87(), gclass146_0.method_88(), this.gclass40_0.gclass85_0.double_2, this.gclass40_0.gclass85_0.double_3);
    }
  }

  
  private sealed class Class346
  {
    public double double_0;
    public double double_1;
    public GClass2.Class345 class345_0;

    public Class346()
    {
      
    }

    internal double method_0(GClass40 gclass40_0)
    {
      return this.class345_0.gclass2_0.gclass0_0.method_28(gclass40_0.gclass85_0.double_2, gclass40_0.gclass85_0.double_3, this.double_0, this.double_1);
    }

    internal double method_1(GClass146 gclass146_0)
    {
      return this.class345_0.gclass2_0.gclass0_0.method_28(gclass146_0.method_87(), gclass146_0.method_88(), this.double_0, this.double_1);
    }
  }

  
  private sealed class Class347
  {
    public GClass202 gclass202_0;

    public Class347()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.gclass200_0 == this.gclass202_0.gclass200_0;
    }
  }

  
  private sealed class Class348
  {
    public GClass202 gclass202_0;

    public Class348()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass202_0 == this.gclass202_0;
    }
  }

  
  private sealed class Class349
  {
    public GClass202 gclass202_0;
    public Func<GClass146, bool> func_0;
    public Func<GClass115, Decimal> func_1;

    public Class349()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.gclass200_0 == this.gclass202_0.gclass200_0;
    }

    internal bool method_1(GClass146 gclass146_0)
    {
      return gclass146_0.gclass202_0 == this.gclass202_0;
    }

    internal Decimal method_2(GClass115 gclass115_0)
    {
      return gclass115_0.method_2(this.gclass202_0);
    }
  }

  
  private sealed class Class350
  {
    public GClass110 gclass110_0;
    public GClass2.Class349 class349_0;

    public Class350()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      if (gclass65_0.gclass21_0 != this.gclass110_0.gclass21_0 || gclass65_0.gclass200_0 != this.class349_0.gclass202_0.gclass200_0)
        return false;
      return gclass65_0.auroraContactType_0 == AuroraContactType.Population || gclass65_0.auroraContactType_0 == AuroraContactType.Shipyard || gclass65_0.auroraContactType_0 == AuroraContactType.GroundUnit || gclass65_0.auroraContactType_0 == AuroraContactType.STOGroundUnit;
    }

    internal bool method_1(GClass65 gclass65_0)
    {
      return gclass65_0.gclass21_0 == this.gclass110_0.gclass21_0 && gclass65_0.gclass200_0 == this.class349_0.gclass202_0.gclass200_0 && gclass65_0.auroraContactType_0 == AuroraContactType.Ship;
    }

    internal bool method_2(GClass65 gclass65_0)
    {
      return gclass65_0.gclass21_0 == this.gclass110_0.gclass21_0 && gclass65_0.auroraContactType_0 == AuroraContactType.Ship && gclass65_0.gclass200_0 == this.class349_0.gclass202_0.gclass200_0;
    }

    internal bool method_3(GClass40 gclass40_0)
    {
      return gclass40_0.gclass187_0 == null || !this.gclass110_0.bool_0;
    }
  }

  
  private sealed class Class351
  {
    public List<GClass200> list_0;
    public List<GClass200> list_1;
    public List<GClass200> list_2;
    public GClass2 gclass2_0;

    public Class351()
    {
      
    }

    internal bool method_0(GClass202 gclass202_0)
    {
      return this.list_0.Contains(gclass202_0.gclass200_0);
    }

    internal bool method_1(GClass202 gclass202_0)
    {
      return this.list_1.Contains(gclass202_0.gclass200_0);
    }

    internal bool method_2(GClass202 gclass202_0)
    {
      return this.list_2.Contains(gclass202_0.gclass200_0);
    }
  }

  
  private sealed class Class352
  {
    public GClass202 gclass202_0;

    public Class352()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.gclass200_0 == this.gclass202_0.gclass200_0 && gclass65_0.auroraContactType_0 == AuroraContactType.Ship;
    }
  }

  
  private sealed class Class353
  {
    public GClass202 gclass202_0;
    public GClass2.Class351 class351_0;

    public Class353()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.gclass200_0 == this.gclass202_0.gclass200_0 && this.class351_0.gclass2_0.gclass0_0.decimal_0 - gclass65_0.decimal_3 < GClass226.decimal_34 && gclass65_0.auroraContactType_0 == AuroraContactType.Ship;
    }
  }

  
  private sealed class Class354
  {
    public List<GClass200> list_0;

    public Class354()
    {
      
    }

    internal bool method_0(GClass202 gclass202_0)
    {
      return this.list_0.Contains(gclass202_0.gclass200_0);
    }
  }

  
  private sealed class Class355
  {
    public List<GClass200> list_0;

    public Class355()
    {
      
    }

    internal bool method_0(GClass113 gclass113_0)
    {
      return this.list_0.Contains(gclass113_0.gclass146_0.gclass202_0.gclass200_0);
    }
  }

  
  private sealed class Class356
  {
    public GClass85 gclass85_0;
    public GClass2.Class351 class351_0;

    public Class356()
    {
      
    }

    internal bool method_0(GClass85 gclass85_1)
    {
      return gclass85_1.gclass85_0 == this.gclass85_0;
    }

    internal double method_1(GClass85 gclass85_1)
    {
      return this.class351_0.gclass2_0.gclass0_0.method_28(this.gclass85_0.double_2, this.gclass85_0.double_3, gclass85_1.double_2, gclass85_1.double_3);
    }
  }

  
  private sealed class Class357
  {
    public GClass202 gclass202_0;

    public Class357()
    {
      
    }

    internal bool method_0(GClass202 gclass202_1)
    {
      return gclass202_1 != this.gclass202_0;
    }
  }

  
  private sealed class Class358
  {
    public GClass2 gclass2_0;
    public GClass200 gclass200_0;
    public GClass221 gclass221_0;

    public Class358()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass2_0.gclass21_0 && gclass85_0.gclass202_0.gclass200_0 == this.gclass200_0 && gclass85_0.double_2 == this.gclass221_0.double_0 && gclass85_0.double_3 == this.gclass221_0.double_1;
    }

    internal bool method_1(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass2_0.gclass21_0 && gclass146_0.gclass202_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_2(GClass146 gclass146_0)
    {
      return gclass146_0.method_87() == this.gclass221_0.double_0 && gclass146_0.method_88() == this.gclass221_0.double_1;
    }

    internal bool method_3(GClass103 gclass103_0)
    {
      return gclass103_0.gclass21_0 == this.gclass2_0.gclass21_0 && gclass103_0.gclass146_0 != null;
    }
  }

  
  private sealed class Class359
  {
    public List<GClass146> list_0;

    public Class359()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return this.list_0.Contains(gclass103_0.gclass146_0);
    }
  }

  
  private sealed class Class360
  {
    public GClass36 gclass36_0;

    public Class360()
    {
      
    }

    internal bool method_0(GClass31 gclass31_0)
    {
      return gclass31_0.gclass230_1 == this.gclass36_0.gclass230_0 && gclass31_0.int_1 == this.gclass36_0.int_0;
    }
  }

  
  private sealed class Class361
  {
    public GClass202 gclass202_0;
    public GClass2 gclass2_0;

    public Class361()
    {
      
    }

    internal bool method_0(GClass65 gclass65_0)
    {
      return gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.gclass21_1 == this.gclass202_0.gclass21_0 && this.gclass2_0.gclass0_0.decimal_0 - gclass65_0.decimal_3 < GClass226.decimal_34 && gclass65_0.auroraContactType_0 == AuroraContactType.Ship;
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.gclass202_0 == this.gclass202_0;
    }
  }

  
  private sealed class Class362
  {
    public GClass85 gclass85_0;

    public Class362()
    {
      
    }

    internal bool method_0(GClass85 gclass85_1)
    {
      return gclass85_1 != this.gclass85_0 && gclass85_1.double_2 == this.gclass85_0.double_2 && gclass85_1.double_3 == this.gclass85_0.double_3 && this.gclass85_0.method_24(gclass85_1);
    }
  }

  
  private sealed class Class363
  {
    public List<GClass200> list_0;

    public Class363()
    {
      
    }

    internal bool method_0(GClass202 gclass202_0)
    {
      return this.list_0.Contains(gclass202_0.gclass200_0);
    }
  }

  
  private sealed class Class364
  {
    public GClass146 gclass146_0;

    public Class364()
    {
      
    }

    internal bool method_0(GClass146 gclass146_1)
    {
      return gclass146_1 != this.gclass146_0;
    }
  }

  
  private sealed class Class365
  {
    public GClass40 gclass40_0;
    public GClass2 gclass2_0;

    public Class365()
    {
      
    }

    internal bool method_0(GClass40 gclass40_1)
    {
      return gclass40_1.gclass85_0.gclass202_0 == this.gclass40_0.gclass85_0.gclass202_0;
    }

    internal double method_1(GClass40 gclass40_1)
    {
      return this.gclass2_0.gclass0_0.method_28(gclass40_1.gclass85_0.double_2, gclass40_1.gclass85_0.double_3, this.gclass40_0.gclass85_0.double_2, this.gclass40_0.gclass85_0.double_3);
    }
  }

  
  private sealed class Class366
  {
    public GClass2 gclass2_0;
    public GEnum120 genum120_0;

    public Class366()
    {
      
    }

    internal bool method_0(GClass22 gclass22_0)
    {
      return gclass22_0.gclass21_0 == this.gclass2_0.gclass21_0 && gclass22_0.gclass14_0.genum120_0 == this.genum120_0;
    }
  }

  
  private sealed class Class367
  {
    public GClass202 gclass202_0;
    public GEnum120 genum120_0;

    public Class367()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      return gclass40_0.gclass85_0.gclass202_0 == this.gclass202_0 && gclass40_0.gclass22_0.gclass14_0.genum120_0 == this.genum120_0;
    }
  }

  
  private sealed class Class368
  {
    public GClass164 gclass164_0;

    public Class368()
    {
      
    }

    internal bool method_0(GClass168 gclass168_0)
    {
      return gclass168_0.gclass164_0 == this.gclass164_0;
    }
  }

  
  private sealed class Class369
  {
    public GClass146 gclass146_0;

    public Class369()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0 == this.gclass146_0;
    }

    internal bool method_1(GClass139 gclass139_0)
    {
      return gclass139_0.gclass146_0 == this.gclass146_0;
    }
  }

  
  private sealed class Class370
  {
    public GClass146 gclass146_0;

    public Class370()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0 == this.gclass146_0;
    }

    internal bool method_1(GClass139 gclass139_0)
    {
      return gclass139_0.gclass146_0 == this.gclass146_0;
    }
  }

  
  private sealed class Class371
  {
    public GClass2 gclass2_0;
    public List<GClass200> list_0;

    public Class371()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass2_0.gclass21_0;
    }

    internal bool method_1(GClass215 gclass215_0)
    {
      return gclass215_0.gclass21_0 == this.gclass2_0.gclass21_0;
    }

    internal bool method_2(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass2_0.gclass21_0 && gclass146_0.decimal_30 > 0M;
    }

    internal bool method_3(GClass1 gclass1_0)
    {
      return this.list_0.Contains(gclass1_0.gclass200_0);
    }
  }

  
  private sealed class Class372
  {
    public GClass194 gclass194_0;
    public GClass200 gclass200_0;
    public GClass2.Class371 class371_0;

    public Class372()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.double_7 >= this.gclass194_0.double_7 && gclass1_0.double_7 <= this.gclass194_0.double_8;
    }

    internal int method_1(GClass1 gclass1_0)
    {
      return this.class371_0.gclass2_0.gclass0_0.method_35(this.gclass200_0, gclass1_0.gclass200_0, this.class371_0.gclass2_0.gclass21_0);
    }
  }

  
  private sealed class Class373
  {
    public GClass1 gclass1_0;
    public GClass2 gclass2_0;
    public GClass194 gclass194_0;

    public Class373()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass1_0 == this.gclass1_0 && gclass146_0.gclass21_0 == this.gclass2_0.gclass21_0 && gclass146_0.gclass194_0 == this.gclass194_0;
    }
  }

  
  private sealed class Class374
  {
    public List<GClass139> list_0;
    public List<GClass103> list_1;
    public GClass2 gclass2_0;

    public Class374()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0 != null &&
             this.list_0.Select<GClass139, int>(gClass139 => gClass139.int_7).Contains<int>(gclass103_0.int_0);
    }
  }

  
  private sealed class Class375
  {
    public GClass113 gclass113_0;

    public Class375()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass1_0 == this.gclass113_0.gclass146_0.gclass1_0;
    }

    internal bool method_1(GClass65 gclass65_0)
    {
      return gclass65_0.gclass146_0 == this.gclass113_0.gclass146_0;
    }
  }

  
  private sealed class Class376
  {
    public GClass146 gclass146_0;
    public GClass2.Class374 class374_0;

    public Class376()
    {
      
    }

    internal bool method_0(GClass16 gclass16_0)
    {
      return gclass16_0.genum97_0 == this.gclass146_0.gclass6_0.genum97_0;
    }

    internal bool method_1(GClass139 gclass139_0)
    {
      return gclass139_0.gclass146_0 == this.gclass146_0;
    }

    internal bool method_2(GClass85 gclass85_0)
    {
      return gclass85_0.method_257() == this.gclass146_0;
    }
  }

  
  private sealed class Class377
  {
    public List<GClass85> list_0;
    public GClass2.Class376 class376_0;

    public Class377()
    {
      
    }
  }

  
  private sealed class Class378
  {
    public GEnum116 genum116_0;
    public GClass2.Class377 class377_0;

    public Class378()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass102_0.genum116_0 == this.genum116_0;
    }

    internal bool method_1(GClass103 gclass103_0)
    {
      return this.class377_0.list_0.Contains(gclass103_0.gclass40_0.gclass85_0) && gclass103_0.gclass102_0.genum116_0 == this.genum116_0;
    }

    internal IEnumerable<GClass103> method_2(GClass139 gclass139_0)
    {
      GClass2.Class379 class379 = new GClass2.Class379();
      class379.class378_0 = this;
      class379.gclass139_0 = gclass139_0;
      return this.class377_0.class376_0.class374_0.list_1.Where<GClass103>(class379.method_0);
    }

    internal bool method_3(GClass16 gclass16_0)
    {
      return gclass16_0.genum116_0 == this.genum116_0;
    }
  }

  
  private sealed class Class379
  {
    public GClass139 gclass139_0;
    public GClass2.Class378 class378_0;

    public Class379()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.int_0 == this.gclass139_0.int_7 && gclass103_0.gclass102_0.genum116_0 == this.class378_0.genum116_0;
    }
  }

  
  private sealed class Class380
  {
    public GClass146 gclass146_0;
    public GClass2.Class374 class374_0;

    public Class380()
    {
      
    }

    internal bool method_0(GClass17 gclass17_0)
    {
      return gclass17_0.gclass146_0 == this.gclass146_0 && gclass17_0.int_2 > 0;
    }
  }

  
  private sealed class Class381
  {
    public GClass17 gclass17_0;
    public GClass2.Class380 class380_0;

    public Class381()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass102_0.genum116_0 == this.gclass17_0.genum116_0;
    }

    internal int method_1(GClass85 gclass85_0)
    {
      return this.class380_0.class374_0.gclass2_0.gclass0_0.method_35(gclass85_0.gclass202_0.gclass200_0, this.gclass17_0.gclass146_0.gclass202_0.gclass200_0, this.class380_0.class374_0.gclass2_0.gclass21_0);
    }

    internal bool method_2(GClass17 gclass17_1)
    {
      return gclass17_1.genum116_0 == this.gclass17_0.genum116_0 && gclass17_1.int_6 > 0;
    }

    internal int method_3(GClass17 gclass17_1)
    {
      return this.class380_0.class374_0.gclass2_0.gclass0_0.method_35(gclass17_1.gclass146_0.gclass202_0.gclass200_0, this.gclass17_0.gclass146_0.gclass202_0.gclass200_0, this.class380_0.class374_0.gclass2_0.gclass21_0);
    }
  }

  
  private sealed class Class382
  {
    public GClass85 gclass85_0;
    public GClass2.Class381 class381_0;

    public Class382()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass102_0.genum116_0 == this.class381_0.gclass17_0.genum116_0 && gclass103_0.gclass40_0.gclass85_0 == this.gclass85_0;
    }
  }

  
  private sealed class Class383
  {
    public GClass17 gclass17_0;

    public Class383()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass102_0.genum116_0 == this.gclass17_0.genum116_0;
    }
  }

  
  private sealed class Class384
  {
    public List<GClass139> list_0;

    public Class384()
    {
      
    }

    internal bool method_0(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0 != null && this.list_0.Select<GClass139, int>(gClass139=>gClass139.int_7).Contains<int>(gclass103_0.int_0);
    }
  }

  
  private sealed class Class385
  {
    public List<GClass1> list_0;
    public GClass2 gclass2_0;

    public Class385()
    {
      
    }

    internal bool method_0(GClass193 gclass193_0)
    {
      return !this.list_0.Contains(gclass193_0.gclass146_0.gclass1_0);
    }
  }

  
  private sealed class Class386
  {
    public GClass85 gclass85_0;
    public GClass2.Class385 class385_0;

    public Class386()
    {
      
    }

    internal bool method_0(GClass193 gclass193_0)
    {
      return gclass193_0.gclass146_0.gclass202_0 == this.gclass85_0.gclass202_0 && gclass193_0.auroraShipyardType_0 == this.class385_0.gclass2_0.auroraShipyardType_0 && gclass193_0.decimal_0 >= this.class385_0.gclass2_0.decimal_4;
    }

    internal double method_1(GClass146 gclass146_0)
    {
      return this.gclass85_0.gclass202_0.gclass200_0.method_3(this.gclass85_0.double_2, this.gclass85_0.double_3, gclass146_0.method_87(), gclass146_0.method_88());
    }
  }

  
  private sealed class Class387
  {
    public List<GClass1> list_0;

    public Class387()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return !this.list_0.Contains(gclass146_0.gclass1_0);
    }
  }

  
  private sealed class Class388
  {
    public GClass85 gclass85_0;

    public Class388()
    {
      
    }

    internal double method_0(GClass146 gclass146_0)
    {
      return this.gclass85_0.gclass202_0.gclass200_0.method_3(this.gclass85_0.double_2, this.gclass85_0.double_3, gclass146_0.method_87(), gclass146_0.method_88());
    }
  }

  
  private sealed class Class389
  {
    public Decimal decimal_0;
    public GClass2.Class388 class388_0;

    public Class389()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass202_0 == this.class388_0.gclass85_0.gclass202_0 && gclass146_0.gclass6_0.decimal_0 > this.decimal_0;
    }
  }

  
  private sealed class Class390
  {
    public GClass85 gclass85_0;

    public Class390()
    {
      
    }

    internal bool method_0(GClass210 gclass210_0)
    {
      return gclass210_0.gclass200_0 == this.gclass85_0.gclass202_0.gclass200_0;
    }
  }

  
  private sealed class Class391
  {
    public GClass85 gclass85_0;
    public GClass2 gclass2_0;

    public Class391()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      return gclass40_0.gclass85_0.gclass202_0 == this.gclass85_0.gclass202_0;
    }

    internal bool method_1(GClass40 gclass40_0)
    {
      return gclass40_0.gclass85_0.gclass202_0 == this.gclass85_0.gclass202_0;
    }

    internal double method_2(GClass40 gclass40_0)
    {
      return this.gclass2_0.gclass0_0.method_28(this.gclass85_0.double_2, this.gclass85_0.double_3, gclass40_0.gclass85_0.double_2, gclass40_0.gclass85_0.double_3);
    }
  }

  
  private sealed class Class392
  {
    public List<GClass40> list_0;

    public Class392()
    {
      
    }

    internal bool method_0(GClass132 gclass132_0)
    {
      return this.list_0.Contains(gclass132_0.gclass40_0);
    }
  }

  
  private sealed class Class393
  {
    public GClass40 gclass40_0;

    public Class393()
    {
      
    }

    internal bool method_0(GClass40 gclass40_1)
    {
      return gclass40_1.gclass40_0 == this.gclass40_0;
    }
  }

  
  private sealed class Class394
  {
    public List<GClass1> list_0;

    public Class394()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return !this.list_0.Contains(gclass146_0.gclass1_0);
    }
  }

  
  private sealed class Class395
  {
    public GClass85 gclass85_0;
    public Func<GClass40, bool> func_0;
    public Func<GClass40, bool> func_1;

    public Class395()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      return gclass40_0.gclass85_0 == this.gclass85_0;
    }

    internal bool method_1(GClass40 gclass40_0)
    {
      return gclass40_0.gclass85_0 == this.gclass85_0;
    }

    internal bool method_2(GClass40 gclass40_0)
    {
      return gclass40_0.gclass85_0 == this.gclass85_0;
    }
  }

  
  private sealed class Class396
  {
    public GClass129 gclass129_0;

    public Class396()
    {
      
    }

    internal bool method_0(GClass130 gclass130_0)
    {
      return gclass130_0.gclass129_0 == this.gclass129_0;
    }

    internal bool method_1(GClass130 gclass130_0)
    {
      return gclass130_0.gclass129_0 == this.gclass129_0;
    }
  }

  
  private sealed class Class397
  {
    public GClass130 gclass130_0;
    public GClass2.Class395 class395_0;

    public Class397()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass202_0 == this.class395_0.gclass85_0.gclass202_0 && gclass146_0.method_87() == this.class395_0.gclass85_0.double_2 && gclass146_0.method_88() == this.class395_0.gclass85_0.double_3 && gclass146_0.gclass6_0.dictionary_0.ContainsKey(this.gclass130_0.gclass129_0);
    }

    internal bool method_1(GClass146 gclass146_0)
    {
      return gclass146_0.gclass202_0 == this.class395_0.gclass85_0.gclass202_0 && gclass146_0.gclass6_0.dictionary_0.ContainsKey(this.gclass130_0.gclass129_0);
    }

    internal bool method_2(GClass146 gclass146_0)
    {
      return (double) gclass146_0.gclass6_0.dictionary_0[this.gclass130_0.gclass129_0].int_0 >= (double) this.gclass130_0.int_0 / 2.0;
    }

    internal int method_3(GClass146 gclass146_0)
    {
      return gclass146_0.gclass6_0.dictionary_0[this.gclass130_0.gclass129_0].int_0;
    }
  }

  
  private sealed class Class398
  {
    public GClass2 gclass2_0;
    public GEnum104 genum104_0;

    public Class398()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return gclass120_0.method_2(this.gclass2_0.gclass21_0);
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass2_0.gclass21_0;
    }

    internal GClass202 method_2(GClass120 gclass120_0)
    {
      return this.gclass2_0.gclass21_0.method_128(gclass120_0.gclass200_0);
    }
  }

  
  private sealed class Class399
  {
    public List<int> list_0;
    public List<GClass202> list_1;
    public GClass2.Class398 class398_0;
    public Func<GClass85, bool> func_0;

    public Class399()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return !this.list_0.Contains(gclass120_0.int_0);
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.gclass9_0.genum104_0 == this.class398_0.genum104_0 && this.list_1.Contains(gclass85_0.gclass202_0) && gclass85_0.gclass4_0.genum100_0 == GEnum100.const_2 && !gclass85_0.gclass4_0.bool_1 && !gclass85_0.method_42(GEnum123.const_0);
    }
  }

  
  private sealed class Class400
  {
    public GClass202 gclass202_0;
    public GClass2.Class399 class399_0;
    public Func<GClass85, bool> func_0;
    public Func<GClass85, int> func_1;

    public Class400()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return this.class399_0.class398_0.gclass2_0.gclass21_0.method_128(gclass120_0.gclass200_0) == this.gclass202_0;
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.gclass9_0.genum104_0 == this.class399_0.class398_0.genum104_0 && gclass85_0.gclass202_0 == this.gclass202_0 && gclass85_0.gclass4_0.genum100_0 == GEnum100.const_2 && !gclass85_0.gclass4_0.bool_1 && !gclass85_0.method_42(GEnum123.const_0);
    }

    internal int method_2(GClass85 gclass85_0)
    {
      return this.class399_0.class398_0.gclass2_0.gclass0_0.method_35(gclass85_0.gclass202_0.gclass200_0, this.gclass202_0.gclass200_0, this.class399_0.class398_0.gclass2_0.gclass21_0);
    }
  }

  
  private sealed class Class401
  {
    public GClass120 gclass120_0;

    public Class401()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return this.gclass120_0.int_2 > 0 || gclass85_0.method_241();
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return this.gclass120_0.int_2 > 0 || gclass85_0.method_241();
    }
  }

  
  private sealed class Class402
  {
    public GEnum104 genum104_0;
    public GEnum100 genum100_0;
    public List<GClass202> list_0;
    public GClass2 gclass2_0;
    public Func<GClass85, bool> func_0;

    public Class402()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass9_0.genum104_0 == this.genum104_0 && (this.list_0.Contains(gclass85_0.gclass202_0) || gclass85_0.gclass202_0.gclass3_0.int_2 < 1) && gclass85_0.gclass4_0.genum100_0 >= this.genum100_0 && !gclass85_0.gclass4_0.bool_1 && !gclass85_0.gclass4_0.bool_2;
    }
  }

  
  private sealed class Class403
  {
    public GClass202 gclass202_0;
    public GClass2.Class402 class402_0;

    public Class403()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass9_0.genum104_0 == this.class402_0.genum104_0 && gclass85_0.gclass4_0.gclass202_0 == this.gclass202_0 && gclass85_0.gclass4_0.genum100_0 >= this.class402_0.genum100_0 && gclass85_0.gclass4_0.bool_1;
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.gclass9_0.genum104_0 == this.class402_0.genum104_0 && gclass85_0.gclass202_0 == this.gclass202_0 && gclass85_0.gclass4_0.genum100_0 >= this.class402_0.genum100_0 && !gclass85_0.gclass4_0.bool_1;
    }

    internal int method_2(GClass85 gclass85_0)
    {
      return this.class402_0.gclass2_0.gclass0_0.method_35(gclass85_0.gclass202_0.gclass200_0, this.gclass202_0.gclass200_0, this.class402_0.gclass2_0.gclass21_0);
    }
  }

  
  private sealed class Class404
  {
    public GClass202 gclass202_0;
    public Decimal decimal_0;
    public GClass2 gclass2_0;

    public Class404()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass9_0.bool_2 && gclass85_0.gclass4_0.gclass202_0 == this.gclass202_0 && gclass85_0.gclass4_0.genum100_0 == GEnum100.const_2 && gclass85_0.gclass4_0.bool_1;
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.method_13() > this.decimal_0;
    }

    internal bool method_2(GClass85 gclass85_0)
    {
      return gclass85_0.gclass9_0.bool_2 && gclass85_0.gclass4_0.genum100_0 == GEnum100.const_2 && !gclass85_0.gclass4_0.bool_1 && !gclass85_0.gclass4_0.bool_2 && gclass85_0.gclass202_0 != this.gclass202_0;
    }

    internal bool method_3(GClass85 gclass85_0)
    {
      return gclass85_0.method_13() > this.decimal_0;
    }

    internal int method_4(GClass85 gclass85_0)
    {
      return this.gclass2_0.gclass0_0.method_35(gclass85_0.gclass202_0.gclass200_0, this.gclass202_0.gclass200_0, this.gclass2_0.gclass21_0);
    }
  }

  
  private sealed class Class405
  {
    public GEnum104 genum104_0;
    public List<GClass202> list_0;
    public GClass2 gclass2_0;
    public Func<GClass85, bool> func_0;
    public Func<GClass85, bool> func_1;

    public Class405()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass9_0.genum104_0 == this.genum104_0;
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.gclass9_0.genum104_0 == this.genum104_0 && this.list_0.Contains(gclass85_0.gclass202_0) && gclass85_0.gclass4_0.genum100_0 == GEnum100.const_2 && !gclass85_0.gclass4_0.bool_1;
    }
  }

  
  private sealed class Class406
  {
    public GClass202 gclass202_0;
    public GClass2.Class405 class405_0;
    public Func<GClass85, bool> func_0;
    public Func<GClass85, int> func_1;

    public Class406()
    {
      
    }

    internal GClass120 method_0(GClass202 gclass202_1)
    {
      return gclass202_1.method_11(this.gclass202_0).gclass120_0;
    }

    internal bool method_1(GClass214 gclass214_0)
    {
      return gclass214_0.gclass21_0 == this.gclass202_0.gclass21_0 && gclass214_0.gclass200_0 == this.gclass202_0.gclass200_0 && gclass214_0.wayPointType_0 == WayPointType.TransitPOI;
    }

    internal bool method_2(GClass85 gclass85_0)
    {
      return gclass85_0.gclass9_0.genum104_0 == this.class405_0.genum104_0 && gclass85_0.gclass202_0 == this.gclass202_0 && gclass85_0.gclass4_0.genum100_0 == GEnum100.const_2 && !gclass85_0.gclass4_0.bool_1;
    }

    internal int method_3(GClass85 gclass85_0)
    {
      return this.class405_0.gclass2_0.gclass0_0.method_35(gclass85_0.gclass202_0.gclass200_0, this.gclass202_0.gclass200_0, this.class405_0.gclass2_0.gclass21_0);
    }
  }

  
  private sealed class Class407
  {
    public GClass120 gclass120_0;
    public GClass2.Class406 class406_0;

    public Class407()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass9_0.genum104_0 == this.class406_0.class405_0.genum104_0 && gclass85_0.gclass202_0 == this.class406_0.gclass202_0 && gclass85_0.double_2 == this.gclass120_0.double_1 && gclass85_0.double_3 == this.gclass120_0.double_2 && gclass85_0.gclass4_0.genum100_0 == GEnum100.const_2 && !gclass85_0.gclass4_0.bool_1;
    }
  }

  
  private sealed class Class408
  {
    public GClass120 gclass120_0;

    public Class408()
    {
      
    }

    internal bool method_0(GClass139 gclass139_0)
    {
      return gclass139_0.genum13_0 == GEnum13.const_0 && gclass139_0.int_2 == this.gclass120_0.int_0 && gclass139_0.gclass133_0.genum123_0 == GEnum123.const_1;
    }
  }

  
  private sealed class Class409
  {
    public GClass202 gclass202_0;
    public GEnum104 genum104_0;
    public Func<GClass85, bool> func_0;

    public Class409()
    {
      
    }

    internal GClass120 method_0(GClass202 gclass202_1)
    {
      return gclass202_1.method_11(this.gclass202_0).gclass120_0;
    }

    internal bool method_1(GClass214 gclass214_0)
    {
      return gclass214_0.gclass21_0 == this.gclass202_0.gclass21_0 && gclass214_0.gclass200_0 == this.gclass202_0.gclass200_0 && gclass214_0.wayPointType_0 == WayPointType.TransitPOI;
    }

    internal bool method_2(GClass85 gclass85_0)
    {
      return gclass85_0.gclass9_0.genum104_0 == this.genum104_0 && gclass85_0.gclass202_0 == this.gclass202_0 && gclass85_0.gclass4_0.genum100_0 == GEnum100.const_2 && !gclass85_0.gclass4_0.bool_1;
    }
  }

  
  private sealed class Class410
  {
    public GClass120 gclass120_0;
    public GClass2.Class409 class409_0;

    public Class410()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass202_0 == this.class409_0.gclass202_0 && gclass85_0.double_2 == this.gclass120_0.double_1 && gclass85_0.double_3 == this.gclass120_0.double_2 && gclass85_0.gclass4_0.genum100_0 == GEnum100.const_2 && !gclass85_0.gclass4_0.bool_1;
    }
  }

  
  private sealed class Class411
  {
    public GClass85 gclass85_0;
    public GClass2 gclass2_0;

    public Class411()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass202_0 == this.gclass85_0.gclass202_0;
    }

    internal int method_1(GClass146 gclass146_0)
    {
      return this.gclass2_0.gclass0_0.method_35(this.gclass85_0.gclass202_0.gclass200_0, gclass146_0.gclass202_0.gclass200_0, this.gclass85_0.gclass21_0);
    }
  }

  
  private sealed class Class412
  {
    public GClass85 gclass85_0;
    public GClass2 gclass2_0;

    public Class412()
    {
      
    }

    internal bool method_0(GClass85 gclass85_1)
    {
      return gclass85_1.gclass202_0 == this.gclass85_0.gclass202_0 && gclass85_1.dictionary_0.Count == 0;
    }

    internal double method_1(GClass85 gclass85_1)
    {
      return this.gclass2_0.gclass0_0.method_28(this.gclass85_0.double_2, this.gclass85_0.double_3, gclass85_1.double_2, gclass85_1.double_3);
    }

    internal int method_2(GClass85 gclass85_1)
    {
      return this.gclass2_0.gclass0_0.method_35(this.gclass85_0.gclass202_0.gclass200_0, gclass85_1.gclass202_0.gclass200_0, this.gclass85_0.gclass21_0);
    }

    internal bool method_3(GClass146 gclass146_0)
    {
      return gclass146_0.gclass202_0 == this.gclass85_0.gclass202_0;
    }

    internal int method_4(GClass146 gclass146_0)
    {
      return this.gclass2_0.gclass0_0.method_35(this.gclass85_0.gclass202_0.gclass200_0, gclass146_0.gclass202_0.gclass200_0, this.gclass85_0.gclass21_0);
    }
  }

  
  private sealed class Class413
  {
    public GClass2 gclass2_0;
    public List<GClass202> list_0;

    public Class413()
    {
      
    }

    internal bool method_0(GClass200 gclass200_0)
    {
      return this.gclass2_0.gclass21_0.dictionary_0.Values.Select<GClass202, GClass200>(gClass202=>gClass202.gclass200_0).ToList<GClass200>().Contains(gclass200_0);
    }

    internal GClass202 method_1(GClass200 gclass200_0)
    {
      return this.gclass2_0.gclass21_0.method_128(gclass200_0);
    }

    internal bool method_2(GClass202 gclass202_0)
    {
      return !this.list_0.Contains(gclass202_0) && gclass202_0.gclass3_0.genum95_0 != 0;
    }

    internal bool method_3(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass2_0.gclass21_0 && gclass85_0.gclass9_0.genum104_0 == GEnum104.const_9;
    }

    internal bool method_4(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass2_0.gclass21_0 && gclass85_0.gclass9_0.genum104_0 == GEnum104.const_9 && !gclass85_0.gclass4_0.bool_1 && !gclass85_0.gclass4_0.bool_2;
    }

    internal bool method_5(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass2_0.gclass21_0 && gclass85_0.gclass9_0.genum104_0 == GEnum104.const_22;
    }
  }

  
  private sealed class Class414
  {
    public List<GClass200> list_0;

    public Class414()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return this.list_0.Contains(gclass1_0.gclass200_0);
    }
  }

  
  private sealed class Class415
  {
    public GClass85 gclass85_0;
    public Func<GClass1, bool> func_0;

    public Class415()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass85_0.gclass202_0.gclass200_0 && gclass1_0.double_0 == this.gclass85_0.double_2 && gclass1_0.double_1 == this.gclass85_0.double_3;
    }
  }

  
  private sealed class Class416
  {
    public GClass85 gclass85_0;

    public Class416()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.double_0 == this.gclass85_0.double_2 && gclass1_0.double_1 == this.gclass85_0.double_3 && gclass1_0.gclass200_0 == this.gclass85_0.gclass202_0.gclass200_0;
    }
  }
}