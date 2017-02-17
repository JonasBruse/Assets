using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    public GameObject PortalProjectile1;
    Vector2 mousePos;
    Vector2 playerPos;
    float despawnS = 3f;
    //dir = direction
    float timerStart = 0f;
    float timerStop = 0.5f;
    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        playerPos = gameObject.transform.position;
        Vector2 dir = (mousePos - playerPos).normalized;
        float rot = Mathf.Atan2(dir.y, dir.x);
        transform.localRotation = Quaternion.AngleAxis(rot * Mathf.Rad2Deg, Vector3.forward);

        if (Input.GetKey(KeyCode.Space) && Time.time > timerStart + timerStop)
        {
            timerStart = Time.time;
                GameObject bulletShot = Instantiate(PortalProjectile1, transform.localPosition, transform.localRotation * Quaternion.identity) as GameObject;
                bulletShot.GetComponent<BulletScript>().dir = dir;
                bulletShot.GetComponent<BulletScript>().rot = rot;
                Destroy(bulletShot, despawnS);
            
        }
    }
}
