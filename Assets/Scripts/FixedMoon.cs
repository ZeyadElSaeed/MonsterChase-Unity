using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedMoon : MonoBehaviour
{
    private Transform cam;
    private Vector3 temPos;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindWithTag("MainCamera").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        temPos = transform.position;
        temPos.x = cam.position.x - 7;
        temPos.y = cam.position.y + 3;

        transform.position = temPos;
    }
}
