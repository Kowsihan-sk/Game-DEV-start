using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGame : MonoBehaviour
{
    float roundStartTime;
    int waitTime;

    // Start is called before the first frame update
    void Start()
    {
        print("Press SpaceBar once you think the alloted time is up.");
        SetNewRandomTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float playerWaitTime = Time.time - roundStartTime;
            float error = Mathf.Abs(waitTime - playerWaitTime);

            print("You waited for " + playerWaitTime + " seconds. That's " + error + " seconds off.");
            SetNewRandomTime();
        }
    }

    void SetNewRandomTime()
    {
        waitTime = Random.Range(5, 21);
        roundStartTime = Time.time;

        print(waitTime + " seconds.");
    }
}
