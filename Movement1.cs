using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    private Vector3 pos1 = new Vector3(-6, 1, 5);
    private Vector3 pos2 = new Vector3(6, 1, 5);
    public float speed = .25f;

    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
