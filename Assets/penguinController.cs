using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class penguinController : MonoBehaviour
{
    public Transform[] points;
    private int num;
    private float time = 1f;

    void Update()
    {
        time -= 1 * Time.deltaTime;
        num = Random.Range(1,3);
        if(time <= 0)
        {
            transform.position = points[num].position;
            time = 3.5f;
        }

    }
    
}
