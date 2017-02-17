using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    float speed = 3;
    public Vector2 dir;
    public float rot;
    public Rigidbody2D PortalProjectile1;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(dir * speed * speed * Time.deltaTime, Space.World);

	}
}
