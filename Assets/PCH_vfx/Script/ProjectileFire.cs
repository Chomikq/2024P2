using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ProjectileFire : MonoBehaviour
{
    public GameObject ProjectileFireLocation;
    public GameObject CastLocation;

    public float ProjectileSpeed;
    public float fireRate=0.5f;
    public float nextFireTime=0f;
    
    
    public GameObject ProjectilePrefab;
    public GameObject CastPrefab;
    
    private bool hasFired=false;


    // Update is called once per frame
    void Update()
    {    if(nextFireTime >0) //if there is a shoot cooldown...
          {
               nextFireTime-= Time.deltaTime;
               nextFireTime = Mathf.Max(nextFireTime,0);
               hasFired = false;
          }
         if(!hasFired && Input.GetKeyDown(KeyCode.Z))
        {
             GetComponent<Animator>().SetTrigger("Cast");
             GetComponent<Animator>().SetTrigger("FireProjectile");
             nextFireTime =0.1f; 
             hasFired= true;

        }  
     }
 
    void FireProjectileEvent()
    {   
        GameObject clone = Instantiate(ProjectilePrefab,ProjectileFireLocation.transform.position,Quaternion.identity);
        clone.GetComponent<Rigidbody>().velocity = gameObject.transform.forward * ProjectileSpeed;
        Instantiate(CastPrefab,CastLocation.transform.position,Quaternion.identity);

     }
    
}