using UnityEngine;

public class DamageTypeExample : MonoBehaviour
{
    public enum DAMAGE_TYPE
    {
        SLASHING = 0,
        PIERCING = 1,
        BLUDGEONING = 2,
        MAGICAL = 3,
        FORCE = 4
    }

    public DAMAGE_TYPE attackType;
    public DAMAGE_TYPE resistance;
    public DAMAGE_TYPE weakness;

    public int baseDamage;

    void Start()
    {
        if (attackType == resistance)
        {
            baseDamage /= 2;
            Debug.Log($"Il nemico è resistente a questo tipo di attacco, danno di {baseDamage}");
        }

        if (attackType == weakness)
        {
            baseDamage *= 2;
            Debug.Log($"Il nemico è debole a questo tipo di attacco, danno di {baseDamage}");
        }

        Debug.Log("Danno inflitto: " + baseDamage);
    }
}
