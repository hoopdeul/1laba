using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectToggle : MonoBehaviour
{
    public GameObject targetObject;
    public Button toggleButton;
    private bool isActive;

    private void Start()
    {
        // Проверяем и устанавливаем начальное состояние объекта
        isActive = targetObject.activeSelf;
        UpdateButton();
    }

    public void ToggleObject()
    {
        isActive = !isActive;
        targetObject.SetActive(isActive);
        UpdateButton();
    }

    private void UpdateButton()
    {
        if (toggleButton != null)
        {
            toggleButton.GetComponentInChildren<Text>().text = isActive ? "Deactivate" : "Activate";
        }
    }
}