using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

[CreateAssetMenu(menuName = "Unity Atoms/Generic/Actions/Explode GameObjectPair")]
public class ExplodeGameObjectPairAction : GameObjectPairAction
{
    [SerializeField] private GameObject explosionObject;
    
    public override void Do(GameObjectPair pair)
    {
        var object1 = pair.Item1;
        var object2 = pair.Item2;
        
        if (object1.CompareTag("Ball") || object2.CompareTag("Ball"))
        {
            Instantiate(explosionObject, object1.transform.position, Quaternion.identity);
        }
    }
}
