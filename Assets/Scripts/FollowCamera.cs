using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField]
    private float minX, maxX;

    private Transform player;
    private Vector3 temPos;
    // Start is called before the first frame update
    void Start()
    {
        minX = -55f;
        maxX = 55f;
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

        if (!player)
            return;

        temPos = transform.position;
        temPos.x = player.position.x;

        if ( temPos.x > maxX )
        {
            temPos.x = maxX;
        }
        if ( temPos.x < minX)
        {
            temPos.x = minX;
        }
        transform.position = temPos;

        
        
    }
}
