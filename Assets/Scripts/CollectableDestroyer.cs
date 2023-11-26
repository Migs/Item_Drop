using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableDestroyer : MonoBehaviour
{
    private float _liveTime = 3.5f;

    // Update is called once per frame
    void Update()
    {
        if(_liveTime <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            _liveTime -= Time.deltaTime;
        }
    }
}
