using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitFlySpawner : MonoBehaviour
{
    
    public static int numberOfAdultFlies;


    public int numberOfAdults;
    public int numberOfFlies;

    public int weekNumber;

    private GameObject[] array;
    private GameObject[] array1;
    // Start is called before the first frame update
    void Start()
    {
        weekNumber = 0;
    }

    private void Update()
    {
        numberOfAdults = 0;
        numberOfFlies = 0;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        array = GameObject.FindGameObjectsWithTag("adult");
        array1 = GameObject.FindGameObjectsWithTag("fly");
  
        foreach (GameObject a in array)
        {
            numberOfAdults += 1;
            numberOfFlies += 1;
        }
        foreach (GameObject a in array1)
        {
            numberOfFlies += 1;

        }
       
        weekNumber += 1;
    }
}
