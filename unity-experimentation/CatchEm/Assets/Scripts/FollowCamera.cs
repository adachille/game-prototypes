using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject objectToFollow;

    void LateUpdate()
    {
        Vector3 objectPosition = objectToFollow.transform.position;
        transform.position = new Vector3(objectPosition.x, objectPosition.y, transform.position.z);        
    }
}
