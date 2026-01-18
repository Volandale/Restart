using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName = "LegBase", menuName = "Scriptable Objects/Parts/Leg")]
public abstract class LegBase : ScriptableObject, IMove
{
    public float moveSpeed;
    public abstract void PerformMovement(GameObject me);
}
