using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class SetTextToInt : MonoBehaviour
{
    [SerializeField] private IntEvent doChangeTextOn;
    
    private TextMeshProUGUI textMesh;

    private void OnEnable()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        doChangeTextOn.Register(ChangeText);
        ChangeText(0);
    }

    private void OnDestroy()
    {
        doChangeTextOn.Unregister(ChangeText);
    }

    private void ChangeText(int value)
    {
        textMesh.SetText(value + "");
    }
}
