using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayToGo : MonoBehaviour
{
    Vector3 startPos, endPos;
    public float MoveTime = 0.2f;
    [NonSerialized] public bool isMoving = false;
    [NonSerialized] public float _x;
    [NonSerialized] public float _y;


    // Update is called once per frame
    void Update()
    {
        if(!isMoving)
        {
            StartCoroutine(MovePlayer(new Vector3(_x, _y, 0f)));
        }
    }

    IEnumerator MovePlayer(Vector3 dir)
    {
        isMoving = true;
        float nextMove = 0f;
        startPos = transform.position;
        endPos = startPos + dir;

        while(nextMove < MoveTime)
        {
            transform.position = Vector3.Lerp(startPos, endPos, nextMove / MoveTime);
            nextMove += Time.deltaTime;
            yield return null;
        }

        _x =0; _y =0;
        transform.position = endPos;

        isMoving = false;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Void"))
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.CompareTag("Aurore Spirit"))
        {
            Destroy(gameObject);
        }
    }
}
