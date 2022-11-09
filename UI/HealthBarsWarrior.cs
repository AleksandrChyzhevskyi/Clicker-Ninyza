using UnityEngine.UI;
using UnityEngine;

public class HealthBarsWarrior : MonoBehaviour
{
    [SerializeField] private Warrior _warrior;
    [SerializeField] private Image _bar;

    private void OnEnable()
    {
        _warrior.UpdateCurrantHealth(OnHealthChenged()* -1);
    }
    private void OnDisable()
    {
        _warrior.UpdateCurrantHealth(OnHealthChenged()* -1);
    }
    private float OnHealthChenged()
    {
       return _bar.fillAmount = Mathf.InverseLerp(0, _warrior.MaxHealth, _warrior.Health);
    }
}
