using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class OnBoxClick : MonoBehaviour
{
    [SerializeField] public UnityEvent OnClickBox;
    Vector3 scaleChange = new Vector3(0.1f, 0.1f, 0.1f);
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        gameObject.transform.localScale += scaleChange;
        OnClickBox.Invoke();
    }
    void OnMouseUp()
    {
        gameObject.transform.localScale -= scaleChange;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
