using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NPCDialogue : MonoBehaviour
{
    public string[] dialogueNpc;
    public int dialogueIndex;

    public GameObject dialoguePanel;
    public Text dialogueText;

    public Text nameNpc;
    public Image imageNpc;

    public Sprite spriteNpc;

    public bool readyToSpeak;
    public bool startDialogue;
    // Start is called before the first frame update
    void Start()
    {
        dialoguePanel.SetActive(false);
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
      if(Input.GetButtonDown("Fire1")&& readyToSpeak)
        {
            if (!startDialogue)
            {
                // FindObjectOfType<PlayerMoviment>().speed = 0f;
                StartDialogue();
            }
        }  
    }
    void StartDialogue()
    {
        nameNpc.text = "Moedas";
        imageNpc.sprite = spriteNpc;
        startDialogue = true;
        dialogueIndex = 0;  
        dialoguePanel.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        { 
            readyToSpeak = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            readyToSpeak = false;
        }
    }
}
