using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InspectRaycast : MonoBehaviour
{
    
    [SerializeField] private float rayLength = 1.5f;
    [SerializeField] private LayerMask PickupMask;
    

    public TMP_Text songName;
    
   // public Outline outlineScript;
    
    

    
   
    
    

    // Update is called once per frame
    void Start()
    {

    }
    void Update()
    {
        

        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        


        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, PickupMask.value))
        {
            //outlineScript.enabled = true;
            if(hit.collider.CompareTag("snw"))
            {
            songName.text = "Saturday Night Wrist";
            }

            if(hit.collider.CompareTag("pony"))
            {
                songName.text = "White Pony";
            }

            if(hit.collider.CompareTag("mop"))
            {
                songName.text = "Master of Puppets";
            }
        }
            
        else
        {
            //outlineScript.enabled = false;
            songName.text = "";
            //songName.SetActive(false);

        }
        
    
    
       


            
        
    }

    
    

    

    
    
}

