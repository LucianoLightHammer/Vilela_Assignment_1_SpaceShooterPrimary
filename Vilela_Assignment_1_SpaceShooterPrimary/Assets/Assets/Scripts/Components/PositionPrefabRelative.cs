using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionPrefabRelative : MonoBehaviour
{
    public GameObject Prefab;
    public Vector3 SpawnOffset;

    /// <summary>
    /// Instantiates the game object stored in the variable Prefab at SpawnOffset distance away from the player. The object is a 
    /// root object.
    /// </summary>
    /// <returns>the newly spawned object int he right position.</returns>
    public GameObject PositionPrefabAtRelativePosition()
    {
        SpawnOffset = transform.position + new Vector3(5.0f, 0.0f);
        Instantiate(Prefab, SpawnOffset, Quaternion.identity);
        return null;
    }
    
}
