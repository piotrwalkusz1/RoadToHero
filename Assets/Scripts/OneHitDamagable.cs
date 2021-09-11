using UnityEngine.Events;

public class OneHitDamagable : Damagable
{
    public UnityEvent onDamageDeal;

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
