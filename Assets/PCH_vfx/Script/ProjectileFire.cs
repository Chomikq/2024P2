using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ProjectileFire : MonoBehaviour
{
    public GameObject ProjectileFireLocation;
    public GameObject CastLocation;

    public float ProjectileSpeed;
    
    public GameObject ProjectilePrefab;
    public GameObject CastPrefab;


    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Z))
        {
             GetComponent<Animator>().SetTrigger("Cast");
             GetComponent<Animator>().SetTrigger("FireProjectile");
        }  
     }
 
    void FireProjectileEvent()
    {   
        GameObject clone = Instantiate(ProjectilePrefab,ProjectileFireLocation.transform.position,Quaternion.identity);
        clone.GetComponent<Rigidbody>().velocity = gameObject.transform.forward * ProjectileSpeed;
        Instantiate(CastPrefab,CastLocation.transform.position,Quaternion.identity);

     }
}