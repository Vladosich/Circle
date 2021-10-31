using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation : MonoBehaviour
{
    [SerializeField] GameObject CenterCircle;
    bool direction = false;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(!direction)
            CenterCircle.transform.Rotate(0, 0, 3);
        else
            CenterCircle.transform.Rotate(0, 0, -3);
    }
    public void ChangeDirection()
    {
        direction = !direction;
    }

}
