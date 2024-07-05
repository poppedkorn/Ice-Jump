
using UnityEngine;

public class health : MonoBehaviour
{
    [SerializeField]private float startHealth;
    public float currentHealth { get; private set; }


    private void Awake()
    {
        currentHealth = startHealth;
    }
    public void TakeDamage(float _damage)
    {
        Mathf.Clamp(currentHealth - _damage, 0, startHealth);
        if (currentHealth > 0)
        {
            //player hurt
        } else
        {
            //player dead
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
            TakeDamage(1);
    }
}
