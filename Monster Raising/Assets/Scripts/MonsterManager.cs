using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class MonsterManager : MonoBehaviour
{
    [SerializeField] Tilemap t;
    [SerializeField] private MonsterBase monsterPrefab;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            Vector3Int cellPos = t.WorldToCell(mousePos);
            TileBase ctile = t.GetTile(cellPos);
            if (ctile != null)
            {
             
            }
        }
       
    }
}
