using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class CubeInterface : MonoBehaviour,IInteractable
{
    public void Interact()
    {
        Destroy(gameObject);
        print(gameObject.name);
    }
}
