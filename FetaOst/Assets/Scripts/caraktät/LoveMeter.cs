using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoveMeter : MonoBehaviour
{
    public Transform bar;

    void Start()
    {
        
    }

    public void SetSize(float _size)
    {
        bar.localScale = new Vector3(_size, 1f);
    }

}
