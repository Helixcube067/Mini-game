using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intertwerp : MonoBehaviour
{
    public Transform player;
    public float speed;


    void FixedUpdate()
    {
        Vector3 targetDir = player.position - transform.position;
        float step = speed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
        Debug.DrawRay(transform.position, newDir, Color.red);
        transform.rotation = Quaternion.LookRotation(newDir);
        transform.position = Vector3.MoveTowards(transform.position, player.position, step);
    }
}