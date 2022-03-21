using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class test : MonoBehaviour
{
    public List<int> vs = new List<int>();

    void Start()
    {
        vs.Add(2);
        vs.Add(10);
        vs.Add(3);

        Debug.Log( vs.IndexOf(vs.Max()) );

        
    }

    void Update()
    {
        
    }
}
