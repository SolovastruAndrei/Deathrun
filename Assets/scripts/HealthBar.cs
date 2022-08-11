using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image healthImage;
    public void UpdateHealhBarAmount(float percentHealth)
    {
        this.healthImage.fillAmount = percentHealth;
    }
}
