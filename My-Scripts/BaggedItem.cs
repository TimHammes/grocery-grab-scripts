using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaggedItem : MonoBehaviour
{

  bool isBagged = false;
    void Start()
    {
        
    }

  private void OnTriggerEnter(Collider other)
  {
    if(other.gameObject.tag == "grocery-bag" && gameObject.GetComponent<OVRGrabbable>().isGrabbed == false)
    {
      isBagged = true;
      gameObject.transform.parent = other.transform;
      gameObject.GetComponent<Rigidbody>().drag = 7;
     
    }
  }

 
  void Update()
    {
        
    }
}
