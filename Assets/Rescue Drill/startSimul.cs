using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startSimul : MonoBehaviour
{
    [SerializeField] public GameObject bigMachine;
    [SerializeField] public GameObject capsule;

    public void OnButtonClick()
    {
        bigMachine.SetActive(false);
        capsule.SetActive(true);
    }

    public void OnButtonClick2()
    {
        bigMachine.GetComponent<Animator>().Play("driller");
    }
}