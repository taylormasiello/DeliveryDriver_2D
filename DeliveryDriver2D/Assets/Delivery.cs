using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage; // fasle is default bool
    
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
       // if (the thing we trigger is the package)
       // then pring "package picked up" to console
       if (other.tag == "Package")
        {
            Debug.Log("Package Picked Up!");
            hasPackage = true;
        }

       if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Delilvered Package!");
            hasPackage = false;
        }
    }
}
