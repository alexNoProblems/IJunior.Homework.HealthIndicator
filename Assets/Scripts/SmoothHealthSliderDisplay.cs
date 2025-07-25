using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthSliderDisplay : HealthDisplayBase
{
    [SerializeField] private Slider _smoothHealthSlider;
    [SerializeField] private float _smoothSpeed = 50f;

    protected override void Start()
    {
        base.Start();
        _smoothHealthSlider.maxValue = _health.MaxHealth;
        _smoothHealthSlider.value = _health.CurrentHealth;
    }

    private void Update()
    {
        _smoothHealthSlider.value = Mathf.MoveTowards(_smoothHealthSlider.value, _health.CurrentHealth, _smoothSpeed * Time.deltaTime);
    }

    protected override void UpdateUI(){}
}
