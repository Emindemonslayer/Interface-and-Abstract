using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//direkt bunu ekleyecek yoksa eger
[RequireComponent(typeof(Rigidbody))]
public class MoveInput : MonoBehaviour
{
    [SerializeField]
    ScriptType moveType;
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            moveType.MoveGo(this,Vector3.forward); 
        }
    }
}
