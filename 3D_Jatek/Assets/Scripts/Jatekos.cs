using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Jatekos : MonoBehaviour
{
    public float sebesseg;
    public float maxX;
    public float minX;
    public float Xvalt;
    private Vector3 cel;
    public GameObject szamlalo;
    private float mpSzamlalo;
    private Text szoveg;
    private float ido = 0;
    private int mp;
    public GameObject gameOver;
    public GameObject pauseMenu;
    private void Start(){
        szoveg = szamlalo.GetComponent<Text>();
        
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, cel, sebesseg * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxX)
        {
                cel = new Vector3(transform.position.x + Xvalt, transform.position.y, transform.position.z);
        }else if(Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minX)
        {
                cel = new Vector3(transform.position.x - Xvalt, transform.position.y, transform.position.z);
        }else if(Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        ido += Time.deltaTime;
        if(ido>1)
        {
            mp++;
            ido = 0;
        }
        szoveg.text = mp.ToString();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Akadaly"))
        {
            Debug.Log("Ütközés");
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Continue(){
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
}
