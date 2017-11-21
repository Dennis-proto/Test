using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

public class Auto
{
    public string name;
    private int räder = 4;

    public Auto()
    {

    }
    public int Räder
    {
        get
        {
            return this.räder;


        }
    }
}
/*public class DataBaseTable
{
    MySqlConnection connection;
    MySqlDataAdapter adapter;
    public DataTable GetTable(string query, string SortyBy)
    {
        String connString = "server=localhost;uid=root;pwd=test;database=protoform;";
        connection = new MySqlConnection(connString);
        adapter = new MySqlDataAdapter(query, connection);
        DataTable dataTable = new DataTable();
        adapter.Fill(dataTable);
        dataTable.DefaultView.Sort = SortyBy;
        return dataTable;


    }

}*/
