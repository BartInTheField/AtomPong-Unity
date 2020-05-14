using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using EZCameraShake;
using UnityAtoms;

[CreateAssetMenu(menuName = "Unity Atoms/Camera/Actions/ShakeOnce")]
public class ShakeOnceAction : AtomAction
{
    [SerializeField] private float magnitude = 1f;
    [SerializeField] private float roughness = 1f;
    [SerializeField] private float fadeInTime = 0;
    [SerializeField] private float fadeOutTime = 1f;

    public override void Do()
    {
        CameraShaker.Instance.ShakeOnce(magnitude, roughness, fadeInTime, fadeOutTime);
    }
}
