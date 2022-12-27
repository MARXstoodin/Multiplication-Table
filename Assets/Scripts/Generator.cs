using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Generator : MonoBehaviour
{
    public Text Viragenie;
    public GameObject TextCol;
    int a, b;
    string x;
    System.Random r = new System.Random();
    void Start()
    {
        NewVir();
    }
    void NewVir()
    {
        x = " ?";

        a = r.Next(2, 10);
        b = r.Next(2, 10);

        Viragenie.text = $"{a}*{b}={x}";
    }
    public void Button0()
    {
        if (x == " ?")
            x = "";
        if (x.Length == 1 )
            x += "0";
        Viragenie.text = $"{a}*{b}={x}";
    }
    public void Button1()
    {
        if (x == " ?")
            x = "";
        if (x.Length < 2)
            x += "1";
        Viragenie.text = $"{a}*{b}={x}";
    }
    public void Button2()
    {
        if (x == " ?")
            x = "";
        if (x.Length < 2)
            x += "2";
        Viragenie.text = $"{a}*{b}={x}";
    }
    public void Button3()
    {
        if (x == " ?")
            x = "";
        if (x.Length < 2)
            x += "3";
        Viragenie.text = $"{a}*{b}={x}";
    }
    public void Button4()
    {
        if (x == " ?")
            x = "";
        if (x.Length < 2)
            x += "4";
        Viragenie.text = $"{a}*{b}={x}";
    }
    public void Button5()
    {
        if (x == " ?")
            x = "";
        if (x.Length < 2)
            x += "5";
        Viragenie.text = $"{a}*{b}={x}";
    }
    public void Button6()
    {
        if (x == " ?")
            x = "";
        if (x.Length < 2)
            x += "6";
        Viragenie.text = $"{a}*{b}={x}";
    }
    public void Button7()
    {
        if (x == " ?")
            x = "";
        if (x.Length < 2)
            x += "7";
        Viragenie.text = $"{a}*{b}={x}";
    }
    public void Button8()
    {
        if (x == " ?")
            x = "";
        if (x.Length < 2)
            x += "8";
        Viragenie.text = $"{a}*{b}={x}";
    }
    public void Button9()
    {
        if (x == " ?")
            x = "";
        if (x.Length < 2)
            x += "9";
        Viragenie.text = $"{a}*{b}={x}";
    }
    public void ButtonBackspace()
    {
        if (x.Length > 0 && x != " ?")
        {
            x = x.Remove(x.Length - 1);
        }
        if (x.Length == 0)
            x = " ?";
        Viragenie.text = $"{a}*{b}={x}";
    }
    public void ButtonEnter()
    {
        if (Convert.ToInt32(x) == (a * b))
        {
            TextCol.GetComponent<Text>().color = new Color(0.2f, 0.2f, 0.2f);
            NewVir();
        }
        else
        {
            x = " ?";
            TextCol.GetComponent<Text>().color = Color.red;
        }
        Viragenie.text = $"{a}*{b}={x}";
    }
}
