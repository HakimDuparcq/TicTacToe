using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bot : MonoBehaviour
{
    public Button[] ButtonsEnter = new Button[9];
    public Button[,] Buttons = new Button[3, 3];
    public bool Botplay=false;
    public string[] values =  new string[2];
    List<string> Historique = new List<string>();

    void Start()
    {
        Buttons[0, 0] = ButtonsEnter[0];
        Buttons[1, 0] = ButtonsEnter[1];
        Buttons[2, 0] = ButtonsEnter[2];
        Buttons[0, 1] = ButtonsEnter[3];
        Buttons[1, 1] = ButtonsEnter[4];
        Buttons[2, 1] = ButtonsEnter[5];
        Buttons[0, 2] = ButtonsEnter[6];
        Buttons[1, 2] = ButtonsEnter[7];
        Buttons[2, 2] = ButtonsEnter[8];

        values[0] = "X";
        values[1] = "O";
    }

    void Update()
    {
        if (Botplay)//au bot de jouer
        {
            CompleteArray(Buttons, 3, Botplay, Historique);
            Botplay=!Botplay;
        }
        //Debug.LogError(IsGameFinish());
       // Debug.LogError(Buttons[0, 0].GetComponentInChildren<Text>().text);
    }


    public void OnButtonClicked(GameObject but)
    {
        Text textt = but.GetComponentInChildren<Text>();
        textt.text = "X";
        Botplay = true;
    }




    public bool IsGameFinish()
    {
        for (int i = 0; i < values.Length; i++)
        {
            //ligne
            if (Buttons[0, 0].GetComponentInChildren<Text>().text == values[i] && Buttons[1, 0].GetComponentInChildren<Text>().text == values[i] && Buttons[2, 0].GetComponentInChildren<Text>().text == values[i]  )
            {
                return true;
            }

            if (Buttons[0, 1].GetComponentInChildren<Text>().text == values[i] && Buttons[1, 1].GetComponentInChildren<Text>().text == values[i] && Buttons[2, 1].GetComponentInChildren<Text>().text == values[i])
            {
                return true;
            }

            if (Buttons[0, 2].GetComponentInChildren<Text>().text == values[i] && Buttons[1, 2].GetComponentInChildren<Text>().text == values[i] && Buttons[2, 2].GetComponentInChildren<Text>().text == values[i])
            {
                return true;
            }

            //colonne
        }


        return false;
    }

    public int ScoreGame(Button[,] Buttons)
    {
        for (int i = 0; i < values.Length; i++)
        {
            //ligne
            if (Buttons[0, 0].GetComponentInChildren<Text>().text == values[i] && Buttons[1, 0].GetComponentInChildren<Text>().text == values[i] && Buttons[2, 0].GetComponentInChildren<Text>().text == values[i])
            {
                if (values[i]=="O")
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }

            if (Buttons[0, 1].GetComponentInChildren<Text>().text == values[i] && Buttons[1, 1].GetComponentInChildren<Text>().text == values[i] && Buttons[2, 1].GetComponentInChildren<Text>().text == values[i])
            {
                if (values[i] == "O")
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }

            if (Buttons[0, 2].GetComponentInChildren<Text>().text == values[i] && Buttons[1, 2].GetComponentInChildren<Text>().text == values[i] && Buttons[2, 2].GetComponentInChildren<Text>().text == values[i])
            {
                if (values[i] == "O")
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }

            //colonne
        }


        return 0;
    }

    public int CompleteArray(Button[,] Array, int recursionNb, bool botplay, List<string> historique)
    {
        Debug.Log("StartCompleteArray" + " recursion=" + recursionNb);
        



        string symbol;
        if (botplay)
        {
            symbol = "O";
        }
        else
        {
            symbol = "X";
        }

        if (recursionNb==0)
        {
            Debug.Log("Score "+ScoreGame(Array));
            for (int i = 0; i < historique.Count; i++)
            {
                Debug.Log("Historique " +historique[i]);
            }
            return ScoreGame(Array);

        }
        else
        {
            if (Array[0, 0].GetComponentInChildren<Text>().text == "")//si c'est libre 
            {
                
                Array[0, 0].GetComponentInChildren<Text>().text = symbol; // je joue
                Debug.Log("Play on  0 0" + " by bot? " + botplay + " recursion="+recursionNb);
                historique.Add("0,0");

                CompleteArray(Array, recursionNb - 1, !botplay, historique);
                Array[0, 0].GetComponentInChildren<Text>().text = "";
                historique.RemoveAt(historique.Count);
            }
            if (Array[1, 0].GetComponentInChildren<Text>().text == "")
            {
                
                Array[1, 0].GetComponentInChildren<Text>().text = symbol;
                Debug.Log("Play on  1 0" + " by bot? " + botplay + " recursion=" + recursionNb);

                historique.Add("1,0");
                CompleteArray(Array, recursionNb - 1, !botplay, historique);
                Array[1, 0].GetComponentInChildren<Text>().text = "";
                historique.RemoveAt(historique.Count);

            }
            if (Array[2, 0].GetComponentInChildren<Text>().text == "")
            {
                
                Array[2, 0].GetComponentInChildren<Text>().text = symbol;
                Debug.Log("Play on  2 0" + " by bot? " + botplay + " recursion=" + recursionNb);
                historique.Add("2,0");
                CompleteArray(Array, recursionNb - 1, !botplay, historique);
                Array[2, 0].GetComponentInChildren<Text>().text = "";
                historique.RemoveAt(historique.Count);

            }
            if (Array[0, 1].GetComponentInChildren<Text>().text == "")
            {
                
                Array[0, 1].GetComponentInChildren<Text>().text = symbol;
                Debug.Log("Play on  0 1" + " by bot? " + botplay + " recursion=" + recursionNb);
                historique.Add("0,1");
                CompleteArray(Array, recursionNb - 1, !botplay, historique);
                Array[0, 1].GetComponentInChildren<Text>().text = "";
                historique.RemoveAt(historique.Count);

            }
            if (Array[1, 1].GetComponentInChildren<Text>().text== "")
            {
                
                Array[1, 1].GetComponentInChildren<Text>().text = symbol;
                Debug.Log("Play on  1 1" + " by bot? " + botplay + " recursion=" + recursionNb);
                historique.Add("1,1");
                CompleteArray(Array, recursionNb - 1, !botplay, historique);
                Array[1, 1].GetComponentInChildren<Text>().text = "";
                historique.removeat(historique.count);

            }
            if (Array[2, 1].GetComponentInChildren<Text>().text == "")
            {
                
                Array[2, 1].GetComponentInChildren<Text>().text = symbol;
                Debug.Log("Play on  2 1" + " by bot? " + botplay + " recursion=" + recursionNb);
                historique.Add("2,1");
                CompleteArray(Array, recursionNb - 1, !botplay, historique);
                Array[2, 1].GetComponentInChildren<Text>().text = "";
                if (historique.Count > 0)
                {
                    historique.RemoveAt(historique.Count);
                }
                

            }
            if (Array[0, 2].GetComponentInChildren<Text>().text == "")
            {
                
                Array[0, 2].GetComponentInChildren<Text>().text = symbol;
                Debug.Log("Play on  0 2" + " by bot? " + botplay + " recursion=" + recursionNb);
                historique.Add("0,2");
                CompleteArray(Array, recursionNb - 1, !botplay, historique);
                Array[0, 2].GetComponentInChildren<Text>().text = "";
                if (historique.Count > 0)
                {
                    historique.RemoveAt(historique.Count);
                }

            }
            if (Array[1, 2].GetComponentInChildren<Text>().text == "")
            {
                
                Array[1, 2].GetComponentInChildren<Text>().text = symbol;
                Debug.Log("Play on  1 2" + " by bot? " + botplay + " recursion=" + recursionNb);
                historique.Add("1,2");
                CompleteArray(Array, recursionNb - 1, !botplay, historique);
                Array[1, 2].GetComponentInChildren<Text>().text = "";
                if (historique.Count > 0)
                {
                    historique.RemoveAt(historique.Count);
                }

            }
            if (Array[2, 2].GetComponentInChildren<Text>().text == "")
            {
                
                Array[2, 2].GetComponentInChildren<Text>().text = symbol;
                Debug.Log("Play on  2 2" + " by bot? " + botplay + " recursion=" + recursionNb);
                historique.Add("2,2");
                CompleteArray(Array, recursionNb - 1, !botplay, historique);
                Array[2, 2].GetComponentInChildren<Text>().text = "";
                if (historique.Count>0)
                {
                    historique.RemoveAt(historique.Count);
                }

            }

        }

        Debug.Log("return -100");
        return -100;






        
    }
        

        
    










}
