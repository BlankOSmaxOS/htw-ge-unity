using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab = null;
    [SerializeField] private int cubeSpawnAmount = 10;     
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log ("Hello World");
    } 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
                {
            this.SpawnXCubes(this.cubeSpawnAmount);
        }
    }        

private void SpawnXCubes(int amount)
{
    for (int i = 0; i < amount; i++)
    {
        GameObject.Instantiate(this.cubePrefab);
        }        
    }
}
