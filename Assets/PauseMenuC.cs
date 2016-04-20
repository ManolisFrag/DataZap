using UnityEngine;
using System.Collections;

public class PauseMenuC : MonoBehaviour {

    public bool isPaused;
    public GameObject Canvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if (isPaused)
        {
            Canvas.SetActive(true);
            Time.timeScale = 0f;
        } else
        {
            Canvas.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            isPaused = !isPaused;
        }
	}

    public void Resume()
    {
        isPaused = false;

    }
}
