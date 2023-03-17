using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public float myFloat = 5.0f;
    public int myInt = 2;
    public bool myBool = false;
    private string myStr = "hello";
    public int privInt;

    public Transform CamTransform;
    public GameObject DirectionLight;
    public Transform LightTransform;

    /* this
     * is a multi line comment
     * as directed in chapter 2
     */

    /// <summary>
    /// this script shows progress for learning c#. 
    /// multiple features and basics of c# can be found here. 
    /// </summary>

    // Start is called before the first frame update
    void Start()
    {
        //ListsDicts();
        //help_debug();
        //privInt = adder(6);
        CamTransform = this.GetComponent<Transform>();
        Debug.Log(CamTransform.localPosition);

        DirectionLight = GameObject.Find("Directional Light");
        LightTransform = DirectionLight.GetComponent<Transform>();
        Debug.Log(LightTransform.localPosition);
    }


    //method, if-else-if statements
    int adder(int addInt)
    {
        int limit = addInt + addInt;

        if (limit == myInt)
        {
            if (myBool)
            {
                Debug.Log("limit met!");
            }

        }
        else if (limit > myInt)
        {
            if (myBool)
            {
                Debug.Log("limit exceeded!");
            }

        }
        else
        {
            if (myBool == !true)
            {
                Debug.Log("below limit!");
            }
        }
        return limit;
    }

    //collections
    void ListsDicts()
    {
        int[] myIntArr = { 1, 4, 6, 7, 9 };
        List<string> subjects = new List<string>()
        {
            "science",
            "defense",
            "alchemy"
        };

        Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
        {
            { "Potion", 5 },
            { "Antidote", 7 },
            { "Aspirin", 1 }
        };

        //loops:
        int subLen = subjects.Count;

        for (int i = 0; i < subLen; i++)
        {
            if (i==2)
            {
                Debug.LogFormat("Current subject at index {0} is: {1}", i, subjects[i]);
            }

        }

        foreach (string sub in subjects)
        {
            if (myBool)
            {
                Debug.LogFormat("Subject: {0}", sub);
            }
        }

        foreach (KeyValuePair<string, int> pair in ItemInventory)
        {
            Debug.LogFormat("Key: {0} maps to Value: {1}", pair.Key, pair.Value);
        }
    }
    
    //Debug and switch
    void help_debug()
    {
        int x = myInt;

        switch (x)
        {
            case 1:
                Debug.LogFormat("{0} Debugging attempt {1}!", myStr, myInt);
                break;
            case 2:
                Debug.Log(myStr + myStr);
                break;
            case 3:
                Debug.Log($"{myStr}, myInt at limit");
                break;
            default:
                Debug.Log("no match found!");
                break;

        }
    }

}

