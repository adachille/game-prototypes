using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public class GibbitCollection : MonoBehaviour
{
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);
    [SerializeField] Color32 hasPackageColor = new Color32(236, 61, 162, 255);

    bool hasPackage = false;
    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = noPackageColor;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        switch(collider.gameObject.tag)
        {
            case "Gibbit":
                handlePackageTouched(collider.gameObject);
                break;
            case "UnpackingZone":
                handlePackingZoneTouched();
                break;
        }
        Debug.Log(hasPackage);
    }

    void handlePackageTouched(GameObject gameObject) {
        if (!hasPackage) {
            Debug.Log("Packed Em!");
            Destroy(gameObject, 0.1f);
            spriteRenderer.color = hasPackageColor;
            hasPackage = true;
        } else {
            Debug.Log("Already have a package!");
        }
    }

    void handlePackingZoneTouched()
    {
        if (hasPackage)
        {
            Debug.Log("Unpacked Em!");
            spriteRenderer.color = noPackageColor;
            hasPackage = false;
        }
        else
        {
            Debug.Log("No package to deliver!");
        }
    }
}
