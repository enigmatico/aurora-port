// Decompiled with JetBrains decompiler
// Type: Class1181
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Data;
using System.Data.SQLite;

#nullable disable
internal class SQLiteDatabaseC1181
{
    public DataTable ExecuteQuery(string sqlQueryString)
    {
        try
        {
            SQLiteConnection connection = new SQLiteConnection(AuroraUtils.string_1);
            connection.Open();
            SQLiteDataAdapter sqLiteDataAdapter = new SQLiteDataAdapter(sqlQueryString, connection);
            sqLiteDataAdapter.SelectCommand.CommandTimeout = 360;
            DataSet dataSet = new DataSet();
            sqLiteDataAdapter.Fill(dataSet, "RecordSet");
            connection.Close();
            return dataSet.Tables["RecordSet"];
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 483);
            return null;
        }
    }

    public int method_1(string string_0, string string_1)
    {
        try
        {
            SQLiteConnection connection = new SQLiteConnection(AuroraUtils.string_1);
            connection.Open();
            SQLiteDataAdapter sqLiteDataAdapter =
                new SQLiteDataAdapter(string.Format("Select max({0}) from {1}", string_1, string_0), connection);
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
            AuroraUtils.ShowExceptionPopup(ex, 484);
            return 0;
        }
    }
}