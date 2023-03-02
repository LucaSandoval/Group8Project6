using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public List<MedBox> inrangelist;
    public Text indicatorText;
    public Text objectiveText;
    public int meds;
    // Start is called before the first frame update
    void Start()
    {
        inrangelist = new List<MedBox>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inrangelist.Count > 0)
        {
            indicatorText.gameObject.SetActive(true);
        } else
        {
            indicatorText.gameObject.SetActive(false);
        }

        objectiveText.text = "Find medicine (" + meds + "/5)";
    }
}
