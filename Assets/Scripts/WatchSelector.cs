using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WatchSelector : MonoBehaviour
{

    [SerializeField] 
    private GameObject[] watchModels;

    [SerializeField]
    private Button[] watchButtons;

    void Start()
    {
        if (watchButtons.Length == 0)
            return;

        for (int i = 0; i < watchButtons.Length; i++)
        {
            int a = i;
            watchButtons[i].onClick.AddListener(() => { ButtonOnClick(a); });
        }
    }

    public void ButtonOnClick(int index)
    {
        if (watchModels.Length == 0)
            return;

        watchModels[index].SetActive(true);

        for (int i = 0; i < watchModels.Length; i++)
        {
            if (i != index )
            {
                watchModels[i].SetActive(false);
            }
        }
    }
}
