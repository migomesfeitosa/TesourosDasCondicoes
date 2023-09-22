using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public Animator playerAnimator;
    float input_x;
    float input_y;
    public float speed =4.5f;
    bool isWalking = false;
    bool teste = false;

    public Text contTextFaseInicial;
    public int contIntFaseInicial = 4;

    public int chaves = 0;
   
   [Header("Interact")]
   public KeyCode interactKey = KeyCode.E;
   bool canTeleport = false;
   Region tmpRegion;


    void Start()
    {
        isWalking = false;
        teste = false;   
    }

  public  void clique()
    {
        teste = true;
        if (teste)
        {
            input_x = 10;
        }
    }

    void Update()
    {

        input_x = Input.GetAxisRaw("Horizontal");
        input_y = Input.GetAxisRaw("Vertical");
        isWalking = (input_x !=0 || input_y !=0);
        
        if (isWalking)
        {
            var move = new Vector3(input_x,input_y,0).normalized;
            transform.position += move * speed * Time.deltaTime;

            playerAnimator.SetFloat("input_x",input_x);
            playerAnimator.SetFloat("input_y",input_y);

        }

        if( canTeleport )
        {
            this.transform.position = tmpRegion.warpLocation.position;
        }

        teste = false;

        playerAnimator.SetBool("isWalking",isWalking);
        
    }

    public void ContarChaves()
    {
        contIntFaseInicial -= 1;
    }

    public void AtualizaFaseInicial()
    {
        contTextFaseInicial.text = contIntFaseInicial.ToString();
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Teleport")

        {
            tmpRegion = collider.GetComponent<Teleport>().region;
            canTeleport = true;
        }

        if (collider.gameObject.tag == "bau" && chaves == 4)
        {
            SceneManager.LoadScene("FaseFinal");
        }

        if (collider.gameObject.tag == "chave")
        {
           Destroy(collider.gameObject);
            chaves++;
            ContarChaves();
            AtualizaFaseInicial();
        }

        if (collider.gameObject.tag == "voltar")
        {
            SceneManager.LoadScene("FaseInicial"); 
        }

        if (collider.gameObject.tag == "LevelUp2")
        {
            SceneManager.LoadScene("FaseFinal");
        }

    }

    private void OnTriggerExit2D(Collider2D collider)
    {

        if(collider.tag == "Teleport")

        {

            canTeleport = false;
        }
        
    }


}
