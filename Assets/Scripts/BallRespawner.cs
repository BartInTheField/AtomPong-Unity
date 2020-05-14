using System;
using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

[RequireComponent(typeof(BallMovement))]
public class BallRespawner : MonoBehaviour
{
    [SerializeField] private Vector2Event doRespawnOn;
    [SerializeField] private Vector2 location;
    [SerializeField] private float respawnDelay;

    private BallMovement movement;
    
    private void Start()
    {
        movement = GetComponent<BallMovement>();
        
        doRespawnOn.Register(OnRespawn);
    }

    private void OnDestroy()
    {
        doRespawnOn.Unregister(OnRespawn);
    }

    private void OnRespawn(Vector2 direction)
    {
        StartCoroutine(AwaitRespawn(direction));
    }

    private IEnumerator AwaitRespawn(Vector2 direction)
    {
        yield return new WaitForSeconds(respawnDelay);
        Respawn(direction);
    }
    
    private void Respawn(Vector2 direction)
    {
        movement.Go(new Vector2(0,0));

        transform.position = location;
        
        movement.Go(direction);
    }
}
