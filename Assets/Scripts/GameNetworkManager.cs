using Mirror;
using UnityEngine;

public class GameNetworkManager : NetworkManager
{
    public override void OnServerAddPlayer(NetworkConnection conn)
    {
        base.OnServerAddPlayer(conn);

        NetworkPlayer player = conn.identity.gameObject.GetComponent<NetworkPlayer>();
        player.SetPlayerName($"Player {numPlayers}");
        player.SetPlayerColor(new Color(
            Random.Range(0f, 1f), 
            Random.Range(0f, 1f), 
            Random.Range(0f, 1f)
        ));
    }
}
