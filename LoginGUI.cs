using System.Collections;
using UnityEngine;


public class LoginGUI : MonoBehaviour
{
    public db _mysqlHolder;
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 300, 30), "My SQL Connection state: " + _mysqlHolder.GetConnectionState());
    }
}
