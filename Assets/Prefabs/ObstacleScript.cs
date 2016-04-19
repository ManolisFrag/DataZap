using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour
{
    public float objectSpeed = -0.05f;

    void Update()
    {
        transform.Translate(0, objectSpeed, 0);
    }
}