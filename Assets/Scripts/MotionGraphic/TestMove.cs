using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    public static TestMove instance;

    private void Start()
    {
        instance = this;
    }


    public void Move()
    {
        transform.DOMoveX(3000f, 5f);
    }

    
}
