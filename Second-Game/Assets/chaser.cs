using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaser : MonoBehaviour
{
    public Transform targetTransform;
    public float speed = 7;
    
    void Update()
    {
        Vector3 displacementFromTarget = targetTransform.position - transform.position;
        Vector3 directionToTarget = displacementFromTarget.normalized;
        Vector3 velocity = speed * directionToTarget;

        float distanceToTarget = displacementFromTarget.magnitude;

        if(distanceToTarget > 1.5f)
        {
            transform.Translate(velocity * Time.deltaTime);
        }
    }
}
