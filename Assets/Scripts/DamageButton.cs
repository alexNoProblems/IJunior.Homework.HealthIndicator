using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class DamageButton : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private int _damage = 10;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(ApplyDamage);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ApplyDamage);
    }

    private void ApplyDamage()
    {
        _health.TakeDamage(_damage);
    }
}
