// Decompiled with JetBrains decompiler
// Type: Class326`4
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
[CompilerGenerated]
internal sealed class Class326<T, U, V, W>
{
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  private readonly T gparam_0;
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  private readonly U gparam_1;
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  private readonly V gparam_2;
  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  private readonly W gparam_3;

  public T SensorRace => this.gparam_0;

  public U SensorSystem => this.gparam_1;

  public V Xcor => this.gparam_2;

  public W Ycor => this.gparam_3;

  [DebuggerHidden]
  public Class326(T gparam_4, U gparam_5, V gparam_6, W gparam_7)
  {
    // ISSUE: reference to a compiler-generated field
    this.gparam_0 = gparam_4;
    // ISSUE: reference to a compiler-generated field
    this.gparam_1 = gparam_5;
    // ISSUE: reference to a compiler-generated field
    this.gparam_2 = gparam_6;
    // ISSUE: reference to a compiler-generated field
    this.gparam_3 = gparam_7;
  }

  [DebuggerHidden]
  public override bool Equals(object value)
  {
    // ISSUE: variable of a compiler-generated type
    Class326<T, U, V, W> class326 = value as Class326<T, U, V, W>;
    if (this == class326)
      return true;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return class326 != null && EqualityComparer<T>.Default.Equals(this.gparam_0, class326.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, class326.gparam_1) && EqualityComparer<V>.Default.Equals(this.gparam_2, class326.gparam_2) && EqualityComparer<W>.Default.Equals(this.gparam_3, class326.gparam_3);
  }

  [DebuggerHidden]
  public override int GetHashCode()
  {
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return (((EqualityComparer<T>.Default.GetHashCode(this.gparam_0) - 1657138387) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1)) * -1521134295 + EqualityComparer<V>.Default.GetHashCode(this.gparam_2)) * -1521134295 + EqualityComparer<W>.Default.GetHashCode(this.gparam_3);
  }

  [DebuggerHidden]
  public override string ToString()
  {
    object[] objArray = new object[4];
    // ISSUE: reference to a compiler-generated field
    T gparam0 = this.gparam_0;
    ref T local1 = ref gparam0;
    objArray[0] = (object) ((object) local1 != null ? local1.ToString() : (string) null);
    // ISSUE: reference to a compiler-generated field
    U gparam1 = this.gparam_1;
    ref U local2 = ref gparam1;
    objArray[1] = (object) ((object) local2 != null ? local2.ToString() : (string) null);
    // ISSUE: reference to a compiler-generated field
    V gparam2 = this.gparam_2;
    ref V local3 = ref gparam2;
    objArray[2] = (object) ((object) local3 != null ? local3.ToString() : (string) null);
    // ISSUE: reference to a compiler-generated field
    W gparam3 = this.gparam_3;
    ref W local4 = ref gparam3;
    objArray[3] = (object) ((object) local4 != null ? local4.ToString() : (string) null);
    return string.Format((IFormatProvider) null, "{{ SensorRace = {0}, SensorSystem = {1}, Xcor = {2}, Ycor = {3} }}", objArray);
  }
}
