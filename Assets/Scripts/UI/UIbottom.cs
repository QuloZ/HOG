﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(UIHintsButton))]
public class UIbottom : MonoBehaviour
{
    [SerializeField] private GameObject textPrefab;
    [SerializeField] private GameObject questPanel;

    private List<GameObject> questItem;
    public void Init()
    {
        questItem = LevelManager.Instance.questItem;
    }

    public void FillQuestPanel()
    {
        for (int i = 0; i < questItem.Count; i++)
        {
            GameObject itemText = Instantiate(textPrefab);
            itemText.transform.SetParent(questPanel.transform);
            itemText.GetComponent<Text>().text = questItem[i].GetComponent<Item>().Name;
        }
    }
    public void ClearQuestPanel()
    {
        int count = questPanel.transform.childCount;
        for (int i = 0; i < count; i++)
        {
            Destroy(questPanel.transform.GetChild(i).gameObject);
        }
    }


}
