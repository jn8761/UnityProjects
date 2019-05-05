using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollowPlayer : MonoBehaviour
{
    public Vector3 offset;
    public Transform playerLocation;
    // Update is called once per frame
    void Update()
    {
        transform.position = playerLocation.position + offset;
    }
}
