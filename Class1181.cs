// Decompiled with JetBrains decompiler
// Type: Class1181
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Data;
using System.Data.SQLite;

#nullable disable
internal class Class1181
{
  public DataTable method_0(string string_0)
  {
    try
    {
      SQLiteConnection connection = new SQLiteConnection(GClass226.string_1);
      connection.Open();
      SQLiteDataAdapter sqLiteDataAdapter = new SQLiteDataAdapter(string_0, connection);
      sqLiteDataAdapter.SelectCommand.CommandTimeout = 360;
      DataSet dataSet = new DataSet();
      sqLiteDataAdapter.Fill(dataSet, "RecordSet");
      connection.Close();
      return dataSet.Tables["RecordSet"];
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 483);
      return (DataTable) null;
    }
  }

  public int method_1(string string_0, string string_1)
  {
    try
    {
      SQLiteConnection connection = new SQLiteConnection(GClass226.string_1);
      connection.Open();
      SQLiteDataAdapter sqLiteDataAdapter = new SQLiteDataAdapter($"Select max({string_1}) from {string_0}", connection);
      sqLiteDataAdapter.SelectCommand.CommandTimeout = 360;
      DataSet dataSet = new DataSet();
      sqLiteDataAdapter.Fill(dataSet, "RecordSet");
      connection.Close();
      if (dataSet.Tables["RecordSet"].Rows.Count <= 0)
        return 0;
      DataRow row = dataSet.Tables["RecordSet"].Rows[0];
      return row[0] is DBNull ? 0 : Convert.ToInt32(row[0]);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 484);
      return 0;
    }
  }
}
