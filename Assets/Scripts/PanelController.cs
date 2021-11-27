using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelController : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> panels;
    void Start()
    {
        ShowPanel(panels[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowPanel(GameObject panel)
    {
        foreach (var item in panels)
        {
            item.SetActive(item == panel);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
