using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitFly1 : MonoBehaviour
{
    public Vector2 EggPos, PupaPos, AdultPos, DeathPos;
    public int WeeksAlive;

    public GameObject flyPrefab;


    public bool isEgg, isPupa, isAdult;
    // Start is called before the first frame update
    void Start()
    {
        fruitFlySpawner.numberOfAdultFlies += 1;

        WeeksAlive = 1;

    }

    // Update is called once per frame
    void Update()
    {
  

        if (WeeksAlive == 0)
        {
            transform.position = EggPos;
      
        }
        if(WeeksAlive == 1)
        {
          

            transform.position = PupaPos;
        
        }
        if(WeeksAlive >= 2 && WeeksAlive < 8)
        {

            gameObject.tag = "adult";
            transform.position = AdultPos;
         
        }
        if(WeeksAlive == 8)
        {
            fruitFlySpawner.numberOfAdultFlies -= 1;

            Destroy(gameObject);
        }
        Mate();

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
