using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Note: The following class gets the user's current system time. - Amorse
public class GetSystemTime : MonoBehaviour
{

    private int m_Hour;

    // Start is called before the first frame update
    void Start()
    {
        if (null != m_Hour) 
        {
            m_Hour = System.DateTime.Now.Hour;
        }
    }

    // Update is called once per frame
    void Update()
    {
        PrintHour(m_Hour);
        
    }

    void PrintHour(int currentHour) 
    {
    	Debug.Log("The current hour is " + m_Hour);
    }
}
