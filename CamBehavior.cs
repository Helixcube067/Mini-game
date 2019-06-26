using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBehavior : MonoBehaviour {
    public Transform player;
    public Vector3 offset;
    public float speed;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
