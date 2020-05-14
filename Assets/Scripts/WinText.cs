using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class WinText : MonoBehaviour
{
    [SerializeField] private AtomEventBase doShowWinOn;
    [SerializeField] private IntVariable playerThatWon;
    [SerializeField] private string winText;

    private TextMeshProUGUI textMesh;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.enabled = false;
        
        doShowWinOn.Register(ShowWinner);
    }

    private void OnDestroy()
    {
        doShowWinOn.Unregister(ShowWinner);
    }

    private void ShowWinner()
    {
        textMesh.enabled = true;
        textMesh.SetText(winText, playerThatWon.Value);
    }
}
