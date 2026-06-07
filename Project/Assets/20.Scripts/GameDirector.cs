using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    public GameObject timeText;

    float time = 60.0f;

    void Update()
    {
        if (time < 0)
        {
    #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
    #else
            Application.Quit();
    #endif
            return;
        }

        time -= Time.deltaTime;
        timeText.GetComponent<TextMeshProUGUI>().text =
            "Time :" + time.ToString("F1");
    }
}
