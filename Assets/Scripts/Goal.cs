using System;
using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private GameObjectPairEvent onBallHitGoal;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            onBallHitGoal.Raise(new GameObjectPair()
            {
                Item1 = this.gameObject,
                Item2 = other.gameObject
            });
        }
    }
}
