using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceshipController : MonoBehaviour
{
    Rigidbody2D rgbody;
    //Vector3 rotate;
    public float speed;
    public float torque;
    public float limit;

    public GameObject bulletPrefab;
    public Transform bulletSpawnpoint;
    public float cooldown = 0.25f;
    public float bulletThrust;

    Animator shipAnimator;

    public AudioSource pew;

    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody2D>();
        shipAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //bulletSpawnpoint.transform.rotation = gameObject.transform.rotation;

        if ((Input.GetKeyDown(KeyCode.Q) || (Input.GetKeyDown(KeyCode.E)) && rgbody.angularVelocity != 0))
        {
            rgbody.angularVelocity = 0;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
            rgbody.AddTorque(torque * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            
            transform.Rotate(Vector3.back * speed * Time.deltaTime);
            rgbody.AddTorque(-torque * Time.deltaTime);
        }

        /* if (Input.GetKey(KeyCode.W))
        {
            rgbody.angularVelocity = 0;
        } */


        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
        else
        {
            cooldown = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space) && cooldown == 0)
        {
            pew.Play();
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnpoint.position, bulletSpawnpoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce((bulletSpawnpoint.transform.up).normalized * bulletThrust, ForceMode2D.Impulse);
            cooldown = 0.25f;
        }
        

        if (rgbody.angularVelocity > limit) rgbody.angularVelocity = limit;
        if (rgbody.angularVelocity < -limit) rgbody.angularVelocity = -limit;
    }
}
