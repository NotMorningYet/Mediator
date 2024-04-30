using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GamePanel : MonoBehaviour
{
    [SerializeField] private Button _levelUpBTN;
    [SerializeField] private Button _healthUpBTN;
    [SerializeField] private Button _healthDownBTN;

    [SerializeField] private TextMeshProUGUI _levelView;
    [SerializeField] private TextMeshProUGUI _healthView;

    private Mediator _mediator;
    public void Initialize(Mediator mediator)
    {
        _mediator = mediator;
    }


    private void OnEnable()
    {
        _levelUpBTN.onClick.AddListener(OnLevelUpPress);
        _healthUpBTN.onClick.AddListener(OnHealthUpPress);
        _healthDownBTN.onClick.AddListener(OnHealthDownPress);
    }

    private void OnDisable()
    {
        _levelUpBTN.onClick.RemoveListener(OnLevelUpPress);
        _healthUpBTN.onClick.RemoveListener(OnHealthUpPress);
        _healthDownBTN.onClick.RemoveListener(OnHealthDownPress);
    }


    public void Show() => gameObject.SetActive(true);

    public void Hide() => gameObject.SetActive(false);

    private void OnLevelUpPress() => _mediator.OnLevelUp();
    private void OnHealthUpPress() => _mediator.OnHealthUp();
    private void OnHealthDownPress() => _mediator.OnHealthDown();

    public void HPViewRenew(int hpNew) 
    {
        _healthView.text = "HP: " + hpNew.ToString();
    }

    public void LevelViewRenew(int hpNew)
    {
        _levelView.text = "Level: " + hpNew.ToString();
    }
}
