using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _collectables;

    private float _respawnTime;


    private void Start()
    {
        _respawnTime = Random.Range(3f, 10f);
    }

    void Update()
    {
        if(_respawnTime <= 0)
        {
            SpawnCollectable();
            _respawnTime = Random.Range(3f, 10f);
        }
        else
        {
            _respawnTime -= Time.deltaTime;
        }
    }

    private void SpawnCollectable()
    {
        int randomUnit = Random.Range(0, 2);

        Instantiate(_collectables[randomUnit], transform.position, transform.rotation);
    }
}
