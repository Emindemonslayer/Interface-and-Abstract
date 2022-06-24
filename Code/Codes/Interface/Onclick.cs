using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onclick : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitinfo;
            if(Physics.Raycast(ray,out hitinfo))
            {
                IInteractable interact = hitinfo.collider.GetComponent<IInteractable>();

                if(interact != null)
                {
                    interact.Interact();
                } 
            }
        }
    }
}
