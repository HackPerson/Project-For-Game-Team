using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{

    public GameObject buttonObject;
    public Text score;
    int scoreValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;
    }

    public void moveRandom() {
        scoreValue++;
        buttonObject.transform.position = new Vector2(Random.Range(0, 863), Random.Range(0, 469));
    }
}
