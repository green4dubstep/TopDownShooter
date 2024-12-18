using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable 
{
    void TakeDamage(int damage);
    void Heal(int heal);
    void Die();
}