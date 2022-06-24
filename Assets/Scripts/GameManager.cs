using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public static GameManager instance;

    [SerializeField]
    private GameObject[] characters;
    private int _selectedIndex; 
    public int SelectedIndex
    {
        get { return _selectedIndex; }
        set { _selectedIndex = value; }
    }
    private void Awake()
    {
        if ( !instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }
    private void OnLevelFinishedLoading(Scene scene , LoadSceneMode mode)
    {
        if (scene.name == "GamePlay")
            Instantiate(characters[SelectedIndex]);
        
    }
}
