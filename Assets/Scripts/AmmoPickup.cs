using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] int ammoAmount = 5;
    [SerializeField] AmmoType ammoType;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            var playerAmmo = other.GetComponent<Ammo>();
            playerAmmo.IncreaseCurrentAmmo(ammoType, ammoAmount);
            Destroy(gameObject);
        }    
    }
}
