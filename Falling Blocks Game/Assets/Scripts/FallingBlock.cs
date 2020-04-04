using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour
{
    public Vector2 speedMinMax;
    float speed;

    float visibleHeightthreshold;

     void Start()
    {
        speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, Difficulty.GetDifficultyPercent());

        visibleHeightthreshold = -Camera.main.orthographicSize - transform.localScale.y;
    }
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.Self);
    
        if(transform.position.y < visibleHeightthreshold)
        {
            Destroy(gameObject);
        }
    }
}
