using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame, LateUpdate later in the frame, after the vehicle has moved
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
