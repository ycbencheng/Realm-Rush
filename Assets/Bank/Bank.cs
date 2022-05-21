using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bank : MonoBehaviour
{
  [SerializeField] int startingBalance = 100;

  [SerializeField] int currentBalance;
  public int CurrentBalance { get { return currentBalance; } }

  [SerializeField] TextMeshProUGUI displayBalance;

  void Awake() {
    currentBalance = startingBalance;
    updateDisplay();
  }

  public void Deposit(int amount)
  {
    currentBalance += Mathf.Abs(amount);
    updateDisplay();
  }

  public void Withdraw(int amount)
  {
    currentBalance -= Mathf.Abs(amount);
    updateDisplay();

    if(currentBalance < 0) {
      ReloadScene();
    }
  }

  void updateDisplay() {
    displayBalance.text = "Gold: " + currentBalance;
  }

  void ReloadScene() {
    Scene currentScene = SceneManager.GetActiveScene();
    SceneManager.LoadScene(currentScene.buildIndex);
  }
}
