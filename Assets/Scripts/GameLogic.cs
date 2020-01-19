using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

    public int coinsToWin = 10;
    public GameObject levelExit;
    public HudUI hudUi;

    static private int coins;

	// Use this for initialization
	void OnEnable () {
        if (levelExit != null)
        {
            levelExit.SetActive(false);
        }
        coins = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (hudUi != null)
        {
            hudUi.SetCoinCount(coins);
        }
        if(coins >= coinsToWin)
        {
            if (levelExit != null)
            {
                levelExit.SetActive(true);
            }
            if (hudUi != null)
            {
                hudUi.SetReadyToExit(true);
            }
        }
	}

    public static void CoinPickup()
    {
        coins++;
    }
}
