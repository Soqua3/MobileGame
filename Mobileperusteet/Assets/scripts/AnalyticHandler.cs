using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class AnalyticHandler : MonoBehaviour
{
    public static AnalyticHandler instance;
    private string currentlevel;

    bool duplicatedestroy = false;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
            duplicatedestroy = true;
        }
        AnalyticsEvent.GameStart();
    }

    void Start()
    {
        
    }

    public void sendpickUp()
    {
        Analytics.CustomEvent("One point picked up!");
        Debug.Log("One point picked up!");
    }

    public void sendpickUp5()
    {
        Analytics.CustomEvent("Five points picked up!");
        Debug.Log("Five point picked up!");
    }
    public void sceneSwitch()
    {
        Analytics.CustomEvent("Scene Switched!");
        Debug.Log("Scene Switched!");
    }
    

    
   
    

    void OnDestroy()
    {
        if (!duplicatedestroy)
        {
            AnalyticsEvent.GameOver();

        }
    }

    // Update is called once per frame

}
