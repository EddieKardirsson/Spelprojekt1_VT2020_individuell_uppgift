using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudUI : MonoBehaviour {

    public Text coinCount;
    public GameObject readyToExit;
    
	void OnEnable () {
        readyToExit.SetActive(false);
	}

    public void SetCoinCount(int count)
    {
        coinCount.text = count.ToString();
    }

    public void SetReadyToExit(bool ready)
    {
        readyToExit.SetActive(ready);
    }
}
