using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class adManager : MonoBehaviour
{
    public string androidGameID;
    public string iosGameID;
    
    
    
    public bool testMode = true;

    bool adStarted = false;
    // Start is called before the first frame update
    void Start()
    {
#if UNITY_ANDROID
        Advertisement.Initialize(androidGameID, testMode);
#elif UNITY_IOS
        Advertisement.Initialize(loadGameID, testMode);
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
