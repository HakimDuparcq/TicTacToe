using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public Button un;
    public Button deux;
    public Button[,] Buttons = new Button[3, 3];
    public Button[,] ButtonsAcopier = new Button[3, 3];

    void Start()
    {
        Buttons[0, 0] = un;
        Buttons[1, 0]  = deux;

        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                ButtonsAcopier[x, y] = Buttons[x, y];
            }
        }
        Debug.Log("original" + Buttons[0, 0] + Buttons[1, 0]);
        Debug.Log("copie" + ButtonsAcopier[0, 0] + ButtonsAcopier[1, 0]);
        Buttons[0, 0]=deux;
        Buttons[1, 0]=un;

        Debug.Log("original" + Buttons[0, 0] + Buttons[1, 0]);
        Debug.Log("copie" + ButtonsAcopier[0, 0] + ButtonsAcopier[1, 0]);


    }

    void Update()
    {
        
    }
}
