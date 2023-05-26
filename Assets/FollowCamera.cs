using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // Start is called before the first frame update
    void LateUpdate() {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10f);
    }
}
