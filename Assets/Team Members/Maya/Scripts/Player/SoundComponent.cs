using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundComponent : MonoBehaviour
{
    public delegate void SoundDelegate();
    public event SoundDelegate onCowHeard;
    public event SoundDelegate onHumanHeard;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponentInParent<CowModel>())
        {
            Debug.Log("cow heard player");
            onCowHeard?.Invoke();
        }

        if (other.gameObject.GetComponentInParent<HumanModel>())
        {
            Debug.Log("human heard player");
            onHumanHeard?.Invoke();
        }
    }
}
