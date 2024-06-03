using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Episode4 : MonoBehaviour{
    int frameCount;

    // Start is called before the first frame update
    void Start(){
        int x = 0;

        print ("Start");
    }

    // Update is called once per frame
    void Update(){
        frameCount += 1;
        print ("Update");
    }
}
