using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitFly : MonoBehaviour
{
    public Vector2 EggPos, PupaPos, AdultPos, DeathPos;
    public int WeeksAlive;

    public GameObject flyPrefab;

    public bool isOG = false;

    public bool isEgg, isPupa, isAdult;
    // Start is called before the first frame update
    void Start()
    {
        //fruitFlySpawner.numberOfAdultFlies += 1;

        WeeksAlive = 0;

    }

    // Update is called once per frame
    void Update()
    {

        Mate();
        if (WeeksAlive == 0)
        {
            gameObject.tag = "fly";
            transform.position = EggPos;
            
        }
        if(WeeksAlive == 1)
        {
            gameObject.tag = "fly";

            transform.position = PupaPos;
         
        }
        if(WeeksAlive >= 2 && WeeksAlive < 8)
        {
            if(WeeksAlive == 2 || WeeksAlive == 3 || WeeksAlive == 4 || WeeksAlive == 5 || WeeksAlive == 6)
            {
                gameObject.tag = "adult";

            }
            transform.position = AdultPos;
           
        }
        if(WeeksAlive == 8)
        {
            //fruitFlySpawner.numberOfAdultFlies -= 1;

            Destroy(gameObject);
        }
        

        WeeksAlive += 1;
    }

    void Mate()
    {
        if (WeeksAlive >= 2 && WeeksAlive < 8)
        {
            for (int i = 0; i < 5; i++)
            {
                Instantiate(flyPrefab, EggPos, Quaternion.identity);
            }
        }
    }
}
