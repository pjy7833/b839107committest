using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControllerScript : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Wall;
    private int counter;


    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        int a;
        ++counter;
        a = counter % 300;
        if (a == 1)
        {
            for (int i = 0; i < 5; i++)
            {
                float randomx = Random.Range(-5f, 5f);
                Instantiate(Enemy, new Vector3(randomx, 1.5f, 25f), Quaternion.identity);

            }

            for (int i = 0; i < 2; i++)
            {
                float randomx = Random.Range(-5f, 5f);
                Instantiate(Wall, new Vector3(randomx, 1.5f, 25f), Quaternion.identity);
            }
        }
    }
}
