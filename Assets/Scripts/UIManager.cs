using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    public PlayerMoney money;
    public TextMeshProUGUI lifeText;
    public LifeManager life;

    void Update()
    {
        moneyText.text = "money: $" + money.availableMoney.ToString();
        lifeText.text = "life: " + life.life.ToString();
    }
}
