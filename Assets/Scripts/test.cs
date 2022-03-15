using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public List<string> vs = new List<string>();

    void Start()
    {
        vs.Add("ok1");
        vs.Add("ok2");
        vs.Add("ok3");

        vs.RemoveAt(vs.Count-1);

        for (int i = 0; i < vs.Count; i++)
        {
            Debug.Log(vs[i]);
        }
    }

    void Update()
    {
        
    }
}
