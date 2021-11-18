using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class IntersitialAdExample : MonoBehaviour
{
    public string AdPlacementName;

    public void ShowInterstitalAD()
    {
        if (Advertisement.IsReady(AdPlacementName)) 
        {
            Advertisement.Show(AdPlacementName);
            Debug.Log("Showing ad " + AdPlacementName);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
