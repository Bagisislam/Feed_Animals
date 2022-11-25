using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMenegerScript : MonoBehaviour
{
    public GameObject[] _SpawngameObjects;
    private float SpawnPosX = 19;
    private float SpawnposY = 30;
    private float StartDelay =2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMenegerMethod",StartDelay,spawnInterval );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnMenegerMethod()
    {
        Vector3 Spawnpos = new Vector3(Random.Range(-SpawnPosX, SpawnPosX), 0, SpawnposY);
        int randomSpawn = Random.Range(0, _SpawngameObjects.Length);
        Instantiate(_SpawngameObjects[randomSpawn], Spawnpos, _SpawngameObjects[randomSpawn].transform.rotation);
    }
}
