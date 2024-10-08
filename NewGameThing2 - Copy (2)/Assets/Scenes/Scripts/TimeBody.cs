using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBody : MonoBehaviour
{
   // bool isRewinding = false;

    public float recordTime;

    List<PointInTime> pointsInTime;

    private Vector3 ballpos = new Vector3();

    private Rigidbody2D rb;
    
    public float rate = .3f;
    
    public float next = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        pointsInTime = new List<PointInTime>();
        
        ballpos = transform.position;
        print(ballpos);
        rb = this.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        if (Input.GetKeyDown("up") && Time.time > next)
        {
            rb.AddForce(transform.up * 1f, ForceMode2D.Impulse);
            next = Time.time + rate;
        }
        else if (Input.GetKeyDown("left") && Time.time > next)
        {
            rb.AddForce(transform.right * -1f, ForceMode2D.Impulse);
            next = Time.time + rate;
        }
        else if (Input.GetKeyDown("right") && Time.time > next)
        {
            rb.AddForce(transform.right * 1f, ForceMode2D.Impulse);
            next = Time.time + rate;
        }
        
    }

   
    void Rewind()
    {
        



        /*
        if(pointsInTime.Count > 0)
        {
             PointInTime pointInTime = pointsInTime[0];
            transform.position = pointInTime.position;
            transform.rotation = pointInTime.rotation;
            pointsInTime.RemoveAt(0);


        }
        else
        {
            StopRewind();
        }
        */
    }
    void Record()
    {
        /*if(pointsInTime.Count > Mathf.Round(recordTime / Time.unscaledDeltaTime))
        {
            pointsInTime.RemoveAt(pointsInTime.Count - 0);
        }
        pointsInTime.Insert(0, new PointInTime(transform.position, transform.rotation));
        */
    }

    public void StartRewind()
    {
        transform.position = ballpos;
        print(ballpos);
        WinScript.setZero();
    }
/*
    public void StopRewind()
    {
        isRewinding = false;
    }
*/
    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            print("WaitAndPrint " + Time.time);
        }
    }
}
