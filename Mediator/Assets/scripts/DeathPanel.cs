using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DeathPanel : MonoBehaviour
{
    [SerializeField] private Button _restartBtn;

    private Mediator _mediator;
    public void Initialize(Mediator mediator)
    {
        _mediator = mediator;
    }


    private void OnEnable()
    {
        _restartBtn.onClick.AddListener(OnRestartClick);
    }

    private void OnDisable()
    {
        _restartBtn.onClick.RemoveListener(OnRestartClick);
    }


    public void Show() => gameObject.SetActive(true);

    public void Hide() => gameObject.SetActive(false);

    private void OnRestartClick() => _mediator.Restart();

}
