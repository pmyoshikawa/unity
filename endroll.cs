using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endroll : MonoBehaviour {

 int speed = 1;
 private GameObject canvas;

void Start () {
    // TextCanvasを呼び出す
    canvas = GameObject.Find("TextA");
}

void Update () {

    // 0.05ずつy軸マイナス方向にtextを動かしていく
    transform.Translate(0,0.6f*speed,0);
    // textのy座標が-55以下になったらcanvasを削除
    if (transform.localPosition.y >= 2200) {
        Destroy(canvas);
        Application.LoadLevel("goal");

    }
}
}