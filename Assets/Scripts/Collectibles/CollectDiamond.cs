using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectDiamond : MonoBehaviour
{
    public AudioSource coinFX;

    private void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        CollectibleControl.coinCount = CollectibleControl.coinCount + 5;
        this.gameObject.SetActive(false);

    }
}
