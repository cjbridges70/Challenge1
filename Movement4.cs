using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement4 : MonoBehaviour
{
    private Vector3 pos1 = new Vector3(-9, 1, 113);
    private Vector3 pos2 = new Vector3(2, 1, 113);
    public float speed = .25f;

    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
