using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;
using System;
using System.Data;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

public class db : MonoBehaviour
{
    public string host, database, user, password;
    public bool pooling=true;

    private string connectionstring;
    private MySqlConnection con = null;
    private MySqlCommand cmd = null;
    private MySqlDataReader rdr = null;

    private MD5 _md5Hash;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        connectionstring = "Server=" + host + ";Database=" + database + ";User=" + user + ";Password=" + password + ";Pooling=";
        if (pooling)
        {
            connectionstring += "true";
        }
        else
        {
            connectionstring += "false";
        }
        try
        {
            con = new MySqlConnection(connectionstring);
            con.Open();
            Debug.Log("My Sql State "+con.State);
        }catch(Exception e)
        {
            Debug.Log(e);
        }
        void OnApplicationQuit()
        {
            if(con!=null)
                if(con.State.ToString()!="Closed")
                {
                    con.Close();
                    Debug.Log("My connection closed");
                }
            con.Dispose();
        }
    }
    public string GetConnectionState()
    {
        return con.State.ToString();
    }
}
