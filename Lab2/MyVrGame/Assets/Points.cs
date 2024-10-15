using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class SocketInteraction : MonoBehaviour
{
    public XRSocketInteractor socketInteractor50; 
    public XRSocketInteractor socketInteractor100; 
    public XRSocketInteractor socketInteractor200; 
    public XRSocketInteractor socketInteractor300; 

    public ParticleSystem particleSystem50;
    public ParticleSystem particleSystem100;
    public ParticleSystem particleSystem200;
    public ParticleSystem particleSystem300;

    public TextMeshProUGUI scoreText; 
    private int score = 0; 

    private void Start()
    {
        UpdateScoreText();
    }

    private void OnEnable()
    {
        if (socketInteractor50 != null)
        {
            socketInteractor50.selectEntered.AddListener(OnObjectPlaced50);
        }
        

        if (socketInteractor100 != null)
        {
            socketInteractor100.selectEntered.AddListener(OnObjectPlaced100);
        }
       
        if (socketInteractor200 != null)
        {
            socketInteractor200.selectEntered.AddListener(OnObjectPlaced200);
        }
     
        if (socketInteractor300 != null)
        {
            socketInteractor300.selectEntered.AddListener(OnObjectPlaced300);
        }
      
    }

   

    private void OnObjectPlaced50(SelectEnterEventArgs args)
    {
        score += 50; 
        UpdateScoreText(); 
        ActivateParticles(particleSystem50);
    }

  

    private void OnObjectPlaced100(SelectEnterEventArgs args)
    {
        score += 100; 
        UpdateScoreText(); 
        ActivateParticles(particleSystem100);
    }

   
    private void OnObjectPlaced200(SelectEnterEventArgs args)
    {
        score += 200; 
        UpdateScoreText(); 
        ActivateParticles(particleSystem200);
    }

   

    private void OnObjectPlaced300(SelectEnterEventArgs args)
    {
        score += 300; 
        UpdateScoreText(); 
        ActivateParticles(particleSystem300);
    }

 

    private void ActivateParticles(ParticleSystem particleSystem)
    {
        if (particleSystem != null)
        {
            particleSystem.Play();
        }
       
    }

    private void UpdateScoreText()
    {
        Debug.Log("Actualizarea scorului: " + score);
        if (scoreText != null)
        {
            scoreText.text = "Scor: " + score.ToString(); 
        }
       
    }
}
