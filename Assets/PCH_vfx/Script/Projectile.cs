using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Projectille : MonoBehaviour
{
    public GameObject Impact;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Target")
        {
            other.GetComponent<Target>().TriggerHitAnimation();
            Instantiate(Impact,transform.position, quaternion.identity);
            Destroy(gameObject);
        }

    }
}
