using UnityEngine;
using UnityEngine.Tilemaps;

public class MonsterController : MonoBehaviour
{
     Tilemap T;

    void Update()
    {
       
    }
    public void MonsterSetup(MonsterBase data, Tilemap map)
    {
        
        T = map;
    }
}
