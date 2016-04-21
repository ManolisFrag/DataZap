using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

    
    public GameObject Canvas;
    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.name == "Finishline")
        {
            Application.LoadLevel("game");
        }
    }
}
