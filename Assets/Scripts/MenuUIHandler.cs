using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[DefaultExecutionOrder(1000)]
//per the tutorial, it can sometimes be helpful to load UI scripts after other scripts have loaded.
public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInput;
    private void Start()
    {
        nameInput = GameObject.Find("Name Input").GetComponent<TMP_InputField>();
    }

    private void Update()
    {
        DataManager.Instance.playerName = nameInput.text;
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }
}
