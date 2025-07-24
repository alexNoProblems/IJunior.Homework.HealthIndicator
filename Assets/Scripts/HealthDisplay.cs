using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private Slider _healthSlider;
    [SerializeField] private Slider _smoothHealthSlider;
    [SerializeField] private float _smoothSpeed = 50f;

    private void OnEnable()
    {
        _health.Damaged += UpdateUI;
        _health.Healed += UpdateUI;
        _health.Died += UpdateUI;
    }

    private void Start()
    {
        _healthSlider.maxValue = _health.MaxHealth;
        _smoothHealthSlider.maxValue = _health.MaxHealth;
        UpdateUI();
    }

    private void Update()
    {
        _smoothHealthSlider.value = Mathf.MoveTowards(_smoothHealthSlider.value, _health.CurrentHealth, _smoothSpeed * Time.deltaTime);
    }

    private void OnDisable()
    {
        _health.Damaged -= UpdateUI;
        _health.Healed -= UpdateUI;
        _health.Died -= UpdateUI;
    }

    private void UpdateUI()
    {
        _healthText.text = $"{_health.CurrentHealth} / {_health.MaxHealth}";
        _healthSlider.value = _health.CurrentHealth;
    }
}
