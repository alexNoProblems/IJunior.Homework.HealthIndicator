using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class HealButton : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private int _heal = 10;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(ApplyHeal);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ApplyHeal);
    }

    private void ApplyHeal()
    {
        _health.Heal(_heal);
    }
}
