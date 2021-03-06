﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for Grant
/// </summary>
public class Grant
{
    private SqlConnection connect;
    public Grant()
    {
        string connectString = ConfigurationManager.ConnectionStrings["Community_Assist_Connection"].ToString();
        connect = new SqlConnection(connectString);
    }

    public DataTable GetGrants(int grantKey)
    {
        DataTable table = new DataTable();
        string sql = "Select GrantReviewDate as [Date], "
 + "GrantRequestExplanation as Explanation, "
 + "GrantAllocationAmount as Amount, "
 + "GrantRequestStatus as [Status] "
 + "From GrantRequest r "
 + "inner join GrantReview gr "
 + "on r.GrantRequestKey = gr.GrantRequestKey "
 + " Where GrantTypeKey = @GrantTypeKey";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@GrantTypeKey", grantKey);
        SqlDataReader reader = null;
        connect.Open();
        reader = cmd.ExecuteReader();
        table.Load(reader);
        reader.Close();
        connect.Close();
        return table;
    }

    public DataTable GetType()
    {
        DataTable table = new DataTable();
        string sql = "Select GrantTypeName, GrantTypeKey from GrantType";
        SqlCommand cmd = new SqlCommand(sql, connect);
        SqlDataReader reader = null;
        connect.Open();
        reader = cmd.ExecuteReader();
        table.Load(reader);
        reader.Close();
        connect.Close();
        return table;
    }
}