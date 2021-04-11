using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject Bullet;
    private float moving_speed = 10.0f;
    private float rot_speed = 50.0f;

    private void PlayerMovingControl()
    {
        float keyHorizontal = Input.GetAxis("Horizontal");
        float keyVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * this.moving_speed*Time.smoothDeltaTime*keyHorizontal, Space.World);
        transform.Translate(Vector3.up * this.moving_speed * Time.smoothDeltaTime * keyVertical, Space.World);

    }

    private void PlayerRotate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * this.rot_speed * Time.deltaTime;
        v = v * this.rot_speed * Time.deltaTime;

        transform.Rotate(Vector3.back * h);
        transform.Rotate(Vector3.back*v);
    }

    void shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))        {            Debug.Log("space pressed");            Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);        }
    }

    void Start()
    {
        Debug.Log("HelloWorld");

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovingControl();
        PlayerRotate();
        shoot();
    }
}
