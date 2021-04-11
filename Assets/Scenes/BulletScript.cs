using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private float z_pos = 0f;

    // Start is called before the first frame update
    void Start()
    {
        z_pos = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        z_pos += 0.2f;
        transform.Translate(0.0f,0.0f,z_pos*Time.deltaTime);

        if (z_pos > 80.0f)
        {
            Destroy(gameObject, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject, 0);
            Destroy(other.gameObject, 0);
        }

        
    }
}
