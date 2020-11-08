using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker_Score : MonoBehaviour
{
    public Transform Target;

    public Vector3 Offset;

    void LateUpdate()
    {
        transform.position = Target.position + Offset;
    }
}
