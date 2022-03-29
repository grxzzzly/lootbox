using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseController : MonoBehaviour
{
    // Start is called before the first frame update
    static int score = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        score = score + 10000;
        print("ты заработал " + score + "$");
        Destroy(gameObject);
    }
}
