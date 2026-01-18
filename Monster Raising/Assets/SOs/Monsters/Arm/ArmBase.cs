using UnityEngine;

[CreateAssetMenu(fileName = "ArmBase", menuName = "Scriptable Objects/Parts/Arm")]
public abstract class ArmBase : ScriptableObject, IAttack
{
    public float attackDamage;
    public abstract void PerformAttack(GameObject me);
   
}
