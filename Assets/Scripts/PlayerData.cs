using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float moveSpeed;
    public float jumpForce;
    public int numberOfPlatforms;
    public PlayerData (PlayerController player, Platformer platty, GameManager gamer)
    {
        moveSpeed = player.moveSpeed;
        jumpForce = platty.jumpForce;
        numberOfPlatforms = gamer.numberOfPlatforms;
    }

}
