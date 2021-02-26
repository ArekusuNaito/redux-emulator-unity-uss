using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UniRx;
using System;
using static GameActions;
public class Counter : MonoBehaviour
{
    public Button plusButton,minusButton,addAmountButton;
    public Label counterLabel;
    public TextField textField;
    public VisualElement appRoot;
    [Header("Element IDs")]
    private string labelID = "counterLabel";
    public string plusButtonID = "addButton";
    public string minusButtonID = "addButton";
    public string addAmountButtonID = "addAmountButtonID";
    public string inputBoxID = "inputAmount";
    GameState gameState;

    public void OnEnable()
    {
        
        this.gameState = GameState.Use;
        //Query Elements: getElementByID()
        appRoot = GetComponent<UIDocument>().rootVisualElement;
        //
        counterLabel = appRoot.Q<Label>(labelID);
        plusButton = appRoot.Q<Button>(plusButtonID);
        minusButton = appRoot.Q<Button>(minusButtonID);
        addAmountButton = appRoot.Q<Button>(addAmountButtonID);
        textField = appRoot.Q<TextField>(inputBoxID);

        
        var countSubscription = gameState.Count.Subscribe(count=>counterLabel.text=count.ToString());
        //
        //Listeners
        plusButton.RegisterCallback<ClickEvent>(ev=>
        {
            Increment();
        });
        minusButton.clicked += ()=>
        {
            Decrement();
        };
        addAmountButton.clicked += ()=>
        {
            IncrementByAmount(Int32.Parse(textField.text));
        };
    }
}
