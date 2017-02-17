using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int sprintMultiplier = 10;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprintMultiplier = +10;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * sprintMultiplier * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * sprintMultiplier * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * sprintMultiplier * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * sprintMultiplier * Time.deltaTime, Space.World);
        }
    }
}
