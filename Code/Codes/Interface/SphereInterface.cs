using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class SphereInterface : MonoBehaviour,IInteractable
{
    public void Interact()
    {
        Destroy(gameObject);
        print(gameObject.name);
    }
}
