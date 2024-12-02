using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor;
using UnityEngine;


public class Test : MonoBehaviour
{
   public Transform[] transforms = new Transform[3];
   public float speed = 5.0f;
void Start () {
   
}
 
 private void Update() {
    for(int i = 0; i < transforms.Length; i++) {
  transforms[i].Translate(new UnityEngine.Vector3(1,0,0) * speed * Time.deltaTime);
 }       
}
}
