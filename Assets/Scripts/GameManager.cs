using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum Platform { windows, ios, andriod };
    private Platform platform;
    private void Awake()
    {
#if UNITY_ANDROID
        platform = Platform.andriod;
#endif

#if UNITY_IPHONE
        platform = Platform.ios;
#endif

#if UNITY_STANDALONE_WIN
        platform = Platform.windows;
#endif
    }

    public Platform GetPlatform()
    {
        return platform;
    }
}
