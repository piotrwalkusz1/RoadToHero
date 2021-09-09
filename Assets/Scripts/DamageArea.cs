using UnityEngine;

public class DamageArea : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Damagable damagable = other.GetComponent<Damagable>();
        if (damagable != null)
        {
            damagable.dealDamage();
        }
    }
}
