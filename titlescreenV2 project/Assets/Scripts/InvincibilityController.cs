using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibilityController : MonoBehaviour
{
    private HealthController _healthController;

    private void Awake()
    {
        _healthController = GetComponent<HealthController>();
    }
    public void StartInvincibility(float InvincibilityDuration)
    {
        StartCoroutine(InvincibilityCoroutine(InvincibilityDuration));
    }
    private IEnumerator InvincibilityCoroutine(float InvincibilityDuration)
    {
        _healthController.IsInvincible = true;
        yield return new WaitForSeconds(InvincibilityDuration);
        _healthController.IsInvincible = false;
    } 
}
