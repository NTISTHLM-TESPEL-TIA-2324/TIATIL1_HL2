using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
  public void DoThing()
  {
    print("hey!");
    GetComponent<Renderer>().material.color = Color.red;
  }
}
