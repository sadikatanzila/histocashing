using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text xpText;
    [SerializeField] private Text levelText;
    [SerializeField] private GameObject menu;


    private void awake()
    {
        Assert.IsNotNull(xpText);
        Assert.IsNotNull(levelText);
        Assert.IsNotNull(menu);

    }

    public void updateLevel(int level)
    {
        levelText.text = level.ToString();
    }


    public void updateXp(int currentXP, int requireXp)
    {
        xpText.text = currentXP.ToString() + " / "+ requireXp.ToString();
    }

    public void toggleMenu()
    {
        menu.SetActive(!menu.activeSelf);
    }

    // Start is called before the first frame update
    
}
