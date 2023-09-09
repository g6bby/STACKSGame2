using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbumCollider : MonoBehaviour
{
    public int expectedObjects = 20;
    public int objectsInZone = 0;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("snw") || other.CompareTag("pony") || other.CompareTag("mop") || other.CompareTag("tna") || other.CompareTag("facelift") 
        || other.CompareTag("fame") || other.CompareTag("btw") || other.CompareTag("let") || other.CompareTag("orange") || other.CompareTag("hoh") 
        || other.CompareTag("letgo") || other.CompareTag("flyleaf") || other.CompareTag("bne") || other.CompareTag("sp") || other.CompareTag("riot") 
        || other.CompareTag("awkif") || other.CompareTag("wcpgw") || other.CompareTag("sunburn") || other.CompareTag("soad") || other.CompareTag("loathe"))
        {
            objectsInZone++;
            CheckAllObjectsInZone();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("snw") || other.CompareTag("pony") || other.CompareTag("mop") || other.CompareTag("tna") || other.CompareTag("facelift") 
        || other.CompareTag("fame") || other.CompareTag("btw") || other.CompareTag("let") || other.CompareTag("orange") || other.CompareTag("hoh") 
        || other.CompareTag("letgo") || other.CompareTag("flyleaf") || other.CompareTag("bne") || other.CompareTag("sp") || other.CompareTag("riot") 
        || other.CompareTag("awkif") || other.CompareTag("wcpgw") || other.CompareTag("sunburn") || other.CompareTag("soad") || other.CompareTag("loathe"))
        {
            objectsInZone--;
            CheckAllObjectsInZone();
        }
    }

    private void CheckAllObjectsInZone()
    {
        if (objectsInZone == expectedObjects)
        {
            Debug.Log("All objects are in the trigger zone!");
        }
    }
}
