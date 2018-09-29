using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PacManScript : MonoBehaviour {
    public Tilemap Walls;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if ( Input.GetKeyDown(KeyCode.UpArrow) ) {
            transform.Translate(0, 1, 0);
        }
        if ( Input.GetKeyDown(KeyCode.DownArrow) ) {
            transform.Translate(0, -1, 0);
        }
        if ( Input.GetKeyDown(KeyCode.RightArrow) ) {
            transform.Translate(1, 0, 0);
        }
        if ( Input.GetKeyDown(KeyCode.LeftArrow) ) {
            transform.Translate(-1, 0, 0);
        }
    }
}