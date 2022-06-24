using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveABS : ScriptableObject
{
    public abstract void MoveGo(MoveInput move,Vector3 yon);
    public abstract void JumpGo(JumpInput jump, Vector3 yon);
}
