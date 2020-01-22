using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    public List<GameObject> objectsToShow;
    public List<GameObject> objectsToHide;
    public string tagName;
    public bool reverseOnExit;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag != tagName)
        {
            return;
        }

        foreach(GameObject obj in objectsToShow)
        {
            obj.SetActive(true);
        }

        foreach (GameObject obj in objectsToHide)
        {
            obj.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag != tagName)
        {
            return;
        }

        if (reverseOnExit)
        {
            foreach (GameObject obj in objectsToShow)
            {
                obj.SetActive(false);
            }

            foreach (GameObject obj in objectsToHide)
            {
                obj.SetActive(true);
            }
        }
    }
}
