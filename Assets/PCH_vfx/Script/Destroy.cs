using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour

{
    public float TimeToDestroy;
    void Start()
    {
      DestroyMe(TimeToDestroy);
    }

    // Update is called once per frame
    void DestroyMe(float DestroyMeTime)
    {
        Destroy(gameObject,DestroyMeTime);
    }
}
