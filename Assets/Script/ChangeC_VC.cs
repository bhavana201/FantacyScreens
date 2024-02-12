using System.Collections.Generic;
using UnityEngine;

public class ChangeC_VC : MonoBehaviour
{
    /// List to hold players
    public List<Player> players = new List<Player>();

    // Sprites for players
    public Sprite[] playerSprites;


    // Timer for sprite change interval
    public float spriteChangeInterval = 2f;
    private float timer;

    void Start()
    {
        // Create players and assign sprites
        for (int i = 0; i < 11; i++)
        {
            int spriteIndex = Random.Range(0, playerSprites.Length); // Randomly select a sprite index
            Player player = new Player(spriteIndex);
            players.Add(player);
        }

        // Start the timer
        timer = spriteChangeInterval;
    }

    void Update()
    {
        // Update timer
        timer -= Time.deltaTime;

        // If timer reaches zero, change sprites
        if (timer <= 0f)
        {
            ChangeSprites();
            timer = spriteChangeInterval;
        }
    }

    // Method to randomly change sprites of all players
    public void ChangeSprites()
    {
        foreach (Player player in players)
        {
            int spriteIndex = Random.Range(0, playerSprites.Length); // Randomly select a new sprite index
            player.ChangeSprite(spriteIndex);
        }
    }
}

public class Player
{
    // Index of sprite
    public int spriteIndex;

    // Constructor
    public Player(int index)
    {
        spriteIndex = index;
    }

    // Method to change the sprite
    public void ChangeSprite(int newIndex)
    {
        spriteIndex = newIndex;
        // Apply changes to the sprite here (e.g., update sprite renderer)
        Debug.Log("Player Sprite Index Changed to: " + spriteIndex);
    }
}



