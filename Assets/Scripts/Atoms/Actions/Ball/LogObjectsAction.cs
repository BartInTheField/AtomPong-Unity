using UnityAtoms.BaseAtoms;
using UnityEngine;

[CreateAssetMenu(menuName = "Unity Atoms/Ball/Actions/LogObjects")]
public class LogObjectsAction : GameObjectPairAction
{
    public override void Do(GameObjectPair gameObjectPair)
    {
        Debug.Log(gameObjectPair.Item1.name);
        Debug.Log(gameObjectPair.Item2.name);
    }
}