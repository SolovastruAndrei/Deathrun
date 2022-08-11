using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth = 200.0f;
    [SerializeField] private float currentHealth;
    [SerializeField] private float damagePerClick = 50.0f;
    private HealthBar _HealthBar;

    private void Awake()
    {
        this._HealthBar = this.GetComponentInChildren<HealthBar>();
        this.currentHealth = this.maxHealth;
        this.UpdateHealthBar();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(this.currentHealth>0)
            {
                this.currentHealth -= this.damagePerClick;
                this.UpdateHealthBar();
            }
            else
            {
                Destroy(gameObject);
            }

        }
        if (Input.GetButtonDown("Fire2"))
        {
            this.currentHealth = this.maxHealth;
            this.UpdateHealthBar();
        }
    }
    private void UpdateHealthBar()
    {
        float percentHealth = (this.currentHealth / this.maxHealth);
        this._HealthBar.UpdateHealhBarAmount(percentHealth);
    }
}
