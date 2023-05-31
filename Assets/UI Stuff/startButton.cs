using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startButton : MonoBehaviour
{
    public new GameObject camera;

    private void ExecuteTrigger(string trigger)
    {
        if (camera != null)
        {
            var animator = camera.GetComponent<Animator>();
            if (animator != null)
            {
                animator.SetTrigger(trigger);
            }
        }
    }

    public void OnButtonClick()
    {
        ExecuteTrigger("Launch");
    }
}
