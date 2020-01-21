using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour {

    public Canvas loadCanvas;
    public string nextScene;

    private readonly float delayTime = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(LoadNextScene());
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(LoadNextScene());
        }
    }

    private IEnumerator LoadNextScene(){
        Instantiate(loadCanvas);
        yield return new WaitForSecondsRealtime(delayTime);
        SceneManager.LoadScene(nextScene);
    }
}
