using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedBox : MonoBehaviour
{
    private GameController controller;
    private bool inRange;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("Controller").GetComponent<GameController>();
    }

    private void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.E))
        {
            controller.meds++;
            controller.inrangelist.Remove(this);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inRange = true;
            if (!controller.inrangelist.Contains(this))
            {
                controller.inrangelist.Add(this);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inRange = false;
            if (controller.inrangelist.Contains(this))
            {
                controller.inrangelist.Remove(this);
            }
        }
    }
}
