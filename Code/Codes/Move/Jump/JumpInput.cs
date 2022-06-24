using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpInput : MonoBehaviour
{
    [SerializeField]
    JumpType jumpType;

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpType.JumpGo(this, Vector3.up);
        }
    }
}
