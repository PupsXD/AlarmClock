using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DigitalClockDrag : MonoBehaviour, IPointerClickHandler
{
    public TMP_Text displayText;

    private int hours = 0;
    private int minutes = 0;

    public void OnPointerClick(PointerEventData eventData)
    {
        // Only respond to left mouse button clicks
        if (eventData.button != PointerEventData.InputButton.Left) return;

        // Toggle the clock panel on/off
        displayText.gameObject.SetActive(!displayText.gameObject.activeSelf);
    }

    private void UpdateDisplayText()
    {
        displayText.text = $"{hours:00}:{minutes:00}";
    }

    private void Update()
    {
        // Update the displayed time
        UpdateDisplayText();
    }

    public void SetHours(int value)
    {
        hours = value % 24; // Keep hours within the 24-hour range
    }

    public void SetMinutes(int value)
    {
        minutes = value % 60; // Keep minutes within the 60-minute range
    }

    public void IncrementHours(int amount)
    {
        SetHours(hours + amount);
    }

    public void IncrementMinutes(int amount)
    {
        SetMinutes(minutes + amount);
    }
}