using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Type/Jump")]
public class JumpType : MoveABS
{
    public float JumpSpeed;
    public float Height;
    public ForceMode Modde;
    public override void JumpGo(JumpInput jump, Vector3 yon)
    {
        yon *= JumpSpeed;
        yon.y = Height;
        jump.GetComponent<Rigidbody>().AddForce(yon, Modde);
    }

    public override void MoveGo(MoveInput move, Vector3 yon)
    {

    }
}
