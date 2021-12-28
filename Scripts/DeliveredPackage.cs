using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveredPackage : MonoBehaviour
{   
    //all variables 
    [SerializeField] public Sprite dbyi_carWithPackage;
    [SerializeField] public Sprite normalCar;
    [SerializeField] Color32 hasPackageColor = new Color32 (255, 198, 143, 255);
    [SerializeField] Color32 noPackageColor = new Color32 (255, 255, 255, 255);
    [SerializeField] float PickupDelay;
    bool hasPackage = false;  
    SpriteRenderer spriteRenderer;
    

    void Start() 
    {   //will declare the state of hasPackage
        Debug.Log("hasPackage = " + hasPackage);
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

  


    void OnTriggerEnter2D(Collider2D other) 
    {
        //picks up package
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            spriteRenderer.sprite = dbyi_carWithPackage;
            Destroy(other.gameObject, PickupDelay);
        }

        //delivers the package only with a package in inventory
        if (other.tag == "Deliverspot" && hasPackage)
        {

            Debug.Log("Package delivered");
            spriteRenderer.color = noPackageColor;
            spriteRenderer.sprite = normalCar;
            hasPackage = false;
        }

    }  

}