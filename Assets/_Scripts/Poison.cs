using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            HealthManager.instance.ChangeHealth(1);
            ScoreManager.instance.scoreCalculation(HealthManager.instance.getHealth());
            Destroy(gameObject);
        }
    }
}
