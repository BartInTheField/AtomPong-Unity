using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;


[CreateAssetMenu(menuName = "Unity Atoms/Goal/Actions/AddScore")]
public class AddScoreAction : Collider2DAction
{
    [SerializeField] private IntVariable score;
    
    public override void Do(Collider2D collider)
    {
        if(!collider)
            return;
        
        if (collider.CompareTag("Ball"))
        {
            score.Value++;
        }
    }
}
