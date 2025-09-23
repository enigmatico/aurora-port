// Decompiled with JetBrains decompiler
// Type: Class329`2
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
[CompilerGenerated]
internal sealed class Class329<T, U>
{
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  private readonly T gparam_0;
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  private readonly U gparam_1;

  public T MineralID => this.gparam_0;

  public U DataType => this.gparam_1;

  [DebuggerHidden]
  public Class329(T gparam_2, U gparam_3)
  {
    // ISSUE: reference to a compiler-generated field
    this.gparam_0 = gparam_2;
    // ISSUE: reference to a compiler-generated field
    this.gparam_1 = gparam_3;
  }

  [DebuggerHidden]
  public override bool Equals(object value)
  {
    // ISSUE: variable of a compiler-generated type
    Class329<T, U> class329 = value as Class329<T, U>;
    if (this == class329)
      return true;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return class329 != null && EqualityComparer<T>.Default.Equals(this.gparam_0, class329.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, class329.gparam_1);
  }

  [DebuggerHidden]
  public override int GetHashCode()
  {
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return (EqualityComparer<T>.Default.GetHashCode(this.gparam_0) - 1558636025) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1);
  }

  [DebuggerHidden]
  public override string ToString()
  {
    object[] objArray = new object[2];
    // ISSUE: reference to a compiler-generated field
    T gparam0 = this.gparam_0;
    ref T local1 = ref gparam0;
    objArray[0] = (object) ((object) local1 != null ? local1.ToString() : (string) null);
    // ISSUE: reference to a compiler-generated field
    U gparam1 = this.gparam_1;
    ref U local2 = ref gparam1;
    objArray[1] = (object) ((object) local2 != null ? local2.ToString() : (string) null);
    return string.Format((IFormatProvider) null, "{{ MineralID = {0}, DataType = {1} }}", objArray);
  }
}
