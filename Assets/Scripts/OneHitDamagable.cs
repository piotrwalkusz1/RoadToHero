using UltEvents;
using UnityEngine;

public class OneHitDamagable : Damagable
{
    public UltEvent onDamageDeal;

    private bool damageAlreadyDealt = false;

    public override void dealDamage()
    {
        if (!damageAlreadyDealt)
        {
            damageAlreadyDealt = true;
            onDamageDeal.Invoke();
        }
    }
}
