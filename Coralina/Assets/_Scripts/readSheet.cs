using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readSheet : MonoBehaviour {


    // Update is called once per frame
    void Update() {

        getChildreen(this.transform);

    }

    Transform getChildreen (Transform child) {
        if (child.transform.childCount == 0 || child == null)
        {
            return null;
        }
        else {
            Transform Go = child;
            for (int i = 0; i < this.transform.childCount; i++)
            {
               Go = transform.GetChild(i);
               Debug.Log("name" +Go.name);
                return getChildreen(Go);

            }
            return getChildreen(Go);


        }
        
    }
    
    

    
}
