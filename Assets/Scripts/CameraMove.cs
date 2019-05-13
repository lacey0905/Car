using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public GameObject target;

    void LateUpdate() 
    {
        Vector3 pos = new Vector3(target.transform.position.x, target.transform.position.y, -10f);
        transform.position = pos;
    }
}
