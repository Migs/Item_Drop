using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _hazards;

    private float _respawnTime;


    private void Start()
    {
        _respawnTime = Random.Range(3f, 10f);
    }

    void Update()
    {
        if(_respawnTime <= 0)
        {
            SpawnHazard();
            _respawnTime = Random.Range(3f, 10f);
        }
        else
        {
            _respawnTime -= Time.deltaTime;
        }
    }

    private void SpawnHazard()
    {   
        int randomUnit = Random.Range(0, 2);

        Instantiate(_hazards[randomUnit], transform.position, transform.rotation);
    }
}
