using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GUISkin layout;
    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;
    GameObject disco;


    void OnGUI () {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + PlayerScore1);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + PlayerScore2);

        if (GUI.Button(new Rect(Screen.width / 2 - 60, 35, 120, 53), "RESTART"))
        {
            PlayerScore1 = 0;
            PlayerScore2 = 0;
            disco.SendMessage("RestartGame", 0.5f, SendMessageOptions.RequireReceiver);
        }

        if (PlayerScore1 == 10)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER ONE WINS");
            disco.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        } 
        else if (PlayerScore2 == 10)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER TWO WINS");
            disco.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
    }

    public static void Score (string wallID) {
        if (wallID == "RightGol")
        {
            PlayerScore1++;
        } else if(wallID == "LeftGol")
        {
            PlayerScore2++;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        disco = GameObject.FindWithTag("Disco");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
