using System;
using Mirror;
using UnityEngine;

public class NetworkPlayer : NetworkBehaviour
{
    [SyncVar][SerializeField] private String _playerName;
    [SyncVar][SerializeField] private Color _playerColor;

    [Server]
    public void SetPlayerName(String playerName)
    {
        _playerName = playerName;
    }
    
    public void SetPlayerColor(Color playerColor)
    {
        _playerColor = playerColor;
    }
}
