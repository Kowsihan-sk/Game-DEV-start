using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGame : MonoBehaviour
{
    float roundStartDelayTime = 3;
    float roundStartTime;
    int waitTime;
    bool roundStarted;

    // Start is called before the first frame update
    void Start()
    {
        print("Press SpaceBar once you think the alloted time is up.");
        Invoke("SetNewRandomTime", roundStartDelayTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && roundStarted)
        {
            InputRecieved();
        }
    }

    void InputRecieved()
    {
        roundStarted = false;
        float playerWaitTime = Time.time - roundStartTime;
        float error = Mathf.Abs(waitTime - playerWaitTime);

        
        print("You waited for " + playerWaitTime + " seconds. That's " + error + " seconds off. " + GenerateMessage(error));
        Invoke("SetNewRandomTime", roundStartDelayTime);
    }

    string GenerateMessage(float error)
    {
        string message = "";
        if (error < .15f)
        {
            message = "Outstanding!";
        }
        else if (error < .75f)
        {
            message = "Exceeds Expectation.";
        }
        else if (error < 1.25f)
        {
            message = "Acceptable.";
        }
        else if (error < 1.75f)
        {
            message = "Bad.";
        }
        else
        {
            message = "Dreadful.";
        }

        return message;
    }

    void SetNewRandomTime()
    {
        waitTime = Random.Range(5, 21);
        roundStartTime = Time.time;
        roundStarted = true;

        print(waitTime + " seconds.");
    }
}
