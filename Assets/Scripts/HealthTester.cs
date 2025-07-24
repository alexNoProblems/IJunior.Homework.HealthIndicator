using UnityEngine;

public class HealthTester : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private int _damage = 10;
    [SerializeField] private int _heal = 10;

    public void ApplyDamage()
    {
        _health.TakeDamage(_damage);
    }

    public void ApplyHeal()
    {
        _health.Heal(_heal);
    }
}
