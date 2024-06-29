using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
   private static T instance;
   public static T Instance()
    {
        if(instance == null)
        {
            GameObject obj = new GameObject();
            obj.name = typeof(T).Name;
            DontDestroyOnLoad(obj);
            instance = obj.AddComponent<T>();
        }
        return instance;
    }

 
}
