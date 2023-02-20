using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI RunsText;
    [SerializeField]
    private TextMeshProUGUI WicketsText;

    int Runs, Wickets;

    private void Start()
    {
        Runs = 0;
        Wickets = 0;
        RunsText.text = "0";
        WicketsText.text = "/ 0";
    }

    public void Button_AddRuns_1()
    {
        Runs += 1;
        SetText(Runs, Wickets);
    }

    public void Button_AddRuns_4()
    {
        Runs += 4;
        SetText(Runs, Wickets);
    }

    public void Button_AddRuns_6()
    {
        Runs += 6;
        SetText(Runs, Wickets);
    }

    public void Button_AddWicket_1()
    {
        Wickets += 1;
        SetText(Runs, Wickets);
    }

    public void Button_Reset()
    {
        Runs = 0;
        Wickets = 0;
        SetText(Runs, Wickets);
    }


    private void SetText(int runs, int wickets )
    {
        RunsText.text = runs.ToString();
        WicketsText.text = "/ " + wickets.ToString();
    }
}
