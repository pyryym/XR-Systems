using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int speed = 10;
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, speed * Time.deltaTime);
    }
}
