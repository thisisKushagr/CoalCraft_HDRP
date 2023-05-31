using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSwitch : MonoBehaviour
{
    [SerializeField] public GameObject camera1;
    [SerializeField] public GameObject camera2;
    public void OnButtonClick()
    {
        camera1.SetActive(false);
        camera2.SetActive(true);
    }
}
