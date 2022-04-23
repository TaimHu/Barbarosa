using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private HealthSystem healthSystem;

    public void Setup(HealthSystem healthSystem) {
        this.healthSystem = healthSystem;
    }

    private void Update()
    {
        Transform x = transform.Find("Bar");
        x.localScale = new Vector3(healthSystem.getHealthPercent(), 0.0099f, 0.2f);
        if(healthSystem.getHealthPercent() == 0)
        Destroy(gameObject.transform.parent.gameObject);
    }
}
