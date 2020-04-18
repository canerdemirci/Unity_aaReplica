using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatior : MonoBehaviour
{
    public float speed = 100f;
    public int level = 1;

    void Update()
    {
        transform.Rotate(0f, 0f, speed * level * Time.deltaTime);
    }
}
