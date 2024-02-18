using System.Collections;
using System.Collections.Generic;
using MixedReality.Toolkit.UX;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class ClickController : MonoBehaviour
{
  PressableButton button;
  void Awake()
  {
    button = GetComponent<PressableButton>();
    button.OnClicked.AddListener(Hello);
  }

  void Hello()
  {
    print("HALLO");
  }
}
