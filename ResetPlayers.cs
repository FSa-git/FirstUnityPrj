using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayers : MonoBehaviour
{
    public Transform StartPoint;
    public Transform Player1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player1.position = StartPoint.position;
    }
}