using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    //go back to main scene when back button is pressed
    [System.Obsolete]
    public void onButtonClick()
    {
        Application.LoadLevel("Landing Scene");
    }
}
