using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour

{
    [SerializeField] Mediator _mediator;
    [SerializeField] GamePanel _gamePanel;
    [SerializeField] DeathPanel _deathPanel;
    [SerializeField] private Player _player;
    void Awake()
    {
        _player.Initialize();
        _mediator.Initialize(_player);
        _gamePanel.Initialize(_mediator);
        _deathPanel.Initialize(_mediator);
    }

}
