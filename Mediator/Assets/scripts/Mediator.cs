using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mediator : MonoBehaviour
{
    [SerializeField] private GamePanel _gamePanel;
    [SerializeField] private DeathPanel _deathPanel;
    [SerializeField] private Player _player;
    public void Initialize(Player player)
    {
        _player = player;
        _player.Dead += OnPlayerDead;
        _player.HealthUped += OnHealthUp;
        _player.HealthDowned += OnHealthDown;
        _player.LevelUped += OnLevelUp;

        _gamePanel.HPViewRenew(_player.PlayerHealth);
        _gamePanel.LevelViewRenew(_player.PlayerLevel);
    }


    private void OnDestroy()
    {
        _player.Dead -= OnPlayerDead;
        _player.HealthUped -= OnHealthUp;
        _player.HealthDowned -= OnHealthDown;
        _player.LevelUped -= OnLevelUp;
    }

    private void OnPlayerDead()
    {
        _gamePanel.Hide();
        _deathPanel.Show();
    }

    public void OnLevelUp()
    {
        _player.LevelUp();
        _gamePanel.LevelViewRenew(_player.PlayerLevel);
    }

    public void OnHealthUp()
    {
        _player.HealthUp();
        _gamePanel.HPViewRenew(_player.PlayerHealth);
    }

    public void OnHealthDown()
    {
        _player.HealthDown();
        _gamePanel.HPViewRenew(_player.PlayerHealth);
    }

    public void Restart()
    {
        _deathPanel.Hide();

        _player.Reborn();

        _gamePanel.HPViewRenew(_player.PlayerHealth);
        _gamePanel.LevelViewRenew(_player.PlayerLevel);
        _gamePanel.Show();
    }
}
