using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class Enemy : Warrior
{
    private const float Deley = 2f;

    public event Action AttackAnimated;

    private void Start()
    {
       StartCoroutine(Attacking());
    }
    private IEnumerator Attacking()
    {
        var waitForSecond = new WaitForSeconds(Deley);

        while(IsAlive && _target.IsAlive)
        {
            yield return waitForSecond;
            AttackAnimated?.Invoke();   
        }
    }
}
