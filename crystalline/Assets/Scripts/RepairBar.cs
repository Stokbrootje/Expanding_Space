using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RepairBar : MonoBehaviour
{
    public GameObject repairedShip;
    public GameObject brokenShip;
    public Slider slider;
    public pickUp pickUp;

    public float progress;
    public float maxProgress;
    public GameObject item;
    


    private void Start()
    {
        slider.maxValue = maxProgress;

    }
    // Update is called once per frame
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && pickUp.pickedUp)
        {
            pickUp.pickedUp = false;
            progress += 1;
            slider.value = progress;
            Debug.Log("oui");
            if (!pickUp.pickedUp)
            {
                item.SetActive(false);
            }
        }
        if (progress == 4)
        {
            repairedShip.SetActive(true);
            brokenShip.SetActive(false);
        }

    }
}