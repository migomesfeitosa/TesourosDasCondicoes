using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FaseFinalController : MonoBehaviour
{
    private List<string> itemList = new List<string>();
    private Vector3 posicaoZero;
    public Animator animator;
    private bool bauAbre = false;
   
    void Start()
    {
        posicaoZero = transform.position;
        bauAbre = false;
    }

    private IEnumerator enumerator()
    {
        while (itemList.Count > 0)
        {
            string itemString = itemList[0];
            itemList.RemoveAt(0);

            switch (itemString)
            {
                case "0":
                   Vector3 vector3 = transform.position + Vector3.left * 0.5f;
                   transform.position = vector3;
                   break;
                case "1":
                    Vector3 vector4 = transform.position + Vector3.right * 0.5f;
                    transform.position = vector4;
                    break;
                case "2":
                    Vector3 vector5 = transform.position + Vector3.up * 0.5f;
                    transform.position = vector5;
                    break;
                case "3":
                    Vector3 vector6 = transform.position + Vector3.down * 0.5f;
                    transform.position = vector6;
                    break;
                default:
                    break;
            }
            yield return new WaitForSeconds(1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.tag == "bau")
        {
            bauAbre |= true;
            SceneManager.LoadScene("VoceGanhou");
            //Debug.Log("Completou a fase");
        }

    }

    public void cases()
    {
        StartCoroutine(enumerator());
    }

    public void case0()
    {
        itemList.Add("0");
    }
    public void case1()
    {
        itemList.Add("1");
    }
    public void case2()
    {
        itemList.Add("2");
    }
    public void case3()
    {
        itemList.Add("3");
    }
    // Update is called once per frame
    void Update()
    {
        animator.SetBool("bauAbre", bauAbre);  
    }

    public void LimparCampos()
    {
        itemList.Clear();
    }
}
