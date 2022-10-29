using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;

    public int maxHealth, currentHealth;

    public float invincibleTime = 1f;
    private float invincibleCount;

    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        currentHealth = maxHealth;

        UIController.instance.healthBar.maxValue = maxHealth;
        UIController.instance.healthBar.value = currentHealth;
        UIController.instance.healthText.text = "HEALTH: " + currentHealth + "/" + maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (invincibleCount > 0)
        {
            invincibleCount -= Time.deltaTime;
        }
    }

    public void DamagePlayer(int damageAmount)
    {
        if (invincibleCount <= 0)
        {

            currentHealth -= damageAmount;


            if (currentHealth <= 0)
            {
                gameObject.SetActive(false);

                currentHealth = 0;


            }

            invincibleCount = invincibleTime;

            UIController.instance.healthBar.value = currentHealth;
        }
    }
}