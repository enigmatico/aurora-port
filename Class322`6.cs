// Decompiled with JetBrains decompiler
// Type: Class322`6
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
[CompilerGenerated]
internal sealed class Class322<T, U, V, W, X, Y>
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly T gparam_0;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly U gparam_1;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly V gparam_2;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly W gparam_3;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly X gparam_4;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly Y gparam_5;

    public T SensorRace => this.gparam_0;

    public U SensorSystem => this.gparam_1;

    public V Resolution => this.gparam_2;

    public W Range => this.gparam_3;

    public X Xcor => this.gparam_4;

    public Y Ycor => this.gparam_5;

    [DebuggerHidden]
    public Class322(T gparam_6, U gparam_7, V gparam_8, W gparam_9, X gparam_10, Y gparam_11)
    {
        // ISSUE: reference to a compiler-generated field
        this.gparam_0 = gparam_6;
        // ISSUE: reference to a compiler-generated field
        this.gparam_1 = gparam_7;
        // ISSUE: reference to a compiler-generated field
        this.gparam_2 = gparam_8;
        // ISSUE: reference to a compiler-generated field
        this.gparam_3 = gparam_9;
        // ISSUE: reference to a compiler-generated field
        this.gparam_4 = gparam_10;
        // ISSUE: reference to a compiler-generated field
        this.gparam_5 = gparam_11;
    }

    [DebuggerHidden]
    public override bool Equals(object value)
    {
        // ISSUE: variable of a compiler-generated type
        Class322<T, U, V, W, X, Y> class322 = value as Class322<T, U, V, W, X, Y>;
        if (this == class322)
            return true;
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
        // ISSUE: reference to a compiler-generated field
        return class322 != null && EqualityComparer<T>.Default.Equals(this.gparam_0, class322.gparam_0) &&
               EqualityComparer<U>.Default.Equals(this.gparam_1, class322.gparam_1) &&
               EqualityComparer<V>.Default.Equals(this.gparam_2, class322.gparam_2) &&
               EqualityComparer<W>.Default.Equals(this.gparam_3, class322.gparam_3) &&
               EqualityComparer<X>.Default.Equals(this.gparam_4, class322.gparam_4) &&
               EqualityComparer<Y>.Default.Equals(this.gparam_5, class322.gparam_5);
    }

    [DebuggerHidden]
    public override int GetHashCode()
    {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        return (((((1598346340 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 +
                   EqualityComparer<U>.Default.GetHashCode(this.gparam_1)) * -1521134295 +
                  EqualityComparer<V>.Default.GetHashCode(this.gparam_2)) * -1521134295 +
                 EqualityComparer<W>.Default.GetHashCode(this.gparam_3)) * -1521134295 +
                EqualityComparer<X>.Default.GetHashCode(this.gparam_4)) * -1521134295 +
               EqualityComparer<Y>.Default.GetHashCode(this.gparam_5);
    }

    [DebuggerHidden]
    public override string ToString()
    {
        object[] objArray = new object[6];
        // ISSUE: reference to a compiler-generated field
        T gparam0 = this.gparam_0;
        ref T local1 = ref gparam0;
        objArray[0] = local1 != null ? local1.ToString() : null;
        // ISSUE: reference to a compiler-generated field
        U gparam1 = this.gparam_1;
        ref U local2 = ref gparam1;
        objArray[1] = local2 != null ? local2.ToString() : null;
        // ISSUE: reference to a compiler-generated field
        V gparam2 = this.gparam_2;
        ref V local3 = ref gparam2;
        objArray[2] = local3 != null ? local3.ToString() : null;
        // ISSUE: reference to a compiler-generated field
        W gparam3 = this.gparam_3;
        ref W local4 = ref gparam3;
        objArray[3] = local4 != null ? local4.ToString() : null;
        // ISSUE: reference to a compiler-generated field
        X gparam4 = this.gparam_4;
        ref X local5 = ref gparam4;
        objArray[4] = local5 != null ? local5.ToString() : null;
        // ISSUE: reference to a compiler-generated field
        Y gparam5 = this.gparam_5;
        ref Y local6 = ref gparam5;
        objArray[5] = local6 != null ? local6.ToString() : null;
        return string.Format(null,
            "{{ SensorRace = {0}, SensorSystem = {1}, Resolution = {2}, Range = {3}, Xcor = {4}, Ycor = {5} }}",
            objArray);
    }
}