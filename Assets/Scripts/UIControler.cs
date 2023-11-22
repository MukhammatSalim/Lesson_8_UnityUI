using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControler : MonoBehaviour
{

    [SerializeField] public Button _button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DisableObject(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }
 }
