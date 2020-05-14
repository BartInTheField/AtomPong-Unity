using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

[CreateAssetMenu(menuName = "Unity Atoms/Goal/Actions/RespawnBall")]
public class RespawnBallAction : Collider2DAction
{
    [SerializeField] private Vector2Event onBallNeedRespawn;
    [SerializeField] private Vector2 spawnMove;
    
    public override void Do(Collider2D collider)
    {
        if(!collider)
            return;
        
        if (collider.CompareTag("Ball"))
        {
            onBallNeedRespawn.Raise(spawnMove);
        }
    }
}
