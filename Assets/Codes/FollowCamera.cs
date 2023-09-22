using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject FollowingCamera;
    void LateUpdate()
    {
        transform.position = FollowingCamera.transform.position + new Vector3(0, 0, -10);
    }
}
