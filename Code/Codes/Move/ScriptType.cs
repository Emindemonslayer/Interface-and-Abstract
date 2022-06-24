using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Type")]
public class ScriptType : MoveABS
{
    public float MoveSpeed;

    public ForceMode Modde;

    public override void JumpGo(JumpInput jump, Vector3 yon)
    {
        
    }

    public override void MoveGo(MoveInput move, Vector3 yon)
    {
        move.GetComponent<Rigidbody>().AddForce(yon * MoveSpeed, Modde);
    }
}
