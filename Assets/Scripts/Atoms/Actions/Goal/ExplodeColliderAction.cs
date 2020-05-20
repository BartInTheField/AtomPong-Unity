using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

[CreateAssetMenu(menuName = "Unity Atoms/Generic/Actions/Explode Collider")]
public class ExplodeColliderAction : Collider2DAction
{
    [SerializeField] private GameObject explosionObject;
    
    public override void Do(Collider2D collider)
    {
        if (collider.CompareTag("Ball"))
        {
            Instantiate(explosionObject, collider.transform.position, Quaternion.identity);
        }
    }
}
