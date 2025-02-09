using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeActivator : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite bridgeActivated;
    [SerializeField] private GameObject bridgeOff;
    [SerializeField] private GameObject bridgeOn;
    [SerializeField] private float activateCooldown = 1f;
    private bool bridge = false;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnTriggerEnter2D (Collider2D obj) {
        if ((obj.gameObject.tag == "Player") && (!bridge)) {
            spriteRenderer.color = new Color(255,0,0,255);
            Invoke("ActivateBridge",activateCooldown);
        }
    }

    void ActivateBridge() {
        spriteRenderer.color = new Color(255,255,255,255);
        spriteRenderer.sprite = bridgeActivated;
        bridgeOff.SetActive(false);
        bridgeOn.SetActive(true);
        bridge = true;
    }
}
