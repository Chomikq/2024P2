using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
  public void TriggerHitAnimation()
  {
    GetComponent<Animator>().SetTrigger("Hit");
  } 
}
