using UnityEngine;
using System.Collections;

public class BombSpiral : MonoBehaviour
{
    public GameObject BombPrefab;
    [Range(5, 25)]
    public float SpiralAngleInDegrees = 10;
    public int BombCount = 10;
    public float StartRadius = 1;
    public float EndRadius = 3;

    /// <summary>
    /// Spawns spirals of BombPrefab game objects around the player. Create BombCount number of bombs 
    /// around the player, with each bomb being spaced SpiralAngleInDegrees apart from the next. The spiral 
    /// starts at StartRadius away from the player and ends at EndRadius away from the player.
    /// </summary>
    /// <returns>An array of the spawned bombs</returns>
    public GameObject[] SpawnBombSpiral()
    
    {
        //create array statement
        GameObject[] bombsArray = new GameObject[BombCount];
        
        for (int i = 0; i < BombCount; i++)

        {
            float radius = Quaternion.Lerp(StartRadius, EndRadius, Time / duration);
            Time += Time.deltaTime;
            yield retun null;
        }
        transform.rotation = endValue;
    }


}
